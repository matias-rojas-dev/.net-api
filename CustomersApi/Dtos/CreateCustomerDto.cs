using System.ComponentModel.DataAnnotations;

namespace CustomersApi.Dtos
{
    public class CreateCustomerDto
    {


        /*
        public long ID
        {
            get { return _id; }
        set { _id = value; }
        }
        */

        // Required señala que el campo que está abajo es requerido
        [Required (ErrorMessage = "El nombre debe estar especificado")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "El apellido debe estar especificado")]
        public string LastName { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",ErrorMessage = "El email no es válido")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Addres { get; set; }


    }
}
