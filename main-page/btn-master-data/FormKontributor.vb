Imports System.Data
Imports System.Data.OleDb

Public Class FormKontributor
    Dim Myconection As New CLS.clsDatabaseConnection
    Dim dtData As New Data.DataTable

    Sub FormatGrid()
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100

        DataGridView1.Columns(0).HeaderText = "RW"
        DataGridView1.Columns(1).HeaderText = "Logistik"
        DataGridView1.Columns(2).HeaderText = "relawan"

        DataGridView1.ReadOnly = True
    End Sub

    Sub Browse()
        objdt.Clear()
        strsql = ("Select rw, logistik, relawan from [tbl_konstributor] where lcase(rw) like '%" & Trim(txtRW2.Text) & "%' order by logistik;")
        objcmd = New OleDbCommand With {
            .Connection = Myconection.Open,
            .CommandType = CommandType.Text,
            .CommandText = strsql
        }
        objda = New OleDbDataAdapter(objcmd)
        objda.Fill(objds, "tbl_konstributor")
        objdt = objds.Tables("tbl_konstributor")
        Me.DataGridView1.DataSource = objdt
        FormatGrid()
        Myconection.Close()
        'tambahan buat edit
        txtRW.DataBindings.Clear()
        txtLogistik.DataBindings.Clear()
        txtRelawan.DataBindings.Clear()

        If objdt.Rows.Count <> 0 Then
            Me.txtRW.DataBindings.Add("text", objdt, "rw")
            Me.txtLogistik.DataBindings.Add("text", objdt, "logistik")
            Me.txtRelawan.DataBindings.Add("text", objdt, "relawan")
        End If
    End Sub

    Private Sub Hapus()
        strsql = ("delete from tbl_konstributor where rw ='" & DataGridView1.CurrentRow.Cells(0).Value & "'")
        objcmd = New OleDbCommand With {
            .Connection = Myconection.Open,
            .CommandType = CommandType.Text,
            .CommandText = strsql
        }
        objda = New OleDbDataAdapter(objcmd)
        objda.Fill(objds, "tbl_konstributor")
        objcmd.ExecuteNonQuery()
        Myconection.Close()
        MsgBox("Data Berhasil dihapus", MsgBoxStyle.Information, "Delete Data")
        Browse()
    End Sub

    Private Sub SetClear()
        txtRW.Text = ""
        txtLogistik.Text = ""
        txtRelawan.Text = ""
    End Sub

    Private Sub Simpan()
        strsql = ("insert into tbl_konstributor (rw, logistik, relawan) values ('" & Trim(txtRW.Text) & "','" & Trim(txtLogistik.Text) & "','" & Trim(txtRelawan.Text) & "')")
        objcmd = New OleDbCommand With {
            .Connection = Myconection.Open,
            .CommandType = CommandType.Text,
            .CommandText = strsql
        }
        objda = New OleDbDataAdapter(objcmd)
        objda.Fill(objds, "tbl_konstributor")
        objda.InsertCommand = objcmd
        Myconection.Close()
        Browse()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Browse()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Hapus()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtRW.Text = "" Then
            MsgBox("RW Tidak Boleh Kosong...", MsgBoxStyle.Information, "Perhatian")
            txtRW.Focus()
        ElseIf txtLogistik.Text = "" Then
            MsgBox("Logistik Tidak Boleh Kosong...", MsgBoxStyle.Information, "Perhatian")
            txtLogistik.Focus()
        ElseIf txtRelawan.Text = "" Then
            MsgBox("Jumlah Relawan Buku Tidak Boleh Kosong...", MsgBoxStyle.Information, "Perhatian")
            txtRelawan.Focus()
        Else
            Call Simpan()
            Call SetClear()
            MsgBox("Data Berhasil ditambahkan...", MsgBoxStyle.Information, "Inser Data")
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        strsql = ("update tbl_konstributor set logistik='" & Trim(txtLogistik.Text) & "',relawan='" & Trim(txtRelawan.Text) & "' where [rw] ='" & txtRW.Text & "'")
        objcmd = New OleDbCommand With {
            .Connection = Myconection.Open,
            .CommandType = CommandType.Text,
            .CommandText = strsql
        }
        objda = New OleDbDataAdapter(objcmd)
        objda.Fill(objds, "tbl_konstributor")
        objcmd.ExecuteNonQuery()
        Myconection.Close()
        MsgBox("Edit Data Kontributor Sukses...!!!", MsgBoxStyle.Information, "Edit Data")
        Browse()
    End Sub
End Class
