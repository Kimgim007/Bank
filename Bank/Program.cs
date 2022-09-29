using EntityAndService;
using EntityAndService.Servise;
using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Answer = true;

            string Anser1 = "Добро пожаловать в банк, выберите один из пунктов в меню";
            Console.WriteLine(Anser1);

            UserService  userService = new UserService();
            LoanManagerService loanManagerService = new LoanManagerService();

            while (Answer)
            {
                Console.WriteLine("1.Создать пользователя");
                Console.WriteLine("2.Удалить пользователя");
                Console.WriteLine("3.Информация о пользователе");
                Console.WriteLine("4.Предложить кредит");
                //Console.WriteLine("5.Просмотр кредитов");
                Anser1 = Console.ReadLine();

                switch (Anser1)
                {
                    case "1":
                        {   Console.Clear();
                            userService.CreatUser();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Введите email пользователя которого хотите удалить ");
                            string email = Console.ReadLine();
                            userService.DeleteUser(email);
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Введите ,email пользоввателя");
                            string email = Console.ReadLine();
                         
                            Console.WriteLine(userService.WriteUserInfo(email));
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            loanManagerService.SuggestLoan();
                            break;
                        }
                    //case "5":
                    //    {
                    //        Console.WriteLine(string.Join('\n', loanManagerService.userLoans));
                    //        break;
                    //    }
                }

                Console.WriteLine("Желайте ли продолжить ,введите Да или Нет?");
                string YesOrNo = Console.ReadLine();
                if (YesOrNo == "Нет" || YesOrNo == "нет")
                {
                    Answer = false;
                }

                Console.Clear();

            }

        }
    }
}
