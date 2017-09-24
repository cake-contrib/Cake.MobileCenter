using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Creates an artifacts directory with Espresso tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestPrepareEspresso(this ICakeContext context, MobileCenterTestPrepareEspressoSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestPrepareEspressoSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test prepare espresso", settings ?? new MobileCenterTestPrepareEspressoSettings(), new string[0]);
		}
	}
}
