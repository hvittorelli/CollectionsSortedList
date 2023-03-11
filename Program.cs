using System;
using System.Collections.Generic;

namespace CollectionsSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList <int, string> groceryList = new SortedList<int, string>();
            groceryList.Add(1, "Bananas");
            groceryList.Add(7, "Lettuce");
            groceryList.Add(8, "Chicken");
            groceryList.Add(4, "Apples");
            groceryList.Add(9, "Cheese");
            Console.WriteLine("Here are the items on the grocery list: ");
            foreach (KeyValuePair<int, string> gl in groceryList)
            {
                Console.WriteLine($"Item Number = {gl.Key}    Item = {gl.Value}");
            }
            Console.WriteLine("What else do you want to add to the list?");
            Console.WriteLine("Enter Item: ");
            string newItem = Console.ReadLine();
            Console.WriteLine("Enter Item Number: ");
            int newKey = int.Parse(Console.ReadLine());
            
            while (groceryList.ContainsValue(newItem)) 
            {
                Console.WriteLine("The list already contains that item, enter a different item.");
                Console.WriteLine("Enter Item: ");
                newItem = Console.ReadLine();
            }
            if (groceryList.ContainsKey(newKey))
            {
                Console.WriteLine("The grocery list already has this item number, do you want to remove and replace it? (Enter yes or no)");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    groceryList.Remove(newKey);
                    groceryList.Add(newKey, newItem);
                    Console.WriteLine($"{newItem} has been added at item number {newKey}");
                }
                else 
                {
                    Console.WriteLine("You can't have duplicate item numbers on the grocery list!");
                }
            }
            else
            {
                groceryList.Add(newKey, newItem);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Here are the items on the grocery list: ");
            foreach (KeyValuePair<int, string> gl in groceryList)
            {
                Console.WriteLine($"Item Number = {gl.Key}    Item = {gl.Value}");
            }
        }
    }
}