public class Demothread extends Thread {
    public static void main(String[] args) {
        Thread thread1 = new Thread("My Thread 1");
        Thread thread2 = new Thread("My Thread 2");
        thread1.start();
        thread2.start();
        System.out.println("thread names are following:");
        System.out.println(thread1.getName());
        System.out.println(thread2.getName());
    }

}