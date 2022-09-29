using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAndService.Entity
{
    public class Loan
    {
        public Loan() { }
        public Loan(double LoanAmount, int LoanTerm, double LoanRate, string Email) 
        {
            this.LoanAmount = LoanAmount;
            this.LoanTerm = LoanTerm;
            this.LoanRate = LoanRate;
            this.Email = Email;
        }
        public double LoanAmount { get; set; }
        public int LoanTerm { get; set; }
        public double LoanRate { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Это заём в размере {LoanAmount}, взятый по дпроцент {LoanRate}, на {LoanTerm} месяцев , пользователём с email {Email}";
        }
    }
}
