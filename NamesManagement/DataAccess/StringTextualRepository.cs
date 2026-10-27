using System;
using System.Collections.Generic;
using System.Text;

namespace NamesManagement.DataAccess
{
    public class StringsTextualRepository
    {

        private static readonly string Separator = Environment.NewLine;
        public List<string> Read(string filePath)
        {
            string fileContents = File.ReadAllText(filePath);
            return fileContents.Split(Separator).ToList();

        }
        public void Write(string filePath, List<string> strings)
        {
            File.WriteAllText(filePath, string.Join(Separator, strings));
        }

    }
}
