int[] marks = { 5, 4, 3, 5, 2, 5, 4 };
int sum = 0;           
int countFives = 0;    
int countTwos = 0;
for (int i = 0; i < marks.Length; i++)
{
    sum += marks[i];     

    if (marks[i] == 5)
    {
        countFives++;       
    }
    if (marks[i] == 2)
    {
        countTwos++;          
    }
}
double average = (double)sum / marks.Length;
Console.WriteLine("Оценки за неделю:");
for (int i = 0; i < marks.Length; i++)
{
    Console.Write(marks[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Средний балл: " + average.ToString("F2"));
Console.WriteLine("Количество пятёрок: " + countFives);
Console.WriteLine("Количество двоек: " + countTwos);
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine("Прямой порядок:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Обратный порядок:");
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();
for (int i = 1; i <= 20; i++)
{
    if (i % 2 != 0)  
    {
        continue;    
    }

    Console.Write(i + " "); 
}

Console.WriteLine();
string correctPassword = "1234";
string input;
Console.WriteLine("Введите пароль. У вас 3 попытки.");
for (int attempt = 1; attempt <= 3; attempt++)
{
    Console.Write("Попытка: ");
    input = Console.ReadLine();

    if (input == correctPassword)
    {
        Console.WriteLine("Доступ разрешён!");
        break; 
    }
    else
    {
        Console.WriteLine("Неверный пароль.");
        if (attempt == 3)
        {
            Console.WriteLine("Все попытки исчерпаны. Доступ запрещён.");
        }
    }
}
