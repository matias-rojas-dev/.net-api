namespace CustomersApi.Dtos
{

    // Un DTO es un obj que usas para transferir información de una capa del dominio a otra
    public class CustomerDto
    {


        /*
        public long ID
        {
            get { return _id; }
        set { _id = value; }
        }
        */
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Addres { get; set; }


    }
}
