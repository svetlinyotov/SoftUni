import java.util.Scanner;

public class P9_PointInHouse {
	public static void main(String[] args) {
		
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		
        float x = input.nextFloat();
        float y = input.nextFloat();
        
        boolean answer;
        
        byte position = (byte) ((17.5-12.5)*(y-8.5) - (3.5-8.5)*(x-12.5)); //formula for the first side of the triangle
        byte secondPosition = (byte) ((17.5-22.5)*(y-8.5) - (3.5-8.5)*(x-22.5)); //formula for the second side of teh trinagle
       
        if (position >= 0 && y <= 8.5 && secondPosition <= 0) { //check if the point is in the triangle
                answer = true;
        }
        else if (x >= 12.5 && x <= 17.5 && y <= 13.5 && y >= 8.5) { //check if the point is in the left rectangle
                answer = true;
        }
        else if (x >= 20 && x <= 22.5 && y <= 13.5 && y >= 8.5) { //check if the point is in the right rectangle
                answer = true;
        }
        else {
                answer = false;
        }
       
        if (answer) {
                System.out.println("Inside"); //answer === true
        }
        else {
                System.out.println("Outside"); //answer === false
        }
	}
}
