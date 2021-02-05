<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaSelection
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.PicDeepDish = New System.Windows.Forms.PictureBox()
        Me.PicThinCrust = New System.Windows.Forms.PictureBox()
        Me.btnDeepDish = New System.Windows.Forms.Button()
        Me.btnSelectPizza = New System.Windows.Forms.Button()
        Me.btnThinCrust = New System.Windows.Forms.Button()
        Me.Chlblinstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PicDeepDish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicThinCrust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(130, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(168, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Pizza Selection"
        '
        'PicDeepDish
        '
        Me.PicDeepDish.Location = New System.Drawing.Point(12, 65)
        Me.PicDeepDish.Name = "PicDeepDish"
        Me.PicDeepDish.Size = New System.Drawing.Size(185, 150)
        Me.PicDeepDish.TabIndex = 1
        Me.PicDeepDish.TabStop = False
        '
        'PicThinCrust
        '
        Me.PicThinCrust.Location = New System.Drawing.Point(217, 65)
        Me.PicThinCrust.Name = "PicThinCrust"
        Me.PicThinCrust.Size = New System.Drawing.Size(185, 150)
        Me.PicThinCrust.TabIndex = 2
        Me.PicThinCrust.TabStop = False
        '
        'btnDeepDish
        '
        Me.btnDeepDish.Location = New System.Drawing.Point(40, 230)
        Me.btnDeepDish.Name = "btnDeepDish"
        Me.btnDeepDish.Size = New System.Drawing.Size(75, 23)
        Me.btnDeepDish.TabIndex = 3
        Me.btnDeepDish.Text = "Deep Dish"
        Me.btnDeepDish.UseVisualStyleBackColor = True
        '
        'btnSelectPizza
        '
        Me.btnSelectPizza.Location = New System.Drawing.Point(160, 230)
        Me.btnSelectPizza.Name = "btnSelectPizza"
        Me.btnSelectPizza.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectPizza.TabIndex = 4
        Me.btnSelectPizza.Text = "Select Pizza"
        Me.btnSelectPizza.UseVisualStyleBackColor = True
        '
        'btnThinCrust
        '
        Me.btnThinCrust.Location = New System.Drawing.Point(293, 230)
        Me.btnThinCrust.Name = "btnThinCrust"
        Me.btnThinCrust.Size = New System.Drawing.Size(75, 23)
        Me.btnThinCrust.TabIndex = 5
        Me.btnThinCrust.Text = "Thin Crust"
        Me.btnThinCrust.UseVisualStyleBackColor = True
        '
        'Chlblinstructions
        '
        Me.Chlblinstructions.AutoSize = True
        Me.Chlblinstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chlblinstructions.Location = New System.Drawing.Point(58, 276)
        Me.Chlblinstructions.Name = "Chlblinstructions"
        Me.Chlblinstructions.Size = New System.Drawing.Size(326, 14)
        Me.Chlblinstructions.TabIndex = 6
        Me.Chlblinstructions.Text = "Choose a pizza type and then click the Selecr Pizza Button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(132, 303)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(146, 14)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enjoy your pizza selection"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(327, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPizzaSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 356)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.Chlblinstructions)
        Me.Controls.Add(Me.btnThinCrust)
        Me.Controls.Add(Me.btnSelectPizza)
        Me.Controls.Add(Me.btnDeepDish)
        Me.Controls.Add(Me.PicThinCrust)
        Me.Controls.Add(Me.PicDeepDish)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPizzaSelection"
        Me.Text = "Pizza Selection"
        CType(Me.PicDeepDish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicThinCrust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents PicDeepDish As PictureBox
    Friend WithEvents PicThinCrust As PictureBox
    Friend WithEvents btnDeepDish As Button
    Friend WithEvents btnSelectPizza As Button
    Friend WithEvents btnThinCrust As Button
    Friend WithEvents Chlblinstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
