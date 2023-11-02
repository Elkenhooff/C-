//int x = 10; // Variável inteira
//string nomeAluno, sobrenome; // Variável frase

//Console.WriteLine("Digite o seu nome"); // Comando para escrever no console
//nomeAluno = Console.ReadLine(); // Comando para armazenar valor em uma variável
//Console.WriteLine("Escreva o seu sobrenome");
//sobrenome = Console.ReadLine();
//Console.WriteLine("Olá " + nomeAluno + " " + sobrenome+ ", seja bem vindo!");
//Console.WriteLine("Olá {0} {1}, seja bem vindo!", nomeAluno, sobrenome);

//int n1 = 10; // Variável que recebeu um valor fixo "10".
//int n2 = 20; // Variável que recebeu um valor fixo "10".
//int soma = n1 + n2; // Variável que soma duas variáveis.

//Console.WriteLine("A soma de ambos os números é " + soma);
//Console.WriteLine("A soma de {0} + {1} = {2}", n1, n2, soma);


//int x, y, soma;

//Console.WriteLine("Digite seu primeiro número");
//x = int.Parse(Console.ReadLine());
//Console.WriteLine("Digite seu segundo número");
//y = int.Parse(Console.ReadLine());
//soma = x + y;
//Console.WriteLine("A soma de ambos os números é " + soma);
//Console.WriteLine("A soma de {0} + {1} = {2}", x, y, soma);

//string nomeAluno;
//double n1, n2, n3, n4, media;

//Console.WriteLine("Escreva o nome do aluno(a)");
//nomeAluno = Console.ReadLine();
//Console.WriteLine("\nDigite a nota do 1° bimestre");
//n1 = double.Parse(Console.ReadLine());
//if (n1 >= 11)
//{
//    Console.WriteLine("Porfavor, insira um valor menor que 11.");
//}
//Console.WriteLine("\nDigite a nota do 2° bimestre");
//n2 = double.Parse(Console.ReadLine());
//Console.WriteLine("\nDigite a nota do 3° bimestre");
//n3 = double.Parse(Console.ReadLine());
//Console.WriteLine("\nDigite a nota do 4° bimestre");
//n4 = double.Parse(Console.ReadLine());
//media = (n1 + n2 + n3 + n4) / 4;

//Console.WriteLine("\nA média do aluno(a) " + nomeAluno + " é " + media);
//Console.WriteLine("A média do aluno(a) {0} é {1}", nomeAluno, media);

////Dia 12/06
////Exercicio 01
//string nome;
//Console.WriteLine("Insira uma frase");
//nome = Console.ReadLine();
//Console.WriteLine("A frase que você inseriu é: {0}", nome);
////Exercicio 02
//Console.WriteLine("A frase que você inseriu possuí " + nome.Length + " characteres. (com os espaços)");
////Exercicio 03
//Console.WriteLine("A primeira letra e a última letra da frase que você escolheu é {0} e {1}", nome.Substring(0, 1), nome.Substring(nome.Length - 1, 1));
////Exercicio 04
//Console.WriteLine("A frase que você escreveu em maisculo é\n{0}\nE a frase em minúsculo é\n{1}", nome.ToUpper(), nome.ToLower());
////Exercicio 05
//Console.WriteLine("A frase com a segunda letra em maisculo seria: " + nome.Substring(0, 1) + nome.ToUpper()[1] + nome.Substring(2));
////Exercicio 06
//if (nome.Length % 2 == 1)
//    Console.WriteLine("A letra que está no meio dá frase é: {0}", nome.Substring(nome.Length / 2, 1));
//if (nome.Length % 2 == 0)
//    Console.WriteLine("A letra que está no meio dá frase é: {0}", nome.Substring(nome.Length / 2 - 1, 2));
////Exercicio 07
//string letramaior;
//Console.WriteLine("Qual letra você deseja deixar em caps lock");
//letramaior = Console.ReadLine();
//Console.WriteLine(nome.Replace(letramaior, letramaior.ToUpper()));

//int media = 6;
//double nota;

//Console.Write("Digite a nota do aluno: ");
//nota = double.Parse(Console.ReadLine());

//if (nota >= media)
//{
//    Console.WriteLine("Aprovado");
//}
//else if(nota >= 5 && nota < 6)
//{
//    Console.WriteLine("Recuperação");
//}
//else
//{
//    Console.WriteLine("Reprovado");
//}

//Dia 13/06
//Exercicio 01
//int num;

//Console.Write("Insira um número: ");
//num = int.Parse(Console.ReadLine());
//Console.WriteLine("O sucessor do número {0} é {1}, e o seu antecessor é o {2}", num, num + 1, num - 1);

////Exercicio 02
//int media = 6;
//int total = media * 4;
//double n1, n2, n3, n4, notaMedia, notaTotal;

//Console.WriteLine("Insira a nota do 1° bimestre");
//n1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Insira a nota do 2° bimestre");
//n2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Insira a nota do 3° bimestre");
//n3 = double.Parse(Console.ReadLine());
//notaMedia = (n1 + n2 + n3) / 4;
//notaTotal = n1 + n2 + n3;
//Console.WriteLine("A sua média foi {0} nos 3 bimestres", notaMedia);
//if (notaMedia >= media)
//{
//    Console.WriteLine("A media da nota dos 3 bimestres já são suficientes para passar de ano");
//}
//else if (notaTotal + 10 < total)
//{
//    Console.WriteLine("Não é possível passar de ano nem com a nota do 4° bimestre");
//}
//else
//{
//    Console.WriteLine("Não é suficiente para passar de ano, para que passe de ano você precisa tirar uma média de {0} no 4° bimestre ou uma nota de {1}", media - notaMedia, (media - notaMedia) * 4);
//}

////Exercicio 03
////int shu, kunai;
////int anos = 365;
//double precok, precos, shu, kunai, anos, ano = 365;
//Console.WriteLine("Qual é o valor do pacote de shurikens?");
//precos = double.Parse(Console.ReadLine());
//Console.WriteLine("Qual é o valor do pacote de kunais?");
//precok = double.Parse(Console.ReadLine());
//Console.WriteLine("Há quanto anos você trabalha como ninja?");
//anos = int.Parse(Console.ReadLine());
//Console.WriteLine("Escreva a quantidade de shurikens gasta por dia");
//shu = int.Parse(Console.ReadLine());
//Console.WriteLine("Escreva a quantidade de kunai gasta por dia");
//kunai = int.Parse(Console.ReadLine());
//precos = precos * (shu / 12);
//precok = precok * (kunai / 12);
//Console.WriteLine("O valor gasto com as shurikens por dia é de {0} reais, em {1} anos você terá gasto {2} reais", precos, anos, precos * anos * ano);
//Console.WriteLine("O valor gasto com as kunai por dia é de {0} reais, em {1} anos você terá gasto {2} reais", precok, anos, precok * anos * ano);

////Exercicio 4
//int x, y;
//Console.WriteLine("Escreva o número que você deseja dividir");
//x = int.Parse(Console.ReadLine());
//Console.WriteLine("Escreva por qual número deseja dividir (quociente)");
//y = int.Parse(Console.ReadLine());
//Console.WriteLine("O número {0} dividido por {1} é igual a {2} com um resto de {3}", x, y, x / y, x % y);

////Exercicio 5
//int x, y;
//Console.WriteLine("Coloque o número que desejar verificar se é multiplo");
//x = int.Parse(Console.ReadLine());
//Console.WriteLine("Coloque o número multiplo");
//y = int.Parse(Console.ReadLine());
//if (x % y == 0)
//{
//    Console.WriteLine("O número {0} é multiplo de {1}", x, y);
//}
//else
//{
//    Console.WriteLine("O número {0} não é multiplo de {1}", x, y);
//}

////Exercicio 6
//double n1, n2, n3, n4, media;

//Console.WriteLine("\nDigite a nota do 1° bimestre");
//n1 = double.Parse(Console.ReadLine());
//Console.WriteLine("\nDigite a nota do 2° bimestre");
//n2 = double.Parse(Console.ReadLine());
//Console.WriteLine("\nDigite a nota do 3° bimestre");
//n3 = double.Parse(Console.ReadLine());
//Console.WriteLine("\nDigite a nota do 4° bimestre");
//n4 = double.Parse(Console.ReadLine());
//media = (n1 + n2 + n3 + n4) / 4;
//if (media >= 6)
//{
//    Console.WriteLine("O aluno foi aprovado.");
//}
//else
//{
//    Console.WriteLine("O aluno foi reprovado.");
//}

////Exercicio 7
//double x, y, z;
//Console.WriteLine("Digite o primeiro número");
//x = double.Parse(Console.ReadLine());
//Console.WriteLine("\nDigite o segundo número");
//y = double.Parse(Console.ReadLine());
//Console.WriteLine("\nDigite o terceiro número");
//z = double.Parse(Console.ReadLine());

//if (x > y + z)
//{
//    Console.WriteLine("O número {0} é maior que a soma de {1} e {2} ({3})", x, y, z, y + z);
//}
//else
//{
//    Console.WriteLine("O número {0} não é maior que a soma de {1} e {2} ({3})", x, y, z, y + z);
//}

////Exercicio 8
//string nomeTentativa;
//string nome = "pedro henrique david dos santos";
//Console.WriteLine("Por favor insira o nome do dono da loja.");
//nomeTentativa = Console.ReadLine().Trim().ToLower();

//if (nome == nomeTentativa)
//{
//    Console.WriteLine("Nome correto.");
//}
//else
//{
//    Console.WriteLine("Nome incorreto.");
//}

////Exercicio 9
//double x, y;
//Console.WriteLine("Por favor insira o primeiro número.");
//x = double.Parse(Console.ReadLine().Trim());
//Console.WriteLine("Por favor insira o segundo número.");
//y = double.Parse(Console.ReadLine().Trim());

//if (x > y)
//{
//    Console.WriteLine("O número {0} é maior que o número {1}", x, y);
//}
//else if (x == y)
//{
//    Console.WriteLine("O número {0} é igual o número {1}", x, y);
//}
//else
//{
//    Console.WriteLine("O número {0} é menor que o número {1}", x, y);
//}

////Exercicio 10
//double x, y;
//Console.WriteLine("Por favor insira o primeiro número.");
//x = double.Parse(Console.ReadLine().Trim());
//Console.WriteLine("Por favor insira o segundo número.");
//y = double.Parse(Console.ReadLine().Trim());

//if (y == 0)
//{
//    Console.WriteLine("Não é possível fazer a divisão de um número por 0");
//}
//else
//{
//    Console.WriteLine($"A divisão de {x} por {y} é {x/y}");
//}

//Exercicio 11
//Console.WriteLine("Digite os coeficientes da equação de segundo grau:");
//Console.Write("Coeficiente a: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.Write("Coeficiente b: ");
//double b = Convert.ToDouble(Console.ReadLine());

//Console.Write("Coeficiente c: ");
//double c = Convert.ToDouble(Console.ReadLine());

//double delta = Math.Pow(b, 2) - 4 * a * c;

//if (delta > 0)
//{
//    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//    Console.WriteLine("As raízes são reais e diferentes:");
//    Console.WriteLine("x1 = " + x1);
//    Console.WriteLine("x2 = " + x2);
//}
//else if (delta == 0)
//{
//    double x = -b / (2 * a);
//    Console.WriteLine("As raízes são reais e iguais:");
//    Console.WriteLine("x = " + x);
//}
//else
//{
//    Console.WriteLine("As raízes são complexas e não podem ser calculadas neste exemplo.");
// }

