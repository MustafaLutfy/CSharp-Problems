 class Problem7_3{
    public static void CountA(){
        Console.WriteLine("Enter a word");
      string x = Console.ReadLine();
      int Alphacount = 0;
      int Numscount = 0;
      int Spiscount = 0;
      foreach (char h in x)
      {
        if (h >= 'a' && h<= 'z' || h >= 'A' && h<= 'Z')
        {
            Alphacount++;
        }
        else if(h >= '0' && h<= '9')
        {
            Numscount++;
        }
        else 
        {
            Spiscount++;
        }
       
      }   
      Console.WriteLine("Number of Alphabets in the string is " + Alphacount); 
      Console.WriteLine("Number of Digits in the string is" + Numscount) ;
      Console.WriteLine("Number of Special characters in the string is" + Spiscount) ;
    }
    }
 