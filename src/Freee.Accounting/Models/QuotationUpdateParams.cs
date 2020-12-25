/*
 * freee API
 *
 *  <h1 id=\"freee_api\">freee API</h1> <hr /> <h2 id=\"start_guide\">スタートガイド</h2>  <p>freee API開発がはじめての方は<a href=\"https://developer.freee.co.jp/getting-started\">freee API スタートガイド</a>を参照してください。</p>  <hr /> <h2 id=\"specification\">仕様</h2>  <pre><code>【重要】会計freee APIの新バージョンについて 2020年12月まで、2つのバージョンが利用できる状態です。古いものは2020年12月に利用不可となります。<br> 新しいAPIを利用するにはリクエストヘッダーに以下を指定します。 X-Api-Version: 2020-06-15<br> 指定がない場合は2020年12月に廃止予定のAPIを利用することとなります。<br> 【重要】APIのバージョン指定をせずに利用し続ける場合 2020年12月に新しいバージョンのAPIに自動的に切り替わります。 詳細は、<a href=\"https://developer.freee.co.jp/release-note/2948\" target=\"_blank\">リリースノート</a>をご覧ください。<br> 旧バージョンのAPIリファレンスを確認したい場合は、<a href=\"https://freee.github.io/freee-api-schema/\" target=\"_blank\">旧バージョンのAPIリファレンスページ</a>をご覧ください。 </code></pre>  <h3 id=\"api_endpoint\">APIエンドポイント</h3>  <p>https://api.freee.co.jp/ (httpsのみ)</p>  <h3 id=\"about_authorize\">認証について</h3> <p>OAuth2.0を利用します。詳細は<a href=\"https://developer.freee.co.jp/docs\" target=\"_blank\">ドキュメントの認証</a>パートを参照してください。</p>  <h3 id=\"data_format\">データフォーマット</h3>  <p>リクエスト、レスポンスともにJSON形式をサポートしていますが、詳細は、API毎の説明欄（application/jsonなど）を確認してください。</p>  <h3 id=\"compatibility\">後方互換性ありの変更</h3>  <p>freeeでは、APIを改善していくために以下のような変更は後方互換性ありとして通知なく変更を入れることがあります。アプリケーション実装者は以下を踏まえて開発を行ってください。</p>  <ul> <li>新しいAPIリソース・エンドポイントの追加</li> <li>既存のAPIに対して必須ではない新しいリクエストパラメータの追加</li> <li>既存のAPIレスポンスに対する新しいプロパティの追加</li> <li>既存のAPIレスポンスに対するプロパティの順番の入れ変え</li> <li>keyとなっているidやcodeの長さの変更（長くする）</li> </ul>  <h3 id=\"common_response_header\">共通レスポンスヘッダー</h3>  <p>すべてのAPIのレスポンスには以下のHTTPヘッダーが含まれます。</p>  <ul> <li> <p>X-Freee-Request-ID</p> <ul> <li>各リクエスト毎に発行されるID</li> </ul> </li> </ul>  <h3 id=\"common_error_response\">共通エラーレスポンス</h3>  <ul> <li> <p>ステータスコードはレスポンス内のJSONに含まれる他、HTTPヘッダにも含まれる</p> </li> <li> <p>一部のエラーレスポンスにはエラーコードが含まれます。<br>詳細は、<a href=\"https://developer.freee.co.jp/tips/faq/40x-checkpoint\">HTTPステータスコード400台エラー時のチェックポイント</a>を参照してください</p> </li> <p>type</p>  <ul> <li>status : HTTPステータスコードの説明</li>  <li>validation : エラーの詳細の説明（開発者向け）</li> </ul> </li> </ul>  <p>レスポンスの例</p>  <pre><code>  {     &quot;status_code&quot; : 400,     &quot;errors&quot; : [       {         &quot;type&quot; : &quot;status&quot;,         &quot;messages&quot; : [&quot;不正なリクエストです。&quot;]       },       {         &quot;type&quot; : &quot;validation&quot;,         &quot;messages&quot; : [&quot;Date は不正な日付フォーマットです。入力例：2013-01-01&quot;]       }     ]   }</code></pre>  </br>  <h3 id=\"api_rate_limit\">API使用制限</h3>    <p>freeeは一定期間に過度のアクセスを検知した場合、APIアクセスをコントロールする場合があります。</p>   <p>その際のhttp status codeは403となります。制限がかかってから10分程度が過ぎると再度使用することができるようになります。</p>  <h4 id=\"reports_api_endpoint\">/reportsエンドポイント</h4>  <p>freeeは/reportsエンドポイントに対して1秒間に10以上のアクセスを検知した場合、APIアクセスをコントロールする場合があります。その際のhttp status codeは429（too many requests）となります。</p>  <p>レスポンスボディのmetaプロパティに以下を含めます。</p>  <ul>   <li>設定されている上限値</li>   <li>上限に達するまでの使用可能回数</li>   <li>（上限値に達した場合）使用回数がリセットされる時刻</li> </ul>  <h3 id=\"plan_api_rate_limit\">プラン別のAPI Rate Limit</h3>   <table border=\"1\">     <tbody>       <tr>         <th style=\"padding: 10px\"><strong>会計freeeプラン名</strong></th>         <th style=\"padding: 10px\"><strong>事業所とアプリケーション毎に1日でのAPIコール数</strong></th>       </tr>       <tr>         <td style=\"padding: 10px\">エンタープライズ</td>         <td style=\"padding: 10px\">10,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">プロフェッショナル</td>         <td style=\"padding: 10px\">5,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ベーシック</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ミニマム</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">上記以外</td>         <td style=\"padding: 10px\">3,000</td>       </tr>     </tbody>   </table>  <h3 id=\"webhook\">Webhookについて</h3>  <p>詳細は<a href=\"https://developer.freee.co.jp/docs/accounting/webhook\" target=\"_blank\">会計Webhook概要</a>を参照してください。</p>  <hr /> <h2 id=\"contact\">連絡先</h2>  <p>ご不明点、ご要望等は <a href=\"https://support.freee.co.jp/hc/ja/requests/new\">freee サポートデスクへのお問い合わせフォーム</a> からご連絡ください。</p> <hr />&copy; Since 2013 freee K.K.
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Freee.Accounting.Client.OpenAPIDateConverter;

namespace Freee.Accounting.Models
{
    /// <summary>
    /// QuotationUpdateParams
    /// </summary>
    [DataContract(Name = "quotationUpdateParams")]
    public partial class QuotationUpdateParams : IEquatable<QuotationUpdateParams>
    {
        /// <summary>
        /// 見積書レイアウト * &#x60;default_classic&#x60; - レイアウト１/クラシック (デフォルト)  * &#x60;standard_classic&#x60; - レイアウト２/クラシック  * &#x60;envelope_classic&#x60; - 封筒１/クラシック  * &#x60;default_modern&#x60; - レイアウト１/モダン  * &#x60;standard_modern&#x60; - レイアウト２/モダン  * &#x60;envelope_modern&#x60; - 封筒/モダン
        /// </summary>
        /// <value>見積書レイアウト * &#x60;default_classic&#x60; - レイアウト１/クラシック (デフォルト)  * &#x60;standard_classic&#x60; - レイアウト２/クラシック  * &#x60;envelope_classic&#x60; - 封筒１/クラシック  * &#x60;default_modern&#x60; - レイアウト１/モダン  * &#x60;standard_modern&#x60; - レイアウト２/モダン  * &#x60;envelope_modern&#x60; - 封筒/モダン</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QuotationLayoutEnum
        {
            /// <summary>
            /// Enum Defaultclassic for value: default_classic
            /// </summary>
            [EnumMember(Value = "default_classic")]
            Defaultclassic = 1,

            /// <summary>
            /// Enum Standardclassic for value: standard_classic
            /// </summary>
            [EnumMember(Value = "standard_classic")]
            Standardclassic = 2,

            /// <summary>
            /// Enum Envelopeclassic for value: envelope_classic
            /// </summary>
            [EnumMember(Value = "envelope_classic")]
            Envelopeclassic = 3,

            /// <summary>
            /// Enum Defaultmodern for value: default_modern
            /// </summary>
            [EnumMember(Value = "default_modern")]
            Defaultmodern = 4,

            /// <summary>
            /// Enum Standardmodern for value: standard_modern
            /// </summary>
            [EnumMember(Value = "standard_modern")]
            Standardmodern = 5,

            /// <summary>
            /// Enum Envelopemodern for value: envelope_modern
            /// </summary>
            [EnumMember(Value = "envelope_modern")]
            Envelopemodern = 6

        }

        /// <summary>
        /// 見積書レイアウト * &#x60;default_classic&#x60; - レイアウト１/クラシック (デフォルト)  * &#x60;standard_classic&#x60; - レイアウト２/クラシック  * &#x60;envelope_classic&#x60; - 封筒１/クラシック  * &#x60;default_modern&#x60; - レイアウト１/モダン  * &#x60;standard_modern&#x60; - レイアウト２/モダン  * &#x60;envelope_modern&#x60; - 封筒/モダン
        /// </summary>
        /// <value>見積書レイアウト * &#x60;default_classic&#x60; - レイアウト１/クラシック (デフォルト)  * &#x60;standard_classic&#x60; - レイアウト２/クラシック  * &#x60;envelope_classic&#x60; - 封筒１/クラシック  * &#x60;default_modern&#x60; - レイアウト１/モダン  * &#x60;standard_modern&#x60; - レイアウト２/モダン  * &#x60;envelope_modern&#x60; - 封筒/モダン</value>
        [DataMember(Name = "quotation_layout", EmitDefaultValue = false)]
        public QuotationLayoutEnum? QuotationLayout { get; set; }
        /// <summary>
        /// 見積書ステータス  (unsubmitted: 送付待ち, submitted: 送付済み)
        /// </summary>
        /// <value>見積書ステータス  (unsubmitted: 送付待ち, submitted: 送付済み)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QuotationStatusEnum
        {
            /// <summary>
            /// Enum Unsubmitted for value: unsubmitted
            /// </summary>
            [EnumMember(Value = "unsubmitted")]
            Unsubmitted = 1,

            /// <summary>
            /// Enum Submitted for value: submitted
            /// </summary>
            [EnumMember(Value = "submitted")]
            Submitted = 2

        }

        /// <summary>
        /// 見積書ステータス  (unsubmitted: 送付待ち, submitted: 送付済み)
        /// </summary>
        /// <value>見積書ステータス  (unsubmitted: 送付待ち, submitted: 送付済み)</value>
        [DataMember(Name = "quotation_status", EmitDefaultValue = false)]
        public QuotationStatusEnum? QuotationStatus { get; set; }
        /// <summary>
        /// 見積書の消費税計算方法(inclusive: 内税表示, exclusive: 外税表示 (デフォルト))
        /// </summary>
        /// <value>見積書の消費税計算方法(inclusive: 内税表示, exclusive: 外税表示 (デフォルト))</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxEntryMethodEnum
        {
            /// <summary>
            /// Enum Inclusive for value: inclusive
            /// </summary>
            [EnumMember(Value = "inclusive")]
            Inclusive = 1,

            /// <summary>
            /// Enum Exclusive for value: exclusive
            /// </summary>
            [EnumMember(Value = "exclusive")]
            Exclusive = 2

        }

        /// <summary>
        /// 見積書の消費税計算方法(inclusive: 内税表示, exclusive: 外税表示 (デフォルト))
        /// </summary>
        /// <value>見積書の消費税計算方法(inclusive: 内税表示, exclusive: 外税表示 (デフォルト))</value>
        [DataMember(Name = "tax_entry_method", EmitDefaultValue = false)]
        public TaxEntryMethodEnum? TaxEntryMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotationUpdateParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotationUpdateParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotationUpdateParams" /> class.
        /// </summary>
        /// <param name="companyAddress1">市区町村・番地 (デフォルトは事業所設定情報が補完されます).</param>
        /// <param name="companyAddress2">建物名・部屋番号など (デフォルトは事業所設定情報が補完されます).</param>
        /// <param name="companyContactInfo">事業所担当者名 (デフォルトは事業所設定情報が補完されます).</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="companyName">事業所名 (デフォルトは事業所設定情報が補完されます).</param>
        /// <param name="companyPrefectureCode">都道府県コード（0:北海道、1:青森、2:岩手、3:宮城、4:秋田、5:山形、6:福島、7:茨城、8:栃木、9:群馬、10:埼玉、11:千葉、12:東京、13:神奈川、14:新潟、15:富山、16:石川、17:福井、18:山梨、19:長野、20:岐阜、21:静岡、22:愛知、23:三重、24:滋賀、25:京都、26:大阪、27:兵庫、28:奈良、29:和歌山、30:鳥取、31:島根、32:岡山、33:広島、34:山口、35:徳島、36:香川、37:愛媛、38:高知、39:福岡、40:佐賀、41:長崎、42:熊本、43:大分、44:宮崎、45:鹿児島、46:沖縄) (デフォルトは事業所設定情報が補完されます).</param>
        /// <param name="companyZipcode">郵便番号 (デフォルトは事業所設定情報が補完されます).</param>
        /// <param name="description">概要.</param>
        /// <param name="issueDate">見積日 (yyyy-mm-dd).</param>
        /// <param name="message">メッセージ (デフォルト: 下記の通り御見積申し上げます。).</param>
        /// <param name="notes">備考.</param>
        /// <param name="partnerAddress1">取引先市区町村・番地 (デフォルトはpartner_idもしくははpartner_codeで指定された取引先設定情報が補完されます).</param>
        /// <param name="partnerAddress2">取引先建物名・部屋番号など (デフォルトはpartner_idもしくははpartner_codeで指定された取引先設定情報が補完されます).</param>
        /// <param name="partnerCode">取引先コード.</param>
        /// <param name="partnerContactInfo">取引先担当者名.</param>
        /// <param name="partnerDisplayName">見積書に表示する取引先名 (required).</param>
        /// <param name="partnerId">取引先ID.</param>
        /// <param name="partnerPrefectureCode">取引先都道府県コード（0:北海道、1:青森、2:岩手、3:宮城、4:秋田、5:山形、6:福島、7:茨城、8:栃木、9:群馬、10:埼玉、11:千葉、12:東京、13:神奈川、14:新潟、15:富山、16:石川、17:福井、18:山梨、19:長野、20:岐阜、21:静岡、22:愛知、23:三重、24:滋賀、25:京都、26:大阪、27:兵庫、28:奈良、29:和歌山、30:鳥取、31:島根、32:岡山、33:広島、34:山口、35:徳島、36:香川、37:愛媛、38:高知、39:福岡、40:佐賀、41:長崎、42:熊本、43:大分、44:宮崎、45:鹿児島、46:沖縄) (デフォルトはpartner_idもしくはpartner_codeで指定された取引先設定情報が補完されます).</param>
        /// <param name="partnerTitle">敬称（御中、様、(空白)の3つから選択） (required).</param>
        /// <param name="partnerZipcode">取引先郵便番号 (デフォルトはpartner_idもしくははpartner_codeで指定された取引先設定情報が補完されます).</param>
        /// <param name="quotationContents">見積内容.</param>
        /// <param name="quotationLayout">見積書レイアウト * &#x60;default_classic&#x60; - レイアウト１/クラシック (デフォルト)  * &#x60;standard_classic&#x60; - レイアウト２/クラシック  * &#x60;envelope_classic&#x60; - 封筒１/クラシック  * &#x60;default_modern&#x60; - レイアウト１/モダン  * &#x60;standard_modern&#x60; - レイアウト２/モダン  * &#x60;envelope_modern&#x60; - 封筒/モダン.</param>
        /// <param name="quotationNumber">見積書番号 (デフォルト: 自動採番されます).</param>
        /// <param name="quotationStatus">見積書ステータス  (unsubmitted: 送付待ち, submitted: 送付済み).</param>
        /// <param name="taxEntryMethod">見積書の消費税計算方法(inclusive: 内税表示, exclusive: 外税表示 (デフォルト)).</param>
        /// <param name="title">タイトル (デフォルト: 見積書).</param>
        public QuotationUpdateParams(string companyAddress1 = default(string), string companyAddress2 = default(string), string companyContactInfo = default(string), int companyId = default(int), string companyName = default(string), int companyPrefectureCode = default(int), string companyZipcode = default(string), string description = default(string), string issueDate = default(string), string message = default(string), string notes = default(string), string partnerAddress1 = default(string), string partnerAddress2 = default(string), string partnerCode = default(string), string partnerContactInfo = default(string), string partnerDisplayName = default(string), int? partnerId = default(int?), int? partnerPrefectureCode = default(int?), string partnerTitle = default(string), string partnerZipcode = default(string), List<QuotationUpdateParamsQuotationContents> quotationContents = default(List<QuotationUpdateParamsQuotationContents>), QuotationLayoutEnum? quotationLayout = default(QuotationLayoutEnum?), string quotationNumber = default(string), QuotationStatusEnum? quotationStatus = default(QuotationStatusEnum?), TaxEntryMethodEnum? taxEntryMethod = default(TaxEntryMethodEnum?), string title = default(string))
        {
            this.CompanyId = companyId;
            // to ensure "partnerDisplayName" is required (not null)
            this.PartnerDisplayName = partnerDisplayName ?? throw new ArgumentNullException("partnerDisplayName is a required property for QuotationUpdateParams and cannot be null");
            // to ensure "partnerTitle" is required (not null)
            this.PartnerTitle = partnerTitle ?? throw new ArgumentNullException("partnerTitle is a required property for QuotationUpdateParams and cannot be null");
            this.CompanyAddress1 = companyAddress1;
            this.CompanyAddress2 = companyAddress2;
            this.CompanyContactInfo = companyContactInfo;
            this.CompanyName = companyName;
            this.CompanyPrefectureCode = companyPrefectureCode;
            this.CompanyZipcode = companyZipcode;
            this.Description = description;
            this.IssueDate = issueDate;
            this.Message = message;
            this.Notes = notes;
            this.PartnerAddress1 = partnerAddress1;
            this.PartnerAddress2 = partnerAddress2;
            this.PartnerCode = partnerCode;
            this.PartnerContactInfo = partnerContactInfo;
            this.PartnerId = partnerId;
            this.PartnerPrefectureCode = partnerPrefectureCode;
            this.PartnerZipcode = partnerZipcode;
            this.QuotationContents = quotationContents;
            this.QuotationLayout = quotationLayout;
            this.QuotationNumber = quotationNumber;
            this.QuotationStatus = quotationStatus;
            this.TaxEntryMethod = taxEntryMethod;
            this.Title = title;
        }

        /// <summary>
        /// 市区町村・番地 (デフォルトは事業所設定情報が補完されます)
        /// </summary>
        /// <value>市区町村・番地 (デフォルトは事業所設定情報が補完されます)</value>
        [DataMember(Name = "company_address1", EmitDefaultValue = false)]
        public string CompanyAddress1 { get; set; }

        /// <summary>
        /// 建物名・部屋番号など (デフォルトは事業所設定情報が補完されます)
        /// </summary>
        /// <value>建物名・部屋番号など (デフォルトは事業所設定情報が補完されます)</value>
        [DataMember(Name = "company_address2", EmitDefaultValue = false)]
        public string CompanyAddress2 { get; set; }

        /// <summary>
        /// 事業所担当者名 (デフォルトは事業所設定情報が補完されます)
        /// </summary>
        /// <value>事業所担当者名 (デフォルトは事業所設定情報が補完されます)</value>
        [DataMember(Name = "company_contact_info", EmitDefaultValue = false)]
        public string CompanyContactInfo { get; set; }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", IsRequired = true, EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 事業所名 (デフォルトは事業所設定情報が補完されます)
        /// </summary>
        /// <value>事業所名 (デフォルトは事業所設定情報が補完されます)</value>
        [DataMember(Name = "company_name", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// 都道府県コード（0:北海道、1:青森、2:岩手、3:宮城、4:秋田、5:山形、6:福島、7:茨城、8:栃木、9:群馬、10:埼玉、11:千葉、12:東京、13:神奈川、14:新潟、15:富山、16:石川、17:福井、18:山梨、19:長野、20:岐阜、21:静岡、22:愛知、23:三重、24:滋賀、25:京都、26:大阪、27:兵庫、28:奈良、29:和歌山、30:鳥取、31:島根、32:岡山、33:広島、34:山口、35:徳島、36:香川、37:愛媛、38:高知、39:福岡、40:佐賀、41:長崎、42:熊本、43:大分、44:宮崎、45:鹿児島、46:沖縄) (デフォルトは事業所設定情報が補完されます)
        /// </summary>
        /// <value>都道府県コード（0:北海道、1:青森、2:岩手、3:宮城、4:秋田、5:山形、6:福島、7:茨城、8:栃木、9:群馬、10:埼玉、11:千葉、12:東京、13:神奈川、14:新潟、15:富山、16:石川、17:福井、18:山梨、19:長野、20:岐阜、21:静岡、22:愛知、23:三重、24:滋賀、25:京都、26:大阪、27:兵庫、28:奈良、29:和歌山、30:鳥取、31:島根、32:岡山、33:広島、34:山口、35:徳島、36:香川、37:愛媛、38:高知、39:福岡、40:佐賀、41:長崎、42:熊本、43:大分、44:宮崎、45:鹿児島、46:沖縄) (デフォルトは事業所設定情報が補完されます)</value>
        [DataMember(Name = "company_prefecture_code", EmitDefaultValue = false)]
        public int CompanyPrefectureCode { get; set; }

        /// <summary>
        /// 郵便番号 (デフォルトは事業所設定情報が補完されます)
        /// </summary>
        /// <value>郵便番号 (デフォルトは事業所設定情報が補完されます)</value>
        [DataMember(Name = "company_zipcode", EmitDefaultValue = false)]
        public string CompanyZipcode { get; set; }

        /// <summary>
        /// 概要
        /// </summary>
        /// <value>概要</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 見積日 (yyyy-mm-dd)
        /// </summary>
        /// <value>見積日 (yyyy-mm-dd)</value>
        [DataMember(Name = "issue_date", EmitDefaultValue = false)]
        public string IssueDate { get; set; }

        /// <summary>
        /// メッセージ (デフォルト: 下記の通り御見積申し上げます。)
        /// </summary>
        /// <value>メッセージ (デフォルト: 下記の通り御見積申し上げます。)</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// 備考
        /// </summary>
        /// <value>備考</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// 取引先市区町村・番地 (デフォルトはpartner_idもしくははpartner_codeで指定された取引先設定情報が補完されます)
        /// </summary>
        /// <value>取引先市区町村・番地 (デフォルトはpartner_idもしくははpartner_codeで指定された取引先設定情報が補完されます)</value>
        [DataMember(Name = "partner_address1", EmitDefaultValue = true)]
        public string PartnerAddress1 { get; set; }

        /// <summary>
        /// 取引先建物名・部屋番号など (デフォルトはpartner_idもしくははpartner_codeで指定された取引先設定情報が補完されます)
        /// </summary>
        /// <value>取引先建物名・部屋番号など (デフォルトはpartner_idもしくははpartner_codeで指定された取引先設定情報が補完されます)</value>
        [DataMember(Name = "partner_address2", EmitDefaultValue = true)]
        public string PartnerAddress2 { get; set; }

        /// <summary>
        /// 取引先コード
        /// </summary>
        /// <value>取引先コード</value>
        [DataMember(Name = "partner_code", EmitDefaultValue = true)]
        public string PartnerCode { get; set; }

        /// <summary>
        /// 取引先担当者名
        /// </summary>
        /// <value>取引先担当者名</value>
        [DataMember(Name = "partner_contact_info", EmitDefaultValue = true)]
        public string PartnerContactInfo { get; set; }

        /// <summary>
        /// 見積書に表示する取引先名
        /// </summary>
        /// <value>見積書に表示する取引先名</value>
        [DataMember(Name = "partner_display_name", IsRequired = true, EmitDefaultValue = false)]
        public string PartnerDisplayName { get; set; }

        /// <summary>
        /// 取引先ID
        /// </summary>
        /// <value>取引先ID</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = true)]
        public int? PartnerId { get; set; }

        /// <summary>
        /// 取引先都道府県コード（0:北海道、1:青森、2:岩手、3:宮城、4:秋田、5:山形、6:福島、7:茨城、8:栃木、9:群馬、10:埼玉、11:千葉、12:東京、13:神奈川、14:新潟、15:富山、16:石川、17:福井、18:山梨、19:長野、20:岐阜、21:静岡、22:愛知、23:三重、24:滋賀、25:京都、26:大阪、27:兵庫、28:奈良、29:和歌山、30:鳥取、31:島根、32:岡山、33:広島、34:山口、35:徳島、36:香川、37:愛媛、38:高知、39:福岡、40:佐賀、41:長崎、42:熊本、43:大分、44:宮崎、45:鹿児島、46:沖縄) (デフォルトはpartner_idもしくはpartner_codeで指定された取引先設定情報が補完されます)
        /// </summary>
        /// <value>取引先都道府県コード（0:北海道、1:青森、2:岩手、3:宮城、4:秋田、5:山形、6:福島、7:茨城、8:栃木、9:群馬、10:埼玉、11:千葉、12:東京、13:神奈川、14:新潟、15:富山、16:石川、17:福井、18:山梨、19:長野、20:岐阜、21:静岡、22:愛知、23:三重、24:滋賀、25:京都、26:大阪、27:兵庫、28:奈良、29:和歌山、30:鳥取、31:島根、32:岡山、33:広島、34:山口、35:徳島、36:香川、37:愛媛、38:高知、39:福岡、40:佐賀、41:長崎、42:熊本、43:大分、44:宮崎、45:鹿児島、46:沖縄) (デフォルトはpartner_idもしくはpartner_codeで指定された取引先設定情報が補完されます)</value>
        [DataMember(Name = "partner_prefecture_code", EmitDefaultValue = true)]
        public int? PartnerPrefectureCode { get; set; }

        /// <summary>
        /// 敬称（御中、様、(空白)の3つから選択）
        /// </summary>
        /// <value>敬称（御中、様、(空白)の3つから選択）</value>
        [DataMember(Name = "partner_title", IsRequired = true, EmitDefaultValue = false)]
        public string PartnerTitle { get; set; }

        /// <summary>
        /// 取引先郵便番号 (デフォルトはpartner_idもしくははpartner_codeで指定された取引先設定情報が補完されます)
        /// </summary>
        /// <value>取引先郵便番号 (デフォルトはpartner_idもしくははpartner_codeで指定された取引先設定情報が補完されます)</value>
        [DataMember(Name = "partner_zipcode", EmitDefaultValue = true)]
        public string PartnerZipcode { get; set; }

        /// <summary>
        /// 見積内容
        /// </summary>
        /// <value>見積内容</value>
        [DataMember(Name = "quotation_contents", EmitDefaultValue = false)]
        public List<QuotationUpdateParamsQuotationContents> QuotationContents { get; set; }

        /// <summary>
        /// 見積書番号 (デフォルト: 自動採番されます)
        /// </summary>
        /// <value>見積書番号 (デフォルト: 自動採番されます)</value>
        [DataMember(Name = "quotation_number", EmitDefaultValue = false)]
        public string QuotationNumber { get; set; }

        /// <summary>
        /// タイトル (デフォルト: 見積書)
        /// </summary>
        /// <value>タイトル (デフォルト: 見積書)</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotationUpdateParams {\n");
            sb.Append("  CompanyAddress1: ").Append(CompanyAddress1).Append("\n");
            sb.Append("  CompanyAddress2: ").Append(CompanyAddress2).Append("\n");
            sb.Append("  CompanyContactInfo: ").Append(CompanyContactInfo).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CompanyPrefectureCode: ").Append(CompanyPrefectureCode).Append("\n");
            sb.Append("  CompanyZipcode: ").Append(CompanyZipcode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  PartnerAddress1: ").Append(PartnerAddress1).Append("\n");
            sb.Append("  PartnerAddress2: ").Append(PartnerAddress2).Append("\n");
            sb.Append("  PartnerCode: ").Append(PartnerCode).Append("\n");
            sb.Append("  PartnerContactInfo: ").Append(PartnerContactInfo).Append("\n");
            sb.Append("  PartnerDisplayName: ").Append(PartnerDisplayName).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  PartnerPrefectureCode: ").Append(PartnerPrefectureCode).Append("\n");
            sb.Append("  PartnerTitle: ").Append(PartnerTitle).Append("\n");
            sb.Append("  PartnerZipcode: ").Append(PartnerZipcode).Append("\n");
            sb.Append("  QuotationContents: ").Append(QuotationContents).Append("\n");
            sb.Append("  QuotationLayout: ").Append(QuotationLayout).Append("\n");
            sb.Append("  QuotationNumber: ").Append(QuotationNumber).Append("\n");
            sb.Append("  QuotationStatus: ").Append(QuotationStatus).Append("\n");
            sb.Append("  TaxEntryMethod: ").Append(TaxEntryMethod).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotationUpdateParams);
        }

        /// <summary>
        /// Returns true if QuotationUpdateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotationUpdateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotationUpdateParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyAddress1 == input.CompanyAddress1 ||
                    (this.CompanyAddress1 != null &&
                    this.CompanyAddress1.Equals(input.CompanyAddress1))
                ) && 
                (
                    this.CompanyAddress2 == input.CompanyAddress2 ||
                    (this.CompanyAddress2 != null &&
                    this.CompanyAddress2.Equals(input.CompanyAddress2))
                ) && 
                (
                    this.CompanyContactInfo == input.CompanyContactInfo ||
                    (this.CompanyContactInfo != null &&
                    this.CompanyContactInfo.Equals(input.CompanyContactInfo))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.CompanyPrefectureCode == input.CompanyPrefectureCode ||
                    this.CompanyPrefectureCode.Equals(input.CompanyPrefectureCode)
                ) && 
                (
                    this.CompanyZipcode == input.CompanyZipcode ||
                    (this.CompanyZipcode != null &&
                    this.CompanyZipcode.Equals(input.CompanyZipcode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.PartnerAddress1 == input.PartnerAddress1 ||
                    (this.PartnerAddress1 != null &&
                    this.PartnerAddress1.Equals(input.PartnerAddress1))
                ) && 
                (
                    this.PartnerAddress2 == input.PartnerAddress2 ||
                    (this.PartnerAddress2 != null &&
                    this.PartnerAddress2.Equals(input.PartnerAddress2))
                ) && 
                (
                    this.PartnerCode == input.PartnerCode ||
                    (this.PartnerCode != null &&
                    this.PartnerCode.Equals(input.PartnerCode))
                ) && 
                (
                    this.PartnerContactInfo == input.PartnerContactInfo ||
                    (this.PartnerContactInfo != null &&
                    this.PartnerContactInfo.Equals(input.PartnerContactInfo))
                ) && 
                (
                    this.PartnerDisplayName == input.PartnerDisplayName ||
                    (this.PartnerDisplayName != null &&
                    this.PartnerDisplayName.Equals(input.PartnerDisplayName))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.PartnerPrefectureCode == input.PartnerPrefectureCode ||
                    (this.PartnerPrefectureCode != null &&
                    this.PartnerPrefectureCode.Equals(input.PartnerPrefectureCode))
                ) && 
                (
                    this.PartnerTitle == input.PartnerTitle ||
                    (this.PartnerTitle != null &&
                    this.PartnerTitle.Equals(input.PartnerTitle))
                ) && 
                (
                    this.PartnerZipcode == input.PartnerZipcode ||
                    (this.PartnerZipcode != null &&
                    this.PartnerZipcode.Equals(input.PartnerZipcode))
                ) && 
                (
                    this.QuotationContents == input.QuotationContents ||
                    this.QuotationContents != null &&
                    input.QuotationContents != null &&
                    this.QuotationContents.SequenceEqual(input.QuotationContents)
                ) && 
                (
                    this.QuotationLayout == input.QuotationLayout ||
                    this.QuotationLayout.Equals(input.QuotationLayout)
                ) && 
                (
                    this.QuotationNumber == input.QuotationNumber ||
                    (this.QuotationNumber != null &&
                    this.QuotationNumber.Equals(input.QuotationNumber))
                ) && 
                (
                    this.QuotationStatus == input.QuotationStatus ||
                    this.QuotationStatus.Equals(input.QuotationStatus)
                ) && 
                (
                    this.TaxEntryMethod == input.TaxEntryMethod ||
                    this.TaxEntryMethod.Equals(input.TaxEntryMethod)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CompanyAddress1 != null)
                    hashCode = hashCode * 59 + this.CompanyAddress1.GetHashCode();
                if (this.CompanyAddress2 != null)
                    hashCode = hashCode * 59 + this.CompanyAddress2.GetHashCode();
                if (this.CompanyContactInfo != null)
                    hashCode = hashCode * 59 + this.CompanyContactInfo.GetHashCode();
                hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                hashCode = hashCode * 59 + this.CompanyPrefectureCode.GetHashCode();
                if (this.CompanyZipcode != null)
                    hashCode = hashCode * 59 + this.CompanyZipcode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.PartnerAddress1 != null)
                    hashCode = hashCode * 59 + this.PartnerAddress1.GetHashCode();
                if (this.PartnerAddress2 != null)
                    hashCode = hashCode * 59 + this.PartnerAddress2.GetHashCode();
                if (this.PartnerCode != null)
                    hashCode = hashCode * 59 + this.PartnerCode.GetHashCode();
                if (this.PartnerContactInfo != null)
                    hashCode = hashCode * 59 + this.PartnerContactInfo.GetHashCode();
                if (this.PartnerDisplayName != null)
                    hashCode = hashCode * 59 + this.PartnerDisplayName.GetHashCode();
                if (this.PartnerId != null)
                    hashCode = hashCode * 59 + this.PartnerId.GetHashCode();
                if (this.PartnerPrefectureCode != null)
                    hashCode = hashCode * 59 + this.PartnerPrefectureCode.GetHashCode();
                if (this.PartnerTitle != null)
                    hashCode = hashCode * 59 + this.PartnerTitle.GetHashCode();
                if (this.PartnerZipcode != null)
                    hashCode = hashCode * 59 + this.PartnerZipcode.GetHashCode();
                if (this.QuotationContents != null)
                    hashCode = hashCode * 59 + this.QuotationContents.GetHashCode();
                hashCode = hashCode * 59 + this.QuotationLayout.GetHashCode();
                if (this.QuotationNumber != null)
                    hashCode = hashCode * 59 + this.QuotationNumber.GetHashCode();
                hashCode = hashCode * 59 + this.QuotationStatus.GetHashCode();
                hashCode = hashCode * 59 + this.TaxEntryMethod.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }

    }

}
