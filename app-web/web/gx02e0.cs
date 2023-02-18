/*
               File: Gx02E0
        Description: Selection List Despacho Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 19:49:33.73
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
   public class gx02e0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx02e0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx02e0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pEmpID ,
                           out short aP1_pAgeID ,
                           out short aP2_pDespBodNro ,
                           out short aP3_pDespBodOpId )
      {
         this.AV13pEmpID = 0 ;
         this.AV14pAgeID = 0 ;
         this.AV15pDespBodNro = 0 ;
         this.AV16pDespBodOpId = 0 ;
         executePrivate();
         aP0_pEmpID=this.AV13pEmpID;
         aP1_pAgeID=this.AV14pAgeID;
         aP2_pDespBodNro=this.AV15pDespBodNro;
         aP3_pDespBodOpId=this.AV16pDespBodOpId;
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
               AV6cEmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cAgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cDespBodNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV9cDespBodOpId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV10cBodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11cDespBodCodPrd = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12cDespBodPrdNombre = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cAgeID, AV8cDespBodNro, AV9cDespBodOpId, AV10cBodCod, AV11cDespBodCodPrd, AV12cDespBodPrdNombre) ;
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
               AV13pEmpID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pEmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pEmpID), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14pAgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pAgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pAgeID), 4, 0)));
                  AV15pDespBodNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pDespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pDespBodNro), 4, 0)));
                  AV16pDespBodOpId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pDespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pDespBodOpId), 4, 0)));
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
         PA5M2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START5M2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202311119493414", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx02e0.aspx") + "?" + UrlEncode("" +AV13pEmpID) + "," + UrlEncode("" +AV14pAgeID) + "," + UrlEncode("" +AV15pDespBodNro) + "," + UrlEncode("" +AV16pDespBodOpId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cEmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cAgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCDESPBODNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cDespBodNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCDESPBODOPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cDespBodOpId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCBODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cBodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCDESPBODCODPRD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cDespBodCodPrd), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCDESPBODPRDNOMBRE", StringUtil.RTrim( AV12cDespBodPrdNombre));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pEmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pAgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPDESPBODNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15pDespBodNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPDESPBODOPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16pDespBodOpId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "EMPIDFILTERCONTAINER_Class", StringUtil.RTrim( divEmpidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "AGEIDFILTERCONTAINER_Class", StringUtil.RTrim( divAgeidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "DESPBODNROFILTERCONTAINER_Class", StringUtil.RTrim( divDespbodnrofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "DESPBODOPIDFILTERCONTAINER_Class", StringUtil.RTrim( divDespbodopidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "BODCODFILTERCONTAINER_Class", StringUtil.RTrim( divBodcodfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "DESPBODCODPRDFILTERCONTAINER_Class", StringUtil.RTrim( divDespbodcodprdfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "DESPBODPRDNOMBREFILTERCONTAINER_Class", StringUtil.RTrim( divDespbodprdnombrefiltercontainer_Class));
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
            WE5M2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT5M2( ) ;
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
         return formatLink("gx02e0.aspx") + "?" + UrlEncode("" +AV13pEmpID) + "," + UrlEncode("" +AV14pAgeID) + "," + UrlEncode("" +AV15pDespBodNro) + "," + UrlEncode("" +AV16pDespBodOpId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx02E0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Despacho Bodega" ;
      }

      protected void WB5M0( )
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
            GxWebStd.gx_div_start( context, divEmpidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEmpidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblempidfilter_Internalname, "Emp ID", "", "", lblLblempidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e115m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx02E0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCempid_Internalname, "Emp ID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCempid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cEmpID), 4, 0, ",", "")), ((edtavCempid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cEmpID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cEmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCempid_Visible, edtavCempid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx02E0.htm");
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
            GxWebStd.gx_div_start( context, divAgeidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divAgeidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblageidfilter_Internalname, "Age ID", "", "", lblLblageidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e125m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx02E0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCageid_Internalname, "Age ID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCageid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cAgeID), 4, 0, ",", "")), ((edtavCageid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cAgeID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV7cAgeID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCageid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCageid_Visible, edtavCageid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx02E0.htm");
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
            GxWebStd.gx_div_start( context, divDespbodnrofiltercontainer_Internalname, 1, 0, "px", 0, "px", divDespbodnrofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldespbodnrofilter_Internalname, "Desp Bod Nro", "", "", lblLbldespbodnrofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e135m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx02E0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdespbodnro_Internalname, "Desp Bod Nro", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdespbodnro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cDespBodNro), 4, 0, ",", "")), ((edtavCdespbodnro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cDespBodNro), "ZZZ9")) : context.localUtil.Format( (decimal)(AV8cDespBodNro), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdespbodnro_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdespbodnro_Visible, edtavCdespbodnro_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx02E0.htm");
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
            GxWebStd.gx_div_start( context, divDespbodopidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divDespbodopidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldespbodopidfilter_Internalname, "Desp Bod Op Id", "", "", lblLbldespbodopidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e145m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx02E0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdespbodopid_Internalname, "Desp Bod Op Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdespbodopid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cDespBodOpId), 4, 0, ",", "")), ((edtavCdespbodopid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cDespBodOpId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV9cDespBodOpId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdespbodopid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdespbodopid_Visible, edtavCdespbodopid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx02E0.htm");
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
            GxWebStd.gx_div_start( context, divBodcodfiltercontainer_Internalname, 1, 0, "px", 0, "px", divBodcodfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblbodcodfilter_Internalname, "Bod Cod", "", "", lblLblbodcodfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e155m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx02E0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCbodcod_Internalname, "Bod Cod", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCbodcod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cBodCod), 4, 0, ",", "")), ((edtavCbodcod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cBodCod), "ZZZ9")) : context.localUtil.Format( (decimal)(AV10cBodCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCbodcod_Jsonclick, 0, "Attribute", "", "", "", "", edtavCbodcod_Visible, edtavCbodcod_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx02E0.htm");
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
            GxWebStd.gx_div_start( context, divDespbodcodprdfiltercontainer_Internalname, 1, 0, "px", 0, "px", divDespbodcodprdfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldespbodcodprdfilter_Internalname, "Cod. Producto", "", "", lblLbldespbodcodprdfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e165m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx02E0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdespbodcodprd_Internalname, "Cod. Producto", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdespbodcodprd_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cDespBodCodPrd), 4, 0, ",", "")), ((edtavCdespbodcodprd_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cDespBodCodPrd), "ZZZ9")) : context.localUtil.Format( (decimal)(AV11cDespBodCodPrd), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdespbodcodprd_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdespbodcodprd_Visible, edtavCdespbodcodprd_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx02E0.htm");
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
            GxWebStd.gx_div_start( context, divDespbodprdnombrefiltercontainer_Internalname, 1, 0, "px", 0, "px", divDespbodprdnombrefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbldespbodprdnombrefilter_Internalname, "Producto", "", "", lblLbldespbodprdnombrefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e175m1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx02E0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCdespbodprdnombre_Internalname, "Producto", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCdespbodprdnombre_Internalname, StringUtil.RTrim( AV12cDespBodPrdNombre), StringUtil.RTrim( context.localUtil.Format( AV12cDespBodPrdNombre, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCdespbodprdnombre_Jsonclick, 0, "Attribute", "", "", "", "", edtavCdespbodprdnombre_Visible, edtavCdespbodprdnombre_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx02E0.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e185m1_client"+"'", TempTags, "", 2, "HLP_Gx02E0.htm");
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
               context.SendWebValue( "Emp ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Age ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nro. Orden") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Bod Cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Producto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Producto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cantidad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Valor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Despachar") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A354DespBodOpId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A355DespBodCodPrd), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A356DespBodPrdNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtDespBodPrdNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A357DespBodCant, 8, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A358DespBodValor, 8, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A359DespBodADesp, 8, 2, ".", "")));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx02E0.htm");
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

      protected void START5M2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Selection List Despacho Bodega", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5M0( ) ;
      }

      protected void WS5M2( )
      {
         START5M2( ) ;
         EVT5M2( ) ;
      }

      protected void EVT5M2( )
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
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV20Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_84_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                              A2AgeID = (short)(context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", "."));
                              A353DespBodNro = (short)(context.localUtil.CToN( cgiGet( edtDespBodNro_Internalname), ",", "."));
                              A354DespBodOpId = (short)(context.localUtil.CToN( cgiGet( edtDespBodOpId_Internalname), ",", "."));
                              A42BodCod = (short)(context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", "."));
                              A355DespBodCodPrd = (short)(context.localUtil.CToN( cgiGet( edtDespBodCodPrd_Internalname), ",", "."));
                              n355DespBodCodPrd = false;
                              A356DespBodPrdNombre = StringUtil.Upper( cgiGet( edtDespBodPrdNombre_Internalname));
                              n356DespBodPrdNombre = false;
                              A357DespBodCant = context.localUtil.CToN( cgiGet( edtDespBodCant_Internalname), ",", ".");
                              n357DespBodCant = false;
                              A358DespBodValor = context.localUtil.CToN( cgiGet( edtDespBodValor_Internalname), ",", ".");
                              n358DespBodValor = false;
                              A359DespBodADesp = context.localUtil.CToN( cgiGet( edtDespBodADesp_Internalname), ",", ".");
                              n359DespBodADesp = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E195M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E205M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cempid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPID"), ",", ".") != Convert.ToDecimal( AV6cEmpID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cageid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAGEID"), ",", ".") != Convert.ToDecimal( AV7cAgeID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cdespbodnro Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDESPBODNRO"), ",", ".") != Convert.ToDecimal( AV8cDespBodNro )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cdespbodopid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDESPBODOPID"), ",", ".") != Convert.ToDecimal( AV9cDespBodOpId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cbodcod Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBODCOD"), ",", ".") != Convert.ToDecimal( AV10cBodCod )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cdespbodcodprd Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDESPBODCODPRD"), ",", ".") != Convert.ToDecimal( AV11cDespBodCodPrd )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cdespbodprdnombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCDESPBODPRDNOMBRE"), AV12cDespBodPrdNombre) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E215M2 ();
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

      protected void WE5M2( )
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

      protected void PA5M2( )
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
                                        short AV6cEmpID ,
                                        short AV7cAgeID ,
                                        short AV8cDespBodNro ,
                                        short AV9cDespBodOpId ,
                                        short AV10cBodCod ,
                                        short AV11cDespBodCodPrd ,
                                        String AV12cDespBodPrdNombre )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF5M2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "EMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_AGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "AGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_DESPBODNRO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A353DespBodNro), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "DESPBODNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_DESPBODOPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A354DespBodOpId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "DESPBODOPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A354DespBodOpId), 4, 0, ".", "")));
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
         RF5M2( ) ;
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

      protected void RF5M2( )
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
                                                 AV10cBodCod ,
                                                 AV11cDespBodCodPrd ,
                                                 AV12cDespBodPrdNombre ,
                                                 A42BodCod ,
                                                 A355DespBodCodPrd ,
                                                 A356DespBodPrdNombre ,
                                                 AV6cEmpID ,
                                                 AV7cAgeID ,
                                                 AV8cDespBodNro ,
                                                 AV9cDespBodOpId } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            lV12cDespBodPrdNombre = StringUtil.PadR( StringUtil.RTrim( AV12cDespBodPrdNombre), 40, "%");
            /* Using cursor H005M2 */
            pr_default.execute(0, new Object[] {AV6cEmpID, AV7cAgeID, AV8cDespBodNro, AV9cDespBodOpId, AV10cBodCod, AV11cDespBodCodPrd, lV12cDespBodPrdNombre, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A359DespBodADesp = H005M2_A359DespBodADesp[0];
               n359DespBodADesp = H005M2_n359DespBodADesp[0];
               A358DespBodValor = H005M2_A358DespBodValor[0];
               n358DespBodValor = H005M2_n358DespBodValor[0];
               A357DespBodCant = H005M2_A357DespBodCant[0];
               n357DespBodCant = H005M2_n357DespBodCant[0];
               A356DespBodPrdNombre = H005M2_A356DespBodPrdNombre[0];
               n356DespBodPrdNombre = H005M2_n356DespBodPrdNombre[0];
               A355DespBodCodPrd = H005M2_A355DespBodCodPrd[0];
               n355DespBodCodPrd = H005M2_n355DespBodCodPrd[0];
               A42BodCod = H005M2_A42BodCod[0];
               A354DespBodOpId = H005M2_A354DespBodOpId[0];
               A353DespBodNro = H005M2_A353DespBodNro[0];
               A2AgeID = H005M2_A2AgeID[0];
               A1EmpID = H005M2_A1EmpID[0];
               /* Execute user event: Load */
               E205M2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB5M0( ) ;
         }
         bGXsfl_84_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5M2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_AGEID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_DESPBODNRO"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A353DespBodNro), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_DESPBODOPID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A354DespBodOpId), "ZZZ9"), context));
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
                                              AV10cBodCod ,
                                              AV11cDespBodCodPrd ,
                                              AV12cDespBodPrdNombre ,
                                              A42BodCod ,
                                              A355DespBodCodPrd ,
                                              A356DespBodPrdNombre ,
                                              AV6cEmpID ,
                                              AV7cAgeID ,
                                              AV8cDespBodNro ,
                                              AV9cDespBodOpId } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         lV12cDespBodPrdNombre = StringUtil.PadR( StringUtil.RTrim( AV12cDespBodPrdNombre), 40, "%");
         /* Using cursor H005M3 */
         pr_default.execute(1, new Object[] {AV6cEmpID, AV7cAgeID, AV8cDespBodNro, AV9cDespBodOpId, AV10cBodCod, AV11cDespBodCodPrd, lV12cDespBodPrdNombre});
         GRID1_nRecordCount = H005M3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cAgeID, AV8cDespBodNro, AV9cDespBodOpId, AV10cBodCod, AV11cDespBodCodPrd, AV12cDespBodPrdNombre) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cAgeID, AV8cDespBodNro, AV9cDespBodOpId, AV10cBodCod, AV11cDespBodCodPrd, AV12cDespBodPrdNombre) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cAgeID, AV8cDespBodNro, AV9cDespBodOpId, AV10cBodCod, AV11cDespBodCodPrd, AV12cDespBodPrdNombre) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cAgeID, AV8cDespBodNro, AV9cDespBodOpId, AV10cBodCod, AV11cDespBodCodPrd, AV12cDespBodPrdNombre) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cAgeID, AV8cDespBodNro, AV9cDespBodOpId, AV10cBodCod, AV11cDespBodCodPrd, AV12cDespBodPrdNombre) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5M0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E195M2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCempid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCempid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEMPID");
               GX_FocusControl = edtavCempid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cEmpID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cEmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cEmpID), 4, 0)));
            }
            else
            {
               AV6cEmpID = (short)(context.localUtil.CToN( cgiGet( edtavCempid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cEmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cEmpID), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCageid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCageid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCAGEID");
               GX_FocusControl = edtavCageid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cAgeID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cAgeID), 4, 0)));
            }
            else
            {
               AV7cAgeID = (short)(context.localUtil.CToN( cgiGet( edtavCageid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cAgeID), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCdespbodnro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCdespbodnro_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCDESPBODNRO");
               GX_FocusControl = edtavCdespbodnro_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cDespBodNro = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cDespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cDespBodNro), 4, 0)));
            }
            else
            {
               AV8cDespBodNro = (short)(context.localUtil.CToN( cgiGet( edtavCdespbodnro_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cDespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cDespBodNro), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCdespbodopid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCdespbodopid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCDESPBODOPID");
               GX_FocusControl = edtavCdespbodopid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cDespBodOpId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cDespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cDespBodOpId), 4, 0)));
            }
            else
            {
               AV9cDespBodOpId = (short)(context.localUtil.CToN( cgiGet( edtavCdespbodopid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cDespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cDespBodOpId), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCbodcod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCbodcod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCBODCOD");
               GX_FocusControl = edtavCbodcod_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cBodCod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cBodCod), 4, 0)));
            }
            else
            {
               AV10cBodCod = (short)(context.localUtil.CToN( cgiGet( edtavCbodcod_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cBodCod), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCdespbodcodprd_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCdespbodcodprd_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCDESPBODCODPRD");
               GX_FocusControl = edtavCdespbodcodprd_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cDespBodCodPrd = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cDespBodCodPrd", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cDespBodCodPrd), 4, 0)));
            }
            else
            {
               AV11cDespBodCodPrd = (short)(context.localUtil.CToN( cgiGet( edtavCdespbodcodprd_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cDespBodCodPrd", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cDespBodCodPrd), 4, 0)));
            }
            AV12cDespBodPrdNombre = StringUtil.Upper( cgiGet( edtavCdespbodprdnombre_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cDespBodPrdNombre", AV12cDespBodPrdNombre);
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ",", "."));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", "."));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", "."));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEMPID"), ",", ".") != Convert.ToDecimal( AV6cEmpID )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCAGEID"), ",", ".") != Convert.ToDecimal( AV7cAgeID )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDESPBODNRO"), ",", ".") != Convert.ToDecimal( AV8cDespBodNro )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDESPBODOPID"), ",", ".") != Convert.ToDecimal( AV9cDespBodOpId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBODCOD"), ",", ".") != Convert.ToDecimal( AV10cBodCod )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDESPBODCODPRD"), ",", ".") != Convert.ToDecimal( AV11cDespBodCodPrd )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCDESPBODPRDNOMBRE"), AV12cDespBodPrdNombre) != 0 )
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
         E195M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E195M2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Despacho Bodega", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV17ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E205M2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV20Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E215M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E215M2( )
      {
         /* Enter Routine */
         AV13pEmpID = A1EmpID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pEmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pEmpID), 4, 0)));
         AV14pAgeID = A2AgeID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pAgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pAgeID), 4, 0)));
         AV15pDespBodNro = A353DespBodNro;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pDespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pDespBodNro), 4, 0)));
         AV16pDespBodOpId = A354DespBodOpId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pDespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pDespBodOpId), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pEmpID,(short)AV14pAgeID,(short)AV15pDespBodNro,(short)AV16pDespBodOpId});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pEmpID","AV14pAgeID","AV15pDespBodNro","AV16pDespBodOpId"});
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
         AV13pEmpID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pEmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pEmpID), 4, 0)));
         AV14pAgeID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pAgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pAgeID), 4, 0)));
         AV15pDespBodNro = Convert.ToInt16(getParm(obj,2));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pDespBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pDespBodNro), 4, 0)));
         AV16pDespBodOpId = Convert.ToInt16(getParm(obj,3));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pDespBodOpId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pDespBodOpId), 4, 0)));
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
         PA5M2( ) ;
         WS5M2( ) ;
         WE5M2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202311119493978", true);
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
         context.AddJavascriptSource("gx02e0.js", "?202311119493980", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtEmpID_Internalname = "EMPID_"+sGXsfl_84_idx;
         edtAgeID_Internalname = "AGEID_"+sGXsfl_84_idx;
         edtDespBodNro_Internalname = "DESPBODNRO_"+sGXsfl_84_idx;
         edtDespBodOpId_Internalname = "DESPBODOPID_"+sGXsfl_84_idx;
         edtBodCod_Internalname = "BODCOD_"+sGXsfl_84_idx;
         edtDespBodCodPrd_Internalname = "DESPBODCODPRD_"+sGXsfl_84_idx;
         edtDespBodPrdNombre_Internalname = "DESPBODPRDNOMBRE_"+sGXsfl_84_idx;
         edtDespBodCant_Internalname = "DESPBODCANT_"+sGXsfl_84_idx;
         edtDespBodValor_Internalname = "DESPBODVALOR_"+sGXsfl_84_idx;
         edtDespBodADesp_Internalname = "DESPBODADESP_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtEmpID_Internalname = "EMPID_"+sGXsfl_84_fel_idx;
         edtAgeID_Internalname = "AGEID_"+sGXsfl_84_fel_idx;
         edtDespBodNro_Internalname = "DESPBODNRO_"+sGXsfl_84_fel_idx;
         edtDespBodOpId_Internalname = "DESPBODOPID_"+sGXsfl_84_fel_idx;
         edtBodCod_Internalname = "BODCOD_"+sGXsfl_84_fel_idx;
         edtDespBodCodPrd_Internalname = "DESPBODCODPRD_"+sGXsfl_84_fel_idx;
         edtDespBodPrdNombre_Internalname = "DESPBODPRDNOMBRE_"+sGXsfl_84_fel_idx;
         edtDespBodCant_Internalname = "DESPBODCANT_"+sGXsfl_84_fel_idx;
         edtDespBodValor_Internalname = "DESPBODVALOR_"+sGXsfl_84_fel_idx;
         edtDespBodADesp_Internalname = "DESPBODADESP_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB5M0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A354DespBodOpId), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_84_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV20Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV20Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEmpID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEmpID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAgeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAgeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A353DespBodNro), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodOpId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A354DespBodOpId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A354DespBodOpId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodOpId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBodCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodCodPrd_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A355DespBodCodPrd), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A355DespBodCodPrd), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodCodPrd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtDespBodPrdNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A353DespBodNro), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A354DespBodOpId), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDespBodPrdNombre_Internalname, "Link", edtDespBodPrdNombre_Link, !bGXsfl_84_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodPrdNombre_Internalname,StringUtil.RTrim( A356DespBodPrdNombre),StringUtil.RTrim( context.localUtil.Format( A356DespBodPrdNombre, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtDespBodPrdNombre_Link,(String)"",(String)"",(String)"",(String)edtDespBodPrdNombre_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodCant_Internalname,StringUtil.LTrim( StringUtil.NToC( A357DespBodCant, 8, 2, ",", "")),context.localUtil.Format( A357DespBodCant, "ZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodCant_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A358DespBodValor, 8, 2, ",", "")),context.localUtil.Format( A358DespBodValor, "ZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDespBodADesp_Internalname,StringUtil.LTrim( StringUtil.NToC( A359DespBodADesp, 8, 2, ",", "")),context.localUtil.Format( A359DespBodADesp, "ZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDespBodADesp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes5M2( ) ;
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
         lblLblempidfilter_Internalname = "LBLEMPIDFILTER";
         edtavCempid_Internalname = "vCEMPID";
         divEmpidfiltercontainer_Internalname = "EMPIDFILTERCONTAINER";
         lblLblageidfilter_Internalname = "LBLAGEIDFILTER";
         edtavCageid_Internalname = "vCAGEID";
         divAgeidfiltercontainer_Internalname = "AGEIDFILTERCONTAINER";
         lblLbldespbodnrofilter_Internalname = "LBLDESPBODNROFILTER";
         edtavCdespbodnro_Internalname = "vCDESPBODNRO";
         divDespbodnrofiltercontainer_Internalname = "DESPBODNROFILTERCONTAINER";
         lblLbldespbodopidfilter_Internalname = "LBLDESPBODOPIDFILTER";
         edtavCdespbodopid_Internalname = "vCDESPBODOPID";
         divDespbodopidfiltercontainer_Internalname = "DESPBODOPIDFILTERCONTAINER";
         lblLblbodcodfilter_Internalname = "LBLBODCODFILTER";
         edtavCbodcod_Internalname = "vCBODCOD";
         divBodcodfiltercontainer_Internalname = "BODCODFILTERCONTAINER";
         lblLbldespbodcodprdfilter_Internalname = "LBLDESPBODCODPRDFILTER";
         edtavCdespbodcodprd_Internalname = "vCDESPBODCODPRD";
         divDespbodcodprdfiltercontainer_Internalname = "DESPBODCODPRDFILTERCONTAINER";
         lblLbldespbodprdnombrefilter_Internalname = "LBLDESPBODPRDNOMBREFILTER";
         edtavCdespbodprdnombre_Internalname = "vCDESPBODPRDNOMBRE";
         divDespbodprdnombrefiltercontainer_Internalname = "DESPBODPRDNOMBREFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtEmpID_Internalname = "EMPID";
         edtAgeID_Internalname = "AGEID";
         edtDespBodNro_Internalname = "DESPBODNRO";
         edtDespBodOpId_Internalname = "DESPBODOPID";
         edtBodCod_Internalname = "BODCOD";
         edtDespBodCodPrd_Internalname = "DESPBODCODPRD";
         edtDespBodPrdNombre_Internalname = "DESPBODPRDNOMBRE";
         edtDespBodCant_Internalname = "DESPBODCANT";
         edtDespBodValor_Internalname = "DESPBODVALOR";
         edtDespBodADesp_Internalname = "DESPBODADESP";
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
         edtDespBodADesp_Jsonclick = "";
         edtDespBodValor_Jsonclick = "";
         edtDespBodCant_Jsonclick = "";
         edtDespBodPrdNombre_Jsonclick = "";
         edtDespBodCodPrd_Jsonclick = "";
         edtBodCod_Jsonclick = "";
         edtDespBodOpId_Jsonclick = "";
         edtDespBodNro_Jsonclick = "";
         edtAgeID_Jsonclick = "";
         edtEmpID_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtDespBodPrdNombre_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCdespbodprdnombre_Jsonclick = "";
         edtavCdespbodprdnombre_Enabled = 1;
         edtavCdespbodprdnombre_Visible = 1;
         edtavCdespbodcodprd_Jsonclick = "";
         edtavCdespbodcodprd_Enabled = 1;
         edtavCdespbodcodprd_Visible = 1;
         edtavCbodcod_Jsonclick = "";
         edtavCbodcod_Enabled = 1;
         edtavCbodcod_Visible = 1;
         edtavCdespbodopid_Jsonclick = "";
         edtavCdespbodopid_Enabled = 1;
         edtavCdespbodopid_Visible = 1;
         edtavCdespbodnro_Jsonclick = "";
         edtavCdespbodnro_Enabled = 1;
         edtavCdespbodnro_Visible = 1;
         edtavCageid_Jsonclick = "";
         edtavCageid_Enabled = 1;
         edtavCageid_Visible = 1;
         edtavCempid_Jsonclick = "";
         edtavCempid_Enabled = 1;
         edtavCempid_Visible = 1;
         divDespbodprdnombrefiltercontainer_Class = "AdvancedContainerItem";
         divDespbodcodprdfiltercontainer_Class = "AdvancedContainerItem";
         divBodcodfiltercontainer_Class = "AdvancedContainerItem";
         divDespbodopidfiltercontainer_Class = "AdvancedContainerItem";
         divDespbodnrofiltercontainer_Class = "AdvancedContainerItem";
         divAgeidfiltercontainer_Class = "AdvancedContainerItem";
         divEmpidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Despacho Bodega";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEmpID',fld:'vCEMPID',pic:'ZZZ9'},{av:'AV7cAgeID',fld:'vCAGEID',pic:'ZZZ9'},{av:'AV8cDespBodNro',fld:'vCDESPBODNRO',pic:'ZZZ9'},{av:'AV9cDespBodOpId',fld:'vCDESPBODOPID',pic:'ZZZ9'},{av:'AV10cBodCod',fld:'vCBODCOD',pic:'ZZZ9'},{av:'AV11cDespBodCodPrd',fld:'vCDESPBODCODPRD',pic:'ZZZ9'},{av:'AV12cDespBodPrdNombre',fld:'vCDESPBODPRDNOMBRE',pic:'@!'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E185M1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLEMPIDFILTER.CLICK","{handler:'E115M1',iparms:[{av:'divEmpidfiltercontainer_Class',ctrl:'EMPIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLEMPIDFILTER.CLICK",",oparms:[{av:'divEmpidfiltercontainer_Class',ctrl:'EMPIDFILTERCONTAINER',prop:'Class'},{av:'edtavCempid_Visible',ctrl:'vCEMPID',prop:'Visible'}]}");
         setEventMetadata("LBLAGEIDFILTER.CLICK","{handler:'E125M1',iparms:[{av:'divAgeidfiltercontainer_Class',ctrl:'AGEIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLAGEIDFILTER.CLICK",",oparms:[{av:'divAgeidfiltercontainer_Class',ctrl:'AGEIDFILTERCONTAINER',prop:'Class'},{av:'edtavCageid_Visible',ctrl:'vCAGEID',prop:'Visible'}]}");
         setEventMetadata("LBLDESPBODNROFILTER.CLICK","{handler:'E135M1',iparms:[{av:'divDespbodnrofiltercontainer_Class',ctrl:'DESPBODNROFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDESPBODNROFILTER.CLICK",",oparms:[{av:'divDespbodnrofiltercontainer_Class',ctrl:'DESPBODNROFILTERCONTAINER',prop:'Class'},{av:'edtavCdespbodnro_Visible',ctrl:'vCDESPBODNRO',prop:'Visible'}]}");
         setEventMetadata("LBLDESPBODOPIDFILTER.CLICK","{handler:'E145M1',iparms:[{av:'divDespbodopidfiltercontainer_Class',ctrl:'DESPBODOPIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDESPBODOPIDFILTER.CLICK",",oparms:[{av:'divDespbodopidfiltercontainer_Class',ctrl:'DESPBODOPIDFILTERCONTAINER',prop:'Class'},{av:'edtavCdespbodopid_Visible',ctrl:'vCDESPBODOPID',prop:'Visible'}]}");
         setEventMetadata("LBLBODCODFILTER.CLICK","{handler:'E155M1',iparms:[{av:'divBodcodfiltercontainer_Class',ctrl:'BODCODFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLBODCODFILTER.CLICK",",oparms:[{av:'divBodcodfiltercontainer_Class',ctrl:'BODCODFILTERCONTAINER',prop:'Class'},{av:'edtavCbodcod_Visible',ctrl:'vCBODCOD',prop:'Visible'}]}");
         setEventMetadata("LBLDESPBODCODPRDFILTER.CLICK","{handler:'E165M1',iparms:[{av:'divDespbodcodprdfiltercontainer_Class',ctrl:'DESPBODCODPRDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDESPBODCODPRDFILTER.CLICK",",oparms:[{av:'divDespbodcodprdfiltercontainer_Class',ctrl:'DESPBODCODPRDFILTERCONTAINER',prop:'Class'},{av:'edtavCdespbodcodprd_Visible',ctrl:'vCDESPBODCODPRD',prop:'Visible'}]}");
         setEventMetadata("LBLDESPBODPRDNOMBREFILTER.CLICK","{handler:'E175M1',iparms:[{av:'divDespbodprdnombrefiltercontainer_Class',ctrl:'DESPBODPRDNOMBREFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLDESPBODPRDNOMBREFILTER.CLICK",",oparms:[{av:'divDespbodprdnombrefiltercontainer_Class',ctrl:'DESPBODPRDNOMBREFILTERCONTAINER',prop:'Class'},{av:'edtavCdespbodprdnombre_Visible',ctrl:'vCDESPBODPRDNOMBRE',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E215M2',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9',hsh:true},{av:'A353DespBodNro',fld:'DESPBODNRO',pic:'ZZZ9',hsh:true},{av:'A354DespBodOpId',fld:'DESPBODOPID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV14pAgeID',fld:'vPAGEID',pic:'ZZZ9'},{av:'AV15pDespBodNro',fld:'vPDESPBODNRO',pic:'ZZZ9'},{av:'AV16pDespBodOpId',fld:'vPDESPBODOPID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEmpID',fld:'vCEMPID',pic:'ZZZ9'},{av:'AV7cAgeID',fld:'vCAGEID',pic:'ZZZ9'},{av:'AV8cDespBodNro',fld:'vCDESPBODNRO',pic:'ZZZ9'},{av:'AV9cDespBodOpId',fld:'vCDESPBODOPID',pic:'ZZZ9'},{av:'AV10cBodCod',fld:'vCBODCOD',pic:'ZZZ9'},{av:'AV11cDespBodCodPrd',fld:'vCDESPBODCODPRD',pic:'ZZZ9'},{av:'AV12cDespBodPrdNombre',fld:'vCDESPBODPRDNOMBRE',pic:'@!'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEmpID',fld:'vCEMPID',pic:'ZZZ9'},{av:'AV7cAgeID',fld:'vCAGEID',pic:'ZZZ9'},{av:'AV8cDespBodNro',fld:'vCDESPBODNRO',pic:'ZZZ9'},{av:'AV9cDespBodOpId',fld:'vCDESPBODOPID',pic:'ZZZ9'},{av:'AV10cBodCod',fld:'vCBODCOD',pic:'ZZZ9'},{av:'AV11cDespBodCodPrd',fld:'vCDESPBODCODPRD',pic:'ZZZ9'},{av:'AV12cDespBodPrdNombre',fld:'vCDESPBODPRDNOMBRE',pic:'@!'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEmpID',fld:'vCEMPID',pic:'ZZZ9'},{av:'AV7cAgeID',fld:'vCAGEID',pic:'ZZZ9'},{av:'AV8cDespBodNro',fld:'vCDESPBODNRO',pic:'ZZZ9'},{av:'AV9cDespBodOpId',fld:'vCDESPBODOPID',pic:'ZZZ9'},{av:'AV10cBodCod',fld:'vCBODCOD',pic:'ZZZ9'},{av:'AV11cDespBodCodPrd',fld:'vCDESPBODCODPRD',pic:'ZZZ9'},{av:'AV12cDespBodPrdNombre',fld:'vCDESPBODPRDNOMBRE',pic:'@!'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEmpID',fld:'vCEMPID',pic:'ZZZ9'},{av:'AV7cAgeID',fld:'vCAGEID',pic:'ZZZ9'},{av:'AV8cDespBodNro',fld:'vCDESPBODNRO',pic:'ZZZ9'},{av:'AV9cDespBodOpId',fld:'vCDESPBODOPID',pic:'ZZZ9'},{av:'AV10cBodCod',fld:'vCBODCOD',pic:'ZZZ9'},{av:'AV11cDespBodCodPrd',fld:'vCDESPBODCODPRD',pic:'ZZZ9'},{av:'AV12cDespBodPrdNombre',fld:'vCDESPBODPRDNOMBRE',pic:'@!'}]");
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
         AV12cDespBodPrdNombre = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblempidfilter_Jsonclick = "";
         TempTags = "";
         lblLblageidfilter_Jsonclick = "";
         lblLbldespbodnrofilter_Jsonclick = "";
         lblLbldespbodopidfilter_Jsonclick = "";
         lblLblbodcodfilter_Jsonclick = "";
         lblLbldespbodcodprdfilter_Jsonclick = "";
         lblLbldespbodprdnombrefilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A356DespBodPrdNombre = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV20Linkselection_GXI = "";
         scmdbuf = "";
         lV12cDespBodPrdNombre = "";
         H005M2_A359DespBodADesp = new decimal[1] ;
         H005M2_n359DespBodADesp = new bool[] {false} ;
         H005M2_A358DespBodValor = new decimal[1] ;
         H005M2_n358DespBodValor = new bool[] {false} ;
         H005M2_A357DespBodCant = new decimal[1] ;
         H005M2_n357DespBodCant = new bool[] {false} ;
         H005M2_A356DespBodPrdNombre = new String[] {""} ;
         H005M2_n356DespBodPrdNombre = new bool[] {false} ;
         H005M2_A355DespBodCodPrd = new short[1] ;
         H005M2_n355DespBodCodPrd = new bool[] {false} ;
         H005M2_A42BodCod = new short[1] ;
         H005M2_A354DespBodOpId = new short[1] ;
         H005M2_A353DespBodNro = new short[1] ;
         H005M2_A2AgeID = new short[1] ;
         H005M2_A1EmpID = new short[1] ;
         H005M3_AGRID1_nRecordCount = new long[1] ;
         AV17ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx02e0__default(),
            new Object[][] {
                new Object[] {
               H005M2_A359DespBodADesp, H005M2_n359DespBodADesp, H005M2_A358DespBodValor, H005M2_n358DespBodValor, H005M2_A357DespBodCant, H005M2_n357DespBodCant, H005M2_A356DespBodPrdNombre, H005M2_n356DespBodPrdNombre, H005M2_A355DespBodCodPrd, H005M2_n355DespBodCodPrd,
               H005M2_A42BodCod, H005M2_A354DespBodOpId, H005M2_A353DespBodNro, H005M2_A2AgeID, H005M2_A1EmpID
               }
               , new Object[] {
               H005M3_AGRID1_nRecordCount
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
      private short AV6cEmpID ;
      private short AV7cAgeID ;
      private short AV8cDespBodNro ;
      private short AV9cDespBodOpId ;
      private short AV10cBodCod ;
      private short AV11cDespBodCodPrd ;
      private short AV13pEmpID ;
      private short AV14pAgeID ;
      private short AV15pDespBodNro ;
      private short AV16pDespBodOpId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short A353DespBodNro ;
      private short A354DespBodOpId ;
      private short A42BodCod ;
      private short A355DespBodCodPrd ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCempid_Enabled ;
      private int edtavCempid_Visible ;
      private int edtavCageid_Enabled ;
      private int edtavCageid_Visible ;
      private int edtavCdespbodnro_Enabled ;
      private int edtavCdespbodnro_Visible ;
      private int edtavCdespbodopid_Enabled ;
      private int edtavCdespbodopid_Visible ;
      private int edtavCbodcod_Enabled ;
      private int edtavCbodcod_Visible ;
      private int edtavCdespbodcodprd_Enabled ;
      private int edtavCdespbodcodprd_Visible ;
      private int edtavCdespbodprdnombre_Visible ;
      private int edtavCdespbodprdnombre_Enabled ;
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
      private decimal A357DespBodCant ;
      private decimal A358DespBodValor ;
      private decimal A359DespBodADesp ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divEmpidfiltercontainer_Class ;
      private String divAgeidfiltercontainer_Class ;
      private String divDespbodnrofiltercontainer_Class ;
      private String divDespbodopidfiltercontainer_Class ;
      private String divBodcodfiltercontainer_Class ;
      private String divDespbodcodprdfiltercontainer_Class ;
      private String divDespbodprdnombrefiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_84_idx="0001" ;
      private String AV12cDespBodPrdNombre ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divEmpidfiltercontainer_Internalname ;
      private String lblLblempidfilter_Internalname ;
      private String lblLblempidfilter_Jsonclick ;
      private String edtavCempid_Internalname ;
      private String TempTags ;
      private String edtavCempid_Jsonclick ;
      private String divAgeidfiltercontainer_Internalname ;
      private String lblLblageidfilter_Internalname ;
      private String lblLblageidfilter_Jsonclick ;
      private String edtavCageid_Internalname ;
      private String edtavCageid_Jsonclick ;
      private String divDespbodnrofiltercontainer_Internalname ;
      private String lblLbldespbodnrofilter_Internalname ;
      private String lblLbldespbodnrofilter_Jsonclick ;
      private String edtavCdespbodnro_Internalname ;
      private String edtavCdespbodnro_Jsonclick ;
      private String divDespbodopidfiltercontainer_Internalname ;
      private String lblLbldespbodopidfilter_Internalname ;
      private String lblLbldespbodopidfilter_Jsonclick ;
      private String edtavCdespbodopid_Internalname ;
      private String edtavCdespbodopid_Jsonclick ;
      private String divBodcodfiltercontainer_Internalname ;
      private String lblLblbodcodfilter_Internalname ;
      private String lblLblbodcodfilter_Jsonclick ;
      private String edtavCbodcod_Internalname ;
      private String edtavCbodcod_Jsonclick ;
      private String divDespbodcodprdfiltercontainer_Internalname ;
      private String lblLbldespbodcodprdfilter_Internalname ;
      private String lblLbldespbodcodprdfilter_Jsonclick ;
      private String edtavCdespbodcodprd_Internalname ;
      private String edtavCdespbodcodprd_Jsonclick ;
      private String divDespbodprdnombrefiltercontainer_Internalname ;
      private String lblLbldespbodprdnombrefilter_Internalname ;
      private String lblLbldespbodprdnombrefilter_Jsonclick ;
      private String edtavCdespbodprdnombre_Internalname ;
      private String edtavCdespbodprdnombre_Jsonclick ;
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
      private String A356DespBodPrdNombre ;
      private String edtDespBodPrdNombre_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtEmpID_Internalname ;
      private String edtAgeID_Internalname ;
      private String edtDespBodNro_Internalname ;
      private String edtDespBodOpId_Internalname ;
      private String edtBodCod_Internalname ;
      private String edtDespBodCodPrd_Internalname ;
      private String edtDespBodPrdNombre_Internalname ;
      private String edtDespBodCant_Internalname ;
      private String edtDespBodValor_Internalname ;
      private String edtDespBodADesp_Internalname ;
      private String scmdbuf ;
      private String lV12cDespBodPrdNombre ;
      private String AV17ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtEmpID_Jsonclick ;
      private String edtAgeID_Jsonclick ;
      private String edtDespBodNro_Jsonclick ;
      private String edtDespBodOpId_Jsonclick ;
      private String edtBodCod_Jsonclick ;
      private String edtDespBodCodPrd_Jsonclick ;
      private String edtDespBodPrdNombre_Jsonclick ;
      private String edtDespBodCant_Jsonclick ;
      private String edtDespBodValor_Jsonclick ;
      private String edtDespBodADesp_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_84_Refreshing=false ;
      private bool n355DespBodCodPrd ;
      private bool n356DespBodPrdNombre ;
      private bool n357DespBodCant ;
      private bool n358DespBodValor ;
      private bool n359DespBodADesp ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV20Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] H005M2_A359DespBodADesp ;
      private bool[] H005M2_n359DespBodADesp ;
      private decimal[] H005M2_A358DespBodValor ;
      private bool[] H005M2_n358DespBodValor ;
      private decimal[] H005M2_A357DespBodCant ;
      private bool[] H005M2_n357DespBodCant ;
      private String[] H005M2_A356DespBodPrdNombre ;
      private bool[] H005M2_n356DespBodPrdNombre ;
      private short[] H005M2_A355DespBodCodPrd ;
      private bool[] H005M2_n355DespBodCodPrd ;
      private short[] H005M2_A42BodCod ;
      private short[] H005M2_A354DespBodOpId ;
      private short[] H005M2_A353DespBodNro ;
      private short[] H005M2_A2AgeID ;
      private short[] H005M2_A1EmpID ;
      private long[] H005M3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pEmpID ;
      private short aP1_pAgeID ;
      private short aP2_pDespBodNro ;
      private short aP3_pDespBodOpId ;
      private GXWebForm Form ;
   }

   public class gx02e0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005M2( IGxContext context ,
                                             short AV10cBodCod ,
                                             short AV11cDespBodCodPrd ,
                                             String AV12cDespBodPrdNombre ,
                                             short A42BodCod ,
                                             short A355DespBodCodPrd ,
                                             String A356DespBodPrdNombre ,
                                             short AV6cEmpID ,
                                             short AV7cAgeID ,
                                             short AV8cDespBodNro ,
                                             short AV9cDespBodOpId )
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
         sSelectString = " [DespBodADesp], [DespBodValor], [DespBodCant], [DespBodPrdNombre], [DespBodCodPrd], [BodCod], [DespBodOpId], [DespBodNro], [AgeID], [EmpID]";
         sFromString = " FROM [DespBodega] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([EmpID] >= @AV6cEmpID and [AgeID] >= @AV7cAgeID and [DespBodNro] >= @AV8cDespBodNro and [DespBodOpId] >= @AV9cDespBodOpId)";
         if ( ! (0==AV10cBodCod) )
         {
            sWhereString = sWhereString + " and ([BodCod] >= @AV10cBodCod)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV11cDespBodCodPrd) )
         {
            sWhereString = sWhereString + " and ([DespBodCodPrd] >= @AV11cDespBodCodPrd)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cDespBodPrdNombre)) )
         {
            sWhereString = sWhereString + " and ([DespBodPrdNombre] like @lV12cDespBodPrdNombre)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [EmpID], [AgeID], [DespBodNro], [DespBodOpId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H005M3( IGxContext context ,
                                             short AV10cBodCod ,
                                             short AV11cDespBodCodPrd ,
                                             String AV12cDespBodPrdNombre ,
                                             short A42BodCod ,
                                             short A355DespBodCodPrd ,
                                             String A356DespBodPrdNombre ,
                                             short AV6cEmpID ,
                                             short AV7cAgeID ,
                                             short AV8cDespBodNro ,
                                             short AV9cDespBodOpId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [DespBodega] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([EmpID] >= @AV6cEmpID and [AgeID] >= @AV7cAgeID and [DespBodNro] >= @AV8cDespBodNro and [DespBodOpId] >= @AV9cDespBodOpId)";
         if ( ! (0==AV10cBodCod) )
         {
            sWhereString = sWhereString + " and ([BodCod] >= @AV10cBodCod)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV11cDespBodCodPrd) )
         {
            sWhereString = sWhereString + " and ([DespBodCodPrd] >= @AV11cDespBodCodPrd)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12cDespBodPrdNombre)) )
         {
            sWhereString = sWhereString + " and ([DespBodPrdNombre] like @lV12cDespBodPrdNombre)";
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
                     return conditional_H005M2(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] );
               case 1 :
                     return conditional_H005M3(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] );
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
          Object[] prmH005M2 ;
          prmH005M2 = new Object[] {
          new Object[] {"@AV6cEmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cAgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cDespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cDespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cBodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cDespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV12cDespBodPrdNombre",SqlDbType.Char,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005M3 ;
          prmH005M3 = new Object[] {
          new Object[] {"@AV6cEmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cAgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cDespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cDespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cBodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cDespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV12cDespBodPrdNombre",SqlDbType.Char,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005M2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005M2,11,0,false,false )
             ,new CursorDef("H005M3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005M3,1,0,false,false )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((short[]) buf[10])[0] = rslt.getShort(6) ;
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                ((short[]) buf[14])[0] = rslt.getShort(10) ;
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
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
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
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
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
