using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center distribute release.
	/// Upload release binary and trigger distribution.
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterDistributeReleaseSettings : AutoToolSettings
	{
		/// <summary>
		/// -g|--group &lt;arg&gt;
		/// Distribution group name
		/// </summary>
		public string Group { get; set; }
		/// <summary>
		/// -f|--file &lt;arg&gt;
		/// Path to binary file
		/// </summary>
		public string File { get; set; }
		/// <summary>
		/// -R|--release-notes-file &lt;arg&gt;
		/// Path to release notes file
		/// </summary>
		public string ReleaseNotesFile { get; set; }
		/// <summary>
		/// -r|--release-notes &lt;arg&gt;
		/// Release notes text
		/// </summary>
		public string ReleaseNotes { get; set; }
		/// <summary>
		/// -a|--app &lt;arg&gt;
		/// Specify application for command to act on
		/// </summary>
		public string App { get; set; }
		/// <summary>
		/// --disable-telemetry
		/// Do not send any CLI telemetry for this
		/// </summary>
		public bool? DisableTelemetry { get; set; }
		/// <summary>
		/// -v|--version
		/// Display command&#39;s version
		/// </summary>
		public bool? Version { get; set; }
		/// <summary>
		/// --quiet
		/// Auto-confirm any requests, do not prompt
		/// </summary>
		public bool? Quiet { get; set; }
		/// <summary>
		/// -h|--help
		/// Display help for this command
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --env &lt;arg&gt;
		/// Environment to connect to when using api
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
		/// Output additional debug information for
		/// </summary>
		public bool? Debug { get; set; }
	}
}