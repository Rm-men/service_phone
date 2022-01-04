using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    class Employee_of_company
    {
        public string id_employee { get; set; }
        [MaxLength(8)] 
        [Required]
        public string id_employment_contract { get; set; }
        [MaxLength(8)]
        [Required]
        public string emp_phone { get; set; }
        [MaxLength(4)]
        [Required]
        public string passport_serial { get; set; }
        [MaxLength(6)]
        [Required]
        public string passport_nubmer { get; set; }
        [Required]
        public string adres { get; set; }

        [MaxLength(15)]
        [Required]
        public string id_employee_type { get; set; }
        [MaxLength(15)]
        [Required]
        public string emp_phone_number { get; set; }

        [Required]
        public string date_of_employment { get; set; } //Как дату то хранить


        [Required] 
        [MaxLength(25)]
        public string emp_name { get; set; }
        [Required] 
        [MaxLength(45)]
        public string emp_family { get; set; }
        [MaxLength(45)]
        public string emp_patronomic { get; set; }


        [Required]
        [MaxLength(50)]
        public string emp_login { get; set; }
        [Required]
        [MaxLength(50)]
        public string emp_password { get; set; } //алярма, пароли все увидят



    }
}
