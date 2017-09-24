using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Update list of organization collaborators
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterOrgsCollaboratorsUpdate(this ICakeContext context, MobileCenterOrgsCollaboratorsUpdateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterOrgsCollaboratorsUpdateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("orgs collaborators update", settings ?? new MobileCenterOrgsCollaboratorsUpdateSettings(), new string[0]);
		}
	}
}
