import java.util.*;

public class Solution {

    public static void main(String[] args) {  
    	
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();

        for (int i = 0; i < n; i++)
        {
            String s = scan.next();

            for (int j = 0; j < s.length(); j++)
            {
                if (j % 2 == 0)
                   System.out.print(s.charAt(j));
            }

            System.out.print(" ");

            for (int j = 0; j < s.length(); j++)
            {
                if (j % 2 != 0)
                	System.out.print(s.charAt(j));
            }

            System.out.println();
        }
    }
}