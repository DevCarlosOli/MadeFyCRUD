﻿using System;

namespace MadeFyCRUD.Domain.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
