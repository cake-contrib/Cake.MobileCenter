using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Update organization information
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterOrgsUpdate(this ICakeContext context, MobileCenterOrgsUpdateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterOrgsUpdateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("orgs update", settings ?? new MobileCenterOrgsUpdateSettings(), new string[0]);
		}
	}
}
