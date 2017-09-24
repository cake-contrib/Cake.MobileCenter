using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Log the CLI out of Mobile Center
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterLogout(this ICakeContext context, MobileCenterLogoutSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterLogoutSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("logout", settings ?? new MobileCenterLogoutSettings(), new string[0]);
		}
	}
}
