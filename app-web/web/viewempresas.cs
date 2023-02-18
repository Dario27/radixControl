/*
               File: ViewEmpresas
        Description: View Empresas
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:14:53.95
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
   public class viewempresas : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public viewempresas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public viewempresas( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           String aP1_TabCode )
      {
         this.AV12EmpID = aP0_EmpID;
         this.AV6TabCode = aP1_TabCode;
         executePrivate();
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
               AV12EmpID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12EmpID), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV6TabCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6TabCode", AV6TabCode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6TabCode, "")), context));
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
            ValidateSpaRequest();
            PA0R2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV15Pgmname = "ViewEmpresas";
               context.Gx_err = 0;
               WS0R2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE0R2( ) ;
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
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
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?202210262014540", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("viewempresas.aspx") + "?" + UrlEncode("" +AV12EmpID) + "," + UrlEncode(StringUtil.RTrim(AV6TabCode))+"\">") ;
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
         forbiddenHiddens = "hsh" + "ViewEmpresas";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("viewempresas:[SendSecurityCheck value for]"+"empdsc:"+StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_boolean_hidden_field( context, "vLOADALLTABS", AV11LoadAllTabs);
         GxWebStd.gx_hidden_field( context, "vSELECTEDTABCODE", StringUtil.RTrim( AV7SelectedTabCode));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vTABCODE", StringUtil.RTrim( AV6TabCode));
         GxWebStd.gx_hidden_field( context, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6TabCode, "")), context));
         GxWebStd.gx_hidden_field( context, "TAB_Class", StringUtil.RTrim( Tab_Class));
         GxWebStd.gx_hidden_field( context, "TAB_Activepagecontrolname", StringUtil.RTrim( Tab_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "TAB_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tab_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TAB_Historymanagement", StringUtil.BoolToStr( Tab_Historymanagement));
         GxWebStd.gx_hidden_field( context, "TAB_Activepagecontrolname", StringUtil.RTrim( Tab_Activepagecontrolname));
      }

      protected void RenderHtmlCloseForm0R2( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
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
         if ( ! ( WebComp_Generalwc == null ) )
         {
            WebComp_Generalwc.componentjscripts();
         }
         if ( ! ( WebComp_Agenciaswc == null ) )
         {
            WebComp_Agenciaswc.componentjscripts();
         }
         if ( ! ( WebComp_Clienteswc == null ) )
         {
            WebComp_Clienteswc.componentjscripts();
         }
         if ( ! ( WebComp_Marcawc == null ) )
         {
            WebComp_Marcawc.componentjscripts();
         }
         if ( ! ( WebComp_Vendedorwc == null ) )
         {
            WebComp_Vendedorwc.componentjscripts();
         }
         if ( ! ( WebComp_Prototipowc == null ) )
         {
            WebComp_Prototipowc.componentjscripts();
         }
         if ( ! ( WebComp_Tipoordenprowc == null ) )
         {
            WebComp_Tipoordenprowc.componentjscripts();
         }
         if ( ! ( WebComp_Detopfchswc == null ) )
         {
            WebComp_Detopfchswc.componentjscripts();
         }
         if ( ! ( WebComp_Ordenprocesoswc == null ) )
         {
            WebComp_Ordenprocesoswc.componentjscripts();
         }
         if ( ! ( WebComp_Archivosopwc == null ) )
         {
            WebComp_Archivosopwc.componentjscripts();
         }
         if ( ! ( WebComp_Tipoproductowc == null ) )
         {
            WebComp_Tipoproductowc.componentjscripts();
         }
         if ( ! ( WebComp_Subcatwc == null ) )
         {
            WebComp_Subcatwc.componentjscripts();
         }
         if ( ! ( WebComp_Ordenpedidowc == null ) )
         {
            WebComp_Ordenpedidowc.componentjscripts();
         }
         if ( ! ( WebComp_Obreroswc == null ) )
         {
            WebComp_Obreroswc.componentjscripts();
         }
         if ( ! ( WebComp_Bodegaswc == null ) )
         {
            WebComp_Bodegaswc.componentjscripts();
         }
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "ViewEmpresas" ;
      }

      public override String GetPgmdesc( )
      {
         return "View Empresas" ;
      }

      protected void WB0R0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletop_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-sm-offset-2", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblViewtitle_Internalname, "Empresas Information", "", "", lblViewtitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 ViewActionsBackCell", "Right", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblViewall_Internalname, "Empresas", lblViewall_Link, "", lblViewall_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "BtnTextBlockBack", 0, "", lblViewall_Visible, 1, 0, "HLP_ViewEmpresas.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabtable_1_Internalname, 1, 0, "px", 0, "px", "ViewTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtempdsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ViewEmpresas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"TABContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "General", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablegeneral_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0030"+"", StringUtil.RTrim( WebComp_Generalwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0030"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0030"+"");
                  }
                  WebComp_Generalwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblAgencias_title_Internalname, "Agencias", "", "", lblAgencias_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Agencias") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableagencias_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0038"+"", StringUtil.RTrim( WebComp_Agenciaswc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0038"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Agenciaswc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldAgenciaswc), StringUtil.Lower( WebComp_Agenciaswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0038"+"");
                  }
                  WebComp_Agenciaswc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldAgenciaswc), StringUtil.Lower( WebComp_Agenciaswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblClientes_title_Internalname, "Clientes", "", "", lblClientes_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Clientes") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableclientes_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0046"+"", StringUtil.RTrim( WebComp_Clienteswc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0046"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Clienteswc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldClienteswc), StringUtil.Lower( WebComp_Clienteswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0046"+"");
                  }
                  WebComp_Clienteswc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldClienteswc), StringUtil.Lower( WebComp_Clienteswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title4"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblMarca_title_Internalname, "Marca", "", "", lblMarca_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Marca") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel4"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemarca_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0054"+"", StringUtil.RTrim( WebComp_Marcawc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0054"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Marcawc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldMarcawc), StringUtil.Lower( WebComp_Marcawc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0054"+"");
                  }
                  WebComp_Marcawc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldMarcawc), StringUtil.Lower( WebComp_Marcawc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title5"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblVendedor_title_Internalname, "Vendedor", "", "", lblVendedor_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Vendedor") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel5"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablevendedor_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0062"+"", StringUtil.RTrim( WebComp_Vendedorwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0062"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Vendedorwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldVendedorwc), StringUtil.Lower( WebComp_Vendedorwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0062"+"");
                  }
                  WebComp_Vendedorwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldVendedorwc), StringUtil.Lower( WebComp_Vendedorwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title6"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPrototipo_title_Internalname, "Prototipo", "", "", lblPrototipo_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Prototipo") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel6"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableprototipo_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0070"+"", StringUtil.RTrim( WebComp_Prototipowc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0070"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Prototipowc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldPrototipowc), StringUtil.Lower( WebComp_Prototipowc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0070"+"");
                  }
                  WebComp_Prototipowc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldPrototipowc), StringUtil.Lower( WebComp_Prototipowc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title7"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTipoordenpro_title_Internalname, "Tipo Orden", "", "", lblTipoordenpro_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TipoOrdenPro") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel7"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletipoordenpro_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0078"+"", StringUtil.RTrim( WebComp_Tipoordenprowc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0078"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Tipoordenprowc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldTipoordenprowc), StringUtil.Lower( WebComp_Tipoordenprowc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0078"+"");
                  }
                  WebComp_Tipoordenprowc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldTipoordenprowc), StringUtil.Lower( WebComp_Tipoordenprowc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title8"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDetopfchs_title_Internalname, "control de fechas", "", "", lblDetopfchs_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "detOpFchs") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel8"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabledetopfchs_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0086"+"", StringUtil.RTrim( WebComp_Detopfchswc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0086"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Detopfchswc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldDetopfchswc), StringUtil.Lower( WebComp_Detopfchswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0086"+"");
                  }
                  WebComp_Detopfchswc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldDetopfchswc), StringUtil.Lower( WebComp_Detopfchswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title9"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblOrdenprocesos_title_Internalname, "Orden Procesos", "", "", lblOrdenprocesos_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "OrdenProcesos") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel9"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableordenprocesos_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0094"+"", StringUtil.RTrim( WebComp_Ordenprocesoswc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0094"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Ordenprocesoswc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldOrdenprocesoswc), StringUtil.Lower( WebComp_Ordenprocesoswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0094"+"");
                  }
                  WebComp_Ordenprocesoswc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldOrdenprocesoswc), StringUtil.Lower( WebComp_Ordenprocesoswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title10"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblArchivosop_title_Internalname, "Archivos OP", "", "", lblArchivosop_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "ArchivosOP") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel10"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablearchivosop_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0102"+"", StringUtil.RTrim( WebComp_Archivosopwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0102"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Archivosopwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldArchivosopwc), StringUtil.Lower( WebComp_Archivosopwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0102"+"");
                  }
                  WebComp_Archivosopwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldArchivosopwc), StringUtil.Lower( WebComp_Archivosopwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title11"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTipoproducto_title_Internalname, "Tipo Producto", "", "", lblTipoproducto_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TipoProducto") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel11"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletipoproducto_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0110"+"", StringUtil.RTrim( WebComp_Tipoproductowc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0110"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Tipoproductowc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldTipoproductowc), StringUtil.Lower( WebComp_Tipoproductowc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0110"+"");
                  }
                  WebComp_Tipoproductowc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldTipoproductowc), StringUtil.Lower( WebComp_Tipoproductowc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title12"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblSubcat_title_Internalname, "Categorias", "", "", lblSubcat_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "subCat") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel12"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesubcat_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0118"+"", StringUtil.RTrim( WebComp_Subcatwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0118"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Subcatwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldSubcatwc), StringUtil.Lower( WebComp_Subcatwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0118"+"");
                  }
                  WebComp_Subcatwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldSubcatwc), StringUtil.Lower( WebComp_Subcatwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title13"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblOrdenpedido_title_Internalname, "Orden Pedido", "", "", lblOrdenpedido_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "OrdenPedido") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel13"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableordenpedido_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0126"+"", StringUtil.RTrim( WebComp_Ordenpedidowc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0126"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Ordenpedidowc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldOrdenpedidowc), StringUtil.Lower( WebComp_Ordenpedidowc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0126"+"");
                  }
                  WebComp_Ordenpedidowc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldOrdenpedidowc), StringUtil.Lower( WebComp_Ordenpedidowc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title14"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblObreros_title_Internalname, "Cotizador", "", "", lblObreros_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Obreros") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel14"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableobreros_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0134"+"", StringUtil.RTrim( WebComp_Obreroswc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0134"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Obreroswc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldObreroswc), StringUtil.Lower( WebComp_Obreroswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0134"+"");
                  }
                  WebComp_Obreroswc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldObreroswc), StringUtil.Lower( WebComp_Obreroswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title15"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBodegas_title_Internalname, "Bodegas", "", "", lblBodegas_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEmpresas.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Bodegas") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel15"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablebodegas_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0142"+"", StringUtil.RTrim( WebComp_Bodegaswc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0142"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Bodegaswc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBodegaswc), StringUtil.Lower( WebComp_Bodegaswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0142"+"");
                  }
                  WebComp_Bodegaswc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBodegaswc), StringUtil.Lower( WebComp_Bodegaswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0R2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "View Empresas", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0R0( ) ;
      }

      protected void WS0R2( )
      {
         START0R2( ) ;
         EVT0R2( ) ;
      }

      protected void EVT0R2( )
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
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E110R2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E120R2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( ! wbErr )
                           {
                              Rfr0gs = false;
                              if ( ! Rfr0gs )
                              {
                              }
                              dynload_actions( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 4);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                     nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                     if ( nCmpId == 30 )
                     {
                        OldGeneralwc = cgiGet( "W0030");
                        if ( ( StringUtil.Len( OldGeneralwc) == 0 ) || ( StringUtil.StrCmp(OldGeneralwc, WebComp_Generalwc_Component) != 0 ) )
                        {
                           WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", OldGeneralwc, new Object[] {context} );
                           WebComp_Generalwc.ComponentInit();
                           WebComp_Generalwc.Name = "OldGeneralwc";
                           WebComp_Generalwc_Component = OldGeneralwc;
                        }
                        if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
                        {
                           WebComp_Generalwc.componentprocess("W0030", "", sEvt);
                        }
                        WebComp_Generalwc_Component = OldGeneralwc;
                     }
                     else if ( nCmpId == 38 )
                     {
                        OldAgenciaswc = cgiGet( "W0038");
                        if ( ( StringUtil.Len( OldAgenciaswc) == 0 ) || ( StringUtil.StrCmp(OldAgenciaswc, WebComp_Agenciaswc_Component) != 0 ) )
                        {
                           WebComp_Agenciaswc = getWebComponent(GetType(), "GeneXus.Programs", OldAgenciaswc, new Object[] {context} );
                           WebComp_Agenciaswc.ComponentInit();
                           WebComp_Agenciaswc.Name = "OldAgenciaswc";
                           WebComp_Agenciaswc_Component = OldAgenciaswc;
                        }
                        if ( StringUtil.Len( WebComp_Agenciaswc_Component) != 0 )
                        {
                           WebComp_Agenciaswc.componentprocess("W0038", "", sEvt);
                        }
                        WebComp_Agenciaswc_Component = OldAgenciaswc;
                     }
                     else if ( nCmpId == 46 )
                     {
                        OldClienteswc = cgiGet( "W0046");
                        if ( ( StringUtil.Len( OldClienteswc) == 0 ) || ( StringUtil.StrCmp(OldClienteswc, WebComp_Clienteswc_Component) != 0 ) )
                        {
                           WebComp_Clienteswc = getWebComponent(GetType(), "GeneXus.Programs", OldClienteswc, new Object[] {context} );
                           WebComp_Clienteswc.ComponentInit();
                           WebComp_Clienteswc.Name = "OldClienteswc";
                           WebComp_Clienteswc_Component = OldClienteswc;
                        }
                        if ( StringUtil.Len( WebComp_Clienteswc_Component) != 0 )
                        {
                           WebComp_Clienteswc.componentprocess("W0046", "", sEvt);
                        }
                        WebComp_Clienteswc_Component = OldClienteswc;
                     }
                     else if ( nCmpId == 54 )
                     {
                        OldMarcawc = cgiGet( "W0054");
                        if ( ( StringUtil.Len( OldMarcawc) == 0 ) || ( StringUtil.StrCmp(OldMarcawc, WebComp_Marcawc_Component) != 0 ) )
                        {
                           WebComp_Marcawc = getWebComponent(GetType(), "GeneXus.Programs", OldMarcawc, new Object[] {context} );
                           WebComp_Marcawc.ComponentInit();
                           WebComp_Marcawc.Name = "OldMarcawc";
                           WebComp_Marcawc_Component = OldMarcawc;
                        }
                        if ( StringUtil.Len( WebComp_Marcawc_Component) != 0 )
                        {
                           WebComp_Marcawc.componentprocess("W0054", "", sEvt);
                        }
                        WebComp_Marcawc_Component = OldMarcawc;
                     }
                     else if ( nCmpId == 62 )
                     {
                        OldVendedorwc = cgiGet( "W0062");
                        if ( ( StringUtil.Len( OldVendedorwc) == 0 ) || ( StringUtil.StrCmp(OldVendedorwc, WebComp_Vendedorwc_Component) != 0 ) )
                        {
                           WebComp_Vendedorwc = getWebComponent(GetType(), "GeneXus.Programs", OldVendedorwc, new Object[] {context} );
                           WebComp_Vendedorwc.ComponentInit();
                           WebComp_Vendedorwc.Name = "OldVendedorwc";
                           WebComp_Vendedorwc_Component = OldVendedorwc;
                        }
                        if ( StringUtil.Len( WebComp_Vendedorwc_Component) != 0 )
                        {
                           WebComp_Vendedorwc.componentprocess("W0062", "", sEvt);
                        }
                        WebComp_Vendedorwc_Component = OldVendedorwc;
                     }
                     else if ( nCmpId == 70 )
                     {
                        OldPrototipowc = cgiGet( "W0070");
                        if ( ( StringUtil.Len( OldPrototipowc) == 0 ) || ( StringUtil.StrCmp(OldPrototipowc, WebComp_Prototipowc_Component) != 0 ) )
                        {
                           WebComp_Prototipowc = getWebComponent(GetType(), "GeneXus.Programs", OldPrototipowc, new Object[] {context} );
                           WebComp_Prototipowc.ComponentInit();
                           WebComp_Prototipowc.Name = "OldPrototipowc";
                           WebComp_Prototipowc_Component = OldPrototipowc;
                        }
                        if ( StringUtil.Len( WebComp_Prototipowc_Component) != 0 )
                        {
                           WebComp_Prototipowc.componentprocess("W0070", "", sEvt);
                        }
                        WebComp_Prototipowc_Component = OldPrototipowc;
                     }
                     else if ( nCmpId == 78 )
                     {
                        OldTipoordenprowc = cgiGet( "W0078");
                        if ( ( StringUtil.Len( OldTipoordenprowc) == 0 ) || ( StringUtil.StrCmp(OldTipoordenprowc, WebComp_Tipoordenprowc_Component) != 0 ) )
                        {
                           WebComp_Tipoordenprowc = getWebComponent(GetType(), "GeneXus.Programs", OldTipoordenprowc, new Object[] {context} );
                           WebComp_Tipoordenprowc.ComponentInit();
                           WebComp_Tipoordenprowc.Name = "OldTipoordenprowc";
                           WebComp_Tipoordenprowc_Component = OldTipoordenprowc;
                        }
                        if ( StringUtil.Len( WebComp_Tipoordenprowc_Component) != 0 )
                        {
                           WebComp_Tipoordenprowc.componentprocess("W0078", "", sEvt);
                        }
                        WebComp_Tipoordenprowc_Component = OldTipoordenprowc;
                     }
                     else if ( nCmpId == 86 )
                     {
                        OldDetopfchswc = cgiGet( "W0086");
                        if ( ( StringUtil.Len( OldDetopfchswc) == 0 ) || ( StringUtil.StrCmp(OldDetopfchswc, WebComp_Detopfchswc_Component) != 0 ) )
                        {
                           WebComp_Detopfchswc = getWebComponent(GetType(), "GeneXus.Programs", OldDetopfchswc, new Object[] {context} );
                           WebComp_Detopfchswc.ComponentInit();
                           WebComp_Detopfchswc.Name = "OldDetopfchswc";
                           WebComp_Detopfchswc_Component = OldDetopfchswc;
                        }
                        if ( StringUtil.Len( WebComp_Detopfchswc_Component) != 0 )
                        {
                           WebComp_Detopfchswc.componentprocess("W0086", "", sEvt);
                        }
                        WebComp_Detopfchswc_Component = OldDetopfchswc;
                     }
                     else if ( nCmpId == 94 )
                     {
                        OldOrdenprocesoswc = cgiGet( "W0094");
                        if ( ( StringUtil.Len( OldOrdenprocesoswc) == 0 ) || ( StringUtil.StrCmp(OldOrdenprocesoswc, WebComp_Ordenprocesoswc_Component) != 0 ) )
                        {
                           WebComp_Ordenprocesoswc = getWebComponent(GetType(), "GeneXus.Programs", OldOrdenprocesoswc, new Object[] {context} );
                           WebComp_Ordenprocesoswc.ComponentInit();
                           WebComp_Ordenprocesoswc.Name = "OldOrdenprocesoswc";
                           WebComp_Ordenprocesoswc_Component = OldOrdenprocesoswc;
                        }
                        if ( StringUtil.Len( WebComp_Ordenprocesoswc_Component) != 0 )
                        {
                           WebComp_Ordenprocesoswc.componentprocess("W0094", "", sEvt);
                        }
                        WebComp_Ordenprocesoswc_Component = OldOrdenprocesoswc;
                     }
                     else if ( nCmpId == 102 )
                     {
                        OldArchivosopwc = cgiGet( "W0102");
                        if ( ( StringUtil.Len( OldArchivosopwc) == 0 ) || ( StringUtil.StrCmp(OldArchivosopwc, WebComp_Archivosopwc_Component) != 0 ) )
                        {
                           WebComp_Archivosopwc = getWebComponent(GetType(), "GeneXus.Programs", OldArchivosopwc, new Object[] {context} );
                           WebComp_Archivosopwc.ComponentInit();
                           WebComp_Archivosopwc.Name = "OldArchivosopwc";
                           WebComp_Archivosopwc_Component = OldArchivosopwc;
                        }
                        if ( StringUtil.Len( WebComp_Archivosopwc_Component) != 0 )
                        {
                           WebComp_Archivosopwc.componentprocess("W0102", "", sEvt);
                        }
                        WebComp_Archivosopwc_Component = OldArchivosopwc;
                     }
                     else if ( nCmpId == 110 )
                     {
                        OldTipoproductowc = cgiGet( "W0110");
                        if ( ( StringUtil.Len( OldTipoproductowc) == 0 ) || ( StringUtil.StrCmp(OldTipoproductowc, WebComp_Tipoproductowc_Component) != 0 ) )
                        {
                           WebComp_Tipoproductowc = getWebComponent(GetType(), "GeneXus.Programs", OldTipoproductowc, new Object[] {context} );
                           WebComp_Tipoproductowc.ComponentInit();
                           WebComp_Tipoproductowc.Name = "OldTipoproductowc";
                           WebComp_Tipoproductowc_Component = OldTipoproductowc;
                        }
                        if ( StringUtil.Len( WebComp_Tipoproductowc_Component) != 0 )
                        {
                           WebComp_Tipoproductowc.componentprocess("W0110", "", sEvt);
                        }
                        WebComp_Tipoproductowc_Component = OldTipoproductowc;
                     }
                     else if ( nCmpId == 118 )
                     {
                        OldSubcatwc = cgiGet( "W0118");
                        if ( ( StringUtil.Len( OldSubcatwc) == 0 ) || ( StringUtil.StrCmp(OldSubcatwc, WebComp_Subcatwc_Component) != 0 ) )
                        {
                           WebComp_Subcatwc = getWebComponent(GetType(), "GeneXus.Programs", OldSubcatwc, new Object[] {context} );
                           WebComp_Subcatwc.ComponentInit();
                           WebComp_Subcatwc.Name = "OldSubcatwc";
                           WebComp_Subcatwc_Component = OldSubcatwc;
                        }
                        if ( StringUtil.Len( WebComp_Subcatwc_Component) != 0 )
                        {
                           WebComp_Subcatwc.componentprocess("W0118", "", sEvt);
                        }
                        WebComp_Subcatwc_Component = OldSubcatwc;
                     }
                     else if ( nCmpId == 126 )
                     {
                        OldOrdenpedidowc = cgiGet( "W0126");
                        if ( ( StringUtil.Len( OldOrdenpedidowc) == 0 ) || ( StringUtil.StrCmp(OldOrdenpedidowc, WebComp_Ordenpedidowc_Component) != 0 ) )
                        {
                           WebComp_Ordenpedidowc = getWebComponent(GetType(), "GeneXus.Programs", OldOrdenpedidowc, new Object[] {context} );
                           WebComp_Ordenpedidowc.ComponentInit();
                           WebComp_Ordenpedidowc.Name = "OldOrdenpedidowc";
                           WebComp_Ordenpedidowc_Component = OldOrdenpedidowc;
                        }
                        if ( StringUtil.Len( WebComp_Ordenpedidowc_Component) != 0 )
                        {
                           WebComp_Ordenpedidowc.componentprocess("W0126", "", sEvt);
                        }
                        WebComp_Ordenpedidowc_Component = OldOrdenpedidowc;
                     }
                     else if ( nCmpId == 134 )
                     {
                        OldObreroswc = cgiGet( "W0134");
                        if ( ( StringUtil.Len( OldObreroswc) == 0 ) || ( StringUtil.StrCmp(OldObreroswc, WebComp_Obreroswc_Component) != 0 ) )
                        {
                           WebComp_Obreroswc = getWebComponent(GetType(), "GeneXus.Programs", OldObreroswc, new Object[] {context} );
                           WebComp_Obreroswc.ComponentInit();
                           WebComp_Obreroswc.Name = "OldObreroswc";
                           WebComp_Obreroswc_Component = OldObreroswc;
                        }
                        if ( StringUtil.Len( WebComp_Obreroswc_Component) != 0 )
                        {
                           WebComp_Obreroswc.componentprocess("W0134", "", sEvt);
                        }
                        WebComp_Obreroswc_Component = OldObreroswc;
                     }
                     else if ( nCmpId == 142 )
                     {
                        OldBodegaswc = cgiGet( "W0142");
                        if ( ( StringUtil.Len( OldBodegaswc) == 0 ) || ( StringUtil.StrCmp(OldBodegaswc, WebComp_Bodegaswc_Component) != 0 ) )
                        {
                           WebComp_Bodegaswc = getWebComponent(GetType(), "GeneXus.Programs", OldBodegaswc, new Object[] {context} );
                           WebComp_Bodegaswc.ComponentInit();
                           WebComp_Bodegaswc.Name = "OldBodegaswc";
                           WebComp_Bodegaswc_Component = OldBodegaswc;
                        }
                        if ( StringUtil.Len( WebComp_Bodegaswc_Component) != 0 )
                        {
                           WebComp_Bodegaswc.componentprocess("W0142", "", sEvt);
                        }
                        WebComp_Bodegaswc_Component = OldBodegaswc;
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE0R2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0R2( ) ;
            }
         }
      }

      protected void PA0R2( )
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
            if ( ! context.isAjaxRequest( ) )
            {
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
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
         RF0R2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV15Pgmname = "ViewEmpresas";
         context.Gx_err = 0;
      }

      protected void RF0R2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  WebComp_Generalwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Agenciaswc_Component) != 0 )
               {
                  WebComp_Agenciaswc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Clienteswc_Component) != 0 )
               {
                  WebComp_Clienteswc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Marcawc_Component) != 0 )
               {
                  WebComp_Marcawc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Vendedorwc_Component) != 0 )
               {
                  WebComp_Vendedorwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Prototipowc_Component) != 0 )
               {
                  WebComp_Prototipowc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Tipoordenprowc_Component) != 0 )
               {
                  WebComp_Tipoordenprowc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Detopfchswc_Component) != 0 )
               {
                  WebComp_Detopfchswc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Ordenprocesoswc_Component) != 0 )
               {
                  WebComp_Ordenprocesoswc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Archivosopwc_Component) != 0 )
               {
                  WebComp_Archivosopwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Tipoproductowc_Component) != 0 )
               {
                  WebComp_Tipoproductowc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Subcatwc_Component) != 0 )
               {
                  WebComp_Subcatwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Ordenpedidowc_Component) != 0 )
               {
                  WebComp_Ordenpedidowc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Obreroswc_Component) != 0 )
               {
                  WebComp_Obreroswc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Bodegaswc_Component) != 0 )
               {
                  WebComp_Bodegaswc.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000R2 */
            pr_default.execute(0, new Object[] {AV12EmpID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A1EmpID = H000R2_A1EmpID[0];
               A44empdsc = H000R2_A44empdsc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
               n44empdsc = H000R2_n44empdsc[0];
               /* Execute user event: Load */
               E120R2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB0R0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0R2( )
      {
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12EmpID), "ZZZ9"), context));
      }

      protected void STRUP0R0( )
      {
         /* Before Start, stand alone formulas. */
         AV15Pgmname = "ViewEmpresas";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110R2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
            n44empdsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            /* Read saved values. */
            AV12EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
            AV11LoadAllTabs = StringUtil.StrToBool( cgiGet( "vLOADALLTABS"));
            AV7SelectedTabCode = cgiGet( "vSELECTEDTABCODE");
            Tab_Class = cgiGet( "TAB_Class");
            Tab_Activepagecontrolname = cgiGet( "TAB_Activepagecontrolname");
            Tab_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TAB_Pagecount"), ",", "."));
            Tab_Historymanagement = StringUtil.StrToBool( cgiGet( "TAB_Historymanagement"));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = "hsh" + "ViewEmpresas";
            A44empdsc = cgiGet( edtempdsc_Internalname);
            n44empdsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!"));
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("viewempresas:[SecurityCheckFailed value for]"+"empdsc:"+StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
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
         E110R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110R2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV15Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV16GXLvl6 = 0;
         /* Using cursor H000R3 */
         pr_default.execute(1, new Object[] {AV12EmpID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A1EmpID = H000R3_A1EmpID[0];
            A44empdsc = H000R3_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = H000R3_n44empdsc[0];
            AV16GXLvl6 = 1;
            Form.Caption = A44empdsc;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            lblViewall_Link = formatLink("wwempresas.aspx") ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblViewall_Internalname, "Link", lblViewall_Link, true);
            AV10Exists = true;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         if ( AV16GXLvl6 == 0 )
         {
            Form.Caption = "Record not found";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            lblViewall_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblViewall_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblViewall_Visible), 5, 0)), true);
            AV10Exists = false;
         }
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         if ( AV10Exists )
         {
            AV7SelectedTabCode = AV6TabCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SelectedTabCode", AV7SelectedTabCode);
            Tab_Activepagecontrolname = AV7SelectedTabCode;
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Tab_Internalname, "ActivePageControlName", Tab_Activepagecontrolname);
            /* Execute user subroutine: 'LOAD TAB' */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void S112( )
      {
         /* 'LOAD TAB' Routine */
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV7SelectedTabCode, "General") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Generalwc_Component), StringUtil.Lower( "EmpresasGeneral")) != 0 )
            {
               WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", "empresasgeneral", new Object[] {context} );
               WebComp_Generalwc.ComponentInit();
               WebComp_Generalwc.Name = "EmpresasGeneral";
               WebComp_Generalwc_Component = "EmpresasGeneral";
            }
            if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
            {
               WebComp_Generalwc.setjustcreated();
               WebComp_Generalwc.componentprepare(new Object[] {(String)"W0030",(String)"",(short)AV12EmpID});
               WebComp_Generalwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0030"+"");
               WebComp_Generalwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "Agencias") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Agenciaswc_Component), StringUtil.Lower( "EmpresasAgenciasWC")) != 0 )
            {
               WebComp_Agenciaswc = getWebComponent(GetType(), "GeneXus.Programs", "empresasagenciaswc", new Object[] {context} );
               WebComp_Agenciaswc.ComponentInit();
               WebComp_Agenciaswc.Name = "EmpresasAgenciasWC";
               WebComp_Agenciaswc_Component = "EmpresasAgenciasWC";
            }
            if ( StringUtil.Len( WebComp_Agenciaswc_Component) != 0 )
            {
               WebComp_Agenciaswc.setjustcreated();
               WebComp_Agenciaswc.componentprepare(new Object[] {(String)"W0038",(String)"",(short)AV12EmpID});
               WebComp_Agenciaswc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0038"+"");
               WebComp_Agenciaswc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "Clientes") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Clienteswc_Component), StringUtil.Lower( "EmpresasClientesWC")) != 0 )
            {
               WebComp_Clienteswc = getWebComponent(GetType(), "GeneXus.Programs", "empresasclienteswc", new Object[] {context} );
               WebComp_Clienteswc.ComponentInit();
               WebComp_Clienteswc.Name = "EmpresasClientesWC";
               WebComp_Clienteswc_Component = "EmpresasClientesWC";
            }
            if ( StringUtil.Len( WebComp_Clienteswc_Component) != 0 )
            {
               WebComp_Clienteswc.setjustcreated();
               WebComp_Clienteswc.componentprepare(new Object[] {(String)"W0046",(String)"",(short)AV12EmpID});
               WebComp_Clienteswc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0046"+"");
               WebComp_Clienteswc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "Marca") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Marcawc_Component), StringUtil.Lower( "EmpresasMarcaWC")) != 0 )
            {
               WebComp_Marcawc = getWebComponent(GetType(), "GeneXus.Programs", "empresasmarcawc", new Object[] {context} );
               WebComp_Marcawc.ComponentInit();
               WebComp_Marcawc.Name = "EmpresasMarcaWC";
               WebComp_Marcawc_Component = "EmpresasMarcaWC";
            }
            if ( StringUtil.Len( WebComp_Marcawc_Component) != 0 )
            {
               WebComp_Marcawc.setjustcreated();
               WebComp_Marcawc.componentprepare(new Object[] {(String)"W0054",(String)"",(short)AV12EmpID});
               WebComp_Marcawc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0054"+"");
               WebComp_Marcawc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "Vendedor") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Vendedorwc_Component), StringUtil.Lower( "EmpresasVendedorWC")) != 0 )
            {
               WebComp_Vendedorwc = getWebComponent(GetType(), "GeneXus.Programs", "empresasvendedorwc", new Object[] {context} );
               WebComp_Vendedorwc.ComponentInit();
               WebComp_Vendedorwc.Name = "EmpresasVendedorWC";
               WebComp_Vendedorwc_Component = "EmpresasVendedorWC";
            }
            if ( StringUtil.Len( WebComp_Vendedorwc_Component) != 0 )
            {
               WebComp_Vendedorwc.setjustcreated();
               WebComp_Vendedorwc.componentprepare(new Object[] {(String)"W0062",(String)"",(short)AV12EmpID});
               WebComp_Vendedorwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0062"+"");
               WebComp_Vendedorwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "Prototipo") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Prototipowc_Component), StringUtil.Lower( "EmpresasPrototipoWC")) != 0 )
            {
               WebComp_Prototipowc = getWebComponent(GetType(), "GeneXus.Programs", "empresasprototipowc", new Object[] {context} );
               WebComp_Prototipowc.ComponentInit();
               WebComp_Prototipowc.Name = "EmpresasPrototipoWC";
               WebComp_Prototipowc_Component = "EmpresasPrototipoWC";
            }
            if ( StringUtil.Len( WebComp_Prototipowc_Component) != 0 )
            {
               WebComp_Prototipowc.setjustcreated();
               WebComp_Prototipowc.componentprepare(new Object[] {(String)"W0070",(String)"",(short)AV12EmpID});
               WebComp_Prototipowc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0070"+"");
               WebComp_Prototipowc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "TipoOrdenPro") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Tipoordenprowc_Component), StringUtil.Lower( "EmpresasTipoOrdenProWC")) != 0 )
            {
               WebComp_Tipoordenprowc = getWebComponent(GetType(), "GeneXus.Programs", "empresastipoordenprowc", new Object[] {context} );
               WebComp_Tipoordenprowc.ComponentInit();
               WebComp_Tipoordenprowc.Name = "EmpresasTipoOrdenProWC";
               WebComp_Tipoordenprowc_Component = "EmpresasTipoOrdenProWC";
            }
            if ( StringUtil.Len( WebComp_Tipoordenprowc_Component) != 0 )
            {
               WebComp_Tipoordenprowc.setjustcreated();
               WebComp_Tipoordenprowc.componentprepare(new Object[] {(String)"W0078",(String)"",(short)AV12EmpID});
               WebComp_Tipoordenprowc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0078"+"");
               WebComp_Tipoordenprowc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "detOpFchs") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Detopfchswc_Component), StringUtil.Lower( "EmpresasdetOpFchsWC")) != 0 )
            {
               WebComp_Detopfchswc = getWebComponent(GetType(), "GeneXus.Programs", "empresasdetopfchswc", new Object[] {context} );
               WebComp_Detopfchswc.ComponentInit();
               WebComp_Detopfchswc.Name = "EmpresasdetOpFchsWC";
               WebComp_Detopfchswc_Component = "EmpresasdetOpFchsWC";
            }
            if ( StringUtil.Len( WebComp_Detopfchswc_Component) != 0 )
            {
               WebComp_Detopfchswc.setjustcreated();
               WebComp_Detopfchswc.componentprepare(new Object[] {(String)"W0086",(String)"",(short)AV12EmpID});
               WebComp_Detopfchswc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0086"+"");
               WebComp_Detopfchswc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "OrdenProcesos") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Ordenprocesoswc_Component), StringUtil.Lower( "EmpresasOrdenProcesosWC")) != 0 )
            {
               WebComp_Ordenprocesoswc = getWebComponent(GetType(), "GeneXus.Programs", "empresasordenprocesoswc", new Object[] {context} );
               WebComp_Ordenprocesoswc.ComponentInit();
               WebComp_Ordenprocesoswc.Name = "EmpresasOrdenProcesosWC";
               WebComp_Ordenprocesoswc_Component = "EmpresasOrdenProcesosWC";
            }
            if ( StringUtil.Len( WebComp_Ordenprocesoswc_Component) != 0 )
            {
               WebComp_Ordenprocesoswc.setjustcreated();
               WebComp_Ordenprocesoswc.componentprepare(new Object[] {(String)"W0094",(String)"",(short)AV12EmpID});
               WebComp_Ordenprocesoswc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0094"+"");
               WebComp_Ordenprocesoswc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "ArchivosOP") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Archivosopwc_Component), StringUtil.Lower( "EmpresasArchivosOPWC")) != 0 )
            {
               WebComp_Archivosopwc = getWebComponent(GetType(), "GeneXus.Programs", "empresasarchivosopwc", new Object[] {context} );
               WebComp_Archivosopwc.ComponentInit();
               WebComp_Archivosopwc.Name = "EmpresasArchivosOPWC";
               WebComp_Archivosopwc_Component = "EmpresasArchivosOPWC";
            }
            if ( StringUtil.Len( WebComp_Archivosopwc_Component) != 0 )
            {
               WebComp_Archivosopwc.setjustcreated();
               WebComp_Archivosopwc.componentprepare(new Object[] {(String)"W0102",(String)"",(short)AV12EmpID});
               WebComp_Archivosopwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0102"+"");
               WebComp_Archivosopwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "TipoProducto") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Tipoproductowc_Component), StringUtil.Lower( "EmpresasTipoProductoWC")) != 0 )
            {
               WebComp_Tipoproductowc = getWebComponent(GetType(), "GeneXus.Programs", "empresastipoproductowc", new Object[] {context} );
               WebComp_Tipoproductowc.ComponentInit();
               WebComp_Tipoproductowc.Name = "EmpresasTipoProductoWC";
               WebComp_Tipoproductowc_Component = "EmpresasTipoProductoWC";
            }
            if ( StringUtil.Len( WebComp_Tipoproductowc_Component) != 0 )
            {
               WebComp_Tipoproductowc.setjustcreated();
               WebComp_Tipoproductowc.componentprepare(new Object[] {(String)"W0110",(String)"",(short)AV12EmpID});
               WebComp_Tipoproductowc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0110"+"");
               WebComp_Tipoproductowc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "subCat") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Subcatwc_Component), StringUtil.Lower( "EmpresassubCatWC")) != 0 )
            {
               WebComp_Subcatwc = getWebComponent(GetType(), "GeneXus.Programs", "empresassubcatwc", new Object[] {context} );
               WebComp_Subcatwc.ComponentInit();
               WebComp_Subcatwc.Name = "EmpresassubCatWC";
               WebComp_Subcatwc_Component = "EmpresassubCatWC";
            }
            if ( StringUtil.Len( WebComp_Subcatwc_Component) != 0 )
            {
               WebComp_Subcatwc.setjustcreated();
               WebComp_Subcatwc.componentprepare(new Object[] {(String)"W0118",(String)"",(short)AV12EmpID});
               WebComp_Subcatwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0118"+"");
               WebComp_Subcatwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "OrdenPedido") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Ordenpedidowc_Component), StringUtil.Lower( "EmpresasOrdenPedidoWC")) != 0 )
            {
               WebComp_Ordenpedidowc = getWebComponent(GetType(), "GeneXus.Programs", "empresasordenpedidowc", new Object[] {context} );
               WebComp_Ordenpedidowc.ComponentInit();
               WebComp_Ordenpedidowc.Name = "EmpresasOrdenPedidoWC";
               WebComp_Ordenpedidowc_Component = "EmpresasOrdenPedidoWC";
            }
            if ( StringUtil.Len( WebComp_Ordenpedidowc_Component) != 0 )
            {
               WebComp_Ordenpedidowc.setjustcreated();
               WebComp_Ordenpedidowc.componentprepare(new Object[] {(String)"W0126",(String)"",(short)AV12EmpID});
               WebComp_Ordenpedidowc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0126"+"");
               WebComp_Ordenpedidowc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "Obreros") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Obreroswc_Component), StringUtil.Lower( "EmpresasObrerosWC")) != 0 )
            {
               WebComp_Obreroswc = getWebComponent(GetType(), "GeneXus.Programs", "empresasobreroswc", new Object[] {context} );
               WebComp_Obreroswc.ComponentInit();
               WebComp_Obreroswc.Name = "EmpresasObrerosWC";
               WebComp_Obreroswc_Component = "EmpresasObrerosWC";
            }
            if ( StringUtil.Len( WebComp_Obreroswc_Component) != 0 )
            {
               WebComp_Obreroswc.setjustcreated();
               WebComp_Obreroswc.componentprepare(new Object[] {(String)"W0134",(String)"",(short)AV12EmpID});
               WebComp_Obreroswc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0134"+"");
               WebComp_Obreroswc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "Bodegas") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Bodegaswc_Component), StringUtil.Lower( "EmpresasBodegasWC")) != 0 )
            {
               WebComp_Bodegaswc = getWebComponent(GetType(), "GeneXus.Programs", "empresasbodegaswc", new Object[] {context} );
               WebComp_Bodegaswc.ComponentInit();
               WebComp_Bodegaswc.Name = "EmpresasBodegasWC";
               WebComp_Bodegaswc_Component = "EmpresasBodegasWC";
            }
            if ( StringUtil.Len( WebComp_Bodegaswc_Component) != 0 )
            {
               WebComp_Bodegaswc.setjustcreated();
               WebComp_Bodegaswc.componentprepare(new Object[] {(String)"W0142",(String)"",(short)AV12EmpID});
               WebComp_Bodegaswc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0142"+"");
               WebComp_Bodegaswc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E120R2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12EmpID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12EmpID), "ZZZ9"), context));
         AV6TabCode = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6TabCode", AV6TabCode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6TabCode, "")), context));
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
         PA0R2( ) ;
         WS0R2( ) ;
         WE0R2( ) ;
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
         if ( ! ( WebComp_Generalwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
            {
               WebComp_Generalwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Agenciaswc == null ) )
         {
            if ( StringUtil.Len( WebComp_Agenciaswc_Component) != 0 )
            {
               WebComp_Agenciaswc.componentthemes();
            }
         }
         if ( ! ( WebComp_Clienteswc == null ) )
         {
            if ( StringUtil.Len( WebComp_Clienteswc_Component) != 0 )
            {
               WebComp_Clienteswc.componentthemes();
            }
         }
         if ( ! ( WebComp_Marcawc == null ) )
         {
            if ( StringUtil.Len( WebComp_Marcawc_Component) != 0 )
            {
               WebComp_Marcawc.componentthemes();
            }
         }
         if ( ! ( WebComp_Vendedorwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Vendedorwc_Component) != 0 )
            {
               WebComp_Vendedorwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Prototipowc == null ) )
         {
            if ( StringUtil.Len( WebComp_Prototipowc_Component) != 0 )
            {
               WebComp_Prototipowc.componentthemes();
            }
         }
         if ( ! ( WebComp_Tipoordenprowc == null ) )
         {
            if ( StringUtil.Len( WebComp_Tipoordenprowc_Component) != 0 )
            {
               WebComp_Tipoordenprowc.componentthemes();
            }
         }
         if ( ! ( WebComp_Detopfchswc == null ) )
         {
            if ( StringUtil.Len( WebComp_Detopfchswc_Component) != 0 )
            {
               WebComp_Detopfchswc.componentthemes();
            }
         }
         if ( ! ( WebComp_Ordenprocesoswc == null ) )
         {
            if ( StringUtil.Len( WebComp_Ordenprocesoswc_Component) != 0 )
            {
               WebComp_Ordenprocesoswc.componentthemes();
            }
         }
         if ( ! ( WebComp_Archivosopwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Archivosopwc_Component) != 0 )
            {
               WebComp_Archivosopwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Tipoproductowc == null ) )
         {
            if ( StringUtil.Len( WebComp_Tipoproductowc_Component) != 0 )
            {
               WebComp_Tipoproductowc.componentthemes();
            }
         }
         if ( ! ( WebComp_Subcatwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Subcatwc_Component) != 0 )
            {
               WebComp_Subcatwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Ordenpedidowc == null ) )
         {
            if ( StringUtil.Len( WebComp_Ordenpedidowc_Component) != 0 )
            {
               WebComp_Ordenpedidowc.componentthemes();
            }
         }
         if ( ! ( WebComp_Obreroswc == null ) )
         {
            if ( StringUtil.Len( WebComp_Obreroswc_Component) != 0 )
            {
               WebComp_Obreroswc.componentthemes();
            }
         }
         if ( ! ( WebComp_Bodegaswc == null ) )
         {
            if ( StringUtil.Len( WebComp_Bodegaswc_Component) != 0 )
            {
               WebComp_Bodegaswc.componentthemes();
            }
         }
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022102620145593", true);
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
         context.AddJavascriptSource("viewempresas.js", "?2022102620145593", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblViewtitle_Internalname = "VIEWTITLE";
         lblViewall_Internalname = "VIEWALL";
         divTabletop_Internalname = "TABLETOP";
         edtempdsc_Internalname = "EMPDSC";
         divTabtable_1_Internalname = "TABTABLE_1";
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         divTablegeneral_Internalname = "TABLEGENERAL";
         lblAgencias_title_Internalname = "AGENCIAS_TITLE";
         divTableagencias_Internalname = "TABLEAGENCIAS";
         lblClientes_title_Internalname = "CLIENTES_TITLE";
         divTableclientes_Internalname = "TABLECLIENTES";
         lblMarca_title_Internalname = "MARCA_TITLE";
         divTablemarca_Internalname = "TABLEMARCA";
         lblVendedor_title_Internalname = "VENDEDOR_TITLE";
         divTablevendedor_Internalname = "TABLEVENDEDOR";
         lblPrototipo_title_Internalname = "PROTOTIPO_TITLE";
         divTableprototipo_Internalname = "TABLEPROTOTIPO";
         lblTipoordenpro_title_Internalname = "TIPOORDENPRO_TITLE";
         divTabletipoordenpro_Internalname = "TABLETIPOORDENPRO";
         lblDetopfchs_title_Internalname = "DETOPFCHS_TITLE";
         divTabledetopfchs_Internalname = "TABLEDETOPFCHS";
         lblOrdenprocesos_title_Internalname = "ORDENPROCESOS_TITLE";
         divTableordenprocesos_Internalname = "TABLEORDENPROCESOS";
         lblArchivosop_title_Internalname = "ARCHIVOSOP_TITLE";
         divTablearchivosop_Internalname = "TABLEARCHIVOSOP";
         lblTipoproducto_title_Internalname = "TIPOPRODUCTO_TITLE";
         divTabletipoproducto_Internalname = "TABLETIPOPRODUCTO";
         lblSubcat_title_Internalname = "SUBCAT_TITLE";
         divTablesubcat_Internalname = "TABLESUBCAT";
         lblOrdenpedido_title_Internalname = "ORDENPEDIDO_TITLE";
         divTableordenpedido_Internalname = "TABLEORDENPEDIDO";
         lblObreros_title_Internalname = "OBREROS_TITLE";
         divTableobreros_Internalname = "TABLEOBREROS";
         lblBodegas_title_Internalname = "BODEGAS_TITLE";
         divTablebodegas_Internalname = "TABLEBODEGAS";
         Tab_Internalname = "TAB";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtempdsc_Jsonclick = "";
         edtempdsc_Enabled = 0;
         lblViewall_Link = "";
         lblViewall_Visible = 1;
         Tab_Historymanagement = Convert.ToBoolean( -1);
         Tab_Pagecount = 15;
         Tab_Class = "WWTab";
         Form.Caption = "View Empresas";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV12EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV6TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'A44empdsc',fld:'EMPDSC',pic:'@!'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
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
         wcpOAV6TabCode = "";
         Tab_Activepagecontrolname = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV15Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         forbiddenHiddens = "";
         A44empdsc = "";
         AV7SelectedTabCode = "";
         GX_FocusControl = "";
         sPrefix = "";
         lblViewtitle_Jsonclick = "";
         lblViewall_Jsonclick = "";
         lblGeneral_title_Jsonclick = "";
         WebComp_Generalwc_Component = "";
         OldGeneralwc = "";
         lblAgencias_title_Jsonclick = "";
         WebComp_Agenciaswc_Component = "";
         OldAgenciaswc = "";
         lblClientes_title_Jsonclick = "";
         WebComp_Clienteswc_Component = "";
         OldClienteswc = "";
         lblMarca_title_Jsonclick = "";
         WebComp_Marcawc_Component = "";
         OldMarcawc = "";
         lblVendedor_title_Jsonclick = "";
         WebComp_Vendedorwc_Component = "";
         OldVendedorwc = "";
         lblPrototipo_title_Jsonclick = "";
         WebComp_Prototipowc_Component = "";
         OldPrototipowc = "";
         lblTipoordenpro_title_Jsonclick = "";
         WebComp_Tipoordenprowc_Component = "";
         OldTipoordenprowc = "";
         lblDetopfchs_title_Jsonclick = "";
         WebComp_Detopfchswc_Component = "";
         OldDetopfchswc = "";
         lblOrdenprocesos_title_Jsonclick = "";
         WebComp_Ordenprocesoswc_Component = "";
         OldOrdenprocesoswc = "";
         lblArchivosop_title_Jsonclick = "";
         WebComp_Archivosopwc_Component = "";
         OldArchivosopwc = "";
         lblTipoproducto_title_Jsonclick = "";
         WebComp_Tipoproductowc_Component = "";
         OldTipoproductowc = "";
         lblSubcat_title_Jsonclick = "";
         WebComp_Subcatwc_Component = "";
         OldSubcatwc = "";
         lblOrdenpedido_title_Jsonclick = "";
         WebComp_Ordenpedidowc_Component = "";
         OldOrdenpedidowc = "";
         lblObreros_title_Jsonclick = "";
         WebComp_Obreroswc_Component = "";
         OldObreroswc = "";
         lblBodegas_title_Jsonclick = "";
         WebComp_Bodegaswc_Component = "";
         OldBodegaswc = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H000R2_A1EmpID = new short[1] ;
         H000R2_A44empdsc = new String[] {""} ;
         H000R2_n44empdsc = new bool[] {false} ;
         hsh = "";
         H000R3_A1EmpID = new short[1] ;
         H000R3_A44empdsc = new String[] {""} ;
         H000R3_n44empdsc = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.viewempresas__default(),
            new Object[][] {
                new Object[] {
               H000R2_A1EmpID, H000R2_A44empdsc, H000R2_n44empdsc
               }
               , new Object[] {
               H000R3_A1EmpID, H000R3_A44empdsc, H000R3_n44empdsc
               }
            }
         );
         WebComp_Generalwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Agenciaswc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Clienteswc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Marcawc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Vendedorwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Prototipowc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Tipoordenprowc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Detopfchswc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Ordenprocesoswc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Archivosopwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Tipoproductowc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Subcatwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Ordenpedidowc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Obreroswc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Bodegaswc = new GeneXus.Http.GXNullWebComponent();
         AV15Pgmname = "ViewEmpresas";
         /* GeneXus formulas. */
         AV15Pgmname = "ViewEmpresas";
         context.Gx_err = 0;
      }

      private short AV12EmpID ;
      private short wcpOAV12EmpID ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A1EmpID ;
      private short AV16GXLvl6 ;
      private short nGXWrapped ;
      private int Tab_Pagecount ;
      private int lblViewall_Visible ;
      private int edtempdsc_Enabled ;
      private int idxLst ;
      private String AV6TabCode ;
      private String wcpOAV6TabCode ;
      private String Tab_Activepagecontrolname ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String AV15Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String AV7SelectedTabCode ;
      private String Tab_Class ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTabletop_Internalname ;
      private String lblViewtitle_Internalname ;
      private String lblViewtitle_Jsonclick ;
      private String lblViewall_Internalname ;
      private String lblViewall_Link ;
      private String lblViewall_Jsonclick ;
      private String divTabtable_1_Internalname ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divTablegeneral_Internalname ;
      private String WebComp_Generalwc_Component ;
      private String OldGeneralwc ;
      private String lblAgencias_title_Internalname ;
      private String lblAgencias_title_Jsonclick ;
      private String divTableagencias_Internalname ;
      private String WebComp_Agenciaswc_Component ;
      private String OldAgenciaswc ;
      private String lblClientes_title_Internalname ;
      private String lblClientes_title_Jsonclick ;
      private String divTableclientes_Internalname ;
      private String WebComp_Clienteswc_Component ;
      private String OldClienteswc ;
      private String lblMarca_title_Internalname ;
      private String lblMarca_title_Jsonclick ;
      private String divTablemarca_Internalname ;
      private String WebComp_Marcawc_Component ;
      private String OldMarcawc ;
      private String lblVendedor_title_Internalname ;
      private String lblVendedor_title_Jsonclick ;
      private String divTablevendedor_Internalname ;
      private String WebComp_Vendedorwc_Component ;
      private String OldVendedorwc ;
      private String lblPrototipo_title_Internalname ;
      private String lblPrototipo_title_Jsonclick ;
      private String divTableprototipo_Internalname ;
      private String WebComp_Prototipowc_Component ;
      private String OldPrototipowc ;
      private String lblTipoordenpro_title_Internalname ;
      private String lblTipoordenpro_title_Jsonclick ;
      private String divTabletipoordenpro_Internalname ;
      private String WebComp_Tipoordenprowc_Component ;
      private String OldTipoordenprowc ;
      private String lblDetopfchs_title_Internalname ;
      private String lblDetopfchs_title_Jsonclick ;
      private String divTabledetopfchs_Internalname ;
      private String WebComp_Detopfchswc_Component ;
      private String OldDetopfchswc ;
      private String lblOrdenprocesos_title_Internalname ;
      private String lblOrdenprocesos_title_Jsonclick ;
      private String divTableordenprocesos_Internalname ;
      private String WebComp_Ordenprocesoswc_Component ;
      private String OldOrdenprocesoswc ;
      private String lblArchivosop_title_Internalname ;
      private String lblArchivosop_title_Jsonclick ;
      private String divTablearchivosop_Internalname ;
      private String WebComp_Archivosopwc_Component ;
      private String OldArchivosopwc ;
      private String lblTipoproducto_title_Internalname ;
      private String lblTipoproducto_title_Jsonclick ;
      private String divTabletipoproducto_Internalname ;
      private String WebComp_Tipoproductowc_Component ;
      private String OldTipoproductowc ;
      private String lblSubcat_title_Internalname ;
      private String lblSubcat_title_Jsonclick ;
      private String divTablesubcat_Internalname ;
      private String WebComp_Subcatwc_Component ;
      private String OldSubcatwc ;
      private String lblOrdenpedido_title_Internalname ;
      private String lblOrdenpedido_title_Jsonclick ;
      private String divTableordenpedido_Internalname ;
      private String WebComp_Ordenpedidowc_Component ;
      private String OldOrdenpedidowc ;
      private String lblObreros_title_Internalname ;
      private String lblObreros_title_Jsonclick ;
      private String divTableobreros_Internalname ;
      private String WebComp_Obreroswc_Component ;
      private String OldObreroswc ;
      private String lblBodegas_title_Internalname ;
      private String lblBodegas_title_Jsonclick ;
      private String divTablebodegas_Internalname ;
      private String WebComp_Bodegaswc_Component ;
      private String OldBodegaswc ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String hsh ;
      private String Tab_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV11LoadAllTabs ;
      private bool Tab_Historymanagement ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n44empdsc ;
      private bool returnInSub ;
      private bool AV10Exists ;
      private String A44empdsc ;
      private GXWebComponent WebComp_Generalwc ;
      private GXWebComponent WebComp_Agenciaswc ;
      private GXWebComponent WebComp_Clienteswc ;
      private GXWebComponent WebComp_Marcawc ;
      private GXWebComponent WebComp_Vendedorwc ;
      private GXWebComponent WebComp_Prototipowc ;
      private GXWebComponent WebComp_Tipoordenprowc ;
      private GXWebComponent WebComp_Detopfchswc ;
      private GXWebComponent WebComp_Ordenprocesoswc ;
      private GXWebComponent WebComp_Archivosopwc ;
      private GXWebComponent WebComp_Tipoproductowc ;
      private GXWebComponent WebComp_Subcatwc ;
      private GXWebComponent WebComp_Ordenpedidowc ;
      private GXWebComponent WebComp_Obreroswc ;
      private GXWebComponent WebComp_Bodegaswc ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H000R2_A1EmpID ;
      private String[] H000R2_A44empdsc ;
      private bool[] H000R2_n44empdsc ;
      private short[] H000R3_A1EmpID ;
      private String[] H000R3_A44empdsc ;
      private bool[] H000R3_n44empdsc ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class viewempresas__default : DataStoreHelperBase, IDataStoreHelper
   {
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
          Object[] prmH000R2 ;
          prmH000R2 = new Object[] {
          new Object[] {"@AV12EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000R3 ;
          prmH000R3 = new Object[] {
          new Object[] {"@AV12EmpID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000R2", "SELECT [EmpID], [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @AV12EmpID ORDER BY [EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R2,1,0,true,true )
             ,new CursorDef("H000R3", "SELECT [EmpID], [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @AV12EmpID ORDER BY [EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R3,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
