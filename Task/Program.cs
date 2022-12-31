string [] array = new string [5] {"hlo", "man", "iron", "black", "thor"};
string [] temparray = new string [array.Length];
int index = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        temparray[index] = array[i];
        index += 1;
    }
}
for (int j = 0; j < temparray.Length; j++)
{
    Console.Write($"{temparray[j]} ");
}
