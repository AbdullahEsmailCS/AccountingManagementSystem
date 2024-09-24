<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_REP_ALLDAY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_REP_ALLDAY))
        Me.DTP1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DGV_JOB = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.جديدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXT_GUID_CURRENCY = New System.Windows.Forms.TextBox()
        Me.TXT_CURRENCY = New System.Windows.Forms.TextBox()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.TXT_CURRENCY_VAL = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.DTP2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        CType(Me.DTP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.DGV_JOB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DTP2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTP1
        '
        '
        '
        '
        Me.DTP1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTP1.ButtonDropDown.Visible = True
        Me.DTP1.Location = New System.Drawing.Point(9, 28)
        '
        '
        '
        Me.DTP1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.DTP1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTP1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTP1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTP1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTP1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTP1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTP1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTP1.MonthCalendar.DisplayMonth = New Date(2016, 10, 1, 0, 0, 0, 0)
        Me.DTP1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DTP1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DTP1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTP1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTP1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTP1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTP1.MonthCalendar.TodayButtonVisible = True
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(263, 20)
        Me.DTP1.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.GroupPanel4)
        Me.GroupPanel1.Controls.Add(Me.MenuStrip1)
        Me.GroupPanel1.Controls.Add(Me.TXT_GUID_CURRENCY)
        Me.GroupPanel1.Controls.Add(Me.TXT_CURRENCY)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.TXT_CURRENCY_VAL)
        Me.GroupPanel1.Controls.Add(Me.Button3)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.DTP2)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.DTP1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(351, 335)
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
        Me.GroupPanel1.TabIndex = 1
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.DGV_JOB)
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 136)
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
        Me.GroupPanel4.TabIndex = 68
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
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DataGridViewCheckBoxColumn2.HeaderText = "True"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn2.Width = 50
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.جديدToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(345, 24)
        Me.MenuStrip1.TabIndex = 60
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'جديدToolStripMenuItem
        '
        Me.جديدToolStripMenuItem.Image = Global.ACC_TEST.My.Resources.Resources.document_quickprint
        Me.جديدToolStripMenuItem.Name = "جديدToolStripMenuItem"
        Me.جديدToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.جديدToolStripMenuItem.Text = "بحث"
        '
        'TXT_GUID_CURRENCY
        '
        Me.TXT_GUID_CURRENCY.Location = New System.Drawing.Point(287, 93)
        Me.TXT_GUID_CURRENCY.Name = "TXT_GUID_CURRENCY"
        Me.TXT_GUID_CURRENCY.Size = New System.Drawing.Size(31, 20)
        Me.TXT_GUID_CURRENCY.TabIndex = 59
        Me.TXT_GUID_CURRENCY.Visible = False
        '
        'TXT_CURRENCY
        '
        Me.TXT_CURRENCY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXT_CURRENCY.Location = New System.Drawing.Point(51, 80)
        Me.TXT_CURRENCY.Name = "TXT_CURRENCY"
        Me.TXT_CURRENCY.Size = New System.Drawing.Size(221, 20)
        Me.TXT_CURRENCY.TabIndex = 58
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        Me.LabelX8.Location = New System.Drawing.Point(278, 107)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 23)
        Me.LabelX8.TabIndex = 57
        Me.LabelX8.Text = "سعر التعادل"
        '
        'TXT_CURRENCY_VAL
        '
        Me.TXT_CURRENCY_VAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.TXT_CURRENCY_VAL.Border.Class = "TextBoxBorder"
        Me.TXT_CURRENCY_VAL.Location = New System.Drawing.Point(51, 107)
        Me.TXT_CURRENCY_VAL.Name = "TXT_CURRENCY_VAL"
        Me.TXT_CURRENCY_VAL.Size = New System.Drawing.Size(221, 20)
        Me.TXT_CURRENCY_VAL.TabIndex = 56
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 23)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(278, 78)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(65, 23)
        Me.LabelX7.TabIndex = 54
        Me.LabelX7.Text = "العملة"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(278, 51)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "الى تاريخ"
        '
        'DTP2
        '
        '
        '
        '
        Me.DTP2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DTP2.ButtonDropDown.Visible = True
        Me.DTP2.Location = New System.Drawing.Point(9, 54)
        '
        '
        '
        Me.DTP2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.DTP2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DTP2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DTP2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DTP2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DTP2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DTP2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DTP2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DTP2.MonthCalendar.DisplayMonth = New Date(2016, 10, 1, 0, 0, 0, 0)
        Me.DTP2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DTP2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DTP2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DTP2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DTP2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DTP2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DTP2.MonthCalendar.TodayButtonVisible = True
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(263, 20)
        Me.DTP2.TabIndex = 2
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(278, 25)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "من تاريخ"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 313)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(351, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FRM_REP_ALLDAY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 335)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_REP_ALLDAY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اليومية العامة"
        CType(Me.DTP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.DGV_JOB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DTP2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTP1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DTP2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_GUID_CURRENCY As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CURRENCY As System.Windows.Forms.TextBox
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_CURRENCY_VAL As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents جديدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DGV_JOB As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
