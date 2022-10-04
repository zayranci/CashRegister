using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterProgram
{
    class ClassFileRegister {
        public static List<string> fileList = new List<string>();
        public static List<string> writeList = new List<string>();
        
        public static void CashRegisterRead()
        {
            string[] myText = File.ReadAllLines(@"Text\\cashRegister.txt");
            foreach(string lineText in myText)
            {
                fileList.Add(lineText);
            }
        }
        public static void CashRegisterWrite()
        {
            string fileName = @"Text\\cashResultWrite.txt";
            StreamWriter writer = new StreamWriter(fileName);
            for(int i = 0; i < writeList.Count; i++)
            {
                writer.Write(writeList[i]);
                if (writeList[i] !="\n" && writeList[i] != "Output:" && writeList[i+1] != "\n")
                {
                    writer.Write(",");
                }
            }
            writer.Dispose();
           
       
        }

    }
}
