<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.cbxOperacao = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblValor1 = New System.Windows.Forms.Label()
        Me.lblValor2 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.pbxAlertV1 = New System.Windows.Forms.PictureBox()
        Me.pbxAlertV2 = New System.Windows.Forms.PictureBox()
        Me.PbxAlertOp = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbxAlertV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAlertV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAlertOp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtValor1
        '
        Me.txtValor1.BackColor = System.Drawing.Color.White
        Me.txtValor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValor1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor1.Location = New System.Drawing.Point(181, 48)
        Me.txtValor1.MaxLength = 8
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(216, 41)
        Me.txtValor1.TabIndex = 1
        Me.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtValor2
        '
        Me.txtValor2.BackColor = System.Drawing.Color.White
        Me.txtValor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor2.Location = New System.Drawing.Point(181, 97)
        Me.txtValor2.MaxLength = 8
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(216, 41)
        Me.txtValor2.TabIndex = 2
        Me.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResultado
        '
        Me.txtResultado.BackColor = System.Drawing.Color.White
        Me.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.HideSelection = False
        Me.txtResultado.Location = New System.Drawing.Point(181, 201)
        Me.txtResultado.MaxLength = 999999999
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(216, 41)
        Me.txtResultado.TabIndex = 4
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxOperacao
        '
        Me.cbxOperacao.BackColor = System.Drawing.Color.White
        Me.cbxOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxOperacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOperacao.FormattingEnabled = True
        Me.cbxOperacao.Items.AddRange(New Object() {"Somar", "Subtrair", "Dividir", "Multiplicar"})
        Me.cbxOperacao.Location = New System.Drawing.Point(181, 147)
        Me.cbxOperacao.Name = "cbxOperacao"
        Me.cbxOperacao.Size = New System.Drawing.Size(216, 39)
        Me.cbxOperacao.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.AllowDrop = True
        Me.btnCalcular.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise
        Me.btnCalcular.FlatAppearance.BorderSize = 0
        Me.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Calligraphic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.Transparent
        Me.btnCalcular.Location = New System.Drawing.Point(12, 246)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(385, 50)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCalcular.UseVisualStyleBackColor = False
        Me.btnCalcular.Visible = False
        '
        'lblValor1
        '
        Me.lblValor1.AutoSize = True
        Me.lblValor1.Font = New System.Drawing.Font("Calligraphic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor1.ForeColor = System.Drawing.Color.Transparent
        Me.lblValor1.Location = New System.Drawing.Point(10, 53)
        Me.lblValor1.Name = "lblValor1"
        Me.lblValor1.Size = New System.Drawing.Size(133, 36)
        Me.lblValor1.TabIndex = 5
        Me.lblValor1.Text = "Valor 1:"
        '
        'lblValor2
        '
        Me.lblValor2.AutoSize = True
        Me.lblValor2.Font = New System.Drawing.Font("Calligraphic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor2.ForeColor = System.Drawing.Color.Transparent
        Me.lblValor2.Location = New System.Drawing.Point(10, 102)
        Me.lblValor2.Name = "lblValor2"
        Me.lblValor2.Size = New System.Drawing.Size(133, 36)
        Me.lblValor2.TabIndex = 6
        Me.lblValor2.Text = "Valor 2:"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Calligraphic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.ForeColor = System.Drawing.Color.Transparent
        Me.lblResultado.Location = New System.Drawing.Point(10, 201)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(170, 36)
        Me.lblResultado.TabIndex = 7
        Me.lblResultado.Text = "Resultado:"
        '
        'lblOperacao
        '
        Me.lblOperacao.AutoSize = True
        Me.lblOperacao.Font = New System.Drawing.Font("Calligraphic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacao.ForeColor = System.Drawing.Color.Transparent
        Me.lblOperacao.Location = New System.Drawing.Point(10, 152)
        Me.lblOperacao.Name = "lblOperacao"
        Me.lblOperacao.Size = New System.Drawing.Size(163, 36)
        Me.lblOperacao.TabIndex = 8
        Me.lblOperacao.Text = "Operação:"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise
        Me.btnSair.FlatAppearance.BorderSize = 0
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Calligraphic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Transparent
        Me.btnSair.Location = New System.Drawing.Point(12, 311)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(385, 45)
        Me.btnSair.TabIndex = 9
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'pbxAlertV1
        '
        Me.pbxAlertV1.Image = Global.EvaldoCalculadora.My.Resources.Resources._1362904501_Other_Antivirus_Software
        Me.pbxAlertV1.Location = New System.Drawing.Point(403, 48)
        Me.pbxAlertV1.Name = "pbxAlertV1"
        Me.pbxAlertV1.Size = New System.Drawing.Size(42, 41)
        Me.pbxAlertV1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAlertV1.TabIndex = 10
        Me.pbxAlertV1.TabStop = False
        Me.pbxAlertV1.Visible = False
        '
        'pbxAlertV2
        '
        Me.pbxAlertV2.Image = Global.EvaldoCalculadora.My.Resources.Resources._1362904501_Other_Antivirus_Software
        Me.pbxAlertV2.Location = New System.Drawing.Point(403, 97)
        Me.pbxAlertV2.Name = "pbxAlertV2"
        Me.pbxAlertV2.Size = New System.Drawing.Size(42, 41)
        Me.pbxAlertV2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAlertV2.TabIndex = 11
        Me.pbxAlertV2.TabStop = False
        Me.pbxAlertV2.Visible = False
        '
        'PbxAlertOp
        '
        Me.PbxAlertOp.Image = Global.EvaldoCalculadora.My.Resources.Resources._1362904501_Other_Antivirus_Software
        Me.PbxAlertOp.Location = New System.Drawing.Point(403, 147)
        Me.PbxAlertOp.Name = "PbxAlertOp"
        Me.PbxAlertOp.Size = New System.Drawing.Size(42, 41)
        Me.PbxAlertOp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAlertOp.TabIndex = 12
        Me.PbxAlertOp.TabStop = False
        Me.PbxAlertOp.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(304, 365)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Desenvolvido por: Evaldo R.C."
        '
        'FrmPrincipal
        '
        Me.AcceptButton = Me.btnCalcular
        Me.AccessibleDescription = "Calculadora Simples"
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.CancelButton = Me.btnSair
        Me.ClientSize = New System.Drawing.Size(454, 378)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PbxAlertOp)
        Me.Controls.Add(Me.pbxAlertV2)
        Me.Controls.Add(Me.pbxAlertV1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lblOperacao)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblValor2)
        Me.Controls.Add(Me.lblValor1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.cbxOperacao)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Calculadora"
        CType(Me.pbxAlertV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAlertV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxAlertOp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValor1 As System.Windows.Forms.TextBox
    Friend WithEvents txtValor2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents cbxOperacao As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents lblValor1 As System.Windows.Forms.Label
    Friend WithEvents lblValor2 As System.Windows.Forms.Label
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents lblOperacao As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents pbxAlertV1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAlertV2 As System.Windows.Forms.PictureBox
    Friend WithEvents PbxAlertOp As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
