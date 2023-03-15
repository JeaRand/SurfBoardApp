﻿using SurfBoardApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace SurfBoardApp.ViewModels.BoardViewModels
{
    public class EditBoardVM : CreateBoardVM
    {
        public int Id { get; set; }

        public List<Image>? ExistingImages { get; set; }
    }
}
