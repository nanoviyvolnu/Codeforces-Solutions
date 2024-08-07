import java.util.Scanner;
 
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
 
        int n = sc.nextInt();
        int[] inputs = new int[n];
 
        for (int i = 0; i < n; i++) {
            inputs[i] = sc.nextInt();
        }
 
        int result = 1; 
 
        for (int i = 1; i < n; i++) {
            if (inputs[i] != inputs[i - 1]) {
                result++;
            }
        }
 
        System.out.print(result);
 
        sc.close();
    }
}