// Write a java program to count the number of integers from a given list. (Use Command line arguments).
// pass the argument at the time of run java program ex : java q1 12 abc 56 def
import java.util.*;
public class q1 {
    public static void main(String[] args) {
        int count = 0;
        List<String> al = new ArrayList<>();
        for (int i = 0; i < args.length; i++) {
            al.add(args[i]);
        }
        for (int i = 0; i < al.size(); i++) {
            String element = al.get(i);
            try {
                int j = Integer.parseInt(element);
                count++;
            } catch (NumberFormatException e) {}
        }
        System.out.println(count + " integers present in list");
    }
}

