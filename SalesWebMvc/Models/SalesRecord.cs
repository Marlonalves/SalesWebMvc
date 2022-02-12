using SalesWebMvc.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd//MM/yyyy}")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "{0} required")]
        //[Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        //[Display(Name = "Amount")]
        //[DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }

        public SaleStatus Status { get; set; }

        public Seller Seller { get; set; }

        [Display(Name = "Seller name")]
        public int SellerId { get; set; }

        public enum SaleStatus
        {
            Pending = 0,
            Billed = 1,
            Canceled = 2
        }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
