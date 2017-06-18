Public Class ExcelStreamSorce
    Implements IStreamSorce



    Public Function AsQueryable() As IQueryable(Of IPeeple) Implements IStreamSorce.AsQueryable
        Dim excel As New ExcelQueryFactory(".\Datas\Sample.xlsx")

        Dim memberSheet As LinqToExcel.Query.ExcelQueryable(Of LinqToExcel.Row) = excel.Worksheet("Sheet1")

        Dim Peeples = memberSheet.Select(Of Peeple)(Function(p) New Peeple(CInt(p("ID").Value)) With {
                                                        .age = p("age").Cast(Of Integer)(),
                                                        .FamilyName = p("FamilyName").Cast(Of String)(),
                                                        .FirstName = p("FirstName").Cast(Of String)(),
                                                        .group = p("group").Cast(Of Integer)()}).AsQueryable
        Return Peeples

        '型安全にしたいならこんな感じ(コンストラクタは使えないけど)
        '        excel.AddMapping(Of Peeple)(Function(p) p.ID, "ID")
        '        excel.AddMapping(Of Peeple)(Function(p) p.FamilyName, "FamilyName")
        '        excel.AddMapping(Of Peeple)(Function(p) p.FirstName, "FirstName")
        '        excel.AddMapping(Of Peeple)(Function(p) p.age, "age")
        '        excel.AddMapping(Of Peeple)(Function(p) p.group, "group")
    End Function

    Public Sub Update() Implements IStreamSorce.Update
        Throw New NotImplementedException("期待させてすまない・・・LinqToExcelに更新機能はないのだ。")
        '更新したのであれば、独自にExcelに保存するロジックを記述することになる
        'AsQueryable内でインスタンス変数にワークシートの状態管理オブジェクトへの参照を入れておいて
        'Update実行時にそれを書きだせばいいのでは。


        'IQueryableの実装自体は死ぬほど複雑なものでもない
        '(死ぬほど面倒くさくないとは言っていない)ので保存可能なLinqToExcelを自作してもいいかもね
    End Sub
End Class
