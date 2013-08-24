Public Class MainWin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim LineText() As String = Split(Codebox.Text, Chr(13) + Chr(10))
        Dim i, j As Integer
        Dim instance As Stopwatch = Stopwatch.StartNew()
        Dim Ana As New Analyze, ParaList() As String

        DebugBox.Text = ""
        For i = 0 To UBound(LineText)
            DebugBox.Text += "正在解析第" + (i + 1).ToString + "行,结果=" + Ana.IsLegal(LineText(i)).ToString + Chr(13) + Chr(10)
            DebugBox.Text += "GetFactName=" + Ana.GetFactName(LineText(i)) + Chr(13) + Chr(10)
            ParaList = Ana.GetParaName(LineText(i))
            For j = 0 To UBound(ParaList)
                If ParaList(j) <> "" Then
                    If Ana.IsBlock(ParaList(j)) Then
                        DebugBox.Text += "GetVarName=" + Ana.IsBlock(ParaList(j)).ToString + Chr(13) + Chr(10)
                        DebugBox.Text += "VarName=" + ParaList(j) + Chr(13) + Chr(10) + Chr(13) + Chr(10)
                    Else
                        DebugBox.Text += "GetParaName=" + Ana.GetParaName(LineText(i))(0) + ":" + Ana.GetParaName(LineText(i))(1) + Chr(13) + Chr(10) + Chr(13) + Chr(10)
                        Exit For
                    End If
                End If
            Next
        Next
        DebugBox.Text += "Cost " + instance.ElapsedMilliseconds().ToString + "ms" + Chr(13) + Chr(10)
        instance.Stop()

        'Debug.WriteLine("IsLegal=" + Ana.IsLegal("human(a,b)").ToString)
        'Debug.WriteLine("IsBlock=" + Ana.IsBlock("XXXX").ToString)
        'Debug.WriteLine("IsAlphaOrNum=" + Ana.IsAlphaOrNum("1x").ToString)
        'Debug.WriteLine("StartswithNum=" + Ana.StartswithNum("human(a,b)").ToString)
        'Debug.WriteLine("GetFactName=" + Ana.GetFactName("human(kate)").ToString)
        'Debug.WriteLine("GetVarName=" + Ana.GetVarName("human(X,Y)")(0) + ":" + Ana.GetVarName("human(X,Y)")(1))
        'Debug.WriteLine("GetParaName=" + Ana.GetParaName("human(kate,mike)")(0) + ":" + Ana.GetParaName("human(kate,mike)")(1))
        'Debug.WriteLine("CommaIsLegal=" + Ana.CommaIsLegal("human(kate)").ToString)
        'Debug.WriteLine("BracketsIsLegal=" + Ana.BracketsIsLegal("human(kate)").ToString)

    End Sub

End Class