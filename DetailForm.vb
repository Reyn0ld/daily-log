Public Class DetailForm
    Private log As MainForm.DailyLog
    Private parentForm As MainForm

    Public Sub New(selectedLog As MainForm.DailyLog, parent As MainForm)
        InitializeComponent()
        log = selectedLog
        parentForm = parent
    End Sub

    Private Sub DetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()
    End Sub

    Private Sub DisplayData()
        lblTitle.Text = log.Title
        lblDate.Text = log.DateCreated.ToString("dd MMM yyyy")
        lblDescription.Text = log.Description

        ' Sembunyikan input dan tombol Done
        txtTitle.Visible = False
        txtDescription.Visible = False
        btnDone.Visible = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Ganti label dengan input
        txtTitle.Text = log.Title
        txtDescription.Text = log.Description
        txtTitle.Visible = True
        txtDescription.Visible = True
        btnDone.Visible = True

        lblTitle.Visible = False
        lblDescription.Visible = False
        btnEdit.Visible = False
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        ' Simpan perubahan
        log.Title = txtTitle.Text
        log.Description = txtDescription.Text

        parentForm.SaveData() ' Simpan ke JSON
        parentForm.RefreshList() ' Refresh list di form utama
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Hapus log dari list
        parentForm.logs.Remove(log)
        parentForm.SaveData()
        parentForm.RefreshList()
        Me.Close()
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged

    End Sub
End Class