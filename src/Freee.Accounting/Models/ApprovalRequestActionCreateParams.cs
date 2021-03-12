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
    /// ApprovalRequestActionCreateParams
    /// </summary>
    [DataContract(Name = "approvalRequestActionCreateParams")]
    public partial class ApprovalRequestActionCreateParams : IEquatable<ApprovalRequestActionCreateParams>
    {
        /// <summary>
        /// 操作(approve: 承認する、force_approve: 代理承認する、cancel: 申請を取り消す、reject: 却下する、feedback: 申請者へ差し戻す、force_feedback: 承認済み・却下済みを取り消す)
        /// </summary>
        /// <value>操作(approve: 承認する、force_approve: 代理承認する、cancel: 申請を取り消す、reject: 却下する、feedback: 申請者へ差し戻す、force_feedback: 承認済み・却下済みを取り消す)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApprovalActionEnum
        {
            /// <summary>
            /// Enum Approve for value: approve
            /// </summary>
            [EnumMember(Value = "approve")]
            Approve = 1,

            /// <summary>
            /// Enum ForceApprove for value: force_approve
            /// </summary>
            [EnumMember(Value = "force_approve")]
            ForceApprove = 2,

            /// <summary>
            /// Enum Cancel for value: cancel
            /// </summary>
            [EnumMember(Value = "cancel")]
            Cancel = 3,

            /// <summary>
            /// Enum Reject for value: reject
            /// </summary>
            [EnumMember(Value = "reject")]
            Reject = 4,

            /// <summary>
            /// Enum Feedback for value: feedback
            /// </summary>
            [EnumMember(Value = "feedback")]
            Feedback = 5,

            /// <summary>
            /// Enum ForceFeedback for value: force_feedback
            /// </summary>
            [EnumMember(Value = "force_feedback")]
            ForceFeedback = 6

        }

        /// <summary>
        /// 操作(approve: 承認する、force_approve: 代理承認する、cancel: 申請を取り消す、reject: 却下する、feedback: 申請者へ差し戻す、force_feedback: 承認済み・却下済みを取り消す)
        /// </summary>
        /// <value>操作(approve: 承認する、force_approve: 代理承認する、cancel: 申請を取り消す、reject: 却下する、feedback: 申請者へ差し戻す、force_feedback: 承認済み・却下済みを取り消す)</value>
        [DataMember(Name = "approval_action", IsRequired = true, EmitDefaultValue = false)]
        public ApprovalActionEnum ApprovalAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalRequestActionCreateParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApprovalRequestActionCreateParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalRequestActionCreateParams" /> class.
        /// </summary>
        /// <param name="approvalAction">操作(approve: 承認する、force_approve: 代理承認する、cancel: 申請を取り消す、reject: 却下する、feedback: 申請者へ差し戻す、force_feedback: 承認済み・却下済みを取り消す) (required).</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="nextApproverId">次ステップの承認者のユーザーID.</param>
        /// <param name="targetRound">対象round。差し戻し等により申請がstepの最初からやり直しになるとroundの値が増えます。各種申請の取得APIレスポンス.current_roundを送信してください。 (required).</param>
        /// <param name="targetStepId">対象承認ステップID 各種申請の取得APIレスポンス.current_step_idを送信してください。 (required).</param>
        public ApprovalRequestActionCreateParams(ApprovalActionEnum approvalAction = default(ApprovalActionEnum), int companyId = default(int), int? nextApproverId = default(int?), int targetRound = default(int), int targetStepId = default(int))
        {
            this.ApprovalAction = approvalAction;
            this.CompanyId = companyId;
            this.TargetRound = targetRound;
            this.TargetStepId = targetStepId;
            this.NextApproverId = nextApproverId;
        }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", IsRequired = true, EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 次ステップの承認者のユーザーID
        /// </summary>
        /// <value>次ステップの承認者のユーザーID</value>
        [DataMember(Name = "next_approver_id", EmitDefaultValue = true)]
        public int? NextApproverId { get; set; }

        /// <summary>
        /// 対象round。差し戻し等により申請がstepの最初からやり直しになるとroundの値が増えます。各種申請の取得APIレスポンス.current_roundを送信してください。
        /// </summary>
        /// <value>対象round。差し戻し等により申請がstepの最初からやり直しになるとroundの値が増えます。各種申請の取得APIレスポンス.current_roundを送信してください。</value>
        [DataMember(Name = "target_round", IsRequired = true, EmitDefaultValue = false)]
        public int TargetRound { get; set; }

        /// <summary>
        /// 対象承認ステップID 各種申請の取得APIレスポンス.current_step_idを送信してください。
        /// </summary>
        /// <value>対象承認ステップID 各種申請の取得APIレスポンス.current_step_idを送信してください。</value>
        [DataMember(Name = "target_step_id", IsRequired = true, EmitDefaultValue = false)]
        public int TargetStepId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApprovalRequestActionCreateParams {\n");
            sb.Append("  ApprovalAction: ").Append(ApprovalAction).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  NextApproverId: ").Append(NextApproverId).Append("\n");
            sb.Append("  TargetRound: ").Append(TargetRound).Append("\n");
            sb.Append("  TargetStepId: ").Append(TargetStepId).Append("\n");
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
            return this.Equals(input as ApprovalRequestActionCreateParams);
        }

        /// <summary>
        /// Returns true if ApprovalRequestActionCreateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ApprovalRequestActionCreateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApprovalRequestActionCreateParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApprovalAction == input.ApprovalAction ||
                    this.ApprovalAction.Equals(input.ApprovalAction)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.NextApproverId == input.NextApproverId ||
                    (this.NextApproverId != null &&
                    this.NextApproverId.Equals(input.NextApproverId))
                ) && 
                (
                    this.TargetRound == input.TargetRound ||
                    this.TargetRound.Equals(input.TargetRound)
                ) && 
                (
                    this.TargetStepId == input.TargetStepId ||
                    this.TargetStepId.Equals(input.TargetStepId)
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
                hashCode = hashCode * 59 + this.ApprovalAction.GetHashCode();
                hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.NextApproverId != null)
                    hashCode = hashCode * 59 + this.NextApproverId.GetHashCode();
                hashCode = hashCode * 59 + this.TargetRound.GetHashCode();
                hashCode = hashCode * 59 + this.TargetStepId.GetHashCode();
                return hashCode;
            }
        }

    }

}
