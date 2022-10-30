Public Class ResponseItemSelectorClicked

    Public Enum eActionType
        None = 0
        ItemCodeSelected = 1
        BarCodeInputed = 2
        ManagerCodeInputed = 3
    End Enum

    Private _ItemCode As String = Nothing
    Public Property ItemCode() As String
        Get
            Return _ItemCode
        End Get
        Set(ByVal value As String)
            _ItemCode = value
        End Set
    End Property

    Private _ItemName As String = Nothing
    Public Property ItemName() As String
        Get
            Return _ItemName
        End Get
        Set(ByVal value As String)
            _ItemName = value
        End Set
    End Property

    Private _ItemDescription As String = Nothing
    Public Property ItemDescription() As String
        Get
            Return _ItemDescription
        End Get
        Set(ByVal value As String)
            _ItemDescription = value
        End Set
    End Property

    Private _ItemUnit As String = Nothing
    Public Property ItemUnit() As String
        Get
            Return _ItemUnit
        End Get
        Set(ByVal value As String)
            _ItemUnit = value
        End Set
    End Property

    Private _ItemNetPrice As Double = 0.0
    Public Property ItemNetPrice() As Double
        Get
            Return _ItemNetPrice
        End Get
        Set(ByVal value As Double)
            _ItemNetPrice = value
        End Set
    End Property

    Private _ItemPricePay As Double = 0.0
    Public Property ItemPricePay() As Double
        Get
            Return _ItemPricePay
        End Get
        Set(ByVal value As Double)
            _ItemPricePay = value
        End Set
    End Property

    Private _ItemDiscountPerc As Double = 0.0
    Public Property ItemDiscountPerc() As Double
        Get
            Return _ItemDiscountPerc
        End Get
        Set(ByVal value As Double)
            _ItemDiscountPerc = value
        End Set
    End Property

    Private _ItemDiscount As Double = 0.0
    Public Property ItemDiscount() As Double
        Get
            Return _ItemDiscount
        End Get
        Set(ByVal value As Double)
            _ItemDiscount = value
        End Set
    End Property

    Private _ItemVAT As Double = 0.0
    Public Property ItemVAT() As Double
        Get
            Return _ItemVAT
        End Get
        Set(ByVal value As Double)
            _ItemVAT = value
        End Set
    End Property

    Private _ItemVATPerc As Double = 0.0
    Public Property ItemVATPerc() As Double
        Get
            Return _ItemVATPerc
        End Get
        Set(ByVal value As Double)
            _ItemVATPerc = value
        End Set
    End Property

    Private _ItemQuantity As Double = 1.0
    Public Property ItemQuantity() As Double
        Get
            Return _ItemQuantity
        End Get
        Set(ByVal value As Double)
            _ItemQuantity = value
        End Set
    End Property

    Private _ActionType As eActionType = eActionType.ItemCodeSelected
    Public Property ActionType() As eActionType
        Get
            Return _ActionType
        End Get
        Set(ByVal value As eActionType)
            _ActionType = value
        End Set
    End Property

    Public Params() As Object

    Public Function GetParam(Of T)(ByVal pIndex As Integer) As T
        Dim mParam As Object
        Try
            mParam = Params(pIndex)
        Catch ex As Exception
            mParam = Nothing
        End Try
        If Not mParam Is Nothing Then
            Return CType(mParam, T)
        Else
            Return Nothing
        End If
    End Function

    Public Sub ResetParams()
        For Each mParam In Params
            mParam = Nothing
        Next
    End Sub

    Public Sub New()

    End Sub

    'Public Sub New(ByVal pItemCode As String)
    '    _ItemCode=pItemCode
    'End Sub

    'Public Sub New(ByVal pItemCode As String, ByVal pItemName As String)
    '    _ItemCode = pItemCode
    '    _ItemName = pItemName
    'End Sub

    'Public Sub New(ByVal pItemCode As String, ByVal pItemQuantity As Double)
    '    _ItemCode = pItemCode
    '    _ItemQuantity = pItemQuantity
    'End Sub

    'Public Sub New(ByVal pItemCode As String, ByVal pItemNetPrice As Double, ByVal pItemVAT As Double, ByVal pItemQuantity As Double)
    '    _ItemCode = pItemCode
    '    _ItemNetPrice = pItemNetPrice
    '    _ItemVAT = pItemVAT
    '    _ItemQuantity = pItemQuantity
    'End Sub

    'Public Sub New(ByVal pActionType As eActionType, ByVal pItemCode As String, ByVal pItemNetPrice As Double, ByVal pItemVAT As Double, ByVal pItemQuantity As Double)
    '    _ActionType = pActionType
    '    _ItemCode = pItemCode
    '    _ItemNetPrice = pItemNetPrice
    '    _ItemVAT = pItemVAT
    '    _ItemQuantity = pItemQuantity
    'End Sub

    Public Sub New(ByVal pActionType As eActionType, ByVal pItemCode As String, ByVal pItemName As String, ByVal pItemUnit As String, ByVal pItemNetPrice As Double, ByVal pItemPricePay As Double, ByVal pItemDiscountPerc As Double, ByVal pItemDiscount As Double, ByVal pItemVATPerc As Double, ByVal pItemVAT As Double, ByVal pItemQuantity As Double)
        _ActionType = pActionType
        _ItemCode = pItemCode
        _ItemName = pItemName
        _ItemUnit = pItemUnit
        _ItemNetPrice = pItemNetPrice
        _ItemPricePay = pItemPricePay
        _ItemDiscountPerc = pItemDiscountPerc
        _ItemDiscount = pItemDiscount
        _ItemVATPerc = pItemVATPerc
        _ItemVAT = pItemVAT
        _ItemQuantity = pItemQuantity
    End Sub

    Public Sub New(ByVal pActionType As eActionType, ByVal pItemCode As String, ByVal pItemName As String, ByVal pItemDescription As String, ByVal pItemUnit As String, ByVal pItemNetPrice As Double, ByVal pItemPricePay As Double, ByVal pItemDiscountPerc As Double, ByVal pItemDiscount As Double, ByVal pItemVATPerc As Double, ByVal pItemVAT As Double, ByVal pItemQuantity As Double)
        _ActionType = pActionType
        _ItemCode = pItemCode
        _ItemName = pItemName
        _ItemDescription = pItemDescription
        _ItemUnit = pItemUnit
        _ItemNetPrice = pItemNetPrice
        _ItemPricePay = pItemPricePay
        _ItemDiscountPerc = pItemDiscountPerc
        _ItemDiscount = pItemDiscount
        _ItemVATPerc = pItemVATPerc
        _ItemVAT = pItemVAT
        _ItemQuantity = pItemQuantity
    End Sub

End Class
