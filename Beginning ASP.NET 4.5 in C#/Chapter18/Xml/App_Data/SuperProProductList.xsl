<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    version="1.0" >

  <xsl:template match="SuperProProductList">
    <html><body><table border="1">
    <xsl:apply-templates select="Product"/>
    </table></body></html>
  </xsl:template>
  
  <xsl:template match="Product">
    <tr>
    <td><xsl:value-of select="@ID"/></td>
    <td><xsl:value-of select="@Name"/></td>
    <td><xsl:value-of select="Price"/></td>
    </tr>
  </xsl:template>

</xsl:stylesheet>

  