using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");

        Menu menu = new Menu();
        User user = menu.DisplayLogIn();
        user.DisplayUserInfo();
    }
}