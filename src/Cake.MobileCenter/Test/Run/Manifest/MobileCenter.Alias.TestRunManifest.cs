using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Starts a test run with previously prepared artifacts.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterTestRunManifest(this ICakeContext context, MobileCenterTestRunManifestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterTestRunManifestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test run manifest", settings ?? new MobileCenterTestRunManifestSettings(), new string[0]);
		}
	}
}
