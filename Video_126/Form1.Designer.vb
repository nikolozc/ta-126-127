<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnWriteFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(12, 208)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(125, 23)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Open File"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(294, 190)
        Me.TextBox1.TabIndex = 1
        '
        'btnWriteFile
        '
        Me.btnWriteFile.Location = New System.Drawing.Point(176, 208)
        Me.btnWriteFile.Name = "btnWriteFile"
        Me.btnWriteFile.Size = New System.Drawing.Size(117, 23)
        Me.btnWriteFile.TabIndex = 2
        Me.btnWriteFile.Text = "Write File"
        Me.btnWriteFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 243)
        Me.Controls.Add(Me.btnWriteFile)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenFile As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnWriteFile As Button
End Class
