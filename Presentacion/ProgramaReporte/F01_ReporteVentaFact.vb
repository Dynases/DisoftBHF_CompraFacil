Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Imports Janus.Windows.GridEX
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid

Public Class F01_ReporteVentaFact
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub F01_ReporteVentaFact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ventas Facturadas"
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Dim dt As DataTable = L_fnReporteFacturados(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"))

        If (dt.Rows.Count > 0) Then


            grDatos.DataSource = dt
            grDatos.RetrieveStructure()
            grDatos.AlternatingColors = True

            'a.canumi ,a.canombre ,a.cadesc ,a.caimg ,a.cafact,a.cahact,a.cauact
            '    With grBuscador.RootTable.Columns("canumi")
            '    .Width = 100
            '    .Caption = "CODIGO"
            '    .Visible = True

            'End With
            'With grBuscador.RootTable.Columns("canombre")
            '    .Width = 300
            '    .Caption = "NOMBRE CATEGORIA"
            '    .Visible = True
            'End With


            'With grBuscador.RootTable.Columns("cadesc")
            '    .Width = 350
            '    .Visible = True
            '    .Caption = "DESCRIPCION"
            'End With
            'With grBuscador.RootTable.Columns("caimg")
            '    .Width = 150
            '    .Visible = False
            'End With
            'With grBuscador.RootTable.Columns("caest")
            '    .Width = 150
            '    .Visible = False
            'End With

            'With grBuscador.RootTable.Columns("cafact")
            '    .Width = 120
            '    .Visible = True
            '    .Caption = "FECHA"
            '    .FormatString = "dd/MM/yyyy"
            'End With


            'With grBuscador.RootTable.Columns("cahact")
            '    .Width = 50
            '    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            '    .Visible = False
            'End With
            'With grBuscador.RootTable.Columns("cauact")
            '    .Width = 50
            '    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            '    .Visible = False
            'End With

            With grDatos
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                .FilterMode = FilterMode.Automatic
                .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                .GroupByBoxVisible = False
                'diseño de la grilla
                .VisualStyle = VisualStyle.Office2007
            End With

        End If

    End Sub
End Class