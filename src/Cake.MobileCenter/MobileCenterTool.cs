﻿using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System.Collections.Generic;

namespace Cake.MobileCenter
{
    /// <summary>
    /// Base class for all mobile-center related tools.
    /// </summary>
    /// <typeparam name="TSettings">The settings type.</typeparam>
    public abstract class MobileCenterTool<TSettings> : Tool<TSettings>
        where TSettings : ToolSettings
    {
        private readonly ICakeEnvironment _environment;
        private readonly IFileSystem _fileSystem;

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileCenterTool{TSettings}"/> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tools.</param>
        protected MobileCenterTool(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IToolLocator tools)
            : base(fileSystem, environment, processRunner, tools)
        {
            _fileSystem = fileSystem;
            _environment = environment;
        }

        /// <summary>
        /// Gets the name of the tool.
        /// </summary>
        /// <returns>The name of the tool.</returns>
        protected override string GetToolName()
        {
            return "MobileCenter";
        }

        /// <summary>
        /// Gets the possible names of the tool executable.
        /// </summary>
        /// <returns>The tool executable name.</returns>
        protected override IEnumerable<string> GetToolExecutableNames()
        {
            return new[] { "mobile-center" };
        }
    }
}
