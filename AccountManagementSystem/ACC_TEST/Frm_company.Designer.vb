<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_company
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_company))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_SAVE = New System.Windows.Forms.ToolStripButton()
        Me.TXT_WEB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_EMAIL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_MOBILE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_PHONE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pictur_LOGO = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Pictur_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_SAVE})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(471, 25)
        Me.ToolStrip1.TabIndex = 882
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'TXT_WEB
        '
        Me.TXT_WEB.Location = New System.Drawing.Point(156, 152)
        Me.TXT_WEB.Name = "TXT_WEB"
        Me.TXT_WEB.Size = New System.Drawing.Size(227, 20)
        Me.TXT_WEB.TabIndex = 879
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 881
        Me.Label5.Text = "الموقع"
        '
        'TXT_EMAIL
        '
        Me.TXT_EMAIL.Location = New System.Drawing.Point(156, 126)
        Me.TXT_EMAIL.Name = "TXT_EMAIL"
        Me.TXT_EMAIL.Size = New System.Drawing.Size(227, 20)
        Me.TXT_EMAIL.TabIndex = 877
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 880
        Me.Label4.Text = "البريد الالكتروني"
        '
        'TXT_MOBILE
        '
        Me.TXT_MOBILE.Location = New System.Drawing.Point(156, 100)
        Me.TXT_MOBILE.Name = "TXT_MOBILE"
        Me.TXT_MOBILE.Size = New System.Drawing.Size(227, 20)
        Me.TXT_MOBILE.TabIndex = 875
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 878
        Me.Label3.Text = "موبايل"
        '
        'TXT_PHONE
        '
        Me.TXT_PHONE.Location = New System.Drawing.Point(156, 74)
        Me.TXT_PHONE.Name = "TXT_PHONE"
        Me.TXT_PHONE.Size = New System.Drawing.Size(227, 20)
        Me.TXT_PHONE.TabIndex = 874
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 876
        Me.Label2.Text = "الهاتف"
        '
        'TXT_NAME
        '
        Me.TXT_NAME.Location = New System.Drawing.Point(156, 48)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(227, 20)
        Me.TXT_NAME.TabIndex = 872
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 873
        Me.Label1.Text = "الاسم"
        '
        'Pictur_LOGO
        '
        Me.Pictur_LOGO.Location = New System.Drawing.Point(5, 32)
        Me.Pictur_LOGO.Name = "Pictur_LOGO"
        Me.Pictur_LOGO.Size = New System.Drawing.Size(140, 146)
        Me.Pictur_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pictur_LOGO.TabIndex = 883
        Me.Pictur_LOGO.TabStop = False
        '
        'Frm_company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 199)
        Me.Controls.Add(Me.Pictur_LOGO)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TXT_WEB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_EMAIL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_MOBILE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_PHONE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_NAME)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_company"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بيانات الشركة"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Pictur_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pictur_LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_SAVE As System.Windows.Forms.ToolStripButton
    Friend WithEvents TXT_WEB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_MOBILE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_PHONE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_NAME As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
