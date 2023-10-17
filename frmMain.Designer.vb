<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCreate = New Button()
        txtIterations = New TextBox()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.Honeydew
        btnCreate.Font = New Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btnCreate.Location = New Point(12, 88)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(362, 64)
        btnCreate.TabIndex = 0
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' txtIterations
        ' 
        txtIterations.Font = New Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point)
        txtIterations.Location = New Point(12, 31)
        txtIterations.Name = "txtIterations"
        txtIterations.PlaceholderText = "Enter Iterations"
        txtIterations.Size = New Size(362, 51)
        txtIterations.TabIndex = 1
        txtIterations.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.MistyRose
        btnExit.Font = New Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.Location = New Point(12, 158)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(362, 64)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(392, 238)
        Controls.Add(btnExit)
        Controls.Add(txtIterations)
        Controls.Add(btnCreate)
        Name = "frmMain"
        Text = "frmMain"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents txtIterations As TextBox
    Friend WithEvents btnExit As Button
End Class
