Imports Newtonsoft.Json
Imports System.IO

Public Class MainForm
    Private dataPath As String = "data.json"
    Public logs As List(Of DailyLog)

    ' Kelas untuk struktur JSON
    Public Class DailyLog
        Public Property Id As String
        Public Property Title As String
        Public Property DateCreated As DateTime
        Public Property Description As String
    End Class

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Baca file JSON atau buat file baru jika belum ada
        If Not File.Exists(dataPath) Then
            File.WriteAllText(dataPath, "[]")
        End If

        ' Deserialize JSON
        Dim json As String = File.ReadAllText(dataPath)
        logs = JsonConvert.DeserializeObject(Of List(Of DailyLog))(json)

        ' Refresh tampilan list
        RefreshList()
    End Sub

    Public Sub RefreshList()
        panelList.Controls.Clear()
        For Each log As DailyLog In logs
            Dim btn As New Button()
            btn.Text = log.Title
            btn.Tag = log.Id ' Simpan ID sebagai tag
            btn.Width = panelList.Width - 20
            AddHandler btn.Click, AddressOf ListItem_Click
            panelList.Controls.Add(btn)
        Next
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ' Buat data baru
        Dim newLog As New DailyLog With {
        .Id = Guid.NewGuid().ToString(),
        .Title = "New Title",
        .DateCreated = DateTime.Now,
        .Description = "New Description"
    }
        logs.Add(newLog)

        ' Simpan ke JSON
        SaveData()

        ' Refresh list
        RefreshList()
    End Sub

    Public Sub SaveData()
        Dim json As String = JsonConvert.SerializeObject(logs, Formatting.Indented)
        File.WriteAllText(dataPath, json)
    End Sub

    Private Sub ListItem_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim selectedId As String = btn.Tag.ToString()
        Dim selectedLog = logs.Find(Function(log) log.Id = selectedId)

        ' Buka form detail
        Dim detailForm As New DetailForm(selectedLog, Me)
        detailForm.ShowDialog()
    End Sub


End Class