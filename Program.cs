

Console.Write("Enter your name: ");
string name = Console.ReadLine() ?? throw new Exception("cannot be null");

string hw = $"Hello, {name}!";

Console.Write("How many times? ");
int num=int.Parse(Console.ReadLine());

for (int i=0; i<num; i++){
    foreach (var c in hw) 
    {
        Console.ForegroundColor = (ConsoleColor)Random.Shared.Next(1, 16);
        Console.Write(c);
    }
    Console.WriteLine("\n");
}
while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
