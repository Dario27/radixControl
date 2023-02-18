/*
               File: Gx00E1
        Description: Selection List Level1
             Author: GeneXus C# Generator version 15_0_11-124690
       Generated on: 6/28/2022 12:10:32.1
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gx00e1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00e1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx00e1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_pUsuCod ,
                           out short aP1_pempcod ,
                           out short aP2_pagecod ,
                           out short aP3_pModCod ,
                           out short aP4_pMenCod ,
                           out short aP5_pSubCod )
      {
         this.AV12pUsuCod = aP0_pUsuCod;
         this.AV13pempcod = 0 ;
         this.AV14pagecod = 0 ;
         this.AV15pModCod = 0 ;
         this.AV16pMenCod = 0 ;
         this.AV17pSubCod = 0 ;
         executePrivate();
         aP1_pempcod=this.AV13pempcod;
         aP2_pagecod=this.AV14pagecod;
         aP3_pModCod=this.AV15pModCod;
         aP4_pMenCod=this.AV16pMenCod;
         aP5_pSubCod=this.AV17pSubCod;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         context.SetDefaultTheme("Carmine");
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            gxfirstwebparm_bkp = gxfirstwebparm;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
            {
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_74 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_74_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_74_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cempcod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cagecod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cModCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV9cMenCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV10cSubCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11cPermEst = GetNextPar( );
               AV12pUsuCod = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cempcod, AV7cagecod, AV8cModCod, AV9cMenCod, AV10cSubCod, AV11cPermEst, AV12pUsuCod) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV12pUsuCod = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsuCod", AV12pUsuCod);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV13pempcod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pempcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pempcod), 3, 0)));
                  AV14pagecod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pagecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pagecod), 3, 0)));
                  AV15pModCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pModCod), 4, 0)));
                  AV16pMenCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pMenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pMenCod), 4, 0)));
                  AV17pSubCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17pSubCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17pSubCod), 4, 0)));
               }
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdpromptmasterpage", "GeneXus.Programs.rwdpromptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA3H2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3H2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 124690), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 124690), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 124690), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 124690), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 124690), false);
         context.AddJavascriptSource("gxcfg.js", "?202262812103211", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00e1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pUsuCod)) + "," + UrlEncode("" +AV13pempcod) + "," + UrlEncode("" +AV14pagecod) + "," + UrlEncode("" +AV15pModCod) + "," + UrlEncode("" +AV16pMenCod) + "," + UrlEncode("" +AV17pSubCod)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cempcod), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCAGECOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cagecod), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cModCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMENCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cMenCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSUBCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cSubCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPERMEST", StringUtil.RTrim( AV11cPermEst));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPUSUCOD", StringUtil.RTrim( AV12pUsuCod));
         GxWebStd.gx_hidden_field( context, "vPEMPCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pempcod), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPAGECOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pagecod), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPMODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15pModCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPMENCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16pMenCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPSUBCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17pSubCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "EMPCODFILTERCONTAINER_Class", StringUtil.RTrim( divEmpcodfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AGECODFILTERCONTAINER_Class", StringUtil.RTrim( divAgecodfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "MODCODFILTERCONTAINER_Class", StringUtil.RTrim( divModcodfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "MENCODFILTERCONTAINER_Class", StringUtil.RTrim( divMencodfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SUBCODFILTERCONTAINER_Class", StringUtil.RTrim( divSubcodfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PERMESTFILTERCONTAINER_Class", StringUtil.RTrim( divPermestfiltercontainer_Class));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE3H2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3H2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00e1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pUsuCod)) + "," + UrlEncode("" +AV13pempcod) + "," + UrlEncode("" +AV14pagecod) + "," + UrlEncode("" +AV15pModCod) + "," + UrlEncode("" +AV16pMenCod) + "," + UrlEncode("" +AV17pSubCod) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00E1" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Level1" ;
      }

      protected void WB3H0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 PromptAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEmpcodfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpcodfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempcodfilter_Internalname, "empcod", "", "", lblLblempcodfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e113h1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempcod_Internalname, "Codigo", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempcod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cempcod), 3, 0, ",", "")), ((edtavCempcod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cempcod), "ZZ9")) : context.localUtil.Format( (decimal)(AV6cempcod), "ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempcod_Jsonclick, 0, "Attribute", "", "", "", "", edtavCempcod_Visible, edtavCempcod_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAgecodfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAgecodfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblagecodfilter_Internalname, "Agencia", "", "", lblLblagecodfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e123h1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCagecod_Internalname, "Agencia", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCagecod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cagecod), 3, 0, ",", "")), ((edtavCagecod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cagecod), "ZZ9")) : context.localUtil.Format( (decimal)(AV7cagecod), "ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCagecod_Jsonclick, 0, "Attribute", "", "", "", "", edtavCagecod_Visible, edtavCagecod_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divModcodfiltercontainer_Internalname, 1, 0, "px", 0, "px", divModcodfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblmodcodfilter_Internalname, "Codigo", "", "", lblLblmodcodfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e133h1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCmodcod_Internalname, "Codigo", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCmodcod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cModCod), 4, 0, ",", "")), ((edtavCmodcod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cModCod), "ZZZ9")) : context.localUtil.Format( (decimal)(AV8cModCod), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmodcod_Jsonclick, 0, "Attribute", "", "", "", "", edtavCmodcod_Visible, edtavCmodcod_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMencodfiltercontainer_Internalname, 1, 0, "px", 0, "px", divMencodfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblmencodfilter_Internalname, "Código de Menú", "", "", lblLblmencodfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e143h1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCmencod_Internalname, "Código de Menú", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCmencod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cMenCod), 4, 0, ",", "")), ((edtavCmencod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cMenCod), "ZZZ9")) : context.localUtil.Format( (decimal)(AV9cMenCod), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCmencod_Jsonclick, 0, "Attribute", "", "", "", "", edtavCmencod_Visible, edtavCmencod_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSubcodfiltercontainer_Internalname, 1, 0, "px", 0, "px", divSubcodfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblsubcodfilter_Internalname, "Codigo", "", "", lblLblsubcodfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e153h1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCsubcod_Internalname, "Codigo", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCsubcod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cSubCod), 4, 0, ",", "")), ((edtavCsubcod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cSubCod), "ZZZ9")) : context.localUtil.Format( (decimal)(AV10cSubCod), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCsubcod_Jsonclick, 0, "Attribute", "", "", "", "", edtavCsubcod_Visible, edtavCsubcod_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPermestfiltercontainer_Internalname, 1, 0, "px", 0, "px", divPermestfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpermestfilter_Internalname, "Perm Est", "", "", lblLblpermestfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e163h1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCpermest_Internalname, "Perm Est", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCpermest_Internalname, StringUtil.RTrim( AV11cPermEst), StringUtil.RTrim( context.localUtil.Format( AV11cPermEst, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCpermest_Jsonclick, 0, "Attribute", "", "", "", "", edtavCpermest_Visible, edtavCpermest_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 WWGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e173h1_client"+"'", TempTags, "", 2, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"74\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Codigo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Agencia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Codigo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Código de Menú") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Codigo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Perm Est") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Nombre de Usuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", "PromptGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15empcod), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A16agecod), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ModCod), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A12MenCod), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A96PermEst));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtPermEst_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A3UsuCod));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            nRC_GXsfl_74 = (short)(nGXsfl_74_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid1Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
                  Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START3H2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_11-124690", 0) ;
            Form.Meta.addItem("description", "Selection List Level1", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP3H0( ) ;
      }

      protected void WS3H2( )
      {
         START3H2( ) ;
         EVT3H2( ) ;
      }

      protected void EVT3H2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_74_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
                              SubsflControlProps_742( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV21Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_74_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A15empcod = (short)(context.localUtil.CToN( cgiGet( edtempcod_Internalname), ",", "."));
                              A16agecod = (short)(context.localUtil.CToN( cgiGet( edtagecod_Internalname), ",", "."));
                              A11ModCod = (short)(context.localUtil.CToN( cgiGet( edtModCod_Internalname), ",", "."));
                              A12MenCod = (short)(context.localUtil.CToN( cgiGet( edtMenCod_Internalname), ",", "."));
                              A13SubCod = (short)(context.localUtil.CToN( cgiGet( edtSubCod_Internalname), ",", "."));
                              A96PermEst = cgiGet( edtPermEst_Internalname);
                              n96PermEst = false;
                              A3UsuCod = cgiGet( edtUsuCod_Internalname);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E183H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E193H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cempcod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPCOD"), ",", ".") != Convert.ToDecimal( AV6cempcod )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cagecod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAGECOD"), ",", ".") != Convert.ToDecimal( AV7cagecod )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cmodcod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMODCOD"), ",", ".") != Convert.ToDecimal( AV8cModCod )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cmencod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMENCOD"), ",", ".") != Convert.ToDecimal( AV9cMenCod )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Csubcod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSUBCOD"), ",", ".") != Convert.ToDecimal( AV10cSubCod )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cpermest Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPERMEST"), AV11cPermEst) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E203H2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE3H2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA3H2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_742( ) ;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cempcod ,
                                        short AV7cagecod ,
                                        short AV8cModCod ,
                                        short AV9cMenCod ,
                                        short AV10cSubCod ,
                                        String AV11cPermEst ,
                                        String AV12pUsuCod )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF3H2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A15empcod), "ZZ9"), context));
         GxWebStd.gx_hidden_field( context, "EMPCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15empcod), 3, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_AGECOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A16agecod), "ZZ9"), context));
         GxWebStd.gx_hidden_field( context, "AGECOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A16agecod), 3, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_MODCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A11ModCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "MODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ModCod), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_MENCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A12MenCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "MENCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A12MenCod), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_SUBCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A13SubCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SUBCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ".", "")));
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF3H2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF3H2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 74;
         nGXsfl_74_idx = 1;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         SubsflControlProps_742( ) ;
         bGXsfl_74_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "PromptGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_742( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV11cPermEst ,
                                                 A96PermEst ,
                                                 AV12pUsuCod ,
                                                 AV6cempcod ,
                                                 AV7cagecod ,
                                                 AV8cModCod ,
                                                 AV9cMenCod ,
                                                 AV10cSubCod ,
                                                 A3UsuCod } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING
                                                 }
            } ) ;
            lV11cPermEst = StringUtil.PadR( StringUtil.RTrim( AV11cPermEst), 1, "%");
            /* Using cursor H003H2 */
            pr_default.execute(0, new Object[] {AV12pUsuCod, AV6cempcod, AV7cagecod, AV8cModCod, AV9cMenCod, AV10cSubCod, lV11cPermEst, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A3UsuCod = H003H2_A3UsuCod[0];
               A96PermEst = H003H2_A96PermEst[0];
               n96PermEst = H003H2_n96PermEst[0];
               A13SubCod = H003H2_A13SubCod[0];
               A12MenCod = H003H2_A12MenCod[0];
               A11ModCod = H003H2_A11ModCod[0];
               A16agecod = H003H2_A16agecod[0];
               A15empcod = H003H2_A15empcod[0];
               /* Execute user event: Load */
               E193H2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB3H0( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes3H2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPCOD"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A15empcod), "ZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_AGECOD"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A16agecod), "ZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_MODCOD"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A11ModCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_MENCOD"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A12MenCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_SUBCOD"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A13SubCod), "ZZZ9"), context));
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV11cPermEst ,
                                              A96PermEst ,
                                              AV12pUsuCod ,
                                              AV6cempcod ,
                                              AV7cagecod ,
                                              AV8cModCod ,
                                              AV9cMenCod ,
                                              AV10cSubCod ,
                                              A3UsuCod } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING
                                              }
         } ) ;
         lV11cPermEst = StringUtil.PadR( StringUtil.RTrim( AV11cPermEst), 1, "%");
         /* Using cursor H003H3 */
         pr_default.execute(1, new Object[] {AV12pUsuCod, AV6cempcod, AV7cagecod, AV8cModCod, AV9cMenCod, AV10cSubCod, lV11cPermEst});
         GRID1_nRecordCount = H003H3_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempcod, AV7cagecod, AV8cModCod, AV9cMenCod, AV10cSubCod, AV11cPermEst, AV12pUsuCod) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempcod, AV7cagecod, AV8cModCod, AV9cMenCod, AV10cSubCod, AV11cPermEst, AV12pUsuCod) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID1_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempcod, AV7cagecod, AV8cModCod, AV9cMenCod, AV10cSubCod, AV11cPermEst, AV12pUsuCod) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempcod, AV7cagecod, AV8cModCod, AV9cMenCod, AV10cSubCod, AV11cPermEst, AV12pUsuCod) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cempcod, AV7cagecod, AV8cModCod, AV9cMenCod, AV10cSubCod, AV11cPermEst, AV12pUsuCod) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP3H0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E183H2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCempcod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCempcod_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEMPCOD");
               GX_FocusControl = edtavCempcod_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cempcod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cempcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cempcod), 3, 0)));
            }
            else
            {
               AV6cempcod = (short)(context.localUtil.CToN( cgiGet( edtavCempcod_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cempcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cempcod), 3, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCagecod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCagecod_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCAGECOD");
               GX_FocusControl = edtavCagecod_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cagecod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cagecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cagecod), 3, 0)));
            }
            else
            {
               AV7cagecod = (short)(context.localUtil.CToN( cgiGet( edtavCagecod_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cagecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cagecod), 3, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmodcod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmodcod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMODCOD");
               GX_FocusControl = edtavCmodcod_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cModCod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cModCod), 4, 0)));
            }
            else
            {
               AV8cModCod = (short)(context.localUtil.CToN( cgiGet( edtavCmodcod_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cModCod), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmencod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmencod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMENCOD");
               GX_FocusControl = edtavCmencod_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cMenCod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cMenCod), 4, 0)));
            }
            else
            {
               AV9cMenCod = (short)(context.localUtil.CToN( cgiGet( edtavCmencod_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cMenCod), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCsubcod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCsubcod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSUBCOD");
               GX_FocusControl = edtavCsubcod_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cSubCod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSubCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cSubCod), 4, 0)));
            }
            else
            {
               AV10cSubCod = (short)(context.localUtil.CToN( cgiGet( edtavCsubcod_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSubCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cSubCod), 4, 0)));
            }
            AV11cPermEst = cgiGet( edtavCpermest_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPermEst", AV11cPermEst);
            /* Read saved values. */
            nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPCOD"), ",", ".") != Convert.ToDecimal( AV6cempcod )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAGECOD"), ",", ".") != Convert.ToDecimal( AV7cagecod )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMODCOD"), ",", ".") != Convert.ToDecimal( AV8cModCod )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMENCOD"), ",", ".") != Convert.ToDecimal( AV9cMenCod )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSUBCOD"), ",", ".") != Convert.ToDecimal( AV10cSubCod )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPERMEST"), AV11cPermEst) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E183H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E183H2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Level1", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV18ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E193H2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV21Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_74_Refreshing )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E203H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E203H2( )
      {
         /* Enter Routine */
         AV13pempcod = A15empcod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pempcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pempcod), 3, 0)));
         AV14pagecod = A16agecod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pagecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pagecod), 3, 0)));
         AV15pModCod = A11ModCod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pModCod), 4, 0)));
         AV16pMenCod = A12MenCod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pMenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pMenCod), 4, 0)));
         AV17pSubCod = A13SubCod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17pSubCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17pSubCod), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pempcod,(short)AV14pagecod,(short)AV15pModCod,(short)AV16pMenCod,(short)AV17pSubCod});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pempcod","AV14pagecod","AV15pModCod","AV16pMenCod","AV17pSubCod"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pUsuCod = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pUsuCod", AV12pUsuCod);
         AV13pempcod = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pempcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pempcod), 3, 0)));
         AV14pagecod = Convert.ToInt16(getParm(obj,2));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pagecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pagecod), 3, 0)));
         AV15pModCod = Convert.ToInt16(getParm(obj,3));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pModCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pModCod), 4, 0)));
         AV16pMenCod = Convert.ToInt16(getParm(obj,4));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pMenCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pMenCod), 4, 0)));
         AV17pSubCod = Convert.ToInt16(getParm(obj,5));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17pSubCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17pSubCod), 4, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         context.SetDefaultTheme("Carmine");
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA3H2( ) ;
         WS3H2( ) ;
         WE3H2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202262812103373", true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?"+GetCacheInvalidationToken( ), false);
         context.AddJavascriptSource("gx00e1.js", "?202262812103373", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtempcod_Internalname = "EMPCOD_"+sGXsfl_74_idx;
         edtagecod_Internalname = "AGECOD_"+sGXsfl_74_idx;
         edtModCod_Internalname = "MODCOD_"+sGXsfl_74_idx;
         edtMenCod_Internalname = "MENCOD_"+sGXsfl_74_idx;
         edtSubCod_Internalname = "SUBCOD_"+sGXsfl_74_idx;
         edtPermEst_Internalname = "PERMEST_"+sGXsfl_74_idx;
         edtUsuCod_Internalname = "USUCOD_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtempcod_Internalname = "EMPCOD_"+sGXsfl_74_fel_idx;
         edtagecod_Internalname = "AGECOD_"+sGXsfl_74_fel_idx;
         edtModCod_Internalname = "MODCOD_"+sGXsfl_74_fel_idx;
         edtMenCod_Internalname = "MENCOD_"+sGXsfl_74_fel_idx;
         edtSubCod_Internalname = "SUBCOD_"+sGXsfl_74_fel_idx;
         edtPermEst_Internalname = "PERMEST_"+sGXsfl_74_fel_idx;
         edtUsuCod_Internalname = "USUCOD_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB3H0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_74_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0;
               subGrid1_Backcolor = subGrid1_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform";
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)((nGXsfl_74_idx) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"PromptGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A15empcod), 3, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A16agecod), 3, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ModCod), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A12MenCod), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_74_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV21Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV21Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtempcod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A15empcod), 3, 0, ",", "")),context.localUtil.Format( (decimal)(A15empcod), "ZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtempcod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtagecod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A16agecod), 3, 0, ",", "")),context.localUtil.Format( (decimal)(A16agecod), "ZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtagecod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtModCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ModCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A11ModCod), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtModCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMenCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A12MenCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A12MenCod), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtMenCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSubCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A13SubCod), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSubCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtPermEst_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A15empcod), 3, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A16agecod), 3, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ModCod), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A12MenCod), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A13SubCod), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPermEst_Internalname, "Link", edtPermEst_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPermEst_Internalname,StringUtil.RTrim( A96PermEst),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtPermEst_Link,(String)"",(String)"",(String)"",(String)edtPermEst_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuCod_Internalname,StringUtil.RTrim( A3UsuCod),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtUsuCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes3H2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLblempcodfilter_Internalname = "LBLEMPCODFILTER";
         edtavCempcod_Internalname = "vCEMPCOD";
         divEmpcodfiltercontainer_Internalname = "EMPCODFILTERCONTAINER";
         lblLblagecodfilter_Internalname = "LBLAGECODFILTER";
         edtavCagecod_Internalname = "vCAGECOD";
         divAgecodfiltercontainer_Internalname = "AGECODFILTERCONTAINER";
         lblLblmodcodfilter_Internalname = "LBLMODCODFILTER";
         edtavCmodcod_Internalname = "vCMODCOD";
         divModcodfiltercontainer_Internalname = "MODCODFILTERCONTAINER";
         lblLblmencodfilter_Internalname = "LBLMENCODFILTER";
         edtavCmencod_Internalname = "vCMENCOD";
         divMencodfiltercontainer_Internalname = "MENCODFILTERCONTAINER";
         lblLblsubcodfilter_Internalname = "LBLSUBCODFILTER";
         edtavCsubcod_Internalname = "vCSUBCOD";
         divSubcodfiltercontainer_Internalname = "SUBCODFILTERCONTAINER";
         lblLblpermestfilter_Internalname = "LBLPERMESTFILTER";
         edtavCpermest_Internalname = "vCPERMEST";
         divPermestfiltercontainer_Internalname = "PERMESTFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtempcod_Internalname = "EMPCOD";
         edtagecod_Internalname = "AGECOD";
         edtModCod_Internalname = "MODCOD";
         edtMenCod_Internalname = "MENCOD";
         edtSubCod_Internalname = "SUBCOD";
         edtPermEst_Internalname = "PERMEST";
         edtUsuCod_Internalname = "USUCOD";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtUsuCod_Jsonclick = "";
         edtPermEst_Jsonclick = "";
         edtSubCod_Jsonclick = "";
         edtMenCod_Jsonclick = "";
         edtModCod_Jsonclick = "";
         edtagecod_Jsonclick = "";
         edtempcod_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtPermEst_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCpermest_Jsonclick = "";
         edtavCpermest_Enabled = 1;
         edtavCpermest_Visible = 1;
         edtavCsubcod_Jsonclick = "";
         edtavCsubcod_Enabled = 1;
         edtavCsubcod_Visible = 1;
         edtavCmencod_Jsonclick = "";
         edtavCmencod_Enabled = 1;
         edtavCmencod_Visible = 1;
         edtavCmodcod_Jsonclick = "";
         edtavCmodcod_Enabled = 1;
         edtavCmodcod_Visible = 1;
         edtavCagecod_Jsonclick = "";
         edtavCagecod_Enabled = 1;
         edtavCagecod_Visible = 1;
         edtavCempcod_Jsonclick = "";
         edtavCempcod_Enabled = 1;
         edtavCempcod_Visible = 1;
         divPermestfiltercontainer_Class = "AdvancedContainerItem";
         divSubcodfiltercontainer_Class = "AdvancedContainerItem";
         divMencodfiltercontainer_Class = "AdvancedContainerItem";
         divModcodfiltercontainer_Class = "AdvancedContainerItem";
         divAgecodfiltercontainer_Class = "AdvancedContainerItem";
         divEmpcodfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Level1";
         subGrid1_Rows = 10;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cempcod',fld:'vCEMPCOD',pic:'ZZ9'},{av:'AV7cagecod',fld:'vCAGECOD',pic:'ZZ9'},{av:'AV8cModCod',fld:'vCMODCOD',pic:'ZZZ9'},{av:'AV9cMenCod',fld:'vCMENCOD',pic:'ZZZ9'},{av:'AV10cSubCod',fld:'vCSUBCOD',pic:'ZZZ9'},{av:'AV11cPermEst',fld:'vCPERMEST',pic:''},{av:'AV12pUsuCod',fld:'vPUSUCOD',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E173H1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLEMPCODFILTER.CLICK","{handler:'E113H1',iparms:[{av:'divEmpcodfiltercontainer_Class',ctrl:'EMPCODFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLEMPCODFILTER.CLICK",",oparms:[{av:'divEmpcodfiltercontainer_Class',ctrl:'EMPCODFILTERCONTAINER',prop:'Class'},{av:'edtavCempcod_Visible',ctrl:'vCEMPCOD',prop:'Visible'}]}");
         setEventMetadata("LBLAGECODFILTER.CLICK","{handler:'E123H1',iparms:[{av:'divAgecodfiltercontainer_Class',ctrl:'AGECODFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAGECODFILTER.CLICK",",oparms:[{av:'divAgecodfiltercontainer_Class',ctrl:'AGECODFILTERCONTAINER',prop:'Class'},{av:'edtavCagecod_Visible',ctrl:'vCAGECOD',prop:'Visible'}]}");
         setEventMetadata("LBLMODCODFILTER.CLICK","{handler:'E133H1',iparms:[{av:'divModcodfiltercontainer_Class',ctrl:'MODCODFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLMODCODFILTER.CLICK",",oparms:[{av:'divModcodfiltercontainer_Class',ctrl:'MODCODFILTERCONTAINER',prop:'Class'},{av:'edtavCmodcod_Visible',ctrl:'vCMODCOD',prop:'Visible'}]}");
         setEventMetadata("LBLMENCODFILTER.CLICK","{handler:'E143H1',iparms:[{av:'divMencodfiltercontainer_Class',ctrl:'MENCODFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLMENCODFILTER.CLICK",",oparms:[{av:'divMencodfiltercontainer_Class',ctrl:'MENCODFILTERCONTAINER',prop:'Class'},{av:'edtavCmencod_Visible',ctrl:'vCMENCOD',prop:'Visible'}]}");
         setEventMetadata("LBLSUBCODFILTER.CLICK","{handler:'E153H1',iparms:[{av:'divSubcodfiltercontainer_Class',ctrl:'SUBCODFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLSUBCODFILTER.CLICK",",oparms:[{av:'divSubcodfiltercontainer_Class',ctrl:'SUBCODFILTERCONTAINER',prop:'Class'},{av:'edtavCsubcod_Visible',ctrl:'vCSUBCOD',prop:'Visible'}]}");
         setEventMetadata("LBLPERMESTFILTER.CLICK","{handler:'E163H1',iparms:[{av:'divPermestfiltercontainer_Class',ctrl:'PERMESTFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLPERMESTFILTER.CLICK",",oparms:[{av:'divPermestfiltercontainer_Class',ctrl:'PERMESTFILTERCONTAINER',prop:'Class'},{av:'edtavCpermest_Visible',ctrl:'vCPERMEST',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E203H2',iparms:[{av:'A15empcod',fld:'EMPCOD',pic:'ZZ9',hsh:true},{av:'A16agecod',fld:'AGECOD',pic:'ZZ9',hsh:true},{av:'A11ModCod',fld:'MODCOD',pic:'ZZZ9',hsh:true},{av:'A12MenCod',fld:'MENCOD',pic:'ZZZ9',hsh:true},{av:'A13SubCod',fld:'SUBCOD',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pempcod',fld:'vPEMPCOD',pic:'ZZ9'},{av:'AV14pagecod',fld:'vPAGECOD',pic:'ZZ9'},{av:'AV15pModCod',fld:'vPMODCOD',pic:'ZZZ9'},{av:'AV16pMenCod',fld:'vPMENCOD',pic:'ZZZ9'},{av:'AV17pSubCod',fld:'vPSUBCOD',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cempcod',fld:'vCEMPCOD',pic:'ZZ9'},{av:'AV7cagecod',fld:'vCAGECOD',pic:'ZZ9'},{av:'AV8cModCod',fld:'vCMODCOD',pic:'ZZZ9'},{av:'AV9cMenCod',fld:'vCMENCOD',pic:'ZZZ9'},{av:'AV10cSubCod',fld:'vCSUBCOD',pic:'ZZZ9'},{av:'AV11cPermEst',fld:'vCPERMEST',pic:''},{av:'AV12pUsuCod',fld:'vPUSUCOD',pic:''}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cempcod',fld:'vCEMPCOD',pic:'ZZ9'},{av:'AV7cagecod',fld:'vCAGECOD',pic:'ZZ9'},{av:'AV8cModCod',fld:'vCMODCOD',pic:'ZZZ9'},{av:'AV9cMenCod',fld:'vCMENCOD',pic:'ZZZ9'},{av:'AV10cSubCod',fld:'vCSUBCOD',pic:'ZZZ9'},{av:'AV11cPermEst',fld:'vCPERMEST',pic:''},{av:'AV12pUsuCod',fld:'vPUSUCOD',pic:''}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cempcod',fld:'vCEMPCOD',pic:'ZZ9'},{av:'AV7cagecod',fld:'vCAGECOD',pic:'ZZ9'},{av:'AV8cModCod',fld:'vCMODCOD',pic:'ZZZ9'},{av:'AV9cMenCod',fld:'vCMENCOD',pic:'ZZZ9'},{av:'AV10cSubCod',fld:'vCSUBCOD',pic:'ZZZ9'},{av:'AV11cPermEst',fld:'vCPERMEST',pic:''},{av:'AV12pUsuCod',fld:'vPUSUCOD',pic:''}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cempcod',fld:'vCEMPCOD',pic:'ZZ9'},{av:'AV7cagecod',fld:'vCAGECOD',pic:'ZZ9'},{av:'AV8cModCod',fld:'vCMODCOD',pic:'ZZZ9'},{av:'AV9cMenCod',fld:'vCMENCOD',pic:'ZZZ9'},{av:'AV10cSubCod',fld:'vCSUBCOD',pic:'ZZZ9'},{av:'AV11cPermEst',fld:'vCPERMEST',pic:''},{av:'AV12pUsuCod',fld:'vPUSUCOD',pic:''}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         wcpOAV12pUsuCod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV11cPermEst = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblempcodfilter_Jsonclick = "";
         TempTags = "";
         lblLblagecodfilter_Jsonclick = "";
         lblLblmodcodfilter_Jsonclick = "";
         lblLblmencodfilter_Jsonclick = "";
         lblLblsubcodfilter_Jsonclick = "";
         lblLblpermestfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A96PermEst = "";
         A3UsuCod = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV21Linkselection_GXI = "";
         scmdbuf = "";
         lV11cPermEst = "";
         H003H2_A3UsuCod = new String[] {""} ;
         H003H2_A96PermEst = new String[] {""} ;
         H003H2_n96PermEst = new bool[] {false} ;
         H003H2_A13SubCod = new short[1] ;
         H003H2_A12MenCod = new short[1] ;
         H003H2_A11ModCod = new short[1] ;
         H003H2_A16agecod = new short[1] ;
         H003H2_A15empcod = new short[1] ;
         H003H3_AGRID1_nRecordCount = new long[1] ;
         AV18ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00e1__default(),
            new Object[][] {
                new Object[] {
               H003H2_A3UsuCod, H003H2_A96PermEst, H003H2_n96PermEst, H003H2_A13SubCod, H003H2_A12MenCod, H003H2_A11ModCod, H003H2_A16agecod, H003H2_A15empcod
               }
               , new Object[] {
               H003H3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_74 ;
      private short nGXsfl_74_idx=1 ;
      private short GRID1_nEOF ;
      private short AV6cempcod ;
      private short AV7cagecod ;
      private short AV8cModCod ;
      private short AV9cMenCod ;
      private short AV10cSubCod ;
      private short AV13pempcod ;
      private short AV14pagecod ;
      private short AV15pModCod ;
      private short AV16pMenCod ;
      private short AV17pSubCod ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A15empcod ;
      private short A16agecod ;
      private short A11ModCod ;
      private short A12MenCod ;
      private short A13SubCod ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCempcod_Enabled ;
      private int edtavCempcod_Visible ;
      private int edtavCagecod_Enabled ;
      private int edtavCagecod_Visible ;
      private int edtavCmodcod_Enabled ;
      private int edtavCmodcod_Visible ;
      private int edtavCmencod_Enabled ;
      private int edtavCmencod_Visible ;
      private int edtavCsubcod_Enabled ;
      private int edtavCsubcod_Visible ;
      private int edtavCpermest_Visible ;
      private int edtavCpermest_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String AV12pUsuCod ;
      private String wcpOAV12pUsuCod ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divEmpcodfiltercontainer_Class ;
      private String divAgecodfiltercontainer_Class ;
      private String divModcodfiltercontainer_Class ;
      private String divMencodfiltercontainer_Class ;
      private String divSubcodfiltercontainer_Class ;
      private String divPermestfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String AV11cPermEst ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divEmpcodfiltercontainer_Internalname ;
      private String lblLblempcodfilter_Internalname ;
      private String lblLblempcodfilter_Jsonclick ;
      private String edtavCempcod_Internalname ;
      private String TempTags ;
      private String edtavCempcod_Jsonclick ;
      private String divAgecodfiltercontainer_Internalname ;
      private String lblLblagecodfilter_Internalname ;
      private String lblLblagecodfilter_Jsonclick ;
      private String edtavCagecod_Internalname ;
      private String edtavCagecod_Jsonclick ;
      private String divModcodfiltercontainer_Internalname ;
      private String lblLblmodcodfilter_Internalname ;
      private String lblLblmodcodfilter_Jsonclick ;
      private String edtavCmodcod_Internalname ;
      private String edtavCmodcod_Jsonclick ;
      private String divMencodfiltercontainer_Internalname ;
      private String lblLblmencodfilter_Internalname ;
      private String lblLblmencodfilter_Jsonclick ;
      private String edtavCmencod_Internalname ;
      private String edtavCmencod_Jsonclick ;
      private String divSubcodfiltercontainer_Internalname ;
      private String lblLblsubcodfilter_Internalname ;
      private String lblLblsubcodfilter_Jsonclick ;
      private String edtavCsubcod_Internalname ;
      private String edtavCsubcod_Jsonclick ;
      private String divPermestfiltercontainer_Internalname ;
      private String lblLblpermestfilter_Internalname ;
      private String lblLblpermestfilter_Jsonclick ;
      private String edtavCpermest_Internalname ;
      private String edtavCpermest_Jsonclick ;
      private String divGridtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String subGrid1_Header ;
      private String edtavLinkselection_Link ;
      private String A96PermEst ;
      private String edtPermEst_Link ;
      private String A3UsuCod ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtempcod_Internalname ;
      private String edtagecod_Internalname ;
      private String edtModCod_Internalname ;
      private String edtMenCod_Internalname ;
      private String edtSubCod_Internalname ;
      private String edtPermEst_Internalname ;
      private String edtUsuCod_Internalname ;
      private String scmdbuf ;
      private String lV11cPermEst ;
      private String AV18ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtempcod_Jsonclick ;
      private String edtagecod_Jsonclick ;
      private String edtModCod_Jsonclick ;
      private String edtMenCod_Jsonclick ;
      private String edtSubCod_Jsonclick ;
      private String edtPermEst_Jsonclick ;
      private String edtUsuCod_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool n96PermEst ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV21Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H003H2_A3UsuCod ;
      private String[] H003H2_A96PermEst ;
      private bool[] H003H2_n96PermEst ;
      private short[] H003H2_A13SubCod ;
      private short[] H003H2_A12MenCod ;
      private short[] H003H2_A11ModCod ;
      private short[] H003H2_A16agecod ;
      private short[] H003H2_A15empcod ;
      private long[] H003H3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP1_pempcod ;
      private short aP2_pagecod ;
      private short aP3_pModCod ;
      private short aP4_pMenCod ;
      private short aP5_pSubCod ;
      private GXWebForm Form ;
   }

   public class gx00e1__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H003H2( IGxContext context ,
                                             String AV11cPermEst ,
                                             String A96PermEst ,
                                             String AV12pUsuCod ,
                                             short AV6cempcod ,
                                             short AV7cagecod ,
                                             short AV8cModCod ,
                                             short AV9cMenCod ,
                                             short AV10cSubCod ,
                                             String A3UsuCod )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [10] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [UsuCod], [PermEst], [SubCod], [MenCod], [ModCod], [agecod], [empcod]";
         sFromString = " FROM [PERMISOS] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([UsuCod] = @AV12pUsuCod and [empcod] >= @AV6cempcod and [agecod] >= @AV7cagecod and [ModCod] >= @AV8cModCod and [MenCod] >= @AV9cMenCod and [SubCod] >= @AV10cSubCod)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cPermEst)) )
         {
            sWhereString = sWhereString + " and ([PermEst] like @lV11cPermEst)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [UsuCod], [empcod], [agecod], [ModCod], [MenCod], [SubCod]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H003H3( IGxContext context ,
                                             String AV11cPermEst ,
                                             String A96PermEst ,
                                             String AV12pUsuCod ,
                                             short AV6cempcod ,
                                             short AV7cagecod ,
                                             short AV8cModCod ,
                                             short AV9cMenCod ,
                                             short AV10cSubCod ,
                                             String A3UsuCod )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [PERMISOS] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([UsuCod] = @AV12pUsuCod and [empcod] >= @AV6cempcod and [agecod] >= @AV7cagecod and [ModCod] >= @AV8cModCod and [MenCod] >= @AV9cMenCod and [SubCod] >= @AV10cSubCod)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cPermEst)) )
         {
            sWhereString = sWhereString + " and ([PermEst] like @lV11cPermEst)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H003H2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] );
               case 1 :
                     return conditional_H003H3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH003H2 ;
          prmH003H2 = new Object[] {
          new Object[] {"@AV12pUsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@AV6cempcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV7cagecod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8cModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cMenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cSubCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV11cPermEst",SqlDbType.Char,1,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH003H3 ;
          prmH003H3 = new Object[] {
          new Object[] {"@AV12pUsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@AV6cempcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV7cagecod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8cModCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cMenCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cSubCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV11cPermEst",SqlDbType.Char,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003H2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003H2,11,0,false,false )
             ,new CursorDef("H003H3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003H3,1,0,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                return;
       }
    }

 }

}
