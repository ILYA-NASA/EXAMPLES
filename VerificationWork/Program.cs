// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше 
// либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгаритма. 

// Примеры:
// ["hello","2","world",":-)",]->["2",":-)"]
// ["1234","1567","-2","computer scince"]->["-2"]
// ["Russia","Denmark","Kazan"]->[]

// уточняю размер искомого массива: 
int SearchValidSizeArray(string[] fullArray, int lengthElement)
{
    string[] validArray = new string[fullArray.Length];
    int countEmptyElement = 0;
    int validSizeArray = fullArray.Length;
    for (int i = 0; i < fullArray.Length; i++)
    {
        string currentElement = fullArray[i];
        if (currentElement.Length > lengthElement)
            countEmptyElement++;
    }
    validSizeArray -= countEmptyElement;
    if (validSizeArray == 0) validSizeArray++;
    return validSizeArray;
}

// формирую массив из строк, длина которых меньше либо равна заданному количеству символов: 
string[] GetLimitLengthElementArray(string[] fullArray, int lengthElement, int sizeArray)
{
    string[] resultArray = new string[sizeArray];
    string element = string.Empty;
    int count = 0;
    for (int i = 0; i < resultArray.Length; i++)
    {
        for (int j = count; j < fullArray.Length; j++)
        {
            string currentElement = fullArray[j];
            if (currentElement.Length <= lengthElement)
            {
                element = currentElement;
                count = j;
                break;
            }
            else count += j;
        }
        resultArray[i] = element;
        count++;
    }
    return resultArray;
}

// вывожу масивы на экран (использую формат из примеров задачи): 
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

// метод ввода первоначального массива с клавиатуры:
string[] UserEntersArray()
{
    Console.WriteLine("Укажите сколько строк Вы хотите ввести: ");
    int countString = Convert.ToInt32(Console.ReadLine());
    string[] newArray = new string[countString];
    if (countString <= 0) Console.WriteLine("Возвращайтесь, когда захотите что-нибудь ввести!");
    else
    {
        for (int i = 0; i < countString; i++)
        {
            Console.Write($"Введите строку №{i + 1}: ");
            newArray[i] += Console.ReadLine();
        }
    }
    return newArray;
}

// массивы из примеров задачи:
// string[] userArray = { "Russia", "Denmark", "Kazan" };
// string[] userArray = { "hello", "2", "world", ":-)" };
// string[] userArray = { "1234", "1567", "-2", "computer scince" };

int lengthString = 3; // количество символов в строках искомого массива (из условия задачи)
string[] userArray = UserEntersArray();
Console.WriteLine($"Введенные Вами строки и строки, длина которых меньше либо равна {lengthString} символам:");
PrintArray(userArray);
Console.Write("->");
int validSizeArray = SearchValidSizeArray(userArray, lengthString);
PrintArray(GetLimitLengthElementArray(userArray, lengthString, validSizeArray));