/*
               File: Bodegas
        Description: Bodegas
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/18/2022 1:21:5.23
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
using System.Runtime.Remoting;
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
   public class bodegas : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_8( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A43TipoInv = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_10( A43TipoInv) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridbodegas_bodtipo") == 0 )
         {
            nRC_GXsfl_69 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_69_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_69_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridbodegas_bodtipo_newrow( ) ;
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
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
               AV8BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BodCod), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBODCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BodCod), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Bodegas", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtEmpID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public bodegas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public bodegas( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_EmpID ,
                           short aP2_BodCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8BodCod = aP2_BodCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkBodEst = new GXCheckbox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            ValidateSpaRequest();
            UserMain( ) ;
            if ( ! isFullAjaxMode( ) && ( nDynComponent == 0 ) )
            {
               Draw( ) ;
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

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Bodegas", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00y0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"BODCOD"+"'), id:'"+"BODCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "Center", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Codigo", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Bodegas.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "Center", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtempdsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBodCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodCod_Internalname, "Codigo Bodega", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBodCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodCod_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBodDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodDsc_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBodDsc_Internalname, StringUtil.RTrim( A217BodDsc), StringUtil.RTrim( context.localUtil.Format( A217BodDsc, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkBodEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkBodEst_Internalname, "Estado", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkBodEst_Internalname, A218BodEst, "", "Estado", 1, chkBodEst.Enabled, "A", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(55, this, 'A', 'I');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBodDireccion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodDireccion_Internalname, "Direccion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBodDireccion_Internalname, A225BodDireccion, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A225BodDireccion), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", 0, 1, edtBodDireccion_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 3, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divBodtipotable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlebodtipo_Internalname, "Tipo Movimientos", "", "", lblTitlebodtipo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridbodegas_bodtipo( ) ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Bodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0F34( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridbodegas_bodtipo( )
      {
         /*  Grid Control  */
         Gridbodegas_bodtipoContainer.AddObjectProperty("GridName", "Gridbodegas_bodtipo");
         Gridbodegas_bodtipoContainer.AddObjectProperty("Header", subGridbodegas_bodtipo_Header);
         Gridbodegas_bodtipoContainer.AddObjectProperty("Class", "Grid");
         Gridbodegas_bodtipoContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbodegas_bodtipo_Backcolorstyle), 1, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddObjectProperty("CmpContext", "");
         Gridbodegas_bodtipoContainer.AddObjectProperty("InMasterPage", "false");
         Gridbodegas_bodtipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridbodegas_bodtipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A285BodDetID), 4, 0, ".", "")));
         Gridbodegas_bodtipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBodDetID_Enabled), 5, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddColumnProperties(Gridbodegas_bodtipoColumn);
         Gridbodegas_bodtipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridbodegas_bodtipoColumn.AddObjectProperty("Value", StringUtil.RTrim( A43TipoInv));
         Gridbodegas_bodtipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInv_Enabled), 5, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddColumnProperties(Gridbodegas_bodtipoColumn);
         Gridbodegas_bodtipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridbodegas_bodtipoContainer.AddColumnProperties(Gridbodegas_bodtipoColumn);
         Gridbodegas_bodtipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridbodegas_bodtipoColumn.AddObjectProperty("Value", A219TipoInvMov);
         Gridbodegas_bodtipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvMov_Enabled), 5, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddColumnProperties(Gridbodegas_bodtipoColumn);
         Gridbodegas_bodtipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridbodegas_bodtipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BodTipoNro), 8, 0, ".", "")));
         Gridbodegas_bodtipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBodTipoNro_Enabled), 5, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddColumnProperties(Gridbodegas_bodtipoColumn);
         Gridbodegas_bodtipoContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbodegas_bodtipo_Selectedindex), 4, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbodegas_bodtipo_Allowselection), 1, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbodegas_bodtipo_Selectioncolor), 9, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbodegas_bodtipo_Allowhovering), 1, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbodegas_bodtipo_Hoveringcolor), 9, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbodegas_bodtipo_Allowcollapsing), 1, 0, ".", "")));
         Gridbodegas_bodtipoContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridbodegas_bodtipo_Collapsed), 1, 0, ".", "")));
         nGXsfl_69_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount53 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_53 = 1;
               ScanStart0F53( ) ;
               while ( RcdFound53 != 0 )
               {
                  init_level_properties53( ) ;
                  getByPrimaryKey0F53( ) ;
                  AddRow0F53( ) ;
                  ScanNext0F53( ) ;
               }
               ScanEnd0F53( ) ;
               nBlankRcdCount53 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0F53( ) ;
            standaloneModal0F53( ) ;
            sMode53 = Gx_mode;
            while ( nGXsfl_69_idx < nRC_GXsfl_69 )
            {
               bGXsfl_69_Refreshing = true;
               ReadRow0F53( ) ;
               edtBodDetID_Enabled = (int)(context.localUtil.CToN( cgiGet( "BODDETID_"+sGXsfl_69_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDetID_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
               edtTipoInv_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOINV_"+sGXsfl_69_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
               edtTipoInvMov_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOINVMOV_"+sGXsfl_69_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvMov_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInvMov_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
               edtBodTipoNro_Enabled = (int)(context.localUtil.CToN( cgiGet( "BODTIPONRO_"+sGXsfl_69_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodTipoNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodTipoNro_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_43_"+sGXsfl_69_idx+"Link");
               if ( ( nRcdExists_53 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0F53( ) ;
               }
               SendRow0F53( ) ;
               bGXsfl_69_Refreshing = false;
            }
            Gx_mode = sMode53;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount53 = 5;
            nRcdExists_53 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0F53( ) ;
               while ( RcdFound53 != 0 )
               {
                  sGXsfl_69_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_69_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_6953( ) ;
                  init_level_properties53( ) ;
                  standaloneNotModal0F53( ) ;
                  getByPrimaryKey0F53( ) ;
                  standaloneModal0F53( ) ;
                  AddRow0F53( ) ;
                  ScanNext0F53( ) ;
               }
               ScanEnd0F53( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode53 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_69_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_69_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_6953( ) ;
            InitAll0F53( ) ;
            init_level_properties53( ) ;
            standaloneNotModal0F53( ) ;
            standaloneModal0F53( ) ;
            nRcdExists_53 = 0;
            nIsMod_53 = 0;
            nRcdDeleted_53 = 0;
            nBlankRcdCount53 = (short)(nBlankRcdUsr53+nBlankRcdCount53);
            fRowAdded = 0;
            while ( nBlankRcdCount53 > 0 )
            {
               AddRow0F53( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtBodDetID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount53 = (short)(nBlankRcdCount53-1);
            }
            Gx_mode = sMode53;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridbodegas_bodtipoContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridbodegas_bodtipo", Gridbodegas_bodtipoContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridbodegas_bodtipoContainerData", Gridbodegas_bodtipoContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridbodegas_bodtipoContainerData"+"V", Gridbodegas_bodtipoContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridbodegas_bodtipoContainerData"+"V"+"\" value='"+Gridbodegas_bodtipoContainer.GridValuesHidden()+"'/>") ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110F2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A1EmpID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               }
               else
               {
                  A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               }
               A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
               n44empdsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BODCOD");
                  AnyError = 1;
                  GX_FocusControl = edtBodCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A42BodCod = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               }
               else
               {
                  A42BodCod = (short)(context.localUtil.CToN( cgiGet( edtBodCod_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               }
               A217BodDsc = StringUtil.Upper( cgiGet( edtBodDsc_Internalname));
               n217BodDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
               n217BodDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A217BodDsc)) ? true : false);
               A218BodEst = ((StringUtil.StrCmp(cgiGet( chkBodEst_Internalname), "A")==0) ? "A" : "I");
               n218BodEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
               n218BodEst = (String.IsNullOrEmpty(StringUtil.RTrim( A218BodEst)) ? true : false);
               A225BodDireccion = cgiGet( edtBodDireccion_Internalname);
               n225BodDireccion = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BodDireccion", A225BodDireccion);
               n225BodDireccion = (String.IsNullOrEmpty(StringUtil.RTrim( A225BodDireccion)) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z42BodCod = (short)(context.localUtil.CToN( cgiGet( "Z42BodCod"), ",", "."));
               Z217BodDsc = cgiGet( "Z217BodDsc");
               n217BodDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A217BodDsc)) ? true : false);
               Z218BodEst = cgiGet( "Z218BodEst");
               n218BodEst = (String.IsNullOrEmpty(StringUtil.RTrim( A218BodEst)) ? true : false);
               Z225BodDireccion = cgiGet( "Z225BodDireccion");
               n225BodDireccion = (String.IsNullOrEmpty(StringUtil.RTrim( A225BodDireccion)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_69 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_69"), ",", "."));
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8BodCod = (short)(context.localUtil.CToN( cgiGet( "vBODCOD"), ",", "."));
               AV12Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Bodegas";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A42BodCod != Z42BodCod ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("bodegas:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               /* Check if conditions changed and reset current page numbers */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A42BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode34 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode34;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound34 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0F0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "EMPID");
                        AnyError = 1;
                        GX_FocusControl = edtEmpID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                     if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: Start */
                        E110F2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120F2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                     {
                        context.wbHandled = 1;
                        if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                        {
                           btn_enter( ) ;
                        }
                        /* No code required for Cancel button. It is implemented as the Reset button. */
                     }
                  }
                  else
                  {
                     sEvtType = StringUtil.Right( sEvt, 4);
                     sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                  }
               }
               context.wbHandled = 1;
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E120F2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0F34( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)), true);
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)), true);
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)), true);
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)), true);
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes0F34( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_0F0( )
      {
         BeforeValidate0F34( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0F34( ) ;
            }
            else
            {
               CheckExtendedTable0F34( ) ;
               CloseExtendedTableCursors0F34( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode34 = Gx_mode;
            CONFIRM_0F53( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode34;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode34;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0F53( )
      {
         nGXsfl_69_idx = 0;
         while ( nGXsfl_69_idx < nRC_GXsfl_69 )
         {
            ReadRow0F53( ) ;
            if ( ( nRcdExists_53 != 0 ) || ( nIsMod_53 != 0 ) )
            {
               GetKey0F53( ) ;
               if ( ( nRcdExists_53 == 0 ) && ( nRcdDeleted_53 == 0 ) )
               {
                  if ( RcdFound53 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0F53( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0F53( ) ;
                        CloseExtendedTableCursors0F53( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "BODDETID_" + sGXsfl_69_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtBodDetID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound53 != 0 )
                  {
                     if ( nRcdDeleted_53 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0F53( ) ;
                        Load0F53( ) ;
                        BeforeValidate0F53( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0F53( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_53 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0F53( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0F53( ) ;
                              CloseExtendedTableCursors0F53( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_53 == 0 )
                     {
                        GXCCtl = "BODDETID_" + sGXsfl_69_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtBodDetID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtBodDetID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A285BodDetID), 4, 0, ",", ""))) ;
            ChangePostValue( edtTipoInv_Internalname, StringUtil.RTrim( A43TipoInv)) ;
            ChangePostValue( edtTipoInvMov_Internalname, A219TipoInvMov) ;
            ChangePostValue( edtBodTipoNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BodTipoNro), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z285BodDetID_"+sGXsfl_69_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z285BodDetID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z43TipoInv_"+sGXsfl_69_idx, StringUtil.RTrim( Z43TipoInv)) ;
            ChangePostValue( "ZT_"+"Z226BodTipoNro_"+sGXsfl_69_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z226BodTipoNro), 8, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_53_"+sGXsfl_69_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_53), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_53_"+sGXsfl_69_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_53), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_53_"+sGXsfl_69_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_53), 4, 0, ",", ""))) ;
            if ( nIsMod_53 != 0 )
            {
               ChangePostValue( "BODDETID_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBodDetID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOINV_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInv_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOINVMOV_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvMov_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "BODTIPONRO_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBodTipoNro_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0F0( )
      {
      }

      protected void E110F2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV12Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E120F2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwbodegas.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0F34( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z217BodDsc = T000F6_A217BodDsc[0];
               Z218BodEst = T000F6_A218BodEst[0];
               Z225BodDireccion = T000F6_A225BodDireccion[0];
            }
            else
            {
               Z217BodDsc = A217BodDsc;
               Z218BodEst = A218BodEst;
               Z225BodDireccion = A225BodDireccion;
            }
         }
         if ( GX_JID == -7 )
         {
            Z42BodCod = A42BodCod;
            Z217BodDsc = A217BodDsc;
            Z218BodEst = A218BodEst;
            Z225BodDireccion = A225BodDireccion;
            Z1EmpID = A1EmpID;
            Z44empdsc = A44empdsc;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7EmpID) )
         {
            A1EmpID = AV7EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( ! (0==AV7EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         else
         {
            edtEmpID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8BodCod) )
         {
            A42BodCod = AV8BodCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         }
         if ( ! (0==AV8BodCod) )
         {
            edtBodCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtBodCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8BodCod) )
         {
            edtBodCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T000F7 */
            pr_default.execute(5, new Object[] {A1EmpID});
            A44empdsc = T000F7_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000F7_n44empdsc[0];
            pr_default.close(5);
            AV12Pgmname = "Bodegas";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         }
      }

      protected void Load0F34( )
      {
         /* Using cursor T000F8 */
         pr_default.execute(6, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound34 = 1;
            A44empdsc = T000F8_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000F8_n44empdsc[0];
            A217BodDsc = T000F8_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000F8_n217BodDsc[0];
            A218BodEst = T000F8_A218BodEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
            n218BodEst = T000F8_n218BodEst[0];
            A225BodDireccion = T000F8_A225BodDireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BodDireccion", A225BodDireccion);
            n225BodDireccion = T000F8_n225BodDireccion[0];
            ZM0F34( -7) ;
         }
         pr_default.close(6);
         OnLoadActions0F34( ) ;
      }

      protected void OnLoadActions0F34( )
      {
         AV12Pgmname = "Bodegas";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
      }

      protected void CheckExtendedTable0F34( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV12Pgmname = "Bodegas";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         /* Using cursor T000F7 */
         pr_default.execute(5, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000F7_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000F7_n44empdsc[0];
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors0F34( )
      {
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_8( short A1EmpID )
      {
         /* Using cursor T000F9 */
         pr_default.execute(7, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000F9_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000F9_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(7);
      }

      protected void GetKey0F34( )
      {
         /* Using cursor T000F10 */
         pr_default.execute(8, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound34 = 1;
         }
         else
         {
            RcdFound34 = 0;
         }
         pr_default.close(8);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000F6 */
         pr_default.execute(4, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM0F34( 7) ;
            RcdFound34 = 1;
            A42BodCod = T000F6_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A217BodDsc = T000F6_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000F6_n217BodDsc[0];
            A218BodEst = T000F6_A218BodEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
            n218BodEst = T000F6_n218BodEst[0];
            A225BodDireccion = T000F6_A225BodDireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BodDireccion", A225BodDireccion);
            n225BodDireccion = T000F6_n225BodDireccion[0];
            A1EmpID = T000F6_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z42BodCod = A42BodCod;
            sMode34 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0F34( ) ;
            if ( AnyError == 1 )
            {
               RcdFound34 = 0;
               InitializeNonKey0F34( ) ;
            }
            Gx_mode = sMode34;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound34 = 0;
            InitializeNonKey0F34( ) ;
            sMode34 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode34;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey0F34( ) ;
         if ( RcdFound34 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound34 = 0;
         /* Using cursor T000F11 */
         pr_default.execute(9, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000F11_A1EmpID[0] < A1EmpID ) || ( T000F11_A1EmpID[0] == A1EmpID ) && ( T000F11_A42BodCod[0] < A42BodCod ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000F11_A1EmpID[0] > A1EmpID ) || ( T000F11_A1EmpID[0] == A1EmpID ) && ( T000F11_A42BodCod[0] > A42BodCod ) ) )
            {
               A1EmpID = T000F11_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A42BodCod = T000F11_A42BodCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               RcdFound34 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void move_previous( )
      {
         RcdFound34 = 0;
         /* Using cursor T000F12 */
         pr_default.execute(10, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000F12_A1EmpID[0] > A1EmpID ) || ( T000F12_A1EmpID[0] == A1EmpID ) && ( T000F12_A42BodCod[0] > A42BodCod ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000F12_A1EmpID[0] < A1EmpID ) || ( T000F12_A1EmpID[0] == A1EmpID ) && ( T000F12_A42BodCod[0] < A42BodCod ) ) )
            {
               A1EmpID = T000F12_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A42BodCod = T000F12_A42BodCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               RcdFound34 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0F34( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0F34( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound34 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A42BodCod != Z42BodCod ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A42BodCod = Z42BodCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0F34( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A42BodCod != Z42BodCod ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0F34( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EMPID");
                     AnyError = 1;
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0F34( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( ( A1EmpID != Z1EmpID ) || ( A42BodCod != Z42BodCod ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A42BodCod = Z42BodCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0F34( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000F5 */
            pr_default.execute(3, new Object[] {A1EmpID, A42BodCod});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Bodegas"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( StringUtil.StrCmp(Z217BodDsc, T000F5_A217BodDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z218BodEst, T000F5_A218BodEst[0]) != 0 ) || ( StringUtil.StrCmp(Z225BodDireccion, T000F5_A225BodDireccion[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z217BodDsc, T000F5_A217BodDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("bodegas:[seudo value changed for attri]"+"BodDsc");
                  GXUtil.WriteLogRaw("Old: ",Z217BodDsc);
                  GXUtil.WriteLogRaw("Current: ",T000F5_A217BodDsc[0]);
               }
               if ( StringUtil.StrCmp(Z218BodEst, T000F5_A218BodEst[0]) != 0 )
               {
                  GXUtil.WriteLog("bodegas:[seudo value changed for attri]"+"BodEst");
                  GXUtil.WriteLogRaw("Old: ",Z218BodEst);
                  GXUtil.WriteLogRaw("Current: ",T000F5_A218BodEst[0]);
               }
               if ( StringUtil.StrCmp(Z225BodDireccion, T000F5_A225BodDireccion[0]) != 0 )
               {
                  GXUtil.WriteLog("bodegas:[seudo value changed for attri]"+"BodDireccion");
                  GXUtil.WriteLogRaw("Old: ",Z225BodDireccion);
                  GXUtil.WriteLogRaw("Current: ",T000F5_A225BodDireccion[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Bodegas"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0F34( )
      {
         BeforeValidate0F34( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F34( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0F34( 0) ;
            CheckOptimisticConcurrency0F34( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F34( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0F34( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F13 */
                     pr_default.execute(11, new Object[] {A42BodCod, n217BodDsc, A217BodDsc, n218BodEst, A218BodEst, n225BodDireccion, A225BodDireccion, A1EmpID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Bodegas") ;
                     if ( (pr_default.getStatus(11) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0F34( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0F0( ) ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0F34( ) ;
            }
            EndLevel0F34( ) ;
         }
         CloseExtendedTableCursors0F34( ) ;
      }

      protected void Update0F34( )
      {
         BeforeValidate0F34( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F34( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F34( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F34( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0F34( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F14 */
                     pr_default.execute(12, new Object[] {n217BodDsc, A217BodDsc, n218BodEst, A218BodEst, n225BodDireccion, A225BodDireccion, A1EmpID, A42BodCod});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("Bodegas") ;
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Bodegas"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0F34( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0F34( ) ;
                           if ( AnyError == 0 )
                           {
                              if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                              {
                                 if ( AnyError == 0 )
                                 {
                                    context.nUserReturn = 1;
                                 }
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0F34( ) ;
         }
         CloseExtendedTableCursors0F34( ) ;
      }

      protected void DeferredUpdate0F34( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0F34( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F34( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0F34( ) ;
            AfterConfirm0F34( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0F34( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0F53( ) ;
                  while ( RcdFound53 != 0 )
                  {
                     getByPrimaryKey0F53( ) ;
                     Delete0F53( ) ;
                     ScanNext0F53( ) ;
                  }
                  ScanEnd0F53( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F15 */
                     pr_default.execute(13, new Object[] {A1EmpID, A42BodCod});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("Bodegas") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
         }
         sMode34 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0F34( ) ;
         Gx_mode = sMode34;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0F34( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV12Pgmname = "Bodegas";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
            /* Using cursor T000F16 */
            pr_default.execute(14, new Object[] {A1EmpID});
            A44empdsc = T000F16_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000F16_n44empdsc[0];
            pr_default.close(14);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000F17 */
            pr_default.execute(15, new Object[] {A1EmpID, A42BodCod});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Prodx Bodega"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
            /* Using cursor T000F18 */
            pr_default.execute(16, new Object[] {A1EmpID, A42BodCod});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Orden Compra"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(16);
            /* Using cursor T000F19 */
            pr_default.execute(17, new Object[] {A1EmpID, A42BodCod});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Movimientos Inventario"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(17);
         }
      }

      protected void ProcessNestedLevel0F53( )
      {
         nGXsfl_69_idx = 0;
         while ( nGXsfl_69_idx < nRC_GXsfl_69 )
         {
            ReadRow0F53( ) ;
            if ( ( nRcdExists_53 != 0 ) || ( nIsMod_53 != 0 ) )
            {
               standaloneNotModal0F53( ) ;
               GetKey0F53( ) ;
               if ( ( nRcdExists_53 == 0 ) && ( nRcdDeleted_53 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0F53( ) ;
               }
               else
               {
                  if ( RcdFound53 != 0 )
                  {
                     if ( ( nRcdDeleted_53 != 0 ) && ( nRcdExists_53 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0F53( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_53 != 0 ) && ( nRcdExists_53 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0F53( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_53 == 0 )
                     {
                        GXCCtl = "BODDETID_" + sGXsfl_69_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtBodDetID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtBodDetID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A285BodDetID), 4, 0, ",", ""))) ;
            ChangePostValue( edtTipoInv_Internalname, StringUtil.RTrim( A43TipoInv)) ;
            ChangePostValue( edtTipoInvMov_Internalname, A219TipoInvMov) ;
            ChangePostValue( edtBodTipoNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BodTipoNro), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z285BodDetID_"+sGXsfl_69_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z285BodDetID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z43TipoInv_"+sGXsfl_69_idx, StringUtil.RTrim( Z43TipoInv)) ;
            ChangePostValue( "ZT_"+"Z226BodTipoNro_"+sGXsfl_69_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z226BodTipoNro), 8, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_53_"+sGXsfl_69_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_53), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_53_"+sGXsfl_69_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_53), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_53_"+sGXsfl_69_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_53), 4, 0, ",", ""))) ;
            if ( nIsMod_53 != 0 )
            {
               ChangePostValue( "BODDETID_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBodDetID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOINV_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInv_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOINVMOV_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvMov_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "BODTIPONRO_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBodTipoNro_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0F53( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_53 = 0;
         nIsMod_53 = 0;
         nRcdDeleted_53 = 0;
      }

      protected void ProcessLevel0F34( )
      {
         /* Save parent mode. */
         sMode34 = Gx_mode;
         ProcessNestedLevel0F53( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode34;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel0F34( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0F34( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(14);
            pr_default.close(2);
            context.CommitDataStores("bodegas",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0F0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(14);
            pr_default.close(2);
            context.RollbackDataStores("bodegas",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0F34( )
      {
         /* Scan By routine */
         /* Using cursor T000F20 */
         pr_default.execute(18);
         RcdFound34 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound34 = 1;
            A1EmpID = T000F20_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A42BodCod = T000F20_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0F34( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound34 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound34 = 1;
            A1EmpID = T000F20_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A42BodCod = T000F20_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         }
      }

      protected void ScanEnd0F34( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm0F34( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0F34( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0F34( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0F34( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0F34( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0F34( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0F34( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtBodCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         edtBodDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDsc_Enabled), 5, 0)), true);
         chkBodEst.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBodEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkBodEst.Enabled), 5, 0)), true);
         edtBodDireccion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDireccion_Enabled), 5, 0)), true);
      }

      protected void ZM0F53( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z226BodTipoNro = T000F3_A226BodTipoNro[0];
            }
            else
            {
               Z226BodTipoNro = A226BodTipoNro;
            }
         }
         if ( GX_JID == -9 )
         {
            Z1EmpID = A1EmpID;
            Z42BodCod = A42BodCod;
            Z285BodDetID = A285BodDetID;
            Z226BodTipoNro = A226BodTipoNro;
            Z43TipoInv = A43TipoInv;
            Z219TipoInvMov = A219TipoInvMov;
         }
      }

      protected void standaloneNotModal0F53( )
      {
      }

      protected void standaloneModal0F53( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtBodDetID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDetID_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
         }
         else
         {
            edtBodDetID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDetID_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTipoInv_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
         }
         else
         {
            edtTipoInv_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
         }
      }

      protected void Load0F53( )
      {
         /* Using cursor T000F21 */
         pr_default.execute(19, new Object[] {A1EmpID, A42BodCod, A285BodDetID, A43TipoInv});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound53 = 1;
            A219TipoInvMov = T000F21_A219TipoInvMov[0];
            n219TipoInvMov = T000F21_n219TipoInvMov[0];
            A226BodTipoNro = T000F21_A226BodTipoNro[0];
            n226BodTipoNro = T000F21_n226BodTipoNro[0];
            ZM0F53( -9) ;
         }
         pr_default.close(19);
         OnLoadActions0F53( ) ;
      }

      protected void OnLoadActions0F53( )
      {
      }

      protected void CheckExtendedTable0F53( )
      {
         Gx_BScreen = 1;
         standaloneModal0F53( ) ;
         /* Using cursor T000F4 */
         pr_default.execute(2, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "TIPOINV_" + sGXsfl_69_idx;
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A219TipoInvMov = T000F4_A219TipoInvMov[0];
         n219TipoInvMov = T000F4_n219TipoInvMov[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0F53( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0F53( )
      {
      }

      protected void gxLoad_10( String A43TipoInv )
      {
         /* Using cursor T000F22 */
         pr_default.execute(20, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GXCCtl = "TIPOINV_" + sGXsfl_69_idx;
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A219TipoInvMov = T000F22_A219TipoInvMov[0];
         n219TipoInvMov = T000F22_n219TipoInvMov[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A219TipoInvMov)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(20) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(20);
      }

      protected void GetKey0F53( )
      {
         /* Using cursor T000F23 */
         pr_default.execute(21, new Object[] {A1EmpID, A42BodCod, A285BodDetID, A43TipoInv});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound53 = 1;
         }
         else
         {
            RcdFound53 = 0;
         }
         pr_default.close(21);
      }

      protected void getByPrimaryKey0F53( )
      {
         /* Using cursor T000F3 */
         pr_default.execute(1, new Object[] {A1EmpID, A42BodCod, A285BodDetID, A43TipoInv});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0F53( 9) ;
            RcdFound53 = 1;
            InitializeNonKey0F53( ) ;
            A285BodDetID = T000F3_A285BodDetID[0];
            A226BodTipoNro = T000F3_A226BodTipoNro[0];
            n226BodTipoNro = T000F3_n226BodTipoNro[0];
            A43TipoInv = T000F3_A43TipoInv[0];
            Z1EmpID = A1EmpID;
            Z42BodCod = A42BodCod;
            Z285BodDetID = A285BodDetID;
            Z43TipoInv = A43TipoInv;
            sMode53 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0F53( ) ;
            Gx_mode = sMode53;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound53 = 0;
            InitializeNonKey0F53( ) ;
            sMode53 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0F53( ) ;
            Gx_mode = sMode53;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0F53( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0F53( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000F2 */
            pr_default.execute(0, new Object[] {A1EmpID, A42BodCod, A285BodDetID, A43TipoInv});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BodegasBodTipo"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z226BodTipoNro != T000F2_A226BodTipoNro[0] ) )
            {
               if ( Z226BodTipoNro != T000F2_A226BodTipoNro[0] )
               {
                  GXUtil.WriteLog("bodegas:[seudo value changed for attri]"+"BodTipoNro");
                  GXUtil.WriteLogRaw("Old: ",Z226BodTipoNro);
                  GXUtil.WriteLogRaw("Current: ",T000F2_A226BodTipoNro[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BodegasBodTipo"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0F53( )
      {
         BeforeValidate0F53( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F53( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0F53( 0) ;
            CheckOptimisticConcurrency0F53( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F53( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0F53( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F24 */
                     pr_default.execute(22, new Object[] {A1EmpID, A42BodCod, A285BodDetID, n226BodTipoNro, A226BodTipoNro, A43TipoInv});
                     pr_default.close(22);
                     dsDefault.SmartCacheProvider.SetUpdated("BodegasBodTipo") ;
                     if ( (pr_default.getStatus(22) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0F53( ) ;
            }
            EndLevel0F53( ) ;
         }
         CloseExtendedTableCursors0F53( ) ;
      }

      protected void Update0F53( )
      {
         BeforeValidate0F53( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F53( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F53( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F53( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0F53( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F25 */
                     pr_default.execute(23, new Object[] {n226BodTipoNro, A226BodTipoNro, A1EmpID, A42BodCod, A285BodDetID, A43TipoInv});
                     pr_default.close(23);
                     dsDefault.SmartCacheProvider.SetUpdated("BodegasBodTipo") ;
                     if ( (pr_default.getStatus(23) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BodegasBodTipo"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0F53( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0F53( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0F53( ) ;
         }
         CloseExtendedTableCursors0F53( ) ;
      }

      protected void DeferredUpdate0F53( )
      {
      }

      protected void Delete0F53( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0F53( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F53( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0F53( ) ;
            AfterConfirm0F53( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0F53( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000F26 */
                  pr_default.execute(24, new Object[] {A1EmpID, A42BodCod, A285BodDetID, A43TipoInv});
                  pr_default.close(24);
                  dsDefault.SmartCacheProvider.SetUpdated("BodegasBodTipo") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode53 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0F53( ) ;
         Gx_mode = sMode53;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0F53( )
      {
         standaloneModal0F53( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000F27 */
            pr_default.execute(25, new Object[] {A43TipoInv});
            A219TipoInvMov = T000F27_A219TipoInvMov[0];
            n219TipoInvMov = T000F27_n219TipoInvMov[0];
            pr_default.close(25);
         }
      }

      protected void EndLevel0F53( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0F53( )
      {
         /* Scan By routine */
         /* Using cursor T000F28 */
         pr_default.execute(26, new Object[] {A1EmpID, A42BodCod});
         RcdFound53 = 0;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound53 = 1;
            A285BodDetID = T000F28_A285BodDetID[0];
            A43TipoInv = T000F28_A43TipoInv[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0F53( )
      {
         /* Scan next routine */
         pr_default.readNext(26);
         RcdFound53 = 0;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound53 = 1;
            A285BodDetID = T000F28_A285BodDetID[0];
            A43TipoInv = T000F28_A43TipoInv[0];
         }
      }

      protected void ScanEnd0F53( )
      {
         pr_default.close(26);
      }

      protected void AfterConfirm0F53( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0F53( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0F53( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0F53( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0F53( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0F53( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0F53( )
      {
         edtBodDetID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDetID_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
         edtTipoInv_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
         edtTipoInvMov_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvMov_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInvMov_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
         edtBodTipoNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodTipoNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodTipoNro_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
      }

      protected void send_integrity_lvl_hashes0F53( )
      {
      }

      protected void send_integrity_lvl_hashes0F34( )
      {
      }

      protected void SubsflControlProps_6953( )
      {
         edtBodDetID_Internalname = "BODDETID_"+sGXsfl_69_idx;
         edtTipoInv_Internalname = "TIPOINV_"+sGXsfl_69_idx;
         imgprompt_43_Internalname = "PROMPT_43_"+sGXsfl_69_idx;
         edtTipoInvMov_Internalname = "TIPOINVMOV_"+sGXsfl_69_idx;
         edtBodTipoNro_Internalname = "BODTIPONRO_"+sGXsfl_69_idx;
      }

      protected void SubsflControlProps_fel_6953( )
      {
         edtBodDetID_Internalname = "BODDETID_"+sGXsfl_69_fel_idx;
         edtTipoInv_Internalname = "TIPOINV_"+sGXsfl_69_fel_idx;
         imgprompt_43_Internalname = "PROMPT_43_"+sGXsfl_69_fel_idx;
         edtTipoInvMov_Internalname = "TIPOINVMOV_"+sGXsfl_69_fel_idx;
         edtBodTipoNro_Internalname = "BODTIPONRO_"+sGXsfl_69_fel_idx;
      }

      protected void AddRow0F53( )
      {
         nGXsfl_69_idx = (short)(nGXsfl_69_idx+1);
         sGXsfl_69_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_69_idx), 4, 0)), 4, "0");
         SubsflControlProps_6953( ) ;
         SendRow0F53( ) ;
      }

      protected void SendRow0F53( )
      {
         Gridbodegas_bodtipoRow = GXWebRow.GetNew(context);
         if ( subGridbodegas_bodtipo_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridbodegas_bodtipo_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridbodegas_bodtipo_Class, "") != 0 )
            {
               subGridbodegas_bodtipo_Linesclass = subGridbodegas_bodtipo_Class+"Odd";
            }
         }
         else if ( subGridbodegas_bodtipo_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridbodegas_bodtipo_Backstyle = 0;
            subGridbodegas_bodtipo_Backcolor = subGridbodegas_bodtipo_Allbackcolor;
            if ( StringUtil.StrCmp(subGridbodegas_bodtipo_Class, "") != 0 )
            {
               subGridbodegas_bodtipo_Linesclass = subGridbodegas_bodtipo_Class+"Uniform";
            }
         }
         else if ( subGridbodegas_bodtipo_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridbodegas_bodtipo_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridbodegas_bodtipo_Class, "") != 0 )
            {
               subGridbodegas_bodtipo_Linesclass = subGridbodegas_bodtipo_Class+"Odd";
            }
            subGridbodegas_bodtipo_Backcolor = (int)(0x0);
         }
         else if ( subGridbodegas_bodtipo_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridbodegas_bodtipo_Backstyle = 1;
            if ( ((int)(((nGXsfl_69_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridbodegas_bodtipo_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridbodegas_bodtipo_Class, "") != 0 )
               {
                  subGridbodegas_bodtipo_Linesclass = subGridbodegas_bodtipo_Class+"Odd";
               }
            }
            else
            {
               subGridbodegas_bodtipo_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridbodegas_bodtipo_Class, "") != 0 )
               {
                  subGridbodegas_bodtipo_Linesclass = subGridbodegas_bodtipo_Class+"Even";
               }
            }
         }
         imgprompt_43_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0100.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TIPOINV_"+sGXsfl_69_idx+"'), id:'"+"TIPOINV_"+sGXsfl_69_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_53_"+sGXsfl_69_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_53_" + sGXsfl_69_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_69_idx + "',69)\"";
         ROClassString = "Attribute";
         Gridbodegas_bodtipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodDetID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A285BodDetID), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A285BodDetID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBodDetID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtBodDetID_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)69,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_53_" + sGXsfl_69_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_69_idx + "',69)\"";
         ROClassString = "Attribute";
         Gridbodegas_bodtipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInv_Internalname,StringUtil.RTrim( A43TipoInv),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInv_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtTipoInv_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)69,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridbodegas_bodtipoRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_43_Internalname,(String)sImgUrl,(String)imgprompt_43_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_43_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridbodegas_bodtipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInvMov_Internalname,(String)A219TipoInvMov,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInvMov_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtTipoInvMov_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)69,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_53_" + sGXsfl_69_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_69_idx + "',69)\"";
         ROClassString = "Attribute";
         Gridbodegas_bodtipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodTipoNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BodTipoNro), 8, 0, ",", "")),((edtBodTipoNro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A226BodTipoNro), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A226BodTipoNro), "ZZZZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBodTipoNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtBodTipoNro_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)69,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridbodegas_bodtipoRow);
         send_integrity_lvl_hashes0F53( ) ;
         GXCCtl = "Z285BodDetID_" + sGXsfl_69_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z285BodDetID), 4, 0, ",", "")));
         GXCCtl = "Z43TipoInv_" + sGXsfl_69_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z43TipoInv));
         GXCCtl = "Z226BodTipoNro_" + sGXsfl_69_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z226BodTipoNro), 8, 0, ",", "")));
         GXCCtl = "nRcdDeleted_53_" + sGXsfl_69_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_53), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_53_" + sGXsfl_69_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_53), 4, 0, ",", "")));
         GXCCtl = "nIsMod_53_" + sGXsfl_69_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_53), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_69_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_69_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV10TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV10TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_69_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GXCCtl = "vBODCOD_" + sGXsfl_69_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "BODDETID_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBodDetID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPOINV_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInv_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPOINVMOV_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvMov_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BODTIPONRO_"+sGXsfl_69_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBodTipoNro_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_43_"+sGXsfl_69_idx+"Link", StringUtil.RTrim( imgprompt_43_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridbodegas_bodtipoContainer.AddRow(Gridbodegas_bodtipoRow);
      }

      protected void ReadRow0F53( )
      {
         nGXsfl_69_idx = (short)(nGXsfl_69_idx+1);
         sGXsfl_69_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_69_idx), 4, 0)), 4, "0");
         SubsflControlProps_6953( ) ;
         edtBodDetID_Enabled = (int)(context.localUtil.CToN( cgiGet( "BODDETID_"+sGXsfl_69_idx+"Enabled"), ",", "."));
         edtTipoInv_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOINV_"+sGXsfl_69_idx+"Enabled"), ",", "."));
         edtTipoInvMov_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOINVMOV_"+sGXsfl_69_idx+"Enabled"), ",", "."));
         edtBodTipoNro_Enabled = (int)(context.localUtil.CToN( cgiGet( "BODTIPONRO_"+sGXsfl_69_idx+"Enabled"), ",", "."));
         imgprompt_1_Link = cgiGet( "PROMPT_43_"+sGXsfl_69_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtBodDetID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBodDetID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "BODDETID_" + sGXsfl_69_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtBodDetID_Internalname;
            wbErr = true;
            A285BodDetID = 0;
         }
         else
         {
            A285BodDetID = (short)(context.localUtil.CToN( cgiGet( edtBodDetID_Internalname), ",", "."));
         }
         A43TipoInv = cgiGet( edtTipoInv_Internalname);
         A219TipoInvMov = cgiGet( edtTipoInvMov_Internalname);
         n219TipoInvMov = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtBodTipoNro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBodTipoNro_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
         {
            GXCCtl = "BODTIPONRO_" + sGXsfl_69_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtBodTipoNro_Internalname;
            wbErr = true;
            A226BodTipoNro = 0;
            n226BodTipoNro = false;
         }
         else
         {
            A226BodTipoNro = (int)(context.localUtil.CToN( cgiGet( edtBodTipoNro_Internalname), ",", "."));
            n226BodTipoNro = false;
         }
         n226BodTipoNro = ((0==A226BodTipoNro) ? true : false);
         GXCCtl = "Z285BodDetID_" + sGXsfl_69_idx;
         Z285BodDetID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z43TipoInv_" + sGXsfl_69_idx;
         Z43TipoInv = cgiGet( GXCCtl);
         GXCCtl = "Z226BodTipoNro_" + sGXsfl_69_idx;
         Z226BodTipoNro = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n226BodTipoNro = ((0==A226BodTipoNro) ? true : false);
         GXCCtl = "nRcdDeleted_53_" + sGXsfl_69_idx;
         nRcdDeleted_53 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_53_" + sGXsfl_69_idx;
         nRcdExists_53 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_53_" + sGXsfl_69_idx;
         nIsMod_53 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtTipoInv_Enabled = edtTipoInv_Enabled;
         defedtBodDetID_Enabled = edtBodDetID_Enabled;
      }

      protected void ConfirmValues0F0( )
      {
         nGXsfl_69_idx = 0;
         sGXsfl_69_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_69_idx), 4, 0)), 4, "0");
         SubsflControlProps_6953( ) ;
         while ( nGXsfl_69_idx < nRC_GXsfl_69 )
         {
            nGXsfl_69_idx = (short)(nGXsfl_69_idx+1);
            sGXsfl_69_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_69_idx), 4, 0)), 4, "0");
            SubsflControlProps_6953( ) ;
            ChangePostValue( "Z285BodDetID_"+sGXsfl_69_idx, cgiGet( "ZT_"+"Z285BodDetID_"+sGXsfl_69_idx)) ;
            DeletePostValue( "ZT_"+"Z285BodDetID_"+sGXsfl_69_idx) ;
            ChangePostValue( "Z43TipoInv_"+sGXsfl_69_idx, cgiGet( "ZT_"+"Z43TipoInv_"+sGXsfl_69_idx)) ;
            DeletePostValue( "ZT_"+"Z43TipoInv_"+sGXsfl_69_idx) ;
            ChangePostValue( "Z226BodTipoNro_"+sGXsfl_69_idx, cgiGet( "ZT_"+"Z226BodTipoNro_"+sGXsfl_69_idx)) ;
            DeletePostValue( "ZT_"+"Z226BodTipoNro_"+sGXsfl_69_idx) ;
         }
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
         context.SendWebValue( "Bodegas") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202211181211355", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("bodegas.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8BodCod)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Bodegas";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("bodegas:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z42BodCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z217BodDsc", StringUtil.RTrim( Z217BodDsc));
         GxWebStd.gx_hidden_field( context, "Z218BodEst", StringUtil.RTrim( Z218BodEst));
         GxWebStd.gx_hidden_field( context, "Z225BodDireccion", Z225BodDireccion);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_69", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_69_idx), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV10TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV10TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vBODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBODCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BodCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV12Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0F34( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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
         return "Bodegas" ;
      }

      public override String GetPgmdesc( )
      {
         return "Bodegas" ;
      }

      protected void InitializeNonKey0F34( )
      {
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A217BodDsc = "";
         n217BodDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A217BodDsc)) ? true : false);
         A218BodEst = "";
         n218BodEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218BodEst", A218BodEst);
         n218BodEst = (String.IsNullOrEmpty(StringUtil.RTrim( A218BodEst)) ? true : false);
         A225BodDireccion = "";
         n225BodDireccion = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BodDireccion", A225BodDireccion);
         n225BodDireccion = (String.IsNullOrEmpty(StringUtil.RTrim( A225BodDireccion)) ? true : false);
         Z217BodDsc = "";
         Z218BodEst = "";
         Z225BodDireccion = "";
      }

      protected void InitAll0F34( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A42BodCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         InitializeNonKey0F34( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0F53( )
      {
         A219TipoInvMov = "";
         n219TipoInvMov = false;
         A226BodTipoNro = 0;
         n226BodTipoNro = false;
         Z226BodTipoNro = 0;
      }

      protected void InitAll0F53( )
      {
         A285BodDetID = 0;
         A43TipoInv = "";
         InitializeNonKey0F53( ) ;
      }

      protected void StandaloneModalInsert0F53( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202211181211370", true);
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
         context.AddJavascriptSource("bodegas.js", "?202211181211370", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties53( )
      {
         edtTipoInv_Enabled = defedtTipoInv_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
         edtBodDetID_Enabled = defedtBodDetID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDetID_Enabled), 5, 0)), !bGXsfl_69_Refreshing);
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtEmpID_Internalname = "EMPID";
         divSection1_Internalname = "SECTION1";
         edtempdsc_Internalname = "EMPDSC";
         divSection2_Internalname = "SECTION2";
         edtBodCod_Internalname = "BODCOD";
         edtBodDsc_Internalname = "BODDSC";
         chkBodEst_Internalname = "BODEST";
         edtBodDireccion_Internalname = "BODDIRECCION";
         lblTitlebodtipo_Internalname = "TITLEBODTIPO";
         edtBodDetID_Internalname = "BODDETID";
         edtTipoInv_Internalname = "TIPOINV";
         edtTipoInvMov_Internalname = "TIPOINVMOV";
         edtBodTipoNro_Internalname = "BODTIPONRO";
         divBodtipotable_Internalname = "BODTIPOTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_43_Internalname = "PROMPT_43";
         subGridbodegas_bodtipo_Internalname = "GRIDBODEGAS_BODTIPO";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtBodTipoNro_Jsonclick = "";
         edtTipoInvMov_Jsonclick = "";
         imgprompt_43_Visible = 1;
         imgprompt_43_Link = "";
         imgprompt_1_Visible = 1;
         edtTipoInv_Jsonclick = "";
         edtBodDetID_Jsonclick = "";
         subGridbodegas_bodtipo_Class = "Grid";
         subGridbodegas_bodtipo_Backcolorstyle = 0;
         subGridbodegas_bodtipo_Allowcollapsing = 0;
         subGridbodegas_bodtipo_Allowselection = 0;
         edtBodTipoNro_Enabled = 1;
         edtTipoInvMov_Enabled = 0;
         edtTipoInv_Enabled = 1;
         edtBodDetID_Enabled = 1;
         subGridbodegas_bodtipo_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtBodDireccion_Enabled = 1;
         chkBodEst.Enabled = 1;
         edtBodDsc_Jsonclick = "";
         edtBodDsc_Enabled = 1;
         edtBodCod_Jsonclick = "";
         edtBodCod_Enabled = 1;
         edtempdsc_Jsonclick = "";
         edtempdsc_Enabled = 0;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridbodegas_bodtipo_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_6953( ) ;
         while ( nGXsfl_69_idx <= nRC_GXsfl_69 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0F53( ) ;
            standaloneModal0F53( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0F53( ) ;
            nGXsfl_69_idx = (short)(nGXsfl_69_idx+1);
            sGXsfl_69_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_69_idx), 4, 0)), 4, "0");
            SubsflControlProps_6953( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridbodegas_bodtipoContainer));
         /* End function gxnrGridbodegas_bodtipo_newrow */
      }

      protected void init_web_controls( )
      {
         chkBodEst.Name = "BODEST";
         chkBodEst.WebTags = "";
         chkBodEst.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBodEst_Internalname, "TitleCaption", chkBodEst.Caption, true);
         chkBodEst.CheckedValue = "I";
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000F16 */
         pr_default.execute(14, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000F16_A44empdsc[0];
         n44empdsc = T000F16_n44empdsc[0];
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A44empdsc = "";
            n44empdsc = false;
         }
         isValidOutput.Add(A44empdsc);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Tipoinv( String GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A43TipoInv = GX_Parm1;
         A219TipoInvMov = GX_Parm2;
         n219TipoInvMov = false;
         /* Using cursor T000F27 */
         pr_default.execute(25, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(25) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, "TIPOINV");
            AnyError = 1;
            GX_FocusControl = edtTipoInv_Internalname;
         }
         A219TipoInvMov = T000F27_A219TipoInvMov[0];
         n219TipoInvMov = T000F27_n219TipoInvMov[0];
         pr_default.close(25);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A219TipoInvMov = "";
            n219TipoInvMov = false;
         }
         isValidOutput.Add(A219TipoInvMov);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8BodCod',fld:'vBODCOD',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8BodCod',fld:'vBODCOD',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120F2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
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
         pr_default.close(1);
         pr_default.close(25);
         pr_default.close(4);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z217BodDsc = "";
         Z218BodEst = "";
         Z225BodDireccion = "";
         Z43TipoInv = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A43TipoInv = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         sImgUrl = "";
         A44empdsc = "";
         A217BodDsc = "";
         A218BodEst = "";
         A225BodDireccion = "";
         lblTitlebodtipo_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridbodegas_bodtipoContainer = new GXWebGrid( context);
         Gridbodegas_bodtipoColumn = new GXWebColumn();
         A219TipoInvMov = "";
         sMode53 = "";
         sStyleString = "";
         AV12Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode34 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = context.GetSession();
         Z44empdsc = "";
         T000F7_A44empdsc = new String[] {""} ;
         T000F7_n44empdsc = new bool[] {false} ;
         T000F8_A42BodCod = new short[1] ;
         T000F8_A44empdsc = new String[] {""} ;
         T000F8_n44empdsc = new bool[] {false} ;
         T000F8_A217BodDsc = new String[] {""} ;
         T000F8_n217BodDsc = new bool[] {false} ;
         T000F8_A218BodEst = new String[] {""} ;
         T000F8_n218BodEst = new bool[] {false} ;
         T000F8_A225BodDireccion = new String[] {""} ;
         T000F8_n225BodDireccion = new bool[] {false} ;
         T000F8_A1EmpID = new short[1] ;
         T000F9_A44empdsc = new String[] {""} ;
         T000F9_n44empdsc = new bool[] {false} ;
         T000F10_A1EmpID = new short[1] ;
         T000F10_A42BodCod = new short[1] ;
         T000F6_A42BodCod = new short[1] ;
         T000F6_A217BodDsc = new String[] {""} ;
         T000F6_n217BodDsc = new bool[] {false} ;
         T000F6_A218BodEst = new String[] {""} ;
         T000F6_n218BodEst = new bool[] {false} ;
         T000F6_A225BodDireccion = new String[] {""} ;
         T000F6_n225BodDireccion = new bool[] {false} ;
         T000F6_A1EmpID = new short[1] ;
         T000F11_A1EmpID = new short[1] ;
         T000F11_A42BodCod = new short[1] ;
         T000F12_A1EmpID = new short[1] ;
         T000F12_A42BodCod = new short[1] ;
         T000F5_A42BodCod = new short[1] ;
         T000F5_A217BodDsc = new String[] {""} ;
         T000F5_n217BodDsc = new bool[] {false} ;
         T000F5_A218BodEst = new String[] {""} ;
         T000F5_n218BodEst = new bool[] {false} ;
         T000F5_A225BodDireccion = new String[] {""} ;
         T000F5_n225BodDireccion = new bool[] {false} ;
         T000F5_A1EmpID = new short[1] ;
         T000F16_A44empdsc = new String[] {""} ;
         T000F16_n44empdsc = new bool[] {false} ;
         T000F17_A290stockAnio = new short[1] ;
         T000F17_A291stockMes = new short[1] ;
         T000F17_A1EmpID = new short[1] ;
         T000F17_A2AgeID = new short[1] ;
         T000F17_A42BodCod = new short[1] ;
         T000F17_A286PrdCod = new short[1] ;
         T000F18_A1EmpID = new short[1] ;
         T000F18_A2AgeID = new short[1] ;
         T000F18_A317OCompNro = new short[1] ;
         T000F18_A311OcTipoCod = new String[] {""} ;
         T000F19_A1EmpID = new short[1] ;
         T000F19_A2AgeID = new short[1] ;
         T000F19_A42BodCod = new short[1] ;
         T000F19_A264invCod = new short[1] ;
         T000F20_A1EmpID = new short[1] ;
         T000F20_A42BodCod = new short[1] ;
         Z219TipoInvMov = "";
         T000F21_A1EmpID = new short[1] ;
         T000F21_A42BodCod = new short[1] ;
         T000F21_A285BodDetID = new short[1] ;
         T000F21_A219TipoInvMov = new String[] {""} ;
         T000F21_n219TipoInvMov = new bool[] {false} ;
         T000F21_A226BodTipoNro = new int[1] ;
         T000F21_n226BodTipoNro = new bool[] {false} ;
         T000F21_A43TipoInv = new String[] {""} ;
         T000F4_A219TipoInvMov = new String[] {""} ;
         T000F4_n219TipoInvMov = new bool[] {false} ;
         T000F22_A219TipoInvMov = new String[] {""} ;
         T000F22_n219TipoInvMov = new bool[] {false} ;
         T000F23_A1EmpID = new short[1] ;
         T000F23_A42BodCod = new short[1] ;
         T000F23_A285BodDetID = new short[1] ;
         T000F23_A43TipoInv = new String[] {""} ;
         T000F3_A1EmpID = new short[1] ;
         T000F3_A42BodCod = new short[1] ;
         T000F3_A285BodDetID = new short[1] ;
         T000F3_A226BodTipoNro = new int[1] ;
         T000F3_n226BodTipoNro = new bool[] {false} ;
         T000F3_A43TipoInv = new String[] {""} ;
         T000F2_A1EmpID = new short[1] ;
         T000F2_A42BodCod = new short[1] ;
         T000F2_A285BodDetID = new short[1] ;
         T000F2_A226BodTipoNro = new int[1] ;
         T000F2_n226BodTipoNro = new bool[] {false} ;
         T000F2_A43TipoInv = new String[] {""} ;
         T000F27_A219TipoInvMov = new String[] {""} ;
         T000F27_n219TipoInvMov = new bool[] {false} ;
         T000F28_A1EmpID = new short[1] ;
         T000F28_A42BodCod = new short[1] ;
         T000F28_A285BodDetID = new short[1] ;
         T000F28_A43TipoInv = new String[] {""} ;
         Gridbodegas_bodtipoRow = new GXWebRow();
         subGridbodegas_bodtipo_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bodegas__default(),
            new Object[][] {
                new Object[] {
               T000F2_A1EmpID, T000F2_A42BodCod, T000F2_A285BodDetID, T000F2_A226BodTipoNro, T000F2_n226BodTipoNro, T000F2_A43TipoInv
               }
               , new Object[] {
               T000F3_A1EmpID, T000F3_A42BodCod, T000F3_A285BodDetID, T000F3_A226BodTipoNro, T000F3_n226BodTipoNro, T000F3_A43TipoInv
               }
               , new Object[] {
               T000F4_A219TipoInvMov, T000F4_n219TipoInvMov
               }
               , new Object[] {
               T000F5_A42BodCod, T000F5_A217BodDsc, T000F5_n217BodDsc, T000F5_A218BodEst, T000F5_n218BodEst, T000F5_A225BodDireccion, T000F5_n225BodDireccion, T000F5_A1EmpID
               }
               , new Object[] {
               T000F6_A42BodCod, T000F6_A217BodDsc, T000F6_n217BodDsc, T000F6_A218BodEst, T000F6_n218BodEst, T000F6_A225BodDireccion, T000F6_n225BodDireccion, T000F6_A1EmpID
               }
               , new Object[] {
               T000F7_A44empdsc, T000F7_n44empdsc
               }
               , new Object[] {
               T000F8_A42BodCod, T000F8_A44empdsc, T000F8_n44empdsc, T000F8_A217BodDsc, T000F8_n217BodDsc, T000F8_A218BodEst, T000F8_n218BodEst, T000F8_A225BodDireccion, T000F8_n225BodDireccion, T000F8_A1EmpID
               }
               , new Object[] {
               T000F9_A44empdsc, T000F9_n44empdsc
               }
               , new Object[] {
               T000F10_A1EmpID, T000F10_A42BodCod
               }
               , new Object[] {
               T000F11_A1EmpID, T000F11_A42BodCod
               }
               , new Object[] {
               T000F12_A1EmpID, T000F12_A42BodCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000F16_A44empdsc, T000F16_n44empdsc
               }
               , new Object[] {
               T000F17_A290stockAnio, T000F17_A291stockMes, T000F17_A1EmpID, T000F17_A2AgeID, T000F17_A42BodCod, T000F17_A286PrdCod
               }
               , new Object[] {
               T000F18_A1EmpID, T000F18_A2AgeID, T000F18_A317OCompNro, T000F18_A311OcTipoCod
               }
               , new Object[] {
               T000F19_A1EmpID, T000F19_A2AgeID, T000F19_A42BodCod, T000F19_A264invCod
               }
               , new Object[] {
               T000F20_A1EmpID, T000F20_A42BodCod
               }
               , new Object[] {
               T000F21_A1EmpID, T000F21_A42BodCod, T000F21_A285BodDetID, T000F21_A219TipoInvMov, T000F21_n219TipoInvMov, T000F21_A226BodTipoNro, T000F21_n226BodTipoNro, T000F21_A43TipoInv
               }
               , new Object[] {
               T000F22_A219TipoInvMov, T000F22_n219TipoInvMov
               }
               , new Object[] {
               T000F23_A1EmpID, T000F23_A42BodCod, T000F23_A285BodDetID, T000F23_A43TipoInv
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000F27_A219TipoInvMov, T000F27_n219TipoInvMov
               }
               , new Object[] {
               T000F28_A1EmpID, T000F28_A42BodCod, T000F28_A285BodDetID, T000F28_A43TipoInv
               }
            }
         );
         AV12Pgmname = "Bodegas";
      }

      private short nIsMod_53 ;
      private short wcpOAV7EmpID ;
      private short wcpOAV8BodCod ;
      private short Z1EmpID ;
      private short Z42BodCod ;
      private short nRC_GXsfl_69 ;
      private short nGXsfl_69_idx=1 ;
      private short Z285BodDetID ;
      private short nRcdDeleted_53 ;
      private short nRcdExists_53 ;
      private short GxWebError ;
      private short A1EmpID ;
      private short AV7EmpID ;
      private short AV8BodCod ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A42BodCod ;
      private short subGridbodegas_bodtipo_Backcolorstyle ;
      private short A285BodDetID ;
      private short subGridbodegas_bodtipo_Allowselection ;
      private short subGridbodegas_bodtipo_Allowhovering ;
      private short subGridbodegas_bodtipo_Allowcollapsing ;
      private short subGridbodegas_bodtipo_Collapsed ;
      private short nBlankRcdCount53 ;
      private short RcdFound53 ;
      private short nBlankRcdUsr53 ;
      private short RcdFound34 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short subGridbodegas_bodtipo_Backstyle ;
      private short wbTemp ;
      private int Z226BodTipoNro ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtempdsc_Enabled ;
      private int edtBodCod_Enabled ;
      private int edtBodDsc_Enabled ;
      private int edtBodDireccion_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtBodDetID_Enabled ;
      private int edtTipoInv_Enabled ;
      private int edtTipoInvMov_Enabled ;
      private int A226BodTipoNro ;
      private int edtBodTipoNro_Enabled ;
      private int subGridbodegas_bodtipo_Selectedindex ;
      private int subGridbodegas_bodtipo_Selectioncolor ;
      private int subGridbodegas_bodtipo_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridbodegas_bodtipo_Backcolor ;
      private int subGridbodegas_bodtipo_Allbackcolor ;
      private int imgprompt_43_Visible ;
      private int defedtTipoInv_Enabled ;
      private int defedtBodDetID_Enabled ;
      private int idxLst ;
      private long GRIDBODEGAS_BODTIPO_nFirstRecordOnPage ;
      private String sPrefix ;
      private String sGXsfl_69_idx="0001" ;
      private String wcpOGx_mode ;
      private String Z217BodDsc ;
      private String Z218BodEst ;
      private String Z43TipoInv ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A43TipoInv ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEmpID_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String divSection1_Internalname ;
      private String edtEmpID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String divSection2_Internalname ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String edtBodCod_Internalname ;
      private String edtBodCod_Jsonclick ;
      private String edtBodDsc_Internalname ;
      private String A217BodDsc ;
      private String edtBodDsc_Jsonclick ;
      private String chkBodEst_Internalname ;
      private String A218BodEst ;
      private String edtBodDireccion_Internalname ;
      private String divBodtipotable_Internalname ;
      private String lblTitlebodtipo_Internalname ;
      private String lblTitlebodtipo_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridbodegas_bodtipo_Header ;
      private String sMode53 ;
      private String edtBodDetID_Internalname ;
      private String edtTipoInv_Internalname ;
      private String edtTipoInvMov_Internalname ;
      private String edtBodTipoNro_Internalname ;
      private String sStyleString ;
      private String AV12Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode34 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String imgprompt_43_Internalname ;
      private String sGXsfl_69_fel_idx="0001" ;
      private String subGridbodegas_bodtipo_Class ;
      private String subGridbodegas_bodtipo_Linesclass ;
      private String imgprompt_43_Link ;
      private String ROClassString ;
      private String edtBodDetID_Jsonclick ;
      private String edtTipoInv_Jsonclick ;
      private String edtTipoInvMov_Jsonclick ;
      private String edtBodTipoNro_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridbodegas_bodtipo_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_69_Refreshing=false ;
      private bool n44empdsc ;
      private bool n217BodDsc ;
      private bool n218BodEst ;
      private bool n225BodDireccion ;
      private bool returnInSub ;
      private bool n219TipoInvMov ;
      private bool n226BodTipoNro ;
      private String Z225BodDireccion ;
      private String A44empdsc ;
      private String A225BodDireccion ;
      private String A219TipoInvMov ;
      private String Z44empdsc ;
      private String Z219TipoInvMov ;
      private IGxSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridbodegas_bodtipoContainer ;
      private GXWebRow Gridbodegas_bodtipoRow ;
      private GXWebColumn Gridbodegas_bodtipoColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkBodEst ;
      private IDataStoreProvider pr_default ;
      private String[] T000F7_A44empdsc ;
      private bool[] T000F7_n44empdsc ;
      private short[] T000F8_A42BodCod ;
      private String[] T000F8_A44empdsc ;
      private bool[] T000F8_n44empdsc ;
      private String[] T000F8_A217BodDsc ;
      private bool[] T000F8_n217BodDsc ;
      private String[] T000F8_A218BodEst ;
      private bool[] T000F8_n218BodEst ;
      private String[] T000F8_A225BodDireccion ;
      private bool[] T000F8_n225BodDireccion ;
      private short[] T000F8_A1EmpID ;
      private String[] T000F9_A44empdsc ;
      private bool[] T000F9_n44empdsc ;
      private short[] T000F10_A1EmpID ;
      private short[] T000F10_A42BodCod ;
      private short[] T000F6_A42BodCod ;
      private String[] T000F6_A217BodDsc ;
      private bool[] T000F6_n217BodDsc ;
      private String[] T000F6_A218BodEst ;
      private bool[] T000F6_n218BodEst ;
      private String[] T000F6_A225BodDireccion ;
      private bool[] T000F6_n225BodDireccion ;
      private short[] T000F6_A1EmpID ;
      private short[] T000F11_A1EmpID ;
      private short[] T000F11_A42BodCod ;
      private short[] T000F12_A1EmpID ;
      private short[] T000F12_A42BodCod ;
      private short[] T000F5_A42BodCod ;
      private String[] T000F5_A217BodDsc ;
      private bool[] T000F5_n217BodDsc ;
      private String[] T000F5_A218BodEst ;
      private bool[] T000F5_n218BodEst ;
      private String[] T000F5_A225BodDireccion ;
      private bool[] T000F5_n225BodDireccion ;
      private short[] T000F5_A1EmpID ;
      private String[] T000F16_A44empdsc ;
      private bool[] T000F16_n44empdsc ;
      private short[] T000F17_A290stockAnio ;
      private short[] T000F17_A291stockMes ;
      private short[] T000F17_A1EmpID ;
      private short[] T000F17_A2AgeID ;
      private short[] T000F17_A42BodCod ;
      private short[] T000F17_A286PrdCod ;
      private short[] T000F18_A1EmpID ;
      private short[] T000F18_A2AgeID ;
      private short[] T000F18_A317OCompNro ;
      private String[] T000F18_A311OcTipoCod ;
      private short[] T000F19_A1EmpID ;
      private short[] T000F19_A2AgeID ;
      private short[] T000F19_A42BodCod ;
      private short[] T000F19_A264invCod ;
      private short[] T000F20_A1EmpID ;
      private short[] T000F20_A42BodCod ;
      private short[] T000F21_A1EmpID ;
      private short[] T000F21_A42BodCod ;
      private short[] T000F21_A285BodDetID ;
      private String[] T000F21_A219TipoInvMov ;
      private bool[] T000F21_n219TipoInvMov ;
      private int[] T000F21_A226BodTipoNro ;
      private bool[] T000F21_n226BodTipoNro ;
      private String[] T000F21_A43TipoInv ;
      private String[] T000F4_A219TipoInvMov ;
      private bool[] T000F4_n219TipoInvMov ;
      private String[] T000F22_A219TipoInvMov ;
      private bool[] T000F22_n219TipoInvMov ;
      private short[] T000F23_A1EmpID ;
      private short[] T000F23_A42BodCod ;
      private short[] T000F23_A285BodDetID ;
      private String[] T000F23_A43TipoInv ;
      private short[] T000F3_A1EmpID ;
      private short[] T000F3_A42BodCod ;
      private short[] T000F3_A285BodDetID ;
      private int[] T000F3_A226BodTipoNro ;
      private bool[] T000F3_n226BodTipoNro ;
      private String[] T000F3_A43TipoInv ;
      private short[] T000F2_A1EmpID ;
      private short[] T000F2_A42BodCod ;
      private short[] T000F2_A285BodDetID ;
      private int[] T000F2_A226BodTipoNro ;
      private bool[] T000F2_n226BodTipoNro ;
      private String[] T000F2_A43TipoInv ;
      private String[] T000F27_A219TipoInvMov ;
      private bool[] T000F27_n219TipoInvMov ;
      private short[] T000F28_A1EmpID ;
      private short[] T000F28_A42BodCod ;
      private short[] T000F28_A285BodDetID ;
      private String[] T000F28_A43TipoInv ;
      private SdtTransactionContext AV10TrnContext ;
   }

   public class bodegas__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000F8 ;
          prmT000F8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F7 ;
          prmT000F7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F9 ;
          prmT000F9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F10 ;
          prmT000F10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F6 ;
          prmT000F6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F11 ;
          prmT000F11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F12 ;
          prmT000F12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F5 ;
          prmT000F5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F13 ;
          prmT000F13 = new Object[] {
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@BodEst",SqlDbType.Char,1,0} ,
          new Object[] {"@BodDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F14 ;
          prmT000F14 = new Object[] {
          new Object[] {"@BodDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@BodEst",SqlDbType.Char,1,0} ,
          new Object[] {"@BodDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F15 ;
          prmT000F15 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F17 ;
          prmT000F17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F18 ;
          prmT000F18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F19 ;
          prmT000F19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F20 ;
          prmT000F20 = new Object[] {
          } ;
          Object[] prmT000F21 ;
          prmT000F21 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000F4 ;
          prmT000F4 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000F22 ;
          prmT000F22 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000F23 ;
          prmT000F23 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000F3 ;
          prmT000F3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000F2 ;
          prmT000F2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000F24 ;
          prmT000F24 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodTipoNro",SqlDbType.Int,8,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000F25 ;
          prmT000F25 = new Object[] {
          new Object[] {"@BodTipoNro",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000F26 ;
          prmT000F26 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000F28 ;
          prmT000F28 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F16 ;
          prmT000F16 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F27 ;
          prmT000F27 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000F2", "SELECT [EmpID], [BodCod], [BodDetID], [BodTipoNro], [TipoInv] FROM [BodegasBodTipo] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod AND [BodDetID] = @BodDetID AND [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F2,1,0,true,false )
             ,new CursorDef("T000F3", "SELECT [EmpID], [BodCod], [BodDetID], [BodTipoNro], [TipoInv] FROM [BodegasBodTipo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod AND [BodDetID] = @BodDetID AND [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F3,1,0,true,false )
             ,new CursorDef("T000F4", "SELECT [TipoInvMov] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F4,1,0,true,false )
             ,new CursorDef("T000F5", "SELECT [BodCod], [BodDsc], [BodEst], [BodDireccion], [EmpID] FROM [Bodegas] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F5,1,0,true,false )
             ,new CursorDef("T000F6", "SELECT [BodCod], [BodDsc], [BodEst], [BodDireccion], [EmpID] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F6,1,0,true,false )
             ,new CursorDef("T000F7", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F7,1,0,true,false )
             ,new CursorDef("T000F8", "SELECT TM1.[BodCod], T2.[empdsc], TM1.[BodDsc], TM1.[BodEst], TM1.[BodDireccion], TM1.[EmpID] FROM ([Bodegas] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) WHERE TM1.[EmpID] = @EmpID and TM1.[BodCod] = @BodCod ORDER BY TM1.[EmpID], TM1.[BodCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F8,100,0,true,false )
             ,new CursorDef("T000F9", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F9,1,0,true,false )
             ,new CursorDef("T000F10", "SELECT [EmpID], [BodCod] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F10,1,0,true,false )
             ,new CursorDef("T000F11", "SELECT TOP 1 [EmpID], [BodCod] FROM [Bodegas] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [BodCod] > @BodCod) ORDER BY [EmpID], [BodCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F11,1,0,true,true )
             ,new CursorDef("T000F12", "SELECT TOP 1 [EmpID], [BodCod] FROM [Bodegas] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [BodCod] < @BodCod) ORDER BY [EmpID] DESC, [BodCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F12,1,0,true,true )
             ,new CursorDef("T000F13", "INSERT INTO [Bodegas]([BodCod], [BodDsc], [BodEst], [BodDireccion], [EmpID]) VALUES(@BodCod, @BodDsc, @BodEst, @BodDireccion, @EmpID)", GxErrorMask.GX_NOMASK,prmT000F13)
             ,new CursorDef("T000F14", "UPDATE [Bodegas] SET [BodDsc]=@BodDsc, [BodEst]=@BodEst, [BodDireccion]=@BodDireccion  WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod", GxErrorMask.GX_NOMASK,prmT000F14)
             ,new CursorDef("T000F15", "DELETE FROM [Bodegas]  WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod", GxErrorMask.GX_NOMASK,prmT000F15)
             ,new CursorDef("T000F16", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F16,1,0,true,false )
             ,new CursorDef("T000F17", "SELECT TOP 1 [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodega] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F17,1,0,true,true )
             ,new CursorDef("T000F18", "SELECT TOP 1 [EmpID], [AgeID], [OCompNro], [OcTipoCod] FROM [OrdenCompra] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F18,1,0,true,true )
             ,new CursorDef("T000F19", "SELECT TOP 1 [EmpID], [AgeID], [BodCod], [invCod] FROM [Inventario] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F19,1,0,true,true )
             ,new CursorDef("T000F20", "SELECT [EmpID], [BodCod] FROM [Bodegas] WITH (NOLOCK) ORDER BY [EmpID], [BodCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F20,100,0,true,false )
             ,new CursorDef("T000F21", "SELECT T1.[EmpID], T1.[BodCod], T1.[BodDetID], T2.[TipoInvMov], T1.[BodTipoNro], T1.[TipoInv] FROM ([BodegasBodTipo] T1 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T2 WITH (NOLOCK) ON T2.[TipoInv] = T1.[TipoInv]) WHERE T1.[EmpID] = @EmpID and T1.[BodCod] = @BodCod and T1.[BodDetID] = @BodDetID and T1.[TipoInv] = @TipoInv ORDER BY T1.[EmpID], T1.[BodCod], T1.[BodDetID], T1.[TipoInv] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F21,11,0,true,false )
             ,new CursorDef("T000F22", "SELECT [TipoInvMov] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F22,1,0,true,false )
             ,new CursorDef("T000F23", "SELECT [EmpID], [BodCod], [BodDetID], [TipoInv] FROM [BodegasBodTipo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod AND [BodDetID] = @BodDetID AND [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F23,1,0,true,false )
             ,new CursorDef("T000F24", "INSERT INTO [BodegasBodTipo]([EmpID], [BodCod], [BodDetID], [BodTipoNro], [TipoInv]) VALUES(@EmpID, @BodCod, @BodDetID, @BodTipoNro, @TipoInv)", GxErrorMask.GX_NOMASK,prmT000F24)
             ,new CursorDef("T000F25", "UPDATE [BodegasBodTipo] SET [BodTipoNro]=@BodTipoNro  WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod AND [BodDetID] = @BodDetID AND [TipoInv] = @TipoInv", GxErrorMask.GX_NOMASK,prmT000F25)
             ,new CursorDef("T000F26", "DELETE FROM [BodegasBodTipo]  WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod AND [BodDetID] = @BodDetID AND [TipoInv] = @TipoInv", GxErrorMask.GX_NOMASK,prmT000F26)
             ,new CursorDef("T000F27", "SELECT [TipoInvMov] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F27,1,0,true,false )
             ,new CursorDef("T000F28", "SELECT [EmpID], [BodCod], [BodDetID], [TipoInv] FROM [BodegasBodTipo] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [BodCod] = @BodCod ORDER BY [EmpID], [BodCod], [BodDetID], [TipoInv] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F28,11,0,true,false )
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
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 4) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 4) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((int[]) buf[5])[0] = rslt.getInt(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getString(6, 4) ;
                return;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 4) ;
                return;
             case 25 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 26 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 4) ;
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
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
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[6]);
                }
                stmt.SetParameter(5, (short)parms[7]);
                return;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                stmt.SetParameter(4, (short)parms[6]);
                stmt.SetParameter(5, (short)parms[7]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(4, (int)parms[4]);
                }
                stmt.SetParameter(5, (String)parms[5]);
                return;
             case 23 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (String)parms[5]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 25 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
