import java.util.Scanner;
 
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt();
        int t = sc.nextInt();
        
        sc.nextLine();
        String boysAndGirls = sc.nextLine();
        
        StringBuilder sb = new StringBuilder(boysAndGirls);
        
        for (int time = 0; time < t; time++) {
            for (int i = 0; i < sb.length() - 1; i++) {
                if (sb.charAt(i) == 'B' && sb.charAt(i + 1) == 'G') {
                    sb.setCharAt(i, 'G');
                    sb.setCharAt(i + 1, 'B');
                    i++; 
                }
            }
        }
        
        System.out.println(sb.toString());
        
        sc.close();
    }
}