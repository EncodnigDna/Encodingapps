//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appswindows
{
    using System;
    using System.Collections.Generic;
    
    public partial class vente
    {
        public int id_vente { get; set; }
        public string date_vente { get; set; }
        public int qentity_vente { get; set; }
        public decimal prix_unitare_achat { get; set; }
        public decimal prix_vente { get; set; }
        public string mouvement { get; set; }
        public int id_produit { get; set; }
        public int id_client { get; set; }
        public int id_emp { get; set; }
        public string note_vente { get; set; }
    
        public virtual client client { get; set; }
        public virtual emplyee emplyee { get; set; }
        public virtual produit produit { get; set; }
    }
}
