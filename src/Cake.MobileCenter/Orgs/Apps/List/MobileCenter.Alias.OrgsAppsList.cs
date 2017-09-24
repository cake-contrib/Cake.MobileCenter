using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Lists applications of organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterOrgsAppsList(this ICakeContext context, MobileCenterOrgsAppsListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterOrgsAppsListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("orgs apps list", settings ?? new MobileCenterOrgsAppsListSettings(), new string[0]);
		}
	}
}
