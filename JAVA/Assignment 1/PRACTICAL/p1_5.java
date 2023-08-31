//write a java program to calculate sum of digits of a number.
import java.io.*;
public class p1_5
{
	public static void main(String args[]) throws IOException
	{	
		int sum=0;
		System.out.println("Hello User");
		System.out.println("Enter a Digit");
		InputStreamReader in= new InputStreamReader(System.in);
		BufferedReader bin=new BufferedReader(in);
		int n=Integer.parseInt(bin.readLine());
		for(int i=1;i<=n;i++)
		{
			
			sum+=i;
			System.out.println(sum);
		}
	}
}