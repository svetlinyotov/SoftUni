import java.util.Scanner;


public class P3_PointsInsideAFigure {

	public static void main(String[] args) {

		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		
		double x = input.nextDouble();
		double y = input.nextDouble();
		boolean position; //Outside || Inside
		
		if(x >= 12.5 && x <= 22.5 && y >= 6 && y <= 8.5){ //Checking the top rectangle
			position = true;
		}
		else if(x >= 12.5 && x <= 17.5 && y >= 8.5 && y <= 13.5){ //Checking the left rectangle
			position = true;
		}
		else if(x >= 20 && x <= 22.5 && y >= 8.5 && y <= 13.5){ //Checking the right rectangle
			position = true;
		}
		else{
			position = false;
		}
		
		if (position) {
			System.out.println("Inside"); //position === true
		}
		else{
			System.out.println("Outside"); // position === false
		}

	}

}
