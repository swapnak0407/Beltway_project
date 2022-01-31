
#pragma warning disable 162

namespace Beltway.NotifyOvercommittedStock
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Beltway.NotifyOvercommittedStock.__messagetype_Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_RcvOvercommittedStockdetails : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_RcvOvercommittedStockdetails(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_RcvOvercommittedStockdetails(PortType_RcvOvercommittedStockdetails p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_RcvOvercommittedStockdetails p = new PortType_RcvOvercommittedStockdetails(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_RcvOvercommittedStockdetails),
            typeof(__messagetype_Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling),
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Beltway.NotifyOvercommittedStock.__messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Dynamic_SMTP : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Dynamic_SMTP(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Dynamic_SMTP(PortType_Dynamic_SMTP p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Dynamic_SMTP p = new PortType_Dynamic_SMTP(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Dynamic_SMTP),
            typeof(__messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials),
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
    //#line 279 "C:\Users\redde_ng_user1\documents\visual studio 2015\Projects\Beltway_integrate\Beltway.NotifyOvercommittedStock\ProcessNotifyOvercommittedStock.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvOvercommittedStockdetails", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        },
        new System.Type[] {
            typeof(Beltway.NotifyOvercommittedStock.PortType_RcvOvercommittedStockdetails),
            typeof(Beltway.NotifyOvercommittedStock.PortType_Dynamic_SMTP)
        },
        new System.String[] {
            "RcvOvercommittedStockdetails",
            "Dynamic_SMTP"
        },
        new System.Type[] {
            null,
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
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eLongRunning
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ProcessNotifyOvercommittedStock : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ProcessNotifyOvercommittedStock));
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

        static ProcessNotifyOvercommittedStock()
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
            _rootContext = new __ProcessNotifyOvercommittedStock_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ProcessNotifyOvercommittedStock(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ProcessNotifyOvercommittedStock", tracker)
        {
            ConstructorHelper();
        }

        public ProcessNotifyOvercommittedStock(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ProcessNotifyOvercommittedStock")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>95ddea5f-d335-4b0f-9aef-ac04c236a27c</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>d39dd481-2583-44ab-bb77-1e1addd63047</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>rcvOvercommittedStcoks</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>fc9d2966-dcb4-40fb-94cc-6523f8e0cf07</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>LongRunningTransactionShape</shapeType>      <ShapeID>963dcba9-5d21-4fcc-8931-cb158b73622f</ShapeID>      <ParentLink>Scope_Transaction</ParentLink>                <shapeText>Transaction_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>faeff366-f62e-4175-85b9-ad219d10587a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a3add630-ea36-45a0-9122-5d4cf0134202</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>msgGroupdetails</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>8b01914a-9344-4129-99a6-4cc506da5921</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>970aec32-d434-4051-a700-b1473ef12233</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0325d90a-9287-48d5-914d-7ad546c91ba1</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>b542f07f-28b3-4778-a74e-52360b3bc173</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f52e6a9a-9a16-4add-b8cf-b5c0823b5f08</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>ea608470-aede-45e6-9935-4855b2113da2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Loop_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>be8f1ccd-31dd-4882-962f-5928fd56e054</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>msgGroupdetailsOUT</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7d6cbf62-b87c-40d2-8e92-c74f8d17a4ae</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>9ec189a5-5bb8-4e70-8fdd-120d8ae4afa4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>bffb0700-09e1-4d4a-8159-f73c1fba4b9b</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>a06d7233-43d3-4eac-80ba-7f73ba0d4a57</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>2676cede-011a-4ad5-84cc-051332b3a066</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>3c57ec82-746f-4607-8b6d-640dd6088473</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ProcessNotifyOvercommittedStock'</ActionName><IsAtomic>0</IsAtomic><Line>279</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>294</Line><Position>22</Position><ShapeID>'d39dd481-2583-44ab-bb77-1e1addd63047'</ShapeID>
<Messages>
	<MsgInfo><name>msgOvercommittedStocks</name><part>part</part><schema>Beltway.NotifyOvercommittedStock.TypedPolling_Test+TypedPolling</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'Transaction_2'</ActionName><IsAtomic>0</IsAtomic><Line>298</Line><Position>13</Position><ShapeID>'fc9d2966-dcb4-40fb-94cc-6523f8e0cf07'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>303</Line><Position>26</Position><ShapeID>'faeff366-f62e-4175-85b9-ad219d10587a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>307</Line><Position>21</Position><ShapeID>'a3add630-ea36-45a0-9122-5d4cf0134202'</ShapeID>
<Messages>
	<MsgInfo><name>msgGroupdetails</name><part>part</part><schema>Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgOvercommittedStocks</name><part>part</part><schema>Beltway.NotifyOvercommittedStock.TypedPolling_Test+TypedPolling</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>313</Line><Position>26</Position><ShapeID>'f52e6a9a-9a16-4add-b8cf-b5c0823b5f08'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>324</Line><Position>21</Position><ShapeID>'ea608470-aede-45e6-9935-4855b2113da2'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>327</Line><Position>25</Position><ShapeID>'be8f1ccd-31dd-4882-962f-5928fd56e054'</ShapeID>
<Messages>
	<MsgInfo><name>msgGroupdetailsOUT</name><part>part</part><schema>Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>352</Line><Position>25</Position><ShapeID>'a06d7233-43d3-4eac-80ba-7f73ba0d4a57'</ShapeID>
<Messages>
	<MsgInfo><name>msgGroupdetailsOUT</name><part>part</part><schema>Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>358</Line><Position>21</Position><ShapeID>'2676cede-011a-4ad5-84cc-051332b3a066'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>361</Line><Position>63</Position><ShapeID>'3c57ec82-746f-4607-8b6d-640dd6088473'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='8b88306f-7952-4ab8-ab86-9d0802c9e571' LowerBound='1.1' HigherBound='108.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Beltway.NotifyOvercommittedStock' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='6fd02b8b-6820-41bd-9933-a41bd19077fc' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_RcvOvercommittedStockdetails' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='6885866f-2336-4fe5-a57f-24c0b2aede13' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='47539e8f-77bf-45fb-a812-71af2dd56ba3' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.43'>
                    <om:Property Name='Ref' Value='Beltway.NotifyOvercommittedStock.TypedPolling_Test.TypedPolling' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='0a4418ec-cd8e-49c5-a8b7-d9608fe98851' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Dynamic_SMTP' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='dbe72000-4ec3-4661-974b-55d4438b7f1a' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='5d94781b-506a-40dd-bc98-e712284b45fd' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.39'>
                    <om:Property Name='Ref' Value='Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='501c20ce-b423-43e8-976d-d329461aed3c' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='107.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ProcessNotifyOvercommittedStock' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='a6c25050-28f5-45cb-9c14-131e99a57d69' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xdoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='87d46329-c08d-4286-95ab-391b0821916c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='intCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ad5b0402-1d14-4c8b-baf8-2763912246af' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='mailBody' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='LongRunningTransaction' OID='6f3f3e48-c38b-41f6-9969-3fb98379931e' ParentLink='ServiceDeclaration_Transaction' LowerBound='19.21' HigherBound='19.77'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c71df399-97ef-4dc2-8475-fbd47f0bc2c2' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Beltway.NotifyOvercommittedStock.TypedPolling_Test.TypedPolling' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgOvercommittedStocks' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='85fa0e87-f55c-469d-8fd7-1f78a71177c6' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgGroupdetails' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='747abe57-3089-41dc-bfa4-bc18fb49ecd0' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgGroupdetailsOUT' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='95ddea5f-d335-4b0f-9aef-ac04c236a27c' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='d39dd481-2583-44ab-bb77-1e1addd63047' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='37.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvOvercommittedStockdetails' />
                    <om:Property Name='MessageName' Value='msgOvercommittedStocks' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='rcvOvercommittedStcoks' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='fc9d2966-dcb4-40fb-94cc-6523f8e0cf07' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='105.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='LongRunningTransaction' OID='963dcba9-5d21-4fcc-8931-cb158b73622f' ParentLink='Scope_Transaction' LowerBound='38.18' HigherBound='38.56'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transaction_2' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='faeff366-f62e-4175-85b9-ad219d10587a' ParentLink='ComplexStatement_Statement' LowerBound='42.1' HigherBound='46.1'>
                        <om:Property Name='Expression' Value='xdoc = msgOvercommittedStocks;&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;msgOvercommittedStocks : &quot;,xdoc.OuterXml);' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Construct' OID='a3add630-ea36-45a0-9122-5d4cf0134202' ParentLink='ComplexStatement_Statement' LowerBound='46.1' HigherBound='52.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='msgGroupdetails' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='8b01914a-9344-4129-99a6-4cc506da5921' ParentLink='ComplexStatement_Statement' LowerBound='49.1' HigherBound='51.1'>
                            <om:Property Name='ClassName' Value='Beltway.NotifyOvercommittedStock.Transform_1' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='970aec32-d434-4051-a700-b1473ef12233' ParentLink='Transform_InputMessagePartRef' LowerBound='50.101' HigherBound='50.123'>
                                <om:Property Name='MessageRef' Value='msgOvercommittedStocks' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='0325d90a-9287-48d5-914d-7ad546c91ba1' ParentLink='Transform_OutputMessagePartRef' LowerBound='50.36' HigherBound='50.51'>
                                <om:Property Name='MessageRef' Value='msgGroupdetails' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='b542f07f-28b3-4778-a74e-52360b3bc173' ParentLink='Construct_MessageRef' LowerBound='47.31' HigherBound='47.46'>
                            <om:Property Name='Ref' Value='msgGroupdetails' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='f52e6a9a-9a16-4add-b8cf-b5c0823b5f08' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='63.1'>
                        <om:Property Name='Expression' Value='xdoc = msgGroupdetails;&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;msgGroupdetails : &quot;,xdoc.OuterXml);&#xD;&#xA;&#xD;&#xA;// Get count of the y_warehouseid&#xD;&#xA;&#xD;&#xA;intCount = System.Convert.ToInt32(xpath(msgGroupdetails,&quot;count(/*[local-name()=&apos;OvercommittedStockdetails&apos; and namespace-uri()=&apos;http://Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials&apos;]/*[local-name()=&apos;Details&apos; and namespace-uri()=&apos;&apos;]/*[local-name()=&apos;y_Warehouseid&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;intCount : &quot;,System.Convert.ToString(intCount));&#xD;&#xA;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='While' OID='ea608470-aede-45e6-9935-4855b2113da2' ParentLink='ComplexStatement_Statement' LowerBound='63.1' HigherBound='94.1'>
                        <om:Property Name='Expression' Value='intCount &gt; 0' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Loop_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='be8f1ccd-31dd-4882-962f-5928fd56e054' ParentLink='ComplexStatement_Statement' LowerBound='66.1' HigherBound='91.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='msgGroupdetailsOUT' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='7d6cbf62-b87c-40d2-8e92-c74f8d17a4ae' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='78.1'>
                                <om:Property Name='Expression' Value='msgGroupdetailsOUT = msgGroupdetails;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;intCount = intCount-1;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='9ec189a5-5bb8-4e70-8fdd-120d8ae4afa4' ParentLink='ComplexStatement_Statement' LowerBound='78.1' HigherBound='90.1'>
                                <om:Property Name='Expression' Value='// Get the values for the email body&#xD;&#xA;msgGroupdetailsOUT(SMTP.Subject) = &quot;Transfer the stocks&quot;;&#xD;&#xA;// We can get these values from either SQL server or config files&#xD;&#xA;msgGroupdetailsOUT(SMTP.From) = &quot;test@gmail.com&quot;;&#xD;&#xA;msgGroupdetailsOUT(SMTP.SMTPHost) = &quot;smtp.gmail.com&quot;;&#xD;&#xA;msgGroupdetailsOUT(SMTP.EmailBodyText) = mailBody;&#xD;&#xA;msgGroupdetailsOUT(SMTP.SMTPAuthenticate) = 0;&#xD;&#xA;&#xD;&#xA;msgGroupdetailsOUT(SMTP.EmailBodyTextCharset) = &quot;utf-8&quot;;&#xD;&#xA;&#xD;&#xA;Dynamic_SMTP(Microsoft.XLANGs.BaseTypes.Address) = &quot;test@gmail.com&quot;;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_2' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='bffb0700-09e1-4d4a-8159-f73c1fba4b9b' ParentLink='Construct_MessageRef' LowerBound='67.35' HigherBound='67.53'>
                                <om:Property Name='Ref' Value='msgGroupdetailsOUT' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='a06d7233-43d3-4eac-80ba-7f73ba0d4a57' ParentLink='ComplexStatement_Statement' LowerBound='91.1' HigherBound='93.1'>
                            <om:Property Name='PortName' Value='Dynamic_SMTP' />
                            <om:Property Name='MessageName' Value='msgGroupdetailsOUT' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='2676cede-011a-4ad5-84cc-051332b3a066' ParentLink='Scope_Catch' LowerBound='97.1' HigherBound='103.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='3c57ec82-746f-4607-8b6d-640dd6088473' ParentLink='Catch_Statement' LowerBound='100.1' HigherBound='102.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;Error-Overcommitted Stock Notification Process&quot;,ex.InnerException.ToString(),System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d8540700-d924-440a-89fd-fbc2911cc201' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Beltway.NotifyOvercommittedStock.PortType_RcvOvercommittedStockdetails' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvOvercommittedStockdetails' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c0a8289a-4d61-4d05-b120-e485117078c6' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='cb049dd7-f03c-470f-bac0-c18f76068a05' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='32' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Beltway.NotifyOvercommittedStock.PortType_Dynamic_SMTP' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Dynamic_SMTP' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PhysicalBindingAttribute' OID='939c6b44-1bf6-42c1-84a0-abe8916a44bb' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLTransmit' />
                    <om:Property Name='TransportType' Value='HTTP' />
                    <om:Property Name='URI' Value='http://tempURI' />
                    <om:Property Name='IsDynamic' Value='True' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ProcessNotifyOvercommittedStock_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ProcessNotifyOvercommittedStock_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessNotifyOvercommittedStock")
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
                ProcessNotifyOvercommittedStock __svc__ = (ProcessNotifyOvercommittedStock)_service;
                __ProcessNotifyOvercommittedStock_root_0 __ctx0__ = (__ProcessNotifyOvercommittedStock_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RcvOvercommittedStockdetails != null)
                {
                    __svc__.RcvOvercommittedStockdetails.Close(this, null);
                    __svc__.RcvOvercommittedStockdetails = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ProcessNotifyOvercommittedStock_1 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __ProcessNotifyOvercommittedStock_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessNotifyOvercommittedStock")
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
                ProcessNotifyOvercommittedStock __svc__ = (ProcessNotifyOvercommittedStock)_service;
                __ProcessNotifyOvercommittedStock_root_0 __ctx0__ = (__ProcessNotifyOvercommittedStock_root_0)(__svc__._stateMgrs[0]);
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);
                __ProcessNotifyOvercommittedStock_1 __ctx1__ = (__ProcessNotifyOvercommittedStock_1)(__svc__._stateMgrs[1]);

                if (__ctx2__ != null)
                    __ctx2__.__xdoc = null;
                if (__ctx2__ != null && __ctx2__.__msgGroupdetails != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgGroupdetails);
                    __ctx2__.__msgGroupdetails = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgGroupdetails != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgGroupdetails);
                    __ctx1__.__msgGroupdetails = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__xdoc = null;
                if (__ctx1__ != null && __ctx1__.__msgOvercommittedStocks != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOvercommittedStocks);
                    __ctx1__.__msgOvercommittedStocks = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__mailBody = null;
                if (__ctx2__ != null && __ctx2__.__msgGroupdetailsOUT != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgGroupdetailsOUT);
                    __ctx2__.__msgGroupdetailsOUT = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgGroupdetailsOUT != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgGroupdetailsOUT);
                    __ctx1__.__msgGroupdetailsOUT = null;
                }
                if (__svc__.Dynamic_SMTP != null)
                {
                    __svc__.Dynamic_SMTP.Close(this, null);
                    __svc__.Dynamic_SMTP = null;
                }
                if (__ctx2__ != null && __ctx2__.Dynamic_SMTP != null)
                {
                    __ctx2__.Dynamic_SMTP.Close(__ctx2__, null);
                    __ctx2__.Dynamic_SMTP = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgOvercommittedStocks")]
            public __messagetype_Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling __msgOvercommittedStocks;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgGroupdetails")]
            public __messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials __msgGroupdetails;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgGroupdetailsOUT")]
            public __messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials __msgGroupdetailsOUT;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xdoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __xdoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("intCount")]
            internal System.Int32 __intCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("mailBody")]
            internal System.String __mailBody;
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
                ProcessNotifyOvercommittedStock __svc__ = (ProcessNotifyOvercommittedStock)_service;
                __ProcessNotifyOvercommittedStock_root_0 __ctx0__ = (__ProcessNotifyOvercommittedStock_root_0)(__svc__._stateMgrs[0]);
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);
                __ProcessNotifyOvercommittedStock_1 __ctx1__ = (__ProcessNotifyOvercommittedStock_1)(__svc__._stateMgrs[1]);

                __ctx1__.__xdoc = __ctx2__.__xdoc;
                if (__ctx1__.__msgGroupdetails != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgGroupdetails);
                __ctx1__.__msgGroupdetails = __ctx2__.__msgGroupdetails;
                if (__ctx2__.__msgGroupdetails != null)
                    __ctx1__.RefMessage(__ctx1__.__msgGroupdetails);
                __ctx1__.__intCount = __ctx2__.__intCount;
                if (__ctx1__.__msgGroupdetailsOUT != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgGroupdetailsOUT);
                __ctx1__.__msgGroupdetailsOUT = __ctx2__.__msgGroupdetailsOUT;
                if (__ctx2__.__msgGroupdetailsOUT != null)
                    __ctx1__.RefMessage(__ctx1__.__msgGroupdetailsOUT);
                if (__ctx2__ != null && __ctx2__.Dynamic_SMTP != null)
                    __svc__.Dynamic_SMTP.BindingInfo = __ctx2__.Dynamic_SMTP.BindingInfo;
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgGroupdetails")]
            public __messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials __msgGroupdetails;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgGroupdetailsOUT")]
            public __messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials __msgGroupdetailsOUT;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xdoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __xdoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("intCount")]
            internal System.Int32 __intCount;
            [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute(typeof(Microsoft.BizTalk.DefaultPipelines.XMLTransmit))]
            [Microsoft.XLANGs.BaseTypes.PortAttribute(
                Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
            )]
            [Microsoft.XLANGs.Core.UserVariableAttribute("Dynamic_SMTP")]
            internal PortType_Dynamic_SMTP Dynamic_SMTP;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("RcvOvercommittedStockdetails")]
        internal PortType_RcvOvercommittedStockdetails RcvOvercommittedStockdetails;
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute(typeof(Microsoft.BizTalk.DefaultPipelines.XMLTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Dynamic_SMTP")]
        internal PortType_Dynamic_SMTP Dynamic_SMTP;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_RcvOvercommittedStockdetails.Operation_1},
                                               typeof(ProcessNotifyOvercommittedStock).GetField("RcvOvercommittedStockdetails", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessNotifyOvercommittedStock), "RcvOvercommittedStockdetails"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Dynamic_SMTP.Operation_1},
                                               typeof(ProcessNotifyOvercommittedStock).GetField("Dynamic_SMTP", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               true,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessNotifyOvercommittedStock), "Dynamic_SMTP"),
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
                h[_portInfo[1].Name] = _portInfo[1];
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

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "d39dd481-2583-44ab-bb77-1e1addd63047", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "d39dd481-2583-44ab-bb77-1e1addd63047", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "fc9d2966-dcb4-40fb-94cc-6523f8e0cf07", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "faeff366-f62e-4175-85b9-ad219d10587a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "faeff366-f62e-4175-85b9-ad219d10587a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "a3add630-ea36-45a0-9122-5d4cf0134202", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "a3add630-ea36-45a0-9122-5d4cf0134202", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "f52e6a9a-9a16-4add-b8cf-b5c0823b5f08", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "f52e6a9a-9a16-4add-b8cf-b5c0823b5f08", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "ea608470-aede-45e6-9935-4855b2113da2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "be8f1ccd-31dd-4882-962f-5928fd56e054", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "be8f1ccd-31dd-4882-962f-5928fd56e054", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "a06d7233-43d3-4eac-80ba-7f73ba0d4a57", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "a06d7233-43d3-4eac-80ba-7f73ba0d4a57", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "ea608470-aede-45e6-9935-4855b2113da2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "2676cede-011a-4ad5-84cc-051332b3a066", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "3c57ec82-746f-4607-8b6d-640dd6088473", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "3c57ec82-746f-4607-8b6d-640dd6088473", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "2676cede-011a-4ad5-84cc-051332b3a066", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "fc9d2966-dcb4-40fb-94cc-6523f8e0cf07", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,4,4,4,23,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,7,9,9,10,11,11,12,12,12,12,13,13,13,14,14,15,16,16,16,17,18,18,18,18,18,18,};
        public static int[] __progressLocation3 = new int[] { 19,19,20,20,21,22,22,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ProcessNotifyOvercommittedStock_root_0 __ctx0__ = (__ProcessNotifyOvercommittedStock_root_0)_stateMgrs[0];
            __ProcessNotifyOvercommittedStock_1 __ctx1__ = (__ProcessNotifyOvercommittedStock_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                RcvOvercommittedStockdetails = new PortType_RcvOvercommittedStockdetails(0, this);
                Dynamic_SMTP = new PortType_Dynamic_SMTP(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RcvOvercommittedStockdetails, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ProcessNotifyOvercommittedStock_1(this);
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
            __ProcessNotifyOvercommittedStock_root_0 __ctx0__ = (__ProcessNotifyOvercommittedStock_root_0)_stateMgrs[0];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            __ProcessNotifyOvercommittedStock_1 __ctx1__ = (__ProcessNotifyOvercommittedStock_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__xdoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__intCount = default(System.Int32);
                __ctx1__.__mailBody = default(System.String);
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
                if (!RcvOvercommittedStockdetails.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgOvercommittedStocks != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgOvercommittedStocks);
                __ctx1__.__msgOvercommittedStocks = new __messagetype_Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling("msgOvercommittedStocks", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgOvercommittedStocks);
                RcvOvercommittedStockdetails.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgOvercommittedStocks, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RcvOvercommittedStockdetails != null)
                {
                    RcvOvercommittedStockdetails.Close(__ctx1__, __seg__);
                    RcvOvercommittedStockdetails = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgOvercommittedStocks);
                    __edata.PortName = @"RcvOvercommittedStockdetails";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__xdoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__mailBody = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __ctx2__ = new __Transaction_2_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__mailBody = null;
                if (__ctx1__ != null && __ctx1__.__msgOvercommittedStocks != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgOvercommittedStocks);
                    __ctx1__.__msgOvercommittedStocks = null;
                }
                Tracker.FireEvent(__eventLocations[23],__eventData[13],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (__ctx2__ != null)
                    __ctx2__.__xdoc = null;
                if (__ctx2__ != null && __ctx2__.__msgGroupdetailsOUT != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgGroupdetailsOUT);
                    __ctx2__.__msgGroupdetailsOUT = null;
                }
                if (__ctx2__ != null && __ctx2__.__msgGroupdetails != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgGroupdetails);
                    __ctx2__.__msgGroupdetails = null;
                }
                if (__ctx2__ != null && __ctx2__.Dynamic_SMTP != null)
                {
                    __ctx2__.Dynamic_SMTP.Close(__ctx1__, __seg__);
                    __ctx2__.Dynamic_SMTP = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__xdoc = null;
                if (__ctx1__ != null && __ctx1__.__msgGroupdetailsOUT != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgGroupdetailsOUT);
                    __ctx1__.__msgGroupdetailsOUT = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgGroupdetails != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgGroupdetails);
                    __ctx1__.__msgGroupdetails = null;
                }
                if (Dynamic_SMTP != null)
                {
                    Dynamic_SMTP.Close(__ctx1__, __seg__);
                    Dynamic_SMTP = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[14],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 14;
            case 14:
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
            __ProcessNotifyOvercommittedStock_root_0 __ctx0__ = (__ProcessNotifyOvercommittedStock_root_0)_stateMgrs[0];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];
            __ProcessNotifyOvercommittedStock_1 __ctx1__ = (__ProcessNotifyOvercommittedStock_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx2__.__xdoc = __ctx1__.__xdoc;
                __ctx2__.__msgGroupdetails = __ctx1__.__msgGroupdetails;
                if (__ctx2__.__msgGroupdetails != null)
                    __ctx2__.RefMessage(__ctx2__.__msgGroupdetails);
                __ctx2__.__intCount = __ctx1__.__intCount;
                __ctx2__.__msgGroupdetailsOUT = __ctx1__.__msgGroupdetailsOUT;
                if (__ctx2__.__msgGroupdetailsOUT != null)
                    __ctx2__.RefMessage(__ctx2__.__msgGroupdetailsOUT);
                __ctx2__.Dynamic_SMTP = (PortType_Dynamic_SMTP)Dynamic_SMTP.Clone();
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
                __ctx2__.__xdoc.UnderlyingXmlDocument = __ctx1__.__msgOvercommittedStocks.part.TypedValue;
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
                System.Diagnostics.EventLog.WriteEntry("msgOvercommittedStocks : ", __ctx2__.__xdoc.UnderlyingXmlDocument.OuterXml);
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
                    __messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials __msgGroupdetails = new __messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials("msgGroupdetails", __ctx2__);

                    ApplyTransform(typeof(Beltway.NotifyOvercommittedStock.Transform_1), new object[] {__msgGroupdetails.part}, new object[] {__ctx1__.__msgOvercommittedStocks.part});

                    if (__ctx2__.__msgGroupdetails != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgGroupdetails);
                    __ctx2__.__msgGroupdetails = __msgGroupdetails;
                    __ctx2__.RefMessage(__ctx2__.__msgGroupdetails);
                }
                __ctx2__.__msgGroupdetails.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgGroupdetails);
                    __edata.Messages.Add(__ctx1__.__msgOvercommittedStocks);
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
                __ctx2__.__xdoc.UnderlyingXmlDocument = __ctx2__.__msgGroupdetails.part.TypedValue;
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
                System.Diagnostics.EventLog.WriteEntry("msgGroupdetails : ", __ctx2__.__xdoc.UnderlyingXmlDocument.OuterXml);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx2__.__intCount = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx2__.__msgGroupdetails.part, "count(/*[local-name()='OvercommittedStockdetails' and namespace-uri()='http://Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials']/*[local-name()='Details' and namespace-uri()='']/*[local-name()='y_Warehouseid' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                System.Diagnostics.EventLog.WriteEntry("intCount : ", System.Convert.ToString(__ctx2__.__intCount));
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __condition__ = __ctx2__.__intCount > 0;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 26;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                {
                    __messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials __msgGroupdetailsOUT = new __messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials("msgGroupdetailsOUT", __ctx2__);

                    __msgGroupdetailsOUT.CopyFrom(__ctx2__.__msgGroupdetails);
                    __ctx2__.__intCount = __ctx2__.__intCount - 1;
                    __msgGroupdetailsOUT.SetPropertyValue(typeof(SMTP.Subject), "Transfer the stocks");
                    __msgGroupdetailsOUT.SetPropertyValue(typeof(SMTP.From), "test@gmail.com");
                    __msgGroupdetailsOUT.SetPropertyValue(typeof(SMTP.SMTPHost), "smtp.gmail.com");
                    __msgGroupdetailsOUT.SetPropertyValue(typeof(SMTP.EmailBodyText), __ctx1__.__mailBody);
                    __msgGroupdetailsOUT.SetPropertyValue(typeof(SMTP.SMTPAuthenticate), (System.UInt32)(0U));
                    __msgGroupdetailsOUT.SetPropertyValue(typeof(SMTP.EmailBodyTextCharset), "utf-8");
                    __ctx2__.Dynamic_SMTP.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.Address), "test@gmail.com");

                    if (__ctx2__.__msgGroupdetailsOUT != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgGroupdetailsOUT);
                    __ctx2__.__msgGroupdetailsOUT = __msgGroupdetailsOUT;
                    __ctx2__.RefMessage(__ctx2__.__msgGroupdetailsOUT);
                }
                __ctx2__.__msgGroupdetailsOUT.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgGroupdetailsOUT);
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.Dynamic_SMTP.SendMessage(0, __ctx2__.__msgGroupdetailsOUT, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__msgGroupdetailsOUT);
                    __edata.PortName = @"Dynamic_SMTP";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 29;
            case 29:
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
                Tracker.FireEvent(__eventLocations[19],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                System.Diagnostics.EventLog.WriteEntry("Error-Overcommitted Stock Notification Process", __ctx2__.__ex_0.InnerException.ToString(), System.Diagnostics.EventLogEntryType.Error);
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Beltway.NotifyOvercommittedStock.TypedPolling_Test.TypedPolling _schema = new Beltway.NotifyOvercommittedStock.TypedPolling_Test.TypedPolling();

        public __Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Beltway.NotifyOvercommittedStock.TypedPolling_Test.TypedPolling",
        new System.Type[]{
            typeof(Beltway.NotifyOvercommittedStock.TypedPolling_Test.TypedPolling)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedPolling/Test#TypedPolling"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling__ part;

        private void __CreatePartWrappers()
        {
            part = new __Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Beltway_NotifyOvercommittedStock_TypedPolling_Test_TypedPolling(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials _schema = new Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials();

        public __Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials",
        new System.Type[]{
            typeof(Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials__)
        },
        0,
        @"http://Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials#OvercommittedStockdetails"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials__ part;

        private void __CreatePartWrappers()
        {
            part = new __Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Beltway_NotifyOvercommittedStock_GroupWarehouseStockdetials(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
