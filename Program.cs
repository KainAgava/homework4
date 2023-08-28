using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string name = "Петров";
            string surname = "Пётр";
           
           string correctName = surname;
           string correctSurname = name;

             name = correctName;
             surname = correctSurname;

                            Console.WriteLine($"Имя: " + name + " Фамилия:" + surname + ""); 
               
           

        }

    }
}
