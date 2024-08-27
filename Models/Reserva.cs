namespace hospedagem.Models;
class Reserva
{
    public Reserva(int diasReservados)
    {
        Hospedes = [];
        DiasReservados = diasReservados;
    }

    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public void RegistrarHospede(Pessoa pessoa)
    {
        if (Suite.Capacidade > Hospedes.Count)
            Hospedes.Add(pessoa);
        else
            Console.WriteLine("Nao cabem mais pessoas!!");
    }

    public void RegistrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int QuantidadeDeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalculaValorDaDiaria()
    {
        decimal totalValue = Suite.ValorDiaria * DiasReservados;

        if (DiasReservados >= 10)
        {
            decimal descount = totalValue * 0.10m;

            Console.WriteLine(totalValue - descount);

            return totalValue - descount;
        }

        return totalValue;

    }
}