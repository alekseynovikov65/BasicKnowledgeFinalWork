string[] inputArray1 = new string[]
{
    "Hello", "2", "world", ":-)"
};
string[] inputArray2 = new string[]
{
    "1234", "1567", "-2", "computer science"
};
string[] inputArray3 = new string[]
{
    "Russia", "Denmark", "Kazan"
};

DoBasicKnowledgeFinalWork(inputArray1);
DoBasicKnowledgeFinalWork(inputArray2);
DoBasicKnowledgeFinalWork(inputArray3);

void DoBasicKnowledgeFinalWork(string[] inputArray)
{
    string[] outputArray = FillArray(inputArray);
    PrintArray(outputArray);
}

string[] FillArray(string[] inputArray)
{
    return null;
}

string[] AddElement(string[] array, string item)
{
    if (array == null)
    {
        return new string[] { item };
    }
    string[] result = new string[array.Length + 1];
    array.CopyTo(result, 0);
    result[array.Length] = item;
    return result;
}

static void PrintArray(string[] outputArray)
{
    Console.Write("[");
    for (int i = 0; i < outputArray.Length; i++)
    {
        var element = outputArray[i];
        Console.Write($"""{element}""");
        if (i != outputArray.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}
