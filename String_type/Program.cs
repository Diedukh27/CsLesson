Console.WriteLine("Enter your password:");
string pass = Console.ReadLine();


if (pass.Length >= 8)
{
    Console.WriteLine("Great password length!");
}
else
{
    Console.WriteLine("Pssword too short!");
}

if (pass[0] == 'a' || pass[0] == 'A')
{
    Console.WriteLine("Pssword stars with A/a");
}

if (pass.StartsWith("Qwer") && pass.EndsWith("@"))
{
    Console.WriteLine("Pssword has template: Qwer...@");
}

if (pass.Contains("vlad"))
{
    Console.WriteLine("Password contains your name!");
}

Console.WriteLine(pass.ToUpper());
Console.WriteLine(pass.ToLower());

string newPass = pass.Replace(' ', '-');
Console.WriteLine(newPass);

