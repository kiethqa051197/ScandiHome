#Region "Refs"

Imports System.IO.Ports
Imports HTLFW
Imports HTLFW.HTLLib
Imports HTLFW.HTLLib.HTLComFuncs
Imports Microsoft.VisualBasic.Strings
Imports System.Threading
Imports System.Math
Imports System.Globalization

#End Region

Public Class HTLLineDisplay

#Region " IDisposable Support "

    Implements IDisposable

    Private disposedValue As Boolean = False

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                Try
                    MyTimer.Stop()
                    MyTimer.Dispose()
                    MyTimer = Nothing
                Catch ex As Exception
                End Try
                Try
                    _RelateForm.Dispose()
                    _RelateForm = Nothing
                Catch ex As Exception
                End Try
            End If
        End If
        Me.disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
        MyBase.Finalize()
    End Sub

#End Region

#Region "Declares"

    Private _Port As Integer = 3
    Private _Baudrate As Rs232.eBaudRate = Rs232.eBaudRate.ebr9600
    Private _Parity As Rs232.DataParity = Rs232.DataParity.Parity_None
    Private _StopBits As Rs232.DataStopBit = Rs232.DataStopBit.StopBit_1
    Private _DataBits As Integer = 8
    Private _RelateForm As System.Windows.Forms.Form

    Private _FullDisplayText As String = ""
    Private _FirstLineText As String = ""
    Private _SecondLineText As String = ""
    Private _FirstLineCurrPos As Integer = 0
    Private _SecondLineCurrPos As Integer = 0
    Private MyTimer As New System.Windows.Forms.Timer
    Public Const TimerInterval As Integer = 50

#End Region

#Region "Properties"

    Public Property RelateForm() As System.Windows.Forms.Form
        Get
            Return _RelateForm
        End Get
        Set(ByVal value As System.Windows.Forms.Form)
            _RelateForm = value
        End Set
    End Property

    Public Property Port() As Integer
        Get
            Return _Port
        End Get
        Set(ByVal value As Integer)
            If IsNumeric(value) OrElse IsNoValue(value) Then
                _Port = 0
            Else
                _Port = Abs(Round(value, 0, MidpointRounding.AwayFromZero))
            End If
        End Set
    End Property

    Public ReadOnly Property PortName() As String
        Get
            Return "COM" & Port.ToString
        End Get
    End Property

    Public Property Baudrate() As Rs232.eBaudRate
        Get
            Return _Baudrate
        End Get
        Set(ByVal value As Rs232.eBaudRate)
            _Baudrate = value
        End Set
    End Property

    Public Property Parity() As Rs232.DataParity
        Get
            Return _Parity
        End Get
        Set(ByVal value As Rs232.DataParity)
            _Parity = value
        End Set
    End Property

    Public Property StopBits() As Rs232.DataStopBit
        Get
            Return _StopBits
        End Get
        Set(ByVal value As Rs232.DataStopBit)
            _StopBits = value
        End Set
    End Property

    Public Property DataBits() As Integer
        Get
            Return _DataBits
        End Get
        Set(ByVal value As Integer)
            _DataBits = value
        End Set
    End Property

#End Region

