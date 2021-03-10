<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanTerkonfirmasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetLaporan = New uasPV.DataSetLaporan()
        Me.tbl_terkonfirmasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_terkonfirmasiTableAdapter = New uasPV.DataSetLaporanTableAdapters.tbl_terkonfirmasiTableAdapter()
        CType(Me.DataSetLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_terkonfirmasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_terkonfirmasiBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "uasPV.ReportLaporanTerkonfirmasi.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(584, 377)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetLaporan
        '
        Me.DataSetLaporan.DataSetName = "DataSetLaporan"
        Me.DataSetLaporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_terkonfirmasiBindingSource
        '
        Me.tbl_terkonfirmasiBindingSource.DataMember = "tbl_terkonfirmasi"
        Me.tbl_terkonfirmasiBindingSource.DataSource = Me.DataSetLaporan
        '
        'tbl_terkonfirmasiTableAdapter
        '
        Me.tbl_terkonfirmasiTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanTerkonfirmasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 377)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanTerkonfirmasi"
        Me.Text = "FormLaporanTerkonfirmasi"
        CType(Me.DataSetLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_terkonfirmasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_terkonfirmasiBindingSource As BindingSource
    Friend WithEvents DataSetLaporan As DataSetLaporan
    Friend WithEvents tbl_terkonfirmasiTableAdapter As DataSetLaporanTableAdapters.tbl_terkonfirmasiTableAdapter
End Class
