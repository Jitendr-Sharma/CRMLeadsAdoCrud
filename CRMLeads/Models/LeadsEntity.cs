using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRMLeads.Models
{
    public class LeadsEntity
    {
        [Key]
        [DisplayName("Lead Id")]
        public int Id { get; set; }

        [DisplayName("Lead Date")]
        public DateTime LeadDate { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Mobile")]
        public string Mobile { get; set; }
      
        [DisplayName("Lead Source")]
        public string LeadSource { get; set; }

        [DisplayName("Lead Status")]
        public string LeadStatus { get; set; }

        [DisplayName("Next Follow UpDate")]
        public DateTime NextFollowUpDate { get; set; } 


    
    }
}
