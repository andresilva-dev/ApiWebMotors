﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebMotors.DTOs
{
    public class DTOCarro
    {
		public int ID { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string Version { get; set; }
		public string Image { get; set; }
		public int KM { get; set; }
		public decimal Price { get; set; }
		public int YearModel { get; set; }
		public int YearFab { get; set; }
		public string Color { get; set; }
	}
}
