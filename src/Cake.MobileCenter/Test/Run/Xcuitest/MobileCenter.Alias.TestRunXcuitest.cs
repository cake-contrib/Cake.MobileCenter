using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Starts a test run with XCUITest tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestRunXcuitest(this ICakeContext context, MobileCenterTestRunXcuitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestRunXcuitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test run xcuitest", settings ?? new MobileCenterTestRunXcuitestSettings(), new string[0]);
		}
	}
}
