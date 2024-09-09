package main

import (
	"fmt"
	"math"
)

func main() {
	var a, b, c float64

	// Solicita ao usuário os coeficientes da equação
	fmt.Print("Digite o valor de a: ")
	fmt.Scanln(&a)
	fmt.Print("Digite o valor de b: ")
	fmt.Scanln(&b)
	fmt.Print("Digite o valor de c: ")
	fmt.Scanln(&c)

	// Verifica se é uma equação do segundo grau
	if a == 0 {
		fmt.Println("O valor de 'a' deve ser diferente de zero para ser uma equação do segundo grau.")
		return
	}

	// Calcula o discriminante (delta)
	delta := b*b - 4*a*c

	// Verifica se delta é negativo
	if delta < 0 {
		fmt.Println("A equação não possui raízes reais.")
		return
	}

	// Calcula as raízes reais
	raiz1 := (-b + math.Sqrt(delta)) / (2 * a)
	raiz2 := (-b - math.Sqrt(delta)) / (2 * a)

	// Exibe as raízes
	fmt.Printf("As raízes da equação são: x1 = %.2f e x2 = %.2f\n", raiz1, raiz2)
}
