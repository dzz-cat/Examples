// Задача: найти максимум из 9 чисел



// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

// int max = a1; //определим переменную максимум, куда положено значение первого аргумента
// if  (b1 > max) max = b1;   //если значение новой переменной, то есть b1, больше max, то в max положим b1:
// if  (c1 > max) max = b1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a2;
// if (b3 > max) max = b2;
// if (c3 > max) max = c2;

//Console.WriteLine(max); // выводим максимальное зачение


// испльзуем метод 

int Max(int arg1, int arg2, int arg3) // наша функция будет проделывать такую работу: возьмёт три числа и найдёт 
// из них максимальное. Затем мы возьмём следующие три числа и найдём максимальное, повторим
// это действие несколько раз, а потом устроим суперфинал. 

// тело метода
{
int result = arg1; 
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 1123;
int c2 = 33;
int a3 = 513;
int b3 = 23;
int c3 = 33;

//результатом работы функции max  будет являтся максимальное из трех чисел a1, b1,c, 

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);