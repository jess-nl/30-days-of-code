import java.util.*;

class Solution{
    public static void main(String []argh){
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        
        HashMap<String, Integer> phoneBook = new HashMap<String, Integer>();
        
        for(int i = 0; i < n; i++){
            String name = in.next();
            int phone = in.nextInt();
            phoneBook.put(name, phone);
        }
        
        while(in.hasNext()){
            String name = in.next();
            
        	if (phoneBook.containsKey(name)) {
        		System.out.println(name + "=" + phoneBook.get(name));
        	} else {
        		System.out.println("Not found");
            }
        }
        
        in.close();
    }
}