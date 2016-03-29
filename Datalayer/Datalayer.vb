Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Reflection 
Imports System.Data.SqlClient
Imports System.Configuration


Public Class Datalayer

#Region "Assignment 2"


#Region "Connection objects"
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
  System.Environment.CurrentDirectory & "\AthleteManagement.mdb"
    Private cmdole As OleDbCommand
    Private conole As OleDbConnection
    Private daole As OleDbDataAdapter


#End Region

#Region "Athletes"
    Public Function GetAthletes() As DataTable
        conole = New OleDbConnection(strConnectionString)
        cmdole = New OleDbCommand()
        cmdole.CommandType = System.Data.CommandType.Text

        cmdole.CommandTimeout = 0
        cmdole.Connection = conole
        cmdole.CommandText = "select * from Athletes"
        Dim dt As New DataTable()
        daole = New OleDbDataAdapter()
        daole.SelectCommand = cmdole
        Try
            conole.Open()
            daole.Fill(dt)
        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            conole.Close()
        End Try
        Return dt

    End Function



    Public Sub AddAthelete(model As AtheleteModel)
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "INSERT INTO  Athletes values (?,?,?,?,?,?,?,?,?)"

        Me.cmdole.CommandType = CommandType.Text

        Me.cmdole.Connection = Me.conole

        Me.cmdole.Parameters.Add("@Athleteid", SqlDbType.UniqueIdentifier).Value = model.Athleteid.ToString.Replace("{", "").Replace("}", "").ToUpper()

        Me.cmdole.Parameters.Add("@AthleteFirstname", SqlDbType.VarChar).Value = model.AthleteFirstname

        Me.cmdole.Parameters.Add("@AthleteSurname", SqlDbType.VarChar).Value = model.AthleteSurname

        Me.cmdole.Parameters.Add("@AthleteAddress", SqlDbType.VarChar).Value = model.AthleteAddress
         
        Me.cmdole.Parameters.Add("@AthleteGender", SqlDbType.VarChar).Value = model.AthleteGender

        Me.cmdole.Parameters.Add("@AthleteDateofBirth", SqlDbType.DateTime).Value = model.AthleteDateofBirth

        Me.cmdole.Parameters.Add("@Datejoined", SqlDbType.DateTime).Value = model.Datejoined
 
        Me.cmdole.Parameters.Add("@amountdue", SqlDbType.Decimal).Value = model.amountdue

        Me.cmdole.Parameters.Add("@membershipnumber", SqlDbType.VarChar).Value = model.membershipnumber
        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()
        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try 
    End Sub
    Public Sub UpdateAthelete(model As AtheleteModel)
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "Update Athletes SET  AthleteFirstname=? ,AthleteSurname=?,AthleteGender=?,AthleteAddress=?,AthleteDateofBirth=?,Datejoined=?,amountdue=?  WHERE Athleteid=?"

        Me.cmdole.CommandType = CommandType.Text


        Me.cmdole.Connection = Me.conole
         

        Me.cmdole.Parameters.Add("@AthleteFirstname", SqlDbType.VarChar).Value = model.AthleteFirstname

        Me.cmdole.Parameters.Add("@AthleteSurname", SqlDbType.VarChar).Value = model.AthleteSurname

        Me.cmdole.Parameters.Add("@AthleteGender", SqlDbType.VarChar).Value = model.AthleteGender

        Me.cmdole.Parameters.Add("@AthleteAddress", SqlDbType.VarChar).Value = model.AthleteAddress

        Me.cmdole.Parameters.Add("@AthleteDateofBirth", SqlDbType.DateTime).Value = model.AthleteDateofBirth

        Me.cmdole.Parameters.Add("@Datejoined", SqlDbType.DateTime).Value = model.Datejoined

        Me.cmdole.Parameters.Add("@amountdue", SqlDbType.Decimal).Value = model.amountdue
          
        Me.cmdole.Parameters.Add("@Athleteid", SqlDbType.VarChar).Value = model.Athleteid.ToString.Replace("{", "").Replace("}", "").ToUpper()


        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()

        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
    End Sub
    Public Sub  DeleteAthlete(model As AtheleteModel) 
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "DELETE from Athletes WHERE Athleteid='" & model.Athleteid.ToString().ToUpper() & "'"

        Me.cmdole.CommandType = CommandType.Text

        Me.cmdole.Connection = Me.conole
         

        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()

        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
    End Sub

#End Region

