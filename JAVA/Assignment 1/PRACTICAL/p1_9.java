//Write a java program to calculate the sum of first and last digit of a number.
import java.io.*;
public class p1_9
{
	public static void main(String[] args) throws IOException
	{
		System.out.println("Hello User");
		InputStreamReader in = new InputStreamReader(System.in);
		BufferedReader bin = new BufferedReader(in);
		System.out.println("Enter A Number : ");
		int num = Integer.parseInt(bin.readLine());
		int number = num;
		int firstDigit = 0;
		int lastDigit = number%10;
		int result = 0;
		while(number != 0)
       	 	{
            		firstDigit = number % 10;
		        number = number / 10;
	        }
		result = firstDigit + lastDigit;
		System.out.println("first Digit is : "+firstDigit);
		System.out.println( "last Digit is : " +lastDigit);
		System.out.println("Result is : "+ result); 

		
		
		
		
		
	}
}