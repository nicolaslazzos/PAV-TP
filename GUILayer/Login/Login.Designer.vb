<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(108, 68)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(215, 22)
        Me.txtPassword.TabIndex = 6
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(219, 116)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(107, 28)
        Me.cmdSalir.TabIndex = 9
        Me.cmdSalir.Text = "&Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdIngresar
        '
        Me.cmdIngresar.Location = New System.Drawing.Point(107, 116)
        Me.cmdIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(104, 28)
        Me.cmdIngresar.TabIndex = 8
        Me.cmdIngresar.Text = "&Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(108, 27)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.MaxLength = 10
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(216, 22)
        Me.txtUsuario.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(35, 71)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(73, 17)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(48, 29)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(61, 17)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "Usuario:"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 168)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdIngresar)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
End Class
