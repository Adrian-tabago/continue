Public Class FormSearch
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbSearchCategory.Items.Clear()
        cmbSearchCategory.Items.Add("All")
        cmbSearchCategory.Items.Add("Noise")
        cmbSearchCategory.Items.Add("Dispute")
        cmbSearchCategory.Items.Add("Infrastructure")
        cmbSearchCategory.Items.Add("Others")

        cmbSearchCategory.SelectedIndex = 0

    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Button4.Text = Form2.Pendings
        Button6.Text = FormStatus.resolve
        Button7.Text = FormStatus.under

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim nameSearch As String = txtSearchName.Text.ToLower()
        Dim categorySearch As String = cmbSearchCategory.Text.ToLower()

        dgvSearchResults.Rows.Clear()

        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow = False Then

                Dim name As String = row.Cells(0).Value.ToString().ToLower()
                Dim category As String = row.Cells(3).Value.ToString().ToLower()

                'DEFAULT: assume match
                Dim isMatch As Boolean = True

                'CHECK NAME
                If nameSearch <> "" Then
                    If name.Contains(nameSearch) = False Then
                        isMatch = False
                    End If
                End If

                'CHECK CATEGORY
                If categorySearch <> "all" And categorySearch <> "" Then
                    If category <> categorySearch Then
                        isMatch = False
                    End If
                End If

                'ADD TO GRID IF MATCHED
                If isMatch = True Then
                    dgvSearchResults.Rows.Add(
                    row.Cells(0).Value,
                    row.Cells(1).Value,
                    row.Cells(2).Value,
                    row.Cells(3).Value,
                    row.Cells(4).Value,
                    row.Cells(5).Value
                )
                End If

            End If

        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click


        txtSearchName.Clear()
        cmbSearchCategory.SelectedIndex = 0
        dgvSearchResults.Rows.Clear()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearchName.TextChanged

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)

        FormStatus.Show()
        Me.Hide()

    End Sub

    Private Sub cmbSearchCategory_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbSearchCategory_SelectedIndexChanged_1(sender As Object, e As EventArgs)

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

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

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
End Class