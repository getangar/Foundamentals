int BinarySearch(int[] inputArray, int key)  
{ 
  int min = 0;
  int max = inputArray.Length - 1; 
    while (min <=max)  
    {  
       int mid = (min + max) / 2;  
       Console.WriteLine($"Mid = {mid}");

       if (key == inputArray[mid])  
       {  
            return ++mid;  
       }  
       else if (key < inputArray[mid])  
       {  
           max = mid - 1;
           Console.WriteLine($"Min = {min}, Max = {max}");
       }  
       else  
       {  
            min = mid + 1;  
            Console.WriteLine($"Min = {min}, Max = {max}");
       }  
   }  
   return -1;  
}  

int[] array = { -3, 2, 1, 10, -4, -1, -5, 11 };
Array.Sort(array);
int value = -5;

int position = BinarySearch(array, value);

if (position == -1) {
    Console.WriteLine("Value not found");
} else {
    Console.WriteLine($"{value} found in position {position}");
}