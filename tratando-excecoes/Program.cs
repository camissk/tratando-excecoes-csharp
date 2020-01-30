using System;
using tratando_excecoes.Entities.Exceptions;
using tratando_excecoes.Entities;

namespace testando_excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Numero do quarto: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("CheckIn data: (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("CheckOut data: (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva: ");
                Console.Write("CheckIn data: (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("CheckOut data: (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reserva: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva! " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Formato incorreto! " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado " + e.Message);
            }
        }
    }
}