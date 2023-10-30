// Write a java program that asks the user name, and then greets the user by name. Before outputting the user's name, convert it to upper case letters. For example, if the user's name is Raj, then the program should respond "Hello, RAJ, nice to meet you!".
import java.util.Scanner;

class Q2 {
    public static void main(String args[]){
        String str;
        Scanner dr=new Scanner(System.in);
        try {
            System.out.print("Enter Username : ");
            str = dr.nextLine();
            System.out.print("\"Hello, " + str.toUpperCase() + ", nice to meet you!\"");
        } catch (Exception e) {}
        dr.close();
    }
}