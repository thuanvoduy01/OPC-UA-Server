/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace MyOPCUAServer
{
    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint UIObject = 1;

        /// <remarks />
        public const uint UIObject_ObjectObject = 2;

        /// <remarks />
        public const uint UIObject2 = 4;

        /// <remarks />
        public const uint UIObject2_ObjectObject = 5;

        /// <remarks />
        public const uint UIObject2_ObjectFolder = 6;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint UIObject_ObjectVariable = 3;

        /// <remarks />
        public const uint UIObject2_ObjectVariable = 7;

        /// <remarks />
        public const uint UIObject2_NamespacePublicationDate = 8;
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId UIObject = new ExpandedNodeId(MyOPCUAServer.Objects.UIObject, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId UIObject_ObjectObject = new ExpandedNodeId(MyOPCUAServer.Objects.UIObject_ObjectObject, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId UIObject2 = new ExpandedNodeId(MyOPCUAServer.Objects.UIObject2, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId UIObject2_ObjectObject = new ExpandedNodeId(MyOPCUAServer.Objects.UIObject2_ObjectObject, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId UIObject2_ObjectFolder = new ExpandedNodeId(MyOPCUAServer.Objects.UIObject2_ObjectFolder, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId UIObject_ObjectVariable = new ExpandedNodeId(MyOPCUAServer.Variables.UIObject_ObjectVariable, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId UIObject2_ObjectVariable = new ExpandedNodeId(MyOPCUAServer.Variables.UIObject2_ObjectVariable, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId UIObject2_NamespacePublicationDate = new ExpandedNodeId(MyOPCUAServer.Variables.UIObject2_NamespacePublicationDate, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string ObjectFolder = "ObjectFolder";

        /// <remarks />
        public const string ObjectObject = "ObjectObject";

        /// <remarks />
        public const string ObjectVariable = "ObjectVariable";

        /// <remarks />
        public const string UIObject = "UIObject";

        /// <remarks />
        public const string UIObject2 = "UIObject2";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the MyOPCUAServer namespace (.NET code namespace is 'MyOPCUAServer').
        /// </summary>
        public const string MyOPCUAServer = "http://opcfoundation.org/OPCUAServer";
    }
    #endregion
}