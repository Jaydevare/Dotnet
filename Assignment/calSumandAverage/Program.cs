int x = 0;
Console.WriteLine("Enter Marks of % subjects");
for (int i = 0; i < 5; i++)
{
    int n = int.Parse(Console.ReadLine());
    x += n;
}
Console.WriteLine("total of marks is ");

Console.WriteLine(x);
Console.WriteLine("avg of marks is ");
float avg = x / 5;
Console.WriteLine(avg);

