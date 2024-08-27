using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospedagem.Models;

class Suite
{
    public Suite(string suiteTypes, int capacidade, decimal valorDiaria)
    {
        SuiteType = suiteTypes;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }
    public string SuiteType { get; set; }
    public int Capacidade { get; set; } = 0;
    public decimal ValorDiaria { get; set; }
}
