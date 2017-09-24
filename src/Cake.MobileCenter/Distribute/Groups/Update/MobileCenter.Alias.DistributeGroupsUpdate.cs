using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Update existing distribution group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterDistributeGroupsUpdate(this ICakeContext context, MobileCenterDistributeGroupsUpdateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterDistributeGroupsUpdateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("distribute groups update", settings ?? new MobileCenterDistributeGroupsUpdateSettings(), new string[0]);
		}
	}
}
