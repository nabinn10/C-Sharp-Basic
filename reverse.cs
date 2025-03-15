using System;
class Reverse{
    public static void Main(){
        int n,r,sum=0,temp;
        Console.Write("Enter the Number= ");
        n= int.Parse(Console.ReadLine());
        temp=n;
        while(n>0){
            r=n%10;
            sum=sum*10+r;
            n=n/10;
        }
        Console.Write("Reverse Number= "+sum);
    }
}