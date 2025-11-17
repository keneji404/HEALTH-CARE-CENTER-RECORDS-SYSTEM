Imports MySql.Data.MySqlClient

Public Class add_doctor
    Private Sub Add_doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        loadtable()
    End Sub

    'BUTTONS

    'Add Doctor
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        Dim doc As String = txt_Doc.Text

        If txt_Doc.Text = "" Then
            MessageBox.Show("Please Enter Doctor Name!", "Empty Doctor Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf ifdocexist(doc) Then
            MessageBox.Show("Doctor already exist", "Name Exist!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim con As New MYDB_CONNECTION
            Dim command As New MySqlCommand("INSERT INTO physician (doctorname) values (@doc)", con.GetConnection())

            command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = doc

            con.OpenConnection()

            If command.ExecuteNonQuery() = 1 Then
                Clear_Click()
                loadtable()
                Umbrella_Corp.loaddoc()
                Add_Patient.loaddoc()
                MessageBox.Show("Doctor Added", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.ClosedConnection()

            End If
        End If
    End Sub

    'Delete Doctor in Table
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("Do you want to delete {0}?", row.Cells("doctorname").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
                    Using cmd As New MySqlCommand("DELETE FROM physician WHERE doctorname = @doctorname", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@doctorname", row.Cells("doctorname").Value)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using

                loadtable()
                Umbrella_Corp.loaddoc()
                Add_Patient.loaddoc()
            End If
        End If
    End Sub

    'FUNCTIONS

    'Load Datagrid
    Private Function loadtable()
        Dim con As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';")
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter("SELECT doctorname FROM physician", con)
        adapter.Fill(table)
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = table
        DataGridView1.Columns.Item("doctorname").Width = 273
        DataGridView1.AllowUserToAddRows = False

        'add delete button in table
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()

        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Delete"
        buttonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Insert(1, buttonColumn)

        Return DataGridView1.DataSource
    End Function

    'Textbox Reset
    Private Function Clear_Click()
        txt_Doc.Text = ""
        Return 0
    End Function

    'Check if Doctor Already Exist
    Public Function ifdocexist(ByVal doc As String) As Boolean
        Dim con As New MYDB_CONNECTION()
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM physician where doctorname=@txt_Doc", con.GetConnection())

        command.Parameters.Add("@txt_Doc", MySqlDbType.VarChar).Value = doc
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

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
        Me.Close()
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

    Private Sub Txt_Doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Add.PerformClick()
        End If
    End Sub
End Class