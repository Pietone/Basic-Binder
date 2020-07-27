using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * SOURCE CODE BY: PIETONE :D
             * 
             * DISCLAIMER!!!
             *  This was made by PIETONE who is studying C# at the time of this writing
             *  PIETONE used and is currently studying C# for just about 3 days, PIETONE has little programming knowledge
             *  at the time of writing this program.
             * 
             * hardcode app location on device
             * e.g. "c:\\example_dir\example.exe"
            */
            string _proc1Name = "";
            string _proc2Name = "";

            Console.Write("Drag and drop 1st file [ENTER] : ");
            _proc1Name = Console.ReadLine();

            Console.Write("Drag and drop 2nd file [ENTER] : ");
            _proc2Name = Console.ReadLine();

            try
            {
                Process _proc1 = new Process();

                _proc1.StartInfo.FileName = _proc1Name;
                Process _proc2 = new Process();

                _proc2.StartInfo.FileName = _proc2Name;

                _proc1.Start();
                _proc2.Start();
                _proc1.WaitForExit();
                _proc2.WaitForExit();
            }

            catch (Exception e)
            {
                Console.WriteLine($"An Error Occured, ( MAKE SURE YOU DRAGED AND DROPED CORRECTLY! ) || ERROR: {e}");
                Console.ReadLine();
            }
        }
    }
}
