<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Bathed_Button = New Button()
        Ate_Button = New Button()
        Played_Button = New Button()
        SuspendLayout()
        ' 
        ' Bathed_Button
        ' 
        Bathed_Button.Location = New Point(85, 55)
        Bathed_Button.Name = "Bathed_Button"
        Bathed_Button.Size = New Size(167, 131)
        Bathed_Button.TabIndex = 0
        Bathed_Button.Text = "Bathed"
        Bathed_Button.UseVisualStyleBackColor = True
        ' 
        ' Ate_Button
        ' 
        Ate_Button.Location = New Point(310, 55)
        Ate_Button.Name = "Ate_Button"
        Ate_Button.Size = New Size(167, 131)
        Ate_Button.TabIndex = 1
        Ate_Button.Text = "Ate"
        Ate_Button.UseVisualStyleBackColor = True
        ' 
        ' Played_Button
        ' 
        Played_Button.Location = New Point(536, 55)
        Played_Button.Name = "Played_Button"
        Played_Button.Size = New Size(167, 131)
        Played_Button.TabIndex = 2
        Played_Button.Text = "Played"
        Played_Button.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Played_Button)
        Controls.Add(Ate_Button)
        Controls.Add(Bathed_Button)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Pou Tracker"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Bathed_Button As Button
    Friend WithEvents Ate_Button As Button
    Friend WithEvents Played_Button As Button

End Class
