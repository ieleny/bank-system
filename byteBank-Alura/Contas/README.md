# Contas

# Testes no program

## Adicionar conta corrente

```
    Cliente clienteAndre = new Cliente();
    clienteAndre.Nome = "André silva";
    clienteAndre.Cpf = "146548-8848";
    clienteAndre.Profissao = "Contador";

    ContaCorrente contaDoAndre = new ContaCorrente(15, "1010-4");
    contaDoAndre.Titular = clienteAndre;
    contaDoAndre.SetSaldo(100);
    contaDoAndre.Depositar(100);
    
    contaDoAndre.ExibirDadosDaConta(contaDoAndre);
```
## Transferência conta corrente

```
    Cliente clienteMaria = new Cliente();
    clienteMaria.Nome = "Maria Souza";
    clienteMaria.Cpf = "146548-88423";
    clienteMaria.Profissao = "Pedreiro(a)";

    ContaCorrente contaDaMaria = new ContaCorrente(17, "1010-5");
    contaDaMaria.Titular = clienteMaria;
    contaDaMaria.SetSaldo(350);

    contaDoAndre.Transferir(50, contaDaMaria);

    contaDaMaria.ExibirDadosDaConta(contaDaMaria);
    contaDoAndre.ExibirDadosDaConta(contaDoAndre);
```

## Mostrando valores padrões

```
    // A conta do pedro não foi definido nenhum valor, por isso irá mostrar os valores padrões de cada tipo (string = null, bool = false, int = 0 ...)
    Cliente clientePedro = new Cliente();
    clientePedro.Nome = "Pedro Silva";
    ContaCorrente contaDoPedro = new ContaCorrente(17, "1010-9");
    contaDoPedro.Titular = clientePedro;
    contaDoPedro.ExibirDadosDaConta(contaDoPedro);
```

## Referência nulla
```
    // Tipo de valor
    // Tipo de referencia

    // Referência nulla
    ContaCorrente contaOsvaldo = new ContaCorrente(18, "1010-10");
    // Não tem como definir os valores, sem definir o new
    //contaOsvaldo.titular.nome = "Osvaldo cruz";
    //contaOsvaldo.titular.cpf = "146548-88423";
    //contaOsvaldo.titular.profissao = "Pedreiro(a)";
    //contaOsvaldo.Numero_agencia = 17;
    //contaOsvaldo.Conta = "1010-5";
    contaOsvaldo.Titular = clientePedro;
    // Controle de valor negativo
    contaOsvaldo.SetSaldo(350);
    contaOsvaldo.ExibirDadosDaConta(contaOsvaldo);

    // Referencia da propriedade de classe
    // Console.WriteLine($"Propriedades da classe: {ContaCorrente.TotalDeContasCriadas}");
```

# Explicação de algumas partes do paradigma (POO) e boas práticas

## Visilibilidade

```
//Nome da classe, propriedades,enumeradores,interfaces,records e estruturas precisa ser em PascalCase
public class ContaCorrente
```

## Modificadores
```
    // Modificadores de acesso: public, private, protected, internal, protected internal
    // CamelCase: Quando for nomear variaveis que definem campos e parametros de metodos, os campos private ou internal com o prefixo _
    // CamelCase: Metodos
    private int numero_agencia;
```

## Propriedades
```
    private int numero_agencia;
    // Propriedades
    public int Numero_agencia 
    {
        get { return this.numero_agencia; }
        // Só será visivel dentro da classe
        private set { 
            if (value > 0) 
            { 
                numero_agencia = value; 
            } 
        }
    }
```

## Propriedade autoimplementada
```
    public string Conta { get; set; }
```
## Encapsulamento
```
    public void SetSaldo(double valor)
    {
        if (valor <= 0)
        {
            return;
        }
        else
        {
            this.saldo = valor;
        }
    }
```
## Propriedade static
```
    // Quando utiliza o static é uma Propriedade da classe
    // Essa propriedade é salva no codigo fonte do projeto, então cuidado ao utilizar por causa da performance
    public static int TotalDeContasCriadas { get; private set; }
    public static float TaxaOperacao { get; private set; }
```
