namespace TotoStatistics.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Toto : BasicClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public NameType Name { get; set; }

        [Required]
        [Range(9, 25)]
        public string DownloadedNumbers { get; set; }

        [Required]
        [Range(1, 120)]
        public int Edition { get; set; }

        [Required]
        public DrawType Draw { get; set; }

    }
}
