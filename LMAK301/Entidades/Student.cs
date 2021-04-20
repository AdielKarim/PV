using System.ComponentModel.DataAnnotations;

namespace LMAK301.Entidades
{
    public class Student
    {
        #region Propiedades Auto Implementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        
        public string FirsName { get; set; }
        [Required]
        [StringLength(30)]

        public string  LastName { get; set; }
         [StringLength(250)]

        public string Photo { get; set; }

        public int Age { get; set; }
        public string FullName { get { return $"{FirsName}{LastName}"; } }
        #endregion 
    }

}
