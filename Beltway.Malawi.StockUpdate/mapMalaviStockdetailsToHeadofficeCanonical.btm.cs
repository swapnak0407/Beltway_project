namespace Beltway.Malawi.StockUpdate {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Beltway.Malawi.StockUpdate.Malawi_Stockupdate", typeof(global::Beltway.Malawi.StockUpdate.Malawi_Stockupdate))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema", typeof(global::Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema))]
    public sealed class mapMalaviStockdetailsToHeadofficeCanonical : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://Beltway.Skegness.CentralSystemUpdate.Skegness"" xmlns:s0=""http://Beltway.Malawi.StockUpdate.Malawi_Stockupdate"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Stockdetails"" />
  </xsl:template>
  <xsl:template match=""/s0:Stockdetails"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;Malawi&quot;)"" />
    <ns0:Root>
      <CanonicalSchema>
        <WarehouseId>
          <xsl:value-of select=""$var:v1"" />
        </WarehouseId>
        <xsl:if test=""ProductCode"">
          <ProductId>
            <xsl:value-of select=""ProductCode/text()"" />
          </ProductId>
        </xsl:if>
        <xsl:if test=""Level"">
          <Level>
            <xsl:value-of select=""Level/text()"" />
          </Level>
        </xsl:if>
      </CanonicalSchema>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Beltway.Malawi.StockUpdate.Malawi_Stockupdate";
        
        private const global::Beltway.Malawi.StockUpdate.Malawi_Stockupdate _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema";
        
        private const global::Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Beltway.Malawi.StockUpdate.Malawi_Stockupdate";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema";
                return _TrgSchemas;
            }
        }
    }
}
