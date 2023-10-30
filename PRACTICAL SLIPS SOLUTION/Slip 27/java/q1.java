// Write a java program to accept a number from user, If it is greater than 1000 then throw user defined exception “Number is out of Range” otherwise display the factors of that number. (Use static keyword).
import java.io.*;
class NumOutRange extends Exception {
}
class q1 {
  static int n;
  public static void main(String args[]) {
    DataInputStream dr = new DataInputStream(System.in);
    try {
      System.out.print("Enter Number : ");
      n = Integer.parseInt(dr.readLine());
      if (n > 1000) {
        throw new NumOutRange();
      } else {
        for (int i = 1; i < n; i++) {
          if (n % i == 0) {
            System.out.println(i + " ");
          }
        }
      }
    } catch (NumOutRange nz) {
      System.out.println("Num is out of range..!");
    }
    catch (Exception e) {
      System.out.println("" + e.getMessage());
    }
  }
}