using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Shows information about the distribution group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterDistributeGroupsShow(this ICakeContext context, MobileCenterDistributeGroupsShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterDistributeGroupsShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("distribute groups show", settings ?? new MobileCenterDistributeGroupsShowSettings(), new string[0]);
		}
	}
}
