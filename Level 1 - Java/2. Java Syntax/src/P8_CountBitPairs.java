import java.util.Scanner;


public class P8_CountBitPairs {

	public static void main(String[] args) {

		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		
		int n = input.nextInt();
		int count = 0;
		
		//Convert integer to binary string
		String binary = Integer.toBinaryString(n);
		
		for (int i = 0; i <= binary.length()-2; i++) {
			if (binary.charAt(i) == '1' && binary.charAt(i + 1) == '1') { //check the char on positions i and i+1 if equals 1
				count++;
			}
			else if (binary.charAt(i) == '0' && binary.charAt(i + 1) == '0'){ //check the char on positions i and i+1 if equals 0
				count++;
			}
		}
		
		System.out.println(count);
	}

}
