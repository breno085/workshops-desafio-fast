﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AtasAPI.Models
{
    public class Colaborador
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        [JsonIgnore]
        public ICollection<Presenca>? ColaboradorWorkshops { get; set; }
    }
}
