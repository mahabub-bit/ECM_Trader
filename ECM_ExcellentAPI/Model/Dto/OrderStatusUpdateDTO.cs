﻿using System.ComponentModel.DataAnnotations;

namespace ECM_ExcellentAPI.Model.Dto
{
    public class OrderStatusUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        public string Status { get; set; }
        public string Desc { get; set; }
    }
}
