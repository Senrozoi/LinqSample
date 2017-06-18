Imports System.ComponentModel
Public Class ActionTextBox
    Inherits TextBox

    <Browsable(True)>
    <Category("表示")>
    <DefaultValue("")>
    <Description("プレースホルダとして表示するテキストです。")>
    Public Property PlaceHolder As String


    <Browsable(True)>
    <Category("表示")>
    <DefaultValue("")>
    <Description("ユーザーの入力がチェックアクションでエラー判定だった時に発生するアクションです。")>
    Public Property ErrAction As IErrAction

    <Browsable(True)>
    <Category("表示")>
    <DefaultValue("")>
    <Description("ユーザーの入力を検証するアクションです。")>
    Public Property CheckAction As IInputChecAction


    ''' <summary>
    ''' ユーザー入力を検証します。
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Validation(ByVal sender As Object, ByVal e As CancelEventArgs) Handles MyBase.Validating
        If CheckAction.IsFailedInput(Me) Then
            ErrAction.Action(Me)
        End If
    End Sub


End Class
