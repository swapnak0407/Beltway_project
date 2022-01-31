namespace Beltway.Skegness.CentralSystemUpdate {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema", typeof(global::Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Beltway.Skegness.CentralSystemUpdate.CompositeSchema", typeof(global::Beltway.Skegness.CentralSystemUpdate.CompositeSchema))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns1=""http://Beltway.Skegness.CentralSystemUpdate.CompositeSchema"" xmlns:s0=""http://Beltway.Skegness.CentralSystemUpdate.Skegness"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns1:Root>
      <xsl:for-each select=""CanonicalSchema"">
        <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;Date&quot;)"" />
        <xsl:variable name=""var:v2"" select=""userCSharp:LogicalNe(string(ProductId/text()) , string($var:v1))"" />
        <xsl:if test=""$var:v2"">
          <xsl:variable name=""var:v3"" select=""string(ProductId/text())"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:LogicalNe($var:v3 , string($var:v1))"" />
          <ns0:spInsertWarehouseStockDetails>
            <ns0:warehouseName>
              <xsl:value-of select=""WarehouseId/text()"" />
            </ns0:warehouseName>
            <xsl:if test=""string($var:v4)='true'"">
              <xsl:variable name=""var:v5"" select=""ProductId/text()"" />
              <ns0:productCode>
                <xsl:value-of select=""$var:v5"" />
              </ns0:productCode>
            </xsl:if>
            <xsl:variable name=""var:v6"" select=""userCSharp:MyConcat(string(Level/text()))"" />
            <ns0:qty>
              <xsl:value-of select=""$var:v6"" />
            </ns0:qty>
          </ns0:spInsertWarehouseStockDetails>
        </xsl:if>
      </xsl:for-each>
    </ns1:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public int MyConcat(string level)
{
       if( level == ""NOSTOCK"")
	return 0;
       else
               return System.Convert.ToInt32(level);
}


public bool LogicalNe(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 != d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) != 0;
	}
	return ret;
}


public string StringConcat(string param0)
{
   return param0;
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
        
        private const string _strSrcSchemasList0 = @"Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema";
        
        private const global::Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Beltway.Skegness.CentralSystemUpdate.CompositeSchema";
        
        private const global::Beltway.Skegness.CentralSystemUpdate.CompositeSchema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Beltway.Skegness.CentralSystemUpdate.Skegness_SQLUpdate_CanonicalSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Beltway.Skegness.CentralSystemUpdate.CompositeSchema";
                return _TrgSchemas;
            }
        }
    }
}
