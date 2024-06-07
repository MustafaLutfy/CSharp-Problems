class Problem11_3{
    public static void OrederChars(){
    //goal : to re order chars
    Console.WriteLine("Enter a string");
    string string1 = Console.ReadLine();
    char charO;
    //find the length to make it easier to use
    int stringLength = string1.Length;
    //convert string to array of chars 
    char[] arr = string1.ToCharArray(0, stringLength);
    //loop the string and swap between the chars.
    //start from 1 cuz we want to compare the 0 with the 1 
    for (int i = 1; i < stringLength; i++)
    {
        for (int j = 0; j < stringLength - i; j++)
        {
            if (arr[j] > arr[j+1])
            {
                //if the second char is less order than we reorder them by swaping them
                charO = arr[j];
                arr[j] = arr[j+1];
                arr[j + 1] = charO;
            }
        }
        
    }
         foreach (char x in arr)
        { 
            charO = x;
            Console.Write(" "+charO);
        }
    }
}