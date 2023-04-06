//использование операторов If/else

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine(); // вводим строчное имя переменной = и считываем данные 


//проверка 
//if (username == "Маша") 

//ToLower  позволяет все симфолы строки перевести в нижний регистр 
if (username.ToLower() == "маша")
{  
    Console.WriteLine("Ура! Это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
    
}