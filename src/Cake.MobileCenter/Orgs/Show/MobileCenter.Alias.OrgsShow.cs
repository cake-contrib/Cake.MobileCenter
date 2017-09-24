using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Show information about organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterOrgsShow(this ICakeContext context, MobileCenterOrgsShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterOrgsShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("orgs show", settings ?? new MobileCenterOrgsShowSettings(), new string[0]);
		}
	}
}
