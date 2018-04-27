Imports System.Math
Imports System.Drawing
Imports System.IO
Imports System.Text

Public Class Form1
    Private printingText As String
    Private printingPosition As Integer
    Private printFont As Font

    '起動時に実行
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '起動時間を表示
        DayTextBox.Text = Now.ToString
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles LayerNum.ValueChanged
        'データをクリア
        DataGridView1.Rows.Clear()

        '層の数だけ行を追加
        For i As Integer = 1 To LayerNum.Value
            DataGridView1.Rows.Add({i, "", "", ""})
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            DayTextBox.Text = Now.ToString
            '層の数だけ計算を実行
            For i As Integer = 0 To LayerNum.Value - 1
                Dim nagasa As Decimal
                Dim haba As Decimal
                Dim tyokkei As Decimal
                tyokkei = DiameterNum.Value + (ThicknessNum.Value * 2 * (i + 1))

                Select Case DataGridView1(1, i).Value
                    Case "0"
                        nagasa = LongNum.Value + DimensionsNum.Value
                        haba = (tyokkei * PI) + lapNum.Value
                    Case "90"
                        nagasa = LongNum.Value + DimensionsNum.Value
                        haba = (tyokkei * PI) + lapNum.Value
                    Case "45"
                        nagasa = tyokkei * PI / Sqrt(2) + (LongNum.Value + DimensionsNum.Value) * Sqrt(2) + Dimensions45Num.Value
                        haba = (tyokkei * PI) / Sqrt(2)
                    Case "-45"
                        'nagasa = ((LongNum.Value + Dimensions45Num.Value) * Sqrt(2)) + (tyokkei * PI * Sqrt(2))
                        nagasa = tyokkei * PI / Sqrt(2) + (LongNum.Value + DimensionsNum.Value) * Sqrt(2) + Dimensions45Num.Value
                        haba = (tyokkei * PI) / Sqrt(2)
                    Case Else
                        MsgBox("繊維方向は[0][90][45][-45]の中から選択してください", 16)
                        Exit Sub
                End Select
                DataGridView1(2, i).Value = Floor(nagasa)
                DataGridView1(3, i).Value = Floor(haba)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, 16)
        End Try

        If MsgBox("引き続き結果を印刷しますか？", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            print_task()
        End If

    End Sub

    'Button1のClickイベントハンドラ
    Private Sub Button2_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles Button2.Click
        print_task()
    End Sub

    Private Sub print_task()
        Dim str As String
        str = ""
        str = str & "-------------------------------------------------" & vbNewLine
        str = str & "   - プリプレグ裁断寸法作成プログラム　Ver 3 -   " & vbNewLine
        str = str & "   -           Hashimoto 2015/04             -   " & vbNewLine
        str = str & "-------------------------------------------------" & vbNewLine
        str = str & " この計算は" & Now.ToString & " に" & vbNewLine
        str = str & " " & Environment.UserName & " が行いました。" & vbNewLine
        str = str & "   パイプの直径 ---------- " & DiameterNum.Value & " mm" & vbNewLine
        str = str & "   パイプの長さ ---------- " & LongNum.Value & " mm" & vbNewLine
        str = str & "   積層数 ---------------- " & LayerNum.Value & " 層" & vbNewLine
        str = str & "   プリプレグの厚さ ------ " & ThicknessNum.Value & " mm" & vbNewLine
        str = str & "   重ね代 ---------------- " & lapNum.Value & " mm" & vbNewLine
        str = str & "   パイプ余裕寸法（合計）- " & DimensionsNum.Value & " mm" & vbNewLine
        str = str & "   45度の余裕寸法 -------- " & Dimensions45Num.Value & " mm として計算します" & vbNewLine
        For i As Integer = 0 To LayerNum.Value - 1
            str = str & "-------------------------------------------------" & vbNewLine
            str = str & vbTab & DataGridView1(0, i).Value & "層目"
            str = str & vbTab & DataGridView1(1, i).Value & "度"

            If i + 10 <= LayerNum.Value - 1 Then
                str = str & vbTab & vbTab & DataGridView1(0, i + 10).Value & "層目"
                str = str & vbTab & DataGridView1(1, i + 10).Value & "度"
            End If

            str = str + vbNewLine

            str = str & vbTab & "長さ" & vbTab & DataGridView1(2, i).Value & " mm"

            If i + 10 <= LayerNum.Value - 1 Then
                str = str & vbTab & vbTab & "長さ" & vbTab & DataGridView1(2, i + 10).Value & " mm"
            End If

            str = str + vbNewLine

            str = str & vbTab & "幅" & vbTab & DataGridView1(3, i).Value & " mm"

            If i + 10 <= LayerNum.Value - 1 Then
                str = str & vbTab & vbTab & "幅" & vbTab & DataGridView1(3, i + 10).Value & " mm"
            End If

            str = str + vbNewLine + vbNewLine
            If i - 1 = 8 Then
                Exit For
            End If
        Next

        Try
            'PrintDocumentオブジェクトの作成
            Dim pd As New System.Drawing.Printing.PrintDocument
            'PrintPageイベントハンドラの追加
            AddHandler pd.PrintPage, AddressOf pd_PrintPage

            '印刷する文字列と位置を設定する
            printingText = str
            printingPosition = 0
            '印刷に使うフォントを指定する
            printFont = New Font("ＭＳ ゴシック", 11)

            'PrintDialogクラスの作成
            Dim pdlg As New PrintDialog
            'PrintDocumentを指定
            pdlg.Document = pd
            '印刷の選択ダイアログを表示する
            If pdlg.ShowDialog() = DialogResult.OK Then
                'OKがクリックされた時は印刷する
                pd.Print()
            Else
                If MsgBox("処理を終了しますか？", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("印刷に失敗しました" + vbNewLine + ex.Message, 16)
            Exit Sub
        End Try

        Try
            ' フォルダ (ディレクトリ) が存在しているかどうか確認する
            If System.IO.Directory.Exists("C:\Hoge\") = False Then
                System.IO.Directory.CreateDirectory("History\")
            End If

            Dim sjisEnc As Encoding = Encoding.GetEncoding("Shift_JIS")
            Dim path As String
            path = "History\" & Now.ToString("yyyyMMdd,hhmm_") & "直径" & DiameterNum.Value & "長さ" & LongNum.Value & "積層" & LayerNum.Value & ".txt"
            Using writer As New StreamWriter(path, False, sjisEnc)
                writer.WriteLine(str)
                writer.Close()
            End Using
        Catch ex As Exception
            MsgBox("ファイルの作成に失敗しました" + vbNewLine + ex.Message, 16)
            Exit Sub
        End Try

        MsgBox("印刷とファイルの生成が完了しました。" & vbNewLine & "桁焼頑張ってください！！", 64)

    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, _
            ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        If printingPosition = 0 Then
            '改行記号を'\n'に統一する
            printingText = printingText.Replace(vbCrLf, vbLf)
            printingText = printingText.Replace(vbCr, vbLf)
        End If

        '印刷する初期位置を決定
        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top

        '1ページに収まらなくなるか、印刷する文字がなくなるかまでループ
        While e.MarginBounds.Bottom > y + printFont.Height AndAlso _
                printingPosition < printingText.Length
            Dim line As String = ""

            While True
                '印刷する文字がなくなるか、
                '改行の時はループから抜けて印刷する
                If printingPosition >= printingText.Length OrElse _
                        printingText.Chars(printingPosition) = vbLf Then
                    printingPosition += 1
                    Exit While
                End If
                '一文字追加し、印刷幅を超えるか調べる
                line += printingText.Chars(printingPosition)
                If e.Graphics.MeasureString(line, printFont).Width _
                        > e.MarginBounds.Width Then
                    '印刷幅を超えたため、折り返す
                    line = line.Substring(0, line.Length - 1)
                    Exit While
                End If
                '印刷文字位置を次へ
                printingPosition += 1
            End While
            '一行書き出す
            e.Graphics.DrawString(line, printFont, Brushes.Black, x, y)
            '次の行の印刷位置を計算
            y += printFont.GetHeight(e.Graphics)
        End While

        '次のページがあるか調べる
        If printingPosition >= printingText.Length Then
            e.HasMorePages = False
            '初期化する
            printingPosition = 0
        Else
            e.HasMorePages = True
        End If
    End Sub

    Private Sub BtOutputJSON_Click(sender As Object, e As EventArgs) Handles BtOutputJSON.Click
        output_json()
    End Sub

    Private Sub output_json()
        Dim str As String
        str = ""
        str = str & "{""target"":[{""x"":0,""y"":0}],""parts"":["
        For i As Integer = 0 To LayerNum.Value - 1

            If DataGridView1(1, i).Value = 90 And SplitWidthNum.Value <> 0 Then

                Dim howlong As Integer = CType(DataGridView1(2, i).Value, Integer)
                Dim width As Integer = SplitWidthNum.Value

                Do
                    str = str & "{""id"":""" & DataGridView1(0, i).Value & "層"
                    str = str & DataGridView1(1, i).Value & "度"","

                    str = str & """x"":" & DataGridView1(3, i).Value & ","

                    str = str & """y"":" & width & "},"

                    howlong -= width
                    If howlong <= width Then
                        str = str & "{""id"":""" & DataGridView1(0, i).Value & "層"
                        str = str & DataGridView1(1, i).Value & "度"","

                        str = str & """x"":" & DataGridView1(3, i).Value & ","

                        str = str & """y"":" & howlong & "},"

                        Exit Do
                    End If
                Loop
            Else
                str = str & "{""id"":""" & DataGridView1(0, i).Value & "層"
                str = str & DataGridView1(1, i).Value & "度"","

                str = str & """x"":" & DataGridView1(2, i).Value & ","

                str = str & """y"":" & DataGridView1(3, i).Value & "},"

            End If
        Next
        str = str.Remove(str.Length - 1)
        str = str & "]}"

        Try
            ' フォルダ (ディレクトリ) が存在しているかどうか確認する
            If System.IO.Directory.Exists("C:\Hoge\") = False Then
                System.IO.Directory.CreateDirectory("JSON\")
            End If

            Dim path As String
            path = "JSON\" & Now.ToString("yyyyMMdd,hhmm_") & "直径" & DiameterNum.Value & "長さ" & LongNum.Value & "積層" & LayerNum.Value & ".json"
            Using writer As New StreamWriter(path, False, Encoding.UTF8)
                writer.WriteLine(str)
                writer.Close()
            End Using
        Catch ex As Exception
            MsgBox("ファイルの作成に失敗しました" + vbNewLine + ex.Message, 16)
            Exit Sub
        End Try

        MsgBox("JSONファイルの生成が完了しました。" & vbNewLine & "桁焼頑張ってください！！", 64)
    End Sub
End Class
