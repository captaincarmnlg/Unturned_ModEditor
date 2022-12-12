using System.Text.RegularExpressions;

namespace Core
{
    public class Parser
    {
        public Dictionary<string,string> parseRaw(string data)
        {
            var result = new Dictionary<string,string>();
            Regex keyvalue = new Regex("(?<key>[\\w\\d]+)[ ]+(?<value>.+)");
            Regex key = new Regex("^(?<key>[\\w\\d]+)[ ]*$", RegexOptions.Multiline);
            MatchCollection keyvaluematch = keyvalue.Matches(data);
            MatchCollection keymatch = key.Matches(data);
            foreach (Match item in keymatch)
            {
                result.Add(item.Groups["key"].Value, "True");
            }
            foreach (Match item in keyvaluematch)
            {
                result.Add(item.Groups["key"].Value, item.Groups["value"].Value);
            }
            return result;
        } 

    }
}