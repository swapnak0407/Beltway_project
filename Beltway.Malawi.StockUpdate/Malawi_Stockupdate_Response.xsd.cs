namespace Beltway.Malawi.StockUpdate {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response",@"Response")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Result", XPath = @"/*[local-name()='Response' and namespace-uri()='http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response']/*[local-name()='Result' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Response"})]
    public sealed class Malawi_Stockupdate_Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Response"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Response' and namespace-uri()='http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate_Response']/*[local-name()='Result' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Result"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Malawi_Stockupdate_Response() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Response";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
