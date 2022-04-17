// 0. Разобраться\создать репозиторий на гитхабе
// 0.1 .gitignore
// 1. пока (не уточнены условия): уточнить условия
// 2. декомпозиция задачи
// 3. Выявить главный алгоритм
// 4. Проработка алгоритма
// 5. БЛОК-СХЕМА
// 6. Писать код!
// 7. Пока нет тестов - делать тестирование
// 8. Рефакторинг 
// 9. push'ите


// Задать массив из 12 элементов, 
// заполненных числами из [-9,9]. Найти сумму 
// положительных/отрицательных элементов массива

// New
// Задать массив из 12 элементов, 
// заполненных числами из [-9,9]. Найти сумму 
// положительных элементов массива

// - заполнить массив числами от -9 до 9
// - создать массив из валидных (т е > 0) элементов
// - + найти сумму элементов массива из предыдущего пунка
// - вывод массива
// - вывод результата

int count = 12;
// int[] arr = CreateAndFillArray(count);
 

int[] CreateAndFillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10); // [-9,10)
    }
    return array;
}

// заполнить массив числами от -9 до 9
void FillArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10); // [-9,10)
    }
}

// Печать массива
string PrintArray(int[] array)
{
    int size = array.Length;
    string print = String.Empty;
    for (int i = 0; i < size; i++)
    {
        print += $"{array[i]} ";
    }
    return print;
}

// создать массив из валидных (т е > 0) элементов
int[] GetValidArray(int[] array)
{
    int size = array.Length;

    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    int[] validArray = new int[count];

    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            validArray[j++] = array[i];
        }
    }
    return validArray;
}


// найти сумму элементов массива из предыдущего пунка
int SumItems(int[] arrayInput)
{
    int len = arrayInput.Length;
    int resultSum = 0;
    int index = 0;

    while (index < len)
    {
        resultSum += arrayInput[index];
        index += 1;
    }

    return resultSum;
}

count = 12;
// int[] arr = CreateAndFillArray(count);
int[] inputArr = new int[count];
FillArray(inputArr);
Console.WriteLine(PrintArray(inputArr));
Console.WriteLine();

int[] valid = GetValidArray(inputArr);
Console.WriteLine(PrintArray(valid));

File.WriteAllText("file.txt", PrintArray(valid));
int sum = SumItems(valid);
Console.WriteLine();
Console.WriteLine($"sum = {sum}");