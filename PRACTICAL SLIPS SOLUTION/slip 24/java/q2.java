
// Create a package TYBBACA with two classes as class Student (Rno, SName, Per) with a method disp() to display details of N Students and class Teacher (TID, TName, Subject) with a method disp() to display the details of teacher who is teaching Java subject. (Make use of finalize() method and array of Object)
import TYBBACA.*;
import java.io.*;

public class q2 {
    public static void main(String[] args) throws Exception {
        Student[] studentArray = new Student[3];
        Teacher[] teacherArray = new Teacher[3];
        // accept
        for (int i = 0; i < 3; i++) {
            Student s = new Student();
            Teacher t = new Teacher();
            studentArray[i] = s;
            teacherArray[i] = t;
        }
        // display
        for (int i = 0; i < 3; i++) {
            Student s = studentArray[i];
            Teacher t = teacherArray[i];
            // System.out.println(s.getrno()+" "+s.getName()+" "+s.getPer());
            // System.out.println(t.gettid()+" "+t.gettname()+" "+t.getsub());
            System.out.println("Student RollNo: " + s.getrno());
            System.out.println("Student Name: " + s.getName());
            System.out.println("Student Percentage: " + s.getPer());
            if (t.getsub() == "java") {
                System.out.println("Teacher  ID: " + t.gettid());
                System.out.println("Teacher Name: " + t.gettname());
                System.out.println("Teacher Subject: " + t.getsub());
            }
            else{
                System.out.println("No one is teaching Java");
            }
            s.finalize();
            t.finalize();
        }

    }
}
