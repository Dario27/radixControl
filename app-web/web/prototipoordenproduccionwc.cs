/*
               File: PrototipoOrdenProduccionWC
        Description: Prototipo Orden Produccion WC
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:15:32.47
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
   public class prototipoordenproduccionwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public prototipoordenproduccionwc( )
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

      public prototipoordenproduccionwc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_protID )
      {
         this.AV6EmpID = aP0_EmpID;
         this.AV7protID = aP1_protID;
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
                  AV6EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6EmpID), 4, 0)));
                  AV7protID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7protID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7protID), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)AV6EmpID,(short)AV7protID});
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
               {
                  nRC_GXsfl_20 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_20_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_20_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
                  AV12Update = GetNextPar( );
                  edtavUpdate_Tooltiptext = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_20_Refreshing);
                  AV13Delete = GetNextPar( );
                  edtavDelete_Tooltiptext = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_20_Refreshing);
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxnrGrid_newrow( ) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
               {
                  subGrid_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  AV6EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV7protID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV12Update = GetNextPar( );
                  edtavUpdate_Tooltiptext = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_20_Refreshing);
                  AV13Delete = GetNextPar( );
                  edtavDelete_Tooltiptext = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_20_Refreshing);
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7protID, AV12Update, AV13Delete, sPrefix) ;
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
            PA0Y2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV17Pgmname = "PrototipoOrdenProduccionWC";
               context.Gx_err = 0;
               WS0Y2( ) ;
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
            context.SendWebValue( "Prototipo Orden Produccion WC") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231141153260", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 126726), false);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("prototipoordenproduccionwc.aspx") + "?" + UrlEncode("" +AV6EmpID) + "," + UrlEncode("" +AV7protID)+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
               context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
            }
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
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_20", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_20), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV6EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV6EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7protID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV7protID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPROTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7protID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vUPDATE_Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
         GxWebStd.gx_hidden_field( context, sPrefix+"vDELETE_Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
      }

      protected void RenderHtmlCloseForm0Y2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("prototipoordenproduccionwc.js", "?20231141153264", false);
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
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "</form>") ;
            }
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
         return "PrototipoOrdenProduccionWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Prototipo Orden Produccion WC" ;
      }

      protected void WB0Y0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "prototipoordenproduccionwc.aspx");
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "GridTabMainTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletop_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-7 col-sm-2 col-sm-offset-1 ViewGridActionsCell", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group WWViewActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnNew";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(20), 2, 0)+","+"null"+");", "Agregar", bttBtninsert_Jsonclick, 7, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e110y1_client"+"'", TempTags, "", 2, "HLP_PrototipoOrdenProduccionWC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 ViewGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"20\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "ViewGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title";
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro. Orden") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "tip Ord ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Descripcion") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "vendedor ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "vendedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro. FACT") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "representane") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Image"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Url Pdf") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Vehiculo ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "# Placa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "# Chasis") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Venta") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Dias") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Image"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "documento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "User") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fecha Registro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cliente ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Razon Social") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Periodo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Anio") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Empresa Facturar") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Proceso Actual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Image"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Pdf") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Image"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Recepcion") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Subtotal") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Industria") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Enrique") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Materia P.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mano Pintura") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Estructura") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Otros") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mano Obra") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Gastos") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Rentabilidad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fecha Entrega") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Pedido") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Factura") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Calphesa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Pedido") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mano Obra") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Despacho") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridContainer = new GXWebGrid( context);
               }
               else
               {
                  GridContainer.Clear();
               }
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Header", subGrid_Header);
               GridContainer.AddObjectProperty("Class", "ViewGrid");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17tipOrdID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A104tipOrdDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9vendedorID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A72vendedorDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A106facturaNro), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A107representane));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A108urlPdf);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VehiculoID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A68VehiculoPlaca);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A69VehiculoChasis);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A109fchVenta, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A110cantDias), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A112documento);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A115OrdenEst));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A116OrdenUser));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A57ClienteDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26OrdenMarcaID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A117OrdenModeloID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A132OrdenEmpFac), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A133OrdenProceso);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A152OrdenPdf);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A153OrdenActaPdf);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A161OrdenSubtotal, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A162OrdenValInds, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A163OrdenValEnrq, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A164OrdenValMatPri, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A166OrdenValPint, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A167OrdenValEstr, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A168OrdenValOtrs, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A169OrdenValManObr, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A170OrdenTotGast, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A171OrdenValRenta, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A172OrdenfchEnt, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A192OrdenPed), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A195OrdenFacNomb));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A165OrdenValCal, 10, 3, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A203ordenNroPed), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A210OrdenUltSec), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A255OrdenObreSuma, 10, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A401OrdenNroDesp), 6, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV12Update));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV13Delete));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectedindex), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 20 )
         {
            wbEnd = 0;
            nRC_GXsfl_20 = (short)(nGXsfl_20_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
               GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Emp ID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), ((edtEmpID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")) : context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", edtEmpID_Visible, edtEmpID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_PrototipoOrdenProduccionWC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtprotID_Internalname, "prot ID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtprotID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ",", "")), ((edtprotID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A10protID), "ZZZ9")) : context.localUtil.Format( (decimal)(A10protID), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprotID_Jsonclick, 0, "Attribute", "", "", "", "", edtprotID_Visible, edtprotID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_PrototipoOrdenProduccionWC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 20 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
                  GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
                  if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START0Y2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
               Form.Meta.addItem("description", "Prototipo Orden Produccion WC", 0) ;
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
               STRUP0Y0( ) ;
            }
         }
      }

      protected void WS0Y2( )
      {
         START0Y2( ) ;
         EVT0Y2( ) ;
      }

      protected void EVT0Y2( )
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
                                 STRUP0Y0( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0Y0( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0Y0( ) ;
                              }
                              sEvt = cgiGet( sPrefix+"GRIDPAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0Y0( ) ;
                              }
                              nGXsfl_20_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0");
                              SubsflControlProps_202( ) ;
                              A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
                              A17tipOrdID = (short)(context.localUtil.CToN( cgiGet( edttipOrdID_Internalname), ",", "."));
                              A104tipOrdDsc = StringUtil.Upper( cgiGet( edttipOrdDsc_Internalname));
                              n104tipOrdDsc = false;
                              A9vendedorID = (short)(context.localUtil.CToN( cgiGet( edtvendedorID_Internalname), ",", "."));
                              A72vendedorDsc = cgiGet( edtvendedorDsc_Internalname);
                              n72vendedorDsc = false;
                              A106facturaNro = (int)(context.localUtil.CToN( cgiGet( edtfacturaNro_Internalname), ",", "."));
                              n106facturaNro = false;
                              A107representane = cgiGet( edtrepresentane_Internalname);
                              n107representane = false;
                              A108urlPdf = cgiGet( edturlPdf_Internalname);
                              n108urlPdf = false;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edturlPdf_Internalname, "URL", context.PathToRelativeUrl( A108urlPdf), !bGXsfl_20_Refreshing);
                              A8VehiculoID = (short)(context.localUtil.CToN( cgiGet( edtVehiculoID_Internalname), ",", "."));
                              A68VehiculoPlaca = cgiGet( edtVehiculoPlaca_Internalname);
                              n68VehiculoPlaca = false;
                              A69VehiculoChasis = cgiGet( edtVehiculoChasis_Internalname);
                              n69VehiculoChasis = false;
                              A109fchVenta = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtfchVenta_Internalname), 0));
                              n109fchVenta = false;
                              A110cantDias = (short)(context.localUtil.CToN( cgiGet( edtcantDias_Internalname), ",", "."));
                              n110cantDias = false;
                              A112documento = cgiGet( edtdocumento_Internalname);
                              n112documento = false;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtdocumento_Internalname, "URL", context.PathToRelativeUrl( A112documento), !bGXsfl_20_Refreshing);
                              A115OrdenEst = cgiGet( edtOrdenEst_Internalname);
                              n115OrdenEst = false;
                              A116OrdenUser = StringUtil.Upper( cgiGet( edtOrdenUser_Internalname));
                              n116OrdenUser = false;
                              A119OrdenFch = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtOrdenFch_Internalname), 0));
                              n119OrdenFch = false;
                              A5ClienteID = (short)(context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", "."));
                              A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
                              n57ClienteDsc = false;
                              A26OrdenMarcaID = (short)(context.localUtil.CToN( cgiGet( edtOrdenMarcaID_Internalname), ",", "."));
                              A117OrdenModeloID = (short)(context.localUtil.CToN( cgiGet( edtOrdenModeloID_Internalname), ",", "."));
                              A24OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( edtOrdenPeriodo_Internalname), ",", "."));
                              A25OrdenAnio = (short)(context.localUtil.CToN( cgiGet( edtOrdenAnio_Internalname), ",", "."));
                              A132OrdenEmpFac = (short)(context.localUtil.CToN( cgiGet( edtOrdenEmpFac_Internalname), ",", "."));
                              n132OrdenEmpFac = false;
                              A133OrdenProceso = StringUtil.Upper( cgiGet( edtOrdenProceso_Internalname));
                              n133OrdenProceso = false;
                              A152OrdenPdf = cgiGet( edtOrdenPdf_Internalname);
                              n152OrdenPdf = false;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenPdf_Internalname, "URL", context.PathToRelativeUrl( A152OrdenPdf), !bGXsfl_20_Refreshing);
                              A153OrdenActaPdf = cgiGet( edtOrdenActaPdf_Internalname);
                              n153OrdenActaPdf = false;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenActaPdf_Internalname, "URL", context.PathToRelativeUrl( A153OrdenActaPdf), !bGXsfl_20_Refreshing);
                              A161OrdenSubtotal = context.localUtil.CToN( cgiGet( edtOrdenSubtotal_Internalname), ",", ".");
                              n161OrdenSubtotal = false;
                              A162OrdenValInds = context.localUtil.CToN( cgiGet( edtOrdenValInds_Internalname), ",", ".");
                              n162OrdenValInds = false;
                              A163OrdenValEnrq = context.localUtil.CToN( cgiGet( edtOrdenValEnrq_Internalname), ",", ".");
                              n163OrdenValEnrq = false;
                              A164OrdenValMatPri = context.localUtil.CToN( cgiGet( edtOrdenValMatPri_Internalname), ",", ".");
                              A166OrdenValPint = context.localUtil.CToN( cgiGet( edtOrdenValPint_Internalname), ",", ".");
                              n166OrdenValPint = false;
                              A167OrdenValEstr = context.localUtil.CToN( cgiGet( edtOrdenValEstr_Internalname), ",", ".");
                              n167OrdenValEstr = false;
                              A168OrdenValOtrs = context.localUtil.CToN( cgiGet( edtOrdenValOtrs_Internalname), ",", ".");
                              n168OrdenValOtrs = false;
                              A169OrdenValManObr = context.localUtil.CToN( cgiGet( edtOrdenValManObr_Internalname), ",", ".");
                              A170OrdenTotGast = context.localUtil.CToN( cgiGet( edtOrdenTotGast_Internalname), ",", ".");
                              A171OrdenValRenta = context.localUtil.CToN( cgiGet( edtOrdenValRenta_Internalname), ",", ".");
                              A172OrdenfchEnt = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtOrdenfchEnt_Internalname), 0));
                              n172OrdenfchEnt = false;
                              A192OrdenPed = (int)(context.localUtil.CToN( cgiGet( edtOrdenPed_Internalname), ",", "."));
                              n192OrdenPed = false;
                              A195OrdenFacNomb = StringUtil.Upper( cgiGet( edtOrdenFacNomb_Internalname));
                              n195OrdenFacNomb = false;
                              A165OrdenValCal = context.localUtil.CToN( cgiGet( edtOrdenValCal_Internalname), ",", ".");
                              n165OrdenValCal = false;
                              A203ordenNroPed = (int)(context.localUtil.CToN( cgiGet( edtordenNroPed_Internalname), ",", "."));
                              n203ordenNroPed = false;
                              A210OrdenUltSec = (short)(context.localUtil.CToN( cgiGet( edtOrdenUltSec_Internalname), ",", "."));
                              n210OrdenUltSec = false;
                              A255OrdenObreSuma = context.localUtil.CToN( cgiGet( edtOrdenObreSuma_Internalname), ",", ".");
                              n255OrdenObreSuma = false;
                              A401OrdenNroDesp = (int)(context.localUtil.CToN( cgiGet( edtOrdenNroDesp_Internalname), ",", "."));
                              n401OrdenNroDesp = false;
                              AV12Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV12Update)) ? AV18Update_GXI : context.convertURL( context.PathToRelativeUrl( AV12Update))), !bGXsfl_20_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV12Update), true);
                              AV13Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV13Delete)) ? AV19Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV13Delete))), !bGXsfl_20_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV13Delete), true);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: Start */
                                          E120Y2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          E130Y2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
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
                                       STRUP0Y0( ) ;
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

      protected void WE0Y2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0Y2( ) ;
            }
         }
      }

      protected void PA0Y2( )
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

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_202( ) ;
         while ( nGXsfl_20_idx <= nRC_GXsfl_20 )
         {
            sendrow_202( ) ;
            nGXsfl_20_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_20_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_20_idx+1));
            sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0");
            SubsflControlProps_202( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV6EmpID ,
                                       short AV7protID ,
                                       String AV12Update ,
                                       String AV13Delete ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0Y2( ) ;
         /* End function gxgrGrid_refresh */
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
         RF0Y2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV17Pgmname = "PrototipoOrdenProduccionWC";
         context.Gx_err = 0;
      }

      protected void RF0Y2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 20;
         nGXsfl_20_idx = 1;
         sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0");
         SubsflControlProps_202( ) ;
         bGXsfl_20_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", sPrefix);
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "ViewGrid");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_202( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            /* Using cursor H000Y3 */
            pr_default.execute(0, new Object[] {AV6EmpID, AV7protID, GXPagingFrom2, GXPagingTo2});
            nGXsfl_20_idx = 1;
            sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0");
            SubsflControlProps_202( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A1EmpID = H000Y3_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A10protID = H000Y3_A10protID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
               A401OrdenNroDesp = H000Y3_A401OrdenNroDesp[0];
               n401OrdenNroDesp = H000Y3_n401OrdenNroDesp[0];
               A210OrdenUltSec = H000Y3_A210OrdenUltSec[0];
               n210OrdenUltSec = H000Y3_n210OrdenUltSec[0];
               A203ordenNroPed = H000Y3_A203ordenNroPed[0];
               n203ordenNroPed = H000Y3_n203ordenNroPed[0];
               A195OrdenFacNomb = H000Y3_A195OrdenFacNomb[0];
               n195OrdenFacNomb = H000Y3_n195OrdenFacNomb[0];
               A192OrdenPed = H000Y3_A192OrdenPed[0];
               n192OrdenPed = H000Y3_n192OrdenPed[0];
               A172OrdenfchEnt = H000Y3_A172OrdenfchEnt[0];
               n172OrdenfchEnt = H000Y3_n172OrdenfchEnt[0];
               A133OrdenProceso = H000Y3_A133OrdenProceso[0];
               n133OrdenProceso = H000Y3_n133OrdenProceso[0];
               A132OrdenEmpFac = H000Y3_A132OrdenEmpFac[0];
               n132OrdenEmpFac = H000Y3_n132OrdenEmpFac[0];
               A25OrdenAnio = H000Y3_A25OrdenAnio[0];
               A24OrdenPeriodo = H000Y3_A24OrdenPeriodo[0];
               A117OrdenModeloID = H000Y3_A117OrdenModeloID[0];
               A26OrdenMarcaID = H000Y3_A26OrdenMarcaID[0];
               A57ClienteDsc = H000Y3_A57ClienteDsc[0];
               n57ClienteDsc = H000Y3_n57ClienteDsc[0];
               A5ClienteID = H000Y3_A5ClienteID[0];
               A119OrdenFch = H000Y3_A119OrdenFch[0];
               n119OrdenFch = H000Y3_n119OrdenFch[0];
               A116OrdenUser = H000Y3_A116OrdenUser[0];
               n116OrdenUser = H000Y3_n116OrdenUser[0];
               A115OrdenEst = H000Y3_A115OrdenEst[0];
               n115OrdenEst = H000Y3_n115OrdenEst[0];
               A110cantDias = H000Y3_A110cantDias[0];
               n110cantDias = H000Y3_n110cantDias[0];
               A109fchVenta = H000Y3_A109fchVenta[0];
               n109fchVenta = H000Y3_n109fchVenta[0];
               A69VehiculoChasis = H000Y3_A69VehiculoChasis[0];
               n69VehiculoChasis = H000Y3_n69VehiculoChasis[0];
               A68VehiculoPlaca = H000Y3_A68VehiculoPlaca[0];
               n68VehiculoPlaca = H000Y3_n68VehiculoPlaca[0];
               A8VehiculoID = H000Y3_A8VehiculoID[0];
               A107representane = H000Y3_A107representane[0];
               n107representane = H000Y3_n107representane[0];
               A106facturaNro = H000Y3_A106facturaNro[0];
               n106facturaNro = H000Y3_n106facturaNro[0];
               A72vendedorDsc = H000Y3_A72vendedorDsc[0];
               n72vendedorDsc = H000Y3_n72vendedorDsc[0];
               A9vendedorID = H000Y3_A9vendedorID[0];
               A104tipOrdDsc = H000Y3_A104tipOrdDsc[0];
               n104tipOrdDsc = H000Y3_n104tipOrdDsc[0];
               A17tipOrdID = H000Y3_A17tipOrdID[0];
               A22OrdenID = H000Y3_A22OrdenID[0];
               A255OrdenObreSuma = H000Y3_A255OrdenObreSuma[0];
               n255OrdenObreSuma = H000Y3_n255OrdenObreSuma[0];
               A168OrdenValOtrs = H000Y3_A168OrdenValOtrs[0];
               n168OrdenValOtrs = H000Y3_n168OrdenValOtrs[0];
               A167OrdenValEstr = H000Y3_A167OrdenValEstr[0];
               n167OrdenValEstr = H000Y3_n167OrdenValEstr[0];
               A166OrdenValPint = H000Y3_A166OrdenValPint[0];
               n166OrdenValPint = H000Y3_n166OrdenValPint[0];
               A165OrdenValCal = H000Y3_A165OrdenValCal[0];
               n165OrdenValCal = H000Y3_n165OrdenValCal[0];
               A163OrdenValEnrq = H000Y3_A163OrdenValEnrq[0];
               n163OrdenValEnrq = H000Y3_n163OrdenValEnrq[0];
               A162OrdenValInds = H000Y3_A162OrdenValInds[0];
               n162OrdenValInds = H000Y3_n162OrdenValInds[0];
               A161OrdenSubtotal = H000Y3_A161OrdenSubtotal[0];
               n161OrdenSubtotal = H000Y3_n161OrdenSubtotal[0];
               A153OrdenActaPdf = H000Y3_A153OrdenActaPdf[0];
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenActaPdf_Internalname, "URL", context.PathToRelativeUrl( A153OrdenActaPdf), !bGXsfl_20_Refreshing);
               n153OrdenActaPdf = H000Y3_n153OrdenActaPdf[0];
               A152OrdenPdf = H000Y3_A152OrdenPdf[0];
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenPdf_Internalname, "URL", context.PathToRelativeUrl( A152OrdenPdf), !bGXsfl_20_Refreshing);
               n152OrdenPdf = H000Y3_n152OrdenPdf[0];
               A112documento = H000Y3_A112documento[0];
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtdocumento_Internalname, "URL", context.PathToRelativeUrl( A112documento), !bGXsfl_20_Refreshing);
               n112documento = H000Y3_n112documento[0];
               A108urlPdf = H000Y3_A108urlPdf[0];
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edturlPdf_Internalname, "URL", context.PathToRelativeUrl( A108urlPdf), !bGXsfl_20_Refreshing);
               n108urlPdf = H000Y3_n108urlPdf[0];
               A57ClienteDsc = H000Y3_A57ClienteDsc[0];
               n57ClienteDsc = H000Y3_n57ClienteDsc[0];
               A69VehiculoChasis = H000Y3_A69VehiculoChasis[0];
               n69VehiculoChasis = H000Y3_n69VehiculoChasis[0];
               A68VehiculoPlaca = H000Y3_A68VehiculoPlaca[0];
               n68VehiculoPlaca = H000Y3_n68VehiculoPlaca[0];
               A72vendedorDsc = H000Y3_A72vendedorDsc[0];
               n72vendedorDsc = H000Y3_n72vendedorDsc[0];
               A104tipOrdDsc = H000Y3_A104tipOrdDsc[0];
               n104tipOrdDsc = H000Y3_n104tipOrdDsc[0];
               A255OrdenObreSuma = H000Y3_A255OrdenObreSuma[0];
               n255OrdenObreSuma = H000Y3_n255OrdenObreSuma[0];
               A164OrdenValMatPri = NumberUtil.Round( (A162OrdenValInds+A163OrdenValEnrq+A165OrdenValCal), 2);
               A169OrdenValManObr = NumberUtil.Round( (A166OrdenValPint+A167OrdenValEstr+A168OrdenValOtrs), 2);
               A170OrdenTotGast = NumberUtil.Round( (A164OrdenValMatPri+A169OrdenValManObr), 2);
               A171OrdenValRenta = NumberUtil.Round( (A161OrdenSubtotal-A170OrdenTotGast), 2);
               E130Y2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 20;
            WB0Y0( ) ;
         }
         bGXsfl_20_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0Y2( )
      {
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         /* Using cursor H000Y5 */
         pr_default.execute(1, new Object[] {AV6EmpID, AV7protID});
         GRID_nRecordCount = H000Y5_AGRID_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID_nRecordCount) ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            return subGrid_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7protID, AV12Update, AV13Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7protID, AV12Update, AV13Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7protID, AV12Update, AV13Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-subGrid_Recordsperpage( ));
            }
            else
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7protID, AV12Update, AV13Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7protID, AV12Update, AV13Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0Y0( )
      {
         /* Before Start, stand alone formulas. */
         AV17Pgmname = "PrototipoOrdenProduccionWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E120Y2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A10protID = (short)(context.localUtil.CToN( cgiGet( edtprotID_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
            /* Read saved values. */
            nRC_GXsfl_20 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_20"), ",", "."));
            wcpOAV6EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV6EmpID"), ",", "."));
            wcpOAV7protID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7protID"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E120Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E120Y2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV17Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV12Update = context.GetImagePath( "984dbb7e-3105-4d21-aee3-84a29ade1d38", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV12Update)) ? AV18Update_GXI : context.convertURL( context.PathToRelativeUrl( AV12Update))), !bGXsfl_20_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV12Update), true);
         AV18Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "984dbb7e-3105-4d21-aee3-84a29ade1d38", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV12Update)) ? AV18Update_GXI : context.convertURL( context.PathToRelativeUrl( AV12Update))), !bGXsfl_20_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV12Update), true);
         edtavUpdate_Tooltiptext = "Modificar";
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext, !bGXsfl_20_Refreshing);
         AV13Delete = context.GetImagePath( "67c03cc7-261d-4b2f-aa3f-5825ef4786ff", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV13Delete)) ? AV19Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV13Delete))), !bGXsfl_20_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV13Delete), true);
         AV19Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "67c03cc7-261d-4b2f-aa3f-5825ef4786ff", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV13Delete)) ? AV19Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV13Delete))), !bGXsfl_20_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV13Delete), true);
         edtavDelete_Tooltiptext = "Eliminar";
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext, !bGXsfl_20_Refreshing);
         edtEmpID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtEmpID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Visible), 5, 0)), true);
         edtprotID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtprotID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprotID_Visible), 5, 0)), true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      private void E130Y2( )
      {
         /* Grid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 20;
         }
         sendrow_202( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_20_Refreshing )
         {
            context.DoAjaxLoad(20, GridRow);
         }
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new SdtTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV17Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "OrdenProduccion";
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "EmpID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6EmpID), 4, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "protID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7protID), 4, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV8Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "TransactionContext", "KBCalpesa22"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6EmpID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6EmpID), 4, 0)));
         AV7protID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7protID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7protID), 4, 0)));
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
         PA0Y2( ) ;
         WS0Y2( ) ;
         WE0Y2( ) ;
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
         sCtrlAV6EmpID = (String)((String)getParm(obj,0));
         sCtrlAV7protID = (String)((String)getParm(obj,1));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0Y2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "prototipoordenproduccionwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA0Y2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV6EmpID = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6EmpID), 4, 0)));
            AV7protID = Convert.ToInt16(getParm(obj,3));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7protID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7protID), 4, 0)));
         }
         wcpOAV6EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV6EmpID"), ",", "."));
         wcpOAV7protID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7protID"), ",", "."));
         if ( ! GetJustCreated( ) && ( ( AV6EmpID != wcpOAV6EmpID ) || ( AV7protID != wcpOAV7protID ) ) )
         {
            setjustcreated();
         }
         wcpOAV6EmpID = AV6EmpID;
         wcpOAV7protID = AV7protID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV6EmpID = cgiGet( sPrefix+"AV6EmpID_CTRL");
         if ( StringUtil.Len( sCtrlAV6EmpID) > 0 )
         {
            AV6EmpID = (short)(context.localUtil.CToN( cgiGet( sCtrlAV6EmpID), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6EmpID), 4, 0)));
         }
         else
         {
            AV6EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV6EmpID_PARM"), ",", "."));
         }
         sCtrlAV7protID = cgiGet( sPrefix+"AV7protID_CTRL");
         if ( StringUtil.Len( sCtrlAV7protID) > 0 )
         {
            AV7protID = (short)(context.localUtil.CToN( cgiGet( sCtrlAV7protID), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7protID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7protID), 4, 0)));
         }
         else
         {
            AV7protID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV7protID_PARM"), ",", "."));
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
         PA0Y2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0Y2( ) ;
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
         WS0Y2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV6EmpID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6EmpID), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV6EmpID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV6EmpID_CTRL", StringUtil.RTrim( sCtrlAV6EmpID));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7protID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7protID), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7protID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7protID_CTRL", StringUtil.RTrim( sCtrlAV7protID));
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
         WE0Y2( ) ;
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
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231141153447", true);
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
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("prototipoordenproduccionwc.js", "?20231141153447", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_202( )
      {
         edtOrdenID_Internalname = sPrefix+"ORDENID_"+sGXsfl_20_idx;
         edttipOrdID_Internalname = sPrefix+"TIPORDID_"+sGXsfl_20_idx;
         edttipOrdDsc_Internalname = sPrefix+"TIPORDDSC_"+sGXsfl_20_idx;
         edtvendedorID_Internalname = sPrefix+"VENDEDORID_"+sGXsfl_20_idx;
         edtvendedorDsc_Internalname = sPrefix+"VENDEDORDSC_"+sGXsfl_20_idx;
         edtfacturaNro_Internalname = sPrefix+"FACTURANRO_"+sGXsfl_20_idx;
         edtrepresentane_Internalname = sPrefix+"REPRESENTANE_"+sGXsfl_20_idx;
         edturlPdf_Internalname = sPrefix+"URLPDF_"+sGXsfl_20_idx;
         edtVehiculoID_Internalname = sPrefix+"VEHICULOID_"+sGXsfl_20_idx;
         edtVehiculoPlaca_Internalname = sPrefix+"VEHICULOPLACA_"+sGXsfl_20_idx;
         edtVehiculoChasis_Internalname = sPrefix+"VEHICULOCHASIS_"+sGXsfl_20_idx;
         edtfchVenta_Internalname = sPrefix+"FCHVENTA_"+sGXsfl_20_idx;
         edtcantDias_Internalname = sPrefix+"CANTDIAS_"+sGXsfl_20_idx;
         edtdocumento_Internalname = sPrefix+"DOCUMENTO_"+sGXsfl_20_idx;
         edtOrdenEst_Internalname = sPrefix+"ORDENEST_"+sGXsfl_20_idx;
         edtOrdenUser_Internalname = sPrefix+"ORDENUSER_"+sGXsfl_20_idx;
         edtOrdenFch_Internalname = sPrefix+"ORDENFCH_"+sGXsfl_20_idx;
         edtClienteID_Internalname = sPrefix+"CLIENTEID_"+sGXsfl_20_idx;
         edtClienteDsc_Internalname = sPrefix+"CLIENTEDSC_"+sGXsfl_20_idx;
         edtOrdenMarcaID_Internalname = sPrefix+"ORDENMARCAID_"+sGXsfl_20_idx;
         edtOrdenModeloID_Internalname = sPrefix+"ORDENMODELOID_"+sGXsfl_20_idx;
         edtOrdenPeriodo_Internalname = sPrefix+"ORDENPERIODO_"+sGXsfl_20_idx;
         edtOrdenAnio_Internalname = sPrefix+"ORDENANIO_"+sGXsfl_20_idx;
         edtOrdenEmpFac_Internalname = sPrefix+"ORDENEMPFAC_"+sGXsfl_20_idx;
         edtOrdenProceso_Internalname = sPrefix+"ORDENPROCESO_"+sGXsfl_20_idx;
         edtOrdenPdf_Internalname = sPrefix+"ORDENPDF_"+sGXsfl_20_idx;
         edtOrdenActaPdf_Internalname = sPrefix+"ORDENACTAPDF_"+sGXsfl_20_idx;
         edtOrdenSubtotal_Internalname = sPrefix+"ORDENSUBTOTAL_"+sGXsfl_20_idx;
         edtOrdenValInds_Internalname = sPrefix+"ORDENVALINDS_"+sGXsfl_20_idx;
         edtOrdenValEnrq_Internalname = sPrefix+"ORDENVALENRQ_"+sGXsfl_20_idx;
         edtOrdenValMatPri_Internalname = sPrefix+"ORDENVALMATPRI_"+sGXsfl_20_idx;
         edtOrdenValPint_Internalname = sPrefix+"ORDENVALPINT_"+sGXsfl_20_idx;
         edtOrdenValEstr_Internalname = sPrefix+"ORDENVALESTR_"+sGXsfl_20_idx;
         edtOrdenValOtrs_Internalname = sPrefix+"ORDENVALOTRS_"+sGXsfl_20_idx;
         edtOrdenValManObr_Internalname = sPrefix+"ORDENVALMANOBR_"+sGXsfl_20_idx;
         edtOrdenTotGast_Internalname = sPrefix+"ORDENTOTGAST_"+sGXsfl_20_idx;
         edtOrdenValRenta_Internalname = sPrefix+"ORDENVALRENTA_"+sGXsfl_20_idx;
         edtOrdenfchEnt_Internalname = sPrefix+"ORDENFCHENT_"+sGXsfl_20_idx;
         edtOrdenPed_Internalname = sPrefix+"ORDENPED_"+sGXsfl_20_idx;
         edtOrdenFacNomb_Internalname = sPrefix+"ORDENFACNOMB_"+sGXsfl_20_idx;
         edtOrdenValCal_Internalname = sPrefix+"ORDENVALCAL_"+sGXsfl_20_idx;
         edtordenNroPed_Internalname = sPrefix+"ORDENNROPED_"+sGXsfl_20_idx;
         edtOrdenUltSec_Internalname = sPrefix+"ORDENULTSEC_"+sGXsfl_20_idx;
         edtOrdenObreSuma_Internalname = sPrefix+"ORDENOBRESUMA_"+sGXsfl_20_idx;
         edtOrdenNroDesp_Internalname = sPrefix+"ORDENNRODESP_"+sGXsfl_20_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_20_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_20_idx;
      }

      protected void SubsflControlProps_fel_202( )
      {
         edtOrdenID_Internalname = sPrefix+"ORDENID_"+sGXsfl_20_fel_idx;
         edttipOrdID_Internalname = sPrefix+"TIPORDID_"+sGXsfl_20_fel_idx;
         edttipOrdDsc_Internalname = sPrefix+"TIPORDDSC_"+sGXsfl_20_fel_idx;
         edtvendedorID_Internalname = sPrefix+"VENDEDORID_"+sGXsfl_20_fel_idx;
         edtvendedorDsc_Internalname = sPrefix+"VENDEDORDSC_"+sGXsfl_20_fel_idx;
         edtfacturaNro_Internalname = sPrefix+"FACTURANRO_"+sGXsfl_20_fel_idx;
         edtrepresentane_Internalname = sPrefix+"REPRESENTANE_"+sGXsfl_20_fel_idx;
         edturlPdf_Internalname = sPrefix+"URLPDF_"+sGXsfl_20_fel_idx;
         edtVehiculoID_Internalname = sPrefix+"VEHICULOID_"+sGXsfl_20_fel_idx;
         edtVehiculoPlaca_Internalname = sPrefix+"VEHICULOPLACA_"+sGXsfl_20_fel_idx;
         edtVehiculoChasis_Internalname = sPrefix+"VEHICULOCHASIS_"+sGXsfl_20_fel_idx;
         edtfchVenta_Internalname = sPrefix+"FCHVENTA_"+sGXsfl_20_fel_idx;
         edtcantDias_Internalname = sPrefix+"CANTDIAS_"+sGXsfl_20_fel_idx;
         edtdocumento_Internalname = sPrefix+"DOCUMENTO_"+sGXsfl_20_fel_idx;
         edtOrdenEst_Internalname = sPrefix+"ORDENEST_"+sGXsfl_20_fel_idx;
         edtOrdenUser_Internalname = sPrefix+"ORDENUSER_"+sGXsfl_20_fel_idx;
         edtOrdenFch_Internalname = sPrefix+"ORDENFCH_"+sGXsfl_20_fel_idx;
         edtClienteID_Internalname = sPrefix+"CLIENTEID_"+sGXsfl_20_fel_idx;
         edtClienteDsc_Internalname = sPrefix+"CLIENTEDSC_"+sGXsfl_20_fel_idx;
         edtOrdenMarcaID_Internalname = sPrefix+"ORDENMARCAID_"+sGXsfl_20_fel_idx;
         edtOrdenModeloID_Internalname = sPrefix+"ORDENMODELOID_"+sGXsfl_20_fel_idx;
         edtOrdenPeriodo_Internalname = sPrefix+"ORDENPERIODO_"+sGXsfl_20_fel_idx;
         edtOrdenAnio_Internalname = sPrefix+"ORDENANIO_"+sGXsfl_20_fel_idx;
         edtOrdenEmpFac_Internalname = sPrefix+"ORDENEMPFAC_"+sGXsfl_20_fel_idx;
         edtOrdenProceso_Internalname = sPrefix+"ORDENPROCESO_"+sGXsfl_20_fel_idx;
         edtOrdenPdf_Internalname = sPrefix+"ORDENPDF_"+sGXsfl_20_fel_idx;
         edtOrdenActaPdf_Internalname = sPrefix+"ORDENACTAPDF_"+sGXsfl_20_fel_idx;
         edtOrdenSubtotal_Internalname = sPrefix+"ORDENSUBTOTAL_"+sGXsfl_20_fel_idx;
         edtOrdenValInds_Internalname = sPrefix+"ORDENVALINDS_"+sGXsfl_20_fel_idx;
         edtOrdenValEnrq_Internalname = sPrefix+"ORDENVALENRQ_"+sGXsfl_20_fel_idx;
         edtOrdenValMatPri_Internalname = sPrefix+"ORDENVALMATPRI_"+sGXsfl_20_fel_idx;
         edtOrdenValPint_Internalname = sPrefix+"ORDENVALPINT_"+sGXsfl_20_fel_idx;
         edtOrdenValEstr_Internalname = sPrefix+"ORDENVALESTR_"+sGXsfl_20_fel_idx;
         edtOrdenValOtrs_Internalname = sPrefix+"ORDENVALOTRS_"+sGXsfl_20_fel_idx;
         edtOrdenValManObr_Internalname = sPrefix+"ORDENVALMANOBR_"+sGXsfl_20_fel_idx;
         edtOrdenTotGast_Internalname = sPrefix+"ORDENTOTGAST_"+sGXsfl_20_fel_idx;
         edtOrdenValRenta_Internalname = sPrefix+"ORDENVALRENTA_"+sGXsfl_20_fel_idx;
         edtOrdenfchEnt_Internalname = sPrefix+"ORDENFCHENT_"+sGXsfl_20_fel_idx;
         edtOrdenPed_Internalname = sPrefix+"ORDENPED_"+sGXsfl_20_fel_idx;
         edtOrdenFacNomb_Internalname = sPrefix+"ORDENFACNOMB_"+sGXsfl_20_fel_idx;
         edtOrdenValCal_Internalname = sPrefix+"ORDENVALCAL_"+sGXsfl_20_fel_idx;
         edtordenNroPed_Internalname = sPrefix+"ORDENNROPED_"+sGXsfl_20_fel_idx;
         edtOrdenUltSec_Internalname = sPrefix+"ORDENULTSEC_"+sGXsfl_20_fel_idx;
         edtOrdenObreSuma_Internalname = sPrefix+"ORDENOBRESUMA_"+sGXsfl_20_fel_idx;
         edtOrdenNroDesp_Internalname = sPrefix+"ORDENNRODESP_"+sGXsfl_20_fel_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_20_fel_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_20_fel_idx;
      }

      protected void sendrow_202( )
      {
         SubsflControlProps_202( ) ;
         WB0Y0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_20_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer);
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0;
               subGrid_Backcolor = subGrid_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform";
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
               subGrid_Backcolor = (int)(0x0);
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( ((int)(((nGXsfl_20_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd";
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even";
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"ViewGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_20_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipOrdID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17tipOrdID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A17tipOrdID), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipOrdID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttipOrdDsc_Internalname,StringUtil.RTrim( A104tipOrdDsc),StringUtil.RTrim( context.localUtil.Format( A104tipOrdDsc, "@!")),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttipOrdDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtvendedorID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A9vendedorID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A9vendedorID), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtvendedorID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtvendedorDsc_Internalname,StringUtil.RTrim( A72vendedorDsc),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtvendedorDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtfacturaNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A106facturaNro), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A106facturaNro), "ZZZZZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtfacturaNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtrepresentane_Internalname,StringUtil.RTrim( A107representane),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtrepresentane_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            ClassString = "Image";
            StyleString = "";
            edturlPdf_Filetype = "tmp";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edturlPdf_Internalname, "Filetype", edturlPdf_Filetype, !bGXsfl_20_Refreshing);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A108urlPdf)) )
            {
               gxblobfileaux.Source = A108urlPdf;
               if ( ! gxblobfileaux.HasExtension() || ( StringUtil.StrCmp(edturlPdf_Filetype, "tmp") != 0 ) )
               {
                  gxblobfileaux.SetExtension(StringUtil.Trim( edturlPdf_Filetype));
               }
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A108urlPdf = gxblobfileaux.GetURI();
                  n108urlPdf = false;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edturlPdf_Internalname, "URL", context.PathToRelativeUrl( A108urlPdf), !bGXsfl_20_Refreshing);
                  edturlPdf_Filetype = gxblobfileaux.GetExtension();
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edturlPdf_Internalname, "Filetype", edturlPdf_Filetype, !bGXsfl_20_Refreshing);
               }
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edturlPdf_Internalname, "URL", context.PathToRelativeUrl( A108urlPdf), !bGXsfl_20_Refreshing);
            }
            GridRow.AddColumnProperties("blob", 2, isAjaxCallMode( ), new Object[] {(String)edturlPdf_Internalname,StringUtil.RTrim( A108urlPdf),context.PathToRelativeUrl( A108urlPdf),(String.IsNullOrEmpty(StringUtil.RTrim( edturlPdf_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edturlPdf_Filetype)) ? A108urlPdf : edturlPdf_Filetype)) : edturlPdf_Contenttype),(bool)false,(String)"",(String)edturlPdf_Parameters,(short)0,(short)0,(short)-1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)60,(String)"px",(short)0,(short)0,(short)0,(String)edturlPdf_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",(String)""+"",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVehiculoID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VehiculoID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A8VehiculoID), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVehiculoID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVehiculoPlaca_Internalname,(String)A68VehiculoPlaca,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVehiculoPlaca_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVehiculoChasis_Internalname,(String)A69VehiculoChasis,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVehiculoChasis_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtfchVenta_Internalname,context.localUtil.Format(A109fchVenta, "99/99/9999"),context.localUtil.Format( A109fchVenta, "99/99/9999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtfchVenta_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcantDias_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A110cantDias), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A110cantDias), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcantDias_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            ClassString = "Image";
            StyleString = "";
            edtdocumento_Filetype = "tmp";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtdocumento_Internalname, "Filetype", edtdocumento_Filetype, !bGXsfl_20_Refreshing);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A112documento)) )
            {
               gxblobfileaux.Source = A112documento;
               if ( ! gxblobfileaux.HasExtension() || ( StringUtil.StrCmp(edtdocumento_Filetype, "tmp") != 0 ) )
               {
                  gxblobfileaux.SetExtension(StringUtil.Trim( edtdocumento_Filetype));
               }
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A112documento = gxblobfileaux.GetURI();
                  n112documento = false;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtdocumento_Internalname, "URL", context.PathToRelativeUrl( A112documento), !bGXsfl_20_Refreshing);
                  edtdocumento_Filetype = gxblobfileaux.GetExtension();
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtdocumento_Internalname, "Filetype", edtdocumento_Filetype, !bGXsfl_20_Refreshing);
               }
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtdocumento_Internalname, "URL", context.PathToRelativeUrl( A112documento), !bGXsfl_20_Refreshing);
            }
            GridRow.AddColumnProperties("blob", 2, isAjaxCallMode( ), new Object[] {(String)edtdocumento_Internalname,StringUtil.RTrim( A112documento),context.PathToRelativeUrl( A112documento),(String.IsNullOrEmpty(StringUtil.RTrim( edtdocumento_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtdocumento_Filetype)) ? A112documento : edtdocumento_Filetype)) : edtdocumento_Contenttype),(bool)false,(String)"",(String)edtdocumento_Parameters,(short)0,(short)0,(short)-1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)60,(String)"px",(short)0,(short)0,(short)0,(String)edtdocumento_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",(String)""+"",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenEst_Internalname,StringUtil.RTrim( A115OrdenEst),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenEst_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenUser_Internalname,StringUtil.RTrim( A116OrdenUser),StringUtil.RTrim( context.localUtil.Format( A116OrdenUser, "@!")),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenUser_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenFch_Internalname,context.localUtil.Format(A119OrdenFch, "99/99/9999"),context.localUtil.Format( A119OrdenFch, "99/99/9999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenFch_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteDsc_Internalname,StringUtil.RTrim( A57ClienteDsc),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenMarcaID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A26OrdenMarcaID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A26OrdenMarcaID), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenMarcaID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenModeloID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A117OrdenModeloID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A117OrdenModeloID), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenModeloID_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenPeriodo_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A24OrdenPeriodo), 2, 0, ",", "")),context.localUtil.Format( (decimal)(A24OrdenPeriodo), "Z9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenPeriodo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A25OrdenAnio), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenAnio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenEmpFac_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A132OrdenEmpFac), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A132OrdenEmpFac), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenEmpFac_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenProceso_Internalname,(String)A133OrdenProceso,StringUtil.RTrim( context.localUtil.Format( A133OrdenProceso, "@!")),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenProceso_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            ClassString = "Image";
            StyleString = "";
            edtOrdenPdf_Filetype = ".pdf";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenPdf_Internalname, "Filetype", edtOrdenPdf_Filetype, !bGXsfl_20_Refreshing);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A152OrdenPdf)) )
            {
               gxblobfileaux.Source = A152OrdenPdf;
               if ( ! gxblobfileaux.HasExtension() || ( StringUtil.StrCmp(edtOrdenPdf_Filetype, "tmp") != 0 ) )
               {
                  gxblobfileaux.SetExtension(StringUtil.Trim( edtOrdenPdf_Filetype));
               }
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A152OrdenPdf = gxblobfileaux.GetURI();
                  n152OrdenPdf = false;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenPdf_Internalname, "URL", context.PathToRelativeUrl( A152OrdenPdf), !bGXsfl_20_Refreshing);
                  edtOrdenPdf_Filetype = gxblobfileaux.GetExtension();
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenPdf_Internalname, "Filetype", edtOrdenPdf_Filetype, !bGXsfl_20_Refreshing);
               }
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenPdf_Internalname, "URL", context.PathToRelativeUrl( A152OrdenPdf), !bGXsfl_20_Refreshing);
            }
            GridRow.AddColumnProperties("blob", 2, isAjaxCallMode( ), new Object[] {(String)edtOrdenPdf_Internalname,StringUtil.RTrim( A152OrdenPdf),context.PathToRelativeUrl( A152OrdenPdf),(String.IsNullOrEmpty(StringUtil.RTrim( edtOrdenPdf_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtOrdenPdf_Filetype)) ? A152OrdenPdf : edtOrdenPdf_Filetype)) : edtOrdenPdf_Contenttype),(bool)false,(String)"",(String)edtOrdenPdf_Parameters,(short)0,(short)0,(short)-1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)60,(String)"px",(short)0,(short)0,(short)0,(String)edtOrdenPdf_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",(String)""+"",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            ClassString = "Image";
            StyleString = "";
            edtOrdenActaPdf_Filetype = ".pdf";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenActaPdf_Internalname, "Filetype", edtOrdenActaPdf_Filetype, !bGXsfl_20_Refreshing);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A153OrdenActaPdf)) )
            {
               gxblobfileaux.Source = A153OrdenActaPdf;
               if ( ! gxblobfileaux.HasExtension() || ( StringUtil.StrCmp(edtOrdenActaPdf_Filetype, "tmp") != 0 ) )
               {
                  gxblobfileaux.SetExtension(StringUtil.Trim( edtOrdenActaPdf_Filetype));
               }
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A153OrdenActaPdf = gxblobfileaux.GetURI();
                  n153OrdenActaPdf = false;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenActaPdf_Internalname, "URL", context.PathToRelativeUrl( A153OrdenActaPdf), !bGXsfl_20_Refreshing);
                  edtOrdenActaPdf_Filetype = gxblobfileaux.GetExtension();
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenActaPdf_Internalname, "Filetype", edtOrdenActaPdf_Filetype, !bGXsfl_20_Refreshing);
               }
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtOrdenActaPdf_Internalname, "URL", context.PathToRelativeUrl( A153OrdenActaPdf), !bGXsfl_20_Refreshing);
            }
            GridRow.AddColumnProperties("blob", 2, isAjaxCallMode( ), new Object[] {(String)edtOrdenActaPdf_Internalname,StringUtil.RTrim( A153OrdenActaPdf),context.PathToRelativeUrl( A153OrdenActaPdf),(String.IsNullOrEmpty(StringUtil.RTrim( edtOrdenActaPdf_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtOrdenActaPdf_Filetype)) ? A153OrdenActaPdf : edtOrdenActaPdf_Filetype)) : edtOrdenActaPdf_Contenttype),(bool)false,(String)"",(String)edtOrdenActaPdf_Parameters,(short)0,(short)0,(short)-1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)60,(String)"px",(short)0,(short)0,(short)0,(String)edtOrdenActaPdf_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",(String)""+"",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenSubtotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A161OrdenSubtotal, 10, 3, ",", "")),context.localUtil.Format( A161OrdenSubtotal, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenSubtotal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenValInds_Internalname,StringUtil.LTrim( StringUtil.NToC( A162OrdenValInds, 10, 3, ",", "")),context.localUtil.Format( A162OrdenValInds, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenValInds_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenValEnrq_Internalname,StringUtil.LTrim( StringUtil.NToC( A163OrdenValEnrq, 10, 3, ",", "")),context.localUtil.Format( A163OrdenValEnrq, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenValEnrq_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenValMatPri_Internalname,StringUtil.LTrim( StringUtil.NToC( A164OrdenValMatPri, 10, 3, ",", "")),context.localUtil.Format( A164OrdenValMatPri, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenValMatPri_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenValPint_Internalname,StringUtil.LTrim( StringUtil.NToC( A166OrdenValPint, 10, 3, ",", "")),context.localUtil.Format( A166OrdenValPint, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenValPint_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenValEstr_Internalname,StringUtil.LTrim( StringUtil.NToC( A167OrdenValEstr, 10, 3, ",", "")),context.localUtil.Format( A167OrdenValEstr, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenValEstr_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenValOtrs_Internalname,StringUtil.LTrim( StringUtil.NToC( A168OrdenValOtrs, 10, 3, ",", "")),context.localUtil.Format( A168OrdenValOtrs, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenValOtrs_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenValManObr_Internalname,StringUtil.LTrim( StringUtil.NToC( A169OrdenValManObr, 10, 3, ",", "")),context.localUtil.Format( A169OrdenValManObr, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenValManObr_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenTotGast_Internalname,StringUtil.LTrim( StringUtil.NToC( A170OrdenTotGast, 10, 3, ",", "")),context.localUtil.Format( A170OrdenTotGast, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenTotGast_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenValRenta_Internalname,StringUtil.LTrim( StringUtil.NToC( A171OrdenValRenta, 10, 3, ",", "")),context.localUtil.Format( A171OrdenValRenta, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenValRenta_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenfchEnt_Internalname,context.localUtil.Format(A172OrdenfchEnt, "99/99/9999"),context.localUtil.Format( A172OrdenfchEnt, "99/99/9999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenfchEnt_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenPed_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A192OrdenPed), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A192OrdenPed), "ZZZZZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenPed_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenFacNomb_Internalname,StringUtil.RTrim( A195OrdenFacNomb),StringUtil.RTrim( context.localUtil.Format( A195OrdenFacNomb, "@!")),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenFacNomb_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenValCal_Internalname,StringUtil.LTrim( StringUtil.NToC( A165OrdenValCal, 10, 3, ",", "")),context.localUtil.Format( A165OrdenValCal, "ZZZZZ9.999"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenValCal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtordenNroPed_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A203ordenNroPed), 8, 0, ",", "")),context.localUtil.Format( (decimal)(A203ordenNroPed), "ZZZZZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtordenNroPed_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenUltSec_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A210OrdenUltSec), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A210OrdenUltSec), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenUltSec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenObreSuma_Internalname,StringUtil.LTrim( StringUtil.NToC( A255OrdenObreSuma, 10, 2, ",", "")),context.localUtil.Format( A255OrdenObreSuma, "ZZZZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenObreSuma_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenNroDesp_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A401OrdenNroDesp), 6, 0, ",", "")),context.localUtil.Format( (decimal)(A401OrdenNroDesp), "ZZZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenNroDesp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV12Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV12Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV18Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV12Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV12Update)) ? AV18Update_GXI : context.PathToRelativeUrl( AV12Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV12Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            AV13Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV13Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV19Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV13Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV13Delete)) ? AV19Delete_GXI : context.PathToRelativeUrl( AV13Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV13Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes0Y2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_20_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_20_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_20_idx+1));
            sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0");
            SubsflControlProps_202( ) ;
         }
         /* End function sendrow_202 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = sPrefix+"BTNINSERT";
         divTabletop_Internalname = sPrefix+"TABLETOP";
         edtOrdenID_Internalname = sPrefix+"ORDENID";
         edttipOrdID_Internalname = sPrefix+"TIPORDID";
         edttipOrdDsc_Internalname = sPrefix+"TIPORDDSC";
         edtvendedorID_Internalname = sPrefix+"VENDEDORID";
         edtvendedorDsc_Internalname = sPrefix+"VENDEDORDSC";
         edtfacturaNro_Internalname = sPrefix+"FACTURANRO";
         edtrepresentane_Internalname = sPrefix+"REPRESENTANE";
         edturlPdf_Internalname = sPrefix+"URLPDF";
         edtVehiculoID_Internalname = sPrefix+"VEHICULOID";
         edtVehiculoPlaca_Internalname = sPrefix+"VEHICULOPLACA";
         edtVehiculoChasis_Internalname = sPrefix+"VEHICULOCHASIS";
         edtfchVenta_Internalname = sPrefix+"FCHVENTA";
         edtcantDias_Internalname = sPrefix+"CANTDIAS";
         edtdocumento_Internalname = sPrefix+"DOCUMENTO";
         edtOrdenEst_Internalname = sPrefix+"ORDENEST";
         edtOrdenUser_Internalname = sPrefix+"ORDENUSER";
         edtOrdenFch_Internalname = sPrefix+"ORDENFCH";
         edtClienteID_Internalname = sPrefix+"CLIENTEID";
         edtClienteDsc_Internalname = sPrefix+"CLIENTEDSC";
         edtOrdenMarcaID_Internalname = sPrefix+"ORDENMARCAID";
         edtOrdenModeloID_Internalname = sPrefix+"ORDENMODELOID";
         edtOrdenPeriodo_Internalname = sPrefix+"ORDENPERIODO";
         edtOrdenAnio_Internalname = sPrefix+"ORDENANIO";
         edtOrdenEmpFac_Internalname = sPrefix+"ORDENEMPFAC";
         edtOrdenProceso_Internalname = sPrefix+"ORDENPROCESO";
         edtOrdenPdf_Internalname = sPrefix+"ORDENPDF";
         edtOrdenActaPdf_Internalname = sPrefix+"ORDENACTAPDF";
         edtOrdenSubtotal_Internalname = sPrefix+"ORDENSUBTOTAL";
         edtOrdenValInds_Internalname = sPrefix+"ORDENVALINDS";
         edtOrdenValEnrq_Internalname = sPrefix+"ORDENVALENRQ";
         edtOrdenValMatPri_Internalname = sPrefix+"ORDENVALMATPRI";
         edtOrdenValPint_Internalname = sPrefix+"ORDENVALPINT";
         edtOrdenValEstr_Internalname = sPrefix+"ORDENVALESTR";
         edtOrdenValOtrs_Internalname = sPrefix+"ORDENVALOTRS";
         edtOrdenValManObr_Internalname = sPrefix+"ORDENVALMANOBR";
         edtOrdenTotGast_Internalname = sPrefix+"ORDENTOTGAST";
         edtOrdenValRenta_Internalname = sPrefix+"ORDENVALRENTA";
         edtOrdenfchEnt_Internalname = sPrefix+"ORDENFCHENT";
         edtOrdenPed_Internalname = sPrefix+"ORDENPED";
         edtOrdenFacNomb_Internalname = sPrefix+"ORDENFACNOMB";
         edtOrdenValCal_Internalname = sPrefix+"ORDENVALCAL";
         edtordenNroPed_Internalname = sPrefix+"ORDENNROPED";
         edtOrdenUltSec_Internalname = sPrefix+"ORDENULTSEC";
         edtOrdenObreSuma_Internalname = sPrefix+"ORDENOBRESUMA";
         edtOrdenNroDesp_Internalname = sPrefix+"ORDENNRODESP";
         edtavUpdate_Internalname = sPrefix+"vUPDATE";
         edtavDelete_Internalname = sPrefix+"vDELETE";
         divGridtable_Internalname = sPrefix+"GRIDTABLE";
         divGridcell_Internalname = sPrefix+"GRIDCELL";
         edtEmpID_Internalname = sPrefix+"EMPID";
         edtprotID_Internalname = sPrefix+"PROTID";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
         subGrid_Internalname = sPrefix+"GRID";
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
         edtOrdenNroDesp_Jsonclick = "";
         edtOrdenObreSuma_Jsonclick = "";
         edtOrdenUltSec_Jsonclick = "";
         edtordenNroPed_Jsonclick = "";
         edtOrdenValCal_Jsonclick = "";
         edtOrdenFacNomb_Jsonclick = "";
         edtOrdenPed_Jsonclick = "";
         edtOrdenfchEnt_Jsonclick = "";
         edtOrdenValRenta_Jsonclick = "";
         edtOrdenTotGast_Jsonclick = "";
         edtOrdenValManObr_Jsonclick = "";
         edtOrdenValOtrs_Jsonclick = "";
         edtOrdenValEstr_Jsonclick = "";
         edtOrdenValPint_Jsonclick = "";
         edtOrdenValMatPri_Jsonclick = "";
         edtOrdenValEnrq_Jsonclick = "";
         edtOrdenValInds_Jsonclick = "";
         edtOrdenSubtotal_Jsonclick = "";
         edtOrdenActaPdf_Jsonclick = "";
         edtOrdenActaPdf_Parameters = "";
         edtOrdenActaPdf_Contenttype = "";
         edtOrdenActaPdf_Filetype = "";
         edtOrdenPdf_Jsonclick = "";
         edtOrdenPdf_Parameters = "";
         edtOrdenPdf_Contenttype = "";
         edtOrdenPdf_Filetype = "";
         edtOrdenProceso_Jsonclick = "";
         edtOrdenEmpFac_Jsonclick = "";
         edtOrdenAnio_Jsonclick = "";
         edtOrdenPeriodo_Jsonclick = "";
         edtOrdenModeloID_Jsonclick = "";
         edtOrdenMarcaID_Jsonclick = "";
         edtClienteDsc_Jsonclick = "";
         edtClienteID_Jsonclick = "";
         edtOrdenFch_Jsonclick = "";
         edtOrdenUser_Jsonclick = "";
         edtOrdenEst_Jsonclick = "";
         edtdocumento_Jsonclick = "";
         edtdocumento_Parameters = "";
         edtdocumento_Contenttype = "";
         edtdocumento_Filetype = "";
         edtcantDias_Jsonclick = "";
         edtfchVenta_Jsonclick = "";
         edtVehiculoChasis_Jsonclick = "";
         edtVehiculoPlaca_Jsonclick = "";
         edtVehiculoID_Jsonclick = "";
         edturlPdf_Jsonclick = "";
         edturlPdf_Parameters = "";
         edturlPdf_Contenttype = "";
         edturlPdf_Filetype = "";
         edtrepresentane_Jsonclick = "";
         edtfacturaNro_Jsonclick = "";
         edtvendedorDsc_Jsonclick = "";
         edtvendedorID_Jsonclick = "";
         edttipOrdDsc_Jsonclick = "";
         edttipOrdID_Jsonclick = "";
         edtOrdenID_Jsonclick = "";
         edtprotID_Jsonclick = "";
         edtprotID_Enabled = 0;
         edtprotID_Visible = 1;
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 0;
         edtEmpID_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         subGrid_Header = "";
         subGrid_Class = "ViewGrid";
         subGrid_Backcolorstyle = 0;
         subGrid_Rows = 0;
         edtavDelete_Tooltiptext = "Eliminar";
         edtavUpdate_Tooltiptext = "Modificar";
         context.GX_msglist.DisplayMode = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV7protID',fld:'vPROTID',pic:'ZZZ9'},{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV13Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'sPrefix'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRID.LOAD","{handler:'E130Y2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[]}");
         setEventMetadata("'DOINSERT'","{handler:'E110Y1',iparms:[]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV7protID',fld:'vPROTID',pic:'ZZZ9'},{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV13Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'sPrefix'}]");
         setEventMetadata("GRID_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV7protID',fld:'vPROTID',pic:'ZZZ9'},{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV13Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'sPrefix'}]");
         setEventMetadata("GRID_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV7protID',fld:'vPROTID',pic:'ZZZ9'},{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV13Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'sPrefix'}]");
         setEventMetadata("GRID_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV7protID',fld:'vPROTID',pic:'ZZZ9'},{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV13Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'sPrefix'}]");
         setEventMetadata("GRID_LASTPAGE",",oparms:[]}");
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
         AV12Update = "";
         AV13Delete = "";
         GXKey = "";
         AV17Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A104tipOrdDsc = "";
         A72vendedorDsc = "";
         A107representane = "";
         A108urlPdf = "";
         A68VehiculoPlaca = "";
         A69VehiculoChasis = "";
         A109fchVenta = DateTime.MinValue;
         A112documento = "";
         A115OrdenEst = "";
         A116OrdenUser = "";
         A119OrdenFch = DateTime.MinValue;
         A57ClienteDsc = "";
         A133OrdenProceso = "";
         A152OrdenPdf = "";
         A153OrdenActaPdf = "";
         A172OrdenfchEnt = DateTime.MinValue;
         A195OrdenFacNomb = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18Update_GXI = "";
         AV19Delete_GXI = "";
         scmdbuf = "";
         H000Y3_A1EmpID = new short[1] ;
         H000Y3_A10protID = new short[1] ;
         H000Y3_A401OrdenNroDesp = new int[1] ;
         H000Y3_n401OrdenNroDesp = new bool[] {false} ;
         H000Y3_A210OrdenUltSec = new short[1] ;
         H000Y3_n210OrdenUltSec = new bool[] {false} ;
         H000Y3_A203ordenNroPed = new int[1] ;
         H000Y3_n203ordenNroPed = new bool[] {false} ;
         H000Y3_A195OrdenFacNomb = new String[] {""} ;
         H000Y3_n195OrdenFacNomb = new bool[] {false} ;
         H000Y3_A192OrdenPed = new int[1] ;
         H000Y3_n192OrdenPed = new bool[] {false} ;
         H000Y3_A172OrdenfchEnt = new DateTime[] {DateTime.MinValue} ;
         H000Y3_n172OrdenfchEnt = new bool[] {false} ;
         H000Y3_A133OrdenProceso = new String[] {""} ;
         H000Y3_n133OrdenProceso = new bool[] {false} ;
         H000Y3_A132OrdenEmpFac = new short[1] ;
         H000Y3_n132OrdenEmpFac = new bool[] {false} ;
         H000Y3_A25OrdenAnio = new short[1] ;
         H000Y3_A24OrdenPeriodo = new short[1] ;
         H000Y3_A117OrdenModeloID = new short[1] ;
         H000Y3_A26OrdenMarcaID = new short[1] ;
         H000Y3_A57ClienteDsc = new String[] {""} ;
         H000Y3_n57ClienteDsc = new bool[] {false} ;
         H000Y3_A5ClienteID = new short[1] ;
         H000Y3_A119OrdenFch = new DateTime[] {DateTime.MinValue} ;
         H000Y3_n119OrdenFch = new bool[] {false} ;
         H000Y3_A116OrdenUser = new String[] {""} ;
         H000Y3_n116OrdenUser = new bool[] {false} ;
         H000Y3_A115OrdenEst = new String[] {""} ;
         H000Y3_n115OrdenEst = new bool[] {false} ;
         H000Y3_A110cantDias = new short[1] ;
         H000Y3_n110cantDias = new bool[] {false} ;
         H000Y3_A109fchVenta = new DateTime[] {DateTime.MinValue} ;
         H000Y3_n109fchVenta = new bool[] {false} ;
         H000Y3_A69VehiculoChasis = new String[] {""} ;
         H000Y3_n69VehiculoChasis = new bool[] {false} ;
         H000Y3_A68VehiculoPlaca = new String[] {""} ;
         H000Y3_n68VehiculoPlaca = new bool[] {false} ;
         H000Y3_A8VehiculoID = new short[1] ;
         H000Y3_A107representane = new String[] {""} ;
         H000Y3_n107representane = new bool[] {false} ;
         H000Y3_A106facturaNro = new int[1] ;
         H000Y3_n106facturaNro = new bool[] {false} ;
         H000Y3_A72vendedorDsc = new String[] {""} ;
         H000Y3_n72vendedorDsc = new bool[] {false} ;
         H000Y3_A9vendedorID = new short[1] ;
         H000Y3_A104tipOrdDsc = new String[] {""} ;
         H000Y3_n104tipOrdDsc = new bool[] {false} ;
         H000Y3_A17tipOrdID = new short[1] ;
         H000Y3_A22OrdenID = new short[1] ;
         H000Y3_A255OrdenObreSuma = new decimal[1] ;
         H000Y3_n255OrdenObreSuma = new bool[] {false} ;
         H000Y3_A168OrdenValOtrs = new decimal[1] ;
         H000Y3_n168OrdenValOtrs = new bool[] {false} ;
         H000Y3_A167OrdenValEstr = new decimal[1] ;
         H000Y3_n167OrdenValEstr = new bool[] {false} ;
         H000Y3_A166OrdenValPint = new decimal[1] ;
         H000Y3_n166OrdenValPint = new bool[] {false} ;
         H000Y3_A165OrdenValCal = new decimal[1] ;
         H000Y3_n165OrdenValCal = new bool[] {false} ;
         H000Y3_A163OrdenValEnrq = new decimal[1] ;
         H000Y3_n163OrdenValEnrq = new bool[] {false} ;
         H000Y3_A162OrdenValInds = new decimal[1] ;
         H000Y3_n162OrdenValInds = new bool[] {false} ;
         H000Y3_A161OrdenSubtotal = new decimal[1] ;
         H000Y3_n161OrdenSubtotal = new bool[] {false} ;
         H000Y3_A153OrdenActaPdf = new String[] {""} ;
         H000Y3_n153OrdenActaPdf = new bool[] {false} ;
         H000Y3_A152OrdenPdf = new String[] {""} ;
         H000Y3_n152OrdenPdf = new bool[] {false} ;
         H000Y3_A112documento = new String[] {""} ;
         H000Y3_n112documento = new bool[] {false} ;
         H000Y3_A108urlPdf = new String[] {""} ;
         H000Y3_n108urlPdf = new bool[] {false} ;
         H000Y5_AGRID_nRecordCount = new long[1] ;
         GridRow = new GXWebRow();
         AV10TrnContext = new SdtTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV6EmpID = "";
         sCtrlAV7protID = "";
         ROClassString = "";
         gxblobfileaux = new GxFile(context.GetPhysicalPath());
         sImgUrl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prototipoordenproduccionwc__default(),
            new Object[][] {
                new Object[] {
               H000Y3_A1EmpID, H000Y3_A10protID, H000Y3_A401OrdenNroDesp, H000Y3_n401OrdenNroDesp, H000Y3_A210OrdenUltSec, H000Y3_n210OrdenUltSec, H000Y3_A203ordenNroPed, H000Y3_n203ordenNroPed, H000Y3_A195OrdenFacNomb, H000Y3_n195OrdenFacNomb,
               H000Y3_A192OrdenPed, H000Y3_n192OrdenPed, H000Y3_A172OrdenfchEnt, H000Y3_n172OrdenfchEnt, H000Y3_A133OrdenProceso, H000Y3_n133OrdenProceso, H000Y3_A132OrdenEmpFac, H000Y3_n132OrdenEmpFac, H000Y3_A25OrdenAnio, H000Y3_A24OrdenPeriodo,
               H000Y3_A117OrdenModeloID, H000Y3_A26OrdenMarcaID, H000Y3_A57ClienteDsc, H000Y3_n57ClienteDsc, H000Y3_A5ClienteID, H000Y3_A119OrdenFch, H000Y3_n119OrdenFch, H000Y3_A116OrdenUser, H000Y3_n116OrdenUser, H000Y3_A115OrdenEst,
               H000Y3_n115OrdenEst, H000Y3_A110cantDias, H000Y3_n110cantDias, H000Y3_A109fchVenta, H000Y3_n109fchVenta, H000Y3_A69VehiculoChasis, H000Y3_n69VehiculoChasis, H000Y3_A68VehiculoPlaca, H000Y3_n68VehiculoPlaca, H000Y3_A8VehiculoID,
               H000Y3_A107representane, H000Y3_n107representane, H000Y3_A106facturaNro, H000Y3_n106facturaNro, H000Y3_A72vendedorDsc, H000Y3_n72vendedorDsc, H000Y3_A9vendedorID, H000Y3_A104tipOrdDsc, H000Y3_n104tipOrdDsc, H000Y3_A17tipOrdID,
               H000Y3_A22OrdenID, H000Y3_A255OrdenObreSuma, H000Y3_n255OrdenObreSuma, H000Y3_A168OrdenValOtrs, H000Y3_n168OrdenValOtrs, H000Y3_A167OrdenValEstr, H000Y3_n167OrdenValEstr, H000Y3_A166OrdenValPint, H000Y3_n166OrdenValPint, H000Y3_A165OrdenValCal,
               H000Y3_n165OrdenValCal, H000Y3_A163OrdenValEnrq, H000Y3_n163OrdenValEnrq, H000Y3_A162OrdenValInds, H000Y3_n162OrdenValInds, H000Y3_A161OrdenSubtotal, H000Y3_n161OrdenSubtotal, H000Y3_A153OrdenActaPdf, H000Y3_n153OrdenActaPdf, H000Y3_A152OrdenPdf,
               H000Y3_n152OrdenPdf, H000Y3_A112documento, H000Y3_n112documento, H000Y3_A108urlPdf, H000Y3_n108urlPdf
               }
               , new Object[] {
               H000Y5_AGRID_nRecordCount
               }
            }
         );
         AV17Pgmname = "PrototipoOrdenProduccionWC";
         /* GeneXus formulas. */
         AV17Pgmname = "PrototipoOrdenProduccionWC";
         context.Gx_err = 0;
      }

      private short AV6EmpID ;
      private short AV7protID ;
      private short wcpOAV6EmpID ;
      private short wcpOAV7protID ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_20 ;
      private short nGXsfl_20_idx=1 ;
      private short GRID_nEOF ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short A22OrdenID ;
      private short A17tipOrdID ;
      private short A9vendedorID ;
      private short A8VehiculoID ;
      private short A110cantDias ;
      private short A5ClienteID ;
      private short A26OrdenMarcaID ;
      private short A117OrdenModeloID ;
      private short A24OrdenPeriodo ;
      private short A25OrdenAnio ;
      private short A132OrdenEmpFac ;
      private short A210OrdenUltSec ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short A1EmpID ;
      private short A10protID ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int A106facturaNro ;
      private int A192OrdenPed ;
      private int A203ordenNroPed ;
      private int A401OrdenNroDesp ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtEmpID_Enabled ;
      private int edtEmpID_Visible ;
      private int edtprotID_Enabled ;
      private int edtprotID_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A161OrdenSubtotal ;
      private decimal A162OrdenValInds ;
      private decimal A163OrdenValEnrq ;
      private decimal A164OrdenValMatPri ;
      private decimal A166OrdenValPint ;
      private decimal A167OrdenValEstr ;
      private decimal A168OrdenValOtrs ;
      private decimal A169OrdenValManObr ;
      private decimal A170OrdenTotGast ;
      private decimal A171OrdenValRenta ;
      private decimal A165OrdenValCal ;
      private decimal A255OrdenObreSuma ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Tooltiptext ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_20_idx="0001" ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String GXKey ;
      private String AV17Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String divTabletop_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String divGridcell_Internalname ;
      private String divGridtable_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String subGrid_Header ;
      private String A104tipOrdDsc ;
      private String A72vendedorDsc ;
      private String A107representane ;
      private String A115OrdenEst ;
      private String A116OrdenUser ;
      private String A57ClienteDsc ;
      private String A195OrdenFacNomb ;
      private String edtEmpID_Internalname ;
      private String edtEmpID_Jsonclick ;
      private String edtprotID_Internalname ;
      private String edtprotID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtOrdenID_Internalname ;
      private String edttipOrdID_Internalname ;
      private String edttipOrdDsc_Internalname ;
      private String edtvendedorID_Internalname ;
      private String edtvendedorDsc_Internalname ;
      private String edtfacturaNro_Internalname ;
      private String edtrepresentane_Internalname ;
      private String edturlPdf_Internalname ;
      private String edtVehiculoID_Internalname ;
      private String edtVehiculoPlaca_Internalname ;
      private String edtVehiculoChasis_Internalname ;
      private String edtfchVenta_Internalname ;
      private String edtcantDias_Internalname ;
      private String edtdocumento_Internalname ;
      private String edtOrdenEst_Internalname ;
      private String edtOrdenUser_Internalname ;
      private String edtOrdenFch_Internalname ;
      private String edtClienteID_Internalname ;
      private String edtClienteDsc_Internalname ;
      private String edtOrdenMarcaID_Internalname ;
      private String edtOrdenModeloID_Internalname ;
      private String edtOrdenPeriodo_Internalname ;
      private String edtOrdenAnio_Internalname ;
      private String edtOrdenEmpFac_Internalname ;
      private String edtOrdenProceso_Internalname ;
      private String edtOrdenPdf_Internalname ;
      private String edtOrdenActaPdf_Internalname ;
      private String edtOrdenSubtotal_Internalname ;
      private String edtOrdenValInds_Internalname ;
      private String edtOrdenValEnrq_Internalname ;
      private String edtOrdenValMatPri_Internalname ;
      private String edtOrdenValPint_Internalname ;
      private String edtOrdenValEstr_Internalname ;
      private String edtOrdenValOtrs_Internalname ;
      private String edtOrdenValManObr_Internalname ;
      private String edtOrdenTotGast_Internalname ;
      private String edtOrdenValRenta_Internalname ;
      private String edtOrdenfchEnt_Internalname ;
      private String edtOrdenPed_Internalname ;
      private String edtOrdenFacNomb_Internalname ;
      private String edtOrdenValCal_Internalname ;
      private String edtordenNroPed_Internalname ;
      private String edtOrdenUltSec_Internalname ;
      private String edtOrdenObreSuma_Internalname ;
      private String edtOrdenNroDesp_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV6EmpID ;
      private String sCtrlAV7protID ;
      private String sGXsfl_20_fel_idx="0001" ;
      private String ROClassString ;
      private String edtOrdenID_Jsonclick ;
      private String edttipOrdID_Jsonclick ;
      private String edttipOrdDsc_Jsonclick ;
      private String edtvendedorID_Jsonclick ;
      private String edtvendedorDsc_Jsonclick ;
      private String edtfacturaNro_Jsonclick ;
      private String edtrepresentane_Jsonclick ;
      private String edturlPdf_Filetype ;
      private String edturlPdf_Contenttype ;
      private String edturlPdf_Parameters ;
      private String edturlPdf_Jsonclick ;
      private String edtVehiculoID_Jsonclick ;
      private String edtVehiculoPlaca_Jsonclick ;
      private String edtVehiculoChasis_Jsonclick ;
      private String edtfchVenta_Jsonclick ;
      private String edtcantDias_Jsonclick ;
      private String edtdocumento_Filetype ;
      private String edtdocumento_Contenttype ;
      private String edtdocumento_Parameters ;
      private String edtdocumento_Jsonclick ;
      private String edtOrdenEst_Jsonclick ;
      private String edtOrdenUser_Jsonclick ;
      private String edtOrdenFch_Jsonclick ;
      private String edtClienteID_Jsonclick ;
      private String edtClienteDsc_Jsonclick ;
      private String edtOrdenMarcaID_Jsonclick ;
      private String edtOrdenModeloID_Jsonclick ;
      private String edtOrdenPeriodo_Jsonclick ;
      private String edtOrdenAnio_Jsonclick ;
      private String edtOrdenEmpFac_Jsonclick ;
      private String edtOrdenProceso_Jsonclick ;
      private String edtOrdenPdf_Filetype ;
      private String edtOrdenPdf_Contenttype ;
      private String edtOrdenPdf_Parameters ;
      private String edtOrdenPdf_Jsonclick ;
      private String edtOrdenActaPdf_Filetype ;
      private String edtOrdenActaPdf_Contenttype ;
      private String edtOrdenActaPdf_Parameters ;
      private String edtOrdenActaPdf_Jsonclick ;
      private String edtOrdenSubtotal_Jsonclick ;
      private String edtOrdenValInds_Jsonclick ;
      private String edtOrdenValEnrq_Jsonclick ;
      private String edtOrdenValMatPri_Jsonclick ;
      private String edtOrdenValPint_Jsonclick ;
      private String edtOrdenValEstr_Jsonclick ;
      private String edtOrdenValOtrs_Jsonclick ;
      private String edtOrdenValManObr_Jsonclick ;
      private String edtOrdenTotGast_Jsonclick ;
      private String edtOrdenValRenta_Jsonclick ;
      private String edtOrdenfchEnt_Jsonclick ;
      private String edtOrdenPed_Jsonclick ;
      private String edtOrdenFacNomb_Jsonclick ;
      private String edtOrdenValCal_Jsonclick ;
      private String edtordenNroPed_Jsonclick ;
      private String edtOrdenUltSec_Jsonclick ;
      private String edtOrdenObreSuma_Jsonclick ;
      private String edtOrdenNroDesp_Jsonclick ;
      private String sImgUrl ;
      private DateTime A109fchVenta ;
      private DateTime A119OrdenFch ;
      private DateTime A172OrdenfchEnt ;
      private bool entryPointCalled ;
      private bool bGXsfl_20_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n104tipOrdDsc ;
      private bool n72vendedorDsc ;
      private bool n106facturaNro ;
      private bool n107representane ;
      private bool n108urlPdf ;
      private bool n68VehiculoPlaca ;
      private bool n69VehiculoChasis ;
      private bool n109fchVenta ;
      private bool n110cantDias ;
      private bool n112documento ;
      private bool n115OrdenEst ;
      private bool n116OrdenUser ;
      private bool n119OrdenFch ;
      private bool n57ClienteDsc ;
      private bool n132OrdenEmpFac ;
      private bool n133OrdenProceso ;
      private bool n152OrdenPdf ;
      private bool n153OrdenActaPdf ;
      private bool n161OrdenSubtotal ;
      private bool n162OrdenValInds ;
      private bool n163OrdenValEnrq ;
      private bool n166OrdenValPint ;
      private bool n167OrdenValEstr ;
      private bool n168OrdenValOtrs ;
      private bool n172OrdenfchEnt ;
      private bool n192OrdenPed ;
      private bool n195OrdenFacNomb ;
      private bool n165OrdenValCal ;
      private bool n203ordenNroPed ;
      private bool n210OrdenUltSec ;
      private bool n255OrdenObreSuma ;
      private bool n401OrdenNroDesp ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV12Update_IsBlob ;
      private bool AV13Delete_IsBlob ;
      private String A68VehiculoPlaca ;
      private String A69VehiculoChasis ;
      private String A133OrdenProceso ;
      private String AV18Update_GXI ;
      private String AV19Delete_GXI ;
      private String AV12Update ;
      private String AV13Delete ;
      private String A108urlPdf ;
      private String A112documento ;
      private String A152OrdenPdf ;
      private String A153OrdenActaPdf ;
      private GxFile gxblobfileaux ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H000Y3_A1EmpID ;
      private short[] H000Y3_A10protID ;
      private int[] H000Y3_A401OrdenNroDesp ;
      private bool[] H000Y3_n401OrdenNroDesp ;
      private short[] H000Y3_A210OrdenUltSec ;
      private bool[] H000Y3_n210OrdenUltSec ;
      private int[] H000Y3_A203ordenNroPed ;
      private bool[] H000Y3_n203ordenNroPed ;
      private String[] H000Y3_A195OrdenFacNomb ;
      private bool[] H000Y3_n195OrdenFacNomb ;
      private int[] H000Y3_A192OrdenPed ;
      private bool[] H000Y3_n192OrdenPed ;
      private DateTime[] H000Y3_A172OrdenfchEnt ;
      private bool[] H000Y3_n172OrdenfchEnt ;
      private String[] H000Y3_A133OrdenProceso ;
      private bool[] H000Y3_n133OrdenProceso ;
      private short[] H000Y3_A132OrdenEmpFac ;
      private bool[] H000Y3_n132OrdenEmpFac ;
      private short[] H000Y3_A25OrdenAnio ;
      private short[] H000Y3_A24OrdenPeriodo ;
      private short[] H000Y3_A117OrdenModeloID ;
      private short[] H000Y3_A26OrdenMarcaID ;
      private String[] H000Y3_A57ClienteDsc ;
      private bool[] H000Y3_n57ClienteDsc ;
      private short[] H000Y3_A5ClienteID ;
      private DateTime[] H000Y3_A119OrdenFch ;
      private bool[] H000Y3_n119OrdenFch ;
      private String[] H000Y3_A116OrdenUser ;
      private bool[] H000Y3_n116OrdenUser ;
      private String[] H000Y3_A115OrdenEst ;
      private bool[] H000Y3_n115OrdenEst ;
      private short[] H000Y3_A110cantDias ;
      private bool[] H000Y3_n110cantDias ;
      private DateTime[] H000Y3_A109fchVenta ;
      private bool[] H000Y3_n109fchVenta ;
      private String[] H000Y3_A69VehiculoChasis ;
      private bool[] H000Y3_n69VehiculoChasis ;
      private String[] H000Y3_A68VehiculoPlaca ;
      private bool[] H000Y3_n68VehiculoPlaca ;
      private short[] H000Y3_A8VehiculoID ;
      private String[] H000Y3_A107representane ;
      private bool[] H000Y3_n107representane ;
      private int[] H000Y3_A106facturaNro ;
      private bool[] H000Y3_n106facturaNro ;
      private String[] H000Y3_A72vendedorDsc ;
      private bool[] H000Y3_n72vendedorDsc ;
      private short[] H000Y3_A9vendedorID ;
      private String[] H000Y3_A104tipOrdDsc ;
      private bool[] H000Y3_n104tipOrdDsc ;
      private short[] H000Y3_A17tipOrdID ;
      private short[] H000Y3_A22OrdenID ;
      private decimal[] H000Y3_A255OrdenObreSuma ;
      private bool[] H000Y3_n255OrdenObreSuma ;
      private decimal[] H000Y3_A168OrdenValOtrs ;
      private bool[] H000Y3_n168OrdenValOtrs ;
      private decimal[] H000Y3_A167OrdenValEstr ;
      private bool[] H000Y3_n167OrdenValEstr ;
      private decimal[] H000Y3_A166OrdenValPint ;
      private bool[] H000Y3_n166OrdenValPint ;
      private decimal[] H000Y3_A165OrdenValCal ;
      private bool[] H000Y3_n165OrdenValCal ;
      private decimal[] H000Y3_A163OrdenValEnrq ;
      private bool[] H000Y3_n163OrdenValEnrq ;
      private decimal[] H000Y3_A162OrdenValInds ;
      private bool[] H000Y3_n162OrdenValInds ;
      private decimal[] H000Y3_A161OrdenSubtotal ;
      private bool[] H000Y3_n161OrdenSubtotal ;
      private String[] H000Y3_A153OrdenActaPdf ;
      private bool[] H000Y3_n153OrdenActaPdf ;
      private String[] H000Y3_A152OrdenPdf ;
      private bool[] H000Y3_n152OrdenPdf ;
      private String[] H000Y3_A112documento ;
      private bool[] H000Y3_n112documento ;
      private String[] H000Y3_A108urlPdf ;
      private bool[] H000Y3_n108urlPdf ;
      private long[] H000Y5_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private IGxSession AV8Session ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class prototipoordenproduccionwc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000Y3 ;
          prmH000Y3 = new Object[] {
          new Object[] {"@AV6EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7protID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          String cmdBufferH000Y3 ;
          cmdBufferH000Y3=" SELECT T1.[EmpID], T1.[protID], T1.[OrdenNroDesp], T1.[OrdenUltSec], T1.[ordenNroPed], T1.[OrdenFacNomb], T1.[OrdenPed], T1.[OrdenfchEnt], T1.[OrdenProceso], T1.[OrdenEmpFac], T1.[OrdenAnio], T1.[OrdenPeriodo], T1.[OrdenModeloID], T1.[OrdenMarcaID], T2.[ClienteDsc], T1.[ClienteID], T1.[OrdenFch], T1.[OrdenUser], T1.[OrdenEst], T1.[cantDias], T1.[fchVenta], T3.[VehiculoChasis], T3.[VehiculoPlaca], T1.[VehiculoID], T1.[representane], T1.[facturaNro], T4.[vendedorDsc], T1.[vendedorID], T5.[tipOrdDsc], T1.[tipOrdID], T1.[OrdenID], COALESCE( T6.[OrdenObreSuma], 0) AS OrdenObreSuma, T1.[OrdenValOtrs], T1.[OrdenValEstr], T1.[OrdenValPint], T1.[OrdenValCal], T1.[OrdenValEnrq], T1.[OrdenValInds], T1.[OrdenSubtotal], T1.[OrdenActaPdf], T1.[OrdenPdf], T1.[documento], T1.[urlPdf] FROM ((((([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) INNER JOIN [Vehiculos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[VehiculoID] = T1.[VehiculoID]) INNER JOIN [Vendedor] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[vendedorID] = T1.[vendedorID]) INNER JOIN [TipoOrdenPro] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[tipOrdID] = T1.[tipOrdID]) LEFT JOIN (SELECT SUM([OrdenObreValor]) AS OrdenObreSuma, [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccionObr] WITH (NOLOCK) GROUP BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] ) T6 ON T6.[EmpID] = T1.[EmpID] AND T6.[ClienteID] = T1.[ClienteID] AND T6.[OrdenPeriodo] = T1.[OrdenPeriodo] AND T6.[OrdenAnio] = T1.[OrdenAnio] AND T6.[OrdenID] = T1.[OrdenID]) WHERE T1.[EmpID] = @AV6EmpID and T1.[protID] = @AV7protID ORDER BY T1.[EmpID], T1.[protID]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN "
          + " @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY" ;
          Object[] prmH000Y5 ;
          prmH000Y5 = new Object[] {
          new Object[] {"@AV6EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7protID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000Y3", cmdBufferH000Y3,false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000Y3,11,0,true,false )
             ,new CursorDef("H000Y5", "SELECT COUNT(*) FROM ((((([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) INNER JOIN [Vehiculos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[VehiculoID] = T1.[VehiculoID]) INNER JOIN [Vendedor] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[vendedorID] = T1.[vendedorID]) INNER JOIN [TipoOrdenPro] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[tipOrdID] = T1.[tipOrdID]) LEFT JOIN (SELECT SUM([OrdenObreValor]) AS OrdenObreSuma, [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccionObr] WITH (NOLOCK) GROUP BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] ) T6 ON T6.[EmpID] = T1.[EmpID] AND T6.[ClienteID] = T1.[ClienteID] AND T6.[OrdenPeriodo] = T1.[OrdenPeriodo] AND T6.[OrdenAnio] = T1.[OrdenAnio] AND T6.[OrdenID] = T1.[OrdenID]) WHERE T1.[EmpID] = @AV6EmpID and T1.[protID] = @AV7protID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000Y5,1,0,true,false )
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((int[]) buf[6])[0] = rslt.getInt(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getString(6, 40) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((int[]) buf[10])[0] = rslt.getInt(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((String[]) buf[14])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((short[]) buf[16])[0] = rslt.getShort(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                ((short[]) buf[19])[0] = rslt.getShort(12) ;
                ((short[]) buf[20])[0] = rslt.getShort(13) ;
                ((short[]) buf[21])[0] = rslt.getShort(14) ;
                ((String[]) buf[22])[0] = rslt.getString(15, 50) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(15);
                ((short[]) buf[24])[0] = rslt.getShort(16) ;
                ((DateTime[]) buf[25])[0] = rslt.getGXDate(17) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(17);
                ((String[]) buf[27])[0] = rslt.getString(18, 40) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(18);
                ((String[]) buf[29])[0] = rslt.getString(19, 1) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(19);
                ((short[]) buf[31])[0] = rslt.getShort(20) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(20);
                ((DateTime[]) buf[33])[0] = rslt.getGXDate(21) ;
                ((bool[]) buf[34])[0] = rslt.wasNull(21);
                ((String[]) buf[35])[0] = rslt.getVarchar(22) ;
                ((bool[]) buf[36])[0] = rslt.wasNull(22);
                ((String[]) buf[37])[0] = rslt.getVarchar(23) ;
                ((bool[]) buf[38])[0] = rslt.wasNull(23);
                ((short[]) buf[39])[0] = rslt.getShort(24) ;
                ((String[]) buf[40])[0] = rslt.getString(25, 50) ;
                ((bool[]) buf[41])[0] = rslt.wasNull(25);
                ((int[]) buf[42])[0] = rslt.getInt(26) ;
                ((bool[]) buf[43])[0] = rslt.wasNull(26);
                ((String[]) buf[44])[0] = rslt.getString(27, 50) ;
                ((bool[]) buf[45])[0] = rslt.wasNull(27);
                ((short[]) buf[46])[0] = rslt.getShort(28) ;
                ((String[]) buf[47])[0] = rslt.getString(29, 40) ;
                ((bool[]) buf[48])[0] = rslt.wasNull(29);
                ((short[]) buf[49])[0] = rslt.getShort(30) ;
                ((short[]) buf[50])[0] = rslt.getShort(31) ;
                ((decimal[]) buf[51])[0] = rslt.getDecimal(32) ;
                ((bool[]) buf[52])[0] = rslt.wasNull(32);
                ((decimal[]) buf[53])[0] = rslt.getDecimal(33) ;
                ((bool[]) buf[54])[0] = rslt.wasNull(33);
                ((decimal[]) buf[55])[0] = rslt.getDecimal(34) ;
                ((bool[]) buf[56])[0] = rslt.wasNull(34);
                ((decimal[]) buf[57])[0] = rslt.getDecimal(35) ;
                ((bool[]) buf[58])[0] = rslt.wasNull(35);
                ((decimal[]) buf[59])[0] = rslt.getDecimal(36) ;
                ((bool[]) buf[60])[0] = rslt.wasNull(36);
                ((decimal[]) buf[61])[0] = rslt.getDecimal(37) ;
                ((bool[]) buf[62])[0] = rslt.wasNull(37);
                ((decimal[]) buf[63])[0] = rslt.getDecimal(38) ;
                ((bool[]) buf[64])[0] = rslt.wasNull(38);
                ((decimal[]) buf[65])[0] = rslt.getDecimal(39) ;
                ((bool[]) buf[66])[0] = rslt.wasNull(39);
                ((String[]) buf[67])[0] = rslt.getBLOBFile(40, ".pdf", "") ;
                ((bool[]) buf[68])[0] = rslt.wasNull(40);
                ((String[]) buf[69])[0] = rslt.getBLOBFile(41, ".pdf", "") ;
                ((bool[]) buf[70])[0] = rslt.wasNull(41);
                ((String[]) buf[71])[0] = rslt.getBLOBFile(42, "tmp", "") ;
                ((bool[]) buf[72])[0] = rslt.wasNull(42);
                ((String[]) buf[73])[0] = rslt.getBLOBFile(43, "tmp", "") ;
                ((bool[]) buf[74])[0] = rslt.wasNull(43);
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
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
