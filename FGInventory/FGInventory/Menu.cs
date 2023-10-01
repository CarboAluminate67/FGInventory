using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// class to handle menu navigation

namespace FGInventory
{
    public class Menu
    {
        private List<Item> _items = new List<Item>(); 
        public Menu() // initializer
        { }

        public void ListItems() // view inventory
        {
            foreach(Item item in _items)
            {
                Console.Write($"Item: {item.GetName()}, Number on hand: {item.GetQuant()}");
                if (item.GetType().Name == "Perish")
                {
                    Console.Write($", {item.GetExp().ToString()} day shelf life; expires on {item.GetExpiresOn}");
                }
                else if (item.GetType().Name == "Meat")
                {
                    Console.Write($", pack date: {item.GetPack()}, {item.GetExp().ToString()} day shelf life; expires on {item.GetExpiresOn}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        public void NewItem(string type, string name, int quant, int exp = 0, string pack = "") // make new item in list
        {
            if (type.ToLower() == "dry")
            {
                _items.Add(new Item(name, quant));
            }

            else
            {
                if (type.ToLower() == "meat")
                {
                    _items.Add(new Meat(name, quant, exp, pack));
                }
                else
                {
                    _items.Add(new Perish(name, quant, exp));
                }
            }

        }
        public void OrderItem(Item item, int quant)
        {
            item.AddItems(quant);
        }

        public void UseItem(Item item, int quant)
        {
            item.UseItem(quant);
        }

        public void Save() // save to txt file
        {
            File.WriteAllText("./Inventory.txt", String.Empty);
            using (StreamWriter writer = new StreamWriter("./Inventory.txt"))
            {
                foreach (Item item in _items)
                {
                    writer.WriteLine(item.MakeString());
                }
            }
        }

        public void Load() // load from file
        {
            _items.Clear();
            String[] lines = File.ReadAllLines("./Inventory.txt");
            foreach (string line in lines)
            {
                String[] parts = line.Split("; ");
                if (parts.Length == 2)
                {
                    _items.Add(new Item(parts[0], int.Parse(parts[1])));
                }
                else if (parts.Length == 4)
                {
                    _items.Add(new Perish(parts[0], int.Parse(parts[1]), int.Parse(parts[2])));
                }
                else
                {
                    _items.Add(new Meat(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), parts[4]));
                }
            }
        }
        public List<Item> GetItems() // getter
        {
            return _items;
        }
    }
}
