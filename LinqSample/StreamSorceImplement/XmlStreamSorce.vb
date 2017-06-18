Public Class XmlStreamSorce
    Implements IStreamSorce

    Private _sorce As XDocument

    Sub New()
        _sorce = XDocument.Load(".\Datas\Sample.xml")
    End Sub

    ''' <summary>
    ''' XMLから作成したIQueryable(Of IPeeple)を返します。
    ''' </summary>
    ''' <returns></returns>
    Public Function AsQueryable() As System.Linq.IQueryable(Of IPeeple) Implements IStreamSorce.AsQueryable

        Dim Xml = _sorce.Descendants("peeple")
        Dim query = Xml.Select(Function(p) New XmlPeeple(p)).AsQueryable
        Return query
        '型推論を使っています。暗黙の型変換ではありません
    End Function

    Public Sub Update() Implements IStreamSorce.Update
        _sorce.Save(".\Datas\Sample.xml")
    End Sub
End Class
