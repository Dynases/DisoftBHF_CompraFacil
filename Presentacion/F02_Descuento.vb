Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls


Public Class F02_Descuento

#Region "Variables Globales"

    Dim _Pos As Integer
    Dim _Nuevo As Boolean
    Dim _Dsencabezado As DataSet

    Dim _BindingSource As BindingSource
    Dim _Modificar As Boolean

    Dim modif As Boolean = True

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

    Dim dtPreciosDesc As New DataTable

#End Region

#Region "Metodos"
    Private Sub _PIniciarTodo()
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If
        P_prArmarComboCategoria()
        _PCargarGridCategoriasPrecios(-1)
        _Filtrar()

        MBtNuevo.Visible = False
        MBtModificar.Visible = False
        MBtEliminar.Visible = False

        Me.Text = " P R E C I O S  -  D E S C U E N T O S "
        Me.WindowState = FormWindowState.Maximized

        btNuevoP.Image = My.Resources.ADICIONAR

        MBtPrimero.PerformClick()

        'activar los permisos del rol
        _PAsignarPermisos()
    End Sub

    Private Sub _PAsignarPermisos()
        Dim dtRolUsu() As DataRow = L_prRolDetalleGeneral(gi_userRol).Select("yaprog='" + _nameButton + "'")

        Dim show As Boolean = False
        Dim add As Boolean = False
        Dim modif As Boolean = False
        Dim del As Boolean = False

        If (dtRolUsu.Count = 1) Then
            show = dtRolUsu(0).Item("ycshow")
            add = dtRolUsu(0).Item("ycadd")
            modif = dtRolUsu(0).Item("ycmod")
            del = dtRolUsu(0).Item("ycdel")
        End If

        If add = False Then
            'MBtNuevo.Visible = False
        End If
        If modif = False Then
            'MBtModificar.Visible = False
        End If
        If del = False Then
            'MBtEliminar.Visible = False
        End If
    End Sub
    Private Sub _PGrabarRegistro()
        'borrar toda la tabla por la categoria
        Dim i, j, codProd, numi, catPrecio As Integer
        Dim precio As Double
        Dim dtCatPrecios As DataTable
        dtCatPrecios = L_CategoriaPrecioGeneral()
        'terminar edicion de la grilla
        JCb_CatProducto.Focus()

        For i = 0 To JGr_Detalle.RowCount - 1
            JGr_Detalle.Row = i
            If (JGr_Detalle.CurrentRow.Cells("huboCambio").Value) Then
                codProd = JGr_Detalle.CurrentRow.Cells(0).Value
                L_PrecioProd_BorrarPorCodProd(codProd)
                For j = 0 To dtCatPrecios.Rows.Count - 1
                    catPrecio = dtCatPrecios.Rows(j).Item("cinumi")
                    If IsNumeric(JGr_Detalle.CurrentRow.Cells(j + 3).Value) = True Then
                        precio = JGr_Detalle.CurrentRow.Cells(j + 3).Value
                    Else
                        precio = 0
                    End If
                    L_PrecioProd_Grabar(numi, codProd, catPrecio, precio)
                Next
            End If
        Next

        ToastNotification.Show(Me, "Precios de " + JCb_CatProducto.Text + " Grabado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomRight)
        _PCargarDetalle(JCb_CatProducto.Value)
    End Sub

    'Private Sub _PGrabarRegistro()
    '    If btGrabar.Tag = 0 Then
    '        btGrabar.Tag = 1
    '        btGrabar.Image = My.Resources.CONFIRMACION
    '        'btGrabar.ImageLarge = My.Resources.CONFIRMACION
    '        BubbleBar1.Refresh()
    '        Exit Sub
    '    Else
    '        btGrabar.Tag = 0
    '        btGrabar.Image = My.Resources.GRABAR
    '        'btGrabar.ImageLarge = My.Resources.GRABAR
    '        BubbleBar1.Refresh()
    '    End If

    '    'borrar toda la tabla por la categoria
    '    Dim i, j, codProd, numi, catPrecio, precio As Integer
    '    Dim dtCatPrecios As DataTable
    '    dtCatPrecios = L_General_LibreriaDetalle(-1, 8).Tables(0)
    '    'terminar edicion de la grilla
    '    JCb_CatProducto.Focus()

    '    For i = 0 To JGr_Detalle.RowCount - 1
    '        JGr_Detalle.Row = i
    '        codProd = JGr_Detalle.CurrentRow.Cells(0).Value
    '        L_PrecioProd_BorrarPorCodProd(codProd)
    '        For j = 0 To dtCatPrecios.Rows.Count - 1
    '            catPrecio = dtCatPrecios.Rows(j).Item("cenum")
    '            If IsNumeric(JGr_Detalle.CurrentRow.Cells(j + 2).Value) = True Then
    '                precio = JGr_Detalle.CurrentRow.Cells(j + 2).Value
    '            Else
    '                precio = 0
    '            End If
    '            L_PrecioProd_Grabar(numi, codProd, catPrecio, precio)
    '        Next
    '    Next

    '    ToastNotification.Show(Me, "Precios de " + JCb_CatProducto.Text + " Grabado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomRight)
    '    _PCargarDetalle(JCb_CatProducto.Value)
    'End Sub

    'Private Sub _PGrabarRegistro2()
    '    If btGrabar.Tag = 0 Then
    '        btGrabar.Tag = 1
    '        btGrabar.Image = My.Resources.CONFIRMACION
    '        'btGrabar.ImageLarge = My.Resources.CONFIRMACION
    '        BubbleBar1.Refresh()
    '        Exit Sub
    '    Else
    '        btGrabar.Tag = 0
    '        btGrabar.Image = My.Resources.GRABAR
    '        'btGrabar.ImageLarge = My.Resources.GRABAR
    '        BubbleBar1.Refresh()
    '    End If

    '    'borrar toda la tabla por la categoria
    '    Dim i, j, codProd, numi, precio As Integer
    '    Dim catPrecio, catDesc As String
    '    Dim dtCatPrecios As DataTable
    '    'dtCatPrecios = L_General_LibreriaDetalle(-1, 8).Tables(0)
    '    dtCatPrecios = L_CategoriaPrecioGeneral()

    '    'terminar edicion de la grilla
    '    JCb_CatProducto.Focus()

    '    For i = 0 To JGr_Detalle.RowCount - 1
    '        JGr_Detalle.Row = i
    '        codProd = JGr_Detalle.CurrentRow.Cells(0).Value
    '        L_PrecioProd_BorrarPorCodProd(codProd)
    '        For j = 0 To dtCatPrecios.Rows.Count - 1
    '            catPrecio = dtCatPrecios.Rows(j).Item("chcatcl")
    '            catDesc = dtCatPrecios.Rows(j).Item("chdesc")
    '            If IsNumeric(JGr_Detalle.CurrentRow.Cells(j + 2).Value) = True Then
    '                precio = JGr_Detalle.CurrentRow.Cells(j + 2).Value
    '            Else
    '                precio = 0
    '            End If
    '            L_PrecioProd_Grabar2(numi, codProd, catPrecio, catDesc, precio)
    '        Next
    '    Next

    '    ToastNotification.Show(Me, "Precios de " + JCb_CatProducto.Text + " Grabado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomRight)
    '    _PCargarDetalle(JCb_CatProducto.Value)
    'End Sub
    Private Sub _PSalirRegistro()
        Me.Close()
        _modulo.Select()
        _tab.Close()
    End Sub
    Private Sub _PAgregarFilasDetalle(cant As Integer)
        Dim newRow As GridEXRow
        Dim i As Integer
        For i = 1 To cant
            newRow = JGr_Detalle.AddItem()
        Next

    End Sub

    Private Sub P_prArmarComboCategoria()
        Dim Dt As DataTable
        Dt = L_fnObtenerCategoria()
        ''   Dt = L_fnObtenerLibreria("5", IIf(TipoForm = 1, "cenum>0", "cenum<0"))
        g_prArmarCombo(JCb_CatProducto, Dt, 60, 200, "Código", "Categoría")
    End Sub
    Private Sub _PCargarComboLibreria(ByVal cb As Janus.Windows.GridEX.EditControls.MultiColumnCombo, ByVal concep As Integer)
        Dim _Ds As New DataSet
        _Ds = L_General_LibreriaDetalle(-1, concep)

        With cb
            .DropDownList.Columns.Clear()

            .DropDownList.Columns.Add(_Ds.Tables(0).Columns("cenum").ToString).Width = 50
            .DropDownList.Columns(0).Caption = "Código"
            .DropDownList.Columns.Add(_Ds.Tables(0).Columns("cedesc").ToString).Width = 250
            .DropDownList.Columns(1).Caption = "Descripcion"

            .ValueMember = _Ds.Tables(0).Columns("cenum").ToString
            .DisplayMember = _Ds.Tables(0).Columns("cedesc").ToString
            .DataSource = _Ds.Tables(0)
            .Refresh()
        End With


    End Sub

    Private Sub _PCargarDetalle(idTipoProd As String)
        Dim dtProd, dtCatPrecios As New DataTable
        dtProd = L_Productos_GeneralFiltrado3(-1, "cacat= " + idTipoProd + "AND caest=1 AND caserie=0 AND cecon=103 AND cenum=cagr3")
        'dtCatPrecios = L_General_LibreriaDetalle(-1, 8).Tables(0)
        dtCatPrecios = L_CategoriaPrecioGeneral()

        'Cargar categoria de precios
        Dim i, j As Integer
        j = 2
        For i = 0 To dtCatPrecios.Rows.Count() - 1
            'aumentar columna al datatable de productos
            dtProd.Columns.Add(dtCatPrecios.Rows(i).Item("cicod"), Type.GetType("System.Double"))
        Next
        dtProd.Columns.Add("huboCambio", Type.GetType("System.Boolean"))
        dtProd.Columns.Add("listPrecio", Type.GetType("System.String"))


        'cargar datos de la tabla
        Dim dtPreciosProd As DataTable
        For i = 0 To dtProd.Rows.Count - 1
            Dim where As String = "chcprod='" + dtProd.Rows(i).Item("canumi").ToString + "'"
            dtPreciosProd = L_PrecioProd_GeneralConCatPrecio(-1, where).Tables(0)
            Dim listPrecio = String.Empty
            Dim k As Integer = 0
            For j = 0 To dtPreciosProd.Rows.Count - 1
                Dim catPrecio As String = dtPreciosProd.Rows(j).Item("cicod")
                Dim precio As Double = dtPreciosProd.Rows(j).Item("chprecio")
                dtProd.Rows(i).Item(catPrecio) = precio
                listPrecio += precio.ToString + "|"
            Next
            dtProd.Rows(i).Item("huboCambio") = False
            dtProd.Rows(i).Item("listPrecio") = listPrecio.Trim("|")
        Next

        JGr_Detalle.BoundMode = BoundMode.Bound
        JGr_Detalle.DataSource = dtProd
        JGr_Detalle.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Detalle.RootTable.Columns(0)
            .Caption = "Cod. Producto"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .CellStyle.BackColor = Color.AliceBlue
        End With

        With JGr_Detalle.RootTable.Columns(1)
            .Caption = "Codigo Flex"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .CellStyle.BackColor = Color.AliceBlue
        End With

        ''JGr_Detalle.RootTable.Columns.Add()
        With JGr_Detalle.RootTable.Columns(2)
            .Caption = "Descripcion"
            .Width = 350
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
        End With

        For i = 3 To JGr_Detalle.RootTable.Columns.Count - 1
            With JGr_Detalle.RootTable.Columns(i)
                .Width = 65
                .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                .CellStyle.FontSize = gi_fuenteTamano
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .FormatString = "0.00"
                .Visible = False
            End With
        Next

        With JGr_Detalle.RootTable.Columns("huboCambio")
            .Visible = False
        End With

        With JGr_Detalle.RootTable.Columns("listPrecio")
            .Visible = False
        End With
        With JGr_Detalle.RootTable.Columns(3)
            .Caption = "Familia"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .TextAlignment = TextAlignment.Near
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
            .Visible = True
        End With

        'Habilitar Filtradores
        With JGr_Detalle
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With


    End Sub

    'Private Sub _PCargarDetalle(idTipoProd As String)
    '    Dim dtProd, dtCatPrecios As New DataTable
    '    dtProd = L_Productos_GeneralFiltrado2(-1, "cacat= " + idTipoProd + "AND caest=1")
    '    dtCatPrecios = L_General_LibreriaDetalle(-1, 8).Tables(0)
    '    'dtCatPrecios=L_CategoriaPrecioGeneral()

    '    'mi codigo, cambio el modo de llenado de la tabla
    '    ''JGr_Detalle.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound

    '    'Iniciar las columnas
    '    ''JGr_Detalle.RootTable = New GridEXTable()
    '    ''JGr_Detalle.RootTable.Columns.Add()
    '    ''With JGr_Detalle.RootTable.Columns(0)
    '    ''    .Caption = "ID Producto"
    '    ''    .Width = 70
    '    ''    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '    ''    .CellStyle.FontSize = gi_fuenteTamano
    '    ''    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '    ''    .EditType = EditType.NoEdit
    '    ''    '.EmptyStringValue = ""
    '    ''End With

    '    '' ''JGr_Detalle.RootTable.Columns.Add()
    '    ''With JGr_Detalle.RootTable.Columns(1)
    '    ''    .Caption = "Descripcion"
    '    ''    .Width = 150
    '    ''    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '    ''    .CellStyle.FontSize = gi_fuenteTamano
    '    ''    .CellStyle.BackColor = Color.LightGray
    '    ''    .EditType = EditType.NoEdit
    '    ''    .AllowSort = False
    '    ''End With


    '    'Cargar categoria de precios
    '    Dim i, j As Integer
    '    j = 2
    '    For i = 0 To dtCatPrecios.Rows.Count() - 1
    '        ''JGr_Detalle.RootTable.Columns.Add()
    '        ''With JGr_Detalle.RootTable.Columns(j)
    '        ''    .Caption = dtCatPrecios.Rows(i).Item("cedesc")
    '        ''    .Width = 70
    '        ''    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '        ''    .CellStyle.FontSize = gi_fuenteTamano
    '        ''    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '        ''End With
    '        ''j = j + 1

    '        'aumentar columna al datatable de productos
    '        dtProd.Columns.Add(dtCatPrecios.Rows(i).Item("cedesc"))
    '    Next


    '    'cargar datos de la tabla
    '    Dim dtPreciosProd As DataTable
    '    For i = 0 To dtProd.Rows.Count - 1
    '        Dim where As String = "chcprod='" + dtProd.Rows(i).Item("cacod") + "'"
    '        dtPreciosProd = L_PrecioProd_GeneralConCatPrecio(-1, where).Tables(0)
    '        Dim k As Integer = 0
    '        For j = 0 To dtPreciosProd.Rows.Count - 1
    '            Dim catPrecio As String = dtPreciosProd.Rows(j).Item("cedesc")
    '            Dim precio As Integer = dtPreciosProd.Rows(j).Item("chprecio")
    '            dtProd.Rows(i).Item(catPrecio) = precio
    '        Next

    '    Next

    '    JGr_Detalle.BoundMode = BoundMode.Bound
    '    JGr_Detalle.DataSource = dtProd
    '    JGr_Detalle.RetrieveStructure()

    '    'dar formato a las columnas
    '    With JGr_Detalle.RootTable.Columns(0)
    '        .Caption = "ID Producto"
    '        .Width = 70
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '        .CellStyle.BackColor = Color.AliceBlue
    '    End With

    '    ''JGr_Detalle.RootTable.Columns.Add()
    '    With JGr_Detalle.RootTable.Columns(1)
    '        .Caption = "Descripcion"
    '        .Width = 150
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.BackColor = Color.AliceBlue
    '    End With

    '    'Habilitar Filtradores
    '    With JGr_Detalle
    '        .DefaultFilterRowComparison = FilterConditionOperator.Contains
    '        .FilterMode = FilterMode.Automatic
    '        .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
    '        .GroupByBoxVisible = False
    '        'diseño de la grilla
    '        .VisualStyle = VisualStyle.Office2007
    '    End With


    'End Sub

    'Private Sub _PCargarDetalle2(idTipoProd As String)
    '    Dim dtProd, dtCatPrecios As New DataTable
    '    dtProd = L_Productos_GeneralFiltrado2(-1, "cacat= " + idTipoProd + "AND caest=1")
    '    'dtCatPrecios = L_General_LibreriaDetalle(-1, 8).Tables(0)
    '    dtCatPrecios = L_CategoriaPrecioGeneral()

    '    'mi codigo, cambio el modo de llenado de la tabla
    '    ''JGr_Detalle.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound

    '    'Iniciar las columnas
    '    ''JGr_Detalle.RootTable = New GridEXTable()
    '    ''JGr_Detalle.RootTable.Columns.Add()
    '    ''With JGr_Detalle.RootTable.Columns(0)
    '    ''    .Caption = "ID Producto"
    '    ''    .Width = 70
    '    ''    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '    ''    .CellStyle.FontSize = gi_fuenteTamano
    '    ''    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '    ''    .EditType = EditType.NoEdit
    '    ''    '.EmptyStringValue = ""
    '    ''End With

    '    '' ''JGr_Detalle.RootTable.Columns.Add()
    '    ''With JGr_Detalle.RootTable.Columns(1)
    '    ''    .Caption = "Descripcion"
    '    ''    .Width = 150
    '    ''    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '    ''    .CellStyle.FontSize = gi_fuenteTamano
    '    ''    .CellStyle.BackColor = Color.LightGray
    '    ''    .EditType = EditType.NoEdit
    '    ''    .AllowSort = False
    '    ''End With


    '    'Cargar categoria de precios
    '    Dim i, j As Integer
    '    For i = 0 To dtCatPrecios.Rows.Count() - 1
    '        ''JGr_Detalle.RootTable.Columns.Add()
    '        ''With JGr_Detalle.RootTable.Columns(j)
    '        ''    .Caption = dtCatPrecios.Rows(i).Item("cedesc")
    '        ''    .Width = 70
    '        ''    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '        ''    .CellStyle.FontSize = gi_fuenteTamano
    '        ''    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '        ''End With
    '        ''j = j + 1

    '        'aumentar columna al datatable de productos
    '        dtProd.Columns.Add(dtCatPrecios.Rows(i).Item("chcatcl"))
    '    Next


    '    'cargar datos de la tabla
    '    Dim dtPreciosProd As DataTable
    '    For i = 0 To dtProd.Rows.Count - 1
    '        Dim where As String = "chcprod='" + dtProd.Rows(i).Item("cacod") + "'"
    '        dtPreciosProd = L_PrecioProd_GeneralConCatPrecio2(-1, where).Tables(0)
    '        Dim k As Integer = 0
    '        For j = 0 To dtPreciosProd.Rows.Count - 1
    '            Dim catPrecio As String = dtPreciosProd.Rows(j).Item("chcatcl")
    '            Dim precio As Integer = dtPreciosProd.Rows(j).Item("chprecio")
    '            dtProd.Rows(i).Item(catPrecio) = precio
    '        Next
    '    Next

    '    JGr_Detalle.BoundMode = BoundMode.Bound
    '    JGr_Detalle.DataSource = dtProd
    '    JGr_Detalle.RetrieveStructure()

    '    'dar formato a las columnas
    '    With JGr_Detalle.RootTable.Columns(0)
    '        .Caption = "Cod"
    '        .Width = 50
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '        .CellStyle.BackColor = Color.AliceBlue
    '    End With

    '    ''JGr_Detalle.RootTable.Columns.Add()
    '    With JGr_Detalle.RootTable.Columns(1)
    '        .Caption = "Descripcion"
    '        .Width = 150
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.BackColor = Color.AliceBlue
    '    End With

    '    For i = 2 To JGr_Detalle.RootTable.Columns.Count - 1
    '        With JGr_Detalle.RootTable.Columns(i)
    '            .Width = 50
    '            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '            .CellStyle.FontSize = gi_fuenteTamano
    '            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '        End With
    '    Next

    '    'Habilitar Filtradores
    '    With JGr_Detalle
    '        .DefaultFilterRowComparison = FilterConditionOperator.Contains
    '        .FilterMode = FilterMode.Automatic
    '        .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
    '        .GroupByBoxVisible = False
    '        'diseño de la grilla
    '        .VisualStyle = VisualStyle.Office2007
    '    End With


    'End Sub


    Private Sub _PCargarGridCategoriasPrecios(cod As String)

        dtPreciosDesc = L_fnMostrarDescuentosPrecios(cod)

        JGr_Descuentos.DataSource = dtPreciosDesc
        JGr_Descuentos.RetrieveStructure()

        With JGr_Descuentos.RootTable.Columns("danumi")
            .Visible = False
        End With
        With JGr_Descuentos.RootTable.Columns("dacanumi")
            .Caption = "Cod Prod."
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .CellStyle.BackColor = Color.AliceBlue
            .Visible = False
        End With
        With JGr_Descuentos.RootTable.Columns("dacant1")
            .Caption = "Desde"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
        End With
        With JGr_Descuentos.RootTable.Columns("dacant2")
            .Caption = "Hasta"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
        End With
        With JGr_Descuentos.RootTable.Columns("dapreciou")
            .Caption = "Precio"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        With JGr_Descuentos.RootTable.Columns("dafinicio")
            .Caption = "Fecha Inicio"
            .Width = 180
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
            .Visible = False
        End With
        With JGr_Descuentos.RootTable.Columns("daffin")
            .Caption = "Fecha Fin"
            .Width = 180
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
            .Visible = False
        End With
        With JGr_Descuentos.RootTable.Columns("estado")
            .Visible = False
        End With
        'Habilitar Filtradores
        With JGr_Descuentos
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            '.AllowEdit = InheritableBoolean.False
        End With


    End Sub

    'Private Sub _PCargarGridCategoriasPrecios2()
    '    Dim dtCatPrecios As New DataTable
    '    dtCatPrecios = L_CategoriaPrecioGeneral()

    '    JGr_Categorias.DataSource = dtCatPrecios
    '    JGr_Categorias.RetrieveStructure()

    '    'dar formato a las columnas
    '    With JGr_Categorias.RootTable.Columns("tam")
    '        .Visible = False
    '    End With
    '    With JGr_Categorias.RootTable.Columns("chcatcl")
    '        .Caption = "Cod"
    '        .Width = 50
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '        .CellStyle.BackColor = Color.AliceBlue
    '    End With

    '    ''JGr_Categorias.RootTable.Columns.Add()
    '    With JGr_Categorias.RootTable.Columns("chdesc")
    '        .Caption = "Descripcion"
    '        .Width = 150
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.BackColor = Color.AliceBlue
    '    End With

    '    'Habilitar Filtradores
    '    With JGr_Categorias
    '        .DefaultFilterRowComparison = FilterConditionOperator.Contains
    '        .FilterMode = FilterMode.Automatic
    '        .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
    '        .GroupByBoxVisible = False
    '        'diseño de la grilla
    '        .VisualStyle = VisualStyle.Office2007
    '    End With


    'End Sub


    Private Sub _PAdicionarCategoria()
        'Dim dtCatPrecios As DataTable
        'dtCatPrecios = L_CategoriaPrecioGeneral()
        'Dim sigCategoria = ""
        'If (dtCatPrecios.Rows.Count > 0) Then
        '    sigCategoria = _FSiguienteLetra(dtCatPrecios.Rows(dtCatPrecios.Rows.Count - 1).Item("cicod").ToString)
        'Else
        '    sigCategoria = "A"
        'End If
        'If sigCategoria = "" Then
        '    ToastNotification.Show(Me, "YA NO SE PUEDE INGRESAR CATEGORIA DE PRECIOS", My.Resources.WARNING, 5000, eToastGlowColor.Red, eToastPosition.BottomRight)
        'Else

        '    Dim catDesc As String = InputBox("INGRESE LA DESCRIPCION DE LA NUEVA CATEGORIA", "NUEVA CATEGORIA", "").ToUpper

        '    If (Not catDesc = String.Empty) Then
        '        Dim numi As String = ""
        '        L_CategoriaPrecioGrabar(numi, sigCategoria, catDesc, 1) 'Se agregó un campo mas citcv en la tabla TC007

        '        ToastNotification.Show(Me, "NUEVA CATEGORIA " + sigCategoria + " ADICIONADA CON EXITO", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomRight)
        '        _PCargarDetalle(JCb_CatProducto.Value)
        '        _PCargarGridCategoriasPrecios()
        '    End If
        'End If

    End Sub

    'Private Sub _PAdicionarCategoria()
    '    Dim dtCatPrecios As DataTable
    '    dtCatPrecios = L_CategoriaPrecioGeneral()
    '    Dim sigCategoria = _FSiguienteLetra(dtCatPrecios.Rows(dtCatPrecios.Rows.Count - 1).Item("cicod"))
    '    If sigCategoria = "" Then
    '        ToastNotification.Show(Me, "YA NO SE PUEDE INGRESAR CATEGORIA DE PRECIOS", My.Resources.WARNING, 5000, eToastGlowColor.Red, eToastPosition.BottomRight)
    '    Else
    '        Dim catDesc As String = InputBox("INGRESE LA DESCRIPCION DE LA NUEVA CATEGORIA", "NUEVA CATEGORIA", "")

    '        Dim dtProductos As DataTable = L_ProductosGeneral(0).Tables(0)
    '        For i = 0 To dtProductos.Rows.Count - 1
    '            Dim idProd As String = dtProductos.Rows(i).Item("canumi").ToString
    '            Dim numi As String = ""
    '            L_PrecioProd_Grabar2(numi, idProd, sigCategoria, catDesc, 0)
    '        Next

    '        ToastNotification.Show(Me, "NUEVA CATEGORIA " + sigCategoria + " ADICIONADA CON EXITO", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomRight)
    '        _PCargarDetalle(JCb_CatProducto.Value)
    '        _PCargarGridCategoriasPrecios()
    '    End If
    'End Sub


    Private Sub _Filtrar()
        _Dsencabezado = New DataSet
        _Dsencabezado = L_General_LibreriaDetalle(-1, 5)
        '_First = False
        If _Dsencabezado.Tables(0).Rows.Count <> 0 Then
            _Pos = 0
            _MostrarRegistro(_Pos)
            If _Dsencabezado.Tables(0).Rows.Count > 0 Then
                MBtPrimero.Visible = True
                MBtAnterior.Visible = True
                MBtSiguiente.Visible = True
                MBtUltimo.Visible = True
            End If
        End If

    End Sub
    Private Sub _MostrarRegistro(_N As Integer)
        JCb_CatProducto.SelectedIndex = _N
    End Sub
    Private Sub _PrimerRegistro()
        _Pos = 0
        _MostrarRegistro(_Pos)
        MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub
    Private Sub _AnteriorRegistro()
        If _Pos > 0 Then
            _Pos = _Pos - 1
            _MostrarRegistro(_Pos)
            MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub
    Private Sub _SiguienteRegistro()
        If _Pos < _Dsencabezado.Tables(0).Rows.Count - 1 Then
            _Pos = _Pos + 1
            _MostrarRegistro(_Pos)
            MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub
    Private Sub _UltimoRegistro()
        _Pos = _Dsencabezado.Tables(0).Rows.Count - 1
        _MostrarRegistro(_Pos)
        MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub
#End Region

    Private Sub P_PrecioProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub JCb_CatProducto_ValueChanged(sender As Object, e As EventArgs) Handles JCb_CatProducto.ValueChanged
        If JCb_CatProducto.SelectedIndex >= 0 Then
            _PCargarDetalle(JCb_CatProducto.Value)
        End If
    End Sub

    Private Sub JGr_Detalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles JGr_Detalle.KeyPress
        'If Char.IsDigit(e.KeyChar) = False Then
        '    e.Handled = True
        'End If

    End Sub

    Private Sub MBtPrimero_Click(sender As Object, e As EventArgs) Handles MBtPrimero.Click
        _PrimerRegistro()
    End Sub

    Private Sub MBtAnterior_Click(sender As Object, e As EventArgs) Handles MBtAnterior.Click
        _AnteriorRegistro()
    End Sub

    Private Sub MBtSiguiente_Click(sender As Object, e As EventArgs) Handles MBtSiguiente.Click
        _SiguienteRegistro()
    End Sub

    Private Sub MBtUltimo_Click(sender As Object, e As EventArgs) Handles MBtUltimo.Click
        _UltimoRegistro()
    End Sub

    Private Sub JGr_Detalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_Detalle.EditingCell
        If e.Column.Index = 0 Or e.Column.Index = 1 Or e.Column.Index = 2 Or e.Column.Index = 3 Then
            e.Cancel = True
        End If

        If modif = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        _PSalirRegistro()
    End Sub

    Private Sub MBtGrabar_Click(sender As Object, e As EventArgs) Handles MBtGrabar.Click
        _PGrabarRegistro()
    End Sub

    Private Sub MBtImprimir_Click(sender As Object, e As EventArgs) Handles MBtImprimir.Click
        Try
            Dim myppd As New PrintPreviewDialog
            GridEXPrintDocumentListaPrecios.PageHeaderCenter = "TIPO DE PRODUCTO : " + JCb_CatProducto.Text
            GridEXPrintDocumentListaPrecios.HeaderDistance = 75
            myppd.Document = GridEXPrintDocumentListaPrecios
            myppd.WindowState = FormWindowState.Maximized
            myppd.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btExportarExcel_Click(sender As Object, e As EventArgs) Handles btExportarExcel.Click
        Try
            Dim mysfd As New SaveFileDialog
            mysfd.Filter = "Archivos de Excel (*.xls)|*.xls| All Files (*.*)|*.*"
            mysfd.Title = "Guardar archivo Excel"
            If (mysfd.ShowDialog = DialogResult.OK) Then
                Dim exApp As New Microsoft.Office.Interop.Excel.Application
                Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
                Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

                GridEXExporterListaPrecio.SheetName = "P1" 'mysfd.FileName

                exLibro = exApp.Workbooks.Add
                exHoja = exLibro.Worksheets.Add()


                'Dim NCol As Integer = DGVdatos.ColumnCount
                'Dim NRow As Integer = DGVdatos.RowCount

                ''Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
                'For i As Integer = 1 To NCol
                '    exHoja.Cells.Item(1, i) = DGVdatos.Columns(i - 1).Name.ToString
                '    'exHoja.Cells.Item(1, i).HorizontalAlignment = 3


                'Next

                'For Fila As Integer = 0 To NRow - 1
                '    For Col As Integer = 0 To NCol - 1
                '        exHoja.Cells.Item(Fila + 2, Col + 1) = DGVdatos.Rows(Fila).Cells(Col).Value


                '    Next
                'Next
                'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
                exHoja.Rows.Item(1).Font.Bold = 1
                exHoja.Rows.Item(1).HorizontalAlignment = 3
                exHoja.Columns.AutoFit()
                exHoja.Columns.ColumnWidth = 14.14


                'Aplicación visible
                exApp.Application.Visible = True

                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing
                exLibro.SaveAs(mysfd.FileName)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub JGr_Detalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles JGr_Detalle.CellEdited
        Try
            If (Not IsNumeric(JGr_Detalle.CurrentRow.Cells(e.Column.Index).Value)) Then
                JGr_Detalle.CurrentRow.Cells(e.Column.Index).Value = 0
            End If

            Dim listPrecio = JGr_Detalle.CurrentRow.Cells("listPrecio").Value.ToString.Split("|")
            Dim valorActual = Convert.ToDecimal(JGr_Detalle.CurrentRow.Cells(e.Column.Index).Value)
            Dim valorInicial As Decimal = 0
            Try
                valorInicial = Convert.ToDecimal(listPrecio(e.Column.Index - 3))
            Catch
            End Try

            If (valorActual <> valorInicial) Then
                JGr_Detalle.CurrentRow.Cells("huboCambio").Value = True
            Else
                JGr_Detalle.CurrentRow.Cells("huboCambio").Value = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub JGr_Detalle_Click(sender As Object, e As EventArgs) Handles JGr_Detalle.Click


        If JGr_Detalle.Focused Then
                If JGr_Detalle.GetValue("canumi") > 0 Then
                    ' Dim CodPro As String = JGr_Detalle.CurrentRow.Cells("canumi").Value.ToString
                    tbCodPro.Text = JGr_Detalle.CurrentRow.Cells("canumi").Value.ToString
                    lbProducto.Text = JGr_Detalle.CurrentRow.Cells("cadesc").Value.ToString

                    _PCargarGridCategoriasPrecios(tbCodPro.Text)



                    'P_prAddFilaDetallePrecio()
                    'CType(JGr_Descuentos.DataSource, DataTable).Rows(0).Item("dacant1") = JGr_Detalle.CurrentRow.Cells("canumi").Value.ToString
                End If
            End If


    End Sub

    Private Sub btNuevoP_Click(sender As Object, e As EventArgs) Handles btNuevoP.Click
        If JGr_Descuentos.RowCount > 0 Then
            L_fnActualizarEstadoPrecios(tbCodPro.Text)
            _PCargarGridCategoriasPrecios(tbCodPro.Text)
        End If
        dtiFechaIni.Value = Now.Date
        dtiFechaFin.Value = Now.Date
        '_PCargarGridCategoriasPrecios(tbCodPro.Text)
        P_prAddFilaDetallePrecio()
    End Sub

    Private Sub JGr_Descuentos_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_Descuentos.EditingCell
        If (e.Column.Key.Equals("dacant1") Or e.Column.Key.Equals("dacant2") Or e.Column.Key.Equals("dapreciou")) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub P_prAddFilaDetallePrecio()
        Dim fil As DataRow
        fil = dtPreciosDesc.NewRow
        fil.Item("danumi") = 0
        fil.Item("dacanumi") = 0
        fil.Item("dacant1") = 0
        fil.Item("dacant2") = 0
        fil.Item("dapreciou") = 0.00
        fil.Item("dafinicio") = Now.Date
        fil.Item("daffin") = Now.Date
        fil.Item("estado") = 0

        dtPreciosDesc.Rows.Add(fil)
    End Sub

    Private Sub JGr_Descuentos_KeyDown(sender As Object, e As KeyEventArgs) Handles JGr_Descuentos.KeyDown
        If (e.KeyData = Keys.Enter And JGr_Descuentos.Col = JGr_Descuentos.RootTable.Columns("dapreciou").Index) Then
            Dim filIndex As Integer = JGr_Descuentos.Row
            If (filIndex = JGr_Descuentos.RowCount - 1) Then
                P_prAddFilaDetallePrecio()
            End If
        End If
    End Sub

    Private Sub btGrabarP_Click(sender As Object, e As EventArgs) Handles btGrabarP.Click
        Dim dt As DataTable = CType(JGr_Descuentos.DataSource, DataTable)
        Dim numi As String = ""
        If (_ValidarCampos()) Then

            'Grabar
            Dim res As Boolean = L_fnGrabarPreciosDescuentos(numi, tbCodPro.Text, dtiFechaIni.Value, dtiFechaFin.Value, CType(JGr_Descuentos.DataSource, DataTable))

            If (res) Then

                ToastNotification.Show(Me, "Descuento de Producto Grabado con éxito.".ToUpper,
                                   My.Resources.GRABACION_EXITOSA,
                                   3000,
                                   eToastGlowColor.Green,
                                   eToastPosition.TopCenter)
            Else
                ToastNotification.Show(Me, "No se pudo grabar los descuentos.".ToUpper,
                                   My.Resources.WARNING,
                                   3000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
            End If
        End If
    End Sub
    Public Function _ValidarCampos() As Boolean
        If (tbCodPro.Text <= 0) Then
            Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
            ToastNotification.Show(Me, "Por Favor debe dar click a un producto".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Return False
        End If

        'For Each aux In JGr_Descuentos.GetRows
        '    MessageBox.Show(aux.Cells(2).Value)
        '    'If Convert.ToInt32(aux.Cells(2)) <= 0 Then
        '    '    Dim img As Bitmap = New Bitmap(My.Resources.Mensaje, 50, 50)
        '    '    ToastNotification.Show(Me, "Las cantidades no pueden ser 0 por favor coloque las cantidades correctas".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        '    'End If

        'Next



        Return True
    End Function
End Class