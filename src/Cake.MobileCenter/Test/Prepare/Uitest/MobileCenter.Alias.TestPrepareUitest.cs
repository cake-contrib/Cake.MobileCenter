using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Creates an artifacts directory with Xamarin UI Tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestPrepareUitest(this ICakeContext context, MobileCenterTestPrepareUitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestPrepareUitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test prepare uitest", settings ?? new MobileCenterTestPrepareUitestSettings(), new string[0]);
		}
	}
}
