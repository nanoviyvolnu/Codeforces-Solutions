import java.util.Scanner;
import java.util.ArrayList;
import java.util.List;
 
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
 
        int count = sc.nextInt();
        int max = sc.nextInt();
 
        List<Integer> friendsHeight = new ArrayList<>();
        int result = 0;
 
        for (int i = 0; i < count; i++) {
            friendsHeight.add(sc.nextInt());
        }
 
        for (int height : friendsHeight) {
            int currentValue = 0;
            if (height > max) {
                currentValue = 2;
            } else {
                currentValue = 1;
            }
            result += currentValue;
        }
 
        System.out.println(result);
    }
}