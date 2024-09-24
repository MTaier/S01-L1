class Animal {
  constructor(nome, idade, especie) {
    this.nome = nome;
    this.idade = idade;
    this.especie = especie;
  }
  imprimirInfo() {
    console.log(
      `${this.nome} tem ${this.idade} anos e é um(a) ${this.especie}`
    );
  }
}

class Cachorro extends Animal {
  constructor(nome, idade, especie, raca) {
    super(nome, idade, especie);
    this.raca = raca;
  }

  imprimirInfo() {
    console.log(
      `${this.nome} tem ${this.idade} anos, é um(a) ${this.especie} e é da raça ${this.raca}`
    );
  }
}

class Gato extends Animal {
  constructor(nome, idade, especie, corPelo) {
    super(nome, idade, especie);
    this.corPelo = corPelo;
  }

  imprimirInfo() {
    console.log(
      `${this.nome} tem ${this.idade} anos, é um(a) ${this.especie} e tem pelos ${this.corPelo}`
    );
  }
}

let cachorro = new Cachorro("Max", 3, "cachorro", "Golden Retriever");
cachorro.imprimirInfo();

let corPelo = ["cinza", "branco", "laranja"];
let gato = new Gato("Luna", 4, "gato", corPelo);
gato.imprimirInfo();

let animal = new Animal("Spike", 5, "iguana");
animal.imprimirInfo();
