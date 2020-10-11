using System;
using System.IO;

namespace HelloWorld
{
    internal class HighScore
    {
        public string Name { get; set; }

        public int Score { get; set; }
    }

    internal class ReadingWritingFiles
    {
        public void WritingFile(string path)
        {
            var content = "Hello persistent file storage world";
            File.WriteAllText(path, content);
            var fileContent = File.ReadAllText(path);
            Console.WriteLine(fileContent);

            var data = new string[2] {"This is line 1.", "This is line 2."};
            File.WriteAllLines(path, data);
            var fileData = File.ReadAllLines(path);
            foreach (var item in fileData)
                Console.WriteLine(item);
        }

        public void Test()
        {
            WritingFile("test.txt"); // the folder contains .exe file
        }
    }
}