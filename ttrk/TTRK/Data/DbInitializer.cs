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
            new Customer{FirstName="Carson",LastName="Alexander",DateOfBirth= DateTime.Parse("2005-09-01"), Dept = 0,CustomerID= "000001",},
            new Customer{FirstName="Meredith",LastName="Alonso",DateOfBirth=DateTime.Parse("2002-09-01"), Dept = 0,CustomerID= "000002",},
            new Customer{FirstName="Arturo",LastName="Anand",DateOfBirth=DateTime.Parse("2003-09-01"), Dept = 0,CustomerID= "000003",},
            new Customer{FirstName="Gytis",LastName="Barzdukas",DateOfBirth=DateTime.Parse("2002-09-01"), Dept = 0,CustomerID= "000004",},
            new Customer{FirstName="Yan",LastName="Li",DateOfBirth=DateTime.Parse("2002-09-01"), Dept = 0,CustomerID= "000005",},
            new Customer{FirstName="Peggy",LastName="Justice",DateOfBirth=DateTime.Parse("2001-09-01"), Dept = 0,CustomerID= "000006",},
            new Customer{FirstName="Laura",LastName="Norman",DateOfBirth=DateTime.Parse("2003-09-01"), Dept = 0,CustomerID= "000007",},
            new Customer{FirstName="Nino",LastName="Olivetto",DateOfBirth=DateTime.Parse("2005-09-01"), Dept = 0,CustomerID= "000008",},
            new Customer{FirstName="Ilja",LastName="Freiberg",DateOfBirth=DateTime.Parse("1999-04-20"), Dept = 0,CustomerID= "000009",},
            new Customer{FirstName="Nikita",LastName="Piljavets",DateOfBirth=DateTime.Parse("1999-12-23"), Dept = 20,CustomerID= "690228",}
            };

            foreach (Customer s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();

            
            var books = new Book[]
            {
            new Book{CustomerID= "000001",BookID ="1050",},
            new Book{CustomerID= "000002",BookID ="4022",},
            new Book{CustomerID= "000003",BookID ="4041",},
            new Book{CustomerID= "000004",BookID ="0453",},
            new Book{CustomerID= "000005",BookID ="3141",},
            new Book{CustomerID= "000006",BookID ="2021",},
            new Book{CustomerID= "000007",BookID ="1050"},
            new Book{CustomerID= "000008",BookID ="1050"},
            new Book{CustomerID= "000009",BookID ="4022",},
            new Book{CustomerID= "000010",BookID ="4041",},
            new Book{CustomerID= "000011",BookID ="1045"},
            new Book{CustomerID= "000012",BookID ="3141"},
            };
            foreach (Book e in books)
            {
                context.Books.Add(e);
            }
            context.SaveChanges();
        }
    }
}
