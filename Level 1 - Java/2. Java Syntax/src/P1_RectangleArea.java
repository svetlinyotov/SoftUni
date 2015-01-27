import java.util.Scanner;


public class P1_RectangleArea {

	public static void main(String[] args) {
		
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		int b = input.nextInt();
		
		int area = a * b;
		
		System.out.println(area);
		

	}

}
