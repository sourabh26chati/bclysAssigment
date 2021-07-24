using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                FileDetails objFileDetails = new FileDetails();
                
                //Task-1 
                if(args[0].ToString().Replace("'","").Equals("-v"))
                {
                    string strResponse=objFileDetails.Version(args[1]);
                    Console.WriteLine(strResponse);
                    Console.ReadLine();
                }

                //Task-2
                if(args[0].ToString().Replace("'", "") == "-v"||args[0].ToString().Replace("'", "") == "--v"||args[0].ToString().Replace("'", "") == "/v"||args[0].ToString().Replace("'", "") == "--version")
                {
                    string strResponsev = objFileDetails.Version(args[1]);
                    Console.WriteLine(strResponsev);
                    Console.ReadLine();
                }
                else if(args[0].ToString().Replace("'", "") == "-s" || args[0].ToString().Replace("'", "") == "--s" || args[0].ToString().Replace("'", "") == "/s" || args[0].ToString().Replace("'", "") == "--size")
                {
                    int strResponsev = objFileDetails.size(args[1]);
                    Console.WriteLine(strResponsev);
                    Console.ReadLine();
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.ReadLine();
            }
        }
    }
}
