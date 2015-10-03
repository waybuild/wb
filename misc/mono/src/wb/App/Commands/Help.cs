using System;
using wb.App.Messages;
using wb.Utils;

namespace wb.App.Commands
{
    public class Help : ICommand
    {
        public Help(Args args)
        {
        }

        public void Run()
        {
            Console.WriteLine(new HelpMsg().TransformText());
        } 
    }
}