/*
               File: Inventario
        Description: Movimientos Inventario
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/29/2022 1:8:44.73
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
   public class inventario : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"TIPOINV") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLATIPOINV0S48( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel25"+"_"+"DETINVSTOCK") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A286PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX25ASADETINVSTOCK0S51( A1EmpID, A286PrdCod, A2AgeID, A42BodCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_34") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_34( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_35") == 0 )
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
            gxLoad_35( A1EmpID, A2AgeID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_36") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A42BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_36( A1EmpID, A42BodCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_38") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A264invCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_38( A1EmpID, A2AgeID, A42BodCod, A264invCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_37") == 0 )
         {
            A43TipoInv = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_37( A43TipoInv) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_40") == 0 )
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
            gxLoad_40( A1EmpID, A2AgeID, A286PrdCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_42") == 0 )
         {
            A37PrvRuc = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_42( A37PrvRuc) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridinventario_detinv") == 0 )
         {
            nRC_GXsfl_125 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_125_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_125_idx = GetNextPar( );
            A272InvUltNro = (int)(NumberUtil.Val( GetNextPar( ), "."));
            n272InvUltNro = false;
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridinventario_detinv_newrow( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridinventario_detinvoc") == 0 )
         {
            nRC_GXsfl_148 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_148_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_148_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridinventario_detinvoc_newrow( ) ;
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
               AV9BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9BodCod), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBODCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9BodCod), "ZZZ9"), context));
               AV10invCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10invCod), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vINVCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10invCod), "ZZZ9"), context));
               AV16usuCod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16usuCod", AV16usuCod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV16usuCod, "")), context));
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
            Form.Meta.addItem("description", "Movimientos Inventario", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtInvUser_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public inventario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public inventario( IGxContext context )
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
                           short aP3_BodCod ,
                           short aP4_invCod ,
                           String aP5_usuCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8AgeID = aP2_AgeID;
         this.AV9BodCod = aP3_BodCod;
         this.AV10invCod = aP4_invCod;
         this.AV16usuCod = aP5_usuCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynTipoInv = new GXCombobox();
         cmbTipoInvSigno = new GXCombobox();
         chkInvEst = new GXCheckbox();
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
         if ( dynTipoInv.ItemCount > 0 )
         {
            A43TipoInv = dynTipoInv.getValidValue(A43TipoInv);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynTipoInv.CurrentValue = StringUtil.RTrim( A43TipoInv);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoInv_Internalname, "Values", dynTipoInv.ToJavascriptSource(), true);
         }
         if ( cmbTipoInvSigno.ItemCount > 0 )
         {
            A223TipoInvSigno = (short)(NumberUtil.Val( cmbTipoInvSigno.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0))), "."));
            n223TipoInvSigno = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbTipoInvSigno.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoInvSigno_Internalname, "Values", cmbTipoInvSigno.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2 col-lg-10 col-lg-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Movimientos Inventario", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Inventario.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2 col-lg-10 col-lg-offset-1", "left", "top", "", "", "div");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx01c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"BODCOD"+"'), id:'"+"BODCOD"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"INVCOD"+"'), id:'"+"INVCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection1_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtempdsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection2_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeDsc_Internalname, "Agencia", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtAgeDsc_Internalname, StringUtil.RTrim( A46AgeDsc), StringUtil.RTrim( context.localUtil.Format( A46AgeDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAgeDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection3_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtInvUser_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtInvUser_Internalname, "User", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtInvUser_Internalname, A270InvUser, StringUtil.RTrim( context.localUtil.Format( A270InvUser, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInvUser_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInvUser_Enabled, 1, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection4_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtInvHora_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtInvHora_Internalname, "Hora", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtInvHora_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtInvHora_Internalname, context.localUtil.TToC( A271InvHora, 10, 8, 0, 3, "/", ":", " "), context.localUtil.Format( A271InvHora, "99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInvHora_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInvHora_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Time", "right", false, "HLP_Inventario.htm");
            GxWebStd.gx_bitmap( context, edtInvHora_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtInvHora_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Inventario.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, "", edtEmpID_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmpID_Internalname, "Emp ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", edtEmpID_Visible, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Inventario.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtAgeID_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAgeID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAgeID_Internalname, "Age ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAgeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2AgeID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A2AgeID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAgeID_Jsonclick, 0, "Attribute", "", "", "", "", edtAgeID_Visible, edtAgeID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Inventario.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_2_Internalname, sImgUrl, imgprompt_2_Link, "", "", context.GetTheme( ), imgprompt_2_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection5_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBodCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodCod_Internalname, "Bodega Cod.", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBodCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodCod_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Inventario.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_42_Internalname, sImgUrl, imgprompt_42_Link, "", "", context.GetTheme( ), imgprompt_42_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection6_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBodDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodDsc_Internalname, "Bodega Nombre", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBodDsc_Internalname, StringUtil.RTrim( A217BodDsc), StringUtil.RTrim( context.localUtil.Format( A217BodDsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_Inventario.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtinvCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtinvCod_Internalname, "Codigo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtinvCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A264invCod), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A264invCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtinvCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtinvCod_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtInvDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtInvDsc_Internalname, "Descripcion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtInvDsc_Internalname, StringUtil.RTrim( A265InvDsc), StringUtil.RTrim( context.localUtil.Format( A265InvDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInvDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInvDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtInvFch_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtInvFch_Internalname, "Fecha", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtInvFch_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtInvFch_Internalname, context.localUtil.Format(A266InvFch, "99/99/9999"), context.localUtil.Format( A266InvFch, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInvFch_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInvFch_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Inventario.htm");
            GxWebStd.gx_bitmap( context, edtInvFch_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtInvFch_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Inventario.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynTipoInv_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynTipoInv_Internalname, "Tipo Movimiento", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynTipoInv, dynTipoInv_Internalname, StringUtil.RTrim( A43TipoInv), 1, dynTipoInv_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, dynTipoInv.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "", true, "HLP_Inventario.htm");
            dynTipoInv.CurrentValue = StringUtil.RTrim( A43TipoInv);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoInv_Internalname, "Values", (String)(dynTipoInv.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbTipoInvSigno_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbTipoInvSigno_Internalname, "Signo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoInvSigno, cmbTipoInvSigno_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)), 1, cmbTipoInvSigno_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbTipoInvSigno.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_Inventario.htm");
            cmbTipoInvSigno.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoInvSigno_Internalname, "Values", (String)(cmbTipoInvSigno.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkInvEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkInvEst_Internalname, "Estado", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkInvEst_Internalname, A267InvEst, "", "Estado", 1, chkInvEst.Enabled, "A", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(101, this, 'A', 'N');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtInvGuia_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtInvGuia_Internalname, "Guia", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtInvGuia_Internalname, StringUtil.RTrim( A268InvGuia), StringUtil.RTrim( context.localUtil.Format( A268InvGuia, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,106);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInvGuia_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInvGuia_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtInvFac_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtInvFac_Internalname, "Factura", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtInvFac_Internalname, StringUtil.RTrim( A269InvFac), StringUtil.RTrim( context.localUtil.Format( A269InvFac, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,111);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInvFac_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInvFac_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtInvUltNro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtInvUltNro_Internalname, "Ult Nro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtInvUltNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A272InvUltNro), 8, 0, ",", "")), ((edtInvUltNro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A272InvUltNro), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A272InvUltNro), "ZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInvUltNro_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInvUltNro_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDetinvtable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitledetinv_Internalname, "Detalle de Productos", "", "", lblTitledetinv_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridinventario_detinv( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 col-lg-12 col-lg-offset-0 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtdetInvTotal_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtdetInvTotal_Internalname, "Total", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtdetInvTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A281detInvTotal, 13, 2, ",", "")), ((edtdetInvTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A281detInvTotal, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A281detInvTotal, "ZZ,ZZZ,ZZZ.ZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtdetInvTotal_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtdetInvTotal_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "valores", "right", false, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 col-lg-12 col-lg-offset-0 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDetinvoctable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitledetinvoc_Internalname, "Detalle de Ordenes", "", "", lblTitledetinvoc_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridinventario_detinvoc( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 159,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 161,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 163,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Inventario.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0S48( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridinventario_detinv( )
      {
         /*  Grid Control  */
         Gridinventario_detinvContainer.AddObjectProperty("GridName", "Gridinventario_detinv");
         Gridinventario_detinvContainer.AddObjectProperty("Header", subGridinventario_detinv_Header);
         Gridinventario_detinvContainer.AddObjectProperty("Class", "Grid");
         Gridinventario_detinvContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridinventario_detinvContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridinventario_detinvContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinv_Backcolorstyle), 1, 0, ".", "")));
         Gridinventario_detinvContainer.AddObjectProperty("CmpContext", "");
         Gridinventario_detinvContainer.AddObjectProperty("InMasterPage", "false");
         Gridinventario_detinvColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A273detInvId), 4, 0, ".", "")));
         Gridinventario_detinvColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvId_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvContainer.AddColumnProperties(Gridinventario_detinvColumn);
         Gridinventario_detinvColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ".", "")));
         Gridinventario_detinvColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvContainer.AddColumnProperties(Gridinventario_detinvColumn);
         Gridinventario_detinvColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvContainer.AddColumnProperties(Gridinventario_detinvColumn);
         Gridinventario_detinvColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvColumn.AddObjectProperty("Value", A309prdNombre);
         Gridinventario_detinvColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvContainer.AddColumnProperties(Gridinventario_detinvColumn);
         Gridinventario_detinvColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvColumn.AddObjectProperty("Value", StringUtil.RTrim( A341detInvUniCod));
         Gridinventario_detinvColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvUniCod_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvContainer.AddColumnProperties(Gridinventario_detinvColumn);
         Gridinventario_detinvColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A274detInvCant), 8, 0, ".", "")));
         Gridinventario_detinvColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCant_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvContainer.AddColumnProperties(Gridinventario_detinvColumn);
         Gridinventario_detinvColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A275detInvCosto, 8, 2, ".", "")));
         Gridinventario_detinvColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCosto_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvContainer.AddColumnProperties(Gridinventario_detinvColumn);
         Gridinventario_detinvColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A276detInvCostUni, 13, 2, ".", "")));
         Gridinventario_detinvColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCostUni_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvContainer.AddColumnProperties(Gridinventario_detinvColumn);
         Gridinventario_detinvColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A277detInvImporte, 13, 2, ".", "")));
         Gridinventario_detinvColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvImporte_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvContainer.AddColumnProperties(Gridinventario_detinvColumn);
         Gridinventario_detinvColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A280detInvStock), 8, 0, ".", "")));
         Gridinventario_detinvColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvStock_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvContainer.AddColumnProperties(Gridinventario_detinvColumn);
         Gridinventario_detinvContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinv_Selectedindex), 4, 0, ".", "")));
         Gridinventario_detinvContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinv_Allowselection), 1, 0, ".", "")));
         Gridinventario_detinvContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinv_Selectioncolor), 9, 0, ".", "")));
         Gridinventario_detinvContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinv_Allowhovering), 1, 0, ".", "")));
         Gridinventario_detinvContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinv_Hoveringcolor), 9, 0, ".", "")));
         Gridinventario_detinvContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinv_Allowcollapsing), 1, 0, ".", "")));
         Gridinventario_detinvContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinv_Collapsed), 1, 0, ".", "")));
         nGXsfl_125_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount51 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_51 = 1;
               ScanStart0S51( ) ;
               while ( RcdFound51 != 0 )
               {
                  init_level_properties51( ) ;
                  getByPrimaryKey0S51( ) ;
                  AddRow0S51( ) ;
                  ScanNext0S51( ) ;
               }
               ScanEnd0S51( ) ;
               nBlankRcdCount51 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B272InvUltNro = A272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            B281detInvTotal = A281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            standaloneNotModal0S51( ) ;
            standaloneModal0S51( ) ;
            sMode51 = Gx_mode;
            while ( nGXsfl_125_idx < nRC_GXsfl_125 )
            {
               bGXsfl_125_Refreshing = true;
               ReadRow0S51( ) ;
               edtdetInvId_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVID_"+sGXsfl_125_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvId_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
               edtPrdCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDCOD_"+sGXsfl_125_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
               edtprdNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDNOMBRE_"+sGXsfl_125_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdNombre_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
               edtdetInvUniCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVUNICOD_"+sGXsfl_125_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvUniCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvUniCod_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
               edtdetInvCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVCANT_"+sGXsfl_125_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvCant_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
               edtdetInvCosto_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVCOSTO_"+sGXsfl_125_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvCosto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvCosto_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
               edtdetInvCostUni_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVCOSTUNI_"+sGXsfl_125_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvCostUni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvCostUni_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
               edtdetInvImporte_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVIMPORTE_"+sGXsfl_125_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvImporte_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvImporte_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
               edtdetInvStock_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVSTOCK_"+sGXsfl_125_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvStock_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_286_"+sGXsfl_125_idx+"Link");
               if ( ( nRcdExists_51 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0S51( ) ;
               }
               SendRow0S51( ) ;
               bGXsfl_125_Refreshing = false;
            }
            Gx_mode = sMode51;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A272InvUltNro = B272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            A281detInvTotal = B281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount51 = 5;
            nRcdExists_51 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0S51( ) ;
               while ( RcdFound51 != 0 )
               {
                  sGXsfl_125_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_125_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_12551( ) ;
                  init_level_properties51( ) ;
                  standaloneNotModal0S51( ) ;
                  getByPrimaryKey0S51( ) ;
                  standaloneModal0S51( ) ;
                  AddRow0S51( ) ;
                  ScanNext0S51( ) ;
               }
               ScanEnd0S51( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode51 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_125_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_125_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_12551( ) ;
            InitAll0S51( ) ;
            init_level_properties51( ) ;
            B272InvUltNro = A272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            B281detInvTotal = A281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            standaloneNotModal0S51( ) ;
            standaloneModal0S51( ) ;
            nRcdExists_51 = 0;
            nIsMod_51 = 0;
            nRcdDeleted_51 = 0;
            nBlankRcdCount51 = (short)(nBlankRcdUsr51+nBlankRcdCount51);
            fRowAdded = 0;
            while ( nBlankRcdCount51 > 0 )
            {
               AddRow0S51( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtdetInvId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount51 = (short)(nBlankRcdCount51-1);
            }
            Gx_mode = sMode51;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A272InvUltNro = B272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            A281detInvTotal = B281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridinventario_detinvContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridinventario_detinv", Gridinventario_detinvContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridinventario_detinvContainerData", Gridinventario_detinvContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridinventario_detinvContainerData"+"V", Gridinventario_detinvContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridinventario_detinvContainerData"+"V"+"\" value='"+Gridinventario_detinvContainer.GridValuesHidden()+"'/>") ;
         }
      }

      protected void gxdraw_Gridinventario_detinvoc( )
      {
         /*  Grid Control  */
         Gridinventario_detinvocContainer.AddObjectProperty("GridName", "Gridinventario_detinvoc");
         Gridinventario_detinvocContainer.AddObjectProperty("Header", subGridinventario_detinvoc_Header);
         Gridinventario_detinvocContainer.AddObjectProperty("Class", "Grid");
         Gridinventario_detinvocContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridinventario_detinvocContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridinventario_detinvocContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinvoc_Backcolorstyle), 1, 0, ".", "")));
         Gridinventario_detinvocContainer.AddObjectProperty("CmpContext", "");
         Gridinventario_detinvocContainer.AddObjectProperty("InMasterPage", "false");
         Gridinventario_detinvocColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvocColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A282detInvOcId), 4, 0, ".", "")));
         Gridinventario_detinvocColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOcId_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvocContainer.AddColumnProperties(Gridinventario_detinvocColumn);
         Gridinventario_detinvocColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvocColumn.AddObjectProperty("Value", StringUtil.RTrim( A37PrvRuc));
         Gridinventario_detinvocColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvRuc_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvocContainer.AddColumnProperties(Gridinventario_detinvocColumn);
         Gridinventario_detinvocColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvocContainer.AddColumnProperties(Gridinventario_detinvocColumn);
         Gridinventario_detinvocColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvocColumn.AddObjectProperty("Value", A184PrvDsc);
         Gridinventario_detinvocColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvDsc_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvocContainer.AddColumnProperties(Gridinventario_detinvocColumn);
         Gridinventario_detinvocColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvocColumn.AddObjectProperty("Value", StringUtil.RTrim( A185PrvEst));
         Gridinventario_detinvocColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvEst_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvocContainer.AddColumnProperties(Gridinventario_detinvocColumn);
         Gridinventario_detinvocColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvocColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A283detInvOCNro), 8, 0, ".", "")));
         Gridinventario_detinvocColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOCNro_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvocContainer.AddColumnProperties(Gridinventario_detinvocColumn);
         Gridinventario_detinvocColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridinventario_detinvocColumn.AddObjectProperty("Value", StringUtil.RTrim( A284detInvOcDoc));
         Gridinventario_detinvocColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOcDoc_Enabled), 5, 0, ".", "")));
         Gridinventario_detinvocContainer.AddColumnProperties(Gridinventario_detinvocColumn);
         Gridinventario_detinvocContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinvoc_Selectedindex), 4, 0, ".", "")));
         Gridinventario_detinvocContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinvoc_Allowselection), 1, 0, ".", "")));
         Gridinventario_detinvocContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinvoc_Selectioncolor), 9, 0, ".", "")));
         Gridinventario_detinvocContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinvoc_Allowhovering), 1, 0, ".", "")));
         Gridinventario_detinvocContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinvoc_Hoveringcolor), 9, 0, ".", "")));
         Gridinventario_detinvocContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinvoc_Allowcollapsing), 1, 0, ".", "")));
         Gridinventario_detinvocContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinventario_detinvoc_Collapsed), 1, 0, ".", "")));
         nGXsfl_148_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount50 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_50 = 1;
               ScanStart0S50( ) ;
               while ( RcdFound50 != 0 )
               {
                  init_level_properties50( ) ;
                  getByPrimaryKey0S50( ) ;
                  AddRow0S50( ) ;
                  ScanNext0S50( ) ;
               }
               ScanEnd0S50( ) ;
               nBlankRcdCount50 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B272InvUltNro = A272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            B281detInvTotal = A281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            standaloneNotModal0S50( ) ;
            standaloneModal0S50( ) ;
            sMode50 = Gx_mode;
            while ( nGXsfl_148_idx < nRC_GXsfl_148 )
            {
               bGXsfl_148_Refreshing = true;
               ReadRow0S50( ) ;
               edtdetInvOcId_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVOCID_"+sGXsfl_148_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvOcId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvOcId_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
               edtPrvRuc_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRVRUC_"+sGXsfl_148_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
               edtPrvDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRVDSC_"+sGXsfl_148_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvDsc_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
               edtPrvEst_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRVEST_"+sGXsfl_148_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvEst_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
               edtdetInvOCNro_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVOCNRO_"+sGXsfl_148_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvOCNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvOCNro_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
               edtdetInvOcDoc_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVOCDOC_"+sGXsfl_148_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvOcDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvOcDoc_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_37_"+sGXsfl_148_idx+"Link");
               if ( ( nRcdExists_50 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0S50( ) ;
               }
               SendRow0S50( ) ;
               bGXsfl_148_Refreshing = false;
            }
            Gx_mode = sMode50;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A272InvUltNro = B272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            A281detInvTotal = B281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount50 = 5;
            nRcdExists_50 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0S50( ) ;
               while ( RcdFound50 != 0 )
               {
                  sGXsfl_148_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_148_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_14850( ) ;
                  init_level_properties50( ) ;
                  standaloneNotModal0S50( ) ;
                  getByPrimaryKey0S50( ) ;
                  standaloneModal0S50( ) ;
                  AddRow0S50( ) ;
                  ScanNext0S50( ) ;
               }
               ScanEnd0S50( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode50 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_148_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_148_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_14850( ) ;
            InitAll0S50( ) ;
            init_level_properties50( ) ;
            B272InvUltNro = A272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            B281detInvTotal = A281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            standaloneNotModal0S50( ) ;
            standaloneModal0S50( ) ;
            nRcdExists_50 = 0;
            nIsMod_50 = 0;
            nRcdDeleted_50 = 0;
            nBlankRcdCount50 = (short)(nBlankRcdUsr50+nBlankRcdCount50);
            fRowAdded = 0;
            while ( nBlankRcdCount50 > 0 )
            {
               AddRow0S50( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtdetInvOcId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount50 = (short)(nBlankRcdCount50-1);
            }
            Gx_mode = sMode50;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A272InvUltNro = B272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            A281detInvTotal = B281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridinventario_detinvocContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridinventario_detinvoc", Gridinventario_detinvocContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridinventario_detinvocContainerData", Gridinventario_detinvocContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridinventario_detinvocContainerData"+"V", Gridinventario_detinvocContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridinventario_detinvocContainerData"+"V"+"\" value='"+Gridinventario_detinvocContainer.GridValuesHidden()+"'/>") ;
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
         E110S2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A44empdsc = StringUtil.Upper( cgiGet( edtempdsc_Internalname));
               n44empdsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
               A46AgeDsc = cgiGet( edtAgeDsc_Internalname);
               n46AgeDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
               A270InvUser = cgiGet( edtInvUser_Internalname);
               n270InvUser = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270InvUser", A270InvUser);
               n270InvUser = (String.IsNullOrEmpty(StringUtil.RTrim( A270InvUser)) ? true : false);
               A271InvHora = DateTimeUtil.ResetDate(context.localUtil.CToT( cgiGet( edtInvHora_Internalname)));
               n271InvHora = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271InvHora", context.localUtil.TToC( A271InvHora, 0, 5, 0, 3, "/", ":", " "));
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtinvCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtinvCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "INVCOD");
                  AnyError = 1;
                  GX_FocusControl = edtinvCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A264invCod = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
               }
               else
               {
                  A264invCod = (short)(context.localUtil.CToN( cgiGet( edtinvCod_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
               }
               A265InvDsc = cgiGet( edtInvDsc_Internalname);
               n265InvDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265InvDsc", A265InvDsc);
               n265InvDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A265InvDsc)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtInvFch_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "INVFCH");
                  AnyError = 1;
                  GX_FocusControl = edtInvFch_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A266InvFch = DateTime.MinValue;
                  n266InvFch = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266InvFch", context.localUtil.Format(A266InvFch, "99/99/9999"));
               }
               else
               {
                  A266InvFch = context.localUtil.CToD( cgiGet( edtInvFch_Internalname), 2);
                  n266InvFch = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266InvFch", context.localUtil.Format(A266InvFch, "99/99/9999"));
               }
               n266InvFch = ((DateTime.MinValue==A266InvFch) ? true : false);
               dynTipoInv.Name = dynTipoInv_Internalname;
               dynTipoInv.CurrentValue = cgiGet( dynTipoInv_Internalname);
               A43TipoInv = cgiGet( dynTipoInv_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
               cmbTipoInvSigno.Name = cmbTipoInvSigno_Internalname;
               cmbTipoInvSigno.CurrentValue = cgiGet( cmbTipoInvSigno_Internalname);
               A223TipoInvSigno = (short)(NumberUtil.Val( cgiGet( cmbTipoInvSigno_Internalname), "."));
               n223TipoInvSigno = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
               A267InvEst = ((StringUtil.StrCmp(cgiGet( chkInvEst_Internalname), "A")==0) ? "A" : "N");
               n267InvEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267InvEst", A267InvEst);
               n267InvEst = (String.IsNullOrEmpty(StringUtil.RTrim( A267InvEst)) ? true : false);
               A268InvGuia = cgiGet( edtInvGuia_Internalname);
               n268InvGuia = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268InvGuia", A268InvGuia);
               n268InvGuia = (String.IsNullOrEmpty(StringUtil.RTrim( A268InvGuia)) ? true : false);
               A269InvFac = cgiGet( edtInvFac_Internalname);
               n269InvFac = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269InvFac", A269InvFac);
               n269InvFac = (String.IsNullOrEmpty(StringUtil.RTrim( A269InvFac)) ? true : false);
               A272InvUltNro = (int)(context.localUtil.CToN( cgiGet( edtInvUltNro_Internalname), ",", "."));
               n272InvUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
               A281detInvTotal = context.localUtil.CToN( cgiGet( edtdetInvTotal_Internalname), ",", ".");
               n281detInvTotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z2AgeID = (short)(context.localUtil.CToN( cgiGet( "Z2AgeID"), ",", "."));
               Z42BodCod = (short)(context.localUtil.CToN( cgiGet( "Z42BodCod"), ",", "."));
               Z264invCod = (short)(context.localUtil.CToN( cgiGet( "Z264invCod"), ",", "."));
               Z270InvUser = cgiGet( "Z270InvUser");
               n270InvUser = (String.IsNullOrEmpty(StringUtil.RTrim( A270InvUser)) ? true : false);
               Z265InvDsc = cgiGet( "Z265InvDsc");
               n265InvDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A265InvDsc)) ? true : false);
               Z266InvFch = context.localUtil.CToD( cgiGet( "Z266InvFch"), 0);
               n266InvFch = ((DateTime.MinValue==A266InvFch) ? true : false);
               Z267InvEst = cgiGet( "Z267InvEst");
               n267InvEst = (String.IsNullOrEmpty(StringUtil.RTrim( A267InvEst)) ? true : false);
               Z268InvGuia = cgiGet( "Z268InvGuia");
               n268InvGuia = (String.IsNullOrEmpty(StringUtil.RTrim( A268InvGuia)) ? true : false);
               Z269InvFac = cgiGet( "Z269InvFac");
               n269InvFac = (String.IsNullOrEmpty(StringUtil.RTrim( A269InvFac)) ? true : false);
               Z271InvHora = DateTimeUtil.ResetDate(context.localUtil.CToT( cgiGet( "Z271InvHora"), 0));
               n271InvHora = ((DateTime.MinValue==A271InvHora) ? true : false);
               Z272InvUltNro = (int)(context.localUtil.CToN( cgiGet( "Z272InvUltNro"), ",", "."));
               n272InvUltNro = ((0==A272InvUltNro) ? true : false);
               Z43TipoInv = cgiGet( "Z43TipoInv");
               O272InvUltNro = (int)(context.localUtil.CToN( cgiGet( "O272InvUltNro"), ",", "."));
               n272InvUltNro = ((0==A272InvUltNro) ? true : false);
               O281detInvTotal = context.localUtil.CToN( cgiGet( "O281detInvTotal"), ",", ".");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_125 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_125"), ",", "."));
               nRC_GXsfl_148 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_148"), ",", "."));
               N43TipoInv = cgiGet( "N43TipoInv");
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8AgeID = (short)(context.localUtil.CToN( cgiGet( "vAGEID"), ",", "."));
               AV9BodCod = (short)(context.localUtil.CToN( cgiGet( "vBODCOD"), ",", "."));
               AV10invCod = (short)(context.localUtil.CToN( cgiGet( "vINVCOD"), ",", "."));
               AV14Insert_TipoInv = cgiGet( "vINSERT_TIPOINV");
               AV16usuCod = cgiGet( "vUSUCOD");
               AV17horaNow = DateTimeUtil.ResetDate(context.localUtil.CToT( cgiGet( "vHORANOW"), 0));
               A219TipoInvMov = cgiGet( "TIPOINVMOV");
               n219TipoInvMov = false;
               AV19Pgmname = cgiGet( "vPGMNAME");
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Inventario";
               A271InvHora = DateTimeUtil.ResetDate(context.localUtil.CToT( cgiGet( edtInvHora_Internalname)));
               n271InvHora = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271InvHora", context.localUtil.TToC( A271InvHora, 0, 5, 0, 3, "/", ":", " "));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A271InvHora, "99:99");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV14Insert_TipoInv, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( A264invCod != Z264invCod ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("inventario:[SecurityCheckFailed value for]"+"InvHora:"+context.localUtil.Format( A271InvHora, "99:99"));
                  GXUtil.WriteLog("inventario:[SecurityCheckFailed value for]"+"Insert_TipoInv:"+StringUtil.RTrim( context.localUtil.Format( AV14Insert_TipoInv, "")));
                  GXUtil.WriteLog("inventario:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A42BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
                  A264invCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
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
                     sMode48 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode48;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound48 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0S0( ) ;
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
                        E110S2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120S2 ();
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
            E120S2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0S48( ) ;
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
            DisableAttributes0S48( ) ;
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

      protected void CONFIRM_0S0( )
      {
         BeforeValidate0S48( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0S48( ) ;
            }
            else
            {
               CheckExtendedTable0S48( ) ;
               CloseExtendedTableCursors0S48( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode48 = Gx_mode;
            CONFIRM_0S51( ) ;
            if ( AnyError == 0 )
            {
               CONFIRM_0S50( ) ;
               if ( AnyError == 0 )
               {
                  /* Restore parent mode. */
                  Gx_mode = sMode48;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  IsConfirmed = 1;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
               }
            }
            /* Restore parent mode. */
            Gx_mode = sMode48;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0S50( )
      {
         nGXsfl_148_idx = 0;
         while ( nGXsfl_148_idx < nRC_GXsfl_148 )
         {
            ReadRow0S50( ) ;
            if ( ( nRcdExists_50 != 0 ) || ( nIsMod_50 != 0 ) )
            {
               GetKey0S50( ) ;
               if ( ( nRcdExists_50 == 0 ) && ( nRcdDeleted_50 == 0 ) )
               {
                  if ( RcdFound50 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0S50( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0S50( ) ;
                        CloseExtendedTableCursors0S50( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "DETINVOCID_" + sGXsfl_148_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtdetInvOcId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound50 != 0 )
                  {
                     if ( nRcdDeleted_50 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0S50( ) ;
                        Load0S50( ) ;
                        BeforeValidate0S50( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0S50( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_50 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0S50( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0S50( ) ;
                              CloseExtendedTableCursors0S50( ) ;
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
                     if ( nRcdDeleted_50 == 0 )
                     {
                        GXCCtl = "DETINVOCID_" + sGXsfl_148_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtdetInvOcId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtdetInvOcId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A282detInvOcId), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrvRuc_Internalname, StringUtil.RTrim( A37PrvRuc)) ;
            ChangePostValue( edtPrvDsc_Internalname, A184PrvDsc) ;
            ChangePostValue( edtPrvEst_Internalname, StringUtil.RTrim( A185PrvEst)) ;
            ChangePostValue( edtdetInvOCNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A283detInvOCNro), 8, 0, ",", ""))) ;
            ChangePostValue( edtdetInvOcDoc_Internalname, StringUtil.RTrim( A284detInvOcDoc)) ;
            ChangePostValue( "ZT_"+"Z282detInvOcId_"+sGXsfl_148_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z282detInvOcId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z283detInvOCNro_"+sGXsfl_148_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z283detInvOCNro), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z284detInvOcDoc_"+sGXsfl_148_idx, StringUtil.RTrim( Z284detInvOcDoc)) ;
            ChangePostValue( "ZT_"+"Z37PrvRuc_"+sGXsfl_148_idx, StringUtil.RTrim( Z37PrvRuc)) ;
            ChangePostValue( "nRcdDeleted_50_"+sGXsfl_148_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_50), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_50_"+sGXsfl_148_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_50), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_50_"+sGXsfl_148_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_50), 4, 0, ",", ""))) ;
            if ( nIsMod_50 != 0 )
            {
               ChangePostValue( "DETINVOCID_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOcId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRVRUC_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvRuc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRVDSC_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRVEST_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvEst_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVOCNRO_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOCNro_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVOCDOC_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOcDoc_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_0S51( )
      {
         s272InvUltNro = O272InvUltNro;
         n272InvUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
         s281detInvTotal = O281detInvTotal;
         n281detInvTotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         nGXsfl_125_idx = 0;
         while ( nGXsfl_125_idx < nRC_GXsfl_125 )
         {
            ReadRow0S51( ) ;
            if ( ( nRcdExists_51 != 0 ) || ( nIsMod_51 != 0 ) )
            {
               GetKey0S51( ) ;
               if ( ( nRcdExists_51 == 0 ) && ( nRcdDeleted_51 == 0 ) )
               {
                  if ( RcdFound51 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0S51( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0S51( ) ;
                        CloseExtendedTableCursors0S51( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O272InvUltNro = A272InvUltNro;
                        n272InvUltNro = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
                        O281detInvTotal = A281detInvTotal;
                        n281detInvTotal = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
                     }
                  }
                  else
                  {
                     GXCCtl = "DETINVID_" + sGXsfl_125_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtdetInvId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound51 != 0 )
                  {
                     if ( nRcdDeleted_51 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0S51( ) ;
                        Load0S51( ) ;
                        BeforeValidate0S51( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0S51( ) ;
                           O272InvUltNro = A272InvUltNro;
                           n272InvUltNro = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
                           O281detInvTotal = A281detInvTotal;
                           n281detInvTotal = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_51 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0S51( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0S51( ) ;
                              CloseExtendedTableCursors0S51( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O272InvUltNro = A272InvUltNro;
                              n272InvUltNro = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
                              O281detInvTotal = A281detInvTotal;
                              n281detInvTotal = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_51 == 0 )
                     {
                        GXCCtl = "DETINVID_" + sGXsfl_125_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtdetInvId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtdetInvId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A273detInvId), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtprdNombre_Internalname, A309prdNombre) ;
            ChangePostValue( edtdetInvUniCod_Internalname, StringUtil.RTrim( A341detInvUniCod)) ;
            ChangePostValue( edtdetInvCant_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A274detInvCant), 8, 0, ",", ""))) ;
            ChangePostValue( edtdetInvCosto_Internalname, StringUtil.LTrim( StringUtil.NToC( A275detInvCosto, 8, 2, ",", ""))) ;
            ChangePostValue( edtdetInvCostUni_Internalname, StringUtil.LTrim( StringUtil.NToC( A276detInvCostUni, 13, 2, ",", ""))) ;
            ChangePostValue( edtdetInvImporte_Internalname, StringUtil.LTrim( StringUtil.NToC( A277detInvImporte, 13, 2, ",", ""))) ;
            ChangePostValue( edtdetInvStock_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A280detInvStock), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z273detInvId_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z273detInvId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z341detInvUniCod_"+sGXsfl_125_idx, StringUtil.RTrim( Z341detInvUniCod)) ;
            ChangePostValue( "ZT_"+"Z274detInvCant_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z274detInvCant), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z275detInvCosto_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( Z275detInvCosto, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( "T277detInvImporte_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( O277detInvImporte, 10, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_51_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_51), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_51_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_51), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_51_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_51), 4, 0, ",", ""))) ;
            if ( nIsMod_51 != 0 )
            {
               ChangePostValue( "DETINVID_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDCOD_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDNOMBRE_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVUNICOD_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvUniCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVCANT_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVCOSTO_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCosto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVCOSTUNI_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCostUni_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVIMPORTE_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvImporte_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVSTOCK_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvStock_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O272InvUltNro = s272InvUltNro;
         n272InvUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
         O281detInvTotal = s281detInvTotal;
         n281detInvTotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0S0( )
      {
      }

      protected void E110S2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV19Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV19Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV12TrnContext.FromXml(AV13WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV14Insert_TipoInv = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_TipoInv", AV14Insert_TipoInv);
         if ( ( StringUtil.StrCmp(AV12TrnContext.gxTpr_Transactionname, AV19Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV20GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GXV1), 8, 0)));
            while ( AV20GXV1 <= AV12TrnContext.gxTpr_Attributes.Count )
            {
               AV15TrnContextAtt = ((SdtTransactionContext_Attribute)AV12TrnContext.gxTpr_Attributes.Item(AV20GXV1));
               if ( StringUtil.StrCmp(AV15TrnContextAtt.gxTpr_Attributename, "TipoInv") == 0 )
               {
                  AV14Insert_TipoInv = AV15TrnContextAtt.gxTpr_Attributevalue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_TipoInv", AV14Insert_TipoInv);
               }
               AV20GXV1 = (int)(AV20GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GXV1), 8, 0)));
            }
         }
         edtInvUser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvUser_Enabled), 5, 0)), true);
         edtEmpID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Visible), 5, 0)), true);
         edtAgeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Visible), 5, 0)), true);
      }

      protected void E120S2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV12TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwinventario.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0S48( short GX_JID )
      {
         if ( ( GX_JID == 33 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z270InvUser = T000S9_A270InvUser[0];
               Z265InvDsc = T000S9_A265InvDsc[0];
               Z266InvFch = T000S9_A266InvFch[0];
               Z267InvEst = T000S9_A267InvEst[0];
               Z268InvGuia = T000S9_A268InvGuia[0];
               Z269InvFac = T000S9_A269InvFac[0];
               Z271InvHora = T000S9_A271InvHora[0];
               Z272InvUltNro = T000S9_A272InvUltNro[0];
               Z43TipoInv = T000S9_A43TipoInv[0];
            }
            else
            {
               Z270InvUser = A270InvUser;
               Z265InvDsc = A265InvDsc;
               Z266InvFch = A266InvFch;
               Z267InvEst = A267InvEst;
               Z268InvGuia = A268InvGuia;
               Z269InvFac = A269InvFac;
               Z271InvHora = A271InvHora;
               Z272InvUltNro = A272InvUltNro;
               Z43TipoInv = A43TipoInv;
            }
         }
         if ( GX_JID == -33 )
         {
            Z264invCod = A264invCod;
            Z270InvUser = A270InvUser;
            Z265InvDsc = A265InvDsc;
            Z266InvFch = A266InvFch;
            Z267InvEst = A267InvEst;
            Z268InvGuia = A268InvGuia;
            Z269InvFac = A269InvFac;
            Z271InvHora = A271InvHora;
            Z272InvUltNro = A272InvUltNro;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z43TipoInv = A43TipoInv;
            Z44empdsc = A44empdsc;
            Z46AgeDsc = A46AgeDsc;
            Z217BodDsc = A217BodDsc;
            Z281detInvTotal = A281detInvTotal;
            Z219TipoInvMov = A219TipoInvMov;
            Z223TipoInvSigno = A223TipoInvSigno;
         }
      }

      protected void standaloneNotModal( )
      {
         GXATIPOINV_html0S48( ) ;
         AV17horaNow = DateTimeUtil.ResetDate(DateTimeUtil.ServerNow( context, pr_default));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17horaNow", context.localUtil.TToC( AV17horaNow, 0, 5, 0, 3, "/", ":", " "));
         edtInvUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvUltNro_Enabled), 5, 0)), true);
         edtInvHora_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvHora_Enabled), 5, 0)), true);
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_2_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0021.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_42_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00y1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"BODCOD"+"'), id:'"+"BODCOD"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         edtInvUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvUltNro_Enabled), 5, 0)), true);
         edtInvHora_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvHora_Enabled), 5, 0)), true);
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
         if ( ! (0==AV9BodCod) )
         {
            A42BodCod = AV9BodCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         }
         if ( ! (0==AV9BodCod) )
         {
            edtBodCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtBodCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV9BodCod) )
         {
            edtBodCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10invCod) )
         {
            A264invCod = AV10invCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
         }
         if ( ! (0==AV10invCod) )
         {
            edtinvCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtinvCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtinvCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtinvCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtinvCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtinvCod_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10invCod) )
         {
            edtinvCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtinvCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtinvCod_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV14Insert_TipoInv)) )
         {
            dynTipoInv.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTipoInv.Enabled), 5, 0)), true);
         }
         else
         {
            dynTipoInv.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTipoInv.Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV14Insert_TipoInv)) )
         {
            A43TipoInv = AV14Insert_TipoInv;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         }
         A270InvUser = AV16usuCod;
         n270InvUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270InvUser", A270InvUser);
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A271InvHora = AV17horaNow;
            n271InvHora = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271InvHora", context.localUtil.TToC( A271InvHora, 0, 5, 0, 3, "/", ":", " "));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T000S13 */
            pr_default.execute(11, new Object[] {A43TipoInv});
            A219TipoInvMov = T000S13_A219TipoInvMov[0];
            n219TipoInvMov = T000S13_n219TipoInvMov[0];
            A223TipoInvSigno = T000S13_A223TipoInvSigno[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
            n223TipoInvSigno = T000S13_n223TipoInvSigno[0];
            pr_default.close(11);
            /* Using cursor T000S10 */
            pr_default.execute(8, new Object[] {A1EmpID});
            A44empdsc = T000S10_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000S10_n44empdsc[0];
            pr_default.close(8);
            AV19Pgmname = "Inventario";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
            /* Using cursor T000S11 */
            pr_default.execute(9, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T000S11_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000S11_n46AgeDsc[0];
            pr_default.close(9);
            /* Using cursor T000S12 */
            pr_default.execute(10, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = T000S12_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000S12_n217BodDsc[0];
            pr_default.close(10);
            /* Using cursor T000S15 */
            pr_default.execute(12, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
            if ( (pr_default.getStatus(12) != 101) )
            {
               A281detInvTotal = T000S15_A281detInvTotal[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
               n281detInvTotal = T000S15_n281detInvTotal[0];
            }
            else
            {
               A281detInvTotal = 0;
               n281detInvTotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            }
            O281detInvTotal = A281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            pr_default.close(12);
         }
      }

      protected void Load0S48( )
      {
         /* Using cursor T000S17 */
         pr_default.execute(13, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound48 = 1;
            A270InvUser = T000S17_A270InvUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270InvUser", A270InvUser);
            n270InvUser = T000S17_n270InvUser[0];
            A44empdsc = T000S17_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000S17_n44empdsc[0];
            A46AgeDsc = T000S17_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000S17_n46AgeDsc[0];
            A217BodDsc = T000S17_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000S17_n217BodDsc[0];
            A265InvDsc = T000S17_A265InvDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265InvDsc", A265InvDsc);
            n265InvDsc = T000S17_n265InvDsc[0];
            A266InvFch = T000S17_A266InvFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266InvFch", context.localUtil.Format(A266InvFch, "99/99/9999"));
            n266InvFch = T000S17_n266InvFch[0];
            A219TipoInvMov = T000S17_A219TipoInvMov[0];
            n219TipoInvMov = T000S17_n219TipoInvMov[0];
            A223TipoInvSigno = T000S17_A223TipoInvSigno[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
            n223TipoInvSigno = T000S17_n223TipoInvSigno[0];
            A267InvEst = T000S17_A267InvEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267InvEst", A267InvEst);
            n267InvEst = T000S17_n267InvEst[0];
            A268InvGuia = T000S17_A268InvGuia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268InvGuia", A268InvGuia);
            n268InvGuia = T000S17_n268InvGuia[0];
            A269InvFac = T000S17_A269InvFac[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269InvFac", A269InvFac);
            n269InvFac = T000S17_n269InvFac[0];
            A271InvHora = T000S17_A271InvHora[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271InvHora", context.localUtil.TToC( A271InvHora, 0, 5, 0, 3, "/", ":", " "));
            n271InvHora = T000S17_n271InvHora[0];
            A272InvUltNro = T000S17_A272InvUltNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            n272InvUltNro = T000S17_n272InvUltNro[0];
            A43TipoInv = T000S17_A43TipoInv[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            A281detInvTotal = T000S17_A281detInvTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            n281detInvTotal = T000S17_n281detInvTotal[0];
            ZM0S48( -33) ;
         }
         pr_default.close(13);
         OnLoadActions0S48( ) ;
      }

      protected void OnLoadActions0S48( )
      {
         O281detInvTotal = A281detInvTotal;
         n281detInvTotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         AV19Pgmname = "Inventario";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
      }

      protected void CheckExtendedTable0S48( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV19Pgmname = "Inventario";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
         /* Using cursor T000S10 */
         pr_default.execute(8, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000S10_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000S10_n44empdsc[0];
         pr_default.close(8);
         /* Using cursor T000S11 */
         pr_default.execute(9, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T000S11_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T000S11_n46AgeDsc[0];
         pr_default.close(9);
         /* Using cursor T000S12 */
         pr_default.execute(10, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A217BodDsc = T000S12_A217BodDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = T000S12_n217BodDsc[0];
         pr_default.close(10);
         /* Using cursor T000S15 */
         pr_default.execute(12, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
         if ( (pr_default.getStatus(12) != 101) )
         {
            A281detInvTotal = T000S15_A281detInvTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            n281detInvTotal = T000S15_n281detInvTotal[0];
         }
         else
         {
            A281detInvTotal = 0;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         }
         pr_default.close(12);
         if ( ! ( (DateTime.MinValue==A266InvFch) || ( A266InvFch >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "INVFCH");
            AnyError = 1;
            GX_FocusControl = edtInvFch_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T000S13 */
         pr_default.execute(11, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, "TIPOINV");
            AnyError = 1;
            GX_FocusControl = dynTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A219TipoInvMov = T000S13_A219TipoInvMov[0];
         n219TipoInvMov = T000S13_n219TipoInvMov[0];
         A223TipoInvSigno = T000S13_A223TipoInvSigno[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
         n223TipoInvSigno = T000S13_n223TipoInvSigno[0];
         pr_default.close(11);
      }

      protected void CloseExtendedTableCursors0S48( )
      {
         pr_default.close(8);
         pr_default.close(9);
         pr_default.close(10);
         pr_default.close(12);
         pr_default.close(11);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_34( short A1EmpID )
      {
         /* Using cursor T000S18 */
         pr_default.execute(14, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000S18_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000S18_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(14) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(14);
      }

      protected void gxLoad_35( short A1EmpID ,
                                short A2AgeID )
      {
         /* Using cursor T000S19 */
         pr_default.execute(15, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A46AgeDsc = T000S19_A46AgeDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         n46AgeDsc = T000S19_n46AgeDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A46AgeDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(15) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(15);
      }

      protected void gxLoad_36( short A1EmpID ,
                                short A42BodCod )
      {
         /* Using cursor T000S20 */
         pr_default.execute(16, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A217BodDsc = T000S20_A217BodDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = T000S20_n217BodDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A217BodDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(16) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(16);
      }

      protected void gxLoad_38( short A1EmpID ,
                                short A2AgeID ,
                                short A42BodCod ,
                                short A264invCod )
      {
         /* Using cursor T000S22 */
         pr_default.execute(17, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
         if ( (pr_default.getStatus(17) != 101) )
         {
            A281detInvTotal = T000S22_A281detInvTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            n281detInvTotal = T000S22_n281detInvTotal[0];
         }
         else
         {
            A281detInvTotal = 0;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A281detInvTotal, 10, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(17) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(17);
      }

      protected void gxLoad_37( String A43TipoInv )
      {
         /* Using cursor T000S23 */
         pr_default.execute(18, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, "TIPOINV");
            AnyError = 1;
            GX_FocusControl = dynTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A219TipoInvMov = T000S23_A219TipoInvMov[0];
         n219TipoInvMov = T000S23_n219TipoInvMov[0];
         A223TipoInvSigno = T000S23_A223TipoInvSigno[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
         n223TipoInvSigno = T000S23_n223TipoInvSigno[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A219TipoInvMov)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(18) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(18);
      }

      protected void GetKey0S48( )
      {
         /* Using cursor T000S24 */
         pr_default.execute(19, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound48 = 1;
         }
         else
         {
            RcdFound48 = 0;
         }
         pr_default.close(19);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000S9 */
         pr_default.execute(7, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
         if ( (pr_default.getStatus(7) != 101) )
         {
            ZM0S48( 33) ;
            RcdFound48 = 1;
            A264invCod = T000S9_A264invCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
            A270InvUser = T000S9_A270InvUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270InvUser", A270InvUser);
            n270InvUser = T000S9_n270InvUser[0];
            A265InvDsc = T000S9_A265InvDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265InvDsc", A265InvDsc);
            n265InvDsc = T000S9_n265InvDsc[0];
            A266InvFch = T000S9_A266InvFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266InvFch", context.localUtil.Format(A266InvFch, "99/99/9999"));
            n266InvFch = T000S9_n266InvFch[0];
            A267InvEst = T000S9_A267InvEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267InvEst", A267InvEst);
            n267InvEst = T000S9_n267InvEst[0];
            A268InvGuia = T000S9_A268InvGuia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268InvGuia", A268InvGuia);
            n268InvGuia = T000S9_n268InvGuia[0];
            A269InvFac = T000S9_A269InvFac[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269InvFac", A269InvFac);
            n269InvFac = T000S9_n269InvFac[0];
            A271InvHora = T000S9_A271InvHora[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271InvHora", context.localUtil.TToC( A271InvHora, 0, 5, 0, 3, "/", ":", " "));
            n271InvHora = T000S9_n271InvHora[0];
            A272InvUltNro = T000S9_A272InvUltNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            n272InvUltNro = T000S9_n272InvUltNro[0];
            A1EmpID = T000S9_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000S9_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = T000S9_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A43TipoInv = T000S9_A43TipoInv[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            O272InvUltNro = A272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z264invCod = A264invCod;
            sMode48 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0S48( ) ;
            if ( AnyError == 1 )
            {
               RcdFound48 = 0;
               InitializeNonKey0S48( ) ;
            }
            Gx_mode = sMode48;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound48 = 0;
            InitializeNonKey0S48( ) ;
            sMode48 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode48;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(7);
      }

      protected void getEqualNoModal( )
      {
         GetKey0S48( ) ;
         if ( RcdFound48 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound48 = 0;
         /* Using cursor T000S25 */
         pr_default.execute(20, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
         if ( (pr_default.getStatus(20) != 101) )
         {
            while ( (pr_default.getStatus(20) != 101) && ( ( T000S25_A1EmpID[0] < A1EmpID ) || ( T000S25_A1EmpID[0] == A1EmpID ) && ( T000S25_A2AgeID[0] < A2AgeID ) || ( T000S25_A2AgeID[0] == A2AgeID ) && ( T000S25_A1EmpID[0] == A1EmpID ) && ( T000S25_A42BodCod[0] < A42BodCod ) || ( T000S25_A42BodCod[0] == A42BodCod ) && ( T000S25_A2AgeID[0] == A2AgeID ) && ( T000S25_A1EmpID[0] == A1EmpID ) && ( T000S25_A264invCod[0] < A264invCod ) ) )
            {
               pr_default.readNext(20);
            }
            if ( (pr_default.getStatus(20) != 101) && ( ( T000S25_A1EmpID[0] > A1EmpID ) || ( T000S25_A1EmpID[0] == A1EmpID ) && ( T000S25_A2AgeID[0] > A2AgeID ) || ( T000S25_A2AgeID[0] == A2AgeID ) && ( T000S25_A1EmpID[0] == A1EmpID ) && ( T000S25_A42BodCod[0] > A42BodCod ) || ( T000S25_A42BodCod[0] == A42BodCod ) && ( T000S25_A2AgeID[0] == A2AgeID ) && ( T000S25_A1EmpID[0] == A1EmpID ) && ( T000S25_A264invCod[0] > A264invCod ) ) )
            {
               A1EmpID = T000S25_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000S25_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A42BodCod = T000S25_A42BodCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               A264invCod = T000S25_A264invCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
               RcdFound48 = 1;
            }
         }
         pr_default.close(20);
      }

      protected void move_previous( )
      {
         RcdFound48 = 0;
         /* Using cursor T000S26 */
         pr_default.execute(21, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
         if ( (pr_default.getStatus(21) != 101) )
         {
            while ( (pr_default.getStatus(21) != 101) && ( ( T000S26_A1EmpID[0] > A1EmpID ) || ( T000S26_A1EmpID[0] == A1EmpID ) && ( T000S26_A2AgeID[0] > A2AgeID ) || ( T000S26_A2AgeID[0] == A2AgeID ) && ( T000S26_A1EmpID[0] == A1EmpID ) && ( T000S26_A42BodCod[0] > A42BodCod ) || ( T000S26_A42BodCod[0] == A42BodCod ) && ( T000S26_A2AgeID[0] == A2AgeID ) && ( T000S26_A1EmpID[0] == A1EmpID ) && ( T000S26_A264invCod[0] > A264invCod ) ) )
            {
               pr_default.readNext(21);
            }
            if ( (pr_default.getStatus(21) != 101) && ( ( T000S26_A1EmpID[0] < A1EmpID ) || ( T000S26_A1EmpID[0] == A1EmpID ) && ( T000S26_A2AgeID[0] < A2AgeID ) || ( T000S26_A2AgeID[0] == A2AgeID ) && ( T000S26_A1EmpID[0] == A1EmpID ) && ( T000S26_A42BodCod[0] < A42BodCod ) || ( T000S26_A42BodCod[0] == A42BodCod ) && ( T000S26_A2AgeID[0] == A2AgeID ) && ( T000S26_A1EmpID[0] == A1EmpID ) && ( T000S26_A264invCod[0] < A264invCod ) ) )
            {
               A1EmpID = T000S26_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000S26_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A42BodCod = T000S26_A42BodCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               A264invCod = T000S26_A264invCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
               RcdFound48 = 1;
            }
         }
         pr_default.close(21);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0S48( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A272InvUltNro = O272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            A281detInvTotal = O281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            GX_FocusControl = edtInvUser_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0S48( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound48 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( A264invCod != Z264invCod ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A2AgeID = Z2AgeID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A42BodCod = Z42BodCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
                  A264invCod = Z264invCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A272InvUltNro = O272InvUltNro;
                  n272InvUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
                  A281detInvTotal = O281detInvTotal;
                  n281detInvTotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtInvUser_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A272InvUltNro = O272InvUltNro;
                  n272InvUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
                  A281detInvTotal = O281detInvTotal;
                  n281detInvTotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
                  Update0S48( ) ;
                  GX_FocusControl = edtInvUser_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( A264invCod != Z264invCod ) )
               {
                  /* Insert record */
                  A272InvUltNro = O272InvUltNro;
                  n272InvUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
                  A281detInvTotal = O281detInvTotal;
                  n281detInvTotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
                  GX_FocusControl = edtInvUser_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0S48( ) ;
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
                     A272InvUltNro = O272InvUltNro;
                     n272InvUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
                     A281detInvTotal = O281detInvTotal;
                     n281detInvTotal = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
                     GX_FocusControl = edtInvUser_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0S48( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( A264invCod != Z264invCod ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = Z2AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = Z42BodCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A264invCod = Z264invCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A272InvUltNro = O272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            A281detInvTotal = O281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtInvUser_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0S48( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000S8 */
            pr_default.execute(6, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Inventario"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z270InvUser, T000S8_A270InvUser[0]) != 0 ) || ( StringUtil.StrCmp(Z265InvDsc, T000S8_A265InvDsc[0]) != 0 ) || ( Z266InvFch != T000S8_A266InvFch[0] ) || ( StringUtil.StrCmp(Z267InvEst, T000S8_A267InvEst[0]) != 0 ) || ( StringUtil.StrCmp(Z268InvGuia, T000S8_A268InvGuia[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z269InvFac, T000S8_A269InvFac[0]) != 0 ) || ( Z271InvHora != T000S8_A271InvHora[0] ) || ( Z272InvUltNro != T000S8_A272InvUltNro[0] ) || ( StringUtil.StrCmp(Z43TipoInv, T000S8_A43TipoInv[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z270InvUser, T000S8_A270InvUser[0]) != 0 )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"InvUser");
                  GXUtil.WriteLogRaw("Old: ",Z270InvUser);
                  GXUtil.WriteLogRaw("Current: ",T000S8_A270InvUser[0]);
               }
               if ( StringUtil.StrCmp(Z265InvDsc, T000S8_A265InvDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"InvDsc");
                  GXUtil.WriteLogRaw("Old: ",Z265InvDsc);
                  GXUtil.WriteLogRaw("Current: ",T000S8_A265InvDsc[0]);
               }
               if ( Z266InvFch != T000S8_A266InvFch[0] )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"InvFch");
                  GXUtil.WriteLogRaw("Old: ",Z266InvFch);
                  GXUtil.WriteLogRaw("Current: ",T000S8_A266InvFch[0]);
               }
               if ( StringUtil.StrCmp(Z267InvEst, T000S8_A267InvEst[0]) != 0 )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"InvEst");
                  GXUtil.WriteLogRaw("Old: ",Z267InvEst);
                  GXUtil.WriteLogRaw("Current: ",T000S8_A267InvEst[0]);
               }
               if ( StringUtil.StrCmp(Z268InvGuia, T000S8_A268InvGuia[0]) != 0 )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"InvGuia");
                  GXUtil.WriteLogRaw("Old: ",Z268InvGuia);
                  GXUtil.WriteLogRaw("Current: ",T000S8_A268InvGuia[0]);
               }
               if ( StringUtil.StrCmp(Z269InvFac, T000S8_A269InvFac[0]) != 0 )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"InvFac");
                  GXUtil.WriteLogRaw("Old: ",Z269InvFac);
                  GXUtil.WriteLogRaw("Current: ",T000S8_A269InvFac[0]);
               }
               if ( Z271InvHora != T000S8_A271InvHora[0] )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"InvHora");
                  GXUtil.WriteLogRaw("Old: ",Z271InvHora);
                  GXUtil.WriteLogRaw("Current: ",T000S8_A271InvHora[0]);
               }
               if ( Z272InvUltNro != T000S8_A272InvUltNro[0] )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"InvUltNro");
                  GXUtil.WriteLogRaw("Old: ",Z272InvUltNro);
                  GXUtil.WriteLogRaw("Current: ",T000S8_A272InvUltNro[0]);
               }
               if ( StringUtil.StrCmp(Z43TipoInv, T000S8_A43TipoInv[0]) != 0 )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"TipoInv");
                  GXUtil.WriteLogRaw("Old: ",Z43TipoInv);
                  GXUtil.WriteLogRaw("Current: ",T000S8_A43TipoInv[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Inventario"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0S48( )
      {
         BeforeValidate0S48( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S48( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0S48( 0) ;
            CheckOptimisticConcurrency0S48( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S48( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0S48( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S27 */
                     pr_default.execute(22, new Object[] {A264invCod, n270InvUser, A270InvUser, n265InvDsc, A265InvDsc, n266InvFch, A266InvFch, n267InvEst, A267InvEst, n268InvGuia, A268InvGuia, n269InvFac, A269InvFac, n271InvHora, A271InvHora, n272InvUltNro, A272InvUltNro, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
                     pr_default.close(22);
                     dsDefault.SmartCacheProvider.SetUpdated("Inventario") ;
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
                           ProcessLevel0S48( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0S0( ) ;
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
               Load0S48( ) ;
            }
            EndLevel0S48( ) ;
         }
         CloseExtendedTableCursors0S48( ) ;
      }

      protected void Update0S48( )
      {
         BeforeValidate0S48( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S48( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S48( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S48( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0S48( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S28 */
                     pr_default.execute(23, new Object[] {n270InvUser, A270InvUser, n265InvDsc, A265InvDsc, n266InvFch, A266InvFch, n267InvEst, A267InvEst, n268InvGuia, A268InvGuia, n269InvFac, A269InvFac, n271InvHora, A271InvHora, n272InvUltNro, A272InvUltNro, A43TipoInv, A1EmpID, A2AgeID, A42BodCod, A264invCod});
                     pr_default.close(23);
                     dsDefault.SmartCacheProvider.SetUpdated("Inventario") ;
                     if ( (pr_default.getStatus(23) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Inventario"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0S48( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0S48( ) ;
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
            EndLevel0S48( ) ;
         }
         CloseExtendedTableCursors0S48( ) ;
      }

      protected void DeferredUpdate0S48( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0S48( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S48( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0S48( ) ;
            AfterConfirm0S48( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0S48( ) ;
               if ( AnyError == 0 )
               {
                  A272InvUltNro = O272InvUltNro;
                  n272InvUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
                  A281detInvTotal = O281detInvTotal;
                  n281detInvTotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
                  ScanStart0S51( ) ;
                  while ( RcdFound51 != 0 )
                  {
                     getByPrimaryKey0S51( ) ;
                     Delete0S51( ) ;
                     ScanNext0S51( ) ;
                     O272InvUltNro = A272InvUltNro;
                     n272InvUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
                     O281detInvTotal = A281detInvTotal;
                     n281detInvTotal = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
                  }
                  ScanEnd0S51( ) ;
                  ScanStart0S50( ) ;
                  while ( RcdFound50 != 0 )
                  {
                     getByPrimaryKey0S50( ) ;
                     Delete0S50( ) ;
                     ScanNext0S50( ) ;
                  }
                  ScanEnd0S50( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S29 */
                     pr_default.execute(24, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
                     pr_default.close(24);
                     dsDefault.SmartCacheProvider.SetUpdated("Inventario") ;
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
         sMode48 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0S48( ) ;
         Gx_mode = sMode48;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0S48( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV19Pgmname = "Inventario";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
            /* Using cursor T000S30 */
            pr_default.execute(25, new Object[] {A1EmpID});
            A44empdsc = T000S30_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000S30_n44empdsc[0];
            pr_default.close(25);
            /* Using cursor T000S31 */
            pr_default.execute(26, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = T000S31_A46AgeDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
            n46AgeDsc = T000S31_n46AgeDsc[0];
            pr_default.close(26);
            /* Using cursor T000S32 */
            pr_default.execute(27, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = T000S32_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000S32_n217BodDsc[0];
            pr_default.close(27);
            /* Using cursor T000S34 */
            pr_default.execute(28, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
            if ( (pr_default.getStatus(28) != 101) )
            {
               A281detInvTotal = T000S34_A281detInvTotal[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
               n281detInvTotal = T000S34_n281detInvTotal[0];
            }
            else
            {
               A281detInvTotal = 0;
               n281detInvTotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            }
            pr_default.close(28);
            /* Using cursor T000S35 */
            pr_default.execute(29, new Object[] {A43TipoInv});
            A219TipoInvMov = T000S35_A219TipoInvMov[0];
            n219TipoInvMov = T000S35_n219TipoInvMov[0];
            A223TipoInvSigno = T000S35_A223TipoInvSigno[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
            n223TipoInvSigno = T000S35_n223TipoInvSigno[0];
            pr_default.close(29);
         }
      }

      protected void ProcessNestedLevel0S51( )
      {
         s272InvUltNro = O272InvUltNro;
         n272InvUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
         s281detInvTotal = O281detInvTotal;
         n281detInvTotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         nGXsfl_125_idx = 0;
         while ( nGXsfl_125_idx < nRC_GXsfl_125 )
         {
            ReadRow0S51( ) ;
            if ( ( nRcdExists_51 != 0 ) || ( nIsMod_51 != 0 ) )
            {
               standaloneNotModal0S51( ) ;
               GetKey0S51( ) ;
               if ( ( nRcdExists_51 == 0 ) && ( nRcdDeleted_51 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0S51( ) ;
               }
               else
               {
                  if ( RcdFound51 != 0 )
                  {
                     if ( ( nRcdDeleted_51 != 0 ) && ( nRcdExists_51 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0S51( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_51 != 0 ) && ( nRcdExists_51 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0S51( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_51 == 0 )
                     {
                        GXCCtl = "DETINVID_" + sGXsfl_125_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtdetInvId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O272InvUltNro = A272InvUltNro;
               n272InvUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
               O281detInvTotal = A281detInvTotal;
               n281detInvTotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            }
            ChangePostValue( edtdetInvId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A273detInvId), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtprdNombre_Internalname, A309prdNombre) ;
            ChangePostValue( edtdetInvUniCod_Internalname, StringUtil.RTrim( A341detInvUniCod)) ;
            ChangePostValue( edtdetInvCant_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A274detInvCant), 8, 0, ",", ""))) ;
            ChangePostValue( edtdetInvCosto_Internalname, StringUtil.LTrim( StringUtil.NToC( A275detInvCosto, 8, 2, ",", ""))) ;
            ChangePostValue( edtdetInvCostUni_Internalname, StringUtil.LTrim( StringUtil.NToC( A276detInvCostUni, 13, 2, ",", ""))) ;
            ChangePostValue( edtdetInvImporte_Internalname, StringUtil.LTrim( StringUtil.NToC( A277detInvImporte, 13, 2, ",", ""))) ;
            ChangePostValue( edtdetInvStock_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A280detInvStock), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z273detInvId_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z273detInvId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z341detInvUniCod_"+sGXsfl_125_idx, StringUtil.RTrim( Z341detInvUniCod)) ;
            ChangePostValue( "ZT_"+"Z274detInvCant_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z274detInvCant), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z275detInvCosto_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( Z275detInvCosto, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( "T277detInvImporte_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( O277detInvImporte, 10, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_51_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_51), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_51_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_51), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_51_"+sGXsfl_125_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_51), 4, 0, ",", ""))) ;
            if ( nIsMod_51 != 0 )
            {
               ChangePostValue( "DETINVID_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDCOD_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDNOMBRE_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVUNICOD_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvUniCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVCANT_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVCOSTO_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCosto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVCOSTUNI_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCostUni_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVIMPORTE_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvImporte_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVSTOCK_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvStock_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0S51( ) ;
         if ( AnyError != 0 )
         {
            O272InvUltNro = s272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            O281detInvTotal = s281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         }
         nRcdExists_51 = 0;
         nIsMod_51 = 0;
         nRcdDeleted_51 = 0;
      }

      protected void ProcessNestedLevel0S50( )
      {
         nGXsfl_148_idx = 0;
         while ( nGXsfl_148_idx < nRC_GXsfl_148 )
         {
            ReadRow0S50( ) ;
            if ( ( nRcdExists_50 != 0 ) || ( nIsMod_50 != 0 ) )
            {
               standaloneNotModal0S50( ) ;
               GetKey0S50( ) ;
               if ( ( nRcdExists_50 == 0 ) && ( nRcdDeleted_50 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0S50( ) ;
               }
               else
               {
                  if ( RcdFound50 != 0 )
                  {
                     if ( ( nRcdDeleted_50 != 0 ) && ( nRcdExists_50 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0S50( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_50 != 0 ) && ( nRcdExists_50 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0S50( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_50 == 0 )
                     {
                        GXCCtl = "DETINVOCID_" + sGXsfl_148_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtdetInvOcId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtdetInvOcId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A282detInvOcId), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrvRuc_Internalname, StringUtil.RTrim( A37PrvRuc)) ;
            ChangePostValue( edtPrvDsc_Internalname, A184PrvDsc) ;
            ChangePostValue( edtPrvEst_Internalname, StringUtil.RTrim( A185PrvEst)) ;
            ChangePostValue( edtdetInvOCNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A283detInvOCNro), 8, 0, ",", ""))) ;
            ChangePostValue( edtdetInvOcDoc_Internalname, StringUtil.RTrim( A284detInvOcDoc)) ;
            ChangePostValue( "ZT_"+"Z282detInvOcId_"+sGXsfl_148_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z282detInvOcId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z283detInvOCNro_"+sGXsfl_148_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z283detInvOCNro), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z284detInvOcDoc_"+sGXsfl_148_idx, StringUtil.RTrim( Z284detInvOcDoc)) ;
            ChangePostValue( "ZT_"+"Z37PrvRuc_"+sGXsfl_148_idx, StringUtil.RTrim( Z37PrvRuc)) ;
            ChangePostValue( "nRcdDeleted_50_"+sGXsfl_148_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_50), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_50_"+sGXsfl_148_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_50), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_50_"+sGXsfl_148_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_50), 4, 0, ",", ""))) ;
            if ( nIsMod_50 != 0 )
            {
               ChangePostValue( "DETINVOCID_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOcId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRVRUC_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvRuc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRVDSC_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRVEST_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvEst_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVOCNRO_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOCNro_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETINVOCDOC_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOcDoc_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0S50( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_50 = 0;
         nIsMod_50 = 0;
         nRcdDeleted_50 = 0;
      }

      protected void ProcessLevel0S48( )
      {
         /* Save parent mode. */
         sMode48 = Gx_mode;
         ProcessNestedLevel0S51( ) ;
         ProcessNestedLevel0S50( ) ;
         if ( AnyError != 0 )
         {
            O272InvUltNro = s272InvUltNro;
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
            O281detInvTotal = s281detInvTotal;
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode48;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T000S36 */
         pr_default.execute(30, new Object[] {n272InvUltNro, A272InvUltNro, A1EmpID, A2AgeID, A42BodCod, A264invCod});
         pr_default.close(30);
         dsDefault.SmartCacheProvider.SetUpdated("Inventario") ;
      }

      protected void EndLevel0S48( )
      {
         pr_default.close(6);
         if ( AnyError == 0 )
         {
            BeforeComplete0S48( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(4);
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(25);
            pr_default.close(26);
            pr_default.close(27);
            pr_default.close(29);
            pr_default.close(28);
            pr_default.close(5);
            pr_default.close(2);
            context.CommitDataStores("inventario",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0S0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(4);
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(25);
            pr_default.close(26);
            pr_default.close(27);
            pr_default.close(29);
            pr_default.close(28);
            pr_default.close(5);
            pr_default.close(2);
            context.RollbackDataStores("inventario",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0S48( )
      {
         /* Scan By routine */
         /* Using cursor T000S37 */
         pr_default.execute(31);
         RcdFound48 = 0;
         if ( (pr_default.getStatus(31) != 101) )
         {
            RcdFound48 = 1;
            A1EmpID = T000S37_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000S37_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = T000S37_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A264invCod = T000S37_A264invCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0S48( )
      {
         /* Scan next routine */
         pr_default.readNext(31);
         RcdFound48 = 0;
         if ( (pr_default.getStatus(31) != 101) )
         {
            RcdFound48 = 1;
            A1EmpID = T000S37_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000S37_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = T000S37_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A264invCod = T000S37_A264invCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
         }
      }

      protected void ScanEnd0S48( )
      {
         pr_default.close(31);
      }

      protected void AfterConfirm0S48( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0S48( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0S48( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0S48( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0S48( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0S48( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0S48( )
      {
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtAgeDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeDsc_Enabled), 5, 0)), true);
         edtInvUser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvUser_Enabled), 5, 0)), true);
         edtInvHora_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvHora_Enabled), 5, 0)), true);
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtAgeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgeID_Enabled), 5, 0)), true);
         edtBodCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         edtBodDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDsc_Enabled), 5, 0)), true);
         edtinvCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtinvCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtinvCod_Enabled), 5, 0)), true);
         edtInvDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvDsc_Enabled), 5, 0)), true);
         edtInvFch_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvFch_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvFch_Enabled), 5, 0)), true);
         dynTipoInv.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynTipoInv.Enabled), 5, 0)), true);
         cmbTipoInvSigno.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoInvSigno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoInvSigno.Enabled), 5, 0)), true);
         chkInvEst.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkInvEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkInvEst.Enabled), 5, 0)), true);
         edtInvGuia_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvGuia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvGuia_Enabled), 5, 0)), true);
         edtInvFac_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvFac_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvFac_Enabled), 5, 0)), true);
         edtInvUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvUltNro_Enabled), 5, 0)), true);
         edtdetInvTotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvTotal_Enabled), 5, 0)), true);
      }

      protected void ZM0S51( short GX_JID )
      {
         if ( ( GX_JID == 39 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z341detInvUniCod = T000S6_A341detInvUniCod[0];
               Z274detInvCant = T000S6_A274detInvCant[0];
               Z275detInvCosto = T000S6_A275detInvCosto[0];
               Z286PrdCod = T000S6_A286PrdCod[0];
            }
            else
            {
               Z341detInvUniCod = A341detInvUniCod;
               Z274detInvCant = A274detInvCant;
               Z275detInvCosto = A275detInvCosto;
               Z286PrdCod = A286PrdCod;
            }
         }
         if ( GX_JID == -39 )
         {
            Z42BodCod = A42BodCod;
            Z264invCod = A264invCod;
            Z273detInvId = A273detInvId;
            Z341detInvUniCod = A341detInvUniCod;
            Z274detInvCant = A274detInvCant;
            Z275detInvCosto = A275detInvCosto;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z286PrdCod = A286PrdCod;
            Z309prdNombre = A309prdNombre;
         }
      }

      protected void standaloneNotModal0S51( )
      {
         edtdetInvUniCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvUniCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvUniCod_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         edtInvUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvUltNro_Enabled), 5, 0)), true);
         edtInvUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvUltNro_Enabled), 5, 0)), true);
      }

      protected void standaloneModal0S51( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A272InvUltNro = (int)(O272InvUltNro+1);
            n272InvUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A273detInvId = (short)(A272InvUltNro);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtdetInvId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvId_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         }
         else
         {
            edtdetInvId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvId_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         }
      }

      protected void Load0S51( )
      {
         /* Using cursor T000S38 */
         pr_default.execute(32, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A273detInvId});
         if ( (pr_default.getStatus(32) != 101) )
         {
            RcdFound51 = 1;
            A309prdNombre = T000S38_A309prdNombre[0];
            n309prdNombre = T000S38_n309prdNombre[0];
            A341detInvUniCod = T000S38_A341detInvUniCod[0];
            n341detInvUniCod = T000S38_n341detInvUniCod[0];
            A274detInvCant = T000S38_A274detInvCant[0];
            n274detInvCant = T000S38_n274detInvCant[0];
            A275detInvCosto = T000S38_A275detInvCosto[0];
            n275detInvCosto = T000S38_n275detInvCosto[0];
            A286PrdCod = T000S38_A286PrdCod[0];
            ZM0S51( -39) ;
         }
         pr_default.close(32);
         OnLoadActions0S51( ) ;
      }

      protected void OnLoadActions0S51( )
      {
         GXt_int1 = (short)(A280detInvStock);
         new obtstocks(context ).execute(  0,  0,  A1EmpID,  A286PrdCod,  A2AgeID,  A42BodCod, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         A280detInvStock = GXt_int1;
         A277detInvImporte = (decimal)(A275detInvCosto*A274detInvCant);
         O277detInvImporte = A277detInvImporte;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A281detInvTotal = (decimal)(O281detInvTotal+A277detInvImporte);
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A281detInvTotal = (decimal)(O281detInvTotal+A277detInvImporte-O277detInvImporte);
               n281detInvTotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A281detInvTotal = (decimal)(O281detInvTotal-O277detInvImporte);
                  n281detInvTotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
               }
            }
         }
         A276detInvCostUni = (decimal)(A277detInvImporte/ (decimal)(A274detInvCant));
      }

      protected void CheckExtendedTable0S51( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0S51( ) ;
         /* Using cursor T000S7 */
         pr_default.execute(5, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_125_idx;
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A309prdNombre = T000S7_A309prdNombre[0];
         n309prdNombre = T000S7_n309prdNombre[0];
         pr_default.close(5);
         GXt_int1 = (short)(A280detInvStock);
         new obtstocks(context ).execute(  0,  0,  A1EmpID,  A286PrdCod,  A2AgeID,  A42BodCod, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         A280detInvStock = GXt_int1;
         A277detInvImporte = (decimal)(A275detInvCosto*A274detInvCant);
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A281detInvTotal = (decimal)(O281detInvTotal+A277detInvImporte);
            n281detInvTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A281detInvTotal = (decimal)(O281detInvTotal+A277detInvImporte-O277detInvImporte);
               n281detInvTotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A281detInvTotal = (decimal)(O281detInvTotal-O277detInvImporte);
                  n281detInvTotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
               }
            }
         }
         A276detInvCostUni = (decimal)(A277detInvImporte/ (decimal)(A274detInvCant));
      }

      protected void CloseExtendedTableCursors0S51( )
      {
         pr_default.close(5);
      }

      protected void enableDisable0S51( )
      {
      }

      protected void gxLoad_40( short A1EmpID ,
                                short A2AgeID ,
                                short A286PrdCod )
      {
         /* Using cursor T000S39 */
         pr_default.execute(33, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(33) == 101) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_125_idx;
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A309prdNombre = T000S39_A309prdNombre[0];
         n309prdNombre = T000S39_n309prdNombre[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A309prdNombre)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(33) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(33);
      }

      protected void GetKey0S51( )
      {
         /* Using cursor T000S40 */
         pr_default.execute(34, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A273detInvId});
         if ( (pr_default.getStatus(34) != 101) )
         {
            RcdFound51 = 1;
         }
         else
         {
            RcdFound51 = 0;
         }
         pr_default.close(34);
      }

      protected void getByPrimaryKey0S51( )
      {
         /* Using cursor T000S6 */
         pr_default.execute(4, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A273detInvId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM0S51( 39) ;
            RcdFound51 = 1;
            InitializeNonKey0S51( ) ;
            A273detInvId = T000S6_A273detInvId[0];
            A341detInvUniCod = T000S6_A341detInvUniCod[0];
            n341detInvUniCod = T000S6_n341detInvUniCod[0];
            A274detInvCant = T000S6_A274detInvCant[0];
            n274detInvCant = T000S6_n274detInvCant[0];
            A275detInvCosto = T000S6_A275detInvCosto[0];
            n275detInvCosto = T000S6_n275detInvCosto[0];
            A286PrdCod = T000S6_A286PrdCod[0];
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z264invCod = A264invCod;
            Z273detInvId = A273detInvId;
            sMode51 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0S51( ) ;
            Gx_mode = sMode51;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound51 = 0;
            InitializeNonKey0S51( ) ;
            sMode51 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0S51( ) ;
            Gx_mode = sMode51;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0S51( ) ;
         }
         pr_default.close(4);
      }

      protected void CheckOptimisticConcurrency0S51( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000S5 */
            pr_default.execute(3, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A273detInvId});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"InventariodetInv"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( StringUtil.StrCmp(Z341detInvUniCod, T000S5_A341detInvUniCod[0]) != 0 ) || ( Z274detInvCant != T000S5_A274detInvCant[0] ) || ( Z275detInvCosto != T000S5_A275detInvCosto[0] ) || ( Z286PrdCod != T000S5_A286PrdCod[0] ) )
            {
               if ( StringUtil.StrCmp(Z341detInvUniCod, T000S5_A341detInvUniCod[0]) != 0 )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"detInvUniCod");
                  GXUtil.WriteLogRaw("Old: ",Z341detInvUniCod);
                  GXUtil.WriteLogRaw("Current: ",T000S5_A341detInvUniCod[0]);
               }
               if ( Z274detInvCant != T000S5_A274detInvCant[0] )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"detInvCant");
                  GXUtil.WriteLogRaw("Old: ",Z274detInvCant);
                  GXUtil.WriteLogRaw("Current: ",T000S5_A274detInvCant[0]);
               }
               if ( Z275detInvCosto != T000S5_A275detInvCosto[0] )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"detInvCosto");
                  GXUtil.WriteLogRaw("Old: ",Z275detInvCosto);
                  GXUtil.WriteLogRaw("Current: ",T000S5_A275detInvCosto[0]);
               }
               if ( Z286PrdCod != T000S5_A286PrdCod[0] )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"PrdCod");
                  GXUtil.WriteLogRaw("Old: ",Z286PrdCod);
                  GXUtil.WriteLogRaw("Current: ",T000S5_A286PrdCod[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"InventariodetInv"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0S51( )
      {
         BeforeValidate0S51( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S51( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0S51( 0) ;
            CheckOptimisticConcurrency0S51( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S51( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0S51( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S41 */
                     pr_default.execute(35, new Object[] {A42BodCod, A264invCod, A273detInvId, n341detInvUniCod, A341detInvUniCod, n274detInvCant, A274detInvCant, n275detInvCosto, A275detInvCosto, A1EmpID, A2AgeID, A286PrdCod});
                     pr_default.close(35);
                     dsDefault.SmartCacheProvider.SetUpdated("InventariodetInv") ;
                     if ( (pr_default.getStatus(35) == 1) )
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
               Load0S51( ) ;
            }
            EndLevel0S51( ) ;
         }
         CloseExtendedTableCursors0S51( ) ;
      }

      protected void Update0S51( )
      {
         BeforeValidate0S51( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S51( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S51( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S51( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0S51( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S42 */
                     pr_default.execute(36, new Object[] {n341detInvUniCod, A341detInvUniCod, n274detInvCant, A274detInvCant, n275detInvCosto, A275detInvCosto, A286PrdCod, A1EmpID, A2AgeID, A42BodCod, A264invCod, A273detInvId});
                     pr_default.close(36);
                     dsDefault.SmartCacheProvider.SetUpdated("InventariodetInv") ;
                     if ( (pr_default.getStatus(36) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"InventariodetInv"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0S51( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0S51( ) ;
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
            EndLevel0S51( ) ;
         }
         CloseExtendedTableCursors0S51( ) ;
      }

      protected void DeferredUpdate0S51( )
      {
      }

      protected void Delete0S51( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0S51( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S51( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0S51( ) ;
            AfterConfirm0S51( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0S51( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000S43 */
                  pr_default.execute(37, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A273detInvId});
                  pr_default.close(37);
                  dsDefault.SmartCacheProvider.SetUpdated("InventariodetInv") ;
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
         sMode51 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0S51( ) ;
         Gx_mode = sMode51;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0S51( )
      {
         standaloneModal0S51( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000S44 */
            pr_default.execute(38, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            A309prdNombre = T000S44_A309prdNombre[0];
            n309prdNombre = T000S44_n309prdNombre[0];
            pr_default.close(38);
            GXt_int1 = (short)(A280detInvStock);
            new obtstocks(context ).execute(  0,  0,  A1EmpID,  A286PrdCod,  A2AgeID,  A42BodCod, out  GXt_int1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A280detInvStock = GXt_int1;
            A277detInvImporte = (decimal)(A275detInvCosto*A274detInvCant);
            A276detInvCostUni = (decimal)(A277detInvImporte/ (decimal)(A274detInvCant));
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A281detInvTotal = (decimal)(O281detInvTotal+A277detInvImporte);
               n281detInvTotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A281detInvTotal = (decimal)(O281detInvTotal+A277detInvImporte-O277detInvImporte);
                  n281detInvTotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A281detInvTotal = (decimal)(O281detInvTotal-O277detInvImporte);
                     n281detInvTotal = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
                  }
               }
            }
         }
      }

      protected void EndLevel0S51( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0S51( )
      {
         /* Scan By routine */
         /* Using cursor T000S45 */
         pr_default.execute(39, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
         RcdFound51 = 0;
         if ( (pr_default.getStatus(39) != 101) )
         {
            RcdFound51 = 1;
            A273detInvId = T000S45_A273detInvId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0S51( )
      {
         /* Scan next routine */
         pr_default.readNext(39);
         RcdFound51 = 0;
         if ( (pr_default.getStatus(39) != 101) )
         {
            RcdFound51 = 1;
            A273detInvId = T000S45_A273detInvId[0];
         }
      }

      protected void ScanEnd0S51( )
      {
         pr_default.close(39);
      }

      protected void AfterConfirm0S51( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0S51( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0S51( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0S51( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0S51( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0S51( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0S51( )
      {
         edtdetInvId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvId_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         edtPrdCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         edtprdNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdNombre_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         edtdetInvUniCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvUniCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvUniCod_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         edtdetInvCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvCant_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         edtdetInvCosto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvCosto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvCosto_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         edtdetInvCostUni_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvCostUni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvCostUni_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         edtdetInvImporte_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvImporte_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvImporte_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         edtdetInvStock_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvStock_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
      }

      protected void send_integrity_lvl_hashes0S51( )
      {
      }

      protected void ZM0S50( short GX_JID )
      {
         if ( ( GX_JID == 41 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z283detInvOCNro = T000S3_A283detInvOCNro[0];
               Z284detInvOcDoc = T000S3_A284detInvOcDoc[0];
               Z37PrvRuc = T000S3_A37PrvRuc[0];
            }
            else
            {
               Z283detInvOCNro = A283detInvOCNro;
               Z284detInvOcDoc = A284detInvOcDoc;
               Z37PrvRuc = A37PrvRuc;
            }
         }
         if ( GX_JID == -41 )
         {
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z264invCod = A264invCod;
            Z282detInvOcId = A282detInvOcId;
            Z283detInvOCNro = A283detInvOCNro;
            Z284detInvOcDoc = A284detInvOcDoc;
            Z37PrvRuc = A37PrvRuc;
            Z184PrvDsc = A184PrvDsc;
            Z185PrvEst = A185PrvEst;
         }
      }

      protected void standaloneNotModal0S50( )
      {
      }

      protected void standaloneModal0S50( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtdetInvOcId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvOcId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvOcId_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
         }
         else
         {
            edtdetInvOcId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvOcId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvOcId_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
         }
      }

      protected void Load0S50( )
      {
         /* Using cursor T000S46 */
         pr_default.execute(40, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A282detInvOcId});
         if ( (pr_default.getStatus(40) != 101) )
         {
            RcdFound50 = 1;
            A184PrvDsc = T000S46_A184PrvDsc[0];
            n184PrvDsc = T000S46_n184PrvDsc[0];
            A185PrvEst = T000S46_A185PrvEst[0];
            n185PrvEst = T000S46_n185PrvEst[0];
            A283detInvOCNro = T000S46_A283detInvOCNro[0];
            n283detInvOCNro = T000S46_n283detInvOCNro[0];
            A284detInvOcDoc = T000S46_A284detInvOcDoc[0];
            n284detInvOcDoc = T000S46_n284detInvOcDoc[0];
            A37PrvRuc = T000S46_A37PrvRuc[0];
            ZM0S50( -41) ;
         }
         pr_default.close(40);
         OnLoadActions0S50( ) ;
      }

      protected void OnLoadActions0S50( )
      {
      }

      protected void CheckExtendedTable0S50( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0S50( ) ;
         /* Using cursor T000S4 */
         pr_default.execute(2, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "PRVRUC_" + sGXsfl_148_idx;
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A184PrvDsc = T000S4_A184PrvDsc[0];
         n184PrvDsc = T000S4_n184PrvDsc[0];
         A185PrvEst = T000S4_A185PrvEst[0];
         n185PrvEst = T000S4_n185PrvEst[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0S50( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0S50( )
      {
      }

      protected void gxLoad_42( String A37PrvRuc )
      {
         /* Using cursor T000S47 */
         pr_default.execute(41, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(41) == 101) )
         {
            GXCCtl = "PRVRUC_" + sGXsfl_148_idx;
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A184PrvDsc = T000S47_A184PrvDsc[0];
         n184PrvDsc = T000S47_n184PrvDsc[0];
         A185PrvEst = T000S47_A185PrvEst[0];
         n185PrvEst = T000S47_n185PrvEst[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A184PrvDsc)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A185PrvEst))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(41) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(41);
      }

      protected void GetKey0S50( )
      {
         /* Using cursor T000S48 */
         pr_default.execute(42, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A282detInvOcId});
         if ( (pr_default.getStatus(42) != 101) )
         {
            RcdFound50 = 1;
         }
         else
         {
            RcdFound50 = 0;
         }
         pr_default.close(42);
      }

      protected void getByPrimaryKey0S50( )
      {
         /* Using cursor T000S3 */
         pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A282detInvOcId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0S50( 41) ;
            RcdFound50 = 1;
            InitializeNonKey0S50( ) ;
            A282detInvOcId = T000S3_A282detInvOcId[0];
            A283detInvOCNro = T000S3_A283detInvOCNro[0];
            n283detInvOCNro = T000S3_n283detInvOCNro[0];
            A284detInvOcDoc = T000S3_A284detInvOcDoc[0];
            n284detInvOcDoc = T000S3_n284detInvOcDoc[0];
            A37PrvRuc = T000S3_A37PrvRuc[0];
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z264invCod = A264invCod;
            Z282detInvOcId = A282detInvOcId;
            sMode50 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0S50( ) ;
            Gx_mode = sMode50;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound50 = 0;
            InitializeNonKey0S50( ) ;
            sMode50 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0S50( ) ;
            Gx_mode = sMode50;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0S50( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0S50( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000S2 */
            pr_default.execute(0, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A282detInvOcId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"InventariodetInvOc"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z283detInvOCNro != T000S2_A283detInvOCNro[0] ) || ( StringUtil.StrCmp(Z284detInvOcDoc, T000S2_A284detInvOcDoc[0]) != 0 ) || ( StringUtil.StrCmp(Z37PrvRuc, T000S2_A37PrvRuc[0]) != 0 ) )
            {
               if ( Z283detInvOCNro != T000S2_A283detInvOCNro[0] )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"detInvOCNro");
                  GXUtil.WriteLogRaw("Old: ",Z283detInvOCNro);
                  GXUtil.WriteLogRaw("Current: ",T000S2_A283detInvOCNro[0]);
               }
               if ( StringUtil.StrCmp(Z284detInvOcDoc, T000S2_A284detInvOcDoc[0]) != 0 )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"detInvOcDoc");
                  GXUtil.WriteLogRaw("Old: ",Z284detInvOcDoc);
                  GXUtil.WriteLogRaw("Current: ",T000S2_A284detInvOcDoc[0]);
               }
               if ( StringUtil.StrCmp(Z37PrvRuc, T000S2_A37PrvRuc[0]) != 0 )
               {
                  GXUtil.WriteLog("inventario:[seudo value changed for attri]"+"PrvRuc");
                  GXUtil.WriteLogRaw("Old: ",Z37PrvRuc);
                  GXUtil.WriteLogRaw("Current: ",T000S2_A37PrvRuc[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"InventariodetInvOc"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0S50( )
      {
         BeforeValidate0S50( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S50( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0S50( 0) ;
            CheckOptimisticConcurrency0S50( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S50( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0S50( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S49 */
                     pr_default.execute(43, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A282detInvOcId, n283detInvOCNro, A283detInvOCNro, n284detInvOcDoc, A284detInvOcDoc, A37PrvRuc});
                     pr_default.close(43);
                     dsDefault.SmartCacheProvider.SetUpdated("InventariodetInvOc") ;
                     if ( (pr_default.getStatus(43) == 1) )
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
               Load0S50( ) ;
            }
            EndLevel0S50( ) ;
         }
         CloseExtendedTableCursors0S50( ) ;
      }

      protected void Update0S50( )
      {
         BeforeValidate0S50( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S50( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S50( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S50( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0S50( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000S50 */
                     pr_default.execute(44, new Object[] {n283detInvOCNro, A283detInvOCNro, n284detInvOcDoc, A284detInvOcDoc, A37PrvRuc, A1EmpID, A2AgeID, A42BodCod, A264invCod, A282detInvOcId});
                     pr_default.close(44);
                     dsDefault.SmartCacheProvider.SetUpdated("InventariodetInvOc") ;
                     if ( (pr_default.getStatus(44) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"InventariodetInvOc"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0S50( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0S50( ) ;
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
            EndLevel0S50( ) ;
         }
         CloseExtendedTableCursors0S50( ) ;
      }

      protected void DeferredUpdate0S50( )
      {
      }

      protected void Delete0S50( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0S50( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S50( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0S50( ) ;
            AfterConfirm0S50( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0S50( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000S51 */
                  pr_default.execute(45, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod, A282detInvOcId});
                  pr_default.close(45);
                  dsDefault.SmartCacheProvider.SetUpdated("InventariodetInvOc") ;
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
         sMode50 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0S50( ) ;
         Gx_mode = sMode50;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0S50( )
      {
         standaloneModal0S50( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000S52 */
            pr_default.execute(46, new Object[] {A37PrvRuc});
            A184PrvDsc = T000S52_A184PrvDsc[0];
            n184PrvDsc = T000S52_n184PrvDsc[0];
            A185PrvEst = T000S52_A185PrvEst[0];
            n185PrvEst = T000S52_n185PrvEst[0];
            pr_default.close(46);
         }
      }

      protected void EndLevel0S50( )
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

      public void ScanStart0S50( )
      {
         /* Scan By routine */
         /* Using cursor T000S53 */
         pr_default.execute(47, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
         RcdFound50 = 0;
         if ( (pr_default.getStatus(47) != 101) )
         {
            RcdFound50 = 1;
            A282detInvOcId = T000S53_A282detInvOcId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0S50( )
      {
         /* Scan next routine */
         pr_default.readNext(47);
         RcdFound50 = 0;
         if ( (pr_default.getStatus(47) != 101) )
         {
            RcdFound50 = 1;
            A282detInvOcId = T000S53_A282detInvOcId[0];
         }
      }

      protected void ScanEnd0S50( )
      {
         pr_default.close(47);
      }

      protected void AfterConfirm0S50( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0S50( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0S50( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0S50( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0S50( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0S50( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0S50( )
      {
         edtdetInvOcId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvOcId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvOcId_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
         edtPrvRuc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
         edtPrvDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvDsc_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
         edtPrvEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvEst_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
         edtdetInvOCNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvOCNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvOCNro_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
         edtdetInvOcDoc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvOcDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvOcDoc_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
      }

      protected void send_integrity_lvl_hashes0S50( )
      {
      }

      protected void send_integrity_lvl_hashes0S48( )
      {
      }

      protected void SubsflControlProps_12551( )
      {
         edtdetInvId_Internalname = "DETINVID_"+sGXsfl_125_idx;
         edtPrdCod_Internalname = "PRDCOD_"+sGXsfl_125_idx;
         imgprompt_286_Internalname = "PROMPT_286_"+sGXsfl_125_idx;
         edtprdNombre_Internalname = "PRDNOMBRE_"+sGXsfl_125_idx;
         edtdetInvUniCod_Internalname = "DETINVUNICOD_"+sGXsfl_125_idx;
         edtdetInvCant_Internalname = "DETINVCANT_"+sGXsfl_125_idx;
         edtdetInvCosto_Internalname = "DETINVCOSTO_"+sGXsfl_125_idx;
         edtdetInvCostUni_Internalname = "DETINVCOSTUNI_"+sGXsfl_125_idx;
         edtdetInvImporte_Internalname = "DETINVIMPORTE_"+sGXsfl_125_idx;
         edtdetInvStock_Internalname = "DETINVSTOCK_"+sGXsfl_125_idx;
      }

      protected void SubsflControlProps_fel_12551( )
      {
         edtdetInvId_Internalname = "DETINVID_"+sGXsfl_125_fel_idx;
         edtPrdCod_Internalname = "PRDCOD_"+sGXsfl_125_fel_idx;
         imgprompt_286_Internalname = "PROMPT_286_"+sGXsfl_125_fel_idx;
         edtprdNombre_Internalname = "PRDNOMBRE_"+sGXsfl_125_fel_idx;
         edtdetInvUniCod_Internalname = "DETINVUNICOD_"+sGXsfl_125_fel_idx;
         edtdetInvCant_Internalname = "DETINVCANT_"+sGXsfl_125_fel_idx;
         edtdetInvCosto_Internalname = "DETINVCOSTO_"+sGXsfl_125_fel_idx;
         edtdetInvCostUni_Internalname = "DETINVCOSTUNI_"+sGXsfl_125_fel_idx;
         edtdetInvImporte_Internalname = "DETINVIMPORTE_"+sGXsfl_125_fel_idx;
         edtdetInvStock_Internalname = "DETINVSTOCK_"+sGXsfl_125_fel_idx;
      }

      protected void AddRow0S51( )
      {
         nGXsfl_125_idx = (short)(nGXsfl_125_idx+1);
         sGXsfl_125_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_125_idx), 4, 0)), 4, "0");
         SubsflControlProps_12551( ) ;
         SendRow0S51( ) ;
      }

      protected void SendRow0S51( )
      {
         Gridinventario_detinvRow = GXWebRow.GetNew(context);
         if ( subGridinventario_detinv_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridinventario_detinv_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridinventario_detinv_Class, "") != 0 )
            {
               subGridinventario_detinv_Linesclass = subGridinventario_detinv_Class+"Odd";
            }
         }
         else if ( subGridinventario_detinv_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridinventario_detinv_Backstyle = 0;
            subGridinventario_detinv_Backcolor = subGridinventario_detinv_Allbackcolor;
            if ( StringUtil.StrCmp(subGridinventario_detinv_Class, "") != 0 )
            {
               subGridinventario_detinv_Linesclass = subGridinventario_detinv_Class+"Uniform";
            }
         }
         else if ( subGridinventario_detinv_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridinventario_detinv_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridinventario_detinv_Class, "") != 0 )
            {
               subGridinventario_detinv_Linesclass = subGridinventario_detinv_Class+"Odd";
            }
            subGridinventario_detinv_Backcolor = (int)(0x0);
         }
         else if ( subGridinventario_detinv_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridinventario_detinv_Backstyle = 1;
            if ( ((int)(((nGXsfl_125_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridinventario_detinv_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridinventario_detinv_Class, "") != 0 )
               {
                  subGridinventario_detinv_Linesclass = subGridinventario_detinv_Class+"Odd";
               }
            }
            else
            {
               subGridinventario_detinv_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridinventario_detinv_Class, "") != 0 )
               {
                  subGridinventario_detinv_Linesclass = subGridinventario_detinv_Class+"Even";
               }
            }
         }
         imgprompt_286_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0202.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"PRDCOD_"+sGXsfl_125_idx+"'), id:'"+"PRDCOD_"+sGXsfl_125_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_51_"+sGXsfl_125_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_51_" + sGXsfl_125_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 126,'',false,'" + sGXsfl_125_idx + "',125)\"";
         ROClassString = "Attribute";
         Gridinventario_detinvRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A273detInvId), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A273detInvId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,126);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetInvId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)125,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_51_" + sGXsfl_125_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 127,'',false,'" + sGXsfl_125_idx + "',125)\"";
         ROClassString = "Attribute";
         Gridinventario_detinvRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrdCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", "")),((edtPrdCod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")) : context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,127);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrdCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPrdCod_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)125,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridinventario_detinvRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_286_Internalname,(String)sImgUrl,(String)imgprompt_286_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_286_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridinventario_detinvRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprdNombre_Internalname,(String)A309prdNombre,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprdNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtprdNombre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)80,(short)0,(short)0,(short)125,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridinventario_detinvRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvUniCod_Internalname,StringUtil.RTrim( A341detInvUniCod),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvUniCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtdetInvUniCod_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)125,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_51_" + sGXsfl_125_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 130,'',false,'" + sGXsfl_125_idx + "',125)\"";
         ROClassString = "Attribute";
         Gridinventario_detinvRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvCant_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A274detInvCant), 8, 0, ",", "")),((edtdetInvCant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A274detInvCant), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A274detInvCant), "ZZZZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,130);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvCant_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetInvCant_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)125,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_51_" + sGXsfl_125_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 131,'',false,'" + sGXsfl_125_idx + "',125)\"";
         ROClassString = "Attribute";
         Gridinventario_detinvRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvCosto_Internalname,StringUtil.LTrim( StringUtil.NToC( A275detInvCosto, 8, 2, ",", "")),((edtdetInvCosto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A275detInvCosto, "ZZZZ9.99")) : context.localUtil.Format( A275detInvCosto, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,131);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvCosto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetInvCosto_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)125,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridinventario_detinvRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvCostUni_Internalname,StringUtil.LTrim( StringUtil.NToC( A276detInvCostUni, 13, 2, ",", "")),((edtdetInvCostUni_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A276detInvCostUni, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A276detInvCostUni, "ZZ,ZZZ,ZZZ.ZZ")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvCostUni_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetInvCostUni_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)125,(short)1,(short)-1,(short)0,(bool)true,(String)"valores",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridinventario_detinvRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvImporte_Internalname,StringUtil.LTrim( StringUtil.NToC( A277detInvImporte, 13, 2, ",", "")),((edtdetInvImporte_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A277detInvImporte, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A277detInvImporte, "ZZ,ZZZ,ZZZ.ZZ")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvImporte_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetInvImporte_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)125,(short)1,(short)-1,(short)0,(bool)true,(String)"valores",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridinventario_detinvRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvStock_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A280detInvStock), 8, 0, ",", "")),((edtdetInvStock_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A280detInvStock), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A280detInvStock), "ZZZZZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvStock_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetInvStock_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)125,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridinventario_detinvRow);
         send_integrity_lvl_hashes0S51( ) ;
         GXCCtl = "Z273detInvId_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z273detInvId), 4, 0, ",", "")));
         GXCCtl = "Z341detInvUniCod_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z341detInvUniCod));
         GXCCtl = "Z274detInvCant_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z274detInvCant), 8, 0, ",", "")));
         GXCCtl = "Z275detInvCosto_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z275detInvCosto, 8, 2, ",", "")));
         GXCCtl = "Z286PrdCod_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", "")));
         GXCCtl = "O277detInvImporte_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O277detInvImporte, 10, 2, ",", "")));
         GXCCtl = "nRcdDeleted_51_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_51), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_51_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_51), 4, 0, ",", "")));
         GXCCtl = "nIsMod_51_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_51), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_125_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV12TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV12TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GXCCtl = "vAGEID_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8AgeID), 4, 0, ",", "")));
         GXCCtl = "vBODCOD_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9BodCod), 4, 0, ",", "")));
         GXCCtl = "vINVCOD_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10invCod), 4, 0, ",", "")));
         GXCCtl = "vUSUCOD_" + sGXsfl_125_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV16usuCod));
         GxWebStd.gx_hidden_field( context, "DETINVID_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRDCOD_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRDNOMBRE_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETINVUNICOD_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvUniCod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETINVCANT_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCant_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETINVCOSTO_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCosto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETINVCOSTUNI_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvCostUni_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETINVIMPORTE_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvImporte_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETINVSTOCK_"+sGXsfl_125_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvStock_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_286_"+sGXsfl_125_idx+"Link", StringUtil.RTrim( imgprompt_286_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridinventario_detinvContainer.AddRow(Gridinventario_detinvRow);
      }

      protected void ReadRow0S51( )
      {
         nGXsfl_125_idx = (short)(nGXsfl_125_idx+1);
         sGXsfl_125_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_125_idx), 4, 0)), 4, "0");
         SubsflControlProps_12551( ) ;
         edtdetInvId_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVID_"+sGXsfl_125_idx+"Enabled"), ",", "."));
         edtPrdCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDCOD_"+sGXsfl_125_idx+"Enabled"), ",", "."));
         edtprdNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDNOMBRE_"+sGXsfl_125_idx+"Enabled"), ",", "."));
         edtdetInvUniCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVUNICOD_"+sGXsfl_125_idx+"Enabled"), ",", "."));
         edtdetInvCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVCANT_"+sGXsfl_125_idx+"Enabled"), ",", "."));
         edtdetInvCosto_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVCOSTO_"+sGXsfl_125_idx+"Enabled"), ",", "."));
         edtdetInvCostUni_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVCOSTUNI_"+sGXsfl_125_idx+"Enabled"), ",", "."));
         edtdetInvImporte_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVIMPORTE_"+sGXsfl_125_idx+"Enabled"), ",", "."));
         edtdetInvStock_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVSTOCK_"+sGXsfl_125_idx+"Enabled"), ",", "."));
         imgprompt_1_Link = cgiGet( "PROMPT_286_"+sGXsfl_125_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtdetInvId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetInvId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "DETINVID_" + sGXsfl_125_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetInvId_Internalname;
            wbErr = true;
            A273detInvId = 0;
         }
         else
         {
            A273detInvId = (short)(context.localUtil.CToN( cgiGet( edtdetInvId_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_125_idx;
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
         A309prdNombre = cgiGet( edtprdNombre_Internalname);
         n309prdNombre = false;
         A341detInvUniCod = cgiGet( edtdetInvUniCod_Internalname);
         n341detInvUniCod = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtdetInvCant_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetInvCant_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
         {
            GXCCtl = "DETINVCANT_" + sGXsfl_125_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetInvCant_Internalname;
            wbErr = true;
            A274detInvCant = 0;
            n274detInvCant = false;
         }
         else
         {
            A274detInvCant = (int)(context.localUtil.CToN( cgiGet( edtdetInvCant_Internalname), ",", "."));
            n274detInvCant = false;
         }
         n274detInvCant = ((0==A274detInvCant) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtdetInvCosto_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetInvCosto_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "DETINVCOSTO_" + sGXsfl_125_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetInvCosto_Internalname;
            wbErr = true;
            A275detInvCosto = 0;
            n275detInvCosto = false;
         }
         else
         {
            A275detInvCosto = context.localUtil.CToN( cgiGet( edtdetInvCosto_Internalname), ",", ".");
            n275detInvCosto = false;
         }
         n275detInvCosto = ((Convert.ToDecimal(0)==A275detInvCosto) ? true : false);
         A276detInvCostUni = context.localUtil.CToN( cgiGet( edtdetInvCostUni_Internalname), ",", ".");
         A277detInvImporte = context.localUtil.CToN( cgiGet( edtdetInvImporte_Internalname), ",", ".");
         A280detInvStock = (int)(context.localUtil.CToN( cgiGet( edtdetInvStock_Internalname), ",", "."));
         GXCCtl = "Z273detInvId_" + sGXsfl_125_idx;
         Z273detInvId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z341detInvUniCod_" + sGXsfl_125_idx;
         Z341detInvUniCod = cgiGet( GXCCtl);
         n341detInvUniCod = (String.IsNullOrEmpty(StringUtil.RTrim( A341detInvUniCod)) ? true : false);
         GXCCtl = "Z274detInvCant_" + sGXsfl_125_idx;
         Z274detInvCant = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n274detInvCant = ((0==A274detInvCant) ? true : false);
         GXCCtl = "Z275detInvCosto_" + sGXsfl_125_idx;
         Z275detInvCosto = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n275detInvCosto = ((Convert.ToDecimal(0)==A275detInvCosto) ? true : false);
         GXCCtl = "Z286PrdCod_" + sGXsfl_125_idx;
         Z286PrdCod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "O277detInvImporte_" + sGXsfl_125_idx;
         O277detInvImporte = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         GXCCtl = "nRcdDeleted_51_" + sGXsfl_125_idx;
         nRcdDeleted_51 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_51_" + sGXsfl_125_idx;
         nRcdExists_51 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_51_" + sGXsfl_125_idx;
         nIsMod_51 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void SubsflControlProps_14850( )
      {
         edtdetInvOcId_Internalname = "DETINVOCID_"+sGXsfl_148_idx;
         edtPrvRuc_Internalname = "PRVRUC_"+sGXsfl_148_idx;
         imgprompt_37_Internalname = "PROMPT_37_"+sGXsfl_148_idx;
         edtPrvDsc_Internalname = "PRVDSC_"+sGXsfl_148_idx;
         edtPrvEst_Internalname = "PRVEST_"+sGXsfl_148_idx;
         edtdetInvOCNro_Internalname = "DETINVOCNRO_"+sGXsfl_148_idx;
         edtdetInvOcDoc_Internalname = "DETINVOCDOC_"+sGXsfl_148_idx;
      }

      protected void SubsflControlProps_fel_14850( )
      {
         edtdetInvOcId_Internalname = "DETINVOCID_"+sGXsfl_148_fel_idx;
         edtPrvRuc_Internalname = "PRVRUC_"+sGXsfl_148_fel_idx;
         imgprompt_37_Internalname = "PROMPT_37_"+sGXsfl_148_fel_idx;
         edtPrvDsc_Internalname = "PRVDSC_"+sGXsfl_148_fel_idx;
         edtPrvEst_Internalname = "PRVEST_"+sGXsfl_148_fel_idx;
         edtdetInvOCNro_Internalname = "DETINVOCNRO_"+sGXsfl_148_fel_idx;
         edtdetInvOcDoc_Internalname = "DETINVOCDOC_"+sGXsfl_148_fel_idx;
      }

      protected void AddRow0S50( )
      {
         nGXsfl_148_idx = (short)(nGXsfl_148_idx+1);
         sGXsfl_148_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_148_idx), 4, 0)), 4, "0");
         SubsflControlProps_14850( ) ;
         SendRow0S50( ) ;
      }

      protected void SendRow0S50( )
      {
         Gridinventario_detinvocRow = GXWebRow.GetNew(context);
         if ( subGridinventario_detinvoc_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridinventario_detinvoc_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridinventario_detinvoc_Class, "") != 0 )
            {
               subGridinventario_detinvoc_Linesclass = subGridinventario_detinvoc_Class+"Odd";
            }
         }
         else if ( subGridinventario_detinvoc_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridinventario_detinvoc_Backstyle = 0;
            subGridinventario_detinvoc_Backcolor = subGridinventario_detinvoc_Allbackcolor;
            if ( StringUtil.StrCmp(subGridinventario_detinvoc_Class, "") != 0 )
            {
               subGridinventario_detinvoc_Linesclass = subGridinventario_detinvoc_Class+"Uniform";
            }
         }
         else if ( subGridinventario_detinvoc_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridinventario_detinvoc_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridinventario_detinvoc_Class, "") != 0 )
            {
               subGridinventario_detinvoc_Linesclass = subGridinventario_detinvoc_Class+"Odd";
            }
            subGridinventario_detinvoc_Backcolor = (int)(0x0);
         }
         else if ( subGridinventario_detinvoc_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridinventario_detinvoc_Backstyle = 1;
            if ( ((int)(((nGXsfl_148_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridinventario_detinvoc_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridinventario_detinvoc_Class, "") != 0 )
               {
                  subGridinventario_detinvoc_Linesclass = subGridinventario_detinvoc_Class+"Odd";
               }
            }
            else
            {
               subGridinventario_detinvoc_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridinventario_detinvoc_Class, "") != 0 )
               {
                  subGridinventario_detinvoc_Linesclass = subGridinventario_detinvoc_Class+"Even";
               }
            }
         }
         imgprompt_37_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00v0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRVRUC_"+sGXsfl_148_idx+"'), id:'"+"PRVRUC_"+sGXsfl_148_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_50_"+sGXsfl_148_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_50_" + sGXsfl_148_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 149,'',false,'" + sGXsfl_148_idx + "',148)\"";
         ROClassString = "Attribute";
         Gridinventario_detinvocRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvOcId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A282detInvOcId), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A282detInvOcId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,149);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvOcId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetInvOcId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)148,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_50_" + sGXsfl_148_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 150,'',false,'" + sGXsfl_148_idx + "',148)\"";
         ROClassString = "Attribute";
         Gridinventario_detinvocRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrvRuc_Internalname,StringUtil.RTrim( A37PrvRuc),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,150);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrvRuc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPrvRuc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)148,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridinventario_detinvocRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_37_Internalname,(String)sImgUrl,(String)imgprompt_37_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_37_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridinventario_detinvocRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrvDsc_Internalname,(String)A184PrvDsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrvDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPrvDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)150,(short)0,(short)0,(short)148,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridinventario_detinvocRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrvEst_Internalname,StringUtil.RTrim( A185PrvEst),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrvEst_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPrvEst_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)148,(short)1,(short)-1,(short)-1,(bool)true,(String)"estado",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_50_" + sGXsfl_148_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 153,'',false,'" + sGXsfl_148_idx + "',148)\"";
         ROClassString = "Attribute";
         Gridinventario_detinvocRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvOCNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A283detInvOCNro), 8, 0, ",", "")),((edtdetInvOCNro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A283detInvOCNro), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A283detInvOCNro), "ZZZZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,153);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvOCNro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetInvOCNro_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)148,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_50_" + sGXsfl_148_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 154,'',false,'" + sGXsfl_148_idx + "',148)\"";
         ROClassString = "Attribute";
         Gridinventario_detinvocRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetInvOcDoc_Internalname,StringUtil.RTrim( A284detInvOcDoc),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,154);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetInvOcDoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetInvOcDoc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)148,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridinventario_detinvocRow);
         send_integrity_lvl_hashes0S50( ) ;
         GXCCtl = "Z282detInvOcId_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z282detInvOcId), 4, 0, ",", "")));
         GXCCtl = "Z283detInvOCNro_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z283detInvOCNro), 8, 0, ",", "")));
         GXCCtl = "Z284detInvOcDoc_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z284detInvOcDoc));
         GXCCtl = "Z37PrvRuc_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z37PrvRuc));
         GXCCtl = "nRcdDeleted_50_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_50), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_50_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_50), 4, 0, ",", "")));
         GXCCtl = "nIsMod_50_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_50), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_148_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV12TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV12TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GXCCtl = "vAGEID_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8AgeID), 4, 0, ",", "")));
         GXCCtl = "vBODCOD_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9BodCod), 4, 0, ",", "")));
         GXCCtl = "vINVCOD_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10invCod), 4, 0, ",", "")));
         GXCCtl = "vUSUCOD_" + sGXsfl_148_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV16usuCod));
         GxWebStd.gx_hidden_field( context, "DETINVOCID_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOcId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRVRUC_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvRuc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRVDSC_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRVEST_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvEst_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETINVOCNRO_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOCNro_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETINVOCDOC_"+sGXsfl_148_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetInvOcDoc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_37_"+sGXsfl_148_idx+"Link", StringUtil.RTrim( imgprompt_37_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridinventario_detinvocContainer.AddRow(Gridinventario_detinvocRow);
      }

      protected void ReadRow0S50( )
      {
         nGXsfl_148_idx = (short)(nGXsfl_148_idx+1);
         sGXsfl_148_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_148_idx), 4, 0)), 4, "0");
         SubsflControlProps_14850( ) ;
         edtdetInvOcId_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVOCID_"+sGXsfl_148_idx+"Enabled"), ",", "."));
         edtPrvRuc_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRVRUC_"+sGXsfl_148_idx+"Enabled"), ",", "."));
         edtPrvDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRVDSC_"+sGXsfl_148_idx+"Enabled"), ",", "."));
         edtPrvEst_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRVEST_"+sGXsfl_148_idx+"Enabled"), ",", "."));
         edtdetInvOCNro_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVOCNRO_"+sGXsfl_148_idx+"Enabled"), ",", "."));
         edtdetInvOcDoc_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETINVOCDOC_"+sGXsfl_148_idx+"Enabled"), ",", "."));
         imgprompt_1_Link = cgiGet( "PROMPT_37_"+sGXsfl_148_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtdetInvOcId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetInvOcId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "DETINVOCID_" + sGXsfl_148_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetInvOcId_Internalname;
            wbErr = true;
            A282detInvOcId = 0;
         }
         else
         {
            A282detInvOcId = (short)(context.localUtil.CToN( cgiGet( edtdetInvOcId_Internalname), ",", "."));
         }
         A37PrvRuc = cgiGet( edtPrvRuc_Internalname);
         A184PrvDsc = cgiGet( edtPrvDsc_Internalname);
         n184PrvDsc = false;
         A185PrvEst = cgiGet( edtPrvEst_Internalname);
         n185PrvEst = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtdetInvOCNro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetInvOCNro_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
         {
            GXCCtl = "DETINVOCNRO_" + sGXsfl_148_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetInvOCNro_Internalname;
            wbErr = true;
            A283detInvOCNro = 0;
            n283detInvOCNro = false;
         }
         else
         {
            A283detInvOCNro = (int)(context.localUtil.CToN( cgiGet( edtdetInvOCNro_Internalname), ",", "."));
            n283detInvOCNro = false;
         }
         n283detInvOCNro = ((0==A283detInvOCNro) ? true : false);
         A284detInvOcDoc = cgiGet( edtdetInvOcDoc_Internalname);
         n284detInvOcDoc = false;
         n284detInvOcDoc = (String.IsNullOrEmpty(StringUtil.RTrim( A284detInvOcDoc)) ? true : false);
         GXCCtl = "Z282detInvOcId_" + sGXsfl_148_idx;
         Z282detInvOcId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z283detInvOCNro_" + sGXsfl_148_idx;
         Z283detInvOCNro = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n283detInvOCNro = ((0==A283detInvOCNro) ? true : false);
         GXCCtl = "Z284detInvOcDoc_" + sGXsfl_148_idx;
         Z284detInvOcDoc = cgiGet( GXCCtl);
         n284detInvOcDoc = (String.IsNullOrEmpty(StringUtil.RTrim( A284detInvOcDoc)) ? true : false);
         GXCCtl = "Z37PrvRuc_" + sGXsfl_148_idx;
         Z37PrvRuc = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_50_" + sGXsfl_148_idx;
         nRcdDeleted_50 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_50_" + sGXsfl_148_idx;
         nRcdExists_50 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_50_" + sGXsfl_148_idx;
         nIsMod_50 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtdetInvOcId_Enabled = edtdetInvOcId_Enabled;
         defedtdetInvUniCod_Enabled = edtdetInvUniCod_Enabled;
         defedtdetInvId_Enabled = edtdetInvId_Enabled;
      }

      protected void ConfirmValues0S0( )
      {
         nGXsfl_125_idx = 0;
         sGXsfl_125_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_125_idx), 4, 0)), 4, "0");
         SubsflControlProps_12551( ) ;
         while ( nGXsfl_125_idx < nRC_GXsfl_125 )
         {
            nGXsfl_125_idx = (short)(nGXsfl_125_idx+1);
            sGXsfl_125_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_125_idx), 4, 0)), 4, "0");
            SubsflControlProps_12551( ) ;
            ChangePostValue( "Z273detInvId_"+sGXsfl_125_idx, cgiGet( "ZT_"+"Z273detInvId_"+sGXsfl_125_idx)) ;
            DeletePostValue( "ZT_"+"Z273detInvId_"+sGXsfl_125_idx) ;
            ChangePostValue( "Z341detInvUniCod_"+sGXsfl_125_idx, cgiGet( "ZT_"+"Z341detInvUniCod_"+sGXsfl_125_idx)) ;
            DeletePostValue( "ZT_"+"Z341detInvUniCod_"+sGXsfl_125_idx) ;
            ChangePostValue( "Z274detInvCant_"+sGXsfl_125_idx, cgiGet( "ZT_"+"Z274detInvCant_"+sGXsfl_125_idx)) ;
            DeletePostValue( "ZT_"+"Z274detInvCant_"+sGXsfl_125_idx) ;
            ChangePostValue( "Z275detInvCosto_"+sGXsfl_125_idx, cgiGet( "ZT_"+"Z275detInvCosto_"+sGXsfl_125_idx)) ;
            DeletePostValue( "ZT_"+"Z275detInvCosto_"+sGXsfl_125_idx) ;
            ChangePostValue( "Z286PrdCod_"+sGXsfl_125_idx, cgiGet( "ZT_"+"Z286PrdCod_"+sGXsfl_125_idx)) ;
            DeletePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_125_idx) ;
         }
         nGXsfl_148_idx = 0;
         sGXsfl_148_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_148_idx), 4, 0)), 4, "0");
         SubsflControlProps_14850( ) ;
         while ( nGXsfl_148_idx < nRC_GXsfl_148 )
         {
            nGXsfl_148_idx = (short)(nGXsfl_148_idx+1);
            sGXsfl_148_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_148_idx), 4, 0)), 4, "0");
            SubsflControlProps_14850( ) ;
            ChangePostValue( "Z282detInvOcId_"+sGXsfl_148_idx, cgiGet( "ZT_"+"Z282detInvOcId_"+sGXsfl_148_idx)) ;
            DeletePostValue( "ZT_"+"Z282detInvOcId_"+sGXsfl_148_idx) ;
            ChangePostValue( "Z283detInvOCNro_"+sGXsfl_148_idx, cgiGet( "ZT_"+"Z283detInvOCNro_"+sGXsfl_148_idx)) ;
            DeletePostValue( "ZT_"+"Z283detInvOCNro_"+sGXsfl_148_idx) ;
            ChangePostValue( "Z284detInvOcDoc_"+sGXsfl_148_idx, cgiGet( "ZT_"+"Z284detInvOcDoc_"+sGXsfl_148_idx)) ;
            DeletePostValue( "ZT_"+"Z284detInvOcDoc_"+sGXsfl_148_idx) ;
            ChangePostValue( "Z37PrvRuc_"+sGXsfl_148_idx, cgiGet( "ZT_"+"Z37PrvRuc_"+sGXsfl_148_idx)) ;
            DeletePostValue( "ZT_"+"Z37PrvRuc_"+sGXsfl_148_idx) ;
         }
         ChangePostValue( "O277detInvImporte", cgiGet( "T277detInvImporte")) ;
         DeletePostValue( "T277detInvImporte") ;
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
         context.SendWebValue( "Movimientos Inventario") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20221029191624", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("inventario.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8AgeID) + "," + UrlEncode("" +AV9BodCod) + "," + UrlEncode("" +AV10invCod) + "," + UrlEncode(StringUtil.RTrim(AV16usuCod))+"\">") ;
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
         forbiddenHiddens = "hsh" + "Inventario";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A271InvHora, "99:99");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV14Insert_TipoInv, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("inventario:[SendSecurityCheck value for]"+"InvHora:"+context.localUtil.Format( A271InvHora, "99:99"));
         GXUtil.WriteLog("inventario:[SendSecurityCheck value for]"+"Insert_TipoInv:"+StringUtil.RTrim( context.localUtil.Format( AV14Insert_TipoInv, "")));
         GXUtil.WriteLog("inventario:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z2AgeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z42BodCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z264invCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z264invCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z270InvUser", Z270InvUser);
         GxWebStd.gx_hidden_field( context, "Z265InvDsc", StringUtil.RTrim( Z265InvDsc));
         GxWebStd.gx_hidden_field( context, "Z266InvFch", context.localUtil.DToC( Z266InvFch, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z267InvEst", StringUtil.RTrim( Z267InvEst));
         GxWebStd.gx_hidden_field( context, "Z268InvGuia", StringUtil.RTrim( Z268InvGuia));
         GxWebStd.gx_hidden_field( context, "Z269InvFac", StringUtil.RTrim( Z269InvFac));
         GxWebStd.gx_hidden_field( context, "Z271InvHora", context.localUtil.TToC( Z271InvHora, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z272InvUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z272InvUltNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z43TipoInv", StringUtil.RTrim( Z43TipoInv));
         GxWebStd.gx_hidden_field( context, "O272InvUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(O272InvUltNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O281detInvTotal", StringUtil.LTrim( StringUtil.NToC( O281detInvTotal, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_125", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_125_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_148", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_148_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N43TipoInv", StringUtil.RTrim( A43TipoInv));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV12TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV12TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vBODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBODCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9BodCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINVCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10invCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vINVCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10invCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_TIPOINV", StringUtil.RTrim( AV14Insert_TipoInv));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV16usuCod));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV16usuCod, "")), context));
         GxWebStd.gx_hidden_field( context, "vHORANOW", context.localUtil.TToC( AV17horaNow, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "TIPOINVMOV", A219TipoInvMov);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV19Pgmname));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0S48( )
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
         return "Inventario" ;
      }

      public override String GetPgmdesc( )
      {
         return "Movimientos Inventario" ;
      }

      protected void InitializeNonKey0S48( )
      {
         A43TipoInv = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         A270InvUser = "";
         n270InvUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270InvUser", A270InvUser);
         n270InvUser = (String.IsNullOrEmpty(StringUtil.RTrim( A270InvUser)) ? true : false);
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A46AgeDsc = "";
         n46AgeDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46AgeDsc", A46AgeDsc);
         A217BodDsc = "";
         n217BodDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         A265InvDsc = "";
         n265InvDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265InvDsc", A265InvDsc);
         n265InvDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A265InvDsc)) ? true : false);
         A266InvFch = DateTime.MinValue;
         n266InvFch = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266InvFch", context.localUtil.Format(A266InvFch, "99/99/9999"));
         n266InvFch = ((DateTime.MinValue==A266InvFch) ? true : false);
         A219TipoInvMov = "";
         n219TipoInvMov = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
         A223TipoInvSigno = 0;
         n223TipoInvSigno = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
         A267InvEst = "";
         n267InvEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267InvEst", A267InvEst);
         n267InvEst = (String.IsNullOrEmpty(StringUtil.RTrim( A267InvEst)) ? true : false);
         A268InvGuia = "";
         n268InvGuia = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268InvGuia", A268InvGuia);
         n268InvGuia = (String.IsNullOrEmpty(StringUtil.RTrim( A268InvGuia)) ? true : false);
         A269InvFac = "";
         n269InvFac = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269InvFac", A269InvFac);
         n269InvFac = (String.IsNullOrEmpty(StringUtil.RTrim( A269InvFac)) ? true : false);
         A271InvHora = (DateTime)(DateTime.MinValue);
         n271InvHora = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271InvHora", context.localUtil.TToC( A271InvHora, 0, 5, 0, 3, "/", ":", " "));
         n271InvHora = ((DateTime.MinValue==A271InvHora) ? true : false);
         A272InvUltNro = 0;
         n272InvUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
         n272InvUltNro = ((0==A272InvUltNro) ? true : false);
         A281detInvTotal = 0;
         n281detInvTotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         O272InvUltNro = A272InvUltNro;
         n272InvUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
         O281detInvTotal = A281detInvTotal;
         n281detInvTotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281detInvTotal", StringUtil.LTrim( StringUtil.Str( A281detInvTotal, 10, 2)));
         Z270InvUser = "";
         Z265InvDsc = "";
         Z266InvFch = DateTime.MinValue;
         Z267InvEst = "";
         Z268InvGuia = "";
         Z269InvFac = "";
         Z271InvHora = (DateTime)(DateTime.MinValue);
         Z272InvUltNro = 0;
         Z43TipoInv = "";
      }

      protected void InitAll0S48( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A2AgeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         A42BodCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         A264invCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264invCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A264invCod), 4, 0)));
         InitializeNonKey0S48( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A271InvHora = i271InvHora;
         n271InvHora = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271InvHora", context.localUtil.TToC( A271InvHora, 0, 5, 0, 3, "/", ":", " "));
      }

      protected void InitializeNonKey0S51( )
      {
         A276detInvCostUni = 0;
         A277detInvImporte = 0;
         A280detInvStock = 0;
         A286PrdCod = 0;
         A309prdNombre = "";
         n309prdNombre = false;
         A341detInvUniCod = "";
         n341detInvUniCod = false;
         A274detInvCant = 0;
         n274detInvCant = false;
         A275detInvCosto = 0;
         n275detInvCosto = false;
         O277detInvImporte = A277detInvImporte;
         Z341detInvUniCod = "";
         Z274detInvCant = 0;
         Z275detInvCosto = 0;
         Z286PrdCod = 0;
      }

      protected void InitAll0S51( )
      {
         A273detInvId = 0;
         InitializeNonKey0S51( ) ;
      }

      protected void StandaloneModalInsert0S51( )
      {
         A272InvUltNro = i272InvUltNro;
         n272InvUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A272InvUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A272InvUltNro), 8, 0)));
      }

      protected void InitializeNonKey0S50( )
      {
         A37PrvRuc = "";
         A184PrvDsc = "";
         n184PrvDsc = false;
         A185PrvEst = "";
         n185PrvEst = false;
         A283detInvOCNro = 0;
         n283detInvOCNro = false;
         A284detInvOcDoc = "";
         n284detInvOcDoc = false;
         Z283detInvOCNro = 0;
         Z284detInvOcDoc = "";
         Z37PrvRuc = "";
      }

      protected void InitAll0S50( )
      {
         A282detInvOcId = 0;
         InitializeNonKey0S50( ) ;
      }

      protected void StandaloneModalInsert0S50( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221029191754", true);
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
         context.AddJavascriptSource("inventario.js", "?20221029191756", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties51( )
      {
         edtdetInvUniCod_Enabled = defedtdetInvUniCod_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvUniCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvUniCod_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
         edtdetInvId_Enabled = defedtdetInvId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvId_Enabled), 5, 0)), !bGXsfl_125_Refreshing);
      }

      protected void init_level_properties50( )
      {
         edtdetInvOcId_Enabled = defedtdetInvOcId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetInvOcId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetInvOcId_Enabled), 5, 0)), !bGXsfl_148_Refreshing);
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
         edtempdsc_Internalname = "EMPDSC";
         divSection1_Internalname = "SECTION1";
         edtAgeDsc_Internalname = "AGEDSC";
         divSection2_Internalname = "SECTION2";
         edtInvUser_Internalname = "INVUSER";
         divSection3_Internalname = "SECTION3";
         edtInvHora_Internalname = "INVHORA";
         divSection4_Internalname = "SECTION4";
         edtEmpID_Internalname = "EMPID";
         edtAgeID_Internalname = "AGEID";
         edtBodCod_Internalname = "BODCOD";
         divSection5_Internalname = "SECTION5";
         edtBodDsc_Internalname = "BODDSC";
         divSection6_Internalname = "SECTION6";
         edtinvCod_Internalname = "INVCOD";
         edtInvDsc_Internalname = "INVDSC";
         edtInvFch_Internalname = "INVFCH";
         dynTipoInv_Internalname = "TIPOINV";
         cmbTipoInvSigno_Internalname = "TIPOINVSIGNO";
         chkInvEst_Internalname = "INVEST";
         edtInvGuia_Internalname = "INVGUIA";
         edtInvFac_Internalname = "INVFAC";
         edtInvUltNro_Internalname = "INVULTNRO";
         lblTitledetinv_Internalname = "TITLEDETINV";
         edtdetInvId_Internalname = "DETINVID";
         edtPrdCod_Internalname = "PRDCOD";
         edtprdNombre_Internalname = "PRDNOMBRE";
         edtdetInvUniCod_Internalname = "DETINVUNICOD";
         edtdetInvCant_Internalname = "DETINVCANT";
         edtdetInvCosto_Internalname = "DETINVCOSTO";
         edtdetInvCostUni_Internalname = "DETINVCOSTUNI";
         edtdetInvImporte_Internalname = "DETINVIMPORTE";
         edtdetInvStock_Internalname = "DETINVSTOCK";
         divDetinvtable_Internalname = "DETINVTABLE";
         edtdetInvTotal_Internalname = "DETINVTOTAL";
         lblTitledetinvoc_Internalname = "TITLEDETINVOC";
         edtdetInvOcId_Internalname = "DETINVOCID";
         edtPrvRuc_Internalname = "PRVRUC";
         edtPrvDsc_Internalname = "PRVDSC";
         edtPrvEst_Internalname = "PRVEST";
         edtdetInvOCNro_Internalname = "DETINVOCNRO";
         edtdetInvOcDoc_Internalname = "DETINVOCDOC";
         divDetinvoctable_Internalname = "DETINVOCTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_2_Internalname = "PROMPT_2";
         imgprompt_42_Internalname = "PROMPT_42";
         imgprompt_286_Internalname = "PROMPT_286";
         imgprompt_37_Internalname = "PROMPT_37";
         subGridinventario_detinv_Internalname = "GRIDINVENTARIO_DETINV";
         subGridinventario_detinvoc_Internalname = "GRIDINVENTARIO_DETINVOC";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtdetInvOcDoc_Jsonclick = "";
         edtdetInvOCNro_Jsonclick = "";
         edtPrvEst_Jsonclick = "";
         edtPrvDsc_Jsonclick = "";
         imgprompt_37_Visible = 1;
         imgprompt_37_Link = "";
         edtPrvRuc_Jsonclick = "";
         edtdetInvOcId_Jsonclick = "";
         subGridinventario_detinvoc_Class = "Grid";
         subGridinventario_detinvoc_Backcolorstyle = 0;
         edtdetInvStock_Jsonclick = "";
         edtdetInvImporte_Jsonclick = "";
         edtdetInvCostUni_Jsonclick = "";
         edtdetInvCosto_Jsonclick = "";
         edtdetInvCant_Jsonclick = "";
         edtdetInvUniCod_Jsonclick = "";
         edtprdNombre_Jsonclick = "";
         imgprompt_286_Visible = 1;
         imgprompt_286_Link = "";
         imgprompt_1_Visible = 1;
         edtPrdCod_Jsonclick = "";
         edtdetInvId_Jsonclick = "";
         subGridinventario_detinv_Class = "Grid";
         subGridinventario_detinv_Backcolorstyle = 0;
         subGridinventario_detinvoc_Allowcollapsing = 0;
         subGridinventario_detinvoc_Allowselection = 0;
         edtdetInvOcDoc_Enabled = 1;
         edtdetInvOCNro_Enabled = 1;
         edtPrvEst_Enabled = 0;
         edtPrvDsc_Enabled = 0;
         edtPrvRuc_Enabled = 1;
         edtdetInvOcId_Enabled = 1;
         subGridinventario_detinvoc_Header = "";
         subGridinventario_detinv_Allowcollapsing = 0;
         subGridinventario_detinv_Allowselection = 0;
         edtdetInvStock_Enabled = 0;
         edtdetInvImporte_Enabled = 0;
         edtdetInvCostUni_Enabled = 0;
         edtdetInvCosto_Enabled = 1;
         edtdetInvCant_Enabled = 1;
         edtdetInvUniCod_Enabled = 0;
         edtprdNombre_Enabled = 0;
         edtPrdCod_Enabled = 1;
         edtdetInvId_Enabled = 1;
         subGridinventario_detinv_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtdetInvTotal_Jsonclick = "";
         edtdetInvTotal_Enabled = 0;
         edtInvUltNro_Jsonclick = "";
         edtInvUltNro_Enabled = 0;
         edtInvFac_Jsonclick = "";
         edtInvFac_Enabled = 1;
         edtInvGuia_Jsonclick = "";
         edtInvGuia_Enabled = 1;
         chkInvEst.Enabled = 1;
         cmbTipoInvSigno_Jsonclick = "";
         cmbTipoInvSigno.Enabled = 0;
         dynTipoInv_Jsonclick = "";
         dynTipoInv.Enabled = 1;
         edtInvFch_Jsonclick = "";
         edtInvFch_Enabled = 1;
         edtInvDsc_Jsonclick = "";
         edtInvDsc_Enabled = 1;
         edtinvCod_Jsonclick = "";
         edtinvCod_Enabled = 1;
         edtBodDsc_Jsonclick = "";
         edtBodDsc_Enabled = 0;
         imgprompt_42_Visible = 1;
         imgprompt_42_Link = "";
         edtBodCod_Jsonclick = "";
         edtBodCod_Enabled = 1;
         imgprompt_2_Link = "";
         edtAgeID_Jsonclick = "";
         edtAgeID_Enabled = 1;
         edtAgeID_Visible = 1;
         imgprompt_1_Link = "";
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 1;
         edtEmpID_Visible = 1;
         edtInvHora_Jsonclick = "";
         edtInvHora_Enabled = 0;
         edtInvUser_Jsonclick = "";
         edtInvUser_Enabled = 1;
         edtAgeDsc_Jsonclick = "";
         edtAgeDsc_Enabled = 0;
         edtempdsc_Jsonclick = "";
         edtempdsc_Enabled = 0;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         imgprompt_2_Visible = 1;
         imgprompt_1_Visible = 1;
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

      protected void GXDLATIPOINV0S48( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLATIPOINV_data0S48( ) ;
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

      protected void GXATIPOINV_html0S48( )
      {
         String gxdynajaxvalue ;
         GXDLATIPOINV_data0S48( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynTipoInv.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynTipoInv.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLATIPOINV_data0S48( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000S54 */
         pr_default.execute(48);
         while ( (pr_default.getStatus(48) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000S54_A43TipoInv[0]));
            gxdynajaxctrldescr.Add(T000S54_A219TipoInvMov[0]);
            pr_default.readNext(48);
         }
         pr_default.close(48);
      }

      protected void GX25ASADETINVSTOCK0S51( short A1EmpID ,
                                             short A286PrdCod ,
                                             short A2AgeID ,
                                             short A42BodCod )
      {
         GXt_int1 = (short)(A280detInvStock);
         new obtstocks(context ).execute(  0,  0,  A1EmpID,  A286PrdCod,  A2AgeID,  A42BodCod, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         A280detInvStock = GXt_int1;
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A280detInvStock), 8, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void gxnrGridinventario_detinv_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_12551( ) ;
         while ( nGXsfl_125_idx <= nRC_GXsfl_125 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0S51( ) ;
            standaloneModal0S51( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0S51( ) ;
            nGXsfl_125_idx = (short)(nGXsfl_125_idx+1);
            sGXsfl_125_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_125_idx), 4, 0)), 4, "0");
            SubsflControlProps_12551( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridinventario_detinvContainer));
         /* End function gxnrGridinventario_detinv_newrow */
      }

      protected void gxnrGridinventario_detinvoc_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_14850( ) ;
         while ( nGXsfl_148_idx <= nRC_GXsfl_148 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0S50( ) ;
            standaloneModal0S50( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0S50( ) ;
            nGXsfl_148_idx = (short)(nGXsfl_148_idx+1);
            sGXsfl_148_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_148_idx), 4, 0)), 4, "0");
            SubsflControlProps_14850( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridinventario_detinvocContainer));
         /* End function gxnrGridinventario_detinvoc_newrow */
      }

      protected void init_web_controls( )
      {
         dynTipoInv.Name = "TIPOINV";
         dynTipoInv.WebTags = "";
         cmbTipoInvSigno.Name = "TIPOINVSIGNO";
         cmbTipoInvSigno.WebTags = "";
         cmbTipoInvSigno.addItem("1", "Positivo", 0);
         cmbTipoInvSigno.addItem("-1", "Negativo", 0);
         if ( cmbTipoInvSigno.ItemCount > 0 )
         {
            A223TipoInvSigno = (short)(NumberUtil.Val( cmbTipoInvSigno.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0))), "."));
            n223TipoInvSigno = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
         }
         chkInvEst.Name = "INVEST";
         chkInvEst.WebTags = "";
         chkInvEst.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkInvEst_Internalname, "TitleCaption", chkInvEst.Caption, true);
         chkInvEst.CheckedValue = "N";
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000S55 */
         pr_default.execute(49, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(49) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000S55_A44empdsc[0];
         n44empdsc = T000S55_n44empdsc[0];
         pr_default.close(49);
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
         /* Using cursor T000S56 */
         pr_default.execute(50, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(50) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A46AgeDsc = T000S56_A46AgeDsc[0];
         n46AgeDsc = T000S56_n46AgeDsc[0];
         pr_default.close(50);
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

      public void Valid_Bodcod( short GX_Parm1 ,
                                short GX_Parm2 ,
                                String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         A42BodCod = GX_Parm2;
         A217BodDsc = GX_Parm3;
         n217BodDsc = false;
         /* Using cursor T000S57 */
         pr_default.execute(51, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(51) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A217BodDsc = T000S57_A217BodDsc[0];
         n217BodDsc = T000S57_n217BodDsc[0];
         pr_default.close(51);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A217BodDsc = "";
            n217BodDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A217BodDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Invcod( short GX_Parm1 ,
                                short GX_Parm2 ,
                                short GX_Parm3 ,
                                short GX_Parm4 ,
                                decimal GX_Parm5 )
      {
         A1EmpID = GX_Parm1;
         A2AgeID = GX_Parm2;
         A42BodCod = GX_Parm3;
         A264invCod = GX_Parm4;
         A281detInvTotal = GX_Parm5;
         n281detInvTotal = false;
         /* Using cursor T000S59 */
         pr_default.execute(52, new Object[] {A1EmpID, A2AgeID, A42BodCod, A264invCod});
         if ( (pr_default.getStatus(52) != 101) )
         {
            A281detInvTotal = T000S59_A281detInvTotal[0];
            n281detInvTotal = T000S59_n281detInvTotal[0];
         }
         else
         {
            A281detInvTotal = 0;
            n281detInvTotal = false;
         }
         pr_default.close(52);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A281detInvTotal = 0;
            n281detInvTotal = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A281detInvTotal, 10, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Tipoinv( GXCombobox dynGX_Parm1 ,
                                 String GX_Parm2 ,
                                 GXCombobox cmbGX_Parm3 )
      {
         dynTipoInv = dynGX_Parm1;
         A43TipoInv = dynTipoInv.CurrentValue;
         A219TipoInvMov = GX_Parm2;
         n219TipoInvMov = false;
         cmbTipoInvSigno = cmbGX_Parm3;
         A223TipoInvSigno = (short)(NumberUtil.Val( cmbTipoInvSigno.CurrentValue, "."));
         n223TipoInvSigno = false;
         cmbTipoInvSigno.CurrentValue = StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0));
         /* Using cursor T000S60 */
         pr_default.execute(53, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(53) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, "TIPOINV");
            AnyError = 1;
            GX_FocusControl = dynTipoInv_Internalname;
         }
         A219TipoInvMov = T000S60_A219TipoInvMov[0];
         n219TipoInvMov = T000S60_n219TipoInvMov[0];
         A223TipoInvSigno = T000S60_A223TipoInvSigno[0];
         cmbTipoInvSigno.CurrentValue = StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0));
         n223TipoInvSigno = T000S60_n223TipoInvSigno[0];
         pr_default.close(53);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A219TipoInvMov = "";
            n219TipoInvMov = false;
            A223TipoInvSigno = 0;
            n223TipoInvSigno = false;
            cmbTipoInvSigno.CurrentValue = StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0));
         }
         isValidOutput.Add(A219TipoInvMov);
         cmbTipoInvSigno.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0));
         isValidOutput.Add(cmbTipoInvSigno);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Prdcod( short GX_Parm1 ,
                                short GX_Parm2 ,
                                short GX_Parm3 ,
                                short GX_Parm4 ,
                                String GX_Parm5 ,
                                int GX_Parm6 )
      {
         A1EmpID = GX_Parm1;
         A2AgeID = GX_Parm2;
         A286PrdCod = GX_Parm3;
         A42BodCod = GX_Parm4;
         A309prdNombre = GX_Parm5;
         n309prdNombre = false;
         A280detInvStock = GX_Parm6;
         /* Using cursor T000S44 */
         pr_default.execute(38, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(38) == 101) )
         {
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, "PRDCOD");
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
         }
         A309prdNombre = T000S44_A309prdNombre[0];
         n309prdNombre = T000S44_n309prdNombre[0];
         pr_default.close(38);
         GXt_int1 = (short)(A280detInvStock);
         new obtstocks(context ).execute(  0,  0,  A1EmpID,  A286PrdCod,  A2AgeID,  A42BodCod, out  GXt_int1) ;
         A280detInvStock = GXt_int1;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A309prdNombre = "";
            n309prdNombre = false;
         }
         isValidOutput.Add(A309prdNombre);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A280detInvStock), 8, 0, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Prvruc( String GX_Parm1 ,
                                String GX_Parm2 ,
                                String GX_Parm3 )
      {
         A37PrvRuc = GX_Parm1;
         A184PrvDsc = GX_Parm2;
         n184PrvDsc = false;
         A185PrvEst = GX_Parm3;
         n185PrvEst = false;
         /* Using cursor T000S52 */
         pr_default.execute(46, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(46) == 101) )
         {
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, "PRVRUC");
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
         }
         A184PrvDsc = T000S52_A184PrvDsc[0];
         n184PrvDsc = T000S52_n184PrvDsc[0];
         A185PrvEst = T000S52_A185PrvEst[0];
         n185PrvEst = T000S52_n185PrvEst[0];
         pr_default.close(46);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A184PrvDsc = "";
            n184PrvDsc = false;
            A185PrvEst = "";
            n185PrvEst = false;
         }
         isValidOutput.Add(A184PrvDsc);
         isValidOutput.Add(StringUtil.RTrim( A185PrvEst));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV9BodCod',fld:'vBODCOD',pic:'ZZZ9',hsh:true},{av:'AV10invCod',fld:'vINVCOD',pic:'ZZZ9',hsh:true},{av:'AV16usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynTipoInv'},{av:'A43TipoInv',fld:'TIPOINV',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'dynTipoInv'},{av:'A43TipoInv',fld:'TIPOINV',pic:''}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV9BodCod',fld:'vBODCOD',pic:'ZZZ9',hsh:true},{av:'AV10invCod',fld:'vINVCOD',pic:'ZZZ9',hsh:true},{av:'AV16usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'A271InvHora',fld:'INVHORA',pic:'99:99'},{av:'AV14Insert_TipoInv',fld:'vINSERT_TIPOINV',pic:''},{av:'dynTipoInv'},{av:'A43TipoInv',fld:'TIPOINV',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dynTipoInv'},{av:'A43TipoInv',fld:'TIPOINV',pic:''}]}");
         setEventMetadata("AFTER TRN","{handler:'E120S2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'dynTipoInv'},{av:'A43TipoInv',fld:'TIPOINV',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[{av:'dynTipoInv'},{av:'A43TipoInv',fld:'TIPOINV',pic:''}]}");
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
         pr_default.close(46);
         pr_default.close(4);
         pr_default.close(38);
         pr_default.close(7);
         pr_default.close(49);
         pr_default.close(25);
         pr_default.close(50);
         pr_default.close(26);
         pr_default.close(51);
         pr_default.close(27);
         pr_default.close(53);
         pr_default.close(29);
         pr_default.close(52);
         pr_default.close(28);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV16usuCod = "";
         Z270InvUser = "";
         Z265InvDsc = "";
         Z266InvFch = DateTime.MinValue;
         Z267InvEst = "";
         Z268InvGuia = "";
         Z269InvFac = "";
         Z271InvHora = (DateTime)(DateTime.MinValue);
         Z43TipoInv = "";
         N43TipoInv = "";
         Z341detInvUniCod = "";
         Z284detInvOcDoc = "";
         Z37PrvRuc = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A43TipoInv = "";
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
         A44empdsc = "";
         A46AgeDsc = "";
         A270InvUser = "";
         A271InvHora = (DateTime)(DateTime.MinValue);
         sImgUrl = "";
         A217BodDsc = "";
         A265InvDsc = "";
         A266InvFch = DateTime.MinValue;
         A267InvEst = "";
         A268InvGuia = "";
         A269InvFac = "";
         lblTitledetinv_Jsonclick = "";
         lblTitledetinvoc_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridinventario_detinvContainer = new GXWebGrid( context);
         Gridinventario_detinvColumn = new GXWebColumn();
         A309prdNombre = "";
         A341detInvUniCod = "";
         sMode51 = "";
         sStyleString = "";
         Gridinventario_detinvocContainer = new GXWebGrid( context);
         Gridinventario_detinvocColumn = new GXWebColumn();
         A184PrvDsc = "";
         A185PrvEst = "";
         A284detInvOcDoc = "";
         sMode50 = "";
         AV14Insert_TipoInv = "";
         AV17horaNow = (DateTime)(DateTime.MinValue);
         A219TipoInvMov = "";
         AV19Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode48 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV12TrnContext = new SdtTransactionContext(context);
         AV13WebSession = context.GetSession();
         AV15TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z44empdsc = "";
         Z46AgeDsc = "";
         Z217BodDsc = "";
         Z219TipoInvMov = "";
         T000S13_A219TipoInvMov = new String[] {""} ;
         T000S13_n219TipoInvMov = new bool[] {false} ;
         T000S13_A223TipoInvSigno = new short[1] ;
         T000S13_n223TipoInvSigno = new bool[] {false} ;
         T000S10_A44empdsc = new String[] {""} ;
         T000S10_n44empdsc = new bool[] {false} ;
         T000S11_A46AgeDsc = new String[] {""} ;
         T000S11_n46AgeDsc = new bool[] {false} ;
         T000S12_A217BodDsc = new String[] {""} ;
         T000S12_n217BodDsc = new bool[] {false} ;
         T000S15_A281detInvTotal = new decimal[1] ;
         T000S15_n281detInvTotal = new bool[] {false} ;
         T000S17_A264invCod = new short[1] ;
         T000S17_A270InvUser = new String[] {""} ;
         T000S17_n270InvUser = new bool[] {false} ;
         T000S17_A44empdsc = new String[] {""} ;
         T000S17_n44empdsc = new bool[] {false} ;
         T000S17_A46AgeDsc = new String[] {""} ;
         T000S17_n46AgeDsc = new bool[] {false} ;
         T000S17_A217BodDsc = new String[] {""} ;
         T000S17_n217BodDsc = new bool[] {false} ;
         T000S17_A265InvDsc = new String[] {""} ;
         T000S17_n265InvDsc = new bool[] {false} ;
         T000S17_A266InvFch = new DateTime[] {DateTime.MinValue} ;
         T000S17_n266InvFch = new bool[] {false} ;
         T000S17_A219TipoInvMov = new String[] {""} ;
         T000S17_n219TipoInvMov = new bool[] {false} ;
         T000S17_A223TipoInvSigno = new short[1] ;
         T000S17_n223TipoInvSigno = new bool[] {false} ;
         T000S17_A267InvEst = new String[] {""} ;
         T000S17_n267InvEst = new bool[] {false} ;
         T000S17_A268InvGuia = new String[] {""} ;
         T000S17_n268InvGuia = new bool[] {false} ;
         T000S17_A269InvFac = new String[] {""} ;
         T000S17_n269InvFac = new bool[] {false} ;
         T000S17_A271InvHora = new DateTime[] {DateTime.MinValue} ;
         T000S17_n271InvHora = new bool[] {false} ;
         T000S17_A272InvUltNro = new int[1] ;
         T000S17_n272InvUltNro = new bool[] {false} ;
         T000S17_A1EmpID = new short[1] ;
         T000S17_A2AgeID = new short[1] ;
         T000S17_A42BodCod = new short[1] ;
         T000S17_A43TipoInv = new String[] {""} ;
         T000S17_A281detInvTotal = new decimal[1] ;
         T000S17_n281detInvTotal = new bool[] {false} ;
         T000S18_A44empdsc = new String[] {""} ;
         T000S18_n44empdsc = new bool[] {false} ;
         T000S19_A46AgeDsc = new String[] {""} ;
         T000S19_n46AgeDsc = new bool[] {false} ;
         T000S20_A217BodDsc = new String[] {""} ;
         T000S20_n217BodDsc = new bool[] {false} ;
         T000S22_A281detInvTotal = new decimal[1] ;
         T000S22_n281detInvTotal = new bool[] {false} ;
         T000S23_A219TipoInvMov = new String[] {""} ;
         T000S23_n219TipoInvMov = new bool[] {false} ;
         T000S23_A223TipoInvSigno = new short[1] ;
         T000S23_n223TipoInvSigno = new bool[] {false} ;
         T000S24_A1EmpID = new short[1] ;
         T000S24_A2AgeID = new short[1] ;
         T000S24_A42BodCod = new short[1] ;
         T000S24_A264invCod = new short[1] ;
         T000S9_A264invCod = new short[1] ;
         T000S9_A270InvUser = new String[] {""} ;
         T000S9_n270InvUser = new bool[] {false} ;
         T000S9_A265InvDsc = new String[] {""} ;
         T000S9_n265InvDsc = new bool[] {false} ;
         T000S9_A266InvFch = new DateTime[] {DateTime.MinValue} ;
         T000S9_n266InvFch = new bool[] {false} ;
         T000S9_A267InvEst = new String[] {""} ;
         T000S9_n267InvEst = new bool[] {false} ;
         T000S9_A268InvGuia = new String[] {""} ;
         T000S9_n268InvGuia = new bool[] {false} ;
         T000S9_A269InvFac = new String[] {""} ;
         T000S9_n269InvFac = new bool[] {false} ;
         T000S9_A271InvHora = new DateTime[] {DateTime.MinValue} ;
         T000S9_n271InvHora = new bool[] {false} ;
         T000S9_A272InvUltNro = new int[1] ;
         T000S9_n272InvUltNro = new bool[] {false} ;
         T000S9_A1EmpID = new short[1] ;
         T000S9_A2AgeID = new short[1] ;
         T000S9_A42BodCod = new short[1] ;
         T000S9_A43TipoInv = new String[] {""} ;
         T000S25_A1EmpID = new short[1] ;
         T000S25_A2AgeID = new short[1] ;
         T000S25_A42BodCod = new short[1] ;
         T000S25_A264invCod = new short[1] ;
         T000S26_A1EmpID = new short[1] ;
         T000S26_A2AgeID = new short[1] ;
         T000S26_A42BodCod = new short[1] ;
         T000S26_A264invCod = new short[1] ;
         T000S8_A264invCod = new short[1] ;
         T000S8_A270InvUser = new String[] {""} ;
         T000S8_n270InvUser = new bool[] {false} ;
         T000S8_A265InvDsc = new String[] {""} ;
         T000S8_n265InvDsc = new bool[] {false} ;
         T000S8_A266InvFch = new DateTime[] {DateTime.MinValue} ;
         T000S8_n266InvFch = new bool[] {false} ;
         T000S8_A267InvEst = new String[] {""} ;
         T000S8_n267InvEst = new bool[] {false} ;
         T000S8_A268InvGuia = new String[] {""} ;
         T000S8_n268InvGuia = new bool[] {false} ;
         T000S8_A269InvFac = new String[] {""} ;
         T000S8_n269InvFac = new bool[] {false} ;
         T000S8_A271InvHora = new DateTime[] {DateTime.MinValue} ;
         T000S8_n271InvHora = new bool[] {false} ;
         T000S8_A272InvUltNro = new int[1] ;
         T000S8_n272InvUltNro = new bool[] {false} ;
         T000S8_A1EmpID = new short[1] ;
         T000S8_A2AgeID = new short[1] ;
         T000S8_A42BodCod = new short[1] ;
         T000S8_A43TipoInv = new String[] {""} ;
         T000S30_A44empdsc = new String[] {""} ;
         T000S30_n44empdsc = new bool[] {false} ;
         T000S31_A46AgeDsc = new String[] {""} ;
         T000S31_n46AgeDsc = new bool[] {false} ;
         T000S32_A217BodDsc = new String[] {""} ;
         T000S32_n217BodDsc = new bool[] {false} ;
         T000S34_A281detInvTotal = new decimal[1] ;
         T000S34_n281detInvTotal = new bool[] {false} ;
         T000S35_A219TipoInvMov = new String[] {""} ;
         T000S35_n219TipoInvMov = new bool[] {false} ;
         T000S35_A223TipoInvSigno = new short[1] ;
         T000S35_n223TipoInvSigno = new bool[] {false} ;
         T000S37_A1EmpID = new short[1] ;
         T000S37_A2AgeID = new short[1] ;
         T000S37_A42BodCod = new short[1] ;
         T000S37_A264invCod = new short[1] ;
         Z309prdNombre = "";
         T000S38_A42BodCod = new short[1] ;
         T000S38_A264invCod = new short[1] ;
         T000S38_A273detInvId = new short[1] ;
         T000S38_A309prdNombre = new String[] {""} ;
         T000S38_n309prdNombre = new bool[] {false} ;
         T000S38_A341detInvUniCod = new String[] {""} ;
         T000S38_n341detInvUniCod = new bool[] {false} ;
         T000S38_A274detInvCant = new int[1] ;
         T000S38_n274detInvCant = new bool[] {false} ;
         T000S38_A275detInvCosto = new decimal[1] ;
         T000S38_n275detInvCosto = new bool[] {false} ;
         T000S38_A1EmpID = new short[1] ;
         T000S38_A2AgeID = new short[1] ;
         T000S38_A286PrdCod = new short[1] ;
         T000S7_A309prdNombre = new String[] {""} ;
         T000S7_n309prdNombre = new bool[] {false} ;
         T000S39_A309prdNombre = new String[] {""} ;
         T000S39_n309prdNombre = new bool[] {false} ;
         T000S40_A1EmpID = new short[1] ;
         T000S40_A2AgeID = new short[1] ;
         T000S40_A42BodCod = new short[1] ;
         T000S40_A264invCod = new short[1] ;
         T000S40_A273detInvId = new short[1] ;
         T000S6_A42BodCod = new short[1] ;
         T000S6_A264invCod = new short[1] ;
         T000S6_A273detInvId = new short[1] ;
         T000S6_A341detInvUniCod = new String[] {""} ;
         T000S6_n341detInvUniCod = new bool[] {false} ;
         T000S6_A274detInvCant = new int[1] ;
         T000S6_n274detInvCant = new bool[] {false} ;
         T000S6_A275detInvCosto = new decimal[1] ;
         T000S6_n275detInvCosto = new bool[] {false} ;
         T000S6_A1EmpID = new short[1] ;
         T000S6_A2AgeID = new short[1] ;
         T000S6_A286PrdCod = new short[1] ;
         T000S5_A42BodCod = new short[1] ;
         T000S5_A264invCod = new short[1] ;
         T000S5_A273detInvId = new short[1] ;
         T000S5_A341detInvUniCod = new String[] {""} ;
         T000S5_n341detInvUniCod = new bool[] {false} ;
         T000S5_A274detInvCant = new int[1] ;
         T000S5_n274detInvCant = new bool[] {false} ;
         T000S5_A275detInvCosto = new decimal[1] ;
         T000S5_n275detInvCosto = new bool[] {false} ;
         T000S5_A1EmpID = new short[1] ;
         T000S5_A2AgeID = new short[1] ;
         T000S5_A286PrdCod = new short[1] ;
         T000S44_A309prdNombre = new String[] {""} ;
         T000S44_n309prdNombre = new bool[] {false} ;
         T000S45_A1EmpID = new short[1] ;
         T000S45_A2AgeID = new short[1] ;
         T000S45_A42BodCod = new short[1] ;
         T000S45_A264invCod = new short[1] ;
         T000S45_A273detInvId = new short[1] ;
         Z184PrvDsc = "";
         Z185PrvEst = "";
         T000S46_A1EmpID = new short[1] ;
         T000S46_A2AgeID = new short[1] ;
         T000S46_A42BodCod = new short[1] ;
         T000S46_A264invCod = new short[1] ;
         T000S46_A282detInvOcId = new short[1] ;
         T000S46_A184PrvDsc = new String[] {""} ;
         T000S46_n184PrvDsc = new bool[] {false} ;
         T000S46_A185PrvEst = new String[] {""} ;
         T000S46_n185PrvEst = new bool[] {false} ;
         T000S46_A283detInvOCNro = new int[1] ;
         T000S46_n283detInvOCNro = new bool[] {false} ;
         T000S46_A284detInvOcDoc = new String[] {""} ;
         T000S46_n284detInvOcDoc = new bool[] {false} ;
         T000S46_A37PrvRuc = new String[] {""} ;
         T000S4_A184PrvDsc = new String[] {""} ;
         T000S4_n184PrvDsc = new bool[] {false} ;
         T000S4_A185PrvEst = new String[] {""} ;
         T000S4_n185PrvEst = new bool[] {false} ;
         T000S47_A184PrvDsc = new String[] {""} ;
         T000S47_n184PrvDsc = new bool[] {false} ;
         T000S47_A185PrvEst = new String[] {""} ;
         T000S47_n185PrvEst = new bool[] {false} ;
         T000S48_A1EmpID = new short[1] ;
         T000S48_A2AgeID = new short[1] ;
         T000S48_A42BodCod = new short[1] ;
         T000S48_A264invCod = new short[1] ;
         T000S48_A282detInvOcId = new short[1] ;
         T000S3_A1EmpID = new short[1] ;
         T000S3_A2AgeID = new short[1] ;
         T000S3_A42BodCod = new short[1] ;
         T000S3_A264invCod = new short[1] ;
         T000S3_A282detInvOcId = new short[1] ;
         T000S3_A283detInvOCNro = new int[1] ;
         T000S3_n283detInvOCNro = new bool[] {false} ;
         T000S3_A284detInvOcDoc = new String[] {""} ;
         T000S3_n284detInvOcDoc = new bool[] {false} ;
         T000S3_A37PrvRuc = new String[] {""} ;
         T000S2_A1EmpID = new short[1] ;
         T000S2_A2AgeID = new short[1] ;
         T000S2_A42BodCod = new short[1] ;
         T000S2_A264invCod = new short[1] ;
         T000S2_A282detInvOcId = new short[1] ;
         T000S2_A283detInvOCNro = new int[1] ;
         T000S2_n283detInvOCNro = new bool[] {false} ;
         T000S2_A284detInvOcDoc = new String[] {""} ;
         T000S2_n284detInvOcDoc = new bool[] {false} ;
         T000S2_A37PrvRuc = new String[] {""} ;
         T000S52_A184PrvDsc = new String[] {""} ;
         T000S52_n184PrvDsc = new bool[] {false} ;
         T000S52_A185PrvEst = new String[] {""} ;
         T000S52_n185PrvEst = new bool[] {false} ;
         T000S53_A1EmpID = new short[1] ;
         T000S53_A2AgeID = new short[1] ;
         T000S53_A42BodCod = new short[1] ;
         T000S53_A264invCod = new short[1] ;
         T000S53_A282detInvOcId = new short[1] ;
         Gridinventario_detinvRow = new GXWebRow();
         subGridinventario_detinv_Linesclass = "";
         ROClassString = "";
         Gridinventario_detinvocRow = new GXWebRow();
         subGridinventario_detinvoc_Linesclass = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i271InvHora = (DateTime)(DateTime.MinValue);
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000S54_A43TipoInv = new String[] {""} ;
         T000S54_A219TipoInvMov = new String[] {""} ;
         T000S54_n219TipoInvMov = new bool[] {false} ;
         T000S55_A44empdsc = new String[] {""} ;
         T000S55_n44empdsc = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         T000S56_A46AgeDsc = new String[] {""} ;
         T000S56_n46AgeDsc = new bool[] {false} ;
         T000S57_A217BodDsc = new String[] {""} ;
         T000S57_n217BodDsc = new bool[] {false} ;
         T000S59_A281detInvTotal = new decimal[1] ;
         T000S59_n281detInvTotal = new bool[] {false} ;
         T000S60_A219TipoInvMov = new String[] {""} ;
         T000S60_n219TipoInvMov = new bool[] {false} ;
         T000S60_A223TipoInvSigno = new short[1] ;
         T000S60_n223TipoInvSigno = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.inventario__default(),
            new Object[][] {
                new Object[] {
               T000S2_A1EmpID, T000S2_A2AgeID, T000S2_A42BodCod, T000S2_A264invCod, T000S2_A282detInvOcId, T000S2_A283detInvOCNro, T000S2_n283detInvOCNro, T000S2_A284detInvOcDoc, T000S2_n284detInvOcDoc, T000S2_A37PrvRuc
               }
               , new Object[] {
               T000S3_A1EmpID, T000S3_A2AgeID, T000S3_A42BodCod, T000S3_A264invCod, T000S3_A282detInvOcId, T000S3_A283detInvOCNro, T000S3_n283detInvOCNro, T000S3_A284detInvOcDoc, T000S3_n284detInvOcDoc, T000S3_A37PrvRuc
               }
               , new Object[] {
               T000S4_A184PrvDsc, T000S4_n184PrvDsc, T000S4_A185PrvEst, T000S4_n185PrvEst
               }
               , new Object[] {
               T000S5_A42BodCod, T000S5_A264invCod, T000S5_A273detInvId, T000S5_A341detInvUniCod, T000S5_n341detInvUniCod, T000S5_A274detInvCant, T000S5_n274detInvCant, T000S5_A275detInvCosto, T000S5_n275detInvCosto, T000S5_A1EmpID,
               T000S5_A2AgeID, T000S5_A286PrdCod
               }
               , new Object[] {
               T000S6_A42BodCod, T000S6_A264invCod, T000S6_A273detInvId, T000S6_A341detInvUniCod, T000S6_n341detInvUniCod, T000S6_A274detInvCant, T000S6_n274detInvCant, T000S6_A275detInvCosto, T000S6_n275detInvCosto, T000S6_A1EmpID,
               T000S6_A2AgeID, T000S6_A286PrdCod
               }
               , new Object[] {
               T000S7_A309prdNombre, T000S7_n309prdNombre
               }
               , new Object[] {
               T000S8_A264invCod, T000S8_A270InvUser, T000S8_n270InvUser, T000S8_A265InvDsc, T000S8_n265InvDsc, T000S8_A266InvFch, T000S8_n266InvFch, T000S8_A267InvEst, T000S8_n267InvEst, T000S8_A268InvGuia,
               T000S8_n268InvGuia, T000S8_A269InvFac, T000S8_n269InvFac, T000S8_A271InvHora, T000S8_n271InvHora, T000S8_A272InvUltNro, T000S8_n272InvUltNro, T000S8_A1EmpID, T000S8_A2AgeID, T000S8_A42BodCod,
               T000S8_A43TipoInv
               }
               , new Object[] {
               T000S9_A264invCod, T000S9_A270InvUser, T000S9_n270InvUser, T000S9_A265InvDsc, T000S9_n265InvDsc, T000S9_A266InvFch, T000S9_n266InvFch, T000S9_A267InvEst, T000S9_n267InvEst, T000S9_A268InvGuia,
               T000S9_n268InvGuia, T000S9_A269InvFac, T000S9_n269InvFac, T000S9_A271InvHora, T000S9_n271InvHora, T000S9_A272InvUltNro, T000S9_n272InvUltNro, T000S9_A1EmpID, T000S9_A2AgeID, T000S9_A42BodCod,
               T000S9_A43TipoInv
               }
               , new Object[] {
               T000S10_A44empdsc, T000S10_n44empdsc
               }
               , new Object[] {
               T000S11_A46AgeDsc, T000S11_n46AgeDsc
               }
               , new Object[] {
               T000S12_A217BodDsc, T000S12_n217BodDsc
               }
               , new Object[] {
               T000S13_A219TipoInvMov, T000S13_n219TipoInvMov, T000S13_A223TipoInvSigno, T000S13_n223TipoInvSigno
               }
               , new Object[] {
               T000S15_A281detInvTotal, T000S15_n281detInvTotal
               }
               , new Object[] {
               T000S17_A264invCod, T000S17_A270InvUser, T000S17_n270InvUser, T000S17_A44empdsc, T000S17_n44empdsc, T000S17_A46AgeDsc, T000S17_n46AgeDsc, T000S17_A217BodDsc, T000S17_n217BodDsc, T000S17_A265InvDsc,
               T000S17_n265InvDsc, T000S17_A266InvFch, T000S17_n266InvFch, T000S17_A219TipoInvMov, T000S17_n219TipoInvMov, T000S17_A223TipoInvSigno, T000S17_n223TipoInvSigno, T000S17_A267InvEst, T000S17_n267InvEst, T000S17_A268InvGuia,
               T000S17_n268InvGuia, T000S17_A269InvFac, T000S17_n269InvFac, T000S17_A271InvHora, T000S17_n271InvHora, T000S17_A272InvUltNro, T000S17_n272InvUltNro, T000S17_A1EmpID, T000S17_A2AgeID, T000S17_A42BodCod,
               T000S17_A43TipoInv, T000S17_A281detInvTotal, T000S17_n281detInvTotal
               }
               , new Object[] {
               T000S18_A44empdsc, T000S18_n44empdsc
               }
               , new Object[] {
               T000S19_A46AgeDsc, T000S19_n46AgeDsc
               }
               , new Object[] {
               T000S20_A217BodDsc, T000S20_n217BodDsc
               }
               , new Object[] {
               T000S22_A281detInvTotal, T000S22_n281detInvTotal
               }
               , new Object[] {
               T000S23_A219TipoInvMov, T000S23_n219TipoInvMov, T000S23_A223TipoInvSigno, T000S23_n223TipoInvSigno
               }
               , new Object[] {
               T000S24_A1EmpID, T000S24_A2AgeID, T000S24_A42BodCod, T000S24_A264invCod
               }
               , new Object[] {
               T000S25_A1EmpID, T000S25_A2AgeID, T000S25_A42BodCod, T000S25_A264invCod
               }
               , new Object[] {
               T000S26_A1EmpID, T000S26_A2AgeID, T000S26_A42BodCod, T000S26_A264invCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000S30_A44empdsc, T000S30_n44empdsc
               }
               , new Object[] {
               T000S31_A46AgeDsc, T000S31_n46AgeDsc
               }
               , new Object[] {
               T000S32_A217BodDsc, T000S32_n217BodDsc
               }
               , new Object[] {
               T000S34_A281detInvTotal, T000S34_n281detInvTotal
               }
               , new Object[] {
               T000S35_A219TipoInvMov, T000S35_n219TipoInvMov, T000S35_A223TipoInvSigno, T000S35_n223TipoInvSigno
               }
               , new Object[] {
               }
               , new Object[] {
               T000S37_A1EmpID, T000S37_A2AgeID, T000S37_A42BodCod, T000S37_A264invCod
               }
               , new Object[] {
               T000S38_A42BodCod, T000S38_A264invCod, T000S38_A273detInvId, T000S38_A309prdNombre, T000S38_n309prdNombre, T000S38_A341detInvUniCod, T000S38_n341detInvUniCod, T000S38_A274detInvCant, T000S38_n274detInvCant, T000S38_A275detInvCosto,
               T000S38_n275detInvCosto, T000S38_A1EmpID, T000S38_A2AgeID, T000S38_A286PrdCod
               }
               , new Object[] {
               T000S39_A309prdNombre, T000S39_n309prdNombre
               }
               , new Object[] {
               T000S40_A1EmpID, T000S40_A2AgeID, T000S40_A42BodCod, T000S40_A264invCod, T000S40_A273detInvId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000S44_A309prdNombre, T000S44_n309prdNombre
               }
               , new Object[] {
               T000S45_A1EmpID, T000S45_A2AgeID, T000S45_A42BodCod, T000S45_A264invCod, T000S45_A273detInvId
               }
               , new Object[] {
               T000S46_A1EmpID, T000S46_A2AgeID, T000S46_A42BodCod, T000S46_A264invCod, T000S46_A282detInvOcId, T000S46_A184PrvDsc, T000S46_n184PrvDsc, T000S46_A185PrvEst, T000S46_n185PrvEst, T000S46_A283detInvOCNro,
               T000S46_n283detInvOCNro, T000S46_A284detInvOcDoc, T000S46_n284detInvOcDoc, T000S46_A37PrvRuc
               }
               , new Object[] {
               T000S47_A184PrvDsc, T000S47_n184PrvDsc, T000S47_A185PrvEst, T000S47_n185PrvEst
               }
               , new Object[] {
               T000S48_A1EmpID, T000S48_A2AgeID, T000S48_A42BodCod, T000S48_A264invCod, T000S48_A282detInvOcId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000S52_A184PrvDsc, T000S52_n184PrvDsc, T000S52_A185PrvEst, T000S52_n185PrvEst
               }
               , new Object[] {
               T000S53_A1EmpID, T000S53_A2AgeID, T000S53_A42BodCod, T000S53_A264invCod, T000S53_A282detInvOcId
               }
               , new Object[] {
               T000S54_A43TipoInv, T000S54_A219TipoInvMov, T000S54_n219TipoInvMov
               }
               , new Object[] {
               T000S55_A44empdsc, T000S55_n44empdsc
               }
               , new Object[] {
               T000S56_A46AgeDsc, T000S56_n46AgeDsc
               }
               , new Object[] {
               T000S57_A217BodDsc, T000S57_n217BodDsc
               }
               , new Object[] {
               T000S59_A281detInvTotal, T000S59_n281detInvTotal
               }
               , new Object[] {
               T000S60_A219TipoInvMov, T000S60_n219TipoInvMov, T000S60_A223TipoInvSigno, T000S60_n223TipoInvSigno
               }
            }
         );
         AV19Pgmname = "Inventario";
      }

      private short nIsMod_51 ;
      private short nIsMod_50 ;
      private short wcpOAV7EmpID ;
      private short wcpOAV8AgeID ;
      private short wcpOAV9BodCod ;
      private short wcpOAV10invCod ;
      private short Z1EmpID ;
      private short Z2AgeID ;
      private short Z42BodCod ;
      private short Z264invCod ;
      private short nRC_GXsfl_125 ;
      private short nGXsfl_125_idx=1 ;
      private short nRC_GXsfl_148 ;
      private short nGXsfl_148_idx=1 ;
      private short Z273detInvId ;
      private short Z286PrdCod ;
      private short nRcdDeleted_51 ;
      private short nRcdExists_51 ;
      private short Z282detInvOcId ;
      private short nRcdDeleted_50 ;
      private short nRcdExists_50 ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A286PrdCod ;
      private short A2AgeID ;
      private short A42BodCod ;
      private short A264invCod ;
      private short Gx_BScreen ;
      private short AV7EmpID ;
      private short AV8AgeID ;
      private short AV9BodCod ;
      private short AV10invCod ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A223TipoInvSigno ;
      private short subGridinventario_detinv_Backcolorstyle ;
      private short A273detInvId ;
      private short subGridinventario_detinv_Allowselection ;
      private short subGridinventario_detinv_Allowhovering ;
      private short subGridinventario_detinv_Allowcollapsing ;
      private short subGridinventario_detinv_Collapsed ;
      private short nBlankRcdCount51 ;
      private short RcdFound51 ;
      private short nBlankRcdUsr51 ;
      private short subGridinventario_detinvoc_Backcolorstyle ;
      private short A282detInvOcId ;
      private short subGridinventario_detinvoc_Allowselection ;
      private short subGridinventario_detinvoc_Allowhovering ;
      private short subGridinventario_detinvoc_Allowcollapsing ;
      private short subGridinventario_detinvoc_Collapsed ;
      private short nBlankRcdCount50 ;
      private short RcdFound50 ;
      private short nBlankRcdUsr50 ;
      private short RcdFound48 ;
      private short GX_JID ;
      private short Z223TipoInvSigno ;
      private short subGridinventario_detinv_Backstyle ;
      private short subGridinventario_detinvoc_Backstyle ;
      private short wbTemp ;
      private short GXt_int1 ;
      private int Z272InvUltNro ;
      private int O272InvUltNro ;
      private int edtEmpID_Visible ;
      private int edtAgeID_Visible ;
      private int Z274detInvCant ;
      private int Z283detInvOCNro ;
      private int A272InvUltNro ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtempdsc_Enabled ;
      private int edtAgeDsc_Enabled ;
      private int edtInvUser_Enabled ;
      private int edtInvHora_Enabled ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtAgeID_Enabled ;
      private int imgprompt_2_Visible ;
      private int edtBodCod_Enabled ;
      private int imgprompt_42_Visible ;
      private int edtBodDsc_Enabled ;
      private int edtinvCod_Enabled ;
      private int edtInvDsc_Enabled ;
      private int edtInvFch_Enabled ;
      private int edtInvGuia_Enabled ;
      private int edtInvFac_Enabled ;
      private int edtInvUltNro_Enabled ;
      private int edtdetInvTotal_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtdetInvId_Enabled ;
      private int edtPrdCod_Enabled ;
      private int edtprdNombre_Enabled ;
      private int edtdetInvUniCod_Enabled ;
      private int A274detInvCant ;
      private int edtdetInvCant_Enabled ;
      private int edtdetInvCosto_Enabled ;
      private int edtdetInvCostUni_Enabled ;
      private int edtdetInvImporte_Enabled ;
      private int A280detInvStock ;
      private int edtdetInvStock_Enabled ;
      private int subGridinventario_detinv_Selectedindex ;
      private int subGridinventario_detinv_Selectioncolor ;
      private int subGridinventario_detinv_Hoveringcolor ;
      private int B272InvUltNro ;
      private int fRowAdded ;
      private int edtdetInvOcId_Enabled ;
      private int edtPrvRuc_Enabled ;
      private int edtPrvDsc_Enabled ;
      private int edtPrvEst_Enabled ;
      private int A283detInvOCNro ;
      private int edtdetInvOCNro_Enabled ;
      private int edtdetInvOcDoc_Enabled ;
      private int subGridinventario_detinvoc_Selectedindex ;
      private int subGridinventario_detinvoc_Selectioncolor ;
      private int subGridinventario_detinvoc_Hoveringcolor ;
      private int s272InvUltNro ;
      private int AV20GXV1 ;
      private int subGridinventario_detinv_Backcolor ;
      private int subGridinventario_detinv_Allbackcolor ;
      private int imgprompt_286_Visible ;
      private int subGridinventario_detinvoc_Backcolor ;
      private int subGridinventario_detinvoc_Allbackcolor ;
      private int imgprompt_37_Visible ;
      private int defedtdetInvOcId_Enabled ;
      private int defedtdetInvUniCod_Enabled ;
      private int defedtdetInvId_Enabled ;
      private int i272InvUltNro ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long GRIDINVENTARIO_DETINV_nFirstRecordOnPage ;
      private long GRIDINVENTARIO_DETINVOC_nFirstRecordOnPage ;
      private decimal O281detInvTotal ;
      private decimal Z275detInvCosto ;
      private decimal O277detInvImporte ;
      private decimal A281detInvTotal ;
      private decimal A275detInvCosto ;
      private decimal A276detInvCostUni ;
      private decimal A277detInvImporte ;
      private decimal B281detInvTotal ;
      private decimal s281detInvTotal ;
      private decimal T277detInvImporte ;
      private decimal Z281detInvTotal ;
      private String sPrefix ;
      private String sGXsfl_125_idx="0001" ;
      private String sGXsfl_148_idx="0001" ;
      private String wcpOGx_mode ;
      private String wcpOAV16usuCod ;
      private String Z265InvDsc ;
      private String Z267InvEst ;
      private String Z268InvGuia ;
      private String Z269InvFac ;
      private String Z43TipoInv ;
      private String N43TipoInv ;
      private String Z341detInvUniCod ;
      private String Z284detInvOcDoc ;
      private String Z37PrvRuc ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A43TipoInv ;
      private String A37PrvRuc ;
      private String Gx_mode ;
      private String AV16usuCod ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtInvUser_Internalname ;
      private String dynTipoInv_Internalname ;
      private String cmbTipoInvSigno_Internalname ;
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
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String divSection2_Internalname ;
      private String edtAgeDsc_Internalname ;
      private String A46AgeDsc ;
      private String edtAgeDsc_Jsonclick ;
      private String divSection3_Internalname ;
      private String edtInvUser_Jsonclick ;
      private String divSection4_Internalname ;
      private String edtInvHora_Internalname ;
      private String edtInvHora_Jsonclick ;
      private String edtEmpID_Internalname ;
      private String edtEmpID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtAgeID_Internalname ;
      private String edtAgeID_Jsonclick ;
      private String imgprompt_2_Internalname ;
      private String imgprompt_2_Link ;
      private String divSection5_Internalname ;
      private String edtBodCod_Internalname ;
      private String edtBodCod_Jsonclick ;
      private String imgprompt_42_Internalname ;
      private String imgprompt_42_Link ;
      private String divSection6_Internalname ;
      private String edtBodDsc_Internalname ;
      private String A217BodDsc ;
      private String edtBodDsc_Jsonclick ;
      private String edtinvCod_Internalname ;
      private String edtinvCod_Jsonclick ;
      private String edtInvDsc_Internalname ;
      private String A265InvDsc ;
      private String edtInvDsc_Jsonclick ;
      private String edtInvFch_Internalname ;
      private String edtInvFch_Jsonclick ;
      private String dynTipoInv_Jsonclick ;
      private String cmbTipoInvSigno_Jsonclick ;
      private String chkInvEst_Internalname ;
      private String A267InvEst ;
      private String edtInvGuia_Internalname ;
      private String A268InvGuia ;
      private String edtInvGuia_Jsonclick ;
      private String edtInvFac_Internalname ;
      private String A269InvFac ;
      private String edtInvFac_Jsonclick ;
      private String edtInvUltNro_Internalname ;
      private String edtInvUltNro_Jsonclick ;
      private String divDetinvtable_Internalname ;
      private String lblTitledetinv_Internalname ;
      private String lblTitledetinv_Jsonclick ;
      private String edtdetInvTotal_Internalname ;
      private String edtdetInvTotal_Jsonclick ;
      private String divDetinvoctable_Internalname ;
      private String lblTitledetinvoc_Internalname ;
      private String lblTitledetinvoc_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridinventario_detinv_Header ;
      private String A341detInvUniCod ;
      private String sMode51 ;
      private String edtdetInvId_Internalname ;
      private String edtPrdCod_Internalname ;
      private String edtprdNombre_Internalname ;
      private String edtdetInvUniCod_Internalname ;
      private String edtdetInvCant_Internalname ;
      private String edtdetInvCosto_Internalname ;
      private String edtdetInvCostUni_Internalname ;
      private String edtdetInvImporte_Internalname ;
      private String edtdetInvStock_Internalname ;
      private String sStyleString ;
      private String subGridinventario_detinvoc_Header ;
      private String A185PrvEst ;
      private String A284detInvOcDoc ;
      private String sMode50 ;
      private String edtdetInvOcId_Internalname ;
      private String edtPrvRuc_Internalname ;
      private String edtPrvDsc_Internalname ;
      private String edtPrvEst_Internalname ;
      private String edtdetInvOCNro_Internalname ;
      private String edtdetInvOcDoc_Internalname ;
      private String AV14Insert_TipoInv ;
      private String AV19Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode48 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z46AgeDsc ;
      private String Z217BodDsc ;
      private String Z185PrvEst ;
      private String imgprompt_286_Internalname ;
      private String sGXsfl_125_fel_idx="0001" ;
      private String subGridinventario_detinv_Class ;
      private String subGridinventario_detinv_Linesclass ;
      private String imgprompt_286_Link ;
      private String ROClassString ;
      private String edtdetInvId_Jsonclick ;
      private String edtPrdCod_Jsonclick ;
      private String edtprdNombre_Jsonclick ;
      private String edtdetInvUniCod_Jsonclick ;
      private String edtdetInvCant_Jsonclick ;
      private String edtdetInvCosto_Jsonclick ;
      private String edtdetInvCostUni_Jsonclick ;
      private String edtdetInvImporte_Jsonclick ;
      private String edtdetInvStock_Jsonclick ;
      private String imgprompt_37_Internalname ;
      private String sGXsfl_148_fel_idx="0001" ;
      private String subGridinventario_detinvoc_Class ;
      private String subGridinventario_detinvoc_Linesclass ;
      private String imgprompt_37_Link ;
      private String edtdetInvOcId_Jsonclick ;
      private String edtPrvRuc_Jsonclick ;
      private String edtPrvDsc_Jsonclick ;
      private String edtPrvEst_Jsonclick ;
      private String edtdetInvOCNro_Jsonclick ;
      private String edtdetInvOcDoc_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridinventario_detinv_Internalname ;
      private String subGridinventario_detinvoc_Internalname ;
      private String gxwrpcisep ;
      private DateTime Z271InvHora ;
      private DateTime A271InvHora ;
      private DateTime AV17horaNow ;
      private DateTime i271InvHora ;
      private DateTime Z266InvFch ;
      private DateTime A266InvFch ;
      private bool entryPointCalled ;
      private bool n272InvUltNro ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n223TipoInvSigno ;
      private bool n281detInvTotal ;
      private bool bGXsfl_125_Refreshing=false ;
      private bool bGXsfl_148_Refreshing=false ;
      private bool n44empdsc ;
      private bool n46AgeDsc ;
      private bool n270InvUser ;
      private bool n271InvHora ;
      private bool n217BodDsc ;
      private bool n265InvDsc ;
      private bool n266InvFch ;
      private bool n267InvEst ;
      private bool n268InvGuia ;
      private bool n269InvFac ;
      private bool n219TipoInvMov ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool n309prdNombre ;
      private bool n341detInvUniCod ;
      private bool n274detInvCant ;
      private bool n275detInvCosto ;
      private bool n184PrvDsc ;
      private bool n185PrvEst ;
      private bool n283detInvOCNro ;
      private bool n284detInvOcDoc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z270InvUser ;
      private String A44empdsc ;
      private String A270InvUser ;
      private String A309prdNombre ;
      private String A184PrvDsc ;
      private String A219TipoInvMov ;
      private String Z44empdsc ;
      private String Z219TipoInvMov ;
      private String Z309prdNombre ;
      private String Z184PrvDsc ;
      private IGxSession AV13WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridinventario_detinvContainer ;
      private GXWebGrid Gridinventario_detinvocContainer ;
      private GXWebRow Gridinventario_detinvRow ;
      private GXWebRow Gridinventario_detinvocRow ;
      private GXWebColumn Gridinventario_detinvColumn ;
      private GXWebColumn Gridinventario_detinvocColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynTipoInv ;
      private GXCombobox cmbTipoInvSigno ;
      private GXCheckbox chkInvEst ;
      private IDataStoreProvider pr_default ;
      private String[] T000S13_A219TipoInvMov ;
      private bool[] T000S13_n219TipoInvMov ;
      private short[] T000S13_A223TipoInvSigno ;
      private bool[] T000S13_n223TipoInvSigno ;
      private String[] T000S10_A44empdsc ;
      private bool[] T000S10_n44empdsc ;
      private String[] T000S11_A46AgeDsc ;
      private bool[] T000S11_n46AgeDsc ;
      private String[] T000S12_A217BodDsc ;
      private bool[] T000S12_n217BodDsc ;
      private decimal[] T000S15_A281detInvTotal ;
      private bool[] T000S15_n281detInvTotal ;
      private short[] T000S17_A264invCod ;
      private String[] T000S17_A270InvUser ;
      private bool[] T000S17_n270InvUser ;
      private String[] T000S17_A44empdsc ;
      private bool[] T000S17_n44empdsc ;
      private String[] T000S17_A46AgeDsc ;
      private bool[] T000S17_n46AgeDsc ;
      private String[] T000S17_A217BodDsc ;
      private bool[] T000S17_n217BodDsc ;
      private String[] T000S17_A265InvDsc ;
      private bool[] T000S17_n265InvDsc ;
      private DateTime[] T000S17_A266InvFch ;
      private bool[] T000S17_n266InvFch ;
      private String[] T000S17_A219TipoInvMov ;
      private bool[] T000S17_n219TipoInvMov ;
      private short[] T000S17_A223TipoInvSigno ;
      private bool[] T000S17_n223TipoInvSigno ;
      private String[] T000S17_A267InvEst ;
      private bool[] T000S17_n267InvEst ;
      private String[] T000S17_A268InvGuia ;
      private bool[] T000S17_n268InvGuia ;
      private String[] T000S17_A269InvFac ;
      private bool[] T000S17_n269InvFac ;
      private DateTime[] T000S17_A271InvHora ;
      private bool[] T000S17_n271InvHora ;
      private int[] T000S17_A272InvUltNro ;
      private bool[] T000S17_n272InvUltNro ;
      private short[] T000S17_A1EmpID ;
      private short[] T000S17_A2AgeID ;
      private short[] T000S17_A42BodCod ;
      private String[] T000S17_A43TipoInv ;
      private decimal[] T000S17_A281detInvTotal ;
      private bool[] T000S17_n281detInvTotal ;
      private String[] T000S18_A44empdsc ;
      private bool[] T000S18_n44empdsc ;
      private String[] T000S19_A46AgeDsc ;
      private bool[] T000S19_n46AgeDsc ;
      private String[] T000S20_A217BodDsc ;
      private bool[] T000S20_n217BodDsc ;
      private decimal[] T000S22_A281detInvTotal ;
      private bool[] T000S22_n281detInvTotal ;
      private String[] T000S23_A219TipoInvMov ;
      private bool[] T000S23_n219TipoInvMov ;
      private short[] T000S23_A223TipoInvSigno ;
      private bool[] T000S23_n223TipoInvSigno ;
      private short[] T000S24_A1EmpID ;
      private short[] T000S24_A2AgeID ;
      private short[] T000S24_A42BodCod ;
      private short[] T000S24_A264invCod ;
      private short[] T000S9_A264invCod ;
      private String[] T000S9_A270InvUser ;
      private bool[] T000S9_n270InvUser ;
      private String[] T000S9_A265InvDsc ;
      private bool[] T000S9_n265InvDsc ;
      private DateTime[] T000S9_A266InvFch ;
      private bool[] T000S9_n266InvFch ;
      private String[] T000S9_A267InvEst ;
      private bool[] T000S9_n267InvEst ;
      private String[] T000S9_A268InvGuia ;
      private bool[] T000S9_n268InvGuia ;
      private String[] T000S9_A269InvFac ;
      private bool[] T000S9_n269InvFac ;
      private DateTime[] T000S9_A271InvHora ;
      private bool[] T000S9_n271InvHora ;
      private int[] T000S9_A272InvUltNro ;
      private bool[] T000S9_n272InvUltNro ;
      private short[] T000S9_A1EmpID ;
      private short[] T000S9_A2AgeID ;
      private short[] T000S9_A42BodCod ;
      private String[] T000S9_A43TipoInv ;
      private short[] T000S25_A1EmpID ;
      private short[] T000S25_A2AgeID ;
      private short[] T000S25_A42BodCod ;
      private short[] T000S25_A264invCod ;
      private short[] T000S26_A1EmpID ;
      private short[] T000S26_A2AgeID ;
      private short[] T000S26_A42BodCod ;
      private short[] T000S26_A264invCod ;
      private short[] T000S8_A264invCod ;
      private String[] T000S8_A270InvUser ;
      private bool[] T000S8_n270InvUser ;
      private String[] T000S8_A265InvDsc ;
      private bool[] T000S8_n265InvDsc ;
      private DateTime[] T000S8_A266InvFch ;
      private bool[] T000S8_n266InvFch ;
      private String[] T000S8_A267InvEst ;
      private bool[] T000S8_n267InvEst ;
      private String[] T000S8_A268InvGuia ;
      private bool[] T000S8_n268InvGuia ;
      private String[] T000S8_A269InvFac ;
      private bool[] T000S8_n269InvFac ;
      private DateTime[] T000S8_A271InvHora ;
      private bool[] T000S8_n271InvHora ;
      private int[] T000S8_A272InvUltNro ;
      private bool[] T000S8_n272InvUltNro ;
      private short[] T000S8_A1EmpID ;
      private short[] T000S8_A2AgeID ;
      private short[] T000S8_A42BodCod ;
      private String[] T000S8_A43TipoInv ;
      private String[] T000S30_A44empdsc ;
      private bool[] T000S30_n44empdsc ;
      private String[] T000S31_A46AgeDsc ;
      private bool[] T000S31_n46AgeDsc ;
      private String[] T000S32_A217BodDsc ;
      private bool[] T000S32_n217BodDsc ;
      private decimal[] T000S34_A281detInvTotal ;
      private bool[] T000S34_n281detInvTotal ;
      private String[] T000S35_A219TipoInvMov ;
      private bool[] T000S35_n219TipoInvMov ;
      private short[] T000S35_A223TipoInvSigno ;
      private bool[] T000S35_n223TipoInvSigno ;
      private short[] T000S37_A1EmpID ;
      private short[] T000S37_A2AgeID ;
      private short[] T000S37_A42BodCod ;
      private short[] T000S37_A264invCod ;
      private short[] T000S38_A42BodCod ;
      private short[] T000S38_A264invCod ;
      private short[] T000S38_A273detInvId ;
      private String[] T000S38_A309prdNombre ;
      private bool[] T000S38_n309prdNombre ;
      private String[] T000S38_A341detInvUniCod ;
      private bool[] T000S38_n341detInvUniCod ;
      private int[] T000S38_A274detInvCant ;
      private bool[] T000S38_n274detInvCant ;
      private decimal[] T000S38_A275detInvCosto ;
      private bool[] T000S38_n275detInvCosto ;
      private short[] T000S38_A1EmpID ;
      private short[] T000S38_A2AgeID ;
      private short[] T000S38_A286PrdCod ;
      private String[] T000S7_A309prdNombre ;
      private bool[] T000S7_n309prdNombre ;
      private String[] T000S39_A309prdNombre ;
      private bool[] T000S39_n309prdNombre ;
      private short[] T000S40_A1EmpID ;
      private short[] T000S40_A2AgeID ;
      private short[] T000S40_A42BodCod ;
      private short[] T000S40_A264invCod ;
      private short[] T000S40_A273detInvId ;
      private short[] T000S6_A42BodCod ;
      private short[] T000S6_A264invCod ;
      private short[] T000S6_A273detInvId ;
      private String[] T000S6_A341detInvUniCod ;
      private bool[] T000S6_n341detInvUniCod ;
      private int[] T000S6_A274detInvCant ;
      private bool[] T000S6_n274detInvCant ;
      private decimal[] T000S6_A275detInvCosto ;
      private bool[] T000S6_n275detInvCosto ;
      private short[] T000S6_A1EmpID ;
      private short[] T000S6_A2AgeID ;
      private short[] T000S6_A286PrdCod ;
      private short[] T000S5_A42BodCod ;
      private short[] T000S5_A264invCod ;
      private short[] T000S5_A273detInvId ;
      private String[] T000S5_A341detInvUniCod ;
      private bool[] T000S5_n341detInvUniCod ;
      private int[] T000S5_A274detInvCant ;
      private bool[] T000S5_n274detInvCant ;
      private decimal[] T000S5_A275detInvCosto ;
      private bool[] T000S5_n275detInvCosto ;
      private short[] T000S5_A1EmpID ;
      private short[] T000S5_A2AgeID ;
      private short[] T000S5_A286PrdCod ;
      private String[] T000S44_A309prdNombre ;
      private bool[] T000S44_n309prdNombre ;
      private short[] T000S45_A1EmpID ;
      private short[] T000S45_A2AgeID ;
      private short[] T000S45_A42BodCod ;
      private short[] T000S45_A264invCod ;
      private short[] T000S45_A273detInvId ;
      private short[] T000S46_A1EmpID ;
      private short[] T000S46_A2AgeID ;
      private short[] T000S46_A42BodCod ;
      private short[] T000S46_A264invCod ;
      private short[] T000S46_A282detInvOcId ;
      private String[] T000S46_A184PrvDsc ;
      private bool[] T000S46_n184PrvDsc ;
      private String[] T000S46_A185PrvEst ;
      private bool[] T000S46_n185PrvEst ;
      private int[] T000S46_A283detInvOCNro ;
      private bool[] T000S46_n283detInvOCNro ;
      private String[] T000S46_A284detInvOcDoc ;
      private bool[] T000S46_n284detInvOcDoc ;
      private String[] T000S46_A37PrvRuc ;
      private String[] T000S4_A184PrvDsc ;
      private bool[] T000S4_n184PrvDsc ;
      private String[] T000S4_A185PrvEst ;
      private bool[] T000S4_n185PrvEst ;
      private String[] T000S47_A184PrvDsc ;
      private bool[] T000S47_n184PrvDsc ;
      private String[] T000S47_A185PrvEst ;
      private bool[] T000S47_n185PrvEst ;
      private short[] T000S48_A1EmpID ;
      private short[] T000S48_A2AgeID ;
      private short[] T000S48_A42BodCod ;
      private short[] T000S48_A264invCod ;
      private short[] T000S48_A282detInvOcId ;
      private short[] T000S3_A1EmpID ;
      private short[] T000S3_A2AgeID ;
      private short[] T000S3_A42BodCod ;
      private short[] T000S3_A264invCod ;
      private short[] T000S3_A282detInvOcId ;
      private int[] T000S3_A283detInvOCNro ;
      private bool[] T000S3_n283detInvOCNro ;
      private String[] T000S3_A284detInvOcDoc ;
      private bool[] T000S3_n284detInvOcDoc ;
      private String[] T000S3_A37PrvRuc ;
      private short[] T000S2_A1EmpID ;
      private short[] T000S2_A2AgeID ;
      private short[] T000S2_A42BodCod ;
      private short[] T000S2_A264invCod ;
      private short[] T000S2_A282detInvOcId ;
      private int[] T000S2_A283detInvOCNro ;
      private bool[] T000S2_n283detInvOCNro ;
      private String[] T000S2_A284detInvOcDoc ;
      private bool[] T000S2_n284detInvOcDoc ;
      private String[] T000S2_A37PrvRuc ;
      private String[] T000S52_A184PrvDsc ;
      private bool[] T000S52_n184PrvDsc ;
      private String[] T000S52_A185PrvEst ;
      private bool[] T000S52_n185PrvEst ;
      private short[] T000S53_A1EmpID ;
      private short[] T000S53_A2AgeID ;
      private short[] T000S53_A42BodCod ;
      private short[] T000S53_A264invCod ;
      private short[] T000S53_A282detInvOcId ;
      private String[] T000S54_A43TipoInv ;
      private String[] T000S54_A219TipoInvMov ;
      private bool[] T000S54_n219TipoInvMov ;
      private String[] T000S55_A44empdsc ;
      private bool[] T000S55_n44empdsc ;
      private String[] T000S56_A46AgeDsc ;
      private bool[] T000S56_n46AgeDsc ;
      private String[] T000S57_A217BodDsc ;
      private bool[] T000S57_n217BodDsc ;
      private decimal[] T000S59_A281detInvTotal ;
      private bool[] T000S59_n281detInvTotal ;
      private String[] T000S60_A219TipoInvMov ;
      private bool[] T000S60_n219TipoInvMov ;
      private short[] T000S60_A223TipoInvSigno ;
      private bool[] T000S60_n223TipoInvSigno ;
      private SdtTransactionContext AV12TrnContext ;
      private SdtTransactionContext_Attribute AV15TrnContextAtt ;
   }

   public class inventario__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new UpdateCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new UpdateCursor(def[35])
         ,new UpdateCursor(def[36])
         ,new UpdateCursor(def[37])
         ,new ForEachCursor(def[38])
         ,new ForEachCursor(def[39])
         ,new ForEachCursor(def[40])
         ,new ForEachCursor(def[41])
         ,new ForEachCursor(def[42])
         ,new UpdateCursor(def[43])
         ,new UpdateCursor(def[44])
         ,new UpdateCursor(def[45])
         ,new ForEachCursor(def[46])
         ,new ForEachCursor(def[47])
         ,new ForEachCursor(def[48])
         ,new ForEachCursor(def[49])
         ,new ForEachCursor(def[50])
         ,new ForEachCursor(def[51])
         ,new ForEachCursor(def[52])
         ,new ForEachCursor(def[53])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000S17 ;
          prmT000S17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S10 ;
          prmT000S10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S11 ;
          prmT000S11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S12 ;
          prmT000S12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S15 ;
          prmT000S15 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S13 ;
          prmT000S13 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000S18 ;
          prmT000S18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S19 ;
          prmT000S19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S20 ;
          prmT000S20 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S22 ;
          prmT000S22 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S23 ;
          prmT000S23 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000S24 ;
          prmT000S24 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S9 ;
          prmT000S9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S25 ;
          prmT000S25 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S26 ;
          prmT000S26 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S8 ;
          prmT000S8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S27 ;
          prmT000S27 = new Object[] {
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@InvUser",SqlDbType.VarChar,20,0} ,
          new Object[] {"@InvDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@InvFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@InvEst",SqlDbType.Char,1,0} ,
          new Object[] {"@InvGuia",SqlDbType.Char,20,0} ,
          new Object[] {"@InvFac",SqlDbType.Char,20,0} ,
          new Object[] {"@InvHora",SqlDbType.DateTime,0,5} ,
          new Object[] {"@InvUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000S28 ;
          prmT000S28 = new Object[] {
          new Object[] {"@InvUser",SqlDbType.VarChar,20,0} ,
          new Object[] {"@InvDsc",SqlDbType.Char,50,0} ,
          new Object[] {"@InvFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@InvEst",SqlDbType.Char,1,0} ,
          new Object[] {"@InvGuia",SqlDbType.Char,20,0} ,
          new Object[] {"@InvFac",SqlDbType.Char,20,0} ,
          new Object[] {"@InvHora",SqlDbType.DateTime,0,5} ,
          new Object[] {"@InvUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S29 ;
          prmT000S29 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S30 ;
          prmT000S30 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S31 ;
          prmT000S31 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S32 ;
          prmT000S32 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S34 ;
          prmT000S34 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S35 ;
          prmT000S35 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000S36 ;
          prmT000S36 = new Object[] {
          new Object[] {"@InvUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S37 ;
          prmT000S37 = new Object[] {
          } ;
          Object[] prmT000S38 ;
          prmT000S38 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S7 ;
          prmT000S7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S39 ;
          prmT000S39 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S40 ;
          prmT000S40 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S6 ;
          prmT000S6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S5 ;
          prmT000S5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S41 ;
          prmT000S41 = new Object[] {
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvUniCod",SqlDbType.Char,3,0} ,
          new Object[] {"@detInvCant",SqlDbType.Int,8,0} ,
          new Object[] {"@detInvCosto",SqlDbType.Decimal,8,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S42 ;
          prmT000S42 = new Object[] {
          new Object[] {"@detInvUniCod",SqlDbType.Char,3,0} ,
          new Object[] {"@detInvCant",SqlDbType.Int,8,0} ,
          new Object[] {"@detInvCosto",SqlDbType.Decimal,8,2} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S43 ;
          prmT000S43 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S45 ;
          prmT000S45 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S46 ;
          prmT000S46 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvOcId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S4 ;
          prmT000S4 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000S47 ;
          prmT000S47 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000S48 ;
          prmT000S48 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvOcId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S3 ;
          prmT000S3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvOcId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S2 ;
          prmT000S2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvOcId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S49 ;
          prmT000S49 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvOcId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvOCNro",SqlDbType.Int,8,0} ,
          new Object[] {"@detInvOcDoc",SqlDbType.Char,3,0} ,
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT000S50 ;
          prmT000S50 = new Object[] {
          new Object[] {"@detInvOCNro",SqlDbType.Int,8,0} ,
          new Object[] {"@detInvOcDoc",SqlDbType.Char,3,0} ,
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvOcId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S51 ;
          prmT000S51 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detInvOcId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S53 ;
          prmT000S53 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S54 ;
          prmT000S54 = new Object[] {
          } ;
          Object[] prmT000S55 ;
          prmT000S55 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S56 ;
          prmT000S56 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S57 ;
          prmT000S57 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S59 ;
          prmT000S59 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@invCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S60 ;
          prmT000S60 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000S44 ;
          prmT000S44 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000S52 ;
          prmT000S52 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000S2", "SELECT [EmpID], [AgeID], [BodCod], [invCod], [detInvOcId], [detInvOCNro], [detInvOcDoc], [PrvRuc] FROM [InventariodetInvOc] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod AND [detInvOcId] = @detInvOcId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S2,1,0,true,false )
             ,new CursorDef("T000S3", "SELECT [EmpID], [AgeID], [BodCod], [invCod], [detInvOcId], [detInvOCNro], [detInvOcDoc], [PrvRuc] FROM [InventariodetInvOc] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod AND [detInvOcId] = @detInvOcId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S3,1,0,true,false )
             ,new CursorDef("T000S4", "SELECT [PrvDsc], [PrvEst] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S4,1,0,true,false )
             ,new CursorDef("T000S5", "SELECT [BodCod], [invCod], [detInvId], [detInvUniCod], [detInvCant], [detInvCosto], [EmpID], [AgeID], [PrdCod] FROM [InventariodetInv] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod AND [detInvId] = @detInvId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S5,1,0,true,false )
             ,new CursorDef("T000S6", "SELECT [BodCod], [invCod], [detInvId], [detInvUniCod], [detInvCant], [detInvCosto], [EmpID], [AgeID], [PrdCod] FROM [InventariodetInv] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod AND [detInvId] = @detInvId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S6,1,0,true,false )
             ,new CursorDef("T000S7", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S7,1,0,true,false )
             ,new CursorDef("T000S8", "SELECT [invCod], [InvUser], [InvDsc], [InvFch], [InvEst], [InvGuia], [InvFac], [InvHora], [InvUltNro], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [Inventario] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S8,1,0,true,false )
             ,new CursorDef("T000S9", "SELECT [invCod], [InvUser], [InvDsc], [InvFch], [InvEst], [InvGuia], [InvFac], [InvHora], [InvUltNro], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [Inventario] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S9,1,0,true,false )
             ,new CursorDef("T000S10", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S10,1,0,true,false )
             ,new CursorDef("T000S11", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S11,1,0,true,false )
             ,new CursorDef("T000S12", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S12,1,0,true,false )
             ,new CursorDef("T000S13", "SELECT [TipoInvMov], [TipoInvSigno] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S13,1,0,true,false )
             ,new CursorDef("T000S15", "SELECT COALESCE( T1.[detInvTotal], 0) AS detInvTotal FROM (SELECT SUM(COALESCE( [detInvCosto], 0) * CAST(COALESCE( [detInvCant], 0) AS decimal( 18, 10))) AS detInvTotal, [EmpID], [AgeID], [BodCod], [invCod] FROM [InventariodetInv] WITH (UPDLOCK) GROUP BY [EmpID], [AgeID], [BodCod], [invCod] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[invCod] = @invCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S15,1,0,true,false )
             ,new CursorDef("T000S17", "SELECT TM1.[invCod], TM1.[InvUser], T2.[empdsc], T3.[AgeDsc], T4.[BodDsc], TM1.[InvDsc], TM1.[InvFch], T6.[TipoInvMov], T6.[TipoInvSigno], TM1.[InvEst], TM1.[InvGuia], TM1.[InvFac], TM1.[InvHora], TM1.[InvUltNro], TM1.[EmpID], TM1.[AgeID], TM1.[BodCod], TM1.[TipoInv], COALESCE( T5.[detInvTotal], 0) AS detInvTotal FROM ((((([Inventario] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[AgeID] = TM1.[AgeID]) INNER JOIN [Bodegas] T4 WITH (NOLOCK) ON T4.[EmpID] = TM1.[EmpID] AND T4.[BodCod] = TM1.[BodCod]) LEFT JOIN (SELECT SUM(COALESCE( [detInvCosto], 0) * CAST(COALESCE( [detInvCant], 0) AS decimal( 18, 10))) AS detInvTotal, [EmpID], [AgeID], [BodCod], [invCod] FROM [InventariodetInv] WITH (NOLOCK) GROUP BY [EmpID], [AgeID], [BodCod], [invCod] ) T5 ON T5.[EmpID] = TM1.[EmpID] AND T5.[AgeID] = TM1.[AgeID] AND T5.[BodCod] = TM1.[BodCod] AND T5.[invCod] = TM1.[invCod]) INNER JOIN [TipoMovimiento] T6 WITH (NOLOCK) ON T6.[TipoInv] = TM1.[TipoInv]) WHERE TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[BodCod] = @BodCod and TM1.[invCod] = @invCod ORDER BY TM1.[EmpID], TM1.[AgeID], TM1.[BodCod], TM1.[invCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S17,100,0,true,false )
             ,new CursorDef("T000S18", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S18,1,0,true,false )
             ,new CursorDef("T000S19", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S19,1,0,true,false )
             ,new CursorDef("T000S20", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S20,1,0,true,false )
             ,new CursorDef("T000S22", "SELECT COALESCE( T1.[detInvTotal], 0) AS detInvTotal FROM (SELECT SUM(COALESCE( [detInvCosto], 0) * CAST(COALESCE( [detInvCant], 0) AS decimal( 18, 10))) AS detInvTotal, [EmpID], [AgeID], [BodCod], [invCod] FROM [InventariodetInv] WITH (UPDLOCK) GROUP BY [EmpID], [AgeID], [BodCod], [invCod] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[invCod] = @invCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S22,1,0,true,false )
             ,new CursorDef("T000S23", "SELECT [TipoInvMov], [TipoInvSigno] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S23,1,0,true,false )
             ,new CursorDef("T000S24", "SELECT [EmpID], [AgeID], [BodCod], [invCod] FROM [Inventario] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S24,1,0,true,false )
             ,new CursorDef("T000S25", "SELECT TOP 1 [EmpID], [AgeID], [BodCod], [invCod] FROM [Inventario] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [AgeID] > @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [BodCod] > @BodCod or [BodCod] = @BodCod and [AgeID] = @AgeID and [EmpID] = @EmpID and [invCod] > @invCod) ORDER BY [EmpID], [AgeID], [BodCod], [invCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S25,1,0,true,true )
             ,new CursorDef("T000S26", "SELECT TOP 1 [EmpID], [AgeID], [BodCod], [invCod] FROM [Inventario] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [AgeID] < @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [BodCod] < @BodCod or [BodCod] = @BodCod and [AgeID] = @AgeID and [EmpID] = @EmpID and [invCod] < @invCod) ORDER BY [EmpID] DESC, [AgeID] DESC, [BodCod] DESC, [invCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S26,1,0,true,true )
             ,new CursorDef("T000S27", "INSERT INTO [Inventario]([invCod], [InvUser], [InvDsc], [InvFch], [InvEst], [InvGuia], [InvFac], [InvHora], [InvUltNro], [EmpID], [AgeID], [BodCod], [TipoInv]) VALUES(@invCod, @InvUser, @InvDsc, @InvFch, @InvEst, @InvGuia, @InvFac, @InvHora, @InvUltNro, @EmpID, @AgeID, @BodCod, @TipoInv)", GxErrorMask.GX_NOMASK,prmT000S27)
             ,new CursorDef("T000S28", "UPDATE [Inventario] SET [InvUser]=@InvUser, [InvDsc]=@InvDsc, [InvFch]=@InvFch, [InvEst]=@InvEst, [InvGuia]=@InvGuia, [InvFac]=@InvFac, [InvHora]=@InvHora, [InvUltNro]=@InvUltNro, [TipoInv]=@TipoInv  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod", GxErrorMask.GX_NOMASK,prmT000S28)
             ,new CursorDef("T000S29", "DELETE FROM [Inventario]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod", GxErrorMask.GX_NOMASK,prmT000S29)
             ,new CursorDef("T000S30", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S30,1,0,true,false )
             ,new CursorDef("T000S31", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S31,1,0,true,false )
             ,new CursorDef("T000S32", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S32,1,0,true,false )
             ,new CursorDef("T000S34", "SELECT COALESCE( T1.[detInvTotal], 0) AS detInvTotal FROM (SELECT SUM(COALESCE( [detInvCosto], 0) * CAST(COALESCE( [detInvCant], 0) AS decimal( 18, 10))) AS detInvTotal, [EmpID], [AgeID], [BodCod], [invCod] FROM [InventariodetInv] WITH (UPDLOCK) GROUP BY [EmpID], [AgeID], [BodCod], [invCod] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[invCod] = @invCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S34,1,0,true,false )
             ,new CursorDef("T000S35", "SELECT [TipoInvMov], [TipoInvSigno] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S35,1,0,true,false )
             ,new CursorDef("T000S36", "UPDATE [Inventario] SET [InvUltNro]=@InvUltNro  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod", GxErrorMask.GX_NOMASK,prmT000S36)
             ,new CursorDef("T000S37", "SELECT [EmpID], [AgeID], [BodCod], [invCod] FROM [Inventario] WITH (NOLOCK) ORDER BY [EmpID], [AgeID], [BodCod], [invCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000S37,100,0,true,false )
             ,new CursorDef("T000S38", "SELECT T1.[BodCod], T1.[invCod], T1.[detInvId], T2.[prdNombre], T1.[detInvUniCod], T1.[detInvCant], T1.[detInvCosto], T1.[EmpID], T1.[AgeID], T1.[PrdCod] FROM ([InventariodetInv] T1 WITH (NOLOCK) INNER JOIN [Productos] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[PrdCod] = T1.[PrdCod]) WHERE T1.[EmpID] = @EmpID and T1.[AgeID] = @AgeID and T1.[BodCod] = @BodCod and T1.[invCod] = @invCod and T1.[detInvId] = @detInvId ORDER BY T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[invCod], T1.[detInvId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S38,11,0,true,false )
             ,new CursorDef("T000S39", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S39,1,0,true,false )
             ,new CursorDef("T000S40", "SELECT [EmpID], [AgeID], [BodCod], [invCod], [detInvId] FROM [InventariodetInv] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod AND [detInvId] = @detInvId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S40,1,0,true,false )
             ,new CursorDef("T000S41", "INSERT INTO [InventariodetInv]([BodCod], [invCod], [detInvId], [detInvUniCod], [detInvCant], [detInvCosto], [EmpID], [AgeID], [PrdCod]) VALUES(@BodCod, @invCod, @detInvId, @detInvUniCod, @detInvCant, @detInvCosto, @EmpID, @AgeID, @PrdCod)", GxErrorMask.GX_NOMASK,prmT000S41)
             ,new CursorDef("T000S42", "UPDATE [InventariodetInv] SET [detInvUniCod]=@detInvUniCod, [detInvCant]=@detInvCant, [detInvCosto]=@detInvCosto, [PrdCod]=@PrdCod  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod AND [detInvId] = @detInvId", GxErrorMask.GX_NOMASK,prmT000S42)
             ,new CursorDef("T000S43", "DELETE FROM [InventariodetInv]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod AND [detInvId] = @detInvId", GxErrorMask.GX_NOMASK,prmT000S43)
             ,new CursorDef("T000S44", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S44,1,0,true,false )
             ,new CursorDef("T000S45", "SELECT [EmpID], [AgeID], [BodCod], [invCod], [detInvId] FROM [InventariodetInv] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [AgeID] = @AgeID and [BodCod] = @BodCod and [invCod] = @invCod ORDER BY [EmpID], [AgeID], [BodCod], [invCod], [detInvId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S45,11,0,true,false )
             ,new CursorDef("T000S46", "SELECT T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[invCod], T1.[detInvOcId], T2.[PrvDsc], T2.[PrvEst], T1.[detInvOCNro], T1.[detInvOcDoc], T1.[PrvRuc] FROM ([InventariodetInvOc] T1 WITH (NOLOCK) INNER JOIN [Proveedor] T2 WITH (NOLOCK) ON T2.[PrvRuc] = T1.[PrvRuc]) WHERE T1.[EmpID] = @EmpID and T1.[AgeID] = @AgeID and T1.[BodCod] = @BodCod and T1.[invCod] = @invCod and T1.[detInvOcId] = @detInvOcId ORDER BY T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[invCod], T1.[detInvOcId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S46,11,0,true,false )
             ,new CursorDef("T000S47", "SELECT [PrvDsc], [PrvEst] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S47,1,0,true,false )
             ,new CursorDef("T000S48", "SELECT [EmpID], [AgeID], [BodCod], [invCod], [detInvOcId] FROM [InventariodetInvOc] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod AND [detInvOcId] = @detInvOcId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S48,1,0,true,false )
             ,new CursorDef("T000S49", "INSERT INTO [InventariodetInvOc]([EmpID], [AgeID], [BodCod], [invCod], [detInvOcId], [detInvOCNro], [detInvOcDoc], [PrvRuc]) VALUES(@EmpID, @AgeID, @BodCod, @invCod, @detInvOcId, @detInvOCNro, @detInvOcDoc, @PrvRuc)", GxErrorMask.GX_NOMASK,prmT000S49)
             ,new CursorDef("T000S50", "UPDATE [InventariodetInvOc] SET [detInvOCNro]=@detInvOCNro, [detInvOcDoc]=@detInvOcDoc, [PrvRuc]=@PrvRuc  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod AND [detInvOcId] = @detInvOcId", GxErrorMask.GX_NOMASK,prmT000S50)
             ,new CursorDef("T000S51", "DELETE FROM [InventariodetInvOc]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [invCod] = @invCod AND [detInvOcId] = @detInvOcId", GxErrorMask.GX_NOMASK,prmT000S51)
             ,new CursorDef("T000S52", "SELECT [PrvDsc], [PrvEst] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S52,1,0,true,false )
             ,new CursorDef("T000S53", "SELECT [EmpID], [AgeID], [BodCod], [invCod], [detInvOcId] FROM [InventariodetInvOc] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [AgeID] = @AgeID and [BodCod] = @BodCod and [invCod] = @invCod ORDER BY [EmpID], [AgeID], [BodCod], [invCod], [detInvOcId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S53,11,0,true,false )
             ,new CursorDef("T000S54", "SELECT [TipoInv], [TipoInvMov] FROM [TipoMovimiento] WITH (NOLOCK) ORDER BY [TipoInvMov] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S54,0,0,true,false )
             ,new CursorDef("T000S55", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S55,1,0,true,false )
             ,new CursorDef("T000S56", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S56,1,0,true,false )
             ,new CursorDef("T000S57", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S57,1,0,true,false )
             ,new CursorDef("T000S59", "SELECT COALESCE( T1.[detInvTotal], 0) AS detInvTotal FROM (SELECT SUM(COALESCE( [detInvCosto], 0) * CAST(COALESCE( [detInvCant], 0) AS decimal( 18, 10))) AS detInvTotal, [EmpID], [AgeID], [BodCod], [invCod] FROM [InventariodetInv] WITH (UPDLOCK) GROUP BY [EmpID], [AgeID], [BodCod], [invCod] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[invCod] = @invCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S59,1,0,true,false )
             ,new CursorDef("T000S60", "SELECT [TipoInvMov], [TipoInvSigno] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000S60,1,0,true,false )
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
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 3) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getString(8, 13) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 3) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getString(8, 13) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((int[]) buf[5])[0] = rslt.getInt(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((int[]) buf[5])[0] = rslt.getInt(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 20) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 20) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                ((short[]) buf[19])[0] = rslt.getShort(12) ;
                ((String[]) buf[20])[0] = rslt.getString(13, 4) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 20) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getString(7, 20) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                ((short[]) buf[19])[0] = rslt.getShort(12) ;
                ((String[]) buf[20])[0] = rslt.getString(13, 4) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 12 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 50) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[11])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((short[]) buf[15])[0] = rslt.getShort(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getString(10, 1) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getString(11, 20) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getString(12, 20) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[23])[0] = rslt.getGXDateTime(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((int[]) buf[25])[0] = rslt.getInt(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((short[]) buf[27])[0] = rslt.getShort(15) ;
                ((short[]) buf[28])[0] = rslt.getShort(16) ;
                ((short[]) buf[29])[0] = rslt.getShort(17) ;
                ((String[]) buf[30])[0] = rslt.getString(18, 4) ;
                ((decimal[]) buf[31])[0] = rslt.getDecimal(19) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(19);
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 17 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 25 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 26 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 28 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 29 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 31 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 32 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 3) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((int[]) buf[7])[0] = rslt.getInt(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((short[]) buf[12])[0] = rslt.getShort(9) ;
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                return;
             case 33 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 34 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 38 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 39 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 40 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((int[]) buf[9])[0] = rslt.getInt(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((String[]) buf[11])[0] = rslt.getString(9, 3) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((String[]) buf[13])[0] = rslt.getString(10, 13) ;
                return;
             case 41 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 42 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 46 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 47 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 48 :
                ((String[]) buf[0])[0] = rslt.getString(1, 4) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 49 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 50 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 51 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 52 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 53 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
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
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
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
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(9, (int)parms[16]);
                }
                stmt.SetParameter(10, (short)parms[17]);
                stmt.SetParameter(11, (short)parms[18]);
                stmt.SetParameter(12, (short)parms[19]);
                stmt.SetParameter(13, (String)parms[20]);
                return;
             case 23 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
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
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(8, (int)parms[15]);
                }
                stmt.SetParameter(9, (String)parms[16]);
                stmt.SetParameter(10, (short)parms[17]);
                stmt.SetParameter(11, (short)parms[18]);
                stmt.SetParameter(12, (short)parms[19]);
                stmt.SetParameter(13, (short)parms[20]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 29 :
                stmt.SetParameter(1, (String)parms[0]);
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
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                return;
             case 32 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 33 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 34 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 35 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[8]);
                }
                stmt.SetParameter(7, (short)parms[9]);
                stmt.SetParameter(8, (short)parms[10]);
                stmt.SetParameter(9, (short)parms[11]);
                return;
             case 36 :
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
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[3]);
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
                stmt.SetParameter(9, (short)parms[11]);
                return;
             case 37 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 38 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 39 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 40 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 41 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 42 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 43 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[8]);
                }
                stmt.SetParameter(8, (String)parms[9]);
                return;
             case 44 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                stmt.SetParameter(3, (String)parms[4]);
                stmt.SetParameter(4, (short)parms[5]);
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (short)parms[9]);
                return;
             case 45 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 46 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 47 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 49 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 50 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 51 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 52 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 53 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
