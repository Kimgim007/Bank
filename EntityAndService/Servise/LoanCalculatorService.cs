using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAndService.Entity
{
    public static  class LoanCalculatorService
    {
        public static void Calculate(double sumCredit, int NumberOfMonths, double interestRate)
        {
            double P = interestRate / 100 / 12;

            double shareOfTheInterestRate = Math.Pow((1 + P), interestRate);

            double AmountOfPayment = sumCredit * (P + (P / (shareOfTheInterestRate - 1)));

            double R = sumCredit;

           
            Console.WriteLine($"Выплата в месяц {Math.Round(AmountOfPayment, 4)}");
            Console.WriteLine();
            for(int i = 0; i < NumberOfMonths; i++)
            {
                double Remainder = R - AmountOfPayment + (R * P);
               
                    Console.WriteLine($"Остатако на {i + 1}-й месяц {Math.Round(Remainder, 4)}");
                
                R = Remainder;
            }         
        }
    }
}
