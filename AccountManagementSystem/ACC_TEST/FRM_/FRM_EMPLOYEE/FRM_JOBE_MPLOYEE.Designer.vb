<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_JOBE_MPLOYEE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_JOBE_MPLOYEE))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_NEW = New System.Windows.Forms.ToolStripButton()
        Me.Tool_SAVE = New System.Windows.Forms.ToolStripButton()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_NEW, Me.Tool_SAVE})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(416, 25)
        Me.ToolStrip1.TabIndex = 8
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
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 74)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(392, 324)
        Me.DGV.TabIndex = 7
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(12, 48)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(34, 20)
        Me.TXT_ID.TabIndex = 6
        Me.TXT_ID.Visible = False
        '
        'TXT_NAME
        '
        Me.TXT_NAME.Location = New System.Drawing.Point(52, 48)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_NAME.Size = New System.Drawing.Size(318, 20)
        Me.TXT_NAME.TabIndex = 5
        '
        'FRM_JOBE_MPLOYEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 411)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.TXT_NAME)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(432, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(432, 450)
        Me.Name = "FRM_JOBE_MPLOYEE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "التصنيف الوظيفي"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_NEW As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_SAVE As System.Windows.Forms.ToolStripButton
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TXT_ID As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NAME As System.Windows.Forms.TextBox
End Class
