class Problem11{
public static String AddThreeChars(){

    String str = "Python";
    

    if(str.Length >= 3){
        String firstThreeChs = str.Remove(3);
        return firstThreeChs + str + firstThreeChs;
    }
    else{
        return str + str + str;
    }

}
}
