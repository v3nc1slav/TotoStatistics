namespace TotoStatistics.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class BasicClass
    {
        [Required]
        public bool Isdelete { get; set; } = false;

        [DataType(DataType.Date)]
        public string CreatedOn { get; set; } = DateTime.UtcNow.ToString("D");

        [DataType(DataType.Date)]
        public string ChangeOn { get; set; } = DateTime.UtcNow.ToString("D");
    }
}
