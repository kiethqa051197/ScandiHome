Imports DevExpress.XtraGrid.Views.Base
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Public Module FilteredDataSourceHelper

    <System.Runtime.CompilerServices.Extension()>
    Public Function GetFilteredDataSource(ByVal view As ColumnView) As Object
        If view Is Nothing Then
            Return Nothing
        End If
        If TypeOf view.DataSource Is DataView Then
            Return GetFilteredDataView(view)
        End If
        If TypeOf view.DataSource Is IBindingList Then
            Return GetFilteredBindingList(view)
        End If
        Return Nothing
    End Function

    <System.Runtime.CompilerServices.Extension()>
    Public Function GetFilteredDataTable(ByVal view As ColumnView) As DataTable
        If view Is Nothing Then
            Return Nothing
        End If
        If TypeOf view.DataSource Is DataView Then
            Return GetFilteredDataView(view).ToTable
        End If
        Return Nothing
    End Function

    Private Function GetFilteredDataView(ByVal view As ColumnView) As DataView
        If view Is Nothing Then
            Return Nothing
        End If
        If view.ActiveFilter Is Nothing OrElse (Not view.ActiveFilterEnabled) OrElse view.ActiveFilter.Expression = "" Then
            Return TryCast(view.DataSource, DataView)
        End If

        Dim table As DataTable = (CType(view.DataSource, DataView)).Table
        Dim filteredDataView As New DataView(table)
        filteredDataView.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(view.ActiveFilterCriteria)
        Return filteredDataView
    End Function

    Private Function GetFilteredBindingList(ByVal view As ColumnView) As IList
        If view Is Nothing Then
            Return Nothing
        End If
        Dim list As IList = TryCast(view.DataSource, IList)
        If view.ActiveFilter Is Nothing OrElse (Not view.ActiveFilterEnabled) OrElse view.ActiveFilter.Expression = "" OrElse list.Count = 0 Then
            Return list
        End If
        Dim result As New BindingList(Of Object)()
        For i As Integer = 0 To view.RowCount - 1
            result.Add(view.GetRow(i))
        Next i
        Return result
    End Function

End Module

<System.ComponentModel.DesignerCategory("")>
Public Class FilteredDataSourceHelperComponent
    Inherits Component
    ' Fields...
    Private _FilteredDataSource As BindingSource
    Private _View As GridView

    Public Property View() As GridView
        Get
            Return _View
        End Get
        Set(ByVal value As GridView)
            Dim prevView As GridView = _View
            _View = value
            OnViewChanged(prevView, _View)
        End Set
    End Property

    Public Property FilteredDataSource() As BindingSource
        Get
            Return _FilteredDataSource
        End Get
        Set(ByVal value As BindingSource)
            _FilteredDataSource = value
        End Set
    End Property

    Private Sub OnViewChanged(ByVal oldValue As GridView, ByVal newValue As GridView)
        UnSubscribeEvents(oldValue)
        SubscribeEvents(newValue)
        UpdateFilteredSource()
    End Sub
    Private Sub UnSubscribeEvents(ByVal gridView As GridView)
        If gridView Is Nothing Then
            Return
        End If
        RemoveHandler gridView.DataSourceChanged, AddressOf gridView_DataSourceChanged
        RemoveHandler gridView.ColumnFilterChanged, AddressOf gridView_ColumnFilterChanged
    End Sub
    Private Sub SubscribeEvents(ByVal gridView As GridView)
        If gridView Is Nothing Then
            Return
        End If
        AddHandler gridView.DataSourceChanged, AddressOf gridView_DataSourceChanged
        AddHandler gridView.ColumnFilterChanged, AddressOf gridView_ColumnFilterChanged
    End Sub

    Private Sub gridView_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs)
        UpdateFilteredSource()
    End Sub

    Private Sub gridView_DataSourceChanged(ByVal sender As Object, ByVal e As EventArgs)
        UpdateFilteredSource()
    End Sub

    Private Sub UpdateFilteredSource()
        If _View Is Nothing OrElse _FilteredDataSource Is Nothing Then
            Return
        End If
        _FilteredDataSource.DataSource = _View.GetFilteredDataSource()
    End Sub
End Class