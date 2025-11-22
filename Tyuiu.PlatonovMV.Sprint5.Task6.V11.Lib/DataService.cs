using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PlatonovMV.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            char[] separators = { ' ', '\t', '\r', '\n', ',', '.', ';', ':', '!', '?', '\"', '\'', '(', ')', '[', ']', '{', '}' };

            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = words.Count(w => w.Length == 6);

            return count;
        }
    }
}