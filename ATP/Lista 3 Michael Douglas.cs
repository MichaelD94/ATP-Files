Lista 3 Michael Douglas
Var


  raizA, raizB: real
  opcao, x, pessoas: inteiro
  aluno1, aluno2, aluno3, media, mediaP, altura, soma: real
  n1, n2, a, b, y: inteiro
  paisB, paisA, crescA, crescB: real
  anos: inteiro

Inicio


    escreval("")
    escreva("Escolha Um Exercicio (1 a 6) ")
    leia(opcao)
    limpatela
    
    enquanto (opcao < 1 ) ou (opcao > 6) faca
    leia(opcao)
    fimenquanto

escolha (opcao)


caso 1

//Exercício 1
//Calcular a raiz quadrada e cubica dos númeos menores que 16

   //Entrada de Dados e Processamento

       x <- 0
       enquanto (x < 16) faca

       x <- x + 1
       raizA <- raizQ (x)
       raizB <- x ^ (1/3)

       escreval(" Raiz 2      Raiz 3")
       escreval(x,"= ",raizA:1:2,"    ",x,"= ",raizB:1:2)

       fimenquanto
       

caso 2

//Exercício 2
//Calcular a média aritmética de duas notas

   //Entrada de dados
   
       
       escreva("Digite a nota do Aluno: ")
       leia(aluno1)
       escreva("Digite a nota de outro Aluno: ")
       leia(aluno2)
       escreva("Digite a nota de um outro Aluno: ")
       leia(aluno3)
       
   //Processamento
       
       se (aluno1 > aluno2) e (aluno2 > aluno3) entao
       
         media <- (aluno1 + aluno2) / 2

       senao

         se (aluno2 > aluno1) e (aluno3 < aluno1) entao
         
           media <- (aluno2 + aluno1) / 2
         
         senao

           se ( aluno2 < aluno3) e (aluno1 < aluno2) entao
           
             media <- (aluno2 + aluno3) / 2
           
           senao
           
             se ( aluno1 > aluno2) e (aluno3 > aluno2) entao
             
               media <- (aluno1 + aluno3) / 2

             fimse
           fimse
         fimse
       fimse

   //Saída de Resultados
   

         escreval("As notas são: ", aluno1,", ", aluno2,", ", aluno3,". E a MÉDIA ARTMÉTICA É: ", media)


caso 3

//Exercício 3
//Escrever os números inteiro de um intervalo [a,b]

   //Entrada de Dados
   
       escreva("Digite um número inteiro qualquer e aperte enter: ")
       leia(n1)
       escreva("Agora, digite um outro número inteiro qualquer e aperte enter: ")
       leia(n2)
       limpatela
       
   //Processamento e Saída de Resultados
   
       se (n1 < n2) entao
       
         a <- n1
         b <- n2

       senao
       
         a <- n2
         b <- n1

       fimse
         
       enquanto (a <= b) faca
       
       escreva(a)
       a <- a + 1
       

       fimenquanto
       

caso 4

//Exercício 4
//Determinar e escrever todos os números inteiros positivos menores que 1000

   //Processamento e Saída de Resultados

       y <- 0
       
       enquanto (y <= 1000) faca
       
       escreva(y)
       y <- y + 1
       
       fimenquanto
       
       
caso 5

//Exercício 5
//Calcular a média aritmética da altura de um número indeterminado de pessoas

   //Entrada de Dados e Processamento
   
       pessoas <- -1
       
       escreval("Digite uma relação de alturas: ")
       escreval("Para finalizar e calcular a média digite ZERO ")
       repita
       leia(altura)

       soma <- soma + altura
       pessoas <- pessoas + 1

       ate altura = 0
       mediaP <- soma / pessoas
       
   //Saída de Resultados

       limpatela
       escreval("A média aritmética das alturas é: ", mediaP:1:2)
       

caso 6

//Exercício 6
//Programa para calcular quando a quantidade de habitantes de um país "A" alcançará a de um país "B"

   //Entra de Dados e Processamento
   
       paisA <- 50000000
       paisB <- 100000000
       anos <- 0
    
       enquanto (paisA <= paisB) faca
    
       crescA <- (paisA * 2) /100
       crescB <- (paisB * 1.2) /100
    
       paisA <- paisA + crescA
       paisB <- paisB + crescB
       anos <- anos + 1
    
       fimenquanto
    
   //Saída de Resultados
   
       escreval("Em ", anos, " anos")
       escreval("O pais A estará com ", paisA, " habitantes")
       escreval("O pais B estará com ", paisB, " habitantes")

	   
fimescolha
   
Fimalgoritmo