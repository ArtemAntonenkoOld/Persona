using System;
using System.Media;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Input;


namespace ConsoleApplication170
{
    class Program
    {


        public static string name = "qwertyuiopasdfghjklzxcvbnm"; public static Random rand = new Random();
        /*static string SetHash(int size)
        {


            var ht = new MyHashTable<int, Man>(size);
            Stopwatch stopw = new Stopwatch();
            stopw.Start();
            for (int i = 0; i < size + 1; i++)
            {
                ht.Put(i, new Man()
                {
                    Age = rand.Next(0, 200),
                    Name = Name(),
                    Size = rand.Next(0, 200)


                });
            }
            stopw.Stop();
            return stopw.Elapsed.ToString();*/
    }
}
        static void Main(string[] args)
        {
            Console.WriteLine(rand.Next(0, 1));
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(SetHash(size));

            var hat = new MyHashTable<int, string>(3);
            hat.Put(1, "1");
            hat.Put(2, "2");
            hat.Put(3, "3");
            hat.Put(4, "4");
            hat.Get(1);
            Console.ReadLine();
        }
        /*   static string Name()
           {
               StringBuilder text = new StringBuilder();
               for (int i = 0; i < 7; i++)
               {
                   text.Append(name[rand.Next(0, name.Length)]);
               }
               return text.ToString();
           }
       }

       internal class MyHashTable<K, V> 
       {
           private List<Tuple<K, V>> list;
           public MyHashTable(int capacity)
           {
               list = new List<Tuple<K, V>>(capacity);
               for (int i = 0; i < capacity; i++)
                   list.Add(null);

           }

           public void Put(K key, V val)
           {
               try
               {
                   var i = GetIndex(key);

                   list[i] = new Tuple<K, V>(key, val);
               }
               catch
               {

                   foreach (var item in list)
                   {
                       var k = int.Parse(key);
                       GetIndex(GetIndex()){
                           list[i] = new Tuple<K, V>(key, val);
                       }
                   }
               }
           }

           public V Get(K key)
           {
               var i = GetIndex(key);
               var tuple = list[i];
               if (tuple == null || !tuple.Item1.Equals(key))
                   throw new Exception("Key is not found!");

               return tuple.Item2;
           }

           public int Count
           {
               get { return list.Count(t => t != null); }
           }

           public bool IsEmpty
           {
               get { return Count == 0; }
           }

           public IEnumerable<K> Keys
           {
               get { return list.Where(t => t != null).Select(t => t.Item1); }
           }

           int GetIndex(K key)
           {
               return key.GetHashCode() % list.Count;
           }
           public void Delete(K key)
           {
               var i = GetIndex(key);
               list[i] = null;
           }
       }


       public class Woman : Essence
       {
           public Woman()
           {
               Gender = false;
           }
           public override string ToString()
           {
               return ("Age=" + Age + " ,Name=" + Name);
           }

       }
       public class Man : Essence, Human
       {
           public double Size { get; set; }
           public Man()
           {
               Gender = true;
           }
           public override string ToString()
           {
               return ("Age=" + Age + " ,Name=" + Name + " ,Size=" + Size);
           }
       }
       public class Essence
       {
           public int Age { get; set; }
           public string Name { get; set; }
           public bool Gender { get; set; }

       }
       public interface Human
       {
           double Size { get; set; }
       }
       */
    }
}