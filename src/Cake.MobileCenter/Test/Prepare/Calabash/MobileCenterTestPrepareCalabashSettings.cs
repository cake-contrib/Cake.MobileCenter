using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center test prepare calabash.
	/// Creates an artifacts directory with Calabash tests..
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterTestPrepareCalabashSettings : AutoToolSettings
	{
		/// <summary>
		/// --app-path &lt;arg&gt;
		/// Path to an application file
		/// </summary>
		public string AppPath { get; set; }
		/// <summary>
		/// --artifacts-dir &lt;arg&gt;
		/// Path to the artifacts directory to create
		/// </summary>
		public string ArtifactsDir { get; set; }
		/// <summary>
		/// --skip-config-check
		/// Force running without Cucumber profile
		/// </summary>
		public bool? SkipConfigCheck { get; set; }
		/// <summary>
		/// --profile &lt;arg&gt;
		/// Profile to run. It must exist in the
		/// </summary>
		public string Profile { get; set; }
		/// <summary>
		/// --config-path &lt;arg&gt;
		/// Path to the Cucumber configuration file
		/// </summary>
		public string ConfigPath { get; set; }
		/// <summary>
		/// --config &lt;arg&gt;
		/// Obsolete. Please use --config-path instead
		/// </summary>
		public string Config { get; set; }
		/// <summary>
		/// --sign-info &lt;arg&gt;
		/// Use Signing Info for signing the test server
		/// </summary>
		public string SignInfo { get; set; }
		/// <summary>
		/// --workspace &lt;arg&gt;
		/// Obsolete. Please use --project-dir instead
		/// </summary>
		public string Workspace { get; set; }
		/// <summary>
		/// --project-dir &lt;arg&gt;
		/// Path to the Calabash workspace directory
		/// </summary>
		public string ProjectDir { get; set; }
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