// Exercicio 12
//int num, soma = 0;

//Console.Write("Digite o primeiro número inteiro: ");
//num = int.Parse(Console.ReadLine());
//if (num % 2 == 0) soma += num;
//Console.Write("Digite o segundo número inteiro: ");
//num = int.Parse(Console.ReadLine());
//if (num % 2 == 0) soma += num;
//Console.Write("Digite o terceiro número inteiro: ");
//num = int.Parse(Console.ReadLine());
//if (num % 2 == 0) soma += num;
//Console.Write("Digite o quarto número inteiro: ");
//num = int.Parse(Console.ReadLine());
//if (num % 2 == 0) soma += num;
//Console.Write($"A soma dos número pares é {soma}");


//Exercicio 13

//Console.WriteLine("Digite três valores:");
//Console.Write("Valor 1: ");
//double valor1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Valor 2: ");
//double valor2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Valor 3: ");
//double valor3 = Convert.ToDouble(Console.ReadLine());

//double maior = valor1; // Assume que o valor1 é o maior inicialmente

//if (valor2 > maior)
//{
//    maior = valor2;
//}

//if (valor3 > maior)
//{
//    maior = valor3;
//}

//Console.WriteLine("O maior valor é: " + maior);

// Exercicio 14
//Console.WriteLine("Digite três valores:");
//Console.Write("Valor 1: ");
//double valor1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Valor 2: ");
//double valor2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Valor 3: ");
//double valor3 = Convert.ToDouble(Console.ReadLine());

//// Ordenação em ordem decrescente
//if (valor1 < valor2)
//{
//    double temp = valor1;
//    valor1 = valor2;
//    valor2 = temp;
//}

//if (valor2 < valor3)
//{
//    double temp = valor2;
//    valor2 = valor3;
//    valor3 = temp;
//}

//if (valor1 < valor2)
//{
//    double temp = valor1;
//    valor1 = valor2;
//    valor2 = temp;
//}

//Console.WriteLine("Os valores em ordem decrescente são: " + valor1 + ", " + valor2 + ", " + valor3);

//Dia 20/06

////Exercicio 01
//string n1, n2, n3;
//double id1, id2, id3, media;

//Console.WriteLine("Insira o nome do primeiro aluno (a)");
//n1 = Console.ReadLine();
//Console.WriteLine("Insira a idade dele (a)");
//id1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Insira o nome do segundo aluno (a)");
//n2 = Console.ReadLine();
//Console.WriteLine("Insira a idade dele (a)");
//id2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Insira o nome do terceiro aluno (a)");
//n3 = Console.ReadLine();
//Console.WriteLine("Insira a idade dele (a)");
//id3 = double.Parse(Console.ReadLine());
//media = (id1 + id2 + id3) / 3;
//Console.WriteLine($"A média de idade dos alunos (a) é {media}");
//if (id1 > id2 && id1 > id3)
//{
//    Console.WriteLine($"O aluno mais velho é o (a) {n1} com uma idade de {id1} anos.");
//}
//else if ( id2 > id1 && id2 > id3)
//{
//    Console.WriteLine($"O aluno mais velho é o (a) {n2} com uma idade de {id2} anos.");
//}
//else
//{
//    Console.WriteLine($"O aluno mais velho é o (a) {n3} com uma idade de {id3} anos.");
//}

////Exercicio 02
//double x, y, z;
//Console.WriteLine("Insira a medida do primeiro lado do triângulo");
//x = int.Parse(Console.ReadLine());
//Console.WriteLine("Insira a medida do segundo lado do triângulo");
//y = int.Parse(Console.ReadLine());
//Console.WriteLine("Insira a medida do terceiro lado do triângulo");
//z = int.Parse(Console.ReadLine());

//if (x >= y + z || y >= x + z || z >= y + x)
//{
//    Console.WriteLine("Não forma um triângulo.");
//}
//else if (Math.Pow(x, 2) == Math.Pow(y, 2) + Math.Pow(z, 2) || Math.Pow(y, 2) == Math.Pow(x, 2) + Math.Pow(z, 2) || Math.Pow(z, 2) == Math.Pow(x, 2) + Math.Pow(y, 2))
//{
//    Console.WriteLine("Forma um triângulo retangulo.");
//}
//else if (Math.Pow(x, 2) > Math.Pow(y, 2) + Math.Pow(z, 2) || Math.Pow(y, 2) > Math.Pow(x, 2) + Math.Pow(z, 2) || Math.Pow(z, 2) > Math.Pow(x, 2) + Math.Pow(y, 2))
//{
//    Console.WriteLine("Forma um triângulo obtusângulo.");
//}
//else if(Math.Pow(x, 2) < Math.Pow(y, 2) + Math.Pow(z, 2) || Math.Pow(y, 2) < Math.Pow(x, 2) + Math.Pow(z, 2) || Math.Pow(z, 2) < Math.Pow(x, 2) + Math.Pow(y, 2))
//{
//    Console.WriteLine("Forma um triângulo acutângulo.");
//}
//if (x == y && x == z)
//{
//    Console.WriteLine("Forma um triângulo equilátero");
//}
//else if (x == y && x > z || x == z && x > y || z == y && z > x)
//{
//    Console.WriteLine("Forma um triângulo isósceles");
//}

////Exercicio 03
//int[] notas = { 100, 50, 20, 10, 5, 2 };
//int saque, saquenotas;

//Console.WriteLine("Insira o valor que deseja sacar.");
//saque = int.Parse(Console.ReadLine());

//if (saque >= notas[0])
//{
//    saquenotas = saque / notas[0];
//    Console.WriteLine($"Você precisará de {saquenotas} de 100 reais");
//    saque = saque - saquenotas * notas[0];
//}
//if (saque >= notas[1])
//{
//    saquenotas = saque / notas[1];
//    Console.WriteLine($"Você precisará de {saquenotas} de 50 reais");
//    saque = saque - saquenotas * notas[1];
//}
//if (saque >= notas[2] || saque < notas[2])
//{
//    saquenotas = saque / notas[2];
//    Console.WriteLine($"Você precisará de {saquenotas} de 20 reais");
//    saque = saque - saquenotas * notas[2];
//}
//if (saque >= notas[3])
//{
//    saquenotas = saque / notas[3];
//    Console.WriteLine($"Você precisará de {saquenotas} de {notas[3]} reais");
//    saque = saque - saquenotas * notas[3];
//}
//if (saque >= notas[4])
//{
//    saquenotas = saque / notas[4];
//    Console.WriteLine($"Você precisará de {saquenotas} de 5 reais");
//    saque = saque - saquenotas * notas[4];
//}
//if (saque >= notas[5])
//{
//    saquenotas = saque / notas[5];
//    Console.WriteLine($"Você precisará de {saquenotas} de 2 reais");
//    saque = saque - saquenotas * notas[5];
//}
//if (saque == 1)
//{
//    Console.WriteLine("E com um resto de 1 real, enviaremos esse valor na sua conta digitalmente.");
//}


////Exercicio 04
//DateTime horainicio, horafim;
//TimeSpan finalizacao;

//Console.WriteLine("Insira o horario que começou a partida");
//horainicio = DateTime.Parse(Console.ReadLine());
//Console.WriteLine("Insira o horario que finalizou a partida");
//horafim = DateTime.Parse(Console.ReadLine());
//finalizacao = horafim - horainicio;
//if (horafim > horainicio)
//{
//    Console.WriteLine($"A duração do jogo foi de exatas {finalizacao}");
//}
//else
//{
//    finalizacao = (horafim + TimeSpan.FromHours(24)) - horainicio;
//    Console.WriteLine($"A duração do jogo foi de exatas {finalizacao}");
//}

////Exercicio 05
//double valor;
//Console.WriteLine("Informe o valor do produto");
//valor = double.Parse(Console.ReadLine());

//if (valor < 999)
//{
//    Console.WriteLine("Como o valor é menor que 999, há um acrésimo de 2% no valor como imposto no produto.\nO valor do imposto será de {0} reais, ficando com um valor total de {1} reais", valor * 0.02, valor + valor * 0.02); ;
//}
//else if (valor >= 1000 && valor < 2999)
//{
//    Console.WriteLine("Como o valor está entre 1000 e 2999, há um acrésimo de 2,5% no valor como imposto no produto.\nO valor do imposto será de {0} reais, ficando com um valor total de {1} reais", valor * 0.025, valor + valor * 0.025); ;
//}
//else if (valor >= 3000 && valor < 6999)
//{
//    Console.WriteLine("Como o valor está entre 3000 e 6999, há um acrésimo de 2,8% no valor como imposto no produto.\nO valor do imposto será de {0} reais, ficando com um valor total de {1} reais", valor * 0.028, valor + valor * 0.028); ;
//}
//else if (valor >= 7000)
//{
//    Console.WriteLine("Como o valor é maior que 7000, há um acrésimo de 3% no valor como imposto no produto.\nO valor do imposto será de {0} reais, ficando com um valor total de {1} reais", valor * 0.03, valor + valor * 0.03); ;
//}

////Exemplo 1
//for (int x = 0; x <= 10; x++)
//{
//        Console.WriteLine("{0} x {1} = {2} ", 9, x, 9 * x);
//}


////Exemplo 2
//using System.Security.Cryptography.X509Certificates;

//int i = 0;

//while (i <= -5)
//{
//    Console.WriteLine("{0} X {1} = {2}", 9, i, 9 * i);
//}
//do
//{
//    Console.WriteLine("{0} X {1} = {2} ", 9, i, 9 * i); i++;
//}
//while (i < -5);

////Exercicio 1
//int soma = 0;

//for (int x = 1; x <= 1000; x++)
//{
//    soma += x;
//}
//Console.WriteLine(soma);

////Exercicio 02
//int i;

//for (i = 1; i <= 100; i++)
//{
//    if (i % 3 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

////Exercicio 03
//int i;
//int soma = 0;

//for (i = 1; i <= 100; i++)
//{
//    soma += i;
//    if (i % 3 == 0)
//    {
//        soma -= i;
//    }
//}
//Console.WriteLine($"O resultado da soma dos números de 1 a 100 exceto os multiplos de 3 é {soma}");

////Exercicio 04
//uint i;
//uint soma = 1;

//for (i = 1; i <= 30; i++)
//{
//    if (i % 3 == 0)
//    {
//        soma *= i;
//    }
//    //if (i % 4 == 0)
//    //{
//    //    soma *= i;
//    //}
//}
//Console.WriteLine($"A multiplicação dos números de 1 a 30, contando somente com os multiplos de 3 e 4 é {soma}");

////Exercicio 05
//double n;
//double soma = 1;

//Console.WriteLine("Insira qual número você deseja ver o fatorial");
//n = uint.Parse(Console.ReadLine());

//for (n = n; n >= 1; n--)
//{
//    soma *= n;
//}
//Console.WriteLine($"O fatorial do seu número é {soma:0}");

////Exercicio 06
//int i, qnt;

//Console.WriteLine("Digite até qual número que você deseja conhecer");
//qnt = int.Parse(Console.ReadLine());

//if (qnt < 5)
//{
//    Console.WriteLine("O número inserido é menor que 5.");
//}
//for (i = 1; i <= qnt; i++)
//{
//    if (i % 5 == 0)
//    {
//        Console.WriteLine($"Os multiplos de 5 até {qnt} é: {i}");
//    }
//}

////Exercicio 7
//using System; //(ChatGPT)

