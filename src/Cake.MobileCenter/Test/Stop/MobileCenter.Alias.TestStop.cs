using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Stop the started test run.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestStop(this ICakeContext context, MobileCenterTestStopSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestStopSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test stop", settings ?? new MobileCenterTestStopSettings(), new string[0]);
		}
	}
}
