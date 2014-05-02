Imports Telerik.Pivot.Core
Imports Telerik.Pivot
Imports Telerik.Windows.Controls
Imports Telerik.Windows.Controls.Charting
Imports Telerik.Charting


Public Class PivotWin

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        TryCast(Me.Resources("LocalDataProvider"), LocalDataSourceProvider).ItemsSource = GeneratePivotData()

        'Dim chartViewModel = New PivotChartViewModel()
        'chartViewModel.DataProvider = Me.DataProvider
        'Me.DataContext = chartViewModel

    End Sub

    Private Shared Function GeneratePivotData() As IList(Of Product)
        Dim PivotData As IList(Of Product) = New List(Of Product)() From { _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
     .Price = 10.4, _
     .Quantity = 148 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
     .Price = 10.99, _
     .Quantity = 122 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
     .Price = 11.24, _
     .Quantity = 80 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
     .Price = 11.24, _
     .Quantity = 90 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
     .Price = 11.14, _
     .Quantity = 140 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
     .Price = 10.89, _
     .Quantity = 162 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
     .Price = 10.89, _
     .Quantity = 181 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
     .Price = 10.88, _
     .Quantity = 180 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
     .Price = 11.0, _
     .Quantity = 116 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
     .Price = 10.99, _
     .Quantity = 128 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
     .Price = 10.95, _
     .Quantity = 145 _
    }, _
    New Product() With { _
     .Name = "Pen", _
     .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
     .Price = 10.45, _
     .Quantity = 189 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
     .Price = 5.22, _
     .Quantity = 100 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 85 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
     .Price = 6.04, _
     .Quantity = 80 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
     .Price = 6.28, _
     .Quantity = 72 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
     .Price = 6.12, _
     .Quantity = 99 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
     .Price = 6.59, _
     .Quantity = 40 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
     .Price = 6.29, _
     .Quantity = 68 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 95 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
     .Price = 5.89, _
     .Quantity = 120 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 105 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
     .Price = 5.96, _
     .Quantity = 111 _
    }, _
    New Product() With { _
     .Name = "Pencil", _
     .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
     .Price = 5.99, _
     .Quantity = 108 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 1, 1, 0, 0, 0), _
     .Price = 22.86, _
     .Quantity = 88 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 2, 1, 0, 0, 0), _
     .Price = 23.02, _
     .Quantity = 95 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 3, 1, 0, 0, 0), _
     .Price = 23.22, _
     .Quantity = 102 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 4, 1, 0, 0, 0), _
     .Price = 21.99, _
     .Quantity = 95 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 5, 1, 0, 0, 0), _
     .Price = 22.45, _
     .Quantity = 84 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 6, 1, 0, 0, 0), _
     .Price = 22.56, _
     .Quantity = 96 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 7, 1, 0, 0, 0), _
     .Price = 22.88, _
     .Quantity = 88 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 8, 1, 0, 0, 0), _
     .Price = 22.42, _
     .Quantity = 99 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 9, 1, 0, 0, 0), _
     .Price = 22.56, _
     .Quantity = 111 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 10, 1, 0, 0, 0), _
     .Price = 22.18, _
     .Quantity = 102 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 11, 1, 0, 0, 0), _
     .Price = 22.93, _
     .Quantity = 105 _
    }, _
    New Product() With { _
     .Name = "Notebook", _
     .[Date] = New DateTime(2012, 12, 1, 0, 0, 0), _
     .Price = 22.89, _
     .Quantity = 122 _
    } _
    }

        Return PivotData
    End Function


End Class


Public Class MyPivotFilterList
    Inherits RadPivotFieldList


    Private Sub MyPivotFilterList_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim vm = Me.ViewModel

        Dim x = Me.ViewModel.Fields

        Dim y = Me.ViewModel.Filters


    End Sub

    Public Sub New()


    End Sub
End Class
