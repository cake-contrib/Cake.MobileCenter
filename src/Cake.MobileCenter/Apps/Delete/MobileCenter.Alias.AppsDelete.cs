using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Delete an app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterAppsDelete(this ICakeContext context, MobileCenterAppsDeleteSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterAppsDeleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apps delete", settings ?? new MobileCenterAppsDeleteSettings(), new string[0]);
		}
	}
}
