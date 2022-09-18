// Программа задает две квадратные матрицы одного размера и находит их произведение.
Console.Clear();
Random rand = new Random();

// функция заполнения двумерного массива случайными числами
void fill_array(int [,]arr)
{
 for(int i=0; i < arr.GetLength(0); i++)
 { 
   for(int j=0; j < arr.GetLength(1); j++)
   {
     arr[i,j] = rand.Next(0,10);
   }
 }
}  

// функция нахождения произведение двух матриц 
int [,] comp_array(int [,] array1, int [,] array2)
{
   int [,] array = new int [array1.GetLength(0),array1.GetLength(1)];
   for(int i=0; i < array1.GetLength(0); i++)
   {
      for(int j=0; j < array1.GetLength(1); j++)
      {
         for(int k=0; k < array1.GetLength(0) ; k++)
         {
         array[i,j] = array[i,j] + array1[i,k] * array2[k,j];
         }
      }
   }
   return array;
}
// основная программа
int row = rand.Next(2,10); // задаем количество строк
int column = row; // задаем количество столбцов
int [,] first_array = new int [row,column]; // создаем двумерный массив 1
int [,] second_array = new int [row,column]; // создаем двумерный массив 2
int [,] composition = new int [row,column]; // массив произведения матриц

// заполняем двумерные массивы случайными числами  
fill_array(first_array);
fill_array(second_array);
// находим произведение массивов
composition = comp_array(first_array, second_array);

// выводим результаты
Console.WriteLine("массив 1          массив 2"); 
for(int i=0; i < first_array.GetLength(0); i++)
{
   for(int j=0; j < first_array.GetLength(1); j++)
   {
     Console.Write(first_array[i,j] + "  ");
   }
   Console.Write("            ");
   for(int j=0; j < second_array.GetLength(1); j++)
   {
     Console.Write(second_array[i,j] + "  ");
   }
   Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("произведение ");

for(int i=0; i<row; i++)
{
   for(int j=0; j<column; j++)
   {
     Console.Write(composition[i,j] + "  ");
   }
   Console.WriteLine();
}
