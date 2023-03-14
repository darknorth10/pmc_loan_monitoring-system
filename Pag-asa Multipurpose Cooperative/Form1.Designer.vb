<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMMAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnreports = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnlogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btninventory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnmember = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbluser = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlmain = New System.Windows.Forms.Panel()
        Me.btnexit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lbltext = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnloantransaction = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnusemanagement = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btndashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Guna2Panel1.BorderRadius = 40
        Me.Guna2Panel1.Controls.Add(Me.btnreports)
        Me.Guna2Panel1.Controls.Add(Me.btnlogout)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.BunifuFlatButton2)
        Me.Guna2Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Guna2Panel1.Controls.Add(Me.btninventory)
        Me.Guna2Panel1.Controls.Add(Me.btnmember)
        Me.Guna2Panel1.Controls.Add(Me.btnloantransaction)
        Me.Guna2Panel1.Controls.Add(Me.btnusemanagement)
        Me.Guna2Panel1.Controls.Add(Me.btndashboard)
        Me.Guna2Panel1.Controls.Add(Me.Panel2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(261, 800)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnreports
        '
        Me.btnreports.Activecolor = System.Drawing.Color.Turquoise
        Me.btnreports.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnreports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnreports.BorderRadius = 0
        Me.btnreports.ButtonText = "Reports"
        Me.btnreports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreports.DisabledColor = System.Drawing.Color.Gray
        Me.btnreports.Iconcolor = System.Drawing.Color.Transparent
        Me.btnreports.Iconimage = Nothing
        Me.btnreports.Iconimage_right = Nothing
        Me.btnreports.Iconimage_right_Selected = Nothing
        Me.btnreports.Iconimage_Selected = Nothing
        Me.btnreports.IconMarginLeft = 0
        Me.btnreports.IconMarginRight = 0
        Me.btnreports.IconRightVisible = True
        Me.btnreports.IconRightZoom = 0R
        Me.btnreports.IconVisible = True
        Me.btnreports.IconZoom = 50.0R
        Me.btnreports.IsTab = False
        Me.btnreports.Location = New System.Drawing.Point(-1, 599)
        Me.btnreports.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.btnreports.OnHovercolor = System.Drawing.Color.Turquoise
        Me.btnreports.OnHoverTextColor = System.Drawing.Color.White
        Me.btnreports.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnreports.selected = False
        Me.btnreports.Size = New System.Drawing.Size(261, 52)
        Me.btnreports.TabIndex = 15
        Me.btnreports.Text = "Reports"
        Me.btnreports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnreports.Textcolor = System.Drawing.Color.Black
        Me.btnreports.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnlogout
        '
        Me.btnlogout.Activecolor = System.Drawing.Color.Turquoise
        Me.btnlogout.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogout.BorderRadius = 0
        Me.btnlogout.ButtonText = "Logout"
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.DisabledColor = System.Drawing.Color.Gray
        Me.btnlogout.Iconcolor = System.Drawing.Color.Transparent
        Me.btnlogout.Iconimage = Nothing
        Me.btnlogout.Iconimage_right = Nothing
        Me.btnlogout.Iconimage_right_Selected = Nothing
        Me.btnlogout.Iconimage_Selected = Nothing
        Me.btnlogout.IconMarginLeft = 0
        Me.btnlogout.IconMarginRight = 0
        Me.btnlogout.IconRightVisible = True
        Me.btnlogout.IconRightZoom = 0R
        Me.btnlogout.IconVisible = True
        Me.btnlogout.IconZoom = 65.0R
        Me.btnlogout.IsTab = False
        Me.btnlogout.Location = New System.Drawing.Point(-3, 708)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.btnlogout.OnHovercolor = System.Drawing.Color.Turquoise
        Me.btnlogout.OnHoverTextColor = System.Drawing.Color.White
        Me.btnlogout.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnlogout.selected = False
        Me.btnlogout.Size = New System.Drawing.Size(261, 41)
        Me.btnlogout.TabIndex = 14
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnlogout.Textcolor = System.Drawing.Color.Black
        Me.btnlogout.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 5.8!)
        Me.Label1.Location = New System.Drawing.Point(7, 780)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "version 1.0.0.beta"
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Turquoise
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "About Us"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 60.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(-1, 655)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Turquoise
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(261, 44)
        Me.BunifuFlatButton2.TabIndex = 12
        Me.BunifuFlatButton2.Text = "About Us"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Turquoise
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Settings"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(-1, 542)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Turquoise
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(261, 52)
        Me.BunifuFlatButton1.TabIndex = 11
        Me.BunifuFlatButton1.Text = "Settings"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btninventory
        '
        Me.btninventory.Activecolor = System.Drawing.Color.Turquoise
        Me.btninventory.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btninventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btninventory.BorderRadius = 0
        Me.btninventory.ButtonText = "Inventory Management"
        Me.btninventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninventory.DisabledColor = System.Drawing.Color.Gray
        Me.btninventory.Iconcolor = System.Drawing.Color.Transparent
        Me.btninventory.Iconimage = Nothing
        Me.btninventory.Iconimage_right = Nothing
        Me.btninventory.Iconimage_right_Selected = Nothing
        Me.btninventory.Iconimage_Selected = Nothing
        Me.btninventory.IconMarginLeft = 0
        Me.btninventory.IconMarginRight = 0
        Me.btninventory.IconRightVisible = True
        Me.btninventory.IconRightZoom = 0R
        Me.btninventory.IconVisible = True
        Me.btninventory.IconZoom = 40.0R
        Me.btninventory.IsTab = False
        Me.btninventory.Location = New System.Drawing.Point(-1, 478)
        Me.btninventory.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btninventory.Name = "btninventory"
        Me.btninventory.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.btninventory.OnHovercolor = System.Drawing.Color.Turquoise
        Me.btninventory.OnHoverTextColor = System.Drawing.Color.White
        Me.btninventory.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btninventory.selected = False
        Me.btninventory.Size = New System.Drawing.Size(261, 59)
        Me.btninventory.TabIndex = 10
        Me.btninventory.Text = "Inventory Management"
        Me.btninventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btninventory.Textcolor = System.Drawing.Color.Black
        Me.btninventory.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnmember
        '
        Me.btnmember.Activecolor = System.Drawing.Color.Turquoise
        Me.btnmember.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnmember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmember.BorderRadius = 0
        Me.btnmember.ButtonText = "Member Management"
        Me.btnmember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmember.DisabledColor = System.Drawing.Color.Gray
        Me.btnmember.Iconcolor = System.Drawing.Color.Transparent
        Me.btnmember.Iconimage = Nothing
        Me.btnmember.Iconimage_right = Nothing
        Me.btnmember.Iconimage_right_Selected = Nothing
        Me.btnmember.Iconimage_Selected = Nothing
        Me.btnmember.IconMarginLeft = 0
        Me.btnmember.IconMarginRight = 0
        Me.btnmember.IconRightVisible = True
        Me.btnmember.IconRightZoom = 0R
        Me.btnmember.IconVisible = True
        Me.btnmember.IconZoom = 40.0R
        Me.btnmember.IsTab = False
        Me.btnmember.Location = New System.Drawing.Point(-1, 412)
        Me.btnmember.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnmember.Name = "btnmember"
        Me.btnmember.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.btnmember.OnHovercolor = System.Drawing.Color.Turquoise
        Me.btnmember.OnHoverTextColor = System.Drawing.Color.White
        Me.btnmember.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnmember.selected = False
        Me.btnmember.Size = New System.Drawing.Size(261, 59)
        Me.btnmember.TabIndex = 9
        Me.btnmember.Text = "Member Management"
        Me.btnmember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnmember.Textcolor = System.Drawing.Color.Black
        Me.btnmember.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel2.Controls.Add(Me.lbluser)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 190)
        Me.Panel2.TabIndex = 5
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.MediumTurquoise
        Me.lbluser.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(93, 140)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.lbluser.Size = New System.Drawing.Size(72, 30)
        Me.lbluser.TabIndex = 4
        Me.lbluser.Text = "ADMIN"
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlmain
        '
        Me.pnlmain.BackColor = System.Drawing.Color.GhostWhite
        Me.pnlmain.Location = New System.Drawing.Point(281, 62)
        Me.pnlmain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(1187, 720)
        Me.pnlmain.TabIndex = 1
        '
        'btnexit
        '
        Me.btnexit.Activecolor = System.Drawing.Color.RosyBrown
        Me.btnexit.BackColor = System.Drawing.Color.Firebrick
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexit.BorderRadius = 0
        Me.btnexit.ButtonText = "X"
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.DisabledColor = System.Drawing.Color.Gray
        Me.btnexit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnexit.Iconimage = Nothing
        Me.btnexit.Iconimage_right = Nothing
        Me.btnexit.Iconimage_right_Selected = Nothing
        Me.btnexit.Iconimage_Selected = Nothing
        Me.btnexit.IconMarginLeft = 0
        Me.btnexit.IconMarginRight = 0
        Me.btnexit.IconRightVisible = True
        Me.btnexit.IconRightZoom = 0R
        Me.btnexit.IconVisible = True
        Me.btnexit.IconZoom = 90.0R
        Me.btnexit.IsTab = False
        Me.btnexit.Location = New System.Drawing.Point(1429, -2)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Normalcolor = System.Drawing.Color.Firebrick
        Me.btnexit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnexit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnexit.selected = False
        Me.btnexit.Size = New System.Drawing.Size(59, 38)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "X"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnexit.Textcolor = System.Drawing.Color.White
        Me.btnexit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.BackColor = System.Drawing.Color.GhostWhite
        Me.lbltext.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext.Location = New System.Drawing.Point(277, 9)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Padding = New System.Windows.Forms.Padding(40, 10, 5, 10)
        Me.lbltext.Size = New System.Drawing.Size(188, 50)
        Me.lbltext.TabIndex = 5
        Me.lbltext.Text = "Dashboard"
        Me.lbltext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnloantransaction
        '
        Me.btnloantransaction.Activecolor = System.Drawing.Color.Turquoise
        Me.btnloantransaction.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnloantransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnloantransaction.BorderRadius = 0
        Me.btnloantransaction.ButtonText = "Loan Transaction"
        Me.btnloantransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnloantransaction.DisabledColor = System.Drawing.Color.Gray
        Me.btnloantransaction.Iconcolor = System.Drawing.Color.Transparent
        Me.btnloantransaction.Iconimage = Global.Pag_asa_Multipurpose_Cooperative.My.Resources.Resources.transaction
        Me.btnloantransaction.Iconimage_right = Nothing
        Me.btnloantransaction.Iconimage_right_Selected = Nothing
        Me.btnloantransaction.Iconimage_Selected = Nothing
        Me.btnloantransaction.IconMarginLeft = 0
        Me.btnloantransaction.IconMarginRight = 0
        Me.btnloantransaction.IconRightVisible = True
        Me.btnloantransaction.IconRightZoom = 0R
        Me.btnloantransaction.IconVisible = True
        Me.btnloantransaction.IconZoom = 50.0R
        Me.btnloantransaction.IsTab = False
        Me.btnloantransaction.Location = New System.Drawing.Point(-3, 347)
        Me.btnloantransaction.Margin = New System.Windows.Forms.Padding(5)
        Me.btnloantransaction.Name = "btnloantransaction"
        Me.btnloantransaction.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.btnloantransaction.OnHovercolor = System.Drawing.Color.Turquoise
        Me.btnloantransaction.OnHoverTextColor = System.Drawing.Color.White
        Me.btnloantransaction.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnloantransaction.selected = False
        Me.btnloantransaction.Size = New System.Drawing.Size(261, 59)
        Me.btnloantransaction.TabIndex = 8
        Me.btnloantransaction.Text = "Loan Transaction"
        Me.btnloantransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnloantransaction.Textcolor = System.Drawing.Color.Black
        Me.btnloantransaction.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnusemanagement
        '
        Me.btnusemanagement.Activecolor = System.Drawing.Color.Turquoise
        Me.btnusemanagement.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnusemanagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnusemanagement.BorderRadius = 0
        Me.btnusemanagement.ButtonText = "User Management"
        Me.btnusemanagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnusemanagement.DisabledColor = System.Drawing.Color.Gray
        Me.btnusemanagement.Iconcolor = System.Drawing.Color.Transparent
        Me.btnusemanagement.Iconimage = Global.Pag_asa_Multipurpose_Cooperative.My.Resources.Resources.group
        Me.btnusemanagement.Iconimage_right = Nothing
        Me.btnusemanagement.Iconimage_right_Selected = Nothing
        Me.btnusemanagement.Iconimage_Selected = Nothing
        Me.btnusemanagement.IconMarginLeft = 0
        Me.btnusemanagement.IconMarginRight = 0
        Me.btnusemanagement.IconRightVisible = True
        Me.btnusemanagement.IconRightZoom = 0R
        Me.btnusemanagement.IconVisible = True
        Me.btnusemanagement.IconZoom = 40.0R
        Me.btnusemanagement.IsTab = False
        Me.btnusemanagement.Location = New System.Drawing.Point(-3, 283)
        Me.btnusemanagement.Margin = New System.Windows.Forms.Padding(5)
        Me.btnusemanagement.Name = "btnusemanagement"
        Me.btnusemanagement.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.btnusemanagement.OnHovercolor = System.Drawing.Color.Turquoise
        Me.btnusemanagement.OnHoverTextColor = System.Drawing.Color.White
        Me.btnusemanagement.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnusemanagement.selected = False
        Me.btnusemanagement.Size = New System.Drawing.Size(261, 59)
        Me.btnusemanagement.TabIndex = 7
        Me.btnusemanagement.Text = "User Management"
        Me.btnusemanagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnusemanagement.Textcolor = System.Drawing.Color.Black
        Me.btnusemanagement.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btndashboard
        '
        Me.btndashboard.Activecolor = System.Drawing.Color.Turquoise
        Me.btndashboard.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndashboard.BorderRadius = 0
        Me.btndashboard.ButtonText = "Dashboard"
        Me.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndashboard.DisabledColor = System.Drawing.Color.SlateGray
        Me.btndashboard.ForeColor = System.Drawing.Color.Transparent
        Me.btndashboard.Iconcolor = System.Drawing.Color.Transparent
        Me.btndashboard.Iconimage = Global.Pag_asa_Multipurpose_Cooperative.My.Resources.Resources.dashboard
        Me.btndashboard.Iconimage_right = Nothing
        Me.btndashboard.Iconimage_right_Selected = Nothing
        Me.btndashboard.Iconimage_Selected = Nothing
        Me.btndashboard.IconMarginLeft = 20
        Me.btndashboard.IconMarginRight = 0
        Me.btndashboard.IconRightVisible = True
        Me.btndashboard.IconRightZoom = 0R
        Me.btndashboard.IconVisible = True
        Me.btndashboard.IconZoom = 40.0R
        Me.btndashboard.IsTab = False
        Me.btndashboard.Location = New System.Drawing.Point(-3, 217)
        Me.btndashboard.Margin = New System.Windows.Forms.Padding(5)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.btndashboard.OnHovercolor = System.Drawing.Color.Turquoise
        Me.btndashboard.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.btndashboard.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btndashboard.selected = False
        Me.btndashboard.Size = New System.Drawing.Size(261, 59)
        Me.btndashboard.TabIndex = 6
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btndashboard.Textcolor = System.Drawing.Color.Black
        Me.btndashboard.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Guna2PictureBox1.Image = Global.Pag_asa_Multipurpose_Cooperative.My.Resources.Resources.profile
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(76, 26)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(105, 95)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'FRMMAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1485, 794)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbltext)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.pnlmain)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FRMMAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mul"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlmain As Panel
    Friend WithEvents btnexit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lbluser As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btndashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnloantransaction As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnusemanagement As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnmember As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btninventory As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltext As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnlogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnreports As Bunifu.Framework.UI.BunifuFlatButton
End Class
