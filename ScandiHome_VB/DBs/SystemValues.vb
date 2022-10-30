#Region "References"

Imports HTLFW
Imports HTLFW.HTLLib

#End Region

Public Class SystemValues

#Region "SO LE HE THONG"

#Region "SOLEDONGIA"

    Public Shared Function SOLEDONGIA() As Integer
        Return AppBase.AppSystemValues.GetValue(Of Integer)("HETHONG", "SOLEDONGIA")
    End Function
    Public Shared Sub SOLEDONGIA(ByVal pValue As Integer)
        AppBase.AppSystemValues.SetValue("HETHONG", "SOLEDONGIA", pValue)
    End Sub

    Public Shared Function SOLEDONGIA_GridFormatString() As String
        Return GridFormatString(SOLEDONGIA)
    End Function
    Public Shared Function SOLEDONGIA_GridFormatStringAdv() As String
        Return GridFormatStringAdv(SOLEDONGIA)
    End Function
    Public Shared Function SOLEDONGIA_GridFormatStringExcel() As String
        Return GridFormatStringExcel(SOLEDONGIA)
    End Function
    Public Shared Function SOLEDONGIA_ReportNumerFormatString(ByVal pValue As Double) As String
        Return ReportNumerFormatString(pValue, SOLEDONGIA)
    End Function

#End Region

#Region "SOLESOTIEN"

    Public Shared Function SOLESOTIEN() As Integer
        Try
            Return AppBase.AppSystemValues.GetValue(Of Integer)("HETHONG", "SOLESOTIEN")
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Shared Sub SOLESOTIEN(ByVal pValue As Integer)
        Try
            AppBase.AppSystemValues.SetValue("HETHONG", "SOLESOTIEN", pValue)
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Function SOLESOTIEN_GridFormatString() As String
        Return GridFormatString(SOLESOTIEN)
    End Function
    Public Shared Function SOLESOTIEN_GridFormatStringAdv() As String
        Return GridFormatStringAdv(SOLESOTIEN)
    End Function
    Public Shared Function SOLESOTIEN_GridFormatStringExcel() As String
        Return GridFormatStringExcel(SOLESOTIEN)
    End Function
    Public Shared Function SOLESOTIEN_ReportNumerFormatString(ByVal pValue As Double) As String
        Return ReportNumerFormatString(pValue, SOLESOTIEN)
    End Function

#End Region

#Region "SOLETYLE"

    Public Shared Function SOLETYLE() As Integer
        Try
            Return AppBase.AppSystemValues.GetValue(Of Integer)("HETHONG", "SOLETYLE")
        Catch ex As Exception
            Return 2
        End Try
    End Function
    Public Shared Sub SOLETYLE(ByVal pValue As Integer)
        Try
            AppBase.AppSystemValues.SetValue("HETHONG", "SOLETYLE", pValue)
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Function SOLETYLE_GridFormatString() As String
        Return GridFormatString(SOLETYLE)
    End Function
    Public Shared Function SOLETYLE_GridFormatStringAdv() As String
        Return GridFormatStringAdv(SOLETYLE)
    End Function
    Public Shared Function SOLETYLE_GridFormatStringExcel() As String
        Return GridFormatStringExcel(SOLETYLE)
    End Function
    Public Shared Function SOLETYLE_ReportNumerFormatString(ByVal pValue As Double) As String
        Return ReportNumerFormatString(pValue, SOLETYLE)
    End Function

#End Region

#Region "SOLESOLUONG"

    Public Shared Function SOLESOLUONG() As Integer
        Try
            Return AppBase.AppSystemValues.GetValue(Of Integer)("HETHONG", "SOLESOLUONG")
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Shared Sub SOLESOLUONG(ByVal pValue As Integer)
        Try
            AppBase.AppSystemValues.SetValue("HETHONG", "SOLESOLUONG", pValue)
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Function SOLESOLUONG_GridFormatString() As String
        Return GridFormatString(SOLESOLUONG)
    End Function
    Public Shared Function SOLESOLUONG_GridFormatStringAdv() As String
        Return GridFormatStringAdv(SOLESOLUONG)
    End Function
    Public Shared Function SOLESOLUONG_GridFormatStringExcel() As String
        Return GridFormatStringExcel(SOLESOLUONG)
    End Function
    Public Shared Function SOLESOLUONG_ReportNumerFormatString(ByVal pValue As Double) As String
        Return ReportNumerFormatString(pValue, SOLESOLUONG)
    End Function

#End Region

#Region "Khác"

    Public Shared Function GridFormatString(ByVal pSoLe As Integer) As String
        Return "N" & pSoLe.ToString
    End Function
    Public Shared Function GridFormatStringAdv(ByVal pSoLe As Integer) As String
        Return "{0:N" & pSoLe.ToString & "}"
    End Function
    Public Shared Function GridFormatStringExcel(ByVal pSoLe As Integer) As String
        Dim mResult As String
        Select Case System.Threading.Thread.CurrentThread.CurrentCulture.Name
            Case "vi-VN"
                mResult = "#.##0" & If(pSoLe > 0, "," & HTLStringFuncs.FormatFixStringNumber(0, pSoLe), "")
            Case Else
                mResult = "#,##0" & If(pSoLe > 0, "." & HTLStringFuncs.FormatFixStringNumber(0, pSoLe), "")
        End Select
        Return "_(* " & mResult & "_);_(* (" & mResult & ");_(* ""-""??_);_(@_)"
    End Function
    Public Shared Function ReportNumerFormatString(ByVal pValue As Double, ByVal pSoLe As Integer) As String
        Return HTLStringFuncs.FormatNumber(pValue, pSoLe)
    End Function

#End Region

#End Region

End Class
