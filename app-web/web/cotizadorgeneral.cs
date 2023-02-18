/*
               File: CotizadorGeneral
        Description: Cotizador General
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:53:25.6
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class cotizadorgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public cotizadorgeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
      }

      public cotizadorgeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_CotiID )
      {
         this.A1EmpID = aP0_EmpID;
         this.A34CotiID = aP1_CotiID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A34CotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A1EmpID,(short)A34CotiID});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA1S2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV14Pgmname = "CotizadorGeneral";
               context.Gx_err = 0;
               /* Using cursor H001S2 */
               pr_default.execute(0, new Object[] {A1EmpID});
               A44empdsc = H001S2_A44empdsc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A44empdsc", A44empdsc);
               n44empdsc = H001S2_n44empdsc[0];
               pr_default.close(0);
               /* Using cursor H001S6 */
               pr_default.execute(1, new Object[] {A1EmpID, A34CotiID});
               if ( (pr_default.getStatus(1) != 101) )
               {
                  A176sumTotNeto1 = H001S6_A176sumTotNeto1[0];
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
               }
               else
               {
                  A176sumTotNeto1 = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
               }
               pr_default.close(1);
               /* Using cursor H001S8 */
               pr_default.execute(2, new Object[] {A1EmpID, A34CotiID});
               if ( (pr_default.getStatus(2) != 101) )
               {
                  A177ObrSubtotal = H001S8_A177ObrSubtotal[0];
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               }
               else
               {
                  A177ObrSubtotal = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               }
               pr_default.close(2);
               A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
               /* Using cursor H001S11 */
               pr_default.execute(3, new Object[] {A1EmpID, A34CotiID});
               if ( (pr_default.getStatus(3) != 101) )
               {
                  A180sumTotValorIVA = H001S11_A180sumTotValorIVA[0];
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                  n180sumTotValorIVA = H001S11_n180sumTotValorIVA[0];
               }
               else
               {
                  A180sumTotValorIVA = 0;
                  n180sumTotValorIVA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
               }
               pr_default.close(3);
               /* Using cursor H001S13 */
               pr_default.execute(4, new Object[] {A1EmpID, A34CotiID});
               if ( (pr_default.getStatus(4) != 101) )
               {
                  A179sumTotValor = H001S13_A179sumTotValor[0];
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                  n179sumTotValor = H001S13_n179sumTotValor[0];
               }
               else
               {
                  A179sumTotValor = 0;
                  n179sumTotValor = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
               }
               pr_default.close(4);
               /* Using cursor H001S15 */
               pr_default.execute(5, new Object[] {A1EmpID, A34CotiID});
               if ( (pr_default.getStatus(5) != 101) )
               {
                  A174sumTotCant = H001S15_A174sumTotCant[0];
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                  n174sumTotCant = H001S15_n174sumTotCant[0];
               }
               else
               {
                  A174sumTotCant = 0;
                  n174sumTotCant = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
               }
               pr_default.close(5);
               WS1S2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Cotizador General") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?2022111922532530", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("cotizadorgeneral.aspx") + "?" + UrlEncode("" +A1EmpID) + "," + UrlEncode("" +A34CotiID)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA34CotiID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA34CotiID), 4, 0, ",", "")));
      }

      protected void RenderHtmlCloseForm1S2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("cotizadorgeneral.js", "?2022111922532531", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "CotizadorGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cotizador General" ;
      }

      protected void WB1S0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "cotizadorgeneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewActionsCell", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group WWViewActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ActionButtons";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Modificar", bttBtnupdate_Jsonclick, 7, "Modificar", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e111s1_client"+"'", TempTags, "", 2, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ActionButtons";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Eliminar", bttBtndelete_Jsonclick, 7, "Eliminar", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e121s1_client"+"'", TempTags, "", 2, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAttributestable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Emp ID", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), ((edtEmpID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")) : context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEmpID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtempdsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiID_Internalname, "Nro", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCotiID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34CotiID), 4, 0, ",", "")), ((edtCotiID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A34CotiID), "ZZZ9")) : context.localUtil.Format( (decimal)(A34CotiID), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCotiID_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtCotiID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiDsc_Internalname, "Descripcion", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCotiDsc_Internalname, A154CotiDsc, StringUtil.RTrim( context.localUtil.Format( A154CotiDsc, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCotiDsc_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtCotiDsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtprotID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtprotID_Internalname, "prot ID", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtprotID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ",", "")), ((edtprotID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A10protID), "ZZZ9")) : context.localUtil.Format( (decimal)(A10protID), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprotID_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtprotID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtprotDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtprotDsc_Internalname, "Prototipo", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtprotDsc_Internalname, StringUtil.RTrim( A74protDsc), StringUtil.RTrim( context.localUtil.Format( A74protDsc, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprotDsc_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtprotDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiIVA_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiIVA_Internalname, "IVA", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCotiIVA_Internalname, StringUtil.LTrim( StringUtil.NToC( A155CotiIVA, 8, 3, ",", "")), ((edtCotiIVA_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A155CotiIVA, "ZZZ9.999")) : context.localUtil.Format( A155CotiIVA, "ZZZ9.999")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCotiIVA_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtCotiIVA_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiUltNro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiUltNro_Internalname, "Nro", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCotiUltNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A156CotiUltNro), 8, 0, ",", "")), ((edtCotiUltNro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A156CotiUltNro), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A156CotiUltNro), "ZZZZZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCotiUltNro_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtCotiUltNro_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtsumTotCant_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtsumTotCant_Internalname, "Cant", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtsumTotCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A174sumTotCant, 10, 2, ",", "")), ((edtsumTotCant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A174sumTotCant, "ZZZZZZ9.99")) : context.localUtil.Format( A174sumTotCant, "ZZZZZZ9.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtsumTotCant_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtsumTotCant_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtsumTotNeto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtsumTotNeto_Internalname, "Neto", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtsumTotNeto_Internalname, StringUtil.LTrim( StringUtil.NToC( A175sumTotNeto, 10, 2, ",", "")), ((edtsumTotNeto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A175sumTotNeto, "ZZZZZZ9.99")) : context.localUtil.Format( A175sumTotNeto, "ZZZZZZ9.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtsumTotNeto_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtsumTotNeto_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtsumTotValor_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtsumTotValor_Internalname, "Valor", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtsumTotValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A179sumTotValor, 10, 2, ",", "")), ((edtsumTotValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A179sumTotValor, "ZZZZZZ9.99")) : context.localUtil.Format( A179sumTotValor, "ZZZZZZ9.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtsumTotValor_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtsumTotValor_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtsumTotValorIVA_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtsumTotValorIVA_Internalname, "Valor IVA", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtsumTotValorIVA_Internalname, StringUtil.LTrim( StringUtil.NToC( A180sumTotValorIVA, 10, 2, ",", "")), ((edtsumTotValorIVA_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A180sumTotValorIVA, "ZZZZZZ9.99")) : context.localUtil.Format( A180sumTotValorIVA, "ZZZZZZ9.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtsumTotValorIVA_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtsumTotValorIVA_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTotNeto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtTotNeto_Internalname, "Neto", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtTotNeto_Internalname, StringUtil.LTrim( StringUtil.NToC( A181TotNeto, 10, 2, ",", "")), ((edtTotNeto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A181TotNeto, "ZZZZZZ9.99")) : context.localUtil.Format( A181TotNeto, "ZZZZZZ9.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTotNeto_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtTotNeto_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiObs_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiObs_Internalname, "Observaciones", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCotiObs_Internalname, A182CotiObs, StringUtil.RTrim( context.localUtil.Format( A182CotiObs, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "Observaciones", edtCotiObs_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtCotiObs_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiUltNroObr_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiUltNroObr_Internalname, "Nro Obr", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCotiUltNroObr_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A201CotiUltNroObr), 8, 0, ",", "")), ((edtCotiUltNroObr_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A201CotiUltNroObr), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A201CotiUltNroObr), "ZZZZZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCotiUltNroObr_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtCotiUltNroObr_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtObrSubtotal_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObrSubtotal_Internalname, "Subtotal", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtObrSubtotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A177ObrSubtotal, 10, 2, ",", "")), ((edtObrSubtotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A177ObrSubtotal, "ZZZZZZ9.99")) : context.localUtil.Format( A177ObrSubtotal, "ZZZZZZ9.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObrSubtotal_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtObrSubtotal_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtsumTotNeto1_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtsumTotNeto1_Internalname, "Tot Neto1", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtsumTotNeto1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A176sumTotNeto1), 4, 0, ",", "")), ((edtsumTotNeto1_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A176sumTotNeto1), "ZZZ9")) : context.localUtil.Format( (decimal)(A176sumTotNeto1), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtsumTotNeto1_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtsumTotNeto1_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_CotizadorGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1S2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
               Form.Meta.addItem("description", "Cotizador General", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP1S0( ) ;
            }
         }
      }

      protected void WS1S2( )
      {
         START1S2( ) ;
         EVT1S2( ) ;
      }

      protected void EVT1S2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
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
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1S0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1S0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E131S2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1S0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E141S2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1S0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1S0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1S2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1S2( ) ;
            }
         }
      }

      protected void PA1S2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
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
         RF1S2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV14Pgmname = "CotizadorGeneral";
         context.Gx_err = 0;
      }

      protected void RF1S2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H001S24 */
            pr_default.execute(6, new Object[] {A1EmpID, A34CotiID});
            while ( (pr_default.getStatus(6) != 101) )
            {
               A201CotiUltNroObr = H001S24_A201CotiUltNroObr[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A201CotiUltNroObr", StringUtil.LTrim( StringUtil.Str( (decimal)(A201CotiUltNroObr), 8, 0)));
               n201CotiUltNroObr = H001S24_n201CotiUltNroObr[0];
               A182CotiObs = H001S24_A182CotiObs[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A182CotiObs", A182CotiObs);
               n182CotiObs = H001S24_n182CotiObs[0];
               A181TotNeto = H001S24_A181TotNeto[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
               n181TotNeto = H001S24_n181TotNeto[0];
               A156CotiUltNro = H001S24_A156CotiUltNro[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
               n156CotiUltNro = H001S24_n156CotiUltNro[0];
               A155CotiIVA = H001S24_A155CotiIVA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155CotiIVA", StringUtil.LTrim( StringUtil.Str( A155CotiIVA, 8, 3)));
               n155CotiIVA = H001S24_n155CotiIVA[0];
               A74protDsc = H001S24_A74protDsc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A74protDsc", A74protDsc);
               n74protDsc = H001S24_n74protDsc[0];
               A10protID = H001S24_A10protID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
               A154CotiDsc = H001S24_A154CotiDsc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A154CotiDsc", A154CotiDsc);
               n154CotiDsc = H001S24_n154CotiDsc[0];
               A180sumTotValorIVA = H001S24_A180sumTotValorIVA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
               n180sumTotValorIVA = H001S24_n180sumTotValorIVA[0];
               A179sumTotValor = H001S24_A179sumTotValor[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
               n179sumTotValor = H001S24_n179sumTotValor[0];
               A174sumTotCant = H001S24_A174sumTotCant[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
               n174sumTotCant = H001S24_n174sumTotCant[0];
               A177ObrSubtotal = H001S24_A177ObrSubtotal[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               A176sumTotNeto1 = H001S24_A176sumTotNeto1[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
               A74protDsc = H001S24_A74protDsc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A74protDsc", A74protDsc);
               n74protDsc = H001S24_n74protDsc[0];
               A176sumTotNeto1 = H001S24_A176sumTotNeto1[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
               A177ObrSubtotal = H001S24_A177ObrSubtotal[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               A180sumTotValorIVA = H001S24_A180sumTotValorIVA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
               n180sumTotValorIVA = H001S24_n180sumTotValorIVA[0];
               A179sumTotValor = H001S24_A179sumTotValor[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
               n179sumTotValor = H001S24_n179sumTotValor[0];
               A174sumTotCant = H001S24_A174sumTotCant[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
               n174sumTotCant = H001S24_n174sumTotCant[0];
               /* Execute user event: Load */
               E141S2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(6);
            WB1S0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1S2( )
      {
      }

      protected void STRUP1S0( )
      {
         /* Before Start, stand alone formulas. */
         AV14Pgmname = "CotizadorGeneral";
         context.Gx_err = 0;
         /* Using cursor H001S25 */
         pr_default.execute(7, new Object[] {A1EmpID});
         A44empdsc = H001S25_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A44empdsc", A44empdsc);
         n44empdsc = H001S25_n44empdsc[0];
         pr_default.close(7);
         /* Using cursor H001S29 */
         pr_default.execute(8, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            A176sumTotNeto1 = H001S29_A176sumTotNeto1[0];
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         }
         else
         {
            A176sumTotNeto1 = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         }
         pr_default.close(8);
         /* Using cursor H001S31 */
         pr_default.execute(9, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            A177ObrSubtotal = H001S31_A177ObrSubtotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         }
         else
         {
            A177ObrSubtotal = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         }
         pr_default.close(9);
         A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         /* Using cursor H001S34 */
         pr_default.execute(10, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(10) != 101) )
         {
            A180sumTotValorIVA = H001S34_A180sumTotValorIVA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            n180sumTotValorIVA = H001S34_n180sumTotValorIVA[0];
         }
         else
         {
            A180sumTotValorIVA = 0;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         }
         pr_default.close(10);
         /* Using cursor H001S36 */
         pr_default.execute(11, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(11) != 101) )
         {
            A179sumTotValor = H001S36_A179sumTotValor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            n179sumTotValor = H001S36_n179sumTotValor[0];
         }
         else
         {
            A179sumTotValor = 0;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         }
         pr_default.close(11);
         /* Using cursor H001S38 */
         pr_default.execute(12, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(12) != 101) )
         {
            A174sumTotCant = H001S38_A174sumTotCant[0];
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            n174sumTotCant = H001S38_n174sumTotCant[0];
         }
         else
         {
            A174sumTotCant = 0;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         }
         pr_default.close(12);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E131S2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
            n44empdsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A44empdsc", A44empdsc);
            A154CotiDsc = cgiGet( edtCotiDsc_Internalname);
            n154CotiDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A154CotiDsc", A154CotiDsc);
            A10protID = (short)(context.localUtil.CToN( cgiGet( edtprotID_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
            A74protDsc = cgiGet( edtprotDsc_Internalname);
            n74protDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A74protDsc", A74protDsc);
            A155CotiIVA = context.localUtil.CToN( cgiGet( edtCotiIVA_Internalname), ",", ".");
            n155CotiIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155CotiIVA", StringUtil.LTrim( StringUtil.Str( A155CotiIVA, 8, 3)));
            A156CotiUltNro = (int)(context.localUtil.CToN( cgiGet( edtCotiUltNro_Internalname), ",", "."));
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            A174sumTotCant = context.localUtil.CToN( cgiGet( edtsumTotCant_Internalname), ",", ".");
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            A175sumTotNeto = context.localUtil.CToN( cgiGet( edtsumTotNeto_Internalname), ",", ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            A179sumTotValor = context.localUtil.CToN( cgiGet( edtsumTotValor_Internalname), ",", ".");
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            A180sumTotValorIVA = context.localUtil.CToN( cgiGet( edtsumTotValorIVA_Internalname), ",", ".");
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            A181TotNeto = context.localUtil.CToN( cgiGet( edtTotNeto_Internalname), ",", ".");
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
            A182CotiObs = cgiGet( edtCotiObs_Internalname);
            n182CotiObs = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A182CotiObs", A182CotiObs);
            A201CotiUltNroObr = (int)(context.localUtil.CToN( cgiGet( edtCotiUltNroObr_Internalname), ",", "."));
            n201CotiUltNroObr = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A201CotiUltNroObr", StringUtil.LTrim( StringUtil.Str( (decimal)(A201CotiUltNroObr), 8, 0)));
            A177ObrSubtotal = context.localUtil.CToN( cgiGet( edtObrSubtotal_Internalname), ",", ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            A176sumTotNeto1 = (short)(context.localUtil.CToN( cgiGet( edtsumTotNeto1_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            /* Read saved values. */
            wcpOA1EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA1EmpID"), ",", "."));
            wcpOA34CotiID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA34CotiID"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E131S2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E131S2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV14Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV8TrnContext = new SdtTransactionContext(context);
         AV8TrnContext.gxTpr_Callerobject = AV14Pgmname;
         AV8TrnContext.gxTpr_Callerondelete = false;
         AV8TrnContext.gxTpr_Callerurl = AV11HTTPRequest.ScriptName+"?"+AV11HTTPRequest.QueryString;
         AV8TrnContext.gxTpr_Transactionname = "Cotizador";
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9TrnContextAtt.gxTpr_Attributename = "EmpID";
         AV9TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6EmpID), 4, 0);
         AV8TrnContext.gxTpr_Attributes.Add(AV9TrnContextAtt, 0);
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9TrnContextAtt.gxTpr_Attributename = "CotiID";
         AV9TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7CotiID), 4, 0);
         AV8TrnContext.gxTpr_Attributes.Add(AV9TrnContextAtt, 0);
         AV10Session.Set("TrnContext", AV8TrnContext.ToXml(false, true, "TransactionContext", "KBCalpesa22"));
      }

      protected void nextLoad( )
      {
      }

      protected void E141S2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A1EmpID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A34CotiID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
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
         PA1S2( ) ;
         WS1S2( ) ;
         WE1S2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlA1EmpID = (String)((String)getParm(obj,0));
         sCtrlA34CotiID = (String)((String)getParm(obj,1));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA1S2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "cotizadorgeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA1S2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A1EmpID = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A34CotiID = Convert.ToInt16(getParm(obj,3));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
         }
         wcpOA1EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA1EmpID"), ",", "."));
         wcpOA34CotiID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA34CotiID"), ",", "."));
         if ( ! GetJustCreated( ) && ( ( A1EmpID != wcpOA1EmpID ) || ( A34CotiID != wcpOA34CotiID ) ) )
         {
            setjustcreated();
         }
         wcpOA1EmpID = A1EmpID;
         wcpOA34CotiID = A34CotiID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA1EmpID = cgiGet( sPrefix+"A1EmpID_CTRL");
         if ( StringUtil.Len( sCtrlA1EmpID) > 0 )
         {
            A1EmpID = (short)(context.localUtil.CToN( cgiGet( sCtrlA1EmpID), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         else
         {
            A1EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A1EmpID_PARM"), ",", "."));
         }
         sCtrlA34CotiID = cgiGet( sPrefix+"A34CotiID_CTRL");
         if ( StringUtil.Len( sCtrlA34CotiID) > 0 )
         {
            A34CotiID = (short)(context.localUtil.CToN( cgiGet( sCtrlA34CotiID), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
         }
         else
         {
            A34CotiID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A34CotiID_PARM"), ",", "."));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA1S2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS1S2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS1S2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A1EmpID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA1EmpID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A1EmpID_CTRL", StringUtil.RTrim( sCtrlA1EmpID));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"A34CotiID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34CotiID), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA34CotiID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A34CotiID_CTRL", StringUtil.RTrim( sCtrlA34CotiID));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE1S2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022111922532687", true);
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
         context.AddJavascriptSource("cotizadorgeneral.js", "?2022111922532687", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         edtEmpID_Internalname = sPrefix+"EMPID";
         edtempdsc_Internalname = sPrefix+"EMPDSC";
         edtCotiID_Internalname = sPrefix+"COTIID";
         edtCotiDsc_Internalname = sPrefix+"COTIDSC";
         edtprotID_Internalname = sPrefix+"PROTID";
         edtprotDsc_Internalname = sPrefix+"PROTDSC";
         edtCotiIVA_Internalname = sPrefix+"COTIIVA";
         edtCotiUltNro_Internalname = sPrefix+"COTIULTNRO";
         edtsumTotCant_Internalname = sPrefix+"SUMTOTCANT";
         edtsumTotNeto_Internalname = sPrefix+"SUMTOTNETO";
         edtsumTotValor_Internalname = sPrefix+"SUMTOTVALOR";
         edtsumTotValorIVA_Internalname = sPrefix+"SUMTOTVALORIVA";
         edtTotNeto_Internalname = sPrefix+"TOTNETO";
         edtCotiObs_Internalname = sPrefix+"COTIOBS";
         edtCotiUltNroObr_Internalname = sPrefix+"COTIULTNROOBR";
         edtObrSubtotal_Internalname = sPrefix+"OBRSUBTOTAL";
         edtsumTotNeto1_Internalname = sPrefix+"SUMTOTNETO1";
         divAttributestable_Internalname = sPrefix+"ATTRIBUTESTABLE";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtsumTotNeto1_Jsonclick = "";
         edtsumTotNeto1_Enabled = 0;
         edtObrSubtotal_Jsonclick = "";
         edtObrSubtotal_Enabled = 0;
         edtCotiUltNroObr_Jsonclick = "";
         edtCotiUltNroObr_Enabled = 0;
         edtCotiObs_Jsonclick = "";
         edtCotiObs_Enabled = 0;
         edtTotNeto_Jsonclick = "";
         edtTotNeto_Enabled = 0;
         edtsumTotValorIVA_Jsonclick = "";
         edtsumTotValorIVA_Enabled = 0;
         edtsumTotValor_Jsonclick = "";
         edtsumTotValor_Enabled = 0;
         edtsumTotNeto_Jsonclick = "";
         edtsumTotNeto_Enabled = 0;
         edtsumTotCant_Jsonclick = "";
         edtsumTotCant_Enabled = 0;
         edtCotiUltNro_Jsonclick = "";
         edtCotiUltNro_Enabled = 0;
         edtCotiIVA_Jsonclick = "";
         edtCotiIVA_Enabled = 0;
         edtprotDsc_Jsonclick = "";
         edtprotDsc_Enabled = 0;
         edtprotID_Jsonclick = "";
         edtprotID_Enabled = 0;
         edtCotiDsc_Jsonclick = "";
         edtCotiDsc_Enabled = 0;
         edtCotiID_Jsonclick = "";
         edtCotiID_Enabled = 0;
         edtempdsc_Jsonclick = "";
         edtempdsc_Enabled = 0;
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOUPDATE'","{handler:'E111S1',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'A34CotiID',fld:'COTIID',pic:'ZZZ9'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E121S1',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'A34CotiID',fld:'COTIID',pic:'ZZZ9'}]");
         setEventMetadata("'DODELETE'",",oparms:[]}");
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
         sPrefix = "";
         AV14Pgmname = "";
         scmdbuf = "";
         H001S2_A44empdsc = new String[] {""} ;
         H001S2_n44empdsc = new bool[] {false} ;
         A44empdsc = "";
         H001S6_A176sumTotNeto1 = new short[1] ;
         H001S8_A177ObrSubtotal = new decimal[1] ;
         H001S11_A180sumTotValorIVA = new decimal[1] ;
         H001S11_n180sumTotValorIVA = new bool[] {false} ;
         H001S13_A179sumTotValor = new decimal[1] ;
         H001S13_n179sumTotValor = new bool[] {false} ;
         H001S15_A174sumTotCant = new decimal[1] ;
         H001S15_n174sumTotCant = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         A154CotiDsc = "";
         A74protDsc = "";
         A182CotiObs = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         H001S24_A1EmpID = new short[1] ;
         H001S24_A34CotiID = new short[1] ;
         H001S24_A201CotiUltNroObr = new int[1] ;
         H001S24_n201CotiUltNroObr = new bool[] {false} ;
         H001S24_A182CotiObs = new String[] {""} ;
         H001S24_n182CotiObs = new bool[] {false} ;
         H001S24_A181TotNeto = new decimal[1] ;
         H001S24_n181TotNeto = new bool[] {false} ;
         H001S24_A156CotiUltNro = new int[1] ;
         H001S24_n156CotiUltNro = new bool[] {false} ;
         H001S24_A155CotiIVA = new decimal[1] ;
         H001S24_n155CotiIVA = new bool[] {false} ;
         H001S24_A74protDsc = new String[] {""} ;
         H001S24_n74protDsc = new bool[] {false} ;
         H001S24_A10protID = new short[1] ;
         H001S24_A154CotiDsc = new String[] {""} ;
         H001S24_n154CotiDsc = new bool[] {false} ;
         H001S24_A44empdsc = new String[] {""} ;
         H001S24_n44empdsc = new bool[] {false} ;
         H001S24_A180sumTotValorIVA = new decimal[1] ;
         H001S24_n180sumTotValorIVA = new bool[] {false} ;
         H001S24_A179sumTotValor = new decimal[1] ;
         H001S24_n179sumTotValor = new bool[] {false} ;
         H001S24_A174sumTotCant = new decimal[1] ;
         H001S24_n174sumTotCant = new bool[] {false} ;
         H001S24_A177ObrSubtotal = new decimal[1] ;
         H001S24_A176sumTotNeto1 = new short[1] ;
         H001S25_A44empdsc = new String[] {""} ;
         H001S25_n44empdsc = new bool[] {false} ;
         H001S29_A176sumTotNeto1 = new short[1] ;
         H001S31_A177ObrSubtotal = new decimal[1] ;
         H001S34_A180sumTotValorIVA = new decimal[1] ;
         H001S34_n180sumTotValorIVA = new bool[] {false} ;
         H001S36_A179sumTotValor = new decimal[1] ;
         H001S36_n179sumTotValor = new bool[] {false} ;
         H001S38_A174sumTotCant = new decimal[1] ;
         H001S38_n174sumTotCant = new bool[] {false} ;
         AV8TrnContext = new SdtTransactionContext(context);
         AV11HTTPRequest = new GxHttpRequest( context);
         AV9TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV10Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA1EmpID = "";
         sCtrlA34CotiID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cotizadorgeneral__default(),
            new Object[][] {
                new Object[] {
               H001S2_A44empdsc, H001S2_n44empdsc
               }
               , new Object[] {
               H001S6_A176sumTotNeto1
               }
               , new Object[] {
               H001S8_A177ObrSubtotal
               }
               , new Object[] {
               H001S11_A180sumTotValorIVA, H001S11_n180sumTotValorIVA
               }
               , new Object[] {
               H001S13_A179sumTotValor, H001S13_n179sumTotValor
               }
               , new Object[] {
               H001S15_A174sumTotCant, H001S15_n174sumTotCant
               }
               , new Object[] {
               H001S24_A1EmpID, H001S24_A34CotiID, H001S24_A201CotiUltNroObr, H001S24_n201CotiUltNroObr, H001S24_A182CotiObs, H001S24_n182CotiObs, H001S24_A181TotNeto, H001S24_n181TotNeto, H001S24_A156CotiUltNro, H001S24_n156CotiUltNro,
               H001S24_A155CotiIVA, H001S24_n155CotiIVA, H001S24_A74protDsc, H001S24_n74protDsc, H001S24_A10protID, H001S24_A154CotiDsc, H001S24_n154CotiDsc, H001S24_A44empdsc, H001S24_n44empdsc, H001S24_A180sumTotValorIVA,
               H001S24_n180sumTotValorIVA, H001S24_A179sumTotValor, H001S24_n179sumTotValor, H001S24_A174sumTotCant, H001S24_n174sumTotCant, H001S24_A177ObrSubtotal, H001S24_A176sumTotNeto1
               }
               , new Object[] {
               H001S25_A44empdsc, H001S25_n44empdsc
               }
               , new Object[] {
               H001S29_A176sumTotNeto1
               }
               , new Object[] {
               H001S31_A177ObrSubtotal
               }
               , new Object[] {
               H001S34_A180sumTotValorIVA, H001S34_n180sumTotValorIVA
               }
               , new Object[] {
               H001S36_A179sumTotValor, H001S36_n179sumTotValor
               }
               , new Object[] {
               H001S38_A174sumTotCant, H001S38_n174sumTotCant
               }
            }
         );
         AV14Pgmname = "CotizadorGeneral";
         /* GeneXus formulas. */
         AV14Pgmname = "CotizadorGeneral";
         context.Gx_err = 0;
      }

      private short A1EmpID ;
      private short A34CotiID ;
      private short wcpOA1EmpID ;
      private short wcpOA34CotiID ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short A176sumTotNeto1 ;
      private short wbEnd ;
      private short wbStart ;
      private short A10protID ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV6EmpID ;
      private short AV7CotiID ;
      private short nGXWrapped ;
      private int edtEmpID_Enabled ;
      private int edtempdsc_Enabled ;
      private int edtCotiID_Enabled ;
      private int edtCotiDsc_Enabled ;
      private int edtprotID_Enabled ;
      private int edtprotDsc_Enabled ;
      private int edtCotiIVA_Enabled ;
      private int A156CotiUltNro ;
      private int edtCotiUltNro_Enabled ;
      private int edtsumTotCant_Enabled ;
      private int edtsumTotNeto_Enabled ;
      private int edtsumTotValor_Enabled ;
      private int edtsumTotValorIVA_Enabled ;
      private int edtTotNeto_Enabled ;
      private int edtCotiObs_Enabled ;
      private int A201CotiUltNroObr ;
      private int edtCotiUltNroObr_Enabled ;
      private int edtObrSubtotal_Enabled ;
      private int edtsumTotNeto1_Enabled ;
      private int idxLst ;
      private decimal A177ObrSubtotal ;
      private decimal A175sumTotNeto ;
      private decimal A180sumTotValorIVA ;
      private decimal A179sumTotValor ;
      private decimal A174sumTotCant ;
      private decimal A155CotiIVA ;
      private decimal A181TotNeto ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV14Pgmname ;
      private String scmdbuf ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String divAttributestable_Internalname ;
      private String edtEmpID_Internalname ;
      private String edtEmpID_Jsonclick ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String edtCotiID_Internalname ;
      private String edtCotiID_Jsonclick ;
      private String edtCotiDsc_Internalname ;
      private String edtCotiDsc_Jsonclick ;
      private String edtprotID_Internalname ;
      private String edtprotID_Jsonclick ;
      private String edtprotDsc_Internalname ;
      private String A74protDsc ;
      private String edtprotDsc_Jsonclick ;
      private String edtCotiIVA_Internalname ;
      private String edtCotiIVA_Jsonclick ;
      private String edtCotiUltNro_Internalname ;
      private String edtCotiUltNro_Jsonclick ;
      private String edtsumTotCant_Internalname ;
      private String edtsumTotCant_Jsonclick ;
      private String edtsumTotNeto_Internalname ;
      private String edtsumTotNeto_Jsonclick ;
      private String edtsumTotValor_Internalname ;
      private String edtsumTotValor_Jsonclick ;
      private String edtsumTotValorIVA_Internalname ;
      private String edtsumTotValorIVA_Jsonclick ;
      private String edtTotNeto_Internalname ;
      private String edtTotNeto_Jsonclick ;
      private String edtCotiObs_Internalname ;
      private String edtCotiObs_Jsonclick ;
      private String edtCotiUltNroObr_Internalname ;
      private String edtCotiUltNroObr_Jsonclick ;
      private String edtObrSubtotal_Internalname ;
      private String edtObrSubtotal_Jsonclick ;
      private String edtsumTotNeto1_Internalname ;
      private String edtsumTotNeto1_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sCtrlA1EmpID ;
      private String sCtrlA34CotiID ;
      private bool entryPointCalled ;
      private bool n44empdsc ;
      private bool n180sumTotValorIVA ;
      private bool n179sumTotValor ;
      private bool n174sumTotCant ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n201CotiUltNroObr ;
      private bool n182CotiObs ;
      private bool n181TotNeto ;
      private bool n156CotiUltNro ;
      private bool n155CotiIVA ;
      private bool n74protDsc ;
      private bool n154CotiDsc ;
      private bool returnInSub ;
      private String A44empdsc ;
      private String A154CotiDsc ;
      private String A182CotiObs ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H001S2_A44empdsc ;
      private bool[] H001S2_n44empdsc ;
      private short[] H001S6_A176sumTotNeto1 ;
      private decimal[] H001S8_A177ObrSubtotal ;
      private decimal[] H001S11_A180sumTotValorIVA ;
      private bool[] H001S11_n180sumTotValorIVA ;
      private decimal[] H001S13_A179sumTotValor ;
      private bool[] H001S13_n179sumTotValor ;
      private decimal[] H001S15_A174sumTotCant ;
      private bool[] H001S15_n174sumTotCant ;
      private short[] H001S24_A1EmpID ;
      private short[] H001S24_A34CotiID ;
      private int[] H001S24_A201CotiUltNroObr ;
      private bool[] H001S24_n201CotiUltNroObr ;
      private String[] H001S24_A182CotiObs ;
      private bool[] H001S24_n182CotiObs ;
      private decimal[] H001S24_A181TotNeto ;
      private bool[] H001S24_n181TotNeto ;
      private int[] H001S24_A156CotiUltNro ;
      private bool[] H001S24_n156CotiUltNro ;
      private decimal[] H001S24_A155CotiIVA ;
      private bool[] H001S24_n155CotiIVA ;
      private String[] H001S24_A74protDsc ;
      private bool[] H001S24_n74protDsc ;
      private short[] H001S24_A10protID ;
      private String[] H001S24_A154CotiDsc ;
      private bool[] H001S24_n154CotiDsc ;
      private String[] H001S24_A44empdsc ;
      private bool[] H001S24_n44empdsc ;
      private decimal[] H001S24_A180sumTotValorIVA ;
      private bool[] H001S24_n180sumTotValorIVA ;
      private decimal[] H001S24_A179sumTotValor ;
      private bool[] H001S24_n179sumTotValor ;
      private decimal[] H001S24_A174sumTotCant ;
      private bool[] H001S24_n174sumTotCant ;
      private decimal[] H001S24_A177ObrSubtotal ;
      private short[] H001S24_A176sumTotNeto1 ;
      private String[] H001S25_A44empdsc ;
      private bool[] H001S25_n44empdsc ;
      private short[] H001S29_A176sumTotNeto1 ;
      private decimal[] H001S31_A177ObrSubtotal ;
      private decimal[] H001S34_A180sumTotValorIVA ;
      private bool[] H001S34_n180sumTotValorIVA ;
      private decimal[] H001S36_A179sumTotValor ;
      private bool[] H001S36_n179sumTotValor ;
      private decimal[] H001S38_A174sumTotCant ;
      private bool[] H001S38_n174sumTotCant ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV11HTTPRequest ;
      private IGxSession AV10Session ;
      private SdtTransactionContext AV8TrnContext ;
      private SdtTransactionContext_Attribute AV9TrnContextAtt ;
   }

   public class cotizadorgeneral__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001S2 ;
          prmH001S2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S6 ;
          prmH001S6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S8 ;
          prmH001S8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S11 ;
          prmH001S11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S13 ;
          prmH001S13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S15 ;
          prmH001S15 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S24 ;
          prmH001S24 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          String cmdBufferH001S24 ;
          cmdBufferH001S24=" SELECT T1.[EmpID], T1.[CotiID], T1.[CotiUltNroObr], T1.[CotiObs], T1.[TotNeto], T1.[CotiUltNro], T1.[CotiIVA], T3.[protDsc], T1.[protID], T1.[CotiDsc], T2.[empdsc], COALESCE( T6.[sumTotValorIVA], 0) AS sumTotValorIVA, COALESCE( T7.[sumTotValor], 0) AS sumTotValor, COALESCE( T8.[sumTotCant], 0) AS sumTotCant, COALESCE( T5.[ObrSubtotal], 0) AS ObrSubtotal, COALESCE( T4.[sumTotNeto1], 0) AS sumTotNeto1 FROM ((((((([Cotizador] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID]) INNER JOIN [Prototipo] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[protID] = T1.[protID]) LEFT JOIN (SELECT T9.[EmpID], T9.[CotiID], SUM(COALESCE( T10.[CotiDetTotal], 0)) AS sumTotNeto1 FROM ([CotizadorLevel1] T9 WITH (NOLOCK) INNER JOIN (SELECT ROUND(( COALESCE( T12.[subCatPrec], 0) * CAST(COALESCE( T11.[CotiDetCant], 0) AS decimal( 20, 10)) + COALESCE( T13.[CotiDetIva], 0)), 2) AS CotiDetTotal, T11.[EmpID], T11.[CotiID], T11.[secID] FROM (([CotizadorLevel1] T11 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T12 WITH (NOLOCK) ON T12.[EmpID] = T11.[EmpID] AND T12.[categID] = T11.[categID] AND T12.[subCatID] = T11.[subCatID]) INNER JOIN (SELECT ( CAST(( ( COALESCE( T15.[subCatPrec], 0) * CAST(COALESCE( T14.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T16.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T14.[EmpID], T14.[CotiID], T14.[secID] FROM (([CotizadorLevel1] T14 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T15 WITH (NOLOCK) ON T15.[EmpID] = T14.[EmpID] AND T15.[categID] = T14.[categID] AND T15.[subCatID] = T14.[subCatID]) INNER JOIN [Cotizador] T16 WITH (NOLOCK) ON T16.[EmpID] = T14.[EmpID] AND T16.[CotiID] = T14.[CotiID]) ) T13 ON T13.[EmpID] = T11.[EmpID] AND T13.[CotiID] = T11.[CotiID] AND T13.[secID] = T11.[secID]) "
          + " ) T10 ON T10.[EmpID] = T9.[EmpID] AND T10.[CotiID] = T9.[CotiID] AND T10.[secID] = T9.[secID]) GROUP BY T9.[EmpID], T9.[CotiID] ) T4 ON T4.[EmpID] = T1.[EmpID] AND T4.[CotiID] = T1.[CotiID]) LEFT JOIN (SELECT [EmpID], [CotiID], SUM([ObrValor]) AS ObrSubtotal FROM [CotizadorObreros] WITH (NOLOCK) GROUP BY [EmpID], [CotiID] ) T5 ON T5.[EmpID] = T1.[EmpID] AND T5.[CotiID] = T1.[CotiID]) LEFT JOIN (SELECT SUM(COALESCE( T10.[CotiDetIva], 0)) AS sumTotValorIVA, T9.[EmpID], T9.[CotiID] FROM ([CotizadorLevel1] T9 WITH (NOLOCK) INNER JOIN (SELECT ( CAST(( ( COALESCE( T12.[subCatPrec], 0) * CAST(COALESCE( T11.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T13.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T11.[EmpID], T11.[CotiID], T11.[secID] FROM (([CotizadorLevel1] T11 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T12 WITH (NOLOCK) ON T12.[EmpID] = T11.[EmpID] AND T12.[categID] = T11.[categID] AND T12.[subCatID] = T11.[subCatID]) INNER JOIN [Cotizador] T13 WITH (NOLOCK) ON T13.[EmpID] = T11.[EmpID] AND T13.[CotiID] = T11.[CotiID]) ) T10 ON T10.[EmpID] = T9.[EmpID] AND T10.[CotiID] = T9.[CotiID] AND T10.[secID] = T9.[secID]) GROUP BY T9.[EmpID], T9.[CotiID] ) T6 ON T6.[EmpID] = T1.[EmpID] AND T6.[CotiID] = T1.[CotiID]) LEFT JOIN (SELECT SUM(COALESCE( T10.[subCatPrec], 0) * CAST(COALESCE( T9.[CotiDetCant], 0) AS decimal( 20, 10))) AS sumTotValor, T9.[EmpID], T9.[CotiID] FROM ([CotizadorLevel1] T9 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T10 WITH (NOLOCK) ON T10.[EmpID] = T9.[EmpID] AND T10.[categID] = T9.[categID] AND T10.[subCatID] = T9.[subCatID]) GROUP BY T9.[EmpID], T9.[CotiID] ) T7 ON T7.[EmpID] = T1.[EmpID] AND T7.[CotiID] = T1.[CotiID]) LEFT JOIN (SELECT SUM([CotiDetCant]) AS sumTotCant, [EmpID], [CotiID] FROM [CotizadorLevel1] WITH"
          + " (NOLOCK) GROUP BY [EmpID], [CotiID] ) T8 ON T8.[EmpID] = T1.[EmpID] AND T8.[CotiID] = T1.[CotiID]) WHERE T1.[EmpID] = @EmpID and T1.[CotiID] = @CotiID ORDER BY T1.[EmpID], T1.[CotiID]" ;
          Object[] prmH001S25 ;
          prmH001S25 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S29 ;
          prmH001S29 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S31 ;
          prmH001S31 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S34 ;
          prmH001S34 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S36 ;
          prmH001S36 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001S38 ;
          prmH001S38 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001S2", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S2,1,0,true,true )
             ,new CursorDef("H001S6", "SELECT COALESCE( T1.[sumTotNeto1], 0) AS sumTotNeto1 FROM (SELECT T2.[EmpID], T2.[CotiID], SUM(COALESCE( T3.[CotiDetTotal], 0)) AS sumTotNeto1 FROM ([CotizadorLevel1] T2 WITH (NOLOCK) INNER JOIN (SELECT ROUND(( COALESCE( T5.[subCatPrec], 0) * CAST(COALESCE( T4.[CotiDetCant], 0) AS decimal( 20, 10)) + COALESCE( T6.[CotiDetIva], 0)), 2) AS CotiDetTotal, T4.[EmpID], T4.[CotiID], T4.[secID] FROM (([CotizadorLevel1] T4 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T5 WITH (NOLOCK) ON T5.[EmpID] = T4.[EmpID] AND T5.[categID] = T4.[categID] AND T5.[subCatID] = T4.[subCatID]) INNER JOIN (SELECT ( CAST(( ( COALESCE( T8.[subCatPrec], 0) * CAST(COALESCE( T7.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T9.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T7.[EmpID], T7.[CotiID], T7.[secID] FROM (([CotizadorLevel1] T7 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T8 WITH (NOLOCK) ON T8.[EmpID] = T7.[EmpID] AND T8.[categID] = T7.[categID] AND T8.[subCatID] = T7.[subCatID]) INNER JOIN [Cotizador] T9 WITH (NOLOCK) ON T9.[EmpID] = T7.[EmpID] AND T9.[CotiID] = T7.[CotiID]) ) T6 ON T6.[EmpID] = T4.[EmpID] AND T6.[CotiID] = T4.[CotiID] AND T6.[secID] = T4.[secID]) ) T3 ON T3.[EmpID] = T2.[EmpID] AND T3.[CotiID] = T2.[CotiID] AND T3.[secID] = T2.[secID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S6,1,0,true,true )
             ,new CursorDef("H001S8", "SELECT COALESCE( T1.[ObrSubtotal], 0) AS ObrSubtotal FROM (SELECT [EmpID], [CotiID], SUM([ObrValor]) AS ObrSubtotal FROM [CotizadorObreros] WITH (NOLOCK) GROUP BY [EmpID], [CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S8,1,0,true,true )
             ,new CursorDef("H001S11", "SELECT COALESCE( T1.[sumTotValorIVA], 0) AS sumTotValorIVA FROM (SELECT SUM(COALESCE( T3.[CotiDetIva], 0)) AS sumTotValorIVA, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (NOLOCK) INNER JOIN (SELECT ( CAST(( ( COALESCE( T5.[subCatPrec], 0) * CAST(COALESCE( T4.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T6.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T4.[EmpID], T4.[CotiID], T4.[secID] FROM (([CotizadorLevel1] T4 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T5 WITH (NOLOCK) ON T5.[EmpID] = T4.[EmpID] AND T5.[categID] = T4.[categID] AND T5.[subCatID] = T4.[subCatID]) INNER JOIN [Cotizador] T6 WITH (NOLOCK) ON T6.[EmpID] = T4.[EmpID] AND T6.[CotiID] = T4.[CotiID]) ) T3 ON T3.[EmpID] = T2.[EmpID] AND T3.[CotiID] = T2.[CotiID] AND T3.[secID] = T2.[secID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S11,1,0,true,true )
             ,new CursorDef("H001S13", "SELECT COALESCE( T1.[sumTotValor], 0) AS sumTotValor FROM (SELECT SUM(COALESCE( T3.[subCatPrec], 0) * CAST(COALESCE( T2.[CotiDetCant], 0) AS decimal( 20, 10))) AS sumTotValor, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T2.[EmpID] AND T3.[categID] = T2.[categID] AND T3.[subCatID] = T2.[subCatID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S13,1,0,true,true )
             ,new CursorDef("H001S15", "SELECT COALESCE( T1.[sumTotCant], 0) AS sumTotCant FROM (SELECT SUM([CotiDetCant]) AS sumTotCant, [EmpID], [CotiID] FROM [CotizadorLevel1] WITH (NOLOCK) GROUP BY [EmpID], [CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S15,1,0,true,true )
             ,new CursorDef("H001S24", cmdBufferH001S24,false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S24,1,0,true,true )
             ,new CursorDef("H001S25", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S25,1,0,true,true )
             ,new CursorDef("H001S29", "SELECT COALESCE( T1.[sumTotNeto1], 0) AS sumTotNeto1 FROM (SELECT T2.[EmpID], T2.[CotiID], SUM(COALESCE( T3.[CotiDetTotal], 0)) AS sumTotNeto1 FROM ([CotizadorLevel1] T2 WITH (NOLOCK) INNER JOIN (SELECT ROUND(( COALESCE( T5.[subCatPrec], 0) * CAST(COALESCE( T4.[CotiDetCant], 0) AS decimal( 20, 10)) + COALESCE( T6.[CotiDetIva], 0)), 2) AS CotiDetTotal, T4.[EmpID], T4.[CotiID], T4.[secID] FROM (([CotizadorLevel1] T4 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T5 WITH (NOLOCK) ON T5.[EmpID] = T4.[EmpID] AND T5.[categID] = T4.[categID] AND T5.[subCatID] = T4.[subCatID]) INNER JOIN (SELECT ( CAST(( ( COALESCE( T8.[subCatPrec], 0) * CAST(COALESCE( T7.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T9.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T7.[EmpID], T7.[CotiID], T7.[secID] FROM (([CotizadorLevel1] T7 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T8 WITH (NOLOCK) ON T8.[EmpID] = T7.[EmpID] AND T8.[categID] = T7.[categID] AND T8.[subCatID] = T7.[subCatID]) INNER JOIN [Cotizador] T9 WITH (NOLOCK) ON T9.[EmpID] = T7.[EmpID] AND T9.[CotiID] = T7.[CotiID]) ) T6 ON T6.[EmpID] = T4.[EmpID] AND T6.[CotiID] = T4.[CotiID] AND T6.[secID] = T4.[secID]) ) T3 ON T3.[EmpID] = T2.[EmpID] AND T3.[CotiID] = T2.[CotiID] AND T3.[secID] = T2.[secID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S29,1,0,true,true )
             ,new CursorDef("H001S31", "SELECT COALESCE( T1.[ObrSubtotal], 0) AS ObrSubtotal FROM (SELECT [EmpID], [CotiID], SUM([ObrValor]) AS ObrSubtotal FROM [CotizadorObreros] WITH (NOLOCK) GROUP BY [EmpID], [CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S31,1,0,true,true )
             ,new CursorDef("H001S34", "SELECT COALESCE( T1.[sumTotValorIVA], 0) AS sumTotValorIVA FROM (SELECT SUM(COALESCE( T3.[CotiDetIva], 0)) AS sumTotValorIVA, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (NOLOCK) INNER JOIN (SELECT ( CAST(( ( COALESCE( T5.[subCatPrec], 0) * CAST(COALESCE( T4.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T6.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T4.[EmpID], T4.[CotiID], T4.[secID] FROM (([CotizadorLevel1] T4 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T5 WITH (NOLOCK) ON T5.[EmpID] = T4.[EmpID] AND T5.[categID] = T4.[categID] AND T5.[subCatID] = T4.[subCatID]) INNER JOIN [Cotizador] T6 WITH (NOLOCK) ON T6.[EmpID] = T4.[EmpID] AND T6.[CotiID] = T4.[CotiID]) ) T3 ON T3.[EmpID] = T2.[EmpID] AND T3.[CotiID] = T2.[CotiID] AND T3.[secID] = T2.[secID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S34,1,0,true,true )
             ,new CursorDef("H001S36", "SELECT COALESCE( T1.[sumTotValor], 0) AS sumTotValor FROM (SELECT SUM(COALESCE( T3.[subCatPrec], 0) * CAST(COALESCE( T2.[CotiDetCant], 0) AS decimal( 20, 10))) AS sumTotValor, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T2.[EmpID] AND T3.[categID] = T2.[categID] AND T3.[subCatID] = T2.[subCatID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S36,1,0,true,true )
             ,new CursorDef("H001S38", "SELECT COALESCE( T1.[sumTotCant], 0) AS sumTotCant FROM (SELECT SUM([CotiDetCant]) AS sumTotCant, [EmpID], [CotiID] FROM [CotizadorLevel1] WITH (NOLOCK) GROUP BY [EmpID], [CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001S38,1,0,true,true )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 2 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                return;
             case 3 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 4 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((int[]) buf[8])[0] = rslt.getInt(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getString(8, 50) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(10);
                ((String[]) buf[17])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(11);
                ((decimal[]) buf[19])[0] = rslt.getDecimal(12) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(12);
                ((decimal[]) buf[21])[0] = rslt.getDecimal(13) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(13);
                ((decimal[]) buf[23])[0] = rslt.getDecimal(14) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(14);
                ((decimal[]) buf[25])[0] = rslt.getDecimal(15) ;
                ((short[]) buf[26])[0] = rslt.getShort(16) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                return;
             case 10 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 11 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 12 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
