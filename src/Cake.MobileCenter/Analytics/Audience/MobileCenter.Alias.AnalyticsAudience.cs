using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Show audience statistics
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterAnalyticsAudience(this ICakeContext context, MobileCenterAnalyticsAudienceSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterAnalyticsAudienceSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("analytics audience", settings ?? new MobileCenterAnalyticsAudienceSettings(), new string[0]);
		}
	}
}
