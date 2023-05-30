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
        public const uint MySystem = 1;

        /// <remarks />
        public const uint MySystem_Motor1 = 2;

        /// <remarks />
        public const uint MySystem_Motor2 = 10;

        /// <remarks />
        public const uint MySystem_Tank1 = 18;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint MySystem_Motor1_Start = 3;

        /// <remarks />
        public const uint MySystem_Motor1_Stop = 4;

        /// <remarks />
        public const uint MySystem_Motor1_Run = 5;

        /// <remarks />
        public const uint MySystem_Motor1_Power = 6;

        /// <remarks />
        public const uint MySystem_Motor1_PowerMax = 7;

        /// <remarks />
        public const uint MySystem_Motor1_Speed = 8;

        /// <remarks />
        public const uint MySystem_Motor1_SpeedMax = 9;

        /// <remarks />
        public const uint MySystem_Motor2_Start = 11;

        /// <remarks />
        public const uint MySystem_Motor2_Stop = 12;

        /// <remarks />
        public const uint MySystem_Motor2_Run = 13;

        /// <remarks />
        public const uint MySystem_Motor2_Power = 14;

        /// <remarks />
        public const uint MySystem_Motor2_PowerMax = 15;

        /// <remarks />
        public const uint MySystem_Motor2_Speed = 16;

        /// <remarks />
        public const uint MySystem_Motor2_SpeedMax = 17;

        /// <remarks />
        public const uint MySystem_Tank1_Level = 19;

        /// <remarks />
        public const uint MySystem_Tank1_High = 20;

        /// <remarks />
        public const uint MySystem_Tank1_Low = 21;
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MySystem = new ExpandedNodeId(MyOPCUAServer.Objects.MySystem, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor1 = new ExpandedNodeId(MyOPCUAServer.Objects.MySystem_Motor1, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor2 = new ExpandedNodeId(MyOPCUAServer.Objects.MySystem_Motor2, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Tank1 = new ExpandedNodeId(MyOPCUAServer.Objects.MySystem_Tank1, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor1_Start = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor1_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor1_Stop = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor1_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor1_Run = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor1_Run, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor1_Power = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor1_Power, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor1_PowerMax = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor1_PowerMax, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor1_Speed = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor1_Speed, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor1_SpeedMax = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor1_SpeedMax, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor2_Start = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor2_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor2_Stop = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor2_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor2_Run = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor2_Run, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor2_Power = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor2_Power, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor2_PowerMax = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor2_PowerMax, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor2_Speed = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor2_Speed, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Motor2_SpeedMax = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Motor2_SpeedMax, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Tank1_Level = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Tank1_Level, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Tank1_High = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Tank1_High, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MySystem_Tank1_Low = new ExpandedNodeId(MyOPCUAServer.Variables.MySystem_Tank1_Low, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Motor1 = "Motor1";

        /// <remarks />
        public const string Motor2 = "Motor2";

        /// <remarks />
        public const string MySystem = "MySystem";

        /// <remarks />
        public const string Tank1 = "Tank1";
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
        public const string MyOPCUAServer = "http://opcfoundation.org/MyOPCUAServer";
    }
    #endregion
}