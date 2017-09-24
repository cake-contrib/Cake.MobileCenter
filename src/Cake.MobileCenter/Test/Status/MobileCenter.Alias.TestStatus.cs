using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Checks the status of the started test run.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestStatus(this ICakeContext context, MobileCenterTestStatusSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestStatusSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test status", settings ?? new MobileCenterTestStatusSettings(), new string[0]);
		}
	}
}
