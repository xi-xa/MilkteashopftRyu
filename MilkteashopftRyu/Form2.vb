Public Class Form1
    Private Sub CheckedListBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbl4.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            cbl1.Visible = True
        Else
            cbl1.Visible = False

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            cbl2.Visible = True
        Else
            cbl2.Visible = False

        End If
    End Sub

    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If cb3.Checked = True Then
            cbl3.Visible = True
        Else
            cbl3.Visible = False

        End If
    End Sub

    Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
        If cb4.Checked = True Then
            cbl4.Visible = True
        Else
            cbl4.Visible = False

        End If
    End Sub
End Class