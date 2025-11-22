using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PlatonovMV.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path, Encoding.UTF8);

            StringBuilder sb = new StringBuilder();
            StringBuilder currentWord = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                bool isRusLetter =
                    (c >= 'А' && c <= 'Я') ||
                    (c >= 'а' && c <= 'я') ||
                    c == 'Ё' || c == 'ё';

                if (isRusLetter)
                {
                    currentWord.Append(c);
                }
                else
                {
                    if (currentWord.Length > 0)
                    {
                        sb.Append("слово");
                        currentWord.Clear();
                    }

                    sb.Append(c);
                }
            }

            if (currentWord.Length > 0)
            {
                sb.Append("слово");
            }

            string resultText = sb.ToString();

            
            string tempDir = Path.GetTempPath();
            string outPath = Path.Combine(tempDir, "OutPutDataFileTask7V24.txt");

            File.WriteAllText(outPath, resultText, Encoding.UTF8);

            return outPath;
        }
    }
}