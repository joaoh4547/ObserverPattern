using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern
{
    public class NovasAgesciasNoticias : IObserver
    {
        public string NomeAgencia { get; set; }
        public NovasAgesciasNoticias(string NomeAgencia)
        {
            this.NomeAgencia = NomeAgencia;
        }
        public void Atualizar(ISubject subject)
        {
            if (subject is EstacaoMeteorologica estacao)
            {
                var temp = estacao.temperatura;
                Console.WriteLine($"{NomeAgencia} reportando a temperatura {temp} graus celcius");
                Console.WriteLine("-------------------------------");
            }
            return;
        }
    }
}
