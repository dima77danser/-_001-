﻿Console.WriteLine("назовите ваше имя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("ура это же МАША!");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}
