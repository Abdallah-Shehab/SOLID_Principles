using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class FileProcessor
    {
        private FileReader _fileReader;
        private FileWriter _fileWriter;
        public FileProcessor(FileReader _fileReader, FileWriter _fileWriter)
        {
            this._fileReader = _fileReader;
            this._fileWriter = _fileWriter;
        }
        public void ProcessFile(string inputFilePath, string outputFilePath)
        {
            string fileContent = _fileReader.ReadFile(inputFilePath);
            // Process the file content
            _fileWriter.WriteFile(outputFilePath, fileContent);
        }
    }
    public class FileReader
    {
        public string ReadFile(string filePath)
        {
            // Code to read file content
            return "File content";
        }
    }
    public class FileWriter
    {
        public void WriteFile(string filePath, string content)
        {
            //  Code to write file content
        }
    }
}
