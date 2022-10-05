void Zadacha41()
{
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x =0;
double y =0;
x = (b2-b1)/(k1-k2);
y = k1*x+b1;
Console.WriteLine ($"({x};{y})");
}
//Zadacha41();

void Zadacha43()
{
Console.WriteLine("Количество чисел введенных пользователем");
int num = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [num];
FillArray (numbers);
Console.WriteLine("Пользователь ввёл следующие числа:");   
PrintArray (numbers);
int count = 0;
for ( int i =0; i< num; i++)
{
    if (numbers [i]>0)
     {
        count++;
     }
}
Console.WriteLine ($"Количество чисел больше 0 = {count}");
}
//Zadacha43();





void FillArray ( int[] numbers)
    {
        Random random = new Random();
        for( int i = 0; i < numbers.Length;  i++) 
        {
            numbers[i] = random.Next (-1000, 1000);
        }
    }




void PrintArray (int[] numbers)

    {
        
        Console.WriteLine();
         for( int i = 0; i < numbers.Length;  i++)
         {
         Console.Write ( numbers[i] + ", ");
         }
        Console.WriteLine();      
    }