// //Имеется числовой массив A заполненный числами из отрезка 
//[minValue; maxValue]. Создать на его основе масив B, отбрасывая те, 
//которые нарушают порядок
// возрастания
// элементы, больше 8
// знакочередования

int minValue=10;
int maxValue=1000;
// Console.WriteLine ("Введите мин значение:");
// minValue = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine ("Введите макс значение:");
// maxValue = Convert.ToInt32(Console.ReadLine ());

void PrintArray(int[]arr)
{
for (int i=0; i<arr.Length; i++)
 {
  
  Console.Write($"{(arr[i])} ");
 }
 Console.WriteLine();
}
 //Console.WriteLine($"Третьей цифрой числа {i} является {i}");

int GetRandom ()
{
  return new Random().Next(minValue,maxValue);
}

int i=0;
int[] A = new int [10];
while (i<10)
{
A[i]=GetRandom(); i++;
}
// печать массива А

Console.WriteLine("Печать массива:");
i=0;
PrintArray(A);

Console.WriteLine ("Вывод массива элементов по взрастанию");
int current=A[0];
int count=1;
while (i<10)
{
  if (A[i]>current) 
  { current=A[i];count=count+1;}
  i++;
}
Console.WriteLine(count);

int[] B = new int [count]; 
B[0]=A[0];
current=A[0];
int j=1;
for (i = 1; i < 10; i++)
{
  if (A[i]>current) 
  {B[j]=A[i]; j++;current=A[i];}
  
}
Console.WriteLine();
PrintArray(B);


/*Console.WriteLine ("Вывод массива c числами больше 8");
i=1; j=1;
Console.Write (current+" ");

int[] С = new int [10]; 
С[0]=A[0];
while ( i<10 )
{
  if (A[i]>8) 
  {С[j]=A[i]; Console.Write(С[j]+" "); j++;}
  i++;
}
Console.WriteLine();
PrintArray(B);


// if (i%2==0)
// {
//   if (A[i]<0) 
// }



Console.WriteLine ("Вывод массива знакочередования");
i=1;
j=1;
current=A[0];
Console.Write (current+" ");

B[0]=A[0];
while ( i<10 )
{
  if (A[i]>current) 
  {B[j]=A[i]; Console.Write(B[j]+" "); j++;current=A[i];}
  i++;
  
}
Console.WriteLine();

PrintArray(B);



//B[0]=A[0];

// while (i<10)
// {
//   if (A[i-1]<A[i]) {B[j]=A[j];
//   j++;}
//   i++;
// }




// i=0;
// int[] B = new int [10];
// while (i<10)
// {
//   if (A[i]>80) 
//   {
//   B[i]= A[i+1];
//   }
//   i++;
// }

// i=0;
// while (i<10)
// {
// Console.Write(A[i]+" ");
// i++;
// }







*/




