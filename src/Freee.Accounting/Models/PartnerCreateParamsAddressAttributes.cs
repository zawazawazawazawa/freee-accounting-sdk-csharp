// <auto-generated>
// Copyright (c) freee K.K. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license
// information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
//
// </auto-generated>

namespace Freee.Accounting.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PartnerCreateParamsAddressAttributes
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PartnerCreateParamsAddressAttributes class.
        /// </summary>
        public PartnerCreateParamsAddressAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PartnerCreateParamsAddressAttributes class.
        /// </summary>
        /// <param name="zipcode">郵便番号</param>
        /// <param name="prefectureCode">都道府県コード（0:
        /// 北海道、1:青森、2:岩手、3:宮城、4:秋田、5:山形、6:福島、7:茨城、8:栃木、9:群馬、10:埼玉、11:千葉、12:東京、13:神奈川、14:新潟、15:富山、16:石川、17:福井、18:山梨、19:長野、20:岐阜、21:静岡、22:愛知、23:三重、24:滋賀、25:京都、26:大阪、27:兵庫、28:奈良、29:和歌山、30:鳥取、31:島根、32:岡山、33:広島、34:山口、35:徳島、36:香川、37:愛媛、38:高知、39:福岡、40:佐賀、41:長崎、42:熊本、43:大分、44:宮崎、45:鹿児島、46:沖縄</param>
        /// <param name="streetName1">市区町村・番地</param>
        /// <param name="streetName2">建物名・部屋番号など</param>
        public PartnerCreateParamsAddressAttributes(string zipcode = default(string), int? prefectureCode = default(int?), string streetName1 = default(string), string streetName2 = default(string))
        {
            Zipcode = zipcode;
            PrefectureCode = prefectureCode;
            StreetName1 = streetName1;
            StreetName2 = streetName2;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 郵便番号
        /// </summary>
        [JsonProperty(PropertyName = "zipcode")]
        public string Zipcode { get; set; }

        /// <summary>
        /// Gets or sets 都道府県コード（0:
        /// 北海道、1:青森、2:岩手、3:宮城、4:秋田、5:山形、6:福島、7:茨城、8:栃木、9:群馬、10:埼玉、11:千葉、12:東京、13:神奈川、14:新潟、15:富山、16:石川、17:福井、18:山梨、19:長野、20:岐阜、21:静岡、22:愛知、23:三重、24:滋賀、25:京都、26:大阪、27:兵庫、28:奈良、29:和歌山、30:鳥取、31:島根、32:岡山、33:広島、34:山口、35:徳島、36:香川、37:愛媛、38:高知、39:福岡、40:佐賀、41:長崎、42:熊本、43:大分、44:宮崎、45:鹿児島、46:沖縄
        /// </summary>
        [JsonProperty(PropertyName = "prefecture_code")]
        public int? PrefectureCode { get; set; }

        /// <summary>
        /// Gets or sets 市区町村・番地
        /// </summary>
        [JsonProperty(PropertyName = "street_name1")]
        public string StreetName1 { get; set; }

        /// <summary>
        /// Gets or sets 建物名・部屋番号など
        /// </summary>
        [JsonProperty(PropertyName = "street_name2")]
        public string StreetName2 { get; set; }

    }
}
