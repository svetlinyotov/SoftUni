import java.util.Scanner;


public class P7_CountBitsOne {
	public static void main(String[] args) {
		
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		
		int n = input.nextInt();
		
		//Using Integer class to count all 1 bits
		System.out.println(Integer.bitCount(n));
		
	}
}
