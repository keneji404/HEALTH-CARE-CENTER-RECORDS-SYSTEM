<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.lbl_Pass = New System.Windows.Forms.Label()
        Me.lbl_User = New System.Windows.Forms.Label()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.btn_Forgot = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_Create = New System.Windows.Forms.Button()
        Me.lbl_RecoverCode = New System.Windows.Forms.Label()
        Me.txt_RecoverCode = New System.Windows.Forms.TextBox()
        Me.pic_Exit = New System.Windows.Forms.PictureBox()
        Me.pic_Minimize = New System.Windows.Forms.PictureBox()
        Me.pic_Eye2 = New System.Windows.Forms.PictureBox()
        Me.pic_Eye = New System.Windows.Forms.PictureBox()
        Me.umbrella_logo = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Eye2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Eye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        resources.ApplyResources(Me.lbl_Title, "lbl_Title")
        Me.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Title.Name = "lbl_Title"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.username, "username")
        Me.username.Name = "username"
        '
        'password
        '
        Me.password.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.password, "password")
        Me.password.Name = "password"
        Me.password.UseSystemPasswordChar = True
        '
        'lbl_Pass
        '
        resources.ApplyResources(Me.lbl_Pass, "lbl_Pass")
        Me.lbl_Pass.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_Pass.Name = "lbl_Pass"
        '
        'lbl_User
        '
        resources.ApplyResources(Me.lbl_User, "lbl_User")
        Me.lbl_User.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_User.Name = "lbl_User"
        '
        'btn_Login
        '
        resources.ApplyResources(Me.btn_Login, "btn_Login")
        Me.btn_Login.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'btn_Forgot
        '
        resources.ApplyResources(Me.btn_Forgot, "btn_Forgot")
        Me.btn_Forgot.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Forgot.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Forgot.Name = "btn_Forgot"
        Me.btn_Forgot.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem})
        resources.ApplyResources(Me.LoginToolStripMenuItem, "LoginToolStripMenuItem")
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk
        Me.LoginToolStripMenuItem.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.Artboard_9_512
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        resources.ApplyResources(Me.AdminToolStripMenuItem, "AdminToolStripMenuItem")
        '
        'btn_Create
        '
        resources.ApplyResources(Me.btn_Create, "btn_Create")
        Me.btn_Create.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Create.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Create.Name = "btn_Create"
        Me.btn_Create.UseVisualStyleBackColor = True
        '
        'lbl_RecoverCode
        '
        resources.ApplyResources(Me.lbl_RecoverCode, "lbl_RecoverCode")
        Me.lbl_RecoverCode.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_RecoverCode.Name = "lbl_RecoverCode"
        '
        'txt_RecoverCode
        '
        Me.txt_RecoverCode.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_RecoverCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txt_RecoverCode, "txt_RecoverCode")
        Me.txt_RecoverCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_RecoverCode.Name = "txt_RecoverCode"
        Me.txt_RecoverCode.UseSystemPasswordChar = True
        '
        'pic_Exit
        '
        Me.pic_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Exit.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.exit2
        resources.ApplyResources(Me.pic_Exit, "pic_Exit")
        Me.pic_Exit.Name = "pic_Exit"
        Me.pic_Exit.TabStop = False
        '
        'pic_Minimize
        '
        Me.pic_Minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_Minimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Minimize.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.minimize2
        resources.ApplyResources(Me.pic_Minimize, "pic_Minimize")
        Me.pic_Minimize.Name = "pic_Minimize"
        Me.pic_Minimize.TabStop = False
        '
        'pic_Eye2
        '
        Me.pic_Eye2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pic_Eye2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Eye2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_Eye2.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.show_password
        resources.ApplyResources(Me.pic_Eye2, "pic_Eye2")
        Me.pic_Eye2.Name = "pic_Eye2"
        Me.pic_Eye2.TabStop = False
        '
        'pic_Eye
        '
        Me.pic_Eye.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pic_Eye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Eye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_Eye.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.show_password
        resources.ApplyResources(Me.pic_Eye, "pic_Eye")
        Me.pic_Eye.Name = "pic_Eye"
        Me.pic_Eye.TabStop = False
        '
        'umbrella_logo
        '
        Me.umbrella_logo.BackColor = System.Drawing.Color.Transparent
        Me.umbrella_logo.BackgroundImage = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.umbrella_clinic_final
        resources.ApplyResources(Me.umbrella_logo, "umbrella_logo")
        Me.umbrella_logo.FlatAppearance.BorderSize = 0
        Me.umbrella_logo.Name = "umbrella_logo"
        Me.umbrella_logo.TabStop = False
        Me.umbrella_logo.Tag = ""
        Me.umbrella_logo.UseVisualStyleBackColor = False
        '
        'loginform
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.pic_Exit)
        Me.Controls.Add(Me.pic_Minimize)
        Me.Controls.Add(Me.pic_Eye2)
        Me.Controls.Add(Me.pic_Eye)
        Me.Controls.Add(Me.btn_Forgot)
        Me.Controls.Add(Me.btn_Create)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.lbl_RecoverCode)
        Me.Controls.Add(Me.lbl_User)
        Me.Controls.Add(Me.lbl_Pass)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.txt_RecoverCode)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.umbrella_logo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "loginform"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Eye2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Eye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Title As Label
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents lbl_Pass As Label
    Friend WithEvents lbl_User As Label
    Friend WithEvents btn_Login As Button
    Friend WithEvents btn_Forgot As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pic_Eye As PictureBox
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents pic_Minimize As PictureBox
    Friend WithEvents umbrella_logo As Button
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_Create As Button
    Friend WithEvents lbl_RecoverCode As Label
    Friend WithEvents txt_RecoverCode As TextBox
    Friend WithEvents pic_Eye2 As PictureBox
End Class
