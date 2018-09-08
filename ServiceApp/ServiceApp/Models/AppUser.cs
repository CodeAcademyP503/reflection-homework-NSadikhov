using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Models
{
    public class AppUser : Entity<AppUser>
    {
        public AppUser()
        {
            incidents = new HashSet<Incident>();

            Cards = new HashSet<Card>();
        }


        public decimal Balance { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string Password { get; set; }

        public ICollection<Incident> incidents { get; set; }

        public ICollection<Card> Cards { get; set; }

        public Role Role { get; set; }

        public bool IsLocked { get; set; }

        public DateTime? LockedDate { get; set; }

        public override void Update(AppUser item)
        {
            
        }
    }
}
