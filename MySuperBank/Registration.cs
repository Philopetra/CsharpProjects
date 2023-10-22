using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MySuperBank
{
    public class Registration
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        public Registration(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Registration() 
        {

        }


        //public Registration()
        //{
        //    CollectUserInformation();
        //}



        //private void CollectUserInformation()
        //{
        //    Console.Write("Enter your name: ");
        //    Name = Console.ReadLine();

        //    Console.Write("Enter your email: ");
        //    Email = Console.ReadLine();

        //    Console.Write("Enter your phone number: ");
        //    PhoneNumber = Console.ReadLine();
        //}
    }


    
}
