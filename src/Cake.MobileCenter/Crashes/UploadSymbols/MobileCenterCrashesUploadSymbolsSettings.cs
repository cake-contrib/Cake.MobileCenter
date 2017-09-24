using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center crashes upload-symbols.
	/// Upload the crash symbols for the application.
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterCrashesUploadSymbolsSettings : AutoToolSettings
	{
		/// <summary>
		/// -m|--sourcemap &lt;arg&gt;
		/// Path to a React Native sourcemap file. Only
		/// </summary>
		public string Sourcemap { get; set; }
		/// <summary>
		/// -x|--xcarchive &lt;arg&gt;
		/// Path to a xcarchive package
		/// </summary>
		public string Xcarchive { get; set; }
		/// <summary>
		/// -s|--symbol &lt;arg&gt;
		/// Path to a dSYM package, a directory containing
		/// </summary>
		public string Symbol { get; set; }
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