<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_Preview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print_Preview))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pic_Exit = New System.Windows.Forms.PictureBox()
        Me.pic_Minimize = New System.Windows.Forms.PictureBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.panel_Header = New System.Windows.Forms.Panel()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Preview = New System.Windows.Forms.Button()
        Me.btn_Print = New System.Windows.Forms.Button()
        Me.lbl_Header3 = New System.Windows.Forms.Label()
        Me.lbl_Header2 = New System.Windows.Forms.Label()
        Me.lbl_Header1 = New System.Windows.Forms.Label()
        Me.umbrella_logo = New System.Windows.Forms.Button()
        Me.lbl_BloodP = New System.Windows.Forms.Label()
        Me.lbl_Weight = New System.Windows.Forms.Label()
        Me.lbl_Height = New System.Windows.Forms.Label()
        Me.lbl_ProfilePic = New System.Windows.Forms.Label()
        Me.lbl_MedicineTR = New System.Windows.Forms.Label()
        Me.lbl_PurposeofC = New System.Windows.Forms.Label()
        Me.lbl_Cnum = New System.Windows.Forms.Label()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.lbl_Gender = New System.Windows.Forms.Label()
        Me.lbl_Pnum = New System.Windows.Forms.Label()
        Me.lbl_AttendingP = New System.Windows.Forms.Label()
        Me.lbl_Age = New System.Windows.Forms.Label()
        Me.lbl_Bdate = New System.Windows.Forms.Label()
        Me.lbl_DateofR = New System.Windows.Forms.Label()
        Me.lbl_Mname = New System.Windows.Forms.Label()
        Me.lbl_Lname = New System.Windows.Forms.Label()
        Me.lbl_Fname = New System.Windows.Forms.Label()
        Me.pic_Profile = New System.Windows.Forms.PictureBox()
        Me.txt_Fname = New System.Windows.Forms.Label()
        Me.txt_Lname = New System.Windows.Forms.Label()
        Me.txt_Mname = New System.Windows.Forms.Label()
        Me.date_Registered = New System.Windows.Forms.Label()
        Me.date_Bdate = New System.Windows.Forms.Label()
        Me.box_AttendingP = New System.Windows.Forms.Label()
        Me.txt_Pnum = New System.Windows.Forms.Label()
        Me.txt_Age = New System.Windows.Forms.Label()
        Me.txt_Gender = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.Label()
        Me.txt_Cnum = New System.Windows.Forms.Label()
        Me.txt_Height = New System.Windows.Forms.Label()
        Me.txt_Weight = New System.Windows.Forms.Label()
        Me.txt_BloodP = New System.Windows.Forms.Label()
        Me.box_MedTR = New System.Windows.Forms.Label()
        Me.txt_PurposeofC = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Header.SuspendLayout()
        CType(Me.pic_Profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(955, 28)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk
        Me.FileToolStripMenuItem.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.patient_records_512
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.FileToolStripMenuItem.Text = "PRINT RECORD"
        '
        'pic_Exit
        '
        Me.pic_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Exit.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.exit2
        Me.pic_Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Exit.Location = New System.Drawing.Point(925, 0)
        Me.pic_Exit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Exit.Name = "pic_Exit"
        Me.pic_Exit.Size = New System.Drawing.Size(30, 28)
        Me.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Exit.TabIndex = 54
        Me.pic_Exit.TabStop = False
        '
        'pic_Minimize
        '
        Me.pic_Minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_Minimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Minimize.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.minimize2
        Me.pic_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Minimize.Location = New System.Drawing.Point(898, 0)
        Me.pic_Minimize.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Minimize.Name = "pic_Minimize"
        Me.pic_Minimize.Size = New System.Drawing.Size(28, 28)
        Me.pic_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Minimize.TabIndex = 55
        Me.pic_Minimize.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'panel_Header
        '
        Me.panel_Header.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Header.Controls.Add(Me.btn_Back)
        Me.panel_Header.Controls.Add(Me.btn_Preview)
        Me.panel_Header.Controls.Add(Me.btn_Print)
        Me.panel_Header.Controls.Add(Me.lbl_Header3)
        Me.panel_Header.Controls.Add(Me.lbl_Header2)
        Me.panel_Header.Controls.Add(Me.lbl_Header1)
        Me.panel_Header.Controls.Add(Me.umbrella_logo)
        Me.panel_Header.Location = New System.Drawing.Point(-1, 28)
        Me.panel_Header.Name = "panel_Header"
        Me.panel_Header.Size = New System.Drawing.Size(970, 58)
        Me.panel_Header.TabIndex = 56
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.back_icon_blue
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Back.FlatAppearance.BorderSize = 0
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Back.Location = New System.Drawing.Point(11, 4)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(34, 45)
        Me.btn_Back.TabIndex = 1
        Me.btn_Back.TabStop = False
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Preview
        '
        Me.btn_Preview.AutoSize = True
        Me.btn_Preview.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Preview.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Preview.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Preview.Location = New System.Drawing.Point(792, 11)
        Me.btn_Preview.Name = "btn_Preview"
        Me.btn_Preview.Size = New System.Drawing.Size(70, 30)
        Me.btn_Preview.TabIndex = 2
        Me.btn_Preview.TabStop = False
        Me.btn_Preview.Text = "Preview"
        Me.btn_Preview.UseVisualStyleBackColor = True
        '
        'btn_Print
        '
        Me.btn_Print.AutoSize = True
        Me.btn_Print.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Print.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Print.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Print.Location = New System.Drawing.Point(868, 11)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(70, 30)
        Me.btn_Print.TabIndex = 2
        Me.btn_Print.TabStop = False
        Me.btn_Print.Text = "Print"
        Me.btn_Print.UseVisualStyleBackColor = True
        '
        'lbl_Header3
        '
        Me.lbl_Header3.AutoSize = True
        Me.lbl_Header3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Header3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Header3.ForeColor = System.Drawing.Color.Beige
        Me.lbl_Header3.Location = New System.Drawing.Point(435, 35)
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
        Me.lbl_Header2.Location = New System.Drawing.Point(433, 15)
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
        Me.lbl_Header1.Location = New System.Drawing.Point(435, 3)
        Me.lbl_Header1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Header1.Name = "lbl_Header1"
        Me.lbl_Header1.Size = New System.Drawing.Size(95, 14)
        Me.lbl_Header1.TabIndex = 0
        Me.lbl_Header1.Text = "Interior Community"
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
        Me.umbrella_logo.Location = New System.Drawing.Point(377, 3)
        Me.umbrella_logo.Name = "umbrella_logo"
        Me.umbrella_logo.Size = New System.Drawing.Size(67, 48)
        Me.umbrella_logo.TabIndex = 0
        Me.umbrella_logo.TabStop = False
        Me.umbrella_logo.UseVisualStyleBackColor = False
        '
        'lbl_BloodP
        '
        Me.lbl_BloodP.AutoSize = True
        Me.lbl_BloodP.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BloodP.Location = New System.Drawing.Point(436, 228)
        Me.lbl_BloodP.Name = "lbl_BloodP"
        Me.lbl_BloodP.Size = New System.Drawing.Size(109, 17)
        Me.lbl_BloodP.TabIndex = 96
        Me.lbl_BloodP.Text = "Blood Pressure:"
        '
        'lbl_Weight
        '
        Me.lbl_Weight.AutoSize = True
        Me.lbl_Weight.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Weight.Location = New System.Drawing.Point(486, 202)
        Me.lbl_Weight.Name = "lbl_Weight"
        Me.lbl_Weight.Size = New System.Drawing.Size(59, 17)
        Me.lbl_Weight.TabIndex = 95
        Me.lbl_Weight.Text = "Weight:"
        '
        'lbl_Height
        '
        Me.lbl_Height.AutoSize = True
        Me.lbl_Height.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Height.Location = New System.Drawing.Point(489, 176)
        Me.lbl_Height.Name = "lbl_Height"
        Me.lbl_Height.Size = New System.Drawing.Size(56, 17)
        Me.lbl_Height.TabIndex = 94
        Me.lbl_Height.Text = "Height:"
        '
        'lbl_ProfilePic
        '
        Me.lbl_ProfilePic.AutoSize = True
        Me.lbl_ProfilePic.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ProfilePic.Location = New System.Drawing.Point(803, 280)
        Me.lbl_ProfilePic.Name = "lbl_ProfilePic"
        Me.lbl_ProfilePic.Size = New System.Drawing.Size(100, 17)
        Me.lbl_ProfilePic.TabIndex = 116
        Me.lbl_ProfilePic.Text = "Profile Picture"
        '
        'lbl_MedicineTR
        '
        Me.lbl_MedicineTR.AutoSize = True
        Me.lbl_MedicineTR.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MedicineTR.Location = New System.Drawing.Point(365, 332)
        Me.lbl_MedicineTR.Name = "lbl_MedicineTR"
        Me.lbl_MedicineTR.Size = New System.Drawing.Size(180, 17)
        Me.lbl_MedicineTR.TabIndex = 97
        Me.lbl_MedicineTR.Text = "Medicine Type Received:"
        '
        'lbl_PurposeofC
        '
        Me.lbl_PurposeofC.AutoSize = True
        Me.lbl_PurposeofC.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PurposeofC.Location = New System.Drawing.Point(404, 254)
        Me.lbl_PurposeofC.Name = "lbl_PurposeofC"
        Me.lbl_PurposeofC.Size = New System.Drawing.Size(141, 17)
        Me.lbl_PurposeofC.TabIndex = 92
        Me.lbl_PurposeofC.Text = "Purpose of Coming:"
        '
        'lbl_Cnum
        '
        Me.lbl_Cnum.AutoSize = True
        Me.lbl_Cnum.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cnum.Location = New System.Drawing.Point(421, 150)
        Me.lbl_Cnum.Name = "lbl_Cnum"
        Me.lbl_Cnum.Size = New System.Drawing.Size(124, 17)
        Me.lbl_Cnum.TabIndex = 91
        Me.lbl_Cnum.Text = "Contact Number:"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.Location = New System.Drawing.Point(480, 125)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(65, 17)
        Me.lbl_Address.TabIndex = 90
        Me.lbl_Address.Text = "Address:"
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gender.Location = New System.Drawing.Point(105, 332)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(63, 17)
        Me.lbl_Gender.TabIndex = 89
        Me.lbl_Gender.Text = "Gender:"
        '
        'lbl_Pnum
        '
        Me.lbl_Pnum.AutoSize = True
        Me.lbl_Pnum.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pnum.Location = New System.Drawing.Point(52, 280)
        Me.lbl_Pnum.Name = "lbl_Pnum"
        Me.lbl_Pnum.Size = New System.Drawing.Size(116, 17)
        Me.lbl_Pnum.TabIndex = 88
        Me.lbl_Pnum.Text = "Patient Number:"
        '
        'lbl_AttendingP
        '
        Me.lbl_AttendingP.AutoSize = True
        Me.lbl_AttendingP.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AttendingP.Location = New System.Drawing.Point(24, 255)
        Me.lbl_AttendingP.Name = "lbl_AttendingP"
        Me.lbl_AttendingP.Size = New System.Drawing.Size(144, 17)
        Me.lbl_AttendingP.TabIndex = 93
        Me.lbl_AttendingP.Text = "Attending Physician:"
        '
        'lbl_Age
        '
        Me.lbl_Age.AutoSize = True
        Me.lbl_Age.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Age.Location = New System.Drawing.Point(128, 307)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(40, 17)
        Me.lbl_Age.TabIndex = 82
        Me.lbl_Age.Text = "Age:"
        '
        'lbl_Bdate
        '
        Me.lbl_Bdate.AutoSize = True
        Me.lbl_Bdate.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bdate.Location = New System.Drawing.Point(92, 228)
        Me.lbl_Bdate.Name = "lbl_Bdate"
        Me.lbl_Bdate.Size = New System.Drawing.Size(76, 17)
        Me.lbl_Bdate.TabIndex = 87
        Me.lbl_Bdate.Text = "Birth Date:"
        '
        'lbl_DateofR
        '
        Me.lbl_DateofR.AutoSize = True
        Me.lbl_DateofR.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DateofR.Location = New System.Drawing.Point(25, 202)
        Me.lbl_DateofR.Name = "lbl_DateofR"
        Me.lbl_DateofR.Size = New System.Drawing.Size(143, 17)
        Me.lbl_DateofR.TabIndex = 86
        Me.lbl_DateofR.Text = "Date of Registration:"
        '
        'lbl_Mname
        '
        Me.lbl_Mname.AutoSize = True
        Me.lbl_Mname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mname.Location = New System.Drawing.Point(62, 176)
        Me.lbl_Mname.Name = "lbl_Mname"
        Me.lbl_Mname.Size = New System.Drawing.Size(106, 17)
        Me.lbl_Mname.TabIndex = 85
        Me.lbl_Mname.Text = "Middle Name:"
        '
        'lbl_Lname
        '
        Me.lbl_Lname.AutoSize = True
        Me.lbl_Lname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lname.Location = New System.Drawing.Point(85, 150)
        Me.lbl_Lname.Name = "lbl_Lname"
        Me.lbl_Lname.Size = New System.Drawing.Size(83, 17)
        Me.lbl_Lname.TabIndex = 84
        Me.lbl_Lname.Text = "Last Name:"
        '
        'lbl_Fname
        '
        Me.lbl_Fname.AutoSize = True
        Me.lbl_Fname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fname.Location = New System.Drawing.Point(85, 125)
        Me.lbl_Fname.Name = "lbl_Fname"
        Me.lbl_Fname.Size = New System.Drawing.Size(83, 17)
        Me.lbl_Fname.TabIndex = 83
        Me.lbl_Fname.Text = "First Name:"
        '
        'pic_Profile
        '
        Me.pic_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_Profile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Profile.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pic_Profile.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.profile_avatar_png_1
        Me.pic_Profile.Location = New System.Drawing.Point(778, 121)
        Me.pic_Profile.Name = "pic_Profile"
        Me.pic_Profile.Size = New System.Drawing.Size(150, 150)
        Me.pic_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Profile.TabIndex = 115
        Me.pic_Profile.TabStop = False
        '
        'txt_Fname
        '
        Me.txt_Fname.AutoSize = True
        Me.txt_Fname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fname.Location = New System.Drawing.Point(174, 123)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.Size = New System.Drawing.Size(46, 20)
        Me.txt_Fname.TabIndex = 83
        Me.txt_Fname.Text = "[text]"
        '
        'txt_Lname
        '
        Me.txt_Lname.AutoSize = True
        Me.txt_Lname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Lname.Location = New System.Drawing.Point(174, 148)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.Size = New System.Drawing.Size(46, 20)
        Me.txt_Lname.TabIndex = 83
        Me.txt_Lname.Text = "[text]"
        '
        'txt_Mname
        '
        Me.txt_Mname.AutoSize = True
        Me.txt_Mname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mname.Location = New System.Drawing.Point(174, 174)
        Me.txt_Mname.Name = "txt_Mname"
        Me.txt_Mname.Size = New System.Drawing.Size(46, 20)
        Me.txt_Mname.TabIndex = 83
        Me.txt_Mname.Text = "[text]"
        '
        'date_Registered
        '
        Me.date_Registered.AutoSize = True
        Me.date_Registered.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_Registered.Location = New System.Drawing.Point(174, 200)
        Me.date_Registered.Name = "date_Registered"
        Me.date_Registered.Size = New System.Drawing.Size(46, 20)
        Me.date_Registered.TabIndex = 83
        Me.date_Registered.Text = "[text]"
        '
        'date_Bdate
        '
        Me.date_Bdate.AutoSize = True
        Me.date_Bdate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_Bdate.Location = New System.Drawing.Point(174, 226)
        Me.date_Bdate.Name = "date_Bdate"
        Me.date_Bdate.Size = New System.Drawing.Size(46, 20)
        Me.date_Bdate.TabIndex = 83
        Me.date_Bdate.Text = "[text]"
        '
        'box_AttendingP
        '
        Me.box_AttendingP.AutoSize = True
        Me.box_AttendingP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_AttendingP.Location = New System.Drawing.Point(174, 253)
        Me.box_AttendingP.Name = "box_AttendingP"
        Me.box_AttendingP.Size = New System.Drawing.Size(46, 20)
        Me.box_AttendingP.TabIndex = 83
        Me.box_AttendingP.Text = "[text]"
        '
        'txt_Pnum
        '
        Me.txt_Pnum.AutoSize = True
        Me.txt_Pnum.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pnum.Location = New System.Drawing.Point(174, 278)
        Me.txt_Pnum.Name = "txt_Pnum"
        Me.txt_Pnum.Size = New System.Drawing.Size(46, 20)
        Me.txt_Pnum.TabIndex = 83
        Me.txt_Pnum.Text = "[text]"
        '
        'txt_Age
        '
        Me.txt_Age.AutoSize = True
        Me.txt_Age.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Age.Location = New System.Drawing.Point(174, 305)
        Me.txt_Age.Name = "txt_Age"
        Me.txt_Age.Size = New System.Drawing.Size(46, 20)
        Me.txt_Age.TabIndex = 83
        Me.txt_Age.Text = "[text]"
        '
        'txt_Gender
        '
        Me.txt_Gender.AutoSize = True
        Me.txt_Gender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Gender.Location = New System.Drawing.Point(174, 330)
        Me.txt_Gender.Name = "txt_Gender"
        Me.txt_Gender.Size = New System.Drawing.Size(46, 20)
        Me.txt_Gender.TabIndex = 83
        Me.txt_Gender.Text = "[text]"
        '
        'txt_Address
        '
        Me.txt_Address.AutoSize = True
        Me.txt_Address.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Location = New System.Drawing.Point(551, 123)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(46, 20)
        Me.txt_Address.TabIndex = 83
        Me.txt_Address.Text = "[text]"
        '
        'txt_Cnum
        '
        Me.txt_Cnum.AutoSize = True
        Me.txt_Cnum.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cnum.Location = New System.Drawing.Point(551, 148)
        Me.txt_Cnum.Name = "txt_Cnum"
        Me.txt_Cnum.Size = New System.Drawing.Size(46, 20)
        Me.txt_Cnum.TabIndex = 83
        Me.txt_Cnum.Text = "[text]"
        '
        'txt_Height
        '
        Me.txt_Height.AutoSize = True
        Me.txt_Height.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Height.Location = New System.Drawing.Point(551, 174)
        Me.txt_Height.Name = "txt_Height"
        Me.txt_Height.Size = New System.Drawing.Size(46, 20)
        Me.txt_Height.TabIndex = 83
        Me.txt_Height.Text = "[text]"
        '
        'txt_Weight
        '
        Me.txt_Weight.AutoSize = True
        Me.txt_Weight.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Weight.Location = New System.Drawing.Point(551, 200)
        Me.txt_Weight.Name = "txt_Weight"
        Me.txt_Weight.Size = New System.Drawing.Size(46, 20)
        Me.txt_Weight.TabIndex = 83
        Me.txt_Weight.Text = "[text]"
        '
        'txt_BloodP
        '
        Me.txt_BloodP.AutoSize = True
        Me.txt_BloodP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BloodP.Location = New System.Drawing.Point(551, 226)
        Me.txt_BloodP.Name = "txt_BloodP"
        Me.txt_BloodP.Size = New System.Drawing.Size(46, 20)
        Me.txt_BloodP.TabIndex = 83
        Me.txt_BloodP.Text = "[text]"
        '
        'box_MedTR
        '
        Me.box_MedTR.AutoSize = True
        Me.box_MedTR.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_MedTR.Location = New System.Drawing.Point(551, 330)
        Me.box_MedTR.Name = "box_MedTR"
        Me.box_MedTR.Size = New System.Drawing.Size(46, 20)
        Me.box_MedTR.TabIndex = 83
        Me.box_MedTR.Text = "[text]"
        '
        'txt_PurposeofC
        '
        Me.txt_PurposeofC.AutoSize = True
        Me.txt_PurposeofC.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PurposeofC.Location = New System.Drawing.Point(551, 253)
        Me.txt_PurposeofC.Name = "txt_PurposeofC"
        Me.txt_PurposeofC.Size = New System.Drawing.Size(46, 20)
        Me.txt_PurposeofC.TabIndex = 83
        Me.txt_PurposeofC.Text = "[text]"
        '
        'Print_Preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(955, 380)
        Me.Controls.Add(Me.lbl_BloodP)
        Me.Controls.Add(Me.lbl_Weight)
        Me.Controls.Add(Me.lbl_Height)
        Me.Controls.Add(Me.lbl_ProfilePic)
        Me.Controls.Add(Me.lbl_MedicineTR)
        Me.Controls.Add(Me.lbl_PurposeofC)
        Me.Controls.Add(Me.lbl_Cnum)
        Me.Controls.Add(Me.lbl_Address)
        Me.Controls.Add(Me.lbl_Gender)
        Me.Controls.Add(Me.lbl_Pnum)
        Me.Controls.Add(Me.lbl_AttendingP)
        Me.Controls.Add(Me.lbl_Age)
        Me.Controls.Add(Me.lbl_Bdate)
        Me.Controls.Add(Me.lbl_DateofR)
        Me.Controls.Add(Me.lbl_Mname)
        Me.Controls.Add(Me.lbl_Lname)
        Me.Controls.Add(Me.date_Bdate)
        Me.Controls.Add(Me.date_Registered)
        Me.Controls.Add(Me.txt_Gender)
        Me.Controls.Add(Me.txt_Age)
        Me.Controls.Add(Me.txt_Pnum)
        Me.Controls.Add(Me.box_AttendingP)
        Me.Controls.Add(Me.txt_Mname)
        Me.Controls.Add(Me.txt_Lname)
        Me.Controls.Add(Me.txt_PurposeofC)
        Me.Controls.Add(Me.box_MedTR)
        Me.Controls.Add(Me.txt_BloodP)
        Me.Controls.Add(Me.txt_Weight)
        Me.Controls.Add(Me.txt_Height)
        Me.Controls.Add(Me.txt_Cnum)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.txt_Fname)
        Me.Controls.Add(Me.lbl_Fname)
        Me.Controls.Add(Me.pic_Profile)
        Me.Controls.Add(Me.panel_Header)
        Me.Controls.Add(Me.pic_Exit)
        Me.Controls.Add(Me.pic_Minimize)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Print_Preview"
        Me.Text = "Print_Preview"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Header.ResumeLayout(False)
        Me.panel_Header.PerformLayout()
        CType(Me.pic_Profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents pic_Minimize As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents panel_Header As Panel
    Friend WithEvents lbl_Header3 As Label
    Friend WithEvents lbl_Header2 As Label
    Friend WithEvents lbl_Header1 As Label
    Friend WithEvents umbrella_logo As Button
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Preview As Button
    Friend WithEvents btn_Print As Button
    Friend WithEvents lbl_BloodP As Label
    Friend WithEvents lbl_Weight As Label
    Friend WithEvents lbl_Height As Label
    Friend WithEvents lbl_ProfilePic As Label
    Friend WithEvents lbl_MedicineTR As Label
    Friend WithEvents lbl_PurposeofC As Label
    Friend WithEvents lbl_Cnum As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Gender As Label
    Friend WithEvents lbl_Pnum As Label
    Friend WithEvents lbl_AttendingP As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents lbl_Bdate As Label
    Friend WithEvents lbl_DateofR As Label
    Friend WithEvents lbl_Mname As Label
    Friend WithEvents lbl_Lname As Label
    Friend WithEvents lbl_Fname As Label
    Friend WithEvents pic_Profile As PictureBox
    Friend WithEvents txt_Fname As Label
    Friend WithEvents txt_Lname As Label
    Friend WithEvents txt_Mname As Label
    Friend WithEvents date_Registered As Label
    Friend WithEvents date_Bdate As Label
    Friend WithEvents box_AttendingP As Label
    Friend WithEvents txt_Pnum As Label
    Friend WithEvents txt_Age As Label
    Friend WithEvents txt_Gender As Label
    Friend WithEvents txt_Address As Label
    Friend WithEvents txt_Cnum As Label
    Friend WithEvents txt_Height As Label
    Friend WithEvents txt_Weight As Label
    Friend WithEvents txt_BloodP As Label
    Friend WithEvents box_MedTR As Label
    Friend WithEvents txt_PurposeofC As Label
End Class
