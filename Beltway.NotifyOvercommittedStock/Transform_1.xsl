<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s0" version="1.0" xmlns:s0="http://schemas.microsoft.com/Sql/2008/05/TypedPolling/Test" xmlns:ns0="http://Beltway.NotifyOvercommittedStock.GroupWarehouseStockdetials">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:key name="groups1" match="s0:TypedPolling/s0:TypedPollingResultSet0/s0:TypedPollingResultSet0" use="s0:y_WarehouseId"/>
  <xsl:key name="groups2" match="s0:TypedPolling/s0:TypedPollingResultSet0/s0:TypedPollingResultSet0" use="concat(s0:y_WarehouseId,s0:y_WarehouseId)"/>
  <xsl:template match="/">
    <xsl:apply-templates select="/s0:TypedPolling" />
  </xsl:template>
  <xsl:template match="/s0:TypedPolling" >
    <ns0:OvercommittedStockDetails>
      <xsl:for-each select="s0:TypedPollingResultSet0/s0:TypedPollingResultSet0[generate-id()=generate-id(key('groups1',s0:y_WarehouseId/text()))]">
        <Details>
          <y_Warehouseid>
            <xsl:value-of select="s0:y_WarehouseId/text()"/>
          </y_Warehouseid>
          <!--<xsl:for-each select="key('groups2',concat(s0:y_WarehouseId,s0:y_WarehouseId))">-->
              <Stockdetails>
                  <n_Warehouseid>
                    <xsl:value-of select="s0:n_WarehouseId/text()" />
                  </n_Warehouseid>
                  <xsl:for-each select="key('groups2',concat(s0:y_WarehouseId,s0:y_WarehouseId))">
                  <Stocks>
                    <ProductId>
                      <xsl:value-of select="s0:n_productid/text()" />
                    </ProductId>
                    <n_Level>
                      <xsl:value-of select="s0:n_level/text()" />
                    </n_Level>
                  </Stocks>
                  <!--</xsl:for-each>-->
                  </xsl:for-each>
              </Stockdetails>
            
          <!--</xsl:for-each>-->
        </Details>
      </xsl:for-each>
    </ns0:OvercommittedStockDetails>
  </xsl:template>
</xsl:stylesheet>