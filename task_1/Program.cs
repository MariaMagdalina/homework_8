// Данная программа находит в двумерном массиве строку с наименьшей суммой элементов.
Console.Clear();
Random rand = new Random();
int row = rand.Next(2,11); // задаем количество строк
int column = rand.Next(2,11); // задаем количество столбцов
int [,] array = new int [row,column]; // создаем двумерный массив
int [] summa = new int [row]; // создаем массив, элементами которого будут суммы строк двумерного массива

// заполняем двумерный массив случайными числами 
for(int i=0; i<row; i++)
{
   for(int j=0; j<column; j++)
   {
      array[i,j] = rand.Next(-1000,1000);
      Console.Write(array[i,j] + "  ");
   }
   Console.WriteLine();
}

// заполняем одномерный массив
for(int i=0; i<row; i++)
{
   int sum = 0;
   for(int j=0; j<column; j++)
   {
      sum = sum + array[i,j];
   }
   summa[i] = sum;
   Console.WriteLine("сумма элементов в строке " + i + " = " + summa[i]);
}

int min = summa[0]; // вводим переменную для поиска минимального значения, присваиваем ей значение элемента массива с индексом 0
int num_min = 0; // номер минимального элемента в массиве (номер строки в двумерном массиве), присваиваем значение 0
for(int i=1; i < row ; i++)
{
   if(summa[i] < min) // сравнимаем элементы массива с текущим значением min
      {
         min = summa[i];
         num_min = i;
      }
} 

Console.WriteLine(num_min + " cтрока является строкой с наименьшей суммой элементов");

