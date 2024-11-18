//void PrintStar()
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.Write('*');
//    }
//}


//PrintStar();




//void PrintStar2( char filler, ConsoleColor color)
//{
//    Console.ForegroundColor = color;
//    for (int i = 0; i < 10; i++)
//    {
//        Console.Write(new string(filler, 1));
//    }
//    Console.ResetColor();
//}

//PrintStar2( '*', ConsoleColor.White);

//PrintStar2( '|' , ConsoleColor.Blue);



void PrintRectangle(int w, int h)
{
        Console.WriteLine($"area Result: {h * w}");
    Console.WriteLine($"Perimetr Result: {h + w * 2}");
}

PrintRectangle(9 , 7);

PrintRectangle(7 , 3);






