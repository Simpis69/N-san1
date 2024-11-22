string [] leksaker = {"bil", "plan", "svärd", "bubblor", "spiderman"};

string [] chompi = {"sverre", "Skibidi Leo", "Raschmuss", "David", "Micke"};

int [] värden = {3, 5, 7, 9, 1};


for (int i = 0; i < chompi.Length; i++)
{
Console.WriteLine($"{chompi[i]} ger {leksaker[i]} betyget {värden[i]}");
}

List<string> cities = new List<string>();

Console.WriteLine("skriv en valfri stad!");
Console.WriteLine("skriv exit för att stänga av");
while(true)
{
    string city = Console.ReadLine();
    
    if(city.ToLower() == "exit")
    {
        break;
    }
    else
    {
        cities.Add(city);
    }
}
foreach (string stad in cities)
{
    Console.WriteLine(stad);
}


// foreach (string leksak in leksaker)
// {
//     Console.WriteLine(leksak);
// }
Console.ReadLine();