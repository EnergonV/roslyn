﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Xml.Linq;
using Microsoft.CodeAnalysis.Shared.TestHooks;
using Microsoft.VisualStudio.IntegrationTest.Utilities.InProcess;
using ProjectUtils = Microsoft.VisualStudio.IntegrationTest.Utilities.Common.ProjectUtils;

namespace Microsoft.VisualStudio.IntegrationTest.Utilities.OutOfProcess
{
    public class SolutionExplorer_OutOfProc : OutOfProcComponent
    {
        private readonly SolutionExplorer_InProc _inProc;
        private readonly VisualStudioInstance _instance;

        public SolutionExplorer_OutOfProc(VisualStudioInstance visualStudioInstance)
            : base(visualStudioInstance)
        {
            _instance = visualStudioInstance;
            _inProc = CreateInProcComponent<SolutionExplorer_InProc>(visualStudioInstance);
        }

        public string DirectoryName
            => _inProc.DirectoryName;

        public void CloseSolution(bool saveFirst = false)
            => _inProc.CloseSolution(saveFirst);

        /// <summary>
        /// Creates and loads a new solution in the host process, optionally saving the existing solution if one exists.
        /// </summary>
        public void CreateSolution(string solutionName, bool saveExistingSolutionIfExists = false)
            => _inProc.CreateSolution(solutionName, saveExistingSolutionIfExists);

        public void CreateSolution(string solutionName, XElement solutionElement)
            => _inProc.CreateSolution(solutionName, solutionElement.ToString());

        public void AddProject(ProjectUtils.Project projectName, string projectTemplate, string languageName)
        {
            _inProc.AddProject(projectName.Name, projectTemplate, languageName);
            _instance.Workspace.WaitForAsyncOperations(Helper.HangMitigatingTimeout, FeatureAttribute.Workspace);
        }

        public void AddProjectReference(ProjectUtils.Project fromProjectName, ProjectUtils.ProjectReference toProjectName)
        {
            _inProc.AddProjectReference(fromProjectName.Name, toProjectName.Name);
            _instance.Workspace.WaitForAsyncOperations(Helper.HangMitigatingTimeout, FeatureAttribute.Workspace);
        }

        public void RemoveProjectReference(ProjectUtils.Project projectName, ProjectUtils.ProjectReference projectReferenceName)
        {
            _inProc.RemoveProjectReference(projectName.Name, projectReferenceName.Name);
            _instance.Workspace.WaitForAsyncOperations(Helper.HangMitigatingTimeout, FeatureAttribute.Workspace);
        }

        public void AddMetadataReference(ProjectUtils.AssemblyReference fullyQualifiedAssemblyName, ProjectUtils.Project projectName)
        {
            _inProc.AddMetadataReference(fullyQualifiedAssemblyName.Name, projectName.Name);
            _instance.Workspace.WaitForAsyncOperations(Helper.HangMitigatingTimeout, FeatureAttribute.Workspace);
        }

        public void RemoveMetadataReference(ProjectUtils.AssemblyReference assemblyName, ProjectUtils.Project projectName)
        {
            _inProc.RemoveMetadataReference(assemblyName.Name, projectName.Name);
            _instance.Workspace.WaitForAsyncOperations(Helper.HangMitigatingTimeout, FeatureAttribute.Workspace);
        }

        public void AddAnalyzerReference(string filePath, ProjectUtils.Project projectName)
        {
            _inProc.AddAnalyzerReference(filePath, projectName.Name);
            _instance.Workspace.WaitForAsyncOperations(Helper.HangMitigatingTimeout, FeatureAttribute.Workspace);
        }

        public void CleanUpOpenSolution()
            => _inProc.CleanUpOpenSolution();

        public void AddFile(ProjectUtils.Project project, string fileName, string? contents = null, bool open = false)
            => _inProc.AddFile(project.Name, fileName, contents, open);

        public void SetFileContents(ProjectUtils.Project project, string fileName, string contents)
            => _inProc.SetFileContents(project.Name, fileName, contents);

        public string GetFileContents(ProjectUtils.Project project, string fileName)
            => _inProc.GetFileContents(project.Name, fileName);

        public void BuildSolution()
            => _inProc.BuildSolution();

        public void OpenFileWithDesigner(ProjectUtils.Project project, string fileName)
            => _inProc.OpenFileWithDesigner(project.Name, fileName);

        public void OpenFile(ProjectUtils.Project project, string fileName)
        {
            // Wireup to open files can happen asynchronously in the case we're being notified of changes on background threads.
            _inProc.OpenFile(project.Name, fileName);
            _instance.Workspace.WaitForAsyncOperations(Helper.HangMitigatingTimeout, FeatureAttribute.Workspace);
        }

        public void RenameFile(ProjectUtils.Project project, string oldFileName, string newFileName)
        {
            // Wireup to open files can happen asynchronously in the case we're being notified of changes on background threads.
            _inProc.RenameFile(project.Name, oldFileName, newFileName);
            _instance.Workspace.WaitForAsyncOperations(Helper.HangMitigatingTimeout, FeatureAttribute.Workspace);
        }

        public void RenameFileViaDTE(ProjectUtils.Project project, string oldFileName, string newFileName)
        {
            // Wireup to open files can happen asynchronously in the case we're being notified of changes on background threads.
            _inProc.RenameFileViaDTE(project.Name, oldFileName, newFileName);
            _instance.Workspace.WaitForAsyncOperations(Helper.HangMitigatingTimeout, FeatureAttribute.Workspace);
        }

        public void CloseDesignerFile(ProjectUtils.Project project, string fileName, bool saveFile)
            => _inProc.CloseDesignerFile(project.Name, fileName, saveFile);

        public void CloseCodeFile(ProjectUtils.Project project, string fileName, bool saveFile)
            => _inProc.CloseCodeFile(project.Name, fileName, saveFile);

        public void SaveFile(ProjectUtils.Project project, string fileName)
            => _inProc.SaveFile(project.Name, fileName);

        public void RestoreNuGetPackages(ProjectUtils.Project project)
            => _inProc.RestoreNuGetPackages(project.Name);

        public void SaveAll()
        {
            _inProc.SaveAll();

            // Wait for async save operations to complete before proceeding
            _instance.Workspace.WaitForAsyncOperations(Helper.HangMitigatingTimeout, FeatureAttribute.Workspace);
        }

        /// <summary>
        /// Selects an item named by the <paramref name="itemName"/> parameter.
        /// Note that this selects the first item of the given name found. In situations where
        /// there may be more than one item of a given name, use <see cref="SelectItemAtPath(string[])"/>
        /// instead.
        /// </summary>
        public void SelectItem(string itemName)
            => _inProc.SelectItem(itemName);

        /// <summary>
        /// Selects the specific item at the given "path".
        /// </summary>
        public void SelectItemAtPath(params string[] path)
            => _inProc.SelectItemAtPath(path);

        public void EditProjectFile(ProjectUtils.Project project)
            => _inProc.EditProjectFile(project.Name);

        public void AddStandaloneFile(string fileName)
            => _inProc.AddStandaloneFile(fileName);
    }
}
