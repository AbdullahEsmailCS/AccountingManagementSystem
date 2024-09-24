<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_REP_ACCOUNT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DGV_JOB = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TXT_GUID_ACCOUNT = New System.Windows.Forms.TextBox()
        Me.TXT_NAME_ACCOUNT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TXT_GUID_CURRENCY = New System.Windows.Forms.TextBox()
        Me.TXT_CURRENCY = New System.Windows.Forms.TextBox()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.TXT_CURRENCY_VAL = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.جديدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.DGV_JOB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.DTP2)
        Me.GroupPanel1.Controls.Add(Me.DTP1)
        Me.GroupPanel1.Controls.Add(Me.Button3)
        Me.GroupPanel1.Controls.Add(Me.Button2)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel4)
        Me.GroupPanel1.Controls.Add(Me.TXT_GUID_ACCOUNT)
        Me.GroupPanel1.Controls.Add(Me.TXT_NAME_ACCOUNT)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.TXT_GUID_CURRENCY)
        Me.GroupPanel1.Controls.Add(Me.TXT_CURRENCY)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.TXT_CURRENCY_VAL)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.StatusStrip1)
        Me.GroupPanel1.Controls.Add(Me.MenuStrip1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(362, 383)
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
        Me.GroupPanel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Image = Global.ACC_TEST.My.Resources.Resources.search
        Me.Button3.Location = New System.Drawing.Point(30, 141)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 23)
        Me.Button3.TabIndex = 876
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.ACC_TEST.My.Resources.Resources.search
        Me.Button2.Location = New System.Drawing.Point(30, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 23)
        Me.Button2.TabIndex = 875
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.DGV_JOB)
        Me.GroupPanel4.Location = New System.Drawing.Point(3, 178)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(343, 171)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel4.TabIndex = 82
        Me.GroupPanel4.Text = "مراكز الكلفة"
        '
        'DGV_JOB
        '
        Me.DGV_JOB.AllowUserToAddRows = False
        Me.DGV_JOB.BackgroundColor = System.Drawing.Color.White
        Me.DGV_JOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_JOB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGV_JOB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_JOB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn2})
        Me.DGV_JOB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_JOB.Location = New System.Drawing.Point(0, 0)
        Me.DGV_JOB.Name = "DGV_JOB"
        Me.DGV_JOB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGV_JOB.RowHeadersVisible = False
        Me.DGV_JOB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_JOB.Size = New System.Drawing.Size(337, 148)
        Me.DGV_JOB.TabIndex = 968
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Guid"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "مركز كلفة"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DataGridViewCheckBoxColumn2.HeaderText = "تحديد"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn2.Width = 50
        '
        'TXT_GUID_ACCOUNT
        '
        Me.TXT_GUID_ACCOUNT.Location = New System.Drawing.Point(302, 152)
        Me.TXT_GUID_ACCOUNT.Name = "TXT_GUID_ACCOUNT"
        Me.TXT_GUID_ACCOUNT.Size = New System.Drawing.Size(52, 20)
        Me.TXT_GUID_ACCOUNT.TabIndex = 81
        Me.TXT_GUID_ACCOUNT.Visible = False
        '
        'TXT_NAME_ACCOUNT
        '
        Me.TXT_NAME_ACCOUNT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.TXT_NAME_ACCOUNT.Border.Class = "TextBoxBorder"
        Me.TXT_NAME_ACCOUNT.Location = New System.Drawing.Point(62, 144)
        Me.TXT_NAME_ACCOUNT.Name = "TXT_NAME_ACCOUNT"
        Me.TXT_NAME_ACCOUNT.Size = New System.Drawing.Size(221, 20)
        Me.TXT_NAME_ACCOUNT.TabIndex = 80
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Location = New System.Drawing.Point(291, 141)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(88, 23)
        Me.LabelX6.TabIndex = 77
        Me.LabelX6.Text = "اسم الحساب"
        '
        'TXT_GUID_CURRENCY
        '
        Me.TXT_GUID_CURRENCY.Location = New System.Drawing.Point(315, 90)
        Me.TXT_GUID_CURRENCY.Name = "TXT_GUID_CURRENCY"
        Me.TXT_GUID_CURRENCY.Size = New System.Drawing.Size(31, 20)
        Me.TXT_GUID_CURRENCY.TabIndex = 76
        Me.TXT_GUID_CURRENCY.Visible = False
        '
        'TXT_CURRENCY
        '
        Me.TXT_CURRENCY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXT_CURRENCY.Location = New System.Drawing.Point(62, 89)
        Me.TXT_CURRENCY.Name = "TXT_CURRENCY"
        Me.TXT_CURRENCY.Size = New System.Drawing.Size(221, 20)
        Me.TXT_CURRENCY.TabIndex = 75
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        Me.LabelX8.Location = New System.Drawing.Point(289, 116)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 23)
        Me.LabelX8.TabIndex = 74
        Me.LabelX8.Text = "سعر التعادل"
        '
        'TXT_CURRENCY_VAL
        '
        Me.TXT_CURRENCY_VAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.TXT_CURRENCY_VAL.Border.Class = "TextBoxBorder"
        Me.TXT_CURRENCY_VAL.Location = New System.Drawing.Point(62, 116)
        Me.TXT_CURRENCY_VAL.Name = "TXT_CURRENCY_VAL"
        Me.TXT_CURRENCY_VAL.Size = New System.Drawing.Size(221, 20)
        Me.TXT_CURRENCY_VAL.TabIndex = 73
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(289, 87)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(65, 23)
        Me.LabelX7.TabIndex = 71
        Me.LabelX7.Text = "العملة"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(289, 60)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 66
        Me.LabelX2.Text = "الى تاريخ"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(289, 34)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 64
        Me.LabelX1.Text = "من تاريخ"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 355)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(356, 22)
        Me.StatusStrip1.TabIndex = 62
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.جديدToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(356, 24)
        Me.MenuStrip1.TabIndex = 61
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'جديدToolStripMenuItem
        '
        Me.جديدToolStripMenuItem.Image = Global.ACC_TEST.My.Resources.Resources.document_quickprint
        Me.جديدToolStripMenuItem.Name = "جديدToolStripMenuItem"
        Me.جديدToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.جديدToolStripMenuItem.Text = "بحث"
        '
        'DTP1
        '
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(62, 33)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(221, 20)
        Me.DTP1.TabIndex = 877
        '
        'DTP2
        '
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP2.Location = New System.Drawing.Point(62, 63)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(221, 20)
        Me.DTP2.TabIndex = 878
        '
        'FRM_REP_ACCOUNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 383)
        Me.Controls.Add(Me.GroupPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_REP_ACCOUNT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "كشف حساب"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.DGV_JOB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents جديدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TXT_GUID_CURRENCY As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CURRENCY As System.Windows.Forms.TextBox
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_CURRENCY_VAL As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_NAME_ACCOUNT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_GUID_ACCOUNT As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DGV_JOB As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
End Class
