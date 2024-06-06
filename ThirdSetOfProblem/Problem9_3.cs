 class Problem9_3{
    public static void MaxNumberOfChars(){
        
        String str = "Helllllo";
        int maxCount = 0;
        int tempCount = 0;
        char temp = ' ';
        char maxChar = ' ';

        for (int i = 0; i < str.Length; i++)
        {
            temp = str[i];

            for (int j = 0; j < str.Length; j++)
            {
                if(str[j] == temp){
                    tempCount++;
                }
            }
            
            if(tempCount > maxCount){
                maxCount = tempCount;
                maxChar = temp;
            }

            tempCount = 0;
        }

        Console.WriteLine("The Highest frequency of character : " + maxChar);
        Console.WriteLine("appears number of times : " + maxCount);

    }
}




 