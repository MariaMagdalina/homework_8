// Программа формирует двумерный массив из неповторяющихся двузначных чисел
Console.Clear();
Random rand = new Random();

bool Contains(int[,] arr, int value) 
{
    for(int i =0; i < arr.GetLength(0) ; i++)
      {
         for(int j=0; j < arr.GetLength(1) ; j++)
         {
            if(arr[i,j] == value)
            return true;
         }
      }
    return false;
}

// функция заполнения двумерного массива случайными числами
void fill_array(int [,] array)
{
   for(int i=0; i < array.GetLength(0); i++)
      {
         for(int j=0; j < array.GetLength(1); j++)
         {
            int value = rand.Next(10,100);
            while(Contains(array, value))
            {
               value = rand.Next(10,100);              
            }
             array[i,j] = value;
         }
      }
}  



// основная программа
int row = rand.Next(2,8); // задаем количество строк
int column = rand.Next(2,8); // задаем количество столбцов
int [,] array = new int [row,column]; // создаем двумерный массив 1
fill_array(array); // заполняем массив элементами
// выводим массив
 for(int i=0; i < array.GetLength(0); i++)
 { 
   for(int j=0; j < array.GetLength(1); j++)
   {
     Console.Write(array[i,j] + "  ");
   }
   Console.WriteLine();
 }
