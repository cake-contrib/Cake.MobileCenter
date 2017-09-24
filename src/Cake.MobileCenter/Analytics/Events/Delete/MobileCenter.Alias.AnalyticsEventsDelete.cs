using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Delete event
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterAnalyticsEventsDelete(this ICakeContext context, MobileCenterAnalyticsEventsDeleteSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterAnalyticsEventsDeleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("analytics events delete", settings ?? new MobileCenterAnalyticsEventsDeleteSettings(), new string[0]);
		}
	}
}