#Region "Constructors"

    Public Sub New(ByVal pRelateForm As System.Windows.Forms.Form)
        _RelateForm = pRelateForm
        AddHandler MyTimer.Tick, AddressOf Timer_Tick
    End Sub

    Public Sub New(ByVal pRelateForm As System.Windows.Forms.Form, ByVal pPort As Integer)
        _RelateForm = pRelateForm
        _Port = Port
        AddHandler MyTimer.Tick, AddressOf Timer_Tick
    End Sub

    Public Sub New(ByVal pRelateForm As System.Windows.Forms.Form, ByVal pPort As Integer, ByVal pBaudrate As Rs232.eBaudRate)
        _RelateForm = pRelateForm
        _Port = pPort
        _Baudrate = pBaudrate
        AddHandler MyTimer.Tick, AddressOf Timer_Tick
    End Sub

    Public Sub New(ByVal pRelateForm As System.Windows.Forms.Form, ByVal pPort As Integer, ByVal pBaudrate As Rs232.eBaudRate, ByVal pParity As Rs232.DataParity)
        _RelateForm = pRelateForm
        _Port = pPort
        _Baudrate = pBaudrate
        _Parity = pParity
        AddHandler MyTimer.Tick, AddressOf Timer_Tick
    End Sub

    Public Sub New(ByVal pRelateForm As System.Windows.Forms.Form, ByVal pPort As Integer, ByVal pBaudrate As Rs232.eBaudRate, ByVal pParity As Rs232.DataParity, ByVal pDataBits As Integer)
        _RelateForm = pRelateForm
        _Port = pPort
        _Baudrate = pBaudrate
        _Parity = pParity
        _DataBits = pDataBits
        AddHandler MyTimer.Tick, AddressOf Timer_Tick
    End Sub

    Public Sub New(ByVal pRelateForm As System.Windows.Forms.Form, ByVal pPort As Integer, ByVal pBaudrate As Rs232.eBaudRate, ByVal pParity As Rs232.DataParity, ByVal pDataBits As Integer, ByVal pStopBits As Rs232.DataStopBit)
        _RelateForm = pRelateForm
        _Port = pPort
        _Baudrate = pBaudrate
        _Parity = pParity
        _DataBits = pDataBits
        _StopBits = pStopBits
        AddHandler MyTimer.Tick, AddressOf Timer_Tick
    End Sub

#End Region

#Region "Functions"

    Public Function OpenMachinePort() As System.IO.Ports.SerialPort
        Dim mPort As New System.IO.Ports.SerialPort
        Try
            With mPort
                .PortName = PortName
                .BaudRate = Baudrate
                .Parity = Parity
                .DataBits = DataBits
                .StopBits = StopBits
                .RtsEnable = True
                .DtrEnable = True
            End With
            If mPort.IsOpen = False Then mPort.Open()
            Return mPort
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function FormatText(ByVal pValue As String, ByVal pLen As Long, ByVal pAfter As Boolean) As String
        If Len(pValue) > pLen Then
            If pAfter Then
                FormatText = HTLStringFuncs.Right(pValue, pLen)
            Else
                FormatText = HTLStringFuncs.Left(pValue, pLen)
            End If
        Else
            If pAfter Then
                FormatText = Space(pLen - Len(pValue)) & pValue
            Else
                FormatText = pValue & Space(pLen - Len(pValue))
            End If
        End If
    End Function

    Public Function FormatCombineText(ByVal pDescription As String, ByVal pValue As Double) As String
        Dim Result As String = pDescription + HTLStringFuncs.FormatNumber(HTLComFuncs.Nz(pValue, 0.0), 0, ",")
        If Result.Length < 20 Then
            Dim _LenSpace = 20 - Result.Length
            If _LenSpace > 0 Then
                Result = pDescription + Space(_LenSpace) + HTLStringFuncs.FormatNumber(HTLComFuncs.Nz(pValue, 0.0), 0, ",")
            End If
        End If
        Return Result
    End Function

#End Region

