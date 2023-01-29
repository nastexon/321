/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
*/


Console.WriteLine ("Введите фразу. Для корректной работы перед знаками припинания следует ставить пробел");

string phrase = Console.ReadLine ();;
string[] words = phrase.Split(' ');


    int j = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3)
        {
            j++;
        }
    }
    string[] arrayNew = new string[j];

    j = 0;
    for (int i = 0; i < words.Length; i++)
    {   ё
        if (words[i].Length <= 3)
        {
            arrayNew[j] = words[i];
            j++;
        }
    }

foreach (var word in arrayNew)
{
    System.Console.Write($"<{word}>");
}