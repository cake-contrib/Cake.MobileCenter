using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Upload missing crash symbols for the application (only from macOS)
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterCrashesUploadMissingSymbols(this ICakeContext context, MobileCenterCrashesUploadMissingSymbolsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterCrashesUploadMissingSymbolsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("crashes upload-missing-symbols", settings ?? new MobileCenterCrashesUploadMissingSymbolsSettings(), new string[0]);
		}
	}
}
