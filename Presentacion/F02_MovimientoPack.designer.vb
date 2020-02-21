<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F02_MovimientoPack
    Inherits Modelo.ModeloF02_cd

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim cbConcepto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F02_MovimientoPack))
        Me.TableLayoutPanelPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupPanelDatosGenerales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelExDatosGenerales = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.btAddConcepto = New DevComponents.DotNetBar.ButtonX()
        Me.tbObs = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbConcepto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.dtiFechaDoc = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.tbCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanelDetalle = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgjDetalle = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanelBusqueda = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgjBusqueda = New Janus.Windows.GridEX.GridEX()
        Me.CmDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.tbProdPack = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbCodPack = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgjDesArmPack = New Janus.Windows.GridEX.GridEX()
        Me.tbCantArm = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.tbPcosto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.btnAsignarFicha = New DevComponents.DotNetBar.ButtonX()
        Me.tbCantDesarm = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSuperTabControlPrincipal.SuspendLayout()
        Me.MSuperTabControlPanelBusqueda.SuspendLayout()
        Me.MSuperTabControlPanelRegistro.SuspendLayout()
        Me.MPnSuperior.SuspendLayout()
        Me.MPnInferior.SuspendLayout()
        Me.MPanelToolBarUsuario.SuspendLayout()
        Me.MPanelToolBarNavegacion.SuspendLayout()
        Me.MPanelToolBarAccion.SuspendLayout()
        Me.MPanelToolBarImprimir.SuspendLayout()
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPnUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelPrincipal.SuspendLayout()
        Me.GroupPanelDatosGenerales.SuspendLayout()
        Me.PanelExDatosGenerales.SuspendLayout()
        CType(Me.cbConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiFechaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelDetalle.SuspendLayout()
        CType(Me.dgjDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelBusqueda.SuspendLayout()
        CType(Me.dgjBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmDetalle.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dgjDesArmPack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSuperTabControlPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.MSuperTabControlPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.MSuperTabControlPrincipal.ControlBox.MenuBox.Name = ""
        Me.MSuperTabControlPrincipal.ControlBox.Name = ""
        Me.MSuperTabControlPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MSuperTabControlPrincipal.ControlBox.MenuBox, Me.MSuperTabControlPrincipal.ControlBox.CloseBox})
        Me.MSuperTabControlPrincipal.SelectedTabIndex = 1
        Me.MSuperTabControlPrincipal.Size = New System.Drawing.Size(1318, 555)
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelBusqueda, 0)
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelRegistro, 0)
        '
        'MSuperTabControlPanelBusqueda
        '
        Me.MSuperTabControlPanelBusqueda.Controls.Add(Me.GroupPanelBusqueda)
        Me.MSuperTabControlPanelBusqueda.Size = New System.Drawing.Size(642, 455)
        '
        'MSuperTabControlPanelRegistro
        '
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.TableLayoutPanelPrincipal)
        Me.MSuperTabControlPanelRegistro.Size = New System.Drawing.Size(1276, 555)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.TableLayoutPanelPrincipal, 0)
        '
        'MPnSuperior
        '
        Me.MPnSuperior.Size = New System.Drawing.Size(1318, 70)
        Me.MPnSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnSuperior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnSuperior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnSuperior.Style.GradientAngle = 90
        '
        'MPnInferior
        '
        Me.MPnInferior.Location = New System.Drawing.Point(0, 625)
        Me.MPnInferior.Size = New System.Drawing.Size(1318, 36)
        Me.MPnInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnInferior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnInferior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MPnInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnInferior.Style.GradientAngle = 90
        '
        'MPanelToolBarUsuario
        '
        Me.MPanelToolBarUsuario.Location = New System.Drawing.Point(1118, 0)
        '
        'MTbUsuario
        '
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Text = "DEFAULT"
        '
        'MBtUltimo
        '
        '
        'MBtSiguiente
        '
        '
        'MBtAnterior
        '
        '
        'MBtPrimero
        '
        '
        'MBtSalir
        '
        '
        'MBtGrabar
        '
        '
        'MBtEliminar
        '
        '
        'MBtModificar
        '
        '
        'MBtNuevo
        '
        '
        'MPanelToolBarImprimir
        '
        Me.MPanelToolBarImprimir.Location = New System.Drawing.Point(1238, 0)
        '
        'MBubbleBarUsuario
        '
        '
        '
        '
        Me.MBubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.MBubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.MBubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'MLbPaginacion
        '
        '
        '
        '
        Me.MLbPaginacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'TableLayoutPanelPrincipal
        '
        Me.TableLayoutPanelPrincipal.ColumnCount = 1
        Me.TableLayoutPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.GroupPanel1, 0, 2)
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.GroupPanelDatosGenerales, 0, 0)
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.GroupPanelDetalle, 0, 1)
        Me.TableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelPrincipal.Name = "TableLayoutPanelPrincipal"
        Me.TableLayoutPanelPrincipal.RowCount = 3
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5!))
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5!))
        Me.TableLayoutPanelPrincipal.Size = New System.Drawing.Size(1276, 555)
        Me.TableLayoutPanelPrincipal.TabIndex = 29
        '
        'GroupPanelDatosGenerales
        '
        Me.GroupPanelDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelDatosGenerales.Controls.Add(Me.PanelExDatosGenerales)
        Me.GroupPanelDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelDatosGenerales.Location = New System.Drawing.Point(3, 3)
        Me.GroupPanelDatosGenerales.Name = "GroupPanelDatosGenerales"
        Me.GroupPanelDatosGenerales.Size = New System.Drawing.Size(1270, 188)
        '
        '
        '
        Me.GroupPanelDatosGenerales.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelDatosGenerales.Style.BackColorGradientAngle = 90
        Me.GroupPanelDatosGenerales.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelDatosGenerales.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderBottomWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelDatosGenerales.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderLeftWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderRightWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderTopWidth = 1
        Me.GroupPanelDatosGenerales.Style.CornerDiameter = 4
        Me.GroupPanelDatosGenerales.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelDatosGenerales.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelDatosGenerales.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelDatosGenerales.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelDatosGenerales.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelDatosGenerales.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelDatosGenerales.TabIndex = 0
        Me.GroupPanelDatosGenerales.Text = "DATOS GENERALES"
        '
        'PanelExDatosGenerales
        '
        Me.PanelExDatosGenerales.AutoScroll = True
        Me.PanelExDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelExDatosGenerales.Controls.Add(Me.tbCantDesarm)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX5)
        Me.PanelExDatosGenerales.Controls.Add(Me.btnAsignarFicha)
        Me.PanelExDatosGenerales.Controls.Add(Me.tbPcosto)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX9)
        Me.PanelExDatosGenerales.Controls.Add(Me.tbCantArm)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX8)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX7)
        Me.PanelExDatosGenerales.Controls.Add(Me.tbCodPack)
        Me.PanelExDatosGenerales.Controls.Add(Me.tbProdPack)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX6)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX4)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX3)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX2)
        Me.PanelExDatosGenerales.Controls.Add(Me.btAddConcepto)
        Me.PanelExDatosGenerales.Controls.Add(Me.tbObs)
        Me.PanelExDatosGenerales.Controls.Add(Me.cbConcepto)
        Me.PanelExDatosGenerales.Controls.Add(Me.dtiFechaDoc)
        Me.PanelExDatosGenerales.Controls.Add(Me.tbCodigo)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX1)
        Me.PanelExDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelExDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelExDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.PanelExDatosGenerales.Name = "PanelExDatosGenerales"
        Me.PanelExDatosGenerales.Size = New System.Drawing.Size(1264, 164)
        Me.PanelExDatosGenerales.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelExDatosGenerales.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelExDatosGenerales.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelExDatosGenerales.Style.GradientAngle = 90
        Me.PanelExDatosGenerales.TabIndex = 0
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.FontBold = True
        Me.LabelX4.Location = New System.Drawing.Point(6, 107)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(80, 23)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Concepto:"
        Me.LabelX4.Visible = False
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.FontBold = True
        Me.LabelX3.Location = New System.Drawing.Point(6, 61)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(90, 23)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "Observación:"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.FontBold = True
        Me.LabelX2.Location = New System.Drawing.Point(6, 32)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(80, 23)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Fecha:"
        '
        'btAddConcepto
        '
        Me.btAddConcepto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAddConcepto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAddConcepto.Location = New System.Drawing.Point(310, 107)
        Me.btAddConcepto.Name = "btAddConcepto"
        Me.btAddConcepto.Size = New System.Drawing.Size(40, 40)
        Me.btAddConcepto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAddConcepto.TabIndex = 4
        Me.btAddConcepto.Text = "+"
        '
        'tbObs
        '
        '
        '
        '
        Me.tbObs.Border.Class = "TextBoxBorder"
        Me.tbObs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbObs.Location = New System.Drawing.Point(102, 61)
        Me.tbObs.MaxLength = 40
        Me.tbObs.Multiline = True
        Me.tbObs.Name = "tbObs"
        Me.tbObs.PreventEnterBeep = True
        Me.tbObs.Size = New System.Drawing.Size(300, 40)
        Me.tbObs.TabIndex = 2
        '
        'cbConcepto
        '
        cbConcepto_DesignTimeLayout.LayoutString = resources.GetString("cbConcepto_DesignTimeLayout.LayoutString")
        Me.cbConcepto.DesignTimeLayout = cbConcepto_DesignTimeLayout
        Me.cbConcepto.Location = New System.Drawing.Point(102, 107)
        Me.cbConcepto.Name = "cbConcepto"
        Me.cbConcepto.SelectedIndex = -1
        Me.cbConcepto.SelectedItem = Nothing
        Me.cbConcepto.Size = New System.Drawing.Size(200, 23)
        Me.cbConcepto.TabIndex = 3
        Me.cbConcepto.Visible = False
        '
        'dtiFechaDoc
        '
        '
        '
        '
        Me.dtiFechaDoc.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiFechaDoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaDoc.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiFechaDoc.ButtonDropDown.Visible = True
        Me.dtiFechaDoc.IsPopupCalendarOpen = False
        Me.dtiFechaDoc.Location = New System.Drawing.Point(102, 32)
        '
        '
        '
        '
        '
        '
        Me.dtiFechaDoc.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaDoc.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiFechaDoc.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiFechaDoc.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiFechaDoc.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaDoc.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiFechaDoc.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiFechaDoc.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiFechaDoc.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiFechaDoc.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaDoc.MonthCalendar.DisplayMonth = New Date(2017, 7, 1, 0, 0, 0, 0)
        Me.dtiFechaDoc.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtiFechaDoc.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiFechaDoc.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaDoc.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiFechaDoc.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaDoc.MonthCalendar.TodayButtonVisible = True
        Me.dtiFechaDoc.Name = "dtiFechaDoc"
        Me.dtiFechaDoc.Size = New System.Drawing.Size(200, 23)
        Me.dtiFechaDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiFechaDoc.TabIndex = 1
        '
        'tbCodigo
        '
        '
        '
        '
        Me.tbCodigo.Border.Class = "TextBoxBorder"
        Me.tbCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigo.Location = New System.Drawing.Point(102, 3)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.PreventEnterBeep = True
        Me.tbCodigo.Size = New System.Drawing.Size(100, 23)
        Me.tbCodigo.TabIndex = 0
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.FontBold = True
        Me.LabelX1.Location = New System.Drawing.Point(6, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(80, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Código:"
        '
        'GroupPanelDetalle
        '
        Me.GroupPanelDetalle.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelDetalle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelDetalle.Controls.Add(Me.dgjDetalle)
        Me.GroupPanelDetalle.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelDetalle.Location = New System.Drawing.Point(3, 197)
        Me.GroupPanelDetalle.Name = "GroupPanelDetalle"
        Me.GroupPanelDetalle.Size = New System.Drawing.Size(1270, 174)
        '
        '
        '
        Me.GroupPanelDetalle.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelDetalle.Style.BackColorGradientAngle = 90
        Me.GroupPanelDetalle.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelDetalle.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDetalle.Style.BorderBottomWidth = 1
        Me.GroupPanelDetalle.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelDetalle.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDetalle.Style.BorderLeftWidth = 1
        Me.GroupPanelDetalle.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDetalle.Style.BorderRightWidth = 1
        Me.GroupPanelDetalle.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDetalle.Style.BorderTopWidth = 1
        Me.GroupPanelDetalle.Style.CornerDiameter = 4
        Me.GroupPanelDetalle.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelDetalle.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelDetalle.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelDetalle.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelDetalle.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelDetalle.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelDetalle.TabIndex = 1
        Me.GroupPanelDetalle.Text = "DETALLE MOVIMIENTO DE PACK"
        '
        'dgjDetalle
        '
        Me.dgjDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjDetalle.Location = New System.Drawing.Point(0, 0)
        Me.dgjDetalle.Name = "dgjDetalle"
        Me.dgjDetalle.Size = New System.Drawing.Size(1264, 150)
        Me.dgjDetalle.TabIndex = 0
        '
        'GroupPanelBusqueda
        '
        Me.GroupPanelBusqueda.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelBusqueda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelBusqueda.Controls.Add(Me.dgjBusqueda)
        Me.GroupPanelBusqueda.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelBusqueda.Name = "GroupPanelBusqueda"
        Me.GroupPanelBusqueda.Size = New System.Drawing.Size(642, 455)
        '
        '
        '
        Me.GroupPanelBusqueda.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelBusqueda.Style.BackColorGradientAngle = 90
        Me.GroupPanelBusqueda.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelBusqueda.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBusqueda.Style.BorderBottomWidth = 1
        Me.GroupPanelBusqueda.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelBusqueda.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBusqueda.Style.BorderLeftWidth = 1
        Me.GroupPanelBusqueda.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBusqueda.Style.BorderRightWidth = 1
        Me.GroupPanelBusqueda.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBusqueda.Style.BorderTopWidth = 1
        Me.GroupPanelBusqueda.Style.CornerDiameter = 4
        Me.GroupPanelBusqueda.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelBusqueda.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelBusqueda.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelBusqueda.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelBusqueda.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelBusqueda.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelBusqueda.TabIndex = 0
        Me.GroupPanelBusqueda.Text = "BUSQUEDA GENERAL"
        '
        'dgjBusqueda
        '
        Me.dgjBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.dgjBusqueda.Name = "dgjBusqueda"
        Me.dgjBusqueda.Size = New System.Drawing.Size(636, 431)
        Me.dgjBusqueda.TabIndex = 0
        '
        'CmDetalle
        '
        Me.CmDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarProductoToolStripMenuItem})
        Me.CmDetalle.Name = "CmDetalle"
        Me.CmDetalle.Size = New System.Drawing.Size(169, 36)
        '
        'QuitarProductoToolStripMenuItem
        '
        Me.QuitarProductoToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.eliminar
        Me.QuitarProductoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuitarProductoToolStripMenuItem.Name = "QuitarProductoToolStripMenuItem"
        Me.QuitarProductoToolStripMenuItem.Size = New System.Drawing.Size(168, 32)
        Me.QuitarProductoToolStripMenuItem.Text = "Quitar Producto"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.FontBold = True
        Me.LabelX6.Location = New System.Drawing.Point(472, 15)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(49, 23)
        Me.LabelX6.TabIndex = 218
        Me.LabelX6.Text = "Pack:"
        '
        'tbProdPack
        '
        '
        '
        '
        Me.tbProdPack.Border.Class = "TextBoxBorder"
        Me.tbProdPack.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbProdPack.Location = New System.Drawing.Point(616, 16)
        Me.tbProdPack.MaxLength = 15
        Me.tbProdPack.Name = "tbProdPack"
        Me.tbProdPack.Size = New System.Drawing.Size(200, 23)
        Me.tbProdPack.TabIndex = 219
        '
        'tbCodPack
        '
        '
        '
        '
        Me.tbCodPack.Border.Class = "TextBoxBorder"
        Me.tbCodPack.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodPack.Location = New System.Drawing.Point(543, 16)
        Me.tbCodPack.MaxLength = 15
        Me.tbCodPack.Name = "tbCodPack"
        Me.tbCodPack.Size = New System.Drawing.Size(66, 23)
        Me.tbCodPack.TabIndex = 220
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(543, 3)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(51, 10)
        Me.LabelX7.TabIndex = 221
        Me.LabelX7.Text = "Ctrl+Enter:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.dgjDesArmPack)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 377)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1270, 175)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "DETALLE MOVIMIENTO DE DESARMADO DE PACK"
        '
        'dgjDesArmPack
        '
        Me.dgjDesArmPack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjDesArmPack.Location = New System.Drawing.Point(0, 0)
        Me.dgjDesArmPack.Name = "dgjDesArmPack"
        Me.dgjDesArmPack.Size = New System.Drawing.Size(1264, 151)
        Me.dgjDesArmPack.TabIndex = 0
        '
        'tbCantArm
        '
        '
        '
        '
        Me.tbCantArm.Border.Class = "TextBoxBorder"
        Me.tbCantArm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCantArm.Location = New System.Drawing.Point(543, 45)
        Me.tbCantArm.MaxLength = 15
        Me.tbCantArm.Name = "tbCantArm"
        Me.tbCantArm.Size = New System.Drawing.Size(66, 23)
        Me.tbCantArm.TabIndex = 223
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.FontBold = True
        Me.LabelX8.Location = New System.Drawing.Point(472, 44)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(65, 23)
        Me.LabelX8.TabIndex = 222
        Me.LabelX8.Text = "Cantidad:"
        '
        'tbPcosto
        '
        '
        '
        '
        Me.tbPcosto.Border.Class = "TextBoxBorder"
        Me.tbPcosto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbPcosto.Location = New System.Drawing.Point(543, 74)
        Me.tbPcosto.MaxLength = 15
        Me.tbPcosto.Name = "tbPcosto"
        Me.tbPcosto.Size = New System.Drawing.Size(66, 23)
        Me.tbPcosto.TabIndex = 225
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.FontBold = True
        Me.LabelX9.Location = New System.Drawing.Point(472, 73)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(65, 23)
        Me.LabelX9.TabIndex = 224
        Me.LabelX9.Text = "P. Costo:"
        '
        'btnAsignarFicha
        '
        Me.btnAsignarFicha.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAsignarFicha.BackColor = System.Drawing.Color.White
        Me.btnAsignarFicha.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAsignarFicha.FadeEffect = False
        Me.btnAsignarFicha.FocusCuesEnabled = False
        Me.btnAsignarFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignarFicha.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnAsignarFicha.Location = New System.Drawing.Point(971, 13)
        Me.btnAsignarFicha.Name = "btnAsignarFicha"
        Me.btnAsignarFicha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAsignarFicha.Size = New System.Drawing.Size(166, 30)
        Me.btnAsignarFicha.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAsignarFicha.TabIndex = 262
        Me.btnAsignarFicha.Text = "DESARMAR    PACK"
        '
        'tbCantDesarm
        '
        '
        '
        '
        Me.tbCantDesarm.Border.Class = "TextBoxBorder"
        Me.tbCantDesarm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCantDesarm.Location = New System.Drawing.Point(1040, 59)
        Me.tbCantDesarm.MaxLength = 15
        Me.tbCantDesarm.Name = "tbCantDesarm"
        Me.tbCantDesarm.Size = New System.Drawing.Size(97, 23)
        Me.tbCantDesarm.TabIndex = 264
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.FontBold = True
        Me.LabelX5.Location = New System.Drawing.Point(971, 59)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(60, 23)
        Me.LabelX5.TabIndex = 263
        Me.LabelX5.Text = "Cantidad:"
        '
        'F02_MovimientoPack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 661)
        Me.Name = "F02_MovimientoPack"
        Me.Text = "F02_Movimiento"
        Me.Controls.SetChildIndex(Me.MPnSuperior, 0)
        Me.Controls.SetChildIndex(Me.MPnInferior, 0)
        Me.Controls.SetChildIndex(Me.MSuperTabControlPrincipal, 0)
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSuperTabControlPrincipal.ResumeLayout(False)
        Me.MSuperTabControlPanelBusqueda.ResumeLayout(False)
        Me.MSuperTabControlPanelRegistro.ResumeLayout(False)
        Me.MPnSuperior.ResumeLayout(False)
        Me.MPnInferior.ResumeLayout(False)
        Me.MPanelToolBarUsuario.ResumeLayout(False)
        Me.MPanelToolBarUsuario.PerformLayout()
        Me.MPanelToolBarNavegacion.ResumeLayout(False)
        Me.MPanelToolBarAccion.ResumeLayout(False)
        Me.MPanelToolBarImprimir.ResumeLayout(False)
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MPnUsuario.ResumeLayout(False)
        Me.MPnUsuario.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelPrincipal.ResumeLayout(False)
        Me.GroupPanelDatosGenerales.ResumeLayout(False)
        Me.PanelExDatosGenerales.ResumeLayout(False)
        Me.PanelExDatosGenerales.PerformLayout()
        CType(Me.cbConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiFechaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelDetalle.ResumeLayout(False)
        CType(Me.dgjDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelBusqueda.ResumeLayout(False)
        CType(Me.dgjBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmDetalle.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dgjDesArmPack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanelBusqueda As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanelPrincipal As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupPanelDatosGenerales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelExDatosGenerales As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanelDetalle As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dgjDetalle As Janus.Windows.GridEX.GridEX
    Friend WithEvents dgjBusqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btAddConcepto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbObs As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbConcepto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents dtiFechaDoc As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbCodPack As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbProdPack As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dgjDesArmPack As Janus.Windows.GridEX.GridEX
    Friend WithEvents tbPcosto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbCantArm As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAsignarFicha As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbCantDesarm As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
End Class
