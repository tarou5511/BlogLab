﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Photo
{
	public class PhotoCreate
	{
        public string ImageUrl { get; set; } = string.Empty;

        public string PublicId { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
