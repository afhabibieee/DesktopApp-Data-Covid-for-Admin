<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelSubLaporan = New System.Windows.Forms.Panel()
        Me.BtnDataKontributor = New FontAwesome.Sharp.IconButton()
        Me.BtnDataKonfirmasi = New FontAwesome.Sharp.IconButton()
        Me.PanelLaporan = New System.Windows.Forms.Panel()
        Me.BtnLaporan = New FontAwesome.Sharp.IconButton()
        Me.PanelSubDataMaster = New System.Windows.Forms.Panel()
        Me.BtnKontributor = New FontAwesome.Sharp.IconButton()
        Me.BtnTerkonfirmasi = New FontAwesome.Sharp.IconButton()
        Me.PanelDataMaster = New System.Windows.Forms.Panel()
        Me.BtnDataMaster = New FontAwesome.Sharp.IconButton()
        Me.PanelPict = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExit = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelTitlebar = New System.Windows.Forms.Panel()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelSubLaporan.SuspendLayout()
        Me.PanelLaporan.SuspendLayout()
        Me.PanelSubDataMaster.SuspendLayout()
        Me.PanelDataMaster.SuspendLayout()
        Me.PanelPict.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitlebar.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PanelSubLaporan)
        Me.PanelMenu.Controls.Add(Me.PanelLaporan)
        Me.PanelMenu.Controls.Add(Me.PanelSubDataMaster)
        Me.PanelMenu.Controls.Add(Me.PanelDataMaster)
        Me.PanelMenu.Controls.Add(Me.PanelPict)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 450)
        Me.PanelMenu.TabIndex = 1
        '
        'PanelSubLaporan
        '
        Me.PanelSubLaporan.Controls.Add(Me.BtnDataKontributor)
        Me.PanelSubLaporan.Controls.Add(Me.BtnDataKonfirmasi)
        Me.PanelSubLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubLaporan.Location = New System.Drawing.Point(0, 346)
        Me.PanelSubLaporan.Name = "PanelSubLaporan"
        Me.PanelSubLaporan.Size = New System.Drawing.Size(200, 95)
        Me.PanelSubLaporan.TabIndex = 4
        '
        'BtnDataKontributor
        '
        Me.BtnDataKontributor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDataKontributor.FlatAppearance.BorderSize = 0
        Me.BtnDataKontributor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataKontributor.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnDataKontributor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDataKontributor.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnDataKontributor.IconChar = FontAwesome.Sharp.IconChar.Medkit
        Me.BtnDataKontributor.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnDataKontributor.IconSize = 25
        Me.BtnDataKontributor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataKontributor.Location = New System.Drawing.Point(0, 45)
        Me.BtnDataKontributor.Name = "BtnDataKontributor"
        Me.BtnDataKontributor.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnDataKontributor.Rotation = 0R
        Me.BtnDataKontributor.Size = New System.Drawing.Size(200, 45)
        Me.BtnDataKontributor.TabIndex = 1
        Me.BtnDataKontributor.Text = "Data Kontributor"
        Me.BtnDataKontributor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataKontributor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDataKontributor.UseVisualStyleBackColor = True
        '
        'BtnDataKonfirmasi
        '
        Me.BtnDataKonfirmasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDataKonfirmasi.FlatAppearance.BorderSize = 0
        Me.BtnDataKonfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataKonfirmasi.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnDataKonfirmasi.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDataKonfirmasi.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnDataKonfirmasi.IconChar = FontAwesome.Sharp.IconChar.HSquare
        Me.BtnDataKonfirmasi.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnDataKonfirmasi.IconSize = 25
        Me.BtnDataKonfirmasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataKonfirmasi.Location = New System.Drawing.Point(0, 0)
        Me.BtnDataKonfirmasi.Name = "BtnDataKonfirmasi"
        Me.BtnDataKonfirmasi.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnDataKonfirmasi.Rotation = 0R
        Me.BtnDataKonfirmasi.Size = New System.Drawing.Size(200, 45)
        Me.BtnDataKonfirmasi.TabIndex = 0
        Me.BtnDataKonfirmasi.Text = "Data Konfirmasi"
        Me.BtnDataKonfirmasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataKonfirmasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDataKonfirmasi.UseVisualStyleBackColor = True
        '
        'PanelLaporan
        '
        Me.PanelLaporan.Controls.Add(Me.BtnLaporan)
        Me.PanelLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLaporan.Location = New System.Drawing.Point(0, 286)
        Me.PanelLaporan.Name = "PanelLaporan"
        Me.PanelLaporan.Size = New System.Drawing.Size(200, 60)
        Me.PanelLaporan.TabIndex = 3
        '
        'BtnLaporan
        '
        Me.BtnLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLaporan.FlatAppearance.BorderSize = 0
        Me.BtnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaporan.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnLaporan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporan.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLaporan.IconChar = FontAwesome.Sharp.IconChar.Newspaper
        Me.BtnLaporan.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnLaporan.IconSize = 30
        Me.BtnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLaporan.Location = New System.Drawing.Point(0, 0)
        Me.BtnLaporan.Name = "BtnLaporan"
        Me.BtnLaporan.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnLaporan.Rotation = 0R
        Me.BtnLaporan.Size = New System.Drawing.Size(200, 55)
        Me.BtnLaporan.TabIndex = 0
        Me.BtnLaporan.Text = "Laporan"
        Me.BtnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLaporan.UseVisualStyleBackColor = True
        '
        'PanelSubDataMaster
        '
        Me.PanelSubDataMaster.Controls.Add(Me.BtnKontributor)
        Me.PanelSubDataMaster.Controls.Add(Me.BtnTerkonfirmasi)
        Me.PanelSubDataMaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubDataMaster.Location = New System.Drawing.Point(0, 191)
        Me.PanelSubDataMaster.Name = "PanelSubDataMaster"
        Me.PanelSubDataMaster.Size = New System.Drawing.Size(200, 95)
        Me.PanelSubDataMaster.TabIndex = 2
        '
        'BtnKontributor
        '
        Me.BtnKontributor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnKontributor.FlatAppearance.BorderSize = 0
        Me.BtnKontributor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKontributor.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnKontributor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKontributor.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnKontributor.IconChar = FontAwesome.Sharp.IconChar.Medkit
        Me.BtnKontributor.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnKontributor.IconSize = 25
        Me.BtnKontributor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKontributor.Location = New System.Drawing.Point(0, 45)
        Me.BtnKontributor.Name = "BtnKontributor"
        Me.BtnKontributor.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnKontributor.Rotation = 0R
        Me.BtnKontributor.Size = New System.Drawing.Size(200, 45)
        Me.BtnKontributor.TabIndex = 1
        Me.BtnKontributor.Text = "Kontributor"
        Me.BtnKontributor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKontributor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnKontributor.UseVisualStyleBackColor = True
        '
        'BtnTerkonfirmasi
        '
        Me.BtnTerkonfirmasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTerkonfirmasi.FlatAppearance.BorderSize = 0
        Me.BtnTerkonfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTerkonfirmasi.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnTerkonfirmasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTerkonfirmasi.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnTerkonfirmasi.IconChar = FontAwesome.Sharp.IconChar.HSquare
        Me.BtnTerkonfirmasi.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnTerkonfirmasi.IconSize = 25
        Me.BtnTerkonfirmasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTerkonfirmasi.Location = New System.Drawing.Point(0, 0)
        Me.BtnTerkonfirmasi.Name = "BtnTerkonfirmasi"
        Me.BtnTerkonfirmasi.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnTerkonfirmasi.Rotation = 0R
        Me.BtnTerkonfirmasi.Size = New System.Drawing.Size(200, 45)
        Me.BtnTerkonfirmasi.TabIndex = 0
        Me.BtnTerkonfirmasi.Text = "Terkonfirmasi"
        Me.BtnTerkonfirmasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTerkonfirmasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTerkonfirmasi.UseVisualStyleBackColor = True
        '
        'PanelDataMaster
        '
        Me.PanelDataMaster.Controls.Add(Me.BtnDataMaster)
        Me.PanelDataMaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDataMaster.Location = New System.Drawing.Point(0, 136)
        Me.PanelDataMaster.Name = "PanelDataMaster"
        Me.PanelDataMaster.Size = New System.Drawing.Size(200, 55)
        Me.PanelDataMaster.TabIndex = 1
        '
        'BtnDataMaster
        '
        Me.BtnDataMaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDataMaster.FlatAppearance.BorderSize = 0
        Me.BtnDataMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataMaster.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnDataMaster.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDataMaster.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnDataMaster.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.BtnDataMaster.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnDataMaster.IconSize = 30
        Me.BtnDataMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataMaster.Location = New System.Drawing.Point(0, 0)
        Me.BtnDataMaster.Name = "BtnDataMaster"
        Me.BtnDataMaster.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnDataMaster.Rotation = 0R
        Me.BtnDataMaster.Size = New System.Drawing.Size(200, 55)
        Me.BtnDataMaster.TabIndex = 0
        Me.BtnDataMaster.Text = "Data Master"
        Me.BtnDataMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDataMaster.UseVisualStyleBackColor = True
        '
        'PanelPict
        '
        Me.PanelPict.Controls.Add(Me.Label1)
        Me.PanelPict.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPict.Location = New System.Drawing.Point(0, 0)
        Me.PanelPict.Name = "PanelPict"
        Me.PanelPict.Size = New System.Drawing.Size(200, 136)
        Me.PanelPict.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Kelurahan"
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnExit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.BtnExit.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnExit.IconSize = 16
        Me.BtnExit.Location = New System.Drawing.Point(570, 0)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Rotation = 0R
        Me.BtnExit.Size = New System.Drawing.Size(30, 34)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(206, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PanelTitlebar
        '
        Me.PanelTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelTitlebar.Controls.Add(Me.BtnExit)
        Me.PanelTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitlebar.Location = New System.Drawing.Point(200, 0)
        Me.PanelTitlebar.Name = "PanelTitlebar"
        Me.PanelTitlebar.Size = New System.Drawing.Size(600, 34)
        Me.PanelTitlebar.TabIndex = 4
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(200, 34)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(600, 416)
        Me.PanelDesktop.TabIndex = 5
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitlebar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenuUtama"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelSubLaporan.ResumeLayout(False)
        Me.PanelLaporan.ResumeLayout(False)
        Me.PanelSubDataMaster.ResumeLayout(False)
        Me.PanelDataMaster.ResumeLayout(False)
        Me.PanelPict.ResumeLayout(False)
        Me.PanelPict.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitlebar.ResumeLayout(False)
        Me.PanelDesktop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelPict As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelSubDataMaster As Panel
    Friend WithEvents BtnTerkonfirmasi As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDataMaster As Panel
    Friend WithEvents BtnDataMaster As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLaporan As Panel
    Friend WithEvents BtnLaporan As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnKontributor As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelSubLaporan As Panel
    Friend WithEvents BtnDataKontributor As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnDataKonfirmasi As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitlebar As Panel
    Friend WithEvents PanelDesktop As Panel
End Class
