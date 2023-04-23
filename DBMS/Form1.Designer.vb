<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtGender = New TextBox()
        txtAge = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        dgStudents = New DataGridView()
        Insert = New Button()
        toSearch = New TextBox()
        CType(dgStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(20, 262)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(123, 33)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(195, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(123, 74)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(195, 23)
        txtLastName.TabIndex = 2
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(123, 116)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(195, 23)
        txtGender.TabIndex = 3
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(123, 160)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(195, 23)
        txtAge.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 5
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 6
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(50, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 7
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 8
        Label4.Text = "Age"
        ' 
        ' dgStudents
        ' 
        dgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgStudents.Location = New Point(337, 33)
        dgStudents.Name = "dgStudents"
        dgStudents.RowTemplate.Height = 25
        dgStudents.Size = New Size(740, 252)
        dgStudents.TabIndex = 9
        ' 
        ' Insert
        ' 
        Insert.Location = New Point(123, 199)
        Insert.Name = "Insert"
        Insert.Size = New Size(195, 23)
        Insert.TabIndex = 10
        Insert.Text = "Insert"
        Insert.UseVisualStyleBackColor = True
        ' 
        ' toSearch
        ' 
        toSearch.Location = New Point(121, 263)
        toSearch.Name = "toSearch"
        toSearch.Size = New Size(197, 23)
        toSearch.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1089, 460)
        Controls.Add(toSearch)
        Controls.Add(Insert)
        Controls.Add(dgStudents)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtAge)
        Controls.Add(txtGender)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Data Management System"
        CType(dgStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgStudents As DataGridView
    Friend WithEvents Insert As Button
    Friend WithEvents toSearch As TextBox
End Class
