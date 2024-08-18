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
    internal abstract class SwitchFileBase : BaseCommand
    {
        protected readonly AsyncPackage _package;
        private readonly int _fileIndex;

        protected SwitchFileBase(AsyncPackage package, OleMenuCommandService commandService, CommandID commandID, int fileIndex)
        {
            _package = package ?? throw new ArgumentNullException(nameof(package));
            _fileIndex = fileIndex;

            var menuItem = new MenuCommand(Execute, commandID);
            commandService.AddCommand(menuItem);
        }

        public static SwitchFileBase Instance { get; private set; }


        private IAsyncServiceProvider ServiceProvider => _package;

        public static async Task InitializeAsync(AsyncPackage package, CommandID commandID, int fileIndex)
        {
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            var commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = CreateInstance(package, commandService, commandID, fileIndex);
        }


        private static SwitchFileBase CreateInstance(AsyncPackage package, OleMenuCommandService commandService, CommandID commandID, int fileIndex)
        {
            // Create the appropriate subclass instance based on file index
            return fileIndex switch
            {
                1 => new SwitchFile1(package, commandService),
                2 => new SwitchFile2(package, commandService),
                3 => new SwitchFile3(package, commandService),
                4 => new SwitchFile4(package, commandService),
                5 => new SwitchFile5(package, commandService),
                6 => new SwitchFile6(package, commandService),
                7 => new SwitchFile7(package, commandService),
                8 => new SwitchFile8(package, commandService),
                9 => new SwitchFile9(package, commandService),
                // Add cases for other file indices
                _ => throw new ArgumentOutOfRangeException(nameof(fileIndex)),
            };
        }

        protected override void Execute(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            var dte = (DTE2)ServiceProvider.GetServiceAsync(typeof(DTE)).Result;
            if (dte == null)
            {
                return;
            }

            try
            {
                var selectedFilePath = FileManager.Instance.GetItems().ElementAt(_fileIndex - 1).FilePath;
                dte.ItemOperations.OpenFile(selectedFilePath);
            }
            catch (Exception ex) { }
        }
    }
}
