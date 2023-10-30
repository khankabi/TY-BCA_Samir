//  Write a java program to display each String in reverse order from a String array.
public class Q1 {
    public static void main(String args[]) {

        String arr[] = { "college", "senior", "National" };

        for (int i = arr.length - 1; i >= 0; i--) {

            System.out.print(arr[i] + ' ');

        }

    }

}
