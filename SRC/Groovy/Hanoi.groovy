//Groovy hanoi.groovy

class Hanoi {
    def exec(int n, String from, String to, String via) {
        if( n > 1) {
            exec(n - 1, from, via, to)
            println(from + " -> " + to)
            exec(n - 1, via, to, from)
        } else {
            println(from + " ->  + to")
        }
    }
}

//표준 입력에서 명령을 받아서 실행

Scanner = cin = new Scanner(System.in)
String n = cin.nextLine()
hanoi h = new Hanoi()
h.exec(Integer.decode(n), "a", "b", "c")
