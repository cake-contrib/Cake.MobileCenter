using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Generates an Appium project
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestGenerateAppium(this ICakeContext context, MobileCenterTestGenerateAppiumSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestGenerateAppiumSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test generate appium", settings ?? new MobileCenterTestGenerateAppiumSettings(), new string[0]);
		}
	}
}
