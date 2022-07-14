int [] array = {1, 2, 3, 4, 243, 5, 6, 44, 77, 12, 566, 243, 777, 245, 666};

int n = array.Length;
int find = 243;
int index = 0;

while(index < n)
{
    if (array[index] == find)
  {Console.WriteLine(index);
   break;
            //   остановка после первого найденного числа
  }
    index++;
}
