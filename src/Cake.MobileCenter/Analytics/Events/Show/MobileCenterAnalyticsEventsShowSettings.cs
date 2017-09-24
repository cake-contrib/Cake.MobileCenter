using System;
using System.Runtime.CompilerServices;

namespace Cake.MobileCenter
{
	/// <summary>
	/// Settings for mobile-center analytics events show.
	/// Show statistics for events.
	/// </summary>
	[CompilerGenerated]
	public sealed class MobileCenterAnalyticsEventsShowSettings : AutoToolSettings
	{
		/// <summary>
		/// -n|--event-name &lt;arg&gt;
		/// Filter the metrics to a specific event name
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// -c|--number-of-events &lt;arg&gt;
		/// Introduce the number of events that are
		/// </summary>
		public string NumberOfEvents { get; set; }
		/// <summary>
		/// -V|--app-version &lt;arg&gt;
		/// Filter the list of events by app version
		/// </summary>
		public string AppVersion { get; set; }
		/// <summary>
		/// -e|--end &lt;arg&gt;
		/// End date (e.g. &#39;1970/01/01 00:00&#39; (system
		/// </summary>
		public string End { get; set; }
		/// <summary>
		/// -s|--start &lt;arg&gt;
		/// Start date (e.g. &#39;1970/01/01 00:00&#39; (system
		/// </summary>
		public string Start { get; set; }
		/// <summary>
		/// --properties
		/// Show statistics about event properties
		/// </summary>
		public bool? Properties { get; set; }
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
		/// Format of output for this command: json,
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --debug
		/// Output additional debug information for
		/// </summary>
		public bool? Debug { get; set; }
	}
}