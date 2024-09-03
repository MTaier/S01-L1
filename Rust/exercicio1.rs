use std::io;

fn main() {
 let x = 10;
  while x<100
    {
        println!("Entre com um numero: ");
        let mut num1 = String::new();
        io::stdin().read_line(&mut num1).expect("Erro");
        let num1: i32 = num1.trim().parse().expect("Entre com um NUMERO");
        println!("Entre com o outro numero: ");
        let mut num2 = String::new();
        io::stdin().read_line(&mut num2).expect("Erro");
        let num2: i32 = num2.trim().parse().expect("Entre com outro NUMERO");
        println!("Escreva 'add' para somar e 'multiply' para multiplicar ");
        let mut operation = String::new();
        io::stdin().read_line(&mut operation).expect("Erro");
        let operation: String = operation.trim().parse().expect("Escreva add ou multiply!");
        if operation == "add" {
        println!("{}", num1 + num2);
        } else if operation == "multiply" {
        println!("{}", num1 * num2);
        } else {
        println!("valor invalido");
        }
        println!("Pressione 'q' para sair ou outra tecla para continuar ");
        let mut quit = String::new();
        io::stdin().read_line(&mut quit).expect("Erro");
        let quit: String = quit.trim().parse().expect("Pressione 'q' para sair ou outra tecla para continuar!!!!!!");
        if quit == "q" {
        println!("saindo...");
        break;
        } else {
        println!("continuando...");
        }
    }
}