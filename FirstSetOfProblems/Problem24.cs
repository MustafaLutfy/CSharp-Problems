class Problem24{
public static String Last3ToUpper(){

    String str = "js";

    String result = ""; 

    //Check if the string is less then 3 chars
    if(str.Length < 3){
        return str.ToUpper();
    }
    else{
        //Get the last 3 chars form str and save it into result
        for (int i = str.Length-3 ; i < str.Length; i++)
            {
                result = result + str[i];
            }

            //Make the last 3 chars that we saved into upper case
            result = result.ToUpper();
    }

    //Now remove the last 3 chars from the old str and concat with the new upper case chars
    return str.Remove(str.Length - 3) + result;
}
}
