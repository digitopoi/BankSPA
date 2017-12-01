using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BankSPA.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int AccountNumber { get; set; }

        public string TransactionType { get; set; }

        public decimal BalanceDifference { get; set; }

        public DateTime TransactionDate { get; set; }

        public Account Account { get; set; }
    }
}
