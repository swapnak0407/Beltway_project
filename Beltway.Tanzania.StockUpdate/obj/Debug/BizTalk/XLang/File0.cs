
#pragma warning disable 162

namespace Beltway.Tanzania.StockUpdate
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Beltway.Tanzania.StockUpdate.__messagetype_Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_1(PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_1 p = new PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF),
            null,
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
    //#line 230 "C:\Users\redde_ng_user1\documents\visual studio 2015\Projects\Beltway_integrate\Beltway.Tanzania.StockUpdate\ProcessTanzaniaToHeadoffice.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_1", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(Beltway.Tanzania.StockUpdate.PortType_1)
        },
        new System.String[] {
            "Port_1"
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
    sealed internal class ProcessTanzaniaToHeadoffice : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ProcessTanzaniaToHeadoffice));
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

        static ProcessTanzaniaToHeadoffice()
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
            _rootContext = new __ProcessTanzaniaToHeadoffice_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[4];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ProcessTanzaniaToHeadoffice(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ProcessTanzaniaToHeadoffice", tracker)
        {
            ConstructorHelper();
        }

        public ProcessTanzaniaToHeadoffice(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ProcessTanzaniaToHeadoffice")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>8144a23c-b51d-4b58-bf54-7efe9a140dae</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>28fe8e06-d11c-4568-810e-17252350f249</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>rcvStockupdateDetails</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>4e445439-16f0-406e-bcb4-fb51407bc7a3</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ScopeTanzania</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>LongRunningTransactionShape</shapeType>      <ShapeID>9cee8ba7-2c39-4f90-b632-f105e66b75aa</ShapeID>      <ParentLink>Scope_Transaction</ParentLink>                <shapeText>Transaction_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7174130c-0bc1-4ae1-b397-33de93f58640</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>strWarehouseName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>5f957af2-5664-48fd-ab4a-f6a8279656c7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>msgCanonical</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>6fc81b15-c76b-41cb-b0a7-c50931cddca8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0ff05d1d-aed0-4233-b7f7-e4a78f71f8eb</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b5e3f29f-6b66-437f-99e8-2c1c2816e6cd</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9cad9ac4-4db4-4a76-bd87-ff0bfadb83bd</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>fd349b2e-cf6e-4a24-a972-2d7d5cbbca4a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>23e28413-f76a-45ed-85f1-a546e381406c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CallOrchestration_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>e3e4a1b8-c82a-41eb-ae64-8671374d83b9</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>msgCanonical</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b93f66f9-4138-4b75-95d2-048b83702e0e</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>out_Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>0c0bcecd-2f80-40fa-acc1-cd5d32538c64</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>e1a226e8-bd66-425e-bb67-aa1fe9bded43</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Tanzania_Error</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ProcessTanzaniaToHeadoffice'</ActionName><IsAtomic>0</IsAtomic><Line>230</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>245</Line><Position>22</Position><ShapeID>'28fe8e06-d11c-4568-810e-17252350f249'</ShapeID>
<Messages>
	<MsgInfo><name>msgStockupdateDetails</name><part>part</part><schema>Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'Transaction_2'</ActionName><IsAtomic>0</IsAtomic><Line>252</Line><Position>13</Position><ShapeID>'4e445439-16f0-406e-bcb4-fb51407bc7a3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>258</Line><Position>38</Position><ShapeID>'7174130c-0bc1-4ae1-b397-33de93f58640'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>264</Line><Position>21</Position><ShapeID>'5f957af2-5664-48fd-ab4a-f6a8279656c7'</ShapeID>
<Messages>
	<MsgInfo><name>msgCanonical</name><part>part</part><schema>Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgStockupdateDetails</name><part>part</part><schema>Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>270</Line><Position>26</Position><ShapeID>'fd349b2e-cf6e-4a24-a972-2d7d5cbbca4a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>273</Line><Position>92</Position><ShapeID>'23e28413-f76a-45ed-85f1-a546e381406c'</ShapeID>
<Messages>
	<MsgInfo><name>msgCanonical</name><part>part</part><schema>Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>278</Line><Position>21</Position><ShapeID>'0c0bcecd-2f80-40fa-acc1-cd5d32538c64'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>281</Line><Position>63</Position><ShapeID>'e1a226e8-bd66-425e-bb67-aa1fe9bded43'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='469614c7-73fd-4654-b533-4971bc3093db' LowerBound='1.1' HigherBound='71.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Beltway.Tanzania.StockUpdate' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='8a945216-0374-4785-9cc9-ac1bb568a146' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d785eedd-70ac-41b9-b707-168640d2d775' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='1ae4916b-9ca5-48e3-b8ca-9039902ff556' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='6da203a4-f87f-4579-8b48-1ced992bd206' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='70.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ProcessTanzaniaToHeadoffice' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='34e1b03f-3d14-4f37-a57c-13b4fa1c3055' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strWarehouseName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='57065f4b-6258-4f32-878c-64e67035466a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strProductcode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9af14f80-57c3-45c4-b978-89d62436775d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xdoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d224b589-0946-4ea2-ba3f-10ed6e8c900f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strxml' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5a977f1c-4a00-44b9-8ed5-b0bc0371e28b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='out_Result' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='LongRunningTransaction' OID='33657102-e4a5-487d-8f6a-3bcbc23d2ecd' ParentLink='ServiceDeclaration_Transaction' LowerBound='12.21' HigherBound='12.73'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d0e6622c-aa41-4602-a613-13209de882bb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgStockupdateDetails' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ee64b91c-b1f2-449e-8a76-91731f0f0854' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgNewStockupdate' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d8ff2bd8-034a-467e-a8c2-fceba21fe9df' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='Type' Value='Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCanonical' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='8144a23c-b51d-4b58-bf54-7efe9a140dae' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='28fe8e06-d11c-4568-810e-17252350f249' ParentLink='ServiceBody_Statement' LowerBound='26.1' HigherBound='33.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_1' />
                    <om:Property Name='MessageName' Value='msgStockupdateDetails' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='rcvStockupdateDetails' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='4e445439-16f0-406e-bcb4-fb51407bc7a3' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='68.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ScopeTanzania' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='LongRunningTransaction' OID='9cee8ba7-2c39-4f90-b632-f105e66b75aa' ParentLink='Scope_Transaction' LowerBound='34.18' HigherBound='34.56'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transaction_2' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='7174130c-0bc1-4ae1-b397-33de93f58640' ParentLink='ComplexStatement_Statement' LowerBound='38.1' HigherBound='45.1'>
                        <om:Property Name='Expression' Value='&#xD;&#xA;strWarehouseName = &quot;Tanzania&quot;;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;strWarehousename: &quot;,strWarehouseName);&#xD;&#xA;&#xD;&#xA;// strProductcode = xpath(msgStockupdateDetails,&quot;string(/*[local-name()=&apos;TanzaniaStockDetails&apos; and namespace-uri()=&apos;http://Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF&apos;]/*[local-name()=&apos;StockDetails&apos; and namespace-uri()=&apos;&apos;]/*[local-name()=&apos;ProductCode&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;//  System.Diagnostics.EventLog.WriteEntry(&quot;strProductcode: &quot;,strProductcode);&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='strWarehouseName' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Construct' OID='5f957af2-5664-48fd-ab4a-f6a8279656c7' ParentLink='ComplexStatement_Statement' LowerBound='45.1' HigherBound='51.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='msgCanonical' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='6fc81b15-c76b-41cb-b0a7-c50931cddca8' ParentLink='ComplexStatement_Statement' LowerBound='48.1' HigherBound='50.1'>
                            <om:Property Name='ClassName' Value='Beltway.Tanzania.StockUpdate.mapTanzaniaStockupdate_to_headofficeCanonial' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='MessagePartRef' OID='0ff05d1d-aed0-4233-b7f7-e4a78f71f8eb' ParentLink='Transform_InputMessagePartRef' LowerBound='49.127' HigherBound='49.148'>
                                <om:Property Name='MessageRef' Value='msgStockupdateDetails' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='b5e3f29f-6b66-437f-99e8-2c1c2816e6cd' ParentLink='Transform_OutputMessagePartRef' LowerBound='49.36' HigherBound='49.48'>
                                <om:Property Name='MessageRef' Value='msgCanonical' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='9cad9ac4-4db4-4a76-bd87-ff0bfadb83bd' ParentLink='Construct_MessageRef' LowerBound='46.31' HigherBound='46.43'>
                            <om:Property Name='Ref' Value='msgCanonical' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='fd349b2e-cf6e-4a24-a972-2d7d5cbbca4a' ParentLink='ComplexStatement_Statement' LowerBound='51.1' HigherBound='54.1'>
                        <om:Property Name='Expression' Value='xdoc = msgCanonical;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Start orchratration&quot;,xdoc.ToString());' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Call' OID='23e28413-f76a-45ed-85f1-a546e381406c' ParentLink='ComplexStatement_Statement' LowerBound='54.1' HigherBound='56.1'>
                        <om:Property Name='Identifier' Value='CallOrchestration_1' />
                        <om:Property Name='Invokee' Value='Beltway.Skegness.CentralSystemUpdate.ProcessUpdateStockdetailsSQL' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CallOrchestration_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Parameter' OID='e3e4a1b8-c82a-41eb-ae64-8671374d83b9' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='In' />
                            <om:Property Name='Name' Value='msgCanonical' />
                            <om:Property Name='Type' Value='Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Parameter' OID='b93f66f9-4138-4b75-95d2-048b83702e0e' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='Out' />
                            <om:Property Name='Name' Value='out_Result' />
                            <om:Property Name='Type' Value='System.String' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='0c0bcecd-2f80-40fa-acc1-cd5d32538c64' ParentLink='Scope_Catch' LowerBound='59.1' HigherBound='66.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='e1a226e8-bd66-425e-bb67-aa1fe9bded43' ParentLink='Catch_Statement' LowerBound='62.1' HigherBound='65.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;out_result&quot;,out_Result);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Error-Tanzania Process&quot;,ex.InnerException.ToString(),System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Tanzania_Error' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4a8fe96d-b5dd-4fd6-a361-033d8952f8d5' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Beltway.Tanzania.StockUpdate.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7387a3c6-2043-461f-b18d-3f02b5fb31df' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ProcessTanzaniaToHeadoffice_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ProcessTanzaniaToHeadoffice_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessTanzaniaToHeadoffice")
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
                ProcessTanzaniaToHeadoffice __svc__ = (ProcessTanzaniaToHeadoffice)_service;
                __ProcessTanzaniaToHeadoffice_root_0 __ctx0__ = (__ProcessTanzaniaToHeadoffice_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_1 != null)
                {
                    __svc__.Port_1.Close(this, null);
                    __svc__.Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ProcessTanzaniaToHeadoffice_1 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __ProcessTanzaniaToHeadoffice_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessTanzaniaToHeadoffice")
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
                ProcessTanzaniaToHeadoffice __svc__ = (ProcessTanzaniaToHeadoffice)_service;
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);
                __ProcessTanzaniaToHeadoffice_1 __ctx1__ = (__ProcessTanzaniaToHeadoffice_1)(__svc__._stateMgrs[1]);

                if (__ctx2__ != null)
                    __ctx2__.__xdoc = null;
                if (__ctx2__ != null)
                    __ctx2__.__out_Result = null;
                if (__ctx2__ != null)
                    __ctx2__.__strWarehouseName = null;
                if (__ctx1__ != null)
                    __ctx1__.__strWarehouseName = null;
                if (__ctx1__ != null)
                    __ctx1__.__xdoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__strxml = null;
                if (__ctx2__ != null && __ctx2__.__msgCanonical != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgCanonical);
                    __ctx2__.__msgCanonical = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__out_Result = null;
                if (__ctx1__ != null && __ctx1__.__msgStockupdateDetails != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgStockupdateDetails);
                    __ctx1__.__msgStockupdateDetails = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCanonical != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                    __ctx1__.__msgCanonical = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__strProductcode = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgStockupdateDetails")]
            public __messagetype_Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF __msgStockupdateDetails;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCanonical")]
            public __messagetype_Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema __msgCanonical;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strWarehouseName")]
            internal System.String __strWarehouseName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strProductcode")]
            internal System.String __strProductcode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xdoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __xdoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strxml")]
            internal System.String __strxml;
            [Microsoft.XLANGs.Core.UserVariableAttribute("out_Result")]
            internal System.String __out_Result;
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
                ProcessTanzaniaToHeadoffice __svc__ = (ProcessTanzaniaToHeadoffice)_service;
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);
                __ProcessTanzaniaToHeadoffice_1 __ctx1__ = (__ProcessTanzaniaToHeadoffice_1)(__svc__._stateMgrs[1]);

                __ctx1__.__strWarehouseName = __ctx2__.__strWarehouseName;
                if (__ctx1__.__msgCanonical != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                __ctx1__.__msgCanonical = __ctx2__.__msgCanonical;
                if (__ctx2__.__msgCanonical != null)
                    __ctx1__.RefMessage(__ctx1__.__msgCanonical);
                __ctx1__.__xdoc = __ctx2__.__xdoc;
                __ctx1__.__out_Result = __ctx2__.__out_Result;
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCanonical")]
            public __messagetype_Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema __msgCanonical;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strWarehouseName")]
            internal System.String __strWarehouseName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xdoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __xdoc;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_1")]
        internal PortType_1 Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(ProcessTanzaniaToHeadoffice).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessTanzaniaToHeadoffice), "Port_1"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "28fe8e06-d11c-4568-810e-17252350f249", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "28fe8e06-d11c-4568-810e-17252350f249", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "4e445439-16f0-406e-bcb4-fb51407bc7a3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "7174130c-0bc1-4ae1-b397-33de93f58640", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "7174130c-0bc1-4ae1-b397-33de93f58640", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "5f957af2-5664-48fd-ab4a-f6a8279656c7", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "5f957af2-5664-48fd-ab4a-f6a8279656c7", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "fd349b2e-cf6e-4a24-a972-2d7d5cbbca4a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "fd349b2e-cf6e-4a24-a972-2d7d5cbbca4a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "23e28413-f76a-45ed-85f1-a546e381406c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "23e28413-f76a-45ed-85f1-a546e381406c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "0c0bcecd-2f80-40fa-acc1-cd5d32538c64", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "e1a226e8-bd66-425e-bb67-aa1fe9bded43", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "e1a226e8-bd66-425e-bb67-aa1fe9bded43", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "0c0bcecd-2f80-40fa-acc1-cd5d32538c64", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "4e445439-16f0-406e-bcb4-fb51407bc7a3", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,4,4,4,21,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,7,9,9,10,11,11,12,12,13,13,14,14,14,14,};
        public static int[] __progressLocation3 = new int[] { 15,15,16,16,17,17,20,20,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ProcessTanzaniaToHeadoffice_root_0 __ctx0__ = (__ProcessTanzaniaToHeadoffice_root_0)_stateMgrs[0];
            __ProcessTanzaniaToHeadoffice_1 __ctx1__ = (__ProcessTanzaniaToHeadoffice_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_1 = new PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ProcessTanzaniaToHeadoffice_1(this);
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
            __ProcessTanzaniaToHeadoffice_root_0 __ctx0__ = (__ProcessTanzaniaToHeadoffice_root_0)_stateMgrs[0];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            __ProcessTanzaniaToHeadoffice_1 __ctx1__ = (__ProcessTanzaniaToHeadoffice_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__strWarehouseName = default(System.String);
                __ctx1__.__strProductcode = default(System.String);
                __ctx1__.__xdoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__strxml = default(System.String);
                __ctx1__.__out_Result = default(System.String);
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
                if (!Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgStockupdateDetails != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgStockupdateDetails);
                __ctx1__.__msgStockupdateDetails = new __messagetype_Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF("msgStockupdateDetails", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgStockupdateDetails);
                Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgStockupdateDetails, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Port_1 != null)
                {
                    Port_1.Close(__ctx1__, __seg__);
                    Port_1 = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgStockupdateDetails);
                    __edata.PortName = @"Port_1";
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
                __ctx1__.__strProductcode = "";
                if (__ctx1__ != null)
                    __ctx1__.__strProductcode = null;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__xdoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__strxml = "";
                if (__ctx1__ != null)
                    __ctx1__.__strxml = null;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__out_Result = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx2__ = new __Transaction_2_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__msgStockupdateDetails != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgStockupdateDetails);
                    __ctx1__.__msgStockupdateDetails = null;
                }
                Tracker.FireEvent(__eventLocations[21],__eventData[10],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (__ctx2__ != null)
                    __ctx2__.__out_Result = null;
                if (__ctx2__ != null)
                    __ctx2__.__xdoc = null;
                if (__ctx2__ != null)
                    __ctx2__.__strWarehouseName = null;
                if (__ctx2__ != null && __ctx2__.__msgCanonical != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgCanonical);
                    __ctx2__.__msgCanonical = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__out_Result = null;
                if (__ctx1__ != null)
                    __ctx1__.__xdoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__strWarehouseName = null;
                if (__ctx1__ != null && __ctx1__.__msgCanonical != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                    __ctx1__.__msgCanonical = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 17;
            case 17:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            __ProcessTanzaniaToHeadoffice_1 __ctx1__ = (__ProcessTanzaniaToHeadoffice_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx2__.__strWarehouseName = __ctx1__.__strWarehouseName;
                __ctx2__.__msgCanonical = __ctx1__.__msgCanonical;
                if (__ctx2__.__msgCanonical != null)
                    __ctx2__.RefMessage(__ctx2__.__msgCanonical);
                __ctx2__.__xdoc = __ctx1__.__xdoc;
                __ctx2__.__out_Result = __ctx1__.__out_Result;
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
                __ctx2__.__strWarehouseName = "Tanzania";
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

                    ApplyTransform(typeof(Beltway.Tanzania.StockUpdate.mapTanzaniaStockupdate_to_headofficeCanonial), new object[] {__msgCanonical.part}, new object[] {__ctx1__.__msgStockupdateDetails.part});

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
                    __edata.Messages.Add(__ctx1__.__msgStockupdateDetails);
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                __ctx2__.__xdoc.UnderlyingXmlDocument = __ctx2__.__msgCanonical.part.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                System.Diagnostics.EventLog.WriteEntry("Start orchratration", __ctx2__.__xdoc.UnderlyingXmlDocument.ToString());
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                {
                    Microsoft.XLANGs.Core.Service svc = new Beltway.Skegness.CentralSystemUpdate.ProcessUpdateStockdetailsSQL(3, InstanceId, this);
                    _stateMgrs[3] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[13],new object[] {__ctx2__.__msgCanonical, null});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[3]).Args;
                    __ctx2__.__out_Result = (System.String)args[1];
                }
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call);
                    __edata.Messages.Add(__ctx2__.__msgCanonical);
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 17;
            case 17:
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
                Tracker.FireEvent(__eventLocations[15],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                System.Diagnostics.EventLog.WriteEntry("out_result", __ctx2__.__out_Result);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                System.Diagnostics.EventLog.WriteEntry("Error-Tanzania Process", __ctx2__.__ex_0.InnerException.ToString(), System.Diagnostics.EventLogEntryType.Error);
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[9],_stateMgrs[2].TrackDataStream );
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
    sealed public class __Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF _schema = new Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF();

        public __Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF",
        new System.Type[]{
            typeof(Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF__)
        },
        0,
        @"http://Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF#TanzaniaStockupdate"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF__ part;

        private void __CreatePartWrappers()
        {
            part = new __Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Beltway_Tanzania_StockUpdate_TanzaniaStockupdate_FF(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
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
