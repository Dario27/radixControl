/*
               File: ProdxBodega
        Description: Prodx Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/29/2022 1:7:37.0
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
   public class prodxbodega : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"AGEID") == 0 )
         {
            AV9EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9EmpID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAAGEID0U82( AV9EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_31") == 0 )
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
            gxLoad_31( A1EmpID, A2AgeID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_32") == 0 )
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
            gxLoad_32( A1EmpID, A42BodCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_33") == 0 )
         {
            A43TipoInv = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_33( A43TipoInv) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_34") == 0 )
         {
            A290stockAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
            A291stockMes = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A43TipoInv = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_34( A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_35") == 0 )
         {
            A290stockAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
            A291stockMes = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A43TipoInv = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_35( A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_37") == 0 )
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
            gxLoad_37( A1EmpID, A2AgeID, A286PrdCod) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridprodxbodega_tipo") == 0 )
         {
            nRC_GXsfl_101 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_101_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_101_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridprodxbodega_tipo_newrow( ) ;
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
               AV7stockAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7stockAnio), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSTOCKANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7stockAnio), "ZZZ9"), context));
               AV8stockMes = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8stockMes), 2, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSTOCKMES", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8stockMes), "Z9"), context));
               AV9EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9EmpID), "ZZZ9"), context));
               AV10AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10AgeID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10AgeID), "ZZZ9"), context));
               AV12BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12BodCod), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBODCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BodCod), "ZZZ9"), context));
               AV19tipoInv = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19tipoInv", AV19tipoInv);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTIPOINV", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19tipoInv, "")), context));
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
            Form.Meta.addItem("description", "Prodx Bodega", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = dynEmpID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public prodxbodega( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prodxbodega( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_stockAnio ,
                           short aP2_stockMes ,
                           short aP3_EmpID ,
                           short aP4_AgeID ,
                           short aP5_BodCod ,
                           String aP6_tipoInv )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7stockAnio = aP1_stockAnio;
         this.AV8stockMes = aP2_stockMes;
         this.AV9EmpID = aP3_EmpID;
         this.AV10AgeID = aP4_AgeID;
         this.AV12BodCod = aP5_BodCod;
         this.AV19tipoInv = aP6_tipoInv;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynEmpID = new GXCombobox();
         dynAgeID = new GXCombobox();
         cmbstockMes = new GXCombobox();
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
         if ( dynEmpID.ItemCount > 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( dynEmpID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynEmpID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Values", dynEmpID.ToJavascriptSource(), true);
         }
         if ( dynAgeID.ItemCount > 0 )
         {
            A2AgeID = (short)(NumberUtil.Val( dynAgeID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A2AgeID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynAgeID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A2AgeID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Values", dynAgeID.ToJavascriptSource(), true);
         }
         if ( cmbstockMes.ItemCount > 0 )
         {
            A291stockMes = (short)(NumberUtil.Val( cmbstockMes.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A291stockMes), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbstockMes.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A291stockMes), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbstockMes_Internalname, "Values", cmbstockMes.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Prodx Bodega", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_ProdxBodega.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx02a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"STOCKANIO"+"'), id:'"+"STOCKANIO"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"STOCKMES"+"'), id:'"+"STOCKMES"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"BODCOD"+"'), id:'"+"BODCOD"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"TIPOINV"+"'), id:'"+"TIPOINV"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_ProdxBodega.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynEmpID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynEmpID_Internalname, "Empresa", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynEmpID, dynEmpID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)), 1, dynEmpID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynEmpID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "", true, "HLP_ProdxBodega.htm");
            dynEmpID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Values", (String)(dynEmpID.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection2_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynAgeID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynAgeID_Internalname, "Agencia", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynAgeID, dynAgeID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)), 1, dynAgeID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynAgeID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "", true, "HLP_ProdxBodega.htm");
            dynAgeID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A2AgeID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Values", (String)(dynAgeID.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection3_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtstockAnio_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtstockAnio_Internalname, "Anio", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtstockAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A290stockAnio), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A290stockAnio), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstockAnio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtstockAnio_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection4_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbstockMes_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbstockMes_Internalname, "Mes", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbstockMes, cmbstockMes_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)), 1, cmbstockMes_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbstockMes.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "", true, "HLP_ProdxBodega.htm");
            cmbstockMes.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A291stockMes), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbstockMes_Internalname, "Values", (String)(cmbstockMes.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-5 FormCellFields", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBodCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodCod_Internalname, "Bodega", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBodCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodCod_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_ProdxBodega.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_42_Internalname, sImgUrl, imgprompt_1_42_Link, "", "", context.GetTheme( ), imgprompt_1_42_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-7 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBodDsc_Internalname, "Nombre", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBodDsc_Internalname, StringUtil.RTrim( A217BodDsc), StringUtil.RTrim( context.localUtil.Format( A217BodDsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-5 FormCellFields", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTipoInv_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtTipoInv_Internalname, "Tipo Inv.", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtTipoInv_Internalname, StringUtil.RTrim( A43TipoInv), StringUtil.RTrim( context.localUtil.Format( A43TipoInv, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTipoInv_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTipoInv_Enabled, 1, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdxBodega.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_43_Internalname, sImgUrl, imgprompt_43_Link, "", "", context.GetTheme( ), imgprompt_43_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-7 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtTipoInvMov_Internalname, "Tipo Movimiento", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtTipoInvMov_Internalname, A219TipoInvMov, StringUtil.RTrim( context.localUtil.Format( A219TipoInvMov, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTipoInvMov_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTipoInvMov_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtprdStockDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtprdStockDsc_Internalname, "Descripcion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtprdStockDsc_Internalname, A307prdStockDsc, StringUtil.RTrim( context.localUtil.Format( A307prdStockDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprdStockDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtprdStockDsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtstockBod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtstockBod_Internalname, "Stock Bodega", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtstockBod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A292stockBod), 4, 0, ",", "")), ((edtstockBod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A292stockBod), "ZZZ9")) : context.localUtil.Format( (decimal)(A292stockBod), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstockBod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtstockBod_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtinvFisico_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtinvFisico_Internalname, "Inv. Fisico", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtinvFisico_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A293invFisico), 9, 0, ",", "")), ((edtinvFisico_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A293invFisico), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A293invFisico), "ZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtinvFisico_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtinvFisico_Enabled, 0, "number", "1", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection5_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtingBod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtingBod_Internalname, "Ingresos Bodega", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtingBod_Internalname, StringUtil.LTrim( StringUtil.NToC( A294ingBod, 9, 2, ",", "")), ((edtingBod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A294ingBod, "ZZZZZ9.99")) : context.localUtil.Format( A294ingBod, "ZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtingBod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtingBod_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection6_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtegrBod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtegrBod_Internalname, "Salidas Bodega", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtegrBod_Internalname, StringUtil.LTrim( StringUtil.NToC( A295egrBod, 9, 2, ",", "")), ((edtegrBod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A295egrBod, "ZZZZZ9.99")) : context.localUtil.Format( A295egrBod, "ZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtegrBod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtegrBod_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdxBodega.htm");
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
            GxWebStd.gx_div_start( context, divTipotable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitletipo_Internalname, "Tipo", "", "", lblTitletipo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridprodxbodega_tipo( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 117,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdxBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0U82( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridprodxbodega_tipo( )
      {
         /*  Grid Control  */
         Gridprodxbodega_tipoContainer.AddObjectProperty("GridName", "Gridprodxbodega_tipo");
         Gridprodxbodega_tipoContainer.AddObjectProperty("Header", subGridprodxbodega_tipo_Header);
         Gridprodxbodega_tipoContainer.AddObjectProperty("Class", "Grid");
         Gridprodxbodega_tipoContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Backcolorstyle), 1, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("CmpContext", "");
         Gridprodxbodega_tipoContainer.AddObjectProperty("InMasterPage", "false");
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A348stockDetID), 4, 0, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetID_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", A309prdNombre);
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A296cantidad, 9, 2, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidad_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A297stock, 9, 2, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstock_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A298costo, 13, 2, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcosto_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A299costUni, 13, 2, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcostUni_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A300ingTipo), 9, 0, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipo_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A301egrTipo), 9, 0, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtegrTipo_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Selectedindex), 4, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Allowselection), 1, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Selectioncolor), 9, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Allowhovering), 1, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Hoveringcolor), 9, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Allowcollapsing), 1, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Collapsed), 1, 0, ".", "")));
         nGXsfl_101_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount83 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_83 = 1;
               ScanStart0U83( ) ;
               while ( RcdFound83 != 0 )
               {
                  init_level_properties83( ) ;
                  getByPrimaryKey0U83( ) ;
                  AddRow0U83( ) ;
                  ScanNext0U83( ) ;
               }
               ScanEnd0U83( ) ;
               nBlankRcdCount83 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B295egrBod = A295egrBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            B294ingBod = A294ingBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            standaloneNotModal0U83( ) ;
            standaloneModal0U83( ) ;
            sMode83 = Gx_mode;
            while ( nGXsfl_101_idx < nRC_GXsfl_101 )
            {
               bGXsfl_101_Refreshing = true;
               ReadRow0U83( ) ;
               edtstockDetID_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCKDETID_"+sGXsfl_101_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetID_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
               edtPrdCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDCOD_"+sGXsfl_101_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
               edtprdNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDNOMBRE_"+sGXsfl_101_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdNombre_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
               edtcantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTIDAD_"+sGXsfl_101_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcantidad_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
               edtstock_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCK_"+sGXsfl_101_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstock_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
               edtcosto_Enabled = (int)(context.localUtil.CToN( cgiGet( "COSTO_"+sGXsfl_101_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcosto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcosto_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
               edtcostUni_Enabled = (int)(context.localUtil.CToN( cgiGet( "COSTUNI_"+sGXsfl_101_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcostUni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcostUni_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
               edtingTipo_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGTIPO_"+sGXsfl_101_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipo_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
               edtegrTipo_Enabled = (int)(context.localUtil.CToN( cgiGet( "EGRTIPO_"+sGXsfl_101_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtegrTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtegrTipo_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
               imgprompt_1_42_Link = cgiGet( "PROMPT_286_"+sGXsfl_101_idx+"Link");
               if ( ( nRcdExists_83 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0U83( ) ;
               }
               SendRow0U83( ) ;
               bGXsfl_101_Refreshing = false;
            }
            Gx_mode = sMode83;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A295egrBod = B295egrBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            A294ingBod = B294ingBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount83 = 5;
            nRcdExists_83 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0U83( ) ;
               while ( RcdFound83 != 0 )
               {
                  sGXsfl_101_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_101_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_10183( ) ;
                  init_level_properties83( ) ;
                  standaloneNotModal0U83( ) ;
                  getByPrimaryKey0U83( ) ;
                  standaloneModal0U83( ) ;
                  AddRow0U83( ) ;
                  ScanNext0U83( ) ;
               }
               ScanEnd0U83( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode83 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_101_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_101_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_10183( ) ;
            InitAll0U83( ) ;
            init_level_properties83( ) ;
            B295egrBod = A295egrBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            B294ingBod = A294ingBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            standaloneNotModal0U83( ) ;
            standaloneModal0U83( ) ;
            nRcdExists_83 = 0;
            nIsMod_83 = 0;
            nRcdDeleted_83 = 0;
            nBlankRcdCount83 = (short)(nBlankRcdUsr83+nBlankRcdCount83);
            fRowAdded = 0;
            while ( nBlankRcdCount83 > 0 )
            {
               AddRow0U83( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtstockDetID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount83 = (short)(nBlankRcdCount83-1);
            }
            Gx_mode = sMode83;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A295egrBod = B295egrBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            A294ingBod = B294ingBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridprodxbodega_tipoContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridprodxbodega_tipo", Gridprodxbodega_tipoContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridprodxbodega_tipoContainerData", Gridprodxbodega_tipoContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridprodxbodega_tipoContainerData"+"V", Gridprodxbodega_tipoContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridprodxbodega_tipoContainerData"+"V"+"\" value='"+Gridprodxbodega_tipoContainer.GridValuesHidden()+"'/>") ;
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
         E110U2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               dynEmpID.Name = dynEmpID_Internalname;
               dynEmpID.CurrentValue = cgiGet( dynEmpID_Internalname);
               A1EmpID = (short)(NumberUtil.Val( cgiGet( dynEmpID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               dynAgeID.Name = dynAgeID_Internalname;
               dynAgeID.CurrentValue = cgiGet( dynAgeID_Internalname);
               A2AgeID = (short)(NumberUtil.Val( cgiGet( dynAgeID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtstockAnio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtstockAnio_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "STOCKANIO");
                  AnyError = 1;
                  GX_FocusControl = edtstockAnio_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A290stockAnio = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
               }
               else
               {
                  A290stockAnio = (short)(context.localUtil.CToN( cgiGet( edtstockAnio_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
               }
               cmbstockMes.Name = cmbstockMes_Internalname;
               cmbstockMes.CurrentValue = cgiGet( cmbstockMes_Internalname);
               A291stockMes = (short)(NumberUtil.Val( cgiGet( cmbstockMes_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
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
               A43TipoInv = cgiGet( edtTipoInv_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
               A219TipoInvMov = cgiGet( edtTipoInvMov_Internalname);
               n219TipoInvMov = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
               A307prdStockDsc = cgiGet( edtprdStockDsc_Internalname);
               n307prdStockDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307prdStockDsc", A307prdStockDsc);
               n307prdStockDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A307prdStockDsc)) ? true : false);
               A292stockBod = (short)(context.localUtil.CToN( cgiGet( edtstockBod_Internalname), ",", "."));
               n292stockBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtinvFisico_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtinvFisico_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "INVFISICO");
                  AnyError = 1;
                  GX_FocusControl = edtinvFisico_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A293invFisico = 0;
                  n293invFisico = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293invFisico", StringUtil.LTrim( StringUtil.Str( (decimal)(A293invFisico), 9, 0)));
               }
               else
               {
                  A293invFisico = (int)(context.localUtil.CToN( cgiGet( edtinvFisico_Internalname), ",", "."));
                  n293invFisico = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293invFisico", StringUtil.LTrim( StringUtil.Str( (decimal)(A293invFisico), 9, 0)));
               }
               n293invFisico = ((0==A293invFisico) ? true : false);
               A294ingBod = context.localUtil.CToN( cgiGet( edtingBod_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               A295egrBod = context.localUtil.CToN( cgiGet( edtegrBod_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               /* Read saved values. */
               Z290stockAnio = (short)(context.localUtil.CToN( cgiGet( "Z290stockAnio"), ",", "."));
               Z291stockMes = (short)(context.localUtil.CToN( cgiGet( "Z291stockMes"), ",", "."));
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z2AgeID = (short)(context.localUtil.CToN( cgiGet( "Z2AgeID"), ",", "."));
               Z42BodCod = (short)(context.localUtil.CToN( cgiGet( "Z42BodCod"), ",", "."));
               Z43TipoInv = cgiGet( "Z43TipoInv");
               Z307prdStockDsc = cgiGet( "Z307prdStockDsc");
               n307prdStockDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A307prdStockDsc)) ? true : false);
               Z293invFisico = (int)(context.localUtil.CToN( cgiGet( "Z293invFisico"), ",", "."));
               n293invFisico = ((0==A293invFisico) ? true : false);
               O295egrBod = context.localUtil.CToN( cgiGet( "O295egrBod"), ",", ".");
               O294ingBod = context.localUtil.CToN( cgiGet( "O294ingBod"), ",", ".");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_101 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_101"), ",", "."));
               N43TipoInv = cgiGet( "N43TipoInv");
               AV7stockAnio = (short)(context.localUtil.CToN( cgiGet( "vSTOCKANIO"), ",", "."));
               AV8stockMes = (short)(context.localUtil.CToN( cgiGet( "vSTOCKMES"), ",", "."));
               AV20mes = (short)(context.localUtil.CToN( cgiGet( "vMES"), ",", "."));
               AV9EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV10AgeID = (short)(context.localUtil.CToN( cgiGet( "vAGEID"), ",", "."));
               AV12BodCod = (short)(context.localUtil.CToN( cgiGet( "vBODCOD"), ",", "."));
               AV18Insert_TipoInv = cgiGet( "vINSERT_TIPOINV");
               AV19tipoInv = cgiGet( "vTIPOINV");
               A223TipoInvSigno = (short)(context.localUtil.CToN( cgiGet( "TIPOINVSIGNO"), ",", "."));
               n223TipoInvSigno = false;
               AV21Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "ProdxBodega";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV18Insert_TipoInv, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A290stockAnio != Z290stockAnio ) || ( A291stockMes != Z291stockMes ) || ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( StringUtil.StrCmp(A43TipoInv, Z43TipoInv) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("prodxbodega:[SecurityCheckFailed value for]"+"Insert_TipoInv:"+StringUtil.RTrim( context.localUtil.Format( AV18Insert_TipoInv, "")));
                  GXUtil.WriteLog("prodxbodega:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A290stockAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
                  A291stockMes = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
                  A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A42BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
                  A43TipoInv = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
                  getEqualNoModal( ) ;
                  GXAAGEID_html0U82( AV9EmpID) ;
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
                     sMode82 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     GXAAGEID_html0U82( AV9EmpID) ;
                     Gx_mode = sMode82;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound82 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0U0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "STOCKANIO");
                        AnyError = 1;
                        GX_FocusControl = edtstockAnio_Internalname;
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
                        E110U2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120U2 ();
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
            E120U2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0U82( ) ;
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
            DisableAttributes0U82( ) ;
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

      protected void CONFIRM_0U0( )
      {
         BeforeValidate0U82( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0U82( ) ;
            }
            else
            {
               CheckExtendedTable0U82( ) ;
               CloseExtendedTableCursors0U82( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode82 = Gx_mode;
            CONFIRM_0U83( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode82;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode82;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0U83( )
      {
         s295egrBod = O295egrBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         s294ingBod = O294ingBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         nGXsfl_101_idx = 0;
         while ( nGXsfl_101_idx < nRC_GXsfl_101 )
         {
            ReadRow0U83( ) ;
            if ( ( nRcdExists_83 != 0 ) || ( nIsMod_83 != 0 ) )
            {
               GetKey0U83( ) ;
               if ( ( nRcdExists_83 == 0 ) && ( nRcdDeleted_83 == 0 ) )
               {
                  if ( RcdFound83 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0U83( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0U83( ) ;
                        CloseExtendedTableCursors0U83( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O295egrBod = A295egrBod;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                        O294ingBod = A294ingBod;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                     }
                  }
                  else
                  {
                     GXCCtl = "STOCKDETID_" + sGXsfl_101_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtstockDetID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound83 != 0 )
                  {
                     if ( nRcdDeleted_83 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0U83( ) ;
                        Load0U83( ) ;
                        BeforeValidate0U83( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0U83( ) ;
                           O295egrBod = A295egrBod;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                           O294ingBod = A294ingBod;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_83 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0U83( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0U83( ) ;
                              CloseExtendedTableCursors0U83( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O295egrBod = A295egrBod;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                              O294ingBod = A294ingBod;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_83 == 0 )
                     {
                        GXCCtl = "STOCKDETID_" + sGXsfl_101_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtstockDetID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtstockDetID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A348stockDetID), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtprdNombre_Internalname, A309prdNombre) ;
            ChangePostValue( edtcantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A296cantidad, 9, 2, ",", ""))) ;
            ChangePostValue( edtstock_Internalname, StringUtil.LTrim( StringUtil.NToC( A297stock, 9, 2, ",", ""))) ;
            ChangePostValue( edtcosto_Internalname, StringUtil.LTrim( StringUtil.NToC( A298costo, 13, 2, ",", ""))) ;
            ChangePostValue( edtcostUni_Internalname, StringUtil.LTrim( StringUtil.NToC( A299costUni, 13, 2, ",", ""))) ;
            ChangePostValue( edtingTipo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A300ingTipo), 9, 0, ",", ""))) ;
            ChangePostValue( edtegrTipo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A301egrTipo), 9, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z348stockDetID_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z348stockDetID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z296cantidad_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( Z296cantidad, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z297stock_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( Z297stock, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z298costo_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( Z298costo, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( "T301egrTipo_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(O301egrTipo), 9, 0, ",", ""))) ;
            ChangePostValue( "T300ingTipo_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(O300ingTipo), 9, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_83_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_83), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_83_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_83), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_83_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_83), 4, 0, ",", ""))) ;
            if ( nIsMod_83 != 0 )
            {
               ChangePostValue( "STOCKDETID_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDCOD_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDNOMBRE_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTIDAD_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "STOCK_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstock_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COSTO_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcosto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COSTUNI_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcostUni_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGTIPO_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EGRTIPO_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtegrTipo_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O295egrBod = s295egrBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         O294ingBod = s294ingBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0U0( )
      {
      }

      protected void E110U2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV21Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV21Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV14TrnContext.FromXml(AV15WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV18Insert_TipoInv = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Insert_TipoInv", AV18Insert_TipoInv);
         if ( ( StringUtil.StrCmp(AV14TrnContext.gxTpr_Transactionname, AV21Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV22GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22GXV1), 8, 0)));
            while ( AV22GXV1 <= AV14TrnContext.gxTpr_Attributes.Count )
            {
               AV17TrnContextAtt = ((SdtTransactionContext_Attribute)AV14TrnContext.gxTpr_Attributes.Item(AV22GXV1));
               if ( StringUtil.StrCmp(AV17TrnContextAtt.gxTpr_Attributename, "TipoInv") == 0 )
               {
                  AV18Insert_TipoInv = AV17TrnContextAtt.gxTpr_Attributevalue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Insert_TipoInv", AV18Insert_TipoInv);
               }
               AV22GXV1 = (int)(AV22GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22GXV1), 8, 0)));
            }
         }
      }

      protected void E120U2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV14TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwprodxbodega.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0U82( short GX_JID )
      {
         if ( ( GX_JID == 30 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z307prdStockDsc = T000U6_A307prdStockDsc[0];
               Z293invFisico = T000U6_A293invFisico[0];
            }
            else
            {
               Z307prdStockDsc = A307prdStockDsc;
               Z293invFisico = A293invFisico;
            }
         }
         if ( GX_JID == -30 )
         {
            Z290stockAnio = A290stockAnio;
            Z291stockMes = A291stockMes;
            Z307prdStockDsc = A307prdStockDsc;
            Z293invFisico = A293invFisico;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z43TipoInv = A43TipoInv;
            Z217BodDsc = A217BodDsc;
            Z219TipoInvMov = A219TipoInvMov;
            Z223TipoInvSigno = A223TipoInvSigno;
            Z292stockBod = A292stockBod;
            Z294ingBod = A294ingBod;
            Z295egrBod = A295egrBod;
         }
      }

      protected void standaloneNotModal( )
      {
         AV20mes = (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20mes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20mes), 2, 0)));
         imgprompt_1_42_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00y0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"BODCOD"+"'), id:'"+"BODCOD"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_43_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0100.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TIPOINV"+"'), id:'"+"TIPOINV"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7stockAnio) )
         {
            A290stockAnio = AV7stockAnio;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
         }
         if ( ! (0==AV7stockAnio) )
         {
            edtstockAnio_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockAnio_Enabled), 5, 0)), true);
         }
         else
         {
            edtstockAnio_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockAnio_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7stockAnio) )
         {
            edtstockAnio_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockAnio_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8stockMes) )
         {
            A291stockMes = AV8stockMes;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
         }
         else
         {
            A291stockMes = AV20mes;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
         }
         if ( ! (0==AV8stockMes) )
         {
            cmbstockMes.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbstockMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbstockMes.Enabled), 5, 0)), true);
         }
         else
         {
            cmbstockMes.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbstockMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbstockMes.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8stockMes) )
         {
            cmbstockMes.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbstockMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbstockMes.Enabled), 5, 0)), true);
         }
         GXAAGEID_html0U82( AV9EmpID) ;
         if ( ! (0==AV9EmpID) )
         {
            A1EmpID = AV9EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( ! (0==AV9EmpID) )
         {
            dynEmpID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         }
         else
         {
            dynEmpID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV9EmpID) )
         {
            dynEmpID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10AgeID) )
         {
            A2AgeID = AV10AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         }
         if ( ! (0==AV10AgeID) )
         {
            dynAgeID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
         }
         else
         {
            dynAgeID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10AgeID) )
         {
            dynAgeID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV12BodCod) )
         {
            A42BodCod = AV12BodCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         }
         if ( ! (0==AV12BodCod) )
         {
            edtBodCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtBodCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV12BodCod) )
         {
            edtBodCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV18Insert_TipoInv)) )
         {
            A43TipoInv = AV18Insert_TipoInv;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         }
         else
         {
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19tipoInv)) )
            {
               A43TipoInv = AV19tipoInv;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV18Insert_TipoInv)) )
         {
            edtTipoInv_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), true);
         }
         else
         {
            edtTipoInv_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), true);
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
            AV21Pgmname = "ProdxBodega";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Pgmname", AV21Pgmname);
            /* Using cursor T000U8 */
            pr_default.execute(6, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = T000U8_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000U8_n217BodDsc[0];
            pr_default.close(6);
            /* Using cursor T000U9 */
            pr_default.execute(7, new Object[] {A43TipoInv});
            A219TipoInvMov = T000U9_A219TipoInvMov[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
            n219TipoInvMov = T000U9_n219TipoInvMov[0];
            A223TipoInvSigno = T000U9_A223TipoInvSigno[0];
            n223TipoInvSigno = T000U9_n223TipoInvSigno[0];
            pr_default.close(7);
            /* Using cursor T000U11 */
            pr_default.execute(8, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
            if ( (pr_default.getStatus(8) != 101) )
            {
               A292stockBod = T000U11_A292stockBod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
               n292stockBod = T000U11_n292stockBod[0];
            }
            else
            {
               A292stockBod = 0;
               n292stockBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
            }
            pr_default.close(8);
            /* Using cursor T000U13 */
            pr_default.execute(9, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
            if ( (pr_default.getStatus(9) != 101) )
            {
               A294ingBod = T000U13_A294ingBod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               A295egrBod = T000U13_A295egrBod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            else
            {
               A294ingBod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               A295egrBod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            O294ingBod = A294ingBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            O295egrBod = A295egrBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            pr_default.close(9);
         }
      }

      protected void Load0U82( )
      {
         /* Using cursor T000U16 */
         pr_default.execute(10, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound82 = 1;
            A217BodDsc = T000U16_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000U16_n217BodDsc[0];
            A219TipoInvMov = T000U16_A219TipoInvMov[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
            n219TipoInvMov = T000U16_n219TipoInvMov[0];
            A223TipoInvSigno = T000U16_A223TipoInvSigno[0];
            n223TipoInvSigno = T000U16_n223TipoInvSigno[0];
            A307prdStockDsc = T000U16_A307prdStockDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307prdStockDsc", A307prdStockDsc);
            n307prdStockDsc = T000U16_n307prdStockDsc[0];
            A293invFisico = T000U16_A293invFisico[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293invFisico", StringUtil.LTrim( StringUtil.Str( (decimal)(A293invFisico), 9, 0)));
            n293invFisico = T000U16_n293invFisico[0];
            A292stockBod = T000U16_A292stockBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
            n292stockBod = T000U16_n292stockBod[0];
            A294ingBod = T000U16_A294ingBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            A295egrBod = T000U16_A295egrBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            ZM0U82( -30) ;
         }
         pr_default.close(10);
         OnLoadActions0U82( ) ;
      }

      protected void OnLoadActions0U82( )
      {
         O295egrBod = A295egrBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         O294ingBod = A294ingBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         AV21Pgmname = "ProdxBodega";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Pgmname", AV21Pgmname);
      }

      protected void CheckExtendedTable0U82( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV21Pgmname = "ProdxBodega";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Pgmname", AV21Pgmname);
         /* Using cursor T000U7 */
         pr_default.execute(5, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(5);
         /* Using cursor T000U8 */
         pr_default.execute(6, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A217BodDsc = T000U8_A217BodDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = T000U8_n217BodDsc[0];
         pr_default.close(6);
         /* Using cursor T000U9 */
         pr_default.execute(7, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, "TIPOINV");
            AnyError = 1;
            GX_FocusControl = edtTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A219TipoInvMov = T000U9_A219TipoInvMov[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
         n219TipoInvMov = T000U9_n219TipoInvMov[0];
         A223TipoInvSigno = T000U9_A223TipoInvSigno[0];
         n223TipoInvSigno = T000U9_n223TipoInvSigno[0];
         pr_default.close(7);
         /* Using cursor T000U11 */
         pr_default.execute(8, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(8) != 101) )
         {
            A292stockBod = T000U11_A292stockBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
            n292stockBod = T000U11_n292stockBod[0];
         }
         else
         {
            A292stockBod = 0;
            n292stockBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
         }
         pr_default.close(8);
         /* Using cursor T000U13 */
         pr_default.execute(9, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(9) != 101) )
         {
            A294ingBod = T000U13_A294ingBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            A295egrBod = T000U13_A295egrBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         }
         else
         {
            A294ingBod = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            A295egrBod = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         }
         pr_default.close(9);
      }

      protected void CloseExtendedTableCursors0U82( )
      {
         pr_default.close(5);
         pr_default.close(6);
         pr_default.close(7);
         pr_default.close(8);
         pr_default.close(9);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_31( short A1EmpID ,
                                short A2AgeID )
      {
         /* Using cursor T000U17 */
         pr_default.execute(11, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
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
                                short A42BodCod )
      {
         /* Using cursor T000U18 */
         pr_default.execute(12, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A217BodDsc = T000U18_A217BodDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = T000U18_n217BodDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A217BodDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(12);
      }

      protected void gxLoad_33( String A43TipoInv )
      {
         /* Using cursor T000U19 */
         pr_default.execute(13, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, "TIPOINV");
            AnyError = 1;
            GX_FocusControl = edtTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A219TipoInvMov = T000U19_A219TipoInvMov[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
         n219TipoInvMov = T000U19_n219TipoInvMov[0];
         A223TipoInvSigno = T000U19_A223TipoInvSigno[0];
         n223TipoInvSigno = T000U19_n223TipoInvSigno[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A219TipoInvMov)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(13) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(13);
      }

      protected void gxLoad_34( short A290stockAnio ,
                                short A291stockMes ,
                                short A1EmpID ,
                                short A2AgeID ,
                                short A42BodCod ,
                                String A43TipoInv )
      {
         /* Using cursor T000U21 */
         pr_default.execute(14, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(14) != 101) )
         {
            A292stockBod = T000U21_A292stockBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
            n292stockBod = T000U21_n292stockBod[0];
         }
         else
         {
            A292stockBod = 0;
            n292stockBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A292stockBod), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(14) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(14);
      }

      protected void gxLoad_35( short A290stockAnio ,
                                short A291stockMes ,
                                short A1EmpID ,
                                short A2AgeID ,
                                short A42BodCod ,
                                String A43TipoInv )
      {
         /* Using cursor T000U23 */
         pr_default.execute(15, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(15) != 101) )
         {
            A294ingBod = T000U23_A294ingBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            A295egrBod = T000U23_A295egrBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         }
         else
         {
            A294ingBod = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            A295egrBod = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A294ingBod, 9, 2, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A295egrBod, 9, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(15) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(15);
      }

      protected void GetKey0U82( )
      {
         /* Using cursor T000U24 */
         pr_default.execute(16, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound82 = 1;
         }
         else
         {
            RcdFound82 = 0;
         }
         pr_default.close(16);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000U6 */
         pr_default.execute(4, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM0U82( 30) ;
            RcdFound82 = 1;
            A290stockAnio = T000U6_A290stockAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
            A291stockMes = T000U6_A291stockMes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
            A307prdStockDsc = T000U6_A307prdStockDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307prdStockDsc", A307prdStockDsc);
            n307prdStockDsc = T000U6_n307prdStockDsc[0];
            A293invFisico = T000U6_A293invFisico[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293invFisico", StringUtil.LTrim( StringUtil.Str( (decimal)(A293invFisico), 9, 0)));
            n293invFisico = T000U6_n293invFisico[0];
            A1EmpID = T000U6_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000U6_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = T000U6_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A43TipoInv = T000U6_A43TipoInv[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            Z290stockAnio = A290stockAnio;
            Z291stockMes = A291stockMes;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z43TipoInv = A43TipoInv;
            sMode82 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0U82( ) ;
            if ( AnyError == 1 )
            {
               RcdFound82 = 0;
               InitializeNonKey0U82( ) ;
            }
            Gx_mode = sMode82;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound82 = 0;
            InitializeNonKey0U82( ) ;
            sMode82 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode82;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey0U82( ) ;
         if ( RcdFound82 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound82 = 0;
         /* Using cursor T000U25 */
         pr_default.execute(17, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(17) != 101) )
         {
            while ( (pr_default.getStatus(17) != 101) && ( ( T000U25_A290stockAnio[0] < A290stockAnio ) || ( T000U25_A290stockAnio[0] == A290stockAnio ) && ( T000U25_A291stockMes[0] < A291stockMes ) || ( T000U25_A291stockMes[0] == A291stockMes ) && ( T000U25_A290stockAnio[0] == A290stockAnio ) && ( T000U25_A1EmpID[0] < A1EmpID ) || ( T000U25_A1EmpID[0] == A1EmpID ) && ( T000U25_A291stockMes[0] == A291stockMes ) && ( T000U25_A290stockAnio[0] == A290stockAnio ) && ( T000U25_A2AgeID[0] < A2AgeID ) || ( T000U25_A2AgeID[0] == A2AgeID ) && ( T000U25_A1EmpID[0] == A1EmpID ) && ( T000U25_A291stockMes[0] == A291stockMes ) && ( T000U25_A290stockAnio[0] == A290stockAnio ) && ( T000U25_A42BodCod[0] < A42BodCod ) || ( T000U25_A42BodCod[0] == A42BodCod ) && ( T000U25_A2AgeID[0] == A2AgeID ) && ( T000U25_A1EmpID[0] == A1EmpID ) && ( T000U25_A291stockMes[0] == A291stockMes ) && ( T000U25_A290stockAnio[0] == A290stockAnio ) && ( StringUtil.StrCmp(T000U25_A43TipoInv[0], A43TipoInv) < 0 ) ) )
            {
               pr_default.readNext(17);
            }
            if ( (pr_default.getStatus(17) != 101) && ( ( T000U25_A290stockAnio[0] > A290stockAnio ) || ( T000U25_A290stockAnio[0] == A290stockAnio ) && ( T000U25_A291stockMes[0] > A291stockMes ) || ( T000U25_A291stockMes[0] == A291stockMes ) && ( T000U25_A290stockAnio[0] == A290stockAnio ) && ( T000U25_A1EmpID[0] > A1EmpID ) || ( T000U25_A1EmpID[0] == A1EmpID ) && ( T000U25_A291stockMes[0] == A291stockMes ) && ( T000U25_A290stockAnio[0] == A290stockAnio ) && ( T000U25_A2AgeID[0] > A2AgeID ) || ( T000U25_A2AgeID[0] == A2AgeID ) && ( T000U25_A1EmpID[0] == A1EmpID ) && ( T000U25_A291stockMes[0] == A291stockMes ) && ( T000U25_A290stockAnio[0] == A290stockAnio ) && ( T000U25_A42BodCod[0] > A42BodCod ) || ( T000U25_A42BodCod[0] == A42BodCod ) && ( T000U25_A2AgeID[0] == A2AgeID ) && ( T000U25_A1EmpID[0] == A1EmpID ) && ( T000U25_A291stockMes[0] == A291stockMes ) && ( T000U25_A290stockAnio[0] == A290stockAnio ) && ( StringUtil.StrCmp(T000U25_A43TipoInv[0], A43TipoInv) > 0 ) ) )
            {
               A290stockAnio = T000U25_A290stockAnio[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
               A291stockMes = T000U25_A291stockMes[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
               A1EmpID = T000U25_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000U25_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A42BodCod = T000U25_A42BodCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               A43TipoInv = T000U25_A43TipoInv[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
               RcdFound82 = 1;
            }
         }
         pr_default.close(17);
      }

      protected void move_previous( )
      {
         RcdFound82 = 0;
         /* Using cursor T000U26 */
         pr_default.execute(18, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(18) != 101) )
         {
            while ( (pr_default.getStatus(18) != 101) && ( ( T000U26_A290stockAnio[0] > A290stockAnio ) || ( T000U26_A290stockAnio[0] == A290stockAnio ) && ( T000U26_A291stockMes[0] > A291stockMes ) || ( T000U26_A291stockMes[0] == A291stockMes ) && ( T000U26_A290stockAnio[0] == A290stockAnio ) && ( T000U26_A1EmpID[0] > A1EmpID ) || ( T000U26_A1EmpID[0] == A1EmpID ) && ( T000U26_A291stockMes[0] == A291stockMes ) && ( T000U26_A290stockAnio[0] == A290stockAnio ) && ( T000U26_A2AgeID[0] > A2AgeID ) || ( T000U26_A2AgeID[0] == A2AgeID ) && ( T000U26_A1EmpID[0] == A1EmpID ) && ( T000U26_A291stockMes[0] == A291stockMes ) && ( T000U26_A290stockAnio[0] == A290stockAnio ) && ( T000U26_A42BodCod[0] > A42BodCod ) || ( T000U26_A42BodCod[0] == A42BodCod ) && ( T000U26_A2AgeID[0] == A2AgeID ) && ( T000U26_A1EmpID[0] == A1EmpID ) && ( T000U26_A291stockMes[0] == A291stockMes ) && ( T000U26_A290stockAnio[0] == A290stockAnio ) && ( StringUtil.StrCmp(T000U26_A43TipoInv[0], A43TipoInv) > 0 ) ) )
            {
               pr_default.readNext(18);
            }
            if ( (pr_default.getStatus(18) != 101) && ( ( T000U26_A290stockAnio[0] < A290stockAnio ) || ( T000U26_A290stockAnio[0] == A290stockAnio ) && ( T000U26_A291stockMes[0] < A291stockMes ) || ( T000U26_A291stockMes[0] == A291stockMes ) && ( T000U26_A290stockAnio[0] == A290stockAnio ) && ( T000U26_A1EmpID[0] < A1EmpID ) || ( T000U26_A1EmpID[0] == A1EmpID ) && ( T000U26_A291stockMes[0] == A291stockMes ) && ( T000U26_A290stockAnio[0] == A290stockAnio ) && ( T000U26_A2AgeID[0] < A2AgeID ) || ( T000U26_A2AgeID[0] == A2AgeID ) && ( T000U26_A1EmpID[0] == A1EmpID ) && ( T000U26_A291stockMes[0] == A291stockMes ) && ( T000U26_A290stockAnio[0] == A290stockAnio ) && ( T000U26_A42BodCod[0] < A42BodCod ) || ( T000U26_A42BodCod[0] == A42BodCod ) && ( T000U26_A2AgeID[0] == A2AgeID ) && ( T000U26_A1EmpID[0] == A1EmpID ) && ( T000U26_A291stockMes[0] == A291stockMes ) && ( T000U26_A290stockAnio[0] == A290stockAnio ) && ( StringUtil.StrCmp(T000U26_A43TipoInv[0], A43TipoInv) < 0 ) ) )
            {
               A290stockAnio = T000U26_A290stockAnio[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
               A291stockMes = T000U26_A291stockMes[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
               A1EmpID = T000U26_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T000U26_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A42BodCod = T000U26_A42BodCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               A43TipoInv = T000U26_A43TipoInv[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
               RcdFound82 = 1;
            }
         }
         pr_default.close(18);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0U82( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A295egrBod = O295egrBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            A294ingBod = O294ingBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0U82( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound82 == 1 )
            {
               if ( ( A290stockAnio != Z290stockAnio ) || ( A291stockMes != Z291stockMes ) || ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( StringUtil.StrCmp(A43TipoInv, Z43TipoInv) != 0 ) )
               {
                  A290stockAnio = Z290stockAnio;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
                  A291stockMes = Z291stockMes;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A2AgeID = Z2AgeID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
                  A42BodCod = Z42BodCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
                  A43TipoInv = Z43TipoInv;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "STOCKANIO");
                  AnyError = 1;
                  GX_FocusControl = edtstockAnio_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A295egrBod = O295egrBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                  A294ingBod = O294ingBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A295egrBod = O295egrBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                  A294ingBod = O294ingBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  Update0U82( ) ;
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A290stockAnio != Z290stockAnio ) || ( A291stockMes != Z291stockMes ) || ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( StringUtil.StrCmp(A43TipoInv, Z43TipoInv) != 0 ) )
               {
                  /* Insert record */
                  A295egrBod = O295egrBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                  A294ingBod = O294ingBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0U82( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "STOCKANIO");
                     AnyError = 1;
                     GX_FocusControl = edtstockAnio_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     A295egrBod = O295egrBod;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                     A294ingBod = O294ingBod;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                     GX_FocusControl = dynEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0U82( ) ;
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
         if ( ( A290stockAnio != Z290stockAnio ) || ( A291stockMes != Z291stockMes ) || ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( StringUtil.StrCmp(A43TipoInv, Z43TipoInv) != 0 ) )
         {
            A290stockAnio = Z290stockAnio;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
            A291stockMes = Z291stockMes;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = Z2AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = Z42BodCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A43TipoInv = Z43TipoInv;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "STOCKANIO");
            AnyError = 1;
            GX_FocusControl = edtstockAnio_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A295egrBod = O295egrBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            A294ingBod = O294ingBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0U82( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000U5 */
            pr_default.execute(3, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdxBodega"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( StringUtil.StrCmp(Z307prdStockDsc, T000U5_A307prdStockDsc[0]) != 0 ) || ( Z293invFisico != T000U5_A293invFisico[0] ) )
            {
               if ( StringUtil.StrCmp(Z307prdStockDsc, T000U5_A307prdStockDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("prodxbodega:[seudo value changed for attri]"+"prdStockDsc");
                  GXUtil.WriteLogRaw("Old: ",Z307prdStockDsc);
                  GXUtil.WriteLogRaw("Current: ",T000U5_A307prdStockDsc[0]);
               }
               if ( Z293invFisico != T000U5_A293invFisico[0] )
               {
                  GXUtil.WriteLog("prodxbodega:[seudo value changed for attri]"+"invFisico");
                  GXUtil.WriteLogRaw("Old: ",Z293invFisico);
                  GXUtil.WriteLogRaw("Current: ",T000U5_A293invFisico[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ProdxBodega"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0U82( )
      {
         BeforeValidate0U82( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0U82( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0U82( 0) ;
            CheckOptimisticConcurrency0U82( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0U82( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0U82( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000U27 */
                     pr_default.execute(19, new Object[] {A290stockAnio, A291stockMes, n307prdStockDsc, A307prdStockDsc, n293invFisico, A293invFisico, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdxBodega") ;
                     if ( (pr_default.getStatus(19) == 1) )
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
                           ProcessLevel0U82( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0U0( ) ;
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
               Load0U82( ) ;
            }
            EndLevel0U82( ) ;
         }
         CloseExtendedTableCursors0U82( ) ;
      }

      protected void Update0U82( )
      {
         BeforeValidate0U82( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0U82( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0U82( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0U82( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0U82( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000U28 */
                     pr_default.execute(20, new Object[] {n307prdStockDsc, A307prdStockDsc, n293invFisico, A293invFisico, A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
                     pr_default.close(20);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdxBodega") ;
                     if ( (pr_default.getStatus(20) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdxBodega"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0U82( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0U82( ) ;
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
            EndLevel0U82( ) ;
         }
         CloseExtendedTableCursors0U82( ) ;
      }

      protected void DeferredUpdate0U82( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0U82( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0U82( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0U82( ) ;
            AfterConfirm0U82( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0U82( ) ;
               if ( AnyError == 0 )
               {
                  A295egrBod = O295egrBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                  A294ingBod = O294ingBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  ScanStart0U83( ) ;
                  while ( RcdFound83 != 0 )
                  {
                     getByPrimaryKey0U83( ) ;
                     Delete0U83( ) ;
                     ScanNext0U83( ) ;
                     O295egrBod = A295egrBod;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                     O294ingBod = A294ingBod;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  }
                  ScanEnd0U83( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000U29 */
                     pr_default.execute(21, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
                     pr_default.close(21);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdxBodega") ;
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
         sMode82 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0U82( ) ;
         Gx_mode = sMode82;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0U82( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV21Pgmname = "ProdxBodega";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21Pgmname", AV21Pgmname);
            /* Using cursor T000U30 */
            pr_default.execute(22, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = T000U30_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T000U30_n217BodDsc[0];
            pr_default.close(22);
            /* Using cursor T000U31 */
            pr_default.execute(23, new Object[] {A43TipoInv});
            A219TipoInvMov = T000U31_A219TipoInvMov[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
            n219TipoInvMov = T000U31_n219TipoInvMov[0];
            A223TipoInvSigno = T000U31_A223TipoInvSigno[0];
            n223TipoInvSigno = T000U31_n223TipoInvSigno[0];
            pr_default.close(23);
            /* Using cursor T000U33 */
            pr_default.execute(24, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
            if ( (pr_default.getStatus(24) != 101) )
            {
               A292stockBod = T000U33_A292stockBod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
               n292stockBod = T000U33_n292stockBod[0];
            }
            else
            {
               A292stockBod = 0;
               n292stockBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
            }
            pr_default.close(24);
            /* Using cursor T000U35 */
            pr_default.execute(25, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
            if ( (pr_default.getStatus(25) != 101) )
            {
               A294ingBod = T000U35_A294ingBod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               A295egrBod = T000U35_A295egrBod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            else
            {
               A294ingBod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               A295egrBod = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            pr_default.close(25);
         }
      }

      protected void ProcessNestedLevel0U83( )
      {
         s295egrBod = O295egrBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         s294ingBod = O294ingBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         nGXsfl_101_idx = 0;
         while ( nGXsfl_101_idx < nRC_GXsfl_101 )
         {
            ReadRow0U83( ) ;
            if ( ( nRcdExists_83 != 0 ) || ( nIsMod_83 != 0 ) )
            {
               standaloneNotModal0U83( ) ;
               GetKey0U83( ) ;
               if ( ( nRcdExists_83 == 0 ) && ( nRcdDeleted_83 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0U83( ) ;
               }
               else
               {
                  if ( RcdFound83 != 0 )
                  {
                     if ( ( nRcdDeleted_83 != 0 ) && ( nRcdExists_83 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0U83( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_83 != 0 ) && ( nRcdExists_83 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0U83( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_83 == 0 )
                     {
                        GXCCtl = "STOCKDETID_" + sGXsfl_101_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtstockDetID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O295egrBod = A295egrBod;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               O294ingBod = A294ingBod;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            }
            ChangePostValue( edtstockDetID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A348stockDetID), 4, 0, ",", ""))) ;
            ChangePostValue( edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( edtprdNombre_Internalname, A309prdNombre) ;
            ChangePostValue( edtcantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A296cantidad, 9, 2, ",", ""))) ;
            ChangePostValue( edtstock_Internalname, StringUtil.LTrim( StringUtil.NToC( A297stock, 9, 2, ",", ""))) ;
            ChangePostValue( edtcosto_Internalname, StringUtil.LTrim( StringUtil.NToC( A298costo, 13, 2, ",", ""))) ;
            ChangePostValue( edtcostUni_Internalname, StringUtil.LTrim( StringUtil.NToC( A299costUni, 13, 2, ",", ""))) ;
            ChangePostValue( edtingTipo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A300ingTipo), 9, 0, ",", ""))) ;
            ChangePostValue( edtegrTipo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A301egrTipo), 9, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z348stockDetID_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z348stockDetID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z296cantidad_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( Z296cantidad, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z297stock_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( Z297stock, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z298costo_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( Z298costo, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", ""))) ;
            ChangePostValue( "T301egrTipo_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(O301egrTipo), 9, 0, ",", ""))) ;
            ChangePostValue( "T300ingTipo_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(O300ingTipo), 9, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_83_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_83), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_83_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_83), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_83_"+sGXsfl_101_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_83), 4, 0, ",", ""))) ;
            if ( nIsMod_83 != 0 )
            {
               ChangePostValue( "STOCKDETID_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDCOD_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRDNOMBRE_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTIDAD_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "STOCK_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstock_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COSTO_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcosto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COSTUNI_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcostUni_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGTIPO_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EGRTIPO_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtegrTipo_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0U83( ) ;
         if ( AnyError != 0 )
         {
            O295egrBod = s295egrBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            O294ingBod = s294ingBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         nRcdExists_83 = 0;
         nIsMod_83 = 0;
         nRcdDeleted_83 = 0;
      }

      protected void ProcessLevel0U82( )
      {
         /* Save parent mode. */
         sMode82 = Gx_mode;
         ProcessNestedLevel0U83( ) ;
         if ( AnyError != 0 )
         {
            O295egrBod = s295egrBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            O294ingBod = s294ingBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode82;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel0U82( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0U82( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(22);
            pr_default.close(23);
            pr_default.close(24);
            pr_default.close(25);
            pr_default.close(2);
            context.CommitDataStores("prodxbodega",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0U0( ) ;
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
            pr_default.close(22);
            pr_default.close(23);
            pr_default.close(24);
            pr_default.close(25);
            pr_default.close(2);
            context.RollbackDataStores("prodxbodega",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0U82( )
      {
         /* Scan By routine */
         /* Using cursor T000U36 */
         pr_default.execute(26);
         RcdFound82 = 0;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound82 = 1;
            A290stockAnio = T000U36_A290stockAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
            A291stockMes = T000U36_A291stockMes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
            A1EmpID = T000U36_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000U36_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = T000U36_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A43TipoInv = T000U36_A43TipoInv[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0U82( )
      {
         /* Scan next routine */
         pr_default.readNext(26);
         RcdFound82 = 0;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound82 = 1;
            A290stockAnio = T000U36_A290stockAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
            A291stockMes = T000U36_A291stockMes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
            A1EmpID = T000U36_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T000U36_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = T000U36_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A43TipoInv = T000U36_A43TipoInv[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         }
      }

      protected void ScanEnd0U82( )
      {
         pr_default.close(26);
      }

      protected void AfterConfirm0U82( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0U82( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0U82( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0U82( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0U82( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0U82( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0U82( )
      {
         dynEmpID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynEmpID.Enabled), 5, 0)), true);
         dynAgeID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
         edtstockAnio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockAnio_Enabled), 5, 0)), true);
         cmbstockMes.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbstockMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbstockMes.Enabled), 5, 0)), true);
         edtBodCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodCod_Enabled), 5, 0)), true);
         edtBodDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodDsc_Enabled), 5, 0)), true);
         edtTipoInv_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), true);
         edtTipoInvMov_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvMov_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInvMov_Enabled), 5, 0)), true);
         edtprdStockDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdStockDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdStockDsc_Enabled), 5, 0)), true);
         edtstockBod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockBod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockBod_Enabled), 5, 0)), true);
         edtinvFisico_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtinvFisico_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtinvFisico_Enabled), 5, 0)), true);
         edtingBod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBod_Enabled), 5, 0)), true);
         edtegrBod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtegrBod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtegrBod_Enabled), 5, 0)), true);
      }

      protected void ZM0U83( short GX_JID )
      {
         if ( ( GX_JID == 36 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z296cantidad = T000U3_A296cantidad[0];
               Z297stock = T000U3_A297stock[0];
               Z298costo = T000U3_A298costo[0];
               Z286PrdCod = T000U3_A286PrdCod[0];
            }
            else
            {
               Z296cantidad = A296cantidad;
               Z297stock = A297stock;
               Z298costo = A298costo;
               Z286PrdCod = A286PrdCod;
            }
         }
         if ( GX_JID == -36 )
         {
            Z290stockAnio = A290stockAnio;
            Z291stockMes = A291stockMes;
            Z42BodCod = A42BodCod;
            Z43TipoInv = A43TipoInv;
            Z348stockDetID = A348stockDetID;
            Z296cantidad = A296cantidad;
            Z297stock = A297stock;
            Z298costo = A298costo;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z286PrdCod = A286PrdCod;
            Z309prdNombre = A309prdNombre;
         }
      }

      protected void standaloneNotModal0U83( )
      {
         edtingTipo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipo_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtegrTipo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtegrTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtegrTipo_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
      }

      protected void standaloneModal0U83( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtstockDetID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetID_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         }
         else
         {
            edtstockDetID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetID_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         }
      }

      protected void Load0U83( )
      {
         /* Using cursor T000U37 */
         pr_default.execute(27, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv, A348stockDetID});
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound83 = 1;
            A309prdNombre = T000U37_A309prdNombre[0];
            n309prdNombre = T000U37_n309prdNombre[0];
            A296cantidad = T000U37_A296cantidad[0];
            n296cantidad = T000U37_n296cantidad[0];
            A297stock = T000U37_A297stock[0];
            n297stock = T000U37_n297stock[0];
            A298costo = T000U37_A298costo[0];
            n298costo = T000U37_n298costo[0];
            A286PrdCod = T000U37_A286PrdCod[0];
            ZM0U83( -36) ;
         }
         pr_default.close(27);
         OnLoadActions0U83( ) ;
      }

      protected void OnLoadActions0U83( )
      {
         if ( A223TipoInvSigno == -1 )
         {
            A301egrTipo = (int)(A296cantidad);
         }
         else
         {
            A301egrTipo = 0;
         }
         O301egrTipo = A301egrTipo;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A295egrBod = (decimal)(O295egrBod+A301egrTipo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A295egrBod = (decimal)(O295egrBod+A301egrTipo-O301egrTipo);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A295egrBod = (decimal)(O295egrBod-O301egrTipo);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               }
            }
         }
         if ( A223TipoInvSigno == 1 )
         {
            A300ingTipo = (int)(A296cantidad);
         }
         else
         {
            A300ingTipo = 0;
         }
         O300ingTipo = A300ingTipo;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A294ingBod = (decimal)(O294ingBod+A300ingTipo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A294ingBod = (decimal)(O294ingBod+A300ingTipo-O300ingTipo);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A294ingBod = (decimal)(O294ingBod-O300ingTipo);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               }
            }
         }
         if ( ( A296cantidad != Convert.ToDecimal( 0 )) )
         {
            A299costUni = NumberUtil.Round( A298costo/ (decimal)(A296cantidad), 2);
         }
         else
         {
            A299costUni = 0;
         }
      }

      protected void CheckExtendedTable0U83( )
      {
         Gx_BScreen = 1;
         standaloneModal0U83( ) ;
         /* Using cursor T000U4 */
         pr_default.execute(2, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_101_idx;
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A309prdNombre = T000U4_A309prdNombre[0];
         n309prdNombre = T000U4_n309prdNombre[0];
         pr_default.close(2);
         if ( A223TipoInvSigno == -1 )
         {
            A301egrTipo = (int)(A296cantidad);
         }
         else
         {
            A301egrTipo = 0;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A295egrBod = (decimal)(O295egrBod+A301egrTipo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A295egrBod = (decimal)(O295egrBod+A301egrTipo-O301egrTipo);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A295egrBod = (decimal)(O295egrBod-O301egrTipo);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               }
            }
         }
         if ( A223TipoInvSigno == 1 )
         {
            A300ingTipo = (int)(A296cantidad);
         }
         else
         {
            A300ingTipo = 0;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A294ingBod = (decimal)(O294ingBod+A300ingTipo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A294ingBod = (decimal)(O294ingBod+A300ingTipo-O300ingTipo);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A294ingBod = (decimal)(O294ingBod-O300ingTipo);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               }
            }
         }
         if ( ( A296cantidad != Convert.ToDecimal( 0 )) )
         {
            A299costUni = NumberUtil.Round( A298costo/ (decimal)(A296cantidad), 2);
         }
         else
         {
            A299costUni = 0;
         }
      }

      protected void CloseExtendedTableCursors0U83( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0U83( )
      {
      }

      protected void gxLoad_37( short A1EmpID ,
                                short A2AgeID ,
                                short A286PrdCod )
      {
         /* Using cursor T000U38 */
         pr_default.execute(28, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(28) == 101) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_101_idx;
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A309prdNombre = T000U38_A309prdNombre[0];
         n309prdNombre = T000U38_n309prdNombre[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A309prdNombre)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(28) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(28);
      }

      protected void GetKey0U83( )
      {
         /* Using cursor T000U39 */
         pr_default.execute(29, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv, A348stockDetID});
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound83 = 1;
         }
         else
         {
            RcdFound83 = 0;
         }
         pr_default.close(29);
      }

      protected void getByPrimaryKey0U83( )
      {
         /* Using cursor T000U3 */
         pr_default.execute(1, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv, A348stockDetID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0U83( 36) ;
            RcdFound83 = 1;
            InitializeNonKey0U83( ) ;
            A348stockDetID = T000U3_A348stockDetID[0];
            A296cantidad = T000U3_A296cantidad[0];
            n296cantidad = T000U3_n296cantidad[0];
            A297stock = T000U3_A297stock[0];
            n297stock = T000U3_n297stock[0];
            A298costo = T000U3_A298costo[0];
            n298costo = T000U3_n298costo[0];
            A286PrdCod = T000U3_A286PrdCod[0];
            Z290stockAnio = A290stockAnio;
            Z291stockMes = A291stockMes;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z43TipoInv = A43TipoInv;
            Z348stockDetID = A348stockDetID;
            sMode83 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0U83( ) ;
            Gx_mode = sMode83;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound83 = 0;
            InitializeNonKey0U83( ) ;
            sMode83 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0U83( ) ;
            Gx_mode = sMode83;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0U83( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0U83( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000U2 */
            pr_default.execute(0, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv, A348stockDetID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdxBodegaTipo"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z296cantidad != T000U2_A296cantidad[0] ) || ( Z297stock != T000U2_A297stock[0] ) || ( Z298costo != T000U2_A298costo[0] ) || ( Z286PrdCod != T000U2_A286PrdCod[0] ) )
            {
               if ( Z296cantidad != T000U2_A296cantidad[0] )
               {
                  GXUtil.WriteLog("prodxbodega:[seudo value changed for attri]"+"cantidad");
                  GXUtil.WriteLogRaw("Old: ",Z296cantidad);
                  GXUtil.WriteLogRaw("Current: ",T000U2_A296cantidad[0]);
               }
               if ( Z297stock != T000U2_A297stock[0] )
               {
                  GXUtil.WriteLog("prodxbodega:[seudo value changed for attri]"+"stock");
                  GXUtil.WriteLogRaw("Old: ",Z297stock);
                  GXUtil.WriteLogRaw("Current: ",T000U2_A297stock[0]);
               }
               if ( Z298costo != T000U2_A298costo[0] )
               {
                  GXUtil.WriteLog("prodxbodega:[seudo value changed for attri]"+"costo");
                  GXUtil.WriteLogRaw("Old: ",Z298costo);
                  GXUtil.WriteLogRaw("Current: ",T000U2_A298costo[0]);
               }
               if ( Z286PrdCod != T000U2_A286PrdCod[0] )
               {
                  GXUtil.WriteLog("prodxbodega:[seudo value changed for attri]"+"PrdCod");
                  GXUtil.WriteLogRaw("Old: ",Z286PrdCod);
                  GXUtil.WriteLogRaw("Current: ",T000U2_A286PrdCod[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ProdxBodegaTipo"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0U83( )
      {
         BeforeValidate0U83( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0U83( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0U83( 0) ;
            CheckOptimisticConcurrency0U83( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0U83( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0U83( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000U40 */
                     pr_default.execute(30, new Object[] {A290stockAnio, A291stockMes, A42BodCod, A43TipoInv, A348stockDetID, n296cantidad, A296cantidad, n297stock, A297stock, n298costo, A298costo, A1EmpID, A2AgeID, A286PrdCod});
                     pr_default.close(30);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdxBodegaTipo") ;
                     if ( (pr_default.getStatus(30) == 1) )
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
               Load0U83( ) ;
            }
            EndLevel0U83( ) ;
         }
         CloseExtendedTableCursors0U83( ) ;
      }

      protected void Update0U83( )
      {
         BeforeValidate0U83( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0U83( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0U83( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0U83( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0U83( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000U41 */
                     pr_default.execute(31, new Object[] {n296cantidad, A296cantidad, n297stock, A297stock, n298costo, A298costo, A286PrdCod, A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv, A348stockDetID});
                     pr_default.close(31);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdxBodegaTipo") ;
                     if ( (pr_default.getStatus(31) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdxBodegaTipo"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0U83( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0U83( ) ;
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
            EndLevel0U83( ) ;
         }
         CloseExtendedTableCursors0U83( ) ;
      }

      protected void DeferredUpdate0U83( )
      {
      }

      protected void Delete0U83( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0U83( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0U83( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0U83( ) ;
            AfterConfirm0U83( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0U83( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000U42 */
                  pr_default.execute(32, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv, A348stockDetID});
                  pr_default.close(32);
                  dsDefault.SmartCacheProvider.SetUpdated("ProdxBodegaTipo") ;
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
         sMode83 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0U83( ) ;
         Gx_mode = sMode83;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0U83( )
      {
         standaloneModal0U83( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000U43 */
            pr_default.execute(33, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            A309prdNombre = T000U43_A309prdNombre[0];
            n309prdNombre = T000U43_n309prdNombre[0];
            pr_default.close(33);
            if ( A223TipoInvSigno == -1 )
            {
               A301egrTipo = (int)(A296cantidad);
            }
            else
            {
               A301egrTipo = 0;
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A295egrBod = (decimal)(O295egrBod+A301egrTipo);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A295egrBod = (decimal)(O295egrBod+A301egrTipo-O301egrTipo);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A295egrBod = (decimal)(O295egrBod-O301egrTipo);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                  }
               }
            }
            if ( A223TipoInvSigno == 1 )
            {
               A300ingTipo = (int)(A296cantidad);
            }
            else
            {
               A300ingTipo = 0;
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A294ingBod = (decimal)(O294ingBod+A300ingTipo);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A294ingBod = (decimal)(O294ingBod+A300ingTipo-O300ingTipo);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A294ingBod = (decimal)(O294ingBod-O300ingTipo);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  }
               }
            }
            if ( ( A296cantidad != Convert.ToDecimal( 0 )) )
            {
               A299costUni = NumberUtil.Round( A298costo/ (decimal)(A296cantidad), 2);
            }
            else
            {
               A299costUni = 0;
            }
         }
      }

      protected void EndLevel0U83( )
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

      public void ScanStart0U83( )
      {
         /* Scan By routine */
         /* Using cursor T000U44 */
         pr_default.execute(34, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         RcdFound83 = 0;
         if ( (pr_default.getStatus(34) != 101) )
         {
            RcdFound83 = 1;
            A348stockDetID = T000U44_A348stockDetID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0U83( )
      {
         /* Scan next routine */
         pr_default.readNext(34);
         RcdFound83 = 0;
         if ( (pr_default.getStatus(34) != 101) )
         {
            RcdFound83 = 1;
            A348stockDetID = T000U44_A348stockDetID[0];
         }
      }

      protected void ScanEnd0U83( )
      {
         pr_default.close(34);
      }

      protected void AfterConfirm0U83( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0U83( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0U83( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0U83( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0U83( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0U83( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0U83( )
      {
         edtstockDetID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetID_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtPrdCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtprdNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdNombre_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtcantidad_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcantidad_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtstock_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstock_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtcosto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcosto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcosto_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtcostUni_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcostUni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcostUni_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtingTipo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipo_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtegrTipo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtegrTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtegrTipo_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
      }

      protected void send_integrity_lvl_hashes0U83( )
      {
      }

      protected void send_integrity_lvl_hashes0U82( )
      {
      }

      protected void SubsflControlProps_10183( )
      {
         edtstockDetID_Internalname = "STOCKDETID_"+sGXsfl_101_idx;
         edtPrdCod_Internalname = "PRDCOD_"+sGXsfl_101_idx;
         imgprompt_286_Internalname = "PROMPT_286_"+sGXsfl_101_idx;
         edtprdNombre_Internalname = "PRDNOMBRE_"+sGXsfl_101_idx;
         edtcantidad_Internalname = "CANTIDAD_"+sGXsfl_101_idx;
         edtstock_Internalname = "STOCK_"+sGXsfl_101_idx;
         edtcosto_Internalname = "COSTO_"+sGXsfl_101_idx;
         edtcostUni_Internalname = "COSTUNI_"+sGXsfl_101_idx;
         edtingTipo_Internalname = "INGTIPO_"+sGXsfl_101_idx;
         edtegrTipo_Internalname = "EGRTIPO_"+sGXsfl_101_idx;
      }

      protected void SubsflControlProps_fel_10183( )
      {
         edtstockDetID_Internalname = "STOCKDETID_"+sGXsfl_101_fel_idx;
         edtPrdCod_Internalname = "PRDCOD_"+sGXsfl_101_fel_idx;
         imgprompt_286_Internalname = "PROMPT_286_"+sGXsfl_101_fel_idx;
         edtprdNombre_Internalname = "PRDNOMBRE_"+sGXsfl_101_fel_idx;
         edtcantidad_Internalname = "CANTIDAD_"+sGXsfl_101_fel_idx;
         edtstock_Internalname = "STOCK_"+sGXsfl_101_fel_idx;
         edtcosto_Internalname = "COSTO_"+sGXsfl_101_fel_idx;
         edtcostUni_Internalname = "COSTUNI_"+sGXsfl_101_fel_idx;
         edtingTipo_Internalname = "INGTIPO_"+sGXsfl_101_fel_idx;
         edtegrTipo_Internalname = "EGRTIPO_"+sGXsfl_101_fel_idx;
      }

      protected void AddRow0U83( )
      {
         nGXsfl_101_idx = (short)(nGXsfl_101_idx+1);
         sGXsfl_101_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_101_idx), 4, 0)), 4, "0");
         SubsflControlProps_10183( ) ;
         SendRow0U83( ) ;
      }

      protected void SendRow0U83( )
      {
         Gridprodxbodega_tipoRow = GXWebRow.GetNew(context);
         if ( subGridprodxbodega_tipo_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridprodxbodega_tipo_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridprodxbodega_tipo_Class, "") != 0 )
            {
               subGridprodxbodega_tipo_Linesclass = subGridprodxbodega_tipo_Class+"Odd";
            }
         }
         else if ( subGridprodxbodega_tipo_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridprodxbodega_tipo_Backstyle = 0;
            subGridprodxbodega_tipo_Backcolor = subGridprodxbodega_tipo_Allbackcolor;
            if ( StringUtil.StrCmp(subGridprodxbodega_tipo_Class, "") != 0 )
            {
               subGridprodxbodega_tipo_Linesclass = subGridprodxbodega_tipo_Class+"Uniform";
            }
         }
         else if ( subGridprodxbodega_tipo_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridprodxbodega_tipo_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridprodxbodega_tipo_Class, "") != 0 )
            {
               subGridprodxbodega_tipo_Linesclass = subGridprodxbodega_tipo_Class+"Odd";
            }
            subGridprodxbodega_tipo_Backcolor = (int)(0x0);
         }
         else if ( subGridprodxbodega_tipo_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridprodxbodega_tipo_Backstyle = 1;
            if ( ((int)(((nGXsfl_101_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridprodxbodega_tipo_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridprodxbodega_tipo_Class, "") != 0 )
               {
                  subGridprodxbodega_tipo_Linesclass = subGridprodxbodega_tipo_Class+"Odd";
               }
            }
            else
            {
               subGridprodxbodega_tipo_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridprodxbodega_tipo_Class, "") != 0 )
               {
                  subGridprodxbodega_tipo_Linesclass = subGridprodxbodega_tipo_Class+"Even";
               }
            }
         }
         imgprompt_286_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0202.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"PRDCOD_"+sGXsfl_101_idx+"'), id:'"+"PRDCOD_"+sGXsfl_101_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_83_"+sGXsfl_101_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_83_" + sGXsfl_101_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 102,'',false,'" + sGXsfl_101_idx + "',101)\"";
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstockDetID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A348stockDetID), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A348stockDetID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstockDetID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtstockDetID_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)101,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_83_" + sGXsfl_101_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 103,'',false,'" + sGXsfl_101_idx + "',101)\"";
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrdCod_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", "")),((edtPrdCod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")) : context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrdCod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPrdCod_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)101,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridprodxbodega_tipoRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_286_Internalname,(String)sImgUrl,(String)imgprompt_286_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_286_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtprdNombre_Internalname,(String)A309prdNombre,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtprdNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtprdNombre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)80,(short)0,(short)0,(short)101,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_83_" + sGXsfl_101_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 105,'',false,'" + sGXsfl_101_idx + "',101)\"";
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A296cantidad, 9, 2, ",", "")),((edtcantidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A296cantidad, "ZZZZZ9.99")) : context.localUtil.Format( A296cantidad, "ZZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,105);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcantidad_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcantidad_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)101,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_83_" + sGXsfl_101_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 106,'',false,'" + sGXsfl_101_idx + "',101)\"";
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstock_Internalname,StringUtil.LTrim( StringUtil.NToC( A297stock, 9, 2, ",", "")),((edtstock_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A297stock, "ZZZZZ9.99")) : context.localUtil.Format( A297stock, "ZZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,106);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstock_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtstock_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)101,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_83_" + sGXsfl_101_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 107,'',false,'" + sGXsfl_101_idx + "',101)\"";
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcosto_Internalname,StringUtil.LTrim( StringUtil.NToC( A298costo, 13, 2, ",", "")),((edtcosto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A298costo, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A298costo, "ZZ,ZZZ,ZZZ.ZZ")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,107);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcosto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcosto_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)101,(short)1,(short)-1,(short)0,(bool)true,(String)"valores",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcostUni_Internalname,StringUtil.LTrim( StringUtil.NToC( A299costUni, 13, 2, ",", "")),((edtcostUni_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A299costUni, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A299costUni, "ZZ,ZZZ,ZZZ.ZZ")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcostUni_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcostUni_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)101,(short)1,(short)-1,(short)0,(bool)true,(String)"valores",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingTipo_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A300ingTipo), 9, 0, ",", "")),((edtingTipo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A300ingTipo), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A300ingTipo), "ZZZZZZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingTipo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtingTipo_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)101,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtegrTipo_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A301egrTipo), 9, 0, ",", "")),((edtegrTipo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A301egrTipo), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A301egrTipo), "ZZZZZZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtegrTipo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtegrTipo_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)101,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridprodxbodega_tipoRow);
         send_integrity_lvl_hashes0U83( ) ;
         GXCCtl = "Z348stockDetID_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z348stockDetID), 4, 0, ",", "")));
         GXCCtl = "Z296cantidad_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z296cantidad, 9, 2, ",", "")));
         GXCCtl = "Z297stock_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z297stock, 9, 2, ",", "")));
         GXCCtl = "Z298costo_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z298costo, 10, 2, ",", "")));
         GXCCtl = "Z286PrdCod_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", "")));
         GXCCtl = "O301egrTipo_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(O301egrTipo), 9, 0, ",", "")));
         GXCCtl = "O300ingTipo_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(O300ingTipo), 9, 0, ",", "")));
         GXCCtl = "nRcdDeleted_83_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_83), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_83_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_83), 4, 0, ",", "")));
         GXCCtl = "nIsMod_83_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_83), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_101_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV14TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV14TrnContext);
         }
         GXCCtl = "vSTOCKANIO_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7stockAnio), 4, 0, ",", "")));
         GXCCtl = "vSTOCKMES_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8stockMes), 2, 0, ",", "")));
         GXCCtl = "vEMPID_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9EmpID), 4, 0, ",", "")));
         GXCCtl = "vAGEID_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10AgeID), 4, 0, ",", "")));
         GXCCtl = "vBODCOD_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12BodCod), 4, 0, ",", "")));
         GXCCtl = "vTIPOINV_" + sGXsfl_101_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV19tipoInv));
         GxWebStd.gx_hidden_field( context, "STOCKDETID_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRDCOD_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrdCod_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRDNOMBRE_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtprdNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CANTIDAD_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidad_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "STOCK_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstock_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "COSTO_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcosto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "COSTUNI_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcostUni_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGTIPO_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "EGRTIPO_"+sGXsfl_101_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtegrTipo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_286_"+sGXsfl_101_idx+"Link", StringUtil.RTrim( imgprompt_286_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridprodxbodega_tipoContainer.AddRow(Gridprodxbodega_tipoRow);
      }

      protected void ReadRow0U83( )
      {
         nGXsfl_101_idx = (short)(nGXsfl_101_idx+1);
         sGXsfl_101_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_101_idx), 4, 0)), 4, "0");
         SubsflControlProps_10183( ) ;
         edtstockDetID_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCKDETID_"+sGXsfl_101_idx+"Enabled"), ",", "."));
         edtPrdCod_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDCOD_"+sGXsfl_101_idx+"Enabled"), ",", "."));
         edtprdNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRDNOMBRE_"+sGXsfl_101_idx+"Enabled"), ",", "."));
         edtcantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTIDAD_"+sGXsfl_101_idx+"Enabled"), ",", "."));
         edtstock_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCK_"+sGXsfl_101_idx+"Enabled"), ",", "."));
         edtcosto_Enabled = (int)(context.localUtil.CToN( cgiGet( "COSTO_"+sGXsfl_101_idx+"Enabled"), ",", "."));
         edtcostUni_Enabled = (int)(context.localUtil.CToN( cgiGet( "COSTUNI_"+sGXsfl_101_idx+"Enabled"), ",", "."));
         edtingTipo_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGTIPO_"+sGXsfl_101_idx+"Enabled"), ",", "."));
         edtegrTipo_Enabled = (int)(context.localUtil.CToN( cgiGet( "EGRTIPO_"+sGXsfl_101_idx+"Enabled"), ",", "."));
         imgprompt_1_42_Link = cgiGet( "PROMPT_286_"+sGXsfl_101_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtstockDetID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtstockDetID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "STOCKDETID_" + sGXsfl_101_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtstockDetID_Internalname;
            wbErr = true;
            A348stockDetID = 0;
         }
         else
         {
            A348stockDetID = (short)(context.localUtil.CToN( cgiGet( edtstockDetID_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "PRDCOD_" + sGXsfl_101_idx;
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
         if ( ( ( context.localUtil.CToN( cgiGet( edtcantidad_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcantidad_Internalname), ",", ".") > 999999.99m ) ) )
         {
            GXCCtl = "CANTIDAD_" + sGXsfl_101_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcantidad_Internalname;
            wbErr = true;
            A296cantidad = 0;
            n296cantidad = false;
         }
         else
         {
            A296cantidad = context.localUtil.CToN( cgiGet( edtcantidad_Internalname), ",", ".");
            n296cantidad = false;
         }
         n296cantidad = ((Convert.ToDecimal(0)==A296cantidad) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtstock_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtstock_Internalname), ",", ".") > 999999.99m ) ) )
         {
            GXCCtl = "STOCK_" + sGXsfl_101_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtstock_Internalname;
            wbErr = true;
            A297stock = 0;
            n297stock = false;
         }
         else
         {
            A297stock = context.localUtil.CToN( cgiGet( edtstock_Internalname), ",", ".");
            n297stock = false;
         }
         n297stock = ((Convert.ToDecimal(0)==A297stock) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtcosto_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcosto_Internalname), ",", ".") > 9999999.99m ) ) )
         {
            GXCCtl = "COSTO_" + sGXsfl_101_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcosto_Internalname;
            wbErr = true;
            A298costo = 0;
            n298costo = false;
         }
         else
         {
            A298costo = context.localUtil.CToN( cgiGet( edtcosto_Internalname), ",", ".");
            n298costo = false;
         }
         n298costo = ((Convert.ToDecimal(0)==A298costo) ? true : false);
         A299costUni = context.localUtil.CToN( cgiGet( edtcostUni_Internalname), ",", ".");
         A300ingTipo = (int)(context.localUtil.CToN( cgiGet( edtingTipo_Internalname), ",", "."));
         A301egrTipo = (int)(context.localUtil.CToN( cgiGet( edtegrTipo_Internalname), ",", "."));
         GXCCtl = "Z348stockDetID_" + sGXsfl_101_idx;
         Z348stockDetID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z296cantidad_" + sGXsfl_101_idx;
         Z296cantidad = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n296cantidad = ((Convert.ToDecimal(0)==A296cantidad) ? true : false);
         GXCCtl = "Z297stock_" + sGXsfl_101_idx;
         Z297stock = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n297stock = ((Convert.ToDecimal(0)==A297stock) ? true : false);
         GXCCtl = "Z298costo_" + sGXsfl_101_idx;
         Z298costo = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n298costo = ((Convert.ToDecimal(0)==A298costo) ? true : false);
         GXCCtl = "Z286PrdCod_" + sGXsfl_101_idx;
         Z286PrdCod = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "O301egrTipo_" + sGXsfl_101_idx;
         O301egrTipo = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "O300ingTipo_" + sGXsfl_101_idx;
         O300ingTipo = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdDeleted_83_" + sGXsfl_101_idx;
         nRcdDeleted_83 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_83_" + sGXsfl_101_idx;
         nRcdExists_83 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_83_" + sGXsfl_101_idx;
         nIsMod_83 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtegrTipo_Enabled = edtegrTipo_Enabled;
         defedtingTipo_Enabled = edtingTipo_Enabled;
         defedtstockDetID_Enabled = edtstockDetID_Enabled;
      }

      protected void ConfirmValues0U0( )
      {
         nGXsfl_101_idx = 0;
         sGXsfl_101_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_101_idx), 4, 0)), 4, "0");
         SubsflControlProps_10183( ) ;
         while ( nGXsfl_101_idx < nRC_GXsfl_101 )
         {
            nGXsfl_101_idx = (short)(nGXsfl_101_idx+1);
            sGXsfl_101_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_101_idx), 4, 0)), 4, "0");
            SubsflControlProps_10183( ) ;
            ChangePostValue( "Z348stockDetID_"+sGXsfl_101_idx, cgiGet( "ZT_"+"Z348stockDetID_"+sGXsfl_101_idx)) ;
            DeletePostValue( "ZT_"+"Z348stockDetID_"+sGXsfl_101_idx) ;
            ChangePostValue( "Z296cantidad_"+sGXsfl_101_idx, cgiGet( "ZT_"+"Z296cantidad_"+sGXsfl_101_idx)) ;
            DeletePostValue( "ZT_"+"Z296cantidad_"+sGXsfl_101_idx) ;
            ChangePostValue( "Z297stock_"+sGXsfl_101_idx, cgiGet( "ZT_"+"Z297stock_"+sGXsfl_101_idx)) ;
            DeletePostValue( "ZT_"+"Z297stock_"+sGXsfl_101_idx) ;
            ChangePostValue( "Z298costo_"+sGXsfl_101_idx, cgiGet( "ZT_"+"Z298costo_"+sGXsfl_101_idx)) ;
            DeletePostValue( "ZT_"+"Z298costo_"+sGXsfl_101_idx) ;
            ChangePostValue( "Z286PrdCod_"+sGXsfl_101_idx, cgiGet( "ZT_"+"Z286PrdCod_"+sGXsfl_101_idx)) ;
            DeletePostValue( "ZT_"+"Z286PrdCod_"+sGXsfl_101_idx) ;
         }
         ChangePostValue( "O301egrTipo", cgiGet( "T301egrTipo")) ;
         DeletePostValue( "T301egrTipo") ;
         ChangePostValue( "O300ingTipo", cgiGet( "T300ingTipo")) ;
         DeletePostValue( "T300ingTipo") ;
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
         context.SendWebValue( "Prodx Bodega") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20221029174261", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("prodxbodega.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7stockAnio) + "," + UrlEncode("" +AV8stockMes) + "," + UrlEncode("" +AV9EmpID) + "," + UrlEncode("" +AV10AgeID) + "," + UrlEncode("" +AV12BodCod) + "," + UrlEncode(StringUtil.RTrim(AV19tipoInv))+"\">") ;
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
         forbiddenHiddens = "hsh" + "ProdxBodega";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV18Insert_TipoInv, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("prodxbodega:[SendSecurityCheck value for]"+"Insert_TipoInv:"+StringUtil.RTrim( context.localUtil.Format( AV18Insert_TipoInv, "")));
         GXUtil.WriteLog("prodxbodega:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z290stockAnio", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z290stockAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z291stockMes", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z291stockMes), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z2AgeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z42BodCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z43TipoInv", StringUtil.RTrim( Z43TipoInv));
         GxWebStd.gx_hidden_field( context, "Z307prdStockDsc", Z307prdStockDsc);
         GxWebStd.gx_hidden_field( context, "Z293invFisico", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z293invFisico), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O295egrBod", StringUtil.LTrim( StringUtil.NToC( O295egrBod, 9, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "O294ingBod", StringUtil.LTrim( StringUtil.NToC( O294ingBod, 9, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_101", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_101_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N43TipoInv", StringUtil.RTrim( A43TipoInv));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV14TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV14TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vSTOCKANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7stockAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSTOCKANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7stockAnio), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vSTOCKMES", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8stockMes), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSTOCKMES", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8stockMes), "Z9"), context));
         GxWebStd.gx_hidden_field( context, "vMES", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20mes), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vBODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBODCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BodCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_TIPOINV", StringUtil.RTrim( AV18Insert_TipoInv));
         GxWebStd.gx_hidden_field( context, "vTIPOINV", StringUtil.RTrim( AV19tipoInv));
         GxWebStd.gx_hidden_field( context, "gxhash_vTIPOINV", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19tipoInv, "")), context));
         GxWebStd.gx_hidden_field( context, "TIPOINVSIGNO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV21Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void RenderHtmlCloseForm0U82( )
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
         return "ProdxBodega" ;
      }

      public override String GetPgmdesc( )
      {
         return "Prodx Bodega" ;
      }

      protected void InitializeNonKey0U82( )
      {
         A217BodDsc = "";
         n217BodDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         A219TipoInvMov = "";
         n219TipoInvMov = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TipoInvMov", A219TipoInvMov);
         A223TipoInvSigno = 0;
         n223TipoInvSigno = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TipoInvSigno", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TipoInvSigno), 2, 0)));
         A307prdStockDsc = "";
         n307prdStockDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307prdStockDsc", A307prdStockDsc);
         n307prdStockDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A307prdStockDsc)) ? true : false);
         A292stockBod = 0;
         n292stockBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( (decimal)(A292stockBod), 4, 0)));
         A293invFisico = 0;
         n293invFisico = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293invFisico", StringUtil.LTrim( StringUtil.Str( (decimal)(A293invFisico), 9, 0)));
         n293invFisico = ((0==A293invFisico) ? true : false);
         A294ingBod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         A295egrBod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         O295egrBod = A295egrBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         O294ingBod = A294ingBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         Z307prdStockDsc = "";
         Z293invFisico = 0;
      }

      protected void InitAll0U82( )
      {
         A290stockAnio = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
         A291stockMes = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A2AgeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         A42BodCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
         A43TipoInv = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TipoInv", A43TipoInv);
         InitializeNonKey0U82( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0U83( )
      {
         A286PrdCod = 0;
         A309prdNombre = "";
         n309prdNombre = false;
         A296cantidad = 0;
         n296cantidad = false;
         A297stock = 0;
         n297stock = false;
         A298costo = 0;
         n298costo = false;
         A299costUni = 0;
         A300ingTipo = 0;
         A301egrTipo = 0;
         O301egrTipo = A301egrTipo;
         O300ingTipo = A300ingTipo;
         Z296cantidad = 0;
         Z297stock = 0;
         Z298costo = 0;
         Z286PrdCod = 0;
      }

      protected void InitAll0U83( )
      {
         A348stockDetID = 0;
         InitializeNonKey0U83( ) ;
      }

      protected void StandaloneModalInsert0U83( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20221029174278", true);
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
         context.AddJavascriptSource("prodxbodega.js", "?20221029174278", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties83( )
      {
         edtegrTipo_Enabled = defedtegrTipo_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtegrTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtegrTipo_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtingTipo_Enabled = defedtingTipo_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipo_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
         edtstockDetID_Enabled = defedtstockDetID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetID_Enabled), 5, 0)), !bGXsfl_101_Refreshing);
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
         dynEmpID_Internalname = "EMPID";
         divSection1_Internalname = "SECTION1";
         dynAgeID_Internalname = "AGEID";
         divSection2_Internalname = "SECTION2";
         edtstockAnio_Internalname = "STOCKANIO";
         divSection3_Internalname = "SECTION3";
         cmbstockMes_Internalname = "STOCKMES";
         divSection4_Internalname = "SECTION4";
         edtBodCod_Internalname = "BODCOD";
         edtBodDsc_Internalname = "BODDSC";
         edtTipoInv_Internalname = "TIPOINV";
         edtTipoInvMov_Internalname = "TIPOINVMOV";
         edtprdStockDsc_Internalname = "PRDSTOCKDSC";
         edtstockBod_Internalname = "STOCKBOD";
         edtinvFisico_Internalname = "INVFISICO";
         edtingBod_Internalname = "INGBOD";
         divSection5_Internalname = "SECTION5";
         edtegrBod_Internalname = "EGRBOD";
         divSection6_Internalname = "SECTION6";
         lblTitletipo_Internalname = "TITLETIPO";
         edtstockDetID_Internalname = "STOCKDETID";
         edtPrdCod_Internalname = "PRDCOD";
         edtprdNombre_Internalname = "PRDNOMBRE";
         edtcantidad_Internalname = "CANTIDAD";
         edtstock_Internalname = "STOCK";
         edtcosto_Internalname = "COSTO";
         edtcostUni_Internalname = "COSTUNI";
         edtingTipo_Internalname = "INGTIPO";
         edtegrTipo_Internalname = "EGRTIPO";
         divTipotable_Internalname = "TIPOTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_42_Internalname = "PROMPT_1_42";
         imgprompt_43_Internalname = "PROMPT_43";
         imgprompt_286_Internalname = "PROMPT_286";
         subGridprodxbodega_tipo_Internalname = "GRIDPRODXBODEGA_TIPO";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtegrTipo_Jsonclick = "";
         edtingTipo_Jsonclick = "";
         edtcostUni_Jsonclick = "";
         edtcosto_Jsonclick = "";
         edtstock_Jsonclick = "";
         edtcantidad_Jsonclick = "";
         edtprdNombre_Jsonclick = "";
         imgprompt_286_Visible = 1;
         imgprompt_286_Link = "";
         imgprompt_1_42_Visible = 1;
         edtPrdCod_Jsonclick = "";
         edtstockDetID_Jsonclick = "";
         subGridprodxbodega_tipo_Class = "Grid";
         subGridprodxbodega_tipo_Backcolorstyle = 0;
         subGridprodxbodega_tipo_Allowcollapsing = 0;
         subGridprodxbodega_tipo_Allowselection = 0;
         edtegrTipo_Enabled = 0;
         edtingTipo_Enabled = 0;
         edtcostUni_Enabled = 0;
         edtcosto_Enabled = 1;
         edtstock_Enabled = 1;
         edtcantidad_Enabled = 1;
         edtprdNombre_Enabled = 0;
         edtPrdCod_Enabled = 1;
         edtstockDetID_Enabled = 1;
         subGridprodxbodega_tipo_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtegrBod_Jsonclick = "";
         edtegrBod_Enabled = 0;
         edtingBod_Jsonclick = "";
         edtingBod_Enabled = 0;
         edtinvFisico_Jsonclick = "";
         edtinvFisico_Enabled = 1;
         edtstockBod_Jsonclick = "";
         edtstockBod_Enabled = 0;
         edtprdStockDsc_Jsonclick = "";
         edtprdStockDsc_Enabled = 1;
         edtTipoInvMov_Jsonclick = "";
         edtTipoInvMov_Enabled = 0;
         imgprompt_43_Visible = 1;
         imgprompt_43_Link = "";
         edtTipoInv_Jsonclick = "";
         edtTipoInv_Enabled = 1;
         edtBodDsc_Jsonclick = "";
         edtBodDsc_Enabled = 0;
         imgprompt_1_42_Visible = 1;
         imgprompt_1_42_Link = "";
         edtBodCod_Jsonclick = "";
         edtBodCod_Enabled = 1;
         cmbstockMes_Jsonclick = "";
         cmbstockMes.Enabled = 1;
         edtstockAnio_Jsonclick = "";
         edtstockAnio_Enabled = 1;
         dynAgeID_Jsonclick = "";
         dynAgeID.Enabled = 1;
         dynEmpID_Jsonclick = "";
         dynEmpID.Enabled = 1;
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

      protected void GXDLAEMPID0U1( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAEMPID_data0U1( ) ;
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

      protected void GXAEMPID_html0U1( )
      {
         short gxdynajaxvalue ;
         GXDLAEMPID_data0U1( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynEmpID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynEmpID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAEMPID_data0U1( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000U45 */
         pr_default.execute(35);
         while ( (pr_default.getStatus(35) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000U45_A1EmpID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(T000U45_A44empdsc[0]);
            pr_default.readNext(35);
         }
         pr_default.close(35);
      }

      protected void GXDLAAGEID0U82( short AV9EmpID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAAGEID_data0U82( AV9EmpID) ;
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

      protected void GXAAGEID_html0U82( short AV9EmpID )
      {
         short gxdynajaxvalue ;
         GXDLAAGEID_data0U82( AV9EmpID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynAgeID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynAgeID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAAGEID_data0U82( short AV9EmpID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000U46 */
         pr_default.execute(36, new Object[] {AV9EmpID});
         while ( (pr_default.getStatus(36) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000U46_A2AgeID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000U46_A46AgeDsc[0]));
            pr_default.readNext(36);
         }
         pr_default.close(36);
      }

      protected void gxnrGridprodxbodega_tipo_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_10183( ) ;
         while ( nGXsfl_101_idx <= nRC_GXsfl_101 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0U83( ) ;
            standaloneModal0U83( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0U83( ) ;
            nGXsfl_101_idx = (short)(nGXsfl_101_idx+1);
            sGXsfl_101_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_101_idx), 4, 0)), 4, "0");
            SubsflControlProps_10183( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridprodxbodega_tipoContainer));
         /* End function gxnrGridprodxbodega_tipo_newrow */
      }

      protected void init_web_controls( )
      {
         dynEmpID.Name = "EMPID";
         dynEmpID.WebTags = "";
         dynEmpID.removeAllItems();
         /* Using cursor T000U47 */
         pr_default.execute(37);
         while ( (pr_default.getStatus(37) != 101) )
         {
            dynEmpID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(T000U47_A1EmpID[0]), 4, 0)), T000U47_A44empdsc[0], 0);
            pr_default.readNext(37);
         }
         pr_default.close(37);
         if ( dynEmpID.ItemCount > 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( dynEmpID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         dynAgeID.Name = "AGEID";
         dynAgeID.WebTags = "";
         cmbstockMes.Name = "STOCKMES";
         cmbstockMes.WebTags = "";
         cmbstockMes.addItem("0", "Seleccionar", 0);
         cmbstockMes.addItem("1", "Enero", 0);
         cmbstockMes.addItem("2", "Febrero", 0);
         cmbstockMes.addItem("3", "Marzo", 0);
         cmbstockMes.addItem("4", "Abril", 0);
         cmbstockMes.addItem("5", "Mayo", 0);
         cmbstockMes.addItem("6", "Junio", 0);
         cmbstockMes.addItem("7", "Julio", 0);
         cmbstockMes.addItem("8", "Agosto", 0);
         cmbstockMes.addItem("9", "Septiembre", 0);
         cmbstockMes.addItem("10", "Octubre", 0);
         cmbstockMes.addItem("11", "Noviembre", 0);
         cmbstockMes.addItem("12", "Diciembre", 0);
         if ( cmbstockMes.ItemCount > 0 )
         {
            A291stockMes = (short)(NumberUtil.Val( cmbstockMes.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A291stockMes), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
         }
         /* End function init_web_controls */
      }

      public void Valid_Ageid( GXCombobox dynGX_Parm1 ,
                               GXCombobox dynGX_Parm2 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         dynAgeID = dynGX_Parm2;
         A2AgeID = (short)(NumberUtil.Val( dynAgeID.CurrentValue, "."));
         /* Using cursor T000U48 */
         pr_default.execute(38, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(38) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
         }
         pr_default.close(38);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Bodcod( GXCombobox dynGX_Parm1 ,
                                short GX_Parm2 ,
                                String GX_Parm3 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         A42BodCod = GX_Parm2;
         A217BodDsc = GX_Parm3;
         n217BodDsc = false;
         /* Using cursor T000U30 */
         pr_default.execute(22, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(22) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
         }
         A217BodDsc = T000U30_A217BodDsc[0];
         n217BodDsc = T000U30_n217BodDsc[0];
         pr_default.close(22);
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

      public void Valid_Tipoinv( String GX_Parm1 ,
                                 short GX_Parm2 ,
                                 GXCombobox cmbGX_Parm3 ,
                                 GXCombobox dynGX_Parm4 ,
                                 GXCombobox dynGX_Parm5 ,
                                 short GX_Parm6 ,
                                 String GX_Parm7 ,
                                 short GX_Parm8 ,
                                 short GX_Parm9 ,
                                 decimal GX_Parm10 ,
                                 decimal GX_Parm11 )
      {
         A43TipoInv = GX_Parm1;
         A290stockAnio = GX_Parm2;
         cmbstockMes = cmbGX_Parm3;
         A291stockMes = (short)(NumberUtil.Val( cmbstockMes.CurrentValue, "."));
         dynEmpID = dynGX_Parm4;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         dynAgeID = dynGX_Parm5;
         A2AgeID = (short)(NumberUtil.Val( dynAgeID.CurrentValue, "."));
         A42BodCod = GX_Parm6;
         A219TipoInvMov = GX_Parm7;
         n219TipoInvMov = false;
         A223TipoInvSigno = GX_Parm8;
         n223TipoInvSigno = false;
         A292stockBod = GX_Parm9;
         n292stockBod = false;
         A294ingBod = GX_Parm10;
         A295egrBod = GX_Parm11;
         /* Using cursor T000U31 */
         pr_default.execute(23, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, "TIPOINV");
            AnyError = 1;
            GX_FocusControl = edtTipoInv_Internalname;
         }
         A219TipoInvMov = T000U31_A219TipoInvMov[0];
         n219TipoInvMov = T000U31_n219TipoInvMov[0];
         A223TipoInvSigno = T000U31_A223TipoInvSigno[0];
         n223TipoInvSigno = T000U31_n223TipoInvSigno[0];
         pr_default.close(23);
         /* Using cursor T000U33 */
         pr_default.execute(24, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(24) != 101) )
         {
            A292stockBod = T000U33_A292stockBod[0];
            n292stockBod = T000U33_n292stockBod[0];
         }
         else
         {
            A292stockBod = 0;
            n292stockBod = false;
         }
         pr_default.close(24);
         /* Using cursor T000U35 */
         pr_default.execute(25, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A43TipoInv});
         if ( (pr_default.getStatus(25) != 101) )
         {
            A294ingBod = T000U35_A294ingBod[0];
            A295egrBod = T000U35_A295egrBod[0];
         }
         else
         {
            A294ingBod = 0;
            A295egrBod = 0;
         }
         pr_default.close(25);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A219TipoInvMov = "";
            n219TipoInvMov = false;
            A223TipoInvSigno = 0;
            n223TipoInvSigno = false;
            A292stockBod = 0;
            n292stockBod = false;
            A294ingBod = 0;
            A295egrBod = 0;
         }
         isValidOutput.Add(A219TipoInvMov);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A292stockBod), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A294ingBod, 9, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A295egrBod, 9, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Prdcod( GXCombobox dynGX_Parm1 ,
                                GXCombobox dynGX_Parm2 ,
                                short GX_Parm3 ,
                                String GX_Parm4 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         dynAgeID = dynGX_Parm2;
         A2AgeID = (short)(NumberUtil.Val( dynAgeID.CurrentValue, "."));
         A286PrdCod = GX_Parm3;
         A309prdNombre = GX_Parm4;
         n309prdNombre = false;
         /* Using cursor T000U43 */
         pr_default.execute(33, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(33) == 101) )
         {
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, "PRDCOD");
            AnyError = 1;
            GX_FocusControl = edtPrdCod_Internalname;
         }
         A309prdNombre = T000U43_A309prdNombre[0];
         n309prdNombre = T000U43_n309prdNombre[0];
         pr_default.close(33);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A309prdNombre = "";
            n309prdNombre = false;
         }
         isValidOutput.Add(A309prdNombre);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7stockAnio',fld:'vSTOCKANIO',pic:'ZZZ9',hsh:true},{av:'AV8stockMes',fld:'vSTOCKMES',pic:'Z9',hsh:true},{av:'AV10AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV12BodCod',fld:'vBODCOD',pic:'ZZZ9',hsh:true},{av:'AV19tipoInv',fld:'vTIPOINV',pic:'',hsh:true},{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7stockAnio',fld:'vSTOCKANIO',pic:'ZZZ9',hsh:true},{av:'AV8stockMes',fld:'vSTOCKMES',pic:'Z9',hsh:true},{av:'AV10AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV12BodCod',fld:'vBODCOD',pic:'ZZZ9',hsh:true},{av:'AV19tipoInv',fld:'vTIPOINV',pic:'',hsh:true},{av:'AV18Insert_TipoInv',fld:'vINSERT_TIPOINV',pic:''},{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]}");
         setEventMetadata("AFTER TRN","{handler:'E120U2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV14TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]");
         setEventMetadata("AFTER TRN",",oparms:[{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]}");
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
         pr_default.close(33);
         pr_default.close(4);
         pr_default.close(38);
         pr_default.close(22);
         pr_default.close(23);
         pr_default.close(24);
         pr_default.close(25);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV19tipoInv = "";
         Z43TipoInv = "";
         Z307prdStockDsc = "";
         N43TipoInv = "";
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
         A217BodDsc = "";
         A219TipoInvMov = "";
         A307prdStockDsc = "";
         lblTitletipo_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridprodxbodega_tipoContainer = new GXWebGrid( context);
         Gridprodxbodega_tipoColumn = new GXWebColumn();
         A309prdNombre = "";
         sMode83 = "";
         sStyleString = "";
         AV18Insert_TipoInv = "";
         AV21Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode82 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV14TrnContext = new SdtTransactionContext(context);
         AV15WebSession = context.GetSession();
         AV17TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z217BodDsc = "";
         Z219TipoInvMov = "";
         T000U8_A217BodDsc = new String[] {""} ;
         T000U8_n217BodDsc = new bool[] {false} ;
         T000U9_A219TipoInvMov = new String[] {""} ;
         T000U9_n219TipoInvMov = new bool[] {false} ;
         T000U9_A223TipoInvSigno = new short[1] ;
         T000U9_n223TipoInvSigno = new bool[] {false} ;
         T000U11_A292stockBod = new short[1] ;
         T000U11_n292stockBod = new bool[] {false} ;
         T000U13_A294ingBod = new decimal[1] ;
         T000U13_A295egrBod = new decimal[1] ;
         T000U16_A290stockAnio = new short[1] ;
         T000U16_A291stockMes = new short[1] ;
         T000U16_A217BodDsc = new String[] {""} ;
         T000U16_n217BodDsc = new bool[] {false} ;
         T000U16_A219TipoInvMov = new String[] {""} ;
         T000U16_n219TipoInvMov = new bool[] {false} ;
         T000U16_A223TipoInvSigno = new short[1] ;
         T000U16_n223TipoInvSigno = new bool[] {false} ;
         T000U16_A307prdStockDsc = new String[] {""} ;
         T000U16_n307prdStockDsc = new bool[] {false} ;
         T000U16_A293invFisico = new int[1] ;
         T000U16_n293invFisico = new bool[] {false} ;
         T000U16_A1EmpID = new short[1] ;
         T000U16_A2AgeID = new short[1] ;
         T000U16_A42BodCod = new short[1] ;
         T000U16_A43TipoInv = new String[] {""} ;
         T000U16_A292stockBod = new short[1] ;
         T000U16_n292stockBod = new bool[] {false} ;
         T000U16_A294ingBod = new decimal[1] ;
         T000U16_A295egrBod = new decimal[1] ;
         T000U7_A1EmpID = new short[1] ;
         T000U17_A1EmpID = new short[1] ;
         T000U18_A217BodDsc = new String[] {""} ;
         T000U18_n217BodDsc = new bool[] {false} ;
         T000U19_A219TipoInvMov = new String[] {""} ;
         T000U19_n219TipoInvMov = new bool[] {false} ;
         T000U19_A223TipoInvSigno = new short[1] ;
         T000U19_n223TipoInvSigno = new bool[] {false} ;
         T000U21_A292stockBod = new short[1] ;
         T000U21_n292stockBod = new bool[] {false} ;
         T000U23_A294ingBod = new decimal[1] ;
         T000U23_A295egrBod = new decimal[1] ;
         T000U24_A290stockAnio = new short[1] ;
         T000U24_A291stockMes = new short[1] ;
         T000U24_A1EmpID = new short[1] ;
         T000U24_A2AgeID = new short[1] ;
         T000U24_A42BodCod = new short[1] ;
         T000U24_A43TipoInv = new String[] {""} ;
         T000U6_A290stockAnio = new short[1] ;
         T000U6_A291stockMes = new short[1] ;
         T000U6_A307prdStockDsc = new String[] {""} ;
         T000U6_n307prdStockDsc = new bool[] {false} ;
         T000U6_A293invFisico = new int[1] ;
         T000U6_n293invFisico = new bool[] {false} ;
         T000U6_A1EmpID = new short[1] ;
         T000U6_A2AgeID = new short[1] ;
         T000U6_A42BodCod = new short[1] ;
         T000U6_A43TipoInv = new String[] {""} ;
         T000U25_A290stockAnio = new short[1] ;
         T000U25_A291stockMes = new short[1] ;
         T000U25_A1EmpID = new short[1] ;
         T000U25_A2AgeID = new short[1] ;
         T000U25_A42BodCod = new short[1] ;
         T000U25_A43TipoInv = new String[] {""} ;
         T000U26_A290stockAnio = new short[1] ;
         T000U26_A291stockMes = new short[1] ;
         T000U26_A1EmpID = new short[1] ;
         T000U26_A2AgeID = new short[1] ;
         T000U26_A42BodCod = new short[1] ;
         T000U26_A43TipoInv = new String[] {""} ;
         T000U5_A290stockAnio = new short[1] ;
         T000U5_A291stockMes = new short[1] ;
         T000U5_A307prdStockDsc = new String[] {""} ;
         T000U5_n307prdStockDsc = new bool[] {false} ;
         T000U5_A293invFisico = new int[1] ;
         T000U5_n293invFisico = new bool[] {false} ;
         T000U5_A1EmpID = new short[1] ;
         T000U5_A2AgeID = new short[1] ;
         T000U5_A42BodCod = new short[1] ;
         T000U5_A43TipoInv = new String[] {""} ;
         T000U30_A217BodDsc = new String[] {""} ;
         T000U30_n217BodDsc = new bool[] {false} ;
         T000U31_A219TipoInvMov = new String[] {""} ;
         T000U31_n219TipoInvMov = new bool[] {false} ;
         T000U31_A223TipoInvSigno = new short[1] ;
         T000U31_n223TipoInvSigno = new bool[] {false} ;
         T000U33_A292stockBod = new short[1] ;
         T000U33_n292stockBod = new bool[] {false} ;
         T000U35_A294ingBod = new decimal[1] ;
         T000U35_A295egrBod = new decimal[1] ;
         T000U36_A290stockAnio = new short[1] ;
         T000U36_A291stockMes = new short[1] ;
         T000U36_A1EmpID = new short[1] ;
         T000U36_A2AgeID = new short[1] ;
         T000U36_A42BodCod = new short[1] ;
         T000U36_A43TipoInv = new String[] {""} ;
         Z309prdNombre = "";
         T000U37_A290stockAnio = new short[1] ;
         T000U37_A291stockMes = new short[1] ;
         T000U37_A42BodCod = new short[1] ;
         T000U37_A43TipoInv = new String[] {""} ;
         T000U37_A348stockDetID = new short[1] ;
         T000U37_A309prdNombre = new String[] {""} ;
         T000U37_n309prdNombre = new bool[] {false} ;
         T000U37_A296cantidad = new decimal[1] ;
         T000U37_n296cantidad = new bool[] {false} ;
         T000U37_A297stock = new decimal[1] ;
         T000U37_n297stock = new bool[] {false} ;
         T000U37_A298costo = new decimal[1] ;
         T000U37_n298costo = new bool[] {false} ;
         T000U37_A1EmpID = new short[1] ;
         T000U37_A2AgeID = new short[1] ;
         T000U37_A286PrdCod = new short[1] ;
         T000U4_A309prdNombre = new String[] {""} ;
         T000U4_n309prdNombre = new bool[] {false} ;
         T000U38_A309prdNombre = new String[] {""} ;
         T000U38_n309prdNombre = new bool[] {false} ;
         T000U39_A290stockAnio = new short[1] ;
         T000U39_A291stockMes = new short[1] ;
         T000U39_A1EmpID = new short[1] ;
         T000U39_A2AgeID = new short[1] ;
         T000U39_A42BodCod = new short[1] ;
         T000U39_A43TipoInv = new String[] {""} ;
         T000U39_A348stockDetID = new short[1] ;
         T000U3_A290stockAnio = new short[1] ;
         T000U3_A291stockMes = new short[1] ;
         T000U3_A42BodCod = new short[1] ;
         T000U3_A43TipoInv = new String[] {""} ;
         T000U3_A348stockDetID = new short[1] ;
         T000U3_A296cantidad = new decimal[1] ;
         T000U3_n296cantidad = new bool[] {false} ;
         T000U3_A297stock = new decimal[1] ;
         T000U3_n297stock = new bool[] {false} ;
         T000U3_A298costo = new decimal[1] ;
         T000U3_n298costo = new bool[] {false} ;
         T000U3_A1EmpID = new short[1] ;
         T000U3_A2AgeID = new short[1] ;
         T000U3_A286PrdCod = new short[1] ;
         T000U2_A290stockAnio = new short[1] ;
         T000U2_A291stockMes = new short[1] ;
         T000U2_A42BodCod = new short[1] ;
         T000U2_A43TipoInv = new String[] {""} ;
         T000U2_A348stockDetID = new short[1] ;
         T000U2_A296cantidad = new decimal[1] ;
         T000U2_n296cantidad = new bool[] {false} ;
         T000U2_A297stock = new decimal[1] ;
         T000U2_n297stock = new bool[] {false} ;
         T000U2_A298costo = new decimal[1] ;
         T000U2_n298costo = new bool[] {false} ;
         T000U2_A1EmpID = new short[1] ;
         T000U2_A2AgeID = new short[1] ;
         T000U2_A286PrdCod = new short[1] ;
         T000U43_A309prdNombre = new String[] {""} ;
         T000U43_n309prdNombre = new bool[] {false} ;
         T000U44_A290stockAnio = new short[1] ;
         T000U44_A291stockMes = new short[1] ;
         T000U44_A1EmpID = new short[1] ;
         T000U44_A2AgeID = new short[1] ;
         T000U44_A42BodCod = new short[1] ;
         T000U44_A43TipoInv = new String[] {""} ;
         T000U44_A348stockDetID = new short[1] ;
         Gridprodxbodega_tipoRow = new GXWebRow();
         subGridprodxbodega_tipo_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000U45_A1EmpID = new short[1] ;
         T000U45_A44empdsc = new String[] {""} ;
         T000U45_n44empdsc = new bool[] {false} ;
         T000U46_A1EmpID = new short[1] ;
         T000U46_A2AgeID = new short[1] ;
         T000U46_A46AgeDsc = new String[] {""} ;
         T000U46_n46AgeDsc = new bool[] {false} ;
         T000U47_A1EmpID = new short[1] ;
         T000U47_A44empdsc = new String[] {""} ;
         T000U47_n44empdsc = new bool[] {false} ;
         T000U48_A1EmpID = new short[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prodxbodega__default(),
            new Object[][] {
                new Object[] {
               T000U2_A290stockAnio, T000U2_A291stockMes, T000U2_A42BodCod, T000U2_A43TipoInv, T000U2_A348stockDetID, T000U2_A296cantidad, T000U2_n296cantidad, T000U2_A297stock, T000U2_n297stock, T000U2_A298costo,
               T000U2_n298costo, T000U2_A1EmpID, T000U2_A2AgeID, T000U2_A286PrdCod
               }
               , new Object[] {
               T000U3_A290stockAnio, T000U3_A291stockMes, T000U3_A42BodCod, T000U3_A43TipoInv, T000U3_A348stockDetID, T000U3_A296cantidad, T000U3_n296cantidad, T000U3_A297stock, T000U3_n297stock, T000U3_A298costo,
               T000U3_n298costo, T000U3_A1EmpID, T000U3_A2AgeID, T000U3_A286PrdCod
               }
               , new Object[] {
               T000U4_A309prdNombre, T000U4_n309prdNombre
               }
               , new Object[] {
               T000U5_A290stockAnio, T000U5_A291stockMes, T000U5_A307prdStockDsc, T000U5_n307prdStockDsc, T000U5_A293invFisico, T000U5_n293invFisico, T000U5_A1EmpID, T000U5_A2AgeID, T000U5_A42BodCod, T000U5_A43TipoInv
               }
               , new Object[] {
               T000U6_A290stockAnio, T000U6_A291stockMes, T000U6_A307prdStockDsc, T000U6_n307prdStockDsc, T000U6_A293invFisico, T000U6_n293invFisico, T000U6_A1EmpID, T000U6_A2AgeID, T000U6_A42BodCod, T000U6_A43TipoInv
               }
               , new Object[] {
               T000U7_A1EmpID
               }
               , new Object[] {
               T000U8_A217BodDsc, T000U8_n217BodDsc
               }
               , new Object[] {
               T000U9_A219TipoInvMov, T000U9_n219TipoInvMov, T000U9_A223TipoInvSigno, T000U9_n223TipoInvSigno
               }
               , new Object[] {
               T000U11_A292stockBod, T000U11_n292stockBod
               }
               , new Object[] {
               T000U13_A294ingBod, T000U13_A295egrBod
               }
               , new Object[] {
               T000U16_A290stockAnio, T000U16_A291stockMes, T000U16_A217BodDsc, T000U16_n217BodDsc, T000U16_A219TipoInvMov, T000U16_n219TipoInvMov, T000U16_A223TipoInvSigno, T000U16_n223TipoInvSigno, T000U16_A307prdStockDsc, T000U16_n307prdStockDsc,
               T000U16_A293invFisico, T000U16_n293invFisico, T000U16_A1EmpID, T000U16_A2AgeID, T000U16_A42BodCod, T000U16_A43TipoInv, T000U16_A292stockBod, T000U16_n292stockBod, T000U16_A294ingBod, T000U16_A295egrBod
               }
               , new Object[] {
               T000U17_A1EmpID
               }
               , new Object[] {
               T000U18_A217BodDsc, T000U18_n217BodDsc
               }
               , new Object[] {
               T000U19_A219TipoInvMov, T000U19_n219TipoInvMov, T000U19_A223TipoInvSigno, T000U19_n223TipoInvSigno
               }
               , new Object[] {
               T000U21_A292stockBod, T000U21_n292stockBod
               }
               , new Object[] {
               T000U23_A294ingBod, T000U23_A295egrBod
               }
               , new Object[] {
               T000U24_A290stockAnio, T000U24_A291stockMes, T000U24_A1EmpID, T000U24_A2AgeID, T000U24_A42BodCod, T000U24_A43TipoInv
               }
               , new Object[] {
               T000U25_A290stockAnio, T000U25_A291stockMes, T000U25_A1EmpID, T000U25_A2AgeID, T000U25_A42BodCod, T000U25_A43TipoInv
               }
               , new Object[] {
               T000U26_A290stockAnio, T000U26_A291stockMes, T000U26_A1EmpID, T000U26_A2AgeID, T000U26_A42BodCod, T000U26_A43TipoInv
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000U30_A217BodDsc, T000U30_n217BodDsc
               }
               , new Object[] {
               T000U31_A219TipoInvMov, T000U31_n219TipoInvMov, T000U31_A223TipoInvSigno, T000U31_n223TipoInvSigno
               }
               , new Object[] {
               T000U33_A292stockBod, T000U33_n292stockBod
               }
               , new Object[] {
               T000U35_A294ingBod, T000U35_A295egrBod
               }
               , new Object[] {
               T000U36_A290stockAnio, T000U36_A291stockMes, T000U36_A1EmpID, T000U36_A2AgeID, T000U36_A42BodCod, T000U36_A43TipoInv
               }
               , new Object[] {
               T000U37_A290stockAnio, T000U37_A291stockMes, T000U37_A42BodCod, T000U37_A43TipoInv, T000U37_A348stockDetID, T000U37_A309prdNombre, T000U37_n309prdNombre, T000U37_A296cantidad, T000U37_n296cantidad, T000U37_A297stock,
               T000U37_n297stock, T000U37_A298costo, T000U37_n298costo, T000U37_A1EmpID, T000U37_A2AgeID, T000U37_A286PrdCod
               }
               , new Object[] {
               T000U38_A309prdNombre, T000U38_n309prdNombre
               }
               , new Object[] {
               T000U39_A290stockAnio, T000U39_A291stockMes, T000U39_A1EmpID, T000U39_A2AgeID, T000U39_A42BodCod, T000U39_A43TipoInv, T000U39_A348stockDetID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000U43_A309prdNombre, T000U43_n309prdNombre
               }
               , new Object[] {
               T000U44_A290stockAnio, T000U44_A291stockMes, T000U44_A1EmpID, T000U44_A2AgeID, T000U44_A42BodCod, T000U44_A43TipoInv, T000U44_A348stockDetID
               }
               , new Object[] {
               T000U45_A1EmpID, T000U45_A44empdsc, T000U45_n44empdsc
               }
               , new Object[] {
               T000U46_A1EmpID, T000U46_A2AgeID, T000U46_A46AgeDsc, T000U46_n46AgeDsc
               }
               , new Object[] {
               T000U47_A1EmpID, T000U47_A44empdsc, T000U47_n44empdsc
               }
               , new Object[] {
               T000U48_A1EmpID
               }
            }
         );
         AV21Pgmname = "ProdxBodega";
      }

      private short nIsMod_83 ;
      private short wcpOAV7stockAnio ;
      private short wcpOAV8stockMes ;
      private short wcpOAV9EmpID ;
      private short wcpOAV10AgeID ;
      private short wcpOAV12BodCod ;
      private short Z290stockAnio ;
      private short Z291stockMes ;
      private short Z1EmpID ;
      private short Z2AgeID ;
      private short Z42BodCod ;
      private short nRC_GXsfl_101 ;
      private short nGXsfl_101_idx=1 ;
      private short Z348stockDetID ;
      private short Z286PrdCod ;
      private short nRcdDeleted_83 ;
      private short nRcdExists_83 ;
      private short GxWebError ;
      private short AV9EmpID ;
      private short A1EmpID ;
      private short A2AgeID ;
      private short A42BodCod ;
      private short A290stockAnio ;
      private short A291stockMes ;
      private short A286PrdCod ;
      private short AV7stockAnio ;
      private short AV8stockMes ;
      private short AV10AgeID ;
      private short AV12BodCod ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A292stockBod ;
      private short subGridprodxbodega_tipo_Backcolorstyle ;
      private short A348stockDetID ;
      private short subGridprodxbodega_tipo_Allowselection ;
      private short subGridprodxbodega_tipo_Allowhovering ;
      private short subGridprodxbodega_tipo_Allowcollapsing ;
      private short subGridprodxbodega_tipo_Collapsed ;
      private short nBlankRcdCount83 ;
      private short RcdFound83 ;
      private short nBlankRcdUsr83 ;
      private short AV20mes ;
      private short A223TipoInvSigno ;
      private short RcdFound82 ;
      private short GX_JID ;
      private short Z223TipoInvSigno ;
      private short Z292stockBod ;
      private short Gx_BScreen ;
      private short subGridprodxbodega_tipo_Backstyle ;
      private short wbTemp ;
      private int Z293invFisico ;
      private int O301egrTipo ;
      private int O300ingTipo ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtstockAnio_Enabled ;
      private int edtBodCod_Enabled ;
      private int imgprompt_1_42_Visible ;
      private int edtBodDsc_Enabled ;
      private int edtTipoInv_Enabled ;
      private int imgprompt_43_Visible ;
      private int edtTipoInvMov_Enabled ;
      private int edtprdStockDsc_Enabled ;
      private int edtstockBod_Enabled ;
      private int A293invFisico ;
      private int edtinvFisico_Enabled ;
      private int edtingBod_Enabled ;
      private int edtegrBod_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtstockDetID_Enabled ;
      private int edtPrdCod_Enabled ;
      private int edtprdNombre_Enabled ;
      private int edtcantidad_Enabled ;
      private int edtstock_Enabled ;
      private int edtcosto_Enabled ;
      private int edtcostUni_Enabled ;
      private int A300ingTipo ;
      private int edtingTipo_Enabled ;
      private int A301egrTipo ;
      private int edtegrTipo_Enabled ;
      private int subGridprodxbodega_tipo_Selectedindex ;
      private int subGridprodxbodega_tipo_Selectioncolor ;
      private int subGridprodxbodega_tipo_Hoveringcolor ;
      private int fRowAdded ;
      private int T301egrTipo ;
      private int T300ingTipo ;
      private int AV22GXV1 ;
      private int subGridprodxbodega_tipo_Backcolor ;
      private int subGridprodxbodega_tipo_Allbackcolor ;
      private int imgprompt_286_Visible ;
      private int defedtegrTipo_Enabled ;
      private int defedtingTipo_Enabled ;
      private int defedtstockDetID_Enabled ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long GRIDPRODXBODEGA_TIPO_nFirstRecordOnPage ;
      private decimal O295egrBod ;
      private decimal O294ingBod ;
      private decimal Z296cantidad ;
      private decimal Z297stock ;
      private decimal Z298costo ;
      private decimal A294ingBod ;
      private decimal A295egrBod ;
      private decimal A296cantidad ;
      private decimal A297stock ;
      private decimal A298costo ;
      private decimal A299costUni ;
      private decimal B295egrBod ;
      private decimal B294ingBod ;
      private decimal s295egrBod ;
      private decimal s294ingBod ;
      private decimal Z294ingBod ;
      private decimal Z295egrBod ;
      private String sPrefix ;
      private String sGXsfl_101_idx="0001" ;
      private String wcpOGx_mode ;
      private String wcpOAV19tipoInv ;
      private String Z43TipoInv ;
      private String N43TipoInv ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A43TipoInv ;
      private String Gx_mode ;
      private String AV19tipoInv ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String dynEmpID_Internalname ;
      private String dynAgeID_Internalname ;
      private String cmbstockMes_Internalname ;
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
      private String dynEmpID_Jsonclick ;
      private String divSection2_Internalname ;
      private String dynAgeID_Jsonclick ;
      private String divSection3_Internalname ;
      private String edtstockAnio_Internalname ;
      private String edtstockAnio_Jsonclick ;
      private String divSection4_Internalname ;
      private String cmbstockMes_Jsonclick ;
      private String edtBodCod_Internalname ;
      private String edtBodCod_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_42_Internalname ;
      private String imgprompt_1_42_Link ;
      private String edtBodDsc_Internalname ;
      private String A217BodDsc ;
      private String edtBodDsc_Jsonclick ;
      private String edtTipoInv_Internalname ;
      private String edtTipoInv_Jsonclick ;
      private String imgprompt_43_Internalname ;
      private String imgprompt_43_Link ;
      private String edtTipoInvMov_Internalname ;
      private String edtTipoInvMov_Jsonclick ;
      private String edtprdStockDsc_Internalname ;
      private String edtprdStockDsc_Jsonclick ;
      private String edtstockBod_Internalname ;
      private String edtstockBod_Jsonclick ;
      private String edtinvFisico_Internalname ;
      private String edtinvFisico_Jsonclick ;
      private String divSection5_Internalname ;
      private String edtingBod_Internalname ;
      private String edtingBod_Jsonclick ;
      private String divSection6_Internalname ;
      private String edtegrBod_Internalname ;
      private String edtegrBod_Jsonclick ;
      private String divTipotable_Internalname ;
      private String lblTitletipo_Internalname ;
      private String lblTitletipo_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridprodxbodega_tipo_Header ;
      private String sMode83 ;
      private String edtstockDetID_Internalname ;
      private String edtPrdCod_Internalname ;
      private String edtprdNombre_Internalname ;
      private String edtcantidad_Internalname ;
      private String edtstock_Internalname ;
      private String edtcosto_Internalname ;
      private String edtcostUni_Internalname ;
      private String edtingTipo_Internalname ;
      private String edtegrTipo_Internalname ;
      private String sStyleString ;
      private String AV18Insert_TipoInv ;
      private String AV21Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode82 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z217BodDsc ;
      private String imgprompt_286_Internalname ;
      private String sGXsfl_101_fel_idx="0001" ;
      private String subGridprodxbodega_tipo_Class ;
      private String subGridprodxbodega_tipo_Linesclass ;
      private String imgprompt_286_Link ;
      private String ROClassString ;
      private String edtstockDetID_Jsonclick ;
      private String edtPrdCod_Jsonclick ;
      private String edtprdNombre_Jsonclick ;
      private String edtcantidad_Jsonclick ;
      private String edtstock_Jsonclick ;
      private String edtcosto_Jsonclick ;
      private String edtcostUni_Jsonclick ;
      private String edtingTipo_Jsonclick ;
      private String edtegrTipo_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridprodxbodega_tipo_Internalname ;
      private String gxwrpcisep ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_101_Refreshing=false ;
      private bool n217BodDsc ;
      private bool n219TipoInvMov ;
      private bool n307prdStockDsc ;
      private bool n292stockBod ;
      private bool n293invFisico ;
      private bool n223TipoInvSigno ;
      private bool returnInSub ;
      private bool n309prdNombre ;
      private bool n296cantidad ;
      private bool n297stock ;
      private bool n298costo ;
      private bool gxdyncontrolsrefreshing ;
      private String Z307prdStockDsc ;
      private String A219TipoInvMov ;
      private String A307prdStockDsc ;
      private String A309prdNombre ;
      private String Z219TipoInvMov ;
      private String Z309prdNombre ;
      private IGxSession AV15WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridprodxbodega_tipoContainer ;
      private GXWebRow Gridprodxbodega_tipoRow ;
      private GXWebColumn Gridprodxbodega_tipoColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynEmpID ;
      private GXCombobox dynAgeID ;
      private GXCombobox cmbstockMes ;
      private IDataStoreProvider pr_default ;
      private String[] T000U8_A217BodDsc ;
      private bool[] T000U8_n217BodDsc ;
      private String[] T000U9_A219TipoInvMov ;
      private bool[] T000U9_n219TipoInvMov ;
      private short[] T000U9_A223TipoInvSigno ;
      private bool[] T000U9_n223TipoInvSigno ;
      private short[] T000U11_A292stockBod ;
      private bool[] T000U11_n292stockBod ;
      private decimal[] T000U13_A294ingBod ;
      private decimal[] T000U13_A295egrBod ;
      private short[] T000U16_A290stockAnio ;
      private short[] T000U16_A291stockMes ;
      private String[] T000U16_A217BodDsc ;
      private bool[] T000U16_n217BodDsc ;
      private String[] T000U16_A219TipoInvMov ;
      private bool[] T000U16_n219TipoInvMov ;
      private short[] T000U16_A223TipoInvSigno ;
      private bool[] T000U16_n223TipoInvSigno ;
      private String[] T000U16_A307prdStockDsc ;
      private bool[] T000U16_n307prdStockDsc ;
      private int[] T000U16_A293invFisico ;
      private bool[] T000U16_n293invFisico ;
      private short[] T000U16_A1EmpID ;
      private short[] T000U16_A2AgeID ;
      private short[] T000U16_A42BodCod ;
      private String[] T000U16_A43TipoInv ;
      private short[] T000U16_A292stockBod ;
      private bool[] T000U16_n292stockBod ;
      private decimal[] T000U16_A294ingBod ;
      private decimal[] T000U16_A295egrBod ;
      private short[] T000U7_A1EmpID ;
      private short[] T000U17_A1EmpID ;
      private String[] T000U18_A217BodDsc ;
      private bool[] T000U18_n217BodDsc ;
      private String[] T000U19_A219TipoInvMov ;
      private bool[] T000U19_n219TipoInvMov ;
      private short[] T000U19_A223TipoInvSigno ;
      private bool[] T000U19_n223TipoInvSigno ;
      private short[] T000U21_A292stockBod ;
      private bool[] T000U21_n292stockBod ;
      private decimal[] T000U23_A294ingBod ;
      private decimal[] T000U23_A295egrBod ;
      private short[] T000U24_A290stockAnio ;
      private short[] T000U24_A291stockMes ;
      private short[] T000U24_A1EmpID ;
      private short[] T000U24_A2AgeID ;
      private short[] T000U24_A42BodCod ;
      private String[] T000U24_A43TipoInv ;
      private short[] T000U6_A290stockAnio ;
      private short[] T000U6_A291stockMes ;
      private String[] T000U6_A307prdStockDsc ;
      private bool[] T000U6_n307prdStockDsc ;
      private int[] T000U6_A293invFisico ;
      private bool[] T000U6_n293invFisico ;
      private short[] T000U6_A1EmpID ;
      private short[] T000U6_A2AgeID ;
      private short[] T000U6_A42BodCod ;
      private String[] T000U6_A43TipoInv ;
      private short[] T000U25_A290stockAnio ;
      private short[] T000U25_A291stockMes ;
      private short[] T000U25_A1EmpID ;
      private short[] T000U25_A2AgeID ;
      private short[] T000U25_A42BodCod ;
      private String[] T000U25_A43TipoInv ;
      private short[] T000U26_A290stockAnio ;
      private short[] T000U26_A291stockMes ;
      private short[] T000U26_A1EmpID ;
      private short[] T000U26_A2AgeID ;
      private short[] T000U26_A42BodCod ;
      private String[] T000U26_A43TipoInv ;
      private short[] T000U5_A290stockAnio ;
      private short[] T000U5_A291stockMes ;
      private String[] T000U5_A307prdStockDsc ;
      private bool[] T000U5_n307prdStockDsc ;
      private int[] T000U5_A293invFisico ;
      private bool[] T000U5_n293invFisico ;
      private short[] T000U5_A1EmpID ;
      private short[] T000U5_A2AgeID ;
      private short[] T000U5_A42BodCod ;
      private String[] T000U5_A43TipoInv ;
      private String[] T000U30_A217BodDsc ;
      private bool[] T000U30_n217BodDsc ;
      private String[] T000U31_A219TipoInvMov ;
      private bool[] T000U31_n219TipoInvMov ;
      private short[] T000U31_A223TipoInvSigno ;
      private bool[] T000U31_n223TipoInvSigno ;
      private short[] T000U33_A292stockBod ;
      private bool[] T000U33_n292stockBod ;
      private decimal[] T000U35_A294ingBod ;
      private decimal[] T000U35_A295egrBod ;
      private short[] T000U36_A290stockAnio ;
      private short[] T000U36_A291stockMes ;
      private short[] T000U36_A1EmpID ;
      private short[] T000U36_A2AgeID ;
      private short[] T000U36_A42BodCod ;
      private String[] T000U36_A43TipoInv ;
      private short[] T000U37_A290stockAnio ;
      private short[] T000U37_A291stockMes ;
      private short[] T000U37_A42BodCod ;
      private String[] T000U37_A43TipoInv ;
      private short[] T000U37_A348stockDetID ;
      private String[] T000U37_A309prdNombre ;
      private bool[] T000U37_n309prdNombre ;
      private decimal[] T000U37_A296cantidad ;
      private bool[] T000U37_n296cantidad ;
      private decimal[] T000U37_A297stock ;
      private bool[] T000U37_n297stock ;
      private decimal[] T000U37_A298costo ;
      private bool[] T000U37_n298costo ;
      private short[] T000U37_A1EmpID ;
      private short[] T000U37_A2AgeID ;
      private short[] T000U37_A286PrdCod ;
      private String[] T000U4_A309prdNombre ;
      private bool[] T000U4_n309prdNombre ;
      private String[] T000U38_A309prdNombre ;
      private bool[] T000U38_n309prdNombre ;
      private short[] T000U39_A290stockAnio ;
      private short[] T000U39_A291stockMes ;
      private short[] T000U39_A1EmpID ;
      private short[] T000U39_A2AgeID ;
      private short[] T000U39_A42BodCod ;
      private String[] T000U39_A43TipoInv ;
      private short[] T000U39_A348stockDetID ;
      private short[] T000U3_A290stockAnio ;
      private short[] T000U3_A291stockMes ;
      private short[] T000U3_A42BodCod ;
      private String[] T000U3_A43TipoInv ;
      private short[] T000U3_A348stockDetID ;
      private decimal[] T000U3_A296cantidad ;
      private bool[] T000U3_n296cantidad ;
      private decimal[] T000U3_A297stock ;
      private bool[] T000U3_n297stock ;
      private decimal[] T000U3_A298costo ;
      private bool[] T000U3_n298costo ;
      private short[] T000U3_A1EmpID ;
      private short[] T000U3_A2AgeID ;
      private short[] T000U3_A286PrdCod ;
      private short[] T000U2_A290stockAnio ;
      private short[] T000U2_A291stockMes ;
      private short[] T000U2_A42BodCod ;
      private String[] T000U2_A43TipoInv ;
      private short[] T000U2_A348stockDetID ;
      private decimal[] T000U2_A296cantidad ;
      private bool[] T000U2_n296cantidad ;
      private decimal[] T000U2_A297stock ;
      private bool[] T000U2_n297stock ;
      private decimal[] T000U2_A298costo ;
      private bool[] T000U2_n298costo ;
      private short[] T000U2_A1EmpID ;
      private short[] T000U2_A2AgeID ;
      private short[] T000U2_A286PrdCod ;
      private String[] T000U43_A309prdNombre ;
      private bool[] T000U43_n309prdNombre ;
      private short[] T000U44_A290stockAnio ;
      private short[] T000U44_A291stockMes ;
      private short[] T000U44_A1EmpID ;
      private short[] T000U44_A2AgeID ;
      private short[] T000U44_A42BodCod ;
      private String[] T000U44_A43TipoInv ;
      private short[] T000U44_A348stockDetID ;
      private short[] T000U45_A1EmpID ;
      private String[] T000U45_A44empdsc ;
      private bool[] T000U45_n44empdsc ;
      private short[] T000U46_A1EmpID ;
      private short[] T000U46_A2AgeID ;
      private String[] T000U46_A46AgeDsc ;
      private bool[] T000U46_n46AgeDsc ;
      private short[] T000U47_A1EmpID ;
      private String[] T000U47_A44empdsc ;
      private bool[] T000U47_n44empdsc ;
      private short[] T000U48_A1EmpID ;
      private SdtTransactionContext AV14TrnContext ;
      private SdtTransactionContext_Attribute AV17TrnContextAtt ;
   }

   public class prodxbodega__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new UpdateCursor(def[30])
         ,new UpdateCursor(def[31])
         ,new UpdateCursor(def[32])
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new ForEachCursor(def[35])
         ,new ForEachCursor(def[36])
         ,new ForEachCursor(def[37])
         ,new ForEachCursor(def[38])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000U16 ;
          prmT000U16 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          String cmdBufferT000U16 ;
          cmdBufferT000U16=" SELECT TM1.[stockAnio], TM1.[stockMes], T2.[BodDsc], T3.[TipoInvMov], T3.[TipoInvSigno], TM1.[prdStockDsc], TM1.[invFisico], TM1.[EmpID], TM1.[AgeID], TM1.[BodCod], TM1.[TipoInv], COALESCE( T4.[stockBod], 0) AS stockBod, COALESCE( T5.[ingBod], 0) AS ingBod, COALESCE( T5.[egrBod], 0) AS egrBod FROM (((([ProdxBodega] TM1 WITH (NOLOCK) INNER JOIN [Bodegas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID] AND T2.[BodCod] = TM1.[BodCod]) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = TM1.[TipoInv]) LEFT JOIN (SELECT SUM([stock]) AS stockBod, [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodegaTipo] WITH (NOLOCK) GROUP BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] ) T4 ON T4.[stockAnio] = TM1.[stockAnio] AND T4.[stockMes] = TM1.[stockMes] AND T4.[EmpID] = TM1.[EmpID] AND T4.[AgeID] = TM1.[AgeID] AND T4.[BodCod] = TM1.[BodCod] AND T4.[TipoInv] = TM1.[TipoInv]) LEFT JOIN (SELECT SUM(CASE  WHEN COALESCE( T7.[TipoInvSigno], 0) = 1 THEN COALESCE( T6.[cantidad], 0) ELSE 0 END) AS ingBod, T6.[stockAnio], T6.[stockMes], T6.[EmpID], T6.[AgeID], T6.[BodCod], T6.[TipoInv], SUM(CASE  WHEN COALESCE( T7.[TipoInvSigno], 0) = -1 THEN COALESCE( T6.[cantidad], 0) ELSE 0 END) AS egrBod FROM ([ProdxBodegaTipo] T6 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T7 WITH (NOLOCK) ON T7.[TipoInv] = T6.[TipoInv]) GROUP BY T6.[stockAnio], T6.[stockMes], T6.[EmpID], T6.[AgeID], T6.[BodCod], T6.[TipoInv] ) T5 ON T5.[stockAnio] = TM1.[stockAnio] AND T5.[stockMes] = TM1.[stockMes] AND T5.[EmpID] = TM1.[EmpID] AND T5.[AgeID] = TM1.[AgeID] AND T5.[BodCod] = TM1.[BodCod] AND T5.[TipoInv] = TM1.[TipoInv]) WHERE TM1.[stockAnio] = @stockAnio and TM1.[stockMes] = @stockMes and TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[BodCod] = @BodCod and TM1.[TipoInv] "
          + " = @TipoInv ORDER BY TM1.[stockAnio], TM1.[stockMes], TM1.[EmpID], TM1.[AgeID], TM1.[BodCod], TM1.[TipoInv]  OPTION (FAST 100)" ;
          Object[] prmT000U7 ;
          prmT000U7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U8 ;
          prmT000U8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U9 ;
          prmT000U9 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U11 ;
          prmT000U11 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U13 ;
          prmT000U13 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U17 ;
          prmT000U17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U18 ;
          prmT000U18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U19 ;
          prmT000U19 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U21 ;
          prmT000U21 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U23 ;
          prmT000U23 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U24 ;
          prmT000U24 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U6 ;
          prmT000U6 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U25 ;
          prmT000U25 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U26 ;
          prmT000U26 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U5 ;
          prmT000U5 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U27 ;
          prmT000U27 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@prdStockDsc",SqlDbType.VarChar,80,0} ,
          new Object[] {"@invFisico",SqlDbType.Int,9,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U28 ;
          prmT000U28 = new Object[] {
          new Object[] {"@prdStockDsc",SqlDbType.VarChar,80,0} ,
          new Object[] {"@invFisico",SqlDbType.Int,9,0} ,
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U29 ;
          prmT000U29 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U36 ;
          prmT000U36 = new Object[] {
          } ;
          Object[] prmT000U37 ;
          prmT000U37 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U4 ;
          prmT000U4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U38 ;
          prmT000U38 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U39 ;
          prmT000U39 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U3 ;
          prmT000U3 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U2 ;
          prmT000U2 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U40 ;
          prmT000U40 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@cantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@stock",SqlDbType.Decimal,9,2} ,
          new Object[] {"@costo",SqlDbType.Decimal,10,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U41 ;
          prmT000U41 = new Object[] {
          new Object[] {"@cantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@stock",SqlDbType.Decimal,9,2} ,
          new Object[] {"@costo",SqlDbType.Decimal,10,2} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U42 ;
          prmT000U42 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U44 ;
          prmT000U44 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U45 ;
          prmT000U45 = new Object[] {
          } ;
          Object[] prmT000U46 ;
          prmT000U46 = new Object[] {
          new Object[] {"@AV9EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U47 ;
          prmT000U47 = new Object[] {
          } ;
          Object[] prmT000U48 ;
          prmT000U48 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U30 ;
          prmT000U30 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U31 ;
          prmT000U31 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U33 ;
          prmT000U33 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U35 ;
          prmT000U35 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT000U43 ;
          prmT000U43 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000U2", "SELECT [stockAnio], [stockMes], [BodCod], [TipoInv], [stockDetID], [cantidad], [stock], [costo], [EmpID], [AgeID], [PrdCod] FROM [ProdxBodegaTipo] WITH (UPDLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [TipoInv] = @TipoInv AND [stockDetID] = @stockDetID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U2,1,0,true,false )
             ,new CursorDef("T000U3", "SELECT [stockAnio], [stockMes], [BodCod], [TipoInv], [stockDetID], [cantidad], [stock], [costo], [EmpID], [AgeID], [PrdCod] FROM [ProdxBodegaTipo] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [TipoInv] = @TipoInv AND [stockDetID] = @stockDetID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U3,1,0,true,false )
             ,new CursorDef("T000U4", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U4,1,0,true,false )
             ,new CursorDef("T000U5", "SELECT [stockAnio], [stockMes], [prdStockDsc], [invFisico], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodega] WITH (UPDLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U5,1,0,true,false )
             ,new CursorDef("T000U6", "SELECT [stockAnio], [stockMes], [prdStockDsc], [invFisico], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodega] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U6,1,0,true,false )
             ,new CursorDef("T000U7", "SELECT [EmpID] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U7,1,0,true,false )
             ,new CursorDef("T000U8", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U8,1,0,true,false )
             ,new CursorDef("T000U9", "SELECT [TipoInvMov], [TipoInvSigno] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U9,1,0,true,false )
             ,new CursorDef("T000U11", "SELECT COALESCE( T1.[stockBod], 0) AS stockBod FROM (SELECT SUM([stock]) AS stockBod, [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodegaTipo] WITH (UPDLOCK) GROUP BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U11,1,0,true,false )
             ,new CursorDef("T000U13", "SELECT COALESCE( T1.[ingBod], 0) AS ingBod, COALESCE( T1.[egrBod], 0) AS egrBod FROM (SELECT SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = 1 THEN COALESCE( T2.[cantidad], 0) ELSE 0 END) AS ingBod, T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[TipoInv], SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = -1 THEN COALESCE( T2.[cantidad], 0) ELSE 0 END) AS egrBod FROM ([ProdxBodegaTipo] T2 WITH (UPDLOCK) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = T2.[TipoInv]) GROUP BY T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[TipoInv] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U13,1,0,true,false )
             ,new CursorDef("T000U16", cmdBufferT000U16,true, GxErrorMask.GX_NOMASK, false, this,prmT000U16,100,0,true,false )
             ,new CursorDef("T000U17", "SELECT [EmpID] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U17,1,0,true,false )
             ,new CursorDef("T000U18", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U18,1,0,true,false )
             ,new CursorDef("T000U19", "SELECT [TipoInvMov], [TipoInvSigno] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U19,1,0,true,false )
             ,new CursorDef("T000U21", "SELECT COALESCE( T1.[stockBod], 0) AS stockBod FROM (SELECT SUM([stock]) AS stockBod, [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodegaTipo] WITH (UPDLOCK) GROUP BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U21,1,0,true,false )
             ,new CursorDef("T000U23", "SELECT COALESCE( T1.[ingBod], 0) AS ingBod, COALESCE( T1.[egrBod], 0) AS egrBod FROM (SELECT SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = 1 THEN COALESCE( T2.[cantidad], 0) ELSE 0 END) AS ingBod, T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[TipoInv], SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = -1 THEN COALESCE( T2.[cantidad], 0) ELSE 0 END) AS egrBod FROM ([ProdxBodegaTipo] T2 WITH (UPDLOCK) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = T2.[TipoInv]) GROUP BY T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[TipoInv] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U23,1,0,true,false )
             ,new CursorDef("T000U24", "SELECT [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodega] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [TipoInv] = @TipoInv  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U24,1,0,true,false )
             ,new CursorDef("T000U25", "SELECT TOP 1 [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodega] WITH (NOLOCK) WHERE ( [stockAnio] > @stockAnio or [stockAnio] = @stockAnio and [stockMes] > @stockMes or [stockMes] = @stockMes and [stockAnio] = @stockAnio and [EmpID] > @EmpID or [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [AgeID] > @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [BodCod] > @BodCod or [BodCod] = @BodCod and [AgeID] = @AgeID and [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [TipoInv] > @TipoInv) ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U25,1,0,true,true )
             ,new CursorDef("T000U26", "SELECT TOP 1 [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodega] WITH (NOLOCK) WHERE ( [stockAnio] < @stockAnio or [stockAnio] = @stockAnio and [stockMes] < @stockMes or [stockMes] = @stockMes and [stockAnio] = @stockAnio and [EmpID] < @EmpID or [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [AgeID] < @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [BodCod] < @BodCod or [BodCod] = @BodCod and [AgeID] = @AgeID and [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [TipoInv] < @TipoInv) ORDER BY [stockAnio] DESC, [stockMes] DESC, [EmpID] DESC, [AgeID] DESC, [BodCod] DESC, [TipoInv] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U26,1,0,true,true )
             ,new CursorDef("T000U27", "INSERT INTO [ProdxBodega]([stockAnio], [stockMes], [prdStockDsc], [invFisico], [EmpID], [AgeID], [BodCod], [TipoInv]) VALUES(@stockAnio, @stockMes, @prdStockDsc, @invFisico, @EmpID, @AgeID, @BodCod, @TipoInv)", GxErrorMask.GX_NOMASK,prmT000U27)
             ,new CursorDef("T000U28", "UPDATE [ProdxBodega] SET [prdStockDsc]=@prdStockDsc, [invFisico]=@invFisico  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [TipoInv] = @TipoInv", GxErrorMask.GX_NOMASK,prmT000U28)
             ,new CursorDef("T000U29", "DELETE FROM [ProdxBodega]  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [TipoInv] = @TipoInv", GxErrorMask.GX_NOMASK,prmT000U29)
             ,new CursorDef("T000U30", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U30,1,0,true,false )
             ,new CursorDef("T000U31", "SELECT [TipoInvMov], [TipoInvSigno] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U31,1,0,true,false )
             ,new CursorDef("T000U33", "SELECT COALESCE( T1.[stockBod], 0) AS stockBod FROM (SELECT SUM([stock]) AS stockBod, [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodegaTipo] WITH (UPDLOCK) GROUP BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U33,1,0,true,false )
             ,new CursorDef("T000U35", "SELECT COALESCE( T1.[ingBod], 0) AS ingBod, COALESCE( T1.[egrBod], 0) AS egrBod FROM (SELECT SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = 1 THEN COALESCE( T2.[cantidad], 0) ELSE 0 END) AS ingBod, T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[TipoInv], SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = -1 THEN COALESCE( T2.[cantidad], 0) ELSE 0 END) AS egrBod FROM ([ProdxBodegaTipo] T2 WITH (UPDLOCK) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = T2.[TipoInv]) GROUP BY T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[TipoInv] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U35,1,0,true,false )
             ,new CursorDef("T000U36", "SELECT [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodega] WITH (NOLOCK) ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U36,100,0,true,false )
             ,new CursorDef("T000U37", "SELECT T1.[stockAnio], T1.[stockMes], T1.[BodCod], T1.[TipoInv], T1.[stockDetID], T2.[prdNombre], T1.[cantidad], T1.[stock], T1.[costo], T1.[EmpID], T1.[AgeID], T1.[PrdCod] FROM ([ProdxBodegaTipo] T1 WITH (NOLOCK) INNER JOIN [Productos] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[PrdCod] = T1.[PrdCod]) WHERE T1.[stockAnio] = @stockAnio and T1.[stockMes] = @stockMes and T1.[EmpID] = @EmpID and T1.[AgeID] = @AgeID and T1.[BodCod] = @BodCod and T1.[TipoInv] = @TipoInv and T1.[stockDetID] = @stockDetID ORDER BY T1.[stockAnio], T1.[stockMes], T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[TipoInv], T1.[stockDetID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U37,11,0,true,false )
             ,new CursorDef("T000U38", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U38,1,0,true,false )
             ,new CursorDef("T000U39", "SELECT [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv], [stockDetID] FROM [ProdxBodegaTipo] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [TipoInv] = @TipoInv AND [stockDetID] = @stockDetID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U39,1,0,true,false )
             ,new CursorDef("T000U40", "INSERT INTO [ProdxBodegaTipo]([stockAnio], [stockMes], [BodCod], [TipoInv], [stockDetID], [cantidad], [stock], [costo], [EmpID], [AgeID], [PrdCod]) VALUES(@stockAnio, @stockMes, @BodCod, @TipoInv, @stockDetID, @cantidad, @stock, @costo, @EmpID, @AgeID, @PrdCod)", GxErrorMask.GX_NOMASK,prmT000U40)
             ,new CursorDef("T000U41", "UPDATE [ProdxBodegaTipo] SET [cantidad]=@cantidad, [stock]=@stock, [costo]=@costo, [PrdCod]=@PrdCod  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [TipoInv] = @TipoInv AND [stockDetID] = @stockDetID", GxErrorMask.GX_NOMASK,prmT000U41)
             ,new CursorDef("T000U42", "DELETE FROM [ProdxBodegaTipo]  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [TipoInv] = @TipoInv AND [stockDetID] = @stockDetID", GxErrorMask.GX_NOMASK,prmT000U42)
             ,new CursorDef("T000U43", "SELECT [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U43,1,0,true,false )
             ,new CursorDef("T000U44", "SELECT [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv], [stockDetID] FROM [ProdxBodegaTipo] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio and [stockMes] = @stockMes and [EmpID] = @EmpID and [AgeID] = @AgeID and [BodCod] = @BodCod and [TipoInv] = @TipoInv ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv], [stockDetID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U44,11,0,true,false )
             ,new CursorDef("T000U45", "SELECT [EmpID], [empdsc] FROM [Empresas] WITH (NOLOCK) ORDER BY [empdsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U45,0,0,true,false )
             ,new CursorDef("T000U46", "SELECT [EmpID], [AgeID], [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @AV9EmpID ORDER BY [AgeDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U46,0,0,true,false )
             ,new CursorDef("T000U47", "SELECT [EmpID], [empdsc] FROM [Empresas] WITH (NOLOCK) ORDER BY [empdsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U47,0,0,true,false )
             ,new CursorDef("T000U48", "SELECT [EmpID] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U48,1,0,true,false )
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
                ((String[]) buf[3])[0] = rslt.getString(4, 4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((short[]) buf[12])[0] = rslt.getShort(10) ;
                ((short[]) buf[13])[0] = rslt.getShort(11) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((short[]) buf[12])[0] = rslt.getShort(10) ;
                ((short[]) buf[13])[0] = rslt.getShort(11) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((String[]) buf[9])[0] = rslt.getString(8, 4) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((String[]) buf[9])[0] = rslt.getString(8, 4) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 9 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((int[]) buf[10])[0] = rslt.getInt(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                ((short[]) buf[14])[0] = rslt.getShort(10) ;
                ((String[]) buf[15])[0] = rslt.getString(11, 4) ;
                ((short[]) buf[16])[0] = rslt.getShort(12) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((decimal[]) buf[18])[0] = rslt.getDecimal(13) ;
                ((decimal[]) buf[19])[0] = rslt.getDecimal(14) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 15 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 4) ;
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 4) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 4) ;
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 24 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 25 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 26 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 4) ;
                return;
             case 27 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((decimal[]) buf[11])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                return;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 29 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 4) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
                ((String[]) buf[5])[0] = rslt.getString(6, 4) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 35 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 36 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 37 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 38 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
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
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(4, (int)parms[5]);
                }
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (String)parms[9]);
                return;
             case 20 :
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
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[3]);
                }
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (short)parms[5]);
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (String)parms[9]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 29 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (decimal)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (decimal)parms[10]);
                }
                stmt.SetParameter(9, (short)parms[11]);
                stmt.SetParameter(10, (short)parms[12]);
                stmt.SetParameter(11, (short)parms[13]);
                return;
             case 31 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (decimal)parms[1]);
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
                stmt.SetParameter(9, (short)parms[11]);
                stmt.SetParameter(10, (String)parms[12]);
                stmt.SetParameter(11, (short)parms[13]);
                return;
             case 32 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
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
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 36 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 38 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
