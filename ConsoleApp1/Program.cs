using ConsoleApp1;
using System;

static bool CheckPasswordRequirements(string password)
{
    bool hasDigit = false;
    bool hasUppercase = false;

    foreach (char c in password)
    {
        if (char.IsDigit(c))
            hasDigit = true;
        else if (char.IsUpper(c))
            hasUppercase = true;
    }

    return hasDigit && hasUppercase;
}
string username;
    string password;
    string section;
    bool issuperadmin;
do
{
    Console.Write("Username(minumum 6 character):");
    username = Console.ReadLine();
} while (username.Length <6);

do
{
    Console.Write("Password(minumum 6 character):");
    password = Console.ReadLine();
} while (password.Length < 6 || !CheckPasswordRequirements(password));

Console.Write("Section:");
section = Console.ReadLine();


Console.Write("Issuperadmin:");
issuperadmin = bool.Parse(Console.ReadLine());

Admin admin = new Admin(username,password,issuperadmin,section);

admin.GetAdminData();


