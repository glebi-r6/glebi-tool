using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace Updater
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileDownload = "https://github.com/davld122/glebi-Update-exe/releases/download/2.1.2/2.1.2-Setup.exe";

            string updatePath, updateFileName, processID;

            Console.ForegroundColor = ConsoleColor.Magenta;

            updatePath = args[0].ToString();
            updateFileName = args[1].ToString();
            processID = args[2].ToString();

            Process.GetProcessById(Convert.ToInt32(processID)).Kill();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(updatePath);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Path (Do not change files location)");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine(updateFileName);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("File Name");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine(processID);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Process - ID");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("Join Discord For Update Notification");
            Console.ForegroundColor = ConsoleColor.Cyan;

            using (WebClient wc = new WebClient())
            
            try
                {
                    {
                        wc.DownloadFile(fileDownload, updatePath + "\\2.1.2-Setup.exe");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Updating...");
                        Thread.Sleep(3000);
                        Console.Clear();
                    }

                    File.Delete(updatePath + "\\" + updateFileName);

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Successfully Updated");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Lookup Changes In Settings");
                    Console.WriteLine("");          
                    Console.WriteLine("");
                    Console.WriteLine("Press Any Key To Close..");

                    Console.ReadKey();

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Installer Will Be Started");
                    Thread.Sleep(2000);

                    Process.Start(@"C:\Program Files\Glebi-tool\2.1.2-Setup.exe");

                }
            catch
                {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("No Update Found");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You are on the latest version (2.1.1)");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Press Any Key To Close..");

                Console.ReadKey();

                Process.Start(@"C:\Program Files\Glebi-tool\glebi-tool 2.1.1.exe");
            }
        }
    }
}
