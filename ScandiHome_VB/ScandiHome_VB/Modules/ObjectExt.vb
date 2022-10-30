#Region "Refs"

Imports System.Runtime.CompilerServices

#End Region

Module ObjectExt

    <Extension()> Public Sub Release(ByRef pObject As DataTable)
        If pObject IsNot Nothing Then
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As Form)
        If pObject IsNot Nothing Then
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As DevExpress.XtraEditors.XtraForm)
        If pObject IsNot Nothing Then
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As DevExpress.XtraEditors.XtraUserControl)
        If pObject IsNot Nothing Then
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As DevExpress.XtraReports.UI.XtraReport)
        If pObject IsNot Nothing Then
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As DevExpress.XtraGrid.GridControl)
        If pObject IsNot Nothing Then
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As HTLFW.ListKeyValues)
        If pObject IsNot Nothing Then
            pObject.Clear()
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As HTLFW.DuLieuPhanQuyenNguoiDung)
        If pObject IsNot Nothing Then
            pObject.Clear()
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As HTLFW.DuLieuPhanQuyenNguoiDung.PhanQuyenNguoiDung)
        If pObject IsNot Nothing Then
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As SqlClient.SqlConnection)
        If pObject IsNot Nothing Then
            pObject.Close()
            SqlClient.SqlConnection.ClearPool(pObject)
            pObject.Dispose()
            SqlClient.SqlConnection.ClearAllPools()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As DataRow)
        If pObject IsNot Nothing Then
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As Reflection.AssemblyFileVersionAttribute)
        If pObject IsNot Nothing Then
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As IO.FileStream)
        If pObject IsNot Nothing Then
            pObject.Flush()
            pObject.Close()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As IO.StreamWriter)
        If pObject IsNot Nothing Then
            pObject.Flush()
            pObject.Close()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As HTLFW.ResponseItemClicked)
        If pObject IsNot Nothing Then
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As SqlClient.SqlCommand)
        If pObject IsNot Nothing Then
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As SqlClient.SqlDataAdapter)
        If pObject IsNot Nothing Then
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As SqlClient.SqlTransaction)
        If pObject IsNot Nothing Then
            pObject.Dispose()
            pObject = Nothing
        End If
    End Sub
    <Extension()> Public Sub Release(ByRef pObject As System.Object)
        If pObject IsNot Nothing Then
            pObject = Nothing
        End If
    End Sub

    '<Extension()> Public Sub Release(ByRef pObject As System.Object)
    '    Try
    '        If pObject IsNot Nothing Then
    '            If pObject.GetType.IsSubclassOf(GetType(System.Data.DataTable)) OrElse _
    '                pObject.GetType.IsSubclassOf(GetType(Windows.Forms.Form)) OrElse _
    '                pObject.GetType.IsSubclassOf(GetType(DevExpress.XtraEditors.XtraForm)) OrElse _
    '                pObject.GetType.IsSubclassOf(GetType(Windows.Forms.UserControl)) OrElse _
    '                pObject.GetType.IsSubclassOf(GetType(DevExpress.XtraEditors.XtraUserControl)) OrElse _
    '                pObject.GetType.IsSubclassOf(GetType(DevExpress.XtraReports.UI.XtraReport)) OrElse _
    '                pObject.GetType.IsSubclassOf(GetType(DevExpress.XtraGrid.GridControl)) OrElse _
    '                pObject.GetType.IsSubclassOf(GetType(HTLFW.ListKeyValues)) OrElse _
    '                pObject.GetType.IsSubclassOf(GetType(HTLFW.DuLieuPhanQuyenNguoiDung)) _
    '                Then
    '                pObject.Dispose()
    '            Else
    '                If pObject.GetType.Equals(GetType(System.Data.SqlClient.SqlConnection)) Then
    '                    pObject.Close()
    '                    SqlClient.SqlConnection.ClearPool(pObject)
    '                    pObject.Dispose()
    '                    SqlClient.SqlConnection.ClearAllPools()
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '    End Try
    '    pObject = Nothing
    'End Sub

End Module
