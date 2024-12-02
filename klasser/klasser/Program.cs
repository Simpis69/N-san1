using klasser;

// Book ett = new Book("Bamse", 34);
// Book två = new Book("ParryHotter", 82);
// Book tre = new Book("Ralf", 45);



// // ett.name = "Bamse";
// // två.name = "ParryHotter";
// // tre.name = "Ralf";

// // ett.pages = 82;
// // två.pages = 23;
// // tre.pages = 12;

// ett.GetCurrentPage();
// två.GetCurrentPage();
// tre.GetCurrentPage();

// ett.TurnPage += 1;
// två.TurnPage += 1;
// tre.TurnPage += 1;

Console.WriteLine("hur många stenar vill du ha?");
string tal = Console.ReadLine();
int.TryParse(tal, out int nummer2);
Console.WriteLine("hur mycket ska din sten väga?");

string vikt = Console.ReadLine();
int.TryParse(vikt, out int stenvikt);

List<Rock> rocklist = new List<Rock>(); 
Rock viktis = new Rock(stenvikt);
Rock stenar = new Rock(nummer2);
rocklist.Add(viktis);
rocklist.Add(stenar);





// int [] Rocklist = {nummer2, stenvikt};
// Rock stenis = new Rock[Rocklist];
Console.ReadLine();