//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dolap
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductSize { get; set; }
        public string Productcolor { get; set; }
        public string ProductType { get; set; }
        public Nullable<System.DateTime> ProductInputDate { get; set; }
        public Nullable<System.DateTime> ProductOutputDate { get; set; }
        public Nullable<int> ProductQuantity { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public string ProductDesc { get; set; }
        public string UserName { get; set; }
        public byte[] ProductImage { get; set; }
    
        public virtual User User { get; set; }
    }
}
