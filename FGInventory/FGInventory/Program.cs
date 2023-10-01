using FGInventory;

Menu menu  = new Menu();
int choice = 0;
while (choice != 7) // menu layout and navigation
{
    Console.Clear();
    Console.WriteLine("Welcome to Five Guys Inventory Management... Please select an option from the menu.");
    Console.WriteLine("1. Add Item");
    Console.WriteLine("2. Order Item");
    Console.WriteLine("3. Use Item");
    Console.WriteLine("4. List Inventory");
    Console.WriteLine("5. Save");
    Console.WriteLine("6. Load");
    Console.WriteLine("7. Quit");
    choice = int.Parse(Console.ReadLine());
    if (choice == 1) // add new item
    {
        Console.Write("What kind of item (Dry, perishable, or meat)? ");
        string type = Console.ReadLine();
        
        Console.Write("What is the name of the item? ");
        string name = Console.ReadLine();

        Console.Write("How many are now on hand? ");
        int quant = int.Parse(Console.ReadLine());
        if (type != "dry")
        {
            Console.Write("What is the shelf life in days? ");
            int exp = int.Parse(Console.ReadLine());
            if (type == "meat")
            {
                Console.Write("What was the pack date (MM/DD)? ");
                string pack = Console.ReadLine();
                menu.NewItem(type, name, quant, exp, pack);
            }
            else
            {
                menu.NewItem(type, name, quant, exp);
            }
        }
        else
        {
            menu.NewItem(type, name, quant);
        }

    }

    if (choice == 2) // increase item quantity
    {
        Console.Write("What item are you ordering? ");
        string name = Console.ReadLine();
        Console.Write("How many units would you like to order? ");
        int quant = int.Parse(Console.ReadLine());
        foreach (Item item in menu.GetItems())
        {
            if (item.GetName() == name)
            {
                menu.OrderItem(item, quant);
            }
        }
    }

    if (choice == 3) // reduce item quantity
    {
        Console.Write("What item are you using? ");
        string name = Console.ReadLine();
        Console.Write("How many units would you like to use? ");
        int quant = int.Parse(Console.ReadLine());
        foreach (Item item in menu.GetItems())
        {
            if (item.GetName() == name)
            {
                menu.UseItem(item, quant);
            }
        }
    }

    if (choice == 4) // view inventory
    {
        menu.ListItems();
    }

    if (choice == 5) // save
    {
        menu.Save();
    }

    if (choice == 6) // load
    {
        menu.Load();
    }
}