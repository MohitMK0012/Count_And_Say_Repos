using System;

public class Program {
    public static void Main() {
        Console.Write("\nEnter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string result = CountAndSay(n);
        Console.WriteLine("\nCount and Say sequence: " + result +"\n");
    }

    public static string CountAndSay(int n) {
        if (n == 1) {
            return "1";
        }

        string previous = CountAndSay(n - 1);
        string result = "";
        char currentChar = previous[0];
        int count = 1;

        for (int i = 1; i < previous.Length; i++) {
            if (previous[i] == currentChar) {
                count++;
            } else {
                result += count.ToString() + currentChar;
                currentChar = previous[i];
                count = 1;
            }
        }

        result += count.ToString() + currentChar;
        return result;
    }
}
