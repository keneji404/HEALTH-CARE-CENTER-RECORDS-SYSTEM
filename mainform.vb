Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.IO

Public Class Umbrella_Corp

    Dim com As New MySqlCommand
    Dim table As New DataTable

    Private Sub MAINFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Table()
        loaddoc()
        loadmed()

        Me.TransparencyKey = Color.Empty
        date_Registered.MaxDate = Date.Today
        date_Registered.Value = Date.Today
        Me.CenterToScreen()
    End Sub

    Private Sub Load_Table()
        Dim con As New MYDB_CONNECTION
        Dim MysqlConn As New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password='';database=healthcenter"
        Dim Adapter As New MySqlDataAdapter

        Dim source As New BindingSource
        Try

            MysqlConn.Open()
            Dim query As String
            query = "select * from healthcenter.patient"
            com = New MySqlCommand(query, MysqlConn)
            Adapter.SelectCommand = com
            Adapter.Fill(table)
            source.DataSource = table
            DataGridView1.DataSource = source
            Adapter.Update(table)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    'BUTTONS

    'Search ID
    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_SearchID.Click
        Dim con As New MYDB_CONNECTION
        Dim Fname As String = txt_Fname.Text
        Dim Lname As String = txt_Lname.Text
        Dim Mname As String = txt_Mname.Text
        Dim Address As String = txt_Address.Text
        Dim Cnum As String = txt_Cnum.Text
        Dim Age As String = txt_Age.Text
        Dim SearchID As String = txt_SearchID.Text
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
        Dim Registereed As String = Format(date_Registered.Value, "MMM,d,yyyy")
        Dim Height As String = txt_Height.Text
        Dim Weight As String = txt_Weight.Text
        Dim BloodP As String = txt_BloodP.Text

        If SearchID.Trim() = "" Then
            MessageBox.Show("Please type the Patient's Assigned Number to see their record!", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Dim command As New MySqlCommand("SELECT * FROM patient where PatientNumber=@SearchID", con.GetConnection)

            command.Parameters.Add("@SearchID", MySqlDbType.Int64).Value = SearchID
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            If table.Rows.Count > 0 Then 'placing the search data from mysql into the fields
                txt_Pnum.Text = table(0)(0)
                txt_Fname.Text = table(0)(1)
                txt_Mname.Text = table(0)(2)
                txt_Lname.Text = table(0)(3)
                date_Registered.Value = table(0)(4)
                box_AttendingP.Text = table(0)(5)
                txt_PurposeofC.Text = table(0)(6)
                box_MedTR.Text = table(0)(7)
                date_Bdate.Value = table(0)(8)
                txt_Age.Text = table(0)(9)
                txt_Address.Text = table(0)(11)
                txt_Cnum.Text = table(0)(12)
                txt_Height.Text = table(0)(13)
                txt_Weight.Text = table(0)(14)
                txt_BloodP.Text = table(0)(15)
                txt_PIDName.Text = table(0)(16).ToString
                Dim Profile As String = table(0)(16).ToString
                If Profile = "" Then
                    MessageBox.Show("Data Found but doesn't have Profile Picture.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim folder As String = "C:\Users\User\Desktop\HEALTHCARE\patient id\"
                    Dim filename As String = System.IO.Path.Combine(folder, Profile)
                    pic_Profile.Image = Image.FromFile(filename)
                    MessageBox.Show("Data Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Select Case table(0)(10).ToString
                    Case "Male"
                        rb_Male.Checked = True
                    Case "Female"
                        rb_Female.Checked = True
                End Select

            Else
                MessageBox.Show("Sorry, No Data Found!", "Data doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    'Lougout to Login Screen
    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        If MessageBox.Show("Do you want to Log Out and go back to Login Screen?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Hide()
            Me.Clear()
            loginform.Show()
        Else
            Me.Show()
        End If
    End Sub

    'Add Profile Picture
    Private Sub picbox_Click(sender As Object, e As EventArgs) Handles pic_Profile.Click
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

    'Shows Add Patient Window
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Me.Hide()
        Add_Patient.Show()
    End Sub

    'Update Patient Data Using ID
    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click

        Dim con As New MYDB_CONNECTION
        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim Pnum As String = txt_Pnum.Text
        Dim Fname As String = txt_Fname.Text
        Dim Lname As String = txt_Lname.Text
        Dim Mname As String = txt_Mname.Text
        Dim Address As String = txt_Address.Text
        Dim Cnum As String = txt_Cnum.Text
        Dim Age As String = txt_Age.Text
        Dim SearchID As String = txt_SearchID.Text
        Dim PIDName As String = txt_PIDName.Text
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

        If SearchID.Trim() = "" Then
            MessageBox.Show("Please search Patient ID to Edit Information!", "No ID Selected!", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Fname.Trim() = "" Or Lname.Trim() = "" Or Mname.Trim() = "" Or Gender.Trim() = "" Or Address.Trim() = "" Or Cnum.Trim() = "" Or Age.Trim() = "" Or Registered.Trim() = "" Or Bdate.Trim() = "" Or AttendingP.Trim() = "" Or PurposeofC.Trim() = "" Or MedTR.Trim() = "" Then

            MessageBox.Show("One or more important fields are empty!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            con.OpenConnection()
            Dim command As New MySqlCommand("UPDATE patient SET PatientNumber=@Pnum,FirstName=@Fname,MiddleName=@Mname, LastName=@Lname, DateofRegistration=@Registered, Attending_Physician=@AttendingP, Purpose_of_Coming=@PurposeofC, Medicines_Received=@MedTR, BirthDate=@Bdate, Age=@Age, Gender=@Gender, Address=@Address, ContactNumber=@Cnum, Height=@Height, Weight=@Weight, BloodP=@BloodP, PatientIDName=@pic_Profile where PatientNumber=@SearchID", con.GetConnection)
            With command.Parameters
                .AddWithValue("@SearchID", SearchID)
                .AddWithValue("@Pnum", Pnum)
                .AddWithValue("@Fname", Fname)
                .AddWithValue("@Mname", Mname)
                .AddWithValue("@Lname", Lname)
                .AddWithValue("@Registered", Registered)
                .AddWithValue("@AttendingP", AttendingP)
                .AddWithValue("@PurposeofC", PurposeofC)
                .AddWithValue("@MedTR", MedTR)
                .AddWithValue("@Bdate", Bdate)
                .AddWithValue("@Age", Age)
                .AddWithValue("@Gender", Gender)
                .AddWithValue("@Address", Address)
                .AddWithValue("@Cnum", Cnum)
                .AddWithValue("@Height", Height)
                .AddWithValue("@Weight", Weight)
                .AddWithValue("@BloodP", BloodP)
                .AddWithValue("@pic_Profile", PIDName)

            End With

            adapter.SelectCommand = command
            adapter.Fill(table)

            If command.ExecuteNonQuery() = 1 Then

                UpdateDataGridView()
                MessageBox.Show("Registration Completed Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

                con.ClosedConnection()

            End If
        End If
    End Sub

    'Remove Patient
    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click

        Dim con As New MYDB_CONNECTION
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim searchpatient As String = txt_SearchID.Text

        If searchpatient.Trim = "" Then
            MessageBox.Show("Please search Patients ID to Remove Information", "No ID Selected!", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            If MessageBox.Show("Are you sure you want to Delete the Record of this Patient?!", "Delete Permanently?", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) = DialogResult.Yes Then
                con.OpenConnection()

                Dim command As New MySqlCommand("DELETE from patient where PatientNumber='" + txt_SearchID.Text + "'", con.GetConnection)
                command.ExecuteNonQuery()

                Dim AlterTable As New MySqlCommand("ALTER TABLE patient", con.GetConnection)
                AlterTable.ExecuteNonQuery()
                UpdateDataGridView()
                Clear()
                con.ClosedConnection()

            End If

        End If
    End Sub

    'Reset Textbox to Default
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Clear()
    End Sub

    'Refreshes Datagrid
    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        UpdateDataGridView()
    End Sub

    'Shows Add Physician Window
    Private Sub Btn_AddPhysician_Click(sender As Object, e As EventArgs) Handles btn_AddPhysician.Click
        add_doctor.Show()
    End Sub

    'Shows Add Medicine Window
    Private Sub Btn_AddMed_Click(sender As Object, e As EventArgs) Handles btn_AddMed.Click
        add_medicine.Show()
    End Sub

    'Shows Print Preview Window
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Me.Hide()
        Print_Preview.Show()
    End Sub

    'FUNCTIONS

    'Reset Textboxes
    Public Function Clear() Handles btn_Clear.Click

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

    'Update Data Table
    Public Function UpdateDataGridView()
        Dim con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT * FROM patient", con)
        adapter.Fill(table)
        DataGridView1.DataSource = table
        Return DataGridView1.DataSource
    End Function

    'VARIOUS OPTIONS

    'Search bar Clear when Clicked
    Private Sub Txt_SearchID_Click(sender As Object, e As EventArgs) Handles txt_SearchID.Click
        txt_SearchID.Text = ""
    End Sub

    'Search Last Name
    Private Sub txt_SearchLname_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchLname.TextChanged
        If txt_SearchLname.Text = "" Then
            UpdateDataGridView()
        Else
            UpdateDataGridView()
            Dim adapter As New MySqlDataAdapter()
            Dim con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
            Dim command As New MySqlCommand("SELECT * from  patient", con)
            Dim DV As New DataView(table)

            adapter.SelectCommand = command
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DV.RowFilter = String.Format("LastName Like '%{0}%'", txt_SearchLname.Text)
            DataGridView1.DataSource = DV
        End If
    End Sub

    'Search Control = ENTER KEY
    Private Sub txt_SearchID_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SearchID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_SearchID.PerformClick()
        End If
    End Sub

    'txt_search ID integer only
    Private Sub Txt_SearchID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SearchID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'pnum integer only
    Private Sub Txt_Pnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Pnum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'Print Control = CTRL + P KEY (NOT YET DONE)
    Private Sub Umbrella_Corp_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.P) Then
            PrintToolStripMenuItem.PerformClick()
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