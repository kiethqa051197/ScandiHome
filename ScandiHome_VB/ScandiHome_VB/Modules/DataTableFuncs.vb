Imports System.Runtime.CompilerServices
Imports HTLFW

Module DataTableFuncs

#Region "DataTable"

    <Extension()> Public Function IsNoData(ByVal pDataTable As DataTable) As Boolean
        Return (pDataTable Is Nothing OrElse pDataTable.Rows.Count = 0)
    End Function

    <Extension()> Public Sub RemoveAll(ByVal pRows As System.Data.DataRowCollection, ByVal pDataRow As List(Of DataRow))
        If pRows Is Nothing Then Exit Sub
        If pRows.Count = 0 Then Exit Sub
        For Each mRow As DataRow In pDataRow
            Try
                pRows.Remove(mRow)
            Catch ex As Exception

            End Try
        Next
    End Sub

    <Extension()> Public Sub RemoveAllRows(ByVal pDataTable As DataTable, ByVal pDataRow As List(Of DataRow))
        If pDataTable Is Nothing Then Exit Sub
        If pDataTable.Rows.Count = 0 Then Exit Sub
        For Each mRow As DataRow In pDataRow
            Try
                pDataTable.Rows.Remove(mRow)
            Catch ex As Exception

            End Try
        Next
    End Sub

    <Extension()> Public Function GetRows(ByVal pDataTable As DataTable, ByVal ParamArray pWhereParams() As WhereObjectParam) As List(Of DataRow)
        If pDataTable Is Nothing Then Return Nothing
        If pDataTable.Rows.Count = 0 Then Return Nothing
        Try
            Dim mFoundRows As List(Of DataRow) = pDataTable.Rows.OfType(Of DataRow)().ToList
            Dim i As Integer
            If Not pWhereParams Is Nothing Then
                For i = 0 To pWhereParams.Count - 1
                    mFoundRows = mFoundRows.Where(Function(pp) pp.Item(pWhereParams(i).Name).Equals(pWhereParams(i).Value) = True).ToList
                Next
                If mFoundRows Is Nothing Then Return Nothing
                If mFoundRows.Count = 0 Then Return Nothing
            End If
            Return mFoundRows.ToList
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    <Extension()> Public Function GetRows(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal pFieldValue As Object) As List(Of DataRow)
        If pDataTable Is Nothing Then Return Nothing
        If pDataTable.Rows.Count = 0 Then Return Nothing
        If HTLFW.HTLLib.HTLComFuncs.IsNoValue(pFieldValue) Then
            Return pDataTable.Rows.OfType(Of DataRow)().Where(Function(pp) pp.Item(pFieldName).Equals(System.DBNull.Value) OrElse pp.Item(pFieldName) Is Nothing OrElse pp.Item(pFieldName).Equals("")).ToList
        Else
            If pFieldValue.GetType Is GetType(String) Then
                Return pDataTable.Rows.OfType(Of DataRow)().Where(Function(pp) String.Compare(pp.Item(pFieldName), pFieldValue, True) = 0).ToList
            Else
                Return pDataTable.Rows.OfType(Of DataRow)().Where(Function(pp) pp.Item(pFieldName).Equals(pFieldValue)).ToList
            End If
        End If
    End Function
    <Extension()> Public Function GetRows(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal pFieldValue As Object, ByVal pFieldName2 As String, ByVal pFieldValue2 As Object) As List(Of DataRow)
        Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pFieldName, pFieldValue)
        Return mFoundRows.GetRows(pFieldName2, pFieldValue2)
    End Function
    <Extension()> Public Function GetRows(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal pFieldValue As Object, ByVal pFieldName2 As String, ByVal pFieldValue2 As Object, ByVal pFieldName3 As String, ByVal pFieldValue3 As Object) As List(Of DataRow)
        Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pFieldName, pFieldValue)
        mFoundRows = mFoundRows.GetRows(pFieldName2, pFieldValue2)
        Return mFoundRows.GetRows(pFieldName3, pFieldValue3)
    End Function

    <Extension()> Public Function DLookup(Of T)(ByVal pDataTable As DataTable, ByVal pFieldName As String) As T
        Dim mResult As Object = DLookup(pDataTable, pFieldName)
        If Not mResult Is Nothing Then
            Return CType(mResult, T)
        Else
            Return Nothing
        End If
    End Function
    <Extension()> Public Function DLookup(ByVal pDataTable As DataTable, ByVal pFieldName As String) As Object
        Return DLookup(pDataTable, pFieldName, Nothing)
    End Function
    <Extension()> Public Function DLookup(Of T)(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As T
        Dim mResult As Object = DLookup(pDataTable, pFieldName, pWhereParams)
        If Not mResult Is Nothing Then
            Return CType(mResult, T)
        Else
            Return Nothing
        End If
    End Function
    <Extension()> Public Function DLookup(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As Object
        If pDataTable Is Nothing Then Return Nothing
        If pDataTable.Rows.Count = 0 Then Return Nothing
        Try
            Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pWhereParams)
            If mFoundRows Is Nothing Then Return Nothing
            If mFoundRows.Count = 0 Then Return Nothing
            Return mFoundRows.FirstOrDefault().Item(pFieldName)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    '<Extension()> Public Function DLookup(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal pKeys As ListKeyValues) As Object
    '    If pDataTable Is Nothing Then Return Nothing
    '    If pDataTable.Rows.Count = 0 Then Return Nothing
    '    Try
    '        Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pKeys)
    '        If mFoundRows Is Nothing Then Return Nothing
    '        If mFoundRows.Count = 0 Then Return Nothing
    '        Return mFoundRows.FirstOrDefault().Item(pFieldName)
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function
    <Extension()> Public Function DLookup(ByVal pDataTable As DataTable, ByVal pLookUpFieldName As String, ByVal pFieldName As String, ByVal pFieldValue As Object) As Object
        If pDataTable Is Nothing Then Return Nothing
        If pDataTable.Rows.Count = 0 Then Return Nothing
        Try
            Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pFieldName, pFieldValue)
            If mFoundRows Is Nothing Then Return Nothing
            If mFoundRows.Count = 0 Then Return Nothing
            Return mFoundRows.FirstOrDefault().Item(pLookUpFieldName)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    <Extension()> Public Function DLookup(ByVal pDataTable As DataTable, ByVal pLookUpFieldName As String, ByVal pFieldName As String, ByVal pFieldValue As Object, ByVal pFieldName2 As String, ByVal pFieldValue2 As Object) As Object
        If pDataTable Is Nothing Then Return Nothing
        If pDataTable.Rows.Count = 0 Then Return Nothing
        Try
            Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pFieldName, pFieldValue)
            mFoundRows = mFoundRows.GetRows(pFieldName2, pFieldValue2)
            If mFoundRows Is Nothing Then Return Nothing
            If mFoundRows.Count = 0 Then Return Nothing
            Return mFoundRows.FirstOrDefault().Item(pLookUpFieldName)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    <Extension()> Public Function DLookup(ByVal pDataTable As DataTable, ByVal pLookUpFieldName As String, ByVal pFieldName As String, ByVal pFieldValue As Object, ByVal pFieldName2 As String, ByVal pFieldValue2 As Object, ByVal pFieldName3 As String, ByVal pFieldValue3 As Object) As Object
        If pDataTable Is Nothing Then Return Nothing
        If pDataTable.Rows.Count = 0 Then Return Nothing
        Try
            Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pFieldName, pFieldValue)
            mFoundRows = mFoundRows.GetRows(pFieldName2, pFieldValue2)
            mFoundRows = mFoundRows.GetRows(pFieldName3, pFieldValue3)
            If mFoundRows Is Nothing Then Return Nothing
            If mFoundRows.Count = 0 Then Return Nothing
            Return mFoundRows.FirstOrDefault().Item(pLookUpFieldName)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    <Extension()> Public Function DSum(Of T)(ByVal pDataTable As DataTable, ByVal pFieldName As String) As T
        Dim mResult As Object = DSum(pDataTable, pFieldName)
        If Not mResult Is Nothing Then
            Return CType(mResult, T)
        Else
            Return Nothing
        End If
    End Function
    <Extension()> Public Function DSum(ByVal pDataTable As DataTable, ByVal pFieldName As String) As Double
        Return DSum(pDataTable, pFieldName, Nothing)
    End Function
    <Extension()> Public Function DSum(Of T)(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As T
        Dim mResult As Object = DSum(pDataTable, pFieldName, pWhereParams)
        If Not mResult Is Nothing Then
            Return CType(mResult, T)
        Else
            Return Nothing
        End If
    End Function
    <Extension()> Public Function DSum(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As Double
        If pDataTable Is Nothing Then Return 0.0
        If pDataTable.Rows.Count = 0 Then Return 0.0
        Try
            Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pWhereParams)
            If mFoundRows Is Nothing Then Return 0.0
            If mFoundRows.Count = 0 Then Return 0.0
            Return CType(mFoundRows.Sum(Function(pp) CType(pp.Item(pFieldName), Double)), Double)
        Catch ex As Exception
            Return 0.0
        End Try
    End Function

    <Extension()> Public Function DCount(ByVal pDataTable As DataTable, ByVal pFieldName As String) As Integer
        Return DCount(pDataTable, pFieldName, Nothing)
    End Function
    <Extension()> Public Function DCount(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As Integer
        If pDataTable Is Nothing Then Return 0
        If pDataTable.Rows.Count = 0 Then Return 0
        Try
            Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pWhereParams)
            If mFoundRows Is Nothing Then Return 0
            If mFoundRows.Count = 0 Then Return 0
            Return mFoundRows.Count
        Catch ex As Exception
            Return 0
        End Try
    End Function

    <Extension()> Public Function DMax(Of T)(ByVal pDataTable As DataTable, ByVal pFieldName As String) As T
        Dim mResult As Object = DMax(pDataTable, pFieldName)
        If Not mResult Is Nothing Then
            Return CType(mResult, T)
        Else
            Return Nothing
        End If
    End Function
    <Extension()> Public Function DMax(ByVal pDataTable As DataTable, ByVal pFieldName As String) As Object
        Return DMax(pDataTable, pFieldName, Nothing)
    End Function
    <Extension()> Public Function DMax(Of T)(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As T
        Dim mResult As Object = DMax(pDataTable, pFieldName, pWhereParams)
        If Not mResult Is Nothing Then
            Return CType(mResult, T)
        Else
            Return Nothing
        End If
    End Function
    <Extension()> Public Function DMax(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As Object
        If pDataTable Is Nothing Then Return Nothing
        If pDataTable.Rows.Count = 0 Then Return Nothing
        Try
            Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pWhereParams)
            If mFoundRows Is Nothing Then Return Nothing
            If mFoundRows.Count = 0 Then Return Nothing
            Return mFoundRows.Where(Function(p) Not p.Item(pFieldName).Equals(System.DBNull.Value)).Select(Function(pp) pp.Item(pFieldName)).Max
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    <Extension()> Public Function DMin(Of T)(ByVal pDataTable As DataTable, ByVal pFieldName As String) As T
        Dim mResult As Object = DMin(pDataTable, pFieldName)
        If Not mResult Is Nothing Then
            Return CType(mResult, T)
        Else
            Return Nothing
        End If
    End Function
    <Extension()> Public Function DMin(ByVal pDataTable As DataTable, ByVal pFieldName As String) As Object
        Return DMin(pDataTable, pFieldName, Nothing)
    End Function
    <Extension()> Public Function DMin(Of T)(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As T
        Dim mResult As Object = DMin(pDataTable, pFieldName, pWhereParams)
        If Not mResult Is Nothing Then
            Return CType(mResult, T)
        Else
            Return Nothing
        End If
    End Function
    <Extension()> Public Function DMin(ByVal pDataTable As DataTable, ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As Object
        If pDataTable Is Nothing Then Return Nothing
        If pDataTable.Rows.Count = 0 Then Return Nothing
        Try
            Dim mFoundRows As List(Of DataRow) = pDataTable.GetRows(pWhereParams)
            If mFoundRows Is Nothing Then Return Nothing
            If mFoundRows.Count = 0 Then Return Nothing
            Return mFoundRows.Where(Function(p) Not p.Item(pFieldName).Equals(System.DBNull.Value)).Select(Function(pp) pp.Item(pFieldName)).Min
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    <Extension()> Public Function DExists(ByVal pDataTable As DataTable, ByVal ParamArray pWhereParams() As WhereObjectParam) As Boolean
        If pDataTable Is Nothing Then Return False
        If pDataTable.Rows.Count = 0 Then Return False
        Try
            Dim mFoundRows As List(Of DataRow) = pDataTable.Rows.OfType(Of DataRow)().ToList
            Dim i As Integer
            If Not pWhereParams Is Nothing Then
                For i = 0 To pWhereParams.Count - 1
                    mFoundRows = mFoundRows.Where(Function(pp) pp.Item(pWhereParams(i).Name).Equals(pWhereParams(i).Value) = True).ToList
                Next
                If mFoundRows Is Nothing Then Return False
                If mFoundRows.Count = 0 Then Return False
            End If
            Return mFoundRows.Count > 0
        Catch ex As Exception
            Return False
        End Try
    End Function

    <Extension()> Public Function GetStringItemsFromColumnName(ByVal pDataTable As DataTable, ByVal pColumnName As String) As List(Of String)
        Dim mResult As New List(Of String)
        If pDataTable Is Nothing Then Return mResult
        If pDataTable.Rows.Count = 0 Then Return mResult
        Try
            For i As Integer = pDataTable.Rows.Count - 1 To 0 Step -1
                If Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pDataTable.Rows(i).Item(pColumnName)) Then mResult.Add(CStr(pDataTable.Rows(i).Item(pColumnName)))
            Next
        Catch ex As Exception
        End Try
        Return mResult
    End Function

#End Region

#Region "List of DataRow"

    <Extension()> Public Function GetRows(ByVal pListRows As List(Of DataRow), ByVal ParamArray pWhereParams() As WhereObjectParam) As List(Of DataRow)
        If pListRows Is Nothing Then Return Nothing
        If pListRows.Count = 0 Then Return Nothing
        Try
            Dim mFoundRows As List(Of DataRow) = pListRows.ToList
            Dim i As Integer
            If Not pWhereParams Is Nothing Then
                For i = 0 To pWhereParams.Count - 1
                    mFoundRows = mFoundRows.Where(Function(pp) pp.Item(pWhereParams(i).Name).Equals(pWhereParams(i).Value) = True).ToList
                Next
                If mFoundRows Is Nothing Then Return Nothing
                If mFoundRows.Count = 0 Then Return Nothing
            End If
            Return mFoundRows.ToList
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    <Extension()> Public Function GetRows(ByVal pListRows As List(Of DataRow), ByVal pFieldName As String, ByVal pFieldValue As Object) As List(Of DataRow)
        If pListRows Is Nothing Then Return Nothing
        If pListRows.Count = 0 Then Return Nothing
        If HTLFW.HTLLib.HTLComFuncs.IsNoValue(pFieldValue) Then
            Return pListRows.Where(Function(pp) pp.Item(pFieldName).Equals(System.DBNull.Value) OrElse pp.Item(pFieldName) Is Nothing OrElse pp.Item(pFieldName).Equals("")).ToList
        Else
            If pFieldValue.GetType Is GetType(String) Then
                Return pListRows.Where(Function(pp) String.Compare(pp.Item(pFieldName), pFieldValue, True) = 0).ToList
            Else
                Return pListRows.Where(Function(pp) pp.Item(pFieldName).Equals(pFieldValue)).ToList
            End If
        End If
    End Function
    <Extension()> Public Function GetRows(ByVal pListRows As List(Of DataRow), ByVal pFieldName As String, ByVal pFieldValue As Object, ByVal pFieldName2 As String, ByVal pFieldValue2 As Object) As List(Of DataRow)
        Dim mFoundRows As List(Of DataRow) = pListRows.GetRows(pFieldName, pFieldValue)
        Return mFoundRows.GetRows(pFieldName2, pFieldValue2)
    End Function
    <Extension()> Public Function GetRows(ByVal pListRows As List(Of DataRow), ByVal pFieldName As String, ByVal pFieldValue As Object, ByVal pFieldName2 As String, ByVal pFieldValue2 As Object, ByVal pFieldName3 As String, ByVal pFieldValue3 As Object) As List(Of DataRow)
        Dim mFoundRows As List(Of DataRow) = pListRows.GetRows(pFieldName, pFieldValue)
        mFoundRows = mFoundRows.GetRows(pFieldName2, pFieldValue2)
        Return mFoundRows.GetRows(pFieldName3, pFieldValue3)
    End Function
    <Extension()> Public Function GetRows(ByVal pListRows As List(Of DataRow), ByVal pKeys As ListKeyValues) As List(Of DataRow)
        If pListRows Is Nothing Then Return Nothing
        If pListRows.Count = 0 Then Return Nothing
        Try
            Dim mFoundRows As List(Of DataRow) = pListRows.ToList
            If Not pKeys Is Nothing Then
                For Each mKey In pKeys
                    mFoundRows = mFoundRows.Where(Function(pp) pp.Item(mKey.KeyName).Equals(mKey.KeyValue) = True).ToList
                Next
                If mFoundRows Is Nothing Then Return Nothing
                If mFoundRows.Count = 0 Then Return Nothing
            End If
            Return mFoundRows.ToList
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    <Extension()> Public Function DLookup(Of T)(ByVal pListRows As List(Of DataRow), ByVal pFieldName As String) As T
        Dim mResult As Object = DLookup(pListRows, pFieldName)
        If Not mResult Is Nothing Then
            Return CType(mResult, T)
        Else
            Return Nothing
        End If
    End Function
    <Extension()> Public Function DLookup(ByVal pListRows As List(Of DataRow), ByVal pFieldName As String) As Object
        Return DLookup(pListRows, pFieldName, Nothing)
    End Function
    <Extension()> Public Function DLookup(Of T)(ByVal pListRows As List(Of DataRow), ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As T
        Dim mResult As Object = DLookup(pListRows, pFieldName, pWhereParams)
        If Not mResult Is Nothing Then
            Return CType(mResult, T)
        Else
            Return Nothing
        End If
    End Function
    <Extension()> Public Function DLookup(ByVal pListRows As List(Of DataRow), ByVal pFieldName As String, ByVal ParamArray pWhereParams() As WhereObjectParam) As Object
        If pListRows Is Nothing Then Return Nothing
        If pListRows.Count = 0 Then Return Nothing
        Try
            Dim mFoundRows As List(Of DataRow) = pListRows.GetRows(pFieldName, pWhereParams)
            If mFoundRows Is Nothing Then Return Nothing
            If mFoundRows.Count = 0 Then Return Nothing
            Return mFoundRows.FirstOrDefault().Item(pFieldName)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region

End Module