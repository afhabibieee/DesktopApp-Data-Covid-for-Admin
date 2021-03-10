<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanKontributor
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
        Me.dbuascovidkelurahanDataSet = New uasPV.dbuascovidkelurahanDataSet()
        Me.tbl_konstributorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_konstributorTableAdapter = New uasPV.dbuascovidkelurahanDataSetTableAdapters.tbl_konstributorTableAdapter()
        CType(Me.dbuascovidkelurahanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_konstributorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_konstributorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "uasPV.ReportLaporanKontributor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(584, 377)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbuascovidkelurahanDataSet
        '
        Me.dbuascovidkelurahanDataSet.DataSetName = "dbuascovidkelurahanDataSet"
        Me.dbuascovidkelurahanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_konstributorBindingSource
        '
        Me.tbl_konstributorBindingSource.DataMember = "tbl_konstributor"
        Me.tbl_konstributorBindingSource.DataSource = Me.dbuascovidkelurahanDataSet
        '
        'tbl_konstributorTableAdapter
        '
        Me.tbl_konstributorTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanKontributor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 377)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanKontributor"
        Me.Text = "FormLaporanKontributor"
        CType(Me.dbuascovidkelurahanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_konstributorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_konstributorBindingSource As BindingSource
    Friend WithEvents dbuascovidkelurahanDataSet As dbuascovidkelurahanDataSet
    Friend WithEvents tbl_konstributorTableAdapter As dbuascovidkelurahanDataSetTableAdapters.tbl_konstributorTableAdapter
End Class
