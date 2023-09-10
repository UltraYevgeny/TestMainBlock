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