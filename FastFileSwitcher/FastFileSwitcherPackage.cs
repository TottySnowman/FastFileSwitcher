global using Community.VisualStudio.Toolkit;
global using Microsoft.VisualStudio.Shell;
global using System;
global using Task = System.Threading.Tasks.Task;
using FastFileSwitcher.Commands;
using System.Runtime.InteropServices;
using System.Threading;

namespace FastFileSwitcher
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(PackageGuids.FastFileSwitcherString)]
    public sealed class FastFileSwitcherPackage : ToolkitPackage
    {
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await base.InitializeAsync(cancellationToken, progress);
            await AddFileCommand.InitializeAsync(this);
            //await DisplayFiles.InitializeAsync(this);
            await SwitchFile1.InitializeAsync(this);
            await SwitchFile2.InitializeAsync(this);
            await SwitchFile3.InitializeAsync(this);
            await SwitchFile4.InitializeAsync(this);
            await SwitchFile5.InitializeAsync(this);
            await SwitchFile6.InitializeAsync(this);
            await SwitchFile7.InitializeAsync(this);
            await SwitchFile8.InitializeAsync(this);
            await SwitchFile9.InitializeAsync(this);
        }
    }
}