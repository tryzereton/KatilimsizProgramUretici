using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KatilimsizProgramUretici
{
   public class CsprojOlustur
    {
        public void csprojOlustur(string programAdi,string ciktiDizini)
        {

            Form1 getir = new Form1();
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\OrnekProje.csproj");
            try
            {
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>" + sw.NewLine +
     "<Project ToolsVersion=\"12.0\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">" + sw.NewLine +
      " <Import Project=\"$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props\" Condition=\"Exists('$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props')\" />" + sw.NewLine +
       "<PropertyGroup>" + sw.NewLine +
       "  <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>" + sw.NewLine +
       "  <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>" + sw.NewLine +
       "  <ProjectGuid>{B5C65D25-8D49-431E-894F-088745B0DE83}</ProjectGuid>" + sw.NewLine +
       "  <OutputType>WinExe</OutputType>" + sw.NewLine +
       "  <AppDesignerFolder>Properties</AppDesignerFolder>" + sw.NewLine +
       "  <RootNamespace>OrnekProje</RootNamespace>" + sw.NewLine +
       "  <AssemblyName>" + programAdi.Trim() + "_katilimsiz" + "</AssemblyName>" + sw.NewLine +
       "  <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>" + sw.NewLine +
       "  <FileAlignment>512</FileAlignment>" + sw.NewLine +
       "  <PublishUrl>publish\\</PublishUrl>" + sw.NewLine +
       "  <Install>true</Install>" + sw.NewLine +
       "  <InstallFrom>Disk</InstallFrom>" + sw.NewLine +
       "  <UpdateEnabled>false</UpdateEnabled>" + sw.NewLine +
       "  <UpdateMode>Foreground</UpdateMode>" + sw.NewLine +
       "  <UpdateInterval>7</UpdateInterval>" + sw.NewLine +
       "  <UpdateIntervalUnits>Days</UpdateIntervalUnits>" + sw.NewLine +
       "  <UpdatePeriodically>false</UpdatePeriodically>" + sw.NewLine +
       "  <UpdateRequired>false</UpdateRequired>" + sw.NewLine +
       "  <MapFileExtensions>true</MapFileExtensions>" + sw.NewLine +
       "  <ApplicationRevision>0</ApplicationRevision>" + sw.NewLine +
       "  <ApplicationVersion>1.0.0.%2a</ApplicationVersion>" + sw.NewLine +
       "  <IsWebBootstrapper>false</IsWebBootstrapper>" + sw.NewLine +
       "  <UseApplicationTrust>false</UseApplicationTrust>" + sw.NewLine +
       "  <BootstrapperEnabled>true</BootstrapperEnabled>" + sw.NewLine +
       "</PropertyGroup>" + sw.NewLine +
       "<PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' \">" + sw.NewLine +
       "  <PlatformTarget>AnyCPU</PlatformTarget>" + sw.NewLine +
       "  <DebugSymbols>true</DebugSymbols>" + sw.NewLine +
       "  <DebugType>full</DebugType>" + sw.NewLine +
       "  <Optimize>false</Optimize>" + sw.NewLine +
       "  <OutputPath>" + Properties.Settings.Default.cikti + "</OutputPath>" + sw.NewLine +
       "  <DefineConstants>DEBUG;TRACE</DefineConstants>" + sw.NewLine +
       "  <ErrorReport>prompt</ErrorReport>" + sw.NewLine +
       "  <WarningLevel>4</WarningLevel>" + sw.NewLine +
       "</PropertyGroup>" + sw.NewLine +
       "<PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' \">" + sw.NewLine +
       "  <PlatformTarget>AnyCPU</PlatformTarget>" + sw.NewLine +
       "  <DebugType>pdbonly</DebugType>" + sw.NewLine +
       "  <Optimize>true</Optimize>" + sw.NewLine +
       "  <OutputPath>" + Properties.Settings.Default.cikti + "</OutputPath>" + sw.NewLine +
       "  <DefineConstants>TRACE</DefineConstants>" + sw.NewLine +
       "  <ErrorReport>prompt</ErrorReport>" + sw.NewLine +
       "  <WarningLevel>4</WarningLevel>" + sw.NewLine +
       "</PropertyGroup>" + sw.NewLine +
       "<PropertyGroup>" + sw.NewLine +
       "  <SignManifests>true</SignManifests>" + sw.NewLine +
       "</PropertyGroup>" + sw.NewLine +
       "<PropertyGroup>" + sw.NewLine +
       "  <ManifestCertificateThumbprint>4E7052430893108E1F94CC7BA83D92BEBE5C3ABF</ManifestCertificateThumbprint>" + sw.NewLine +
       "</PropertyGroup>" + sw.NewLine +
       "<PropertyGroup>" + sw.NewLine +
       "</PropertyGroup>" + sw.NewLine +
       "<PropertyGroup>" + sw.NewLine +
       "  <ApplicationManifest>app.manifest</ApplicationManifest>" + sw.NewLine +
       "</PropertyGroup>" + sw.NewLine +
       "<ItemGroup>" + sw.NewLine +
       "  <Reference Include=\"System\" />" + sw.NewLine +
       "  <Reference Include=\"System.Core\" />" + sw.NewLine +
       "  <Reference Include=\"System.Xml.Linq\" />" + sw.NewLine +
       "  <Reference Include=\"System.Data.DataSetExtensions\" />" + sw.NewLine +
       "  <Reference Include=\"System.Data\" />" + sw.NewLine +
       "  <Reference Include=\"System.Deployment\" />" + sw.NewLine +
       "  <Reference Include=\"System.Drawing\" />" + sw.NewLine +
       "  <Reference Include=\"System.Windows.Forms\" />" + sw.NewLine +
       "  <Reference Include=\"System.Xml\" />" + sw.NewLine +
       "</ItemGroup>" + sw.NewLine +
       "<ItemGroup>" + sw.NewLine +
       "  <Compile Include=\"Form1.cs\">" + sw.NewLine +
       "    <SubType>Form</SubType>" + sw.NewLine +
       "  </Compile>" + sw.NewLine +
       "  <Compile Include=\"Form1.Designer.cs\">" + sw.NewLine +
       "    <DependentUpon>Form1.cs</DependentUpon>" + sw.NewLine +
       "  </Compile>" + sw.NewLine +
       "  <Compile Include=\"Program.cs\" />" + sw.NewLine +
       "  <Compile Include=\"Properties\\AssemblyInfo.cs\" />" + sw.NewLine +
       "  <EmbeddedResource Include=\"Form1.resx\">" + sw.NewLine +
       "    <DependentUpon>Form1.cs</DependentUpon>" + sw.NewLine +
       "  </EmbeddedResource>" + sw.NewLine +
       "  <EmbeddedResource Include=\"Properties\\Resources.resx\">" + sw.NewLine +
       "    <Generator>ResXFileCodeGenerator</Generator>" + sw.NewLine +
       "    <LastGenOutput>Resources.Designer.cs</LastGenOutput>" + sw.NewLine +
       "    <SubType>Designer</SubType>" + sw.NewLine +
       "  </EmbeddedResource>" + sw.NewLine +
       "  <Compile Include=\"Properties\\Resources.Designer.cs\">" + sw.NewLine +
       "    <AutoGen>True</AutoGen>" + sw.NewLine +
       "    <DependentUpon>Resources.resx</DependentUpon>" + sw.NewLine +
       "    <DesignTime>True</DesignTime>" + sw.NewLine +
       "  </Compile>" + sw.NewLine +
       "  <None Include=\"app.manifest\" />" + sw.NewLine +
       "  <None Include=\"Properties\\Settings.settings\">" + sw.NewLine +
       "    <Generator>SettingsSingleFileGenerator</Generator>" + sw.NewLine +
       "    <LastGenOutput>Settings.Designer.cs</LastGenOutput>" + sw.NewLine +
       "  </None>" + sw.NewLine +
       "  <Compile Include=\"Properties\\Settings.Designer.cs\">" + sw.NewLine +
       "    <AutoGen>True</AutoGen>" + sw.NewLine +
       "    <DependentUpon>Settings.settings</DependentUpon>" + sw.NewLine +
       "    <DesignTimeSharedInput>True</DesignTimeSharedInput>" + sw.NewLine +
       "  </Compile>" + sw.NewLine +
       "  <None Include=\"Resources\\cert.cer\" />" + sw.NewLine +
        " <None Include=\"Resources\\certificate.cmd\" />" + sw.NewLine +
       "</ItemGroup>" + sw.NewLine +
       "<ItemGroup>" + sw.NewLine +
       "  <None Include=\"App.config\" />" + sw.NewLine +
       "</ItemGroup>" + sw.NewLine +
       "<ItemGroup>" + sw.NewLine +
       "  <None Include=\"Resources\\program.exe\" />" + sw.NewLine +
       "</ItemGroup>" + sw.NewLine +
       "<ItemGroup>" + sw.NewLine +
       "  <BootstrapperPackage Include=\".NETFramework,Version=v4.5\">" + sw.NewLine +
       "    <Visible>False</Visible>" + sw.NewLine +
       "    <ProductName>Microsoft .NET Framework 4.5 %28x86 and x64%29</ProductName>" + sw.NewLine +
       "    <Install>true</Install>" + sw.NewLine +
       "  </BootstrapperPackage>" + sw.NewLine +
       "  <BootstrapperPackage Include=\"Microsoft.Net.Client.3.5\">" + sw.NewLine +
       "    <Visible>False</Visible>" + sw.NewLine +
       "    <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>" + sw.NewLine +
       "    <Install>false</Install>" + sw.NewLine +
       "  </BootstrapperPackage>" + sw.NewLine +
       "  <BootstrapperPackage Include=\"Microsoft.Net.Framework.3.5.SP1\">" + sw.NewLine +
       "    <Visible>False</Visible>" + sw.NewLine +
       "    <ProductName>.NET Framework 3.5 SP1</ProductName>" + sw.NewLine +
       "    <Install>false</Install>" + sw.NewLine +
       "  </BootstrapperPackage>" + sw.NewLine +
       "</ItemGroup>" + sw.NewLine +
       "<Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />" + sw.NewLine +
       "<!-- To modify your build process, add your task inside one of the targets below and uncomment it. " + sw.NewLine +
       "     Other similar extension points exist, see Microsoft.Common.targets." + sw.NewLine +
       "<Target Name=\"BeforeBuild\">" + sw.NewLine +
       "</Target>" + sw.NewLine +
       "<Target Name=\"AfterBuild\">" + sw.NewLine +
       "</Target>" + sw.NewLine +
       "-->" + sw.NewLine +
     "</Project>");

                sw.Close();
            }catch(IOException ex)
            {
                MessageBox.Show("Bir G/Ç hatası oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
