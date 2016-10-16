<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaticChart.aspx.cs" Inherits="StaticChart" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>.NET Fans - Favorite Pastime Survey</h3>

        <asp:Chart ID="passtimeChart" runat="server">
  <Series>
    <asp:Series ChartType="Pie"> 
      <Points> 
        <asp:DataPoint AxisLabel="Programming the Web" YValues="42" /> 
        <asp:DataPoint AxisLabel="Building Robots" YValues="18" /> 
        <asp:DataPoint AxisLabel="Playing Video Games" YValues="17" /> 
        <asp:DataPoint AxisLabel="Playing Foosball" YValues="5" /> 
      </Points> 
    </asp:Series> 
  </Series>
  <ChartAreas>
    <asp:ChartArea Name="chartArea">
    </asp:ChartArea>
  </ChartAreas>
</asp:Chart>
        </div>
    </form>
</body>
</html>
