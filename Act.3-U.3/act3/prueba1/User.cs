using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba1
{
    //Class for handling user data
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //Default constructor
        public User()
        {
            Name = "Default Name";
            Age = 0;
        }

        //Constructor with parameters
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Destructor
        ~User()
        {
            Console.WriteLine("User object destroyed.");
        }

    }
}
