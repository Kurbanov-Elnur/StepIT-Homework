using System;
using System.Formats.Tar;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using _23;
using _23.Models;
using _23.Services.Classes;












string text = "atillaristam@gmail.com";
string name = "Elnur";
string surname = "Mamedov";
string password = "Elnur123";




if (IsEmailameValid(text))
    Console.WriteLine("True 1");

if (!Regex.IsMatch(name, @"^[a-zA-Z]"))
    Console.WriteLine("True 2");

if (!Regex.IsMatch(surname, @"^[a-zA-Z]"))
    Console.WriteLine("True 3");

if (!Regex.IsMatch(password, @"^[a-zA-Z0-9.]{8,}$"))
    Console.WriteLine("True 4");

bool IsEmailameValid(string email)
{
    return Regex.IsMatch(email, @"((a-zA-Z0-9?)+([a-zA-Z0-9])+@([a-zA-Z0-9])+((\.)[a-zA-Z]{2,})+)");
}