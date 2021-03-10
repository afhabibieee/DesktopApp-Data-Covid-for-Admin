Public Class FormLaporanKontributor
    Private Sub FormLaporanKontributor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbuascovidkelurahanDataSet.tbl_konstributor' table. You can move, or remove it, as needed.
        Me.tbl_konstributorTableAdapter.Fill(Me.dbuascovidkelurahanDataSet.tbl_konstributor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
