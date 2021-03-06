using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center analytics audience.
	/// Show audience statistics.
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterAnalyticsAudienceSettings : AutoToolSettings
	{
		/// <summary>
		/// --active-users
		/// Show active users statistics
		/// </summary>
		public bool? ActiveUsers { get; set; }
		/// <summary>
		/// --languages
		/// Show languages statistics
		/// </summary>
		public bool? Languages { get; set; }
		/// <summary>
		/// --countries
		/// Show country statistics
		/// </summary>
		public bool? Countries { get; set; }
		/// <summary>
		/// --devices
		/// Show devices statistics
		/// </summary>
		public bool? Devices { get; set; }
		/// <summary>
		/// -V|--app-version &lt;arg&gt;
		/// Specify app version to show statistics for
		/// </summary>
		public string AppVersion { get; set; }
		/// <summary>
		/// -e|--end &lt;arg&gt;
		/// End date (e.g. &#39;1970/01/01 00:00&#39; (system time
		/// </summary>
		public string End { get; set; }
		/// <summary>
		/// -s|--start &lt;arg&gt;
		/// Start date (e.g. &#39;1970/01/01 00:00&#39; (system time
		/// </summary>
		public string Start { get; set; }
		/// <summary>
		/// -a|--app &lt;arg&gt;
		/// Specify application for command to act on
		/// </summary>
		public string App { get; set; }
		/// <summary>
		/// --disable-telemetry
		/// Do not send any CLI telemetry for this command,
		/// </summary>
		public bool? DisableTelemetry { get; set; }
		/// <summary>
		/// -v|--version
		/// Display command&#39;s version
		/// </summary>
		public bool? Version { get; set; }
		/// <summary>
		/// --quiet
		/// Auto-confirm any requests, do not prompt for
		/// </summary>
		public bool? Quiet { get; set; }
		/// <summary>
		/// -h|--help
		/// Display help for this command
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --env &lt;arg&gt;
		/// Environment to connect to when using api token
		/// </summary>
		public string Env { get; set; }
		/// <summary>
		/// --token &lt;arg&gt;
		/// API Token to use for this command
		/// </summary>
		public string Token { get; set; }
		/// <summary>
		/// --output &lt;arg&gt;
		/// Format of output for this command: json, csv
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --debug
		/// Output additional debug information for this
		/// </summary>
		public bool? Debug { get; set; }
	}
}