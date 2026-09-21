Console.Write("ur urdu marks: ");
int urdu = int.Parse(Console.ReadLine() ?? " ");
Console.Write("ur eng marks : ");
int eng = int.Parse(Console.ReadLine() ?? " ");
if (eng >= 50 && urdu >= 50)
{
    Console.WriteLine("You are Pass ab party yayyyy ! ");
}
else if (eng >= 60 && urdu <= 20)
{
    Console.Write("urdu me mehnat kon key ga ? ");
}
else if (eng <= 20 && urdu >= 60)
{
    Console.Write("English ka subject hi chor dety hain. ");

}
else
{
    Console.WriteLine("OoO Bhai Sahab ap ny toh top kiya ha nichy sy :D ");
}