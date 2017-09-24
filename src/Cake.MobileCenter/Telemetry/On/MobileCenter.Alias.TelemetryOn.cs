using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Turn on the sending of telemetry
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTelemetryOn(this ICakeContext context, MobileCenterTelemetryOnSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTelemetryOnSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("telemetry on", settings ?? new MobileCenterTelemetryOnSettings(), new string[0]);
		}
	}
}
