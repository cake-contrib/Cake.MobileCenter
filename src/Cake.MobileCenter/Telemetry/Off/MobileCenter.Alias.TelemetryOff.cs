using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Turn off the sending of telemetry
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTelemetryOff(this ICakeContext context, MobileCenterTelemetryOffSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTelemetryOffSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("telemetry off", settings ?? new MobileCenterTelemetryOffSettings(), new string[0]);
		}
	}
}
