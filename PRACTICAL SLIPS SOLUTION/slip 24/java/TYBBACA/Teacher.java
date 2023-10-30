package TYBBACA;

import java.util.*;

public class Teacher {
    public int tid;
    public String tname;
    public String subject;

    public void settid(int tid) {
        this.tid = tid;
    }

    public int gettid() {
        return tid;
    }

    public void settname(String tname) {
        this.tname = tname;
    }

    public String gettname() {
        return tname;
    }

    public void setsub(String sub) {
        this.subject = sub;
    }

    public String getsub() {
        return subject;
    }

    public Teacher() {
        Scanner n = new Scanner(System.in);
        System.out.print("Enter Teacher id Number: ");
        this.settid(n.nextInt());
        System.out.print("Enter Teacher Name: ");
        this.settname(n.next());
        System.out.print("Enter Subject Name: ");
        this.setsub(n.next());
    }

    public void disp() {

    }

    public void finalize() {
        System.out.println("inside demo's finalize()");

        System.out.println("Calling finalize method"
                + " of the Object class");

        // Calling finalize() of Object class
    }
}
