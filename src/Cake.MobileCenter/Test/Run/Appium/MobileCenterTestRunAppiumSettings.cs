using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center test run appium.
	/// Starts a test run with Appium tests..
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterTestRunAppiumSettings : AutoToolSettings
	{
		/// <summary>
		/// --build-dir &lt;arg&gt;
		/// Path to the directory with the Appium tests
		/// </summary>
		public string BuildDir { get; set; }
		/// <summary>
		/// --devices &lt;arg&gt;
		/// Device selection slug
		/// </summary>
		public string Devices { get; set; }
		/// <summary>
		/// --timeout &lt;arg&gt;
		/// Maximum time (in seconds) to wait for test
		/// </summary>
		public string Timeout { get; set; }
		/// <summary>
		/// --async
		/// Exit the command when tests are uploaded,
		/// </summary>
		public bool? Async { get; set; }
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
		/// --test-series &lt;arg&gt;
		/// Name of the test series
		/// </summary>
		public string TestSeries { get; set; }
		/// <summary>
		/// --language &lt;arg&gt;
		/// Override the language (iOS only) for the test
		/// </summary>
		public string Language { get; set; }
		/// <summary>
		/// --locale &lt;arg&gt;
		/// The system locale for the test run. For
		/// </summary>
		public string Locale { get; set; }
		/// <summary>
		/// --dsym-dir &lt;arg&gt;
		/// Path to the directory with iOS symbol files
		/// </summary>
		public string DsymDir { get; set; }
		/// <summary>
		/// --app-path &lt;arg&gt;
		/// Path to an application file
		/// </summary>
		public string AppPath { get; set; }
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