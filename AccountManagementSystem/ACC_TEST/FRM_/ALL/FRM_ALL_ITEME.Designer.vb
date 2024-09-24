<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ALL_ITEME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ALL_ITEME))
        Me.TXT_SEARSH = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.guid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEME_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.it = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.M_Whole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_Half = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_EndUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_Vendor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_Export = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_Retail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_LastPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_SEARSH
        '
        Me.TXT_SEARSH.Location = New System.Drawing.Point(191, 15)
        Me.TXT_SEARSH.Name = "TXT_SEARSH"
        Me.TXT_SEARSH.Size = New System.Drawing.Size(322, 20)
        Me.TXT_SEARSH.TabIndex = 0
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.guid, Me.barcode1, Me.ITEME_name, Me.unit1, Me.balance, Me.it, Me.M_Whole, Me.M_Half, Me.M_EndUser, Me.M_Vendor, Me.M_Export, Me.M_Retail, Me.M_LastPrice})
        Me.DGV.Location = New System.Drawing.Point(12, 41)
        Me.DGV.Name = "DGV"
        Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(657, 270)
        Me.DGV.TabIndex = 1
        '
        'guid
        '
        Me.guid.FillWeight = 89.54314!
        Me.guid.HeaderText = "guid"
        Me.guid.Name = "guid"
        Me.guid.Visible = False
        Me.guid.Width = 101
        '
        'barcode1
        '
        Me.barcode1.FillWeight = 89.54314!
        Me.barcode1.HeaderText = "باركود وحدة1"
        Me.barcode1.Name = "barcode1"
        Me.barcode1.ReadOnly = True
        '
        'ITEME_name
        '
        Me.ITEME_name.FillWeight = 89.54314!
        Me.ITEME_name.HeaderText = "اسم المادة"
        Me.ITEME_name.Name = "ITEME_name"
        Me.ITEME_name.ReadOnly = True
        Me.ITEME_name.Width = 250
        '
        'unit1
        '
        Me.unit1.FillWeight = 89.54314!
        Me.unit1.HeaderText = "الوحدة1"
        Me.unit1.Name = "unit1"
        Me.unit1.ReadOnly = True
        Me.unit1.Width = 101
        '
        'balance
        '
        Me.balance.FillWeight = 89.54314!
        Me.balance.HeaderText = "الرصيد"
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        Me.balance.Width = 101
        '
        'it
        '
        Me.it.FillWeight = 152.2843!
        Me.it.HeaderText = "تحديد"
        Me.it.Name = "it"
        Me.it.Width = 50
        '
        'M_Whole
        '
        Me.M_Whole.HeaderText = "الجملة"
        Me.M_Whole.Name = "M_Whole"
        Me.M_Whole.Visible = False
        '
        'M_Half
        '
        Me.M_Half.HeaderText = "نصف الجملة"
        Me.M_Half.Name = "M_Half"
        Me.M_Half.Visible = False
        '
        'M_EndUser
        '
        Me.M_EndUser.HeaderText = "المستهلك"
        Me.M_EndUser.Name = "M_EndUser"
        Me.M_EndUser.Visible = False
        '
        'M_Vendor
        '
        Me.M_Vendor.HeaderText = "الموزع"
        Me.M_Vendor.Name = "M_Vendor"
        Me.M_Vendor.Visible = False
        '
        'M_Export
        '
        Me.M_Export.HeaderText = "التصدير"
        Me.M_Export.Name = "M_Export"
        Me.M_Export.Visible = False
        '
        'M_Retail
        '
        Me.M_Retail.HeaderText = "المفرق"
        Me.M_Retail.Name = "M_Retail"
        Me.M_Retail.Visible = False
        '
        'M_LastPrice
        '
        Me.M_LastPrice.HeaderText = "اخر شراء"
        Me.M_LastPrice.Name = "M_LastPrice"
        Me.M_LastPrice.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.ACC_TEST.My.Resources.Resources.add
        Me.Button1.Location = New System.Drawing.Point(12, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'FRM_ALL_ITEME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 323)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TXT_SEARSH)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_ALL_ITEME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بحث"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_SEARSH As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents guid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEME_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents it As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents M_Whole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Half As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_EndUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Vendor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Export As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_Retail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_LastPrice As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
