using Collections.Generic;
using System;
using System.Collections.Generic;


namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Lists
            //If we have the data,list's are dynamic not as arrays fixed that means we can add as much as we need.

            //List<string> names = new List<string> { "John", "Rihanna", "Rock", "Jason" };

            //Console.WriteLine("####################################\n");
            //foreach (var name in names)
            //{

            //    Console.WriteLine(name);
            //}
            //names.Add("Foden");
            //names.Add("Pascal");

            //Console.WriteLine("####################################\n");
            //foreach (var name in names)
            //{

            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("####################################\n");
            //names.Remove(names[5]);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("####################################\n");
            //names.Clear();
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}



            #endregion

            #region MyList - Generic <T>

            //MyList<string> myList = new MyList<string>();

            //myList.Add("Richard");
            //myList.Add("Lilly");
            //myList.Add("Muhammed");
            //myList.Add("Sophie");
            //Console.WriteLine(myList.Count + " Total items in MyList.");
            //myList.Print();


            #endregion

            #region Dictionary Class

            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "Pencil");
            //dictionary.Add(2, "Book");
            //dictionary.Add(3, "Paper");

            //for (int i = 1; i <= dictionary.Count; i++)
            //{
            //    Console.WriteLine(dictionary[i]);
            //}





            #endregion


            #region MyDictionary
            
                var myDictionary = new MyDictionary<int, string>();
                myDictionary.Add(1, "Table");
                myDictionary.Add(2, "Desk");
                myDictionary.Add(3, "Pencil");
                myDictionary.Add(4, "Chair");


                int indx = 0;
                foreach (var item in myDictionary.Keys)
                {
                    Console.WriteLine($" Value {item} Key: {myDictionary.Values[indx]} ");
                    indx++;
                }
            #endregion



            Console.ReadLine();

        }
    }
}
