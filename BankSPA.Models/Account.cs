using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BankSPA.Models
{
    public class Account
    {
        [Key]
        public int AccountNumber { get; set; }

        public decimal Balance { get; set; }

        public byte[] PinHash { get; set; }

        public byte[] PinSalt { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
