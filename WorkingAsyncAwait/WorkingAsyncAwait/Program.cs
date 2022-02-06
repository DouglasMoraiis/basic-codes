using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingAsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                Async : É usado na declaração de um método;
                Await : É usado na chamada de uma método;

                Quando um método que contem await é chamado,
                uma nova thread é criada e fica aguardando a finalização
                desse método naquele determinado ponto.

                Ao mesmo tempo que a thread principal que executou o
                método async que contem o await ira continuar a sua 
                execução normalmente.
            
                Logo, após o método await resolver ele continua os
                demais passos do método async encerrando a thread no
                fim da execução.
                
            */
        }
    }
}
