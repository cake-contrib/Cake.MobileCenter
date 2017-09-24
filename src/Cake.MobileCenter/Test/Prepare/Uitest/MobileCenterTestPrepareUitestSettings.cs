using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center test prepare uitest.
	/// Creates an artifacts directory with Xamarin UI Tests..
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterTestPrepareUitestSettings : AutoToolSettings
	{
		/// <summary>
		/// --build-dir &lt;arg&gt;
		/// Path to the directory with the built test
		/// </summary>
		public string BuildDir { get; set; }
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
		/// --uitest-tools-dir &lt;arg&gt;
		/// Path to the directory containing the
		/// </summary>
		public string UitestToolsDir { get; set; }
		/// <summary>
		/// --sign-info &lt;arg&gt;
		/// Use Signing Info for signing the test
		/// </summary>
		public string SignInfo { get; set; }
		/// <summary>
		/// --key-password &lt;arg&gt;
		/// Password to the matching private key in the
		/// </summary>
		public string KeyPassword { get; set; }
		/// <summary>
		/// --key-alias &lt;arg&gt;
		/// Alias to the key in the keystore.
		/// </summary>
		public string KeyAlias { get; set; }
		/// <summary>
		/// --store-password &lt;arg&gt;
		/// Password to the keystore. Corresponds to
		/// </summary>
		public string StorePassword { get; set; }
		/// <summary>
		/// --store-path &lt;arg&gt;
		/// Path to the keystore file
		/// </summary>
		public string StorePath { get; set; }
		/// <summary>
		/// --assembly-dir &lt;arg&gt;
		/// Obsolete. Please use --build-dir instead
		/// </summary>
		public string AssemblyDir { get; set; }
		/// <summary>
		/// -p|--test-parameter &lt;arg&gt;
		/// Additional test parameters. The value must
		/// </summary>
		public string TestParameter { get; set; }
		/// <summary>
		/// --include &lt;arg&gt;
		/// Additional files and directories to
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