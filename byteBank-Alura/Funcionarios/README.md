# Funcionarios

# Testes no program

## Não pode instanciar classe abstrata
```
    // Funcionarios
    // É uma classe abstrata não funciona
    //Funcionario pedro = new Funcionario("123456789", 2000);
    //pedro.Nome = "Pedro malazartes";
    //pedro.AumentarSalario();
    //pedro.ExibirDados(pedro);
```
## Chamando classe Diretor
```
    Diretor roberta = new Diretor("1237356789");
    roberta.Nome = "Roberta malavazres";
    roberta.AumentarSalario();
    roberta.ExibirDados(roberta);
```
## Chamando classe Designer
```
    // Designer
    Designer ulisses = new Designer("2342325");
    ulisses.Nome = "Roberta malavazres";
    ulisses.AumentarSalario();
    ulisses.ExibirDados(ulisses);

    // Designer
    Auxiliar marcelo = new Auxiliar("2342325");
    marcelo.Nome = "Roberta malavazres";
    marcelo.AumentarSalario();
    marcelo.ExibirDados(marcelo);
```

# Explicação de algumas partes do paradigma (POO) e boas práticas

## Classe PAI
```
public abstract class Funcionario
```

## Propriedade
```
    // Propriedade da classe
    public static int TotalDeFuncionarios { get; private set; }
```

## CodeSnippet de construtor
```
    // code snippet para construtor: ctor + tab
    public Funcionario(string cpf, double salario)
```

## Metodos abstratos para serem reescritos
```
    public abstract double GetBonificacao();
    public abstract void AumentarSalario();
```

## Classe filha
```
    // A classe filha precisa estar com os mesmos parametros, que a classe pai. Para utilizar esses dados utilizam-se
    // A palavra reservada "base"
    public Auxiliar(string cpf) : base(cpf, 2000)
```

## Polimorfismo
```
    public override double GetBonificacao()
    public override void AumentarSalario()
```
## Destrutor
```
    // Destrutor
    // O metodo destrutor só executa quando o Garbage collector, indentifica qual o melhor momento para fazer isso
    // O CLR (Common Language Runtime), fica responsavel por isso
    ~Auxiliar()
```

## Pegar dados da superClasse
```
    public override double GetBonificacao()
    {
        // Base: pega os dados da superClasse
        // return this.Salario + base.GetBonificacao();

        return this.Salario * 0.5;
    }
```