import java.util.Scanner;


public class P4_TheSmallestNumber {
	public static void main(String[] args) {
		
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		
		double a = input.nextDouble();
		double b = input.nextDouble();
		double c = input.nextDouble();
		
		//Find first the smallest number out of b and c, the compare it to a
		double smallest = Math.min(a, Math.min(b, c));
		
		//if the number is integer, print it without floating point
		if(smallest == (int) smallest){
			System.out.println((int)smallest);
		}
		else{ //else print the number with floating point
			System.out.println(smallest);
		}
		
	}
}
