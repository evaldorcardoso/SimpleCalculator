Public Class FrmPrincipal
    Dim valor1 As Integer
    Dim valor2 As Integer
    Dim resultado As Double
    Dim aux As Boolean = False

    '''Faz a validação de valores numéricos no txtValor1
    Private Sub txtValor1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor1.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or _
            Char.IsControl(e.KeyChar)) Then
            pbxAlertV1.Visible = True
            btnCalcular.Visible = False
            e.KeyChar = ""
            MsgBox("Só são permitidos valores numéricos!")
        Else
            pbxAlertV1.Visible = False
            btnCalcular.Visible = True
        End If
    End Sub
    '''Faz a validação de valores numéricos no txtValor2
    Private Sub txtValor2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor2.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or _
            Char.IsControl(e.KeyChar)) Then
            pbxAlertV2.Visible = True
            btnCalcular.Visible = False
            e.KeyChar = ""
            MsgBox("Só são permitidos valores numéricos!")
        Else
            pbxAlertV2.Visible = False
            btnCalcular.Visible = True
        End If
    End Sub
    '''Controla se alguma opção do comboBox foi selecionada, se sim habilita o botão calcular e desabilita mensagem atenção
    Private Sub cbxOperacao_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxOperacao.SelectedValueChanged
        PbxAlertOp.Visible = False
        btnCalcular.Visible = True
    End Sub
    '''Ação de clique do btnCalcular
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ''Compara se há campos vazios
        If (txtValor1.Text.Trim().Length = 0) Then
            MsgBox("Campo: 'Valor 1' não pode ser vazio!")
            pbxAlertV1.Visible = True
            btnCalcular.Visible = False
        ElseIf (txtValor2.Text.Trim.Length() = 0) Then
            MsgBox("Campo: 'Valor 2' não pode ser vazio!")
            pbxAlertV2.Visible = True
            btnCalcular.Visible = False
        Else
            btnCalcular.Visible = True
            pbxAlertV1.Visible = False
            pbxAlertV2.Visible = False
            PbxAlertOp.Visible = False
            valor1 = Convert.ToInt32(txtValor1.Text)
            valor2 = Convert.ToInt32(txtValor2.Text)
            If (cbxOperacao.Text = "Somar") Then
                resultado = valor1 + valor2
                aux = True
            ElseIf (cbxOperacao.Text = "Subtrair") Then
                resultado = valor1 - valor2
                aux = True
            ElseIf (cbxOperacao.Text = "Dividir") Then
                resultado = valor1 / valor2
                aux = True
            ElseIf (cbxOperacao.Text = "Multiplicar") Then
                ''Tratamento de erro caso algo dê errado
                Try
                    resultado = valor1 * valor2
                    aux = True
                Catch ex As Exception
                    MsgBox("Erro!!")
                End Try
            End If
            If (aux = True) Then
                txtResultado.Text = resultado.ToString
            Else
                MsgBox("Operação Inválida!")
                PbxAlertOp.Visible = True
                btnCalcular.Visible = False
            End If
        End If
    End Sub
    '''Ação do clique no btnSair
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub
End Class
