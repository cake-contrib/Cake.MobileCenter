using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Generates a Xamarin.UITest project
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestGenerateUitest(this ICakeContext context, MobileCenterTestGenerateUitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestGenerateUitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test generate uitest", settings ?? new MobileCenterTestGenerateUitestSettings(), new string[0]);
		}
	}
}
