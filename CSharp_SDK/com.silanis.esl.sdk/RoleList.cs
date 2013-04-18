using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Silanis.ESL.SDK
{
	public class RoleList
	{
		[JsonProperty("results")]
		public List<Role> Roles { get; private set; }

		[JsonProperty("count")]
		public int Count { get; private set; }

	}
}

