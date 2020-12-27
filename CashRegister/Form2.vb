Public Class Form2


    Public intotal = 0, bill = 0, subtotal As Integer

    Private Sub sublist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sublist.SelectedIndexChanged

    End Sub

    Private Sub drinklist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drinklist.SelectedIndexChanged

        subtotal = Form1.price * Val(amt.Text)
        sublist.Items.Add("Drinks: " + drinklist.Text)
        sublist.Items.Add("x" + amt.Text + " Subtotal : P" + Str(subtotal))
        confirm.Enabled = True

        If (drinklist.Text = "Coke") Then
            coke.Visible = True
            sprite.Visible = False
            fanta.Visible = False
            pepsi.Visible = False
            up.Visible = False
            drinklist.Enabled = False
        ElseIf (drinklist.Text = "Sprite") Then
            coke.Visible = False
            sprite.Visible = True
            fanta.Visible = False
            pepsi.Visible = False
            up.Visible = False
            drinklist.Enabled = False
        ElseIf (drinklist.Text = "Fanta") Then
            coke.Visible = False
            sprite.Visible = False
            fanta.Visible = True
            pepsi.Visible = False
            up.Visible = False
            drinklist.Enabled = False
        ElseIf (drinklist.Text = "Pepsi") Then
            coke.Visible = False
            sprite.Visible = False
            fanta.Visible = False
            pepsi.Visible = True
            up.Visible = False
            drinklist.Enabled = False
        ElseIf (drinklist.Text = "7up") Then
            coke.Visible = False
            sprite.Visible = False
            fanta.Visible = False
            pepsi.Visible = False
            up.Visible = True
            drinklist.Enabled = False
        End If

    End Sub

    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click

        Me.Hide()
        subtotal = Form1.price * Val(amt.Text)
        Form1.receipt.Items.AddRange(sublist.Items)
        sublist.Items.Clear()
        drinklist.Enabled = True
        amt.Text = 1
        confirm.Enabled = False

        bill = intotal + subtotal
        intotal = bill

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        confirm.Enabled = False
        Me.Hide()
        drinklist.Enabled = True
        sublist.Items.Clear()
        amt.Text = 1


    End Sub
End Class