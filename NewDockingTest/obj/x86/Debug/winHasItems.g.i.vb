﻿#ExternalChecksum("..\..\..\winHasItems.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","1C608269F8088D4F4906B23725DCEC87")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18063
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell
Imports Telerik.Charting
Imports Telerik.Windows.Controls
Imports Telerik.Windows.Controls.Animation
Imports Telerik.Windows.Controls.Carousel
Imports Telerik.Windows.Controls.Charting
Imports Telerik.Windows.Controls.ChartView
Imports Telerik.Windows.Controls.Data.PropertyGrid
Imports Telerik.Windows.Controls.Docking
Imports Telerik.Windows.Controls.DragDrop
Imports Telerik.Windows.Controls.GridView
Imports Telerik.Windows.Controls.Legend
Imports Telerik.Windows.Controls.Primitives
Imports Telerik.Windows.Controls.TransitionEffects
Imports Telerik.Windows.Controls.TreeListView
Imports Telerik.Windows.Controls.TreeView
Imports Telerik.Windows.Data
Imports Telerik.Windows.DragDrop
Imports Telerik.Windows.DragDrop.Behaviors
Imports Telerik.Windows.Input.Touch
Imports Telerik.Windows.Persistence
Imports Telerik.Windows.Persistence.SerializationMetadata
Imports Telerik.Windows.Shapes


'''<summary>
'''winHasItems
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class winHasItems
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\winHasItems.xaml",17)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnAdd As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\winHasItems.xaml",18)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnRemove As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\winHasItems.xaml",22)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents radGridView As Telerik.Windows.Controls.RadGridView
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/NewDockingTest;component/winhasitems.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\winHasItems.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.btnAdd = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\winHasItems.xaml",17)
            AddHandler Me.btnAdd.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnAdd_Click_1)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.btnRemove = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\winHasItems.xaml",18)
            AddHandler Me.btnRemove.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnRemove_Click_1)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 3) Then
            Me.radGridView = CType(target,Telerik.Windows.Controls.RadGridView)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

