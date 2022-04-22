// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше 
// либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгаритма. 

// Примеры:
// ["hello","2","world",":-)",]->["2",":-)"]
// ["1234","1567","-2","computer scince"]->["-2"]
// ["Russia","Denmark","Kazan"]->[]


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

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
    // Console.WriteLine(validSizeArray);
    return validSizeArray;
}

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
            if (currentElement.Length <= lengthElement) // && currentElement != element)
            {
                element = currentElement;
                break;
            }
            count = j + count;
        }
        resultArray[i] = element;
        count++;
    }
    return resultArray;
}

// string[] SearchElemtnt(string[] arr, int lengthElement, int sizeArray)
// {
//     string[] resultArray = new string[sizeArray];
//     // string element = string.Empty;
//     for (int j = 0; j < arr.Length; j++)
//     {
//         string currentElement = arr[j];
//         if (currentElement.Length <= lengthElement)
//         {
//             resultArray[j] = currentElement;
//             // break;
//         }
//     }
// }

string[] userArray = { "he", "2", "world", "2", ":-)", "he", ":-)", ":-)" };
// string[] userArray = { "hello", "2", "world", ":-)" };
// string[] userArray = { "1234", "1567", "-2", "computer scince" };
// string[] userArray = { "Russia","Denmark","Kazan" };
PrintArray(userArray);
Console.Write("->");
int lengthString = 3;
int validSizeArray = SearchValidSizeArray(userArray, lengthString);
PrintArray(GetLimitLengthElementArray(userArray, lengthString, validSizeArray));