// Hаписать программу, которая из имеющегося 
//массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.

string[] array1 = new string[5] {"hello", "2", "world", ":-)", "123567"};
string[] array2 = new string[array1.Length];
void ConditionalArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ConditionalArray(array1, array2);
PrintArray(array2);