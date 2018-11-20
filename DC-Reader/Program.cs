using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DC_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reads all file names in selected directory tree.");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            string ext = GetExtension();
            string sourcePath = GetSourcePath();
            string destPath = GetDestinationPath();

            List<string> Lines = new List<string>();

            var fileNames = Directory.GetFiles(sourcePath, ext, SearchOption.AllDirectories).Select(Path.GetFileName);

            foreach (var fileName in fileNames)
            {
                Console.WriteLine(fileName);
                var firstIndex = fileName.IndexOf("_20");
                var add = fileName.Substring(firstIndex + 1, 8);
                var year = add.Substring(0, 4);
                var month = add.Substring(4, 2);
                var day = add.Substring(6, 2);

                var line = $@"{fileName}, {day}.{month}.{year}";

                Lines.Add(line);
            }

            File.WriteAllLines(destPath, Lines);
            Console.WriteLine("___________________________");
            Console.WriteLine("Pomyślnie zapisano do pliku");
            Console.ReadLine();
        }

        public static string GetSourcePath()
        {
            string path = @"";
            string source = "";

            Console.WriteLine("Podaj sciezke folderu zrodlowego:");
            source = Console.ReadLine();
            path = $@"{source}";

            return path;
        }

        public static string GetDestinationPath()
        {
            string path = @"";
            string source = "";
            string name = "";

            Console.WriteLine("Podaj sciezke dla pliku docelowego:");
            source = Console.ReadLine();
            Console.WriteLine("Podaj nazwe dla pliku docelowego:");
            name = Console.ReadLine();
            path = $@"{source}\{name}.txt";

            return path;
        }

        public static string GetExtension()
        {
            string path = @"";
            string source = "";

            Console.WriteLine("Podaj rozszezenie pliku bez dodatowych znaków! Przyklad txt, avi, itp");
            Console.WriteLine("Wpisz rozszezenie:");
            source = Console.ReadLine();
            path = $@"*.{source}";

            return path;
        }
    }
}
