using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.BlogComment
{
	public class BlogCommentCreate
	{
        public int BlogCommentId { get; set; }

        public int ParentBlogCommentId { get; set; }

        public int BlogId { get; set; }

		[Required(ErrorMessage = "Titleの入力が必要です")]
		[MinLength(10, ErrorMessage = "10文字以上の入力が必要です")]
		[MaxLength(300, ErrorMessage = "300文字以下の入力が必要です")]
		public string Content { get; set; } = string.Empty;
    }
}
