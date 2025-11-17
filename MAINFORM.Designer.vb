<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Umbrella_Corp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Umbrella_Corp))
        Me.txt_SearchID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_SearchID = New System.Windows.Forms.Button()
        Me.lbl_Fname = New System.Windows.Forms.Label()
        Me.lbl_Lname = New System.Windows.Forms.Label()
        Me.lbl_Mname = New System.Windows.Forms.Label()
        Me.lbl_DateofR = New System.Windows.Forms.Label()
        Me.lbl_Bdate = New System.Windows.Forms.Label()
        Me.lbl_Age = New System.Windows.Forms.Label()
        Me.lbl_Gender = New System.Windows.Forms.Label()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.lbl_Cnum = New System.Windows.Forms.Label()
        Me.txt_Mname = New System.Windows.Forms.TextBox()
        Me.txt_Lname = New System.Windows.Forms.TextBox()
        Me.txt_Fname = New System.Windows.Forms.TextBox()
        Me.txt_Age = New System.Windows.Forms.TextBox()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.txt_Cnum = New System.Windows.Forms.TextBox()
        Me.rb_Male = New System.Windows.Forms.RadioButton()
        Me.rb_Female = New System.Windows.Forms.RadioButton()
        Me.btn_Remove = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.lbl_Body1 = New System.Windows.Forms.Label()
        Me.date_Bdate = New System.Windows.Forms.DateTimePicker()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.lbl_PurposeofC = New System.Windows.Forms.Label()
        Me.lbl_AttendingP = New System.Windows.Forms.Label()
        Me.lbl_MedTR = New System.Windows.Forms.Label()
        Me.date_Registered = New System.Windows.Forms.DateTimePicker()
        Me.txt_SearchLname = New System.Windows.Forms.TextBox()
        Me.btn_Refresh = New System.Windows.Forms.Button()
        Me.lbl_Pnum = New System.Windows.Forms.Label()
        Me.txt_Pnum = New System.Windows.Forms.TextBox()
        Me.lbl_Body2 = New System.Windows.Forms.Label()
        Me.panel_Header = New System.Windows.Forms.Panel()
        Me.lbl_Header3 = New System.Windows.Forms.Label()
        Me.lbl_Header2 = New System.Windows.Forms.Label()
        Me.lbl_Header1 = New System.Windows.Forms.Label()
        Me.umbrella_logo = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel_Body = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.lbl_Height = New System.Windows.Forms.Label()
        Me.txt_Height = New System.Windows.Forms.TextBox()
        Me.lbl_Weight = New System.Windows.Forms.Label()
        Me.txt_Weight = New System.Windows.Forms.TextBox()
        Me.lbl_BloodP = New System.Windows.Forms.Label()
        Me.box_AttendingP = New System.Windows.Forms.ComboBox()
        Me.box_MedTR = New System.Windows.Forms.ComboBox()
        Me.txt_PurposeofC = New System.Windows.Forms.RichTextBox()
        Me.pic_Exit = New System.Windows.Forms.PictureBox()
        Me.pic_Minimize = New System.Windows.Forms.PictureBox()
        Me.pic_Profile = New System.Windows.Forms.PictureBox()
        Me.txt_PIDName = New System.Windows.Forms.TextBox()
        Me.lbl_ProfilePic = New System.Windows.Forms.Label()
        Me.txt_BloodP = New System.Windows.Forms.ComboBox()
        Me.btn_AddPhysician = New System.Windows.Forms.Button()
        Me.btn_AddMed = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Header.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.panel_Body.SuspendLayout()
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_SearchID
        '
        Me.txt_SearchID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_SearchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SearchID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SearchID.Location = New System.Drawing.Point(19, 16)
        Me.txt_SearchID.Name = "txt_SearchID"
        Me.txt_SearchID.Size = New System.Drawing.Size(66, 23)
        Me.txt_SearchID.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(927, 250)
        Me.DataGridView1.TabIndex = 26
        Me.DataGridView1.TabStop = False
        '
        'btn_SearchID
        '
        Me.btn_SearchID.AutoSize = True
        Me.btn_SearchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SearchID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SearchID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_SearchID.Location = New System.Drawing.Point(91, 12)
        Me.btn_SearchID.Name = "btn_SearchID"
        Me.btn_SearchID.Size = New System.Drawing.Size(91, 30)
        Me.btn_SearchID.TabIndex = 2
        Me.btn_SearchID.Text = "Search ID"
        Me.btn_SearchID.UseVisualStyleBackColor = True
        '
        'lbl_Fname
        '
        Me.lbl_Fname.AutoSize = True
        Me.lbl_Fname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fname.Location = New System.Drawing.Point(98, 90)
        Me.lbl_Fname.Name = "lbl_Fname"
        Me.lbl_Fname.Size = New System.Drawing.Size(73, 17)
        Me.lbl_Fname.TabIndex = 0
        Me.lbl_Fname.Text = "Firstname"
        '
        'lbl_Lname
        '
        Me.lbl_Lname.AutoSize = True
        Me.lbl_Lname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lname.Location = New System.Drawing.Point(98, 116)
        Me.lbl_Lname.Name = "lbl_Lname"
        Me.lbl_Lname.Size = New System.Drawing.Size(73, 17)
        Me.lbl_Lname.TabIndex = 0
        Me.lbl_Lname.Text = "Lastname"
        '
        'lbl_Mname
        '
        Me.lbl_Mname.AutoSize = True
        Me.lbl_Mname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mname.Location = New System.Drawing.Point(75, 142)
        Me.lbl_Mname.Name = "lbl_Mname"
        Me.lbl_Mname.Size = New System.Drawing.Size(96, 17)
        Me.lbl_Mname.TabIndex = 0
        Me.lbl_Mname.Text = "Middlename"
        '
        'lbl_DateofR
        '
        Me.lbl_DateofR.AutoSize = True
        Me.lbl_DateofR.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DateofR.Location = New System.Drawing.Point(32, 168)
        Me.lbl_DateofR.Name = "lbl_DateofR"
        Me.lbl_DateofR.Size = New System.Drawing.Size(139, 17)
        Me.lbl_DateofR.TabIndex = 0
        Me.lbl_DateofR.Text = "Date of Registration"
        '
        'lbl_Bdate
        '
        Me.lbl_Bdate.AutoSize = True
        Me.lbl_Bdate.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bdate.Location = New System.Drawing.Point(99, 194)
        Me.lbl_Bdate.Name = "lbl_Bdate"
        Me.lbl_Bdate.Size = New System.Drawing.Size(72, 17)
        Me.lbl_Bdate.TabIndex = 0
        Me.lbl_Bdate.Text = "Birth Date"
        '
        'lbl_Age
        '
        Me.lbl_Age.AutoSize = True
        Me.lbl_Age.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Age.Location = New System.Drawing.Point(135, 272)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(36, 17)
        Me.lbl_Age.TabIndex = 0
        Me.lbl_Age.Text = "Age"
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gender.Location = New System.Drawing.Point(112, 299)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(59, 17)
        Me.lbl_Gender.TabIndex = 0
        Me.lbl_Gender.Text = "Gender"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.Location = New System.Drawing.Point(494, 90)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(61, 17)
        Me.lbl_Address.TabIndex = 0
        Me.lbl_Address.Text = "Address"
        '
        'lbl_Cnum
        '
        Me.lbl_Cnum.AutoSize = True
        Me.lbl_Cnum.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cnum.Location = New System.Drawing.Point(435, 116)
        Me.lbl_Cnum.Name = "lbl_Cnum"
        Me.lbl_Cnum.Size = New System.Drawing.Size(120, 17)
        Me.lbl_Cnum.TabIndex = 0
        Me.lbl_Cnum.Text = "Contact Number"
        '
        'txt_Mname
        '
        Me.txt_Mname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Mname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Mname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mname.Location = New System.Drawing.Point(177, 142)
        Me.txt_Mname.Name = "txt_Mname"
        Me.txt_Mname.Size = New System.Drawing.Size(187, 21)
        Me.txt_Mname.TabIndex = 5
        '
        'txt_Lname
        '
        Me.txt_Lname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Lname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Lname.Location = New System.Drawing.Point(177, 117)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.Size = New System.Drawing.Size(187, 21)
        Me.txt_Lname.TabIndex = 4
        '
        'txt_Fname
        '
        Me.txt_Fname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Fname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fname.Location = New System.Drawing.Point(177, 90)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.Size = New System.Drawing.Size(187, 21)
        Me.txt_Fname.TabIndex = 3
        '
        'txt_Age
        '
        Me.txt_Age.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Age.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Age.Location = New System.Drawing.Point(177, 272)
        Me.txt_Age.Name = "txt_Age"
        Me.txt_Age.Size = New System.Drawing.Size(187, 21)
        Me.txt_Age.TabIndex = 10
        '
        'txt_Address
        '
        Me.txt_Address.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Address.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Location = New System.Drawing.Point(561, 91)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(190, 21)
        Me.txt_Address.TabIndex = 13
        '
        'txt_Cnum
        '
        Me.txt_Cnum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Cnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cnum.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cnum.Location = New System.Drawing.Point(561, 117)
        Me.txt_Cnum.Name = "txt_Cnum"
        Me.txt_Cnum.Size = New System.Drawing.Size(190, 21)
        Me.txt_Cnum.TabIndex = 14
        '
        'rb_Male
        '
        Me.rb_Male.AutoSize = True
        Me.rb_Male.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Male.Location = New System.Drawing.Point(177, 299)
        Me.rb_Male.Name = "rb_Male"
        Me.rb_Male.Size = New System.Drawing.Size(52, 19)
        Me.rb_Male.TabIndex = 11
        Me.rb_Male.TabStop = True
        Me.rb_Male.Text = "Male"
        Me.rb_Male.UseVisualStyleBackColor = True
        '
        'rb_Female
        '
        Me.rb_Female.AutoSize = True
        Me.rb_Female.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Female.Location = New System.Drawing.Point(235, 299)
        Me.rb_Female.Name = "rb_Female"
        Me.rb_Female.Size = New System.Drawing.Size(64, 19)
        Me.rb_Female.TabIndex = 12
        Me.rb_Female.TabStop = True
        Me.rb_Female.Text = "Female"
        Me.rb_Female.UseVisualStyleBackColor = True
        '
        'btn_Remove
        '
        Me.btn_Remove.AutoSize = True
        Me.btn_Remove.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_Remove.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Remove.FlatAppearance.BorderSize = 2
        Me.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Remove.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Remove.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_Remove.Location = New System.Drawing.Point(386, 334)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(175, 33)
        Me.btn_Remove.TabIndex = 22
        Me.btn_Remove.Text = "Remove Patient Info"
        Me.btn_Remove.UseVisualStyleBackColor = False
        '
        'btn_Update
        '
        Me.btn_Update.AutoSize = True
        Me.btn_Update.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_Update.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Update.FlatAppearance.BorderSize = 2
        Me.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_Update.Location = New System.Drawing.Point(212, 334)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(168, 33)
        Me.btn_Update.TabIndex = 21
        Me.btn_Update.Text = "Update Patient Info"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.AutoSize = True
        Me.btn_Add.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_Add.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Add.FlatAppearance.BorderSize = 2
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_Add.Location = New System.Drawing.Point(41, 334)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(165, 33)
        Me.btn_Add.TabIndex = 20
        Me.btn_Add.Text = "Add New Patient"
        Me.btn_Add.UseVisualStyleBackColor = False
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
        Me.btn_Clear.Location = New System.Drawing.Point(567, 334)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(165, 33)
        Me.btn_Clear.TabIndex = 23
        Me.btn_Clear.Text = "Clear All Fields"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'lbl_Body1
        '
        Me.lbl_Body1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Body1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Body1.Location = New System.Drawing.Point(344, 15)
        Me.lbl_Body1.Name = "lbl_Body1"
        Me.lbl_Body1.Size = New System.Drawing.Size(277, 29)
        Me.lbl_Body1.TabIndex = 0
        Me.lbl_Body1.Text = "PATIENT RECORDS"
        Me.lbl_Body1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'date_Bdate
        '
        Me.date_Bdate.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        Me.date_Bdate.CalendarTitleBackColor = System.Drawing.Color.CadetBlue
        Me.date_Bdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_Bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_Bdate.Location = New System.Drawing.Point(177, 194)
        Me.date_Bdate.Name = "date_Bdate"
        Me.date_Bdate.Size = New System.Drawing.Size(187, 21)
        Me.date_Bdate.TabIndex = 7
        Me.date_Bdate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'btn_Logout
        '
        Me.btn_Logout.AutoSize = True
        Me.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Logout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Logout.Location = New System.Drawing.Point(876, 12)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(70, 30)
        Me.btn_Logout.TabIndex = 0
        Me.btn_Logout.TabStop = False
        Me.btn_Logout.Text = "Logout"
        Me.btn_Logout.UseVisualStyleBackColor = True
        '
        'lbl_PurposeofC
        '
        Me.lbl_PurposeofC.AutoSize = True
        Me.lbl_PurposeofC.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PurposeofC.Location = New System.Drawing.Point(418, 220)
        Me.lbl_PurposeofC.Name = "lbl_PurposeofC"
        Me.lbl_PurposeofC.Size = New System.Drawing.Size(137, 17)
        Me.lbl_PurposeofC.TabIndex = 0
        Me.lbl_PurposeofC.Text = "Purpose of Coming"
        '
        'lbl_AttendingP
        '
        Me.lbl_AttendingP.AutoSize = True
        Me.lbl_AttendingP.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AttendingP.Location = New System.Drawing.Point(31, 220)
        Me.lbl_AttendingP.Name = "lbl_AttendingP"
        Me.lbl_AttendingP.Size = New System.Drawing.Size(140, 17)
        Me.lbl_AttendingP.TabIndex = 0
        Me.lbl_AttendingP.Text = "Attending Physician"
        '
        'lbl_MedTR
        '
        Me.lbl_MedTR.AutoSize = True
        Me.lbl_MedTR.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MedTR.Location = New System.Drawing.Point(379, 299)
        Me.lbl_MedTR.Name = "lbl_MedTR"
        Me.lbl_MedTR.Size = New System.Drawing.Size(176, 17)
        Me.lbl_MedTR.TabIndex = 0
        Me.lbl_MedTR.Text = "Medicine Type Received"
        '
        'date_Registered
        '
        Me.date_Registered.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        Me.date_Registered.CalendarTitleBackColor = System.Drawing.Color.CadetBlue
        Me.date_Registered.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_Registered.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_Registered.Location = New System.Drawing.Point(177, 168)
        Me.date_Registered.MaxDate = New Date(2020, 3, 21, 0, 0, 0, 0)
        Me.date_Registered.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.date_Registered.Name = "date_Registered"
        Me.date_Registered.Size = New System.Drawing.Size(187, 21)
        Me.date_Registered.TabIndex = 6
        Me.date_Registered.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'txt_SearchLname
        '
        Me.txt_SearchLname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_SearchLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SearchLname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SearchLname.Location = New System.Drawing.Point(787, 59)
        Me.txt_SearchLname.Name = "txt_SearchLname"
        Me.txt_SearchLname.Size = New System.Drawing.Size(154, 21)
        Me.txt_SearchLname.TabIndex = 25
        '
        'btn_Refresh
        '
        Me.btn_Refresh.AutoSize = True
        Me.btn_Refresh.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_Refresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Refresh.FlatAppearance.BorderSize = 2
        Me.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refresh.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_Refresh.Location = New System.Drawing.Point(14, 52)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(135, 33)
        Me.btn_Refresh.TabIndex = 24
        Me.btn_Refresh.Text = "Refresh"
        Me.btn_Refresh.UseVisualStyleBackColor = False
        '
        'lbl_Pnum
        '
        Me.lbl_Pnum.AutoSize = True
        Me.lbl_Pnum.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pnum.Location = New System.Drawing.Point(59, 246)
        Me.lbl_Pnum.Name = "lbl_Pnum"
        Me.lbl_Pnum.Size = New System.Drawing.Size(112, 17)
        Me.lbl_Pnum.TabIndex = 0
        Me.lbl_Pnum.Text = "Patient Number"
        '
        'txt_Pnum
        '
        Me.txt_Pnum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Pnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Pnum.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pnum.Location = New System.Drawing.Point(177, 246)
        Me.txt_Pnum.Name = "txt_Pnum"
        Me.txt_Pnum.Size = New System.Drawing.Size(187, 21)
        Me.txt_Pnum.TabIndex = 9
        '
        'lbl_Body2
        '
        Me.lbl_Body2.AutoSize = True
        Me.lbl_Body2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Body2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Body2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Body2.Location = New System.Drawing.Point(645, 58)
        Me.lbl_Body2.Name = "lbl_Body2"
        Me.lbl_Body2.Size = New System.Drawing.Size(137, 19)
        Me.lbl_Body2.TabIndex = 0
        Me.lbl_Body2.Text = "Search Last Name:"
        '
        'panel_Header
        '
        Me.panel_Header.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Header.Controls.Add(Me.lbl_Header3)
        Me.panel_Header.Controls.Add(Me.lbl_Header2)
        Me.panel_Header.Controls.Add(Me.lbl_Header1)
        Me.panel_Header.Controls.Add(Me.txt_SearchID)
        Me.panel_Header.Controls.Add(Me.btn_SearchID)
        Me.panel_Header.Controls.Add(Me.btn_Logout)
        Me.panel_Header.Controls.Add(Me.umbrella_logo)
        Me.panel_Header.Location = New System.Drawing.Point(-7, 24)
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
        Me.lbl_Header1.Size = New System.Drawing.Size(93, 13)
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(955, 28)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk
        Me.FileToolStripMenuItem.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.patient_records_512
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.FileToolStripMenuItem.Text = "HEALTH CENTER RECORDS"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'panel_Body
        '
        Me.panel_Body.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panel_Body.Controls.Add(Me.lbl_Body1)
        Me.panel_Body.Controls.Add(Me.DataGridView1)
        Me.panel_Body.Controls.Add(Me.lbl_Body2)
        Me.panel_Body.Controls.Add(Me.btn_Refresh)
        Me.panel_Body.Controls.Add(Me.txt_SearchLname)
        Me.panel_Body.Location = New System.Drawing.Point(0, 379)
        Me.panel_Body.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_Body.Name = "panel_Body"
        Me.panel_Body.Size = New System.Drawing.Size(955, 355)
        Me.panel_Body.TabIndex = 0
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
        'lbl_Height
        '
        Me.lbl_Height.AutoSize = True
        Me.lbl_Height.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Height.Location = New System.Drawing.Point(503, 142)
        Me.lbl_Height.Name = "lbl_Height"
        Me.lbl_Height.Size = New System.Drawing.Size(52, 17)
        Me.lbl_Height.TabIndex = 0
        Me.lbl_Height.Text = "Height"
        '
        'txt_Height
        '
        Me.txt_Height.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Height.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Height.Location = New System.Drawing.Point(561, 143)
        Me.txt_Height.Name = "txt_Height"
        Me.txt_Height.Size = New System.Drawing.Size(190, 21)
        Me.txt_Height.TabIndex = 15
        '
        'lbl_Weight
        '
        Me.lbl_Weight.AutoSize = True
        Me.lbl_Weight.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Weight.Location = New System.Drawing.Point(500, 168)
        Me.lbl_Weight.Name = "lbl_Weight"
        Me.lbl_Weight.Size = New System.Drawing.Size(55, 17)
        Me.lbl_Weight.TabIndex = 0
        Me.lbl_Weight.Text = "Weight"
        '
        'txt_Weight
        '
        Me.txt_Weight.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Weight.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Weight.Location = New System.Drawing.Point(561, 169)
        Me.txt_Weight.Name = "txt_Weight"
        Me.txt_Weight.Size = New System.Drawing.Size(190, 21)
        Me.txt_Weight.TabIndex = 16
        '
        'lbl_BloodP
        '
        Me.lbl_BloodP.AutoSize = True
        Me.lbl_BloodP.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BloodP.Location = New System.Drawing.Point(450, 194)
        Me.lbl_BloodP.Name = "lbl_BloodP"
        Me.lbl_BloodP.Size = New System.Drawing.Size(105, 17)
        Me.lbl_BloodP.TabIndex = 0
        Me.lbl_BloodP.Text = "Blood Pressure"
        '
        'box_AttendingP
        '
        Me.box_AttendingP.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.box_AttendingP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_AttendingP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_AttendingP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.box_AttendingP.FormattingEnabled = True
        Me.box_AttendingP.ItemHeight = 16
        Me.box_AttendingP.Location = New System.Drawing.Point(177, 219)
        Me.box_AttendingP.Name = "box_AttendingP"
        Me.box_AttendingP.Size = New System.Drawing.Size(187, 24)
        Me.box_AttendingP.TabIndex = 8
        Me.box_AttendingP.Text = "None"
        '
        'box_MedTR
        '
        Me.box_MedTR.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.box_MedTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_MedTR.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_MedTR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.box_MedTR.FormattingEnabled = True
        Me.box_MedTR.ItemHeight = 16
        Me.box_MedTR.Location = New System.Drawing.Point(561, 298)
        Me.box_MedTR.Name = "box_MedTR"
        Me.box_MedTR.Size = New System.Drawing.Size(190, 24)
        Me.box_MedTR.TabIndex = 19
        Me.box_MedTR.Text = "None"
        '
        'txt_PurposeofC
        '
        Me.txt_PurposeofC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_PurposeofC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PurposeofC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_PurposeofC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PurposeofC.Location = New System.Drawing.Point(561, 222)
        Me.txt_PurposeofC.Name = "txt_PurposeofC"
        Me.txt_PurposeofC.Size = New System.Drawing.Size(190, 72)
        Me.txt_PurposeofC.TabIndex = 82
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
        Me.pic_Exit.TabIndex = 52
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
        Me.pic_Minimize.TabIndex = 53
        Me.pic_Minimize.TabStop = False
        '
        'pic_Profile
        '
        Me.pic_Profile.BackColor = System.Drawing.Color.Transparent
        Me.pic_Profile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Profile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_Profile.Image = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.profile_avatar_png_1
        Me.pic_Profile.Location = New System.Drawing.Point(774, 91)
        Me.pic_Profile.Name = "pic_Profile"
        Me.pic_Profile.Size = New System.Drawing.Size(150, 150)
        Me.pic_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Profile.TabIndex = 0
        Me.pic_Profile.TabStop = False
        '
        'txt_PIDName
        '
        Me.txt_PIDName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_PIDName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_PIDName.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PIDName.Location = New System.Drawing.Point(774, 249)
        Me.txt_PIDName.Name = "txt_PIDName"
        Me.txt_PIDName.ReadOnly = True
        Me.txt_PIDName.Size = New System.Drawing.Size(150, 13)
        Me.txt_PIDName.TabIndex = 0
        Me.txt_PIDName.TabStop = False
        Me.txt_PIDName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_PIDName.Visible = False
        '
        'lbl_ProfilePic
        '
        Me.lbl_ProfilePic.AutoSize = True
        Me.lbl_ProfilePic.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ProfilePic.Location = New System.Drawing.Point(803, 246)
        Me.lbl_ProfilePic.Name = "lbl_ProfilePic"
        Me.lbl_ProfilePic.Size = New System.Drawing.Size(100, 17)
        Me.lbl_ProfilePic.TabIndex = 117
        Me.lbl_ProfilePic.Text = "Profile Picture"
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
        Me.txt_BloodP.Location = New System.Drawing.Point(561, 194)
        Me.txt_BloodP.Name = "txt_BloodP"
        Me.txt_BloodP.Size = New System.Drawing.Size(190, 24)
        Me.txt_BloodP.TabIndex = 19
        Me.txt_BloodP.Text = "None"
        '
        'btn_AddPhysician
        '
        Me.btn_AddPhysician.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddPhysician.BackgroundImage = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.add_photo_icon_1
        Me.btn_AddPhysician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_AddPhysician.FlatAppearance.BorderSize = 0
        Me.btn_AddPhysician.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddPhysician.Location = New System.Drawing.Point(370, 220)
        Me.btn_AddPhysician.Name = "btn_AddPhysician"
        Me.btn_AddPhysician.Size = New System.Drawing.Size(25, 24)
        Me.btn_AddPhysician.TabIndex = 118
        Me.btn_AddPhysician.TabStop = False
        Me.btn_AddPhysician.UseVisualStyleBackColor = False
        '
        'btn_AddMed
        '
        Me.btn_AddMed.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddMed.BackgroundImage = Global.HEALTHCARE_CENTER_RECORDS_SYSTEM.My.Resources.Resources.add_photo_icon_1
        Me.btn_AddMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_AddMed.FlatAppearance.BorderSize = 0
        Me.btn_AddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddMed.Location = New System.Drawing.Point(757, 299)
        Me.btn_AddMed.Name = "btn_AddMed"
        Me.btn_AddMed.Size = New System.Drawing.Size(25, 23)
        Me.btn_AddMed.TabIndex = 118
        Me.btn_AddMed.TabStop = False
        Me.btn_AddMed.UseVisualStyleBackColor = False
        '
        'Umbrella_Corp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(955, 730)
        Me.Controls.Add(Me.btn_AddMed)
        Me.Controls.Add(Me.btn_AddPhysician)
        Me.Controls.Add(Me.lbl_ProfilePic)
        Me.Controls.Add(Me.txt_PurposeofC)
        Me.Controls.Add(Me.box_AttendingP)
        Me.Controls.Add(Me.txt_BloodP)
        Me.Controls.Add(Me.box_MedTR)
        Me.Controls.Add(Me.pic_Exit)
        Me.Controls.Add(Me.pic_Minimize)
        Me.Controls.Add(Me.panel_Header)
        Me.Controls.Add(Me.txt_Pnum)
        Me.Controls.Add(Me.lbl_Pnum)
        Me.Controls.Add(Me.date_Registered)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txt_Weight)
        Me.Controls.Add(Me.txt_Height)
        Me.Controls.Add(Me.date_Bdate)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Remove)
        Me.Controls.Add(Me.rb_Female)
        Me.Controls.Add(Me.rb_Male)
        Me.Controls.Add(Me.txt_Cnum)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.txt_Age)
        Me.Controls.Add(Me.txt_Fname)
        Me.Controls.Add(Me.lbl_BloodP)
        Me.Controls.Add(Me.txt_Lname)
        Me.Controls.Add(Me.lbl_Weight)
        Me.Controls.Add(Me.txt_Mname)
        Me.Controls.Add(Me.lbl_Height)
        Me.Controls.Add(Me.lbl_MedTR)
        Me.Controls.Add(Me.lbl_AttendingP)
        Me.Controls.Add(Me.lbl_PurposeofC)
        Me.Controls.Add(Me.lbl_Cnum)
        Me.Controls.Add(Me.lbl_Address)
        Me.Controls.Add(Me.lbl_Gender)
        Me.Controls.Add(Me.lbl_Age)
        Me.Controls.Add(Me.lbl_Bdate)
        Me.Controls.Add(Me.lbl_DateofR)
        Me.Controls.Add(Me.lbl_Mname)
        Me.Controls.Add(Me.lbl_Lname)
        Me.Controls.Add(Me.lbl_Fname)
        Me.Controls.Add(Me.txt_PIDName)
        Me.Controls.Add(Me.pic_Profile)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.panel_Body)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Umbrella_Corp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "HEALTH CENTER RECORDS"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Header.ResumeLayout(False)
        Me.panel_Header.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panel_Body.ResumeLayout(False)
        Me.panel_Body.PerformLayout()
        CType(Me.pic_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_Profile As PictureBox
    Friend WithEvents txt_SearchID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_SearchID As Button
    Friend WithEvents lbl_Fname As Label
    Friend WithEvents lbl_Lname As Label
    Friend WithEvents lbl_Mname As Label
    Friend WithEvents lbl_DateofR As Label
    Friend WithEvents lbl_Bdate As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents lbl_Gender As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Cnum As Label
    Friend WithEvents txt_Mname As TextBox
    Friend WithEvents txt_Lname As TextBox
    Friend WithEvents txt_Fname As TextBox
    Friend WithEvents txt_Age As TextBox
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents txt_Cnum As TextBox
    Friend WithEvents rb_Male As RadioButton
    Friend WithEvents rb_Female As RadioButton
    Friend WithEvents btn_Remove As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents lbl_Body1 As Label
    Friend WithEvents date_Bdate As DateTimePicker
    Friend WithEvents btn_Logout As Button
    Friend WithEvents lbl_PurposeofC As Label
    Friend WithEvents lbl_AttendingP As Label
    Friend WithEvents lbl_MedTR As Label
    Friend WithEvents date_Registered As DateTimePicker
    Friend WithEvents txt_SearchLname As TextBox
    Friend WithEvents btn_Refresh As Button
    Friend WithEvents lbl_Pnum As Label
    Friend WithEvents txt_Pnum As TextBox
    Friend WithEvents lbl_Body2 As Label
    Friend WithEvents panel_Header As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_Header3 As Label
    Friend WithEvents lbl_Header2 As Label
    Friend WithEvents lbl_Header1 As Label
    Friend WithEvents panel_Body As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents lbl_Height As Label
    Friend WithEvents txt_Height As TextBox
    Friend WithEvents lbl_Weight As Label
    Friend WithEvents txt_Weight As TextBox
    Friend WithEvents lbl_BloodP As Label
    Friend WithEvents umbrella_logo As Button
    Friend WithEvents pic_Exit As PictureBox
    Friend WithEvents pic_Minimize As PictureBox
    Friend WithEvents box_AttendingP As ComboBox
    Friend WithEvents box_MedTR As ComboBox
    Friend WithEvents txt_PurposeofC As RichTextBox
    Friend WithEvents txt_PIDName As TextBox
    Friend WithEvents lbl_ProfilePic As Label
    Friend WithEvents txt_BloodP As ComboBox
    Friend WithEvents btn_AddPhysician As Button
    Friend WithEvents btn_AddMed As Button
End Class
