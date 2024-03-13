<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btnAnadir = New Button()
        GroupBox3 = New GroupBox()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        btnBorrar = New Button()
        btnSalir = New Button()
        Label17 = New Label()
        TotalSemanal = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAnadir
        ' 
        btnAnadir.BackColor = SystemColors.ActiveCaptionText
        btnAnadir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAnadir.ForeColor = SystemColors.ControlLightLight
        btnAnadir.Location = New Point(245, 502)
        btnAnadir.Name = "btnAnadir"
        btnAnadir.Size = New Size(94, 29)
        btnAnadir.TabIndex = 0
        btnAnadir.Text = "Anadir"
        btnAnadir.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Black
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBox3.ForeColor = Color.WhiteSmoke
        GroupBox3.Location = New Point(46, 201)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(293, 204)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Precios"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(187, 136)
        Label15.Name = "Label15"
        Label15.Size = New Size(48, 28)
        Label15.TabIndex = 9
        Label15.Text = "$10"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(187, 90)
        Label14.Name = "Label14"
        Label14.Size = New Size(48, 28)
        Label14.TabIndex = 8
        Label14.Text = "$15"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(187, 38)
        Label13.Name = "Label13"
        Label13.Size = New Size(48, 28)
        Label13.TabIndex = 7
        Label13.Text = "$20"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(119, 136)
        Label12.Name = "Label12"
        Label12.Size = New Size(42, 28)
        Label12.TabIndex = 6
        Label12.Text = "-->"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(119, 90)
        Label11.Name = "Label11"
        Label11.Size = New Size(42, 28)
        Label11.TabIndex = 5
        Label11.Text = "-->"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(119, 38)
        Label10.Name = "Label10"
        Label10.Size = New Size(42, 28)
        Label10.TabIndex = 4
        Label10.Text = "-->"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(44, 136)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 28)
        Label9.TabIndex = 3
        Label9.Text = "Nivel3"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(44, 90)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 28)
        Label8.TabIndex = 2
        Label8.Text = "Nivel2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(44, 38)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 28)
        Label7.TabIndex = 1
        Label7.Text = "Nivel1"
        ' 
        ' btnBorrar
        ' 
        btnBorrar.BackColor = SystemColors.ActiveCaptionText
        btnBorrar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnBorrar.ForeColor = SystemColors.ControlLightLight
        btnBorrar.Location = New Point(345, 502)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(94, 29)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = SystemColors.ActiveCaptionText
        btnSalir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSalir.ForeColor = SystemColors.ControlLightLight
        btnSalir.Location = New Point(459, 502)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(94, 29)
        btnSalir.TabIndex = 8
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(271, 22)
        Label17.Name = "Label17"
        Label17.Size = New Size(245, 26)
        Label17.TabIndex = 9
        Label17.Text = "ProgramaVolleyBall"
        ' 
        ' TotalSemanal
        ' 
        TotalSemanal.BackColor = SystemColors.ControlText
        TotalSemanal.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        TotalSemanal.ForeColor = SystemColors.Window
        TotalSemanal.FormattingEnabled = True
        TotalSemanal.ItemHeight = 25
        TotalSemanal.Location = New Point(445, 201)
        TotalSemanal.Name = "TotalSemanal"
        TotalSemanal.Size = New Size(293, 204)
        TotalSemanal.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(529, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 26)
        Label1.TabIndex = 14
        Label1.Text = "Resultados"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(115, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 26)
        Label2.TabIndex = 15
        Label2.Text = "Tienda"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(856, 649)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TotalSemanal)
        Controls.Add(Label17)
        Controls.Add(btnSalir)
        Controls.Add(btnBorrar)
        Controls.Add(GroupBox3)
        Controls.Add(btnAnadir)
        Name = "Form1"
        Text = "Form1"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAnadir As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TotalSemanal As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
