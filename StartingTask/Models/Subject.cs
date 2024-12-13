namespace StartingTask.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subject
    {
        public int SubjectID { get; set; }

        [StringLength(30)]
        public string Group { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        [StringLength(20)]
        public string Lesson { get; set; }

        [StringLength(20)]
        public string GroupID { get; set; }

        [StringLength(20)]
        public string NameID { get; set; }
    }
}
