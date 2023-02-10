<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Information = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Information
        '
        Me.Information.AutoSize = True
        Me.Information.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Information.Location = New System.Drawing.Point(41, 25)
        Me.Information.Name = "Information"
        Me.Information.Size = New System.Drawing.Size(361, 19)
        Me.Information.TabIndex = 0
        Me.Information.Text = "차례 입니다. 인풋박스에 숫자를 최대 3까지 입력하세요."
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label.Location = New System.Drawing.Point(175, 103)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(71, 28)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 351)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Information)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Information As Label
    Friend WithEvents Label As Label
End Class
