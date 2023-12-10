int[] array = KolvoChetn(5, 0, 10);
System.Console.WriteLine(Print(array));
System.Console.WriteLine(ReversArrt(array));
System.Console.WriteLine(Print(array));


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

static int[] ReversArrt(int[] array){
    int size=array.Length/2;
    int j=array.Length-1;
    for (int i = 0; i < size; i++)
    {
        int num1=array[i];
        int num2=array[j];
        array[j]=num1;
        array[i]=num2;
        j--;
    }
    
    return array;
    
        
    
}
