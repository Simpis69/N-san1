// #1
// if(6>3)
// {
//     Console.WriteLine("Hello world");
// }
// Console.ReadLine();

// #2
// Console.WriteLine("Tjaboba vad är ditt användarnamn?");
// string svar = Console.ReadLine().ToLower();

// if (svar == "noname")
// {
//     Console.WriteLine("Correct username");
// }
// else
// {
//     Console.WriteLine("Incorrect username");
// }

// Console.WriteLine("what is your password");
// string pass = Console.ReadLine().ToLower();

// if(pass == "12345")
// {
//     Console.WriteLine("Welcome!");
// }
// else
// {
//     Console.WriteLine("wrong password");
// }

// #3

// for(int i = 0 ; i < 32; i ++ )
// {
//     Console.WriteLine("Hello world");
// }

// #4

// while (true)
// {
// Console.WriteLine("what is your password");
// string pass = Console.ReadLine().ToLower();

// if(pass == "12345")
// {
//     Console.WriteLine("Welcome!");
//     break;
// }
// else
// {
//     Console.WriteLine("wrong password");
// }

// Console.ReadLine();
// }

// #5

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("skriv ett nummer från 1-10");
//     string tal = Console.ReadLine();
//     int.TryParse(tal, out int tal2);

//     if(tal2 > 5)
//     {
//         Console.WriteLine("högre än 5");
//     }
//     else
//     {
//         Console.WriteLine("lägre än 5");
//     }
//     else if (tal2 == 5)
//     {
//         Console.WriteLine("fem");
//     }

// }

// #6

// while (true)
//         {
//             Console.WriteLine("skriv vad du vill");
//             string skriv = Console.ReadLine();
//             if(int.TryParse(skriv, out int prat))
//             {
//                 Console.WriteLine("detta kan jag konvertera");
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Ge mig en utmaning");
//             }


//             Console.ReadLine();
//         }

// #7




int nummer  = Random.Shared.Next(1,100);
Console.WriteLine("gissa ett nummer mellan 1-100");
while(true)
{

    string svar = Console.ReadLine();
    int.TryParse(svar, out int nummer2);
    if(nummer == nummer2)
    {
        Console.WriteLine("good job!!");
        break;
    }
    else if(nummer2 < nummer)
    {
        Console.WriteLine("higher");
    }
    else if(nummer2 > nummer)
    {
        Console.WriteLine("lower");
    }
    Console.WriteLine("gissa igen");
    
}



Console.ReadLine();