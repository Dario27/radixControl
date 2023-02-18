/*
               File: ProcesosOrdenProd
        Description: Procesos Orden Prod
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:15:56.64
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
   public class procesosordenprod : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public procesosordenprod( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public procesosordenprod( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           short aP1_ageID ,
                           String aP2_UsuCod )
      {
         this.AV7empID = aP0_empID;
         this.AV5ageID = aP1_ageID;
         this.AV10UsuCod = aP2_UsuCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavCorte = new GXCheckbox();
         chkavEstructura = new GXCheckbox();
         chkavDoblado = new GXCheckbox();
         chkavForrado = new GXCheckbox();
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
               nRC_GXsfl_13 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_13_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_13_idx = GetNextPar( );
               chkavForrado.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavForrado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavForrado.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
               chkavDoblado.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavDoblado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavDoblado.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
               chkavEstructura.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavEstructura_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavEstructura.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
               chkavCorte.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCorte_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavCorte.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
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
               chkavForrado.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavForrado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavForrado.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
               chkavDoblado.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavDoblado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavDoblado.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
               chkavEstructura.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavEstructura_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavEstructura.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
               chkavCorte.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCorte_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavCorte.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
               A115OrdenEst = GetNextPar( );
               n115OrdenEst = false;
               A57ClienteDsc = GetNextPar( );
               n57ClienteDsc = false;
               A22OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( A115OrdenEst, A57ClienteDsc, A22OrdenID, AV7empID) ;
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
               AV7empID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empID), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV5ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5ageID), 4, 0)));
                  AV10UsuCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10UsuCod", AV10UsuCod);
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
            PA282( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS282( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE282( ) ;
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
         context.SendWebValue( "Procesos Orden Prod") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231141155669", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("procesosordenprod.aspx") + "?" + UrlEncode("" +AV7empID) + "," + UrlEncode("" +AV5ageID) + "," + UrlEncode(StringUtil.RTrim(AV10UsuCod))+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         }
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
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_13", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_13), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENEST", StringUtil.RTrim( A115OrdenEst));
         GxWebStd.gx_hidden_field( context, "CLIENTEDSC", StringUtil.RTrim( A57ClienteDsc));
         GxWebStd.gx_hidden_field( context, "ORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5ageID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV10UsuCod));
         GxWebStd.gx_hidden_field( context, "vFORRADO_Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavForrado.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vDOBLADO_Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavDoblado.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vESTRUCTURA_Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavEstructura.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCORTE_Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavCorte.Enabled), 5, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm282( )
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

      public override String GetPgmname( )
      {
         return "ProcesosOrdenProd" ;
      }

      public override String GetPgmdesc( )
      {
         return "Procesos Orden Prod" ;
      }

      protected void WB280( )
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
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "ContainerFluid WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "nav");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Orden por Procesos ", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_ProcesosOrdenProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "nav");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"13\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "#Orden") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cliente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "corte") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "estructura") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "doblado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "forrado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", "WorkWith");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ordenID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV6clienteDsc));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV9corte));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavCorte.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV11estructura));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavEstructura.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV12doblado));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavDoblado.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV13forrado));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavForrado.Enabled), 5, 0, ".", "")));
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
         if ( wbEnd == 13 )
         {
            wbEnd = 0;
            nRC_GXsfl_13 = (short)(nGXsfl_13_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 13 )
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

      protected void START282( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Procesos Orden Prod", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP280( ) ;
      }

      protected void WS282( )
      {
         START282( ) ;
         EVT282( ) ;
      }

      protected void EVT282( )
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
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                        {
                           nGXsfl_13_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
                           SubsflControlProps_132( ) ;
                           AV8ordenID = (short)(context.localUtil.CToN( cgiGet( edtavOrdenid_Internalname), ",", "."));
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavOrdenid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ordenID), 4, 0)));
                           AV6clienteDsc = cgiGet( edtavClientedsc_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavClientedsc_Internalname, AV6clienteDsc);
                           AV9corte = ((StringUtil.StrCmp(cgiGet( chkavCorte_Internalname), "S")==0) ? "S" : "N");
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavCorte_Internalname, AV9corte);
                           AV11estructura = ((StringUtil.StrCmp(cgiGet( chkavEstructura_Internalname), "S")==0) ? "S" : "N");
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavEstructura_Internalname, AV11estructura);
                           AV12doblado = ((StringUtil.StrCmp(cgiGet( chkavDoblado_Internalname), "S")==0) ? "S" : "N");
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavDoblado_Internalname, AV12doblado);
                           AV13forrado = ((StringUtil.StrCmp(cgiGet( chkavForrado_Internalname), "S")==0) ? "S" : "N");
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavForrado_Internalname, AV13forrado);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E11282 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E12282 ();
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

      protected void WE282( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm282( ) ;
            }
         }
      }

      protected void PA282( )
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

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_132( ) ;
         while ( nGXsfl_13_idx <= nRC_GXsfl_13 )
         {
            sendrow_132( ) ;
            nGXsfl_13_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_13_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_13_idx+1));
            sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
            SubsflControlProps_132( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( String A115OrdenEst ,
                                        String A57ClienteDsc ,
                                        short A22OrdenID ,
                                        short AV7empID )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF282( ) ;
         /* End function gxgrGrid1_refresh */
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
         RF282( ) ;
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

      protected void RF282( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 13;
         nGXsfl_13_idx = 1;
         sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
         SubsflControlProps_132( ) ;
         bGXsfl_13_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "WorkWith");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_132( ) ;
            E11282 ();
            wbEnd = 13;
            WB280( ) ;
         }
         bGXsfl_13_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes282( )
      {
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empID), "ZZZ9"), context));
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP280( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E12282 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_13 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_13"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      private void E11282( )
      {
         /* Grid1_Load Routine */
         /* Using cursor H00282 */
         pr_default.execute(0, new Object[] {AV7empID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A5ClienteID = H00282_A5ClienteID[0];
            A1EmpID = H00282_A1EmpID[0];
            A115OrdenEst = H00282_A115OrdenEst[0];
            n115OrdenEst = H00282_n115OrdenEst[0];
            A57ClienteDsc = H00282_A57ClienteDsc[0];
            n57ClienteDsc = H00282_n57ClienteDsc[0];
            A22OrdenID = H00282_A22OrdenID[0];
            A57ClienteDsc = H00282_A57ClienteDsc[0];
            n57ClienteDsc = H00282_n57ClienteDsc[0];
            AV6clienteDsc = A57ClienteDsc;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavClientedsc_Internalname, AV6clienteDsc);
            AV8ordenID = A22OrdenID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavOrdenid_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV8ordenID), 4, 0)));
            AV13forrado = "S";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavForrado_Internalname, AV13forrado);
            AV12doblado = "N";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavDoblado_Internalname, AV12doblado);
            AV11estructura = "S";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavEstructura_Internalname, AV11estructura);
            AV9corte = "N";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavCorte_Internalname, AV9corte);
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 13;
            }
            sendrow_132( ) ;
            if ( isFullAjaxMode( ) && ! bGXsfl_13_Refreshing )
            {
               context.DoAjaxLoad(13, Grid1Row);
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         /*  Sending Event outputs  */
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E12282 ();
         if (returnInSub) return;
      }

      protected void E12282( )
      {
         /* Start Routine */
         chkavForrado.Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavForrado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavForrado.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
         chkavDoblado.Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavDoblado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavDoblado.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
         chkavEstructura.Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavEstructura_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavEstructura.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
         chkavCorte.Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCorte_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavCorte.Enabled), 5, 0)), !bGXsfl_13_Refreshing);
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7empID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7empID), "ZZZ9"), context));
         AV5ageID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5ageID), 4, 0)));
         AV10UsuCod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10UsuCod", AV10UsuCod);
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
         PA282( ) ;
         WS282( ) ;
         WE282( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2023114115570", true);
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
            context.AddJavascriptSource("messages.spa.js", "?"+GetCacheInvalidationToken( ), false);
            context.AddJavascriptSource("procesosordenprod.js", "?2023114115570", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_132( )
      {
         edtavOrdenid_Internalname = "vORDENID_"+sGXsfl_13_idx;
         edtavClientedsc_Internalname = "vCLIENTEDSC_"+sGXsfl_13_idx;
         chkavCorte_Internalname = "vCORTE_"+sGXsfl_13_idx;
         chkavEstructura_Internalname = "vESTRUCTURA_"+sGXsfl_13_idx;
         chkavDoblado_Internalname = "vDOBLADO_"+sGXsfl_13_idx;
         chkavForrado_Internalname = "vFORRADO_"+sGXsfl_13_idx;
      }

      protected void SubsflControlProps_fel_132( )
      {
         edtavOrdenid_Internalname = "vORDENID_"+sGXsfl_13_fel_idx;
         edtavClientedsc_Internalname = "vCLIENTEDSC_"+sGXsfl_13_fel_idx;
         chkavCorte_Internalname = "vCORTE_"+sGXsfl_13_fel_idx;
         chkavEstructura_Internalname = "vESTRUCTURA_"+sGXsfl_13_fel_idx;
         chkavDoblado_Internalname = "vDOBLADO_"+sGXsfl_13_fel_idx;
         chkavForrado_Internalname = "vFORRADO_"+sGXsfl_13_fel_idx;
      }

      protected void sendrow_132( )
      {
         SubsflControlProps_132( ) ;
         WB280( ) ;
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
            if ( ((int)(((nGXsfl_13_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
            context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_13_idx+"\">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavOrdenid_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8ordenID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(AV8ordenID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavOrdenid_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)13,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavClientedsc_Internalname,StringUtil.RTrim( AV6clienteDsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavClientedsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)13,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavCorte.Enabled!=0)&&(chkavCorte.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 16,'',false,'"+sGXsfl_13_idx+"',13)\"" : " ");
         ClassString = "Attribute";
         StyleString = "";
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavCorte_Internalname,(String)AV9corte,(String)"",(String)"",(short)-1,chkavCorte.Enabled,(String)"S",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(16, this, 'S', 'N');gx.evt.onchange(this, event);\" "});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavEstructura.Enabled!=0)&&(chkavEstructura.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 17,'',false,'"+sGXsfl_13_idx+"',13)\"" : " ");
         ClassString = "Attribute";
         StyleString = "";
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavEstructura_Internalname,(String)AV11estructura,(String)"",(String)"",(short)-1,chkavEstructura.Enabled,(String)"S",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(17, this, 'S', 'N');gx.evt.onchange(this, event);\" "});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavDoblado.Enabled!=0)&&(chkavDoblado.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 18,'',false,'"+sGXsfl_13_idx+"',13)\"" : " ");
         ClassString = "Attribute";
         StyleString = "";
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavDoblado_Internalname,(String)AV12doblado,(String)"",(String)"",(short)-1,chkavDoblado.Enabled,(String)"S",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(18, this, 'S', 'N');gx.evt.onchange(this, event);\" "});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavForrado.Enabled!=0)&&(chkavForrado.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 19,'',false,'"+sGXsfl_13_idx+"',13)\"" : " ");
         ClassString = "Attribute";
         StyleString = "";
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavForrado_Internalname,(String)AV13forrado,(String)"",(String)"",(short)-1,chkavForrado.Enabled,(String)"S",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(19, this, 'S', 'N');gx.evt.onchange(this, event);\" "});
         send_integrity_lvl_hashes282( ) ;
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_13_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_13_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_13_idx+1));
         sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0");
         SubsflControlProps_132( ) ;
         /* End function sendrow_132 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "vCORTE_" + sGXsfl_13_idx;
         chkavCorte.Name = GXCCtl;
         chkavCorte.WebTags = "";
         chkavCorte.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCorte_Internalname, "TitleCaption", chkavCorte.Caption, !bGXsfl_13_Refreshing);
         chkavCorte.CheckedValue = "N";
         GXCCtl = "vESTRUCTURA_" + sGXsfl_13_idx;
         chkavEstructura.Name = GXCCtl;
         chkavEstructura.WebTags = "";
         chkavEstructura.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavEstructura_Internalname, "TitleCaption", chkavEstructura.Caption, !bGXsfl_13_Refreshing);
         chkavEstructura.CheckedValue = "N";
         GXCCtl = "vDOBLADO_" + sGXsfl_13_idx;
         chkavDoblado.Name = GXCCtl;
         chkavDoblado.WebTags = "";
         chkavDoblado.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavDoblado_Internalname, "TitleCaption", chkavDoblado.Caption, !bGXsfl_13_Refreshing);
         chkavDoblado.CheckedValue = "N";
         GXCCtl = "vFORRADO_" + sGXsfl_13_idx;
         chkavForrado.Name = GXCCtl;
         chkavForrado.WebTags = "";
         chkavForrado.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavForrado_Internalname, "TitleCaption", chkavForrado.Caption, !bGXsfl_13_Refreshing);
         chkavForrado.CheckedValue = "N";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         divSection1_Internalname = "SECTION1";
         edtavOrdenid_Internalname = "vORDENID";
         edtavClientedsc_Internalname = "vCLIENTEDSC";
         chkavCorte_Internalname = "vCORTE";
         chkavEstructura_Internalname = "vESTRUCTURA";
         chkavDoblado_Internalname = "vDOBLADO";
         chkavForrado_Internalname = "vFORRADO";
         divTable1_Internalname = "TABLE1";
         divMaintable_Internalname = "MAINTABLE";
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
         chkavForrado.Caption = "";
         chkavDoblado.Caption = "";
         chkavEstructura.Caption = "";
         chkavCorte.Caption = "";
         chkavForrado.Visible = -1;
         chkavDoblado.Visible = -1;
         chkavEstructura.Visible = -1;
         chkavCorte.Visible = -1;
         edtavClientedsc_Jsonclick = "";
         edtavOrdenid_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         subGrid1_Header = "";
         subGrid1_Class = "WorkWith";
         subGrid1_Backcolorstyle = 0;
         chkavCorte.Enabled = 0;
         chkavEstructura.Enabled = 0;
         chkavDoblado.Enabled = 0;
         chkavForrado.Enabled = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'chkavForrado.Enabled',ctrl:'vFORRADO',prop:'Enabled'},{av:'chkavDoblado.Enabled',ctrl:'vDOBLADO',prop:'Enabled'},{av:'chkavEstructura.Enabled',ctrl:'vESTRUCTURA',prop:'Enabled'},{av:'chkavCorte.Enabled',ctrl:'vCORTE',prop:'Enabled'},{av:'A115OrdenEst',fld:'ORDENEST',pic:''},{av:'A57ClienteDsc',fld:'CLIENTEDSC',pic:''},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9'},{av:'AV7empID',fld:'vEMPID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRID1.LOAD","{handler:'E11282',iparms:[{av:'A115OrdenEst',fld:'ORDENEST',pic:''},{av:'A57ClienteDsc',fld:'CLIENTEDSC',pic:''},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9'},{av:'AV7empID',fld:'vEMPID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID1.LOAD",",oparms:[{av:'AV6clienteDsc',fld:'vCLIENTEDSC',pic:''},{av:'AV8ordenID',fld:'vORDENID',pic:'ZZZ9'},{av:'AV13forrado',fld:'vFORRADO',pic:''},{av:'AV12doblado',fld:'vDOBLADO',pic:''},{av:'AV11estructura',fld:'vESTRUCTURA',pic:''},{av:'AV9corte',fld:'vCORTE',pic:''}]}");
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
         wcpOAV10UsuCod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A115OrdenEst = "";
         A57ClienteDsc = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         sPrefix = "";
         lblTextblock1_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV6clienteDsc = "";
         AV9corte = "";
         AV11estructura = "";
         AV12doblado = "";
         AV13forrado = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H00282_A24OrdenPeriodo = new short[1] ;
         H00282_A25OrdenAnio = new short[1] ;
         H00282_A5ClienteID = new short[1] ;
         H00282_A1EmpID = new short[1] ;
         H00282_A115OrdenEst = new String[] {""} ;
         H00282_n115OrdenEst = new bool[] {false} ;
         H00282_A57ClienteDsc = new String[] {""} ;
         H00282_n57ClienteDsc = new bool[] {false} ;
         H00282_A22OrdenID = new short[1] ;
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.procesosordenprod__default(),
            new Object[][] {
                new Object[] {
               H00282_A24OrdenPeriodo, H00282_A25OrdenAnio, H00282_A5ClienteID, H00282_A1EmpID, H00282_A115OrdenEst, H00282_n115OrdenEst, H00282_A57ClienteDsc, H00282_n57ClienteDsc, H00282_A22OrdenID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV7empID ;
      private short AV5ageID ;
      private short wcpOAV7empID ;
      private short wcpOAV5ageID ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_13 ;
      private short nGXsfl_13_idx=1 ;
      private short A22OrdenID ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short AV8ordenID ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A5ClienteID ;
      private short A1EmpID ;
      private short subGrid1_Backstyle ;
      private short GRID1_nEOF ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nFirstRecordOnPage ;
      private String AV10UsuCod ;
      private String wcpOAV10UsuCod ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_13_idx="0001" ;
      private String chkavForrado_Internalname ;
      private String chkavDoblado_Internalname ;
      private String chkavEstructura_Internalname ;
      private String chkavCorte_Internalname ;
      private String A115OrdenEst ;
      private String A57ClienteDsc ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable1_Internalname ;
      private String divSection1_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String subGrid1_Header ;
      private String AV6clienteDsc ;
      private String AV9corte ;
      private String AV11estructura ;
      private String AV12doblado ;
      private String AV13forrado ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavOrdenid_Internalname ;
      private String edtavClientedsc_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_13_fel_idx="0001" ;
      private String ROClassString ;
      private String edtavOrdenid_Jsonclick ;
      private String edtavClientedsc_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String GXCCtl ;
      private bool entryPointCalled ;
      private bool bGXsfl_13_Refreshing=false ;
      private bool n115OrdenEst ;
      private bool n57ClienteDsc ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavCorte ;
      private GXCheckbox chkavEstructura ;
      private GXCheckbox chkavDoblado ;
      private GXCheckbox chkavForrado ;
      private IDataStoreProvider pr_default ;
      private short[] H00282_A24OrdenPeriodo ;
      private short[] H00282_A25OrdenAnio ;
      private short[] H00282_A5ClienteID ;
      private short[] H00282_A1EmpID ;
      private String[] H00282_A115OrdenEst ;
      private bool[] H00282_n115OrdenEst ;
      private String[] H00282_A57ClienteDsc ;
      private bool[] H00282_n57ClienteDsc ;
      private short[] H00282_A22OrdenID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class procesosordenprod__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00282 ;
          prmH00282 = new Object[] {
          new Object[] {"@AV7empID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00282", "SELECT T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[ClienteID], T1.[EmpID], T1.[OrdenEst], T2.[ClienteDsc], T1.[OrdenID] FROM ([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) WHERE T1.[EmpID] = @AV7empID ORDER BY T1.[EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00282,100,0,false,false )
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
                ((String[]) buf[4])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((String[]) buf[6])[0] = rslt.getString(6, 50) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
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
       }
    }

 }

}
