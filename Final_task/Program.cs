string[] array = {"Hello", "2", "world", ":-)"};
string[] NewArray = new string[array.Length];


void NewArrayIf(string[] array, string[] NewArray)
{
    int size = 0;
for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        NewArray[size] = array[i];
        size++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

NewArrayIf(array, NewArray);
PrintArray(NewArray);
