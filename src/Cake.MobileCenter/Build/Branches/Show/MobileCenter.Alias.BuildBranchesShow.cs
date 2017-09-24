using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Show branch build status
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterBuildBranchesShow(this ICakeContext context, MobileCenterBuildBranchesShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterBuildBranchesShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("build branches show", settings ?? new MobileCenterBuildBranchesShowSettings(), new string[0]);
		}
	}
}
