// See https://aka.ms/new-console-template for more information

using System;
					
public class Program
{
	public static void Main()
	{
		  int n, i, m=0, flag=0;  
          Console.Write("Enter the Number to check Prime: ");
		  //read number
          n = int.Parse(Console.ReadLine());  
		  //divide it by 2 and get remainder
          m=n/2;    
		  //loop until the remainder is reach, check if it is divisble
          for(i = 2; i <= m; i++)    
          {    
			  // if divisible by any number from 2 to m, then it is not prime
             if(n % i == 0)    
             {    
               Console.WriteLine("Number is not Prime.");    
               flag=1;    
               break;    
             }    
          }    
		  // if flag =0, means,above code when flag =1 is assigned is not executed and hence it is prime number
          if (flag==0){
			   Console.WriteLine("Number is Prime.");
		  }
	}
}