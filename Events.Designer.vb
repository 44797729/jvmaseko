<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Events
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txteventdistance = New System.Windows.Forms.TextBox()
        Me.txteventlocation = New System.Windows.Forms.TextBox()
        Me.txteventname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dpdateofevent = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtregistrationfee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(150, 256)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(473, 163)
        Me.DataGridView1.TabIndex = 23
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(367, 213)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(97, 27)
        Me.btndelete.TabIndex = 22
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(264, 213)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(97, 27)
        Me.btnupdate.TabIndex = 21
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(150, 213)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(97, 27)
        Me.btnadd.TabIndex = 20
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txteventdistance
        '
        Me.txteventdistance.Location = New System.Drawing.Point(150, 106)
        Me.txteventdistance.Name = "txteventdistance"
        Me.txteventdistance.Size = New System.Drawing.Size(222, 20)
        Me.txteventdistance.TabIndex = 19
        '
        'txteventlocation
        '
        Me.txteventlocation.Location = New System.Drawing.Point(150, 65)
        Me.txteventlocation.Name = "txteventlocation"
        Me.txteventlocation.Size = New System.Drawing.Size(222, 20)
        Me.txteventlocation.TabIndex = 18
        '
        'txteventname
        '
        Me.txteventname.Location = New System.Drawing.Point(150, 17)
        Me.txteventname.Name = "txteventname"
        Me.txteventname.Size = New System.Drawing.Size(222, 20)
        Me.txteventname.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Distance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Event Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Event Name"
        '
        'dpdateofevent
        '
        Me.dpdateofevent.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpdateofevent.Location = New System.Drawing.Point(150, 143)
        Me.dpdateofevent.Name = "dpdateofevent"
        Me.dpdateofevent.Size = New System.Drawing.Size(222, 20)
        Me.dpdateofevent.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Date of the event"
        '
        'txtregistrationfee
        '
        Me.txtregistrationfee.Location = New System.Drawing.Point(150, 179)
        Me.txtregistrationfee.Name = "txtregistrationfee"
        Me.txtregistrationfee.Size = New System.Drawing.Size(222, 20)
        Me.txtregistrationfee.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Registration Fee"
        '
        'Events
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 431)
        Me.Controls.Add(Me.txtregistrationfee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dpdateofevent)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txteventdistance)
        Me.Controls.Add(Me.txteventlocation)
        Me.Controls.Add(Me.txteventname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Events"
        Me.Text = "Events"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txteventdistance As System.Windows.Forms.TextBox
    Friend WithEvents txteventlocation As System.Windows.Forms.TextBox
    Friend WithEvents txteventname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dpdateofevent As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtregistrationfee As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
