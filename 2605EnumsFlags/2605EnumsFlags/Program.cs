using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2605EnumsFlags
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO.FileAttributes
            FileFlags fileState = FileFlags.Directory | FileFlags.Encrypted;
            if (fileState.HasFlag(FileFlags.Directory))
            {
                // this is a directory
            }
            Console.WriteLine(fileState);
        }
    }
}
