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
        Me.components = New System.ComponentModel.Container()
        Me.btnadduser = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnclearuser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdateuser = New Guna.UI2.WinForms.Guna2Button()

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
        Me.GroupBox1.Size = New System.Drawing.Size(1169, 163)
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

        'userctrlusermanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White

        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "userctrlusermanagement"
        Me.Size = New System.Drawing.Size(1186, 720)
        Me.GroupBox1.ResumeLayout(False)

        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnadduser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnclearuser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdateuser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox


End Class
