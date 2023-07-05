﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Account
{
	public class ApplicationUserIdentity
	{
		public int ApplicationUserId { get; set; }

		public string UserName { get; set; } = string.Empty;

		public string NormalizedUserName { get; set; } = string.Empty;

		public string Email { get; set; } = string.Empty;

		public string NormalizedEmail { get; set; } = string.Empty;

		public string Fullname { get; set; } = string.Empty;

		public string PasswordHash { get; set; } = string.Empty;
	}
}
