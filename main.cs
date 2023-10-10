using lecture__1_hw;
using lecture_1_hw;
static int InputCheck()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.Write("Некоректный ввод. Пожалуйста,введите число: ");
    }
    return num;
}

Student student = new Student() { Name = "Иван", Age = 30 };
Bag bag = new Bag() { Capacity = 5 };

Console.WriteLine("Введите количества кусочков пиццы:");

if (!bag.AddPizza(InputCheck(), bag))
{
    Console.WriteLine("Пицца не влезет");
}

else
{
    Console.WriteLine("Введите количество бутылок пива:");
    
    if (!bag.AddBeer(InputCheck(), bag))
    {
        Console.WriteLine("Пиво не влезет");
    }
    
    else
    {
        Console.WriteLine($"Имя: {student.Name}\nКолличество кусков пиццы: {bag.PizzaPieces}\nКоличество бутылок пива: {bag.BeerBottles}\n" +
            $"Степень сытость: {student.CountSatiety(bag)}\nСтепень опьянение: {student.CountDrunk(bag)}");
    }
}