#Region "Subs"

    Public Sub StopRolling()
        MyTimer.Stop()
    End Sub

    Public Sub StartRolling()
        MyTimer.Interval = TimerInterval
        MyTimer.Start()
    End Sub

    Public Sub ResetText()
        StopRolling()
        _FullDisplayText = Space(40)
        RunThreadShowText()
    End Sub

    Private Sub RunThreadShowText()
        Dim mThread As New System.Threading.Thread(AddressOf ShowText)
        mThread.Start()
        While mThread.IsAlive
            System.Threading.Thread.Sleep(1)
            DoEvents()
        End While
    End Sub

    Public Sub ShowText(ByVal pValue As String)
        StopRolling()
        '_FullDisplayText = FormatText(HTLStringFuncs.ConvertFont(pValue, eFontType.Uni_1, eFontType.ASCII), 40, False)
        _FullDisplayText = FormatText(pValue, 40, False)
        RunThreadShowText()
        StartRolling()
    End Sub

    Public Sub ShowText(ByVal pFirstLineValue As String, ByVal pSecondLineValue As String)
        StopRolling()
        _FirstLineText = ConvertUnicodeStringToAsscii(pFirstLineValue)
        _SecondLineText = pSecondLineValue
        _FullDisplayText = FormatText(_FirstLineText, 20, False) & FormatText(_SecondLineText, 20, True)
        RunThreadShowText()
        If pFirstLineValue.Length > 20 Then
            _FirstLineCurrPos = 20
        End If
        StartRolling()
    End Sub

    Public Sub ShowText(ByVal pFirstLineValue As String, ByVal pSecondLineValue As Double)
        StopRolling()
        _FirstLineText = ConvertUnicodeStringToAsscii(pFirstLineValue)
        _SecondLineText = pSecondLineValue
        _FullDisplayText = FormatText(_FirstLineText, 20, False) & FormatText(HTLStringFuncs.FormatNumber(HTLComFuncs.Nz(pSecondLineValue, 0.0), 0, "."), 20, True)
        RunThreadShowText()
        If pFirstLineValue.Length > 20 Then
            _FirstLineCurrPos = 20
        End If
        StartRolling()
    End Sub

    Public Sub ShowText(ByVal pFirstLineValue As String, ByVal pSecondLineValue As String, ByVal pSecondLineAllignLeft As Boolean)
        StopRolling()
        _FirstLineText = ConvertUnicodeStringToAsscii(pFirstLineValue)
        _SecondLineText = pSecondLineValue
        _FullDisplayText = FormatText(_FirstLineText, 20, False) & FormatText(ConvertUnicodeStringToAsscii(_SecondLineText), 20, If(pSecondLineAllignLeft, False, True))
        RunThreadShowText()
        If pFirstLineValue.Length > 20 Then
            _FirstLineCurrPos = 20
        End If
        StartRolling()
    End Sub

    Private Sub ShowText()
        Dim mPort = OpenMachinePort()
        If Not mPort Is Nothing Then
            'System.Threading.Thread.Sleep(1)
            'HTLComFuncs.DoEvents()
            For i As Integer = 0 To 39
                Try
                    mPort.Write(_FullDisplayText(i).ToString)
                    mPort.DiscardInBuffer()
                Catch ex As Exception
                End Try
                System.Threading.Thread.Sleep(2)
                mPort.DiscardInBuffer()
            Next
            'System.Threading.Thread.Sleep(1)
            'HTLComFuncs.DoEvents()


            'mPort.DiscardInBuffer()
            'mPort.Write(_FullDisplayText)
            mPort.DiscardInBuffer()
            mPort.DiscardOutBuffer()
            mPort.Close()
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
        MyTimer.Stop()
        If _FirstLineText.Length > 20 Then
            Dim mFirstText = Space(20) & _FirstLineText & Space(20)
            If _FirstLineCurrPos > mFirstText.Length - 20 Then
                _FirstLineCurrPos = 0
            End If
            Dim mFirstShowText As String = mFirstText.Substring(_FirstLineCurrPos, 20)
            _FullDisplayText = mFirstShowText & FormatText(_SecondLineText, 20, True)
            _FirstLineCurrPos = _FirstLineCurrPos + 1
            RunThreadShowText()
            MyTimer.Start()
        Else
            MyTimer.Stop()
            RunThreadShowText()
        End If
        DoEvents()
    End Sub

#End Region

    Public Function ConvertUnicodeStringToAsscii(ByVal mStr As String)
        Dim stFormD As String = mStr.Normalize(System.Text.NormalizationForm.FormD)
        Dim sb As New System.Text.StringBuilder
        For ich As Integer = 0 To stFormD.Length - 1
            Dim uc As UnicodeCategory = CharUnicodeInfo.GetUnicodeCategory(stFormD(ich))
            If uc = UnicodeCategory.NonSpacingMark = False Then
                sb.Append(stFormD(ich))
            End If
        Next
        Return sb.ToString().Normalize(System.Text.NormalizationForm.FormD)
        sb.Release()
    End Function

End Class
