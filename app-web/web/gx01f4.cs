/*
               File: Gx01F4
        Description: Selection List det Inv
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:18:22.74
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
   public class gx01f4 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01f4( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx01f4( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_pEmpID ,
                           short aP1_pAgeID ,
                           short aP2_pBodCod ,
                           short aP3_pinvCod ,
                           out short aP4_pdetInvId )
      {
         this.AV9pEmpID = aP0_pEmpID;
         this.AV10pAgeID = aP1_pAgeID;
         this.AV11pBodCod = aP2_pBodCod;
         this.AV12pinvCod = aP3_pinvCod;
         this.AV13pdetInvId = 0 ;
         executePrivate();
         aP4_pdetInvId=this.AV13pdetInvId;
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
               nRC_GXsfl_44 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_44_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_44_idx = GetNextPar( );
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
               AV6cdetInvId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cdetInvCant = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cdetInvCosto = NumberUtil.Val( GetNextPar( ), ".");
               AV9pEmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV10pAgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11pBodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12pinvCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvId, AV7cdetInvCant, AV8cdetInvCosto, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
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
               AV9pEmpID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pEmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9pEmpID), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV10pAgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pAgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pAgeID), 4, 0)));
                  AV11pBodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pBodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pBodCod), 4, 0)));
                  AV12pinvCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pinvCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pinvCod), 4, 0)));
                  AV13pdetInvId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pdetInvId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pdetInvId), 4, 0)));
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
         PA5B2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START5B2( ) ;
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
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?2022102620182286", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx01f4.aspx") + "?" + UrlEncode("" +AV9pEmpID) + "," + UrlEncode("" +AV10pAgeID) + "," + UrlEncode("" +AV11pBodCod) + "," + UrlEncode("" +AV12pinvCod) + "," + UrlEncode("" +AV13pdetInvId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCDETINVID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cdetInvId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCDETINVCANT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cdetInvCant), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCDETINVCOSTO", StringUtil.LTrim( StringUtil.NToC( AV8cdetInvCosto, 8, 2, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_44", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_44), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9pEmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10pAgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPBODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pBodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPINVCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pinvCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPDETINVID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pdetInvId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "DETINVIDFILTERCONTAINER_Class", StringUtil.RTrim( divDetinvidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "DETINVCANTFILTERCONTAINER_Class", StringUtil.RTrim( divDetinvcantfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "DETINVCOSTOFILTERCONTAINER_Class", StringUtil.RTrim( divDetinvcostofiltercontainer_Class));
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
            WE5B2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT5B2( ) ;
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
         return formatLink("gx01f4.aspx") + "?" + UrlEncode("" +AV9pEmpID) + "," + UrlEncode("" +AV10pAgeID) + "," + UrlEncode("" +AV11pBodCod) + "," + UrlEncode("" +AV12pinvCod) + "," + UrlEncode("" +AV13pdetInvId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx01F4" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List det Inv" ;
      }

      protected void WB5B0( )
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
            GxWebStd.gx_div_start( context, divDetinvidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divDetinvidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldetinvidfilter_Internalname, "det Inv Id", "", "", lblLbldetinvidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e115b1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx01F4.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdetinvid_Internalname, "det Inv Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_44_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdetinvid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cdetInvId), 4, 0, ",", "")), ((edtavCdetinvid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cdetInvId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cdetInvId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdetinvid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdetinvid_Visible, edtavCdetinvid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx01F4.htm");
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
            GxWebStd.gx_div_start( context, divDetinvcantfiltercontainer_Internalname, 1, 0, "px", 0, "px", divDetinvcantfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldetinvcantfilter_Internalname, "Cantidad", "", "", lblLbldetinvcantfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e125b1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx01F4.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdetinvcant_Internalname, "Cantidad", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_44_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdetinvcant_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cdetInvCant), 8, 0, ",", "")), ((edtavCdetinvcant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cdetInvCant), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7cdetInvCant), "ZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdetinvcant_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdetinvcant_Visible, edtavCdetinvcant_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx01F4.htm");
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
            GxWebStd.gx_div_start( context, divDetinvcostofiltercontainer_Internalname, 1, 0, "px", 0, "px", divDetinvcostofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldetinvcostofilter_Internalname, "Costo Inv", "", "", lblLbldetinvcostofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e135b1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx01F4.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdetinvcosto_Internalname, "Costo Inv", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_44_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdetinvcosto_Internalname, StringUtil.LTrim( StringUtil.NToC( AV8cdetInvCosto, 8, 2, ",", "")), ((edtavCdetinvcosto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV8cdetInvCosto, "ZZZZ9.99")) : context.localUtil.Format( AV8cdetInvCosto, "ZZZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdetinvcosto_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdetinvcosto_Visible, edtavCdetinvcosto_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx01F4.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(44), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e145b1_client"+"'", TempTags, "", 2, "HLP_Gx01F4.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"44\">") ;
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
               context.SendWebValue( "Inv Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cantidad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Inv") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Uni Cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Emp ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Age ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Bod Cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "inv Cod") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A273detInvId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A274detInvCant), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A275detInvCosto, 8, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A341detInvUniCod));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtdetInvUniCod_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A264invCod), 4, 0, ".", "")));
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
         if ( wbEnd == 44 )
         {
            wbEnd = 0;
            nRC_GXsfl_44 = (short)(nGXsfl_44_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(44), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx01F4.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 44 )
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

      protected void START5B2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Selection List det Inv", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5B0( ) ;
      }

      protected void WS5B2( )
      {
         START5B2( ) ;
         EVT5B2( ) ;
      }

      protected void EVT5B2( )
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
                              nGXsfl_44_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_44_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_44_idx), 4, 0)), 4, "0");
                              SubsflControlProps_442( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_44_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A273detInvId = (short)(context.localUtil.CToN( cgiGet( edtdetInvId_Internalname), ",", "."));
                              A274detInvCant = (int)(context.localUtil.CToN( cgiGet( edtdetInvCant_Internalname), ",", "."));
                              n274detInvCant = false;
                              A275detInvCosto = context.localUtil.CToN( cgiGet( edtdetInvCosto_Internalname), ",", ".");
                              n275detInvCosto = false;
                              A286PrdCod = (short)(context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", "."));
                              A341detInvUniCod = cgiGet( edtdetInvUniCod_Internalname);
                              n341detInvUniCod = false;
                              A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                              A2AgeID = (short)(context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", "."));
                              A42BodCod = (short)(context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", "."));
                              A264invCod = (short)(context.localUtil.CToN( cgiGet( edtinvCod_Internalname), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E155B2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E165B2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cdetinvid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDETINVID"), ",", ".") != Convert.ToDecimal( AV6cdetInvId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cdetinvcant Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDETINVCANT"), ",", ".") != Convert.ToDecimal( AV7cdetInvCant )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cdetinvcosto Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCDETINVCOSTO"), ",", ".") != AV8cdetInvCosto )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E175B2 ();
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

      protected void WE5B2( )
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

      protected void PA5B2( )
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
         SubsflControlProps_442( ) ;
         while ( nGXsfl_44_idx <= nRC_GXsfl_44 )
         {
            sendrow_442( ) ;
            nGXsfl_44_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_44_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_44_idx+1));
            sGXsfl_44_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_44_idx), 4, 0)), 4, "0");
            SubsflControlProps_442( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cdetInvId ,
                                        int AV7cdetInvCant ,
                                        decimal AV8cdetInvCosto ,
                                        short AV9pEmpID ,
                                        short AV10pAgeID ,
                                        short AV11pBodCod ,
                                        short AV12pinvCod )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF5B2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_DETINVID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A273detInvId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "DETINVID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A273detInvId), 4, 0, ".", "")));
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
         RF5B2( ) ;
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

      protected void RF5B2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 44;
         nGXsfl_44_idx = 1;
         sGXsfl_44_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_44_idx), 4, 0)), 4, "0");
         SubsflControlProps_442( ) ;
         bGXsfl_44_Refreshing = true;
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
            SubsflControlProps_442( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cdetInvCant ,
                                                 AV8cdetInvCosto ,
                                                 A274detInvCant ,
                                                 A275detInvCosto ,
                                                 AV9pEmpID ,
                                                 AV10pAgeID ,
                                                 AV11pBodCod ,
                                                 AV12pinvCod ,
                                                 AV6cdetInvId ,
                                                 A1EmpID ,
                                                 A2AgeID ,
                                                 A42BodCod ,
                                                 A264invCod } ,
                                                 new int[]{
                                                 TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            /* Using cursor H005B2 */
            pr_default.execute(0, new Object[] {AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod, AV6cdetInvId, AV7cdetInvCant, AV8cdetInvCosto, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_44_idx = 1;
            sGXsfl_44_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_44_idx), 4, 0)), 4, "0");
            SubsflControlProps_442( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A264invCod = H005B2_A264invCod[0];
               A42BodCod = H005B2_A42BodCod[0];
               A2AgeID = H005B2_A2AgeID[0];
               A1EmpID = H005B2_A1EmpID[0];
               A341detInvUniCod = H005B2_A341detInvUniCod[0];
               n341detInvUniCod = H005B2_n341detInvUniCod[0];
               A286PrdCod = H005B2_A286PrdCod[0];
               A275detInvCosto = H005B2_A275detInvCosto[0];
               n275detInvCosto = H005B2_n275detInvCosto[0];
               A274detInvCant = H005B2_A274detInvCant[0];
               n274detInvCant = H005B2_n274detInvCant[0];
               A273detInvId = H005B2_A273detInvId[0];
               /* Execute user event: Load */
               E165B2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 44;
            WB5B0( ) ;
         }
         bGXsfl_44_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5B2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_DETINVID"+"_"+sGXsfl_44_idx, GetSecureSignedToken( sGXsfl_44_idx, context.localUtil.Format( (decimal)(A273detInvId), "ZZZ9"), context));
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
                                              AV7cdetInvCant ,
                                              AV8cdetInvCosto ,
                                              A274detInvCant ,
                                              A275detInvCosto ,
                                              AV9pEmpID ,
                                              AV10pAgeID ,
                                              AV11pBodCod ,
                                              AV12pinvCod ,
                                              AV6cdetInvId ,
                                              A1EmpID ,
                                              A2AgeID ,
                                              A42BodCod ,
                                              A264invCod } ,
                                              new int[]{
                                              TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor H005B3 */
         pr_default.execute(1, new Object[] {AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod, AV6cdetInvId, AV7cdetInvCant, AV8cdetInvCosto});
         GRID1_nRecordCount = H005B3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvId, AV7cdetInvCant, AV8cdetInvCosto, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvId, AV7cdetInvCant, AV8cdetInvCosto, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvId, AV7cdetInvCant, AV8cdetInvCosto, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvId, AV7cdetInvCant, AV8cdetInvCosto, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvId, AV7cdetInvCant, AV8cdetInvCosto, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5B0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E155B2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCdetinvid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCdetinvid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCDETINVID");
               GX_FocusControl = edtavCdetinvid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cdetInvId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cdetInvId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cdetInvId), 4, 0)));
            }
            else
            {
               AV6cdetInvId = (short)(context.localUtil.CToN( cgiGet( edtavCdetinvid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cdetInvId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cdetInvId), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCdetinvcant_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCdetinvcant_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCDETINVCANT");
               GX_FocusControl = edtavCdetinvcant_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cdetInvCant = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cdetInvCant", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cdetInvCant), 8, 0)));
            }
            else
            {
               AV7cdetInvCant = (int)(context.localUtil.CToN( cgiGet( edtavCdetinvcant_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cdetInvCant", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cdetInvCant), 8, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCdetinvcosto_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCdetinvcosto_Internalname), ",", ".") > 99999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCDETINVCOSTO");
               GX_FocusControl = edtavCdetinvcosto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cdetInvCosto = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cdetInvCosto", StringUtil.LTrim( StringUtil.Str( AV8cdetInvCosto, 8, 2)));
            }
            else
            {
               AV8cdetInvCosto = context.localUtil.CToN( cgiGet( edtavCdetinvcosto_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cdetInvCosto", StringUtil.LTrim( StringUtil.Str( AV8cdetInvCosto, 8, 2)));
            }
            /* Read saved values. */
            nRC_GXsfl_44 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_44"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDETINVID"), ",", ".") != Convert.ToDecimal( AV6cdetInvId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDETINVCANT"), ",", ".") != Convert.ToDecimal( AV7cdetInvCant )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCDETINVCOSTO"), ",", ".") != AV8cdetInvCosto )
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
         E155B2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E155B2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selecci�n %1", "det Inv", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E165B2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV17Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_442( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_44_Refreshing )
         {
            context.DoAjaxLoad(44, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E175B2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E175B2( )
      {
         /* Enter Routine */
         AV13pdetInvId = A273detInvId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pdetInvId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pdetInvId), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pdetInvId});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pdetInvId"});
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
         AV9pEmpID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pEmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9pEmpID), 4, 0)));
         AV10pAgeID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pAgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pAgeID), 4, 0)));
         AV11pBodCod = Convert.ToInt16(getParm(obj,2));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pBodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pBodCod), 4, 0)));
         AV12pinvCod = Convert.ToInt16(getParm(obj,3));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pinvCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pinvCod), 4, 0)));
         AV13pdetInvId = Convert.ToInt16(getParm(obj,4));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pdetInvId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pdetInvId), 4, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA5B2( ) ;
         WS5B2( ) ;
         WE5B2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202210262018257", true);
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
         context.AddJavascriptSource("gx01f4.js", "?202210262018257", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_442( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_44_idx;
         edtdetInvId_Internalname = "DETINVID_"+sGXsfl_44_idx;
         edtdetInvCant_Internalname = "DETINVCANT_"+sGXsfl_44_idx;
         edtdetInvCosto_Internalname = "DETINVCOSTO_"+sGXsfl_44_idx;
         edtPrdCod_Internalname = "PRDCOD_"+sGXsfl_44_idx;
         edtdetInvUniCod_Internalname = "DETINVUNICOD_"+sGXsfl_44_idx;
         edtEmpID_Internalname = "EMPID_"+sGXsfl_44_idx;
         edtAgeID_Internalname = "AGEID_"+sGXsfl_44_idx;
         edtBodCod_Internalname = "BODCOD_"+sGXsfl_44_idx;
         edtinvCod_Internalname = "INVCOD_"+sGXsfl_44_idx;
      }

      protected void SubsflControlProps_fel_442( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_44_fel_idx;
         edtdetInvId_Internalname = "DETINVID_"+sGXsfl_44_fel_idx;
         edtdetInvCant_Internalname = "DETINVCANT_"+sGXsfl_44_fel_idx;
         edtdetInvCosto_Internalname = "DETINVCOSTO_"+sGXsfl_44_fel_idx;
         edtPrdCod_Internalname = "PRDCOD_"+sGXsfl_44_fel_idx;
         edtdetInvUniCod_Internalname = "DETINVUNICOD_"+sGXsfl_44_fel_idx;
         edtEmpID_Internalname = "EMPID_"+sGXsfl_44_fel_idx;
         edtAgeID_Internalname = "AGEID_"+sGXsfl_44_fel_idx;
         edtBodCod_Internalname = "BODCOD_"+sGXsfl_44_fel_idx;
         edtinvCod_Internalname = "INVCOD_"+sGXsfl_44_fel_idx;
      }

      protected void sendrow_442( )
      {
         SubsflControlProps_442( ) ;
         WB5B0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_44_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_44_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"PromptGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_44_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A273detInvId), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_44_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV17Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A273detInvId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A273detInvId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvCant_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A274detInvCant), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A274detInvCant), "ZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvCant_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvCosto_Internalname,StringUtil.LTrim( StringUtil.NToC( A275detInvCosto, 8, 2, ",", "")),context.localUtil.Format( A275detInvCosto, "ZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvCosto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrdCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrdCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtdetInvUniCod_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A273detInvId), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvUniCod_Internalname, "Link", edtdetInvUniCod_Link, !bGXsfl_44_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvUniCod_Internalname,StringUtil.RTrim( A341detInvUniCod),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtdetInvUniCod_Link,(String)"",(String)"",(String)"",(String)edtdetInvUniCod_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEmpID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAgeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAgeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBodCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtinvCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A264invCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A264invCod), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtinvCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes5B2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_44_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_44_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_44_idx+1));
            sGXsfl_44_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_44_idx), 4, 0)), 4, "0");
            SubsflControlProps_442( ) ;
         }
         /* End function sendrow_442 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLbldetinvidfilter_Internalname = "LBLDETINVIDFILTER";
         edtavCdetinvid_Internalname = "vCDETINVID";
         divDetinvidfiltercontainer_Internalname = "DETINVIDFILTERCONTAINER";
         lblLbldetinvcantfilter_Internalname = "LBLDETINVCANTFILTER";
         edtavCdetinvcant_Internalname = "vCDETINVCANT";
         divDetinvcantfiltercontainer_Internalname = "DETINVCANTFILTERCONTAINER";
         lblLbldetinvcostofilter_Internalname = "LBLDETINVCOSTOFILTER";
         edtavCdetinvcosto_Internalname = "vCDETINVCOSTO";
         divDetinvcostofiltercontainer_Internalname = "DETINVCOSTOFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtdetInvId_Internalname = "DETINVID";
         edtdetInvCant_Internalname = "DETINVCANT";
         edtdetInvCosto_Internalname = "DETINVCOSTO";
         edtPrdCod_Internalname = "PRDCOD";
         edtdetInvUniCod_Internalname = "DETINVUNICOD";
         edtEmpID_Internalname = "EMPID";
         edtAgeID_Internalname = "AGEID";
         edtBodCod_Internalname = "BODCOD";
         edtinvCod_Internalname = "INVCOD";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtinvCod_Jsonclick = "";
         edtBodCod_Jsonclick = "";
         edtAgeID_Jsonclick = "";
         edtEmpID_Jsonclick = "";
         edtdetInvUniCod_Jsonclick = "";
         edtPrdCod_Jsonclick = "";
         edtdetInvCosto_Jsonclick = "";
         edtdetInvCant_Jsonclick = "";
         edtdetInvId_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtdetInvUniCod_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCdetinvcosto_Jsonclick = "";
         edtavCdetinvcosto_Enabled = 1;
         edtavCdetinvcosto_Visible = 1;
         edtavCdetinvcant_Jsonclick = "";
         edtavCdetinvcant_Enabled = 1;
         edtavCdetinvcant_Visible = 1;
         edtavCdetinvid_Jsonclick = "";
         edtavCdetinvid_Enabled = 1;
         edtavCdetinvid_Visible = 1;
         divDetinvcostofiltercontainer_Class = "AdvancedContainerItem";
         divDetinvcantfiltercontainer_Class = "AdvancedContainerItem";
         divDetinvidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List det Inv";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cdetInvId',fld:'vCDETINVID',pic:'ZZZ9'},{av:'AV7cdetInvCant',fld:'vCDETINVCANT',pic:'ZZZZZZZ9'},{av:'AV8cdetInvCosto',fld:'vCDETINVCOSTO',pic:'ZZZZ9.99'},{av:'AV9pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV10pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV11pBodCod',fld:'vPBODCOD',pic:'ZZZ9'},{av:'AV12pinvCod',fld:'vPINVCOD',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E145B1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLDETINVIDFILTER.CLICK","{handler:'E115B1',iparms:[{av:'divDetinvidfiltercontainer_Class',ctrl:'DETINVIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDETINVIDFILTER.CLICK",",oparms:[{av:'divDetinvidfiltercontainer_Class',ctrl:'DETINVIDFILTERCONTAINER',prop:'Class'},{av:'edtavCdetinvid_Visible',ctrl:'vCDETINVID',prop:'Visible'}]}");
         setEventMetadata("LBLDETINVCANTFILTER.CLICK","{handler:'E125B1',iparms:[{av:'divDetinvcantfiltercontainer_Class',ctrl:'DETINVCANTFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDETINVCANTFILTER.CLICK",",oparms:[{av:'divDetinvcantfiltercontainer_Class',ctrl:'DETINVCANTFILTERCONTAINER',prop:'Class'},{av:'edtavCdetinvcant_Visible',ctrl:'vCDETINVCANT',prop:'Visible'}]}");
         setEventMetadata("LBLDETINVCOSTOFILTER.CLICK","{handler:'E135B1',iparms:[{av:'divDetinvcostofiltercontainer_Class',ctrl:'DETINVCOSTOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDETINVCOSTOFILTER.CLICK",",oparms:[{av:'divDetinvcostofiltercontainer_Class',ctrl:'DETINVCOSTOFILTERCONTAINER',prop:'Class'},{av:'edtavCdetinvcosto_Visible',ctrl:'vCDETINVCOSTO',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E175B2',iparms:[{av:'A273detInvId',fld:'DETINVID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pdetInvId',fld:'vPDETINVID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cdetInvId',fld:'vCDETINVID',pic:'ZZZ9'},{av:'AV7cdetInvCant',fld:'vCDETINVCANT',pic:'ZZZZZZZ9'},{av:'AV8cdetInvCosto',fld:'vCDETINVCOSTO',pic:'ZZZZ9.99'},{av:'AV9pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV10pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV11pBodCod',fld:'vPBODCOD',pic:'ZZZ9'},{av:'AV12pinvCod',fld:'vPINVCOD',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cdetInvId',fld:'vCDETINVID',pic:'ZZZ9'},{av:'AV7cdetInvCant',fld:'vCDETINVCANT',pic:'ZZZZZZZ9'},{av:'AV8cdetInvCosto',fld:'vCDETINVCOSTO',pic:'ZZZZ9.99'},{av:'AV9pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV10pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV11pBodCod',fld:'vPBODCOD',pic:'ZZZ9'},{av:'AV12pinvCod',fld:'vPINVCOD',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cdetInvId',fld:'vCDETINVID',pic:'ZZZ9'},{av:'AV7cdetInvCant',fld:'vCDETINVCANT',pic:'ZZZZZZZ9'},{av:'AV8cdetInvCosto',fld:'vCDETINVCOSTO',pic:'ZZZZ9.99'},{av:'AV9pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV10pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV11pBodCod',fld:'vPBODCOD',pic:'ZZZ9'},{av:'AV12pinvCod',fld:'vPINVCOD',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cdetInvId',fld:'vCDETINVID',pic:'ZZZ9'},{av:'AV7cdetInvCant',fld:'vCDETINVCANT',pic:'ZZZZZZZ9'},{av:'AV8cdetInvCosto',fld:'vCDETINVCOSTO',pic:'ZZZZ9.99'},{av:'AV9pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV10pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV11pBodCod',fld:'vPBODCOD',pic:'ZZZ9'},{av:'AV12pinvCod',fld:'vPINVCOD',pic:'ZZZ9'}]");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLbldetinvidfilter_Jsonclick = "";
         TempTags = "";
         lblLbldetinvcantfilter_Jsonclick = "";
         lblLbldetinvcostofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A341detInvUniCod = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         H005B2_A264invCod = new short[1] ;
         H005B2_A42BodCod = new short[1] ;
         H005B2_A2AgeID = new short[1] ;
         H005B2_A1EmpID = new short[1] ;
         H005B2_A341detInvUniCod = new String[] {""} ;
         H005B2_n341detInvUniCod = new bool[] {false} ;
         H005B2_A286PrdCod = new short[1] ;
         H005B2_A275detInvCosto = new decimal[1] ;
         H005B2_n275detInvCosto = new bool[] {false} ;
         H005B2_A274detInvCant = new int[1] ;
         H005B2_n274detInvCant = new bool[] {false} ;
         H005B2_A273detInvId = new short[1] ;
         H005B3_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01f4__default(),
            new Object[][] {
                new Object[] {
               H005B2_A264invCod, H005B2_A42BodCod, H005B2_A2AgeID, H005B2_A1EmpID, H005B2_A341detInvUniCod, H005B2_n341detInvUniCod, H005B2_A286PrdCod, H005B2_A275detInvCosto, H005B2_n275detInvCosto, H005B2_A274detInvCant,
               H005B2_n274detInvCant, H005B2_A273detInvId
               }
               , new Object[] {
               H005B3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9pEmpID ;
      private short AV10pAgeID ;
      private short AV11pBodCod ;
      private short AV12pinvCod ;
      private short wcpOAV9pEmpID ;
      private short wcpOAV10pAgeID ;
      private short wcpOAV11pBodCod ;
      private short wcpOAV12pinvCod ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_44 ;
      private short nGXsfl_44_idx=1 ;
      private short GRID1_nEOF ;
      private short AV6cdetInvId ;
      private short AV13pdetInvId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A273detInvId ;
      private short A286PrdCod ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short A42BodCod ;
      private short A264invCod ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int AV7cdetInvCant ;
      private int edtavCdetinvid_Enabled ;
      private int edtavCdetinvid_Visible ;
      private int edtavCdetinvcant_Enabled ;
      private int edtavCdetinvcant_Visible ;
      private int edtavCdetinvcosto_Enabled ;
      private int edtavCdetinvcosto_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A274detInvCant ;
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
      private decimal AV8cdetInvCosto ;
      private decimal A275detInvCosto ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divDetinvidfiltercontainer_Class ;
      private String divDetinvcantfiltercontainer_Class ;
      private String divDetinvcostofiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_44_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divDetinvidfiltercontainer_Internalname ;
      private String lblLbldetinvidfilter_Internalname ;
      private String lblLbldetinvidfilter_Jsonclick ;
      private String edtavCdetinvid_Internalname ;
      private String TempTags ;
      private String edtavCdetinvid_Jsonclick ;
      private String divDetinvcantfiltercontainer_Internalname ;
      private String lblLbldetinvcantfilter_Internalname ;
      private String lblLbldetinvcantfilter_Jsonclick ;
      private String edtavCdetinvcant_Internalname ;
      private String edtavCdetinvcant_Jsonclick ;
      private String divDetinvcostofiltercontainer_Internalname ;
      private String lblLbldetinvcostofilter_Internalname ;
      private String lblLbldetinvcostofilter_Jsonclick ;
      private String edtavCdetinvcosto_Internalname ;
      private String edtavCdetinvcosto_Jsonclick ;
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
      private String A341detInvUniCod ;
      private String edtdetInvUniCod_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtdetInvId_Internalname ;
      private String edtdetInvCant_Internalname ;
      private String edtdetInvCosto_Internalname ;
      private String edtPrdCod_Internalname ;
      private String edtdetInvUniCod_Internalname ;
      private String edtEmpID_Internalname ;
      private String edtAgeID_Internalname ;
      private String edtBodCod_Internalname ;
      private String edtinvCod_Internalname ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_44_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtdetInvId_Jsonclick ;
      private String edtdetInvCant_Jsonclick ;
      private String edtdetInvCosto_Jsonclick ;
      private String edtPrdCod_Jsonclick ;
      private String edtdetInvUniCod_Jsonclick ;
      private String edtEmpID_Jsonclick ;
      private String edtAgeID_Jsonclick ;
      private String edtBodCod_Jsonclick ;
      private String edtinvCod_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_44_Refreshing=false ;
      private bool n274detInvCant ;
      private bool n275detInvCosto ;
      private bool n341detInvUniCod ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV17Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H005B2_A264invCod ;
      private short[] H005B2_A42BodCod ;
      private short[] H005B2_A2AgeID ;
      private short[] H005B2_A1EmpID ;
      private String[] H005B2_A341detInvUniCod ;
      private bool[] H005B2_n341detInvUniCod ;
      private short[] H005B2_A286PrdCod ;
      private decimal[] H005B2_A275detInvCosto ;
      private bool[] H005B2_n275detInvCosto ;
      private int[] H005B2_A274detInvCant ;
      private bool[] H005B2_n274detInvCant ;
      private short[] H005B2_A273detInvId ;
      private long[] H005B3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP4_pdetInvId ;
      private GXWebForm Form ;
   }

   public class gx01f4__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005B2( IGxContext context ,
                                             int AV7cdetInvCant ,
                                             decimal AV8cdetInvCosto ,
                                             int A274detInvCant ,
                                             decimal A275detInvCosto ,
                                             short AV9pEmpID ,
                                             short AV10pAgeID ,
                                             short AV11pBodCod ,
                                             short AV12pinvCod ,
                                             short AV6cdetInvId ,
                                             short A1EmpID ,
                                             short A2AgeID ,
                                             short A42BodCod ,
                                             short A264invCod )
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
         sSelectString = " [invCod], [BodCod], [AgeID], [EmpID], [detInvUniCod], [PrdCod], [detInvCosto], [detInvCant], [detInvId]";
         sFromString = " FROM [InventariodetInv] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([EmpID] = @AV9pEmpID and [AgeID] = @AV10pAgeID and [BodCod] = @AV11pBodCod and [invCod] = @AV12pinvCod and [detInvId] >= @AV6cdetInvId)";
         if ( ! (0==AV7cdetInvCant) )
         {
            sWhereString = sWhereString + " and ([detInvCant] >= @AV7cdetInvCant)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV8cdetInvCosto) )
         {
            sWhereString = sWhereString + " and ([detInvCosto] >= @AV8cdetInvCosto)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [EmpID], [AgeID], [BodCod], [invCod], [detInvId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H005B3( IGxContext context ,
                                             int AV7cdetInvCant ,
                                             decimal AV8cdetInvCosto ,
                                             int A274detInvCant ,
                                             decimal A275detInvCosto ,
                                             short AV9pEmpID ,
                                             short AV10pAgeID ,
                                             short AV11pBodCod ,
                                             short AV12pinvCod ,
                                             short AV6cdetInvId ,
                                             short A1EmpID ,
                                             short A2AgeID ,
                                             short A42BodCod ,
                                             short A264invCod )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [InventariodetInv] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([EmpID] = @AV9pEmpID and [AgeID] = @AV10pAgeID and [BodCod] = @AV11pBodCod and [invCod] = @AV12pinvCod and [detInvId] >= @AV6cdetInvId)";
         if ( ! (0==AV7cdetInvCant) )
         {
            sWhereString = sWhereString + " and ([detInvCant] >= @AV7cdetInvCant)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV8cdetInvCosto) )
         {
            sWhereString = sWhereString + " and ([detInvCosto] >= @AV8cdetInvCosto)";
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
                     return conditional_H005B2(context, (int)dynConstraints[0] , (decimal)dynConstraints[1] , (int)dynConstraints[2] , (decimal)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
               case 1 :
                     return conditional_H005B3(context, (int)dynConstraints[0] , (decimal)dynConstraints[1] , (int)dynConstraints[2] , (decimal)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
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
          Object[] prmH005B2 ;
          prmH005B2 = new Object[] {
          new Object[] {"@AV9pEmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10pAgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11pBodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12pinvCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cdetInvId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cdetInvCant",SqlDbType.Int,8,0} ,
          new Object[] {"@AV8cdetInvCosto",SqlDbType.Decimal,8,2} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005B3 ;
          prmH005B3 = new Object[] {
          new Object[] {"@AV9pEmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10pAgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11pBodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12pinvCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cdetInvId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cdetInvCant",SqlDbType.Int,8,0} ,
          new Object[] {"@AV8cdetInvCosto",SqlDbType.Decimal,8,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005B2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B2,11,0,false,false )
             ,new CursorDef("H005B3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B3,1,0,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((int[]) buf[9])[0] = rslt.getInt(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
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
                   stmt.SetParameter(sIdx, (short)parms[10]);
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
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[16]);
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
                   stmt.SetParameter(sIdx, (short)parms[7]);
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
                   stmt.SetParameter(sIdx, (int)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[13]);
                }
                return;
       }
    }

 }

}
