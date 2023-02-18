/*
               File: ProdStockBodega
        Description: Prod Stock Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/9/2023 12:20:7.32
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
   public class prodstockbodega : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
            GXDLAAGEID1184( AV9EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_50") == 0 )
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
            gxLoad_50( A1EmpID, A42BodCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_51") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A286PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_51( A1EmpID, A2AgeID, A286PrdCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_52") == 0 )
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
            A286PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_52( A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_53") == 0 )
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
            A286PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_53( A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_54") == 0 )
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
            A286PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_54( A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_57") == 0 )
         {
            A383ingTipoInv = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_57( A383ingTipoInv) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_56") == 0 )
         {
            A37PrvRuc = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_56( A37PrvRuc) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_60") == 0 )
         {
            A43TipoInv = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_60( A43TipoInv) ;
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
            nRC_GXsfl_109 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_109_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_109_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGrid1_newrow( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridprodxbodega_tipo") == 0 )
         {
            nRC_GXsfl_128 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_128_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_128_idx = GetNextPar( );
            A350stockUltNro = (short)(NumberUtil.Val( GetNextPar( ), "."));
            n350stockUltNro = false;
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
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
               AV15stockAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15stockAnio), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSTOCKANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV15stockAnio), "ZZZ9"), context));
               AV16stockMes = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16stockMes), 2, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSTOCKMES", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16stockMes), "Z9"), context));
               AV9EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9EmpID), "ZZZ9"), context));
               AV7AgeID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7AgeID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7AgeID), "ZZZ9"), context));
               AV8BodCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BodCod), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBODCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BodCod), "ZZZ9"), context));
               AV14PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14PrdCod), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPRDCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14PrdCod), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Prod Stock Bodega", 0) ;
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

      public prodstockbodega( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prodstockbodega( IGxContext context )
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
                           short aP6_PrdCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV15stockAnio = aP1_stockAnio;
         this.AV16stockMes = aP2_stockMes;
         this.AV9EmpID = aP3_EmpID;
         this.AV7AgeID = aP4_AgeID;
         this.AV8BodCod = aP5_BodCod;
         this.AV14PrdCod = aP6_PrdCod;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2 col-lg-11 col-lg-offset-1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Prodx Bodega", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_ProdStockBodega.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2 col-lg-11 col-lg-offset-1", "left", "top", "", "", "div");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx02c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"STOCKANIO"+"'), id:'"+"STOCKANIO"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"STOCKMES"+"'), id:'"+"STOCKMES"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"BODCOD"+"'), id:'"+"BODCOD"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"PRDCOD"+"'), id:'"+"PRDCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_ProdStockBodega.htm");
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
            GxWebStd.gx_combobox_ctrl1( context, dynEmpID, dynEmpID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)), 1, dynEmpID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynEmpID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "", true, "HLP_ProdStockBodega.htm");
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
            GxWebStd.gx_combobox_ctrl1( context, dynAgeID, dynAgeID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)), 1, dynAgeID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynAgeID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "", true, "HLP_ProdStockBodega.htm");
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
            GxWebStd.gx_single_line_edit( context, edtstockAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A290stockAnio), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A290stockAnio), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstockAnio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtstockAnio_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdStockBodega.htm");
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
            GxWebStd.gx_combobox_ctrl1( context, cmbstockMes, cmbstockMes_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)), 1, cmbstockMes_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbstockMes.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "", true, "HLP_ProdStockBodega.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBodCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42BodCod), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A42BodCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodCod_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_ProdStockBodega.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_42_Internalname, sImgUrl, imgprompt_1_42_Link, "", "", context.GetTheme( ), imgprompt_1_42_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdStockBodega.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBodDsc_Internalname, StringUtil.RTrim( A217BodDsc), StringUtil.RTrim( context.localUtil.Format( A217BodDsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBodDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBodDsc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-5 FormCellFields", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPrdCod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPrdCod_Internalname, "Codigo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPrdCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A286PrdCod), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A286PrdCod), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPrdCod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPrdCod_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdStockBodega.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_2_286_Internalname, sImgUrl, imgprompt_1_2_286_Link, "", "", context.GetTheme( ), imgprompt_1_2_286_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-7 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtprdNombre_Internalname, "Tipo Movimiento", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtprdNombre_Internalname, A309prdNombre, StringUtil.RTrim( context.localUtil.Format( A309prdNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprdNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtprdNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdStockBodega.htm");
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
            GxWebStd.gx_single_line_edit( context, edtprdStockDsc_Internalname, A307prdStockDsc, StringUtil.RTrim( context.localUtil.Format( A307prdStockDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprdStockDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtprdStockDsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdStockBodega.htm");
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
            GxWebStd.gx_label_element( context, edtinvFisico_Internalname, "Inv. Fisico/S. Inicial", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtinvFisico_Internalname, StringUtil.LTrim( StringUtil.NToC( A293invFisico, 6, 2, ",", "")), ((edtinvFisico_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A293invFisico, "ZZ9.99")) : context.localUtil.Format( A293invFisico, "ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtinvFisico_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtinvFisico_Enabled, 0, "text", "", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection5_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtingBod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtingBod_Internalname, "Ingresos Bodega", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtingBod_Internalname, StringUtil.LTrim( StringUtil.NToC( A294ingBod, 9, 2, ",", "")), ((edtingBod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A294ingBod, "ZZZZZ9.99")) : context.localUtil.Format( A294ingBod, "ZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtingBod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtingBod_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection6_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtegrBod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtegrBod_Internalname, "Salidas Bodega", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtegrBod_Internalname, StringUtil.LTrim( StringUtil.NToC( A295egrBod, 9, 2, ",", "")), ((edtegrBod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A295egrBod, "ZZZZZ9.99")) : context.localUtil.Format( A295egrBod, "ZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtegrBod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtegrBod_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection7_Internalname, 1, 0, "px", 0, "px", "SectionHead1", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtstockBod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtstockBod_Internalname, "Stock Bodega", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtstockBod_Internalname, StringUtil.LTrim( StringUtil.NToC( A292stockBod, 9, 2, ",", "")), ((edtstockBod_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A292stockBod, "ZZ.ZZ9.99")) : context.localUtil.Format( A292stockBod, "ZZ.ZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtstockBod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtstockBod_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdStockBodega.htm");
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
            GxWebStd.gx_label_ctrl( context, lblTitletipo_Internalname, "Movimientos", "", "", lblTitletipo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"TABMOVIMIENTOSContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABMOVIMIENTOSContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabpageing_title_Internalname, "Ingresos", "", "", lblTabpageing_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ProdStockBodega.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabPageIng") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABMOVIMIENTOSContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Grid1( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABMOVIMIENTOSContainer"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabpageegr_title_Internalname, "Egresos", "", "", lblTabpageegr_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ProdStockBodega.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TabPageEgr") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABMOVIMIENTOSContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage2table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridprodxbodega_tipo( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-11 col-lg-offset-1", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 150,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 152,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 154,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdStockBodega.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm1184( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Grid1( )
      {
         /*  Grid Control  */
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("Header", subGrid1_Header);
         Grid1Container.AddObjectProperty("Class", "Grid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A389stockDetIngID), 4, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetIngID_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A383ingTipoInv));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoInv_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", A384ingTipoInvMov);
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoInvMov_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A385ingTipoSigno), 2, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoSigno_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A37PrvRuc));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvRuc_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", A184PrvDsc);
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvDsc_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A386ingCantidad, 9, 2, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingCantidad_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A390ingBodNroDoc), 4, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingBodNroDoc_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A391ingBodTipoDoc));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingBodTipoDoc_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A387fchMovIng, "99/99/9999"));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtfchMovIng_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", context.localUtil.TToC( A388hraMovIng, 10, 8, 0, 3, "/", ":", " "));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edthraMovIng_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
         nGXsfl_109_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount89 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_89 = 1;
               ScanStart1189( ) ;
               while ( RcdFound89 != 0 )
               {
                  init_level_properties89( ) ;
                  getByPrimaryKey1189( ) ;
                  AddRow1189( ) ;
                  ScanNext1189( ) ;
               }
               ScanEnd1189( ) ;
               nBlankRcdCount89 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B350stockUltNro = A350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            B295egrBod = A295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            B349totalStock = A349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            B294ingBod = A294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            standaloneNotModal1189( ) ;
            standaloneModal1189( ) ;
            sMode89 = Gx_mode;
            while ( nGXsfl_109_idx < nRC_GXsfl_109 )
            {
               bGXsfl_109_Refreshing = true;
               ReadRow1189( ) ;
               edtstockDetIngID_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCKDETINGID_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetIngID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetIngID_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               edtingTipoInv_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGTIPOINV_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipoInv_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               edtingTipoInvMov_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGTIPOINVMOV_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipoInvMov_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipoInvMov_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               edtingTipoSigno_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGTIPOSIGNO_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipoSigno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipoSigno_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               edtPrvRuc_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRVRUC_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               edtPrvDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRVDSC_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvDsc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               edtingCantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGCANTIDAD_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingCantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingCantidad_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               edtingBodNroDoc_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGBODNRODOC_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodNroDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodNroDoc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               edtingBodTipoDoc_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGBODTIPODOC_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTipoDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTipoDoc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               edtfchMovIng_Enabled = (int)(context.localUtil.CToN( cgiGet( "FCHMOVING_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfchMovIng_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfchMovIng_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               edthraMovIng_Enabled = (int)(context.localUtil.CToN( cgiGet( "HRAMOVING_"+sGXsfl_109_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edthraMovIng_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edthraMovIng_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
               imgprompt_1_42_Link = cgiGet( "PROMPT_383_"+sGXsfl_109_idx+"Link");
               imgprompt_1_42_Link = cgiGet( "PROMPT_37_"+sGXsfl_109_idx+"Link");
               if ( ( nRcdExists_89 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal1189( ) ;
               }
               SendRow1189( ) ;
               bGXsfl_109_Refreshing = false;
            }
            Gx_mode = sMode89;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A350stockUltNro = B350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            A295egrBod = B295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            A349totalStock = B349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            A294ingBod = B294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount89 = 5;
            nRcdExists_89 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart1189( ) ;
               while ( RcdFound89 != 0 )
               {
                  sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_10989( ) ;
                  init_level_properties89( ) ;
                  standaloneNotModal1189( ) ;
                  getByPrimaryKey1189( ) ;
                  standaloneModal1189( ) ;
                  AddRow1189( ) ;
                  ScanNext1189( ) ;
               }
               ScanEnd1189( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode89 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_10989( ) ;
            InitAll1189( ) ;
            init_level_properties89( ) ;
            B350stockUltNro = A350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            B295egrBod = A295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            B349totalStock = A349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            B294ingBod = A294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            standaloneNotModal1189( ) ;
            standaloneModal1189( ) ;
            nRcdExists_89 = 0;
            nIsMod_89 = 0;
            nRcdDeleted_89 = 0;
            nBlankRcdCount89 = (short)(nBlankRcdUsr89+nBlankRcdCount89);
            fRowAdded = 0;
            while ( nBlankRcdCount89 > 0 )
            {
               AddRow1189( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtstockDetIngID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount89 = (short)(nBlankRcdCount89-1);
            }
            Gx_mode = sMode89;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A350stockUltNro = B350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            A295egrBod = B295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            A349totalStock = B349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            A294ingBod = B294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
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
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.RTrim( A43TipoInv));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInv_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", A219TipoInvMov);
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvMov_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvSigno_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A296cantidad, 10, 2, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidad_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteID_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.RTrim( A56ClienteRUC));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteRUC_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.RTrim( A57ClienteDsc));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteDsc_Enabled), 5, 0, ".", "")));
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
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A351stockDetNroDoc), 4, 0, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetNroDoc_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.RTrim( A352stockdetTipo));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockdetTipo_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", context.localUtil.Format(A374fchMovStock, "99/99/9999"));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtfchMovStock_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", context.localUtil.TToC( A375hraMovStock, 10, 8, 0, 3, "/", ":", " "));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edthraMovStock_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A300ingTipo, 10, 2, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipo_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A301egrTipo, 10, 2, ".", "")));
         Gridprodxbodega_tipoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtegrTipo_Enabled), 5, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddColumnProperties(Gridprodxbodega_tipoColumn);
         Gridprodxbodega_tipoContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Selectedindex), 4, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Allowselection), 1, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Selectioncolor), 9, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Allowhovering), 1, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Hoveringcolor), 9, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Allowcollapsing), 1, 0, ".", "")));
         Gridprodxbodega_tipoContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridprodxbodega_tipo_Collapsed), 1, 0, ".", "")));
         nGXsfl_128_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount85 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_85 = 1;
               ScanStart1185( ) ;
               while ( RcdFound85 != 0 )
               {
                  init_level_properties85( ) ;
                  getByPrimaryKey1185( ) ;
                  AddRow1185( ) ;
                  ScanNext1185( ) ;
               }
               ScanEnd1185( ) ;
               nBlankRcdCount85 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B350stockUltNro = A350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            B295egrBod = A295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            B349totalStock = A349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            B294ingBod = A294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            standaloneNotModal1185( ) ;
            standaloneModal1185( ) ;
            sMode85 = Gx_mode;
            while ( nGXsfl_128_idx < nRC_GXsfl_128 )
            {
               bGXsfl_128_Refreshing = true;
               ReadRow1185( ) ;
               edtstockDetID_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCKDETID_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetID_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtTipoInv_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOINV_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtTipoInvMov_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOINVMOV_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvMov_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInvMov_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtTipoInvSigno_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOINVSIGNO_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvSigno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInvSigno_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtcantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTIDAD_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcantidad_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtClienteID_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTEID_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtClienteRUC_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTERUC_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteRUC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteRUC_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtClienteDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTEDSC_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteDsc_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtstock_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCK_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtcosto_Enabled = (int)(context.localUtil.CToN( cgiGet( "COSTO_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcosto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcosto_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtcostUni_Enabled = (int)(context.localUtil.CToN( cgiGet( "COSTUNI_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcostUni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcostUni_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtstockDetNroDoc_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCKDETNRODOC_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetNroDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetNroDoc_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtstockdetTipo_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCKDETTIPO_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockdetTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockdetTipo_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtfchMovStock_Enabled = (int)(context.localUtil.CToN( cgiGet( "FCHMOVSTOCK_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfchMovStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfchMovStock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edthraMovStock_Enabled = (int)(context.localUtil.CToN( cgiGet( "HRAMOVSTOCK_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edthraMovStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edthraMovStock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtingTipo_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGTIPO_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipo_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               edtegrTipo_Enabled = (int)(context.localUtil.CToN( cgiGet( "EGRTIPO_"+sGXsfl_128_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtegrTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtegrTipo_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
               imgprompt_1_42_Link = cgiGet( "PROMPT_43_"+sGXsfl_128_idx+"Link");
               if ( ( nRcdExists_85 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal1185( ) ;
               }
               SendRow1185( ) ;
               bGXsfl_128_Refreshing = false;
            }
            Gx_mode = sMode85;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A350stockUltNro = B350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            A295egrBod = B295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            A349totalStock = B349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            A294ingBod = B294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount85 = 5;
            nRcdExists_85 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart1185( ) ;
               while ( RcdFound85 != 0 )
               {
                  sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_128_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_12885( ) ;
                  init_level_properties85( ) ;
                  standaloneNotModal1185( ) ;
                  getByPrimaryKey1185( ) ;
                  standaloneModal1185( ) ;
                  AddRow1185( ) ;
                  ScanNext1185( ) ;
               }
               ScanEnd1185( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode85 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_128_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_12885( ) ;
            InitAll1185( ) ;
            init_level_properties85( ) ;
            B350stockUltNro = A350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            B295egrBod = A295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            B349totalStock = A349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            B294ingBod = A294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            standaloneNotModal1185( ) ;
            standaloneModal1185( ) ;
            nRcdExists_85 = 0;
            nIsMod_85 = 0;
            nRcdDeleted_85 = 0;
            nBlankRcdCount85 = (short)(nBlankRcdUsr85+nBlankRcdCount85);
            fRowAdded = 0;
            while ( nBlankRcdCount85 > 0 )
            {
               AddRow1185( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtstockDetID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount85 = (short)(nBlankRcdCount85-1);
            }
            Gx_mode = sMode85;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A350stockUltNro = B350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            A295egrBod = B295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            A349totalStock = B349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            A294ingBod = B294ingBod;
            n294ingBod = false;
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
         E11112 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PRDCOD");
                  AnyError = 1;
                  GX_FocusControl = edtPrdCod_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A286PrdCod = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
               }
               else
               {
                  A286PrdCod = (short)(context.localUtil.CToN( cgiGet( edtPrdCod_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
               }
               A309prdNombre = cgiGet( edtprdNombre_Internalname);
               n309prdNombre = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
               A307prdStockDsc = cgiGet( edtprdStockDsc_Internalname);
               n307prdStockDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307prdStockDsc", A307prdStockDsc);
               n307prdStockDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A307prdStockDsc)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtinvFisico_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtinvFisico_Internalname), ",", ".") > 999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "INVFISICO");
                  AnyError = 1;
                  GX_FocusControl = edtinvFisico_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A293invFisico = 0;
                  n293invFisico = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293invFisico", StringUtil.LTrim( StringUtil.Str( A293invFisico, 6, 2)));
               }
               else
               {
                  A293invFisico = context.localUtil.CToN( cgiGet( edtinvFisico_Internalname), ",", ".");
                  n293invFisico = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293invFisico", StringUtil.LTrim( StringUtil.Str( A293invFisico, 6, 2)));
               }
               n293invFisico = ((Convert.ToDecimal(0)==A293invFisico) ? true : false);
               A294ingBod = context.localUtil.CToN( cgiGet( edtingBod_Internalname), ",", ".");
               n294ingBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               A295egrBod = context.localUtil.CToN( cgiGet( edtegrBod_Internalname), ",", ".");
               n295egrBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               A292stockBod = context.localUtil.CToN( cgiGet( edtstockBod_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
               /* Read saved values. */
               Z290stockAnio = (short)(context.localUtil.CToN( cgiGet( "Z290stockAnio"), ",", "."));
               Z291stockMes = (short)(context.localUtil.CToN( cgiGet( "Z291stockMes"), ",", "."));
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z2AgeID = (short)(context.localUtil.CToN( cgiGet( "Z2AgeID"), ",", "."));
               Z42BodCod = (short)(context.localUtil.CToN( cgiGet( "Z42BodCod"), ",", "."));
               Z286PrdCod = (short)(context.localUtil.CToN( cgiGet( "Z286PrdCod"), ",", "."));
               Z307prdStockDsc = cgiGet( "Z307prdStockDsc");
               n307prdStockDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A307prdStockDsc)) ? true : false);
               Z293invFisico = context.localUtil.CToN( cgiGet( "Z293invFisico"), ",", ".");
               n293invFisico = ((Convert.ToDecimal(0)==A293invFisico) ? true : false);
               Z350stockUltNro = (short)(context.localUtil.CToN( cgiGet( "Z350stockUltNro"), ",", "."));
               n350stockUltNro = ((0==A350stockUltNro) ? true : false);
               A350stockUltNro = (short)(context.localUtil.CToN( cgiGet( "Z350stockUltNro"), ",", "."));
               n350stockUltNro = false;
               n350stockUltNro = ((0==A350stockUltNro) ? true : false);
               O350stockUltNro = (short)(context.localUtil.CToN( cgiGet( "O350stockUltNro"), ",", "."));
               n350stockUltNro = ((0==A350stockUltNro) ? true : false);
               O295egrBod = context.localUtil.CToN( cgiGet( "O295egrBod"), ",", ".");
               O349totalStock = context.localUtil.CToN( cgiGet( "O349totalStock"), ",", ".");
               O294ingBod = context.localUtil.CToN( cgiGet( "O294ingBod"), ",", ".");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_109 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_109"), ",", "."));
               nRC_GXsfl_128 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_128"), ",", "."));
               AV15stockAnio = (short)(context.localUtil.CToN( cgiGet( "vSTOCKANIO"), ",", "."));
               AV21anio = (short)(context.localUtil.CToN( cgiGet( "vANIO"), ",", "."));
               AV16stockMes = (short)(context.localUtil.CToN( cgiGet( "vSTOCKMES"), ",", "."));
               AV13mes = (short)(context.localUtil.CToN( cgiGet( "vMES"), ",", "."));
               AV9EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV7AgeID = (short)(context.localUtil.CToN( cgiGet( "vAGEID"), ",", "."));
               AV8BodCod = (short)(context.localUtil.CToN( cgiGet( "vBODCOD"), ",", "."));
               AV14PrdCod = (short)(context.localUtil.CToN( cgiGet( "vPRDCOD"), ",", "."));
               A350stockUltNro = (short)(context.localUtil.CToN( cgiGet( "STOCKULTNRO"), ",", "."));
               n350stockUltNro = ((0==A350stockUltNro) ? true : false);
               A288PrdPres = (short)(context.localUtil.CToN( cgiGet( "PRDPRES"), ",", "."));
               n288PrdPres = false;
               A349totalStock = context.localUtil.CToN( cgiGet( "TOTALSTOCK"), ",", ".");
               AV23Pgmname = cgiGet( "vPGMNAME");
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               Tabmovimientos_Objectcall = cgiGet( "TABMOVIMIENTOS_Objectcall");
               Tabmovimientos_Enabled = StringUtil.StrToBool( cgiGet( "TABMOVIMIENTOS_Enabled"));
               Tabmovimientos_Class = cgiGet( "TABMOVIMIENTOS_Class");
               Tabmovimientos_Activepage = (int)(context.localUtil.CToN( cgiGet( "TABMOVIMIENTOS_Activepage"), ",", "."));
               Tabmovimientos_Activepagecontrolname = cgiGet( "TABMOVIMIENTOS_Activepagecontrolname");
               Tabmovimientos_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TABMOVIMIENTOS_Pagecount"), ",", "."));
               Tabmovimientos_Historymanagement = StringUtil.StrToBool( cgiGet( "TABMOVIMIENTOS_Historymanagement"));
               Tabmovimientos_Visible = StringUtil.StrToBool( cgiGet( "TABMOVIMIENTOS_Visible"));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "ProdStockBodega";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A290stockAnio != Z290stockAnio ) || ( A291stockMes != Z291stockMes ) || ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( A286PrdCod != Z286PrdCod ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("prodstockbodega:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A286PrdCod = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
                  getEqualNoModal( ) ;
                  if ( ! (0==AV15stockAnio) )
                  {
                     A290stockAnio = AV15stockAnio;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                     {
                        A290stockAnio = AV21anio;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
                     }
                  }
                  if ( ! (0==AV16stockMes) )
                  {
                     A291stockMes = AV16stockMes;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                     {
                        A291stockMes = AV13mes;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
                     }
                  }
                  GXAAGEID_html1184( AV9EmpID) ;
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
                     sMode84 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV15stockAnio) )
                     {
                        A290stockAnio = AV15stockAnio;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                        {
                           A290stockAnio = AV21anio;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
                        }
                     }
                     if ( ! (0==AV16stockMes) )
                     {
                        A291stockMes = AV16stockMes;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                        {
                           A291stockMes = AV13mes;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
                        }
                     }
                     GXAAGEID_html1184( AV9EmpID) ;
                     Gx_mode = sMode84;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound84 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_110( ) ;
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
                        E11112 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E12112 ();
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
            E12112 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1184( ) ;
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
            DisableAttributes1184( ) ;
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

      protected void CONFIRM_110( )
      {
         BeforeValidate1184( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1184( ) ;
            }
            else
            {
               CheckExtendedTable1184( ) ;
               CloseExtendedTableCursors1184( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode84 = Gx_mode;
            CONFIRM_1189( ) ;
            if ( AnyError == 0 )
            {
               CONFIRM_1185( ) ;
               if ( AnyError == 0 )
               {
                  /* Restore parent mode. */
                  Gx_mode = sMode84;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  IsConfirmed = 1;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
               }
            }
            /* Restore parent mode. */
            Gx_mode = sMode84;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_1185( )
      {
         s350stockUltNro = O350stockUltNro;
         n350stockUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
         s295egrBod = O295egrBod;
         n295egrBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         s349totalStock = O349totalStock;
         n349totalStock = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
         s292stockBod = O292stockBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         nGXsfl_128_idx = 0;
         while ( nGXsfl_128_idx < nRC_GXsfl_128 )
         {
            ReadRow1185( ) ;
            if ( ( nRcdExists_85 != 0 ) || ( nIsMod_85 != 0 ) )
            {
               GetKey1185( ) ;
               if ( ( nRcdExists_85 == 0 ) && ( nRcdDeleted_85 == 0 ) )
               {
                  if ( RcdFound85 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate1185( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1185( ) ;
                        CloseExtendedTableCursors1185( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O350stockUltNro = A350stockUltNro;
                        n350stockUltNro = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
                        O295egrBod = A295egrBod;
                        n295egrBod = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                        O349totalStock = A349totalStock;
                        n349totalStock = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
                        O292stockBod = A292stockBod;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                     }
                  }
                  else
                  {
                     GXCCtl = "STOCKDETID_" + sGXsfl_128_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtstockDetID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound85 != 0 )
                  {
                     if ( nRcdDeleted_85 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey1185( ) ;
                        Load1185( ) ;
                        BeforeValidate1185( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1185( ) ;
                           O350stockUltNro = A350stockUltNro;
                           n350stockUltNro = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
                           O295egrBod = A295egrBod;
                           n295egrBod = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                           O349totalStock = A349totalStock;
                           n349totalStock = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
                           O292stockBod = A292stockBod;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_85 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate1185( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1185( ) ;
                              CloseExtendedTableCursors1185( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O350stockUltNro = A350stockUltNro;
                              n350stockUltNro = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
                              O295egrBod = A295egrBod;
                              n295egrBod = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                              O349totalStock = A349totalStock;
                              n349totalStock = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
                              O292stockBod = A292stockBod;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_85 == 0 )
                     {
                        GXCCtl = "STOCKDETID_" + sGXsfl_128_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtstockDetID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtstockDetID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A348stockDetID), 4, 0, ",", ""))) ;
            ChangePostValue( edtTipoInv_Internalname, StringUtil.RTrim( A43TipoInv)) ;
            ChangePostValue( edtTipoInvMov_Internalname, A219TipoInvMov) ;
            ChangePostValue( edtTipoInvSigno_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ",", ""))) ;
            ChangePostValue( edtcantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A296cantidad, 10, 2, ",", ""))) ;
            ChangePostValue( edtClienteID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", ""))) ;
            ChangePostValue( edtClienteRUC_Internalname, StringUtil.RTrim( A56ClienteRUC)) ;
            ChangePostValue( edtClienteDsc_Internalname, StringUtil.RTrim( A57ClienteDsc)) ;
            ChangePostValue( edtstock_Internalname, StringUtil.LTrim( StringUtil.NToC( A297stock, 9, 2, ",", ""))) ;
            ChangePostValue( edtcosto_Internalname, StringUtil.LTrim( StringUtil.NToC( A298costo, 13, 2, ",", ""))) ;
            ChangePostValue( edtcostUni_Internalname, StringUtil.LTrim( StringUtil.NToC( A299costUni, 13, 2, ",", ""))) ;
            ChangePostValue( edtstockDetNroDoc_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A351stockDetNroDoc), 4, 0, ",", ""))) ;
            ChangePostValue( edtstockdetTipo_Internalname, StringUtil.RTrim( A352stockdetTipo)) ;
            ChangePostValue( edtfchMovStock_Internalname, context.localUtil.Format(A374fchMovStock, "99/99/9999")) ;
            ChangePostValue( edthraMovStock_Internalname, context.localUtil.TToC( A375hraMovStock, 10, 8, 0, 3, "/", ":", " ")) ;
            ChangePostValue( edtingTipo_Internalname, StringUtil.LTrim( StringUtil.NToC( A300ingTipo, 10, 2, ",", ""))) ;
            ChangePostValue( edtegrTipo_Internalname, StringUtil.LTrim( StringUtil.NToC( A301egrTipo, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z348stockDetID_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z348stockDetID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z296cantidad_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( Z296cantidad, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z297stock_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( Z297stock, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z351stockDetNroDoc_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z351stockDetNroDoc), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z352stockdetTipo_"+sGXsfl_128_idx, StringUtil.RTrim( Z352stockdetTipo)) ;
            ChangePostValue( "ZT_"+"Z298costo_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( Z298costo, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z374fchMovStock_"+sGXsfl_128_idx, context.localUtil.DToC( Z374fchMovStock, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z375hraMovStock_"+sGXsfl_128_idx, context.localUtil.TToC( Z375hraMovStock, 10, 8, 0, 0, "/", ":", " ")) ;
            ChangePostValue( "ZT_"+"Z5ClienteID_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5ClienteID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z43TipoInv_"+sGXsfl_128_idx, StringUtil.RTrim( Z43TipoInv)) ;
            ChangePostValue( "T301egrTipo_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( O301egrTipo, 9, 2, ",", ""))) ;
            ChangePostValue( "T297stock_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( O297stock, 9, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_85_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_85), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_85_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_85), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_85_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_85), 4, 0, ",", ""))) ;
            if ( nIsMod_85 != 0 )
            {
               ChangePostValue( "STOCKDETID_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOINV_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInv_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOINVMOV_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvMov_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOINVSIGNO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvSigno_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTIDAD_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CLIENTEID_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CLIENTERUC_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteRUC_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CLIENTEDSC_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "STOCK_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstock_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COSTO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcosto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COSTUNI_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcostUni_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "STOCKDETNRODOC_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetNroDoc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "STOCKDETTIPO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockdetTipo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FCHMOVSTOCK_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtfchMovStock_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "HRAMOVSTOCK_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edthraMovStock_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGTIPO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EGRTIPO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtegrTipo_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O350stockUltNro = s350stockUltNro;
         n350stockUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
         O295egrBod = s295egrBod;
         n295egrBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         O349totalStock = s349totalStock;
         n349totalStock = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
         O292stockBod = s292stockBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_1189( )
      {
         s294ingBod = O294ingBod;
         n294ingBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         s292stockBod = O292stockBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         nGXsfl_109_idx = 0;
         while ( nGXsfl_109_idx < nRC_GXsfl_109 )
         {
            ReadRow1189( ) ;
            if ( ( nRcdExists_89 != 0 ) || ( nIsMod_89 != 0 ) )
            {
               GetKey1189( ) ;
               if ( ( nRcdExists_89 == 0 ) && ( nRcdDeleted_89 == 0 ) )
               {
                  if ( RcdFound89 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate1189( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1189( ) ;
                        CloseExtendedTableCursors1189( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O294ingBod = A294ingBod;
                        n294ingBod = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                        O292stockBod = A292stockBod;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                     }
                  }
                  else
                  {
                     GXCCtl = "STOCKDETINGID_" + sGXsfl_109_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtstockDetIngID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound89 != 0 )
                  {
                     if ( nRcdDeleted_89 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey1189( ) ;
                        Load1189( ) ;
                        BeforeValidate1189( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1189( ) ;
                           O294ingBod = A294ingBod;
                           n294ingBod = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                           O292stockBod = A292stockBod;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_89 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate1189( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1189( ) ;
                              CloseExtendedTableCursors1189( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O294ingBod = A294ingBod;
                              n294ingBod = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                              O292stockBod = A292stockBod;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_89 == 0 )
                     {
                        GXCCtl = "STOCKDETINGID_" + sGXsfl_109_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtstockDetIngID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtstockDetIngID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A389stockDetIngID), 4, 0, ",", ""))) ;
            ChangePostValue( edtingTipoInv_Internalname, StringUtil.RTrim( A383ingTipoInv)) ;
            ChangePostValue( edtingTipoInvMov_Internalname, A384ingTipoInvMov) ;
            ChangePostValue( edtingTipoSigno_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A385ingTipoSigno), 2, 0, ",", ""))) ;
            ChangePostValue( edtPrvRuc_Internalname, StringUtil.RTrim( A37PrvRuc)) ;
            ChangePostValue( edtPrvDsc_Internalname, A184PrvDsc) ;
            ChangePostValue( edtingCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A386ingCantidad, 9, 2, ",", ""))) ;
            ChangePostValue( edtingBodNroDoc_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A390ingBodNroDoc), 4, 0, ",", ""))) ;
            ChangePostValue( edtingBodTipoDoc_Internalname, StringUtil.RTrim( A391ingBodTipoDoc)) ;
            ChangePostValue( edtfchMovIng_Internalname, context.localUtil.Format(A387fchMovIng, "99/99/9999")) ;
            ChangePostValue( edthraMovIng_Internalname, context.localUtil.TToC( A388hraMovIng, 10, 8, 0, 3, "/", ":", " ")) ;
            ChangePostValue( "ZT_"+"Z389stockDetIngID_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z389stockDetIngID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z386ingCantidad_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( Z386ingCantidad, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z387fchMovIng_"+sGXsfl_109_idx, context.localUtil.DToC( Z387fchMovIng, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z388hraMovIng_"+sGXsfl_109_idx, context.localUtil.TToC( Z388hraMovIng, 10, 8, 0, 0, "/", ":", " ")) ;
            ChangePostValue( "ZT_"+"Z390ingBodNroDoc_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z390ingBodNroDoc), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z391ingBodTipoDoc_"+sGXsfl_109_idx, StringUtil.RTrim( Z391ingBodTipoDoc)) ;
            ChangePostValue( "ZT_"+"Z37PrvRuc_"+sGXsfl_109_idx, StringUtil.RTrim( Z37PrvRuc)) ;
            ChangePostValue( "ZT_"+"Z383ingTipoInv_"+sGXsfl_109_idx, StringUtil.RTrim( Z383ingTipoInv)) ;
            ChangePostValue( "T300ingTipo_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( O300ingTipo, 9, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_89_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_89), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_89_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_89), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_89_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_89), 4, 0, ",", ""))) ;
            if ( nIsMod_89 != 0 )
            {
               ChangePostValue( "STOCKDETINGID_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetIngID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGTIPOINV_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoInv_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGTIPOINVMOV_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoInvMov_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGTIPOSIGNO_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoSigno_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRVRUC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvRuc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRVDSC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGCANTIDAD_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingCantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGBODNRODOC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingBodNroDoc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGBODTIPODOC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingBodTipoDoc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FCHMOVING_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtfchMovIng_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "HRAMOVING_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edthraMovIng_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O294ingBod = s294ingBod;
         n294ingBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         O292stockBod = s292stockBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption110( )
      {
      }

      protected void E11112( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV23Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV23Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV18TrnContext.FromXml(AV20WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
      }

      protected void E12112( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV18TrnContext.gxTpr_Callerondelete )
         {
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM1184( short GX_JID )
      {
         if ( ( GX_JID == 49 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z307prdStockDsc = T001111_A307prdStockDsc[0];
               Z293invFisico = T001111_A293invFisico[0];
               Z350stockUltNro = T001111_A350stockUltNro[0];
            }
            else
            {
               Z307prdStockDsc = A307prdStockDsc;
               Z293invFisico = A293invFisico;
               Z350stockUltNro = A350stockUltNro;
            }
         }
         if ( GX_JID == -49 )
         {
            Z290stockAnio = A290stockAnio;
            Z291stockMes = A291stockMes;
            Z307prdStockDsc = A307prdStockDsc;
            Z293invFisico = A293invFisico;
            Z350stockUltNro = A350stockUltNro;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z286PrdCod = A286PrdCod;
            Z217BodDsc = A217BodDsc;
            Z309prdNombre = A309prdNombre;
            Z288PrdPres = A288PrdPres;
            Z349totalStock = A349totalStock;
            Z294ingBod = A294ingBod;
            Z295egrBod = A295egrBod;
         }
      }

      protected void standaloneNotModal( )
      {
         AV13mes = (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13mes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13mes), 2, 0)));
         AV21anio = (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21anio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21anio), 4, 0)));
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_42_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00y0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"BODCOD"+"'), id:'"+"BODCOD"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_1_2_286_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0200.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"AGEID"+"'), id:'"+"AGEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"PRDCOD"+"'), id:'"+"PRDCOD"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV15stockAnio) )
         {
            edtstockAnio_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockAnio_Enabled), 5, 0)), true);
         }
         else
         {
            edtstockAnio_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockAnio_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV15stockAnio) )
         {
            edtstockAnio_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockAnio_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV16stockMes) )
         {
            cmbstockMes.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbstockMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbstockMes.Enabled), 5, 0)), true);
         }
         else
         {
            cmbstockMes.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbstockMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbstockMes.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV16stockMes) )
         {
            cmbstockMes.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbstockMes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbstockMes.Enabled), 5, 0)), true);
         }
         GXAAGEID_html1184( AV9EmpID) ;
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
         if ( ! (0==AV7AgeID) )
         {
            A2AgeID = AV7AgeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
         }
         if ( ! (0==AV7AgeID) )
         {
            dynAgeID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
         }
         else
         {
            dynAgeID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7AgeID) )
         {
            dynAgeID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynAgeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynAgeID.Enabled), 5, 0)), true);
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
         if ( ! (0==AV14PrdCod) )
         {
            A286PrdCod = AV14PrdCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         }
         if ( ! (0==AV14PrdCod) )
         {
            edtPrdCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         }
         else
         {
            edtPrdCod_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV14PrdCod) )
         {
            edtPrdCod_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
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
         if ( ! (0==AV15stockAnio) )
         {
            A290stockAnio = AV15stockAnio;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A290stockAnio = AV21anio;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
            }
         }
         if ( ! (0==AV16stockMes) )
         {
            A291stockMes = AV16stockMes;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A291stockMes = AV13mes;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV23Pgmname = "ProdStockBodega";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23Pgmname", AV23Pgmname);
            /* Using cursor T001112 */
            pr_default.execute(10, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = T001112_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T001112_n217BodDsc[0];
            pr_default.close(10);
            /* Using cursor T001113 */
            pr_default.execute(11, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            A309prdNombre = T001113_A309prdNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
            n309prdNombre = T001113_n309prdNombre[0];
            A288PrdPres = T001113_A288PrdPres[0];
            n288PrdPres = T001113_n288PrdPres[0];
            pr_default.close(11);
            /* Using cursor T001115 */
            pr_default.execute(12, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
            if ( (pr_default.getStatus(12) != 101) )
            {
               A349totalStock = T001115_A349totalStock[0];
               n349totalStock = T001115_n349totalStock[0];
            }
            else
            {
               A349totalStock = 0;
               n349totalStock = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            }
            O349totalStock = A349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            pr_default.close(12);
            /* Using cursor T001117 */
            pr_default.execute(13, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
            if ( (pr_default.getStatus(13) != 101) )
            {
               A294ingBod = T001117_A294ingBod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               n294ingBod = T001117_n294ingBod[0];
            }
            else
            {
               A294ingBod = 0;
               n294ingBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            }
            O294ingBod = A294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            pr_default.close(13);
            /* Using cursor T001119 */
            pr_default.execute(14, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
            if ( (pr_default.getStatus(14) != 101) )
            {
               A295egrBod = T001119_A295egrBod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               n295egrBod = T001119_n295egrBod[0];
            }
            else
            {
               A295egrBod = 0;
               n295egrBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            O295egrBod = A295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            pr_default.close(14);
         }
      }

      protected void Load1184( )
      {
         /* Using cursor T001123 */
         pr_default.execute(15, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound84 = 1;
            A217BodDsc = T001123_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T001123_n217BodDsc[0];
            A309prdNombre = T001123_A309prdNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
            n309prdNombre = T001123_n309prdNombre[0];
            A288PrdPres = T001123_A288PrdPres[0];
            n288PrdPres = T001123_n288PrdPres[0];
            A307prdStockDsc = T001123_A307prdStockDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307prdStockDsc", A307prdStockDsc);
            n307prdStockDsc = T001123_n307prdStockDsc[0];
            A293invFisico = T001123_A293invFisico[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293invFisico", StringUtil.LTrim( StringUtil.Str( A293invFisico, 6, 2)));
            n293invFisico = T001123_n293invFisico[0];
            A350stockUltNro = T001123_A350stockUltNro[0];
            n350stockUltNro = T001123_n350stockUltNro[0];
            A349totalStock = T001123_A349totalStock[0];
            n349totalStock = T001123_n349totalStock[0];
            A294ingBod = T001123_A294ingBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            n294ingBod = T001123_n294ingBod[0];
            A295egrBod = T001123_A295egrBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            n295egrBod = T001123_n295egrBod[0];
            ZM1184( -49) ;
         }
         pr_default.close(15);
         OnLoadActions1184( ) ;
      }

      protected void OnLoadActions1184( )
      {
         O295egrBod = A295egrBod;
         n295egrBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         O349totalStock = A349totalStock;
         n349totalStock = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
         O294ingBod = A294ingBod;
         n294ingBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         AV23Pgmname = "ProdStockBodega";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23Pgmname", AV23Pgmname);
         A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
      }

      protected void CheckExtendedTable1184( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV23Pgmname = "ProdStockBodega";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23Pgmname", AV23Pgmname);
         /* Using cursor T001112 */
         pr_default.execute(10, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A217BodDsc = T001112_A217BodDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = T001112_n217BodDsc[0];
         pr_default.close(10);
         /* Using cursor T001113 */
         pr_default.execute(11, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A309prdNombre = T001113_A309prdNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
         n309prdNombre = T001113_n309prdNombre[0];
         A288PrdPres = T001113_A288PrdPres[0];
         n288PrdPres = T001113_n288PrdPres[0];
         pr_default.close(11);
         /* Using cursor T001115 */
         pr_default.execute(12, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(12) != 101) )
         {
            A349totalStock = T001115_A349totalStock[0];
            n349totalStock = T001115_n349totalStock[0];
         }
         else
         {
            A349totalStock = 0;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
         }
         pr_default.close(12);
         /* Using cursor T001117 */
         pr_default.execute(13, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(13) != 101) )
         {
            A294ingBod = T001117_A294ingBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            n294ingBod = T001117_n294ingBod[0];
         }
         else
         {
            A294ingBod = 0;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         pr_default.close(13);
         /* Using cursor T001119 */
         pr_default.execute(14, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(14) != 101) )
         {
            A295egrBod = T001119_A295egrBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            n295egrBod = T001119_n295egrBod[0];
         }
         else
         {
            A295egrBod = 0;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         }
         pr_default.close(14);
         A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
      }

      protected void CloseExtendedTableCursors1184( )
      {
         pr_default.close(10);
         pr_default.close(11);
         pr_default.close(12);
         pr_default.close(13);
         pr_default.close(14);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_50( short A1EmpID ,
                                short A42BodCod )
      {
         /* Using cursor T001124 */
         pr_default.execute(16, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A217BodDsc = T001124_A217BodDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         n217BodDsc = T001124_n217BodDsc[0];
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

      protected void gxLoad_51( short A1EmpID ,
                                short A2AgeID ,
                                short A286PrdCod )
      {
         /* Using cursor T001125 */
         pr_default.execute(17, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A309prdNombre = T001125_A309prdNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
         n309prdNombre = T001125_n309prdNombre[0];
         A288PrdPres = T001125_A288PrdPres[0];
         n288PrdPres = T001125_n288PrdPres[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A309prdNombre)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A288PrdPres), 2, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(17) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(17);
      }

      protected void gxLoad_52( short A290stockAnio ,
                                short A291stockMes ,
                                short A1EmpID ,
                                short A2AgeID ,
                                short A42BodCod ,
                                short A286PrdCod )
      {
         /* Using cursor T001127 */
         pr_default.execute(18, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(18) != 101) )
         {
            A349totalStock = T001127_A349totalStock[0];
            n349totalStock = T001127_n349totalStock[0];
         }
         else
         {
            A349totalStock = 0;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A349totalStock, 10, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(18) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(18);
      }

      protected void gxLoad_53( short A290stockAnio ,
                                short A291stockMes ,
                                short A1EmpID ,
                                short A2AgeID ,
                                short A42BodCod ,
                                short A286PrdCod )
      {
         /* Using cursor T001129 */
         pr_default.execute(19, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(19) != 101) )
         {
            A294ingBod = T001129_A294ingBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            n294ingBod = T001129_n294ingBod[0];
         }
         else
         {
            A294ingBod = 0;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A294ingBod, 9, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(19) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(19);
      }

      protected void gxLoad_54( short A290stockAnio ,
                                short A291stockMes ,
                                short A1EmpID ,
                                short A2AgeID ,
                                short A42BodCod ,
                                short A286PrdCod )
      {
         /* Using cursor T001131 */
         pr_default.execute(20, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(20) != 101) )
         {
            A295egrBod = T001131_A295egrBod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            n295egrBod = T001131_n295egrBod[0];
         }
         else
         {
            A295egrBod = 0;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A295egrBod, 9, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(20) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(20);
      }

      protected void GetKey1184( )
      {
         /* Using cursor T001132 */
         pr_default.execute(21, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound84 = 1;
         }
         else
         {
            RcdFound84 = 0;
         }
         pr_default.close(21);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001111 */
         pr_default.execute(9, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            ZM1184( 49) ;
            RcdFound84 = 1;
            A290stockAnio = T001111_A290stockAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
            A291stockMes = T001111_A291stockMes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
            A307prdStockDsc = T001111_A307prdStockDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307prdStockDsc", A307prdStockDsc);
            n307prdStockDsc = T001111_n307prdStockDsc[0];
            A293invFisico = T001111_A293invFisico[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293invFisico", StringUtil.LTrim( StringUtil.Str( A293invFisico, 6, 2)));
            n293invFisico = T001111_n293invFisico[0];
            A350stockUltNro = T001111_A350stockUltNro[0];
            n350stockUltNro = T001111_n350stockUltNro[0];
            A1EmpID = T001111_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T001111_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = T001111_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A286PrdCod = T001111_A286PrdCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
            O350stockUltNro = A350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            Z290stockAnio = A290stockAnio;
            Z291stockMes = A291stockMes;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z286PrdCod = A286PrdCod;
            sMode84 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1184( ) ;
            if ( AnyError == 1 )
            {
               RcdFound84 = 0;
               InitializeNonKey1184( ) ;
            }
            Gx_mode = sMode84;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound84 = 0;
            InitializeNonKey1184( ) ;
            sMode84 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode84;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(9);
      }

      protected void getEqualNoModal( )
      {
         GetKey1184( ) ;
         if ( RcdFound84 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound84 = 0;
         /* Using cursor T001133 */
         pr_default.execute(22, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(22) != 101) )
         {
            while ( (pr_default.getStatus(22) != 101) && ( ( T001133_A290stockAnio[0] < A290stockAnio ) || ( T001133_A290stockAnio[0] == A290stockAnio ) && ( T001133_A291stockMes[0] < A291stockMes ) || ( T001133_A291stockMes[0] == A291stockMes ) && ( T001133_A290stockAnio[0] == A290stockAnio ) && ( T001133_A1EmpID[0] < A1EmpID ) || ( T001133_A1EmpID[0] == A1EmpID ) && ( T001133_A291stockMes[0] == A291stockMes ) && ( T001133_A290stockAnio[0] == A290stockAnio ) && ( T001133_A2AgeID[0] < A2AgeID ) || ( T001133_A2AgeID[0] == A2AgeID ) && ( T001133_A1EmpID[0] == A1EmpID ) && ( T001133_A291stockMes[0] == A291stockMes ) && ( T001133_A290stockAnio[0] == A290stockAnio ) && ( T001133_A42BodCod[0] < A42BodCod ) || ( T001133_A42BodCod[0] == A42BodCod ) && ( T001133_A2AgeID[0] == A2AgeID ) && ( T001133_A1EmpID[0] == A1EmpID ) && ( T001133_A291stockMes[0] == A291stockMes ) && ( T001133_A290stockAnio[0] == A290stockAnio ) && ( T001133_A286PrdCod[0] < A286PrdCod ) ) )
            {
               pr_default.readNext(22);
            }
            if ( (pr_default.getStatus(22) != 101) && ( ( T001133_A290stockAnio[0] > A290stockAnio ) || ( T001133_A290stockAnio[0] == A290stockAnio ) && ( T001133_A291stockMes[0] > A291stockMes ) || ( T001133_A291stockMes[0] == A291stockMes ) && ( T001133_A290stockAnio[0] == A290stockAnio ) && ( T001133_A1EmpID[0] > A1EmpID ) || ( T001133_A1EmpID[0] == A1EmpID ) && ( T001133_A291stockMes[0] == A291stockMes ) && ( T001133_A290stockAnio[0] == A290stockAnio ) && ( T001133_A2AgeID[0] > A2AgeID ) || ( T001133_A2AgeID[0] == A2AgeID ) && ( T001133_A1EmpID[0] == A1EmpID ) && ( T001133_A291stockMes[0] == A291stockMes ) && ( T001133_A290stockAnio[0] == A290stockAnio ) && ( T001133_A42BodCod[0] > A42BodCod ) || ( T001133_A42BodCod[0] == A42BodCod ) && ( T001133_A2AgeID[0] == A2AgeID ) && ( T001133_A1EmpID[0] == A1EmpID ) && ( T001133_A291stockMes[0] == A291stockMes ) && ( T001133_A290stockAnio[0] == A290stockAnio ) && ( T001133_A286PrdCod[0] > A286PrdCod ) ) )
            {
               A290stockAnio = T001133_A290stockAnio[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
               A291stockMes = T001133_A291stockMes[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
               A1EmpID = T001133_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T001133_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A42BodCod = T001133_A42BodCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               A286PrdCod = T001133_A286PrdCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
               RcdFound84 = 1;
            }
         }
         pr_default.close(22);
      }

      protected void move_previous( )
      {
         RcdFound84 = 0;
         /* Using cursor T001134 */
         pr_default.execute(23, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(23) != 101) )
         {
            while ( (pr_default.getStatus(23) != 101) && ( ( T001134_A290stockAnio[0] > A290stockAnio ) || ( T001134_A290stockAnio[0] == A290stockAnio ) && ( T001134_A291stockMes[0] > A291stockMes ) || ( T001134_A291stockMes[0] == A291stockMes ) && ( T001134_A290stockAnio[0] == A290stockAnio ) && ( T001134_A1EmpID[0] > A1EmpID ) || ( T001134_A1EmpID[0] == A1EmpID ) && ( T001134_A291stockMes[0] == A291stockMes ) && ( T001134_A290stockAnio[0] == A290stockAnio ) && ( T001134_A2AgeID[0] > A2AgeID ) || ( T001134_A2AgeID[0] == A2AgeID ) && ( T001134_A1EmpID[0] == A1EmpID ) && ( T001134_A291stockMes[0] == A291stockMes ) && ( T001134_A290stockAnio[0] == A290stockAnio ) && ( T001134_A42BodCod[0] > A42BodCod ) || ( T001134_A42BodCod[0] == A42BodCod ) && ( T001134_A2AgeID[0] == A2AgeID ) && ( T001134_A1EmpID[0] == A1EmpID ) && ( T001134_A291stockMes[0] == A291stockMes ) && ( T001134_A290stockAnio[0] == A290stockAnio ) && ( T001134_A286PrdCod[0] > A286PrdCod ) ) )
            {
               pr_default.readNext(23);
            }
            if ( (pr_default.getStatus(23) != 101) && ( ( T001134_A290stockAnio[0] < A290stockAnio ) || ( T001134_A290stockAnio[0] == A290stockAnio ) && ( T001134_A291stockMes[0] < A291stockMes ) || ( T001134_A291stockMes[0] == A291stockMes ) && ( T001134_A290stockAnio[0] == A290stockAnio ) && ( T001134_A1EmpID[0] < A1EmpID ) || ( T001134_A1EmpID[0] == A1EmpID ) && ( T001134_A291stockMes[0] == A291stockMes ) && ( T001134_A290stockAnio[0] == A290stockAnio ) && ( T001134_A2AgeID[0] < A2AgeID ) || ( T001134_A2AgeID[0] == A2AgeID ) && ( T001134_A1EmpID[0] == A1EmpID ) && ( T001134_A291stockMes[0] == A291stockMes ) && ( T001134_A290stockAnio[0] == A290stockAnio ) && ( T001134_A42BodCod[0] < A42BodCod ) || ( T001134_A42BodCod[0] == A42BodCod ) && ( T001134_A2AgeID[0] == A2AgeID ) && ( T001134_A1EmpID[0] == A1EmpID ) && ( T001134_A291stockMes[0] == A291stockMes ) && ( T001134_A290stockAnio[0] == A290stockAnio ) && ( T001134_A286PrdCod[0] < A286PrdCod ) ) )
            {
               A290stockAnio = T001134_A290stockAnio[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
               A291stockMes = T001134_A291stockMes[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
               A1EmpID = T001134_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A2AgeID = T001134_A2AgeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
               A42BodCod = T001134_A42BodCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
               A286PrdCod = T001134_A286PrdCod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
               RcdFound84 = 1;
            }
         }
         pr_default.close(23);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1184( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A294ingBod = O294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            A292stockBod = O292stockBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
            A350stockUltNro = O350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            A295egrBod = O295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            A349totalStock = O349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            A292stockBod = O292stockBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1184( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound84 == 1 )
            {
               if ( ( A290stockAnio != Z290stockAnio ) || ( A291stockMes != Z291stockMes ) || ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( A286PrdCod != Z286PrdCod ) )
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
                  A286PrdCod = Z286PrdCod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "STOCKANIO");
                  AnyError = 1;
                  GX_FocusControl = edtstockAnio_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A294ingBod = O294ingBod;
                  n294ingBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  A292stockBod = O292stockBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                  A350stockUltNro = O350stockUltNro;
                  n350stockUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
                  A295egrBod = O295egrBod;
                  n295egrBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                  A349totalStock = O349totalStock;
                  n349totalStock = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
                  A292stockBod = O292stockBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A294ingBod = O294ingBod;
                  n294ingBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  A292stockBod = O292stockBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                  A350stockUltNro = O350stockUltNro;
                  n350stockUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
                  A295egrBod = O295egrBod;
                  n295egrBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                  A349totalStock = O349totalStock;
                  n349totalStock = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
                  A292stockBod = O292stockBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                  Update1184( ) ;
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A290stockAnio != Z290stockAnio ) || ( A291stockMes != Z291stockMes ) || ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( A286PrdCod != Z286PrdCod ) )
               {
                  /* Insert record */
                  A294ingBod = O294ingBod;
                  n294ingBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  A292stockBod = O292stockBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                  A350stockUltNro = O350stockUltNro;
                  n350stockUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
                  A295egrBod = O295egrBod;
                  n295egrBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                  A349totalStock = O349totalStock;
                  n349totalStock = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
                  A292stockBod = O292stockBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                  GX_FocusControl = dynEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1184( ) ;
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
                     A294ingBod = O294ingBod;
                     n294ingBod = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                     A292stockBod = O292stockBod;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                     A350stockUltNro = O350stockUltNro;
                     n350stockUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
                     A295egrBod = O295egrBod;
                     n295egrBod = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                     A349totalStock = O349totalStock;
                     n349totalStock = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
                     A292stockBod = O292stockBod;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                     GX_FocusControl = dynEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1184( ) ;
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
         if ( ( A290stockAnio != Z290stockAnio ) || ( A291stockMes != Z291stockMes ) || ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A42BodCod != Z42BodCod ) || ( A286PrdCod != Z286PrdCod ) )
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
            A286PrdCod = Z286PrdCod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "STOCKANIO");
            AnyError = 1;
            GX_FocusControl = edtstockAnio_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A294ingBod = O294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            A292stockBod = O292stockBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
            A350stockUltNro = O350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            A295egrBod = O295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            A349totalStock = O349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            A292stockBod = O292stockBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1184( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001110 */
            pr_default.execute(8, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdxBodega"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z307prdStockDsc, T001110_A307prdStockDsc[0]) != 0 ) || ( Z293invFisico != T001110_A293invFisico[0] ) || ( Z350stockUltNro != T001110_A350stockUltNro[0] ) )
            {
               if ( StringUtil.StrCmp(Z307prdStockDsc, T001110_A307prdStockDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"prdStockDsc");
                  GXUtil.WriteLogRaw("Old: ",Z307prdStockDsc);
                  GXUtil.WriteLogRaw("Current: ",T001110_A307prdStockDsc[0]);
               }
               if ( Z293invFisico != T001110_A293invFisico[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"invFisico");
                  GXUtil.WriteLogRaw("Old: ",Z293invFisico);
                  GXUtil.WriteLogRaw("Current: ",T001110_A293invFisico[0]);
               }
               if ( Z350stockUltNro != T001110_A350stockUltNro[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"stockUltNro");
                  GXUtil.WriteLogRaw("Old: ",Z350stockUltNro);
                  GXUtil.WriteLogRaw("Current: ",T001110_A350stockUltNro[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ProdxBodega"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1184( )
      {
         BeforeValidate1184( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1184( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1184( 0) ;
            CheckOptimisticConcurrency1184( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1184( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1184( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001135 */
                     pr_default.execute(24, new Object[] {A290stockAnio, A291stockMes, n307prdStockDsc, A307prdStockDsc, n293invFisico, A293invFisico, n350stockUltNro, A350stockUltNro, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
                     pr_default.close(24);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdxBodega") ;
                     if ( (pr_default.getStatus(24) == 1) )
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
                           ProcessLevel1184( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption110( ) ;
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
               Load1184( ) ;
            }
            EndLevel1184( ) ;
         }
         CloseExtendedTableCursors1184( ) ;
      }

      protected void Update1184( )
      {
         BeforeValidate1184( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1184( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1184( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1184( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1184( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001136 */
                     pr_default.execute(25, new Object[] {n307prdStockDsc, A307prdStockDsc, n293invFisico, A293invFisico, n350stockUltNro, A350stockUltNro, A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
                     pr_default.close(25);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdxBodega") ;
                     if ( (pr_default.getStatus(25) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdxBodega"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1184( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel1184( ) ;
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
            EndLevel1184( ) ;
         }
         CloseExtendedTableCursors1184( ) ;
      }

      protected void DeferredUpdate1184( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1184( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1184( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1184( ) ;
            AfterConfirm1184( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1184( ) ;
               if ( AnyError == 0 )
               {
                  A294ingBod = O294ingBod;
                  n294ingBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  A292stockBod = O292stockBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                  ScanStart1189( ) ;
                  while ( RcdFound89 != 0 )
                  {
                     getByPrimaryKey1189( ) ;
                     Delete1189( ) ;
                     ScanNext1189( ) ;
                     O294ingBod = A294ingBod;
                     n294ingBod = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                     O292stockBod = A292stockBod;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                  }
                  ScanEnd1189( ) ;
                  A350stockUltNro = O350stockUltNro;
                  n350stockUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
                  A295egrBod = O295egrBod;
                  n295egrBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                  A349totalStock = O349totalStock;
                  n349totalStock = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
                  A292stockBod = O292stockBod;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                  ScanStart1185( ) ;
                  while ( RcdFound85 != 0 )
                  {
                     getByPrimaryKey1185( ) ;
                     Delete1185( ) ;
                     ScanNext1185( ) ;
                     O350stockUltNro = A350stockUltNro;
                     n350stockUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
                     O295egrBod = A295egrBod;
                     n295egrBod = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                     O349totalStock = A349totalStock;
                     n349totalStock = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
                     O292stockBod = A292stockBod;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
                  }
                  ScanEnd1185( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001137 */
                     pr_default.execute(26, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
                     pr_default.close(26);
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
         sMode84 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1184( ) ;
         Gx_mode = sMode84;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1184( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV23Pgmname = "ProdStockBodega";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23Pgmname", AV23Pgmname);
            /* Using cursor T001138 */
            pr_default.execute(27, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = T001138_A217BodDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
            n217BodDsc = T001138_n217BodDsc[0];
            pr_default.close(27);
            /* Using cursor T001139 */
            pr_default.execute(28, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            A309prdNombre = T001139_A309prdNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
            n309prdNombre = T001139_n309prdNombre[0];
            A288PrdPres = T001139_A288PrdPres[0];
            n288PrdPres = T001139_n288PrdPres[0];
            pr_default.close(28);
            /* Using cursor T001141 */
            pr_default.execute(29, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
            if ( (pr_default.getStatus(29) != 101) )
            {
               A349totalStock = T001141_A349totalStock[0];
               n349totalStock = T001141_n349totalStock[0];
            }
            else
            {
               A349totalStock = 0;
               n349totalStock = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            }
            pr_default.close(29);
            /* Using cursor T001143 */
            pr_default.execute(30, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
            if ( (pr_default.getStatus(30) != 101) )
            {
               A294ingBod = T001143_A294ingBod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               n294ingBod = T001143_n294ingBod[0];
            }
            else
            {
               A294ingBod = 0;
               n294ingBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            }
            pr_default.close(30);
            /* Using cursor T001145 */
            pr_default.execute(31, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
            if ( (pr_default.getStatus(31) != 101) )
            {
               A295egrBod = T001145_A295egrBod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               n295egrBod = T001145_n295egrBod[0];
            }
            else
            {
               A295egrBod = 0;
               n295egrBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            pr_default.close(31);
            A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         }
      }

      protected void ProcessNestedLevel1189( )
      {
         s294ingBod = O294ingBod;
         n294ingBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         s292stockBod = O292stockBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         nGXsfl_109_idx = 0;
         while ( nGXsfl_109_idx < nRC_GXsfl_109 )
         {
            ReadRow1189( ) ;
            if ( ( nRcdExists_89 != 0 ) || ( nIsMod_89 != 0 ) )
            {
               standaloneNotModal1189( ) ;
               GetKey1189( ) ;
               if ( ( nRcdExists_89 == 0 ) && ( nRcdDeleted_89 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert1189( ) ;
               }
               else
               {
                  if ( RcdFound89 != 0 )
                  {
                     if ( ( nRcdDeleted_89 != 0 ) && ( nRcdExists_89 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete1189( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_89 != 0 ) && ( nRcdExists_89 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update1189( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_89 == 0 )
                     {
                        GXCCtl = "STOCKDETINGID_" + sGXsfl_109_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtstockDetIngID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O294ingBod = A294ingBod;
               n294ingBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               O292stockBod = A292stockBod;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
            }
            ChangePostValue( edtstockDetIngID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A389stockDetIngID), 4, 0, ",", ""))) ;
            ChangePostValue( edtingTipoInv_Internalname, StringUtil.RTrim( A383ingTipoInv)) ;
            ChangePostValue( edtingTipoInvMov_Internalname, A384ingTipoInvMov) ;
            ChangePostValue( edtingTipoSigno_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A385ingTipoSigno), 2, 0, ",", ""))) ;
            ChangePostValue( edtPrvRuc_Internalname, StringUtil.RTrim( A37PrvRuc)) ;
            ChangePostValue( edtPrvDsc_Internalname, A184PrvDsc) ;
            ChangePostValue( edtingCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A386ingCantidad, 9, 2, ",", ""))) ;
            ChangePostValue( edtingBodNroDoc_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A390ingBodNroDoc), 4, 0, ",", ""))) ;
            ChangePostValue( edtingBodTipoDoc_Internalname, StringUtil.RTrim( A391ingBodTipoDoc)) ;
            ChangePostValue( edtfchMovIng_Internalname, context.localUtil.Format(A387fchMovIng, "99/99/9999")) ;
            ChangePostValue( edthraMovIng_Internalname, context.localUtil.TToC( A388hraMovIng, 10, 8, 0, 3, "/", ":", " ")) ;
            ChangePostValue( "ZT_"+"Z389stockDetIngID_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z389stockDetIngID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z386ingCantidad_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( Z386ingCantidad, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z387fchMovIng_"+sGXsfl_109_idx, context.localUtil.DToC( Z387fchMovIng, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z388hraMovIng_"+sGXsfl_109_idx, context.localUtil.TToC( Z388hraMovIng, 10, 8, 0, 0, "/", ":", " ")) ;
            ChangePostValue( "ZT_"+"Z390ingBodNroDoc_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z390ingBodNroDoc), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z391ingBodTipoDoc_"+sGXsfl_109_idx, StringUtil.RTrim( Z391ingBodTipoDoc)) ;
            ChangePostValue( "ZT_"+"Z37PrvRuc_"+sGXsfl_109_idx, StringUtil.RTrim( Z37PrvRuc)) ;
            ChangePostValue( "ZT_"+"Z383ingTipoInv_"+sGXsfl_109_idx, StringUtil.RTrim( Z383ingTipoInv)) ;
            ChangePostValue( "T300ingTipo_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( O300ingTipo, 9, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_89_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_89), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_89_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_89), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_89_"+sGXsfl_109_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_89), 4, 0, ",", ""))) ;
            if ( nIsMod_89 != 0 )
            {
               ChangePostValue( "STOCKDETINGID_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetIngID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGTIPOINV_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoInv_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGTIPOINVMOV_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoInvMov_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGTIPOSIGNO_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoSigno_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRVRUC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvRuc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRVDSC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGCANTIDAD_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingCantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGBODNRODOC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingBodNroDoc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGBODTIPODOC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingBodTipoDoc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FCHMOVING_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtfchMovIng_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "HRAMOVING_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edthraMovIng_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1189( ) ;
         if ( AnyError != 0 )
         {
            O294ingBod = s294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            O292stockBod = s292stockBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         }
         nRcdExists_89 = 0;
         nIsMod_89 = 0;
         nRcdDeleted_89 = 0;
      }

      protected void ProcessNestedLevel1185( )
      {
         s350stockUltNro = O350stockUltNro;
         n350stockUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
         s295egrBod = O295egrBod;
         n295egrBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         s349totalStock = O349totalStock;
         n349totalStock = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
         s292stockBod = O292stockBod;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         nGXsfl_128_idx = 0;
         while ( nGXsfl_128_idx < nRC_GXsfl_128 )
         {
            ReadRow1185( ) ;
            if ( ( nRcdExists_85 != 0 ) || ( nIsMod_85 != 0 ) )
            {
               standaloneNotModal1185( ) ;
               GetKey1185( ) ;
               if ( ( nRcdExists_85 == 0 ) && ( nRcdDeleted_85 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert1185( ) ;
               }
               else
               {
                  if ( RcdFound85 != 0 )
                  {
                     if ( ( nRcdDeleted_85 != 0 ) && ( nRcdExists_85 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete1185( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_85 != 0 ) && ( nRcdExists_85 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update1185( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_85 == 0 )
                     {
                        GXCCtl = "STOCKDETID_" + sGXsfl_128_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtstockDetID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O350stockUltNro = A350stockUltNro;
               n350stockUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
               O295egrBod = A295egrBod;
               n295egrBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               O349totalStock = A349totalStock;
               n349totalStock = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
               O292stockBod = A292stockBod;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
            }
            ChangePostValue( edtstockDetID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A348stockDetID), 4, 0, ",", ""))) ;
            ChangePostValue( edtTipoInv_Internalname, StringUtil.RTrim( A43TipoInv)) ;
            ChangePostValue( edtTipoInvMov_Internalname, A219TipoInvMov) ;
            ChangePostValue( edtTipoInvSigno_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ",", ""))) ;
            ChangePostValue( edtcantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A296cantidad, 10, 2, ",", ""))) ;
            ChangePostValue( edtClienteID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", ""))) ;
            ChangePostValue( edtClienteRUC_Internalname, StringUtil.RTrim( A56ClienteRUC)) ;
            ChangePostValue( edtClienteDsc_Internalname, StringUtil.RTrim( A57ClienteDsc)) ;
            ChangePostValue( edtstock_Internalname, StringUtil.LTrim( StringUtil.NToC( A297stock, 9, 2, ",", ""))) ;
            ChangePostValue( edtcosto_Internalname, StringUtil.LTrim( StringUtil.NToC( A298costo, 13, 2, ",", ""))) ;
            ChangePostValue( edtcostUni_Internalname, StringUtil.LTrim( StringUtil.NToC( A299costUni, 13, 2, ",", ""))) ;
            ChangePostValue( edtstockDetNroDoc_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A351stockDetNroDoc), 4, 0, ",", ""))) ;
            ChangePostValue( edtstockdetTipo_Internalname, StringUtil.RTrim( A352stockdetTipo)) ;
            ChangePostValue( edtfchMovStock_Internalname, context.localUtil.Format(A374fchMovStock, "99/99/9999")) ;
            ChangePostValue( edthraMovStock_Internalname, context.localUtil.TToC( A375hraMovStock, 10, 8, 0, 3, "/", ":", " ")) ;
            ChangePostValue( edtingTipo_Internalname, StringUtil.LTrim( StringUtil.NToC( A300ingTipo, 10, 2, ",", ""))) ;
            ChangePostValue( edtegrTipo_Internalname, StringUtil.LTrim( StringUtil.NToC( A301egrTipo, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z348stockDetID_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z348stockDetID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z296cantidad_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( Z296cantidad, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z297stock_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( Z297stock, 9, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z351stockDetNroDoc_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z351stockDetNroDoc), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z352stockdetTipo_"+sGXsfl_128_idx, StringUtil.RTrim( Z352stockdetTipo)) ;
            ChangePostValue( "ZT_"+"Z298costo_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( Z298costo, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z374fchMovStock_"+sGXsfl_128_idx, context.localUtil.DToC( Z374fchMovStock, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z375hraMovStock_"+sGXsfl_128_idx, context.localUtil.TToC( Z375hraMovStock, 10, 8, 0, 0, "/", ":", " ")) ;
            ChangePostValue( "ZT_"+"Z5ClienteID_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5ClienteID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z43TipoInv_"+sGXsfl_128_idx, StringUtil.RTrim( Z43TipoInv)) ;
            ChangePostValue( "T301egrTipo_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( O301egrTipo, 9, 2, ",", ""))) ;
            ChangePostValue( "T297stock_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( O297stock, 9, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_85_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_85), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_85_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_85), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_85_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_85), 4, 0, ",", ""))) ;
            if ( nIsMod_85 != 0 )
            {
               ChangePostValue( "STOCKDETID_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOINV_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInv_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOINVMOV_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvMov_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPOINVSIGNO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvSigno_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CANTIDAD_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CLIENTEID_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CLIENTERUC_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteRUC_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CLIENTEDSC_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "STOCK_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstock_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COSTO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcosto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COSTUNI_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcostUni_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "STOCKDETNRODOC_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetNroDoc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "STOCKDETTIPO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockdetTipo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FCHMOVSTOCK_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtfchMovStock_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "HRAMOVSTOCK_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edthraMovStock_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INGTIPO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EGRTIPO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtegrTipo_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1185( ) ;
         if ( AnyError != 0 )
         {
            O350stockUltNro = s350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            O295egrBod = s295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            O349totalStock = s349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            O292stockBod = s292stockBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         }
         nRcdExists_85 = 0;
         nIsMod_85 = 0;
         nRcdDeleted_85 = 0;
      }

      protected void ProcessLevel1184( )
      {
         /* Save parent mode. */
         sMode84 = Gx_mode;
         ProcessNestedLevel1189( ) ;
         ProcessNestedLevel1185( ) ;
         if ( AnyError != 0 )
         {
            O294ingBod = s294ingBod;
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            O292stockBod = s292stockBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
            O350stockUltNro = s350stockUltNro;
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
            O295egrBod = s295egrBod;
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            O349totalStock = s349totalStock;
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            O292stockBod = s292stockBod;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode84;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T001146 */
         pr_default.execute(32, new Object[] {n350stockUltNro, A350stockUltNro, A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         pr_default.close(32);
         dsDefault.SmartCacheProvider.SetUpdated("ProdxBodega") ;
      }

      protected void EndLevel1184( )
      {
         pr_default.close(8);
         if ( AnyError == 0 )
         {
            BeforeComplete1184( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(5);
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(27);
            pr_default.close(28);
            pr_default.close(29);
            pr_default.close(30);
            pr_default.close(31);
            pr_default.close(6);
            pr_default.close(7);
            pr_default.close(2);
            pr_default.close(3);
            context.CommitDataStores("prodstockbodega",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues110( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(5);
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(27);
            pr_default.close(28);
            pr_default.close(29);
            pr_default.close(30);
            pr_default.close(31);
            pr_default.close(6);
            pr_default.close(7);
            pr_default.close(2);
            pr_default.close(3);
            context.RollbackDataStores("prodstockbodega",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1184( )
      {
         /* Scan By routine */
         /* Using cursor T001147 */
         pr_default.execute(33);
         RcdFound84 = 0;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound84 = 1;
            A290stockAnio = T001147_A290stockAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
            A291stockMes = T001147_A291stockMes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
            A1EmpID = T001147_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T001147_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = T001147_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A286PrdCod = T001147_A286PrdCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1184( )
      {
         /* Scan next routine */
         pr_default.readNext(33);
         RcdFound84 = 0;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound84 = 1;
            A290stockAnio = T001147_A290stockAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290stockAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A290stockAnio), 4, 0)));
            A291stockMes = T001147_A291stockMes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291stockMes", StringUtil.LTrim( StringUtil.Str( (decimal)(A291stockMes), 2, 0)));
            A1EmpID = T001147_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A2AgeID = T001147_A2AgeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2AgeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A2AgeID), 4, 0)));
            A42BodCod = T001147_A42BodCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BodCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A42BodCod), 4, 0)));
            A286PrdCod = T001147_A286PrdCod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         }
      }

      protected void ScanEnd1184( )
      {
         pr_default.close(33);
      }

      protected void AfterConfirm1184( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1184( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1184( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1184( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1184( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1184( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1184( )
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
         edtPrdCod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrdCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrdCod_Enabled), 5, 0)), true);
         edtprdNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdNombre_Enabled), 5, 0)), true);
         edtprdStockDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprdStockDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprdStockDsc_Enabled), 5, 0)), true);
         edtinvFisico_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtinvFisico_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtinvFisico_Enabled), 5, 0)), true);
         edtingBod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBod_Enabled), 5, 0)), true);
         edtegrBod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtegrBod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtegrBod_Enabled), 5, 0)), true);
         edtstockBod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockBod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockBod_Enabled), 5, 0)), true);
      }

      protected void ZM1189( short GX_JID )
      {
         if ( ( GX_JID == 55 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z386ingCantidad = T00117_A386ingCantidad[0];
               Z387fchMovIng = T00117_A387fchMovIng[0];
               Z388hraMovIng = T00117_A388hraMovIng[0];
               Z390ingBodNroDoc = T00117_A390ingBodNroDoc[0];
               Z391ingBodTipoDoc = T00117_A391ingBodTipoDoc[0];
               Z37PrvRuc = T00117_A37PrvRuc[0];
               Z383ingTipoInv = T00117_A383ingTipoInv[0];
            }
            else
            {
               Z386ingCantidad = A386ingCantidad;
               Z387fchMovIng = A387fchMovIng;
               Z388hraMovIng = A388hraMovIng;
               Z390ingBodNroDoc = A390ingBodNroDoc;
               Z391ingBodTipoDoc = A391ingBodTipoDoc;
               Z37PrvRuc = A37PrvRuc;
               Z383ingTipoInv = A383ingTipoInv;
            }
         }
         if ( GX_JID == -55 )
         {
            Z290stockAnio = A290stockAnio;
            Z291stockMes = A291stockMes;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z286PrdCod = A286PrdCod;
            Z389stockDetIngID = A389stockDetIngID;
            Z386ingCantidad = A386ingCantidad;
            Z387fchMovIng = A387fchMovIng;
            Z388hraMovIng = A388hraMovIng;
            Z390ingBodNroDoc = A390ingBodNroDoc;
            Z391ingBodTipoDoc = A391ingBodTipoDoc;
            Z37PrvRuc = A37PrvRuc;
            Z383ingTipoInv = A383ingTipoInv;
            Z1EmpID = A1EmpID;
            Z384ingTipoInvMov = A384ingTipoInvMov;
            Z385ingTipoSigno = A385ingTipoSigno;
            Z184PrvDsc = A184PrvDsc;
         }
      }

      protected void standaloneNotModal1189( )
      {
         edtingTipoSigno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipoSigno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipoSigno_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingBodNroDoc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodNroDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodNroDoc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingBodTipoDoc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTipoDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTipoDoc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtfchMovIng_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfchMovIng_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfchMovIng_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edthraMovIng_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edthraMovIng_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edthraMovIng_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingTipo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipo_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
      }

      protected void standaloneModal1189( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtstockDetIngID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetIngID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetIngID_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         }
         else
         {
            edtstockDetIngID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetIngID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetIngID_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         }
      }

      protected void Load1189( )
      {
         /* Using cursor T001148 */
         pr_default.execute(34, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A389stockDetIngID});
         if ( (pr_default.getStatus(34) != 101) )
         {
            RcdFound89 = 1;
            A384ingTipoInvMov = T001148_A384ingTipoInvMov[0];
            n384ingTipoInvMov = T001148_n384ingTipoInvMov[0];
            A385ingTipoSigno = T001148_A385ingTipoSigno[0];
            n385ingTipoSigno = T001148_n385ingTipoSigno[0];
            A386ingCantidad = T001148_A386ingCantidad[0];
            n386ingCantidad = T001148_n386ingCantidad[0];
            A184PrvDsc = T001148_A184PrvDsc[0];
            n184PrvDsc = T001148_n184PrvDsc[0];
            A387fchMovIng = T001148_A387fchMovIng[0];
            n387fchMovIng = T001148_n387fchMovIng[0];
            A388hraMovIng = T001148_A388hraMovIng[0];
            n388hraMovIng = T001148_n388hraMovIng[0];
            A390ingBodNroDoc = T001148_A390ingBodNroDoc[0];
            n390ingBodNroDoc = T001148_n390ingBodNroDoc[0];
            A391ingBodTipoDoc = T001148_A391ingBodTipoDoc[0];
            n391ingBodTipoDoc = T001148_n391ingBodTipoDoc[0];
            A37PrvRuc = T001148_A37PrvRuc[0];
            A383ingTipoInv = T001148_A383ingTipoInv[0];
            ZM1189( -55) ;
         }
         pr_default.close(34);
         OnLoadActions1189( ) ;
      }

      protected void OnLoadActions1189( )
      {
         if ( A385ingTipoSigno == 1 )
         {
            A300ingTipo = A386ingCantidad;
         }
         else
         {
            A300ingTipo = 0;
         }
         O300ingTipo = A300ingTipo;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A294ingBod = (decimal)(O294ingBod+A300ingTipo);
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A294ingBod = (decimal)(O294ingBod+A300ingTipo-O300ingTipo);
               n294ingBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A294ingBod = (decimal)(O294ingBod-O300ingTipo);
                  n294ingBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               }
            }
         }
         A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
      }

      protected void CheckExtendedTable1189( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal1189( ) ;
         /* Using cursor T00119 */
         pr_default.execute(7, new Object[] {A383ingTipoInv});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GXCCtl = "INGTIPOINV_" + sGXsfl_109_idx;
            GX_msglist.addItem("No existe 'Tipo Movimiento Inv'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtingTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A384ingTipoInvMov = T00119_A384ingTipoInvMov[0];
         n384ingTipoInvMov = T00119_n384ingTipoInvMov[0];
         A385ingTipoSigno = T00119_A385ingTipoSigno[0];
         n385ingTipoSigno = T00119_n385ingTipoSigno[0];
         pr_default.close(7);
         if ( A385ingTipoSigno == 1 )
         {
            A300ingTipo = A386ingCantidad;
         }
         else
         {
            A300ingTipo = 0;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A294ingBod = (decimal)(O294ingBod+A300ingTipo);
            n294ingBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A294ingBod = (decimal)(O294ingBod+A300ingTipo-O300ingTipo);
               n294ingBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A294ingBod = (decimal)(O294ingBod-O300ingTipo);
                  n294ingBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               }
            }
         }
         A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         /* Using cursor T00118 */
         pr_default.execute(6, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GXCCtl = "PRVRUC_" + sGXsfl_109_idx;
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A184PrvDsc = T00118_A184PrvDsc[0];
         n184PrvDsc = T00118_n184PrvDsc[0];
         pr_default.close(6);
      }

      protected void CloseExtendedTableCursors1189( )
      {
         pr_default.close(7);
         pr_default.close(6);
      }

      protected void enableDisable1189( )
      {
      }

      protected void gxLoad_57( String A383ingTipoInv )
      {
         /* Using cursor T001149 */
         pr_default.execute(35, new Object[] {A383ingTipoInv});
         if ( (pr_default.getStatus(35) == 101) )
         {
            GXCCtl = "INGTIPOINV_" + sGXsfl_109_idx;
            GX_msglist.addItem("No existe 'Tipo Movimiento Inv'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtingTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A384ingTipoInvMov = T001149_A384ingTipoInvMov[0];
         n384ingTipoInvMov = T001149_n384ingTipoInvMov[0];
         A385ingTipoSigno = T001149_A385ingTipoSigno[0];
         n385ingTipoSigno = T001149_n385ingTipoSigno[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A384ingTipoInvMov)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A385ingTipoSigno), 2, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(35) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(35);
      }

      protected void gxLoad_56( String A37PrvRuc )
      {
         /* Using cursor T001150 */
         pr_default.execute(36, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(36) == 101) )
         {
            GXCCtl = "PRVRUC_" + sGXsfl_109_idx;
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A184PrvDsc = T001150_A184PrvDsc[0];
         n184PrvDsc = T001150_n184PrvDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A184PrvDsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(36) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(36);
      }

      protected void GetKey1189( )
      {
         /* Using cursor T001151 */
         pr_default.execute(37, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A389stockDetIngID});
         if ( (pr_default.getStatus(37) != 101) )
         {
            RcdFound89 = 1;
         }
         else
         {
            RcdFound89 = 0;
         }
         pr_default.close(37);
      }

      protected void getByPrimaryKey1189( )
      {
         /* Using cursor T00117 */
         pr_default.execute(5, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A389stockDetIngID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            ZM1189( 55) ;
            RcdFound89 = 1;
            InitializeNonKey1189( ) ;
            A389stockDetIngID = T00117_A389stockDetIngID[0];
            A386ingCantidad = T00117_A386ingCantidad[0];
            n386ingCantidad = T00117_n386ingCantidad[0];
            A387fchMovIng = T00117_A387fchMovIng[0];
            n387fchMovIng = T00117_n387fchMovIng[0];
            A388hraMovIng = T00117_A388hraMovIng[0];
            n388hraMovIng = T00117_n388hraMovIng[0];
            A390ingBodNroDoc = T00117_A390ingBodNroDoc[0];
            n390ingBodNroDoc = T00117_n390ingBodNroDoc[0];
            A391ingBodTipoDoc = T00117_A391ingBodTipoDoc[0];
            n391ingBodTipoDoc = T00117_n391ingBodTipoDoc[0];
            A37PrvRuc = T00117_A37PrvRuc[0];
            A383ingTipoInv = T00117_A383ingTipoInv[0];
            Z290stockAnio = A290stockAnio;
            Z291stockMes = A291stockMes;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z286PrdCod = A286PrdCod;
            Z389stockDetIngID = A389stockDetIngID;
            sMode89 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1189( ) ;
            Gx_mode = sMode89;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound89 = 0;
            InitializeNonKey1189( ) ;
            sMode89 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal1189( ) ;
            Gx_mode = sMode89;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes1189( ) ;
         }
         pr_default.close(5);
      }

      protected void CheckOptimisticConcurrency1189( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00116 */
            pr_default.execute(4, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A389stockDetIngID});
            if ( (pr_default.getStatus(4) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdStockBodegastockDetEgr"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(4) == 101) || ( Z386ingCantidad != T00116_A386ingCantidad[0] ) || ( Z387fchMovIng != T00116_A387fchMovIng[0] ) || ( Z388hraMovIng != T00116_A388hraMovIng[0] ) || ( Z390ingBodNroDoc != T00116_A390ingBodNroDoc[0] ) || ( StringUtil.StrCmp(Z391ingBodTipoDoc, T00116_A391ingBodTipoDoc[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z37PrvRuc, T00116_A37PrvRuc[0]) != 0 ) || ( StringUtil.StrCmp(Z383ingTipoInv, T00116_A383ingTipoInv[0]) != 0 ) )
            {
               if ( Z386ingCantidad != T00116_A386ingCantidad[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"ingCantidad");
                  GXUtil.WriteLogRaw("Old: ",Z386ingCantidad);
                  GXUtil.WriteLogRaw("Current: ",T00116_A386ingCantidad[0]);
               }
               if ( Z387fchMovIng != T00116_A387fchMovIng[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"fchMovIng");
                  GXUtil.WriteLogRaw("Old: ",Z387fchMovIng);
                  GXUtil.WriteLogRaw("Current: ",T00116_A387fchMovIng[0]);
               }
               if ( Z388hraMovIng != T00116_A388hraMovIng[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"hraMovIng");
                  GXUtil.WriteLogRaw("Old: ",Z388hraMovIng);
                  GXUtil.WriteLogRaw("Current: ",T00116_A388hraMovIng[0]);
               }
               if ( Z390ingBodNroDoc != T00116_A390ingBodNroDoc[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"ingBodNroDoc");
                  GXUtil.WriteLogRaw("Old: ",Z390ingBodNroDoc);
                  GXUtil.WriteLogRaw("Current: ",T00116_A390ingBodNroDoc[0]);
               }
               if ( StringUtil.StrCmp(Z391ingBodTipoDoc, T00116_A391ingBodTipoDoc[0]) != 0 )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"ingBodTipoDoc");
                  GXUtil.WriteLogRaw("Old: ",Z391ingBodTipoDoc);
                  GXUtil.WriteLogRaw("Current: ",T00116_A391ingBodTipoDoc[0]);
               }
               if ( StringUtil.StrCmp(Z37PrvRuc, T00116_A37PrvRuc[0]) != 0 )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"PrvRuc");
                  GXUtil.WriteLogRaw("Old: ",Z37PrvRuc);
                  GXUtil.WriteLogRaw("Current: ",T00116_A37PrvRuc[0]);
               }
               if ( StringUtil.StrCmp(Z383ingTipoInv, T00116_A383ingTipoInv[0]) != 0 )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"ingTipoInv");
                  GXUtil.WriteLogRaw("Old: ",Z383ingTipoInv);
                  GXUtil.WriteLogRaw("Current: ",T00116_A383ingTipoInv[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ProdStockBodegastockDetEgr"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1189( )
      {
         BeforeValidate1189( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1189( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1189( 0) ;
            CheckOptimisticConcurrency1189( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1189( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1189( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001152 */
                     pr_default.execute(38, new Object[] {A290stockAnio, A291stockMes, A2AgeID, A42BodCod, A286PrdCod, A389stockDetIngID, n386ingCantidad, A386ingCantidad, n387fchMovIng, A387fchMovIng, n388hraMovIng, A388hraMovIng, n390ingBodNroDoc, A390ingBodNroDoc, n391ingBodTipoDoc, A391ingBodTipoDoc, A37PrvRuc, A383ingTipoInv, A1EmpID});
                     pr_default.close(38);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdStockBodegastockDetEgr") ;
                     if ( (pr_default.getStatus(38) == 1) )
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
               Load1189( ) ;
            }
            EndLevel1189( ) ;
         }
         CloseExtendedTableCursors1189( ) ;
      }

      protected void Update1189( )
      {
         BeforeValidate1189( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1189( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1189( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1189( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1189( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001153 */
                     pr_default.execute(39, new Object[] {n386ingCantidad, A386ingCantidad, n387fchMovIng, A387fchMovIng, n388hraMovIng, A388hraMovIng, n390ingBodNroDoc, A390ingBodNroDoc, n391ingBodTipoDoc, A391ingBodTipoDoc, A37PrvRuc, A383ingTipoInv, A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A389stockDetIngID});
                     pr_default.close(39);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdStockBodegastockDetEgr") ;
                     if ( (pr_default.getStatus(39) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdStockBodegastockDetEgr"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1189( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1189( ) ;
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
            EndLevel1189( ) ;
         }
         CloseExtendedTableCursors1189( ) ;
      }

      protected void DeferredUpdate1189( )
      {
      }

      protected void Delete1189( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate1189( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1189( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1189( ) ;
            AfterConfirm1189( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1189( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001154 */
                  pr_default.execute(40, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A389stockDetIngID});
                  pr_default.close(40);
                  dsDefault.SmartCacheProvider.SetUpdated("ProdStockBodegastockDetEgr") ;
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
         sMode89 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1189( ) ;
         Gx_mode = sMode89;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1189( )
      {
         standaloneModal1189( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T001155 */
            pr_default.execute(41, new Object[] {A383ingTipoInv});
            A384ingTipoInvMov = T001155_A384ingTipoInvMov[0];
            n384ingTipoInvMov = T001155_n384ingTipoInvMov[0];
            A385ingTipoSigno = T001155_A385ingTipoSigno[0];
            n385ingTipoSigno = T001155_n385ingTipoSigno[0];
            pr_default.close(41);
            if ( A385ingTipoSigno == 1 )
            {
               A300ingTipo = A386ingCantidad;
            }
            else
            {
               A300ingTipo = 0;
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A294ingBod = (decimal)(O294ingBod+A300ingTipo);
               n294ingBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A294ingBod = (decimal)(O294ingBod+A300ingTipo-O300ingTipo);
                  n294ingBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A294ingBod = (decimal)(O294ingBod-O300ingTipo);
                     n294ingBod = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
                  }
               }
            }
            A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
            /* Using cursor T001156 */
            pr_default.execute(42, new Object[] {A37PrvRuc});
            A184PrvDsc = T001156_A184PrvDsc[0];
            n184PrvDsc = T001156_n184PrvDsc[0];
            pr_default.close(42);
         }
      }

      protected void EndLevel1189( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(4);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1189( )
      {
         /* Scan By routine */
         /* Using cursor T001157 */
         pr_default.execute(43, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         RcdFound89 = 0;
         if ( (pr_default.getStatus(43) != 101) )
         {
            RcdFound89 = 1;
            A389stockDetIngID = T001157_A389stockDetIngID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1189( )
      {
         /* Scan next routine */
         pr_default.readNext(43);
         RcdFound89 = 0;
         if ( (pr_default.getStatus(43) != 101) )
         {
            RcdFound89 = 1;
            A389stockDetIngID = T001157_A389stockDetIngID[0];
         }
      }

      protected void ScanEnd1189( )
      {
         pr_default.close(43);
      }

      protected void AfterConfirm1189( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1189( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1189( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1189( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1189( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1189( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1189( )
      {
         edtstockDetIngID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetIngID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetIngID_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingTipoInv_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipoInv_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingTipoInvMov_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipoInvMov_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipoInvMov_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingTipoSigno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipoSigno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipoSigno_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtPrvRuc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvRuc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvRuc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtPrvDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPrvDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPrvDsc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingCantidad_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingCantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingCantidad_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingBodNroDoc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodNroDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodNroDoc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingBodTipoDoc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTipoDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTipoDoc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtfchMovIng_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfchMovIng_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfchMovIng_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edthraMovIng_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edthraMovIng_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edthraMovIng_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingTipo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipo_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
      }

      protected void send_integrity_lvl_hashes1189( )
      {
      }

      protected void ZM1185( short GX_JID )
      {
         if ( ( GX_JID == 58 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z296cantidad = T00113_A296cantidad[0];
               Z297stock = T00113_A297stock[0];
               Z351stockDetNroDoc = T00113_A351stockDetNroDoc[0];
               Z352stockdetTipo = T00113_A352stockdetTipo[0];
               Z298costo = T00113_A298costo[0];
               Z374fchMovStock = T00113_A374fchMovStock[0];
               Z375hraMovStock = T00113_A375hraMovStock[0];
               Z5ClienteID = T00113_A5ClienteID[0];
               Z43TipoInv = T00113_A43TipoInv[0];
            }
            else
            {
               Z296cantidad = A296cantidad;
               Z297stock = A297stock;
               Z351stockDetNroDoc = A351stockDetNroDoc;
               Z352stockdetTipo = A352stockdetTipo;
               Z298costo = A298costo;
               Z374fchMovStock = A374fchMovStock;
               Z375hraMovStock = A375hraMovStock;
               Z5ClienteID = A5ClienteID;
               Z43TipoInv = A43TipoInv;
            }
         }
         if ( GX_JID == -58 )
         {
            Z290stockAnio = A290stockAnio;
            Z291stockMes = A291stockMes;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z286PrdCod = A286PrdCod;
            Z348stockDetID = A348stockDetID;
            Z296cantidad = A296cantidad;
            Z297stock = A297stock;
            Z351stockDetNroDoc = A351stockDetNroDoc;
            Z352stockdetTipo = A352stockdetTipo;
            Z298costo = A298costo;
            Z374fchMovStock = A374fchMovStock;
            Z375hraMovStock = A375hraMovStock;
            Z1EmpID = A1EmpID;
            Z5ClienteID = A5ClienteID;
            Z43TipoInv = A43TipoInv;
            Z56ClienteRUC = A56ClienteRUC;
            Z57ClienteDsc = A57ClienteDsc;
            Z219TipoInvMov = A219TipoInvMov;
            Z223TipoInvSigno = A223TipoInvSigno;
         }
      }

      protected void standaloneNotModal1185( )
      {
         edtTipoInvSigno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvSigno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInvSigno_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtClienteID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtClienteRUC_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteRUC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteRUC_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtClienteDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteDsc_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtstock_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtcosto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcosto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcosto_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtcostUni_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcostUni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcostUni_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtfchMovStock_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfchMovStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfchMovStock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edthraMovStock_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edthraMovStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edthraMovStock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtegrTipo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtegrTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtegrTipo_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
      }

      protected void standaloneModal1185( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A350stockUltNro = (short)(O350stockUltNro+1);
            n350stockUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A348stockDetID = A350stockUltNro;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A349totalStock = (decimal)(O349totalStock+A297stock);
            n349totalStock = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A349totalStock = (decimal)(O349totalStock+A297stock-O297stock);
               n349totalStock = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A349totalStock = (decimal)(O349totalStock-O297stock);
                  n349totalStock = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
               }
            }
         }
         /* Using cursor T00114 */
         pr_default.execute(2, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Clientes'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A56ClienteRUC = T00114_A56ClienteRUC[0];
         n56ClienteRUC = T00114_n56ClienteRUC[0];
         A57ClienteDsc = T00114_A57ClienteDsc[0];
         n57ClienteDsc = T00114_n57ClienteDsc[0];
         pr_default.close(2);
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtstockDetID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetID_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         }
         else
         {
            edtstockDetID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetID_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         }
      }

      protected void Load1185( )
      {
         /* Using cursor T001158 */
         pr_default.execute(44, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A348stockDetID});
         if ( (pr_default.getStatus(44) != 101) )
         {
            RcdFound85 = 1;
            A219TipoInvMov = T001158_A219TipoInvMov[0];
            n219TipoInvMov = T001158_n219TipoInvMov[0];
            A223TipoInvSigno = T001158_A223TipoInvSigno[0];
            n223TipoInvSigno = T001158_n223TipoInvSigno[0];
            A296cantidad = T001158_A296cantidad[0];
            n296cantidad = T001158_n296cantidad[0];
            A297stock = T001158_A297stock[0];
            n297stock = T001158_n297stock[0];
            A351stockDetNroDoc = T001158_A351stockDetNroDoc[0];
            n351stockDetNroDoc = T001158_n351stockDetNroDoc[0];
            A352stockdetTipo = T001158_A352stockdetTipo[0];
            n352stockdetTipo = T001158_n352stockdetTipo[0];
            A56ClienteRUC = T001158_A56ClienteRUC[0];
            n56ClienteRUC = T001158_n56ClienteRUC[0];
            A57ClienteDsc = T001158_A57ClienteDsc[0];
            n57ClienteDsc = T001158_n57ClienteDsc[0];
            A298costo = T001158_A298costo[0];
            n298costo = T001158_n298costo[0];
            A374fchMovStock = T001158_A374fchMovStock[0];
            n374fchMovStock = T001158_n374fchMovStock[0];
            A375hraMovStock = T001158_A375hraMovStock[0];
            n375hraMovStock = T001158_n375hraMovStock[0];
            A5ClienteID = T001158_A5ClienteID[0];
            A43TipoInv = T001158_A43TipoInv[0];
            ZM1185( -58) ;
         }
         pr_default.close(44);
         OnLoadActions1185( ) ;
      }

      protected void OnLoadActions1185( )
      {
         if ( A223TipoInvSigno == -1 )
         {
            A301egrTipo = A296cantidad;
         }
         else
         {
            A301egrTipo = 0;
         }
         O301egrTipo = A301egrTipo;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A295egrBod = (decimal)(O295egrBod+A301egrTipo);
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A295egrBod = (decimal)(O295egrBod+A301egrTipo-O301egrTipo);
               n295egrBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A295egrBod = (decimal)(O295egrBod-O301egrTipo);
                  n295egrBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               }
            }
         }
         A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         if ( ( A296cantidad != Convert.ToDecimal( 0 )) )
         {
            A299costUni = NumberUtil.Round( A298costo/ (decimal)(A296cantidad), 2);
         }
         else
         {
            A299costUni = 0;
         }
      }

      protected void CheckExtendedTable1185( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal1185( ) ;
         /* Using cursor T00115 */
         pr_default.execute(3, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GXCCtl = "TIPOINV_" + sGXsfl_128_idx;
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A219TipoInvMov = T00115_A219TipoInvMov[0];
         n219TipoInvMov = T00115_n219TipoInvMov[0];
         A223TipoInvSigno = T00115_A223TipoInvSigno[0];
         n223TipoInvSigno = T00115_n223TipoInvSigno[0];
         pr_default.close(3);
         if ( A223TipoInvSigno == -1 )
         {
            A301egrTipo = A296cantidad;
         }
         else
         {
            A301egrTipo = 0;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A295egrBod = (decimal)(O295egrBod+A301egrTipo);
            n295egrBod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A295egrBod = (decimal)(O295egrBod+A301egrTipo-O301egrTipo);
               n295egrBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A295egrBod = (decimal)(O295egrBod-O301egrTipo);
                  n295egrBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               }
            }
         }
         A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         if ( ( A296cantidad != Convert.ToDecimal( 0 )) )
         {
            A299costUni = NumberUtil.Round( A298costo/ (decimal)(A296cantidad), 2);
         }
         else
         {
            A299costUni = 0;
         }
      }

      protected void CloseExtendedTableCursors1185( )
      {
         pr_default.close(3);
      }

      protected void enableDisable1185( )
      {
      }

      protected void gxLoad_60( String A43TipoInv )
      {
         /* Using cursor T001159 */
         pr_default.execute(45, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(45) == 101) )
         {
            GXCCtl = "TIPOINV_" + sGXsfl_128_idx;
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtTipoInv_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A219TipoInvMov = T001159_A219TipoInvMov[0];
         n219TipoInvMov = T001159_n219TipoInvMov[0];
         A223TipoInvSigno = T001159_A223TipoInvSigno[0];
         n223TipoInvSigno = T001159_n223TipoInvSigno[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A219TipoInvMov)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(45) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(45);
      }

      protected void GetKey1185( )
      {
         /* Using cursor T001160 */
         pr_default.execute(46, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A348stockDetID});
         if ( (pr_default.getStatus(46) != 101) )
         {
            RcdFound85 = 1;
         }
         else
         {
            RcdFound85 = 0;
         }
         pr_default.close(46);
      }

      protected void getByPrimaryKey1185( )
      {
         /* Using cursor T00113 */
         pr_default.execute(1, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A348stockDetID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1185( 58) ;
            RcdFound85 = 1;
            InitializeNonKey1185( ) ;
            A348stockDetID = T00113_A348stockDetID[0];
            A296cantidad = T00113_A296cantidad[0];
            n296cantidad = T00113_n296cantidad[0];
            A297stock = T00113_A297stock[0];
            n297stock = T00113_n297stock[0];
            A351stockDetNroDoc = T00113_A351stockDetNroDoc[0];
            n351stockDetNroDoc = T00113_n351stockDetNroDoc[0];
            A352stockdetTipo = T00113_A352stockdetTipo[0];
            n352stockdetTipo = T00113_n352stockdetTipo[0];
            A298costo = T00113_A298costo[0];
            n298costo = T00113_n298costo[0];
            A374fchMovStock = T00113_A374fchMovStock[0];
            n374fchMovStock = T00113_n374fchMovStock[0];
            A375hraMovStock = T00113_A375hraMovStock[0];
            n375hraMovStock = T00113_n375hraMovStock[0];
            A5ClienteID = T00113_A5ClienteID[0];
            A43TipoInv = T00113_A43TipoInv[0];
            O297stock = A297stock;
            n297stock = false;
            Z290stockAnio = A290stockAnio;
            Z291stockMes = A291stockMes;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z286PrdCod = A286PrdCod;
            Z348stockDetID = A348stockDetID;
            sMode85 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1185( ) ;
            Gx_mode = sMode85;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound85 = 0;
            InitializeNonKey1185( ) ;
            sMode85 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal1185( ) ;
            Gx_mode = sMode85;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes1185( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency1185( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00112 */
            pr_default.execute(0, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A348stockDetID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdxBodegaTipoInv"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z296cantidad != T00112_A296cantidad[0] ) || ( Z297stock != T00112_A297stock[0] ) || ( Z351stockDetNroDoc != T00112_A351stockDetNroDoc[0] ) || ( StringUtil.StrCmp(Z352stockdetTipo, T00112_A352stockdetTipo[0]) != 0 ) || ( Z298costo != T00112_A298costo[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z374fchMovStock != T00112_A374fchMovStock[0] ) || ( Z375hraMovStock != T00112_A375hraMovStock[0] ) || ( Z5ClienteID != T00112_A5ClienteID[0] ) || ( StringUtil.StrCmp(Z43TipoInv, T00112_A43TipoInv[0]) != 0 ) )
            {
               if ( Z296cantidad != T00112_A296cantidad[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"cantidad");
                  GXUtil.WriteLogRaw("Old: ",Z296cantidad);
                  GXUtil.WriteLogRaw("Current: ",T00112_A296cantidad[0]);
               }
               if ( Z297stock != T00112_A297stock[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"stock");
                  GXUtil.WriteLogRaw("Old: ",Z297stock);
                  GXUtil.WriteLogRaw("Current: ",T00112_A297stock[0]);
               }
               if ( Z351stockDetNroDoc != T00112_A351stockDetNroDoc[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"stockDetNroDoc");
                  GXUtil.WriteLogRaw("Old: ",Z351stockDetNroDoc);
                  GXUtil.WriteLogRaw("Current: ",T00112_A351stockDetNroDoc[0]);
               }
               if ( StringUtil.StrCmp(Z352stockdetTipo, T00112_A352stockdetTipo[0]) != 0 )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"stockdetTipo");
                  GXUtil.WriteLogRaw("Old: ",Z352stockdetTipo);
                  GXUtil.WriteLogRaw("Current: ",T00112_A352stockdetTipo[0]);
               }
               if ( Z298costo != T00112_A298costo[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"costo");
                  GXUtil.WriteLogRaw("Old: ",Z298costo);
                  GXUtil.WriteLogRaw("Current: ",T00112_A298costo[0]);
               }
               if ( Z374fchMovStock != T00112_A374fchMovStock[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"fchMovStock");
                  GXUtil.WriteLogRaw("Old: ",Z374fchMovStock);
                  GXUtil.WriteLogRaw("Current: ",T00112_A374fchMovStock[0]);
               }
               if ( Z375hraMovStock != T00112_A375hraMovStock[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"hraMovStock");
                  GXUtil.WriteLogRaw("Old: ",Z375hraMovStock);
                  GXUtil.WriteLogRaw("Current: ",T00112_A375hraMovStock[0]);
               }
               if ( Z5ClienteID != T00112_A5ClienteID[0] )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"ClienteID");
                  GXUtil.WriteLogRaw("Old: ",Z5ClienteID);
                  GXUtil.WriteLogRaw("Current: ",T00112_A5ClienteID[0]);
               }
               if ( StringUtil.StrCmp(Z43TipoInv, T00112_A43TipoInv[0]) != 0 )
               {
                  GXUtil.WriteLog("prodstockbodega:[seudo value changed for attri]"+"TipoInv");
                  GXUtil.WriteLogRaw("Old: ",Z43TipoInv);
                  GXUtil.WriteLogRaw("Current: ",T00112_A43TipoInv[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ProdxBodegaTipoInv"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1185( )
      {
         BeforeValidate1185( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1185( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1185( 0) ;
            CheckOptimisticConcurrency1185( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1185( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1185( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001161 */
                     pr_default.execute(47, new Object[] {A290stockAnio, A291stockMes, A2AgeID, A42BodCod, A286PrdCod, A348stockDetID, n296cantidad, A296cantidad, n297stock, A297stock, n351stockDetNroDoc, A351stockDetNroDoc, n352stockdetTipo, A352stockdetTipo, n298costo, A298costo, n374fchMovStock, A374fchMovStock, n375hraMovStock, A375hraMovStock, A1EmpID, A5ClienteID, A43TipoInv});
                     pr_default.close(47);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdxBodegaTipoInv") ;
                     if ( (pr_default.getStatus(47) == 1) )
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
               Load1185( ) ;
            }
            EndLevel1185( ) ;
         }
         CloseExtendedTableCursors1185( ) ;
      }

      protected void Update1185( )
      {
         BeforeValidate1185( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1185( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1185( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1185( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1185( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001162 */
                     pr_default.execute(48, new Object[] {n296cantidad, A296cantidad, n297stock, A297stock, n351stockDetNroDoc, A351stockDetNroDoc, n352stockdetTipo, A352stockdetTipo, n298costo, A298costo, n374fchMovStock, A374fchMovStock, n375hraMovStock, A375hraMovStock, A5ClienteID, A43TipoInv, A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A348stockDetID});
                     pr_default.close(48);
                     dsDefault.SmartCacheProvider.SetUpdated("ProdxBodegaTipoInv") ;
                     if ( (pr_default.getStatus(48) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ProdxBodegaTipoInv"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1185( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1185( ) ;
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
            EndLevel1185( ) ;
         }
         CloseExtendedTableCursors1185( ) ;
      }

      protected void DeferredUpdate1185( )
      {
      }

      protected void Delete1185( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate1185( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1185( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1185( ) ;
            AfterConfirm1185( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1185( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001163 */
                  pr_default.execute(49, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod, A348stockDetID});
                  pr_default.close(49);
                  dsDefault.SmartCacheProvider.SetUpdated("ProdxBodegaTipoInv") ;
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
         sMode85 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1185( ) ;
         Gx_mode = sMode85;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1185( )
      {
         standaloneModal1185( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T001164 */
            pr_default.execute(50, new Object[] {A43TipoInv});
            A219TipoInvMov = T001164_A219TipoInvMov[0];
            n219TipoInvMov = T001164_n219TipoInvMov[0];
            A223TipoInvSigno = T001164_A223TipoInvSigno[0];
            n223TipoInvSigno = T001164_n223TipoInvSigno[0];
            pr_default.close(50);
            if ( A223TipoInvSigno == -1 )
            {
               A301egrTipo = A296cantidad;
            }
            else
            {
               A301egrTipo = 0;
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A295egrBod = (decimal)(O295egrBod+A301egrTipo);
               n295egrBod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A295egrBod = (decimal)(O295egrBod+A301egrTipo-O301egrTipo);
                  n295egrBod = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A295egrBod = (decimal)(O295egrBod-O301egrTipo);
                     n295egrBod = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
                  }
               }
            }
            A292stockBod = NumberUtil.Round( ((A293invFisico+A294ingBod)-A295egrBod), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
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

      protected void EndLevel1185( )
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

      public void ScanStart1185( )
      {
         /* Scan By routine */
         /* Using cursor T001165 */
         pr_default.execute(51, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         RcdFound85 = 0;
         if ( (pr_default.getStatus(51) != 101) )
         {
            RcdFound85 = 1;
            A348stockDetID = T001165_A348stockDetID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1185( )
      {
         /* Scan next routine */
         pr_default.readNext(51);
         RcdFound85 = 0;
         if ( (pr_default.getStatus(51) != 101) )
         {
            RcdFound85 = 1;
            A348stockDetID = T001165_A348stockDetID[0];
         }
      }

      protected void ScanEnd1185( )
      {
         pr_default.close(51);
      }

      protected void AfterConfirm1185( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1185( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1185( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1185( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1185( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1185( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1185( )
      {
         edtstockDetID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetID_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtTipoInv_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInv_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInv_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtTipoInvMov_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvMov_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInvMov_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtTipoInvSigno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvSigno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInvSigno_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtcantidad_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcantidad_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtClienteID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtClienteRUC_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteRUC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteRUC_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtClienteDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteDsc_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtstock_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtcosto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcosto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcosto_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtcostUni_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcostUni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcostUni_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtstockDetNroDoc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetNroDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetNroDoc_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtstockdetTipo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockdetTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockdetTipo_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtfchMovStock_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfchMovStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfchMovStock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edthraMovStock_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edthraMovStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edthraMovStock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtegrTipo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtegrTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtegrTipo_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
      }

      protected void send_integrity_lvl_hashes1185( )
      {
      }

      protected void send_integrity_lvl_hashes1184( )
      {
      }

      protected void SubsflControlProps_10989( )
      {
         edtstockDetIngID_Internalname = "STOCKDETINGID_"+sGXsfl_109_idx;
         edtingTipoInv_Internalname = "INGTIPOINV_"+sGXsfl_109_idx;
         imgprompt_383_Internalname = "PROMPT_383_"+sGXsfl_109_idx;
         edtingTipoInvMov_Internalname = "INGTIPOINVMOV_"+sGXsfl_109_idx;
         edtingTipoSigno_Internalname = "INGTIPOSIGNO_"+sGXsfl_109_idx;
         edtPrvRuc_Internalname = "PRVRUC_"+sGXsfl_109_idx;
         imgprompt_37_Internalname = "PROMPT_37_"+sGXsfl_109_idx;
         edtPrvDsc_Internalname = "PRVDSC_"+sGXsfl_109_idx;
         edtingCantidad_Internalname = "INGCANTIDAD_"+sGXsfl_109_idx;
         edtingBodNroDoc_Internalname = "INGBODNRODOC_"+sGXsfl_109_idx;
         edtingBodTipoDoc_Internalname = "INGBODTIPODOC_"+sGXsfl_109_idx;
         edtfchMovIng_Internalname = "FCHMOVING_"+sGXsfl_109_idx;
         edthraMovIng_Internalname = "HRAMOVING_"+sGXsfl_109_idx;
      }

      protected void SubsflControlProps_fel_10989( )
      {
         edtstockDetIngID_Internalname = "STOCKDETINGID_"+sGXsfl_109_fel_idx;
         edtingTipoInv_Internalname = "INGTIPOINV_"+sGXsfl_109_fel_idx;
         imgprompt_383_Internalname = "PROMPT_383_"+sGXsfl_109_fel_idx;
         edtingTipoInvMov_Internalname = "INGTIPOINVMOV_"+sGXsfl_109_fel_idx;
         edtingTipoSigno_Internalname = "INGTIPOSIGNO_"+sGXsfl_109_fel_idx;
         edtPrvRuc_Internalname = "PRVRUC_"+sGXsfl_109_fel_idx;
         imgprompt_37_Internalname = "PROMPT_37_"+sGXsfl_109_fel_idx;
         edtPrvDsc_Internalname = "PRVDSC_"+sGXsfl_109_fel_idx;
         edtingCantidad_Internalname = "INGCANTIDAD_"+sGXsfl_109_fel_idx;
         edtingBodNroDoc_Internalname = "INGBODNRODOC_"+sGXsfl_109_fel_idx;
         edtingBodTipoDoc_Internalname = "INGBODTIPODOC_"+sGXsfl_109_fel_idx;
         edtfchMovIng_Internalname = "FCHMOVING_"+sGXsfl_109_fel_idx;
         edthraMovIng_Internalname = "HRAMOVING_"+sGXsfl_109_fel_idx;
      }

      protected void AddRow1189( )
      {
         nGXsfl_109_idx = (short)(nGXsfl_109_idx+1);
         sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0");
         SubsflControlProps_10989( ) ;
         SendRow1189( ) ;
      }

      protected void SendRow1189( )
      {
         Grid1Row = GXWebRow.GetNew(context);
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
            if ( ((int)(((nGXsfl_109_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
         imgprompt_383_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0100.aspx"+"',["+"{Ctrl:gx.dom.el('"+"INGTIPOINV_"+sGXsfl_109_idx+"'), id:'"+"INGTIPOINV_"+sGXsfl_109_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_89_"+sGXsfl_109_idx+","+"'', false"+","+"false"+");");
         imgprompt_37_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00v0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRVRUC_"+sGXsfl_109_idx+"'), id:'"+"PRVRUC_"+sGXsfl_109_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_89_"+sGXsfl_109_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_89_" + sGXsfl_109_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 110,'',false,'" + sGXsfl_109_idx + "',109)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstockDetIngID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A389stockDetIngID), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A389stockDetIngID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,110);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstockDetIngID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtstockDetIngID_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_89_" + sGXsfl_109_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 111,'',false,'" + sGXsfl_109_idx + "',109)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingTipoInv_Internalname,StringUtil.RTrim( A383ingTipoInv),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,111);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingTipoInv_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtingTipoInv_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_383_Internalname,(String)sImgUrl,(String)imgprompt_383_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_383_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingTipoInvMov_Internalname,(String)A384ingTipoInvMov,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingTipoInvMov_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtingTipoInvMov_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingTipoSigno_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A385ingTipoSigno), 2, 0, ",", "")),((edtingTipoSigno_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A385ingTipoSigno), "Z9")) : context.localUtil.Format( (decimal)(A385ingTipoSigno), "Z9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingTipoSigno_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtingTipoSigno_Enabled,(short)0,(String)"number",(String)"1",(short)32,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_89_" + sGXsfl_109_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 114,'',false,'" + sGXsfl_109_idx + "',109)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrvRuc_Internalname,StringUtil.RTrim( A37PrvRuc),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,114);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrvRuc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPrvRuc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_37_Internalname,(String)sImgUrl,(String)imgprompt_37_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_37_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPrvDsc_Internalname,(String)A184PrvDsc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPrvDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtPrvDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)150,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_89_" + sGXsfl_109_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 116,'',false,'" + sGXsfl_109_idx + "',109)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingCantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A386ingCantidad, 9, 2, ",", "")),((edtingCantidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A386ingCantidad, "ZZZZZ9.99")) : context.localUtil.Format( A386ingCantidad, "ZZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,116);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingCantidad_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtingCantidad_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingBodNroDoc_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A390ingBodNroDoc), 4, 0, ",", "")),((edtingBodNroDoc_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A390ingBodNroDoc), "ZZZ9")) : context.localUtil.Format( (decimal)(A390ingBodNroDoc), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingBodNroDoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtingBodNroDoc_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingBodTipoDoc_Internalname,StringUtil.RTrim( A391ingBodTipoDoc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingBodTipoDoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtingBodTipoDoc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtfchMovIng_Internalname,context.localUtil.Format(A387fchMovIng, "99/99/9999"),context.localUtil.Format( A387fchMovIng, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtfchMovIng_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtfchMovIng_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edthraMovIng_Internalname,context.localUtil.TToC( A388hraMovIng, 10, 8, 0, 3, "/", ":", " "),context.localUtil.Format( A388hraMovIng, "99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edthraMovIng_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edthraMovIng_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)109,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXus\\Time",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Grid1Row);
         send_integrity_lvl_hashes1189( ) ;
         GXCCtl = "Z389stockDetIngID_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z389stockDetIngID), 4, 0, ",", "")));
         GXCCtl = "Z386ingCantidad_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z386ingCantidad, 9, 2, ",", "")));
         GXCCtl = "Z387fchMovIng_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z387fchMovIng, 0, "/"));
         GXCCtl = "Z388hraMovIng_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.TToC( Z388hraMovIng, 10, 8, 0, 0, "/", ":", " "));
         GXCCtl = "Z390ingBodNroDoc_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z390ingBodNroDoc), 4, 0, ",", "")));
         GXCCtl = "Z391ingBodTipoDoc_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z391ingBodTipoDoc));
         GXCCtl = "Z37PrvRuc_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z37PrvRuc));
         GXCCtl = "Z383ingTipoInv_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z383ingTipoInv));
         GXCCtl = "O300ingTipo_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O300ingTipo, 9, 2, ",", "")));
         GXCCtl = "nRcdDeleted_89_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_89), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_89_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_89), 4, 0, ",", "")));
         GXCCtl = "nIsMod_89_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_89), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_109_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV18TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV18TrnContext);
         }
         GXCCtl = "vSTOCKANIO_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15stockAnio), 4, 0, ",", "")));
         GXCCtl = "vSTOCKMES_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16stockMes), 2, 0, ",", "")));
         GXCCtl = "vEMPID_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9EmpID), 4, 0, ",", "")));
         GXCCtl = "vAGEID_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7AgeID), 4, 0, ",", "")));
         GXCCtl = "vBODCOD_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BodCod), 4, 0, ",", "")));
         GXCCtl = "vPRDCOD_" + sGXsfl_109_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14PrdCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "STOCKDETINGID_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetIngID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGTIPOINV_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoInv_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGTIPOINVMOV_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoInvMov_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGTIPOSIGNO_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipoSigno_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRVRUC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvRuc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRVDSC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPrvDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGCANTIDAD_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingCantidad_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGBODNRODOC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingBodNroDoc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGBODTIPODOC_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingBodTipoDoc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FCHMOVING_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtfchMovIng_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "HRAMOVING_"+sGXsfl_109_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edthraMovIng_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_383_"+sGXsfl_109_idx+"Link", StringUtil.RTrim( imgprompt_383_Link));
         GxWebStd.gx_hidden_field( context, "PROMPT_37_"+sGXsfl_109_idx+"Link", StringUtil.RTrim( imgprompt_37_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Grid1Container.AddRow(Grid1Row);
      }

      protected void ReadRow1189( )
      {
         nGXsfl_109_idx = (short)(nGXsfl_109_idx+1);
         sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0");
         SubsflControlProps_10989( ) ;
         edtstockDetIngID_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCKDETINGID_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         edtingTipoInv_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGTIPOINV_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         edtingTipoInvMov_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGTIPOINVMOV_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         edtingTipoSigno_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGTIPOSIGNO_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         edtPrvRuc_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRVRUC_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         edtPrvDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRVDSC_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         edtingCantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGCANTIDAD_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         edtingBodNroDoc_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGBODNRODOC_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         edtingBodTipoDoc_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGBODTIPODOC_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         edtfchMovIng_Enabled = (int)(context.localUtil.CToN( cgiGet( "FCHMOVING_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         edthraMovIng_Enabled = (int)(context.localUtil.CToN( cgiGet( "HRAMOVING_"+sGXsfl_109_idx+"Enabled"), ",", "."));
         imgprompt_1_42_Link = cgiGet( "PROMPT_383_"+sGXsfl_109_idx+"Link");
         imgprompt_1_42_Link = cgiGet( "PROMPT_37_"+sGXsfl_109_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtstockDetIngID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtstockDetIngID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "STOCKDETINGID_" + sGXsfl_109_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtstockDetIngID_Internalname;
            wbErr = true;
            A389stockDetIngID = 0;
         }
         else
         {
            A389stockDetIngID = (short)(context.localUtil.CToN( cgiGet( edtstockDetIngID_Internalname), ",", "."));
         }
         A383ingTipoInv = cgiGet( edtingTipoInv_Internalname);
         A384ingTipoInvMov = cgiGet( edtingTipoInvMov_Internalname);
         n384ingTipoInvMov = false;
         A385ingTipoSigno = (short)(context.localUtil.CToN( cgiGet( edtingTipoSigno_Internalname), ",", "."));
         n385ingTipoSigno = false;
         A37PrvRuc = cgiGet( edtPrvRuc_Internalname);
         A184PrvDsc = cgiGet( edtPrvDsc_Internalname);
         n184PrvDsc = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtingCantidad_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtingCantidad_Internalname), ",", ".") > 999999.99m ) ) )
         {
            GXCCtl = "INGCANTIDAD_" + sGXsfl_109_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtingCantidad_Internalname;
            wbErr = true;
            A386ingCantidad = 0;
            n386ingCantidad = false;
         }
         else
         {
            A386ingCantidad = context.localUtil.CToN( cgiGet( edtingCantidad_Internalname), ",", ".");
            n386ingCantidad = false;
         }
         n386ingCantidad = ((Convert.ToDecimal(0)==A386ingCantidad) ? true : false);
         A390ingBodNroDoc = (short)(context.localUtil.CToN( cgiGet( edtingBodNroDoc_Internalname), ",", "."));
         n390ingBodNroDoc = false;
         A391ingBodTipoDoc = cgiGet( edtingBodTipoDoc_Internalname);
         n391ingBodTipoDoc = false;
         A387fchMovIng = context.localUtil.CToD( cgiGet( edtfchMovIng_Internalname), 2);
         n387fchMovIng = false;
         A388hraMovIng = DateTimeUtil.ResetDate(context.localUtil.CToT( cgiGet( edthraMovIng_Internalname)));
         n388hraMovIng = false;
         GXCCtl = "Z389stockDetIngID_" + sGXsfl_109_idx;
         Z389stockDetIngID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z386ingCantidad_" + sGXsfl_109_idx;
         Z386ingCantidad = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n386ingCantidad = ((Convert.ToDecimal(0)==A386ingCantidad) ? true : false);
         GXCCtl = "Z387fchMovIng_" + sGXsfl_109_idx;
         Z387fchMovIng = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         n387fchMovIng = ((DateTime.MinValue==A387fchMovIng) ? true : false);
         GXCCtl = "Z388hraMovIng_" + sGXsfl_109_idx;
         Z388hraMovIng = DateTimeUtil.ResetDate(context.localUtil.CToT( cgiGet( GXCCtl), 0));
         n388hraMovIng = ((DateTime.MinValue==A388hraMovIng) ? true : false);
         GXCCtl = "Z390ingBodNroDoc_" + sGXsfl_109_idx;
         Z390ingBodNroDoc = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n390ingBodNroDoc = ((0==A390ingBodNroDoc) ? true : false);
         GXCCtl = "Z391ingBodTipoDoc_" + sGXsfl_109_idx;
         Z391ingBodTipoDoc = cgiGet( GXCCtl);
         n391ingBodTipoDoc = (String.IsNullOrEmpty(StringUtil.RTrim( A391ingBodTipoDoc)) ? true : false);
         GXCCtl = "Z37PrvRuc_" + sGXsfl_109_idx;
         Z37PrvRuc = cgiGet( GXCCtl);
         GXCCtl = "Z383ingTipoInv_" + sGXsfl_109_idx;
         Z383ingTipoInv = cgiGet( GXCCtl);
         GXCCtl = "O300ingTipo_" + sGXsfl_109_idx;
         O300ingTipo = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         GXCCtl = "nRcdDeleted_89_" + sGXsfl_109_idx;
         nRcdDeleted_89 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_89_" + sGXsfl_109_idx;
         nRcdExists_89 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_89_" + sGXsfl_109_idx;
         nIsMod_89 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void SubsflControlProps_12885( )
      {
         edtstockDetID_Internalname = "STOCKDETID_"+sGXsfl_128_idx;
         edtTipoInv_Internalname = "TIPOINV_"+sGXsfl_128_idx;
         imgprompt_43_Internalname = "PROMPT_43_"+sGXsfl_128_idx;
         edtTipoInvMov_Internalname = "TIPOINVMOV_"+sGXsfl_128_idx;
         edtTipoInvSigno_Internalname = "TIPOINVSIGNO_"+sGXsfl_128_idx;
         edtcantidad_Internalname = "CANTIDAD_"+sGXsfl_128_idx;
         edtClienteID_Internalname = "CLIENTEID_"+sGXsfl_128_idx;
         edtClienteRUC_Internalname = "CLIENTERUC_"+sGXsfl_128_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_128_idx;
         edtstock_Internalname = "STOCK_"+sGXsfl_128_idx;
         edtcosto_Internalname = "COSTO_"+sGXsfl_128_idx;
         edtcostUni_Internalname = "COSTUNI_"+sGXsfl_128_idx;
         edtstockDetNroDoc_Internalname = "STOCKDETNRODOC_"+sGXsfl_128_idx;
         edtstockdetTipo_Internalname = "STOCKDETTIPO_"+sGXsfl_128_idx;
         edtfchMovStock_Internalname = "FCHMOVSTOCK_"+sGXsfl_128_idx;
         edthraMovStock_Internalname = "HRAMOVSTOCK_"+sGXsfl_128_idx;
         edtingTipo_Internalname = "INGTIPO_"+sGXsfl_128_idx;
         edtegrTipo_Internalname = "EGRTIPO_"+sGXsfl_128_idx;
      }

      protected void SubsflControlProps_fel_12885( )
      {
         edtstockDetID_Internalname = "STOCKDETID_"+sGXsfl_128_fel_idx;
         edtTipoInv_Internalname = "TIPOINV_"+sGXsfl_128_fel_idx;
         imgprompt_43_Internalname = "PROMPT_43_"+sGXsfl_128_fel_idx;
         edtTipoInvMov_Internalname = "TIPOINVMOV_"+sGXsfl_128_fel_idx;
         edtTipoInvSigno_Internalname = "TIPOINVSIGNO_"+sGXsfl_128_fel_idx;
         edtcantidad_Internalname = "CANTIDAD_"+sGXsfl_128_fel_idx;
         edtClienteID_Internalname = "CLIENTEID_"+sGXsfl_128_fel_idx;
         edtClienteRUC_Internalname = "CLIENTERUC_"+sGXsfl_128_fel_idx;
         edtClienteDsc_Internalname = "CLIENTEDSC_"+sGXsfl_128_fel_idx;
         edtstock_Internalname = "STOCK_"+sGXsfl_128_fel_idx;
         edtcosto_Internalname = "COSTO_"+sGXsfl_128_fel_idx;
         edtcostUni_Internalname = "COSTUNI_"+sGXsfl_128_fel_idx;
         edtstockDetNroDoc_Internalname = "STOCKDETNRODOC_"+sGXsfl_128_fel_idx;
         edtstockdetTipo_Internalname = "STOCKDETTIPO_"+sGXsfl_128_fel_idx;
         edtfchMovStock_Internalname = "FCHMOVSTOCK_"+sGXsfl_128_fel_idx;
         edthraMovStock_Internalname = "HRAMOVSTOCK_"+sGXsfl_128_fel_idx;
         edtingTipo_Internalname = "INGTIPO_"+sGXsfl_128_fel_idx;
         edtegrTipo_Internalname = "EGRTIPO_"+sGXsfl_128_fel_idx;
      }

      protected void AddRow1185( )
      {
         nGXsfl_128_idx = (short)(nGXsfl_128_idx+1);
         sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_128_idx), 4, 0)), 4, "0");
         SubsflControlProps_12885( ) ;
         SendRow1185( ) ;
      }

      protected void SendRow1185( )
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
            if ( ((int)(((nGXsfl_128_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
         imgprompt_43_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0100.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TIPOINV_"+sGXsfl_128_idx+"'), id:'"+"TIPOINV_"+sGXsfl_128_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_85_"+sGXsfl_128_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_85_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 129,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstockDetID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A348stockDetID), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A348stockDetID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,129);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstockDetID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtstockDetID_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_85_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 130,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInv_Internalname,StringUtil.RTrim( A43TipoInv),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,130);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInv_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtTipoInv_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridprodxbodega_tipoRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_43_Internalname,(String)sImgUrl,(String)imgprompt_43_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_43_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInvMov_Internalname,(String)A219TipoInvMov,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInvMov_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtTipoInvMov_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoInvSigno_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ",", "")),((edtTipoInvSigno_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A223TipoInvSigno), "Z9")) : context.localUtil.Format( (decimal)(A223TipoInvSigno), "Z9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoInvSigno_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtTipoInvSigno_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_85_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 133,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A296cantidad, 10, 2, ",", "")),((edtcantidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A296cantidad, "ZZZ.ZZ9.99")) : context.localUtil.Format( A296cantidad, "ZZZ.ZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,133);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcantidad_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcantidad_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5ClienteID), 4, 0, ",", "")),((edtClienteID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9")) : context.localUtil.Format( (decimal)(A5ClienteID), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtClienteID_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteRUC_Internalname,StringUtil.RTrim( A56ClienteRUC),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteRUC_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtClienteRUC_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteDsc_Internalname,StringUtil.RTrim( A57ClienteDsc),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtClienteDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)-1,(bool)true,(String)"Descripcion",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstock_Internalname,StringUtil.LTrim( StringUtil.NToC( A297stock, 9, 2, ",", "")),((edtstock_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A297stock, "ZZZZZ9.99")) : context.localUtil.Format( A297stock, "ZZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstock_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtstock_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcosto_Internalname,StringUtil.LTrim( StringUtil.NToC( A298costo, 13, 2, ",", "")),((edtcosto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A298costo, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A298costo, "ZZ,ZZZ,ZZZ.ZZ")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcosto_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtcosto_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"valores",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcostUni_Internalname,StringUtil.LTrim( StringUtil.NToC( A299costUni, 13, 2, ",", "")),((edtcostUni_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A299costUni, "ZZ,ZZZ,ZZZ.ZZ")) : context.localUtil.Format( A299costUni, "ZZ,ZZZ,ZZZ.ZZ")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcostUni_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtcostUni_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)13,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"valores",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_85_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 140,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstockDetNroDoc_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A351stockDetNroDoc), 4, 0, ",", "")),((edtstockDetNroDoc_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A351stockDetNroDoc), "ZZZ9")) : context.localUtil.Format( (decimal)(A351stockDetNroDoc), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,140);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstockDetNroDoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtstockDetNroDoc_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_85_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 141,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtstockdetTipo_Internalname,StringUtil.RTrim( A352stockdetTipo),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,141);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtstockdetTipo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtstockdetTipo_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtfchMovStock_Internalname,context.localUtil.Format(A374fchMovStock, "99/99/9999"),context.localUtil.Format( A374fchMovStock, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtfchMovStock_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtfchMovStock_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edthraMovStock_Internalname,context.localUtil.TToC( A375hraMovStock, 10, 8, 0, 3, "/", ":", " "),context.localUtil.Format( A375hraMovStock, "99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edthraMovStock_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edthraMovStock_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXus\\Time",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtingTipo_Internalname,StringUtil.LTrim( StringUtil.NToC( A300ingTipo, 10, 2, ",", "")),((edtingTipo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A300ingTipo, "ZZZ.ZZ9.99")) : context.localUtil.Format( A300ingTipo, "ZZZ.ZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtingTipo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtingTipo_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridprodxbodega_tipoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtegrTipo_Internalname,StringUtil.LTrim( StringUtil.NToC( A301egrTipo, 10, 2, ",", "")),((edtegrTipo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A301egrTipo, "ZZZ.ZZ9.99")) : context.localUtil.Format( A301egrTipo, "ZZZ.ZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtegrTipo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtegrTipo_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridprodxbodega_tipoRow);
         send_integrity_lvl_hashes1185( ) ;
         GXCCtl = "Z348stockDetID_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z348stockDetID), 4, 0, ",", "")));
         GXCCtl = "Z296cantidad_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z296cantidad, 9, 2, ",", "")));
         GXCCtl = "Z297stock_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z297stock, 9, 2, ",", "")));
         GXCCtl = "Z351stockDetNroDoc_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z351stockDetNroDoc), 4, 0, ",", "")));
         GXCCtl = "Z352stockdetTipo_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z352stockdetTipo));
         GXCCtl = "Z298costo_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z298costo, 10, 2, ",", "")));
         GXCCtl = "Z374fchMovStock_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z374fchMovStock, 0, "/"));
         GXCCtl = "Z375hraMovStock_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.TToC( Z375hraMovStock, 10, 8, 0, 0, "/", ":", " "));
         GXCCtl = "Z5ClienteID_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5ClienteID), 4, 0, ",", "")));
         GXCCtl = "Z43TipoInv_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z43TipoInv));
         GXCCtl = "O301egrTipo_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O301egrTipo, 9, 2, ",", "")));
         GXCCtl = "O297stock_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O297stock, 9, 2, ",", "")));
         GXCCtl = "nRcdDeleted_85_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_85), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_85_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_85), 4, 0, ",", "")));
         GXCCtl = "nIsMod_85_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_85), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_128_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV18TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV18TrnContext);
         }
         GXCCtl = "vSTOCKANIO_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15stockAnio), 4, 0, ",", "")));
         GXCCtl = "vSTOCKMES_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16stockMes), 2, 0, ",", "")));
         GXCCtl = "vEMPID_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9EmpID), 4, 0, ",", "")));
         GXCCtl = "vAGEID_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7AgeID), 4, 0, ",", "")));
         GXCCtl = "vBODCOD_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BodCod), 4, 0, ",", "")));
         GXCCtl = "vPRDCOD_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14PrdCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "STOCKDETID_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPOINV_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInv_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPOINVMOV_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvMov_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPOINVSIGNO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoInvSigno_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CANTIDAD_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcantidad_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CLIENTEID_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CLIENTERUC_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteRUC_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CLIENTEDSC_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "STOCK_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstock_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "COSTO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcosto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "COSTUNI_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcostUni_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "STOCKDETNRODOC_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockDetNroDoc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "STOCKDETTIPO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtstockdetTipo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FCHMOVSTOCK_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtfchMovStock_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "HRAMOVSTOCK_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edthraMovStock_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INGTIPO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtingTipo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "EGRTIPO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtegrTipo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_43_"+sGXsfl_128_idx+"Link", StringUtil.RTrim( imgprompt_43_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridprodxbodega_tipoContainer.AddRow(Gridprodxbodega_tipoRow);
      }

      protected void ReadRow1185( )
      {
         nGXsfl_128_idx = (short)(nGXsfl_128_idx+1);
         sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_128_idx), 4, 0)), 4, "0");
         SubsflControlProps_12885( ) ;
         edtstockDetID_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCKDETID_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtTipoInv_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOINV_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtTipoInvMov_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOINVMOV_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtTipoInvSigno_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPOINVSIGNO_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtcantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "CANTIDAD_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtClienteID_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTEID_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtClienteRUC_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTERUC_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtClienteDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTEDSC_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtstock_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCK_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtcosto_Enabled = (int)(context.localUtil.CToN( cgiGet( "COSTO_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtcostUni_Enabled = (int)(context.localUtil.CToN( cgiGet( "COSTUNI_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtstockDetNroDoc_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCKDETNRODOC_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtstockdetTipo_Enabled = (int)(context.localUtil.CToN( cgiGet( "STOCKDETTIPO_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtfchMovStock_Enabled = (int)(context.localUtil.CToN( cgiGet( "FCHMOVSTOCK_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edthraMovStock_Enabled = (int)(context.localUtil.CToN( cgiGet( "HRAMOVSTOCK_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtingTipo_Enabled = (int)(context.localUtil.CToN( cgiGet( "INGTIPO_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         edtegrTipo_Enabled = (int)(context.localUtil.CToN( cgiGet( "EGRTIPO_"+sGXsfl_128_idx+"Enabled"), ",", "."));
         imgprompt_1_42_Link = cgiGet( "PROMPT_43_"+sGXsfl_128_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtstockDetID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtstockDetID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "STOCKDETID_" + sGXsfl_128_idx;
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
         A43TipoInv = cgiGet( edtTipoInv_Internalname);
         A219TipoInvMov = cgiGet( edtTipoInvMov_Internalname);
         n219TipoInvMov = false;
         A223TipoInvSigno = (short)(context.localUtil.CToN( cgiGet( edtTipoInvSigno_Internalname), ",", "."));
         n223TipoInvSigno = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtcantidad_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcantidad_Internalname), ",", ".") > 999999.99m ) ) )
         {
            GXCCtl = "CANTIDAD_" + sGXsfl_128_idx;
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
         A5ClienteID = (short)(context.localUtil.CToN( cgiGet( edtClienteID_Internalname), ",", "."));
         A56ClienteRUC = cgiGet( edtClienteRUC_Internalname);
         n56ClienteRUC = false;
         A57ClienteDsc = cgiGet( edtClienteDsc_Internalname);
         n57ClienteDsc = false;
         A297stock = context.localUtil.CToN( cgiGet( edtstock_Internalname), ",", ".");
         n297stock = false;
         A298costo = context.localUtil.CToN( cgiGet( edtcosto_Internalname), ",", ".");
         n298costo = false;
         A299costUni = context.localUtil.CToN( cgiGet( edtcostUni_Internalname), ",", ".");
         if ( ( ( context.localUtil.CToN( cgiGet( edtstockDetNroDoc_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtstockDetNroDoc_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "STOCKDETNRODOC_" + sGXsfl_128_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtstockDetNroDoc_Internalname;
            wbErr = true;
            A351stockDetNroDoc = 0;
            n351stockDetNroDoc = false;
         }
         else
         {
            A351stockDetNroDoc = (short)(context.localUtil.CToN( cgiGet( edtstockDetNroDoc_Internalname), ",", "."));
            n351stockDetNroDoc = false;
         }
         n351stockDetNroDoc = ((0==A351stockDetNroDoc) ? true : false);
         A352stockdetTipo = cgiGet( edtstockdetTipo_Internalname);
         n352stockdetTipo = false;
         n352stockdetTipo = (String.IsNullOrEmpty(StringUtil.RTrim( A352stockdetTipo)) ? true : false);
         A374fchMovStock = context.localUtil.CToD( cgiGet( edtfchMovStock_Internalname), 2);
         n374fchMovStock = false;
         A375hraMovStock = DateTimeUtil.ResetDate(context.localUtil.CToT( cgiGet( edthraMovStock_Internalname)));
         n375hraMovStock = false;
         A300ingTipo = context.localUtil.CToN( cgiGet( edtingTipo_Internalname), ",", ".");
         A301egrTipo = context.localUtil.CToN( cgiGet( edtegrTipo_Internalname), ",", ".");
         GXCCtl = "Z348stockDetID_" + sGXsfl_128_idx;
         Z348stockDetID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z296cantidad_" + sGXsfl_128_idx;
         Z296cantidad = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n296cantidad = ((Convert.ToDecimal(0)==A296cantidad) ? true : false);
         GXCCtl = "Z297stock_" + sGXsfl_128_idx;
         Z297stock = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n297stock = ((Convert.ToDecimal(0)==A297stock) ? true : false);
         GXCCtl = "Z351stockDetNroDoc_" + sGXsfl_128_idx;
         Z351stockDetNroDoc = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n351stockDetNroDoc = ((0==A351stockDetNroDoc) ? true : false);
         GXCCtl = "Z352stockdetTipo_" + sGXsfl_128_idx;
         Z352stockdetTipo = cgiGet( GXCCtl);
         n352stockdetTipo = (String.IsNullOrEmpty(StringUtil.RTrim( A352stockdetTipo)) ? true : false);
         GXCCtl = "Z298costo_" + sGXsfl_128_idx;
         Z298costo = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n298costo = ((Convert.ToDecimal(0)==A298costo) ? true : false);
         GXCCtl = "Z374fchMovStock_" + sGXsfl_128_idx;
         Z374fchMovStock = context.localUtil.CToD( cgiGet( GXCCtl), 0);
         n374fchMovStock = ((DateTime.MinValue==A374fchMovStock) ? true : false);
         GXCCtl = "Z375hraMovStock_" + sGXsfl_128_idx;
         Z375hraMovStock = DateTimeUtil.ResetDate(context.localUtil.CToT( cgiGet( GXCCtl), 0));
         n375hraMovStock = ((DateTime.MinValue==A375hraMovStock) ? true : false);
         GXCCtl = "Z5ClienteID_" + sGXsfl_128_idx;
         Z5ClienteID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z43TipoInv_" + sGXsfl_128_idx;
         Z43TipoInv = cgiGet( GXCCtl);
         GXCCtl = "O301egrTipo_" + sGXsfl_128_idx;
         O301egrTipo = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         GXCCtl = "O297stock_" + sGXsfl_128_idx;
         O297stock = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n297stock = ((Convert.ToDecimal(0)==A297stock) ? true : false);
         GXCCtl = "nRcdDeleted_85_" + sGXsfl_128_idx;
         nRcdDeleted_85 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_85_" + sGXsfl_128_idx;
         nRcdExists_85 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_85_" + sGXsfl_128_idx;
         nIsMod_85 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtegrTipo_Enabled = edtegrTipo_Enabled;
         defedthraMovStock_Enabled = edthraMovStock_Enabled;
         defedtfchMovStock_Enabled = edtfchMovStock_Enabled;
         defedtcostUni_Enabled = edtcostUni_Enabled;
         defedtcosto_Enabled = edtcosto_Enabled;
         defedtstock_Enabled = edtstock_Enabled;
         defedtClienteDsc_Enabled = edtClienteDsc_Enabled;
         defedtClienteRUC_Enabled = edtClienteRUC_Enabled;
         defedtClienteID_Enabled = edtClienteID_Enabled;
         defedtTipoInvSigno_Enabled = edtTipoInvSigno_Enabled;
         defedtstockDetID_Enabled = edtstockDetID_Enabled;
         defedthraMovIng_Enabled = edthraMovIng_Enabled;
         defedtfchMovIng_Enabled = edtfchMovIng_Enabled;
         defedtingBodTipoDoc_Enabled = edtingBodTipoDoc_Enabled;
         defedtingBodNroDoc_Enabled = edtingBodNroDoc_Enabled;
         defedtingTipoSigno_Enabled = edtingTipoSigno_Enabled;
         defedtstockDetIngID_Enabled = edtstockDetIngID_Enabled;
      }

      protected void ConfirmValues110( )
      {
         nGXsfl_109_idx = 0;
         sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0");
         SubsflControlProps_10989( ) ;
         while ( nGXsfl_109_idx < nRC_GXsfl_109 )
         {
            nGXsfl_109_idx = (short)(nGXsfl_109_idx+1);
            sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0");
            SubsflControlProps_10989( ) ;
            ChangePostValue( "Z389stockDetIngID_"+sGXsfl_109_idx, cgiGet( "ZT_"+"Z389stockDetIngID_"+sGXsfl_109_idx)) ;
            DeletePostValue( "ZT_"+"Z389stockDetIngID_"+sGXsfl_109_idx) ;
            ChangePostValue( "Z386ingCantidad_"+sGXsfl_109_idx, cgiGet( "ZT_"+"Z386ingCantidad_"+sGXsfl_109_idx)) ;
            DeletePostValue( "ZT_"+"Z386ingCantidad_"+sGXsfl_109_idx) ;
            ChangePostValue( "Z387fchMovIng_"+sGXsfl_109_idx, cgiGet( "ZT_"+"Z387fchMovIng_"+sGXsfl_109_idx)) ;
            DeletePostValue( "ZT_"+"Z387fchMovIng_"+sGXsfl_109_idx) ;
            ChangePostValue( "Z388hraMovIng_"+sGXsfl_109_idx, cgiGet( "ZT_"+"Z388hraMovIng_"+sGXsfl_109_idx)) ;
            DeletePostValue( "ZT_"+"Z388hraMovIng_"+sGXsfl_109_idx) ;
            ChangePostValue( "Z390ingBodNroDoc_"+sGXsfl_109_idx, cgiGet( "ZT_"+"Z390ingBodNroDoc_"+sGXsfl_109_idx)) ;
            DeletePostValue( "ZT_"+"Z390ingBodNroDoc_"+sGXsfl_109_idx) ;
            ChangePostValue( "Z391ingBodTipoDoc_"+sGXsfl_109_idx, cgiGet( "ZT_"+"Z391ingBodTipoDoc_"+sGXsfl_109_idx)) ;
            DeletePostValue( "ZT_"+"Z391ingBodTipoDoc_"+sGXsfl_109_idx) ;
            ChangePostValue( "Z37PrvRuc_"+sGXsfl_109_idx, cgiGet( "ZT_"+"Z37PrvRuc_"+sGXsfl_109_idx)) ;
            DeletePostValue( "ZT_"+"Z37PrvRuc_"+sGXsfl_109_idx) ;
            ChangePostValue( "Z383ingTipoInv_"+sGXsfl_109_idx, cgiGet( "ZT_"+"Z383ingTipoInv_"+sGXsfl_109_idx)) ;
            DeletePostValue( "ZT_"+"Z383ingTipoInv_"+sGXsfl_109_idx) ;
         }
         nGXsfl_128_idx = 0;
         sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_128_idx), 4, 0)), 4, "0");
         SubsflControlProps_12885( ) ;
         while ( nGXsfl_128_idx < nRC_GXsfl_128 )
         {
            nGXsfl_128_idx = (short)(nGXsfl_128_idx+1);
            sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_128_idx), 4, 0)), 4, "0");
            SubsflControlProps_12885( ) ;
            ChangePostValue( "Z348stockDetID_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z348stockDetID_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z348stockDetID_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z296cantidad_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z296cantidad_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z296cantidad_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z297stock_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z297stock_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z297stock_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z351stockDetNroDoc_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z351stockDetNroDoc_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z351stockDetNroDoc_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z352stockdetTipo_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z352stockdetTipo_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z352stockdetTipo_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z298costo_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z298costo_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z298costo_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z374fchMovStock_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z374fchMovStock_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z374fchMovStock_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z375hraMovStock_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z375hraMovStock_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z375hraMovStock_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z5ClienteID_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z5ClienteID_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z5ClienteID_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z43TipoInv_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z43TipoInv_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z43TipoInv_"+sGXsfl_128_idx) ;
         }
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
         context.SendWebValue( "Prod Stock Bodega") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231912203266", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-es.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("prodstockbodega.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV15stockAnio) + "," + UrlEncode("" +AV16stockMes) + "," + UrlEncode("" +AV9EmpID) + "," + UrlEncode("" +AV7AgeID) + "," + UrlEncode("" +AV8BodCod) + "," + UrlEncode("" +AV14PrdCod)+"\">") ;
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
         forbiddenHiddens = "hsh" + "ProdStockBodega";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("prodstockbodega:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
         GxWebStd.gx_hidden_field( context, "Z286PrdCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z286PrdCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z307prdStockDsc", Z307prdStockDsc);
         GxWebStd.gx_hidden_field( context, "Z293invFisico", StringUtil.LTrim( StringUtil.NToC( Z293invFisico, 6, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z350stockUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z350stockUltNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O350stockUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(O350stockUltNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O295egrBod", StringUtil.LTrim( StringUtil.NToC( O295egrBod, 9, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "O349totalStock", StringUtil.LTrim( StringUtil.NToC( O349totalStock, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "O294ingBod", StringUtil.LTrim( StringUtil.NToC( O294ingBod, 9, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_109", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_109_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_128", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_128_idx), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV18TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV18TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vSTOCKANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15stockAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSTOCKANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV15stockAnio), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21anio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSTOCKMES", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16stockMes), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSTOCKMES", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16stockMes), "Z9"), context));
         GxWebStd.gx_hidden_field( context, "vMES", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13mes), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7AgeID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7AgeID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vBODCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BodCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBODCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BodCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPRDCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14PrdCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPRDCOD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14PrdCod), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "STOCKULTNRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A350stockUltNro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "PRDPRES", StringUtil.LTrim( StringUtil.NToC( (decimal)(A288PrdPres), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TOTALSTOCK", StringUtil.LTrim( StringUtil.NToC( A349totalStock, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV23Pgmname));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "TABMOVIMIENTOS_Objectcall", StringUtil.RTrim( Tabmovimientos_Objectcall));
         GxWebStd.gx_hidden_field( context, "TABMOVIMIENTOS_Enabled", StringUtil.BoolToStr( Tabmovimientos_Enabled));
         GxWebStd.gx_hidden_field( context, "TABMOVIMIENTOS_Class", StringUtil.RTrim( Tabmovimientos_Class));
         GxWebStd.gx_hidden_field( context, "TABMOVIMIENTOS_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tabmovimientos_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABMOVIMIENTOS_Historymanagement", StringUtil.BoolToStr( Tabmovimientos_Historymanagement));
      }

      protected void RenderHtmlCloseForm1184( )
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
         return "ProdStockBodega" ;
      }

      public override String GetPgmdesc( )
      {
         return "Prod Stock Bodega" ;
      }

      protected void InitializeNonKey1184( )
      {
         A292stockBod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292stockBod", StringUtil.LTrim( StringUtil.Str( A292stockBod, 8, 2)));
         A217BodDsc = "";
         n217BodDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217BodDsc", A217BodDsc);
         A309prdNombre = "";
         n309prdNombre = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309prdNombre", A309prdNombre);
         A288PrdPres = 0;
         n288PrdPres = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288PrdPres", StringUtil.LTrim( StringUtil.Str( (decimal)(A288PrdPres), 2, 0)));
         A307prdStockDsc = "";
         n307prdStockDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307prdStockDsc", A307prdStockDsc);
         n307prdStockDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A307prdStockDsc)) ? true : false);
         A349totalStock = 0;
         n349totalStock = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
         A293invFisico = 0;
         n293invFisico = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293invFisico", StringUtil.LTrim( StringUtil.Str( A293invFisico, 6, 2)));
         n293invFisico = ((Convert.ToDecimal(0)==A293invFisico) ? true : false);
         A294ingBod = 0;
         n294ingBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         A295egrBod = 0;
         n295egrBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         A350stockUltNro = 0;
         n350stockUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
         O350stockUltNro = A350stockUltNro;
         n350stockUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
         O295egrBod = A295egrBod;
         n295egrBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295egrBod", StringUtil.LTrim( StringUtil.Str( A295egrBod, 9, 2)));
         O349totalStock = A349totalStock;
         n349totalStock = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
         O294ingBod = A294ingBod;
         n294ingBod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294ingBod", StringUtil.LTrim( StringUtil.Str( A294ingBod, 9, 2)));
         Z307prdStockDsc = "";
         Z293invFisico = 0;
         Z350stockUltNro = 0;
      }

      protected void InitAll1184( )
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
         A286PrdCod = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A286PrdCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A286PrdCod), 4, 0)));
         InitializeNonKey1184( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey1189( )
      {
         A300ingTipo = 0;
         A383ingTipoInv = "";
         A384ingTipoInvMov = "";
         n384ingTipoInvMov = false;
         A385ingTipoSigno = 0;
         n385ingTipoSigno = false;
         A386ingCantidad = 0;
         n386ingCantidad = false;
         A37PrvRuc = "";
         A184PrvDsc = "";
         n184PrvDsc = false;
         A387fchMovIng = DateTime.MinValue;
         n387fchMovIng = false;
         A388hraMovIng = (DateTime)(DateTime.MinValue);
         n388hraMovIng = false;
         A390ingBodNroDoc = 0;
         n390ingBodNroDoc = false;
         A391ingBodTipoDoc = "";
         n391ingBodTipoDoc = false;
         O300ingTipo = A300ingTipo;
         Z386ingCantidad = 0;
         Z387fchMovIng = DateTime.MinValue;
         Z388hraMovIng = (DateTime)(DateTime.MinValue);
         Z390ingBodNroDoc = 0;
         Z391ingBodTipoDoc = "";
         Z37PrvRuc = "";
         Z383ingTipoInv = "";
      }

      protected void InitAll1189( )
      {
         A389stockDetIngID = 0;
         InitializeNonKey1189( ) ;
      }

      protected void StandaloneModalInsert1189( )
      {
      }

      protected void InitializeNonKey1185( )
      {
         A301egrTipo = 0;
         A43TipoInv = "";
         A219TipoInvMov = "";
         n219TipoInvMov = false;
         A223TipoInvSigno = 0;
         n223TipoInvSigno = false;
         A296cantidad = 0;
         n296cantidad = false;
         A297stock = 0;
         n297stock = false;
         A351stockDetNroDoc = 0;
         n351stockDetNroDoc = false;
         A352stockdetTipo = "";
         n352stockdetTipo = false;
         A5ClienteID = 0;
         A56ClienteRUC = "";
         n56ClienteRUC = false;
         A57ClienteDsc = "";
         n57ClienteDsc = false;
         A298costo = 0;
         n298costo = false;
         A374fchMovStock = DateTime.MinValue;
         n374fchMovStock = false;
         A375hraMovStock = (DateTime)(DateTime.MinValue);
         n375hraMovStock = false;
         A299costUni = 0;
         O301egrTipo = A301egrTipo;
         O297stock = A297stock;
         n297stock = false;
         Z296cantidad = 0;
         Z297stock = 0;
         Z351stockDetNroDoc = 0;
         Z352stockdetTipo = "";
         Z298costo = 0;
         Z374fchMovStock = DateTime.MinValue;
         Z375hraMovStock = (DateTime)(DateTime.MinValue);
         Z5ClienteID = 0;
         Z43TipoInv = "";
      }

      protected void InitAll1185( )
      {
         A348stockDetID = 0;
         InitializeNonKey1185( ) ;
      }

      protected void StandaloneModalInsert1185( )
      {
         A350stockUltNro = i350stockUltNro;
         n350stockUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350stockUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A350stockUltNro), 4, 0)));
         A349totalStock = i349totalStock;
         n349totalStock = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349totalStock", StringUtil.LTrim( StringUtil.Str( A349totalStock, 10, 2)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231912203466", true);
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
         context.AddJavascriptSource("prodstockbodega.js", "?20231912203469", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties89( )
      {
         edthraMovIng_Enabled = defedthraMovIng_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edthraMovIng_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edthraMovIng_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtfchMovIng_Enabled = defedtfchMovIng_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfchMovIng_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfchMovIng_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingBodTipoDoc_Enabled = defedtingBodTipoDoc_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodTipoDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodTipoDoc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingBodNroDoc_Enabled = defedtingBodNroDoc_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingBodNroDoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingBodNroDoc_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtingTipoSigno_Enabled = defedtingTipoSigno_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtingTipoSigno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtingTipoSigno_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
         edtstockDetIngID_Enabled = defedtstockDetIngID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetIngID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetIngID_Enabled), 5, 0)), !bGXsfl_109_Refreshing);
      }

      protected void init_level_properties85( )
      {
         edtegrTipo_Enabled = defedtegrTipo_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtegrTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtegrTipo_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edthraMovStock_Enabled = defedthraMovStock_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edthraMovStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edthraMovStock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtfchMovStock_Enabled = defedtfchMovStock_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfchMovStock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfchMovStock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtcostUni_Enabled = defedtcostUni_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcostUni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcostUni_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtcosto_Enabled = defedtcosto_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcosto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcosto_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtstock_Enabled = defedtstock_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstock_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstock_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtClienteDsc_Enabled = defedtClienteDsc_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteDsc_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtClienteRUC_Enabled = defedtClienteRUC_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteRUC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteRUC_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtClienteID_Enabled = defedtClienteID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteID_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtTipoInvSigno_Enabled = defedtTipoInvSigno_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoInvSigno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoInvSigno_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
         edtstockDetID_Enabled = defedtstockDetID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtstockDetID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtstockDetID_Enabled), 5, 0)), !bGXsfl_128_Refreshing);
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
         edtPrdCod_Internalname = "PRDCOD";
         edtprdNombre_Internalname = "PRDNOMBRE";
         edtprdStockDsc_Internalname = "PRDSTOCKDSC";
         edtinvFisico_Internalname = "INVFISICO";
         edtingBod_Internalname = "INGBOD";
         divSection5_Internalname = "SECTION5";
         edtegrBod_Internalname = "EGRBOD";
         divSection6_Internalname = "SECTION6";
         edtstockBod_Internalname = "STOCKBOD";
         divSection7_Internalname = "SECTION7";
         lblTitletipo_Internalname = "TITLETIPO";
         lblTabpageing_title_Internalname = "TABPAGEING_TITLE";
         edtstockDetIngID_Internalname = "STOCKDETINGID";
         edtingTipoInv_Internalname = "INGTIPOINV";
         edtingTipoInvMov_Internalname = "INGTIPOINVMOV";
         edtingTipoSigno_Internalname = "INGTIPOSIGNO";
         edtPrvRuc_Internalname = "PRVRUC";
         edtPrvDsc_Internalname = "PRVDSC";
         edtingCantidad_Internalname = "INGCANTIDAD";
         edtingBodNroDoc_Internalname = "INGBODNRODOC";
         edtingBodTipoDoc_Internalname = "INGBODTIPODOC";
         edtfchMovIng_Internalname = "FCHMOVING";
         edthraMovIng_Internalname = "HRAMOVING";
         divTabpage1table_Internalname = "TABPAGE1TABLE";
         lblTabpageegr_title_Internalname = "TABPAGEEGR_TITLE";
         edtstockDetID_Internalname = "STOCKDETID";
         edtTipoInv_Internalname = "TIPOINV";
         edtTipoInvMov_Internalname = "TIPOINVMOV";
         edtTipoInvSigno_Internalname = "TIPOINVSIGNO";
         edtcantidad_Internalname = "CANTIDAD";
         edtClienteID_Internalname = "CLIENTEID";
         edtClienteRUC_Internalname = "CLIENTERUC";
         edtClienteDsc_Internalname = "CLIENTEDSC";
         edtstock_Internalname = "STOCK";
         edtcosto_Internalname = "COSTO";
         edtcostUni_Internalname = "COSTUNI";
         edtstockDetNroDoc_Internalname = "STOCKDETNRODOC";
         edtstockdetTipo_Internalname = "STOCKDETTIPO";
         edtfchMovStock_Internalname = "FCHMOVSTOCK";
         edthraMovStock_Internalname = "HRAMOVSTOCK";
         edtingTipo_Internalname = "INGTIPO";
         edtegrTipo_Internalname = "EGRTIPO";
         divTabpage2table_Internalname = "TABPAGE2TABLE";
         Tabmovimientos_Internalname = "TABMOVIMIENTOS";
         divTipotable_Internalname = "TIPOTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_42_Internalname = "PROMPT_1_42";
         imgprompt_1_2_286_Internalname = "PROMPT_1_2_286";
         imgprompt_383_Internalname = "PROMPT_383";
         imgprompt_37_Internalname = "PROMPT_37";
         imgprompt_43_Internalname = "PROMPT_43";
         subGrid1_Internalname = "GRID1";
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
         Tabmovimientos_Historymanagement = Convert.ToBoolean( 0);
         Tabmovimientos_Pagecount = 2;
         Tabmovimientos_Class = "Tab";
         edtegrTipo_Jsonclick = "";
         edtingTipo_Jsonclick = "";
         edthraMovStock_Jsonclick = "";
         edtfchMovStock_Jsonclick = "";
         edtstockdetTipo_Jsonclick = "";
         edtstockDetNroDoc_Jsonclick = "";
         edtcostUni_Jsonclick = "";
         edtcosto_Jsonclick = "";
         edtstock_Jsonclick = "";
         edtClienteDsc_Jsonclick = "";
         edtClienteRUC_Jsonclick = "";
         edtClienteID_Jsonclick = "";
         edtcantidad_Jsonclick = "";
         edtTipoInvSigno_Jsonclick = "";
         edtTipoInvMov_Jsonclick = "";
         imgprompt_43_Visible = 1;
         imgprompt_43_Link = "";
         edtTipoInv_Jsonclick = "";
         edtstockDetID_Jsonclick = "";
         subGridprodxbodega_tipo_Class = "Grid";
         subGridprodxbodega_tipo_Backcolorstyle = 0;
         edthraMovIng_Jsonclick = "";
         edtfchMovIng_Jsonclick = "";
         edtingBodTipoDoc_Jsonclick = "";
         edtingBodNroDoc_Jsonclick = "";
         edtingCantidad_Jsonclick = "";
         edtPrvDsc_Jsonclick = "";
         imgprompt_37_Visible = 1;
         imgprompt_37_Link = "";
         edtPrvRuc_Jsonclick = "";
         edtingTipoSigno_Jsonclick = "";
         edtingTipoInvMov_Jsonclick = "";
         imgprompt_383_Visible = 1;
         imgprompt_383_Link = "";
         imgprompt_1_42_Visible = 1;
         edtingTipoInv_Jsonclick = "";
         edtstockDetIngID_Jsonclick = "";
         subGrid1_Class = "Grid";
         subGrid1_Backcolorstyle = 0;
         subGridprodxbodega_tipo_Allowcollapsing = 0;
         subGridprodxbodega_tipo_Allowselection = 0;
         edtegrTipo_Enabled = 0;
         edtingTipo_Enabled = 0;
         edthraMovStock_Enabled = 0;
         edtfchMovStock_Enabled = 0;
         edtstockdetTipo_Enabled = 1;
         edtstockDetNroDoc_Enabled = 1;
         edtcostUni_Enabled = 0;
         edtcosto_Enabled = 0;
         edtstock_Enabled = 0;
         edtClienteDsc_Enabled = 0;
         edtClienteRUC_Enabled = 0;
         edtClienteID_Enabled = 0;
         edtcantidad_Enabled = 1;
         edtTipoInvSigno_Enabled = 0;
         edtTipoInvMov_Enabled = 0;
         edtTipoInv_Enabled = 1;
         edtstockDetID_Enabled = 1;
         subGridprodxbodega_tipo_Header = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edthraMovIng_Enabled = 0;
         edtfchMovIng_Enabled = 0;
         edtingBodTipoDoc_Enabled = 0;
         edtingBodNroDoc_Enabled = 0;
         edtingCantidad_Enabled = 1;
         edtPrvDsc_Enabled = 0;
         edtPrvRuc_Enabled = 1;
         edtingTipoSigno_Enabled = 0;
         edtingTipoInvMov_Enabled = 0;
         edtingTipoInv_Enabled = 1;
         edtstockDetIngID_Enabled = 1;
         subGrid1_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtstockBod_Jsonclick = "";
         edtstockBod_Enabled = 0;
         edtegrBod_Jsonclick = "";
         edtegrBod_Enabled = 0;
         edtingBod_Jsonclick = "";
         edtingBod_Enabled = 0;
         edtinvFisico_Jsonclick = "";
         edtinvFisico_Enabled = 1;
         edtprdStockDsc_Jsonclick = "";
         edtprdStockDsc_Enabled = 1;
         edtprdNombre_Jsonclick = "";
         edtprdNombre_Enabled = 0;
         imgprompt_1_2_286_Visible = 1;
         imgprompt_1_2_286_Link = "";
         edtPrdCod_Jsonclick = "";
         edtPrdCod_Enabled = 1;
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

      protected void GXDLAEMPID111( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAEMPID_data111( ) ;
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

      protected void GXAEMPID_html111( )
      {
         short gxdynajaxvalue ;
         GXDLAEMPID_data111( ) ;
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

      protected void GXDLAEMPID_data111( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T001166 */
         pr_default.execute(52);
         while ( (pr_default.getStatus(52) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T001166_A1EmpID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(T001166_A44empdsc[0]);
            pr_default.readNext(52);
         }
         pr_default.close(52);
      }

      protected void GXDLAAGEID1184( short AV9EmpID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAAGEID_data1184( AV9EmpID) ;
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

      protected void GXAAGEID_html1184( short AV9EmpID )
      {
         short gxdynajaxvalue ;
         GXDLAAGEID_data1184( AV9EmpID) ;
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

      protected void GXDLAAGEID_data1184( short AV9EmpID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T001167 */
         pr_default.execute(53, new Object[] {AV9EmpID});
         while ( (pr_default.getStatus(53) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T001167_A2AgeID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T001167_A46AgeDsc[0]));
            pr_default.readNext(53);
         }
         pr_default.close(53);
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_10989( ) ;
         while ( nGXsfl_109_idx <= nRC_GXsfl_109 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1189( ) ;
            standaloneModal1189( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow1189( ) ;
            nGXsfl_109_idx = (short)(nGXsfl_109_idx+1);
            sGXsfl_109_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_109_idx), 4, 0)), 4, "0");
            SubsflControlProps_10989( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxnrGridprodxbodega_tipo_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_12885( ) ;
         while ( nGXsfl_128_idx <= nRC_GXsfl_128 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1185( ) ;
            standaloneModal1185( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow1185( ) ;
            nGXsfl_128_idx = (short)(nGXsfl_128_idx+1);
            sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_128_idx), 4, 0)), 4, "0");
            SubsflControlProps_12885( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridprodxbodega_tipoContainer));
         /* End function gxnrGridprodxbodega_tipo_newrow */
      }

      protected void init_web_controls( )
      {
         dynEmpID.Name = "EMPID";
         dynEmpID.WebTags = "";
         dynEmpID.removeAllItems();
         /* Using cursor T001168 */
         pr_default.execute(54);
         while ( (pr_default.getStatus(54) != 101) )
         {
            dynEmpID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(T001168_A1EmpID[0]), 4, 0)), T001168_A44empdsc[0], 0);
            pr_default.readNext(54);
         }
         pr_default.close(54);
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

      public void Valid_Bodcod( GXCombobox dynGX_Parm1 ,
                                short GX_Parm2 ,
                                String GX_Parm3 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         A42BodCod = GX_Parm2;
         A217BodDsc = GX_Parm3;
         n217BodDsc = false;
         /* Using cursor T001138 */
         pr_default.execute(27, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(27) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
         }
         A217BodDsc = T001138_A217BodDsc[0];
         n217BodDsc = T001138_n217BodDsc[0];
         pr_default.close(27);
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

      public void Valid_Prdcod( GXCombobox dynGX_Parm1 ,
                                GXCombobox dynGX_Parm2 ,
                                short GX_Parm3 ,
                                short GX_Parm4 ,
                                GXCombobox cmbGX_Parm5 ,
                                short GX_Parm6 ,
                                String GX_Parm7 ,
                                short GX_Parm8 ,
                                decimal GX_Parm9 ,
                                decimal GX_Parm10 ,
                                decimal GX_Parm11 )
      {
         dynEmpID = dynGX_Parm1;
         A1EmpID = (short)(NumberUtil.Val( dynEmpID.CurrentValue, "."));
         dynAgeID = dynGX_Parm2;
         A2AgeID = (short)(NumberUtil.Val( dynAgeID.CurrentValue, "."));
         A286PrdCod = GX_Parm3;
         A290stockAnio = GX_Parm4;
         cmbstockMes = cmbGX_Parm5;
         A291stockMes = (short)(NumberUtil.Val( cmbstockMes.CurrentValue, "."));
         A42BodCod = GX_Parm6;
         A309prdNombre = GX_Parm7;
         n309prdNombre = false;
         A288PrdPres = GX_Parm8;
         n288PrdPres = false;
         A349totalStock = GX_Parm9;
         n349totalStock = false;
         A294ingBod = GX_Parm10;
         n294ingBod = false;
         A295egrBod = GX_Parm11;
         n295egrBod = false;
         /* Using cursor T001139 */
         pr_default.execute(28, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
         if ( (pr_default.getStatus(28) == 101) )
         {
            GX_msglist.addItem("No existe 'Productos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = dynEmpID_Internalname;
         }
         A309prdNombre = T001139_A309prdNombre[0];
         n309prdNombre = T001139_n309prdNombre[0];
         A288PrdPres = T001139_A288PrdPres[0];
         n288PrdPres = T001139_n288PrdPres[0];
         pr_default.close(28);
         /* Using cursor T001141 */
         pr_default.execute(29, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(29) != 101) )
         {
            A349totalStock = T001141_A349totalStock[0];
            n349totalStock = T001141_n349totalStock[0];
         }
         else
         {
            A349totalStock = 0;
            n349totalStock = false;
         }
         pr_default.close(29);
         /* Using cursor T001143 */
         pr_default.execute(30, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(30) != 101) )
         {
            A294ingBod = T001143_A294ingBod[0];
            n294ingBod = T001143_n294ingBod[0];
         }
         else
         {
            A294ingBod = 0;
            n294ingBod = false;
         }
         pr_default.close(30);
         /* Using cursor T001145 */
         pr_default.execute(31, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod, A286PrdCod});
         if ( (pr_default.getStatus(31) != 101) )
         {
            A295egrBod = T001145_A295egrBod[0];
            n295egrBod = T001145_n295egrBod[0];
         }
         else
         {
            A295egrBod = 0;
            n295egrBod = false;
         }
         pr_default.close(31);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A309prdNombre = "";
            n309prdNombre = false;
            A288PrdPres = 0;
            n288PrdPres = false;
            A349totalStock = 0;
            n349totalStock = false;
            A294ingBod = 0;
            n294ingBod = false;
            A295egrBod = 0;
            n295egrBod = false;
         }
         isValidOutput.Add(A309prdNombre);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A288PrdPres), 2, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A349totalStock, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A294ingBod, 9, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A295egrBod, 9, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Ingtipoinv( String GX_Parm1 ,
                                    String GX_Parm2 ,
                                    short GX_Parm3 )
      {
         A383ingTipoInv = GX_Parm1;
         A384ingTipoInvMov = GX_Parm2;
         n384ingTipoInvMov = false;
         A385ingTipoSigno = GX_Parm3;
         n385ingTipoSigno = false;
         /* Using cursor T001155 */
         pr_default.execute(41, new Object[] {A383ingTipoInv});
         if ( (pr_default.getStatus(41) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Movimiento Inv'.", "ForeignKeyNotFound", 1, "INGTIPOINV");
            AnyError = 1;
            GX_FocusControl = edtingTipoInv_Internalname;
         }
         A384ingTipoInvMov = T001155_A384ingTipoInvMov[0];
         n384ingTipoInvMov = T001155_n384ingTipoInvMov[0];
         A385ingTipoSigno = T001155_A385ingTipoSigno[0];
         n385ingTipoSigno = T001155_n385ingTipoSigno[0];
         pr_default.close(41);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A384ingTipoInvMov = "";
            n384ingTipoInvMov = false;
            A385ingTipoSigno = 0;
            n385ingTipoSigno = false;
         }
         isValidOutput.Add(A384ingTipoInvMov);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A385ingTipoSigno), 2, 0, ".", "")));
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
         /* Using cursor T001156 */
         pr_default.execute(42, new Object[] {A37PrvRuc});
         if ( (pr_default.getStatus(42) == 101) )
         {
            GX_msglist.addItem("No existe 'Proveedor'.", "ForeignKeyNotFound", 1, "PRVRUC");
            AnyError = 1;
            GX_FocusControl = edtPrvRuc_Internalname;
         }
         A184PrvDsc = T001156_A184PrvDsc[0];
         n184PrvDsc = T001156_n184PrvDsc[0];
         pr_default.close(42);
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

      public void Valid_Tipoinv( String GX_Parm1 ,
                                 String GX_Parm2 ,
                                 short GX_Parm3 )
      {
         A43TipoInv = GX_Parm1;
         A219TipoInvMov = GX_Parm2;
         n219TipoInvMov = false;
         A223TipoInvSigno = GX_Parm3;
         n223TipoInvSigno = false;
         /* Using cursor T001164 */
         pr_default.execute(50, new Object[] {A43TipoInv});
         if ( (pr_default.getStatus(50) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Movimiento'.", "ForeignKeyNotFound", 1, "TIPOINV");
            AnyError = 1;
            GX_FocusControl = edtTipoInv_Internalname;
         }
         A219TipoInvMov = T001164_A219TipoInvMov[0];
         n219TipoInvMov = T001164_n219TipoInvMov[0];
         A223TipoInvSigno = T001164_A223TipoInvSigno[0];
         n223TipoInvSigno = T001164_n223TipoInvSigno[0];
         pr_default.close(50);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A219TipoInvMov = "";
            n219TipoInvMov = false;
            A223TipoInvSigno = 0;
            n223TipoInvSigno = false;
         }
         isValidOutput.Add(A219TipoInvMov);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TipoInvSigno), 2, 0, ".", "")));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV15stockAnio',fld:'vSTOCKANIO',pic:'ZZZ9',hsh:true},{av:'AV16stockMes',fld:'vSTOCKMES',pic:'Z9',hsh:true},{av:'AV7AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV8BodCod',fld:'vBODCOD',pic:'ZZZ9',hsh:true},{av:'AV14PrdCod',fld:'vPRDCOD',pic:'ZZZ9',hsh:true},{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV15stockAnio',fld:'vSTOCKANIO',pic:'ZZZ9',hsh:true},{av:'AV16stockMes',fld:'vSTOCKMES',pic:'Z9',hsh:true},{av:'AV7AgeID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV8BodCod',fld:'vBODCOD',pic:'ZZZ9',hsh:true},{av:'AV14PrdCod',fld:'vPRDCOD',pic:'ZZZ9',hsh:true},{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]}");
         setEventMetadata("AFTER TRN","{handler:'E12112',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV18TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV9EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynAgeID'},{av:'A2AgeID',fld:'AGEID',pic:'ZZZ9'},{av:'dynEmpID'},{av:'A1EmpID',fld:'EMPID',pic:'ZZZ9'}]");
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
         pr_default.close(50);
         pr_default.close(5);
         pr_default.close(42);
         pr_default.close(41);
         pr_default.close(9);
         pr_default.close(27);
         pr_default.close(28);
         pr_default.close(29);
         pr_default.close(30);
         pr_default.close(31);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z307prdStockDsc = "";
         Z387fchMovIng = DateTime.MinValue;
         Z388hraMovIng = (DateTime)(DateTime.MinValue);
         Z391ingBodTipoDoc = "";
         Z37PrvRuc = "";
         Z383ingTipoInv = "";
         Z352stockdetTipo = "";
         Z374fchMovStock = DateTime.MinValue;
         Z375hraMovStock = (DateTime)(DateTime.MinValue);
         Z43TipoInv = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A383ingTipoInv = "";
         A37PrvRuc = "";
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
         A309prdNombre = "";
         A307prdStockDsc = "";
         lblTitletipo_Jsonclick = "";
         lblTabpageing_title_Jsonclick = "";
         lblTabpageegr_title_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         Grid1Column = new GXWebColumn();
         A384ingTipoInvMov = "";
         A184PrvDsc = "";
         A391ingBodTipoDoc = "";
         A387fchMovIng = DateTime.MinValue;
         A388hraMovIng = (DateTime)(DateTime.MinValue);
         sMode89 = "";
         sStyleString = "";
         Gridprodxbodega_tipoContainer = new GXWebGrid( context);
         Gridprodxbodega_tipoColumn = new GXWebColumn();
         A219TipoInvMov = "";
         A56ClienteRUC = "";
         A57ClienteDsc = "";
         A352stockdetTipo = "";
         A374fchMovStock = DateTime.MinValue;
         A375hraMovStock = (DateTime)(DateTime.MinValue);
         sMode85 = "";
         AV23Pgmname = "";
         Tabmovimientos_Objectcall = "";
         Tabmovimientos_Activepagecontrolname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode84 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV18TrnContext = new SdtTransactionContext(context);
         AV20WebSession = context.GetSession();
         Z217BodDsc = "";
         Z309prdNombre = "";
         T001112_A217BodDsc = new String[] {""} ;
         T001112_n217BodDsc = new bool[] {false} ;
         T001113_A309prdNombre = new String[] {""} ;
         T001113_n309prdNombre = new bool[] {false} ;
         T001113_A288PrdPres = new short[1] ;
         T001113_n288PrdPres = new bool[] {false} ;
         T001115_A349totalStock = new decimal[1] ;
         T001115_n349totalStock = new bool[] {false} ;
         T001117_A294ingBod = new decimal[1] ;
         T001117_n294ingBod = new bool[] {false} ;
         T001119_A295egrBod = new decimal[1] ;
         T001119_n295egrBod = new bool[] {false} ;
         T001123_A290stockAnio = new short[1] ;
         T001123_A291stockMes = new short[1] ;
         T001123_A217BodDsc = new String[] {""} ;
         T001123_n217BodDsc = new bool[] {false} ;
         T001123_A309prdNombre = new String[] {""} ;
         T001123_n309prdNombre = new bool[] {false} ;
         T001123_A288PrdPres = new short[1] ;
         T001123_n288PrdPres = new bool[] {false} ;
         T001123_A307prdStockDsc = new String[] {""} ;
         T001123_n307prdStockDsc = new bool[] {false} ;
         T001123_A293invFisico = new decimal[1] ;
         T001123_n293invFisico = new bool[] {false} ;
         T001123_A350stockUltNro = new short[1] ;
         T001123_n350stockUltNro = new bool[] {false} ;
         T001123_A1EmpID = new short[1] ;
         T001123_A2AgeID = new short[1] ;
         T001123_A42BodCod = new short[1] ;
         T001123_A286PrdCod = new short[1] ;
         T001123_A349totalStock = new decimal[1] ;
         T001123_n349totalStock = new bool[] {false} ;
         T001123_A294ingBod = new decimal[1] ;
         T001123_n294ingBod = new bool[] {false} ;
         T001123_A295egrBod = new decimal[1] ;
         T001123_n295egrBod = new bool[] {false} ;
         T001124_A217BodDsc = new String[] {""} ;
         T001124_n217BodDsc = new bool[] {false} ;
         T001125_A309prdNombre = new String[] {""} ;
         T001125_n309prdNombre = new bool[] {false} ;
         T001125_A288PrdPres = new short[1] ;
         T001125_n288PrdPres = new bool[] {false} ;
         T001127_A349totalStock = new decimal[1] ;
         T001127_n349totalStock = new bool[] {false} ;
         T001129_A294ingBod = new decimal[1] ;
         T001129_n294ingBod = new bool[] {false} ;
         T001131_A295egrBod = new decimal[1] ;
         T001131_n295egrBod = new bool[] {false} ;
         T001132_A290stockAnio = new short[1] ;
         T001132_A291stockMes = new short[1] ;
         T001132_A1EmpID = new short[1] ;
         T001132_A2AgeID = new short[1] ;
         T001132_A42BodCod = new short[1] ;
         T001132_A286PrdCod = new short[1] ;
         T001111_A290stockAnio = new short[1] ;
         T001111_A291stockMes = new short[1] ;
         T001111_A307prdStockDsc = new String[] {""} ;
         T001111_n307prdStockDsc = new bool[] {false} ;
         T001111_A293invFisico = new decimal[1] ;
         T001111_n293invFisico = new bool[] {false} ;
         T001111_A350stockUltNro = new short[1] ;
         T001111_n350stockUltNro = new bool[] {false} ;
         T001111_A1EmpID = new short[1] ;
         T001111_A2AgeID = new short[1] ;
         T001111_A42BodCod = new short[1] ;
         T001111_A286PrdCod = new short[1] ;
         T001133_A290stockAnio = new short[1] ;
         T001133_A291stockMes = new short[1] ;
         T001133_A1EmpID = new short[1] ;
         T001133_A2AgeID = new short[1] ;
         T001133_A42BodCod = new short[1] ;
         T001133_A286PrdCod = new short[1] ;
         T001134_A290stockAnio = new short[1] ;
         T001134_A291stockMes = new short[1] ;
         T001134_A1EmpID = new short[1] ;
         T001134_A2AgeID = new short[1] ;
         T001134_A42BodCod = new short[1] ;
         T001134_A286PrdCod = new short[1] ;
         T001110_A290stockAnio = new short[1] ;
         T001110_A291stockMes = new short[1] ;
         T001110_A307prdStockDsc = new String[] {""} ;
         T001110_n307prdStockDsc = new bool[] {false} ;
         T001110_A293invFisico = new decimal[1] ;
         T001110_n293invFisico = new bool[] {false} ;
         T001110_A350stockUltNro = new short[1] ;
         T001110_n350stockUltNro = new bool[] {false} ;
         T001110_A1EmpID = new short[1] ;
         T001110_A2AgeID = new short[1] ;
         T001110_A42BodCod = new short[1] ;
         T001110_A286PrdCod = new short[1] ;
         T001138_A217BodDsc = new String[] {""} ;
         T001138_n217BodDsc = new bool[] {false} ;
         T001139_A309prdNombre = new String[] {""} ;
         T001139_n309prdNombre = new bool[] {false} ;
         T001139_A288PrdPres = new short[1] ;
         T001139_n288PrdPres = new bool[] {false} ;
         T001141_A349totalStock = new decimal[1] ;
         T001141_n349totalStock = new bool[] {false} ;
         T001143_A294ingBod = new decimal[1] ;
         T001143_n294ingBod = new bool[] {false} ;
         T001145_A295egrBod = new decimal[1] ;
         T001145_n295egrBod = new bool[] {false} ;
         T001147_A290stockAnio = new short[1] ;
         T001147_A291stockMes = new short[1] ;
         T001147_A1EmpID = new short[1] ;
         T001147_A2AgeID = new short[1] ;
         T001147_A42BodCod = new short[1] ;
         T001147_A286PrdCod = new short[1] ;
         Z384ingTipoInvMov = "";
         Z184PrvDsc = "";
         T001148_A290stockAnio = new short[1] ;
         T001148_A291stockMes = new short[1] ;
         T001148_A2AgeID = new short[1] ;
         T001148_A42BodCod = new short[1] ;
         T001148_A286PrdCod = new short[1] ;
         T001148_A389stockDetIngID = new short[1] ;
         T001148_A384ingTipoInvMov = new String[] {""} ;
         T001148_n384ingTipoInvMov = new bool[] {false} ;
         T001148_A385ingTipoSigno = new short[1] ;
         T001148_n385ingTipoSigno = new bool[] {false} ;
         T001148_A386ingCantidad = new decimal[1] ;
         T001148_n386ingCantidad = new bool[] {false} ;
         T001148_A184PrvDsc = new String[] {""} ;
         T001148_n184PrvDsc = new bool[] {false} ;
         T001148_A387fchMovIng = new DateTime[] {DateTime.MinValue} ;
         T001148_n387fchMovIng = new bool[] {false} ;
         T001148_A388hraMovIng = new DateTime[] {DateTime.MinValue} ;
         T001148_n388hraMovIng = new bool[] {false} ;
         T001148_A390ingBodNroDoc = new short[1] ;
         T001148_n390ingBodNroDoc = new bool[] {false} ;
         T001148_A391ingBodTipoDoc = new String[] {""} ;
         T001148_n391ingBodTipoDoc = new bool[] {false} ;
         T001148_A37PrvRuc = new String[] {""} ;
         T001148_A383ingTipoInv = new String[] {""} ;
         T001148_A1EmpID = new short[1] ;
         T00119_A384ingTipoInvMov = new String[] {""} ;
         T00119_n384ingTipoInvMov = new bool[] {false} ;
         T00119_A385ingTipoSigno = new short[1] ;
         T00119_n385ingTipoSigno = new bool[] {false} ;
         T00118_A184PrvDsc = new String[] {""} ;
         T00118_n184PrvDsc = new bool[] {false} ;
         T001149_A384ingTipoInvMov = new String[] {""} ;
         T001149_n384ingTipoInvMov = new bool[] {false} ;
         T001149_A385ingTipoSigno = new short[1] ;
         T001149_n385ingTipoSigno = new bool[] {false} ;
         T001150_A184PrvDsc = new String[] {""} ;
         T001150_n184PrvDsc = new bool[] {false} ;
         T001151_A290stockAnio = new short[1] ;
         T001151_A291stockMes = new short[1] ;
         T001151_A1EmpID = new short[1] ;
         T001151_A2AgeID = new short[1] ;
         T001151_A42BodCod = new short[1] ;
         T001151_A286PrdCod = new short[1] ;
         T001151_A389stockDetIngID = new short[1] ;
         T00117_A290stockAnio = new short[1] ;
         T00117_A291stockMes = new short[1] ;
         T00117_A2AgeID = new short[1] ;
         T00117_A42BodCod = new short[1] ;
         T00117_A286PrdCod = new short[1] ;
         T00117_A389stockDetIngID = new short[1] ;
         T00117_A386ingCantidad = new decimal[1] ;
         T00117_n386ingCantidad = new bool[] {false} ;
         T00117_A387fchMovIng = new DateTime[] {DateTime.MinValue} ;
         T00117_n387fchMovIng = new bool[] {false} ;
         T00117_A388hraMovIng = new DateTime[] {DateTime.MinValue} ;
         T00117_n388hraMovIng = new bool[] {false} ;
         T00117_A390ingBodNroDoc = new short[1] ;
         T00117_n390ingBodNroDoc = new bool[] {false} ;
         T00117_A391ingBodTipoDoc = new String[] {""} ;
         T00117_n391ingBodTipoDoc = new bool[] {false} ;
         T00117_A37PrvRuc = new String[] {""} ;
         T00117_A383ingTipoInv = new String[] {""} ;
         T00117_A1EmpID = new short[1] ;
         T00116_A290stockAnio = new short[1] ;
         T00116_A291stockMes = new short[1] ;
         T00116_A2AgeID = new short[1] ;
         T00116_A42BodCod = new short[1] ;
         T00116_A286PrdCod = new short[1] ;
         T00116_A389stockDetIngID = new short[1] ;
         T00116_A386ingCantidad = new decimal[1] ;
         T00116_n386ingCantidad = new bool[] {false} ;
         T00116_A387fchMovIng = new DateTime[] {DateTime.MinValue} ;
         T00116_n387fchMovIng = new bool[] {false} ;
         T00116_A388hraMovIng = new DateTime[] {DateTime.MinValue} ;
         T00116_n388hraMovIng = new bool[] {false} ;
         T00116_A390ingBodNroDoc = new short[1] ;
         T00116_n390ingBodNroDoc = new bool[] {false} ;
         T00116_A391ingBodTipoDoc = new String[] {""} ;
         T00116_n391ingBodTipoDoc = new bool[] {false} ;
         T00116_A37PrvRuc = new String[] {""} ;
         T00116_A383ingTipoInv = new String[] {""} ;
         T00116_A1EmpID = new short[1] ;
         T001155_A384ingTipoInvMov = new String[] {""} ;
         T001155_n384ingTipoInvMov = new bool[] {false} ;
         T001155_A385ingTipoSigno = new short[1] ;
         T001155_n385ingTipoSigno = new bool[] {false} ;
         T001156_A184PrvDsc = new String[] {""} ;
         T001156_n184PrvDsc = new bool[] {false} ;
         T001157_A290stockAnio = new short[1] ;
         T001157_A291stockMes = new short[1] ;
         T001157_A1EmpID = new short[1] ;
         T001157_A2AgeID = new short[1] ;
         T001157_A42BodCod = new short[1] ;
         T001157_A286PrdCod = new short[1] ;
         T001157_A389stockDetIngID = new short[1] ;
         Z56ClienteRUC = "";
         Z57ClienteDsc = "";
         Z219TipoInvMov = "";
         T00114_A56ClienteRUC = new String[] {""} ;
         T00114_n56ClienteRUC = new bool[] {false} ;
         T00114_A57ClienteDsc = new String[] {""} ;
         T00114_n57ClienteDsc = new bool[] {false} ;
         T001158_A290stockAnio = new short[1] ;
         T001158_A291stockMes = new short[1] ;
         T001158_A2AgeID = new short[1] ;
         T001158_A42BodCod = new short[1] ;
         T001158_A286PrdCod = new short[1] ;
         T001158_A348stockDetID = new short[1] ;
         T001158_A219TipoInvMov = new String[] {""} ;
         T001158_n219TipoInvMov = new bool[] {false} ;
         T001158_A223TipoInvSigno = new short[1] ;
         T001158_n223TipoInvSigno = new bool[] {false} ;
         T001158_A296cantidad = new decimal[1] ;
         T001158_n296cantidad = new bool[] {false} ;
         T001158_A297stock = new decimal[1] ;
         T001158_n297stock = new bool[] {false} ;
         T001158_A351stockDetNroDoc = new short[1] ;
         T001158_n351stockDetNroDoc = new bool[] {false} ;
         T001158_A352stockdetTipo = new String[] {""} ;
         T001158_n352stockdetTipo = new bool[] {false} ;
         T001158_A56ClienteRUC = new String[] {""} ;
         T001158_n56ClienteRUC = new bool[] {false} ;
         T001158_A57ClienteDsc = new String[] {""} ;
         T001158_n57ClienteDsc = new bool[] {false} ;
         T001158_A298costo = new decimal[1] ;
         T001158_n298costo = new bool[] {false} ;
         T001158_A374fchMovStock = new DateTime[] {DateTime.MinValue} ;
         T001158_n374fchMovStock = new bool[] {false} ;
         T001158_A375hraMovStock = new DateTime[] {DateTime.MinValue} ;
         T001158_n375hraMovStock = new bool[] {false} ;
         T001158_A1EmpID = new short[1] ;
         T001158_A5ClienteID = new short[1] ;
         T001158_A43TipoInv = new String[] {""} ;
         T00115_A219TipoInvMov = new String[] {""} ;
         T00115_n219TipoInvMov = new bool[] {false} ;
         T00115_A223TipoInvSigno = new short[1] ;
         T00115_n223TipoInvSigno = new bool[] {false} ;
         T001159_A219TipoInvMov = new String[] {""} ;
         T001159_n219TipoInvMov = new bool[] {false} ;
         T001159_A223TipoInvSigno = new short[1] ;
         T001159_n223TipoInvSigno = new bool[] {false} ;
         T001160_A290stockAnio = new short[1] ;
         T001160_A291stockMes = new short[1] ;
         T001160_A1EmpID = new short[1] ;
         T001160_A2AgeID = new short[1] ;
         T001160_A42BodCod = new short[1] ;
         T001160_A286PrdCod = new short[1] ;
         T001160_A348stockDetID = new short[1] ;
         T00113_A290stockAnio = new short[1] ;
         T00113_A291stockMes = new short[1] ;
         T00113_A2AgeID = new short[1] ;
         T00113_A42BodCod = new short[1] ;
         T00113_A286PrdCod = new short[1] ;
         T00113_A348stockDetID = new short[1] ;
         T00113_A296cantidad = new decimal[1] ;
         T00113_n296cantidad = new bool[] {false} ;
         T00113_A297stock = new decimal[1] ;
         T00113_n297stock = new bool[] {false} ;
         T00113_A351stockDetNroDoc = new short[1] ;
         T00113_n351stockDetNroDoc = new bool[] {false} ;
         T00113_A352stockdetTipo = new String[] {""} ;
         T00113_n352stockdetTipo = new bool[] {false} ;
         T00113_A298costo = new decimal[1] ;
         T00113_n298costo = new bool[] {false} ;
         T00113_A374fchMovStock = new DateTime[] {DateTime.MinValue} ;
         T00113_n374fchMovStock = new bool[] {false} ;
         T00113_A375hraMovStock = new DateTime[] {DateTime.MinValue} ;
         T00113_n375hraMovStock = new bool[] {false} ;
         T00113_A1EmpID = new short[1] ;
         T00113_A5ClienteID = new short[1] ;
         T00113_A43TipoInv = new String[] {""} ;
         T00112_A290stockAnio = new short[1] ;
         T00112_A291stockMes = new short[1] ;
         T00112_A2AgeID = new short[1] ;
         T00112_A42BodCod = new short[1] ;
         T00112_A286PrdCod = new short[1] ;
         T00112_A348stockDetID = new short[1] ;
         T00112_A296cantidad = new decimal[1] ;
         T00112_n296cantidad = new bool[] {false} ;
         T00112_A297stock = new decimal[1] ;
         T00112_n297stock = new bool[] {false} ;
         T00112_A351stockDetNroDoc = new short[1] ;
         T00112_n351stockDetNroDoc = new bool[] {false} ;
         T00112_A352stockdetTipo = new String[] {""} ;
         T00112_n352stockdetTipo = new bool[] {false} ;
         T00112_A298costo = new decimal[1] ;
         T00112_n298costo = new bool[] {false} ;
         T00112_A374fchMovStock = new DateTime[] {DateTime.MinValue} ;
         T00112_n374fchMovStock = new bool[] {false} ;
         T00112_A375hraMovStock = new DateTime[] {DateTime.MinValue} ;
         T00112_n375hraMovStock = new bool[] {false} ;
         T00112_A1EmpID = new short[1] ;
         T00112_A5ClienteID = new short[1] ;
         T00112_A43TipoInv = new String[] {""} ;
         T001164_A219TipoInvMov = new String[] {""} ;
         T001164_n219TipoInvMov = new bool[] {false} ;
         T001164_A223TipoInvSigno = new short[1] ;
         T001164_n223TipoInvSigno = new bool[] {false} ;
         T001165_A290stockAnio = new short[1] ;
         T001165_A291stockMes = new short[1] ;
         T001165_A1EmpID = new short[1] ;
         T001165_A2AgeID = new short[1] ;
         T001165_A42BodCod = new short[1] ;
         T001165_A286PrdCod = new short[1] ;
         T001165_A348stockDetID = new short[1] ;
         Grid1Row = new GXWebRow();
         subGrid1_Linesclass = "";
         ROClassString = "";
         Gridprodxbodega_tipoRow = new GXWebRow();
         subGridprodxbodega_tipo_Linesclass = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T001166_A1EmpID = new short[1] ;
         T001166_A44empdsc = new String[] {""} ;
         T001166_n44empdsc = new bool[] {false} ;
         T001167_A1EmpID = new short[1] ;
         T001167_A2AgeID = new short[1] ;
         T001167_A46AgeDsc = new String[] {""} ;
         T001167_n46AgeDsc = new bool[] {false} ;
         T001168_A1EmpID = new short[1] ;
         T001168_A44empdsc = new String[] {""} ;
         T001168_n44empdsc = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prodstockbodega__default(),
            new Object[][] {
                new Object[] {
               T00112_A290stockAnio, T00112_A291stockMes, T00112_A2AgeID, T00112_A42BodCod, T00112_A286PrdCod, T00112_A348stockDetID, T00112_A296cantidad, T00112_n296cantidad, T00112_A297stock, T00112_n297stock,
               T00112_A351stockDetNroDoc, T00112_n351stockDetNroDoc, T00112_A352stockdetTipo, T00112_n352stockdetTipo, T00112_A298costo, T00112_n298costo, T00112_A374fchMovStock, T00112_n374fchMovStock, T00112_A375hraMovStock, T00112_n375hraMovStock,
               T00112_A1EmpID, T00112_A5ClienteID, T00112_A43TipoInv
               }
               , new Object[] {
               T00113_A290stockAnio, T00113_A291stockMes, T00113_A2AgeID, T00113_A42BodCod, T00113_A286PrdCod, T00113_A348stockDetID, T00113_A296cantidad, T00113_n296cantidad, T00113_A297stock, T00113_n297stock,
               T00113_A351stockDetNroDoc, T00113_n351stockDetNroDoc, T00113_A352stockdetTipo, T00113_n352stockdetTipo, T00113_A298costo, T00113_n298costo, T00113_A374fchMovStock, T00113_n374fchMovStock, T00113_A375hraMovStock, T00113_n375hraMovStock,
               T00113_A1EmpID, T00113_A5ClienteID, T00113_A43TipoInv
               }
               , new Object[] {
               T00114_A56ClienteRUC, T00114_n56ClienteRUC, T00114_A57ClienteDsc, T00114_n57ClienteDsc
               }
               , new Object[] {
               T00115_A219TipoInvMov, T00115_n219TipoInvMov, T00115_A223TipoInvSigno, T00115_n223TipoInvSigno
               }
               , new Object[] {
               T00116_A290stockAnio, T00116_A291stockMes, T00116_A2AgeID, T00116_A42BodCod, T00116_A286PrdCod, T00116_A389stockDetIngID, T00116_A386ingCantidad, T00116_n386ingCantidad, T00116_A387fchMovIng, T00116_n387fchMovIng,
               T00116_A388hraMovIng, T00116_n388hraMovIng, T00116_A390ingBodNroDoc, T00116_n390ingBodNroDoc, T00116_A391ingBodTipoDoc, T00116_n391ingBodTipoDoc, T00116_A37PrvRuc, T00116_A383ingTipoInv, T00116_A1EmpID
               }
               , new Object[] {
               T00117_A290stockAnio, T00117_A291stockMes, T00117_A2AgeID, T00117_A42BodCod, T00117_A286PrdCod, T00117_A389stockDetIngID, T00117_A386ingCantidad, T00117_n386ingCantidad, T00117_A387fchMovIng, T00117_n387fchMovIng,
               T00117_A388hraMovIng, T00117_n388hraMovIng, T00117_A390ingBodNroDoc, T00117_n390ingBodNroDoc, T00117_A391ingBodTipoDoc, T00117_n391ingBodTipoDoc, T00117_A37PrvRuc, T00117_A383ingTipoInv, T00117_A1EmpID
               }
               , new Object[] {
               T00118_A184PrvDsc, T00118_n184PrvDsc
               }
               , new Object[] {
               T00119_A384ingTipoInvMov, T00119_n384ingTipoInvMov, T00119_A385ingTipoSigno, T00119_n385ingTipoSigno
               }
               , new Object[] {
               T001110_A290stockAnio, T001110_A291stockMes, T001110_A307prdStockDsc, T001110_n307prdStockDsc, T001110_A293invFisico, T001110_n293invFisico, T001110_A350stockUltNro, T001110_n350stockUltNro, T001110_A1EmpID, T001110_A2AgeID,
               T001110_A42BodCod, T001110_A286PrdCod
               }
               , new Object[] {
               T001111_A290stockAnio, T001111_A291stockMes, T001111_A307prdStockDsc, T001111_n307prdStockDsc, T001111_A293invFisico, T001111_n293invFisico, T001111_A350stockUltNro, T001111_n350stockUltNro, T001111_A1EmpID, T001111_A2AgeID,
               T001111_A42BodCod, T001111_A286PrdCod
               }
               , new Object[] {
               T001112_A217BodDsc, T001112_n217BodDsc
               }
               , new Object[] {
               T001113_A309prdNombre, T001113_n309prdNombre, T001113_A288PrdPres, T001113_n288PrdPres
               }
               , new Object[] {
               T001115_A349totalStock, T001115_n349totalStock
               }
               , new Object[] {
               T001117_A294ingBod, T001117_n294ingBod
               }
               , new Object[] {
               T001119_A295egrBod, T001119_n295egrBod
               }
               , new Object[] {
               T001123_A290stockAnio, T001123_A291stockMes, T001123_A217BodDsc, T001123_n217BodDsc, T001123_A309prdNombre, T001123_n309prdNombre, T001123_A288PrdPres, T001123_n288PrdPres, T001123_A307prdStockDsc, T001123_n307prdStockDsc,
               T001123_A293invFisico, T001123_n293invFisico, T001123_A350stockUltNro, T001123_n350stockUltNro, T001123_A1EmpID, T001123_A2AgeID, T001123_A42BodCod, T001123_A286PrdCod, T001123_A349totalStock, T001123_n349totalStock,
               T001123_A294ingBod, T001123_n294ingBod, T001123_A295egrBod, T001123_n295egrBod
               }
               , new Object[] {
               T001124_A217BodDsc, T001124_n217BodDsc
               }
               , new Object[] {
               T001125_A309prdNombre, T001125_n309prdNombre, T001125_A288PrdPres, T001125_n288PrdPres
               }
               , new Object[] {
               T001127_A349totalStock, T001127_n349totalStock
               }
               , new Object[] {
               T001129_A294ingBod, T001129_n294ingBod
               }
               , new Object[] {
               T001131_A295egrBod, T001131_n295egrBod
               }
               , new Object[] {
               T001132_A290stockAnio, T001132_A291stockMes, T001132_A1EmpID, T001132_A2AgeID, T001132_A42BodCod, T001132_A286PrdCod
               }
               , new Object[] {
               T001133_A290stockAnio, T001133_A291stockMes, T001133_A1EmpID, T001133_A2AgeID, T001133_A42BodCod, T001133_A286PrdCod
               }
               , new Object[] {
               T001134_A290stockAnio, T001134_A291stockMes, T001134_A1EmpID, T001134_A2AgeID, T001134_A42BodCod, T001134_A286PrdCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001138_A217BodDsc, T001138_n217BodDsc
               }
               , new Object[] {
               T001139_A309prdNombre, T001139_n309prdNombre, T001139_A288PrdPres, T001139_n288PrdPres
               }
               , new Object[] {
               T001141_A349totalStock, T001141_n349totalStock
               }
               , new Object[] {
               T001143_A294ingBod, T001143_n294ingBod
               }
               , new Object[] {
               T001145_A295egrBod, T001145_n295egrBod
               }
               , new Object[] {
               }
               , new Object[] {
               T001147_A290stockAnio, T001147_A291stockMes, T001147_A1EmpID, T001147_A2AgeID, T001147_A42BodCod, T001147_A286PrdCod
               }
               , new Object[] {
               T001148_A290stockAnio, T001148_A291stockMes, T001148_A2AgeID, T001148_A42BodCod, T001148_A286PrdCod, T001148_A389stockDetIngID, T001148_A384ingTipoInvMov, T001148_n384ingTipoInvMov, T001148_A385ingTipoSigno, T001148_n385ingTipoSigno,
               T001148_A386ingCantidad, T001148_n386ingCantidad, T001148_A184PrvDsc, T001148_n184PrvDsc, T001148_A387fchMovIng, T001148_n387fchMovIng, T001148_A388hraMovIng, T001148_n388hraMovIng, T001148_A390ingBodNroDoc, T001148_n390ingBodNroDoc,
               T001148_A391ingBodTipoDoc, T001148_n391ingBodTipoDoc, T001148_A37PrvRuc, T001148_A383ingTipoInv, T001148_A1EmpID
               }
               , new Object[] {
               T001149_A384ingTipoInvMov, T001149_n384ingTipoInvMov, T001149_A385ingTipoSigno, T001149_n385ingTipoSigno
               }
               , new Object[] {
               T001150_A184PrvDsc, T001150_n184PrvDsc
               }
               , new Object[] {
               T001151_A290stockAnio, T001151_A291stockMes, T001151_A1EmpID, T001151_A2AgeID, T001151_A42BodCod, T001151_A286PrdCod, T001151_A389stockDetIngID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001155_A384ingTipoInvMov, T001155_n384ingTipoInvMov, T001155_A385ingTipoSigno, T001155_n385ingTipoSigno
               }
               , new Object[] {
               T001156_A184PrvDsc, T001156_n184PrvDsc
               }
               , new Object[] {
               T001157_A290stockAnio, T001157_A291stockMes, T001157_A1EmpID, T001157_A2AgeID, T001157_A42BodCod, T001157_A286PrdCod, T001157_A389stockDetIngID
               }
               , new Object[] {
               T001158_A290stockAnio, T001158_A291stockMes, T001158_A2AgeID, T001158_A42BodCod, T001158_A286PrdCod, T001158_A348stockDetID, T001158_A219TipoInvMov, T001158_n219TipoInvMov, T001158_A223TipoInvSigno, T001158_n223TipoInvSigno,
               T001158_A296cantidad, T001158_n296cantidad, T001158_A297stock, T001158_n297stock, T001158_A351stockDetNroDoc, T001158_n351stockDetNroDoc, T001158_A352stockdetTipo, T001158_n352stockdetTipo, T001158_A56ClienteRUC, T001158_n56ClienteRUC,
               T001158_A57ClienteDsc, T001158_n57ClienteDsc, T001158_A298costo, T001158_n298costo, T001158_A374fchMovStock, T001158_n374fchMovStock, T001158_A375hraMovStock, T001158_n375hraMovStock, T001158_A1EmpID, T001158_A5ClienteID,
               T001158_A43TipoInv
               }
               , new Object[] {
               T001159_A219TipoInvMov, T001159_n219TipoInvMov, T001159_A223TipoInvSigno, T001159_n223TipoInvSigno
               }
               , new Object[] {
               T001160_A290stockAnio, T001160_A291stockMes, T001160_A1EmpID, T001160_A2AgeID, T001160_A42BodCod, T001160_A286PrdCod, T001160_A348stockDetID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001164_A219TipoInvMov, T001164_n219TipoInvMov, T001164_A223TipoInvSigno, T001164_n223TipoInvSigno
               }
               , new Object[] {
               T001165_A290stockAnio, T001165_A291stockMes, T001165_A1EmpID, T001165_A2AgeID, T001165_A42BodCod, T001165_A286PrdCod, T001165_A348stockDetID
               }
               , new Object[] {
               T001166_A1EmpID, T001166_A44empdsc, T001166_n44empdsc
               }
               , new Object[] {
               T001167_A1EmpID, T001167_A2AgeID, T001167_A46AgeDsc, T001167_n46AgeDsc
               }
               , new Object[] {
               T001168_A1EmpID, T001168_A44empdsc, T001168_n44empdsc
               }
            }
         );
         AV23Pgmname = "ProdStockBodega";
      }

      private short nIsMod_89 ;
      private short nIsMod_85 ;
      private short wcpOAV15stockAnio ;
      private short wcpOAV16stockMes ;
      private short wcpOAV9EmpID ;
      private short wcpOAV7AgeID ;
      private short wcpOAV8BodCod ;
      private short wcpOAV14PrdCod ;
      private short Z290stockAnio ;
      private short Z291stockMes ;
      private short Z1EmpID ;
      private short Z2AgeID ;
      private short Z42BodCod ;
      private short Z286PrdCod ;
      private short Z350stockUltNro ;
      private short O350stockUltNro ;
      private short nRC_GXsfl_109 ;
      private short nGXsfl_109_idx=1 ;
      private short nRC_GXsfl_128 ;
      private short nGXsfl_128_idx=1 ;
      private short Z389stockDetIngID ;
      private short Z390ingBodNroDoc ;
      private short nRcdDeleted_89 ;
      private short nRcdExists_89 ;
      private short Z348stockDetID ;
      private short Z351stockDetNroDoc ;
      private short Z5ClienteID ;
      private short nRcdDeleted_85 ;
      private short nRcdExists_85 ;
      private short GxWebError ;
      private short AV9EmpID ;
      private short A1EmpID ;
      private short A42BodCod ;
      private short A2AgeID ;
      private short A286PrdCod ;
      private short A290stockAnio ;
      private short A291stockMes ;
      private short A350stockUltNro ;
      private short Gx_BScreen ;
      private short AV15stockAnio ;
      private short AV16stockMes ;
      private short AV7AgeID ;
      private short AV8BodCod ;
      private short AV14PrdCod ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short subGrid1_Backcolorstyle ;
      private short A389stockDetIngID ;
      private short A385ingTipoSigno ;
      private short A390ingBodNroDoc ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nBlankRcdCount89 ;
      private short RcdFound89 ;
      private short B350stockUltNro ;
      private short nBlankRcdUsr89 ;
      private short subGridprodxbodega_tipo_Backcolorstyle ;
      private short A348stockDetID ;
      private short A223TipoInvSigno ;
      private short A5ClienteID ;
      private short A351stockDetNroDoc ;
      private short subGridprodxbodega_tipo_Allowselection ;
      private short subGridprodxbodega_tipo_Allowhovering ;
      private short subGridprodxbodega_tipo_Allowcollapsing ;
      private short subGridprodxbodega_tipo_Collapsed ;
      private short nBlankRcdCount85 ;
      private short RcdFound85 ;
      private short nBlankRcdUsr85 ;
      private short AV21anio ;
      private short AV13mes ;
      private short A288PrdPres ;
      private short RcdFound84 ;
      private short s350stockUltNro ;
      private short GX_JID ;
      private short Z288PrdPres ;
      private short Z385ingTipoSigno ;
      private short Z223TipoInvSigno ;
      private short subGrid1_Backstyle ;
      private short subGridprodxbodega_tipo_Backstyle ;
      private short i350stockUltNro ;
      private short wbTemp ;
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
      private int edtPrdCod_Enabled ;
      private int imgprompt_1_2_286_Visible ;
      private int edtprdNombre_Enabled ;
      private int edtprdStockDsc_Enabled ;
      private int edtinvFisico_Enabled ;
      private int edtingBod_Enabled ;
      private int edtegrBod_Enabled ;
      private int edtstockBod_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtstockDetIngID_Enabled ;
      private int edtingTipoInv_Enabled ;
      private int edtingTipoInvMov_Enabled ;
      private int edtingTipoSigno_Enabled ;
      private int edtPrvRuc_Enabled ;
      private int edtPrvDsc_Enabled ;
      private int edtingCantidad_Enabled ;
      private int edtingBodNroDoc_Enabled ;
      private int edtingBodTipoDoc_Enabled ;
      private int edtfchMovIng_Enabled ;
      private int edthraMovIng_Enabled ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int fRowAdded ;
      private int edtstockDetID_Enabled ;
      private int edtTipoInv_Enabled ;
      private int edtTipoInvMov_Enabled ;
      private int edtTipoInvSigno_Enabled ;
      private int edtcantidad_Enabled ;
      private int edtClienteID_Enabled ;
      private int edtClienteRUC_Enabled ;
      private int edtClienteDsc_Enabled ;
      private int edtstock_Enabled ;
      private int edtcosto_Enabled ;
      private int edtcostUni_Enabled ;
      private int edtstockDetNroDoc_Enabled ;
      private int edtstockdetTipo_Enabled ;
      private int edtfchMovStock_Enabled ;
      private int edthraMovStock_Enabled ;
      private int edtingTipo_Enabled ;
      private int edtegrTipo_Enabled ;
      private int subGridprodxbodega_tipo_Selectedindex ;
      private int subGridprodxbodega_tipo_Selectioncolor ;
      private int subGridprodxbodega_tipo_Hoveringcolor ;
      private int Tabmovimientos_Activepage ;
      private int Tabmovimientos_Pagecount ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int imgprompt_383_Visible ;
      private int imgprompt_37_Visible ;
      private int subGridprodxbodega_tipo_Backcolor ;
      private int subGridprodxbodega_tipo_Allbackcolor ;
      private int imgprompt_43_Visible ;
      private int defedtegrTipo_Enabled ;
      private int defedthraMovStock_Enabled ;
      private int defedtfchMovStock_Enabled ;
      private int defedtcostUni_Enabled ;
      private int defedtcosto_Enabled ;
      private int defedtstock_Enabled ;
      private int defedtClienteDsc_Enabled ;
      private int defedtClienteRUC_Enabled ;
      private int defedtClienteID_Enabled ;
      private int defedtTipoInvSigno_Enabled ;
      private int defedtstockDetID_Enabled ;
      private int defedthraMovIng_Enabled ;
      private int defedtfchMovIng_Enabled ;
      private int defedtingBodTipoDoc_Enabled ;
      private int defedtingBodNroDoc_Enabled ;
      private int defedtingTipoSigno_Enabled ;
      private int defedtstockDetIngID_Enabled ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRIDPRODXBODEGA_TIPO_nFirstRecordOnPage ;
      private decimal Z293invFisico ;
      private decimal O295egrBod ;
      private decimal O349totalStock ;
      private decimal O294ingBod ;
      private decimal Z386ingCantidad ;
      private decimal O300ingTipo ;
      private decimal Z296cantidad ;
      private decimal Z297stock ;
      private decimal Z298costo ;
      private decimal O301egrTipo ;
      private decimal O297stock ;
      private decimal A293invFisico ;
      private decimal A294ingBod ;
      private decimal A295egrBod ;
      private decimal A292stockBod ;
      private decimal A386ingCantidad ;
      private decimal B295egrBod ;
      private decimal B349totalStock ;
      private decimal A349totalStock ;
      private decimal B294ingBod ;
      private decimal A296cantidad ;
      private decimal A297stock ;
      private decimal A298costo ;
      private decimal A299costUni ;
      private decimal A300ingTipo ;
      private decimal A301egrTipo ;
      private decimal s295egrBod ;
      private decimal s349totalStock ;
      private decimal s292stockBod ;
      private decimal O292stockBod ;
      private decimal T301egrTipo ;
      private decimal T297stock ;
      private decimal s294ingBod ;
      private decimal T300ingTipo ;
      private decimal Z349totalStock ;
      private decimal Z294ingBod ;
      private decimal Z295egrBod ;
      private decimal i349totalStock ;
      private String sPrefix ;
      private String sGXsfl_109_idx="0001" ;
      private String sGXsfl_128_idx="0001" ;
      private String wcpOGx_mode ;
      private String Z391ingBodTipoDoc ;
      private String Z37PrvRuc ;
      private String Z383ingTipoInv ;
      private String Z352stockdetTipo ;
      private String Z43TipoInv ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A383ingTipoInv ;
      private String A37PrvRuc ;
      private String A43TipoInv ;
      private String Gx_mode ;
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
      private String edtPrdCod_Internalname ;
      private String edtPrdCod_Jsonclick ;
      private String imgprompt_1_2_286_Internalname ;
      private String imgprompt_1_2_286_Link ;
      private String edtprdNombre_Internalname ;
      private String edtprdNombre_Jsonclick ;
      private String edtprdStockDsc_Internalname ;
      private String edtprdStockDsc_Jsonclick ;
      private String edtinvFisico_Internalname ;
      private String edtinvFisico_Jsonclick ;
      private String divSection5_Internalname ;
      private String edtingBod_Internalname ;
      private String edtingBod_Jsonclick ;
      private String divSection6_Internalname ;
      private String edtegrBod_Internalname ;
      private String edtegrBod_Jsonclick ;
      private String divSection7_Internalname ;
      private String edtstockBod_Internalname ;
      private String edtstockBod_Jsonclick ;
      private String divTipotable_Internalname ;
      private String lblTitletipo_Internalname ;
      private String lblTitletipo_Jsonclick ;
      private String lblTabpageing_title_Internalname ;
      private String lblTabpageing_title_Jsonclick ;
      private String divTabpage1table_Internalname ;
      private String lblTabpageegr_title_Internalname ;
      private String lblTabpageegr_title_Jsonclick ;
      private String divTabpage2table_Internalname ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGrid1_Header ;
      private String A391ingBodTipoDoc ;
      private String sMode89 ;
      private String edtstockDetIngID_Internalname ;
      private String edtingTipoInv_Internalname ;
      private String edtingTipoInvMov_Internalname ;
      private String edtingTipoSigno_Internalname ;
      private String edtPrvRuc_Internalname ;
      private String edtPrvDsc_Internalname ;
      private String edtingCantidad_Internalname ;
      private String edtingBodNroDoc_Internalname ;
      private String edtingBodTipoDoc_Internalname ;
      private String edtfchMovIng_Internalname ;
      private String edthraMovIng_Internalname ;
      private String sStyleString ;
      private String subGridprodxbodega_tipo_Header ;
      private String A56ClienteRUC ;
      private String A57ClienteDsc ;
      private String A352stockdetTipo ;
      private String sMode85 ;
      private String edtstockDetID_Internalname ;
      private String edtTipoInv_Internalname ;
      private String edtTipoInvMov_Internalname ;
      private String edtTipoInvSigno_Internalname ;
      private String edtcantidad_Internalname ;
      private String edtClienteID_Internalname ;
      private String edtClienteRUC_Internalname ;
      private String edtClienteDsc_Internalname ;
      private String edtstock_Internalname ;
      private String edtcosto_Internalname ;
      private String edtcostUni_Internalname ;
      private String edtstockDetNroDoc_Internalname ;
      private String edtstockdetTipo_Internalname ;
      private String edtfchMovStock_Internalname ;
      private String edthraMovStock_Internalname ;
      private String edtingTipo_Internalname ;
      private String edtegrTipo_Internalname ;
      private String AV23Pgmname ;
      private String Tabmovimientos_Objectcall ;
      private String Tabmovimientos_Class ;
      private String Tabmovimientos_Activepagecontrolname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode84 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z217BodDsc ;
      private String Z56ClienteRUC ;
      private String Z57ClienteDsc ;
      private String imgprompt_383_Internalname ;
      private String imgprompt_37_Internalname ;
      private String sGXsfl_109_fel_idx="0001" ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String imgprompt_383_Link ;
      private String imgprompt_37_Link ;
      private String ROClassString ;
      private String edtstockDetIngID_Jsonclick ;
      private String edtingTipoInv_Jsonclick ;
      private String edtingTipoInvMov_Jsonclick ;
      private String edtingTipoSigno_Jsonclick ;
      private String edtPrvRuc_Jsonclick ;
      private String edtPrvDsc_Jsonclick ;
      private String edtingCantidad_Jsonclick ;
      private String edtingBodNroDoc_Jsonclick ;
      private String edtingBodTipoDoc_Jsonclick ;
      private String edtfchMovIng_Jsonclick ;
      private String edthraMovIng_Jsonclick ;
      private String imgprompt_43_Internalname ;
      private String sGXsfl_128_fel_idx="0001" ;
      private String subGridprodxbodega_tipo_Class ;
      private String subGridprodxbodega_tipo_Linesclass ;
      private String imgprompt_43_Link ;
      private String edtstockDetID_Jsonclick ;
      private String edtTipoInv_Jsonclick ;
      private String edtTipoInvMov_Jsonclick ;
      private String edtTipoInvSigno_Jsonclick ;
      private String edtcantidad_Jsonclick ;
      private String edtClienteID_Jsonclick ;
      private String edtClienteRUC_Jsonclick ;
      private String edtClienteDsc_Jsonclick ;
      private String edtstock_Jsonclick ;
      private String edtcosto_Jsonclick ;
      private String edtcostUni_Jsonclick ;
      private String edtstockDetNroDoc_Jsonclick ;
      private String edtstockdetTipo_Jsonclick ;
      private String edtfchMovStock_Jsonclick ;
      private String edthraMovStock_Jsonclick ;
      private String edtingTipo_Jsonclick ;
      private String edtegrTipo_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Tabmovimientos_Internalname ;
      private String subGrid1_Internalname ;
      private String subGridprodxbodega_tipo_Internalname ;
      private String gxwrpcisep ;
      private DateTime Z388hraMovIng ;
      private DateTime Z375hraMovStock ;
      private DateTime A388hraMovIng ;
      private DateTime A375hraMovStock ;
      private DateTime Z387fchMovIng ;
      private DateTime Z374fchMovStock ;
      private DateTime A387fchMovIng ;
      private DateTime A374fchMovStock ;
      private bool entryPointCalled ;
      private bool n350stockUltNro ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n295egrBod ;
      private bool n349totalStock ;
      private bool n294ingBod ;
      private bool bGXsfl_109_Refreshing=false ;
      private bool bGXsfl_128_Refreshing=false ;
      private bool n217BodDsc ;
      private bool n309prdNombre ;
      private bool n307prdStockDsc ;
      private bool n293invFisico ;
      private bool n288PrdPres ;
      private bool Tabmovimientos_Enabled ;
      private bool Tabmovimientos_Historymanagement ;
      private bool Tabmovimientos_Visible ;
      private bool returnInSub ;
      private bool n384ingTipoInvMov ;
      private bool n385ingTipoSigno ;
      private bool n386ingCantidad ;
      private bool n184PrvDsc ;
      private bool n387fchMovIng ;
      private bool n388hraMovIng ;
      private bool n390ingBodNroDoc ;
      private bool n391ingBodTipoDoc ;
      private bool Gx_longc ;
      private bool n56ClienteRUC ;
      private bool n57ClienteDsc ;
      private bool n219TipoInvMov ;
      private bool n223TipoInvSigno ;
      private bool n296cantidad ;
      private bool n297stock ;
      private bool n351stockDetNroDoc ;
      private bool n352stockdetTipo ;
      private bool n298costo ;
      private bool n374fchMovStock ;
      private bool n375hraMovStock ;
      private bool gxdyncontrolsrefreshing ;
      private String Z307prdStockDsc ;
      private String A309prdNombre ;
      private String A307prdStockDsc ;
      private String A384ingTipoInvMov ;
      private String A184PrvDsc ;
      private String A219TipoInvMov ;
      private String Z309prdNombre ;
      private String Z384ingTipoInvMov ;
      private String Z184PrvDsc ;
      private String Z219TipoInvMov ;
      private IGxSession AV20WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Grid1Container ;
      private GXWebGrid Gridprodxbodega_tipoContainer ;
      private GXWebRow Grid1Row ;
      private GXWebRow Gridprodxbodega_tipoRow ;
      private GXWebColumn Grid1Column ;
      private GXWebColumn Gridprodxbodega_tipoColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynEmpID ;
      private GXCombobox dynAgeID ;
      private GXCombobox cmbstockMes ;
      private IDataStoreProvider pr_default ;
      private String[] T001112_A217BodDsc ;
      private bool[] T001112_n217BodDsc ;
      private String[] T001113_A309prdNombre ;
      private bool[] T001113_n309prdNombre ;
      private short[] T001113_A288PrdPres ;
      private bool[] T001113_n288PrdPres ;
      private decimal[] T001115_A349totalStock ;
      private bool[] T001115_n349totalStock ;
      private decimal[] T001117_A294ingBod ;
      private bool[] T001117_n294ingBod ;
      private decimal[] T001119_A295egrBod ;
      private bool[] T001119_n295egrBod ;
      private short[] T001123_A290stockAnio ;
      private short[] T001123_A291stockMes ;
      private String[] T001123_A217BodDsc ;
      private bool[] T001123_n217BodDsc ;
      private String[] T001123_A309prdNombre ;
      private bool[] T001123_n309prdNombre ;
      private short[] T001123_A288PrdPres ;
      private bool[] T001123_n288PrdPres ;
      private String[] T001123_A307prdStockDsc ;
      private bool[] T001123_n307prdStockDsc ;
      private decimal[] T001123_A293invFisico ;
      private bool[] T001123_n293invFisico ;
      private short[] T001123_A350stockUltNro ;
      private bool[] T001123_n350stockUltNro ;
      private short[] T001123_A1EmpID ;
      private short[] T001123_A2AgeID ;
      private short[] T001123_A42BodCod ;
      private short[] T001123_A286PrdCod ;
      private decimal[] T001123_A349totalStock ;
      private bool[] T001123_n349totalStock ;
      private decimal[] T001123_A294ingBod ;
      private bool[] T001123_n294ingBod ;
      private decimal[] T001123_A295egrBod ;
      private bool[] T001123_n295egrBod ;
      private String[] T001124_A217BodDsc ;
      private bool[] T001124_n217BodDsc ;
      private String[] T001125_A309prdNombre ;
      private bool[] T001125_n309prdNombre ;
      private short[] T001125_A288PrdPres ;
      private bool[] T001125_n288PrdPres ;
      private decimal[] T001127_A349totalStock ;
      private bool[] T001127_n349totalStock ;
      private decimal[] T001129_A294ingBod ;
      private bool[] T001129_n294ingBod ;
      private decimal[] T001131_A295egrBod ;
      private bool[] T001131_n295egrBod ;
      private short[] T001132_A290stockAnio ;
      private short[] T001132_A291stockMes ;
      private short[] T001132_A1EmpID ;
      private short[] T001132_A2AgeID ;
      private short[] T001132_A42BodCod ;
      private short[] T001132_A286PrdCod ;
      private short[] T001111_A290stockAnio ;
      private short[] T001111_A291stockMes ;
      private String[] T001111_A307prdStockDsc ;
      private bool[] T001111_n307prdStockDsc ;
      private decimal[] T001111_A293invFisico ;
      private bool[] T001111_n293invFisico ;
      private short[] T001111_A350stockUltNro ;
      private bool[] T001111_n350stockUltNro ;
      private short[] T001111_A1EmpID ;
      private short[] T001111_A2AgeID ;
      private short[] T001111_A42BodCod ;
      private short[] T001111_A286PrdCod ;
      private short[] T001133_A290stockAnio ;
      private short[] T001133_A291stockMes ;
      private short[] T001133_A1EmpID ;
      private short[] T001133_A2AgeID ;
      private short[] T001133_A42BodCod ;
      private short[] T001133_A286PrdCod ;
      private short[] T001134_A290stockAnio ;
      private short[] T001134_A291stockMes ;
      private short[] T001134_A1EmpID ;
      private short[] T001134_A2AgeID ;
      private short[] T001134_A42BodCod ;
      private short[] T001134_A286PrdCod ;
      private short[] T001110_A290stockAnio ;
      private short[] T001110_A291stockMes ;
      private String[] T001110_A307prdStockDsc ;
      private bool[] T001110_n307prdStockDsc ;
      private decimal[] T001110_A293invFisico ;
      private bool[] T001110_n293invFisico ;
      private short[] T001110_A350stockUltNro ;
      private bool[] T001110_n350stockUltNro ;
      private short[] T001110_A1EmpID ;
      private short[] T001110_A2AgeID ;
      private short[] T001110_A42BodCod ;
      private short[] T001110_A286PrdCod ;
      private String[] T001138_A217BodDsc ;
      private bool[] T001138_n217BodDsc ;
      private String[] T001139_A309prdNombre ;
      private bool[] T001139_n309prdNombre ;
      private short[] T001139_A288PrdPres ;
      private bool[] T001139_n288PrdPres ;
      private decimal[] T001141_A349totalStock ;
      private bool[] T001141_n349totalStock ;
      private decimal[] T001143_A294ingBod ;
      private bool[] T001143_n294ingBod ;
      private decimal[] T001145_A295egrBod ;
      private bool[] T001145_n295egrBod ;
      private short[] T001147_A290stockAnio ;
      private short[] T001147_A291stockMes ;
      private short[] T001147_A1EmpID ;
      private short[] T001147_A2AgeID ;
      private short[] T001147_A42BodCod ;
      private short[] T001147_A286PrdCod ;
      private short[] T001148_A290stockAnio ;
      private short[] T001148_A291stockMes ;
      private short[] T001148_A2AgeID ;
      private short[] T001148_A42BodCod ;
      private short[] T001148_A286PrdCod ;
      private short[] T001148_A389stockDetIngID ;
      private String[] T001148_A384ingTipoInvMov ;
      private bool[] T001148_n384ingTipoInvMov ;
      private short[] T001148_A385ingTipoSigno ;
      private bool[] T001148_n385ingTipoSigno ;
      private decimal[] T001148_A386ingCantidad ;
      private bool[] T001148_n386ingCantidad ;
      private String[] T001148_A184PrvDsc ;
      private bool[] T001148_n184PrvDsc ;
      private DateTime[] T001148_A387fchMovIng ;
      private bool[] T001148_n387fchMovIng ;
      private DateTime[] T001148_A388hraMovIng ;
      private bool[] T001148_n388hraMovIng ;
      private short[] T001148_A390ingBodNroDoc ;
      private bool[] T001148_n390ingBodNroDoc ;
      private String[] T001148_A391ingBodTipoDoc ;
      private bool[] T001148_n391ingBodTipoDoc ;
      private String[] T001148_A37PrvRuc ;
      private String[] T001148_A383ingTipoInv ;
      private short[] T001148_A1EmpID ;
      private String[] T00119_A384ingTipoInvMov ;
      private bool[] T00119_n384ingTipoInvMov ;
      private short[] T00119_A385ingTipoSigno ;
      private bool[] T00119_n385ingTipoSigno ;
      private String[] T00118_A184PrvDsc ;
      private bool[] T00118_n184PrvDsc ;
      private String[] T001149_A384ingTipoInvMov ;
      private bool[] T001149_n384ingTipoInvMov ;
      private short[] T001149_A385ingTipoSigno ;
      private bool[] T001149_n385ingTipoSigno ;
      private String[] T001150_A184PrvDsc ;
      private bool[] T001150_n184PrvDsc ;
      private short[] T001151_A290stockAnio ;
      private short[] T001151_A291stockMes ;
      private short[] T001151_A1EmpID ;
      private short[] T001151_A2AgeID ;
      private short[] T001151_A42BodCod ;
      private short[] T001151_A286PrdCod ;
      private short[] T001151_A389stockDetIngID ;
      private short[] T00117_A290stockAnio ;
      private short[] T00117_A291stockMes ;
      private short[] T00117_A2AgeID ;
      private short[] T00117_A42BodCod ;
      private short[] T00117_A286PrdCod ;
      private short[] T00117_A389stockDetIngID ;
      private decimal[] T00117_A386ingCantidad ;
      private bool[] T00117_n386ingCantidad ;
      private DateTime[] T00117_A387fchMovIng ;
      private bool[] T00117_n387fchMovIng ;
      private DateTime[] T00117_A388hraMovIng ;
      private bool[] T00117_n388hraMovIng ;
      private short[] T00117_A390ingBodNroDoc ;
      private bool[] T00117_n390ingBodNroDoc ;
      private String[] T00117_A391ingBodTipoDoc ;
      private bool[] T00117_n391ingBodTipoDoc ;
      private String[] T00117_A37PrvRuc ;
      private String[] T00117_A383ingTipoInv ;
      private short[] T00117_A1EmpID ;
      private short[] T00116_A290stockAnio ;
      private short[] T00116_A291stockMes ;
      private short[] T00116_A2AgeID ;
      private short[] T00116_A42BodCod ;
      private short[] T00116_A286PrdCod ;
      private short[] T00116_A389stockDetIngID ;
      private decimal[] T00116_A386ingCantidad ;
      private bool[] T00116_n386ingCantidad ;
      private DateTime[] T00116_A387fchMovIng ;
      private bool[] T00116_n387fchMovIng ;
      private DateTime[] T00116_A388hraMovIng ;
      private bool[] T00116_n388hraMovIng ;
      private short[] T00116_A390ingBodNroDoc ;
      private bool[] T00116_n390ingBodNroDoc ;
      private String[] T00116_A391ingBodTipoDoc ;
      private bool[] T00116_n391ingBodTipoDoc ;
      private String[] T00116_A37PrvRuc ;
      private String[] T00116_A383ingTipoInv ;
      private short[] T00116_A1EmpID ;
      private String[] T001155_A384ingTipoInvMov ;
      private bool[] T001155_n384ingTipoInvMov ;
      private short[] T001155_A385ingTipoSigno ;
      private bool[] T001155_n385ingTipoSigno ;
      private String[] T001156_A184PrvDsc ;
      private bool[] T001156_n184PrvDsc ;
      private short[] T001157_A290stockAnio ;
      private short[] T001157_A291stockMes ;
      private short[] T001157_A1EmpID ;
      private short[] T001157_A2AgeID ;
      private short[] T001157_A42BodCod ;
      private short[] T001157_A286PrdCod ;
      private short[] T001157_A389stockDetIngID ;
      private String[] T00114_A56ClienteRUC ;
      private bool[] T00114_n56ClienteRUC ;
      private String[] T00114_A57ClienteDsc ;
      private bool[] T00114_n57ClienteDsc ;
      private short[] T001158_A290stockAnio ;
      private short[] T001158_A291stockMes ;
      private short[] T001158_A2AgeID ;
      private short[] T001158_A42BodCod ;
      private short[] T001158_A286PrdCod ;
      private short[] T001158_A348stockDetID ;
      private String[] T001158_A219TipoInvMov ;
      private bool[] T001158_n219TipoInvMov ;
      private short[] T001158_A223TipoInvSigno ;
      private bool[] T001158_n223TipoInvSigno ;
      private decimal[] T001158_A296cantidad ;
      private bool[] T001158_n296cantidad ;
      private decimal[] T001158_A297stock ;
      private bool[] T001158_n297stock ;
      private short[] T001158_A351stockDetNroDoc ;
      private bool[] T001158_n351stockDetNroDoc ;
      private String[] T001158_A352stockdetTipo ;
      private bool[] T001158_n352stockdetTipo ;
      private String[] T001158_A56ClienteRUC ;
      private bool[] T001158_n56ClienteRUC ;
      private String[] T001158_A57ClienteDsc ;
      private bool[] T001158_n57ClienteDsc ;
      private decimal[] T001158_A298costo ;
      private bool[] T001158_n298costo ;
      private DateTime[] T001158_A374fchMovStock ;
      private bool[] T001158_n374fchMovStock ;
      private DateTime[] T001158_A375hraMovStock ;
      private bool[] T001158_n375hraMovStock ;
      private short[] T001158_A1EmpID ;
      private short[] T001158_A5ClienteID ;
      private String[] T001158_A43TipoInv ;
      private String[] T00115_A219TipoInvMov ;
      private bool[] T00115_n219TipoInvMov ;
      private short[] T00115_A223TipoInvSigno ;
      private bool[] T00115_n223TipoInvSigno ;
      private String[] T001159_A219TipoInvMov ;
      private bool[] T001159_n219TipoInvMov ;
      private short[] T001159_A223TipoInvSigno ;
      private bool[] T001159_n223TipoInvSigno ;
      private short[] T001160_A290stockAnio ;
      private short[] T001160_A291stockMes ;
      private short[] T001160_A1EmpID ;
      private short[] T001160_A2AgeID ;
      private short[] T001160_A42BodCod ;
      private short[] T001160_A286PrdCod ;
      private short[] T001160_A348stockDetID ;
      private short[] T00113_A290stockAnio ;
      private short[] T00113_A291stockMes ;
      private short[] T00113_A2AgeID ;
      private short[] T00113_A42BodCod ;
      private short[] T00113_A286PrdCod ;
      private short[] T00113_A348stockDetID ;
      private decimal[] T00113_A296cantidad ;
      private bool[] T00113_n296cantidad ;
      private decimal[] T00113_A297stock ;
      private bool[] T00113_n297stock ;
      private short[] T00113_A351stockDetNroDoc ;
      private bool[] T00113_n351stockDetNroDoc ;
      private String[] T00113_A352stockdetTipo ;
      private bool[] T00113_n352stockdetTipo ;
      private decimal[] T00113_A298costo ;
      private bool[] T00113_n298costo ;
      private DateTime[] T00113_A374fchMovStock ;
      private bool[] T00113_n374fchMovStock ;
      private DateTime[] T00113_A375hraMovStock ;
      private bool[] T00113_n375hraMovStock ;
      private short[] T00113_A1EmpID ;
      private short[] T00113_A5ClienteID ;
      private String[] T00113_A43TipoInv ;
      private short[] T00112_A290stockAnio ;
      private short[] T00112_A291stockMes ;
      private short[] T00112_A2AgeID ;
      private short[] T00112_A42BodCod ;
      private short[] T00112_A286PrdCod ;
      private short[] T00112_A348stockDetID ;
      private decimal[] T00112_A296cantidad ;
      private bool[] T00112_n296cantidad ;
      private decimal[] T00112_A297stock ;
      private bool[] T00112_n297stock ;
      private short[] T00112_A351stockDetNroDoc ;
      private bool[] T00112_n351stockDetNroDoc ;
      private String[] T00112_A352stockdetTipo ;
      private bool[] T00112_n352stockdetTipo ;
      private decimal[] T00112_A298costo ;
      private bool[] T00112_n298costo ;
      private DateTime[] T00112_A374fchMovStock ;
      private bool[] T00112_n374fchMovStock ;
      private DateTime[] T00112_A375hraMovStock ;
      private bool[] T00112_n375hraMovStock ;
      private short[] T00112_A1EmpID ;
      private short[] T00112_A5ClienteID ;
      private String[] T00112_A43TipoInv ;
      private String[] T001164_A219TipoInvMov ;
      private bool[] T001164_n219TipoInvMov ;
      private short[] T001164_A223TipoInvSigno ;
      private bool[] T001164_n223TipoInvSigno ;
      private short[] T001165_A290stockAnio ;
      private short[] T001165_A291stockMes ;
      private short[] T001165_A1EmpID ;
      private short[] T001165_A2AgeID ;
      private short[] T001165_A42BodCod ;
      private short[] T001165_A286PrdCod ;
      private short[] T001165_A348stockDetID ;
      private short[] T001166_A1EmpID ;
      private String[] T001166_A44empdsc ;
      private bool[] T001166_n44empdsc ;
      private short[] T001167_A1EmpID ;
      private short[] T001167_A2AgeID ;
      private String[] T001167_A46AgeDsc ;
      private bool[] T001167_n46AgeDsc ;
      private short[] T001168_A1EmpID ;
      private String[] T001168_A44empdsc ;
      private bool[] T001168_n44empdsc ;
      private SdtTransactionContext AV18TrnContext ;
   }

   public class prodstockbodega__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new UpdateCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new UpdateCursor(def[32])
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new ForEachCursor(def[35])
         ,new ForEachCursor(def[36])
         ,new ForEachCursor(def[37])
         ,new UpdateCursor(def[38])
         ,new UpdateCursor(def[39])
         ,new UpdateCursor(def[40])
         ,new ForEachCursor(def[41])
         ,new ForEachCursor(def[42])
         ,new ForEachCursor(def[43])
         ,new ForEachCursor(def[44])
         ,new ForEachCursor(def[45])
         ,new ForEachCursor(def[46])
         ,new UpdateCursor(def[47])
         ,new UpdateCursor(def[48])
         ,new UpdateCursor(def[49])
         ,new ForEachCursor(def[50])
         ,new ForEachCursor(def[51])
         ,new ForEachCursor(def[52])
         ,new ForEachCursor(def[53])
         ,new ForEachCursor(def[54])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001123 ;
          prmT001123 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          String cmdBufferT001123 ;
          cmdBufferT001123=" SELECT TM1.[stockAnio], TM1.[stockMes], T2.[BodDsc], T3.[prdNombre], T3.[PrdPres], TM1.[prdStockDsc], TM1.[invFisico], TM1.[stockUltNro], TM1.[EmpID], TM1.[AgeID], TM1.[BodCod], TM1.[PrdCod], COALESCE( T4.[totalStock], 0) AS totalStock, COALESCE( T5.[ingBod], 0) AS ingBod, COALESCE( T6.[egrBod], 0) AS egrBod FROM ((((([ProdxBodega] TM1 WITH (NOLOCK) INNER JOIN [Bodegas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID] AND T2.[BodCod] = TM1.[BodCod]) INNER JOIN [Productos] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[AgeID] = TM1.[AgeID] AND T3.[PrdCod] = TM1.[PrdCod]) LEFT JOIN (SELECT SUM([stock]) AS totalStock, [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodegaTipoInv] WITH (NOLOCK) GROUP BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] ) T4 ON T4.[stockAnio] = TM1.[stockAnio] AND T4.[stockMes] = TM1.[stockMes] AND T4.[EmpID] = TM1.[EmpID] AND T4.[AgeID] = TM1.[AgeID] AND T4.[BodCod] = TM1.[BodCod] AND T4.[PrdCod] = TM1.[PrdCod]) LEFT JOIN (SELECT SUM(CASE  WHEN COALESCE( T8.[TipoInvSigno], 0) = 1 THEN COALESCE( T7.[ingCantidad], 0) ELSE 0 END) AS ingBod, T7.[stockAnio], T7.[stockMes], T7.[EmpID], T7.[AgeID], T7.[BodCod], T7.[PrdCod] FROM ([ProdStockBodegastockDetEgr] T7 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T8 WITH (NOLOCK) ON T8.[TipoInv] = T7.[ingTipoInv]) GROUP BY T7.[stockAnio], T7.[stockMes], T7.[EmpID], T7.[AgeID], T7.[BodCod], T7.[PrdCod] ) T5 ON T5.[stockAnio] = TM1.[stockAnio] AND T5.[stockMes] = TM1.[stockMes] AND T5.[EmpID] = TM1.[EmpID] AND T5.[AgeID] = TM1.[AgeID] AND T5.[BodCod] = TM1.[BodCod] AND T5.[PrdCod] = TM1.[PrdCod]) LEFT JOIN (SELECT SUM(CASE  WHEN COALESCE( T8.[TipoInvSigno], 0) = -1 THEN COALESCE( T7.[cantidad], 0) ELSE 0 END) AS egrBod, T7.[stockAnio], T7.[stockMes], T7.[EmpID], T7.[AgeID], "
          + " T7.[BodCod], T7.[PrdCod] FROM ([ProdxBodegaTipoInv] T7 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T8 WITH (NOLOCK) ON T8.[TipoInv] = T7.[TipoInv]) GROUP BY T7.[stockAnio], T7.[stockMes], T7.[EmpID], T7.[AgeID], T7.[BodCod], T7.[PrdCod] ) T6 ON T6.[stockAnio] = TM1.[stockAnio] AND T6.[stockMes] = TM1.[stockMes] AND T6.[EmpID] = TM1.[EmpID] AND T6.[AgeID] = TM1.[AgeID] AND T6.[BodCod] = TM1.[BodCod] AND T6.[PrdCod] = TM1.[PrdCod]) WHERE TM1.[stockAnio] = @stockAnio and TM1.[stockMes] = @stockMes and TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[BodCod] = @BodCod and TM1.[PrdCod] = @PrdCod ORDER BY TM1.[stockAnio], TM1.[stockMes], TM1.[EmpID], TM1.[AgeID], TM1.[BodCod], TM1.[PrdCod]  OPTION (FAST 100)" ;
          Object[] prmT001112 ;
          prmT001112 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001113 ;
          prmT001113 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001115 ;
          prmT001115 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001117 ;
          prmT001117 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001119 ;
          prmT001119 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001124 ;
          prmT001124 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001125 ;
          prmT001125 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001127 ;
          prmT001127 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001129 ;
          prmT001129 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001131 ;
          prmT001131 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001132 ;
          prmT001132 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001111 ;
          prmT001111 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001133 ;
          prmT001133 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001134 ;
          prmT001134 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001110 ;
          prmT001110 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001135 ;
          prmT001135 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@prdStockDsc",SqlDbType.VarChar,80,0} ,
          new Object[] {"@invFisico",SqlDbType.Decimal,6,2} ,
          new Object[] {"@stockUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001136 ;
          prmT001136 = new Object[] {
          new Object[] {"@prdStockDsc",SqlDbType.VarChar,80,0} ,
          new Object[] {"@invFisico",SqlDbType.Decimal,6,2} ,
          new Object[] {"@stockUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001137 ;
          prmT001137 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001146 ;
          prmT001146 = new Object[] {
          new Object[] {"@stockUltNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001147 ;
          prmT001147 = new Object[] {
          } ;
          Object[] prmT001148 ;
          prmT001148 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetIngID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00119 ;
          prmT00119 = new Object[] {
          new Object[] {"@ingTipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT00118 ;
          prmT00118 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT001149 ;
          prmT001149 = new Object[] {
          new Object[] {"@ingTipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT001150 ;
          prmT001150 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT001151 ;
          prmT001151 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetIngID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00117 ;
          prmT00117 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetIngID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00116 ;
          prmT00116 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetIngID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001152 ;
          prmT001152 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetIngID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingCantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@fchMovIng",SqlDbType.DateTime,8,0} ,
          new Object[] {"@hraMovIng",SqlDbType.DateTime,0,5} ,
          new Object[] {"@ingBodNroDoc",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingBodTipoDoc",SqlDbType.Char,4,0} ,
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0} ,
          new Object[] {"@ingTipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001153 ;
          prmT001153 = new Object[] {
          new Object[] {"@ingCantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@fchMovIng",SqlDbType.DateTime,8,0} ,
          new Object[] {"@hraMovIng",SqlDbType.DateTime,0,5} ,
          new Object[] {"@ingBodNroDoc",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ingBodTipoDoc",SqlDbType.Char,4,0} ,
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0} ,
          new Object[] {"@ingTipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetIngID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001154 ;
          prmT001154 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetIngID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001157 ;
          prmT001157 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00114 ;
          prmT00114 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001158 ;
          prmT001158 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00115 ;
          prmT00115 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT001159 ;
          prmT001159 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT001160 ;
          prmT001160 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00113 ;
          prmT00113 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00112 ;
          prmT00112 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001161 ;
          prmT001161 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@cantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@stock",SqlDbType.Decimal,9,2} ,
          new Object[] {"@stockDetNroDoc",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockdetTipo",SqlDbType.Char,4,0} ,
          new Object[] {"@costo",SqlDbType.Decimal,10,2} ,
          new Object[] {"@fchMovStock",SqlDbType.DateTime,8,0} ,
          new Object[] {"@hraMovStock",SqlDbType.DateTime,0,5} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT001162 ;
          prmT001162 = new Object[] {
          new Object[] {"@cantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@stock",SqlDbType.Decimal,9,2} ,
          new Object[] {"@stockDetNroDoc",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockdetTipo",SqlDbType.Char,4,0} ,
          new Object[] {"@costo",SqlDbType.Decimal,10,2} ,
          new Object[] {"@fchMovStock",SqlDbType.DateTime,8,0} ,
          new Object[] {"@hraMovStock",SqlDbType.DateTime,0,5} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001163 ;
          prmT001163 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockDetID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001165 ;
          prmT001165 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001166 ;
          prmT001166 = new Object[] {
          } ;
          Object[] prmT001167 ;
          prmT001167 = new Object[] {
          new Object[] {"@AV9EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001168 ;
          prmT001168 = new Object[] {
          } ;
          Object[] prmT001138 ;
          prmT001138 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001139 ;
          prmT001139 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001141 ;
          prmT001141 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001143 ;
          prmT001143 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001145 ;
          prmT001145 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001155 ;
          prmT001155 = new Object[] {
          new Object[] {"@ingTipoInv",SqlDbType.Char,4,0}
          } ;
          Object[] prmT001156 ;
          prmT001156 = new Object[] {
          new Object[] {"@PrvRuc",SqlDbType.Char,13,0}
          } ;
          Object[] prmT001164 ;
          prmT001164 = new Object[] {
          new Object[] {"@TipoInv",SqlDbType.Char,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00112", "SELECT [stockAnio], [stockMes], [AgeID], [BodCod], [PrdCod], [stockDetID], [cantidad], [stock], [stockDetNroDoc], [stockdetTipo], [costo], [fchMovStock], [hraMovStock], [EmpID], [ClienteID], [TipoInv] FROM [ProdxBodegaTipoInv] WITH (UPDLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetID] = @stockDetID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00112,1,0,true,false )
             ,new CursorDef("T00113", "SELECT [stockAnio], [stockMes], [AgeID], [BodCod], [PrdCod], [stockDetID], [cantidad], [stock], [stockDetNroDoc], [stockdetTipo], [costo], [fchMovStock], [hraMovStock], [EmpID], [ClienteID], [TipoInv] FROM [ProdxBodegaTipoInv] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetID] = @stockDetID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00113,1,0,true,false )
             ,new CursorDef("T00114", "SELECT [ClienteRUC], [ClienteDsc] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00114,1,0,true,false )
             ,new CursorDef("T00115", "SELECT [TipoInvMov], [TipoInvSigno] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT00115,1,0,true,false )
             ,new CursorDef("T00116", "SELECT [stockAnio], [stockMes], [AgeID], [BodCod], [PrdCod], [stockDetIngID], [ingCantidad], [fchMovIng], [hraMovIng], [ingBodNroDoc], [ingBodTipoDoc], [PrvRuc], [ingTipoInv] AS ingTipoInv, [EmpID] FROM [ProdStockBodegastockDetEgr] WITH (UPDLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetIngID] = @stockDetIngID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00116,1,0,true,false )
             ,new CursorDef("T00117", "SELECT [stockAnio], [stockMes], [AgeID], [BodCod], [PrdCod], [stockDetIngID], [ingCantidad], [fchMovIng], [hraMovIng], [ingBodNroDoc], [ingBodTipoDoc], [PrvRuc], [ingTipoInv] AS ingTipoInv, [EmpID] FROM [ProdStockBodegastockDetEgr] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetIngID] = @stockDetIngID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00117,1,0,true,false )
             ,new CursorDef("T00118", "SELECT [PrvDsc] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT00118,1,0,true,false )
             ,new CursorDef("T00119", "SELECT [TipoInvMov] AS ingTipoInvMov, [TipoInvSigno] AS ingTipoSigno FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @ingTipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT00119,1,0,true,false )
             ,new CursorDef("T001110", "SELECT [stockAnio], [stockMes], [prdStockDsc], [invFisico], [stockUltNro], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodega] WITH (UPDLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001110,1,0,true,false )
             ,new CursorDef("T001111", "SELECT [stockAnio], [stockMes], [prdStockDsc], [invFisico], [stockUltNro], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodega] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001111,1,0,true,false )
             ,new CursorDef("T001112", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001112,1,0,true,false )
             ,new CursorDef("T001113", "SELECT [prdNombre], [PrdPres] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001113,1,0,true,false )
             ,new CursorDef("T001115", "SELECT COALESCE( T1.[totalStock], 0) AS totalStock FROM (SELECT SUM([stock]) AS totalStock, [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodegaTipoInv] WITH (UPDLOCK) GROUP BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001115,1,0,true,false )
             ,new CursorDef("T001117", "SELECT COALESCE( T1.[ingBod], 0) AS ingBod FROM (SELECT SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = 1 THEN COALESCE( T2.[ingCantidad], 0) ELSE 0 END) AS ingBod, T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] FROM ([ProdStockBodegastockDetEgr] T2 WITH (UPDLOCK) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = T2.[ingTipoInv]) GROUP BY T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001117,1,0,true,false )
             ,new CursorDef("T001119", "SELECT COALESCE( T1.[egrBod], 0) AS egrBod FROM (SELECT SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = -1 THEN COALESCE( T2.[cantidad], 0) ELSE 0 END) AS egrBod, T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] FROM ([ProdxBodegaTipoInv] T2 WITH (UPDLOCK) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = T2.[TipoInv]) GROUP BY T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001119,1,0,true,false )
             ,new CursorDef("T001123", cmdBufferT001123,true, GxErrorMask.GX_NOMASK, false, this,prmT001123,100,0,true,false )
             ,new CursorDef("T001124", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001124,1,0,true,false )
             ,new CursorDef("T001125", "SELECT [prdNombre], [PrdPres] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001125,1,0,true,false )
             ,new CursorDef("T001127", "SELECT COALESCE( T1.[totalStock], 0) AS totalStock FROM (SELECT SUM([stock]) AS totalStock, [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodegaTipoInv] WITH (UPDLOCK) GROUP BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001127,1,0,true,false )
             ,new CursorDef("T001129", "SELECT COALESCE( T1.[ingBod], 0) AS ingBod FROM (SELECT SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = 1 THEN COALESCE( T2.[ingCantidad], 0) ELSE 0 END) AS ingBod, T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] FROM ([ProdStockBodegastockDetEgr] T2 WITH (UPDLOCK) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = T2.[ingTipoInv]) GROUP BY T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001129,1,0,true,false )
             ,new CursorDef("T001131", "SELECT COALESCE( T1.[egrBod], 0) AS egrBod FROM (SELECT SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = -1 THEN COALESCE( T2.[cantidad], 0) ELSE 0 END) AS egrBod, T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] FROM ([ProdxBodegaTipoInv] T2 WITH (UPDLOCK) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = T2.[TipoInv]) GROUP BY T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001131,1,0,true,false )
             ,new CursorDef("T001132", "SELECT [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodega] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001132,1,0,true,false )
             ,new CursorDef("T001133", "SELECT TOP 1 [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodega] WITH (NOLOCK) WHERE ( [stockAnio] > @stockAnio or [stockAnio] = @stockAnio and [stockMes] > @stockMes or [stockMes] = @stockMes and [stockAnio] = @stockAnio and [EmpID] > @EmpID or [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [AgeID] > @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [BodCod] > @BodCod or [BodCod] = @BodCod and [AgeID] = @AgeID and [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [PrdCod] > @PrdCod) ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001133,1,0,true,true )
             ,new CursorDef("T001134", "SELECT TOP 1 [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodega] WITH (NOLOCK) WHERE ( [stockAnio] < @stockAnio or [stockAnio] = @stockAnio and [stockMes] < @stockMes or [stockMes] = @stockMes and [stockAnio] = @stockAnio and [EmpID] < @EmpID or [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [AgeID] < @AgeID or [AgeID] = @AgeID and [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [BodCod] < @BodCod or [BodCod] = @BodCod and [AgeID] = @AgeID and [EmpID] = @EmpID and [stockMes] = @stockMes and [stockAnio] = @stockAnio and [PrdCod] < @PrdCod) ORDER BY [stockAnio] DESC, [stockMes] DESC, [EmpID] DESC, [AgeID] DESC, [BodCod] DESC, [PrdCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001134,1,0,true,true )
             ,new CursorDef("T001135", "INSERT INTO [ProdxBodega]([stockAnio], [stockMes], [prdStockDsc], [invFisico], [stockUltNro], [EmpID], [AgeID], [BodCod], [PrdCod]) VALUES(@stockAnio, @stockMes, @prdStockDsc, @invFisico, @stockUltNro, @EmpID, @AgeID, @BodCod, @PrdCod)", GxErrorMask.GX_NOMASK,prmT001135)
             ,new CursorDef("T001136", "UPDATE [ProdxBodega] SET [prdStockDsc]=@prdStockDsc, [invFisico]=@invFisico, [stockUltNro]=@stockUltNro  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod", GxErrorMask.GX_NOMASK,prmT001136)
             ,new CursorDef("T001137", "DELETE FROM [ProdxBodega]  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod", GxErrorMask.GX_NOMASK,prmT001137)
             ,new CursorDef("T001138", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001138,1,0,true,false )
             ,new CursorDef("T001139", "SELECT [prdNombre], [PrdPres] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001139,1,0,true,false )
             ,new CursorDef("T001141", "SELECT COALESCE( T1.[totalStock], 0) AS totalStock FROM (SELECT SUM([stock]) AS totalStock, [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodegaTipoInv] WITH (UPDLOCK) GROUP BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001141,1,0,true,false )
             ,new CursorDef("T001143", "SELECT COALESCE( T1.[ingBod], 0) AS ingBod FROM (SELECT SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = 1 THEN COALESCE( T2.[ingCantidad], 0) ELSE 0 END) AS ingBod, T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] FROM ([ProdStockBodegastockDetEgr] T2 WITH (UPDLOCK) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = T2.[ingTipoInv]) GROUP BY T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001143,1,0,true,false )
             ,new CursorDef("T001145", "SELECT COALESCE( T1.[egrBod], 0) AS egrBod FROM (SELECT SUM(CASE  WHEN COALESCE( T3.[TipoInvSigno], 0) = -1 THEN COALESCE( T2.[cantidad], 0) ELSE 0 END) AS egrBod, T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] FROM ([ProdxBodegaTipoInv] T2 WITH (UPDLOCK) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = T2.[TipoInv]) GROUP BY T2.[stockAnio], T2.[stockMes], T2.[EmpID], T2.[AgeID], T2.[BodCod], T2.[PrdCod] ) T1 WHERE T1.[stockAnio] = @stockAnio AND T1.[stockMes] = @stockMes AND T1.[EmpID] = @EmpID AND T1.[AgeID] = @AgeID AND T1.[BodCod] = @BodCod AND T1.[PrdCod] = @PrdCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT001145,1,0,true,false )
             ,new CursorDef("T001146", "UPDATE [ProdxBodega] SET [stockUltNro]=@stockUltNro  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod", GxErrorMask.GX_NOMASK,prmT001146)
             ,new CursorDef("T001147", "SELECT [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod] FROM [ProdxBodega] WITH (NOLOCK) ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001147,100,0,true,false )
             ,new CursorDef("T001148", "SELECT T1.[stockAnio], T1.[stockMes], T1.[AgeID], T1.[BodCod], T1.[PrdCod], T1.[stockDetIngID], T2.[TipoInvMov] AS ingTipoInvMov, T2.[TipoInvSigno] AS ingTipoSigno, T1.[ingCantidad], T3.[PrvDsc], T1.[fchMovIng], T1.[hraMovIng], T1.[ingBodNroDoc], T1.[ingBodTipoDoc], T1.[PrvRuc], T1.[ingTipoInv] AS ingTipoInv, T1.[EmpID] FROM (([ProdStockBodegastockDetEgr] T1 WITH (NOLOCK) INNER JOIN [TipoMovimiento] T2 WITH (NOLOCK) ON T2.[TipoInv] = T1.[ingTipoInv]) INNER JOIN [Proveedor] T3 WITH (NOLOCK) ON T3.[PrvRuc] = T1.[PrvRuc]) WHERE T1.[stockAnio] = @stockAnio and T1.[stockMes] = @stockMes and T1.[EmpID] = @EmpID and T1.[AgeID] = @AgeID and T1.[BodCod] = @BodCod and T1.[PrdCod] = @PrdCod and T1.[stockDetIngID] = @stockDetIngID ORDER BY T1.[stockAnio], T1.[stockMes], T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[PrdCod], T1.[stockDetIngID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001148,11,0,true,false )
             ,new CursorDef("T001149", "SELECT [TipoInvMov] AS ingTipoInvMov, [TipoInvSigno] AS ingTipoSigno FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @ingTipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT001149,1,0,true,false )
             ,new CursorDef("T001150", "SELECT [PrvDsc] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT001150,1,0,true,false )
             ,new CursorDef("T001151", "SELECT [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetIngID] FROM [ProdStockBodegastockDetEgr] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetIngID] = @stockDetIngID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001151,1,0,true,false )
             ,new CursorDef("T001152", "INSERT INTO [ProdStockBodegastockDetEgr]([stockAnio], [stockMes], [AgeID], [BodCod], [PrdCod], [stockDetIngID], [ingCantidad], [fchMovIng], [hraMovIng], [ingBodNroDoc], [ingBodTipoDoc], [PrvRuc], [ingTipoInv], [EmpID]) VALUES(@stockAnio, @stockMes, @AgeID, @BodCod, @PrdCod, @stockDetIngID, @ingCantidad, @fchMovIng, @hraMovIng, @ingBodNroDoc, @ingBodTipoDoc, @PrvRuc, @ingTipoInv, @EmpID)", GxErrorMask.GX_NOMASK,prmT001152)
             ,new CursorDef("T001153", "UPDATE [ProdStockBodegastockDetEgr] SET [ingCantidad]=@ingCantidad, [fchMovIng]=@fchMovIng, [hraMovIng]=@hraMovIng, [ingBodNroDoc]=@ingBodNroDoc, [ingBodTipoDoc]=@ingBodTipoDoc, [PrvRuc]=@PrvRuc, [ingTipoInv]=@ingTipoInv  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetIngID] = @stockDetIngID", GxErrorMask.GX_NOMASK,prmT001153)
             ,new CursorDef("T001154", "DELETE FROM [ProdStockBodegastockDetEgr]  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetIngID] = @stockDetIngID", GxErrorMask.GX_NOMASK,prmT001154)
             ,new CursorDef("T001155", "SELECT [TipoInvMov] AS ingTipoInvMov, [TipoInvSigno] AS ingTipoSigno FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @ingTipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT001155,1,0,true,false )
             ,new CursorDef("T001156", "SELECT [PrvDsc] FROM [Proveedor] WITH (NOLOCK) WHERE [PrvRuc] = @PrvRuc ",true, GxErrorMask.GX_NOMASK, false, this,prmT001156,1,0,true,false )
             ,new CursorDef("T001157", "SELECT [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetIngID] FROM [ProdStockBodegastockDetEgr] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio and [stockMes] = @stockMes and [EmpID] = @EmpID and [AgeID] = @AgeID and [BodCod] = @BodCod and [PrdCod] = @PrdCod ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetIngID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001157,11,0,true,false )
             ,new CursorDef("T001158", "SELECT T1.[stockAnio], T1.[stockMes], T1.[AgeID], T1.[BodCod], T1.[PrdCod], T1.[stockDetID], T3.[TipoInvMov], T3.[TipoInvSigno], T1.[cantidad], T1.[stock], T1.[stockDetNroDoc], T1.[stockdetTipo], T2.[ClienteRUC], T2.[ClienteDsc], T1.[costo], T1.[fchMovStock], T1.[hraMovStock], T1.[EmpID], T1.[ClienteID], T1.[TipoInv] FROM (([ProdxBodegaTipoInv] T1 WITH (NOLOCK) INNER JOIN [Clientes] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[ClienteID] = T1.[ClienteID]) INNER JOIN [TipoMovimiento] T3 WITH (NOLOCK) ON T3.[TipoInv] = T1.[TipoInv]) WHERE T1.[stockAnio] = @stockAnio and T1.[stockMes] = @stockMes and T1.[EmpID] = @EmpID and T1.[AgeID] = @AgeID and T1.[BodCod] = @BodCod and T1.[PrdCod] = @PrdCod and T1.[stockDetID] = @stockDetID ORDER BY T1.[stockAnio], T1.[stockMes], T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[PrdCod], T1.[stockDetID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001158,11,0,true,false )
             ,new CursorDef("T001159", "SELECT [TipoInvMov], [TipoInvSigno] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT001159,1,0,true,false )
             ,new CursorDef("T001160", "SELECT [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetID] FROM [ProdxBodegaTipoInv] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetID] = @stockDetID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001160,1,0,true,false )
             ,new CursorDef("T001161", "INSERT INTO [ProdxBodegaTipoInv]([stockAnio], [stockMes], [AgeID], [BodCod], [PrdCod], [stockDetID], [cantidad], [stock], [stockDetNroDoc], [stockdetTipo], [costo], [fchMovStock], [hraMovStock], [EmpID], [ClienteID], [TipoInv]) VALUES(@stockAnio, @stockMes, @AgeID, @BodCod, @PrdCod, @stockDetID, @cantidad, @stock, @stockDetNroDoc, @stockdetTipo, @costo, @fchMovStock, @hraMovStock, @EmpID, @ClienteID, @TipoInv)", GxErrorMask.GX_NOMASK,prmT001161)
             ,new CursorDef("T001162", "UPDATE [ProdxBodegaTipoInv] SET [cantidad]=@cantidad, [stock]=@stock, [stockDetNroDoc]=@stockDetNroDoc, [stockdetTipo]=@stockdetTipo, [costo]=@costo, [fchMovStock]=@fchMovStock, [hraMovStock]=@hraMovStock, [ClienteID]=@ClienteID, [TipoInv]=@TipoInv  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetID] = @stockDetID", GxErrorMask.GX_NOMASK,prmT001162)
             ,new CursorDef("T001163", "DELETE FROM [ProdxBodegaTipoInv]  WHERE [stockAnio] = @stockAnio AND [stockMes] = @stockMes AND [EmpID] = @EmpID AND [AgeID] = @AgeID AND [BodCod] = @BodCod AND [PrdCod] = @PrdCod AND [stockDetID] = @stockDetID", GxErrorMask.GX_NOMASK,prmT001163)
             ,new CursorDef("T001164", "SELECT [TipoInvMov], [TipoInvSigno] FROM [TipoMovimiento] WITH (NOLOCK) WHERE [TipoInv] = @TipoInv ",true, GxErrorMask.GX_NOMASK, false, this,prmT001164,1,0,true,false )
             ,new CursorDef("T001165", "SELECT [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetID] FROM [ProdxBodegaTipoInv] WITH (NOLOCK) WHERE [stockAnio] = @stockAnio and [stockMes] = @stockMes and [EmpID] = @EmpID and [AgeID] = @AgeID and [BodCod] = @BodCod and [PrdCod] = @PrdCod ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [PrdCod], [stockDetID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001165,11,0,true,false )
             ,new CursorDef("T001166", "SELECT [EmpID], [empdsc] FROM [Empresas] WITH (NOLOCK) ORDER BY [empdsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001166,0,0,true,false )
             ,new CursorDef("T001167", "SELECT [EmpID], [AgeID], [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @AV9EmpID ORDER BY [AgeDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001167,0,0,true,false )
             ,new CursorDef("T001168", "SELECT [EmpID], [empdsc] FROM [Empresas] WITH (NOLOCK) ORDER BY [empdsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001168,0,0,true,false )
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
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getString(10, 4) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[16])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[18])[0] = rslt.getGXDateTime(13) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(13);
                ((short[]) buf[20])[0] = rslt.getShort(14) ;
                ((short[]) buf[21])[0] = rslt.getShort(15) ;
                ((String[]) buf[22])[0] = rslt.getString(16, 4) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getString(10, 4) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[16])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[18])[0] = rslt.getGXDateTime(13) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(13);
                ((short[]) buf[20])[0] = rslt.getShort(14) ;
                ((short[]) buf[21])[0] = rslt.getShort(15) ;
                ((String[]) buf[22])[0] = rslt.getString(16, 4) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((short[]) buf[12])[0] = rslt.getShort(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((String[]) buf[14])[0] = rslt.getString(11, 4) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getString(12, 13) ;
                ((String[]) buf[17])[0] = rslt.getString(13, 4) ;
                ((short[]) buf[18])[0] = rslt.getShort(14) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((short[]) buf[12])[0] = rslt.getShort(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((String[]) buf[14])[0] = rslt.getString(11, 4) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getString(12, 13) ;
                ((String[]) buf[17])[0] = rslt.getString(13, 4) ;
                ((short[]) buf[18])[0] = rslt.getShort(14) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 14 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 15 :
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
                ((decimal[]) buf[10])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((short[]) buf[15])[0] = rslt.getShort(10) ;
                ((short[]) buf[16])[0] = rslt.getShort(11) ;
                ((short[]) buf[17])[0] = rslt.getShort(12) ;
                ((decimal[]) buf[18])[0] = rslt.getDecimal(13) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(13);
                ((decimal[]) buf[20])[0] = rslt.getDecimal(14) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(14);
                ((decimal[]) buf[22])[0] = rslt.getDecimal(15) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(15);
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 18 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 19 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 20 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 29 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 31 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 33 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 34 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((short[]) buf[8])[0] = rslt.getShort(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[14])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[16])[0] = rslt.getGXDateTime(12) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((short[]) buf[18])[0] = rslt.getShort(13) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(13);
                ((String[]) buf[20])[0] = rslt.getString(14, 4) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(14);
                ((String[]) buf[22])[0] = rslt.getString(15, 13) ;
                ((String[]) buf[23])[0] = rslt.getString(16, 4) ;
                ((short[]) buf[24])[0] = rslt.getShort(17) ;
                return;
             case 35 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 36 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 37 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 41 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 42 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 43 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 44 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((short[]) buf[8])[0] = rslt.getShort(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                ((String[]) buf[16])[0] = rslt.getString(12, 4) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((String[]) buf[18])[0] = rslt.getString(13, 13) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(13);
                ((String[]) buf[20])[0] = rslt.getString(14, 50) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(14);
                ((decimal[]) buf[22])[0] = rslt.getDecimal(15) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(15);
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(16) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(16);
                ((DateTime[]) buf[26])[0] = rslt.getGXDateTime(17) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(17);
                ((short[]) buf[28])[0] = rslt.getShort(18) ;
                ((short[]) buf[29])[0] = rslt.getShort(19) ;
                ((String[]) buf[30])[0] = rslt.getString(20, 4) ;
                return;
             case 45 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 46 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 50 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 51 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 52 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 53 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 54 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
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
                stmt.SetParameter(6, (short)parms[5]);
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
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
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 24 :
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
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (decimal)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[7]);
                }
                stmt.SetParameter(6, (short)parms[8]);
                stmt.SetParameter(7, (short)parms[9]);
                stmt.SetParameter(8, (short)parms[10]);
                stmt.SetParameter(9, (short)parms[11]);
                return;
             case 25 :
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
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (decimal)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                stmt.SetParameter(4, (short)parms[6]);
                stmt.SetParameter(5, (short)parms[7]);
                stmt.SetParameter(6, (short)parms[8]);
                stmt.SetParameter(7, (short)parms[9]);
                stmt.SetParameter(8, (short)parms[10]);
                stmt.SetParameter(9, (short)parms[11]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(6, (short)parms[5]);
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
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 31 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 32 :
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
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                stmt.SetParameter(7, (short)parms[7]);
                return;
             case 34 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 35 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 36 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 37 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 38 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (decimal)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(8, (DateTime)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(9, (DateTime)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 11 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[15]);
                }
                stmt.SetParameter(12, (String)parms[16]);
                stmt.SetParameter(13, (String)parms[17]);
                stmt.SetParameter(14, (short)parms[18]);
                return;
             case 39 :
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
                   stmt.setNull( 2 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(2, (DateTime)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(3, (DateTime)parms[5]);
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
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
                }
                stmt.SetParameter(6, (String)parms[10]);
                stmt.SetParameter(7, (String)parms[11]);
                stmt.SetParameter(8, (short)parms[12]);
                stmt.SetParameter(9, (short)parms[13]);
                stmt.SetParameter(10, (short)parms[14]);
                stmt.SetParameter(11, (short)parms[15]);
                stmt.SetParameter(12, (short)parms[16]);
                stmt.SetParameter(13, (short)parms[17]);
                stmt.SetParameter(14, (short)parms[18]);
                return;
             case 40 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 41 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 42 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 43 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 44 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 45 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 46 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 47 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(7, (decimal)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (decimal)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 9 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(9, (short)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 11 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(11, (decimal)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 12 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(12, (DateTime)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 13 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(13, (DateTime)parms[19]);
                }
                stmt.SetParameter(14, (short)parms[20]);
                stmt.SetParameter(15, (short)parms[21]);
                stmt.SetParameter(16, (String)parms[22]);
                return;
             case 48 :
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
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
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
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(6, (DateTime)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[13]);
                }
                stmt.SetParameter(8, (short)parms[14]);
                stmt.SetParameter(9, (String)parms[15]);
                stmt.SetParameter(10, (short)parms[16]);
                stmt.SetParameter(11, (short)parms[17]);
                stmt.SetParameter(12, (short)parms[18]);
                stmt.SetParameter(13, (short)parms[19]);
                stmt.SetParameter(14, (short)parms[20]);
                stmt.SetParameter(15, (short)parms[21]);
                stmt.SetParameter(16, (short)parms[22]);
                return;
             case 49 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 50 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 51 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 53 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
