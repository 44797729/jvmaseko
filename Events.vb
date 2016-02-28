Imports System.IO
Imports System.Reflection

Public Class Events

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
                table.Columns.Add("Eventname", GetType(String))
                table.Columns.Add("Eventlocation", GetType(String))
                table.Columns.Add("EventDistance", GetType(String))
                table.Columns.Add("EventDate", GetType(DateTime))
                table.Columns.Add("EventRegistrationfee", GetType(String))

            End If

        Else
            If (table.Columns.Count = 0) Then
                table.Columns.Add("Eventid", GetType(String))
                table.Columns.Add("Eventname", GetType(String))
                table.Columns.Add("Eventlocation", GetType(String))
                table.Columns.Add("EventDistance", GetType(String))
                table.Columns.Add("EventDate", GetType(DateTime))
                table.Columns.Add("EventRegistrationfee", GetType(String))

            End If

        End If
        ' Add five rows with those columns filled in the DataTable.


        Dim business As New BusinessLayer.BusinessLayer()

        Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\Events.csv")


        'Add the newly insert record into a Table 
        table.Rows.Add(System.Guid.NewGuid.ToString(), txteventname.Text.Replace(",", " "), txteventlocation.Text.Replace(",", " "), txteventdistance.Text.Replace(",", " "), Convert.ToDateTime(dpdateofevent.Text.Replace(",", " ")), txtregistrationfee.Text.Replace(",", " "))

        'Get the Data in the file so that it wont be overriten 

        Try
            business.Convert_DataTable_To_CSV(table, Paths, ",")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

            business = Nothing

        End Try

        'Get latest data 
        GetData()
    End Sub
    Private Sub GetData()

        Dim business As New BusinessLayer.BusinessLayer()
        Try
            Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\Events.csv")

            table = business.ConvertCsvToDatatableExtended(Paths)

            DataGridView1.DataSource = table

        Catch ex As Exception

        End Try

    End Sub


    Private Sub Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        IsUpdate = 1

        If (Selected_event_id <> String.Empty) Then

            For Each row As DataRow In table.Rows
                If (Selected_event_id.ToString() = row.Item("Eventid").ToString()) Then
                    table.Rows.Remove(row)
                    table.Rows.Add(Selected_event_id, txteventname.Text.Replace(",", " "), txteventlocation.Text.Replace(",", " "), txteventdistance.Text.Replace(",", " "), Convert.ToDateTime(dpdateofevent.Text.Replace(",", " ")), txtregistrationfee.Text.Replace(",", " "))

                    table.AcceptChanges()

                    Dim business As New BusinessLayer.BusinessLayer()
                    Try
                        Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\Events.csv")

                        business.Convert_DataTable_To_CSV(table, Paths, ",")
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
                Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\Events.csv")

                business.Convert_DataTable_To_CSV(table, Paths, ",")
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
                    txteventname.Text = row.Cells()("Eventname").Value.ToString()
                    txteventlocation.Text = row.Cells()("Eventlocation").Value.ToString()
                    txteventdistance.Text = row.Cells()("EventDistance").Value.ToString()
                    dpdateofevent.Text = row.Cells()("EventDate").Value.ToString()
                    txtregistrationfee.Text = row.Cells()("EventRegistrationfee").Value.ToString()
                    Selected_event_id = row.Cells()("Eventid").Value.ToString()
                End If
            End If

        End If

    End Sub
End Class