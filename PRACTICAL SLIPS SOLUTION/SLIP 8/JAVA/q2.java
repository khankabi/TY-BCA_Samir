// Write a java program to display the files having extension .txt from a given directory.
import java.io.File;

public class q2 {

  public static void main(String[] args) {
    File directory = new File("JAVA");

    // list all files present in the directory
    File[] files = directory.listFiles();
    System.out.println("Files\t\t\tExtension");

    for(File file : files) {
      // convert the file name into string
      String fileName = file.toString();

      int index = fileName.lastIndexOf('.');
      if(index > 0) {
        String extension = fileName.substring(index + 1);
        System.out.println(fileName + "\t" + extension);
      }
    }
  }


}

