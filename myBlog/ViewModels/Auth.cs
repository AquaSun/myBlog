﻿using System;
using System.ComponentModel.DataAnnotations;

namespace myBlog.ViewModels
{
	public class AuthLogin
	{
		[Required]
		public string Username { get; set; }

		[Required, DataType(DataType.Password)]
		public string Password { get; set; }
	}
}

