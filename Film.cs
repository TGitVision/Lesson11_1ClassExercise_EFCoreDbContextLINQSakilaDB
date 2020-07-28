using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lesson11_1ClassExercise_EFCoreDbContextLINQSakilaDB
{
    class Film
    {
        [Key]
        public int film_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string release_year { get; set; }
        public byte language_id { get; set; }
        public byte original_language_id { get; set; }
        public byte rental_duration { get; set; }
        public decimal rental_rate { get; set; }
        public Int16 length { get; set; }
        public decimal replacement_cost { get; set; }
        public string rating { get; set; }
        public string special_features { get; set; }
        public DateTime last_update { get; set; }

    }
}
