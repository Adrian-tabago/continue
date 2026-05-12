Public Class FormSearch
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbSearchCategory.Items.Clear()
        cmbSearchCategory.Items.Add("All")
        cmbSearchCategory.Items.Add("Noise")
        cmbSearchCategory.Items.Add("Dispute")
        cmbSearchCategory.Items.Add("Infrastructure")
        cmbSearchCategory.Items.Add("Others")

        cmbSearchCategory.SelectedIndex = 0

        LoadAllComplaints()
        UpdateComplaintCounts()

    End Sub

    Private Sub LoadAllComplaints()

        dgvPending.Rows.Clear()

        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow Then Continue For

            dgvPending.Rows.Add(
            row.Cells(0).Value,
            row.Cells(1).Value,
            row.Cells(2).Value,
            row.Cells(3).Value,
            row.Cells(4).Value,
            row.Cells(5).Value
        )

        Next

    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        UpdateComplaintCounts()

    End Sub

    Private Sub UpdateComplaintCounts()

        Dim pendingCount As Integer = 0
        Dim resolvedCount As Integer = 0
        Dim underCount As Integer = 0
        Dim rejectedCount As Integer = 0

        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow Then Continue For

            Dim status As String = row.Cells(4).Value.ToString()

            Select Case status

                Case "Pending"
                    pendingCount += 1

                Case "Resolved"
                    resolvedCount += 1

                Case "Under Investigation"
                    underCount += 1

                Case "Rejected"
                    rejectedCount += 1

            End Select

        Next

        Button4.Text = pendingCount.ToString()
        Button6.Text = resolvedCount.ToString()
        Button7.Text = underCount.ToString()
        Button1.Text = rejectedCount.ToString()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim categorySearch As String = cmbSearchCategory.Text.ToLower()

        'CLEAR GRID
        dgvPending.Rows.Clear()

        'LOOP MAIN GRID
        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow Then Continue For

            Dim category As String = row.Cells(3).Value.ToString().ToLower()

            If categorySearch = "all" Then

                dgvPending.Rows.Add(
                    row.Cells(0).Value,
                    row.Cells(1).Value,
                    row.Cells(2).Value,
                    row.Cells(3).Value,
                    row.Cells(4).Value,
                    row.Cells(5).Value
                )

            ElseIf categorySearch = "others" Then


                If category <> "noise" AndAlso
                   category <> "dispute" AndAlso
                   category <> "infrastructure" Then

                    dgvPending.Rows.Add(
                        row.Cells(0).Value,
                        row.Cells(1).Value,
                        row.Cells(2).Value,
                        row.Cells(3).Value,
                        row.Cells(4).Value,
                        row.Cells(5).Value
                    )

                End If

            ElseIf category = categorySearch Then

                dgvPending.Rows.Add(
                    row.Cells(0).Value,
                    row.Cells(1).Value,
                    row.Cells(2).Value,
                    row.Cells(3).Value,
                    row.Cells(4).Value,
                    row.Cells(5).Value
                )

            End If
        Next

    End Sub




    Private Sub btnComplain_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        FormStatus.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()
        Form2.txtBoxAddress.Clear()
        Form2.txtBoxContact.Clear()
        Form2.txtBoxDesc.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'CLEAR GRID
        dgvPending.Rows.Clear()

        'LOOP MAIN GRID
        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow Then Continue For

            'CHECK IF PENDING
            If row.Cells(4).Value.ToString() = "Pending" Then

                dgvPending.Rows.Add(
                row.Cells(0).Value,
                row.Cells(1).Value,
                row.Cells(2).Value,
                row.Cells(3).Value,
                row.Cells(4).Value,
                row.Cells(5).Value
            )

            End If

        Next

        'SORT DATE COLUMN
        dgvPending.Sort(
        dgvPending.Columns(5),
        System.ComponentModel.ListSortDirection.Ascending
    )
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'CLEAR GRID
        dgvPending.Rows.Clear()

        'LOOP MAIN GRID
        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow Then Continue For

            'CHECK IF PENDING
            If row.Cells(4).Value.ToString() = "Resolved" Then

                dgvPending.Rows.Add(
                row.Cells(0).Value,
                row.Cells(1).Value,
                row.Cells(2).Value,
                row.Cells(3).Value,
                row.Cells(4).Value,
                row.Cells(5).Value
            )

            End If

        Next

        'SORT DATE COLUMN
        dgvPending.Sort(
        dgvPending.Columns(5),
        System.ComponentModel.ListSortDirection.Ascending
    )
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        dgvPending.Rows.Clear()

        'LOOP MAIN GRID
        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow Then Continue For

            'CHECK IF PENDING
            If row.Cells(4).Value.ToString() = "Under Investigation" Then

                dgvPending.Rows.Add(
                row.Cells(0).Value,
                row.Cells(1).Value,
                row.Cells(2).Value,
                row.Cells(3).Value,
                row.Cells(4).Value,
                row.Cells(5).Value
            )

            End If

        Next

        'SORT DATE COLUMN
        dgvPending.Sort(
        dgvPending.Columns(5),
        System.ComponentModel.ListSortDirection.Ascending
    )

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        FormStatus.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()
        Form2.txtBoxAddress.Clear()
        Form2.txtBoxContact.Clear()
        Form2.txtBoxDesc.Clear()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        dgvPending.Rows.Clear()

        'LOOP MAIN GRID
        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow Then Continue For

            Dim status As String = row.Cells(4).Value.ToString()

            'SHOW ONLY REJECTED
            If status = "Rejected" Then

                dgvPending.Rows.Add(
                    row.Cells(0).Value,
                    row.Cells(1).Value,
                    row.Cells(2).Value,
                    row.Cells(3).Value,
                    row.Cells(4).Value,
                    row.Cells(5).Value
                )

            End If
        Next

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub
End Class