/*Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckDayNumber (int dayNumber) {
  if (dayNumber == 6)
  {
  Console.WriteLine("Суббота-выходной день");
  }
  if (dayNumber == 7) 
  {
    Console.WriteLine("Воскресенье-выходной день");
  }
  
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("В неделе всего 7 дней,введите число от 1 до 7");
  }
  else Console.WriteLine("Этот день не выходной");
}

CheckDayNumber(dayNumber);


Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int threeNumber()
{
   
int des = number / 10 % 10;


int result = des;
return result;
}
int res = threeNumber();
Console.WriteLine("Вторая цифра этого числа " +res); */




Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
int yourNumber()
{
int sot = number / 100;    
int des = number / 10 % 10;
int ed = number % 10;

int result = des;
return result;
}
int res = yourNumber();
Console.WriteLine("Вторая цифра этого числа " +res); 