//class Program
//{
//    static bool IsPrime(uint num)
//    {
//        if (num < 2)
//            return false;

//        for (uint i = 2; i <= Math.Sqrt(num); i++)
//        {
//            if (num % i == 0)
//                return false;
//        }

//        return true;
//    }

//    static void Main()
//    {
//        uint start = 1;
//        uint end = 100000;

//        for (uint num = start; num <= end; num++)
//        {
//            if (IsPrime(num))
//                Console.WriteLine(num);
//        }
//    }
//}

////Exercicio 08

//int i, n;
//double soma = 0;

//Console.WriteLine("Insira um valor para N");
//n = int.Parse(Console.ReadLine());
//for (i = 1; i <= n; i++)
//{
//    soma += 1.0 / i;

//}
//Console.WriteLine("A soma dos valores de S = 1 + 1/n é " + soma);

////Exercicio 09
//int i, x;
//int soma = 0;

//Console.Write("Insira o número que deseja verificar: ");
//x = int.Parse(Console.ReadLine());
//for (i = 1; i < x; i++)
//{
//    if (x % i == 0)
//    {
//        soma += i;
//        Console.WriteLine("Seus divisores é: " + i);
//    }
//}
//Console.WriteLine($"A soma de todos os divisores é igual a {soma}");
//if (x == soma)
//{
//    Console.WriteLine("O número inserido é um número perfeito, poís a soma dos seus divisores é igual ele mesmo");
//}
//else
//{
//    Console.WriteLine("O número inserido não é um número perfeito.");
//}

////Exercicio 10
//int y;
//double alturam, alturah;
//string x;

//Console.WriteLine("Insira seu sexo (Masculino ou Feminino)");
//x = Console.ReadLine();
//x = x.ToLower();
//Console.Write("Insira sua altura em centimentros: ");
//y = int.Parse(Console.ReadLine());

//if (x == "F" || x == "f" || x =="feminino")
//{
//    alturam = y - 100 - (y - 150) / 2.5;
//    Console.WriteLine($"O peso ideal para sua altura e seu sexo é {alturam}kg");
//}
//if (x == "M" || x == "m" || x == "masculino")
//{
//    alturah = y - 100 - (y - 150) / 4;
//    Console.WriteLine($"O peso ideal para sua altura e seu sexo é {alturah}kg");
//}

////Exercicio 11
//int x, y, i;
//double soma = 1;

//Console.WriteLine("Insira o número que você deseja elevar");
//x = int.Parse(Console.ReadLine());
//Console.WriteLine("Insira o número por quanto deseja elevar");
//y = int.Parse(Console.ReadLine());
//for (i = 1; i <= y; i++)
//{
//    soma *= x;
//}
//Console.WriteLine($"A potência do número {x} elevado a {y} é {soma}");

////Exercicio 12
//int x, i, i2;

//Console.WriteLine("Insira o número que você deseja");
//x = int.Parse(Console.ReadLine());

//for (i = 1; i <= x; i++)
//{
//    for (i2 = 1; i2 <= i; i2++)
//    {

//        Console.Write("" + i * i2 + " ");
//    }
//    Console.WriteLine();
//}

////Dia 03/07
////Exercicio 01
//int numatual = 1, i, numanterior=0, proxnum;
//Console.WriteLine("A sequência de fibbonaci até < 100");
//for (i = 1; numatual <= 100; i++)
//{
//    Console.Write("" + numatual + " ");
//    proxnum = numatual + numanterior;
//    numanterior = numatual;
//    numatual = proxnum;

//}

////Exercicio 02
//Console.WriteLine("Digite o valor de N: ");
//int n = int.Parse(Console.ReadLine());
//int i = 1;
//double resultado = 0;

//while (i <= n)
//{
//    resultado += ((Math.Pow(i, 2) + 1) / ((i + 3)));
//    i++;
//}
//Console.WriteLine($"O resultado de S segundo a formula é: {Math.Round(resultado)}");

//Exercicio 03
//Random rnum = new Random();
//double i, y, pessoasMulher = 0, pessoasHomem = 0, somaHomem = 0.00, somaMulher = 0.00, somaAlturaMulher = 0.00, somaAlturaHomem = 0.00, x = rnum.Next(0, 1001);

//Console.WriteLine($"Na região possuí {x} mulheres e {1000 - x} homens");
//for (i = 1; i <= x; i++)
//{
//    y = rnum.Next(144, 201);
//    somaAlturaMulher += y;
//}
//for (i = 1; i <= 1000 - x; i++)
//{
//    y = rnum.Next(159, 211);
//    somaAlturaHomem += y;
//}
//for (i = 1; i <= x; i++)
//{
//    y = rnum.Next(14, 101);
//    somaMulher += y;
//    if (y >= 18 && y <= 35)
//    {
//        pessoasMulher += 1;
//    }
//}
//for (i = 1; i <= 1000 - x; i++)
//{
//    y = rnum.Next(14, 101);
//    somaHomem += y;
//    if (y >= 18 && y <= 35)
//    {
//        pessoasHomem += 1;
//    }
//}
//double mediamulher = somaMulher / x;
//double mediahomem = somaHomem / (1000 - x);
//double mediaAlturaMulher = somaAlturaMulher / x;
//double mediaAlturaHomem = somaAlturaHomem / (1000 - x);
//double somaPessoas = pessoasHomem + pessoasMulher;
//Console.WriteLine($"A soma das alturas de todas as mulheres é {somaAlturaMulher} centímetros");
//Console.WriteLine($"A soma das alturas de todos os homens é {somaAlturaHomem} centímetros");
//Console.WriteLine($"A média das alturas de todas as mulheres é {mediaAlturaMulher} centímetros");
//Console.WriteLine($"A média das alturas de todos os homens é {mediaAlturaHomem} centímetros");
//Console.WriteLine($"A soma das idades de todas as mulheres é {somaMulher}");
//Console.WriteLine($"A média das idades de todas as mulheres é {mediamulher}");
//Console.WriteLine($"A soma das idades de todos os homens é {somaHomem}");
//Console.WriteLine($"A média da idades todos os homens é {mediahomem}");
//Console.WriteLine("A quantidade de mulheres com 18 a 35 anos é " + pessoasMulher);
//Console.WriteLine("A quantidade de homens com 18 a 35 anos é " + pessoasHomem);
//Console.WriteLine("A quantidade total de pessoas entre 18 a 35 anos é " + somaPessoas);
//somaPessoas = somaPessoas / 1000 * 100;
//Console.WriteLine($"A porcentagem de pessoas entre 18 a 35 anos é {somaPessoas}%");

////Exercicio 04
//Random rnum = new Random();
//double i, y = 0, alturamenor = 300, alturamaior = 0, x = 50;
//for (i = 1; i <= x; i++)
//{
//    y = rnum.Next(145, 211);
//    Console.WriteLine(y);
//    if (y < alturamenor)
//    {
//        alturamenor = y;
//    }
//    if (y > alturamaior)
//    {
//        alturamaior = y;
//    }
//}
//Console.WriteLine($"A menor altura é {alturamenor}");
//Console.WriteLine($"A maior altura é {alturamaior}");

////Exercicio 05
//Console.WriteLine("Digite um número: ");
//int i, contador = 0, y = int.Parse(Console.ReadLine());
//for (i = 1; i <= y; i=i)
//{
//    i = i * 10;
//    contador += 1;
//}
//Console.WriteLine($"A quantidade de dígitos é {contador}");

////Exercicio 06
//using System.Data;
//using System.Net;

//double camisa = 50, moleton = 99.99, calca = 70.50, precoCamisa = 0.00, precoCalcas = 0.00, precoMoleton = 0.00, precoTotal = 0.00;
//int quantidadeCamisas = 0, quantidadeMoleton = 0, quantidadeCalcas = 0;
//comeco:
//Console.WriteLine("//--LOJINHA DO TADEU--//\n1 - Camisa - R$50,00\n2 - Moleton - R$99,99\n3 - Calça - R$70,50\n0 - Sair");
//int inserido = int.Parse(Console.ReadLine());
//if (inserido == 0)
//{
//    Console.WriteLine("Você escolheu sair.");
//}
//if (inserido == 1)
//{
//    Console.Write("Insira a quantidade de camisas que você deseja comprar: ");
//quantidade:
//    quantidadeCamisas += int.Parse(Console.ReadLine());
//    if (quantidadeCamisas < 0)
//    {
//        quantidadeCamisas = 0;
//        Console.Write("Você inseriu um valor inválido, insira novamente: ");
//        goto quantidade;
//    }
//    precoCamisa = quantidadeCamisas * camisa;
//    Console.WriteLine("Deseja continuar sua compra? (S/N)");
//    string continuar = Console.ReadLine();
//    continuar = continuar.ToLower();
//    if (continuar == "sim" || continuar == "s" || continuar == "si")
//    {
//        goto comeco;
//    }
//    if (continuar != "sim" || continuar != "s" || continuar == "si")
//    {
//        precoTotal = precoCamisa + precoCalcas + precoMoleton;
//        Console.Write($"O valor gasto com camisas é de R$ {Math.Round(precoCamisa)} \nO valor gasto com moleton é de R$ {Math.Round(precoMoleton)} \nO valor gasto com calças é de R${Math.Round(precoCalcas)}\n");
//        Console.WriteLine("O preço total gasto é de R${0}", precoTotal);
//        if (precoTotal >= 1000)
//        {
//            Console.WriteLine("Você receberá um desconto de 10%");
//            precoTotal *= 0.9;
//            Console.WriteLine($"A compra ficará em um valor de R${precoTotal}");
//        }
//    }
//}
//if (inserido == 2)
//{
//    Console.Write("Insira a quantidade de moleton que você deseja comprar: ");
//quantidade1:
//    quantidadeMoleton += int.Parse(Console.ReadLine());
//    if (quantidadeMoleton < 0)
//    {
//        quantidadeMoleton = 0;
//        Console.Write("Você inseriu um valor inválido, insira novamente: ");
//        goto quantidade1;
//    }
//    precoMoleton = quantidadeMoleton * moleton;
//    Console.WriteLine("Deseja continuar sua compra? (S/N)");
//    string continuar = Console.ReadLine();
//    continuar = continuar.ToLower();
//    if (continuar == "sim" || continuar == "s" || continuar == "si")
//    {
//        goto comeco;
//    }
//    if (continuar != "sim" || continuar != "s" || continuar == "si")
//    {
//        precoTotal = precoCamisa + precoCalcas + precoMoleton;
//        Console.Write($"O valor gasto com camisas é de R$ {Math.Round(precoCamisa)} \nO valor gasto com moleton é de R$ {Math.Round(precoMoleton)} \nO valor gasto com calças é de R${Math.Round(precoCalcas)}\n");
//        Console.WriteLine("O preço total gasto é de R${0}", precoTotal);
//        if (precoTotal >= 1000)
//        {
//            Console.WriteLine("Você receberá um desconto de 10%");
//            precoTotal *= 0.9;
//            Console.WriteLine($"A compra ficará em um valor de R${precoTotal}");
//        }
//    }
//}
//if (inserido == 3)
//{
//    Console.Write("Insira a quantidade de calças que você deseja comprar: ");
//quantidade2:
//    quantidadeCalcas += int.Parse(Console.ReadLine());
//    if (quantidadeCalcas < 0)
//    {
//        quantidadeCalcas = 0;
//        Console.Write("Você inseriu um valor inválido, insira novamente: ");
//        goto quantidade2;
//    }
//    precoCalcas = quantidadeCalcas * calca;
//    Console.WriteLine("Deseja continuar sua compra? (S/N)");
//    string continuar = Console.ReadLine();
//    continuar = continuar.ToLower();
//    if (continuar == "sim" || continuar == "s" || continuar == "si")
//    {
//        goto comeco;
//    }
//    if (continuar != "sim" || continuar != "s" || continuar == "si")
//    {
//        precoTotal = precoCamisa + precoCalcas + precoMoleton;
//        Console.Write($"O valor gasto com camisas é de R$ {Math.Round(precoCamisa)} \nO valor gasto com moleton é de R$ {Math.Round(precoMoleton)} \nO valor gasto com calças é de R${Math.Round(precoCalcas)}\n");
//        Console.WriteLine("O preço total gasto é de R${0}", precoTotal);
//        if (precoTotal >= 1000)
//        {
//            Console.WriteLine("Você receberá um desconto de 10%");
//            precoTotal *= 0.9;
//            Console.WriteLine($"A compra ficará em um valor de R${precoTotal}");
//        }
//    }
//}

