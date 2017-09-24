using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Get a list of API tokens
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTokensList(this ICakeContext context, MobileCenterTokensListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTokensListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("tokens list", settings ?? new MobileCenterTokensListSettings(), new string[0]);
		}
	}
}
