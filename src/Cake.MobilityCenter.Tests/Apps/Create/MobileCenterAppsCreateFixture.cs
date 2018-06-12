using System;
using Cake.Testing.Fixtures;
using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.MobileCenter;
using Cake.Core.IO;
using Cake.Core.Tooling;
using NSubstitute;

namespace Cake.MobilityCenter.Tests.Apps.Create
{
    public class MobileCenterAppsCreateFixture : ToolFixture<MobileCenterAppsCreateSettings>, ICakeContext
    {
        public string Path { get; set; }
        IFileSystem fileSystem;
        ICakeEnvironment environment;
        IFileSystem ICakeContext.FileSystem => fileSystem;
        ICakeEnvironment ICakeContext.Environment => environment;
        public ICakeLog Log => Log;
        ICakeArguments ICakeContext.Arguments => throw new NotImplementedException();
        IProcessRunner ICakeContext.ProcessRunner => ProcessRunner;
        public IRegistry Registry => Registry;
        public ICakeDataResolver Data => throw new NotImplementedException();
        public MobileCenterAppsCreateFixture(): base("mobility-center")
        {
            Tools = Substitute.For<IToolLocator>();
            fileSystem = Substitute.For<IFileSystem>();
            environment = Substitute.For<ICakeEnvironment>();
            var toolPath = new FilePath("mobile-center");
            var file = Substitute.For<IFile>();
            file.Exists.Returns(true);
            fileSystem.GetFile(toolPath).Returns(file);
            environment.WorkingDirectory.Returns("C:/Temp");
            Tools.Resolve("mobile-center").Returns(toolPath);
            ProcessRunner.Process.SetStandardOutput(new string[] { });
        }
        protected override void RunTool()
        {
            this.MobileCenterAppsCreate(Settings);
        }
    }
}
