<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailForm
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
        lblTitle = New Label()
        lblDate = New Label()
        lblDescription = New Label()
        btnEdit = New Button()
        btnDelete = New Button()
        btnDone = New Button()
        txtTitle = New TextBox()
        txtDescription = New TextBox()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(187, 39)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(77, 40)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Title"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 7F)
        lblDate.Location = New Point(196, 89)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(25, 12)
        lblDate.TabIndex = 1
        lblDate.Text = "Date"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(197, 141)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(67, 15)
        lblDescription.TabIndex = 2
        lblDescription.Text = "Description"
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnEdit.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(187, 246)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(107, 37)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = SystemColors.ControlText
        btnDelete.Location = New Point(317, 246)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(93, 37)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnDone
        ' 
        btnDone.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnDone.Cursor = Cursors.Hand
        btnDone.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDone.ForeColor = SystemColors.ControlText
        btnDone.Location = New Point(187, 246)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(110, 37)
        btnDone.TabIndex = 5
        btnDone.Text = "Done"
        btnDone.UseVisualStyleBackColor = False
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(194, 56)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(100, 23)
        txtTitle.TabIndex = 6
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(197, 138)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(100, 23)
        txtDescription.TabIndex = 7
        ' 
        ' DetailForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtDescription)
        Controls.Add(txtTitle)
        Controls.Add(btnDone)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(lblDescription)
        Controls.Add(lblDate)
        Controls.Add(lblTitle)
        Name = "DetailForm"
        Text = "DetailForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDescription As TextBox
End Class
