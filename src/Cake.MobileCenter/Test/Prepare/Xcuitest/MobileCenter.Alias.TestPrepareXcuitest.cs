using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Creates an artifacts directory with XCUITest tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestPrepareXcuitest(this ICakeContext context, MobileCenterTestPrepareXcuitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestPrepareXcuitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test prepare xcuitest", settings ?? new MobileCenterTestPrepareXcuitestSettings(), new string[0]);
		}
	}
}
