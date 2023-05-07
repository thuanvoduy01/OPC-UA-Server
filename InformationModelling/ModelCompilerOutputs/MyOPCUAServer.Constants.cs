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
        public const uint System = 1;

        /// <remarks />
        public const uint System_M1 = 2;

        /// <remarks />
        public const uint System_M1_Input = 3;

        /// <remarks />
        public const uint System_M1_Output = 6;

        /// <remarks />
        public const uint System_M2 = 8;

        /// <remarks />
        public const uint System_M3 = 9;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint System_M1_Input_Start = 4;

        /// <remarks />
        public const uint System_M1_Input_Stop = 5;

        /// <remarks />
        public const uint System_M1_Output_CMD = 7;
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId System = new ExpandedNodeId(MyOPCUAServer.Objects.System, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId System_M1 = new ExpandedNodeId(MyOPCUAServer.Objects.System_M1, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId System_M1_Input = new ExpandedNodeId(MyOPCUAServer.Objects.System_M1_Input, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId System_M1_Output = new ExpandedNodeId(MyOPCUAServer.Objects.System_M1_Output, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId System_M2 = new ExpandedNodeId(MyOPCUAServer.Objects.System_M2, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId System_M3 = new ExpandedNodeId(MyOPCUAServer.Objects.System_M3, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId System_M1_Input_Start = new ExpandedNodeId(MyOPCUAServer.Variables.System_M1_Input_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId System_M1_Input_Stop = new ExpandedNodeId(MyOPCUAServer.Variables.System_M1_Input_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId System_M1_Output_CMD = new ExpandedNodeId(MyOPCUAServer.Variables.System_M1_Output_CMD, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string M1 = "M1";

        /// <remarks />
        public const string M2 = "M2";

        /// <remarks />
        public const string M3 = "M3";

        /// <remarks />
        public const string System = "System";
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