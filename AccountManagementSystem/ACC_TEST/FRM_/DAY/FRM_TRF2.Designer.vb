<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_TRF2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_TRF2))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_NEW = New System.Windows.Forms.ToolStripButton()
        Me.Tool_SAVE = New System.Windows.Forms.ToolStripButton()
        Me.Tool_UPDATE = New System.Windows.Forms.ToolStripButton()
        Me.Tool_DELETE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TXT_GUID = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TXT_GUID_PARENT = New System.Windows.Forms.TextBox()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_iD = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LB_LAST = New System.Windows.Forms.Label()
        Me.LB_FIRST = New System.Windows.Forms.Label()
        Me.LB_NEXT = New System.Windows.Forms.Label()
        Me.LBL_END = New System.Windows.Forms.Label()
        Me.PIC_NEW = New System.Windows.Forms.PictureBox()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_LAST_NAME = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_JOB_COMPAN = New System.Windows.Forms.TextBox()
        Me.TXT_NAME_COMPANY = New System.Windows.Forms.TextBox()
        Me.TXT_CUNTRY = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_STREET = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_WEB = New System.Windows.Forms.TextBox()
        Me.TXT_MOBILE_1 = New System.Windows.Forms.TextBox()
        Me.TXT_PHONE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_MAIL = New System.Windows.Forms.TextBox()
        Me.TXT_MOBILE_2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_GUID_ACCOUNT = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PIC_NEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_NEW, Me.Tool_SAVE, Me.Tool_UPDATE, Me.Tool_DELETE, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(529, 25)
        Me.ToolStrip1.TabIndex = 871
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
        Me.Tool_DELETE.Image = Global.ACC_TEST.My.Resources.Resources.dialog_cancel_3
        Me.Tool_DELETE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_DELETE.Name = "Tool_DELETE"
        Me.Tool_DELETE.Size = New System.Drawing.Size(23, 22)
        Me.Tool_DELETE.Text = "حذف"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "البحث"
        '
        'TXT_GUID
        '
        Me.TXT_GUID.BackColor = System.Drawing.Color.White
        Me.TXT_GUID.Location = New System.Drawing.Point(240, 378)
        Me.TXT_GUID.Name = "TXT_GUID"
        Me.TXT_GUID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_GUID.Size = New System.Drawing.Size(25, 20)
        Me.TXT_GUID.TabIndex = 889
        Me.TXT_GUID.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(329, 375)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker1.TabIndex = 46
        Me.DateTimePicker1.Visible = False
        '
        'TXT_GUID_PARENT
        '
        Me.TXT_GUID_PARENT.BackColor = System.Drawing.Color.White
        Me.TXT_GUID_PARENT.Location = New System.Drawing.Point(271, 378)
        Me.TXT_GUID_PARENT.Name = "TXT_GUID_PARENT"
        Me.TXT_GUID_PARENT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_GUID_PARENT.Size = New System.Drawing.Size(52, 20)
        Me.TXT_GUID_PARENT.TabIndex = 34
        Me.TXT_GUID_PARENT.Text = "e89a8e3f-6440-42c3-95ec-f51204349053"
        Me.TXT_GUID_PARENT.Visible = False
        '
        'TXT_NAME
        '
        Me.TXT_NAME.BackColor = System.Drawing.Color.White
        Me.TXT_NAME.Location = New System.Drawing.Point(145, 59)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_NAME.Size = New System.Drawing.Size(279, 20)
        Me.TXT_NAME.TabIndex = 872
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 874
        Me.Label2.Text = "الاسم"
        '
        'TXT_iD
        '
        Me.TXT_iD.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TXT_iD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_iD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_iD.Location = New System.Drawing.Point(62, 35)
        Me.TXT_iD.Multiline = True
        Me.TXT_iD.Name = "TXT_iD"
        Me.TXT_iD.ReadOnly = True
        Me.TXT_iD.Size = New System.Drawing.Size(70, 20)
        Me.TXT_iD.TabIndex = 890
        Me.TXT_iD.TabStop = False
        Me.TXT_iD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"زبون", "مورد"})
        Me.ComboBox1.Location = New System.Drawing.Point(19, 58)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 895
        Me.ComboBox1.Text = "زبون"
        '
        'LB_LAST
        '
        Me.LB_LAST.BackColor = System.Drawing.Color.Transparent
        Me.LB_LAST.Image = Global.ACC_TEST.My.Resources.Resources.Prev
        Me.LB_LAST.Location = New System.Drawing.Point(34, 33)
        Me.LB_LAST.Name = "LB_LAST"
        Me.LB_LAST.Size = New System.Drawing.Size(22, 23)
        Me.LB_LAST.TabIndex = 894
        '
        'LB_FIRST
        '
        Me.LB_FIRST.BackColor = System.Drawing.Color.Transparent
        Me.LB_FIRST.Image = Global.ACC_TEST.My.Resources.Resources.Last
        Me.LB_FIRST.Location = New System.Drawing.Point(7, 33)
        Me.LB_FIRST.Name = "LB_FIRST"
        Me.LB_FIRST.Size = New System.Drawing.Size(30, 23)
        Me.LB_FIRST.TabIndex = 893
        '
        'LB_NEXT
        '
        Me.LB_NEXT.BackColor = System.Drawing.Color.Transparent
        Me.LB_NEXT.Image = Global.ACC_TEST.My.Resources.Resources._Next
        Me.LB_NEXT.Location = New System.Drawing.Point(142, 33)
        Me.LB_NEXT.Name = "LB_NEXT"
        Me.LB_NEXT.Size = New System.Drawing.Size(20, 23)
        Me.LB_NEXT.TabIndex = 892
        '
        'LBL_END
        '
        Me.LBL_END.BackColor = System.Drawing.Color.Transparent
        Me.LBL_END.Image = Global.ACC_TEST.My.Resources.Resources.First1
        Me.LBL_END.Location = New System.Drawing.Point(162, 33)
        Me.LBL_END.Name = "LBL_END"
        Me.LBL_END.Size = New System.Drawing.Size(30, 23)
        Me.LBL_END.TabIndex = 891
        '
        'PIC_NEW
        '
        Me.PIC_NEW.Image = Global.ACC_TEST.My.Resources.Resources.images
        Me.PIC_NEW.Location = New System.Drawing.Point(194, 378)
        Me.PIC_NEW.Name = "PIC_NEW"
        Me.PIC_NEW.Size = New System.Drawing.Size(21, 23)
        Me.PIC_NEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC_NEW.TabIndex = 881
        Me.PIC_NEW.TabStop = False
        Me.PIC_NEW.Visible = False
        '
        'pic
        '
        Me.pic.Image = Global.ACC_TEST.My.Resources.Resources.images
        Me.pic.Location = New System.Drawing.Point(19, 88)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(120, 124)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 880
        Me.pic.TabStop = False
        '
        'DTP
        '
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(145, 111)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(279, 20)
        Me.DTP.TabIndex = 897
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(430, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 896
        Me.Label1.Text = "المواليد"
        '
        'TXT_LAST_NAME
        '
        Me.TXT_LAST_NAME.BackColor = System.Drawing.Color.White
        Me.TXT_LAST_NAME.Location = New System.Drawing.Point(145, 85)
        Me.TXT_LAST_NAME.Name = "TXT_LAST_NAME"
        Me.TXT_LAST_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_LAST_NAME.Size = New System.Drawing.Size(279, 20)
        Me.TXT_LAST_NAME.TabIndex = 898
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(430, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 899
        Me.Label3.Text = "الاسم اللاتيني"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(435, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 903
        Me.Label5.Text = "مجال العمل سابق"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 902
        Me.Label4.Text = "الشركة السابقة"
        '
        'TXT_JOB_COMPAN
        '
        Me.TXT_JOB_COMPAN.BackColor = System.Drawing.Color.White
        Me.TXT_JOB_COMPAN.Location = New System.Drawing.Point(145, 163)
        Me.TXT_JOB_COMPAN.Name = "TXT_JOB_COMPAN"
        Me.TXT_JOB_COMPAN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_JOB_COMPAN.Size = New System.Drawing.Size(279, 20)
        Me.TXT_JOB_COMPAN.TabIndex = 901
        '
        'TXT_NAME_COMPANY
        '
        Me.TXT_NAME_COMPANY.BackColor = System.Drawing.Color.White
        Me.TXT_NAME_COMPANY.Location = New System.Drawing.Point(145, 140)
        Me.TXT_NAME_COMPANY.Name = "TXT_NAME_COMPANY"
        Me.TXT_NAME_COMPANY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_NAME_COMPANY.Size = New System.Drawing.Size(279, 20)
        Me.TXT_NAME_COMPANY.TabIndex = 900
        '
        'TXT_CUNTRY
        '
        Me.TXT_CUNTRY.BackColor = System.Drawing.Color.White
        Me.TXT_CUNTRY.Location = New System.Drawing.Point(145, 189)
        Me.TXT_CUNTRY.Name = "TXT_CUNTRY"
        Me.TXT_CUNTRY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_CUNTRY.Size = New System.Drawing.Size(279, 20)
        Me.TXT_CUNTRY.TabIndex = 904
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(436, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 907
        Me.Label11.Text = "المدينة"
        '
        'TXT_STREET
        '
        Me.TXT_STREET.BackColor = System.Drawing.Color.White
        Me.TXT_STREET.Location = New System.Drawing.Point(19, 216)
        Me.TXT_STREET.Name = "TXT_STREET"
        Me.TXT_STREET.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_STREET.Size = New System.Drawing.Size(405, 20)
        Me.TXT_STREET.TabIndex = 905
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(435, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 906
        Me.Label12.Text = "الشارع"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(432, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 916
        Me.Label6.Text = "الموقع الالكتروني"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(439, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 908
        Me.Label10.Text = "موبايل1"
        '
        'TXT_WEB
        '
        Me.TXT_WEB.BackColor = System.Drawing.Color.White
        Me.TXT_WEB.Location = New System.Drawing.Point(19, 349)
        Me.TXT_WEB.Name = "TXT_WEB"
        Me.TXT_WEB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_WEB.Size = New System.Drawing.Size(405, 20)
        Me.TXT_WEB.TabIndex = 917
        '
        'TXT_MOBILE_1
        '
        Me.TXT_MOBILE_1.BackColor = System.Drawing.Color.White
        Me.TXT_MOBILE_1.Location = New System.Drawing.Point(19, 242)
        Me.TXT_MOBILE_1.Name = "TXT_MOBILE_1"
        Me.TXT_MOBILE_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_MOBILE_1.Size = New System.Drawing.Size(405, 20)
        Me.TXT_MOBILE_1.TabIndex = 912
        '
        'TXT_PHONE
        '
        Me.TXT_PHONE.BackColor = System.Drawing.Color.White
        Me.TXT_PHONE.Location = New System.Drawing.Point(19, 293)
        Me.TXT_PHONE.Name = "TXT_PHONE"
        Me.TXT_PHONE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_PHONE.Size = New System.Drawing.Size(405, 20)
        Me.TXT_PHONE.TabIndex = 911
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(436, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 915
        Me.Label7.Text = "الايميل"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(436, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 910
        Me.Label8.Text = "الهاتف"
        '
        'TXT_MAIL
        '
        Me.TXT_MAIL.BackColor = System.Drawing.Color.White
        Me.TXT_MAIL.Location = New System.Drawing.Point(19, 322)
        Me.TXT_MAIL.Name = "TXT_MAIL"
        Me.TXT_MAIL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_MAIL.Size = New System.Drawing.Size(405, 20)
        Me.TXT_MAIL.TabIndex = 914
        '
        'TXT_MOBILE_2
        '
        Me.TXT_MOBILE_2.BackColor = System.Drawing.Color.White
        Me.TXT_MOBILE_2.Location = New System.Drawing.Point(19, 266)
        Me.TXT_MOBILE_2.Name = "TXT_MOBILE_2"
        Me.TXT_MOBILE_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_MOBILE_2.Size = New System.Drawing.Size(405, 20)
        Me.TXT_MOBILE_2.TabIndex = 913
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(436, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 909
        Me.Label9.Text = "موبايل 2"
        '
        'TXT_GUID_ACCOUNT
        '
        Me.TXT_GUID_ACCOUNT.BackColor = System.Drawing.Color.White
        Me.TXT_GUID_ACCOUNT.Location = New System.Drawing.Point(37, 378)
        Me.TXT_GUID_ACCOUNT.Name = "TXT_GUID_ACCOUNT"
        Me.TXT_GUID_ACCOUNT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_GUID_ACCOUNT.Size = New System.Drawing.Size(113, 20)
        Me.TXT_GUID_ACCOUNT.TabIndex = 918
        Me.TXT_GUID_ACCOUNT.Visible = False
        '
        'FRM_TRF2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 405)
        Me.Controls.Add(Me.TXT_GUID_ACCOUNT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_WEB)
        Me.Controls.Add(Me.TXT_MOBILE_1)
        Me.Controls.Add(Me.TXT_PHONE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_MAIL)
        Me.Controls.Add(Me.TXT_MOBILE_2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXT_CUNTRY)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT_STREET)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_JOB_COMPAN)
        Me.Controls.Add(Me.TXT_NAME_COMPANY)
        Me.Controls.Add(Me.TXT_LAST_NAME)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TXT_GUID_PARENT)
        Me.Controls.Add(Me.LB_LAST)
        Me.Controls.Add(Me.LB_FIRST)
        Me.Controls.Add(Me.LB_NEXT)
        Me.Controls.Add(Me.LBL_END)
        Me.Controls.Add(Me.TXT_iD)
        Me.Controls.Add(Me.TXT_GUID)
        Me.Controls.Add(Me.PIC_NEW)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.TXT_NAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FRM_TRF2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة زبون/مورد"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PIC_NEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_NEW As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_SAVE As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_UPDATE As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_DELETE As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TXT_GUID As System.Windows.Forms.TextBox
    Friend WithEvents TXT_GUID_PARENT As System.Windows.Forms.TextBox
    Public WithEvents PIC_NEW As System.Windows.Forms.PictureBox
    Public WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_NAME As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LB_LAST As System.Windows.Forms.Label
    Friend WithEvents LB_FIRST As System.Windows.Forms.Label
    Friend WithEvents LB_NEXT As System.Windows.Forms.Label
    Friend WithEvents LBL_END As System.Windows.Forms.Label
    Friend WithEvents TXT_iD As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_LAST_NAME As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_JOB_COMPAN As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NAME_COMPANY As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CUNTRY As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXT_STREET As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_WEB As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MOBILE_1 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PHONE As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_MAIL As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MOBILE_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXT_GUID_ACCOUNT As System.Windows.Forms.TextBox
End Class
