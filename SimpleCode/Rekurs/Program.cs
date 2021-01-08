using System;

namespace Rekurs
{
    class Program
    {

        class Item 
        {
            public int Value { get; set; }
            public Item Child { get; set; }
        }

        static Item InitItem() 
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 10,
                    Child = new Item()
                    {
                        Value = 2
                    }
                }

            }; 
        }

        static void Print(Item item) 
        {
            if (item != null) 
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
            
        }

        static void Main(string[] args)
        {
            Item item = InitItem();
            // Print(item); // Вывод с помощью рекурсии
            for (Item i = item; i != null; i = i.Child) // Вывод без рекурсии
            {
                Console.WriteLine(i.Value);
            }
         }
    }
}
