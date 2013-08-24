'表示事实：
'human(kate)
'human(bill)
'likes(kate,bill)
'——表示kate和bill是人（human），kate喜欢bill；
'表示规则：
'friend(X,Y):-likes(X,Y),likes(Y,X).
'——表示对于两个对象XY，如果X喜欢Y，且Y喜欢X，那么他们是朋友。
Public Class Analyze

    Public Function GetFactName(ByVal Statement As String) As String
        Dim FactToken() As String = Statement.Split("(")
        Return FactToken(0)
    End Function

    Public Function CommaIsLegal(ByVal Statement As String) As Boolean
        Dim StateLength As Integer = Len(Statement)
        Dim StateIndex As Integer
        Dim CommaCount As Integer = 0, CommaExist As String

        For StateIndex = 1 To StateLength
            CommaExist = Mid(Statement, StateIndex, 1)
            If CommaExist = "," Then
                CommaCount += 1
            End If
        Next

        If CommaCount = 1 Or CommaCount = 0 Then
            Return True
        Else : Return False
        End If

    End Function

    Public Function BracketsIsLegal(ByVal Statement As String) As Boolean
        Dim Token_AfterBody As String = Right(Statement, 1)
        Dim LeftParenthesis_Pos As Integer

        If Token_AfterBody <> ")" Then
            Return False
        Else
            LeftParenthesis_Pos = InStr(Statement, "(")
            If LeftParenthesis_Pos = 0 Then
                Return False
            Else
                Return True
            End If
        End If

    End Function

    Public Function GetParaName(ByVal Statement As String) As String()
        Dim CommaExist As Integer = InStr(Statement, ",") '0没有.1有
        Dim SplitComma() As String, FactName As String = GetFactName(Statement)
        Dim FactNameLength As Integer = Len(FactName)
        Dim DoubleParaName(2), SingleParaName(1) As String

        If CommaExist <> 0 Then
            SplitComma = Statement.Split(",")
            DoubleParaName(0) = Mid(SplitComma(0), FactNameLength + 2)
            DoubleParaName(1) = Replace(SplitComma(1), ")", "")
            Return DoubleParaName
        Else
            SingleParaName(0) = Mid(Statement, FactNameLength + 2)
            SingleParaName(0) = Replace(SingleParaName(0), ")", "")
            Return SingleParaName
        End If
    End Function

    Public Function GetVarName(ByVal Statement As String) As String()
        Dim VarFactName As String = GetFactName(Statement)
        Dim VarCommaSpliting() As String = {}
        Dim VarCommaExist As Integer = InStr(Statement, ",") '0没有.1有
        Dim VarSingleParaName(1) As String
        Dim VarFactNameLength As Integer = Len(Statement)

        If VarCommaExist <> 0 Then
            VarCommaSpliting = Statement.Split(",")
            VarCommaSpliting(0) = Replace(VarCommaSpliting(0), VarFactName + "(", "")
            VarCommaSpliting(1) = Replace(VarCommaSpliting(1), ")", "")
            Return VarCommaSpliting
        Else
            VarSingleParaName(0) = Mid(Statement, VarFactNameLength + 2)
            VarSingleParaName(0) = Replace(VarSingleParaName(0), ")", "")
            Return VarSingleParaName
        End If
    End Function

    Public Function IsLegal(ByVal Rescource As String) As Boolean '判断事实或参数名称是否合法
        Dim ResLength As Integer = Len(Rescource)
        Dim JudgeFactName As String = ""
        Dim JudgeParaName() As String = {}
        Dim JudgeVarName() As String = {}
        Dim Judgement As Boolean = True
        Dim i, j As Integer

        If CommaIsLegal(Rescource) And BracketsIsLegal(Rescource) Then
            JudgeFactName = GetFactName(Rescource)
            JudgeParaName = GetParaName(Rescource)
            JudgeVarName = GetVarName(Rescource)
            Judgement = (StartswithNum(JudgeFactName) = False Or IsAlphaOrNum(JudgeFactName))
            If Judgement Then
                For i = 0 To 1
                    If JudgeParaName(i) <> "" Then
                        Judgement = StartswithNum(JudgeParaName(i)) = False Or IsAlphaOrNum(JudgeParaName(i))
                        If Judgement Then
                            For j = 0 To 1
                                If JudgeVarName(i) <> "" Then
                                    Judgement = StartswithNum(JudgeVarName(i)) = False Or IsAlphaOrNum(JudgeVarName(i))
                                    If Judgement Then
                                        Return True
                                    End If
                                End If
                            Next
                        End If
                    End If
                Next
                Return True
            Else : Return False
            End If
        Else : Return False
        End If

    End Function

    Public Function StartswithNum(ByVal str As String) As Boolean
        Dim AscFirst As Integer = Asc(str.First())
        Dim Judge As Boolean

        Judge = AscFirst > 48 And AscFirst < 57

        If Judge Then
            Return True
        Else : Return False
        End If
    End Function

    Public Function IsAlphaOrNum(ByVal ResToBeChecked As String) As Boolean
        Dim ElementIndex As Integer = 0, tmpstr As String, StrLength As Integer
        Dim ErrorCount As Integer = 0
        Dim Judgment As Boolean

        StrLength = Len(ResToBeChecked)
        If ResToBeChecked <> "" Then

            For ElementIndex = 1 To StrLength
                tmpstr = Asc(Mid(ResToBeChecked, ElementIndex, 1))
                Judgment = (tmpstr > 46 And tmpstr < 57) Or (tmpstr > 65 And tmpstr < 90) Or (tmpstr > 97 And tmpstr < 122) Or tmpstr = 95
                If Judgment Then
                    ErrorCount = 0
                Else : Return False
                End If
            Next

            If ErrorCount = 0 Then
                Return True
            Else : Return False
            End If

        Else : Return False
        End If
    End Function

    Public Function IsBlock(ByVal Rescource As String) As Boolean '判断参数是否为大写字母,如为大写字母则是变量
        If Asc(Rescource) > 65 And Asc(Rescource) < 90 Then
            Return True
        Else : Return False
        End If
    End Function

End Class