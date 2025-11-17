Imports MySql.Data.MySqlClient

Public Class Add_Patient

    Private Sub Add_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadmed()
        loaddoc()
        date_Registered.MaxDate = Date.Today
        date_Registered.Value = Date.Today
        UpdateDataGridView()
        Me.CenterToScreen()
    End Sub

    'BUTTONS

    'Back to Mainform
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        Clear()
        Umbrella_Corp.UpdateDataGridView()
        Umbrella_Corp.Show()
    End Sub

    'Logout to Login Screen
    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        If MessageBox.Show("Do you want to Log Out and go back to Login Screen?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Hide()
            Clear()
            loginform.Show()
        Else
            Me.Show()
        End If
    End Sub

    'Add Profile Picture
    Private Sub pic_Profile_Click(sender As Object, e As EventArgs) Handles pic_Profile.Click
        Dim IMG_FileNameInput As String
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPEG (.jpeg;.jpg;)|*.jpeg;*.png;*.jpg"
        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput = OpenFileDialog1.FileName
            pic_Profile.ImageLocation = IMG_FileNameInput
            Dim FileToProfile As String = System.IO.Path.GetFileName(IMG_FileNameInput)
            txt_PIDName.Text = FileToProfile

        End If
    End Sub

    'Reset Textbox to Default
    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Clear()
    End Sub

    'Add Patient
    Private Sub Addpatient_Click(sender As Object, e As EventArgs) Handles addpatient.Click

        Dim Fname As String = txt_Fname.Text
        Dim Lname As String = txt_Lname.Text
        Dim Mname As String = txt_Mname.Text
        Dim Address As String = txt_Address.Text
        Dim Cnum As String = txt_Cnum.Text
        Dim Age As String = txt_Age.Text
        Dim Pnum As String = txt_Pnum.Text
        Dim AttendingP As String = box_AttendingP.Text
        Dim PurposeofC As String = txt_PurposeofC.Text
        Dim MedTR As String = box_MedTR.Text
        Dim Gender As String
        If rb_Female.Checked = False And rb_Male.Checked = False Then
            Gender = ""
        ElseIf rb_Male.Checked = True Then
            Gender = "Male"
        Else
            Gender = "Female"
        End If
        Dim Bdate As String = Format(date_Bdate.Value, "MMM,d,yyyy")
        Dim Registered As String = Format(date_Registered.Value, "MMM,d,yyyy")
        Dim Height As String = txt_Height.Text
        Dim Weight As String = txt_Weight.Text
        Dim BloodP As String = txt_BloodP.Text

        If txt_PIDName.Text = "" Then
            MessageBox.Show("One or more Fields are Empty", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Fname.Trim() = "" Or Lname.Trim() = "" Or Mname.Trim() = "" Or Address.Trim() = "" Or Gender.Trim() = "" Or Cnum.Trim() = "" Or Age.Trim() = "" Or Registered.Trim() = "" Or Bdate.Trim() = "" Or AttendingP.Trim() = "" Or PurposeofC.Trim() = "" Or MedTR.Trim() = "" Or Pnum.Trim() = "" Then

            MessageBox.Show("One or more Fields are Empty", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            Dim con As New MYDB_CONNECTION
            Dim command As New MySqlCommand("INSERT INTO patient (PatientNumber,FirstName,MiddleName,LastName,DateofRegistration,Attending_Physician,Purpose_of_Coming,Medicines_Received,BirthDate,Age,Gender,Address,ContactNumber,Height,Weight,BloodP,PatientIDName ) values (@Pnum,@Fname,@Mname,@Lname,@Registered,@AttendingP,@PurposeofC,@MedTR,@Bdate,@Age,@Gender,@Address,@Cnum,@Height,@Weight,@BloodP,@ProfilePic)", con.GetConnection())

            command.Parameters.Add("@Fname", MySqlDbType.VarChar).Value = Fname
            command.Parameters.Add("@Mname", MySqlDbType.VarChar).Value = Mname
            command.Parameters.Add("@Lname", MySqlDbType.VarChar).Value = Lname
            command.Parameters.Add("@Registered", MySqlDbType.VarChar).Value = Registered
            command.Parameters.Add("@AttendingP", MySqlDbType.VarChar).Value = AttendingP
            command.Parameters.Add("@PurposeofC", MySqlDbType.VarChar).Value = PurposeofC
            command.Parameters.Add("@MedTR", MySqlDbType.VarChar).Value = MedTR
            command.Parameters.Add("@Bdate", MySqlDbType.VarChar).Value = Bdate
            command.Parameters.Add("@Age", MySqlDbType.VarChar).Value = Age
            command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = Gender
            command.Parameters.Add("@Address", MySqlDbType.VarChar).Value = Address
            command.Parameters.Add("@Cnum", MySqlDbType.VarChar).Value = Cnum
            command.Parameters.Add("@Height", MySqlDbType.VarChar).Value = Height
            command.Parameters.Add("@Weight", MySqlDbType.VarChar).Value = Weight
            command.Parameters.Add("@BloodP", MySqlDbType.VarChar).Value = BloodP
            command.Parameters.Add("@Pnum", MySqlDbType.VarChar).Value = Pnum
            command.Parameters.Add("@ProfilePic", MySqlDbType.VarChar).Value = txt_PIDName.Text
            pic_Profile.Image.Save("C:\Users\User\Desktop\HEALTHCARE\patient id\" & txt_PIDName.Text & "")
            con.OpenConnection()

            If command.ExecuteNonQuery() = 1 Then
                UpdateDataGridView()
                MessageBox.Show("Registration Completed Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.ClosedConnection()

            End If
        End If
    End Sub

    'Show Add Doctor Window
    Private Sub Btn_AddPhysician_Click(sender As Object, e As EventArgs) Handles btn_AddPhysician.Click
        add_doctor.Show()
    End Sub

    'Show Add Medicine Window
    Private Sub Btn_AddMed_Click(sender As Object, e As EventArgs) Handles btn_AddMed.Click
        add_medicine.Show()
    End Sub

    'FUNCTIONS

    'Load Physician
    Public Function loaddoc()
        Dim con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT *FROM physician", con)

        adapter.Fill(table)

        box_AttendingP.DataSource = table
        box_AttendingP.ValueMember = "doctorname"
        box_AttendingP.DisplayMember = "doctorname"
        Return 0
    End Function

    'Load Medicines
    Public Function loadmed()
        Dim con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT *FROM medicine", con)

        adapter.Fill(table)

        box_MedTR.DataSource = table
        box_MedTR.ValueMember = "medicine_name"
        box_MedTR.DisplayMember = "medicine_name"
        Return 0
    End Function

    'Reset Textboxes
    Private Function Clear() Handles btn_Clear.Click

        txt_Fname.Text = ""
        txt_Mname.Text = ""
        txt_Lname.Text = ""
        txt_Age.Text = ""
        txt_Address.Text = ""
        txt_Cnum.Text = ""
        txt_PIDName.Text = ""
        txt_Pnum.Text = ""
        box_AttendingP.Text = "None"
        txt_PurposeofC.Text = ""
        box_MedTR.Text = "None"
        txt_Lname.Text = ""
        rb_Male.Checked = False
        rb_Female.Checked = False
        date_Bdate.Value = ("1,1,2000")
        date_Registered.MaxDate = Date.Today
        date_Registered.Value = Date.Today
        pic_Profile.Image = My.Resources.profile_avatar_png_1
        txt_Height.Text = ""
        txt_Weight.Text = ""
        txt_BloodP.Text = "None"

        Return 0
    End Function

    'Update Data Table
    Private Function UpdateDataGridView()
        Dim con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT * FROM patient", con)
        adapter.Fill(table)
        DataGridView1.DataSource = table
        Return 0
    End Function

    'VARIOUS OPTIONS

    'pnum integer only input
    Private Sub Txt_Pnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Pnum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'FORM CONTROLS

    'Minimize and Exit Controls
    Private Sub Pic_Minimize_MouseHover(sender As Object, e As EventArgs) Handles pic_Minimize.MouseHover
        pic_Minimize.Image = My.Resources.minimize1
        pic_Minimize.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Pic_Minimize_MouseLeave(sender As Object, e As EventArgs) Handles pic_Minimize.MouseLeave
        pic_Minimize.Image = My.Resources.minimize2
        pic_Minimize.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Pic_Exit_MouseHover(sender As Object, e As EventArgs) Handles pic_Exit.MouseHover
        pic_Exit.Image = My.Resources.exit1
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Pic_Exit_MouseLeave(sender As Object, e As EventArgs) Handles pic_Exit.MouseLeave
        pic_Exit.Image = My.Resources.exit2
        pic_Exit.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Pic_Exit_Click(sender As Object, e As EventArgs) Handles pic_Exit.Click
        Application.Exit()
    End Sub

    Private Sub Pic_Minimize_Click(sender As Object, e As EventArgs) Handles pic_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Form Drag
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub MenuStrip1_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub MenuStrip1_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseUp
        drag = False
    End Sub
End Class