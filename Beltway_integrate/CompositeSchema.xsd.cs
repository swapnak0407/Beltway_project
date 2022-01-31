namespace Beltway.Skegness.CentralSystemUpdate {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Beltway.Skegness.CentralSystemUpdate.CompositeSchema",@"Root")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Root"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Beltway.Skegness.CentralSystemUpdate.TypedProcedure_dbo", typeof(global::Beltway.Skegness.CentralSystemUpdate.TypedProcedure_dbo))]
    public sealed class CompositeSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Beltway.Skegness.CentralSystemUpdate.CompositeSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" targetNamespace=""http://Beltway.Skegness.CentralSystemUpdate.CompositeSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Beltway.Skegness.CentralSystemUpdate.TypedProcedure_dbo"" namespace=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Root"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" ref=""ns0:spInsertWarehouseStockDetails"" />
        <xs:element ref=""ns0:spInsertWarehouseStockDetailsResponse"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CompositeSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Root";
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
