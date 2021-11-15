using System;
using System.Threading;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EstacaoMeteorologica estacaoMeteorologica = new EstacaoMeteorologica();
            NovasAgesciasNoticias agn1 = new NovasAgesciasNoticias("Agencia 1");
            NovasAgesciasNoticias agn2 = new NovasAgesciasNoticias("Agencia 2");
            NovasAgesciasNoticias agn3 = new NovasAgesciasNoticias("Agencia 3");
            estacaoMeteorologica.Anexar(agn1);
            estacaoMeteorologica.Anexar(agn2);
            estacaoMeteorologica.Anexar(agn3);
            while (true)
            {
                estacaoMeteorologica.temperatura = new Random().Next(25,40);
                Console.WriteLine();
                Thread.Sleep(20000);
            }


           
        }
    }
}
