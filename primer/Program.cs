// //Имеется числовой массив A заполненный числами из отрезка 
//[minValue; maxValue]. Создать на его основе масив B, отбрасывая те, 
//которые нарушают порядок
// возрастания
// элементы, больше 8
// знакочередования

int minValue=10;
int maxValue=100;
Console.WriteLine ("Введите мин значение:");
minValue = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите макс значение:");
maxValue = Convert.ToInt32(Console.ReadLine ());

void PrintArray(int[]arr)
{
for (int i=0; i<arr.Length; i++)
 {
  Console.WriteLine($"{(arr[i]} ");
 }
 Console.WriteLine();Console.WriteLine();
}

int GetRandom ()
{
  return new Random().Next(minValue,maxValue);
  }
int i=0;

int[] A = new int [10];
while (i<10)
{
//A[i]= new Random().Next(10,100);
A[i]=GetRandom();
i++;
}
// печать массива А
i=0;
while (i<10)
{ Console.Write(A[i]+" "); i++;}
Console.WriteLine();

i=1;
int j=1;
B[0]=A[0];

while (i<10)
{
  if (A[i-1]<A[i]) {B[j]=A[j];
  j++;}
  i++;
}




i=0;
int[] B = new int [10];
while (i<10)
{
  if (A[i]>80) 
  {
  B[i]= A[i+1];
  }
  i++;
}

i=0;
while (i<10)
{
Console.Write(A[i]+" ");
i++;
}












