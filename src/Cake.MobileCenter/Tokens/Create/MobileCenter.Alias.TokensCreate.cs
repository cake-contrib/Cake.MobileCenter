using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Create a new API token
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTokensCreate(this ICakeContext context, MobileCenterTokensCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTokensCreateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("tokens create", settings ?? new MobileCenterTokensCreateSettings(), new string[0]);
		}
	}
}
