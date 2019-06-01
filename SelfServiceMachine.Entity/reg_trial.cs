﻿using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace SelfServiceMachine.Entity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("reg_trial")]
    public partial class reg_trial
    {
           public reg_trial(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:费用单据号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string akc190 {get;set;}

           /// <summary>
           /// Desc:费用序列号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string aaz500 {get;set;}

           /// <summary>
           /// Desc:社保目录编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bzz269 {get;set;}

           /// <summary>
           /// Desc:协议机构内部诊疗目录编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string alc005 {get;set;}

           /// <summary>
           /// Desc:协议机构内部诊疗目录名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string aka130 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string akf001 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bkc368 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string aka120 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string akc188 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string akc189 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bke384 {get;set;}

           /// <summary>
           /// Desc:费用单据号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? akc264 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? regid {get;set;}

    }
}