//Console.WriteLine("Tem mais de 18 anos?");
//Console.WriteLine("1 - Sim");
//Console.WriteLine("2 - Não");
//int respotas;
//respotas = int.Parse(Console.ReadLine());

//if (respotas == 1)
//{
//    Console.WriteLine("Acesso liberado");
//}
//else if (respotas == 2)
//{
//    Console.WriteLine("Acesso Negado");
//}
//else
//{
//    Console.WriteLine("Valor invalido");
//}

//int resposta = 0;
//while (resposta != 1 || resposta != 2)
//{
//    Console.WriteLine("Tem mais de 18 anos?");
//    Console.WriteLine("1 - Sim");
//    Console.WriteLine("2 - Não");
//    int respostas;
//    respostas = int.Parse(Console.ReadLine());

//    if (respostas == 1)
//    {
//        Console.WriteLine("Acesso liberado");
//        break;
//    }
//    else if (respostas == 2)
//    {
//        Console.WriteLine("Acesso Negado");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Valor invalido");
//        Console.ReadKey();
//        Console.Clear();
//    }
//}

////Criar uma tabuada de 0 a 100 de determinado número

//Console.WriteLine("Digite um número para saber sua tabuada de 0 a 100");
//int num = int.Parse(Console.ReadLine());

////for (int i = 0; i <= 100; i++)
////{
////    Console.WriteLine($"{num} x {i} = {num*i}");
////}

//int i = 0;
//while (i <= 100){
//    Console.WriteLine($"{num} x {i} = {num * i}");
//    i++;
//}

//int contador = 0;
//for (int i = 1; i <= 100000; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        if (i % j == 0)
//        {
//            contador++;
//        }
//    }
//    if (contador < 3)
//    {
//        Console.WriteLine(i);
//    }
//    contador = 0;
//}

////Exercicio 6
//int produto = 0, pagamento = 0;
//int camisa = 0, moleton = 0, calca = 0;
//double carrinho = 0;
//while (produto != 0)
//{
//    Console.WriteLine("=====Lojinha da Ju <3===== \n 1 - Camisa = R$50,00 \n 2 - Moleton - R$99,99 \n 3 - Calça R$70,50 \n 0 - Sair");
//    Console.WriteLine("Escolha uma opção");

//    if (produto == 1)
//    {
//        Console.WriteLine("Quantidade: ");
//        camisa = int.Parse(Console.ReadLine());
//        carrinho = camisa * 50;
//        Console.Clear();
//    }
//    else if (produto == 2)
//    {
//        Console.WriteLine("Quantidade: ");
//        moleton = int.Parse(Console.ReadLine());
//        carrinho = camisa * 99.99;
//        Console.Clear();
//    }
//    else if (produto == 3)
//    {
//        Console.WriteLine("Quantidade: ");
//        calca = int.Parse(Console.ReadLine());
//        carrinho = calca * 70.50;
//        Console.Clear();
//    }
//    else if (produto == 0)
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Digite uma opção valida!");
//        Console.ReadKey();
//        Console.Clear();
//    }
//}

//if (carrinho > 1000) carrinho *= 0.9;

//while (pagamento != 1 || pagamento != 2 || pagamento != 3 || pagamento != 4)
//    {
//    Console.WriteLine("//Selecione a forma de pagamento:\r\n //1-PIX \r\n//2-Crédito\r\n//3-Debito\r\n//4-Em especie");
//    pagamento = int.Parse(Console.ReadLine());
//    if (pagamento == 1)
//    {
//        Console.WriteLine("Pagamento em Pix");
//        break;
//    }
//     else if (pagamento == 2)
//    {
//        Console.WriteLine("Pagamento no Credito");
//        break;
//    }
//   else if (pagamento == 3)
//    {
//        Console.WriteLine("Pagamento no Debito");
//        break;
//    }
//   else if (pagamento == 4)
//    {
//        Console.WriteLine("Pagamento em Especie");
//        Console.WriteLine("Digite o valor inserido para o pagamento");
//        double valor = double.Parse(Console.ReadLine());
//        if (valor < carrinho)
//        {
//            Console.WriteLine("Digite um valor maior ou escolha outra forma de pagamento!");
//        }
//        else
//        {
//            Console.WriteLine("O Troco é de : R$ {0}", valor - carrinho);
//            break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Escolha uma opção valida");
//        Console.ReadKey();
//        Console.Clear();
//    }
//}

////Exercicio 07
//int i = 0, j = 0, contador = 0, soma = 0;

//while (i != -1)
//{
//    Console.WriteLine("Insira um número");
//    int numero = int.Parse(Console.ReadLine());
//    soma += numero;
//    contador++;
//    while (j != -1)
//    {
//        Console.WriteLine("Deseja continuar?\n1- Sim\n0- Não");
//        int resposta = int.Parse(Console.ReadLine());
//        if (resposta == 1)
//        {
//            Console.Clear();
//            break;
//        }
//        else if (resposta == 0)
//        {
//            Console.WriteLine($"A soma de todos os seus números é {soma}");
//            Console.WriteLine($"A média de todos os seus números é {soma} / {contador} = {soma / contador}");
//            i = -1;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Você inseriu um valor inválido");
//            Console.ReadKey();
//            Console.Clear();
//        }
//    }
//}

////Exercicio 08
//string login = "pedro", password = "123pEdro@", l, p;
//int i = 0, contador = 0, j = 0;
//while (i != -1)
//{
//    contador++;
//    Console.Write("IT Tech\nLogin: ");
//    l = Console.ReadLine();
//    Console.Write("Password: ");
//    p = Console.ReadLine();
//    if (l == login && p == password)
//    {
//        Console.WriteLine($"Bem vindo {login}, acesso liberado.");
//        i = -1; break;
//    }
//    else if (contador == 3)
//    {
//        Console.WriteLine("Você errou sua senha muitas vezes, acesso bloqueado.");
//        while (j != -1)
//        {
//            Console.WriteLine("Acesso bloqueado.");
//            Console.ReadKey();
//            Console.Clear();
//        }

//    }
//    Console.WriteLine($"Senha incorreta, {3 - contador} tentativas restantes.");
//    Console.ReadKey();
//    Console.Clear();
//}

////Exercicio 09
//int i, num, num2;

//Console.Write("Insira o primeiro número: ");
//num = int.Parse(Console.ReadLine());
//Console.Write("Insira o segundo número: ");
//num2 = int.Parse(Console.ReadLine());

//while (num > num2)
//{
//    Console.WriteLine("O primeiro número inserido é menor que o segundo número, por favor insira novamente ambos os números.");
//    Console.ReadKey();
//    Console.Clear();
//    Console.Write("Insira o primeiro número: ");
//    num = int.Parse(Console.ReadLine());
//    Console.Write("Insira o segundo número: ");
//    num2 = int.Parse(Console.ReadLine());
//}

//Console.Write($"Os números entre {num} e {num2} é: ");

//for (i = 1; num < num2 - 1;)
//{
//    num += i;
//    Console.Write("{0} ", num);
//}

////Exercicio 10
//int i, somaIdades = 0;
//Random randomNum = new Random();
//int pessoas = randomNum.Next(0, 51);
//Console.WriteLine($"A quantidade de pessoas na turma é {pessoas}");

//for (i = 1; i <= pessoas; i++)
//{
//    int idades = randomNum.Next(1, 101);
//    somaIdades+= idades;
//    //Console.WriteLine(idades);

//}

//int media = somaIdades / pessoas;
//Console.WriteLine($"A soma de todas as idades é {somaIdades}");
//Console.WriteLine($"A média de todas as idades é {media}");

//if (media < 26)
//{
//    Console.WriteLine("Como a média da turma é entre 0 e 25 anos, a turma é jovem.");
//}
//if (media > 25 && media < 66)
//{
//    Console.WriteLine("Como a média da turma esta entre 26 e 65 anos, a turma é adulta.");
//}
//if (media > 65)
//{
//    Console.WriteLine("Como a média da turma é maior que 65 anos, a turma é idosa.");
//}

////Exercicio 11

//Console.Write("Qual será o valor do empréstimo: ");
//double emprestimo = double.Parse(Console.ReadLine());
//Console.WriteLine("Em quantas vezes deseja parcelar?");
//int parcelas = int.Parse(Console.ReadLine());
//double juros = 1.5 / 100;
//double valoremprestimo = emprestimo / parcelas;
////Console.WriteLine($" O valor de cada parcela seria {valoremprestimo} por mês sem o juros.");
//Console.WriteLine($" O valor de cada parcela com o juros é {valoremprestimo + (emprestimo * juros)} por mes.");
////Console.WriteLine((valoremprestimo + (emprestimo * juros)) * parcelas);

////Exercicio 12
//int num = 0, total = 0, g1 = 0, g2 = 0, g3 = 0, g4 = 0;
//while (num >= 0)
//{
//    Console.WriteLine("Digite um numero:de 0 a 100");
//    Console.WriteLine("Digite um numero negativo para sair");
//    num = int.Parse(Console.ReadLine());
//    total++;

//    if (num >= 0 && num < 26)
//    {
//        g1++;
//        Console.Clear();
//    }
//    else if (num > 25 && num < 51)
//    {
//        g2++;
//        Console.Clear();
//    }
//    else if (num > 50 && num < 76)
//    {
//        g3++;
//        Console.Clear();
//    }
//    else if (num > 75 && num < 101)
//    {
//        g4++;
//        Console.Clear();
//    }
//    else if (num > 100)
//    {
//        Console.WriteLine("Digite um numero valido");
//    }
//    else
//    {
//        Console.WriteLine("Contagem finalizada");
//    }
//}

//Console.WriteLine("Foram cadastrados um total de {0} numeros", total);
//Console.WriteLine("");
//Console.WriteLine("Total do grupo de [0-25] foi de {0}", g1);
//Console.WriteLine("");
//for (int i = 0; i <= g1; i++)
//{
//    Console.Write("▬");
//}
//Console.WriteLine("");
//Console.WriteLine("Total do grupo de [26-50] foi de {0}", g2);
//Console.WriteLine("");
//for (int i = 0; i <= g2; i++)
//{
//    Console.Write("▬");
//}
//Console.WriteLine("");
//Console.WriteLine("Total do grupo de [51-75] foi de {0}", g3);
//Console.WriteLine("");
//for (int i = 0; i <= g3; i++)
//{
//    Console.Write("▬");
//}
//Console.WriteLine("");
//Console.WriteLine("Total do grupo de [75-100] foi de {0}", g4);
//Console.WriteLine("");
//for (int i = 0; i <= g4; i++)
//{
//    Console.Write("▬");
//}
//Console.WriteLine("");

