using System;

namespace EntityAndService
{
    public class User
    {
        public User (){}
        public User (string FirstName,string LastName,string Email,int Age)
        {
            this.FirsName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Age = Age;
        }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Это пользователь по имени {LastName} {FirsName} ,возрастом {Age}";
        }
    }
}
