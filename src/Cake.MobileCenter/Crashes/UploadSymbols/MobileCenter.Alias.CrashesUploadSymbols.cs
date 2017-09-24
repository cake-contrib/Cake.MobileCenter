using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Upload the crash symbols for the application
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterCrashesUploadSymbols(this ICakeContext context, MobileCenterCrashesUploadSymbolsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterCrashesUploadSymbolsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("crashes upload-symbols", settings ?? new MobileCenterCrashesUploadSymbolsSettings(), new string[0]);
		}
	}
}
