using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Setup autocompletion for the shell
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterSetupAutocomplete(this ICakeContext context, MobileCenterSetupAutocompleteSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterSetupAutocompleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("setup-autocomplete", settings ?? new MobileCenterSetupAutocompleteSettings(), new string[0]);
		}
	}
}
