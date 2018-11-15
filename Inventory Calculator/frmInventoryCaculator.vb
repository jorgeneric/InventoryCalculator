Public Class frmInventoryCaculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Below are variables created to use in the calculations

        Dim Onhand As Integer
        Dim Cost As Decimal
        Dim Value As Decimal
        Dim Fee As Decimal
        Dim Target As Integer = 1000
        Dim HighRate As Decimal = 0.15
        Dim LowRate As Decimal = 0.05

        ' How I want the user to INPUT on the screen, in this case onhand and cost

        Integer.TryParse(txtOnhand.Text, Onhand)
        Decimal.TryParse(txtCost.Text, Cost)

        ' Calculations

        Value = Onhand * Cost

        If Value > Target Then
            Fee = Onhand * HighRate
            txtStockingFee.BackColor = Color.LightGreen
        End If
        If Target > Value Then
            Fee = Value * LowRate
            txtStockingFee.BackColor = Color.LightCoral
        End If

        ' Below is the OUTPUT of what is keyed in and what is calculated.

        txtOnhand.Text = Convert.ToString(Onhand)
        txtCost.Text = Convert.ToString(Cost)
        txtValue.Text = Convert.ToString(Value)
        txtStockingFee.Text = Convert.ToString(Fee)

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Below is how you blank out a text box

        txtOnhand.Text = String.Empty
        txtCost.Text = String.Empty
        txtValue.Text = String.Empty
        txtStockingFee.Text = String.Empty
        txtStockingFee.BackColor = Color.MistyRose

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
