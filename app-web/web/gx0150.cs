/*
               File: Gx0150
        Description: Selection List Obreros
             Author: GeneXus C# Generator version 15_0_11-124690
       Generated on: 7/7/2022 21:38:38.30
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
   public class gx0150 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0150( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0150( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pObreID )
      {
         this.AV13pObreID = 0 ;
         executePrivate();
         aP0_pObreID=this.AV13pObreID;
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
         context.SetDefaultTheme("Carmine");
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
               AV6cObreID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cObreCedula = GetNextPar( );
               AV8cObrePrNombre = GetNextPar( );
               AV9cObreSegNombre = GetNextPar( );
               AV10cObrePrApellido = GetNextPar( );
               AV11cObreSegApellido = GetNextPar( );
               AV12cObreFchNac = context.localUtil.ParseDateParm( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cObreID, AV7cObreCedula, AV8cObrePrNombre, AV9cObreSegNombre, AV10cObrePrApellido, AV11cObreSegApellido, AV12cObreFchNac) ;
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
               AV13pObreID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pObreID), 4, 0)));
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
         PA3S2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3S2( ) ;
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
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 124690), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 124690), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 124690), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 124690), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 124690), false);
         context.AddJavascriptSource("gxcfg.js", "?20227721383840", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 124690), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 124690), false);
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 124690), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0150.aspx") + "?" + UrlEncode("" +AV13pObreID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCOBREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cObreID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCOBRECEDULA", StringUtil.RTrim( AV7cObreCedula));
         GxWebStd.gx_hidden_field( context, "GXH_vCOBREPRNOMBRE", AV8cObrePrNombre);
         GxWebStd.gx_hidden_field( context, "GXH_vCOBRESEGNOMBRE", AV9cObreSegNombre);
         GxWebStd.gx_hidden_field( context, "GXH_vCOBREPRAPELLIDO", AV10cObrePrApellido);
         GxWebStd.gx_hidden_field( context, "GXH_vCOBRESEGAPELLIDO", AV11cObreSegApellido);
         GxWebStd.gx_hidden_field( context, "GXH_vCOBREFCHNAC", context.localUtil.Format(AV12cObreFchNac, "99/99/99"));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPOBREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pObreID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "OBREIDFILTERCONTAINER_Class", StringUtil.RTrim( divObreidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "OBRECEDULAFILTERCONTAINER_Class", StringUtil.RTrim( divObrecedulafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "OBREPRNOMBREFILTERCONTAINER_Class", StringUtil.RTrim( divObreprnombrefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "OBRESEGNOMBREFILTERCONTAINER_Class", StringUtil.RTrim( divObresegnombrefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "OBREPRAPELLIDOFILTERCONTAINER_Class", StringUtil.RTrim( divObreprapellidofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "OBRESEGAPELLIDOFILTERCONTAINER_Class", StringUtil.RTrim( divObresegapellidofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "OBREFCHNACFILTERCONTAINER_Class", StringUtil.RTrim( divObrefchnacfiltercontainer_Class));
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
            WE3S2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3S2( ) ;
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
         return formatLink("gx0150.aspx") + "?" + UrlEncode("" +AV13pObreID) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0150" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Obreros" ;
      }

      protected void WB3S0( )
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
            GxWebStd.gx_div_start( context, divObreidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divObreidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblobreidfilter_Internalname, "Obre ID", "", "", lblLblobreidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e113s1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0150.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCobreid_Internalname, "Obre ID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCobreid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cObreID), 4, 0, ",", "")), ((edtavCobreid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cObreID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cObreID), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCobreid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCobreid_Visible, edtavCobreid_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0150.htm");
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
            GxWebStd.gx_div_start( context, divObrecedulafiltercontainer_Internalname, 1, 0, "px", 0, "px", divObrecedulafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblobrecedulafilter_Internalname, "Cedula", "", "", lblLblobrecedulafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e123s1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0150.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCobrecedula_Internalname, "Cedula", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCobrecedula_Internalname, StringUtil.RTrim( AV7cObreCedula), StringUtil.RTrim( context.localUtil.Format( AV7cObreCedula, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCobrecedula_Jsonclick, 0, "Attribute", "", "", "", "", edtavCobrecedula_Visible, edtavCobrecedula_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0150.htm");
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
            GxWebStd.gx_div_start( context, divObreprnombrefiltercontainer_Internalname, 1, 0, "px", 0, "px", divObreprnombrefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblobreprnombrefilter_Internalname, "Primer Nombre", "", "", lblLblobreprnombrefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e133s1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0150.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCobreprnombre_Internalname, "Primer Nombre", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCobreprnombre_Internalname, AV8cObrePrNombre, StringUtil.RTrim( context.localUtil.Format( AV8cObrePrNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCobreprnombre_Jsonclick, 0, "Attribute", "", "", "", "", edtavCobreprnombre_Visible, edtavCobreprnombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0150.htm");
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
            GxWebStd.gx_div_start( context, divObresegnombrefiltercontainer_Internalname, 1, 0, "px", 0, "px", divObresegnombrefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblobresegnombrefilter_Internalname, "Segundo Nombre", "", "", lblLblobresegnombrefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e143s1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0150.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCobresegnombre_Internalname, "Segundo Nombre", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCobresegnombre_Internalname, AV9cObreSegNombre, StringUtil.RTrim( context.localUtil.Format( AV9cObreSegNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCobresegnombre_Jsonclick, 0, "Attribute", "", "", "", "", edtavCobresegnombre_Visible, edtavCobresegnombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0150.htm");
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
            GxWebStd.gx_div_start( context, divObreprapellidofiltercontainer_Internalname, 1, 0, "px", 0, "px", divObreprapellidofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblobreprapellidofilter_Internalname, "Primer Apellido", "", "", lblLblobreprapellidofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e153s1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0150.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCobreprapellido_Internalname, "Primer Apellido", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCobreprapellido_Internalname, AV10cObrePrApellido, StringUtil.RTrim( context.localUtil.Format( AV10cObrePrApellido, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCobreprapellido_Jsonclick, 0, "Attribute", "", "", "", "", edtavCobreprapellido_Visible, edtavCobreprapellido_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0150.htm");
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
            GxWebStd.gx_div_start( context, divObresegapellidofiltercontainer_Internalname, 1, 0, "px", 0, "px", divObresegapellidofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblobresegapellidofilter_Internalname, "Segundo Apellido", "", "", lblLblobresegapellidofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e163s1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0150.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCobresegapellido_Internalname, "Segundo Apellido", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCobresegapellido_Internalname, AV11cObreSegApellido, StringUtil.RTrim( context.localUtil.Format( AV11cObreSegApellido, "")), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCobresegapellido_Jsonclick, 0, "Attribute", "", "", "", "", edtavCobresegapellido_Visible, edtavCobresegapellido_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx0150.htm");
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
            GxWebStd.gx_div_start( context, divObrefchnacfiltercontainer_Internalname, 1, 0, "px", 0, "px", divObrefchnacfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblobrefchnacfilter_Internalname, "Fecha Nac", "", "", lblLblobrefchnacfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e173s1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0150.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCobrefchnac_Internalname, "Fecha Nac", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCobrefchnac_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCobrefchnac_Internalname, context.localUtil.Format(AV12cObreFchNac, "99/99/99"), context.localUtil.Format( AV12cObreFchNac, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCobrefchnac_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCobrefchnac_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0150.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e183s1_client"+"'", TempTags, "", 2, "HLP_Gx0150.htm");
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cedula") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Primer Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Segundo Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Primer Apellido") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Segundo Apellido") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nac") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A238ObreID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A239ObreCedula));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtObreCedula_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A240ObrePrNombre);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A241ObreSegNombre);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A242ObrePrApellido);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A243ObreSegApellido);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A245ObreFchNac, "99/99/99"));
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0150.htm");
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

      protected void START3S2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_11-124690", 0) ;
            Form.Meta.addItem("description", "Selection List Obreros", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP3S0( ) ;
      }

      protected void WS3S2( )
      {
         START3S2( ) ;
         EVT3S2( ) ;
      }

      protected void EVT3S2( )
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
                              A238ObreID = (short)(context.localUtil.CToN( cgiGet( edtObreID_Internalname), ",", "."));
                              A239ObreCedula = cgiGet( edtObreCedula_Internalname);
                              n239ObreCedula = false;
                              A240ObrePrNombre = cgiGet( edtObrePrNombre_Internalname);
                              n240ObrePrNombre = false;
                              A241ObreSegNombre = cgiGet( edtObreSegNombre_Internalname);
                              n241ObreSegNombre = false;
                              A242ObrePrApellido = cgiGet( edtObrePrApellido_Internalname);
                              n242ObrePrApellido = false;
                              A243ObreSegApellido = cgiGet( edtObreSegApellido_Internalname);
                              n243ObreSegApellido = false;
                              A245ObreFchNac = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtObreFchNac_Internalname), 0));
                              n245ObreFchNac = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E193S2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E203S2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cobreid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCOBREID"), ",", ".") != Convert.ToDecimal( AV6cObreID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cobrecedula Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCOBRECEDULA"), AV7cObreCedula) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cobreprnombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCOBREPRNOMBRE"), AV8cObrePrNombre) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cobresegnombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCOBRESEGNOMBRE"), AV9cObreSegNombre) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cobreprapellido Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCOBREPRAPELLIDO"), AV10cObrePrApellido) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cobresegapellido Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCOBRESEGAPELLIDO"), AV11cObreSegApellido) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cobrefchnac Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCOBREFCHNAC"), 0) != AV12cObreFchNac )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E213S2 ();
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

      protected void WE3S2( )
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

      protected void PA3S2( )
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
                                        short AV6cObreID ,
                                        String AV7cObreCedula ,
                                        String AV8cObrePrNombre ,
                                        String AV9cObreSegNombre ,
                                        String AV10cObrePrApellido ,
                                        String AV11cObreSegApellido ,
                                        DateTime AV12cObreFchNac )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF3S2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_OBREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A238ObreID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "OBREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A238ObreID), 4, 0, ".", "")));
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
         RF3S2( ) ;
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

      protected void RF3S2( )
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
                                                 AV7cObreCedula ,
                                                 AV8cObrePrNombre ,
                                                 AV9cObreSegNombre ,
                                                 AV10cObrePrApellido ,
                                                 AV11cObreSegApellido ,
                                                 AV12cObreFchNac ,
                                                 A239ObreCedula ,
                                                 A240ObrePrNombre ,
                                                 A241ObreSegNombre ,
                                                 A242ObrePrApellido ,
                                                 A243ObreSegApellido ,
                                                 A245ObreFchNac ,
                                                 AV6cObreID } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT
                                                 }
            } ) ;
            lV7cObreCedula = StringUtil.PadR( StringUtil.RTrim( AV7cObreCedula), 13, "%");
            lV8cObrePrNombre = StringUtil.Concat( StringUtil.RTrim( AV8cObrePrNombre), "%", "");
            lV9cObreSegNombre = StringUtil.Concat( StringUtil.RTrim( AV9cObreSegNombre), "%", "");
            lV10cObrePrApellido = StringUtil.Concat( StringUtil.RTrim( AV10cObrePrApellido), "%", "");
            lV11cObreSegApellido = StringUtil.Concat( StringUtil.RTrim( AV11cObreSegApellido), "%", "");
            /* Using cursor H003S2 */
            pr_default.execute(0, new Object[] {AV6cObreID, lV7cObreCedula, lV8cObrePrNombre, lV9cObreSegNombre, lV10cObrePrApellido, lV11cObreSegApellido, AV12cObreFchNac, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A245ObreFchNac = H003S2_A245ObreFchNac[0];
               n245ObreFchNac = H003S2_n245ObreFchNac[0];
               A243ObreSegApellido = H003S2_A243ObreSegApellido[0];
               n243ObreSegApellido = H003S2_n243ObreSegApellido[0];
               A242ObrePrApellido = H003S2_A242ObrePrApellido[0];
               n242ObrePrApellido = H003S2_n242ObrePrApellido[0];
               A241ObreSegNombre = H003S2_A241ObreSegNombre[0];
               n241ObreSegNombre = H003S2_n241ObreSegNombre[0];
               A240ObrePrNombre = H003S2_A240ObrePrNombre[0];
               n240ObrePrNombre = H003S2_n240ObrePrNombre[0];
               A239ObreCedula = H003S2_A239ObreCedula[0];
               n239ObreCedula = H003S2_n239ObreCedula[0];
               A238ObreID = H003S2_A238ObreID[0];
               /* Execute user event: Load */
               E203S2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB3S0( ) ;
         }
         bGXsfl_84_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes3S2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_OBREID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A238ObreID), "ZZZ9"), context));
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
                                              AV7cObreCedula ,
                                              AV8cObrePrNombre ,
                                              AV9cObreSegNombre ,
                                              AV10cObrePrApellido ,
                                              AV11cObreSegApellido ,
                                              AV12cObreFchNac ,
                                              A239ObreCedula ,
                                              A240ObrePrNombre ,
                                              A241ObreSegNombre ,
                                              A242ObrePrApellido ,
                                              A243ObreSegApellido ,
                                              A245ObreFchNac ,
                                              AV6cObreID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT
                                              }
         } ) ;
         lV7cObreCedula = StringUtil.PadR( StringUtil.RTrim( AV7cObreCedula), 13, "%");
         lV8cObrePrNombre = StringUtil.Concat( StringUtil.RTrim( AV8cObrePrNombre), "%", "");
         lV9cObreSegNombre = StringUtil.Concat( StringUtil.RTrim( AV9cObreSegNombre), "%", "");
         lV10cObrePrApellido = StringUtil.Concat( StringUtil.RTrim( AV10cObrePrApellido), "%", "");
         lV11cObreSegApellido = StringUtil.Concat( StringUtil.RTrim( AV11cObreSegApellido), "%", "");
         /* Using cursor H003S3 */
         pr_default.execute(1, new Object[] {AV6cObreID, lV7cObreCedula, lV8cObrePrNombre, lV9cObreSegNombre, lV10cObrePrApellido, lV11cObreSegApellido, AV12cObreFchNac});
         GRID1_nRecordCount = H003S3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cObreID, AV7cObreCedula, AV8cObrePrNombre, AV9cObreSegNombre, AV10cObrePrApellido, AV11cObreSegApellido, AV12cObreFchNac) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cObreID, AV7cObreCedula, AV8cObrePrNombre, AV9cObreSegNombre, AV10cObrePrApellido, AV11cObreSegApellido, AV12cObreFchNac) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cObreID, AV7cObreCedula, AV8cObrePrNombre, AV9cObreSegNombre, AV10cObrePrApellido, AV11cObreSegApellido, AV12cObreFchNac) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cObreID, AV7cObreCedula, AV8cObrePrNombre, AV9cObreSegNombre, AV10cObrePrApellido, AV11cObreSegApellido, AV12cObreFchNac) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cObreID, AV7cObreCedula, AV8cObrePrNombre, AV9cObreSegNombre, AV10cObrePrApellido, AV11cObreSegApellido, AV12cObreFchNac) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP3S0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E193S2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCobreid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCobreid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCOBREID");
               GX_FocusControl = edtavCobreid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cObreID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cObreID), 4, 0)));
            }
            else
            {
               AV6cObreID = (short)(context.localUtil.CToN( cgiGet( edtavCobreid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cObreID), 4, 0)));
            }
            AV7cObreCedula = cgiGet( edtavCobrecedula_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cObreCedula", AV7cObreCedula);
            AV8cObrePrNombre = cgiGet( edtavCobreprnombre_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cObrePrNombre", AV8cObrePrNombre);
            AV9cObreSegNombre = cgiGet( edtavCobresegnombre_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cObreSegNombre", AV9cObreSegNombre);
            AV10cObrePrApellido = cgiGet( edtavCobreprapellido_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cObrePrApellido", AV10cObrePrApellido);
            AV11cObreSegApellido = cgiGet( edtavCobresegapellido_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cObreSegApellido", AV11cObreSegApellido);
            if ( context.localUtil.VCDate( cgiGet( edtavCobrefchnac_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha Nac"}), 1, "vCOBREFCHNAC");
               GX_FocusControl = edtavCobrefchnac_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cObreFchNac = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cObreFchNac", context.localUtil.Format(AV12cObreFchNac, "99/99/99"));
            }
            else
            {
               AV12cObreFchNac = context.localUtil.CToD( cgiGet( edtavCobrefchnac_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cObreFchNac", context.localUtil.Format(AV12cObreFchNac, "99/99/99"));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCOBREID"), ",", ".") != Convert.ToDecimal( AV6cObreID )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCOBRECEDULA"), AV7cObreCedula) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCOBREPRNOMBRE"), AV8cObrePrNombre) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCOBRESEGNOMBRE"), AV9cObreSegNombre) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCOBREPRAPELLIDO"), AV10cObrePrApellido) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCOBRESEGAPELLIDO"), AV11cObreSegApellido) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vCOBREFCHNAC"), 2) != AV12cObreFchNac )
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
         E193S2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E193S2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Obreros", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E203S2( )
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
         E213S2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E213S2( )
      {
         /* Enter Routine */
         AV13pObreID = A238ObreID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pObreID), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pObreID});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pObreID"});
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
         AV13pObreID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pObreID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pObreID), 4, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         context.SetDefaultTheme("Carmine");
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA3S2( ) ;
         WS3S2( ) ;
         WE3S2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20227721383937", true);
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
         context.AddJavascriptSource("gx0150.js", "?20227721383937", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtObreID_Internalname = "OBREID_"+sGXsfl_84_idx;
         edtObreCedula_Internalname = "OBRECEDULA_"+sGXsfl_84_idx;
         edtObrePrNombre_Internalname = "OBREPRNOMBRE_"+sGXsfl_84_idx;
         edtObreSegNombre_Internalname = "OBRESEGNOMBRE_"+sGXsfl_84_idx;
         edtObrePrApellido_Internalname = "OBREPRAPELLIDO_"+sGXsfl_84_idx;
         edtObreSegApellido_Internalname = "OBRESEGAPELLIDO_"+sGXsfl_84_idx;
         edtObreFchNac_Internalname = "OBREFCHNAC_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtObreID_Internalname = "OBREID_"+sGXsfl_84_fel_idx;
         edtObreCedula_Internalname = "OBRECEDULA_"+sGXsfl_84_fel_idx;
         edtObrePrNombre_Internalname = "OBREPRNOMBRE_"+sGXsfl_84_fel_idx;
         edtObreSegNombre_Internalname = "OBRESEGNOMBRE_"+sGXsfl_84_fel_idx;
         edtObrePrApellido_Internalname = "OBREPRAPELLIDO_"+sGXsfl_84_fel_idx;
         edtObreSegApellido_Internalname = "OBRESEGAPELLIDO_"+sGXsfl_84_fel_idx;
         edtObreFchNac_Internalname = "OBREFCHNAC_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB3S0( ) ;
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
               if ( ((int)((nGXsfl_84_idx) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A238ObreID), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_84_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV17Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObreID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A238ObreID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A238ObreID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtObreID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtObreCedula_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A238ObreID), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObreCedula_Internalname, "Link", edtObreCedula_Link, !bGXsfl_84_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObreCedula_Internalname,StringUtil.RTrim( A239ObreCedula),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtObreCedula_Link,(String)"",(String)"",(String)"",(String)edtObreCedula_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObrePrNombre_Internalname,(String)A240ObrePrNombre,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtObrePrNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObreSegNombre_Internalname,(String)A241ObreSegNombre,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtObreSegNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObrePrApellido_Internalname,(String)A242ObrePrApellido,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtObrePrApellido_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObreSegApellido_Internalname,(String)A243ObreSegApellido,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtObreSegApellido_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObreFchNac_Internalname,context.localUtil.Format(A245ObreFchNac, "99/99/99"),context.localUtil.Format( A245ObreFchNac, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtObreFchNac_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes3S2( ) ;
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
         lblLblobreidfilter_Internalname = "LBLOBREIDFILTER";
         edtavCobreid_Internalname = "vCOBREID";
         divObreidfiltercontainer_Internalname = "OBREIDFILTERCONTAINER";
         lblLblobrecedulafilter_Internalname = "LBLOBRECEDULAFILTER";
         edtavCobrecedula_Internalname = "vCOBRECEDULA";
         divObrecedulafiltercontainer_Internalname = "OBRECEDULAFILTERCONTAINER";
         lblLblobreprnombrefilter_Internalname = "LBLOBREPRNOMBREFILTER";
         edtavCobreprnombre_Internalname = "vCOBREPRNOMBRE";
         divObreprnombrefiltercontainer_Internalname = "OBREPRNOMBREFILTERCONTAINER";
         lblLblobresegnombrefilter_Internalname = "LBLOBRESEGNOMBREFILTER";
         edtavCobresegnombre_Internalname = "vCOBRESEGNOMBRE";
         divObresegnombrefiltercontainer_Internalname = "OBRESEGNOMBREFILTERCONTAINER";
         lblLblobreprapellidofilter_Internalname = "LBLOBREPRAPELLIDOFILTER";
         edtavCobreprapellido_Internalname = "vCOBREPRAPELLIDO";
         divObreprapellidofiltercontainer_Internalname = "OBREPRAPELLIDOFILTERCONTAINER";
         lblLblobresegapellidofilter_Internalname = "LBLOBRESEGAPELLIDOFILTER";
         edtavCobresegapellido_Internalname = "vCOBRESEGAPELLIDO";
         divObresegapellidofiltercontainer_Internalname = "OBRESEGAPELLIDOFILTERCONTAINER";
         lblLblobrefchnacfilter_Internalname = "LBLOBREFCHNACFILTER";
         edtavCobrefchnac_Internalname = "vCOBREFCHNAC";
         divObrefchnacfiltercontainer_Internalname = "OBREFCHNACFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtObreID_Internalname = "OBREID";
         edtObreCedula_Internalname = "OBRECEDULA";
         edtObrePrNombre_Internalname = "OBREPRNOMBRE";
         edtObreSegNombre_Internalname = "OBRESEGNOMBRE";
         edtObrePrApellido_Internalname = "OBREPRAPELLIDO";
         edtObreSegApellido_Internalname = "OBRESEGAPELLIDO";
         edtObreFchNac_Internalname = "OBREFCHNAC";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtObreFchNac_Jsonclick = "";
         edtObreSegApellido_Jsonclick = "";
         edtObrePrApellido_Jsonclick = "";
         edtObreSegNombre_Jsonclick = "";
         edtObrePrNombre_Jsonclick = "";
         edtObreCedula_Jsonclick = "";
         edtObreID_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtObreCedula_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCobrefchnac_Jsonclick = "";
         edtavCobrefchnac_Enabled = 1;
         edtavCobresegapellido_Jsonclick = "";
         edtavCobresegapellido_Enabled = 1;
         edtavCobresegapellido_Visible = 1;
         edtavCobreprapellido_Jsonclick = "";
         edtavCobreprapellido_Enabled = 1;
         edtavCobreprapellido_Visible = 1;
         edtavCobresegnombre_Jsonclick = "";
         edtavCobresegnombre_Enabled = 1;
         edtavCobresegnombre_Visible = 1;
         edtavCobreprnombre_Jsonclick = "";
         edtavCobreprnombre_Enabled = 1;
         edtavCobreprnombre_Visible = 1;
         edtavCobrecedula_Jsonclick = "";
         edtavCobrecedula_Enabled = 1;
         edtavCobrecedula_Visible = 1;
         edtavCobreid_Jsonclick = "";
         edtavCobreid_Enabled = 1;
         edtavCobreid_Visible = 1;
         divObrefchnacfiltercontainer_Class = "AdvancedContainerItem";
         divObresegapellidofiltercontainer_Class = "AdvancedContainerItem";
         divObreprapellidofiltercontainer_Class = "AdvancedContainerItem";
         divObresegnombrefiltercontainer_Class = "AdvancedContainerItem";
         divObreprnombrefiltercontainer_Class = "AdvancedContainerItem";
         divObrecedulafiltercontainer_Class = "AdvancedContainerItem";
         divObreidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Obreros";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cObreID',fld:'vCOBREID',pic:'ZZZ9'},{av:'AV7cObreCedula',fld:'vCOBRECEDULA',pic:''},{av:'AV8cObrePrNombre',fld:'vCOBREPRNOMBRE',pic:''},{av:'AV9cObreSegNombre',fld:'vCOBRESEGNOMBRE',pic:''},{av:'AV10cObrePrApellido',fld:'vCOBREPRAPELLIDO',pic:''},{av:'AV11cObreSegApellido',fld:'vCOBRESEGAPELLIDO',pic:''},{av:'AV12cObreFchNac',fld:'vCOBREFCHNAC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E183S1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLOBREIDFILTER.CLICK","{handler:'E113S1',iparms:[{av:'divObreidfiltercontainer_Class',ctrl:'OBREIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLOBREIDFILTER.CLICK",",oparms:[{av:'divObreidfiltercontainer_Class',ctrl:'OBREIDFILTERCONTAINER',prop:'Class'},{av:'edtavCobreid_Visible',ctrl:'vCOBREID',prop:'Visible'}]}");
         setEventMetadata("LBLOBRECEDULAFILTER.CLICK","{handler:'E123S1',iparms:[{av:'divObrecedulafiltercontainer_Class',ctrl:'OBRECEDULAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLOBRECEDULAFILTER.CLICK",",oparms:[{av:'divObrecedulafiltercontainer_Class',ctrl:'OBRECEDULAFILTERCONTAINER',prop:'Class'},{av:'edtavCobrecedula_Visible',ctrl:'vCOBRECEDULA',prop:'Visible'}]}");
         setEventMetadata("LBLOBREPRNOMBREFILTER.CLICK","{handler:'E133S1',iparms:[{av:'divObreprnombrefiltercontainer_Class',ctrl:'OBREPRNOMBREFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLOBREPRNOMBREFILTER.CLICK",",oparms:[{av:'divObreprnombrefiltercontainer_Class',ctrl:'OBREPRNOMBREFILTERCONTAINER',prop:'Class'},{av:'edtavCobreprnombre_Visible',ctrl:'vCOBREPRNOMBRE',prop:'Visible'}]}");
         setEventMetadata("LBLOBRESEGNOMBREFILTER.CLICK","{handler:'E143S1',iparms:[{av:'divObresegnombrefiltercontainer_Class',ctrl:'OBRESEGNOMBREFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLOBRESEGNOMBREFILTER.CLICK",",oparms:[{av:'divObresegnombrefiltercontainer_Class',ctrl:'OBRESEGNOMBREFILTERCONTAINER',prop:'Class'},{av:'edtavCobresegnombre_Visible',ctrl:'vCOBRESEGNOMBRE',prop:'Visible'}]}");
         setEventMetadata("LBLOBREPRAPELLIDOFILTER.CLICK","{handler:'E153S1',iparms:[{av:'divObreprapellidofiltercontainer_Class',ctrl:'OBREPRAPELLIDOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLOBREPRAPELLIDOFILTER.CLICK",",oparms:[{av:'divObreprapellidofiltercontainer_Class',ctrl:'OBREPRAPELLIDOFILTERCONTAINER',prop:'Class'},{av:'edtavCobreprapellido_Visible',ctrl:'vCOBREPRAPELLIDO',prop:'Visible'}]}");
         setEventMetadata("LBLOBRESEGAPELLIDOFILTER.CLICK","{handler:'E163S1',iparms:[{av:'divObresegapellidofiltercontainer_Class',ctrl:'OBRESEGAPELLIDOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLOBRESEGAPELLIDOFILTER.CLICK",",oparms:[{av:'divObresegapellidofiltercontainer_Class',ctrl:'OBRESEGAPELLIDOFILTERCONTAINER',prop:'Class'},{av:'edtavCobresegapellido_Visible',ctrl:'vCOBRESEGAPELLIDO',prop:'Visible'}]}");
         setEventMetadata("LBLOBREFCHNACFILTER.CLICK","{handler:'E173S1',iparms:[{av:'divObrefchnacfiltercontainer_Class',ctrl:'OBREFCHNACFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLOBREFCHNACFILTER.CLICK",",oparms:[{av:'divObrefchnacfiltercontainer_Class',ctrl:'OBREFCHNACFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("ENTER","{handler:'E213S2',iparms:[{av:'A238ObreID',fld:'OBREID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pObreID',fld:'vPOBREID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cObreID',fld:'vCOBREID',pic:'ZZZ9'},{av:'AV7cObreCedula',fld:'vCOBRECEDULA',pic:''},{av:'AV8cObrePrNombre',fld:'vCOBREPRNOMBRE',pic:''},{av:'AV9cObreSegNombre',fld:'vCOBRESEGNOMBRE',pic:''},{av:'AV10cObrePrApellido',fld:'vCOBREPRAPELLIDO',pic:''},{av:'AV11cObreSegApellido',fld:'vCOBRESEGAPELLIDO',pic:''},{av:'AV12cObreFchNac',fld:'vCOBREFCHNAC',pic:''}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cObreID',fld:'vCOBREID',pic:'ZZZ9'},{av:'AV7cObreCedula',fld:'vCOBRECEDULA',pic:''},{av:'AV8cObrePrNombre',fld:'vCOBREPRNOMBRE',pic:''},{av:'AV9cObreSegNombre',fld:'vCOBRESEGNOMBRE',pic:''},{av:'AV10cObrePrApellido',fld:'vCOBREPRAPELLIDO',pic:''},{av:'AV11cObreSegApellido',fld:'vCOBRESEGAPELLIDO',pic:''},{av:'AV12cObreFchNac',fld:'vCOBREFCHNAC',pic:''}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cObreID',fld:'vCOBREID',pic:'ZZZ9'},{av:'AV7cObreCedula',fld:'vCOBRECEDULA',pic:''},{av:'AV8cObrePrNombre',fld:'vCOBREPRNOMBRE',pic:''},{av:'AV9cObreSegNombre',fld:'vCOBRESEGNOMBRE',pic:''},{av:'AV10cObrePrApellido',fld:'vCOBREPRAPELLIDO',pic:''},{av:'AV11cObreSegApellido',fld:'vCOBRESEGAPELLIDO',pic:''},{av:'AV12cObreFchNac',fld:'vCOBREFCHNAC',pic:''}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cObreID',fld:'vCOBREID',pic:'ZZZ9'},{av:'AV7cObreCedula',fld:'vCOBRECEDULA',pic:''},{av:'AV8cObrePrNombre',fld:'vCOBREPRNOMBRE',pic:''},{av:'AV9cObreSegNombre',fld:'vCOBRESEGNOMBRE',pic:''},{av:'AV10cObrePrApellido',fld:'vCOBREPRAPELLIDO',pic:''},{av:'AV11cObreSegApellido',fld:'vCOBRESEGAPELLIDO',pic:''},{av:'AV12cObreFchNac',fld:'vCOBREFCHNAC',pic:''}]");
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
         AV7cObreCedula = "";
         AV8cObrePrNombre = "";
         AV9cObreSegNombre = "";
         AV10cObrePrApellido = "";
         AV11cObreSegApellido = "";
         AV12cObreFchNac = DateTime.MinValue;
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblobreidfilter_Jsonclick = "";
         TempTags = "";
         lblLblobrecedulafilter_Jsonclick = "";
         lblLblobreprnombrefilter_Jsonclick = "";
         lblLblobresegnombrefilter_Jsonclick = "";
         lblLblobreprapellidofilter_Jsonclick = "";
         lblLblobresegapellidofilter_Jsonclick = "";
         lblLblobrefchnacfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A239ObreCedula = "";
         A240ObrePrNombre = "";
         A241ObreSegNombre = "";
         A242ObrePrApellido = "";
         A243ObreSegApellido = "";
         A245ObreFchNac = DateTime.MinValue;
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         scmdbuf = "";
         lV7cObreCedula = "";
         lV8cObrePrNombre = "";
         lV9cObreSegNombre = "";
         lV10cObrePrApellido = "";
         lV11cObreSegApellido = "";
         H003S2_A245ObreFchNac = new DateTime[] {DateTime.MinValue} ;
         H003S2_n245ObreFchNac = new bool[] {false} ;
         H003S2_A243ObreSegApellido = new String[] {""} ;
         H003S2_n243ObreSegApellido = new bool[] {false} ;
         H003S2_A242ObrePrApellido = new String[] {""} ;
         H003S2_n242ObrePrApellido = new bool[] {false} ;
         H003S2_A241ObreSegNombre = new String[] {""} ;
         H003S2_n241ObreSegNombre = new bool[] {false} ;
         H003S2_A240ObrePrNombre = new String[] {""} ;
         H003S2_n240ObrePrNombre = new bool[] {false} ;
         H003S2_A239ObreCedula = new String[] {""} ;
         H003S2_n239ObreCedula = new bool[] {false} ;
         H003S2_A238ObreID = new short[1] ;
         H003S3_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0150__default(),
            new Object[][] {
                new Object[] {
               H003S2_A245ObreFchNac, H003S2_n245ObreFchNac, H003S2_A243ObreSegApellido, H003S2_n243ObreSegApellido, H003S2_A242ObrePrApellido, H003S2_n242ObrePrApellido, H003S2_A241ObreSegNombre, H003S2_n241ObreSegNombre, H003S2_A240ObrePrNombre, H003S2_n240ObrePrNombre,
               H003S2_A239ObreCedula, H003S2_n239ObreCedula, H003S2_A238ObreID
               }
               , new Object[] {
               H003S3_AGRID1_nRecordCount
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
      private short AV6cObreID ;
      private short AV13pObreID ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A238ObreID ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCobreid_Enabled ;
      private int edtavCobreid_Visible ;
      private int edtavCobrecedula_Visible ;
      private int edtavCobrecedula_Enabled ;
      private int edtavCobreprnombre_Visible ;
      private int edtavCobreprnombre_Enabled ;
      private int edtavCobresegnombre_Visible ;
      private int edtavCobresegnombre_Enabled ;
      private int edtavCobreprapellido_Visible ;
      private int edtavCobreprapellido_Enabled ;
      private int edtavCobresegapellido_Visible ;
      private int edtavCobresegapellido_Enabled ;
      private int edtavCobrefchnac_Enabled ;
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
      private String divObreidfiltercontainer_Class ;
      private String divObrecedulafiltercontainer_Class ;
      private String divObreprnombrefiltercontainer_Class ;
      private String divObresegnombrefiltercontainer_Class ;
      private String divObreprapellidofiltercontainer_Class ;
      private String divObresegapellidofiltercontainer_Class ;
      private String divObrefchnacfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_84_idx="0001" ;
      private String AV7cObreCedula ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divObreidfiltercontainer_Internalname ;
      private String lblLblobreidfilter_Internalname ;
      private String lblLblobreidfilter_Jsonclick ;
      private String edtavCobreid_Internalname ;
      private String TempTags ;
      private String edtavCobreid_Jsonclick ;
      private String divObrecedulafiltercontainer_Internalname ;
      private String lblLblobrecedulafilter_Internalname ;
      private String lblLblobrecedulafilter_Jsonclick ;
      private String edtavCobrecedula_Internalname ;
      private String edtavCobrecedula_Jsonclick ;
      private String divObreprnombrefiltercontainer_Internalname ;
      private String lblLblobreprnombrefilter_Internalname ;
      private String lblLblobreprnombrefilter_Jsonclick ;
      private String edtavCobreprnombre_Internalname ;
      private String edtavCobreprnombre_Jsonclick ;
      private String divObresegnombrefiltercontainer_Internalname ;
      private String lblLblobresegnombrefilter_Internalname ;
      private String lblLblobresegnombrefilter_Jsonclick ;
      private String edtavCobresegnombre_Internalname ;
      private String edtavCobresegnombre_Jsonclick ;
      private String divObreprapellidofiltercontainer_Internalname ;
      private String lblLblobreprapellidofilter_Internalname ;
      private String lblLblobreprapellidofilter_Jsonclick ;
      private String edtavCobreprapellido_Internalname ;
      private String edtavCobreprapellido_Jsonclick ;
      private String divObresegapellidofiltercontainer_Internalname ;
      private String lblLblobresegapellidofilter_Internalname ;
      private String lblLblobresegapellidofilter_Jsonclick ;
      private String edtavCobresegapellido_Internalname ;
      private String edtavCobresegapellido_Jsonclick ;
      private String divObrefchnacfiltercontainer_Internalname ;
      private String lblLblobrefchnacfilter_Internalname ;
      private String lblLblobrefchnacfilter_Jsonclick ;
      private String edtavCobrefchnac_Internalname ;
      private String edtavCobrefchnac_Jsonclick ;
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
      private String A239ObreCedula ;
      private String edtObreCedula_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtObreID_Internalname ;
      private String edtObreCedula_Internalname ;
      private String edtObrePrNombre_Internalname ;
      private String edtObreSegNombre_Internalname ;
      private String edtObrePrApellido_Internalname ;
      private String edtObreSegApellido_Internalname ;
      private String edtObreFchNac_Internalname ;
      private String scmdbuf ;
      private String lV7cObreCedula ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtObreID_Jsonclick ;
      private String edtObreCedula_Jsonclick ;
      private String edtObrePrNombre_Jsonclick ;
      private String edtObreSegNombre_Jsonclick ;
      private String edtObrePrApellido_Jsonclick ;
      private String edtObreSegApellido_Jsonclick ;
      private String edtObreFchNac_Jsonclick ;
      private DateTime AV12cObreFchNac ;
      private DateTime A245ObreFchNac ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_84_Refreshing=false ;
      private bool n239ObreCedula ;
      private bool n240ObrePrNombre ;
      private bool n241ObreSegNombre ;
      private bool n242ObrePrApellido ;
      private bool n243ObreSegApellido ;
      private bool n245ObreFchNac ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV8cObrePrNombre ;
      private String AV9cObreSegNombre ;
      private String AV10cObrePrApellido ;
      private String AV11cObreSegApellido ;
      private String A240ObrePrNombre ;
      private String A241ObreSegNombre ;
      private String A242ObrePrApellido ;
      private String A243ObreSegApellido ;
      private String AV17Linkselection_GXI ;
      private String lV8cObrePrNombre ;
      private String lV9cObreSegNombre ;
      private String lV10cObrePrApellido ;
      private String lV11cObreSegApellido ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H003S2_A245ObreFchNac ;
      private bool[] H003S2_n245ObreFchNac ;
      private String[] H003S2_A243ObreSegApellido ;
      private bool[] H003S2_n243ObreSegApellido ;
      private String[] H003S2_A242ObrePrApellido ;
      private bool[] H003S2_n242ObrePrApellido ;
      private String[] H003S2_A241ObreSegNombre ;
      private bool[] H003S2_n241ObreSegNombre ;
      private String[] H003S2_A240ObrePrNombre ;
      private bool[] H003S2_n240ObrePrNombre ;
      private String[] H003S2_A239ObreCedula ;
      private bool[] H003S2_n239ObreCedula ;
      private short[] H003S2_A238ObreID ;
      private long[] H003S3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pObreID ;
      private GXWebForm Form ;
   }

   public class gx0150__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H003S2( IGxContext context ,
                                             String AV7cObreCedula ,
                                             String AV8cObrePrNombre ,
                                             String AV9cObreSegNombre ,
                                             String AV10cObrePrApellido ,
                                             String AV11cObreSegApellido ,
                                             DateTime AV12cObreFchNac ,
                                             String A239ObreCedula ,
                                             String A240ObrePrNombre ,
                                             String A241ObreSegNombre ,
                                             String A242ObrePrApellido ,
                                             String A243ObreSegApellido ,
                                             DateTime A245ObreFchNac ,
                                             short AV6cObreID )
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
         sSelectString = " [ObreFchNac], [ObreSegApellido], [ObrePrApellido], [ObreSegNombre], [ObrePrNombre], [ObreCedula], [ObreID]";
         sFromString = " FROM [Obreros] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([ObreID] >= @AV6cObreID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cObreCedula)) )
         {
            sWhereString = sWhereString + " and ([ObreCedula] like @lV7cObreCedula)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cObrePrNombre)) )
         {
            sWhereString = sWhereString + " and ([ObrePrNombre] like @lV8cObrePrNombre)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cObreSegNombre)) )
         {
            sWhereString = sWhereString + " and ([ObreSegNombre] like @lV9cObreSegNombre)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cObrePrApellido)) )
         {
            sWhereString = sWhereString + " and ([ObrePrApellido] like @lV10cObrePrApellido)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cObreSegApellido)) )
         {
            sWhereString = sWhereString + " and ([ObreSegApellido] like @lV11cObreSegApellido)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV12cObreFchNac) )
         {
            sWhereString = sWhereString + " and ([ObreFchNac] >= @AV12cObreFchNac)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [ObreID]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H003S3( IGxContext context ,
                                             String AV7cObreCedula ,
                                             String AV8cObrePrNombre ,
                                             String AV9cObreSegNombre ,
                                             String AV10cObrePrApellido ,
                                             String AV11cObreSegApellido ,
                                             DateTime AV12cObreFchNac ,
                                             String A239ObreCedula ,
                                             String A240ObrePrNombre ,
                                             String A241ObreSegNombre ,
                                             String A242ObrePrApellido ,
                                             String A243ObreSegApellido ,
                                             DateTime A245ObreFchNac ,
                                             short AV6cObreID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Obreros] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([ObreID] >= @AV6cObreID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cObreCedula)) )
         {
            sWhereString = sWhereString + " and ([ObreCedula] like @lV7cObreCedula)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cObrePrNombre)) )
         {
            sWhereString = sWhereString + " and ([ObrePrNombre] like @lV8cObrePrNombre)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cObreSegNombre)) )
         {
            sWhereString = sWhereString + " and ([ObreSegNombre] like @lV9cObreSegNombre)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10cObrePrApellido)) )
         {
            sWhereString = sWhereString + " and ([ObrePrApellido] like @lV10cObrePrApellido)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11cObreSegApellido)) )
         {
            sWhereString = sWhereString + " and ([ObreSegApellido] like @lV11cObreSegApellido)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV12cObreFchNac) )
         {
            sWhereString = sWhereString + " and ([ObreFchNac] >= @AV12cObreFchNac)";
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
                     return conditional_H003S2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (short)dynConstraints[12] );
               case 1 :
                     return conditional_H003S3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (short)dynConstraints[12] );
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
          Object[] prmH003S2 ;
          prmH003S2 = new Object[] {
          new Object[] {"@AV6cObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cObreCedula",SqlDbType.Char,13,0} ,
          new Object[] {"@lV8cObrePrNombre",SqlDbType.VarChar,20,0} ,
          new Object[] {"@lV9cObreSegNombre",SqlDbType.VarChar,20,0} ,
          new Object[] {"@lV10cObrePrApellido",SqlDbType.VarChar,20,0} ,
          new Object[] {"@lV11cObreSegApellido",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV12cObreFchNac",SqlDbType.DateTime,8,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH003S3 ;
          prmH003S3 = new Object[] {
          new Object[] {"@AV6cObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cObreCedula",SqlDbType.Char,13,0} ,
          new Object[] {"@lV8cObrePrNombre",SqlDbType.VarChar,20,0} ,
          new Object[] {"@lV9cObreSegNombre",SqlDbType.VarChar,20,0} ,
          new Object[] {"@lV10cObrePrApellido",SqlDbType.VarChar,20,0} ,
          new Object[] {"@lV11cObreSegApellido",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV12cObreFchNac",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003S2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003S2,11,0,false,false )
             ,new CursorDef("H003S3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003S3,1,0,false,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getString(6, 13) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((short[]) buf[12])[0] = rslt.getShort(7) ;
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
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[16]);
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
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[13]);
                }
                return;
       }
    }

 }

}
