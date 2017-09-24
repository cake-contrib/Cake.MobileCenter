using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Get information about logged in user
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterProfileList(this ICakeContext context, MobileCenterProfileListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterProfileListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("profile list", settings ?? new MobileCenterProfileListSettings(), new string[0]);
		}
	}
}
