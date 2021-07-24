using System;

namespace ThirdPartyTools
{
    //Implemented Open and closed Priciple.
    public interface IFileDetails
    {
        string Version(string filePath);
        int size(string filePath);
    }

    public class FileDetails:IFileDetails
    {
        private readonly Random _random = new Random();

        public string Version(string filePath)
        {
            return string.Format("{0}.{1}.{2}", _random.Next(5), _random.Next(8), _random.Next(22));
        }

        public int size(string filePath)
        {
            return _random.Next(100000) + 1000000;
        }

       
    }
}
