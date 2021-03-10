Imports System.Data
Imports System.Data.OleDb

Public Class FormTerkonfirmasi
    Dim Myconection As New CLS.clsDatabaseConnection
    Dim dtData As New Data.DataTable

    Sub FormatGrid()
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100

        DataGridView1.Columns(0).HeaderText = "RW"
        DataGridView1.Columns(1).HeaderText = "Positif"
        DataGridView1.Columns(2).HeaderText = "Pasien"
        DataGridView1.Columns(3).HeaderText = "Sembuh"
        DataGridView1.Columns(4).HeaderText = "Meninggal"

        DataGridView1.ReadOnly = True
    End Sub

    Sub Browse()
        objdt.Clear()
        strsql = ("Select rw, positif, pasien, sembuh, meninggal from [tbl_terkonfirmasi] where lcase(rw) like '%" & Trim(txtRW2.Text) & "%' order by positif;")
        objcmd = New OleDbCommand With {
            .Connection = Myconection.Open,
            .CommandType = CommandType.Text,
            .CommandText = strsql
        }
        objda = New OleDbDataAdapter(objcmd)
        objda.Fill(objds, "tbl_terkonfirmasi")
        objdt = objds.Tables("tbl_terkonfirmasi")
        Me.DataGridView1.DataSource = objdt
        FormatGrid()
        Myconection.Close()
        'tambahan buat edit
        txtRW.DataBindings.Clear()
        txtPositif.DataBindings.Clear()
        txtPasien.DataBindings.Clear()
        txtSembuh.DataBindings.Clear()
        txtMeninggal.DataBindings.Clear()

        If objdt.Rows.Count <> 0 Then
            Me.txtRW.DataBindings.Add("text", objdt, "rw")
            Me.txtPositif.DataBindings.Add("text", objdt, "positif")
            Me.txtPasien.DataBindings.Add("text", objdt, "pasien")
            Me.txtSembuh.DataBindings.Add("text", objdt, "sembuh")
            Me.txtMeninggal.DataBindings.Add("text", objdt, "meninggal")
        End If
    End Sub

    Private Sub Hapus()
        strsql = ("delete from tbl_terkonfirmasi where rw ='" & DataGridView1.CurrentRow.Cells(0).Value & "'")
        objcmd = New OleDbCommand With {
            .Connection = Myconection.Open,
            .CommandType = CommandType.Text,
            .CommandText = strsql
        }
        objda = New OleDbDataAdapter(objcmd)
        objda.Fill(objds, "tbl_terkonfirmasi")
        objcmd.ExecuteNonQuery()
        Myconection.Close()
        MsgBox("Data Berhasil dihapus", MsgBoxStyle.Information, "Delete Data")
        Browse()
    End Sub

    Private Sub SetClear()
        txtRW.Text = ""
        txtPositif.Text = ""
        txtPasien.Text = ""
        txtSembuh.Text = ""
        txtMeninggal.Text = ""
    End Sub

    Private Sub Simpan()
        strsql = ("insert into tbl_terkonfirmasi (rw, positif, pasien, sembuh, meninggal) values ('" & Trim(txtRW.Text) & "','" & Trim(txtPositif.Text) & "','" & Trim(txtPasien.Text) & "','" & Trim(txtSembuh.Text) & "','" & Trim(txtMeninggal.Text) & "')")
        objcmd = New OleDbCommand With {
            .Connection = Myconection.Open,
            .CommandType = CommandType.Text,
            .CommandText = strsql
        }
        objda = New OleDbDataAdapter(objcmd)
        objda.Fill(objds, "tbl_terkonfirmasi")
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
        ElseIf txtPositif.Text = "" Then
            MsgBox("Jumlah Positif Tidak Boleh Kosong...", MsgBoxStyle.Information, "Perhatian")
            txtPositif.Focus()
        ElseIf txtPasien.Text = "" Then
            MsgBox("Jumlah Pasien Buku Tidak Boleh Kosong...", MsgBoxStyle.Information, "Perhatian")
            txtPasien.Focus()
        Else
            Call Simpan()
            Call SetClear()
            MsgBox("Data Berhasil ditambahkan...", MsgBoxStyle.Information, "Inser Data")
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        strsql = ("update tbl_terkonfirmasi set positif='" & Trim(txtPositif.Text) & "',pasien='" & Trim(txtPasien.Text) & "',sembuh='" & Trim(txtSembuh.Text) & "',meninggal='" & Trim(txtMeninggal.Text) & "' where [rw] ='" & txtRW.Text & "'")
        objcmd = New OleDbCommand With {
            .Connection = Myconection.Open,
            .CommandType = CommandType.Text,
            .CommandText = strsql
        }
        objda = New OleDbDataAdapter(objcmd)
        objda.Fill(objds, "tbl_terkonfirmasi")
        objcmd.ExecuteNonQuery()
        Myconection.Close()
        MsgBox("Edit Data Terkonfirmasi Sukses...!!!", MsgBoxStyle.Information, "Edit Data")
        Browse()
    End Sub
End Class
