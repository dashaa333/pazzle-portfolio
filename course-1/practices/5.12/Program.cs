using System.Xml.Linq;

void SayHello()
{
    Console.WriteLine("Привет, мир!");
        }
SayHello();
SayHello();
SayHello();
void Greet(string name)
{
    Console.WriteLine("Привет, " + name + "!");
}

Greet("Дарья");
Greet("Ярослав");
void PrintPerson(string name, int age, string city)
{
    Console.WriteLine($"Name: {name}  Age: {age} City: {city}");
}

PrintPerson("Егор", 15, "Москва");

void PrintPerson1(string name, int age = 18, string hobby = "Не указано")
{
    Console.WriteLine($"Name: {name}  Age: {age} Hobby: {hobby}");
}

PrintPerson1("Алина", 17, "Рисование");
PrintPerson1("Матвей");
int Square(int x)
{
    int square = x * x;
    return square;
}

int result = Square(11);
Console.WriteLine("Квадрат числа: " + result);
int counter = 0;
void Increment()
{ 
    counter++;
}
Console.WriteLine("До вызывов:" + counter);
Increment();
Console.WriteLine("Первый вызов:" + counter);
Increment();
Console.WriteLine("Второй вызов:" + counter);
Increment();
Console.WriteLine("Третий вызов:" + counter);
