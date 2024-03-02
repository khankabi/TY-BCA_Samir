//java program to demonstrate synchronization of a thread.
class MyThread extends Thread {
    String msg[] = { "Java", "Supports", "Multithreading", "Concept" };

    MyThread(String name) {
        super(name);
    }

    synchronized void display(String name) {
        for (int i = 0; i < msg.length; i++) {
            System.out.println(name + msg[i]);
        }
    }

    public void run() {
        display(getName());
        System.out.println("Exit From" + getName());
    }
}

// main class
class SynchronizationDemo {
    public static void main(String[] args) {
        MyThread t1 = new MyThread("Thread 1:");
        MyThread t2 = new MyThread("Thread 2:");
        t1.start();
        t2.start();
        System.out.println(("Main thread existed"));

    }
}
