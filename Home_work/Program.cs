/* Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/
int[] GetArrayEvenNumber(int[] array)
{
    int[] arrayEvenNumber = new int[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            if (array[i] % 2 == 0)
            {
                Array.Resize(ref arrayEvenNumber, arrayEvenNumber.Length + 1);
                arrayEvenNumber[count] = array[i];
                count++;
            }
        }
    }
    return arrayEvenNumber;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+" ");
    }
}
int[] GetArrayInteger(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int[] numbersArray = new int[new Random().Next(0, 10)];
numbersArray = GetArrayInteger(numbersArray);
PrintArray(numbersArray);
System.Console.WriteLine();
numbersArray = GetArrayEvenNumber(numbersArray);
PrintArray(numbersArray);
