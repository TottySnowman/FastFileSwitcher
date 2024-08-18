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

