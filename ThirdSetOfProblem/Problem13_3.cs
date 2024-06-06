 class Problem13_3{
    public static void Substring (){
        

        String str = "welcome";
        Console.WriteLine("Input a Start Point");
        int startPoint = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Input a length of substring");
        int subStrLen = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < subStrLen; i++)
        {
            Console.Write(str[startPoint]);
            startPoint++;
        }
        
    }
}




 