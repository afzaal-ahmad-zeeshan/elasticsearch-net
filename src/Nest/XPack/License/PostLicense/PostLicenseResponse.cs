﻿using Newtonsoft.Json;

namespace Nest
{
	public interface IPostLicenseResponse : IResponse
	{
		/// <summary>
		/// If the license is valid but is older or has less capabilities this will list out the reasons why a resubmission with acknowledge=true is
		/// required.
		/// null if no acknowledge resubmission is needed
		/// </summary>
		[JsonProperty("acknowledge")]
		LicenseAcknowledgement Acknowledge { get; }

		[JsonProperty("acknowledged")]
		bool Acknowledged { get; }

		[JsonProperty("license_status")]
		LicenseStatus LicenseStatus { get; }
	}

	public class PostLicenseResponse : ResponseBase, IPostLicenseResponse
	{
		public LicenseAcknowledgement Acknowledge { get; internal set; }
		public bool Acknowledged { get; internal set; }

		public LicenseStatus LicenseStatus { get; internal set; }
	}
}
