using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Update user information
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterProfileUpdate(this ICakeContext context, MobileCenterProfileUpdateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterProfileUpdateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("profile update", settings ?? new MobileCenterProfileUpdateSettings(), new string[0]);
		}
	}
}
