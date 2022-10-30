Public Class ResponseListItemSelector

    Public Enum eSelectMethod
        GetListForUpdate
        GetListForDelete
        GetListForInsert
    End Enum

    Public Enum eListItemReturn
        PickUp
        Cancel
    End Enum

    Public _SelectMethod As eSelectMethod = eSelectMethod.GetListForUpdate
    Public Property SelectMethod() As eSelectMethod
        Get
            Return _SelectMethod
        End Get
        Set(ByVal value As eSelectMethod)
            _SelectMethod = value
        End Set
    End Property

    Public _ListItemReturn As eListItemReturn = eListItemReturn.Cancel
    Public Property ListItemReturn() As eListItemReturn
        Get
            Return _ListItemReturn
        End Get
        Set(ByVal value As eListItemReturn)
            _ListItemReturn = value
        End Set
    End Property

    Private _ItemList As New HTLFW.ListKeyValues
    Public Property ItemList() As HTLFW.ListKeyValues
        Get
            Return _ItemList
        End Get
        Set(ByVal value As HTLFW.ListKeyValues)
            _ItemList = value
        End Set
    End Property

    Public Sub ResetItemList()
        _ItemList.Clear()
    End Sub

    Public Function GetItems() As String
        Try
            Dim mResult As String = ""
            For Each mItem In _ItemList
                mResult = mResult + If(mResult <> "", ", ", "") + mItem.KeyName
            Next
            Return mResult
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function Item(Of T)(ByVal pIndex As Integer) As T
        Try
            Dim mItem As Object = _ItemList.KeyValue(pIndex)
            Return CType(mItem, T)
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Sub New()

    End Sub

End Class
