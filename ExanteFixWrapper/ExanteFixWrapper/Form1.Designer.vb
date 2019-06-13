<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DrawLine0 = New System.Windows.Forms.Button()
        Me.ExanteIDTextBox0 = New System.Windows.Forms.TextBox()
        Me.SubscribreButton0 = New System.Windows.Forms.Button()
        Me.AskPriceLabel = New System.Windows.Forms.Label()
        Me.BidPriceLabel = New System.Windows.Forms.Label()
        Me.TradeVolumeLabel = New System.Windows.Forms.Label()
        Me.TradePriceLabel = New System.Windows.Forms.Label()
        Me.AddTab = New System.Windows.Forms.Button()
        Me.TabPage0 = New System.Windows.Forms.TabPage()
        Me.Charts0 = New System.Windows.Forms.TabControl()
        Me.QuotesTab0 = New System.Windows.Forms.TabPage()
        Me.PricesQuotesPctBox0 = New System.Windows.Forms.PictureBox()
        Me.MinusQuotesButton0 = New System.Windows.Forms.Button()
        Me.QuotesPctBox0 = New System.Windows.Forms.PictureBox()
        Me.PlusQuotesButton0 = New System.Windows.Forms.Button()
        Me.RightQuotesButton0 = New System.Windows.Forms.Button()
        Me.LeftQuotesButton0 = New System.Windows.Forms.Button()
        Me.TimesQuotesPctBox0 = New System.Windows.Forms.PictureBox()
        Me.TradesTab0 = New System.Windows.Forms.TabPage()
        Me.BorderPctBox = New System.Windows.Forms.PictureBox()
        Me.VolumesVolumesTradesPctBox0 = New System.Windows.Forms.PictureBox()
        Me.VolumesTradesPctBox0 = New System.Windows.Forms.PictureBox()
        Me.PricesTradesPctBox0 = New System.Windows.Forms.PictureBox()
        Me.MinusTradesButton0 = New System.Windows.Forms.Button()
        Me.TradesPctBox0 = New System.Windows.Forms.PictureBox()
        Me.PlusTradesButton0 = New System.Windows.Forms.Button()
        Me.RightButtonTrades0 = New System.Windows.Forms.Button()
        Me.TimesTradesPctBox0 = New System.Windows.Forms.PictureBox()
        Me.LeftTradesButton0 = New System.Windows.Forms.Button()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.TicksOrSeconds = New System.Windows.Forms.ComboBox()
        Me.TypeOfGraphic = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BuyAndSell = New System.Windows.Forms.RadioButton()
        Me.BuyPlusSell = New System.Windows.Forms.RadioButton()
        Me.Original = New System.Windows.Forms.CheckBox()
        Me.Average = New System.Windows.Forms.CheckBox()
        Me.WindowSizeTextBox = New System.Windows.Forms.TextBox()
        Me.WindowSizeBtn = New System.Windows.Forms.Button()
        Me.WindowsSizeLabel = New System.Windows.Forms.Label()
        Me.SetSensitivityButton = New System.Windows.Forms.Button()
        Me.SetSensitivityTextBox = New System.Windows.Forms.TextBox()
        Me.SetSensitivityLabel = New System.Windows.Forms.Label()
        Me.BuyOrderButton = New System.Windows.Forms.Button()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.SellOrderButton = New System.Windows.Forms.Button()
        Me.ListViewOrders = New System.Windows.Forms.ListView()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.ToEndButton = New System.Windows.Forms.Button()
        Me.TabPage0.SuspendLayout()
        Me.Charts0.SuspendLayout()
        Me.QuotesTab0.SuspendLayout()
        CType(Me.PricesQuotesPctBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotesPctBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimesQuotesPctBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TradesTab0.SuspendLayout()
        CType(Me.BorderPctBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumesVolumesTradesPctBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumesTradesPctBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PricesTradesPctBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradesPctBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimesTradesPctBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(141, 9)
        Me.ConnectButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(115, 28)
        Me.ConnectButton.TabIndex = 0
        Me.ConnectButton.Text = "Соединиться"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Нет соединения"
        '
        'DrawLine0
        '
        Me.DrawLine0.Location = New System.Drawing.Point(607, 102)
        Me.DrawLine0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DrawLine0.Name = "DrawLine0"
        Me.DrawLine0.Size = New System.Drawing.Size(212, 30)
        Me.DrawLine0.TabIndex = 32
        Me.DrawLine0.Text = "Рисовать линию"
        Me.DrawLine0.UseVisualStyleBackColor = True
        '
        'ExanteIDTextBox0
        '
        Me.ExanteIDTextBox0.Location = New System.Drawing.Point(264, 11)
        Me.ExanteIDTextBox0.Margin = New System.Windows.Forms.Padding(4)
        Me.ExanteIDTextBox0.Name = "ExanteIDTextBox0"
        Me.ExanteIDTextBox0.Size = New System.Drawing.Size(225, 22)
        Me.ExanteIDTextBox0.TabIndex = 2
        Me.ExanteIDTextBox0.Text = "TSLA.NASDAQ"
        '
        'SubscribreButton0
        '
        Me.SubscribreButton0.Location = New System.Drawing.Point(503, 9)
        Me.SubscribreButton0.Margin = New System.Windows.Forms.Padding(4)
        Me.SubscribreButton0.Name = "SubscribreButton0"
        Me.SubscribreButton0.Size = New System.Drawing.Size(147, 28)
        Me.SubscribreButton0.TabIndex = 11
        Me.SubscribreButton0.Text = "Подписаться"
        Me.SubscribreButton0.UseVisualStyleBackColor = True
        '
        'AskPriceLabel
        '
        Me.AskPriceLabel.AutoSize = True
        Me.AskPriceLabel.ForeColor = System.Drawing.Color.Red
        Me.AskPriceLabel.Location = New System.Drawing.Point(1403, 14)
        Me.AskPriceLabel.Name = "AskPriceLabel"
        Me.AskPriceLabel.Size = New System.Drawing.Size(13, 17)
        Me.AskPriceLabel.TabIndex = 39
        Me.AskPriceLabel.Text = "-"
        '
        'BidPriceLabel
        '
        Me.BidPriceLabel.AutoSize = True
        Me.BidPriceLabel.ForeColor = System.Drawing.Color.Blue
        Me.BidPriceLabel.Location = New System.Drawing.Point(1511, 14)
        Me.BidPriceLabel.Name = "BidPriceLabel"
        Me.BidPriceLabel.Size = New System.Drawing.Size(13, 17)
        Me.BidPriceLabel.TabIndex = 40
        Me.BidPriceLabel.Text = "-"
        '
        'TradeVolumeLabel
        '
        Me.TradeVolumeLabel.AutoSize = True
        Me.TradeVolumeLabel.ForeColor = System.Drawing.Color.Green
        Me.TradeVolumeLabel.Location = New System.Drawing.Point(1711, 14)
        Me.TradeVolumeLabel.Name = "TradeVolumeLabel"
        Me.TradeVolumeLabel.Size = New System.Drawing.Size(13, 17)
        Me.TradeVolumeLabel.TabIndex = 42
        Me.TradeVolumeLabel.Text = "-"
        '
        'TradePriceLabel
        '
        Me.TradePriceLabel.AutoSize = True
        Me.TradePriceLabel.ForeColor = System.Drawing.Color.Red
        Me.TradePriceLabel.Location = New System.Drawing.Point(1619, 14)
        Me.TradePriceLabel.Name = "TradePriceLabel"
        Me.TradePriceLabel.Size = New System.Drawing.Size(13, 17)
        Me.TradePriceLabel.TabIndex = 41
        Me.TradePriceLabel.Text = "-"
        '
        'AddTab
        '
        Me.AddTab.Location = New System.Drawing.Point(23, 47)
        Me.AddTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddTab.Name = "AddTab"
        Me.AddTab.Size = New System.Drawing.Size(233, 26)
        Me.AddTab.TabIndex = 43
        Me.AddTab.Text = "Добавить вкладку"
        Me.AddTab.UseVisualStyleBackColor = True
        '
        'TabPage0
        '
        Me.TabPage0.Controls.Add(Me.Charts0)
        Me.TabPage0.Location = New System.Drawing.Point(4, 25)
        Me.TabPage0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage0.Name = "TabPage0"
        Me.TabPage0.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage0.Size = New System.Drawing.Size(1709, 845)
        Me.TabPage0.TabIndex = 0
        Me.TabPage0.Text = "TabPage0"
        Me.TabPage0.UseVisualStyleBackColor = True
        '
        'Charts0
        '
        Me.Charts0.Controls.Add(Me.QuotesTab0)
        Me.Charts0.Controls.Add(Me.TradesTab0)
        Me.Charts0.Location = New System.Drawing.Point(3, 4)
        Me.Charts0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Charts0.Name = "Charts0"
        Me.Charts0.SelectedIndex = 0
        Me.Charts0.Size = New System.Drawing.Size(1697, 801)
        Me.Charts0.TabIndex = 30
        '
        'QuotesTab0
        '
        Me.QuotesTab0.Controls.Add(Me.PricesQuotesPctBox0)
        Me.QuotesTab0.Controls.Add(Me.MinusQuotesButton0)
        Me.QuotesTab0.Controls.Add(Me.QuotesPctBox0)
        Me.QuotesTab0.Controls.Add(Me.PlusQuotesButton0)
        Me.QuotesTab0.Controls.Add(Me.RightQuotesButton0)
        Me.QuotesTab0.Controls.Add(Me.LeftQuotesButton0)
        Me.QuotesTab0.Controls.Add(Me.TimesQuotesPctBox0)
        Me.QuotesTab0.Location = New System.Drawing.Point(4, 25)
        Me.QuotesTab0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuotesTab0.Name = "QuotesTab0"
        Me.QuotesTab0.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuotesTab0.Size = New System.Drawing.Size(1689, 772)
        Me.QuotesTab0.TabIndex = 0
        Me.QuotesTab0.Text = "Аск / Бид"
        Me.QuotesTab0.UseVisualStyleBackColor = True
        '
        'PricesQuotesPctBox0
        '
        Me.PricesQuotesPctBox0.Location = New System.Drawing.Point(3, 0)
        Me.PricesQuotesPctBox0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PricesQuotesPctBox0.Name = "PricesQuotesPctBox0"
        Me.PricesQuotesPctBox0.Size = New System.Drawing.Size(105, 727)
        Me.PricesQuotesPctBox0.TabIndex = 20
        Me.PricesQuotesPctBox0.TabStop = False
        '
        'MinusQuotesButton0
        '
        Me.MinusQuotesButton0.Location = New System.Drawing.Point(1635, 336)
        Me.MinusQuotesButton0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinusQuotesButton0.Name = "MinusQuotesButton0"
        Me.MinusQuotesButton0.Size = New System.Drawing.Size(47, 318)
        Me.MinusQuotesButton0.TabIndex = 29
        Me.MinusQuotesButton0.Text = "-"
        Me.MinusQuotesButton0.UseVisualStyleBackColor = True
        '
        'QuotesPctBox0
        '
        Me.QuotesPctBox0.Location = New System.Drawing.Point(108, 0)
        Me.QuotesPctBox0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuotesPctBox0.Name = "QuotesPctBox0"
        Me.QuotesPctBox0.Size = New System.Drawing.Size(1579, 727)
        Me.QuotesPctBox0.TabIndex = 18
        Me.QuotesPctBox0.TabStop = False
        '
        'PlusQuotesButton0
        '
        Me.PlusQuotesButton0.Location = New System.Drawing.Point(1635, 2)
        Me.PlusQuotesButton0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PlusQuotesButton0.Name = "PlusQuotesButton0"
        Me.PlusQuotesButton0.Size = New System.Drawing.Size(48, 327)
        Me.PlusQuotesButton0.TabIndex = 28
        Me.PlusQuotesButton0.Text = "+"
        Me.PlusQuotesButton0.UseVisualStyleBackColor = True
        '
        'RightQuotesButton0
        '
        Me.RightQuotesButton0.Location = New System.Drawing.Point(869, 734)
        Me.RightQuotesButton0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RightQuotesButton0.Name = "RightQuotesButton0"
        Me.RightQuotesButton0.Size = New System.Drawing.Size(741, 33)
        Me.RightQuotesButton0.TabIndex = 27
        Me.RightQuotesButton0.Text = "Right ->"
        Me.RightQuotesButton0.UseVisualStyleBackColor = True
        '
        'LeftQuotesButton0
        '
        Me.LeftQuotesButton0.Location = New System.Drawing.Point(108, 734)
        Me.LeftQuotesButton0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LeftQuotesButton0.Name = "LeftQuotesButton0"
        Me.LeftQuotesButton0.Size = New System.Drawing.Size(773, 33)
        Me.LeftQuotesButton0.TabIndex = 26
        Me.LeftQuotesButton0.Text = "<- Left"
        Me.LeftQuotesButton0.UseVisualStyleBackColor = True
        '
        'TimesQuotesPctBox0
        '
        Me.TimesQuotesPctBox0.Location = New System.Drawing.Point(107, 731)
        Me.TimesQuotesPctBox0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimesQuotesPctBox0.Name = "TimesQuotesPctBox0"
        Me.TimesQuotesPctBox0.Size = New System.Drawing.Size(1576, 36)
        Me.TimesQuotesPctBox0.TabIndex = 22
        Me.TimesQuotesPctBox0.TabStop = False
        '
        'TradesTab0
        '
        Me.TradesTab0.Controls.Add(Me.BorderPctBox)
        Me.TradesTab0.Controls.Add(Me.VolumesVolumesTradesPctBox0)
        Me.TradesTab0.Controls.Add(Me.VolumesTradesPctBox0)
        Me.TradesTab0.Controls.Add(Me.PricesTradesPctBox0)
        Me.TradesTab0.Controls.Add(Me.MinusTradesButton0)
        Me.TradesTab0.Controls.Add(Me.TradesPctBox0)
        Me.TradesTab0.Controls.Add(Me.PlusTradesButton0)
        Me.TradesTab0.Controls.Add(Me.RightButtonTrades0)
        Me.TradesTab0.Controls.Add(Me.TimesTradesPctBox0)
        Me.TradesTab0.Controls.Add(Me.LeftTradesButton0)
        Me.TradesTab0.Location = New System.Drawing.Point(4, 25)
        Me.TradesTab0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TradesTab0.Name = "TradesTab0"
        Me.TradesTab0.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TradesTab0.Size = New System.Drawing.Size(1689, 772)
        Me.TradesTab0.TabIndex = 1
        Me.TradesTab0.Text = "Сделки"
        Me.TradesTab0.UseVisualStyleBackColor = True
        '
        'BorderPctBox
        '
        Me.BorderPctBox.BackColor = System.Drawing.Color.LightGray
        Me.BorderPctBox.Location = New System.Drawing.Point(107, 425)
        Me.BorderPctBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BorderPctBox.Name = "BorderPctBox"
        Me.BorderPctBox.Size = New System.Drawing.Size(1573, 5)
        Me.BorderPctBox.TabIndex = 40
        Me.BorderPctBox.TabStop = False
        '
        'VolumesVolumesTradesPctBox0
        '
        Me.VolumesVolumesTradesPctBox0.Location = New System.Drawing.Point(3, 431)
        Me.VolumesVolumesTradesPctBox0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VolumesVolumesTradesPctBox0.Name = "VolumesVolumesTradesPctBox0"
        Me.VolumesVolumesTradesPctBox0.Size = New System.Drawing.Size(105, 295)
        Me.VolumesVolumesTradesPctBox0.TabIndex = 39
        Me.VolumesVolumesTradesPctBox0.TabStop = False
        '
        'VolumesTradesPctBox0
        '
        Me.VolumesTradesPctBox0.Location = New System.Drawing.Point(108, 431)
        Me.VolumesTradesPctBox0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VolumesTradesPctBox0.Name = "VolumesTradesPctBox0"
        Me.VolumesTradesPctBox0.Size = New System.Drawing.Size(1572, 295)
        Me.VolumesTradesPctBox0.TabIndex = 38
        Me.VolumesTradesPctBox0.TabStop = False
        '
        'PricesTradesPctBox0
        '
        Me.PricesTradesPctBox0.Location = New System.Drawing.Point(3, 0)
        Me.PricesTradesPctBox0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PricesTradesPctBox0.Name = "PricesTradesPctBox0"
        Me.PricesTradesPctBox0.Size = New System.Drawing.Size(105, 425)
        Me.PricesTradesPctBox0.TabIndex = 37
        Me.PricesTradesPctBox0.TabStop = False
        '
        'MinusTradesButton0
        '
        Me.MinusTradesButton0.Location = New System.Drawing.Point(1635, 353)
        Me.MinusTradesButton0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinusTradesButton0.Name = "MinusTradesButton0"
        Me.MinusTradesButton0.Size = New System.Drawing.Size(47, 345)
        Me.MinusTradesButton0.TabIndex = 36
        Me.MinusTradesButton0.Text = "-"
        Me.MinusTradesButton0.UseVisualStyleBackColor = True
        '
        'TradesPctBox0
        '
        Me.TradesPctBox0.Location = New System.Drawing.Point(108, 0)
        Me.TradesPctBox0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TradesPctBox0.Name = "TradesPctBox0"
        Me.TradesPctBox0.Size = New System.Drawing.Size(1572, 425)
        Me.TradesPctBox0.TabIndex = 30
        Me.TradesPctBox0.TabStop = False
        '
        'PlusTradesButton0
        '
        Me.PlusTradesButton0.Location = New System.Drawing.Point(1635, 6)
        Me.PlusTradesButton0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PlusTradesButton0.Name = "PlusTradesButton0"
        Me.PlusTradesButton0.Size = New System.Drawing.Size(48, 341)
        Me.PlusTradesButton0.TabIndex = 35
        Me.PlusTradesButton0.Text = "+"
        Me.PlusTradesButton0.UseVisualStyleBackColor = True
        '
        'RightButtonTrades0
        '
        Me.RightButtonTrades0.Location = New System.Drawing.Point(869, 734)
        Me.RightButtonTrades0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RightButtonTrades0.Name = "RightButtonTrades0"
        Me.RightButtonTrades0.Size = New System.Drawing.Size(759, 33)
        Me.RightButtonTrades0.TabIndex = 34
        Me.RightButtonTrades0.Text = "Right ->"
        Me.RightButtonTrades0.UseVisualStyleBackColor = True
        '
        'TimesTradesPctBox0
        '
        Me.TimesTradesPctBox0.Location = New System.Drawing.Point(107, 730)
        Me.TimesTradesPctBox0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimesTradesPctBox0.Name = "TimesTradesPctBox0"
        Me.TimesTradesPctBox0.Size = New System.Drawing.Size(1572, 36)
        Me.TimesTradesPctBox0.TabIndex = 32
        Me.TimesTradesPctBox0.TabStop = False
        '
        'LeftTradesButton0
        '
        Me.LeftTradesButton0.Location = New System.Drawing.Point(108, 730)
        Me.LeftTradesButton0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LeftTradesButton0.Name = "LeftTradesButton0"
        Me.LeftTradesButton0.Size = New System.Drawing.Size(756, 33)
        Me.LeftTradesButton0.TabIndex = 33
        Me.LeftTradesButton0.Text = "<- Left"
        Me.LeftTradesButton0.UseVisualStyleBackColor = True
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabPage0)
        Me.Tabs.Location = New System.Drawing.Point(23, 119)
        Me.Tabs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(1717, 874)
        Me.Tabs.TabIndex = 31
        '
        'TicksOrSeconds
        '
        Me.TicksOrSeconds.FormattingEnabled = True
        Me.TicksOrSeconds.Items.AddRange(New Object() {"Тики", "5 секунд", "10 секунд", "15 секунд", "30 секунд", "1 минута", "5 минут", "10 минут", "15 минут", "30 минут", "1 час"})
        Me.TicksOrSeconds.Location = New System.Drawing.Point(264, 46)
        Me.TicksOrSeconds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TicksOrSeconds.Name = "TicksOrSeconds"
        Me.TicksOrSeconds.Size = New System.Drawing.Size(225, 24)
        Me.TicksOrSeconds.TabIndex = 44
        '
        'TypeOfGraphic
        '
        Me.TypeOfGraphic.FormattingEnabled = True
        Me.TypeOfGraphic.Items.AddRange(New Object() {"Линии", "Японские свечи", "Бары"})
        Me.TypeOfGraphic.Location = New System.Drawing.Point(264, 79)
        Me.TypeOfGraphic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TypeOfGraphic.Name = "TypeOfGraphic"
        Me.TypeOfGraphic.Size = New System.Drawing.Size(227, 24)
        Me.TypeOfGraphic.TabIndex = 45
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(23, 78)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(233, 26)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Добавить окно"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BuyAndSell
        '
        Me.BuyAndSell.AutoSize = True
        Me.BuyAndSell.Location = New System.Drawing.Point(669, 78)
        Me.BuyAndSell.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BuyAndSell.Name = "BuyAndSell"
        Me.BuyAndSell.Size = New System.Drawing.Size(219, 21)
        Me.BuyAndSell.TabIndex = 47
        Me.BuyAndSell.TabStop = True
        Me.BuyAndSell.Text = "Покупка / продажа отдельно"
        Me.BuyAndSell.UseVisualStyleBackColor = True
        '
        'BuyPlusSell
        '
        Me.BuyPlusSell.AutoSize = True
        Me.BuyPlusSell.Location = New System.Drawing.Point(503, 78)
        Me.BuyPlusSell.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BuyPlusSell.Name = "BuyPlusSell"
        Me.BuyPlusSell.Size = New System.Drawing.Size(151, 21)
        Me.BuyPlusSell.TabIndex = 49
        Me.BuyPlusSell.TabStop = True
        Me.BuyPlusSell.Text = "Покупка+Продажа"
        Me.BuyPlusSell.UseVisualStyleBackColor = True
        '
        'Original
        '
        Me.Original.AutoSize = True
        Me.Original.Checked = True
        Me.Original.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Original.Location = New System.Drawing.Point(669, 46)
        Me.Original.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Original.Name = "Original"
        Me.Original.Size = New System.Drawing.Size(85, 21)
        Me.Original.TabIndex = 50
        Me.Original.Text = "Объемы"
        Me.Original.UseVisualStyleBackColor = True
        '
        'Average
        '
        Me.Average.AutoSize = True
        Me.Average.Location = New System.Drawing.Point(503, 44)
        Me.Average.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Average.Name = "Average"
        Me.Average.Size = New System.Drawing.Size(129, 21)
        Me.Average.TabIndex = 51
        Me.Average.Text = "Сглаживающая"
        Me.Average.UseVisualStyleBackColor = True
        '
        'WindowSizeTextBox
        '
        Me.WindowSizeTextBox.Location = New System.Drawing.Point(805, 12)
        Me.WindowSizeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WindowSizeTextBox.Name = "WindowSizeTextBox"
        Me.WindowSizeTextBox.Size = New System.Drawing.Size(37, 22)
        Me.WindowSizeTextBox.TabIndex = 52
        Me.WindowSizeTextBox.Text = "5"
        '
        'WindowSizeBtn
        '
        Me.WindowSizeBtn.Location = New System.Drawing.Point(848, 10)
        Me.WindowSizeBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WindowSizeBtn.Name = "WindowSizeBtn"
        Me.WindowSizeBtn.Size = New System.Drawing.Size(117, 27)
        Me.WindowSizeBtn.TabIndex = 53
        Me.WindowSizeBtn.Text = "Применить"
        Me.WindowSizeBtn.UseVisualStyleBackColor = True
        '
        'WindowsSizeLabel
        '
        Me.WindowsSizeLabel.AutoSize = True
        Me.WindowsSizeLabel.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.WindowsSizeLabel.Location = New System.Drawing.Point(657, 14)
        Me.WindowsSizeLabel.Name = "WindowsSizeLabel"
        Me.WindowsSizeLabel.Size = New System.Drawing.Size(142, 17)
        Me.WindowsSizeLabel.TabIndex = 55
        Me.WindowsSizeLabel.Text = "Задать размер окна"
        '
        'SetSensitivityButton
        '
        Me.SetSensitivityButton.Location = New System.Drawing.Point(1277, 11)
        Me.SetSensitivityButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SetSensitivityButton.Name = "SetSensitivityButton"
        Me.SetSensitivityButton.Size = New System.Drawing.Size(99, 28)
        Me.SetSensitivityButton.TabIndex = 56
        Me.SetSensitivityButton.Text = "Применить"
        Me.SetSensitivityButton.UseVisualStyleBackColor = True
        '
        'SetSensitivityTextBox
        '
        Me.SetSensitivityTextBox.Location = New System.Drawing.Point(1205, 12)
        Me.SetSensitivityTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SetSensitivityTextBox.Name = "SetSensitivityTextBox"
        Me.SetSensitivityTextBox.Size = New System.Drawing.Size(65, 22)
        Me.SetSensitivityTextBox.TabIndex = 57
        Me.SetSensitivityTextBox.Text = "10"
        '
        'SetSensitivityLabel
        '
        Me.SetSensitivityLabel.AutoSize = True
        Me.SetSensitivityLabel.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.SetSensitivityLabel.Location = New System.Drawing.Point(971, 15)
        Me.SetSensitivityLabel.Name = "SetSensitivityLabel"
        Me.SetSensitivityLabel.Size = New System.Drawing.Size(219, 17)
        Me.SetSensitivityLabel.TabIndex = 58
        Me.SetSensitivityLabel.Text = "Задать чувствительность мыши"
        '
        'BuyOrderButton
        '
        Me.BuyOrderButton.Location = New System.Drawing.Point(905, 38)
        Me.BuyOrderButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BuyOrderButton.Name = "BuyOrderButton"
        Me.BuyOrderButton.Size = New System.Drawing.Size(133, 28)
        Me.BuyOrderButton.TabIndex = 59
        Me.BuyOrderButton.Text = "Купить"
        Me.BuyOrderButton.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(768, 43)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(132, 22)
        Me.QuantityTextBox.TabIndex = 60
        '
        'SellOrderButton
        '
        Me.SellOrderButton.Location = New System.Drawing.Point(907, 70)
        Me.SellOrderButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SellOrderButton.Name = "SellOrderButton"
        Me.SellOrderButton.Size = New System.Drawing.Size(133, 28)
        Me.SellOrderButton.TabIndex = 61
        Me.SellOrderButton.Text = "Продать"
        Me.SellOrderButton.UseVisualStyleBackColor = True
        '
        'ListViewOrders
        '
        Me.ListViewOrders.Location = New System.Drawing.Point(1047, 43)
        Me.ListViewOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.ListViewOrders.Name = "ListViewOrders"
        Me.ListViewOrders.Size = New System.Drawing.Size(687, 90)
        Me.ListViewOrders.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.ListViewOrders.TabIndex = 62
        Me.ListViewOrders.UseCompatibleStateImageBehavior = False
        Me.ListViewOrders.View = System.Windows.Forms.View.Details
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(907, 102)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(133, 28)
        Me.RefreshButton.TabIndex = 63
        Me.RefreshButton.Text = "Обновить"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'ToEndButton
        '
        Me.ToEndButton.Location = New System.Drawing.Point(824, 103)
        Me.ToEndButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ToEndButton.Name = "ToEndButton"
        Me.ToEndButton.Size = New System.Drawing.Size(75, 28)
        Me.ToEndButton.TabIndex = 54
        Me.ToEndButton.Text = "->>"
        Me.ToEndButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1882, 1037)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.ListViewOrders)
        Me.Controls.Add(Me.SellOrderButton)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.BuyOrderButton)
        Me.Controls.Add(Me.SetSensitivityLabel)
        Me.Controls.Add(Me.SetSensitivityTextBox)
        Me.Controls.Add(Me.SetSensitivityButton)
        Me.Controls.Add(Me.WindowsSizeLabel)
        Me.Controls.Add(Me.ToEndButton)
        Me.Controls.Add(Me.WindowSizeBtn)
        Me.Controls.Add(Me.WindowSizeTextBox)
        Me.Controls.Add(Me.Average)
        Me.Controls.Add(Me.Original)
        Me.Controls.Add(Me.BuyPlusSell)
        Me.Controls.Add(Me.BuyAndSell)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TypeOfGraphic)
        Me.Controls.Add(Me.TicksOrSeconds)
        Me.Controls.Add(Me.AddTab)
        Me.Controls.Add(Me.TradeVolumeLabel)
        Me.Controls.Add(Me.BidPriceLabel)
        Me.Controls.Add(Me.AskPriceLabel)
        Me.Controls.Add(Me.TradePriceLabel)
        Me.Controls.Add(Me.DrawLine0)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.ExanteIDTextBox0)
        Me.Controls.Add(Me.SubscribreButton0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "A&K Trader 1.0"
        Me.TabPage0.ResumeLayout(False)
        Me.Charts0.ResumeLayout(False)
        Me.QuotesTab0.ResumeLayout(False)
        CType(Me.PricesQuotesPctBox0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotesPctBox0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimesQuotesPctBox0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TradesTab0.ResumeLayout(False)
        CType(Me.BorderPctBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumesVolumesTradesPctBox0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumesTradesPctBox0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PricesTradesPctBox0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradesPctBox0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimesTradesPctBox0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConnectButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DrawLine0 As Button
    Friend WithEvents ExanteIDTextBox0 As TextBox
    Friend WithEvents SubscribreButton0 As Button
    Friend WithEvents AskPriceLabel As Label
    Friend WithEvents BidPriceLabel As Label
    Friend WithEvents TradeVolumeLabel As Label
    Friend WithEvents TradePriceLabel As Label
    Friend WithEvents AddTab As Button
    Friend WithEvents TabPage0 As TabPage
    Friend WithEvents Charts0 As TabControl
    Friend WithEvents QuotesTab0 As TabPage
    Friend WithEvents PricesQuotesPctBox0 As PictureBox
    Friend WithEvents MinusQuotesButton0 As Button
    Friend WithEvents QuotesPctBox0 As PictureBox
    Friend WithEvents PlusQuotesButton0 As Button
    Friend WithEvents RightQuotesButton0 As Button
    Friend WithEvents LeftQuotesButton0 As Button
    Friend WithEvents TimesQuotesPctBox0 As PictureBox
    Friend WithEvents TradesTab0 As TabPage
    Friend WithEvents VolumesVolumesTradesPctBox0 As PictureBox
    Friend WithEvents VolumesTradesPctBox0 As PictureBox
    Friend WithEvents PricesTradesPctBox0 As PictureBox
    Friend WithEvents MinusTradesButton0 As Button
    Friend WithEvents TradesPctBox0 As PictureBox
    Friend WithEvents PlusTradesButton0 As Button
    Friend WithEvents RightButtonTrades0 As Button
    Friend WithEvents LeftTradesButton0 As Button
    Friend WithEvents TimesTradesPctBox0 As PictureBox
    Friend WithEvents Tabs As TabControl
    Friend WithEvents TicksOrSeconds As ComboBox
    Friend WithEvents TypeOfGraphic As ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BuyAndSell As RadioButton
    Friend WithEvents BuyPlusSell As RadioButton
    Friend WithEvents Original As CheckBox
    Friend WithEvents Average As CheckBox
    Friend WithEvents WindowSizeTextBox As TextBox
    Friend WithEvents WindowSizeBtn As Button
    Friend WithEvents BorderPctBox As PictureBox
    Friend WithEvents WindowsSizeLabel As Label
    Friend WithEvents SetSensitivityButton As Button
    Friend WithEvents SetSensitivityTextBox As TextBox
    Friend WithEvents SetSensitivityLabel As Label
    Friend WithEvents BuyOrderButton As System.Windows.Forms.Button
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SellOrderButton As System.Windows.Forms.Button
    Friend WithEvents ListViewOrders As System.Windows.Forms.ListView
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents ToEndButton As Button
End Class
