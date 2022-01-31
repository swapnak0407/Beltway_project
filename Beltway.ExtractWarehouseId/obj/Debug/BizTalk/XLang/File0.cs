
#pragma warning disable 162

namespace Beltway.ExtractWarehouseId
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Beltway.ExtractWarehouseId.__messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid), 
            typeof(Beltway.ExtractWarehouseId.__messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_SQL_ExtractWarehouseid : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SQL_ExtractWarehouseid(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SQL_ExtractWarehouseid(PortType_SQL_ExtractWarehouseid p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SQL_ExtractWarehouseid p = new PortType_SQL_ExtractWarehouseid(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_SQL_ExtractWarehouseid),
            typeof(__messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid),
            typeof(__messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 151 "C:\Users\redde_ng_user1\documents\visual studio 2015\Projects\Beltway_integrate\Beltway.ExtractWarehouseId\orchExtractWarehouseId.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Beltway.ExtractWarehouseId.PortType_SQL_ExtractWarehouseid)
        },
        new System.String[] {
            "Port_SQL_ExtractWarehouseid"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eLongRunning
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class orchExtractWarehouseId : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String strWarehouseName,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] out System.String strWarehouseid)
        {
            strWarehouseid = default(System.String);
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(orchExtractWarehouseId));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static orchExtractWarehouseId()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __orchExtractWarehouseId_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public orchExtractWarehouseId(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "orchExtractWarehouseId", tracker)
        {
            ConstructorHelper();
        }

        public orchExtractWarehouseId(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "orchExtractWarehouseId")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>72e8b86c-ee2e-45a2-b2f7-2c8f22719789</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>95073097-888b-4fa8-9e09-379ab1513ca8</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>strWarehouseName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>013e0934-2279-483a-a857-76d87eec12d0</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>strWarehouseid</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ed000765-e03b-4948-8ab5-7e5145827993</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>msgExtractWarehouseidRequest</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>efef0d58-367f-4a54-aa2d-6ee57c9297b3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>d024c3e3-9fcc-4883-a2b4-b432800331cd</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>92bc92b9-f58a-4c8c-9fea-8af38e5a3938</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>reqWarehouseid</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>663f2aa7-df21-45f8-8add-917bbaa8b2b4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>rcvWarehouseId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>4dd77fef-d4b1-450f-8913-7736728dd164</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>strWarehouseid</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'orchExtractWarehouseId'</ActionName><IsAtomic>0</IsAtomic><Line>151</Line><Position>12</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>160</Line><Position>13</Position><ShapeID>'ed000765-e03b-4948-8ab5-7e5145827993'</ShapeID>
<Messages>
	<MsgInfo><name>msgExtractWarehouseidRequest</name><part>part</part><schema>Beltway.ExtractWarehouseId.TypedProcedure_dbo+spExtractWarehouseid</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>168</Line><Position>13</Position><ShapeID>'92bc92b9-f58a-4c8c-9fea-8af38e5a3938'</ShapeID>
<Messages>
	<MsgInfo><name>msgExtractWarehouseidRequest</name><part>part</part><schema>Beltway.ExtractWarehouseId.TypedProcedure_dbo+spExtractWarehouseid</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>170</Line><Position>13</Position><ShapeID>'663f2aa7-df21-45f8-8add-917bbaa8b2b4'</ShapeID>
<Messages>
	<MsgInfo><name>msgExtractWarehouseidResponse</name><part>part</part><schema>Beltway.ExtractWarehouseId.TypedProcedure_dbo+spExtractWarehouseidResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>172</Line><Position>28</Position><ShapeID>'4dd77fef-d4b1-450f-8913-7736728dd164'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='cff35739-5c01-4c3e-8cf4-9b062063b871' LowerBound='1.1' HigherBound='38.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Beltway.ExtractWarehouseId' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='b1df8b98-c3af-4270-a163-c1cce9b78723' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SQL_ExtractWarehouseid' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e178acac-2ee6-476f-b825-230493c0b1eb' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='12460e3e-b153-4eec-ad14-838a99236d59' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.52'>
                    <om:Property Name='Ref' Value='Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseid' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='4a2b1680-8c76-47d7-a431-5dfcf746f1c9' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.54' HigherBound='8.101'>
                    <om:Property Name='Ref' Value='Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseidResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='fde8b863-f8b0-4ad7-9451-dc0eb9c24c9c' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='37.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='orchExtractWarehouseId' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='LongRunningTransaction' OID='3d5d9515-ae0a-4c28-8951-862efd1fe1f4' ParentLink='ServiceDeclaration_Transaction' LowerBound='12.19' HigherBound='12.66'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_ExtractWarehouseid' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='fee5a631-dad5-4ae6-8def-8da62b840767' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseidResponse' />
                <om:Property Name='ParamDirection' Value='Out' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgExtractWarehouseidResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3527059a-98aa-42cd-8149-672d01368146' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='Type' Value='Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseid' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgExtractWarehouseidRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='72e8b86c-ee2e-45a2-b2f7-2c8f22719789' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='95073097-888b-4fa8-9e09-379ab1513ca8' ParentLink='ServiceBody_Declaration' LowerBound='18.15' HigherBound='18.45'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='strWarehouseName' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='013e0934-2279-483a-a857-76d87eec12d0' ParentLink='ServiceBody_Declaration' LowerBound='18.47' HigherBound='18.79'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='strWarehouseid' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='ed000765-e03b-4948-8ab5-7e5145827993' ParentLink='ServiceBody_Statement' LowerBound='20.1' HigherBound='28.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='msgExtractWarehouseidRequest' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='efef0d58-367f-4a54-aa2d-6ee57c9297b3' ParentLink='ComplexStatement_Statement' LowerBound='23.1' HigherBound='27.1'>
                        <om:Property Name='Expression' Value='msgExtractWarehouseidRequest = new System.Xml.XmlDocument();&#xD;&#xA;msgExtractWarehouseidRequest.WarehouseName = strWarehouseName;&#xD;&#xA;System.Diagnostics.Debug.WriteLine(&quot;CALL_ORCH_strWarehouseName&quot;,strWarehouseName);' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='d024c3e3-9fcc-4883-a2b4-b432800331cd' ParentLink='Construct_MessageRef' LowerBound='21.23' HigherBound='21.51'>
                        <om:Property Name='Ref' Value='msgExtractWarehouseidRequest' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='92bc92b9-f58a-4c8c-9fea-8af38e5a3938' ParentLink='ServiceBody_Statement' LowerBound='28.1' HigherBound='30.1'>
                    <om:Property Name='PortName' Value='Port_SQL_ExtractWarehouseid' />
                    <om:Property Name='MessageName' Value='msgExtractWarehouseidRequest' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='reqWarehouseid' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='663f2aa7-df21-45f8-8add-917bbaa8b2b4' ParentLink='ServiceBody_Statement' LowerBound='30.1' HigherBound='32.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='Port_SQL_ExtractWarehouseid' />
                    <om:Property Name='MessageName' Value='msgExtractWarehouseidResponse' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='rcvWarehouseId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='4dd77fef-d4b1-450f-8913-7736728dd164' ParentLink='ServiceBody_Statement' LowerBound='32.1' HigherBound='35.1'>
                    <om:Property Name='Expression' Value='strWarehouseid = xpath(msgExtractWarehouseidResponse,&quot;string(/*[local-name()=&apos;spExtractWarehouseidResponse&apos; and namespace-uri()=&apos;http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo&apos;]/*[local-name()=&apos;StoredProcedureResultSet0&apos; and namespace-uri()=&apos;http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo&apos;]/*[local-name()=&apos;StoredProcedureResultSet0&apos; and namespace-uri()=&apos;http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/spExtractWarehouseid&apos;]/*[local-name()=&apos;WarehouseId&apos; and namespace-uri()=&apos;http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/spExtractWarehouseid&apos;])&quot;);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;strWarehouseid&quot;,strWarehouseid);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='strWarehouseid' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='63b63379-3896-4f15-a13d-09deb5d2dea6' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='15' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Beltway.ExtractWarehouseId.PortType_SQL_ExtractWarehouseid' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_SQL_ExtractWarehouseid' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='a0e42e7b-51ab-44b7-9e49-b15bb566d188' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __orchExtractWarehouseId_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __orchExtractWarehouseId_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "orchExtractWarehouseId")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                orchExtractWarehouseId __svc__ = (orchExtractWarehouseId)_service;
                __orchExtractWarehouseId_root_0 __ctx0__ = (__orchExtractWarehouseId_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_SQL_ExtractWarehouseid != null)
                {
                    __svc__.Port_SQL_ExtractWarehouseid.Close(this, null);
                    __svc__.Port_SQL_ExtractWarehouseid = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __orchExtractWarehouseId_1 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __orchExtractWarehouseId_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "orchExtractWarehouseId")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                orchExtractWarehouseId __svc__ = (orchExtractWarehouseId)_service;
                __orchExtractWarehouseId_root_0 __ctx0__ = (__orchExtractWarehouseId_root_0)(__svc__._stateMgrs[0]);
                __orchExtractWarehouseId_1 __ctx1__ = (__orchExtractWarehouseId_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__strWarehouseName = null;
                if (__ctx1__ != null && __ctx1__.__msgExtractWarehouseidRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgExtractWarehouseidRequest);
                    __ctx1__.__msgExtractWarehouseidRequest = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgExtractWarehouseidResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgExtractWarehouseidResponse);
                    __ctx1__.__msgExtractWarehouseidResponse = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgExtractWarehouseidResponse")]
            public __messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse __msgExtractWarehouseidResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgExtractWarehouseidRequest")]
            public __messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid __msgExtractWarehouseidRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strWarehouseName")]
            internal System.String __strWarehouseName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strWarehouseid")]
            internal System.String __strWarehouseid;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_SQL_ExtractWarehouseid")]
        internal PortType_SQL_ExtractWarehouseid Port_SQL_ExtractWarehouseid;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SQL_ExtractWarehouseid.Operation_1},
                                               typeof(orchExtractWarehouseId).GetField("Port_SQL_ExtractWarehouseid", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(orchExtractWarehouseId), "Port_SQL_ExtractWarehouseid"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "ed000765-e03b-4948-8ab5-7e5145827993", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "ed000765-e03b-4948-8ab5-7e5145827993", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "92bc92b9-f58a-4c8c-9fea-8af38e5a3938", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "92bc92b9-f58a-4c8c-9fea-8af38e5a3938", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "663f2aa7-df21-45f8-8add-917bbaa8b2b4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "663f2aa7-df21-45f8-8add-917bbaa8b2b4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "4dd77fef-d4b1-450f-8913-7736728dd164", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "4dd77fef-d4b1-450f-8913-7736728dd164", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,2,2,3,4,4,4,5,6,6,7,8,8,9,9,1,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __orchExtractWarehouseId_root_0 __ctx0__ = (__orchExtractWarehouseId_root_0)_stateMgrs[0];
            __orchExtractWarehouseId_1 __ctx1__ = (__orchExtractWarehouseId_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_SQL_ExtractWarehouseid = new PortType_SQL_ExtractWarehouseid(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __orchExtractWarehouseId_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __orchExtractWarehouseId_root_0 __ctx0__ = (__orchExtractWarehouseId_root_0)_stateMgrs[0];
            __orchExtractWarehouseId_1 __ctx1__ = (__orchExtractWarehouseId_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__strWarehouseName = (System.String)Args[0];
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__strWarehouseid = default(System.String);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                {
                    __messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid __msgExtractWarehouseidRequest = new __messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid("msgExtractWarehouseidRequest", __ctx1__);

                    __msgExtractWarehouseidRequest.part.LoadFrom(new System.Xml.XmlDocument());
                    __msgExtractWarehouseidRequest.part.SetDistinguishedField("WarehouseName", __ctx1__.__strWarehouseName);
                    System.Diagnostics.Debug.WriteLine("CALL_ORCH_strWarehouseName", __ctx1__.__strWarehouseName);
                    if (__ctx1__ != null)
                        __ctx1__.__strWarehouseName = null;

                    if (__ctx1__.__msgExtractWarehouseidRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgExtractWarehouseidRequest);
                    __ctx1__.__msgExtractWarehouseidRequest = __msgExtractWarehouseidRequest;
                    __ctx1__.RefMessage(__ctx1__.__msgExtractWarehouseidRequest);
                }
                __ctx1__.__msgExtractWarehouseidRequest.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgExtractWarehouseidRequest);
                    Tracker.FireEvent(__eventLocations[3],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_SQL_ExtractWarehouseid.SendMessage(0, __ctx1__.__msgExtractWarehouseidRequest, null, null, out __ctx0__.__subWrapper0, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgExtractWarehouseidRequest);
                    __edata.PortName = @"Port_SQL_ExtractWarehouseid";
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgExtractWarehouseidRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgExtractWarehouseidRequest);
                    __ctx1__.__msgExtractWarehouseidRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!Port_SQL_ExtractWarehouseid.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__msgExtractWarehouseidResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgExtractWarehouseidResponse);
                __ctx1__.__msgExtractWarehouseidResponse = new __messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse("msgExtractWarehouseidResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgExtractWarehouseidResponse);
                Port_SQL_ExtractWarehouseid.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgExtractWarehouseidResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Port_SQL_ExtractWarehouseid != null)
                {
                    Port_SQL_ExtractWarehouseid.Close(__ctx1__, __seg__);
                    Port_SQL_ExtractWarehouseid = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgExtractWarehouseidResponse);
                    __edata.PortName = @"Port_SQL_ExtractWarehouseid";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                __ctx1__.__strWarehouseid = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgExtractWarehouseidResponse.part, "string(/*[local-name()='spExtractWarehouseidResponse' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/spExtractWarehouseid']/*[local-name()='WarehouseId' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/spExtractWarehouseid'])", typeof(System.String));
                if (__ctx1__ != null && __ctx1__.__msgExtractWarehouseidResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgExtractWarehouseidResponse);
                    __ctx1__.__msgExtractWarehouseidResponse = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                System.Diagnostics.EventLog.WriteEntry("strWarehouseid", __ctx1__.__strWarehouseid);
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 20;
            case 20:
                Args[1] = __ctx1__.__strWarehouseid;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{DAC6B48C-5F9F-445D-AC1C-643C58E6A36B}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseid _schema = new Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseid();

        public __Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseid",
        new System.Type[]{
            typeof(Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseid)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#spExtractWarehouseid"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid__ part;

        private void __CreatePartWrappers()
        {
            part = new __Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseid(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseidResponse _schema = new Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseidResponse();

        public __Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseidResponse",
        new System.Type[]{
            typeof(Beltway.ExtractWarehouseId.TypedProcedure_dbo.spExtractWarehouseidResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#spExtractWarehouseidResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Beltway_ExtractWarehouseId_TypedProcedure_dbo_spExtractWarehouseidResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
