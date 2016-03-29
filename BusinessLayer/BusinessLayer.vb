Imports Datalayer

Public Class BusinessLayer
   
 

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

    Public Sub UpdateEvents(model As EventsModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.UpdateEvents(model)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub AddEvents(model As EventsModel)

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
    Public Sub DeleteEvents(model As EventsModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.DeleteEvents(model)
        Catch ex As Exception

        End Try


    End Sub

#End Region



#Region "Oledb AthleteEvents"

    Public Sub UpdateAtheleteEvents(model As AtheleteEventsModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.UpdateAtheleteEvents(model)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub AddAtheleteEvents(model As AtheleteEventsModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.AddAtheleteEvents(model)
        Catch ex As Exception

        End Try
    End Sub
    Public Function GetAthletesEvents() As DataTable

        Dim obj As New Datalayer.Datalayer()
        Try
            Return obj.GetAthletesEvents()
        Catch ex As Exception

        End Try
    End Function
    Public Sub DeleteAthleteEvents(model As AtheleteEventsModel)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.DeleteAthleteEvents(model)
        Catch ex As Exception

        End Try


    End Sub

#End Region

End Class
