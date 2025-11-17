<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recover
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recover))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RecoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pic_Exit = New System.Windows.Forms.PictureBox()
        Me.pic_Minimize = New System.Windows.Forms.PictureBox()
        Me.umbrella_logo = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.btn_Recover = New System.Windows.Forms.Button()
        Me.lbl_RecoverCode = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_RecoverCode = New System.Windows.Forms.TextBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.pic_Eye = New System.Windows.Forms.PictureBox()
        Me.pic_Eye2 = New System.Windows.Forms.PictureBox()
        Me.txt_User = New System.Windows.Forms.TextBox()
        Me.lbl_User = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Eye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Eye2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecoverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(400, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RecoverToolStripMenuItem
        '
        Me.RecoverToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.RecoverToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.RecoverToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk
        Me.RecoverToolStripMenuItem.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.forgot_pass
        Me.RecoverToolStripMenuItem.Name = "RecoverToolStripMenuItem"
        Me.RecoverToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.RecoverToolStripMenuItem.Text = "RECOVER PASSWORD"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'pic_Exit
        '
        Me.pic_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Exit.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.exit2
        Me.pic_Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Exit.Location = New System.Drawing.Point(374, 0)
        Me.pic_Exit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Exit.Name = "pic_Exit"
        Me.pic_Exit.Size = New System.Drawing.Size(26, 28)
        Me.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Exit.TabIndex = 12
        Me.pic_Exit.TabStop = False
        '
        'pic_Minimize
        '
        Me.pic_Minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_Minimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Minimize.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.minimize2
        Me.pic_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Minimize.Location = New System.Drawing.Point(350, 0)
        Me.pic_Minimize.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Minimize.Name = "pic_Minimize"
        Me.pic_Minimize.Size = New System.Drawing.Size(24, 28)
        Me.pic_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Minimize.TabIndex = 11
        Me.pic_Minimize.TabStop = False
        '
        'umbrella_logo
        '
        Me.umbrella_logo.BackColor = System.Drawing.Color.Transparent
        Me.umbrella_logo.BackgroundImage = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.umbrella_clinic_final
        Me.umbrella_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.umbrella_logo.Enabled = False
        Me.umbrella_logo.FlatAppearance.BorderSize = 0
        Me.umbrella_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.umbrella_logo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.umbrella_logo.Location = New System.Drawing.Point(139, 35)
        Me.umbrella_logo.Name = "umbrella_logo"
        Me.umbrella_logo.Size = New System.Drawing.Size(123, 114)
        Me.umbrella_logo.TabIndex = 13
        Me.umbrella_logo.TabStop = False
        Me.umbrella_logo.Tag = ""
        Me.umbrella_logo.UseVisualStyleBackColor = False
        '
        'lbl_Title
        '
        Me.lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_Title.Location = New System.Drawing.Point(5, 161)
        Me.lbl_Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(389, 43)
        Me.lbl_Title.TabIndex = 14
        Me.lbl_Title.Text = "Health Care Center Records System"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_Recover
        '
        Me.btn_Recover.AutoSize = True
        Me.btn_Recover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Recover.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Recover.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Recover.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_Recover.Location = New System.Drawing.Point(139, 298)
        Me.btn_Recover.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Recover.Name = "btn_Recover"
        Me.btn_Recover.Size = New System.Drawing.Size(123, 27)
        Me.btn_Recover.TabIndex = 4
        Me.btn_Recover.Text = "Recover"
        Me.btn_Recover.UseVisualStyleBackColor = True
        '
        'lbl_RecoverCode
        '
        Me.lbl_RecoverCode.AutoSize = True
        Me.lbl_RecoverCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_RecoverCode.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_RecoverCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_RecoverCode.Location = New System.Drawing.Point(32, 240)
        Me.lbl_RecoverCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_RecoverCode.Name = "lbl_RecoverCode"
        Me.lbl_RecoverCode.Size = New System.Drawing.Size(117, 20)
        Me.lbl_RecoverCode.TabIndex = 15
        Me.lbl_RecoverCode.Text = "Recovery Code"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_Password.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_Password.Location = New System.Drawing.Point(71, 269)
        Me.lbl_Password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(78, 20)
        Me.lbl_Password.TabIndex = 16
        Me.lbl_Password.Text = "Password"
        Me.lbl_Password.Visible = False
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_Password.Location = New System.Drawing.Point(153, 269)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.ReadOnly = True
        Me.txt_Password.Size = New System.Drawing.Size(157, 23)
        Me.txt_Password.TabIndex = 3
        Me.txt_Password.Visible = False
        '
        'txt_RecoverCode
        '
        Me.txt_RecoverCode.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_RecoverCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RecoverCode.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_RecoverCode.Location = New System.Drawing.Point(153, 240)
        Me.txt_RecoverCode.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_RecoverCode.Name = "txt_RecoverCode"
        Me.txt_RecoverCode.Size = New System.Drawing.Size(157, 23)
        Me.txt_RecoverCode.TabIndex = 2
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_Cancel.Location = New System.Drawing.Point(139, 346)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(123, 27)
        Me.btn_Cancel.TabIndex = 5
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'pic_Eye
        '
        Me.pic_Eye.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pic_Eye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Eye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_Eye.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.show_password
        Me.pic_Eye.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Eye.Location = New System.Drawing.Point(309, 240)
        Me.pic_Eye.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Eye.Name = "pic_Eye"
        Me.pic_Eye.Size = New System.Drawing.Size(21, 23)
        Me.pic_Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Eye.TabIndex = 17
        Me.pic_Eye.TabStop = False
        '
        'pic_Eye2
        '
        Me.pic_Eye2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pic_Eye2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Eye2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_Eye2.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.show_password
        Me.pic_Eye2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Eye2.Location = New System.Drawing.Point(309, 269)
        Me.pic_Eye2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Eye2.Name = "pic_Eye2"
        Me.pic_Eye2.Size = New System.Drawing.Size(21, 23)
        Me.pic_Eye2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Eye2.TabIndex = 18
        Me.pic_Eye2.TabStop = False
        Me.pic_Eye2.Visible = False
        '
        'txt_User
        '
        Me.txt_User.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_User.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_User.Location = New System.Drawing.Point(153, 211)
        Me.txt_User.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_User.Name = "txt_User"
        Me.txt_User.ReadOnly = True
        Me.txt_User.Size = New System.Drawing.Size(157, 23)
        Me.txt_User.TabIndex = 1
        Me.txt_User.Visible = False
        '
        'lbl_User
        '
        Me.lbl_User.AutoSize = True
        Me.lbl_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_User.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_User.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_User.Location = New System.Drawing.Point(66, 211)
        Me.lbl_User.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_User.Name = "lbl_User"
        Me.lbl_User.Size = New System.Drawing.Size(83, 20)
        Me.lbl_User.TabIndex = 16
        Me.lbl_User.Text = "Username"
        Me.lbl_User.Visible = False
        '
        'Recover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.pic_Eye2)
        Me.Controls.Add(Me.pic_Eye)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Recover)
        Me.Controls.Add(Me.lbl_RecoverCode)
        Me.Controls.Add(Me.lbl_User)
        Me.Controls.Add(Me.txt_User)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_RecoverCode)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.umbrella_logo)
        Me.Controls.Add(Me.pic_Exit)
        Me.Controls.Add(Me.pic_Minimize)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Recover"
        Me.Text = "RECOVER PASSWORD"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Eye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Eye2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents pic_Minimize As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RecoverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents umbrella_logo As Button
    Friend WithEvents lbl_Title As Label
    Friend WithEvents btn_Recover As Button
    Friend WithEvents lbl_RecoverCode As Label
    Friend WithEvents lbl_Password As Label
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_RecoverCode As TextBox
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents pic_Eye As PictureBox
    Friend WithEvents pic_Eye2 As PictureBox
    Friend WithEvents txt_User As TextBox
    Friend WithEvents lbl_User As Label
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
