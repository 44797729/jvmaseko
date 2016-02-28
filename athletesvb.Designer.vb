<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class athletesvb
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dpdateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.rbtfemale = New System.Windows.Forms.RadioButton()
        Me.rbtMale = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.datejoined = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtamountdue = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmembershipnumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(160, 24)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(222, 20)
        Me.txtfirstname.TabIndex = 0
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(160, 58)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(222, 20)
        Me.txtsurname.TabIndex = 1
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(160, 173)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(222, 55)
        Me.txtaddress.TabIndex = 3
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(105, 237)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(97, 27)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(219, 237)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(97, 27)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(322, 237)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(97, 27)
        Me.btndelete.TabIndex = 12
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(105, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(682, 162)
        Me.DataGridView1.TabIndex = 13
        '
        'dpdateofbirth
        '
        Me.dpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpdateofbirth.Location = New System.Drawing.Point(569, 24)
        Me.dpdateofbirth.Name = "dpdateofbirth"
        Me.dpdateofbirth.Size = New System.Drawing.Size(191, 20)
        Me.dpdateofbirth.TabIndex = 4
        '
        'rbtfemale
        '
        Me.rbtfemale.AutoSize = True
        Me.rbtfemale.Location = New System.Drawing.Point(623, 63)
        Me.rbtfemale.Name = "rbtfemale"
        Me.rbtfemale.Size = New System.Drawing.Size(59, 17)
        Me.rbtfemale.TabIndex = 6
        Me.rbtfemale.Text = "Female"
        Me.rbtfemale.UseVisualStyleBackColor = True
        '
        'rbtMale
        '
        Me.rbtMale.AutoSize = True
        Me.rbtMale.Checked = True
        Me.rbtMale.Location = New System.Drawing.Point(569, 63)
        Me.rbtMale.Name = "rbtMale"
        Me.rbtMale.Size = New System.Drawing.Size(48, 17)
        Me.rbtMale.TabIndex = 5
        Me.rbtMale.TabStop = True
        Me.rbtMale.Text = "Male"
        Me.rbtMale.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(450, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Date of Birth"
        '
        'datejoined
        '
        Me.datejoined.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datejoined.Location = New System.Drawing.Point(160, 97)
        Me.datejoined.Name = "datejoined"
        Me.datejoined.Size = New System.Drawing.Size(191, 20)
        Me.datejoined.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Date Joined"
        '
        'txtamountdue
        '
        Me.txtamountdue.Location = New System.Drawing.Point(569, 97)
        Me.txtamountdue.Name = "txtamountdue"
        Me.txtamountdue.Size = New System.Drawing.Size(207, 20)
        Me.txtamountdue.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(455, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Amount Due"
        '
        'txtmembershipnumber
        '
        Me.txtmembershipnumber.Location = New System.Drawing.Point(160, 132)
        Me.txtmembershipnumber.MaxLength = 14
        Me.txtmembershipnumber.Name = "txtmembershipnumber"
        Me.txtmembershipnumber.Size = New System.Drawing.Size(222, 20)
        Me.txtmembershipnumber.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Membership number"
        '
        'athletesvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 461)
        Me.Controls.Add(Me.txtmembershipnumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtamountdue)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.datejoined)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dpdateofbirth)
        Me.Controls.Add(Me.rbtfemale)
        Me.Controls.Add(Me.rbtMale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtsurname)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "athletesvb"
        Me.Text = "Athletes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dpdateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbtfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents datejoined As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtamountdue As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtmembershipnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
