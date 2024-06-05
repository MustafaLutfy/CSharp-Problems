
class StringRepeat{
public static String CopyStr(){

    String str = "a";

    if(str.Length >= 2){
        return string.Concat(Enumerable.Repeat(str.Remove(2), 4));
    }
    
    else{
        return str;
    }
}
}
