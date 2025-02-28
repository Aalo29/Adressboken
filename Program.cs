﻿using System;

string contacts = "";
int numberOfPeopleInList = 0;

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"~: ADRESSBOKEN ({numberOfPeopleInList} personer, {contacts.Length} tecken) :~\n");
    Console.ResetColor();
    Console.WriteLine("[V]isa personer");
    Console.WriteLine("[L]ägg till person");
    Console.WriteLine("\n[A]vsluta [R]ensa adressboken");

    // Console.Write("\nVal: ");
    char choice = Console.ReadKey(true).KeyChar;

    if (choice == 'v')
    {
        Console.Clear();
        Console.WriteLine(Environment.NewLine + contacts + Environment.NewLine + (contacts.Split("\n").Length - 1) + " personer totalt");
        Console.ReadKey();
    }
    else if (choice == 'l')
    {
        Console.Clear();
        Console.Write("\nNamn: ");
        string newPerson = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newPerson))
        {
            contacts += contacts.Length >= 0 ? newPerson + Environment.NewLine : newPerson;
            numberOfPeopleInList++;
        }
    }
    else if (choice == 'r')
    {
        Console.WriteLine("\nAre you sure?  (y/n)");
        choice = Console.ReadKey(true).KeyChar;
        if (choice == 'y')
        {
            contacts = "";
            numberOfPeopleInList = 0;
        }
    }
    else if (choice == 'a') Environment.Exit(0);
}