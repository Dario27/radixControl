/*
               File: PeriodosDet
        Description: Periodos Det
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 0:42:59.12
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
   public class periodosdet : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridperiodosdet_detfch") == 0 )
         {
            nRC_GXsfl_73 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_73_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_73_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridperiodosdet_detfch_newrow( ) ;
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
               A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_EMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
               A327procesoCod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_PROCESOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A327procesoCod, "")), context));
               A335PerAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335PerAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A335PerAnio), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_PERANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A335PerAnio), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Periodos Det", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPerUltMes_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public periodosdet( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public periodosdet( IGxContext context )
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
                           String aP2_procesoCod ,
                           short aP3_PerAnio )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.A1EmpID = aP1_EmpID;
         this.A327procesoCod = aP2_procesoCod;
         this.A335PerAnio = aP3_PerAnio;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Periodos Det", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_PeriodosDet.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 5, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Emp ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), ((edtEmpID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")) : context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtprocesoCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtprocesoCod_Internalname, "Proceso", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtprocesoCod_Internalname, A327procesoCod, StringUtil.RTrim( context.localUtil.Format( A327procesoCod, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprocesoCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtprocesoCod_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPerFchControl_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPerFchControl_Internalname, "Fecha Control", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtPerFchControl_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPerFchControl_Internalname, context.localUtil.Format(A328PerFchControl, "99/99/9999"), context.localUtil.Format( A328PerFchControl, "99/99/9999"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPerFchControl_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPerFchControl_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PeriodosDet.htm");
            GxWebStd.gx_bitmap( context, edtPerFchControl_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtPerFchControl_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PeriodosDet.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPerUser_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPerUser_Internalname, "Per User", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPerUser_Internalname, StringUtil.RTrim( A333PerUser), StringUtil.RTrim( context.localUtil.Format( A333PerUser, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPerUser_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPerUser_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPerUserName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPerUserName_Internalname, "Per User Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPerUserName_Internalname, A334PerUserName, StringUtil.RTrim( context.localUtil.Format( A334PerUserName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPerUserName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPerUserName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPerAnio_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPerAnio_Internalname, "Año", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPerAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A335PerAnio), 4, 0, ",", "")), ((edtPerAnio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A335PerAnio), "ZZZ9")) : context.localUtil.Format( (decimal)(A335PerAnio), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPerAnio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPerAnio_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPerUltMes_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPerUltMes_Internalname, "Ultm. Mes", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPerUltMes_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A336PerUltMes), 2, 0, ",", "")), ((edtPerUltMes_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A336PerUltMes), "Z9")) : context.localUtil.Format( (decimal)(A336PerUltMes), "Z9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPerUltMes_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPerUltMes_Enabled, 0, "number", "1", 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDetfchtable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitledetfch_Internalname, "det Fch", "", "", lblTitledetfch_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridperiodosdet_detfch( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_PeriodosDet.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm1078( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridperiodosdet_detfch( )
      {
         /*  Grid Control  */
         Gridperiodosdet_detfchContainer.AddObjectProperty("GridName", "Gridperiodosdet_detfch");
         Gridperiodosdet_detfchContainer.AddObjectProperty("Header", subGridperiodosdet_detfch_Header);
         Gridperiodosdet_detfchContainer.AddObjectProperty("Class", "Grid");
         Gridperiodosdet_detfchContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodosdet_detfch_Backcolorstyle), 1, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddObjectProperty("CmpContext", "");
         Gridperiodosdet_detfchContainer.AddObjectProperty("InMasterPage", "false");
         Gridperiodosdet_detfchColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridperiodosdet_detfchColumn.AddObjectProperty("Value", context.localUtil.Format(A337detFchIni, "99/99/9999"));
         Gridperiodosdet_detfchColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetFchIni_Enabled), 5, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddColumnProperties(Gridperiodosdet_detfchColumn);
         Gridperiodosdet_detfchColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridperiodosdet_detfchColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A338detMes), 2, 0, ".", "")));
         Gridperiodosdet_detfchColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetMes_Enabled), 5, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddColumnProperties(Gridperiodosdet_detfchColumn);
         Gridperiodosdet_detfchColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridperiodosdet_detfchColumn.AddObjectProperty("Value", StringUtil.RTrim( A339detPerEstado));
         Gridperiodosdet_detfchColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetPerEstado_Enabled), 5, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddColumnProperties(Gridperiodosdet_detfchColumn);
         Gridperiodosdet_detfchContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodosdet_detfch_Selectedindex), 4, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodosdet_detfch_Allowselection), 1, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodosdet_detfch_Selectioncolor), 9, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodosdet_detfch_Allowhovering), 1, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodosdet_detfch_Hoveringcolor), 9, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodosdet_detfch_Allowcollapsing), 1, 0, ".", "")));
         Gridperiodosdet_detfchContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridperiodosdet_detfch_Collapsed), 1, 0, ".", "")));
         nGXsfl_73_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount79 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_79 = 1;
               ScanStart1079( ) ;
               while ( RcdFound79 != 0 )
               {
                  init_level_properties79( ) ;
                  getByPrimaryKey1079( ) ;
                  AddRow1079( ) ;
                  ScanNext1079( ) ;
               }
               ScanEnd1079( ) ;
               nBlankRcdCount79 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal1079( ) ;
            standaloneModal1079( ) ;
            sMode79 = Gx_mode;
            while ( nGXsfl_73_idx < nRC_GXsfl_73 )
            {
               bGXsfl_73_Refreshing = true;
               ReadRow1079( ) ;
               edtdetFchIni_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETFCHINI_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetFchIni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetFchIni_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtdetMes_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETMES_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetMes_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               edtdetPerEstado_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETPERESTADO_"+sGXsfl_73_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetPerEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetPerEstado_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
               if ( ( nRcdExists_79 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal1079( ) ;
               }
               SendRow1079( ) ;
               bGXsfl_73_Refreshing = false;
            }
            Gx_mode = sMode79;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount79 = 5;
            nRcdExists_79 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart1079( ) ;
               while ( RcdFound79 != 0 )
               {
                  sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_7379( ) ;
                  init_level_properties79( ) ;
                  standaloneNotModal1079( ) ;
                  getByPrimaryKey1079( ) ;
                  standaloneModal1079( ) ;
                  AddRow1079( ) ;
                  ScanNext1079( ) ;
               }
               ScanEnd1079( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode79 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_7379( ) ;
            InitAll1079( ) ;
            init_level_properties79( ) ;
            standaloneNotModal1079( ) ;
            standaloneModal1079( ) ;
            nRcdExists_79 = 0;
            nIsMod_79 = 0;
            nRcdDeleted_79 = 0;
            nBlankRcdCount79 = (short)(nBlankRcdUsr79+nBlankRcdCount79);
            fRowAdded = 0;
            while ( nBlankRcdCount79 > 0 )
            {
               AddRow1079( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtdetFchIni_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount79 = (short)(nBlankRcdCount79-1);
            }
            Gx_mode = sMode79;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridperiodosdet_detfchContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridperiodosdet_detfch", Gridperiodosdet_detfchContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridperiodosdet_detfchContainerData", Gridperiodosdet_detfchContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridperiodosdet_detfchContainerData"+"V", Gridperiodosdet_detfchContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridperiodosdet_detfchContainerData"+"V"+"\" value='"+Gridperiodosdet_detfchContainer.GridValuesHidden()+"'/>") ;
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
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A1EmpID = (short)(context.localUtil.CToN( cgiGet( edtEmpID_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_EMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
               A327procesoCod = cgiGet( edtprocesoCod_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_PROCESOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A327procesoCod, "")), context));
               A328PerFchControl = context.localUtil.CToD( cgiGet( edtPerFchControl_Internalname), 2);
               n328PerFchControl = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
               A333PerUser = cgiGet( edtPerUser_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333PerUser", A333PerUser);
               A334PerUserName = cgiGet( edtPerUserName_Internalname);
               n334PerUserName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334PerUserName", A334PerUserName);
               A335PerAnio = (short)(context.localUtil.CToN( cgiGet( edtPerAnio_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335PerAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A335PerAnio), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_PERANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A335PerAnio), "ZZZ9"), context));
               if ( ( ( context.localUtil.CToN( cgiGet( edtPerUltMes_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPerUltMes_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PERULTMES");
                  AnyError = 1;
                  GX_FocusControl = edtPerUltMes_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A336PerUltMes = 0;
                  n336PerUltMes = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336PerUltMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A336PerUltMes), 2, 0)));
               }
               else
               {
                  A336PerUltMes = (short)(context.localUtil.CToN( cgiGet( edtPerUltMes_Internalname), ",", "."));
                  n336PerUltMes = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336PerUltMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A336PerUltMes), 2, 0)));
               }
               n336PerUltMes = ((0==A336PerUltMes) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z327procesoCod = cgiGet( "Z327procesoCod");
               Z335PerAnio = (short)(context.localUtil.CToN( cgiGet( "Z335PerAnio"), ",", "."));
               Z336PerUltMes = (short)(context.localUtil.CToN( cgiGet( "Z336PerUltMes"), ",", "."));
               n336PerUltMes = ((0==A336PerUltMes) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_73 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_73"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "PeriodosDet";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("periodosdet:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_EMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
                  A327procesoCod = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327procesoCod", A327procesoCod);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_PROCESOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A327procesoCod, "")), context));
                  A335PerAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335PerAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A335PerAnio), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_PERANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A335PerAnio), "ZZZ9"), context));
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
                     sMode78 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode78;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound78 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_100( ) ;
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
                     if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1078( ) ;
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
            DisableAttributes1078( ) ;
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

      protected void CONFIRM_100( )
      {
         BeforeValidate1078( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1078( ) ;
            }
            else
            {
               CheckExtendedTable1078( ) ;
               CloseExtendedTableCursors1078( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode78 = Gx_mode;
            CONFIRM_1079( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode78;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode78;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_1079( )
      {
         nGXsfl_73_idx = 0;
         while ( nGXsfl_73_idx < nRC_GXsfl_73 )
         {
            ReadRow1079( ) ;
            if ( ( nRcdExists_79 != 0 ) || ( nIsMod_79 != 0 ) )
            {
               GetKey1079( ) ;
               if ( ( nRcdExists_79 == 0 ) && ( nRcdDeleted_79 == 0 ) )
               {
                  if ( RcdFound79 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate1079( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1079( ) ;
                        CloseExtendedTableCursors1079( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "DETFCHINI_" + sGXsfl_73_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtdetFchIni_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound79 != 0 )
                  {
                     if ( nRcdDeleted_79 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey1079( ) ;
                        Load1079( ) ;
                        BeforeValidate1079( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1079( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_79 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate1079( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1079( ) ;
                              CloseExtendedTableCursors1079( ) ;
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
                     if ( nRcdDeleted_79 == 0 )
                     {
                        GXCCtl = "DETFCHINI_" + sGXsfl_73_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtdetFchIni_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtdetFchIni_Internalname, context.localUtil.Format(A337detFchIni, "99/99/9999")) ;
            ChangePostValue( edtdetMes_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A338detMes), 2, 0, ",", ""))) ;
            ChangePostValue( edtdetPerEstado_Internalname, StringUtil.RTrim( A339detPerEstado)) ;
            ChangePostValue( "ZT_"+"Z337detFchIni_"+sGXsfl_73_idx, context.localUtil.DToC( Z337detFchIni, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z338detMes_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z338detMes), 2, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z339detPerEstado_"+sGXsfl_73_idx, StringUtil.RTrim( Z339detPerEstado)) ;
            ChangePostValue( "nRcdDeleted_79_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_79), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_79_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_79), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_79_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_79), 4, 0, ",", ""))) ;
            if ( nIsMod_79 != 0 )
            {
               ChangePostValue( "DETFCHINI_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetFchIni_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETMES_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetMes_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETPERESTADO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetPerEstado_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption100( )
      {
      }

      protected void ZM1078( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z336PerUltMes = T00105_A336PerUltMes[0];
            }
            else
            {
               Z336PerUltMes = A336PerUltMes;
            }
         }
         if ( GX_JID == -2 )
         {
            Z335PerAnio = A335PerAnio;
            Z336PerUltMes = A336PerUltMes;
            Z1EmpID = A1EmpID;
            Z327procesoCod = A327procesoCod;
            Z328PerFchControl = A328PerFchControl;
            Z333PerUser = A333PerUser;
            Z334PerUserName = A334PerUserName;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         /* Using cursor T00106 */
         pr_default.execute(4, new Object[] {A1EmpID, A327procesoCod});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Periodos'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A328PerFchControl = T00106_A328PerFchControl[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
         n328PerFchControl = T00106_n328PerFchControl[0];
         A333PerUser = T00106_A333PerUser[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333PerUser", A333PerUser);
         pr_default.close(4);
         /* Using cursor T00107 */
         pr_default.execute(5, new Object[] {A333PerUser});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'user Periodos'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A334PerUserName = T00107_A334PerUserName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334PerUserName", A334PerUserName);
         n334PerUserName = T00107_n334PerUserName[0];
         pr_default.close(5);
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
      }

      protected void Load1078( )
      {
         /* Using cursor T00108 */
         pr_default.execute(6, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound78 = 1;
            A328PerFchControl = T00108_A328PerFchControl[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328PerFchControl", context.localUtil.Format(A328PerFchControl, "99/99/9999"));
            n328PerFchControl = T00108_n328PerFchControl[0];
            A334PerUserName = T00108_A334PerUserName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334PerUserName", A334PerUserName);
            n334PerUserName = T00108_n334PerUserName[0];
            A336PerUltMes = T00108_A336PerUltMes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336PerUltMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A336PerUltMes), 2, 0)));
            n336PerUltMes = T00108_n336PerUltMes[0];
            A333PerUser = T00108_A333PerUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333PerUser", A333PerUser);
            ZM1078( -2) ;
         }
         pr_default.close(6);
         OnLoadActions1078( ) ;
      }

      protected void OnLoadActions1078( )
      {
      }

      protected void CheckExtendedTable1078( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1078( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1078( )
      {
         /* Using cursor T00109 */
         pr_default.execute(7, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound78 = 1;
         }
         else
         {
            RcdFound78 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00105 */
         pr_default.execute(3, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
         if ( (pr_default.getStatus(3) != 101) && ( T00105_A335PerAnio[0] == A335PerAnio ) && ( T00105_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T00105_A327procesoCod[0], A327procesoCod) == 0 ) )
         {
            ZM1078( 2) ;
            RcdFound78 = 1;
            A336PerUltMes = T00105_A336PerUltMes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336PerUltMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A336PerUltMes), 2, 0)));
            n336PerUltMes = T00105_n336PerUltMes[0];
            Z1EmpID = A1EmpID;
            Z327procesoCod = A327procesoCod;
            Z335PerAnio = A335PerAnio;
            sMode78 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1078( ) ;
            if ( AnyError == 1 )
            {
               RcdFound78 = 0;
               InitializeNonKey1078( ) ;
            }
            Gx_mode = sMode78;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound78 = 0;
            InitializeNonKey1078( ) ;
            sMode78 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode78;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey1078( ) ;
         if ( RcdFound78 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound78 = 0;
         /* Using cursor T001010 */
         pr_default.execute(8, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( T001010_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T001010_A327procesoCod[0], A327procesoCod) == 0 ) && ( T001010_A335PerAnio[0] == A335PerAnio ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( T001010_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T001010_A327procesoCod[0], A327procesoCod) == 0 ) && ( T001010_A335PerAnio[0] == A335PerAnio ) )
            {
               RcdFound78 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound78 = 0;
         /* Using cursor T001011 */
         pr_default.execute(9, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( T001011_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T001011_A327procesoCod[0], A327procesoCod) == 0 ) && ( T001011_A335PerAnio[0] == A335PerAnio ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( T001011_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T001011_A327procesoCod[0], A327procesoCod) == 0 ) && ( T001011_A335PerAnio[0] == A335PerAnio ) )
            {
               RcdFound78 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1078( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtPerUltMes_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1078( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound78 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( StringUtil.StrCmp(A327procesoCod, Z327procesoCod) != 0 ) || ( A335PerAnio != Z335PerAnio ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtPerUltMes_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update1078( ) ;
                  GX_FocusControl = edtPerUltMes_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( StringUtil.StrCmp(A327procesoCod, Z327procesoCod) != 0 ) || ( A335PerAnio != Z335PerAnio ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtPerUltMes_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1078( ) ;
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
                     GX_FocusControl = edtPerUltMes_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1078( ) ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( ( A1EmpID != Z1EmpID ) || ( StringUtil.StrCmp(A327procesoCod, Z327procesoCod) != 0 ) || ( A335PerAnio != Z335PerAnio ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPerUltMes_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1078( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00104 */
            pr_default.execute(2, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PeriodosPer"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( Z336PerUltMes != T00104_A336PerUltMes[0] ) )
            {
               if ( Z336PerUltMes != T00104_A336PerUltMes[0] )
               {
                  GXUtil.WriteLog("periodosdet:[seudo value changed for attri]"+"PerUltMes");
                  GXUtil.WriteLogRaw("Old: ",Z336PerUltMes);
                  GXUtil.WriteLogRaw("Current: ",T00104_A336PerUltMes[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PeriodosPer"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1078( )
      {
         BeforeValidate1078( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1078( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1078( 0) ;
            CheckOptimisticConcurrency1078( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1078( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1078( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001012 */
                     pr_default.execute(10, new Object[] {A335PerAnio, n336PerUltMes, A336PerUltMes, A1EmpID, A327procesoCod});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("PeriodosPer") ;
                     if ( (pr_default.getStatus(10) == 1) )
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
                           ProcessLevel1078( ) ;
                           if ( AnyError == 0 )
                           {
                              if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                              {
                                 if ( AnyError == 0 )
                                 {
                                    context.nUserReturn = 1;
                                 }
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
            else
            {
               Load1078( ) ;
            }
            EndLevel1078( ) ;
         }
         CloseExtendedTableCursors1078( ) ;
      }

      protected void Update1078( )
      {
         BeforeValidate1078( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1078( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1078( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1078( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1078( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001013 */
                     pr_default.execute(11, new Object[] {n336PerUltMes, A336PerUltMes, A1EmpID, A327procesoCod, A335PerAnio});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("PeriodosPer") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PeriodosPer"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1078( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel1078( ) ;
                           if ( AnyError == 0 )
                           {
                              if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
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
            EndLevel1078( ) ;
         }
         CloseExtendedTableCursors1078( ) ;
      }

      protected void DeferredUpdate1078( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1078( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1078( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1078( ) ;
            AfterConfirm1078( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1078( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart1079( ) ;
                  while ( RcdFound79 != 0 )
                  {
                     getByPrimaryKey1079( ) ;
                     Delete1079( ) ;
                     ScanNext1079( ) ;
                  }
                  ScanEnd1079( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001014 */
                     pr_default.execute(12, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("PeriodosPer") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
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
         sMode78 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1078( ) ;
         Gx_mode = sMode78;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1078( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel1079( )
      {
         nGXsfl_73_idx = 0;
         while ( nGXsfl_73_idx < nRC_GXsfl_73 )
         {
            ReadRow1079( ) ;
            if ( ( nRcdExists_79 != 0 ) || ( nIsMod_79 != 0 ) )
            {
               standaloneNotModal1079( ) ;
               GetKey1079( ) ;
               if ( ( nRcdExists_79 == 0 ) && ( nRcdDeleted_79 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert1079( ) ;
               }
               else
               {
                  if ( RcdFound79 != 0 )
                  {
                     if ( ( nRcdDeleted_79 != 0 ) && ( nRcdExists_79 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete1079( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_79 != 0 ) && ( nRcdExists_79 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update1079( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_79 == 0 )
                     {
                        GXCCtl = "DETFCHINI_" + sGXsfl_73_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtdetFchIni_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtdetFchIni_Internalname, context.localUtil.Format(A337detFchIni, "99/99/9999")) ;
            ChangePostValue( edtdetMes_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A338detMes), 2, 0, ",", ""))) ;
            ChangePostValue( edtdetPerEstado_Internalname, StringUtil.RTrim( A339detPerEstado)) ;
            ChangePostValue( "ZT_"+"Z337detFchIni_"+sGXsfl_73_idx, context.localUtil.DToC( Z337detFchIni, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z338detMes_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z338detMes), 2, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z339detPerEstado_"+sGXsfl_73_idx, StringUtil.RTrim( Z339detPerEstado)) ;
            ChangePostValue( "nRcdDeleted_79_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_79), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_79_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_79), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_79_"+sGXsfl_73_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_79), 4, 0, ",", ""))) ;
            if ( nIsMod_79 != 0 )
            {
               ChangePostValue( "DETFCHINI_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetFchIni_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETMES_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetMes_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETPERESTADO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetPerEstado_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1079( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_79 = 0;
         nIsMod_79 = 0;
         nRcdDeleted_79 = 0;
      }

      protected void ProcessLevel1078( )
      {
         /* Save parent mode. */
         sMode78 = Gx_mode;
         ProcessNestedLevel1079( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode78;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel1078( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(2);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1078( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("periodosdet",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues100( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("periodosdet",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1078( )
      {
         /* Scan By routine */
         /* Using cursor T001015 */
         pr_default.execute(13, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
         RcdFound78 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound78 = 1;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1078( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound78 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound78 = 1;
         }
      }

      protected void ScanEnd1078( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm1078( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1078( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1078( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1078( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1078( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1078( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1078( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtprocesoCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprocesoCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprocesoCod_Enabled), 5, 0)), true);
         edtPerFchControl_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerFchControl_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerFchControl_Enabled), 5, 0)), true);
         edtPerUser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerUser_Enabled), 5, 0)), true);
         edtPerUserName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerUserName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerUserName_Enabled), 5, 0)), true);
         edtPerAnio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerAnio_Enabled), 5, 0)), true);
         edtPerUltMes_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPerUltMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPerUltMes_Enabled), 5, 0)), true);
      }

      protected void ZM1079( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z338detMes = T00103_A338detMes[0];
               Z339detPerEstado = T00103_A339detPerEstado[0];
            }
            else
            {
               Z338detMes = A338detMes;
               Z339detPerEstado = A339detPerEstado;
            }
         }
         if ( GX_JID == -5 )
         {
            Z1EmpID = A1EmpID;
            Z327procesoCod = A327procesoCod;
            Z335PerAnio = A335PerAnio;
            Z337detFchIni = A337detFchIni;
            Z338detMes = A338detMes;
            Z339detPerEstado = A339detPerEstado;
         }
      }

      protected void standaloneNotModal1079( )
      {
      }

      protected void standaloneModal1079( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtdetFchIni_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetFchIni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetFchIni_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         }
         else
         {
            edtdetFchIni_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetFchIni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetFchIni_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         }
      }

      protected void Load1079( )
      {
         /* Using cursor T001016 */
         pr_default.execute(14, new Object[] {A1EmpID, A327procesoCod, A335PerAnio, A337detFchIni});
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound79 = 1;
            A338detMes = T001016_A338detMes[0];
            n338detMes = T001016_n338detMes[0];
            A339detPerEstado = T001016_A339detPerEstado[0];
            n339detPerEstado = T001016_n339detPerEstado[0];
            ZM1079( -5) ;
         }
         pr_default.close(14);
         OnLoadActions1079( ) ;
      }

      protected void OnLoadActions1079( )
      {
      }

      protected void CheckExtendedTable1079( )
      {
         Gx_BScreen = 1;
         standaloneModal1079( ) ;
         if ( ! ( (DateTime.MinValue==A337detFchIni) || ( A337detFchIni >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXCCtl = "DETFCHINI_" + sGXsfl_73_idx;
            GX_msglist.addItem("Campo det Fch Ini fuera de rango", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetFchIni_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1079( )
      {
      }

      protected void enableDisable1079( )
      {
      }

      protected void GetKey1079( )
      {
         /* Using cursor T001017 */
         pr_default.execute(15, new Object[] {A1EmpID, A327procesoCod, A335PerAnio, A337detFchIni});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound79 = 1;
         }
         else
         {
            RcdFound79 = 0;
         }
         pr_default.close(15);
      }

      protected void getByPrimaryKey1079( )
      {
         /* Using cursor T00103 */
         pr_default.execute(1, new Object[] {A1EmpID, A327procesoCod, A335PerAnio, A337detFchIni});
         if ( (pr_default.getStatus(1) != 101) && ( T00103_A1EmpID[0] == A1EmpID ) && ( StringUtil.StrCmp(T00103_A327procesoCod[0], A327procesoCod) == 0 ) && ( T00103_A335PerAnio[0] == A335PerAnio ) )
         {
            ZM1079( 5) ;
            RcdFound79 = 1;
            InitializeNonKey1079( ) ;
            A337detFchIni = T00103_A337detFchIni[0];
            A338detMes = T00103_A338detMes[0];
            n338detMes = T00103_n338detMes[0];
            A339detPerEstado = T00103_A339detPerEstado[0];
            n339detPerEstado = T00103_n339detPerEstado[0];
            Z1EmpID = A1EmpID;
            Z327procesoCod = A327procesoCod;
            Z335PerAnio = A335PerAnio;
            Z337detFchIni = A337detFchIni;
            sMode79 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1079( ) ;
            Gx_mode = sMode79;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound79 = 0;
            InitializeNonKey1079( ) ;
            sMode79 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal1079( ) ;
            Gx_mode = sMode79;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes1079( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency1079( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00102 */
            pr_default.execute(0, new Object[] {A1EmpID, A327procesoCod, A335PerAnio, A337detFchIni});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PeriodosDetdetFch"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z338detMes != T00102_A338detMes[0] ) || ( StringUtil.StrCmp(Z339detPerEstado, T00102_A339detPerEstado[0]) != 0 ) )
            {
               if ( Z338detMes != T00102_A338detMes[0] )
               {
                  GXUtil.WriteLog("periodosdet:[seudo value changed for attri]"+"detMes");
                  GXUtil.WriteLogRaw("Old: ",Z338detMes);
                  GXUtil.WriteLogRaw("Current: ",T00102_A338detMes[0]);
               }
               if ( StringUtil.StrCmp(Z339detPerEstado, T00102_A339detPerEstado[0]) != 0 )
               {
                  GXUtil.WriteLog("periodosdet:[seudo value changed for attri]"+"detPerEstado");
                  GXUtil.WriteLogRaw("Old: ",Z339detPerEstado);
                  GXUtil.WriteLogRaw("Current: ",T00102_A339detPerEstado[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PeriodosDetdetFch"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1079( )
      {
         BeforeValidate1079( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1079( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1079( 0) ;
            CheckOptimisticConcurrency1079( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1079( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1079( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001018 */
                     pr_default.execute(16, new Object[] {A1EmpID, A327procesoCod, A335PerAnio, A337detFchIni, n338detMes, A338detMes, n339detPerEstado, A339detPerEstado});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("PeriodosDetdetFch") ;
                     if ( (pr_default.getStatus(16) == 1) )
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
               Load1079( ) ;
            }
            EndLevel1079( ) ;
         }
         CloseExtendedTableCursors1079( ) ;
      }

      protected void Update1079( )
      {
         BeforeValidate1079( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1079( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1079( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1079( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1079( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001019 */
                     pr_default.execute(17, new Object[] {n338detMes, A338detMes, n339detPerEstado, A339detPerEstado, A1EmpID, A327procesoCod, A335PerAnio, A337detFchIni});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("PeriodosDetdetFch") ;
                     if ( (pr_default.getStatus(17) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PeriodosDetdetFch"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1079( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1079( ) ;
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
            EndLevel1079( ) ;
         }
         CloseExtendedTableCursors1079( ) ;
      }

      protected void DeferredUpdate1079( )
      {
      }

      protected void Delete1079( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate1079( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1079( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1079( ) ;
            AfterConfirm1079( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1079( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001020 */
                  pr_default.execute(18, new Object[] {A1EmpID, A327procesoCod, A335PerAnio, A337detFchIni});
                  pr_default.close(18);
                  dsDefault.SmartCacheProvider.SetUpdated("PeriodosDetdetFch") ;
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
         sMode79 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1079( ) ;
         Gx_mode = sMode79;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1079( )
      {
         standaloneModal1079( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1079( )
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

      public void ScanStart1079( )
      {
         /* Scan By routine */
         /* Using cursor T001021 */
         pr_default.execute(19, new Object[] {A1EmpID, A327procesoCod, A335PerAnio});
         RcdFound79 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound79 = 1;
            A337detFchIni = T001021_A337detFchIni[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1079( )
      {
         /* Scan next routine */
         pr_default.readNext(19);
         RcdFound79 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound79 = 1;
            A337detFchIni = T001021_A337detFchIni[0];
         }
      }

      protected void ScanEnd1079( )
      {
         pr_default.close(19);
      }

      protected void AfterConfirm1079( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1079( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1079( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1079( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1079( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1079( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1079( )
      {
         edtdetFchIni_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetFchIni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetFchIni_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtdetMes_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetMes_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
         edtdetPerEstado_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetPerEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetPerEstado_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
      }

      protected void send_integrity_lvl_hashes1079( )
      {
      }

      protected void send_integrity_lvl_hashes1078( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_EMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PROCESOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A327procesoCod, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PERANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A335PerAnio), "ZZZ9"), context));
      }

      protected void SubsflControlProps_7379( )
      {
         edtdetFchIni_Internalname = "DETFCHINI_"+sGXsfl_73_idx;
         edtdetMes_Internalname = "DETMES_"+sGXsfl_73_idx;
         edtdetPerEstado_Internalname = "DETPERESTADO_"+sGXsfl_73_idx;
      }

      protected void SubsflControlProps_fel_7379( )
      {
         edtdetFchIni_Internalname = "DETFCHINI_"+sGXsfl_73_fel_idx;
         edtdetMes_Internalname = "DETMES_"+sGXsfl_73_fel_idx;
         edtdetPerEstado_Internalname = "DETPERESTADO_"+sGXsfl_73_fel_idx;
      }

      protected void AddRow1079( )
      {
         nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
         sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
         SubsflControlProps_7379( ) ;
         SendRow1079( ) ;
      }

      protected void SendRow1079( )
      {
         Gridperiodosdet_detfchRow = GXWebRow.GetNew(context);
         if ( subGridperiodosdet_detfch_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridperiodosdet_detfch_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridperiodosdet_detfch_Class, "") != 0 )
            {
               subGridperiodosdet_detfch_Linesclass = subGridperiodosdet_detfch_Class+"Odd";
            }
         }
         else if ( subGridperiodosdet_detfch_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridperiodosdet_detfch_Backstyle = 0;
            subGridperiodosdet_detfch_Backcolor = subGridperiodosdet_detfch_Allbackcolor;
            if ( StringUtil.StrCmp(subGridperiodosdet_detfch_Class, "") != 0 )
            {
               subGridperiodosdet_detfch_Linesclass = subGridperiodosdet_detfch_Class+"Uniform";
            }
         }
         else if ( subGridperiodosdet_detfch_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridperiodosdet_detfch_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridperiodosdet_detfch_Class, "") != 0 )
            {
               subGridperiodosdet_detfch_Linesclass = subGridperiodosdet_detfch_Class+"Odd";
            }
            subGridperiodosdet_detfch_Backcolor = (int)(0x0);
         }
         else if ( subGridperiodosdet_detfch_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridperiodosdet_detfch_Backstyle = 1;
            if ( ((int)(((nGXsfl_73_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridperiodosdet_detfch_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridperiodosdet_detfch_Class, "") != 0 )
               {
                  subGridperiodosdet_detfch_Linesclass = subGridperiodosdet_detfch_Class+"Odd";
               }
            }
            else
            {
               subGridperiodosdet_detfch_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridperiodosdet_detfch_Class, "") != 0 )
               {
                  subGridperiodosdet_detfch_Linesclass = subGridperiodosdet_detfch_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_79_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_73_idx + "',73)\"";
         ROClassString = "Attribute";
         Gridperiodosdet_detfchRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetFchIni_Internalname,context.localUtil.Format(A337detFchIni, "99/99/9999"),context.localUtil.Format( A337detFchIni, "99/99/9999"),TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetFchIni_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetFchIni_Enabled,(short)1,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_79_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_73_idx + "',73)\"";
         ROClassString = "Attribute";
         Gridperiodosdet_detfchRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetMes_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A338detMes), 2, 0, ",", "")),((edtdetMes_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A338detMes), "Z9")) : context.localUtil.Format( (decimal)(A338detMes), "Z9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetMes_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetMes_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_79_" + sGXsfl_73_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_73_idx + "',73)\"";
         ROClassString = "Attribute";
         Gridperiodosdet_detfchRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetPerEstado_Internalname,StringUtil.RTrim( A339detPerEstado),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetPerEstado_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetPerEstado_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)73,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridperiodosdet_detfchRow);
         send_integrity_lvl_hashes1079( ) ;
         GXCCtl = "Z337detFchIni_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z337detFchIni, 0, "/"));
         GXCCtl = "Z338detMes_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z338detMes), 2, 0, ",", "")));
         GXCCtl = "Z339detPerEstado_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z339detPerEstado));
         GXCCtl = "nRcdDeleted_79_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_79), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_79_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_79), 4, 0, ",", "")));
         GXCCtl = "nIsMod_79_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_79), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_73_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "DETFCHINI_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetFchIni_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETMES_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetMes_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETPERESTADO_"+sGXsfl_73_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetPerEstado_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridperiodosdet_detfchContainer.AddRow(Gridperiodosdet_detfchRow);
      }

      protected void ReadRow1079( )
      {
         nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
         sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
         SubsflControlProps_7379( ) ;
         edtdetFchIni_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETFCHINI_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtdetMes_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETMES_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         edtdetPerEstado_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETPERESTADO_"+sGXsfl_73_idx+"Enabled"), ",", "."));
         if ( context.localUtil.VCDate( cgiGet( edtdetFchIni_Internalname), 2) == 0 )
         {
            GXCCtl = "DETFCHINI_" + sGXsfl_73_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"det Fch Ini"}), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetFchIni_Internalname;
            wbErr = true;
            A337detFchIni = DateTime.MinValue;
         }
         else
         {
            A337detFchIni = context.localUtil.CToD( cgiGet( edtdetFchIni_Internalname), 2);
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtdetMes_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetMes_Internalname), ",", ".") > Convert.ToDecimal( 99 )) ) )
         {
            GXCCtl = "DETMES_" + sGXsfl_73_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetMes_Internalname;
            wbErr = true;
            A338detMes = 0;
            n338detMes = false;
         }
         else
         {
            A338detMes = (short)(context.localUtil.CToN( cgiGet( edtdetMes_Internalname), ",", "."));
            n338detMes = false;
         }
         n338detMes = ((0==A338detMes) ? true : false);
         A339detPerEstado = cgiGet( edtdetPerEstado_Internalname);
         n339detPerEstado = false;
         n339detPerEstado = (String.IsNullOrEmpty(StringUtil.RTrim( A339detPerEstado)) ? true : false);
         GXCCtl = "Z337detFchIni_" + sGXsfl_73_idx;
         Z337detFchIni = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         GXCCtl = "Z338detMes_" + sGXsfl_73_idx;
         Z338detMes = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n338detMes = ((0==A338detMes) ? true : false);
         GXCCtl = "Z339detPerEstado_" + sGXsfl_73_idx;
         Z339detPerEstado = cgiGet( GXCCtl);
         n339detPerEstado = (String.IsNullOrEmpty(StringUtil.RTrim( A339detPerEstado)) ? true : false);
         GXCCtl = "nRcdDeleted_79_" + sGXsfl_73_idx;
         nRcdDeleted_79 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_79_" + sGXsfl_73_idx;
         nRcdExists_79 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_79_" + sGXsfl_73_idx;
         nIsMod_79 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtdetFchIni_Enabled = edtdetFchIni_Enabled;
      }

      protected void ConfirmValues100( )
      {
         nGXsfl_73_idx = 0;
         sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
         SubsflControlProps_7379( ) ;
         while ( nGXsfl_73_idx < nRC_GXsfl_73 )
         {
            nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
            sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
            SubsflControlProps_7379( ) ;
            ChangePostValue( "Z337detFchIni_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z337detFchIni_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z337detFchIni_"+sGXsfl_73_idx) ;
            ChangePostValue( "Z338detMes_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z338detMes_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z338detMes_"+sGXsfl_73_idx) ;
            ChangePostValue( "Z339detPerEstado_"+sGXsfl_73_idx, cgiGet( "ZT_"+"Z339detPerEstado_"+sGXsfl_73_idx)) ;
            DeletePostValue( "ZT_"+"Z339detPerEstado_"+sGXsfl_73_idx) ;
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
         context.SendWebValue( "Periodos Det") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2023111043174", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 126726), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("periodosdet.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +A1EmpID) + "," + UrlEncode(StringUtil.RTrim(A327procesoCod)) + "," + UrlEncode("" +A335PerAnio)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_EMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PROCESOCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A327procesoCod, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PERANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A335PerAnio), "ZZZ9"), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "PeriodosDet";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("periodosdet:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z327procesoCod", Z327procesoCod);
         GxWebStd.gx_hidden_field( context, "Z335PerAnio", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z335PerAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z336PerUltMes", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z336PerUltMes), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_73", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_73_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm1078( )
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
         return "PeriodosDet" ;
      }

      public override String GetPgmdesc( )
      {
         return "Periodos Det" ;
      }

      protected void InitializeNonKey1078( )
      {
         A336PerUltMes = 0;
         n336PerUltMes = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336PerUltMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A336PerUltMes), 2, 0)));
         n336PerUltMes = ((0==A336PerUltMes) ? true : false);
         Z336PerUltMes = 0;
      }

      protected void InitAll1078( )
      {
         InitializeNonKey1078( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey1079( )
      {
         A338detMes = 0;
         n338detMes = false;
         A339detPerEstado = "";
         n339detPerEstado = false;
         Z338detMes = 0;
         Z339detPerEstado = "";
      }

      protected void InitAll1079( )
      {
         A337detFchIni = DateTime.MinValue;
         InitializeNonKey1079( ) ;
      }

      protected void StandaloneModalInsert1079( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2023111043183", true);
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
         context.AddJavascriptSource("periodosdet.js", "?2023111043183", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties79( )
      {
         edtdetFchIni_Enabled = defedtdetFchIni_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetFchIni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetFchIni_Enabled), 5, 0)), !bGXsfl_73_Refreshing);
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
         edtprocesoCod_Internalname = "PROCESOCOD";
         edtPerFchControl_Internalname = "PERFCHCONTROL";
         edtPerUser_Internalname = "PERUSER";
         edtPerUserName_Internalname = "PERUSERNAME";
         edtPerAnio_Internalname = "PERANIO";
         edtPerUltMes_Internalname = "PERULTMES";
         lblTitledetfch_Internalname = "TITLEDETFCH";
         edtdetFchIni_Internalname = "DETFCHINI";
         edtdetMes_Internalname = "DETMES";
         edtdetPerEstado_Internalname = "DETPERESTADO";
         divDetfchtable_Internalname = "DETFCHTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridperiodosdet_detfch_Internalname = "GRIDPERIODOSDET_DETFCH";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtdetPerEstado_Jsonclick = "";
         edtdetMes_Jsonclick = "";
         edtdetFchIni_Jsonclick = "";
         subGridperiodosdet_detfch_Class = "Grid";
         subGridperiodosdet_detfch_Backcolorstyle = 0;
         subGridperiodosdet_detfch_Allowcollapsing = 0;
         subGridperiodosdet_detfch_Allowselection = 0;
         edtdetPerEstado_Enabled = 1;
         edtdetMes_Enabled = 1;
         edtdetFchIni_Enabled = 1;
         subGridperiodosdet_detfch_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtPerUltMes_Jsonclick = "";
         edtPerUltMes_Enabled = 1;
         edtPerAnio_Jsonclick = "";
         edtPerAnio_Enabled = 0;
         edtPerUserName_Jsonclick = "";
         edtPerUserName_Enabled = 0;
         edtPerUser_Jsonclick = "";
         edtPerUser_Enabled = 0;
         edtPerFchControl_Jsonclick = "";
         edtPerFchControl_Enabled = 0;
         edtprocesoCod_Jsonclick = "";
         edtprocesoCod_Enabled = 0;
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 0;
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

      protected void gxnrGridperiodosdet_detfch_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_7379( ) ;
         while ( nGXsfl_73_idx <= nRC_GXsfl_73 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1079( ) ;
            standaloneModal1079( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow1079( ) ;
            nGXsfl_73_idx = (short)(nGXsfl_73_idx+1);
            sGXsfl_73_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_73_idx), 4, 0)), 4, "0");
            SubsflControlProps_7379( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridperiodosdet_detfchContainer));
         /* End function gxnrGridperiodosdet_detfch_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A327procesoCod',fld:'PROCESOCOD',pic:'',hsh:true},{av:'A335PerAnio',fld:'PERANIO',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9',hsh:true},{av:'A327procesoCod',fld:'PROCESOCOD',pic:'',hsh:true},{av:'A335PerAnio',fld:'PERANIO',pic:'ZZZ9',hsh:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
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
         pr_default.close(3);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOA327procesoCod = "";
         Z327procesoCod = "";
         Z337detFchIni = DateTime.MinValue;
         Z339detPerEstado = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
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
         A328PerFchControl = DateTime.MinValue;
         A333PerUser = "";
         A334PerUserName = "";
         lblTitledetfch_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridperiodosdet_detfchContainer = new GXWebGrid( context);
         Gridperiodosdet_detfchColumn = new GXWebColumn();
         A337detFchIni = DateTime.MinValue;
         A339detPerEstado = "";
         sMode79 = "";
         sStyleString = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode78 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         Z328PerFchControl = DateTime.MinValue;
         Z333PerUser = "";
         Z334PerUserName = "";
         T00106_A328PerFchControl = new DateTime[] {DateTime.MinValue} ;
         T00106_n328PerFchControl = new bool[] {false} ;
         T00106_A333PerUser = new String[] {""} ;
         T00107_A334PerUserName = new String[] {""} ;
         T00107_n334PerUserName = new bool[] {false} ;
         T00108_A335PerAnio = new short[1] ;
         T00108_A328PerFchControl = new DateTime[] {DateTime.MinValue} ;
         T00108_n328PerFchControl = new bool[] {false} ;
         T00108_A334PerUserName = new String[] {""} ;
         T00108_n334PerUserName = new bool[] {false} ;
         T00108_A336PerUltMes = new short[1] ;
         T00108_n336PerUltMes = new bool[] {false} ;
         T00108_A1EmpID = new short[1] ;
         T00108_A327procesoCod = new String[] {""} ;
         T00108_A333PerUser = new String[] {""} ;
         T00109_A1EmpID = new short[1] ;
         T00109_A327procesoCod = new String[] {""} ;
         T00109_A335PerAnio = new short[1] ;
         T00105_A335PerAnio = new short[1] ;
         T00105_A336PerUltMes = new short[1] ;
         T00105_n336PerUltMes = new bool[] {false} ;
         T00105_A1EmpID = new short[1] ;
         T00105_A327procesoCod = new String[] {""} ;
         T001010_A1EmpID = new short[1] ;
         T001010_A327procesoCod = new String[] {""} ;
         T001010_A335PerAnio = new short[1] ;
         T001011_A1EmpID = new short[1] ;
         T001011_A327procesoCod = new String[] {""} ;
         T001011_A335PerAnio = new short[1] ;
         T00104_A335PerAnio = new short[1] ;
         T00104_A336PerUltMes = new short[1] ;
         T00104_n336PerUltMes = new bool[] {false} ;
         T00104_A1EmpID = new short[1] ;
         T00104_A327procesoCod = new String[] {""} ;
         T001015_A1EmpID = new short[1] ;
         T001015_A327procesoCod = new String[] {""} ;
         T001015_A335PerAnio = new short[1] ;
         T001016_A1EmpID = new short[1] ;
         T001016_A327procesoCod = new String[] {""} ;
         T001016_A335PerAnio = new short[1] ;
         T001016_A337detFchIni = new DateTime[] {DateTime.MinValue} ;
         T001016_A338detMes = new short[1] ;
         T001016_n338detMes = new bool[] {false} ;
         T001016_A339detPerEstado = new String[] {""} ;
         T001016_n339detPerEstado = new bool[] {false} ;
         T001017_A1EmpID = new short[1] ;
         T001017_A327procesoCod = new String[] {""} ;
         T001017_A335PerAnio = new short[1] ;
         T001017_A337detFchIni = new DateTime[] {DateTime.MinValue} ;
         T00103_A1EmpID = new short[1] ;
         T00103_A327procesoCod = new String[] {""} ;
         T00103_A335PerAnio = new short[1] ;
         T00103_A337detFchIni = new DateTime[] {DateTime.MinValue} ;
         T00103_A338detMes = new short[1] ;
         T00103_n338detMes = new bool[] {false} ;
         T00103_A339detPerEstado = new String[] {""} ;
         T00103_n339detPerEstado = new bool[] {false} ;
         T00102_A1EmpID = new short[1] ;
         T00102_A327procesoCod = new String[] {""} ;
         T00102_A335PerAnio = new short[1] ;
         T00102_A337detFchIni = new DateTime[] {DateTime.MinValue} ;
         T00102_A338detMes = new short[1] ;
         T00102_n338detMes = new bool[] {false} ;
         T00102_A339detPerEstado = new String[] {""} ;
         T00102_n339detPerEstado = new bool[] {false} ;
         T001021_A1EmpID = new short[1] ;
         T001021_A327procesoCod = new String[] {""} ;
         T001021_A335PerAnio = new short[1] ;
         T001021_A337detFchIni = new DateTime[] {DateTime.MinValue} ;
         Gridperiodosdet_detfchRow = new GXWebRow();
         subGridperiodosdet_detfch_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.periodosdet__default(),
            new Object[][] {
                new Object[] {
               T00102_A1EmpID, T00102_A327procesoCod, T00102_A335PerAnio, T00102_A337detFchIni, T00102_A338detMes, T00102_n338detMes, T00102_A339detPerEstado, T00102_n339detPerEstado
               }
               , new Object[] {
               T00103_A1EmpID, T00103_A327procesoCod, T00103_A335PerAnio, T00103_A337detFchIni, T00103_A338detMes, T00103_n338detMes, T00103_A339detPerEstado, T00103_n339detPerEstado
               }
               , new Object[] {
               T00104_A335PerAnio, T00104_A336PerUltMes, T00104_n336PerUltMes, T00104_A1EmpID, T00104_A327procesoCod
               }
               , new Object[] {
               T00105_A335PerAnio, T00105_A336PerUltMes, T00105_n336PerUltMes, T00105_A1EmpID, T00105_A327procesoCod
               }
               , new Object[] {
               T00106_A328PerFchControl, T00106_n328PerFchControl, T00106_A333PerUser
               }
               , new Object[] {
               T00107_A334PerUserName, T00107_n334PerUserName
               }
               , new Object[] {
               T00108_A335PerAnio, T00108_A328PerFchControl, T00108_n328PerFchControl, T00108_A334PerUserName, T00108_n334PerUserName, T00108_A336PerUltMes, T00108_n336PerUltMes, T00108_A1EmpID, T00108_A327procesoCod, T00108_A333PerUser
               }
               , new Object[] {
               T00109_A1EmpID, T00109_A327procesoCod, T00109_A335PerAnio
               }
               , new Object[] {
               T001010_A1EmpID, T001010_A327procesoCod, T001010_A335PerAnio
               }
               , new Object[] {
               T001011_A1EmpID, T001011_A327procesoCod, T001011_A335PerAnio
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001015_A1EmpID, T001015_A327procesoCod, T001015_A335PerAnio
               }
               , new Object[] {
               T001016_A1EmpID, T001016_A327procesoCod, T001016_A335PerAnio, T001016_A337detFchIni, T001016_A338detMes, T001016_n338detMes, T001016_A339detPerEstado, T001016_n339detPerEstado
               }
               , new Object[] {
               T001017_A1EmpID, T001017_A327procesoCod, T001017_A335PerAnio, T001017_A337detFchIni
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001021_A1EmpID, T001021_A327procesoCod, T001021_A335PerAnio, T001021_A337detFchIni
               }
            }
         );
         Z335PerAnio = 0;
         A335PerAnio = 0;
         Z327procesoCod = "";
         A327procesoCod = "";
         Z1EmpID = 0;
         A1EmpID = 0;
      }

      private short wcpOA1EmpID ;
      private short wcpOA335PerAnio ;
      private short Z1EmpID ;
      private short Z335PerAnio ;
      private short Z336PerUltMes ;
      private short nRC_GXsfl_73 ;
      private short nGXsfl_73_idx=1 ;
      private short Z338detMes ;
      private short nRcdDeleted_79 ;
      private short nRcdExists_79 ;
      private short nIsMod_79 ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A335PerAnio ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A336PerUltMes ;
      private short subGridperiodosdet_detfch_Backcolorstyle ;
      private short A338detMes ;
      private short subGridperiodosdet_detfch_Allowselection ;
      private short subGridperiodosdet_detfch_Allowhovering ;
      private short subGridperiodosdet_detfch_Allowcollapsing ;
      private short subGridperiodosdet_detfch_Collapsed ;
      private short nBlankRcdCount79 ;
      private short RcdFound79 ;
      private short nBlankRcdUsr79 ;
      private short RcdFound78 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short subGridperiodosdet_detfch_Backstyle ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEmpID_Enabled ;
      private int edtprocesoCod_Enabled ;
      private int edtPerFchControl_Enabled ;
      private int edtPerUser_Enabled ;
      private int edtPerUserName_Enabled ;
      private int edtPerAnio_Enabled ;
      private int edtPerUltMes_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtdetFchIni_Enabled ;
      private int edtdetMes_Enabled ;
      private int edtdetPerEstado_Enabled ;
      private int subGridperiodosdet_detfch_Selectedindex ;
      private int subGridperiodosdet_detfch_Selectioncolor ;
      private int subGridperiodosdet_detfch_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridperiodosdet_detfch_Backcolor ;
      private int subGridperiodosdet_detfch_Allbackcolor ;
      private int defedtdetFchIni_Enabled ;
      private int idxLst ;
      private long GRIDPERIODOSDET_DETFCH_nFirstRecordOnPage ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z339detPerEstado ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_73_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPerUltMes_Internalname ;
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
      private String edtEmpID_Internalname ;
      private String edtEmpID_Jsonclick ;
      private String edtprocesoCod_Internalname ;
      private String edtprocesoCod_Jsonclick ;
      private String edtPerFchControl_Internalname ;
      private String edtPerFchControl_Jsonclick ;
      private String edtPerUser_Internalname ;
      private String A333PerUser ;
      private String edtPerUser_Jsonclick ;
      private String edtPerUserName_Internalname ;
      private String edtPerUserName_Jsonclick ;
      private String edtPerAnio_Internalname ;
      private String edtPerAnio_Jsonclick ;
      private String edtPerUltMes_Jsonclick ;
      private String divDetfchtable_Internalname ;
      private String lblTitledetfch_Internalname ;
      private String lblTitledetfch_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridperiodosdet_detfch_Header ;
      private String A339detPerEstado ;
      private String sMode79 ;
      private String edtdetFchIni_Internalname ;
      private String edtdetMes_Internalname ;
      private String edtdetPerEstado_Internalname ;
      private String sStyleString ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode78 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z333PerUser ;
      private String sGXsfl_73_fel_idx="0001" ;
      private String subGridperiodosdet_detfch_Class ;
      private String subGridperiodosdet_detfch_Linesclass ;
      private String ROClassString ;
      private String edtdetFchIni_Jsonclick ;
      private String edtdetMes_Jsonclick ;
      private String edtdetPerEstado_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridperiodosdet_detfch_Internalname ;
      private DateTime Z337detFchIni ;
      private DateTime A328PerFchControl ;
      private DateTime A337detFchIni ;
      private DateTime Z328PerFchControl ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_73_Refreshing=false ;
      private bool n328PerFchControl ;
      private bool n334PerUserName ;
      private bool n336PerUltMes ;
      private bool n338detMes ;
      private bool n339detPerEstado ;
      private String wcpOA327procesoCod ;
      private String Z327procesoCod ;
      private String A327procesoCod ;
      private String A334PerUserName ;
      private String Z334PerUserName ;
      private GXWebGrid Gridperiodosdet_detfchContainer ;
      private GXWebRow Gridperiodosdet_detfchRow ;
      private GXWebColumn Gridperiodosdet_detfchColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] T00106_A328PerFchControl ;
      private bool[] T00106_n328PerFchControl ;
      private String[] T00106_A333PerUser ;
      private String[] T00107_A334PerUserName ;
      private bool[] T00107_n334PerUserName ;
      private short[] T00108_A335PerAnio ;
      private DateTime[] T00108_A328PerFchControl ;
      private bool[] T00108_n328PerFchControl ;
      private String[] T00108_A334PerUserName ;
      private bool[] T00108_n334PerUserName ;
      private short[] T00108_A336PerUltMes ;
      private bool[] T00108_n336PerUltMes ;
      private short[] T00108_A1EmpID ;
      private String[] T00108_A327procesoCod ;
      private String[] T00108_A333PerUser ;
      private short[] T00109_A1EmpID ;
      private String[] T00109_A327procesoCod ;
      private short[] T00109_A335PerAnio ;
      private short[] T00105_A335PerAnio ;
      private short[] T00105_A336PerUltMes ;
      private bool[] T00105_n336PerUltMes ;
      private short[] T00105_A1EmpID ;
      private String[] T00105_A327procesoCod ;
      private short[] T001010_A1EmpID ;
      private String[] T001010_A327procesoCod ;
      private short[] T001010_A335PerAnio ;
      private short[] T001011_A1EmpID ;
      private String[] T001011_A327procesoCod ;
      private short[] T001011_A335PerAnio ;
      private short[] T00104_A335PerAnio ;
      private short[] T00104_A336PerUltMes ;
      private bool[] T00104_n336PerUltMes ;
      private short[] T00104_A1EmpID ;
      private String[] T00104_A327procesoCod ;
      private short[] T001015_A1EmpID ;
      private String[] T001015_A327procesoCod ;
      private short[] T001015_A335PerAnio ;
      private short[] T001016_A1EmpID ;
      private String[] T001016_A327procesoCod ;
      private short[] T001016_A335PerAnio ;
      private DateTime[] T001016_A337detFchIni ;
      private short[] T001016_A338detMes ;
      private bool[] T001016_n338detMes ;
      private String[] T001016_A339detPerEstado ;
      private bool[] T001016_n339detPerEstado ;
      private short[] T001017_A1EmpID ;
      private String[] T001017_A327procesoCod ;
      private short[] T001017_A335PerAnio ;
      private DateTime[] T001017_A337detFchIni ;
      private short[] T00103_A1EmpID ;
      private String[] T00103_A327procesoCod ;
      private short[] T00103_A335PerAnio ;
      private DateTime[] T00103_A337detFchIni ;
      private short[] T00103_A338detMes ;
      private bool[] T00103_n338detMes ;
      private String[] T00103_A339detPerEstado ;
      private bool[] T00103_n339detPerEstado ;
      private short[] T00102_A1EmpID ;
      private String[] T00102_A327procesoCod ;
      private short[] T00102_A335PerAnio ;
      private DateTime[] T00102_A337detFchIni ;
      private short[] T00102_A338detMes ;
      private bool[] T00102_n338detMes ;
      private String[] T00102_A339detPerEstado ;
      private bool[] T00102_n339detPerEstado ;
      private short[] T001021_A1EmpID ;
      private String[] T001021_A327procesoCod ;
      private short[] T001021_A335PerAnio ;
      private DateTime[] T001021_A337detFchIni ;
   }

   public class periodosdet__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00106 ;
          prmT00106 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00107 ;
          prmT00107 = new Object[] {
          new Object[] {"@PerUser",SqlDbType.Char,15,0}
          } ;
          Object[] prmT00108 ;
          prmT00108 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00109 ;
          prmT00109 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00105 ;
          prmT00105 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001010 ;
          prmT001010 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001011 ;
          prmT001011 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00104 ;
          prmT00104 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001012 ;
          prmT001012 = new Object[] {
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PerUltMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001013 ;
          prmT001013 = new Object[] {
          new Object[] {"@PerUltMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001014 ;
          prmT001014 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001015 ;
          prmT001015 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001016 ;
          prmT001016 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detFchIni",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT001017 ;
          prmT001017 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detFchIni",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT00103 ;
          prmT00103 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detFchIni",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT00102 ;
          prmT00102 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detFchIni",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT001018 ;
          prmT001018 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detFchIni",SqlDbType.DateTime,8,0} ,
          new Object[] {"@detMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detPerEstado",SqlDbType.Char,1,0}
          } ;
          Object[] prmT001019 ;
          prmT001019 = new Object[] {
          new Object[] {"@detMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detPerEstado",SqlDbType.Char,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detFchIni",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT001020 ;
          prmT001020 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detFchIni",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT001021 ;
          prmT001021 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PerAnio",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00102", "SELECT [EmpID], [procesoCod], [PerAnio], [detFchIni], [detMes], [detPerEstado] FROM [PeriodosDetdetFch] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio AND [detFchIni] = @detFchIni ",true, GxErrorMask.GX_NOMASK, false, this,prmT00102,1,0,true,false )
             ,new CursorDef("T00103", "SELECT [EmpID], [procesoCod], [PerAnio], [detFchIni], [detMes], [detPerEstado] FROM [PeriodosDetdetFch] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio AND [detFchIni] = @detFchIni ",true, GxErrorMask.GX_NOMASK, false, this,prmT00103,1,0,true,false )
             ,new CursorDef("T00104", "SELECT [PerAnio], [PerUltMes], [EmpID], [procesoCod] FROM [PeriodosPer] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT00104,1,0,true,true )
             ,new CursorDef("T00105", "SELECT [PerAnio], [PerUltMes], [EmpID], [procesoCod] FROM [PeriodosPer] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT00105,1,0,true,true )
             ,new CursorDef("T00106", "SELECT [PerFchControl], [PerUser] AS PerUser FROM [Periodos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT00106,1,0,true,true )
             ,new CursorDef("T00107", "SELECT [UsuName] AS PerUserName FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @PerUser ",true, GxErrorMask.GX_NOMASK, false, this,prmT00107,1,0,true,true )
             ,new CursorDef("T00108", "SELECT TM1.[PerAnio], T2.[PerFchControl], T3.[UsuName] AS PerUserName, TM1.[PerUltMes], TM1.[EmpID], TM1.[procesoCod], T2.[PerUser] AS PerUser FROM (([PeriodosPer] TM1 WITH (NOLOCK) INNER JOIN [Periodos] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID] AND T2.[procesoCod] = TM1.[procesoCod]) INNER JOIN [Usuarios] T3 WITH (NOLOCK) ON T3.[UsuCod] = T2.[PerUser]) WHERE TM1.[EmpID] = @EmpID and TM1.[procesoCod] = @procesoCod and TM1.[PerAnio] = @PerAnio ORDER BY TM1.[EmpID], TM1.[procesoCod], TM1.[PerAnio]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00108,1,0,true,true )
             ,new CursorDef("T00109", "SELECT [EmpID], [procesoCod], [PerAnio] FROM [PeriodosPer] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00109,1,0,true,true )
             ,new CursorDef("T001010", "SELECT TOP 1 [EmpID], [procesoCod], [PerAnio] FROM [PeriodosPer] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [procesoCod] = @procesoCod and [PerAnio] = @PerAnio ORDER BY [EmpID], [procesoCod], [PerAnio]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001010,1,0,true,true )
             ,new CursorDef("T001011", "SELECT TOP 1 [EmpID], [procesoCod], [PerAnio] FROM [PeriodosPer] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [procesoCod] = @procesoCod and [PerAnio] = @PerAnio ORDER BY [EmpID] DESC, [procesoCod] DESC, [PerAnio] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001011,1,0,true,true )
             ,new CursorDef("T001012", "INSERT INTO [PeriodosPer]([PerAnio], [PerUltMes], [EmpID], [procesoCod]) VALUES(@PerAnio, @PerUltMes, @EmpID, @procesoCod)", GxErrorMask.GX_NOMASK,prmT001012)
             ,new CursorDef("T001013", "UPDATE [PeriodosPer] SET [PerUltMes]=@PerUltMes  WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio", GxErrorMask.GX_NOMASK,prmT001013)
             ,new CursorDef("T001014", "DELETE FROM [PeriodosPer]  WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio", GxErrorMask.GX_NOMASK,prmT001014)
             ,new CursorDef("T001015", "SELECT [EmpID], [procesoCod], [PerAnio] FROM [PeriodosPer] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [procesoCod] = @procesoCod and [PerAnio] = @PerAnio ORDER BY [EmpID], [procesoCod], [PerAnio]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001015,100,0,true,true )
             ,new CursorDef("T001016", "SELECT [EmpID], [procesoCod], [PerAnio], [detFchIni], [detMes], [detPerEstado] FROM [PeriodosDetdetFch] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [procesoCod] = @procesoCod and [PerAnio] = @PerAnio and [detFchIni] = @detFchIni ORDER BY [EmpID], [procesoCod], [PerAnio], [detFchIni] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001016,11,0,true,false )
             ,new CursorDef("T001017", "SELECT [EmpID], [procesoCod], [PerAnio], [detFchIni] FROM [PeriodosDetdetFch] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio AND [detFchIni] = @detFchIni ",true, GxErrorMask.GX_NOMASK, false, this,prmT001017,1,0,true,false )
             ,new CursorDef("T001018", "INSERT INTO [PeriodosDetdetFch]([EmpID], [procesoCod], [PerAnio], [detFchIni], [detMes], [detPerEstado]) VALUES(@EmpID, @procesoCod, @PerAnio, @detFchIni, @detMes, @detPerEstado)", GxErrorMask.GX_NOMASK,prmT001018)
             ,new CursorDef("T001019", "UPDATE [PeriodosDetdetFch] SET [detMes]=@detMes, [detPerEstado]=@detPerEstado  WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio AND [detFchIni] = @detFchIni", GxErrorMask.GX_NOMASK,prmT001019)
             ,new CursorDef("T001020", "DELETE FROM [PeriodosDetdetFch]  WHERE [EmpID] = @EmpID AND [procesoCod] = @procesoCod AND [PerAnio] = @PerAnio AND [detFchIni] = @detFchIni", GxErrorMask.GX_NOMASK,prmT001020)
             ,new CursorDef("T001021", "SELECT [EmpID], [procesoCod], [PerAnio], [detFchIni] FROM [PeriodosDetdetFch] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [procesoCod] = @procesoCod and [PerAnio] = @PerAnio ORDER BY [EmpID], [procesoCod], [PerAnio], [detFchIni] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001021,11,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((String[]) buf[6])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((String[]) buf[6])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                return;
             case 4 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 15) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[9])[0] = rslt.getString(7, 15) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((String[]) buf[6])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[2]);
                }
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (String)parms[4]);
                return;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (String)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[7]);
                }
                return;
             case 17 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (String)parms[5]);
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (DateTime)parms[7]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
