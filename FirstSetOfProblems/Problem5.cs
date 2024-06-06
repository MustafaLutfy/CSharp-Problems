
class Problem5{
public static String StartWithIf(){

    String str = "else";
    
    if(str.StartsWith("if")){
        return str;
    }
    
    else{
        return "if" + " " + str;
    }
}
}
