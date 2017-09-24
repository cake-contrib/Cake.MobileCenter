using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Get list of configured applications
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterAppsList(this ICakeContext context, MobileCenterAppsListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterAppsListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apps list", settings ?? new MobileCenterAppsListSettings(), new string[0]);
		}
	}
}
