using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center distribute groups update.
	/// Update existing distribution group.
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterDistributeGroupsUpdateSettings : AutoToolSettings
	{
		/// <summary>
		/// -g|--group &lt;arg&gt;
		/// Distribution group name
		/// </summary>
		public string Group { get; set; }
		/// <summary>
		/// -D|--delete-testers-file &lt;arg&gt;
		/// Path to file containing list of testers
		/// </summary>
		public string DeleteTestersFile { get; set; }
		/// <summary>
		/// -T|--add-testers-file &lt;arg&gt;
		/// Path to file containing list of testers
		/// </summary>
		public string AddTestersFile { get; set; }
		/// <summary>
		/// -d|--delete-testers &lt;arg&gt;
		/// List of testers to delete (use
		/// </summary>
		public string DeleteTesters { get; set; }
		/// <summary>
		/// -t|--add-testers &lt;arg&gt;
		/// List of testers to add (use
		/// </summary>
		public string AddTesters { get; set; }
		/// <summary>
		/// -n|--name &lt;arg&gt;
		/// New distribution group name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// -a|--app &lt;arg&gt;
		/// Specify application for command to act
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