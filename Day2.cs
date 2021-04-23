using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value");
        var x=Console.ReadLine();
        Console.WriteLine(x);
        Console.WriteLine(x.GetType());
        Console.ReadLine();
    }
}
----------------------------------------------------------

using System.IO;
using System;

class Class1
{
    void sum(int a)
    {
        Console.WriteLine(a);
    }
    static void Main(string[] args)
    {
        Class1 class1= new Class1();
        class1.sum(5);
        Console.ReadLine();
    }
}

------------------------------------------------------------

using System.IO;
using System;

class Class1
{
    void CheckOddEven(int a)
    {
        if(a%2==0)
        {
        Console.WriteLine("Even Number");
        }
        else
        {
            Console.WriteLine("Odd Number");
        }
    }
    static void Main(string[] args)
    {
        Class1 class1= new Class1();
        class1.CheckOddEven(5);
        Console.ReadLine();
    }
}

----------------------------------------------------------


using System.IO;
using System;

class Class1
{
    void swap(int a, int b)
    {
        int temp= a;
        a=b;
        b= temp;
        Console.WriteLine("Inside Swap Fn");    
        Console.WriteLine("a= "+a);
        Console.WriteLine("b= "+b);
         
    }
    static void Main(string[] args)
    {
        Class1 class1= new Class1();
        int a= 3;
        int b= 6;
        class1.swap(a,b);
        Console.WriteLine("Inside Main Fn");
        Console.WriteLine("a= "+a);
        Console.WriteLine("b= "+b);
        Console.ReadLine();
    }
}

-------------------------------------------------------------

using System.IO;
using System;

class Class1
{
    void swap(ref int a, ref int b)
    {
        int temp= a;
        a=b;
        b= temp;
        Console.WriteLine("Inside Swap Fn");    
        Console.WriteLine("a= "+a);
        Console.WriteLine("b= "+b);
         
    }
    static void Main(string[] args)
    {
        Class1 class1= new Class1();
        int a= 3;
        int b= 6;
        class1.swap(ref a, ref b);
        Console.WriteLine("Inside Main Fn");
        Console.WriteLine("a= "+a);
        Console.WriteLine("b= "+b);
        Console.ReadLine();
    }
}


-----------------------------------------------------------


using System.IO;
using System;

class Class1
{
    
    static void Main()
    {
        int r;
        int.TryParse("1", out r);
        Console.WriteLine(r);
        Console.ReadLine();
        
        if(r!=0)
         Console.WriteLine("Is a number");
        else
         Console.WriteLine("NaN");
    }
}


-------------------------------------------------------



using System.IO;
using System;

public struct Person
{
    public String Name {get; set;}
    public Person(string _name)
    {
        Name=_name;
    }
}


public struct Dog
{
    public String Breed {get; set;}
    public Dog(string _breed)
    {
        Breed=_breed;
    }

}


class Class1
{
    
    public static void showvalue(Object o)
    {
        if(o is Person p)
        {
        Console.WriteLine(p.Name);
        }
        else if(o is Dog d)
        {
        Console.WriteLine(d.Breed);
        }
    }    
        
     static void Main()
     {
         Object o= new Person("Simanta");
         showvalue(o);
         o= new Dog("Husky");
         showvalue(o);
         Console.ReadLine();
     }

}

---------------------------------------------------------------


using System.IO;
using System;

class Program
{
    static void Main()
    {
        object str="hello";
        char[] values={'h','e','l','l','o'};
        object str2= new string(values);
        Console.WriteLine("Using Equality operator" +(str==str2));
        Console.WriteLine("Using equals() method {0}", str.Equals(str2));
        Console.ReadLine();
    }
}


------------------------------------------------------------------------------


using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string sA=Console.ReadLine();
        int[] charCount= new int[256];
        int length= sA.Length;
        
        for (int i=0; i<sA.Length; i++)
        {
            charCount[sA[i]]++;
        }
        
        int maxcount=-1;
        char c= ' ';
        
        for (int j=0; j<length; j++)
        {
            if(maxcount<charCount[sA[j]])
            {
                maxcount=charCount[sA[j]];
                c=sA[j];
            }
        }
        Console.WriteLine("String is {0}", sA);
       
        Console.WriteLine("Highest occuring character is "+c+" and max count is "+maxcount);
        
        Console.ReadLine();
    }
}

---------------------------------------------------------------------------------------------------
using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string sA=Console.ReadLine();
        char []revredStringArray=new char[sA.Length];
        
        for (int i=sA.Length-1; i>=0; i--)
        {
            revredStringArray[i]= sA[i];
        }
        
        string reversedString= new string(revredStringArray);
        Console.WriteLine(reversedString);
        if(reversedString==sA)
        {
        Console.WriteLine("It's a Palindrome!");
        }
        else
        {
        Console.WriteLine("Not a Palindrome!");
        }
        Console.ReadLine();
    }
}


---------------------------------------------------------------------------------------

using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        
        int vowel= 0;
        string sA= Console.ReadLine();
        
        for (int i=0; i<sA.Length; i++)
        {
            if(sA[i]=='a' || sA[i]=='e' || sA[i]=='i' || sA[i]=='o' || sA[i]=='u')
            {
                vowel++;
            }
        }
        
        }
        Console.WriteLine("Total Number of vowels is : "+vowel);      
        Console.ReadLine();
    }

}