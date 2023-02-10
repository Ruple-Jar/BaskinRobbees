Imports System.Threading

Public Class Form2
    Private Const MaxNumber As Integer = 3
    Private CurrentNumber As Integer = 0
    Private BackNumber As Integer = CurrentNumber
    Private CurrentTurn As Integer ' 1 : ai, 2 : 사람
    Private IsGameEnd As Boolean = False

    Private Function ComputerRollANumber() As Integer ' 11 - 8
        If Number() - BacksNumber() = 1 Then
            Return Number() + 3
        ElseIf Number() - BacksNumber() = 2 Then
            Return Number() + 2
        ElseIf Number() - BacksNumber() = 3 Then ' 11 - 8
            Return Number() + 1
        End If
    End Function

    Protected Property Number() As Integer
        Set(ByVal Number As Integer)
            CurrentNumber = Number
        End Set
        Get
            Return CurrentNumber
        End Get
    End Property

    Protected Property BacksNumber() As Integer
        Set(ByVal Number As Integer)
            BackNumber = Number
        End Set
        Get
            Return BackNumber
        End Get
    End Property

    Property Turn() As Integer
        Set(ByVal turn As Integer)
            CurrentTurn = turn
            If CurrentTurn = 1 Then
                Information.Text = "컴퓨터 " & "차례 입니다. 인풋박스에 숫자를 최대 3까지 입력하세요."
            ElseIf CurrentTurn = 2 Then
                Information.Text = "당신 " & "차례 입니다. 인풋박스에 숫자를 최대 3까지 입력하세요."
            End If
        End Set
        Get
            Return CurrentTurn
        End Get
    End Property


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Yes.Checked Then
            Turn = 2
        Else
            Turn = 1
        End If
    End Sub

    Private Sub LabelChanger(ByVal str As String)
        Label.Text = str
    End Sub

    Private Function GetLastnumber(ByVal str As String) As Integer
        Dim aa() As String = str.Split(" "c)
        Return CInt(aa(aa.Length - 1))
    End Function

    Private Function GetFirstNumber(ByVal str As String) As Integer
        Dim aa() As String = str.Split(" "c)
        Return CInt(aa(aa.Length - aa.Length))
    End Function


    Private Sub GameLoop()
        While IsGameEnd = False
            If Turn = 2 Then
                Dim Answar = InputBox("당신 차례입니다. 식을 x, x, x 형식으로 입력하세요.")
                Dim LastNumber As Integer = GetLastnumber(Answar)
                Dim Firstnumber As Integer = GetFirstNumber(Answar)
                Dim Answar2
                While Firstnumber - 1 <> Number() Or LastNumber > Number() + MaxNumber
                    Answar2 = InputBox("잘못된 형식입니다. 다시 입력해주세요.")
                    LastNumber = GetLastnumber(Answar2)
                    Firstnumber = GetFirstNumber(Answar2)
                End While
                BacksNumber = Number()
                If (LastNumber >= 31) Then
                    MsgBox("게임 끝! 당신의 패배!")
                    Environment.Exit(0)
                End If
                Number = LastNumber
                LabelChanger(Number.ToString)
                Turn = 1
            ElseIf Turn = 1 Then
                MsgBox("컴퓨터가 숫자를 고릅니다..")
                Dim ComputersNumber As Integer = ComputerRollANumber()
                If (ComputersNumber >= 31) Then
                    MsgBox("게임 끝! 당신의 승리!")
                    Environment.Exit(0)
                End If
                Number = ComputersNumber
                LabelChanger(ComputersNumber.ToString)
                Turn = 2
            End If
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GameLoop()
    End Sub
End Class