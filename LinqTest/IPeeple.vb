Public Interface IPeeple

    ''' <summary>
    ''' このインスタンスのIdを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property ID As Integer

    ''' <summary>
    ''' このインスタンスの名字を設定および取得します。
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property FamilyName As String

    ''' <summary>
    ''' このインスタンスの名前を設定および取得します。
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property FirstName As String

    ''' <summary>
    ''' このインスタンスの年齢を設定および取得します。
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Age As Integer

    ''' <summary>
    ''' このインスタンスの所属グループIDを設定および取得します。
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Group As Integer
End Interface
