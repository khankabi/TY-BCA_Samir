//write a program to print odd and even numbers from array
import java.io.*;
class odd_even_extraction_from_array
{
	public static void main(String args[])
	{
		System.out.println("Hello User");
		int arr[]={10,5,3,74,2,90,1,4,3,56};
		System.out.println("Even Numbers :");
		for(int i:arr)
		{
			if(i%2==0)
				System.out.println(i);
		}
		System.out.println("Odd Numbers :");
		for(int i:arr)
		{
			if(i%2!=0)
				System.out.println(i);
		}
		
	}
}