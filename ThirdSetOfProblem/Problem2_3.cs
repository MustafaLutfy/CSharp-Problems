 class Problem2_3{
    public static int LengthStr(){
      Console.WriteLine("Enter a word");
      string x = Console.ReadLine();
      int count = 0;
      foreach (char h in x)
      {
       count++;
      }
      return count;
        
    }
}