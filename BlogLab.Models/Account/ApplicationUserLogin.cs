using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Account
{
	public class ApplicationUserLogin
	{
		[Required(ErrorMessage ="Usernameの入力が必要です")]
		[MinLength(5,ErrorMessage ="5文字以上の入力が必要です")]
		[MaxLength(20, ErrorMessage = "20文字以下の入力が必要です")]
		public string Username { get; set; }　= string.Empty;

		[Required(ErrorMessage = "Passwordの入力が必要です")]
		[MinLength(10, ErrorMessage = "10文字以上の入力が必要です")]
		[MaxLength(50, ErrorMessage = "50文字以下の入力が必要です")]
		public string Password { get; set; } = string.Empty;
    }
}
