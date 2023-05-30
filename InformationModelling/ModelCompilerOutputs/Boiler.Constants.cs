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

namespace Boiler
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint BoilerStateMachineType_Start = 118;

        /// <remarks />
        public const uint BoilerStateMachineType_Suspend = 119;

        /// <remarks />
        public const uint BoilerStateMachineType_Resume = 120;

        /// <remarks />
        public const uint BoilerStateMachineType_Halt = 121;

        /// <remarks />
        public const uint BoilerStateMachineType_Reset = 122;

        /// <remarks />
        public const uint BoilerType_Simulation_Start = 233;

        /// <remarks />
        public const uint BoilerType_Simulation_Suspend = 234;

        /// <remarks />
        public const uint BoilerType_Simulation_Resume = 235;

        /// <remarks />
        public const uint BoilerType_Simulation_Halt = 236;

        /// <remarks />
        public const uint BoilerType_Simulation_Reset = 237;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_Start = 317;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_Suspend = 318;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_Resume = 319;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_Halt = 320;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_Reset = 321;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint BoilerInputPipeType_FlowTransmitter1 = 125;

        /// <remarks />
        public const uint BoilerInputPipeType_Valve = 132;

        /// <remarks />
        public const uint BoilerDrumType_LevelIndicator = 140;

        /// <remarks />
        public const uint BoilerOutputPipeType_FlowTransmitter2 = 148;

        /// <remarks />
        public const uint BoilerType_InputPipe = 156;

        /// <remarks />
        public const uint BoilerType_InputPipe_FlowTransmitter1 = 157;

        /// <remarks />
        public const uint BoilerType_InputPipe_Valve = 164;

        /// <remarks />
        public const uint BoilerType_Drum = 171;

        /// <remarks />
        public const uint BoilerType_Drum_LevelIndicator = 172;

        /// <remarks />
        public const uint BoilerType_OutputPipe = 179;

        /// <remarks />
        public const uint BoilerType_OutputPipe_FlowTransmitter2 = 180;

        /// <remarks />
        public const uint BoilerType_FlowController = 187;

        /// <remarks />
        public const uint BoilerType_LevelController = 191;

        /// <remarks />
        public const uint BoilerType_CustomController = 195;

        /// <remarks />
        public const uint BoilerType_Simulation = 201;

        /// <remarks />
        public const uint Boilers = 238;

        /// <remarks />
        public const uint Boilers_Boiler1 = 239;

        /// <remarks />
        public const uint Boilers_Boiler1_InputPipe = 240;

        /// <remarks />
        public const uint Boilers_Boiler1_InputPipe_FlowTransmitter1 = 241;

        /// <remarks />
        public const uint Boilers_Boiler1_InputPipe_Valve = 248;

        /// <remarks />
        public const uint Boilers_Boiler1_Drum = 255;

        /// <remarks />
        public const uint Boilers_Boiler1_Drum_LevelIndicator = 256;

        /// <remarks />
        public const uint Boilers_Boiler1_OutputPipe = 263;

        /// <remarks />
        public const uint Boilers_Boiler1_OutputPipe_FlowTransmitter2 = 264;

        /// <remarks />
        public const uint Boilers_Boiler1_FlowController = 271;

        /// <remarks />
        public const uint Boilers_Boiler1_LevelController = 275;

        /// <remarks />
        public const uint Boilers_Boiler1_CustomController = 279;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation = 285;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint GenericControllerType = 4;

        /// <remarks />
        public const uint GenericSensorType = 8;

        /// <remarks />
        public const uint GenericActuatorType = 15;

        /// <remarks />
        public const uint CustomControllerType = 22;

        /// <remarks />
        public const uint ValveType = 28;

        /// <remarks />
        public const uint LevelControllerType = 35;

        /// <remarks />
        public const uint FlowControllerType = 39;

        /// <remarks />
        public const uint LevelIndicatorType = 43;

        /// <remarks />
        public const uint FlowTransmitterType = 50;

        /// <remarks />
        public const uint BoilerStateMachineType = 57;

        /// <remarks />
        public const uint BoilerInputPipeType = 124;

        /// <remarks />
        public const uint BoilerDrumType = 139;

        /// <remarks />
        public const uint BoilerOutputPipeType = 147;

        /// <remarks />
        public const uint BoilerType = 155;
    }
    #endregion

    #region ReferenceType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypes
    {
        /// <remarks />
        public const uint FlowTo = 1;

        /// <remarks />
        public const uint HotFlowTo = 2;

        /// <remarks />
        public const uint SignalTo = 3;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint GenericControllerType_Measurement = 5;

        /// <remarks />
        public const uint GenericControllerType_SetPoint = 6;

        /// <remarks />
        public const uint GenericControllerType_ControlOut = 7;

        /// <remarks />
        public const uint GenericSensorType_Output = 9;

        /// <remarks />
        public const uint GenericSensorType_Output_EURange = 13;

        /// <remarks />
        public const uint GenericActuatorType_Input = 16;

        /// <remarks />
        public const uint GenericActuatorType_Input_EURange = 20;

        /// <remarks />
        public const uint CustomControllerType_Input1 = 23;

        /// <remarks />
        public const uint CustomControllerType_Input2 = 24;

        /// <remarks />
        public const uint CustomControllerType_Input3 = 25;

        /// <remarks />
        public const uint CustomControllerType_ControlOut = 26;

        /// <remarks />
        public const uint CustomControllerType_DescriptionX = 27;

        /// <remarks />
        public const uint ValveType_Input_EURange = 33;

        /// <remarks />
        public const uint LevelIndicatorType_Output_EURange = 48;

        /// <remarks />
        public const uint FlowTransmitterType_Output_EURange = 55;

        /// <remarks />
        public const uint BoilerStateMachineType_CurrentState_Id = 59;

        /// <remarks />
        public const uint BoilerStateMachineType_CurrentState_Number = 61;

        /// <remarks />
        public const uint BoilerStateMachineType_LastTransition_Id = 64;

        /// <remarks />
        public const uint BoilerStateMachineType_LastTransition_Number = 66;

        /// <remarks />
        public const uint BoilerStateMachineType_LastTransition_TransitionTime = 67;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_CreateSessionId = 79;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_CreateClientName = 80;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_InvocationCreationTime = 81;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_LastTransitionTime = 82;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_LastMethodCall = 83;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_LastMethodSessionId = 84;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_LastMethodInputArguments = 85;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_LastMethodOutputArguments = 86;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_LastMethodInputValues = 87;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_LastMethodOutputValues = 88;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_LastMethodCallTime = 89;

        /// <remarks />
        public const uint BoilerStateMachineType_ProgramDiagnostic_LastMethodReturnStatus = 90;

        /// <remarks />
        public const uint BoilerStateMachineType_Halted_StateNumber = 93;

        /// <remarks />
        public const uint BoilerStateMachineType_Ready_StateNumber = 95;

        /// <remarks />
        public const uint BoilerStateMachineType_Running_StateNumber = 97;

        /// <remarks />
        public const uint BoilerStateMachineType_Suspended_StateNumber = 99;

        /// <remarks />
        public const uint BoilerStateMachineType_HaltedToReady_TransitionNumber = 101;

        /// <remarks />
        public const uint BoilerStateMachineType_ReadyToRunning_TransitionNumber = 103;

        /// <remarks />
        public const uint BoilerStateMachineType_RunningToHalted_TransitionNumber = 105;

        /// <remarks />
        public const uint BoilerStateMachineType_RunningToReady_TransitionNumber = 107;

        /// <remarks />
        public const uint BoilerStateMachineType_RunningToSuspended_TransitionNumber = 109;

        /// <remarks />
        public const uint BoilerStateMachineType_SuspendedToRunning_TransitionNumber = 111;

        /// <remarks />
        public const uint BoilerStateMachineType_SuspendedToHalted_TransitionNumber = 113;

        /// <remarks />
        public const uint BoilerStateMachineType_SuspendedToReady_TransitionNumber = 115;

        /// <remarks />
        public const uint BoilerStateMachineType_ReadyToHalted_TransitionNumber = 117;

        /// <remarks />
        public const uint BoilerStateMachineType_UpdateRate = 123;

        /// <remarks />
        public const uint BoilerInputPipeType_FlowTransmitter1_Output = 126;

        /// <remarks />
        public const uint BoilerInputPipeType_FlowTransmitter1_Output_EURange = 130;

        /// <remarks />
        public const uint BoilerInputPipeType_Valve_Input = 133;

        /// <remarks />
        public const uint BoilerInputPipeType_Valve_Input_EURange = 137;

        /// <remarks />
        public const uint BoilerDrumType_LevelIndicator_Output = 141;

        /// <remarks />
        public const uint BoilerDrumType_LevelIndicator_Output_EURange = 145;

        /// <remarks />
        public const uint BoilerOutputPipeType_FlowTransmitter2_Output = 149;

        /// <remarks />
        public const uint BoilerOutputPipeType_FlowTransmitter2_Output_EURange = 153;

        /// <remarks />
        public const uint BoilerType_InputPipe_FlowTransmitter1_Output = 158;

        /// <remarks />
        public const uint BoilerType_InputPipe_FlowTransmitter1_Output_EURange = 162;

        /// <remarks />
        public const uint BoilerType_InputPipe_Valve_Input = 165;

        /// <remarks />
        public const uint BoilerType_InputPipe_Valve_Input_EURange = 169;

        /// <remarks />
        public const uint BoilerType_Drum_LevelIndicator_Output = 173;

        /// <remarks />
        public const uint BoilerType_Drum_LevelIndicator_Output_EURange = 177;

        /// <remarks />
        public const uint BoilerType_OutputPipe_FlowTransmitter2_Output = 181;

        /// <remarks />
        public const uint BoilerType_OutputPipe_FlowTransmitter2_Output_EURange = 185;

        /// <remarks />
        public const uint BoilerType_FlowController_Measurement = 188;

        /// <remarks />
        public const uint BoilerType_FlowController_SetPoint = 189;

        /// <remarks />
        public const uint BoilerType_FlowController_ControlOut = 190;

        /// <remarks />
        public const uint BoilerType_LevelController_Measurement = 192;

        /// <remarks />
        public const uint BoilerType_LevelController_SetPoint = 193;

        /// <remarks />
        public const uint BoilerType_LevelController_ControlOut = 194;

        /// <remarks />
        public const uint BoilerType_CustomController_Input1 = 196;

        /// <remarks />
        public const uint BoilerType_CustomController_Input2 = 197;

        /// <remarks />
        public const uint BoilerType_CustomController_Input3 = 198;

        /// <remarks />
        public const uint BoilerType_CustomController_ControlOut = 199;

        /// <remarks />
        public const uint BoilerType_CustomController_DescriptionX = 200;

        /// <remarks />
        public const uint BoilerType_Simulation_CurrentState = 202;

        /// <remarks />
        public const uint BoilerType_Simulation_CurrentState_Id = 203;

        /// <remarks />
        public const uint BoilerType_Simulation_CurrentState_Number = 205;

        /// <remarks />
        public const uint BoilerType_Simulation_LastTransition = 207;

        /// <remarks />
        public const uint BoilerType_Simulation_LastTransition_Id = 208;

        /// <remarks />
        public const uint BoilerType_Simulation_LastTransition_Number = 210;

        /// <remarks />
        public const uint BoilerType_Simulation_LastTransition_TransitionTime = 211;

        /// <remarks />
        public const uint BoilerType_Simulation_Deletable = 215;

        /// <remarks />
        public const uint BoilerType_Simulation_AutoDelete = 216;

        /// <remarks />
        public const uint BoilerType_Simulation_RecycleCount = 217;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_CreateSessionId = 219;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_CreateClientName = 220;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_InvocationCreationTime = 221;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_LastTransitionTime = 222;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_LastMethodCall = 223;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_LastMethodSessionId = 224;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_LastMethodInputArguments = 225;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_LastMethodOutputArguments = 226;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_LastMethodInputValues = 227;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_LastMethodOutputValues = 228;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_LastMethodCallTime = 229;

        /// <remarks />
        public const uint BoilerType_Simulation_ProgramDiagnostic_LastMethodReturnStatus = 230;

        /// <remarks />
        public const uint BoilerType_Simulation_UpdateRate = 232;

        /// <remarks />
        public const uint Boilers_Boiler1_InputPipe_FlowTransmitter1_Output = 242;

        /// <remarks />
        public const uint Boilers_Boiler1_InputPipe_FlowTransmitter1_Output_EURange = 246;

        /// <remarks />
        public const uint Boilers_Boiler1_InputPipe_Valve_Input = 249;

        /// <remarks />
        public const uint Boilers_Boiler1_InputPipe_Valve_Input_EURange = 253;

        /// <remarks />
        public const uint Boilers_Boiler1_Drum_LevelIndicator_Output = 257;

        /// <remarks />
        public const uint Boilers_Boiler1_Drum_LevelIndicator_Output_EURange = 261;

        /// <remarks />
        public const uint Boilers_Boiler1_OutputPipe_FlowTransmitter2_Output = 265;

        /// <remarks />
        public const uint Boilers_Boiler1_OutputPipe_FlowTransmitter2_Output_EURange = 269;

        /// <remarks />
        public const uint Boilers_Boiler1_FlowController_Measurement = 272;

        /// <remarks />
        public const uint Boilers_Boiler1_FlowController_SetPoint = 273;

        /// <remarks />
        public const uint Boilers_Boiler1_FlowController_ControlOut = 274;

        /// <remarks />
        public const uint Boilers_Boiler1_LevelController_Measurement = 276;

        /// <remarks />
        public const uint Boilers_Boiler1_LevelController_SetPoint = 277;

        /// <remarks />
        public const uint Boilers_Boiler1_LevelController_ControlOut = 278;

        /// <remarks />
        public const uint Boilers_Boiler1_CustomController_Input1 = 280;

        /// <remarks />
        public const uint Boilers_Boiler1_CustomController_Input2 = 281;

        /// <remarks />
        public const uint Boilers_Boiler1_CustomController_Input3 = 282;

        /// <remarks />
        public const uint Boilers_Boiler1_CustomController_ControlOut = 283;

        /// <remarks />
        public const uint Boilers_Boiler1_CustomController_DescriptionX = 284;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_CurrentState = 286;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_CurrentState_Id = 287;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_CurrentState_Number = 289;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_LastTransition = 291;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_LastTransition_Id = 292;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_LastTransition_Number = 294;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_LastTransition_TransitionTime = 295;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_Deletable = 299;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_AutoDelete = 300;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_RecycleCount = 301;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_CreateSessionId = 303;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_CreateClientName = 304;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_InvocationCreationTime = 305;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_LastTransitionTime = 306;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodCall = 307;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodSessionId = 308;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodInputArguments = 309;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodOutputArguments = 310;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodInputValues = 311;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodOutputValues = 312;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodCallTime = 313;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodReturnStatus = 314;

        /// <remarks />
        public const uint Boilers_Boiler1_Simulation_UpdateRate = 316;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_Start = new ExpandedNodeId(Boiler.Methods.BoilerStateMachineType_Start, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_Suspend = new ExpandedNodeId(Boiler.Methods.BoilerStateMachineType_Suspend, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_Resume = new ExpandedNodeId(Boiler.Methods.BoilerStateMachineType_Resume, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_Halt = new ExpandedNodeId(Boiler.Methods.BoilerStateMachineType_Halt, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_Reset = new ExpandedNodeId(Boiler.Methods.BoilerStateMachineType_Reset, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_Start = new ExpandedNodeId(Boiler.Methods.BoilerType_Simulation_Start, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_Suspend = new ExpandedNodeId(Boiler.Methods.BoilerType_Simulation_Suspend, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_Resume = new ExpandedNodeId(Boiler.Methods.BoilerType_Simulation_Resume, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_Halt = new ExpandedNodeId(Boiler.Methods.BoilerType_Simulation_Halt, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_Reset = new ExpandedNodeId(Boiler.Methods.BoilerType_Simulation_Reset, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_Start = new ExpandedNodeId(Boiler.Methods.Boilers_Boiler1_Simulation_Start, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_Suspend = new ExpandedNodeId(Boiler.Methods.Boilers_Boiler1_Simulation_Suspend, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_Resume = new ExpandedNodeId(Boiler.Methods.Boilers_Boiler1_Simulation_Resume, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_Halt = new ExpandedNodeId(Boiler.Methods.Boilers_Boiler1_Simulation_Halt, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_Reset = new ExpandedNodeId(Boiler.Methods.Boilers_Boiler1_Simulation_Reset, Boiler.Namespaces.Boiler);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BoilerInputPipeType_FlowTransmitter1 = new ExpandedNodeId(Boiler.Objects.BoilerInputPipeType_FlowTransmitter1, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerInputPipeType_Valve = new ExpandedNodeId(Boiler.Objects.BoilerInputPipeType_Valve, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerDrumType_LevelIndicator = new ExpandedNodeId(Boiler.Objects.BoilerDrumType_LevelIndicator, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerOutputPipeType_FlowTransmitter2 = new ExpandedNodeId(Boiler.Objects.BoilerOutputPipeType_FlowTransmitter2, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_InputPipe = new ExpandedNodeId(Boiler.Objects.BoilerType_InputPipe, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_InputPipe_FlowTransmitter1 = new ExpandedNodeId(Boiler.Objects.BoilerType_InputPipe_FlowTransmitter1, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_InputPipe_Valve = new ExpandedNodeId(Boiler.Objects.BoilerType_InputPipe_Valve, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Drum = new ExpandedNodeId(Boiler.Objects.BoilerType_Drum, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Drum_LevelIndicator = new ExpandedNodeId(Boiler.Objects.BoilerType_Drum_LevelIndicator, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_OutputPipe = new ExpandedNodeId(Boiler.Objects.BoilerType_OutputPipe, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_OutputPipe_FlowTransmitter2 = new ExpandedNodeId(Boiler.Objects.BoilerType_OutputPipe_FlowTransmitter2, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_FlowController = new ExpandedNodeId(Boiler.Objects.BoilerType_FlowController, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_LevelController = new ExpandedNodeId(Boiler.Objects.BoilerType_LevelController, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_CustomController = new ExpandedNodeId(Boiler.Objects.BoilerType_CustomController, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation = new ExpandedNodeId(Boiler.Objects.BoilerType_Simulation, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers = new ExpandedNodeId(Boiler.Objects.Boilers, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1 = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_InputPipe = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_InputPipe, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_InputPipe_FlowTransmitter1 = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_InputPipe_FlowTransmitter1, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_InputPipe_Valve = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_InputPipe_Valve, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Drum = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_Drum, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Drum_LevelIndicator = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_Drum_LevelIndicator, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_OutputPipe = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_OutputPipe, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_OutputPipe_FlowTransmitter2 = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_OutputPipe_FlowTransmitter2, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_FlowController = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_FlowController, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_LevelController = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_LevelController, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_CustomController = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_CustomController, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation = new ExpandedNodeId(Boiler.Objects.Boilers_Boiler1_Simulation, Boiler.Namespaces.Boiler);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericControllerType = new ExpandedNodeId(Boiler.ObjectTypes.GenericControllerType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(Boiler.ObjectTypes.GenericSensorType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType = new ExpandedNodeId(Boiler.ObjectTypes.GenericActuatorType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId CustomControllerType = new ExpandedNodeId(Boiler.ObjectTypes.CustomControllerType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(Boiler.ObjectTypes.ValveType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId LevelControllerType = new ExpandedNodeId(Boiler.ObjectTypes.LevelControllerType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId FlowControllerType = new ExpandedNodeId(Boiler.ObjectTypes.FlowControllerType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId LevelIndicatorType = new ExpandedNodeId(Boiler.ObjectTypes.LevelIndicatorType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId FlowTransmitterType = new ExpandedNodeId(Boiler.ObjectTypes.FlowTransmitterType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType = new ExpandedNodeId(Boiler.ObjectTypes.BoilerStateMachineType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerInputPipeType = new ExpandedNodeId(Boiler.ObjectTypes.BoilerInputPipeType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerDrumType = new ExpandedNodeId(Boiler.ObjectTypes.BoilerDrumType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerOutputPipeType = new ExpandedNodeId(Boiler.ObjectTypes.BoilerOutputPipeType, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType = new ExpandedNodeId(Boiler.ObjectTypes.BoilerType, Boiler.Namespaces.Boiler);
    }
    #endregion

    #region ReferenceType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId FlowTo = new ExpandedNodeId(Boiler.ReferenceTypes.FlowTo, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId HotFlowTo = new ExpandedNodeId(Boiler.ReferenceTypes.HotFlowTo, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId SignalTo = new ExpandedNodeId(Boiler.ReferenceTypes.SignalTo, Boiler.Namespaces.Boiler);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericControllerType_Measurement = new ExpandedNodeId(Boiler.Variables.GenericControllerType_Measurement, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId GenericControllerType_SetPoint = new ExpandedNodeId(Boiler.Variables.GenericControllerType_SetPoint, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId GenericControllerType_ControlOut = new ExpandedNodeId(Boiler.Variables.GenericControllerType_ControlOut, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Output = new ExpandedNodeId(Boiler.Variables.GenericSensorType_Output, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Output_EURange = new ExpandedNodeId(Boiler.Variables.GenericSensorType_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(Boiler.Variables.GenericActuatorType_Input, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input_EURange = new ExpandedNodeId(Boiler.Variables.GenericActuatorType_Input_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId CustomControllerType_Input1 = new ExpandedNodeId(Boiler.Variables.CustomControllerType_Input1, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId CustomControllerType_Input2 = new ExpandedNodeId(Boiler.Variables.CustomControllerType_Input2, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId CustomControllerType_Input3 = new ExpandedNodeId(Boiler.Variables.CustomControllerType_Input3, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId CustomControllerType_ControlOut = new ExpandedNodeId(Boiler.Variables.CustomControllerType_ControlOut, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId CustomControllerType_DescriptionX = new ExpandedNodeId(Boiler.Variables.CustomControllerType_DescriptionX, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId ValveType_Input_EURange = new ExpandedNodeId(Boiler.Variables.ValveType_Input_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId LevelIndicatorType_Output_EURange = new ExpandedNodeId(Boiler.Variables.LevelIndicatorType_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId FlowTransmitterType_Output_EURange = new ExpandedNodeId(Boiler.Variables.FlowTransmitterType_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_CurrentState_Id = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_CurrentState_Id, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_CurrentState_Number = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_CurrentState_Number, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_LastTransition_Id = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_LastTransition_Id, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_LastTransition_Number = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_LastTransition_Number, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_LastTransition_TransitionTime = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_LastTransition_TransitionTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_CreateSessionId, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_CreateClientName, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_InvocationCreationTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_LastTransitionTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_LastMethodCall, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_LastMethodSessionId, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_LastMethodInputArguments, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_LastMethodOutputArguments, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_LastMethodInputValues, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_LastMethodOutputValues, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_LastMethodCallTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ProgramDiagnostic_LastMethodReturnStatus, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_Halted_StateNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_Halted_StateNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_Ready_StateNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_Ready_StateNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_Running_StateNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_Running_StateNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_Suspended_StateNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_Suspended_StateNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_HaltedToReady_TransitionNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_HaltedToReady_TransitionNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ReadyToRunning_TransitionNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_RunningToHalted_TransitionNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_RunningToHalted_TransitionNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_RunningToReady_TransitionNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_RunningToReady_TransitionNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_RunningToSuspended_TransitionNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_SuspendedToRunning_TransitionNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_SuspendedToHalted_TransitionNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_SuspendedToReady_TransitionNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_ReadyToHalted_TransitionNumber, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerStateMachineType_UpdateRate = new ExpandedNodeId(Boiler.Variables.BoilerStateMachineType_UpdateRate, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerInputPipeType_FlowTransmitter1_Output = new ExpandedNodeId(Boiler.Variables.BoilerInputPipeType_FlowTransmitter1_Output, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerInputPipeType_FlowTransmitter1_Output_EURange = new ExpandedNodeId(Boiler.Variables.BoilerInputPipeType_FlowTransmitter1_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerInputPipeType_Valve_Input = new ExpandedNodeId(Boiler.Variables.BoilerInputPipeType_Valve_Input, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerInputPipeType_Valve_Input_EURange = new ExpandedNodeId(Boiler.Variables.BoilerInputPipeType_Valve_Input_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerDrumType_LevelIndicator_Output = new ExpandedNodeId(Boiler.Variables.BoilerDrumType_LevelIndicator_Output, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerDrumType_LevelIndicator_Output_EURange = new ExpandedNodeId(Boiler.Variables.BoilerDrumType_LevelIndicator_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerOutputPipeType_FlowTransmitter2_Output = new ExpandedNodeId(Boiler.Variables.BoilerOutputPipeType_FlowTransmitter2_Output, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerOutputPipeType_FlowTransmitter2_Output_EURange = new ExpandedNodeId(Boiler.Variables.BoilerOutputPipeType_FlowTransmitter2_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_InputPipe_FlowTransmitter1_Output = new ExpandedNodeId(Boiler.Variables.BoilerType_InputPipe_FlowTransmitter1_Output, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_InputPipe_FlowTransmitter1_Output_EURange = new ExpandedNodeId(Boiler.Variables.BoilerType_InputPipe_FlowTransmitter1_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_InputPipe_Valve_Input = new ExpandedNodeId(Boiler.Variables.BoilerType_InputPipe_Valve_Input, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_InputPipe_Valve_Input_EURange = new ExpandedNodeId(Boiler.Variables.BoilerType_InputPipe_Valve_Input_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Drum_LevelIndicator_Output = new ExpandedNodeId(Boiler.Variables.BoilerType_Drum_LevelIndicator_Output, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Drum_LevelIndicator_Output_EURange = new ExpandedNodeId(Boiler.Variables.BoilerType_Drum_LevelIndicator_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_OutputPipe_FlowTransmitter2_Output = new ExpandedNodeId(Boiler.Variables.BoilerType_OutputPipe_FlowTransmitter2_Output, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_OutputPipe_FlowTransmitter2_Output_EURange = new ExpandedNodeId(Boiler.Variables.BoilerType_OutputPipe_FlowTransmitter2_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_FlowController_Measurement = new ExpandedNodeId(Boiler.Variables.BoilerType_FlowController_Measurement, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_FlowController_SetPoint = new ExpandedNodeId(Boiler.Variables.BoilerType_FlowController_SetPoint, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_FlowController_ControlOut = new ExpandedNodeId(Boiler.Variables.BoilerType_FlowController_ControlOut, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_LevelController_Measurement = new ExpandedNodeId(Boiler.Variables.BoilerType_LevelController_Measurement, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_LevelController_SetPoint = new ExpandedNodeId(Boiler.Variables.BoilerType_LevelController_SetPoint, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_LevelController_ControlOut = new ExpandedNodeId(Boiler.Variables.BoilerType_LevelController_ControlOut, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_CustomController_Input1 = new ExpandedNodeId(Boiler.Variables.BoilerType_CustomController_Input1, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_CustomController_Input2 = new ExpandedNodeId(Boiler.Variables.BoilerType_CustomController_Input2, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_CustomController_Input3 = new ExpandedNodeId(Boiler.Variables.BoilerType_CustomController_Input3, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_CustomController_ControlOut = new ExpandedNodeId(Boiler.Variables.BoilerType_CustomController_ControlOut, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_CustomController_DescriptionX = new ExpandedNodeId(Boiler.Variables.BoilerType_CustomController_DescriptionX, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_CurrentState = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_CurrentState, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_CurrentState_Id = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_CurrentState_Id, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_CurrentState_Number = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_CurrentState_Number, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_LastTransition = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_LastTransition, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_LastTransition_Id = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_LastTransition_Id, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_LastTransition_Number = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_LastTransition_Number, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_LastTransition_TransitionTime = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_LastTransition_TransitionTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_Deletable = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_Deletable, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_AutoDelete = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_AutoDelete, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_RecycleCount = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_RecycleCount, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_CreateSessionId, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_CreateClientName, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_InvocationCreationTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_LastTransitionTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_LastMethodCall, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_LastMethodSessionId, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_LastMethodInputArguments, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_LastMethodOutputArguments, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_LastMethodInputValues, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_LastMethodOutputValues, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_LastMethodCallTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_ProgramDiagnostic_LastMethodReturnStatus, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId BoilerType_Simulation_UpdateRate = new ExpandedNodeId(Boiler.Variables.BoilerType_Simulation_UpdateRate, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_InputPipe_FlowTransmitter1_Output = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_InputPipe_FlowTransmitter1_Output, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_InputPipe_FlowTransmitter1_Output_EURange = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_InputPipe_FlowTransmitter1_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_InputPipe_Valve_Input = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_InputPipe_Valve_Input, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_InputPipe_Valve_Input_EURange = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_InputPipe_Valve_Input_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Drum_LevelIndicator_Output = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Drum_LevelIndicator_Output, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Drum_LevelIndicator_Output_EURange = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Drum_LevelIndicator_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_OutputPipe_FlowTransmitter2_Output = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_OutputPipe_FlowTransmitter2_Output, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_OutputPipe_FlowTransmitter2_Output_EURange = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_OutputPipe_FlowTransmitter2_Output_EURange, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_FlowController_Measurement = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_FlowController_Measurement, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_FlowController_SetPoint = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_FlowController_SetPoint, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_FlowController_ControlOut = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_FlowController_ControlOut, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_LevelController_Measurement = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_LevelController_Measurement, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_LevelController_SetPoint = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_LevelController_SetPoint, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_LevelController_ControlOut = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_LevelController_ControlOut, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_CustomController_Input1 = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_CustomController_Input1, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_CustomController_Input2 = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_CustomController_Input2, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_CustomController_Input3 = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_CustomController_Input3, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_CustomController_ControlOut = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_CustomController_ControlOut, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_CustomController_DescriptionX = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_CustomController_DescriptionX, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_CurrentState = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_CurrentState, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_CurrentState_Id = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_CurrentState_Id, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_CurrentState_Number = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_CurrentState_Number, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_LastTransition = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_LastTransition, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_LastTransition_Id = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_LastTransition_Id, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_LastTransition_Number = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_LastTransition_Number, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_LastTransition_TransitionTime = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_LastTransition_TransitionTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_Deletable = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_Deletable, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_AutoDelete = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_AutoDelete, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_RecycleCount = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_RecycleCount, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_CreateSessionId, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_CreateClientName, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_InvocationCreationTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_LastTransitionTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodCall, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodSessionId, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodInputArguments, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodOutputArguments, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodInputValues, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodOutputValues, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodCallTime, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_ProgramDiagnostic_LastMethodReturnStatus, Boiler.Namespaces.Boiler);

        /// <remarks />
        public static readonly ExpandedNodeId Boilers_Boiler1_Simulation_UpdateRate = new ExpandedNodeId(Boiler.Variables.Boilers_Boiler1_Simulation_UpdateRate, Boiler.Namespaces.Boiler);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Boiler1 = "Boiler #1";

        /// <remarks />
        public const string BoilerDrumType = "BoilerDrumType";

        /// <remarks />
        public const string BoilerInputPipeType = "BoilerInputPipeType";

        /// <remarks />
        public const string BoilerOutputPipeType = "BoilerOutputPipeType";

        /// <remarks />
        public const string Boilers = "Boilers";

        /// <remarks />
        public const string BoilerStateMachineType = "BoilerStateMachineType";

        /// <remarks />
        public const string BoilerType = "BoilerType";

        /// <remarks />
        public const string ControlOut = "ControlOut";

        /// <remarks />
        public const string CustomController = "CCX001";

        /// <remarks />
        public const string CustomControllerType = "CustomControllerType";

        /// <remarks />
        public const string DescriptionX = "Description";

        /// <remarks />
        public const string Drum = "DrumX001";

        /// <remarks />
        public const string FlowController = "FCX001";

        /// <remarks />
        public const string FlowControllerType = "FlowControllerType";

        /// <remarks />
        public const string FlowTo = "FlowTo";

        /// <remarks />
        public const string FlowTransmitter1 = "FTX001";

        /// <remarks />
        public const string FlowTransmitter2 = "FTX002";

        /// <remarks />
        public const string FlowTransmitterType = "FlowTransmitterType";

        /// <remarks />
        public const string GenericActuatorType = "GenericActuatorType";

        /// <remarks />
        public const string GenericControllerType = "GenericControllerType";

        /// <remarks />
        public const string GenericSensorType = "GenericSensorType";

        /// <remarks />
        public const string Halt = "Halt";

        /// <remarks />
        public const string HotFlowTo = "HotFlowTo";

        /// <remarks />
        public const string Input = "Input";

        /// <remarks />
        public const string Input1 = "Input1";

        /// <remarks />
        public const string Input2 = "Input2";

        /// <remarks />
        public const string Input3 = "Input3";

        /// <remarks />
        public const string InputPipe = "PipeX001";

        /// <remarks />
        public const string LevelController = "LCX001";

        /// <remarks />
        public const string LevelControllerType = "LevelControllerType";

        /// <remarks />
        public const string LevelIndicator = "LIX001";

        /// <remarks />
        public const string LevelIndicatorType = "LevelIndicatorType";

        /// <remarks />
        public const string Measurement = "Measurement";

        /// <remarks />
        public const string Output = "Output";

        /// <remarks />
        public const string OutputPipe = "PipeX002";

        /// <remarks />
        public const string Reset = "Reset";

        /// <remarks />
        public const string Resume = "Resume";

        /// <remarks />
        public const string SetPoint = "SetPoint";

        /// <remarks />
        public const string SignalTo = "SignalTo";

        /// <remarks />
        public const string Simulation = "Simulation";

        /// <remarks />
        public const string Start = "Start";

        /// <remarks />
        public const string Suspend = "Suspend";

        /// <remarks />
        public const string UpdateRate = "UpdateRate";

        /// <remarks />
        public const string Valve = "ValveX001";

        /// <remarks />
        public const string ValveType = "ValveType";
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
        /// The URI for the Boiler namespace (.NET code namespace is 'Boiler').
        /// </summary>
        public const string Boiler = "http://opcfoundation.org/UA/Boiler/";
    }
    #endregion
}