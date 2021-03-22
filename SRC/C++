#include <iostream>
using namespace std;

//하노이의 탑
void hanoi(int n, char *from, char *to, char *via) {
    if( n > 1 ) {
        hanoi(n - 1, from, via, to);
        cout << from << " -> " << to << endl;
        hanoi(n - 1, via, to, from);
    } else {
        cout << from << " -> " << to << endl;
    }
}

int main(void) {
    int n;
    cin >> n;
    hanoi(n, "a", "b", "c");

    return 0;
}
