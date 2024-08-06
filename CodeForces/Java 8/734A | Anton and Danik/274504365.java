import java.util.Scanner;
 
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt();
        sc.nextLine();
        String matches = sc.nextLine();
        
        String[] matchesArray = matches.split("");
        
        int a = 0;
        int d = 0;
        
        for(int i = 0; i < matchesArray.length; i++){
            if(matchesArray[i].equals("A")){
                a++;
            } else if(matchesArray[i].equals("D")) {
                d++;
            }
        }
        
        if(a > d){
            System.out.println("Anton");
        } else if(a < d){
            System.out.println("Danik");
        } else {
            System.out.println("Friendship");
        }
        
        sc.close();
    }
}