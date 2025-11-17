<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Patient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Patient))
        Me.txt_PIDName = New System.Windows.Forms.TextBox()
        Me.addpatient = New System.Windows.Forms.Button()
        Me.txt_Fname = New System.Windows.Forms.TextBox()
        Me.txt_Lname = New System.Windows.Forms.TextBox()
        Me.txt_Mname = New System.Windows.Forms.TextBox()
        Me.txt_Age = New System.Windows.Forms.TextBox()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.txt_Cnum = New System.Windows.Forms.TextBox()
        Me.txt_Pnum = New System.Windows.Forms.TextBox()
        Me.date_Bdate = New System.Windows.Forms.DateTimePicker()
        Me.rb_Male = New System.Windows.Forms.RadioButton()
        Me.rb_Female = New System.Windows.Forms.RadioButton()
        Me.date_Registered = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Pnum = New System.Windows.Forms.Label()
        Me.lbl_AttendingP = New System.Windows.Forms.Label()
        Me.lbl_Age = New System.Windows.Forms.Label()
        Me.lbl_Bdate = New System.Windows.Forms.Label()
        Me.lbl_DateofR = New System.Windows.Forms.Label()
        Me.lbl_Mname = New System.Windows.Forms.Label()
        Me.lbl_Lname = New System.Windows.Forms.Label()
        Me.lbl_Fname = New System.Windows.Forms.Label()
        Me.panel_Header = New System.Windows.Forms.Panel()
        Me.lbl_Header3 = New System.Windows.Forms.Label()
        Me.lbl_Header2 = New System.Windows.Forms.Label()
        Me.lbl_Header1 = New System.Windows.Forms.Label()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.umbrella_logo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Weight = New System.Windows.Forms.TextBox()
        Me.txt_Height = New System.Windows.Forms.TextBox()
        Me.lbl_BloodP = New System.Windows.Forms.Label()
        Me.lbl_Weight = New System.Windows.Forms.Label()
        Me.lbl_Height = New System.Windows.Forms.Label()
        Me.lbl_MedicineTR = New System.Windows.Forms.Label()
        Me.lbl_PurposeofC = New System.Windows.Forms.Label()
        Me.lbl_Cnum = New System.Windows.Forms.Label()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.lbl_Gender = New System.Windows.Forms.Label()
        Me.lbl_Profilepic = New System.Windows.Forms.Label()
        Me.panel_Body = New System.Windows.Forms.Panel()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.box_MedTR = New System.Windows.Forms.ComboBox()
        Me.box_AttendingP = New System.Windows.Forms.ComboBox()
        Me.txt_PurposeofC = New System.Windows.Forms.RichTextBox()
        Me.pic_Exit = New System.Windows.Forms.PictureBox()
        Me.pic_Minimize = New System.Windows.Forms.PictureBox()
        Me.pic_Profile = New System.Windows.Forms.PictureBox()
        Me.txt_BloodP = New System.Windows.Forms.ComboBox()
        Me.btn_AddMed = New System.Windows.Forms.Button()
        Me.btn_AddPhysician = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.panel_Header.SuspendLayout()
        Me.panel_Body.SuspendLayout()
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_PIDName
        '
        Me.txt_PIDName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_PIDName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_PIDName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PIDName.Location = New System.Drawing.Point(775, 297)
        Me.txt_PIDName.Multiline = True
        Me.txt_PIDName.Name = "txt_PIDName"
        Me.txt_PIDName.ReadOnly = True
        Me.txt_PIDName.Size = New System.Drawing.Size(150, 33)
        Me.txt_PIDName.TabIndex = 18
        Me.txt_PIDName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'addpatient
        '
        Me.addpatient.AutoSize = True
        Me.addpatient.BackColor = System.Drawing.Color.CadetBlue
        Me.addpatient.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.addpatient.FlatAppearance.BorderSize = 2
        Me.addpatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addpatient.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addpatient.ForeColor = System.Drawing.Color.Cornsilk
        Me.addpatient.Location = New System.Drawing.Point(804, 392)
        Me.addpatient.Name = "addpatient"
        Me.addpatient.Size = New System.Drawing.Size(121, 33)
        Me.addpatient.TabIndex = 19
        Me.addpatient.Text = "ADD PATIENT"
        Me.addpatient.UseVisualStyleBackColor = False
        '
        'txt_Fname
        '
        Me.txt_Fname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Fname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fname.Location = New System.Drawing.Point(171, 139)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.Size = New System.Drawing.Size(190, 21)
        Me.txt_Fname.TabIndex = 1
        '
        'txt_Lname
        '
        Me.txt_Lname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Lname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Lname.Location = New System.Drawing.Point(171, 165)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.Size = New System.Drawing.Size(190, 21)
        Me.txt_Lname.TabIndex = 2
        '
        'txt_Mname
        '
        Me.txt_Mname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Mname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mname.Location = New System.Drawing.Point(171, 191)
        Me.txt_Mname.Name = "txt_Mname"
        Me.txt_Mname.Size = New System.Drawing.Size(190, 21)
        Me.txt_Mname.TabIndex = 3
        '
        'txt_Age
        '
        Me.txt_Age.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Age.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Age.Location = New System.Drawing.Point(171, 321)
        Me.txt_Age.Name = "txt_Age"
        Me.txt_Age.Size = New System.Drawing.Size(190, 21)
        Me.txt_Age.TabIndex = 8
        '
        'txt_Address
        '
        Me.txt_Address.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Address.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Location = New System.Drawing.Point(548, 139)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(190, 21)
        Me.txt_Address.TabIndex = 11
        '
        'txt_Cnum
        '
        Me.txt_Cnum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Cnum.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cnum.Location = New System.Drawing.Point(548, 165)
        Me.txt_Cnum.Name = "txt_Cnum"
        Me.txt_Cnum.Size = New System.Drawing.Size(190, 21)
        Me.txt_Cnum.TabIndex = 12
        '
        'txt_Pnum
        '
        Me.txt_Pnum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Pnum.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pnum.Location = New System.Drawing.Point(171, 295)
        Me.txt_Pnum.Name = "txt_Pnum"
        Me.txt_Pnum.Size = New System.Drawing.Size(190, 21)
        Me.txt_Pnum.TabIndex = 7
        '
        'date_Bdate
        '
        Me.date_Bdate.CalendarFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_Bdate.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        Me.date_Bdate.CalendarTitleBackColor = System.Drawing.Color.CadetBlue
        Me.date_Bdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_Bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_Bdate.Location = New System.Drawing.Point(171, 243)
        Me.date_Bdate.MaxDate = New Date(2019, 11, 13, 0, 0, 0, 0)
        Me.date_Bdate.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.date_Bdate.Name = "date_Bdate"
        Me.date_Bdate.Size = New System.Drawing.Size(190, 21)
        Me.date_Bdate.TabIndex = 5
        Me.date_Bdate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'rb_Male
        '
        Me.rb_Male.AutoSize = True
        Me.rb_Male.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Male.Location = New System.Drawing.Point(171, 345)
        Me.rb_Male.Name = "rb_Male"
        Me.rb_Male.Size = New System.Drawing.Size(52, 19)
        Me.rb_Male.TabIndex = 9
        Me.rb_Male.TabStop = True
        Me.rb_Male.Text = "Male"
        Me.rb_Male.UseVisualStyleBackColor = True
        '
        'rb_Female
        '
        Me.rb_Female.AutoSize = True
        Me.rb_Female.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Female.Location = New System.Drawing.Point(229, 345)
        Me.rb_Female.Name = "rb_Female"
        Me.rb_Female.Size = New System.Drawing.Size(64, 19)
        Me.rb_Female.TabIndex = 10
        Me.rb_Female.TabStop = True
        Me.rb_Female.Text = "Female"
        Me.rb_Female.UseVisualStyleBackColor = True
        '
        'date_Registered
        '
        Me.date_Registered.CalendarFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_Registered.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        Me.date_Registered.CalendarTitleBackColor = System.Drawing.Color.CadetBlue
        Me.date_Registered.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_Registered.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_Registered.Location = New System.Drawing.Point(171, 217)
        Me.date_Registered.MaxDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.date_Registered.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.date_Registered.Name = "date_Registered"
        Me.date_Registered.Size = New System.Drawing.Size(190, 21)
        Me.date_Registered.TabIndex = 4
        Me.date_Registered.Value = New Date(2019, 11, 13, 0, 0, 0, 0)
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(927, 260)
        Me.DataGridView1.TabIndex = 20
        Me.DataGridView1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(955, 28)
        Me.MenuStrip1.TabIndex = 59
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk
        Me.HelpToolStripMenuItem.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.user_14_512
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.HelpToolStripMenuItem.Text = "ADD PATIENT"
        '
        'lbl_Pnum
        '
        Me.lbl_Pnum.AutoSize = True
        Me.lbl_Pnum.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pnum.Location = New System.Drawing.Point(53, 295)
        Me.lbl_Pnum.Name = "lbl_Pnum"
        Me.lbl_Pnum.Size = New System.Drawing.Size(112, 17)
        Me.lbl_Pnum.TabIndex = 0
        Me.lbl_Pnum.Text = "Patient Number"
        '
        'lbl_AttendingP
        '
        Me.lbl_AttendingP.AutoSize = True
        Me.lbl_AttendingP.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AttendingP.Location = New System.Drawing.Point(25, 269)
        Me.lbl_AttendingP.Name = "lbl_AttendingP"
        Me.lbl_AttendingP.Size = New System.Drawing.Size(140, 17)
        Me.lbl_AttendingP.TabIndex = 0
        Me.lbl_AttendingP.Text = "Attending Physician"
        '
        'lbl_Age
        '
        Me.lbl_Age.AutoSize = True
        Me.lbl_Age.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Age.Location = New System.Drawing.Point(129, 321)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(36, 17)
        Me.lbl_Age.TabIndex = 0
        Me.lbl_Age.Text = "Age"
        '
        'lbl_Bdate
        '
        Me.lbl_Bdate.AutoSize = True
        Me.lbl_Bdate.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bdate.Location = New System.Drawing.Point(93, 243)
        Me.lbl_Bdate.Name = "lbl_Bdate"
        Me.lbl_Bdate.Size = New System.Drawing.Size(72, 17)
        Me.lbl_Bdate.TabIndex = 0
        Me.lbl_Bdate.Text = "Birth Date"
        '
        'lbl_DateofR
        '
        Me.lbl_DateofR.AutoSize = True
        Me.lbl_DateofR.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DateofR.Location = New System.Drawing.Point(26, 217)
        Me.lbl_DateofR.Name = "lbl_DateofR"
        Me.lbl_DateofR.Size = New System.Drawing.Size(139, 17)
        Me.lbl_DateofR.TabIndex = 0
        Me.lbl_DateofR.Text = "Date of Registration"
        '
        'lbl_Mname
        '
        Me.lbl_Mname.AutoSize = True
        Me.lbl_Mname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mname.Location = New System.Drawing.Point(69, 191)
        Me.lbl_Mname.Name = "lbl_Mname"
        Me.lbl_Mname.Size = New System.Drawing.Size(96, 17)
        Me.lbl_Mname.TabIndex = 0
        Me.lbl_Mname.Text = "Middlename"
        '
        'lbl_Lname
        '
        Me.lbl_Lname.AutoSize = True
        Me.lbl_Lname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lname.Location = New System.Drawing.Point(92, 165)
        Me.lbl_Lname.Name = "lbl_Lname"
        Me.lbl_Lname.Size = New System.Drawing.Size(73, 17)
        Me.lbl_Lname.TabIndex = 0
        Me.lbl_Lname.Text = "Lastname"
        '
        'lbl_Fname
        '
        Me.lbl_Fname.AutoSize = True
        Me.lbl_Fname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fname.Location = New System.Drawing.Point(92, 139)
        Me.lbl_Fname.Name = "lbl_Fname"
        Me.lbl_Fname.Size = New System.Drawing.Size(73, 17)
        Me.lbl_Fname.TabIndex = 0
        Me.lbl_Fname.Text = "Firstname"
        '
        'panel_Header
        '
        Me.panel_Header.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Header.Controls.Add(Me.lbl_Header3)
        Me.panel_Header.Controls.Add(Me.lbl_Header2)
        Me.panel_Header.Controls.Add(Me.lbl_Header1)
        Me.panel_Header.Controls.Add(Me.btn_Back)
        Me.panel_Header.Controls.Add(Me.btn_Logout)
        Me.panel_Header.Controls.Add(Me.umbrella_logo)
        Me.panel_Header.Location = New System.Drawing.Point(-8, 24)
        Me.panel_Header.Name = "panel_Header"
        Me.panel_Header.Size = New System.Drawing.Size(970, 58)
        Me.panel_Header.TabIndex = 0
        '
        'lbl_Header3
        '
        Me.lbl_Header3.AutoSize = True
        Me.lbl_Header3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Header3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Header3.ForeColor = System.Drawing.Color.Beige
        Me.lbl_Header3.Location = New System.Drawing.Point(431, 35)
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
        Me.lbl_Header2.Location = New System.Drawing.Point(429, 15)
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
        Me.lbl_Header1.Location = New System.Drawing.Point(431, 3)
        Me.lbl_Header1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Header1.Name = "lbl_Header1"
        Me.lbl_Header1.Size = New System.Drawing.Size(93, 13)
        Me.lbl_Header1.TabIndex = 0
        Me.lbl_Header1.Text = "Interior Community"
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
        Me.btn_Back.Location = New System.Drawing.Point(19, 6)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(34, 45)
        Me.btn_Back.TabIndex = 0
        Me.btn_Back.TabStop = False
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Logout
        '
        Me.btn_Logout.AutoSize = True
        Me.btn_Logout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Logout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Logout.Location = New System.Drawing.Point(876, 13)
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
        Me.umbrella_logo.Location = New System.Drawing.Point(373, 3)
        Me.umbrella_logo.Name = "umbrella_logo"
        Me.umbrella_logo.Size = New System.Drawing.Size(67, 48)
        Me.umbrella_logo.TabIndex = 0
        Me.umbrella_logo.TabStop = False
        Me.umbrella_logo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("BigNoodleTooOblique", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(351, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ADD NEW PATIENT RECORDS"
        '
        'txt_Weight
        '
        Me.txt_Weight.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Weight.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Weight.Location = New System.Drawing.Point(548, 217)
        Me.txt_Weight.Name = "txt_Weight"
        Me.txt_Weight.Size = New System.Drawing.Size(190, 21)
        Me.txt_Weight.TabIndex = 14
        '
        'txt_Height
        '
        Me.txt_Height.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Height.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Height.Location = New System.Drawing.Point(548, 191)
        Me.txt_Height.Name = "txt_Height"
        Me.txt_Height.Size = New System.Drawing.Size(190, 21)
        Me.txt_Height.TabIndex = 13
        '
        'lbl_BloodP
        '
        Me.lbl_BloodP.AutoSize = True
        Me.lbl_BloodP.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BloodP.Location = New System.Drawing.Point(437, 243)
        Me.lbl_BloodP.Name = "lbl_BloodP"
        Me.lbl_BloodP.Size = New System.Drawing.Size(105, 17)
        Me.lbl_BloodP.TabIndex = 0
        Me.lbl_BloodP.Text = "Blood Pressure"
        '
        'lbl_Weight
        '
        Me.lbl_Weight.AutoSize = True
        Me.lbl_Weight.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Weight.Location = New System.Drawing.Point(487, 217)
        Me.lbl_Weight.Name = "lbl_Weight"
        Me.lbl_Weight.Size = New System.Drawing.Size(55, 17)
        Me.lbl_Weight.TabIndex = 0
        Me.lbl_Weight.Text = "Weight"
        '
        'lbl_Height
        '
        Me.lbl_Height.AutoSize = True
        Me.lbl_Height.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Height.Location = New System.Drawing.Point(490, 191)
        Me.lbl_Height.Name = "lbl_Height"
        Me.lbl_Height.Size = New System.Drawing.Size(52, 17)
        Me.lbl_Height.TabIndex = 0
        Me.lbl_Height.Text = "Height"
        '
        'lbl_MedicineTR
        '
        Me.lbl_MedicineTR.AutoSize = True
        Me.lbl_MedicineTR.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MedicineTR.Location = New System.Drawing.Point(366, 347)
        Me.lbl_MedicineTR.Name = "lbl_MedicineTR"
        Me.lbl_MedicineTR.Size = New System.Drawing.Size(176, 17)
        Me.lbl_MedicineTR.TabIndex = 0
        Me.lbl_MedicineTR.Text = "Medicine Type Received"
        '
        'lbl_PurposeofC
        '
        Me.lbl_PurposeofC.AutoSize = True
        Me.lbl_PurposeofC.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PurposeofC.Location = New System.Drawing.Point(405, 269)
        Me.lbl_PurposeofC.Name = "lbl_PurposeofC"
        Me.lbl_PurposeofC.Size = New System.Drawing.Size(137, 17)
        Me.lbl_PurposeofC.TabIndex = 0
        Me.lbl_PurposeofC.Text = "Purpose of Coming"
        '
        'lbl_Cnum
        '
        Me.lbl_Cnum.AutoSize = True
        Me.lbl_Cnum.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cnum.Location = New System.Drawing.Point(422, 165)
        Me.lbl_Cnum.Name = "lbl_Cnum"
        Me.lbl_Cnum.Size = New System.Drawing.Size(120, 17)
        Me.lbl_Cnum.TabIndex = 0
        Me.lbl_Cnum.Text = "Contact Number"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.Location = New System.Drawing.Point(481, 139)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(61, 17)
        Me.lbl_Address.TabIndex = 0
        Me.lbl_Address.Text = "Address"
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gender.Location = New System.Drawing.Point(106, 345)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(59, 17)
        Me.lbl_Gender.TabIndex = 0
        Me.lbl_Gender.Text = "Gender"
        '
        'lbl_Profilepic
        '
        Me.lbl_Profilepic.AutoSize = True
        Me.lbl_Profilepic.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Profilepic.Location = New System.Drawing.Point(801, 116)
        Me.lbl_Profilepic.Name = "lbl_Profilepic"
        Me.lbl_Profilepic.Size = New System.Drawing.Size(100, 17)
        Me.lbl_Profilepic.TabIndex = 75
        Me.lbl_Profilepic.Text = "Profile Picture"
        '
        'panel_Body
        '
        Me.panel_Body.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panel_Body.Controls.Add(Me.DataGridView1)
        Me.panel_Body.Location = New System.Drawing.Point(0, 444)
        Me.panel_Body.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_Body.Name = "panel_Body"
        Me.panel_Body.Size = New System.Drawing.Size(955, 288)
        Me.panel_Body.TabIndex = 0
        '
        'btn_Clear
        '
        Me.btn_Clear.AutoSize = True
        Me.btn_Clear.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_Clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Clear.FlatAppearance.BorderSize = 2
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_Clear.Location = New System.Drawing.Point(29, 392)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(165, 33)
        Me.btn_Clear.TabIndex = 78
        Me.btn_Clear.Text = "Clear All Fields"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'box_MedTR
        '
        Me.box_MedTR.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.box_MedTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_MedTR.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_MedTR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.box_MedTR.FormattingEnabled = True
        Me.box_MedTR.ItemHeight = 16
        Me.box_MedTR.Location = New System.Drawing.Point(548, 344)
        Me.box_MedTR.Name = "box_MedTR"
        Me.box_MedTR.Size = New System.Drawing.Size(190, 24)
        Me.box_MedTR.TabIndex = 17
        Me.box_MedTR.Text = "None"
        '
        'box_AttendingP
        '
        Me.box_AttendingP.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.box_AttendingP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_AttendingP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_AttendingP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.box_AttendingP.FormattingEnabled = True
        Me.box_AttendingP.ItemHeight = 16
        Me.box_AttendingP.Location = New System.Drawing.Point(171, 268)
        Me.box_AttendingP.Name = "box_AttendingP"
        Me.box_AttendingP.Size = New System.Drawing.Size(190, 24)
        Me.box_AttendingP.TabIndex = 6
        Me.box_AttendingP.Text = "None"
        '
        'txt_PurposeofC
        '
        Me.txt_PurposeofC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_PurposeofC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PurposeofC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_PurposeofC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PurposeofC.Location = New System.Drawing.Point(548, 270)
        Me.txt_PurposeofC.Name = "txt_PurposeofC"
        Me.txt_PurposeofC.Size = New System.Drawing.Size(190, 72)
        Me.txt_PurposeofC.TabIndex = 81
        Me.txt_PurposeofC.Text = ""
        '
        'pic_Exit
        '
        Me.pic_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Exit.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.exit2
        Me.pic_Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Exit.Location = New System.Drawing.Point(928, 0)
        Me.pic_Exit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Exit.Name = "pic_Exit"
        Me.pic_Exit.Size = New System.Drawing.Size(26, 24)
        Me.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Exit.TabIndex = 76
        Me.pic_Exit.TabStop = False
        '
        'pic_Minimize
        '
        Me.pic_Minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_Minimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Minimize.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.minimize2
        Me.pic_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pic_Minimize.Location = New System.Drawing.Point(904, 0)
        Me.pic_Minimize.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pic_Minimize.Name = "pic_Minimize"
        Me.pic_Minimize.Size = New System.Drawing.Size(24, 24)
        Me.pic_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Minimize.TabIndex = 77
        Me.pic_Minimize.TabStop = False
        '
        'pic_Profile
        '
        Me.pic_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_Profile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Profile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_Profile.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.profile_avatar_png_1
        Me.pic_Profile.Location = New System.Drawing.Point(775, 136)
        Me.pic_Profile.Name = "pic_Profile"
        Me.pic_Profile.Size = New System.Drawing.Size(150, 150)
        Me.pic_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Profile.TabIndex = 30
        Me.pic_Profile.TabStop = False
        '
        'txt_BloodP
        '
        Me.txt_BloodP.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_BloodP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_BloodP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BloodP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_BloodP.FormattingEnabled = True
        Me.txt_BloodP.ItemHeight = 16
        Me.txt_BloodP.Items.AddRange(New Object() {"None", "Normal (Less than 120)", "Elevated (120 - 129)", "High (Stage 1) (130 - 139)", "High (Stage 2) (140 or Higher)", "Hypertensive Crisis (180+)"})
        Me.txt_BloodP.Location = New System.Drawing.Point(548, 242)
        Me.txt_BloodP.Name = "txt_BloodP"
        Me.txt_BloodP.Size = New System.Drawing.Size(190, 24)
        Me.txt_BloodP.TabIndex = 82
        Me.txt_BloodP.Text = "None"
        '
        'btn_AddMed
        '
        Me.btn_AddMed.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddMed.BackgroundImage = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.add_photo_icon_1
        Me.btn_AddMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_AddMed.FlatAppearance.BorderSize = 0
        Me.btn_AddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddMed.Location = New System.Drawing.Point(744, 344)
        Me.btn_AddMed.Name = "btn_AddMed"
        Me.btn_AddMed.Size = New System.Drawing.Size(25, 23)
        Me.btn_AddMed.TabIndex = 119
        Me.btn_AddMed.TabStop = False
        Me.btn_AddMed.UseVisualStyleBackColor = False
        '
        'btn_AddPhysician
        '
        Me.btn_AddPhysician.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddPhysician.BackgroundImage = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.add_photo_icon_1
        Me.btn_AddPhysician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_AddPhysician.FlatAppearance.BorderSize = 0
        Me.btn_AddPhysician.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddPhysician.Location = New System.Drawing.Point(367, 268)
        Me.btn_AddPhysician.Name = "btn_AddPhysician"
        Me.btn_AddPhysician.Size = New System.Drawing.Size(25, 24)
        Me.btn_AddPhysician.TabIndex = 120
        Me.btn_AddPhysician.TabStop = False
        Me.btn_AddPhysician.UseVisualStyleBackColor = False
        '
        'Add_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(955, 730)
        Me.Controls.Add(Me.btn_AddMed)
        Me.Controls.Add(Me.btn_AddPhysician)
        Me.Controls.Add(Me.txt_BloodP)
        Me.Controls.Add(Me.txt_PurposeofC)
        Me.Controls.Add(Me.box_AttendingP)
        Me.Controls.Add(Me.box_MedTR)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.pic_Exit)
        Me.Controls.Add(Me.pic_Minimize)
        Me.Controls.Add(Me.panel_Body)
        Me.Controls.Add(Me.txt_Weight)
        Me.Controls.Add(Me.txt_Height)
        Me.Controls.Add(Me.lbl_BloodP)
        Me.Controls.Add(Me.lbl_Weight)
        Me.Controls.Add(Me.lbl_Height)
        Me.Controls.Add(Me.lbl_Profilepic)
        Me.Controls.Add(Me.lbl_MedicineTR)
        Me.Controls.Add(Me.lbl_PurposeofC)
        Me.Controls.Add(Me.lbl_Cnum)
        Me.Controls.Add(Me.lbl_Address)
        Me.Controls.Add(Me.lbl_Gender)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panel_Header)
        Me.Controls.Add(Me.lbl_Pnum)
        Me.Controls.Add(Me.lbl_AttendingP)
        Me.Controls.Add(Me.lbl_Age)
        Me.Controls.Add(Me.lbl_Bdate)
        Me.Controls.Add(Me.lbl_DateofR)
        Me.Controls.Add(Me.lbl_Mname)
        Me.Controls.Add(Me.lbl_Lname)
        Me.Controls.Add(Me.lbl_Fname)
        Me.Controls.Add(Me.date_Registered)
        Me.Controls.Add(Me.rb_Female)
        Me.Controls.Add(Me.rb_Male)
        Me.Controls.Add(Me.date_Bdate)
        Me.Controls.Add(Me.txt_Pnum)
        Me.Controls.Add(Me.txt_Cnum)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.txt_Age)
        Me.Controls.Add(Me.txt_Mname)
        Me.Controls.Add(Me.txt_Lname)
        Me.Controls.Add(Me.txt_Fname)
        Me.Controls.Add(Me.addpatient)
        Me.Controls.Add(Me.txt_PIDName)
        Me.Controls.Add(Me.pic_Profile)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Add_Patient"
        Me.Text = "Add Patient"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panel_Header.ResumeLayout(False)
        Me.panel_Header.PerformLayout()
        Me.panel_Body.ResumeLayout(False)
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_Profile As PictureBox
    Friend WithEvents txt_PIDName As TextBox
    Friend WithEvents addpatient As Button
    Friend WithEvents txt_Fname As TextBox
    Friend WithEvents txt_Lname As TextBox
    Friend WithEvents txt_Mname As TextBox
    Friend WithEvents txt_Age As TextBox
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents txt_Cnum As TextBox
    Friend WithEvents txt_Pnum As TextBox
    Friend WithEvents date_Bdate As DateTimePicker
    Friend WithEvents rb_Male As RadioButton
    Friend WithEvents rb_Female As RadioButton
    Friend WithEvents date_Registered As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents lbl_Pnum As Label
    Friend WithEvents lbl_AttendingP As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents lbl_Bdate As Label
    Friend WithEvents lbl_DateofR As Label
    Friend WithEvents lbl_Mname As Label
    Friend WithEvents lbl_Lname As Label
    Friend WithEvents lbl_Fname As Label
    Friend WithEvents panel_Header As Panel
    Friend WithEvents lbl_Header3 As Label
    Friend WithEvents lbl_Header2 As Label
    Friend WithEvents lbl_Header1 As Label
    Friend WithEvents btn_Logout As Button
    Friend WithEvents btn_Back As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Weight As TextBox
    Friend WithEvents txt_Height As TextBox
    Friend WithEvents lbl_BloodP As Label
    Friend WithEvents lbl_Weight As Label
    Friend WithEvents lbl_Height As Label
    Friend WithEvents lbl_MedicineTR As Label
    Friend WithEvents lbl_PurposeofC As Label
    Friend WithEvents lbl_Cnum As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Gender As Label
    Friend WithEvents lbl_Profilepic As Label
    Friend WithEvents panel_Body As Panel
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents umbrella_logo As Button
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents pic_Minimize As PictureBox
    Friend WithEvents btn_Clear As Button
    Friend WithEvents box_MedTR As ComboBox
    Friend WithEvents box_AttendingP As ComboBox
    Friend WithEvents txt_PurposeofC As RichTextBox
    Friend WithEvents txt_BloodP As ComboBox
    Friend WithEvents btn_AddMed As Button
    Friend WithEvents btn_AddPhysician As Button
End Class
