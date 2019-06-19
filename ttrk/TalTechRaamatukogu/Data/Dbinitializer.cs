using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalTechRaamatukogu.Models;

namespace TalTechRaamatukogu.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
            new Customer{FirstName="Carson",LastName="Alexander", Dept = 0,CustomerID= "50509010001"},
            new Customer{FirstName="Meredith",LastName="Alonso", Dept = 0,CustomerID= "502009010002"},
            new Customer{FirstName="Arturo",LastName="Anand", Dept = 0,CustomerID= "50309010003"},
            new Customer{FirstName="Gytis",LastName="Barzdukas", Dept = 0,CustomerID= "50209010004"},
            new Customer{FirstName="Yan",LastName="Li_",Dept = 0,CustomerID= "60209010005"},
            new Customer{FirstName="Peggy",LastName="Justice", Dept = 0,CustomerID= "60109010006"},
            new Customer{FirstName="Laura",LastName="Norman",Dept = 0,CustomerID= "60309010007"},
            new Customer{FirstName="Nino",LastName="Olivetto", Dept = 0,CustomerID= "600509010008"},
            new Customer{FirstName="Ilja",LastName="Freiberg",Dept = 0,CustomerID= "39904200243"},
            new Customer{FirstName="Nikita",LastName="Piljavets",Dept = 20,CustomerID= "39912232281"}
            };

            foreach (Customer s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();


            var books = new Book[]
            {
            //new Book{Title = ,Author = "",,Customer = ,DateOfPublication = ,DateOfReturn = ,Floor = ,Rack = ,Status = },     
            new Book{Title = "The Girl on the Train",Author = "Paula Hawkins",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,Status = true},
            new Book{Title = "Between the World and Me",Author = "Ta-Nehisi Coates",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,Status = true},
            new Book{Title = "When Breath Becomes Air",Author = "Paul Kalanithi",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,Status = true},
            new Book{Title = "Go Set a Watchman",Author = "Harper Lee",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,Status = true,},
            new Book{Title = "Why Not Me?",Author = "Mindy Kaling",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,Status = true},
            new Book{Title = "Modern Romance",Author = "Aziz Ansari",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,Status = false,DateOfReturn = DateTime.Parse("2019-09-12"),CustomerID = "39912230280"},

            };
            foreach (Book e in books)
            {
                context.Books.Add(e);
            }
            context.SaveChanges();
        }
    }
}
