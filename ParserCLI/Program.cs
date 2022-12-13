using Core.Context.Models;
using Core.Utils;
using ParserCLI;

Console.WriteLine(@"
    Used for debugging & testing current core version
    
    This 'script' executes core functions on predefined modlib
    Only usable on direct modfiles. does not yet differ between filetypes.

    Override current mod directory? 
    Input directory OR enter to continue... :
");

string? moddir = "C:\\Users\\theme\\source\\repos\\Unturned_ModEditor\\Mods\\Weapons\\2857695278\\The Great Hsi-Ku Arsenal\\Attachments";
string? dir = Console.ReadLine();

if ( dir is not null && dir != String.Empty ) moddir = dir.ToString();

Console.WriteLine("Processing {0}", moddir);
var files = FileProcessor.Process(moddir);


Console.WriteLine("Reading list...");
Dictionary<string, string> fileContents = new Dictionary<string, string>();
foreach (var file in files)
{
    fileContents.Add(file, await FileProcessor.ReadFile(file));
}

Dictionary<string, ParsedItemUnit> modInfo = new Dictionary<string, ParsedItemUnit>();
Console.WriteLine("Parsing files...");
foreach (var file in fileContents)
{
    Console.WriteLine("Parsing {0}", file.Key);
    var contents = (new Parser()).parseRaw(file.Value);
    Console.WriteLine(@"Done reading file. found content:
    Count: {0},
    Keys {1},
    Values {2}", contents.Count, contents.Keys.Count, contents.Values.Count);

    if (file.Key.EndsWith("English.dat"))
    {
        var trans = new Translation()
        {
            Lang = file.Key.Split('\\').Last().Split('.').First(),
            MetaData = new Core.Context.Models.MetaData()
            {
                Name = contents.GetValueOrDefault(nameof(MetaData.Name)) ?? String.Empty,
                Description = contents.GetValueOrDefault(nameof(MetaData.Description)) ?? String.Empty,
            }
        };

        var filePath = file.Key.Split('\\');
        if (modInfo.ContainsKey(
            filePath[filePath.Length - 2]
            ))
            modInfo[filePath[filePath.Length - 2]].Translations.Add(trans);
        else modInfo.Add(
            filePath[filePath.Length - 2],
            new ParsedItemUnit()
            {
                Translations = new List<Translation> { trans }
            });
    }
    else
    {
        var filePath = file.Key.Split('\\');
        if (modInfo.ContainsKey(
            filePath[filePath.Length - 2]
            ))
        {
            modInfo[filePath[filePath.Length - 2]].Mod = filePath[filePath.Length - 2];
            modInfo[filePath[filePath.Length - 2]].Contents = contents;
        }
        else modInfo.Add(
            filePath[filePath.Length - 2],
            new ParsedItemUnit()
            {
                Mod = filePath[filePath.Length - 2],
                Contents = contents,
            });
    }

}

Console.WriteLine("Finished");

Console.WriteLine(@"
    Output modinfo to console?
    Y/n | default Y,
");

string? outputToCon = Console.ReadLine();
switch ((outputToCon ?? "Y").ToUpper())
{
    case "Y":
        await OutputModInf(modInfo);
        break;
    case "N":
        break;
    default:
        await OutputModInf(modInfo);
        break;
}

async Task OutputModInf(Dictionary<string, ParsedItemUnit> modInfo)
{
    string final = String.Empty;
    foreach (var mod in modInfo)
    {
        final +=
@$"
{mod.Key} {{
    Content {{
        {ContentsToString(mod.Value.Contents)}
    }}
    Translations {{
        Count: {mod.Value.Translations.Count}
        {TranslationsToString(mod.Value.Translations)}
    }}
}}";
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(".\\", "Output.txt")))
        {
            await outputFile.WriteAsync(final);
        }

        Console.WriteLine(final);
    }
}

string ContentsToString(Dictionary<string, string> contents)
{
    string output = String.Empty;
    foreach (var item in contents)
    {
        output +=
@$"{item.Key}: {item.Value}
        ";
    }
    return output;
}

string TranslationsToString(List<Translation> translations)
{
    string output = String.Empty;
    foreach (var item in translations)
    {
        output += 
@$"{item.Lang} {{
            Name: {item.MetaData.Name}
            Description: {item.MetaData.Description}
        }}
        ";
    }
    return output;
}