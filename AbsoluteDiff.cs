
class AbsoluteDifference{
public static void AbsDiff(){

    int n = 51;
    int r = 51;

    int diff = Math.Abs(n - r);
    
    if(n > r){
        Console.WriteLine(3*diff);
    }
    else{
        Console.WriteLine(diff);
    }
}
}
