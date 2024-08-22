using EnvDTE;
using EnvDTE80;
using FastFileSwitcher.Managers;
using FastFileSwitcher.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FastFileSwitcher.Commands
{
    [Command(PackageIds.DisplayFilesCommand)]
    internal sealed class FileDisplayer : BaseCommand
    {
        private readonly AsyncPackage _package;
        private FileDisplayer(AsyncPackage package, OleMenuCommandService commandService)
        {
            _package = package ?? throw new ArgumentNullException(nameof(package));

            var menuCommandID = new CommandID(PackageGuids.FastFileSwitcher, PackageIds.DisplayFilesCommand);
            var menuItem = new MenuCommand(Execute, menuCommandID);
            commandService.AddCommand(menuItem);

        }
        public static FileDisplayer Instance { get; private set; }

        private IAsyncServiceProvider ServiceProvider => _package;

        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in GetDocumentPathCommand's constructor requires it
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            var commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new FileDisplayer(package, commandService);
        }
        protected override void Execute(object sender, EventArgs e)
        {
            var dialog = new DisplayFiles(FileManager.Instance.GetItems());
            
            dialog.ShowDialog();
        }
    }
}
