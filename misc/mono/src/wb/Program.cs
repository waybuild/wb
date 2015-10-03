using System;
using System.Diagnostics;
using wb.App;

namespace wb
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new Args(args).Command.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); //todo:logs
                Debugger.Break(); 
            }
        }        
    }
}
