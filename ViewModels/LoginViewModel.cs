using System.ComponentModel.DataAnnotations;
 
namespace Test_task_Xpand.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }
         
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
         
         public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}