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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace MyOPCUAServer
{
    #region MTDevicesState Class
    #if (!OPCUA_EXCLUDE_MTDevicesState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTDevicesState : FolderState
    {
        #region Constructors
        /// <remarks />
        public MTDevicesState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MTDevicesType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MTConnectVersion != null)
            {
                MTConnectVersion.Initialize(context, MTConnectVersion_InitializationString);
            }

            if (OPCUAMappingDate != null)
            {
                OPCUAMappingDate.Initialize(context, OPCUAMappingDate_InitializationString);
            }

            if (OPCUAVersion != null)
            {
                OPCUAVersion.Initialize(context, OPCUAVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string MTConnectVersion_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABAA" +
           "AABNVENvbm5lY3RWZXJzaW9uAQECAAAvAD8CAAAAAAz/////AQH/////AAAAAA==";

        private const string OPCUAMappingDate_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABAA" +
           "AABPUENVQU1hcHBpbmdEYXRlAQEDAAAvAD8DAAAAAA3/////AQH/////AAAAAA==";

        private const string OPCUAVersion_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAwA" +
           "AABPUENVQVZlcnNpb24BAQQAAC8APwQAAAAADP////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABUA" +
           "AABNVERldmljZXNUeXBlSW5zdGFuY2UBAQEAAQEBAAEAAAD/////AwAAABVgiQoCAAAAAQAQAAAATVRD" +
           "b25uZWN0VmVyc2lvbgEBAgAALwA/AgAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAE9QQ1VB" +
           "TWFwcGluZ0RhdGUBAQMAAC8APwMAAAAADf////8BAf////8AAAAAFWCJCgIAAAABAAwAAABPUENVQVZl" +
           "cnNpb24BAQQAAC8APwQAAAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<string> MTConnectVersion
        {
            get
            {
                return m_mTConnectVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mTConnectVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mTConnectVersion = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<DateTime> OPCUAMappingDate
        {
            get
            {
                return m_oPCUAMappingDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_oPCUAMappingDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_oPCUAMappingDate = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> OPCUAVersion
        {
            get
            {
                return m_oPCUAVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_oPCUAVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_oPCUAVersion = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mTConnectVersion != null)
            {
                children.Add(m_mTConnectVersion);
            }

            if (m_oPCUAMappingDate != null)
            {
                children.Add(m_oPCUAMappingDate);
            }

            if (m_oPCUAVersion != null)
            {
                children.Add(m_oPCUAVersion);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.MTConnectVersion:
                {
                    if (createOrReplace)
                    {
                        if (MTConnectVersion == null)
                        {
                            if (replacement == null)
                            {
                                MTConnectVersion = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                MTConnectVersion = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = MTConnectVersion;
                    break;
                }

                case MyOPCUAServer.BrowseNames.OPCUAMappingDate:
                {
                    if (createOrReplace)
                    {
                        if (OPCUAMappingDate == null)
                        {
                            if (replacement == null)
                            {
                                OPCUAMappingDate = new BaseDataVariableState<DateTime>(this);
                            }
                            else
                            {
                                OPCUAMappingDate = (BaseDataVariableState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = OPCUAMappingDate;
                    break;
                }

                case MyOPCUAServer.BrowseNames.OPCUAVersion:
                {
                    if (createOrReplace)
                    {
                        if (OPCUAVersion == null)
                        {
                            if (replacement == null)
                            {
                                OPCUAVersion = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                OPCUAVersion = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = OPCUAVersion;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_mTConnectVersion;
        private BaseDataVariableState<DateTime> m_oPCUAMappingDate;
        private BaseDataVariableState<string> m_oPCUAVersion;
        #endregion
    }
    #endif
    #endregion

    #region MTDeviceState Class
    #if (!OPCUA_EXCLUDE_MTDeviceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTDeviceState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public MTDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MTDeviceType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Configuration != null)
            {
                Configuration.Initialize(context, Configuration_InitializationString);
            }

            if (SampleInterval != null)
            {
                SampleInterval.Initialize(context, SampleInterval_InitializationString);
            }

            if (Conditions != null)
            {
                Conditions.Initialize(context, Conditions_InitializationString);
            }
        }

        #region Initialization String
        private const string Configuration_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAA0A" +
           "AABDb25maWd1cmF0aW9uAQEPAAAuAEQPAAAAAAz/////AQH/////AAAAAA==";

        private const string SampleInterval_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAA4A" +
           "AABTYW1wbGVJbnRlcnZhbAEBEAAALgBEEAAAAAEAIgH/////AQH/////AAAAAA==";

        private const string Conditions_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCACgEAAAABAAoA" +
           "AABDb25kaXRpb25zAQETAAAvAD0TAAAA/////wAAAAA=";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABQA" +
           "AABNVERldmljZVR5cGVJbnN0YW5jZQEBCQABAQkACQAAAP////8IAAAAFWCJCgIAAAABAAwAAABBdmFp" +
           "bGFiaWxpdHkBAQoAAC8BAD0JCgAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0" +
           "dXJlcgEBDQAALgBEDQAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJlcgEB" +
           "DgAALgBEDgAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAENvbmZpZ3VyYXRpb24BAQ8AAC4A" +
           "RA8AAAAADP////8BAf////8AAAAAFWCJCgIAAAABAA4AAABTYW1wbGVJbnRlcnZhbAEBEAAALgBEEAAA" +
           "AAEAIgH/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1zAQERAAAvAD0RAAAA/////wAA" +
           "AAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBARIAAC8APRIAAAD/////AAAAAARggAoBAAAAAQAKAAAA" +
           "Q29uZGl0aW9ucwEBEwAALwA9EwAAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DataItemState<string> Availability
        {
            get
            {
                return m_availability;
            }

            set
            {
                if (!Object.ReferenceEquals(m_availability, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_availability = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Manufacturer
        {
            get
            {
                return m_manufacturer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Configuration
        {
            get
            {
                return m_configuration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configuration = value;
            }
        }

        /// <remarks />
        public PropertyState<double> SampleInterval
        {
            get
            {
                return m_sampleInterval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleInterval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleInterval = value;
            }
        }

        /// <remarks />
        public FolderState DataItems
        {
            get
            {
                return m_dataItems;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dataItems, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dataItems = value;
            }
        }

        /// <remarks />
        public FolderState Components
        {
            get
            {
                return m_components;
            }

            set
            {
                if (!Object.ReferenceEquals(m_components, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_components = value;
            }
        }

        /// <remarks />
        public FolderState Conditions
        {
            get
            {
                return m_conditions;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conditions, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conditions = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_availability != null)
            {
                children.Add(m_availability);
            }

            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_sampleInterval != null)
            {
                children.Add(m_sampleInterval);
            }

            if (m_dataItems != null)
            {
                children.Add(m_dataItems);
            }

            if (m_components != null)
            {
                children.Add(m_components);
            }

            if (m_conditions != null)
            {
                children.Add(m_conditions);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.Availability:
                {
                    if (createOrReplace)
                    {
                        if (Availability == null)
                        {
                            if (replacement == null)
                            {
                                Availability = new DataItemState<string>(this);
                            }
                            else
                            {
                                Availability = (DataItemState<string>)replacement;
                            }
                        }
                    }

                    instance = Availability;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<string>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case MyOPCUAServer.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Configuration:
                {
                    if (createOrReplace)
                    {
                        if (Configuration == null)
                        {
                            if (replacement == null)
                            {
                                Configuration = new PropertyState<string>(this);
                            }
                            else
                            {
                                Configuration = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Configuration;
                    break;
                }

                case MyOPCUAServer.BrowseNames.SampleInterval:
                {
                    if (createOrReplace)
                    {
                        if (SampleInterval == null)
                        {
                            if (replacement == null)
                            {
                                SampleInterval = new PropertyState<double>(this);
                            }
                            else
                            {
                                SampleInterval = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleInterval;
                    break;
                }

                case MyOPCUAServer.BrowseNames.DataItems:
                {
                    if (createOrReplace)
                    {
                        if (DataItems == null)
                        {
                            if (replacement == null)
                            {
                                DataItems = new FolderState(this);
                            }
                            else
                            {
                                DataItems = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DataItems;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Components:
                {
                    if (createOrReplace)
                    {
                        if (Components == null)
                        {
                            if (replacement == null)
                            {
                                Components = new FolderState(this);
                            }
                            else
                            {
                                Components = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Components;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Conditions:
                {
                    if (createOrReplace)
                    {
                        if (Conditions == null)
                        {
                            if (replacement == null)
                            {
                                Conditions = new FolderState(this);
                            }
                            else
                            {
                                Conditions = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Conditions;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private DataItemState<string> m_availability;
        private PropertyState<string> m_manufacturer;
        private PropertyState<string> m_serialNumber;
        private PropertyState<string> m_configuration;
        private PropertyState<double> m_sampleInterval;
        private FolderState m_dataItems;
        private FolderState m_components;
        private FolderState m_conditions;
        #endregion
    }
    #endif
    #endregion

    #region MTComponentState Class
    #if (!OPCUA_EXCLUDE_MTComponentState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTComponentState : MTDeviceState
    {
        #region Constructors
        /// <remarks />
        public MTComponentState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MTComponentType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Model != null)
            {
                Model.Initialize(context, Model_InitializationString);
            }

            if (Station != null)
            {
                Station.Initialize(context, Station_InitializationString);
            }
        }

        #region Initialization String
        private const string Model_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAUA" +
           "AABNb2RlbAEBHwAALgBEHwAAAAAM/////wEB/////wAAAAA=";

        private const string Station_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAcA" +
           "AABTdGF0aW9uAQEgAAAuAEQgAAAAAQAiAf////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABcA" +
           "AABNVENvbXBvbmVudFR5cGVJbnN0YW5jZQEBFAABARQAFAAAAP////8HAAAAFWCJCgIAAAABAAwAAABB" +
           "dmFpbGFiaWxpdHkBARUAAC8BAD0JFQAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1hbnVm" +
           "YWN0dXJlcgEBGAAALgBEGAAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNlcmlhbE51bWJl" +
           "cgEBGQAALgBEGQAAAAAM/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAERhdGFJdGVtcwEBHAAALwA9" +
           "HAAAAP////8AAAAABGCACgEAAAABAAoAAABDb21wb25lbnRzAQEdAAAvAD0dAAAA/////wAAAAAVYIkK" +
           "AgAAAAEABQAAAE1vZGVsAQEfAAAuAEQfAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAHAAAAU3Rh" +
           "dGlvbgEBIAAALgBEIAAAAAEAIgH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Model
        {
            get
            {
                return m_model;
            }

            set
            {
                if (!Object.ReferenceEquals(m_model, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_model = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Station
        {
            get
            {
                return m_station;
            }

            set
            {
                if (!Object.ReferenceEquals(m_station, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_station = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_model != null)
            {
                children.Add(m_model);
            }

            if (m_station != null)
            {
                children.Add(m_station);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.Model:
                {
                    if (createOrReplace)
                    {
                        if (Model == null)
                        {
                            if (replacement == null)
                            {
                                Model = new PropertyState<string>(this);
                            }
                            else
                            {
                                Model = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Model;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Station:
                {
                    if (createOrReplace)
                    {
                        if (Station == null)
                        {
                            if (replacement == null)
                            {
                                Station = new PropertyState<double>(this);
                            }
                            else
                            {
                                Station = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Station;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_model;
        private PropertyState<double> m_station;
        #endregion
    }
    #endif
    #endregion

    #region MTAxesState Class
    #if (!OPCUA_EXCLUDE_MTAxesState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTAxesState : MTDeviceState
    {
        #region Constructors
        /// <remarks />
        public MTAxesState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MTAxesType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (LinearAxesX != null)
            {
                LinearAxesX.Initialize(context, LinearAxesX_InitializationString);
            }

            if (LinearAxesY != null)
            {
                LinearAxesY.Initialize(context, LinearAxesY_InitializationString);
            }

            if (LinearAxesZ != null)
            {
                LinearAxesZ.Initialize(context, LinearAxesZ_InitializationString);
            }

            if (RotoryAxesA != null)
            {
                RotoryAxesA.Initialize(context, RotoryAxesA_InitializationString);
            }

            if (RotoryAxesB != null)
            {
                RotoryAxesB.Initialize(context, RotoryAxesB_InitializationString);
            }

            if (RotoryAxesC != null)
            {
                RotoryAxesC.Initialize(context, RotoryAxesC_InitializationString);
            }
        }

        #region Initialization String
        private const string LinearAxesX_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABMaW5lYXJBeGVzWAEBLAAALgBELAAAAAAM/////wEB/////wAAAAA=";

        private const string LinearAxesY_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABMaW5lYXJBeGVzWQEBLQAALgBELQAAAAAM/////wEB/////wAAAAA=";

        private const string LinearAxesZ_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABMaW5lYXJBeGVzWgEBLgAALgBELgAAAAAM/////wEB/////wAAAAA=";

        private const string RotoryAxesA_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABSb3RvcnlBeGVzQQEBLwAALgBELwAAAAAM/////wEB/////wAAAAA=";

        private const string RotoryAxesB_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABSb3RvcnlBeGVzQgEBMAAALgBEMAAAAAAM/////wEB/////wAAAAA=";

        private const string RotoryAxesC_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABSb3RvcnlBeGVzQwEBMQAALgBEMQAAAAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABIA" +
           "AABNVEF4ZXNUeXBlSW5zdGFuY2UBASEAAQEhACEAAAD/////CwAAABVgiQoCAAAAAQAMAAAAQXZhaWxh" +
           "YmlsaXR5AQEiAAAvAQA9CSIAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVy" +
           "ZXIBASUAAC4ARCUAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXIBASYA" +
           "AC4ARCYAAAAADP////8BAf////8AAAAABGCACgEAAAABAAkAAABEYXRhSXRlbXMBASkAAC8APSkAAAD/" +
           "////AAAAAARggAoBAAAAAQAKAAAAQ29tcG9uZW50cwEBKgAALwA9KgAAAP////8AAAAAFWCJCgIAAAAB" +
           "AAsAAABMaW5lYXJBeGVzWAEBLAAALgBELAAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAExp" +
           "bmVhckF4ZXNZAQEtAAAuAEQtAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAATGluZWFyQXhl" +
           "c1oBAS4AAC4ARC4AAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABSb3RvcnlBeGVzQQEBLwAA" +
           "LgBELwAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAFJvdG9yeUF4ZXNCAQEwAAAuAEQwAAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAUm90b3J5QXhlc0MBATEAAC4ARDEAAAAADP////8B" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> LinearAxesX
        {
            get
            {
                return m_linearAxesX;
            }

            set
            {
                if (!Object.ReferenceEquals(m_linearAxesX, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_linearAxesX = value;
            }
        }

        /// <remarks />
        public PropertyState<string> LinearAxesY
        {
            get
            {
                return m_linearAxesY;
            }

            set
            {
                if (!Object.ReferenceEquals(m_linearAxesY, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_linearAxesY = value;
            }
        }

        /// <remarks />
        public PropertyState<string> LinearAxesZ
        {
            get
            {
                return m_linearAxesZ;
            }

            set
            {
                if (!Object.ReferenceEquals(m_linearAxesZ, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_linearAxesZ = value;
            }
        }

        /// <remarks />
        public PropertyState<string> RotoryAxesA
        {
            get
            {
                return m_rotoryAxesA;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rotoryAxesA, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rotoryAxesA = value;
            }
        }

        /// <remarks />
        public PropertyState<string> RotoryAxesB
        {
            get
            {
                return m_rotoryAxesB;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rotoryAxesB, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rotoryAxesB = value;
            }
        }

        /// <remarks />
        public PropertyState<string> RotoryAxesC
        {
            get
            {
                return m_rotoryAxesC;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rotoryAxesC, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rotoryAxesC = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_linearAxesX != null)
            {
                children.Add(m_linearAxesX);
            }

            if (m_linearAxesY != null)
            {
                children.Add(m_linearAxesY);
            }

            if (m_linearAxesZ != null)
            {
                children.Add(m_linearAxesZ);
            }

            if (m_rotoryAxesA != null)
            {
                children.Add(m_rotoryAxesA);
            }

            if (m_rotoryAxesB != null)
            {
                children.Add(m_rotoryAxesB);
            }

            if (m_rotoryAxesC != null)
            {
                children.Add(m_rotoryAxesC);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.LinearAxesX:
                {
                    if (createOrReplace)
                    {
                        if (LinearAxesX == null)
                        {
                            if (replacement == null)
                            {
                                LinearAxesX = new PropertyState<string>(this);
                            }
                            else
                            {
                                LinearAxesX = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LinearAxesX;
                    break;
                }

                case MyOPCUAServer.BrowseNames.LinearAxesY:
                {
                    if (createOrReplace)
                    {
                        if (LinearAxesY == null)
                        {
                            if (replacement == null)
                            {
                                LinearAxesY = new PropertyState<string>(this);
                            }
                            else
                            {
                                LinearAxesY = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LinearAxesY;
                    break;
                }

                case MyOPCUAServer.BrowseNames.LinearAxesZ:
                {
                    if (createOrReplace)
                    {
                        if (LinearAxesZ == null)
                        {
                            if (replacement == null)
                            {
                                LinearAxesZ = new PropertyState<string>(this);
                            }
                            else
                            {
                                LinearAxesZ = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LinearAxesZ;
                    break;
                }

                case MyOPCUAServer.BrowseNames.RotoryAxesA:
                {
                    if (createOrReplace)
                    {
                        if (RotoryAxesA == null)
                        {
                            if (replacement == null)
                            {
                                RotoryAxesA = new PropertyState<string>(this);
                            }
                            else
                            {
                                RotoryAxesA = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = RotoryAxesA;
                    break;
                }

                case MyOPCUAServer.BrowseNames.RotoryAxesB:
                {
                    if (createOrReplace)
                    {
                        if (RotoryAxesB == null)
                        {
                            if (replacement == null)
                            {
                                RotoryAxesB = new PropertyState<string>(this);
                            }
                            else
                            {
                                RotoryAxesB = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = RotoryAxesB;
                    break;
                }

                case MyOPCUAServer.BrowseNames.RotoryAxesC:
                {
                    if (createOrReplace)
                    {
                        if (RotoryAxesC == null)
                        {
                            if (replacement == null)
                            {
                                RotoryAxesC = new PropertyState<string>(this);
                            }
                            else
                            {
                                RotoryAxesC = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = RotoryAxesC;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_linearAxesX;
        private PropertyState<string> m_linearAxesY;
        private PropertyState<string> m_linearAxesZ;
        private PropertyState<string> m_rotoryAxesA;
        private PropertyState<string> m_rotoryAxesB;
        private PropertyState<string> m_rotoryAxesC;
        #endregion
    }
    #endif
    #endregion

    #region MTControllerState Class
    #if (!OPCUA_EXCLUDE_MTControllerState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTControllerState : MTDeviceState
    {
        #region Constructors
        /// <remarks />
        public MTControllerState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MTControllerType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABgA" +
           "AABNVENvbnRyb2xsZXJUeXBlSW5zdGFuY2UBATIAAQEyADIAAAD/////BQAAABVgiQoCAAAAAQAMAAAA" +
           "QXZhaWxhYmlsaXR5AQEzAAAvAQA9CTMAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51" +
           "ZmFjdHVyZXIBATYAAC4ARDYAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1i" +
           "ZXIBATcAAC4ARDcAAAAADP////8BAf////8AAAAABGCACgEAAAABAAkAAABEYXRhSXRlbXMBAToAAC8A" +
           "PToAAAD/////AAAAAARggAoBAAAAAQAKAAAAQ29tcG9uZW50cwEBOwAALwA9OwAAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MTDoorState Class
    #if (!OPCUA_EXCLUDE_MTDoorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTDoorState : MTDeviceState
    {
        #region Constructors
        /// <remarks />
        public MTDoorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MTDoorType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (DoorState != null)
            {
                DoorState.Initialize(context, DoorState_InitializationString);
            }
        }

        #region Initialization String
        private const string DoorState_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAkA" +
           "AABEb29yU3RhdGUBAUgAAC4AREgAAAAADP////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABIA" +
           "AABNVERvb3JUeXBlSW5zdGFuY2UBAT0AAQE9AD0AAAD/////BgAAABVgiQoCAAAAAQAMAAAAQXZhaWxh" +
           "YmlsaXR5AQE+AAAvAQA9CT4AAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVy" +
           "ZXIBAUEAAC4AREEAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXIBAUIA" +
           "AC4AREIAAAAADP////8BAf////8AAAAABGCACgEAAAABAAkAAABEYXRhSXRlbXMBAUUAAC8APUUAAAD/" +
           "////AAAAAARggAoBAAAAAQAKAAAAQ29tcG9uZW50cwEBRgAALwA9RgAAAP////8AAAAAFWCJCgIAAAAB" +
           "AAkAAABEb29yU3RhdGUBAUgAAC4AREgAAAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> DoorState
        {
            get
            {
                return m_doorState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_doorState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_doorState = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_doorState != null)
            {
                children.Add(m_doorState);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.DoorState:
                {
                    if (createOrReplace)
                    {
                        if (DoorState == null)
                        {
                            if (replacement == null)
                            {
                                DoorState = new PropertyState<string>(this);
                            }
                            else
                            {
                                DoorState = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DoorState;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_doorState;
        #endregion
    }
    #endif
    #endregion

    #region MTActuatorState Class
    #if (!OPCUA_EXCLUDE_MTActuatorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTActuatorState : MTDeviceState
    {
        #region Constructors
        /// <remarks />
        public MTActuatorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MTActuatorType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (LinearAxesX != null)
            {
                LinearAxesX.Initialize(context, LinearAxesX_InitializationString);
            }
        }

        #region Initialization String
        private const string LinearAxesX_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABMaW5lYXJBeGVzWAEBVAAALgBEVAAAAAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABYA" +
           "AABNVEFjdHVhdG9yVHlwZUluc3RhbmNlAQFJAAEBSQBJAAAA/////wYAAAAVYIkKAgAAAAEADAAAAEF2" +
           "YWlsYWJpbGl0eQEBSgAALwEAPQlKAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFudWZh" +
           "Y3R1cmVyAQFNAAAuAERNAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVy" +
           "AQFOAAAuAEROAAAAAAz/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1zAQFRAAAvAD1R" +
           "AAAA/////wAAAAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBAVIAAC8APVIAAAD/////AAAAABVgiQoC" +
           "AAAAAQALAAAATGluZWFyQXhlc1gBAVQAAC4ARFQAAAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> LinearAxesX
        {
            get
            {
                return m_linearAxesX;
            }

            set
            {
                if (!Object.ReferenceEquals(m_linearAxesX, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_linearAxesX = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_linearAxesX != null)
            {
                children.Add(m_linearAxesX);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.LinearAxesX:
                {
                    if (createOrReplace)
                    {
                        if (LinearAxesX == null)
                        {
                            if (replacement == null)
                            {
                                LinearAxesX = new PropertyState<string>(this);
                            }
                            else
                            {
                                LinearAxesX = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LinearAxesX;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_linearAxesX;
        #endregion
    }
    #endif
    #endregion

    #region MTSampleDataItemState Class
    #if (!OPCUA_EXCLUDE_MTSampleDataItemState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTSampleDataItemState : AnalogItemState
    {
        #region Constructors
        /// <remarks />
        public MTSampleDataItemState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.MTSampleDataItemType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CoordinateSystem != null)
            {
                CoordinateSystem.Initialize(context, CoordinateSystem_InitializationString);
            }

            if (NativeUnits != null)
            {
                NativeUnits.Initialize(context, NativeUnits_InitializationString);
            }

            if (NativeScale != null)
            {
                NativeScale.Initialize(context, NativeScale_InitializationString);
            }

            if (SampleInterval != null)
            {
                SampleInterval.Initialize(context, SampleInterval_InitializationString);
            }
        }

        #region Initialization String
        private const string CoordinateSystem_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABAA" +
           "AABDb29yZGluYXRlU3lzdGVtAQFbAAAuAERbAAAAAQE1Dv////8BAf////8AAAAA";

        private const string NativeUnits_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABOYXRpdmVVbml0cwEBXAAALgBEXAAAAAEAdwP/////AQH/////AAAAAA==";

        private const string NativeScale_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABOYXRpdmVTY2FsZQEBXQAALgBEXQAAAAAK/////wEB/////wAAAAA=";

        private const string SampleInterval_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAA4A" +
           "AABTYW1wbGVJbnRlcnZhbAEBXgAALgBEXgAAAAEAIgH/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCBAgIAAAABABwA" +
           "AABNVFNhbXBsZURhdGFJdGVtVHlwZUluc3RhbmNlAQFVAAEBVQBVAAAAABoBAf////8FAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQFZAAAuAERZAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABAAAABD" +
           "b29yZGluYXRlU3lzdGVtAQFbAAAuAERbAAAAAQE1Dv////8BAf////8AAAAAFWCJCgIAAAABAAsAAABO" +
           "YXRpdmVVbml0cwEBXAAALgBEXAAAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQALAAAATmF0aXZl" +
           "U2NhbGUBAV0AAC4ARF0AAAAACv////8BAf////8AAAAAFWCJCgIAAAABAA4AAABTYW1wbGVJbnRlcnZh" +
           "bAEBXgAALgBEXgAAAAEAIgH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<CoordinateSystemTypeEnum> CoordinateSystem
        {
            get
            {
                return m_coordinateSystem;
            }

            set
            {
                if (!Object.ReferenceEquals(m_coordinateSystem, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_coordinateSystem = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> NativeUnits
        {
            get
            {
                return m_nativeUnits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeUnits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeUnits = value;
            }
        }

        /// <remarks />
        public PropertyState<float> NativeScale
        {
            get
            {
                return m_nativeScale;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeScale, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeScale = value;
            }
        }

        /// <remarks />
        public PropertyState<double> SampleInterval
        {
            get
            {
                return m_sampleInterval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleInterval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleInterval = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_coordinateSystem != null)
            {
                children.Add(m_coordinateSystem);
            }

            if (m_nativeUnits != null)
            {
                children.Add(m_nativeUnits);
            }

            if (m_nativeScale != null)
            {
                children.Add(m_nativeScale);
            }

            if (m_sampleInterval != null)
            {
                children.Add(m_sampleInterval);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.CoordinateSystem:
                {
                    if (createOrReplace)
                    {
                        if (CoordinateSystem == null)
                        {
                            if (replacement == null)
                            {
                                CoordinateSystem = new PropertyState<CoordinateSystemTypeEnum>(this);
                            }
                            else
                            {
                                CoordinateSystem = (PropertyState<CoordinateSystemTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CoordinateSystem;
                    break;
                }

                case MyOPCUAServer.BrowseNames.NativeUnits:
                {
                    if (createOrReplace)
                    {
                        if (NativeUnits == null)
                        {
                            if (replacement == null)
                            {
                                NativeUnits = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                NativeUnits = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = NativeUnits;
                    break;
                }

                case MyOPCUAServer.BrowseNames.NativeScale:
                {
                    if (createOrReplace)
                    {
                        if (NativeScale == null)
                        {
                            if (replacement == null)
                            {
                                NativeScale = new PropertyState<float>(this);
                            }
                            else
                            {
                                NativeScale = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = NativeScale;
                    break;
                }

                case MyOPCUAServer.BrowseNames.SampleInterval:
                {
                    if (createOrReplace)
                    {
                        if (SampleInterval == null)
                        {
                            if (replacement == null)
                            {
                                SampleInterval = new PropertyState<double>(this);
                            }
                            else
                            {
                                SampleInterval = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleInterval;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<CoordinateSystemTypeEnum> m_coordinateSystem;
        private PropertyState<EUInformation> m_nativeUnits;
        private PropertyState<float> m_nativeScale;
        private PropertyState<double> m_sampleInterval;
        #endregion
    }

    #region MTSampleDataItemState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MTSampleDataItemState<T> : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public MTSampleDataItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AccelerationState Class
    #if (!OPCUA_EXCLUDE_AccelerationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccelerationState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public AccelerationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.AccelerationType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABgA" +
           "AABBY2NlbGVyYXRpb25UeXBlSW5zdGFuY2UBAV8AAQFfAF8AAAAAGv////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQFjAAAuAERjAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AccelerationState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AccelerationState<T> : AccelerationState
    {
        #region Constructors
        /// <remarks />
        public AccelerationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AccumulatedTimeState Class
    #if (!OPCUA_EXCLUDE_AccumulatedTimeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccumulatedTimeState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public AccumulatedTimeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.AccumulatedTimeType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABsA" +
           "AABBY2N1bXVsYXRlZFRpbWVUeXBlSW5zdGFuY2UBAWkAAQFpAGkAAAAAGv////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQFtAAAuAERtAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AccumulatedTimeState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AccumulatedTimeState<T> : AccumulatedTimeState
    {
        #region Constructors
        /// <remarks />
        public AccumulatedTimeState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AmperageState Class
    #if (!OPCUA_EXCLUDE_AmperageState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AmperageState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public AmperageState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.AmperageType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABQA" +
           "AABBbXBlcmFnZVR5cGVJbnN0YW5jZQEBcwABAXMAcwAAAAAa/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAXcAAC4ARHcAAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AmperageState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AmperageState<T> : AmperageState
    {
        #region Constructors
        /// <remarks />
        public AmperageState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AngleState Class
    #if (!OPCUA_EXCLUDE_AngleState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngleState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public AngleState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.AngleType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABEA" +
           "AABBbmdsZVR5cGVJbnN0YW5jZQEBfQABAX0AfQAAAAAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAYEAAC4ARIEAAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AngleState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AngleState<T> : AngleState
    {
        #region Constructors
        /// <remarks />
        public AngleState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AngularAccelerationState Class
    #if (!OPCUA_EXCLUDE_AngularAccelerationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngularAccelerationState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public AngularAccelerationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.AngularAccelerationType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABAB8A" +
           "AABBbmd1bGFyQWNjZWxlcmF0aW9uVHlwZUluc3RhbmNlAQGHAAEBhwCHAAAAABr/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBiwAALgBEiwAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AngularAccelerationState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AngularAccelerationState<T> : AngularAccelerationState
    {
        #region Constructors
        /// <remarks />
        public AngularAccelerationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AngularVelocityState Class
    #if (!OPCUA_EXCLUDE_AngularVelocityState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngularVelocityState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public AngularVelocityState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.AngularVelocityType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABsA" +
           "AABBbmd1bGFyVmVsb2NpdHlUeXBlSW5zdGFuY2UBAZEAAQGRAJEAAAAAGv////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQGVAAAuAESVAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AngularVelocityState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AngularVelocityState<T> : AngularVelocityState
    {
        #region Constructors
        /// <remarks />
        public AngularVelocityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AxisFeedrateState Class
    #if (!OPCUA_EXCLUDE_AxisFeedrateState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AxisFeedrateState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public AxisFeedrateState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.AxisFeedrateType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABgA" +
           "AABBeGlzRmVlZHJhdGVUeXBlSW5zdGFuY2UBAZsAAQGbAJsAAAAAGv////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQGfAAAuAESfAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AxisFeedrateState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AxisFeedrateState<T> : AxisFeedrateState
    {
        #region Constructors
        /// <remarks />
        public AxisFeedrateState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ConcentrationState Class
    #if (!OPCUA_EXCLUDE_ConcentrationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConcentrationState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public ConcentrationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ConcentrationType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABkA" +
           "AABDb25jZW50cmF0aW9uVHlwZUluc3RhbmNlAQGlAAEBpQClAAAAABr/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBqQAALgBEqQAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ConcentrationState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ConcentrationState<T> : ConcentrationState
    {
        #region Constructors
        /// <remarks />
        public ConcentrationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ConductivityState Class
    #if (!OPCUA_EXCLUDE_ConductivityState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConductivityState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public ConductivityState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ConductivityType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABgA" +
           "AABDb25kdWN0aXZpdHlUeXBlSW5zdGFuY2UBAa8AAQGvAK8AAAAAGv////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQGzAAAuAESzAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ConductivityState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ConductivityState<T> : ConductivityState
    {
        #region Constructors
        /// <remarks />
        public ConductivityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region DisplacementState Class
    #if (!OPCUA_EXCLUDE_DisplacementState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DisplacementState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public DisplacementState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.DisplacementType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABgA" +
           "AABEaXNwbGFjZW1lbnRUeXBlSW5zdGFuY2UBAbkAAQG5ALkAAAAAGv////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQG9AAAuAES9AAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region DisplacementState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class DisplacementState<T> : DisplacementState
    {
        #region Constructors
        /// <remarks />
        public DisplacementState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ElectricalEnergyState Class
    #if (!OPCUA_EXCLUDE_ElectricalEnergyState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ElectricalEnergyState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public ElectricalEnergyState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ElectricalEnergyType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABwA" +
           "AABFbGVjdHJpY2FsRW5lcmd5VHlwZUluc3RhbmNlAQHDAAEBwwDDAAAAABr/////AQH/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBxwAALgBExwAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ElectricalEnergyState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ElectricalEnergyState<T> : ElectricalEnergyState
    {
        #region Constructors
        /// <remarks />
        public ElectricalEnergyState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FillLevelState Class
    #if (!OPCUA_EXCLUDE_FillLevelState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FillLevelState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public FillLevelState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.FillLevelType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABUA" +
           "AABGaWxsTGV2ZWxUeXBlSW5zdGFuY2UBAc0AAQHNAM0AAAAAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQHRAAAuAETRAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region FillLevelState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class FillLevelState<T> : FillLevelState
    {
        #region Constructors
        /// <remarks />
        public FillLevelState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FlowState Class
    #if (!OPCUA_EXCLUDE_FlowState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FlowState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public FlowState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.FlowType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABAA" +
           "AABGbG93VHlwZUluc3RhbmNlAQHXAAEB1wDXAAAAABr/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEB2wAALgBE2wAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region FlowState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class FlowState<T> : FlowState
    {
        #region Constructors
        /// <remarks />
        public FlowState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FrequencyState Class
    #if (!OPCUA_EXCLUDE_FrequencyState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FrequencyState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public FrequencyState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.FrequencyType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABUA" +
           "AABGcmVxdWVuY3lUeXBlSW5zdGFuY2UBAeEAAQHhAOEAAAAAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQHlAAAuAETlAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region FrequencyState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class FrequencyState<T> : FrequencyState
    {
        #region Constructors
        /// <remarks />
        public FrequencyState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LinearForceState Class
    #if (!OPCUA_EXCLUDE_LinearForceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LinearForceState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public LinearForceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.LinearForceType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABcA" +
           "AABMaW5lYXJGb3JjZVR5cGVJbnN0YW5jZQEB6wABAesA6wAAAAAa/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAe8AAC4ARO8AAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region LinearForceState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LinearForceState<T> : LinearForceState
    {
        #region Constructors
        /// <remarks />
        public LinearForceState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LoadState Class
    #if (!OPCUA_EXCLUDE_LoadState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public LoadState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.LoadType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABAA" +
           "AABMb2FkVHlwZUluc3RhbmNlAQH1AAEB9QD1AAAAABr/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEB+QAALgBE+QAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region LoadState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LoadState<T> : LoadState
    {
        #region Constructors
        /// <remarks />
        public LoadState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region MassState Class
    #if (!OPCUA_EXCLUDE_MassState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MassState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public MassState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.MassType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABAA" +
           "AABNYXNzVHlwZUluc3RhbmNlAQH/AAEB/wD/AAAAABr/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBAwEALgBEAwEAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region MassState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MassState<T> : MassState
    {
        #region Constructors
        /// <remarks />
        public MassState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PathFeedrateState Class
    #if (!OPCUA_EXCLUDE_PathFeedrateState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PathFeedrateState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public PathFeedrateState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PathFeedrateType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABgA" +
           "AABQYXRoRmVlZHJhdGVUeXBlSW5zdGFuY2UBAQkBAQEJAQkBAAAAGv////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQENAQAuAEQNAQAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PathFeedrateState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PathFeedrateState<T> : PathFeedrateState
    {
        #region Constructors
        /// <remarks />
        public PathFeedrateState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PathPositionState Class
    #if (!OPCUA_EXCLUDE_PathPositionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PathPositionState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public PathPositionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PathPositionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABgA" +
           "AABQYXRoUG9zaXRpb25UeXBlSW5zdGFuY2UBARMBAQETARMBAAAAGv////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQEXAQAuAEQXAQAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PathPositionState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PathPositionState<T> : PathPositionState
    {
        #region Constructors
        /// <remarks />
        public PathPositionState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PHState Class
    #if (!OPCUA_EXCLUDE_PHState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PHState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public PHState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PHType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABAA4A" +
           "AABQSFR5cGVJbnN0YW5jZQEBHQEBAR0BHQEAAAAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBASEBAC4ARCEBAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PHState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PHState<T> : PHState
    {
        #region Constructors
        /// <remarks />
        public PHState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PositionState Class
    #if (!OPCUA_EXCLUDE_PositionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PositionState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public PositionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PositionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABQA" +
           "AABQb3NpdGlvblR5cGVJbnN0YW5jZQEBJwEBAScBJwEAAAAa/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBASsBAC4ARCsBAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PositionState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PositionState<T> : PositionState
    {
        #region Constructors
        /// <remarks />
        public PositionState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PowerFactorState Class
    #if (!OPCUA_EXCLUDE_PowerFactorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PowerFactorState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public PowerFactorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PowerFactorType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABcA" +
           "AABQb3dlckZhY3RvclR5cGVJbnN0YW5jZQEBMQEBATEBMQEAAAAa/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBATUBAC4ARDUBAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PowerFactorState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PowerFactorState<T> : PowerFactorState
    {
        #region Constructors
        /// <remarks />
        public PowerFactorState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PressureState Class
    #if (!OPCUA_EXCLUDE_PressureState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PressureState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public PressureState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PressureType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABQA" +
           "AABQcmVzc3VyZVR5cGVJbnN0YW5jZQEBOwEBATsBOwEAAAAa/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAT8BAC4ARD8BAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PressureState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PressureState<T> : PressureState
    {
        #region Constructors
        /// <remarks />
        public PressureState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ResistanceState Class
    #if (!OPCUA_EXCLUDE_ResistanceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResistanceState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public ResistanceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ResistanceType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABYA" +
           "AABSZXNpc3RhbmNlVHlwZUluc3RhbmNlAQFFAQEBRQFFAQAAABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBSQEALgBESQEAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ResistanceState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ResistanceState<T> : ResistanceState
    {
        #region Constructors
        /// <remarks />
        public ResistanceState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region RotationalVelocityState Class
    #if (!OPCUA_EXCLUDE_RotationalVelocityState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RotationalVelocityState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public RotationalVelocityState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.RotationalVelocityType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABAB4A" +
           "AABSb3RhdGlvbmFsVmVsb2NpdHlUeXBlSW5zdGFuY2UBAU8BAQFPAU8BAAAAGv////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQFTAQAuAERTAQAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region RotationalVelocityState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class RotationalVelocityState<T> : RotationalVelocityState
    {
        #region Constructors
        /// <remarks />
        public RotationalVelocityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region SoundPressureState Class
    #if (!OPCUA_EXCLUDE_SoundPressureState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SoundPressureState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public SoundPressureState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.SoundPressureType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABkA" +
           "AABTb3VuZFByZXNzdXJlVHlwZUluc3RhbmNlAQFZAQEBWQFZAQAAABr/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBXQEALgBEXQEAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region SoundPressureState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class SoundPressureState<T> : SoundPressureState
    {
        #region Constructors
        /// <remarks />
        public SoundPressureState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region StrainState Class
    #if (!OPCUA_EXCLUDE_StrainState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StrainState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public StrainState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.StrainType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABIA" +
           "AABTdHJhaW5UeXBlSW5zdGFuY2UBAWMBAQFjAWMBAAAAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQFnAQAuAERnAQAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region StrainState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class StrainState<T> : StrainState
    {
        #region Constructors
        /// <remarks />
        public StrainState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TemperatureState Class
    #if (!OPCUA_EXCLUDE_TemperatureState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public TemperatureState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.TemperatureType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABcA" +
           "AABUZW1wZXJhdHVyZVR5cGVJbnN0YW5jZQEBbQEBAW0BbQEAAAAa/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAXEBAC4ARHEBAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region TemperatureState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class TemperatureState<T> : TemperatureState
    {
        #region Constructors
        /// <remarks />
        public TemperatureState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TiltState Class
    #if (!OPCUA_EXCLUDE_TiltState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TiltState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public TiltState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.TiltType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABAA" +
           "AABUaWx0VHlwZUluc3RhbmNlAQF3AQEBdwF3AQAAABr/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBewEALgBEewEAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region TiltState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class TiltState<T> : TiltState
    {
        #region Constructors
        /// <remarks />
        public TiltState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TorqueState Class
    #if (!OPCUA_EXCLUDE_TorqueState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TorqueState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public TorqueState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.TorqueType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABIA" +
           "AABUb3JxdWVUeXBlSW5zdGFuY2UBAYEBAQGBAYEBAAAAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQGFAQAuAESFAQAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region TorqueState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class TorqueState<T> : TorqueState
    {
        #region Constructors
        /// <remarks />
        public TorqueState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VelocityState Class
    #if (!OPCUA_EXCLUDE_VelocityState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VelocityState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public VelocityState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.VelocityType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABQA" +
           "AABWZWxvY2l0eVR5cGVJbnN0YW5jZQEBiwEBAYsBiwEAAAAa/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAY8BAC4ARI8BAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VelocityState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VelocityState<T> : VelocityState
    {
        #region Constructors
        /// <remarks />
        public VelocityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ViscosityState Class
    #if (!OPCUA_EXCLUDE_ViscosityState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ViscosityState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public ViscosityState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ViscosityType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABUA" +
           "AABWaXNjb3NpdHlUeXBlSW5zdGFuY2UBAZUBAQGVAZUBAAAAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQGZAQAuAESZAQAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ViscosityState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ViscosityState<T> : ViscosityState
    {
        #region Constructors
        /// <remarks />
        public ViscosityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VoltageState Class
    #if (!OPCUA_EXCLUDE_VoltageState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltageState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public VoltageState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.VoltageType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABMA" +
           "AABWb2x0YWdlVHlwZUluc3RhbmNlAQGfAQEBnwGfAQAAABr/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBowEALgBEowEAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VoltageState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VoltageState<T> : VoltageState
    {
        #region Constructors
        /// <remarks />
        public VoltageState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VoltAmpereState Class
    #if (!OPCUA_EXCLUDE_VoltAmpereState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltAmpereState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public VoltAmpereState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.VoltAmpereType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABYA" +
           "AABWb2x0QW1wZXJlVHlwZUluc3RhbmNlAQGpAQEBqQGpAQAAABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBrQEALgBErQEAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VoltAmpereState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VoltAmpereState<T> : VoltAmpereState
    {
        #region Constructors
        /// <remarks />
        public VoltAmpereState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VoltAmpereReactiveState Class
    #if (!OPCUA_EXCLUDE_VoltAmpereReactiveState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltAmpereReactiveState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public VoltAmpereReactiveState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.VoltAmpereReactiveType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABAB4A" +
           "AABWb2x0QW1wZXJlUmVhY3RpdmVUeXBlSW5zdGFuY2UBAbMBAQGzAbMBAAAAGv////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQG3AQAuAES3AQAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VoltAmpereReactiveState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VoltAmpereReactiveState<T> : VoltAmpereReactiveState
    {
        #region Constructors
        /// <remarks />
        public VoltAmpereReactiveState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region WattageState Class
    #if (!OPCUA_EXCLUDE_WattageState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WattageState : MTSampleDataItemState
    {
        #region Constructors
        /// <remarks />
        public WattageState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.WattageType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABMA" +
           "AABXYXR0YWdlVHlwZUluc3RhbmNlAQG9AQEBvQG9AQAAABr/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBwQEALgBEwQEAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region WattageState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class WattageState<T> : WattageState
    {
        #region Constructors
        /// <remarks />
        public WattageState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region MTEventDataItemState Class
    #if (!OPCUA_EXCLUDE_MTEventDataItemState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTEventDataItemState : DiscreteItemState
    {
        #region Constructors
        /// <remarks />
        public MTEventDataItemState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.MTEventDataItemType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CoordinateSystem != null)
            {
                CoordinateSystem.Initialize(context, CoordinateSystem_InitializationString);
            }

            if (SampleInterval != null)
            {
                SampleInterval.Initialize(context, SampleInterval_InitializationString);
            }
        }

        #region Initialization String
        private const string CoordinateSystem_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABAA" +
           "AABDb29yZGluYXRlU3lzdGVtAQHKAQAuAETKAQAAAQE1Dv////8BAf////8AAAAA";

        private const string SampleInterval_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAA4A" +
           "AABTYW1wbGVJbnRlcnZhbAEBywEALgBEywEAAAEAIgH/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABsA" +
           "AABNVEV2ZW50RGF0YUl0ZW1UeXBlSW5zdGFuY2UBAccBAQHHAccBAAAAGP////8BAf////8CAAAAFWCJ" +
           "CgIAAAABABAAAABDb29yZGluYXRlU3lzdGVtAQHKAQAuAETKAQAAAQE1Dv////8BAf////8AAAAAFWCJ" +
           "CgIAAAABAA4AAABTYW1wbGVJbnRlcnZhbAEBywEALgBEywEAAAEAIgH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<CoordinateSystemTypeEnum> CoordinateSystem
        {
            get
            {
                return m_coordinateSystem;
            }

            set
            {
                if (!Object.ReferenceEquals(m_coordinateSystem, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_coordinateSystem = value;
            }
        }

        /// <remarks />
        public PropertyState<double> SampleInterval
        {
            get
            {
                return m_sampleInterval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleInterval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleInterval = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_coordinateSystem != null)
            {
                children.Add(m_coordinateSystem);
            }

            if (m_sampleInterval != null)
            {
                children.Add(m_sampleInterval);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.CoordinateSystem:
                {
                    if (createOrReplace)
                    {
                        if (CoordinateSystem == null)
                        {
                            if (replacement == null)
                            {
                                CoordinateSystem = new PropertyState<CoordinateSystemTypeEnum>(this);
                            }
                            else
                            {
                                CoordinateSystem = (PropertyState<CoordinateSystemTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CoordinateSystem;
                    break;
                }

                case MyOPCUAServer.BrowseNames.SampleInterval:
                {
                    if (createOrReplace)
                    {
                        if (SampleInterval == null)
                        {
                            if (replacement == null)
                            {
                                SampleInterval = new PropertyState<double>(this);
                            }
                            else
                            {
                                SampleInterval = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleInterval;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<CoordinateSystemTypeEnum> m_coordinateSystem;
        private PropertyState<double> m_sampleInterval;
        #endregion
    }

    #region MTEventDataItemState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MTEventDataItemState<T> : MTEventDataItemState
    {
        #region Constructors
        /// <remarks />
        public MTEventDataItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ActiveAxesState Class
    #if (!OPCUA_EXCLUDE_ActiveAxesState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ActiveAxesState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <remarks />
        public ActiveAxesState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ActiveAxesType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABYA" +
           "AABBY3RpdmVBeGVzVHlwZUluc3RhbmNlAQHMAQEBzAHMAQAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ActuatorStateState Class
    #if (!OPCUA_EXCLUDE_ActuatorStateState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ActuatorStateState : MTEventDataItemState<ActuatorStateTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public ActuatorStateState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ActuatorStateType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.ActuatorStateTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABkA" +
           "AABBY3R1YXRvclN0YXRlVHlwZUluc3RhbmNlAQHRAQEB0QHRAQAAAQEdDv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AvailabilityState Class
    #if (!OPCUA_EXCLUDE_AvailabilityState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AvailabilityState : MTEventDataItemState<AvailabilityTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public AvailabilityState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.AvailabilityType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.AvailabilityTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABgA" +
           "AABBdmFpbGFiaWxpdHlUeXBlSW5zdGFuY2UBAdYBAQHWAdYBAAABASUO/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AxesCouplingState Class
    #if (!OPCUA_EXCLUDE_AxesCouplingState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AxesCouplingState : MTEventDataItemState<AxesCouplingTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public AxesCouplingState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.AxesCouplingType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.AxesCouplingTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABgA" +
           "AABBeGVzQ291cGxpbmdUeXBlSW5zdGFuY2UBAdsBAQHbAdsBAAABAScO/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region BlockState Class
    #if (!OPCUA_EXCLUDE_BlockState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BlockState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <remarks />
        public BlockState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.BlockType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABEA" +
           "AABCbG9ja1R5cGVJbnN0YW5jZQEB4AEBAeAB4AEAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ClampStateState Class
    #if (!OPCUA_EXCLUDE_ClampStateState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ClampStateState : MTEventDataItemState<ClampStateTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public ClampStateState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ClampStateType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.ClampStateTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABYA" +
           "AABDbGFtcFN0YXRlVHlwZUluc3RhbmNlAQHlAQEB5QHlAQAAAQEwDv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ControllerModeState Class
    #if (!OPCUA_EXCLUDE_ControllerModeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControllerModeState : MTEventDataItemState<ControllerModeTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public ControllerModeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ControllerModeType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.ControllerModeTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABoA" +
           "AABDb250cm9sbGVyTW9kZVR5cGVJbnN0YW5jZQEB6gEBAeoB6gEAAAEBMw7/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region CoupledAxesState Class
    #if (!OPCUA_EXCLUDE_CoupledAxesState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CoupledAxesState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <remarks />
        public CoupledAxesState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.CoupledAxesType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABcA" +
           "AABDb3VwbGVkQXhlc1R5cGVJbnN0YW5jZQEB7wEBAe8B7wEAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DirectionState Class
    #if (!OPCUA_EXCLUDE_DirectionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DirectionState : MTEventDataItemState<DirectionTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public DirectionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.DirectionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.DirectionTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABUA" +
           "AABEaXJlY3Rpb25UeXBlSW5zdGFuY2UBAfQBAQH0AfQBAAABAUwO/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DoorStateState Class
    #if (!OPCUA_EXCLUDE_DoorStateState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DoorStateState : MTEventDataItemState<DoorStateTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public DoorStateState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.DoorStateType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.DoorStateTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABUA" +
           "AABEb29yU3RhdGVUeXBlSW5zdGFuY2UBAfkBAQH5AfkBAAABAU4O/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region EmergencyStopState Class
    #if (!OPCUA_EXCLUDE_EmergencyStopState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EmergencyStopState : MTEventDataItemState<EmergencyStopTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public EmergencyStopState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.EmergencyStopType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.EmergencyStopTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABkA" +
           "AABFbWVyZ2VuY3lTdG9wVHlwZUluc3RhbmNlAQH+AQEB/gH+AQAAAQFTDv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ExecutionState Class
    #if (!OPCUA_EXCLUDE_ExecutionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ExecutionState : MTEventDataItemState<ExecutionTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public ExecutionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ExecutionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.ExecutionTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABUA" +
           "AABFeGVjdXRpb25UeXBlSW5zdGFuY2UBAQMCAQEDAgMCAAABAVYO/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LineState Class
    #if (!OPCUA_EXCLUDE_LineState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LineState : MTEventDataItemState<ushort>
    {
        #region Constructors
        /// <remarks />
        public LineState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.LineType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.UInt16, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABAA" +
           "AABMaW5lVHlwZUluc3RhbmNlAQEIAgEBCAIIAgAAAAX/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MessageState Class
    #if (!OPCUA_EXCLUDE_MessageState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MessageState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <remarks />
        public MessageState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.MessageType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABMA" +
           "AABNZXNzYWdlVHlwZUluc3RhbmNlAQENAgEBDQINAgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PalletIdState Class
    #if (!OPCUA_EXCLUDE_PalletIdState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PalletIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <remarks />
        public PalletIdState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PalletIdType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABQA" +
           "AABQYWxsZXRJZFR5cGVJbnN0YW5jZQEBEgIBARICEgIAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PartCountState Class
    #if (!OPCUA_EXCLUDE_PartCountState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PartCountState : MTEventDataItemState<ushort>
    {
        #region Constructors
        /// <remarks />
        public PartCountState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PartCountType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.UInt16, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABUA" +
           "AABQYXJ0Q291bnRUeXBlSW5zdGFuY2UBARcCAQEXAhcCAAAABf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PartIdState Class
    #if (!OPCUA_EXCLUDE_PartIdState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PartIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <remarks />
        public PartIdState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PartIdType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABIA" +
           "AABQYXJ0SWRUeXBlSW5zdGFuY2UBARwCAQEcAhwCAAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PathModeState Class
    #if (!OPCUA_EXCLUDE_PathModeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PathModeState : MTEventDataItemState<PathModeTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public PathModeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PathModeType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.PathModeTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABQA" +
           "AABQYXRoTW9kZVR5cGVJbnN0YW5jZQEBIQIBASECIQIAAAEBeg7/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PowerStateState Class
    #if (!OPCUA_EXCLUDE_PowerStateState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PowerStateState : MTEventDataItemState<PowerStateTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public PowerStateState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.PowerStateType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.PowerStateTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABYA" +
           "AABQb3dlclN0YXRlVHlwZUluc3RhbmNlAQEmAgEBJgImAgAAAQF8Dv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ProgramState Class
    #if (!OPCUA_EXCLUDE_ProgramState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <remarks />
        public ProgramState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ProgramType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABMA" +
           "AABQcm9ncmFtVHlwZUluc3RhbmNlAQErAgEBKwIrAgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region RotaryModeState Class
    #if (!OPCUA_EXCLUDE_RotaryModeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RotaryModeState : MTEventDataItemState<RotaryModeTypeEnum>
    {
        #region Constructors
        /// <remarks />
        public RotaryModeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.RotaryModeType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.RotaryModeTypeEnum, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABYA" +
           "AABSb3RhcnlNb2RlVHlwZUluc3RhbmNlAQEwAgEBMAIwAgAAAQGDDv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ToolAssetIdState Class
    #if (!OPCUA_EXCLUDE_ToolAssetIdState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ToolAssetIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <remarks />
        public ToolAssetIdState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ToolAssetIdType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABcA" +
           "AABUb29sQXNzZXRJZFR5cGVJbnN0YW5jZQEBNQIBATUCNQIAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ToolNumberState Class
    #if (!OPCUA_EXCLUDE_ToolNumberState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ToolNumberState : MTEventDataItemState<ushort>
    {
        #region Constructors
        /// <remarks />
        public ToolNumberState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ToolNumberType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.UInt16, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABYA" +
           "AABUb29sTnVtYmVyVHlwZUluc3RhbmNlAQE6AgEBOgI6AgAAAAX/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region WorkHoldingIdState Class
    #if (!OPCUA_EXCLUDE_WorkHoldingIdState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WorkHoldingIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <remarks />
        public WorkHoldingIdState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.WorkHoldingIdType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABkA" +
           "AABXb3JrSG9sZGluZ0lkVHlwZUluc3RhbmNlAQE/AgEBPwI/AgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MTConditionState Class
    #if (!OPCUA_EXCLUDE_MTConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTConditionState : ConditionState
    {
        #region Constructors
        /// <remarks />
        public MTConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MTConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (LimitState != null)
            {
                LimitState.Initialize(context, LimitState_InitializationString);
            }

            if (NativeCode != null)
            {
                NativeCode.Initialize(context, NativeCode_InitializationString);
            }

            if (NativeSeverity != null)
            {
                NativeSeverity.Initialize(context, NativeSeverity_InitializationString);
            }
        }

        #region Initialization String
        private const string LimitState_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCACgEAAAABAAoA" +
           "AABMaW1pdFN0YXRlAQF3AgAvAQBmJHcCAAD/////AQAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRl" +
           "AQF4AgAvAQDICngCAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBeQIALgBEeQIAAAAR" +
           "/////wEB/////wAAAAA=";

        private const string NativeCode_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAoA" +
           "AABOYXRpdmVDb2RlAQGFAgAuAESFAgAAAAz/////AQH/////AAAAAA==";

        private const string NativeSeverity_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAA4A" +
           "AABOYXRpdmVTZXZlcml0eQEBhgIALgBEhgIAAAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABcA" +
           "AABNVENvbmRpdGlvblR5cGVJbnN0YW5jZQEBRAIBAUQCRAIAAP////8aAAAAFWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQFFAgAuAERFAgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQFG" +
           "AgAuAERGAgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBRwIALgBERwIA" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAUgCAC4AREgCAAAADP////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFJAgAuAERJAgAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAsAAABSZWNlaXZlVGltZQEBSgIALgBESgIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEBTAIALgBETAIAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVy" +
           "aXR5AQFNAgAuAERNAgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJ" +
           "ZAEBTgIALgBETgIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFt" +
           "ZQEBTwIALgBETwIAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAVIC" +
           "AC4ARFICAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBUwIALgBEUwIAAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBVAIALgBEVAIAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBVQIALwEAIyNVAgAAABX/////AQH/////AQAAABVg" +
           "iQoCAAAAAAACAAAASWQBAVYCAC4ARFYCAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFs" +
           "aXR5AQFeAgAvAQAqI14CAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAV8CAC4ARF8CAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEB" +
           "YAIALwEAKiNgAgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFh" +
           "AgAuAERhAgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQFiAgAvAQAqI2IC" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAWMCAC4ARGMCAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBZAIALgBEZAIAAAAM////" +
           "/wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAWUCAC8BAEQjZQIAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBZgIALwEAQyNmAgAAAQEBAAAAAQD5CwABAPMKAAAAAARh" +
           "ggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBZwIALwEARSNnAgAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAWgCAC4ARGgCAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElk" +
           "AA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4B" +
           "ACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8g" +
           "dGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJy" +
           "ZW50U3RhdGUBAW0CAC8AP20CAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0" +
           "ZQEBbgIALwEAIyNuAgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAW8CAC4ARG8CAAAA" +
           "Af////8BAf////8AAAAABGCACgEAAAABAAoAAABMaW1pdFN0YXRlAQF3AgAvAQBmJHcCAAD/////AQAA" +
           "ABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQF4AgAvAQDICngCAAAAFf////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAEBeQIALgBEeQIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAEACgAAAE5hdGl2" +
           "ZUNvZGUBAYUCAC4ARIUCAAAADP////8BAf////8AAAAAFWCJCgIAAAABAA4AAABOYXRpdmVTZXZlcml0" +
           "eQEBhgIALgBEhgIAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<string> MTCurrentState
        {
            get
            {
                return m_mTCurrentState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mTCurrentState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mTCurrentState = value;
            }
        }

        /// <remarks />
        public TwoStateVariableState ActiveState
        {
            get
            {
                return m_activeState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_activeState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_activeState = value;
            }
        }

        /// <remarks />
        public ExclusiveLimitStateMachineState LimitState
        {
            get
            {
                return m_limitState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_limitState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_limitState = value;
            }
        }

        /// <remarks />
        public PropertyState<string> NativeCode
        {
            get
            {
                return m_nativeCode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeCode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeCode = value;
            }
        }

        /// <remarks />
        public PropertyState<string> NativeSeverity
        {
            get
            {
                return m_nativeSeverity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeSeverity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeSeverity = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mTCurrentState != null)
            {
                children.Add(m_mTCurrentState);
            }

            if (m_activeState != null)
            {
                children.Add(m_activeState);
            }

            if (m_limitState != null)
            {
                children.Add(m_limitState);
            }

            if (m_nativeCode != null)
            {
                children.Add(m_nativeCode);
            }

            if (m_nativeSeverity != null)
            {
                children.Add(m_nativeSeverity);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.MTCurrentState:
                {
                    if (createOrReplace)
                    {
                        if (MTCurrentState == null)
                        {
                            if (replacement == null)
                            {
                                MTCurrentState = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                MTCurrentState = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = MTCurrentState;
                    break;
                }

                case MyOPCUAServer.BrowseNames.ActiveState:
                {
                    if (createOrReplace)
                    {
                        if (ActiveState == null)
                        {
                            if (replacement == null)
                            {
                                ActiveState = new TwoStateVariableState(this);
                            }
                            else
                            {
                                ActiveState = (TwoStateVariableState)replacement;
                            }
                        }
                    }

                    instance = ActiveState;
                    break;
                }

                case MyOPCUAServer.BrowseNames.LimitState:
                {
                    if (createOrReplace)
                    {
                        if (LimitState == null)
                        {
                            if (replacement == null)
                            {
                                LimitState = new ExclusiveLimitStateMachineState(this);
                            }
                            else
                            {
                                LimitState = (ExclusiveLimitStateMachineState)replacement;
                            }
                        }
                    }

                    instance = LimitState;
                    break;
                }

                case MyOPCUAServer.BrowseNames.NativeCode:
                {
                    if (createOrReplace)
                    {
                        if (NativeCode == null)
                        {
                            if (replacement == null)
                            {
                                NativeCode = new PropertyState<string>(this);
                            }
                            else
                            {
                                NativeCode = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NativeCode;
                    break;
                }

                case MyOPCUAServer.BrowseNames.NativeSeverity:
                {
                    if (createOrReplace)
                    {
                        if (NativeSeverity == null)
                        {
                            if (replacement == null)
                            {
                                NativeSeverity = new PropertyState<string>(this);
                            }
                            else
                            {
                                NativeSeverity = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NativeSeverity;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_mTCurrentState;
        private TwoStateVariableState m_activeState;
        private ExclusiveLimitStateMachineState m_limitState;
        private PropertyState<string> m_nativeCode;
        private PropertyState<string> m_nativeSeverity;
        #endregion
    }
    #endif
    #endregion

    #region AccelerationConditionState Class
    #if (!OPCUA_EXCLUDE_AccelerationConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccelerationConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public AccelerationConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.AccelerationConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACEA" +
           "AABBY2NlbGVyYXRpb25Db25kaXRpb25UeXBlSW5zdGFuY2UBAYcCAQGHAocCAAD/////FwAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBiAIALgBEiAIAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEBiQIALgBEiQIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AYoCAC4ARIoCAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGLAgAuAESL" +
           "AgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBjAIALgBEjAIAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAY0CAC4ARI0CAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAY8CAC4ARI8CAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABTZXZlcml0eQEBkAIALgBEkAIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBAZECAC4ARJECAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBAZICAC4ARJICAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQGVAgAuAESVAgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAZYC" +
           "AC4ARJYCAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAZcCAC4ARJcCAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAZgCAC8BACMjmAIAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGZAgAuAESZAgAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEBoQIALwEAKiOhAgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQGiAgAuAESiAgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBAaMCAC8BACojowIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBpAIALgBEpAIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "pQIALwEAKiOlAgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQGm" +
           "AgAuAESmAgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAacCAC4A" +
           "RKcCAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQGoAgAvAQBEI6gCAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAakCAC8BAEMjqQIAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAaoCAC8BAEUjqgIAAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGrAgAuAESrAgAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQGwAgAvAD+wAgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAbECAC8BACMjsQIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGy" +
           "AgAuAESyAgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Accumulated_TimeConditionState Class
    #if (!OPCUA_EXCLUDE_Accumulated_TimeConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Accumulated_TimeConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Accumulated_TimeConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Accumulated_TimeConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACUA" +
           "AABBY2N1bXVsYXRlZF9UaW1lQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHKAgEBygLKAgAA/////xcAAAAV" +
           "YIkKAgAAAAAABwAAAEV2ZW50SWQBAcsCAC4ARMsCAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkA" +
           "AABFdmVudFR5cGUBAcwCAC4ARMwCAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VO" +
           "b2RlAQHNAgAuAETNAgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBzgIA" +
           "LgBEzgIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAc8CAC4ARM8CAAABACYB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHQAgAuAETQAgAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQHSAgAuAETSAgAAABX/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAIAAAAU2V2ZXJpdHkBAdMCAC4ARNMCAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABD" +
           "b25kaXRpb25DbGFzc0lkAQHUAgAuAETUAgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NOYW1lAQHVAgAuAETVAgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29u" +
           "ZGl0aW9uTmFtZQEB2AIALgBE2AIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElk" +
           "AQHZAgAuAETZAgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHaAgAuAETaAgAA" +
           "AAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHbAgAvAQAjI9sCAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB3AIALgBE3AIAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAFF1YWxpdHkBAeQCAC8BACoj5AIAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEB5QIALgBE5QIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAA" +
           "TGFzdFNldmVyaXR5AQHmAgAvAQAqI+YCAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAecCAC4AROcCAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1l" +
           "bnQBAegCAC8BACoj6AIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEB6QIALgBE6QIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHq" +
           "AgAuAETqAgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB6wIALwEARCPrAgAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHsAgAvAQBDI+wCAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHtAgAvAQBFI+0CAAABAQEAAAABAPkL" +
           "AAEADQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB7gIALgBE7gIAAJYCAAAAAQAqAQFG" +
           "AAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21t" +
           "ZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIA" +
           "AAABAA4AAABNVEN1cnJlbnRTdGF0ZQEB8wIALwA/8wIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "CwAAAEFjdGl2ZVN0YXRlAQH0AgAvAQAjI/QCAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEB9QIALgBE9QIAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AmperageConditionState Class
    #if (!OPCUA_EXCLUDE_AmperageConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AmperageConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public AmperageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.AmperageConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB0A" +
           "AABBbXBlcmFnZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBDQMBAQ0DDQMAAP////8XAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQEOAwAuAEQOAwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQEPAwAuAEQPAwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBEAMA" +
           "LgBEEAMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAREDAC4ARBEDAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQESAwAuAEQSAwAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBEwMALgBEEwMAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBFQMALgBEFQMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQEWAwAuAEQWAwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBFwMALgBEFwMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBGAMALgBEGAMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBARsDAC4ARBsDAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBHAMALgBE" +
           "HAMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBHQMALgBEHQMAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBHgMALwEAIyMeAwAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAR8DAC4ARB8DAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQEnAwAvAQAqIycDAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABASgDAC4ARCgDAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEBKQMALwEAKiMpAwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQEqAwAuAEQqAwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQErAwAv" +
           "AQAqIysDAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABASwDAC4A" +
           "RCwDAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBLQMALgBELQMA" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAS4DAC8BAEQjLgMAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBLwMALwEAQyMvAwAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBMAMALwEARSMwAwAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATEDAC4ARDEDAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBATYDAC8APzYDAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBNwMALwEAIyM3AwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBATgDAC4A" +
           "RDgDAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AngleConditionState Class
    #if (!OPCUA_EXCLUDE_AngleConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngleConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public AngleConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.AngleConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABoA" +
           "AABBbmdsZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBUAMBAVADUAMAAP////8XAAAAFWCJCgIAAAAAAAcA" +
           "AABFdmVudElkAQFRAwAuAERRAwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBl" +
           "AQFSAwAuAERSAwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBUwMALgBE" +
           "UwMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAVQDAC4ARFQDAAAADP//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFVAwAuAERVAwAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBVgMALgBEVgMAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAATWVzc2FnZQEBWAMALgBEWAMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNl" +
           "dmVyaXR5AQFZAwAuAERZAwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xh" +
           "c3NJZAEBWgMALgBEWgMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNz" +
           "TmFtZQEBWwMALgBEWwMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUB" +
           "AV4DAC4ARF4DAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBXwMALgBEXwMA" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBYAMALgBEYAMAAAAB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBYQMALwEAIyNhAwAAABX/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAACAAAASWQBAWIDAC4ARGIDAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABR" +
           "dWFsaXR5AQFqAwAvAQAqI2oDAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAWsDAC4ARGsDAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0" +
           "eQEBbAMALwEAKiNsAwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQFtAwAuAERtAwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQFuAwAvAQAq" +
           "I24DAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAW8DAC4ARG8D" +
           "AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBcAMALgBEcAMAAAAM" +
           "/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAXEDAC8BAEQjcQMAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBcgMALwEAQyNyAwAAAQEBAAAAAQD5CwABAPMKAAAA" +
           "AARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBcwMALwEARSNzAwAAAQEBAAAAAQD5CwABAA0LAQAAABdg" +
           "qQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXQDAC4ARHQDAACWAgAAAAEAKgEBRgAAAAcAAABFdmVu" +
           "dElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVu" +
           "dC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQg" +
           "dG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRD" +
           "dXJyZW50U3RhdGUBAXkDAC8AP3kDAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVT" +
           "dGF0ZQEBegMALwEAIyN6AwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAXsDAC4ARHsD" +
           "AAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Angular-AccelerationConditionState Class
    #if (!OPCUA_EXCLUDE_Angular-AccelerationConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Angular-AccelerationConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Angular-AccelerationConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Angular-AccelerationConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACkA" +
           "AABBbmd1bGFyLUFjY2VsZXJhdGlvbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBkwMBAZMDkwMAAP////8X" +
           "AAAAFWCJCgIAAAAAAAcAAABFdmVudElkAQGUAwAuAESUAwAAAA//////AQH/////AAAAABVgiQoCAAAA" +
           "AAAJAAAARXZlbnRUeXBlAQGVAwAuAESVAwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291" +
           "cmNlTm9kZQEBlgMALgBElgMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUB" +
           "AZcDAC4ARJcDAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGYAwAuAESYAwAAAQAm" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBmQMALgBEmQMAAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBmwMALgBEmwMAAAAV/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACAAAAFNldmVyaXR5AQGcAwAuAEScAwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAAQ29uZGl0aW9uQ2xhc3NJZAEBnQMALgBEnQMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAA" +
           "AENvbmRpdGlvbkNsYXNzTmFtZQEBngMALgBEngMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAA" +
           "AENvbmRpdGlvbk5hbWUBAaEDAC4ARKEDAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFu" +
           "Y2hJZAEBogMALgBEogMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBowMALgBE" +
           "owMAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBpAMALwEAIyOkAwAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAaUDAC4ARKUDAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABRdWFsaXR5AQGtAwAvAQAqI60DAAAAE/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABAa4DAC4ARK4DAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DAAAAExhc3RTZXZlcml0eQEBrwMALwEAKiOvAwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQGwAwAuAESwAwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABD" +
           "b21tZW50AQGxAwAvAQAqI7EDAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAbIDAC4ARLIDAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJ" +
           "ZAEBswMALgBEswMAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAbQDAC8BAEQj" +
           "tAMAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBtQMALwEAQyO1AwAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBtgMALwEARSO2AwAAAQEBAAAA" +
           "AQD5CwABAA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbcDAC4ARLcDAACWAgAAAAEA" +
           "KgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUg" +
           "Y29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVg" +
           "iQoCAAAAAQAOAAAATVRDdXJyZW50U3RhdGUBAbwDAC8AP7wDAAAADP////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAsAAABBY3RpdmVTdGF0ZQEBvQMALwEAIyO9AwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAC" +
           "AAAASWQBAb4DAC4ARL4DAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Angular_VelocityConditionState Class
    #if (!OPCUA_EXCLUDE_Angular_VelocityConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Angular_VelocityConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Angular_VelocityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Angular_VelocityConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACUA" +
           "AABBbmd1bGFyX1ZlbG9jaXR5Q29uZGl0aW9uVHlwZUluc3RhbmNlAQHWAwEB1gPWAwAA/////xcAAAAV" +
           "YIkKAgAAAAAABwAAAEV2ZW50SWQBAdcDAC4ARNcDAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkA" +
           "AABFdmVudFR5cGUBAdgDAC4ARNgDAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VO" +
           "b2RlAQHZAwAuAETZAwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB2gMA" +
           "LgBE2gMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAdsDAC4ARNsDAAABACYB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHcAwAuAETcAwAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQHeAwAuAETeAwAAABX/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAIAAAAU2V2ZXJpdHkBAd8DAC4ARN8DAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABD" +
           "b25kaXRpb25DbGFzc0lkAQHgAwAuAETgAwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NOYW1lAQHhAwAuAEThAwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29u" +
           "ZGl0aW9uTmFtZQEB5AMALgBE5AMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElk" +
           "AQHlAwAuAETlAwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHmAwAuAETmAwAA" +
           "AAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHnAwAvAQAjI+cDAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB6AMALgBE6AMAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAFF1YWxpdHkBAfADAC8BACoj8AMAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEB8QMALgBE8QMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAA" +
           "TGFzdFNldmVyaXR5AQHyAwAvAQAqI/IDAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAfMDAC4ARPMDAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1l" +
           "bnQBAfQDAC8BACoj9AMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEB9QMALgBE9QMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQH2" +
           "AwAuAET2AwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB9wMALwEARCP3AwAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQH4AwAvAQBDI/gDAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQH5AwAvAQBFI/kDAAABAQEAAAABAPkL" +
           "AAEADQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB+gMALgBE+gMAAJYCAAAAAQAqAQFG" +
           "AAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21t" +
           "ZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIA" +
           "AAABAA4AAABNVEN1cnJlbnRTdGF0ZQEB/wMALwA//wMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "CwAAAEFjdGl2ZVN0YXRlAQEABAAvAQAjIwAEAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEBAQQALgBEAQQAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region CommunicationsConditionState Class
    #if (!OPCUA_EXCLUDE_CommunicationsConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CommunicationsConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public CommunicationsConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.CommunicationsConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACMA" +
           "AABDb21tdW5pY2F0aW9uc0NvbmRpdGlvblR5cGVJbnN0YW5jZQEBGQQBARkEGQQAAP////8XAAAAFWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQEaBAAuAEQaBAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQEbBAAuAEQbBAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQEBHAQALgBEHAQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAR0EAC4A" +
           "RB0EAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEeBAAuAEQeBAAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBHwQALgBEHwQAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBIQQALgBEIQQAAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAACAAAAFNldmVyaXR5AQEiBAAuAEQiBAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBIwQALgBEIwQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBJAQALgBEJAQAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBAScEAC4ARCcEAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "KAQALgBEKAQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBKQQALgBEKQQAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBKgQALwEAIyMqBAAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBASsEAC4ARCsEAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQEzBAAvAQAqIzMEAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABATQEAC4ARDQEAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBNQQALwEAKiM1BAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQE2BAAuAEQ2BAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQE3BAAvAQAqIzcEAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "ATgEAC4ARDgEAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBOQQA" +
           "LgBEOQQAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAToEAC8BAEQjOgQAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBOwQALwEAQyM7BAAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBPAQALwEARSM8BAAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAT0EAC4ARD0EAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAUIEAC8AP0IEAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBQwQALwEAIyNDBAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "AUQEAC4AREQEAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConcentrationConditionState Class
    #if (!OPCUA_EXCLUDE_ConcentrationConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConcentrationConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public ConcentrationConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.ConcentrationConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACIA" +
           "AABDb25jZW50cmF0aW9uQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFcBAEBXARcBAAA/////xcAAAAVYIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBAV0EAC4ARF0EAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABF" +
           "dmVudFR5cGUBAV4EAC4ARF4EAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2Rl" +
           "AQFfBAAuAERfBAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBYAQALgBE" +
           "YAQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAWEEAC4ARGEEAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFiBAAuAERiBAAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQFkBAAuAERkBAAAABX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAIAAAAU2V2ZXJpdHkBAWUEAC4ARGUEAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25k" +
           "aXRpb25DbGFzc0lkAQFmBAAuAERmBAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0" +
           "aW9uQ2xhc3NOYW1lAQFnBAAuAERnBAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0" +
           "aW9uTmFtZQEBagQALgBEagQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFr" +
           "BAAuAERrBAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFsBAAuAERsBAAAAAH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFtBAAvAQAjI20EAAAAFf////8B" +
           "Af////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBbgQALgBEbgQAAAAB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAFF1YWxpdHkBAXYEAC8BACojdgQAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBdwQALgBEdwQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFz" +
           "dFNldmVyaXR5AQF4BAAvAQAqI3gEAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAXkEAC4ARHkEAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQB" +
           "AXoEAC8BACojegQAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "ewQALgBEewQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQF8BAAu" +
           "AER8BAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBfQQALwEARCN9BAAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQF+BAAvAQBDI34EAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQF/BAAvAQBFI38EAAABAQEAAAABAPkLAAEA" +
           "DQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBgAQALgBEgAQAAJYCAAAAAQAqAQFGAAAA" +
           "BwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0" +
           "byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50" +
           "IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA4AAABNVEN1cnJlbnRTdGF0ZQEBhQQALwA/hQQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAA" +
           "AEFjdGl2ZVN0YXRlAQGGBAAvAQAjI4YEAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "hwQALgBEhwQAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConductivityConditionState Class
    #if (!OPCUA_EXCLUDE_ConductivityConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConductivityConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public ConductivityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.ConductivityConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACEA" +
           "AABDb25kdWN0aXZpdHlDb25kaXRpb25UeXBlSW5zdGFuY2UBAZ8EAQGfBJ8EAAD/////FwAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBoAQALgBEoAQAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEBoQQALgBEoQQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AaIEAC4ARKIEAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGjBAAuAESj" +
           "BAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBpAQALgBEpAQAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAaUEAC4ARKUEAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAacEAC4ARKcEAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABTZXZlcml0eQEBqAQALgBEqAQAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBAakEAC4ARKkEAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBAaoEAC4ARKoEAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQGtBAAuAEStBAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAa4E" +
           "AC4ARK4EAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAa8EAC4ARK8EAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAbAEAC8BACMjsAQAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGxBAAuAESxBAAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEBuQQALwEAKiO5BAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQG6BAAuAES6BAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBAbsEAC8BACojuwQAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBvAQALgBEvAQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "vQQALwEAKiO9BAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQG+" +
           "BAAuAES+BAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAb8EAC4A" +
           "RL8EAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHABAAvAQBEI8AEAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAcEEAC8BAEMjwQQAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAcIEAC8BAEUjwgQAAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHDBAAuAETDBAAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQHIBAAvAD/IBAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAckEAC8BACMjyQQAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHK" +
           "BAAuAETKBAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Data_RangeConditionState Class
    #if (!OPCUA_EXCLUDE_Data_RangeConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Data_RangeConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Data_RangeConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Data_RangeConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB8A" +
           "AABEYXRhX1JhbmdlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHiBAEB4gTiBAAA/////xcAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAeMEAC4AROMEAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAeQEAC4AROQEAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHl" +
           "BAAuAETlBAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB5gQALgBE5gQA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAecEAC4AROcEAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHoBAAuAEToBAAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQHqBAAuAETqBAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAesEAC4AROsEAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRp" +
           "b25DbGFzc0lkAQHsBAAuAETsBAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9u" +
           "Q2xhc3NOYW1lAQHtBAAuAETtBAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9u" +
           "TmFtZQEB8AQALgBE8AQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQHxBAAu" +
           "AETxBAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHyBAAuAETyBAAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHzBAAvAQAjI/MEAAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEB9AQALgBE9AQAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAFF1YWxpdHkBAfwEAC8BACoj/AQAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEB/QQALgBE/QQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNl" +
           "dmVyaXR5AQH+BAAvAQAqI/4EAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAf8EAC4ARP8EAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAQAF" +
           "AC8BACojAAUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBAQUA" +
           "LgBEAQUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQECBQAuAEQC" +
           "BQAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBAwUALwEARCMDBQAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEEBQAvAQBDIwQFAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQEFBQAvAQBFIwUFAAABAQEAAAABAPkLAAEADQsB" +
           "AAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBBgUALgBEBgUAAJYCAAAAAQAqAQFGAAAABwAA" +
           "AEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBj" +
           "b21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRv" +
           "IGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBCwUALwA/CwUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQEMBQAvAQAjIwwFAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBDQUA" +
           "LgBEDQUAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DirectionConditionState Class
    #if (!OPCUA_EXCLUDE_DirectionConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DirectionConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public DirectionConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.DirectionConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB4A" +
           "AABEaXJlY3Rpb25Db25kaXRpb25UeXBlSW5zdGFuY2UBASUFAQElBSUFAAD/////FwAAABVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEBJgUALgBEJgUAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50" +
           "VHlwZQEBJwUALgBEJwUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBASgF" +
           "AC4ARCgFAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEpBQAuAEQpBQAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBKgUALgBEKgUAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBASsFAC4ARCsFAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAE1lc3NhZ2UBAS0FAC4ARC0FAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABTZXZlcml0eQEBLgUALgBELgUAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlv" +
           "bkNsYXNzSWQBAS8FAC4ARC8FAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25D" +
           "bGFzc05hbWUBATAFAC4ARDAFAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25O" +
           "YW1lAQEzBQAuAEQzBQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBATQFAC4A" +
           "RDQFAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BATUFAC4ARDUFAAAAAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBATYFAC8BACMjNgUAAAAV/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAAAgAAAElkAQE3BQAuAEQ3BQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAUXVhbGl0eQEBPwUALwEAKiM/BQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQFABQAuAERABQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2" +
           "ZXJpdHkBAUEFAC8BACojQQUAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBQgUALgBEQgUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBQwUA" +
           "LwEAKiNDBQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFEBQAu" +
           "AEREBQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAUUFAC4AREUF" +
           "AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFGBQAvAQBEI0YFAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAUcFAC8BAEMjRwUAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAUgFAC8BAEUjSAUAAAEBAQAAAAEA+QsAAQANCwEA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFJBQAuAERJBQAAlgIAAAABACoBAUYAAAAHAAAA" +
           "RXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNv" +
           "bW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8g" +
           "YWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQFOBQAvAD9OBQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBAU8FAC8BACMjTwUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFQBQAu" +
           "AERQBQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DisplacementConditionState Class
    #if (!OPCUA_EXCLUDE_DisplacementConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DisplacementConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public DisplacementConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.DisplacementConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACEA" +
           "AABEaXNwbGFjZW1lbnRDb25kaXRpb25UeXBlSW5zdGFuY2UBAWgFAQFoBWgFAAD/////FwAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBaQUALgBEaQUAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEBagUALgBEagUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AWsFAC4ARGsFAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFsBQAuAERs" +
           "BQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBbQUALgBEbQUAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAW4FAC4ARG4FAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAXAFAC4ARHAFAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABTZXZlcml0eQEBcQUALgBEcQUAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBAXIFAC4ARHIFAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBAXMFAC4ARHMFAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQF2BQAuAER2BQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAXcF" +
           "AC4ARHcFAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAXgFAC4ARHgFAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAXkFAC8BACMjeQUAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQF6BQAuAER6BQAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEBggUALwEAKiOCBQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQGDBQAuAESDBQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBAYQFAC8BACojhAUAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBhQUALgBEhQUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "hgUALwEAKiOGBQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQGH" +
           "BQAuAESHBQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAYgFAC4A" +
           "RIgFAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQGJBQAvAQBEI4kFAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAYoFAC8BAEMjigUAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAYsFAC8BAEUjiwUAAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGMBQAuAESMBQAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQGRBQAvAD+RBQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAZIFAC8BACMjkgUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGT" +
           "BQAuAESTBQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Electrical_EnergyConditionState Class
    #if (!OPCUA_EXCLUDE_Electrical_EnergyConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Electrical_EnergyConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Electrical_EnergyConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Electrical_EnergyConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACYA" +
           "AABFbGVjdHJpY2FsX0VuZXJneUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBqwUBAasFqwUAAP////8XAAAA" +
           "FWCJCgIAAAAAAAcAAABFdmVudElkAQGsBQAuAESsBQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJ" +
           "AAAARXZlbnRUeXBlAQGtBQAuAEStBQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNl" +
           "Tm9kZQEBrgUALgBErgUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAa8F" +
           "AC4ARK8FAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGwBQAuAESwBQAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBsQUALgBEsQUAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBswUALgBEswUAAAAV/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACAAAAFNldmVyaXR5AQG0BQAuAES0BQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAA" +
           "Q29uZGl0aW9uQ2xhc3NJZAEBtQUALgBEtQUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENv" +
           "bmRpdGlvbkNsYXNzTmFtZQEBtgUALgBEtgUAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENv" +
           "bmRpdGlvbk5hbWUBAbkFAC4ARLkFAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJ" +
           "ZAEBugUALgBEugUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBuwUALgBEuwUA" +
           "AAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBvAUALwEAIyO8BQAAABX/" +
           "////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAb0FAC4ARL0FAAAAAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABRdWFsaXR5AQHFBQAvAQAqI8UFAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAcYFAC4ARMYFAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAA" +
           "AExhc3RTZXZlcml0eQEBxwUALwEAKiPHBQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQHIBQAuAETIBQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21t" +
           "ZW50AQHJBQAvAQAqI8kFAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAcoFAC4ARMoFAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB" +
           "ywUALgBEywUAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAcwFAC8BAEQjzAUA" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBzQUALwEAQyPNBQAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBzgUALwEARSPOBQAAAQEBAAAAAQD5" +
           "CwABAA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAc8FAC4ARM8FAACWAgAAAAEAKgEB" +
           "RgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZl" +
           "bnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29t" +
           "bWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoC" +
           "AAAAAQAOAAAATVRDdXJyZW50U3RhdGUBAdQFAC8AP9QFAAAADP////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAsAAABBY3RpdmVTdGF0ZQEB1QUALwEAIyPVBQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAA" +
           "SWQBAdYFAC4ARNYFAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Fill_LevelConditionState Class
    #if (!OPCUA_EXCLUDE_Fill_LevelConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Fill_LevelConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Fill_LevelConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Fill_LevelConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB8A" +
           "AABGaWxsX0xldmVsQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHuBQEB7gXuBQAA/////xcAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAe8FAC4ARO8FAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAfAFAC4ARPAFAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHx" +
           "BQAuAETxBQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB8gUALgBE8gUA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAfMFAC4ARPMFAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQH0BQAuAET0BQAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQH2BQAuAET2BQAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAfcFAC4ARPcFAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRp" +
           "b25DbGFzc0lkAQH4BQAuAET4BQAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9u" +
           "Q2xhc3NOYW1lAQH5BQAuAET5BQAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9u" +
           "TmFtZQEB/AUALgBE/AUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQH9BQAu" +
           "AET9BQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQH+BQAuAET+BQAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQH/BQAvAQAjI/8FAAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEBAAYALgBEAAYAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAFF1YWxpdHkBAQgGAC8BACojCAYAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBCQYALgBECQYAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNl" +
           "dmVyaXR5AQEKBgAvAQAqIwoGAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAQsGAC4ARAsGAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAQwG" +
           "AC8BACojDAYAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBDQYA" +
           "LgBEDQYAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQEOBgAuAEQO" +
           "BgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBDwYALwEARCMPBgAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEQBgAvAQBDIxAGAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQERBgAvAQBFIxEGAAABAQEAAAABAPkLAAEADQsB" +
           "AAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBEgYALgBEEgYAAJYCAAAAAQAqAQFGAAAABwAA" +
           "AEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBj" +
           "b21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRv" +
           "IGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBFwYALwA/FwYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQEYBgAvAQAjIxgGAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBGQYA" +
           "LgBEGQYAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FlowConditionState Class
    #if (!OPCUA_EXCLUDE_FlowConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FlowConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public FlowConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.FlowConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABkA" +
           "AABGbG93Q29uZGl0aW9uVHlwZUluc3RhbmNlAQExBgEBMQYxBgAA/////xcAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBATIGAC4ARDIGAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "ATMGAC4ARDMGAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQE0BgAuAEQ0" +
           "BgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBNQYALgBENQYAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBATYGAC4ARDYGAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQE3BgAuAEQ3BgAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQE5BgAuAEQ5BgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBAToGAC4ARDoGAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFz" +
           "c0lkAQE7BgAuAEQ7BgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NO" +
           "YW1lAQE8BgAuAEQ8BgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB" +
           "PwYALgBEPwYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFABgAuAERABgAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFBBgAuAERBBgAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFCBgAvAQAjI0IGAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBQwYALgBEQwYAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1" +
           "YWxpdHkBAUsGAC8BACojSwYAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBTAYALgBETAYAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5" +
           "AQFNBgAvAQAqI00GAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AU4GAC4ARE4GAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAU8GAC8BACoj" +
           "TwYAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBUAYALgBEUAYA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFRBgAuAERRBgAAAAz/" +
           "////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBUgYALwEARCNSBgAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFTBgAvAQBDI1MGAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFUBgAvAQBFI1QGAAABAQEAAAABAPkLAAEADQsBAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBVQYALgBEVQYAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50" +
           "SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50" +
           "LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEBWgYALwA/WgYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQFbBgAvAQAjI1sGAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBXAYALgBEXAYA" +
           "AAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FrequencyConditionState Class
    #if (!OPCUA_EXCLUDE_FrequencyConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FrequencyConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public FrequencyConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.FrequencyConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB4A" +
           "AABGcmVxdWVuY3lDb25kaXRpb25UeXBlSW5zdGFuY2UBAXQGAQF0BnQGAAD/////FwAAABVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEBdQYALgBEdQYAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50" +
           "VHlwZQEBdgYALgBEdgYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAXcG" +
           "AC4ARHcGAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQF4BgAuAER4BgAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBeQYALgBEeQYAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAXoGAC4ARHoGAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAE1lc3NhZ2UBAXwGAC4ARHwGAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABTZXZlcml0eQEBfQYALgBEfQYAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlv" +
           "bkNsYXNzSWQBAX4GAC4ARH4GAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25D" +
           "bGFzc05hbWUBAX8GAC4ARH8GAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25O" +
           "YW1lAQGCBgAuAESCBgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAYMGAC4A" +
           "RIMGAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAYQGAC4ARIQGAAAAAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAYUGAC8BACMjhQYAAAAV/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAAAgAAAElkAQGGBgAuAESGBgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAUXVhbGl0eQEBjgYALwEAKiOOBgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQGPBgAuAESPBgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2" +
           "ZXJpdHkBAZAGAC8BACojkAYAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBkQYALgBEkQYAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBkgYA" +
           "LwEAKiOSBgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQGTBgAu" +
           "AESTBgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAZQGAC4ARJQG" +
           "AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQGVBgAvAQBEI5UGAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAZYGAC8BAEMjlgYAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAZcGAC8BAEUjlwYAAAEBAQAAAAEA+QsAAQANCwEA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGYBgAuAESYBgAAlgIAAAABACoBAUYAAAAHAAAA" +
           "RXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNv" +
           "bW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8g" +
           "YWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQGdBgAvAD+dBgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBAZ4GAC8BACMjngYAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGfBgAu" +
           "AESfBgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region HardwareConditionState Class
    #if (!OPCUA_EXCLUDE_HardwareConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class HardwareConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public HardwareConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.HardwareConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB0A" +
           "AABIYXJkd2FyZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBtwYBAbcGtwYAAP////8XAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQG4BgAuAES4BgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQG5BgAuAES5BgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBugYA" +
           "LgBEugYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAbsGAC4ARLsGAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQG8BgAuAES8BgAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBvQYALgBEvQYAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBvwYALgBEvwYAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQHABgAuAETABgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBwQYALgBEwQYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBwgYALgBEwgYAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAcUGAC4ARMUGAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBxgYALgBE" +
           "xgYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBxwYALgBExwYAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEByAYALwEAIyPIBgAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAckGAC4ARMkGAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQHRBgAvAQAqI9EGAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAdIGAC4ARNIGAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEB0wYALwEAKiPTBgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQHUBgAuAETUBgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQHVBgAv" +
           "AQAqI9UGAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAdYGAC4A" +
           "RNYGAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB1wYALgBE1wYA" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAdgGAC8BAEQj2AYAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB2QYALwEAQyPZBgAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB2gYALwEARSPaBgAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAdsGAC4ARNsGAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAeAGAC8AP+AGAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEB4QYALwEAIyPhBgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAeIGAC4A" +
           "ROIGAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Linear_ForceConditionState Class
    #if (!OPCUA_EXCLUDE_Linear_ForceConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Linear_ForceConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Linear_ForceConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Linear_ForceConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACEA" +
           "AABMaW5lYXJfRm9yY2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAfoGAQH6BvoGAAD/////FwAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEB+wYALgBE+wYAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEB/AYALgBE/AYAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "Af0GAC4ARP0GAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQH+BgAuAET+" +
           "BgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEB/wYALgBE/wYAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQAHAC4ARAAHAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAQIHAC4ARAIHAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABTZXZlcml0eQEBAwcALgBEAwcAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBAQQHAC4ARAQHAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBAQUHAC4ARAUHAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQEIBwAuAEQIBwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAQkH" +
           "AC4ARAkHAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAQoHAC4ARAoHAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAQsHAC8BACMjCwcAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEMBwAuAEQMBwAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEBFAcALwEAKiMUBwAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQEVBwAuAEQVBwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBARYHAC8BACojFgcAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBFwcALgBEFwcAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "GAcALwEAKiMYBwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEZ" +
           "BwAuAEQZBwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBARoHAC4A" +
           "RBoHAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEbBwAvAQBEIxsHAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBARwHAC8BAEMjHAcAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAR0HAC8BAEUjHQcAAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEeBwAuAEQeBwAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQEjBwAvAD8jBwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBASQHAC8BACMjJAcAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEl" +
           "BwAuAEQlBwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LoadConditionState Class
    #if (!OPCUA_EXCLUDE_LoadConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public LoadConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.LoadConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABkA" +
           "AABMb2FkQ29uZGl0aW9uVHlwZUluc3RhbmNlAQE9BwEBPQc9BwAA/////xcAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAT4HAC4ARD4HAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AT8HAC4ARD8HAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFABwAuAERA" +
           "BwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBQQcALgBEQQcAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAUIHAC4AREIHAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFDBwAuAERDBwAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQFFBwAuAERFBwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBAUYHAC4AREYHAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFz" +
           "c0lkAQFHBwAuAERHBwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NO" +
           "YW1lAQFIBwAuAERIBwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB" +
           "SwcALgBESwcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFMBwAuAERMBwAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFNBwAuAERNBwAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFOBwAvAQAjI04HAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBTwcALgBETwcAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1" +
           "YWxpdHkBAVcHAC8BACojVwcAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBWAcALgBEWAcAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5" +
           "AQFZBwAvAQAqI1kHAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AVoHAC4ARFoHAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAVsHAC8BACoj" +
           "WwcAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBXAcALgBEXAcA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFdBwAuAERdBwAAAAz/" +
           "////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBXgcALwEARCNeBwAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFfBwAvAQBDI18HAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFgBwAvAQBFI2AHAAABAQEAAAABAPkLAAEADQsBAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBYQcALgBEYQcAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50" +
           "SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50" +
           "LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEBZgcALwA/ZgcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQFnBwAvAQAjI2cHAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBaAcALgBEaAcA" +
           "AAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Logic_ProgramConditionState Class
    #if (!OPCUA_EXCLUDE_Logic_ProgramConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Logic_ProgramConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Logic_ProgramConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Logic_ProgramConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACIA" +
           "AABMb2dpY19Qcm9ncmFtQ29uZGl0aW9uVHlwZUluc3RhbmNlAQGABwEBgAeABwAA/////xcAAAAVYIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBAYEHAC4ARIEHAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABF" +
           "dmVudFR5cGUBAYIHAC4ARIIHAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2Rl" +
           "AQGDBwAuAESDBwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBhAcALgBE" +
           "hAcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAYUHAC4ARIUHAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQGGBwAuAESGBwAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQGIBwAuAESIBwAAABX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAIAAAAU2V2ZXJpdHkBAYkHAC4ARIkHAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25k" +
           "aXRpb25DbGFzc0lkAQGKBwAuAESKBwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0" +
           "aW9uQ2xhc3NOYW1lAQGLBwAuAESLBwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0" +
           "aW9uTmFtZQEBjgcALgBEjgcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQGP" +
           "BwAuAESPBwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQGQBwAuAESQBwAAAAH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQGRBwAvAQAjI5EHAAAAFf////8B" +
           "Af////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBkgcALgBEkgcAAAAB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAFF1YWxpdHkBAZoHAC8BACojmgcAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBmwcALgBEmwcAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFz" +
           "dFNldmVyaXR5AQGcBwAvAQAqI5wHAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAZ0HAC4ARJ0HAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQB" +
           "AZ4HAC8BACojngcAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "nwcALgBEnwcAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQGgBwAu" +
           "AESgBwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBoQcALwEARCOhBwAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQGiBwAvAQBDI6IHAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQGjBwAvAQBFI6MHAAABAQEAAAABAPkLAAEA" +
           "DQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBpAcALgBEpAcAAJYCAAAAAQAqAQFGAAAA" +
           "BwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0" +
           "byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50" +
           "IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA4AAABNVEN1cnJlbnRTdGF0ZQEBqQcALwA/qQcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAA" +
           "AEFjdGl2ZVN0YXRlAQGqBwAvAQAjI6oHAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "qwcALgBEqwcAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MassConditionState Class
    #if (!OPCUA_EXCLUDE_MassConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MassConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public MassConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MassConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABkA" +
           "AABNYXNzQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHDBwEBwwfDBwAA/////xcAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAcQHAC4ARMQHAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AcUHAC4ARMUHAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHGBwAuAETG" +
           "BwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBxwcALgBExwcAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAcgHAC4ARMgHAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHJBwAuAETJBwAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQHLBwAuAETLBwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBAcwHAC4ARMwHAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFz" +
           "c0lkAQHNBwAuAETNBwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NO" +
           "YW1lAQHOBwAuAETOBwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB" +
           "0QcALgBE0QcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQHSBwAuAETSBwAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHTBwAuAETTBwAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHUBwAvAQAjI9QHAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEB1QcALgBE1QcAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1" +
           "YWxpdHkBAd0HAC8BACoj3QcAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEB3gcALgBE3gcAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5" +
           "AQHfBwAvAQAqI98HAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AeAHAC4AROAHAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAeEHAC8BACoj" +
           "4QcAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB4gcALgBE4gcA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHjBwAuAETjBwAAAAz/" +
           "////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB5AcALwEARCPkBwAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHlBwAvAQBDI+UHAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHmBwAvAQBFI+YHAAABAQEAAAABAPkLAAEADQsBAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB5wcALgBE5wcAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50" +
           "SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50" +
           "LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEB7AcALwA/7AcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQHtBwAvAQAjI+0HAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB7gcALgBE7gcA" +
           "AAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Motion_ProgramConditionState Class
    #if (!OPCUA_EXCLUDE_Motion_ProgramConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Motion_ProgramConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Motion_ProgramConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Motion_ProgramConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACMA" +
           "AABNb3Rpb25fUHJvZ3JhbUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBBggBAQYIBggAAP////8XAAAAFWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQEHCAAuAEQHCAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQEICAAuAEQICAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQEBCQgALgBECQgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAQoIAC4A" +
           "RAoIAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQELCAAuAEQLCAAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBDAgALgBEDAgAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBDggALgBEDggAAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAACAAAAFNldmVyaXR5AQEPCAAuAEQPCAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBEAgALgBEEAgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBEQgALgBEEQgAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBARQIAC4ARBQIAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "FQgALgBEFQgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBFggALgBEFggAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBFwgALwEAIyMXCAAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBARgIAC4ARBgIAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQEgCAAvAQAqIyAIAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABASEIAC4ARCEIAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBIggALwEAKiMiCAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQEjCAAuAEQjCAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQEkCAAvAQAqIyQIAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "ASUIAC4ARCUIAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBJggA" +
           "LgBEJggAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAScIAC8BAEQjJwgAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBKAgALwEAQyMoCAAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBKQgALwEARSMpCAAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBASoIAC4ARCoIAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAS8IAC8APy8IAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBMAgALwEAIyMwCAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "ATEIAC4ARDEIAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Path_FeedrateConditionState Class
    #if (!OPCUA_EXCLUDE_Path_FeedrateConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Path_FeedrateConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Path_FeedrateConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Path_FeedrateConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACIA" +
           "AABQYXRoX0ZlZWRyYXRlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFJCAEBSQhJCAAA/////xcAAAAVYIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBAUoIAC4AREoIAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABF" +
           "dmVudFR5cGUBAUsIAC4AREsIAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2Rl" +
           "AQFMCAAuAERMCAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBTQgALgBE" +
           "TQgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAU4IAC4ARE4IAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFPCAAuAERPCAAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQFRCAAuAERRCAAAABX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAIAAAAU2V2ZXJpdHkBAVIIAC4ARFIIAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25k" +
           "aXRpb25DbGFzc0lkAQFTCAAuAERTCAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0" +
           "aW9uQ2xhc3NOYW1lAQFUCAAuAERUCAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0" +
           "aW9uTmFtZQEBVwgALgBEVwgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFY" +
           "CAAuAERYCAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFZCAAuAERZCAAAAAH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFaCAAvAQAjI1oIAAAAFf////8B" +
           "Af////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBWwgALgBEWwgAAAAB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAFF1YWxpdHkBAWMIAC8BACojYwgAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBZAgALgBEZAgAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFz" +
           "dFNldmVyaXR5AQFlCAAvAQAqI2UIAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAWYIAC4ARGYIAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQB" +
           "AWcIAC8BACojZwgAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "aAgALgBEaAgAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFpCAAu" +
           "AERpCAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBaggALwEARCNqCAAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFrCAAvAQBDI2sIAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFsCAAvAQBFI2wIAAABAQEAAAABAPkLAAEA" +
           "DQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBbQgALgBEbQgAAJYCAAAAAQAqAQFGAAAA" +
           "BwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0" +
           "byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50" +
           "IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA4AAABNVEN1cnJlbnRTdGF0ZQEBcggALwA/cggAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAA" +
           "AEFjdGl2ZVN0YXRlAQFzCAAvAQAjI3MIAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "dAgALgBEdAgAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Path_PositionConditionState Class
    #if (!OPCUA_EXCLUDE_Path_PositionConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Path_PositionConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Path_PositionConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Path_PositionConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACIA" +
           "AABQYXRoX1Bvc2l0aW9uQ29uZGl0aW9uVHlwZUluc3RhbmNlAQGMCAEBjAiMCAAA/////xcAAAAVYIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBAY0IAC4ARI0IAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABF" +
           "dmVudFR5cGUBAY4IAC4ARI4IAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2Rl" +
           "AQGPCAAuAESPCAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBkAgALgBE" +
           "kAgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAZEIAC4ARJEIAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQGSCAAuAESSCAAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQGUCAAuAESUCAAAABX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAIAAAAU2V2ZXJpdHkBAZUIAC4ARJUIAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25k" +
           "aXRpb25DbGFzc0lkAQGWCAAuAESWCAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0" +
           "aW9uQ2xhc3NOYW1lAQGXCAAuAESXCAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0" +
           "aW9uTmFtZQEBmggALgBEmggAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQGb" +
           "CAAuAESbCAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQGcCAAuAEScCAAAAAH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQGdCAAvAQAjI50IAAAAFf////8B" +
           "Af////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBnggALgBEnggAAAAB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAFF1YWxpdHkBAaYIAC8BACojpggAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBpwgALgBEpwgAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFz" +
           "dFNldmVyaXR5AQGoCAAvAQAqI6gIAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAakIAC4ARKkIAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQB" +
           "AaoIAC8BACojqggAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "qwgALgBEqwgAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQGsCAAu" +
           "AESsCAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBrQgALwEARCOtCAAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQGuCAAvAQBDI64IAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQGvCAAvAQBFI68IAAABAQEAAAABAPkLAAEA" +
           "DQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBsAgALgBEsAgAAJYCAAAAAQAqAQFGAAAA" +
           "BwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0" +
           "byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50" +
           "IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA4AAABNVEN1cnJlbnRTdGF0ZQEBtQgALwA/tQgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAA" +
           "AEFjdGl2ZVN0YXRlAQG2CAAvAQAjI7YIAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "twgALgBEtwgAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PHConditionState Class
    #if (!OPCUA_EXCLUDE_PHConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PHConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public PHConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.PHConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABcA" +
           "AABQSENvbmRpdGlvblR5cGVJbnN0YW5jZQEBzwgBAc8IzwgAAP////8XAAAAFWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQHQCAAuAETQCAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQHR" +
           "CAAuAETRCAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB0ggALgBE0ggA" +
           "AAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAdMIAC4ARNMIAAAADP////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQHUCAAuAETUCAAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAsAAABSZWNlaXZlVGltZQEB1QgALgBE1QgAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEB1wgALgBE1wgAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVy" +
           "aXR5AQHYCAAuAETYCAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJ" +
           "ZAEB2QgALgBE2QgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNsYXNzTmFt" +
           "ZQEB2ggALgBE2ggAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5hbWUBAd0I" +
           "AC4ARN0IAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB3ggALgBE3ggAAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB3wgALgBE3wgAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB4AgALwEAIyPgCAAAABX/////AQH/////AQAAABVg" +
           "iQoCAAAAAAACAAAASWQBAeEIAC4AROEIAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABRdWFs" +
           "aXR5AQHpCAAvAQAqI+kIAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAeoIAC4AROoIAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZlcml0eQEB" +
           "6wgALwEAKiPrCAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHs" +
           "CAAuAETsCAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQHtCAAvAQAqI+0I" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAe4IAC4ARO4IAAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB7wgALgBE7wgAAAAM////" +
           "/wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAfAIAC8BAEQj8AgAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB8QgALwEAQyPxCAAAAQEBAAAAAQD5CwABAPMKAAAAAARh" +
           "ggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB8ggALwEARSPyCAAAAQEBAAAAAQD5CwABAA0LAQAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfMIAC4ARPMIAACWAgAAAAEAKgEBRgAAAAcAAABFdmVudElk" +
           "AA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29tbWVudC4B" +
           "ACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBhZGQgdG8g" +
           "dGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJy" +
           "ZW50U3RhdGUBAfgIAC8AP/gIAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0" +
           "ZQEB+QgALwEAIyP5CAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAfoIAC4ARPoIAAAA" +
           "Af////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PositionConditionState Class
    #if (!OPCUA_EXCLUDE_PositionConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PositionConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public PositionConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.PositionConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB0A" +
           "AABQb3NpdGlvbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBEgkBARIJEgkAAP////8XAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQETCQAuAEQTCQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQEUCQAuAEQUCQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBFQkA" +
           "LgBEFQkAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBARYJAC4ARBYJAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEXCQAuAEQXCQAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBGAkALgBEGAkAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBGgkALgBEGgkAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQEbCQAuAEQbCQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBHAkALgBEHAkAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBHQkALgBEHQkAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBASAJAC4ARCAJAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBIQkALgBE" +
           "IQkAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBIgkALgBEIgkAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBIwkALwEAIyMjCQAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBASQJAC4ARCQJAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQEsCQAvAQAqIywJAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAS0JAC4ARC0JAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEBLgkALwEAKiMuCQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQEvCQAuAEQvCQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQEwCQAv" +
           "AQAqIzAJAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABATEJAC4A" +
           "RDEJAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBMgkALgBEMgkA" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBATMJAC8BAEQjMwkAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBNAkALwEAQyM0CQAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBNQkALwEARSM1CQAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATYJAC4ARDYJAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBATsJAC8APzsJAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBPAkALwEAIyM8CQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAT0JAC4A" +
           "RD0JAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Power_FactorConditionState Class
    #if (!OPCUA_EXCLUDE_Power_FactorConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Power_FactorConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Power_FactorConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Power_FactorConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACEA" +
           "AABQb3dlcl9GYWN0b3JDb25kaXRpb25UeXBlSW5zdGFuY2UBAVUJAQFVCVUJAAD/////FwAAABVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBVgkALgBEVgkAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2" +
           "ZW50VHlwZQEBVwkALgBEVwkAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AVgJAC4ARFgJAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFZCQAuAERZ" +
           "CQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBWgkALgBEWgkAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAVsJAC4ARFsJAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAV0JAC4ARF0JAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAgAAABTZXZlcml0eQEBXgkALgBEXgkAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBAV8JAC4ARF8JAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBAWAJAC4ARGAJAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQFjCQAuAERjCQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAWQJ" +
           "AC4ARGQJAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAWUJAC4ARGUJAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAWYJAC8BACMjZgkAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFnCQAuAERnCQAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEBbwkALwEAKiNvCQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQFwCQAuAERwCQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBAXEJAC8BACojcQkAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBcgkALgBEcgkAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "cwkALwEAKiNzCQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQF0" +
           "CQAuAER0CQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAXUJAC4A" +
           "RHUJAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQF2CQAvAQBEI3YJAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAXcJAC8BAEMjdwkAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAXgJAC8BAEUjeAkAAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF5CQAuAER5CQAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQF+CQAvAD9+CQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAX8JAC8BACMjfwkAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGA" +
           "CQAuAESACQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PressureConditionState Class
    #if (!OPCUA_EXCLUDE_PressureConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PressureConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public PressureConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.PressureConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB0A" +
           "AABQcmVzc3VyZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBmAkBAZgJmAkAAP////8XAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQGZCQAuAESZCQAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQGaCQAuAESaCQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBmwkA" +
           "LgBEmwkAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAZwJAC4ARJwJAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQGdCQAuAESdCQAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBngkALgBEngkAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEBoAkALgBEoAkAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQGhCQAuAEShCQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEBogkALgBEogkAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEBowkALgBEowkAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAaYJAC4ARKYJAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBpwkALgBE" +
           "pwkAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBqAkALgBEqAkAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBqQkALwEAIyOpCQAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAaoJAC4ARKoJAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQGyCQAvAQAqI7IJAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAbMJAC4ARLMJAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEBtAkALwEAKiO0CQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQG1CQAuAES1CQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQG2CQAv" +
           "AQAqI7YJAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAbcJAC4A" +
           "RLcJAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBuAkALgBEuAkA" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAbkJAC8BAEQjuQkAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBugkALwEAQyO6CQAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBuwkALwEARSO7CQAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbwJAC4ARLwJAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAcEJAC8AP8EJAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBwgkALwEAIyPCCQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAcMJAC4A" +
           "RMMJAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ResistanceConditionState Class
    #if (!OPCUA_EXCLUDE_ResistanceConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResistanceConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public ResistanceConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.ResistanceConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB8A" +
           "AABSZXNpc3RhbmNlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHbCQEB2wnbCQAA/////xcAAAAVYIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAdwJAC4ARNwJAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAd0JAC4ARN0JAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHe" +
           "CQAuAETeCQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB3wkALgBE3wkA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAeAJAC4AROAJAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHhCQAuAEThCQAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABNZXNzYWdlAQHjCQAuAETjCQAAABX/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAU2V2ZXJpdHkBAeQJAC4AROQJAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRp" +
           "b25DbGFzc0lkAQHlCQAuAETlCQAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9u" +
           "Q2xhc3NOYW1lAQHmCQAuAETmCQAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9u" +
           "TmFtZQEB6QkALgBE6QkAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQHqCQAu" +
           "AETqCQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHrCQAuAETrCQAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHsCQAvAQAjI+wJAAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEB7QkALgBE7QkAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAFF1YWxpdHkBAfUJAC8BACoj9QkAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEB9gkALgBE9gkAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNl" +
           "dmVyaXR5AQH3CQAvAQAqI/cJAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAfgJAC4ARPgJAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAfkJ" +
           "AC8BACoj+QkAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB+gkA" +
           "LgBE+gkAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQH7CQAuAET7" +
           "CQAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB/AkALwEARCP8CQAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQH9CQAvAQBDI/0JAAABAQEAAAABAPkLAAEA" +
           "8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQH+CQAvAQBFI/4JAAABAQEAAAABAPkLAAEADQsB" +
           "AAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB/wkALgBE/wkAAJYCAAAAAQAqAQFGAAAABwAA" +
           "AEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBj" +
           "b21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRv" +
           "IGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBBAoALwA/BAoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQEFCgAvAQAjIwUKAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBBgoA" +
           "LgBEBgoAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Rotary_VelocityConditionState Class
    #if (!OPCUA_EXCLUDE_Rotary_VelocityConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Rotary_VelocityConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Rotary_VelocityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Rotary_VelocityConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACQA" +
           "AABSb3RhcnlfVmVsb2NpdHlDb25kaXRpb25UeXBlSW5zdGFuY2UBAR4KAQEeCh4KAAD/////FwAAABVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEBHwoALgBEHwoAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAA" +
           "AEV2ZW50VHlwZQEBIAoALgBEIAoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5v" +
           "ZGUBASEKAC4ARCEKAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEiCgAu" +
           "AEQiCgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBIwoALgBEIwoAAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBASQKAC4ARCQKAAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBASYKAC4ARCYKAAAAFf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAgAAABTZXZlcml0eQEBJwoALgBEJwoAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENv" +
           "bmRpdGlvbkNsYXNzSWQBASgKAC4ARCgKAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25k" +
           "aXRpb25DbGFzc05hbWUBASkKAC4ARCkKAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25k" +
           "aXRpb25OYW1lAQEsCgAuAEQsCgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQB" +
           "AS0KAC4ARC0KAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAS4KAC4ARC4KAAAA" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAS8KAC8BACMjLwoAAAAV////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEwCgAuAEQwCgAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAAUXVhbGl0eQEBOAoALwEAKiM4CgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQE5CgAuAEQ5CgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABM" +
           "YXN0U2V2ZXJpdHkBAToKAC8BACojOgoAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBOwoALgBEOwoAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVu" +
           "dAEBPAoALwEAKiM8CgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQE9CgAuAEQ9CgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAT4K" +
           "AC4ARD4KAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQE/CgAvAQBEIz8KAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAUAKAC8BAEMjQAoAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAUEKAC8BAEUjQQoAAAEBAQAAAAEA+QsA" +
           "AQANCwEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFCCgAuAERCCgAAlgIAAAABACoBAUYA" +
           "AAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50" +
           "IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1l" +
           "bnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQFHCgAvAD9HCgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAUgKAC8BACMjSAoAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQFJCgAuAERJCgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Sound_LevelConditionState Class
    #if (!OPCUA_EXCLUDE_Sound_LevelConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Sound_LevelConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Sound_LevelConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Sound_LevelConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACAA" +
           "AABTb3VuZF9MZXZlbENvbmRpdGlvblR5cGVJbnN0YW5jZQEBYQoBAWEKYQoAAP////8XAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQFiCgAuAERiCgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQFjCgAuAERjCgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "ZAoALgBEZAoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAWUKAC4ARGUK" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQFmCgAuAERmCgAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBZwoALgBEZwoAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBaQoALgBEaQoAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CAAAAFNldmVyaXR5AQFqCgAuAERqCgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0" +
           "aW9uQ2xhc3NJZAEBawoALgBEawoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlv" +
           "bkNsYXNzTmFtZQEBbAoALgBEbAoAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlv" +
           "bk5hbWUBAW8KAC4ARG8KAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBcAoA" +
           "LgBEcAoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBcQoALgBEcQoAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBcgoALwEAIyNyCgAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBAXMKAC4ARHMKAAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABRdWFsaXR5AQF7CgAvAQAqI3sKAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAXwKAC4ARHwKAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RT" +
           "ZXZlcml0eQEBfQoALwEAKiN9CgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQF+CgAuAER+CgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQF/" +
           "CgAvAQAqI38KAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAYAK" +
           "AC4ARIAKAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBgQoALgBE" +
           "gQoAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAYIKAC8BAEQjggoAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBgwoALwEAQyODCgAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBhAoALwEARSOECgAAAQEBAAAAAQD5CwABAA0L" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYUKAC4ARIUKAACWAgAAAAEAKgEBRgAAAAcA" +
           "AABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8g" +
           "Y29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0" +
           "byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAYoKAC8AP4oKAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEBiwoALwEAIyOLCgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAYwK" +
           "AC4ARIwKAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region StrainConditionState Class
    #if (!OPCUA_EXCLUDE_StrainConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StrainConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public StrainConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.StrainConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABsA" +
           "AABTdHJhaW5Db25kaXRpb25UeXBlSW5zdGFuY2UBAaQKAQGkCqQKAAD/////FwAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBpQoALgBEpQoAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBpgoALgBEpgoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAacKAC4A" +
           "RKcKAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGoCgAuAESoCgAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBqQoALgBEqQoAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAaoKAC4ARKoKAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAawKAC4ARKwKAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEBrQoALgBErQoAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNs" +
           "YXNzSWQBAa4KAC4ARK4KAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFz" +
           "c05hbWUBAa8KAC4ARK8KAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1l" +
           "AQGyCgAuAESyCgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAbMKAC4ARLMK" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAbQKAC4ARLQKAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAbUKAC8BACMjtQoAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQG2CgAuAES2CgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "UXVhbGl0eQEBvgoALwEAKiO+CgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQG/CgAuAES/CgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJp" +
           "dHkBAcAKAC8BACojwAoAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBwQoALgBEwQoAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBwgoALwEA" +
           "KiPCCgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHDCgAuAETD" +
           "CgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAcQKAC4ARMQKAAAA" +
           "DP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHFCgAvAQBEI8UKAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAcYKAC8BAEMjxgoAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAccKAC8BAEUjxwoAAAEBAQAAAAEA+QsAAQANCwEAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHICgAuAETICgAAlgIAAAABACoBAUYAAAAHAAAARXZl" +
           "bnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1l" +
           "bnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQHNCgAvAD/NCgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAc4KAC8BACMjzgoAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHPCgAuAETP" +
           "CgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SystemConditionState Class
    #if (!OPCUA_EXCLUDE_SystemConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SystemConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public SystemConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.SystemConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABsA" +
           "AABTeXN0ZW1Db25kaXRpb25UeXBlSW5zdGFuY2UBAecKAQHnCucKAAD/////FwAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEB6AoALgBE6AoAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEB6QoALgBE6QoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAeoKAC4A" +
           "ROoKAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHrCgAuAETrCgAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEB7AoALgBE7AoAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAe0KAC4ARO0KAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAe8KAC4ARO8KAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEB8AoALgBE8AoAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNs" +
           "YXNzSWQBAfEKAC4ARPEKAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFz" +
           "c05hbWUBAfIKAC4ARPIKAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1l" +
           "AQH1CgAuAET1CgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAfYKAC4ARPYK" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAfcKAC4ARPcKAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAfgKAC8BACMj+AoAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQH5CgAuAET5CgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "UXVhbGl0eQEBAQsALwEAKiMBCwAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQECCwAuAEQCCwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJp" +
           "dHkBAQMLAC8BACojAwsAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBBAsALgBEBAsAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBBQsALwEA" +
           "KiMFCwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEGCwAuAEQG" +
           "CwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAQcLAC4ARAcLAAAA" +
           "DP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQEICwAvAQBEIwgLAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAQkLAC8BAEMjCQsAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAQoLAC8BAEUjCgsAAAEBAQAAAAEA+QsAAQANCwEAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQELCwAuAEQLCwAAlgIAAAABACoBAUYAAAAHAAAARXZl" +
           "bnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1l" +
           "bnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQEQCwAvAD8QCwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBARELAC8BACMjEQsAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQESCwAuAEQS" +
           "CwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TemperatureConditionState Class
    #if (!OPCUA_EXCLUDE_TemperatureConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public TemperatureConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.TemperatureConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACAA" +
           "AABUZW1wZXJhdHVyZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBKgsBASoLKgsAAP////8XAAAAFWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQErCwAuAEQrCwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAQEsCwAuAEQsCwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "LQsALgBELQsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAS4LAC4ARC4L" +
           "AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEvCwAuAEQvCwAAAQAmAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBMAsALgBEMAsAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBMgsALgBEMgsAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "CAAAAFNldmVyaXR5AQEzCwAuAEQzCwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0" +
           "aW9uQ2xhc3NJZAEBNAsALgBENAsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlv" +
           "bkNsYXNzTmFtZQEBNQsALgBENQsAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlv" +
           "bk5hbWUBATgLAC4ARDgLAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBOQsA" +
           "LgBEOQsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBOgsALgBEOgsAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBOwsALwEAIyM7CwAAABX/////AQH/" +
           "////AQAAABVgiQoCAAAAAAACAAAASWQBATwLAC4ARDwLAAAAAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABRdWFsaXR5AQFECwAvAQAqI0QLAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAUULAC4AREULAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RT" +
           "ZXZlcml0eQEBRgsALwEAKiNGCwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQFHCwAuAERHCwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQFI" +
           "CwAvAQAqI0gLAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAUkL" +
           "AC4AREkLAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBSgsALgBE" +
           "SgsAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAUsLAC8BAEQjSwsAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBTAsALwEAQyNMCwAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBTQsALwEARSNNCwAAAQEBAAAAAQD5CwABAA0L" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAU4LAC4ARE4LAACWAgAAAAEAKgEBRgAAAAcA" +
           "AABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8g" +
           "Y29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0" +
           "byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAVMLAC8AP1MLAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEBVAsALwEAIyNUCwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAVUL" +
           "AC4ARFULAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TiltConditionState Class
    #if (!OPCUA_EXCLUDE_TiltConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TiltConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public TiltConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.TiltConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABkA" +
           "AABUaWx0Q29uZGl0aW9uVHlwZUluc3RhbmNlAQFtCwEBbQttCwAA/////xcAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAW4LAC4ARG4LAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AW8LAC4ARG8LAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFwCwAuAERw" +
           "CwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBcQsALgBEcQsAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAXILAC4ARHILAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFzCwAuAERzCwAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQF1CwAuAER1CwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBAXYLAC4ARHYLAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFz" +
           "c0lkAQF3CwAuAER3CwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NO" +
           "YW1lAQF4CwAuAER4CwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEB" +
           "ewsALgBEewsAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQF8CwAuAER8CwAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQF9CwAuAER9CwAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQF+CwAvAQAjI34LAAAAFf////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBfwsALgBEfwsAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1" +
           "YWxpdHkBAYcLAC8BACojhwsAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBiAsALgBEiAsAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5" +
           "AQGJCwAvAQAqI4kLAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AYoLAC4ARIoLAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAYsLAC8BACoj" +
           "iwsAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBjAsALgBEjAsA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQGNCwAuAESNCwAAAAz/" +
           "////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBjgsALwEARCOOCwAAAQEBAAAAAQD5CwAB" +
           "APMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQGPCwAvAQBDI48LAAABAQEAAAABAPkLAAEA8woAAAAA" +
           "BGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQGQCwAvAQBFI5ALAAABAQEAAAABAPkLAAEADQsBAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBkQsALgBEkQsAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50" +
           "SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50" +
           "LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0" +
           "byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEBlgsALwA/lgsAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQGXCwAvAQAjI5cLAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBmAsALgBEmAsA" +
           "AAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TorqueConditionState Class
    #if (!OPCUA_EXCLUDE_TorqueConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TorqueConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public TorqueConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.TorqueConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABsA" +
           "AABUb3JxdWVDb25kaXRpb25UeXBlSW5zdGFuY2UBAbALAQGwC7ALAAD/////FwAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBsQsALgBEsQsAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBsgsALgBEsgsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAbMLAC4A" +
           "RLMLAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQG0CwAuAES0CwAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBtQsALgBEtQsAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAbYLAC4ARLYLAAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAbgLAC4ARLgLAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEBuQsALgBEuQsAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlvbkNs" +
           "YXNzSWQBAboLAC4ARLoLAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25DbGFz" +
           "c05hbWUBAbsLAC4ARLsLAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25OYW1l" +
           "AQG+CwAuAES+CwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAb8LAC4ARL8L" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAcALAC4ARMALAAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAcELAC8BACMjwQsAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQHCCwAuAETCCwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "UXVhbGl0eQEBygsALwEAKiPKCwAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQHLCwAuAETLCwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJp" +
           "dHkBAcwLAC8BACojzAsAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBzQsALgBEzQsAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBzgsALwEA" +
           "KiPOCwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHPCwAuAETP" +
           "CwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAdALAC4ARNALAAAA" +
           "DP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHRCwAvAQBEI9ELAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAdILAC8BAEMj0gsAAAEBAQAAAAEA+QsAAQDzCgAA" +
           "AAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAdMLAC8BAEUj0wsAAAEBAQAAAAEA+QsAAQANCwEAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHUCwAuAETUCwAAlgIAAAABACoBAUYAAAAHAAAARXZl" +
           "bnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1l" +
           "bnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRk" +
           "IHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQHZCwAvAD/ZCwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAdoLAC8BACMj2gsAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHbCwAuAETb" +
           "CwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VelocityConditionState Class
    #if (!OPCUA_EXCLUDE_VelocityConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VelocityConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public VelocityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.VelocityConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB0A" +
           "AABWZWxvY2l0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEB8wsBAfML8wsAAP////8XAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQH0CwAuAET0CwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRU" +
           "eXBlAQH1CwAuAET1CwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB9gsA" +
           "LgBE9gsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAfcLAC4ARPcLAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQH4CwAuAET4CwAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB+QsALgBE+QsAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAATWVzc2FnZQEB+wsALgBE+wsAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AFNldmVyaXR5AQH8CwAuAET8CwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29uZGl0aW9u" +
           "Q2xhc3NJZAEB/QsALgBE/QsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRpdGlvbkNs" +
           "YXNzTmFtZQEB/gsALgBE/gsAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRpdGlvbk5h" +
           "bWUBAQEMAC4ARAEMAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEBAgwALgBE" +
           "AgwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBAwwALgBEAwwAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBBAwALwEAIyMEDAAAABX/////AQH/////" +
           "AQAAABVgiQoCAAAAAAACAAAASWQBAQUMAC4ARAUMAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABRdWFsaXR5AQENDAAvAQAqIw0MAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAQ4MAC4ARA4MAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExhc3RTZXZl" +
           "cml0eQEBDwwALwEAKiMPDAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQEQDAAuAEQQDAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50AQERDAAv" +
           "AQAqIxEMAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABARIMAC4A" +
           "RBIMAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBEwwALgBEEwwA" +
           "AAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBARQMAC8BAEQjFAwAAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBFQwALwEAQyMVDAAAAQEBAAAAAQD5CwABAPMK" +
           "AAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBFgwALwEARSMWDAAAAQEBAAAAAQD5CwABAA0LAQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBARcMAC4ARBcMAACWAgAAAAEAKgEBRgAAAAcAAABF" +
           "dmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdG8gY29t" +
           "bWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVudCB0byBh" +
           "ZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBARwMAC8APxwMAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBHQwALwEAIyMdDAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAR4MAC4A" +
           "RB4MAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ViscosityConditionState Class
    #if (!OPCUA_EXCLUDE_ViscosityConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ViscosityConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public ViscosityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.ViscosityConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB4A" +
           "AABWaXNjb3NpdHlDb25kaXRpb25UeXBlSW5zdGFuY2UBATYMAQE2DDYMAAD/////FwAAABVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEBNwwALgBENwwAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50" +
           "VHlwZQEBOAwALgBEOAwAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBATkM" +
           "AC4ARDkMAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQE6DAAuAEQ6DAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBOwwALgBEOwwAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBATwMAC4ARDwMAAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAE1lc3NhZ2UBAT4MAC4ARD4MAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABTZXZlcml0eQEBPwwALgBEPwwAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRpdGlv" +
           "bkNsYXNzSWQBAUAMAC4AREAMAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRpb25D" +
           "bGFzc05hbWUBAUEMAC4AREEMAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRpb25O" +
           "YW1lAQFEDAAuAEREDAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAUUMAC4A" +
           "REUMAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAUYMAC4AREYMAAAAAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAUcMAC8BACMjRwwAAAAV/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAAAgAAAElkAQFIDAAuAERIDAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAUXVhbGl0eQEBUAwALwEAKiNQDAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQFRDAAuAERRDAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0U2V2" +
           "ZXJpdHkBAVIMAC8BACojUgwAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBUwwALgBEUwwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEBVAwA" +
           "LwEAKiNUDAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFVDAAu" +
           "AERVDAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAVYMAC4ARFYM" +
           "AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFXDAAvAQBEI1cMAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAVgMAC8BAEMjWAwAAAEBAQAAAAEA+QsAAQDz" +
           "CgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAVkMAC8BAEUjWQwAAAEBAQAAAAEA+QsAAQANCwEA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFaDAAuAERaDAAAlgIAAAABACoBAUYAAAAHAAAA" +
           "RXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNv" +
           "bW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8g" +
           "YWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQFfDAAvAD9fDAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBAWAMAC8BACMjYAwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFhDAAu" +
           "AERhDAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VoltageConditionState Class
    #if (!OPCUA_EXCLUDE_VoltageConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltageConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public VoltageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.VoltageConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABwA" +
           "AABWb2x0YWdlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQF5DAEBeQx5DAAA/////xcAAAAVYIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBAXoMAC4ARHoMAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5" +
           "cGUBAXsMAC4ARHsMAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQF8DAAu" +
           "AER8DAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBfQwALgBEfQwAAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAX4MAC4ARH4MAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQF/DAAuAER/DAAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABNZXNzYWdlAQGBDAAuAESBDAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBAYIMAC4ARIIMAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25D" +
           "bGFzc0lkAQGDDAAuAESDDAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xh" +
           "c3NOYW1lAQGEDAAuAESEDAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFt" +
           "ZQEBhwwALgBEhwwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQGIDAAuAESI" +
           "DAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQGJDAAuAESJDAAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQGKDAAvAQAjI4oMAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEBiwwALgBEiwwAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AFF1YWxpdHkBAZMMAC8BACojkwwAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBlAwALgBElAwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVy" +
           "aXR5AQGVDAAvAQAqI5UMAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAZYMAC4ARJYMAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAZcMAC8B" +
           "ACojlwwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBmAwALgBE" +
           "mAwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQGZDAAuAESZDAAA" +
           "AAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBmgwALwEARCOaDAAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQGbDAAvAQBDI5sMAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQGcDAAvAQBFI5wMAAABAQEAAAABAPkLAAEADQsBAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBnQwALgBEnQwAAJYCAAAAAQAqAQFGAAAABwAAAEV2" +
           "ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21t" +
           "ZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFk" +
           "ZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBogwALwA/ogwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQGjDAAvAQAjI6MMAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBpAwALgBE" +
           "pAwAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Volt_AmperageConditionState Class
    #if (!OPCUA_EXCLUDE_Volt_AmperageConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Volt_AmperageConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public Volt_AmperageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.Volt_AmperageConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACIA" +
           "AABWb2x0X0FtcGVyYWdlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQG8DAEBvAy8DAAA/////xcAAAAVYIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBAb0MAC4ARL0MAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABF" +
           "dmVudFR5cGUBAb4MAC4ARL4MAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2Rl" +
           "AQG/DAAuAES/DAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBwAwALgBE" +
           "wAwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAcEMAC4ARMEMAAABACYB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHCDAAuAETCDAAAAQAmAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQHEDAAuAETEDAAAABX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAIAAAAU2V2ZXJpdHkBAcUMAC4ARMUMAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25k" +
           "aXRpb25DbGFzc0lkAQHGDAAuAETGDAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0" +
           "aW9uQ2xhc3NOYW1lAQHHDAAuAETHDAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0" +
           "aW9uTmFtZQEBygwALgBEygwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQHL" +
           "DAAuAETLDAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHMDAAuAETMDAAAAAH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHNDAAvAQAjI80MAAAAFf////8B" +
           "Af////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBzgwALgBEzgwAAAAB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAFF1YWxpdHkBAdYMAC8BACoj1gwAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEB1wwALgBE1wwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFz" +
           "dFNldmVyaXR5AQHYDAAvAQAqI9gMAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAdkMAC4ARNkMAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQB" +
           "AdoMAC8BACoj2gwAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "2wwALgBE2wwAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQHcDAAu" +
           "AETcDAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB3QwALwEARCPdDAAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHeDAAvAQBDI94MAAABAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHfDAAvAQBFI98MAAABAQEAAAABAPkLAAEA" +
           "DQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB4AwALgBE4AwAAJYCAAAAAQAqAQFGAAAA" +
           "BwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0" +
           "byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50" +
           "IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA4AAABNVEN1cnJlbnRTdGF0ZQEB5QwALwA/5QwAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAA" +
           "AEFjdGl2ZVN0YXRlAQHmDAAvAQAjI+YMAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "5wwALgBE5wwAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VoltAmperageReactiveConditionState Class
    #if (!OPCUA_EXCLUDE_VoltAmperageReactiveConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltAmperageReactiveConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public VoltAmperageReactiveConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.VoltAmperageReactiveConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACkA" +
           "AABWb2x0QW1wZXJhZ2VSZWFjdGl2ZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEB/wwBAf8M/wwAAP////8X" +
           "AAAAFWCJCgIAAAAAAAcAAABFdmVudElkAQEADQAuAEQADQAAAA//////AQH/////AAAAABVgiQoCAAAA" +
           "AAAJAAAARXZlbnRUeXBlAQEBDQAuAEQBDQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291" +
           "cmNlTm9kZQEBAg0ALgBEAg0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUB" +
           "AQMNAC4ARAMNAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEEDQAuAEQEDQAAAQAm" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBBQ0ALgBEBQ0AAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBBw0ALgBEBw0AAAAV/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACAAAAFNldmVyaXR5AQEIDQAuAEQIDQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAAQ29uZGl0aW9uQ2xhc3NJZAEBCQ0ALgBECQ0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAA" +
           "AENvbmRpdGlvbkNsYXNzTmFtZQEBCg0ALgBECg0AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAA" +
           "AENvbmRpdGlvbk5hbWUBAQ0NAC4ARA0NAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFu" +
           "Y2hJZAEBDg0ALgBEDg0AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBDw0ALgBE" +
           "Dw0AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBEA0ALwEAIyMQDQAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBARENAC4ARBENAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABRdWFsaXR5AQEZDQAvAQAqIxkNAAAAE/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABARoNAC4ARBoNAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DAAAAExhc3RTZXZlcml0eQEBGw0ALwEAKiMbDQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQEcDQAuAEQcDQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABD" +
           "b21tZW50AQEdDQAvAQAqIx0NAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAR4NAC4ARB4NAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJ" +
           "ZAEBHw0ALgBEHw0AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBASANAC8BAEQj" +
           "IA0AAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBIQ0ALwEAQyMhDQAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBIg0ALwEARSMiDQAAAQEBAAAA" +
           "AQD5CwABAA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBASMNAC4ARCMNAACWAgAAAAEA" +
           "KgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUg" +
           "Y29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVg" +
           "iQoCAAAAAQAOAAAATVRDdXJyZW50U3RhdGUBASgNAC8APygNAAAADP////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAsAAABBY3RpdmVTdGF0ZQEBKQ0ALwEAIyMpDQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAC" +
           "AAAASWQBASoNAC4ARCoNAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region WattageConditionState Class
    #if (!OPCUA_EXCLUDE_WattageConditionState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WattageConditionState : MTConditionState
    {
        #region Constructors
        /// <remarks />
        public WattageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.WattageConditionType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABwA" +
           "AABXYXR0YWdlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFCDQEBQg1CDQAA/////xcAAAAVYIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBAUMNAC4AREMNAAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5" +
           "cGUBAUQNAC4AREQNAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFFDQAu" +
           "AERFDQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBRg0ALgBERg0AAAAM" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAUcNAC4AREcNAAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFIDQAuAERIDQAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABNZXNzYWdlAQFKDQAuAERKDQAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBAUsNAC4AREsNAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25D" +
           "bGFzc0lkAQFMDQAuAERMDQAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xh" +
           "c3NOYW1lAQFNDQAuAERNDQAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFt" +
           "ZQEBUA0ALgBEUA0AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQFRDQAuAERR" +
           "DQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFSDQAuAERSDQAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFTDQAvAQAjI1MNAAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAEBVA0ALgBEVA0AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AFF1YWxpdHkBAVwNAC8BACojXA0AAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBXQ0ALgBEXQ0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVy" +
           "aXR5AQFeDQAvAQAqI14NAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAV8NAC4ARF8NAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAWANAC8B" +
           "ACojYA0AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBYQ0ALgBE" +
           "YQ0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFiDQAuAERiDQAA" +
           "AAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBYw0ALwEARCNjDQAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFkDQAvAQBDI2QNAAABAQEAAAABAPkLAAEA8woA" +
           "AAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFlDQAvAQBFI2UNAAABAQEAAAABAPkLAAEADQsBAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBZg0ALgBEZg0AAJYCAAAAAQAqAQFGAAAABwAAAEV2" +
           "ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21t" +
           "ZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFk" +
           "ZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBaw0ALwA/aw0AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQFsDQAvAQAjI2wNAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBbQ0ALgBE" +
           "bQ0AAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ChannelState Class
    #if (!OPCUA_EXCLUDE_ChannelState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChannelState : BaseDataVariableState<ushort>
    {
        #region Constructors
        /// <remarks />
        public ChannelState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ChannelType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.DataTypes.ChannelNumberDataType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CalibrationDate != null)
            {
                CalibrationDate.Initialize(context, CalibrationDate_InitializationString);
            }

            if (NextCalibrationDate != null)
            {
                NextCalibrationDate.Initialize(context, NextCalibrationDate_InitializationString);
            }

            if (CalibrationInitials != null)
            {
                CalibrationInitials.Initialize(context, CalibrationInitials_InitializationString);
            }
        }

        #region Initialization String
        private const string CalibrationDate_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAA8A" +
           "AABDYWxpYnJhdGlvbkRhdGUBAYYNAC4ARIYNAAABASsO/////wEB/////wAAAAA=";

        private const string NextCalibrationDate_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABMA" +
           "AABOZXh0Q2FsaWJyYXRpb25EYXRlAQGHDQAuAESHDQAAAQErDv////8BAf////8AAAAA";

        private const string CalibrationInitials_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABMA" +
           "AABDYWxpYnJhdGlvbkluaXRpYWxzAQGIDQAuAESIDQAAAQEsDv////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCBAgIAAAABABMA" +
           "AABDaGFubmVsVHlwZUluc3RhbmNlAQGFDQEBhQ2FDQAAAQEvDgEB/////wMAAAAVYIkKAgAAAAEADwAA" +
           "AENhbGlicmF0aW9uRGF0ZQEBhg0ALgBEhg0AAAEBKw7/////AQH/////AAAAABVgiQoCAAAAAQATAAAA" +
           "TmV4dENhbGlicmF0aW9uRGF0ZQEBhw0ALgBEhw0AAAEBKw7/////AQH/////AAAAABVgiQoCAAAAAQAT" +
           "AAAAQ2FsaWJyYXRpb25Jbml0aWFscwEBiA0ALgBEiA0AAAEBLA7/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> CalibrationDate
        {
            get
            {
                return m_calibrationDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_calibrationDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_calibrationDate = value;
            }
        }

        /// <remarks />
        public PropertyState<string> NextCalibrationDate
        {
            get
            {
                return m_nextCalibrationDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nextCalibrationDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nextCalibrationDate = value;
            }
        }

        /// <remarks />
        public PropertyState<string> CalibrationInitials
        {
            get
            {
                return m_calibrationInitials;
            }

            set
            {
                if (!Object.ReferenceEquals(m_calibrationInitials, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_calibrationInitials = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_calibrationDate != null)
            {
                children.Add(m_calibrationDate);
            }

            if (m_nextCalibrationDate != null)
            {
                children.Add(m_nextCalibrationDate);
            }

            if (m_calibrationInitials != null)
            {
                children.Add(m_calibrationInitials);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.CalibrationDate:
                {
                    if (createOrReplace)
                    {
                        if (CalibrationDate == null)
                        {
                            if (replacement == null)
                            {
                                CalibrationDate = new PropertyState<string>(this);
                            }
                            else
                            {
                                CalibrationDate = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = CalibrationDate;
                    break;
                }

                case MyOPCUAServer.BrowseNames.NextCalibrationDate:
                {
                    if (createOrReplace)
                    {
                        if (NextCalibrationDate == null)
                        {
                            if (replacement == null)
                            {
                                NextCalibrationDate = new PropertyState<string>(this);
                            }
                            else
                            {
                                NextCalibrationDate = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NextCalibrationDate;
                    break;
                }

                case MyOPCUAServer.BrowseNames.CalibrationInitials:
                {
                    if (createOrReplace)
                    {
                        if (CalibrationInitials == null)
                        {
                            if (replacement == null)
                            {
                                CalibrationInitials = new PropertyState<string>(this);
                            }
                            else
                            {
                                CalibrationInitials = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = CalibrationInitials;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_calibrationDate;
        private PropertyState<string> m_nextCalibrationDate;
        private PropertyState<string> m_calibrationInitials;
        #endregion
    }
    #endif
    #endregion

    #region ConfigurationState Class
    #if (!OPCUA_EXCLUDE_ConfigurationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConfigurationState : MTComponentState
    {
        #region Constructors
        /// <remarks />
        public ConfigurationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.ConfigurationType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABkA" +
           "AABDb25maWd1cmF0aW9uVHlwZUluc3RhbmNlAQGJDQEBiQ2JDQAA/////wUAAAAVYIkKAgAAAAEADAAA" +
           "AEF2YWlsYWJpbGl0eQEBig0ALwEAPQmKDQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAATWFu" +
           "dWZhY3R1cmVyAQGNDQAuAESNDQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2VyaWFsTnVt" +
           "YmVyAQGODQAuAESODQAAAAz/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1zAQGRDQAv" +
           "AD2RDQAA/////wAAAAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBAZINAC8APZINAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SensorConfigurationState Class
    #if (!OPCUA_EXCLUDE_SensorConfigurationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorConfigurationState : ConfigurationState
    {
        #region Constructors
        /// <remarks />
        public SensorConfigurationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.SensorConfigurationType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (FirmwareVersion != null)
            {
                FirmwareVersion.Initialize(context, FirmwareVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string FirmwareVersion_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAA8A" +
           "AABGaXJtd2FyZVZlcnNpb24BAaMNAC4ARKMNAAABAVkO/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABAB8A" +
           "AABTZW5zb3JDb25maWd1cmF0aW9uVHlwZUluc3RhbmNlAQGWDQEBlg2WDQAA/////wYAAAAVYIkKAgAA" +
           "AAEADAAAAEF2YWlsYWJpbGl0eQEBlw0ALwEAPQmXDQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAM" +
           "AAAATWFudWZhY3R1cmVyAQGaDQAuAESaDQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU2Vy" +
           "aWFsTnVtYmVyAQGbDQAuAESbDQAAAAz/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1z" +
           "AQGeDQAvAD2eDQAA/////wAAAAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBAZ8NAC8APZ8NAAD/////" +
           "AAAAABVgiQoCAAAAAQAPAAAARmlybXdhcmVWZXJzaW9uAQGjDQAuAESjDQAAAQFZDv////8BAf////8A" +
           "AAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> FirmwareVersion
        {
            get
            {
                return m_firmwareVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_firmwareVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_firmwareVersion = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_firmwareVersion != null)
            {
                children.Add(m_firmwareVersion);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.FirmwareVersion:
                {
                    if (createOrReplace)
                    {
                        if (FirmwareVersion == null)
                        {
                            if (replacement == null)
                            {
                                FirmwareVersion = new PropertyState<string>(this);
                            }
                            else
                            {
                                FirmwareVersion = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = FirmwareVersion;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_firmwareVersion;
        #endregion
    }
    #endif
    #endregion

    #region SensorState Class
    #if (!OPCUA_EXCLUDE_SensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorState : MTComponentState
    {
        #region Constructors
        /// <remarks />
        public SensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.SensorType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABIA" +
           "AABTZW5zb3JUeXBlSW5zdGFuY2UBAaQNAQGkDaQNAAD/////BQAAABVgiQoCAAAAAQAMAAAAQXZhaWxh" +
           "YmlsaXR5AQGlDQAvAQA9CaUNAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVy" +
           "ZXIBAagNAC4ARKgNAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXIBAakN" +
           "AC4ARKkNAAAADP////8BAf////8AAAAABGCACgEAAAABAAkAAABEYXRhSXRlbXMBAawNAC8APawNAAD/" +
           "////AAAAAARggAoBAAAAAQAKAAAAQ29tcG9uZW50cwEBrQ0ALwA9rQ0AAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SourceState Class
    #if (!OPCUA_EXCLUDE_SourceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SourceState : MTComponentState
    {
        #region Constructors
        /// <remarks />
        public SourceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.SourceType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ComponentId != null)
            {
                ComponentId.Initialize(context, ComponentId_InitializationString);
            }
        }

        #region Initialization String
        private const string ComponentId_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABDb21wb25lbnRJZAEBvg0ALgBEvg0AAAEBOQ7/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABIA" +
           "AABTb3VyY2VUeXBlSW5zdGFuY2UBAbENAQGxDbENAAD/////BgAAABVgiQoCAAAAAQAMAAAAQXZhaWxh" +
           "YmlsaXR5AQGyDQAvAQA9CbINAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVy" +
           "ZXIBAbUNAC4ARLUNAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXIBAbYN" +
           "AC4ARLYNAAAADP////8BAf////8AAAAABGCACgEAAAABAAkAAABEYXRhSXRlbXMBAbkNAC8APbkNAAD/" +
           "////AAAAAARggAoBAAAAAQAKAAAAQ29tcG9uZW50cwEBug0ALwA9ug0AAP////8AAAAAFWCJCgIAAAAB" +
           "AAsAAABDb21wb25lbnRJZAEBvg0ALgBEvg0AAAEBOQ7/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<NodeId> ComponentId
        {
            get
            {
                return m_componentId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_componentId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_componentId = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_componentId != null)
            {
                children.Add(m_componentId);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.ComponentId:
                {
                    if (createOrReplace)
                    {
                        if (ComponentId == null)
                        {
                            if (replacement == null)
                            {
                                ComponentId = new PropertyState<NodeId>(this);
                            }
                            else
                            {
                                ComponentId = (PropertyState<NodeId>)replacement;
                            }
                        }
                    }

                    instance = ComponentId;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<NodeId> m_componentId;
        #endregion
    }
    #endif
    #endregion

    #region AssetState Class
    #if (!OPCUA_EXCLUDE_AssetState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AssetState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public AssetState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.AssetType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Manufacturers != null)
            {
                Manufacturers.Initialize(context, Manufacturers_InitializationString);
            }

            if (AssetDescription != null)
            {
                AssetDescription.Initialize(context, AssetDescription_InitializationString);
            }
        }

        #region Initialization String
        private const string Manufacturers_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAA0A" +
           "AABNYW51ZmFjdHVyZXJzAQHBDQAuAETBDQAAAQFnDv////8BAf////8AAAAA";

        private const string AssetDescription_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABAA" +
           "AABBc3NldERlc2NyaXB0aW9uAQHDDQAvAD/DDQAAABj/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABEA" +
           "AABBc3NldFR5cGVJbnN0YW5jZQEBvw0BAb8Nvw0AAP////8EAAAAFWCJCgIAAAABAAwAAABTZXJpYWxO" +
           "dW1iZXIBAcANAC4ARMANAAABAYwO/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAE1hbnVmYWN0dXJl" +
           "cnMBAcENAC4ARMENAAABAWcO/////wEB/////wAAAAAVYIkKAgAAAAEAEwAAAExhc3RDaGFuZ2VUaW1l" +
           "c3RhbXABAcINAC4ARMINAAAADf////8BAf////8AAAAAFWCJCgIAAAABABAAAABBc3NldERlc2NyaXB0" +
           "aW9uAQHDDQAvAD/DDQAAABj/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Manufacturers
        {
            get
            {
                return m_manufacturers;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturers, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturers = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> LastChangeTimestamp
        {
            get
            {
                return m_lastChangeTimestamp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastChangeTimestamp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastChangeTimestamp = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState AssetDescription
        {
            get
            {
                return m_assetDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_assetDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_assetDescription = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_manufacturers != null)
            {
                children.Add(m_manufacturers);
            }

            if (m_lastChangeTimestamp != null)
            {
                children.Add(m_lastChangeTimestamp);
            }

            if (m_assetDescription != null)
            {
                children.Add(m_assetDescription);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Manufacturers:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturers == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturers = new PropertyState<string>(this);
                            }
                            else
                            {
                                Manufacturers = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Manufacturers;
                    break;
                }

                case MyOPCUAServer.BrowseNames.LastChangeTimestamp:
                {
                    if (createOrReplace)
                    {
                        if (LastChangeTimestamp == null)
                        {
                            if (replacement == null)
                            {
                                LastChangeTimestamp = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                LastChangeTimestamp = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = LastChangeTimestamp;
                    break;
                }

                case MyOPCUAServer.BrowseNames.AssetDescription:
                {
                    if (createOrReplace)
                    {
                        if (AssetDescription == null)
                        {
                            if (replacement == null)
                            {
                                AssetDescription = new BaseDataVariableState(this);
                            }
                            else
                            {
                                AssetDescription = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = AssetDescription;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_serialNumber;
        private PropertyState<string> m_manufacturers;
        private PropertyState<DateTime> m_lastChangeTimestamp;
        private BaseDataVariableState m_assetDescription;
        #endregion
    }
    #endif
    #endregion

    #region MeasurementState Class
    #if (!OPCUA_EXCLUDE_MeasurementState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MeasurementState : AnalogItemState
    {
        #region Constructors
        /// <remarks />
        public MeasurementState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.MeasurementType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (SignificantDigits != null)
            {
                SignificantDigits.Initialize(context, SignificantDigits_InitializationString);
            }

            if (Units != null)
            {
                Units.Initialize(context, Units_InitializationString);
            }

            if (NativeUnits != null)
            {
                NativeUnits.Initialize(context, NativeUnits_InitializationString);
            }

            if (LastChangeTimestamp != null)
            {
                LastChangeTimestamp.Initialize(context, LastChangeTimestamp_InitializationString);
            }

            if (Code != null)
            {
                Code.Initialize(context, Code_InitializationString);
            }

            if (Maximum != null)
            {
                Maximum.Initialize(context, Maximum_InitializationString);
            }

            if (Minimum != null)
            {
                Minimum.Initialize(context, Minimum_InitializationString);
            }

            if (Nominal != null)
            {
                Nominal.Initialize(context, Nominal_InitializationString);
            }
        }

        #region Initialization String
        private const string SignificantDigits_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABEA" +
           "AABTaWduaWZpY2FudERpZ2l0cwEByg0ALgBEyg0AAAEBiA7/////AQH/////AAAAAA==";

        private const string Units_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAUA" +
           "AABVbml0cwEByw0ALwA/yw0AAAEAdwP/////AQH/////AAAAAA==";

        private const string NativeUnits_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABOYXRpdmVVbml0cwEBzA0ALwA/zA0AAAEAdwP/////AQH/////AAAAAA==";

        private const string LastChangeTimestamp_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABMA" +
           "AABMYXN0Q2hhbmdlVGltZXN0YW1wAQHNDQAuAETNDQAAAA3/////AQH/////AAAAAA==";

        private const string Code_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAQA" +
           "AABDb2RlAQHODQAuAETODQAAAQE4Dv////8BAf////8AAAAA";

        private const string Maximum_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAcA" +
           "AABNYXhpbXVtAQHPDQAuAETPDQAAAQFrDv////8BAf////8AAAAA";

        private const string Minimum_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAcA" +
           "AABNaW5pbXVtAQHQDQAuAETQDQAAAQFrDv////8BAf////8AAAAA";

        private const string Nominal_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAcA" +
           "AABOb21pbmFsAQHRDQAuAETRDQAAAQFrDv////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABABcA" +
           "AABNZWFzdXJlbWVudFR5cGVJbnN0YW5jZQEBxA0BAcQNxA0AAAAa/////wEB/////wkAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAcgNAC4ARMgNAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEQAAAFNp" +
           "Z25pZmljYW50RGlnaXRzAQHKDQAuAETKDQAAAQGIDv////8BAf////8AAAAAFWCJCgIAAAABAAUAAABV" +
           "bml0cwEByw0ALwA/yw0AAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQALAAAATmF0aXZlVW5pdHMB" +
           "AcwNAC8AP8wNAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEAEwAAAExhc3RDaGFuZ2VUaW1lc3Rh" +
           "bXABAc0NAC4ARM0NAAAADf////8BAf////8AAAAAFWCJCgIAAAABAAQAAABDb2RlAQHODQAuAETODQAA" +
           "AQE4Dv////8BAf////8AAAAAFWCJCgIAAAABAAcAAABNYXhpbXVtAQHPDQAuAETPDQAAAQFrDv////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAcAAABNaW5pbXVtAQHQDQAuAETQDQAAAQFrDv////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAcAAABOb21pbmFsAQHRDQAuAETRDQAAAQFrDv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState SignificantDigits
        {
            get
            {
                return m_significantDigits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_significantDigits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_significantDigits = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<EUInformation> Units
        {
            get
            {
                return m_units;
            }

            set
            {
                if (!Object.ReferenceEquals(m_units, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_units = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<EUInformation> NativeUnits
        {
            get
            {
                return m_nativeUnits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeUnits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeUnits = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> LastChangeTimestamp
        {
            get
            {
                return m_lastChangeTimestamp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastChangeTimestamp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastChangeTimestamp = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Code
        {
            get
            {
                return m_code;
            }

            set
            {
                if (!Object.ReferenceEquals(m_code, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_code = value;
            }
        }

        /// <remarks />
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }

        /// <remarks />
        public PropertyState<float> Minimum
        {
            get
            {
                return m_minimum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minimum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minimum = value;
            }
        }

        /// <remarks />
        public PropertyState<float> Nominal
        {
            get
            {
                return m_nominal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nominal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nominal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_significantDigits != null)
            {
                children.Add(m_significantDigits);
            }

            if (m_units != null)
            {
                children.Add(m_units);
            }

            if (m_nativeUnits != null)
            {
                children.Add(m_nativeUnits);
            }

            if (m_lastChangeTimestamp != null)
            {
                children.Add(m_lastChangeTimestamp);
            }

            if (m_code != null)
            {
                children.Add(m_code);
            }

            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            if (m_minimum != null)
            {
                children.Add(m_minimum);
            }

            if (m_nominal != null)
            {
                children.Add(m_nominal);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.SignificantDigits:
                {
                    if (createOrReplace)
                    {
                        if (SignificantDigits == null)
                        {
                            if (replacement == null)
                            {
                                SignificantDigits = new PropertyState(this);
                            }
                            else
                            {
                                SignificantDigits = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = SignificantDigits;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Units:
                {
                    if (createOrReplace)
                    {
                        if (Units == null)
                        {
                            if (replacement == null)
                            {
                                Units = new BaseDataVariableState<EUInformation>(this);
                            }
                            else
                            {
                                Units = (BaseDataVariableState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = Units;
                    break;
                }

                case MyOPCUAServer.BrowseNames.NativeUnits:
                {
                    if (createOrReplace)
                    {
                        if (NativeUnits == null)
                        {
                            if (replacement == null)
                            {
                                NativeUnits = new BaseDataVariableState<EUInformation>(this);
                            }
                            else
                            {
                                NativeUnits = (BaseDataVariableState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = NativeUnits;
                    break;
                }

                case MyOPCUAServer.BrowseNames.LastChangeTimestamp:
                {
                    if (createOrReplace)
                    {
                        if (LastChangeTimestamp == null)
                        {
                            if (replacement == null)
                            {
                                LastChangeTimestamp = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                LastChangeTimestamp = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = LastChangeTimestamp;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Code:
                {
                    if (createOrReplace)
                    {
                        if (Code == null)
                        {
                            if (replacement == null)
                            {
                                Code = new PropertyState<string>(this);
                            }
                            else
                            {
                                Code = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Code;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Minimum:
                {
                    if (createOrReplace)
                    {
                        if (Minimum == null)
                        {
                            if (replacement == null)
                            {
                                Minimum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Minimum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Minimum;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Nominal:
                {
                    if (createOrReplace)
                    {
                        if (Nominal == null)
                        {
                            if (replacement == null)
                            {
                                Nominal = new PropertyState<float>(this);
                            }
                            else
                            {
                                Nominal = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Nominal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState m_significantDigits;
        private BaseDataVariableState<EUInformation> m_units;
        private BaseDataVariableState<EUInformation> m_nativeUnits;
        private PropertyState<DateTime> m_lastChangeTimestamp;
        private PropertyState<string> m_code;
        private PropertyState<float> m_maximum;
        private PropertyState<float> m_minimum;
        private PropertyState<float> m_nominal;
        #endregion
    }

    #region MeasurementState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MeasurementState<T> : MeasurementState
    {
        #region Constructors
        /// <remarks />
        public MeasurementState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region CuttingToolState Class
    #if (!OPCUA_EXCLUDE_CuttingToolState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingToolState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public CuttingToolState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.CuttingToolType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ToolGroup != null)
            {
                ToolGroup.Initialize(context, ToolGroup_InitializationString);
            }
        }

        #region Initialization String
        private const string ToolGroup_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAkA" +
           "AABUb29sR3JvdXABAdQNAC4ARNQNAAABAZAO/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABcA" +
           "AABDdXR0aW5nVG9vbFR5cGVJbnN0YW5jZQEB0g0BAdIN0g0AAP////8CAAAAFWCJCgIAAAABAAYAAABU" +
           "b29sSWQBAdMNAC4ARNMNAAABAZEO/////wEB/////wAAAAAVYIkKAgAAAAEACQAAAFRvb2xHcm91cAEB" +
           "1A0ALgBE1A0AAAEBkA7/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> ToolId
        {
            get
            {
                return m_toolId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toolId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toolId = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ToolGroup
        {
            get
            {
                return m_toolGroup;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toolGroup, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toolGroup = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_toolId != null)
            {
                children.Add(m_toolId);
            }

            if (m_toolGroup != null)
            {
                children.Add(m_toolGroup);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.ToolId:
                {
                    if (createOrReplace)
                    {
                        if (ToolId == null)
                        {
                            if (replacement == null)
                            {
                                ToolId = new PropertyState<string>(this);
                            }
                            else
                            {
                                ToolId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ToolId;
                    break;
                }

                case MyOPCUAServer.BrowseNames.ToolGroup:
                {
                    if (createOrReplace)
                    {
                        if (ToolGroup == null)
                        {
                            if (replacement == null)
                            {
                                ToolGroup = new PropertyState<string>(this);
                            }
                            else
                            {
                                ToolGroup = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ToolGroup;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_toolId;
        private PropertyState<string> m_toolGroup;
        #endregion
    }
    #endif
    #endregion

    #region CuttingToolLifeCycleState Class
    #if (!OPCUA_EXCLUDE_CuttingToolLifeCycleState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingToolLifeCycleState : AssetState
    {
        #region Constructors
        /// <remarks />
        public CuttingToolLifeCycleState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.CuttingToolLifeCycleType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ReconditionCount != null)
            {
                ReconditionCount.Initialize(context, ReconditionCount_InitializationString);
            }

            if (ToolLife != null)
            {
                ToolLife.Initialize(context, ToolLife_InitializationString);
            }

            if (ProgramToolNumber != null)
            {
                ProgramToolNumber.Initialize(context, ProgramToolNumber_InitializationString);
            }

            if (Location != null)
            {
                Location.Initialize(context, Location_InitializationString);
            }

            if (ProgramSpindleSpeed != null)
            {
                ProgramSpindleSpeed.Initialize(context, ProgramSpindleSpeed_InitializationString);
            }

            if (ProgramFeedRate != null)
            {
                ProgramFeedRate.Initialize(context, ProgramFeedRate_InitializationString);
            }

            if (ConnectionCodeMachineSide != null)
            {
                ConnectionCodeMachineSide.Initialize(context, ConnectionCodeMachineSide_InitializationString);
            }
        }

        #region Initialization String
        private const string ReconditionCount_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABAA" +
           "AABSZWNvbmRpdGlvbkNvdW50AQHcDQAvAQHzDdwNAAABAYIO/////wEB/////wAAAAA=";

        private const string ToolLife_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAgA" +
           "AABUb29sTGlmZQEB3g0ALwEB9Q3eDQAAABj/////AQH/////AwAAABVgiQoCAAAAAQAEAAAAVHlwZQEB" +
           "3w0ALgBE3w0AAAEBlA7/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAQ291bnREaXJlY3Rpb24BAeAN" +
           "AC4AROANAAABAZIO/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE1heGltdW0BAeINAC4AROINAAAB" +
           "AZYO/////wEB/////wAAAAA=";

        private const string ProgramToolNumber_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABEA" +
           "AABQcm9ncmFtVG9vbE51bWJlcgEB4w0ALwEB/g3jDQAAAQF+Dv////8BAf////8DAAAAFWCJCgIAAAAB" +
           "AAcAAABNYXhpbXVtAQHkDQAuAETkDQAAAQFqDv////8BAf////8AAAAAFWCJCgIAAAABAAcAAABNaW5p" +
           "bXVtAQHlDQAuAETlDQAAAQFsDv////8BAf////8AAAAAFWCJCgIAAAABAAcAAABOb21pbmFsAQHmDQAu" +
           "AETmDQAAAQF0Dv////8BAf////8AAAAA";

        private const string Location_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAgA" +
           "AABMb2NhdGlvbgEB5w0ALwEB+g3nDQAAAQFjDv////8BAf////8DAAAAFWCJCgIAAAABAAQAAABUeXBl" +
           "AQHoDQAuAEToDQAAAQFkDv////8BAf////8AAAAAFWCJCgIAAAABAA8AAABOZWdhdGl2ZU92ZXJsYXAB" +
           "AekNAC4AROkNAAABAXkO/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFBvc2l0aXZlT3ZlcmxhcAEB" +
           "6g0ALgBE6g0AAAEBeQ7/////AQH/////AAAAAA==";

        private const string ProgramSpindleSpeed_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABMA" +
           "AABQcm9ncmFtU3BpbmRsZVNwZWVkAQHrDQAvAQH+DesNAAAAGP////8BAf////8DAAAAFWCJCgIAAAAB" +
           "AAcAAABNYXhpbXVtAQHsDQAuAETsDQAAAQFqDv////8BAf////8AAAAAFWCJCgIAAAABAAcAAABNaW5p" +
           "bXVtAQHtDQAuAETtDQAAAQFsDv////8BAf////8AAAAAFWCJCgIAAAABAAcAAABOb21pbmFsAQHuDQAu" +
           "AETuDQAAAQF0Dv////8BAf////8AAAAA";

        private const string ProgramFeedRate_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAA8A" +
           "AABQcm9ncmFtRmVlZFJhdGUBAe8NAC4ARO8NAAABAVgO/////wEB/////wAAAAA=";

        private const string ConnectionCodeMachineSide_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABABkA" +
           "AABDb25uZWN0aW9uQ29kZU1hY2hpbmVTaWRlAQHwDQAuAETwDQAAAQE6Dv////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABACAA" +
           "AABDdXR0aW5nVG9vbExpZmVDeWNsZVR5cGVJbnN0YW5jZQEB1Q0BAdUN1Q0AAP////8KAAAAFWCJCgIA" +
           "AAABAAwAAABTZXJpYWxOdW1iZXIBAdYNAC4ARNYNAAABAYwO/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "EwAAAExhc3RDaGFuZ2VUaW1lc3RhbXABAdgNAC4ARNgNAAAADf////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAwAAABDdXR0ZXJTdGF0dXMBAdoNAC8BAfEN2g0AAAEBPQ7/////AQH/////AQAAABVgiQoCAAAAAQAG" +
           "AAAAU3RhdHVzAQHbDQAuAETbDQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAQAAAAUmVjb25kaXRp" +
           "b25Db3VudAEB3A0ALwEB8w3cDQAAAQGCDv////8BAf////8AAAAAFWCJCgIAAAABAAgAAABUb29sTGlm" +
           "ZQEB3g0ALwEB9Q3eDQAAABj/////AQH/////AwAAABVgiQoCAAAAAQAEAAAAVHlwZQEB3w0ALgBE3w0A" +
           "AAEBlA7/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAQ291bnREaXJlY3Rpb24BAeANAC4AROANAAAB" +
           "AZIO/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE1heGltdW0BAeINAC4AROINAAABAZYO/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEAEQAAAFByb2dyYW1Ub29sTnVtYmVyAQHjDQAvAQH+DeMNAAABAX4O////" +
           "/wEB/////wMAAAAVYIkKAgAAAAEABwAAAE1heGltdW0BAeQNAC4AROQNAAABAWoO/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEABwAAAE1pbmltdW0BAeUNAC4AROUNAAABAWwO/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEABwAAAE5vbWluYWwBAeYNAC4AROYNAAABAXQO/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAExv" +
           "Y2F0aW9uAQHnDQAvAQH6DecNAAABAWMO/////wEB/////wMAAAAVYIkKAgAAAAEABAAAAFR5cGUBAegN" +
           "AC4AROgNAAABAWQO/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE5lZ2F0aXZlT3ZlcmxhcAEB6Q0A" +
           "LgBE6Q0AAAEBeQ7/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAUG9zaXRpdmVPdmVybGFwAQHqDQAu" +
           "AETqDQAAAQF5Dv////8BAf////8AAAAAFWCJCgIAAAABABMAAABQcm9ncmFtU3BpbmRsZVNwZWVkAQHr" +
           "DQAvAQH+DesNAAAAGP////8BAf////8DAAAAFWCJCgIAAAABAAcAAABNYXhpbXVtAQHsDQAuAETsDQAA" +
           "AQFqDv////8BAf////8AAAAAFWCJCgIAAAABAAcAAABNaW5pbXVtAQHtDQAuAETtDQAAAQFsDv////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAcAAABOb21pbmFsAQHuDQAuAETuDQAAAQF0Dv////8BAf////8AAAAA" +
           "FWCJCgIAAAABAA8AAABQcm9ncmFtRmVlZFJhdGUBAe8NAC4ARO8NAAABAVgO/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEAGQAAAENvbm5lY3Rpb25Db2RlTWFjaGluZVNpZGUBAfANAC4ARPANAAABAToO/////wEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public CutterStatusState<CutterStatusValueTypeEnum> CutterStatus
        {
            get
            {
                return m_cutterStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cutterStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cutterStatus = value;
            }
        }

        /// <remarks />
        public ReconditionCountState ReconditionCount
        {
            get
            {
                return m_reconditionCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_reconditionCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_reconditionCount = value;
            }
        }

        /// <remarks />
        public LifeState ToolLife
        {
            get
            {
                return m_toolLife;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toolLife, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toolLife = value;
            }
        }

        /// <remarks />
        public ProgramSpindleSpeedState ProgramToolNumber
        {
            get
            {
                return m_programToolNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programToolNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programToolNumber = value;
            }
        }

        /// <remarks />
        public LocationState Location
        {
            get
            {
                return m_location;
            }

            set
            {
                if (!Object.ReferenceEquals(m_location, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_location = value;
            }
        }

        /// <remarks />
        public ProgramSpindleSpeedState ProgramSpindleSpeed
        {
            get
            {
                return m_programSpindleSpeed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programSpindleSpeed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programSpindleSpeed = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ProgramFeedRate
        {
            get
            {
                return m_programFeedRate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programFeedRate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programFeedRate = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ConnectionCodeMachineSide
        {
            get
            {
                return m_connectionCodeMachineSide;
            }

            set
            {
                if (!Object.ReferenceEquals(m_connectionCodeMachineSide, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_connectionCodeMachineSide = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_cutterStatus != null)
            {
                children.Add(m_cutterStatus);
            }

            if (m_reconditionCount != null)
            {
                children.Add(m_reconditionCount);
            }

            if (m_toolLife != null)
            {
                children.Add(m_toolLife);
            }

            if (m_programToolNumber != null)
            {
                children.Add(m_programToolNumber);
            }

            if (m_location != null)
            {
                children.Add(m_location);
            }

            if (m_programSpindleSpeed != null)
            {
                children.Add(m_programSpindleSpeed);
            }

            if (m_programFeedRate != null)
            {
                children.Add(m_programFeedRate);
            }

            if (m_connectionCodeMachineSide != null)
            {
                children.Add(m_connectionCodeMachineSide);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.CutterStatus:
                {
                    if (createOrReplace)
                    {
                        if (CutterStatus == null)
                        {
                            if (replacement == null)
                            {
                                CutterStatus = new CutterStatusState<CutterStatusValueTypeEnum>(this);
                            }
                            else
                            {
                                CutterStatus = (CutterStatusState<CutterStatusValueTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CutterStatus;
                    break;
                }

                case MyOPCUAServer.BrowseNames.ReconditionCount:
                {
                    if (createOrReplace)
                    {
                        if (ReconditionCount == null)
                        {
                            if (replacement == null)
                            {
                                ReconditionCount = new ReconditionCountState(this);
                            }
                            else
                            {
                                ReconditionCount = (ReconditionCountState)replacement;
                            }
                        }
                    }

                    instance = ReconditionCount;
                    break;
                }

                case MyOPCUAServer.BrowseNames.ToolLife:
                {
                    if (createOrReplace)
                    {
                        if (ToolLife == null)
                        {
                            if (replacement == null)
                            {
                                ToolLife = new LifeState(this);
                            }
                            else
                            {
                                ToolLife = (LifeState)replacement;
                            }
                        }
                    }

                    instance = ToolLife;
                    break;
                }

                case MyOPCUAServer.BrowseNames.ProgramToolNumber:
                {
                    if (createOrReplace)
                    {
                        if (ProgramToolNumber == null)
                        {
                            if (replacement == null)
                            {
                                ProgramToolNumber = new ProgramSpindleSpeedState(this);
                            }
                            else
                            {
                                ProgramToolNumber = (ProgramSpindleSpeedState)replacement;
                            }
                        }
                    }

                    instance = ProgramToolNumber;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Location:
                {
                    if (createOrReplace)
                    {
                        if (Location == null)
                        {
                            if (replacement == null)
                            {
                                Location = new LocationState(this);
                            }
                            else
                            {
                                Location = (LocationState)replacement;
                            }
                        }
                    }

                    instance = Location;
                    break;
                }

                case MyOPCUAServer.BrowseNames.ProgramSpindleSpeed:
                {
                    if (createOrReplace)
                    {
                        if (ProgramSpindleSpeed == null)
                        {
                            if (replacement == null)
                            {
                                ProgramSpindleSpeed = new ProgramSpindleSpeedState(this);
                            }
                            else
                            {
                                ProgramSpindleSpeed = (ProgramSpindleSpeedState)replacement;
                            }
                        }
                    }

                    instance = ProgramSpindleSpeed;
                    break;
                }

                case MyOPCUAServer.BrowseNames.ProgramFeedRate:
                {
                    if (createOrReplace)
                    {
                        if (ProgramFeedRate == null)
                        {
                            if (replacement == null)
                            {
                                ProgramFeedRate = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProgramFeedRate = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProgramFeedRate;
                    break;
                }

                case MyOPCUAServer.BrowseNames.ConnectionCodeMachineSide:
                {
                    if (createOrReplace)
                    {
                        if (ConnectionCodeMachineSide == null)
                        {
                            if (replacement == null)
                            {
                                ConnectionCodeMachineSide = new PropertyState<string>(this);
                            }
                            else
                            {
                                ConnectionCodeMachineSide = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ConnectionCodeMachineSide;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private CutterStatusState<CutterStatusValueTypeEnum> m_cutterStatus;
        private ReconditionCountState m_reconditionCount;
        private LifeState m_toolLife;
        private ProgramSpindleSpeedState m_programToolNumber;
        private LocationState m_location;
        private ProgramSpindleSpeedState m_programSpindleSpeed;
        private PropertyState<string> m_programFeedRate;
        private PropertyState<string> m_connectionCodeMachineSide;
        #endregion
    }
    #endif
    #endregion

    #region CutterStatusState Class
    #if (!OPCUA_EXCLUDE_CutterStatusState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CutterStatusState : BaseDataVariableState
    {
        #region Constructors
        /// <remarks />
        public CutterStatusState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.CutterStatusType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCBAgIAAAABABgA" +
           "AABDdXR0ZXJTdGF0dXNUeXBlSW5zdGFuY2UBAfENAQHxDfENAAAAGAEB/////wEAAAAVYIkKAgAAAAEA" +
           "BgAAAFN0YXR1cwEB8g0ALgBE8g0AAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_status != null)
            {
                children.Add(m_status);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new PropertyState<string>(this);
                            }
                            else
                            {
                                Status = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_status;
        #endregion
    }

    #region CutterStatusState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class CutterStatusState<T> : CutterStatusState
    {
        #region Constructors
        /// <remarks />
        public CutterStatusState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ReconditionCountState Class
    #if (!OPCUA_EXCLUDE_ReconditionCountState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReconditionCountState : BaseDataVariableState
    {
        #region Constructors
        /// <remarks />
        public ReconditionCountState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ReconditionCountType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MaximumCount != null)
            {
                MaximumCount.Initialize(context, MaximumCount_InitializationString);
            }
        }

        #region Initialization String
        private const string MaximumCount_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAwA" +
           "AABNYXhpbXVtQ291bnQBAfQNAC4ARPQNAAABAWkO/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCBAgIAAAABABwA" +
           "AABSZWNvbmRpdGlvbkNvdW50VHlwZUluc3RhbmNlAQHzDQEB8w3zDQAAABgBAf////8BAAAAFWCJCgIA" +
           "AAABAAwAAABNYXhpbXVtQ291bnQBAfQNAC4ARPQNAAABAWkO/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState MaximumCount
        {
            get
            {
                return m_maximumCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximumCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximumCount = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_maximumCount != null)
            {
                children.Add(m_maximumCount);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.MaximumCount:
                {
                    if (createOrReplace)
                    {
                        if (MaximumCount == null)
                        {
                            if (replacement == null)
                            {
                                MaximumCount = new PropertyState(this);
                            }
                            else
                            {
                                MaximumCount = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = MaximumCount;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState m_maximumCount;
        #endregion
    }

    #region ReconditionCountState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ReconditionCountState<T> : ReconditionCountState
    {
        #region Constructors
        /// <remarks />
        public ReconditionCountState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LifeState Class
    #if (!OPCUA_EXCLUDE_LifeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LifeState : BaseDataVariableState
    {
        #region Constructors
        /// <remarks />
        public LifeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.LifeType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (WarningLevel != null)
            {
                WarningLevel.Initialize(context, WarningLevel_InitializationString);
            }
        }

        #region Initialization String
        private const string WarningLevel_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAwA" +
           "AABXYXJuaW5nTGV2ZWwBAfgNAC4ARPgNAAABAZYO/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCBAgIAAAABABAA" +
           "AABMaWZlVHlwZUluc3RhbmNlAQH1DQEB9Q31DQAAABgBAf////8EAAAAFWCJCgIAAAABAAQAAABUeXBl" +
           "AQH2DQAuAET2DQAAAQGUDv////8BAf////8AAAAAFWCJCgIAAAABAA4AAABDb3VudERpcmVjdGlvbgEB" +
           "9w0ALgBE9w0AAAEBkg7/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAV2FybmluZ0xldmVsAQH4DQAu" +
           "AET4DQAAAQGWDv////8BAf////8AAAAAFWCJCgIAAAABAAcAAABNYXhpbXVtAQH5DQAuAET5DQAAAQGW" +
           "Dv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<ToolLifeTypeEnum> Type
        {
            get
            {
                return m_type;
            }

            set
            {
                if (!Object.ReferenceEquals(m_type, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_type = value;
            }
        }

        /// <remarks />
        public PropertyState<ToolLifeDirectionTypeEnum> CountDirection
        {
            get
            {
                return m_countDirection;
            }

            set
            {
                if (!Object.ReferenceEquals(m_countDirection, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_countDirection = value;
            }
        }

        /// <remarks />
        public PropertyState<float> WarningLevel
        {
            get
            {
                return m_warningLevel;
            }

            set
            {
                if (!Object.ReferenceEquals(m_warningLevel, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_warningLevel = value;
            }
        }

        /// <remarks />
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_type != null)
            {
                children.Add(m_type);
            }

            if (m_countDirection != null)
            {
                children.Add(m_countDirection);
            }

            if (m_warningLevel != null)
            {
                children.Add(m_warningLevel);
            }

            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.Type:
                {
                    if (createOrReplace)
                    {
                        if (Type == null)
                        {
                            if (replacement == null)
                            {
                                Type = new PropertyState<ToolLifeTypeEnum>(this);
                            }
                            else
                            {
                                Type = (PropertyState<ToolLifeTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = Type;
                    break;
                }

                case MyOPCUAServer.BrowseNames.CountDirection:
                {
                    if (createOrReplace)
                    {
                        if (CountDirection == null)
                        {
                            if (replacement == null)
                            {
                                CountDirection = new PropertyState<ToolLifeDirectionTypeEnum>(this);
                            }
                            else
                            {
                                CountDirection = (PropertyState<ToolLifeDirectionTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CountDirection;
                    break;
                }

                case MyOPCUAServer.BrowseNames.WarningLevel:
                {
                    if (createOrReplace)
                    {
                        if (WarningLevel == null)
                        {
                            if (replacement == null)
                            {
                                WarningLevel = new PropertyState<float>(this);
                            }
                            else
                            {
                                WarningLevel = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = WarningLevel;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ToolLifeTypeEnum> m_type;
        private PropertyState<ToolLifeDirectionTypeEnum> m_countDirection;
        private PropertyState<float> m_warningLevel;
        private PropertyState<float> m_maximum;
        #endregion
    }

    #region LifeState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LifeState<T> : LifeState
    {
        #region Constructors
        /// <remarks />
        public LifeState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LocationState Class
    #if (!OPCUA_EXCLUDE_LocationState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LocationState : BaseDataVariableState
    {
        #region Constructors
        /// <remarks />
        public LocationState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.LocationType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCBAgIAAAABABQA" +
           "AABMb2NhdGlvblR5cGVJbnN0YW5jZQEB+g0BAfoN+g0AAAAYAQH/////AwAAABVgiQoCAAAAAQAEAAAA" +
           "VHlwZQEB+w0ALgBE+w0AAAEBZA7/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATmVnYXRpdmVPdmVy" +
           "bGFwAQH8DQAuAET8DQAAAQF5Dv////8BAf////8AAAAAFWCJCgIAAAABAA8AAABQb3NpdGl2ZU92ZXJs" +
           "YXABAf0NAC4ARP0NAAABAXkO/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<LocationsTypeEnum> Type
        {
            get
            {
                return m_type;
            }

            set
            {
                if (!Object.ReferenceEquals(m_type, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_type = value;
            }
        }

        /// <remarks />
        public PropertyState NegativeOverlap
        {
            get
            {
                return m_negativeOverlap;
            }

            set
            {
                if (!Object.ReferenceEquals(m_negativeOverlap, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_negativeOverlap = value;
            }
        }

        /// <remarks />
        public PropertyState PositiveOverlap
        {
            get
            {
                return m_positiveOverlap;
            }

            set
            {
                if (!Object.ReferenceEquals(m_positiveOverlap, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_positiveOverlap = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_type != null)
            {
                children.Add(m_type);
            }

            if (m_negativeOverlap != null)
            {
                children.Add(m_negativeOverlap);
            }

            if (m_positiveOverlap != null)
            {
                children.Add(m_positiveOverlap);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.Type:
                {
                    if (createOrReplace)
                    {
                        if (Type == null)
                        {
                            if (replacement == null)
                            {
                                Type = new PropertyState<LocationsTypeEnum>(this);
                            }
                            else
                            {
                                Type = (PropertyState<LocationsTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = Type;
                    break;
                }

                case MyOPCUAServer.BrowseNames.NegativeOverlap:
                {
                    if (createOrReplace)
                    {
                        if (NegativeOverlap == null)
                        {
                            if (replacement == null)
                            {
                                NegativeOverlap = new PropertyState(this);
                            }
                            else
                            {
                                NegativeOverlap = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = NegativeOverlap;
                    break;
                }

                case MyOPCUAServer.BrowseNames.PositiveOverlap:
                {
                    if (createOrReplace)
                    {
                        if (PositiveOverlap == null)
                        {
                            if (replacement == null)
                            {
                                PositiveOverlap = new PropertyState(this);
                            }
                            else
                            {
                                PositiveOverlap = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = PositiveOverlap;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<LocationsTypeEnum> m_type;
        private PropertyState m_negativeOverlap;
        private PropertyState m_positiveOverlap;
        #endregion
    }

    #region LocationState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LocationState<T> : LocationState
    {
        #region Constructors
        /// <remarks />
        public LocationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ProgramSpindleSpeedState Class
    #if (!OPCUA_EXCLUDE_ProgramSpindleSpeedState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramSpindleSpeedState : BaseDataVariableState
    {
        #region Constructors
        /// <remarks />
        public ProgramSpindleSpeedState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ProgramSpindleSpeedType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCBAgIAAAABAB8A" +
           "AABQcm9ncmFtU3BpbmRsZVNwZWVkVHlwZUluc3RhbmNlAQH+DQEB/g3+DQAAABgBAf////8DAAAAFWCJ" +
           "CgIAAAABAAcAAABNYXhpbXVtAQH/DQAuAET/DQAAAQFqDv////8BAf////8AAAAAFWCJCgIAAAABAAcA" +
           "AABNaW5pbXVtAQEADgAuAEQADgAAAQFsDv////8BAf////8AAAAAFWCJCgIAAAABAAcAAABOb21pbmFs" +
           "AQEBDgAuAEQBDgAAAQF0Dv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }

        /// <remarks />
        public PropertyState<float> Minimum
        {
            get
            {
                return m_minimum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minimum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minimum = value;
            }
        }

        /// <remarks />
        public PropertyState<float> Nominal
        {
            get
            {
                return m_nominal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nominal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nominal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            if (m_minimum != null)
            {
                children.Add(m_minimum);
            }

            if (m_nominal != null)
            {
                children.Add(m_nominal);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Minimum:
                {
                    if (createOrReplace)
                    {
                        if (Minimum == null)
                        {
                            if (replacement == null)
                            {
                                Minimum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Minimum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Minimum;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Nominal:
                {
                    if (createOrReplace)
                    {
                        if (Nominal == null)
                        {
                            if (replacement == null)
                            {
                                Nominal = new PropertyState<float>(this);
                            }
                            else
                            {
                                Nominal = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Nominal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<float> m_maximum;
        private PropertyState<float> m_minimum;
        private PropertyState<float> m_nominal;
        #endregion
    }

    #region ProgramSpindleSpeedState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ProgramSpindleSpeedState<T> : ProgramSpindleSpeedState
    {
        #region Constructors
        /// <remarks />
        public ProgramSpindleSpeedState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ProgramFeedRateState Class
    #if (!OPCUA_EXCLUDE_ProgramFeedRateState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramFeedRateState : BaseDataVariableState
    {
        #region Constructors
        /// <remarks />
        public ProgramFeedRateState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.ProgramFeedRateType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCBAgIAAAABABsA" +
           "AABQcm9ncmFtRmVlZFJhdGVUeXBlSW5zdGFuY2UBAQIOAQECDgIOAAAAGAEB/////wMAAAAVYIkKAgAA" +
           "AAEABwAAAE1heGltdW0BAQMOAC4ARAMOAAABAWoO/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE1p" +
           "bmltdW0BAQQOAC4ARAQOAAABAWwO/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE5vbWluYWwBAQUO" +
           "AC4ARAUOAAABAXQO/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }

        /// <remarks />
        public PropertyState<float> Minimum
        {
            get
            {
                return m_minimum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minimum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minimum = value;
            }
        }

        /// <remarks />
        public PropertyState<float> Nominal
        {
            get
            {
                return m_nominal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nominal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nominal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            if (m_minimum != null)
            {
                children.Add(m_minimum);
            }

            if (m_nominal != null)
            {
                children.Add(m_nominal);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Minimum:
                {
                    if (createOrReplace)
                    {
                        if (Minimum == null)
                        {
                            if (replacement == null)
                            {
                                Minimum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Minimum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Minimum;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Nominal:
                {
                    if (createOrReplace)
                    {
                        if (Nominal == null)
                        {
                            if (replacement == null)
                            {
                                Nominal = new PropertyState<float>(this);
                            }
                            else
                            {
                                Nominal = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Nominal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<float> m_maximum;
        private PropertyState<float> m_minimum;
        private PropertyState<float> m_nominal;
        #endregion
    }

    #region ProgramFeedRateState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ProgramFeedRateState<T> : ProgramFeedRateState
    {
        #region Constructors
        /// <remarks />
        public ProgramFeedRateState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region CuttingItemState Class
    #if (!OPCUA_EXCLUDE_CuttingItemState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingItemState : BaseDataVariableState
    {
        #region Constructors
        /// <remarks />
        public CuttingItemState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.CuttingItemType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ItemId != null)
            {
                ItemId.Initialize(context, ItemId_InitializationString);
            }

            if (Grade != null)
            {
                Grade.Initialize(context, Grade_InitializationString);
            }

            if (Manufacturers != null)
            {
                Manufacturers.Initialize(context, Manufacturers_InitializationString);
            }

            if (Description != null)
            {
                Description.Initialize(context, Description_InitializationString);
            }

            if (Locus != null)
            {
                Locus.Initialize(context, Locus_InitializationString);
            }

            if (ItemLife != null)
            {
                ItemLife.Initialize(context, ItemLife_InitializationString);
            }

            if (Measurements != null)
            {
                Measurements.Initialize(context, Measurements_InitializationString);
            }
        }

        #region Initialization String
        private const string ItemId_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAYA" +
           "AABJdGVtSWQBAQgOAC4ARAgOAAABAV4O/////wEB/////wAAAAA=";

        private const string Grade_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAUA" +
           "AABHcmFkZQEBCQ4ALgBECQ4AAAEBWw7/////AQH/////AAAAAA==";

        private const string Manufacturers_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAA0A" +
           "AABNYW51ZmFjdHVyZXJzAQEKDgAuAEQKDgAAAQFnDv////8BAf////8AAAAA";

        private const string Description_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAsA" +
           "AABEZXNjcmlwdGlvbgEBCw4ALgBECw4AAAEBIQ7/////AQH/////AAAAAA==";

        private const string Locus_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJCgIAAAABAAUA" +
           "AABMb2N1cwEBDA4ALgBEDA4AAAEBZg7/////AQH/////AAAAAA==";

        private const string ItemLife_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCACgEAAAABAAgA" +
           "AABJdGVtTGlmZQEBDQ4ALwA9DQ4AAP////8AAAAA";

        private const string Measurements_InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCACgEAAAABAAwA" +
           "AABNZWFzdXJlbWVudHMBAQ4OAC8APQ4OAAD/////AAAAAA==";

        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCBAgIAAAABABcA" +
           "AABDdXR0aW5nSXRlbVR5cGVJbnN0YW5jZQEBBg4BAQYOBg4AAAAYAQH/////CAAAABVgiQoCAAAAAQAH" +
           "AAAASW5kaWNlcwEBBw4ALgBEBw4AAAEBXA7/////AQH/////AAAAABVgiQoCAAAAAQAGAAAASXRlbUlk" +
           "AQEIDgAuAEQIDgAAAQFeDv////8BAf////8AAAAAFWCJCgIAAAABAAUAAABHcmFkZQEBCQ4ALgBECQ4A" +
           "AAEBWw7/////AQH/////AAAAABVgiQoCAAAAAQANAAAATWFudWZhY3R1cmVycwEBCg4ALgBECg4AAAEB" +
           "Zw7/////AQH/////AAAAABVgiQoCAAAAAQALAAAARGVzY3JpcHRpb24BAQsOAC4ARAsOAAABASEO////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABQAAAExvY3VzAQEMDgAuAEQMDgAAAQFmDv////8BAf////8AAAAA" +
           "BGCACgEAAAABAAgAAABJdGVtTGlmZQEBDQ4ALwA9DQ4AAP////8AAAAABGCACgEAAAABAAwAAABNZWFz" +
           "dXJlbWVudHMBAQ4OAC8APQ4OAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Indices
        {
            get
            {
                return m_indices;
            }

            set
            {
                if (!Object.ReferenceEquals(m_indices, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_indices = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ItemId
        {
            get
            {
                return m_itemId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_itemId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_itemId = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Grade
        {
            get
            {
                return m_grade;
            }

            set
            {
                if (!Object.ReferenceEquals(m_grade, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_grade = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Manufacturers
        {
            get
            {
                return m_manufacturers;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturers, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturers = value;
            }
        }

        /// <remarks />
        public new PropertyState<string> Description
        {
            get
            {
                return m_description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Locus
        {
            get
            {
                return m_locus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_locus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_locus = value;
            }
        }

        /// <remarks />
        public FolderState ItemLife
        {
            get
            {
                return m_itemLife;
            }

            set
            {
                if (!Object.ReferenceEquals(m_itemLife, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_itemLife = value;
            }
        }

        /// <remarks />
        public FolderState Measurements
        {
            get
            {
                return m_measurements;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measurements, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measurements = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_indices != null)
            {
                children.Add(m_indices);
            }

            if (m_itemId != null)
            {
                children.Add(m_itemId);
            }

            if (m_grade != null)
            {
                children.Add(m_grade);
            }

            if (m_manufacturers != null)
            {
                children.Add(m_manufacturers);
            }

            if (m_description != null)
            {
                children.Add(m_description);
            }

            if (m_locus != null)
            {
                children.Add(m_locus);
            }

            if (m_itemLife != null)
            {
                children.Add(m_itemLife);
            }

            if (m_measurements != null)
            {
                children.Add(m_measurements);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MyOPCUAServer.BrowseNames.Indices:
                {
                    if (createOrReplace)
                    {
                        if (Indices == null)
                        {
                            if (replacement == null)
                            {
                                Indices = new PropertyState<string>(this);
                            }
                            else
                            {
                                Indices = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Indices;
                    break;
                }

                case MyOPCUAServer.BrowseNames.ItemId:
                {
                    if (createOrReplace)
                    {
                        if (ItemId == null)
                        {
                            if (replacement == null)
                            {
                                ItemId = new PropertyState<string>(this);
                            }
                            else
                            {
                                ItemId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ItemId;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Grade:
                {
                    if (createOrReplace)
                    {
                        if (Grade == null)
                        {
                            if (replacement == null)
                            {
                                Grade = new PropertyState<string>(this);
                            }
                            else
                            {
                                Grade = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Grade;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Manufacturers:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturers == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturers = new PropertyState<string>(this);
                            }
                            else
                            {
                                Manufacturers = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Manufacturers;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Description:
                {
                    if (createOrReplace)
                    {
                        if (Description == null)
                        {
                            if (replacement == null)
                            {
                                Description = new PropertyState<string>(this);
                            }
                            else
                            {
                                Description = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Description;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Locus:
                {
                    if (createOrReplace)
                    {
                        if (Locus == null)
                        {
                            if (replacement == null)
                            {
                                Locus = new PropertyState<string>(this);
                            }
                            else
                            {
                                Locus = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Locus;
                    break;
                }

                case MyOPCUAServer.BrowseNames.ItemLife:
                {
                    if (createOrReplace)
                    {
                        if (ItemLife == null)
                        {
                            if (replacement == null)
                            {
                                ItemLife = new FolderState(this);
                            }
                            else
                            {
                                ItemLife = (FolderState)replacement;
                            }
                        }
                    }

                    instance = ItemLife;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Measurements:
                {
                    if (createOrReplace)
                    {
                        if (Measurements == null)
                        {
                            if (replacement == null)
                            {
                                Measurements = new FolderState(this);
                            }
                            else
                            {
                                Measurements = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Measurements;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_indices;
        private PropertyState<string> m_itemId;
        private PropertyState<string> m_grade;
        private PropertyState<string> m_manufacturers;
        private PropertyState<string> m_description;
        private PropertyState<string> m_locus;
        private FolderState m_itemLife;
        private FolderState m_measurements;
        #endregion
    }

    #region CuttingItemState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class CuttingItemState<T> : CuttingItemState
    {
        #region Constructors
        /// <remarks />
        public CuttingItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AssemblyMeasurementState Class
    #if (!OPCUA_EXCLUDE_AssemblyMeasurementState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AssemblyMeasurementState : MeasurementState
    {
        #region Constructors
        /// <remarks />
        public AssemblyMeasurementState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.VariableTypes.AssemblyMeasurementType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////FWCJAgIAAAABAB8A" +
           "AABBc3NlbWJseU1lYXN1cmVtZW50VHlwZUluc3RhbmNlAQEPDgEBDw4PDgAAABr/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBEw4ALgBEEw4AAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AssemblyMeasurementState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AssemblyMeasurementState<T> : AssemblyMeasurementState
    {
        #region Constructors
        /// <remarks />
        public AssemblyMeasurementState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion
}