////Exercicio 13

//Console.WriteLine("Digite o valor de N: ");
//double n = double.Parse(Console.ReadLine());
//double i = 1;
//double j = 1;
//double resultado = 0;

//while (i <= n)
//{
//    Console.WriteLine($"{i} / {j}");
//    resultado += (i / j);
//    i++;
//    j += 2;
//    Console.WriteLine(Math.Round(resultado, 4));
//}
//Console.WriteLine($"O resultado de N segundo a formula é: {Math.Round(resultado, 2)}");

////Exercicio 14

//int i, soma = 0;

//Console.Write("Insira a quantidade de turmas: ");
//int turma = int.Parse(Console.ReadLine());

//for (i = 1; i <= turma; i++)
//{
//    Console.Write($"Insira a quantidade de alunos na {i}° turma: ");
//    int aluno = int.Parse(Console.ReadLine());
//    while (aluno > 40 || aluno < 0)
//    {
//        Console.Write("A quantidade inserida de alunos excede o limite de cada turma, insira novamente a quantidade de alunos: ");
//        aluno = int.Parse(Console.ReadLine());
//        Console.Clear();
//    }
//    soma += aluno;
//    Console.Clear();

//}
//int media = soma / turma;
//Console.WriteLine($"A soma total de alunos é {soma}.");
//Console.WriteLine($"A média dos alunos é {media}.");

////Dia 24/07
////Exercicio 01

//string[] nomes = new string[10]; 
//int[] alturas = new int[10];
//int[] numeros = new int[10];
//int somaImpar = 0, somaPar = 0, mediaPar, mediaImpar, contador = 0;

//for (int i = 1; i <= 4; i++)
//{
//    Console.Write("Digite o seu nome: ");
//    nomes[i] = Console.ReadLine();
//    Console.Write("Digite sua altura em centimetros: ");
//    alturas[i] = int.Parse(Console.ReadLine());
//    numeros[i] = i;
//    Console.Clear();
//    contador++;

//}

//Console.WriteLine("Os times impares são");
//for (int i = 1; i <= 4; i++)
//{
//    if (i % 2 == 1)
//    {
//        Console.Write($"{numeros[i]} - {nomes[i]} com {alturas[i]}cm\n");
//    }
//}

//Console.WriteLine("\nOs times pares são");
//for (int i = 1; i <= 4; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.Write($"{numeros[i]} - {nomes[i]} com {alturas[i]}cm\n");
//    }
//}

//for (int i = 1; i <= 4; i++)
//{
//    if (i % 2 == 1)
//    {
//        somaImpar += alturas[i];
//    }
//    if (i % 2 == 0)
//    {
//        somaPar += alturas[i];
//    }
//}

//mediaImpar = somaImpar / (contador / 2);
//mediaPar = somaPar / (contador / 2);
//if (mediaPar > mediaImpar)
//{
//    Console.WriteLine($"O time com a maior altura média é o time par.");
//}
//else if (mediaImpar > mediaPar)
//{
//    Console.WriteLine("O time com a maior altura média é o time impar.");
//}
//else
//{
//    Console.WriteLine("Ambos os times possuem a mesma altura média.");
//}


//Console.WriteLine(somaImpar);
//Console.WriteLine(somaPar);
//Console.WriteLine(mediaPar);
//Console.WriteLine(mediaImpar);
//Console.ReadKey();
//Console.Clear();
//Console.ReadKey();


////Exercicio 02
////ChatGPT
//Console.Write("Digite o primeiro número inteiro:");
//int numero1 = int.Parse(Console.ReadLine());
//Console.Write("Digite o segundo número inteiro:");
//int numero2 = int.Parse(Console.ReadLine());
//int mmc = CalcularMMC(numero1, numero2);
//int mdc = CalcularMDC(numero1, numero2);
//Console.WriteLine($"MMC entre {numero1} e {numero2}: {mmc}");
//Console.WriteLine($"MDC entre {numero1} e {numero2}: {mdc}");
//static int CalcularMMC(int a, int b)
//{
//    int mdc = CalcularMDC(a, b);
//    return Math.Abs(a * b) / mdc;
//}
//static int CalcularMDC(int a, int b)
//{
//    while (b != 0)
//    {
//        int temp = b;
//        b = a % b;
//        a = temp;
//    }
//    return a;
//}

////Exercicio 03

//Console.WriteLine("Insira o primeiro valor: ");
//double valor1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Insira qual é o porcentual desse valor: ");
//double porcentual1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Você deseja descobrir o valor porcentual ou o valor númerico? (N/P)");
//string resposta = Console.ReadLine().ToLower();

//switch (resposta)
//{
//    case "n":
//        Console.WriteLine("Insira o proximo valor porcentual: ");
//        double porcentual2 = double.Parse(Console.ReadLine());
//        Console.WriteLine($"A sua formula ficou assim\n{valor1} = {porcentual1}%\nx = {porcentual2}%");
//        double valorinicial = valor1 * porcentual2;
//        double valorf = valorinicial / porcentual1;
//        Console.WriteLine($"O resultado da sua formula\n{valor1} = {porcentual1}%\n{valorf} = {porcentual2}%");
//        break;

//    case "p":
//        Console.WriteLine("Insira qual é o próximo valor númerico: ");
//        double valor2 = double.Parse(Console.ReadLine());
//        Console.WriteLine($"A sua formula ficou assim\n{valor1} = {porcentual1}%\n{valor2} = x%");
//        double valorip = valor2 * porcentual1;
//        double valorfp = valorip / valor1;
//        Console.WriteLine($"O resultado da sua formula\n{valor1} = {porcentual1}%\n{valor2} = {valorfp}%");
//        break;
//}

////Exercicio 04
//Console.WriteLine("Insira sua altura (m)");
//double altura = double.Parse(Console.ReadLine());
//Console.WriteLine("Insira seu peso (kg)");
//double peso = double.Parse(Console.ReadLine());

//double imc = peso / Math.Pow(altura, 2);
//Console.WriteLine(imc);

//if (altura >= 1.60 && altura <= 1.70)
//{
//    if (imc > 14 && imc < 18)
//    {
//        Console.WriteLine("Seu IMC está muito baixo, categoria magro.");
//    }
//    if (imc > 17 && imc < 25)
//    {
//        Console.WriteLine("Seu IMC está ideal, categoria saudável.");
//    }
//    if (imc > 24 && imc < 30)
//    {
//        Console.WriteLine("Seu IMC está acima do ideal, categoria gordo.");
//    }
//    if (imc > 29 && imc < 35)
//    {
//        Console.WriteLine("Seu IMC está alto, categoria obeso.");
//    }
//    if (imc > 34)
//    {
//        Console.WriteLine("Seu IMC está muito alto, categoria obesidade morbida.");
//    }
//}

//if (altura >= 1.70 && altura <= 1.80)
//{
//    if (imc > 13 && imc < 19)
//    {
//        Console.WriteLine("Seu IMC está muito baixo, categoria magro.");
//    }
//    if (imc > 18 && imc < 25)
//    {
//        Console.WriteLine("Seu IMC está ideal, categoria saudável.");
//    }
//    if (imc > 24 && imc < 30)
//    {
//        Console.WriteLine("Seu IMC está acima do ideal, categoria gordo.");
//    }
//    if (imc > 29 && imc < 34)
//    {
//        Console.WriteLine("Seu IMC está alto, categoria obeso.");
//    }
//    if (imc > 34)
//    {
//        Console.WriteLine("Seu IMC está muito alto, categoria obesidade morbida.");
//    }
//}

//if (altura >= 1.80 && altura <= 1.90)
//{
//    if (imc > 11 && imc < 19)
//    {
//        Console.WriteLine("Seu IMC está muito baixo, categoria magro.");
//    }
//    if (imc > 17 && imc < 25)
//    {
//        Console.WriteLine("Seu IMC está ideal, categoria saudável.");
//    }
//    if (imc > 24 && imc < 28)
//    {
//        Console.WriteLine("Seu IMC está acima do ideal, categoria gordo.");
//    }
//    if (imc > 27 && imc < 30)
//    {
//        Console.WriteLine("Seu IMC está alto, categoria obeso.");
//    }
//    if (imc > 30)
//    {
//        Console.WriteLine("Seu IMC está muito alto, categoria obesidade morbida.");
//    }
//}

////Exercicio 05

//int salario;

//Console.Write("Digite o salario do funcionario:");
//salario = int.Parse(Console.ReadLine());

//if (salario <= 1320)
//{
//    Console.WriteLine("Salario com ajuste ficou {0}", salario * 0.10 + salario);
//}
//else if (salario <= 2640)
//{
//    Console.WriteLine($"Salario com ajuste ficou {salario * 0.08 + salario}");
//}
//else if (salario >= 3960)
//{
//    Console.WriteLine($"Salario com ajuste ficou {salario * 0.05 + salario}");
//}

////Exercicio 6 extra 

//Console.WriteLine("▒▒▒▒▒▒▒▒▒▄▄▄▄▒▒▒▒▒▒▒\r\n▒▒▒▒▒▒▄▀▀▓▓▓▀█▒▒▒▒▒▒\r\n▒▒▒▒▄▀▓▓▄██████▄▒▒▒▒\r\n▒▒▒▄█▄█▀░░▄░▄░█▀▒▒▒▒\r\n▒▒▄▀░██▄░░▀░▀░▀▄▒▒▒▒\r\n▒▒▀▄░░▀░▄█▄▄░░▄█▄▒▒▒\r\n▒▒▒▒▀█▄▄░░▀▀▀█▀▒▒▒▒▒\r\n▒▒▒▄▀▓▓▓▀██▀▀█▄▀▀▄▒▒\r\n▒▒█▓▓▄▀▀▀▄█▄▓▓▀█░█▒▒\r\n▒▒▀▄█░░░░░█▀▀▄▄▀█▒▒▒\r\n▒▒▒▄▀▀▄▄▄██▄▄█▀▓▓█▒▒\r\n▒▒█▀▓█████████▓▓▓█▒▒\r\n▒▒█▓▓██▀▀▀▒▒▒▀▄▄█▀▒▒\r\n▒▒▒▀▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");

