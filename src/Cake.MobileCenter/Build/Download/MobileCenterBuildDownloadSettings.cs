using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center build download.
	/// Download the binary, logs or symbols for a completed build.
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterBuildDownloadSettings : AutoToolSettings
	{
		/// <summary>
		/// -t|--type &lt;arg&gt;
		/// Type of download. &#39;build&#39;, &#39;logs&#39;, and &#39;symbols&#39;
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// -i|--id &lt;arg&gt;
		/// ID of build to download
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// -d|--dest &lt;arg&gt;
		/// Download destination path
		/// </summary>
		public string Dest { get; set; }
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
		/// Format of output for this command: json
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --debug
		/// Output additional debug information for this
		/// </summary>
		public bool? Debug { get; set; }
	}
}