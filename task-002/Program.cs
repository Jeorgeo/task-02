using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace task_002
{
    class Program
    {
        static async Task Main()
        {
            
            {
                await ReadAndDisplayFilesAsync();
            }

            static async Task<string> ReadAndDisplayFilesAsync()
            {
                string filename = @"C:\Users\CooLer\source\repos\task-02\task-002\fragment.txt";
                char[] buffer;

                using (var sr = new StreamReader(filename))
                {
                    buffer = new char[(int)sr.BaseStream.Length];
                    await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);

                }

                return new string(buffer);

                
            }

            string text = await ReadAndDisplayFilesAsync();



            string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sentence in sentences)
            {
                string s = String.Concat(sentence.Trim(), ".");

                Console.WriteLine(s);
            }

            
        }

    }

            
            
}  
    
        



