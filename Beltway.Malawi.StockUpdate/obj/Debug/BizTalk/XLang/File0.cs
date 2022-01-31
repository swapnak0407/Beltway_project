
#pragma warning disable 162

namespace Beltway.Malawi.StockUpdate
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "GetMalaviStockdetails",
        new System.Type[]{
            typeof(Beltway.Malawi.StockUpdate.__messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate), 
            typeof(Beltway.Malawi.StockUpdate.__messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_RcvMalaviStockdetails : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_RcvMalaviStockdetails(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_RcvMalaviStockdetails(PortType_RcvMalaviStockdetails p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_RcvMalaviStockdetails p = new PortType_RcvMalaviStockdetails(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo GetMalaviStockdetails = new Microsoft.XLANGs.Core.OperationInfo
        (
            "GetMalaviStockdetails",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_RcvMalaviStockdetails),
            typeof(__messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate),
            typeof(__messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "GetMalaviStockdetails" ] = GetMalaviStockdetails;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 282 "C:\Users\redde_ng_user1\documents\visual studio 2015\Projects\Beltway_integrate\Beltway.Malawi.StockUpdate\ProcessMalawiStockUpdate.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "GetMalaviStockdetails", "GetMalaviStockdetails", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(Beltway.Malawi.StockUpdate.PortType_RcvMalaviStockdetails)
        },
        new System.String[] {
            "GetMalaviStockdetails"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(Beltway.Skegness.CentralSystemUpdate.ProcessUpdateStockdetailsSQL)
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eLongRunning
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ProcessMalawiStockUpdate : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
                "Beltway.Skegness.CentralSystemUpdate.ProcessUpdateStockdetailsSQL"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ProcessMalawiStockUpdate));
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

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static ProcessMalawiStockUpdate()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3)
            };

            _Locks = 0;
            _rootContext = new __ProcessMalawiStockUpdate_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[4];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ProcessMalawiStockUpdate(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ProcessMalawiStockUpdate", tracker)
        {
            ConstructorHelper();
        }

        public ProcessMalawiStockUpdate(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ProcessMalawiStockUpdate")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>6c8d97d2-18ec-4fff-bba1-58057869a3c3</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>e64278a6-cae3-4344-ac4f-a464c48838ee</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>rcvRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>116da85c-c7d4-4c85-95cb-8d696949f766</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_Malawi</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>LongRunningTransactionShape</shapeType>      <ShapeID>e808b825-629f-4bc8-8474-c98af1e5722b</ShapeID>      <ParentLink>Scope_Transaction</ParentLink>                <shapeText>Transaction_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>2212511a-e5b6-4df2-9bad-411ce87f3683</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>strWarehouseName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>218d0125-04f7-48ea-9c96-9dcc18780c4a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>msgCanonical</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>81f23c97-afcf-4c79-95ea-b7c60818bbce</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9736ad13-6edc-4c59-a575-91cffbfa7af9</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>276ae0d4-f681-462b-9a28-c76b5ea8d466</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>d9f16e41-9943-4037-b98c-5e66df63ff31</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>41a45287-adae-42ff-a8f5-5ee90b424095</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CallOrchestration_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>177659a0-8430-4c45-8152-8401fe61b89a</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>msgCanonical</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>e2b90881-e0ee-4a93-ab13-a86ac75e6ec3</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>out_Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>3f40e888-e970-45cc-ad6c-d7484530b056</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>623f17c8-65bd-4fb6-a6c3-55686cd63077</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Success</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a0ae9241-b6a2-42d5-bc75-7d5816da0b2d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>msgResponse</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>90e20926-3e20-4a74-a26a-757ff8987b44</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>72647922-3d85-47a9-85a6-ae97361dd320</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7d40668d-afd9-45be-a009-621d39d65c05</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>9331c748-dacc-416b-a659-2708be564c06</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>cb85a735-dc3b-4ec2-a27c-82cdf9e39644</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>msgResponse</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>c368fd58-f5eb-4adc-ae81-6096bb597bc4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>083f5720-0666-4e72-a30a-a9e2fe28d002</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>91b253e9-0a52-4524-a697-1fdbc443aa53</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>b3214639-c9de-4413-945b-1d816bed652a</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d1955e70-a44c-42a2-9f79-096cc2bd3cd7</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ProcessMalawiStockUpdate'</ActionName><IsAtomic>0</IsAtomic><Line>282</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>295</Line><Position>22</Position><ShapeID>'e64278a6-cae3-4344-ac4f-a464c48838ee'</ShapeID>
<Messages>
	<MsgInfo><name>msgMalaviStockRequest</name><part>part</part><schema>Beltway.Malawi.StockUpdate.Malawi_Stockupdate</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'Transaction_2'</ActionName><IsAtomic>0</IsAtomic><Line>300</Line><Position>13</Position><ShapeID>'116da85c-c7d4-4c85-95cb-8d696949f766'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>306</Line><Position>38</Position><ShapeID>'2212511a-e5b6-4df2-9bad-411ce87f3683'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>312</Line><Position>21</Position><ShapeID>'218d0125-04f7-48ea-9c96-9dcc18780c4a'</ShapeID>
<Messages>
	<MsgInfo><name>msgCanonical</name><part>part</part><schema>Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgMalaviStockRequest</name><part>part</part><schema>Beltway.Malawi.StockUpdate.Malawi_Stockupdate</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>318</Line><Position>92</Position><ShapeID>'41a45287-adae-42ff-a8f5-5ee90b424095'</ShapeID>
<Messages>
	<MsgInfo><name>msgCanonical</name><part>part</part><schema>Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>320</Line><Position>21</Position><ShapeID>'3f40e888-e970-45cc-ad6c-d7484530b056'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>323</Line><Position>25</Position><ShapeID>'a0ae9241-b6a2-42d5-bc75-7d5816da0b2d'</ShapeID>
<Messages>
	<MsgInfo><name>msgResponse</name><part>part</part><schema>Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>333</Line><Position>25</Position><ShapeID>'7d40668d-afd9-45be-a009-621d39d65c05'</ShapeID>
<Messages>
	<MsgInfo><name>msgResponse</name><part>part</part><schema>Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>338</Line><Position>25</Position><ShapeID>'cb85a735-dc3b-4ec2-a27c-82cdf9e39644'</ShapeID>
<Messages>
	<MsgInfo><name>msgResponse</name><part>part</part><schema>Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>347</Line><Position>25</Position><ShapeID>'91b253e9-0a52-4524-a697-1fdbc443aa53'</ShapeID>
<Messages>
	<MsgInfo><name>msgResponse</name><part>part</part><schema>Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>353</Line><Position>21</Position><ShapeID>'b3214639-c9de-4413-945b-1d816bed652a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>356</Line><Position>63</Position><ShapeID>'d1955e70-a44c-42a2-9f79-096cc2bd3cd7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='638c739c-f63b-4daa-ae02-5372d70b9339' LowerBound='1.1' HigherBound='94.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Beltway.Malawi.StockUpdate' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='ee927d3c-1b4f-4987-a3f7-91b1bbfcc939' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_RcvMalaviStockdetails' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7f7536f4-8960-4872-84af-f8ddc4ea3a13' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GetMalaviStockdetails' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='3eccc804-74d7-4bea-a2a4-d9589d44e565' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.31'>
                    <om:Property Name='Ref' Value='Beltway.Malawi.StockUpdate.Malawi_Stockupdate' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='638ab059-7fca-4ab5-8dfe-8497c9fdb5e7' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.33' HigherBound='8.60'>
                    <om:Property Name='Ref' Value='Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='ff21931d-d5ea-40aa-9f49-4aa440e277e9' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='93.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ProcessMalawiStockUpdate' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='b8735880-3808-410c-9c3c-3114ca9b333f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strWarehouseName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a0976ddf-6d46-4d96-8173-6bb9e5c8cdcd' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='out_Result' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1786a2c4-1e3c-4637-a6dd-3c1cbf976801' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xmlDocMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='LongRunningTransaction' OID='8b342893-8481-49c6-b8c6-5b017d455628' ParentLink='ServiceDeclaration_Transaction' LowerBound='12.21' HigherBound='12.70'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='13408d91-9950-476a-9f53-af4e8bb34b33' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='Beltway.Malawi.StockUpdate.Malawi_Stockupdate' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgMalaviStockRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='24cc6811-140e-4c5c-9380-d01b192455dd' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='Type' Value='Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCanonical' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='06a62ccd-b719-4199-8012-a6e48e93eebb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='Type' Value='Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='6c8d97d2-18ec-4fff-bba1-58057869a3c3' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='e64278a6-cae3-4344-ac4f-a464c48838ee' ParentLink='ServiceBody_Statement' LowerBound='24.1' HigherBound='29.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='GetMalaviStockdetails' />
                    <om:Property Name='MessageName' Value='msgMalaviStockRequest' />
                    <om:Property Name='OperationName' Value='GetMalaviStockdetails' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='rcvRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='116da85c-c7d4-4c85-95cb-8d696949f766' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='91.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_Malawi' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='LongRunningTransaction' OID='e808b825-629f-4bc8-8474-c98af1e5722b' ParentLink='Scope_Transaction' LowerBound='30.18' HigherBound='30.56'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transaction_2' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='2212511a-e5b6-4df2-9bad-411ce87f3683' ParentLink='ComplexStatement_Statement' LowerBound='34.1' HigherBound='41.1'>
                        <om:Property Name='Expression' Value='&#xD;&#xA;strWarehouseName = &quot;Malawi&quot;;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;strWarehousename: &quot;,strWarehouseName);&#xD;&#xA;&#xD;&#xA;// strProductcode = xpath(msgStockupdateDetails,&quot;string(/*[local-name()=&apos;TanzaniaStockDetails&apos; and namespace-uri()=&apos;http://Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF&apos;]/*[local-name()=&apos;StockDetails&apos; and namespace-uri()=&apos;&apos;]/*[local-name()=&apos;ProductCode&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;//  System.Diagnostics.EventLog.WriteEntry(&quot;strProductcode: &quot;,strProductcode);&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='strWarehouseName' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Construct' OID='218d0125-04f7-48ea-9c96-9dcc18780c4a' ParentLink='ComplexStatement_Statement' LowerBound='41.1' HigherBound='47.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='msgCanonical' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='81f23c97-afcf-4c79-95ea-b7c60818bbce' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='46.1'>
                            <om:Property Name='ClassName' Value='Beltway.Malawi.StockUpdate.mapMalaviStockdetailsToHeadofficeCanonical' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='MessagePartRef' OID='9736ad13-6edc-4c59-a575-91cffbfa7af9' ParentLink='Transform_InputMessagePartRef' LowerBound='45.123' HigherBound='45.144'>
                                <om:Property Name='MessageRef' Value='msgMalaviStockRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='276ae0d4-f681-462b-9a28-c76b5ea8d466' ParentLink='Transform_OutputMessagePartRef' LowerBound='45.36' HigherBound='45.48'>
                                <om:Property Name='MessageRef' Value='msgCanonical' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='d9f16e41-9943-4037-b98c-5e66df63ff31' ParentLink='Construct_MessageRef' LowerBound='42.31' HigherBound='42.43'>
                            <om:Property Name='Ref' Value='msgCanonical' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Call' OID='41a45287-adae-42ff-a8f5-5ee90b424095' ParentLink='ComplexStatement_Statement' LowerBound='47.1' HigherBound='49.1'>
                        <om:Property Name='Identifier' Value='CallOrchestration_1' />
                        <om:Property Name='Invokee' Value='Beltway.Skegness.CentralSystemUpdate.ProcessUpdateStockdetailsSQL' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CallOrchestration_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Parameter' OID='177659a0-8430-4c45-8152-8401fe61b89a' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='In' />
                            <om:Property Name='Name' Value='msgCanonical' />
                            <om:Property Name='Type' Value='Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Parameter' OID='e2b90881-e0ee-4a93-ab13-a86ac75e6ec3' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='Out' />
                            <om:Property Name='Name' Value='out_Result' />
                            <om:Property Name='Type' Value='System.String' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Decision' OID='3f40e888-e970-45cc-ad6c-d7484530b056' ParentLink='ComplexStatement_Statement' LowerBound='49.1' HigherBound='79.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Decide_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='DecisionBranch' OID='623f17c8-65bd-4fb6-a6c3-55686cd63077' ParentLink='ReallyComplexStatement_Branch' LowerBound='50.21' HigherBound='65.1'>
                            <om:Property Name='Expression' Value='out_Result == &quot;Success&quot;' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Success' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='a0ae9241-b6a2-42d5-bc75-7d5816da0b2d' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='62.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='msgResponse' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='90e20926-3e20-4a74-a26a-757ff8987b44' ParentLink='ComplexStatement_Statement' LowerBound='55.1' HigherBound='61.1'>
                                    <om:Property Name='Expression' Value='xmlDocMessage = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;xmlDocMessage.LoadXml(&quot;&lt;ns0:Response xmlns:ns0=\&quot;http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response\&quot;&gt;&lt;Result&gt;Success&lt;/Result&gt;&lt;/ns0:Response&gt;&quot;);&#xD;&#xA;msgResponse = xmlDocMessage;&#xD;&#xA;msgResponse.Result = &quot;Success&quot;;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_1' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='72647922-3d85-47a9-85a6-ae97361dd320' ParentLink='Construct_MessageRef' LowerBound='53.35' HigherBound='53.46'>
                                    <om:Property Name='Ref' Value='msgResponse' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='7d40668d-afd9-45be-a009-621d39d65c05' ParentLink='ComplexStatement_Statement' LowerBound='62.1' HigherBound='64.1'>
                                <om:Property Name='PortName' Value='GetMalaviStockdetails' />
                                <om:Property Name='MessageName' Value='msgResponse' />
                                <om:Property Name='OperationName' Value='GetMalaviStockdetails' />
                                <om:Property Name='OperationMessageName' Value='Response' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='9331c748-dacc-416b-a659-2708be564c06' ParentLink='ReallyComplexStatement_Branch'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Else' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='cb85a735-dc3b-4ec2-a27c-82cdf9e39644' ParentLink='ComplexStatement_Statement' LowerBound='67.1' HigherBound='76.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='msgResponse' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='c368fd58-f5eb-4adc-ae81-6096bb597bc4' ParentLink='ComplexStatement_Statement' LowerBound='70.1' HigherBound='75.1'>
                                    <om:Property Name='Expression' Value='xmlDocMessage = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;xmlDocMessage.LoadXml(&quot;&lt;ns0:Response xmlns:ns0=\&quot;http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response\&quot;&gt;&lt;Result&gt;Failed&lt;/Result&gt;&lt;/ns0:Response&gt;&quot;);&#xD;&#xA;msgResponse = xmlDocMessage;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_1' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='083f5720-0666-4e72-a30a-a9e2fe28d002' ParentLink='Construct_MessageRef' LowerBound='68.35' HigherBound='68.46'>
                                    <om:Property Name='Ref' Value='msgResponse' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='91b253e9-0a52-4524-a697-1fdbc443aa53' ParentLink='ComplexStatement_Statement' LowerBound='76.1' HigherBound='78.1'>
                                <om:Property Name='PortName' Value='GetMalaviStockdetails' />
                                <om:Property Name='MessageName' Value='msgResponse' />
                                <om:Property Name='OperationName' Value='GetMalaviStockdetails' />
                                <om:Property Name='OperationMessageName' Value='Response' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='b3214639-c9de-4413-945b-1d816bed652a' ParentLink='Scope_Catch' LowerBound='82.1' HigherBound='89.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='d1955e70-a44c-42a2-9f79-096cc2bd3cd7' ParentLink='Catch_Statement' LowerBound='85.1' HigherBound='88.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;Exception caught: &quot;,ex.Message);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Error-Malawi Process&quot;,ex.InnerException.ToString(),System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3fb13c3c-4ff4-448e-8cb1-651dbc28cae9' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Beltway.Malawi.StockUpdate.PortType_RcvMalaviStockdetails' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GetMalaviStockdetails' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='92b0030a-5c8a-4d02-bab6-0b568f636197' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ProcessMalawiStockUpdate_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ProcessMalawiStockUpdate_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessMalawiStockUpdate")
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
                ProcessMalawiStockUpdate __svc__ = (ProcessMalawiStockUpdate)_service;
                __ProcessMalawiStockUpdate_root_0 __ctx0__ = (__ProcessMalawiStockUpdate_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.GetMalaviStockdetails != null)
                {
                    __svc__.GetMalaviStockdetails.Close(this, null);
                    __svc__.GetMalaviStockdetails = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ProcessMalawiStockUpdate_1 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __ProcessMalawiStockUpdate_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessMalawiStockUpdate")
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
                ProcessMalawiStockUpdate __svc__ = (ProcessMalawiStockUpdate)_service;
                __ProcessMalawiStockUpdate_1 __ctx1__ = (__ProcessMalawiStockUpdate_1)(__svc__._stateMgrs[1]);
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);

                if (__ctx1__ != null && __ctx1__.__msgMalaviStockRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgMalaviStockRequest);
                    __ctx1__.__msgMalaviStockRequest = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__strWarehouseName = null;
                if (__ctx1__ != null && __ctx1__.__msgResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgResponse);
                    __ctx1__.__msgResponse = null;
                }
                if (__ctx2__ != null && __ctx2__.__msgCanonical != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgCanonical);
                    __ctx2__.__msgCanonical = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__strWarehouseName = null;
                if (__ctx1__ != null)
                    __ctx1__.__xmlDocMessage = null;
                if (__ctx2__ != null)
                    __ctx2__.__out_Result = null;
                if (__ctx2__ != null && __ctx2__.__msgResponse != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgResponse);
                    __ctx2__.__msgResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCanonical != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                    __ctx1__.__msgCanonical = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__out_Result = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgMalaviStockRequest")]
            public __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate __msgMalaviStockRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCanonical")]
            public __messagetype_Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema __msgCanonical;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgResponse")]
            public __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response __msgResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strWarehouseName")]
            internal System.String __strWarehouseName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("out_Result")]
            internal System.String __out_Result;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xmlDocMessage")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __xmlDocMessage;
        }


        [System.SerializableAttribute]
        public class __Transaction_2_2 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __Transaction_2_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Transaction_2")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[3];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                ProcessMalawiStockUpdate __svc__ = (ProcessMalawiStockUpdate)_service;
                __ProcessMalawiStockUpdate_1 __ctx1__ = (__ProcessMalawiStockUpdate_1)(__svc__._stateMgrs[1]);
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);

                __ctx1__.__strWarehouseName = __ctx2__.__strWarehouseName;
                if (__ctx1__.__msgCanonical != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                __ctx1__.__msgCanonical = __ctx2__.__msgCanonical;
                if (__ctx2__.__msgCanonical != null)
                    __ctx1__.RefMessage(__ctx1__.__msgCanonical);
                __ctx1__.__out_Result = __ctx2__.__out_Result;
                if (__ctx1__.__msgResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgResponse);
                __ctx1__.__msgResponse = __ctx2__.__msgResponse;
                if (__ctx2__.__msgResponse != null)
                    __ctx1__.RefMessage(__ctx1__.__msgResponse);
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCanonical")]
            public __messagetype_Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema __msgCanonical;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgResponse")]
            public __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response __msgResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strWarehouseName")]
            internal System.String __strWarehouseName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("out_Result")]
            internal System.String __out_Result;
            internal object __exv__;
            internal System.Exception __ex_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
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
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("GetMalaviStockdetails")]
        internal PortType_RcvMalaviStockdetails GetMalaviStockdetails;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_RcvMalaviStockdetails.GetMalaviStockdetails},
                                               typeof(ProcessMalawiStockUpdate).GetField("GetMalaviStockdetails", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessMalawiStockUpdate), "GetMalaviStockdetails"),
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
                    typeof(Beltway.Skegness.CentralSystemUpdate.ProcessUpdateStockdetailsSQL)                    
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

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "e64278a6-cae3-4344-ac4f-a464c48838ee", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "e64278a6-cae3-4344-ac4f-a464c48838ee", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "116da85c-c7d4-4c85-95cb-8d696949f766", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "2212511a-e5b6-4df2-9bad-411ce87f3683", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "2212511a-e5b6-4df2-9bad-411ce87f3683", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "218d0125-04f7-48ea-9c96-9dcc18780c4a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "218d0125-04f7-48ea-9c96-9dcc18780c4a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "41a45287-adae-42ff-a8f5-5ee90b424095", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "41a45287-adae-42ff-a8f5-5ee90b424095", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "3f40e888-e970-45cc-ad6c-d7484530b056", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "a0ae9241-b6a2-42d5-bc75-7d5816da0b2d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "a0ae9241-b6a2-42d5-bc75-7d5816da0b2d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "7d40668d-afd9-45be-a009-621d39d65c05", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "7d40668d-afd9-45be-a009-621d39d65c05", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "cb85a735-dc3b-4ec2-a27c-82cdf9e39644", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "cb85a735-dc3b-4ec2-a27c-82cdf9e39644", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "91b253e9-0a52-4524-a697-1fdbc443aa53", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "91b253e9-0a52-4524-a697-1fdbc443aa53", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "3f40e888-e970-45cc-ad6c-d7484530b056", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "b3214639-c9de-4413-945b-1d816bed652a", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "d1955e70-a44c-42a2-9f79-096cc2bd3cd7", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "d1955e70-a44c-42a2-9f79-096cc2bd3cd7", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "b3214639-c9de-4413-945b-1d816bed652a", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "116da85c-c7d4-4c85-95cb-8d696949f766", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,4,4,4,29,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,7,9,9,10,11,11,12,13,13,14,14,15,16,16,16,17,13,18,18,19,20,20,20,21,22,22,22,22,};
        public static int[] __progressLocation3 = new int[] { 23,23,24,24,25,25,28,28,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ProcessMalawiStockUpdate_1 __ctx1__ = (__ProcessMalawiStockUpdate_1)_stateMgrs[1];
            __ProcessMalawiStockUpdate_root_0 __ctx0__ = (__ProcessMalawiStockUpdate_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                GetMalaviStockdetails = new PortType_RcvMalaviStockdetails(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], GetMalaviStockdetails, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ProcessMalawiStockUpdate_1(this);
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
            __ProcessMalawiStockUpdate_1 __ctx1__ = (__ProcessMalawiStockUpdate_1)_stateMgrs[1];
            __ProcessMalawiStockUpdate_root_0 __ctx0__ = (__ProcessMalawiStockUpdate_root_0)_stateMgrs[0];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__strWarehouseName = default(System.String);
                __ctx1__.__out_Result = default(System.String);
                __ctx1__.__xmlDocMessage = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!GetMalaviStockdetails.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgMalaviStockRequest != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgMalaviStockRequest);
                __ctx1__.__msgMalaviStockRequest = new __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate("msgMalaviStockRequest", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgMalaviStockRequest);
                GetMalaviStockdetails.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgMalaviStockRequest, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgMalaviStockRequest);
                    __edata.PortName = @"GetMalaviStockdetails";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__strWarehouseName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__out_Result = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__xmlDocMessage.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                __ctx2__ = new __Transaction_2_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__xmlDocMessage = null;
                if (__ctx1__ != null && __ctx1__.__msgMalaviStockRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgMalaviStockRequest);
                    __ctx1__.__msgMalaviStockRequest = null;
                }
                if (GetMalaviStockdetails != null)
                {
                    GetMalaviStockdetails.Close(__ctx1__, __seg__);
                    GetMalaviStockdetails = null;
                }
                Tracker.FireEvent(__eventLocations[29],__eventData[13],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (__ctx2__ != null)
                    __ctx2__.__out_Result = null;
                if (__ctx2__ != null)
                    __ctx2__.__strWarehouseName = null;
                if (__ctx2__ != null && __ctx2__.__msgResponse != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgResponse);
                    __ctx2__.__msgResponse = null;
                }
                if (__ctx2__ != null && __ctx2__.__msgCanonical != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgCanonical);
                    __ctx2__.__msgCanonical = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__out_Result = null;
                if (__ctx1__ != null)
                    __ctx1__.__strWarehouseName = null;
                if (__ctx1__ != null && __ctx1__.__msgResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgResponse);
                    __ctx1__.__msgResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCanonical != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                    __ctx1__.__msgCanonical = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[14],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __ProcessMalawiStockUpdate_1 __ctx1__ = (__ProcessMalawiStockUpdate_1)_stateMgrs[1];
            __ProcessMalawiStockUpdate_root_0 __ctx0__ = (__ProcessMalawiStockUpdate_root_0)_stateMgrs[0];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx2__.__strWarehouseName = __ctx1__.__strWarehouseName;
                __ctx2__.__msgCanonical = __ctx1__.__msgCanonical;
                if (__ctx2__.__msgCanonical != null)
                    __ctx2__.RefMessage(__ctx2__.__msgCanonical);
                __ctx2__.__out_Result = __ctx1__.__out_Result;
                __ctx2__.__msgResponse = __ctx1__.__msgResponse;
                if (__ctx2__.__msgResponse != null)
                    __ctx2__.RefMessage(__ctx2__.__msgResponse);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx2__.__strWarehouseName = "Malawi";
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                System.Diagnostics.EventLog.WriteEntry("strWarehousename: ", __ctx2__.__strWarehouseName);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema __msgCanonical = new __messagetype_Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema("msgCanonical", __ctx2__);

                    ApplyTransform(typeof(Beltway.Malawi.StockUpdate.mapMalaviStockdetailsToHeadofficeCanonical), new object[] {__msgCanonical.part}, new object[] {__ctx1__.__msgMalaviStockRequest.part});

                    if (__ctx2__.__msgCanonical != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgCanonical);
                    __ctx2__.__msgCanonical = __msgCanonical;
                    __ctx2__.RefMessage(__ctx2__.__msgCanonical);
                }
                __ctx2__.__msgCanonical.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgCanonical);
                    __edata.Messages.Add(__ctx1__.__msgMalaviStockRequest);
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    Microsoft.XLANGs.Core.Service svc = new Beltway.Skegness.CentralSystemUpdate.ProcessUpdateStockdetailsSQL(3, InstanceId, this);
                    _stateMgrs[3] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[11],new object[] {__ctx2__.__msgCanonical, null});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[3]).Args;
                    __ctx2__.__out_Result = (System.String)args[1];
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx2__.__msgCanonical);
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __condition__ = __ctx2__.__out_Result == "Success";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 21;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                {
                    __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response __msgResponse = new __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response("msgResponse", __ctx2__);

                    __ctx1__.__xmlDocMessage.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__xmlDocMessage.UnderlyingXmlDocument.LoadXml("<ns0:Response xmlns:ns0=\"http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response\"><Result>Success</Result></ns0:Response>");
                    __msgResponse.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__xmlDocMessage.UnderlyingXmlDocument);
                    __msgResponse.part.SetDistinguishedField("Result", "Success");

                    if (__ctx2__.__msgResponse != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgResponse);
                    __ctx2__.__msgResponse = __msgResponse;
                    __ctx2__.RefMessage(__ctx2__.__msgResponse);
                }
                __ctx2__.__msgResponse.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgResponse);
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                GetMalaviStockdetails.SendMessage(0, __ctx2__.__msgResponse, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__msgResponse);
                    __edata.PortName = @"GetMalaviStockdetails";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                {
                    __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response __msgResponse = new __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response("msgResponse", __ctx2__);

                    __ctx1__.__xmlDocMessage.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__xmlDocMessage.UnderlyingXmlDocument.LoadXml("<ns0:Response xmlns:ns0=\"http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response\"><Result>Failed</Result></ns0:Response>");
                    __msgResponse.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__xmlDocMessage.UnderlyingXmlDocument);

                    if (__ctx2__.__msgResponse != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgResponse);
                    __ctx2__.__msgResponse = __msgResponse;
                    __ctx2__.RefMessage(__ctx2__.__msgResponse);
                }
                __ctx2__.__msgResponse.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgResponse);
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                GetMalaviStockdetails.SendMessage(0, __ctx2__.__msgResponse, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__msgResponse);
                    __edata.PortName = @"GetMalaviStockdetails";
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 31;
            case 31:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                System.Diagnostics.EventLog.WriteEntry("Exception caught: ", __ctx2__.__ex_0.Message);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                System.Diagnostics.EventLog.WriteEntry("Error-Malawi Process", __ctx2__.__ex_0.InnerException.ToString(), System.Diagnostics.EventLogEntryType.Error);
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Beltway_Malawi_StockUpdate_Malawi_Stockupdate__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Beltway.Malawi.StockUpdate.Malawi_Stockupdate _schema = new Beltway.Malawi.StockUpdate.Malawi_Stockupdate();

        public __Beltway_Malawi_StockUpdate_Malawi_Stockupdate__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Beltway.Malawi.StockUpdate.Malawi_Stockupdate",
        new System.Type[]{
            typeof(Beltway.Malawi.StockUpdate.Malawi_Stockupdate)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Beltway_Malawi_StockUpdate_Malawi_Stockupdate__)
        },
        0,
        @"http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate#Stockdetails"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Beltway_Malawi_StockUpdate_Malawi_Stockupdate__ part;

        private void __CreatePartWrappers()
        {
            part = new __Beltway_Malawi_StockUpdate_Malawi_Stockupdate__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response _schema = new Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response();

        public __Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response",
        new System.Type[]{
            typeof(Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response__)
        },
        0,
        @"http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response#Response"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response__ part;

        private void __CreatePartWrappers()
        {
            part = new __Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Beltway_Malawi_StockUpdate_Malawi_Stockupdate_Response(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema _schema = new Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema();

        public __Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema",
        new System.Type[]{
            typeof(Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema__)
        },
        0,
        @"http://Beltway.Skegness.CentralSystemUpdate.Skegness#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
