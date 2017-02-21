using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Ch04_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Error : You must specify the URL to be downloaded");
                Console.WriteLine("Ch04_Downloader.ext <URL> <FileName>");
                return;
            }

            string url = args[0];
            string fileName = args[1];

            WebClient wc = new WebClient();
            wc.DownloadFile(url, fileName);
        }
    }
}
