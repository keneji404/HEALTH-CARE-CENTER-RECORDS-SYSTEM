Imports MySql.Data.MySqlClient

Public Class AdminPass

    Private Sub AdminPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    'BUTTONS

    'Back to Login Screen
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        loginform.Show()
    End Sub

    'Check the Code and if Correct Brings you to Create Account Screen
    Private Sub Btn_Enter_Click(sender As Object, e As EventArgs) Handles btn_Enter.Click
        Dim con As New MYDB_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim code As String = txt_AdminCode.Text

        If code.Trim() = "" Then
            My.Computer.Audio.Play("C:\Users\User\Desktop\code_denied.wav")
        Else
            Dim command As New MySqlCommand("SELECT code FROM activate_admin where code=@code", con.GetConnection)
            command.Parameters.Add("@code", MySqlDbType.VarChar).Value = code
            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                My.Computer.Audio.Play("C:\Users\User\Desktop\code_accepted.wav") 'AudioPlayMode.WaitToComplete
                choose.Show()
                Me.Hide()
            Else
                My.Computer.Audio.Play("C:\Users\User\Desktop\code_denied.wav")
            End If
        End If
    End Sub

    'VARIOUS OPTIONS

    'Enter Key Shortcut
    Private Sub Txt_AdminCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_AdminCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Enter.PerformClick()
        End If
    End Sub

    'FORM CONTROLS

    'Form Drag
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub AdminPass_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub AdminPass_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub AdminPass_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    'CUSTOMIZATION

    'button hover
    Private Sub Btn_Enter_MouseHover(sender As Object, e As EventArgs) Handles btn_Enter.MouseHover
        btn_Enter.ForeColor = Color.White
        btn_Enter.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Enter_MouseLeave(sender As Object, e As EventArgs) Handles btn_Enter.MouseLeave
        btn_Enter.ForeColor = Color.DodgerBlue
        btn_Enter.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub Btn_Cancel_MouseHover(sender As Object, e As EventArgs) Handles btn_Cancel.MouseHover
        btn_Cancel.ForeColor = Color.White
        btn_Cancel.BackColor = Color.FromArgb(255, 128, 128)
    End Sub

    Private Sub Btn_Cancel_MouseLeave(sender As Object, e As EventArgs) Handles btn_Cancel.MouseLeave
        btn_Cancel.ForeColor = Color.FromArgb(255, 128, 128)
        btn_Cancel.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
End Class