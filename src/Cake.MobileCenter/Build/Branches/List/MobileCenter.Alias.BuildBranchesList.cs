using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Show list of branches
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterBuildBranchesList(this ICakeContext context, MobileCenterBuildBranchesListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterBuildBranchesListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("build branches list", settings ?? new MobileCenterBuildBranchesListSettings(), new string[0]);
		}
	}
}
