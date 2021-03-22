import 'dart:io';

//하노이의 탑

void hanoi(n, from, to, via) {
  if(n > 1) {
    
    hanoi(n - 1, from, via, to);
    print(from + " -> " + to);
    hanoi(n - 1, via, to, from);

  } else {
    print(from + " -> " + to);
  }
}

void main() {
  var n = int.parse(stdin.readLineSync());
  hanoi(n, "a", "b", "c");
}
