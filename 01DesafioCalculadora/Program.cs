while (true)
{
    Console.WriteLine("\t\t\t\t##--- Calculadora ---##\n");
    Console.WriteLine("Digite a operação desejada:\n");
    Console.Write("1-SOMAR    2-SUBTRAIR    3-MULTIPLICAR    4-DIVIDIR    5-POTENCIAÇÃO    0-SAIR\n");

    int operacao = int.Parse(Console.ReadLine());

    if (operacao == 0)
    {
        Console.WriteLine("\t\t\t\t---- FIM ----");
        break;
    }


    double resultado = 0;


    switch (operacao)
    {
        case 1:
            resultado = Somar();
            break;
        case 2:
            resultado = Subtrair();
            break;
        case 3:
            resultado = Multiplicar();
            break;
        case 4:
            ResultadoDivisao resultadoDivisao = Dividir();
            Console.WriteLine("Resultado = " + resultadoDivisao.Quociente + ", Resto = " + resultadoDivisao.Resto);
            Console.WriteLine();
            continue;
        case 5:
            resultado = Potenciacao();
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.\n");
            continue;
    }

    Console.WriteLine("Resultado: " + resultado);
}

Console.ReadKey();


static double LerNumero()
{
    Console.WriteLine("Digite um número:");
    return double.Parse(Console.ReadLine());
}

static double Somar()
{
    double num1 = LerNumero();
    double num2 = LerNumero();
    return num1 + num2;
}

static double Subtrair()
{
    double num1 = LerNumero();
    double num2 = LerNumero();
    return num1 - num2;
}

static double Multiplicar()
{
    double num1 = LerNumero();
    double num2 = LerNumero();
    return num1 * num2;
}

static ResultadoDivisao Dividir()
{
    double num1 = LerNumero();
    double num2 = LerNumero();

    if (num2 == 0)
    {
        Console.WriteLine("Não é possível dividir por zero.\n");
        return new ResultadoDivisao();
    }

    double quociente = num1 / num2;
    double resto = num1 % num2;

    ResultadoDivisao resultadoDivisao;
    resultadoDivisao.Quociente = quociente;
    resultadoDivisao.Resto = resto;

    return resultadoDivisao;
}

static double Potenciacao()
{
    double baseNum = LerNumero();
    double expoente = LerNumero();
    return Math.Pow(baseNum, expoente);
}
struct ResultadoDivisao
{
    public double Quociente;
    public double Resto;
}

