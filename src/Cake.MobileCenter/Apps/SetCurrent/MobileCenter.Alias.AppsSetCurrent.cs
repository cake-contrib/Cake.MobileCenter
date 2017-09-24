using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Set default application for all CLI commands
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterAppsSetCurrent(this ICakeContext context, MobileCenterAppsSetCurrentSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterAppsSetCurrentSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apps set-current", settings ?? new MobileCenterAppsSetCurrentSettings(), new string[0]);
		}
	}
}
