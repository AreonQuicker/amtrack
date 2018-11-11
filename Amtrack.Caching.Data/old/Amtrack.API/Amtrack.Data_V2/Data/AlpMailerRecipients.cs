using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AlpMailerRecipients
    {
        public int Id { get; set; }
        public int FkMailerId { get; set; }
        public string CustomerCode { get; set; }
        public string AccountName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public bool IsValid { get; set; }
        public int FailedValidation { get; set; }
        public DateTime? DateSent { get; set; }

        public AlpMailerUpdates FkMailer { get; set; }
    }
}
