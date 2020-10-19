using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Shared.Models
{
    public class History
    {
        public int HistoryId { get; set; }
        public string List { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
