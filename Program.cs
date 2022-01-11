using System;
using System.IO;
using System.Configuration; 

namespace File_IO_Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var textFilePathWithConfig = ConfigurationManager.AppSettings["ConfigurationFile"];
            string textFilePath = $"C:\\Users\\Linoy Ben Shitrit\\source\\repos\\File_IO_Example\\File_IO_Example\\Files\\textFileDemo.txt";
            WriteToFile(textFilePath, "Hi Dana!");
            ReadFromFile(textFilePath);
        }

        public static void WriteToFile(string textFilePath, string input)
        {
            File.WriteAllText(textFilePath, input);
        }

        public static void ReadFromFile(string textFilePath)
        {
            foreach (string content in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine(content);
            }
        }

        public static string GetInputValueToWrite(string value)
        {
            if (value != null)
            {
                return value;
            }

            else
            {
                return "We have nothing to write, please try again!";
            }
        }

    }
}
