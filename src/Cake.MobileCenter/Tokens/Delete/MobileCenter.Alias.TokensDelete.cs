using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Delete an API token
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTokensDelete(this ICakeContext context, MobileCenterTokensDeleteSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTokensDeleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("tokens delete", settings ?? new MobileCenterTokensDeleteSettings(), new string[0]);
		}
	}
}
