Public Class Form1
    Private Sub CheckedListBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbl4.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            cbl1.Visible = True
            nud1.Visible = False
            bt1.Visible = False

        Else
            cbl1.Visible = False
            nud1.Visible = False
            bt1.Visible = False

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            cbl2.Visible = True
            nud2.Visible = False
            bt2.Visible = False
        Else
            cbl2.Visible = False
            nud2.Visible = False
            bt2.Visible = False

        End If
    End Sub

    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If cb3.Checked = True Then
            cbl3.Visible = True
            nud3.Visible = False
            bt3.Visible = False
        Else
            cbl3.Visible = False
            nud3.Visible = False
            bt3.Visible = False

        End If
    End Sub

    Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
        If cb4.Checked = True Then
            cbl4.Visible = True
            nud4.Visible = False
            bt4.Visible = False

        Else
            cbl4.Visible = False
            nud4.Visible = False
            bt4.Visible = False
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbl1.SelectedIndexChanged
        nud1.Visible = cb1.Checked AndAlso cbl1.SelectedItems.Count > 0
        bt1.Visible = True
        cbl1.Visible = False
    End Sub

    Private Sub nud2_ValueChanged(sender As Object, e As EventArgs) Handles nud2.ValueChanged
        nud2.Visible = cb2.Checked AndAlso cbl2.SelectedItems.Count > 0
        bt2.Visible = True
        cbl2.Visible = False
    End Sub

    Private Sub nud3_ValueChanged(sender As Object, e As EventArgs) Handles nud3.ValueChanged
        nud3.Visible = cb3.Checked AndAlso cbl3.SelectedItems.Count > 0
        bt3.Visible = True
        cbl3.Visible = False
    End Sub

    Private Sub nud4_ValueChanged(sender As Object, e As EventArgs) Handles nud4.ValueChanged
        nud4.Visible = cb4.Checked AndAlso cbl4.SelectedItems.Count > 0
        bt4.Visible = True
        cbl4.Visible = False
    End Sub

End Class