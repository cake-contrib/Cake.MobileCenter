using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Command to see the incoming logs in real time
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterAnalyticsLogFlow(this ICakeContext context, MobileCenterAnalyticsLogFlowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterAnalyticsLogFlowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("analytics log-flow", settings ?? new MobileCenterAnalyticsLogFlowSettings(), new string[0]);
		}
	}
}
