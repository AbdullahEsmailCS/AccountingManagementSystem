<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_day_expen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_day_expen))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_NEW = New System.Windows.Forms.ToolStripButton()
        Me.Tool_SAVE = New System.Windows.Forms.ToolStripButton()
        Me.Tool_UPDATE = New System.Windows.Forms.ToolStripButton()
        Me.Tool_DELETE = New System.Windows.Forms.ToolStripButton()
        Me.TXT_iD_DAY = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_student = New System.Windows.Forms.ComboBox()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_NOTE = New System.Windows.Forms.TextBox()
        Me.TXT_MONEY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_TYPE = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LB_LAST = New System.Windows.Forms.Label()
        Me.LB_FIRST = New System.Windows.Forms.Label()
        Me.LB_NEXT = New System.Windows.Forms.Label()
        Me.LBL_END = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_NEW, Me.Tool_SAVE, Me.Tool_UPDATE, Me.Tool_DELETE})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(356, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_NEW
        '
        Me.Tool_NEW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_NEW.Image = Global.ACC_TEST.My.Resources.Resources.add
        Me.Tool_NEW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_NEW.Name = "Tool_NEW"
        Me.Tool_NEW.Size = New System.Drawing.Size(23, 22)
        Me.Tool_NEW.Text = "جديد"
        '
        'Tool_SAVE
        '
        Me.Tool_SAVE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_SAVE.Image = Global.ACC_TEST.My.Resources.Resources.Save
        Me.Tool_SAVE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_SAVE.Name = "Tool_SAVE"
        Me.Tool_SAVE.Size = New System.Drawing.Size(23, 22)
        Me.Tool_SAVE.Text = "حفظ"
        '
        'Tool_UPDATE
        '
        Me.Tool_UPDATE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tool_UPDATE.Image = Global.ACC_TEST.My.Resources.Resources.Edit
        Me.Tool_UPDATE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_UPDATE.Name = "Tool_UPDATE"
        Me.Tool_UPDATE.Size = New System.Drawing.Size(23, 22)
        Me.Tool_UPDATE.Text = "تعديل"
        '
        'Tool_DELETE
        '
        Me.Tool_DELETE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        'Me.Tool_DELETE.Image = Global.ACC_TEST.My.Resources.Resources.Delete
        Me.Tool_DELETE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_DELETE.Name = "Tool_DELETE"
        Me.Tool_DELETE.Size = New System.Drawing.Size(23, 22)
        Me.Tool_DELETE.Text = "حذف"
        '
        'TXT_iD_DAY
        '
        Me.TXT_iD_DAY.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TXT_iD_DAY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_iD_DAY.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_iD_DAY.Location = New System.Drawing.Point(64, 28)
        Me.TXT_iD_DAY.Multiline = True
        Me.TXT_iD_DAY.Name = "TXT_iD_DAY"
        Me.TXT_iD_DAY.ReadOnly = True
        Me.TXT_iD_DAY.Size = New System.Drawing.Size(70, 20)
        Me.TXT_iD_DAY.TabIndex = 869
        Me.TXT_iD_DAY.TabStop = False
        Me.TXT_iD_DAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmb_student)
        Me.GroupBox1.Controls.Add(Me.DTP1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_NOTE)
        Me.GroupBox1.Controls.Add(Me.TXT_MONEY)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 232)
        Me.GroupBox1.TabIndex = 874
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "الموظف"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 21)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_student
        '
        Me.cmb_student.ForeColor = System.Drawing.Color.Navy
        Me.cmb_student.FormattingEnabled = True
        Me.cmb_student.Location = New System.Drawing.Point(42, 45)
        Me.cmb_student.Name = "cmb_student"
        Me.cmb_student.Size = New System.Drawing.Size(238, 21)
        Me.cmb_student.TabIndex = 45
        '
        'DTP1
        '
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(6, 19)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(274, 20)
        Me.DTP1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "التاريخ"
        '
        'TXT_NOTE
        '
        Me.TXT_NOTE.Location = New System.Drawing.Point(6, 98)
        Me.TXT_NOTE.Multiline = True
        Me.TXT_NOTE.Name = "TXT_NOTE"
        Me.TXT_NOTE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_NOTE.Size = New System.Drawing.Size(274, 126)
        Me.TXT_NOTE.TabIndex = 3
        '
        'TXT_MONEY
        '
        Me.TXT_MONEY.Location = New System.Drawing.Point(6, 72)
        Me.TXT_MONEY.Name = "TXT_MONEY"
        Me.TXT_MONEY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_MONEY.Size = New System.Drawing.Size(274, 20)
        Me.TXT_MONEY.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "الشرح"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "المبلغ"
        '
        'TXT_TYPE
        '
        Me.TXT_TYPE.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TXT_TYPE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TYPE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TYPE.Location = New System.Drawing.Point(280, 28)
        Me.TXT_TYPE.Multiline = True
        Me.TXT_TYPE.Name = "TXT_TYPE"
        Me.TXT_TYPE.ReadOnly = True
        Me.TXT_TYPE.Size = New System.Drawing.Size(70, 20)
        Me.TXT_TYPE.TabIndex = 875
        Me.TXT_TYPE.TabStop = False
        Me.TXT_TYPE.Text = "0"
        Me.TXT_TYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_TYPE.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 296)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(356, 22)
        Me.StatusStrip1.TabIndex = 876
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LB_LAST
        '
        Me.LB_LAST.BackColor = System.Drawing.Color.Transparent
        'Me.LB_LAST.Image = Global.EMPLOYEE.My.Resources.Resources.Prev
        Me.LB_LAST.Location = New System.Drawing.Point(36, 26)
        Me.LB_LAST.Name = "LB_LAST"
        Me.LB_LAST.Size = New System.Drawing.Size(22, 23)
        Me.LB_LAST.TabIndex = 873
        '
        'LB_FIRST
        '
        Me.LB_FIRST.BackColor = System.Drawing.Color.Transparent
        'Me.LB_FIRST.Image = Global.EMPLOYEE.My.Resources.Resources.Last
        Me.LB_FIRST.Location = New System.Drawing.Point(9, 26)
        Me.LB_FIRST.Name = "LB_FIRST"
        Me.LB_FIRST.Size = New System.Drawing.Size(30, 23)
        Me.LB_FIRST.TabIndex = 872
        '
        'LB_NEXT
        '
        Me.LB_NEXT.BackColor = System.Drawing.Color.Transparent
        'Me.LB_NEXT.Image = Global.EMPLOYEE.My.Resources.Resources._Next
        Me.LB_NEXT.Location = New System.Drawing.Point(140, 26)
        Me.LB_NEXT.Name = "LB_NEXT"
        Me.LB_NEXT.Size = New System.Drawing.Size(20, 23)
        Me.LB_NEXT.TabIndex = 871
        '
        'LBL_END
        '
        Me.LBL_END.BackColor = System.Drawing.Color.Transparent
        'Me.LBL_END.Image = Global.EMPLOYEE.My.Resources.Resources.First
        Me.LBL_END.Location = New System.Drawing.Point(160, 26)
        Me.LBL_END.Name = "LBL_END"
        Me.LBL_END.Size = New System.Drawing.Size(30, 23)
        Me.LBL_END.TabIndex = 870
        '
        'Frm_day_expen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 318)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TXT_TYPE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LB_LAST)
        Me.Controls.Add(Me.LB_FIRST)
        Me.Controls.Add(Me.LB_NEXT)
        Me.Controls.Add(Me.LBL_END)
        Me.Controls.Add(Me.TXT_iD_DAY)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_day_expen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_NEW As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_SAVE As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_UPDATE As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_DELETE As System.Windows.Forms.ToolStripButton
    Friend WithEvents LB_LAST As System.Windows.Forms.Label
    Friend WithEvents LB_FIRST As System.Windows.Forms.Label
    Friend WithEvents LB_NEXT As System.Windows.Forms.Label
    Friend WithEvents LBL_END As System.Windows.Forms.Label
    Friend WithEvents TXT_iD_DAY As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_NOTE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MONEY As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_TYPE As System.Windows.Forms.TextBox
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmb_student As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
