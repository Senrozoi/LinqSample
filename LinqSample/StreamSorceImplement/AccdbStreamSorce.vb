''' <summary>
''' .accdb用IStreamSorce実装
''' </summary>
''' <remarks></remarks>
Public Class AccdbStreamSorce
    Implements IStreamSorce
    Private _DataSet As AccdbDataSet
    Private _Adapter As AccdbDataSetTableAdapters.peeplesTableAdapter

    ''' <summary>
    ''' Accdb用のIQueryable(Of IPeeple)を返します。
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AsQueryable() As System.Linq.IQueryable(Of IPeeple) Implements IStreamSorce.AsQueryable
        _DataSet = New AccdbDataSet
        _Adapter = New AccdbDataSetTableAdapters.peeplesTableAdapter
        _Adapter.Fill(_DataSet.peeples)
        Dim rb As IQueryable = _DataSet.peeples.AsQueryable
        Dim Q = _DataSet.peeples.Select(Function(p) New AccdbPeeple(p)).AsQueryable
        Return Q

    End Function

    ''' <summary>
    ''' 名前のまま
    ''' </summary>
    Public Sub Update() Implements IStreamSorce.Update
        _Adapter.Update(_DataSet)
    End Sub
End Class
