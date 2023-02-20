// Виды методов
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
Console.WriteLine(res);