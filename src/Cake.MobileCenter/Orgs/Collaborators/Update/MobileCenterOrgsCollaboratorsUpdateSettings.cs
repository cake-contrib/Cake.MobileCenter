using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center orgs collaborators update.
	/// Update list of organization collaborators.
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterOrgsCollaboratorsUpdateSettings : AutoToolSettings
	{
		/// <summary>
		/// -n|--name &lt;arg&gt;
		/// Name of the organization
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// -M|--make-collaborators-file &lt;arg&gt;
		/// Path to the list of admins to make
		/// </summary>
		public string MakeCollaboratorsFile { get; set; }
		/// <summary>
		/// -m|--make-collaborators &lt;arg&gt;
		/// List of admins to make
		/// </summary>
		public string MakeCollaborators { get; set; }
		/// <summary>
		/// -A|--make-admins-file &lt;arg&gt;
		/// Path to the list of collaborators
		/// </summary>
		public string MakeAdminsFile { get; set; }
		/// <summary>
		/// -a|--make-admins &lt;arg&gt;
		/// List of collaborators to make
		/// </summary>
		public string MakeAdmins { get; set; }
		/// <summary>
		/// -D|--delete-collaborators-file &lt;arg&gt;
		/// Path to the list of collaborators
		/// </summary>
		public string DeleteCollaboratorsFile { get; set; }
		/// <summary>
		/// -d|--delete-collaborators &lt;arg&gt;
		/// List of collaborators to delete
		/// </summary>
		public string DeleteCollaborators { get; set; }
		/// <summary>
		/// -C|--add-collaborators-file &lt;arg&gt;
		/// Path to the list of collaborators
		/// </summary>
		public string AddCollaboratorsFile { get; set; }
		/// <summary>
		/// -c|--add-collaborators &lt;arg&gt;
		/// List of collaborators to add
		/// </summary>
		public string AddCollaborators { get; set; }
		/// <summary>
		/// --disable-telemetry
		/// Do not send any CLI telemetry for
		/// </summary>
		public bool? DisableTelemetry { get; set; }
		/// <summary>
		/// -v|--version
		/// Display command&#39;s version
		/// </summary>
		public bool? Version { get; set; }
		/// <summary>
		/// --quiet
		/// Auto-confirm any requests, do not
		/// </summary>
		public bool? Quiet { get; set; }
		/// <summary>
		/// -h|--help
		/// Display help for this command
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --env &lt;arg&gt;
		/// Environment to connect to when
		/// </summary>
		public string Env { get; set; }
		/// <summary>
		/// --token &lt;arg&gt;
		/// API Token to use for this command
		/// </summary>
		public string Token { get; set; }
		/// <summary>
		/// --output &lt;arg&gt;
		/// Format of output for this command:
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --debug
		/// Output additional debug
		/// </summary>
		public bool? Debug { get; set; }
	}
}