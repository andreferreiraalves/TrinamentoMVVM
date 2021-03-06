﻿using System.Collections.Generic;

namespace SimpleTrader.Domain.Models
{
    public class Account : DomainObject
    {
        public User AccountHolder { get; set; }
        public double Balance { get; set; }
        public IEnumerable<AssertTransactions> AssetTransactions { get; set; }
    }
}
