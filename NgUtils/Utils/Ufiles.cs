using NgUtils.Utils;
using System;
using System.IO;

namespace ngUtils.Utils
{
    class  Ufiles
    {
        //Creation d'un composant
        public static void GenerateComponent(EnvDTE.Project project, string path,string ngName)
        {
            var directoryName = path + ngName;
            string[] fileFullNames;
            try
            {
                DirectoryInfo d = Directory.CreateDirectory(directoryName);
                CreateFilesComponent(directoryName, ngName);
                fileFullNames = Directory.GetFiles(directoryName);

                foreach (string fileFullName in fileFullNames)
                {           
                    project.ProjectItems.AddFromFile(fileFullName);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        public static void CreateFilesComponent(string folderFullName, string ngName)
        {
            var componentName = ngName + ".component.ts";
            var templateName = ngName + ".component.html";
            var styleName = ngName + ".component.css";

            File.AppendAllText(Path.Combine(folderFullName, componentName), UClientApp.componentContent(ngName));
            File.AppendAllText(Path.Combine(folderFullName, templateName), UClientApp.componentTemplate(ngName), System.Text.Encoding.UTF8);
            File.AppendAllText(Path.Combine(folderFullName, styleName), UClientApp.componentStyle(ngName), System.Text.Encoding.UTF8);       
        }

        //Creation d'un Pipe
        public static void GeneratePipe(EnvDTE.Project project, string path, string ngName)
        {
            string[] fileFullNames;
            try
            {
                var componentName = ngName + ".pipe.ts";
                File.AppendAllText(Path.Combine(path, componentName), UClientApp.pipeContent(ngName));
                fileFullNames = Directory.GetFiles(path);

                foreach (string fileFullName in fileFullNames)
                {
                    project.ProjectItems.AddFromFile(fileFullName);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        //Creation d'un service
        public static void GenerateService(EnvDTE.Project project, string path, string ngName)
        {
            string[] fileFullNames;
            try
            {
                var componentName = ngName + ".service.ts";
                File.AppendAllText(Path.Combine(path, componentName), UClientApp.serviceContent(ngName));
                fileFullNames = Directory.GetFiles(path);

                foreach (string fileFullName in fileFullNames)
                {
                    project.ProjectItems.AddFromFile(fileFullName);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        //Creation d'une Directive
        public static void GenerateDirective(EnvDTE.Project project, string path, string ngName)
        {
            string[] fileFullNames;
            try
            {
                var componentName = ngName + ".directive.ts";
                File.AppendAllText(Path.Combine(path, componentName), UClientApp.directiveContent(ngName));
                fileFullNames = Directory.GetFiles(path);

                foreach (string fileFullName in fileFullNames)
                {
                    project.ProjectItems.AddFromFile(fileFullName);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        // Creation d'un Module
        public static void GenerateModule(EnvDTE.Project project, string path, string ngName)
        {
            string[] fileFullNames;
            try
            {
                GenerateComponent(project, path, ngName);

                var componentName = ngName + ".module.ts";
                File.AppendAllText(Path.Combine(path+ngName, componentName), UClientApp.moduleContent(ngName));

                var routingtName = ngName + ".routing.ts";
                File.AppendAllText(Path.Combine(path+ngName, routingtName), UClientApp.routingContent(ngName));

                fileFullNames = Directory.GetFiles(path+ ngName);

                foreach (string fileFullName in fileFullNames)
                {
                    project.ProjectItems.AddFromFile(fileFullName);
                }       
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

    }
}