//Console.WriteLine("██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██            ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▓▓▒▒▒▒▒▒░░                                                    \r\n██              ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓                                                      \r\n██              ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒                                          \r\n██              ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░▓▓▓▓▒▒▒▒▓▓▓▓▓▓              ░░░░░░░░░░                  \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒        ░░░░            ░░░░░░░░░░░░░░░░              \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▒▒░░░░░░██▒▒░░░░░░░░  ░░          ░░░░░░░░░░░░░░░░░░              \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░░░░░░░░░██▒▒░░░░░░    ░░          ░░░░░░░░░░░░░░░░░░░░            \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░░░░░░░░░██▒▒░░░░    ░░░░          ░░░░░░░░░░░░░░░░░░░░            \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓░░▒▒  ██▒▒░░    ░░░░░░          ░░          ░░░░░░░░            \r\n██              ▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒░░░░░░▓▓██▒▒    ░░░░░░░░            ░░      ░░  ░░░░░░            \r\n██              ▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▓▓░░░░▒▒▓▓▓▓▒▒  ░░░░░░░░░░            ░░          ░░░░░░            \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░░░  ▒▒                ░░░░      ░░              \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒░░░░░░▓▓▓▓▓▓░░░░░░    ░░              ░░░░░░░░    ░░              \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░░░░░░░  ██▒▒░░░░    ░░░░                                          \r\n██              ▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▓▓▓▓▓▓░░██▒▒▓▓▓▓▓▓▓▓▓▓▓▓                                          \r\n██              ▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▓▓▒▒▓▓░░██▓▓▒▒▒▒▒▒▒▒▒▒▓▓            ░░░░░░░░░░░░░░                \r\n██              ▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▓▓░░▓▓░░██▓▓▒▒▒▒▒▒▒▒▓▓▒▒            ░░░░░░░░░░░░░░                \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓░░▓▓░░██▓▓▒▒▓▓▓▓▒▒▒▒▒▒            ░░░░░░░░░░░░░░░░              \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▓▓▒▒██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒            ░░░░░░░░░░░░░░░░              \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▓▓▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒            ░░░░░░░░░░░░░░░░              \r\n██              ▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒              ░░░░░░░░░░░░                \r\n██              ▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▓▓▓▓██▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒              ░░░░    ░░░░                \r\n██              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒              ░░░░      ░░                \r\n██              ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓                        ░░░░░░      ░░░░              \r\n██              ▒▒▓▓░░    ░░░░      ░░  ▓▓▓▓░░                        ░░░░░░      ░░░░              \r\n██            ░░▒▒▓▓░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░░░░░  ░░  ░░  ░░░░░░░░░░░░░░░░░░░░░░          \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n██                                                                                                  \r\n");



//Exemplo switch case:

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Escolha uma opção:");
//        Console.WriteLine("1 - Opção 1");
//        Console.WriteLine("2 - Opção 2");
//        Console.WriteLine("3 - Opção 3");
//        Console.WriteLine("4 - Opção 4");
//        Console.WriteLine("5 - Opção 5");
//        Console.Write("Digite o número da opção desejada: ");

//        int escolha = int.Parse(Console.ReadLine());

//        switch (escolha)
//        {
//            case 1:
//                Console.WriteLine("Você escolheu a Opção 1.");
//                break;

//            case 2:
//                Console.WriteLine("Você escolheu a Opção 2.");
//                break;

//            case 3:
//                Console.WriteLine("Você escolheu a Opção 3.");
//                break;

//            case 4:
//                Console.WriteLine("Você escolheu a Opção 4.");
//                break;

//            case 5:
//                Console.WriteLine("Você escolheu a Opção 5.");
//                break;

//            default:
//                Console.WriteLine("Opção inválida. Por favor, escolha um número válido.");
//                break;
//        }
//    }
//}


////ex 2 :

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Digite a nota: ");
//        double nota = double.Parse(Console.ReadLine());

//        switch (nota)
//        {
//            case double n when (n < 5):
//                Console.WriteLine("Reprovado");
//                break;
//            case double n when (n >= 5 && n <=10):
//                Console.WriteLine("Aprovado");
//                break;
//            default:
//                Console.WriteLine("Nota inválida.");
//                break;
//        }
//    }
//}

////ex 3 :

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Digite a nota (letra - A, B, C, D, E ou F): ");
//        string nota = (Console.ReadLine());
//        nota = nota.ToUpper();

//        switch (nota)
//        {
//            case "A":
//            case "B":
//            case "C":
//                Console.WriteLine("Aprovado");
//                break;
//            case "D":
//            case "E":
//            case "F":
//                Console.WriteLine("Reprovado");
//                break;
//            default:
//                Console.WriteLine("Nota inválida.");
//                break;
//        }
//    }
//}


////Dia 31/07
////Exercicio 01

//Console.Write("Dia da Semana\nInsira um número de 1 a 7: ");
//int dia = int.Parse(Console.ReadLine());

//switch (dia)
//{
//    case 1:
//        Console.WriteLine("Domingo");
//        break;
//    case 2:
//        Console.WriteLine("Segunda-Feira");
//        break;
//    case 3:
//        Console.WriteLine("Terça-Feira");
//        break;
//    case 4:
//        Console.WriteLine("Quarta-Feira");
//        break;
//    case 5:
//        Console.WriteLine("Quinta-Feira");
//        break;
//    case 6:
//        Console.WriteLine("Sexta-Feira");
//        break;
//    case 7:
//        Console.WriteLine("Sábado");
//        break;
//    default:
//        Console.WriteLine("Você não inseriu um valor valido da semana, insira um valor de 1 a 7");
//        break;
//}

////Exercicio 02

//inicio:;
//int i = 1;
//Console.WriteLine("Calculadora Avançada");
//Console.Write("Insira um número: ");
//double num1 = double.Parse(Console.ReadLine());

//while (i != -1)
//{
//    Console.WriteLine("Escolha uma operação: + | - | * | / | potencia | raiz | C | limpar |");
//    string operacao = Console.ReadLine().ToLower();
//    switch (operacao)
//    {
//        case "+":
//            Console.WriteLine("Você escolheu a opção soma");
//            Console.Write("Insira outro número: ");
//            double num2 = double.Parse(Console.ReadLine());
//            double soma = num1 + num2;
//            Console.WriteLine($"O resultado da sua operação é: {soma}");
//            num1 = soma;
//            break;

//        case "-":
//            Console.WriteLine("Você escolheu a opção menos");
//            Console.Write("Insira outro número: ");
//            num2 = double.Parse(Console.ReadLine());
//            double menos = num1 - num2;
//            Console.WriteLine($"O resultado da sua operação é: {menos}");
//            num1 = menos;
//            break;

//        case "*":
//            Console.WriteLine("Você escolheu a opção multiplicação");
//            Console.Write("Insira outro número: ");
//            num2 = double.Parse(Console.ReadLine());
//            double multi = num1 * num2;
//            Console.WriteLine($"O resultado da sua operação é: {multi}");
//            num1 = multi;
//            break;

//        case "/":
//            Console.WriteLine("Você escolheu a opção potência");
//            Console.Write("Insira outro número: ");
//            num2 = double.Parse(Console.ReadLine());
//            double divisao = num1 / num2;
//            Console.WriteLine($"O resultado da sua operação é: {divisao}");
//            num1 = divisao;
//            break;

//        case "potencia":
//            Console.WriteLine("Você escolheu a opção soma");
//            Console.Write("Insira outro número: ");
//            num2 = double.Parse(Console.ReadLine());
//            double potencia = Math.Pow(num1, num2);
//            Console.WriteLine($"O resultado da sua operação é: {potencia}");
//            num1 = potencia;
//            break;

//        case "raiz":
//            Console.WriteLine("Você escolheu a opção raiz");
//            Console.Write("Insira outro número: ");
//            num2 = double.Parse(Console.ReadLine());
//            double raiz = Math.Pow(num1, 1 / num2);
//            Console.WriteLine($"O resultado da sua operação é: {raiz}");
//            num1 = raiz;
//            break;

//        case "c":
//            Console.Clear();
//            break;

//        case "limpar":
//            Console.Clear();
//            num1 = 0;
//            goto inicio;

//        default:
//            Console.WriteLine("Você inseriu um valor inválido");
//            break;

//    }
//}

////Exercicio 03

//int i = 1;
//while (i != -1)
//{
//    Console.WriteLine("Conversor de Unidades");
//    Console.WriteLine("1 - Conversor de Metros\n2 - Conversor de Litros");
//    int resposta = int.Parse(Console.ReadLine());
//    switch (resposta)
//    {
//        case 1:
//            metros:
//            Console.Clear();
//            Console.WriteLine("Conversor de Unidades");
//            Console.Write("Insira um valor em metros: ");
//            double num1 = double.Parse(Console.ReadLine());


//            Console.WriteLine("Escolha uma conversão: km | hm | dam | dm | cm | mm | C (limpar tela)");
//            string medida = Console.ReadLine().ToLower();
//            switch (medida)
//            {
//                case "km":
//                    Console.WriteLine("Você escolheu a opção quilômetro");
//                    num1 = num1 / 1000;
//                    Console.WriteLine($"O resultado da sua operação é: {num1} km");
//                    break;

//                case "hm":
//                    Console.WriteLine("Você escolheu a opção hectómetro");
//                    num1 = num1 / 100;
//                    Console.WriteLine($"O resultado da sua operação é: {num1} hm");
//                    break;

//                case "dam":
//                    Console.WriteLine("Você escolheu a opção decámetro");
//                    num1 = num1 / 10;
//                    Console.WriteLine($"O resultado da sua operação é: {num1} dam");
//                    break;

//                case "dm":
//                    Console.WriteLine("Você escolheu a opção decímetro");
//                    num1 = num1 * 10;
//                    Console.WriteLine($"O resultado da sua operação é: {num1} dm");
//                    break;

//                case "cm":
//                    Console.WriteLine("Você escolheu a opção centímetros");
//                    num1 = num1 * 100;
//                    Console.WriteLine($"O resultado da sua operação é: {num1} cm");
//                    break;

//                case "mm":
//                    Console.WriteLine("Você escolheu a opção milímetros");
//                    num1 = num1 * 1000;
//                    Console.WriteLine($"O resultado da sua operação é: {num1} mm");
//                    break;

//                case "c":
//                    Console.Clear();
//                    break;

//                default:
//                    Console.WriteLine("Você inseriu um valor inválido");
//                    break;

//            }
//            Console.WriteLine("\nDeseja continuar no mesmo conversor de unidade?\n1 - Sim\n2 - Não");
//            int respostaa = int.Parse(Console.ReadLine());
//            switch (respostaa)
//            {
//                case 1:
//                    Console.Clear();
//                    goto metros;
//                case 2:
//                    Console.Clear();
//                    break;
//                default:
//                    Console.WriteLine("Você inseriu um valor inválido");
//                    break;
//            }
//            break;

//        case 2:
//            Console.Clear();
//            litros:
//            Console.WriteLine("Conversor de Unidades");
//            Console.Write("Insira um valor em litros: ");
//            double litros = double.Parse(Console.ReadLine());

//            Console.WriteLine("Escolha uma conversão: kL | hL | dL | decL | cL | mL | C (limpar tela)");
//            string litragem = Console.ReadLine().ToLower();
//            switch (litragem)
//            {
//                case "kl":
//                    Console.WriteLine("Você escolheu a opção kilolitro");
//                    litros = litros / 1000;
//                    Console.WriteLine($"O resultado da sua operação é: {litros} kL");
//                    break;

//                case "hl":
//                    Console.WriteLine("Você escolheu a opção hectolitro");
//                    litros = litros / 100;
//                    Console.WriteLine($"O resultado da sua operação é: {litros} hL");
//                    break;

//                case "dl":
//                    Console.WriteLine("Você escolheu a opção decalitro");
//                    litros = litros / 10;
//                    Console.WriteLine($"O resultado da sua operação é: {litros} dL");
//                    break;

//                case "decl":
//                    Console.WriteLine("Você escolheu a opção decilitro");
//                    litros = litros * 10;
//                    Console.WriteLine($"O resultado da sua operação é: {litros} decL");
//                    break;

//                case "cl":
//                    Console.WriteLine("Você escolheu a opção centilitro");
//                    litros = litros * 100;
//                    Console.WriteLine($"O resultado da sua operação é: {litros} cL");
//                    break;

//                case "ml":
//                    Console.WriteLine("Você escolheu a opção militros");
//                    litros = litros * 1000;
//                    Console.WriteLine($"O resultado da sua operação é: {litros} mL");
//                    break;

//                case "c":
//                    Console.Clear();
//                    break;

