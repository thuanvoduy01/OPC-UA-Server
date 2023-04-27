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
    #region DtDemoState Class
    #if (!OPCUA_EXCLUDE_DtDemoState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DtDemoState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public DtDemoState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.DtDemoType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
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
           "AABEdERlbW9UeXBlSW5zdGFuY2UBAQ4DAQEOAw4DAAD/////AQAAABVgiQoCAAAAAQAFAAAAVmFsdWUB" +
           "AQ8DAC8BAEAJDwMAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBARMDAC4ARBMD" +
           "AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new AnalogItemState<double> Value
        {
            get
            {
                return m_value;
            }

            set
            {
                if (!Object.ReferenceEquals(m_value, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_value = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_value != null)
            {
                children.Add(m_value);
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
                case MyOPCUAServer.BrowseNames.Value:
                {
                    if (createOrReplace)
                    {
                        if (Value == null)
                        {
                            if (replacement == null)
                            {
                                Value = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Value = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Value;
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
        private AnalogItemState<double> m_value;
        #endregion
    }
    #endif
    #endregion

    #region GenericSensorState Class
    #if (!OPCUA_EXCLUDE_GenericSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericSensorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.GenericSensorType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
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
           "AABHZW5lcmljU2Vuc29yVHlwZUluc3RhbmNlAQEIAAEBCAAIAAAA/////wEAAAAVYIkKAgAAAAEABQAA" +
           "AFZhbHVlAQEVAwAvAQBACRUDAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEZ" +
           "AwAuAEQZAwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new AnalogItemState<double> Value
        {
            get
            {
                return m_value;
            }

            set
            {
                if (!Object.ReferenceEquals(m_value, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_value = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_value != null)
            {
                children.Add(m_value);
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
                case MyOPCUAServer.BrowseNames.Value:
                {
                    if (createOrReplace)
                    {
                        if (Value == null)
                        {
                            if (replacement == null)
                            {
                                Value = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Value = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Value;
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
        private AnalogItemState<double> m_value;
        #endregion
    }
    #endif
    #endregion

    #region TemperatureSensorState Class
    #if (!OPCUA_EXCLUDE_TemperatureSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureSensorState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public TemperatureSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.TemperatureSensor, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
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
           "AABUZW1wZXJhdHVyZVNlbnNvckluc3RhbmNlAQEbAwEBGwMbAwAA/////wEAAAAVYIkKAgAAAAEABQAA" +
           "AFZhbHVlAQEcAwAvAQBACRwDAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEg" +
           "AwAuAEQgAwAAAQB0A/////8BAf////8AAAAA";
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

    #region ProximitySensorState Class
    #if (!OPCUA_EXCLUDE_ProximitySensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProximitySensorState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public ProximitySensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.ProximitySensor, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
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
           "AABQcm94aW1pdHlTZW5zb3JJbnN0YW5jZQEBIgMBASIDIgMAAP////8BAAAAFWCJCgIAAAABAAUAAABW" +
           "YWx1ZQEBIwMALwEAQAkjAwAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBJwMA" +
           "LgBEJwMAAAEAdAP/////AQH/////AAAAAA==";
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

    #region MotorConveyorState Class
    #if (!OPCUA_EXCLUDE_MotorConveyorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MotorConveyorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public MotorConveyorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MotorConveyor, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
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
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABUA" +
           "AABNb3RvckNvbnZleW9ySW5zdGFuY2UBASkDAQEpAykDAAD/////AwAAABVgiQoCAAAAAQAFAAAAU3Bl" +
           "ZWQBASoDAC8BAEAJKgMAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAS4DAC4A" +
           "RC4DAAABAHQD/////wEB/////wAAAAAEYYIKBAAAAAEABQAAAFN0YXJ0AQEwAwAvAQEwAzADAAABAf//" +
           "//8AAAAABGGCCgQAAAABAAQAAABTdG9wAQExAwAvAQExAzEDAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Speed
        {
            get
            {
                return m_speed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speed = value;
            }
        }

        /// <remarks />
        public MethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
            }
        }

        /// <remarks />
        public MethodState Stop
        {
            get
            {
                return m_stopMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_speed != null)
            {
                children.Add(m_speed);
            }

            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            if (m_stopMethod != null)
            {
                children.Add(m_stopMethod);
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
                case MyOPCUAServer.BrowseNames.Speed:
                {
                    if (createOrReplace)
                    {
                        if (Speed == null)
                        {
                            if (replacement == null)
                            {
                                Speed = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Speed = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Speed;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new MethodState(this);
                            }
                            else
                            {
                                Start = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Stop:
                {
                    if (createOrReplace)
                    {
                        if (Stop == null)
                        {
                            if (replacement == null)
                            {
                                Stop = new MethodState(this);
                            }
                            else
                            {
                                Stop = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Stop;
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
        private AnalogItemState<double> m_speed;
        private MethodState m_startMethod;
        private MethodState m_stopMethod;
        #endregion
    }
    #endif
    #endregion

    #region MachineState Class
    #if (!OPCUA_EXCLUDE_MachineState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineState : FolderState
    {
        #region Constructors
        /// <remarks />
        public MachineState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MachineType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
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
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABMA" +
           "AABNYWNoaW5lVHlwZUluc3RhbmNlAQEyAwEBMgMyAwAA/////wMAAACEYIAKAQAAAAEACwAAAFRlbXBl" +
           "cmF0dXJlAQEzAwAvAQEbAzMDAAAB/////wEAAAAVYIkKAgAAAAEABQAAAFZhbHVlAQE0AwAvAQBACTQD" +
           "AAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQE4AwAuAEQ4AwAAAQB0A/////8B" +
           "Af////8AAAAAhGCACgEAAAABAAkAAABQcm94aW1pdHkBAToDAC8BASIDOgMAAAH/////AQAAABVgiQoC" +
           "AAAAAQAFAAAAVmFsdWUBATsDAC8BAEAJOwMAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAT8DAC4ARD8DAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEACAAAAENvbnZleW9yAQFB" +
           "AwAvAQEpA0EDAAAB/////wMAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQFCAwAvAQBACUIDAAAAC/////8D" +
           "A/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFGAwAuAERGAwAAAQB0A/////8BAf////8AAAAA" +
           "BGGCCgQAAAABAAUAAABTdGFydAEBSAMALwEBMANIAwAAAQH/////AAAAAARhggoEAAAAAQAEAAAAU3Rv" +
           "cAEBSQMALwEBMQNJAwAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public TemperatureSensorState Temperature
        {
            get
            {
                return m_temperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperature = value;
            }
        }

        /// <remarks />
        public ProximitySensorState Proximity
        {
            get
            {
                return m_proximity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_proximity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_proximity = value;
            }
        }

        /// <remarks />
        public MotorConveyorState Conveyor
        {
            get
            {
                return m_conveyor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conveyor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conveyor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_temperature != null)
            {
                children.Add(m_temperature);
            }

            if (m_proximity != null)
            {
                children.Add(m_proximity);
            }

            if (m_conveyor != null)
            {
                children.Add(m_conveyor);
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
                case MyOPCUAServer.BrowseNames.Temperature:
                {
                    if (createOrReplace)
                    {
                        if (Temperature == null)
                        {
                            if (replacement == null)
                            {
                                Temperature = new TemperatureSensorState(this);
                            }
                            else
                            {
                                Temperature = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = Temperature;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Proximity:
                {
                    if (createOrReplace)
                    {
                        if (Proximity == null)
                        {
                            if (replacement == null)
                            {
                                Proximity = new ProximitySensorState(this);
                            }
                            else
                            {
                                Proximity = (ProximitySensorState)replacement;
                            }
                        }
                    }

                    instance = Proximity;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Conveyor:
                {
                    if (createOrReplace)
                    {
                        if (Conveyor == null)
                        {
                            if (replacement == null)
                            {
                                Conveyor = new MotorConveyorState(this);
                            }
                            else
                            {
                                Conveyor = (MotorConveyorState)replacement;
                            }
                        }
                    }

                    instance = Conveyor;
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
        private TemperatureSensorState m_temperature;
        private ProximitySensorState m_proximity;
        private MotorConveyorState m_conveyor;
        #endregion
    }
    #endif
    #endregion

    #region OPCUAServerState Class
    #if (!OPCUA_EXCLUDE_OPCUAServerState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OPCUAServerState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public OPCUAServerState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.OPCUAServerType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
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
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////hGCAAgEAAAABABcA" +
           "AABPUENVQVNlcnZlclR5cGVJbnN0YW5jZQEBSgMBAUoDSgMAAAH/////AQAAAIRggAoBAAAAAQAHAAAA" +
           "TWFjaGluZQEBSwMALwEBMgNLAwAAAf////8DAAAAhGCACgEAAAABAAsAAABUZW1wZXJhdHVyZQEBTAMA" +
           "LwEBGwNMAwAAAf////8BAAAAFWCJCgIAAAABAAUAAABWYWx1ZQEBTQMALwEAQAlNAwAAAAv/////AQH/" +
           "////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBUQMALgBEUQMAAAEAdAP/////AQH/////AAAAAIRg" +
           "gAoBAAAAAQAJAAAAUHJveGltaXR5AQFTAwAvAQEiA1MDAAAB/////wEAAAAVYIkKAgAAAAEABQAAAFZh" +
           "bHVlAQFUAwAvAQBACVQDAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFYAwAu" +
           "AERYAwAAAQB0A/////8BAf////8AAAAAhGCACgEAAAABAAgAAABDb252ZXlvcgEBWgMALwEBKQNaAwAA" +
           "Af////8DAAAAFWCJCgIAAAABAAUAAABTcGVlZAEBWwMALwEAQAlbAwAAAAv/////AwP/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBXwMALgBEXwMAAAEAdAP/////AQH/////AAAAAARhggoEAAAAAQAF" +
           "AAAAU3RhcnQBAWEDAC8BATADYQMAAAEB/////wAAAAAEYYIKBAAAAAEABAAAAFN0b3ABAWIDAC8BATED" +
           "YgMAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MachineState Machine
        {
            get
            {
                return m_machine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machine = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_machine != null)
            {
                children.Add(m_machine);
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
                case MyOPCUAServer.BrowseNames.Machine:
                {
                    if (createOrReplace)
                    {
                        if (Machine == null)
                        {
                            if (replacement == null)
                            {
                                Machine = new MachineState(this);
                            }
                            else
                            {
                                Machine = (MachineState)replacement;
                            }
                        }
                    }

                    instance = Machine;
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
        private MachineState m_machine;
        #endregion
    }
    #endif
    #endregion

    #region MotorState Class
    #if (!OPCUA_EXCLUDE_MotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MotorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public MotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.MotorType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
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
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABEA" +
           "AABNb3RvclR5cGVJbnN0YW5jZQEBfAMBAXwDfAMAAP////8IAAAAFWCJCgIAAAABAAQAAABNb2RlAQF9" +
           "AwAvAD99AwAAAAH/////AwP/////AAAAABVgiQoCAAAAAQAFAAAAU3RhcnQBAX4DAC8AP34DAAAAAf//" +
           "//8DA/////8AAAAAFWCJCgIAAAABAAQAAABTdG9wAQF/AwAvAD9/AwAAAAH/////AwP/////AAAAABVg" +
           "iQoCAAAAAQAOAAAAU3RhcnRDb25kaXRpb24BAYADAC8AP4ADAAAAAf////8DA/////8AAAAAFWCJCgIA" +
           "AAABAA0AAABTdG9wQ29uZGl0aW9uAQGBAwAvAD+BAwAAAAH/////AwP/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAUnVuRmVlZGJhY2sBAYIDAC8AP4IDAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAAMAAABDTUQB" +
           "AYMDAC8AP4MDAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAAUAAABGYXVsdAEBhAMALwA/hAMAAAAB" +
           "/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> Mode
        {
            get
            {
                return m_mode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mode = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Start
        {
            get
            {
                return m_start;
            }

            set
            {
                if (!Object.ReferenceEquals(m_start, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_start = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Stop
        {
            get
            {
                return m_stop;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stop, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stop = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> StartCondition
        {
            get
            {
                return m_startCondition;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startCondition, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startCondition = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> StopCondition
        {
            get
            {
                return m_stopCondition;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopCondition, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopCondition = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> RunFeedback
        {
            get
            {
                return m_runFeedback;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runFeedback, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runFeedback = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> CMD
        {
            get
            {
                return m_cMD;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cMD, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cMD = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Fault
        {
            get
            {
                return m_fault;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fault, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fault = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mode != null)
            {
                children.Add(m_mode);
            }

            if (m_start != null)
            {
                children.Add(m_start);
            }

            if (m_stop != null)
            {
                children.Add(m_stop);
            }

            if (m_startCondition != null)
            {
                children.Add(m_startCondition);
            }

            if (m_stopCondition != null)
            {
                children.Add(m_stopCondition);
            }

            if (m_runFeedback != null)
            {
                children.Add(m_runFeedback);
            }

            if (m_cMD != null)
            {
                children.Add(m_cMD);
            }

            if (m_fault != null)
            {
                children.Add(m_fault);
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
                case MyOPCUAServer.BrowseNames.Mode:
                {
                    if (createOrReplace)
                    {
                        if (Mode == null)
                        {
                            if (replacement == null)
                            {
                                Mode = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Mode = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Mode;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Start = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Stop:
                {
                    if (createOrReplace)
                    {
                        if (Stop == null)
                        {
                            if (replacement == null)
                            {
                                Stop = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Stop = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Stop;
                    break;
                }

                case MyOPCUAServer.BrowseNames.StartCondition:
                {
                    if (createOrReplace)
                    {
                        if (StartCondition == null)
                        {
                            if (replacement == null)
                            {
                                StartCondition = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                StartCondition = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = StartCondition;
                    break;
                }

                case MyOPCUAServer.BrowseNames.StopCondition:
                {
                    if (createOrReplace)
                    {
                        if (StopCondition == null)
                        {
                            if (replacement == null)
                            {
                                StopCondition = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                StopCondition = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = StopCondition;
                    break;
                }

                case MyOPCUAServer.BrowseNames.RunFeedback:
                {
                    if (createOrReplace)
                    {
                        if (RunFeedback == null)
                        {
                            if (replacement == null)
                            {
                                RunFeedback = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                RunFeedback = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = RunFeedback;
                    break;
                }

                case MyOPCUAServer.BrowseNames.CMD:
                {
                    if (createOrReplace)
                    {
                        if (CMD == null)
                        {
                            if (replacement == null)
                            {
                                CMD = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                CMD = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = CMD;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Fault:
                {
                    if (createOrReplace)
                    {
                        if (Fault == null)
                        {
                            if (replacement == null)
                            {
                                Fault = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Fault = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Fault;
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
        private BaseDataVariableState<bool> m_mode;
        private BaseDataVariableState<bool> m_start;
        private BaseDataVariableState<bool> m_stop;
        private BaseDataVariableState<bool> m_startCondition;
        private BaseDataVariableState<bool> m_stopCondition;
        private BaseDataVariableState<bool> m_runFeedback;
        private BaseDataVariableState<bool> m_cMD;
        private BaseDataVariableState<bool> m_fault;
        #endregion
    }
    #endif
    #endregion

    #region TankBatchSystemState Class
    #if (!OPCUA_EXCLUDE_TankBatchSystemState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TankBatchSystemState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public TankBatchSystemState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MyOPCUAServer.ObjectTypes.TankBatchSystemType, MyOPCUAServer.Namespaces.MyOPCUAServer, namespaceUris);
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
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////hGCAAgEAAAABABsA" +
           "AABUYW5rQmF0Y2hTeXN0ZW1UeXBlSW5zdGFuY2UBAYUDAQGFA4UDAAAB/////wMAAACEYIAKAQAAAAEA" +
           "BgAAAE1vdG9yMQEBhgMALwEBfAOGAwAAAf////8IAAAAFWCJCgIAAAABAAQAAABNb2RlAQGHAwAvAD+H" +
           "AwAAAAH/////AwP/////AAAAABVgiQoCAAAAAQAFAAAAU3RhcnQBAYgDAC8AP4gDAAAAAf////8DA///" +
           "//8AAAAAFWCJCgIAAAABAAQAAABTdG9wAQGJAwAvAD+JAwAAAAH/////AwP/////AAAAABVgiQoCAAAA" +
           "AQAOAAAAU3RhcnRDb25kaXRpb24BAYoDAC8AP4oDAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAA0A" +
           "AABTdG9wQ29uZGl0aW9uAQGLAwAvAD+LAwAAAAH/////AwP/////AAAAABVgiQoCAAAAAQALAAAAUnVu" +
           "RmVlZGJhY2sBAYwDAC8AP4wDAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAAMAAABDTUQBAY0DAC8A" +
           "P40DAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAAUAAABGYXVsdAEBjgMALwA/jgMAAAAB/////wMD" +
           "/////wAAAACEYIAKAQAAAAEABgAAAE1vdG9yMgEBjwMALwEBfAOPAwAAAf////8IAAAAFWCJCgIAAAAB" +
           "AAQAAABNb2RlAQGQAwAvAD+QAwAAAAH/////AwP/////AAAAABVgiQoCAAAAAQAFAAAAU3RhcnQBAZED" +
           "AC8AP5EDAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAAQAAABTdG9wAQGSAwAvAD+SAwAAAAH/////" +
           "AwP/////AAAAABVgiQoCAAAAAQAOAAAAU3RhcnRDb25kaXRpb24BAZMDAC8AP5MDAAAAAf////8DA///" +
           "//8AAAAAFWCJCgIAAAABAA0AAABTdG9wQ29uZGl0aW9uAQGUAwAvAD+UAwAAAAH/////AwP/////AAAA" +
           "ABVgiQoCAAAAAQALAAAAUnVuRmVlZGJhY2sBAZUDAC8AP5UDAAAAAf////8DA/////8AAAAAFWCJCgIA" +
           "AAABAAMAAABDTUQBAZYDAC8AP5YDAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAAUAAABGYXVsdAEB" +
           "lwMALwA/lwMAAAAB/////wMD/////wAAAACEYIAKAQAAAAEABgAAAE1vdG9yMwEBmAMALwEBfAOYAwAA" +
           "Af////8IAAAAFWCJCgIAAAABAAQAAABNb2RlAQGZAwAvAD+ZAwAAAAH/////AwP/////AAAAABVgiQoC" +
           "AAAAAQAFAAAAU3RhcnQBAZoDAC8AP5oDAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAAQAAABTdG9w" +
           "AQGbAwAvAD+bAwAAAAH/////AwP/////AAAAABVgiQoCAAAAAQAOAAAAU3RhcnRDb25kaXRpb24BAZwD" +
           "AC8AP5wDAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAA0AAABTdG9wQ29uZGl0aW9uAQGdAwAvAD+d" +
           "AwAAAAH/////AwP/////AAAAABVgiQoCAAAAAQALAAAAUnVuRmVlZGJhY2sBAZ4DAC8AP54DAAAAAf//" +
           "//8DA/////8AAAAAFWCJCgIAAAABAAMAAABDTUQBAZ8DAC8AP58DAAAAAf////8DA/////8AAAAAFWCJ" +
           "CgIAAAABAAUAAABGYXVsdAEBoAMALwA/oAMAAAAB/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MotorState Motor1
        {
            get
            {
                return m_motor1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motor1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motor1 = value;
            }
        }

        /// <remarks />
        public MotorState Motor2
        {
            get
            {
                return m_motor2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motor2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motor2 = value;
            }
        }

        /// <remarks />
        public MotorState Motor3
        {
            get
            {
                return m_motor3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motor3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motor3 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_motor1 != null)
            {
                children.Add(m_motor1);
            }

            if (m_motor2 != null)
            {
                children.Add(m_motor2);
            }

            if (m_motor3 != null)
            {
                children.Add(m_motor3);
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
                case MyOPCUAServer.BrowseNames.Motor1:
                {
                    if (createOrReplace)
                    {
                        if (Motor1 == null)
                        {
                            if (replacement == null)
                            {
                                Motor1 = new MotorState(this);
                            }
                            else
                            {
                                Motor1 = (MotorState)replacement;
                            }
                        }
                    }

                    instance = Motor1;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Motor2:
                {
                    if (createOrReplace)
                    {
                        if (Motor2 == null)
                        {
                            if (replacement == null)
                            {
                                Motor2 = new MotorState(this);
                            }
                            else
                            {
                                Motor2 = (MotorState)replacement;
                            }
                        }
                    }

                    instance = Motor2;
                    break;
                }

                case MyOPCUAServer.BrowseNames.Motor3:
                {
                    if (createOrReplace)
                    {
                        if (Motor3 == null)
                        {
                            if (replacement == null)
                            {
                                Motor3 = new MotorState(this);
                            }
                            else
                            {
                                Motor3 = (MotorState)replacement;
                            }
                        }
                    }

                    instance = Motor3;
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
        private MotorState m_motor1;
        private MotorState m_motor2;
        private MotorState m_motor3;
        #endregion
    }
    #endif
    #endregion
}