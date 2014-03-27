<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">
	<xsl:output indent="yes"></xsl:output>
	<xsl:template match="/">
     <HTML>
       <HEAD><TITLE>Library Details</TITLE></HEAD>
       <BODY>
      	 <P> <B><font size="10"> Library Details</font></B>     <hr/></P>
				
					<table>
						<xsl:for-each select="LIBRARY/BOOK">
							<tr>
								<td width="100" colspan="5"><HR/></td>
							</tr>
							<tr>
								<td>Book ID: </td><td><xsl:value-of select="@bookid"/></td>
							</tr>
							<tr>
								<td>Title: </td><td><xsl:value-of select="TITLE"/></td>
							</tr>
							<xsl:for-each select="AUTHOR">
								<tr>
									<td>Author: </td><td><xsl:value-of select="."/></td>
								</tr>
							</xsl:for-each>
							<tr>
								<td>Publisher: </td><td><xsl:value-of select="PUBLISHER"/></td>
							</tr>
							<tr>
								<td>Year: </td><td><xsl:value-of select="YEAROFPUBLICATION"/></td>
							</tr>
							<tr>
								<td>Cost: </td><td><xsl:value-of select="COSTPRICE"/></td>
							</tr>
							<xsl:for-each select="ISSUES">
								<tr>
									<td>Student ID: </td><td><xsl:value-of select="./@studentid"/></td>
								</tr>
								<tr>
									<td>Student First: </td><td><xsl:value-of select="./NAME/FIRST"/></td>
								</tr>
								<tr>
									<td>Student Last: </td><td><xsl:value-of select="./NAME/LAST"/></td>
								</tr>
								<tr>
									<td>Date of Issue: </td><td><xsl:value-of select="./DATEOFISSUE"/></td>
								</tr>
							</xsl:for-each>
							<tr>
								<td>Remarks: </td><td><xsl:value-of select="REMARKS"/></td>
							</tr>
							<tr>
								<td colspan="2"><hr/></td>
							</tr>
						</xsl:for-each>
					</table>
				</BODY>
			</HTML>
	</xsl:template>
</xsl:stylesheet>
