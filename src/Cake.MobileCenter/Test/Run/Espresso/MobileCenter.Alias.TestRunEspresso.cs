using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Starts a test run with Espresso tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestRunEspresso(this ICakeContext context, MobileCenterTestRunEspressoSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestRunEspressoSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test run espresso", settings ?? new MobileCenterTestRunEspressoSettings(), new string[0]);
		}
	}
}
