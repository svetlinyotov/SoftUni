import java.util.Scanner;


public class P5_DecToHex {
	public static void main(String[] args) {
		
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int decimal = input.nextInt();
		
		//formatted printing for hexadecimal
		System.out.printf("%X", decimal);
		
	}
}