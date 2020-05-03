namespace TotoStatistics.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Statistics : BasicClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SumOfFirstEdition { get; set; }

        [Required]
        public int SumOfSecandEdition { get; set; }

        [Required]
        public int SumOfBonusEdition { get; set; }

        [Required]
        public int SumOfNumber { get; set; }

        [Required]
        public decimal AverageSumOfNumber { get; set; }

        [Required]
        public string PopularNumber { get; set; }

        [Required]
        public string UnpopularNumber { get; set; }


    }
}
