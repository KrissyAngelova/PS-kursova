//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhoWantsToBeAMillionare
{
    using System;
    using System.Collections.Generic;
    
    public partial class Qustions
    {
        public Qustions()
        {
            this.Answers = new HashSet<Answers>();
        }
    
        public int Id { get; set; }
        public string Content { get; set; }
        public Nullable<int> DifficultyValue { get; set; }
    
        public virtual ICollection<Answers> Answers { get; set; }
    }
}
