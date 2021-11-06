// //Имеется числовой массив A заполненный числами из отрезка 
//[minValue; maxValue]. Создать на его основе масив B, отбрасывая те, 
//которые нарушают порядок
// возрастания
// элементы, больше 8
// знакочередования

int minValue=-100;
int maxValue=200;
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
Console.WriteLine($"Печать массива случайных чисел в интервале от {minValue} до {maxValue}");
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
Console.WriteLine($"Найдено {count} значений по возрастанию");

int[] B = new int [count]; 
B[0]=A[0];
current=A[0];
int j=1;
for (i = 1; i < 10; i++)
{
  if (A[i]>current) 
  {B[j]=A[i]; j++;current=A[i];}
  
}
PrintArray(B);
Console.WriteLine();

Console.WriteLine ("Вывод массива c числами больше 8");
count=0;
i=0; j=0;

while ( i<10 )
{
  if (A[i]>8) {count=count+1;}
  i++;
}
Console.WriteLine($"Найдено {count} значений больше 8");
int[] D = new int [count]; 
j=0;

for (i=0; i<10; i++)

{
  if (A[i]>8) 
  {D[j]=A[i]; j++;}
  
}
PrintArray(D);
Console.WriteLine();


int znak=1;
Console.WriteLine ("Вывод массива знакочередования");
if (A[0]<0) znak=0;
//Console.WriteLine($"{znak} {A[0]}");
i=0; count=0;
while (i<10)
{
  if ((A[i]<0) && (znak==0)) {count=count+1;znak=1;}
    else if ((A[i]>0) && (znak==1)) {count=count+1;znak=0;}
  i++;
}  
Console.WriteLine($"Найдено {count} значений со знакочередованием");

int[] E = new int [count]; 
j=1;
E[0]=A[0];
if (A[0]<0) znak=0;
for (i=0; i<10; i++)

{
  if ((A[i]<0) && (znak==0)) {E[j]=A[i]; j++;;znak=1;}
    else if ((A[i]>0) && (znak==1)) {E[j]=A[i]; j++;znak=0;}
  
}
PrintArray(E);
Console.WriteLine();
