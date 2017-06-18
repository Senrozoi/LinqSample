Imports System.Data.Common
Public Class MdbStreamSorce
    Implements IStreamSorce

    Private _DataSet As MDBDataSet
    Private _Adapter As MDBDataSetTableAdapters.peeplesTableAdapter


    Public Function AsQueryable() As System.Linq.IQueryable(Of IPeeple) Implements IStreamSorce.AsQueryable
        _DataSet = New MDBDataSet
        _Adapter = New MDBDataSetTableAdapters.peeplesTableAdapter

        Dim DT As New MDBDataSet.peeplesDataTable
        Dim adp As New MDBDataSetTableAdapters.peeplesTableAdapter
        _Adapter.Fill(_DataSet.peeples)
        Dim rb As IQueryable = _DataSet.peeples.AsQueryable
        Dim Q = _DataSet.peeples.Select(Function(p) New MdbPeeple(p)).AsQueryable
        Return Q
    End Function

    Public Sub Update() Implements IStreamSorce.Update
        _Adapter.Update(_DataSet)
    End Sub
End Class
