using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Account
{
	public class ApplicationUser
	{
        public int ApplicationUserId { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Fullname { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Token { get; set; } = string.Empty;
    }
}
