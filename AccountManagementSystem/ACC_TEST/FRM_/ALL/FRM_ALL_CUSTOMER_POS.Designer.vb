<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ALL_CUSTOMER_POS
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Group_itemeamer = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX21 = New DevComponents.DotNetBar.ButtonX()
        Me.TXT_SEARSH = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Group_itemeamer.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Group_itemeamer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 60)
        Me.Panel1.TabIndex = 3
        '
        'Group_itemeamer
        '
        Me.Group_itemeamer.AutoScroll = True
        Me.Group_itemeamer.CanvasColor = System.Drawing.SystemColors.Control
        Me.Group_itemeamer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Group_itemeamer.Controls.Add(Me.ButtonX21)
        Me.Group_itemeamer.Controls.Add(Me.TXT_SEARSH)
        Me.Group_itemeamer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Group_itemeamer.Location = New System.Drawing.Point(0, 0)
        Me.Group_itemeamer.Name = "Group_itemeamer"
        Me.Group_itemeamer.Size = New System.Drawing.Size(744, 60)
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
        Me.Group_itemeamer.TabIndex = 2
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
        Me.ButtonX21.Size = New System.Drawing.Size(158, 54)
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
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(0, 60)
        Me.DGV.Name = "DGV"
        Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGV.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(744, 339)
        Me.DGV.TabIndex = 4
        '
        'FRM_ALL_CUSTOMER_POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 399)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ALL_CUSTOMER_POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الزبائن"
        Me.Panel1.ResumeLayout(False)
        Me.Group_itemeamer.ResumeLayout(False)
        Me.Group_itemeamer.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TXT_SEARSH As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Group_itemeamer As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX21 As DevComponents.DotNetBar.ButtonX
End Class
