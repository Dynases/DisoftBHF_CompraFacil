<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F0_AsignacionZonaAlternativo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gPanelVendedor = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SuperTabControl2 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.dgjPrevendedor = New Janus.Windows.GridEX.GridEX()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.gPanelRepartidor = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.dgjRepartidor = New Janus.Windows.GridEX.GridEX()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.GroupPanelPersonal = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SuperTabControlPersonal = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.DgjBusqueda = New Janus.Windows.GridEX.GridEX()
        Me.SuperTabItemRepartidor = New DevComponents.DotNetBar.SuperTabItem()
        Me.TbCodigo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gPanelVendedor.SuspendLayout()
        CType(Me.SuperTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl2.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me.dgjPrevendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gPanelRepartidor.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.dgjRepartidor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelPersonal.SuspendLayout()
        CType(Me.SuperTabControlPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPersonal.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.DgjBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Presentacion.My.Resources.Resources.fondo11
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 87)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.gPanelVendedor, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gPanelRepartidor, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanelPersonal, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 87)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(959, 488)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'gPanelVendedor
        '
        Me.gPanelVendedor.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanelVendedor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanelVendedor.Controls.Add(Me.SuperTabControl2)
        Me.gPanelVendedor.DisabledBackColor = System.Drawing.Color.Empty
        Me.gPanelVendedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gPanelVendedor.Location = New System.Drawing.Point(642, 4)
        Me.gPanelVendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.gPanelVendedor.Name = "gPanelVendedor"
        Me.gPanelVendedor.Size = New System.Drawing.Size(313, 480)
        '
        '
        '
        Me.gPanelVendedor.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gPanelVendedor.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gPanelVendedor.Style.BackColorGradientAngle = 90
        Me.gPanelVendedor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanelVendedor.Style.BorderBottomWidth = 1
        Me.gPanelVendedor.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gPanelVendedor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanelVendedor.Style.BorderLeftWidth = 1
        Me.gPanelVendedor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanelVendedor.Style.BorderRightWidth = 1
        Me.gPanelVendedor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanelVendedor.Style.BorderTopWidth = 1
        Me.gPanelVendedor.Style.CornerDiameter = 4
        Me.gPanelVendedor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gPanelVendedor.Style.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gPanelVendedor.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gPanelVendedor.Style.TextColor = System.Drawing.Color.White
        Me.gPanelVendedor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gPanelVendedor.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gPanelVendedor.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gPanelVendedor.TabIndex = 5
        Me.gPanelVendedor.Text = "Vendedores Asignados"
        '
        'SuperTabControl2
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl2.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl2.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl2.ControlBox.Name = ""
        Me.SuperTabControl2.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl2.ControlBox.MenuBox, Me.SuperTabControl2.ControlBox.CloseBox})
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControl2.Name = "SuperTabControl2"
        Me.SuperTabControl2.ReorderTabsEnabled = True
        Me.SuperTabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl2.SelectedTabIndex = 1
        Me.SuperTabControl2.Size = New System.Drawing.Size(307, 451)
        Me.SuperTabControl2.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl2.TabIndex = 118
        Me.SuperTabControl2.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem2})
        Me.SuperTabControl2.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl2.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.dgjPrevendedor)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 26)
        Me.SuperTabControlPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(307, 425)
        Me.SuperTabControlPanel3.TabIndex = 1
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem2
        '
        'dgjPrevendedor
        '
        Me.dgjPrevendedor.ColumnAutoResize = True
        Me.dgjPrevendedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjPrevendedor.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgjPrevendedor.Location = New System.Drawing.Point(0, 0)
        Me.dgjPrevendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgjPrevendedor.Name = "dgjPrevendedor"
        Me.dgjPrevendedor.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.dgjPrevendedor.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.dgjPrevendedor.RowHeaderFormatStyle.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgjPrevendedor.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.dgjPrevendedor.Size = New System.Drawing.Size(307, 425)
        Me.dgjPrevendedor.TabIndex = 117
        Me.dgjPrevendedor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Listado Vendedores"
        '
        'gPanelRepartidor
        '
        Me.gPanelRepartidor.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanelRepartidor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanelRepartidor.Controls.Add(Me.SuperTabControl1)
        Me.gPanelRepartidor.DisabledBackColor = System.Drawing.Color.Empty
        Me.gPanelRepartidor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gPanelRepartidor.Location = New System.Drawing.Point(323, 4)
        Me.gPanelRepartidor.Margin = New System.Windows.Forms.Padding(4)
        Me.gPanelRepartidor.Name = "gPanelRepartidor"
        Me.gPanelRepartidor.Size = New System.Drawing.Size(311, 480)
        '
        '
        '
        Me.gPanelRepartidor.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gPanelRepartidor.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gPanelRepartidor.Style.BackColorGradientAngle = 90
        Me.gPanelRepartidor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanelRepartidor.Style.BorderBottomWidth = 1
        Me.gPanelRepartidor.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gPanelRepartidor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanelRepartidor.Style.BorderLeftWidth = 1
        Me.gPanelRepartidor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanelRepartidor.Style.BorderRightWidth = 1
        Me.gPanelRepartidor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanelRepartidor.Style.BorderTopWidth = 1
        Me.gPanelRepartidor.Style.CornerDiameter = 4
        Me.gPanelRepartidor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gPanelRepartidor.Style.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gPanelRepartidor.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gPanelRepartidor.Style.TextColor = System.Drawing.Color.White
        Me.gPanelRepartidor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gPanelRepartidor.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gPanelRepartidor.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gPanelRepartidor.TabIndex = 4
        Me.gPanelRepartidor.Text = "Repartidores Asignados"
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 1
        Me.SuperTabControl1.Size = New System.Drawing.Size(305, 451)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 118
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.dgjRepartidor)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(305, 425)
        Me.SuperTabControlPanel2.TabIndex = 1
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem1
        '
        'dgjRepartidor
        '
        Me.dgjRepartidor.ColumnAutoResize = True
        Me.dgjRepartidor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjRepartidor.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgjRepartidor.Location = New System.Drawing.Point(0, 0)
        Me.dgjRepartidor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgjRepartidor.Name = "dgjRepartidor"
        Me.dgjRepartidor.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.dgjRepartidor.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.dgjRepartidor.RowHeaderFormatStyle.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgjRepartidor.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.dgjRepartidor.Size = New System.Drawing.Size(305, 425)
        Me.dgjRepartidor.TabIndex = 117
        Me.dgjRepartidor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Listado Repartidores"
        '
        'GroupPanelPersonal
        '
        Me.GroupPanelPersonal.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelPersonal.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelPersonal.Controls.Add(Me.SuperTabControlPersonal)
        Me.GroupPanelPersonal.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelPersonal.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanelPersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanelPersonal.Name = "GroupPanelPersonal"
        Me.GroupPanelPersonal.Size = New System.Drawing.Size(311, 480)
        '
        '
        '
        Me.GroupPanelPersonal.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelPersonal.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelPersonal.Style.BackColorGradientAngle = 90
        Me.GroupPanelPersonal.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPersonal.Style.BorderBottomWidth = 1
        Me.GroupPanelPersonal.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelPersonal.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPersonal.Style.BorderLeftWidth = 1
        Me.GroupPanelPersonal.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPersonal.Style.BorderRightWidth = 1
        Me.GroupPanelPersonal.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPersonal.Style.BorderTopWidth = 1
        Me.GroupPanelPersonal.Style.CornerDiameter = 4
        Me.GroupPanelPersonal.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelPersonal.Style.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelPersonal.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelPersonal.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanelPersonal.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelPersonal.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelPersonal.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelPersonal.TabIndex = 3
        Me.GroupPanelPersonal.Text = "Zonas"
        '
        'SuperTabControlPersonal
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControlPersonal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControlPersonal.ControlBox.MenuBox.Name = ""
        Me.SuperTabControlPersonal.ControlBox.Name = ""
        Me.SuperTabControlPersonal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControlPersonal.ControlBox.MenuBox, Me.SuperTabControlPersonal.ControlBox.CloseBox})
        Me.SuperTabControlPersonal.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControlPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPersonal.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPersonal.Name = "SuperTabControlPersonal"
        Me.SuperTabControlPersonal.ReorderTabsEnabled = True
        Me.SuperTabControlPersonal.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControlPersonal.SelectedTabIndex = 1
        Me.SuperTabControlPersonal.Size = New System.Drawing.Size(305, 451)
        Me.SuperTabControlPersonal.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControlPersonal.TabIndex = 118
        Me.SuperTabControlPersonal.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItemRepartidor})
        Me.SuperTabControlPersonal.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControlPersonal.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.DgjBusqueda)
        Me.SuperTabControlPanel1.Controls.Add(Me.TbCodigo)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(305, 425)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItemRepartidor
        '
        'DgjBusqueda
        '
        Me.DgjBusqueda.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.DgjBusqueda.ColumnAutoResize = True
        Me.DgjBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgjBusqueda.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.DgjBusqueda.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgjBusqueda.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.DgjBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.DgjBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.DgjBusqueda.Name = "DgjBusqueda"
        Me.DgjBusqueda.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.DgjBusqueda.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.DgjBusqueda.RowFormatStyle.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgjBusqueda.RowHeaderFormatStyle.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgjBusqueda.RowHeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.DgjBusqueda.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.DgjBusqueda.SelectedFormatStyle.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgjBusqueda.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.DgjBusqueda.Size = New System.Drawing.Size(305, 425)
        Me.DgjBusqueda.TabIndex = 117
        Me.DgjBusqueda.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SuperTabItemRepartidor
        '
        Me.SuperTabItemRepartidor.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItemRepartidor.GlobalItem = False
        Me.SuperTabItemRepartidor.Name = "SuperTabItemRepartidor"
        Me.SuperTabItemRepartidor.Text = "Listado Zonas"
        '
        'TbCodigo
        '
        Me.TbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCodigo.Location = New System.Drawing.Point(77, 78)
        Me.TbCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.Size = New System.Drawing.Size(132, 26)
        Me.TbCodigo.TabIndex = 116
        Me.TbCodigo.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ButtonX1)
        Me.Panel2.Controls.Add(Me.ButtonX2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(591, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 87)
        Me.Panel2.TabIndex = 117
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.ButtonX1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.Presentacion.My.Resources.Resources.save
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.ButtonX1.Location = New System.Drawing.Point(74, 0)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(147, 87)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Guardar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.ButtonX2.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.Presentacion.My.Resources.Resources.atras
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.ButtonX2.Location = New System.Drawing.Point(221, 0)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(147, 87)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX2.TabIndex = 1
        Me.ButtonX2.Text = "Salir"
        '
        'F0_AsignacionZonaAlternativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 575)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F0_AsignacionZonaAlternativo"
        Me.Text = "F0_AsignacionZonaAlternativo"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gPanelVendedor.ResumeLayout(False)
        CType(Me.SuperTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl2.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        CType(Me.dgjPrevendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gPanelRepartidor.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me.dgjRepartidor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelPersonal.ResumeLayout(False)
        CType(Me.SuperTabControlPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPersonal.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel1.PerformLayout()
        CType(Me.DgjBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents gPanelVendedor As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SuperTabControl2 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents dgjPrevendedor As Janus.Windows.GridEX.GridEX
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents gPanelRepartidor As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents dgjRepartidor As Janus.Windows.GridEX.GridEX
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents GroupPanelPersonal As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SuperTabControlPersonal As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents DgjBusqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents SuperTabItemRepartidor As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents TbCodigo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
