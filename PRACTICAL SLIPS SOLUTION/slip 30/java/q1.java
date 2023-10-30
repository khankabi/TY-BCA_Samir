// Write a java program to accept a number from a user, if it is zero then throw user defined Exception “Number is Zero”. If it is non-numeric then generate an error “Number is Invalid” otherwise check whether it is palindrome or not.
import java.io.*;
import java.util.Scanner;
class abc extends Exception{}
class q1{
    public static void main( String args[]){
        int r,sum=0,temp; 
        int n;
        Scanner dr=new Scanner(System.in);
        try {
            System.out.print("Enter Number : ");
            n = dr.nextInt();
            if(n==0){
                throw new abc();
            }else{
                temp=n; 
                while(n>0){ 
                    r=n%10;
                    sum=(sum*10)+r; 
                    n=n/10; 
                } 
                if(temp==sum){
                    System.out.println("It is Palindrome Number "); 
                }else{
                    System.out.println("Not Palindrome");
                }
            }
        } catch (abc nz) {
            System.out.println("Number is 0");
        }
        catch (NumberFormatException e){
            System.out.println("Invalid Number ");
        }
        catch (Exception e){}
    }
}