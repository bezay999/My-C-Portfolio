using System;

namespace SpaceMission
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] spaceInventory = new string [] 
                { "Space Suits", 
                    "Oxygen Tanks", 
                      "Food Supplies", 
                       "Medical Kits", 
                        "Communication Devices",  
                         "Fuel Canisters", 
                          "Navigation Tools", 
                           "Repair Tools"};
            
            int[] itemQuantities = new int[] {10, 8, 15, 5, 6, 9, 4, 7};
            if (spaceInventory.Length == 8)
            {
                Console.WriteLine("Space Inventory is ready to go!");
            }
            else if (spaceInventory.Length > 8)
            {
                Console.WriteLine("Too many Items!");
            }
            else
            {
                Console.WriteLine("Add more Items!");
            }
            
            Console.WriteLine("Item: " + spaceInventory[1]);
            Console.WriteLine("Quantity: " + itemQuantities[1]);

            spaceInventory[7] = "Scientific Instruments";
            itemQuantities[7] = 5;

            int x = Array.IndexOf(spaceInventory, "Space Suits");
            
            Console.WriteLine($"The first item with quantity 5 is at position {x}.");
            
            Array.Reverse(spaceInventory);
            Console.WriteLine(spaceInventory[0]);
            Console.WriteLine(spaceInventory[7]);
            
            Array.Sort(spaceInventory);
            Console.WriteLine(spaceInventory[0]);
            Console.WriteLine(spaceInventory[7]);
        }
    }
}