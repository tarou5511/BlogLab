using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Blog
{
	public class BlogCreate
	{
        public int BlogId { get; set; }

		[Required(ErrorMessage = "Titleの入力が必要です")]
		[MinLength(10, ErrorMessage = "10文字以上の入力が必要です")]
		[MaxLength(50, ErrorMessage = "50文字以下の入力が必要です")]
		public string Title { get; set; } = string.Empty;

		[Required(ErrorMessage = "Contentの入力が必要です")]
		[MinLength(300, ErrorMessage = "300文字以上の入力が必要です")]
		[MaxLength(3000, ErrorMessage = "3000文字以下の入力が必要です")]
		public string Content { get; set; } = string.Empty;

        public int? PhotoId { get; set; }
    }
}
