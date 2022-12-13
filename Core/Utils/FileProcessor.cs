using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public static class FileProcessor
    {
        public async static Task<string> ReadFile(string path)
        {
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(path))
                {
                    Console.WriteLine("Reading file {0}", path);
                    // Read the stream as a string, and write the string to the console.
                    return await sr.ReadToEndAsync();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public static List<string> Process(string path)
        {
            if (File.Exists(path))
                return new List<string> { ProcessFile(path) };
            else if (Directory.Exists(path))
                return ProcessDir(path);
            else
                Console.WriteLine("{0} is not a valid file or directory.", path);
            throw new FileNotFoundException();
        }

        internal static string ProcessFile(string path)
        {
            Console.WriteLine("File found '{0}'", path);
            return path;
        }

        internal static List<string> ProcessDir(string targetDirectory)
        {
            List<string> files = new List<string>();

            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                files.Add(ProcessFile(fileName));

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                files.AddRange(ProcessDir(subdirectory));

            return files;
        }
    }
}
