using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyOPCUAServer
{
    public partial class MyServerDesignerUC : UserControl
    {
        #region Private field
        ApplicationInstance m_application;

        #endregion

        public MyServerDesignerUC()
        {
            InitializeComponent();
        }
        public MyServerDesignerUC(ApplicationInstance application)
        {
            InitializeComponent();

            m_application = application;

            //TreeNode root = new TreeNode("ModelDesign");
            //tvwModel.Nodes.Add(root);
            //tvwModel.ExpandAll();

            timerUpdateDesigner.Interval = 500;
            //timerUpdateDesigner.Enabled = true;

            UpdateTreeViewModel();


        }

        public ApplicationInstance GetApplication()
        {
            return m_application;
        }

        private void btnImportXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "All files (*.*)|*.* | XML files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 2;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != String.Empty)
            { 
                txtFilePath.Text = openFileDialog.FileName; 
            }
            else
            { 
                //txtFilePath.Text = "You didn't select the file!"; 
            }
        }

        private void btnRunServer_Click(object sender, EventArgs e)
        {
            string selectedFileDir;
            string xmlModelDesignDir = MyOPCUAServer.Const.MODEL_DESIGN_DIRECTORY;
            string modelCompilerOutputsDir = MyOPCUAServer.Const.MODEL_COMPILER_OUTPUTS_DIRECTORY;
            XmlDocument xmlDoc = new XmlDocument();

            #region Create an empty ModelDesign.xml
            // Open the file in write mode and write an empty string to it
            // If the file not exist, StreamWriter will create a new one
            using (StreamWriter sw = new StreamWriter(xmlModelDesignDir, false))
            {
                sw.Write(String.Empty);
            }
            #endregion

            #region Delete old generated file
            string[] files = Directory.GetFiles(modelCompilerOutputsDir);
            foreach(string file in files)
            {
                File.Delete(file);
            }
            #endregion

            #region Update ModelDesign file from Designer or Import
            if (chkImport.Checked == false)
            {
                //Using Designer
                selectedFileDir = MyOPCUAServer.Const.MODEL_DESIGN_UC_DIRECTORY;
            }
            else
            {
                //Using import XML
                selectedFileDir = txtFilePath.Text;
            }

            if (File.Exists(selectedFileDir) == false)
            {
                return;
            }

            if (Path.GetExtension(selectedFileDir) != ".xml")
            {
                return;
            }

            xmlDoc.Load(selectedFileDir);
            xmlDoc.Save(xmlModelDesignDir);
            #endregion

            #region Calling ModelCompiler to generate ua.nodes file
            try
            {
                string batDir = MyOPCUAServer.Const.BATCH_DIRECTORY_MODEL_COMPILER;
                //string batDir = @"D:\Proj\VStudio\MyOPCUAServer\InformationModelling\MyOPCUAServerBuildDesignFullPath.bat";
                /* cmd /c -> run command then terminate
                   cmd /k -> run command then return to CMD prompt => useful for debugging*/
                string para = $"/c \"{batDir}\"";
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", para);
                procStartInfo.CreateNoWindow = true;
                Process proc = Process.Start(procStartInfo);
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} \n {ex.StackTrace.ToString()}");
            }
            #endregion

            #region Create OPC UA Server from ua.nodes file
            try
            {
                // process and command line arguments.
                if (m_application.ProcessCommandLine())
                {
                    return;
                }

                // check if running as a service.
                if (!Environment.UserInteractive)
                {
                    m_application.StartAsService(new MyServer());
                    return;
                }

                //load the application configuration
                string confDir = MyOPCUAServer.Const.CONFIG_SERVER_DIRECTORY;
                //string confDir = @"..\..\MyOPCUAServer.Config.xml";
                m_application.LoadApplicationConfiguration(confDir, false).Wait();

                //check the application certification
                m_application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // start the server.
                m_application.Start(new MyServer()).Wait();


                // run the application interactively.
                //Application.Run(new MyOPCUAServerForm(m_application));

                //MyOPCUAServerForm myOPCUAServerForm = new MyOPCUAServerForm(m_application);
                //myOPCUAServerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                string text = "Exception: " + ex.Message;
                if (ex.InnerException != null)
                {
                    text += "\r\nInner exception: ";
                    text += ex.InnerException.Message;
                }
                MessageBox.Show(text, m_application.ApplicationName);
            }
            #endregion

            //MyOPCUAServerForm myOPCUAServerForm = new MyOPCUAServerForm();
            //ShowDialog(MyOPCUAServerForm);
        }

        private void timerUpdateDesigner_Tick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// If finish, returns true
        /// </summary>
        /// <returns></returns>
        public void UpdateTreeViewModel()
        {
            tvwModel.Nodes.Clear();

            // Create ModelDesign root node
            TreeNode treeNodeRoot = new TreeNode("ModelDesign");
            tvwModel.Nodes.Add(treeNodeRoot);

            // Load ModelDesignUc.xml
            XmlDocument xmlDocument = new XmlDocument();
            string xmlModelDesignUc = MyOPCUAServer.Const.MODEL_DESIGN_UC_DIRECTORY;
            xmlDocument.Load(xmlModelDesignUc);

            XmlElement root = xmlDocument.DocumentElement;
            PopulateTreeview(root, tvwModel.Nodes[0]);

            tvwModel.ExpandAll();
        }

        public void PopulateTreeview(XmlNode node, TreeNode treeNode)
        {
            string treeNodeText, treeNodeType = String.Empty;
            TreeNode treeNodeChild = null;
            XmlNodeList childNodeList = node.ChildNodes;

            if (childNodeList.Count <= 0)
            {
                return;
            }

            foreach (XmlNode childNode in childNodeList)
            {
                if (childNode.Name.Contains("Namespaces"))
                {
                    continue;
                }

                if (childNode.Name.Contains("References"))
                {
                    continue;
                }

                if (childNode.Name.Contains("Children"))
                {
                    PopulateTreeview(childNode, treeNode);
                    return;
                }

                if (childNode.Name.Contains("Object") ||
                    childNode.Name.Contains("Variable") ||
                    childNode.Name.Contains("Property"))
                {
                    //Object and folder all have xml tag is <opc:Object>
                    //Base on TypeDefinition to distinguish those two
                    if (childNode.Name.Contains("Object"))
                    {
                        if (childNode.Attributes["TypeDefinition"].Value == "ua:BaseObjectType")
                        {
                            treeNodeType = "Object";
                        }

                        if (childNode.Attributes["TypeDefinition"].Value == "ua:FolderType")
                        {
                            treeNodeType = "Folder";
                        }
                    }
                    else
                    {
                        //Only took "Variable" from <opc:Variable>
                        treeNodeType = childNode.Name.Split(':')[1];
                    }

                    treeNodeText = childNode.Attributes["SymbolicName"].Value;

                    string temp = $"{treeNodeText}::{treeNodeType}";
                    treeNodeChild = treeNode.Nodes.Add(temp);
                    PopulateTreeview(childNode, treeNodeChild);
                }

            }
        }


        public void InitDesignerUcMdoel()
        {
            string xmlModelDesignUcDir = MyOPCUAServer.Const.MODEL_DESIGN_UC_DIRECTORY;

            #region create an empty model design file (using DesignerUcModel.xml)
            // Open the file in write mode and write an empty string to it
            // If the file not exist, StreamWriter will create a new one
            using (StreamWriter sw = new StreamWriter(xmlModelDesignUcDir, false))
            {
                sw.Write(String.Empty);
            }
            #endregion

            #region Add tag to the empty file to create a normative file
            //The normaive file look like this:
            /*      
                   <?xml version="1.0" encoding="utf-8"?>
                   <opc:ModelDesign xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
                                     xmlns:xsd="http://www.w3.org/2001/XMLSchema"
                                     xmlns:opc="http://opcfoundation.org/UA/ModelDesign.xsd"
                                     xmlns:ua="http://opcfoundation.org/UA/"
                                     xmlns:uax="http://opcfoundation.org/UA/2008/02/Types.xsd"
                                     xmlns="http://opcfoundation.org/OPCUAServer"
                                     TargetNamespace="http://opcfoundation.org/OPCUAServer">
	                    <opc:Namespaces>
		                    <opc:Namespace Name="OpcUa"
		                                   Prefix="Opc.Ua"
		                                   XmlNamespace="http://opcfoundation.org/UA/2008/02/Types.xsd">http://opcfoundation.org/UA/</opc:Namespace>
		                    <opc:Namespace Name="MyOPCUAServer"
		                                   Prefix="MyOPCUAServer">http://opcfoundation.org/OPCUAServer</opc:Namespace>
	                    </opc:Namespaces>
                        <!-- Model is added here -->
                    </opc:ModelDesign>
                
            */

            // Create the XML document instance
            XmlDocument xmlDoc = new XmlDocument();

            #region Create the <?xml version="1.0" encoding="utf-8" ?> declaration
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(xmlDeclaration);
            #endregion

            #region Create the <opc:ModelDesign> element (root element)
            XmlElement modelDesignElement = xmlDoc.CreateElement("opc", "ModelDesign", "http://opcfoundation.org/UA/ModelDesign.xsd");
            xmlDoc.AppendChild(modelDesignElement);
            #endregion

            #region Add the xmlns attributes to the <opc:ModelDesign> element
            modelDesignElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            modelDesignElement.SetAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
            modelDesignElement.SetAttribute("xmlns:opc", "http://opcfoundation.org/UA/ModelDesign.xsd");
            modelDesignElement.SetAttribute("xmlns:ua", "http://opcfoundation.org/UA/");
            modelDesignElement.SetAttribute("xmlns:uax", "http://opcfoundation.org/UA/2008/02/Types.xsd");
            modelDesignElement.SetAttribute("xmlns", "http://opcfoundation.org/OPCUAServer");
            modelDesignElement.SetAttribute("TargetNamespace", "http://opcfoundation.org/OPCUAServer");
            #endregion

            #region Add namespace to the <opc:ModelDesign> element
            // Create the <opc:Namespaces> element
            XmlElement namespacesElement = xmlDoc.CreateElement("opc", "Namespaces", "http://opcfoundation.org/UA/ModelDesign.xsd");
            modelDesignElement.AppendChild(namespacesElement);

            // Create the <opc:Namespace> elements and add them to the <opc:Namespaces> element
            XmlElement namespaceElement1 = xmlDoc.CreateElement("opc", "Namespace", "http://opcfoundation.org/UA/ModelDesign.xsd");
            namespaceElement1.SetAttribute("Name", "OpcUa");
            namespaceElement1.SetAttribute("Prefix", "Opc.Ua");
            namespaceElement1.SetAttribute("XmlNamespace", "http://opcfoundation.org/UA/2008/02/Types.xsd");
            namespaceElement1.InnerText = "http://opcfoundation.org/UA/";
            namespacesElement.AppendChild(namespaceElement1);

            XmlElement namespaceElement2 = xmlDoc.CreateElement("opc", "Namespace", "http://opcfoundation.org/UA/ModelDesign.xsd");
            namespaceElement2.SetAttribute("Name", "MyOPCUAServer");
            namespaceElement2.SetAttribute("Prefix", "MyOPCUAServer");
            namespaceElement2.InnerText = "http://opcfoundation.org/OPCUAServer";
            namespacesElement.AppendChild(namespaceElement2);
            #endregion

            xmlDoc.Save(xmlModelDesignUcDir);
            #endregion
        }

        /// <summary>
        /// Return something like "ModelDesign\\{symbolic1}\\{symbolic2}
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public string GetNodeSymbolicNamePath(XmlNode node)
        {
            if (node == null)
            {
                return String.Empty;
            }

            if (node.Name.Contains("ModelDesign"))
            {
                return $"ModelDesign";
            }

            if (node.Name.Contains("Children"))
            {
                return GetNodeSymbolicNamePath(node.ParentNode);
            }

            return $"{GetNodeSymbolicNamePath(node.ParentNode)}\\{node.Attributes["SymbolicName"].Value}";

            #region old version (working)
            //if (node == null)
            //{
            //    return String.Empty;
            //}

            //if (node.Name.Contains("ModelDesign"))
            //{
            //    return $"ModelDesign";
            //}

            //XmlNode nodeParent = node.ParentNode;

            //if (nodeParent.Name.Contains("ModelDesign"))
            //{
            //    return $"ModelDesign\\{node.Attributes["SymbolicName"].Value}";
            //}

            //if (nodeParent.Name.Contains("Children"))
            //{
            //    nodeParent = nodeParent.ParentNode;
            //}

            //string tempStr = GetNodeSymbolicNamePath(nodeParent);
            //tempStr = tempStr + "\\" + node.Attributes["SymbolicName"].Value;
            //return tempStr;
            ////return $"{GetNodeSymbolicNamePath(nodeParent)}\\{node.Attributes["SymbolicName"].Value}";
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <param name="treeviewNodePath"></param>
        /// <returns></returns>
        public XmlNode GetXmlNode(XmlDocument xmlDoc, string treeviewNodePath)
        {
            if (xmlDoc == null)
            {
                return null;
            }

            if (treeviewNodePath == String.Empty)
            {
                return null;
            }

            #region Get all xml nodes that have the same SymbolicName as the node in the treeview
            //For example: ModelDesign\\obj1::ua:Object\\obj11::ua:Object.
            //Then look for all nodes that have symbolicName = "obj11" and elementType = Object

            //Parse to get SymbolicName and ElementType of the node
            string nodeSymbolicName, nodeType;
            string[] subStrings = ParsingPathToSymbolicNameAndType(treeviewNodePath);
            nodeSymbolicName = subStrings[0];
            nodeType = subStrings[1];

            //Create xPath
            string xPath = $"//opc:{nodeType}[@SymbolicName='{nodeSymbolicName}']";

            XmlNamespaceManager nsMgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsMgr.AddNamespace("opc", "http://opcfoundation.org/UA/ModelDesign.xsd");

            XmlNodeList nodeList = xmlDoc.SelectNodes(xPath, nsMgr);
            #endregion

            #region Get the exact node by symbolicNamePath
            XmlNode selectedXmlNode = null;
            if (nodeList.Count > 0)
            {
                string pathTreeview = @"ModelDesign\UIObject2\obj1";
                foreach (XmlNode node in nodeList)
                {
                    string nodePath = GetNodeSymbolicNamePath(node);
                    if (nodePath == pathTreeview)
                    {
                        selectedXmlNode = node;
                        break;
                    }

                }
            }

            return selectedXmlNode;
            #endregion
        }

        /// <summary>
        /// Input path: ModelDesign\\obj1::Object\\obj11::Object.
        /// Output symbolicNamePath: ModelDesign\\obj1\\obj11
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string ParsingPathToSymbolicNamePath(string path)
        {
            /* ---Xử lý parse cho object và folder---*/
            //
            /*------------------------------ */
            string symbolicNamePath = String.Empty;
            string[] subPaths = path.Split(new[] { "\\" }, StringSplitOptions.None);

            foreach(string subPath in subPaths)
            {
                string[] subStrings = subPath.Split(new[] { "::" }, StringSplitOptions.None);
                symbolicNamePath += subStrings[0] + "\\";

                /*
                //subPath = ModelDesign -> symbolicNamePath = ModelDesign
                if (subStrings.Length == 1)
                {
                    symbolicNamePath = symbolicNamePath + subStrings[0];
                }

                if (subStrings.Length == 2)
                {
                    symbolicNamePath = symbolicNamePath + "\\" + subStrings[1];
                }
                */

            }


            symbolicNamePath = symbolicNamePath.TrimEnd('\\');
            return symbolicNamePath;
            
        }
        /// <summary>
        /// Input path: ModelDesign\\obj1::ua:Object\\obj11::ua:Object.
        /// Output symbolicNamePath: obj11::ua:Object.
        /// Return SymbolicName = subString[0], Type = subString[1]
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string[] ParsingPathToSymbolicNameAndType(string path)
        {
            //dT: adjust
            return new[] { String.Empty };

        }




        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (tvwModel.SelectedNode == null)
            {
                return;
            }


            UpdateTreeViewModel();
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            if (tvwModel.SelectedNode == null)
            {
                return;
            }


            UpdateTreeViewModel();

        }

        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            if (tvwModel.SelectedNode == null)
            {
                return;
            }


            UpdateTreeViewModel();

        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (tvwModel.SelectedNode == null)
            {
                return;
            }

            UpdateTreeViewModel();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(tvwModel.SelectedNode == null)
            {
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();
            string xmlModelDesignUc = MyOPCUAServer.Const.MODEL_DESIGN_UC_DIRECTORY;
            xmlDoc.Load(xmlModelDesignUc);

            string symbolicNamePath = ParsingPathToSymbolicNamePath(tvwModel.SelectedNode.FullPath);

            XmlNode xmlNode = GetXmlNode(xmlDoc, symbolicNamePath);

            if (xmlNode != null)
            {
                xmlNode.ParentNode.RemoveChild(xmlNode);
            }

            UpdateTreeViewModel();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InitDesignerUcMdoel();
            UpdateTreeViewModel();
        }
    }
}
