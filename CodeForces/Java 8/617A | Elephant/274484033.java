import java.util.Scanner;
 
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int input = sc.nextInt();
 
        int[] positions = new int[]{1, 2, 3, 4, 5};
 
        int result = 0;
 
        for(int i = positions.length - 1; i >= 0; i--) {
            while(input >= positions[i]) {
                input -= positions[i];
                result++;
            }
        }
 
        System.out.println(result);
    }
}