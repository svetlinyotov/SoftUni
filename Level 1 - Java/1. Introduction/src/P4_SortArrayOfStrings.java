import java.util.Scanner;


public class P4_SortArrayOfStrings {

	public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        int number = reader.nextInt();
        reader.nextLine();
 
        String[] words = new String[number];
        for (int index = 0; index < number; index++) {
            words[index] = reader.nextLine();
        }
 
        for (int i = 0; i < number; i++) {
            for (int j = i + 1; j < number; j++) {
                if (words[j].compareTo(words[i]) < 0) {
                    String temp = words[i];
                    words[i] = words[j];
                    words[j] = temp;
                }
            }
        }
 
        for (int i = 0; i < number; i++) {
            System.out.println(words[i]);
        }
        
    }

}
