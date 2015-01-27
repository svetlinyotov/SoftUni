import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;


public class P10_PrintHouse {
	public static void main(String[] args) {
		
		@SuppressWarnings("resource")
		Scanner  in = new Scanner(System.in);
		
		String[] input = new String[in.nextInt()]; //make array with length equal to the count of point pairs
		in.nextLine(); //get the first line
		
		List<Double> x = new ArrayList<Double>(); //list for the first values x
		List<Double> y = new ArrayList<Double>(); //list for the second values y
		
		for (int i = 0; i < input.length; i++) { //loop the .nextLine
	        input[i] = in.nextLine(); //get the i line
	        String num[] = input[i].split(" "); //split the two values from each line
	        x.add(Double.parseDouble(num[0])); //add the first value to list
			y.add(Double.parseDouble(num[1])); //add the second value to list
	    }
		
		//writing html

		String content = "<!DOCTYPE html>\n"
                + "<html>\n"
                + "<body>\n"
                + "\n" //writing the numbers
                + "<svg width=\"1000\" height=\"1000\">\n"
                + "  <text x=\"55\" y=\"20\" font-size=\"27\">10</text>\n"
                + "  <text x=\"115\" y=\"20\" font-size=\"27\">12.5</text>\n"
                + "  <text x=\"195\" y=\"20\" font-size=\"27\">15</text>\n"
                + "  <text x=\"255\" y=\"20\" font-size=\"27\">17.5</text>\n"
                + "  <text x=\"335\" y=\"20\" font-size=\"27\">20</text>\n"
                + "  <text x=\"395\" y=\"20\" font-size=\"27\">22.5</text>\n"
                + "\n"
                + "  <text x=\"13\" y=\"70\" font-size=\"27\">3.5</text>\n"
                + "  <text x=\"33\" y=\"140\" font-size=\"27\">6</text>\n"
                + "  <text x=\"13\" y=\"210\" font-size=\"27\">8.5</text>\n"
                + "  <text x=\"20\" y=\"280\" font-size=\"27\">11</text>\n"
                + "  <text x=\"0\" y=\"350\" font-size=\"27\">13.5</text>\n"
                + "  <text x=\"20\" y=\"420\" font-size=\"27\">16</text>\n"
                + "\n" //draw the lines
                + "  <line x1=\"53\" y1=\"60\" x2=\"440\" y2=\"60\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"53\" y1=\"130\" x2=\"440\" y2=\"130\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"53\" y1=\"200\" x2=\"440\" y2=\"200\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"53\" y1=\"270\" x2=\"440\" y2=\"270\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"53\" y1=\"340\" x2=\"440\" y2=\"340\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"53\" y1=\"410\" x2=\"440\" y2=\"410\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "\n"
                + "  <line x1=\"70\" y1=\"30\" x2=\"70\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"140\" y1=\"30\" x2=\"140\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"210\" y1=\"30\" x2=\"210\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"280\" y1=\"30\" x2=\"280\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"350\" y1=\"30\" x2=\"350\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"420\" y1=\"30\" x2=\"420\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "\n";
		
		//loop all points
		for(int i = 0; i < x.size(); i++){
			//convert position in pixels
			double pixelsX = 70 + (70 * ((x.get(i) - 10) / 2.5));
	        double pixelsY = 60 + (70 * ((y.get(i) - 3.5) / 2.5));
	        
	        // check if inside the house
	        double leftSide = ( (12.5 - 17.5)*(y.get(i) - 3.5) - (8.5 - 3.5)*(x.get(i) - 17.5) ); //formula for the triangle
	        double rightSide = ( (22.5 - 17.5)*(y.get(i) - 3.5) - (8.5 - 3.5)*(x.get(i) - 17.5) );
	        
	        boolean leftRoof = leftSide <= 0.0;
	        boolean rightRoof = rightSide >= 0.0;
	        boolean roof = leftRoof == true && rightRoof == true && y.get(i) <= 8.5; //if the point is in the roof
	        
	        boolean leftWall = y.get(i) >= 8.5 && y.get(i) <= 13.5 && x.get(i) >= 12.5 && x.get(i) <= 17.5; //if the point is in the left wall
	        boolean rightWall = y.get(i) >= 8.5 && y.get(i) <= 13.5 && x.get(i) >= 20 && x.get(i) <= 22.5; //if the point is in the right wall
	        boolean walls = leftWall == true || rightWall == true; //if the point is inside the walls
	        
	        if(roof == true || walls == true) {
	            content += "<circle cx=\""+pixelsX+"\" cy=\""+pixelsY+"\" r=\"5\" fill=\"black\" />\n"; //the point is in the house
	        } else {
	            content += "<circle cx=\""+pixelsX+"\" cy=\""+pixelsY+"\" r=\"5\" stroke=\"black\" stroke-width=\"1\" fill=\"#bfbfbf\" />\n"; //the point is outside the house
	        }
		} 
		
		
		 content += "  <polygon points=\"280,60 420,200 140,200\" style=\"fill:blue;stroke:#002065;stroke-width:2;fill-opacity:0.3;stroke-opacity:0.8\" />\n" //draw triangle
	                + "  <rect x=\"140\" y=\"200\" width=\"140\" height=\"140\" style=\"fill:blue;stroke:#002065;stroke-width:2;fill-opacity:0.3;stroke-opacity:0.8\" />\n" //draw left wall
	                + "  <rect x=\"350\" y=\"200\" width=\"70\" height=\"140\" style=\"fill:blue;stroke:#002065;stroke-width:2;fill-opacity:0.3;stroke-opacity:0.8\" />\n" //draw right wall
	                + "</svg>\n"
	                + " \n"
	                + "</body>\n"
	                + "</html>\n";
	        
	      try {
	            
            // Create html file and fill with the html content
            PrintWriter writer = new PrintWriter("house.html", "UTF-8");
            writer.println(content);
            writer.close();
            
            System.out.println("--- The html is generated ---");
            
        } catch (Exception e) {
        }
        
        
        
	}
}
