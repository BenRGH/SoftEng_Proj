Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices
Imports SEGame.ScoreDBDataSetTableAdapters

<DesignerGenerated()> _
Partial Class Score
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
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
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New Container()
        Me.Label1 = New Label()
        Me.ListBox1 = New ListBox()
        Me.closeBtn = New Button()
        Me.nickBox = New TextBox()
        Me.nickLbl = New Label()
        Me.saveBtn = New Button()
        Me.ScoreDBDataSet = New ScoreDBDataSet()
        Me.ScoreboardBindingSource = New BindingSource(Me.components)
        Me.ScoreboardTableAdapter = New scoreboardTableAdapter()
        Me.ListBox2 = New ListBox()
        CType(Me.ScoreDBDataSet, ISupportInitialize).BeginInit()
        CType(Me.ScoreboardBindingSource, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Microsoft Sans Serif", 21.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New Point(63, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(162, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Highscores"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.ScoreboardBindingSource
        Me.ListBox1.DisplayMember = "nick"
        Me.ListBox1.Font = New Font("Microsoft Sans Serif", 20.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New Point(13, 62)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New Size(148, 252)
        Me.ListBox1.TabIndex = 1
        '
        'closeBtn
        '
        Me.closeBtn.Location = New Point(13, 411)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New Size(269, 30)
        Me.closeBtn.TabIndex = 2
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'nickBox
        '
        Me.nickBox.Location = New Point(76, 345)
        Me.nickBox.Name = "nickBox"
        Me.nickBox.Size = New Size(206, 20)
        Me.nickBox.TabIndex = 3
        '
        'nickLbl
        '
        Me.nickLbl.AutoSize = True
        Me.nickLbl.Location = New Point(12, 348)
        Me.nickLbl.Name = "nickLbl"
        Me.nickLbl.Size = New Size(58, 13)
        Me.nickLbl.TabIndex = 4
        Me.nickLbl.Text = "Nickname:"
        '
        'saveBtn
        '
        Me.saveBtn.Location = New Point(12, 375)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New Size(269, 30)
        Me.saveBtn.TabIndex = 5
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'ScoreDBDataSet
        '
        Me.ScoreDBDataSet.DataSetName = "ScoreDBDataSet"
        Me.ScoreDBDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'ScoreboardBindingSource
        '
        Me.ScoreboardBindingSource.DataMember = "scoreboard"
        Me.ScoreboardBindingSource.DataSource = Me.ScoreDBDataSet
        '
        'ScoreboardTableAdapter
        '
        Me.ScoreboardTableAdapter.ClearBeforeFill = True
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.ScoreboardBindingSource
        Me.ListBox2.DisplayMember = "score"
        Me.ListBox2.Font = New Font("Microsoft Sans Serif", 20.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 31
        Me.ListBox2.Location = New Point(167, 62)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New Size(114, 252)
        Me.ListBox2.TabIndex = 6
        '
        'Score
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(294, 453)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.nickLbl)
        Me.Controls.Add(Me.nickBox)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New Size(310, 492)
        Me.MinimumSize = New Size(310, 492)
        Me.Name = "Score"
        Me.Text = "Score"
        CType(Me.ScoreDBDataSet, ISupportInitialize).EndInit()
        CType(Me.ScoreboardBindingSource, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents closeBtn As Button
    Friend WithEvents nickBox As TextBox
    Friend WithEvents nickLbl As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents ScoreDBDataSet As ScoreDBDataSet
    Friend WithEvents ScoreboardBindingSource As BindingSource
    Friend WithEvents ScoreboardTableAdapter As scoreboardTableAdapter
    Friend WithEvents ListBox2 As ListBox
End Class
