﻿// Виды методов
// Вид 1: Ничего не принимает, ничего не возвращает. Ключевое слово void, в скобках нет аргументов.
void Method1()
{
    Console.WriteLine("Автор - Князева Анна");
}

// Как вызываются такие методы: название метода и обязательно скобки!
// Method1();

// Вид 2: Ничего не возвращают, но могут принимать какие-то аргументы.
void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Вызываем:
// Method2(msg: "Текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Вызываем:
// Method2_1(msg: "Текст", count: 4);
// Method2_1(count: 4, msg: " Новый текст");

// Вид 3: Что-то возвращают, но ничего не принимают. Надо обязательно указать тип данных, который мы ожидаем
int Method3()
{
    return DateTime.Now.Year;
}

// Вызываем:
int year = Method3();
// Console.WriteLine(year);

// Вид 4: Что-то принимают, что-то возвращают
// string Method4(int count, string text)
// {
//    int i = 0;
//    string result = String.Empty;

//   while (i < count)
//    {
//       result = result + text;
//        i++;
//    }
//    return result;
// }

// цикл for: for (инициализация внутренней переменной цикла; условие; инкремент (i++))
string Method4(int count, string text)
{
    
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

// Вызыываем:
string res = Method4(count: 10, text: "z");
// Console.WriteLine(res);

// Цикл в цикле. Вывод таблицы умножения на экран. Таблица умножения начинается с двух, поэтому изначально  i = 2.

// for (int i = 2; i <= 10; i++)
// {
//    for (int j = 2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} x {j} = {i * j}");
//    }
    // Переход на новую строку после выполнения внутреннего цикла
    // Console.WriteLine();
// }

// ======= Работа с текстом. 
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // вывод r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
