int[] nums = { 1, 4, 0, 9, 8 };
nums[0] = 1;
nums[1] = 4;
nums[2] = 0;
nums[3] = 9;
nums[4] = 8;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("nums [" + i + "] = " + nums[i]);
}

int[] marks = new int[6];
marks[0] = 3;   
marks[1] = 5;
marks[2] = 2;
marks[3] = 3;
marks[4] = 4;
marks[5] = 5;
int sum = 0;
for (int i = 0; i < 6; i++)
{
    sum = sum + marks[i];  
}
float average = (float)sum / marks.Length;
Console.WriteLine("Оценки:");
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine("Оценка №" + (i + 1) + ": " + marks[i]);
}
Console.WriteLine("Сумма всех оценок: " + sum);
Console.WriteLine("Средний балл: " + average);

int[] numbers = new int[8];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1, 101);
}
int max = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i]; 
    }
}
Console.WriteLine("Сгенерированные числа:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Максимальное число: " + max);

string[] fruits = { "яблоко", "банан", "апельсин", "груша", "мандарин" };
Console.WriteLine("Список фруктов:");
foreach (string fruit in fruits)
{
    Console.WriteLine("Фрукт: " + fruit);
}
int[,] matrix = new int[3, 3];
int[,] matrix1 = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix1[i, j] + " ");
    }
    Console.WriteLine();
}
int number = 1234;
string password;

do
{
    Console.Write("Введите пароль: ");
    password = Console.ReadLine();

    if (password == "1234")
    {
        Console.WriteLine("Доступ разрешён!");
        break; // Выходим из цикла, если пароль верный
    }
    else
    {
        Console.WriteLine("Неверный пароль. Попробуйте ещё раз.");
    }
}
while (number == 1234);
