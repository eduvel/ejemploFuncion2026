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
        txtNumero1 = New TextBox()
        txtNumero2 = New TextBox()
        lblMostrar = New Label()
        cmdEjecutar = New Button()
        lblVariableModificada = New Label()
        SuspendLayout()
        ' 
        ' txtNumero1
        ' 
        txtNumero1.Location = New Point(128, 52)
        txtNumero1.Name = "txtNumero1"
        txtNumero1.Size = New Size(122, 27)
        txtNumero1.TabIndex = 0
        ' 
        ' txtNumero2
        ' 
        txtNumero2.Location = New Point(267, 52)
        txtNumero2.Name = "txtNumero2"
        txtNumero2.Size = New Size(116, 27)
        txtNumero2.TabIndex = 1
        ' 
        ' lblMostrar
        ' 
        lblMostrar.AutoSize = True
        lblMostrar.Location = New Point(217, 118)
        lblMostrar.Name = "lblMostrar"
        lblMostrar.Size = New Size(71, 20)
        lblMostrar.TabIndex = 2
        lblMostrar.Text = "resultado"
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(195, 164)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(117, 56)
        cmdEjecutar.TabIndex = 3
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lblVariableModificada
        ' 
        lblVariableModificada.AutoSize = True
        lblVariableModificada.Location = New Point(474, 119)
        lblVariableModificada.Name = "lblVariableModificada"
        lblVariableModificada.Size = New Size(86, 20)
        lblVariableModificada.TabIndex = 4
        lblVariableModificada.Text = "modificado"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblVariableModificada)
        Controls.Add(cmdEjecutar)
        Controls.Add(lblMostrar)
        Controls.Add(txtNumero2)
        Controls.Add(txtNumero1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents lblMostrar As Label
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lblVariableModificada As Label

End Class
