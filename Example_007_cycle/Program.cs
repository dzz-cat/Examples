// использование цикла

//  Алгоритм:
// Определить три точки
// Выбрать две любых
// Найти середину
// Поставить точку
// Выбрать случайную вершину треугольника
// Соединить её с полученной на 4 шаге точкой
// Перейти к шагу 3
// Шаги 3-7 построить 9, 28, 31 раз 

Console.Clear();
// Console.SetCursorPosition(10, 4); // положение курсора 10 х и 4 по у
// Console.WriteLine ("+");

int xa = 15, ya = 1,
    xb = 1, yb = 15,
    xc = 30, yc = 15;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

/////////

int x = xa, y = xb;
int count = 0;
while(count <10000)
{
    int what = new Random().Next(0, 3); //генерация случайного числа  what  через генератор случайных чисел // выбор одной из трех числел, диапазон 0 до 3
    
    if(what == 0) //если число what равно нулю
    {
        x =(x + xa) / 2; // то в х мы кладем середину отрезка на первой вершине
        y = (y + ya) / 2;
    }

    if(what == 1) //если число what равно 1
    {
        x =(x + xb) / 2; // то в х мы кладем середину отрезка на первой вершине
        y = (y + yb) / 2;
    }

     if(what == 2) //если число what равно 2
    {
        x =(x + xc) / 2; // то в х мы кладем середину отрезка на первой вершине
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;  // count = count +1 
}