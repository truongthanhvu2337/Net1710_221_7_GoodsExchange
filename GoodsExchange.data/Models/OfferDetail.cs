﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace GoodsExchange.data.Models;

public partial class OfferDetail
{
    public int OfferDetailId { get; set; }

    public string TraderItem { get; set; }

    public int? OfferId { get; set; }

    public string Note { get; set; }

    public int? PostId { get; set; }

    public virtual Offer Offer { get; set; }

    public virtual Post Post { get; set; }
}