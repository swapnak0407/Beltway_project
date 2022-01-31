
#pragma warning disable 162

namespace Beltway.Skegness.CentralSystemUpdate
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Beltway.Skegness.CentralSystemUpdate.__messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema), 
            typeof(Beltway.Skegness.CentralSystemUpdate.__messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema)
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
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_1),
            typeof(__messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema),
            typeof(__messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema),
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
    //#line 188 "C:\Users\redde_ng_user1\documents\visual studio 2015\Projects\Beltway_integrate\Beltway_integrate\ProcessUpdateStockdetailsSQL.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Beltway.Skegness.CentralSystemUpdate.PortType_1)
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
    sealed public class ProcessUpdateStockdetailsSQL : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema msgCanonical,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] out System.String out_Result)
        {
            out_Result = default(System.String);
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ProcessUpdateStockdetailsSQL));
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

        static ProcessUpdateStockdetailsSQL()
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
            _rootContext = new __ProcessUpdateStockdetailsSQL_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ProcessUpdateStockdetailsSQL(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ProcessUpdateStockdetailsSQL", tracker)
        {
            ConstructorHelper();
        }

        public ProcessUpdateStockdetailsSQL(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ProcessUpdateStockdetailsSQL")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>d53aed9c-d80d-4217-bdca-dc8b8bb5b82f</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>80866208-4dae-4da7-90ae-b4e591f1a384</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>msgCanonical</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>4d219a64-86e1-4994-8763-4cc51375fddc</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>out_Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>fbce8b5a-3b9d-4f13-917d-8191ff50426e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ScopeUpdateSQL</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>LongRunningTransactionShape</shapeType>      <ShapeID>495bb8d1-0187-4e71-9cf7-44a00108f70f</ShapeID>      <ParentLink>Scope_Transaction</ParentLink>                <shapeText>Transaction_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ac186598-40b0-46e0-834a-991356bc12d3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>msgSQLUpdateStockRequest</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>c3c46a0a-b0fe-46f2-b328-b03ef00bb528</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2f2008b6-4fae-46af-a3ae-197cb9281f53</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3da4be44-a928-4b7d-a89f-9c02e45ab599</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>c035b919-d34c-4d44-a8d4-37fabae426e3</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>0548865b-aeeb-4898-a0b4-6ca205f918f8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>ab176af9-9a01-4b8d-a3cc-342c988bf879</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>fdef20bc-fca2-475f-b928-fd7ea05e2b55</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>out_Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>4264f66a-b6e1-431c-bb3f-c413e6465170</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>da693e6f-c640-4e9f-8d7c-7b2a1260bfd5</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>out_Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ProcessUpdateStockdetailsSQL'</ActionName><IsAtomic>0</IsAtomic><Line>188</Line><Position>12</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
	<MsgInfo><name>msgCanonical</name><part>part</part><schema>Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'Transaction_2'</ActionName><IsAtomic>0</IsAtomic><Line>197</Line><Position>13</Position><ShapeID>'fbce8b5a-3b9d-4f13-917d-8191ff50426e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>202</Line><Position>21</Position><ShapeID>'ac186598-40b0-46e0-834a-991356bc12d3'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLUpdateStockRequest</name><part>part</part><schema>Beltway.Skegness.CentralSystemUpdate.CompositeSchema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgCanonical</name><part>part</part><schema>Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>208</Line><Position>21</Position><ShapeID>'0548865b-aeeb-4898-a0b4-6ca205f918f8'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLUpdateStockRequest</name><part>part</part><schema>Beltway.Skegness.CentralSystemUpdate.CompositeSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>210</Line><Position>21</Position><ShapeID>'ab176af9-9a01-4b8d-a3cc-342c988bf879'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLUpdateStockResponse</name><part>part</part><schema>Beltway.Skegness.CentralSystemUpdate.CompositeSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>212</Line><Position>32</Position><ShapeID>'fdef20bc-fca2-475f-b928-fd7ea05e2b55'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>217</Line><Position>21</Position><ShapeID>'4264f66a-b6e1-431c-bb3f-c413e6465170'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>220</Line><Position>36</Position><ShapeID>'da693e6f-c640-4e9f-8d7c-7b2a1260bfd5'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='5199e4d4-bed0-4d3a-9900-7f2282c56972' LowerBound='1.1' HigherBound='52.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Beltway.Skegness.CentralSystemUpdate' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='758da843-b251-4379-bbbb-ddee2c99a6c9' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='36807371-ee8e-477b-810b-284fb7711c54' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='b5e378bb-b275-4b7d-8ad9-e894419e9e37' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.28'>
                    <om:Property Name='Ref' Value='Beltway.Skegness.CentralSystemUpdate.CompositeSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='28c57def-535d-4e1c-a339-009e2dc965bc' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.30' HigherBound='8.45'>
                    <om:Property Name='Ref' Value='Beltway.Skegness.CentralSystemUpdate.CompositeSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='cab19ef5-1cb7-4a46-aa3f-478fcf0dc113' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='51.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ProcessUpdateStockdetailsSQL' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='LongRunningTransaction' OID='63c73921-ed81-4219-b10c-cce356375d9b' ParentLink='ServiceDeclaration_Transaction' LowerBound='12.19' HigherBound='12.72'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8d452375-c5e1-45aa-8aff-4192970b1aa5' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='Beltway.Skegness.CentralSystemUpdate.CompositeSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLUpdateStockRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='1246b247-1b57-4a33-bca0-9b1e196a3d56' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='Type' Value='Beltway.Skegness.CentralSystemUpdate.CompositeSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLUpdateStockResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='d53aed9c-d80d-4217-bdca-dc8b8bb5b82f' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageDeclaration' OID='80866208-4dae-4da7-90ae-b4e591f1a384' ParentLink='ServiceBody_Declaration' LowerBound='18.15' HigherBound='18.70'>
                    <om:Property Name='Type' Value='Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='msgCanonical' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='4d219a64-86e1-4994-8763-4cc51375fddc' ParentLink='ServiceBody_Declaration' LowerBound='18.72' HigherBound='18.100'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='Out' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='out_Result' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='fbce8b5a-3b9d-4f13-917d-8191ff50426e' ParentLink='ServiceBody_Statement' LowerBound='20.1' HigherBound='49.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ScopeUpdateSQL' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='LongRunningTransaction' OID='495bb8d1-0187-4e71-9cf7-44a00108f70f' ParentLink='Scope_Transaction' LowerBound='21.18' HigherBound='21.56'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transaction_2' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Construct' OID='ac186598-40b0-46e0-834a-991356bc12d3' ParentLink='ComplexStatement_Statement' LowerBound='25.1' HigherBound='31.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='msgSQLUpdateStockRequest' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='c3c46a0a-b0fe-46f2-b328-b03ef00bb528' ParentLink='ComplexStatement_Statement' LowerBound='28.1' HigherBound='30.1'>
                            <om:Property Name='ClassName' Value='Beltway.Skegness.CentralSystemUpdate.Transform_1' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='2f2008b6-4fae-46af-a3ae-197cb9281f53' ParentLink='Transform_InputMessagePartRef' LowerBound='29.114' HigherBound='29.126'>
                                <om:Property Name='MessageRef' Value='msgCanonical' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='3da4be44-a928-4b7d-a89f-9c02e45ab599' ParentLink='Transform_OutputMessagePartRef' LowerBound='29.36' HigherBound='29.60'>
                                <om:Property Name='MessageRef' Value='msgSQLUpdateStockRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='c035b919-d34c-4d44-a8d4-37fabae426e3' ParentLink='Construct_MessageRef' LowerBound='26.31' HigherBound='26.55'>
                            <om:Property Name='Ref' Value='msgSQLUpdateStockRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='0548865b-aeeb-4898-a0b4-6ca205f918f8' ParentLink='ComplexStatement_Statement' LowerBound='31.1' HigherBound='33.1'>
                        <om:Property Name='PortName' Value='Port_1' />
                        <om:Property Name='MessageName' Value='msgSQLUpdateStockRequest' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Receive' OID='ab176af9-9a01-4b8d-a3cc-342c988bf879' ParentLink='ComplexStatement_Statement' LowerBound='33.1' HigherBound='35.1'>
                        <om:Property Name='Activate' Value='False' />
                        <om:Property Name='PortName' Value='Port_1' />
                        <om:Property Name='MessageName' Value='msgSQLUpdateStockResponse' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Receive_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='fdef20bc-fca2-475f-b928-fd7ea05e2b55' ParentLink='ComplexStatement_Statement' LowerBound='35.1' HigherBound='37.1'>
                        <om:Property Name='Expression' Value='out_Result = &quot;Success&quot;;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='out_Result' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Catch' OID='4264f66a-b6e1-431c-bb3f-c413e6465170' ParentLink='Scope_Catch' LowerBound='40.1' HigherBound='47.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='da693e6f-c640-4e9f-8d7c-7b2a1260bfd5' ParentLink='Catch_Statement' LowerBound='43.1' HigherBound='46.1'>
                            <om:Property Name='Expression' Value='out_Result = ex.InnerException.ToString();&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Error-Stock SQL Update Process&quot;,ex.InnerException.ToString(),System.Diagnostics.EventLogEntryType.Error);&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='out_Result' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='08d5cacd-961f-4c5a-9620-e69e540f67ab' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Beltway.Skegness.CentralSystemUpdate.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='f49d1d84-1658-447f-8ae9-302b99bc7007' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ProcessUpdateStockdetailsSQL_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ProcessUpdateStockdetailsSQL_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessUpdateStockdetailsSQL")
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
                ProcessUpdateStockdetailsSQL __svc__ = (ProcessUpdateStockdetailsSQL)_service;
                __ProcessUpdateStockdetailsSQL_root_0 __ctx0__ = (__ProcessUpdateStockdetailsSQL_root_0)(__svc__._stateMgrs[0]);

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
        public class __ProcessUpdateStockdetailsSQL_1 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __ProcessUpdateStockdetailsSQL_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessUpdateStockdetailsSQL")
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
                ProcessUpdateStockdetailsSQL __svc__ = (ProcessUpdateStockdetailsSQL)_service;
                __ProcessUpdateStockdetailsSQL_1 __ctx1__ = (__ProcessUpdateStockdetailsSQL_1)(__svc__._stateMgrs[1]);
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);

                if (__ctx1__ != null && __ctx1__.__msgSQLUpdateStockRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLUpdateStockRequest);
                    __ctx1__.__msgSQLUpdateStockRequest = null;
                }
                if (__ctx2__ != null && __ctx2__.__msgSQLUpdateStockRequest != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgSQLUpdateStockRequest);
                    __ctx2__.__msgSQLUpdateStockRequest = null;
                }
                if (__ctx2__ != null && __ctx2__.__msgSQLUpdateStockResponse != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgSQLUpdateStockResponse);
                    __ctx2__.__msgSQLUpdateStockResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCanonical != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                    __ctx1__.__msgCanonical = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLUpdateStockResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLUpdateStockResponse);
                    __ctx1__.__msgSQLUpdateStockResponse = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLUpdateStockRequest")]
            public __messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema __msgSQLUpdateStockRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLUpdateStockResponse")]
            public __messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema __msgSQLUpdateStockResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCanonical")]
            public __messagetype_Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema __msgCanonical;
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
                ProcessUpdateStockdetailsSQL __svc__ = (ProcessUpdateStockdetailsSQL)_service;
                __ProcessUpdateStockdetailsSQL_root_0 __ctx0__ = (__ProcessUpdateStockdetailsSQL_root_0)(__svc__._stateMgrs[0]);
                __ProcessUpdateStockdetailsSQL_1 __ctx1__ = (__ProcessUpdateStockdetailsSQL_1)(__svc__._stateMgrs[1]);
                __Transaction_2_2 __ctx2__ = (__Transaction_2_2)(__svc__._stateMgrs[2]);

                if (__ctx1__.__msgSQLUpdateStockRequest != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLUpdateStockRequest);
                __ctx1__.__msgSQLUpdateStockRequest = __ctx2__.__msgSQLUpdateStockRequest;
                if (__ctx2__.__msgSQLUpdateStockRequest != null)
                    __ctx1__.RefMessage(__ctx1__.__msgSQLUpdateStockRequest);
                if (__ctx1__.__msgSQLUpdateStockResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLUpdateStockResponse);
                __ctx1__.__msgSQLUpdateStockResponse = __ctx2__.__msgSQLUpdateStockResponse;
                if (__ctx2__.__msgSQLUpdateStockResponse != null)
                    __ctx1__.RefMessage(__ctx1__.__msgSQLUpdateStockResponse);
                __ctx1__.__out_Result = __ctx2__.__out_Result;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLUpdateStockRequest")]
            public __messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema __msgSQLUpdateStockRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLUpdateStockResponse")]
            public __messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema __msgSQLUpdateStockResponse;
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
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_1")]
        internal PortType_1 Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(ProcessUpdateStockdetailsSQL).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessUpdateStockdetailsSQL), "Port_1"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "fbce8b5a-3b9d-4f13-917d-8191ff50426e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "ac186598-40b0-46e0-834a-991356bc12d3", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "ac186598-40b0-46e0-834a-991356bc12d3", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "0548865b-aeeb-4898-a0b4-6ca205f918f8", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "0548865b-aeeb-4898-a0b4-6ca205f918f8", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "ab176af9-9a01-4b8d-a3cc-342c988bf879", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "ab176af9-9a01-4b8d-a3cc-342c988bf879", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "fdef20bc-fca2-475f-b928-fd7ea05e2b55", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "fdef20bc-fca2-475f-b928-fd7ea05e2b55", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "4264f66a-b6e1-431c-bb3f-c413e6465170", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "da693e6f-c640-4e9f-8d7c-7b2a1260bfd5", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "da693e6f-c640-4e9f-8d7c-7b2a1260bfd5", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "4264f66a-b6e1-431c-bb3f-c413e6465170", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "fbce8b5a-3b9d-4f13-917d-8191ff50426e", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,2,2,2,18,1,1,1,1,1,};
        public static int[] __progressLocation2 = new int[] { 4,4,4,5,6,6,6,7,8,8,9,10,10,11,11,11,11,};
        public static int[] __progressLocation3 = new int[] { 12,12,13,13,14,14,17,17,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ProcessUpdateStockdetailsSQL_root_0 __ctx0__ = (__ProcessUpdateStockdetailsSQL_root_0)_stateMgrs[0];
            __ProcessUpdateStockdetailsSQL_1 __ctx1__ = (__ProcessUpdateStockdetailsSQL_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_1 = new PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ProcessUpdateStockdetailsSQL_1(this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ProcessUpdateStockdetailsSQL_root_0 __ctx0__ = (__ProcessUpdateStockdetailsSQL_root_0)_stateMgrs[0];
            __ProcessUpdateStockdetailsSQL_1 __ctx1__ = (__ProcessUpdateStockdetailsSQL_1)_stateMgrs[1];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__msgCanonical = new __messagetype_Beltway_Skegness_CentralSystemUpdate_Skegness_SQLUpdate_CanonicalSchema("msgCanonical", __ctx1__);
                __ctx1__.__msgCanonical.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[0]);
                __ctx1__.RefMessage(__ctx1__.__msgCanonical);
                __ctx1__.__msgCanonical.ConstructionCompleteEvent();
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__out_Result = default(System.String);
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
                __ctx2__ = new __Transaction_2_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (Port_1 != null)
                {
                    Port_1.Close(__ctx1__, __seg__);
                    Port_1 = null;
                }
                Tracker.FireEvent(__eventLocations[18],__eventData[10],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (__ctx2__ != null && __ctx2__.__msgSQLUpdateStockResponse != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgSQLUpdateStockResponse);
                    __ctx2__.__msgSQLUpdateStockResponse = null;
                }
                if (__ctx2__ != null && __ctx2__.__msgSQLUpdateStockRequest != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__msgSQLUpdateStockRequest);
                    __ctx2__.__msgSQLUpdateStockRequest = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLUpdateStockResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLUpdateStockResponse);
                    __ctx1__.__msgSQLUpdateStockResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLUpdateStockRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLUpdateStockRequest);
                    __ctx1__.__msgSQLUpdateStockRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body);
                    __edata.Messages.Add(__ctx1__.__msgCanonical);
                    Tracker.FireEvent(__eventLocations[0],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgCanonical != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCanonical);
                    __ctx1__.__msgCanonical = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 10;
            case 10:
                Args[1] = __ctx1__.__out_Result;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __ProcessUpdateStockdetailsSQL_root_0 __ctx0__ = (__ProcessUpdateStockdetailsSQL_root_0)_stateMgrs[0];
            __ProcessUpdateStockdetailsSQL_1 __ctx1__ = (__ProcessUpdateStockdetailsSQL_1)_stateMgrs[1];
            __Transaction_2_2 __ctx2__ = (__Transaction_2_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx2__.__msgSQLUpdateStockRequest = __ctx1__.__msgSQLUpdateStockRequest;
                if (__ctx2__.__msgSQLUpdateStockRequest != null)
                    __ctx2__.RefMessage(__ctx2__.__msgSQLUpdateStockRequest);
                __ctx2__.__msgSQLUpdateStockResponse = __ctx1__.__msgSQLUpdateStockResponse;
                if (__ctx2__.__msgSQLUpdateStockResponse != null)
                    __ctx2__.RefMessage(__ctx2__.__msgSQLUpdateStockResponse);
                __ctx2__.__out_Result = __ctx1__.__out_Result;
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                {
                    __messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema __msgSQLUpdateStockRequest = new __messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema("msgSQLUpdateStockRequest", __ctx2__);

                    ApplyTransform(typeof(Beltway.Skegness.CentralSystemUpdate.Transform_1), new object[] {__msgSQLUpdateStockRequest.part}, new object[] {__ctx1__.__msgCanonical.part});

                    if (__ctx2__.__msgSQLUpdateStockRequest != null)
                        __ctx2__.UnrefMessage(__ctx2__.__msgSQLUpdateStockRequest);
                    __ctx2__.__msgSQLUpdateStockRequest = __msgSQLUpdateStockRequest;
                    __ctx2__.RefMessage(__ctx2__.__msgSQLUpdateStockRequest);
                }
                __ctx2__.__msgSQLUpdateStockRequest.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__msgSQLUpdateStockRequest);
                    __edata.Messages.Add(__ctx1__.__msgCanonical);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_1.SendMessage(0, __ctx2__.__msgSQLUpdateStockRequest, null, null, out __ctx0__.__subWrapper0, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__msgSQLUpdateStockRequest);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx2__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx2__.__msgSQLUpdateStockResponse != null)
                    __ctx2__.UnrefMessage(__ctx2__.__msgSQLUpdateStockResponse);
                __ctx2__.__msgSQLUpdateStockResponse = new __messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema("msgSQLUpdateStockResponse", __ctx2__);
                __ctx2__.RefMessage(__ctx2__.__msgSQLUpdateStockResponse);
                Port_1.ReceiveMessage(0, __msgEnv__, __ctx2__.__msgSQLUpdateStockResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx2__.__msgSQLUpdateStockResponse);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx2__.__out_Result = "Success";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 16;
            case 16:
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
                Tracker.FireEvent(__eventLocations[12],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx2__.__out_Result = __ctx2__.__ex_0.InnerException.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                System.Diagnostics.EventLog.WriteEntry("Error-Stock SQL Update Process", __ctx2__.__ex_0.InnerException.ToString(), System.Diagnostics.EventLogEntryType.Error);
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[9],_stateMgrs[2].TrackDataStream );
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
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{0DCE92E2-2211-4A5E-ACD7-6F40453794E3}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Beltway_Skegness_CentralSystemUpdate_CompositeSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Beltway.Skegness.CentralSystemUpdate.CompositeSchema _schema = new Beltway.Skegness.CentralSystemUpdate.CompositeSchema();

        public __Beltway_Skegness_CentralSystemUpdate_CompositeSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Beltway.Skegness.CentralSystemUpdate.CompositeSchema",
        new System.Type[]{
            typeof(Beltway.Skegness.CentralSystemUpdate.CompositeSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Beltway_Skegness_CentralSystemUpdate_CompositeSchema__)
        },
        0,
        @"http://Beltway.Skegness.CentralSystemUpdate.CompositeSchema#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Beltway_Skegness_CentralSystemUpdate_CompositeSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __Beltway_Skegness_CentralSystemUpdate_CompositeSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Beltway_Skegness_CentralSystemUpdate_CompositeSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
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
