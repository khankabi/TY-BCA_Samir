/**write a java program which accepts three integer values and prints
the maximum and minimum
*/ 
import java.io.*;
public class p1_2
{
	public static void main(String args[]) throws IOException
	{
		InputStreamReader in=new InputStreamReader(System.in);
		BufferedReader bf= new BufferedReader(in);
		System.out.println("enter the number");
		int num1=Integer.parseInt(bf.readLine());
		int num2=Integer.parseInt(bf.readLine());
		int num3=Integer.parseInt(bf.readLine());
		System.out.println(num1);
		System.out.println(num2);
		System.out.println(num3);
		/**int num1=10;
		int num2=20;
		int num3=1;*/
		if(num1>num2 && num1>num3)
		{
			System.out.println("num1 is the greatest"+num1);
		}
		else if(num2>num1 && num2>num3)
		{
			System.out.println("num2 is the greatest"+num2);
		}
		else if(num3>num1 && num3>num2)
		{
			System.out.println("num3 is the greatest"+num3);
		}
		else  
		{
			System.out.println("Wrong input");
		}


	}
}