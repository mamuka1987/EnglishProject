using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NewEnglishMegaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var directories = Directory
                .GetDirectories(@"C:\Users\conference-pc\source\repos\SecretRepo")
                .Where(x => !x.Contains("git"));


            var list = new List<List<string>>();
            foreach (var item in directories)
            {
                var files = Directory.GetFiles(item).ToList();
                list.Add(files);
            }
            var filesPath = directories.SelectMany(x => Directory.GetFiles(x)).ToList();
            var lines = filesPath.SelectMany(x => File.ReadAllLines(x));
            var dividedManyLines = lines.Select(x => x.Split('/'));
            var translateSources = dividedManyLines.Select(x => new TranslateSource(x.First(), x.Last()));
            var martivia = translateSources.Where(x => x.English.Contains("will"));









        }
    }
}
