// Write a java program to check whether given candidate is eligible for voting or not. Handle user defined as well as system defined Exception.
import java.util.*;
class q1
{
   public static void main(String args[])
   {
      Scanner sc = new Scanner(System.in);
      System.out.println("Enter your Name: ");
      String name=sc.nextLine();
      System.out.println("Enter your age: ");
      int age=sc.nextInt();
      if((age>=18)&&(age<=100))
      {
          System.out.println("Congratulation "+name+", You are eligible for Voting");
      }
      else
      {
          System.out.println("Sorry "+name+", You are not eligible for voting");
      }      
  }
}