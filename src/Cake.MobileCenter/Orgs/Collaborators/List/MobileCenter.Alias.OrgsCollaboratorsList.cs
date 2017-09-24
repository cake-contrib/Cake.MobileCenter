using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.MobileCenter
{
	partial class MobileCenterAliases
	{
		/// <summary>
	    /// Lists collaborators of organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
	
		public static void MobileCenterOrgsCollaboratorsList(this ICakeContext context, MobileCenterOrgsCollaboratorsListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			var runner = new GenericRunner<MobileCenterOrgsCollaboratorsListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("orgs collaborators list", settings ?? new MobileCenterOrgsCollaboratorsListSettings(), new string[0]);
		}
	}
}
