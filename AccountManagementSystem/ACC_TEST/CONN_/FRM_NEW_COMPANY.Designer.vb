<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_NEW_COMPANY
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.TXT_COMPANY = New System.Windows.Forms.TextBox()
        Me.TXT_CON2 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.TXT_NEWDATA = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TXT_server = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.chkWindowsAuthentication = New System.Windows.Forms.CheckBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ButtonX2)
        Me.Panel2.Controls.Add(Me.ButtonX1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(309, 46)
        Me.Panel2.TabIndex = 1
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(12, 11)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(98, 23)
        Me.ButtonX2.TabIndex = 1
        Me.ButtonX2.Text = "خروج"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(199, 11)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(91, 23)
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "شركة جديدة"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 206)
        Me.Panel1.TabIndex = 2
        '
        'panel4
        '
        Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel4.Controls.Add(Me.label3)
        Me.panel4.Controls.Add(Me.TXT_COMPANY)
        Me.panel4.Controls.Add(Me.TXT_CON2)
        Me.panel4.Controls.Add(Me.label2)
        Me.panel4.Controls.Add(Me.TXT_NEWDATA)
        Me.panel4.Location = New System.Drawing.Point(2, 128)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(288, 72)
        Me.panel4.TabIndex = 31
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(10, 36)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(66, 13)
        Me.label3.TabIndex = 35
        Me.label3.Text = "اسم الشركة"
        '
        'TXT_COMPANY
        '
        Me.TXT_COMPANY.ForeColor = System.Drawing.Color.Black
        Me.TXT_COMPANY.Location = New System.Drawing.Point(76, 33)
        Me.TXT_COMPANY.Name = "TXT_COMPANY"
        Me.TXT_COMPANY.Size = New System.Drawing.Size(179, 20)
        Me.TXT_COMPANY.TabIndex = 36
        '
        'TXT_CON2
        '
        Me.TXT_CON2.ForeColor = System.Drawing.Color.Black
        Me.TXT_CON2.Location = New System.Drawing.Point(15, 107)
        Me.TXT_CON2.Name = "TXT_CON2"
        Me.TXT_CON2.Size = New System.Drawing.Size(31, 20)
        Me.TXT_CON2.TabIndex = 34
        Me.TXT_CON2.Visible = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(10, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(54, 13)
        Me.label2.TabIndex = 21
        Me.label2.Text = "New Data"
        '
        'TXT_NEWDATA
        '
        Me.TXT_NEWDATA.ForeColor = System.Drawing.Color.Black
        Me.TXT_NEWDATA.Location = New System.Drawing.Point(76, 7)
        Me.TXT_NEWDATA.Name = "TXT_NEWDATA"
        Me.TXT_NEWDATA.Size = New System.Drawing.Size(179, 20)
        Me.TXT_NEWDATA.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TXT_server)
        Me.Panel3.Controls.Add(Me.lblPassword)
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.Controls.Add(Me.label1)
        Me.Panel3.Controls.Add(Me.lblLogin)
        Me.Panel3.Controls.Add(Me.chkWindowsAuthentication)
        Me.Panel3.Controls.Add(Me.txtLogin)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(287, 119)
        Me.Panel3.TabIndex = 30
        '
        'TXT_server
        '
        Me.TXT_server.ForeColor = System.Drawing.Color.Black
        Me.TXT_server.Location = New System.Drawing.Point(75, 3)
        Me.TXT_server.Name = "TXT_server"
        Me.TXT_server.Size = New System.Drawing.Size(207, 20)
        Me.TXT_server.TabIndex = 26
        Me.TXT_server.Text = "(local)"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(6, 58)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(57, 13)
        Me.lblPassword.TabIndex = 18
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(75, 58)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(207, 20)
        Me.txtPassword.TabIndex = 20
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(3, 6)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Name:"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.ForeColor = System.Drawing.Color.Black
        Me.lblLogin.Location = New System.Drawing.Point(6, 32)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(36, 13)
        Me.lblLogin.TabIndex = 17
        Me.lblLogin.Text = "Login:"
        '
        'chkWindowsAuthentication
        '
        Me.chkWindowsAuthentication.AutoSize = True
        Me.chkWindowsAuthentication.Checked = True
        Me.chkWindowsAuthentication.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWindowsAuthentication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkWindowsAuthentication.ForeColor = System.Drawing.Color.Black
        Me.chkWindowsAuthentication.Location = New System.Drawing.Point(9, 81)
        Me.chkWindowsAuthentication.Name = "chkWindowsAuthentication"
        Me.chkWindowsAuthentication.Size = New System.Drawing.Size(160, 17)
        Me.chkWindowsAuthentication.TabIndex = 24
        Me.chkWindowsAuthentication.Text = "Use Windows Authentication"
        Me.chkWindowsAuthentication.UseVisualStyleBackColor = True
        '
        'txtLogin
        '
        Me.txtLogin.ForeColor = System.Drawing.Color.Black
        Me.txtLogin.Location = New System.Drawing.Point(75, 29)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(207, 20)
        Me.txtLogin.TabIndex = 19
        Me.txtLogin.Text = "SA"
        '
        'FRM_NEW_COMPANY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FRM_NEW_COMPANY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شركة جديدة"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents panel4 As System.Windows.Forms.Panel
    Private WithEvents TXT_CON2 As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents TXT_NEWDATA As System.Windows.Forms.TextBox
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents TXT_server As System.Windows.Forms.TextBox
    Private WithEvents lblPassword As System.Windows.Forms.Label
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lblLogin As System.Windows.Forms.Label
    Private WithEvents chkWindowsAuthentication As System.Windows.Forms.CheckBox
    Private WithEvents txtLogin As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents TXT_COMPANY As System.Windows.Forms.TextBox
End Class
