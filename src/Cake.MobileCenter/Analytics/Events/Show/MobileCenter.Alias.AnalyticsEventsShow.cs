using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Show statistics for events
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterAnalyticsEventsShow(this ICakeContext context, MobileCenterAnalyticsEventsShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterAnalyticsEventsShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("analytics events show", settings ?? new MobileCenterAnalyticsEventsShowSettings(), new string[0]);
		}
	}
}
