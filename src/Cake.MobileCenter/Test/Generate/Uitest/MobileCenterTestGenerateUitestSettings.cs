using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center test generate uitest.
	/// Generates a Xamarin.UITest project.
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterTestGenerateUitestSettings : AutoToolSettings
	{
		/// <summary>
		/// --output-path &lt;arg&gt;
		/// The path where the tests will be generated
		/// </summary>
		public string OutputPath { get; set; }
		/// <summary>
		/// --platform &lt;arg&gt;
		/// The app&#39;s platform (&#39;ios&#39; or &#39;android&#39;)
		/// </summary>
		public string Platform { get; set; }
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