
class Problem8{
public static String RepeatStr(){

    String str = "a";

    if(str.Length >= 2){
        return string.Concat(Enumerable.Repeat(str.Remove(2), 4));
    }
    
    else{
        return str;
    }
}
}
