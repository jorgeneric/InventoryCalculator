<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryCaculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtInventoryCalculator = New System.Windows.Forms.Label()
        Me.lblAmtonHand = New System.Windows.Forms.Label()
        Me.lblProductCost = New System.Windows.Forms.Label()
        Me.lblInventoryValue = New System.Windows.Forms.Label()
        Me.lblStockingFee = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtOnhand = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtStockingFee = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtInventoryCalculator
        '
        Me.txtInventoryCalculator.AutoSize = True
        Me.txtInventoryCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventoryCalculator.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtInventoryCalculator.Location = New System.Drawing.Point(186, 113)
        Me.txtInventoryCalculator.Name = "txtInventoryCalculator"
        Me.txtInventoryCalculator.Size = New System.Drawing.Size(277, 31)
        Me.txtInventoryCalculator.TabIndex = 0
        Me.txtInventoryCalculator.Text = "Inventory Calculator"
        '
        'lblAmtonHand
        '
        Me.lblAmtonHand.AutoSize = True
        Me.lblAmtonHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmtonHand.Location = New System.Drawing.Point(185, 179)
        Me.lblAmtonHand.Name = "lblAmtonHand"
        Me.lblAmtonHand.Size = New System.Drawing.Size(174, 16)
        Me.lblAmtonHand.TabIndex = 1
        Me.lblAmtonHand.Text = "ENTER the amount on hand"
        '
        'lblProductCost
        '
        Me.lblProductCost.AutoSize = True
        Me.lblProductCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductCost.Location = New System.Drawing.Point(185, 228)
        Me.lblProductCost.Name = "lblProductCost"
        Me.lblProductCost.Size = New System.Drawing.Size(152, 16)
        Me.lblProductCost.TabIndex = 3
        Me.lblProductCost.Text = "ENTER the product cost"
        '
        'lblInventoryValue
        '
        Me.lblInventoryValue.AutoSize = True
        Me.lblInventoryValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventoryValue.Location = New System.Drawing.Point(185, 286)
        Me.lblInventoryValue.Name = "lblInventoryValue"
        Me.lblInventoryValue.Size = New System.Drawing.Size(111, 16)
        Me.lblInventoryValue.TabIndex = 7
        Me.lblInventoryValue.Text = "Inventory value is"
        '
        'lblStockingFee
        '
        Me.lblStockingFee.AutoSize = True
        Me.lblStockingFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockingFee.Location = New System.Drawing.Point(185, 340)
        Me.lblStockingFee.Name = "lblStockingFee"
        Me.lblStockingFee.Size = New System.Drawing.Size(95, 16)
        Me.lblStockingFee.TabIndex = 9
        Me.lblStockingFee.Text = "Stocking fee is"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCalculate.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(511, 175)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(92, 27)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClear.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(511, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 27)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Lavender
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExit.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(511, 286)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 27)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtOnhand
        '
        Me.txtOnhand.Location = New System.Drawing.Point(378, 177)
        Me.txtOnhand.Name = "txtOnhand"
        Me.txtOnhand.Size = New System.Drawing.Size(71, 20)
        Me.txtOnhand.TabIndex = 2
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(378, 228)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(71, 20)
        Me.txtCost.TabIndex = 4
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.MistyRose
        Me.txtValue.ForeColor = System.Drawing.Color.Black
        Me.txtValue.Location = New System.Drawing.Point(378, 286)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(71, 20)
        Me.txtValue.TabIndex = 8
        '
        'txtStockingFee
        '
        Me.txtStockingFee.BackColor = System.Drawing.Color.MistyRose
        Me.txtStockingFee.Location = New System.Drawing.Point(378, 340)
        Me.txtStockingFee.Name = "txtStockingFee"
        Me.txtStockingFee.Size = New System.Drawing.Size(71, 20)
        Me.txtStockingFee.TabIndex = 10
        '
        'frmInventoryCaculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 760)
        Me.Controls.Add(Me.txtStockingFee)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtOnhand)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblStockingFee)
        Me.Controls.Add(Me.lblInventoryValue)
        Me.Controls.Add(Me.lblProductCost)
        Me.Controls.Add(Me.lblAmtonHand)
        Me.Controls.Add(Me.txtInventoryCalculator)
        Me.Name = "frmInventoryCaculator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInventoryCalculator As Label
    Friend WithEvents lblAmtonHand As Label
    Friend WithEvents lblProductCost As Label
    Friend WithEvents lblInventoryValue As Label
    Friend WithEvents lblStockingFee As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtOnhand As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents txtStockingFee As TextBox
End Class
