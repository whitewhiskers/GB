int [] array = {15,21,38,42,48,75,66,77,48};

int n = array.Length;
int find = 48;
int index = 0;
while (index<n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}