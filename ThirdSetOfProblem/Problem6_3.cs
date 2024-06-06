using System.Reflection.Metadata;

class Problem6_3{
    public static String CountBothStrs(){
      Console.WriteLine("Enter a word");
      string x = Console.ReadLine();
      Console.WriteLine("Enter a word");
      string y = Console.ReadLine();
      int countx = 0;
      int county = 0;
      foreach (char h in x)
      {
       countx++;
      }
      foreach (char h in y)
      {
       county++;
      }
       if (countx == county && x == y)
       {
             return "The length of both strings are equal and also, both strings are equal";
       }
       else if(countx == county && x != y)
       {
           return "The length of both strings are equal and also,but both strings are not equal";

       }
       else 
       {
            return "both are not equal";
       }
        
    }
} 