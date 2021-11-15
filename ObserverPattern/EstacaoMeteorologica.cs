using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class EstacaoMeteorologica : ISubject
    {
        private List<IObserver> observers;
        private double _temperatura;
        public double temperatura
        {
            get
            {
                return _temperatura;

            }
            set
            {
                _temperatura = value;
                Notificar();
            }
        }
        public EstacaoMeteorologica()
        {
            observers = new List<IObserver>();
        }
        public void Anexar(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notificar()
        {
            var now = DateTime.Now;
            Console.WriteLine($"Notificação Dia {now.Date.ToShortDateString()} as {now.Hour}:{now.Minute}:{now.Second} ");
            observers.ForEach(observer =>
            {
                observer.Atualizar(this);
            });
        }
    }
}
