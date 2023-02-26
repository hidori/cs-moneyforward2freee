# moneyforward2freee

MoneyForward 口座の「家計簿データの出力（CSV 形式）」を freee 口座の「明細アップロード（CSV 形式）」に変換します。

## 使用方法

以下のコマンドラインを実行すると、標準出力に変換結果を出力します。

### コマンドライン
```sh
moneyforward2freee ./example.csv
```

### 変換結果
```csv
Date,Amount,Description
2019/01/01,10000,購入 STARBUCKS COFFEE JAPAN
2019/01/02,4240,購入 PIZZA HUT
2019/01/07,-10000,カードチャージ
```
