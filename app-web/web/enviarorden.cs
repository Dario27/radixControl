/*
               File: EnviarOrden
        Description: Enviar Orden
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 0:43:56.50
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
using GeneXus.Mail;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class enviarorden : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public enviarorden( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public enviarorden( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           short aP1_OrdenID ,
                           short aP2_ClienteID ,
                           String aP3_userCod )
      {
         this.AV21empID = aP0_empID;
         this.AV31OrdenID = aP1_OrdenID;
         this.AV12ClienteID = aP2_ClienteID;
         this.AV43userCod = aP3_userCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavClienteid = new GXCombobox();
         chkavCc = new GXCheckbox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vCLIENTEID") == 0 )
            {
               AV21empID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21empID), "ZZZ9"), context));
               AV12ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12ClienteID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12ClienteID), "ZZZ9"), context));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvCLIENTEID272( AV21empID, AV12ClienteID) ;
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
               AV21empID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21empID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21empID), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV31OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31OrdenID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV31OrdenID), "ZZZ9"), context));
                  AV12ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12ClienteID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12ClienteID), "ZZZ9"), context));
                  AV43userCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43userCod", AV43userCod);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV43userCod, "")), context));
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
            PA272( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               GXVvCLIENTEID_html272( AV21empID, AV12ClienteID) ;
               WS272( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE272( ) ;
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
         context.SendWebValue( "Enviar Orden") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231110435656", false);
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
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("enviarorden.aspx") + "?" + UrlEncode("" +AV21empID) + "," + UrlEncode("" +AV31OrdenID) + "," + UrlEncode("" +AV12ClienteID) + "," + UrlEncode(StringUtil.RTrim(AV43userCod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV31OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12ClienteID), "ZZZ9"), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vDATOSOK", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15DatosOk), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "USUCOD", StringUtil.RTrim( A3UsuCod));
         GxWebStd.gx_hidden_field( context, "vUSERCOD", StringUtil.RTrim( AV43userCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV43userCod, "")), context));
         GxWebStd.gx_hidden_field( context, "USUSMTP", StringUtil.RTrim( A91UsuSMTP));
         GxWebStd.gx_hidden_field( context, "USUPUERTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A92UsuPuerto), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "USUNAME", A50UsuName);
         GxWebStd.gx_hidden_field( context, "USUCORREO", StringUtil.RTrim( A90UsuCorreo));
         GxWebStd.gx_hidden_field( context, "USUCLAVECORREO", StringUtil.RTrim( A138UsuClaveCorreo));
         GxWebStd.gx_hidden_field( context, "EMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "CLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENEST", StringUtil.RTrim( A115OrdenEst));
         GxWebStd.gx_hidden_field( context, "CLIENTEDSC", StringUtil.RTrim( A57ClienteDsc));
         GxWebStd.gx_hidden_field( context, "FACTURANRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A106facturaNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENEMPFAC", StringUtil.LTrim( StringUtil.NToC( (decimal)(A132OrdenEmpFac), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "VEHICULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VehiculoID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TIPORDID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17tipOrdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENMARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26OrdenMarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENMODELOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A117OrdenModeloID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "PROTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSMTP", StringUtil.RTrim( AV39smtp));
         GxWebStd.gx_hidden_field( context, "vUSUNOM", AV46UsuNom);
         GxWebStd.gx_hidden_field( context, "vPUERTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38puerto), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUCORREO", StringUtil.RTrim( AV45UsuCorreo));
         GxWebStd.gx_hidden_field( context, "vUSUCLAVE", StringUtil.RTrim( AV44UsuClave));
         GxWebStd.gx_hidden_field( context, "NAMEDESTINATARIO", A141nameDestinatario);
         GxWebStd.gx_hidden_field( context, "EMAILSDESTINATARIOS", A140emailsDestinatarios);
         GxWebStd.gx_hidden_field( context, "CCDESTINATARIO", A142ccDestinatario);
         GxWebStd.gx_hidden_field( context, "vTIPOORDENDSC", StringUtil.RTrim( AV41tipoOrdenDsc));
         GxWebStd.gx_hidden_field( context, "vEMPDSCFAC", StringUtil.RTrim( AV19empDscFac));
         GxWebStd.gx_hidden_field( context, "vPLACANRO", AV32placaNro);
         GxWebStd.gx_hidden_field( context, "vCHASISNRO", AV11chasisNro);
         GxWebStd.gx_hidden_field( context, "vMODELCAMION", StringUtil.RTrim( AV27modelCamion));
         GxWebStd.gx_hidden_field( context, "vPROTOTIPODSC", StringUtil.RTrim( AV37prototipoDsc));
         GxWebStd.gx_hidden_field( context, "vEMPFAC", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20empFac), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "EMPEST", StringUtil.RTrim( A45EmpEst));
         GxWebStd.gx_hidden_field( context, "EMPDSC", A44empdsc);
         GxWebStd.gx_hidden_field( context, "vVEHID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV47vehID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "VEHICULOEST", StringUtil.RTrim( A67VehiculoEst));
         GxWebStd.gx_hidden_field( context, "VEHICULOPLACA", A68VehiculoPlaca);
         GxWebStd.gx_hidden_field( context, "VEHICULOCHASIS", A69VehiculoChasis);
         GxWebStd.gx_hidden_field( context, "vTIPOORDID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42tipoOrdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TIPORDEST", StringUtil.RTrim( A105tipOrdEst));
         GxWebStd.gx_hidden_field( context, "TIPORDDSC", StringUtil.RTrim( A104tipOrdDsc));
         GxWebStd.gx_hidden_field( context, "MARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6MarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25marcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "MODELOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7ModeloID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODELOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28modeloID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "MODELODSC", StringUtil.RTrim( A64ModeloDsc));
         GxWebStd.gx_hidden_field( context, "vPROTIPOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV36protipoID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "PROTEST", StringUtil.RTrim( A75protEst));
         GxWebStd.gx_hidden_field( context, "PROTDSC", StringUtil.RTrim( A74protDsc));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21empID), "ZZZ9"), context));
      }

      protected void RenderHtmlCloseForm272( )
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
         return "EnviarOrden" ;
      }

      public override String GetPgmdesc( )
      {
         return "Enviar Orden" ;
      }

      protected void WB270( )
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
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-8 col-lg-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable4_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 col-lg-8 col-lg-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTop_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-9 col-lg-offset-1", "Center", "Middle", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Envio ordenes x Correo", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_EnviarOrden.htm");
            GxWebStd.gx_div_end( context, "Center", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-8 col-lg-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavOrdenid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavOrdenid_Internalname, "Orden ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavOrdenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31OrdenID), 4, 0, ",", "")), ((edtavOrdenid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV31OrdenID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV31OrdenID), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdenid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavOrdenid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_EnviarOrden.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavClienteid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavClienteid_Internalname, "Cliente", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavClienteid, dynavClienteid_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV12ClienteID), 4, 0)), 1, dynavClienteid_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavClienteid.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_EnviarOrden.htm");
            dynavClienteid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV12ClienteID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavClienteid_Internalname, "Values", (String)(dynavClienteid.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSubject_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSubject_Internalname, "Asunto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSubject_Internalname, AV40subject, StringUtil.RTrim( context.localUtil.Format( AV40subject, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Asunto correo", edtavSubject_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSubject_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_EnviarOrden.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavAditionalmnsj_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavAditionalmnsj_Internalname, "Mensaje Adicional", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavAditionalmnsj_Internalname, AV5AditionalMnsj, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, 1, edtavAditionalmnsj_Enabled, 0, 80, "chr", 1, "row", StyleString, ClassString, "", "", "100", -1, 3, "", "Escribe un mensaje adicional", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_EnviarOrden.htm");
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
            GxWebStd.gx_label_element( context, chkavCc_Internalname, "cc", "col-sm-3 AttributeLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCc_Internalname, AV7cc, "", "cc", 1, chkavCc.Enabled, "S", "Envío CC", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(39, this, 'S', 'N');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnok_Internalname, "", "Enviar", bttBtnok_Jsonclick, 5, "Enviar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'ACEPTAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_EnviarOrden.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "Cancelar", bttBtncancel_Jsonclick, 5, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CANCELAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_EnviarOrden.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START272( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Enviar Orden", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP270( ) ;
      }

      protected void WS272( )
      {
         START272( ) ;
         EVT272( ) ;
      }

      protected void EVT272( )
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
                        else if ( StringUtil.StrCmp(sEvt, "'ACEPTAR'") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'Aceptar' */
                           E11272 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E12272 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'CANCELAR'") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'Cancelar' */
                           E13272 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E14272 ();
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
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE272( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm272( ) ;
            }
         }
      }

      protected void PA272( )
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
               GX_FocusControl = edtavSubject_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvCLIENTEID272( short AV21empID ,
                                         short AV12ClienteID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvCLIENTEID_data272( AV21empID, AV12ClienteID) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXVvCLIENTEID_html272( short AV21empID ,
                                            short AV12ClienteID )
      {
         short gxdynajaxvalue ;
         GXDLVvCLIENTEID_data272( AV21empID, AV12ClienteID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavClienteid.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavClienteid.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvCLIENTEID_data272( short AV21empID ,
                                              short AV12ClienteID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Todos");
         /* Using cursor H00272 */
         pr_default.execute(0, new Object[] {AV21empID, AV12ClienteID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H00272_A5ClienteID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H00272_A57ClienteDsc[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            GXVvCLIENTEID_html272( AV21empID, AV12ClienteID) ;
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( dynavClienteid.ItemCount > 0 )
         {
            AV12ClienteID = (short)(NumberUtil.Val( dynavClienteid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV12ClienteID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12ClienteID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12ClienteID), "ZZZ9"), context));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavClienteid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV12ClienteID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavClienteid_Internalname, "Values", dynavClienteid.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF272( ) ;
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

      protected void RF272( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E14272 ();
            WB270( ) ;
         }
      }

      protected void send_integrity_lvl_hashes272( )
      {
         GxWebStd.gx_hidden_field( context, "vUSERCOD", StringUtil.RTrim( AV43userCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV43userCod, "")), context));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21empID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21empID), "ZZZ9"), context));
      }

      protected void STRUP270( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         GXVvCLIENTEID_html272( AV21empID, AV12ClienteID) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E12272 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV40subject = cgiGet( edtavSubject_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40subject", AV40subject);
            AV5AditionalMnsj = cgiGet( edtavAditionalmnsj_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5AditionalMnsj", AV5AditionalMnsj);
            AV7cc = ((StringUtil.StrCmp(cgiGet( chkavCc_Internalname), "S")==0) ? "S" : "N");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cc", AV7cc);
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            GXVvCLIENTEID_html272( AV21empID, AV12ClienteID) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E11272( )
      {
         /* 'Aceptar' Routine */
         /* Execute user subroutine: 'DATOSCORREO' */
         S112 ();
         if (returnInSub) return;
         if ( AV15DatosOk == 1 )
         {
            /* Execute user subroutine: 'ENVIOCORREO' */
            S122 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E12272 ();
         if (returnInSub) return;
      }

      protected void E12272( )
      {
         /* Start Routine */
      }

      protected void E13272( )
      {
         /* 'Cancelar' Routine */
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void S112( )
      {
         /* 'DATOSCORREO' Routine */
         /* Using cursor H00273 */
         pr_default.execute(1, new Object[] {AV43userCod});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A3UsuCod = H00273_A3UsuCod[0];
            A91UsuSMTP = H00273_A91UsuSMTP[0];
            n91UsuSMTP = H00273_n91UsuSMTP[0];
            A92UsuPuerto = H00273_A92UsuPuerto[0];
            n92UsuPuerto = H00273_n92UsuPuerto[0];
            A50UsuName = H00273_A50UsuName[0];
            n50UsuName = H00273_n50UsuName[0];
            A90UsuCorreo = H00273_A90UsuCorreo[0];
            n90UsuCorreo = H00273_n90UsuCorreo[0];
            A138UsuClaveCorreo = H00273_A138UsuClaveCorreo[0];
            n138UsuClaveCorreo = H00273_n138UsuClaveCorreo[0];
            AV39smtp = StringUtil.Trim( A91UsuSMTP);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39smtp", AV39smtp);
            AV38puerto = A92UsuPuerto;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38puerto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38puerto), 4, 0)));
            AV46UsuNom = StringUtil.Trim( A50UsuName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46UsuNom", AV46UsuNom);
            AV45UsuCorreo = StringUtil.Trim( A90UsuCorreo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45UsuCorreo", AV45UsuCorreo);
            AV44UsuClave = StringUtil.Trim( A138UsuClaveCorreo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44UsuClave", AV44UsuClave);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         if ( ( StringUtil.StrCmp(AV45UsuCorreo, "") != 0 ) && ( StringUtil.StrCmp(AV44UsuClave, "") != 0 ) && ( StringUtil.StrCmp(AV39smtp, "") != 0 ) && ( AV38puerto != 0 ) )
         {
            AV15DatosOk = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15DatosOk", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15DatosOk), 4, 0)));
         }
      }

      protected void S132( )
      {
         /* 'EMPRESAS' Routine */
         /* Using cursor H00274 */
         pr_default.execute(2, new Object[] {AV20empFac});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A1EmpID = H00274_A1EmpID[0];
            A45EmpEst = H00274_A45EmpEst[0];
            n45EmpEst = H00274_n45EmpEst[0];
            A44empdsc = H00274_A44empdsc[0];
            n44empdsc = H00274_n44empdsc[0];
            AV19empDscFac = StringUtil.Trim( A44empdsc);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19empDscFac", AV19empDscFac);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
      }

      protected void S142( )
      {
         /* 'INFOVEHICULOS' Routine */
         /* Using cursor H00275 */
         pr_default.execute(3, new Object[] {AV21empID, AV47vehID});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A8VehiculoID = H00275_A8VehiculoID[0];
            A1EmpID = H00275_A1EmpID[0];
            A67VehiculoEst = H00275_A67VehiculoEst[0];
            n67VehiculoEst = H00275_n67VehiculoEst[0];
            A68VehiculoPlaca = H00275_A68VehiculoPlaca[0];
            n68VehiculoPlaca = H00275_n68VehiculoPlaca[0];
            A69VehiculoChasis = H00275_A69VehiculoChasis[0];
            n69VehiculoChasis = H00275_n69VehiculoChasis[0];
            AV32placaNro = A68VehiculoPlaca;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32placaNro", AV32placaNro);
            AV11chasisNro = A69VehiculoChasis;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11chasisNro", AV11chasisNro);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(3);
      }

      protected void S152( )
      {
         /* 'INFOTIPOORDEN' Routine */
         /* Using cursor H00276 */
         pr_default.execute(4, new Object[] {AV21empID, AV42tipoOrdID});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A17tipOrdID = H00276_A17tipOrdID[0];
            A1EmpID = H00276_A1EmpID[0];
            A105tipOrdEst = H00276_A105tipOrdEst[0];
            n105tipOrdEst = H00276_n105tipOrdEst[0];
            A104tipOrdDsc = H00276_A104tipOrdDsc[0];
            n104tipOrdDsc = H00276_n104tipOrdDsc[0];
            AV41tipoOrdenDsc = A104tipOrdDsc;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41tipoOrdenDsc", AV41tipoOrdenDsc);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(4);
      }

      protected void S162( )
      {
         /* 'INFOMARCAMODELO' Routine */
         /* Using cursor H00277 */
         pr_default.execute(5, new Object[] {AV21empID, AV25marcaID, AV28modeloID});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A7ModeloID = H00277_A7ModeloID[0];
            A6MarcaID = H00277_A6MarcaID[0];
            A1EmpID = H00277_A1EmpID[0];
            A64ModeloDsc = H00277_A64ModeloDsc[0];
            n64ModeloDsc = H00277_n64ModeloDsc[0];
            AV27modelCamion = A64ModeloDsc;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27modelCamion", AV27modelCamion);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(5);
      }

      protected void S172( )
      {
         /* 'INFOPROTOTIPO' Routine */
         /* Using cursor H00278 */
         pr_default.execute(6, new Object[] {AV21empID, AV36protipoID});
         while ( (pr_default.getStatus(6) != 101) )
         {
            A10protID = H00278_A10protID[0];
            A1EmpID = H00278_A1EmpID[0];
            A75protEst = H00278_A75protEst[0];
            n75protEst = H00278_n75protEst[0];
            A74protDsc = H00278_A74protDsc[0];
            n74protDsc = H00278_n74protDsc[0];
            AV37prototipoDsc = A74protDsc;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37prototipoDsc", AV37prototipoDsc);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(6);
      }

      protected void S122( )
      {
         /* 'ENVIOCORREO' Routine */
         AV30ok2 = "";
         AV56GXLvl81 = 0;
         /* Using cursor H00279 */
         pr_default.execute(7, new Object[] {AV21empID, AV31OrdenID, AV12ClienteID});
         while ( (pr_default.getStatus(7) != 101) )
         {
            A1EmpID = H00279_A1EmpID[0];
            A22OrdenID = H00279_A22OrdenID[0];
            A5ClienteID = H00279_A5ClienteID[0];
            A115OrdenEst = H00279_A115OrdenEst[0];
            n115OrdenEst = H00279_n115OrdenEst[0];
            A57ClienteDsc = H00279_A57ClienteDsc[0];
            n57ClienteDsc = H00279_n57ClienteDsc[0];
            A106facturaNro = H00279_A106facturaNro[0];
            n106facturaNro = H00279_n106facturaNro[0];
            A132OrdenEmpFac = H00279_A132OrdenEmpFac[0];
            n132OrdenEmpFac = H00279_n132OrdenEmpFac[0];
            A8VehiculoID = H00279_A8VehiculoID[0];
            A17tipOrdID = H00279_A17tipOrdID[0];
            A26OrdenMarcaID = H00279_A26OrdenMarcaID[0];
            A117OrdenModeloID = H00279_A117OrdenModeloID[0];
            A10protID = H00279_A10protID[0];
            A57ClienteDsc = H00279_A57ClienteDsc[0];
            n57ClienteDsc = H00279_n57ClienteDsc[0];
            AV56GXLvl81 = 1;
            AV13clienteName = A57ClienteDsc;
            AV24facturaNro = A106facturaNro;
            AV20empFac = A132OrdenEmpFac;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20empFac", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20empFac), 4, 0)));
            AV47vehID = A8VehiculoID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47vehID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV47vehID), 4, 0)));
            AV42tipoOrdID = A17tipOrdID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42tipoOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42tipoOrdID), 4, 0)));
            AV25marcaID = A26OrdenMarcaID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25marcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25marcaID), 4, 0)));
            AV28modeloID = A117OrdenModeloID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28modeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28modeloID), 4, 0)));
            AV36protipoID = A10protID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36protipoID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36protipoID), 4, 0)));
            /* Execute user subroutine: 'EMPRESAS' */
            S132 ();
            if ( returnInSub )
            {
               pr_default.close(7);
               returnInSub = true;
               if (true) return;
            }
            /* Execute user subroutine: 'INFOVEHICULOS' */
            S142 ();
            if ( returnInSub )
            {
               pr_default.close(7);
               returnInSub = true;
               if (true) return;
            }
            /* Execute user subroutine: 'INFOTIPOORDEN' */
            S152 ();
            if ( returnInSub )
            {
               pr_default.close(7);
               returnInSub = true;
               if (true) return;
            }
            /* Execute user subroutine: 'INFOMARCAMODELO' */
            S162 ();
            if ( returnInSub )
            {
               pr_default.close(7);
               returnInSub = true;
               if (true) return;
            }
            /* Execute user subroutine: 'INFOPROTOTIPO' */
            S172 ();
            if ( returnInSub )
            {
               pr_default.close(7);
               returnInSub = true;
               if (true) return;
            }
            AV30ok2 = "S";
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(7);
         }
         pr_default.close(7);
         if ( AV56GXLvl81 == 0 )
         {
            AV30ok2 = "N";
         }
         if ( StringUtil.StrCmp(AV30ok2, "S") == 0 )
         {
            AV26MensSMTP.ErrDisplay = 1;
            AV26MensSMTP.Host = AV39smtp;
            AV26MensSMTP.Sender.Name = AV46UsuNom;
            AV26MensSMTP.Secure = 1;
            AV26MensSMTP.Authentication = 1;
            AV26MensSMTP.Port = AV38puerto;
            AV26MensSMTP.Sender.Address = AV45UsuCorreo;
            AV26MensSMTP.UserName = AV45UsuCorreo;
            AV26MensSMTP.Password = AV44UsuClave;
            AV23Error = AV26MensSMTP.Login();
            if ( AV23Error != 0 )
            {
               GX_msglist.addItem("error: "+StringUtil.Str( (decimal)(AV23Error), 4, 0));
               GX_msglist.addItem("Error No. : "+StringUtil.Str( (decimal)(NumberUtil.Int( AV26MensSMTP.ErrCode)), 10, 0)+" , "+AV26MensSMTP.ErrDescription);
            }
            else
            {
               AV22Envio.To.Clear();
               /* Using cursor H002710 */
               pr_default.execute(8, new Object[] {AV43userCod});
               while ( (pr_default.getStatus(8) != 101) )
               {
                  A3UsuCod = H002710_A3UsuCod[0];
                  A140emailsDestinatarios = H002710_A140emailsDestinatarios[0];
                  n140emailsDestinatarios = H002710_n140emailsDestinatarios[0];
                  A141nameDestinatario = H002710_A141nameDestinatario[0];
                  n141nameDestinatario = H002710_n141nameDestinatario[0];
                  A142ccDestinatario = H002710_A142ccDestinatario[0];
                  n142ccDestinatario = H002710_n142ccDestinatario[0];
                  AV18emailDestino = A140emailsDestinatarios;
                  AV29nameDestino = A141nameDestinatario;
                  AV9CCDestinatario = A142ccDestinatario;
                  AV17DirTo.Address = StringUtil.Trim( AV18emailDestino);
                  AV17DirTo.Name = StringUtil.Trim( AV29nameDestino);
                  AV22Envio.To.Add(AV17DirTo);
                  pr_default.readNext(8);
               }
               pr_default.close(8);
               if ( StringUtil.StrCmp(AV7cc, "S") == 0 )
               {
                  AV8CCAux = AV9CCDestinatario;
                  AV22Envio.CC.Clear();
                  while ( StringUtil.Len( AV8CCAux) > 0 )
                  {
                     AV34PosIni = 1;
                     AV35PosSep = (short)(StringUtil.StringSearch( AV8CCAux, ";", AV34PosIni));
                     if ( AV35PosSep == 0 )
                     {
                        AV33PosFin = (short)(StringUtil.Len( AV8CCAux));
                     }
                     else
                     {
                        AV33PosFin = (short)(AV35PosSep-1);
                     }
                     AV10CCDestinatario1 = StringUtil.Substring( AV8CCAux, AV34PosIni, AV33PosFin);
                     AV16DirCc.Address = AV10CCDestinatario1;
                     AV22Envio.CC.Add(AV16DirCc);
                     AV34PosIni = (short)(AV35PosSep+1);
                     AV33PosFin = (short)(StringUtil.Len( AV8CCAux)-AV33PosFin);
                     AV8CCAux = StringUtil.Substring( AV8CCAux, AV34PosIni, AV33PosFin);
                  }
               }
               AV22Envio.Subject = StringUtil.Trim( AV40subject);
               AV22Envio.HTMLText = "<p>Estimados:</p> <p>A continuación envio informe de la orden de trabajo:</p>"+"<b><p>Tipo de Orden: "+AV41tipoOrdenDsc+"</p></b>"+"<b><p>Nro. Orden: "+StringUtil.Str( (decimal)(AV31OrdenID), 4, 0)+"</p></b>"+"<b><p>Cliente: "+AV13clienteName+"</p></b>"+"<b><p>Factura Nro.: "+StringUtil.Str( (decimal)(AV24facturaNro), 8, 0)+"</p></b>"+"<b><p>Empresa que Factura: "+AV19empDscFac+"</p></b>"+"<b><p>Nro. Placa: "+AV32placaNro+"</p></b>"+"<b><p>Nro. Chasis: "+AV11chasisNro+"</p></b>"+"<b><p>Modelo Camion: "+AV27modelCamion+"</p></b>"+"<b><p>Prototipo: "+AV37prototipoDsc+"</p></b>"+"<br/>"+"<b><p>Mensaje adicional: "+AV5AditionalMnsj+".</p></b>"+"<br/>"+"<p>Atentamente,</p>"+"<p>"+AV46UsuNom+"</p>";
               AV23Error = AV26MensSMTP.Send(AV22Envio);
               if ( AV23Error != 0 )
               {
                  GX_msglist.addItem("Error No. : "+StringUtil.Str( (decimal)(NumberUtil.Int( AV26MensSMTP.ErrCode)), 10, 0)+" , "+AV26MensSMTP.ErrDescription);
                  GX_msglist.addItem("Correo NO Enviado a :"+AV29nameDestino+"  Correo: "+StringUtil.Trim( AV18emailDestino));
               }
               else
               {
                  GX_msglist.addItem("Correo Enviado con exito!!!!");
               }
               AV26MensSMTP.Logout();
            }
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E14272( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV21empID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21empID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21empID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21empID), "ZZZ9"), context));
         AV31OrdenID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31OrdenID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV31OrdenID), "ZZZ9"), context));
         AV12ClienteID = Convert.ToInt16(getParm(obj,2));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12ClienteID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12ClienteID), "ZZZ9"), context));
         AV43userCod = (String)getParm(obj,3);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43userCod", AV43userCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSERCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV43userCod, "")), context));
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
         PA272( ) ;
         WS272( ) ;
         WE272( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231110435735", true);
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
         context.AddJavascriptSource("enviarorden.js", "?20231110435735", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavClienteid.Name = "vCLIENTEID";
         dynavClienteid.WebTags = "";
         chkavCc.Name = "vCC";
         chkavCc.WebTags = "";
         chkavCc.Caption = "Envío CC";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCc_Internalname, "TitleCaption", chkavCc.Caption, true);
         chkavCc.CheckedValue = "N";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         divTop_Internalname = "TOP";
         edtavOrdenid_Internalname = "vORDENID";
         dynavClienteid_Internalname = "vCLIENTEID";
         edtavSubject_Internalname = "vSUBJECT";
         edtavAditionalmnsj_Internalname = "vADITIONALMNSJ";
         chkavCc_Internalname = "vCC";
         divTable2_Internalname = "TABLE2";
         divTable4_Internalname = "TABLE4";
         bttBtnok_Internalname = "BTNOK";
         bttBtncancel_Internalname = "BTNCANCEL";
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
         chkavCc.Caption = "cc";
         chkavCc.Enabled = 1;
         edtavAditionalmnsj_Enabled = 1;
         edtavSubject_Jsonclick = "";
         edtavSubject_Enabled = 1;
         dynavClienteid_Jsonclick = "";
         dynavClienteid.Enabled = 0;
         edtavOrdenid_Jsonclick = "";
         edtavOrdenid_Enabled = 0;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public void Validv_Clienteid( short GX_Parm1 ,
                                    GXCombobox dynGX_Parm2 )
      {
         AV21empID = GX_Parm1;
         dynavClienteid = dynGX_Parm2;
         AV12ClienteID = (short)(NumberUtil.Val( dynavClienteid.CurrentValue, "."));
         GXVvCLIENTEID_html272( AV21empID, AV12ClienteID) ;
         dynload_actions( ) ;
         if ( dynavClienteid.ItemCount > 0 )
         {
            AV12ClienteID = (short)(NumberUtil.Val( dynavClienteid.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV12ClienteID), 4, 0))), "."));
         }
         dynavClienteid.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV12ClienteID), 4, 0));
         isValidOutput.Add(dynavClienteid);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV43userCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'AV31OrdenID',fld:'vORDENID',pic:'ZZZ9',hsh:true},{av:'AV21empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV12ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV21empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV12ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true}]}");
         setEventMetadata("'ACEPTAR'","{handler:'E11272',iparms:[{av:'AV15DatosOk',fld:'vDATOSOK',pic:'ZZZ9'},{av:'A3UsuCod',fld:'USUCOD',pic:''},{av:'AV43userCod',fld:'vUSERCOD',pic:'',hsh:true},{av:'A91UsuSMTP',fld:'USUSMTP',pic:''},{av:'A92UsuPuerto',fld:'USUPUERTO',pic:'ZZZ9'},{av:'A50UsuName',fld:'USUNAME',pic:''},{av:'A90UsuCorreo',fld:'USUCORREO',pic:''},{av:'A138UsuClaveCorreo',fld:'USUCLAVECORREO',pic:''},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9'},{av:'AV31OrdenID',fld:'vORDENID',pic:'ZZZ9',hsh:true},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'A115OrdenEst',fld:'ORDENEST',pic:''},{av:'A57ClienteDsc',fld:'CLIENTEDSC',pic:''},{av:'A106facturaNro',fld:'FACTURANRO',pic:'ZZZZZZZ9'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'A8VehiculoID',fld:'VEHICULOID',pic:'ZZZ9'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'},{av:'AV39smtp',fld:'vSMTP',pic:''},{av:'AV46UsuNom',fld:'vUSUNOM',pic:''},{av:'AV38puerto',fld:'vPUERTO',pic:'ZZZ9'},{av:'AV45UsuCorreo',fld:'vUSUCORREO',pic:''},{av:'AV44UsuClave',fld:'vUSUCLAVE',pic:''},{av:'A141nameDestinatario',fld:'NAMEDESTINATARIO',pic:''},{av:'A140emailsDestinatarios',fld:'EMAILSDESTINATARIOS',pic:''},{av:'A142ccDestinatario',fld:'CCDESTINATARIO',pic:''},{av:'AV7cc',fld:'vCC',pic:''},{av:'AV40subject',fld:'vSUBJECT',pic:''},{av:'AV41tipoOrdenDsc',fld:'vTIPOORDENDSC',pic:'@!'},{av:'AV19empDscFac',fld:'vEMPDSCFAC',pic:''},{av:'AV32placaNro',fld:'vPLACANRO',pic:''},{av:'AV11chasisNro',fld:'vCHASISNRO',pic:''},{av:'AV27modelCamion',fld:'vMODELCAMION',pic:''},{av:'AV37prototipoDsc',fld:'vPROTOTIPODSC',pic:''},{av:'AV5AditionalMnsj',fld:'vADITIONALMNSJ',pic:''},{av:'AV20empFac',fld:'vEMPFAC',pic:'ZZZ9'},{av:'A45EmpEst',fld:'EMPEST',pic:''},{av:'A44empdsc',fld:'EMPDSC',pic:'@!'},{av:'AV47vehID',fld:'vVEHID',pic:'ZZZ9'},{av:'A67VehiculoEst',fld:'VEHICULOEST',pic:''},{av:'A68VehiculoPlaca',fld:'VEHICULOPLACA',pic:''},{av:'A69VehiculoChasis',fld:'VEHICULOCHASIS',pic:''},{av:'AV42tipoOrdID',fld:'vTIPOORDID',pic:'ZZZ9'},{av:'A105tipOrdEst',fld:'TIPORDEST',pic:''},{av:'A104tipOrdDsc',fld:'TIPORDDSC',pic:'@!'},{av:'A6MarcaID',fld:'MARCAID',pic:'ZZZ9'},{av:'AV25marcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'A7ModeloID',fld:'MODELOID',pic:'ZZZ9'},{av:'AV28modeloID',fld:'vMODELOID',pic:'ZZZ9'},{av:'A64ModeloDsc',fld:'MODELODSC',pic:''},{av:'AV36protipoID',fld:'vPROTIPOID',pic:'ZZZ9'},{av:'A75protEst',fld:'PROTEST',pic:''},{av:'A74protDsc',fld:'PROTDSC',pic:''},{av:'AV21empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV12ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'ACEPTAR'",",oparms:[{av:'AV39smtp',fld:'vSMTP',pic:''},{av:'AV38puerto',fld:'vPUERTO',pic:'ZZZ9'},{av:'AV46UsuNom',fld:'vUSUNOM',pic:''},{av:'AV45UsuCorreo',fld:'vUSUCORREO',pic:''},{av:'AV44UsuClave',fld:'vUSUCLAVE',pic:''},{av:'AV15DatosOk',fld:'vDATOSOK',pic:'ZZZ9'},{av:'AV20empFac',fld:'vEMPFAC',pic:'ZZZ9'},{av:'AV47vehID',fld:'vVEHID',pic:'ZZZ9'},{av:'AV42tipoOrdID',fld:'vTIPOORDID',pic:'ZZZ9'},{av:'AV25marcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'AV28modeloID',fld:'vMODELOID',pic:'ZZZ9'},{av:'AV36protipoID',fld:'vPROTIPOID',pic:'ZZZ9'},{av:'AV19empDscFac',fld:'vEMPDSCFAC',pic:''},{av:'AV32placaNro',fld:'vPLACANRO',pic:''},{av:'AV11chasisNro',fld:'vCHASISNRO',pic:''},{av:'AV41tipoOrdenDsc',fld:'vTIPOORDENDSC',pic:'@!'},{av:'AV27modelCamion',fld:'vMODELCAMION',pic:''},{av:'AV37prototipoDsc',fld:'vPROTOTIPODSC',pic:''},{av:'AV21empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV12ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true}]}");
         setEventMetadata("'CANCELAR'","{handler:'E13272',iparms:[{av:'AV21empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV12ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'CANCELAR'",",oparms:[{av:'AV21empID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynavClienteid'},{av:'AV12ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true}]}");
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
         wcpOAV43userCod = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         A3UsuCod = "";
         A91UsuSMTP = "";
         A50UsuName = "";
         A90UsuCorreo = "";
         A138UsuClaveCorreo = "";
         A115OrdenEst = "";
         A57ClienteDsc = "";
         AV39smtp = "";
         AV46UsuNom = "";
         AV45UsuCorreo = "";
         AV44UsuClave = "";
         A141nameDestinatario = "";
         A140emailsDestinatarios = "";
         A142ccDestinatario = "";
         AV41tipoOrdenDsc = "";
         AV19empDscFac = "";
         AV32placaNro = "";
         AV11chasisNro = "";
         AV27modelCamion = "";
         AV37prototipoDsc = "";
         A45EmpEst = "";
         A44empdsc = "";
         A67VehiculoEst = "";
         A68VehiculoPlaca = "";
         A69VehiculoChasis = "";
         A105tipOrdEst = "";
         A104tipOrdDsc = "";
         A64ModeloDsc = "";
         A75protEst = "";
         A74protDsc = "";
         GX_FocusControl = "";
         sPrefix = "";
         lblTextblock1_Jsonclick = "";
         TempTags = "";
         AV40subject = "";
         ClassString = "";
         StyleString = "";
         AV5AditionalMnsj = "";
         AV7cc = "";
         bttBtnok_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H00272_A5ClienteID = new short[1] ;
         H00272_A57ClienteDsc = new String[] {""} ;
         H00272_n57ClienteDsc = new bool[] {false} ;
         H00272_A1EmpID = new short[1] ;
         H00273_A3UsuCod = new String[] {""} ;
         H00273_A91UsuSMTP = new String[] {""} ;
         H00273_n91UsuSMTP = new bool[] {false} ;
         H00273_A92UsuPuerto = new short[1] ;
         H00273_n92UsuPuerto = new bool[] {false} ;
         H00273_A50UsuName = new String[] {""} ;
         H00273_n50UsuName = new bool[] {false} ;
         H00273_A90UsuCorreo = new String[] {""} ;
         H00273_n90UsuCorreo = new bool[] {false} ;
         H00273_A138UsuClaveCorreo = new String[] {""} ;
         H00273_n138UsuClaveCorreo = new bool[] {false} ;
         H00274_A1EmpID = new short[1] ;
         H00274_A45EmpEst = new String[] {""} ;
         H00274_n45EmpEst = new bool[] {false} ;
         H00274_A44empdsc = new String[] {""} ;
         H00274_n44empdsc = new bool[] {false} ;
         H00275_A8VehiculoID = new short[1] ;
         H00275_A1EmpID = new short[1] ;
         H00275_A67VehiculoEst = new String[] {""} ;
         H00275_n67VehiculoEst = new bool[] {false} ;
         H00275_A68VehiculoPlaca = new String[] {""} ;
         H00275_n68VehiculoPlaca = new bool[] {false} ;
         H00275_A69VehiculoChasis = new String[] {""} ;
         H00275_n69VehiculoChasis = new bool[] {false} ;
         H00276_A17tipOrdID = new short[1] ;
         H00276_A1EmpID = new short[1] ;
         H00276_A105tipOrdEst = new String[] {""} ;
         H00276_n105tipOrdEst = new bool[] {false} ;
         H00276_A104tipOrdDsc = new String[] {""} ;
         H00276_n104tipOrdDsc = new bool[] {false} ;
         H00277_A7ModeloID = new short[1] ;
         H00277_A6MarcaID = new short[1] ;
         H00277_A1EmpID = new short[1] ;
         H00277_A64ModeloDsc = new String[] {""} ;
         H00277_n64ModeloDsc = new bool[] {false} ;
         H00278_A10protID = new short[1] ;
         H00278_A1EmpID = new short[1] ;
         H00278_A75protEst = new String[] {""} ;
         H00278_n75protEst = new bool[] {false} ;
         H00278_A74protDsc = new String[] {""} ;
         H00278_n74protDsc = new bool[] {false} ;
         AV30ok2 = "";
         H00279_A24OrdenPeriodo = new short[1] ;
         H00279_A25OrdenAnio = new short[1] ;
         H00279_A1EmpID = new short[1] ;
         H00279_A22OrdenID = new short[1] ;
         H00279_A5ClienteID = new short[1] ;
         H00279_A115OrdenEst = new String[] {""} ;
         H00279_n115OrdenEst = new bool[] {false} ;
         H00279_A57ClienteDsc = new String[] {""} ;
         H00279_n57ClienteDsc = new bool[] {false} ;
         H00279_A106facturaNro = new int[1] ;
         H00279_n106facturaNro = new bool[] {false} ;
         H00279_A132OrdenEmpFac = new short[1] ;
         H00279_n132OrdenEmpFac = new bool[] {false} ;
         H00279_A8VehiculoID = new short[1] ;
         H00279_A17tipOrdID = new short[1] ;
         H00279_A26OrdenMarcaID = new short[1] ;
         H00279_A117OrdenModeloID = new short[1] ;
         H00279_A10protID = new short[1] ;
         AV13clienteName = "";
         AV26MensSMTP = new GeneXus.Mail.GXSMTPSession(context.GetPhysicalPath());
         AV22Envio = new GeneXus.Mail.GXMailMessage();
         H002710_A29emailID = new short[1] ;
         H002710_A30sec = new short[1] ;
         H002710_A3UsuCod = new String[] {""} ;
         H002710_A140emailsDestinatarios = new String[] {""} ;
         H002710_n140emailsDestinatarios = new bool[] {false} ;
         H002710_A141nameDestinatario = new String[] {""} ;
         H002710_n141nameDestinatario = new bool[] {false} ;
         H002710_A142ccDestinatario = new String[] {""} ;
         H002710_n142ccDestinatario = new bool[] {false} ;
         AV18emailDestino = "";
         AV29nameDestino = "";
         AV9CCDestinatario = "";
         AV17DirTo = new GeneXus.Mail.GXMailRecipient();
         AV8CCAux = "";
         AV10CCDestinatario1 = "";
         AV16DirCc = new GeneXus.Mail.GXMailRecipient();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.enviarorden__default(),
            new Object[][] {
                new Object[] {
               H00272_A5ClienteID, H00272_A57ClienteDsc, H00272_n57ClienteDsc, H00272_A1EmpID
               }
               , new Object[] {
               H00273_A3UsuCod, H00273_A91UsuSMTP, H00273_n91UsuSMTP, H00273_A92UsuPuerto, H00273_n92UsuPuerto, H00273_A50UsuName, H00273_n50UsuName, H00273_A90UsuCorreo, H00273_n90UsuCorreo, H00273_A138UsuClaveCorreo,
               H00273_n138UsuClaveCorreo
               }
               , new Object[] {
               H00274_A1EmpID, H00274_A45EmpEst, H00274_n45EmpEst, H00274_A44empdsc, H00274_n44empdsc
               }
               , new Object[] {
               H00275_A8VehiculoID, H00275_A1EmpID, H00275_A67VehiculoEst, H00275_n67VehiculoEst, H00275_A68VehiculoPlaca, H00275_n68VehiculoPlaca, H00275_A69VehiculoChasis, H00275_n69VehiculoChasis
               }
               , new Object[] {
               H00276_A17tipOrdID, H00276_A1EmpID, H00276_A105tipOrdEst, H00276_n105tipOrdEst, H00276_A104tipOrdDsc, H00276_n104tipOrdDsc
               }
               , new Object[] {
               H00277_A7ModeloID, H00277_A6MarcaID, H00277_A1EmpID, H00277_A64ModeloDsc, H00277_n64ModeloDsc
               }
               , new Object[] {
               H00278_A10protID, H00278_A1EmpID, H00278_A75protEst, H00278_n75protEst, H00278_A74protDsc, H00278_n74protDsc
               }
               , new Object[] {
               H00279_A24OrdenPeriodo, H00279_A25OrdenAnio, H00279_A1EmpID, H00279_A22OrdenID, H00279_A5ClienteID, H00279_A115OrdenEst, H00279_n115OrdenEst, H00279_A57ClienteDsc, H00279_n57ClienteDsc, H00279_A106facturaNro,
               H00279_n106facturaNro, H00279_A132OrdenEmpFac, H00279_n132OrdenEmpFac, H00279_A8VehiculoID, H00279_A17tipOrdID, H00279_A26OrdenMarcaID, H00279_A117OrdenModeloID, H00279_A10protID
               }
               , new Object[] {
               H002710_A29emailID, H002710_A30sec, H002710_A3UsuCod, H002710_A140emailsDestinatarios, H002710_n140emailsDestinatarios, H002710_A141nameDestinatario, H002710_n141nameDestinatario, H002710_A142ccDestinatario, H002710_n142ccDestinatario
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV21empID ;
      private short AV31OrdenID ;
      private short AV12ClienteID ;
      private short wcpOAV21empID ;
      private short wcpOAV31OrdenID ;
      private short wcpOAV12ClienteID ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short AV15DatosOk ;
      private short A92UsuPuerto ;
      private short A1EmpID ;
      private short A22OrdenID ;
      private short A5ClienteID ;
      private short A132OrdenEmpFac ;
      private short A8VehiculoID ;
      private short A17tipOrdID ;
      private short A26OrdenMarcaID ;
      private short A117OrdenModeloID ;
      private short A10protID ;
      private short AV38puerto ;
      private short AV20empFac ;
      private short AV47vehID ;
      private short AV42tipoOrdID ;
      private short A6MarcaID ;
      private short AV25marcaID ;
      private short A7ModeloID ;
      private short AV28modeloID ;
      private short AV36protipoID ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV56GXLvl81 ;
      private short AV23Error ;
      private short AV34PosIni ;
      private short AV35PosSep ;
      private short AV33PosFin ;
      private short nGXWrapped ;
      private short wbTemp ;
      private int A106facturaNro ;
      private int edtavOrdenid_Enabled ;
      private int edtavSubject_Enabled ;
      private int edtavAditionalmnsj_Enabled ;
      private int gxdynajaxindex ;
      private int AV24facturaNro ;
      private int idxLst ;
      private String AV43userCod ;
      private String wcpOAV43userCod ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String A3UsuCod ;
      private String A91UsuSMTP ;
      private String A90UsuCorreo ;
      private String A138UsuClaveCorreo ;
      private String A115OrdenEst ;
      private String A57ClienteDsc ;
      private String AV39smtp ;
      private String AV45UsuCorreo ;
      private String AV44UsuClave ;
      private String AV41tipoOrdenDsc ;
      private String AV19empDscFac ;
      private String AV27modelCamion ;
      private String AV37prototipoDsc ;
      private String A45EmpEst ;
      private String A67VehiculoEst ;
      private String A105tipOrdEst ;
      private String A104tipOrdDsc ;
      private String A64ModeloDsc ;
      private String A75protEst ;
      private String A74protDsc ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTable4_Internalname ;
      private String divTop_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String divTable2_Internalname ;
      private String edtavOrdenid_Internalname ;
      private String edtavOrdenid_Jsonclick ;
      private String dynavClienteid_Internalname ;
      private String dynavClienteid_Jsonclick ;
      private String edtavSubject_Internalname ;
      private String TempTags ;
      private String edtavSubject_Jsonclick ;
      private String edtavAditionalmnsj_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String chkavCc_Internalname ;
      private String AV7cc ;
      private String bttBtnok_Internalname ;
      private String bttBtnok_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String AV30ok2 ;
      private String AV13clienteName ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool n91UsuSMTP ;
      private bool n92UsuPuerto ;
      private bool n50UsuName ;
      private bool n90UsuCorreo ;
      private bool n138UsuClaveCorreo ;
      private bool n45EmpEst ;
      private bool n44empdsc ;
      private bool n67VehiculoEst ;
      private bool n68VehiculoPlaca ;
      private bool n69VehiculoChasis ;
      private bool n105tipOrdEst ;
      private bool n104tipOrdDsc ;
      private bool n64ModeloDsc ;
      private bool n75protEst ;
      private bool n74protDsc ;
      private bool n115OrdenEst ;
      private bool n57ClienteDsc ;
      private bool n106facturaNro ;
      private bool n132OrdenEmpFac ;
      private bool n140emailsDestinatarios ;
      private bool n141nameDestinatario ;
      private bool n142ccDestinatario ;
      private String A50UsuName ;
      private String AV46UsuNom ;
      private String A141nameDestinatario ;
      private String A140emailsDestinatarios ;
      private String A142ccDestinatario ;
      private String AV32placaNro ;
      private String AV11chasisNro ;
      private String A44empdsc ;
      private String A68VehiculoPlaca ;
      private String A69VehiculoChasis ;
      private String AV40subject ;
      private String AV5AditionalMnsj ;
      private String AV18emailDestino ;
      private String AV29nameDestino ;
      private String AV9CCDestinatario ;
      private String AV8CCAux ;
      private String AV10CCDestinatario1 ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavClienteid ;
      private GXCheckbox chkavCc ;
      private IDataStoreProvider pr_default ;
      private short[] H00272_A5ClienteID ;
      private String[] H00272_A57ClienteDsc ;
      private bool[] H00272_n57ClienteDsc ;
      private short[] H00272_A1EmpID ;
      private String[] H00273_A3UsuCod ;
      private String[] H00273_A91UsuSMTP ;
      private bool[] H00273_n91UsuSMTP ;
      private short[] H00273_A92UsuPuerto ;
      private bool[] H00273_n92UsuPuerto ;
      private String[] H00273_A50UsuName ;
      private bool[] H00273_n50UsuName ;
      private String[] H00273_A90UsuCorreo ;
      private bool[] H00273_n90UsuCorreo ;
      private String[] H00273_A138UsuClaveCorreo ;
      private bool[] H00273_n138UsuClaveCorreo ;
      private short[] H00274_A1EmpID ;
      private String[] H00274_A45EmpEst ;
      private bool[] H00274_n45EmpEst ;
      private String[] H00274_A44empdsc ;
      private bool[] H00274_n44empdsc ;
      private short[] H00275_A8VehiculoID ;
      private short[] H00275_A1EmpID ;
      private String[] H00275_A67VehiculoEst ;
      private bool[] H00275_n67VehiculoEst ;
      private String[] H00275_A68VehiculoPlaca ;
      private bool[] H00275_n68VehiculoPlaca ;
      private String[] H00275_A69VehiculoChasis ;
      private bool[] H00275_n69VehiculoChasis ;
      private short[] H00276_A17tipOrdID ;
      private short[] H00276_A1EmpID ;
      private String[] H00276_A105tipOrdEst ;
      private bool[] H00276_n105tipOrdEst ;
      private String[] H00276_A104tipOrdDsc ;
      private bool[] H00276_n104tipOrdDsc ;
      private short[] H00277_A7ModeloID ;
      private short[] H00277_A6MarcaID ;
      private short[] H00277_A1EmpID ;
      private String[] H00277_A64ModeloDsc ;
      private bool[] H00277_n64ModeloDsc ;
      private short[] H00278_A10protID ;
      private short[] H00278_A1EmpID ;
      private String[] H00278_A75protEst ;
      private bool[] H00278_n75protEst ;
      private String[] H00278_A74protDsc ;
      private bool[] H00278_n74protDsc ;
      private short[] H00279_A24OrdenPeriodo ;
      private short[] H00279_A25OrdenAnio ;
      private short[] H00279_A1EmpID ;
      private short[] H00279_A22OrdenID ;
      private short[] H00279_A5ClienteID ;
      private String[] H00279_A115OrdenEst ;
      private bool[] H00279_n115OrdenEst ;
      private String[] H00279_A57ClienteDsc ;
      private bool[] H00279_n57ClienteDsc ;
      private int[] H00279_A106facturaNro ;
      private bool[] H00279_n106facturaNro ;
      private short[] H00279_A132OrdenEmpFac ;
      private bool[] H00279_n132OrdenEmpFac ;
      private short[] H00279_A8VehiculoID ;
      private short[] H00279_A17tipOrdID ;
      private short[] H00279_A26OrdenMarcaID ;
      private short[] H00279_A117OrdenModeloID ;
      private short[] H00279_A10protID ;
      private short[] H002710_A29emailID ;
      private short[] H002710_A30sec ;
      private String[] H002710_A3UsuCod ;
      private String[] H002710_A140emailsDestinatarios ;
      private bool[] H002710_n140emailsDestinatarios ;
      private String[] H002710_A141nameDestinatario ;
      private bool[] H002710_n141nameDestinatario ;
      private String[] H002710_A142ccDestinatario ;
      private bool[] H002710_n142ccDestinatario ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GeneXus.Mail.GXMailMessage AV22Envio ;
      private GeneXus.Mail.GXMailRecipient AV17DirTo ;
      private GeneXus.Mail.GXMailRecipient AV16DirCc ;
      private GeneXus.Mail.GXSMTPSession AV26MensSMTP ;
   }

   public class enviarorden__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00272 ;
          prmH00272 = new Object[] {
          new Object[] {"@AV21empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00273 ;
          prmH00273 = new Object[] {
          new Object[] {"@AV43userCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmH00274 ;
          prmH00274 = new Object[] {
          new Object[] {"@AV20empFac",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00275 ;
          prmH00275 = new Object[] {
          new Object[] {"@AV21empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV47vehID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00276 ;
          prmH00276 = new Object[] {
          new Object[] {"@AV21empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV42tipoOrdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00277 ;
          prmH00277 = new Object[] {
          new Object[] {"@AV21empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25marcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV28modeloID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00278 ;
          prmH00278 = new Object[] {
          new Object[] {"@AV21empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV36protipoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00279 ;
          prmH00279 = new Object[] {
          new Object[] {"@AV21empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV31OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH002710 ;
          prmH002710 = new Object[] {
          new Object[] {"@AV43userCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00272", "SELECT [ClienteID], [ClienteDsc], [EmpID] FROM [Clientes] WITH (NOLOCK) WHERE ([EmpID] = @AV21empID) AND ([ClienteID] = @AV12ClienteID) ORDER BY [ClienteDsc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00272,0,0,true,false )
             ,new CursorDef("H00273", "SELECT [UsuCod], [UsuSMTP], [UsuPuerto], [UsuName], [UsuCorreo], [UsuClaveCorreo] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @AV43userCod ORDER BY [UsuCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00273,1,0,false,true )
             ,new CursorDef("H00274", "SELECT [EmpID], [EmpEst], [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @AV20empFac ORDER BY [EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00274,1,0,false,true )
             ,new CursorDef("H00275", "SELECT [VehiculoID], [EmpID], [VehiculoEst], [VehiculoPlaca], [VehiculoChasis] FROM [Vehiculos] WITH (NOLOCK) WHERE [EmpID] = @AV21empID and [VehiculoID] = @AV47vehID ORDER BY [EmpID], [VehiculoID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00275,1,0,false,true )
             ,new CursorDef("H00276", "SELECT [tipOrdID], [EmpID], [tipOrdEst], [tipOrdDsc] FROM [TipoOrdenPro] WITH (NOLOCK) WHERE [EmpID] = @AV21empID and [tipOrdID] = @AV42tipoOrdID ORDER BY [EmpID], [tipOrdID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00276,1,0,false,true )
             ,new CursorDef("H00277", "SELECT [ModeloID], [MarcaID], [EmpID], [ModeloDsc] FROM [MarcaModelo] WITH (NOLOCK) WHERE [EmpID] = @AV21empID and [MarcaID] = @AV25marcaID and [ModeloID] = @AV28modeloID ORDER BY [EmpID], [MarcaID], [ModeloID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00277,1,0,false,true )
             ,new CursorDef("H00278", "SELECT [protID], [EmpID], [protEst], [protDsc] FROM [Prototipo] WITH (NOLOCK) WHERE [EmpID] = @AV21empID and [protID] = @AV36protipoID ORDER BY [EmpID], [protID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00278,1,0,false,true )
             ,new CursorDef("H00279", "SELECT TOP 1 T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[EmpID], T1.[OrdenID], T1.[ClienteID], T1.[OrdenEst], T2.[ClienteDsc], T1.[facturaNro], T1.[OrdenEmpFac], T1.[VehiculoID], T1.[tipOrdID], T1.[OrdenMarcaID], T1.[OrdenModeloID], T1.[protID] FROM ([OrdenProduccion] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) WHERE (T1.[EmpID] = @AV21empID and T1.[OrdenID] = @AV31OrdenID) AND (T1.[ClienteID] = @AV12ClienteID) ORDER BY T1.[EmpID], T1.[OrdenID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00279,1,0,true,true )
             ,new CursorDef("H002710", "SELECT [emailID], [sec], [UsuCod], [emailsDestinatarios], [nameDestinatario], [ccDestinatario] FROM [EmailsLevel1] WITH (NOLOCK) WHERE [UsuCod] = @AV43userCod ORDER BY [emailID], [UsuCod], [sec] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002710,100,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 60) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 60) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 50) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((int[]) buf[9])[0] = rslt.getInt(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                ((short[]) buf[16])[0] = rslt.getShort(13) ;
                ((short[]) buf[17])[0] = rslt.getShort(14) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
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
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
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
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