//                default:
//                    Console.WriteLine("Você inseriu um valor inválido");
//                    break;

//            }
//            Console.WriteLine("\nDeseja continuar no mesmo conversor de unidade?\n1 - Sim\n2 - Não");
//            int respostaaa = int.Parse(Console.ReadLine());
//            switch (respostaaa)
//            {
//                case 1:
//                    Console.Clear();
//                    goto litros;
//                case 2:
//                    Console.Clear();
//                    break;
//                default:
//                    Console.WriteLine("Você inseriu um valor inválido");
//                    break;
//            }
//            break;

//        default:
//            Console.WriteLine("Você inseriu um valor inválido");
//            break;
//    }  
//}

////Exercicio 04
//Console.WriteLine("Conversor de moedas");
//Console.WriteLine("Câmbio de Moedas");
//Console.WriteLine("Insira uma moeda\n1 - Dolar Americano\n2 - Euro\n3 - Yuan Chines\n4 - Dolar Canadense\n5 - Iene");
//int resposta = int.Parse(Console.ReadLine());
//switch (resposta)
//{
//    case 1:
//        Console.WriteLine("Você escolheu dolár americano\nO dolar hoje (07/08/2023) está 4.90 reais");
//        Console.WriteLine("Insira o valor em dolares: ");
//        double valor = double.Parse(Console.ReadLine());
//        double conversor = valor * 4.90;
//        Console.WriteLine($"Convertendo ${valor} para reais ficará: R${conversor}");
//        break;

//    case 2:
//        Console.WriteLine("Você escolheu euro\nO euro hoje (07/08/2023) está 5.39 reais");
//        Console.WriteLine("Insira o valor em euros: ");
//        double valor2 = double.Parse(Console.ReadLine());
//        double conversor2 = valor2 * 5.39;
//        Console.WriteLine($"Convertendo €{valor2} para reais ficará: R${conversor2}");
//        break;

//    case 3:
//        Console.WriteLine("Você escolheu yuan\nO yuan hoje (07/08/2023) está 0.68 reais");
//        Console.WriteLine("Insira o valor em yuan: ");
//        double valor3 = double.Parse(Console.ReadLine());
//        double conversor3 = valor3 * 0.68;
//        Console.WriteLine($"Convertendo ${valor3} para reais ficará: R${conversor3}");
//        break;

//    case 4:
//        Console.WriteLine("Você escolheu dolar canadense\nO dolar canadense hoje (07/08/2023) está 3.66 reais");
//        Console.WriteLine("Insira o valor em dolares canadense: ");
//        double valor4 = double.Parse(Console.ReadLine());
//        double conversor4 = valor4 * 3.66;
//        Console.WriteLine($"Convertendo ${valor4} para reais ficará: R${conversor4}");
//        break;

//    case 5:
//        Console.WriteLine("Você escolheu yene\nO yene hoje (07/08/2023) está 0.034 reais");
//        Console.WriteLine("Insira o valor em yene: ");
//        double valor5 = double.Parse(Console.ReadLine());
//        double conversor5 = valor5 * 0.034;
//        Console.WriteLine($"Convertendo ${valor5} para reais ficará: R${conversor5}");
//        break;

//    default:
//        Console.WriteLine("Você inseriu um valor inválido");
//        break;
//}

////Exercicio 05

//int i = 1;
//Random rnum = new Random();
//int numero = rnum.Next(1, 101);
//Console.WriteLine("Jogo de adivinhação\nAdivinhe um número de 1 a 100.");

//while (i != -1)
//{
//    Console.Write("Insira seu chute: ");
//    int resposta = int.Parse(Console.ReadLine());


//    switch (resposta)
//    {
//        case int a when (a < numero):
//            Console.WriteLine("Seu chute está baixo.");
//            break;
//        case int a when (a > numero):
//            Console.WriteLine("Seu chute está alto.");
//            break;
//        case int a when (a == numero):
//            Console.WriteLine("Parabéns você acertou o número aleátorio");
//            i = -1;
//            Console.ReadKey();
//            Console.Clear();
//            break;
//    }
//}

////Exercicio 06
//Console.WriteLine("Insira o valor total em reais da compra: ");
//double compra = double.Parse(Console.ReadLine());
//Console.WriteLine("Como será feito a forma de pagamento?\n1 - A vista\n2 - A prazo");
//int resposta = int.Parse(Console.ReadLine());

//switch (resposta)
//{
//    case 1:
//        compra = compra - compra * 0.05;
//        Console.WriteLine($"Por ter escolhido pagamento à vista receberá um desconto de 5%\nO valor total da compra ficará {compra} reais");
//        break;

//    case 2:
//        Console.Write("Insira a quantidade de parcelas: ");
//        double parcelas = double.Parse(Console.ReadLine());
//        compra = compra / parcelas;
//        double juros = 2 * parcelas / 100;
//        double compratotal = compra + compra * juros;
//        Console.WriteLine($"O valor de cada parcela é {compratotal}\nO valor total da compra é de {compratotal * parcelas} reais");
//        break;

//    default:
//        Console.WriteLine("Você inseriu um valor inválido");
//        break;
//}

////Exercicio 07
//int tempo = 0;
//Console.WriteLine("Para qual local você deseja viajar?\n1 - São Paulo (S)\n2 - Rio de Janeiro (RJ)");
//string resposta = Console.ReadLine().ToLower();



//switch (resposta)
//{
//    case "s":
//        Console.WriteLine("Qual o meio de transporte?\n1 - Avião (A)\n2 - Carro (B)\n3 - Ônibus (C)");
//        string resposta2 = Console.ReadLine().ToLower();
//        switch (resposta2)
//        {
//            case "a":
//                Console.WriteLine("Para um viagem de avião até São Paulo levará 56 minutos");
//                tempo = 56;
//                break;
//            case "b":
//                Console.WriteLine("Para um viagem de carro até São Paulo levará 200 minutos");
//                tempo = 200;
//                break;
//            case "c":
//                Console.WriteLine("Para um viagem de ônibus até São Paulo levará 270 minutos");
//                tempo = 270;
//                break;

//                default:
//                Console.WriteLine("Valor inválido, insira somente (A | B | C)");
//                break;
//        }
//        break;
//    case "rj":
//        Console.WriteLine("Qual o meio de transporte?\n1 - Avião (A)\n2 - Carro (B)\n3 - Ônibus (C)");
//        string resposta3 = Console.ReadLine().ToLower();
//        switch (resposta3)
//        {
//            case "a":
//                Console.WriteLine("Para um viagem de avião até Rio de Janeiro levará 70 minutos");
//                tempo = 70;
//                break;
//            case "b":
//                Console.WriteLine("Para um viagem de carro até Rio de Janeiro levará 540 minutos");
//                tempo = 540;
//                break;
//            case "c":
//                Console.WriteLine("Para um viagem de ônibus até Rio de Janeiro levará 630 minutos");
//                tempo = 630;
//                break;

//            default:
//                Console.WriteLine("Valor inválido, insira somente (A | B | C)");
//                break;
//        }
//        break;
//    default:
//        Console.WriteLine("Valor inválido, insira somente (S ou RJ)");
//        break;

//}
//if (tempo > 0 && tempo <= 120)
//{
//    Console.WriteLine("A viagem será curta !.");
//}
//else if (tempo > 121 && tempo < 241)
//{
//    Console.WriteLine("A viagem será em tempo medio.");
//}
//else if (tempo > 240)
//{
//    Console.WriteLine("A viagem será longa.");
//}

////Exercicio 8
//Console.Write("Digite a data no formato (dd/mm/aaaa): ");
//string DataCompleta = Console.ReadLine();

//string[] DataPartes = DataCompleta.Split('/');

//if (DataPartes.Length == 3)
//{
//    // Converter as partes em inteiros
//    int dia = int.Parse(DataPartes[0]);
//    int mes = int.Parse(DataPartes[1]);
//    int ano = int.Parse(DataPartes[2]);

//    if (dia == 31)
//    {
//        switch (mes)
//        {
//            case 1:
//                Console.WriteLine($"O próximo dia é 01/02/{ano}");
//                break;
//            case 3:
//                Console.WriteLine($"O próximo dia é 01/04/{ano}");
//                break;
//            case 4:
//                Console.WriteLine($"Data inválida.");
//                break;
//            case 5:
//                Console.WriteLine($"O próximo dia é 01/06/{ano}");
//                break;
//            case 6:
//                Console.WriteLine($"Data inválida.");
//                break;
//            case 7:
//                Console.WriteLine($"O próximo dia é 01/08/{ano}");
//                break;
//            case 8:
//                Console.WriteLine($"O próximo dia é 01/09/{ano}");
//                break;
//            case 9:
//                Console.WriteLine($"Data inválida.");
//                break;
//            case 10:
//                Console.WriteLine($"O próximo dia é 01/11/{ano}");
//                break;
//            case 11:
//                Console.WriteLine($"Data inválida.");
//                break;
//            case 12:
//                Console.WriteLine($"O próximo dia é 01/01/{ano + 1}");
//                break;
//        }
//    }

//    else if (dia == 30)
//    {
//        switch (mes)
//        {
//            case 1:
//                Console.WriteLine($"O próximo dia é 31/01/{ano}");
//                break;
//            case 3:
//                Console.WriteLine($"O próximo dia é 31/03/{ano}");
//                break;
//            case 4:
//                Console.WriteLine($"O próximo dia é 01/05/{ano}");
//                break;
//            case 5:
//                Console.WriteLine($"O próximo dia é 31/05/{ano}");
//                break;
//            case 6:
//                Console.WriteLine($"O próximo dia é 01/07/{ano}");
//                break;
//            case 7:
//                Console.WriteLine($"O próximo dia é 31/07/{ano}");
//                break;
//            case 8:
//                Console.WriteLine($"O próximo dia é 31/08/{ano}");
//                break;
//            case 9:
//                Console.WriteLine($"O próximo dia é 01/10/{ano}");
//                break;
//            case 10:
//                Console.WriteLine($"O próximo dia é 31/10/{ano}");
//                break;
//            case 11:
//                Console.WriteLine($"O próximo dia é 01/12/{ano}");
//                break;
//            case 12:
//                Console.WriteLine($"O próximo dia é 31/12/{ano}");
//                break;
//        }
//    }

//    else if (mes == 2)
//    {
//        switch (dia)
//        {
//            case 28:
//                Console.WriteLine($"O próximo dia é 01/03/{ano}");
//                break;
//            case int a when (a > 28):
//                Console.WriteLine("O dia inserido é inválido");
//                break;
//            case int a when (a < 28):
//                Console.WriteLine($"O próximo dia é {a + 1}/{mes}/{ano}");
//                break;
//        }
//    }
//    else if (dia < 30)
//    {
//        Console.WriteLine($"O próximo dia é {dia + 1}/{mes}/{ano}");
//    }
//}
//else
//{
//    Console.WriteLine("Formato de data inválido. Use o formato (dd/mm/aaaa)");
//}

///// Dia 07/08/2023
////Exercicio 01

//int[] numeros = new int [10];

//for (int i = 0; i < 10; i++)
//{
//    numeros[i] = i + 1;
//    Console.WriteLine($"{numeros[i]}");
//}
//for (int i = 0; i < 10; i++)
//{
//    numeros[i] = i + 1;
//    Console.WriteLine($"{numeros[9-i]}");
//}


////Exercicio 02

