# Teste de admissão NetLex

## *Questões* 

1. **Lógica.**
 
>Mais de um gato grande é gordo. Nem todo gato branco é bravo. Não há gato gordo que não seja branco. É possível ter um gato grande e bravo? Explicite sua linha de raciocínio.
 
2. **Lógica de Programação.**
 
>O art. 47 da Lei n. 8.245/1991 prevê que caso a locação seja ajustada verbalmente ou por escrito e com prazo inferior a trinta meses, ela prorroga-se automaticamente e por prazo indeterminado. Traduzindo para uma proposição lógica, podemos assim escrever:
 
[Se o contrato for verbala locação prorroga-se automaticamente e por prazo indeterminado]
[Se o contrato for escrito[Se o prazo é inferior a 30 mesesa locação prorroga-se automaticamente e por prazo indeterminado]]
 
>Já o art. 46 da Lei n. 8.245/1991 prevê que se a locação for pactuada por escrito e por prazo igual ou superior a trinta meses, a resolução do contrato ocorre com o fim do prazo. Como poderíamos traduzir esta regra para uma proposição lógica?
 
3. **Programação.**
 
>Dado um arquivo (obrigatoriamente chamado in.txt) contendo em sua primeira linha um inteiro positivo M maior que 0 e em sua segunda linha um texto, realizar a quebra de linha do texto sem quebrar palavras, considerando que a linha pode ter no máximo M caracteres. 

>O texto se encontra inteiro em uma linha do arquivo. O texto pode ser arbitrariamente longo, mas sempre terá pelo menos uma palavra. A resposta deve ser escrita em um arquivo texto obrigatoriamente denominado out.txt. 

>O problema pode ser resolvido em qualquer linguagem de programação que conte com uma IDE virtual disponível em http://www.tutorialspoint.com/codingground.htm, e deve compilar e rodar corretamente, produzindo o arquivo de saída com a resposta.

## *Respostas*

1. **Lógica**

Conforme consta nas premissas da questão:
>"Não há gato gordo que não seja branco.", logo, todos os gatos brancos são gordos.
>"Nem todo gato branco é bravo". O prefixo "Nem" da ideia de negação, permitindo-nos inferir que ao menos um gato branco NÃO é bravo, entretanto há gatos brancos e bravos que são a maioria.
>"Mais de um gato grande é gordo", logo, existem gatos gordos E grandes.
 
**Conclusão**: apesar de não explicitar o número de gatos, há a probabilidade de um gato ser grande e bravo, visto que a maioria dos gatos gordos são bravos e também os gatos gordos podem ser grandes.

2. *Lógica de Programação*

```
SE (locação = escrito && prazo >= 30){
      a resolução do contrato ocorre com o fim do prazo
}
```