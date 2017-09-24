using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Download the binary, logs or symbols for a completed build
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterBuildDownload(this ICakeContext context, MobileCenterBuildDownloadSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterBuildDownloadSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("build download", settings ?? new MobileCenterBuildDownloadSettings(), new string[0]);
		}
	}
}
