package main

import "fmt"

//하노이의 탑

func hanoi(n int, from, to, via string) {

	if n > 1 {
		hanoi(n - 1, from, via, to)
		fmt.Println(from, " -> ", to)
		hanoi(n - 1, via, to, from)
	} else {
		fmt.Println(from, " -> ", to)
	}

}

func main() {
	//표준 입력에서 명령을 받아서 실행.

	var n int
	fmt.Scan(&n)
	hanoi(n, "a", "b", "c")

}
