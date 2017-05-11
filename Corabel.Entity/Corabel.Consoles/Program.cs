using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corabel.Entity;

namespace Corabel.Consoles
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var db = new Context())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Photo() {Path = "/papka"};
                db.Photos.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Photos
                            orderby b.Path
                            select b;

                Console.WriteLine("All photos in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Path);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
