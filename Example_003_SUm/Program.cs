// нахождение суммы двух чисел
// вводим переменную, где будет хранится число
// int numberA = 32;
//вводим переменную второго числа
//int numberB = 5;

//нахождение случайного целого числа
int numberA = new Random().Next(1, 10); //случайное число 0,1,2....9
Console.WriteLine(numberA); //выводим сгенерированное число в консоль
int numberB = new Random().Next(1, 10); //случайное число 0,1,2....9
Console.WriteLine(numberB); //выводим сгенерированное число в консоль

// выводим  в консоль сумму  числел
// Console.WriteLine(numberA + numberB);

// упрощаем код сохранение результата в доп переменную
int result = numberA + numberB;
Console.WriteLine(result);




