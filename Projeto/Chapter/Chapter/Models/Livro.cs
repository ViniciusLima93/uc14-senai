﻿namespace Chapter.Models
{
    public class Livro
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public int QuantidadePagina { get; set; }

        public bool Disponivel { get; set; }
    }
}
