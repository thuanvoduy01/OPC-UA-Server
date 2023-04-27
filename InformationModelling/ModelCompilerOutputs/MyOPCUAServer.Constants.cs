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
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint MotorConveyor_Start = 816;

        /// <remarks />
        public const uint MotorConveyor_Stop = 817;

        /// <remarks />
        public const uint MachineType_Conveyor_Start = 840;

        /// <remarks />
        public const uint MachineType_Conveyor_Stop = 841;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Conveyor_Start = 865;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Conveyor_Stop = 866;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Conveyor_Start = 890;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Conveyor_Stop = 891;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint MachineType_Temperature = 819;

        /// <remarks />
        public const uint MachineType_Proximity = 826;

        /// <remarks />
        public const uint MachineType_Conveyor = 833;

        /// <remarks />
        public const uint OPCUAServerType_Machine = 843;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Temperature = 844;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Proximity = 851;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Conveyor = 858;

        /// <remarks />
        public const uint OPCUAServer1 = 867;

        /// <remarks />
        public const uint OPCUAServer1_Machine = 868;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Temperature = 869;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Proximity = 876;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Conveyor = 883;

        /// <remarks />
        public const uint TankBatchSystemType_Motor1 = 902;

        /// <remarks />
        public const uint TankBatchSystemType_Motor2 = 911;

        /// <remarks />
        public const uint TankBatchSystemType_Motor3 = 920;

        /// <remarks />
        public const uint TankBatch = 929;

        /// <remarks />
        public const uint TankBatch_Motor1 = 930;

        /// <remarks />
        public const uint TankBatch_Motor2 = 939;

        /// <remarks />
        public const uint TankBatch_Motor3 = 948;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint DtDemoType = 782;

        /// <remarks />
        public const uint GenericSensorType = 8;

        /// <remarks />
        public const uint TemperatureSensor = 795;

        /// <remarks />
        public const uint ProximitySensor = 802;

        /// <remarks />
        public const uint MotorConveyor = 809;

        /// <remarks />
        public const uint MachineType = 818;

        /// <remarks />
        public const uint OPCUAServerType = 842;

        /// <remarks />
        public const uint MotorType = 892;

        /// <remarks />
        public const uint TankBatchSystemType = 901;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint DtDemoType_Value = 783;

        /// <remarks />
        public const uint DtDemoType_Value_EURange = 787;

        /// <remarks />
        public const uint GenericSensorType_Value = 789;

        /// <remarks />
        public const uint GenericSensorType_Value_EURange = 793;

        /// <remarks />
        public const uint TemperatureSensor_Value_EURange = 800;

        /// <remarks />
        public const uint ProximitySensor_Value_EURange = 807;

        /// <remarks />
        public const uint MotorConveyor_Speed = 810;

        /// <remarks />
        public const uint MotorConveyor_Speed_EURange = 814;

        /// <remarks />
        public const uint MachineType_Temperature_Value = 820;

        /// <remarks />
        public const uint MachineType_Temperature_Value_EURange = 824;

        /// <remarks />
        public const uint MachineType_Proximity_Value = 827;

        /// <remarks />
        public const uint MachineType_Proximity_Value_EURange = 831;

        /// <remarks />
        public const uint MachineType_Conveyor_Speed = 834;

        /// <remarks />
        public const uint MachineType_Conveyor_Speed_EURange = 838;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Temperature_Value = 845;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Temperature_Value_EURange = 849;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Proximity_Value = 852;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Proximity_Value_EURange = 856;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Conveyor_Speed = 859;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Conveyor_Speed_EURange = 863;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Temperature_Value = 870;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Temperature_Value_EURange = 874;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Proximity_Value = 877;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Proximity_Value_EURange = 881;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Conveyor_Speed = 884;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Conveyor_Speed_EURange = 888;

        /// <remarks />
        public const uint MotorType_Mode = 893;

        /// <remarks />
        public const uint MotorType_Start = 894;

        /// <remarks />
        public const uint MotorType_Stop = 895;

        /// <remarks />
        public const uint MotorType_StartCondition = 896;

        /// <remarks />
        public const uint MotorType_StopCondition = 897;

        /// <remarks />
        public const uint MotorType_RunFeedback = 898;

        /// <remarks />
        public const uint MotorType_CMD = 899;

        /// <remarks />
        public const uint MotorType_Fault = 900;

        /// <remarks />
        public const uint TankBatchSystemType_Motor1_Mode = 903;

        /// <remarks />
        public const uint TankBatchSystemType_Motor1_Start = 904;

        /// <remarks />
        public const uint TankBatchSystemType_Motor1_Stop = 905;

        /// <remarks />
        public const uint TankBatchSystemType_Motor1_StartCondition = 906;

        /// <remarks />
        public const uint TankBatchSystemType_Motor1_StopCondition = 907;

        /// <remarks />
        public const uint TankBatchSystemType_Motor1_RunFeedback = 908;

        /// <remarks />
        public const uint TankBatchSystemType_Motor1_CMD = 909;

        /// <remarks />
        public const uint TankBatchSystemType_Motor1_Fault = 910;

        /// <remarks />
        public const uint TankBatchSystemType_Motor2_Mode = 912;

        /// <remarks />
        public const uint TankBatchSystemType_Motor2_Start = 913;

        /// <remarks />
        public const uint TankBatchSystemType_Motor2_Stop = 914;

        /// <remarks />
        public const uint TankBatchSystemType_Motor2_StartCondition = 915;

        /// <remarks />
        public const uint TankBatchSystemType_Motor2_StopCondition = 916;

        /// <remarks />
        public const uint TankBatchSystemType_Motor2_RunFeedback = 917;

        /// <remarks />
        public const uint TankBatchSystemType_Motor2_CMD = 918;

        /// <remarks />
        public const uint TankBatchSystemType_Motor2_Fault = 919;

        /// <remarks />
        public const uint TankBatchSystemType_Motor3_Mode = 921;

        /// <remarks />
        public const uint TankBatchSystemType_Motor3_Start = 922;

        /// <remarks />
        public const uint TankBatchSystemType_Motor3_Stop = 923;

        /// <remarks />
        public const uint TankBatchSystemType_Motor3_StartCondition = 924;

        /// <remarks />
        public const uint TankBatchSystemType_Motor3_StopCondition = 925;

        /// <remarks />
        public const uint TankBatchSystemType_Motor3_RunFeedback = 926;

        /// <remarks />
        public const uint TankBatchSystemType_Motor3_CMD = 927;

        /// <remarks />
        public const uint TankBatchSystemType_Motor3_Fault = 928;

        /// <remarks />
        public const uint TankBatch_Motor1_Mode = 931;

        /// <remarks />
        public const uint TankBatch_Motor1_Start = 932;

        /// <remarks />
        public const uint TankBatch_Motor1_Stop = 933;

        /// <remarks />
        public const uint TankBatch_Motor1_StartCondition = 934;

        /// <remarks />
        public const uint TankBatch_Motor1_StopCondition = 935;

        /// <remarks />
        public const uint TankBatch_Motor1_RunFeedback = 936;

        /// <remarks />
        public const uint TankBatch_Motor1_CMD = 937;

        /// <remarks />
        public const uint TankBatch_Motor1_Fault = 938;

        /// <remarks />
        public const uint TankBatch_Motor2_Mode = 940;

        /// <remarks />
        public const uint TankBatch_Motor2_Start = 941;

        /// <remarks />
        public const uint TankBatch_Motor2_Stop = 942;

        /// <remarks />
        public const uint TankBatch_Motor2_StartCondition = 943;

        /// <remarks />
        public const uint TankBatch_Motor2_StopCondition = 944;

        /// <remarks />
        public const uint TankBatch_Motor2_RunFeedback = 945;

        /// <remarks />
        public const uint TankBatch_Motor2_CMD = 946;

        /// <remarks />
        public const uint TankBatch_Motor2_Fault = 947;

        /// <remarks />
        public const uint TankBatch_Motor3_Mode = 949;

        /// <remarks />
        public const uint TankBatch_Motor3_Start = 950;

        /// <remarks />
        public const uint TankBatch_Motor3_Stop = 951;

        /// <remarks />
        public const uint TankBatch_Motor3_StartCondition = 952;

        /// <remarks />
        public const uint TankBatch_Motor3_StopCondition = 953;

        /// <remarks />
        public const uint TankBatch_Motor3_RunFeedback = 954;

        /// <remarks />
        public const uint TankBatch_Motor3_CMD = 955;

        /// <remarks />
        public const uint TankBatch_Motor3_Fault = 956;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MotorConveyor_Start = new ExpandedNodeId(MyOPCUAServer.Methods.MotorConveyor_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorConveyor_Stop = new ExpandedNodeId(MyOPCUAServer.Methods.MotorConveyor_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Conveyor_Start = new ExpandedNodeId(MyOPCUAServer.Methods.MachineType_Conveyor_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Conveyor_Stop = new ExpandedNodeId(MyOPCUAServer.Methods.MachineType_Conveyor_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Start = new ExpandedNodeId(MyOPCUAServer.Methods.OPCUAServerType_Machine_Conveyor_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Stop = new ExpandedNodeId(MyOPCUAServer.Methods.OPCUAServerType_Machine_Conveyor_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Start = new ExpandedNodeId(MyOPCUAServer.Methods.OPCUAServer1_Machine_Conveyor_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Stop = new ExpandedNodeId(MyOPCUAServer.Methods.OPCUAServer1_Machine_Conveyor_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Temperature = new ExpandedNodeId(MyOPCUAServer.Objects.MachineType_Temperature, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Proximity = new ExpandedNodeId(MyOPCUAServer.Objects.MachineType_Proximity, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Conveyor = new ExpandedNodeId(MyOPCUAServer.Objects.MachineType_Conveyor, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine = new ExpandedNodeId(MyOPCUAServer.Objects.OPCUAServerType_Machine, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Temperature = new ExpandedNodeId(MyOPCUAServer.Objects.OPCUAServerType_Machine_Temperature, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Proximity = new ExpandedNodeId(MyOPCUAServer.Objects.OPCUAServerType_Machine_Proximity, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor = new ExpandedNodeId(MyOPCUAServer.Objects.OPCUAServerType_Machine_Conveyor, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1 = new ExpandedNodeId(MyOPCUAServer.Objects.OPCUAServer1, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine = new ExpandedNodeId(MyOPCUAServer.Objects.OPCUAServer1_Machine, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Temperature = new ExpandedNodeId(MyOPCUAServer.Objects.OPCUAServer1_Machine_Temperature, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Proximity = new ExpandedNodeId(MyOPCUAServer.Objects.OPCUAServer1_Machine_Proximity, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor = new ExpandedNodeId(MyOPCUAServer.Objects.OPCUAServer1_Machine_Conveyor, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor1 = new ExpandedNodeId(MyOPCUAServer.Objects.TankBatchSystemType_Motor1, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor2 = new ExpandedNodeId(MyOPCUAServer.Objects.TankBatchSystemType_Motor2, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor3 = new ExpandedNodeId(MyOPCUAServer.Objects.TankBatchSystemType_Motor3, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch = new ExpandedNodeId(MyOPCUAServer.Objects.TankBatch, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor1 = new ExpandedNodeId(MyOPCUAServer.Objects.TankBatch_Motor1, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor2 = new ExpandedNodeId(MyOPCUAServer.Objects.TankBatch_Motor2, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor3 = new ExpandedNodeId(MyOPCUAServer.Objects.TankBatch_Motor3, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId DtDemoType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.DtDemoType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.GenericSensorType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureSensor = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.TemperatureSensor, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProximitySensor = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.ProximitySensor, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorConveyor = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MotorConveyor, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MachineType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.OPCUAServerType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MotorType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.TankBatchSystemType, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId DtDemoType_Value = new ExpandedNodeId(MyOPCUAServer.Variables.DtDemoType_Value, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DtDemoType_Value_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.DtDemoType_Value_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Value = new ExpandedNodeId(MyOPCUAServer.Variables.GenericSensorType_Value, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Value_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.GenericSensorType_Value_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureSensor_Value_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureSensor_Value_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProximitySensor_Value_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.ProximitySensor_Value_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorConveyor_Speed = new ExpandedNodeId(MyOPCUAServer.Variables.MotorConveyor_Speed, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorConveyor_Speed_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.MotorConveyor_Speed_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Temperature_Value = new ExpandedNodeId(MyOPCUAServer.Variables.MachineType_Temperature_Value, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Temperature_Value_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.MachineType_Temperature_Value_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Proximity_Value = new ExpandedNodeId(MyOPCUAServer.Variables.MachineType_Proximity_Value, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Proximity_Value_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.MachineType_Proximity_Value_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Conveyor_Speed = new ExpandedNodeId(MyOPCUAServer.Variables.MachineType_Conveyor_Speed, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Conveyor_Speed_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.MachineType_Conveyor_Speed_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Temperature_Value = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServerType_Machine_Temperature_Value, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Temperature_Value_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServerType_Machine_Temperature_Value_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Proximity_Value = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServerType_Machine_Proximity_Value, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Proximity_Value_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServerType_Machine_Proximity_Value_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Speed = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServerType_Machine_Conveyor_Speed, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Speed_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServerType_Machine_Conveyor_Speed_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Temperature_Value = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServer1_Machine_Temperature_Value, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Temperature_Value_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServer1_Machine_Temperature_Value_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Proximity_Value = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServer1_Machine_Proximity_Value, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Proximity_Value_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServer1_Machine_Proximity_Value_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Speed = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServer1_Machine_Conveyor_Speed, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Speed_EURange = new ExpandedNodeId(MyOPCUAServer.Variables.OPCUAServer1_Machine_Conveyor_Speed_EURange, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_Mode = new ExpandedNodeId(MyOPCUAServer.Variables.MotorType_Mode, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_Start = new ExpandedNodeId(MyOPCUAServer.Variables.MotorType_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_Stop = new ExpandedNodeId(MyOPCUAServer.Variables.MotorType_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_StartCondition = new ExpandedNodeId(MyOPCUAServer.Variables.MotorType_StartCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_StopCondition = new ExpandedNodeId(MyOPCUAServer.Variables.MotorType_StopCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_RunFeedback = new ExpandedNodeId(MyOPCUAServer.Variables.MotorType_RunFeedback, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_CMD = new ExpandedNodeId(MyOPCUAServer.Variables.MotorType_CMD, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorType_Fault = new ExpandedNodeId(MyOPCUAServer.Variables.MotorType_Fault, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor1_Mode = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor1_Mode, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor1_Start = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor1_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor1_Stop = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor1_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor1_StartCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor1_StartCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor1_StopCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor1_StopCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor1_RunFeedback = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor1_RunFeedback, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor1_CMD = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor1_CMD, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor1_Fault = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor1_Fault, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor2_Mode = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor2_Mode, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor2_Start = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor2_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor2_Stop = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor2_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor2_StartCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor2_StartCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor2_StopCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor2_StopCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor2_RunFeedback = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor2_RunFeedback, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor2_CMD = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor2_CMD, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor2_Fault = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor2_Fault, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor3_Mode = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor3_Mode, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor3_Start = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor3_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor3_Stop = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor3_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor3_StartCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor3_StartCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor3_StopCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor3_StopCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor3_RunFeedback = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor3_RunFeedback, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor3_CMD = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor3_CMD, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatchSystemType_Motor3_Fault = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatchSystemType_Motor3_Fault, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor1_Mode = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor1_Mode, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor1_Start = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor1_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor1_Stop = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor1_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor1_StartCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor1_StartCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor1_StopCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor1_StopCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor1_RunFeedback = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor1_RunFeedback, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor1_CMD = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor1_CMD, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor1_Fault = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor1_Fault, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor2_Mode = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor2_Mode, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor2_Start = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor2_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor2_Stop = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor2_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor2_StartCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor2_StartCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor2_StopCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor2_StopCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor2_RunFeedback = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor2_RunFeedback, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor2_CMD = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor2_CMD, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor2_Fault = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor2_Fault, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor3_Mode = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor3_Mode, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor3_Start = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor3_Start, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor3_Stop = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor3_Stop, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor3_StartCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor3_StartCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor3_StopCondition = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor3_StopCondition, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor3_RunFeedback = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor3_RunFeedback, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor3_CMD = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor3_CMD, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TankBatch_Motor3_Fault = new ExpandedNodeId(MyOPCUAServer.Variables.TankBatch_Motor3_Fault, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string CMD = "CMD";

        /// <remarks />
        public const string Conveyor = "Conveyor";

        /// <remarks />
        public const string DtDemoType = "DtDemoType";

        /// <remarks />
        public const string Fault = "Fault";

        /// <remarks />
        public const string GenericSensorType = "GenericSensorType";

        /// <remarks />
        public const string Machine = "Machine";

        /// <remarks />
        public const string MachineType = "MachineType";

        /// <remarks />
        public const string Mode = "Mode";

        /// <remarks />
        public const string Motor1 = "Motor1";

        /// <remarks />
        public const string Motor2 = "Motor2";

        /// <remarks />
        public const string Motor3 = "Motor3";

        /// <remarks />
        public const string MotorConveyor = "MotorConveyor";

        /// <remarks />
        public const string MotorType = "MotorType";

        /// <remarks />
        public const string OPCUAServer1 = "Line";

        /// <remarks />
        public const string OPCUAServerType = "OPCUAServerType";

        /// <remarks />
        public const string Proximity = "Proximity";

        /// <remarks />
        public const string ProximitySensor = "ProximitySensor";

        /// <remarks />
        public const string RunFeedback = "RunFeedback";

        /// <remarks />
        public const string Speed = "Speed";

        /// <remarks />
        public const string Start = "Start";

        /// <remarks />
        public const string StartCondition = "StartCondition";

        /// <remarks />
        public const string Stop = "Stop";

        /// <remarks />
        public const string StopCondition = "StopCondition";

        /// <remarks />
        public const string TankBatch = "System";

        /// <remarks />
        public const string TankBatchSystemType = "TankBatchSystemType";

        /// <remarks />
        public const string Temperature = "Temperature";

        /// <remarks />
        public const string TemperatureSensor = "TemperatureSensor";

        /// <remarks />
        public const string Value = "Value";
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