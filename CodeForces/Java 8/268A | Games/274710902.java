import java.util.Scanner;
 
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
 
        int n = sc.nextInt();
        int[][] uniforms = new int[n][2];
 
        for (int i = 0; i < n; i++) {
            uniforms[i][0] = sc.nextInt(); // home color
            uniforms[i][1] = sc.nextInt(); // away color
        }
 
        int count = 0;
 
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (i != j && uniforms[i][0] == uniforms[j][1]) {
                    count++;
                }
            }
        }
 
        System.out.println(count);
 
        sc.close();
    }
}