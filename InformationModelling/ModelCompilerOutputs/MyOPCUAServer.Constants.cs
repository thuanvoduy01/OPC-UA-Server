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
        public const uint obj = 1;

        /// <remarks />
        public const uint obj_input = 2;

        /// <remarks />
        public const uint obj_output = 5;

        /// <remarks />
        public const uint obj_control = 7;

        /// <remarks />
        public const uint obj_new = 11;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint obj_input_start = 3;

        /// <remarks />
        public const uint obj_input_stop = 4;

        /// <remarks />
        public const uint obj_output_CMD = 6;

        /// <remarks />
        public const uint obj_control_kp = 8;

        /// <remarks />
        public const uint obj_control_ki = 9;

        /// <remarks />
        public const uint obj_control_kd = 10;

        /// <remarks />
        public const uint obj_new_dt = 12;

        /// <remarks />
        public const uint obj_new_guid = 13;

        /// <remarks />
        public const uint obj_new_bytestring = 14;

        /// <remarks />
        public const uint obj_new_statcode = 15;

        /// <remarks />
        public const uint obj_new_locText = 16;

        /// <remarks />
        public const uint obj_test = 17;

        /// <remarks />
        public const uint obj_test2 = 18;
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId obj = new ExpandedNodeId(MyOPCUAServer.Objects.obj, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_input = new ExpandedNodeId(MyOPCUAServer.Objects.obj_input, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_output = new ExpandedNodeId(MyOPCUAServer.Objects.obj_output, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_control = new ExpandedNodeId(MyOPCUAServer.Objects.obj_control, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_new = new ExpandedNodeId(MyOPCUAServer.Objects.obj_new, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId obj_input_start = new ExpandedNodeId(MyOPCUAServer.Variables.obj_input_start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_input_stop = new ExpandedNodeId(MyOPCUAServer.Variables.obj_input_stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_output_CMD = new ExpandedNodeId(MyOPCUAServer.Variables.obj_output_CMD, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_control_kp = new ExpandedNodeId(MyOPCUAServer.Variables.obj_control_kp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_control_ki = new ExpandedNodeId(MyOPCUAServer.Variables.obj_control_ki, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_control_kd = new ExpandedNodeId(MyOPCUAServer.Variables.obj_control_kd, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_new_dt = new ExpandedNodeId(MyOPCUAServer.Variables.obj_new_dt, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_new_guid = new ExpandedNodeId(MyOPCUAServer.Variables.obj_new_guid, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_new_bytestring = new ExpandedNodeId(MyOPCUAServer.Variables.obj_new_bytestring, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_new_statcode = new ExpandedNodeId(MyOPCUAServer.Variables.obj_new_statcode, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_new_locText = new ExpandedNodeId(MyOPCUAServer.Variables.obj_new_locText, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_test = new ExpandedNodeId(MyOPCUAServer.Variables.obj_test, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId obj_test2 = new ExpandedNodeId(MyOPCUAServer.Variables.obj_test2, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string control = "control";

        /// <remarks />
        public const string input = "input";

        /// <remarks />
        public const string new = "new";

        /// <remarks />
        public const string obj = "obj";

        /// <remarks />
        public const string output = "output";

        /// <remarks />
        public const string test = "test";

        /// <remarks />
        public const string test2 = "test2";
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