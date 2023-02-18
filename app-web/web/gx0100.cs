/*
               File: Gx0100
        Description: Selection List Tipo Movimiento
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:16:56.63
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
   public class gx0100 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0100( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0100( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pTipoInv )
      {
         this.AV13pTipoInv = "" ;
         executePrivate();
         aP0_pTipoInv=this.AV13pTipoInv;
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
               nRC_GXsfl_84 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_84_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_84_idx = GetNextPar( );
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
               AV6cTipoInv = GetNextPar( );
               AV7cTipoInvMov = GetNextPar( );
               AV8cTipoInvEst = GetNextPar( );
               AV9cTipoInvActivo = GetNextPar( );
               AV10cTipoInvUso = GetNextPar( );
               AV11cTipoInvSigno = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12cTipoInvTipo = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cTipoInv, AV7cTipoInvMov, AV8cTipoInvEst, AV9cTipoInvActivo, AV10cTipoInvUso, AV11cTipoInvSigno, AV12cTipoInvTipo) ;
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
               AV13pTipoInv = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTipoInv", AV13pTipoInv);
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
         PA372( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START372( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022102620165682", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0100.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pTipoInv))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOINV", StringUtil.RTrim( AV6cTipoInv));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOINVMOV", AV7cTipoInvMov);
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOINVEST", StringUtil.RTrim( AV8cTipoInvEst));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOINVACTIVO", StringUtil.RTrim( AV9cTipoInvActivo));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOINVUSO", StringUtil.RTrim( AV10cTipoInvUso));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOINVSIGNO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cTipoInvSigno), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOINVTIPO", StringUtil.RTrim( AV12cTipoInvTipo));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTIPOINV", StringUtil.RTrim( AV13pTipoInv));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "TIPOINVFILTERCONTAINER_Class", StringUtil.RTrim( divTipoinvfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOINVMOVFILTERCONTAINER_Class", StringUtil.RTrim( divTipoinvmovfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOINVESTFILTERCONTAINER_Class", StringUtil.RTrim( divTipoinvestfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOINVACTIVOFILTERCONTAINER_Class", StringUtil.RTrim( divTipoinvactivofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOINVUSOFILTERCONTAINER_Class", StringUtil.RTrim( divTipoinvusofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOINVSIGNOFILTERCONTAINER_Class", StringUtil.RTrim( divTipoinvsignofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TIPOINVTIPOFILTERCONTAINER_Class", StringUtil.RTrim( divTipoinvtipofiltercontainer_Class));
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
            WE372( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT372( ) ;
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
         return formatLink("gx0100.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pTipoInv)) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0100" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Tipo Movimiento" ;
      }

      protected void WB370( )
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
            GxWebStd.gx_div_start( context, divTipoinvfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipoinvfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipoinvfilter_Internalname, "Codigo", "", "", lblLbltipoinvfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11371_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0100.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipoinv_Internalname, "Codigo", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipoinv_Internalname, StringUtil.RTrim( AV6cTipoInv), StringUtil.RTrim( context.localUtil.Format( AV6cTipoInv, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipoinv_Jsonclick, 0, "Attribute", "", "", "", "", edtavCtipoinv_Visible, edtavCtipoinv_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0100.htm");
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
            GxWebStd.gx_div_start( context, divTipoinvmovfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipoinvmovfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipoinvmovfilter_Internalname, "Tipo Movimiento", "", "", lblLbltipoinvmovfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12371_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0100.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipoinvmov_Internalname, "Tipo Movimiento", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipoinvmov_Internalname, AV7cTipoInvMov, StringUtil.RTrim( context.localUtil.Format( AV7cTipoInvMov, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipoinvmov_Jsonclick, 0, "Attribute", "", "", "", "", edtavCtipoinvmov_Visible, edtavCtipoinvmov_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0100.htm");
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
            GxWebStd.gx_div_start( context, divTipoinvestfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipoinvestfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipoinvestfilter_Internalname, "Estado", "", "", lblLbltipoinvestfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13371_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0100.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipoinvest_Internalname, "Estado", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipoinvest_Internalname, StringUtil.RTrim( AV8cTipoInvEst), StringUtil.RTrim( context.localUtil.Format( AV8cTipoInvEst, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipoinvest_Jsonclick, 0, "Attribute", "", "", "", "", edtavCtipoinvest_Visible, edtavCtipoinvest_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0100.htm");
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
            GxWebStd.gx_div_start( context, divTipoinvactivofiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipoinvactivofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipoinvactivofilter_Internalname, "Tipo Activo", "", "", lblLbltipoinvactivofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14371_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0100.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipoinvactivo_Internalname, "Tipo Activo", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipoinvactivo_Internalname, StringUtil.RTrim( AV9cTipoInvActivo), StringUtil.RTrim( context.localUtil.Format( AV9cTipoInvActivo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipoinvactivo_Jsonclick, 0, "Attribute", "", "", "", "", edtavCtipoinvactivo_Visible, edtavCtipoinvactivo_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0100.htm");
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
            GxWebStd.gx_div_start( context, divTipoinvusofiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipoinvusofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipoinvusofilter_Internalname, "Uso", "", "", lblLbltipoinvusofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15371_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0100.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipoinvuso_Internalname, "Uso", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipoinvuso_Internalname, StringUtil.RTrim( AV10cTipoInvUso), StringUtil.RTrim( context.localUtil.Format( AV10cTipoInvUso, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipoinvuso_Jsonclick, 0, "Attribute", "", "", "", "", edtavCtipoinvuso_Visible, edtavCtipoinvuso_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0100.htm");
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
            GxWebStd.gx_div_start( context, divTipoinvsignofiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipoinvsignofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipoinvsignofilter_Internalname, "Signo", "", "", lblLbltipoinvsignofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16371_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0100.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipoinvsigno_Internalname, "Signo", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipoinvsigno_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cTipoInvSigno), 2, 0, ",", "")), ((edtavCtipoinvsigno_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cTipoInvSigno), "Z9")) : context.localUtil.Format( (decimal)(AV11cTipoInvSigno), "Z9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipoinvsigno_Jsonclick, 0, "Attribute", "", "", "", "", edtavCtipoinvsigno_Visible, edtavCtipoinvsigno_Enabled, 0, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0100.htm");
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
            GxWebStd.gx_div_start( context, divTipoinvtipofiltercontainer_Internalname, 1, 0, "px", 0, "px", divTipoinvtipofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltipoinvtipofilter_Internalname, "Tipo", "", "", lblLbltipoinvtipofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17371_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0100.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCtipoinvtipo_Internalname, "Tipo", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCtipoinvtipo_Internalname, StringUtil.RTrim( AV12cTipoInvTipo), StringUtil.RTrim( context.localUtil.Format( AV12cTipoInvTipo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtipoinvtipo_Jsonclick, 0, "Attribute", "", "", "", "", edtavCtipoinvtipo_Visible, edtavCtipoinvtipo_Enabled, 0, "text", "", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0100.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18371_client"+"'", TempTags, "", 2, "HLP_Gx0100.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"84\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo ") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Movimiento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo Activo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Uso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Signo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A43TipoInv));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A219TipoInvMov);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtTipoInvMov_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A220TipoInvEst));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A221TipoInvActivo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A222TipoInvUso));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A224TipoInvTipo));
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
         if ( wbEnd == 84 )
         {
            wbEnd = 0;
            nRC_GXsfl_84 = (short)(nGXsfl_84_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0100.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 84 )
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

      protected void START372( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Selection List Tipo Movimiento", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP370( ) ;
      }

      protected void WS372( )
      {
         START372( ) ;
         EVT372( ) ;
      }

      protected void EVT372( )
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
                              nGXsfl_84_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
                              SubsflControlProps_842( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_84_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A43TipoInv = cgiGet( edtTipoInv_Internalname);
                              A219TipoInvMov = cgiGet( edtTipoInvMov_Internalname);
                              n219TipoInvMov = false;
                              A220TipoInvEst = cgiGet( edtTipoInvEst_Internalname);
                              n220TipoInvEst = false;
                              A221TipoInvActivo = cgiGet( edtTipoInvActivo_Internalname);
                              n221TipoInvActivo = false;
                              A222TipoInvUso = cgiGet( edtTipoInvUso_Internalname);
                              n222TipoInvUso = false;
                              A223TipoInvSigno = (short)(context.localUtil.CToN( cgiGet( edtTipoInvSigno_Internalname), ",", "."));
                              n223TipoInvSigno = false;
                              A224TipoInvTipo = cgiGet( edtTipoInvTipo_Internalname);
                              n224TipoInvTipo = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E19372 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E20372 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Ctipoinv Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINV"), AV6cTipoInv) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipoinvmov Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINVMOV"), AV7cTipoInvMov) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipoinvest Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINVEST"), AV8cTipoInvEst) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipoinvactivo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINVACTIVO"), AV9cTipoInvActivo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipoinvuso Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINVUSO"), AV10cTipoInvUso) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipoinvsigno Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOINVSIGNO"), ",", ".") != Convert.ToDecimal( AV11cTipoInvSigno )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctipoinvtipo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINVTIPO"), AV12cTipoInvTipo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E21372 ();
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

      protected void WE372( )
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

      protected void PA372( )
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
         SubsflControlProps_842( ) ;
         while ( nGXsfl_84_idx <= nRC_GXsfl_84 )
         {
            sendrow_842( ) ;
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        String AV6cTipoInv ,
                                        String AV7cTipoInvMov ,
                                        String AV8cTipoInvEst ,
                                        String AV9cTipoInvActivo ,
                                        String AV10cTipoInvUso ,
                                        short AV11cTipoInvSigno ,
                                        String AV12cTipoInvTipo )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF372( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_TIPOINV", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A43TipoInv, "")), context));
         GxWebStd.gx_hidden_field( context, "TIPOINV", StringUtil.RTrim( A43TipoInv));
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
         RF372( ) ;
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

      protected void RF372( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 84;
         nGXsfl_84_idx = 1;
         sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
         SubsflControlProps_842( ) ;
         bGXsfl_84_Refreshing = true;
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
            SubsflControlProps_842( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cTipoInvMov ,
                                                 AV8cTipoInvEst ,
                                                 AV9cTipoInvActivo ,
                                                 AV10cTipoInvUso ,
                                                 AV11cTipoInvSigno ,
                                                 AV12cTipoInvTipo ,
                                                 A219TipoInvMov ,
                                                 A220TipoInvEst ,
                                                 A221TipoInvActivo ,
                                                 A222TipoInvUso ,
                                                 A223TipoInvSigno ,
                                                 A224TipoInvTipo ,
                                                 A43TipoInv ,
                                                 AV6cTipoInv } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING
                                                 }
            } ) ;
            lV6cTipoInv = StringUtil.PadR( StringUtil.RTrim( AV6cTipoInv), 4, "%");
            lV7cTipoInvMov = StringUtil.Concat( StringUtil.RTrim( AV7cTipoInvMov), "%", "");
            lV8cTipoInvEst = StringUtil.PadR( StringUtil.RTrim( AV8cTipoInvEst), 1, "%");
            lV9cTipoInvActivo = StringUtil.PadR( StringUtil.RTrim( AV9cTipoInvActivo), 1, "%");
            lV10cTipoInvUso = StringUtil.PadR( StringUtil.RTrim( AV10cTipoInvUso), 1, "%");
            lV12cTipoInvTipo = StringUtil.PadR( StringUtil.RTrim( AV12cTipoInvTipo), 1, "%");
            /* Using cursor H00372 */
            pr_default.execute(0, new Object[] {lV6cTipoInv, lV7cTipoInvMov, lV8cTipoInvEst, lV9cTipoInvActivo, lV10cTipoInvUso, AV11cTipoInvSigno, lV12cTipoInvTipo, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A224TipoInvTipo = H00372_A224TipoInvTipo[0];
               n224TipoInvTipo = H00372_n224TipoInvTipo[0];
               A223TipoInvSigno = H00372_A223TipoInvSigno[0];
               n223TipoInvSigno = H00372_n223TipoInvSigno[0];
               A222TipoInvUso = H00372_A222TipoInvUso[0];
               n222TipoInvUso = H00372_n222TipoInvUso[0];
               A221TipoInvActivo = H00372_A221TipoInvActivo[0];
               n221TipoInvActivo = H00372_n221TipoInvActivo[0];
               A220TipoInvEst = H00372_A220TipoInvEst[0];
               n220TipoInvEst = H00372_n220TipoInvEst[0];
               A219TipoInvMov = H00372_A219TipoInvMov[0];
               n219TipoInvMov = H00372_n219TipoInvMov[0];
               A43TipoInv = H00372_A43TipoInv[0];
               /* Execute user event: Load */
               E20372 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB370( ) ;
         }
         bGXsfl_84_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes372( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_TIPOINV"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, StringUtil.RTrim( context.localUtil.Format( A43TipoInv, "")), context));
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
                                              AV7cTipoInvMov ,
                                              AV8cTipoInvEst ,
                                              AV9cTipoInvActivo ,
                                              AV10cTipoInvUso ,
                                              AV11cTipoInvSigno ,
                                              AV12cTipoInvTipo ,
                                              A219TipoInvMov ,
                                              A220TipoInvEst ,
                                              A221TipoInvActivo ,
                                              A222TipoInvUso ,
                                              A223TipoInvSigno ,
                                              A224TipoInvTipo ,
                                              A43TipoInv ,
                                              AV6cTipoInv } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV6cTipoInv = StringUtil.PadR( StringUtil.RTrim( AV6cTipoInv), 4, "%");
         lV7cTipoInvMov = StringUtil.Concat( StringUtil.RTrim( AV7cTipoInvMov), "%", "");
         lV8cTipoInvEst = StringUtil.PadR( StringUtil.RTrim( AV8cTipoInvEst), 1, "%");
         lV9cTipoInvActivo = StringUtil.PadR( StringUtil.RTrim( AV9cTipoInvActivo), 1, "%");
         lV10cTipoInvUso = StringUtil.PadR( StringUtil.RTrim( AV10cTipoInvUso), 1, "%");
         lV12cTipoInvTipo = StringUtil.PadR( StringUtil.RTrim( AV12cTipoInvTipo), 1, "%");
         /* Using cursor H00373 */
         pr_default.execute(1, new Object[] {lV6cTipoInv, lV7cTipoInvMov, lV8cTipoInvEst, lV9cTipoInvActivo, lV10cTipoInvUso, AV11cTipoInvSigno, lV12cTipoInvTipo});
         GRID1_nRecordCount = H00373_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cTipoInv, AV7cTipoInvMov, AV8cTipoInvEst, AV9cTipoInvActivo, AV10cTipoInvUso, AV11cTipoInvSigno, AV12cTipoInvTipo) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cTipoInv, AV7cTipoInvMov, AV8cTipoInvEst, AV9cTipoInvActivo, AV10cTipoInvUso, AV11cTipoInvSigno, AV12cTipoInvTipo) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cTipoInv, AV7cTipoInvMov, AV8cTipoInvEst, AV9cTipoInvActivo, AV10cTipoInvUso, AV11cTipoInvSigno, AV12cTipoInvTipo) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cTipoInv, AV7cTipoInvMov, AV8cTipoInvEst, AV9cTipoInvActivo, AV10cTipoInvUso, AV11cTipoInvSigno, AV12cTipoInvTipo) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cTipoInv, AV7cTipoInvMov, AV8cTipoInvEst, AV9cTipoInvActivo, AV10cTipoInvUso, AV11cTipoInvSigno, AV12cTipoInvTipo) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP370( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E19372 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cTipoInv = cgiGet( edtavCtipoinv_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTipoInv", AV6cTipoInv);
            AV7cTipoInvMov = cgiGet( edtavCtipoinvmov_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoInvMov", AV7cTipoInvMov);
            AV8cTipoInvEst = cgiGet( edtavCtipoinvest_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoInvEst", AV8cTipoInvEst);
            AV9cTipoInvActivo = cgiGet( edtavCtipoinvactivo_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoInvActivo", AV9cTipoInvActivo);
            AV10cTipoInvUso = cgiGet( edtavCtipoinvuso_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTipoInvUso", AV10cTipoInvUso);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtipoinvsigno_Internalname), ",", ".") < Convert.ToDecimal( -9 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtipoinvsigno_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTIPOINVSIGNO");
               GX_FocusControl = edtavCtipoinvsigno_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cTipoInvSigno = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTipoInvSigno), 2, 0)));
            }
            else
            {
               AV11cTipoInvSigno = (short)(context.localUtil.CToN( cgiGet( edtavCtipoinvsigno_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTipoInvSigno), 2, 0)));
            }
            AV12cTipoInvTipo = cgiGet( edtavCtipoinvtipo_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTipoInvTipo", AV12cTipoInvTipo);
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINV"), AV6cTipoInv) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINVMOV"), AV7cTipoInvMov) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINVEST"), AV8cTipoInvEst) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINVACTIVO"), AV9cTipoInvActivo) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINVUSO"), AV10cTipoInvUso) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOINVSIGNO"), ",", ".") != Convert.ToDecimal( AV11cTipoInvSigno )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOINVTIPO"), AV12cTipoInvTipo) != 0 )
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
         E19372 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19372( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Tipo Movimiento", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20372( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV17Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_842( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_84_Refreshing )
         {
            context.DoAjaxLoad(84, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E21372 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21372( )
      {
         /* Enter Routine */
         AV13pTipoInv = A43TipoInv;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTipoInv", AV13pTipoInv);
         context.setWebReturnParms(new Object[] {(String)AV13pTipoInv});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pTipoInv"});
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
         AV13pTipoInv = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTipoInv", AV13pTipoInv);
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
         PA372( ) ;
         WS372( ) ;
         WE372( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202210262017071", true);
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
         context.AddJavascriptSource("gx0100.js", "?202210262017071", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtTipoInv_Internalname = "TIPOINV_"+sGXsfl_84_idx;
         edtTipoInvMov_Internalname = "TIPOINVMOV_"+sGXsfl_84_idx;
         edtTipoInvEst_Internalname = "TIPOINVEST_"+sGXsfl_84_idx;
         edtTipoInvActivo_Internalname = "TIPOINVACTIVO_"+sGXsfl_84_idx;
         edtTipoInvUso_Internalname = "TIPOINVUSO_"+sGXsfl_84_idx;
         edtTipoInvSigno_Internalname = "TIPOINVSIGNO_"+sGXsfl_84_idx;
         edtTipoInvTipo_Internalname = "TIPOINVTIPO_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtTipoInv_Internalname = "TIPOINV_"+sGXsfl_84_fel_idx;
         edtTipoInvMov_Internalname = "TIPOINVMOV_"+sGXsfl_84_fel_idx;
         edtTipoInvEst_Internalname = "TIPOINVEST_"+sGXsfl_84_fel_idx;
         edtTipoInvActivo_Internalname = "TIPOINVACTIVO_"+sGXsfl_84_fel_idx;
         edtTipoInvUso_Internalname = "TIPOINVUSO_"+sGXsfl_84_fel_idx;
         edtTipoInvSigno_Internalname = "TIPOINVSIGNO_"+sGXsfl_84_fel_idx;
         edtTipoInvTipo_Internalname = "TIPOINVTIPO_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB370( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_84_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_84_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_84_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A43TipoInv))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_84_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV17Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInv_Internalname,StringUtil.RTrim( A43TipoInv),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInv_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtTipoInvMov_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A43TipoInv))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvMov_Internalname, "Link", edtTipoInvMov_Link, !bGXsfl_84_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInvMov_Internalname,(String)A219TipoInvMov,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtTipoInvMov_Link,(String)"",(String)"",(String)"",(String)edtTipoInvMov_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInvEst_Internalname,StringUtil.RTrim( A220TipoInvEst),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInvEst_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInvActivo_Internalname,StringUtil.RTrim( A221TipoInvActivo),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInvActivo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInvUso_Internalname,StringUtil.RTrim( A222TipoInvUso),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInvUso_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInvSigno_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ",", "")),context.localUtil.Format( (decimal)(A223TipoInvSigno), "Z9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInvSigno_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInvTipo_Internalname,StringUtil.RTrim( A224TipoInvTipo),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInvTipo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
            send_integrity_lvl_hashes372( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLbltipoinvfilter_Internalname = "LBLTIPOINVFILTER";
         edtavCtipoinv_Internalname = "vCTIPOINV";
         divTipoinvfiltercontainer_Internalname = "TIPOINVFILTERCONTAINER";
         lblLbltipoinvmovfilter_Internalname = "LBLTIPOINVMOVFILTER";
         edtavCtipoinvmov_Internalname = "vCTIPOINVMOV";
         divTipoinvmovfiltercontainer_Internalname = "TIPOINVMOVFILTERCONTAINER";
         lblLbltipoinvestfilter_Internalname = "LBLTIPOINVESTFILTER";
         edtavCtipoinvest_Internalname = "vCTIPOINVEST";
         divTipoinvestfiltercontainer_Internalname = "TIPOINVESTFILTERCONTAINER";
         lblLbltipoinvactivofilter_Internalname = "LBLTIPOINVACTIVOFILTER";
         edtavCtipoinvactivo_Internalname = "vCTIPOINVACTIVO";
         divTipoinvactivofiltercontainer_Internalname = "TIPOINVACTIVOFILTERCONTAINER";
         lblLbltipoinvusofilter_Internalname = "LBLTIPOINVUSOFILTER";
         edtavCtipoinvuso_Internalname = "vCTIPOINVUSO";
         divTipoinvusofiltercontainer_Internalname = "TIPOINVUSOFILTERCONTAINER";
         lblLbltipoinvsignofilter_Internalname = "LBLTIPOINVSIGNOFILTER";
         edtavCtipoinvsigno_Internalname = "vCTIPOINVSIGNO";
         divTipoinvsignofiltercontainer_Internalname = "TIPOINVSIGNOFILTERCONTAINER";
         lblLbltipoinvtipofilter_Internalname = "LBLTIPOINVTIPOFILTER";
         edtavCtipoinvtipo_Internalname = "vCTIPOINVTIPO";
         divTipoinvtipofiltercontainer_Internalname = "TIPOINVTIPOFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtTipoInv_Internalname = "TIPOINV";
         edtTipoInvMov_Internalname = "TIPOINVMOV";
         edtTipoInvEst_Internalname = "TIPOINVEST";
         edtTipoInvActivo_Internalname = "TIPOINVACTIVO";
         edtTipoInvUso_Internalname = "TIPOINVUSO";
         edtTipoInvSigno_Internalname = "TIPOINVSIGNO";
         edtTipoInvTipo_Internalname = "TIPOINVTIPO";
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
         edtTipoInvTipo_Jsonclick = "";
         edtTipoInvSigno_Jsonclick = "";
         edtTipoInvUso_Jsonclick = "";
         edtTipoInvActivo_Jsonclick = "";
         edtTipoInvEst_Jsonclick = "";
         edtTipoInvMov_Jsonclick = "";
         edtTipoInv_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtTipoInvMov_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCtipoinvtipo_Jsonclick = "";
         edtavCtipoinvtipo_Enabled = 1;
         edtavCtipoinvtipo_Visible = 1;
         edtavCtipoinvsigno_Jsonclick = "";
         edtavCtipoinvsigno_Enabled = 1;
         edtavCtipoinvsigno_Visible = 1;
         edtavCtipoinvuso_Jsonclick = "";
         edtavCtipoinvuso_Enabled = 1;
         edtavCtipoinvuso_Visible = 1;
         edtavCtipoinvactivo_Jsonclick = "";
         edtavCtipoinvactivo_Enabled = 1;
         edtavCtipoinvactivo_Visible = 1;
         edtavCtipoinvest_Jsonclick = "";
         edtavCtipoinvest_Enabled = 1;
         edtavCtipoinvest_Visible = 1;
         edtavCtipoinvmov_Jsonclick = "";
         edtavCtipoinvmov_Enabled = 1;
         edtavCtipoinvmov_Visible = 1;
         edtavCtipoinv_Jsonclick = "";
         edtavCtipoinv_Enabled = 1;
         edtavCtipoinv_Visible = 1;
         divTipoinvtipofiltercontainer_Class = "AdvancedContainerItem";
         divTipoinvsignofiltercontainer_Class = "AdvancedContainerItem";
         divTipoinvusofiltercontainer_Class = "AdvancedContainerItem";
         divTipoinvactivofiltercontainer_Class = "AdvancedContainerItem";
         divTipoinvestfiltercontainer_Class = "AdvancedContainerItem";
         divTipoinvmovfiltercontainer_Class = "AdvancedContainerItem";
         divTipoinvfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Tipo Movimiento";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cTipoInv',fld:'vCTIPOINV',pic:''},{av:'AV7cTipoInvMov',fld:'vCTIPOINVMOV',pic:''},{av:'AV8cTipoInvEst',fld:'vCTIPOINVEST',pic:''},{av:'AV9cTipoInvActivo',fld:'vCTIPOINVACTIVO',pic:''},{av:'AV10cTipoInvUso',fld:'vCTIPOINVUSO',pic:''},{av:'AV11cTipoInvSigno',fld:'vCTIPOINVSIGNO',pic:'Z9'},{av:'AV12cTipoInvTipo',fld:'vCTIPOINVTIPO',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18371',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLTIPOINVFILTER.CLICK","{handler:'E11371',iparms:[{av:'divTipoinvfiltercontainer_Class',ctrl:'TIPOINVFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLTIPOINVFILTER.CLICK",",oparms:[{av:'divTipoinvfiltercontainer_Class',ctrl:'TIPOINVFILTERCONTAINER',prop:'Class'},{av:'edtavCtipoinv_Visible',ctrl:'vCTIPOINV',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOINVMOVFILTER.CLICK","{handler:'E12371',iparms:[{av:'divTipoinvmovfiltercontainer_Class',ctrl:'TIPOINVMOVFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLTIPOINVMOVFILTER.CLICK",",oparms:[{av:'divTipoinvmovfiltercontainer_Class',ctrl:'TIPOINVMOVFILTERCONTAINER',prop:'Class'},{av:'edtavCtipoinvmov_Visible',ctrl:'vCTIPOINVMOV',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOINVESTFILTER.CLICK","{handler:'E13371',iparms:[{av:'divTipoinvestfiltercontainer_Class',ctrl:'TIPOINVESTFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLTIPOINVESTFILTER.CLICK",",oparms:[{av:'divTipoinvestfiltercontainer_Class',ctrl:'TIPOINVESTFILTERCONTAINER',prop:'Class'},{av:'edtavCtipoinvest_Visible',ctrl:'vCTIPOINVEST',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOINVACTIVOFILTER.CLICK","{handler:'E14371',iparms:[{av:'divTipoinvactivofiltercontainer_Class',ctrl:'TIPOINVACTIVOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLTIPOINVACTIVOFILTER.CLICK",",oparms:[{av:'divTipoinvactivofiltercontainer_Class',ctrl:'TIPOINVACTIVOFILTERCONTAINER',prop:'Class'},{av:'edtavCtipoinvactivo_Visible',ctrl:'vCTIPOINVACTIVO',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOINVUSOFILTER.CLICK","{handler:'E15371',iparms:[{av:'divTipoinvusofiltercontainer_Class',ctrl:'TIPOINVUSOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLTIPOINVUSOFILTER.CLICK",",oparms:[{av:'divTipoinvusofiltercontainer_Class',ctrl:'TIPOINVUSOFILTERCONTAINER',prop:'Class'},{av:'edtavCtipoinvuso_Visible',ctrl:'vCTIPOINVUSO',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOINVSIGNOFILTER.CLICK","{handler:'E16371',iparms:[{av:'divTipoinvsignofiltercontainer_Class',ctrl:'TIPOINVSIGNOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLTIPOINVSIGNOFILTER.CLICK",",oparms:[{av:'divTipoinvsignofiltercontainer_Class',ctrl:'TIPOINVSIGNOFILTERCONTAINER',prop:'Class'},{av:'edtavCtipoinvsigno_Visible',ctrl:'vCTIPOINVSIGNO',prop:'Visible'}]}");
         setEventMetadata("LBLTIPOINVTIPOFILTER.CLICK","{handler:'E17371',iparms:[{av:'divTipoinvtipofiltercontainer_Class',ctrl:'TIPOINVTIPOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLTIPOINVTIPOFILTER.CLICK",",oparms:[{av:'divTipoinvtipofiltercontainer_Class',ctrl:'TIPOINVTIPOFILTERCONTAINER',prop:'Class'},{av:'edtavCtipoinvtipo_Visible',ctrl:'vCTIPOINVTIPO',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E21372',iparms:[{av:'A43TipoInv',fld:'TIPOINV',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pTipoInv',fld:'vPTIPOINV',pic:''}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cTipoInv',fld:'vCTIPOINV',pic:''},{av:'AV7cTipoInvMov',fld:'vCTIPOINVMOV',pic:''},{av:'AV8cTipoInvEst',fld:'vCTIPOINVEST',pic:''},{av:'AV9cTipoInvActivo',fld:'vCTIPOINVACTIVO',pic:''},{av:'AV10cTipoInvUso',fld:'vCTIPOINVUSO',pic:''},{av:'AV11cTipoInvSigno',fld:'vCTIPOINVSIGNO',pic:'Z9'},{av:'AV12cTipoInvTipo',fld:'vCTIPOINVTIPO',pic:''}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cTipoInv',fld:'vCTIPOINV',pic:''},{av:'AV7cTipoInvMov',fld:'vCTIPOINVMOV',pic:''},{av:'AV8cTipoInvEst',fld:'vCTIPOINVEST',pic:''},{av:'AV9cTipoInvActivo',fld:'vCTIPOINVACTIVO',pic:''},{av:'AV10cTipoInvUso',fld:'vCTIPOINVUSO',pic:''},{av:'AV11cTipoInvSigno',fld:'vCTIPOINVSIGNO',pic:'Z9'},{av:'AV12cTipoInvTipo',fld:'vCTIPOINVTIPO',pic:''}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cTipoInv',fld:'vCTIPOINV',pic:''},{av:'AV7cTipoInvMov',fld:'vCTIPOINVMOV',pic:''},{av:'AV8cTipoInvEst',fld:'vCTIPOINVEST',pic:''},{av:'AV9cTipoInvActivo',fld:'vCTIPOINVACTIVO',pic:''},{av:'AV10cTipoInvUso',fld:'vCTIPOINVUSO',pic:''},{av:'AV11cTipoInvSigno',fld:'vCTIPOINVSIGNO',pic:'Z9'},{av:'AV12cTipoInvTipo',fld:'vCTIPOINVTIPO',pic:''}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cTipoInv',fld:'vCTIPOINV',pic:''},{av:'AV7cTipoInvMov',fld:'vCTIPOINVMOV',pic:''},{av:'AV8cTipoInvEst',fld:'vCTIPOINVEST',pic:''},{av:'AV9cTipoInvActivo',fld:'vCTIPOINVACTIVO',pic:''},{av:'AV10cTipoInvUso',fld:'vCTIPOINVUSO',pic:''},{av:'AV11cTipoInvSigno',fld:'vCTIPOINVSIGNO',pic:'Z9'},{av:'AV12cTipoInvTipo',fld:'vCTIPOINVTIPO',pic:''}]");
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
         AV6cTipoInv = "";
         AV7cTipoInvMov = "";
         AV8cTipoInvEst = "";
         AV9cTipoInvActivo = "";
         AV10cTipoInvUso = "";
         AV12cTipoInvTipo = "";
         GXKey = "";
         AV13pTipoInv = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLbltipoinvfilter_Jsonclick = "";
         TempTags = "";
         lblLbltipoinvmovfilter_Jsonclick = "";
         lblLbltipoinvestfilter_Jsonclick = "";
         lblLbltipoinvactivofilter_Jsonclick = "";
         lblLbltipoinvusofilter_Jsonclick = "";
         lblLbltipoinvsignofilter_Jsonclick = "";
         lblLbltipoinvtipofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A43TipoInv = "";
         A219TipoInvMov = "";
         A220TipoInvEst = "";
         A221TipoInvActivo = "";
         A222TipoInvUso = "";
         A224TipoInvTipo = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV6cTipoInv = "";
         lV7cTipoInvMov = "";
         lV8cTipoInvEst = "";
         lV9cTipoInvActivo = "";
         lV10cTipoInvUso = "";
         lV12cTipoInvTipo = "";
         H00372_A224TipoInvTipo = new String[] {""} ;
         H00372_n224TipoInvTipo = new bool[] {false} ;
         H00372_A223TipoInvSigno = new short[1] ;
         H00372_n223TipoInvSigno = new bool[] {false} ;
         H00372_A222TipoInvUso = new String[] {""} ;
         H00372_n222TipoInvUso = new bool[] {false} ;
         H00372_A221TipoInvActivo = new String[] {""} ;
         H00372_n221TipoInvActivo = new bool[] {false} ;
         H00372_A220TipoInvEst = new String[] {""} ;
         H00372_n220TipoInvEst = new bool[] {false} ;
         H00372_A219TipoInvMov = new String[] {""} ;
         H00372_n219TipoInvMov = new bool[] {false} ;
         H00372_A43TipoInv = new String[] {""} ;
         H00373_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0100__default(),
            new Object[][] {
                new Object[] {
               H00372_A224TipoInvTipo, H00372_n224TipoInvTipo, H00372_A223TipoInvSigno, H00372_n223TipoInvSigno, H00372_A222TipoInvUso, H00372_n222TipoInvUso, H00372_A221TipoInvActivo, H00372_n221TipoInvActivo, H00372_A220TipoInvEst, H00372_n220TipoInvEst,
               H00372_A219TipoInvMov, H00372_n219TipoInvMov, H00372_A43TipoInv
               }
               , new Object[] {
               H00373_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_84 ;
      private short nGXsfl_84_idx=1 ;
      private short GRID1_nEOF ;
      private short AV11cTipoInvSigno ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A223TipoInvSigno ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCtipoinv_Visible ;
      private int edtavCtipoinv_Enabled ;
      private int edtavCtipoinvmov_Visible ;
      private int edtavCtipoinvmov_Enabled ;
      private int edtavCtipoinvest_Visible ;
      private int edtavCtipoinvest_Enabled ;
      private int edtavCtipoinvactivo_Visible ;
      private int edtavCtipoinvactivo_Enabled ;
      private int edtavCtipoinvuso_Visible ;
      private int edtavCtipoinvuso_Enabled ;
      private int edtavCtipoinvsigno_Enabled ;
      private int edtavCtipoinvsigno_Visible ;
      private int edtavCtipoinvtipo_Visible ;
      private int edtavCtipoinvtipo_Enabled ;
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
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divTipoinvfiltercontainer_Class ;
      private String divTipoinvmovfiltercontainer_Class ;
      private String divTipoinvestfiltercontainer_Class ;
      private String divTipoinvactivofiltercontainer_Class ;
      private String divTipoinvusofiltercontainer_Class ;
      private String divTipoinvsignofiltercontainer_Class ;
      private String divTipoinvtipofiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_84_idx="0001" ;
      private String AV6cTipoInv ;
      private String AV8cTipoInvEst ;
      private String AV9cTipoInvActivo ;
      private String AV10cTipoInvUso ;
      private String AV12cTipoInvTipo ;
      private String GXKey ;
      private String AV13pTipoInv ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divTipoinvfiltercontainer_Internalname ;
      private String lblLbltipoinvfilter_Internalname ;
      private String lblLbltipoinvfilter_Jsonclick ;
      private String edtavCtipoinv_Internalname ;
      private String TempTags ;
      private String edtavCtipoinv_Jsonclick ;
      private String divTipoinvmovfiltercontainer_Internalname ;
      private String lblLbltipoinvmovfilter_Internalname ;
      private String lblLbltipoinvmovfilter_Jsonclick ;
      private String edtavCtipoinvmov_Internalname ;
      private String edtavCtipoinvmov_Jsonclick ;
      private String divTipoinvestfiltercontainer_Internalname ;
      private String lblLbltipoinvestfilter_Internalname ;
      private String lblLbltipoinvestfilter_Jsonclick ;
      private String edtavCtipoinvest_Internalname ;
      private String edtavCtipoinvest_Jsonclick ;
      private String divTipoinvactivofiltercontainer_Internalname ;
      private String lblLbltipoinvactivofilter_Internalname ;
      private String lblLbltipoinvactivofilter_Jsonclick ;
      private String edtavCtipoinvactivo_Internalname ;
      private String edtavCtipoinvactivo_Jsonclick ;
      private String divTipoinvusofiltercontainer_Internalname ;
      private String lblLbltipoinvusofilter_Internalname ;
      private String lblLbltipoinvusofilter_Jsonclick ;
      private String edtavCtipoinvuso_Internalname ;
      private String edtavCtipoinvuso_Jsonclick ;
      private String divTipoinvsignofiltercontainer_Internalname ;
      private String lblLbltipoinvsignofilter_Internalname ;
      private String lblLbltipoinvsignofilter_Jsonclick ;
      private String edtavCtipoinvsigno_Internalname ;
      private String edtavCtipoinvsigno_Jsonclick ;
      private String divTipoinvtipofiltercontainer_Internalname ;
      private String lblLbltipoinvtipofilter_Internalname ;
      private String lblLbltipoinvtipofilter_Jsonclick ;
      private String edtavCtipoinvtipo_Internalname ;
      private String edtavCtipoinvtipo_Jsonclick ;
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
      private String A43TipoInv ;
      private String edtTipoInvMov_Link ;
      private String A220TipoInvEst ;
      private String A221TipoInvActivo ;
      private String A222TipoInvUso ;
      private String A224TipoInvTipo ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtTipoInv_Internalname ;
      private String edtTipoInvMov_Internalname ;
      private String edtTipoInvEst_Internalname ;
      private String edtTipoInvActivo_Internalname ;
      private String edtTipoInvUso_Internalname ;
      private String edtTipoInvSigno_Internalname ;
      private String edtTipoInvTipo_Internalname ;
      private String scmdbuf ;
      private String lV6cTipoInv ;
      private String lV8cTipoInvEst ;
      private String lV9cTipoInvActivo ;
      private String lV10cTipoInvUso ;
      private String lV12cTipoInvTipo ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtTipoInv_Jsonclick ;
      private String edtTipoInvMov_Jsonclick ;
      private String edtTipoInvEst_Jsonclick ;
      private String edtTipoInvActivo_Jsonclick ;
      private String edtTipoInvUso_Jsonclick ;
      private String edtTipoInvSigno_Jsonclick ;
      private String edtTipoInvTipo_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_84_Refreshing=false ;
      private bool n219TipoInvMov ;
      private bool n220TipoInvEst ;
      private bool n221TipoInvActivo ;
      private bool n222TipoInvUso ;
      private bool n223TipoInvSigno ;
      private bool n224TipoInvTipo ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cTipoInvMov ;
      private String A219TipoInvMov ;
      private String AV17Linkselection_GXI ;
      private String lV7cTipoInvMov ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00372_A224TipoInvTipo ;
      private bool[] H00372_n224TipoInvTipo ;
      private short[] H00372_A223TipoInvSigno ;
      private bool[] H00372_n223TipoInvSigno ;
      private String[] H00372_A222TipoInvUso ;
      private bool[] H00372_n222TipoInvUso ;
      private String[] H00372_A221TipoInvActivo ;
      private bool[] H00372_n221TipoInvActivo ;
      private String[] H00372_A220TipoInvEst ;
      private bool[] H00372_n220TipoInvEst ;
      private String[] H00372_A219TipoInvMov ;
      private bool[] H00372_n219TipoInvMov ;
      private String[] H00372_A43TipoInv ;
      private long[] H00373_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pTipoInv ;
      private GXWebForm Form ;
   }

   public class gx0100__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00372( IGxContext context ,
                                             String AV7cTipoInvMov ,
                                             String AV8cTipoInvEst ,
                                             String AV9cTipoInvActivo ,
                                             String AV10cTipoInvUso ,
                                             short AV11cTipoInvSigno ,
                                             String AV12cTipoInvTipo ,
                                             String A219TipoInvMov ,
                                             String A220TipoInvEst ,
                                             String A221TipoInvActivo ,
                                             String A222TipoInvUso ,
                                             short A223TipoInvSigno ,
                                             String A224TipoInvTipo ,
                                             String A43TipoInv ,
                                             String AV6cTipoInv )
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
         sSelectString = " [TipoInvTipo], [TipoInvSigno], [TipoInvUso], [TipoInvActivo], [TipoInvEst], [TipoInvMov], [TipoInv]";
         sFromString = " FROM [TipoMovimiento] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([TipoInv] like @lV6cTipoInv)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cTipoInvMov)) )
         {
            sWhereString = sWhereString + " and ([TipoInvMov] like @lV7cTipoInvMov)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cTipoInvEst)) )
         {
            sWhereString = sWhereString + " and ([TipoInvEst] like @lV8cTipoInvEst)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cTipoInvActivo)) )
         {
            sWhereString = sWhereString + " and ([TipoInvActivo] like @lV9cTipoInvActivo)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cTipoInvUso)) )
         {
            sWhereString = sWhereString + " and ([TipoInvUso] like @lV10cTipoInvUso)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV11cTipoInvSigno) )
         {
            sWhereString = sWhereString + " and ([TipoInvSigno] >= @AV11cTipoInvSigno)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cTipoInvTipo)) )
         {
            sWhereString = sWhereString + " and ([TipoInvTipo] like @lV12cTipoInvTipo)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [TipoInv]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00373( IGxContext context ,
                                             String AV7cTipoInvMov ,
                                             String AV8cTipoInvEst ,
                                             String AV9cTipoInvActivo ,
                                             String AV10cTipoInvUso ,
                                             short AV11cTipoInvSigno ,
                                             String AV12cTipoInvTipo ,
                                             String A219TipoInvMov ,
                                             String A220TipoInvEst ,
                                             String A221TipoInvActivo ,
                                             String A222TipoInvUso ,
                                             short A223TipoInvSigno ,
                                             String A224TipoInvTipo ,
                                             String A43TipoInv ,
                                             String AV6cTipoInv )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [TipoMovimiento] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([TipoInv] like @lV6cTipoInv)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cTipoInvMov)) )
         {
            sWhereString = sWhereString + " and ([TipoInvMov] like @lV7cTipoInvMov)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cTipoInvEst)) )
         {
            sWhereString = sWhereString + " and ([TipoInvEst] like @lV8cTipoInvEst)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cTipoInvActivo)) )
         {
            sWhereString = sWhereString + " and ([TipoInvActivo] like @lV9cTipoInvActivo)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cTipoInvUso)) )
         {
            sWhereString = sWhereString + " and ([TipoInvUso] like @lV10cTipoInvUso)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV11cTipoInvSigno) )
         {
            sWhereString = sWhereString + " and ([TipoInvSigno] >= @AV11cTipoInvSigno)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cTipoInvTipo)) )
         {
            sWhereString = sWhereString + " and ([TipoInvTipo] like @lV12cTipoInvTipo)";
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
                     return conditional_H00372(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] );
               case 1 :
                     return conditional_H00373(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] );
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
          Object[] prmH00372 ;
          prmH00372 = new Object[] {
          new Object[] {"@lV6cTipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@lV7cTipoInvMov",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV8cTipoInvEst",SqlDbType.Char,1,0} ,
          new Object[] {"@lV9cTipoInvActivo",SqlDbType.Char,1,0} ,
          new Object[] {"@lV10cTipoInvUso",SqlDbType.Char,1,0} ,
          new Object[] {"@AV11cTipoInvSigno",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@lV12cTipoInvTipo",SqlDbType.Char,1,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00373 ;
          prmH00373 = new Object[] {
          new Object[] {"@lV6cTipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@lV7cTipoInvMov",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV8cTipoInvEst",SqlDbType.Char,1,0} ,
          new Object[] {"@lV9cTipoInvActivo",SqlDbType.Char,1,0} ,
          new Object[] {"@lV10cTipoInvUso",SqlDbType.Char,1,0} ,
          new Object[] {"@AV11cTipoInvSigno",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@lV12cTipoInvTipo",SqlDbType.Char,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00372", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00372,11,0,false,false )
             ,new CursorDef("H00373", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00373,1,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getString(7, 4) ;
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
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
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
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
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
