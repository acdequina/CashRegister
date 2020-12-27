Public Class Form1


    Public chick1p = 83, chick2p = 100, chick3p = 128, chick4p = 350, rice1p = 54, rice2p = 57, rice3p = 74, rice4p = 81, burg1p = 57, burg2p = 110, burg3p = 71, burg4p = 110, side1p = 48, side2p = 63, side3p = 83, side4p = 40, price As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles chick1.Click

        Form2.Show()
        Form2.sublist.Items.Add("1pc Chickenjoy")
        price = chick1p
        Form2.chick1pt.Visible = True
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub burg2_Click(sender As Object, e As EventArgs) Handles burg2.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("Amazing Aloha")
        price = burg2p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = True
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False

    End Sub

    Private Sub chickck_CheckedChanged(sender As Object, e As EventArgs) Handles chickck.CheckedChanged

        If (chickck.Checked = True) Then
            chick1.Enabled = True
            chick2.Enabled = True
            chick3.Enabled = True
            chick4.Enabled = True
        Else
            chick1.Enabled = False
            chick2.Enabled = False
            chick3.Enabled = False
            chick4.Enabled = False
        End If

    End Sub

    Private Sub riceck_CheckedChanged(sender As Object, e As EventArgs) Handles riceck.CheckedChanged

        If (riceck.Checked = True) Then
            rice1.Enabled = True
            rice2.Enabled = True
            rice3.Enabled = True
            rice4.Enabled = True
        Else
            rice1.Enabled = False
            rice2.Enabled = False
            rice3.Enabled = False
            rice4.Enabled = False

        End If

    End Sub

    Private Sub burgck_CheckedChanged(sender As Object, e As EventArgs) Handles burgck.CheckedChanged

        If (burgck.Checked = True) Then
            burg1.Enabled = True
            burg2.Enabled = True
            burg3.Enabled = True
            burg4.Enabled = True
        Else
            burg1.Enabled = False
            burg2.Enabled = False
            burg3.Enabled = False
            burg4.Enabled = False

        End If

    End Sub

    Private Sub sideck_CheckedChanged(sender As Object, e As EventArgs) Handles sideck.CheckedChanged

        If (sideck.Checked = True) Then
            side1.Enabled = True
            side2.Enabled = True
            side3.Enabled = True
            side4.Enabled = True
        Else
            side1.Enabled = False
            side2.Enabled = False
            side3.Enabled = False
            side4.Enabled = False

        End If

    End Sub

    Private Sub chick2_Click(sender As Object, e As EventArgs) Handles chick2.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("1pc Chickenjoy")
        Form2.sublist.Items.Add("Spaghetti")
        price = chick2p

        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = True
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False

    End Sub

    Private Sub chick3_Click(sender As Object, e As EventArgs) Handles chick3.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("2pc Chickenjoy")
        price = chick3p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = True
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False

    End Sub

    Private Sub chick4_Click(sender As Object, e As EventArgs) Handles chick4.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("6pc Chickenjoy Bucket")
        price = chick4p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = True

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False

    End Sub

    Private Sub rice1_Click(sender As Object, e As EventArgs) Handles rice1.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("1pc Burger Steak")
        price = rice1p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = True
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False

    End Sub

    Private Sub rice2_Click(sender As Object, e As EventArgs) Handles rice2.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("Jollibee Spaghetti")
        price = rice2p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = True
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False

    End Sub

    Private Sub rice3_Click(sender As Object, e As EventArgs) Handles rice3.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("2pc Burger Steak")
        price = rice3p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = True
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False
    End Sub

    Private Sub rice4_Click(sender As Object, e As EventArgs) Handles rice4.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("Jollibee Spaghetti w/ Yum")
        price = rice4p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = True

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False
    End Sub

    Private Sub burg1_Click(sender As Object, e As EventArgs) Handles burg1.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("Yum")
        price = burg1p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = True
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False
    End Sub

    Private Sub burg3_Click(sender As Object, e As EventArgs) Handles burg3.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("Yum w/ Cheese")
        price = burg3p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = True
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False
    End Sub

    Private Sub burg4_Click(sender As Object, e As EventArgs) Handles burg4.Click
        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("Cheese Bacon Mushroom")
        price = burg4p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = True

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False
    End Sub

    Private Sub side1_Click(sender As Object, e As EventArgs) Handles side1.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("Jolly Crispy Fries Regular")
        price = side1p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = True
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False

    End Sub

    Private Sub side2_Click(sender As Object, e As EventArgs) Handles side2.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("Jolly Crispy Fries Large")
        price = side2p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = True
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = False

    End Sub

    Private Sub side3_Click(sender As Object, e As EventArgs) Handles side3.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("Jolly Crispy Fries Extra Large")
        price = side3p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = True
        Form2.side4pt.Visible = False

    End Sub

    Private Sub side4_Click(sender As Object, e As EventArgs) Handles side4.Click

        Form2.Show()
        Form2.Visible = Enabled
        Form2.sublist.Items.Add("Jollibee Tuna Pie")
        price = side4p
        Form2.chick1pt.Visible = False
        Form2.chick2pt.Visible = False
        Form2.chick3pt.Visible = False
        Form2.chick4pt.Visible = False

        Form2.rice1pt.Visible = False
        Form2.rice2pt.Visible = False
        Form2.rice3pt.Visible = False
        Form2.rice4pt.Visible = False

        Form2.burg1pt.Visible = False
        Form2.burg2pt.Visible = False
        Form2.burg3pt.Visible = False
        Form2.burg4pt.Visible = False

        Form2.side1pt.Visible = False
        Form2.side2pt.Visible = False
        Form2.side3pt.Visible = False
        Form2.side4pt.Visible = True
    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click

        chickck.Checked = False
        chickck.Enabled = False
        burgck.Checked = False
        burgck.Enabled = False
        riceck.Checked = False
        riceck.Enabled = False
        sideck.Checked = False
        sideck.Enabled = False

        none.Enabled = False
        member.Enabled = False
        senior.Enabled = False
        Confirm.Enabled = False
        Clear.Enabled = False
        payment.Enabled = False
        If (senior.Checked) Then
            receipt.Items.Add("Total : P" + Str(Form2.bill))
            receipt.Items.Add("Received Cash : P" + Str(Val(payment.Text)))
            receipt.Items.Add("Discount : P" + Str(Form2.bill * 0.2))
            receipt.Items.Add("Change : P" + Str(Val(payment.Text) - (Form2.bill - (Form2.bill * 0.2))))
        ElseIf (member.Checked) Then
            receipt.Items.Add("Total : P" + Str(Form2.bill))
            receipt.Items.Add("Received Cash : P" + Str(Val(payment.Text)))
            receipt.Items.Add("Discount : P" + Str(Form2.bill * 0.1))
            receipt.Items.Add("Change : P" + Str(Val(payment.Text) - (Form2.bill - (Form2.bill * 0.1))))
        ElseIf (none.Checked) Then
            receipt.Items.Add("Total : P" + Str(Form2.bill))
            receipt.Items.Add("Received Cash : P" + Str(Val(payment.Text)))
            receipt.Items.Add("Discount : P 0")
            receipt.Items.Add("Change : P" + Str(Val(payment.Text) - Form2.bill))
        End If

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        payment.Clear()
        Confirm.Enabled = False

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        none.Enabled = True
        none.Checked = False
        member.Enabled = True
        member.Checked = False
        senior.Enabled = True
        senior.Checked = False
        Clear.Enabled = True
        receipt.Items.Clear()
        Form2.intotal = 0
        Form2.bill = 0
        payment.Clear()
        chickck.Enabled = True
        burgck.Enabled = True
        riceck.Enabled = True
        sideck.Enabled = True



    End Sub

    Private Sub none_CheckedChanged(sender As Object, e As EventArgs) Handles none.CheckedChanged

        payment.Enabled = True

    End Sub

    Private Sub payment_TextChanged(sender As Object, e As EventArgs) Handles payment.TextChanged
        Confirm.Enabled = True

    End Sub

    Private Sub member_CheckedChanged(sender As Object, e As EventArgs) Handles member.CheckedChanged

        payment.Enabled = True

    End Sub

    Private Sub senior_CheckedChanged(sender As Object, e As EventArgs) Handles senior.CheckedChanged

        payment.Enabled = True

    End Sub
End Class
