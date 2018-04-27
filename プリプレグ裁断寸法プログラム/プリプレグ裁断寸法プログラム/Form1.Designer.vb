<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DayTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dimensions45Num = New System.Windows.Forms.NumericUpDown()
        Me.DimensionsNum = New System.Windows.Forms.NumericUpDown()
        Me.lapNum = New System.Windows.Forms.NumericUpDown()
        Me.ThicknessNum = New System.Windows.Forms.NumericUpDown()
        Me.LayerNum = New System.Windows.Forms.NumericUpDown()
        Me.LongNum = New System.Windows.Forms.NumericUpDown()
        Me.DiameterNum = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtOutputJSON = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SplitWidthNum = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dimensions45Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DimensionsNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lapNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThicknessNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayerNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LongNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiameterNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitWidthNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "日付"
        '
        'DayTextBox
        '
        Me.DayTextBox.Enabled = False
        Me.DayTextBox.Location = New System.Drawing.Point(50, 6)
        Me.DayTextBox.Name = "DayTextBox"
        Me.DayTextBox.Size = New System.Drawing.Size(156, 25)
        Me.DayTextBox.TabIndex = 100
        Me.DayTextBox.TabStop = False
        Me.DayTextBox.Text = "2015/04/18 (土) 18:34:17"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Dimensions45Num)
        Me.GroupBox1.Controls.Add(Me.DimensionsNum)
        Me.GroupBox1.Controls.Add(Me.lapNum)
        Me.GroupBox1.Controls.Add(Me.ThicknessNum)
        Me.GroupBox1.Controls.Add(Me.LayerNum)
        Me.GroupBox1.Controls.Add(Me.LongNum)
        Me.GroupBox1.Controls.Add(Me.DiameterNum)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 291)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "設定"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(118, 245)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 32)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "印刷開始"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(20, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "計算開始"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(233, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(357, 251)
        Me.DataGridView1.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "層"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 25
        '
        'Column2
        '
        Me.Column2.HeaderText = "繊維方向"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "長さ(mm)"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "幅(mm)"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(192, 218)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "mm"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(193, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "mm"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(193, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "mm"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(193, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "mm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(192, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "層"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "mm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "mm"
        '
        'Dimensions45Num
        '
        Me.Dimensions45Num.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.プリプレグ裁断寸法プログラム.My.MySettings.Default, "yoyuu45", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Dimensions45Num.Location = New System.Drawing.Point(117, 210)
        Me.Dimensions45Num.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Dimensions45Num.Name = "Dimensions45Num"
        Me.Dimensions45Num.Size = New System.Drawing.Size(69, 25)
        Me.Dimensions45Num.TabIndex = 6
        Me.Dimensions45Num.Value = Global.プリプレグ裁断寸法プログラム.My.MySettings.Default.yoyuu45
        '
        'DimensionsNum
        '
        Me.DimensionsNum.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.プリプレグ裁断寸法プログラム.My.MySettings.Default, "yoyuu", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DimensionsNum.Location = New System.Drawing.Point(117, 179)
        Me.DimensionsNum.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.DimensionsNum.Name = "DimensionsNum"
        Me.DimensionsNum.Size = New System.Drawing.Size(69, 25)
        Me.DimensionsNum.TabIndex = 5
        Me.DimensionsNum.Value = Global.プリプレグ裁断寸法プログラム.My.MySettings.Default.yoyuu
        '
        'lapNum
        '
        Me.lapNum.Location = New System.Drawing.Point(117, 148)
        Me.lapNum.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.lapNum.Name = "lapNum"
        Me.lapNum.Size = New System.Drawing.Size(69, 25)
        Me.lapNum.TabIndex = 4
        Me.lapNum.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'ThicknessNum
        '
        Me.ThicknessNum.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.プリプレグ裁断寸法プログラム.My.MySettings.Default, "atusa", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ThicknessNum.DecimalPlaces = 3
        Me.ThicknessNum.Location = New System.Drawing.Point(117, 117)
        Me.ThicknessNum.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.ThicknessNum.Name = "ThicknessNum"
        Me.ThicknessNum.Size = New System.Drawing.Size(69, 25)
        Me.ThicknessNum.TabIndex = 3
        Me.ThicknessNum.Value = Global.プリプレグ裁断寸法プログラム.My.MySettings.Default.atusa
        '
        'LayerNum
        '
        Me.LayerNum.Location = New System.Drawing.Point(117, 86)
        Me.LayerNum.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.LayerNum.Name = "LayerNum"
        Me.LayerNum.Size = New System.Drawing.Size(69, 25)
        Me.LayerNum.TabIndex = 2
        '
        'LongNum
        '
        Me.LongNum.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.プリプレグ裁断寸法プログラム.My.MySettings.Default, "nagasa", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LongNum.Location = New System.Drawing.Point(117, 55)
        Me.LongNum.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.LongNum.Name = "LongNum"
        Me.LongNum.Size = New System.Drawing.Size(69, 25)
        Me.LongNum.TabIndex = 1
        Me.LongNum.Value = Global.プリプレグ裁断寸法プログラム.My.MySettings.Default.nagasa
        '
        'DiameterNum
        '
        Me.DiameterNum.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.プリプレグ裁断寸法プログラム.My.MySettings.Default, "tyokkei", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DiameterNum.Location = New System.Drawing.Point(117, 24)
        Me.DiameterNum.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.DiameterNum.Name = "DiameterNum"
        Me.DiameterNum.Size = New System.Drawing.Size(69, 25)
        Me.DiameterNum.TabIndex = 0
        Me.DiameterNum.Value = Global.プリプレグ裁断寸法プログラム.My.MySettings.Default.tyokkei
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 212)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "45度の余裕寸法"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 181)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "パイプ余裕寸法"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 150)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "重ね代"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 119)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "プリプレグ厚さ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "積層数"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "パイプの長さ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "パイプの直径"
        '
        'BtOutputJSON
        '
        Me.BtOutputJSON.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtOutputJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtOutputJSON.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtOutputJSON.Location = New System.Drawing.Point(463, 6)
        Me.BtOutputJSON.Name = "BtOutputJSON"
        Me.BtOutputJSON.Size = New System.Drawing.Size(142, 32)
        Me.BtOutputJSON.TabIndex = 13
        Me.BtOutputJSON.Text = "最適化骨くん連携"
        Me.BtOutputJSON.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.Location = New System.Drawing.Point(420, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 17)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "mm"
        '
        'SplitWidthNum
        '
        Me.SplitWidthNum.Location = New System.Drawing.Point(345, 9)
        Me.SplitWidthNum.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.SplitWidthNum.Name = "SplitWidthNum"
        Me.SplitWidthNum.Size = New System.Drawing.Size(69, 25)
        Me.SplitWidthNum.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(251, 13)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 18)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "90度層 分割幅"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 338)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtOutputJSON)
        Me.Controls.Add(Me.SplitWidthNum)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DayTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "プリプレグ裁断寸法プログラム ver3.2.1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dimensions45Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DimensionsNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lapNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThicknessNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayerNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LongNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiameterNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitWidthNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ThicknessNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents LayerNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents LongNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents DiameterNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Dimensions45Num As System.Windows.Forms.NumericUpDown
    Friend WithEvents DimensionsNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents lapNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtOutputJSON As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents SplitWidthNum As NumericUpDown
    Friend WithEvents Label17 As Label
End Class
