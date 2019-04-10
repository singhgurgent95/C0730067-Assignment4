using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730067
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
        }
        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            //Read file using StreamReader.Reads fil line by line
            using (StreamReader file = new StreamReader(@"U:\Users\730067\beowulf.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln=file.ReadLine())!=null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File has {counter}lines.");
            }
        }

    }
}
