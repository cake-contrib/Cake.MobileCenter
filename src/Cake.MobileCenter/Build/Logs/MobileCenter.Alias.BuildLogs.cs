using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Displays log for build
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterBuildLogs(this ICakeContext context, MobileCenterBuildLogsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterBuildLogsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("build logs", settings ?? new MobileCenterBuildLogsSettings(), new string[0]);
		}
	}
}
