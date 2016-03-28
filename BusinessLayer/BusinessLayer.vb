Imports Datalayer

Public Class BusinessLayer


    Public Sub Convert_DataTable_To_CSV(ByVal dtable As DataTable, ByVal pathFilename As String, ByVal sepChar As String)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.Convert_DataTable_To_CSV(dtable, pathFilename, sepChar)

        Catch ex As Exception

        End Try


    End Sub


    Public Function ConvertCsvToDatatable(ByVal dtable As DataTable, ByVal pathFilename As String, ByVal sepChar As String)

        Dim obj As New Datalayer.Datalayer()
        Try
            Return obj.ConvertCsvToDatatable(dtable, pathFilename, sepChar)

        Catch ex As Exception

        End Try
    End Function

    Public Function Getdata()
        Dim obj As New Datalayer.Datalayer()
        Try
            Return obj.Getdata()

        Catch ex As Exception

        End Try
    End Function



    Public Function ConvertCsvToDatatableExtended(Filename As String) As DataTable
        Dim obj As New Datalayer.Datalayer()
        Try
            Return obj.ConvertCsvToDatatableExtended(Filename)

        Catch ex As Exception
        Finally
            obj = Nothing
        End Try
    End Function

#Region "Oledb Athlete"
     
    Public Sub UpdateAthelete(model As AtheleteModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.UpdateAthelete(model)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub AddAthelete(model As AtheleteModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.AddAthelete(model)
        Catch ex As Exception

        End Try
    End Sub
    Public Function GetAthletes() As DataTable

        Dim obj As New Datalayer.Datalayer()
        Try
            Return obj.GetAthletes()
        Catch ex As Exception

        End Try
    End Function 
    Public Sub DeleteAthlete(model As AtheleteModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.DeleteAthlete(model)
        Catch ex As Exception

        End Try


    End Sub

#End Region


#Region "Oledb Events"

    Public Sub UpdateEvents(model As AtheleteModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.UpdateEvents(model)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub AddEvents(model As AtheleteModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.AddEvents(model)
        Catch ex As Exception

        End Try
    End Sub
    Public Function GetEvents() As DataTable

        Dim obj As New Datalayer.Datalayer()
        Try
            Return obj.GetEvents()
        Catch ex As Exception

        End Try
    End Function
    Public Sub DeleteEvents(model As AtheleteModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.DeleteEvents(model)
        Catch ex As Exception

        End Try


    End Sub

#End Region
End Class
