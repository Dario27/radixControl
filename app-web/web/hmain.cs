/*
               File: HMain
        Description: Radix Control ver. 1.0
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:15:16.61
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
   public class hmain : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public hmain( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public hmain( IGxContext context )
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
         this.AV5empcod = aP0_empcod;
         this.AV6agecod = aP1_agecod;
         this.AV7UsuCod = aP2_UsuCod;
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
               AV5empcod = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5empcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5empcod), 3, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV5empcod), "ZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV6agecod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6agecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6agecod), 3, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGECOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6agecod), "ZZ9"), context));
                  AV7UsuCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7UsuCod", AV7UsuCod);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7UsuCod, "")), context));
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
            PA222( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS222( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE222( ) ;
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
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, false);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( "Radix Control ver. 1.0") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022102620151663", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.WriteHtmlText(  "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         GXEncryptionTmp = "hmain.aspx"+UrlEncode("" +AV5empcod) + "," + UrlEncode("" +AV6agecod) + "," + UrlEncode(StringUtil.RTrim(AV7UsuCod));
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"\" data-gx-class=\"\" novalidate action=\""+formatLink("hmain.aspx") + "?" + Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "", true);
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
         GxWebStd.gx_hidden_field( context, "vEMPCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5empcod), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV5empcod), "ZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGECOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6agecod), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGECOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6agecod), "ZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV7UsuCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7UsuCod, "")), context));
      }

      protected void RenderHtmlCloseForm222( )
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
         if ( ! ( WebComp_Head == null ) )
         {
            WebComp_Head.componentjscripts();
         }
         if ( ! ( WebComp_Menuhor == null ) )
         {
            WebComp_Menuhor.componentjscripts();
         }
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "HMain" ;
      }

      public override String GetPgmdesc( )
      {
         return "Radix Control ver. 1.0" ;
      }

      protected void WB220( )
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
            wb_table1_2_222( true) ;
         }
         else
         {
            wb_table1_2_222( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_222e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true;
      }

      protected void START222( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Radix Control ver. 1.0", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP220( ) ;
      }

      protected void WS222( )
      {
         START222( ) ;
         EVT222( ) ;
      }

      protected void EVT222( )
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
                           E11222 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E12222 ();
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
                     if ( nCmpId == 10 )
                     {
                        OldHead = cgiGet( "W0010");
                        if ( ( StringUtil.Len( OldHead) == 0 ) || ( StringUtil.StrCmp(OldHead, WebComp_Head_Component) != 0 ) )
                        {
                           WebComp_Head = getWebComponent(GetType(), "GeneXus.Programs", OldHead, new Object[] {context} );
                           WebComp_Head.ComponentInit();
                           WebComp_Head.Name = "OldHead";
                           WebComp_Head_Component = OldHead;
                        }
                        if ( StringUtil.Len( WebComp_Head_Component) != 0 )
                        {
                           WebComp_Head.componentprocess("W0010", "", sEvt);
                        }
                        WebComp_Head_Component = OldHead;
                     }
                     else if ( nCmpId == 13 )
                     {
                        OldMenuhor = cgiGet( "W0013");
                        if ( ( StringUtil.Len( OldMenuhor) == 0 ) || ( StringUtil.StrCmp(OldMenuhor, WebComp_Menuhor_Component) != 0 ) )
                        {
                           WebComp_Menuhor = getWebComponent(GetType(), "GeneXus.Programs", OldMenuhor, new Object[] {context} );
                           WebComp_Menuhor.ComponentInit();
                           WebComp_Menuhor.Name = "OldMenuhor";
                           WebComp_Menuhor_Component = OldMenuhor;
                        }
                        if ( StringUtil.Len( WebComp_Menuhor_Component) != 0 )
                        {
                           WebComp_Menuhor.componentprocess("W0013", "", sEvt);
                        }
                        WebComp_Menuhor_Component = OldMenuhor;
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE222( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm222( ) ;
            }
         }
      }

      protected void PA222( )
      {
         if ( nDonePA == 0 )
         {
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
            }
            if ( ( GxWebError == 0 ) && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               GXDecQS = Decrypt64( context.GetRequestQueryString( ), GXKey);
               if ( ( StringUtil.StrCmp(StringUtil.Right( GXDecQS, 6), Crypto.CheckSum( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)), 6)) == 0 ) && ( StringUtil.StrCmp(StringUtil.Substring( GXDecQS, 1, StringUtil.Len( "hmain.aspx")), "hmain.aspx") == 0 ) )
               {
                  SetQueryString( StringUtil.Right( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)), (short)(StringUtil.Len( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)))-StringUtil.Len( "hmain.aspx")))) ;
               }
               else
               {
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               }
            }
            if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               if ( nGotPars == 0 )
               {
                  entryPointCalled = false;
                  gxfirstwebparm = GetNextPar( );
                  if ( context.isSpaRequest( ) )
                  {
                     disableJsOutput();
                  }
                  if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
                  {
                     AV5empcod = (short)(NumberUtil.Val( gxfirstwebparm, "."));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5empcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5empcod), 3, 0)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV5empcod), "ZZ9"), context));
                     if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
                     {
                        AV6agecod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6agecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6agecod), 3, 0)));
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGECOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6agecod), "ZZ9"), context));
                        AV7UsuCod = GetNextPar( );
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7UsuCod", AV7UsuCod);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7UsuCod, "")), context));
                     }
                  }
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
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
         RF222( ) ;
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

      protected void RF222( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Head_Component) != 0 )
               {
                  WebComp_Head.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Menuhor_Component) != 0 )
               {
                  WebComp_Menuhor.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E12222 ();
            WB220( ) ;
         }
      }

      protected void send_integrity_lvl_hashes222( )
      {
      }

      protected void STRUP220( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11222 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
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
         E11222 ();
         if (returnInSub) return;
      }

      protected void E11222( )
      {
         /* Start Routine */
         /* Object Property */
         if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Head_Component), StringUtil.Lower( "WCHeader1")) != 0 )
         {
            WebComp_Head = getWebComponent(GetType(), "GeneXus.Programs", "wcheader1", new Object[] {context} );
            WebComp_Head.ComponentInit();
            WebComp_Head.Name = "WCHeader1";
            WebComp_Head_Component = "WCHeader1";
         }
         if ( StringUtil.Len( WebComp_Head_Component) != 0 )
         {
            WebComp_Head.setjustcreated();
            WebComp_Head.componentprepare(new Object[] {(String)"W0010",(String)"",(short)AV5empcod,(short)AV6agecod,(String)AV7UsuCod});
            WebComp_Head.componentbind(new Object[] {(String)"",(String)"",(String)""});
         }
         /* Object Property */
         if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Menuhor_Component), StringUtil.Lower( "WCMenuHor")) != 0 )
         {
            WebComp_Menuhor = getWebComponent(GetType(), "GeneXus.Programs", "wcmenuhor", new Object[] {context} );
            WebComp_Menuhor.ComponentInit();
            WebComp_Menuhor.Name = "WCMenuHor";
            WebComp_Menuhor_Component = "WCMenuHor";
         }
         if ( StringUtil.Len( WebComp_Menuhor_Component) != 0 )
         {
            WebComp_Menuhor.setjustcreated();
            WebComp_Menuhor.componentprepare(new Object[] {(String)"W0013",(String)"",(short)AV5empcod,(short)AV6agecod,(String)AV7UsuCod});
            WebComp_Menuhor.componentbind(new Object[] {(String)"",(String)"",(String)""});
         }
         epEmb1_Source = formatLink("frames.html") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, epEmb1_Internalname, "Source", epEmb1_Source, true);
      }

      protected void nextLoad( )
      {
      }

      protected void E12222( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_222( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";";
            GxWebStd.gx_table_start( context, tblTablemainmenu_Internalname, tblTablemainmenu_Internalname, "", "MainTable", 0, "center", "", 0, 0, sStyleString, "none", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr style=\""+CSSHelper.Prettify( "vertical-align:top")+"\" class=''>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "height:67px;width:100%")+"\" class='ContainerFluid HeaderContainer'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Radix Control v1.0", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockHeader", 0, "", 1, 1, 0, "HLP_HMain.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='HeaderContainer'>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 7,'',false,'',0)\"";
            ClassString = "BtnLogOf";
            StyleString = "border-width:0;";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Cerrar Sesion", bttButton1_Jsonclick, 7, "Cerrar Sesion", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e13221_client"+"'", TempTags, "", 2, "HLP_HMain.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\""+CSSHelper.Prettify( "height:2%;width:100%")+"\">") ;
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0010"+"", StringUtil.RTrim( WebComp_Head_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0010"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Head_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldHead), StringUtil.Lower( WebComp_Head_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0010"+"");
                  }
                  WebComp_Head.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldHead), StringUtil.Lower( WebComp_Head_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr style=\""+CSSHelper.Prettify( "vertical-align:top")+"\">") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\""+CSSHelper.Prettify( "height:2%;width:100%")+"\">") ;
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0013"+"", StringUtil.RTrim( WebComp_Menuhor_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0013"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Menuhor_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldMenuhor), StringUtil.Lower( WebComp_Menuhor_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0013"+"");
                  }
                  WebComp_Menuhor.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldMenuhor), StringUtil.Lower( WebComp_Menuhor_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            /* Embedded Page */
            GxWebStd.gx_embedded_page( context, epEmb1_Internalname, epEmb1_Source, 1, 100, "%", 65, "vh", 0, "left", "", "no");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_222e( true) ;
         }
         else
         {
            wb_table1_2_222e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV5empcod = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5empcod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5empcod), 3, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV5empcod), "ZZ9"), context));
         AV6agecod = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6agecod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6agecod), 3, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGECOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6agecod), "ZZ9"), context));
         AV7UsuCod = (String)getParm(obj,2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7UsuCod", AV7UsuCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV7UsuCod, "")), context));
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
         PA222( ) ;
         WS222( ) ;
         WE222( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), false);
         if ( ! ( WebComp_Head == null ) )
         {
            if ( StringUtil.Len( WebComp_Head_Component) != 0 )
            {
               WebComp_Head.componentthemes();
            }
         }
         if ( ! ( WebComp_Menuhor == null ) )
         {
            if ( StringUtil.Len( WebComp_Menuhor_Component) != 0 )
            {
               WebComp_Menuhor.componentthemes();
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022102620151670", true);
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
         context.AddJavascriptSource("hmain.js", "?2022102620151670", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         bttButton1_Internalname = "BUTTON1";
         epEmb1_Internalname = "EMB1";
         tblTablemainmenu_Internalname = "TABLEMAINMENU";
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
         epEmb1_Source = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV5empcod',fld:'vEMPCOD',pic:'ZZ9',hsh:true},{av:'AV6agecod',fld:'vAGECOD',pic:'ZZ9',hsh:true},{av:'AV7UsuCod',fld:'vUSUCOD',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'LOGIN'","{handler:'E13221',iparms:[]");
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
         wcpOAV7UsuCod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GXEncryptionTmp = "";
         GX_FocusControl = "";
         sPrefix = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         OldHead = "";
         WebComp_Head_Component = "";
         OldMenuhor = "";
         WebComp_Menuhor_Component = "";
         GXDecQS = "";
         sStyleString = "";
         lblTextblock1_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttButton1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         WebComp_Head = new GeneXus.Http.GXNullWebComponent();
         WebComp_Menuhor = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV5empcod ;
      private short AV6agecod ;
      private short wcpOAV5empcod ;
      private short wcpOAV6agecod ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short nGXWrapped ;
      private int idxLst ;
      private String AV7UsuCod ;
      private String wcpOAV7UsuCod ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String OldHead ;
      private String WebComp_Head_Component ;
      private String OldMenuhor ;
      private String WebComp_Menuhor_Component ;
      private String GXDecQS ;
      private String epEmb1_Source ;
      private String epEmb1_Internalname ;
      private String sStyleString ;
      private String tblTablemainmenu_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GXWebComponent WebComp_Head ;
      private GXWebComponent WebComp_Menuhor ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

}
