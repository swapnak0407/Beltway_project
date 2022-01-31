namespace Beltway.ExtractWarehouseId {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "WarehouseName", XPath = @"/*[local-name()='spExtractWarehouseid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='WarehouseName' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"spExtractWarehouseid", @"spExtractWarehouseidResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Beltway.ExtractWarehouseId.ProcedureResultSet_dbo_spExtractWarehouseid", typeof(global::Beltway.ExtractWarehouseId.ProcedureResultSet_dbo_spExtractWarehouseid))]
    public sealed class TypedProcedure_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/spExtractWarehouseid"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Beltway.ExtractWarehouseId.ProcedureResultSet_dbo_spExtractWarehouseid"" namespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/spExtractWarehouseid"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">TypedProcedure.dbo</fileNameHint>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/spExtractWarehouseid"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""spExtractWarehouseid"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/spExtractWarehouseid</doc:action>
      </xs:documentation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='spExtractWarehouseid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='WarehouseName' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WarehouseName"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""250"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""spExtractWarehouseidResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/spExtractWarehouseid/response</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""StoredProcedureResultSet0"" nillable=""true"" type=""ns3:ArrayOfStoredProcedureResultSet0"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TypedProcedure_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "spExtractWarehouseid";
                _RootElements[1] = "spExtractWarehouseidResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"spExtractWarehouseid")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "WarehouseName", XPath = @"/*[local-name()='spExtractWarehouseid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='WarehouseName' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"spExtractWarehouseid"})]
        public sealed class spExtractWarehouseid : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public spExtractWarehouseid() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "spExtractWarehouseid";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"spExtractWarehouseidResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"spExtractWarehouseidResponse"})]
        public sealed class spExtractWarehouseidResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public spExtractWarehouseidResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "spExtractWarehouseidResponse";
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
}
