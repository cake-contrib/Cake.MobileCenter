using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Create a new app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterAppsCreate(this ICakeContext context, MobileCenterAppsCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterAppsCreateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apps create", settings ?? new MobileCenterAppsCreateSettings(), new string[0]);
		}
	}
}
