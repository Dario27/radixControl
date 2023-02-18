/*
               File: Gx00S0
        Description: Selection List Cotizador
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:16:35.13
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
   public class gx00s0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00s0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx00s0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pEmpID ,
                           out short aP1_pCotiID )
      {
         this.AV13pEmpID = 0 ;
         this.AV14pCotiID = 0 ;
         executePrivate();
         aP0_pEmpID=this.AV13pEmpID;
         aP1_pCotiID=this.AV14pCotiID;
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
               AV7cCotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV8cCotiDsc = GetNextPar( );
               AV9cprotID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV10cCotiIVA = NumberUtil.Val( GetNextPar( ), ".");
               AV11cCotiUltNro = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV12cCotiUltNroObr = (int)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cCotiID, AV8cCotiDsc, AV9cprotID, AV10cCotiIVA, AV11cCotiUltNro, AV12cCotiUltNroObr) ;
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
                  AV14pCotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pCotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pCotiID), 4, 0)));
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
         PA322( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START322( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022102620163533", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00s0.aspx") + "?" + UrlEncode("" +AV13pEmpID) + "," + UrlEncode("" +AV14pCotiID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCCOTIID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cCotiID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCOTIDSC", AV8cCotiDsc);
         GxWebStd.gx_hidden_field( context, "GXH_vCPROTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cprotID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCOTIIVA", StringUtil.LTrim( StringUtil.NToC( AV10cCotiIVA, 8, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCOTIULTNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cCotiUltNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCOTIULTNROOBR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cCotiUltNroObr), 8, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pEmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPCOTIID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pCotiID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "EMPIDFILTERCONTAINER_Class", StringUtil.RTrim( divEmpidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "COTIIDFILTERCONTAINER_Class", StringUtil.RTrim( divCotiidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "COTIDSCFILTERCONTAINER_Class", StringUtil.RTrim( divCotidscfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PROTIDFILTERCONTAINER_Class", StringUtil.RTrim( divProtidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "COTIIVAFILTERCONTAINER_Class", StringUtil.RTrim( divCotiivafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "COTIULTNROFILTERCONTAINER_Class", StringUtil.RTrim( divCotiultnrofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "COTIULTNROOBRFILTERCONTAINER_Class", StringUtil.RTrim( divCotiultnroobrfiltercontainer_Class));
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
            WE322( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT322( ) ;
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
         return formatLink("gx00s0.aspx") + "?" + UrlEncode("" +AV13pEmpID) + "," + UrlEncode("" +AV14pCotiID) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00S0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Cotizador" ;
      }

      protected void WB320( )
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
            GxWebStd.gx_label_ctrl( context, lblLblempidfilter_Internalname, "Emp ID", "", "", lblLblempidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11321_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00S0.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCempid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cEmpID), 4, 0, ",", "")), ((edtavCempid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cEmpID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cEmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCempid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCempid_Visible, edtavCempid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00S0.htm");
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
            GxWebStd.gx_div_start( context, divCotiidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divCotiidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblcotiidfilter_Internalname, "Coti ID", "", "", lblLblcotiidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12321_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00S0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCcotiid_Internalname, "Coti ID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCcotiid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cCotiID), 4, 0, ",", "")), ((edtavCcotiid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cCotiID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV7cCotiID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCcotiid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCcotiid_Visible, edtavCcotiid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00S0.htm");
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
            GxWebStd.gx_div_start( context, divCotidscfiltercontainer_Internalname, 1, 0, "px", 0, "px", divCotidscfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblcotidscfilter_Internalname, "Descripcion", "", "", lblLblcotidscfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13321_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00S0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCcotidsc_Internalname, "Descripcion", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCcotidsc_Internalname, AV8cCotiDsc, StringUtil.RTrim( context.localUtil.Format( AV8cCotiDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCcotidsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavCcotidsc_Visible, edtavCcotidsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Gx00S0.htm");
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
            GxWebStd.gx_div_start( context, divProtidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divProtidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblprotidfilter_Internalname, "prot ID", "", "", lblLblprotidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14321_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00S0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCprotid_Internalname, "prot ID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCprotid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cprotID), 4, 0, ",", "")), ((edtavCprotid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cprotID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV9cprotID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCprotid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCprotid_Visible, edtavCprotid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00S0.htm");
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
            GxWebStd.gx_div_start( context, divCotiivafiltercontainer_Internalname, 1, 0, "px", 0, "px", divCotiivafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblcotiivafilter_Internalname, "IVA", "", "", lblLblcotiivafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15321_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00S0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCcotiiva_Internalname, "IVA", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCcotiiva_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10cCotiIVA, 8, 3, ",", "")), ((edtavCcotiiva_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10cCotiIVA, "ZZZ9.999")) : context.localUtil.Format( AV10cCotiIVA, "ZZZ9.999")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','3');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCcotiiva_Jsonclick, 0, "Attribute", "", "", "", "", edtavCcotiiva_Visible, edtavCcotiiva_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00S0.htm");
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
            GxWebStd.gx_div_start( context, divCotiultnrofiltercontainer_Internalname, 1, 0, "px", 0, "px", divCotiultnrofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblcotiultnrofilter_Internalname, "Ult Nro", "", "", lblLblcotiultnrofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16321_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00S0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCcotiultnro_Internalname, "Ult Nro", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCcotiultnro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cCotiUltNro), 8, 0, ",", "")), ((edtavCcotiultnro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cCotiUltNro), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV11cCotiUltNro), "ZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCcotiultnro_Jsonclick, 0, "Attribute", "", "", "", "", edtavCcotiultnro_Visible, edtavCcotiultnro_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00S0.htm");
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
            GxWebStd.gx_div_start( context, divCotiultnroobrfiltercontainer_Internalname, 1, 0, "px", 0, "px", divCotiultnroobrfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblcotiultnroobrfilter_Internalname, "Coti Ult Nro Obr", "", "", lblLblcotiultnroobrfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17321_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00S0.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCcotiultnroobr_Internalname, "Coti Ult Nro Obr", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCcotiultnroobr_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cCotiUltNroObr), 8, 0, ",", "")), ((edtavCcotiultnroobr_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12cCotiUltNroObr), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV12cCotiUltNroObr), "ZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCcotiultnroobr_Jsonclick, 0, "Attribute", "", "", "", "", edtavCcotiultnroobr_Visible, edtavCcotiultnroobr_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx00S0.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18321_client"+"'", TempTags, "", 2, "HLP_Gx00S0.htm");
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
               context.SendWebValue( "Nro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Descripcion") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "prot ID") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34CotiID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", A154CotiDsc);
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtCotiDsc_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ".", "")));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00S0.htm");
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

      protected void START322( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Selection List Cotizador", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP320( ) ;
      }

      protected void WS322( )
      {
         START322( ) ;
         EVT322( ) ;
      }

      protected void EVT322( )
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
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_84_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                              A34CotiID = (short)(context.localUtil.CToN( cgiGet( edtCotiID_Internalname), ",", "."));
                              A154CotiDsc = cgiGet( edtCotiDsc_Internalname);
                              n154CotiDsc = false;
                              A10protID = (short)(context.localUtil.CToN( cgiGet( edtprotID_Internalname), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E19322 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E20322 ();
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
                                       /* Set Refresh If Ccotiid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCOTIID"), ",", ".") != Convert.ToDecimal( AV7cCotiID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ccotidsc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCOTIDSC"), AV8cCotiDsc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cprotid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPROTID"), ",", ".") != Convert.ToDecimal( AV9cprotID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ccotiiva Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCCOTIIVA"), ",", ".") != AV10cCotiIVA )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ccotiultnro Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCOTIULTNRO"), ",", ".") != Convert.ToDecimal( AV11cCotiUltNro )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ccotiultnroobr Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCOTIULTNROOBR"), ",", ".") != Convert.ToDecimal( AV12cCotiUltNroObr )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E21322 ();
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

      protected void WE322( )
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

      protected void PA322( )
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
                                        short AV7cCotiID ,
                                        String AV8cCotiDsc ,
                                        short AV9cprotID ,
                                        decimal AV10cCotiIVA ,
                                        int AV11cCotiUltNro ,
                                        int AV12cCotiUltNroObr )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF322( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "EMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_COTIID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A34CotiID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "COTIID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34CotiID), 4, 0, ".", "")));
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
         RF322( ) ;
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

      protected void RF322( )
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
                                                 AV8cCotiDsc ,
                                                 AV9cprotID ,
                                                 AV10cCotiIVA ,
                                                 AV11cCotiUltNro ,
                                                 AV12cCotiUltNroObr ,
                                                 A154CotiDsc ,
                                                 A10protID ,
                                                 A155CotiIVA ,
                                                 A156CotiUltNro ,
                                                 A201CotiUltNroObr ,
                                                 AV6cEmpID ,
                                                 AV7cCotiID } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                                 TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            lV8cCotiDsc = StringUtil.Concat( StringUtil.RTrim( AV8cCotiDsc), "%", "");
            /* Using cursor H00322 */
            pr_default.execute(0, new Object[] {AV6cEmpID, AV7cCotiID, lV8cCotiDsc, AV9cprotID, AV10cCotiIVA, AV11cCotiUltNro, AV12cCotiUltNroObr, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            SubsflControlProps_842( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A201CotiUltNroObr = H00322_A201CotiUltNroObr[0];
               n201CotiUltNroObr = H00322_n201CotiUltNroObr[0];
               A156CotiUltNro = H00322_A156CotiUltNro[0];
               n156CotiUltNro = H00322_n156CotiUltNro[0];
               A155CotiIVA = H00322_A155CotiIVA[0];
               n155CotiIVA = H00322_n155CotiIVA[0];
               A10protID = H00322_A10protID[0];
               A154CotiDsc = H00322_A154CotiDsc[0];
               n154CotiDsc = H00322_n154CotiDsc[0];
               A34CotiID = H00322_A34CotiID[0];
               A1EmpID = H00322_A1EmpID[0];
               /* Execute user event: Load */
               E20322 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB320( ) ;
         }
         bGXsfl_84_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes322( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_COTIID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A34CotiID), "ZZZ9"), context));
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
                                              AV8cCotiDsc ,
                                              AV9cprotID ,
                                              AV10cCotiIVA ,
                                              AV11cCotiUltNro ,
                                              AV12cCotiUltNroObr ,
                                              A154CotiDsc ,
                                              A10protID ,
                                              A155CotiIVA ,
                                              A156CotiUltNro ,
                                              A201CotiUltNroObr ,
                                              AV6cEmpID ,
                                              AV7cCotiID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         lV8cCotiDsc = StringUtil.Concat( StringUtil.RTrim( AV8cCotiDsc), "%", "");
         /* Using cursor H00323 */
         pr_default.execute(1, new Object[] {AV6cEmpID, AV7cCotiID, lV8cCotiDsc, AV9cprotID, AV10cCotiIVA, AV11cCotiUltNro, AV12cCotiUltNroObr});
         GRID1_nRecordCount = H00323_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cCotiID, AV8cCotiDsc, AV9cprotID, AV10cCotiIVA, AV11cCotiUltNro, AV12cCotiUltNroObr) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cCotiID, AV8cCotiDsc, AV9cprotID, AV10cCotiIVA, AV11cCotiUltNro, AV12cCotiUltNroObr) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cCotiID, AV8cCotiDsc, AV9cprotID, AV10cCotiIVA, AV11cCotiUltNro, AV12cCotiUltNroObr) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cCotiID, AV8cCotiDsc, AV9cprotID, AV10cCotiIVA, AV11cCotiUltNro, AV12cCotiUltNroObr) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEmpID, AV7cCotiID, AV8cCotiDsc, AV9cprotID, AV10cCotiIVA, AV11cCotiUltNro, AV12cCotiUltNroObr) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP320( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E19322 ();
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcotiid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcotiid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCOTIID");
               GX_FocusControl = edtavCcotiid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cCotiID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cCotiID), 4, 0)));
            }
            else
            {
               AV7cCotiID = (short)(context.localUtil.CToN( cgiGet( edtavCcotiid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cCotiID), 4, 0)));
            }
            AV8cCotiDsc = cgiGet( edtavCcotidsc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCotiDsc", AV8cCotiDsc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCprotid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCprotid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPROTID");
               GX_FocusControl = edtavCprotid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cprotID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cprotID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cprotID), 4, 0)));
            }
            else
            {
               AV9cprotID = (short)(context.localUtil.CToN( cgiGet( edtavCprotid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cprotID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cprotID), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcotiiva_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcotiiva_Internalname), ",", ".") > 9999.999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCOTIIVA");
               GX_FocusControl = edtavCcotiiva_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cCotiIVA = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCotiIVA", StringUtil.LTrim( StringUtil.Str( AV10cCotiIVA, 8, 3)));
            }
            else
            {
               AV10cCotiIVA = context.localUtil.CToN( cgiGet( edtavCcotiiva_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCotiIVA", StringUtil.LTrim( StringUtil.Str( AV10cCotiIVA, 8, 3)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcotiultnro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcotiultnro_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCOTIULTNRO");
               GX_FocusControl = edtavCcotiultnro_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cCotiUltNro = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cCotiUltNro), 8, 0)));
            }
            else
            {
               AV11cCotiUltNro = (int)(context.localUtil.CToN( cgiGet( edtavCcotiultnro_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cCotiUltNro), 8, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcotiultnroobr_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcotiultnroobr_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCOTIULTNROOBR");
               GX_FocusControl = edtavCcotiultnroobr_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cCotiUltNroObr = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cCotiUltNroObr", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cCotiUltNroObr), 8, 0)));
            }
            else
            {
               AV12cCotiUltNroObr = (int)(context.localUtil.CToN( cgiGet( edtavCcotiultnroobr_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cCotiUltNroObr", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cCotiUltNroObr), 8, 0)));
            }
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCOTIID"), ",", ".") != Convert.ToDecimal( AV7cCotiID )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCCOTIDSC"), AV8cCotiDsc) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPROTID"), ",", ".") != Convert.ToDecimal( AV9cprotID )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCCOTIIVA"), ",", ".") != AV10cCotiIVA )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCOTIULTNRO"), ",", ".") != Convert.ToDecimal( AV11cCotiUltNro )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCOTIULTNROOBR"), ",", ".") != Convert.ToDecimal( AV12cCotiUltNroObr )) )
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
         E19322 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19322( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Cotizador", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV15ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20322( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV18Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E21322 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21322( )
      {
         /* Enter Routine */
         AV13pEmpID = A1EmpID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pEmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pEmpID), 4, 0)));
         AV14pCotiID = A34CotiID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pCotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pCotiID), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pEmpID,(short)AV14pCotiID});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pEmpID","AV14pCotiID"});
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
         AV14pCotiID = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pCotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pCotiID), 4, 0)));
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
         PA322( ) ;
         WS322( ) ;
         WE322( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022102620163912", true);
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
         context.AddJavascriptSource("gx00s0.js", "?2022102620163913", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtEmpID_Internalname = "EMPID_"+sGXsfl_84_idx;
         edtCotiID_Internalname = "COTIID_"+sGXsfl_84_idx;
         edtCotiDsc_Internalname = "COTIDSC_"+sGXsfl_84_idx;
         edtprotID_Internalname = "PROTID_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtEmpID_Internalname = "EMPID_"+sGXsfl_84_fel_idx;
         edtCotiID_Internalname = "COTIID_"+sGXsfl_84_fel_idx;
         edtCotiDsc_Internalname = "COTIDSC_"+sGXsfl_84_fel_idx;
         edtprotID_Internalname = "PROTID_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB320( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A34CotiID), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_84_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV18Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCotiID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A34CotiID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A34CotiID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCotiID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtCotiDsc_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A34CotiID), 4, 0, ",", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiDsc_Internalname, "Link", edtCotiDsc_Link, !bGXsfl_84_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCotiDsc_Internalname,(String)A154CotiDsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtCotiDsc_Link,(String)"",(String)"",(String)"",(String)edtCotiDsc_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprotID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A10protID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprotID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
            send_integrity_lvl_hashes322( ) ;
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
         lblLblcotiidfilter_Internalname = "LBLCOTIIDFILTER";
         edtavCcotiid_Internalname = "vCCOTIID";
         divCotiidfiltercontainer_Internalname = "COTIIDFILTERCONTAINER";
         lblLblcotidscfilter_Internalname = "LBLCOTIDSCFILTER";
         edtavCcotidsc_Internalname = "vCCOTIDSC";
         divCotidscfiltercontainer_Internalname = "COTIDSCFILTERCONTAINER";
         lblLblprotidfilter_Internalname = "LBLPROTIDFILTER";
         edtavCprotid_Internalname = "vCPROTID";
         divProtidfiltercontainer_Internalname = "PROTIDFILTERCONTAINER";
         lblLblcotiivafilter_Internalname = "LBLCOTIIVAFILTER";
         edtavCcotiiva_Internalname = "vCCOTIIVA";
         divCotiivafiltercontainer_Internalname = "COTIIVAFILTERCONTAINER";
         lblLblcotiultnrofilter_Internalname = "LBLCOTIULTNROFILTER";
         edtavCcotiultnro_Internalname = "vCCOTIULTNRO";
         divCotiultnrofiltercontainer_Internalname = "COTIULTNROFILTERCONTAINER";
         lblLblcotiultnroobrfilter_Internalname = "LBLCOTIULTNROOBRFILTER";
         edtavCcotiultnroobr_Internalname = "vCCOTIULTNROOBR";
         divCotiultnroobrfiltercontainer_Internalname = "COTIULTNROOBRFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtEmpID_Internalname = "EMPID";
         edtCotiID_Internalname = "COTIID";
         edtCotiDsc_Internalname = "COTIDSC";
         edtprotID_Internalname = "PROTID";
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
         edtprotID_Jsonclick = "";
         edtCotiDsc_Jsonclick = "";
         edtCotiID_Jsonclick = "";
         edtEmpID_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtCotiDsc_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCcotiultnroobr_Jsonclick = "";
         edtavCcotiultnroobr_Enabled = 1;
         edtavCcotiultnroobr_Visible = 1;
         edtavCcotiultnro_Jsonclick = "";
         edtavCcotiultnro_Enabled = 1;
         edtavCcotiultnro_Visible = 1;
         edtavCcotiiva_Jsonclick = "";
         edtavCcotiiva_Enabled = 1;
         edtavCcotiiva_Visible = 1;
         edtavCprotid_Jsonclick = "";
         edtavCprotid_Enabled = 1;
         edtavCprotid_Visible = 1;
         edtavCcotidsc_Jsonclick = "";
         edtavCcotidsc_Enabled = 1;
         edtavCcotidsc_Visible = 1;
         edtavCcotiid_Jsonclick = "";
         edtavCcotiid_Enabled = 1;
         edtavCcotiid_Visible = 1;
         edtavCempid_Jsonclick = "";
         edtavCempid_Enabled = 1;
         edtavCempid_Visible = 1;
         divCotiultnroobrfiltercontainer_Class = "AdvancedContainerItem";
         divCotiultnrofiltercontainer_Class = "AdvancedContainerItem";
         divCotiivafiltercontainer_Class = "AdvancedContainerItem";
         divProtidfiltercontainer_Class = "AdvancedContainerItem";
         divCotidscfiltercontainer_Class = "AdvancedContainerItem";
         divCotiidfiltercontainer_Class = "AdvancedContainerItem";
         divEmpidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Cotizador";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEmpID',fld:'vCEMPID',pic:'ZZZ9'},{av:'AV7cCotiID',fld:'vCCOTIID',pic:'ZZZ9'},{av:'AV8cCotiDsc',fld:'vCCOTIDSC',pic:''},{av:'AV9cprotID',fld:'vCPROTID',pic:'ZZZ9'},{av:'AV10cCotiIVA',fld:'vCCOTIIVA',pic:'ZZZ9.999'},{av:'AV11cCotiUltNro',fld:'vCCOTIULTNRO',pic:'ZZZZZZZ9'},{av:'AV12cCotiUltNroObr',fld:'vCCOTIULTNROOBR',pic:'ZZZZZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18321',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLEMPIDFILTER.CLICK","{handler:'E11321',iparms:[{av:'divEmpidfiltercontainer_Class',ctrl:'EMPIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLEMPIDFILTER.CLICK",",oparms:[{av:'divEmpidfiltercontainer_Class',ctrl:'EMPIDFILTERCONTAINER',prop:'Class'},{av:'edtavCempid_Visible',ctrl:'vCEMPID',prop:'Visible'}]}");
         setEventMetadata("LBLCOTIIDFILTER.CLICK","{handler:'E12321',iparms:[{av:'divCotiidfiltercontainer_Class',ctrl:'COTIIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLCOTIIDFILTER.CLICK",",oparms:[{av:'divCotiidfiltercontainer_Class',ctrl:'COTIIDFILTERCONTAINER',prop:'Class'},{av:'edtavCcotiid_Visible',ctrl:'vCCOTIID',prop:'Visible'}]}");
         setEventMetadata("LBLCOTIDSCFILTER.CLICK","{handler:'E13321',iparms:[{av:'divCotidscfiltercontainer_Class',ctrl:'COTIDSCFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLCOTIDSCFILTER.CLICK",",oparms:[{av:'divCotidscfiltercontainer_Class',ctrl:'COTIDSCFILTERCONTAINER',prop:'Class'},{av:'edtavCcotidsc_Visible',ctrl:'vCCOTIDSC',prop:'Visible'}]}");
         setEventMetadata("LBLPROTIDFILTER.CLICK","{handler:'E14321',iparms:[{av:'divProtidfiltercontainer_Class',ctrl:'PROTIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLPROTIDFILTER.CLICK",",oparms:[{av:'divProtidfiltercontainer_Class',ctrl:'PROTIDFILTERCONTAINER',prop:'Class'},{av:'edtavCprotid_Visible',ctrl:'vCPROTID',prop:'Visible'}]}");
         setEventMetadata("LBLCOTIIVAFILTER.CLICK","{handler:'E15321',iparms:[{av:'divCotiivafiltercontainer_Class',ctrl:'COTIIVAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLCOTIIVAFILTER.CLICK",",oparms:[{av:'divCotiivafiltercontainer_Class',ctrl:'COTIIVAFILTERCONTAINER',prop:'Class'},{av:'edtavCcotiiva_Visible',ctrl:'vCCOTIIVA',prop:'Visible'}]}");
         setEventMetadata("LBLCOTIULTNROFILTER.CLICK","{handler:'E16321',iparms:[{av:'divCotiultnrofiltercontainer_Class',ctrl:'COTIULTNROFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLCOTIULTNROFILTER.CLICK",",oparms:[{av:'divCotiultnrofiltercontainer_Class',ctrl:'COTIULTNROFILTERCONTAINER',prop:'Class'},{av:'edtavCcotiultnro_Visible',ctrl:'vCCOTIULTNRO',prop:'Visible'}]}");
         setEventMetadata("LBLCOTIULTNROOBRFILTER.CLICK","{handler:'E17321',iparms:[{av:'divCotiultnroobrfiltercontainer_Class',ctrl:'COTIULTNROOBRFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLCOTIULTNROOBRFILTER.CLICK",",oparms:[{av:'divCotiultnroobrfiltercontainer_Class',ctrl:'COTIULTNROOBRFILTERCONTAINER',prop:'Class'},{av:'edtavCcotiultnroobr_Visible',ctrl:'vCCOTIULTNROOBR',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E21322',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A34CotiID',fld:'COTIID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pEmpID',fld:'vPEMPID',pic:'ZZZ9'},{av:'AV14pCotiID',fld:'vPCOTIID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEmpID',fld:'vCEMPID',pic:'ZZZ9'},{av:'AV7cCotiID',fld:'vCCOTIID',pic:'ZZZ9'},{av:'AV8cCotiDsc',fld:'vCCOTIDSC',pic:''},{av:'AV9cprotID',fld:'vCPROTID',pic:'ZZZ9'},{av:'AV10cCotiIVA',fld:'vCCOTIIVA',pic:'ZZZ9.999'},{av:'AV11cCotiUltNro',fld:'vCCOTIULTNRO',pic:'ZZZZZZZ9'},{av:'AV12cCotiUltNroObr',fld:'vCCOTIULTNROOBR',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEmpID',fld:'vCEMPID',pic:'ZZZ9'},{av:'AV7cCotiID',fld:'vCCOTIID',pic:'ZZZ9'},{av:'AV8cCotiDsc',fld:'vCCOTIDSC',pic:''},{av:'AV9cprotID',fld:'vCPROTID',pic:'ZZZ9'},{av:'AV10cCotiIVA',fld:'vCCOTIIVA',pic:'ZZZ9.999'},{av:'AV11cCotiUltNro',fld:'vCCOTIULTNRO',pic:'ZZZZZZZ9'},{av:'AV12cCotiUltNroObr',fld:'vCCOTIULTNROOBR',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEmpID',fld:'vCEMPID',pic:'ZZZ9'},{av:'AV7cCotiID',fld:'vCCOTIID',pic:'ZZZ9'},{av:'AV8cCotiDsc',fld:'vCCOTIDSC',pic:''},{av:'AV9cprotID',fld:'vCPROTID',pic:'ZZZ9'},{av:'AV10cCotiIVA',fld:'vCCOTIIVA',pic:'ZZZ9.999'},{av:'AV11cCotiUltNro',fld:'vCCOTIULTNRO',pic:'ZZZZZZZ9'},{av:'AV12cCotiUltNroObr',fld:'vCCOTIULTNROOBR',pic:'ZZZZZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEmpID',fld:'vCEMPID',pic:'ZZZ9'},{av:'AV7cCotiID',fld:'vCCOTIID',pic:'ZZZ9'},{av:'AV8cCotiDsc',fld:'vCCOTIDSC',pic:''},{av:'AV9cprotID',fld:'vCPROTID',pic:'ZZZ9'},{av:'AV10cCotiIVA',fld:'vCCOTIIVA',pic:'ZZZ9.999'},{av:'AV11cCotiUltNro',fld:'vCCOTIULTNRO',pic:'ZZZZZZZ9'},{av:'AV12cCotiUltNroObr',fld:'vCCOTIULTNROOBR',pic:'ZZZZZZZ9'}]");
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
         AV8cCotiDsc = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblempidfilter_Jsonclick = "";
         TempTags = "";
         lblLblcotiidfilter_Jsonclick = "";
         lblLblcotidscfilter_Jsonclick = "";
         lblLblprotidfilter_Jsonclick = "";
         lblLblcotiivafilter_Jsonclick = "";
         lblLblcotiultnrofilter_Jsonclick = "";
         lblLblcotiultnroobrfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A154CotiDsc = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18Linkselection_GXI = "";
         scmdbuf = "";
         lV8cCotiDsc = "";
         H00322_A201CotiUltNroObr = new int[1] ;
         H00322_n201CotiUltNroObr = new bool[] {false} ;
         H00322_A156CotiUltNro = new int[1] ;
         H00322_n156CotiUltNro = new bool[] {false} ;
         H00322_A155CotiIVA = new decimal[1] ;
         H00322_n155CotiIVA = new bool[] {false} ;
         H00322_A10protID = new short[1] ;
         H00322_A154CotiDsc = new String[] {""} ;
         H00322_n154CotiDsc = new bool[] {false} ;
         H00322_A34CotiID = new short[1] ;
         H00322_A1EmpID = new short[1] ;
         H00323_AGRID1_nRecordCount = new long[1] ;
         AV15ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00s0__default(),
            new Object[][] {
                new Object[] {
               H00322_A201CotiUltNroObr, H00322_n201CotiUltNroObr, H00322_A156CotiUltNro, H00322_n156CotiUltNro, H00322_A155CotiIVA, H00322_n155CotiIVA, H00322_A10protID, H00322_A154CotiDsc, H00322_n154CotiDsc, H00322_A34CotiID,
               H00322_A1EmpID
               }
               , new Object[] {
               H00323_AGRID1_nRecordCount
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
      private short AV7cCotiID ;
      private short AV9cprotID ;
      private short AV13pEmpID ;
      private short AV14pCotiID ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A1EmpID ;
      private short A34CotiID ;
      private short A10protID ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int AV11cCotiUltNro ;
      private int AV12cCotiUltNroObr ;
      private int edtavCempid_Enabled ;
      private int edtavCempid_Visible ;
      private int edtavCcotiid_Enabled ;
      private int edtavCcotiid_Visible ;
      private int edtavCcotidsc_Visible ;
      private int edtavCcotidsc_Enabled ;
      private int edtavCprotid_Enabled ;
      private int edtavCprotid_Visible ;
      private int edtavCcotiiva_Enabled ;
      private int edtavCcotiiva_Visible ;
      private int edtavCcotiultnro_Enabled ;
      private int edtavCcotiultnro_Visible ;
      private int edtavCcotiultnroobr_Enabled ;
      private int edtavCcotiultnroobr_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int A156CotiUltNro ;
      private int A201CotiUltNroObr ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private decimal AV10cCotiIVA ;
      private decimal A155CotiIVA ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divEmpidfiltercontainer_Class ;
      private String divCotiidfiltercontainer_Class ;
      private String divCotidscfiltercontainer_Class ;
      private String divProtidfiltercontainer_Class ;
      private String divCotiivafiltercontainer_Class ;
      private String divCotiultnrofiltercontainer_Class ;
      private String divCotiultnroobrfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_84_idx="0001" ;
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
      private String divCotiidfiltercontainer_Internalname ;
      private String lblLblcotiidfilter_Internalname ;
      private String lblLblcotiidfilter_Jsonclick ;
      private String edtavCcotiid_Internalname ;
      private String edtavCcotiid_Jsonclick ;
      private String divCotidscfiltercontainer_Internalname ;
      private String lblLblcotidscfilter_Internalname ;
      private String lblLblcotidscfilter_Jsonclick ;
      private String edtavCcotidsc_Internalname ;
      private String edtavCcotidsc_Jsonclick ;
      private String divProtidfiltercontainer_Internalname ;
      private String lblLblprotidfilter_Internalname ;
      private String lblLblprotidfilter_Jsonclick ;
      private String edtavCprotid_Internalname ;
      private String edtavCprotid_Jsonclick ;
      private String divCotiivafiltercontainer_Internalname ;
      private String lblLblcotiivafilter_Internalname ;
      private String lblLblcotiivafilter_Jsonclick ;
      private String edtavCcotiiva_Internalname ;
      private String edtavCcotiiva_Jsonclick ;
      private String divCotiultnrofiltercontainer_Internalname ;
      private String lblLblcotiultnrofilter_Internalname ;
      private String lblLblcotiultnrofilter_Jsonclick ;
      private String edtavCcotiultnro_Internalname ;
      private String edtavCcotiultnro_Jsonclick ;
      private String divCotiultnroobrfiltercontainer_Internalname ;
      private String lblLblcotiultnroobrfilter_Internalname ;
      private String lblLblcotiultnroobrfilter_Jsonclick ;
      private String edtavCcotiultnroobr_Internalname ;
      private String edtavCcotiultnroobr_Jsonclick ;
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
      private String edtCotiDsc_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtEmpID_Internalname ;
      private String edtCotiID_Internalname ;
      private String edtCotiDsc_Internalname ;
      private String edtprotID_Internalname ;
      private String scmdbuf ;
      private String AV15ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtEmpID_Jsonclick ;
      private String edtCotiID_Jsonclick ;
      private String edtCotiDsc_Jsonclick ;
      private String edtprotID_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_84_Refreshing=false ;
      private bool n154CotiDsc ;
      private bool gxdyncontrolsrefreshing ;
      private bool n201CotiUltNroObr ;
      private bool n156CotiUltNro ;
      private bool n155CotiIVA ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV8cCotiDsc ;
      private String A154CotiDsc ;
      private String AV18Linkselection_GXI ;
      private String lV8cCotiDsc ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H00322_A201CotiUltNroObr ;
      private bool[] H00322_n201CotiUltNroObr ;
      private int[] H00322_A156CotiUltNro ;
      private bool[] H00322_n156CotiUltNro ;
      private decimal[] H00322_A155CotiIVA ;
      private bool[] H00322_n155CotiIVA ;
      private short[] H00322_A10protID ;
      private String[] H00322_A154CotiDsc ;
      private bool[] H00322_n154CotiDsc ;
      private short[] H00322_A34CotiID ;
      private short[] H00322_A1EmpID ;
      private long[] H00323_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pEmpID ;
      private short aP1_pCotiID ;
      private GXWebForm Form ;
   }

   public class gx00s0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00322( IGxContext context ,
                                             String AV8cCotiDsc ,
                                             short AV9cprotID ,
                                             decimal AV10cCotiIVA ,
                                             int AV11cCotiUltNro ,
                                             int AV12cCotiUltNroObr ,
                                             String A154CotiDsc ,
                                             short A10protID ,
                                             decimal A155CotiIVA ,
                                             int A156CotiUltNro ,
                                             int A201CotiUltNroObr ,
                                             short AV6cEmpID ,
                                             short AV7cCotiID )
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
         sSelectString = " [CotiUltNroObr], [CotiUltNro], [CotiIVA], [protID], [CotiDsc], [CotiID], [EmpID]";
         sFromString = " FROM [Cotizador] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([EmpID] >= @AV6cEmpID and [CotiID] >= @AV7cCotiID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cCotiDsc)) )
         {
            sWhereString = sWhereString + " and ([CotiDsc] like @lV8cCotiDsc)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV9cprotID) )
         {
            sWhereString = sWhereString + " and ([protID] >= @AV9cprotID)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV10cCotiIVA) )
         {
            sWhereString = sWhereString + " and ([CotiIVA] >= @AV10cCotiIVA)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV11cCotiUltNro) )
         {
            sWhereString = sWhereString + " and ([CotiUltNro] >= @AV11cCotiUltNro)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV12cCotiUltNroObr) )
         {
            sWhereString = sWhereString + " and ([CotiUltNroObr] >= @AV12cCotiUltNroObr)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [EmpID], [CotiID]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00323( IGxContext context ,
                                             String AV8cCotiDsc ,
                                             short AV9cprotID ,
                                             decimal AV10cCotiIVA ,
                                             int AV11cCotiUltNro ,
                                             int AV12cCotiUltNroObr ,
                                             String A154CotiDsc ,
                                             short A10protID ,
                                             decimal A155CotiIVA ,
                                             int A156CotiUltNro ,
                                             int A201CotiUltNroObr ,
                                             short AV6cEmpID ,
                                             short AV7cCotiID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Cotizador] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([EmpID] >= @AV6cEmpID and [CotiID] >= @AV7cCotiID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cCotiDsc)) )
         {
            sWhereString = sWhereString + " and ([CotiDsc] like @lV8cCotiDsc)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV9cprotID) )
         {
            sWhereString = sWhereString + " and ([protID] >= @AV9cprotID)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV10cCotiIVA) )
         {
            sWhereString = sWhereString + " and ([CotiIVA] >= @AV10cCotiIVA)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV11cCotiUltNro) )
         {
            sWhereString = sWhereString + " and ([CotiUltNro] >= @AV11cCotiUltNro)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV12cCotiUltNroObr) )
         {
            sWhereString = sWhereString + " and ([CotiUltNroObr] >= @AV12cCotiUltNroObr)";
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
                     return conditional_H00322(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (decimal)dynConstraints[2] , (int)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (decimal)dynConstraints[7] , (int)dynConstraints[8] , (int)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] );
               case 1 :
                     return conditional_H00323(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (decimal)dynConstraints[2] , (int)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (decimal)dynConstraints[7] , (int)dynConstraints[8] , (int)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] );
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
          Object[] prmH00322 ;
          prmH00322 = new Object[] {
          new Object[] {"@AV6cEmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cCotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV8cCotiDsc",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV9cprotID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cCotiIVA",SqlDbType.Decimal,8,3} ,
          new Object[] {"@AV11cCotiUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@AV12cCotiUltNroObr",SqlDbType.Int,8,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00323 ;
          prmH00323 = new Object[] {
          new Object[] {"@AV6cEmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cCotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV8cCotiDsc",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV9cprotID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cCotiIVA",SqlDbType.Decimal,8,3} ,
          new Object[] {"@AV11cCotiUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@AV12cCotiUltNroObr",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00322", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00322,11,0,false,false )
             ,new CursorDef("H00323", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00323,1,0,false,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((short[]) buf[10])[0] = rslt.getShort(7) ;
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
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
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
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                return;
       }
    }

 }

}
