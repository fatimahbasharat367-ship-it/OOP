int[] number = new int[5];

for (int i = 0; i < 3; i++)
{
    Console.Write("Enter n : ");
    number[i] = int.Parse(Console.ReadLine() ?? " ");
}

int temp = -1;
for (int i = 0; i < 5; i++)
{
    if (number[i] > temp)
    {
        temp = number[i];

    }

}
Console.Write("Greater number is : " + temp);
