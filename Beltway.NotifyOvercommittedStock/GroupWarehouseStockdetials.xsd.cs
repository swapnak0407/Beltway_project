namespace Beltway.NotifyOvercommittedStock {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials",@"OvercommittedStockdetails")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OvercommittedStockdetails"})]
    public sealed class GroupWarehouseStockdetials : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""OvercommittedStockdetails"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""Details"">
          <xs:complexType>
            <xs:sequence maxOccurs=""unbounded"">
              <xs:element name=""y_Warehouseid"" type=""xs:string"" />
              <xs:element maxOccurs=""unbounded"" name=""Stockdetails"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""n_Warehouseid"" type=""xs:string"" />
                    <xs:element name=""Stocks"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""n_Level"" type=""xs:string"" />
                          <xs:element name=""ProductId"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GroupWarehouseStockdetials() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OvercommittedStockdetails";
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
