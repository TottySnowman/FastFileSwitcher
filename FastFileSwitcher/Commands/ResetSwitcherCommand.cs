using EnvDTE;
using EnvDTE80;
using FastFileSwitcher.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFileSwitcher.Commands
{
    [Command(PackageIds.ResetSwitcherCommand)]
    internal sealed class ResetSwitcherCommand : BaseCommand
    {

        private readonly AsyncPackage _package;
        private ResetSwitcherCommand(AsyncPackage package, OleMenuCommandService commandService)
        {
            _package = package ?? throw new ArgumentNullException(nameof(package));

            var menuCommandID = new CommandID(PackageGuids.FastFileSwitcher, PackageIds.ResetSwitcherCommand);
            var menuItem = new MenuCommand(Execute, menuCommandID);
            commandService.AddCommand(menuItem);
        }
        public static ResetSwitcherCommand Instance { get; private set; }

        private IAsyncServiceProvider ServiceProvider => _package;

        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in GetDocumentPathCommand's constructor requires it
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            var commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new ResetSwitcherCommand(package, commandService);
        }

        protected override void Execute(object sender, EventArgs e)
        {

            ThreadHelper.ThrowIfNotOnUIThread();

            var dte = (DTE2)ServiceProvider.GetServiceAsync(typeof(DTE)).Result;
            if (dte == null)
            {
                return;
            }
            FileManager.Instance.ResetList();
            dte.StatusBar.Text = "Successfully reseted the switcher!";
        }
    }
}
