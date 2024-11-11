//Console.WriteLine("enter your number: ");
//int number = int.Parse(Console.ReadLine());

//for (int count = 0; count < number; count++)
//    {
//        Console.WriteLine($"{count}");
//    }



Console.WriteLine("enter days ");
int days = int.Parse(Console.ReadLine());

int aa = 0;

int potencial = 15;


for (int i = 0; i < days; i++)
{
    aa += potencial;
    potencial += 2;
}
Console.WriteLine(aa);








