/*
               File: IngresoBodegas
        Description: Ingreso Bodegas
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 12/27/2022 19:19:37.97
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
   public class ingresobodegas : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel10"+"_"+"INGREBODNRO") == 0 )
         {
            AV9ingreBodNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9ingreBodNro), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vINGREBODNRO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9ingreBodNro), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX10ASAINGREBODNRO1387( AV9ingreBodNro) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel11"+"_"+"INGREBODNRO") == 0 )
         {
            AV7EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
            AV8AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8AgeID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX11ASAINGREBODNRO1387( AV7EmpID, AV8AgeID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_33") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_33( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_34") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_34( A1EmpID, A2AgeID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_36") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A364ingreBodNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_36( A1EmpID, A2AgeID, A364ingreBodNro) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_35") == 0 )
         {
            A37PrvRuc = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_35( A37PrvRuc) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_38") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A286PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_38( A1EmpID, A2AgeID, A286PrdCod) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridingresobodegas_ingreboddet") == 0 )
         {
            nRC_GXsfl_106 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_106_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_106_idx = GetNextPar( );
            A373ingreBodUltNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
            n373ingreBodUltNro = false;
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridingresobodegas_ingreboddet_newrow( ) ;
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
               AV8AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8AgeID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
               AV9ingreBodNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9ingreBodNro), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vINGREBODNRO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9ingreBodNro), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Ingreso Bodegas", 0) ;
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

      public ingresobodegas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ingresobodegas( IGxContext context )
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
                           short aP2_AgeID ,
                           short aP3_ingreBodNro )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8AgeID = aP2_AgeID;
         this.AV9ingreBodNro = aP3_ingreBodNro;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbingreBodTipo = new GXCombobox();
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
         if ( cmbingreBodTipo.ItemCount > 0 )
         {
            A367ingreBodTipo = (short)(NumberUtil.Val( cmbingreBodTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0))), "."));
            n367ingreBodTipo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367ingreBodTipo", StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbingreBodTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbingreBodTipo_Internalname, "Values", cmbingreBodTipo.ToJavascriptSource(), true);
         }
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Ingreso Bodegas", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_IngresoBodegas.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx02f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"INGREBODNRO"+"'), id:'"+"INGREBODNRO"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_IngresoBodegas.htm");
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
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "Flex", "left", "top", " "+"data-gx-flex"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 250, "px", 0, "px", "FormCellAdvanced", "left", "top", "", "flex-grow::1;align-self:stretch;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Emp ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_IngresoBodegas.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 200, "px", 0, "px", "FormCellAdvanced", "left", "top", "", "flex-grow::1;align-self:stretch;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 250, "px", 0, "px", "FormCellAdvanced", "left", "top", "", "flex-grow::1;align-self:stretch;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeID_Internalname, "Age ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAgeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAgeID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_IngresoBodegas.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_2_Internalname, sImgUrl, imgprompt_2_Link, "", "", context.GetTheme( ), imgprompt_2_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 200, "px", 0, "px", "FormCellAdvanced", "left", "top", "", "flex-grow::1;align-self:stretch;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeDsc_Internalname, "Age Dsc", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtAgeDsc_Internalname, StringUtil.RTrim( A46AgeDsc), StringUtil.RTrim( context.localUtil.Format( A46AgeDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAgeDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtingreBodNro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtingreBodNro_Internalname, "Nro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtingreBodNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A364ingreBodNro), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A364ingreBodNro), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtingreBodNro_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtingreBodNro_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtingreBodDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtingreBodDsc_Internalname, "Descripcion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtingreBodDsc_Internalname, StringUtil.RTrim( A365ingreBodDsc), StringUtil.RTrim( context.localUtil.Format( A365ingreBodDsc, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtingreBodDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtingreBodDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Flex", "left", "top", " "+"data-gx-flex"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrvRuc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvRuc_Internalname, "Ruc", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrvRuc_Internalname, StringUtil.RTrim( A37PrvRuc), StringUtil.RTrim( context.localUtil.Format( A37PrvRuc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrvRuc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrvRuc_Enabled, 1, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_IngresoBodegas.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_37_Internalname, sImgUrl, imgprompt_37_Link, "", "", context.GetTheme( ), imgprompt_37_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "flex-grow::1;", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrvDsc_Internalname, "Razon Social", "col-sm-3 AttributePaddingLeftLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPrvDsc_Internalname, A184PrvDsc, StringUtil.RTrim( context.localUtil.Format( A184PrvDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrvDsc_Jsonclick, 0, "AttributePaddingLeft", "", "", "", "", 1, edtPrvDsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 150, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtingreBodFch_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtingreBodFch_Internalname, "Fecha", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtingreBodFch_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtingreBodFch_Internalname, context.localUtil.Format(A366ingreBodFch, "99/99/9999"), context.localUtil.Format( A366ingreBodFch, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtingreBodFch_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtingreBodFch_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_bitmap( context, edtingreBodFch_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtingreBodFch_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_IngresoBodegas.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbingreBodTipo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbingreBodTipo_Internalname, "Tipo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbingreBodTipo, cmbingreBodTipo_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0)), 1, cmbingreBodTipo_Jsonclick, 7, "'"+""+"'"+",false,"+"'"+"e111387_client"+"'", "int", "", 1, cmbingreBodTipo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "", true, "HLP_IngresoBodegas.htm");
            cmbingreBodTipo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbingreBodTipo_Internalname, "Values", (String)(cmbingreBodTipo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtingreBodNroFac_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtingreBodNroFac_Internalname, edtingreBodNroFac_Caption, "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtingreBodNroFac_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A368ingreBodNroFac), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A368ingreBodNroFac), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtingreBodNroFac_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtingreBodNroFac_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection1_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtingBodTotCant_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtingBodTotCant_Internalname, "Tot Cant", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtingBodTotCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A377ingBodTotCant, 8, 2, ",", "")), ((edtingBodTotCant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A377ingBodTotCant, "ZZZZ9.99")) : context.localUtil.Format( A377ingBodTotCant, "ZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtingBodTotCant_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtingBodTotCant_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection2_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtingBodTotValor_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtingBodTotValor_Internalname, "Subtotal", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtingBodTotValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A378ingBodTotValor, 8, 2, ",", "")), ((edtingBodTotValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A378ingBodTotValor, "ZZZZ9.99")) : context.localUtil.Format( A378ingBodTotValor, "ZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtingBodTotValor_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtingBodTotValor_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection3_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtingBodTotNeto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtingBodTotNeto_Internalname, "Total Neto", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtingBodTotNeto_Internalname, StringUtil.LTrim( StringUtil.NToC( A394ingBodTotNeto, 13, 2, ",", "")), ((edtingBodTotNeto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A394ingBodTotNeto, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A394ingBodTotNeto, "ZZ,ZZZ,ZZZ.ZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtingBodTotNeto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtingBodTotNeto_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "valores", "right", false, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divIngreboddettable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitleingreboddet_Internalname, "Items - Productos", "", "", lblTitleingreboddet_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridingresobodegas_ingreboddet( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_IngresoBodegas.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm1387( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridingresobodegas_ingreboddet( )
      {
         /*  Grid Control  */
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("GridName", "Gridingresobodegas_ingreboddet");
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Header", subGridingresobodegas_ingreboddet_Header);
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Class", "Grid");
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridingresobodegas_ingreboddet_Backcolorstyle), 1, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("CmpContext", "");
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("InMasterPage", "false");
         Gridingresobodegas_ingreboddetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A369ingreBodDetId), 4, 0, ".", "")));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetId_Enabled), 5, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddColumnProperties(Gridingresobodegas_ingreboddetColumn);
         Gridingresobodegas_ingreboddetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ".", "")));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddColumnProperties(Gridingresobodegas_ingreboddetColumn);
         Gridingresobodegas_ingreboddetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridingresobodegas_ingreboddetContainer.AddColumnProperties(Gridingresobodegas_ingreboddetColumn);
         Gridingresobodegas_ingreboddetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Value", A306PrdDescCorta);
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdDescCorta_Enabled), 5, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddColumnProperties(Gridingresobodegas_ingreboddetColumn);
         Gridingresobodegas_ingreboddetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A370ingreBodDetCant, 8, 2, ".", "")));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetCant_Enabled), 5, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddColumnProperties(Gridingresobodegas_ingreboddetColumn);
         Gridingresobodegas_ingreboddetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A371ingreBodDetVal, 8, 2, ".", "")));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetVal_Enabled), 5, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddColumnProperties(Gridingresobodegas_ingreboddetColumn);
         Gridingresobodegas_ingreboddetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A393IngBodDetValTot, 13, 2, ".", "")));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtIngBodDetValTot_Enabled), 5, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddColumnProperties(Gridingresobodegas_ingreboddetColumn);
         Gridingresobodegas_ingreboddetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Value", context.localUtil.Format(A372ingreBodDetFch, "99/99/9999"));
         Gridingresobodegas_ingreboddetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetFch_Enabled), 5, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddColumnProperties(Gridingresobodegas_ingreboddetColumn);
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridingresobodegas_ingreboddet_Selectedindex), 4, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridingresobodegas_ingreboddet_Allowselection), 1, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridingresobodegas_ingreboddet_Selectioncolor), 9, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridingresobodegas_ingreboddet_Allowhovering), 1, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridingresobodegas_ingreboddet_Hoveringcolor), 9, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridingresobodegas_ingreboddet_Allowcollapsing), 1, 0, ".", "")));
         Gridingresobodegas_ingreboddetContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridingresobodegas_ingreboddet_Collapsed), 1, 0, ".", "")));
         nGXsfl_106_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount88 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_88 = 1;
               ScanStart1388( ) ;
               while ( RcdFound88 != 0 )
               {
                  init_level_properties88( ) ;
                  getByPrimaryKey1388( ) ;
                  AddRow1388( ) ;
                  ScanNext1388( ) ;
               }
               ScanEnd1388( ) ;
               nBlankRcdCount88 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B373ingreBodUltNro = A373ingreBodUltNro;
            n373ingreBodUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
            B378ingBodTotValor = A378ingBodTotValor;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            B377ingBodTotCant = A377ingBodTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            standaloneNotModal1388( ) ;
            standaloneModal1388( ) ;
            sMode88 = Gx_mode;
            while ( nGXsfl_106_idx < nRC_GXsfl_106 )
            {
               bGXsfl_106_Refreshing = true;
               ReadRow1388( ) ;
               edtingreBodDetId_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGREBODDETID_"+sGXsfl_106_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDetId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDetId_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
               edtPrdCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDCOD_"+sGXsfl_106_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
               edtPrdDescCorta_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDDESCCORTA_"+sGXsfl_106_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdDescCorta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdDescCorta_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
               edtingreBodDetCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGREBODDETCANT_"+sGXsfl_106_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDetCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDetCant_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
               edtingreBodDetVal_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGREBODDETVAL_"+sGXsfl_106_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDetVal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDetVal_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
               edtIngBodDetValTot_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGBODDETVALTOT_"+sGXsfl_106_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtIngBodDetValTot_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtIngBodDetValTot_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
               edtingreBodDetFch_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGREBODDETFCH_"+sGXsfl_106_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDetFch_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDetFch_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_286_"+sGXsfl_106_idx+"Link");
               if ( ( nRcdExists_88 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal1388( ) ;
               }
               SendRow1388( ) ;
               bGXsfl_106_Refreshing = false;
            }
            Gx_mode = sMode88;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A373ingreBodUltNro = B373ingreBodUltNro;
            n373ingreBodUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
            A378ingBodTotValor = B378ingBodTotValor;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            A377ingBodTotCant = B377ingBodTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount88 = 5;
            nRcdExists_88 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart1388( ) ;
               while ( RcdFound88 != 0 )
               {
                  sGXsfl_106_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_106_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_10688( ) ;
                  init_level_properties88( ) ;
                  standaloneNotModal1388( ) ;
                  getByPrimaryKey1388( ) ;
                  standaloneModal1388( ) ;
                  AddRow1388( ) ;
                  ScanNext1388( ) ;
               }
               ScanEnd1388( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode88 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_106_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_106_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_10688( ) ;
            InitAll1388( ) ;
            init_level_properties88( ) ;
            B373ingreBodUltNro = A373ingreBodUltNro;
            n373ingreBodUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
            B378ingBodTotValor = A378ingBodTotValor;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            B377ingBodTotCant = A377ingBodTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            standaloneNotModal1388( ) ;
            standaloneModal1388( ) ;
            nRcdExists_88 = 0;
            nIsMod_88 = 0;
            nRcdDeleted_88 = 0;
            nBlankRcdCount88 = (short)(nBlankRcdUsr88+nBlankRcdCount88);
            fRowAdded = 0;
            while ( nBlankRcdCount88 > 0 )
            {
               AddRow1388( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtPrdCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount88 = (short)(nBlankRcdCount88-1);
            }
            Gx_mode = sMode88;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A373ingreBodUltNro = B373ingreBodUltNro;
            n373ingreBodUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
            A378ingBodTotValor = B378ingBodTotValor;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            A377ingBodTotCant = B377ingBodTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridingresobodegas_ingreboddetContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridingresobodegas_ingreboddet", Gridingresobodegas_ingreboddetContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridingresobodegas_ingreboddetContainerData", Gridingresobodegas_ingreboddetContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridingresobodegas_ingreboddetContainerData"+"V", Gridingresobodegas_ingreboddetContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridingresobodegas_ingreboddetContainerData"+"V"+"\" value='"+Gridingresobodegas_ingreboddetContainer.GridValuesHidden()+"'/>") ;
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
         E12132 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "AGEID");
                  AnyError = 1;
                  GX_FocusControl = edtAgeID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A2AgeID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               }
               else
               {
                  A2AgeID = (short)(context.localUtil.CToN( cgiGet( edtAgeID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               }
               A46AgeDsc = cgiGet( edtAgeDsc_Internalname);
               n46AgeDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
               if ( ( ( context.localUtil.CToN( cgiGet( edtingreBodNro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtingreBodNro_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "INGREBODNRO");
                  AnyError = 1;
                  GX_FocusControl = edtingreBodNro_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A364ingreBodNro = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
               }
               else
               {
                  A364ingreBodNro = (short)(context.localUtil.CToN( cgiGet( edtingreBodNro_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
               }
               A365ingreBodDsc = StringUtil.Upper( cgiGet( edtingreBodDsc_Internalname));
               n365ingreBodDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365ingreBodDsc", A365ingreBodDsc);
               n365ingreBodDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A365ingreBodDsc)) ? true : false);
               A37PrvRuc = cgiGet( edtPrvRuc_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
               A184PrvDsc = cgiGet( edtPrvDsc_Internalname);
               n184PrvDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
               if ( context.localUtil.VCDate( cgiGet( edtingreBodFch_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "INGREBODFCH");
                  AnyError = 1;
                  GX_FocusControl = edtingreBodFch_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A366ingreBodFch = DateTime.MinValue;
                  n366ingreBodFch = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366ingreBodFch", context.localUtil.Format(A366ingreBodFch, "99/99/9999"));
               }
               else
               {
                  A366ingreBodFch = context.localUtil.CToD( cgiGet( edtingreBodFch_Internalname), 2);
                  n366ingreBodFch = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366ingreBodFch", context.localUtil.Format(A366ingreBodFch, "99/99/9999"));
               }
               n366ingreBodFch = ((DateTime.MinValue==A366ingreBodFch) ? true : false);
               cmbingreBodTipo.Name = cmbingreBodTipo_Internalname;
               cmbingreBodTipo.CurrentValue = cgiGet( cmbingreBodTipo_Internalname);
               A367ingreBodTipo = (short)(NumberUtil.Val( cgiGet( cmbingreBodTipo_Internalname), "."));
               n367ingreBodTipo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367ingreBodTipo", StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0));
               n367ingreBodTipo = ((0==A367ingreBodTipo) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtingreBodNroFac_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtingreBodNroFac_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "INGREBODNROFAC");
                  AnyError = 1;
                  GX_FocusControl = edtingreBodNroFac_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A368ingreBodNroFac = 0;
                  n368ingreBodNroFac = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368ingreBodNroFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A368ingreBodNroFac), 4, 0)));
               }
               else
               {
                  A368ingreBodNroFac = (short)(context.localUtil.CToN( cgiGet( edtingreBodNroFac_Internalname), ",", "."));
                  n368ingreBodNroFac = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368ingreBodNroFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A368ingreBodNroFac), 4, 0)));
               }
               n368ingreBodNroFac = ((0==A368ingreBodNroFac) ? true : false);
               A377ingBodTotCant = context.localUtil.CToN( cgiGet( edtingBodTotCant_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
               A378ingBodTotValor = context.localUtil.CToN( cgiGet( edtingBodTotValor_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
               A394ingBodTotNeto = context.localUtil.CToN( cgiGet( edtingBodTotNeto_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ingBodTotNeto", StringUtil.LTrim( StringUtil.Str( A394ingBodTotNeto, 10, 2)));
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z2AgeID = (short)(context.localUtil.CToN( cgiGet( "Z2AgeID"), ",", "."));
               Z364ingreBodNro = (short)(context.localUtil.CToN( cgiGet( "Z364ingreBodNro"), ",", "."));
               Z365ingreBodDsc = cgiGet( "Z365ingreBodDsc");
               n365ingreBodDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A365ingreBodDsc)) ? true : false);
               Z366ingreBodFch = context.localUtil.CToD( cgiGet( "Z366ingreBodFch"), 0);
               n366ingreBodFch = ((DateTime.MinValue==A366ingreBodFch) ? true : false);
               Z367ingreBodTipo = (short)(context.localUtil.CToN( cgiGet( "Z367ingreBodTipo"), ",", "."));
               n367ingreBodTipo = ((0==A367ingreBodTipo) ? true : false);
               Z368ingreBodNroFac = (short)(context.localUtil.CToN( cgiGet( "Z368ingreBodNroFac"), ",", "."));
               n368ingreBodNroFac = ((0==A368ingreBodNroFac) ? true : false);
               Z373ingreBodUltNro = (short)(context.localUtil.CToN( cgiGet( "Z373ingreBodUltNro"), ",", "."));
               n373ingreBodUltNro = ((0==A373ingreBodUltNro) ? true : false);
               Z37PrvRuc = cgiGet( "Z37PrvRuc");
               A373ingreBodUltNro = (short)(context.localUtil.CToN( cgiGet( "Z373ingreBodUltNro"), ",", "."));
               n373ingreBodUltNro = false;
               n373ingreBodUltNro = ((0==A373ingreBodUltNro) ? true : false);
               O373ingreBodUltNro = (short)(context.localUtil.CToN( cgiGet( "O373ingreBodUltNro"), ",", "."));
               n373ingreBodUltNro = ((0==A373ingreBodUltNro) ? true : false);
               O378ingBodTotValor = context.localUtil.CToN( cgiGet( "O378ingBodTotValor"), ",", ".");
               O377ingBodTotCant = context.localUtil.CToN( cgiGet( "O377ingBodTotCant"), ",", ".");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_106 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_106"), ",", "."));
               N37PrvRuc = cgiGet( "N37PrvRuc");
               A395ingBodValIVA = context.localUtil.CToN( cgiGet( "INGBODVALIVA"), ",", ".");
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8AgeID = (short)(context.localUtil.CToN( cgiGet( "vAGEID"), ",", "."));
               AV9ingreBodNro = (short)(context.localUtil.CToN( cgiGet( "vINGREBODNRO"), ",", "."));
               AV13Insert_PrvRuc = cgiGet( "vINSERT_PRVRUC");
               A373ingreBodUltNro = (short)(context.localUtil.CToN( cgiGet( "INGREBODULTNRO"), ",", "."));
               n373ingreBodUltNro = ((0==A373ingreBodUltNro) ? true : false);
               AV16Pgmname = cgiGet( "vPGMNAME");
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "IngresoBodegas";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV13Insert_PrvRuc, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A364ingreBodNro != Z364ingreBodNro ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("ingresobodegas:[SecurityCheckFailed value for]"+"Insert_PrvRuc:"+StringUtil.RTrim( context.localUtil.Format( AV13Insert_PrvRuc, "")));
                  GXUtil.WriteLog("ingresobodegas:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A364ingreBodNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
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
                     sMode87 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode87;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound87 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_130( ) ;
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
                        E12132 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E13132 ();
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
            E13132 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1387( ) ;
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
            DisableAttributes1387( ) ;
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

      protected void CONFIRM_130( )
      {
         BeforeValidate1387( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1387( ) ;
            }
            else
            {
               CheckExtendedTable1387( ) ;
               CloseExtendedTableCursors1387( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode87 = Gx_mode;
            CONFIRM_1388( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode87;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode87;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_1388( )
      {
         s373ingreBodUltNro = O373ingreBodUltNro;
         n373ingreBodUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
         s378ingBodTotValor = O378ingBodTotValor;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         s377ingBodTotCant = O377ingBodTotCant;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
         s395ingBodValIVA = O395ingBodValIVA;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         nGXsfl_106_idx = 0;
         while ( nGXsfl_106_idx < nRC_GXsfl_106 )
         {
            ReadRow1388( ) ;
            if ( ( nRcdExists_88 != 0 ) || ( nIsMod_88 != 0 ) )
            {
               GetKey1388( ) ;
               if ( ( nRcdExists_88 == 0 ) && ( nRcdDeleted_88 == 0 ) )
               {
                  if ( RcdFound88 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate1388( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1388( ) ;
                        CloseExtendedTableCursors1388( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O373ingreBodUltNro = A373ingreBodUltNro;
                        n373ingreBodUltNro = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
                        O378ingBodTotValor = A378ingBodTotValor;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
                        O377ingBodTotCant = A377ingBodTotCant;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
                        O395ingBodValIVA = A395ingBodValIVA;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "EMPID");
                     AnyError = 1;
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound88 != 0 )
                  {
                     if ( nRcdDeleted_88 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey1388( ) ;
                        Load1388( ) ;
                        BeforeValidate1388( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1388( ) ;
                           O373ingreBodUltNro = A373ingreBodUltNro;
                           n373ingreBodUltNro = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
                           O378ingBodTotValor = A378ingBodTotValor;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
                           O377ingBodTotCant = A377ingBodTotCant;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
                           O395ingBodValIVA = A395ingBodValIVA;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_88 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate1388( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1388( ) ;
                              CloseExtendedTableCursors1388( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O373ingreBodUltNro = A373ingreBodUltNro;
                              n373ingreBodUltNro = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
                              O378ingBodTotValor = A378ingBodTotValor;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
                              O377ingBodTotCant = A377ingBodTotCant;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
                              O395ingBodValIVA = A395ingBodValIVA;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_88 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EMPID");
                        AnyError = 1;
                        GX_FocusControl = edtEmpID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtingreBodDetId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A369ingreBodDetId), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrdDescCorta_Internalname, A306PrdDescCorta) ;
            ChangePostValue( edtingreBodDetCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A370ingreBodDetCant, 8, 2, ",", ""))) ;
            ChangePostValue( edtingreBodDetVal_Internalname, StringUtil.LTrim( StringUtil.NToC( A371ingreBodDetVal, 8, 2, ",", ""))) ;
            ChangePostValue( edtIngBodDetValTot_Internalname, StringUtil.LTrim( StringUtil.NToC( A393IngBodDetValTot, 13, 2, ",", ""))) ;
            ChangePostValue( edtingreBodDetFch_Internalname, context.localUtil.Format(A372ingreBodDetFch, "99/99/9999")) ;
            ChangePostValue( "ZT_"+"Z369ingreBodDetId_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z369ingreBodDetId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z372ingreBodDetFch_"+sGXsfl_106_idx, context.localUtil.DToC( Z372ingreBodDetFch, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z370ingreBodDetCant_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( Z370ingreBodDetCant, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z371ingreBodDetVal_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( Z371ingreBodDetVal, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( "T393IngBodDetValTot_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( O393IngBodDetValTot, 10, 2, ",", ""))) ;
            ChangePostValue( "T370ingreBodDetCant_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( O370ingreBodDetCant, 8, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_88_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_88), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_88_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_88), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_88_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_88), 4, 0, ",", ""))) ;
            if ( nIsMod_88 != 0 )
            {
               ChangePostValue( "INGREBODDETID_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDCOD_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDDESCCORTA_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdDescCorta_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGREBODDETCANT_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGREBODDETVAL_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetVal_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGBODDETVALTOT_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtIngBodDetValTot_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGREBODDETFCH_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetFch_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O373ingreBodUltNro = s373ingreBodUltNro;
         n373ingreBodUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
         O378ingBodTotValor = s378ingBodTotValor;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         O377ingBodTotCant = s377ingBodTotCant;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
         O395ingBodValIVA = s395ingBodValIVA;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption130( )
      {
      }

      protected void E12132( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV16Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV13Insert_PrvRuc = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_PrvRuc", AV13Insert_PrvRuc);
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV16Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV17GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            while ( AV17GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((SdtTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV17GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "PrvRuc") == 0 )
               {
                  AV13Insert_PrvRuc = AV14TrnContextAtt.gxTpr_Attributevalue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_PrvRuc", AV13Insert_PrvRuc);
               }
               AV17GXV1 = (int)(AV17GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            }
         }
      }

      protected void E13132( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwingresobodegas.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM1387( short GX_JID )
      {
         if ( ( GX_JID == 32 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z365ingreBodDsc = T00136_A365ingreBodDsc[0];
               Z366ingreBodFch = T00136_A366ingreBodFch[0];
               Z367ingreBodTipo = T00136_A367ingreBodTipo[0];
               Z368ingreBodNroFac = T00136_A368ingreBodNroFac[0];
               Z373ingreBodUltNro = T00136_A373ingreBodUltNro[0];
               Z37PrvRuc = T00136_A37PrvRuc[0];
            }
            else
            {
               Z365ingreBodDsc = A365ingreBodDsc;
               Z366ingreBodFch = A366ingreBodFch;
               Z367ingreBodTipo = A367ingreBodTipo;
               Z368ingreBodNroFac = A368ingreBodNroFac;
               Z373ingreBodUltNro = A373ingreBodUltNro;
               Z37PrvRuc = A37PrvRuc;
            }
         }
         if ( GX_JID == -32 )
         {
            Z364ingreBodNro = A364ingreBodNro;
            Z365ingreBodDsc = A365ingreBodDsc;
            Z366ingreBodFch = A366ingreBodFch;
            Z367ingreBodTipo = A367ingreBodTipo;
            Z368ingreBodNroFac = A368ingreBodNroFac;
            Z373ingreBodUltNro = A373ingreBodUltNro;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z37PrvRuc = A37PrvRuc;
            Z44empdsc = A44empdsc;
            Z46AgeDsc = A46AgeDsc;
            Z377ingBodTotCant = A377ingBodTotCant;
            Z378ingBodTotValor = A378ingBodTotValor;
            Z184PrvDsc = A184PrvDsc;
         }
      }

      protected void standaloneNotModal( )
      {
         edtingBodTotCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotCant_Enabled), 5, 0)), true);
         edtingBodTotValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotValor_Enabled), 5, 0)), true);
         edtingBodTotNeto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotNeto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotNeto_Enabled), 5, 0)), true);
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_2_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0021.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_37_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00v0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRVRUC"+"'), id:'"+"PRVRUC"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtingBodTotCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotCant_Enabled), 5, 0)), true);
         edtingBodTotValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotValor_Enabled), 5, 0)), true);
         edtingBodTotNeto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotNeto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotNeto_Enabled), 5, 0)), true);
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
         if ( ! (0==AV8AgeID) )
         {
            A2AgeID = AV8AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         }
         if ( ! (0==AV8AgeID) )
         {
            edtAgeID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         }
         else
         {
            edtAgeID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8AgeID) )
         {
            edtAgeID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV9ingreBodNro) )
         {
            A364ingreBodNro = AV9ingreBodNro;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
         }
         if ( ! (0==AV9ingreBodNro) )
         {
            edtingreBodNro_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodNro_Enabled), 5, 0)), true);
         }
         else
         {
            edtingreBodNro_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodNro_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV9ingreBodNro) )
         {
            edtingreBodNro_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodNro_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV13Insert_PrvRuc)) )
         {
            edtPrvRuc_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), true);
         }
         else
         {
            edtPrvRuc_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV13Insert_PrvRuc)) )
         {
            A37PrvRuc = AV13Insert_PrvRuc;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
         }
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
            /* Using cursor T00137 */
            pr_default.execute(5, new Object[] {A1EmpID});
            A44empdsc = T00137_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T00137_n44empdsc[0];
            pr_default.close(5);
            AV16Pgmname = "IngresoBodegas";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            /* Using cursor T00138 */
            pr_default.execute(6, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T00138_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T00138_n46AgeDsc[0];
            pr_default.close(6);
            /* Using cursor T001311 */
            pr_default.execute(8, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
            if ( (pr_default.getStatus(8) != 101) )
            {
               A377ingBodTotCant = T001311_A377ingBodTotCant[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
               A378ingBodTotValor = T001311_A378ingBodTotValor[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            }
            else
            {
               A377ingBodTotCant = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
               A378ingBodTotValor = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            }
            O377ingBodTotCant = A377ingBodTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            O378ingBodTotValor = A378ingBodTotValor;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            pr_default.close(8);
            A395ingBodValIVA = NumberUtil.Round( (A378ingBodTotValor*12)/ (decimal)(100), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
            A394ingBodTotNeto = NumberUtil.Round( (A378ingBodTotValor+A395ingBodValIVA), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ingBodTotNeto", StringUtil.LTrim( StringUtil.Str( A394ingBodTotNeto, 10, 2)));
            /* Using cursor T00139 */
            pr_default.execute(7, new Object[] {A37PrvRuc});
            A184PrvDsc = T00139_A184PrvDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
            n184PrvDsc = T00139_n184PrvDsc[0];
            pr_default.close(7);
         }
      }

      protected void Load1387( )
      {
         /* Using cursor T001313 */
         pr_default.execute(9, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound87 = 1;
            A44empdsc = T001313_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T001313_n44empdsc[0];
            A46AgeDsc = T001313_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T001313_n46AgeDsc[0];
            A365ingreBodDsc = T001313_A365ingreBodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365ingreBodDsc", A365ingreBodDsc);
            n365ingreBodDsc = T001313_n365ingreBodDsc[0];
            A366ingreBodFch = T001313_A366ingreBodFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366ingreBodFch", context.localUtil.Format(A366ingreBodFch, "99/99/9999"));
            n366ingreBodFch = T001313_n366ingreBodFch[0];
            A367ingreBodTipo = T001313_A367ingreBodTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367ingreBodTipo", StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0));
            n367ingreBodTipo = T001313_n367ingreBodTipo[0];
            A368ingreBodNroFac = T001313_A368ingreBodNroFac[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368ingreBodNroFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A368ingreBodNroFac), 4, 0)));
            n368ingreBodNroFac = T001313_n368ingreBodNroFac[0];
            A184PrvDsc = T001313_A184PrvDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
            n184PrvDsc = T001313_n184PrvDsc[0];
            A373ingreBodUltNro = T001313_A373ingreBodUltNro[0];
            n373ingreBodUltNro = T001313_n373ingreBodUltNro[0];
            A37PrvRuc = T001313_A37PrvRuc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
            A377ingBodTotCant = T001313_A377ingBodTotCant[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            A378ingBodTotValor = T001313_A378ingBodTotValor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            ZM1387( -32) ;
         }
         pr_default.close(9);
         OnLoadActions1387( ) ;
      }

      protected void OnLoadActions1387( )
      {
         O378ingBodTotValor = A378ingBodTotValor;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         O377ingBodTotCant = A377ingBodTotCant;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
         AV16Pgmname = "IngresoBodegas";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         A395ingBodValIVA = NumberUtil.Round( (A378ingBodTotValor*12)/ (decimal)(100), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         A394ingBodTotNeto = NumberUtil.Round( (A378ingBodTotValor+A395ingBodValIVA), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ingBodTotNeto", StringUtil.LTrim( StringUtil.Str( A394ingBodTotNeto, 10, 2)));
      }

      protected void CheckExtendedTable1387( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV16Pgmname = "IngresoBodegas";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         /* Using cursor T00137 */
         pr_default.execute(5, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00137_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00137_n44empdsc[0];
         pr_default.close(5);
         /* Using cursor T00138 */
         pr_default.execute(6, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T00138_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T00138_n46AgeDsc[0];
         pr_default.close(6);
         /* Using cursor T001311 */
         pr_default.execute(8, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
         if ( (pr_default.getStatus(8) != 101) )
         {
            A377ingBodTotCant = T001311_A377ingBodTotCant[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            A378ingBodTotValor = T001311_A378ingBodTotValor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         }
         else
         {
            A377ingBodTotCant = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            A378ingBodTotValor = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         }
         pr_default.close(8);
         A395ingBodValIVA = NumberUtil.Round( (A378ingBodTotValor*12)/ (decimal)(100), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         A394ingBodTotNeto = NumberUtil.Round( (A378ingBodTotValor+A395ingBodValIVA), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ingBodTotNeto", StringUtil.LTrim( StringUtil.Str( A394ingBodTotNeto, 10, 2)));
         if ( ! ( (DateTime.MinValue==A366ingreBodFch) || ( A366ingreBodFch >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "INGREBODFCH");
            AnyError = 1;
            GX_FocusControl = edtingreBodFch_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00139 */
         pr_default.execute(7, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, "PRVRUC");
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A184PrvDsc = T00139_A184PrvDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
         n184PrvDsc = T00139_n184PrvDsc[0];
         pr_default.close(7);
      }

      protected void CloseExtendedTableCursors1387( )
      {
         pr_default.close(5);
         pr_default.close(6);
         pr_default.close(8);
         pr_default.close(7);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_33( short A1EmpID )
      {
         /* Using cursor T001314 */
         pr_default.execute(10, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T001314_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T001314_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(10);
      }

      protected void gxLoad_34( short A1EmpID ,
                                short A2AgeID )
      {
         /* Using cursor T001315 */
         pr_default.execute(11, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T001315_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T001315_n46AgeDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A46AgeDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(11) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(11);
      }

      protected void gxLoad_36( short A1EmpID ,
                                short A2AgeID ,
                                short A364ingreBodNro )
      {
         /* Using cursor T001317 */
         pr_default.execute(12, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
         if ( (pr_default.getStatus(12) != 101) )
         {
            A377ingBodTotCant = T001317_A377ingBodTotCant[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            A378ingBodTotValor = T001317_A378ingBodTotValor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         }
         else
         {
            A377ingBodTotCant = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            A378ingBodTotValor = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A377ingBodTotCant, 8, 2, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A378ingBodTotValor, 8, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(12);
      }

      protected void gxLoad_35( String A37PrvRuc )
      {
         /* Using cursor T001318 */
         pr_default.execute(13, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, "PRVRUC");
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A184PrvDsc = T001318_A184PrvDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
         n184PrvDsc = T001318_n184PrvDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A184PrvDsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(13) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(13);
      }

      protected void GetKey1387( )
      {
         /* Using cursor T001319 */
         pr_default.execute(14, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound87 = 1;
         }
         else
         {
            RcdFound87 = 0;
         }
         pr_default.close(14);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00136 */
         pr_default.execute(4, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM1387( 32) ;
            RcdFound87 = 1;
            A364ingreBodNro = T00136_A364ingreBodNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
            A365ingreBodDsc = T00136_A365ingreBodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365ingreBodDsc", A365ingreBodDsc);
            n365ingreBodDsc = T00136_n365ingreBodDsc[0];
            A366ingreBodFch = T00136_A366ingreBodFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366ingreBodFch", context.localUtil.Format(A366ingreBodFch, "99/99/9999"));
            n366ingreBodFch = T00136_n366ingreBodFch[0];
            A367ingreBodTipo = T00136_A367ingreBodTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367ingreBodTipo", StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0));
            n367ingreBodTipo = T00136_n367ingreBodTipo[0];
            A368ingreBodNroFac = T00136_A368ingreBodNroFac[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368ingreBodNroFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A368ingreBodNroFac), 4, 0)));
            n368ingreBodNroFac = T00136_n368ingreBodNroFac[0];
            A373ingreBodUltNro = T00136_A373ingreBodUltNro[0];
            n373ingreBodUltNro = T00136_n373ingreBodUltNro[0];
            A1EmpID = T00136_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T00136_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A37PrvRuc = T00136_A37PrvRuc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
            O373ingreBodUltNro = A373ingreBodUltNro;
            n373ingreBodUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z364ingreBodNro = A364ingreBodNro;
            sMode87 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1387( ) ;
            if ( AnyError == 1 )
            {
               RcdFound87 = 0;
               InitializeNonKey1387( ) ;
            }
            Gx_mode = sMode87;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound87 = 0;
            InitializeNonKey1387( ) ;
            sMode87 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode87;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey1387( ) ;
         if ( RcdFound87 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound87 = 0;
         /* Using cursor T001320 */
         pr_default.execute(15, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
         if ( (pr_default.getStatus(15) != 101) )
         {
            while ( (pr_default.getStatus(15) != 101) && ( ( T001320_A1EmpID[0] < A1EmpID ) || ( T001320_A1EmpID[0] == A1EmpID ) && ( T001320_A2AgeID[0] < A2AgeID ) || ( T001320_A2AgeID[0] == A2AgeID ) && ( T001320_A1EmpID[0] == A1EmpID ) && ( T001320_A364ingreBodNro[0] < A364ingreBodNro ) ) )
            {
               pr_default.readNext(15);
            }
            if ( (pr_default.getStatus(15) != 101) && ( ( T001320_A1EmpID[0] > A1EmpID ) || ( T001320_A1EmpID[0] == A1EmpID ) && ( T001320_A2AgeID[0] > A2AgeID ) || ( T001320_A2AgeID[0] == A2AgeID ) && ( T001320_A1EmpID[0] == A1EmpID ) && ( T001320_A364ingreBodNro[0] > A364ingreBodNro ) ) )
            {
               A1EmpID = T001320_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T001320_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A364ingreBodNro = T001320_A364ingreBodNro[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
               RcdFound87 = 1;
            }
         }
         pr_default.close(15);
      }

      protected void move_previous( )
      {
         RcdFound87 = 0;
         /* Using cursor T001321 */
         pr_default.execute(16, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
         if ( (pr_default.getStatus(16) != 101) )
         {
            while ( (pr_default.getStatus(16) != 101) && ( ( T001321_A1EmpID[0] > A1EmpID ) || ( T001321_A1EmpID[0] == A1EmpID ) && ( T001321_A2AgeID[0] > A2AgeID ) || ( T001321_A2AgeID[0] == A2AgeID ) && ( T001321_A1EmpID[0] == A1EmpID ) && ( T001321_A364ingreBodNro[0] > A364ingreBodNro ) ) )
            {
               pr_default.readNext(16);
            }
            if ( (pr_default.getStatus(16) != 101) && ( ( T001321_A1EmpID[0] < A1EmpID ) || ( T001321_A1EmpID[0] == A1EmpID ) && ( T001321_A2AgeID[0] < A2AgeID ) || ( T001321_A2AgeID[0] == A2AgeID ) && ( T001321_A1EmpID[0] == A1EmpID ) && ( T001321_A364ingreBodNro[0] < A364ingreBodNro ) ) )
            {
               A1EmpID = T001321_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T001321_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A364ingreBodNro = T001321_A364ingreBodNro[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
               RcdFound87 = 1;
            }
         }
         pr_default.close(16);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1387( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A373ingreBodUltNro = O373ingreBodUltNro;
            n373ingreBodUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
            A378ingBodTotValor = O378ingBodTotValor;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            A377ingBodTotCant = O377ingBodTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            A395ingBodValIVA = O395ingBodValIVA;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1387( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound87 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A364ingreBodNro != Z364ingreBodNro ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A2AgeID = Z2AgeID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A364ingreBodNro = Z364ingreBodNro;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A373ingreBodUltNro = O373ingreBodUltNro;
                  n373ingreBodUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
                  A378ingBodTotValor = O378ingBodTotValor;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
                  A377ingBodTotCant = O377ingBodTotCant;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
                  A395ingBodValIVA = O395ingBodValIVA;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A373ingreBodUltNro = O373ingreBodUltNro;
                  n373ingreBodUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
                  A378ingBodTotValor = O378ingBodTotValor;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
                  A377ingBodTotCant = O377ingBodTotCant;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
                  A395ingBodValIVA = O395ingBodValIVA;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
                  Update1387( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A364ingreBodNro != Z364ingreBodNro ) )
               {
                  /* Insert record */
                  A373ingreBodUltNro = O373ingreBodUltNro;
                  n373ingreBodUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
                  A378ingBodTotValor = O378ingBodTotValor;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
                  A377ingBodTotCant = O377ingBodTotCant;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
                  A395ingBodValIVA = O395ingBodValIVA;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1387( ) ;
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
                     A373ingreBodUltNro = O373ingreBodUltNro;
                     n373ingreBodUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
                     A378ingBodTotValor = O378ingBodTotValor;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
                     A377ingBodTotCant = O377ingBodTotCant;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
                     A395ingBodValIVA = O395ingBodValIVA;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1387( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A364ingreBodNro != Z364ingreBodNro ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = Z2AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A364ingreBodNro = Z364ingreBodNro;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A373ingreBodUltNro = O373ingreBodUltNro;
            n373ingreBodUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
            A378ingBodTotValor = O378ingBodTotValor;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            A377ingBodTotCant = O377ingBodTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            A395ingBodValIVA = O395ingBodValIVA;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1387( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00135 */
            pr_default.execute(3, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"IngresoBodegas"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(3) == 101) || ( StringUtil.StrCmp(Z365ingreBodDsc, T00135_A365ingreBodDsc[0]) != 0 ) || ( Z366ingreBodFch != T00135_A366ingreBodFch[0] ) || ( Z367ingreBodTipo != T00135_A367ingreBodTipo[0] ) || ( Z368ingreBodNroFac != T00135_A368ingreBodNroFac[0] ) || ( Z373ingreBodUltNro != T00135_A373ingreBodUltNro[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z37PrvRuc, T00135_A37PrvRuc[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z365ingreBodDsc, T00135_A365ingreBodDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("ingresobodegas:[seudo value changed for attri]"+"ingreBodDsc");
                  GXUtil.WriteLogRaw("Old: ",Z365ingreBodDsc);
                  GXUtil.WriteLogRaw("Current: ",T00135_A365ingreBodDsc[0]);
               }
               if ( Z366ingreBodFch != T00135_A366ingreBodFch[0] )
               {
                  GXUtil.WriteLog("ingresobodegas:[seudo value changed for attri]"+"ingreBodFch");
                  GXUtil.WriteLogRaw("Old: ",Z366ingreBodFch);
                  GXUtil.WriteLogRaw("Current: ",T00135_A366ingreBodFch[0]);
               }
               if ( Z367ingreBodTipo != T00135_A367ingreBodTipo[0] )
               {
                  GXUtil.WriteLog("ingresobodegas:[seudo value changed for attri]"+"ingreBodTipo");
                  GXUtil.WriteLogRaw("Old: ",Z367ingreBodTipo);
                  GXUtil.WriteLogRaw("Current: ",T00135_A367ingreBodTipo[0]);
               }
               if ( Z368ingreBodNroFac != T00135_A368ingreBodNroFac[0] )
               {
                  GXUtil.WriteLog("ingresobodegas:[seudo value changed for attri]"+"ingreBodNroFac");
                  GXUtil.WriteLogRaw("Old: ",Z368ingreBodNroFac);
                  GXUtil.WriteLogRaw("Current: ",T00135_A368ingreBodNroFac[0]);
               }
               if ( Z373ingreBodUltNro != T00135_A373ingreBodUltNro[0] )
               {
                  GXUtil.WriteLog("ingresobodegas:[seudo value changed for attri]"+"ingreBodUltNro");
                  GXUtil.WriteLogRaw("Old: ",Z373ingreBodUltNro);
                  GXUtil.WriteLogRaw("Current: ",T00135_A373ingreBodUltNro[0]);
               }
               if ( StringUtil.StrCmp(Z37PrvRuc, T00135_A37PrvRuc[0]) != 0 )
               {
                  GXUtil.WriteLog("ingresobodegas:[seudo value changed for attri]"+"PrvRuc");
                  GXUtil.WriteLogRaw("Old: ",Z37PrvRuc);
                  GXUtil.WriteLogRaw("Current: ",T00135_A37PrvRuc[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"IngresoBodegas"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1387( )
      {
         BeforeValidate1387( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1387( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1387( 0) ;
            CheckOptimisticConcurrency1387( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1387( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1387( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001322 */
                     pr_default.execute(17, new Object[] {A364ingreBodNro, n365ingreBodDsc, A365ingreBodDsc, n366ingreBodFch, A366ingreBodFch, n367ingreBodTipo, A367ingreBodTipo, n368ingreBodNroFac, A368ingreBodNroFac, n373ingreBodUltNro, A373ingreBodUltNro, A1EmpID, A2AgeID, A37PrvRuc});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("IngresoBodegas") ;
                     if ( (pr_default.getStatus(17) == 1) )
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
                           ProcessLevel1387( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption130( ) ;
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
               Load1387( ) ;
            }
            EndLevel1387( ) ;
         }
         CloseExtendedTableCursors1387( ) ;
      }

      protected void Update1387( )
      {
         BeforeValidate1387( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1387( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1387( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1387( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1387( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001323 */
                     pr_default.execute(18, new Object[] {n365ingreBodDsc, A365ingreBodDsc, n366ingreBodFch, A366ingreBodFch, n367ingreBodTipo, A367ingreBodTipo, n368ingreBodNroFac, A368ingreBodNroFac, n373ingreBodUltNro, A373ingreBodUltNro, A37PrvRuc, A1EmpID, A2AgeID, A364ingreBodNro});
                     pr_default.close(18);
                     dsDefault.SmartCacheProvider.SetUpdated("IngresoBodegas") ;
                     if ( (pr_default.getStatus(18) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"IngresoBodegas"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1387( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel1387( ) ;
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
            EndLevel1387( ) ;
         }
         CloseExtendedTableCursors1387( ) ;
      }

      protected void DeferredUpdate1387( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1387( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1387( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1387( ) ;
            AfterConfirm1387( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1387( ) ;
               if ( AnyError == 0 )
               {
                  A373ingreBodUltNro = O373ingreBodUltNro;
                  n373ingreBodUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
                  A378ingBodTotValor = O378ingBodTotValor;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
                  A377ingBodTotCant = O377ingBodTotCant;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
                  A395ingBodValIVA = O395ingBodValIVA;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
                  ScanStart1388( ) ;
                  while ( RcdFound88 != 0 )
                  {
                     getByPrimaryKey1388( ) ;
                     Delete1388( ) ;
                     ScanNext1388( ) ;
                     O373ingreBodUltNro = A373ingreBodUltNro;
                     n373ingreBodUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
                     O378ingBodTotValor = A378ingBodTotValor;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
                     O377ingBodTotCant = A377ingBodTotCant;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
                     O395ingBodValIVA = A395ingBodValIVA;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
                  }
                  ScanEnd1388( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001324 */
                     pr_default.execute(19, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("IngresoBodegas") ;
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
         sMode87 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1387( ) ;
         Gx_mode = sMode87;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1387( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "IngresoBodegas";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            /* Using cursor T001325 */
            pr_default.execute(20, new Object[] {A1EmpID});
            A44empdsc = T001325_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T001325_n44empdsc[0];
            pr_default.close(20);
            /* Using cursor T001326 */
            pr_default.execute(21, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T001326_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T001326_n46AgeDsc[0];
            pr_default.close(21);
            /* Using cursor T001328 */
            pr_default.execute(22, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
            if ( (pr_default.getStatus(22) != 101) )
            {
               A377ingBodTotCant = T001328_A377ingBodTotCant[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
               A378ingBodTotValor = T001328_A378ingBodTotValor[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            }
            else
            {
               A377ingBodTotCant = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
               A378ingBodTotValor = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            }
            pr_default.close(22);
            A395ingBodValIVA = NumberUtil.Round( (A378ingBodTotValor*12)/ (decimal)(100), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
            A394ingBodTotNeto = NumberUtil.Round( (A378ingBodTotValor+A395ingBodValIVA), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ingBodTotNeto", StringUtil.LTrim( StringUtil.Str( A394ingBodTotNeto, 10, 2)));
            /* Using cursor T001329 */
            pr_default.execute(23, new Object[] {A37PrvRuc});
            A184PrvDsc = T001329_A184PrvDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
            n184PrvDsc = T001329_n184PrvDsc[0];
            pr_default.close(23);
         }
      }

      protected void ProcessNestedLevel1388( )
      {
         s373ingreBodUltNro = O373ingreBodUltNro;
         n373ingreBodUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
         s378ingBodTotValor = O378ingBodTotValor;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         s377ingBodTotCant = O377ingBodTotCant;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
         s395ingBodValIVA = O395ingBodValIVA;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         nGXsfl_106_idx = 0;
         while ( nGXsfl_106_idx < nRC_GXsfl_106 )
         {
            ReadRow1388( ) ;
            if ( ( nRcdExists_88 != 0 ) || ( nIsMod_88 != 0 ) )
            {
               standaloneNotModal1388( ) ;
               GetKey1388( ) ;
               if ( ( nRcdExists_88 == 0 ) && ( nRcdDeleted_88 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert1388( ) ;
               }
               else
               {
                  if ( RcdFound88 != 0 )
                  {
                     if ( ( nRcdDeleted_88 != 0 ) && ( nRcdExists_88 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete1388( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_88 != 0 ) && ( nRcdExists_88 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update1388( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_88 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EMPID");
                        AnyError = 1;
                        GX_FocusControl = edtEmpID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O373ingreBodUltNro = A373ingreBodUltNro;
               n373ingreBodUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
               O378ingBodTotValor = A378ingBodTotValor;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
               O377ingBodTotCant = A377ingBodTotCant;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
               O395ingBodValIVA = A395ingBodValIVA;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
            }
            ChangePostValue( edtingreBodDetId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A369ingreBodDetId), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrdDescCorta_Internalname, A306PrdDescCorta) ;
            ChangePostValue( edtingreBodDetCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A370ingreBodDetCant, 8, 2, ",", ""))) ;
            ChangePostValue( edtingreBodDetVal_Internalname, StringUtil.LTrim( StringUtil.NToC( A371ingreBodDetVal, 8, 2, ",", ""))) ;
            ChangePostValue( edtIngBodDetValTot_Internalname, StringUtil.LTrim( StringUtil.NToC( A393IngBodDetValTot, 13, 2, ",", ""))) ;
            ChangePostValue( edtingreBodDetFch_Internalname, context.localUtil.Format(A372ingreBodDetFch, "99/99/9999")) ;
            ChangePostValue( "ZT_"+"Z369ingreBodDetId_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z369ingreBodDetId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z372ingreBodDetFch_"+sGXsfl_106_idx, context.localUtil.DToC( Z372ingreBodDetFch, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z370ingreBodDetCant_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( Z370ingreBodDetCant, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z371ingreBodDetVal_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( Z371ingreBodDetVal, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( "T393IngBodDetValTot_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( O393IngBodDetValTot, 10, 2, ",", ""))) ;
            ChangePostValue( "T370ingreBodDetCant_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( O370ingreBodDetCant, 8, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_88_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_88), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_88_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_88), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_88_"+sGXsfl_106_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_88), 4, 0, ",", ""))) ;
            if ( nIsMod_88 != 0 )
            {
               ChangePostValue( "INGREBODDETID_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDCOD_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDDESCCORTA_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdDescCorta_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGREBODDETCANT_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGREBODDETVAL_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetVal_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGBODDETVALTOT_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtIngBodDetValTot_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGREBODDETFCH_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetFch_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1388( ) ;
         if ( AnyError != 0 )
         {
            O373ingreBodUltNro = s373ingreBodUltNro;
            n373ingreBodUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
            O378ingBodTotValor = s378ingBodTotValor;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            O377ingBodTotCant = s377ingBodTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            O395ingBodValIVA = s395ingBodValIVA;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         }
         nRcdExists_88 = 0;
         nIsMod_88 = 0;
         nRcdDeleted_88 = 0;
      }

      protected void ProcessLevel1387( )
      {
         /* Save parent mode. */
         sMode87 = Gx_mode;
         ProcessNestedLevel1388( ) ;
         if ( AnyError != 0 )
         {
            O373ingreBodUltNro = s373ingreBodUltNro;
            n373ingreBodUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
            O378ingBodTotValor = s378ingBodTotValor;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            O377ingBodTotCant = s377ingBodTotCant;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            O395ingBodValIVA = s395ingBodValIVA;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode87;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T001330 */
         pr_default.execute(24, new Object[] {n373ingreBodUltNro, A373ingreBodUltNro, A1EmpID, A2AgeID, A364ingreBodNro});
         pr_default.close(24);
         dsDefault.SmartCacheProvider.SetUpdated("IngresoBodegas") ;
      }

      protected void EndLevel1387( )
      {
         pr_default.close(3);
         if ( AnyError == 0 )
         {
            BeforeComplete1387( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(20);
            pr_default.close(21);
            pr_default.close(23);
            pr_default.close(22);
            pr_default.close(2);
            context.CommitDataStores("ingresobodegas",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues130( ) ;
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
            pr_default.close(20);
            pr_default.close(21);
            pr_default.close(23);
            pr_default.close(22);
            pr_default.close(2);
            context.RollbackDataStores("ingresobodegas",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1387( )
      {
         /* Scan By routine */
         /* Using cursor T001331 */
         pr_default.execute(25);
         RcdFound87 = 0;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound87 = 1;
            A1EmpID = T001331_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T001331_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A364ingreBodNro = T001331_A364ingreBodNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1387( )
      {
         /* Scan next routine */
         pr_default.readNext(25);
         RcdFound87 = 0;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound87 = 1;
            A1EmpID = T001331_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T001331_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A364ingreBodNro = T001331_A364ingreBodNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
         }
      }

      protected void ScanEnd1387( )
      {
         pr_default.close(25);
      }

      protected void AfterConfirm1387( )
      {
         /* After Confirm Rules */
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_int1 = A364ingreBodNro;
            new obtnextcod(context ).execute(  AV7EmpID,  AV8AgeID, out  GXt_int1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8AgeID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
            A364ingreBodNro = GXt_int1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
         }
      }

      protected void BeforeInsert1387( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1387( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1387( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1387( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1387( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1387( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtAgeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         edtAgeDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeDsc_Enabled), 5, 0)), true);
         edtingreBodNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodNro_Enabled), 5, 0)), true);
         edtingreBodDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDsc_Enabled), 5, 0)), true);
         edtPrvRuc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), true);
         edtPrvDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvDsc_Enabled), 5, 0)), true);
         edtingreBodFch_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodFch_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodFch_Enabled), 5, 0)), true);
         cmbingreBodTipo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbingreBodTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbingreBodTipo.Enabled), 5, 0)), true);
         edtingreBodNroFac_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodNroFac_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodNroFac_Enabled), 5, 0)), true);
         edtingBodTotCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotCant_Enabled), 5, 0)), true);
         edtingBodTotValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotValor_Enabled), 5, 0)), true);
         edtingBodTotNeto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotNeto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotNeto_Enabled), 5, 0)), true);
      }

      protected void ZM1388( short GX_JID )
      {
         if ( ( GX_JID == 37 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z372ingreBodDetFch = T00133_A372ingreBodDetFch[0];
               Z370ingreBodDetCant = T00133_A370ingreBodDetCant[0];
               Z371ingreBodDetVal = T00133_A371ingreBodDetVal[0];
               Z286PrdCod = T00133_A286PrdCod[0];
            }
            else
            {
               Z372ingreBodDetFch = A372ingreBodDetFch;
               Z370ingreBodDetCant = A370ingreBodDetCant;
               Z371ingreBodDetVal = A371ingreBodDetVal;
               Z286PrdCod = A286PrdCod;
            }
         }
         if ( GX_JID == -37 )
         {
            Z364ingreBodNro = A364ingreBodNro;
            Z369ingreBodDetId = A369ingreBodDetId;
            Z372ingreBodDetFch = A372ingreBodDetFch;
            Z370ingreBodDetCant = A370ingreBodDetCant;
            Z371ingreBodDetVal = A371ingreBodDetVal;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z286PrdCod = A286PrdCod;
            Z306PrdDescCorta = A306PrdDescCorta;
         }
      }

      protected void standaloneNotModal1388( )
      {
         edtingreBodDetId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDetId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDetId_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
         edtingBodTotCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotCant_Enabled), 5, 0)), true);
         edtingBodTotValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotValor_Enabled), 5, 0)), true);
         edtingBodTotCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotCant_Enabled), 5, 0)), true);
         edtingBodTotValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTotValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTotValor_Enabled), 5, 0)), true);
      }

      protected void standaloneModal1388( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A373ingreBodUltNro = (short)(O373ingreBodUltNro+1);
            n373ingreBodUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A369ingreBodDetId = A373ingreBodUltNro;
         }
      }

      protected void Load1388( )
      {
         /* Using cursor T001332 */
         pr_default.execute(26, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro, A369ingreBodDetId});
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound88 = 1;
            A306PrdDescCorta = T001332_A306PrdDescCorta[0];
            n306PrdDescCorta = T001332_n306PrdDescCorta[0];
            A372ingreBodDetFch = T001332_A372ingreBodDetFch[0];
            n372ingreBodDetFch = T001332_n372ingreBodDetFch[0];
            A370ingreBodDetCant = T001332_A370ingreBodDetCant[0];
            n370ingreBodDetCant = T001332_n370ingreBodDetCant[0];
            A371ingreBodDetVal = T001332_A371ingreBodDetVal[0];
            n371ingreBodDetVal = T001332_n371ingreBodDetVal[0];
            A286PrdCod = T001332_A286PrdCod[0];
            ZM1388( -37) ;
         }
         pr_default.close(26);
         OnLoadActions1388( ) ;
      }

      protected void OnLoadActions1388( )
      {
         A393IngBodDetValTot = NumberUtil.Round( (A370ingreBodDetCant*A371ingreBodDetVal), 2);
         O393IngBodDetValTot = A393IngBodDetValTot;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A378ingBodTotValor = (decimal)(O378ingBodTotValor+A393IngBodDetValTot);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A378ingBodTotValor = (decimal)(O378ingBodTotValor+A393IngBodDetValTot-O393IngBodDetValTot);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A378ingBodTotValor = (decimal)(O378ingBodTotValor-O393IngBodDetValTot);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
               }
            }
         }
         A395ingBodValIVA = NumberUtil.Round( (A378ingBodTotValor*12)/ (decimal)(100), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A377ingBodTotCant = (decimal)(O377ingBodTotCant+A370ingreBodDetCant);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A377ingBodTotCant = (decimal)(O377ingBodTotCant+A370ingreBodDetCant-O370ingreBodDetCant);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A377ingBodTotCant = (decimal)(O377ingBodTotCant-O370ingreBodDetCant);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
               }
            }
         }
      }

      protected void CheckExtendedTable1388( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal1388( ) ;
         /* Using cursor T00134 */
         pr_default.execute(2, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_106_idx;
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A306PrdDescCorta = T00134_A306PrdDescCorta[0];
         n306PrdDescCorta = T00134_n306PrdDescCorta[0];
         pr_default.close(2);
         if ( ! ( (DateTime.MinValue==A372ingreBodDetFch) || ( A372ingreBodDetFch >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXCCtl = "INGREBODDETFCH_" + sGXsfl_106_idx;
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtingreBodDetFch_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A393IngBodDetValTot = NumberUtil.Round( (A370ingreBodDetCant*A371ingreBodDetVal), 2);
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A378ingBodTotValor = (decimal)(O378ingBodTotValor+A393IngBodDetValTot);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A378ingBodTotValor = (decimal)(O378ingBodTotValor+A393IngBodDetValTot-O393IngBodDetValTot);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A378ingBodTotValor = (decimal)(O378ingBodTotValor-O393IngBodDetValTot);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
               }
            }
         }
         A395ingBodValIVA = NumberUtil.Round( (A378ingBodTotValor*12)/ (decimal)(100), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A377ingBodTotCant = (decimal)(O377ingBodTotCant+A370ingreBodDetCant);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A377ingBodTotCant = (decimal)(O377ingBodTotCant+A370ingreBodDetCant-O370ingreBodDetCant);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A377ingBodTotCant = (decimal)(O377ingBodTotCant-O370ingreBodDetCant);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
               }
            }
         }
      }

      protected void CloseExtendedTableCursors1388( )
      {
         pr_default.close(2);
      }

      protected void enableDisable1388( )
      {
      }

      protected void gxLoad_38( short A1EmpID ,
                                short A2AgeID ,
                                short A286PrdCod )
      {
         /* Using cursor T001333 */
         pr_default.execute(27, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(27) == 101) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_106_idx;
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A306PrdDescCorta = T001333_A306PrdDescCorta[0];
         n306PrdDescCorta = T001333_n306PrdDescCorta[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A306PrdDescCorta)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(27) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(27);
      }

      protected void GetKey1388( )
      {
         /* Using cursor T001334 */
         pr_default.execute(28, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro, A369ingreBodDetId});
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound88 = 1;
         }
         else
         {
            RcdFound88 = 0;
         }
         pr_default.close(28);
      }

      protected void getByPrimaryKey1388( )
      {
         /* Using cursor T00133 */
         pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro, A369ingreBodDetId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1388( 37) ;
            RcdFound88 = 1;
            InitializeNonKey1388( ) ;
            A369ingreBodDetId = T00133_A369ingreBodDetId[0];
            A372ingreBodDetFch = T00133_A372ingreBodDetFch[0];
            n372ingreBodDetFch = T00133_n372ingreBodDetFch[0];
            A370ingreBodDetCant = T00133_A370ingreBodDetCant[0];
            n370ingreBodDetCant = T00133_n370ingreBodDetCant[0];
            A371ingreBodDetVal = T00133_A371ingreBodDetVal[0];
            n371ingreBodDetVal = T00133_n371ingreBodDetVal[0];
            A286PrdCod = T00133_A286PrdCod[0];
            O370ingreBodDetCant = A370ingreBodDetCant;
            n370ingreBodDetCant = false;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z364ingreBodNro = A364ingreBodNro;
            Z369ingreBodDetId = A369ingreBodDetId;
            sMode88 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1388( ) ;
            Gx_mode = sMode88;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound88 = 0;
            InitializeNonKey1388( ) ;
            sMode88 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal1388( ) ;
            Gx_mode = sMode88;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes1388( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency1388( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00132 */
            pr_default.execute(0, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro, A369ingreBodDetId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"IngresoBodegasingreBodDet"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z372ingreBodDetFch != T00132_A372ingreBodDetFch[0] ) || ( Z370ingreBodDetCant != T00132_A370ingreBodDetCant[0] ) || ( Z371ingreBodDetVal != T00132_A371ingreBodDetVal[0] ) || ( Z286PrdCod != T00132_A286PrdCod[0] ) )
            {
               if ( Z372ingreBodDetFch != T00132_A372ingreBodDetFch[0] )
               {
                  GXUtil.WriteLog("ingresobodegas:[seudo value changed for attri]"+"ingreBodDetFch");
                  GXUtil.WriteLogRaw("Old: ",Z372ingreBodDetFch);
                  GXUtil.WriteLogRaw("Current: ",T00132_A372ingreBodDetFch[0]);
               }
               if ( Z370ingreBodDetCant != T00132_A370ingreBodDetCant[0] )
               {
                  GXUtil.WriteLog("ingresobodegas:[seudo value changed for attri]"+"ingreBodDetCant");
                  GXUtil.WriteLogRaw("Old: ",Z370ingreBodDetCant);
                  GXUtil.WriteLogRaw("Current: ",T00132_A370ingreBodDetCant[0]);
               }
               if ( Z371ingreBodDetVal != T00132_A371ingreBodDetVal[0] )
               {
                  GXUtil.WriteLog("ingresobodegas:[seudo value changed for attri]"+"ingreBodDetVal");
                  GXUtil.WriteLogRaw("Old: ",Z371ingreBodDetVal);
                  GXUtil.WriteLogRaw("Current: ",T00132_A371ingreBodDetVal[0]);
               }
               if ( Z286PrdCod != T00132_A286PrdCod[0] )
               {
                  GXUtil.WriteLog("ingresobodegas:[seudo value changed for attri]"+"PrdCod");
                  GXUtil.WriteLogRaw("Old: ",Z286PrdCod);
                  GXUtil.WriteLogRaw("Current: ",T00132_A286PrdCod[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"IngresoBodegasingreBodDet"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1388( )
      {
         BeforeValidate1388( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1388( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1388( 0) ;
            CheckOptimisticConcurrency1388( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1388( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1388( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001335 */
                     pr_default.execute(29, new Object[] {A364ingreBodNro, A369ingreBodDetId, n372ingreBodDetFch, A372ingreBodDetFch, n370ingreBodDetCant, A370ingreBodDetCant, n371ingreBodDetVal, A371ingreBodDetVal, A1EmpID, A2AgeID, A286PrdCod});
                     pr_default.close(29);
                     dsDefault.SmartCacheProvider.SetUpdated("IngresoBodegasingreBodDet") ;
                     if ( (pr_default.getStatus(29) == 1) )
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
               Load1388( ) ;
            }
            EndLevel1388( ) ;
         }
         CloseExtendedTableCursors1388( ) ;
      }

      protected void Update1388( )
      {
         BeforeValidate1388( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1388( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1388( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1388( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1388( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001336 */
                     pr_default.execute(30, new Object[] {n372ingreBodDetFch, A372ingreBodDetFch, n370ingreBodDetCant, A370ingreBodDetCant, n371ingreBodDetVal, A371ingreBodDetVal, A286PrdCod, A1EmpID, A2AgeID, A364ingreBodNro, A369ingreBodDetId});
                     pr_default.close(30);
                     dsDefault.SmartCacheProvider.SetUpdated("IngresoBodegasingreBodDet") ;
                     if ( (pr_default.getStatus(30) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"IngresoBodegasingreBodDet"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1388( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1388( ) ;
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
            EndLevel1388( ) ;
         }
         CloseExtendedTableCursors1388( ) ;
      }

      protected void DeferredUpdate1388( )
      {
      }

      protected void Delete1388( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate1388( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1388( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1388( ) ;
            AfterConfirm1388( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1388( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001337 */
                  pr_default.execute(31, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro, A369ingreBodDetId});
                  pr_default.close(31);
                  dsDefault.SmartCacheProvider.SetUpdated("IngresoBodegasingreBodDet") ;
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
         sMode88 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1388( ) ;
         Gx_mode = sMode88;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1388( )
      {
         standaloneModal1388( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T001338 */
            pr_default.execute(32, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            A306PrdDescCorta = T001338_A306PrdDescCorta[0];
            n306PrdDescCorta = T001338_n306PrdDescCorta[0];
            pr_default.close(32);
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A377ingBodTotCant = (decimal)(O377ingBodTotCant+A370ingreBodDetCant);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A377ingBodTotCant = (decimal)(O377ingBodTotCant+A370ingreBodDetCant-O370ingreBodDetCant);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A377ingBodTotCant = (decimal)(O377ingBodTotCant-O370ingreBodDetCant);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
                  }
               }
            }
            A393IngBodDetValTot = NumberUtil.Round( (A370ingreBodDetCant*A371ingreBodDetVal), 2);
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A378ingBodTotValor = (decimal)(O378ingBodTotValor+A393IngBodDetValTot);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A378ingBodTotValor = (decimal)(O378ingBodTotValor+A393IngBodDetValTot-O393IngBodDetValTot);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A378ingBodTotValor = (decimal)(O378ingBodTotValor-O393IngBodDetValTot);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
                  }
               }
            }
            A395ingBodValIVA = NumberUtil.Round( (A378ingBodTotValor*12)/ (decimal)(100), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         }
      }

      protected void EndLevel1388( )
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

      public void ScanStart1388( )
      {
         /* Scan By routine */
         /* Using cursor T001339 */
         pr_default.execute(33, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
         RcdFound88 = 0;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound88 = 1;
            A369ingreBodDetId = T001339_A369ingreBodDetId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1388( )
      {
         /* Scan next routine */
         pr_default.readNext(33);
         RcdFound88 = 0;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound88 = 1;
            A369ingreBodDetId = T001339_A369ingreBodDetId[0];
         }
      }

      protected void ScanEnd1388( )
      {
         pr_default.close(33);
      }

      protected void AfterConfirm1388( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1388( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1388( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1388( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1388( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1388( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1388( )
      {
         edtingreBodDetId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDetId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDetId_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
         edtPrdCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
         edtPrdDescCorta_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdDescCorta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdDescCorta_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
         edtingreBodDetCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDetCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDetCant_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
         edtingreBodDetVal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDetVal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDetVal_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
         edtIngBodDetValTot_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtIngBodDetValTot_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtIngBodDetValTot_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
         edtingreBodDetFch_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDetFch_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDetFch_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
      }

      protected void send_integrity_lvl_hashes1388( )
      {
      }

      protected void send_integrity_lvl_hashes1387( )
      {
      }

      protected void SubsflControlProps_10688( )
      {
         edtingreBodDetId_Internalname = "INGREBODDETID_"+sGXsfl_106_idx;
         edtPrdCod_Internalname = "PRDCOD_"+sGXsfl_106_idx;
         imgprompt_286_Internalname = "PROMPT_286_"+sGXsfl_106_idx;
         edtPrdDescCorta_Internalname = "PRDDESCCORTA_"+sGXsfl_106_idx;
         edtingreBodDetCant_Internalname = "INGREBODDETCANT_"+sGXsfl_106_idx;
         edtingreBodDetVal_Internalname = "INGREBODDETVAL_"+sGXsfl_106_idx;
         edtIngBodDetValTot_Internalname = "INGBODDETVALTOT_"+sGXsfl_106_idx;
         edtingreBodDetFch_Internalname = "INGREBODDETFCH_"+sGXsfl_106_idx;
      }

      protected void SubsflControlProps_fel_10688( )
      {
         edtingreBodDetId_Internalname = "INGREBODDETID_"+sGXsfl_106_fel_idx;
         edtPrdCod_Internalname = "PRDCOD_"+sGXsfl_106_fel_idx;
         imgprompt_286_Internalname = "PROMPT_286_"+sGXsfl_106_fel_idx;
         edtPrdDescCorta_Internalname = "PRDDESCCORTA_"+sGXsfl_106_fel_idx;
         edtingreBodDetCant_Internalname = "INGREBODDETCANT_"+sGXsfl_106_fel_idx;
         edtingreBodDetVal_Internalname = "INGREBODDETVAL_"+sGXsfl_106_fel_idx;
         edtIngBodDetValTot_Internalname = "INGBODDETVALTOT_"+sGXsfl_106_fel_idx;
         edtingreBodDetFch_Internalname = "INGREBODDETFCH_"+sGXsfl_106_fel_idx;
      }

      protected void AddRow1388( )
      {
         nGXsfl_106_idx = (short)(nGXsfl_106_idx+1);
         sGXsfl_106_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_106_idx), 4, 0)), 4, "0");
         SubsflControlProps_10688( ) ;
         SendRow1388( ) ;
      }

      protected void SendRow1388( )
      {
         Gridingresobodegas_ingreboddetRow = GXWebRow.GetNew(context);
         if ( subGridingresobodegas_ingreboddet_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridingresobodegas_ingreboddet_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridingresobodegas_ingreboddet_Class, "") != 0 )
            {
               subGridingresobodegas_ingreboddet_Linesclass = subGridingresobodegas_ingreboddet_Class+"Odd";
            }
         }
         else if ( subGridingresobodegas_ingreboddet_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridingresobodegas_ingreboddet_Backstyle = 0;
            subGridingresobodegas_ingreboddet_Backcolor = subGridingresobodegas_ingreboddet_Allbackcolor;
            if ( StringUtil.StrCmp(subGridingresobodegas_ingreboddet_Class, "") != 0 )
            {
               subGridingresobodegas_ingreboddet_Linesclass = subGridingresobodegas_ingreboddet_Class+"Uniform";
            }
         }
         else if ( subGridingresobodegas_ingreboddet_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridingresobodegas_ingreboddet_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridingresobodegas_ingreboddet_Class, "") != 0 )
            {
               subGridingresobodegas_ingreboddet_Linesclass = subGridingresobodegas_ingreboddet_Class+"Odd";
            }
            subGridingresobodegas_ingreboddet_Backcolor = (int)(0x0);
         }
         else if ( subGridingresobodegas_ingreboddet_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridingresobodegas_ingreboddet_Backstyle = 1;
            if ( ((int)(((nGXsfl_106_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridingresobodegas_ingreboddet_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridingresobodegas_ingreboddet_Class, "") != 0 )
               {
                  subGridingresobodegas_ingreboddet_Linesclass = subGridingresobodegas_ingreboddet_Class+"Odd";
               }
            }
            else
            {
               subGridingresobodegas_ingreboddet_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridingresobodegas_ingreboddet_Class, "") != 0 )
               {
                  subGridingresobodegas_ingreboddet_Linesclass = subGridingresobodegas_ingreboddet_Class+"Even";
               }
            }
         }
         imgprompt_286_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0202.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"PRDCOD_"+sGXsfl_106_idx+"'), id:'"+"PRDCOD_"+sGXsfl_106_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_88_"+sGXsfl_106_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridingresobodegas_ingreboddetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingreBodDetId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A369ingreBodDetId), 4, 0, ",", "")),((edtingreBodDetId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A369ingreBodDetId), "ZZZ9")) : context.localUtil.Format( (decimal)(A369ingreBodDetId), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingreBodDetId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtingreBodDetId_Enabled,(short)0,(String)"number",(String)"1",(short)60,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)106,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_88_" + sGXsfl_106_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 108,'',false,'" + sGXsfl_106_idx + "',106)\"";
         ROClassString = "Attribute";
         Gridingresobodegas_ingreboddetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrdCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", "")),((edtPrdCod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")) : context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,108);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrdCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPrdCod_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)106,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridingresobodegas_ingreboddetRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_286_Internalname,(String)sImgUrl,(String)imgprompt_286_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_286_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridingresobodegas_ingreboddetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrdDescCorta_Internalname,(String)A306PrdDescCorta,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrdDescCorta_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPrdDescCorta_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)106,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_88_" + sGXsfl_106_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 110,'',false,'" + sGXsfl_106_idx + "',106)\"";
         ROClassString = "Attribute";
         Gridingresobodegas_ingreboddetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingreBodDetCant_Internalname,StringUtil.LTrim( StringUtil.NToC( A370ingreBodDetCant, 8, 2, ",", "")),((edtingreBodDetCant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A370ingreBodDetCant, "ZZZZ9.99")) : context.localUtil.Format( A370ingreBodDetCant, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,110);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingreBodDetCant_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtingreBodDetCant_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)106,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_88_" + sGXsfl_106_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 111,'',false,'" + sGXsfl_106_idx + "',106)\"";
         ROClassString = "Attribute";
         Gridingresobodegas_ingreboddetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingreBodDetVal_Internalname,StringUtil.LTrim( StringUtil.NToC( A371ingreBodDetVal, 8, 2, ",", "")),((edtingreBodDetVal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A371ingreBodDetVal, "ZZZZ9.99")) : context.localUtil.Format( A371ingreBodDetVal, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,111);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingreBodDetVal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtingreBodDetVal_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)106,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridingresobodegas_ingreboddetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtIngBodDetValTot_Internalname,StringUtil.LTrim( StringUtil.NToC( A393IngBodDetValTot, 13, 2, ",", "")),((edtIngBodDetValTot_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A393IngBodDetValTot, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A393IngBodDetValTot, "ZZ,ZZZ,ZZZ.ZZ")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtIngBodDetValTot_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtIngBodDetValTot_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)106,(short)1,(short)-1,(short)0,(bool)true,(String)"valores",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_88_" + sGXsfl_106_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 113,'',false,'" + sGXsfl_106_idx + "',106)\"";
         ROClassString = "Attribute";
         Gridingresobodegas_ingreboddetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingreBodDetFch_Internalname,context.localUtil.Format(A372ingreBodDetFch, "99/99/9999"),context.localUtil.Format( A372ingreBodDetFch, "99/99/9999"),TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,113);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingreBodDetFch_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtingreBodDetFch_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)106,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridingresobodegas_ingreboddetRow);
         send_integrity_lvl_hashes1388( ) ;
         GXCCtl = "Z369ingreBodDetId_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z369ingreBodDetId), 4, 0, ",", "")));
         GXCCtl = "Z372ingreBodDetFch_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z372ingreBodDetFch, 0, "/"));
         GXCCtl = "Z370ingreBodDetCant_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z370ingreBodDetCant, 8, 2, ",", "")));
         GXCCtl = "Z371ingreBodDetVal_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z371ingreBodDetVal, 8, 2, ",", "")));
         GXCCtl = "Z286PrdCod_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", "")));
         GXCCtl = "O393IngBodDetValTot_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O393IngBodDetValTot, 10, 2, ",", "")));
         GXCCtl = "O370ingreBodDetCant_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O370ingreBodDetCant, 8, 2, ",", "")));
         GXCCtl = "nRcdDeleted_88_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_88), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_88_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_88), 4, 0, ",", "")));
         GXCCtl = "nIsMod_88_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_88), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_106_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV11TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GXCCtl = "vAGEID_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8AgeID), 4, 0, ",", "")));
         GXCCtl = "vINGREBODNRO_" + sGXsfl_106_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9ingreBodNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "INGREBODDETID_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRDCOD_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRDDESCCORTA_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdDescCorta_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGREBODDETCANT_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetCant_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGREBODDETVAL_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetVal_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGBODDETVALTOT_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtIngBodDetValTot_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGREBODDETFCH_"+sGXsfl_106_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingreBodDetFch_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_286_"+sGXsfl_106_idx+"Link", StringUtil.RTrim( imgprompt_286_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridingresobodegas_ingreboddetContainer.AddRow(Gridingresobodegas_ingreboddetRow);
      }

      protected void ReadRow1388( )
      {
         nGXsfl_106_idx = (short)(nGXsfl_106_idx+1);
         sGXsfl_106_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_106_idx), 4, 0)), 4, "0");
         SubsflControlProps_10688( ) ;
         edtingreBodDetId_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGREBODDETID_"+sGXsfl_106_idx+"Enabled"), ",", "."));
         edtPrdCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDCOD_"+sGXsfl_106_idx+"Enabled"), ",", "."));
         edtPrdDescCorta_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDDESCCORTA_"+sGXsfl_106_idx+"Enabled"), ",", "."));
         edtingreBodDetCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGREBODDETCANT_"+sGXsfl_106_idx+"Enabled"), ",", "."));
         edtingreBodDetVal_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGREBODDETVAL_"+sGXsfl_106_idx+"Enabled"), ",", "."));
         edtIngBodDetValTot_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGBODDETVALTOT_"+sGXsfl_106_idx+"Enabled"), ",", "."));
         edtingreBodDetFch_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGREBODDETFCH_"+sGXsfl_106_idx+"Enabled"), ",", "."));
         imgprompt_1_Link = cgiGet( "PROMPT_286_"+sGXsfl_106_idx+"Link");
         A369ingreBodDetId = (short)(context.localUtil.CToN( cgiGet( edtingreBodDetId_Internalname), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_106_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
            wbErr = true;
            A286PrdCod = 0;
         }
         else
         {
            A286PrdCod = (short)(context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", "."));
         }
         A306PrdDescCorta = cgiGet( edtPrdDescCorta_Internalname);
         n306PrdDescCorta = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtingreBodDetCant_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtingreBodDetCant_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "INGREBODDETCANT_" + sGXsfl_106_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtingreBodDetCant_Internalname;
            wbErr = true;
            A370ingreBodDetCant = 0;
            n370ingreBodDetCant = false;
         }
         else
         {
            A370ingreBodDetCant = context.localUtil.CToN( cgiGet( edtingreBodDetCant_Internalname), ",", ".");
            n370ingreBodDetCant = false;
         }
         n370ingreBodDetCant = ((Convert.ToDecimal(0)==A370ingreBodDetCant) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtingreBodDetVal_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtingreBodDetVal_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "INGREBODDETVAL_" + sGXsfl_106_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtingreBodDetVal_Internalname;
            wbErr = true;
            A371ingreBodDetVal = 0;
            n371ingreBodDetVal = false;
         }
         else
         {
            A371ingreBodDetVal = context.localUtil.CToN( cgiGet( edtingreBodDetVal_Internalname), ",", ".");
            n371ingreBodDetVal = false;
         }
         n371ingreBodDetVal = ((Convert.ToDecimal(0)==A371ingreBodDetVal) ? true : false);
         A393IngBodDetValTot = context.localUtil.CToN( cgiGet( edtIngBodDetValTot_Internalname), ",", ".");
         if ( context.localUtil.VCDate( cgiGet( edtingreBodDetFch_Internalname), 2) == 0 )
         {
            GXCCtl = "INGREBODDETFCH_" + sGXsfl_106_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtingreBodDetFch_Internalname;
            wbErr = true;
            A372ingreBodDetFch = DateTime.MinValue;
            n372ingreBodDetFch = false;
         }
         else
         {
            A372ingreBodDetFch = context.localUtil.CToD( cgiGet( edtingreBodDetFch_Internalname), 2);
            n372ingreBodDetFch = false;
         }
         n372ingreBodDetFch = ((DateTime.MinValue==A372ingreBodDetFch) ? true : false);
         GXCCtl = "Z369ingreBodDetId_" + sGXsfl_106_idx;
         Z369ingreBodDetId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z372ingreBodDetFch_" + sGXsfl_106_idx;
         Z372ingreBodDetFch = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         n372ingreBodDetFch = ((DateTime.MinValue==A372ingreBodDetFch) ? true : false);
         GXCCtl = "Z370ingreBodDetCant_" + sGXsfl_106_idx;
         Z370ingreBodDetCant = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n370ingreBodDetCant = ((Convert.ToDecimal(0)==A370ingreBodDetCant) ? true : false);
         GXCCtl = "Z371ingreBodDetVal_" + sGXsfl_106_idx;
         Z371ingreBodDetVal = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n371ingreBodDetVal = ((Convert.ToDecimal(0)==A371ingreBodDetVal) ? true : false);
         GXCCtl = "Z286PrdCod_" + sGXsfl_106_idx;
         Z286PrdCod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "O393IngBodDetValTot_" + sGXsfl_106_idx;
         O393IngBodDetValTot = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         GXCCtl = "O370ingreBodDetCant_" + sGXsfl_106_idx;
         O370ingreBodDetCant = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n370ingreBodDetCant = ((Convert.ToDecimal(0)==A370ingreBodDetCant) ? true : false);
         GXCCtl = "nRcdDeleted_88_" + sGXsfl_106_idx;
         nRcdDeleted_88 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_88_" + sGXsfl_106_idx;
         nRcdExists_88 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_88_" + sGXsfl_106_idx;
         nIsMod_88 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtingreBodDetId_Enabled = edtingreBodDetId_Enabled;
      }

      protected void ConfirmValues130( )
      {
         nGXsfl_106_idx = 0;
         sGXsfl_106_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_106_idx), 4, 0)), 4, "0");
         SubsflControlProps_10688( ) ;
         while ( nGXsfl_106_idx < nRC_GXsfl_106 )
         {
            nGXsfl_106_idx = (short)(nGXsfl_106_idx+1);
            sGXsfl_106_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_106_idx), 4, 0)), 4, "0");
            SubsflControlProps_10688( ) ;
            ChangePostValue( "Z369ingreBodDetId_"+sGXsfl_106_idx, cgiGet( "ZT_"+"Z369ingreBodDetId_"+sGXsfl_106_idx)) ;
            DeletePostValue( "ZT_"+"Z369ingreBodDetId_"+sGXsfl_106_idx) ;
            ChangePostValue( "Z372ingreBodDetFch_"+sGXsfl_106_idx, cgiGet( "ZT_"+"Z372ingreBodDetFch_"+sGXsfl_106_idx)) ;
            DeletePostValue( "ZT_"+"Z372ingreBodDetFch_"+sGXsfl_106_idx) ;
            ChangePostValue( "Z370ingreBodDetCant_"+sGXsfl_106_idx, cgiGet( "ZT_"+"Z370ingreBodDetCant_"+sGXsfl_106_idx)) ;
            DeletePostValue( "ZT_"+"Z370ingreBodDetCant_"+sGXsfl_106_idx) ;
            ChangePostValue( "Z371ingreBodDetVal_"+sGXsfl_106_idx, cgiGet( "ZT_"+"Z371ingreBodDetVal_"+sGXsfl_106_idx)) ;
            DeletePostValue( "ZT_"+"Z371ingreBodDetVal_"+sGXsfl_106_idx) ;
            ChangePostValue( "Z286PrdCod_"+sGXsfl_106_idx, cgiGet( "ZT_"+"Z286PrdCod_"+sGXsfl_106_idx)) ;
            DeletePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_106_idx) ;
         }
         ChangePostValue( "O393IngBodDetValTot", cgiGet( "T393IngBodDetValTot")) ;
         DeletePostValue( "T393IngBodDetValTot") ;
         ChangePostValue( "O370ingreBodDetCant", cgiGet( "T370ingreBodDetCant")) ;
         DeletePostValue( "T370ingreBodDetCant") ;
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
         context.SendWebValue( "Ingreso Bodegas") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022122719195826", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("ingresobodegas.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8AgeID) + "," + UrlEncode("" +AV9ingreBodNro)+"\">") ;
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
         forbiddenHiddens = "hsh" + "IngresoBodegas";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV13Insert_PrvRuc, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("ingresobodegas:[SendSecurityCheck value for]"+"Insert_PrvRuc:"+StringUtil.RTrim( context.localUtil.Format( AV13Insert_PrvRuc, "")));
         GXUtil.WriteLog("ingresobodegas:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z2AgeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z364ingreBodNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z364ingreBodNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z365ingreBodDsc", StringUtil.RTrim( Z365ingreBodDsc));
         GxWebStd.gx_hidden_field( context, "Z366ingreBodFch", context.localUtil.DToC( Z366ingreBodFch, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z367ingreBodTipo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z367ingreBodTipo), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z368ingreBodNroFac", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z368ingreBodNroFac), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z373ingreBodUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z373ingreBodUltNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z37PrvRuc", StringUtil.RTrim( Z37PrvRuc));
         GxWebStd.gx_hidden_field( context, "O373ingreBodUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(O373ingreBodUltNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O378ingBodTotValor", StringUtil.LTrim( StringUtil.NToC( O378ingBodTotValor, 8, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "O377ingBodTotCant", StringUtil.LTrim( StringUtil.NToC( O377ingBodTotCant, 8, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_106", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_106_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N37PrvRuc", StringUtil.RTrim( A37PrvRuc));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "INGBODVALIVA", StringUtil.LTrim( StringUtil.NToC( A395ingBodValIVA, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINGREBODNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9ingreBodNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vINGREBODNRO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9ingreBodNro), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_PRVRUC", StringUtil.RTrim( AV13Insert_PrvRuc));
         GxWebStd.gx_hidden_field( context, "INGREBODULTNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A373ingreBodUltNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV16Pgmname));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm1387( )
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
         return "IngresoBodegas" ;
      }

      public override String GetPgmdesc( )
      {
         return "Ingreso Bodegas" ;
      }

      protected void InitializeNonKey1387( )
      {
         A37PrvRuc = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PrvRuc", A37PrvRuc);
         A395ingBodValIVA = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395ingBodValIVA", StringUtil.LTrim( StringUtil.Str( A395ingBodValIVA, 10, 2)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A46AgeDsc = "";
         n46AgeDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         A365ingreBodDsc = "";
         n365ingreBodDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365ingreBodDsc", A365ingreBodDsc);
         n365ingreBodDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A365ingreBodDsc)) ? true : false);
         A366ingreBodFch = DateTime.MinValue;
         n366ingreBodFch = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366ingreBodFch", context.localUtil.Format(A366ingreBodFch, "99/99/9999"));
         n366ingreBodFch = ((DateTime.MinValue==A366ingreBodFch) ? true : false);
         A367ingreBodTipo = 0;
         n367ingreBodTipo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367ingreBodTipo", StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0));
         n367ingreBodTipo = ((0==A367ingreBodTipo) ? true : false);
         A368ingreBodNroFac = 0;
         n368ingreBodNroFac = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368ingreBodNroFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A368ingreBodNroFac), 4, 0)));
         n368ingreBodNroFac = ((0==A368ingreBodNroFac) ? true : false);
         A184PrvDsc = "";
         n184PrvDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184PrvDsc", A184PrvDsc);
         A373ingreBodUltNro = 0;
         n373ingreBodUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
         A377ingBodTotCant = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
         A378ingBodTotValor = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         A394ingBodTotNeto = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ingBodTotNeto", StringUtil.LTrim( StringUtil.Str( A394ingBodTotNeto, 10, 2)));
         O373ingreBodUltNro = A373ingreBodUltNro;
         n373ingreBodUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
         O378ingBodTotValor = A378ingBodTotValor;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378ingBodTotValor", StringUtil.LTrim( StringUtil.Str( A378ingBodTotValor, 8, 2)));
         O377ingBodTotCant = A377ingBodTotCant;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A377ingBodTotCant", StringUtil.LTrim( StringUtil.Str( A377ingBodTotCant, 8, 2)));
         Z365ingreBodDsc = "";
         Z366ingreBodFch = DateTime.MinValue;
         Z367ingreBodTipo = 0;
         Z368ingreBodNroFac = 0;
         Z373ingreBodUltNro = 0;
         Z37PrvRuc = "";
      }

      protected void InitAll1387( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A2AgeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         A364ingreBodNro = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
         InitializeNonKey1387( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey1388( )
      {
         A393IngBodDetValTot = 0;
         A286PrdCod = 0;
         A306PrdDescCorta = "";
         n306PrdDescCorta = false;
         A372ingreBodDetFch = DateTime.MinValue;
         n372ingreBodDetFch = false;
         A370ingreBodDetCant = 0;
         n370ingreBodDetCant = false;
         A371ingreBodDetVal = 0;
         n371ingreBodDetVal = false;
         O393IngBodDetValTot = A393IngBodDetValTot;
         O370ingreBodDetCant = A370ingreBodDetCant;
         n370ingreBodDetCant = false;
         Z372ingreBodDetFch = DateTime.MinValue;
         Z370ingreBodDetCant = 0;
         Z371ingreBodDetVal = 0;
         Z286PrdCod = 0;
      }

      protected void InitAll1388( )
      {
         A369ingreBodDetId = 0;
         InitializeNonKey1388( ) ;
      }

      protected void StandaloneModalInsert1388( )
      {
         A373ingreBodUltNro = i373ingreBodUltNro;
         n373ingreBodUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A373ingreBodUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A373ingreBodUltNro), 4, 0)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022122719195917", true);
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
         context.AddJavascriptSource("ingresobodegas.js", "?2022122719195919", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties88( )
      {
         edtingreBodDetId_Enabled = defedtingreBodDetId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingreBodDetId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingreBodDetId_Enabled), 5, 0)), !bGXsfl_106_Refreshing);
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
         edtempdsc_Internalname = "EMPDSC";
         edtAgeID_Internalname = "AGEID";
         edtAgeDsc_Internalname = "AGEDSC";
         divTable2_Internalname = "TABLE2";
         edtingreBodNro_Internalname = "INGREBODNRO";
         edtingreBodDsc_Internalname = "INGREBODDSC";
         edtPrvRuc_Internalname = "PRVRUC";
         edtPrvDsc_Internalname = "PRVDSC";
         divTable1_Internalname = "TABLE1";
         edtingreBodFch_Internalname = "INGREBODFCH";
         cmbingreBodTipo_Internalname = "INGREBODTIPO";
         edtingreBodNroFac_Internalname = "INGREBODNROFAC";
         edtingBodTotCant_Internalname = "INGBODTOTCANT";
         divSection1_Internalname = "SECTION1";
         edtingBodTotValor_Internalname = "INGBODTOTVALOR";
         divSection2_Internalname = "SECTION2";
         edtingBodTotNeto_Internalname = "INGBODTOTNETO";
         divSection3_Internalname = "SECTION3";
         lblTitleingreboddet_Internalname = "TITLEINGREBODDET";
         edtingreBodDetId_Internalname = "INGREBODDETID";
         edtPrdCod_Internalname = "PRDCOD";
         edtPrdDescCorta_Internalname = "PRDDESCCORTA";
         edtingreBodDetCant_Internalname = "INGREBODDETCANT";
         edtingreBodDetVal_Internalname = "INGREBODDETVAL";
         edtIngBodDetValTot_Internalname = "INGBODDETVALTOT";
         edtingreBodDetFch_Internalname = "INGREBODDETFCH";
         divIngreboddettable_Internalname = "INGREBODDETTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_2_Internalname = "PROMPT_2";
         imgprompt_37_Internalname = "PROMPT_37";
         imgprompt_286_Internalname = "PROMPT_286";
         subGridingresobodegas_ingreboddet_Internalname = "GRIDINGRESOBODEGAS_INGREBODDET";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtingreBodDetFch_Jsonclick = "";
         edtIngBodDetValTot_Jsonclick = "";
         edtingreBodDetVal_Jsonclick = "";
         edtingreBodDetCant_Jsonclick = "";
         edtPrdDescCorta_Jsonclick = "";
         imgprompt_286_Visible = 1;
         imgprompt_286_Link = "";
         imgprompt_1_Visible = 1;
         edtPrdCod_Jsonclick = "";
         edtingreBodDetId_Jsonclick = "";
         subGridingresobodegas_ingreboddet_Class = "Grid";
         subGridingresobodegas_ingreboddet_Backcolorstyle = 0;
         subGridingresobodegas_ingreboddet_Allowcollapsing = 0;
         subGridingresobodegas_ingreboddet_Allowselection = 0;
         edtingreBodDetFch_Enabled = 1;
         edtIngBodDetValTot_Enabled = 0;
         edtingreBodDetVal_Enabled = 1;
         edtingreBodDetCant_Enabled = 1;
         edtPrdDescCorta_Enabled = 0;
         edtPrdCod_Enabled = 1;
         edtingreBodDetId_Enabled = 0;
         subGridingresobodegas_ingreboddet_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtingBodTotNeto_Jsonclick = "";
         edtingBodTotNeto_Enabled = 0;
         edtingBodTotValor_Jsonclick = "";
         edtingBodTotValor_Enabled = 0;
         edtingBodTotCant_Jsonclick = "";
         edtingBodTotCant_Enabled = 0;
         edtingreBodNroFac_Jsonclick = "";
         edtingreBodNroFac_Enabled = 1;
         edtingreBodNroFac_Caption = "Fac";
         cmbingreBodTipo_Jsonclick = "";
         cmbingreBodTipo.Enabled = 1;
         edtingreBodFch_Jsonclick = "";
         edtingreBodFch_Enabled = 1;
         edtPrvDsc_Jsonclick = "";
         edtPrvDsc_Enabled = 0;
         imgprompt_37_Visible = 1;
         imgprompt_37_Link = "";
         edtPrvRuc_Jsonclick = "";
         edtPrvRuc_Enabled = 1;
         edtingreBodDsc_Jsonclick = "";
         edtingreBodDsc_Enabled = 1;
         edtingreBodNro_Jsonclick = "";
         edtingreBodNro_Enabled = 1;
         edtAgeDsc_Jsonclick = "";
         edtAgeDsc_Enabled = 0;
         imgprompt_2_Visible = 1;
         imgprompt_2_Link = "";
         edtAgeID_Jsonclick = "";
         edtAgeID_Enabled = 1;
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

      protected void GX10ASAINGREBODNRO1387( short AV9ingreBodNro )
      {
         if ( ! (0==AV9ingreBodNro) )
         {
            A364ingreBodNro = AV9ingreBodNro;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A364ingreBodNro), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX11ASAINGREBODNRO1387( short AV7EmpID ,
                                             short AV8AgeID )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_int1 = A364ingreBodNro;
            new obtnextcod(context ).execute(  AV7EmpID,  AV8AgeID, out  GXt_int1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8AgeID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
            A364ingreBodNro = GXt_int1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364ingreBodNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A364ingreBodNro), 4, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A364ingreBodNro), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void gxnrGridingresobodegas_ingreboddet_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_10688( ) ;
         while ( nGXsfl_106_idx <= nRC_GXsfl_106 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1388( ) ;
            standaloneModal1388( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow1388( ) ;
            nGXsfl_106_idx = (short)(nGXsfl_106_idx+1);
            sGXsfl_106_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_106_idx), 4, 0)), 4, "0");
            SubsflControlProps_10688( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridingresobodegas_ingreboddetContainer));
         /* End function gxnrGridingresobodegas_ingreboddet_newrow */
      }

      protected void init_web_controls( )
      {
         cmbingreBodTipo.Name = "INGREBODTIPO";
         cmbingreBodTipo.WebTags = "";
         cmbingreBodTipo.addItem("0", "Seleccionar", 0);
         cmbingreBodTipo.addItem("1", "Con nro. Factura", 0);
         cmbingreBodTipo.addItem("2", "Con Nro. Guia", 0);
         cmbingreBodTipo.addItem("3", "Sin Factura/Guia", 0);
         if ( cmbingreBodTipo.ItemCount > 0 )
         {
            A367ingreBodTipo = (short)(NumberUtil.Val( cmbingreBodTipo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0))), "."));
            n367ingreBodTipo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367ingreBodTipo", StringUtil.Str( (decimal)(A367ingreBodTipo), 1, 0));
         }
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T001325 */
         pr_default.execute(20, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T001325_A44empdsc[0];
         n44empdsc = T001325_n44empdsc[0];
         pr_default.close(20);
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

      public void Valid_Ageid( short GX_Parm1 ,
                               short GX_Parm2 ,
                               String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         A2AgeID = GX_Parm2;
         A46AgeDsc = GX_Parm3;
         n46AgeDsc = false;
         /* Using cursor T001326 */
         pr_default.execute(21, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A46AgeDsc = T001326_A46AgeDsc[0];
         n46AgeDsc = T001326_n46AgeDsc[0];
         pr_default.close(21);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A46AgeDsc = "";
            n46AgeDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A46AgeDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Ingrebodnro( short GX_Parm1 ,
                                     short GX_Parm2 ,
                                     short GX_Parm3 ,
                                     decimal GX_Parm4 ,
                                     decimal GX_Parm5 ,
                                     decimal GX_Parm6 ,
                                     decimal GX_Parm7 )
      {
         A1EmpID = GX_Parm1;
         A2AgeID = GX_Parm2;
         A364ingreBodNro = GX_Parm3;
         A378ingBodTotValor = GX_Parm4;
         A395ingBodValIVA = GX_Parm5;
         A377ingBodTotCant = GX_Parm6;
         A394ingBodTotNeto = GX_Parm7;
         /* Using cursor T001328 */
         pr_default.execute(22, new Object[] {A1EmpID, A2AgeID, A364ingreBodNro});
         if ( (pr_default.getStatus(22) != 101) )
         {
            A377ingBodTotCant = T001328_A377ingBodTotCant[0];
            A378ingBodTotValor = T001328_A378ingBodTotValor[0];
         }
         else
         {
            A377ingBodTotCant = 0;
            A378ingBodTotValor = 0;
         }
         pr_default.close(22);
         A395ingBodValIVA = NumberUtil.Round( (A378ingBodTotValor*12)/ (decimal)(100), 2);
         A394ingBodTotNeto = NumberUtil.Round( (A378ingBodTotValor+A395ingBodValIVA), 2);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A377ingBodTotCant = 0;
            A378ingBodTotValor = 0;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A377ingBodTotCant, 8, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A378ingBodTotValor, 8, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A395ingBodValIVA, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A394ingBodTotNeto, 10, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Prvruc( String GX_Parm1 ,
                                String GX_Parm2 )
      {
         A37PrvRuc = GX_Parm1;
         A184PrvDsc = GX_Parm2;
         n184PrvDsc = false;
         /* Using cursor T001329 */
         pr_default.execute(23, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, "PRVRUC");
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
         }
         A184PrvDsc = T001329_A184PrvDsc[0];
         n184PrvDsc = T001329_n184PrvDsc[0];
         pr_default.close(23);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A184PrvDsc = "";
            n184PrvDsc = false;
         }
         isValidOutput.Add(A184PrvDsc);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Prdcod( short GX_Parm1 ,
                                short GX_Parm2 ,
                                short GX_Parm3 ,
                                String GX_Parm4 )
      {
         A1EmpID = GX_Parm1;
         A2AgeID = GX_Parm2;
         A286PrdCod = GX_Parm3;
         A306PrdDescCorta = GX_Parm4;
         n306PrdDescCorta = false;
         /* Using cursor T001338 */
         pr_default.execute(32, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(32) == 101) )
         {
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, "PRDCOD");
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
         }
         A306PrdDescCorta = T001338_A306PrdDescCorta[0];
         n306PrdDescCorta = T001338_n306PrdDescCorta[0];
         pr_default.close(32);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A306PrdDescCorta = "";
            n306PrdDescCorta = false;
         }
         isValidOutput.Add(A306PrdDescCorta);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV9ingreBodNro',fld:'vINGREBODNRO',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV9ingreBodNro',fld:'vINGREBODNRO',pic:'ZZZ9',hsh:true},{av:'AV13Insert_PrvRuc',fld:'vINSERT_PRVRUC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E13132',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("INGREBODTIPO.CLICK","{handler:'E111387',iparms:[{av:'cmbingreBodTipo'},{av:'A367ingreBodTipo',fld:'INGREBODTIPO',pic:'9'}]");
         setEventMetadata("INGREBODTIPO.CLICK",",oparms:[{av:'edtingreBodNroFac_Caption',ctrl:'INGREBODNROFAC',prop:'Caption'},{av:'edtingreBodNroFac_Enabled',ctrl:'INGREBODNROFAC',prop:'Enabled'},{av:'A368ingreBodNroFac',fld:'INGREBODNROFAC',pic:'ZZZ9'}]}");
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
         pr_default.close(32);
         pr_default.close(4);
         pr_default.close(20);
         pr_default.close(21);
         pr_default.close(23);
         pr_default.close(22);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z365ingreBodDsc = "";
         Z366ingreBodFch = DateTime.MinValue;
         Z37PrvRuc = "";
         N37PrvRuc = "";
         Z372ingreBodDetFch = DateTime.MinValue;
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A37PrvRuc = "";
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
         A46AgeDsc = "";
         A365ingreBodDsc = "";
         A184PrvDsc = "";
         A366ingreBodFch = DateTime.MinValue;
         lblTitleingreboddet_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridingresobodegas_ingreboddetContainer = new GXWebGrid( context);
         Gridingresobodegas_ingreboddetColumn = new GXWebColumn();
         A306PrdDescCorta = "";
         A372ingreBodDetFch = DateTime.MinValue;
         sMode88 = "";
         sStyleString = "";
         AV13Insert_PrvRuc = "";
         AV16Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode87 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV11TrnContext = new SdtTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z44empdsc = "";
         Z46AgeDsc = "";
         Z184PrvDsc = "";
         T00137_A44empdsc = new String[] {""} ;
         T00137_n44empdsc = new bool[] {false} ;
         T00138_A46AgeDsc = new String[] {""} ;
         T00138_n46AgeDsc = new bool[] {false} ;
         T001311_A377ingBodTotCant = new decimal[1] ;
         T001311_A378ingBodTotValor = new decimal[1] ;
         T00139_A184PrvDsc = new String[] {""} ;
         T00139_n184PrvDsc = new bool[] {false} ;
         T001313_A364ingreBodNro = new short[1] ;
         T001313_A44empdsc = new String[] {""} ;
         T001313_n44empdsc = new bool[] {false} ;
         T001313_A46AgeDsc = new String[] {""} ;
         T001313_n46AgeDsc = new bool[] {false} ;
         T001313_A365ingreBodDsc = new String[] {""} ;
         T001313_n365ingreBodDsc = new bool[] {false} ;
         T001313_A366ingreBodFch = new DateTime[] {DateTime.MinValue} ;
         T001313_n366ingreBodFch = new bool[] {false} ;
         T001313_A367ingreBodTipo = new short[1] ;
         T001313_n367ingreBodTipo = new bool[] {false} ;
         T001313_A368ingreBodNroFac = new short[1] ;
         T001313_n368ingreBodNroFac = new bool[] {false} ;
         T001313_A184PrvDsc = new String[] {""} ;
         T001313_n184PrvDsc = new bool[] {false} ;
         T001313_A373ingreBodUltNro = new short[1] ;
         T001313_n373ingreBodUltNro = new bool[] {false} ;
         T001313_A1EmpID = new short[1] ;
         T001313_A2AgeID = new short[1] ;
         T001313_A37PrvRuc = new String[] {""} ;
         T001313_A377ingBodTotCant = new decimal[1] ;
         T001313_A378ingBodTotValor = new decimal[1] ;
         T001314_A44empdsc = new String[] {""} ;
         T001314_n44empdsc = new bool[] {false} ;
         T001315_A46AgeDsc = new String[] {""} ;
         T001315_n46AgeDsc = new bool[] {false} ;
         T001317_A377ingBodTotCant = new decimal[1] ;
         T001317_A378ingBodTotValor = new decimal[1] ;
         T001318_A184PrvDsc = new String[] {""} ;
         T001318_n184PrvDsc = new bool[] {false} ;
         T001319_A1EmpID = new short[1] ;
         T001319_A2AgeID = new short[1] ;
         T001319_A364ingreBodNro = new short[1] ;
         T00136_A364ingreBodNro = new short[1] ;
         T00136_A365ingreBodDsc = new String[] {""} ;
         T00136_n365ingreBodDsc = new bool[] {false} ;
         T00136_A366ingreBodFch = new DateTime[] {DateTime.MinValue} ;
         T00136_n366ingreBodFch = new bool[] {false} ;
         T00136_A367ingreBodTipo = new short[1] ;
         T00136_n367ingreBodTipo = new bool[] {false} ;
         T00136_A368ingreBodNroFac = new short[1] ;
         T00136_n368ingreBodNroFac = new bool[] {false} ;
         T00136_A373ingreBodUltNro = new short[1] ;
         T00136_n373ingreBodUltNro = new bool[] {false} ;
         T00136_A1EmpID = new short[1] ;
         T00136_A2AgeID = new short[1] ;
         T00136_A37PrvRuc = new String[] {""} ;
         T001320_A1EmpID = new short[1] ;
         T001320_A2AgeID = new short[1] ;
         T001320_A364ingreBodNro = new short[1] ;
         T001321_A1EmpID = new short[1] ;
         T001321_A2AgeID = new short[1] ;
         T001321_A364ingreBodNro = new short[1] ;
         T00135_A364ingreBodNro = new short[1] ;
         T00135_A365ingreBodDsc = new String[] {""} ;
         T00135_n365ingreBodDsc = new bool[] {false} ;
         T00135_A366ingreBodFch = new DateTime[] {DateTime.MinValue} ;
         T00135_n366ingreBodFch = new bool[] {false} ;
         T00135_A367ingreBodTipo = new short[1] ;
         T00135_n367ingreBodTipo = new bool[] {false} ;
         T00135_A368ingreBodNroFac = new short[1] ;
         T00135_n368ingreBodNroFac = new bool[] {false} ;
         T00135_A373ingreBodUltNro = new short[1] ;
         T00135_n373ingreBodUltNro = new bool[] {false} ;
         T00135_A1EmpID = new short[1] ;
         T00135_A2AgeID = new short[1] ;
         T00135_A37PrvRuc = new String[] {""} ;
         T001325_A44empdsc = new String[] {""} ;
         T001325_n44empdsc = new bool[] {false} ;
         T001326_A46AgeDsc = new String[] {""} ;
         T001326_n46AgeDsc = new bool[] {false} ;
         T001328_A377ingBodTotCant = new decimal[1] ;
         T001328_A378ingBodTotValor = new decimal[1] ;
         T001329_A184PrvDsc = new String[] {""} ;
         T001329_n184PrvDsc = new bool[] {false} ;
         T001331_A1EmpID = new short[1] ;
         T001331_A2AgeID = new short[1] ;
         T001331_A364ingreBodNro = new short[1] ;
         Z306PrdDescCorta = "";
         T001332_A364ingreBodNro = new short[1] ;
         T001332_A369ingreBodDetId = new short[1] ;
         T001332_A306PrdDescCorta = new String[] {""} ;
         T001332_n306PrdDescCorta = new bool[] {false} ;
         T001332_A372ingreBodDetFch = new DateTime[] {DateTime.MinValue} ;
         T001332_n372ingreBodDetFch = new bool[] {false} ;
         T001332_A370ingreBodDetCant = new decimal[1] ;
         T001332_n370ingreBodDetCant = new bool[] {false} ;
         T001332_A371ingreBodDetVal = new decimal[1] ;
         T001332_n371ingreBodDetVal = new bool[] {false} ;
         T001332_A1EmpID = new short[1] ;
         T001332_A2AgeID = new short[1] ;
         T001332_A286PrdCod = new short[1] ;
         T00134_A306PrdDescCorta = new String[] {""} ;
         T00134_n306PrdDescCorta = new bool[] {false} ;
         GXCCtl = "";
         T001333_A306PrdDescCorta = new String[] {""} ;
         T001333_n306PrdDescCorta = new bool[] {false} ;
         T001334_A1EmpID = new short[1] ;
         T001334_A2AgeID = new short[1] ;
         T001334_A364ingreBodNro = new short[1] ;
         T001334_A369ingreBodDetId = new short[1] ;
         T00133_A364ingreBodNro = new short[1] ;
         T00133_A369ingreBodDetId = new short[1] ;
         T00133_A372ingreBodDetFch = new DateTime[] {DateTime.MinValue} ;
         T00133_n372ingreBodDetFch = new bool[] {false} ;
         T00133_A370ingreBodDetCant = new decimal[1] ;
         T00133_n370ingreBodDetCant = new bool[] {false} ;
         T00133_A371ingreBodDetVal = new decimal[1] ;
         T00133_n371ingreBodDetVal = new bool[] {false} ;
         T00133_A1EmpID = new short[1] ;
         T00133_A2AgeID = new short[1] ;
         T00133_A286PrdCod = new short[1] ;
         T00132_A364ingreBodNro = new short[1] ;
         T00132_A369ingreBodDetId = new short[1] ;
         T00132_A372ingreBodDetFch = new DateTime[] {DateTime.MinValue} ;
         T00132_n372ingreBodDetFch = new bool[] {false} ;
         T00132_A370ingreBodDetCant = new decimal[1] ;
         T00132_n370ingreBodDetCant = new bool[] {false} ;
         T00132_A371ingreBodDetVal = new decimal[1] ;
         T00132_n371ingreBodDetVal = new bool[] {false} ;
         T00132_A1EmpID = new short[1] ;
         T00132_A2AgeID = new short[1] ;
         T00132_A286PrdCod = new short[1] ;
         T001338_A306PrdDescCorta = new String[] {""} ;
         T001338_n306PrdDescCorta = new bool[] {false} ;
         T001339_A1EmpID = new short[1] ;
         T001339_A2AgeID = new short[1] ;
         T001339_A364ingreBodNro = new short[1] ;
         T001339_A369ingreBodDetId = new short[1] ;
         Gridingresobodegas_ingreboddetRow = new GXWebRow();
         subGridingresobodegas_ingreboddet_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ingresobodegas__default(),
            new Object[][] {
                new Object[] {
               T00132_A364ingreBodNro, T00132_A369ingreBodDetId, T00132_A372ingreBodDetFch, T00132_n372ingreBodDetFch, T00132_A370ingreBodDetCant, T00132_n370ingreBodDetCant, T00132_A371ingreBodDetVal, T00132_n371ingreBodDetVal, T00132_A1EmpID, T00132_A2AgeID,
               T00132_A286PrdCod
               }
               , new Object[] {
               T00133_A364ingreBodNro, T00133_A369ingreBodDetId, T00133_A372ingreBodDetFch, T00133_n372ingreBodDetFch, T00133_A370ingreBodDetCant, T00133_n370ingreBodDetCant, T00133_A371ingreBodDetVal, T00133_n371ingreBodDetVal, T00133_A1EmpID, T00133_A2AgeID,
               T00133_A286PrdCod
               }
               , new Object[] {
               T00134_A306PrdDescCorta, T00134_n306PrdDescCorta
               }
               , new Object[] {
               T00135_A364ingreBodNro, T00135_A365ingreBodDsc, T00135_n365ingreBodDsc, T00135_A366ingreBodFch, T00135_n366ingreBodFch, T00135_A367ingreBodTipo, T00135_n367ingreBodTipo, T00135_A368ingreBodNroFac, T00135_n368ingreBodNroFac, T00135_A373ingreBodUltNro,
               T00135_n373ingreBodUltNro, T00135_A1EmpID, T00135_A2AgeID, T00135_A37PrvRuc
               }
               , new Object[] {
               T00136_A364ingreBodNro, T00136_A365ingreBodDsc, T00136_n365ingreBodDsc, T00136_A366ingreBodFch, T00136_n366ingreBodFch, T00136_A367ingreBodTipo, T00136_n367ingreBodTipo, T00136_A368ingreBodNroFac, T00136_n368ingreBodNroFac, T00136_A373ingreBodUltNro,
               T00136_n373ingreBodUltNro, T00136_A1EmpID, T00136_A2AgeID, T00136_A37PrvRuc
               }
               , new Object[] {
               T00137_A44empdsc, T00137_n44empdsc
               }
               , new Object[] {
               T00138_A46AgeDsc, T00138_n46AgeDsc
               }
               , new Object[] {
               T00139_A184PrvDsc, T00139_n184PrvDsc
               }
               , new Object[] {
               T001311_A377ingBodTotCant, T001311_A378ingBodTotValor
               }
               , new Object[] {
               T001313_A364ingreBodNro, T001313_A44empdsc, T001313_n44empdsc, T001313_A46AgeDsc, T001313_n46AgeDsc, T001313_A365ingreBodDsc, T001313_n365ingreBodDsc, T001313_A366ingreBodFch, T001313_n366ingreBodFch, T001313_A367ingreBodTipo,
               T001313_n367ingreBodTipo, T001313_A368ingreBodNroFac, T001313_n368ingreBodNroFac, T001313_A184PrvDsc, T001313_n184PrvDsc, T001313_A373ingreBodUltNro, T001313_n373ingreBodUltNro, T001313_A1EmpID, T001313_A2AgeID, T001313_A37PrvRuc,
               T001313_A377ingBodTotCant, T001313_A378ingBodTotValor
               }
               , new Object[] {
               T001314_A44empdsc, T001314_n44empdsc
               }
               , new Object[] {
               T001315_A46AgeDsc, T001315_n46AgeDsc
               }
               , new Object[] {
               T001317_A377ingBodTotCant, T001317_A378ingBodTotValor
               }
               , new Object[] {
               T001318_A184PrvDsc, T001318_n184PrvDsc
               }
               , new Object[] {
               T001319_A1EmpID, T001319_A2AgeID, T001319_A364ingreBodNro
               }
               , new Object[] {
               T001320_A1EmpID, T001320_A2AgeID, T001320_A364ingreBodNro
               }
               , new Object[] {
               T001321_A1EmpID, T001321_A2AgeID, T001321_A364ingreBodNro
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001325_A44empdsc, T001325_n44empdsc
               }
               , new Object[] {
               T001326_A46AgeDsc, T001326_n46AgeDsc
               }
               , new Object[] {
               T001328_A377ingBodTotCant, T001328_A378ingBodTotValor
               }
               , new Object[] {
               T001329_A184PrvDsc, T001329_n184PrvDsc
               }
               , new Object[] {
               }
               , new Object[] {
               T001331_A1EmpID, T001331_A2AgeID, T001331_A364ingreBodNro
               }
               , new Object[] {
               T001332_A364ingreBodNro, T001332_A369ingreBodDetId, T001332_A306PrdDescCorta, T001332_n306PrdDescCorta, T001332_A372ingreBodDetFch, T001332_n372ingreBodDetFch, T001332_A370ingreBodDetCant, T001332_n370ingreBodDetCant, T001332_A371ingreBodDetVal, T001332_n371ingreBodDetVal,
               T001332_A1EmpID, T001332_A2AgeID, T001332_A286PrdCod
               }
               , new Object[] {
               T001333_A306PrdDescCorta, T001333_n306PrdDescCorta
               }
               , new Object[] {
               T001334_A1EmpID, T001334_A2AgeID, T001334_A364ingreBodNro, T001334_A369ingreBodDetId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001338_A306PrdDescCorta, T001338_n306PrdDescCorta
               }
               , new Object[] {
               T001339_A1EmpID, T001339_A2AgeID, T001339_A364ingreBodNro, T001339_A369ingreBodDetId
               }
            }
         );
         AV16Pgmname = "IngresoBodegas";
      }

      private short nIsMod_88 ;
      private short wcpOAV7EmpID ;
      private short wcpOAV8AgeID ;
      private short wcpOAV9ingreBodNro ;
      private short Z1EmpID ;
      private short Z2AgeID ;
      private short Z364ingreBodNro ;
      private short Z367ingreBodTipo ;
      private short Z368ingreBodNroFac ;
      private short Z373ingreBodUltNro ;
      private short O373ingreBodUltNro ;
      private short nRC_GXsfl_106 ;
      private short nGXsfl_106_idx=1 ;
      private short Z369ingreBodDetId ;
      private short Z286PrdCod ;
      private short nRcdDeleted_88 ;
      private short nRcdExists_88 ;
      private short GxWebError ;
      private short AV9ingreBodNro ;
      private short AV7EmpID ;
      private short AV8AgeID ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short A364ingreBodNro ;
      private short A286PrdCod ;
      private short A373ingreBodUltNro ;
      private short Gx_BScreen ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A367ingreBodTipo ;
      private short A368ingreBodNroFac ;
      private short subGridingresobodegas_ingreboddet_Backcolorstyle ;
      private short A369ingreBodDetId ;
      private short subGridingresobodegas_ingreboddet_Allowselection ;
      private short subGridingresobodegas_ingreboddet_Allowhovering ;
      private short subGridingresobodegas_ingreboddet_Allowcollapsing ;
      private short subGridingresobodegas_ingreboddet_Collapsed ;
      private short nBlankRcdCount88 ;
      private short RcdFound88 ;
      private short B373ingreBodUltNro ;
      private short nBlankRcdUsr88 ;
      private short RcdFound87 ;
      private short s373ingreBodUltNro ;
      private short GX_JID ;
      private short subGridingresobodegas_ingreboddet_Backstyle ;
      private short i373ingreBodUltNro ;
      private short GXt_int1 ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtempdsc_Enabled ;
      private int edtAgeID_Enabled ;
      private int imgprompt_2_Visible ;
      private int edtAgeDsc_Enabled ;
      private int edtingreBodNro_Enabled ;
      private int edtingreBodDsc_Enabled ;
      private int edtPrvRuc_Enabled ;
      private int imgprompt_37_Visible ;
      private int edtPrvDsc_Enabled ;
      private int edtingreBodFch_Enabled ;
      private int edtingreBodNroFac_Enabled ;
      private int edtingBodTotCant_Enabled ;
      private int edtingBodTotValor_Enabled ;
      private int edtingBodTotNeto_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtingreBodDetId_Enabled ;
      private int edtPrdCod_Enabled ;
      private int edtPrdDescCorta_Enabled ;
      private int edtingreBodDetCant_Enabled ;
      private int edtingreBodDetVal_Enabled ;
      private int edtIngBodDetValTot_Enabled ;
      private int edtingreBodDetFch_Enabled ;
      private int subGridingresobodegas_ingreboddet_Selectedindex ;
      private int subGridingresobodegas_ingreboddet_Selectioncolor ;
      private int subGridingresobodegas_ingreboddet_Hoveringcolor ;
      private int fRowAdded ;
      private int AV17GXV1 ;
      private int subGridingresobodegas_ingreboddet_Backcolor ;
      private int subGridingresobodegas_ingreboddet_Allbackcolor ;
      private int imgprompt_286_Visible ;
      private int defedtingreBodDetId_Enabled ;
      private int idxLst ;
      private long GRIDINGRESOBODEGAS_INGREBODDET_nFirstRecordOnPage ;
      private decimal O378ingBodTotValor ;
      private decimal O377ingBodTotCant ;
      private decimal Z370ingreBodDetCant ;
      private decimal Z371ingreBodDetVal ;
      private decimal O393IngBodDetValTot ;
      private decimal O370ingreBodDetCant ;
      private decimal A377ingBodTotCant ;
      private decimal A378ingBodTotValor ;
      private decimal A394ingBodTotNeto ;
      private decimal A370ingreBodDetCant ;
      private decimal A371ingreBodDetVal ;
      private decimal A393IngBodDetValTot ;
      private decimal B378ingBodTotValor ;
      private decimal B377ingBodTotCant ;
      private decimal A395ingBodValIVA ;
      private decimal s378ingBodTotValor ;
      private decimal s377ingBodTotCant ;
      private decimal s395ingBodValIVA ;
      private decimal O395ingBodValIVA ;
      private decimal T393IngBodDetValTot ;
      private decimal T370ingreBodDetCant ;
      private decimal Z377ingBodTotCant ;
      private decimal Z378ingBodTotValor ;
      private String sPrefix ;
      private String sGXsfl_106_idx="0001" ;
      private String wcpOGx_mode ;
      private String Z365ingreBodDsc ;
      private String Z37PrvRuc ;
      private String N37PrvRuc ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A37PrvRuc ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEmpID_Internalname ;
      private String cmbingreBodTipo_Internalname ;
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
      private String divTable2_Internalname ;
      private String edtEmpID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String edtAgeID_Internalname ;
      private String edtAgeID_Jsonclick ;
      private String imgprompt_2_Internalname ;
      private String imgprompt_2_Link ;
      private String edtAgeDsc_Internalname ;
      private String A46AgeDsc ;
      private String edtAgeDsc_Jsonclick ;
      private String edtingreBodNro_Internalname ;
      private String edtingreBodNro_Jsonclick ;
      private String edtingreBodDsc_Internalname ;
      private String A365ingreBodDsc ;
      private String edtingreBodDsc_Jsonclick ;
      private String divTable1_Internalname ;
      private String edtPrvRuc_Internalname ;
      private String edtPrvRuc_Jsonclick ;
      private String imgprompt_37_Internalname ;
      private String imgprompt_37_Link ;
      private String edtPrvDsc_Internalname ;
      private String edtPrvDsc_Jsonclick ;
      private String edtingreBodFch_Internalname ;
      private String edtingreBodFch_Jsonclick ;
      private String cmbingreBodTipo_Jsonclick ;
      private String edtingreBodNroFac_Internalname ;
      private String edtingreBodNroFac_Caption ;
      private String edtingreBodNroFac_Jsonclick ;
      private String divSection1_Internalname ;
      private String edtingBodTotCant_Internalname ;
      private String edtingBodTotCant_Jsonclick ;
      private String divSection2_Internalname ;
      private String edtingBodTotValor_Internalname ;
      private String edtingBodTotValor_Jsonclick ;
      private String divSection3_Internalname ;
      private String edtingBodTotNeto_Internalname ;
      private String edtingBodTotNeto_Jsonclick ;
      private String divIngreboddettable_Internalname ;
      private String lblTitleingreboddet_Internalname ;
      private String lblTitleingreboddet_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridingresobodegas_ingreboddet_Header ;
      private String sMode88 ;
      private String edtingreBodDetId_Internalname ;
      private String edtPrdCod_Internalname ;
      private String edtPrdDescCorta_Internalname ;
      private String edtingreBodDetCant_Internalname ;
      private String edtingreBodDetVal_Internalname ;
      private String edtIngBodDetValTot_Internalname ;
      private String edtingreBodDetFch_Internalname ;
      private String sStyleString ;
      private String AV13Insert_PrvRuc ;
      private String AV16Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode87 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z46AgeDsc ;
      private String GXCCtl ;
      private String imgprompt_286_Internalname ;
      private String sGXsfl_106_fel_idx="0001" ;
      private String subGridingresobodegas_ingreboddet_Class ;
      private String subGridingresobodegas_ingreboddet_Linesclass ;
      private String imgprompt_286_Link ;
      private String ROClassString ;
      private String edtingreBodDetId_Jsonclick ;
      private String edtPrdCod_Jsonclick ;
      private String edtPrdDescCorta_Jsonclick ;
      private String edtingreBodDetCant_Jsonclick ;
      private String edtingreBodDetVal_Jsonclick ;
      private String edtIngBodDetValTot_Jsonclick ;
      private String edtingreBodDetFch_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridingresobodegas_ingreboddet_Internalname ;
      private DateTime Z366ingreBodFch ;
      private DateTime Z372ingreBodDetFch ;
      private DateTime A366ingreBodFch ;
      private DateTime A372ingreBodDetFch ;
      private bool entryPointCalled ;
      private bool n373ingreBodUltNro ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n367ingreBodTipo ;
      private bool bGXsfl_106_Refreshing=false ;
      private bool n44empdsc ;
      private bool n46AgeDsc ;
      private bool n365ingreBodDsc ;
      private bool n184PrvDsc ;
      private bool n366ingreBodFch ;
      private bool n368ingreBodNroFac ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool n306PrdDescCorta ;
      private bool n372ingreBodDetFch ;
      private bool n370ingreBodDetCant ;
      private bool n371ingreBodDetVal ;
      private String A44empdsc ;
      private String A184PrvDsc ;
      private String A306PrdDescCorta ;
      private String Z44empdsc ;
      private String Z184PrvDsc ;
      private String Z306PrdDescCorta ;
      private IGxSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridingresobodegas_ingreboddetContainer ;
      private GXWebRow Gridingresobodegas_ingreboddetRow ;
      private GXWebColumn Gridingresobodegas_ingreboddetColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbingreBodTipo ;
      private IDataStoreProvider pr_default ;
      private String[] T00137_A44empdsc ;
      private bool[] T00137_n44empdsc ;
      private String[] T00138_A46AgeDsc ;
      private bool[] T00138_n46AgeDsc ;
      private decimal[] T001311_A377ingBodTotCant ;
      private decimal[] T001311_A378ingBodTotValor ;
      private String[] T00139_A184PrvDsc ;
      private bool[] T00139_n184PrvDsc ;
      private short[] T001313_A364ingreBodNro ;
      private String[] T001313_A44empdsc ;
      private bool[] T001313_n44empdsc ;
      private String[] T001313_A46AgeDsc ;
      private bool[] T001313_n46AgeDsc ;
      private String[] T001313_A365ingreBodDsc ;
      private bool[] T001313_n365ingreBodDsc ;
      private DateTime[] T001313_A366ingreBodFch ;
      private bool[] T001313_n366ingreBodFch ;
      private short[] T001313_A367ingreBodTipo ;
      private bool[] T001313_n367ingreBodTipo ;
      private short[] T001313_A368ingreBodNroFac ;
      private bool[] T001313_n368ingreBodNroFac ;
      private String[] T001313_A184PrvDsc ;
      private bool[] T001313_n184PrvDsc ;
      private short[] T001313_A373ingreBodUltNro ;
      private bool[] T001313_n373ingreBodUltNro ;
      private short[] T001313_A1EmpID ;
      private short[] T001313_A2AgeID ;
      private String[] T001313_A37PrvRuc ;
      private decimal[] T001313_A377ingBodTotCant ;
      private decimal[] T001313_A378ingBodTotValor ;
      private String[] T001314_A44empdsc ;
      private bool[] T001314_n44empdsc ;
      private String[] T001315_A46AgeDsc ;
      private bool[] T001315_n46AgeDsc ;
      private decimal[] T001317_A377ingBodTotCant ;
      private decimal[] T001317_A378ingBodTotValor ;
      private String[] T001318_A184PrvDsc ;
      private bool[] T001318_n184PrvDsc ;
      private short[] T001319_A1EmpID ;
      private short[] T001319_A2AgeID ;
      private short[] T001319_A364ingreBodNro ;
      private short[] T00136_A364ingreBodNro ;
      private String[] T00136_A365ingreBodDsc ;
      private bool[] T00136_n365ingreBodDsc ;
      private DateTime[] T00136_A366ingreBodFch ;
      private bool[] T00136_n366ingreBodFch ;
      private short[] T00136_A367ingreBodTipo ;
      private bool[] T00136_n367ingreBodTipo ;
      private short[] T00136_A368ingreBodNroFac ;
      private bool[] T00136_n368ingreBodNroFac ;
      private short[] T00136_A373ingreBodUltNro ;
      private bool[] T00136_n373ingreBodUltNro ;
      private short[] T00136_A1EmpID ;
      private short[] T00136_A2AgeID ;
      private String[] T00136_A37PrvRuc ;
      private short[] T001320_A1EmpID ;
      private short[] T001320_A2AgeID ;
      private short[] T001320_A364ingreBodNro ;
      private short[] T001321_A1EmpID ;
      private short[] T001321_A2AgeID ;
      private short[] T001321_A364ingreBodNro ;
      private short[] T00135_A364ingreBodNro ;
      private String[] T00135_A365ingreBodDsc ;
      private bool[] T00135_n365ingreBodDsc ;
      private DateTime[] T00135_A366ingreBodFch ;
      private bool[] T00135_n366ingreBodFch ;
      private short[] T00135_A367ingreBodTipo ;
      private bool[] T00135_n367ingreBodTipo ;
      private short[] T00135_A368ingreBodNroFac ;
      private bool[] T00135_n368ingreBodNroFac ;
      private short[] T00135_A373ingreBodUltNro ;
      private bool[] T00135_n373ingreBodUltNro ;
      private short[] T00135_A1EmpID ;
      private short[] T00135_A2AgeID ;
      private String[] T00135_A37PrvRuc ;
      private String[] T001325_A44empdsc ;
      private bool[] T001325_n44empdsc ;
      private String[] T001326_A46AgeDsc ;
      private bool[] T001326_n46AgeDsc ;
      private decimal[] T001328_A377ingBodTotCant ;
      private decimal[] T001328_A378ingBodTotValor ;
      private String[] T001329_A184PrvDsc ;
      private bool[] T001329_n184PrvDsc ;
      private short[] T001331_A1EmpID ;
      private short[] T001331_A2AgeID ;
      private short[] T001331_A364ingreBodNro ;
      private short[] T001332_A364ingreBodNro ;
      private short[] T001332_A369ingreBodDetId ;
      private String[] T001332_A306PrdDescCorta ;
      private bool[] T001332_n306PrdDescCorta ;
      private DateTime[] T001332_A372ingreBodDetFch ;
      private bool[] T001332_n372ingreBodDetFch ;
      private decimal[] T001332_A370ingreBodDetCant ;
      private bool[] T001332_n370ingreBodDetCant ;
      private decimal[] T001332_A371ingreBodDetVal ;
      private bool[] T001332_n371ingreBodDetVal ;
      private short[] T001332_A1EmpID ;
      private short[] T001332_A2AgeID ;
      private short[] T001332_A286PrdCod ;
      private String[] T00134_A306PrdDescCorta ;
      private bool[] T00134_n306PrdDescCorta ;
      private String[] T001333_A306PrdDescCorta ;
      private bool[] T001333_n306PrdDescCorta ;
      private short[] T001334_A1EmpID ;
      private short[] T001334_A2AgeID ;
      private short[] T001334_A364ingreBodNro ;
      private short[] T001334_A369ingreBodDetId ;
      private short[] T00133_A364ingreBodNro ;
      private short[] T00133_A369ingreBodDetId ;
      private DateTime[] T00133_A372ingreBodDetFch ;
      private bool[] T00133_n372ingreBodDetFch ;
      private decimal[] T00133_A370ingreBodDetCant ;
      private bool[] T00133_n370ingreBodDetCant ;
      private decimal[] T00133_A371ingreBodDetVal ;
      private bool[] T00133_n371ingreBodDetVal ;
      private short[] T00133_A1EmpID ;
      private short[] T00133_A2AgeID ;
      private short[] T00133_A286PrdCod ;
      private short[] T00132_A364ingreBodNro ;
      private short[] T00132_A369ingreBodDetId ;
      private DateTime[] T00132_A372ingreBodDetFch ;
      private bool[] T00132_n372ingreBodDetFch ;
      private decimal[] T00132_A370ingreBodDetCant ;
      private bool[] T00132_n370ingreBodDetCant ;
      private decimal[] T00132_A371ingreBodDetVal ;
      private bool[] T00132_n371ingreBodDetVal ;
      private short[] T00132_A1EmpID ;
      private short[] T00132_A2AgeID ;
      private short[] T00132_A286PrdCod ;
      private String[] T001338_A306PrdDescCorta ;
      private bool[] T001338_n306PrdDescCorta ;
      private short[] T001339_A1EmpID ;
      private short[] T001339_A2AgeID ;
      private short[] T001339_A364ingreBodNro ;
      private short[] T001339_A369ingreBodDetId ;
      private SdtTransactionContext AV11TrnContext ;
      private SdtTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class ingresobodegas__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new UpdateCursor(def[29])
         ,new UpdateCursor(def[30])
         ,new UpdateCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new ForEachCursor(def[33])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001313 ;
          prmT001313 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00137 ;
          prmT00137 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00138 ;
          prmT00138 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001311 ;
          prmT001311 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00139 ;
          prmT00139 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT001314 ;
          prmT001314 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001315 ;
          prmT001315 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001317 ;
          prmT001317 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001318 ;
          prmT001318 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT001319 ;
          prmT001319 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00136 ;
          prmT00136 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001320 ;
          prmT001320 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001321 ;
          prmT001321 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00135 ;
          prmT00135 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001322 ;
          prmT001322 = new Object[] {
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@ingreBodFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ingreBodTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ingreBodNroFac",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT001323 ;
          prmT001323 = new Object[] {
          new Object[] {"@ingreBodDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@ingreBodFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ingreBodTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ingreBodNroFac",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001324 ;
          prmT001324 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001330 ;
          prmT001330 = new Object[] {
          new Object[] {"@ingreBodUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001331 ;
          prmT001331 = new Object[] {
          } ;
          Object[] prmT001332 ;
          prmT001332 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodDetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00134 ;
          prmT00134 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001333 ;
          prmT001333 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001334 ;
          prmT001334 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodDetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00133 ;
          prmT00133 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodDetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00132 ;
          prmT00132 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodDetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001335 ;
          prmT001335 = new Object[] {
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodDetId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodDetFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ingreBodDetCant",SqlDbType.Decimal,8,2} ,
          new Object[] {"@ingreBodDetVal",SqlDbType.Decimal,8,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001336 ;
          prmT001336 = new Object[] {
          new Object[] {"@ingreBodDetFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ingreBodDetCant",SqlDbType.Decimal,8,2} ,
          new Object[] {"@ingreBodDetVal",SqlDbType.Decimal,8,2} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodDetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001337 ;
          prmT001337 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodDetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001339 ;
          prmT001339 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001325 ;
          prmT001325 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001326 ;
          prmT001326 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001328 ;
          prmT001328 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingreBodNro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001329 ;
          prmT001329 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT001338 ;
          prmT001338 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00132", "SELECT [ingreBodNro], [ingreBodDetId], [ingreBodDetFch], [ingreBodDetCant], [ingreBodDetVal], [EmpID], [AgeID], [PrdCod] FROM [IngresoBodegasingreBodDet] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro AND [ingreBodDetId] = @ingreBodDetId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00132,1,0,true,false )
             ,new CursorDef("T00133", "SELECT [ingreBodNro], [ingreBodDetId], [ingreBodDetFch], [ingreBodDetCant], [ingreBodDetVal], [EmpID], [AgeID], [PrdCod] FROM [IngresoBodegasingreBodDet] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro AND [ingreBodDetId] = @ingreBodDetId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00133,1,0,true,false )
             ,new CursorDef("T00134", "SELECT [PrdDescCorta] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT00134,1,0,true,false )
             ,new CursorDef("T00135", "SELECT [ingreBodNro], [ingreBodDsc], [ingreBodFch], [ingreBodTipo], [ingreBodNroFac], [ingreBodUltNro], [EmpID], [AgeID], [PrvRuc] FROM [IngresoBodegas] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro ",true, GxErrorMask.GX_NOMASK, false, this,prmT00135,1,0,true,false )
             ,new CursorDef("T00136", "SELECT [ingreBodNro], [ingreBodDsc], [ingreBodFch], [ingreBodTipo], [ingreBodNroFac], [ingreBodUltNro], [EmpID], [AgeID], [PrvRuc] FROM [IngresoBodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro ",true, GxErrorMask.GX_NOMASK, false, this,prmT00136,1,0,true,false )
             ,new CursorDef("T00137", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00137,1,0,true,false )
             ,new CursorDef("T00138", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00138,1,0,true,false )
             ,new CursorDef("T00139", "SELECT [PrvDsc] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT00139,1,0,true,false )
             ,new CursorDef("T001311", "SELECT COALESCE( T1.[ingBodTotCant], 0) AS ingBodTotCant, COALESCE( T1.[ingBodTotValor], 0) AS ingBodTotValor FROM (SELECT SUM([ingreBodDetCant]) AS ingBodTotCant, [EmpID], [AgeID], [ingreBodNro], SUM(ROUND(( COALESCE( [ingreBodDetCant], 0) * CAST(COALESCE( [ingreBodDetVal], 0) AS decimal( 18, 10))), 2)) AS ingBodTotValor FROM [IngresoBodegasingreBodDet] WITH (UPDLOCK) GROUP BY [EmpID], [AgeID], [ingreBodNro] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[ingreBodNro] = @ingreBodNro ",true, GxErrorMask.GX_NOMASK, false, this,prmT001311,1,0,true,false )
             ,new CursorDef("T001313", "SELECT TM1.[ingreBodNro], T2.[empdsc], T3.[AgeDsc], TM1.[ingreBodDsc], TM1.[ingreBodFch], TM1.[ingreBodTipo], TM1.[ingreBodNroFac], T5.[PrvDsc], TM1.[ingreBodUltNro], TM1.[EmpID], TM1.[AgeID], TM1.[PrvRuc], COALESCE( T4.[ingBodTotCant], 0) AS ingBodTotCant, COALESCE( T4.[ingBodTotValor], 0) AS ingBodTotValor FROM (((([IngresoBodegas] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[AgeID] = TM1.[AgeID]) LEFT JOIN (SELECT SUM([ingreBodDetCant]) AS ingBodTotCant, [EmpID], [AgeID], [ingreBodNro], SUM(ROUND(( COALESCE( [ingreBodDetCant], 0) * CAST(COALESCE( [ingreBodDetVal], 0) AS decimal( 18, 10))), 2)) AS ingBodTotValor FROM [IngresoBodegasingreBodDet] WITH (NOLOCK) GROUP BY [EmpID], [AgeID], [ingreBodNro] ) T4 ON T4.[EmpID] = TM1.[EmpID] AND T4.[AgeID] = TM1.[AgeID] AND T4.[ingreBodNro] = TM1.[ingreBodNro]) INNER JOIN [Proveedor] T5 WITH (NOLOCK) ON T5.[PrvRuc] = TM1.[PrvRuc]) WHERE TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[ingreBodNro] = @ingreBodNro ORDER BY TM1.[EmpID], TM1.[AgeID], TM1.[ingreBodNro]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001313,100,0,true,false )
             ,new CursorDef("T001314", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001314,1,0,true,false )
             ,new CursorDef("T001315", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001315,1,0,true,false )
             ,new CursorDef("T001317", "SELECT COALESCE( T1.[ingBodTotCant], 0) AS ingBodTotCant, COALESCE( T1.[ingBodTotValor], 0) AS ingBodTotValor FROM (SELECT SUM([ingreBodDetCant]) AS ingBodTotCant, [EmpID], [AgeID], [ingreBodNro], SUM(ROUND(( COALESCE( [ingreBodDetCant], 0) * CAST(COALESCE( [ingreBodDetVal], 0) AS decimal( 18, 10))), 2)) AS ingBodTotValor FROM [IngresoBodegasingreBodDet] WITH (UPDLOCK) GROUP BY [EmpID], [AgeID], [ingreBodNro] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[ingreBodNro] = @ingreBodNro ",true, GxErrorMask.GX_NOMASK, false, this,prmT001317,1,0,true,false )
             ,new CursorDef("T001318", "SELECT [PrvDsc] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT001318,1,0,true,false )
             ,new CursorDef("T001319", "SELECT [EmpID], [AgeID], [ingreBodNro] FROM [IngresoBodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001319,1,0,true,false )
             ,new CursorDef("T001320", "SELECT TOP 1 [EmpID], [AgeID], [ingreBodNro] FROM [IngresoBodegas] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [AgeID] > @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [ingreBodNro] > @ingreBodNro) ORDER BY [EmpID], [AgeID], [ingreBodNro]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001320,1,0,true,true )
             ,new CursorDef("T001321", "SELECT TOP 1 [EmpID], [AgeID], [ingreBodNro] FROM [IngresoBodegas] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [AgeID] < @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [ingreBodNro] < @ingreBodNro) ORDER BY [EmpID] DESC, [AgeID] DESC, [ingreBodNro] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001321,1,0,true,true )
             ,new CursorDef("T001322", "INSERT INTO [IngresoBodegas]([ingreBodNro], [ingreBodDsc], [ingreBodFch], [ingreBodTipo], [ingreBodNroFac], [ingreBodUltNro], [EmpID], [AgeID], [PrvRuc]) VALUES(@ingreBodNro, @ingreBodDsc, @ingreBodFch, @ingreBodTipo, @ingreBodNroFac, @ingreBodUltNro, @EmpID, @AgeID, @PrvRuc)", GxErrorMask.GX_NOMASK,prmT001322)
             ,new CursorDef("T001323", "UPDATE [IngresoBodegas] SET [ingreBodDsc]=@ingreBodDsc, [ingreBodFch]=@ingreBodFch, [ingreBodTipo]=@ingreBodTipo, [ingreBodNroFac]=@ingreBodNroFac, [ingreBodUltNro]=@ingreBodUltNro, [PrvRuc]=@PrvRuc  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro", GxErrorMask.GX_NOMASK,prmT001323)
             ,new CursorDef("T001324", "DELETE FROM [IngresoBodegas]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro", GxErrorMask.GX_NOMASK,prmT001324)
             ,new CursorDef("T001325", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001325,1,0,true,false )
             ,new CursorDef("T001326", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001326,1,0,true,false )
             ,new CursorDef("T001328", "SELECT COALESCE( T1.[ingBodTotCant], 0) AS ingBodTotCant, COALESCE( T1.[ingBodTotValor], 0) AS ingBodTotValor FROM (SELECT SUM([ingreBodDetCant]) AS ingBodTotCant, [EmpID], [AgeID], [ingreBodNro], SUM(ROUND(( COALESCE( [ingreBodDetCant], 0) * CAST(COALESCE( [ingreBodDetVal], 0) AS decimal( 18, 10))), 2)) AS ingBodTotValor FROM [IngresoBodegasingreBodDet] WITH (UPDLOCK) GROUP BY [EmpID], [AgeID], [ingreBodNro] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[ingreBodNro] = @ingreBodNro ",true, GxErrorMask.GX_NOMASK, false, this,prmT001328,1,0,true,false )
             ,new CursorDef("T001329", "SELECT [PrvDsc] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT001329,1,0,true,false )
             ,new CursorDef("T001330", "UPDATE [IngresoBodegas] SET [ingreBodUltNro]=@ingreBodUltNro  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro", GxErrorMask.GX_NOMASK,prmT001330)
             ,new CursorDef("T001331", "SELECT [EmpID], [AgeID], [ingreBodNro] FROM [IngresoBodegas] WITH (NOLOCK) ORDER BY [EmpID], [AgeID], [ingreBodNro]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001331,100,0,true,false )
             ,new CursorDef("T001332", "SELECT T1.[ingreBodNro], T1.[ingreBodDetId], T2.[PrdDescCorta], T1.[ingreBodDetFch], T1.[ingreBodDetCant], T1.[ingreBodDetVal], T1.[EmpID], T1.[AgeID], T1.[PrdCod] FROM ([IngresoBodegasingreBodDet] T1 WITH (NOLOCK) INNER JOIN [Productos] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[PrdCod] = T1.[PrdCod]) WHERE T1.[EmpID] = @EmpID and T1.[AgeID] = @AgeID and T1.[ingreBodNro] = @ingreBodNro and T1.[ingreBodDetId] = @ingreBodDetId ORDER BY T1.[EmpID], T1.[AgeID], T1.[ingreBodNro], T1.[ingreBodDetId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001332,11,0,true,false )
             ,new CursorDef("T001333", "SELECT [PrdDescCorta] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001333,1,0,true,false )
             ,new CursorDef("T001334", "SELECT [EmpID], [AgeID], [ingreBodNro], [ingreBodDetId] FROM [IngresoBodegasingreBodDet] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro AND [ingreBodDetId] = @ingreBodDetId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001334,1,0,true,false )
             ,new CursorDef("T001335", "INSERT INTO [IngresoBodegasingreBodDet]([ingreBodNro], [ingreBodDetId], [ingreBodDetFch], [ingreBodDetCant], [ingreBodDetVal], [EmpID], [AgeID], [PrdCod]) VALUES(@ingreBodNro, @ingreBodDetId, @ingreBodDetFch, @ingreBodDetCant, @ingreBodDetVal, @EmpID, @AgeID, @PrdCod)", GxErrorMask.GX_NOMASK,prmT001335)
             ,new CursorDef("T001336", "UPDATE [IngresoBodegasingreBodDet] SET [ingreBodDetFch]=@ingreBodDetFch, [ingreBodDetCant]=@ingreBodDetCant, [ingreBodDetVal]=@ingreBodDetVal, [PrdCod]=@PrdCod  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro AND [ingreBodDetId] = @ingreBodDetId", GxErrorMask.GX_NOMASK,prmT001336)
             ,new CursorDef("T001337", "DELETE FROM [IngresoBodegasingreBodDet]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [ingreBodNro] = @ingreBodNro AND [ingreBodDetId] = @ingreBodDetId", GxErrorMask.GX_NOMASK,prmT001337)
             ,new CursorDef("T001338", "SELECT [PrdDescCorta] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001338,1,0,true,false )
             ,new CursorDef("T001339", "SELECT [EmpID], [AgeID], [ingreBodNro], [ingreBodDetId] FROM [IngresoBodegasingreBodDet] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [AgeID] = @AgeID and [ingreBodNro] = @ingreBodNro ORDER BY [EmpID], [AgeID], [ingreBodNro], [ingreBodDetId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001339,11,0,true,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((String[]) buf[13])[0] = rslt.getString(9, 13) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((String[]) buf[13])[0] = rslt.getString(9, 13) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 8 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((short[]) buf[15])[0] = rslt.getShort(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                ((String[]) buf[19])[0] = rslt.getString(12, 13) ;
                ((decimal[]) buf[20])[0] = rslt.getDecimal(13) ;
                ((decimal[]) buf[21])[0] = rslt.getDecimal(14) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 12 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 22 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 25 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 26 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((short[]) buf[10])[0] = rslt.getShort(7) ;
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((short[]) buf[12])[0] = rslt.getShort(9) ;
                return;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 28 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 32 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 33 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 17 :
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
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[10]);
                }
                stmt.SetParameter(7, (short)parms[11]);
                stmt.SetParameter(8, (short)parms[12]);
                stmt.SetParameter(9, (String)parms[13]);
                return;
             case 18 :
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
                   stmt.setNull( 2 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(2, (DateTime)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[9]);
                }
                stmt.SetParameter(6, (String)parms[10]);
                stmt.SetParameter(7, (short)parms[11]);
                stmt.SetParameter(8, (short)parms[12]);
                stmt.SetParameter(9, (short)parms[13]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 24 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 29 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (decimal)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[7]);
                }
                stmt.SetParameter(6, (short)parms[8]);
                stmt.SetParameter(7, (short)parms[9]);
                stmt.SetParameter(8, (short)parms[10]);
                return;
       }
       setparameters30( cursor, stmt, parms) ;
    }

    public void setparameters30( int cursor ,
                                 IFieldSetter stmt ,
                                 Object[] parms )
    {
       switch ( cursor )
       {
             case 30 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(1, (DateTime)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (decimal)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(3, (decimal)parms[5]);
                }
                stmt.SetParameter(4, (short)parms[6]);
                stmt.SetParameter(5, (short)parms[7]);
                stmt.SetParameter(6, (short)parms[8]);
                stmt.SetParameter(7, (short)parms[9]);
                stmt.SetParameter(8, (short)parms[10]);
                return;
             case 31 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 32 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 33 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
