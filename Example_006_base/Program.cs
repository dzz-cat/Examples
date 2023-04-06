// Нахождение максимального числа из имеющихся. Задача с гирями

// прописываем целые числа из задачи
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (a > max) max = a; // если  в значении а - максимум, то положить ее в значение переменной max
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Max = ");
Console.WriteLine(max);