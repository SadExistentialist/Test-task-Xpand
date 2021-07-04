using System.ComponentModel.DataAnnotations;
 
namespace Test_task_Xpand.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}