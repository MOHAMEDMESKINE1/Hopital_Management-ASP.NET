//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hopita_Ibn_Sina_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class Test_Ordonnance
    {
        public int num { get; set; }
        public Nullable<int> Ord_Num { get; set; }
        public Nullable<int> Test_num { get; set; }
    
        public virtual Ordonnance Ordonnance { get; set; }
        public virtual Test Test { get; set; }
    }
}
