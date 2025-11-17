

Public Class Print_Preview

    Private Sub Print_Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        restart()
    End Sub

    'BUTTONS

    'Back to Mainform
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        Umbrella_Corp.Show()
    End Sub

    ' FUNCTIONS

    'Load Data from Mainform
    Private Function restart()

        If Umbrella_Corp.rb_Female.Checked = False And Umbrella_Corp.rb_Male.Checked = False Then
            Me.txt_Gender.Text = ""
        ElseIf Umbrella_Corp.rb_Male.Checked = True Then
            Me.txt_Gender.Text = "Male"
        Else
            Me.txt_Gender.Text = "Female"
        End If

        Me.txt_Fname.Text = Umbrella_Corp.txt_Fname.Text
        Me.txt_Mname.Text = Umbrella_Corp.txt_Mname.Text
        Me.txt_Lname.Text = Umbrella_Corp.txt_Lname.Text
        Me.date_Registered.Text = Umbrella_Corp.date_Registered.Value
        Me.date_Bdate.Text = Umbrella_Corp.date_Bdate.Value
        Me.box_AttendingP.Text = Umbrella_Corp.box_AttendingP.Text
        Me.txt_Pnum.Text = Umbrella_Corp.txt_Pnum.Text
        Me.txt_Age.Text = Umbrella_Corp.txt_Age.Text
        Me.txt_Address.Text = Umbrella_Corp.txt_Address.Text
        Me.txt_Cnum.Text = Umbrella_Corp.txt_Cnum.Text
        Me.txt_Height.Text = Umbrella_Corp.txt_Height.Text
        Me.txt_Weight.Text = Umbrella_Corp.txt_Weight.Text
        Me.txt_BloodP.Text = Umbrella_Corp.txt_BloodP.Text
        Me.txt_PurposeofC.Text = Umbrella_Corp.txt_PurposeofC.Text
        Me.box_MedTR.Text = Umbrella_Corp.box_MedTR.Text
        Me.pic_Profile.Image = Umbrella_Corp.pic_Profile.Image
        Return 0
    End Function

    'PRINTING OPTIONS

    'Display Data to Print Page
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 14, FontStyle.Regular)
        Dim font2 As New Font("arial", 14, FontStyle.Bold)

        'Header Logo
        e.Graphics.DrawImage(My.Resources.print_logo, 75, 40, 702, 150)
        'Profile Pic
        e.Graphics.DrawImage(pic_Profile.Image, 625, 240, 150, 150)
        e.Graphics.DrawString(lbl_ProfilePic.Text, font2, Brushes.Black, 635, 390)

        'Patient Data
        e.Graphics.DrawString(lbl_Fname.Text, font2, Brushes.Black, 75, 240)
        e.Graphics.DrawString("" & txt_Fname.Text, font1, Brushes.Black, 305, 240)

        e.Graphics.DrawString(lbl_Lname.Text, font2, Brushes.Black, 75, 270)
        e.Graphics.DrawString("" & txt_Lname.Text, font1, Brushes.Black, 305, 270)

        e.Graphics.DrawString(lbl_Mname.Text, font2, Brushes.Black, 75, 300)
        e.Graphics.DrawString("" & txt_Mname.Text, font1, Brushes.Black, 305, 300)

        e.Graphics.DrawString(lbl_DateofR.Text, font2, Brushes.Black, 75, 330)
        e.Graphics.DrawString("" & date_Registered.Text, font1, Brushes.Black, 305, 330)

        e.Graphics.DrawString(lbl_Bdate.Text, font2, Brushes.Black, 75, 360)
        e.Graphics.DrawString("" & date_Bdate.Text, font1, Brushes.Black, 305, 360)

        e.Graphics.DrawString(lbl_AttendingP.Text, font2, Brushes.Black, 75, 390)
        e.Graphics.DrawString("" & box_AttendingP.Text, font1, Brushes.Black, 305, 390)

        e.Graphics.DrawString(lbl_Pnum.Text, font2, Brushes.Black, 75, 420)
        e.Graphics.DrawString("" & txt_Pnum.Text, font1, Brushes.Black, 305, 420)

        e.Graphics.DrawString(lbl_Age.Text, font2, Brushes.Black, 75, 450)
        e.Graphics.DrawString("" & txt_Age.Text, font1, Brushes.Black, 305, 450)

        e.Graphics.DrawString(lbl_Gender.Text, font2, Brushes.Black, 75, 480)
        e.Graphics.DrawString("" & txt_Gender.Text, font1, Brushes.Black, 305, 480)

        e.Graphics.DrawString(lbl_Address.Text, font2, Brushes.Black, 75, 510)
        e.Graphics.DrawString("" & txt_Address.Text, font1, Brushes.Black, 305, 510)

        e.Graphics.DrawString(lbl_Cnum.Text, font2, Brushes.Black, 75, 540)
        e.Graphics.DrawString("" & txt_Cnum.Text, font1, Brushes.Black, 305, 540)

        e.Graphics.DrawString(lbl_Height.Text, font2, Brushes.Black, 75, 570)
        e.Graphics.DrawString("" & txt_Height.Text, font1, Brushes.Black, 305, 570)

        e.Graphics.DrawString(lbl_Weight.Text, font2, Brushes.Black, 75, 600)
        e.Graphics.DrawString("" & txt_Weight.Text, font1, Brushes.Black, 305, 600)

        e.Graphics.DrawString(lbl_BloodP.Text, font2, Brushes.Black, 75, 630)
        e.Graphics.DrawString("" & txt_BloodP.Text, font1, Brushes.Black, 305, 630)

        e.Graphics.DrawString(lbl_PurposeofC.Text, font2, Brushes.Black, 75, 660)
        e.Graphics.DrawString("" & txt_PurposeofC.Text, font1, Brushes.Black, 305, 680)

        e.Graphics.DrawString(lbl_MedicineTR.Text, font2, Brushes.Black, 75, 750)
        e.Graphics.DrawString("" & box_MedTR.Text, font1, Brushes.Black, 305, 750)

    End Sub

    'Print Document
    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        PrintDocument1.Print()
    End Sub

    'Preview Page to Print
    Private Sub Btn_Preview_Click(sender As Object, e As EventArgs) Handles btn_Preview.Click
        PrintPreviewDialog1.ShowDialog()
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