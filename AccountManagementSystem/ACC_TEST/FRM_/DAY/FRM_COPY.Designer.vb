<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_COPY
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.حفظToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXT_ID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.حفظToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(195, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'حفظToolStripMenuItem
        '
        Me.حفظToolStripMenuItem.Image = Global.ACC_TEST.My.Resources.Resources.Save
        Me.حفظToolStripMenuItem.Name = "حفظToolStripMenuItem"
        Me.حفظToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.حفظToolStripMenuItem.Text = "موافق"
        '
        'TXT_ID
        '
        '
        '
        '
        Me.TXT_ID.Border.Class = "TextBoxBorder"
        Me.TXT_ID.Location = New System.Drawing.Point(12, 36)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(124, 20)
        Me.TXT_ID.TabIndex = 13
        Me.TXT_ID.Text = "1"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Location = New System.Drawing.Point(142, 36)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(41, 23)
        Me.LabelX6.TabIndex = 31
        Me.LabelX6.Text = "رقم "
        '
        'FRM_COPY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 71)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_COPY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تكرار سند"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents حفظToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TXT_ID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
End Class
