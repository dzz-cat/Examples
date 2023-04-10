// int Max(int arg1, int arg2, int arg3) 

// // тело метода
// {
// int result = arg1; 
// if (arg2 > result) result = arg2;
// if (arg3 > result) result = arg3;
// return result;
// }
//  //              0   1   2   3   4   5   6   7   8
// int[] array = { 15, 21, 39, 12, 23, 41, 13, 23, 33 }; //определем массив
// // array [0] = 15;
// // Console.WriteLine(array[8]);

// int result = Max(
//     Max(array[0], array[1], array[2]),  
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );

// Console.WriteLine(result);


// Задача:
// есть массив array, в котором n элементов. Найдём элемент, совпадающий с
// некоторым значением, который определяет пользователей.
// 1. Сохраним его в переменную find. Затем установим счётчик в нулевую позицию.
// 2. Если на текущей позиции элемент совпал с find, операцию можно завершить, потому
// что мы нашли позицию.
// 15
// 3. Если элемент не совпал с find, увеличиваем значение счётчика index на 1 и переходим
// на предыдущий шаг.
// 4. Сравниваем снова. И если элемент совпал с find, значит, алгоритм закончил работу.
// 5. Если элемент совпал с find, снова увеличиваем индекс. Смотрим результат.
// 6. В результате если элемент находится, операция завершается успешно. А если этого
// элемента так и нет, надо сообщить об этом.

// поиск позиции нужного элемента
// int[] array = { 1, 21, 39, 12, 23, 33, 41, 13, 23, 33 };
// int n = array.Length; 
// int find = 33;
// int index = 0;
// while (index < n )
// {
//    if (array[index]== find )
//         {
//             Console.WriteLine(index);
//             break; // завершение работы при первм найденом элементе, в прротивном случае выводятся все
//         }
//    // index = index + 1;
//    index++;
// }

// Задача: Вывод массива из 10 элементов

// void FillArray(int[] collection) //  Void  - метод который ничего не вовращает  
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//      {
//         collection[index] = new  Random().Next(1, 10);
//         index++;
//      }
// }

// void PrintArray(int[] col)

// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//         {
//             Console.WriteLine(col[position]);
//             position++;
//         }
// }

// int[] array = new int[10]; // создать новый массив в котором будет 10 элементов
// FillArray(array); //  метод который заполняем массив 
// PrintArray(array); // метод который выводит массив


// синтаксис языка:
void FillArray(int[] collection) //  Void  - метод который ничего не вовращает  В качестве аргумента будет приниматься какая-то коллекция, то есть аргумент collection
{
    int Length = collection.Length; //надо получить длину нашего массива
    int index = 0; //  На следующем этапе возьмём позицию index, которая по умолчанию будет начинаться с 0
    while (index < Length) // Теперь в цикле while пропишем index < length. 
     {
        collection[index] = new  Random().Next(1, 10); // обратимся к аргументу collection на позицию index и положим туда новое случайное число — целое число из диапазона 1–10.
        index++; // усли не завершен, то прибавляем единицу
     }
}

void PrintArray(int[] col) // метод void, который будет печатать массив. Аналогичным образом в качестве аргумента здесь будет приходить массив

{
    int count = col.Length; // количество элементов
    int position = 0; // обозначим текущую позицию не через именование перемен index, а через position
    while (position < count)
        {
            Console.WriteLine(col[position]); // выведем через Console.WriteLine значение текущего элемента, то есть col[position].
            position++; // увеличиваем значение текущей позиции
        }
}

int IndexOff(int[] collection, int find) // возвращать позицию, то есть index. Назовём этот метод IndexOf, а в качестве аргумента будет приходить массив collection и какой-то элемент find.
{
 int count = collection.Length; // Далее определяем количество элементов через count — collection.Length.
 int index = 0; // Нам потребуются индексы, чтобы щёлкать массив, пусть это будет переменная index
 int position = -1; // определим новую переменную position. если элемента нет, то вохвращаем -1

 while (index < count) 
 {
    if(collection[index] == find) // если collection[index] совпал с find, 
    {
         position = index; //то положить ее в position
         break;
    }
    index++;
 }

 return position;
}

int[] array = new int[10]; // создать новый массив в котором будет 10 элементов
FillArray(array); //  метод который заполняем массив 
PrintArray(array); // метод который выводит массив
Console.WriteLine();
int pos = IndexOff(array, 4); //Определим переменную pos и положим в неё результат работы метода IndexOf
Console.WriteLine(pos);