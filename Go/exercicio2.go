package main

import (
	"fmt"
	"math/rand"
)

func fatorial(n int) int {
	if n == 0 || n == 1 {
		return 1
	}
	return n * fatorial(n-1)
}

func main() {
	numero := rand.Intn(10)

	resultado := fatorial(numero)

	fmt.Printf("Número gerado: %d\n", numero)
	fmt.Printf("Fatorial de %d é: %d\n", numero, resultado)
}
