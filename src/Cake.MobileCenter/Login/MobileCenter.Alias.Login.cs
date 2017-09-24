using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Log the CLI into Mobile Center
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterLogin(this ICakeContext context, MobileCenterLoginSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterLoginSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("login", settings ?? new MobileCenterLoginSettings(), new string[0]);
		}
	}
}
