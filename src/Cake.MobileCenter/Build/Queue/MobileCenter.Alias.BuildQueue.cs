using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Queue a new build
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterBuildQueue(this ICakeContext context, MobileCenterBuildQueueSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterBuildQueueSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("build queue", settings ?? new MobileCenterBuildQueueSettings(), new string[0]);
		}
	}
}
