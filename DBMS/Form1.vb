Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.AxHost

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim student As String
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim ds As New DataSet()
        student = toSearch.Text

        con.ConnectionString = "Server=tcp:rcs-ims.database.windows.net,1433;Initial Catalog=dms;Persist Security Info=False;User ID=myAdmin;Password=Settings@101;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT studentId, LastName, FirstName, Gender, Age, DateCreated FROM [dbo].[Students] WHERE FirstName like '%" + student + "%' OR LastName like '%" + student + "%'"
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgStudents.DataSource = table
        con.Close()
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAge As String
        Dim strGender As String
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        strAge = txtAge.Text
        strGender = txtGender.Text

        con.ConnectionString = "Server=tcp:rcs-ims.database.windows.net,1433;Initial Catalog=dms;Persist Security Info=False;User ID=myAdmin;Password=Settings@101;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

        con.Open()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Students (LastName, FirstName, Gender, Age, DateCreated) VALUES ('" + strLastName + "', '" + strFirstName + "', '" + strGender + "', '" + strAge + "', GETDATE())"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox(strFirstName + " " + strLastName + ". Your age is " + strAge + " and your gender is " + strGender + ".")
    End Sub
End Class
