namespace CustomersApi.Dtos
{
    public class CreateCustomerDto
    {

        private long _id;

        /*
        public long ID
        {
            get { return _id; }
        set { _id = value; }
        }
        */
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Addres { get; set; }


    }
}