//int[] numeros = new int[10];
//int valormaior = -1000000000, valormenor = 1000000000;
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Insira um valor:");
//    numeros[i] = int.Parse(Console.ReadLine());
//    Console.Clear();

//}
//foreach (int num in numeros)
//{
//    if (num < valormenor )
//    {
//        valormenor = num;
//    }
//    else if (num > valormaior)
//    {
//        valormaior= num;
//    }
//}
//Console.WriteLine($"O menor valor é {valormenor} e o Maior valor é {valormaior}");

////Exercicio 03
//using System;

//int posicao = 0;
//double valormaior = -10000;
//Random random = new Random();
//double[] numeros = new double[100];
//int i;
//for (i = 0; i < numeros.Length; i++)
//{
//    numeros[i] = random.Next();
//    Console.WriteLine(numeros[i]);
//    if (numeros[i] > valormaior)
//    {
//        valormaior = numeros[i];
//        posicao = i;
//    }
//}
//Console.WriteLine($"O valor maior é {valormaior} e está na posição {posicao + 1}°");

////Exercicio 04
//int valor = 0;
//int[] tabela1 = new int[10]; int [] tabela2 = new int[10];
//int[] tabela3 = new int[20];

//for (int i = 0; i < tabela1.Length; i++)
//{
//    Console.WriteLine("Primeira tabela");
//    Console.Write("Insira um número: ");
//    tabela1[i] = int.Parse(Console.ReadLine());
//    Console.Clear();
//}
//for (int i = 0; i < tabela2.Length; i++)
//{
//    Console.WriteLine("Segunda tabela");
//    Console.Write("Insira um número: ");
//    tabela2[i] = int.Parse(Console.ReadLine());
//    Console.Clear();
//}

//for (int i = 0; i < 10; i++)
//{
//    tabela3[valor++] = tabela1[i];
//    tabela3[valor++] = tabela2[i];
//}

//Console.Write("Intercalando as arrays ficará: ");
//foreach (int numeros in tabela3)
//{
//    Console.Write(numeros + " ");
//}

////Exercicio 05

//int valorpar = 0, valorimpar = 0;
//int[] tabela = new int[10];
//int[] tabelapar = new int[tabela.Length/2];
//int[] tabelaimpar = new int[tabela.Length/2];


//for (int i = 0; i < tabela.Length; i++)
//{
//    Console.Write($"Insira o {i+1}° número: ");
//    tabela[i] = int.Parse(Console.ReadLine());
//}

//foreach (int num in tabela)
//{
//    if (num % 2 == 0)
//    { 
//            tabelapar[valorpar++] = num;
//    }
//    else
//    {
//            tabelaimpar[valorimpar++] = num;
//    }
//}

//Console.WriteLine("Os números impares: ");
//foreach (int numero in tabelaimpar)
//{
//    Console.Write(numero + " ");
//}
//Console.WriteLine();

//Console.WriteLine("Os números pares: ");
//foreach (int numero in tabelapar)
//{
//    Console.Write(numero + " ");
//}

////Exercicio 06
//using System;
//using System.Globalization;

//int maiornota = -1, menornota = 11;
//double media = 0;
//int contadormaior = 0, contadormenor = 0, contadornota = 0, contadornotan = 0;
//Random rnum = new Random();
//int[] notas = new int[80];


//for (int i = 0; i < notas.Length; i++)
//{
//    notas[i] = rnum.Next(0, 11);
//    media += notas[i];
//    Console.WriteLine($"p:{i} = {notas[i]}");
//    if (notas[i] > 5)
//    {
//        contadornota++;
//    }
//    if (notas[i] < 6)
//    {
//        contadornotan++;
//    }
//}

//foreach (int numero in notas)
//{
//    if (numero > maiornota)
//    {
//        maiornota = numero;
//    }
//    if (numero < menornota)
//    {
//        menornota = numero;
//    }
//    if (numero == maiornota)
//    {
//        contadormaior++;
//    }
//    if (numero == menornota)
//    {
//        contadormenor++;
//    }
//}
//int max_maior_notas = 0;
//foreach (int num in notas)
//{

//    if (num == maiornota)
//    {
//        max_maior_notas++;
//    }
//}

//int[] posicao = new int[max_maior_notas];
//int j = 0;

//Console.WriteLine();
//for (int i = 0; i < notas.Length; i++)
//{
//    if (notas[i] == maiornota)
//    {
//        posicao[j] = i;
//        j++;
//    }
//}


//Console.WriteLine($"A menor nota é {menornota} com {contadormenor} alunos e a maior nota é {maiornota} com {posicao.Length} alunos");
//Console.WriteLine();
//foreach (int num in posicao)
//{
//    Console.Write(num+ " ");
//}

////Exercicio 07
//int contador = 0;
//Console.WriteLine("Insira uma frase:");
//string frase = Console.ReadLine().ToLower();

//foreach (char vogal in frase)
//{
//    if (vogal == 'a' || vogal == 'e' || vogal == 'i' || vogal == 'o' || vogal == 'u')
//    {
//        contador++;
//    }
//}

//Console.WriteLine();
//Console.WriteLine($"Na sua frase contém {contador} vogais.");

////Exercicio 08
//Console.Write("Digite a data no formato (dd/mm/aaaa): ");
//string DataCompleta = Console.ReadLine();

//string[] DataPartes = DataCompleta.Split('/');

//if (DataPartes.Length == 3)
//{
//    int dia = int.Parse(DataPartes[0]);
//    int mes = int.Parse(DataPartes[1]);
//    int ano = int.Parse(DataPartes[2]);
//    if (dia < 32 || mes < 13)
//    {
//        Console.WriteLine($"A data inserida é dia {dia} do mês {mes} e do ano de {ano}");
//    }
//    else if (dia < 1 || mes < 1)
//    {
//        Console.WriteLine("Data inválida.");
//    }
//    else
//    {
//        Console.WriteLine("Data inválida.");
//    }
//}
//else
//{
//    Console.WriteLine("Formato de data inválido. Use o formato (dd/mm/aaaa)");
//}

////Exercicio 09
//int[] inteiros = new int[10]; int contador = 0;

//for (int i = 0; i < inteiros.Length; i++)
//{
//    Console.Write($"Insira o {i+1}° número: ");
//    inteiros[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine();

//Console.WriteLine("O número que deseja verificar: ");
//int numero = int.Parse(Console.ReadLine());

//foreach (int numeros in inteiros)
//{
//    if (numeros == numero)
//    {
//        contador++;
//    }
//}

//Console.WriteLine($"Após a verificação o número que você inseriu está presente {contador} vezes no array.");

////Exercicio 10
//using System.Collections.Immutable;
//Random rnum = new Random();
//int contador = 0;

//int[] numeros = new int[100];
//int[] array1 = new int[numeros.Length / 5];
//int[] array2 = new int[numeros.Length / 5];
//int[] array3 = new int[numeros.Length / 5];
//int[] array4 = new int[numeros.Length / 5];
//int[] array5 = new int[numeros.Length / 5];


//for (int i = 0; i < numeros.Length; i++)
//{
//    numeros[i] = rnum.Next();
//}
//Array.Sort(numeros);


////foreach (int num in numeros)
////{
////    Console.WriteLine(num);
////}

//for (int i = 0; i < 20; i++)
//{
//    array1[contador++] = numeros[i];
//}
//contador = 0;
//for (int i = 0; i < 20; i++)
//{
//    array2[contador++] = numeros[i];
//}
//contador = 0;
//for (int i = 0; i < 20; i++)
//{
//    array3[contador++] = numeros[i];
//}
//contador = 0;
//for (int i = 0; i < 20; i++)
//{
//    array4[contador++] = numeros[i];
//}
//contador = 0;
//for (int i = 0; i < 20; i++)
//{
//    array5[contador++] = numeros[i];
//}

//foreach (int num in array1)
//{
//    Console.WriteLine($"Os numeros no primeiro array é: {num}");
//}
//foreach (int num in array2)
//{
//    Console.WriteLine($"Os numeros no segundo array é: {num}");
//}
//foreach (int num in array3)
//{
//    Console.WriteLine($"Os numeros no terceiro array é: {num}");
//}
//foreach (int num in array4)
//{
//    Console.WriteLine($"Os numeros no quarto array é: {num}");
//}
//foreach (int num in array5)
//{
//    Console.WriteLine($"Os numeros no quinto array é: {num}");
//}

////Dia 08/08
//Exercicio 01
Console.OutputEncoding = System.Text.Encoding.UTF8;

inicio:
int largura = 0, altura = 0;
Console.WriteLine("Selecione a forma geometrica");
Console.WriteLine("1 - Quadrado | 2 - Losango | 3 - Triângulo | 4 - Quadrilátero | 5 - Trapézio | 6 - Retângulo");
int resposta = int.Parse(s: Console.ReadLine());

switch (resposta)
{
    case 1:
        Console.WriteLine("Insira a altura (linhas)");
        altura = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a largura (linhas)");
        largura = int.Parse(Console.ReadLine());
        Console.Clear();
        if (altura != largura)
        {
            Console.WriteLine("Para ser um quadrado a altura e a largura deve haver a mesma quantidade de linhas");
        }
        else
        {
            Console.Write(" ");
            for (int i = 0; i < largura; i++)
            {
                Console.Write("__");
            }
            Console.WriteLine();
            for (int i = 0; i < altura; i++)
            {
                Console.Write("|");
                for (int j = 0; j < largura; j++)
                {
                    Console.Write("  ");
                }
                Console.Write("|\n");
            }
            Console.Write(" ");
            for (int i = 0; i < largura; i++)
            {
                Console.Write("--");
            }
        }
        break;

    case 2:
        Console.WriteLine("Insira a altura (linhas)");
        altura = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a largura (linhas)");
        largura = int.Parse(Console.ReadLine());
        break;

    case 3:
        Console.WriteLine("Insira a altura (linhas)");
        altura = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a largura (linhas)");
        largura = int.Parse(Console.ReadLine());
        break;

    case 4:
        Console.WriteLine("Insira a altura (linhas)");
        altura = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a largura (linhas)");
        largura = int.Parse(Console.ReadLine());
        break;

    case 5:
        Console.WriteLine("Insira a altura (linhas)");
        altura = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a largura (linhas)");
        largura = int.Parse(Console.ReadLine());
        break;

    case 6:
        Console.WriteLine("Insira a altura (linhas)");
        altura = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a largura (linhas)");
        largura = int.Parse(Console.ReadLine());
        break;

    default:
        Console.WriteLine("Por favor insira um valor de 1 a 6.");
        Console.ReadKey();
        Console.Clear();
        goto inicio;
}


////Exemplo array (14/08)
//Random rnum = new Random();
//int[,] mult = new int[5, 4]; // Linha x Coluna

//for (int i = 0; i < mult.GetLength(0); i++)
//{
//    for (int j = 0; j < mult.GetLength(1); j++)
//    {
//        mult[i, j] = rnum.Next(0, 10);
//        Console.Write($"{mult[i, j],3}");
//    }
//    Console.WriteLine("");
//}

//////Jagged Array
//int[][] jarray = new int[3][];

//jarray[0] = new int[] { 1, 2, 3 };
//jarray[1] = new int[] { 4, 6, 7, 8, 9 };
//jarray[2] = new int[] { 10, 11, 12, 13, 14, 15, 16 };

//for (int i = 0; i < jarray.Length; i++)
//{
//    for (int j = 0; j < jarray[i].Length; j++)
//    {
//        Console.Write(jarray[i][j]);
//    }
//    Console.WriteLine();
//}
