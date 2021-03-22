using System;

//하노이의 탑
public class Hanoi
{
    private void hanoi(int n, char from, char to, char via)
    {
        if(n > 1) {
            hanoi(n - 1, from, via, to);
            Console.WriteLine(from + " -> " + to);
            hanoi(n - 1, via, to, from);
        } else {
            Console.WriteLine(from + " -> " + to);
        }
    }

    public static void Main() {
        int n = int.Parse(Console.ReadLine());
        Hanoi h = new Hanoi();
        h.hanoi(n, 'a', 'b', 'c');
    }

}
