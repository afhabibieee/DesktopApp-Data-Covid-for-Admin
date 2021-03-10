Imports System.Data.OleDb
Imports System.Data

Public Class FormLogin
    Dim MyConnection As New CLS.clsDatabaseConnection
    Dim Nama As String
    Dim Password As String
    Dim NamaLengkap As String

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNama_User.MaxLength = 60
        txtPassword.MaxLength = 60
    End Sub

    Sub CekUser()
        objdt.Clear()
        strsql = ("Select * from [tbl_user] where [username] = '" & Trim(txtNama_User.Text) & "'")
        objcmd = New OleDbCommand With {
            .Connection = MyConnection.Open,
            .CommandType = CommandType.Text,
            .CommandText = strsql
        }
        objda = New OleDbDataAdapter(objcmd)
        objda.Fill(objds, "tbl_user")
        objdt = objds.Tables("tbl_user")
        MyConnection.Close()
    End Sub

    Sub CekPassword()
        objcmd = MyConnection.Open.CreateCommand
        objcmd.CommandText = ("select [username],[password],[namalengkap] from [tbl_user] where [username] = '" & Trim(txtNama_User.Text) & "'")
        objdr = objcmd.ExecuteReader
        objdr.Read()
        Nama = objdr.Item("username")
        Password = objdr.Item("password")
        NamaLengkap = objdr.Item("namalengkap")
        MyConnection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNama_User.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Maaf Data Login Belum Lengkap...", "DATA LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNama_User.Text = ""
            txtPassword.Text = ""
            txtNama_User.Focus()
        Else
            Call CekUser()
            If objdt.Rows.Count <= 0 Then
                MessageBox.Show("Maaf Nama User Tidak Terdaftar...", "ID TIDAK TERDAFTAR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtNama_User.Text = ""
                txtPassword.Text = ""
                txtNama_User.Focus()
            Else
                Call CekPassword()
                If Password <> Trim(txtPassword.Text) Then
                    MessageBox.Show("Password Salah", "SALAH PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPassword.Text = ""
                    txtPassword.Focus()
                Else
                    MessageBox.Show("Selamat Datang " & UCase(NamaLengkap) & "!", "LOGIN SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormMenuUtama.ShowDialog()
                    Me.Close()
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
