﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public decimal DiscountPrice { get; set; }
        public DateTime FinishDate { get; set; }

    }
}
