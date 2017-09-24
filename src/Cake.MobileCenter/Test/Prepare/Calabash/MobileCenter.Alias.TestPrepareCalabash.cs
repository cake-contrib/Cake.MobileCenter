using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Creates an artifacts directory with Calabash tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestPrepareCalabash(this ICakeContext context, MobileCenterTestPrepareCalabashSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestPrepareCalabashSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test prepare calabash", settings ?? new MobileCenterTestPrepareCalabashSettings(), new string[0]);
		}
	}
}
