﻿string name = Console.ReadLine();
string pass = Console.ReadLine();
string password = Console.ReadLine();
while (password != pass)
{
    password = Console.ReadLine();
}
Console.WriteLine($"Welcome {name}!");