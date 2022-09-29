using EntityAndService.Entity;
using EntityAndService.Expensive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityAndService.Servise
{
    public class LoanManagerService
    {
        public LoanManagerService() { }

        private double[] LoanRate = new double[] { 10, 11.5, 13.4 };

        private static List<Loan> userLoans = new List<Loan>();

        UserService userService = new UserService();

        public void SuggestLoan()
        {
            Console.WriteLine("Введте email");
            string email = Console.ReadLine();

            bool answer = userService.UserExists(email);
            if (answer == false)
            {
                throw new ObjectExistsException(email);
            }

            Console.WriteLine("Введите сумму кредита");
            double loanAmount = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяцы");
            int loanTerm = Int32.Parse(Console.ReadLine());


            double loanRate = 0;
            answer = true;
            while (answer)
            {

                Console.WriteLine("Выберите процентную ставку ");

                foreach (var item in LoanRate)
                {
                    Console.WriteLine($"{item}%");
                }

                Console.WriteLine("Введите процентную ставку");
                loanRate = Double.Parse(Console.ReadLine());

                var _loanRate = LoanRate.FirstOrDefault(x => x == loanRate);

                if (_loanRate != 0)
                {
                    Console.WriteLine("Процентная ставка принята");
                    answer = false;
                }
                else
                {
                    Console.WriteLine("Такой процентной ставки нет , введите другую");              
                }
            }
 
            LoanCalculatorService.Calculate(loanAmount, loanTerm, loanRate);
            Console.WriteLine("Вас устраивает такой план выплат , введите Да или Нет?");
            string YesOrNo = Console.ReadLine(); 
            
            if(YesOrNo == "Да" || YesOrNo =="да")
            {
                userLoans.Add(new Loan(loanAmount, loanTerm, loanRate, email));
            }
             
        }
    }
}
