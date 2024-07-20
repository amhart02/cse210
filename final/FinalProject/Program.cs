using System;

class Program
{
    static void Main(string[] args)
    {
        //define some tings
        int userInput = 1;
        Menu menu = new Menu();
        User user = menu.DisplayLogIn();
        Console.Clear();
        Products products = new Products();
        Cart cart = new Cart(0);

        //main while loop
        while (userInput != 7)
        {
            userInput = menu.DisplayMainMenu();

            //display products
            if (userInput == 1)
            {
                List<Product> loadedProducts = Products.ReadFromFile("products.txt");
                products.LoadProducts(loadedProducts);
                products.DisplayProducts();
            }
            //add item
            else if (userInput == 2)
            {
                List<Product> loadedProducts = Products.ReadFromFile("products.txt");
                products.LoadProducts(loadedProducts);
                products.DisplayProducts();

                Console.WriteLine("Which item would you like to add to the cart (please use the number value)? ");
                int itemToAdd = int.Parse(Console.ReadLine());
                Product productToAdd = loadedProducts[itemToAdd - 1];
                cart.AddProduct(productToAdd);
                Console.WriteLine();
            }
            //remove item
            else if (userInput == 3)
            {
                List<Product> loadedProducts = Products.ReadFromFile("products.txt");
                products.LoadProducts(loadedProducts);
                products.DisplayProducts();

                Console.WriteLine("Which item would you like to add to the cart (please use the number value)? ");
                int itemToDelete = int.Parse(Console.ReadLine());
                Product productToDelete = loadedProducts[itemToDelete];
                cart.DeleteProduct(productToDelete);
                Console.WriteLine();
            }
            //view cart
            else if (userInput == 4)
            {
                Console.WriteLine();
                cart.DisplayCart();
            }
            //create order
            else if (userInput == 5)
            {

            }
            //view orders
            else if (userInput == 6)
            {

            }
        }
    }
}