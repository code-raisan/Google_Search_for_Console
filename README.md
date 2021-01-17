# Google Search for Console
コマンドラインからGoogle検索ができるアプリケーションです。
> このアプリケーションはGoogleとの関連は一切ありません

## 使い方
Google検索
```
> ggr [キーワード]
```

## インストール

十分な動作確認を実施してから公開していますが、予期せぬ不具合が発生する可能性もありますので、自己責任でご利用ください。


コマンドプロンプトまたはWindows PowerShellを起動して下記コマンドを入力してください。

```
PS> mkdir C:￥apps￥gsfc ←ここは任意のディレクトリを指定
PS> cd C:￥apps￥gsfc ←さっき作ったフォルダに移動

PS C:￥apps￥gsfc > curl https://limu.ml/daa9x -o ggr.exe ←ファイルをダウンロード(エラーが出る場合は下を参照)*1
PS C:￥apps￥gsfc > .￥ggr.exe @add--path ←どこでも使えるようにするためにPATHを通します

// 「成功 : 指定した値は保存されました」と出たらPATHの追加ができています
```
最後に ` ggr [キーワード]` と入力して検索が出来ればインストール成功です

> ご使用には、 Microsoft .NET Framework 4.7.2 が必要になります

### *1でエラーが出る場合

