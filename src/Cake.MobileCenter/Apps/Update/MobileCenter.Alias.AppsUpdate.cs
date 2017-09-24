using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Update an app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterAppsUpdate(this ICakeContext context, MobileCenterAppsUpdateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterAppsUpdateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apps update", settings ?? new MobileCenterAppsUpdateSettings(), new string[0]);
		}
	}
}
