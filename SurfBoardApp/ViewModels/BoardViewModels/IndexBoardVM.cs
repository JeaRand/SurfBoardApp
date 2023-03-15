﻿using SurfBoardApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace SurfBoardApp.ViewModels.BoardViewModels
{
    public class IndexBoardVM
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Type { get; set; }

        public decimal? Price { get; set; }

        public Image? Image { get; set; }
    }
}
