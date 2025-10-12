# C# / .NET スキルアップ 3か月プラン（週次タスク表）

## 🧩 フェーズ1：基礎構造の再構築（1〜4週）

### Week 1：文法整理とC#らしい書き方の理解
- 『独習C# 新版』の第1〜6章を通読
- 代表的な構文（var / using / async / lambda）を試す
- サンプル課題：「ファイルを非同期で読み込み、行数をカウントするツール」を作る
- レビュー観点ノート：「可読性の高い命名」「例外処理の基本」

### Week 2：オブジェクト指向と責務分離
- クラス・インターフェース・継承・ポリモーフィズムの動作を理解
- 「責務ごとにクラスを分ける」練習（例：ロガー／データローダー）
- 『Clean Code』第1〜6章を読む
- レビュー観点ノート：「1メソッド1責務」「命名規則」「依存方向の確認」

### Week 3：LINQとラムダ式
- LINQクエリ式とメソッドチェーンの違いを理解
- `Select` / `Where` / `GroupBy` / `Aggregate` / `Any` / `All`
- パフォーマンス（遅延実行）の確認
- サンプル課題：「CSVデータをLINQで集計」
- レビュー観点ノート：「式の短さより意図の明確さ」

### Week 4：例外処理・リソース管理
- `IDisposable` と `using` / `DisposeAsync` の理解
- try-catch-finallyの正しい適用範囲
- 『C# in Depth』第4章を読む（using, async/await）
- サンプル課題：「外部ファイル＋HTTP通信を伴う簡易ツール」
- レビュー観点ノート：「例外の握り潰し禁止」「Dispose責務の明確化」


## ⚙️ フェーズ2：.NET基盤理解（5〜8週）

### Week 5：非同期処理モデルとTask
- `Task`, `Task<T>`, `async/await` の動作モデルを理解
- 非同期メソッドチェーンの挙動確認
- サンプル課題：「複数APIを並列で呼び出すミニツール」
- 『C# in Depth』第14〜16章
- レビュー観点ノート：「async void禁止」「キャンセルトークン対応」

### Week 6：GCとメモリモデルの理解
- 『Pro .NET Memory Management』第1〜4章を読む
- GCの世代構造、LOH、POHの動作を観察（`dotnet-counters`使用）
- サンプル課題：「大量のオブジェクト生成でGC挙動観察」
- レビュー観点ノート：「使い捨て配列やListの扱い」

### Week 7：依存性注入（DI）
- Microsoft.Extensions.DependencyInjectionの使い方
- ライフタイム（Transient / Scoped / Singleton）の違い
- 小規模なDIサンプルを構築
- 『Dependency Injection in .NET』第2〜5章
- レビュー観点ノート：「コンストラクタ注入」「サービススコープの乱用防止」

### Week 8：Entity Framework Core と LINQ to SQL
- DbContextのライフタイムと接続管理を学ぶ
- 遅延実行と即時実行の違いを検証
- サンプル課題：「InMemoryDBを使ったCRUD検証」
- レビュー観点ノート：「DBアクセスの責務分離」「N+1クエリ防止」


## 🧠 フェーズ3：実践とレビュー強化（9〜12週）

### Week 9：クリーンアーキテクチャの導入
- 『Clean Architecture』第1〜6章を読む
- 層構造と依存方向を理解（Domain / Application / Infrastructure / UI）
- 自社プロジェクト構造と対比して整理
- レビュー観点ノート：「UIからDB層への直接依存禁止」

### Week 10：非同期とリソースの統合設計
- TaskとDisposeの組み合わせ（`IAsyncDisposable`）
- Stream・Socketなどを伴うケースで例外ハンドリングの整理
- サンプル課題：「非同期通信＋ログ出力の小アプリ」
- レビュー観点ノート：「リソースリーク防止」「await後の状態保持」

### Week 11：パフォーマンス／スレッドプール観察
- `ThreadPool`, `Parallel.ForEach`, `ConcurrentQueue` の挙動を理解
- サンプル課題：「並列処理＋ロギング付きテストツール」
- `dotnet-trace`, `PerfView`で分析
- レビュー観点ノート：「ボトルネックの見分け方」

### Week 12：レビュー力の総仕上げ
- 実プロジェクトコードを題材に模擬レビュー会
- 自分の観点ノートをチーム向けに整理
- 「レビュー観点リスト（チェックリスト形式）」を完成させる
- 『Clean Code』の「良いコードとは」を再確認
