//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HairCare.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Header { get; set; }
        public string Detail { get; set; }
        public int ViewCount { get; set; }
        public Nullable<int> Stars { get; set; }
        public string Tags { get; set; }
        public Nullable<int> ShowOrder { get; set; }
        public string ViewDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
