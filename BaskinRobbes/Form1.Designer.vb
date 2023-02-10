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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Yes = New System.Windows.Forms.RadioButton()
        Me.No = New System.Windows.Forms.RadioButton()
        Me.Form2button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(133, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "베스킨 라빈스"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(178, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "선공할래요?"
        '
        'Yes
        '
        Me.Yes.AutoSize = True
        Me.Yes.Location = New System.Drawing.Point(133, 120)
        Me.Yes.Name = "Yes"
        Me.Yes.Size = New System.Drawing.Size(43, 19)
        Me.Yes.TabIndex = 2
        Me.Yes.Text = "Yes"
        Me.Yes.UseVisualStyleBackColor = True
        '
        'No
        '
        Me.No.AutoSize = True
        Me.No.Location = New System.Drawing.Point(255, 120)
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(41, 19)
        Me.No.TabIndex = 3
        Me.No.TabStop = True
        Me.No.Text = "No"
        Me.No.UseVisualStyleBackColor = True
        '
        'Form2button
        '
        Me.Form2button.Location = New System.Drawing.Point(133, 174)
        Me.Form2button.Name = "Form2button"
        Me.Form2button.Size = New System.Drawing.Size(163, 111)
        Me.Form2button.TabIndex = 4
        Me.Form2button.Text = "시작하기"
        Me.Form2button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 320)
        Me.Controls.Add(Me.Form2button)
        Me.Controls.Add(Me.No)
        Me.Controls.Add(Me.Yes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Yes As RadioButton
    Friend WithEvents No As RadioButton
    Friend WithEvents Form2button As Button
End Class
