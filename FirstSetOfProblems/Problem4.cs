
class Problem4{
public static Boolean Whithin10(){

    int n = 89;
    
    if(Math.Abs(n-100) <= 10 || Math.Abs(n-200) <= 10){
        return true;
    }
    
    else{
        return false;
    }
}
}
