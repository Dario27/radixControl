/*
               File: Gx01E4
        Description: Selection List det Inv Oc
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:17:42.44
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
   public class gx01e4 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01e4( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx01e4( IGxContext context )
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
                           out short aP4_pdetInvOcId )
      {
         this.AV9pEmpID = aP0_pEmpID;
         this.AV10pAgeID = aP1_pAgeID;
         this.AV11pBodCod = aP2_pBodCod;
         this.AV12pinvCod = aP3_pinvCod;
         this.AV13pdetInvOcId = 0 ;
         executePrivate();
         aP4_pdetInvOcId=this.AV13pdetInvOcId;
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
               AV6cdetInvOcId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cdetInvOCNro = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV15cdetInvOcDoc = GetNextPar( );
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
               gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvOcId, AV8cdetInvOCNro, AV15cdetInvOcDoc, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
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
                  AV13pdetInvOcId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pdetInvOcId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pdetInvOcId), 4, 0)));
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
         PA462( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START462( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022102620174255", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx01e4.aspx") + "?" + UrlEncode("" +AV9pEmpID) + "," + UrlEncode("" +AV10pAgeID) + "," + UrlEncode("" +AV11pBodCod) + "," + UrlEncode("" +AV12pinvCod) + "," + UrlEncode("" +AV13pdetInvOcId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCDETINVOCID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cdetInvOcId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCDETINVOCNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cdetInvOCNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCDETINVOCDOC", StringUtil.RTrim( AV15cdetInvOcDoc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_44", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_44), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9pEmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10pAgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPBODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pBodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPINVCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pinvCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPDETINVOCID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pdetInvOcId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "DETINVOCIDFILTERCONTAINER_Class", StringUtil.RTrim( divDetinvocidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "DETINVOCNROFILTERCONTAINER_Class", StringUtil.RTrim( divDetinvocnrofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "DETINVOCDOCFILTERCONTAINER_Class", StringUtil.RTrim( divDetinvocdocfiltercontainer_Class));
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
            WE462( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT462( ) ;
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
         return formatLink("gx01e4.aspx") + "?" + UrlEncode("" +AV9pEmpID) + "," + UrlEncode("" +AV10pAgeID) + "," + UrlEncode("" +AV11pBodCod) + "," + UrlEncode("" +AV12pinvCod) + "," + UrlEncode("" +AV13pdetInvOcId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx01E4" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List det Inv Oc" ;
      }

      protected void WB460( )
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
            GxWebStd.gx_div_start( context, divDetinvocidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divDetinvocidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldetinvocidfilter_Internalname, "det Inv Oc Id", "", "", lblLbldetinvocidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11461_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx01E4.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdetinvocid_Internalname, "det Inv Oc Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_44_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdetinvocid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cdetInvOcId), 4, 0, ",", "")), ((edtavCdetinvocid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cdetInvOcId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cdetInvOcId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdetinvocid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdetinvocid_Visible, edtavCdetinvocid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx01E4.htm");
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
            GxWebStd.gx_div_start( context, divDetinvocnrofiltercontainer_Internalname, 1, 0, "px", 0, "px", divDetinvocnrofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldetinvocnrofilter_Internalname, "OCNro", "", "", lblLbldetinvocnrofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12461_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx01E4.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdetinvocnro_Internalname, "OCNro", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_44_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdetinvocnro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cdetInvOCNro), 8, 0, ",", "")), ((edtavCdetinvocnro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cdetInvOCNro), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8cdetInvOCNro), "ZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdetinvocnro_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdetinvocnro_Visible, edtavCdetinvocnro_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx01E4.htm");
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
            GxWebStd.gx_div_start( context, divDetinvocdocfiltercontainer_Internalname, 1, 0, "px", 0, "px", divDetinvocdocfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldetinvocdocfilter_Internalname, "Documento", "", "", lblLbldetinvocdocfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13461_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx01E4.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdetinvocdoc_Internalname, "Documento", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_44_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdetinvocdoc_Internalname, StringUtil.RTrim( AV15cdetInvOcDoc), StringUtil.RTrim( context.localUtil.Format( AV15cdetInvOcDoc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdetinvocdoc_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdetinvocdoc_Visible, edtavCdetinvocdoc_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx01E4.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(44), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e14461_client"+"'", TempTags, "", 2, "HLP_Gx01E4.htm");
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
               context.SendWebValue( "Oc Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "OCNro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Documento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Ruc") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A282detInvOcId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A283detInvOCNro), 8, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtdetInvOCNro_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A284detInvOcDoc));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A37PrvRuc));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(44), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx01E4.htm");
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

      protected void START462( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Selection List det Inv Oc", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP460( ) ;
      }

      protected void WS462( )
      {
         START462( ) ;
         EVT462( ) ;
      }

      protected void EVT462( )
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
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_44_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A282detInvOcId = (short)(context.localUtil.CToN( cgiGet( edtdetInvOcId_Internalname), ",", "."));
                              A283detInvOCNro = (int)(context.localUtil.CToN( cgiGet( edtdetInvOCNro_Internalname), ",", "."));
                              n283detInvOCNro = false;
                              A284detInvOcDoc = cgiGet( edtdetInvOcDoc_Internalname);
                              n284detInvOcDoc = false;
                              A37PrvRuc = cgiGet( edtPrvRuc_Internalname);
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
                                    E15462 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E16462 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cdetinvocid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDETINVOCID"), ",", ".") != Convert.ToDecimal( AV6cdetInvOcId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cdetinvocnro Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDETINVOCNRO"), ",", ".") != Convert.ToDecimal( AV8cdetInvOCNro )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cdetinvocdoc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCDETINVOCDOC"), AV15cdetInvOcDoc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E17462 ();
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

      protected void WE462( )
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

      protected void PA462( )
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
                                        short AV6cdetInvOcId ,
                                        int AV8cdetInvOCNro ,
                                        String AV15cdetInvOcDoc ,
                                        short AV9pEmpID ,
                                        short AV10pAgeID ,
                                        short AV11pBodCod ,
                                        short AV12pinvCod )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF462( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_DETINVOCID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A282detInvOcId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "DETINVOCID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A282detInvOcId), 4, 0, ".", "")));
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
         RF462( ) ;
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

      protected void RF462( )
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
                                                 AV8cdetInvOCNro ,
                                                 AV15cdetInvOcDoc ,
                                                 A283detInvOCNro ,
                                                 A284detInvOcDoc ,
                                                 AV9pEmpID ,
                                                 AV10pAgeID ,
                                                 AV11pBodCod ,
                                                 AV12pinvCod ,
                                                 AV6cdetInvOcId ,
                                                 A1EmpID ,
                                                 A2AgeID ,
                                                 A42BodCod ,
                                                 A264invCod } ,
                                                 new int[]{
                                                 TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            lV15cdetInvOcDoc = StringUtil.PadR( StringUtil.RTrim( AV15cdetInvOcDoc), 3, "%");
            /* Using cursor H00462 */
            pr_default.execute(0, new Object[] {AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod, AV6cdetInvOcId, AV8cdetInvOCNro, lV15cdetInvOcDoc, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_44_idx = 1;
            sGXsfl_44_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_44_idx), 4, 0)), 4, "0");
            SubsflControlProps_442( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A264invCod = H00462_A264invCod[0];
               A42BodCod = H00462_A42BodCod[0];
               A2AgeID = H00462_A2AgeID[0];
               A1EmpID = H00462_A1EmpID[0];
               A37PrvRuc = H00462_A37PrvRuc[0];
               A284detInvOcDoc = H00462_A284detInvOcDoc[0];
               n284detInvOcDoc = H00462_n284detInvOcDoc[0];
               A283detInvOCNro = H00462_A283detInvOCNro[0];
               n283detInvOCNro = H00462_n283detInvOCNro[0];
               A282detInvOcId = H00462_A282detInvOcId[0];
               /* Execute user event: Load */
               E16462 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 44;
            WB460( ) ;
         }
         bGXsfl_44_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes462( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_DETINVOCID"+"_"+sGXsfl_44_idx, GetSecureSignedToken( sGXsfl_44_idx, context.localUtil.Format( (decimal)(A282detInvOcId), "ZZZ9"), context));
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
                                              AV8cdetInvOCNro ,
                                              AV15cdetInvOcDoc ,
                                              A283detInvOCNro ,
                                              A284detInvOcDoc ,
                                              AV9pEmpID ,
                                              AV10pAgeID ,
                                              AV11pBodCod ,
                                              AV12pinvCod ,
                                              AV6cdetInvOcId ,
                                              A1EmpID ,
                                              A2AgeID ,
                                              A42BodCod ,
                                              A264invCod } ,
                                              new int[]{
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         lV15cdetInvOcDoc = StringUtil.PadR( StringUtil.RTrim( AV15cdetInvOcDoc), 3, "%");
         /* Using cursor H00463 */
         pr_default.execute(1, new Object[] {AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod, AV6cdetInvOcId, AV8cdetInvOCNro, lV15cdetInvOcDoc});
         GRID1_nRecordCount = H00463_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvOcId, AV8cdetInvOCNro, AV15cdetInvOcDoc, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvOcId, AV8cdetInvOCNro, AV15cdetInvOcDoc, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvOcId, AV8cdetInvOCNro, AV15cdetInvOcDoc, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvOcId, AV8cdetInvOCNro, AV15cdetInvOcDoc, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cdetInvOcId, AV8cdetInvOCNro, AV15cdetInvOcDoc, AV9pEmpID, AV10pAgeID, AV11pBodCod, AV12pinvCod) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP460( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E15462 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCdetinvocid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCdetinvocid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCDETINVOCID");
               GX_FocusControl = edtavCdetinvocid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cdetInvOcId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cdetInvOcId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cdetInvOcId), 4, 0)));
            }
            else
            {
               AV6cdetInvOcId = (short)(context.localUtil.CToN( cgiGet( edtavCdetinvocid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cdetInvOcId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cdetInvOcId), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCdetinvocnro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCdetinvocnro_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCDETINVOCNRO");
               GX_FocusControl = edtavCdetinvocnro_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cdetInvOCNro = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cdetInvOCNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cdetInvOCNro), 8, 0)));
            }
            else
            {
               AV8cdetInvOCNro = (int)(context.localUtil.CToN( cgiGet( edtavCdetinvocnro_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cdetInvOCNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cdetInvOCNro), 8, 0)));
            }
            AV15cdetInvOcDoc = cgiGet( edtavCdetinvocdoc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cdetInvOcDoc", AV15cdetInvOcDoc);
            /* Read saved values. */
            nRC_GXsfl_44 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_44"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDETINVOCID"), ",", ".") != Convert.ToDecimal( AV6cdetInvOcId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDETINVOCNRO"), ",", ".") != Convert.ToDecimal( AV8cdetInvOCNro )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCDETINVOCDOC"), AV15cdetInvOcDoc) != 0 )
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
         E15462 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E15462( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selecci�n %1", "det Inv Oc", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E16462( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV18Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E17462 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E17462( )
      {
         /* Enter Routine */
         AV13pdetInvOcId = A282detInvOcId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pdetInvOcId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pdetInvOcId), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pdetInvOcId});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pdetInvOcId"});
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
         AV13pdetInvOcId = Convert.ToInt16(getParm(obj,4));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pdetInvOcId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pdetInvOcId), 4, 0)));
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
         PA462( ) ;
         WS462( ) ;
         WE462( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022102620174478", true);
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
         context.AddJavascriptSource("gx01e4.js", "?2022102620174479", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_442( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_44_idx;
         edtdetInvOcId_Internalname = "DETINVOCID_"+sGXsfl_44_idx;
         edtdetInvOCNro_Internalname = "DETINVOCNRO_"+sGXsfl_44_idx;
         edtdetInvOcDoc_Internalname = "DETINVOCDOC_"+sGXsfl_44_idx;
         edtPrvRuc_Internalname = "PRVRUC_"+sGXsfl_44_idx;
         edtEmpID_Internalname = "EMPID_"+sGXsfl_44_idx;
         edtAgeID_Internalname = "AGEID_"+sGXsfl_44_idx;
         edtBodCod_Internalname = "BODCOD_"+sGXsfl_44_idx;
         edtinvCod_Internalname = "INVCOD_"+sGXsfl_44_idx;
      }

      protected void SubsflControlProps_fel_442( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_44_fel_idx;
         edtdetInvOcId_Internalname = "DETINVOCID_"+sGXsfl_44_fel_idx;
         edtdetInvOCNro_Internalname = "DETINVOCNRO_"+sGXsfl_44_fel_idx;
         edtdetInvOcDoc_Internalname = "DETINVOCDOC_"+sGXsfl_44_fel_idx;
         edtPrvRuc_Internalname = "PRVRUC_"+sGXsfl_44_fel_idx;
         edtEmpID_Internalname = "EMPID_"+sGXsfl_44_fel_idx;
         edtAgeID_Internalname = "AGEID_"+sGXsfl_44_fel_idx;
         edtBodCod_Internalname = "BODCOD_"+sGXsfl_44_fel_idx;
         edtinvCod_Internalname = "INVCOD_"+sGXsfl_44_fel_idx;
      }

      protected void sendrow_442( )
      {
         SubsflControlProps_442( ) ;
         WB460( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A282detInvOcId), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_44_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV18Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvOcId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A282detInvOcId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A282detInvOcId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvOcId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtdetInvOCNro_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A282detInvOcId), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvOCNro_Internalname, "Link", edtdetInvOCNro_Link, !bGXsfl_44_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvOCNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A283detInvOCNro), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A283detInvOCNro), "ZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtdetInvOCNro_Link,(String)"",(String)"",(String)"",(String)edtdetInvOCNro_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvOcDoc_Internalname,StringUtil.RTrim( A284detInvOcDoc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvOcDoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrvRuc_Internalname,StringUtil.RTrim( A37PrvRuc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrvRuc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)44,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
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
            send_integrity_lvl_hashes462( ) ;
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
         lblLbldetinvocidfilter_Internalname = "LBLDETINVOCIDFILTER";
         edtavCdetinvocid_Internalname = "vCDETINVOCID";
         divDetinvocidfiltercontainer_Internalname = "DETINVOCIDFILTERCONTAINER";
         lblLbldetinvocnrofilter_Internalname = "LBLDETINVOCNROFILTER";
         edtavCdetinvocnro_Internalname = "vCDETINVOCNRO";
         divDetinvocnrofiltercontainer_Internalname = "DETINVOCNROFILTERCONTAINER";
         lblLbldetinvocdocfilter_Internalname = "LBLDETINVOCDOCFILTER";
         edtavCdetinvocdoc_Internalname = "vCDETINVOCDOC";
         divDetinvocdocfiltercontainer_Internalname = "DETINVOCDOCFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtdetInvOcId_Internalname = "DETINVOCID";
         edtdetInvOCNro_Internalname = "DETINVOCNRO";
         edtdetInvOcDoc_Internalname = "DETINVOCDOC";
         edtPrvRuc_Internalname = "PRVRUC";
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
         edtPrvRuc_Jsonclick = "";
         edtdetInvOcDoc_Jsonclick = "";
         edtdetInvOCNro_Jsonclick = "";
         edtdetInvOcId_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtdetInvOCNro_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCdetinvocdoc_Jsonclick = "";
         edtavCdetinvocdoc_Enabled = 1;
         edtavCdetinvocdoc_Visible = 1;
         edtavCdetinvocnro_Jsonclick = "";
         edtavCdetinvocnro_Enabled = 1;
         edtavCdetinvocnro_Visible = 1;
         edtavCdetinvocid_Jsonclick = "";
         edtavCdetinvocid_Enabled = 1;
         edtavCdetinvocid_Visible = 1;
         divDetinvocdocfiltercontainer_Class = "AdvancedContainerItem";
         divDetinvocnrofiltercontainer_Class = "AdvancedContainerItem";
         divDetinvocidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List det Inv Oc";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cdetInvOcId',fld:'vCDETINVOCID',pic:'ZZZ9'},{av:'AV8cdetInvOCNro',fld:'vCDETINVOCNRO',pic:'ZZZZZZZ9'},{av:'AV15cdetInvOcDoc',fld:'vCDETINVOCDOC',pic:''},{av:'AV9pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV10pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV11pBodCod',fld:'vPBODCOD',pic:'ZZZ9'},{av:'AV12pinvCod',fld:'vPINVCOD',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E14461',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLDETINVOCIDFILTER.CLICK","{handler:'E11461',iparms:[{av:'divDetinvocidfiltercontainer_Class',ctrl:'DETINVOCIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDETINVOCIDFILTER.CLICK",",oparms:[{av:'divDetinvocidfiltercontainer_Class',ctrl:'DETINVOCIDFILTERCONTAINER',prop:'Class'},{av:'edtavCdetinvocid_Visible',ctrl:'vCDETINVOCID',prop:'Visible'}]}");
         setEventMetadata("LBLDETINVOCNROFILTER.CLICK","{handler:'E12461',iparms:[{av:'divDetinvocnrofiltercontainer_Class',ctrl:'DETINVOCNROFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDETINVOCNROFILTER.CLICK",",oparms:[{av:'divDetinvocnrofiltercontainer_Class',ctrl:'DETINVOCNROFILTERCONTAINER',prop:'Class'},{av:'edtavCdetinvocnro_Visible',ctrl:'vCDETINVOCNRO',prop:'Visible'}]}");
         setEventMetadata("LBLDETINVOCDOCFILTER.CLICK","{handler:'E13461',iparms:[{av:'divDetinvocdocfiltercontainer_Class',ctrl:'DETINVOCDOCFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDETINVOCDOCFILTER.CLICK",",oparms:[{av:'divDetinvocdocfiltercontainer_Class',ctrl:'DETINVOCDOCFILTERCONTAINER',prop:'Class'},{av:'edtavCdetinvocdoc_Visible',ctrl:'vCDETINVOCDOC',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E17462',iparms:[{av:'A282detInvOcId',fld:'DETINVOCID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pdetInvOcId',fld:'vPDETINVOCID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cdetInvOcId',fld:'vCDETINVOCID',pic:'ZZZ9'},{av:'AV8cdetInvOCNro',fld:'vCDETINVOCNRO',pic:'ZZZZZZZ9'},{av:'AV15cdetInvOcDoc',fld:'vCDETINVOCDOC',pic:''},{av:'AV9pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV10pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV11pBodCod',fld:'vPBODCOD',pic:'ZZZ9'},{av:'AV12pinvCod',fld:'vPINVCOD',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cdetInvOcId',fld:'vCDETINVOCID',pic:'ZZZ9'},{av:'AV8cdetInvOCNro',fld:'vCDETINVOCNRO',pic:'ZZZZZZZ9'},{av:'AV15cdetInvOcDoc',fld:'vCDETINVOCDOC',pic:''},{av:'AV9pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV10pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV11pBodCod',fld:'vPBODCOD',pic:'ZZZ9'},{av:'AV12pinvCod',fld:'vPINVCOD',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cdetInvOcId',fld:'vCDETINVOCID',pic:'ZZZ9'},{av:'AV8cdetInvOCNro',fld:'vCDETINVOCNRO',pic:'ZZZZZZZ9'},{av:'AV15cdetInvOcDoc',fld:'vCDETINVOCDOC',pic:''},{av:'AV9pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV10pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV11pBodCod',fld:'vPBODCOD',pic:'ZZZ9'},{av:'AV12pinvCod',fld:'vPINVCOD',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cdetInvOcId',fld:'vCDETINVOCID',pic:'ZZZ9'},{av:'AV8cdetInvOCNro',fld:'vCDETINVOCNRO',pic:'ZZZZZZZ9'},{av:'AV15cdetInvOcDoc',fld:'vCDETINVOCDOC',pic:''},{av:'AV9pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV10pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV11pBodCod',fld:'vPBODCOD',pic:'ZZZ9'},{av:'AV12pinvCod',fld:'vPINVCOD',pic:'ZZZ9'}]");
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
         AV15cdetInvOcDoc = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLbldetinvocidfilter_Jsonclick = "";
         TempTags = "";
         lblLbldetinvocnrofilter_Jsonclick = "";
         lblLbldetinvocdocfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A284detInvOcDoc = "";
         A37PrvRuc = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18Linkselection_GXI = "";
         scmdbuf = "";
         lV15cdetInvOcDoc = "";
         H00462_A264invCod = new short[1] ;
         H00462_A42BodCod = new short[1] ;
         H00462_A2AgeID = new short[1] ;
         H00462_A1EmpID = new short[1] ;
         H00462_A37PrvRuc = new String[] {""} ;
         H00462_A284detInvOcDoc = new String[] {""} ;
         H00462_n284detInvOcDoc = new bool[] {false} ;
         H00462_A283detInvOCNro = new int[1] ;
         H00462_n283detInvOCNro = new bool[] {false} ;
         H00462_A282detInvOcId = new short[1] ;
         H00463_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01e4__default(),
            new Object[][] {
                new Object[] {
               H00462_A264invCod, H00462_A42BodCod, H00462_A2AgeID, H00462_A1EmpID, H00462_A37PrvRuc, H00462_A284detInvOcDoc, H00462_n284detInvOcDoc, H00462_A283detInvOCNro, H00462_n283detInvOCNro, H00462_A282detInvOcId
               }
               , new Object[] {
               H00463_AGRID1_nRecordCount
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
      private short AV6cdetInvOcId ;
      private short AV13pdetInvOcId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A282detInvOcId ;
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
      private int AV8cdetInvOCNro ;
      private int edtavCdetinvocid_Enabled ;
      private int edtavCdetinvocid_Visible ;
      private int edtavCdetinvocnro_Enabled ;
      private int edtavCdetinvocnro_Visible ;
      private int edtavCdetinvocdoc_Visible ;
      private int edtavCdetinvocdoc_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int A283detInvOCNro ;
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
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divDetinvocidfiltercontainer_Class ;
      private String divDetinvocnrofiltercontainer_Class ;
      private String divDetinvocdocfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_44_idx="0001" ;
      private String AV15cdetInvOcDoc ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divDetinvocidfiltercontainer_Internalname ;
      private String lblLbldetinvocidfilter_Internalname ;
      private String lblLbldetinvocidfilter_Jsonclick ;
      private String edtavCdetinvocid_Internalname ;
      private String TempTags ;
      private String edtavCdetinvocid_Jsonclick ;
      private String divDetinvocnrofiltercontainer_Internalname ;
      private String lblLbldetinvocnrofilter_Internalname ;
      private String lblLbldetinvocnrofilter_Jsonclick ;
      private String edtavCdetinvocnro_Internalname ;
      private String edtavCdetinvocnro_Jsonclick ;
      private String divDetinvocdocfiltercontainer_Internalname ;
      private String lblLbldetinvocdocfilter_Internalname ;
      private String lblLbldetinvocdocfilter_Jsonclick ;
      private String edtavCdetinvocdoc_Internalname ;
      private String edtavCdetinvocdoc_Jsonclick ;
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
      private String edtdetInvOCNro_Link ;
      private String A284detInvOcDoc ;
      private String A37PrvRuc ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtdetInvOcId_Internalname ;
      private String edtdetInvOCNro_Internalname ;
      private String edtdetInvOcDoc_Internalname ;
      private String edtPrvRuc_Internalname ;
      private String edtEmpID_Internalname ;
      private String edtAgeID_Internalname ;
      private String edtBodCod_Internalname ;
      private String edtinvCod_Internalname ;
      private String scmdbuf ;
      private String lV15cdetInvOcDoc ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_44_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtdetInvOcId_Jsonclick ;
      private String edtdetInvOCNro_Jsonclick ;
      private String edtdetInvOcDoc_Jsonclick ;
      private String edtPrvRuc_Jsonclick ;
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
      private bool n283detInvOCNro ;
      private bool n284detInvOcDoc ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV18Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H00462_A264invCod ;
      private short[] H00462_A42BodCod ;
      private short[] H00462_A2AgeID ;
      private short[] H00462_A1EmpID ;
      private String[] H00462_A37PrvRuc ;
      private String[] H00462_A284detInvOcDoc ;
      private bool[] H00462_n284detInvOcDoc ;
      private int[] H00462_A283detInvOCNro ;
      private bool[] H00462_n283detInvOCNro ;
      private short[] H00462_A282detInvOcId ;
      private long[] H00463_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP4_pdetInvOcId ;
      private GXWebForm Form ;
   }

   public class gx01e4__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00462( IGxContext context ,
                                             int AV8cdetInvOCNro ,
                                             String AV15cdetInvOcDoc ,
                                             int A283detInvOCNro ,
                                             String A284detInvOcDoc ,
                                             short AV9pEmpID ,
                                             short AV10pAgeID ,
                                             short AV11pBodCod ,
                                             short AV12pinvCod ,
                                             short AV6cdetInvOcId ,
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
         sSelectString = " [invCod], [BodCod], [AgeID], [EmpID], [PrvRuc], [detInvOcDoc], [detInvOCNro], [detInvOcId]";
         sFromString = " FROM [InventariodetInvOc] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([EmpID] = @AV9pEmpID and [AgeID] = @AV10pAgeID and [BodCod] = @AV11pBodCod and [invCod] = @AV12pinvCod and [detInvOcId] >= @AV6cdetInvOcId)";
         if ( ! (0==AV8cdetInvOCNro) )
         {
            sWhereString = sWhereString + " and ([detInvOCNro] >= @AV8cdetInvOCNro)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15cdetInvOcDoc)) )
         {
            sWhereString = sWhereString + " and ([detInvOcDoc] like @lV15cdetInvOcDoc)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [EmpID], [AgeID], [BodCod], [invCod], [detInvOcId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00463( IGxContext context ,
                                             int AV8cdetInvOCNro ,
                                             String AV15cdetInvOcDoc ,
                                             int A283detInvOCNro ,
                                             String A284detInvOcDoc ,
                                             short AV9pEmpID ,
                                             short AV10pAgeID ,
                                             short AV11pBodCod ,
                                             short AV12pinvCod ,
                                             short AV6cdetInvOcId ,
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
         scmdbuf = "SELECT COUNT(*) FROM [InventariodetInvOc] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([EmpID] = @AV9pEmpID and [AgeID] = @AV10pAgeID and [BodCod] = @AV11pBodCod and [invCod] = @AV12pinvCod and [detInvOcId] >= @AV6cdetInvOcId)";
         if ( ! (0==AV8cdetInvOCNro) )
         {
            sWhereString = sWhereString + " and ([detInvOCNro] >= @AV8cdetInvOCNro)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15cdetInvOcDoc)) )
         {
            sWhereString = sWhereString + " and ([detInvOcDoc] like @lV15cdetInvOcDoc)";
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
                     return conditional_H00462(context, (int)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
               case 1 :
                     return conditional_H00463(context, (int)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
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
          Object[] prmH00462 ;
          prmH00462 = new Object[] {
          new Object[] {"@AV9pEmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10pAgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11pBodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12pinvCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cdetInvOcId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cdetInvOCNro",SqlDbType.Int,8,0} ,
          new Object[] {"@lV15cdetInvOcDoc",SqlDbType.Char,3,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00463 ;
          prmH00463 = new Object[] {
          new Object[] {"@AV9pEmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10pAgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11pBodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12pinvCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cdetInvOcId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cdetInvOCNro",SqlDbType.Int,8,0} ,
          new Object[] {"@lV15cdetInvOcDoc",SqlDbType.Char,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00462", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00462,11,0,false,false )
             ,new CursorDef("H00463", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00463,1,0,false,false )
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
                ((String[]) buf[4])[0] = rslt.getString(5, 13) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 3) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((int[]) buf[7])[0] = rslt.getInt(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
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
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                return;
       }
    }

 }

}
