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
        public const uint UIObject_ObjectFolder = 3;

        /// <remarks />
        public const uint hello = 6;

        /// <remarks />
        public const uint hello_helo123 = 7;

        /// <remarks />
        public const uint f = 8;

        /// <remarks />
        public const uint f_f1 = 9;

        /// <remarks />
        public const uint o = 21;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint UIObject_ObjectVariable = 4;

        /// <remarks />
        public const uint UIObject_NamespacePublicationDate = 5;

        /// <remarks />
        public const uint f_bool = 10;

        /// <remarks />
        public const uint f_bool_property = 11;

        /// <remarks />
        public const uint f_Int16 = 12;

        /// <remarks />
        public const uint f_UInt16 = 13;

        /// <remarks />
        public const uint f_Int32 = 14;

        /// <remarks />
        public const uint f_float = 15;

        /// <remarks />
        public const uint f_double = 16;

        /// <remarks />
        public const uint f_string = 17;

        /// <remarks />
        public const uint f_datetime = 18;

        /// <remarks />
        public const uint f_sbyte = 19;

        /// <remarks />
        public const uint f_byte = 20;

        /// <remarks />
        public const uint v = 22;
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
        public static readonly ExpandedNodeId UIObject_ObjectFolder = new ExpandedNodeId(MyOPCUAServer.Objects.UIObject_ObjectFolder, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId hello = new ExpandedNodeId(MyOPCUAServer.Objects.hello, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId hello_helo123 = new ExpandedNodeId(MyOPCUAServer.Objects.hello_helo123, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f = new ExpandedNodeId(MyOPCUAServer.Objects.f, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_f1 = new ExpandedNodeId(MyOPCUAServer.Objects.f_f1, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId o = new ExpandedNodeId(MyOPCUAServer.Objects.o, MyOPCUAServer.Namespaces.MyOPCUAServer);
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
        public static readonly ExpandedNodeId UIObject_NamespacePublicationDate = new ExpandedNodeId(MyOPCUAServer.Variables.UIObject_NamespacePublicationDate, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_bool = new ExpandedNodeId(MyOPCUAServer.Variables.f_bool, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_bool_property = new ExpandedNodeId(MyOPCUAServer.Variables.f_bool_property, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_Int16 = new ExpandedNodeId(MyOPCUAServer.Variables.f_Int16, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_UInt16 = new ExpandedNodeId(MyOPCUAServer.Variables.f_UInt16, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_Int32 = new ExpandedNodeId(MyOPCUAServer.Variables.f_Int32, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_float = new ExpandedNodeId(MyOPCUAServer.Variables.f_float, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_double = new ExpandedNodeId(MyOPCUAServer.Variables.f_double, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_string = new ExpandedNodeId(MyOPCUAServer.Variables.f_string, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_datetime = new ExpandedNodeId(MyOPCUAServer.Variables.f_datetime, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_sbyte = new ExpandedNodeId(MyOPCUAServer.Variables.f_sbyte, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId f_byte = new ExpandedNodeId(MyOPCUAServer.Variables.f_byte, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId v = new ExpandedNodeId(MyOPCUAServer.Variables.v, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string bool = "bool";

        /// <remarks />
        public const string byte = "byte";

        /// <remarks />
        public const string datetime = "datetime";

        /// <remarks />
        public const string double = "double";

        /// <remarks />
        public const string f = "f";

        /// <remarks />
        public const string f1 = "f1";

        /// <remarks />
        public const string float = "float";

        /// <remarks />
        public const string hello = "hello";

        /// <remarks />
        public const string helo123 = "helo123";

        /// <remarks />
        public const string Int16 = "Int16";

        /// <remarks />
        public const string Int32 = "Int32";

        /// <remarks />
        public const string o = "o";

        /// <remarks />
        public const string ObjectFolder = "ObjectFolder";

        /// <remarks />
        public const string ObjectObject = "ObjectObject";

        /// <remarks />
        public const string ObjectVariable = "ObjectVariable";

        /// <remarks />
        public const string sbyte = "sbyte";

        /// <remarks />
        public const string string = "string";

        /// <remarks />
        public const string UInt16 = "UInt16";

        /// <remarks />
        public const string UIObject = "UIObject";

        /// <remarks />
        public const string v = "v";
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