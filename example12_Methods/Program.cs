// Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор Верюханов Илья");
// }
// Method1();






// Вид 2

// void Method2(string msg)
// {
//   Console.WriteLine(msg);
// }
// // Method2("Текст сообщения");

// void Method21(string msg , int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4);


// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// Вид 4

// string Method4(int count , string text)
// {
//   int i = 0;
//   string result = string.Empty;

//   while(i < count)
//   {
//     result = result + text;
//     i++;
//   }
//   return result;
// }
// string Method4(int count , string text)
// {

//   string result = string.Empty;
//   for(int i = 0 ; i < count; i++)
//   {
//     result = result + text;
//   }
//   return result;
// }
// string res = Method4(10 , "z");
// Console.WriteLine(res);

// for(int i = 2; i <= 10; i++)
// {
//    for(int j = 2; j <= 10; j++)
//    {
//     Console.WriteLine($"{i} * {j} = {i * j}");
//    }
// Console.WriteLine();
// }

// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.
// Ясна ли задача?


// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + " ежели бы вас послали вместо нашего милого Винценгероде,"
//             + " вы бы взяли приступом согласие прусского короля "
//             + " Вы так красноречивы. Выдадите мне чаю?";

//  string s = "qwerty"          
//              012345
//    s[3] = r      

// string Replace(string text , char oldValue , char newValue)
// {
//   string result = String.Empty;

//   int length = text.Length;
//   for(int i = 0; i < length; i++)
//   {
//     if(text[i] == oldValue) result += $"{newValue}" ;
//     else result += $"{text[i]}" ;
//   }
//    return result;
// }
// String newText = Replace(text , ' ' ,'|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text , 'к' ,'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'с' , 'С');
// Console.WriteLine(newText);


int[] arr = { 1, 5, 7, 2, 6, 8, 4 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
   for(int i = 0 ; i < array.Length - 1 ; i++)
   {
    int minPosition = i;
    for(int j = i+1 ; j < array.Length ; j++)
    {
      if(array[j] < array[minPosition]) minPosition = j;
    }


    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
   }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);