using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Creates an artifacts directory with Appium tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestPrepareAppium(this ICakeContext context, MobileCenterTestPrepareAppiumSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestPrepareAppiumSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test prepare appium", settings ?? new MobileCenterTestPrepareAppiumSettings(), new string[0]);
		}
	}
}
