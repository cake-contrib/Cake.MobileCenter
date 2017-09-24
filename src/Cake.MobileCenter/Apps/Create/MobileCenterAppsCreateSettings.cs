using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center apps create.
	/// Create a new app.
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterAppsCreateSettings : AutoToolSettings
	{
		/// <summary>
		/// -p|--platform &lt;arg&gt;
		/// The platform of the app. Supported values:
		/// </summary>
		public string Platform { get; set; }
		/// <summary>
		/// -o|--os &lt;arg&gt;
		/// The OS the app will be running on. Supported
		/// </summary>
		public string Os { get; set; }
		/// <summary>
		/// -d|--display-name &lt;arg&gt;
		/// The descriptive name of the app. This can
		/// </summary>
		public string DisplayName { get; set; }
		/// <summary>
		/// -n|--name &lt;arg&gt;
		/// The name of the app used in URLs. Can
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// --description &lt;arg&gt;
		/// Description of the app
		/// </summary>
		public string Description { get; set; }
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