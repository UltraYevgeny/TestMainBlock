void ShowArray(string[] newArray)
{
    Console.Write("[");
    for (int i = 0; i < newArray.Length-1; i++)
    {
        Console.Write($"{newArray[i]}, ");
    }
    Console.Write($"{newArray[newArray.Length-1]}]");
}

int ArrayCount(string[] array)
{
    int letterCount = 0;
    int newArrayCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        letterCount = array[i].Length;
        if (letterCount <= 3)
            newArrayCount++;
    }
    return newArrayCount;
}

string[] array = {"Lazzer", "13", "Sub Zero", "Q", "2023", "XYZ"};
string[] newArray = new string[ArrayCount(array)];
int newArrayCount = 0;
int letterCount = 0;

for (int i = 0; i < array.Length; i++)
{
    letterCount = array[i].Length;
    if (letterCount <= 3)
    {
        newArray[newArrayCount] = array[i];
        newArrayCount++;
    }
}

ShowArray(newArray);