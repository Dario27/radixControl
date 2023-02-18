/*
               File: ClientesTipoInvWC
        Description: Clientes Tipo Inv WC
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/9/2023 12:19:49.94
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
   public class clientestipoinvwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public clientestipoinvwc( )
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

      public clientestipoinvwc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_ClienteID )
      {
         this.AV6EmpID = aP0_EmpID;
         this.AV7ClienteID = aP1_ClienteID;
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
                  AV7ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)AV6EmpID,(short)AV7ClienteID});
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
                  AV7ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
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
                  gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7ClienteID, AV12Update, AV13Delete, sPrefix) ;
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
            PA5Q2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV17Pgmname = "ClientesTipoInvWC";
               context.Gx_err = 0;
               WS5Q2( ) ;
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
            context.SendWebValue( "Clientes Tipo Inv WC") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2023191219501", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("clientestipoinvwc.aspx") + "?" + UrlEncode("" +AV6EmpID) + "," + UrlEncode("" +AV7ClienteID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7ClienteID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV7ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vCLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vUPDATE_Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
         GxWebStd.gx_hidden_field( context, sPrefix+"vDELETE_Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
      }

      protected void RenderHtmlCloseForm5Q2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("clientestipoinvwc.js", "?2023191219504", false);
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
         return "ClientesTipoInvWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Clientes Tipo Inv WC" ;
      }

      protected void WB5Q0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "clientestipoinvwc.aspx");
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(20), 2, 0)+","+"null"+");", "Agregar", bttBtninsert_Jsonclick, 5, "Agregar", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_ClientesTipoInvWC.htm");
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
               context.SendWebValue( "Anio") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Mes") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Age ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Bod Cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nombre Articulo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Presentacion") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Descripcion") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Stock") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Bod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fisico") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Bod.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Bod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro") ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A290stockAnio), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A291stockMes), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A217BodDsc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A309prdNombre);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A288PrdPres), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A307prdStockDsc);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A349totalStock, 13, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A292stockBod, 9, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A293invFisico, 6, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A294ingBod, 9, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A295egrBod, 9, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A350stockUltNro), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV12Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV13Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
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
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), ((edtEmpID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")) : context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", edtEmpID_Visible, edtEmpID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_ClientesTipoInvWC.htm");
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
            GxWebStd.gx_label_element( context, edtClienteID_Internalname, "Cliente ID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtClienteID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")), ((edtClienteID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9")) : context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteID_Jsonclick, 0, "Attribute", "", "", "", "", edtClienteID_Visible, edtClienteID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_ClientesTipoInvWC.htm");
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

      protected void START5Q2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
               Form.Meta.addItem("description", "Clientes Tipo Inv WC", 0) ;
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
               STRUP5Q0( ) ;
            }
         }
      }

      protected void WS5Q2( )
      {
         START5Q2( ) ;
         EVT5Q2( ) ;
      }

      protected void EVT5Q2( )
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
                                 STRUP5Q0( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DoInsert' */
                                    E115Q2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5Q0( ) ;
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
                                 STRUP5Q0( ) ;
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
                                 STRUP5Q0( ) ;
                              }
                              nGXsfl_20_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0");
                              SubsflControlProps_202( ) ;
                              A290stockAnio = (short)(context.localUtil.CToN( cgiGet( edtstockAnio_Internalname), ",", "."));
                              A291stockMes = (short)(context.localUtil.CToN( cgiGet( edtstockMes_Internalname), ",", "."));
                              A2AgeID = (short)(context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", "."));
                              A42BodCod = (short)(context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", "."));
                              A217BodDsc = StringUtil.Upper( cgiGet( edtBodDsc_Internalname));
                              n217BodDsc = false;
                              A286PrdCod = (short)(context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", "."));
                              A309prdNombre = cgiGet( edtprdNombre_Internalname);
                              n309prdNombre = false;
                              A288PrdPres = (short)(context.localUtil.CToN( cgiGet( edtPrdPres_Internalname), ",", "."));
                              n288PrdPres = false;
                              A307prdStockDsc = cgiGet( edtprdStockDsc_Internalname);
                              n307prdStockDsc = false;
                              A349totalStock = context.localUtil.CToN( cgiGet( edttotalStock_Internalname), ",", ".");
                              n349totalStock = false;
                              A292stockBod = context.localUtil.CToN( cgiGet( edtstockBod_Internalname), ",", ".");
                              A293invFisico = context.localUtil.CToN( cgiGet( edtinvFisico_Internalname), ",", ".");
                              n293invFisico = false;
                              A294ingBod = context.localUtil.CToN( cgiGet( edtingBod_Internalname), ",", ".");
                              A295egrBod = context.localUtil.CToN( cgiGet( edtegrBod_Internalname), ",", ".");
                              n295egrBod = false;
                              A350stockUltNro = (short)(context.localUtil.CToN( cgiGet( edtstockUltNro_Internalname), ",", "."));
                              n350stockUltNro = false;
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
                                          E125Q2 ();
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
                                          E135Q2 ();
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
                                       STRUP5Q0( ) ;
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

      protected void WE5Q2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5Q2( ) ;
            }
         }
      }

      protected void PA5Q2( )
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
                                       short AV7ClienteID ,
                                       String AV12Update ,
                                       String AV13Delete ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5Q2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_STOCKANIO", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A290stockAnio), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"STOCKANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A290stockAnio), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_STOCKMES", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A291stockMes), "Z9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"STOCKMES", StringUtil.LTrim( StringUtil.NToC( (decimal)(A291stockMes), 2, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_AGEID", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"AGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BODCOD", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"BODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_PRDCOD", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"PRDCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ".", "")));
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
         RF5Q2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV17Pgmname = "ClientesTipoInvWC";
         context.Gx_err = 0;
      }

      protected void RF5Q2( )
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
            /* Using cursor H005Q5 */
            pr_default.execute(0, new Object[] {AV6EmpID, AV7ClienteID, GXPagingFrom2, GXPagingTo2});
            nGXsfl_20_idx = 1;
            sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0");
            SubsflControlProps_202( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A1EmpID = H005Q5_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A5ClienteID = H005Q5_A5ClienteID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               A350stockUltNro = H005Q5_A350stockUltNro[0];
               n350stockUltNro = H005Q5_n350stockUltNro[0];
               A307prdStockDsc = H005Q5_A307prdStockDsc[0];
               n307prdStockDsc = H005Q5_n307prdStockDsc[0];
               A288PrdPres = H005Q5_A288PrdPres[0];
               n288PrdPres = H005Q5_n288PrdPres[0];
               A309prdNombre = H005Q5_A309prdNombre[0];
               n309prdNombre = H005Q5_n309prdNombre[0];
               A286PrdCod = H005Q5_A286PrdCod[0];
               A217BodDsc = H005Q5_A217BodDsc[0];
               n217BodDsc = H005Q5_n217BodDsc[0];
               A42BodCod = H005Q5_A42BodCod[0];
               A2AgeID = H005Q5_A2AgeID[0];
               A291stockMes = H005Q5_A291stockMes[0];
               A290stockAnio = H005Q5_A290stockAnio[0];
               A349totalStock = H005Q5_A349totalStock[0];
               n349totalStock = H005Q5_n349totalStock[0];
               A295egrBod = H005Q5_A295egrBod[0];
               n295egrBod = H005Q5_n295egrBod[0];
               A294ingBod = H005Q5_A294ingBod[0];
               A293invFisico = H005Q5_A293invFisico[0];
               n293invFisico = H005Q5_n293invFisico[0];
               A217BodDsc = H005Q5_A217BodDsc[0];
               n217BodDsc = H005Q5_n217BodDsc[0];
               A288PrdPres = H005Q5_A288PrdPres[0];
               n288PrdPres = H005Q5_n288PrdPres[0];
               A309prdNombre = H005Q5_A309prdNombre[0];
               n309prdNombre = H005Q5_n309prdNombre[0];
               A350stockUltNro = H005Q5_A350stockUltNro[0];
               n350stockUltNro = H005Q5_n350stockUltNro[0];
               A307prdStockDsc = H005Q5_A307prdStockDsc[0];
               n307prdStockDsc = H005Q5_n307prdStockDsc[0];
               A293invFisico = H005Q5_A293invFisico[0];
               n293invFisico = H005Q5_n293invFisico[0];
               A295egrBod = H005Q5_A295egrBod[0];
               n295egrBod = H005Q5_n295egrBod[0];
               A294ingBod = H005Q5_A294ingBod[0];
               A349totalStock = H005Q5_A349totalStock[0];
               n349totalStock = H005Q5_n349totalStock[0];
               A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
               E135Q2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 20;
            WB5Q0( ) ;
         }
         bGXsfl_20_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5Q2( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_STOCKANIO"+"_"+sGXsfl_20_idx, GetSecureSignedToken( sPrefix+sGXsfl_20_idx, context.localUtil.Format( (decimal)(A290stockAnio), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_STOCKMES"+"_"+sGXsfl_20_idx, GetSecureSignedToken( sPrefix+sGXsfl_20_idx, context.localUtil.Format( (decimal)(A291stockMes), "Z9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_AGEID"+"_"+sGXsfl_20_idx, GetSecureSignedToken( sPrefix+sGXsfl_20_idx, context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BODCOD"+"_"+sGXsfl_20_idx, GetSecureSignedToken( sPrefix+sGXsfl_20_idx, context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_PRDCOD"+"_"+sGXsfl_20_idx, GetSecureSignedToken( sPrefix+sGXsfl_20_idx, context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9"), context));
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
         /* Using cursor H005Q9 */
         pr_default.execute(1, new Object[] {AV6EmpID, AV7ClienteID});
         GRID_nRecordCount = H005Q9_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7ClienteID, AV12Update, AV13Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7ClienteID, AV12Update, AV13Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7ClienteID, AV12Update, AV13Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7ClienteID, AV12Update, AV13Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV6EmpID, AV7ClienteID, AV12Update, AV13Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5Q0( )
      {
         /* Before Start, stand alone formulas. */
         AV17Pgmname = "ClientesTipoInvWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E125Q2 ();
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
            A5ClienteID = (short)(context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            /* Read saved values. */
            nRC_GXsfl_20 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_20"), ",", "."));
            wcpOAV6EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV6EmpID"), ",", "."));
            wcpOAV7ClienteID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7ClienteID"), ",", "."));
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
         E125Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E125Q2( )
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
         edtClienteID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtClienteID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Visible), 5, 0)), true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      private void E135Q2( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("prodstockbodega.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A290stockAnio) + "," + UrlEncode("" +A291stockMes) + "," + UrlEncode("" +AV6EmpID) + "," + UrlEncode("" +A2AgeID) + "," + UrlEncode("" +A42BodCod) + "," + UrlEncode("" +A286PrdCod);
         edtavDelete_Link = formatLink("prodstockbodega.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A290stockAnio) + "," + UrlEncode("" +A291stockMes) + "," + UrlEncode("" +AV6EmpID) + "," + UrlEncode("" +A2AgeID) + "," + UrlEncode("" +A42BodCod) + "," + UrlEncode("" +A286PrdCod);
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
         /*  Sending Event outputs  */
      }

      protected void E115Q2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("prodstockbodega.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) + "," + UrlEncode("" +AV6EmpID) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new SdtTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV17Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "ProdStockBodega";
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "EmpID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6EmpID), 4, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "ClienteID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7ClienteID), 4, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV8Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "TransactionContext", "KBCalpesa22"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6EmpID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6EmpID), 4, 0)));
         AV7ClienteID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0)));
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
         PA5Q2( ) ;
         WS5Q2( ) ;
         WE5Q2( ) ;
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
         sCtrlAV7ClienteID = (String)((String)getParm(obj,1));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA5Q2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "clientestipoinvwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA5Q2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV6EmpID = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6EmpID), 4, 0)));
            AV7ClienteID = Convert.ToInt16(getParm(obj,3));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0)));
         }
         wcpOAV6EmpID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV6EmpID"), ",", "."));
         wcpOAV7ClienteID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7ClienteID"), ",", "."));
         if ( ! GetJustCreated( ) && ( ( AV6EmpID != wcpOAV6EmpID ) || ( AV7ClienteID != wcpOAV7ClienteID ) ) )
         {
            setjustcreated();
         }
         wcpOAV6EmpID = AV6EmpID;
         wcpOAV7ClienteID = AV7ClienteID;
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
         sCtrlAV7ClienteID = cgiGet( sPrefix+"AV7ClienteID_CTRL");
         if ( StringUtil.Len( sCtrlAV7ClienteID) > 0 )
         {
            AV7ClienteID = (short)(context.localUtil.CToN( cgiGet( sCtrlAV7ClienteID), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ClienteID), 4, 0)));
         }
         else
         {
            AV7ClienteID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV7ClienteID_PARM"), ",", "."));
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
         PA5Q2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS5Q2( ) ;
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
         WS5Q2( ) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7ClienteID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ClienteID), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7ClienteID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7ClienteID_CTRL", StringUtil.RTrim( sCtrlAV7ClienteID));
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
         WE5Q2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2023191219514", true);
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
            context.AddJavascriptSource("clientestipoinvwc.js", "?2023191219515", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_202( )
      {
         edtstockAnio_Internalname = sPrefix+"STOCKANIO_"+sGXsfl_20_idx;
         edtstockMes_Internalname = sPrefix+"STOCKMES_"+sGXsfl_20_idx;
         edtAgeID_Internalname = sPrefix+"AGEID_"+sGXsfl_20_idx;
         edtBodCod_Internalname = sPrefix+"BODCOD_"+sGXsfl_20_idx;
         edtBodDsc_Internalname = sPrefix+"BODDSC_"+sGXsfl_20_idx;
         edtPrdCod_Internalname = sPrefix+"PRDCOD_"+sGXsfl_20_idx;
         edtprdNombre_Internalname = sPrefix+"PRDNOMBRE_"+sGXsfl_20_idx;
         edtPrdPres_Internalname = sPrefix+"PRDPRES_"+sGXsfl_20_idx;
         edtprdStockDsc_Internalname = sPrefix+"PRDSTOCKDSC_"+sGXsfl_20_idx;
         edttotalStock_Internalname = sPrefix+"TOTALSTOCK_"+sGXsfl_20_idx;
         edtstockBod_Internalname = sPrefix+"STOCKBOD_"+sGXsfl_20_idx;
         edtinvFisico_Internalname = sPrefix+"INVFISICO_"+sGXsfl_20_idx;
         edtingBod_Internalname = sPrefix+"INGBOD_"+sGXsfl_20_idx;
         edtegrBod_Internalname = sPrefix+"EGRBOD_"+sGXsfl_20_idx;
         edtstockUltNro_Internalname = sPrefix+"STOCKULTNRO_"+sGXsfl_20_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_20_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_20_idx;
      }

      protected void SubsflControlProps_fel_202( )
      {
         edtstockAnio_Internalname = sPrefix+"STOCKANIO_"+sGXsfl_20_fel_idx;
         edtstockMes_Internalname = sPrefix+"STOCKMES_"+sGXsfl_20_fel_idx;
         edtAgeID_Internalname = sPrefix+"AGEID_"+sGXsfl_20_fel_idx;
         edtBodCod_Internalname = sPrefix+"BODCOD_"+sGXsfl_20_fel_idx;
         edtBodDsc_Internalname = sPrefix+"BODDSC_"+sGXsfl_20_fel_idx;
         edtPrdCod_Internalname = sPrefix+"PRDCOD_"+sGXsfl_20_fel_idx;
         edtprdNombre_Internalname = sPrefix+"PRDNOMBRE_"+sGXsfl_20_fel_idx;
         edtPrdPres_Internalname = sPrefix+"PRDPRES_"+sGXsfl_20_fel_idx;
         edtprdStockDsc_Internalname = sPrefix+"PRDSTOCKDSC_"+sGXsfl_20_fel_idx;
         edttotalStock_Internalname = sPrefix+"TOTALSTOCK_"+sGXsfl_20_fel_idx;
         edtstockBod_Internalname = sPrefix+"STOCKBOD_"+sGXsfl_20_fel_idx;
         edtinvFisico_Internalname = sPrefix+"INVFISICO_"+sGXsfl_20_fel_idx;
         edtingBod_Internalname = sPrefix+"INGBOD_"+sGXsfl_20_fel_idx;
         edtegrBod_Internalname = sPrefix+"EGRBOD_"+sGXsfl_20_fel_idx;
         edtstockUltNro_Internalname = sPrefix+"STOCKULTNRO_"+sGXsfl_20_fel_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_20_fel_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_20_fel_idx;
      }

      protected void sendrow_202( )
      {
         SubsflControlProps_202( ) ;
         WB5Q0( ) ;
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstockAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A290stockAnio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A290stockAnio), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstockAnio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstockMes_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A291stockMes), 2, 0, ",", "")),context.localUtil.Format( (decimal)(A291stockMes), "Z9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstockMes_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAgeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAgeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBodCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodDsc_Internalname,StringUtil.RTrim( A217BodDsc),StringUtil.RTrim( context.localUtil.Format( A217BodDsc, "@!")),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBodDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrdCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrdCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprdNombre_Internalname,(String)A309prdNombre,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprdNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)80,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrdPres_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A288PrdPres), 2, 0, ",", "")),context.localUtil.Format( (decimal)(A288PrdPres), "Z9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrdPres_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprdStockDsc_Internalname,(String)A307prdStockDsc,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprdStockDsc_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)80,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edttotalStock_Internalname,StringUtil.LTrim( StringUtil.NToC( A349totalStock, 13, 2, ",", "")),context.localUtil.Format( A349totalStock, "ZZ,ZZZ,ZZZ.ZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edttotalStock_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"valores",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstockBod_Internalname,StringUtil.LTrim( StringUtil.NToC( A292stockBod, 9, 2, ",", "")),context.localUtil.Format( A292stockBod, "ZZ.ZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstockBod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtinvFisico_Internalname,StringUtil.LTrim( StringUtil.NToC( A293invFisico, 6, 2, ",", "")),context.localUtil.Format( A293invFisico, "ZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtinvFisico_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingBod_Internalname,StringUtil.LTrim( StringUtil.NToC( A294ingBod, 9, 2, ",", "")),context.localUtil.Format( A294ingBod, "ZZZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingBod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtegrBod_Internalname,StringUtil.LTrim( StringUtil.NToC( A295egrBod, 9, 2, ",", "")),context.localUtil.Format( A295egrBod, "ZZZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtegrBod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstockUltNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A350stockUltNro), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A350stockUltNro), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstockUltNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV12Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
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
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV13Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            send_integrity_lvl_hashes5Q2( ) ;
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
         edtstockAnio_Internalname = sPrefix+"STOCKANIO";
         edtstockMes_Internalname = sPrefix+"STOCKMES";
         edtAgeID_Internalname = sPrefix+"AGEID";
         edtBodCod_Internalname = sPrefix+"BODCOD";
         edtBodDsc_Internalname = sPrefix+"BODDSC";
         edtPrdCod_Internalname = sPrefix+"PRDCOD";
         edtprdNombre_Internalname = sPrefix+"PRDNOMBRE";
         edtPrdPres_Internalname = sPrefix+"PRDPRES";
         edtprdStockDsc_Internalname = sPrefix+"PRDSTOCKDSC";
         edttotalStock_Internalname = sPrefix+"TOTALSTOCK";
         edtstockBod_Internalname = sPrefix+"STOCKBOD";
         edtinvFisico_Internalname = sPrefix+"INVFISICO";
         edtingBod_Internalname = sPrefix+"INGBOD";
         edtegrBod_Internalname = sPrefix+"EGRBOD";
         edtstockUltNro_Internalname = sPrefix+"STOCKULTNRO";
         edtavUpdate_Internalname = sPrefix+"vUPDATE";
         edtavDelete_Internalname = sPrefix+"vDELETE";
         divGridtable_Internalname = sPrefix+"GRIDTABLE";
         divGridcell_Internalname = sPrefix+"GRIDCELL";
         edtEmpID_Internalname = sPrefix+"EMPID";
         edtClienteID_Internalname = sPrefix+"CLIENTEID";
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
         edtstockUltNro_Jsonclick = "";
         edtegrBod_Jsonclick = "";
         edtingBod_Jsonclick = "";
         edtinvFisico_Jsonclick = "";
         edtstockBod_Jsonclick = "";
         edttotalStock_Jsonclick = "";
         edtprdStockDsc_Jsonclick = "";
         edtPrdPres_Jsonclick = "";
         edtprdNombre_Jsonclick = "";
         edtPrdCod_Jsonclick = "";
         edtBodDsc_Jsonclick = "";
         edtBodCod_Jsonclick = "";
         edtAgeID_Jsonclick = "";
         edtstockMes_Jsonclick = "";
         edtstockAnio_Jsonclick = "";
         edtClienteID_Jsonclick = "";
         edtClienteID_Enabled = 0;
         edtClienteID_Visible = 1;
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 0;
         edtEmpID_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Link = "";
         edtavUpdate_Link = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV13Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'sPrefix'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRID.LOAD","{handler:'E135Q2',iparms:[{av:'A290stockAnio',fld:'STOCKANIO',pic:'ZZZ9',hsh:true},{av:'A291stockMes',fld:'STOCKMES',pic:'Z9',hsh:true},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9',hsh:true},{av:'A42BodCod',fld:'BODCOD',pic:'ZZZ9',hsh:true},{av:'A286PrdCod',fld:'PRDCOD',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E115Q2',iparms:[{av:'A290stockAnio',fld:'STOCKANIO',pic:'ZZZ9',hsh:true},{av:'A291stockMes',fld:'STOCKMES',pic:'Z9',hsh:true},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9',hsh:true},{av:'A42BodCod',fld:'BODCOD',pic:'ZZZ9',hsh:true},{av:'A286PrdCod',fld:'PRDCOD',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV13Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'sPrefix'}]");
         setEventMetadata("GRID_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV13Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'sPrefix'}]");
         setEventMetadata("GRID_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV13Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'sPrefix'}]");
         setEventMetadata("GRID_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6EmpID',fld:'vEMPID',pic:'ZZZ9'},{av:'AV7ClienteID',fld:'vCLIENTEID',pic:'ZZZ9'},{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'AV13Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'sPrefix'}]");
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
         A217BodDsc = "";
         A309prdNombre = "";
         A307prdStockDsc = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18Update_GXI = "";
         AV19Delete_GXI = "";
         scmdbuf = "";
         H005Q5_A348stockDetID = new short[1] ;
         H005Q5_A1EmpID = new short[1] ;
         H005Q5_A5ClienteID = new short[1] ;
         H005Q5_A350stockUltNro = new short[1] ;
         H005Q5_n350stockUltNro = new bool[] {false} ;
         H005Q5_A307prdStockDsc = new String[] {""} ;
         H005Q5_n307prdStockDsc = new bool[] {false} ;
         H005Q5_A288PrdPres = new short[1] ;
         H005Q5_n288PrdPres = new bool[] {false} ;
         H005Q5_A309prdNombre = new String[] {""} ;
         H005Q5_n309prdNombre = new bool[] {false} ;
         H005Q5_A286PrdCod = new short[1] ;
         H005Q5_A217BodDsc = new String[] {""} ;
         H005Q5_n217BodDsc = new bool[] {false} ;
         H005Q5_A42BodCod = new short[1] ;
         H005Q5_A2AgeID = new short[1] ;
         H005Q5_A291stockMes = new short[1] ;
         H005Q5_A290stockAnio = new short[1] ;
         H005Q5_A349totalStock = new decimal[1] ;
         H005Q5_n349totalStock = new bool[] {false} ;
         H005Q5_A295egrBod = new decimal[1] ;
         H005Q5_n295egrBod = new bool[] {false} ;
         H005Q5_A294ingBod = new decimal[1] ;
         H005Q5_A293invFisico = new decimal[1] ;
         H005Q5_n293invFisico = new bool[] {false} ;
         H005Q9_AGRID_nRecordCount = new long[1] ;
         GridRow = new GXWebRow();
         AV10TrnContext = new SdtTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV6EmpID = "";
         sCtrlAV7ClienteID = "";
         ROClassString = "";
         sImgUrl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.clientestipoinvwc__default(),
            new Object[][] {
                new Object[] {
               H005Q5_A348stockDetID, H005Q5_A1EmpID, H005Q5_A5ClienteID, H005Q5_A350stockUltNro, H005Q5_n350stockUltNro, H005Q5_A307prdStockDsc, H005Q5_n307prdStockDsc, H005Q5_A288PrdPres, H005Q5_n288PrdPres, H005Q5_A309prdNombre,
               H005Q5_n309prdNombre, H005Q5_A286PrdCod, H005Q5_A217BodDsc, H005Q5_n217BodDsc, H005Q5_A42BodCod, H005Q5_A2AgeID, H005Q5_A291stockMes, H005Q5_A290stockAnio, H005Q5_A349totalStock, H005Q5_n349totalStock,
               H005Q5_A295egrBod, H005Q5_n295egrBod, H005Q5_A294ingBod, H005Q5_A293invFisico, H005Q5_n293invFisico
               }
               , new Object[] {
               H005Q9_AGRID_nRecordCount
               }
            }
         );
         AV17Pgmname = "ClientesTipoInvWC";
         /* GeneXus formulas. */
         AV17Pgmname = "ClientesTipoInvWC";
         context.Gx_err = 0;
      }

      private short AV6EmpID ;
      private short AV7ClienteID ;
      private short wcpOAV6EmpID ;
      private short wcpOAV7ClienteID ;
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
      private short A290stockAnio ;
      private short A291stockMes ;
      private short A2AgeID ;
      private short A42BodCod ;
      private short A286PrdCod ;
      private short A288PrdPres ;
      private short A350stockUltNro ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short A1EmpID ;
      private short A5ClienteID ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtEmpID_Enabled ;
      private int edtEmpID_Visible ;
      private int edtClienteID_Enabled ;
      private int edtClienteID_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A349totalStock ;
      private decimal A292stockBod ;
      private decimal A293invFisico ;
      private decimal A294ingBod ;
      private decimal A295egrBod ;
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
      private String A217BodDsc ;
      private String edtavUpdate_Link ;
      private String edtavDelete_Link ;
      private String edtEmpID_Internalname ;
      private String edtEmpID_Jsonclick ;
      private String edtClienteID_Internalname ;
      private String edtClienteID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtstockAnio_Internalname ;
      private String edtstockMes_Internalname ;
      private String edtAgeID_Internalname ;
      private String edtBodCod_Internalname ;
      private String edtBodDsc_Internalname ;
      private String edtPrdCod_Internalname ;
      private String edtprdNombre_Internalname ;
      private String edtPrdPres_Internalname ;
      private String edtprdStockDsc_Internalname ;
      private String edttotalStock_Internalname ;
      private String edtstockBod_Internalname ;
      private String edtinvFisico_Internalname ;
      private String edtingBod_Internalname ;
      private String edtegrBod_Internalname ;
      private String edtstockUltNro_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV6EmpID ;
      private String sCtrlAV7ClienteID ;
      private String sGXsfl_20_fel_idx="0001" ;
      private String ROClassString ;
      private String edtstockAnio_Jsonclick ;
      private String edtstockMes_Jsonclick ;
      private String edtAgeID_Jsonclick ;
      private String edtBodCod_Jsonclick ;
      private String edtBodDsc_Jsonclick ;
      private String edtPrdCod_Jsonclick ;
      private String edtprdNombre_Jsonclick ;
      private String edtPrdPres_Jsonclick ;
      private String edtprdStockDsc_Jsonclick ;
      private String edttotalStock_Jsonclick ;
      private String edtstockBod_Jsonclick ;
      private String edtinvFisico_Jsonclick ;
      private String edtingBod_Jsonclick ;
      private String edtegrBod_Jsonclick ;
      private String edtstockUltNro_Jsonclick ;
      private String sImgUrl ;
      private bool entryPointCalled ;
      private bool bGXsfl_20_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n217BodDsc ;
      private bool n309prdNombre ;
      private bool n288PrdPres ;
      private bool n307prdStockDsc ;
      private bool n349totalStock ;
      private bool n293invFisico ;
      private bool n295egrBod ;
      private bool n350stockUltNro ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV12Update_IsBlob ;
      private bool AV13Delete_IsBlob ;
      private String A309prdNombre ;
      private String A307prdStockDsc ;
      private String AV18Update_GXI ;
      private String AV19Delete_GXI ;
      private String AV12Update ;
      private String AV13Delete ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H005Q5_A348stockDetID ;
      private short[] H005Q5_A1EmpID ;
      private short[] H005Q5_A5ClienteID ;
      private short[] H005Q5_A350stockUltNro ;
      private bool[] H005Q5_n350stockUltNro ;
      private String[] H005Q5_A307prdStockDsc ;
      private bool[] H005Q5_n307prdStockDsc ;
      private short[] H005Q5_A288PrdPres ;
      private bool[] H005Q5_n288PrdPres ;
      private String[] H005Q5_A309prdNombre ;
      private bool[] H005Q5_n309prdNombre ;
      private short[] H005Q5_A286PrdCod ;
      private String[] H005Q5_A217BodDsc ;
      private bool[] H005Q5_n217BodDsc ;
      private short[] H005Q5_A42BodCod ;
      private short[] H005Q5_A2AgeID ;
      private short[] H005Q5_A291stockMes ;
      private short[] H005Q5_A290stockAnio ;
      private decimal[] H005Q5_A349totalStock ;
      private bool[] H005Q5_n349totalStock ;
      private decimal[] H005Q5_A295egrBod ;
      private bool[] H005Q5_n295egrBod ;
      private decimal[] H005Q5_A294ingBod ;
      private decimal[] H005Q5_A293invFisico ;
      private bool[] H005Q5_n293invFisico ;
      private long[] H005Q9_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private IGxSession AV8Session ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class clientestipoinvwc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH005Q5 ;
          prmH005Q5 = new Object[] {
          new Object[] {"@AV6EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          String cmdBufferH005Q5 ;
          cmdBufferH005Q5=" SELECT T1.[stockDetID], T1.[EmpID], T1.[ClienteID], T4.[stockUltNro], T4.[prdStockDsc], T3.[PrdPres], T3.[prdNombre], T1.[PrdCod], T2.[BodDsc], T1.[BodCod], T1.[AgeID], T1.[stockMes], T1.[stockAnio], COALESCE( T7.[totalStock], 0) AS totalStock, COALESCE( T5.[egrBod], 0) AS egrBod, COALESCE( T6.[ingBod], 0) AS ingBod, T4.[invFisico] FROM (((((([ProdxBodegaTipoInv] T1 WITH (NOLOCK) INNER JOIN [Bodegas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[BodCod] = T1.[BodCod]) INNER JOIN [Productos] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[AgeID] = T1.[AgeID] AND T3.[PrdCod] = T1.[PrdCod]) INNER JOIN [ProdxBodega] T4 WITH (NOLOCK) ON T4.[stockAnio] = T1.[stockAnio] AND T4.[stockMes] = T1.[stockMes] AND T4.[EmpID] = T1.[EmpID] AND T4.[AgeID] = T1.[AgeID] AND T4.[BodCod] = T1.[BodCod] AND T4.[PrdCod] = T1.[PrdCod]) LEFT JOIN (SELECT SUM(CASE  WHEN COALESCE( T9.[TipoInvSigno], 0) = -1 THEN COALESCE( T8.[cantidad], 0) ELSE 0 END) AS egrBod, T8.[stockAnio], T8.[stockMes], T8.[EmpID], T8.[AgeID], T8.[BodCod], T8.[PrdCod] FROM ([ProdxBodegaTipoInv] T8 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T9 WITH (NOLOCK) ON T9.[TipoInv] = T8.[TipoInv]) GROUP BY T8.[stockAnio], T8.[stockMes], T8.[EmpID], T8.[AgeID], T8.[BodCod], T8.[PrdCod] ) T5 ON T5.[stockAnio] = T1.[stockAnio] AND T5.[stockMes] = T1.[stockMes] AND T5.[EmpID] = T1.[EmpID] AND T5.[AgeID] = T1.[AgeID] AND T5.[BodCod] = T1.[BodCod] AND T5.[PrdCod] = T1.[PrdCod]) LEFT JOIN (SELECT T8.[stockAnio], T8.[stockMes], T8.[EmpID], T8.[AgeID], T8.[BodCod], T8.[PrdCod], SUM(CASE  WHEN COALESCE( T9.[TipoInvSigno], 0) = 1 THEN COALESCE( T8.[ingCantidad], 0) ELSE 0 END) AS ingBod FROM ([ProdStockBodegastockDetEgr] T8 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T9 WITH (NOLOCK) ON T9.[TipoInv] = T8.[ingTipoInv]) GROUP BY T8.[stockAnio], "
          + " T8.[stockMes], T8.[EmpID], T8.[AgeID], T8.[BodCod], T8.[PrdCod] ) T6 ON T6.[stockAnio] = T1.[stockAnio] AND T6.[stockMes] = T1.[stockMes] AND T6.[EmpID] = T1.[EmpID] AND T6.[AgeID] = T1.[AgeID] AND T6.[BodCod] = T1.[BodCod] AND T6.[PrdCod] = T1.[PrdCod]) LEFT JOIN (SELECT SUM([stock]) AS totalStock, [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodegaTipoInv] WITH (NOLOCK) GROUP BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] ) T7 ON T7.[stockAnio] = T1.[stockAnio] AND T7.[stockMes] = T1.[stockMes] AND T7.[EmpID] = T1.[EmpID] AND T7.[AgeID] = T1.[AgeID] AND T7.[BodCod] = T1.[BodCod] AND T7.[PrdCod] = T1.[PrdCod]) WHERE T1.[EmpID] = @AV6EmpID and T1.[ClienteID] = @AV7ClienteID ORDER BY T1.[EmpID], T1.[ClienteID]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY" ;
          Object[] prmH005Q9 ;
          prmH005Q9 = new Object[] {
          new Object[] {"@AV6EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          String cmdBufferH005Q9 ;
          cmdBufferH005Q9=" SELECT COUNT(*) FROM (((((([ProdxBodegaTipoInv] T1 WITH (NOLOCK) INNER JOIN [Bodegas] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[BodCod] = T1.[BodCod]) INNER JOIN [Productos] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[AgeID] = T1.[AgeID] AND T4.[PrdCod] = T1.[PrdCod]) INNER JOIN [ProdxBodega] T2 WITH (NOLOCK) ON T2.[stockAnio] = T1.[stockAnio] AND T2.[stockMes] = T1.[stockMes] AND T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[BodCod] = T1.[BodCod] AND T2.[PrdCod] = T1.[PrdCod]) LEFT JOIN (SELECT SUM(CASE  WHEN COALESCE( T9.[TipoInvSigno], 0) = -1 THEN COALESCE( T8.[cantidad], 0) ELSE 0 END) AS egrBod, T8.[stockAnio], T8.[stockMes], T8.[EmpID], T8.[AgeID], T8.[BodCod], T8.[PrdCod] FROM ([ProdxBodegaTipoInv] T8 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T9 WITH (NOLOCK) ON T9.[TipoInv] = T8.[TipoInv]) GROUP BY T8.[stockAnio], T8.[stockMes], T8.[EmpID], T8.[AgeID], T8.[BodCod], T8.[PrdCod] ) T5 ON T5.[stockAnio] = T1.[stockAnio] AND T5.[stockMes] = T1.[stockMes] AND T5.[EmpID] = T1.[EmpID] AND T5.[AgeID] = T1.[AgeID] AND T5.[BodCod] = T1.[BodCod] AND T5.[PrdCod] = T1.[PrdCod]) LEFT JOIN (SELECT T8.[stockAnio], T8.[stockMes], T8.[EmpID], T8.[AgeID], T8.[BodCod], T8.[PrdCod], SUM(CASE  WHEN COALESCE( T9.[TipoInvSigno], 0) = 1 THEN COALESCE( T8.[ingCantidad], 0) ELSE 0 END) AS ingBod FROM ([ProdStockBodegastockDetEgr] T8 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T9 WITH (NOLOCK) ON T9.[TipoInv] = T8.[ingTipoInv]) GROUP BY T8.[stockAnio], T8.[stockMes], T8.[EmpID], T8.[AgeID], T8.[BodCod], T8.[PrdCod] ) T6 ON T6.[stockAnio] = T1.[stockAnio] AND T6.[stockMes] = T1.[stockMes] AND T6.[EmpID] = T1.[EmpID] AND T6.[AgeID] = T1.[AgeID] AND T6.[BodCod] = T1.[BodCod] AND T6.[PrdCod] = T1.[PrdCod]) LEFT JOIN (SELECT SUM([stock]) AS totalStock, [stockAnio], "
          + " [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodegaTipoInv] WITH (NOLOCK) GROUP BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] ) T7 ON T7.[stockAnio] = T1.[stockAnio] AND T7.[stockMes] = T1.[stockMes] AND T7.[EmpID] = T1.[EmpID] AND T7.[AgeID] = T1.[AgeID] AND T7.[BodCod] = T1.[BodCod] AND T7.[PrdCod] = T1.[PrdCod]) WHERE T1.[EmpID] = @AV6EmpID and T1.[ClienteID] = @AV7ClienteID" ;
          def= new CursorDef[] {
              new CursorDef("H005Q5", cmdBufferH005Q5,false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005Q5,11,0,true,false )
             ,new CursorDef("H005Q9", cmdBufferH005Q9,false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005Q9,1,0,true,false )
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
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((String[]) buf[9])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((String[]) buf[12])[0] = rslt.getString(9, 40) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                ((short[]) buf[14])[0] = rslt.getShort(10) ;
                ((short[]) buf[15])[0] = rslt.getShort(11) ;
                ((short[]) buf[16])[0] = rslt.getShort(12) ;
                ((short[]) buf[17])[0] = rslt.getShort(13) ;
                ((decimal[]) buf[18])[0] = rslt.getDecimal(14) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(14);
                ((decimal[]) buf[20])[0] = rslt.getDecimal(15) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(15);
                ((decimal[]) buf[22])[0] = rslt.getDecimal(16) ;
                ((decimal[]) buf[23])[0] = rslt.getDecimal(17) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(17);
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
