namespace POSWebAppl.Models.DB_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Agent_Profile
    {
        [Key]
        [StringLength(50)]
        public string Agent_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Working_Area { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Agent_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone_Number { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        public DateTime? Regdate { get; set; }
    }
}
