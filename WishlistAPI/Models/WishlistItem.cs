﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishlistAPI.Models
{
    public class WishlistItem
	{
		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "userId")]
		public string UserId { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "createdDate")]
		public string CreatedDate { get; set; }

		[JsonProperty(PropertyName = "claimedByUserId")]
		public string ClaimedByUserId { get; set; }

    }
}
