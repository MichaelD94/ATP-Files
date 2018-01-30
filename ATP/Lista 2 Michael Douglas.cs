//Lista de Exercícios 2
// Michael Douglas Paim
Var
   
    opcao, age1, agr2, age, alternativa: inteiro
   hora1, hora2, minuto1, minuto2, segundo1, segundo2, segundosTotal_1, segundosTotal_2, diferencaSegundos, dh, dm, ds, maiorHora, menorHora: inteiro
   nome1, nome2, nomeP1, nomeP2, nomeP3, nomeG, nomeM, nomeP, escaleno, esosceles, equilatero: caractere
   cels, fahr, kelvin, sideA, sideB, sideC: real
   side1, side2, side3, altura1, altura2, altura3, area, semiP, soma, maior, altura, areaQ, semip10: real
   polig, diag, lados: inteiro
   ladoQ, perimetroQ, raio, alturaP1, alturaP2, alturaP3, maiorP, menorP, medio, medida, altura10, area10, perimetro10, raio10: real
   
Inicio

   escreval("					MENU			")
 
   escreval("    1-Algoritimo Para Determinar a Pessoa Mais nova")
   escreval("    2-Algoritimo Para Determinar a Condição do Eleitor")
   escreval("    3-Algoritimo Para Conversão de Temperaturas")
   escreval("    4-Algoritimo Para Determinar Medidas Válidas de Um Triângulo e Calcular Suas Alturas")
   escreval("    5-Algoritimo Para Determinar Número de Diagonais de um Polígono")
   escreval("    6-Algoritimo Para Converter Horas em Segundos e Calcular a Difrença entre Elas")
   escreval("    7-Algoritimo Para Determinar o Perímetro de um Quadrado e o Raio de uma Circuferência")
   escreval("    8-Algoritimo Para Determinar o Nome da Pessoa Mais Baixa e Mais Alta")
   escreval("    9-Algoritimo Para Determinar o Tipo de Triângulo, Equilátero, Esósceles ou Escaleno")
   escreval("    10-Algoritimo Para Determinar as Medidas de um Polígono Retangular")
   escreval("")
   escreva("    Digite a sua opção e aperte enter: ")
   leia(opcao)

   limpatela

    
   
   escolha (opcao)
   
     caso 1
	//Exercício 1
    //Determinar a Pessoa Mais nova
    
	//Entrada de Dados
      
        escreva("Digite o nome da pessoa primeira pessoa: ")
        leia(nome1)
        escreva("Digite a idade da primeira pessoa: ")
        leia(age1)
        limpatela
        escreva("Digite o nome da segunda pessoa: ")
        leia(nome2)
        escreva("Digite a idade da segunda pessoa: ")
        leia(age2)
        limpatela
   
    //Processamento e Saída de Resultados
   
     se (age1<age2) entao

        escreva(nome1, " ", age1, " anos de idade")
   
     senao

        escreva(nome2, " ", age2, " anos de idade")
   
     fimse
   

    //Exercício 2
    //Determinar se o Eleitor Obrigatório, Facultativo ou Não Eleitor
   
     caso 2
     
    //Entrada de Dados
     
        escreva("Digite idade: ")
        leia(age)

    //Processamento e Saída de Resultados
        
     se (age<15) entao
     
        escreval("Não Eleitor")

     fimse

     se (age>=18) e (age <70) entao
     
        escreval("Eleitor Obrigatório")
        
     fimse
     
     se ((age<18) e (age>15) ou (age>69)) entao
     
        escreval("Eleitor Facultativo")
        
     fimse
     
     
    //Exercício 3
    //Converter Temperaturas entre Celsius, Fahrenheit e Kelvin
   
     caso 3

        escreval("Menu")
        escreval("1-Temperatura em graus Celsius para Fahrenheit e Kelvin")
        escreval("2-Temperatura em graus Fahrenheit para Celsius e Kelvin")
        escreval("3-Temperatura em graus Kelvin para Celsius e Fahrenheit")
        
        escreva("Digite a sua alternativa: ")
        leia(alternativa)
        limpatela
        
     se (alternativa=1) entao
     
    //Entrada de Dados
     
        escreva("Digite o valor da temperatura em graus Celsius: °")
        leia(cels)
        limpatela
        
    //Processamento
   
        fahr <- cels*1.38+32
        kelvin <- cels + 273.15

    //Saída de Resultados
   
        escreval("°",cels," Graus Celsius equivalem a °",fahr," Graus Fahrenheit e a °",kelvin," Graus Kelvin")
        
     fimse
    
     se (alternativa=2) entao

    //Entrada de Dados
     
        escreva("Digite o valor da temperatura em graus Fahrenheit: °")
        leia(fahr)
        limpatela
        
    //Processamento
    
        cels <- (fahr-32)/1.8
        kelvin <- cels+273.15

    //Saída de Resultados
    
        escreval("°",fahr," Graus Fahrenheit equivalem a °",cels:1:2," Graus Celsius e a °",kelvin:1:2," Graus Kelvin")
        
     fimse
     
     se (alternativa=3) entao
    
    //Entrada de Dados

        escreva("Digite o valor da temperatura em graus Kelvin: °")
        leia(kelvin)
        limpatela
        
    //Processamento
    
        cels <- kelvin-273.15
        fahr <- (cels*1.8)+32
        
    //Saída de Resultados
    
        escreval("°",kelvin," Graus Kelvin equivalem a °",cels:1:2," Graus Celsius e a °",fahr:1:2," Graus Fahrenheit")
     
     fimse
     
     
    //Exercício 4
    //Ler e Validar as Medidas de um  Triângulo Qualquer e Calcular a Altura Relativa de Cada Lado

     caso 4

    //Entrada de Dados
     
        escreva("Digite a medida do 1º lado do triângulo: ")
        leia(side1)
        escreva("Digite a medida do 2º lado do triângulo: ")
        leia(side2)
        escreva("Digite a medida do 3º lado do triângulo: ")
        leia(side3)
        limpatela
     
    //Processamento

     se (side1 > side2) e (side1 > side3) entao
     
        maior <- side1
        soma <- side2 + side3

     senao

       se (side2 > side3) entao
        
        maior <- side2
        soma <- side1 + side3
        
       senao
     
        maior <- side3
        soma <- side1 + side2

       fimse
     fimse

    //Validação, Processamento e Saída de Resultados
     
     se (maior < soma) entao
     
        semiP <- side1 + side2 + side3 / 2

        area <- raizQ (semiP * (semip - side1) * (semiP - side2) * (semiP - side3))
        
        altura1 <- 2 * area / side1
        altura2 <- 2 * area / side2
        altura3 <- 2 * area / side3

        escreval("As medidas do triângulo são: ",side1,", ",side2," e ", side3)
        escreval("As medidas das alturas relativas são: ", altura1:1:3,", ",altura2:1:3," e ",altura3:1:3)

     senao
     
        escreval("As medidas digitadas NÃO SÃO VÁLIDAS para formar um triângulo!")
        escreval("")
        escreval("Tente Outras Medidas")

     fimse
        

    //Exercício 5
    //Ler o Número de Lados e Determinar Número de Diagonais de um Polígono
    
     caso 5
    
    //Entrada de Dados
    
        escreva("Digite o número de lados de um polígono: ")
        leia(polig)
        limpatela
      
    //Validação e Processamento
      
     se (polig >= 3) entao
        
        diag <- int ((polig * (polig - 3)) / 2)

    //Saída de Resultados
    
        escreval("O número de lados do polígono é: ",polig,", e o número de diagonais são: ",diag)

    //Validação

      senao

        escreval("")
        escreval("Este número de lados NÃO FORMAM UM POLIGONO!")
        escreval("")
        escreval("Tente um valor igual ou maior que 3")

      fimse
        
        
    //Exercício 6
    //Converter Horas em Segundos e Calcular a Diferença Entre Dois Horários Distintos

     caso 6

    //Entrada de Dados

        escreva("Digite a hora: ")
        leia(hora1)
        escreva("Digite os minutos : ")
        leia(minuto1)
        escreva("Digite os segundos : ")
        leia(segundo1)
        limpatela

    //Validação
        
     se (hora1 <= 24) e (minuto1 <= 60) e (segundo1 <= 60) entao

        segundosTotal_1 <- (hora1 * 60 + minuto1) * 60 + segundo1
        
     senao

        escreval("Hora digitada NÃO É VÁLIDA!")
        escreva("Digite a hora: ")
        leia(hora1)
        escreva("Digite os minutos : ")
        leia(minuto1)
        escreva("Digite os segundos : ")
        leia(segundo1)
        limpatela
        
     fimse

    //Entrada de Dados
    
        escreva("Digite a hora: ")
        leia(hora1)
        escreva("Digite os minutos : ")
        leia(minuto1)
        escreva("Digite os segundos : ")
        leia(segundo1)
        limpatela

    //Validação

     se (hora2 <= 24) e (minuto2 <= 60) e (segundo2 <= 60) entao

        segundosTotal_2 <- (hora2 * 60 + minuto2) * 60 + segundo2

     senao

        escreval("Hora digitada NÃO É VÁLIDA!")
       escreva("Digite a hora: ")
        leia(hora2)
        escreva("Digite os minutos : ")
        leia(minuto2)
        escreva("Digite os segundos : ")
        leia(segundo2)
        limpatela

     fimse

    //Processamento

     se (segundosTotal_1 < segundosTotal_2) entao
     
        maiorHora <- segundosTotal_2
        menorHora <- segundosTotal_1

     senao
     
        maiorHora <- segundosTotal_1
        menorHora <- segundosTotal_2

     fimse

        diferencaSegundos <- maiorHora - menorHora

        dh <- int (diferencaSegundos / 3600)
        dm <- int ((diferencaSegundos - (dh * 3600)) / 60)
        ds <- (diferencaSegundos - (dh * 3600) - (dm * 60))
        
     //Saída de Resultados
     
        escreval("Primeira hora: ",hora1,":",minuto1,":",segundo1)
        escreval("Segunda hora: ",hora2,":",minuto2,":",segundo2)
        escreval("Diferença entre as duas horas: ",dh,":",dm,":",ds)


     //Exercício 7
    //Determinar o Perímetro de um Quadrado e o Raio de uma Circuferência de Mesmo Valor

     caso 7

    //Entrada de Dados

        escreva("Digite a medida do lado de um quadrado: ")
        leia(ladoQ)
        limpatela

    //Validação e Processamento
        
     se (ladoQ > 0) entao
     
        perimetroQ <- ladoQ * 4
        
        raio <- 2 * Pi *ladoQ
        
    //Saída de Resultados
    
        escreval(" A medida do lado do quadrado é: ",ladoQ,", o perímetro desse quadrado é: ",perimetroQ," e o raio da circuferência é: ",raio:1:2)

     senao
     
        escreval("")
        escreval("Digite uma medida VÁLIDA POSITIVA!!")

     fimse
     
     
    //Exercício 8
    //Determinar o Nome da Pessoa Mais Baixa e Mais Alta
     
     caso 8
     
    //Entrada de Dados
     
        escreva("Digite o nome da primeira pessoa: ")
        leia(nomeP1)
        escreva("Digite a altura da primeira pessoa: ")
        leia(alturaP1)
        limpatela
        escreva("Digite o nome da segunda pessoa: ")
        leia(nomeP2)
        escreva("Digite a altura da segunda pessoa: ")
        leia(alturaP2)
        limpatela
        escreva("Digite o nome da terceira pessoa: ")
        leia(nomeP3)
        escreva("Digite a altura da terceira pessoa: ")
        leia(alturaP3)
        limpatela

    //Processamento
    
     se (alturaP1 > alturaP2) e (alturaP1 > alturaP3) entao
     
        maiorP <- alturaP1
        nomeG <- nomeP1

     senao

      se (alturaP2 > alturaP3) entao
     
        maiorP <- alturaP2
        nomeG <- nomeP2
        medio <- alturaP3
        nomeM <- nomeP3

       senao

        maiorP <- alturaP3
        nomeG <- nomeP3
        medio <- alturaP1
        nomeM <- nomeP1
        
      fimse
     fimse
     
     se (alturaP1 < alturaP2) e (alturaP1 < alturaP3) entao
     
        menorP <- alturaP1
        nomeP <- nomeP1
        
     senao

      se (alturaP2 < alturaP3) entao
      
        menorP <- alturaP2
        nomeP <- nomeP2
        medio <- alturaP3
        nomeM <- nomeP3
      senao
      
        menorP <- alturaP3
        nomeP <- nomeP3
        medio <- alturaP2
        nomeM <- nomeP2

      fimse
     fimse
        
    //Saída de Resultados
    
        escreval("A pessoa mais baixa é: ",nomeP)
        escreval("")
        escreval("A pessoa mais alta é: ",nomeG)
        escreval("")
        escreval("A ordem crescente é: ",nomeP,", altura: ",menorP,"m, ",nomeM,", altura: ",medio,"m, ",nomeG,", altura: ",maiorP,"m")


    //Exercício 9
    //Programa Para Determinar o Tipo de Triângulo, Equilátero, Esósceles ou Escaleno

     caso 9
     
    //Entrada de Dados
     
        escreva("Digite a medida do lado A do triângulo: ")
        leia(sideA)
        escreva("Digite a medida do lado B do triângulo: ")
        leia(sideB)
        escreva("Digite a medida do lado C do triângulo: ")
        leia(sideC)
        limpatela

    //Validação
    
     se (sideA > sideB) e (sideA > sideC) entao

        maior <- sideA
        soma <- sideB + sideC

     senao

       se (sideB > side3) entao

        maior <- sideB
        soma <- sideA + sideC

       senao

        maior <- sideC
        soma <- sideA + sideB

       fimse
     fimse

    //Validação, Processamento e Saída de Resultados

     se (maior < soma) entao
     
      se (sideA = sideB) e (sideA = sideC) entao
      
         escreval(" Este é um triângulo EQUILÁTERO!")
       
      senao
     
       se (sideA = sideB) e (sideA <> sideC) entao

          escreval("Este é um triângulo ISÓSCELES!")
          
       senao
          
        se (sideA = sideC) e (sideA <> sideB) entao
        
             escreval("Este é um triângulo ISÓSCELES!")

        senao
     
         se (sideA <> sideB) e (sideA <> sideC) e (sideB <> sideC) entao
      
          escreval("Este é um triângulo ESCALENO!")

     senao

        escreval("As medidas digitadas NÃO SÃO VÁLIDAS para formar um triângulo!")
        escreval("")
        escreval("Tente Outras Medidas")


         fimse
        fimse
       fimse
      fimse
     fimse


    //Exercício 10
    //Programa Para Determinar o Tipo de Triângulo, Equilátero, Esósceles ou Escaleno

     caso 10

    //Entrada de Dados
    
        escreva("Digite o número de lados do polígono retangular: ")
        leia(lados)
        escreva("Digite a medida de um dos lados desse polígno: ")
        leia(medida)
        limpatela

    //Processamento

     se ((lados >= 3) e (lados <= 6)) entao

     se (lados = 3) entao
     
        semiP10 <- (medida * 3) / 2

        area10 <- raizQ (semiP10 * (semip10 - medida) * (semiP10 - medida) * (semiP10 - medida))
        
        altura10 <- (2 * area10) / medida
        
        escreval("A altura desse polígono de 3 lados é: ",altura10:1:2)
        
     senao
     
      se (lados = 4) entao
      
         areaQ <- medida * medida
        
        escreval("A área desse polígono de 4 lados é: ",areaQ)
        
      senao
     
       se (lados = 5) entao
        
          perimetro10 <- medida * 5
        
          escreval("O perímetro desse polígono de 5 lados é: ",perimetro10)
        
       senao

        se (lados = 6) entao
         
            raio10 <- medida
            
            escreval("O raio da círculo circunscrito nesse polígono de 6 lados é: ",medida)

        fimse
       fimse
      fimse
     fimse
     fimse

   fimescolha
   
Fimalgoritmo