﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ITEME_DAY
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
        Me.TXT_ITEME_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_ITEME_GUID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.جديدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXT_JOB = New System.Windows.Forms.TextBox()
        Me.TXT_GUID_JOB = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.DTP2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.DTP1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.GroupPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DTP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TXT_ITEME_NAME)
        Me.GroupPanel1.Controls.Add(Me.TXT_ITEME_GUID)
        Me.GroupPanel1.Controls.Add(Me.Button1)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.MenuStrip1)
        Me.GroupPanel1.Controls.Add(Me.TXT_JOB)
        Me.GroupPanel1.Controls.Add(Me.TXT_GUID_JOB)
        Me.GroupPanel1.Controls.Add(Me.Button2)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.DTP2)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.DTP1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(373, 141)
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
        Me.GroupPanel1.TabIndex = 3
        '
        'TXT_ITEME_NAME
        '
        Me.TXT_ITEME_NAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXT_ITEME_NAME.Location = New System.Drawing.Point(51, 106)
        Me.TXT_ITEME_NAME.Name = "TXT_ITEME_NAME"
        Me.TXT_ITEME_NAME.Size = New System.Drawing.Size(221, 20)
        Me.TXT_ITEME_NAME.TabIndex = 64
        '
        'TXT_ITEME_GUID
        '
        Me.TXT_ITEME_GUID.Location = New System.Drawing.Point(341, 112)
        Me.TXT_ITEME_GUID.Name = "TXT_ITEME_GUID"
        Me.TXT_ITEME_GUID.Size = New System.Drawing.Size(23, 20)
        Me.TXT_ITEME_GUID.TabIndex = 63
        Me.TXT_ITEME_GUID.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(279, 106)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(45, 23)
        Me.LabelX3.TabIndex = 61
        Me.LabelX3.Text = "المادة"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.جديدToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(367, 24)
        Me.MenuStrip1.TabIndex = 60
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'جديدToolStripMenuItem
        '
        Me.جديدToolStripMenuItem.Image = Global.ACC_TEST.My.Resources.Resources.document_quickprint
        Me.جديدToolStripMenuItem.Name = "جديدToolStripMenuItem"
        Me.جديدToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.جديدToolStripMenuItem.Text = "بحث"
        '
        'TXT_JOB
        '
        Me.TXT_JOB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXT_JOB.Location = New System.Drawing.Point(51, 80)
        Me.TXT_JOB.Name = "TXT_JOB"
        Me.TXT_JOB.Size = New System.Drawing.Size(221, 20)
        Me.TXT_JOB.TabIndex = 53
        '
        'TXT_GUID_JOB
        '
        Me.TXT_GUID_JOB.Location = New System.Drawing.Point(341, 63)
        Me.TXT_GUID_JOB.Name = "TXT_GUID_JOB"
        Me.TXT_GUID_JOB.Size = New System.Drawing.Size(23, 20)
        Me.TXT_GUID_JOB.TabIndex = 52
        Me.TXT_GUID_JOB.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 23)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(279, 80)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(61, 23)
        Me.LabelX4.TabIndex = 50
        Me.LabelX4.Text = "مركز الكلفة"
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
        'FRM_ITEME_DAY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 141)
        Me.Controls.Add(Me.GroupPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_ITEME_DAY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حركة مادة"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DTP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents جديدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TXT_JOB As System.Windows.Forms.TextBox
    Friend WithEvents TXT_GUID_JOB As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DTP2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DTP1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents TXT_ITEME_NAME As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ITEME_GUID As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
End Class
