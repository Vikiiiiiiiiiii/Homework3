/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да   */

int GetNumber(string message) 
{     
    int result = 0;     
    bool isCorrect = false;       
    
    while(!isCorrect)     
    {         
        Console.WriteLine(message);          
        
        if(int.TryParse(Console.ReadLine(), out result) && result >= 10000 && result < 100000)         
        {             
            return result;       
        }         
        else         
        {             
            Console.WriteLine("Ввели не число или не пятизначное число");         
        }     
    }      
    return result; 
}  

int lin = GetNumber("Введите число: "); 

void strNumber(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine($"{number} - палиндром.");
  }
  else Console.WriteLine($"{number} - не палиндром.");
}

  strNumber(lin.ToString());

