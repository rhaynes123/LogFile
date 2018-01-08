using System;
using System.IO;

namespace LogFile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"tests.txt");
                streamReader.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                StreamWriter writeLogfile = new StreamWriter(@"test.txt");
                //Console.WriteLine(ex.StackTrace);
            }
            if (streamReader != null)
            {
                streamReader.Close();

            }
        }
    }
}
