Imports FontAwesome.Sharp

Public Class FormMenuUtama
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        CustomizeDesign()
    End Sub

    Private Sub CustomizeDesign()
        'panel sub menu
        PanelSubDataMaster.Visible = False
        PanelSubLaporan.Visible = False
    End Sub

    Private Sub HideSubMenu()
        If PanelSubDataMaster.Visible = True Then
            PanelSubDataMaster.Visible = False
        End If
        If PanelSubLaporan.Visible = True Then
            PanelSubLaporan.Visible = False
        End If
    End Sub

    Private Sub ShowSubMenu(SubMenu As Panel)
        If SubMenu.Visible = False Then
            HideSubMenu()
            SubMenu.Visible = True
        Else
            SubMenu.Visible = False
        End If
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(240, 240, 240)
            currentBtn.ForeColor = Color.FromArgb(202, 52, 51)
            currentBtn.IconColor = Color.FromArgb(202, 52, 51)
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'left border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(202, 52, 51)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    
  'button control to other pages
    Private Sub BtnDataMaster_Click(sender As Object, e As EventArgs) Handles BtnDataMaster.Click
        ActivateButton(sender, Color.FromArgb(255, 77, 0))
        ShowSubMenu(PanelSubDataMaster)
    End Sub

    Private Sub BtnTerkonfirmasi_Click(sender As Object, e As EventArgs) Handles BtnTerkonfirmasi.Click
        OpenChildForm(New FormTerkonfirmasi)
        HideSubMenu()
    End Sub

    Private Sub BtnKontributor_Click(sender As Object, e As EventArgs) Handles BtnKontributor.Click
        OpenChildForm(New FormKontributor)
        HideSubMenu()
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        ActivateButton(sender, Color.FromArgb(255, 77, 0))
        ShowSubMenu(PanelSubLaporan)
    End Sub

    Private Sub BtnDataKonfirmasi_Click(sender As Object, e As EventArgs) Handles BtnDataKonfirmasi.Click
        OpenChildForm(New FormLaporanTerkonfirmasi)
        HideSubMenu()
    End Sub

    Private Sub BtnDataKontributor_Click(sender As Object, e As EventArgs) Handles BtnDataKontributor.Click
        OpenChildForm(New FormLaporanKontributor)
        HideSubMenu()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub
End Class
