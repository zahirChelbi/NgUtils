using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using EnvDTE;
using EnvDTE80;
using System.Windows.Forms;

using ngUtils.Utils;

namespace ngUtils
{
    internal sealed class Commands
    {
        public const int CommandId = 0x0100;
        public const int CommandId1 = 0x0200;
        public const int CommandId2 = 0x0300;
        public const int CommandId3 = 0x0350;
        public const int CommandId4 = 0x0360;
        public const int CommandIdPC = 0x0400;
        public const int CommandIdP = 0x0500;
        public static readonly Guid CommandSet = new Guid("9865f3c9-4e8f-474b-a2ff-70bcfd17d663");
        private readonly Package package;


        private Commands(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new MenuCommand(this.MenuItemCallbackComponent, menuCommandID);
                commandService.AddCommand(menuItem);

                var menuCommandID1 = new CommandID(CommandSet, CommandId1);
                var menuItem1 = new MenuCommand(this.MenuItemCallbackService, menuCommandID1);
                commandService.AddCommand(menuItem1);

                var menuCommandID2 = new CommandID(CommandSet, CommandId2);
                var menuItem2 = new MenuCommand(this.MenuItemCallbackPipe, menuCommandID2);
                commandService.AddCommand(menuItem2);

                var menuCommandID3 = new CommandID(CommandSet, CommandId3);
                var menuItem3 = new MenuCommand(this.MenuItemCallbackDirective, menuCommandID3);
                commandService.AddCommand(menuItem3);

                var menuCommandID4 = new CommandID(CommandSet, CommandId4);
                var menuItem4 = new MenuCommand(this.MenuItemCallbackModule, menuCommandID4);
                commandService.AddCommand(menuItem4);



                var menuCommandIDP = new CommandID(CommandSet, CommandIdP);
                var menuItemP = new MenuCommand(this.MenuItemCallbackProjectWebpack, menuCommandIDP);
                commandService.AddCommand(menuItemP);

                var menuCommandIDPC = new CommandID(CommandSet, CommandIdPC);
                var menuItemPC = new MenuCommand(this.MenuItemCallbackProjectCli, menuCommandIDPC);
                commandService.AddCommand(menuItemPC);
            }
        }
        public static Commands Instance
        {
            get;
            private set;
        }
        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }
        public static void Initialize(Package package)
        {
            Instance = new Commands(package);
        }




        private void MenuItemCallbackComponent(object sender, EventArgs e)
        {

            Project p = GetActiveProject();
            string path = System.IO.Path.GetDirectoryName(p.FullName);


            string title = "créer un composant";
            string errorMsg = "Le nom est vide";
            string chaine = this.GetSourceFilePath(GetDTE2());


            string text = this.ShowDialog();

            if (text.Trim() == "")
            {
                // Show a message box to prove we were here
                VsShellUtilities.ShowMessageBox(
                    this.ServiceProvider,
                    errorMsg,
                    title,
                    OLEMSGICON.OLEMSGICON_INFO,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
            }
            else
            {
                Ufiles.GenerateComponent(p, chaine, text);
            }


        }
        private void MenuItemCallbackService(object sender, EventArgs e)
        {
            Project p = GetActiveProject();
            string path = System.IO.Path.GetDirectoryName(p.FullName);

            string title = "créer un service";
            string errorMsg = "Le nom est vide";
            string chaine = this.GetSourceFilePath(GetDTE2());
            string text = this.ShowDialog();
            if (text.Trim() == "")
            {
                // Show a message box to prove we were here
                VsShellUtilities.ShowMessageBox(
                    this.ServiceProvider,
                    errorMsg,
                    title,
                    OLEMSGICON.OLEMSGICON_INFO,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
            }
            else
            {
                Ufiles.GenerateService(p, chaine, text);
            }
        }
        private void MenuItemCallbackPipe(object sender, EventArgs e)
        {

            Project p = GetActiveProject();
            string path = System.IO.Path.GetDirectoryName(p.FullName);

            string title = "créer un pipe";
            string errorMsg = "Le nom est vide";
            string chaine = this.GetSourceFilePath(GetDTE2());


            string text = this.ShowDialog();

            if (text.Trim() == "")
            {
                // Show a message box to prove we were here
                VsShellUtilities.ShowMessageBox(
                    this.ServiceProvider,
                    errorMsg,
                    title,
                    OLEMSGICON.OLEMSGICON_INFO,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
            }
            else
            {
                Ufiles.GeneratePipe(p, chaine, text);
            }



        }
        private void MenuItemCallbackDirective(object sender, EventArgs e)
        {

            Project p = GetActiveProject();
            string path = System.IO.Path.GetDirectoryName(p.FullName);

            string title = "créer une Directive";
            string errorMsg = "Le nom est vide";
            string chaine = this.GetSourceFilePath(GetDTE2());


            string text = this.ShowDialog();

            if (text.Trim() == "")
            {
                // Show a message box to prove we were here
                VsShellUtilities.ShowMessageBox(
                    this.ServiceProvider,
                    errorMsg,
                    title,
                    OLEMSGICON.OLEMSGICON_INFO,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
            }
            else
            {
                Ufiles.GenerateDirective(p, chaine, text);
            }



        }
        private void MenuItemCallbackModule(object sender, EventArgs e)
        {

            Project p = GetActiveProject();
            string path = System.IO.Path.GetDirectoryName(p.FullName);

            string title = "créer un Module";
            string errorMsg = "Le nom est vide";
            string chaine = this.GetSourceFilePath(GetDTE2());


            string text = this.ShowDialog();

            if (text.Trim() == "")
            {
                // Show a message box to prove we were here
                VsShellUtilities.ShowMessageBox(
                    this.ServiceProvider,
                    errorMsg,
                    title,
                    OLEMSGICON.OLEMSGICON_INFO,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
            }
            else
            {
                Ufiles.GenerateModule(p, chaine, text);
            }



        }




        private void MenuItemCallbackProjectWebpack(object sender, EventArgs e)
        {
            Project p = GetActiveProject();
            string path = System.IO.Path.GetDirectoryName(p.FullName);

            Uproject.GenerateProject(p, path);

            VsShellUtilities.ShowMessageBox(
                    this.ServiceProvider,
                    "Angular Projet webpack",
                    "success",
                    OLEMSGICON.OLEMSGICON_INFO,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        }
        private void MenuItemCallbackProjectCli(object sender, EventArgs e)
        {
            Project p = GetActiveProject();
            string path = System.IO.Path.GetDirectoryName(p.FullName);

            Uproject.ngGenerateProject(p, path);

            VsShellUtilities.ShowMessageBox(
                    this.ServiceProvider,
                    "Angular Projet",
                    "success",
                    OLEMSGICON.OLEMSGICON_INFO,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        }



        //////////////
        private DTE2 GetDTE2()
        {
            DTE vs = (DTE)ServiceProvider.GetService(typeof(DTE));
            return vs as EnvDTE80.DTE2;
        }
        private string GetSourceFilePath(DTE2 dte)
        {
            DTE2 _applicationObject = dte;
            UIHierarchy uih = _applicationObject.ToolWindows.SolutionExplorer;

            Array selectedItems = (Array)uih.SelectedItems;
            if (null != selectedItems)
            {
                foreach (UIHierarchyItem selItem in selectedItems)
                {
                    ProjectItem prjItem = selItem.Object as ProjectItem;
                    string filePath = prjItem.Properties.Item("FullPath").Value.ToString();
                    //System.Windows.Forms.MessageBox.Show(selItem.Name + filePath);
                    return filePath;
                }
            }
            return string.Empty;
        }
        private string GetselectedProject(DTE2 dte)
        {
            DTE2 _applicationObject = dte;
            UIHierarchy uih = _applicationObject.ToolWindows.SolutionExplorer;
            Array selectedItems = (Array)uih.SelectedItems;
            if (null != selectedItems)
            {
                foreach (UIHierarchyItem selItem in selectedItems)
                {
                    ProjectItem prjItem = selItem.Object as ProjectItem;
                    string filePath = prjItem.Properties.Item("FullPath").Value.ToString();
                    //System.Windows.Forms.MessageBox.Show(selItem.Name + filePath);
                    return filePath;
                }
            }
            return string.Empty;
        }

        public string ShowDialog()
        {
            Form prompt = new Form()
            {
                Width = 350,
                Height = 100,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "ngComponent",
                StartPosition = FormStartPosition.CenterScreen
            };
            TextBox textBox = new TextBox() { Left = 20, Top = 10, Width = 300 };
            Button confirmation = new Button() { Text = "Ok", Left = 20, Width = 100, Top = 35, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        /// <returns></returns>
        internal static Project GetActiveProject()
        {
            DTE dte = Package.GetGlobalService(typeof(SDTE)) as DTE;
            Project activeProject = null;
            Array activeSolutionProjects = dte.ActiveSolutionProjects as Array;
            if (activeSolutionProjects != null && activeSolutionProjects.Length > 0)
            {
                activeProject = activeSolutionProjects.GetValue(0) as Project;
            }
            return activeProject;
        }
    }
}

