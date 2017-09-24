using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Shows versions of the application
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterAnalyticsAppVersions(this ICakeContext context, MobileCenterAnalyticsAppVersionsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterAnalyticsAppVersionsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("analytics app-versions", settings ?? new MobileCenterAnalyticsAppVersionsSettings(), new string[0]);
		}
	}
}
