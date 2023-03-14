<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userctrlusermanagement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnadduser = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnclearuser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdateuser = New Guna.UI2.WinForms.Guna2Button()
        Me.txtreguser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtregpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtconfirmpass = New System.Windows.Forms.TextBox()
        Me.cbout = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnadduser
        '
        Me.btnadduser.BackColor = System.Drawing.Color.Transparent
        Me.btnadduser.BorderRadius = 20
        Me.btnadduser.CheckedState.Parent = Me.btnadduser
        Me.btnadduser.CustomImages.Parent = Me.btnadduser
        Me.btnadduser.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnadduser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnadduser.ForeColor = System.Drawing.Color.White
        Me.btnadduser.HoverState.Parent = Me.btnadduser
        Me.btnadduser.Location = New System.Drawing.Point(183, 92)
        Me.btnadduser.Name = "btnadduser"
        Me.btnadduser.PressedColor = System.Drawing.Color.DimGray
        Me.btnadduser.ShadowDecoration.Parent = Me.btnadduser
        Me.btnadduser.Size = New System.Drawing.Size(168, 44)
        Me.btnadduser.TabIndex = 0
        Me.btnadduser.Text = "Add User"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Guna2TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnclearuser)
        Me.GroupBox1.Controls.Add(Me.btnupdateuser)
        Me.GroupBox1.Controls.Add(Me.btnadduser)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(1169, 162)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "    Action Bar    "
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.White
        Me.Guna2TextBox1.BorderRadius = 20
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.IconLeft = Global.Pag_asa_Multipurpose_Cooperative.My.Resources.Resources.search_interface_symbol
        Me.Guna2TextBox1.IconLeftOffset = New System.Drawing.Point(50, 0)
        Me.Guna2TextBox1.Location = New System.Drawing.Point(183, 31)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Search"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(810, 45)
        Me.Guna2TextBox1.TabIndex = 0
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnclearuser
        '
        Me.btnclearuser.BackColor = System.Drawing.Color.Transparent
        Me.btnclearuser.BorderRadius = 20
        Me.btnclearuser.CheckedState.Parent = Me.btnclearuser
        Me.btnclearuser.CustomImages.Parent = Me.btnclearuser
        Me.btnclearuser.Enabled = False
        Me.btnclearuser.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnclearuser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnclearuser.ForeColor = System.Drawing.Color.White
        Me.btnclearuser.HoverState.Parent = Me.btnclearuser
        Me.btnclearuser.Location = New System.Drawing.Point(825, 92)
        Me.btnclearuser.Name = "btnclearuser"
        Me.btnclearuser.PressedColor = System.Drawing.Color.DimGray
        Me.btnclearuser.ShadowDecoration.Parent = Me.btnclearuser
        Me.btnclearuser.Size = New System.Drawing.Size(168, 44)
        Me.btnclearuser.TabIndex = 2
        Me.btnclearuser.Text = "Clear"
        '
        'btnupdateuser
        '
        Me.btnupdateuser.BackColor = System.Drawing.Color.Transparent
        Me.btnupdateuser.BorderRadius = 20
        Me.btnupdateuser.CheckedState.Parent = Me.btnupdateuser
        Me.btnupdateuser.CustomImages.Parent = Me.btnupdateuser
        Me.btnupdateuser.Enabled = False
        Me.btnupdateuser.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnupdateuser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnupdateuser.ForeColor = System.Drawing.Color.White
        Me.btnupdateuser.HoverState.Parent = Me.btnupdateuser
        Me.btnupdateuser.Location = New System.Drawing.Point(503, 92)
        Me.btnupdateuser.Name = "btnupdateuser"
        Me.btnupdateuser.PressedColor = System.Drawing.Color.DimGray
        Me.btnupdateuser.ShadowDecoration.Parent = Me.btnupdateuser
        Me.btnupdateuser.Size = New System.Drawing.Size(168, 44)
        Me.btnupdateuser.TabIndex = 1
        Me.btnupdateuser.Text = "Update"
        '
        'txtreguser
        '
        Me.txtreguser.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.txtreguser.Location = New System.Drawing.Point(362, 193)
        Me.txtreguser.Name = "txtreguser"
        Me.txtreguser.Size = New System.Drawing.Size(157, 28)
        Me.txtreguser.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label1.Location = New System.Drawing.Point(255, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label2.Location = New System.Drawing.Point(255, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'txtregpass
        '
        Me.txtregpass.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.txtregpass.Location = New System.Drawing.Point(362, 251)
        Me.txtregpass.Name = "txtregpass"
        Me.txtregpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtregpass.Size = New System.Drawing.Size(157, 28)
        Me.txtregpass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label3.Location = New System.Drawing.Point(179, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Re-enter Password"
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.txtconfirmpass.Location = New System.Drawing.Point(362, 310)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpass.Size = New System.Drawing.Size(157, 28)
        Me.txtconfirmpass.TabIndex = 6
        '
        'cbout
        '
        Me.cbout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbout.FormattingEnabled = True
        Me.cbout.Items.AddRange(New Object() {"admin", "secretary", "loan officer"})
        Me.cbout.Location = New System.Drawing.Point(756, 194)
        Me.cbout.Name = "cbout"
        Me.cbout.Size = New System.Drawing.Size(149, 28)
        Me.cbout.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label4.Location = New System.Drawing.Point(646, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "User Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label5.Location = New System.Drawing.Point(674, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Status"
        '
        'cbostatus
        '
        Me.cbostatus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"active", "inacive"})
        Me.cbostatus.Location = New System.Drawing.Point(756, 253)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(149, 28)
        Me.cbostatus.TabIndex = 10
        '
        'userctrlusermanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbostatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtconfirmpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtregpass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtreguser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "userctrlusermanagement"
        Me.Size = New System.Drawing.Size(1186, 720)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnadduser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnclearuser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdateuser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtreguser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtregpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtconfirmpass As TextBox
    Friend WithEvents cbout As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbostatus As ComboBox
End Class
