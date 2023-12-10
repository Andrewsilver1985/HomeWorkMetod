int[] array = KolvoChetn(10, -1, 15);
System.Console.WriteLine(Print(array));
System.Console.WriteLine(Poschet(array));

static int[] KolvoChetn(int size, int num1, int num2)
{
    int[] array = new int[size];
    Random rnd = new();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(num1, num2);

    }
    return array;
}

static string Print(int [] array){
    string result = string.Join(" ", array);
    return result;
}

static int Poschet(int[] array){
    int count=0;
    foreach (int item in array)
    {
        if (item%2==0)
        {
            count++;            
        }
    }
    return count;
    
        
    
}
