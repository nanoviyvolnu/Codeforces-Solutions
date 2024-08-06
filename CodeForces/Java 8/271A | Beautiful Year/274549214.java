import java.util.Scanner;
 
public class Main {
 
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int year = scanner.nextInt();
        year++;
        
        while (!isBeautiful(year)) {
            year++;
        }
        
        System.out.println(year);
        scanner.close();
    }
 //
    private static boolean isBeautiful(int year) {
        String yearStr = String.valueOf(year);
        for (int i = 0; i < yearStr.length(); i++) {
            for (int j = i + 1; j < yearStr.length(); j++) {
                if (yearStr.charAt(i) == yearStr.charAt(j)) {
                    return false;
                }
            }
        }
        return true;
    }
}