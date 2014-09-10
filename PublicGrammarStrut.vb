Public Module PublicGrammarStrut

    Public Structure SParameterName
        Dim SingleParaName() As String
        Dim DoubleParaName() As String
    End Structure

    Public Structure SFactName
        Dim Fact()() As String '包含事实名称和参数
    End Structure

    Public Structure DoubleFactList
        Dim Fact() As String '包含事实名称
        Dim Parameter()() As String '包含参数1和参数2,用于比较
    End Structure

End Module