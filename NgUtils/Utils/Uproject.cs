using System;
using System.IO;

namespace ngUtils.Utils
{
    class Uproject
    {
        // webpack configuration
        public static void GenerateProject(EnvDTE.Project project, string path)
        {
            string[] fileFullNames;         
            try
            {
                DirectoryInfo d = Directory.CreateDirectory(path + "/ClientApp");
                DirectoryInfo d1 = Directory.CreateDirectory(path + "/ClientApp/app");
                DirectoryInfo d2 = Directory.CreateDirectory(path + "/ClientApp/assets");
                DirectoryInfo d3 = Directory.CreateDirectory(path + "/ClientApp/config");

                CreateConfigFiles(project, path);

                CreateClientFiles(project, path + "\\ClientApp");

                fileFullNames = Directory.GetFiles(path + "\\ClientApp");

                project.ProjectItems.AddFromDirectory(d.FullName);
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

        public static void CreateConfigFiles(EnvDTE.Project project,string folderFullName)
        {
            //Fichier de configuration
            File.AppendAllText(Path.Combine(folderFullName, "package.json"), Utils.packageJson());
            project.ProjectItems.AddFromFile(Path.Combine(folderFullName, "package.json"));
 
            File.AppendAllText(Path.Combine(folderFullName, "webpack.config.js"), Utils.webpack());
            project.ProjectItems.AddFromFile(Path.Combine(folderFullName, "webpack.config.js"));

        }

        public static void CreateClientFiles(EnvDTE.Project project, string path)
        {
            //Main
            File.AppendAllText(Path.Combine(path, "main.ts"), Utils.maints());
            project.ProjectItems.AddFromFile(Path.Combine(path, "main.ts"));

            //tsconfig
            File.AppendAllText(Path.Combine(path, "tsconfig.json"), Utils.tsConfig());
            project.ProjectItems.AddFromFile(Path.Combine(path, "tsconfig.json"));


            //config
            File.AppendAllText(Path.Combine(path + "\\config", "environment.prod.ts"), Utils.envprod());
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\config", "environment.prod.ts"));

            File.AppendAllText(Path.Combine(path + "\\config", "environment.ts"), Utils.env());
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\config", "environment.ts"));

            File.AppendAllText(Path.Combine(path + "\\config", "index.html"), Utils.index(), System.Text.Encoding.UTF8);
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\config", "index.html"));

            File.AppendAllText(Path.Combine(path + "\\config", "polyfills.ts"), Utils.polyfills());
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\config", "polyfills.ts"));

            File.AppendAllText(Path.Combine(path + "\\config", "styles.css"), Utils.stylecss(), System.Text.Encoding.UTF8);
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\config", "styles.css"));

            File.AppendAllText(Path.Combine(path + "\\config", "typings.d.ts"), Utils.typing());
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\config", "typings.d.ts"));

          

           
            // app
            File.AppendAllText(Path.Combine(path + "\\app", "app.module.ts"), Utils.appmodule());
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\app", "app.module.ts"));
 
            Ufiles.GenerateComponent(project, path + "\\app\\components\\", "app");
            Ufiles.GenerateComponent(project, path + "\\app\\components\\", "navmenu");
            Ufiles.GenerateComponent(project, path + "\\app\\components\\", "about");
            Ufiles.GenerateComponent(project, path + "\\app\\components\\", "blog");
            Ufiles.GenerateComponent(project, path + "\\app\\components\\", "home");

            //assets
            File.AppendAllText(Path.Combine(path + "\\assets", "Index.cshtml"), Utils.indexHTML(), System.Text.Encoding.UTF8);
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\assets", "Index.cshtml"));

            File.AppendAllText(Path.Combine(path + "\\assets", "important.txt"), Utils.Important());
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\assets", "important.txt"));

        }

        // Angular-cli configuration

        public static void ngGenerateProject(EnvDTE.Project project, string path)
        {
            string[] fileFullNames;

            try
            {
                DirectoryInfo d = Directory.CreateDirectory(path + "/ClientApp");
                DirectoryInfo d1 = Directory.CreateDirectory(path + "/ClientApp/app");
                DirectoryInfo d2 = Directory.CreateDirectory(path + "/ClientApp/dist");
                DirectoryInfo d3 = Directory.CreateDirectory(path + "/ClientApp/environments");

                project.ProjectItems.AddFromDirectory(d.FullName);

                ngCreateConfigFiles(project, path);
                ngCreateClientFiles(project, path + "\\ClientApp");

                fileFullNames = Directory.GetFiles(path + "\\ClientApp");

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

        public static void ngCreateConfigFiles(EnvDTE.Project project, string folderFullName)
        {

            File.AppendAllText(Path.Combine(folderFullName, ".angular-cli.json"), Utils.ng_angularCli());
            project.ProjectItems.AddFromFile(Path.Combine(folderFullName, ".angular-cli.json"));

            File.AppendAllText(Path.Combine(folderFullName, "package.json"), Utils.ng_packageJson());
            project.ProjectItems.AddFromFile(Path.Combine(folderFullName, "package.json"));

            File.AppendAllText(Path.Combine(folderFullName, "tsconfig.json"), Utils.ng_tsConfig());
            project.ProjectItems.AddFromFile(Path.Combine(folderFullName, "tsconfig.json"));

            File.AppendAllText(Path.Combine(folderFullName, "tslint.json"), Utils.ng_tslint());
            project.ProjectItems.AddFromFile(Path.Combine(folderFullName, "tslint.json"));

            File.AppendAllText(Path.Combine(folderFullName, "important.txt"), Utils.Important());
            project.ProjectItems.AddFromFile(Path.Combine(folderFullName, "important.txt"));

        }

        public static void ngCreateClientFiles(EnvDTE.Project project, string path)
        {
            File.AppendAllText(Path.Combine(path, "index.html"), Utils.ng_index());
            project.ProjectItems.AddFromFile(Path.Combine(path, "index.html"));

            File.AppendAllText(Path.Combine(path, "main.ts"), Utils.ng_maints());
            project.ProjectItems.AddFromFile(Path.Combine(path, "main.ts"));

            File.AppendAllText(Path.Combine(path, "polyfills.ts"), Utils.ng_polyfills());
            project.ProjectItems.AddFromFile(Path.Combine(path, "polyfills.ts"));

            File.AppendAllText(Path.Combine(path, "tsconfig.app.json"), Utils.ng_tsconfigapp());
            project.ProjectItems.AddFromFile(Path.Combine(path, "tsconfig.app.json"));

            File.AppendAllText(Path.Combine(path, "typings.d.ts"), Utils.ng_typing());
            project.ProjectItems.AddFromFile(Path.Combine(path, "typings.d.ts"));



            File.AppendAllText(Path.Combine(path + "\\environments", "environment.prod.ts"), Utils.ng_envprod());
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\environments", "environment.prod.ts"));

            File.AppendAllText(Path.Combine(path + "\\environments", "environment.ts"), Utils.ng_env());
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\environments", "environment.ts"));



            /*********************************************/

            File.AppendAllText(Path.Combine(path + "\\app", "app.module.ts"), Utils.ng_appmodule());
            project.ProjectItems.AddFromFile(Path.Combine(path + "\\app", "app.module.ts"));

            Ufiles.GenerateComponent(project, path + "\\app\\components\\", "app");
            Ufiles.GenerateComponent(project, path + "\\app\\components\\", "navmenu");
            Ufiles.GenerateComponent(project, path + "\\app\\components\\", "about");
            Ufiles.GenerateComponent(project, path + "\\app\\components\\", "blog");
            Ufiles.GenerateComponent(project, path + "\\app\\components\\", "home");

        }

    }
}
