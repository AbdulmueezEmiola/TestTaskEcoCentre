<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/">
      <html>
        <head>
          <style>            
            table{
              border-collapse:collapse
            }                        
            td,th{
              padding:10px;
              text-align:center;
            }
          </style>
        </head>
        <body>
          <h2>HTML report</h2>
          <table border="1">
            <tr>
              <th>title</th>
              <th>author</th>
              <th>category</th>
              <th>year</th>
              <th>price</th>
            </tr>
            <xsl:for-each select ="bookstore/book" >
              <tr>
                <td>
                  <xsl:value-of select="title"/>
                </td>
                <td>
                  <xsl:for-each select="author">
                    <xsl:if test="position() &gt; 1">; </xsl:if>
                    <xsl:value-of select="."/>
                  </xsl:for-each>
                </td>
                <td>
                  <xsl:value-of select="@category"/>
                </td>
                <td>
                  <xsl:value-of select="year"/>
                </td>
                <td>
                  <xsl:value-of select="price"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
