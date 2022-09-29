using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EntityAndService.Expensive;

namespace EntityAndService.Servise
{
    public class UserService
    {   
        public UserService() { }
     
        private static List<User> _users = new List<User>();

        public void CreatUser()
        {

            Console.WriteLine("Введите имя");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            string LastName = Console.ReadLine();
            Console.WriteLine("Введите сколько вам лет ");
            int Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш email");
            string Email = Console.ReadLine();

            User user = new User(FirstName, LastName, Email, Age);

            if (_users.Count == 0)
            {
                _users.Add(user);
            }
            else
            {
                foreach (var item in _users.ToList())
                {
                    if (item.Email == Email)
                    {
                        throw new ObjectExistsException(Email);
                    }
                    else
                    {
                        _users.Add(user);
                    }
                }
            }       
        }
        public void DeleteUser(string Email)
        {
            var user = _users.FirstOrDefault(x => x.Email == Email);
            if(user == null)
            {
                throw new ObjectNotFoundException(user.Email);
            }
            else
            {
                _users.Remove(user);
            }     
        }
        public string WriteUserInfo(string email)
        {
            var user = _users.FirstOrDefault(x => x.Email == email);
   
            if(user == null)
            {
                throw new ObjectNotFoundException(user.Email);
            }
            else
            {
                return $" Имя: {user.FirsName},Фамилия: {user.LastName}, возраст: {user.Age}";
            }     
        }
        public bool UserExists(string email)
        {
            var user = _users.FirstOrDefault(x => x.Email == email);
            bool answer = false;
            if(user != null)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }
    }
}
