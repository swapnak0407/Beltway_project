namespace Beltway.Malawi.StockUpdate
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class JsonReceive : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>Microsoft.BizTalk.Component.JsonDecoder,Microsoft.BizTalk.Pipel"+
"ine.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <C"+
"omponentName>JSON decoder</ComponentName>          <Description>JSON decoder component</Description>"+
"          <Version>1.0</Version>          <Properties>            <Property Name=\"RootNode\">        "+
"      <Value xsi:type=\"xsd:string\">Stockdetails</Value>            </Property>            <Property "+
"Name=\"RootNodeNamespace\">              <Value xsi:type=\"xsd:string\">http://Beltway.Malawi.StockUpdat"+
"e.Malawi_Stockupdate</Value>            </Property>          </Properties>          <CachedDisplayNa"+
"me>JSON decoder</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Compon"+
"ent>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" "+
"Name=\"Disassemble\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-"+
"83fa-4a5040674ad6\" />      <Components>        <Component>          <Name>Microsoft.BizTalk.Componen"+
"t.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToke"+
"n=31bf3856ad364e35</Name>          <ComponentName>XML disassembler</ComponentName>          <Descrip"+
"tion>Streaming XML disassembler</Description>          <Version>1.0</Version>          <Properties> "+
"           <Property Name=\"EnvelopeSpecNames\">              <Value xsi:type=\"xsd:string\" />         "+
"   </Property>            <Property Name=\"EnvelopeSpecTargetNamespaces\">              <Value xsi:typ"+
"e=\"xsd:string\" />            </Property>            <Property Name=\"DocumentSpecNames\">             "+
" <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"DocumentSpecTarge"+
"tNamespaces\">              <Value xsi:type=\"xsd:string\" />            </Property>            <Proper"+
"ty Name=\"AllowUnrecognizedMessage\">              <Value xsi:type=\"xsd:boolean\">false</Value>        "+
"    </Property>            <Property Name=\"ValidateDocument\">              <Value xsi:type=\"xsd:bool"+
"ean\">false</Value>            </Property>            <Property Name=\"RecoverableInterchangeProcessin"+
"g\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Prop"+
"erty Name=\"HiddenProperties\">              <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces"+
",DocumentSpecTargetNamespaces</Value>            </Property>          </Properties>          <Cached"+
"DisplayName>XML disassembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>   "+
"     </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name"+
"\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-45"+
"36-83fa-4a5040674ad6\" />      <Components>        <Component>          <Name>Microsoft.BizTalk.Compo"+
"nent.XmlValidator,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKey"+
"Token=31bf3856ad364e35</Name>          <ComponentName>XML validator</ComponentName>          <Descri"+
"ption>XML validator component.</Description>          <Version>1.0</Version>          <Properties>  "+
"          <Property Name=\"DocumentSpecName\">              <Value xsi:type=\"xsd:string\" />           "+
" </Property>            <Property Name=\"DocumentSpecTargetNamespaces\">              <Value xsi:type="+
"\"xsd:string\" />            </Property>            <Property Name=\"HiddenProperties\">              <V"+
"alue xsi:type=\"xsd:string\">DocumentSpecTargetNamespaces</Value>            </Property>            <P"+
"roperty Name=\"RecoverableInterchangeProcessing\">              <Value xsi:type=\"xsd:boolean\">false</V"+
"alue>            </Property>          </Properties>          <CachedDisplayName>XML validator</Cache"+
"dDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components"+
">    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" mi"+
"nOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <"+
"Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "5c5d9e6f-debf-49b6-ac0b-bcf80baf4ec7";
        
        public JsonReceive()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.JsonDecoder,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"RootNode\">     "+
" <Value xsi:type=\"xsd:string\">Stockdetails</Value>    </Property>    <Property Name=\"RootNodeNamespa"+
"ce\">      <Value xsi:type=\"xsd:string\">http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate</Value> "+
"   </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNamesp"+
"aces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">   "+
"   <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespaces\"> "+
"     <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"AllowUnrecognizedMessage\">   "+
"   <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\"> "+
"     <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"RecoverableInterc"+
"hangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name="+
"\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTarge"+
"tNamespaces</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
            stage = this.AddStage(new System.Guid("9d0e410d-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp2 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlValidator,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp2 is IPersistPropertyBag)
            {
                string comp2XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"DocumentSpecNam"+
"e\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespa"+
"ces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"HiddenProperties\">     "+
" <Value xsi:type=\"xsd:string\">DocumentSpecTargetNamespaces</Value>    </Property>    <Property Name="+
"\"RecoverableInterchangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property> "+
" </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp2XmlProperties);;
                ((IPersistPropertyBag)(comp2)).Load(pb, 0);
            }
            this.AddComponent(stage, comp2);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
