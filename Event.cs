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
    
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            this.RegistrationEvent = new HashSet<RegistrationEvent>();
        }
    
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string EventTypeId { get; set; }
        public byte MarathonId { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<short> MaxParticipants { get; set; }
    
        public virtual EventType EventType { get; set; }
        public virtual Marathon Marathon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrationEvent> RegistrationEvent { get; set; }
    }
}
