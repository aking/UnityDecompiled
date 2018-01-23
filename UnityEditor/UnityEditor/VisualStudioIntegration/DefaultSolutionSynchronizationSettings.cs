﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.VisualStudioIntegration.DefaultSolutionSynchronizationSettings
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

namespace UnityEditor.VisualStudioIntegration
{
  internal class DefaultSolutionSynchronizationSettings : ISolutionSynchronizationSettings
  {
    public virtual int VisualStudioVersion
    {
      get
      {
        return 9;
      }
    }

    public virtual string SolutionTemplate
    {
      get
      {
        return string.Join("\r\n", new string[18]{ "", "Microsoft Visual Studio Solution File, Format Version {0}", "# Visual Studio {1}", "{2}", "Global", "    GlobalSection(SolutionConfigurationPlatforms) = preSolution", "        Debug|Any CPU = Debug|Any CPU", "        Release|Any CPU = Release|Any CPU", "    EndGlobalSection", "    GlobalSection(ProjectConfigurationPlatforms) = postSolution", "{3}", "    EndGlobalSection", "    GlobalSection(SolutionProperties) = preSolution", "        HideSolutionNode = FALSE", "    EndGlobalSection", "{4}", "EndGlobal", "" }).Replace("    ", "\t");
      }
    }

    public virtual string SolutionProjectEntryTemplate
    {
      get
      {
        return string.Join("\r\n", new string[2]{ "Project(\"{{{0}}}\") = \"{1}\", \"{2}\", \"{{{3}}}\"", "EndProject" }).Replace("    ", "\t");
      }
    }

    public virtual string SolutionProjectConfigurationTemplate
    {
      get
      {
        return string.Join("\r\n", new string[4]{ "        {{{0}}}.Debug|Any CPU.ActiveCfg = Debug|Any CPU", "        {{{0}}}.Debug|Any CPU.Build.0 = Debug|Any CPU", "        {{{0}}}.Release|Any CPU.ActiveCfg = Release|Any CPU", "        {{{0}}}.Release|Any CPU.Build.0 = Release|Any CPU" }).Replace("    ", "\t");
      }
    }

    public virtual string GetProjectHeaderTemplate(ScriptingLanguage language)
    {
      return string.Join("\r\n", new string[54]{ "<?xml version=\"1.0\" encoding=\"utf-8\"?>", "<Project ToolsVersion=\"{0}\" DefaultTargets=\"Build\" xmlns=\"{6}\">", "  <PropertyGroup>", "    <LangVersion>{10}</LangVersion>", "  </PropertyGroup>", "  <PropertyGroup>", "    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>", "    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>", "    <ProductVersion>{1}</ProductVersion>", "    <SchemaVersion>2.0</SchemaVersion>", "    <RootNamespace>{8}</RootNamespace>", "    <ProjectGuid>{{{2}}}</ProjectGuid>", "    <OutputType>Library</OutputType>", "    <AppDesignerFolder>Properties</AppDesignerFolder>", "    <AssemblyName>{7}</AssemblyName>", "    <TargetFrameworkVersion>{9}</TargetFrameworkVersion>", "    <FileAlignment>512</FileAlignment>", "    <BaseDirectory>Assets</BaseDirectory>", "  </PropertyGroup>", "  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' \">", "    <DebugSymbols>true</DebugSymbols>", "    <DebugType>full</DebugType>", "    <Optimize>false</Optimize>", "    <OutputPath>Temp\\bin\\Debug\\</OutputPath>", "    <DefineConstants>{5}</DefineConstants>", "    <ErrorReport>prompt</ErrorReport>", "    <WarningLevel>4</WarningLevel>", "    <NoWarn>0169</NoWarn>", "    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>", "  </PropertyGroup>", "  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' \">", "    <DebugType>pdbonly</DebugType>", "    <Optimize>true</Optimize>", "    <OutputPath>Temp\\bin\\Release\\</OutputPath>", "    <ErrorReport>prompt</ErrorReport>", "    <WarningLevel>4</WarningLevel>", "    <NoWarn>0169</NoWarn>", "    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>", "  </PropertyGroup>", "  <ItemGroup>", "    <Reference Include=\"System\" />", "    <Reference Include=\"System.XML\" />", "    <Reference Include=\"System.Core\" />", "    <Reference Include=\"System.Runtime.Serialization\" />", "    <Reference Include=\"System.Xml.Linq\" />", "    <Reference Include=\"UnityEngine\">", "      <HintPath>{3}</HintPath>", "    </Reference>", "    <Reference Include=\"UnityEditor\">", "      <HintPath>{4}</HintPath>", "    </Reference>", "  </ItemGroup>", "  <ItemGroup>", "" });
    }

    public virtual string GetProjectFooterTemplate(ScriptingLanguage language)
    {
      return string.Join("\r\n", new string[12]{ "  </ItemGroup>", "  <Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />", "  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. ", "       Other similar extension points exist, see Microsoft.Common.targets.", "  <Target Name=\"BeforeBuild\">", "  </Target>", "  <Target Name=\"AfterBuild\">", "  </Target>", "  -->", "  {0}", "</Project>", "" });
    }

    public virtual string EditorAssemblyPath
    {
      get
      {
        return "/Managed/UnityEditor.dll";
      }
    }

    public virtual string EngineAssemblyPath
    {
      get
      {
        return "/Managed/UnityEngine.dll";
      }
    }

    public virtual string MonoLibFolder
    {
      get
      {
        return this.FrameworksPath() + "/Mono/lib/mono/unity/";
      }
    }

    public virtual string[] Defines
    {
      get
      {
        return new string[0];
      }
    }

    protected virtual string FrameworksPath()
    {
      return string.Empty;
    }
  }
}