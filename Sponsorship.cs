//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSR2016_WPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sponsorship
    {
        public int SponsorshipId { get; set; }
        public string SponsorName { get; set; }
        public int RegistrationId { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Registration Registration { get; set; }
    }
}
