using System;
using System.IO;
using System.Text;

namespace ComsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; // лічильник слів, де d стоїть на 2-му місці
            string line; // допоміжний рядок
            char[] separator = {' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/'}; // масив
            StringBuilder otvet = new StringBuilder(); // рядок-відповідь

            using (StreamReader MyFile = new StreamReader("text.txt"))
            {
                bool wordWithTHeSecondD = false;
                // читання рядка з файлу, поки це можливо
                while ((line = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine(line); // друкуємо, що прочитали
                    //виділяємо слова Москаленко А.С.
                    string[] words = line.Split(separator);
                    foreach(string word in words)
                    {
                        if (word[1].Equals('d'))
                        {
                            wordWithTHeSecondD = true;
                        }
                    }
                }

                if (wordWithTHeSecondD)
                {
                    Console.WriteLine("file:text\nThere are words with the second d");
                }
                else
                {
                    Console.WriteLine("file:text\nThere aren't words with the second d");
                }
            }

            using (StreamReader numbers = new StreamReader("new.txt"))
                {
                    bool hasnonDigit = false;
                    while ((line = numbers.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        string[] words = line.Split(" ");
                        foreach (string slovo in words)
                        {
                            
                            for (int i = 0; i < slovo.Length; i++)
                            {
                                if (!Char.IsDigit(slovo[i]))
                                {
                                    hasnonDigit = true;
                                }
                            }
                        }
                    }

                    if (hasnonDigit)
                    {
                        Console.WriteLine("File new consist of nondigit words");
                    }
                    else
                    {
                        Console.WriteLine("File new consist of digit words");
                    }
                }

            using (StreamReader em = new StreamReader("empty.txt"))
                {
                    if (em.ReadLine() == null)
                    {
                        Console.WriteLine("File empty is empty");
                    } else {
                        Console.WriteLine("File empty isn't empty");
                    }
                }
            
        }
    }
}
