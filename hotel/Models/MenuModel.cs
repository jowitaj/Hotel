﻿using System;

namespace zlobek.Models
{
    public class MenuModel
    {
        public int MenuId { get; set; }
        public DateTime DinnerDate { get; set; }
        public string DishType { get; set; }
        public string Allergens { get; set; }

    }
}
