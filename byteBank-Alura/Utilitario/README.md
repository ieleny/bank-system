# Utilitarios

# Testes no program

## Chamar classe GerenciadorDeBonificacao
```
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    gerenciador.Registrar(roberta);
    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(marcelo);

    Console.WriteLine("Total de bonificações:" + gerenciador.TotalDeBonificacoes);
```

## Chamar classe LeitorDeArquivo
```
    LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

    try
    {
        leitor.LerProximaLinha();
        leitor.LerProximaLinha();
    }
    catch (IOException)
    {
        Console.WriteLine("Leitura de arquivo interrompida");
    }
    finally
    {
        leitor.Fechar();
    }

    //  syntax sugar
    using (LeitorDeArquivo leitor1 = new LeitorDeArquivo("contas.txt"))
    {
        leitor1.LerProximaLinha();
        leitor1.LerProximaLinha();
        leitor1.LerProximaLinha();
    }
```
# Explicação de algumas partes do paradigma (POO) e boas práticas

## Visilibilidade

```
//Nome da classe, propriedades,enumeradores,interfaces,records e estruturas precisa ser em PascalCase
public class ContaCorrente
```