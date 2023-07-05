using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Account
{
	public class ApplicationUserCreate : ApplicationUserLogin
	{
		[MinLength(10, ErrorMessage = "10文字以上の入力が必要です")]
		[MaxLength(30, ErrorMessage = "30文字以下の入力が必要です")]
		public string Fullname { get; set; } = string.Empty;

		[Required(ErrorMessage = "Emailの入力が必要です")]
		[MaxLength(30, ErrorMessage = "30文字以下の入力が必要です")]
		[EmailAddress(ErrorMessage = "無効な入力形式です")]
		public string Email { get; set; } = string.Empty;
    }
}
