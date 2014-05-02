Imports Telerik.Windows.Persistence.Storage
Imports Telerik.Windows.Persistence
Imports System.IO

Public Class PersistenceTest

    Private stream As Stream

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Try
            Using objReader As New System.IO.StreamReader("U:\Layout.txt")
                If objReader IsNot Nothing Then
                    stream = objReader.BaseStream
                    stream.Position = 0L
                    Dim manager As New PersistenceManager()
                    manager.Load(dashboardDocking1, stream)
                End If
            End Using

            'Dim objReader As New System.IO.StreamReader("U:\Layout.txt")
            'If objReader IsNot Nothing Then
            '    stream = objReader.BaseStream
            '    stream.Position = 0L
            '    Dim manager As New PersistenceManager()
            '    manager.Load(dashboardDocking1, stream)
            'End If

        Catch ex As Exception

        End Try
        

    End Sub


    Private Sub PersistenceTest_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles Me.Closing
        Dim manager As New PersistenceManager()
        stream = manager.Save(dashboardDocking1)

        Using filestream = File.Create("U:\Layout.txt")
            stream.CopyTo(filestream)
        End Using

    End Sub
End Class
