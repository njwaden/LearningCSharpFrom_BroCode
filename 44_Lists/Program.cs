namespace _44_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list = data structure that represents a list of objects that can be accessed by index.
            //       similar to array, but can dynamically increase/decrease in size
            //       using System.Collection.Generic;

            List<String> food = new List<String>();
;
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //food.Remove("fries");                             remove method
            //food.Insert(0,"sushi");                           insert object at a given index
            //Console.WriteLine(food.Count);                    current size of list
            //Console.WriteLine(food.IndexOf("pizza"));         find the index of an object
            //Console.WriteLine(food.LastIndexOf("fries"));     find last index of an object
            //Console.WriteLine(food.Contains("pizza"));        checks to see if out list contains a given item
            //food.Sort();                                      sorts the list alphabetically
            //food.Reverse();                                   reverses the order of the list
            //food.Clear();                                     clears the list
            String[] foodArray = food.ToArray();                //convert list to array

            foreach (String item in foodArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(food[0]);                     //accessing an element is the same as array

            Console.ReadKey();
        }
    }
}
