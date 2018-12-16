using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Jaume" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            */
            using (var ctx = new ProvaContext())
            {
                var marc = new Professor() { nom = "Marc", cognom = "Albareda" };
                var grego = new Professor() { nom = "Gregorio", cognom = "Santamaria" };
                var m6 = new Modul() { Codi = 6, nom = "Acces a Dades", horesSetmana = 4 };

                marc.Moduls.Add(m6);

                ctx.Modul.Add(m6);
                ctx.Professor.Add(marc);
                ctx.Professor.Add(grego);
                Console.WriteLine(marc.Moduls);
                ctx.SaveChanges();
            }
        }
    }

}
