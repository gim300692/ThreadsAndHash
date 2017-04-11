using System;

namespace ThreadsAndHash
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = args[0];
            string partSize = args[1];
            
            InputFile file = new InputFile(path, partSize);

            file.Run();

            Console.ReadKey();
        }
    }
}
