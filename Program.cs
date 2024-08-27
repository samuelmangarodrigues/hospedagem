using hospedagem.Models;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new("Samuel", "Manga");
        Suite suite = new("Master", 10, 100);


        Reserva reserva = new(20);

        reserva.RegistrarSuite(suite);
        reserva.RegistrarHospede(pessoa1);

        reserva.CalculaValorDaDiaria();
    }
}