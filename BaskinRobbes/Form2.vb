Imports System.Threading

Public Class Form2
    Public playerfirst As Boolean
    Private Const MaxNumber As Integer = 3
    Private CurrentNumber As Integer = 0
    Private CurrentTurn As Integer ' 1 : ai, 2 : 사람
    Private IsGameEnd As Boolean = False

    Protected Property Number() As Integer
        Set(ByVal Number As Integer)
            CurrentNumber = Number
        End Set
        Get
            Return CurrentNumber
        End Get
    End Property

    Property Turn() As Integer
        Set(ByVal turn As Integer)
            CurrentTurn = turn
            If CurrentTurn = 1 Then
                Information.Text = "컴퓨터 " & Information.Text
            ElseIf CurrentTurn = 2 Then
                Information.Text = "당신 " & Information.Text
            End If
        End Set
        Get
            Return CurrentTurn
        End Get
    End Property


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GameLoop()
    End Sub

    Private Sub LabelChanger(ByVal str As String)
        Information.Text = str
    End Sub

    Private Function GetLastnumber(ByVal str As String) As Integer
        Dim aa As String = str.ElementAt(str.Length - 1)
        Return CInt(aa)
    End Function

    Private Function GetFirstNumber(ByVal str As String) As Integer
        Dim aa As String = str.ElementAt(str.Length - str.Length)
        Return CInt(aa)
    End Function


    Private Sub GameLoop()
        While IsGameEnd = False
            If playerfirst Or Turn = 2 Then
                If playerfirst = True Then
                    playerfirst = False
                End If
                Dim Answar = InputBox("당신 차례입니다. 식을 x, x, x 형식으로 입력하세요.")
                Dim LastNumber As Integer = GetLastnumber(Answar)
                Dim Firstnumber As Integer = GetFirstNumber(Answar)
                If Firstnumber - 1 <> Number() Or LastNumber > Number() + 3 Then
                    Dim Answawr2 = InputBox("잘못된 형식입니다. 다시 입력해주세요.")
                End If
            ElseIf Turn = 1 Then

            End If
        End While
    End Sub

End Class