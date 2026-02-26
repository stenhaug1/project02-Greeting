DateTime Dato = DateTime.Now;
Console.WriteLine("What would you like to be named?");
string username = Console.ReadLine();
Console.WriteLine("Do you have any hobbies?");
string hobbies = Console.ReadLine();
var hour = Dato.Hour;
var output = $" {username}";
if (hobbies == "No" || hobbies == "no")
{

}
else
{
    output = output + " I hope you get to enjoy " + hobbies + " today :)";
}

Dictionary<string, string> greetings = new Dictionary<string, string>();
greetings.Add("morning", "Good morning" + output);
greetings.Add("afternoon", "Good afternoon" + output);
greetings.Add("evening", "Good evening" + output);

switch (hour)
{
    case < 12:
        Console.WriteLine(greetings["morning"]);
        break;
    case < 18:
        Console.WriteLine(greetings["afternoon"]);
        break;
    default:
        Console.WriteLine(greetings["evening"]);
        break;
}