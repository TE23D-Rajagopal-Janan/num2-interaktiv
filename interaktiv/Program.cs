
Console.WriteLine("Du är i en öken med två olika vägar, Vilken väg vill du ta höger eller vänster");

string ans1 = Console.ReadLine().ToLower();

if (ans1 == "vänster")
{
    Console.WriteLine("Okej vänster alltså");
    Console.WriteLine("Det börjar bli en sandstorm vill du Fortsätta eller vänta ut stormen (Fortsätt/vänta)");
    String ss = Console.ReadLine().ToLower();
    if (ss.ToLower() == "förtsätt")
    {
        Condsole.WriteLine("Du kom tillbaka hem");
    }
    
    else if (ss.ToLower() == "vänta")
    {
        Console.WriteLine("Du fick san i ögonon och tappa synen och hitta aldrig hem igen");

    }
}

else if (ans1 == "höger")
{
    Console.WriteLine("Okej höger alltså");
    Console.WriteLine("Du ser en kaktus, och du är väldigt törstig vill du dricka vattnet i den eller fortsätta gå (Dricka/Gå) ");
    string Vx = Console.ReadLine().ToLower();
    if (Vx == "dricka")
    {
        Console.WriteLine("du dog");
    }
    else if (Vx.ToLower() == "gå")
    {
        Console.WriteLine("Du hitta en väg tillbaka hem!");

    }
}
else 
{

}

Console.ReadLine();