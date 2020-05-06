using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    class MainProcess
    {
        #region Event Handle
        public event EventHandler<ProcessEventArgs> ProcessCompleted;
        public event EventHandler Error;

        protected virtual void OnProcessCompleted(ProcessEventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
        #endregion

        #region Find Method
        public List<int> findInText(string pattern, string text)
        {
            List<int> result = new List<int>();
            Regex rx = new Regex(pattern);
            foreach (Match match in rx.Matches(text))
            {
                result.Add(match.Index);
            }
            return result;
        }

        public List<int> findInFile(string pattern, string filePath)
        {
            bool a = checkFileExtension(filePath);
            if (!a)
            {
                Console.WriteLine(a);
                throw new Exception("File extension is not valid!");
            }
            string text = File.ReadAllText(filePath);
            return findInText(pattern, text);
        }

        public List<int> findInLargeFile(string pattern, string filePath)
        {
            bool a = checkFileExtension(filePath);
            if (!a)
            {
                Console.WriteLine(a);
                throw new Exception("File extension is not valid!");
            }
            string[] lines = File.ReadAllLines(filePath);
            List<int> result = new List<int>();
            foreach (string line in lines)
            {
                result.AddRange(findInText(pattern, line));
            }
            return result;
        }

        private bool checkFileExtension(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            
            string[] validExtensions = { ".txt", ".html"};
            
            Console.WriteLine(validExtensions.Contains(extension)+"aaa");
            return validExtensions.Contains(extension);
        }
        #endregion
    }
}
