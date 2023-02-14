using System;
using System.Collections.Generic;
using System.Linq;

namespace ddd_pratica.Entities
{
    public class Client
    {
        public int ClientId { get; set; }   
        public string Name { get; set; } 
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }  
        public bool IsActive { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }

    public bool SpecialClient (Client client)
        {
            return client.IsActive && DateTime.Now.Year - client.RegistrationDate.Year >= 5;
        }
    }
}