#Region "Events"
    Public Function GetEvents() As DataTable
        conole = New OleDbConnection(strConnectionString)
        cmdole = New OleDbCommand()
        cmdole.CommandType = System.Data.CommandType.Text

        cmdole.CommandTimeout = 0
        cmdole.Connection = conole
        cmdole.CommandText = "select * from Events"
        Dim dt As New DataTable()
        daole = New OleDbDataAdapter()
        daole.SelectCommand = cmdole
        Try
            conole.Open()
            daole.Fill(dt)
        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            conole.Close()
        End Try
        Return dt

    End Function



    Public Sub AddEvents(model As EventsModel)
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "INSERT INTO  Events values (?,?,?,?,?,?)"

        Me.cmdole.CommandType = CommandType.Text

        Me.cmdole.Connection = Me.conole

        Me.cmdole.Parameters.Add("@Eventid", SqlDbType.UniqueIdentifier).Value = model.Eventid.ToString.Replace("{", "").Replace("}", "").ToUpper()

        Me.cmdole.Parameters.Add("@Eventname", SqlDbType.VarChar).Value = model.Eventname

        Me.cmdole.Parameters.Add("@Eventlocation", SqlDbType.VarChar).Value = model.Eventlocation

        Me.cmdole.Parameters.Add("@EventDistance", SqlDbType.VarChar).Value = model.EventDistance

        Me.cmdole.Parameters.Add("@EventDate", SqlDbType.DateTime).Value = model.EventDate 
          
        Me.cmdole.Parameters.Add("@EventRegistrationfee", SqlDbType.VarChar).Value = model.EventRegistrationfee
        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()
        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
    End Sub
    Public Sub UpdateEvents(model As EventsModel)
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "Update Events SET  Eventname=? ,Eventlocation=?,EventDistance=?,EventDate=?,EventRegistrationfee=?  WHERE Eventid=?"

        Me.cmdole.CommandType = CommandType.Text


        Me.cmdole.Connection = Me.conole

 
        Me.cmdole.Parameters.Add("@Eventname", SqlDbType.VarChar).Value = model.Eventname

        Me.cmdole.Parameters.Add("@Eventlocation", SqlDbType.VarChar).Value = model.Eventlocation

        Me.cmdole.Parameters.Add("@EventDistance", SqlDbType.VarChar).Value = model.EventDistance

        Me.cmdole.Parameters.Add("@EventDate", SqlDbType.DateTime).Value = model.EventDate

        Me.cmdole.Parameters.Add("@EventRegistrationfee", SqlDbType.VarChar).Value = model.EventRegistrationfee 

        Me.cmdole.Parameters.Add("@Eventid", SqlDbType.VarChar).Value = model.Eventid.ToString.Replace("{", "").Replace("}", "").ToUpper()


        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()

        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
    End Sub
    Public Sub DeleteEvents(model As EventsModel)
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "DELETE from Events WHERE Eventid='" & model.Eventid.ToString().ToUpper() & "'"

        Me.cmdole.CommandType = CommandType.Text

        Me.cmdole.Connection = Me.conole


        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()

        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
    End Sub

#End Region

#Region "Athletes Events"
    Public Function GetAthletesEvents() As DataTable
        conole = New OleDbConnection(strConnectionString)
        cmdole = New OleDbCommand()
        cmdole.CommandType = System.Data.CommandType.Text

        cmdole.CommandTimeout = 0
        cmdole.Connection = conole
        cmdole.CommandText = "select * from AtheleteEvents"
        Dim dt As New DataTable()
        daole = New OleDbDataAdapter()
        daole.SelectCommand = cmdole
        Try
            conole.Open()
            daole.Fill(dt)
        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            conole.Close()
        End Try
        Return dt

    End Function



    Public Sub AddAtheleteEvents(model As AtheleteEventsModel)
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "INSERT INTO  AtheleteEvents values (?,?,?,?)"

        Me.cmdole.CommandType = CommandType.Text

        Me.cmdole.Connection = Me.conole

        Me.cmdole.Parameters.Add("@Eventid", SqlDbType.VarChar).Value = model.Eventid.ToString.Replace("{", "").Replace("}", "").ToUpper()
        Me.cmdole.Parameters.Add("@Membershipnumber", SqlDbType.VarChar).Value = model.Membershipnumber
        Me.cmdole.Parameters.Add("@EventDate", SqlDbType.VarChar).Value = model.EventDate.ToString() 
        Me.cmdole.Parameters.Add("@EventResults", SqlDbType.VarChar).Value = model.EventResults



        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()
        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
    End Sub
    Public Sub UpdateAtheleteEvents(model As AtheleteEventsModel)
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "Update AtheleteEvents SET  EventDate=? ,EventResults=?  WHERE Athleteid=?"

        Me.cmdole.CommandType = CommandType.Text 
        Me.cmdole.Connection = Me.conole
  
        Me.cmdole.Parameters.Add("@Eventid", SqlDbType.VarChar).Value = model.Eventid.ToString.Replace("{", "").Replace("}", "").ToUpper()
        Me.cmdole.Parameters.Add("@Membershipnumber", SqlDbType.VarChar).Value = model.Membershipnumber
        Me.cmdole.Parameters.Add("@EventDate", SqlDbType.VarChar).Value = model.EventDate.ToString()
        Me.cmdole.Parameters.Add("@EventResults", SqlDbType.VarChar).Value = model.EventResults

         
        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()

        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
    End Sub
    Public Sub DeleteAthleteEvents(model As AtheleteEventsModel)
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "DELETE from AtheleteEvents WHERE Eventid='" & model.Eventid.ToString.Replace("{", "").Replace("}", "").ToUpper() & "' And Membershipnumber='" & model.Membershipnumber & "'"


        Me.cmdole.CommandType = CommandType.Text

        Me.cmdole.Connection = Me.conole


        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()

        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
    End Sub

#End Region
#End Region

End Class
