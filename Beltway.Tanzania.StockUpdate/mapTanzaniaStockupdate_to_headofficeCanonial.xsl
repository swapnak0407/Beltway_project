<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s0" version="1.0" xmlns:ns0="http://Beltway.Skegness.CentralSystemUpdate.Skegness" xmlns:s0="http://Beltway.Tanzania.StockUpdate.TanzaniaStockupdate_FF">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s0:TanzaniaStockDetails" />
  </xsl:template>
  <xsl:template match="/s0:TanzaniaStockDetails">
    <ns0:Root>
      <xsl:for-each select="StockDetails">
        <CanonicalSchema>
          <WarehouseId>1</WarehouseId>
          <ProductId>
            <xsl:value-of select="ProductCode/text()" />
          </ProductId>
          <Level>
            <xsl:value-of select="Quantity/text()" />
          </Level>
        </CanonicalSchema>
      </xsl:for-each>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>