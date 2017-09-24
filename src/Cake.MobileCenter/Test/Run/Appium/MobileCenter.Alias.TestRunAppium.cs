using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Starts a test run with Appium tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestRunAppium(this ICakeContext context, MobileCenterTestRunAppiumSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestRunAppiumSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test run appium", settings ?? new MobileCenterTestRunAppiumSettings(), new string[0]);
		}
	}
}
