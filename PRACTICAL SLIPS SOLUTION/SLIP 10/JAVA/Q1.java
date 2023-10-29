// Write a java program to count the frequency of each character in a given string.
public class Q1 {
    public static void main(String[] args) {
        String str = "National senior college";
        int[] freq = new int[str.length()];
        int i, j;

        // Converts given string into character array
        char string[] = str.toCharArray();

        for (i = 0; i < str.length(); i++) {
            freq[i] = 1;
            for (j = i + 1; j < str.length(); j++) {
                if (string[i] == string[j]) {
                    freq[i]++;

                    // Set string[j] to 0 to avoid printing visited character
                    string[j] = '0';
                }
            }
        }

        // Displays the each character and their corresponding frequency
        System.out.println("Characters and their corresponding frequencies");
        for (i = 0; i < freq.length; i++) {
            if (string[i] != ' ' && string[i] != '0')
                System.out.println(string[i] + "-" + freq[i]);
        }
    }
}
