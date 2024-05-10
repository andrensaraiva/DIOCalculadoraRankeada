int vitoria, derrota, saldo;

Console.WriteLine("Digite a quantidade de VITORIAS do Herói");
vitoria = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de DERROTAS do Herói");
derrota = int.Parse(Console.ReadLine());

CalcularRank(vitoria, derrota);

void CalcularRank(int vit, int der)
{
    saldo = vitoria - derrota;

    if (saldo < 10)
    {
        Console.WriteLine("O Herói tem de saldo de " + saldo + " está no nível de FERRO");
        return;
    }
    if (saldo >= 10 && saldo <= 20)
    {
        Console.WriteLine("O Herói tem de saldo de " + saldo + " está no nível de BRONZE");
        return;
    }
    if (saldo >20 && saldo <= 50)
    {
        Console.WriteLine("O Herói tem de saldo de " + saldo + " está no nível de PRATA");
        return;
    }
    if (saldo > 50 && saldo <= 80)
    {
        Console.WriteLine("O Herói tem de saldo de " + saldo + " está no nível de OURO");
        return;
    }
    if (saldo > 80 && saldo <= 90)
    {
        Console.WriteLine("O Herói tem de saldo de " + saldo + " está no nível de DIAMANTE");
        return;
    }
    if (saldo > 90 && saldo <= 100)
    {
        Console.WriteLine("O Herói tem de saldo de " + saldo + " está no nível de LENDARIO");
        return;
    }
    if (saldo > 100)
    {
        Console.WriteLine("O Herói tem de saldo de " + saldo + " está no nível de IMORTAL");
        return;
    }
}