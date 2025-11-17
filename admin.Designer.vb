<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.pic_Exit = New System.Windows.Forms.PictureBox()
        Me.pic_Minimize = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel_Header = New System.Windows.Forms.Panel()
        Me.lbl_Header3 = New System.Windows.Forms.Label()
        Me.lbl_Header2 = New System.Windows.Forms.Label()
        Me.lbl_Header1 = New System.Windows.Forms.Label()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.umbrella_logo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_Accounts = New System.Windows.Forms.Label()
        Me.pic_Eye = New System.Windows.Forms.PictureBox()
        Me.lbl_Current = New System.Windows.Forms.Label()
        Me.txt_Current = New System.Windows.Forms.TextBox()
        Me.txt_New = New System.Windows.Forms.TextBox()
        Me.lbl_New = New System.Windows.Forms.Label()
        Me.pic_Eye2 = New System.Windows.Forms.PictureBox()
        Me.btn_Change = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.lbl_Change = New System.Windows.Forms.Label()
        Me.txt_Confirm = New System.Windows.Forms.TextBox()
        Me.lbl_Confirm = New System.Windows.Forms.Label()
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.panel_Header.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Eye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Eye2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pic_Exit.TabIndex = 55
        Me.pic_Exit.TabStop = False
        '
        'pic_Minimize
        '
        Me.pic_Minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_Minimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Minimize.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.minimize2
        Me.pic_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Minimize.Location = New System.Drawing.Point(349, 0)
        Me.pic_Minimize.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Minimize.Name = "pic_Minimize"
        Me.pic_Minimize.Size = New System.Drawing.Size(24, 28)
        Me.pic_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Minimize.TabIndex = 56
        Me.pic_Minimize.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(400, 28)
        Me.MenuStrip1.TabIndex = 54
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeCodeToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk
        Me.FileToolStripMenuItem.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.pngtube1
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.FileToolStripMenuItem.Text = "ADMIN"
        '
        'ChangeCodeToolStripMenuItem
        '
        Me.ChangeCodeToolStripMenuItem.Name = "ChangeCodeToolStripMenuItem"
        Me.ChangeCodeToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ChangeCodeToolStripMenuItem.Text = "Change Code"
        '
        'panel_Header
        '
        Me.panel_Header.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_Header.Controls.Add(Me.lbl_Header3)
        Me.panel_Header.Controls.Add(Me.lbl_Header2)
        Me.panel_Header.Controls.Add(Me.lbl_Header1)
        Me.panel_Header.Controls.Add(Me.btn_Logout)
        Me.panel_Header.Controls.Add(Me.umbrella_logo)
        Me.panel_Header.Location = New System.Drawing.Point(-11, 29)
        Me.panel_Header.Name = "panel_Header"
        Me.panel_Header.Size = New System.Drawing.Size(523, 58)
        Me.panel_Header.TabIndex = 57
        '
        'lbl_Header3
        '
        Me.lbl_Header3.AutoSize = True
        Me.lbl_Header3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Header3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Header3.ForeColor = System.Drawing.Color.Beige
        Me.lbl_Header3.Location = New System.Drawing.Point(115, 35)
        Me.lbl_Header3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Header3.Name = "lbl_Header3"
        Me.lbl_Header3.Size = New System.Drawing.Size(177, 13)
        Me.lbl_Header3.TabIndex = 0
        Me.lbl_Header3.Text = "Quality primary care accessible to all"
        '
        'lbl_Header2
        '
        Me.lbl_Header2.AutoSize = True
        Me.lbl_Header2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Header2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Header2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Header2.Location = New System.Drawing.Point(113, 15)
        Me.lbl_Header2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Header2.Name = "lbl_Header2"
        Me.lbl_Header2.Size = New System.Drawing.Size(108, 20)
        Me.lbl_Header2.TabIndex = 0
        Me.lbl_Header2.Text = "Health Center"
        '
        'lbl_Header1
        '
        Me.lbl_Header1.AutoSize = True
        Me.lbl_Header1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Header1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Header1.Location = New System.Drawing.Point(115, 3)
        Me.lbl_Header1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Header1.Name = "lbl_Header1"
        Me.lbl_Header1.Size = New System.Drawing.Size(109, 16)
        Me.lbl_Header1.TabIndex = 0
        Me.lbl_Header1.Text = "Interior Community"
        '
        'btn_Logout
        '
        Me.btn_Logout.AutoSize = True
        Me.btn_Logout.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Logout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Logout.Location = New System.Drawing.Point(328, 11)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(70, 30)
        Me.btn_Logout.TabIndex = 0
        Me.btn_Logout.TabStop = False
        Me.btn_Logout.Text = "Logout"
        Me.btn_Logout.UseVisualStyleBackColor = True
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
        Me.umbrella_logo.Location = New System.Drawing.Point(57, 3)
        Me.umbrella_logo.Name = "umbrella_logo"
        Me.umbrella_logo.Size = New System.Drawing.Size(67, 48)
        Me.umbrella_logo.TabIndex = 0
        Me.umbrella_logo.TabStop = False
        Me.umbrella_logo.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(376, 225)
        Me.DataGridView1.TabIndex = 27
        Me.DataGridView1.TabStop = False
        '
        'lbl_Accounts
        '
        Me.lbl_Accounts.AutoSize = True
        Me.lbl_Accounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Accounts.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Accounts.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_Accounts.Location = New System.Drawing.Point(40, 109)
        Me.lbl_Accounts.Name = "lbl_Accounts"
        Me.lbl_Accounts.Size = New System.Drawing.Size(320, 32)
        Me.lbl_Accounts.TabIndex = 58
        Me.lbl_Accounts.Text = "REGISTERED ACCOUNTS"
        '
        'pic_Eye
        '
        Me.pic_Eye.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pic_Eye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Eye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_Eye.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.show_password
        Me.pic_Eye.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Eye.Location = New System.Drawing.Point(322, 215)
        Me.pic_Eye.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Eye.Name = "pic_Eye"
        Me.pic_Eye.Size = New System.Drawing.Size(21, 23)
        Me.pic_Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Eye.TabIndex = 63
        Me.pic_Eye.TabStop = False
        Me.pic_Eye.Visible = False
        '
        'lbl_Current
        '
        Me.lbl_Current.AutoSize = True
        Me.lbl_Current.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_Current.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_Current.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_Current.Location = New System.Drawing.Point(58, 214)
        Me.lbl_Current.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Current.Name = "lbl_Current"
        Me.lbl_Current.Size = New System.Drawing.Size(104, 20)
        Me.lbl_Current.TabIndex = 59
        Me.lbl_Current.Text = "Current Code"
        Me.lbl_Current.Visible = False
        '
        'txt_Current
        '
        Me.txt_Current.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Current.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Current.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_Current.Location = New System.Drawing.Point(166, 215)
        Me.txt_Current.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_Current.Name = "txt_Current"
        Me.txt_Current.Size = New System.Drawing.Size(157, 23)
        Me.txt_Current.TabIndex = 1
        Me.txt_Current.UseSystemPasswordChar = True
        Me.txt_Current.Visible = False
        '
        'txt_New
        '
        Me.txt_New.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_New.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_New.Location = New System.Drawing.Point(166, 244)
        Me.txt_New.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_New.Name = "txt_New"
        Me.txt_New.Size = New System.Drawing.Size(157, 23)
        Me.txt_New.TabIndex = 2
        Me.txt_New.UseSystemPasswordChar = True
        Me.txt_New.Visible = False
        '
        'lbl_New
        '
        Me.lbl_New.AutoSize = True
        Me.lbl_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_New.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_New.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_New.Location = New System.Drawing.Point(80, 243)
        Me.lbl_New.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_New.Name = "lbl_New"
        Me.lbl_New.Size = New System.Drawing.Size(82, 20)
        Me.lbl_New.TabIndex = 60
        Me.lbl_New.Text = "New Code"
        Me.lbl_New.Visible = False
        '
        'pic_Eye2
        '
        Me.pic_Eye2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pic_Eye2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Eye2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_Eye2.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.show_password
        Me.pic_Eye2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Eye2.Location = New System.Drawing.Point(322, 244)
        Me.pic_Eye2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Eye2.Name = "pic_Eye2"
        Me.pic_Eye2.Size = New System.Drawing.Size(21, 23)
        Me.pic_Eye2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Eye2.TabIndex = 63
        Me.pic_Eye2.TabStop = False
        Me.pic_Eye2.Visible = False
        '
        'btn_Change
        '
        Me.btn_Change.AutoSize = True
        Me.btn_Change.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Change.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Change.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Change.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_Change.Location = New System.Drawing.Point(244, 311)
        Me.btn_Change.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Change.Name = "btn_Change"
        Me.btn_Change.Size = New System.Drawing.Size(99, 27)
        Me.btn_Change.TabIndex = 3
        Me.btn_Change.Text = "Change"
        Me.btn_Change.UseVisualStyleBackColor = True
        Me.btn_Change.Visible = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AutoSize = True
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_Cancel.Location = New System.Drawing.Point(62, 311)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(100, 27)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        Me.btn_Cancel.Visible = False
        '
        'lbl_Change
        '
        Me.lbl_Change.AutoSize = True
        Me.lbl_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Change.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Change.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_Change.Location = New System.Drawing.Point(91, 139)
        Me.lbl_Change.Name = "lbl_Change"
        Me.lbl_Change.Size = New System.Drawing.Size(216, 32)
        Me.lbl_Change.TabIndex = 65
        Me.lbl_Change.Text = "CHANGE CODE"
        Me.lbl_Change.Visible = False
        '
        'txt_Confirm
        '
        Me.txt_Confirm.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Confirm.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_Confirm.Location = New System.Drawing.Point(166, 273)
        Me.txt_Confirm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_Confirm.Name = "txt_Confirm"
        Me.txt_Confirm.Size = New System.Drawing.Size(157, 23)
        Me.txt_Confirm.TabIndex = 2
        Me.txt_Confirm.UseSystemPasswordChar = True
        Me.txt_Confirm.Visible = False
        '
        'lbl_Confirm
        '
        Me.lbl_Confirm.AutoSize = True
        Me.lbl_Confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_Confirm.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_Confirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_Confirm.Location = New System.Drawing.Point(56, 272)
        Me.lbl_Confirm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Confirm.Name = "lbl_Confirm"
        Me.lbl_Confirm.Size = New System.Drawing.Size(106, 20)
        Me.lbl_Confirm.TabIndex = 60
        Me.lbl_Confirm.Text = "Confirm Code"
        Me.lbl_Confirm.Visible = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.lbl_Change)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Change)
        Me.Controls.Add(Me.pic_Eye2)
        Me.Controls.Add(Me.pic_Eye)
        Me.Controls.Add(Me.lbl_Current)
        Me.Controls.Add(Me.lbl_Confirm)
        Me.Controls.Add(Me.lbl_New)
        Me.Controls.Add(Me.txt_Confirm)
        Me.Controls.Add(Me.txt_New)
        Me.Controls.Add(Me.txt_Current)
        Me.Controls.Add(Me.lbl_Accounts)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.panel_Header)
        Me.Controls.Add(Me.pic_Exit)
        Me.Controls.Add(Me.pic_Minimize)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panel_Header.ResumeLayout(False)
        Me.panel_Header.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Eye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Eye2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents pic_Minimize As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panel_Header As Panel
    Friend WithEvents lbl_Header3 As Label
    Friend WithEvents lbl_Header2 As Label
    Friend WithEvents lbl_Header1 As Label
    Friend WithEvents btn_Logout As Button
    Friend WithEvents umbrella_logo As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_Accounts As Label
    Friend WithEvents pic_Eye As PictureBox
    Friend WithEvents lbl_Current As Label
    Friend WithEvents txt_Current As TextBox
    Friend WithEvents txt_New As TextBox
    Friend WithEvents lbl_New As Label
    Friend WithEvents pic_Eye2 As PictureBox
    Friend WithEvents btn_Change As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents lbl_Change As Label
    Friend WithEvents txt_Confirm As TextBox
    Friend WithEvents lbl_Confirm As Label
End Class
