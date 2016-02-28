Imports System.IO
Imports System.Reflection

Public Class AtheleteEvents

    Dim table As DataTable
    Dim IsUpdate As Integer
    Dim Selected_event_id As String
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        'table = New DataTable() 
        ' Create four typed columns in the DataTable.

        If (table Is Nothing) Then
            table = New DataTable()
            If (table.Columns.Count = 0) Then
                table.Columns.Add("Eventid", GetType(String))
                table.Columns.Add("Membershipnumber", GetType(String))
                table.Columns.Add("EventDate", GetType(DateTime))
                table.Columns.Add("EventResults", GetType(String))

            End If

        Else
            If (table.Columns.Count = 0) Then
                table.Columns.Add("Eventid", GetType(String))
                table.Columns.Add("Membershipnumber", GetType(String))
                table.Columns.Add("EventDate", GetType(DateTime))
                table.Columns.Add("EventResults", GetType(String))

            End If

        End If
        ' Add five rows with those columns filled in the DataTable. 
        Dim business As New BusinessLayer.BusinessLayer()


        'Add the newly insert record into a Table 
        table.Rows.Add(ddlEventName.SelectedValue.ToString(), ddlmembershipnumber.Text.ToString(), Convert.ToDateTime(dpdateofevent.Text.Replace(",", " ")), txteventdistance.Text.Replace(",", " "))

        Try
            Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\AtheleteEvents.csv")

            business.Convert_DataTable_To_CSV(table, Paths, ",")
            'Get latest data 
            GetData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            business = Nothing
        End Try

    End Sub
    Private Sub GetData()

        Dim business As New BusinessLayer.BusinessLayer()
        Try

            Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\AtheleteEvents.csv")
            table = business.ConvertCsvToDatatableExtended(Paths)
            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            business = Nothing

        End Try

    End Sub

    Private Sub GetEvents()

        Dim business As New BusinessLayer.BusinessLayer()
        Try

            Dim Dt As New DataTable()
       

            Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\Events.csv") 
            Dt = business.ConvertCsvToDatatableExtended(Paths)
            ddlEventName.DataSource = Dt
            ddlEventName.ValueMember = "Eventid"
            ddlEventName.DisplayMember = "Eventname"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            business = Nothing

        End Try

    End Sub


    Private Sub GetAthletes()

        Dim business As New BusinessLayer.BusinessLayer()
        Try

            Dim Dt As New DataTable()

            Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\Athletes.csv")
            Dt = business.ConvertCsvToDatatableExtended(Paths)
            'Dt = business.ConvertCsvToDatatableExtended("C:\unisa\ICT3611\ASSIGNMENT 1\Assignment1\Datalayer\Flatfiles\Athletes.csv")
            ddlmembershipnumber.DataSource = Dt
            ddlmembershipnumber.ValueMember = "Athleteid"
            ddlmembershipnumber.DisplayMember = "Membershipnumber"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            business = Nothing

        End Try

    End Sub



    Private Sub Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        GetEvents()
        GetAthletes()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        IsUpdate = 1

        If (Selected_event_id <> String.Empty) Then

            For Each row As DataRow In table.Rows
                If (Selected_event_id.ToString() = row.Item("Eventid").ToString()) Then
                    table.Rows.Remove(row)
                    table.Rows.Add(Selected_event_id, ddlmembershipnumber.SelectedValue.Text.Replace(",", " "), Convert.ToDateTime(dpdateofevent.Text.Replace(",", " ")), txteventdistance.Text.Replace(",", " "))
                    table.AcceptChanges()
                    Dim business As New BusinessLayer.BusinessLayer()
                    Try

                        Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\AthleteEvents.csv")
                        business.Convert_DataTable_To_CSV(table, Paths, ",")
                        'business.Convert_DataTable_To_CSV(table, "C:\unisa\ICT3611\ASSIGNMENT 1\Assignment1\Datalayer\Flatfiles\AtheleteEvents.csv", ",")
                        GetData()
                        Selected_event_id = String.Empty

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        business = Nothing
                        IsUpdate = 0
                    End Try

                    MessageBox.Show("Successfully Updated")
                    Exit Sub

                End If
            Next
        Else
            MessageBox.Show("Please select the Record on the Grid")
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        'dt.Rows(rowId)("id").ToString()
        For Each row As DataRow In table.Rows
            If (Selected_event_id.ToString() = row.Item("Eventid").ToString()) Then
                table.Rows.Remove(row)
                table.AcceptChanges()
                Dim business As New BusinessLayer.BusinessLayer() 
                Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\AtheleteEvents.csv")

                business.Convert_DataTable_To_CSV(table, Paths, ",")
                'business.Convert_DataTable_To_CSV(table, "C:\unisa\ICT3611\ASSIGNMENT 1\Assignment1\Datalayer\Flatfiles\AtheleteEvents.csv", ",")
                business = Nothing
                GetData()
                Selected_event_id = String.Empty

                MessageBox.Show("Successfully Deleted")
                Exit Sub

            End If
        Next

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If (IsUpdate <> 1) Then

            Dim dgv As DataGridView = TryCast(sender, DataGridView)
            If dgv IsNot Nothing AndAlso dgv.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = dgv.SelectedRows(0)
                If row IsNot Nothing Then
                    'txteventdistance.Text = row.Cells()("EventDistance").Value.ToString()
                    'dpdateofevent.Text = row.Cells()("EventDate").Value.ToString()
                    'Selected_event_id = row.Cells()("Eventid").Value.ToString()
                End If
            End If

        End If

    End Sub
End Class