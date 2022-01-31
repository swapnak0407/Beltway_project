namespace Beltway.Tanzania.StockUpdate {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF", typeof(global::Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema", typeof(global::Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema))]
    public sealed class mapTanzaniaStockupdate_to_headofficeCanonial : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://Beltway.Skegness.CentralSystemUpdate.Skegness"" xmlns:s0=""http://Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TanzaniaStockupdate"" />
  </xsl:template>
  <xsl:template match=""/s0:TanzaniaStockupdate"">
    <ns0:Root>
      <xsl:for-each select=""StockDetails"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalLte(string(Qty/text()) , &quot;5000&quot;)"" />
        <xsl:if test=""$var:v1"">
          <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;Tanzania&quot;)"" />
          <xsl:variable name=""var:v3"" select=""string(Qty/text())"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:LogicalLte($var:v3 , &quot;5000&quot;)"" />
          <CanonicalSchema>
            <WarehouseId>
              <xsl:value-of select=""$var:v2"" />
            </WarehouseId>
            <ProductId>
              <xsl:value-of select=""ProductCode/text()"" />
            </ProductId>
            <xsl:if test=""string($var:v4)='true'"">
              <xsl:variable name=""var:v5"" select=""Qty/text()"" />
              <Level>
                <xsl:value-of select=""$var:v5"" />
              </Level>
            </xsl:if>
          </CanonicalSchema>
        </xsl:if>
      </xsl:for-each>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public bool LogicalLte(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 <= d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) <= 0;
	}
	return ret;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF";
        
        private const global::Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF";
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
