<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.maganhangzovizsgalatTextBox = New System.Windows.Forms.TextBox
        Me.maganhangzovizsgalatButton = New System.Windows.Forms.Button
        Me.maganhangzovalaszTextBox = New System.Windows.Forms.TextBox
        Me.beolvasButton = New System.Windows.Forms.Button
        Me.beolvasottTextBox = New System.Windows.Forms.TextBox
        Me.leghosszabbTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.katakterekszamaTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adjon meg egy szót:"
        '
        'maganhangzovizsgalatTextBox
        '
        Me.maganhangzovizsgalatTextBox.Location = New System.Drawing.Point(120, 12)
        Me.maganhangzovizsgalatTextBox.Name = "maganhangzovizsgalatTextBox"
        Me.maganhangzovizsgalatTextBox.Size = New System.Drawing.Size(437, 20)
        Me.maganhangzovizsgalatTextBox.TabIndex = 1
        '
        'maganhangzovizsgalatButton
        '
        Me.maganhangzovizsgalatButton.Location = New System.Drawing.Point(15, 44)
        Me.maganhangzovizsgalatButton.Name = "maganhangzovizsgalatButton"
        Me.maganhangzovizsgalatButton.Size = New System.Drawing.Size(283, 23)
        Me.maganhangzovizsgalatButton.TabIndex = 2
        Me.maganhangzovizsgalatButton.Text = "Van-e magánhagzó benne?"
        Me.maganhangzovizsgalatButton.UseVisualStyleBackColor = True
        '
        'maganhangzovalaszTextBox
        '
        Me.maganhangzovalaszTextBox.Location = New System.Drawing.Point(304, 46)
        Me.maganhangzovalaszTextBox.Name = "maganhangzovalaszTextBox"
        Me.maganhangzovalaszTextBox.Size = New System.Drawing.Size(252, 20)
        Me.maganhangzovalaszTextBox.TabIndex = 3
        '
        'beolvasButton
        '
        Me.beolvasButton.Location = New System.Drawing.Point(12, 91)
        Me.beolvasButton.Name = "beolvasButton"
        Me.beolvasButton.Size = New System.Drawing.Size(112, 30)
        Me.beolvasButton.TabIndex = 4
        Me.beolvasButton.Text = "Beolvasás"
        Me.beolvasButton.UseVisualStyleBackColor = True
        '
        'beolvasottTextBox
        '
        Me.beolvasottTextBox.Location = New System.Drawing.Point(130, 91)
        Me.beolvasottTextBox.Multiline = True
        Me.beolvasottTextBox.Name = "beolvasottTextBox"
        Me.beolvasottTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.beolvasottTextBox.Size = New System.Drawing.Size(167, 74)
        Me.beolvasottTextBox.TabIndex = 5
        '
        'leghosszabbTextBox
        '
        Me.leghosszabbTextBox.Location = New System.Drawing.Point(311, 118)
        Me.leghosszabbTextBox.Name = "leghosszabbTextBox"
        Me.leghosszabbTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.leghosszabbTextBox.Size = New System.Drawing.Size(245, 20)
        Me.leghosszabbTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "A leghosszabb szó:"
        '
        'katakterekszamaTextBox
        '
        Me.katakterekszamaTextBox.Location = New System.Drawing.Point(513, 145)
        Me.katakterekszamaTextBox.Name = "katakterekszamaTextBox"
        Me.katakterekszamaTextBox.Size = New System.Drawing.Size(44, 20)
        Me.katakterekszamaTextBox.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "A leghosszabb szó karaktereinek száma:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 429)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.katakterekszamaTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.leghosszabbTextBox)
        Me.Controls.Add(Me.beolvasottTextBox)
        Me.Controls.Add(Me.beolvasButton)
        Me.Controls.Add(Me.maganhangzovalaszTextBox)
        Me.Controls.Add(Me.maganhangzovizsgalatButton)
        Me.Controls.Add(Me.maganhangzovizsgalatTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents maganhangzovizsgalatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents maganhangzovizsgalatButton As System.Windows.Forms.Button
    Friend WithEvents maganhangzovalaszTextBox As System.Windows.Forms.TextBox
    Friend WithEvents beolvasButton As System.Windows.Forms.Button
    Friend WithEvents beolvasottTextBox As System.Windows.Forms.TextBox
    Friend WithEvents leghosszabbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents katakterekszamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
