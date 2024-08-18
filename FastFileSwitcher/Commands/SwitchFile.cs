using EnvDTE;
using EnvDTE80;
using FastFileSwitcher.Commands;
using FastFileSwitcher;
using FastFileSwitcher.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFileSwitcher.Commands
{
    //[Command(PackageIds.SwitchToFile1)]
    //internal sealed class SwitchFile : BaseCommand
    //{
    //    private readonly AsyncPackage _package;
    //    private SwitchFile(AsyncPackage package, OleMenuCommandService commandService)
    //    {
    //        _package = package ?? throw new ArgumentNullException(nameof(package));

    //        var switchToFile1 = new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile1);
    //        var menuItem = new MenuCommand(Execute, switchToFile1);
    //        commandService.AddCommand(menuItem);
    //    }
    //    public static SwitchFile Instance { get; private set; }

    //    private IAsyncServiceProvider ServiceProvider => _package;

    //    public static async Task InitializeAsync(AsyncPackage package)
    //    {
    //        // Switch to the main thread - the call to AddCommand in GetDocumentPathCommand's constructor requires it
    //        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

    //        var commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
    //        Instance = new SwitchFile(package, commandService);
    //    }
    //    protected override void Execute(object sender, EventArgs e)
    //    {
    //        var commandArgs = e as OleMenuCmdEventArgs;
    //        if (commandArgs != null)
    //        {
    //            var values = commandArgs.InValue;
    //        }
    //            ThreadHelper.ThrowIfNotOnUIThread();
    //        var dte = (DTE2)ServiceProvider.GetServiceAsync(typeof(DTE)).Result;
    //        if(dte == null)
    //        {
    //            return;
    //        }

    //        var selectedFilePath = ItemManager.Instance.GetItems().First().FilePath;
    //        dte.ItemOperations.OpenFile(selectedFilePath);
    //    }
    //}
    //[Command(PackageIds.SwitchToFile2)]
    //public class SwitchFile2 : BaseCommand
    //{
    //    private readonly AsyncPackage _package;
    //    private SwitchFile2(AsyncPackage package, OleMenuCommandService commandService)
    //    {
    //        _package = package ?? throw new ArgumentNullException(nameof(package));

    //        var switchToFile1 = new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile1);
    //        var menuItem = new MenuCommand(Execute, switchToFile1);
    //        commandService.AddCommand(menuItem);
    //    }
    //    public static SwitchFile2 Instance { get; private set; }

    //    private IAsyncServiceProvider ServiceProvider => _package;

    //    public static async Task InitializeAsync(AsyncPackage package)
    //    {
    //        // Switch to the main thread - the call to AddCommand in GetDocumentPathCommand's constructor requires it
    //        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

    //        var commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
    //        Instance = new SwitchFile2(package, commandService);
    //    }
    //    protected override void Execute(object sender, EventArgs e)
    //    {
    //        ThreadHelper.ThrowIfNotOnUIThread();
    //        var dte = (DTE2)ServiceProvider.GetServiceAsync(typeof(DTE)).Result;
    //        if(dte == null)
    //        {
    //            return;
    //        }

    //        try
    //        {

    //            var selectedFilePath = ItemManager.Instance.GetItems().ElementAt(1).FilePath;
    //            dte.ItemOperations.OpenFile(selectedFilePath);
    //        }
    //        catch (Exception ex) { }
    //    }
    //}

    [Command(PackageIds.SwitchToFile1)]
    internal sealed class SwitchFile1 : SwitchFileBase
    {
        public SwitchFile1(AsyncPackage package, OleMenuCommandService commandService)
            : base(package, commandService, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile1), 1)
        {
        }

        public static async Task InitializeAsync(AsyncPackage package)
        {
            await InitializeAsync(package, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile1), 1);
        }
    }
    [Command(PackageIds.SwitchToFile2)]
    internal sealed class SwitchFile2 : SwitchFileBase
    {
        public SwitchFile2(AsyncPackage package, OleMenuCommandService commandService)
            : base(package, commandService, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile2), 2)
        {
        }

        public static async Task InitializeAsync(AsyncPackage package)
        {
            await InitializeAsync(package, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile2), 2);
        }
    }
    [Command(PackageIds.SwitchToFile3)]
    internal sealed class SwitchFile3 : SwitchFileBase
    {
        public SwitchFile3(AsyncPackage package, OleMenuCommandService commandService)
            : base(package, commandService, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile3), 3)
        {
        }

        public static async Task InitializeAsync(AsyncPackage package)
        {
            await InitializeAsync(package, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile3), 3);
        }
    }

}
[Command(PackageIds.SwitchToFile4)]
internal sealed class SwitchFile4 : SwitchFileBase
{
    public SwitchFile4(AsyncPackage package, OleMenuCommandService commandService)
        : base(package, commandService, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile4), 4)
    {
    }

    public static async Task InitializeAsync(AsyncPackage package)
    {
        await InitializeAsync(package, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile4), 4);
    }
}

[Command(PackageIds.SwitchToFile5)]
internal sealed class SwitchFile5 : SwitchFileBase
{
    public SwitchFile5(AsyncPackage package, OleMenuCommandService commandService)
        : base(package, commandService, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile5), 5)
    {
    }

    public static async Task InitializeAsync(AsyncPackage package)
    {
        await InitializeAsync(package, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile5), 5);
    }
}

[Command(PackageIds.SwitchToFile6)]
internal sealed class SwitchFile6 : SwitchFileBase
{
    public SwitchFile6(AsyncPackage package, OleMenuCommandService commandService)
        : base(package, commandService, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile6), 6)
    {
    }

    public static async Task InitializeAsync(AsyncPackage package)
    {
        await InitializeAsync(package, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile6), 6);
    }
}

[Command(PackageIds.SwitchToFile7)]
internal sealed class SwitchFile7 : SwitchFileBase
{
    public SwitchFile7(AsyncPackage package, OleMenuCommandService commandService)
        : base(package, commandService, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile7), 7)
    {
    }

    public static async Task InitializeAsync(AsyncPackage package)
    {
        await InitializeAsync(package, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile7), 7);
    }
}

[Command(PackageIds.SwitchToFile8)]
internal sealed class SwitchFile8 : SwitchFileBase
{
    public SwitchFile8(AsyncPackage package, OleMenuCommandService commandService)
        : base(package, commandService, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile8), 8)
    {
    }

    public static async Task InitializeAsync(AsyncPackage package)
    {
        await InitializeAsync(package, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile8), 8);
    }
}

[Command(PackageIds.SwitchToFile9)]
internal sealed class SwitchFile9 : SwitchFileBase
{
    public SwitchFile9(AsyncPackage package, OleMenuCommandService commandService)
        : base(package, commandService, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile9), 9)
    {
    }

    public static async Task InitializeAsync(AsyncPackage package)
    {
        await InitializeAsync(package, new CommandID(PackageGuids.FastFileSwitcher, PackageIds.SwitchToFile9), 9);
    }
}

