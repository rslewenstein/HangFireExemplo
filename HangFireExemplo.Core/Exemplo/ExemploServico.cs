using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HangFireExemplo.Core.Exemplo
{
    public interface IExemploServico
    {
        void RunDemoTask();
    }

   public class ExemploServico : IExemploServico
    {
        public void RunDemoTask()
        {
            Console.WriteLine("Task executada!");
        }
    }
}
