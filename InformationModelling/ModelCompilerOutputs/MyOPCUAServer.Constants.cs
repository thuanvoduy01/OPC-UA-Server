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
    #region DataType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <remarks />
        public const uint ActuatorStateTypeEnum = 3613;

        /// <remarks />
        public const uint AlarmStateTypeEnum = 3615;

        /// <remarks />
        public const uint AssetDescriptionType = 3617;

        /// <remarks />
        public const uint AssetAttrDataType = 3618;

        /// <remarks />
        public const uint AssetBufferSizeDataType = 3619;

        /// <remarks />
        public const uint AssetIdDataType = 3620;

        /// <remarks />
        public const uint AvailabilityTypeEnum = 3621;

        /// <remarks />
        public const uint AxesCouplingTypeEnum = 3623;

        /// <remarks />
        public const uint AxesListValueDataType = 3625;

        /// <remarks />
        public const uint BufferSizeDataType = 3626;

        /// <remarks />
        public const uint CalibrationDateDataType = 3627;

        /// <remarks />
        public const uint CalibrationInitialsDataType = 3628;

        /// <remarks />
        public const uint CategoryTypeEnum = 3629;

        /// <remarks />
        public const uint ChannelNumberDataType = 3631;

        /// <remarks />
        public const uint ClampStateTypeEnum = 3632;

        /// <remarks />
        public const uint ConditionDescriptionDataType = 3634;

        /// <remarks />
        public const uint ControllerModeTypeEnum = 3635;

        /// <remarks />
        public const uint CoordinateSystemTypeEnum = 3637;

        /// <remarks />
        public const uint IDDataType = 3639;

        /// <remarks />
        public const uint CodeDataType = 3640;

        /// <remarks />
        public const uint ComponentIdDataType = 3641;

        /// <remarks />
        public const uint ConnectionCodeMachineSideDataType = 3642;

        /// <remarks />
        public const uint CountValueDataType = 3643;

        /// <remarks />
        public const uint CreationTimeDataType = 3644;

        /// <remarks />
        public const uint CutterStatusValueTypeEnum = 3645;

        /// <remarks />
        public const uint DataItemEnumDataType = 3647;

        /// <remarks />
        public const uint DataItemEnumTypeEnum = 3648;

        /// <remarks />
        public const uint DataItemIdDataType = 3650;

        /// <remarks />
        public const uint DataItemStatisticsDataType = 3651;

        /// <remarks />
        public const uint DataItemStatisticsTypeEnum = 3652;

        /// <remarks />
        public const uint DataItemSubEnumTypeEnum = 3654;

        /// <remarks />
        public const uint DefinitionFormatTypeEnum = 3656;

        /// <remarks />
        public const uint DecibelValueDataType = 3658;

        /// <remarks />
        public const uint DescriptionTextDataType = 3659;

        /// <remarks />
        public const uint DirectionTypeEnum = 3660;

        /// <remarks />
        public const uint DoorStateTypeEnum = 3662;

        /// <remarks />
        public const uint DurationTimeDataType = 3664;

        /// <remarks />
        public const uint DurationValueDataType = 3665;

        /// <remarks />
        public const uint EdgeCountDataType = 3666;

        /// <remarks />
        public const uint EmergencyStopTypeEnum = 3667;

        /// <remarks />
        public const uint EnergyValueDataType = 3669;

        /// <remarks />
        public const uint ExecutionTypeEnum = 3670;

        /// <remarks />
        public const uint FeedrateValueDataType = 3672;

        /// <remarks />
        public const uint FirmwareVersionDataType = 3673;

        /// <remarks />
        public const uint ForceValueDataType = 3674;

        /// <remarks />
        public const uint GradeDataType = 3675;

        /// <remarks />
        public const uint IndexRangeDataType = 3676;

        /// <remarks />
        public const uint InstanceIdDataType = 3677;

        /// <remarks />
        public const uint ItemIdDataType = 3678;

        /// <remarks />
        public const uint InterfaceStateTypeEnum = 3679;

        /// <remarks />
        public const uint ItemSourceDataType = 3681;

        /// <remarks />
        public const uint LocationSizeDataType = 3682;

        /// <remarks />
        public const uint LocationValueDataType = 3683;

        /// <remarks />
        public const uint LocationsTypeEnum = 3684;

        /// <remarks />
        public const uint LocusDataType = 3686;

        /// <remarks />
        public const uint ManufacturersDataType = 3687;

        /// <remarks />
        public const uint MassValueDataType = 3688;

        /// <remarks />
        public const uint MaximumCountDataType = 3689;

        /// <remarks />
        public const uint MaximumDataType = 3690;

        /// <remarks />
        public const uint MeasurementValueDataType = 3691;

        /// <remarks />
        public const uint MinimumDataType = 3692;

        /// <remarks />
        public const uint ModelDataType = 3693;

        /// <remarks />
        public const uint NameDataType = 3694;

        /// <remarks />
        public const uint NativeCodeDataType = 3695;

        /// <remarks />
        public const uint NativeNotifcationCodeDataType = 3696;

        /// <remarks />
        public const uint NativeScaleDataType = 3697;

        /// <remarks />
        public const uint NativeSeverityDataType = 3698;

        /// <remarks />
        public const uint NextCalibrationDateDataType = 3699;

        /// <remarks />
        public const uint NominalDataType = 3700;

        /// <remarks />
        public const uint NotificationCodeTypeEnum = 3701;

        /// <remarks />
        public const uint NotificationDescriptionDataType = 3703;

        /// <remarks />
        public const uint OccurrenceTimeDataType = 3704;

        /// <remarks />
        public const uint OverlapDataType = 3705;

        /// <remarks />
        public const uint PathModeTypeEnum = 3706;

        /// <remarks />
        public const uint PowerStateTypeEnum = 3708;

        /// <remarks />
        public const uint ProgramToolNumberDataType = 3710;

        /// <remarks />
        public const uint QualifierTypeEnum = 3711;

        /// <remarks />
        public const uint RateDataType = 3713;

        /// <remarks />
        public const uint ReconditionCountValueDataType = 3714;

        /// <remarks />
        public const uint RotaryModeTypeEnum = 3715;

        /// <remarks />
        public const uint SampleRateDataType = 3717;

        /// <remarks />
        public const uint SeverityTypeEnum = 3718;

        /// <remarks />
        public const uint SignificantDigitsValueDataType = 3720;

        /// <remarks />
        public const uint StationDataType = 3721;

        /// <remarks />
        public const uint SenderDataType = 3722;

        /// <remarks />
        public const uint SequenceDataType = 3723;

        /// <remarks />
        public const uint SerialNumberDataType = 3724;

        /// <remarks />
        public const uint SpeedDataType = 3725;

        /// <remarks />
        public const uint TestIndicatorDataType = 3726;

        /// <remarks />
        public const uint ToolEventValueDataType = 3727;

        /// <remarks />
        public const uint ToolGroupDataType = 3728;

        /// <remarks />
        public const uint ToolIdDataType = 3729;

        /// <remarks />
        public const uint ToolLifeDirectionTypeEnum = 3730;

        /// <remarks />
        public const uint ToolLifeTypeEnum = 3732;

        /// <remarks />
        public const uint ToolLifeValueDataType = 3734;

        /// <remarks />
        public const uint UnitsExtDataType = 3735;

        /// <remarks />
        public const uint VersionDataType = 3736;

        /// <remarks />
        public const uint VibrationValueDataType = 3737;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint MTDevices = 5;

        /// <remarks />
        public const uint MTDeviceType_DataItems = 17;

        /// <remarks />
        public const uint MTDeviceType_Components = 18;

        /// <remarks />
        public const uint MTDeviceType_Conditions = 19;

        /// <remarks />
        public const uint MTConditionType_LimitState = 631;

        /// <remarks />
        public const uint CuttingItemType_ItemLife = 3597;

        /// <remarks />
        public const uint CuttingItemType_Measurements = 3598;

        /// <remarks />
        public const uint DataItemEnumDataType_Encoding_DefaultBinary = 3738;

        /// <remarks />
        public const uint DataItemStatisticsDataType_Encoding_DefaultBinary = 3739;

        /// <remarks />
        public const uint DataItemEnumDataType_Encoding_DefaultXml = 3750;

        /// <remarks />
        public const uint DataItemStatisticsDataType_Encoding_DefaultXml = 3751;

        /// <remarks />
        public const uint DataItemEnumDataType_Encoding_DefaultJson = 3762;

        /// <remarks />
        public const uint DataItemStatisticsDataType_Encoding_DefaultJson = 3763;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint MTDevicesType = 1;

        /// <remarks />
        public const uint MTDeviceType = 9;

        /// <remarks />
        public const uint MTComponentType = 20;

        /// <remarks />
        public const uint MTAxesType = 33;

        /// <remarks />
        public const uint MTControllerType = 50;

        /// <remarks />
        public const uint MTDoorType = 61;

        /// <remarks />
        public const uint MTActuatorType = 73;

        /// <remarks />
        public const uint MTConditionType = 580;

        /// <remarks />
        public const uint AccelerationConditionType = 647;

        /// <remarks />
        public const uint Accumulated_TimeConditionType = 714;

        /// <remarks />
        public const uint AmperageConditionType = 781;

        /// <remarks />
        public const uint AngleConditionType = 848;

        /// <remarks />
        public const uint Angular-AccelerationConditionType = 915;

        /// <remarks />
        public const uint Angular_VelocityConditionType = 982;

        /// <remarks />
        public const uint CommunicationsConditionType = 1049;

        /// <remarks />
        public const uint ConcentrationConditionType = 1116;

        /// <remarks />
        public const uint ConductivityConditionType = 1183;

        /// <remarks />
        public const uint Data_RangeConditionType = 1250;

        /// <remarks />
        public const uint DirectionConditionType = 1317;

        /// <remarks />
        public const uint DisplacementConditionType = 1384;

        /// <remarks />
        public const uint Electrical_EnergyConditionType = 1451;

        /// <remarks />
        public const uint Fill_LevelConditionType = 1518;

        /// <remarks />
        public const uint FlowConditionType = 1585;

        /// <remarks />
        public const uint FrequencyConditionType = 1652;

        /// <remarks />
        public const uint HardwareConditionType = 1719;

        /// <remarks />
        public const uint Linear_ForceConditionType = 1786;

        /// <remarks />
        public const uint LoadConditionType = 1853;

        /// <remarks />
        public const uint Logic_ProgramConditionType = 1920;

        /// <remarks />
        public const uint MassConditionType = 1987;

        /// <remarks />
        public const uint Motion_ProgramConditionType = 2054;

        /// <remarks />
        public const uint Path_FeedrateConditionType = 2121;

        /// <remarks />
        public const uint Path_PositionConditionType = 2188;

        /// <remarks />
        public const uint PHConditionType = 2255;

        /// <remarks />
        public const uint PositionConditionType = 2322;

        /// <remarks />
        public const uint Power_FactorConditionType = 2389;

        /// <remarks />
        public const uint PressureConditionType = 2456;

        /// <remarks />
        public const uint ResistanceConditionType = 2523;

        /// <remarks />
        public const uint Rotary_VelocityConditionType = 2590;

        /// <remarks />
        public const uint Sound_LevelConditionType = 2657;

        /// <remarks />
        public const uint StrainConditionType = 2724;

        /// <remarks />
        public const uint SystemConditionType = 2791;

        /// <remarks />
        public const uint TemperatureConditionType = 2858;

        /// <remarks />
        public const uint TiltConditionType = 2925;

        /// <remarks />
        public const uint TorqueConditionType = 2992;

        /// <remarks />
        public const uint VelocityConditionType = 3059;

        /// <remarks />
        public const uint ViscosityConditionType = 3126;

        /// <remarks />
        public const uint VoltageConditionType = 3193;

        /// <remarks />
        public const uint Volt_AmperageConditionType = 3260;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType = 3327;

        /// <remarks />
        public const uint WattageConditionType = 3394;

        /// <remarks />
        public const uint ConfigurationType = 3465;

        /// <remarks />
        public const uint SensorConfigurationType = 3478;

        /// <remarks />
        public const uint SensorType = 3492;

        /// <remarks />
        public const uint SourceType = 3505;

        /// <remarks />
        public const uint AssetType = 3519;

        /// <remarks />
        public const uint CuttingToolType = 3538;

        /// <remarks />
        public const uint CuttingToolLifeCycleType = 3541;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint MTDevicesType_MTConnectVersion = 2;

        /// <remarks />
        public const uint MTDevicesType_OPCUAMappingDate = 3;

        /// <remarks />
        public const uint MTDevicesType_OPCUAVersion = 4;

        /// <remarks />
        public const uint MTDeviceType_Availability = 10;

        /// <remarks />
        public const uint MTDeviceType_Manufacturer = 13;

        /// <remarks />
        public const uint MTDeviceType_SerialNumber = 14;

        /// <remarks />
        public const uint MTDeviceType_Configuration = 15;

        /// <remarks />
        public const uint MTDeviceType_SampleInterval = 16;

        /// <remarks />
        public const uint MTComponentType_Model = 31;

        /// <remarks />
        public const uint MTComponentType_Station = 32;

        /// <remarks />
        public const uint MTAxesType_LinearAxesX = 44;

        /// <remarks />
        public const uint MTAxesType_LinearAxesY = 45;

        /// <remarks />
        public const uint MTAxesType_LinearAxesZ = 46;

        /// <remarks />
        public const uint MTAxesType_RotoryAxesA = 47;

        /// <remarks />
        public const uint MTAxesType_RotoryAxesB = 48;

        /// <remarks />
        public const uint MTAxesType_RotoryAxesC = 49;

        /// <remarks />
        public const uint MTDoorType_DoorState = 72;

        /// <remarks />
        public const uint MTActuatorType_LinearAxesX = 84;

        /// <remarks />
        public const uint MTSampleDataItemType_CoordinateSystem = 91;

        /// <remarks />
        public const uint MTSampleDataItemType_NativeUnits = 92;

        /// <remarks />
        public const uint MTSampleDataItemType_NativeScale = 93;

        /// <remarks />
        public const uint MTSampleDataItemType_SampleInterval = 94;

        /// <remarks />
        public const uint MTEventDataItemType_CoordinateSystem = 458;

        /// <remarks />
        public const uint MTEventDataItemType_SampleInterval = 459;

        /// <remarks />
        public const uint MTConditionType_EnabledState_Id = 598;

        /// <remarks />
        public const uint MTConditionType_Quality_SourceTimestamp = 607;

        /// <remarks />
        public const uint MTConditionType_LastSeverity_SourceTimestamp = 609;

        /// <remarks />
        public const uint MTConditionType_Comment_SourceTimestamp = 611;

        /// <remarks />
        public const uint MTConditionType_AddComment_InputArguments = 616;

        /// <remarks />
        public const uint MTConditionType_ConditionRefresh_InputArguments = 618;

        /// <remarks />
        public const uint MTConditionType_ConditionRefresh2_InputArguments = 620;

        /// <remarks />
        public const uint MTConditionType_MTCurrentState = 621;

        /// <remarks />
        public const uint MTConditionType_ActiveState = 622;

        /// <remarks />
        public const uint MTConditionType_ActiveState_Id = 623;

        /// <remarks />
        public const uint MTConditionType_LimitState_CurrentState = 632;

        /// <remarks />
        public const uint MTConditionType_LimitState_CurrentState_Id = 633;

        /// <remarks />
        public const uint MTConditionType_LimitState_LastTransition_Id = 638;

        /// <remarks />
        public const uint MTConditionType_NativeCode = 645;

        /// <remarks />
        public const uint MTConditionType_NativeSeverity = 646;

        /// <remarks />
        public const uint AccelerationConditionType_EnabledState_Id = 665;

        /// <remarks />
        public const uint AccelerationConditionType_Quality_SourceTimestamp = 674;

        /// <remarks />
        public const uint AccelerationConditionType_LastSeverity_SourceTimestamp = 676;

        /// <remarks />
        public const uint AccelerationConditionType_Comment_SourceTimestamp = 678;

        /// <remarks />
        public const uint AccelerationConditionType_AddComment_InputArguments = 683;

        /// <remarks />
        public const uint AccelerationConditionType_ConditionRefresh_InputArguments = 685;

        /// <remarks />
        public const uint AccelerationConditionType_ConditionRefresh2_InputArguments = 687;

        /// <remarks />
        public const uint AccelerationConditionType_ActiveState_Id = 690;

        /// <remarks />
        public const uint AccelerationConditionType_LimitState_CurrentState = 699;

        /// <remarks />
        public const uint AccelerationConditionType_LimitState_CurrentState_Id = 700;

        /// <remarks />
        public const uint AccelerationConditionType_LimitState_LastTransition_Id = 705;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_EnabledState_Id = 732;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_Quality_SourceTimestamp = 741;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_LastSeverity_SourceTimestamp = 743;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_Comment_SourceTimestamp = 745;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_AddComment_InputArguments = 750;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_ConditionRefresh_InputArguments = 752;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_ConditionRefresh2_InputArguments = 754;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_ActiveState_Id = 757;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_LimitState_CurrentState = 766;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_LimitState_CurrentState_Id = 767;

        /// <remarks />
        public const uint Accumulated_TimeConditionType_LimitState_LastTransition_Id = 772;

        /// <remarks />
        public const uint AmperageConditionType_EnabledState_Id = 799;

        /// <remarks />
        public const uint AmperageConditionType_Quality_SourceTimestamp = 808;

        /// <remarks />
        public const uint AmperageConditionType_LastSeverity_SourceTimestamp = 810;

        /// <remarks />
        public const uint AmperageConditionType_Comment_SourceTimestamp = 812;

        /// <remarks />
        public const uint AmperageConditionType_AddComment_InputArguments = 817;

        /// <remarks />
        public const uint AmperageConditionType_ConditionRefresh_InputArguments = 819;

        /// <remarks />
        public const uint AmperageConditionType_ConditionRefresh2_InputArguments = 821;

        /// <remarks />
        public const uint AmperageConditionType_ActiveState_Id = 824;

        /// <remarks />
        public const uint AmperageConditionType_LimitState_CurrentState = 833;

        /// <remarks />
        public const uint AmperageConditionType_LimitState_CurrentState_Id = 834;

        /// <remarks />
        public const uint AmperageConditionType_LimitState_LastTransition_Id = 839;

        /// <remarks />
        public const uint AngleConditionType_EnabledState_Id = 866;

        /// <remarks />
        public const uint AngleConditionType_Quality_SourceTimestamp = 875;

        /// <remarks />
        public const uint AngleConditionType_LastSeverity_SourceTimestamp = 877;

        /// <remarks />
        public const uint AngleConditionType_Comment_SourceTimestamp = 879;

        /// <remarks />
        public const uint AngleConditionType_AddComment_InputArguments = 884;

        /// <remarks />
        public const uint AngleConditionType_ConditionRefresh_InputArguments = 886;

        /// <remarks />
        public const uint AngleConditionType_ConditionRefresh2_InputArguments = 888;

        /// <remarks />
        public const uint AngleConditionType_ActiveState_Id = 891;

        /// <remarks />
        public const uint AngleConditionType_LimitState_CurrentState = 900;

        /// <remarks />
        public const uint AngleConditionType_LimitState_CurrentState_Id = 901;

        /// <remarks />
        public const uint AngleConditionType_LimitState_LastTransition_Id = 906;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_EnabledState_Id = 933;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_Quality_SourceTimestamp = 942;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_LastSeverity_SourceTimestamp = 944;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_Comment_SourceTimestamp = 946;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_AddComment_InputArguments = 951;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_ConditionRefresh_InputArguments = 953;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_ConditionRefresh2_InputArguments = 955;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_ActiveState_Id = 958;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_LimitState_CurrentState = 967;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_LimitState_CurrentState_Id = 968;

        /// <remarks />
        public const uint Angular-AccelerationConditionType_LimitState_LastTransition_Id = 973;

        /// <remarks />
        public const uint Angular_VelocityConditionType_EnabledState_Id = 1000;

        /// <remarks />
        public const uint Angular_VelocityConditionType_Quality_SourceTimestamp = 1009;

        /// <remarks />
        public const uint Angular_VelocityConditionType_LastSeverity_SourceTimestamp = 1011;

        /// <remarks />
        public const uint Angular_VelocityConditionType_Comment_SourceTimestamp = 1013;

        /// <remarks />
        public const uint Angular_VelocityConditionType_AddComment_InputArguments = 1018;

        /// <remarks />
        public const uint Angular_VelocityConditionType_ConditionRefresh_InputArguments = 1020;

        /// <remarks />
        public const uint Angular_VelocityConditionType_ConditionRefresh2_InputArguments = 1022;

        /// <remarks />
        public const uint Angular_VelocityConditionType_ActiveState_Id = 1025;

        /// <remarks />
        public const uint Angular_VelocityConditionType_LimitState_CurrentState = 1034;

        /// <remarks />
        public const uint Angular_VelocityConditionType_LimitState_CurrentState_Id = 1035;

        /// <remarks />
        public const uint Angular_VelocityConditionType_LimitState_LastTransition_Id = 1040;

        /// <remarks />
        public const uint CommunicationsConditionType_EnabledState_Id = 1067;

        /// <remarks />
        public const uint CommunicationsConditionType_Quality_SourceTimestamp = 1076;

        /// <remarks />
        public const uint CommunicationsConditionType_LastSeverity_SourceTimestamp = 1078;

        /// <remarks />
        public const uint CommunicationsConditionType_Comment_SourceTimestamp = 1080;

        /// <remarks />
        public const uint CommunicationsConditionType_AddComment_InputArguments = 1085;

        /// <remarks />
        public const uint CommunicationsConditionType_ConditionRefresh_InputArguments = 1087;

        /// <remarks />
        public const uint CommunicationsConditionType_ConditionRefresh2_InputArguments = 1089;

        /// <remarks />
        public const uint CommunicationsConditionType_ActiveState_Id = 1092;

        /// <remarks />
        public const uint CommunicationsConditionType_LimitState_CurrentState = 1101;

        /// <remarks />
        public const uint CommunicationsConditionType_LimitState_CurrentState_Id = 1102;

        /// <remarks />
        public const uint CommunicationsConditionType_LimitState_LastTransition_Id = 1107;

        /// <remarks />
        public const uint ConcentrationConditionType_EnabledState_Id = 1134;

        /// <remarks />
        public const uint ConcentrationConditionType_Quality_SourceTimestamp = 1143;

        /// <remarks />
        public const uint ConcentrationConditionType_LastSeverity_SourceTimestamp = 1145;

        /// <remarks />
        public const uint ConcentrationConditionType_Comment_SourceTimestamp = 1147;

        /// <remarks />
        public const uint ConcentrationConditionType_AddComment_InputArguments = 1152;

        /// <remarks />
        public const uint ConcentrationConditionType_ConditionRefresh_InputArguments = 1154;

        /// <remarks />
        public const uint ConcentrationConditionType_ConditionRefresh2_InputArguments = 1156;

        /// <remarks />
        public const uint ConcentrationConditionType_ActiveState_Id = 1159;

        /// <remarks />
        public const uint ConcentrationConditionType_LimitState_CurrentState = 1168;

        /// <remarks />
        public const uint ConcentrationConditionType_LimitState_CurrentState_Id = 1169;

        /// <remarks />
        public const uint ConcentrationConditionType_LimitState_LastTransition_Id = 1174;

        /// <remarks />
        public const uint ConductivityConditionType_EnabledState_Id = 1201;

        /// <remarks />
        public const uint ConductivityConditionType_Quality_SourceTimestamp = 1210;

        /// <remarks />
        public const uint ConductivityConditionType_LastSeverity_SourceTimestamp = 1212;

        /// <remarks />
        public const uint ConductivityConditionType_Comment_SourceTimestamp = 1214;

        /// <remarks />
        public const uint ConductivityConditionType_AddComment_InputArguments = 1219;

        /// <remarks />
        public const uint ConductivityConditionType_ConditionRefresh_InputArguments = 1221;

        /// <remarks />
        public const uint ConductivityConditionType_ConditionRefresh2_InputArguments = 1223;

        /// <remarks />
        public const uint ConductivityConditionType_ActiveState_Id = 1226;

        /// <remarks />
        public const uint ConductivityConditionType_LimitState_CurrentState = 1235;

        /// <remarks />
        public const uint ConductivityConditionType_LimitState_CurrentState_Id = 1236;

        /// <remarks />
        public const uint ConductivityConditionType_LimitState_LastTransition_Id = 1241;

        /// <remarks />
        public const uint Data_RangeConditionType_EnabledState_Id = 1268;

        /// <remarks />
        public const uint Data_RangeConditionType_Quality_SourceTimestamp = 1277;

        /// <remarks />
        public const uint Data_RangeConditionType_LastSeverity_SourceTimestamp = 1279;

        /// <remarks />
        public const uint Data_RangeConditionType_Comment_SourceTimestamp = 1281;

        /// <remarks />
        public const uint Data_RangeConditionType_AddComment_InputArguments = 1286;

        /// <remarks />
        public const uint Data_RangeConditionType_ConditionRefresh_InputArguments = 1288;

        /// <remarks />
        public const uint Data_RangeConditionType_ConditionRefresh2_InputArguments = 1290;

        /// <remarks />
        public const uint Data_RangeConditionType_ActiveState_Id = 1293;

        /// <remarks />
        public const uint Data_RangeConditionType_LimitState_CurrentState = 1302;

        /// <remarks />
        public const uint Data_RangeConditionType_LimitState_CurrentState_Id = 1303;

        /// <remarks />
        public const uint Data_RangeConditionType_LimitState_LastTransition_Id = 1308;

        /// <remarks />
        public const uint DirectionConditionType_EnabledState_Id = 1335;

        /// <remarks />
        public const uint DirectionConditionType_Quality_SourceTimestamp = 1344;

        /// <remarks />
        public const uint DirectionConditionType_LastSeverity_SourceTimestamp = 1346;

        /// <remarks />
        public const uint DirectionConditionType_Comment_SourceTimestamp = 1348;

        /// <remarks />
        public const uint DirectionConditionType_AddComment_InputArguments = 1353;

        /// <remarks />
        public const uint DirectionConditionType_ConditionRefresh_InputArguments = 1355;

        /// <remarks />
        public const uint DirectionConditionType_ConditionRefresh2_InputArguments = 1357;

        /// <remarks />
        public const uint DirectionConditionType_ActiveState_Id = 1360;

        /// <remarks />
        public const uint DirectionConditionType_LimitState_CurrentState = 1369;

        /// <remarks />
        public const uint DirectionConditionType_LimitState_CurrentState_Id = 1370;

        /// <remarks />
        public const uint DirectionConditionType_LimitState_LastTransition_Id = 1375;

        /// <remarks />
        public const uint DisplacementConditionType_EnabledState_Id = 1402;

        /// <remarks />
        public const uint DisplacementConditionType_Quality_SourceTimestamp = 1411;

        /// <remarks />
        public const uint DisplacementConditionType_LastSeverity_SourceTimestamp = 1413;

        /// <remarks />
        public const uint DisplacementConditionType_Comment_SourceTimestamp = 1415;

        /// <remarks />
        public const uint DisplacementConditionType_AddComment_InputArguments = 1420;

        /// <remarks />
        public const uint DisplacementConditionType_ConditionRefresh_InputArguments = 1422;

        /// <remarks />
        public const uint DisplacementConditionType_ConditionRefresh2_InputArguments = 1424;

        /// <remarks />
        public const uint DisplacementConditionType_ActiveState_Id = 1427;

        /// <remarks />
        public const uint DisplacementConditionType_LimitState_CurrentState = 1436;

        /// <remarks />
        public const uint DisplacementConditionType_LimitState_CurrentState_Id = 1437;

        /// <remarks />
        public const uint DisplacementConditionType_LimitState_LastTransition_Id = 1442;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_EnabledState_Id = 1469;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_Quality_SourceTimestamp = 1478;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_LastSeverity_SourceTimestamp = 1480;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_Comment_SourceTimestamp = 1482;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_AddComment_InputArguments = 1487;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_ConditionRefresh_InputArguments = 1489;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_ConditionRefresh2_InputArguments = 1491;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_ActiveState_Id = 1494;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_LimitState_CurrentState = 1503;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_LimitState_CurrentState_Id = 1504;

        /// <remarks />
        public const uint Electrical_EnergyConditionType_LimitState_LastTransition_Id = 1509;

        /// <remarks />
        public const uint Fill_LevelConditionType_EnabledState_Id = 1536;

        /// <remarks />
        public const uint Fill_LevelConditionType_Quality_SourceTimestamp = 1545;

        /// <remarks />
        public const uint Fill_LevelConditionType_LastSeverity_SourceTimestamp = 1547;

        /// <remarks />
        public const uint Fill_LevelConditionType_Comment_SourceTimestamp = 1549;

        /// <remarks />
        public const uint Fill_LevelConditionType_AddComment_InputArguments = 1554;

        /// <remarks />
        public const uint Fill_LevelConditionType_ConditionRefresh_InputArguments = 1556;

        /// <remarks />
        public const uint Fill_LevelConditionType_ConditionRefresh2_InputArguments = 1558;

        /// <remarks />
        public const uint Fill_LevelConditionType_ActiveState_Id = 1561;

        /// <remarks />
        public const uint Fill_LevelConditionType_LimitState_CurrentState = 1570;

        /// <remarks />
        public const uint Fill_LevelConditionType_LimitState_CurrentState_Id = 1571;

        /// <remarks />
        public const uint Fill_LevelConditionType_LimitState_LastTransition_Id = 1576;

        /// <remarks />
        public const uint FlowConditionType_EnabledState_Id = 1603;

        /// <remarks />
        public const uint FlowConditionType_Quality_SourceTimestamp = 1612;

        /// <remarks />
        public const uint FlowConditionType_LastSeverity_SourceTimestamp = 1614;

        /// <remarks />
        public const uint FlowConditionType_Comment_SourceTimestamp = 1616;

        /// <remarks />
        public const uint FlowConditionType_AddComment_InputArguments = 1621;

        /// <remarks />
        public const uint FlowConditionType_ConditionRefresh_InputArguments = 1623;

        /// <remarks />
        public const uint FlowConditionType_ConditionRefresh2_InputArguments = 1625;

        /// <remarks />
        public const uint FlowConditionType_ActiveState_Id = 1628;

        /// <remarks />
        public const uint FlowConditionType_LimitState_CurrentState = 1637;

        /// <remarks />
        public const uint FlowConditionType_LimitState_CurrentState_Id = 1638;

        /// <remarks />
        public const uint FlowConditionType_LimitState_LastTransition_Id = 1643;

        /// <remarks />
        public const uint FrequencyConditionType_EnabledState_Id = 1670;

        /// <remarks />
        public const uint FrequencyConditionType_Quality_SourceTimestamp = 1679;

        /// <remarks />
        public const uint FrequencyConditionType_LastSeverity_SourceTimestamp = 1681;

        /// <remarks />
        public const uint FrequencyConditionType_Comment_SourceTimestamp = 1683;

        /// <remarks />
        public const uint FrequencyConditionType_AddComment_InputArguments = 1688;

        /// <remarks />
        public const uint FrequencyConditionType_ConditionRefresh_InputArguments = 1690;

        /// <remarks />
        public const uint FrequencyConditionType_ConditionRefresh2_InputArguments = 1692;

        /// <remarks />
        public const uint FrequencyConditionType_ActiveState_Id = 1695;

        /// <remarks />
        public const uint FrequencyConditionType_LimitState_CurrentState = 1704;

        /// <remarks />
        public const uint FrequencyConditionType_LimitState_CurrentState_Id = 1705;

        /// <remarks />
        public const uint FrequencyConditionType_LimitState_LastTransition_Id = 1710;

        /// <remarks />
        public const uint HardwareConditionType_EnabledState_Id = 1737;

        /// <remarks />
        public const uint HardwareConditionType_Quality_SourceTimestamp = 1746;

        /// <remarks />
        public const uint HardwareConditionType_LastSeverity_SourceTimestamp = 1748;

        /// <remarks />
        public const uint HardwareConditionType_Comment_SourceTimestamp = 1750;

        /// <remarks />
        public const uint HardwareConditionType_AddComment_InputArguments = 1755;

        /// <remarks />
        public const uint HardwareConditionType_ConditionRefresh_InputArguments = 1757;

        /// <remarks />
        public const uint HardwareConditionType_ConditionRefresh2_InputArguments = 1759;

        /// <remarks />
        public const uint HardwareConditionType_ActiveState_Id = 1762;

        /// <remarks />
        public const uint HardwareConditionType_LimitState_CurrentState = 1771;

        /// <remarks />
        public const uint HardwareConditionType_LimitState_CurrentState_Id = 1772;

        /// <remarks />
        public const uint HardwareConditionType_LimitState_LastTransition_Id = 1777;

        /// <remarks />
        public const uint Linear_ForceConditionType_EnabledState_Id = 1804;

        /// <remarks />
        public const uint Linear_ForceConditionType_Quality_SourceTimestamp = 1813;

        /// <remarks />
        public const uint Linear_ForceConditionType_LastSeverity_SourceTimestamp = 1815;

        /// <remarks />
        public const uint Linear_ForceConditionType_Comment_SourceTimestamp = 1817;

        /// <remarks />
        public const uint Linear_ForceConditionType_AddComment_InputArguments = 1822;

        /// <remarks />
        public const uint Linear_ForceConditionType_ConditionRefresh_InputArguments = 1824;

        /// <remarks />
        public const uint Linear_ForceConditionType_ConditionRefresh2_InputArguments = 1826;

        /// <remarks />
        public const uint Linear_ForceConditionType_ActiveState_Id = 1829;

        /// <remarks />
        public const uint Linear_ForceConditionType_LimitState_CurrentState = 1838;

        /// <remarks />
        public const uint Linear_ForceConditionType_LimitState_CurrentState_Id = 1839;

        /// <remarks />
        public const uint Linear_ForceConditionType_LimitState_LastTransition_Id = 1844;

        /// <remarks />
        public const uint LoadConditionType_EnabledState_Id = 1871;

        /// <remarks />
        public const uint LoadConditionType_Quality_SourceTimestamp = 1880;

        /// <remarks />
        public const uint LoadConditionType_LastSeverity_SourceTimestamp = 1882;

        /// <remarks />
        public const uint LoadConditionType_Comment_SourceTimestamp = 1884;

        /// <remarks />
        public const uint LoadConditionType_AddComment_InputArguments = 1889;

        /// <remarks />
        public const uint LoadConditionType_ConditionRefresh_InputArguments = 1891;

        /// <remarks />
        public const uint LoadConditionType_ConditionRefresh2_InputArguments = 1893;

        /// <remarks />
        public const uint LoadConditionType_ActiveState_Id = 1896;

        /// <remarks />
        public const uint LoadConditionType_LimitState_CurrentState = 1905;

        /// <remarks />
        public const uint LoadConditionType_LimitState_CurrentState_Id = 1906;

        /// <remarks />
        public const uint LoadConditionType_LimitState_LastTransition_Id = 1911;

        /// <remarks />
        public const uint Logic_ProgramConditionType_EnabledState_Id = 1938;

        /// <remarks />
        public const uint Logic_ProgramConditionType_Quality_SourceTimestamp = 1947;

        /// <remarks />
        public const uint Logic_ProgramConditionType_LastSeverity_SourceTimestamp = 1949;

        /// <remarks />
        public const uint Logic_ProgramConditionType_Comment_SourceTimestamp = 1951;

        /// <remarks />
        public const uint Logic_ProgramConditionType_AddComment_InputArguments = 1956;

        /// <remarks />
        public const uint Logic_ProgramConditionType_ConditionRefresh_InputArguments = 1958;

        /// <remarks />
        public const uint Logic_ProgramConditionType_ConditionRefresh2_InputArguments = 1960;

        /// <remarks />
        public const uint Logic_ProgramConditionType_ActiveState_Id = 1963;

        /// <remarks />
        public const uint Logic_ProgramConditionType_LimitState_CurrentState = 1972;

        /// <remarks />
        public const uint Logic_ProgramConditionType_LimitState_CurrentState_Id = 1973;

        /// <remarks />
        public const uint Logic_ProgramConditionType_LimitState_LastTransition_Id = 1978;

        /// <remarks />
        public const uint MassConditionType_EnabledState_Id = 2005;

        /// <remarks />
        public const uint MassConditionType_Quality_SourceTimestamp = 2014;

        /// <remarks />
        public const uint MassConditionType_LastSeverity_SourceTimestamp = 2016;

        /// <remarks />
        public const uint MassConditionType_Comment_SourceTimestamp = 2018;

        /// <remarks />
        public const uint MassConditionType_AddComment_InputArguments = 2023;

        /// <remarks />
        public const uint MassConditionType_ConditionRefresh_InputArguments = 2025;

        /// <remarks />
        public const uint MassConditionType_ConditionRefresh2_InputArguments = 2027;

        /// <remarks />
        public const uint MassConditionType_ActiveState_Id = 2030;

        /// <remarks />
        public const uint MassConditionType_LimitState_CurrentState = 2039;

        /// <remarks />
        public const uint MassConditionType_LimitState_CurrentState_Id = 2040;

        /// <remarks />
        public const uint MassConditionType_LimitState_LastTransition_Id = 2045;

        /// <remarks />
        public const uint Motion_ProgramConditionType_EnabledState_Id = 2072;

        /// <remarks />
        public const uint Motion_ProgramConditionType_Quality_SourceTimestamp = 2081;

        /// <remarks />
        public const uint Motion_ProgramConditionType_LastSeverity_SourceTimestamp = 2083;

        /// <remarks />
        public const uint Motion_ProgramConditionType_Comment_SourceTimestamp = 2085;

        /// <remarks />
        public const uint Motion_ProgramConditionType_AddComment_InputArguments = 2090;

        /// <remarks />
        public const uint Motion_ProgramConditionType_ConditionRefresh_InputArguments = 2092;

        /// <remarks />
        public const uint Motion_ProgramConditionType_ConditionRefresh2_InputArguments = 2094;

        /// <remarks />
        public const uint Motion_ProgramConditionType_ActiveState_Id = 2097;

        /// <remarks />
        public const uint Motion_ProgramConditionType_LimitState_CurrentState = 2106;

        /// <remarks />
        public const uint Motion_ProgramConditionType_LimitState_CurrentState_Id = 2107;

        /// <remarks />
        public const uint Motion_ProgramConditionType_LimitState_LastTransition_Id = 2112;

        /// <remarks />
        public const uint Path_FeedrateConditionType_EnabledState_Id = 2139;

        /// <remarks />
        public const uint Path_FeedrateConditionType_Quality_SourceTimestamp = 2148;

        /// <remarks />
        public const uint Path_FeedrateConditionType_LastSeverity_SourceTimestamp = 2150;

        /// <remarks />
        public const uint Path_FeedrateConditionType_Comment_SourceTimestamp = 2152;

        /// <remarks />
        public const uint Path_FeedrateConditionType_AddComment_InputArguments = 2157;

        /// <remarks />
        public const uint Path_FeedrateConditionType_ConditionRefresh_InputArguments = 2159;

        /// <remarks />
        public const uint Path_FeedrateConditionType_ConditionRefresh2_InputArguments = 2161;

        /// <remarks />
        public const uint Path_FeedrateConditionType_ActiveState_Id = 2164;

        /// <remarks />
        public const uint Path_FeedrateConditionType_LimitState_CurrentState = 2173;

        /// <remarks />
        public const uint Path_FeedrateConditionType_LimitState_CurrentState_Id = 2174;

        /// <remarks />
        public const uint Path_FeedrateConditionType_LimitState_LastTransition_Id = 2179;

        /// <remarks />
        public const uint Path_PositionConditionType_EnabledState_Id = 2206;

        /// <remarks />
        public const uint Path_PositionConditionType_Quality_SourceTimestamp = 2215;

        /// <remarks />
        public const uint Path_PositionConditionType_LastSeverity_SourceTimestamp = 2217;

        /// <remarks />
        public const uint Path_PositionConditionType_Comment_SourceTimestamp = 2219;

        /// <remarks />
        public const uint Path_PositionConditionType_AddComment_InputArguments = 2224;

        /// <remarks />
        public const uint Path_PositionConditionType_ConditionRefresh_InputArguments = 2226;

        /// <remarks />
        public const uint Path_PositionConditionType_ConditionRefresh2_InputArguments = 2228;

        /// <remarks />
        public const uint Path_PositionConditionType_ActiveState_Id = 2231;

        /// <remarks />
        public const uint Path_PositionConditionType_LimitState_CurrentState = 2240;

        /// <remarks />
        public const uint Path_PositionConditionType_LimitState_CurrentState_Id = 2241;

        /// <remarks />
        public const uint Path_PositionConditionType_LimitState_LastTransition_Id = 2246;

        /// <remarks />
        public const uint PHConditionType_EnabledState_Id = 2273;

        /// <remarks />
        public const uint PHConditionType_Quality_SourceTimestamp = 2282;

        /// <remarks />
        public const uint PHConditionType_LastSeverity_SourceTimestamp = 2284;

        /// <remarks />
        public const uint PHConditionType_Comment_SourceTimestamp = 2286;

        /// <remarks />
        public const uint PHConditionType_AddComment_InputArguments = 2291;

        /// <remarks />
        public const uint PHConditionType_ConditionRefresh_InputArguments = 2293;

        /// <remarks />
        public const uint PHConditionType_ConditionRefresh2_InputArguments = 2295;

        /// <remarks />
        public const uint PHConditionType_ActiveState_Id = 2298;

        /// <remarks />
        public const uint PHConditionType_LimitState_CurrentState = 2307;

        /// <remarks />
        public const uint PHConditionType_LimitState_CurrentState_Id = 2308;

        /// <remarks />
        public const uint PHConditionType_LimitState_LastTransition_Id = 2313;

        /// <remarks />
        public const uint PositionConditionType_EnabledState_Id = 2340;

        /// <remarks />
        public const uint PositionConditionType_Quality_SourceTimestamp = 2349;

        /// <remarks />
        public const uint PositionConditionType_LastSeverity_SourceTimestamp = 2351;

        /// <remarks />
        public const uint PositionConditionType_Comment_SourceTimestamp = 2353;

        /// <remarks />
        public const uint PositionConditionType_AddComment_InputArguments = 2358;

        /// <remarks />
        public const uint PositionConditionType_ConditionRefresh_InputArguments = 2360;

        /// <remarks />
        public const uint PositionConditionType_ConditionRefresh2_InputArguments = 2362;

        /// <remarks />
        public const uint PositionConditionType_ActiveState_Id = 2365;

        /// <remarks />
        public const uint PositionConditionType_LimitState_CurrentState = 2374;

        /// <remarks />
        public const uint PositionConditionType_LimitState_CurrentState_Id = 2375;

        /// <remarks />
        public const uint PositionConditionType_LimitState_LastTransition_Id = 2380;

        /// <remarks />
        public const uint Power_FactorConditionType_EnabledState_Id = 2407;

        /// <remarks />
        public const uint Power_FactorConditionType_Quality_SourceTimestamp = 2416;

        /// <remarks />
        public const uint Power_FactorConditionType_LastSeverity_SourceTimestamp = 2418;

        /// <remarks />
        public const uint Power_FactorConditionType_Comment_SourceTimestamp = 2420;

        /// <remarks />
        public const uint Power_FactorConditionType_AddComment_InputArguments = 2425;

        /// <remarks />
        public const uint Power_FactorConditionType_ConditionRefresh_InputArguments = 2427;

        /// <remarks />
        public const uint Power_FactorConditionType_ConditionRefresh2_InputArguments = 2429;

        /// <remarks />
        public const uint Power_FactorConditionType_ActiveState_Id = 2432;

        /// <remarks />
        public const uint Power_FactorConditionType_LimitState_CurrentState = 2441;

        /// <remarks />
        public const uint Power_FactorConditionType_LimitState_CurrentState_Id = 2442;

        /// <remarks />
        public const uint Power_FactorConditionType_LimitState_LastTransition_Id = 2447;

        /// <remarks />
        public const uint PressureConditionType_EnabledState_Id = 2474;

        /// <remarks />
        public const uint PressureConditionType_Quality_SourceTimestamp = 2483;

        /// <remarks />
        public const uint PressureConditionType_LastSeverity_SourceTimestamp = 2485;

        /// <remarks />
        public const uint PressureConditionType_Comment_SourceTimestamp = 2487;

        /// <remarks />
        public const uint PressureConditionType_AddComment_InputArguments = 2492;

        /// <remarks />
        public const uint PressureConditionType_ConditionRefresh_InputArguments = 2494;

        /// <remarks />
        public const uint PressureConditionType_ConditionRefresh2_InputArguments = 2496;

        /// <remarks />
        public const uint PressureConditionType_ActiveState_Id = 2499;

        /// <remarks />
        public const uint PressureConditionType_LimitState_CurrentState = 2508;

        /// <remarks />
        public const uint PressureConditionType_LimitState_CurrentState_Id = 2509;

        /// <remarks />
        public const uint PressureConditionType_LimitState_LastTransition_Id = 2514;

        /// <remarks />
        public const uint ResistanceConditionType_EnabledState_Id = 2541;

        /// <remarks />
        public const uint ResistanceConditionType_Quality_SourceTimestamp = 2550;

        /// <remarks />
        public const uint ResistanceConditionType_LastSeverity_SourceTimestamp = 2552;

        /// <remarks />
        public const uint ResistanceConditionType_Comment_SourceTimestamp = 2554;

        /// <remarks />
        public const uint ResistanceConditionType_AddComment_InputArguments = 2559;

        /// <remarks />
        public const uint ResistanceConditionType_ConditionRefresh_InputArguments = 2561;

        /// <remarks />
        public const uint ResistanceConditionType_ConditionRefresh2_InputArguments = 2563;

        /// <remarks />
        public const uint ResistanceConditionType_ActiveState_Id = 2566;

        /// <remarks />
        public const uint ResistanceConditionType_LimitState_CurrentState = 2575;

        /// <remarks />
        public const uint ResistanceConditionType_LimitState_CurrentState_Id = 2576;

        /// <remarks />
        public const uint ResistanceConditionType_LimitState_LastTransition_Id = 2581;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_EnabledState_Id = 2608;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_Quality_SourceTimestamp = 2617;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_LastSeverity_SourceTimestamp = 2619;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_Comment_SourceTimestamp = 2621;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_AddComment_InputArguments = 2626;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_ConditionRefresh_InputArguments = 2628;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_ConditionRefresh2_InputArguments = 2630;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_ActiveState_Id = 2633;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_LimitState_CurrentState = 2642;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_LimitState_CurrentState_Id = 2643;

        /// <remarks />
        public const uint Rotary_VelocityConditionType_LimitState_LastTransition_Id = 2648;

        /// <remarks />
        public const uint Sound_LevelConditionType_EnabledState_Id = 2675;

        /// <remarks />
        public const uint Sound_LevelConditionType_Quality_SourceTimestamp = 2684;

        /// <remarks />
        public const uint Sound_LevelConditionType_LastSeverity_SourceTimestamp = 2686;

        /// <remarks />
        public const uint Sound_LevelConditionType_Comment_SourceTimestamp = 2688;

        /// <remarks />
        public const uint Sound_LevelConditionType_AddComment_InputArguments = 2693;

        /// <remarks />
        public const uint Sound_LevelConditionType_ConditionRefresh_InputArguments = 2695;

        /// <remarks />
        public const uint Sound_LevelConditionType_ConditionRefresh2_InputArguments = 2697;

        /// <remarks />
        public const uint Sound_LevelConditionType_ActiveState_Id = 2700;

        /// <remarks />
        public const uint Sound_LevelConditionType_LimitState_CurrentState = 2709;

        /// <remarks />
        public const uint Sound_LevelConditionType_LimitState_CurrentState_Id = 2710;

        /// <remarks />
        public const uint Sound_LevelConditionType_LimitState_LastTransition_Id = 2715;

        /// <remarks />
        public const uint StrainConditionType_EnabledState_Id = 2742;

        /// <remarks />
        public const uint StrainConditionType_Quality_SourceTimestamp = 2751;

        /// <remarks />
        public const uint StrainConditionType_LastSeverity_SourceTimestamp = 2753;

        /// <remarks />
        public const uint StrainConditionType_Comment_SourceTimestamp = 2755;

        /// <remarks />
        public const uint StrainConditionType_AddComment_InputArguments = 2760;

        /// <remarks />
        public const uint StrainConditionType_ConditionRefresh_InputArguments = 2762;

        /// <remarks />
        public const uint StrainConditionType_ConditionRefresh2_InputArguments = 2764;

        /// <remarks />
        public const uint StrainConditionType_ActiveState_Id = 2767;

        /// <remarks />
        public const uint StrainConditionType_LimitState_CurrentState = 2776;

        /// <remarks />
        public const uint StrainConditionType_LimitState_CurrentState_Id = 2777;

        /// <remarks />
        public const uint StrainConditionType_LimitState_LastTransition_Id = 2782;

        /// <remarks />
        public const uint SystemConditionType_EnabledState_Id = 2809;

        /// <remarks />
        public const uint SystemConditionType_Quality_SourceTimestamp = 2818;

        /// <remarks />
        public const uint SystemConditionType_LastSeverity_SourceTimestamp = 2820;

        /// <remarks />
        public const uint SystemConditionType_Comment_SourceTimestamp = 2822;

        /// <remarks />
        public const uint SystemConditionType_AddComment_InputArguments = 2827;

        /// <remarks />
        public const uint SystemConditionType_ConditionRefresh_InputArguments = 2829;

        /// <remarks />
        public const uint SystemConditionType_ConditionRefresh2_InputArguments = 2831;

        /// <remarks />
        public const uint SystemConditionType_ActiveState_Id = 2834;

        /// <remarks />
        public const uint SystemConditionType_LimitState_CurrentState = 2843;

        /// <remarks />
        public const uint SystemConditionType_LimitState_CurrentState_Id = 2844;

        /// <remarks />
        public const uint SystemConditionType_LimitState_LastTransition_Id = 2849;

        /// <remarks />
        public const uint TemperatureConditionType_EnabledState_Id = 2876;

        /// <remarks />
        public const uint TemperatureConditionType_Quality_SourceTimestamp = 2885;

        /// <remarks />
        public const uint TemperatureConditionType_LastSeverity_SourceTimestamp = 2887;

        /// <remarks />
        public const uint TemperatureConditionType_Comment_SourceTimestamp = 2889;

        /// <remarks />
        public const uint TemperatureConditionType_AddComment_InputArguments = 2894;

        /// <remarks />
        public const uint TemperatureConditionType_ConditionRefresh_InputArguments = 2896;

        /// <remarks />
        public const uint TemperatureConditionType_ConditionRefresh2_InputArguments = 2898;

        /// <remarks />
        public const uint TemperatureConditionType_ActiveState_Id = 2901;

        /// <remarks />
        public const uint TemperatureConditionType_LimitState_CurrentState = 2910;

        /// <remarks />
        public const uint TemperatureConditionType_LimitState_CurrentState_Id = 2911;

        /// <remarks />
        public const uint TemperatureConditionType_LimitState_LastTransition_Id = 2916;

        /// <remarks />
        public const uint TiltConditionType_EnabledState_Id = 2943;

        /// <remarks />
        public const uint TiltConditionType_Quality_SourceTimestamp = 2952;

        /// <remarks />
        public const uint TiltConditionType_LastSeverity_SourceTimestamp = 2954;

        /// <remarks />
        public const uint TiltConditionType_Comment_SourceTimestamp = 2956;

        /// <remarks />
        public const uint TiltConditionType_AddComment_InputArguments = 2961;

        /// <remarks />
        public const uint TiltConditionType_ConditionRefresh_InputArguments = 2963;

        /// <remarks />
        public const uint TiltConditionType_ConditionRefresh2_InputArguments = 2965;

        /// <remarks />
        public const uint TiltConditionType_ActiveState_Id = 2968;

        /// <remarks />
        public const uint TiltConditionType_LimitState_CurrentState = 2977;

        /// <remarks />
        public const uint TiltConditionType_LimitState_CurrentState_Id = 2978;

        /// <remarks />
        public const uint TiltConditionType_LimitState_LastTransition_Id = 2983;

        /// <remarks />
        public const uint TorqueConditionType_EnabledState_Id = 3010;

        /// <remarks />
        public const uint TorqueConditionType_Quality_SourceTimestamp = 3019;

        /// <remarks />
        public const uint TorqueConditionType_LastSeverity_SourceTimestamp = 3021;

        /// <remarks />
        public const uint TorqueConditionType_Comment_SourceTimestamp = 3023;

        /// <remarks />
        public const uint TorqueConditionType_AddComment_InputArguments = 3028;

        /// <remarks />
        public const uint TorqueConditionType_ConditionRefresh_InputArguments = 3030;

        /// <remarks />
        public const uint TorqueConditionType_ConditionRefresh2_InputArguments = 3032;

        /// <remarks />
        public const uint TorqueConditionType_ActiveState_Id = 3035;

        /// <remarks />
        public const uint TorqueConditionType_LimitState_CurrentState = 3044;

        /// <remarks />
        public const uint TorqueConditionType_LimitState_CurrentState_Id = 3045;

        /// <remarks />
        public const uint TorqueConditionType_LimitState_LastTransition_Id = 3050;

        /// <remarks />
        public const uint VelocityConditionType_EnabledState_Id = 3077;

        /// <remarks />
        public const uint VelocityConditionType_Quality_SourceTimestamp = 3086;

        /// <remarks />
        public const uint VelocityConditionType_LastSeverity_SourceTimestamp = 3088;

        /// <remarks />
        public const uint VelocityConditionType_Comment_SourceTimestamp = 3090;

        /// <remarks />
        public const uint VelocityConditionType_AddComment_InputArguments = 3095;

        /// <remarks />
        public const uint VelocityConditionType_ConditionRefresh_InputArguments = 3097;

        /// <remarks />
        public const uint VelocityConditionType_ConditionRefresh2_InputArguments = 3099;

        /// <remarks />
        public const uint VelocityConditionType_ActiveState_Id = 3102;

        /// <remarks />
        public const uint VelocityConditionType_LimitState_CurrentState = 3111;

        /// <remarks />
        public const uint VelocityConditionType_LimitState_CurrentState_Id = 3112;

        /// <remarks />
        public const uint VelocityConditionType_LimitState_LastTransition_Id = 3117;

        /// <remarks />
        public const uint ViscosityConditionType_EnabledState_Id = 3144;

        /// <remarks />
        public const uint ViscosityConditionType_Quality_SourceTimestamp = 3153;

        /// <remarks />
        public const uint ViscosityConditionType_LastSeverity_SourceTimestamp = 3155;

        /// <remarks />
        public const uint ViscosityConditionType_Comment_SourceTimestamp = 3157;

        /// <remarks />
        public const uint ViscosityConditionType_AddComment_InputArguments = 3162;

        /// <remarks />
        public const uint ViscosityConditionType_ConditionRefresh_InputArguments = 3164;

        /// <remarks />
        public const uint ViscosityConditionType_ConditionRefresh2_InputArguments = 3166;

        /// <remarks />
        public const uint ViscosityConditionType_ActiveState_Id = 3169;

        /// <remarks />
        public const uint ViscosityConditionType_LimitState_CurrentState = 3178;

        /// <remarks />
        public const uint ViscosityConditionType_LimitState_CurrentState_Id = 3179;

        /// <remarks />
        public const uint ViscosityConditionType_LimitState_LastTransition_Id = 3184;

        /// <remarks />
        public const uint VoltageConditionType_EnabledState_Id = 3211;

        /// <remarks />
        public const uint VoltageConditionType_Quality_SourceTimestamp = 3220;

        /// <remarks />
        public const uint VoltageConditionType_LastSeverity_SourceTimestamp = 3222;

        /// <remarks />
        public const uint VoltageConditionType_Comment_SourceTimestamp = 3224;

        /// <remarks />
        public const uint VoltageConditionType_AddComment_InputArguments = 3229;

        /// <remarks />
        public const uint VoltageConditionType_ConditionRefresh_InputArguments = 3231;

        /// <remarks />
        public const uint VoltageConditionType_ConditionRefresh2_InputArguments = 3233;

        /// <remarks />
        public const uint VoltageConditionType_ActiveState_Id = 3236;

        /// <remarks />
        public const uint VoltageConditionType_LimitState_CurrentState = 3245;

        /// <remarks />
        public const uint VoltageConditionType_LimitState_CurrentState_Id = 3246;

        /// <remarks />
        public const uint VoltageConditionType_LimitState_LastTransition_Id = 3251;

        /// <remarks />
        public const uint Volt_AmperageConditionType_EnabledState_Id = 3278;

        /// <remarks />
        public const uint Volt_AmperageConditionType_Quality_SourceTimestamp = 3287;

        /// <remarks />
        public const uint Volt_AmperageConditionType_LastSeverity_SourceTimestamp = 3289;

        /// <remarks />
        public const uint Volt_AmperageConditionType_Comment_SourceTimestamp = 3291;

        /// <remarks />
        public const uint Volt_AmperageConditionType_AddComment_InputArguments = 3296;

        /// <remarks />
        public const uint Volt_AmperageConditionType_ConditionRefresh_InputArguments = 3298;

        /// <remarks />
        public const uint Volt_AmperageConditionType_ConditionRefresh2_InputArguments = 3300;

        /// <remarks />
        public const uint Volt_AmperageConditionType_ActiveState_Id = 3303;

        /// <remarks />
        public const uint Volt_AmperageConditionType_LimitState_CurrentState = 3312;

        /// <remarks />
        public const uint Volt_AmperageConditionType_LimitState_CurrentState_Id = 3313;

        /// <remarks />
        public const uint Volt_AmperageConditionType_LimitState_LastTransition_Id = 3318;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_EnabledState_Id = 3345;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_Quality_SourceTimestamp = 3354;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_LastSeverity_SourceTimestamp = 3356;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_Comment_SourceTimestamp = 3358;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_AddComment_InputArguments = 3363;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_ConditionRefresh_InputArguments = 3365;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_ConditionRefresh2_InputArguments = 3367;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_ActiveState_Id = 3370;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_LimitState_CurrentState = 3379;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_LimitState_CurrentState_Id = 3380;

        /// <remarks />
        public const uint VoltAmperageReactiveConditionType_LimitState_LastTransition_Id = 3385;

        /// <remarks />
        public const uint WattageConditionType_EnabledState_Id = 3412;

        /// <remarks />
        public const uint WattageConditionType_Quality_SourceTimestamp = 3421;

        /// <remarks />
        public const uint WattageConditionType_LastSeverity_SourceTimestamp = 3423;

        /// <remarks />
        public const uint WattageConditionType_Comment_SourceTimestamp = 3425;

        /// <remarks />
        public const uint WattageConditionType_AddComment_InputArguments = 3430;

        /// <remarks />
        public const uint WattageConditionType_ConditionRefresh_InputArguments = 3432;

        /// <remarks />
        public const uint WattageConditionType_ConditionRefresh2_InputArguments = 3434;

        /// <remarks />
        public const uint WattageConditionType_ActiveState_Id = 3437;

        /// <remarks />
        public const uint WattageConditionType_LimitState_CurrentState = 3446;

        /// <remarks />
        public const uint WattageConditionType_LimitState_CurrentState_Id = 3447;

        /// <remarks />
        public const uint WattageConditionType_LimitState_LastTransition_Id = 3452;

        /// <remarks />
        public const uint ChannelType_CalibrationDate = 3462;

        /// <remarks />
        public const uint ChannelType_NextCalibrationDate = 3463;

        /// <remarks />
        public const uint ChannelType_CalibrationInitials = 3464;

        /// <remarks />
        public const uint SensorConfigurationType_FirmwareVersion = 3491;

        /// <remarks />
        public const uint SourceType_ComponentId = 3518;

        /// <remarks />
        public const uint AssetType_SerialNumber = 3520;

        /// <remarks />
        public const uint AssetType_Manufacturers = 3521;

        /// <remarks />
        public const uint AssetType_LastChangeTimestamp = 3522;

        /// <remarks />
        public const uint AssetType_AssetDescription = 3523;

        /// <remarks />
        public const uint MeasurementType_SignificantDigits = 3530;

        /// <remarks />
        public const uint MeasurementType_Units = 3531;

        /// <remarks />
        public const uint MeasurementType_NativeUnits = 3532;

        /// <remarks />
        public const uint MeasurementType_LastChangeTimestamp = 3533;

        /// <remarks />
        public const uint MeasurementType_Code = 3534;

        /// <remarks />
        public const uint MeasurementType_Maximum = 3535;

        /// <remarks />
        public const uint MeasurementType_Minimum = 3536;

        /// <remarks />
        public const uint MeasurementType_Nominal = 3537;

        /// <remarks />
        public const uint CuttingToolType_ToolId = 3539;

        /// <remarks />
        public const uint CuttingToolType_ToolGroup = 3540;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_CutterStatus = 3546;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_CutterStatus_Status = 3547;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ReconditionCount = 3548;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ToolLife = 3550;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ToolLife_Type = 3551;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ToolLife_CountDirection = 3552;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ToolLife_Maximum = 3554;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ProgramToolNumber = 3555;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ProgramToolNumber_Maximum = 3556;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ProgramToolNumber_Minimum = 3557;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ProgramToolNumber_Nominal = 3558;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_Location = 3559;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_Location_Type = 3560;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_Location_NegativeOverlap = 3561;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_Location_PositiveOverlap = 3562;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ProgramSpindleSpeed = 3563;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ProgramSpindleSpeed_Maximum = 3564;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ProgramSpindleSpeed_Minimum = 3565;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ProgramSpindleSpeed_Nominal = 3566;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ProgramFeedRate = 3567;

        /// <remarks />
        public const uint CuttingToolLifeCycleType_ConnectionCodeMachineSide = 3568;

        /// <remarks />
        public const uint CutterStatusType_Status = 3570;

        /// <remarks />
        public const uint ReconditionCountType_MaximumCount = 3572;

        /// <remarks />
        public const uint LifeType_Type = 3574;

        /// <remarks />
        public const uint LifeType_CountDirection = 3575;

        /// <remarks />
        public const uint LifeType_WarningLevel = 3576;

        /// <remarks />
        public const uint LifeType_Maximum = 3577;

        /// <remarks />
        public const uint LocationType_Type = 3579;

        /// <remarks />
        public const uint LocationType_NegativeOverlap = 3580;

        /// <remarks />
        public const uint LocationType_PositiveOverlap = 3581;

        /// <remarks />
        public const uint ProgramSpindleSpeedType_Maximum = 3583;

        /// <remarks />
        public const uint ProgramSpindleSpeedType_Minimum = 3584;

        /// <remarks />
        public const uint ProgramSpindleSpeedType_Nominal = 3585;

        /// <remarks />
        public const uint ProgramFeedRateType_Maximum = 3587;

        /// <remarks />
        public const uint ProgramFeedRateType_Minimum = 3588;

        /// <remarks />
        public const uint ProgramFeedRateType_Nominal = 3589;

        /// <remarks />
        public const uint CuttingItemType_Indices = 3591;

        /// <remarks />
        public const uint CuttingItemType_ItemId = 3592;

        /// <remarks />
        public const uint CuttingItemType_Grade = 3593;

        /// <remarks />
        public const uint CuttingItemType_Manufacturers = 3594;

        /// <remarks />
        public const uint CuttingItemType_Description = 3595;

        /// <remarks />
        public const uint CuttingItemType_Locus = 3596;

        /// <remarks />
        public const uint ActuatorStateTypeEnum_EnumValues = 3614;

        /// <remarks />
        public const uint AlarmStateTypeEnum_EnumValues = 3616;

        /// <remarks />
        public const uint AvailabilityTypeEnum_EnumValues = 3622;

        /// <remarks />
        public const uint AxesCouplingTypeEnum_EnumValues = 3624;

        /// <remarks />
        public const uint CategoryTypeEnum_EnumValues = 3630;

        /// <remarks />
        public const uint ClampStateTypeEnum_EnumValues = 3633;

        /// <remarks />
        public const uint ControllerModeTypeEnum_EnumValues = 3636;

        /// <remarks />
        public const uint CoordinateSystemTypeEnum_EnumValues = 3638;

        /// <remarks />
        public const uint CutterStatusValueTypeEnum_EnumValues = 3646;

        /// <remarks />
        public const uint DataItemEnumTypeEnum_EnumValues = 3649;

        /// <remarks />
        public const uint DataItemStatisticsTypeEnum_EnumValues = 3653;

        /// <remarks />
        public const uint DataItemSubEnumTypeEnum_EnumValues = 3655;

        /// <remarks />
        public const uint DefinitionFormatTypeEnum_EnumValues = 3657;

        /// <remarks />
        public const uint DirectionTypeEnum_EnumValues = 3661;

        /// <remarks />
        public const uint DoorStateTypeEnum_EnumValues = 3663;

        /// <remarks />
        public const uint EmergencyStopTypeEnum_EnumValues = 3668;

        /// <remarks />
        public const uint ExecutionTypeEnum_EnumValues = 3671;

        /// <remarks />
        public const uint InterfaceStateTypeEnum_EnumValues = 3680;

        /// <remarks />
        public const uint LocationsTypeEnum_EnumValues = 3685;

        /// <remarks />
        public const uint NotificationCodeTypeEnum_EnumValues = 3702;

        /// <remarks />
        public const uint PathModeTypeEnum_EnumValues = 3707;

        /// <remarks />
        public const uint PowerStateTypeEnum_EnumValues = 3709;

        /// <remarks />
        public const uint QualifierTypeEnum_EnumValues = 3712;

        /// <remarks />
        public const uint RotaryModeTypeEnum_EnumValues = 3716;

        /// <remarks />
        public const uint SeverityTypeEnum_EnumValues = 3719;

        /// <remarks />
        public const uint ToolLifeDirectionTypeEnum_EnumValues = 3731;

        /// <remarks />
        public const uint ToolLifeTypeEnum_EnumValues = 3733;

        /// <remarks />
        public const uint MyOPCUAServer_BinarySchema = 3740;

        /// <remarks />
        public const uint MyOPCUAServer_BinarySchema_NamespaceUri = 3742;

        /// <remarks />
        public const uint MyOPCUAServer_BinarySchema_Deprecated = 3743;

        /// <remarks />
        public const uint MyOPCUAServer_BinarySchema_DataItemEnumDataType = 3744;

        /// <remarks />
        public const uint MyOPCUAServer_BinarySchema_DataItemStatisticsDataType = 3747;

        /// <remarks />
        public const uint MyOPCUAServer_XmlSchema = 3752;

        /// <remarks />
        public const uint MyOPCUAServer_XmlSchema_NamespaceUri = 3754;

        /// <remarks />
        public const uint MyOPCUAServer_XmlSchema_Deprecated = 3755;

        /// <remarks />
        public const uint MyOPCUAServer_XmlSchema_DataItemEnumDataType = 3756;

        /// <remarks />
        public const uint MyOPCUAServer_XmlSchema_DataItemStatisticsDataType = 3759;
    }
    #endregion

    #region VariableType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <remarks />
        public const uint MTSampleDataItemType = 85;

        /// <remarks />
        public const uint AccelerationType = 95;

        /// <remarks />
        public const uint AccumulatedTimeType = 105;

        /// <remarks />
        public const uint AmperageType = 115;

        /// <remarks />
        public const uint AngleType = 125;

        /// <remarks />
        public const uint AngularAccelerationType = 135;

        /// <remarks />
        public const uint AngularVelocityType = 145;

        /// <remarks />
        public const uint AxisFeedrateType = 155;

        /// <remarks />
        public const uint ConcentrationType = 165;

        /// <remarks />
        public const uint ConductivityType = 175;

        /// <remarks />
        public const uint DisplacementType = 185;

        /// <remarks />
        public const uint ElectricalEnergyType = 195;

        /// <remarks />
        public const uint FillLevelType = 205;

        /// <remarks />
        public const uint FlowType = 215;

        /// <remarks />
        public const uint FrequencyType = 225;

        /// <remarks />
        public const uint LinearForceType = 235;

        /// <remarks />
        public const uint LoadType = 245;

        /// <remarks />
        public const uint MassType = 255;

        /// <remarks />
        public const uint PathFeedrateType = 265;

        /// <remarks />
        public const uint PathPositionType = 275;

        /// <remarks />
        public const uint PHType = 285;

        /// <remarks />
        public const uint PositionType = 295;

        /// <remarks />
        public const uint PowerFactorType = 305;

        /// <remarks />
        public const uint PressureType = 315;

        /// <remarks />
        public const uint ResistanceType = 325;

        /// <remarks />
        public const uint RotationalVelocityType = 335;

        /// <remarks />
        public const uint SoundPressureType = 345;

        /// <remarks />
        public const uint StrainType = 355;

        /// <remarks />
        public const uint TemperatureType = 365;

        /// <remarks />
        public const uint TiltType = 375;

        /// <remarks />
        public const uint TorqueType = 385;

        /// <remarks />
        public const uint VelocityType = 395;

        /// <remarks />
        public const uint ViscosityType = 405;

        /// <remarks />
        public const uint VoltageType = 415;

        /// <remarks />
        public const uint VoltAmpereType = 425;

        /// <remarks />
        public const uint VoltAmpereReactiveType = 435;

        /// <remarks />
        public const uint WattageType = 445;

        /// <remarks />
        public const uint MTEventDataItemType = 455;

        /// <remarks />
        public const uint ActiveAxesType = 460;

        /// <remarks />
        public const uint ActuatorStateType = 465;

        /// <remarks />
        public const uint AvailabilityType = 470;

        /// <remarks />
        public const uint AxesCouplingType = 475;

        /// <remarks />
        public const uint BlockType = 480;

        /// <remarks />
        public const uint ClampStateType = 485;

        /// <remarks />
        public const uint ControllerModeType = 490;

        /// <remarks />
        public const uint CoupledAxesType = 495;

        /// <remarks />
        public const uint DirectionType = 500;

        /// <remarks />
        public const uint DoorStateType = 505;

        /// <remarks />
        public const uint EmergencyStopType = 510;

        /// <remarks />
        public const uint ExecutionType = 515;

        /// <remarks />
        public const uint LineType = 520;

        /// <remarks />
        public const uint MessageType = 525;

        /// <remarks />
        public const uint PalletIdType = 530;

        /// <remarks />
        public const uint PartCountType = 535;

        /// <remarks />
        public const uint PartIdType = 540;

        /// <remarks />
        public const uint PathModeType = 545;

        /// <remarks />
        public const uint PowerStateType = 550;

        /// <remarks />
        public const uint ProgramType = 555;

        /// <remarks />
        public const uint RotaryModeType = 560;

        /// <remarks />
        public const uint ToolAssetIdType = 565;

        /// <remarks />
        public const uint ToolNumberType = 570;

        /// <remarks />
        public const uint WorkHoldingIdType = 575;

        /// <remarks />
        public const uint ChannelType = 3461;

        /// <remarks />
        public const uint MeasurementType = 3524;

        /// <remarks />
        public const uint CutterStatusType = 3569;

        /// <remarks />
        public const uint ReconditionCountType = 3571;

        /// <remarks />
        public const uint LifeType = 3573;

        /// <remarks />
        public const uint LocationType = 3578;

        /// <remarks />
        public const uint ProgramSpindleSpeedType = 3582;

        /// <remarks />
        public const uint ProgramFeedRateType = 3586;

        /// <remarks />
        public const uint CuttingItemType = 3590;

        /// <remarks />
        public const uint AssemblyMeasurementType = 3599;
    }
    #endregion

    #region DataType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ActuatorStateTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.ActuatorStateTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AlarmStateTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.AlarmStateTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AssetDescriptionType = new ExpandedNodeId(MyOPCUAServer.DataTypes.AssetDescriptionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AssetAttrDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.AssetAttrDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AssetBufferSizeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.AssetBufferSizeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AssetIdDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.AssetIdDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AvailabilityTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.AvailabilityTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AxesCouplingTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.AxesCouplingTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AxesListValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.AxesListValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId BufferSizeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.BufferSizeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CalibrationDateDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.CalibrationDateDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CalibrationInitialsDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.CalibrationInitialsDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CategoryTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.CategoryTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChannelNumberDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ChannelNumberDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ClampStateTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.ClampStateTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConditionDescriptionDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ConditionDescriptionDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerModeTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.ControllerModeTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CoordinateSystemTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.CoordinateSystemTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId IDDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.IDDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CodeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.CodeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentIdDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ComponentIdDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionCodeMachineSideDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ConnectionCodeMachineSideDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CountValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.CountValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CreationTimeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.CreationTimeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CutterStatusValueTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.CutterStatusValueTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemEnumDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.DataItemEnumDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemEnumTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.DataItemEnumTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemIdDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.DataItemIdDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemStatisticsDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.DataItemStatisticsDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemStatisticsTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.DataItemStatisticsTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemSubEnumTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.DataItemSubEnumTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DefinitionFormatTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.DefinitionFormatTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DecibelValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.DecibelValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DescriptionTextDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.DescriptionTextDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.DirectionTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DoorStateTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.DoorStateTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DurationTimeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.DurationTimeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DurationValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.DurationValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId EdgeCountDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.EdgeCountDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId EmergencyStopTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.EmergencyStopTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.EnergyValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ExecutionTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.ExecutionTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FeedrateValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.FeedrateValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FirmwareVersionDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.FirmwareVersionDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ForceValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ForceValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId GradeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.GradeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId IndexRangeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.IndexRangeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId InstanceIdDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.InstanceIdDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ItemIdDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ItemIdDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId InterfaceStateTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.InterfaceStateTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ItemSourceDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ItemSourceDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LocationSizeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.LocationSizeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LocationValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.LocationValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LocationsTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.LocationsTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LocusDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.LocusDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ManufacturersDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ManufacturersDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.MassValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MaximumCountDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.MaximumCountDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MaximumDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.MaximumDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.MeasurementValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MinimumDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.MinimumDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ModelDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ModelDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId NameDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.NameDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId NativeCodeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.NativeCodeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId NativeNotifcationCodeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.NativeNotifcationCodeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId NativeScaleDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.NativeScaleDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId NativeSeverityDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.NativeSeverityDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId NextCalibrationDateDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.NextCalibrationDateDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId NominalDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.NominalDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId NotificationCodeTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.NotificationCodeTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId NotificationDescriptionDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.NotificationDescriptionDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OccurrenceTimeDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.OccurrenceTimeDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OverlapDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.OverlapDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PathModeTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.PathModeTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PowerStateTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.PowerStateTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramToolNumberDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ProgramToolNumberDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId QualifierTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.QualifierTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId RateDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.RateDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ReconditionCountValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ReconditionCountValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId RotaryModeTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.RotaryModeTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SampleRateDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.SampleRateDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SeverityTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.SeverityTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SignificantDigitsValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.SignificantDigitsValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StationDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.StationDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SenderDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.SenderDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SequenceDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.SequenceDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SerialNumberDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.SerialNumberDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SpeedDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.SpeedDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TestIndicatorDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.TestIndicatorDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ToolEventValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ToolEventValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ToolGroupDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ToolGroupDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ToolIdDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ToolIdDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ToolLifeDirectionTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.ToolLifeDirectionTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ToolLifeTypeEnum = new ExpandedNodeId(MyOPCUAServer.DataTypes.ToolLifeTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ToolLifeValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.ToolLifeValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId UnitsExtDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.UnitsExtDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VersionDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.VersionDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VibrationValueDataType = new ExpandedNodeId(MyOPCUAServer.DataTypes.VibrationValueDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MTDevices = new ExpandedNodeId(MyOPCUAServer.Objects.MTDevices, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDeviceType_DataItems = new ExpandedNodeId(MyOPCUAServer.Objects.MTDeviceType_DataItems, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDeviceType_Components = new ExpandedNodeId(MyOPCUAServer.Objects.MTDeviceType_Components, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDeviceType_Conditions = new ExpandedNodeId(MyOPCUAServer.Objects.MTDeviceType_Conditions, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_LimitState = new ExpandedNodeId(MyOPCUAServer.Objects.MTConditionType_LimitState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingItemType_ItemLife = new ExpandedNodeId(MyOPCUAServer.Objects.CuttingItemType_ItemLife, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingItemType_Measurements = new ExpandedNodeId(MyOPCUAServer.Objects.CuttingItemType_Measurements, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemEnumDataType_Encoding_DefaultBinary = new ExpandedNodeId(MyOPCUAServer.Objects.DataItemEnumDataType_Encoding_DefaultBinary, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemStatisticsDataType_Encoding_DefaultBinary = new ExpandedNodeId(MyOPCUAServer.Objects.DataItemStatisticsDataType_Encoding_DefaultBinary, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemEnumDataType_Encoding_DefaultXml = new ExpandedNodeId(MyOPCUAServer.Objects.DataItemEnumDataType_Encoding_DefaultXml, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemStatisticsDataType_Encoding_DefaultXml = new ExpandedNodeId(MyOPCUAServer.Objects.DataItemStatisticsDataType_Encoding_DefaultXml, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemEnumDataType_Encoding_DefaultJson = new ExpandedNodeId(MyOPCUAServer.Objects.DataItemEnumDataType_Encoding_DefaultJson, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemStatisticsDataType_Encoding_DefaultJson = new ExpandedNodeId(MyOPCUAServer.Objects.DataItemStatisticsDataType_Encoding_DefaultJson, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MTDevicesType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MTDevicesType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDeviceType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MTDeviceType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTComponentType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MTComponentType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTAxesType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MTAxesType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTControllerType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MTControllerType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDoorType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MTDoorType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTActuatorType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MTActuatorType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MTConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.AccelerationConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Accumulated_TimeConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.AmperageConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.AngleConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Angular-AccelerationConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Angular_VelocityConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.CommunicationsConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.ConcentrationConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.ConductivityConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Data_RangeConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.DirectionConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.DisplacementConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Electrical_EnergyConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Fill_LevelConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.FlowConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.FrequencyConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.HardwareConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Linear_ForceConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.LoadConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Logic_ProgramConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.MassConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Motion_ProgramConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Path_FeedrateConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Path_PositionConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.PHConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.PositionConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Power_FactorConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.PressureConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.ResistanceConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Rotary_VelocityConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Sound_LevelConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.StrainConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.SystemConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.TemperatureConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.TiltConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.TorqueConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.VelocityConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.ViscosityConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.VoltageConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.Volt_AmperageConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.VoltAmperageReactiveConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.WattageConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.ConfigurationType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SensorConfigurationType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.SensorConfigurationType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.SensorType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SourceType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.SourceType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.AssetType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.CuttingToolType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType = new ExpandedNodeId(MyOPCUAServer.ObjectTypes.CuttingToolLifeCycleType, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MTDevicesType_MTConnectVersion = new ExpandedNodeId(MyOPCUAServer.Variables.MTDevicesType_MTConnectVersion, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDevicesType_OPCUAMappingDate = new ExpandedNodeId(MyOPCUAServer.Variables.MTDevicesType_OPCUAMappingDate, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDevicesType_OPCUAVersion = new ExpandedNodeId(MyOPCUAServer.Variables.MTDevicesType_OPCUAVersion, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDeviceType_Availability = new ExpandedNodeId(MyOPCUAServer.Variables.MTDeviceType_Availability, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDeviceType_Manufacturer = new ExpandedNodeId(MyOPCUAServer.Variables.MTDeviceType_Manufacturer, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDeviceType_SerialNumber = new ExpandedNodeId(MyOPCUAServer.Variables.MTDeviceType_SerialNumber, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDeviceType_Configuration = new ExpandedNodeId(MyOPCUAServer.Variables.MTDeviceType_Configuration, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDeviceType_SampleInterval = new ExpandedNodeId(MyOPCUAServer.Variables.MTDeviceType_SampleInterval, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTComponentType_Model = new ExpandedNodeId(MyOPCUAServer.Variables.MTComponentType_Model, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTComponentType_Station = new ExpandedNodeId(MyOPCUAServer.Variables.MTComponentType_Station, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTAxesType_LinearAxesX = new ExpandedNodeId(MyOPCUAServer.Variables.MTAxesType_LinearAxesX, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTAxesType_LinearAxesY = new ExpandedNodeId(MyOPCUAServer.Variables.MTAxesType_LinearAxesY, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTAxesType_LinearAxesZ = new ExpandedNodeId(MyOPCUAServer.Variables.MTAxesType_LinearAxesZ, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTAxesType_RotoryAxesA = new ExpandedNodeId(MyOPCUAServer.Variables.MTAxesType_RotoryAxesA, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTAxesType_RotoryAxesB = new ExpandedNodeId(MyOPCUAServer.Variables.MTAxesType_RotoryAxesB, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTAxesType_RotoryAxesC = new ExpandedNodeId(MyOPCUAServer.Variables.MTAxesType_RotoryAxesC, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTDoorType_DoorState = new ExpandedNodeId(MyOPCUAServer.Variables.MTDoorType_DoorState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTActuatorType_LinearAxesX = new ExpandedNodeId(MyOPCUAServer.Variables.MTActuatorType_LinearAxesX, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTSampleDataItemType_CoordinateSystem = new ExpandedNodeId(MyOPCUAServer.Variables.MTSampleDataItemType_CoordinateSystem, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTSampleDataItemType_NativeUnits = new ExpandedNodeId(MyOPCUAServer.Variables.MTSampleDataItemType_NativeUnits, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTSampleDataItemType_NativeScale = new ExpandedNodeId(MyOPCUAServer.Variables.MTSampleDataItemType_NativeScale, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTSampleDataItemType_SampleInterval = new ExpandedNodeId(MyOPCUAServer.Variables.MTSampleDataItemType_SampleInterval, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTEventDataItemType_CoordinateSystem = new ExpandedNodeId(MyOPCUAServer.Variables.MTEventDataItemType_CoordinateSystem, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTEventDataItemType_SampleInterval = new ExpandedNodeId(MyOPCUAServer.Variables.MTEventDataItemType_SampleInterval, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_MTCurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_MTCurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_ActiveState = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_ActiveState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_NativeCode = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_NativeCode, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTConditionType_NativeSeverity = new ExpandedNodeId(MyOPCUAServer.Variables.MTConditionType_NativeSeverity, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AccelerationConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Accumulated_TimeConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AmperageConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.AngleConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular-AccelerationConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Angular-AccelerationConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Angular_VelocityConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Angular_VelocityConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationsConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.CommunicationsConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ConcentrationConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ConductivityConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Data_RangeConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Data_RangeConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.DisplacementConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Electrical_EnergyConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Fill_LevelConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Fill_LevelConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.FlowConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.FrequencyConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId HardwareConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.HardwareConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Linear_ForceConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Linear_ForceConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.LoadConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Logic_ProgramConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Logic_ProgramConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.MassConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Motion_ProgramConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Motion_ProgramConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_FeedrateConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Path_FeedrateConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Path_PositionConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Path_PositionConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PHConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PositionConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Power_FactorConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Power_FactorConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.PressureConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ResistanceConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Rotary_VelocityConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Sound_LevelConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Sound_LevelConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.StrainConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SystemConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.SystemConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TemperatureConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TiltConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.TorqueConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VelocityConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.ViscosityConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VoltageConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId Volt_AmperageConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.Volt_AmperageConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.VoltAmperageReactiveConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_EnabledState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_EnabledState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_Quality_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_Quality_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_LastSeverity_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_Comment_SourceTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_Comment_SourceTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_AddComment_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_AddComment_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_ConditionRefresh_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_ConditionRefresh2_InputArguments, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_ActiveState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_ActiveState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_LimitState_CurrentState = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_LimitState_CurrentState, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_LimitState_CurrentState_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(MyOPCUAServer.Variables.WattageConditionType_LimitState_LastTransition_Id, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChannelType_CalibrationDate = new ExpandedNodeId(MyOPCUAServer.Variables.ChannelType_CalibrationDate, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChannelType_NextCalibrationDate = new ExpandedNodeId(MyOPCUAServer.Variables.ChannelType_NextCalibrationDate, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChannelType_CalibrationInitials = new ExpandedNodeId(MyOPCUAServer.Variables.ChannelType_CalibrationInitials, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SensorConfigurationType_FirmwareVersion = new ExpandedNodeId(MyOPCUAServer.Variables.SensorConfigurationType_FirmwareVersion, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SourceType_ComponentId = new ExpandedNodeId(MyOPCUAServer.Variables.SourceType_ComponentId, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_SerialNumber = new ExpandedNodeId(MyOPCUAServer.Variables.AssetType_SerialNumber, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Manufacturers = new ExpandedNodeId(MyOPCUAServer.Variables.AssetType_Manufacturers, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_LastChangeTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.AssetType_LastChangeTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_AssetDescription = new ExpandedNodeId(MyOPCUAServer.Variables.AssetType_AssetDescription, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementType_SignificantDigits = new ExpandedNodeId(MyOPCUAServer.Variables.MeasurementType_SignificantDigits, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementType_Units = new ExpandedNodeId(MyOPCUAServer.Variables.MeasurementType_Units, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementType_NativeUnits = new ExpandedNodeId(MyOPCUAServer.Variables.MeasurementType_NativeUnits, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementType_LastChangeTimestamp = new ExpandedNodeId(MyOPCUAServer.Variables.MeasurementType_LastChangeTimestamp, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementType_Code = new ExpandedNodeId(MyOPCUAServer.Variables.MeasurementType_Code, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementType_Maximum = new ExpandedNodeId(MyOPCUAServer.Variables.MeasurementType_Maximum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementType_Minimum = new ExpandedNodeId(MyOPCUAServer.Variables.MeasurementType_Minimum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementType_Nominal = new ExpandedNodeId(MyOPCUAServer.Variables.MeasurementType_Nominal, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolType_ToolId = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolType_ToolId, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolType_ToolGroup = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolType_ToolGroup, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_CutterStatus = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_CutterStatus, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_CutterStatus_Status = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_CutterStatus_Status, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ReconditionCount = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ReconditionCount, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ToolLife = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ToolLife, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ToolLife_Type = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ToolLife_Type, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ToolLife_CountDirection = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ToolLife_CountDirection, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ToolLife_Maximum = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ToolLife_Maximum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ProgramToolNumber = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ProgramToolNumber, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ProgramToolNumber_Maximum = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ProgramToolNumber_Maximum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ProgramToolNumber_Minimum = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ProgramToolNumber_Minimum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ProgramToolNumber_Nominal = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ProgramToolNumber_Nominal, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_Location = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_Location, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_Location_Type = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_Location_Type, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_Location_NegativeOverlap = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_Location_NegativeOverlap, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_Location_PositiveOverlap = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_Location_PositiveOverlap, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ProgramSpindleSpeed = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ProgramSpindleSpeed, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ProgramSpindleSpeed_Maximum = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ProgramSpindleSpeed_Maximum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ProgramSpindleSpeed_Minimum = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ProgramSpindleSpeed_Minimum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ProgramSpindleSpeed_Nominal = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ProgramSpindleSpeed_Nominal, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ProgramFeedRate = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ProgramFeedRate, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingToolLifeCycleType_ConnectionCodeMachineSide = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingToolLifeCycleType_ConnectionCodeMachineSide, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CutterStatusType_Status = new ExpandedNodeId(MyOPCUAServer.Variables.CutterStatusType_Status, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ReconditionCountType_MaximumCount = new ExpandedNodeId(MyOPCUAServer.Variables.ReconditionCountType_MaximumCount, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LifeType_Type = new ExpandedNodeId(MyOPCUAServer.Variables.LifeType_Type, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LifeType_CountDirection = new ExpandedNodeId(MyOPCUAServer.Variables.LifeType_CountDirection, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LifeType_WarningLevel = new ExpandedNodeId(MyOPCUAServer.Variables.LifeType_WarningLevel, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LifeType_Maximum = new ExpandedNodeId(MyOPCUAServer.Variables.LifeType_Maximum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LocationType_Type = new ExpandedNodeId(MyOPCUAServer.Variables.LocationType_Type, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LocationType_NegativeOverlap = new ExpandedNodeId(MyOPCUAServer.Variables.LocationType_NegativeOverlap, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LocationType_PositiveOverlap = new ExpandedNodeId(MyOPCUAServer.Variables.LocationType_PositiveOverlap, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramSpindleSpeedType_Maximum = new ExpandedNodeId(MyOPCUAServer.Variables.ProgramSpindleSpeedType_Maximum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramSpindleSpeedType_Minimum = new ExpandedNodeId(MyOPCUAServer.Variables.ProgramSpindleSpeedType_Minimum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramSpindleSpeedType_Nominal = new ExpandedNodeId(MyOPCUAServer.Variables.ProgramSpindleSpeedType_Nominal, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramFeedRateType_Maximum = new ExpandedNodeId(MyOPCUAServer.Variables.ProgramFeedRateType_Maximum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramFeedRateType_Minimum = new ExpandedNodeId(MyOPCUAServer.Variables.ProgramFeedRateType_Minimum, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramFeedRateType_Nominal = new ExpandedNodeId(MyOPCUAServer.Variables.ProgramFeedRateType_Nominal, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingItemType_Indices = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingItemType_Indices, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingItemType_ItemId = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingItemType_ItemId, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingItemType_Grade = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingItemType_Grade, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingItemType_Manufacturers = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingItemType_Manufacturers, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingItemType_Description = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingItemType_Description, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingItemType_Locus = new ExpandedNodeId(MyOPCUAServer.Variables.CuttingItemType_Locus, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ActuatorStateTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.ActuatorStateTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AlarmStateTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.AlarmStateTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AvailabilityTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.AvailabilityTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AxesCouplingTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.AxesCouplingTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CategoryTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.CategoryTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ClampStateTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.ClampStateTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerModeTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.ControllerModeTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CoordinateSystemTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.CoordinateSystemTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CutterStatusValueTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.CutterStatusValueTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemEnumTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.DataItemEnumTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemStatisticsTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.DataItemStatisticsTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DataItemSubEnumTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.DataItemSubEnumTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DefinitionFormatTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.DefinitionFormatTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.DirectionTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DoorStateTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.DoorStateTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId EmergencyStopTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.EmergencyStopTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ExecutionTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.ExecutionTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId InterfaceStateTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.InterfaceStateTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LocationsTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.LocationsTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId NotificationCodeTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.NotificationCodeTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PathModeTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.PathModeTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PowerStateTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.PowerStateTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId QualifierTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.QualifierTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId RotaryModeTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.RotaryModeTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SeverityTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.SeverityTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ToolLifeDirectionTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.ToolLifeDirectionTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ToolLifeTypeEnum_EnumValues = new ExpandedNodeId(MyOPCUAServer.Variables.ToolLifeTypeEnum_EnumValues, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MyOPCUAServer_BinarySchema = new ExpandedNodeId(MyOPCUAServer.Variables.MyOPCUAServer_BinarySchema, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MyOPCUAServer_BinarySchema_NamespaceUri = new ExpandedNodeId(MyOPCUAServer.Variables.MyOPCUAServer_BinarySchema_NamespaceUri, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MyOPCUAServer_BinarySchema_Deprecated = new ExpandedNodeId(MyOPCUAServer.Variables.MyOPCUAServer_BinarySchema_Deprecated, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MyOPCUAServer_BinarySchema_DataItemEnumDataType = new ExpandedNodeId(MyOPCUAServer.Variables.MyOPCUAServer_BinarySchema_DataItemEnumDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MyOPCUAServer_BinarySchema_DataItemStatisticsDataType = new ExpandedNodeId(MyOPCUAServer.Variables.MyOPCUAServer_BinarySchema_DataItemStatisticsDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MyOPCUAServer_XmlSchema = new ExpandedNodeId(MyOPCUAServer.Variables.MyOPCUAServer_XmlSchema, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MyOPCUAServer_XmlSchema_NamespaceUri = new ExpandedNodeId(MyOPCUAServer.Variables.MyOPCUAServer_XmlSchema_NamespaceUri, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MyOPCUAServer_XmlSchema_Deprecated = new ExpandedNodeId(MyOPCUAServer.Variables.MyOPCUAServer_XmlSchema_Deprecated, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MyOPCUAServer_XmlSchema_DataItemEnumDataType = new ExpandedNodeId(MyOPCUAServer.Variables.MyOPCUAServer_XmlSchema_DataItemEnumDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MyOPCUAServer_XmlSchema_DataItemStatisticsDataType = new ExpandedNodeId(MyOPCUAServer.Variables.MyOPCUAServer_XmlSchema_DataItemStatisticsDataType, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MTSampleDataItemType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.MTSampleDataItemType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccelerationType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.AccelerationType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AccumulatedTimeType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.AccumulatedTimeType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AmperageType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.AmperageType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngleType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.AngleType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngularAccelerationType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.AngularAccelerationType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AngularVelocityType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.AngularVelocityType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AxisFeedrateType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.AxisFeedrateType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConcentrationType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ConcentrationType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ConductivityType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ConductivityType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DisplacementType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.DisplacementType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ElectricalEnergyType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ElectricalEnergyType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FillLevelType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.FillLevelType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FlowType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.FlowType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId FrequencyType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.FrequencyType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LinearForceType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.LinearForceType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LoadType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.LoadType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MassType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.MassType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PathFeedrateType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PathFeedrateType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PathPositionType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PathPositionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PHType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PHType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PositionType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PositionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PowerFactorType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PowerFactorType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PressureType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PressureType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ResistanceType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ResistanceType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId RotationalVelocityType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.RotationalVelocityType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId SoundPressureType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.SoundPressureType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId StrainType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.StrainType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.TemperatureType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TiltType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.TiltType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TorqueType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.TorqueType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VelocityType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.VelocityType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ViscosityType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ViscosityType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltageType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.VoltageType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmpereType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.VoltAmpereType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId VoltAmpereReactiveType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.VoltAmpereReactiveType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WattageType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.WattageType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MTEventDataItemType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.MTEventDataItemType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ActiveAxesType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ActiveAxesType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ActuatorStateType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ActuatorStateType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AvailabilityType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.AvailabilityType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AxesCouplingType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.AxesCouplingType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.BlockType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ClampStateType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ClampStateType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ControllerModeType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ControllerModeType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CoupledAxesType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.CoupledAxesType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DirectionType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.DirectionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId DoorStateType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.DoorStateType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId EmergencyStopType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.EmergencyStopType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ExecutionType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ExecutionType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LineType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.LineType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MessageType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.MessageType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PalletIdType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PalletIdType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PartCountType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PartCountType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PartIdType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PartIdType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PathModeType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PathModeType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId PowerStateType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.PowerStateType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ProgramType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId RotaryModeType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.RotaryModeType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ToolAssetIdType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ToolAssetIdType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ToolNumberType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ToolNumberType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId WorkHoldingIdType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.WorkHoldingIdType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ChannelType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ChannelType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.MeasurementType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CutterStatusType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.CutterStatusType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ReconditionCountType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ReconditionCountType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LifeType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.LifeType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId LocationType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.LocationType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramSpindleSpeedType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ProgramSpindleSpeedType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProgramFeedRateType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.ProgramFeedRateType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId CuttingItemType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.CuttingItemType, MyOPCUAServer.Namespaces.MyOPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId AssemblyMeasurementType = new ExpandedNodeId(MyOPCUAServer.VariableTypes.AssemblyMeasurementType, MyOPCUAServer.Namespaces.MyOPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AccelerationConditionType = "AccelerationConditionType";

        /// <remarks />
        public const string AccelerationType = "AccelerationType";

        /// <remarks />
        public const string Accumulated_TimeConditionType = "Accumulated_TimeConditionType";

        /// <remarks />
        public const string AccumulatedTimeType = "AccumulatedTimeType";

        /// <remarks />
        public const string ActiveAxesType = "ActiveAxesType";

        /// <remarks />
        public const string ActiveState = "ActiveState";

        /// <remarks />
        public const string ActuatorStateType = "ActuatorStateType";

        /// <remarks />
        public const string ActuatorStateTypeEnum = "ActuatorStateTypeEnum";

        /// <remarks />
        public const string AlarmStateTypeEnum = "AlarmStateTypeEnum";

        /// <remarks />
        public const string AmperageConditionType = "AmperageConditionType";

        /// <remarks />
        public const string AmperageType = "AmperageType";

        /// <remarks />
        public const string AngleConditionType = "AngleConditionType";

        /// <remarks />
        public const string AngleType = "AngleType";

        /// <remarks />
        public const string Angular_VelocityConditionType = "Angular_VelocityConditionType";

        /// <remarks />
        public const string Angular-AccelerationConditionType = "Angular-AccelerationConditionType";

        /// <remarks />
        public const string AngularAccelerationType = "AngularAccelerationType";

        /// <remarks />
        public const string AngularVelocityType = "AngularVelocityType";

        /// <remarks />
        public const string AssemblyMeasurementType = "AssemblyMeasurementType";

        /// <remarks />
        public const string AssetAttrDataType = "AssetAttrDataType";

        /// <remarks />
        public const string AssetBufferSizeDataType = "AssetBufferSizeDataType";

        /// <remarks />
        public const string AssetDescription = "AssetDescription";

        /// <remarks />
        public const string AssetDescriptionType = "AssetDescriptionType";

        /// <remarks />
        public const string AssetIdDataType = "AssetIdDataType";

        /// <remarks />
        public const string AssetType = "AssetType";

        /// <remarks />
        public const string Availability = "Availability";

        /// <remarks />
        public const string AvailabilityType = "AvailabilityType";

        /// <remarks />
        public const string AvailabilityTypeEnum = "AvailabilityTypeEnum";

        /// <remarks />
        public const string AxesCouplingType = "AxesCouplingType";

        /// <remarks />
        public const string AxesCouplingTypeEnum = "AxesCouplingTypeEnum";

        /// <remarks />
        public const string AxesListValueDataType = "AxesListValueDataType";

        /// <remarks />
        public const string AxisFeedrateType = "AxisFeedrateType";

        /// <remarks />
        public const string BlockType = "BlockType";

        /// <remarks />
        public const string BufferSizeDataType = "BufferSizeDataType";

        /// <remarks />
        public const string CalibrationDate = "CalibrationDate";

        /// <remarks />
        public const string CalibrationDateDataType = "CalibrationDateDataType";

        /// <remarks />
        public const string CalibrationInitials = "CalibrationInitials";

        /// <remarks />
        public const string CalibrationInitialsDataType = "CalibrationInitialsDataType";

        /// <remarks />
        public const string CategoryTypeEnum = "CategoryTypeEnum";

        /// <remarks />
        public const string ChannelNumberDataType = "ChannelNumberDataType";

        /// <remarks />
        public const string ChannelType = "ChannelType";

        /// <remarks />
        public const string ClampStateType = "ClampStateType";

        /// <remarks />
        public const string ClampStateTypeEnum = "ClampStateTypeEnum";

        /// <remarks />
        public const string Code = "Code";

        /// <remarks />
        public const string CodeDataType = "CodeDataType";

        /// <remarks />
        public const string CommunicationsConditionType = "CommunicationsConditionType";

        /// <remarks />
        public const string ComponentId = "ComponentId";

        /// <remarks />
        public const string ComponentIdDataType = "ComponentIdDataType";

        /// <remarks />
        public const string Components = "Components";

        /// <remarks />
        public const string ConcentrationConditionType = "ConcentrationConditionType";

        /// <remarks />
        public const string ConcentrationType = "ConcentrationType";

        /// <remarks />
        public const string ConditionDescriptionDataType = "ConditionDescriptionDataType";

        /// <remarks />
        public const string Conditions = "Conditions";

        /// <remarks />
        public const string ConductivityConditionType = "ConductivityConditionType";

        /// <remarks />
        public const string ConductivityType = "ConductivityType";

        /// <remarks />
        public const string Configuration = "Configuration";

        /// <remarks />
        public const string ConfigurationType = "ConfigurationType";

        /// <remarks />
        public const string ConnectionCodeMachineSide = "ConnectionCodeMachineSide";

        /// <remarks />
        public const string ConnectionCodeMachineSideDataType = "ConnectionCodeMachineSideDataType";

        /// <remarks />
        public const string ControllerModeType = "ControllerModeType";

        /// <remarks />
        public const string ControllerModeTypeEnum = "ControllerModeTypeEnum";

        /// <remarks />
        public const string CoordinateSystem = "CoordinateSystem";

        /// <remarks />
        public const string CoordinateSystemTypeEnum = "CoordinateSystemTypeEnum";

        /// <remarks />
        public const string CountDirection = "CountDirection";

        /// <remarks />
        public const string CountValueDataType = "CountValueDataType";

        /// <remarks />
        public const string CoupledAxesType = "CoupledAxesType";

        /// <remarks />
        public const string CreationTimeDataType = "CreationTimeDataType";

        /// <remarks />
        public const string CutterStatus = "CutterStatus";

        /// <remarks />
        public const string CutterStatusType = "CutterStatusType";

        /// <remarks />
        public const string CutterStatusValueTypeEnum = "CutterStatusValueTypeEnum";

        /// <remarks />
        public const string CuttingItemType = "CuttingItemType";

        /// <remarks />
        public const string CuttingToolLifeCycleType = "CuttingToolLifeCycleType";

        /// <remarks />
        public const string CuttingToolType = "CuttingToolType";

        /// <remarks />
        public const string Data_RangeConditionType = "Data_RangeConditionType";

        /// <remarks />
        public const string DataItemEnumDataType = "DataItemEnumDataType";

        /// <remarks />
        public const string DataItemEnumTypeEnum = "DataItemEnumTypeEnum";

        /// <remarks />
        public const string DataItemIdDataType = "DataItemIdDataType";

        /// <remarks />
        public const string DataItems = "DataItems";

        /// <remarks />
        public const string DataItemStatisticsDataType = "DataItemStatisticsDataType";

        /// <remarks />
        public const string DataItemStatisticsTypeEnum = "DataItemStatisticsTypeEnum";

        /// <remarks />
        public const string DataItemSubEnumTypeEnum = "DataItemSubEnumTypeEnum";

        /// <remarks />
        public const string DecibelValueDataType = "DecibelValueDataType";

        /// <remarks />
        public const string DefinitionFormatTypeEnum = "DefinitionFormatTypeEnum";

        /// <remarks />
        public const string Description = "Description";

        /// <remarks />
        public const string DescriptionTextDataType = "DescriptionTextDataType";

        /// <remarks />
        public const string DirectionConditionType = "DirectionConditionType";

        /// <remarks />
        public const string DirectionType = "DirectionType";

        /// <remarks />
        public const string DirectionTypeEnum = "DirectionTypeEnum";

        /// <remarks />
        public const string DisplacementConditionType = "DisplacementConditionType";

        /// <remarks />
        public const string DisplacementType = "DisplacementType";

        /// <remarks />
        public const string DoorState = "DoorState";

        /// <remarks />
        public const string DoorStateType = "DoorStateType";

        /// <remarks />
        public const string DoorStateTypeEnum = "DoorStateTypeEnum";

        /// <remarks />
        public const string DurationTimeDataType = "DurationTimeDataType";

        /// <remarks />
        public const string DurationValueDataType = "DurationValueDataType";

        /// <remarks />
        public const string EdgeCountDataType = "EdgeCountDataType";

        /// <remarks />
        public const string Electrical_EnergyConditionType = "Electrical_EnergyConditionType";

        /// <remarks />
        public const string ElectricalEnergyType = "ElectricalEnergyType";

        /// <remarks />
        public const string EmergencyStopType = "EmergencyStopType";

        /// <remarks />
        public const string EmergencyStopTypeEnum = "EmergencyStopTypeEnum";

        /// <remarks />
        public const string EnergyValueDataType = "EnergyValueDataType";

        /// <remarks />
        public const string ExecutionType = "ExecutionType";

        /// <remarks />
        public const string ExecutionTypeEnum = "ExecutionTypeEnum";

        /// <remarks />
        public const string FeedrateValueDataType = "FeedrateValueDataType";

        /// <remarks />
        public const string Fill_LevelConditionType = "Fill_LevelConditionType";

        /// <remarks />
        public const string FillLevelType = "FillLevelType";

        /// <remarks />
        public const string FirmwareVersion = "FirmwareVersion";

        /// <remarks />
        public const string FirmwareVersionDataType = "FirmwareVersionDataType";

        /// <remarks />
        public const string FlowConditionType = "FlowConditionType";

        /// <remarks />
        public const string FlowType = "FlowType";

        /// <remarks />
        public const string ForceValueDataType = "ForceValueDataType";

        /// <remarks />
        public const string FrequencyConditionType = "FrequencyConditionType";

        /// <remarks />
        public const string FrequencyType = "FrequencyType";

        /// <remarks />
        public const string Grade = "Grade";

        /// <remarks />
        public const string GradeDataType = "GradeDataType";

        /// <remarks />
        public const string HardwareConditionType = "HardwareConditionType";

        /// <remarks />
        public const string IDDataType = "IDDataType";

        /// <remarks />
        public const string IndexRangeDataType = "IndexRangeDataType";

        /// <remarks />
        public const string Indices = "Indices";

        /// <remarks />
        public const string InstanceIdDataType = "InstanceIdDataType";

        /// <remarks />
        public const string InterfaceStateTypeEnum = "InterfaceStateTypeEnum";

        /// <remarks />
        public const string ItemId = "ItemId";

        /// <remarks />
        public const string ItemIdDataType = "ItemIdDataType";

        /// <remarks />
        public const string ItemLife = "ItemLife";

        /// <remarks />
        public const string ItemSourceDataType = "ItemSourceDataType";

        /// <remarks />
        public const string LastChangeTimestamp = "LastChangeTimestamp";

        /// <remarks />
        public const string LifeType = "LifeType";

        /// <remarks />
        public const string LimitState = "LimitState";

        /// <remarks />
        public const string Linear_ForceConditionType = "Linear_ForceConditionType";

        /// <remarks />
        public const string LinearAxesX = "LinearAxesX";

        /// <remarks />
        public const string LinearAxesY = "LinearAxesY";

        /// <remarks />
        public const string LinearAxesZ = "LinearAxesZ";

        /// <remarks />
        public const string LinearForceType = "LinearForceType";

        /// <remarks />
        public const string LineType = "LineType";

        /// <remarks />
        public const string LoadConditionType = "LoadConditionType";

        /// <remarks />
        public const string LoadType = "LoadType";

        /// <remarks />
        public const string Location = "Location";

        /// <remarks />
        public const string LocationSizeDataType = "LocationSizeDataType";

        /// <remarks />
        public const string LocationsTypeEnum = "LocationsTypeEnum";

        /// <remarks />
        public const string LocationType = "LocationType";

        /// <remarks />
        public const string LocationValueDataType = "LocationValueDataType";

        /// <remarks />
        public const string Locus = "Locus";

        /// <remarks />
        public const string LocusDataType = "LocusDataType";

        /// <remarks />
        public const string Logic_ProgramConditionType = "Logic_ProgramConditionType";

        /// <remarks />
        public const string Manufacturer = "Manufacturer";

        /// <remarks />
        public const string Manufacturers = "Manufacturers";

        /// <remarks />
        public const string ManufacturersDataType = "ManufacturersDataType";

        /// <remarks />
        public const string MassConditionType = "MassConditionType";

        /// <remarks />
        public const string MassType = "MassType";

        /// <remarks />
        public const string MassValueDataType = "MassValueDataType";

        /// <remarks />
        public const string Maximum = "Maximum";

        /// <remarks />
        public const string MaximumCount = "MaximumCount";

        /// <remarks />
        public const string MaximumCountDataType = "MaximumCountDataType";

        /// <remarks />
        public const string MaximumDataType = "MaximumDataType";

        /// <remarks />
        public const string Measurements = "Measurements";

        /// <remarks />
        public const string MeasurementType = "MeasurementType";

        /// <remarks />
        public const string MeasurementValueDataType = "MeasurementValueDataType";

        /// <remarks />
        public const string MessageType = "MessageType";

        /// <remarks />
        public const string Minimum = "Minimum";

        /// <remarks />
        public const string MinimumDataType = "MinimumDataType";

        /// <remarks />
        public const string Model = "Model";

        /// <remarks />
        public const string ModelDataType = "ModelDataType";

        /// <remarks />
        public const string Motion_ProgramConditionType = "Motion_ProgramConditionType";

        /// <remarks />
        public const string MTActuatorType = "MTActuatorType";

        /// <remarks />
        public const string MTAxesType = "MTAxesType";

        /// <remarks />
        public const string MTComponentType = "MTComponentType";

        /// <remarks />
        public const string MTConditionType = "MTConditionType";

        /// <remarks />
        public const string MTConnectVersion = "MTConnectVersion";

        /// <remarks />
        public const string MTControllerType = "MTControllerType";

        /// <remarks />
        public const string MTCurrentState = "MTCurrentState";

        /// <remarks />
        public const string MTDevices = "MTDevices";

        /// <remarks />
        public const string MTDevicesType = "MTDevicesType";

        /// <remarks />
        public const string MTDeviceType = "MTDeviceType";

        /// <remarks />
        public const string MTDoorType = "MTDoorType";

        /// <remarks />
        public const string MTEventDataItemType = "MTEventDataItemType";

        /// <remarks />
        public const string MTSampleDataItemType = "MTSampleDataItemType";

        /// <remarks />
        public const string MyOPCUAServer_BinarySchema = "MyOPCUAServer";

        /// <remarks />
        public const string MyOPCUAServer_XmlSchema = "MyOPCUAServer";

        /// <remarks />
        public const string NameDataType = "NameDataType";

        /// <remarks />
        public const string NativeCode = "NativeCode";

        /// <remarks />
        public const string NativeCodeDataType = "NativeCodeDataType";

        /// <remarks />
        public const string NativeNotifcationCodeDataType = "NativeNotifcationCodeDataType";

        /// <remarks />
        public const string NativeScale = "NativeScale";

        /// <remarks />
        public const string NativeScaleDataType = "NativeScaleDataType";

        /// <remarks />
        public const string NativeSeverity = "NativeSeverity";

        /// <remarks />
        public const string NativeSeverityDataType = "NativeSeverityDataType";

        /// <remarks />
        public const string NativeUnits = "NativeUnits";

        /// <remarks />
        public const string NegativeOverlap = "NegativeOverlap";

        /// <remarks />
        public const string NextCalibrationDate = "NextCalibrationDate";

        /// <remarks />
        public const string NextCalibrationDateDataType = "NextCalibrationDateDataType";

        /// <remarks />
        public const string Nominal = "Nominal";

        /// <remarks />
        public const string NominalDataType = "NominalDataType";

        /// <remarks />
        public const string NotificationCodeTypeEnum = "NotificationCodeTypeEnum";

        /// <remarks />
        public const string NotificationDescriptionDataType = "NotificationDescriptionDataType";

        /// <remarks />
        public const string OccurrenceTimeDataType = "OccurrenceTimeDataType";

        /// <remarks />
        public const string OPCUAMappingDate = "OPCUAMappingDate";

        /// <remarks />
        public const string OPCUAVersion = "OPCUAVersion";

        /// <remarks />
        public const string OverlapDataType = "OverlapDataType";

        /// <remarks />
        public const string PalletIdType = "PalletIdType";

        /// <remarks />
        public const string PartCountType = "PartCountType";

        /// <remarks />
        public const string PartIdType = "PartIdType";

        /// <remarks />
        public const string Path_FeedrateConditionType = "Path_FeedrateConditionType";

        /// <remarks />
        public const string Path_PositionConditionType = "Path_PositionConditionType";

        /// <remarks />
        public const string PathFeedrateType = "PathFeedrateType";

        /// <remarks />
        public const string PathModeType = "PathModeType";

        /// <remarks />
        public const string PathModeTypeEnum = "PathModeTypeEnum";

        /// <remarks />
        public const string PathPositionType = "PathPositionType";

        /// <remarks />
        public const string PHConditionType = "PHConditionType";

        /// <remarks />
        public const string PHType = "PHType";

        /// <remarks />
        public const string PositionConditionType = "PositionConditionType";

        /// <remarks />
        public const string PositionType = "PositionType";

        /// <remarks />
        public const string PositiveOverlap = "PositiveOverlap";

        /// <remarks />
        public const string Power_FactorConditionType = "Power_FactorConditionType";

        /// <remarks />
        public const string PowerFactorType = "PowerFactorType";

        /// <remarks />
        public const string PowerStateType = "PowerStateType";

        /// <remarks />
        public const string PowerStateTypeEnum = "PowerStateTypeEnum";

        /// <remarks />
        public const string PressureConditionType = "PressureConditionType";

        /// <remarks />
        public const string PressureType = "PressureType";

        /// <remarks />
        public const string ProgramFeedRate = "ProgramFeedRate";

        /// <remarks />
        public const string ProgramFeedRateType = "ProgramFeedRateType";

        /// <remarks />
        public const string ProgramSpindleSpeed = "ProgramSpindleSpeed";

        /// <remarks />
        public const string ProgramSpindleSpeedType = "ProgramSpindleSpeedType";

        /// <remarks />
        public const string ProgramToolNumber = "ProgramToolNumber";

        /// <remarks />
        public const string ProgramToolNumberDataType = "ProgramToolNumberDataType";

        /// <remarks />
        public const string ProgramType = "ProgramType";

        /// <remarks />
        public const string QualifierTypeEnum = "QualifierTypeEnum";

        /// <remarks />
        public const string RateDataType = "RateDataType";

        /// <remarks />
        public const string ReconditionCount = "ReconditionCount";

        /// <remarks />
        public const string ReconditionCountType = "ReconditionCountType";

        /// <remarks />
        public const string ReconditionCountValueDataType = "ReconditionCountValueDataType";

        /// <remarks />
        public const string ResistanceConditionType = "ResistanceConditionType";

        /// <remarks />
        public const string ResistanceType = "ResistanceType";

        /// <remarks />
        public const string Rotary_VelocityConditionType = "Rotary_VelocityConditionType";

        /// <remarks />
        public const string RotaryModeType = "RotaryModeType";

        /// <remarks />
        public const string RotaryModeTypeEnum = "RotaryModeTypeEnum";

        /// <remarks />
        public const string RotationalVelocityType = "RotationalVelocityType";

        /// <remarks />
        public const string RotoryAxesA = "RotoryAxesA";

        /// <remarks />
        public const string RotoryAxesB = "RotoryAxesB";

        /// <remarks />
        public const string RotoryAxesC = "RotoryAxesC";

        /// <remarks />
        public const string SampleInterval = "SampleInterval";

        /// <remarks />
        public const string SampleRateDataType = "SampleRateDataType";

        /// <remarks />
        public const string SenderDataType = "SenderDataType";

        /// <remarks />
        public const string SensorConfigurationType = "SensorConfigurationType";

        /// <remarks />
        public const string SensorType = "SensorType";

        /// <remarks />
        public const string SequenceDataType = "SequenceDataType";

        /// <remarks />
        public const string SerialNumber = "SerialNumber";

        /// <remarks />
        public const string SerialNumberDataType = "SerialNumberDataType";

        /// <remarks />
        public const string SeverityTypeEnum = "SeverityTypeEnum";

        /// <remarks />
        public const string SignificantDigits = "SignificantDigits";

        /// <remarks />
        public const string SignificantDigitsValueDataType = "SignificantDigitsValueDataType";

        /// <remarks />
        public const string Sound_LevelConditionType = "Sound_LevelConditionType";

        /// <remarks />
        public const string SoundPressureType = "SoundPressureType";

        /// <remarks />
        public const string SourceType = "SourceType";

        /// <remarks />
        public const string SpeedDataType = "SpeedDataType";

        /// <remarks />
        public const string Station = "Station";

        /// <remarks />
        public const string StationDataType = "StationDataType";

        /// <remarks />
        public const string Status = "Status";

        /// <remarks />
        public const string StrainConditionType = "StrainConditionType";

        /// <remarks />
        public const string StrainType = "StrainType";

        /// <remarks />
        public const string SystemConditionType = "SystemConditionType";

        /// <remarks />
        public const string TemperatureConditionType = "TemperatureConditionType";

        /// <remarks />
        public const string TemperatureType = "TemperatureType";

        /// <remarks />
        public const string TestIndicatorDataType = "TestIndicatorDataType";

        /// <remarks />
        public const string TiltConditionType = "TiltConditionType";

        /// <remarks />
        public const string TiltType = "TiltType";

        /// <remarks />
        public const string ToolAssetIdType = "ToolAssetIdType";

        /// <remarks />
        public const string ToolEventValueDataType = "ToolEventValueDataType";

        /// <remarks />
        public const string ToolGroup = "ToolGroup";

        /// <remarks />
        public const string ToolGroupDataType = "ToolGroupDataType";

        /// <remarks />
        public const string ToolId = "ToolId";

        /// <remarks />
        public const string ToolIdDataType = "ToolIdDataType";

        /// <remarks />
        public const string ToolLife = "ToolLife";

        /// <remarks />
        public const string ToolLifeDirectionTypeEnum = "ToolLifeDirectionTypeEnum";

        /// <remarks />
        public const string ToolLifeTypeEnum = "ToolLifeTypeEnum";

        /// <remarks />
        public const string ToolLifeValueDataType = "ToolLifeValueDataType";

        /// <remarks />
        public const string ToolNumberType = "ToolNumberType";

        /// <remarks />
        public const string TorqueConditionType = "TorqueConditionType";

        /// <remarks />
        public const string TorqueType = "TorqueType";

        /// <remarks />
        public const string Type = "Type";

        /// <remarks />
        public const string Units = "Units";

        /// <remarks />
        public const string UnitsExtDataType = "UnitsExtDataType";

        /// <remarks />
        public const string VelocityConditionType = "VelocityConditionType";

        /// <remarks />
        public const string VelocityType = "VelocityType";

        /// <remarks />
        public const string VersionDataType = "VersionDataType";

        /// <remarks />
        public const string VibrationValueDataType = "VibrationValueDataType";

        /// <remarks />
        public const string ViscosityConditionType = "ViscosityConditionType";

        /// <remarks />
        public const string ViscosityType = "ViscosityType";

        /// <remarks />
        public const string Volt_AmperageConditionType = "Volt_AmperageConditionType";

        /// <remarks />
        public const string VoltageConditionType = "VoltageConditionType";

        /// <remarks />
        public const string VoltageType = "VoltageType";

        /// <remarks />
        public const string VoltAmperageReactiveConditionType = "VoltAmperageReactiveConditionType";

        /// <remarks />
        public const string VoltAmpereReactiveType = "VoltAmpereReactiveType";

        /// <remarks />
        public const string VoltAmpereType = "VoltAmpereType";

        /// <remarks />
        public const string WarningLevel = "WarningLevel";

        /// <remarks />
        public const string WattageConditionType = "WattageConditionType";

        /// <remarks />
        public const string WattageType = "WattageType";

        /// <remarks />
        public const string WorkHoldingIdType = "WorkHoldingIdType";
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