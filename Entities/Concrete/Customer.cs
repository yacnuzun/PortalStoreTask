using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : Base, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long TCID { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gsm { get; set; }
    }

}
