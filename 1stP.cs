using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
       /* int a=6;
        int b=8;
        Console.WriteLine("Sum of "+a+" and "+b+" = " +(a+b));
        Console.WriteLine(a-b);
        Console.WriteLine(a*b);
        Console.WriteLine(a/b);
        Console.WriteLine(a==b);*/
    
      /*string name = "Simanta";
        Console.WriteLine("Name : {0}", name);
        byte age = 23;
        Console.WriteLine("Age : {0}", age);
        char gender = 'M';
        Console.WriteLine("Gender : {0}", gender);
        float percentage = 89.5F;
        Console.WriteLine("% : {0}", percentage);
        
        
        Console.ReadLine();
        */

       /*int firstNumber, secondNumber, result;
        Console.Write("\nEnter First Number : ");
        firstNumber=Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\nEnter Second Number : ");
        secondNumber=Convert.ToInt32(Console.ReadLine());
        result= firstNumber + secondNumber;
        Console.WriteLine("\nResult :" +result);
        */

       /*int a=2;
        Console.WriteLine(a/2);
        Console.WriteLine(a%2);
        
        if(a%2==0)
        {
        Console.WriteLine(a+" is an even number");
        }
        else
        {
            Console.WriteLine(a+" is odd");
        }
        */
        
        /*int a;
       Console.Write("\nEnter Age : ");
       a=Convert.ToInt32(Console.ReadLine());
        if(a<18)
        {
        Console.WriteLine(a+"\n is not eligible to vote");
        }
        else if(a>=60)
        {
            Console.WriteLine(a+"\n is Senior Citizen");
        }
        
        else
        {
            Console.WriteLine(a+"\n is eligible to vote");
        }
        */


     /*   Console.WriteLine("Enter choice: \n1. ADD \n2. SUB \n3. MUL");
        int choice=Convert.ToInt32(Console.ReadLine());
        
        switch (choice)
        {
            case 1:
             Console.WriteLine("Add");
             break;
        
            case 2:
             Console.WriteLine("Sub");
             break;
             
            case 3:
             Console.WriteLine("Mul");
             break;
          
          default:
           Console.WriteLine("Nothing");
           break;
        }
       */ 
        
        /*int[] arr= new int[5];
        int sum=0;
        Console.WriteLine("enter numbers: \n");
        for (int i=0; i<arr.Length; i++)
        {
            arr[i]= Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("----------");
        
        for (int i=0; i<arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
         sum=sum+arr[i];   
        }
        Console.WriteLine("Sum=" +sum);*/
        
        
        
        int [,] arr= new int[2,2];
        Console.WriteLine("enter elements: \n");
        for (int row=0; row<arr.GetLength(0); row++)
        {
            for (int col=0; col<arr.GetLength(1); col++)
            {
                arr[row,col]= Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("----------");
        
        for (int row=0; row<arr.GetLength(0); row++)  
        {
            for (int col=0; col<arr.GetLength(1); col++)
            {
                Console.Write(arr[col,row] + "\t");
            }
            Console.Write("\n");
        }
        
    }

}
