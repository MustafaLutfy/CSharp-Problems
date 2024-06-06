using System.Reflection.Metadata;

class Problem5_3{
    public static void CountWord(){
      Console.WriteLine("Enter a string");
      string x = Console.ReadLine();
      int count = 1;
        
       for (int i =0; i <= x.Length-1 ; i++)
       {
       if (x[i] == ' ' && x[i-1] != ' ')
       {
          count++;
       }
        
      }
     Console.WriteLine(count);
    }
} 