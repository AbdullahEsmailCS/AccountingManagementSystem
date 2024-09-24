<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ALL_ITEME_POS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Group_itemeamer = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX21 = New DevComponents.DotNetBar.ButtonX()
        Me.TXT_SEARSH = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.guid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEME_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.it = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.M_Whole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_Half = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_EndUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_Vendor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_Export = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_Retail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_LastPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Group_itemeamer.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group_itemeamer
        '
        Me.Group_itemeamer.AutoScroll = True
        Me.Group_itemeamer.CanvasColor = System.Drawing.SystemColors.Control
        Me.Group_itemeamer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Group_itemeamer.Controls.Add(Me.ButtonX21)
        Me.Group_itemeamer.Controls.Add(Me.TXT_SEARSH)
        Me.Group_itemeamer.Dock = System.Windows.Forms.DockStyle.Top
        Me.Group_itemeamer.Location = New System.Drawing.Point(0, 0)
        Me.Group_itemeamer.Name = "Group_itemeamer"
        Me.Group_itemeamer.Size = New System.Drawing.Size(678, 63)
        '
        '
        '
        Me.Group_itemeamer.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Group_itemeamer.Style.BackColorGradientAngle = 90
        Me.Group_itemeamer.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Group_itemeamer.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Group_itemeamer.Style.BorderBottomWidth = 1
        Me.Group_itemeamer.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Group_itemeamer.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Group_itemeamer.Style.BorderLeftWidth = 1
        Me.Group_itemeamer.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Group_itemeamer.Style.BorderRightWidth = 1
        Me.Group_itemeamer.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Group_itemeamer.Style.BorderTopWidth = 1
        Me.Group_itemeamer.Style.CornerDiameter = 4
        Me.Group_itemeamer.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Group_itemeamer.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Group_itemeamer.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Group_itemeamer.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.Group_itemeamer.TabIndex = 3
        '
        'ButtonX21
        '
        Me.ButtonX21.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX21.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX21.Checked = True
        Me.ButtonX21.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX21.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonX21.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX21.Location = New System.Drawing.Point(0, 0)
        Me.ButtonX21.Name = "ButtonX21"
        Me.ButtonX21.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.ButtonX21.Size = New System.Drawing.Size(158, 57)
        Me.ButtonX21.TabIndex = 32
        Me.ButtonX21.Text = "خروج"
        '
        'TXT_SEARSH
        '
        Me.TXT_SEARSH.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SEARSH.Location = New System.Drawing.Point(191, 9)
        Me.TXT_SEARSH.Multiline = True
        Me.TXT_SEARSH.Name = "TXT_SEARSH"
        Me.TXT_SEARSH.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_SEARSH.Size = New System.Drawing.Size(451, 37)
        Me.TXT_SEARSH.TabIndex = 0
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.guid, Me.barcode1, Me.ITEME_name, Me.unit1, Me.balance, Me.it, Me.M_Whole, Me.M_Half, Me.M_EndUser, Me.M_Vendor, Me.M_Export, Me.M_Retail, Me.M_LastPrice})
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(0, 63)
        Me.DGV.Name = "DGV"
        Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.RowTemplate.Height = 80
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(678, 260)
        Me.DGV.TabIndex = 4
        '
        'guid
        '
        Me.guid.FillWeight = 89.54314!
        Me.guid.HeaderText = "guid"
        Me.guid.Name = "guid"
        Me.guid.Visible = False
        Me.guid.Width = 101
        '
        'barcode1
        '
        Me.barcode1.FillWeight = 89.54314!
        Me.barcode1.HeaderText = "باركود وحدة1"
        Me.barcode1.Name = "barcode1"
        Me.barcode1.ReadOnly = True
        '
        'ITEME_name
        '
        Me.ITEME_name.FillWeight = 89.54314!
        Me.ITEME_name.HeaderText = "اسم المادة"
        Me.ITEME_name.Name = "ITEME_name"
        Me.ITEME_name.ReadOnly = True
        Me.ITEME_name.Width = 250
        '
        'unit1
        '
        Me.unit1.FillWeight = 89.54314!
        Me.unit1.HeaderText = "الوحدة1"
        Me.unit1.Name = "unit1"
        Me.unit1.ReadOnly = True
        Me.unit1.Width = 101
        '
        'balance
        '
        Me.balance.FillWeight = 89.54314!
        Me.balance.HeaderText = "الرصيد"
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        Me.balance.Width = 101
        '
        'it
        '
        Me.it.FillWeight = 152.2843!
        Me.it.HeaderText = "تحديد"
        Me.it.Name = "it"
        Me.it.Width = 50
        '
        'M_Whole
        '
        Me.M_Whole.HeaderText = "الجملة"
        Me.M_Whole.Name = "M_Whole"
        Me.M_Whole.Visible = False
        '
        'M_Half
        '
        Me.M_Half.HeaderText = "نصف الجملة"
        Me.M_Half.Name = "M_Half"
        Me.M_Half.Visible = False
        '
        'M_EndUser
        '
        Me.M_EndUser.HeaderText = "المستهلك"
        Me.M_EndUser.Name = "M_EndUser"
        Me.M_EndUser.Visible = False
        '
        'M_Vendor
        '
        Me.M_Vendor.HeaderText = "الموزع"
        Me.M_Vendor.Name = "M_Vendor"
        Me.M_Vendor.Visible = False
        '
        'M_Export
        '
        Me.M_Export.HeaderText = "التصدير"
        Me.M_Export.Name = "M_Export"
        Me.M_Export.Visible = False
        '
        'M_Retail
        '
        Me.M_Retail.HeaderText = "المفرق"
        Me.M_Retail.Name = "M_Retail"
        Me.M_Retail.Visible = False
        '
        'M_LastPrice
        '
        Me.M_LastPrice.HeaderText = "اخر شراء"
        Me.M_LastPrice.Name = "M_LastPrice"
        Me.M_LastPrice.Visible = False
        '
        'FRM_ALL_ITEME_POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 323)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Group_itemeamer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ALL_ITEME_POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ALL_ITEME_POS"
        Me.Group_itemeamer.ResumeLayout(False)
        Me.Group_itemeamer.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Group_itemeamer As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX21 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_SEARSH As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents guid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEME_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents it As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents M_Whole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Half As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_EndUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Vendor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Export As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Retail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_LastPrice As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
