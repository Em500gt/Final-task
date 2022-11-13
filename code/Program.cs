using static System.Console;
Clear();

WriteLine("Введите массив строк через пробел");
string[] first_mass = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] second_mass = new string[0];

PrintArray(first_mass);
Write(" -> ");
PrintArray(Enumeration(first_mass, second_mass));

string[] Enumeration(string[] arr_first, string[] arr_second)
{
    int index = 0;
    for(int i = 0; i < arr_first.Length; i++)
    {
        if(arr_first[i].Length < 4)
        {
            Array.Resize(ref arr_second, index + 1);
            arr_second[index] = arr_first[i];
            index++;
        }
    }
    return arr_second;
}

void PrintArray(string[] arr)
{
    if(arr.Length == 0) 
    {
        Write("[]");
        return;
    }
    Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]}, ");
    }
    Write($"{arr[arr.Length - 1]}]");
}