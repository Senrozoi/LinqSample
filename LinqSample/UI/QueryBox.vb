Public Class QueryBox
    'Private TreeCreater As ExpressionCreater(Of T)


    'Public Sub New()
    '    TreeCreater = New ExpressionCreater(Of T)


    'End Sub







    'Public Sub CreatTreecreater()
    '    Dim Creater As New ExpressionCreater(Of T)
    'End Sub

    'ラムダ式返しまーす
    Public Function WhereLambda() As Func(Of Peeple, Boolean)
        Return Function(p As Peeple) p.age > 50
    End Function


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
