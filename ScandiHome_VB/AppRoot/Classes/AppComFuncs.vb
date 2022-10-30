#Region "Refs"

Imports HTLFW
Imports HTLFW.HTLLib
Imports HTLFW.HTLLib.HTLComFuncs
Imports HTLFW.HTLLib.HTLFileFuncs
Imports HTLFW.HTLLib.HTLSecurityFuncs
Imports HTLFW.HTLLib.HTLStringFuncs
Imports HTLFW.HTLLib.HTLSystemOSFuncs
Imports HTLFW.MsgBox
Imports AppRoot.AppVars

#End Region

Public Class AppComFuncs

    Public Shared gv_DBVersion As String

    Public Shared Sub GhiOption_STRING(ByVal pGroup As String, ByVal pKey As String, ByVal pValue As String)
        If Not IsNoValue(pValue) Then
            HTLFileFuncs.WriteINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey, pValue.ToString)
        Else
            HTLFileFuncs.WriteINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey, "")
        End If
    End Sub
    Public Shared Sub GhiOption_DATE(ByVal pGroup As String, ByVal pKey As String, ByVal pValue As Nullable(Of Date))
        If pValue.HasValue Then
            HTLFileFuncs.WriteINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey, CType(pValue, Date).ToString("yyyy/MM/dd"))
        Else
            HTLFileFuncs.WriteINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey, "")
        End If
    End Sub
    Public Shared Sub GhiOption_NUMBER(ByVal pGroup As String, ByVal pKey As String, ByVal pValue As Integer)
        If Not IsNoValue(pValue) Then
            HTLFileFuncs.WriteINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey, pValue.ToString)
        Else
            HTLFileFuncs.WriteINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey, "0")
        End If
    End Sub
    Public Shared Sub GhiOption_BOOLEAN(ByVal pGroup As String, ByVal pKey As String, ByVal pValue As Boolean)
        If Not IsNoValue(pValue) Then
            HTLFileFuncs.WriteINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey, If(pValue, "1", "0"))
        Else
            HTLFileFuncs.WriteINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey, "0")
        End If
    End Sub

    Public Shared Function DocOption_STRING(ByVal pGroup As String, ByVal pKey As String) As String
        Dim mValue As String = HTLFileFuncs.ReadINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey)
        If mValue = AppVars.gc_NoValueConfig Then
            Return ""
        Else
            Try
                Return mValue
            Catch ex As Exception
                Return ""
            End Try
        End If
    End Function
    Public Shared Function DocOption_STRING(ByVal pGroup As String, ByVal pKey As String, ByVal pDefaultValue As String) As String
        Dim mValue As String = HTLFileFuncs.ReadINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey)
        If mValue = AppVars.gc_NoValueConfig Then
            Return pDefaultValue
        Else
            Try
                Return mValue
            Catch ex As Exception
                Return pDefaultValue
            End Try
        End If
    End Function
    Public Shared Function DocOption_DATE(ByVal pGroup As String, ByVal pKey As String) As Nullable(Of Date)
        Dim mValue As String = HTLFileFuncs.ReadINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey)
        If mValue = AppVars.gc_NoValueConfig Then
            Return Nothing
        Else
            Try
                Return CType(mValue, Date)
            Catch ex As Exception
                Return Nothing
            End Try
        End If
    End Function
    Public Shared Function DocOption_DATE(ByVal pGroup As String, ByVal pKey As String, ByVal pDefaultValue As Nullable(Of Date)) As Nullable(Of Date)
        Dim mValue As String = HTLFileFuncs.ReadINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey)
        If mValue = AppVars.gc_NoValueConfig Then
            Return pDefaultValue
        Else
            Try
                Return CType(mValue, Date)
            Catch ex As Exception
                Return pDefaultValue
            End Try
        End If
    End Function
    Public Shared Function DocOption_NUMBER(ByVal pGroup As String, ByVal pKey As String) As Integer
        Dim mValue As String = HTLFileFuncs.ReadINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey)
        If mValue = AppVars.gc_NoValueConfig Then
            Return 0
        Else
            Try
                Return CType(mValue, Integer)
            Catch ex As Exception
                Return 0
            End Try
        End If
    End Function
    Public Shared Function DocOption_NUMBER(ByVal pGroup As String, ByVal pKey As String, ByVal pDefaultValue As Integer) As Integer
        Dim mValue As String = HTLFileFuncs.ReadINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey)
        If mValue = AppVars.gc_NoValueConfig Then
            Return pDefaultValue
        Else
            Try
                Return CType(mValue, Integer)
            Catch ex As Exception
                Return pDefaultValue
            End Try
        End If
    End Function

    Public Shared Function DocOption_BOOLEAN(ByVal pGroup As String, ByVal pKey As String) As Boolean
        Dim mValue As String = HTLFileFuncs.ReadINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey)
        If mValue = AppVars.gc_NoValueConfig Then
            Return False
        Else
            Try
                Return CType(mValue, Boolean)
            Catch ex As Exception
                Return False
            End Try
        End If
    End Function
    Public Shared Function DocOption_BOOLEAN(ByVal pGroup As String, ByVal pKey As String, ByVal pDefaultValue As Boolean) As Boolean
        Dim mValue As String = HTLFileFuncs.ReadINIFile(HTLFW.AppBase.AppDataFilePath, pGroup, pKey)
        If mValue = AppVars.gc_NoValueConfig Then
            Return pDefaultValue
        Else
            Try
                Return CType(mValue, Boolean)
            Catch ex As Exception
                Return pDefaultValue
            End Try
        End If
    End Function

    Public Shared Function FindControl(Of ControlType)(ByVal containerControl As Windows.Forms.Control, ByVal controlName As String) As ControlType
        If containerControl Is Nothing Then Return Nothing

        Dim ctrl = containerControl.Controls(controlName)
        If ctrl IsNot Nothing Then
            Dim ctrlObj = Convert.ChangeType(ctrl, GetType(ControlType))
            Return CType(ctrlObj, ControlType)
        End If

        Return Nothing
    End Function

End Class
