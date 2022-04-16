int [] array = {12, 1, 2, 3, 43, 56, 5, 6, 7, 8, 9, 12};
int n = array.Length;
int find = 12;
int index = 0;
while (index<n)
{
    if (array[index]== find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index +1; // index ++
}