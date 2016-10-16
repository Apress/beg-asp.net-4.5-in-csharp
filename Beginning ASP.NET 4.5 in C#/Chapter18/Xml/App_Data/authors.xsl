<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                version="1.0">

<xsl:template match="AuthorsDataSet">
   <h1>The Author List</h1>
  
      <xsl:apply-templates select="AuthorsTable"/>
 
   <i>Created through XML and XSLT</i>
</xsl:template>

<xsl:template match="AuthorsTable">
<p>
<b>Name: </b><xsl:value-of select="au_lname"/>, <xsl:value-of select="au_fname"/>
<br/>
<b>Phone: </b> <xsl:value-of select="phone"/>
</p>
</xsl:template>

</xsl:stylesheet>


