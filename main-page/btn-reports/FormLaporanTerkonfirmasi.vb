Public Class FormLaporanTerkonfirmasi
    Private Sub FormLaporanTerkonfirmasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetLaporan.tbl_terkonfirmasi' table. You can move, or remove it, as needed.
        Me.tbl_terkonfirmasiTableAdapter.Fill(Me.DataSetLaporan.tbl_terkonfirmasi)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
