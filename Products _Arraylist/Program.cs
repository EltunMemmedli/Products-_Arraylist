using System.Collections;
using System.Diagnostics.Metrics;

ArrayList Products = new ArrayList()
{
    new ArrayList(){"Apple", "Macbook Pro", "3000", "20", "Laptop"},
    new ArrayList(){"Samsung", "S22 Ultra", "3500", "30", "Phone"},
    new ArrayList(){"Apple", "Iphone 16 Pro", "3000", "20", "Phone"}
};

Secim:
Console.WriteLine("Select the option:" +
                    "\n1. Show all products," +
                    "\n2. Show products by category," +
                    "\n3. Show total company price," +
                    "\n4. Show total price for category," +
                    "\n5. Add products," +
                    "\n6. Sell products" +
                    "\n-------------------------");

string Secim = Console.ReadLine();
int secim;

if (int.TryParse(Secim, out secim) && secim > 0 && secim < 7)
{

    if (secim == 1)
    {

        Console.Clear();
        int counter = 1;
        foreach (ArrayList AllProducts in Products)
        {
            Console.WriteLine($"Product ID: {counter++}\n" +
                                $"Bran: {AllProducts[0]},\n" +
                                $"Model: {AllProducts[1]},\n" +
                                $"Price: {AllProducts[2]},\n" +
                                $"Quantity: {AllProducts[3]},\n" +
                                $"Category: {AllProducts[4]},\n" +
                                $"-----------------------------------");
        }
    Kec:
        Thread.Sleep(2000);
        Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

        string Kec = Console.ReadLine();

        if (Kec.ToLower() == "f")
        {
            Console.Clear();
            goto Secim;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


            goto Kec;
        }


    }

    else if (secim == 2)
    {
        Console.Clear();
    category:
        Console.WriteLine("Which category do you want?");
        string category = Console.ReadLine();
        Console.Clear();

        if (!(string.IsNullOrEmpty(category)))
        {
            bool valid = false;
            int counter = 1;
            foreach (ArrayList Product in Products)
            {
                if (category.ToLower() == (string)Product[4].ToString().ToLower())
                {
                    valid = true;
                    Console.WriteLine($"Product ID: {counter++}\n" +
                    $"Bran: {Product[0]},\n" +
                    $"Model: {Product[1]},\n" +
                    $"Price: {Product[2]},\n" +
                    $"Quantity: {Product[3]},\n" +
                    $"Category: {Product[4]},\n" +
                    $"-----------------------------------");
                }
            }
            if (!valid)
            {   
                    Console.Clear();
                    Console.WriteLine("Can not find the category!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto category;   
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Enter the category!");
            Thread.Sleep(1000);
            Console.Clear();
            goto category;
        }
    Kec:
        Thread.Sleep(2000);
        Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

        string Kec = Console.ReadLine();

        if (Kec.ToLower() == "f")
        {
            Console.Clear();
            goto Secim;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


            goto Kec;
        }
    }

    else if (secim == 3)
    {
        Console.Clear();

        int TotalPrice = 0;
        foreach (ArrayList Price in Products)
        {
            decimal price = decimal.Parse(Price[2].ToString());

            int quantity = int.Parse(Price[3].ToString());

            TotalPrice += ((int)price * quantity);

        }

        Console.WriteLine($"Total price is : {TotalPrice}");

    Kec:
        Thread.Sleep(2000);
        Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

        string Kec = Console.ReadLine();

        if (Kec.ToLower() == "f")
        {
            Console.Clear();
            goto Secim;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


            goto Kec;
        }


    }

    else if (secim == 4)
    {
        Console.Clear();
    Category:
        Console.WriteLine("Which category do you want?");
        string category = Console.ReadLine();
        Console.Clear();

        if (!(string.IsNullOrEmpty(category)))
        {
            bool valid = false;
            int TotalPriceByCategory = 0;
            foreach (ArrayList Quantity in Products)
            {
                if (category.ToLower() == (string)Quantity[4].ToString().ToLower())
                {
                    valid = true;
                    int quantity = int.Parse(Quantity[3].ToString());

                    decimal price = decimal.Parse(Quantity[2].ToString());

                    TotalPriceByCategory += ((int)price * quantity);
                }

            }
            if (!valid)
            {
                Console.Clear();
                Console.WriteLine("Cannot find the category!");
                Thread.Sleep(1000);
                Console.Clear();
                goto Category;
            }
            Console.WriteLine($"Total price for {category} is {TotalPriceByCategory}");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Enter the category!");
            Thread.Sleep(1000);
            Console.Clear();
            goto Category;
        }
    Kec:
        Thread.Sleep(2000);
        Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

        string Kec = Console.ReadLine();

        if (Kec.ToLower() == "f")
        {
            Console.Clear();
            goto Secim;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


            goto Kec;
        }


    }

    else if (secim == 5)
    {
        Console.Clear();
    Brand:
        Console.WriteLine("Please, enter Brand");
        string Brand = Console.ReadLine();
        if (!(string.IsNullOrEmpty(Brand)))
        {
            Console.Clear();
        Model:
            Console.WriteLine("Please, enter Model");
            string Model = Console.ReadLine();
            if (!(string.IsNullOrEmpty(Model)))
            {
                Console.Clear();
            Price:
                Console.WriteLine("Please, enter Price");
                string Price = Console.ReadLine();
                decimal price;
                if (decimal.TryParse(Price, out price) && price > 0)
                {
                    Console.Clear();
                Quantity:
                    Console.WriteLine("Pleaase, enter Quantity");
                    string Quantity = Console.ReadLine();
                    int quantity;
                    if (int.TryParse(Quantity, out quantity) && quantity > 0)
                    {
                        Console.Clear();
                    Category:
                        Console.WriteLine("Please, enter Category");
                        string Category = Console.ReadLine();
                        if (!(string.IsNullOrEmpty(Category)))
                        {
                            Console.Clear();
                            ArrayList NewProducts = new ArrayList() { Brand, Model, Price, Quantity, Category };

                            Products.Add(NewProducts);

                            Console.Clear();
                            int counter = 1;
                            foreach (ArrayList AllProducts in Products)
                            {
                                Console.WriteLine($"Product ID: {counter++}\n" +
                                                    $"Bran: {AllProducts[0]},\n" +
                                                    $"Model: {AllProducts[1]},\n" +
                                                    $"Price: {AllProducts[2]},\n" +
                                                    $"Quantity: {AllProducts[3]},\n" +
                                                    $"Category: {AllProducts[4]},\n" +
                                                    $"-----------------------------------");
                            }
                        Kec:
                            Thread.Sleep(2000);
                            Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

                            string Kec = Console.ReadLine();

                            if (Kec.ToLower() == "f")
                            {
                                Console.Clear();
                                goto Secim;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


                                goto Kec;
                            }


                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Category!");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto Category;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Quantity!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        goto Quantity;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Price!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Price;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Model!");
                Thread.Sleep(1000);
                Console.Clear();
                goto Model;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid Brend!");
            Thread.Sleep(1000);
            Console.Clear();
            goto Brand;
        }
    }

    else if (secim == 6)
    {
        int say = Products.Count;
        Console.Clear();
        int Counter = 1;
        foreach (ArrayList Product in Products)
        {
            Console.WriteLine($"Product {Counter++}:");
            Console.WriteLine($"Brand: {Product[0]}");
            Console.WriteLine($"Model: {Product[1]}");
            Console.WriteLine($"Price: {Product[2]}");
            Console.WriteLine($"Quantity: {Product[3]}");
            Console.WriteLine($"Category: {Product[4]}");
            Console.WriteLine("--------------------");
        }
    ID:
        Console.Write("Write ID of the products: ");
        string ID = Console.ReadLine();
        int id;
        if (int.TryParse(ID, out id) && id > 0 && id < say + 1)
        {
            ArrayList product = (ArrayList)Products[id-1];

            int quantity = int.Parse(product[3].ToString());

            if (quantity > 0)
            {

                quantity--;
                product[3] = quantity.ToString();

                Products.Add(product);

                Console.Clear();
                int counter = 1;
                Console.WriteLine("Product sold successfully!\n");


                foreach (ArrayList Product in Products)
                {
                    Console.WriteLine($"Product {counter++}:");
                    Console.WriteLine($"Brand: {Product[0]}");
                    Console.WriteLine($"Model: {Product[1]}");
                    Console.WriteLine($"Price: {Product[2]}");
                    Console.WriteLine($"Quantity: {Product[3]}");
                    Console.WriteLine($"Category: {Product[4]}");
                    Console.WriteLine("--------------------");
                }
            Kec:
                Thread.Sleep(2000);
                Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

                string Kec = Console.ReadLine();

                if (Kec.ToLower() == "f")
                {
                    Console.Clear();
                    goto Secim;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


                    goto Kec;
                }



            }
            else
            {
                Console.Clear();
                Console.WriteLine("Product has been finished!");
                Thread.Sleep(1000);
                Console.Clear();
                goto ID;
            }

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid option!");
            Thread.Sleep(1000);
            Console.Clear();
            goto ID;
        }
    }
}
else
{
    Console.Clear();
    Console.WriteLine("Invalid option!");
    Thread.Sleep(1000);
    Console.Clear();
    goto Secim;
}