using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Lists all distribution groups of the app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterDistributeGroupsList(this ICakeContext context, MobileCenterDistributeGroupsListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterDistributeGroupsListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("distribute groups list", settings ?? new MobileCenterDistributeGroupsListSettings(), new string[0]);
		}
	}
}
