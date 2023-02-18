/*
               File: HistPrecioProd
        Description: Hist Precio Productos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:53:32.58
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
   public class histprecioprod : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"DETTIPOPRODID") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLADETTIPOPRODID0Q39( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"CATEGID") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A36detTipoProdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLACATEGID0Q39( A1EmpID, A36detTipoProdID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"SUBCATID") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A32categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLASUBCATID0Q39( A1EmpID, A32categID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_29") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_29( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_30") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A36detTipoProdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_30( A1EmpID, A36detTipoProdID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_31") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A32categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_31( A1EmpID, A32categID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_32") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A32categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
            A33subCatID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_32( A1EmpID, A32categID, A33subCatID) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridhistprecioprod_level1") == 0 )
         {
            nRC_GXsfl_83 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_83_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_83_idx = GetNextPar( );
            A230HistUltNro = (int)(NumberUtil.Val( GetNextPar( ), "."));
            n230HistUltNro = false;
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridhistprecioprod_level1_newrow( ) ;
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
               AV8HistAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8HistAnio), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vHISTANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8HistAnio), "ZZZ9"), context));
               AV9HistPeriodo = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9HistPeriodo), 2, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vHISTPERIODO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9HistPeriodo), "Z9"), context));
               AV10detTipoProdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10detTipoProdID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vDETTIPOPRODID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10detTipoProdID), "ZZZ9"), context));
               AV11categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11categID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11categID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCATEGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11categID), "ZZZ9"), context));
               AV19subCatID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19subCatID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSUBCATID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19subCatID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Hist Precio Productos", 0) ;
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

      public histprecioprod( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public histprecioprod( IGxContext context )
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
                           short aP2_HistAnio ,
                           short aP3_HistPeriodo ,
                           short aP4_detTipoProdID ,
                           short aP5_categID ,
                           short aP6_subCatID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpID = aP1_EmpID;
         this.AV8HistAnio = aP2_HistAnio;
         this.AV9HistPeriodo = aP3_HistPeriodo;
         this.AV10detTipoProdID = aP4_detTipoProdID;
         this.AV11categID = aP5_categID;
         this.AV19subCatID = aP6_subCatID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbHistPeriodo = new GXCombobox();
         dyndetTipoProdID = new GXCombobox();
         dyncategID = new GXCombobox();
         dynsubCatID = new GXCombobox();
         chkHistEst = new GXCheckbox();
         chkDetHistAct = new GXCheckbox();
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
         if ( cmbHistPeriodo.ItemCount > 0 )
         {
            A228HistPeriodo = (short)(NumberUtil.Val( cmbHistPeriodo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbHistPeriodo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbHistPeriodo_Internalname, "Values", cmbHistPeriodo.ToJavascriptSource(), true);
         }
         if ( dyndetTipoProdID.ItemCount > 0 )
         {
            A36detTipoProdID = (short)(NumberUtil.Val( dyndetTipoProdID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dyndetTipoProdID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyndetTipoProdID_Internalname, "Values", dyndetTipoProdID.ToJavascriptSource(), true);
         }
         if ( dyncategID.ItemCount > 0 )
         {
            A32categID = (short)(NumberUtil.Val( dyncategID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dyncategID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyncategID_Internalname, "Values", dyncategID.ToJavascriptSource(), true);
         }
         if ( dynsubCatID.ItemCount > 0 )
         {
            A33subCatID = (short)(NumberUtil.Val( dynsubCatID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A33subCatID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynsubCatID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A33subCatID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynsubCatID_Internalname, "Values", dynsubCatID.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Historico Precio Productos", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_HistPrecioProd.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0130.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"HISTANIO"+"'), id:'"+"HISTANIO"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"HISTPERIODO"+"'), id:'"+"HISTPERIODO"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"DETTIPOPRODID"+"'), id:'"+"DETTIPOPRODID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"CATEGID"+"'), id:'"+"CATEGID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"SUBCATID"+"'), id:'"+"SUBCATID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_HistPrecioProd.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_HistPrecioProd.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtempdsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtempdsc_Internalname, "Empresa", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtHistAnio_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtHistAnio_Internalname, "Año", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtHistAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A227HistAnio), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A227HistAnio), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtHistAnio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtHistAnio_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbHistPeriodo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbHistPeriodo_Internalname, "Mes", "col-sm-3 ComboAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbHistPeriodo, cmbHistPeriodo_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)), 1, cmbHistPeriodo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbHistPeriodo.Enabled, 1, 0, 0, "em", 0, "", "", "ComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "", true, "HLP_HistPrecioProd.htm");
            cmbHistPeriodo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbHistPeriodo_Internalname, "Values", (String)(cmbHistPeriodo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dyndetTipoProdID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dyndetTipoProdID_Internalname, "Tipo Producto", "col-sm-3 ComboAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dyndetTipoProdID, dyndetTipoProdID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)), 1, dyndetTipoProdID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dyndetTipoProdID.Enabled, 1, 0, 0, "em", 0, "", "", "ComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "", true, "HLP_HistPrecioProd.htm");
            dyndetTipoProdID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyndetTipoProdID_Internalname, "Values", (String)(dyndetTipoProdID.ToJavascriptSource()), true);
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_36_Internalname, sImgUrl, imgprompt_36_Link, "", "", context.GetTheme( ), imgprompt_36_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dyncategID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dyncategID_Internalname, "Categoria", "col-sm-3 ComboAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dyncategID, dyncategID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0)), 1, dyncategID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dyncategID.Enabled, 1, 0, 0, "em", 0, "", "", "ComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "", true, "HLP_HistPrecioProd.htm");
            dyncategID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyncategID_Internalname, "Values", (String)(dyncategID.ToJavascriptSource()), true);
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_32_Internalname, sImgUrl, imgprompt_32_Link, "", "", context.GetTheme( ), imgprompt_32_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynsubCatID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynsubCatID_Internalname, "Producto", "col-sm-3 ComboAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynsubCatID, dynsubCatID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)), 1, dynsubCatID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynsubCatID.Enabled, 1, 0, 0, "em", 0, "", "", "ComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "", true, "HLP_HistPrecioProd.htm");
            dynsubCatID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A33subCatID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynsubCatID_Internalname, "Values", (String)(dynsubCatID.ToJavascriptSource()), true);
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_33_Internalname, sImgUrl, imgprompt_33_Link, "", "", context.GetTheme( ), imgprompt_33_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkHistEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkHistEst_Internalname, "Estado", "col-sm-3 CheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            ClassString = "CheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkHistEst_Internalname, A229HistEst, "", "Estado", 1, chkHistEst.Enabled, "A", "Activo?", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(69, this, 'A', 'I');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtHistUltNro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtHistUltNro_Internalname, "Ultimo Nro.", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtHistUltNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A230HistUltNro), 8, 0, ",", "")), ((edtHistUltNro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A230HistUltNro), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A230HistUltNro), "ZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtHistUltNro_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtHistUltNro_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLevel1table_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlelevel1_Internalname, "Historial", "", "", lblTitlelevel1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridhistprecioprod_level1( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_HistPrecioProd.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0Q39( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridhistprecioprod_level1( )
      {
         /*  Grid Control  */
         Gridhistprecioprod_level1Container.AddObjectProperty("GridName", "Gridhistprecioprod_level1");
         Gridhistprecioprod_level1Container.AddObjectProperty("Header", subGridhistprecioprod_level1_Header);
         Gridhistprecioprod_level1Container.AddObjectProperty("Class", "Grid");
         Gridhistprecioprod_level1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridhistprecioprod_level1_Backcolorstyle), 1, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddObjectProperty("CmpContext", "");
         Gridhistprecioprod_level1Container.AddObjectProperty("InMasterPage", "false");
         Gridhistprecioprod_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridhistprecioprod_level1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A231DetHistNro), 8, 0, ".", "")));
         Gridhistprecioprod_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistNro_Enabled), 5, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddColumnProperties(Gridhistprecioprod_level1Column);
         Gridhistprecioprod_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridhistprecioprod_level1Column.AddObjectProperty("Value", context.localUtil.Format(A232DetHistFcha, "99/99/9999"));
         Gridhistprecioprod_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistFcha_Enabled), 5, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddColumnProperties(Gridhistprecioprod_level1Column);
         Gridhistprecioprod_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridhistprecioprod_level1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A233DetHistPrecio, 8, 2, ".", "")));
         Gridhistprecioprod_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistPrecio_Enabled), 5, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddColumnProperties(Gridhistprecioprod_level1Column);
         Gridhistprecioprod_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridhistprecioprod_level1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A237DetHistAct), 1, 0, ".", "")));
         Gridhistprecioprod_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkDetHistAct.Enabled), 5, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddColumnProperties(Gridhistprecioprod_level1Column);
         Gridhistprecioprod_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridhistprecioprod_level1Column.AddObjectProperty("Value", context.localUtil.Format(A234DetHistFchaApli, "99/99/9999"));
         Gridhistprecioprod_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistFchaApli_Enabled), 5, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddColumnProperties(Gridhistprecioprod_level1Column);
         Gridhistprecioprod_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridhistprecioprod_level1Column.AddObjectProperty("Value", StringUtil.RTrim( A235DetHistObs));
         Gridhistprecioprod_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistObs_Enabled), 5, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddColumnProperties(Gridhistprecioprod_level1Column);
         Gridhistprecioprod_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridhistprecioprod_level1Column.AddObjectProperty("Value", StringUtil.RTrim( A236DetHistMotivo));
         Gridhistprecioprod_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistMotivo_Enabled), 5, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddColumnProperties(Gridhistprecioprod_level1Column);
         Gridhistprecioprod_level1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridhistprecioprod_level1_Selectedindex), 4, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridhistprecioprod_level1_Allowselection), 1, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridhistprecioprod_level1_Selectioncolor), 9, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridhistprecioprod_level1_Allowhovering), 1, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridhistprecioprod_level1_Hoveringcolor), 9, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridhistprecioprod_level1_Allowcollapsing), 1, 0, ".", "")));
         Gridhistprecioprod_level1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridhistprecioprod_level1_Collapsed), 1, 0, ".", "")));
         nGXsfl_83_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount40 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_40 = 1;
               ScanStart0Q40( ) ;
               while ( RcdFound40 != 0 )
               {
                  init_level_properties40( ) ;
                  getByPrimaryKey0Q40( ) ;
                  AddRow0Q40( ) ;
                  ScanNext0Q40( ) ;
               }
               ScanEnd0Q40( ) ;
               nBlankRcdCount40 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B230HistUltNro = A230HistUltNro;
            n230HistUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
            standaloneNotModal0Q40( ) ;
            standaloneModal0Q40( ) ;
            sMode40 = Gx_mode;
            while ( nGXsfl_83_idx < nRC_GXsfl_83 )
            {
               bGXsfl_83_Refreshing = true;
               ReadRow0Q40( ) ;
               edtDetHistNro_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTNRO_"+sGXsfl_83_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistNro_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
               edtDetHistFcha_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTFCHA_"+sGXsfl_83_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistFcha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistFcha_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
               edtDetHistPrecio_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTPRECIO_"+sGXsfl_83_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistPrecio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistPrecio_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
               chkDetHistAct.Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTACT_"+sGXsfl_83_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDetHistAct_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkDetHistAct.Enabled), 5, 0)), !bGXsfl_83_Refreshing);
               edtDetHistFchaApli_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTFCHAAPLI_"+sGXsfl_83_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistFchaApli_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistFchaApli_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
               edtDetHistObs_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTOBS_"+sGXsfl_83_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistObs_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
               edtDetHistMotivo_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTMOTIVO_"+sGXsfl_83_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistMotivo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistMotivo_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
               if ( ( nRcdExists_40 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0Q40( ) ;
               }
               SendRow0Q40( ) ;
               bGXsfl_83_Refreshing = false;
            }
            Gx_mode = sMode40;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A230HistUltNro = B230HistUltNro;
            n230HistUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount40 = 5;
            nRcdExists_40 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0Q40( ) ;
               while ( RcdFound40 != 0 )
               {
                  sGXsfl_83_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_83_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_8340( ) ;
                  init_level_properties40( ) ;
                  standaloneNotModal0Q40( ) ;
                  getByPrimaryKey0Q40( ) ;
                  standaloneModal0Q40( ) ;
                  AddRow0Q40( ) ;
                  ScanNext0Q40( ) ;
               }
               ScanEnd0Q40( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode40 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_83_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_83_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_8340( ) ;
            InitAll0Q40( ) ;
            init_level_properties40( ) ;
            B230HistUltNro = A230HistUltNro;
            n230HistUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
            standaloneNotModal0Q40( ) ;
            standaloneModal0Q40( ) ;
            nRcdExists_40 = 0;
            nIsMod_40 = 0;
            nRcdDeleted_40 = 0;
            nBlankRcdCount40 = (short)(nBlankRcdUsr40+nBlankRcdCount40);
            fRowAdded = 0;
            while ( nBlankRcdCount40 > 0 )
            {
               AddRow0Q40( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtDetHistNro_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount40 = (short)(nBlankRcdCount40-1);
            }
            Gx_mode = sMode40;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A230HistUltNro = B230HistUltNro;
            n230HistUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridhistprecioprod_level1Container"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridhistprecioprod_level1", Gridhistprecioprod_level1Container);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridhistprecioprod_level1ContainerData", Gridhistprecioprod_level1Container.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridhistprecioprod_level1ContainerData"+"V", Gridhistprecioprod_level1Container.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridhistprecioprod_level1ContainerData"+"V"+"\" value='"+Gridhistprecioprod_level1Container.GridValuesHidden()+"'/>") ;
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
         E110Q2 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtHistAnio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtHistAnio_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "HISTANIO");
                  AnyError = 1;
                  GX_FocusControl = edtHistAnio_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A227HistAnio = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
               }
               else
               {
                  A227HistAnio = (short)(context.localUtil.CToN( cgiGet( edtHistAnio_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
               }
               cmbHistPeriodo.Name = cmbHistPeriodo_Internalname;
               cmbHistPeriodo.CurrentValue = cgiGet( cmbHistPeriodo_Internalname);
               A228HistPeriodo = (short)(NumberUtil.Val( cgiGet( cmbHistPeriodo_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
               dyndetTipoProdID.Name = dyndetTipoProdID_Internalname;
               dyndetTipoProdID.CurrentValue = cgiGet( dyndetTipoProdID_Internalname);
               A36detTipoProdID = (short)(NumberUtil.Val( cgiGet( dyndetTipoProdID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
               dyncategID.Name = dyncategID_Internalname;
               dyncategID.CurrentValue = cgiGet( dyncategID_Internalname);
               A32categID = (short)(NumberUtil.Val( cgiGet( dyncategID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
               dynsubCatID.Name = dynsubCatID_Internalname;
               dynsubCatID.CurrentValue = cgiGet( dynsubCatID_Internalname);
               A33subCatID = (short)(NumberUtil.Val( cgiGet( dynsubCatID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
               A229HistEst = ((StringUtil.StrCmp(cgiGet( chkHistEst_Internalname), "A")==0) ? "A" : "I");
               n229HistEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229HistEst", A229HistEst);
               n229HistEst = (String.IsNullOrEmpty(StringUtil.RTrim( A229HistEst)) ? true : false);
               A230HistUltNro = (int)(context.localUtil.CToN( cgiGet( edtHistUltNro_Internalname), ",", "."));
               n230HistUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z227HistAnio = (short)(context.localUtil.CToN( cgiGet( "Z227HistAnio"), ",", "."));
               Z228HistPeriodo = (short)(context.localUtil.CToN( cgiGet( "Z228HistPeriodo"), ",", "."));
               Z36detTipoProdID = (short)(context.localUtil.CToN( cgiGet( "Z36detTipoProdID"), ",", "."));
               Z32categID = (short)(context.localUtil.CToN( cgiGet( "Z32categID"), ",", "."));
               Z33subCatID = (short)(context.localUtil.CToN( cgiGet( "Z33subCatID"), ",", "."));
               Z173detTipoProdDsc = cgiGet( "Z173detTipoProdDsc");
               Z229HistEst = cgiGet( "Z229HistEst");
               n229HistEst = (String.IsNullOrEmpty(StringUtil.RTrim( A229HistEst)) ? true : false);
               Z230HistUltNro = (int)(context.localUtil.CToN( cgiGet( "Z230HistUltNro"), ",", "."));
               n230HistUltNro = ((0==A230HistUltNro) ? true : false);
               A173detTipoProdDsc = cgiGet( "Z173detTipoProdDsc");
               O230HistUltNro = (int)(context.localUtil.CToN( cgiGet( "O230HistUltNro"), ",", "."));
               n230HistUltNro = ((0==A230HistUltNro) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_83 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_83"), ",", "."));
               AV7EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV8HistAnio = (short)(context.localUtil.CToN( cgiGet( "vHISTANIO"), ",", "."));
               AV9HistPeriodo = (short)(context.localUtil.CToN( cgiGet( "vHISTPERIODO"), ",", "."));
               AV10detTipoProdID = (short)(context.localUtil.CToN( cgiGet( "vDETTIPOPRODID"), ",", "."));
               AV11categID = (short)(context.localUtil.CToN( cgiGet( "vCATEGID"), ",", "."));
               AV19subCatID = (short)(context.localUtil.CToN( cgiGet( "vSUBCATID"), ",", "."));
               A173detTipoProdDsc = cgiGet( "DETTIPOPRODDSC");
               A146categDsc = cgiGet( "CATEGDSC");
               n146categDsc = false;
               A148subCatDsc = cgiGet( "SUBCATDSC");
               n148subCatDsc = false;
               A31tipoProdID = (short)(context.localUtil.CToN( cgiGet( "TIPOPRODID"), ",", "."));
               AV21Pgmname = cgiGet( "vPGMNAME");
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "HistPrecioProd";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A173detTipoProdDsc, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A227HistAnio != Z227HistAnio ) || ( A228HistPeriodo != Z228HistPeriodo ) || ( A36detTipoProdID != Z36detTipoProdID ) || ( A32categID != Z32categID ) || ( A33subCatID != Z33subCatID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("histprecioprod:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("histprecioprod:[SecurityCheckFailed value for]"+"detTipoProdDsc:"+StringUtil.RTrim( context.localUtil.Format( A173detTipoProdDsc, "@!")));
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
                  A227HistAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
                  A228HistPeriodo = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
                  A36detTipoProdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
                  A32categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
                  A33subCatID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
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
                     sMode39 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode39;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound39 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0Q0( ) ;
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
                        E110Q2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120Q2 ();
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
            E120Q2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0Q39( ) ;
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
            DisableAttributes0Q39( ) ;
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

      protected void CONFIRM_0Q0( )
      {
         BeforeValidate0Q39( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0Q39( ) ;
            }
            else
            {
               CheckExtendedTable0Q39( ) ;
               CloseExtendedTableCursors0Q39( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode39 = Gx_mode;
            CONFIRM_0Q40( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode39;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode39;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0Q40( )
      {
         s230HistUltNro = O230HistUltNro;
         n230HistUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
         nGXsfl_83_idx = 0;
         while ( nGXsfl_83_idx < nRC_GXsfl_83 )
         {
            ReadRow0Q40( ) ;
            if ( ( nRcdExists_40 != 0 ) || ( nIsMod_40 != 0 ) )
            {
               GetKey0Q40( ) ;
               if ( ( nRcdExists_40 == 0 ) && ( nRcdDeleted_40 == 0 ) )
               {
                  if ( RcdFound40 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0Q40( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0Q40( ) ;
                        CloseExtendedTableCursors0Q40( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O230HistUltNro = A230HistUltNro;
                        n230HistUltNro = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
                     }
                  }
                  else
                  {
                     GXCCtl = "DETHISTNRO_" + sGXsfl_83_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtDetHistNro_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound40 != 0 )
                  {
                     if ( nRcdDeleted_40 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0Q40( ) ;
                        Load0Q40( ) ;
                        BeforeValidate0Q40( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0Q40( ) ;
                           O230HistUltNro = A230HistUltNro;
                           n230HistUltNro = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_40 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0Q40( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0Q40( ) ;
                              CloseExtendedTableCursors0Q40( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O230HistUltNro = A230HistUltNro;
                              n230HistUltNro = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_40 == 0 )
                     {
                        GXCCtl = "DETHISTNRO_" + sGXsfl_83_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtDetHistNro_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtDetHistNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A231DetHistNro), 8, 0, ",", ""))) ;
            ChangePostValue( edtDetHistFcha_Internalname, context.localUtil.Format(A232DetHistFcha, "99/99/9999")) ;
            ChangePostValue( edtDetHistPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A233DetHistPrecio, 8, 2, ",", ""))) ;
            ChangePostValue( chkDetHistAct_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A237DetHistAct), 1, 0, ",", ""))) ;
            ChangePostValue( edtDetHistFchaApli_Internalname, context.localUtil.Format(A234DetHistFchaApli, "99/99/9999")) ;
            ChangePostValue( edtDetHistObs_Internalname, StringUtil.RTrim( A235DetHistObs)) ;
            ChangePostValue( edtDetHistMotivo_Internalname, StringUtil.RTrim( A236DetHistMotivo)) ;
            ChangePostValue( "ZT_"+"Z231DetHistNro_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z231DetHistNro), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z232DetHistFcha_"+sGXsfl_83_idx, context.localUtil.DToC( Z232DetHistFcha, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z233DetHistPrecio_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( Z233DetHistPrecio, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z234DetHistFchaApli_"+sGXsfl_83_idx, context.localUtil.DToC( Z234DetHistFchaApli, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z235DetHistObs_"+sGXsfl_83_idx, StringUtil.RTrim( Z235DetHistObs)) ;
            ChangePostValue( "ZT_"+"Z236DetHistMotivo_"+sGXsfl_83_idx, StringUtil.RTrim( Z236DetHistMotivo)) ;
            ChangePostValue( "ZT_"+"Z237DetHistAct_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z237DetHistAct), 1, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_40_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_40), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_40_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_40), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_40_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_40), 4, 0, ",", ""))) ;
            if ( nIsMod_40 != 0 )
            {
               ChangePostValue( "DETHISTNRO_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistNro_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTFCHA_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistFcha_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTPRECIO_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistPrecio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTACT_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkDetHistAct.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTFCHAAPLI_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistFchaApli_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTOBS_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistObs_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTMOTIVO_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistMotivo_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O230HistUltNro = s230HistUltNro;
         n230HistUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0Q0( )
      {
      }

      protected void E110Q2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV21Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV21Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV13TrnContext.FromXml(AV14WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         GX_msglist.addItem(StringUtil.Str( (decimal)(AV7EmpID), 10, 0)+StringUtil.Str( (decimal)(AV8HistAnio), 10, 0)+StringUtil.Str( (decimal)(AV9HistPeriodo), 10, 0)+StringUtil.Str( (decimal)(AV10detTipoProdID), 10, 0)+StringUtil.Str( (decimal)(AV11categID), 10, 0)+StringUtil.Str( (decimal)(AV19subCatID), 10, 0));
      }

      protected void E120Q2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV13TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwhistprecioprod.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0Q39( short GX_JID )
      {
         if ( ( GX_JID == 28 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z173detTipoProdDsc = T000Q5_A173detTipoProdDsc[0];
               Z229HistEst = T000Q5_A229HistEst[0];
               Z230HistUltNro = T000Q5_A230HistUltNro[0];
            }
            else
            {
               Z173detTipoProdDsc = A173detTipoProdDsc;
               Z229HistEst = A229HistEst;
               Z230HistUltNro = A230HistUltNro;
            }
         }
         if ( GX_JID == -28 )
         {
            Z227HistAnio = A227HistAnio;
            Z228HistPeriodo = A228HistPeriodo;
            Z173detTipoProdDsc = A173detTipoProdDsc;
            Z229HistEst = A229HistEst;
            Z230HistUltNro = A230HistUltNro;
            Z1EmpID = A1EmpID;
            Z36detTipoProdID = A36detTipoProdID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            Z44empdsc = A44empdsc;
            Z146categDsc = A146categDsc;
            Z148subCatDsc = A148subCatDsc;
         }
      }

      protected void standaloneNotModal( )
      {
         GXADETTIPOPRODID_html0Q39( ) ;
         edtHistUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistUltNro_Enabled), 5, 0)), true);
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_36_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00p1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"DETTIPOPRODID"+"'), id:'"+"DETTIPOPRODID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_32_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00q1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CATEGID"+"'), id:'"+"CATEGID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_33_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00r2.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CATEGID"+"'), id:'"+"CATEGID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"SUBCATID"+"'), id:'"+"SUBCATID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");");
         edtHistUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistUltNro_Enabled), 5, 0)), true);
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
         if ( ! (0==AV8HistAnio) )
         {
            A227HistAnio = AV8HistAnio;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
         }
         if ( ! (0==AV8HistAnio) )
         {
            edtHistAnio_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistAnio_Enabled), 5, 0)), true);
         }
         else
         {
            edtHistAnio_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistAnio_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8HistAnio) )
         {
            edtHistAnio_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistAnio_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV9HistPeriodo) )
         {
            A228HistPeriodo = AV9HistPeriodo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
         }
         if ( ! (0==AV9HistPeriodo) )
         {
            cmbHistPeriodo.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbHistPeriodo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbHistPeriodo.Enabled), 5, 0)), true);
         }
         else
         {
            cmbHistPeriodo.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbHistPeriodo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbHistPeriodo.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV9HistPeriodo) )
         {
            cmbHistPeriodo.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbHistPeriodo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbHistPeriodo.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10detTipoProdID) )
         {
            A36detTipoProdID = AV10detTipoProdID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
         }
         if ( ! (0==AV10detTipoProdID) )
         {
            dyndetTipoProdID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyndetTipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyndetTipoProdID.Enabled), 5, 0)), true);
         }
         else
         {
            dyndetTipoProdID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyndetTipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyndetTipoProdID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10detTipoProdID) )
         {
            dyndetTipoProdID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyndetTipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyndetTipoProdID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV11categID) )
         {
            A32categID = AV11categID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
         }
         if ( ! (0==AV11categID) )
         {
            dyncategID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyncategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyncategID.Enabled), 5, 0)), true);
         }
         else
         {
            dyncategID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyncategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyncategID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV11categID) )
         {
            dyncategID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyncategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyncategID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV19subCatID) )
         {
            A33subCatID = AV19subCatID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
         }
         if ( ! (0==AV19subCatID) )
         {
            dynsubCatID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynsubCatID.Enabled), 5, 0)), true);
         }
         else
         {
            dynsubCatID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynsubCatID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV19subCatID) )
         {
            dynsubCatID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynsubCatID.Enabled), 5, 0)), true);
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
            /* Using cursor T000Q6 */
            pr_default.execute(4, new Object[] {A1EmpID});
            A44empdsc = T000Q6_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000Q6_n44empdsc[0];
            pr_default.close(4);
            GXACATEGID_html0Q39( A1EmpID, A36detTipoProdID) ;
            AV21Pgmname = "HistPrecioProd";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Pgmname", AV21Pgmname);
            /* Using cursor T000Q8 */
            pr_default.execute(6, new Object[] {A1EmpID, A32categID});
            A146categDsc = T000Q8_A146categDsc[0];
            n146categDsc = T000Q8_n146categDsc[0];
            pr_default.close(6);
            GXASUBCATID_html0Q39( A1EmpID, A32categID) ;
            /* Using cursor T000Q9 */
            pr_default.execute(7, new Object[] {A1EmpID, A32categID, A33subCatID});
            A148subCatDsc = T000Q9_A148subCatDsc[0];
            n148subCatDsc = T000Q9_n148subCatDsc[0];
            pr_default.close(7);
         }
      }

      protected void Load0Q39( )
      {
         /* Using cursor T000Q11 */
         pr_default.execute(9, new Object[] {A227HistAnio, A228HistPeriodo, A1EmpID, A36detTipoProdID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound39 = 1;
            A44empdsc = T000Q11_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000Q11_n44empdsc[0];
            A173detTipoProdDsc = T000Q11_A173detTipoProdDsc[0];
            A146categDsc = T000Q11_A146categDsc[0];
            n146categDsc = T000Q11_n146categDsc[0];
            A148subCatDsc = T000Q11_A148subCatDsc[0];
            n148subCatDsc = T000Q11_n148subCatDsc[0];
            A229HistEst = T000Q11_A229HistEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229HistEst", A229HistEst);
            n229HistEst = T000Q11_n229HistEst[0];
            A230HistUltNro = T000Q11_A230HistUltNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
            n230HistUltNro = T000Q11_n230HistUltNro[0];
            ZM0Q39( -28) ;
         }
         pr_default.close(9);
         OnLoadActions0Q39( ) ;
      }

      protected void OnLoadActions0Q39( )
      {
         AV21Pgmname = "HistPrecioProd";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Pgmname", AV21Pgmname);
         GXACATEGID_html0Q39( A1EmpID, A36detTipoProdID) ;
         GXASUBCATID_html0Q39( A1EmpID, A32categID) ;
      }

      protected void CheckExtendedTable0Q39( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV21Pgmname = "HistPrecioProd";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Pgmname", AV21Pgmname);
         /* Using cursor T000Q6 */
         pr_default.execute(4, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000Q6_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000Q6_n44empdsc[0];
         pr_default.close(4);
         /* Using cursor T000Q7 */
         pr_default.execute(5, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(5);
         GXACATEGID_html0Q39( A1EmpID, A36detTipoProdID) ;
         /* Using cursor T000Q8 */
         pr_default.execute(6, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A146categDsc = T000Q8_A146categDsc[0];
         n146categDsc = T000Q8_n146categDsc[0];
         pr_default.close(6);
         GXASUBCATID_html0Q39( A1EmpID, A32categID) ;
         /* Using cursor T000Q9 */
         pr_default.execute(7, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A148subCatDsc = T000Q9_A148subCatDsc[0];
         n148subCatDsc = T000Q9_n148subCatDsc[0];
         pr_default.close(7);
      }

      protected void CloseExtendedTableCursors0Q39( )
      {
         pr_default.close(4);
         pr_default.close(8);
         pr_default.close(6);
         pr_default.close(7);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_29( short A1EmpID )
      {
         /* Using cursor T000Q12 */
         pr_default.execute(10, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000Q12_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000Q12_n44empdsc[0];
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

      protected void gxLoad_30( short A1EmpID ,
                                short A36detTipoProdID )
      {
         /* Using cursor T000Q7 */
         pr_default.execute(5, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void gxLoad_31( short A1EmpID ,
                                short A32categID )
      {
         /* Using cursor T000Q13 */
         pr_default.execute(11, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A146categDsc = T000Q13_A146categDsc[0];
         n146categDsc = T000Q13_n146categDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A146categDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(11) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(11);
      }

      protected void gxLoad_32( short A1EmpID ,
                                short A32categID ,
                                short A33subCatID )
      {
         /* Using cursor T000Q14 */
         pr_default.execute(12, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A148subCatDsc = T000Q14_A148subCatDsc[0];
         n148subCatDsc = T000Q14_n148subCatDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A148subCatDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(12);
      }

      protected void GetKey0Q39( )
      {
         /* Using cursor T000Q15 */
         pr_default.execute(13, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound39 = 1;
         }
         else
         {
            RcdFound39 = 0;
         }
         pr_default.close(13);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000Q5 */
         pr_default.execute(3, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0Q39( 28) ;
            RcdFound39 = 1;
            A227HistAnio = T000Q5_A227HistAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
            A228HistPeriodo = T000Q5_A228HistPeriodo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
            A173detTipoProdDsc = T000Q5_A173detTipoProdDsc[0];
            A229HistEst = T000Q5_A229HistEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229HistEst", A229HistEst);
            n229HistEst = T000Q5_n229HistEst[0];
            A230HistUltNro = T000Q5_A230HistUltNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
            n230HistUltNro = T000Q5_n230HistUltNro[0];
            A1EmpID = T000Q5_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A36detTipoProdID = T000Q5_A36detTipoProdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
            A32categID = T000Q5_A32categID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
            A33subCatID = T000Q5_A33subCatID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
            O230HistUltNro = A230HistUltNro;
            n230HistUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
            Z1EmpID = A1EmpID;
            Z227HistAnio = A227HistAnio;
            Z228HistPeriodo = A228HistPeriodo;
            Z36detTipoProdID = A36detTipoProdID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            sMode39 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0Q39( ) ;
            if ( AnyError == 1 )
            {
               RcdFound39 = 0;
               InitializeNonKey0Q39( ) ;
            }
            Gx_mode = sMode39;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound39 = 0;
            InitializeNonKey0Q39( ) ;
            sMode39 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode39;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Q39( ) ;
         if ( RcdFound39 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound39 = 0;
         /* Using cursor T000Q16 */
         pr_default.execute(14, new Object[] {A227HistAnio, A228HistPeriodo, A1EmpID, A36detTipoProdID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(14) != 101) )
         {
            while ( (pr_default.getStatus(14) != 101) && ( ( T000Q16_A227HistAnio[0] < A227HistAnio ) || ( T000Q16_A227HistAnio[0] == A227HistAnio ) && ( T000Q16_A228HistPeriodo[0] < A228HistPeriodo ) || ( T000Q16_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q16_A227HistAnio[0] == A227HistAnio ) && ( T000Q16_A1EmpID[0] < A1EmpID ) || ( T000Q16_A1EmpID[0] == A1EmpID ) && ( T000Q16_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q16_A227HistAnio[0] == A227HistAnio ) && ( T000Q16_A36detTipoProdID[0] < A36detTipoProdID ) || ( T000Q16_A36detTipoProdID[0] == A36detTipoProdID ) && ( T000Q16_A1EmpID[0] == A1EmpID ) && ( T000Q16_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q16_A227HistAnio[0] == A227HistAnio ) && ( T000Q16_A32categID[0] < A32categID ) || ( T000Q16_A32categID[0] == A32categID ) && ( T000Q16_A36detTipoProdID[0] == A36detTipoProdID ) && ( T000Q16_A1EmpID[0] == A1EmpID ) && ( T000Q16_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q16_A227HistAnio[0] == A227HistAnio ) && ( T000Q16_A33subCatID[0] < A33subCatID ) ) )
            {
               pr_default.readNext(14);
            }
            if ( (pr_default.getStatus(14) != 101) && ( ( T000Q16_A227HistAnio[0] > A227HistAnio ) || ( T000Q16_A227HistAnio[0] == A227HistAnio ) && ( T000Q16_A228HistPeriodo[0] > A228HistPeriodo ) || ( T000Q16_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q16_A227HistAnio[0] == A227HistAnio ) && ( T000Q16_A1EmpID[0] > A1EmpID ) || ( T000Q16_A1EmpID[0] == A1EmpID ) && ( T000Q16_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q16_A227HistAnio[0] == A227HistAnio ) && ( T000Q16_A36detTipoProdID[0] > A36detTipoProdID ) || ( T000Q16_A36detTipoProdID[0] == A36detTipoProdID ) && ( T000Q16_A1EmpID[0] == A1EmpID ) && ( T000Q16_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q16_A227HistAnio[0] == A227HistAnio ) && ( T000Q16_A32categID[0] > A32categID ) || ( T000Q16_A32categID[0] == A32categID ) && ( T000Q16_A36detTipoProdID[0] == A36detTipoProdID ) && ( T000Q16_A1EmpID[0] == A1EmpID ) && ( T000Q16_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q16_A227HistAnio[0] == A227HistAnio ) && ( T000Q16_A33subCatID[0] > A33subCatID ) ) )
            {
               A227HistAnio = T000Q16_A227HistAnio[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
               A228HistPeriodo = T000Q16_A228HistPeriodo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
               A1EmpID = T000Q16_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A36detTipoProdID = T000Q16_A36detTipoProdID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
               A32categID = T000Q16_A32categID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
               A33subCatID = T000Q16_A33subCatID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
               RcdFound39 = 1;
            }
         }
         pr_default.close(14);
      }

      protected void move_previous( )
      {
         RcdFound39 = 0;
         /* Using cursor T000Q17 */
         pr_default.execute(15, new Object[] {A227HistAnio, A228HistPeriodo, A1EmpID, A36detTipoProdID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(15) != 101) )
         {
            while ( (pr_default.getStatus(15) != 101) && ( ( T000Q17_A227HistAnio[0] > A227HistAnio ) || ( T000Q17_A227HistAnio[0] == A227HistAnio ) && ( T000Q17_A228HistPeriodo[0] > A228HistPeriodo ) || ( T000Q17_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q17_A227HistAnio[0] == A227HistAnio ) && ( T000Q17_A1EmpID[0] > A1EmpID ) || ( T000Q17_A1EmpID[0] == A1EmpID ) && ( T000Q17_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q17_A227HistAnio[0] == A227HistAnio ) && ( T000Q17_A36detTipoProdID[0] > A36detTipoProdID ) || ( T000Q17_A36detTipoProdID[0] == A36detTipoProdID ) && ( T000Q17_A1EmpID[0] == A1EmpID ) && ( T000Q17_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q17_A227HistAnio[0] == A227HistAnio ) && ( T000Q17_A32categID[0] > A32categID ) || ( T000Q17_A32categID[0] == A32categID ) && ( T000Q17_A36detTipoProdID[0] == A36detTipoProdID ) && ( T000Q17_A1EmpID[0] == A1EmpID ) && ( T000Q17_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q17_A227HistAnio[0] == A227HistAnio ) && ( T000Q17_A33subCatID[0] > A33subCatID ) ) )
            {
               pr_default.readNext(15);
            }
            if ( (pr_default.getStatus(15) != 101) && ( ( T000Q17_A227HistAnio[0] < A227HistAnio ) || ( T000Q17_A227HistAnio[0] == A227HistAnio ) && ( T000Q17_A228HistPeriodo[0] < A228HistPeriodo ) || ( T000Q17_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q17_A227HistAnio[0] == A227HistAnio ) && ( T000Q17_A1EmpID[0] < A1EmpID ) || ( T000Q17_A1EmpID[0] == A1EmpID ) && ( T000Q17_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q17_A227HistAnio[0] == A227HistAnio ) && ( T000Q17_A36detTipoProdID[0] < A36detTipoProdID ) || ( T000Q17_A36detTipoProdID[0] == A36detTipoProdID ) && ( T000Q17_A1EmpID[0] == A1EmpID ) && ( T000Q17_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q17_A227HistAnio[0] == A227HistAnio ) && ( T000Q17_A32categID[0] < A32categID ) || ( T000Q17_A32categID[0] == A32categID ) && ( T000Q17_A36detTipoProdID[0] == A36detTipoProdID ) && ( T000Q17_A1EmpID[0] == A1EmpID ) && ( T000Q17_A228HistPeriodo[0] == A228HistPeriodo ) && ( T000Q17_A227HistAnio[0] == A227HistAnio ) && ( T000Q17_A33subCatID[0] < A33subCatID ) ) )
            {
               A227HistAnio = T000Q17_A227HistAnio[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
               A228HistPeriodo = T000Q17_A228HistPeriodo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
               A1EmpID = T000Q17_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A36detTipoProdID = T000Q17_A36detTipoProdID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
               A32categID = T000Q17_A32categID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
               A33subCatID = T000Q17_A33subCatID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
               RcdFound39 = 1;
            }
         }
         pr_default.close(15);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0Q39( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A230HistUltNro = O230HistUltNro;
            n230HistUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0Q39( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound39 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A227HistAnio != Z227HistAnio ) || ( A228HistPeriodo != Z228HistPeriodo ) || ( A36detTipoProdID != Z36detTipoProdID ) || ( A32categID != Z32categID ) || ( A33subCatID != Z33subCatID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A227HistAnio = Z227HistAnio;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
                  A228HistPeriodo = Z228HistPeriodo;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
                  A36detTipoProdID = Z36detTipoProdID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
                  A32categID = Z32categID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
                  A33subCatID = Z33subCatID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A230HistUltNro = O230HistUltNro;
                  n230HistUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A230HistUltNro = O230HistUltNro;
                  n230HistUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
                  Update0Q39( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A227HistAnio != Z227HistAnio ) || ( A228HistPeriodo != Z228HistPeriodo ) || ( A36detTipoProdID != Z36detTipoProdID ) || ( A32categID != Z32categID ) || ( A33subCatID != Z33subCatID ) )
               {
                  /* Insert record */
                  A230HistUltNro = O230HistUltNro;
                  n230HistUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0Q39( ) ;
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
                     A230HistUltNro = O230HistUltNro;
                     n230HistUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0Q39( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A227HistAnio != Z227HistAnio ) || ( A228HistPeriodo != Z228HistPeriodo ) || ( A36detTipoProdID != Z36detTipoProdID ) || ( A32categID != Z32categID ) || ( A33subCatID != Z33subCatID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A227HistAnio = Z227HistAnio;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
            A228HistPeriodo = Z228HistPeriodo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
            A36detTipoProdID = Z36detTipoProdID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
            A32categID = Z32categID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
            A33subCatID = Z33subCatID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A230HistUltNro = O230HistUltNro;
            n230HistUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0Q39( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Q4 */
            pr_default.execute(2, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"HistPrecioProd"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z173detTipoProdDsc, T000Q4_A173detTipoProdDsc[0]) != 0 ) || ( StringUtil.StrCmp(Z229HistEst, T000Q4_A229HistEst[0]) != 0 ) || ( Z230HistUltNro != T000Q4_A230HistUltNro[0] ) )
            {
               if ( StringUtil.StrCmp(Z173detTipoProdDsc, T000Q4_A173detTipoProdDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("histprecioprod:[seudo value changed for attri]"+"detTipoProdDsc");
                  GXUtil.WriteLogRaw("Old: ",Z173detTipoProdDsc);
                  GXUtil.WriteLogRaw("Current: ",T000Q4_A173detTipoProdDsc[0]);
               }
               if ( StringUtil.StrCmp(Z229HistEst, T000Q4_A229HistEst[0]) != 0 )
               {
                  GXUtil.WriteLog("histprecioprod:[seudo value changed for attri]"+"HistEst");
                  GXUtil.WriteLogRaw("Old: ",Z229HistEst);
                  GXUtil.WriteLogRaw("Current: ",T000Q4_A229HistEst[0]);
               }
               if ( Z230HistUltNro != T000Q4_A230HistUltNro[0] )
               {
                  GXUtil.WriteLog("histprecioprod:[seudo value changed for attri]"+"HistUltNro");
                  GXUtil.WriteLogRaw("Old: ",Z230HistUltNro);
                  GXUtil.WriteLogRaw("Current: ",T000Q4_A230HistUltNro[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"HistPrecioProd"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0Q39( )
      {
         BeforeValidate0Q39( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Q39( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Q39( 0) ;
            CheckOptimisticConcurrency0Q39( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Q39( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Q39( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Q18 */
                     pr_default.execute(16, new Object[] {A227HistAnio, A228HistPeriodo, A173detTipoProdDsc, n229HistEst, A229HistEst, n230HistUltNro, A230HistUltNro, A1EmpID, A36detTipoProdID, A32categID, A33subCatID});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("HistPrecioProd") ;
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
                           ProcessLevel0Q39( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0Q0( ) ;
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
               Load0Q39( ) ;
            }
            EndLevel0Q39( ) ;
         }
         CloseExtendedTableCursors0Q39( ) ;
      }

      protected void Update0Q39( )
      {
         BeforeValidate0Q39( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Q39( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Q39( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Q39( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Q39( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Q19 */
                     pr_default.execute(17, new Object[] {A173detTipoProdDsc, n229HistEst, A229HistEst, n230HistUltNro, A230HistUltNro, A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("HistPrecioProd") ;
                     if ( (pr_default.getStatus(17) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"HistPrecioProd"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0Q39( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0Q39( ) ;
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
            EndLevel0Q39( ) ;
         }
         CloseExtendedTableCursors0Q39( ) ;
      }

      protected void DeferredUpdate0Q39( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0Q39( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Q39( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Q39( ) ;
            AfterConfirm0Q39( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Q39( ) ;
               if ( AnyError == 0 )
               {
                  A230HistUltNro = O230HistUltNro;
                  n230HistUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
                  ScanStart0Q40( ) ;
                  while ( RcdFound40 != 0 )
                  {
                     getByPrimaryKey0Q40( ) ;
                     Delete0Q40( ) ;
                     ScanNext0Q40( ) ;
                     O230HistUltNro = A230HistUltNro;
                     n230HistUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
                  }
                  ScanEnd0Q40( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Q20 */
                     pr_default.execute(18, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID});
                     pr_default.close(18);
                     dsDefault.SmartCacheProvider.SetUpdated("HistPrecioProd") ;
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
         sMode39 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0Q39( ) ;
         Gx_mode = sMode39;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0Q39( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV21Pgmname = "HistPrecioProd";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Pgmname", AV21Pgmname);
            /* Using cursor T000Q21 */
            pr_default.execute(19, new Object[] {A1EmpID});
            A44empdsc = T000Q21_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000Q21_n44empdsc[0];
            pr_default.close(19);
            GXACATEGID_html0Q39( A1EmpID, A36detTipoProdID) ;
            /* Using cursor T000Q22 */
            pr_default.execute(20, new Object[] {A1EmpID, A32categID});
            A146categDsc = T000Q22_A146categDsc[0];
            n146categDsc = T000Q22_n146categDsc[0];
            pr_default.close(20);
            GXASUBCATID_html0Q39( A1EmpID, A32categID) ;
            /* Using cursor T000Q23 */
            pr_default.execute(21, new Object[] {A1EmpID, A32categID, A33subCatID});
            A148subCatDsc = T000Q23_A148subCatDsc[0];
            n148subCatDsc = T000Q23_n148subCatDsc[0];
            pr_default.close(21);
         }
      }

      protected void ProcessNestedLevel0Q40( )
      {
         s230HistUltNro = O230HistUltNro;
         n230HistUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
         nGXsfl_83_idx = 0;
         while ( nGXsfl_83_idx < nRC_GXsfl_83 )
         {
            ReadRow0Q40( ) ;
            if ( ( nRcdExists_40 != 0 ) || ( nIsMod_40 != 0 ) )
            {
               standaloneNotModal0Q40( ) ;
               GetKey0Q40( ) ;
               if ( ( nRcdExists_40 == 0 ) && ( nRcdDeleted_40 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0Q40( ) ;
               }
               else
               {
                  if ( RcdFound40 != 0 )
                  {
                     if ( ( nRcdDeleted_40 != 0 ) && ( nRcdExists_40 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0Q40( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_40 != 0 ) && ( nRcdExists_40 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0Q40( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_40 == 0 )
                     {
                        GXCCtl = "DETHISTNRO_" + sGXsfl_83_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtDetHistNro_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O230HistUltNro = A230HistUltNro;
               n230HistUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
            }
            ChangePostValue( edtDetHistNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A231DetHistNro), 8, 0, ",", ""))) ;
            ChangePostValue( edtDetHistFcha_Internalname, context.localUtil.Format(A232DetHistFcha, "99/99/9999")) ;
            ChangePostValue( edtDetHistPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A233DetHistPrecio, 8, 2, ",", ""))) ;
            ChangePostValue( chkDetHistAct_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A237DetHistAct), 1, 0, ",", ""))) ;
            ChangePostValue( edtDetHistFchaApli_Internalname, context.localUtil.Format(A234DetHistFchaApli, "99/99/9999")) ;
            ChangePostValue( edtDetHistObs_Internalname, StringUtil.RTrim( A235DetHistObs)) ;
            ChangePostValue( edtDetHistMotivo_Internalname, StringUtil.RTrim( A236DetHistMotivo)) ;
            ChangePostValue( "ZT_"+"Z231DetHistNro_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z231DetHistNro), 8, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z232DetHistFcha_"+sGXsfl_83_idx, context.localUtil.DToC( Z232DetHistFcha, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z233DetHistPrecio_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( Z233DetHistPrecio, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z234DetHistFchaApli_"+sGXsfl_83_idx, context.localUtil.DToC( Z234DetHistFchaApli, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z235DetHistObs_"+sGXsfl_83_idx, StringUtil.RTrim( Z235DetHistObs)) ;
            ChangePostValue( "ZT_"+"Z236DetHistMotivo_"+sGXsfl_83_idx, StringUtil.RTrim( Z236DetHistMotivo)) ;
            ChangePostValue( "ZT_"+"Z237DetHistAct_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z237DetHistAct), 1, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_40_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_40), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_40_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_40), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_40_"+sGXsfl_83_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_40), 4, 0, ",", ""))) ;
            if ( nIsMod_40 != 0 )
            {
               ChangePostValue( "DETHISTNRO_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistNro_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTFCHA_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistFcha_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTPRECIO_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistPrecio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTACT_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkDetHistAct.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTFCHAAPLI_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistFchaApli_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTOBS_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistObs_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETHISTMOTIVO_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistMotivo_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0Q40( ) ;
         if ( AnyError != 0 )
         {
            O230HistUltNro = s230HistUltNro;
            n230HistUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
         }
         nRcdExists_40 = 0;
         nIsMod_40 = 0;
         nRcdDeleted_40 = 0;
      }

      protected void ProcessLevel0Q39( )
      {
         /* Save parent mode. */
         sMode39 = Gx_mode;
         ProcessNestedLevel0Q40( ) ;
         if ( AnyError != 0 )
         {
            O230HistUltNro = s230HistUltNro;
            n230HistUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode39;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T000Q24 */
         pr_default.execute(22, new Object[] {n230HistUltNro, A230HistUltNro, A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID});
         pr_default.close(22);
         dsDefault.SmartCacheProvider.SetUpdated("HistPrecioProd") ;
      }

      protected void EndLevel0Q39( )
      {
         pr_default.close(2);
         if ( AnyError == 0 )
         {
            BeforeComplete0Q39( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(19);
            pr_default.close(20);
            pr_default.close(21);
            context.CommitDataStores("histprecioprod",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0Q0( ) ;
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
            pr_default.close(19);
            pr_default.close(20);
            pr_default.close(21);
            context.RollbackDataStores("histprecioprod",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0Q39( )
      {
         /* Scan By routine */
         /* Using cursor T000Q25 */
         pr_default.execute(23);
         RcdFound39 = 0;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound39 = 1;
            A1EmpID = T000Q25_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A227HistAnio = T000Q25_A227HistAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
            A228HistPeriodo = T000Q25_A228HistPeriodo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
            A36detTipoProdID = T000Q25_A36detTipoProdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
            A32categID = T000Q25_A32categID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
            A33subCatID = T000Q25_A33subCatID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Q39( )
      {
         /* Scan next routine */
         pr_default.readNext(23);
         RcdFound39 = 0;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound39 = 1;
            A1EmpID = T000Q25_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A227HistAnio = T000Q25_A227HistAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
            A228HistPeriodo = T000Q25_A228HistPeriodo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
            A36detTipoProdID = T000Q25_A36detTipoProdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
            A32categID = T000Q25_A32categID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
            A33subCatID = T000Q25_A33subCatID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
         }
      }

      protected void ScanEnd0Q39( )
      {
         pr_default.close(23);
      }

      protected void AfterConfirm0Q39( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Q39( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0Q39( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0Q39( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Q39( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Q39( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Q39( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtHistAnio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistAnio_Enabled), 5, 0)), true);
         cmbHistPeriodo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbHistPeriodo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbHistPeriodo.Enabled), 5, 0)), true);
         dyndetTipoProdID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyndetTipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyndetTipoProdID.Enabled), 5, 0)), true);
         dyncategID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyncategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyncategID.Enabled), 5, 0)), true);
         dynsubCatID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynsubCatID.Enabled), 5, 0)), true);
         chkHistEst.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkHistEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkHistEst.Enabled), 5, 0)), true);
         edtHistUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistUltNro_Enabled), 5, 0)), true);
      }

      protected void ZM0Q40( short GX_JID )
      {
         if ( ( GX_JID == 34 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z232DetHistFcha = T000Q3_A232DetHistFcha[0];
               Z233DetHistPrecio = T000Q3_A233DetHistPrecio[0];
               Z234DetHistFchaApli = T000Q3_A234DetHistFchaApli[0];
               Z235DetHistObs = T000Q3_A235DetHistObs[0];
               Z236DetHistMotivo = T000Q3_A236DetHistMotivo[0];
               Z237DetHistAct = T000Q3_A237DetHistAct[0];
            }
            else
            {
               Z232DetHistFcha = A232DetHistFcha;
               Z233DetHistPrecio = A233DetHistPrecio;
               Z234DetHistFchaApli = A234DetHistFchaApli;
               Z235DetHistObs = A235DetHistObs;
               Z236DetHistMotivo = A236DetHistMotivo;
               Z237DetHistAct = A237DetHistAct;
            }
         }
         if ( GX_JID == -34 )
         {
            Z1EmpID = A1EmpID;
            Z227HistAnio = A227HistAnio;
            Z228HistPeriodo = A228HistPeriodo;
            Z36detTipoProdID = A36detTipoProdID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            Z231DetHistNro = A231DetHistNro;
            Z232DetHistFcha = A232DetHistFcha;
            Z233DetHistPrecio = A233DetHistPrecio;
            Z234DetHistFchaApli = A234DetHistFchaApli;
            Z235DetHistObs = A235DetHistObs;
            Z236DetHistMotivo = A236DetHistMotivo;
            Z237DetHistAct = A237DetHistAct;
         }
      }

      protected void standaloneNotModal0Q40( )
      {
         edtHistUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistUltNro_Enabled), 5, 0)), true);
         edtHistUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHistUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHistUltNro_Enabled), 5, 0)), true);
      }

      protected void standaloneModal0Q40( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A230HistUltNro = (int)(O230HistUltNro+1);
            n230HistUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A231DetHistNro = A230HistUltNro;
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtDetHistNro_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistNro_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
         }
         else
         {
            edtDetHistNro_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistNro_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
         }
      }

      protected void Load0Q40( )
      {
         /* Using cursor T000Q26 */
         pr_default.execute(24, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID, A231DetHistNro});
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound40 = 1;
            A232DetHistFcha = T000Q26_A232DetHistFcha[0];
            n232DetHistFcha = T000Q26_n232DetHistFcha[0];
            A233DetHistPrecio = T000Q26_A233DetHistPrecio[0];
            n233DetHistPrecio = T000Q26_n233DetHistPrecio[0];
            A234DetHistFchaApli = T000Q26_A234DetHistFchaApli[0];
            n234DetHistFchaApli = T000Q26_n234DetHistFchaApli[0];
            A235DetHistObs = T000Q26_A235DetHistObs[0];
            n235DetHistObs = T000Q26_n235DetHistObs[0];
            A236DetHistMotivo = T000Q26_A236DetHistMotivo[0];
            n236DetHistMotivo = T000Q26_n236DetHistMotivo[0];
            A237DetHistAct = T000Q26_A237DetHistAct[0];
            n237DetHistAct = T000Q26_n237DetHistAct[0];
            ZM0Q40( -34) ;
         }
         pr_default.close(24);
         OnLoadActions0Q40( ) ;
      }

      protected void OnLoadActions0Q40( )
      {
      }

      protected void CheckExtendedTable0Q40( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0Q40( ) ;
         if ( ! ( (DateTime.MinValue==A232DetHistFcha) || ( A232DetHistFcha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXCCtl = "DETHISTFCHA_" + sGXsfl_83_idx;
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtDetHistFcha_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A234DetHistFchaApli) || ( A234DetHistFchaApli >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXCCtl = "DETHISTFCHAAPLI_" + sGXsfl_83_idx;
            GX_msglist.addItem("Campo Fecha Aplica fuera de rango", "OutOfRange", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtDetHistFchaApli_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0Q40( )
      {
      }

      protected void enableDisable0Q40( )
      {
      }

      protected void GetKey0Q40( )
      {
         /* Using cursor T000Q27 */
         pr_default.execute(25, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID, A231DetHistNro});
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound40 = 1;
         }
         else
         {
            RcdFound40 = 0;
         }
         pr_default.close(25);
      }

      protected void getByPrimaryKey0Q40( )
      {
         /* Using cursor T000Q3 */
         pr_default.execute(1, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID, A231DetHistNro});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Q40( 34) ;
            RcdFound40 = 1;
            InitializeNonKey0Q40( ) ;
            A231DetHistNro = T000Q3_A231DetHistNro[0];
            A232DetHistFcha = T000Q3_A232DetHistFcha[0];
            n232DetHistFcha = T000Q3_n232DetHistFcha[0];
            A233DetHistPrecio = T000Q3_A233DetHistPrecio[0];
            n233DetHistPrecio = T000Q3_n233DetHistPrecio[0];
            A234DetHistFchaApli = T000Q3_A234DetHistFchaApli[0];
            n234DetHistFchaApli = T000Q3_n234DetHistFchaApli[0];
            A235DetHistObs = T000Q3_A235DetHistObs[0];
            n235DetHistObs = T000Q3_n235DetHistObs[0];
            A236DetHistMotivo = T000Q3_A236DetHistMotivo[0];
            n236DetHistMotivo = T000Q3_n236DetHistMotivo[0];
            A237DetHistAct = T000Q3_A237DetHistAct[0];
            n237DetHistAct = T000Q3_n237DetHistAct[0];
            Z1EmpID = A1EmpID;
            Z227HistAnio = A227HistAnio;
            Z228HistPeriodo = A228HistPeriodo;
            Z36detTipoProdID = A36detTipoProdID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            Z231DetHistNro = A231DetHistNro;
            sMode40 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0Q40( ) ;
            Gx_mode = sMode40;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound40 = 0;
            InitializeNonKey0Q40( ) ;
            sMode40 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0Q40( ) ;
            Gx_mode = sMode40;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0Q40( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0Q40( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Q2 */
            pr_default.execute(0, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID, A231DetHistNro});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"HistPrecioProdLevel1"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z232DetHistFcha != T000Q2_A232DetHistFcha[0] ) || ( Z233DetHistPrecio != T000Q2_A233DetHistPrecio[0] ) || ( Z234DetHistFchaApli != T000Q2_A234DetHistFchaApli[0] ) || ( StringUtil.StrCmp(Z235DetHistObs, T000Q2_A235DetHistObs[0]) != 0 ) || ( StringUtil.StrCmp(Z236DetHistMotivo, T000Q2_A236DetHistMotivo[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z237DetHistAct != T000Q2_A237DetHistAct[0] ) )
            {
               if ( Z232DetHistFcha != T000Q2_A232DetHistFcha[0] )
               {
                  GXUtil.WriteLog("histprecioprod:[seudo value changed for attri]"+"DetHistFcha");
                  GXUtil.WriteLogRaw("Old: ",Z232DetHistFcha);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A232DetHistFcha[0]);
               }
               if ( Z233DetHistPrecio != T000Q2_A233DetHistPrecio[0] )
               {
                  GXUtil.WriteLog("histprecioprod:[seudo value changed for attri]"+"DetHistPrecio");
                  GXUtil.WriteLogRaw("Old: ",Z233DetHistPrecio);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A233DetHistPrecio[0]);
               }
               if ( Z234DetHistFchaApli != T000Q2_A234DetHistFchaApli[0] )
               {
                  GXUtil.WriteLog("histprecioprod:[seudo value changed for attri]"+"DetHistFchaApli");
                  GXUtil.WriteLogRaw("Old: ",Z234DetHistFchaApli);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A234DetHistFchaApli[0]);
               }
               if ( StringUtil.StrCmp(Z235DetHistObs, T000Q2_A235DetHistObs[0]) != 0 )
               {
                  GXUtil.WriteLog("histprecioprod:[seudo value changed for attri]"+"DetHistObs");
                  GXUtil.WriteLogRaw("Old: ",Z235DetHistObs);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A235DetHistObs[0]);
               }
               if ( StringUtil.StrCmp(Z236DetHistMotivo, T000Q2_A236DetHistMotivo[0]) != 0 )
               {
                  GXUtil.WriteLog("histprecioprod:[seudo value changed for attri]"+"DetHistMotivo");
                  GXUtil.WriteLogRaw("Old: ",Z236DetHistMotivo);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A236DetHistMotivo[0]);
               }
               if ( Z237DetHistAct != T000Q2_A237DetHistAct[0] )
               {
                  GXUtil.WriteLog("histprecioprod:[seudo value changed for attri]"+"DetHistAct");
                  GXUtil.WriteLogRaw("Old: ",Z237DetHistAct);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A237DetHistAct[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"HistPrecioProdLevel1"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0Q40( )
      {
         BeforeValidate0Q40( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Q40( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Q40( 0) ;
            CheckOptimisticConcurrency0Q40( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Q40( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Q40( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Q28 */
                     pr_default.execute(26, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID, A231DetHistNro, n232DetHistFcha, A232DetHistFcha, n233DetHistPrecio, A233DetHistPrecio, n234DetHistFchaApli, A234DetHistFchaApli, n235DetHistObs, A235DetHistObs, n236DetHistMotivo, A236DetHistMotivo, n237DetHistAct, A237DetHistAct});
                     pr_default.close(26);
                     dsDefault.SmartCacheProvider.SetUpdated("HistPrecioProdLevel1") ;
                     if ( (pr_default.getStatus(26) == 1) )
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
               Load0Q40( ) ;
            }
            EndLevel0Q40( ) ;
         }
         CloseExtendedTableCursors0Q40( ) ;
      }

      protected void Update0Q40( )
      {
         BeforeValidate0Q40( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Q40( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Q40( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Q40( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Q40( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Q29 */
                     pr_default.execute(27, new Object[] {n232DetHistFcha, A232DetHistFcha, n233DetHistPrecio, A233DetHistPrecio, n234DetHistFchaApli, A234DetHistFchaApli, n235DetHistObs, A235DetHistObs, n236DetHistMotivo, A236DetHistMotivo, n237DetHistAct, A237DetHistAct, A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID, A231DetHistNro});
                     pr_default.close(27);
                     dsDefault.SmartCacheProvider.SetUpdated("HistPrecioProdLevel1") ;
                     if ( (pr_default.getStatus(27) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"HistPrecioProdLevel1"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0Q40( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0Q40( ) ;
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
            EndLevel0Q40( ) ;
         }
         CloseExtendedTableCursors0Q40( ) ;
      }

      protected void DeferredUpdate0Q40( )
      {
      }

      protected void Delete0Q40( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0Q40( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Q40( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Q40( ) ;
            AfterConfirm0Q40( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Q40( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000Q30 */
                  pr_default.execute(28, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID, A231DetHistNro});
                  pr_default.close(28);
                  dsDefault.SmartCacheProvider.SetUpdated("HistPrecioProdLevel1") ;
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
         sMode40 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0Q40( ) ;
         Gx_mode = sMode40;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0Q40( )
      {
         standaloneModal0Q40( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0Q40( )
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

      public void ScanStart0Q40( )
      {
         /* Scan By routine */
         /* Using cursor T000Q31 */
         pr_default.execute(29, new Object[] {A1EmpID, A227HistAnio, A228HistPeriodo, A36detTipoProdID, A32categID, A33subCatID});
         RcdFound40 = 0;
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound40 = 1;
            A231DetHistNro = T000Q31_A231DetHistNro[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Q40( )
      {
         /* Scan next routine */
         pr_default.readNext(29);
         RcdFound40 = 0;
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound40 = 1;
            A231DetHistNro = T000Q31_A231DetHistNro[0];
         }
      }

      protected void ScanEnd0Q40( )
      {
         pr_default.close(29);
      }

      protected void AfterConfirm0Q40( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Q40( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0Q40( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0Q40( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Q40( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Q40( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Q40( )
      {
         edtDetHistNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistNro_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
         edtDetHistFcha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistFcha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistFcha_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
         edtDetHistPrecio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistPrecio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistPrecio_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
         chkDetHistAct.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDetHistAct_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkDetHistAct.Enabled), 5, 0)), !bGXsfl_83_Refreshing);
         edtDetHistFchaApli_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistFchaApli_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistFchaApli_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
         edtDetHistObs_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistObs_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
         edtDetHistMotivo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistMotivo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistMotivo_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
      }

      protected void send_integrity_lvl_hashes0Q40( )
      {
      }

      protected void send_integrity_lvl_hashes0Q39( )
      {
      }

      protected void SubsflControlProps_8340( )
      {
         edtDetHistNro_Internalname = "DETHISTNRO_"+sGXsfl_83_idx;
         edtDetHistFcha_Internalname = "DETHISTFCHA_"+sGXsfl_83_idx;
         edtDetHistPrecio_Internalname = "DETHISTPRECIO_"+sGXsfl_83_idx;
         chkDetHistAct_Internalname = "DETHISTACT_"+sGXsfl_83_idx;
         edtDetHistFchaApli_Internalname = "DETHISTFCHAAPLI_"+sGXsfl_83_idx;
         edtDetHistObs_Internalname = "DETHISTOBS_"+sGXsfl_83_idx;
         edtDetHistMotivo_Internalname = "DETHISTMOTIVO_"+sGXsfl_83_idx;
      }

      protected void SubsflControlProps_fel_8340( )
      {
         edtDetHistNro_Internalname = "DETHISTNRO_"+sGXsfl_83_fel_idx;
         edtDetHistFcha_Internalname = "DETHISTFCHA_"+sGXsfl_83_fel_idx;
         edtDetHistPrecio_Internalname = "DETHISTPRECIO_"+sGXsfl_83_fel_idx;
         chkDetHistAct_Internalname = "DETHISTACT_"+sGXsfl_83_fel_idx;
         edtDetHistFchaApli_Internalname = "DETHISTFCHAAPLI_"+sGXsfl_83_fel_idx;
         edtDetHistObs_Internalname = "DETHISTOBS_"+sGXsfl_83_fel_idx;
         edtDetHistMotivo_Internalname = "DETHISTMOTIVO_"+sGXsfl_83_fel_idx;
      }

      protected void AddRow0Q40( )
      {
         nGXsfl_83_idx = (short)(nGXsfl_83_idx+1);
         sGXsfl_83_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_83_idx), 4, 0)), 4, "0");
         SubsflControlProps_8340( ) ;
         SendRow0Q40( ) ;
      }

      protected void SendRow0Q40( )
      {
         Gridhistprecioprod_level1Row = GXWebRow.GetNew(context);
         if ( subGridhistprecioprod_level1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridhistprecioprod_level1_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridhistprecioprod_level1_Class, "") != 0 )
            {
               subGridhistprecioprod_level1_Linesclass = subGridhistprecioprod_level1_Class+"Odd";
            }
         }
         else if ( subGridhistprecioprod_level1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridhistprecioprod_level1_Backstyle = 0;
            subGridhistprecioprod_level1_Backcolor = subGridhistprecioprod_level1_Allbackcolor;
            if ( StringUtil.StrCmp(subGridhistprecioprod_level1_Class, "") != 0 )
            {
               subGridhistprecioprod_level1_Linesclass = subGridhistprecioprod_level1_Class+"Uniform";
            }
         }
         else if ( subGridhistprecioprod_level1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridhistprecioprod_level1_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridhistprecioprod_level1_Class, "") != 0 )
            {
               subGridhistprecioprod_level1_Linesclass = subGridhistprecioprod_level1_Class+"Odd";
            }
            subGridhistprecioprod_level1_Backcolor = (int)(0x0);
         }
         else if ( subGridhistprecioprod_level1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridhistprecioprod_level1_Backstyle = 1;
            if ( ((int)(((nGXsfl_83_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridhistprecioprod_level1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridhistprecioprod_level1_Class, "") != 0 )
               {
                  subGridhistprecioprod_level1_Linesclass = subGridhistprecioprod_level1_Class+"Odd";
               }
            }
            else
            {
               subGridhistprecioprod_level1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridhistprecioprod_level1_Class, "") != 0 )
               {
                  subGridhistprecioprod_level1_Linesclass = subGridhistprecioprod_level1_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_40_" + sGXsfl_83_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 84,'',false,'" + sGXsfl_83_idx + "',83)\"";
         ROClassString = "ReadonlyActionAttribute";
         Gridhistprecioprod_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDetHistNro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A231DetHistNro), 8, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A231DetHistNro), "ZZZZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDetHistNro_Jsonclick,(short)0,(String)"ReadonlyActionAttribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDetHistNro_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)83,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_40_" + sGXsfl_83_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 85,'',false,'" + sGXsfl_83_idx + "',83)\"";
         ROClassString = "Attribute";
         Gridhistprecioprod_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDetHistFcha_Internalname,context.localUtil.Format(A232DetHistFcha, "99/99/9999"),context.localUtil.Format( A232DetHistFcha, "99/99/9999"),TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDetHistFcha_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDetHistFcha_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)83,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_40_" + sGXsfl_83_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 86,'',false,'" + sGXsfl_83_idx + "',83)\"";
         ROClassString = "Attribute";
         Gridhistprecioprod_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDetHistPrecio_Internalname,StringUtil.LTrim( StringUtil.NToC( A233DetHistPrecio, 8, 2, ",", "")),((edtDetHistPrecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A233DetHistPrecio, "ZZZZ9.99")) : context.localUtil.Format( A233DetHistPrecio, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDetHistPrecio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDetHistPrecio_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)83,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Check box */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_40_" + sGXsfl_83_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 87,'',false,'" + sGXsfl_83_idx + "',83)\"";
         ClassString = "CheckBox";
         StyleString = "";
         Gridhistprecioprod_level1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkDetHistAct_Internalname,StringUtil.Str( (decimal)(A237DetHistAct), 1, 0),(String)"",(String)"",(short)-1,chkDetHistAct.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(87, this, 1, 0);gx.evt.onchange(this, event);\" "});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_40_" + sGXsfl_83_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 88,'',false,'" + sGXsfl_83_idx + "',83)\"";
         ROClassString = "Attribute";
         Gridhistprecioprod_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDetHistFchaApli_Internalname,context.localUtil.Format(A234DetHistFchaApli, "99/99/9999"),context.localUtil.Format( A234DetHistFchaApli, "99/99/9999"),TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDetHistFchaApli_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDetHistFchaApli_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)83,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_40_" + sGXsfl_83_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 89,'',false,'" + sGXsfl_83_idx + "',83)\"";
         ROClassString = "Attribute";
         Gridhistprecioprod_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDetHistObs_Internalname,StringUtil.RTrim( A235DetHistObs),StringUtil.RTrim( context.localUtil.Format( A235DetHistObs, "@!")),TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDetHistObs_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDetHistObs_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)83,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_40_" + sGXsfl_83_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 90,'',false,'" + sGXsfl_83_idx + "',83)\"";
         ROClassString = "Attribute";
         Gridhistprecioprod_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDetHistMotivo_Internalname,StringUtil.RTrim( A236DetHistMotivo),StringUtil.RTrim( context.localUtil.Format( A236DetHistMotivo, "@!")),TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,90);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtDetHistMotivo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtDetHistMotivo_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)83,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridhistprecioprod_level1Row);
         send_integrity_lvl_hashes0Q40( ) ;
         GXCCtl = "Z231DetHistNro_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z231DetHistNro), 8, 0, ",", "")));
         GXCCtl = "Z232DetHistFcha_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z232DetHistFcha, 0, "/"));
         GXCCtl = "Z233DetHistPrecio_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z233DetHistPrecio, 8, 2, ",", "")));
         GXCCtl = "Z234DetHistFchaApli_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z234DetHistFchaApli, 0, "/"));
         GXCCtl = "Z235DetHistObs_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z235DetHistObs));
         GXCCtl = "Z236DetHistMotivo_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z236DetHistMotivo));
         GXCCtl = "Z237DetHistAct_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z237DetHistAct), 1, 0, ",", "")));
         GXCCtl = "nRcdDeleted_40_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_40), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_40_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_40), 4, 0, ",", "")));
         GXCCtl = "nIsMod_40_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_40), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_83_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV13TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV13TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GXCCtl = "vHISTANIO_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8HistAnio), 4, 0, ",", "")));
         GXCCtl = "vHISTPERIODO_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9HistPeriodo), 2, 0, ",", "")));
         GXCCtl = "vDETTIPOPRODID_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10detTipoProdID), 4, 0, ",", "")));
         GXCCtl = "vCATEGID_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11categID), 4, 0, ",", "")));
         GXCCtl = "vSUBCATID_" + sGXsfl_83_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19subCatID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "DETHISTNRO_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistNro_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETHISTFCHA_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistFcha_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETHISTPRECIO_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistPrecio_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETHISTACT_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkDetHistAct.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETHISTFCHAAPLI_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistFchaApli_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETHISTOBS_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistObs_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETHISTMOTIVO_"+sGXsfl_83_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDetHistMotivo_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridhistprecioprod_level1Container.AddRow(Gridhistprecioprod_level1Row);
      }

      protected void ReadRow0Q40( )
      {
         nGXsfl_83_idx = (short)(nGXsfl_83_idx+1);
         sGXsfl_83_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_83_idx), 4, 0)), 4, "0");
         SubsflControlProps_8340( ) ;
         edtDetHistNro_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTNRO_"+sGXsfl_83_idx+"Enabled"), ",", "."));
         edtDetHistFcha_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTFCHA_"+sGXsfl_83_idx+"Enabled"), ",", "."));
         edtDetHistPrecio_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTPRECIO_"+sGXsfl_83_idx+"Enabled"), ",", "."));
         chkDetHistAct.Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTACT_"+sGXsfl_83_idx+"Enabled"), ",", "."));
         edtDetHistFchaApli_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTFCHAAPLI_"+sGXsfl_83_idx+"Enabled"), ",", "."));
         edtDetHistObs_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTOBS_"+sGXsfl_83_idx+"Enabled"), ",", "."));
         edtDetHistMotivo_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETHISTMOTIVO_"+sGXsfl_83_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtDetHistNro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDetHistNro_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
         {
            GXCCtl = "DETHISTNRO_" + sGXsfl_83_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtDetHistNro_Internalname;
            wbErr = true;
            A231DetHistNro = 0;
         }
         else
         {
            A231DetHistNro = (int)(context.localUtil.CToN( cgiGet( edtDetHistNro_Internalname), ",", "."));
         }
         if ( context.localUtil.VCDate( cgiGet( edtDetHistFcha_Internalname), 2) == 0 )
         {
            GXCCtl = "DETHISTFCHA_" + sGXsfl_83_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtDetHistFcha_Internalname;
            wbErr = true;
            A232DetHistFcha = DateTime.MinValue;
            n232DetHistFcha = false;
         }
         else
         {
            A232DetHistFcha = context.localUtil.CToD( cgiGet( edtDetHistFcha_Internalname), 2);
            n232DetHistFcha = false;
         }
         n232DetHistFcha = ((DateTime.MinValue==A232DetHistFcha) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtDetHistPrecio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDetHistPrecio_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "DETHISTPRECIO_" + sGXsfl_83_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtDetHistPrecio_Internalname;
            wbErr = true;
            A233DetHistPrecio = 0;
            n233DetHistPrecio = false;
         }
         else
         {
            A233DetHistPrecio = context.localUtil.CToN( cgiGet( edtDetHistPrecio_Internalname), ",", ".");
            n233DetHistPrecio = false;
         }
         n233DetHistPrecio = ((Convert.ToDecimal(0)==A233DetHistPrecio) ? true : false);
         if ( ( ( ((StringUtil.StrCmp(cgiGet( chkDetHistAct_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkDetHistAct_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
         {
            GXCCtl = "DETHISTACT_" + sGXsfl_83_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = chkDetHistAct_Internalname;
            wbErr = true;
            A237DetHistAct = 0;
            n237DetHistAct = false;
         }
         else
         {
            A237DetHistAct = (short)(((StringUtil.StrCmp(cgiGet( chkDetHistAct_Internalname), "1")==0) ? 1 : 0));
            n237DetHistAct = false;
         }
         n237DetHistAct = ((0==A237DetHistAct) ? true : false);
         if ( context.localUtil.VCDate( cgiGet( edtDetHistFchaApli_Internalname), 2) == 0 )
         {
            GXCCtl = "DETHISTFCHAAPLI_" + sGXsfl_83_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha Aplica"}), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtDetHistFchaApli_Internalname;
            wbErr = true;
            A234DetHistFchaApli = DateTime.MinValue;
            n234DetHistFchaApli = false;
         }
         else
         {
            A234DetHistFchaApli = context.localUtil.CToD( cgiGet( edtDetHistFchaApli_Internalname), 2);
            n234DetHistFchaApli = false;
         }
         n234DetHistFchaApli = ((DateTime.MinValue==A234DetHistFchaApli) ? true : false);
         A235DetHistObs = StringUtil.Upper( cgiGet( edtDetHistObs_Internalname));
         n235DetHistObs = false;
         n235DetHistObs = (String.IsNullOrEmpty(StringUtil.RTrim( A235DetHistObs)) ? true : false);
         A236DetHistMotivo = StringUtil.Upper( cgiGet( edtDetHistMotivo_Internalname));
         n236DetHistMotivo = false;
         n236DetHistMotivo = (String.IsNullOrEmpty(StringUtil.RTrim( A236DetHistMotivo)) ? true : false);
         GXCCtl = "Z231DetHistNro_" + sGXsfl_83_idx;
         Z231DetHistNro = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z232DetHistFcha_" + sGXsfl_83_idx;
         Z232DetHistFcha = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         n232DetHistFcha = ((DateTime.MinValue==A232DetHistFcha) ? true : false);
         GXCCtl = "Z233DetHistPrecio_" + sGXsfl_83_idx;
         Z233DetHistPrecio = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n233DetHistPrecio = ((Convert.ToDecimal(0)==A233DetHistPrecio) ? true : false);
         GXCCtl = "Z234DetHistFchaApli_" + sGXsfl_83_idx;
         Z234DetHistFchaApli = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         n234DetHistFchaApli = ((DateTime.MinValue==A234DetHistFchaApli) ? true : false);
         GXCCtl = "Z235DetHistObs_" + sGXsfl_83_idx;
         Z235DetHistObs = cgiGet( GXCCtl);
         n235DetHistObs = (String.IsNullOrEmpty(StringUtil.RTrim( A235DetHistObs)) ? true : false);
         GXCCtl = "Z236DetHistMotivo_" + sGXsfl_83_idx;
         Z236DetHistMotivo = cgiGet( GXCCtl);
         n236DetHistMotivo = (String.IsNullOrEmpty(StringUtil.RTrim( A236DetHistMotivo)) ? true : false);
         GXCCtl = "Z237DetHistAct_" + sGXsfl_83_idx;
         Z237DetHistAct = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n237DetHistAct = ((0==A237DetHistAct) ? true : false);
         GXCCtl = "nRcdDeleted_40_" + sGXsfl_83_idx;
         nRcdDeleted_40 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_40_" + sGXsfl_83_idx;
         nRcdExists_40 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_40_" + sGXsfl_83_idx;
         nIsMod_40 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtDetHistNro_Enabled = edtDetHistNro_Enabled;
      }

      protected void ConfirmValues0Q0( )
      {
         nGXsfl_83_idx = 0;
         sGXsfl_83_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_83_idx), 4, 0)), 4, "0");
         SubsflControlProps_8340( ) ;
         while ( nGXsfl_83_idx < nRC_GXsfl_83 )
         {
            nGXsfl_83_idx = (short)(nGXsfl_83_idx+1);
            sGXsfl_83_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_83_idx), 4, 0)), 4, "0");
            SubsflControlProps_8340( ) ;
            ChangePostValue( "Z231DetHistNro_"+sGXsfl_83_idx, cgiGet( "ZT_"+"Z231DetHistNro_"+sGXsfl_83_idx)) ;
            DeletePostValue( "ZT_"+"Z231DetHistNro_"+sGXsfl_83_idx) ;
            ChangePostValue( "Z232DetHistFcha_"+sGXsfl_83_idx, cgiGet( "ZT_"+"Z232DetHistFcha_"+sGXsfl_83_idx)) ;
            DeletePostValue( "ZT_"+"Z232DetHistFcha_"+sGXsfl_83_idx) ;
            ChangePostValue( "Z233DetHistPrecio_"+sGXsfl_83_idx, cgiGet( "ZT_"+"Z233DetHistPrecio_"+sGXsfl_83_idx)) ;
            DeletePostValue( "ZT_"+"Z233DetHistPrecio_"+sGXsfl_83_idx) ;
            ChangePostValue( "Z234DetHistFchaApli_"+sGXsfl_83_idx, cgiGet( "ZT_"+"Z234DetHistFchaApli_"+sGXsfl_83_idx)) ;
            DeletePostValue( "ZT_"+"Z234DetHistFchaApli_"+sGXsfl_83_idx) ;
            ChangePostValue( "Z235DetHistObs_"+sGXsfl_83_idx, cgiGet( "ZT_"+"Z235DetHistObs_"+sGXsfl_83_idx)) ;
            DeletePostValue( "ZT_"+"Z235DetHistObs_"+sGXsfl_83_idx) ;
            ChangePostValue( "Z236DetHistMotivo_"+sGXsfl_83_idx, cgiGet( "ZT_"+"Z236DetHistMotivo_"+sGXsfl_83_idx)) ;
            DeletePostValue( "ZT_"+"Z236DetHistMotivo_"+sGXsfl_83_idx) ;
            ChangePostValue( "Z237DetHistAct_"+sGXsfl_83_idx, cgiGet( "ZT_"+"Z237DetHistAct_"+sGXsfl_83_idx)) ;
            DeletePostValue( "ZT_"+"Z237DetHistAct_"+sGXsfl_83_idx) ;
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
         context.SendWebValue( "Hist Precio Productos") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202211192253381", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("histprecioprod.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpID) + "," + UrlEncode("" +AV8HistAnio) + "," + UrlEncode("" +AV9HistPeriodo) + "," + UrlEncode("" +AV10detTipoProdID) + "," + UrlEncode("" +AV11categID) + "," + UrlEncode("" +AV19subCatID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "HistPrecioProd";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A173detTipoProdDsc, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("histprecioprod:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("histprecioprod:[SendSecurityCheck value for]"+"detTipoProdDsc:"+StringUtil.RTrim( context.localUtil.Format( A173detTipoProdDsc, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z227HistAnio", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z227HistAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z228HistPeriodo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z228HistPeriodo), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z36detTipoProdID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36detTipoProdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z32categID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z33subCatID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z173detTipoProdDsc", StringUtil.RTrim( Z173detTipoProdDsc));
         GxWebStd.gx_hidden_field( context, "Z229HistEst", StringUtil.RTrim( Z229HistEst));
         GxWebStd.gx_hidden_field( context, "Z230HistUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z230HistUltNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O230HistUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(O230HistUltNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_83", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_83_idx), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV13TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV13TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vHISTANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8HistAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vHISTANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8HistAnio), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vHISTPERIODO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9HistPeriodo), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vHISTPERIODO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9HistPeriodo), "Z9"), context));
         GxWebStd.gx_hidden_field( context, "vDETTIPOPRODID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10detTipoProdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vDETTIPOPRODID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10detTipoProdID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vCATEGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11categID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCATEGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11categID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vSUBCATID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19subCatID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSUBCATID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19subCatID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "DETTIPOPRODDSC", StringUtil.RTrim( A173detTipoProdDsc));
         GxWebStd.gx_hidden_field( context, "CATEGDSC", StringUtil.RTrim( A146categDsc));
         GxWebStd.gx_hidden_field( context, "SUBCATDSC", StringUtil.RTrim( A148subCatDsc));
         GxWebStd.gx_hidden_field( context, "TIPOPRODID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31tipoProdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV21Pgmname));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0Q39( )
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
         return "HistPrecioProd" ;
      }

      public override String GetPgmdesc( )
      {
         return "Hist Precio Productos" ;
      }

      protected void InitializeNonKey0Q39( )
      {
         A31tipoProdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A173detTipoProdDsc = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173detTipoProdDsc", A173detTipoProdDsc);
         A146categDsc = "";
         n146categDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A146categDsc", A146categDsc);
         A148subCatDsc = "";
         n148subCatDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A148subCatDsc", A148subCatDsc);
         A229HistEst = "";
         n229HistEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229HistEst", A229HistEst);
         n229HistEst = (String.IsNullOrEmpty(StringUtil.RTrim( A229HistEst)) ? true : false);
         A230HistUltNro = 0;
         n230HistUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
         n230HistUltNro = ((0==A230HistUltNro) ? true : false);
         O230HistUltNro = A230HistUltNro;
         n230HistUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
         Z173detTipoProdDsc = "";
         Z229HistEst = "";
         Z230HistUltNro = 0;
      }

      protected void InitAll0Q39( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A227HistAnio = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227HistAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A227HistAnio), 4, 0)));
         A228HistPeriodo = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
         A36detTipoProdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36detTipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)));
         A32categID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32categID", StringUtil.LTrim( StringUtil.Str( (decimal)(A32categID), 4, 0)));
         A33subCatID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33subCatID", StringUtil.LTrim( StringUtil.Str( (decimal)(A33subCatID), 4, 0)));
         InitializeNonKey0Q39( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0Q40( )
      {
         A232DetHistFcha = DateTime.MinValue;
         n232DetHistFcha = false;
         A233DetHistPrecio = 0;
         n233DetHistPrecio = false;
         A234DetHistFchaApli = DateTime.MinValue;
         n234DetHistFchaApli = false;
         A235DetHistObs = "";
         n235DetHistObs = false;
         A236DetHistMotivo = "";
         n236DetHistMotivo = false;
         A237DetHistAct = 0;
         n237DetHistAct = false;
         Z232DetHistFcha = DateTime.MinValue;
         Z233DetHistPrecio = 0;
         Z234DetHistFchaApli = DateTime.MinValue;
         Z235DetHistObs = "";
         Z236DetHistMotivo = "";
         Z237DetHistAct = 0;
      }

      protected void InitAll0Q40( )
      {
         A231DetHistNro = 0;
         InitializeNonKey0Q40( ) ;
      }

      protected void StandaloneModalInsert0Q40( )
      {
         A230HistUltNro = i230HistUltNro;
         n230HistUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230HistUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A230HistUltNro), 8, 0)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022111922533823", true);
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
         context.AddJavascriptSource("histprecioprod.js", "?2022111922533823", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties40( )
      {
         edtDetHistNro_Enabled = defedtDetHistNro_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDetHistNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDetHistNro_Enabled), 5, 0)), !bGXsfl_83_Refreshing);
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
         edtHistAnio_Internalname = "HISTANIO";
         cmbHistPeriodo_Internalname = "HISTPERIODO";
         dyndetTipoProdID_Internalname = "DETTIPOPRODID";
         dyncategID_Internalname = "CATEGID";
         dynsubCatID_Internalname = "SUBCATID";
         chkHistEst_Internalname = "HISTEST";
         edtHistUltNro_Internalname = "HISTULTNRO";
         lblTitlelevel1_Internalname = "TITLELEVEL1";
         edtDetHistNro_Internalname = "DETHISTNRO";
         edtDetHistFcha_Internalname = "DETHISTFCHA";
         edtDetHistPrecio_Internalname = "DETHISTPRECIO";
         chkDetHistAct_Internalname = "DETHISTACT";
         edtDetHistFchaApli_Internalname = "DETHISTFCHAAPLI";
         edtDetHistObs_Internalname = "DETHISTOBS";
         edtDetHistMotivo_Internalname = "DETHISTMOTIVO";
         divLevel1table_Internalname = "LEVEL1TABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_36_Internalname = "PROMPT_36";
         imgprompt_32_Internalname = "PROMPT_32";
         imgprompt_33_Internalname = "PROMPT_33";
         subGridhistprecioprod_level1_Internalname = "GRIDHISTPRECIOPROD_LEVEL1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtDetHistMotivo_Jsonclick = "";
         edtDetHistObs_Jsonclick = "";
         edtDetHistFchaApli_Jsonclick = "";
         edtDetHistPrecio_Jsonclick = "";
         edtDetHistFcha_Jsonclick = "";
         edtDetHistNro_Jsonclick = "";
         subGridhistprecioprod_level1_Class = "Grid";
         subGridhistprecioprod_level1_Backcolorstyle = 0;
         subGridhistprecioprod_level1_Allowcollapsing = 0;
         subGridhistprecioprod_level1_Allowselection = 0;
         edtDetHistMotivo_Enabled = 1;
         edtDetHistObs_Enabled = 1;
         edtDetHistFchaApli_Enabled = 1;
         chkDetHistAct.Enabled = 1;
         edtDetHistPrecio_Enabled = 1;
         edtDetHistFcha_Enabled = 1;
         edtDetHistNro_Enabled = 1;
         subGridhistprecioprod_level1_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtHistUltNro_Jsonclick = "";
         edtHistUltNro_Enabled = 0;
         chkHistEst.Enabled = 1;
         imgprompt_33_Visible = 1;
         imgprompt_33_Link = "";
         dynsubCatID_Jsonclick = "";
         dynsubCatID.Enabled = 1;
         imgprompt_32_Visible = 1;
         imgprompt_32_Link = "";
         dyncategID_Jsonclick = "";
         dyncategID.Enabled = 1;
         imgprompt_36_Visible = 1;
         imgprompt_36_Link = "";
         dyndetTipoProdID_Jsonclick = "";
         dyndetTipoProdID.Enabled = 1;
         cmbHistPeriodo_Jsonclick = "";
         cmbHistPeriodo.Enabled = 1;
         edtHistAnio_Jsonclick = "";
         edtHistAnio_Enabled = 1;
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
         GXACATEGID_html0Q39( A1EmpID, A36detTipoProdID) ;
         GXACATEGID_html0Q39( A1EmpID, A36detTipoProdID) ;
         GXASUBCATID_html0Q39( A1EmpID, A32categID) ;
         GXASUBCATID_html0Q39( A1EmpID, A32categID) ;
         /* End function dynload_actions */
      }

      protected void GXDLADETTIPOPRODID0Q39( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLADETTIPOPRODID_data0Q39( ) ;
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

      protected void GXADETTIPOPRODID_html0Q39( )
      {
         short gxdynajaxvalue ;
         GXDLADETTIPOPRODID_data0Q39( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dyndetTipoProdID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dyndetTipoProdID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLADETTIPOPRODID_data0Q39( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000Q32 */
         pr_default.execute(30);
         while ( (pr_default.getStatus(30) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000Q32_A31tipoProdID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000Q32_A144tipoProdDsc[0]));
            pr_default.readNext(30);
         }
         pr_default.close(30);
      }

      protected void GXDLACATEGID0Q39( short A1EmpID ,
                                       short A36detTipoProdID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLACATEGID_data0Q39( A1EmpID, A36detTipoProdID) ;
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

      protected void GXACATEGID_html0Q39( short A1EmpID ,
                                          short A36detTipoProdID )
      {
         short gxdynajaxvalue ;
         GXDLACATEGID_data0Q39( A1EmpID, A36detTipoProdID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dyncategID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dyncategID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLACATEGID_data0Q39( short A1EmpID ,
                                            short A36detTipoProdID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000Q33 */
         pr_default.execute(31, new Object[] {A1EmpID, A36detTipoProdID});
         while ( (pr_default.getStatus(31) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000Q33_A32categID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000Q33_A146categDsc[0]));
            pr_default.readNext(31);
         }
         pr_default.close(31);
      }

      protected void GXDLASUBCATID0Q39( short A1EmpID ,
                                        short A32categID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLASUBCATID_data0Q39( A1EmpID, A32categID) ;
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

      protected void GXASUBCATID_html0Q39( short A1EmpID ,
                                           short A32categID )
      {
         short gxdynajaxvalue ;
         GXDLASUBCATID_data0Q39( A1EmpID, A32categID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynsubCatID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynsubCatID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLASUBCATID_data0Q39( short A1EmpID ,
                                             short A32categID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000Q34 */
         pr_default.execute(32, new Object[] {A1EmpID, A32categID});
         while ( (pr_default.getStatus(32) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000Q34_A33subCatID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000Q34_A148subCatDsc[0]));
            pr_default.readNext(32);
         }
         pr_default.close(32);
      }

      protected void gxnrGridhistprecioprod_level1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_8340( ) ;
         while ( nGXsfl_83_idx <= nRC_GXsfl_83 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0Q40( ) ;
            standaloneModal0Q40( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0Q40( ) ;
            nGXsfl_83_idx = (short)(nGXsfl_83_idx+1);
            sGXsfl_83_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_83_idx), 4, 0)), 4, "0");
            SubsflControlProps_8340( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridhistprecioprod_level1Container));
         /* End function gxnrGridhistprecioprod_level1_newrow */
      }

      protected void init_web_controls( )
      {
         cmbHistPeriodo.Name = "HISTPERIODO";
         cmbHistPeriodo.WebTags = "";
         cmbHistPeriodo.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 2, 0)), "Seleccionar", 0);
         cmbHistPeriodo.addItem("1", "ENERO", 0);
         cmbHistPeriodo.addItem("2", "FEBRERO", 0);
         cmbHistPeriodo.addItem("3", "MARZO", 0);
         cmbHistPeriodo.addItem("4", "ABRIL", 0);
         cmbHistPeriodo.addItem("5", "MAYO", 0);
         cmbHistPeriodo.addItem("6", "JUNIO", 0);
         cmbHistPeriodo.addItem("7", "JULIO", 0);
         cmbHistPeriodo.addItem("8", "AGOSTO", 0);
         cmbHistPeriodo.addItem("9", "SEPTIEMBRE", 0);
         cmbHistPeriodo.addItem("10", "OCTUBRE", 0);
         cmbHistPeriodo.addItem("11", "NOVIEMBRE", 0);
         cmbHistPeriodo.addItem("12", "DICIEMBRE", 0);
         if ( cmbHistPeriodo.ItemCount > 0 )
         {
            A228HistPeriodo = (short)(NumberUtil.Val( cmbHistPeriodo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228HistPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A228HistPeriodo), 2, 0)));
         }
         dyndetTipoProdID.Name = "DETTIPOPRODID";
         dyndetTipoProdID.WebTags = "";
         dyncategID.Name = "CATEGID";
         dyncategID.WebTags = "";
         dynsubCatID.Name = "SUBCATID";
         dynsubCatID.WebTags = "";
         chkHistEst.Name = "HISTEST";
         chkHistEst.WebTags = "";
         chkHistEst.Caption = "Activo?";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkHistEst_Internalname, "TitleCaption", chkHistEst.Caption, true);
         chkHistEst.CheckedValue = "I";
         GXCCtl = "DETHISTACT_" + sGXsfl_83_idx;
         chkDetHistAct.Name = GXCCtl;
         chkDetHistAct.WebTags = "";
         chkDetHistAct.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkDetHistAct_Internalname, "TitleCaption", chkDetHistAct.Caption, !bGXsfl_83_Refreshing);
         chkDetHistAct.CheckedValue = "0";
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               short GX_Parm2 ,
                               GXCombobox dynGX_Parm3 ,
                               GXCombobox dynGX_Parm4 ,
                               String GX_Parm5 ,
                               GXCombobox dynGX_Parm6 )
      {
         A1EmpID = GX_Parm1;
         A31tipoProdID = GX_Parm2;
         dyndetTipoProdID = dynGX_Parm3;
         A36detTipoProdID = (short)(NumberUtil.Val( dyndetTipoProdID.CurrentValue, "."));
         dyncategID = dynGX_Parm4;
         A32categID = (short)(NumberUtil.Val( dyncategID.CurrentValue, "."));
         A44empdsc = GX_Parm5;
         n44empdsc = false;
         dynsubCatID = dynGX_Parm6;
         A33subCatID = (short)(NumberUtil.Val( dynsubCatID.CurrentValue, "."));
         /* Using cursor T000Q35 */
         pr_default.execute(33, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(33) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000Q35_A44empdsc[0];
         n44empdsc = T000Q35_n44empdsc[0];
         pr_default.close(33);
         /* Using cursor T000Q36 */
         pr_default.execute(34, new Object[] {A1EmpID, A31tipoProdID});
         if ( (pr_default.getStatus(34) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         pr_default.close(34);
         GXACATEGID_html0Q39( A1EmpID, A36detTipoProdID) ;
         GXASUBCATID_html0Q39( A1EmpID, A32categID) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A44empdsc = "";
            n44empdsc = false;
         }
         dyncategID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0));
         dynsubCatID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A33subCatID), 4, 0));
         isValidOutput.Add(A44empdsc);
         if ( dyncategID.ItemCount > 0 )
         {
            A32categID = (short)(NumberUtil.Val( dyncategID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0))), "."));
         }
         dyncategID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0));
         isValidOutput.Add(dyncategID);
         if ( dynsubCatID.ItemCount > 0 )
         {
            A33subCatID = (short)(NumberUtil.Val( dynsubCatID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A33subCatID), 4, 0))), "."));
         }
         dynsubCatID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A33subCatID), 4, 0));
         isValidOutput.Add(dynsubCatID);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Dettipoprodid( short GX_Parm1 ,
                                       GXCombobox dynGX_Parm2 ,
                                       GXCombobox dynGX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         dyndetTipoProdID = dynGX_Parm2;
         A36detTipoProdID = (short)(NumberUtil.Val( dyndetTipoProdID.CurrentValue, "."));
         dyncategID = dynGX_Parm3;
         A32categID = (short)(NumberUtil.Val( dyncategID.CurrentValue, "."));
         /* Using cursor T000Q37 */
         pr_default.execute(35, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(35) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         pr_default.close(35);
         GXACATEGID_html0Q39( A1EmpID, A36detTipoProdID) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dyncategID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0));
         if ( dyncategID.ItemCount > 0 )
         {
            A32categID = (short)(NumberUtil.Val( dyncategID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0))), "."));
         }
         dyncategID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0));
         isValidOutput.Add(dyncategID);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Categid( short GX_Parm1 ,
                                 GXCombobox dynGX_Parm2 ,
                                 String GX_Parm3 ,
                                 GXCombobox dynGX_Parm4 )
      {
         A1EmpID = GX_Parm1;
         dyncategID = dynGX_Parm2;
         A32categID = (short)(NumberUtil.Val( dyncategID.CurrentValue, "."));
         A146categDsc = GX_Parm3;
         n146categDsc = false;
         dynsubCatID = dynGX_Parm4;
         A33subCatID = (short)(NumberUtil.Val( dynsubCatID.CurrentValue, "."));
         /* Using cursor T000Q38 */
         pr_default.execute(36, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(36) == 101) )
         {
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A146categDsc = T000Q38_A146categDsc[0];
         n146categDsc = T000Q38_n146categDsc[0];
         pr_default.close(36);
         GXASUBCATID_html0Q39( A1EmpID, A32categID) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A146categDsc = "";
            n146categDsc = false;
         }
         dynsubCatID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A33subCatID), 4, 0));
         isValidOutput.Add(StringUtil.RTrim( A146categDsc));
         if ( dynsubCatID.ItemCount > 0 )
         {
            A33subCatID = (short)(NumberUtil.Val( dynsubCatID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A33subCatID), 4, 0))), "."));
         }
         dynsubCatID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A33subCatID), 4, 0));
         isValidOutput.Add(dynsubCatID);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Subcatid( short GX_Parm1 ,
                                  GXCombobox dynGX_Parm2 ,
                                  GXCombobox dynGX_Parm3 ,
                                  String GX_Parm4 )
      {
         A1EmpID = GX_Parm1;
         dyncategID = dynGX_Parm2;
         A32categID = (short)(NumberUtil.Val( dyncategID.CurrentValue, "."));
         dynsubCatID = dynGX_Parm3;
         A33subCatID = (short)(NumberUtil.Val( dynsubCatID.CurrentValue, "."));
         A148subCatDsc = GX_Parm4;
         n148subCatDsc = false;
         /* Using cursor T000Q39 */
         pr_default.execute(37, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(37) == 101) )
         {
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A148subCatDsc = T000Q39_A148subCatDsc[0];
         n148subCatDsc = T000Q39_n148subCatDsc[0];
         pr_default.close(37);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A148subCatDsc = "";
            n148subCatDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A148subCatDsc));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8HistAnio',fld:'vHISTANIO',pic:'ZZZ9',hsh:true},{av:'AV9HistPeriodo',fld:'vHISTPERIODO',pic:'Z9',hsh:true},{av:'AV10detTipoProdID',fld:'vDETTIPOPRODID',pic:'ZZZ9',hsh:true},{av:'AV11categID',fld:'vCATEGID',pic:'ZZZ9',hsh:true},{av:'AV19subCatID',fld:'vSUBCATID',pic:'ZZZ9',hsh:true},{av:'dyndetTipoProdID'},{av:'A36detTipoProdID',fld:'DETTIPOPRODID',pic:'ZZZ9'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'dyncategID'},{av:'A32categID',fld:'CATEGID',pic:'ZZZ9'},{av:'dynsubCatID'},{av:'A33subCatID',fld:'SUBCATID',pic:'ZZZ9'}]");
         setEventMetadata("ENTER",",oparms:[{av:'dyndetTipoProdID'},{av:'A36detTipoProdID',fld:'DETTIPOPRODID',pic:'ZZZ9'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'dyncategID'},{av:'A32categID',fld:'CATEGID',pic:'ZZZ9'},{av:'dynsubCatID'},{av:'A33subCatID',fld:'SUBCATID',pic:'ZZZ9'}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV8HistAnio',fld:'vHISTANIO',pic:'ZZZ9',hsh:true},{av:'AV9HistPeriodo',fld:'vHISTPERIODO',pic:'Z9',hsh:true},{av:'AV10detTipoProdID',fld:'vDETTIPOPRODID',pic:'ZZZ9',hsh:true},{av:'AV11categID',fld:'vCATEGID',pic:'ZZZ9',hsh:true},{av:'AV19subCatID',fld:'vSUBCATID',pic:'ZZZ9',hsh:true},{av:'A173detTipoProdDsc',fld:'DETTIPOPRODDSC',pic:'@!'},{av:'dyndetTipoProdID'},{av:'A36detTipoProdID',fld:'DETTIPOPRODID',pic:'ZZZ9'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'dyncategID'},{av:'A32categID',fld:'CATEGID',pic:'ZZZ9'},{av:'dynsubCatID'},{av:'A33subCatID',fld:'SUBCATID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dyndetTipoProdID'},{av:'A36detTipoProdID',fld:'DETTIPOPRODID',pic:'ZZZ9'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'dyncategID'},{av:'A32categID',fld:'CATEGID',pic:'ZZZ9'},{av:'dynsubCatID'},{av:'A33subCatID',fld:'SUBCATID',pic:'ZZZ9'}]}");
         setEventMetadata("AFTER TRN","{handler:'E120Q2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV13TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'dyndetTipoProdID'},{av:'A36detTipoProdID',fld:'DETTIPOPRODID',pic:'ZZZ9'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'dyncategID'},{av:'A32categID',fld:'CATEGID',pic:'ZZZ9'},{av:'dynsubCatID'},{av:'A33subCatID',fld:'SUBCATID',pic:'ZZZ9'}]");
         setEventMetadata("AFTER TRN",",oparms:[{av:'dyndetTipoProdID'},{av:'A36detTipoProdID',fld:'DETTIPOPRODID',pic:'ZZZ9'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'},{av:'dyncategID'},{av:'A32categID',fld:'CATEGID',pic:'ZZZ9'},{av:'dynsubCatID'},{av:'A33subCatID',fld:'SUBCATID',pic:'ZZZ9'}]}");
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
         pr_default.close(33);
         pr_default.close(19);
         pr_default.close(35);
         pr_default.close(34);
         pr_default.close(36);
         pr_default.close(20);
         pr_default.close(37);
         pr_default.close(21);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z173detTipoProdDsc = "";
         Z229HistEst = "";
         Z232DetHistFcha = DateTime.MinValue;
         Z234DetHistFchaApli = DateTime.MinValue;
         Z235DetHistObs = "";
         Z236DetHistMotivo = "";
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
         sImgUrl = "";
         A44empdsc = "";
         A229HistEst = "";
         lblTitlelevel1_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridhistprecioprod_level1Container = new GXWebGrid( context);
         Gridhistprecioprod_level1Column = new GXWebColumn();
         A232DetHistFcha = DateTime.MinValue;
         A234DetHistFchaApli = DateTime.MinValue;
         A235DetHistObs = "";
         A236DetHistMotivo = "";
         sMode40 = "";
         sStyleString = "";
         A173detTipoProdDsc = "";
         A146categDsc = "";
         A148subCatDsc = "";
         AV21Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode39 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV13TrnContext = new SdtTransactionContext(context);
         AV14WebSession = context.GetSession();
         Z44empdsc = "";
         Z146categDsc = "";
         Z148subCatDsc = "";
         T000Q6_A44empdsc = new String[] {""} ;
         T000Q6_n44empdsc = new bool[] {false} ;
         T000Q8_A146categDsc = new String[] {""} ;
         T000Q8_n146categDsc = new bool[] {false} ;
         T000Q9_A148subCatDsc = new String[] {""} ;
         T000Q9_n148subCatDsc = new bool[] {false} ;
         T000Q11_A227HistAnio = new short[1] ;
         T000Q11_A228HistPeriodo = new short[1] ;
         T000Q11_A44empdsc = new String[] {""} ;
         T000Q11_n44empdsc = new bool[] {false} ;
         T000Q11_A173detTipoProdDsc = new String[] {""} ;
         T000Q11_A146categDsc = new String[] {""} ;
         T000Q11_n146categDsc = new bool[] {false} ;
         T000Q11_A148subCatDsc = new String[] {""} ;
         T000Q11_n148subCatDsc = new bool[] {false} ;
         T000Q11_A229HistEst = new String[] {""} ;
         T000Q11_n229HistEst = new bool[] {false} ;
         T000Q11_A230HistUltNro = new int[1] ;
         T000Q11_n230HistUltNro = new bool[] {false} ;
         T000Q11_A1EmpID = new short[1] ;
         T000Q11_A36detTipoProdID = new short[1] ;
         T000Q11_A32categID = new short[1] ;
         T000Q11_A33subCatID = new short[1] ;
         T000Q7_A31tipoProdID = new short[1] ;
         T000Q12_A44empdsc = new String[] {""} ;
         T000Q12_n44empdsc = new bool[] {false} ;
         T000Q13_A146categDsc = new String[] {""} ;
         T000Q13_n146categDsc = new bool[] {false} ;
         T000Q14_A148subCatDsc = new String[] {""} ;
         T000Q14_n148subCatDsc = new bool[] {false} ;
         T000Q15_A1EmpID = new short[1] ;
         T000Q15_A227HistAnio = new short[1] ;
         T000Q15_A228HistPeriodo = new short[1] ;
         T000Q15_A36detTipoProdID = new short[1] ;
         T000Q15_A32categID = new short[1] ;
         T000Q15_A33subCatID = new short[1] ;
         T000Q5_A227HistAnio = new short[1] ;
         T000Q5_A228HistPeriodo = new short[1] ;
         T000Q5_A173detTipoProdDsc = new String[] {""} ;
         T000Q5_A229HistEst = new String[] {""} ;
         T000Q5_n229HistEst = new bool[] {false} ;
         T000Q5_A230HistUltNro = new int[1] ;
         T000Q5_n230HistUltNro = new bool[] {false} ;
         T000Q5_A1EmpID = new short[1] ;
         T000Q5_A36detTipoProdID = new short[1] ;
         T000Q5_A32categID = new short[1] ;
         T000Q5_A33subCatID = new short[1] ;
         T000Q16_A227HistAnio = new short[1] ;
         T000Q16_A228HistPeriodo = new short[1] ;
         T000Q16_A1EmpID = new short[1] ;
         T000Q16_A36detTipoProdID = new short[1] ;
         T000Q16_A32categID = new short[1] ;
         T000Q16_A33subCatID = new short[1] ;
         T000Q17_A227HistAnio = new short[1] ;
         T000Q17_A228HistPeriodo = new short[1] ;
         T000Q17_A1EmpID = new short[1] ;
         T000Q17_A36detTipoProdID = new short[1] ;
         T000Q17_A32categID = new short[1] ;
         T000Q17_A33subCatID = new short[1] ;
         T000Q4_A227HistAnio = new short[1] ;
         T000Q4_A228HistPeriodo = new short[1] ;
         T000Q4_A173detTipoProdDsc = new String[] {""} ;
         T000Q4_A229HistEst = new String[] {""} ;
         T000Q4_n229HistEst = new bool[] {false} ;
         T000Q4_A230HistUltNro = new int[1] ;
         T000Q4_n230HistUltNro = new bool[] {false} ;
         T000Q4_A1EmpID = new short[1] ;
         T000Q4_A36detTipoProdID = new short[1] ;
         T000Q4_A32categID = new short[1] ;
         T000Q4_A33subCatID = new short[1] ;
         T000Q21_A44empdsc = new String[] {""} ;
         T000Q21_n44empdsc = new bool[] {false} ;
         T000Q22_A146categDsc = new String[] {""} ;
         T000Q22_n146categDsc = new bool[] {false} ;
         T000Q23_A148subCatDsc = new String[] {""} ;
         T000Q23_n148subCatDsc = new bool[] {false} ;
         T000Q25_A1EmpID = new short[1] ;
         T000Q25_A227HistAnio = new short[1] ;
         T000Q25_A228HistPeriodo = new short[1] ;
         T000Q25_A36detTipoProdID = new short[1] ;
         T000Q25_A32categID = new short[1] ;
         T000Q25_A33subCatID = new short[1] ;
         T000Q26_A1EmpID = new short[1] ;
         T000Q26_A227HistAnio = new short[1] ;
         T000Q26_A228HistPeriodo = new short[1] ;
         T000Q26_A36detTipoProdID = new short[1] ;
         T000Q26_A32categID = new short[1] ;
         T000Q26_A33subCatID = new short[1] ;
         T000Q26_A231DetHistNro = new int[1] ;
         T000Q26_A232DetHistFcha = new DateTime[] {DateTime.MinValue} ;
         T000Q26_n232DetHistFcha = new bool[] {false} ;
         T000Q26_A233DetHistPrecio = new decimal[1] ;
         T000Q26_n233DetHistPrecio = new bool[] {false} ;
         T000Q26_A234DetHistFchaApli = new DateTime[] {DateTime.MinValue} ;
         T000Q26_n234DetHistFchaApli = new bool[] {false} ;
         T000Q26_A235DetHistObs = new String[] {""} ;
         T000Q26_n235DetHistObs = new bool[] {false} ;
         T000Q26_A236DetHistMotivo = new String[] {""} ;
         T000Q26_n236DetHistMotivo = new bool[] {false} ;
         T000Q26_A237DetHistAct = new short[1] ;
         T000Q26_n237DetHistAct = new bool[] {false} ;
         T000Q27_A1EmpID = new short[1] ;
         T000Q27_A227HistAnio = new short[1] ;
         T000Q27_A228HistPeriodo = new short[1] ;
         T000Q27_A36detTipoProdID = new short[1] ;
         T000Q27_A32categID = new short[1] ;
         T000Q27_A33subCatID = new short[1] ;
         T000Q27_A231DetHistNro = new int[1] ;
         T000Q3_A1EmpID = new short[1] ;
         T000Q3_A227HistAnio = new short[1] ;
         T000Q3_A228HistPeriodo = new short[1] ;
         T000Q3_A36detTipoProdID = new short[1] ;
         T000Q3_A32categID = new short[1] ;
         T000Q3_A33subCatID = new short[1] ;
         T000Q3_A231DetHistNro = new int[1] ;
         T000Q3_A232DetHistFcha = new DateTime[] {DateTime.MinValue} ;
         T000Q3_n232DetHistFcha = new bool[] {false} ;
         T000Q3_A233DetHistPrecio = new decimal[1] ;
         T000Q3_n233DetHistPrecio = new bool[] {false} ;
         T000Q3_A234DetHistFchaApli = new DateTime[] {DateTime.MinValue} ;
         T000Q3_n234DetHistFchaApli = new bool[] {false} ;
         T000Q3_A235DetHistObs = new String[] {""} ;
         T000Q3_n235DetHistObs = new bool[] {false} ;
         T000Q3_A236DetHistMotivo = new String[] {""} ;
         T000Q3_n236DetHistMotivo = new bool[] {false} ;
         T000Q3_A237DetHistAct = new short[1] ;
         T000Q3_n237DetHistAct = new bool[] {false} ;
         T000Q2_A1EmpID = new short[1] ;
         T000Q2_A227HistAnio = new short[1] ;
         T000Q2_A228HistPeriodo = new short[1] ;
         T000Q2_A36detTipoProdID = new short[1] ;
         T000Q2_A32categID = new short[1] ;
         T000Q2_A33subCatID = new short[1] ;
         T000Q2_A231DetHistNro = new int[1] ;
         T000Q2_A232DetHistFcha = new DateTime[] {DateTime.MinValue} ;
         T000Q2_n232DetHistFcha = new bool[] {false} ;
         T000Q2_A233DetHistPrecio = new decimal[1] ;
         T000Q2_n233DetHistPrecio = new bool[] {false} ;
         T000Q2_A234DetHistFchaApli = new DateTime[] {DateTime.MinValue} ;
         T000Q2_n234DetHistFchaApli = new bool[] {false} ;
         T000Q2_A235DetHistObs = new String[] {""} ;
         T000Q2_n235DetHistObs = new bool[] {false} ;
         T000Q2_A236DetHistMotivo = new String[] {""} ;
         T000Q2_n236DetHistMotivo = new bool[] {false} ;
         T000Q2_A237DetHistAct = new short[1] ;
         T000Q2_n237DetHistAct = new bool[] {false} ;
         T000Q31_A1EmpID = new short[1] ;
         T000Q31_A227HistAnio = new short[1] ;
         T000Q31_A228HistPeriodo = new short[1] ;
         T000Q31_A36detTipoProdID = new short[1] ;
         T000Q31_A32categID = new short[1] ;
         T000Q31_A33subCatID = new short[1] ;
         T000Q31_A231DetHistNro = new int[1] ;
         Gridhistprecioprod_level1Row = new GXWebRow();
         subGridhistprecioprod_level1_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000Q32_A1EmpID = new short[1] ;
         T000Q32_A31tipoProdID = new short[1] ;
         T000Q32_A144tipoProdDsc = new String[] {""} ;
         T000Q32_n144tipoProdDsc = new bool[] {false} ;
         T000Q33_A1EmpID = new short[1] ;
         T000Q33_A32categID = new short[1] ;
         T000Q33_A146categDsc = new String[] {""} ;
         T000Q33_n146categDsc = new bool[] {false} ;
         T000Q33_A31tipoProdID = new short[1] ;
         T000Q34_A1EmpID = new short[1] ;
         T000Q34_A32categID = new short[1] ;
         T000Q34_A33subCatID = new short[1] ;
         T000Q34_A148subCatDsc = new String[] {""} ;
         T000Q34_n148subCatDsc = new bool[] {false} ;
         T000Q35_A44empdsc = new String[] {""} ;
         T000Q35_n44empdsc = new bool[] {false} ;
         T000Q36_A31tipoProdID = new short[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         T000Q37_A31tipoProdID = new short[1] ;
         T000Q38_A146categDsc = new String[] {""} ;
         T000Q38_n146categDsc = new bool[] {false} ;
         T000Q39_A148subCatDsc = new String[] {""} ;
         T000Q39_n148subCatDsc = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.histprecioprod__default(),
            new Object[][] {
                new Object[] {
               T000Q2_A1EmpID, T000Q2_A227HistAnio, T000Q2_A228HistPeriodo, T000Q2_A36detTipoProdID, T000Q2_A32categID, T000Q2_A33subCatID, T000Q2_A231DetHistNro, T000Q2_A232DetHistFcha, T000Q2_n232DetHistFcha, T000Q2_A233DetHistPrecio,
               T000Q2_n233DetHistPrecio, T000Q2_A234DetHistFchaApli, T000Q2_n234DetHistFchaApli, T000Q2_A235DetHistObs, T000Q2_n235DetHistObs, T000Q2_A236DetHistMotivo, T000Q2_n236DetHistMotivo, T000Q2_A237DetHistAct, T000Q2_n237DetHistAct
               }
               , new Object[] {
               T000Q3_A1EmpID, T000Q3_A227HistAnio, T000Q3_A228HistPeriodo, T000Q3_A36detTipoProdID, T000Q3_A32categID, T000Q3_A33subCatID, T000Q3_A231DetHistNro, T000Q3_A232DetHistFcha, T000Q3_n232DetHistFcha, T000Q3_A233DetHistPrecio,
               T000Q3_n233DetHistPrecio, T000Q3_A234DetHistFchaApli, T000Q3_n234DetHistFchaApli, T000Q3_A235DetHistObs, T000Q3_n235DetHistObs, T000Q3_A236DetHistMotivo, T000Q3_n236DetHistMotivo, T000Q3_A237DetHistAct, T000Q3_n237DetHistAct
               }
               , new Object[] {
               T000Q4_A227HistAnio, T000Q4_A228HistPeriodo, T000Q4_A173detTipoProdDsc, T000Q4_A229HistEst, T000Q4_n229HistEst, T000Q4_A230HistUltNro, T000Q4_n230HistUltNro, T000Q4_A1EmpID, T000Q4_A36detTipoProdID, T000Q4_A32categID,
               T000Q4_A33subCatID
               }
               , new Object[] {
               T000Q5_A227HistAnio, T000Q5_A228HistPeriodo, T000Q5_A173detTipoProdDsc, T000Q5_A229HistEst, T000Q5_n229HistEst, T000Q5_A230HistUltNro, T000Q5_n230HistUltNro, T000Q5_A1EmpID, T000Q5_A36detTipoProdID, T000Q5_A32categID,
               T000Q5_A33subCatID
               }
               , new Object[] {
               T000Q6_A44empdsc, T000Q6_n44empdsc
               }
               , new Object[] {
               T000Q7_A31tipoProdID
               }
               , new Object[] {
               T000Q8_A146categDsc, T000Q8_n146categDsc
               }
               , new Object[] {
               T000Q9_A148subCatDsc, T000Q9_n148subCatDsc
               }
               , new Object[] {
               T000Q10_A31tipoProdID
               }
               , new Object[] {
               T000Q11_A227HistAnio, T000Q11_A228HistPeriodo, T000Q11_A44empdsc, T000Q11_n44empdsc, T000Q11_A173detTipoProdDsc, T000Q11_A146categDsc, T000Q11_n146categDsc, T000Q11_A148subCatDsc, T000Q11_n148subCatDsc, T000Q11_A229HistEst,
               T000Q11_n229HistEst, T000Q11_A230HistUltNro, T000Q11_n230HistUltNro, T000Q11_A1EmpID, T000Q11_A36detTipoProdID, T000Q11_A32categID, T000Q11_A33subCatID
               }
               , new Object[] {
               T000Q12_A44empdsc, T000Q12_n44empdsc
               }
               , new Object[] {
               T000Q13_A146categDsc, T000Q13_n146categDsc
               }
               , new Object[] {
               T000Q14_A148subCatDsc, T000Q14_n148subCatDsc
               }
               , new Object[] {
               T000Q15_A1EmpID, T000Q15_A227HistAnio, T000Q15_A228HistPeriodo, T000Q15_A36detTipoProdID, T000Q15_A32categID, T000Q15_A33subCatID
               }
               , new Object[] {
               T000Q16_A227HistAnio, T000Q16_A228HistPeriodo, T000Q16_A1EmpID, T000Q16_A36detTipoProdID, T000Q16_A32categID, T000Q16_A33subCatID
               }
               , new Object[] {
               T000Q17_A227HistAnio, T000Q17_A228HistPeriodo, T000Q17_A1EmpID, T000Q17_A36detTipoProdID, T000Q17_A32categID, T000Q17_A33subCatID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Q21_A44empdsc, T000Q21_n44empdsc
               }
               , new Object[] {
               T000Q22_A146categDsc, T000Q22_n146categDsc
               }
               , new Object[] {
               T000Q23_A148subCatDsc, T000Q23_n148subCatDsc
               }
               , new Object[] {
               }
               , new Object[] {
               T000Q25_A1EmpID, T000Q25_A227HistAnio, T000Q25_A228HistPeriodo, T000Q25_A36detTipoProdID, T000Q25_A32categID, T000Q25_A33subCatID
               }
               , new Object[] {
               T000Q26_A1EmpID, T000Q26_A227HistAnio, T000Q26_A228HistPeriodo, T000Q26_A36detTipoProdID, T000Q26_A32categID, T000Q26_A33subCatID, T000Q26_A231DetHistNro, T000Q26_A232DetHistFcha, T000Q26_n232DetHistFcha, T000Q26_A233DetHistPrecio,
               T000Q26_n233DetHistPrecio, T000Q26_A234DetHistFchaApli, T000Q26_n234DetHistFchaApli, T000Q26_A235DetHistObs, T000Q26_n235DetHistObs, T000Q26_A236DetHistMotivo, T000Q26_n236DetHistMotivo, T000Q26_A237DetHistAct, T000Q26_n237DetHistAct
               }
               , new Object[] {
               T000Q27_A1EmpID, T000Q27_A227HistAnio, T000Q27_A228HistPeriodo, T000Q27_A36detTipoProdID, T000Q27_A32categID, T000Q27_A33subCatID, T000Q27_A231DetHistNro
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Q31_A1EmpID, T000Q31_A227HistAnio, T000Q31_A228HistPeriodo, T000Q31_A36detTipoProdID, T000Q31_A32categID, T000Q31_A33subCatID, T000Q31_A231DetHistNro
               }
               , new Object[] {
               T000Q32_A1EmpID, T000Q32_A31tipoProdID, T000Q32_A144tipoProdDsc, T000Q32_n144tipoProdDsc
               }
               , new Object[] {
               T000Q33_A1EmpID, T000Q33_A32categID, T000Q33_A146categDsc, T000Q33_n146categDsc, T000Q33_A31tipoProdID
               }
               , new Object[] {
               T000Q34_A1EmpID, T000Q34_A32categID, T000Q34_A33subCatID, T000Q34_A148subCatDsc, T000Q34_n148subCatDsc
               }
               , new Object[] {
               T000Q35_A44empdsc, T000Q35_n44empdsc
               }
               , new Object[] {
               T000Q36_A31tipoProdID
               }
               , new Object[] {
               T000Q37_A31tipoProdID
               }
               , new Object[] {
               T000Q38_A146categDsc, T000Q38_n146categDsc
               }
               , new Object[] {
               T000Q39_A148subCatDsc, T000Q39_n148subCatDsc
               }
            }
         );
         AV21Pgmname = "HistPrecioProd";
      }

      private short wcpOAV7EmpID ;
      private short wcpOAV8HistAnio ;
      private short wcpOAV9HistPeriodo ;
      private short wcpOAV10detTipoProdID ;
      private short wcpOAV11categID ;
      private short wcpOAV19subCatID ;
      private short Z1EmpID ;
      private short Z227HistAnio ;
      private short Z228HistPeriodo ;
      private short Z36detTipoProdID ;
      private short Z32categID ;
      private short Z33subCatID ;
      private short nRC_GXsfl_83 ;
      private short nGXsfl_83_idx=1 ;
      private short Z237DetHistAct ;
      private short nRcdDeleted_40 ;
      private short nRcdExists_40 ;
      private short nIsMod_40 ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A36detTipoProdID ;
      private short A32categID ;
      private short A33subCatID ;
      private short Gx_BScreen ;
      private short AV7EmpID ;
      private short AV8HistAnio ;
      private short AV9HistPeriodo ;
      private short AV10detTipoProdID ;
      private short AV11categID ;
      private short AV19subCatID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A228HistPeriodo ;
      private short A227HistAnio ;
      private short subGridhistprecioprod_level1_Backcolorstyle ;
      private short A237DetHistAct ;
      private short subGridhistprecioprod_level1_Allowselection ;
      private short subGridhistprecioprod_level1_Allowhovering ;
      private short subGridhistprecioprod_level1_Allowcollapsing ;
      private short subGridhistprecioprod_level1_Collapsed ;
      private short nBlankRcdCount40 ;
      private short RcdFound40 ;
      private short nBlankRcdUsr40 ;
      private short A31tipoProdID ;
      private short RcdFound39 ;
      private short GX_JID ;
      private short subGridhistprecioprod_level1_Backstyle ;
      private short wbTemp ;
      private int Z230HistUltNro ;
      private int O230HistUltNro ;
      private int Z231DetHistNro ;
      private int A230HistUltNro ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtempdsc_Enabled ;
      private int edtHistAnio_Enabled ;
      private int imgprompt_36_Visible ;
      private int imgprompt_32_Visible ;
      private int imgprompt_33_Visible ;
      private int edtHistUltNro_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int A231DetHistNro ;
      private int edtDetHistNro_Enabled ;
      private int edtDetHistFcha_Enabled ;
      private int edtDetHistPrecio_Enabled ;
      private int edtDetHistFchaApli_Enabled ;
      private int edtDetHistObs_Enabled ;
      private int edtDetHistMotivo_Enabled ;
      private int subGridhistprecioprod_level1_Selectedindex ;
      private int subGridhistprecioprod_level1_Selectioncolor ;
      private int subGridhistprecioprod_level1_Hoveringcolor ;
      private int B230HistUltNro ;
      private int fRowAdded ;
      private int s230HistUltNro ;
      private int subGridhistprecioprod_level1_Backcolor ;
      private int subGridhistprecioprod_level1_Allbackcolor ;
      private int defedtDetHistNro_Enabled ;
      private int i230HistUltNro ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long GRIDHISTPRECIOPROD_LEVEL1_nFirstRecordOnPage ;
      private decimal Z233DetHistPrecio ;
      private decimal A233DetHistPrecio ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z173detTipoProdDsc ;
      private String Z229HistEst ;
      private String Z235DetHistObs ;
      private String Z236DetHistMotivo ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_83_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEmpID_Internalname ;
      private String cmbHistPeriodo_Internalname ;
      private String dyndetTipoProdID_Internalname ;
      private String dyncategID_Internalname ;
      private String dynsubCatID_Internalname ;
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
      private String edtEmpID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String edtHistAnio_Internalname ;
      private String edtHistAnio_Jsonclick ;
      private String cmbHistPeriodo_Jsonclick ;
      private String dyndetTipoProdID_Jsonclick ;
      private String imgprompt_36_Internalname ;
      private String imgprompt_36_Link ;
      private String dyncategID_Jsonclick ;
      private String imgprompt_32_Internalname ;
      private String imgprompt_32_Link ;
      private String dynsubCatID_Jsonclick ;
      private String imgprompt_33_Internalname ;
      private String imgprompt_33_Link ;
      private String chkHistEst_Internalname ;
      private String A229HistEst ;
      private String edtHistUltNro_Internalname ;
      private String edtHistUltNro_Jsonclick ;
      private String divLevel1table_Internalname ;
      private String lblTitlelevel1_Internalname ;
      private String lblTitlelevel1_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridhistprecioprod_level1_Header ;
      private String A235DetHistObs ;
      private String A236DetHistMotivo ;
      private String sMode40 ;
      private String edtDetHistNro_Internalname ;
      private String edtDetHistFcha_Internalname ;
      private String edtDetHistPrecio_Internalname ;
      private String chkDetHistAct_Internalname ;
      private String edtDetHistFchaApli_Internalname ;
      private String edtDetHistObs_Internalname ;
      private String edtDetHistMotivo_Internalname ;
      private String sStyleString ;
      private String A173detTipoProdDsc ;
      private String A146categDsc ;
      private String A148subCatDsc ;
      private String AV21Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode39 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z146categDsc ;
      private String Z148subCatDsc ;
      private String sGXsfl_83_fel_idx="0001" ;
      private String subGridhistprecioprod_level1_Class ;
      private String subGridhistprecioprod_level1_Linesclass ;
      private String ROClassString ;
      private String edtDetHistNro_Jsonclick ;
      private String edtDetHistFcha_Jsonclick ;
      private String edtDetHistPrecio_Jsonclick ;
      private String edtDetHistFchaApli_Jsonclick ;
      private String edtDetHistObs_Jsonclick ;
      private String edtDetHistMotivo_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridhistprecioprod_level1_Internalname ;
      private String gxwrpcisep ;
      private DateTime Z232DetHistFcha ;
      private DateTime Z234DetHistFchaApli ;
      private DateTime A232DetHistFcha ;
      private DateTime A234DetHistFchaApli ;
      private bool entryPointCalled ;
      private bool n230HistUltNro ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_83_Refreshing=false ;
      private bool n44empdsc ;
      private bool n229HistEst ;
      private bool n146categDsc ;
      private bool n148subCatDsc ;
      private bool returnInSub ;
      private bool n232DetHistFcha ;
      private bool n233DetHistPrecio ;
      private bool n234DetHistFchaApli ;
      private bool n235DetHistObs ;
      private bool n236DetHistMotivo ;
      private bool n237DetHistAct ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String A44empdsc ;
      private String Z44empdsc ;
      private IGxSession AV14WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridhistprecioprod_level1Container ;
      private GXWebRow Gridhistprecioprod_level1Row ;
      private GXWebColumn Gridhistprecioprod_level1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbHistPeriodo ;
      private GXCombobox dyndetTipoProdID ;
      private GXCombobox dyncategID ;
      private GXCombobox dynsubCatID ;
      private GXCheckbox chkHistEst ;
      private GXCheckbox chkDetHistAct ;
      private IDataStoreProvider pr_default ;
      private String[] T000Q6_A44empdsc ;
      private bool[] T000Q6_n44empdsc ;
      private String[] T000Q8_A146categDsc ;
      private bool[] T000Q8_n146categDsc ;
      private String[] T000Q9_A148subCatDsc ;
      private bool[] T000Q9_n148subCatDsc ;
      private short[] T000Q11_A227HistAnio ;
      private short[] T000Q11_A228HistPeriodo ;
      private String[] T000Q11_A44empdsc ;
      private bool[] T000Q11_n44empdsc ;
      private String[] T000Q11_A173detTipoProdDsc ;
      private String[] T000Q11_A146categDsc ;
      private bool[] T000Q11_n146categDsc ;
      private String[] T000Q11_A148subCatDsc ;
      private bool[] T000Q11_n148subCatDsc ;
      private String[] T000Q11_A229HistEst ;
      private bool[] T000Q11_n229HistEst ;
      private int[] T000Q11_A230HistUltNro ;
      private bool[] T000Q11_n230HistUltNro ;
      private short[] T000Q11_A1EmpID ;
      private short[] T000Q11_A36detTipoProdID ;
      private short[] T000Q11_A32categID ;
      private short[] T000Q11_A33subCatID ;
      private short[] T000Q7_A31tipoProdID ;
      private String[] T000Q12_A44empdsc ;
      private bool[] T000Q12_n44empdsc ;
      private String[] T000Q13_A146categDsc ;
      private bool[] T000Q13_n146categDsc ;
      private String[] T000Q14_A148subCatDsc ;
      private bool[] T000Q14_n148subCatDsc ;
      private short[] T000Q15_A1EmpID ;
      private short[] T000Q15_A227HistAnio ;
      private short[] T000Q15_A228HistPeriodo ;
      private short[] T000Q15_A36detTipoProdID ;
      private short[] T000Q15_A32categID ;
      private short[] T000Q15_A33subCatID ;
      private short[] T000Q5_A227HistAnio ;
      private short[] T000Q5_A228HistPeriodo ;
      private String[] T000Q5_A173detTipoProdDsc ;
      private String[] T000Q5_A229HistEst ;
      private bool[] T000Q5_n229HistEst ;
      private int[] T000Q5_A230HistUltNro ;
      private bool[] T000Q5_n230HistUltNro ;
      private short[] T000Q5_A1EmpID ;
      private short[] T000Q5_A36detTipoProdID ;
      private short[] T000Q5_A32categID ;
      private short[] T000Q5_A33subCatID ;
      private short[] T000Q16_A227HistAnio ;
      private short[] T000Q16_A228HistPeriodo ;
      private short[] T000Q16_A1EmpID ;
      private short[] T000Q16_A36detTipoProdID ;
      private short[] T000Q16_A32categID ;
      private short[] T000Q16_A33subCatID ;
      private short[] T000Q17_A227HistAnio ;
      private short[] T000Q17_A228HistPeriodo ;
      private short[] T000Q17_A1EmpID ;
      private short[] T000Q17_A36detTipoProdID ;
      private short[] T000Q17_A32categID ;
      private short[] T000Q17_A33subCatID ;
      private short[] T000Q4_A227HistAnio ;
      private short[] T000Q4_A228HistPeriodo ;
      private String[] T000Q4_A173detTipoProdDsc ;
      private String[] T000Q4_A229HistEst ;
      private bool[] T000Q4_n229HistEst ;
      private int[] T000Q4_A230HistUltNro ;
      private bool[] T000Q4_n230HistUltNro ;
      private short[] T000Q4_A1EmpID ;
      private short[] T000Q4_A36detTipoProdID ;
      private short[] T000Q4_A32categID ;
      private short[] T000Q4_A33subCatID ;
      private String[] T000Q21_A44empdsc ;
      private bool[] T000Q21_n44empdsc ;
      private String[] T000Q22_A146categDsc ;
      private bool[] T000Q22_n146categDsc ;
      private String[] T000Q23_A148subCatDsc ;
      private bool[] T000Q23_n148subCatDsc ;
      private short[] T000Q25_A1EmpID ;
      private short[] T000Q25_A227HistAnio ;
      private short[] T000Q25_A228HistPeriodo ;
      private short[] T000Q25_A36detTipoProdID ;
      private short[] T000Q25_A32categID ;
      private short[] T000Q25_A33subCatID ;
      private short[] T000Q26_A1EmpID ;
      private short[] T000Q26_A227HistAnio ;
      private short[] T000Q26_A228HistPeriodo ;
      private short[] T000Q26_A36detTipoProdID ;
      private short[] T000Q26_A32categID ;
      private short[] T000Q26_A33subCatID ;
      private int[] T000Q26_A231DetHistNro ;
      private DateTime[] T000Q26_A232DetHistFcha ;
      private bool[] T000Q26_n232DetHistFcha ;
      private decimal[] T000Q26_A233DetHistPrecio ;
      private bool[] T000Q26_n233DetHistPrecio ;
      private DateTime[] T000Q26_A234DetHistFchaApli ;
      private bool[] T000Q26_n234DetHistFchaApli ;
      private String[] T000Q26_A235DetHistObs ;
      private bool[] T000Q26_n235DetHistObs ;
      private String[] T000Q26_A236DetHistMotivo ;
      private bool[] T000Q26_n236DetHistMotivo ;
      private short[] T000Q26_A237DetHistAct ;
      private bool[] T000Q26_n237DetHistAct ;
      private short[] T000Q27_A1EmpID ;
      private short[] T000Q27_A227HistAnio ;
      private short[] T000Q27_A228HistPeriodo ;
      private short[] T000Q27_A36detTipoProdID ;
      private short[] T000Q27_A32categID ;
      private short[] T000Q27_A33subCatID ;
      private int[] T000Q27_A231DetHistNro ;
      private short[] T000Q3_A1EmpID ;
      private short[] T000Q3_A227HistAnio ;
      private short[] T000Q3_A228HistPeriodo ;
      private short[] T000Q3_A36detTipoProdID ;
      private short[] T000Q3_A32categID ;
      private short[] T000Q3_A33subCatID ;
      private int[] T000Q3_A231DetHistNro ;
      private DateTime[] T000Q3_A232DetHistFcha ;
      private bool[] T000Q3_n232DetHistFcha ;
      private decimal[] T000Q3_A233DetHistPrecio ;
      private bool[] T000Q3_n233DetHistPrecio ;
      private DateTime[] T000Q3_A234DetHistFchaApli ;
      private bool[] T000Q3_n234DetHistFchaApli ;
      private String[] T000Q3_A235DetHistObs ;
      private bool[] T000Q3_n235DetHistObs ;
      private String[] T000Q3_A236DetHistMotivo ;
      private bool[] T000Q3_n236DetHistMotivo ;
      private short[] T000Q3_A237DetHistAct ;
      private bool[] T000Q3_n237DetHistAct ;
      private short[] T000Q2_A1EmpID ;
      private short[] T000Q2_A227HistAnio ;
      private short[] T000Q2_A228HistPeriodo ;
      private short[] T000Q2_A36detTipoProdID ;
      private short[] T000Q2_A32categID ;
      private short[] T000Q2_A33subCatID ;
      private int[] T000Q2_A231DetHistNro ;
      private DateTime[] T000Q2_A232DetHistFcha ;
      private bool[] T000Q2_n232DetHistFcha ;
      private decimal[] T000Q2_A233DetHistPrecio ;
      private bool[] T000Q2_n233DetHistPrecio ;
      private DateTime[] T000Q2_A234DetHistFchaApli ;
      private bool[] T000Q2_n234DetHistFchaApli ;
      private String[] T000Q2_A235DetHistObs ;
      private bool[] T000Q2_n235DetHistObs ;
      private String[] T000Q2_A236DetHistMotivo ;
      private bool[] T000Q2_n236DetHistMotivo ;
      private short[] T000Q2_A237DetHistAct ;
      private bool[] T000Q2_n237DetHistAct ;
      private short[] T000Q31_A1EmpID ;
      private short[] T000Q31_A227HistAnio ;
      private short[] T000Q31_A228HistPeriodo ;
      private short[] T000Q31_A36detTipoProdID ;
      private short[] T000Q31_A32categID ;
      private short[] T000Q31_A33subCatID ;
      private int[] T000Q31_A231DetHistNro ;
      private short[] T000Q32_A1EmpID ;
      private short[] T000Q32_A31tipoProdID ;
      private String[] T000Q32_A144tipoProdDsc ;
      private bool[] T000Q32_n144tipoProdDsc ;
      private short[] T000Q33_A1EmpID ;
      private short[] T000Q33_A32categID ;
      private String[] T000Q33_A146categDsc ;
      private bool[] T000Q33_n146categDsc ;
      private short[] T000Q33_A31tipoProdID ;
      private short[] T000Q34_A1EmpID ;
      private short[] T000Q34_A32categID ;
      private short[] T000Q34_A33subCatID ;
      private String[] T000Q34_A148subCatDsc ;
      private bool[] T000Q34_n148subCatDsc ;
      private String[] T000Q35_A44empdsc ;
      private bool[] T000Q35_n44empdsc ;
      private short[] T000Q36_A31tipoProdID ;
      private short[] T000Q37_A31tipoProdID ;
      private String[] T000Q38_A146categDsc ;
      private bool[] T000Q38_n146categDsc ;
      private String[] T000Q39_A148subCatDsc ;
      private bool[] T000Q39_n148subCatDsc ;
      private short[] T000Q10_A31tipoProdID ;
      private SdtTransactionContext AV13TrnContext ;
   }

   public class histprecioprod__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new UpdateCursor(def[26])
         ,new UpdateCursor(def[27])
         ,new UpdateCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new ForEachCursor(def[35])
         ,new ForEachCursor(def[36])
         ,new ForEachCursor(def[37])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000Q10 ;
          prmT000Q10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q11 ;
          prmT000Q11 = new Object[] {
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q6 ;
          prmT000Q6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q8 ;
          prmT000Q8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q9 ;
          prmT000Q9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q12 ;
          prmT000Q12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q7 ;
          prmT000Q7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q13 ;
          prmT000Q13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q14 ;
          prmT000Q14 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q15 ;
          prmT000Q15 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q5 ;
          prmT000Q5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q16 ;
          prmT000Q16 = new Object[] {
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q17 ;
          prmT000Q17 = new Object[] {
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q4 ;
          prmT000Q4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q18 ;
          prmT000Q18 = new Object[] {
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@HistEst",SqlDbType.Char,1,0} ,
          new Object[] {"@HistUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q19 ;
          prmT000Q19 = new Object[] {
          new Object[] {"@detTipoProdDsc",SqlDbType.Char,40,0} ,
          new Object[] {"@HistEst",SqlDbType.Char,1,0} ,
          new Object[] {"@HistUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q20 ;
          prmT000Q20 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q21 ;
          prmT000Q21 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q22 ;
          prmT000Q22 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q23 ;
          prmT000Q23 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q24 ;
          prmT000Q24 = new Object[] {
          new Object[] {"@HistUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q25 ;
          prmT000Q25 = new Object[] {
          } ;
          Object[] prmT000Q26 ;
          prmT000Q26 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DetHistNro",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000Q27 ;
          prmT000Q27 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DetHistNro",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000Q3 ;
          prmT000Q3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DetHistNro",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000Q2 ;
          prmT000Q2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DetHistNro",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000Q28 ;
          prmT000Q28 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DetHistNro",SqlDbType.Int,8,0} ,
          new Object[] {"@DetHistFcha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@DetHistPrecio",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DetHistFchaApli",SqlDbType.DateTime,8,0} ,
          new Object[] {"@DetHistObs",SqlDbType.Char,40,0} ,
          new Object[] {"@DetHistMotivo",SqlDbType.Char,40,0} ,
          new Object[] {"@DetHistAct",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmT000Q29 ;
          prmT000Q29 = new Object[] {
          new Object[] {"@DetHistFcha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@DetHistPrecio",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DetHistFchaApli",SqlDbType.DateTime,8,0} ,
          new Object[] {"@DetHistObs",SqlDbType.Char,40,0} ,
          new Object[] {"@DetHistMotivo",SqlDbType.Char,40,0} ,
          new Object[] {"@DetHistAct",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DetHistNro",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000Q30 ;
          prmT000Q30 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DetHistNro",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000Q31 ;
          prmT000Q31 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HistPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q32 ;
          prmT000Q32 = new Object[] {
          } ;
          Object[] prmT000Q33 ;
          prmT000Q33 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q34 ;
          prmT000Q34 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q35 ;
          prmT000Q35 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q36 ;
          prmT000Q36 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q37 ;
          prmT000Q37 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q38 ;
          prmT000Q38 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000Q39 ;
          prmT000Q39 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000Q2", "SELECT [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID], [DetHistNro], [DetHistFcha], [DetHistPrecio], [DetHistFchaApli], [DetHistObs], [DetHistMotivo], [DetHistAct] FROM [HistPrecioProdLevel1] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID AND [DetHistNro] = @DetHistNro ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q2,1,0,true,false )
             ,new CursorDef("T000Q3", "SELECT [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID], [DetHistNro], [DetHistFcha], [DetHistPrecio], [DetHistFchaApli], [DetHistObs], [DetHistMotivo], [DetHistAct] FROM [HistPrecioProdLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID AND [DetHistNro] = @DetHistNro ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q3,1,0,true,false )
             ,new CursorDef("T000Q4", "SELECT [HistAnio], [HistPeriodo], [detTipoProdDsc], [HistEst], [HistUltNro], [EmpID], [detTipoProdID], [categID], [subCatID] FROM [HistPrecioProd] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q4,1,0,true,false )
             ,new CursorDef("T000Q5", "SELECT [HistAnio], [HistPeriodo], [detTipoProdDsc], [HistEst], [HistUltNro], [EmpID], [detTipoProdID], [categID], [subCatID] FROM [HistPrecioProd] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q5,1,0,true,false )
             ,new CursorDef("T000Q6", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q6,1,0,true,false )
             ,new CursorDef("T000Q7", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @detTipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q7,1,0,true,false )
             ,new CursorDef("T000Q8", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q8,1,0,true,false )
             ,new CursorDef("T000Q9", "SELECT [subCatDsc] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q9,1,0,true,false )
             ,new CursorDef("T000Q10", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q10,1,0,true,false )
             ,new CursorDef("T000Q11", "SELECT TM1.[HistAnio], TM1.[HistPeriodo], T2.[empdsc], TM1.[detTipoProdDsc], T3.[categDsc], T4.[subCatDsc], TM1.[HistEst], TM1.[HistUltNro], TM1.[EmpID], TM1.[detTipoProdID], TM1.[categID], TM1.[subCatID] FROM ((([HistPrecioProd] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Categorias] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[categID] = TM1.[categID]) INNER JOIN [CategoriassubCat] T4 WITH (NOLOCK) ON T4.[EmpID] = TM1.[EmpID] AND T4.[categID] = TM1.[categID] AND T4.[subCatID] = TM1.[subCatID]) WHERE TM1.[HistAnio] = @HistAnio and TM1.[HistPeriodo] = @HistPeriodo and TM1.[EmpID] = @EmpID and TM1.[detTipoProdID] = @detTipoProdID and TM1.[categID] = @categID and TM1.[subCatID] = @subCatID ORDER BY TM1.[EmpID], TM1.[HistAnio], TM1.[HistPeriodo], TM1.[detTipoProdID], TM1.[categID], TM1.[subCatID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q11,100,0,true,false )
             ,new CursorDef("T000Q12", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q12,1,0,true,false )
             ,new CursorDef("T000Q13", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q13,1,0,true,false )
             ,new CursorDef("T000Q14", "SELECT [subCatDsc] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q14,1,0,true,false )
             ,new CursorDef("T000Q15", "SELECT [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID] FROM [HistPrecioProd] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q15,1,0,true,false )
             ,new CursorDef("T000Q16", "SELECT TOP 1 [HistAnio], [HistPeriodo], [EmpID], [detTipoProdID], [categID], [subCatID] FROM [HistPrecioProd] WITH (NOLOCK) WHERE ( [HistAnio] > @HistAnio or [HistAnio] = @HistAnio and [HistPeriodo] > @HistPeriodo or [HistPeriodo] = @HistPeriodo and [HistAnio] = @HistAnio and [EmpID] > @EmpID or [EmpID] = @EmpID and [HistPeriodo] = @HistPeriodo and [HistAnio] = @HistAnio and [detTipoProdID] > @detTipoProdID or [detTipoProdID] = @detTipoProdID and [EmpID] = @EmpID and [HistPeriodo] = @HistPeriodo and [HistAnio] = @HistAnio and [categID] > @categID or [categID] = @categID and [detTipoProdID] = @detTipoProdID and [EmpID] = @EmpID and [HistPeriodo] = @HistPeriodo and [HistAnio] = @HistAnio and [subCatID] > @subCatID) ORDER BY [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q16,1,0,true,true )
             ,new CursorDef("T000Q17", "SELECT TOP 1 [HistAnio], [HistPeriodo], [EmpID], [detTipoProdID], [categID], [subCatID] FROM [HistPrecioProd] WITH (NOLOCK) WHERE ( [HistAnio] < @HistAnio or [HistAnio] = @HistAnio and [HistPeriodo] < @HistPeriodo or [HistPeriodo] = @HistPeriodo and [HistAnio] = @HistAnio and [EmpID] < @EmpID or [EmpID] = @EmpID and [HistPeriodo] = @HistPeriodo and [HistAnio] = @HistAnio and [detTipoProdID] < @detTipoProdID or [detTipoProdID] = @detTipoProdID and [EmpID] = @EmpID and [HistPeriodo] = @HistPeriodo and [HistAnio] = @HistAnio and [categID] < @categID or [categID] = @categID and [detTipoProdID] = @detTipoProdID and [EmpID] = @EmpID and [HistPeriodo] = @HistPeriodo and [HistAnio] = @HistAnio and [subCatID] < @subCatID) ORDER BY [EmpID] DESC, [HistAnio] DESC, [HistPeriodo] DESC, [detTipoProdID] DESC, [categID] DESC, [subCatID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q17,1,0,true,true )
             ,new CursorDef("T000Q18", "INSERT INTO [HistPrecioProd]([HistAnio], [HistPeriodo], [detTipoProdDsc], [HistEst], [HistUltNro], [EmpID], [detTipoProdID], [categID], [subCatID]) VALUES(@HistAnio, @HistPeriodo, @detTipoProdDsc, @HistEst, @HistUltNro, @EmpID, @detTipoProdID, @categID, @subCatID)", GxErrorMask.GX_NOMASK,prmT000Q18)
             ,new CursorDef("T000Q19", "UPDATE [HistPrecioProd] SET [detTipoProdDsc]=@detTipoProdDsc, [HistEst]=@HistEst, [HistUltNro]=@HistUltNro  WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID", GxErrorMask.GX_NOMASK,prmT000Q19)
             ,new CursorDef("T000Q20", "DELETE FROM [HistPrecioProd]  WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID", GxErrorMask.GX_NOMASK,prmT000Q20)
             ,new CursorDef("T000Q21", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q21,1,0,true,false )
             ,new CursorDef("T000Q22", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q22,1,0,true,false )
             ,new CursorDef("T000Q23", "SELECT [subCatDsc] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q23,1,0,true,false )
             ,new CursorDef("T000Q24", "UPDATE [HistPrecioProd] SET [HistUltNro]=@HistUltNro  WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID", GxErrorMask.GX_NOMASK,prmT000Q24)
             ,new CursorDef("T000Q25", "SELECT [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID] FROM [HistPrecioProd] WITH (NOLOCK) ORDER BY [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q25,100,0,true,false )
             ,new CursorDef("T000Q26", "SELECT [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID], [DetHistNro], [DetHistFcha], [DetHistPrecio], [DetHistFchaApli], [DetHistObs], [DetHistMotivo], [DetHistAct] FROM [HistPrecioProdLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [HistAnio] = @HistAnio and [HistPeriodo] = @HistPeriodo and [detTipoProdID] = @detTipoProdID and [categID] = @categID and [subCatID] = @subCatID and [DetHistNro] = @DetHistNro ORDER BY [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID], [DetHistNro] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q26,11,0,true,false )
             ,new CursorDef("T000Q27", "SELECT [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID], [DetHistNro] FROM [HistPrecioProdLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID AND [DetHistNro] = @DetHistNro ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q27,1,0,true,false )
             ,new CursorDef("T000Q28", "INSERT INTO [HistPrecioProdLevel1]([EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID], [DetHistNro], [DetHistFcha], [DetHistPrecio], [DetHistFchaApli], [DetHistObs], [DetHistMotivo], [DetHistAct]) VALUES(@EmpID, @HistAnio, @HistPeriodo, @detTipoProdID, @categID, @subCatID, @DetHistNro, @DetHistFcha, @DetHistPrecio, @DetHistFchaApli, @DetHistObs, @DetHistMotivo, @DetHistAct)", GxErrorMask.GX_NOMASK,prmT000Q28)
             ,new CursorDef("T000Q29", "UPDATE [HistPrecioProdLevel1] SET [DetHistFcha]=@DetHistFcha, [DetHistPrecio]=@DetHistPrecio, [DetHistFchaApli]=@DetHistFchaApli, [DetHistObs]=@DetHistObs, [DetHistMotivo]=@DetHistMotivo, [DetHistAct]=@DetHistAct  WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID AND [DetHistNro] = @DetHistNro", GxErrorMask.GX_NOMASK,prmT000Q29)
             ,new CursorDef("T000Q30", "DELETE FROM [HistPrecioProdLevel1]  WHERE [EmpID] = @EmpID AND [HistAnio] = @HistAnio AND [HistPeriodo] = @HistPeriodo AND [detTipoProdID] = @detTipoProdID AND [categID] = @categID AND [subCatID] = @subCatID AND [DetHistNro] = @DetHistNro", GxErrorMask.GX_NOMASK,prmT000Q30)
             ,new CursorDef("T000Q31", "SELECT [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID], [DetHistNro] FROM [HistPrecioProdLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [HistAnio] = @HistAnio and [HistPeriodo] = @HistPeriodo and [detTipoProdID] = @detTipoProdID and [categID] = @categID and [subCatID] = @subCatID ORDER BY [EmpID], [HistAnio], [HistPeriodo], [detTipoProdID], [categID], [subCatID], [DetHistNro] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q31,11,0,true,false )
             ,new CursorDef("T000Q32", "SELECT [EmpID], [tipoProdID], [tipoProdDsc] FROM [TipoProducto] WITH (NOLOCK) ORDER BY [tipoProdDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q32,0,0,true,false )
             ,new CursorDef("T000Q33", "SELECT [EmpID], [categID], [categDsc], [tipoProdID] FROM [Categorias] WITH (NOLOCK) WHERE ([EmpID] = @EmpID) AND ([tipoProdID] = @detTipoProdID) ORDER BY [categDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q33,0,0,true,false )
             ,new CursorDef("T000Q34", "SELECT [EmpID], [categID], [subCatID], [subCatDsc] FROM [CategoriassubCat] WITH (NOLOCK) WHERE ([EmpID] = @EmpID) AND ([categID] = @categID) ORDER BY [subCatDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q34,0,0,true,false )
             ,new CursorDef("T000Q35", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q35,1,0,true,false )
             ,new CursorDef("T000Q36", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q36,1,0,true,false )
             ,new CursorDef("T000Q37", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @detTipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q37,1,0,true,false )
             ,new CursorDef("T000Q38", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q38,1,0,true,false )
             ,new CursorDef("T000Q39", "SELECT [subCatDsc] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q39,1,0,true,false )
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
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[11])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((String[]) buf[13])[0] = rslt.getString(11, 40) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((String[]) buf[15])[0] = rslt.getString(12, 40) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                ((short[]) buf[17])[0] = rslt.getShort(13) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(13);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[11])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((String[]) buf[13])[0] = rslt.getString(11, 40) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((String[]) buf[15])[0] = rslt.getString(12, 40) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                ((short[]) buf[17])[0] = rslt.getShort(13) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(13);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((int[]) buf[5])[0] = rslt.getInt(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((int[]) buf[5])[0] = rslt.getInt(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 40) ;
                ((String[]) buf[5])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getString(6, 40) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((String[]) buf[9])[0] = rslt.getString(7, 1) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((int[]) buf[11])[0] = rslt.getInt(8) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                ((short[]) buf[14])[0] = rslt.getShort(10) ;
                ((short[]) buf[15])[0] = rslt.getShort(11) ;
                ((short[]) buf[16])[0] = rslt.getShort(12) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 24 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[11])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((String[]) buf[13])[0] = rslt.getString(11, 40) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((String[]) buf[15])[0] = rslt.getString(12, 40) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                ((short[]) buf[17])[0] = rslt.getShort(13) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(13);
                return;
             case 25 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                return;
             case 29 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                return;
       }
       getresults30( cursor, rslt, buf) ;
    }

    public void getresults30( int cursor ,
                              IFieldGetter rslt ,
                              Object[] buf )
    {
       switch ( cursor )
       {
             case 30 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 31 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                return;
             case 32 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                return;
             case 33 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 34 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 35 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 36 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 37 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
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
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (short)parms[9]);
                stmt.SetParameter(9, (short)parms[10]);
                return;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
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
                   stmt.setNull( 3 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(3, (int)parms[4]);
                }
                stmt.SetParameter(4, (short)parms[5]);
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (short)parms[9]);
                stmt.SetParameter(9, (short)parms[10]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 22 :
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
                stmt.SetParameter(6, (short)parms[6]);
                stmt.SetParameter(7, (short)parms[7]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(8, (DateTime)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (decimal)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(10, (DateTime)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 11 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 12 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 13 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(13, (short)parms[18]);
                }
                return;
             case 27 :
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
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[11]);
                }
                stmt.SetParameter(7, (short)parms[12]);
                stmt.SetParameter(8, (short)parms[13]);
                stmt.SetParameter(9, (short)parms[14]);
                stmt.SetParameter(10, (short)parms[15]);
                stmt.SetParameter(11, (short)parms[16]);
                stmt.SetParameter(12, (short)parms[17]);
                stmt.SetParameter(13, (int)parms[18]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                return;
             case 29 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 31 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 32 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 33 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 34 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 35 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 36 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 37 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
