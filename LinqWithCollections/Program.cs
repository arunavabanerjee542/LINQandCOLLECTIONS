using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> l = new List<int>() { 1, 2, 3, 4, 5, 5, 78, 8, 8, 78, 78, 7, 7 };

            // print numbers that are even 

            //trick 1

            IEnumerable<int> even = l.Where(x => x % 2 == 0);

            foreach(int i  in even)
            {
                Console.WriteLine(i);
            }


            //trick 2

            Func<int,bool> p = x => x % 2 == 0;

            IEnumerable<int> evennow = l.Where(p);

            foreach (int i in evennow)
            {
                Console.WriteLine(i);
            }


            // trick 3

            IEnumerable<int> val = from i in l where i % 2 == 0 select i;

            Console.WriteLine();

            foreach (int ii in val)
            {
                Console.WriteLine(ii);
            }


            // working with SELECT 

            List<Employee> empl = new List<Employee>()
            {
            new Employee()
            {
                id =10, name="Arun", sal= 20000
            },

            new Employee()
            {
                id = 1, name = "Arunava", sal = 400000
            },

              new Employee()
            {
                id =100, name="banerjee", sal= 2000000
            }


            };


            // retrive all data from empl list

            var all = from i in empl select i;

            foreach (Employee em in all)
            {
                Console.WriteLine(em.id + " "+ em.name);
            }


            // retrive onlt 2 data [ id , sal ] from lit


            // trick 1 : Query 

            var only = from x in empl
                       select new Employee()
                       {
                           id = x.id,
                           sal = x.sal
                       };

            foreach (var on in only)
            {
                Console.WriteLine(on.id + " "+ on.sal+ " " +on.name);
            }

            // trick  2 : method 


            var onl = empl.Select(x => new Employee()
            {
                id = x.id,
                sal = x.sal
            }
            );

            Console.WriteLine();

            foreach (var onn in onl)
            {
                Console.WriteLine(onn.id + " " + onn.sal + " " + onn.name);
            }




        } // main
    }


    class Employee
    {
        public int id;
        public string name;
        public int sal;



    }










}
