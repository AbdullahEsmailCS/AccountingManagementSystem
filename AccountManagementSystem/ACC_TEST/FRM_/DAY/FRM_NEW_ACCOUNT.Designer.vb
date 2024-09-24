<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_NEW_ACCOUNT
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.جديدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حفظToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تعديلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXT_NAME = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TXT_PARENT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.CMB_END = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TXT_CODE_PARENT_GUID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TXT_GUID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TXT_GUID_PARENT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.MenuStrip1)
        Me.GroupPanel1.Controls.Add(Me.TXT_NAME)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX3)
        Me.GroupPanel1.Controls.Add(Me.TXT_PARENT)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.CMB_END)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX1)
        Me.GroupPanel1.Controls.Add(Me.ButtonX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.TXT_CODE_PARENT_GUID)
        Me.GroupPanel1.Controls.Add(Me.TXT_GUID)
        Me.GroupPanel1.Controls.Add(Me.TXT_GUID_PARENT)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(360, 248)
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
        Me.GroupPanel1.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.جديدToolStripMenuItem, Me.حفظToolStripMenuItem, Me.تعديلToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(354, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'جديدToolStripMenuItem
        '
        Me.جديدToolStripMenuItem.Image = Global.ACC_TEST.My.Resources.Resources.add
        Me.جديدToolStripMenuItem.Name = "جديدToolStripMenuItem"
        Me.جديدToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.جديدToolStripMenuItem.Text = "جديد"
        Me.جديدToolStripMenuItem.Visible = False
        '
        'حفظToolStripMenuItem
        '
        Me.حفظToolStripMenuItem.Image = Global.ACC_TEST.My.Resources.Resources.Save
        Me.حفظToolStripMenuItem.Name = "حفظToolStripMenuItem"
        Me.حفظToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.حفظToolStripMenuItem.Text = "حفظ"
        '
        'تعديلToolStripMenuItem
        '
        Me.تعديلToolStripMenuItem.Image = Global.ACC_TEST.My.Resources.Resources.Edit
        Me.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem"
        Me.تعديلToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.تعديلToolStripMenuItem.Text = "تعديل"
        '
        'TXT_NAME
        '
        '
        '
        '
        Me.TXT_NAME.Border.Class = "TextBoxBorder"
        Me.TXT_NAME.Location = New System.Drawing.Point(48, 27)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(203, 20)
        Me.TXT_NAME.TabIndex = 2
        '
        'TextBoxX3
        '
        '
        '
        '
        Me.TextBoxX3.Border.Class = "TextBoxBorder"
        Me.TextBoxX3.Location = New System.Drawing.Point(66, 157)
        Me.TextBoxX3.Name = "TextBoxX3"
        Me.TextBoxX3.ReadOnly = True
        Me.TextBoxX3.Size = New System.Drawing.Size(185, 20)
        Me.TextBoxX3.TabIndex = 17
        Me.TextBoxX3.Text = "0"
        '
        'TXT_PARENT
        '
        '
        '
        '
        Me.TXT_PARENT.Border.Class = "TextBoxBorder"
        Me.TXT_PARENT.Location = New System.Drawing.Point(48, 53)
        Me.TXT_PARENT.Name = "TXT_PARENT"
        Me.TXT_PARENT.Size = New System.Drawing.Size(203, 20)
        Me.TXT_PARENT.TabIndex = 3
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Location = New System.Drawing.Point(267, 157)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(90, 23)
        Me.LabelX6.TabIndex = 18
        Me.LabelX6.Text = "الرصيد"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(267, 27)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(104, 23)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "اسم الحساب"
        '
        'TextBoxX2
        '
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Location = New System.Drawing.Point(66, 131)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.ReadOnly = True
        Me.TextBoxX2.Size = New System.Drawing.Size(185, 20)
        Me.TextBoxX2.TabIndex = 15
        Me.TextBoxX2.Text = "0"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(257, 51)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(98, 23)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "الحساب الرئيسي"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(267, 131)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(90, 23)
        Me.LabelX5.TabIndex = 16
        Me.LabelX5.Text = "مجموع الدائن"
        '
        'CMB_END
        '
        Me.CMB_END.DisplayMember = "Text"
        Me.CMB_END.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMB_END.FormattingEnabled = True
        Me.CMB_END.ItemHeight = 14
        Me.CMB_END.Location = New System.Drawing.Point(48, 79)
        Me.CMB_END.Name = "CMB_END"
        Me.CMB_END.Size = New System.Drawing.Size(203, 20)
        Me.CMB_END.TabIndex = 4
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Location = New System.Drawing.Point(66, 105)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.ReadOnly = True
        Me.TextBoxX1.Size = New System.Drawing.Size(185, 20)
        Me.TextBoxX1.TabIndex = 13
        Me.TextBoxX1.Text = "0"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(9, 50)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(34, 23)
        Me.ButtonX4.TabIndex = 8
        Me.ButtonX4.Text = "..."
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(267, 105)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(90, 23)
        Me.LabelX4.TabIndex = 14
        Me.LabelX4.Text = "مجموع المدين"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(257, 80)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(104, 23)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "الحساب الختامي"
        '
        'TXT_CODE_PARENT_GUID
        '
        '
        '
        '
        Me.TXT_CODE_PARENT_GUID.Border.Class = "TextBoxBorder"
        Me.TXT_CODE_PARENT_GUID.Location = New System.Drawing.Point(9, 157)
        Me.TXT_CODE_PARENT_GUID.Name = "TXT_CODE_PARENT_GUID"
        Me.TXT_CODE_PARENT_GUID.Size = New System.Drawing.Size(51, 20)
        Me.TXT_CODE_PARENT_GUID.TabIndex = 10
        Me.TXT_CODE_PARENT_GUID.Visible = False
        '
        'TXT_GUID
        '
        '
        '
        '
        Me.TXT_GUID.Border.Class = "TextBoxBorder"
        Me.TXT_GUID.Location = New System.Drawing.Point(3, 108)
        Me.TXT_GUID.Name = "TXT_GUID"
        Me.TXT_GUID.Size = New System.Drawing.Size(36, 20)
        Me.TXT_GUID.TabIndex = 11
        Me.TXT_GUID.Visible = False
        '
        'TXT_GUID_PARENT
        '
        '
        '
        '
        Me.TXT_GUID_PARENT.Border.Class = "TextBoxBorder"
        Me.TXT_GUID_PARENT.Location = New System.Drawing.Point(9, 79)
        Me.TXT_GUID_PARENT.Name = "TXT_GUID_PARENT"
        Me.TXT_GUID_PARENT.Size = New System.Drawing.Size(36, 20)
        Me.TXT_GUID_PARENT.TabIndex = 9
        Me.TXT_GUID_PARENT.Visible = False
        '
        'FRM_NEW_ACCOUNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 193)
        Me.Controls.Add(Me.GroupPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_NEW_ACCOUNT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بطاقة حساب"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TXT_NAME As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_PARENT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CMB_END As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_CODE_PARENT_GUID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_GUID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_GUID_PARENT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents جديدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حفظToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تعديلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
