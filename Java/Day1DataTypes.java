import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
        int i = 4;
        double d = 4.0;
        String s = "HackerRank ";
		
        Scanner input = new Scanner(System.in);

        /* Declare second integer, double, and String variables. */
        int i2;
        double d2;
        String s2;

        /* Read and save an integer, double, and String to your variables.*/
        // Note: If you have trouble reading the entire String, please go back and review the Tutorial closely.
        i2 = input.nextInt();
        d2 = input.nextDouble();
        input.nextLine(); // creates new line
        s2 = input.nextLine();
        
        /* Print the sum of both integer variables on a new line. */
        System.out.println(i+i2);

        /* Print the sum of the double variables on a new line. */
        System.out.println(d+d2);

        /* Concatenate and print the String variables on a new line; 
        	the 's' variable above should be printed first. */
        System.out.println(s+s2);

        input.close();
	}

}
