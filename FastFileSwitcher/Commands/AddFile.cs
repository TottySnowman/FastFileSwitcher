using EnvDTE;
using EnvDTE80;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System;
using Microsoft.VisualStudio.Shell;
using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell.Interop;
using FastFileSwitcher.Models;
using FastFileSwitcher.Managers;

namespace FastFileSwitcher.Commands
{
    [Command(PackageIds.AddFileCommand)]
    internal sealed class AddFileCommand : BaseCommand
    {
        private readonly AsyncPackage _package;
        private AddFileCommand(AsyncPackage package, OleMenuCommandService commandService)
        {
            _package = package ?? throw new ArgumentNullException(nameof(package));

            var menuCommandID = new CommandID(PackageGuids.FastFileSwitcher, PackageIds.AddFileCommand);
            var menuItem = new MenuCommand(Execute, menuCommandID);
            commandService.AddCommand(menuItem);
        }
        public static AddFileCommand Instance { get; private set; }

        private IAsyncServiceProvider ServiceProvider => _package;

        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in GetDocumentPathCommand's constructor requires it
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            var commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new AddFileCommand(package, commandService);
        }



        protected override void Execute(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            var dte = (DTE2)ServiceProvider.GetServiceAsync(typeof(DTE)).Result;
            if (dte == null)
            {
                return;
            }
            if (dte != null && dte.ActiveDocument != null)
            {
                string path = dte.ActiveDocument.FullName;
                string fileName = path.Split('\\').Last();
                var switchCount = FileManager.Instance.GetItems().Count();
               
                var existingPath = FileManager.Instance.GetItems().ToList().FindIndex(file => file.FilePath == path);
                if (existingPath != -1)
                {
                    dte.StatusBar.Text = @$"File is already in switcher on slot {existingPath + 1}";
                    return;
                }
                if (switchCount == 9)
                {
                    dte.StatusBar.Text = @$"Switcher is full! Please delete some files!";
                    return;
                }
                FileManager.Instance.AddItem(new File() { FilePath = path, FileName = fileName, Index = switchCount + 1 });

                dte.StatusBar.Text = @$"Successfully added to Swicher, slot {switchCount + 1}";
            }
            else
            {
                dte.StatusBar.Text = "No document open";
            }
        }
    }
}
