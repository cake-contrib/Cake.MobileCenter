using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Deletes the distribution group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterDistributeGroupsDelete(this ICakeContext context, MobileCenterDistributeGroupsDeleteSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterDistributeGroupsDeleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("distribute groups delete", settings ?? new MobileCenterDistributeGroupsDeleteSettings(), new string[0]);
		}
	}
}
