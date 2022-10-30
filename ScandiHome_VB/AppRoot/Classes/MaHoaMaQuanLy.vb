Public Class MaHoaMaQuanLy
    Public Shared Function Compare(ByVal pMaQuanLy As String, ByVal pValue As String) As Boolean
        Return String.Compare(GetEncrypted(pMaQuanLy), pValue, False) = 0
    End Function

    Public Shared Function GetEncrypted(ByVal pValue) As String
        If HTLFW.HTLLib.HTLComFuncs.Nz(pValue, "") = "" Then
            Return ""
        Else
            'Dim mTam As String = HTLFW.HTLLib.HTLSecurityFuncs.AppF_EncryptPWDEx(pValue, HTLFW.AppBase.AppPublicKey)
            'Return HTLFW.HTLLib.HTLStringFuncs.ConvertStringToString64Bit(mTam)
            Return HTLFW.HTLLib.HTLStringFuncs.ConvertStringToString64Bit(pValue)
        End If
    End Function

    Public Shared Function GetDeEncrypted(ByVal pValue) As String
        If HTLFW.HTLLib.HTLComFuncs.Nz(pValue, "") = "" Then
            Return ""
        Else
            'Dim mTam As String = HTLFW.HTLLib.HTLStringFuncs.ConvertString64BitToString(pValue)
            'Return HTLFW.HTLLib.HTLSecurityFuncs.AppF_DeEncryptPWDEx(mTam, HTLFW.AppBase.AppPublicKey)
            Return HTLFW.HTLLib.HTLStringFuncs.ConvertString64BitToString(pValue)
        End If
    End Function
End Class
