Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class loginform
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider

    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tool tip
        Dim tt As New ToolTip
        With tt
            .IsBalloon = True
            .UseAnimation = True
            .UseFading = True
        End With
        tt.SetToolTip(txt_RecoverCode, "Incase you forgot your password in the future, better prepare an unforgettable code.")
        Me.CenterToScreen()
    End Sub

    'BUTTONS

    'Disable or Enable Character Block (For Password)
    Private Sub Pic_Eye_Click(sender As Object, e As EventArgs) Handles pic_Eye.Click
        If password.UseSystemPasswordChar = True Then
            pic_Eye.Image = My.Resources.hide_password
            pic_Eye.SizeMode = PictureBoxSizeMode.Zoom
            password.UseSystemPasswordChar = False
        Else
            pic_Eye.Image = My.Resources.show_password
            pic_Eye.SizeMode = PictureBoxSizeMode.Zoom
            password.UseSystemPasswordChar = True
        End If
    End Sub

    'Disable or Enable Character Block (For Recovery Code)
    Private Sub Pic_Eye2_Click(sender As Object, e As EventArgs) Handles pic_Eye2.Click
        If txt_RecoverCode.UseSystemPasswordChar = True Then
            pic_Eye2.Image = My.Resources.hide_password
            pic_Eye2.SizeMode = PictureBoxSizeMode.Zoom
            txt_RecoverCode.UseSystemPasswordChar = False
        Else
            pic_Eye2.Image = My.Resources.show_password
            pic_Eye2.SizeMode = PictureBoxSizeMode.Zoom
            txt_RecoverCode.UseSystemPasswordChar = True
        End If
    End Sub

    'Check Username and Password, if Correct Brings you to Mainform
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Dim con As New MYDB_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim uname As String = username.Text
        Dim pass As String = password.Text

        'login with database

        If uname.Trim() = "" Then
            MessageBox.Show("Enter your Username to Login", "Username Empty", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf pass.Trim() = "" Then
            MessageBox.Show("Enter your Password to Login", "Password Empty", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim command As New MySqlCommand("SELECT UserName, Password FROM admin where UserName=@username and Password=@password", con.GetConnection)
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = uname

            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Encrypt(pass, "abc")
            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Me.Hide()
                Umbrella_Corp.Show()
                username.Text = ""
                password.Text = ""

            Else
                MessageBox.Show("Incorrect Username or Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    'Check if Username and Recovery Code Exist, if not, Create a New Account
    Private Sub Btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click

        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim uname As String = username.Text
        Dim pass As String = password.Text
        Dim recover As String = txt_RecoverCode.Text

        If uname.Trim() = "" Or pass.Trim() = "" Or recover.Trim() = "" Then
            MessageBox.Show("One or more fields are empty", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Ifunameexist(uname) Then
            MessageBox.Show("This username already exist, please choose another one.", "Username Exist!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Ifreccodeexist(recover) Then
            MessageBox.Show("This recovery code already exist, please choose another one.", "Recovery Code Exist!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim con As New MYDB_CONNECTION()
            Dim command As New MySqlCommand("INSERT INTO admin (UserName,Password,RecoveryNumber) values (@username,@password,@recover)", con.GetConnection())

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = uname
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Encrypt(pass, "abc")
            command.Parameters.Add("@recover", MySqlDbType.Int64).Value = recover
            con.OpenConnection()

            If command.ExecuteNonQuery() = 1 Then
                username.Text = ""
                password.Text = ""
                txt_RecoverCode.Text = ""
                MessageBox.Show("You are now registered", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.ClosedConnection()
            End If
        End If

    End Sub

    'Shows Admin Code Window
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        If AdminToolStripMenuItem.Text = "Deactivate Admin Mode" Then
            btn_Create.Visible = False
            lbl_RecoverCode.Visible = False
            txt_RecoverCode.Visible = False
            pic_Eye2.Visible = False
            btn_Login.Visible = True
            btn_Login.Enabled = True
            btn_Forgot.Visible = True
            txt_RecoverCode.Text = ""
            LoginToolStripMenuItem.Text = "LOGIN"
            AdminToolStripMenuItem.Text = "Activate Admin Mode"
        Else
            AdminPass.Show()
        End If
    End Sub

    'Shows Account Recovery Window
    Private Sub btn_Forgot_Click(sender As Object, e As EventArgs) Handles btn_Forgot.Click
        Me.Hide()
        Recover.Show()
    End Sub

    'FUNCTIONS

    'Incrypt Password
    Public Function MD5Hash(ByVal pass As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass))
    End Function

    Public Function Encrypt(ByVal StringInput As String, ByVal key As String) As String
        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(StringInput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function

    'Check If User Name Exist
    Public Function Ifunameexist(ByVal uname As String) As Boolean
        Dim con As New MYDB_CONNECTION()
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM admin where Username=@username", con.GetConnection())

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = uname
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Check If Recovery Code Exist
    Public Function Ifreccodeexist(ByVal code As String) As Boolean
        Dim con As New MYDB_CONNECTION()
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM admin where RecoveryNumber=@txt_RecoverCode", con.GetConnection())

        command.Parameters.Add("@txt_RecoverCode", MySqlDbType.VarChar).Value = code
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'VARIOUS OPTIONS

    'Recovery Code txtbox Integer Only
    Private Sub Txt_RecoverCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_RecoverCode.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'Enter Key Shortcut
    Private Sub Username_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles username.KeyDown, password.KeyDown, txt_RecoverCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btn_Login.Enabled = False Then
                btn_Create.PerformClick()
            Else
                btn_Login.PerformClick()
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
