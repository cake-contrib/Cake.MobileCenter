using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Create new distribution group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterDistributeGroupsCreate(this ICakeContext context, MobileCenterDistributeGroupsCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterDistributeGroupsCreateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("distribute groups create", settings ?? new MobileCenterDistributeGroupsCreateSettings(), new string[0]);
		}
	}
}
