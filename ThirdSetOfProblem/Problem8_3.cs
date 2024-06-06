 class Problem8_3{
    public static void CopyStr(){
      Console.WriteLine("Enter a string");
      string x = Console.ReadLine();
        int count = 0;
       foreach (char h in x)
      {
        Console.Write(h);
        count++;
      }

      Console.WriteLine("\n Number of characters copied : " + count);
    }
}