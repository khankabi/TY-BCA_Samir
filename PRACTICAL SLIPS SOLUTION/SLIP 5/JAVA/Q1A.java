// write a java propgram to display following pattern
// 5
// 4 5
// 3 4 5
// 2 3 4 5 
// 1 2 3 4 5
public class Q1A
{
    public static void main( String[] args) {
        int n=6;
        for (int i = 1; i<n; i++) {
            for (int j = n-i; j<n; j++) {
                System.out.print(j+" ");
            }
            System.out.println();
        }
    }
}