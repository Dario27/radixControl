/*
               File: WCHeader1
        Description: WCHeader1
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 0:42:30.26
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
   public class wcheader1 : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public wcheader1( )
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

      public wcheader1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empcod ,
                           short aP1_agecod ,
                           String aP2_UsuCod )
      {
         this.AV10empcod = aP0_empcod;
         this.AV5agecod = aP1_agecod;
         this.AV20UsuCod = aP2_UsuCod;
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
                  AV10empcod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10empcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10empcod), 3, 0)));
                  AV5agecod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5agecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5agecod), 3, 0)));
                  AV20UsuCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20UsuCod", AV20UsuCod);
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)AV10empcod,(short)AV5agecod,(String)AV20UsuCod});
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
            PA232( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               edtavEmpresa_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavEmpresa_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEmpresa_Enabled), 5, 0)), true);
               edtavAgencia_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavAgencia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAgencia_Enabled), 5, 0)), true);
               edtavUsername_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUsername_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsername_Enabled), 5, 0)), true);
               WS232( ) ;
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
            context.SendWebValue( "WCHeader1") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231110423031", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wcheader1.aspx") + "?" + UrlEncode("" +AV10empcod) + "," + UrlEncode("" +AV5agecod) + "," + UrlEncode(StringUtil.RTrim(AV20UsuCod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV10empcod", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV10empcod), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV5agecod", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV5agecod), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV20UsuCod", StringUtil.RTrim( wcpOAV20UsuCod));
         GxWebStd.gx_hidden_field( context, sPrefix+"vEMPCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10empcod), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vAGECOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5agecod), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vUSUCOD", StringUtil.RTrim( AV20UsuCod));
      }

      protected void RenderHtmlCloseForm232( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("wcheader1.js", "?20231110423034", false);
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
         return "WCHeader1" ;
      }

      public override String GetPgmdesc( )
      {
         return "WCHeader1" ;
      }

      protected void WB230( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wcheader1.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable4_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row TableRow", "left", "top", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-4 col-lg-1", "left", "middle", "", "", "div");
            /* Static images/pictures */
            ClassString = "ImageLogoHeader";
            StyleString = "";
            sImgUrl = imgLogo1_Bitmap;
            GxWebStd.gx_bitmap( context, imgLogo1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgLogo1_Visible, 1, "", "", 0, 0, 120, "px", 90, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WCHeader1.htm");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-lg-5", "left", "middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-offset-1", "left", "middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEmpresa_Internalname, "Descripción Empresa", "col-sm-3 AttributeTitleLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEmpresa_Internalname, StringUtil.RTrim( AV12empresa), StringUtil.RTrim( context.localUtil.Format( AV12empresa, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEmpresa_Jsonclick, 0, "AttributeTitle", "color:#404040;", "", "", "", 1, edtavEmpresa_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WCHeader1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-offset-1", "left", "middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAgencia_Internalname, "agencia", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavAgencia_Internalname, StringUtil.RTrim( AV6agencia), StringUtil.RTrim( context.localUtil.Format( AV6agencia, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,20);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavAgencia_Jsonclick, 0, "Attribute", "color:#404040;", "", "", "", 1, edtavAgencia_Enabled, 0, "text", "", 185, "px", 13, "px", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WCHeader1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-offset-1", "left", "middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUsername_Internalname, "Usuario :", "col-sm-3 TextAttributeUserHeaderLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsername_Internalname, AV17userName, StringUtil.RTrim( context.localUtil.Format( AV17userName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,24);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUsername_Jsonclick, 0, "TextAttributeUserHeader", "", "", "", "", 1, edtavUsername_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WCHeader1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-lg-5", "left", "middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable3_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnLogOf";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnlogout_Internalname, "", "Cerrar Sesion", bttBtnlogout_Jsonclick, 7, "Cerrar Sesion", "", StyleString, ClassString, bttBtnlogout_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e11231_client"+"'", TempTags, "", 2, "HLP_WCHeader1.htm");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblAgencias_Internalname, "Empresas/Agencias", "", lblAgencias_Linktarget, lblAgencias_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "color:#000040;", "TextBlock", 0, "", lblAgencias_Visible, 1, 0, "HLP_WCHeader1.htm");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "middle", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblSubmenu_Internalname, "SubMenu", "", lblSubmenu_Linktarget, lblSubmenu_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "color:#000040;", "TextBlock", 0, "", lblSubmenu_Visible, 1, 0, "HLP_WCHeader1.htm");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "middle", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "middle", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "middle", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START232( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
               Form.Meta.addItem("description", "WCHeader1", 0) ;
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
               STRUP230( ) ;
            }
         }
      }

      protected void WS232( )
      {
         START232( ) ;
         EVT232( ) ;
      }

      protected void EVT232( )
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
                                 STRUP230( ) ;
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
                                 STRUP230( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E12232 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP230( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E13232 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP230( ) ;
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
                                 STRUP230( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavEmpresa_Internalname;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
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

      protected void WE232( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm232( ) ;
            }
         }
      }

      protected void PA232( )
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
               GX_FocusControl = edtavEmpresa_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
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
         RF232( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavEmpresa_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavEmpresa_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEmpresa_Enabled), 5, 0)), true);
         edtavAgencia_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavAgencia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAgencia_Enabled), 5, 0)), true);
         edtavUsername_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUsername_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsername_Enabled), 5, 0)), true);
      }

      protected void RF232( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E13232 ();
            WB230( ) ;
         }
      }

      protected void send_integrity_lvl_hashes232( )
      {
      }

      protected void STRUP230( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavEmpresa_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavEmpresa_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEmpresa_Enabled), 5, 0)), true);
         edtavAgencia_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavAgencia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAgencia_Enabled), 5, 0)), true);
         edtavUsername_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUsername_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsername_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E12232 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV12empresa = StringUtil.Upper( cgiGet( edtavEmpresa_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12empresa", AV12empresa);
            AV6agencia = StringUtil.Upper( cgiGet( edtavAgencia_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6agencia", AV6agencia);
            AV17userName = cgiGet( edtavUsername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17userName", AV17userName);
            /* Read saved values. */
            wcpOAV10empcod = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV10empcod"), ",", "."));
            wcpOAV5agecod = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV5agecod"), ",", "."));
            wcpOAV20UsuCod = cgiGet( sPrefix+"wcpOAV20UsuCod");
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
         E12232 ();
         if (returnInSub) return;
      }

      protected void E12232( )
      {
         /* Start Routine */
         /* Execute user subroutine: 'EMPRESA' */
         S112 ();
         if (returnInSub) return;
         /* Execute user subroutine: 'NAMEUSER' */
         S122 ();
         if (returnInSub) return;
         if ( StringUtil.StrCmp(AV11emplogo, "") != 0 )
         {
            imgLogo1_Bitmap = AV11emplogo;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgLogo1_Internalname, "Bitmap", context.convertURL( context.PathToRelativeUrl( imgLogo1_Bitmap)), true);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgLogo1_Internalname, "SrcSet", context.GetImageSrcSet( imgLogo1_Bitmap), true);
            imgLogo1_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgLogo1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgLogo1_Visible), 5, 0)), true);
         }
         else
         {
            imgLogo1_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgLogo1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgLogo1_Visible), 5, 0)), true);
         }
         lblAgencias_Linktarget = "ppal";
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblAgencias_Internalname, "Linktarget", lblAgencias_Linktarget, true);
         lblSubmenu_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblSubmenu_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblSubmenu_Visible), 5, 0)), true);
         lblAgencias_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblAgencias_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblAgencias_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(AV20UsuCod, "ADM") == 0 ) || ( StringUtil.StrCmp(AV20UsuCod, "adm") == 0 ) )
         {
            lblSubmenu_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblSubmenu_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblSubmenu_Visible), 5, 0)), true);
            lblSubmenu_Linktarget = "ppal";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblSubmenu_Internalname, "Linktarget", lblSubmenu_Linktarget, true);
            lblAgencias_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblAgencias_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblAgencias_Visible), 5, 0)), true);
            lblSubmenu_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblSubmenu_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblSubmenu_Visible), 5, 0)), true);
         }
         bttBtnlogout_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtnlogout_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnlogout_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'EMPRESA' Routine */
         /* Using cursor H00232 */
         pr_default.execute(0, new Object[] {AV10empcod, AV5agecod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A2AgeID = H00232_A2AgeID[0];
            A1EmpID = H00232_A1EmpID[0];
            A44empdsc = H00232_A44empdsc[0];
            n44empdsc = H00232_n44empdsc[0];
            A46AgeDsc = H00232_A46AgeDsc[0];
            n46AgeDsc = H00232_n46AgeDsc[0];
            A97emplogo = H00232_A97emplogo[0];
            n97emplogo = H00232_n97emplogo[0];
            A44empdsc = H00232_A44empdsc[0];
            n44empdsc = H00232_n44empdsc[0];
            A97emplogo = H00232_A97emplogo[0];
            n97emplogo = H00232_n97emplogo[0];
            AV12empresa = A44empdsc;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12empresa", AV12empresa);
            AV6agencia = A46AgeDsc;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6agencia", AV6agencia);
            AV11emplogo = A97emplogo;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11emplogo", AV11emplogo);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
      }

      protected void S122( )
      {
         /* 'NAMEUSER' Routine */
         /* Using cursor H00233 */
         pr_default.execute(1, new Object[] {AV20UsuCod});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A3UsuCod = H00233_A3UsuCod[0];
            A53UsuRol = H00233_A53UsuRol[0];
            n53UsuRol = H00233_n53UsuRol[0];
            A86UsuNivel = H00233_A86UsuNivel[0];
            n86UsuNivel = H00233_n86UsuNivel[0];
            A50UsuName = H00233_A50UsuName[0];
            n50UsuName = H00233_n50UsuName[0];
            AV21UsuNivel = A86UsuNivel;
            AV17userName = StringUtil.Trim( A50UsuName);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17userName", AV17userName);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
      }

      protected void nextLoad( )
      {
      }

      protected void E13232( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10empcod = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10empcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10empcod), 3, 0)));
         AV5agecod = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5agecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5agecod), 3, 0)));
         AV20UsuCod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20UsuCod", AV20UsuCod);
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
         PA232( ) ;
         WS232( ) ;
         WE232( ) ;
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
         sCtrlAV10empcod = (String)((String)getParm(obj,0));
         sCtrlAV5agecod = (String)((String)getParm(obj,1));
         sCtrlAV20UsuCod = (String)((String)getParm(obj,2));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA232( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "wcheader1", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA232( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV10empcod = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10empcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10empcod), 3, 0)));
            AV5agecod = Convert.ToInt16(getParm(obj,3));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5agecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5agecod), 3, 0)));
            AV20UsuCod = (String)getParm(obj,4);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20UsuCod", AV20UsuCod);
         }
         wcpOAV10empcod = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV10empcod"), ",", "."));
         wcpOAV5agecod = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV5agecod"), ",", "."));
         wcpOAV20UsuCod = cgiGet( sPrefix+"wcpOAV20UsuCod");
         if ( ! GetJustCreated( ) && ( ( AV10empcod != wcpOAV10empcod ) || ( AV5agecod != wcpOAV5agecod ) || ( StringUtil.StrCmp(AV20UsuCod, wcpOAV20UsuCod) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV10empcod = AV10empcod;
         wcpOAV5agecod = AV5agecod;
         wcpOAV20UsuCod = AV20UsuCod;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV10empcod = cgiGet( sPrefix+"AV10empcod_CTRL");
         if ( StringUtil.Len( sCtrlAV10empcod) > 0 )
         {
            AV10empcod = (short)(context.localUtil.CToN( cgiGet( sCtrlAV10empcod), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10empcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10empcod), 3, 0)));
         }
         else
         {
            AV10empcod = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV10empcod_PARM"), ",", "."));
         }
         sCtrlAV5agecod = cgiGet( sPrefix+"AV5agecod_CTRL");
         if ( StringUtil.Len( sCtrlAV5agecod) > 0 )
         {
            AV5agecod = (short)(context.localUtil.CToN( cgiGet( sCtrlAV5agecod), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5agecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5agecod), 3, 0)));
         }
         else
         {
            AV5agecod = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV5agecod_PARM"), ",", "."));
         }
         sCtrlAV20UsuCod = cgiGet( sPrefix+"AV20UsuCod_CTRL");
         if ( StringUtil.Len( sCtrlAV20UsuCod) > 0 )
         {
            AV20UsuCod = cgiGet( sCtrlAV20UsuCod);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20UsuCod", AV20UsuCod);
         }
         else
         {
            AV20UsuCod = cgiGet( sPrefix+"AV20UsuCod_PARM");
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
         PA232( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS232( ) ;
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
         WS232( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV10empcod_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10empcod), 3, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV10empcod)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV10empcod_CTRL", StringUtil.RTrim( sCtrlAV10empcod));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV5agecod_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5agecod), 3, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV5agecod)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV5agecod_CTRL", StringUtil.RTrim( sCtrlAV5agecod));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV20UsuCod_PARM", StringUtil.RTrim( AV20UsuCod));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV20UsuCod)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV20UsuCod_CTRL", StringUtil.RTrim( sCtrlAV20UsuCod));
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
         WE232( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231110423095", true);
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
         context.AddJavascriptSource("wcheader1.js", "?20231110423095", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         imgLogo1_Internalname = sPrefix+"LOGO1";
         edtavEmpresa_Internalname = sPrefix+"vEMPRESA";
         edtavAgencia_Internalname = sPrefix+"vAGENCIA";
         edtavUsername_Internalname = sPrefix+"vUSERNAME";
         divTable1_Internalname = sPrefix+"TABLE1";
         bttBtnlogout_Internalname = sPrefix+"BTNLOGOUT";
         lblAgencias_Internalname = sPrefix+"AGENCIAS";
         lblSubmenu_Internalname = sPrefix+"SUBMENU";
         divTable3_Internalname = sPrefix+"TABLE3";
         divTable4_Internalname = sPrefix+"TABLE4";
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
         lblSubmenu_Linktarget = "";
         lblSubmenu_Visible = 1;
         lblAgencias_Linktarget = "";
         lblAgencias_Visible = 1;
         bttBtnlogout_Visible = 1;
         edtavUsername_Jsonclick = "";
         edtavUsername_Enabled = 1;
         edtavAgencia_Jsonclick = "";
         edtavAgencia_Enabled = 1;
         edtavEmpresa_Jsonclick = "";
         edtavEmpresa_Enabled = 1;
         imgLogo1_Visible = 1;
         imgLogo1_Bitmap = "(none)";
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
         setEventMetadata("'LOGIN'","{handler:'E11231',iparms:[]");
         setEventMetadata("'LOGIN'",",oparms:[]}");
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
         wcpOAV20UsuCod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         sImgUrl = "";
         TempTags = "";
         AV12empresa = "";
         AV6agencia = "";
         AV17userName = "";
         bttBtnlogout_Jsonclick = "";
         lblAgencias_Jsonclick = "";
         lblSubmenu_Jsonclick = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV11emplogo = "";
         scmdbuf = "";
         H00232_A2AgeID = new short[1] ;
         H00232_A1EmpID = new short[1] ;
         H00232_A44empdsc = new String[] {""} ;
         H00232_n44empdsc = new bool[] {false} ;
         H00232_A46AgeDsc = new String[] {""} ;
         H00232_n46AgeDsc = new bool[] {false} ;
         H00232_A97emplogo = new String[] {""} ;
         H00232_n97emplogo = new bool[] {false} ;
         A44empdsc = "";
         A46AgeDsc = "";
         A97emplogo = "";
         H00233_A3UsuCod = new String[] {""} ;
         H00233_A53UsuRol = new String[] {""} ;
         H00233_n53UsuRol = new bool[] {false} ;
         H00233_A86UsuNivel = new String[] {""} ;
         H00233_n86UsuNivel = new bool[] {false} ;
         H00233_A50UsuName = new String[] {""} ;
         H00233_n50UsuName = new bool[] {false} ;
         A3UsuCod = "";
         A53UsuRol = "";
         A86UsuNivel = "";
         A50UsuName = "";
         AV21UsuNivel = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV10empcod = "";
         sCtrlAV5agecod = "";
         sCtrlAV20UsuCod = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wcheader1__default(),
            new Object[][] {
                new Object[] {
               H00232_A2AgeID, H00232_A1EmpID, H00232_A44empdsc, H00232_n44empdsc, H00232_A46AgeDsc, H00232_n46AgeDsc, H00232_A97emplogo, H00232_n97emplogo
               }
               , new Object[] {
               H00233_A3UsuCod, H00233_A53UsuRol, H00233_n53UsuRol, H00233_A86UsuNivel, H00233_n86UsuNivel, H00233_A50UsuName, H00233_n50UsuName
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavEmpresa_Enabled = 0;
         edtavAgencia_Enabled = 0;
         edtavUsername_Enabled = 0;
      }

      private short AV10empcod ;
      private short AV5agecod ;
      private short wcpOAV10empcod ;
      private short wcpOAV5agecod ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short nGXWrapped ;
      private int edtavEmpresa_Enabled ;
      private int edtavAgencia_Enabled ;
      private int edtavUsername_Enabled ;
      private int imgLogo1_Visible ;
      private int bttBtnlogout_Visible ;
      private int lblAgencias_Visible ;
      private int lblSubmenu_Visible ;
      private int idxLst ;
      private String AV20UsuCod ;
      private String wcpOAV20UsuCod ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String edtavEmpresa_Internalname ;
      private String edtavAgencia_Internalname ;
      private String edtavUsername_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String divTable4_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String sImgUrl ;
      private String imgLogo1_Internalname ;
      private String divTable1_Internalname ;
      private String TempTags ;
      private String AV12empresa ;
      private String edtavEmpresa_Jsonclick ;
      private String AV6agencia ;
      private String edtavAgencia_Jsonclick ;
      private String edtavUsername_Jsonclick ;
      private String divTable3_Internalname ;
      private String bttBtnlogout_Internalname ;
      private String bttBtnlogout_Jsonclick ;
      private String lblAgencias_Internalname ;
      private String lblAgencias_Linktarget ;
      private String lblAgencias_Jsonclick ;
      private String lblSubmenu_Internalname ;
      private String lblSubmenu_Linktarget ;
      private String lblSubmenu_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV11emplogo ;
      private String scmdbuf ;
      private String A46AgeDsc ;
      private String A97emplogo ;
      private String A3UsuCod ;
      private String A53UsuRol ;
      private String A86UsuNivel ;
      private String AV21UsuNivel ;
      private String sCtrlAV10empcod ;
      private String sCtrlAV5agecod ;
      private String sCtrlAV20UsuCod ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool n44empdsc ;
      private bool n46AgeDsc ;
      private bool n97emplogo ;
      private bool n53UsuRol ;
      private bool n86UsuNivel ;
      private bool n50UsuName ;
      private String AV17userName ;
      private String A44empdsc ;
      private String A50UsuName ;
      private String imgLogo1_Bitmap ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H00232_A2AgeID ;
      private short[] H00232_A1EmpID ;
      private String[] H00232_A44empdsc ;
      private bool[] H00232_n44empdsc ;
      private String[] H00232_A46AgeDsc ;
      private bool[] H00232_n46AgeDsc ;
      private String[] H00232_A97emplogo ;
      private bool[] H00232_n97emplogo ;
      private String[] H00233_A3UsuCod ;
      private String[] H00233_A53UsuRol ;
      private bool[] H00233_n53UsuRol ;
      private String[] H00233_A86UsuNivel ;
      private bool[] H00233_n86UsuNivel ;
      private String[] H00233_A50UsuName ;
      private bool[] H00233_n50UsuName ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class wcheader1__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00232 ;
          prmH00232 = new Object[] {
          new Object[] {"@AV10empcod",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV5agecod",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH00233 ;
          prmH00233 = new Object[] {
          new Object[] {"@AV20UsuCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00232", "SELECT T1.[AgeID], T1.[EmpID], T2.[empdsc], T1.[AgeDsc], T2.[emplogo] FROM ([Agencias] T1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID]) WHERE T1.[EmpID] = @AV10empcod and T1.[AgeID] = @AV5agecod ORDER BY T1.[EmpID], T1.[AgeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00232,1,0,false,true )
             ,new CursorDef("H00233", "SELECT [UsuCod], [UsuRol], [UsuNivel], [UsuName] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @AV20UsuCod ORDER BY [UsuCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00233,1,0,false,true )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 80) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 5) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
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
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
