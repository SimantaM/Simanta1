using System.IO;
using System;

    namespace sample
    {
       /* class student
        {
            public int RollNumber {get; set;}
            public string Name {get; set;}
            public string Gender {get; set;}
          
          static void Main()
          {
              student student = new student();
              student.RollNumber = 7;
              student.Name= "Simanta";
              student.Gender= "Male";
              Console.WriteLine(student.RollNumber+"\t"+ student.Name+"\t" + student.Gender);
              Console.ReadLine();
          }
        }*/
        
        public enum salutation
        {
            Mr=0,
            Ms=1,
            Mrs=2,
            Dr=3
        }
        class student
        {
            static void Main(string[] args)
          {
              salutation salutation;
              string name;
              Console.WriteLine("Enter Salutation:");
              salutation=(salutation)Enum.Parse(typeof(salutation), Console.ReadLine());
              Console.WriteLine("Enter Name: ");
              name= Console.ReadLine();
              Console.Write("\nYour name is: {0}", salutation.ToString());
              Console.Write("_" +name);
              Console.ReadLine();
          }
              
        }

}

