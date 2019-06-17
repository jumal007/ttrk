using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Open.TTRK.Models;

namespace Open.TTRK.Data
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
            new Customer{FirstName="Carson",LastName="Alexander",DateOfBirth= DateTime.Parse("2005-09-01"), Dept = 0,CustomerID= "000001"},
            new Customer{FirstName="Meredith",LastName="Alonso",DateOfBirth=DateTime.Parse("2002-09-01"), Dept = 0,CustomerID= "000002"},
            new Customer{FirstName="Arturo",LastName="Anand",DateOfBirth=DateTime.Parse("2003-09-01"), Dept = 0,CustomerID= "000003"},
            new Customer{FirstName="Gytis",LastName="Barzdukas",DateOfBirth=DateTime.Parse("2002-09-01"), Dept = 0,CustomerID= "000004"},
            new Customer{FirstName="Yan",LastName="Li",DateOfBirth=DateTime.Parse("2002-09-01"), Dept = 0,CustomerID= "000005"},
            new Customer{FirstName="Peggy",LastName="Justice",DateOfBirth=DateTime.Parse("2001-09-01"), Dept = 0,CustomerID= "000006"},
            new Customer{FirstName="Laura",LastName="Norman",DateOfBirth=DateTime.Parse("2003-09-01"), Dept = 0,CustomerID= "000007"},
            new Customer{FirstName="Nino",LastName="Olivetto",DateOfBirth=DateTime.Parse("2005-09-01"), Dept = 0,CustomerID= "000008"},
            new Customer{FirstName="Ilja",LastName="Freiberg",DateOfBirth=DateTime.Parse("1999-04-20"), Dept = 0,CustomerID= "000009"},
            new Customer{FirstName="Nikita",LastName="Piljavets",DateOfBirth=DateTime.Parse("1999-12-23"), Dept = 20,CustomerID= "690228"}
            };

            foreach (Customer s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();

            
            var books = new Book[]
            {
            new Book{Title = "The Girl on the Train",Author = "Paula Hawkins",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,BookID = "",Status = true,DateOfReturn = DateTime.Parse("")},
            new Book{Title = "Between the World and Me",Author = "Ta-Nehisi Coates",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,BookID = "",Status = true,DateOfReturn = DateTime.Parse("")},
            new Book{Title = "When Breath Becomes Air",Author = "Paul Kalanithi",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,BookID = "",Status = true,DateOfReturn = DateTime.Parse("")},
            new Book{Title = "Go Set a Watchman",Author = "Harper Lee",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,BookID = "",Status = true,DateOfReturn = DateTime.Parse("")},
            new Book{Title = "Why Not Me?",Author = "Mindy Kaling",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,BookID = "",Status = true,DateOfReturn = DateTime.Parse("")},
            new Book{Title = "Modern Romance",Author = "Aziz Ansari",DateOfPublication = DateTime.Parse("1995-07-12"),Floor =2,Rack=45,BookID = "",Status = false,DateOfReturn = DateTime.Parse("2019-09-12"),CustomerID = "690228"},

            };
            foreach (Book e in books)
            {
                context.Books.Add(e);
            }
            context.SaveChanges();
        }
    }
}
