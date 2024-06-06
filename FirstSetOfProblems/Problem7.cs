
class Problem7{
public static String ReplaceFirtWithLast(){

    String str = "abcd";
    
    char temp = str[0];
    String result = str.Replace(str[0], str[str.Length - 1]);
    result = result.Remove(result.Length - 1);

    return result + temp;
}
}
