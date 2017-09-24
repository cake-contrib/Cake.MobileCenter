using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center test prepare espresso.
	/// Creates an artifacts directory with Espresso tests..
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterTestPrepareEspressoSettings : AutoToolSettings
	{
		/// <summary>
		/// --artifacts-dir &lt;arg&gt;
		/// Path to the artifacts directory to create
		/// </summary>
		public string ArtifactsDir { get; set; }
		/// <summary>
		/// --test-apk-path &lt;arg&gt;
		/// Path to the *.apk file with the Espresso
		/// </summary>
		public string TestApkPath { get; set; }
		/// <summary>
		/// --build-dir &lt;arg&gt;
		/// Path to the Espresso output directory
		/// </summary>
		public string BuildDir { get; set; }
		/// <summary>
		/// -p|--test-parameter &lt;arg&gt;
		/// Additional test parameters. The value must be
		/// </summary>
		public string TestParameter { get; set; }
		/// <summary>
		/// --include &lt;arg&gt;
		/// Additional files and directories to include.
		/// </summary>
		public string Include { get; set; }
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
		/// Output additional debug information for this
		/// </summary>
		public bool? Debug { get; set; }
	}
}