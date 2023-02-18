/*
               File: Cotizador
        Description: Cotizador
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:53:11.33
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
   public class cotizador : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel6"+"_"+"COTIID") == 0 )
         {
            AV7CotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7CotiID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCOTIID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CotiID), "ZZZ9"), context));
            AV8EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8EmpID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX6ASACOTIID0E28( AV7CotiID, AV8EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_31") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_31( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_32") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A10protID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_32( A1EmpID, A10protID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_33") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A34CotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_33( A1EmpID, A34CotiID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_34") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A34CotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_34( A1EmpID, A34CotiID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_35") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A34CotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_35( A1EmpID, A34CotiID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_36") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A34CotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_36( A1EmpID, A34CotiID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_37") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A34CotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_37( A1EmpID, A34CotiID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_39") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A36detTipoProdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_39( A1EmpID, A36detTipoProdID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_40") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A32categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_40( A1EmpID, A32categID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_41") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A32categID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            A33subCatID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_41( A1EmpID, A32categID, A33subCatID) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcotizadordet") == 0 )
         {
            nRC_GXsfl_74 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_74_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_74_idx = GetNextPar( );
            A156CotiUltNro = (int)(NumberUtil.Val( GetNextPar( ), "."));
            n156CotiUltNro = false;
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridcotizadordet_newrow( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
         {
            nRC_GXsfl_90 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_90_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_90_idx = GetNextPar( );
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
               AV8EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8EmpID), "ZZZ9"), context));
               AV7CotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7CotiID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCOTIID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CotiID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Cotizador", 0) ;
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

      public cotizador( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public cotizador( IGxContext context )
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
                           short aP2_CotiID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV8EmpID = aP1_EmpID;
         this.AV7CotiID = aP2_CotiID;
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
            GxWebStd.gx_div_start( context, divMaintable1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout1_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Cotizador", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Cotizador.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Cotizador.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Cotizador.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiID_Internalname, "Nro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCotiID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34CotiID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A34CotiID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCotiID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCotiID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiDsc_Internalname, "Descripcion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCotiDsc_Internalname, A154CotiDsc, StringUtil.RTrim( context.localUtil.Format( A154CotiDsc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCotiDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCotiDsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtprotID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtprotID_Internalname, "prot ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtprotID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A10protID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprotID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtprotID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_Cotizador.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_10_Internalname, sImgUrl, imgprompt_10_Link, "", "", context.GetTheme( ), imgprompt_10_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtprotDsc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtprotDsc_Internalname, "Prototipo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtprotDsc_Internalname, StringUtil.RTrim( A74protDsc), StringUtil.RTrim( context.localUtil.Format( A74protDsc, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtprotDsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtprotDsc_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiIVA_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiIVA_Internalname, "IVA", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCotiIVA_Internalname, StringUtil.LTrim( StringUtil.NToC( A155CotiIVA, 8, 3, ",", "")), ((edtCotiIVA_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A155CotiIVA, "ZZZ9.999")) : context.localUtil.Format( A155CotiIVA, "ZZZ9.999")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','3');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCotiIVA_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCotiIVA_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiUltNro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiUltNro_Internalname, "Nro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCotiUltNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A156CotiUltNro), 8, 0, ",", "")), ((edtCotiUltNro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A156CotiUltNro), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A156CotiUltNro), "ZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCotiUltNro_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCotiUltNro_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCotiObs_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCotiObs_Internalname, "Observaciones", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtCotiObs_Internalname, A182CotiObs, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", 0, 1, edtCotiObs_Enabled, 0, 80, "chr", 5, "row", StyleString, ClassString, "", "", "120", 1, 5, "", "Observaciones", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDettable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Items", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            gxdraw_Gridcotizadordet( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Mano de Obra", "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Grid1( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "Right", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTbsubtobra_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Right", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtObrSubtotal_Internalname, "Subtotal", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtObrSubtotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A177ObrSubtotal, 10, 2, ",", "")), ((edtObrSubtotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A177ObrSubtotal, "ZZZZZZ9.99")) : context.localUtil.Format( A177ObrSubtotal, "ZZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtObrSubtotal_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtObrSubtotal_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Totales", "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-lg-2 col-lg-offset-1 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection4_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtsumTotCant_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtsumTotCant_Internalname, "Tot. Cant", " AttributeBoldLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtsumTotCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A174sumTotCant, 10, 2, ",", "")), ((edtsumTotCant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A174sumTotCant, "ZZZZZZ9.99")) : context.localUtil.Format( A174sumTotCant, "ZZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtsumTotCant_Jsonclick, 0, "AttributeBold", "", "", "", "", 1, edtsumTotCant_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-lg-2 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection5_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtsumTotValor_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtsumTotValor_Internalname, "Tot. Valor", " AttributeBoldLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtsumTotValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A179sumTotValor, 10, 2, ",", "")), ((edtsumTotValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A179sumTotValor, "ZZZZZZ9.99")) : context.localUtil.Format( A179sumTotValor, "ZZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtsumTotValor_Jsonclick, 0, "AttributeBold", "", "", "", "", 1, edtsumTotValor_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-lg-2 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtsumTotValorIVA_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtsumTotValorIVA_Internalname, "Tot. Valor IVA", " AttributeBoldLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtsumTotValorIVA_Internalname, StringUtil.LTrim( StringUtil.NToC( A180sumTotValorIVA, 10, 2, ",", "")), ((edtsumTotValorIVA_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A180sumTotValorIVA, "ZZZZZZ9.99")) : context.localUtil.Format( A180sumTotValorIVA, "ZZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtsumTotValorIVA_Jsonclick, 0, "AttributeBold", "", "", "", "", 1, edtsumTotValorIVA_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-lg-2 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtsumTotNeto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtsumTotNeto_Internalname, "Tot. Neto", " AttributeBoldLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtsumTotNeto_Internalname, StringUtil.LTrim( StringUtil.NToC( A175sumTotNeto, 10, 2, ",", "")), ((edtsumTotNeto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A175sumTotNeto, "ZZZZZZ9.99")) : context.localUtil.Format( A175sumTotNeto, "ZZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtsumTotNeto_Jsonclick, 0, "AttributeBold", "", "", "", "", 1, edtsumTotNeto_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 132,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Confirmar", bttButton1_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttButton1_Visible, bttButton1_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 134,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", "Cancelar", bttButton2_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttButton2_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cotizador.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0E28( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridcotizadordet( )
      {
         /*  Grid Control  */
         GridcotizadordetContainer.AddObjectProperty("GridName", "Gridcotizadordet");
         GridcotizadordetContainer.AddObjectProperty("Header", subGridcotizadordet_Header);
         GridcotizadordetContainer.AddObjectProperty("Class", "GridDataOPCustom");
         GridcotizadordetContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridcotizadordetContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridcotizadordetContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcotizadordet_Backcolorstyle), 1, 0, ".", "")));
         GridcotizadordetContainer.AddObjectProperty("CmpContext", "");
         GridcotizadordetContainer.AddObjectProperty("InMasterPage", "false");
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A35secID), 4, 0, ".", "")));
         GridcotizadordetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsecID_Enabled), 5, 0, ".", "")));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ".", "")));
         GridcotizadordetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetTipoProdID_Enabled), 5, 0, ".", "")));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ".", "")));
         GridcotizadordetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategID_Enabled), 5, 0, ".", "")));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ".", "")));
         GridcotizadordetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", "")));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetColumn.AddObjectProperty("Value", StringUtil.RTrim( A148subCatDsc));
         GridcotizadordetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", "")));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ".", "")));
         GridcotizadordetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", "")));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A157CotiDetCant, 10, 2, ".", "")));
         GridcotizadordetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetCant_Enabled), 5, 0, ".", "")));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A158CotiDetValor, 10, 2, ".", "")));
         GridcotizadordetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetValor_Enabled), 5, 0, ".", "")));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A159CotiDetIva, 5, 2, ".", "")));
         GridcotizadordetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetIva_Enabled), 5, 0, ".", "")));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GridcotizadordetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A160CotiDetTotal, 10, 2, ".", "")));
         GridcotizadordetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetTotal_Enabled), 5, 0, ".", "")));
         GridcotizadordetContainer.AddColumnProperties(GridcotizadordetColumn);
         GridcotizadordetContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcotizadordet_Selectedindex), 4, 0, ".", "")));
         GridcotizadordetContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcotizadordet_Allowselection), 1, 0, ".", "")));
         GridcotizadordetContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcotizadordet_Selectioncolor), 9, 0, ".", "")));
         GridcotizadordetContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcotizadordet_Allowhovering), 1, 0, ".", "")));
         GridcotizadordetContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcotizadordet_Hoveringcolor), 9, 0, ".", "")));
         GridcotizadordetContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcotizadordet_Allowcollapsing), 1, 0, ".", "")));
         GridcotizadordetContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcotizadordet_Collapsed), 1, 0, ".", "")));
         nGXsfl_74_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount29 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_29 = 1;
               ScanStart0E29( ) ;
               while ( RcdFound29 != 0 )
               {
                  init_level_properties29( ) ;
                  getByPrimaryKey0E29( ) ;
                  AddRow0E29( ) ;
                  ScanNext0E29( ) ;
               }
               ScanEnd0E29( ) ;
               nBlankRcdCount29 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B177ObrSubtotal = A177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            B156CotiUltNro = A156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            B176sumTotNeto1 = A176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            B180sumTotValorIVA = A180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            B179sumTotValor = A179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            B174sumTotCant = A174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            standaloneNotModal0E29( ) ;
            standaloneModal0E29( ) ;
            sMode29 = Gx_mode;
            while ( nGXsfl_74_idx < nRC_GXsfl_74 )
            {
               bGXsfl_74_Refreshing = true;
               ReadRow0E29( ) ;
               edtsecID_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECID_"+sGXsfl_74_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsecID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsecID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
               edtdetTipoProdID_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETTIPOPRODID_"+sGXsfl_74_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetTipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetTipoProdID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
               edtcategID_Enabled = (int)(context.localUtil.CToN( cgiGet( "CATEGID_"+sGXsfl_74_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
               edtsubCatID_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATID_"+sGXsfl_74_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
               edtsubCatDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDSC_"+sGXsfl_74_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDsc_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
               edtsubCatPrec_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPREC_"+sGXsfl_74_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPrec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPrec_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
               edtCotiDetCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "COTIDETCANT_"+sGXsfl_74_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiDetCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiDetCant_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
               edtCotiDetValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "COTIDETVALOR_"+sGXsfl_74_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiDetValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiDetValor_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
               edtCotiDetIva_Enabled = (int)(context.localUtil.CToN( cgiGet( "COTIDETIVA_"+sGXsfl_74_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiDetIva_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiDetIva_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
               edtCotiDetTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "COTIDETTOTAL_"+sGXsfl_74_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiDetTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiDetTotal_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_36_"+sGXsfl_74_idx+"Link");
               imgprompt_1_Link = cgiGet( "PROMPT_32_"+sGXsfl_74_idx+"Link");
               imgprompt_1_Link = cgiGet( "PROMPT_33_"+sGXsfl_74_idx+"Link");
               if ( ( nRcdExists_29 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0E29( ) ;
               }
               SendRow0E29( ) ;
               bGXsfl_74_Refreshing = false;
            }
            Gx_mode = sMode29;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A177ObrSubtotal = B177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            A156CotiUltNro = B156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            A176sumTotNeto1 = B176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            A180sumTotValorIVA = B180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            A179sumTotValor = B179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            A174sumTotCant = B174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount29 = 5;
            nRcdExists_29 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0E29( ) ;
               while ( RcdFound29 != 0 )
               {
                  sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_7429( ) ;
                  init_level_properties29( ) ;
                  standaloneNotModal0E29( ) ;
                  getByPrimaryKey0E29( ) ;
                  standaloneModal0E29( ) ;
                  AddRow0E29( ) ;
                  ScanNext0E29( ) ;
               }
               ScanEnd0E29( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode29 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_7429( ) ;
            InitAll0E29( ) ;
            init_level_properties29( ) ;
            B177ObrSubtotal = A177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            B156CotiUltNro = A156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            B176sumTotNeto1 = A176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            B180sumTotValorIVA = A180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            B179sumTotValor = A179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            B174sumTotCant = A174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            standaloneNotModal0E29( ) ;
            standaloneModal0E29( ) ;
            nRcdExists_29 = 0;
            nIsMod_29 = 0;
            nRcdDeleted_29 = 0;
            nBlankRcdCount29 = (short)(nBlankRcdUsr29+nBlankRcdCount29);
            fRowAdded = 0;
            while ( nBlankRcdCount29 > 0 )
            {
               AddRow0E29( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtsecID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount29 = (short)(nBlankRcdCount29-1);
            }
            Gx_mode = sMode29;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A177ObrSubtotal = B177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            A156CotiUltNro = B156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            A176sumTotNeto1 = B176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            A180sumTotValorIVA = B180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            A179sumTotValor = B179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            A174sumTotCant = B174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"GridcotizadordetContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcotizadordet", GridcotizadordetContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "GridcotizadordetContainerData", GridcotizadordetContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "GridcotizadordetContainerData"+"V", GridcotizadordetContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridcotizadordetContainerData"+"V"+"\" value='"+GridcotizadordetContainer.GridValuesHidden()+"'/>") ;
         }
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
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A38nroSec), 4, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnroSec_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", A202ObrDsc);
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObrDsc_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A178ObrValor, 10, 2, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObrValor_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
         nGXsfl_90_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount30 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_30 = 1;
               ScanStart0E30( ) ;
               while ( RcdFound30 != 0 )
               {
                  init_level_properties30( ) ;
                  getByPrimaryKey0E30( ) ;
                  AddRow0E30( ) ;
                  ScanNext0E30( ) ;
               }
               ScanEnd0E30( ) ;
               nBlankRcdCount30 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B177ObrSubtotal = A177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            B156CotiUltNro = A156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            B176sumTotNeto1 = A176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            B180sumTotValorIVA = A180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            B179sumTotValor = A179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            B174sumTotCant = A174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            standaloneNotModal0E30( ) ;
            standaloneModal0E30( ) ;
            sMode30 = Gx_mode;
            while ( nGXsfl_90_idx < nRC_GXsfl_90 )
            {
               bGXsfl_90_Refreshing = true;
               ReadRow0E30( ) ;
               edtnroSec_Enabled = (int)(context.localUtil.CToN( cgiGet( "NROSEC_"+sGXsfl_90_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnroSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnroSec_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
               edtObrDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "OBRDSC_"+sGXsfl_90_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObrDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObrDsc_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
               edtObrValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "OBRVALOR_"+sGXsfl_90_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObrValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObrValor_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
               if ( ( nRcdExists_30 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0E30( ) ;
               }
               SendRow0E30( ) ;
               bGXsfl_90_Refreshing = false;
            }
            Gx_mode = sMode30;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A177ObrSubtotal = B177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            A156CotiUltNro = B156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            A176sumTotNeto1 = B176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            A180sumTotValorIVA = B180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            A179sumTotValor = B179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            A174sumTotCant = B174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount30 = 5;
            nRcdExists_30 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0E30( ) ;
               while ( RcdFound30 != 0 )
               {
                  sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_9030( ) ;
                  init_level_properties30( ) ;
                  standaloneNotModal0E30( ) ;
                  getByPrimaryKey0E30( ) ;
                  standaloneModal0E30( ) ;
                  AddRow0E30( ) ;
                  ScanNext0E30( ) ;
               }
               ScanEnd0E30( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode30 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_9030( ) ;
            InitAll0E30( ) ;
            init_level_properties30( ) ;
            B177ObrSubtotal = A177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            B156CotiUltNro = A156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            B176sumTotNeto1 = A176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            B180sumTotValorIVA = A180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            B179sumTotValor = A179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            B174sumTotCant = A174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            standaloneNotModal0E30( ) ;
            standaloneModal0E30( ) ;
            nRcdExists_30 = 0;
            nIsMod_30 = 0;
            nRcdDeleted_30 = 0;
            nBlankRcdCount30 = (short)(nBlankRcdUsr30+nBlankRcdCount30);
            fRowAdded = 0;
            while ( nBlankRcdCount30 > 0 )
            {
               AddRow0E30( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtnroSec_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount30 = (short)(nBlankRcdCount30-1);
            }
            Gx_mode = sMode30;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A177ObrSubtotal = B177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            A156CotiUltNro = B156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            A176sumTotNeto1 = B176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            A180sumTotValorIVA = B180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            A179sumTotValor = B179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            A174sumTotCant = B174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
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
         E110E2 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtCotiID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCotiID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "COTIID");
                  AnyError = 1;
                  GX_FocusControl = edtCotiID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A34CotiID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
               }
               else
               {
                  A34CotiID = (short)(context.localUtil.CToN( cgiGet( edtCotiID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
               }
               A154CotiDsc = cgiGet( edtCotiDsc_Internalname);
               n154CotiDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154CotiDsc", A154CotiDsc);
               n154CotiDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A154CotiDsc)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtprotID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtprotID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PROTID");
                  AnyError = 1;
                  GX_FocusControl = edtprotID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A10protID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
               }
               else
               {
                  A10protID = (short)(context.localUtil.CToN( cgiGet( edtprotID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
               }
               A74protDsc = cgiGet( edtprotDsc_Internalname);
               n74protDsc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74protDsc", A74protDsc);
               if ( ( ( context.localUtil.CToN( cgiGet( edtCotiIVA_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCotiIVA_Internalname), ",", ".") > 9999.999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "COTIIVA");
                  AnyError = 1;
                  GX_FocusControl = edtCotiIVA_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A155CotiIVA = 0;
                  n155CotiIVA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155CotiIVA", StringUtil.LTrim( StringUtil.Str( A155CotiIVA, 8, 3)));
               }
               else
               {
                  A155CotiIVA = context.localUtil.CToN( cgiGet( edtCotiIVA_Internalname), ",", ".");
                  n155CotiIVA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155CotiIVA", StringUtil.LTrim( StringUtil.Str( A155CotiIVA, 8, 3)));
               }
               n155CotiIVA = ((Convert.ToDecimal(0)==A155CotiIVA) ? true : false);
               A156CotiUltNro = (int)(context.localUtil.CToN( cgiGet( edtCotiUltNro_Internalname), ",", "."));
               n156CotiUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
               A182CotiObs = cgiGet( edtCotiObs_Internalname);
               n182CotiObs = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182CotiObs", A182CotiObs);
               n182CotiObs = (String.IsNullOrEmpty(StringUtil.RTrim( A182CotiObs)) ? true : false);
               A177ObrSubtotal = context.localUtil.CToN( cgiGet( edtObrSubtotal_Internalname), ",", ".");
               n177ObrSubtotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               A174sumTotCant = context.localUtil.CToN( cgiGet( edtsumTotCant_Internalname), ",", ".");
               n174sumTotCant = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
               A179sumTotValor = context.localUtil.CToN( cgiGet( edtsumTotValor_Internalname), ",", ".");
               n179sumTotValor = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
               A180sumTotValorIVA = context.localUtil.CToN( cgiGet( edtsumTotValorIVA_Internalname), ",", ".");
               n180sumTotValorIVA = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
               A175sumTotNeto = context.localUtil.CToN( cgiGet( edtsumTotNeto_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z34CotiID = (short)(context.localUtil.CToN( cgiGet( "Z34CotiID"), ",", "."));
               Z181TotNeto = context.localUtil.CToN( cgiGet( "Z181TotNeto"), ",", ".");
               n181TotNeto = ((Convert.ToDecimal(0)==A181TotNeto) ? true : false);
               Z154CotiDsc = cgiGet( "Z154CotiDsc");
               n154CotiDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A154CotiDsc)) ? true : false);
               Z155CotiIVA = context.localUtil.CToN( cgiGet( "Z155CotiIVA"), ",", ".");
               n155CotiIVA = ((Convert.ToDecimal(0)==A155CotiIVA) ? true : false);
               Z156CotiUltNro = (int)(context.localUtil.CToN( cgiGet( "Z156CotiUltNro"), ",", "."));
               n156CotiUltNro = ((0==A156CotiUltNro) ? true : false);
               Z201CotiUltNroObr = (int)(context.localUtil.CToN( cgiGet( "Z201CotiUltNroObr"), ",", "."));
               n201CotiUltNroObr = ((0==A201CotiUltNroObr) ? true : false);
               Z182CotiObs = cgiGet( "Z182CotiObs");
               n182CotiObs = (String.IsNullOrEmpty(StringUtil.RTrim( A182CotiObs)) ? true : false);
               Z10protID = (short)(context.localUtil.CToN( cgiGet( "Z10protID"), ",", "."));
               A181TotNeto = context.localUtil.CToN( cgiGet( "Z181TotNeto"), ",", ".");
               n181TotNeto = false;
               n181TotNeto = ((Convert.ToDecimal(0)==A181TotNeto) ? true : false);
               A201CotiUltNroObr = (int)(context.localUtil.CToN( cgiGet( "Z201CotiUltNroObr"), ",", "."));
               n201CotiUltNroObr = false;
               n201CotiUltNroObr = ((0==A201CotiUltNroObr) ? true : false);
               O177ObrSubtotal = context.localUtil.CToN( cgiGet( "O177ObrSubtotal"), ",", ".");
               O156CotiUltNro = (int)(context.localUtil.CToN( cgiGet( "O156CotiUltNro"), ",", "."));
               n156CotiUltNro = ((0==A156CotiUltNro) ? true : false);
               O176sumTotNeto1 = (short)(context.localUtil.CToN( cgiGet( "O176sumTotNeto1"), ",", "."));
               O180sumTotValorIVA = context.localUtil.CToN( cgiGet( "O180sumTotValorIVA"), ",", ".");
               O179sumTotValor = context.localUtil.CToN( cgiGet( "O179sumTotValor"), ",", ".");
               O174sumTotCant = context.localUtil.CToN( cgiGet( "O174sumTotCant"), ",", ".");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ",", "."));
               nRC_GXsfl_90 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_90"), ",", "."));
               N10protID = (short)(context.localUtil.CToN( cgiGet( "N10protID"), ",", "."));
               A176sumTotNeto1 = (short)(context.localUtil.CToN( cgiGet( "SUMTOTNETO1"), ",", "."));
               AV8EmpID = (short)(context.localUtil.CToN( cgiGet( "vEMPID"), ",", "."));
               AV7CotiID = (short)(context.localUtil.CToN( cgiGet( "vCOTIID"), ",", "."));
               AV9Insert_protID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_PROTID"), ",", "."));
               A181TotNeto = context.localUtil.CToN( cgiGet( "TOTNETO"), ",", ".");
               n181TotNeto = ((Convert.ToDecimal(0)==A181TotNeto) ? true : false);
               A201CotiUltNroObr = (int)(context.localUtil.CToN( cgiGet( "COTIULTNROOBR"), ",", "."));
               n201CotiUltNroObr = ((0==A201CotiUltNroObr) ? true : false);
               AV19Pgmname = cgiGet( "vPGMNAME");
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               A146categDsc = cgiGet( "CATEGDSC");
               n146categDsc = false;
               A31tipoProdID = (short)(context.localUtil.CToN( cgiGet( "TIPOPRODID"), ",", "."));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Cotizador";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV9Insert_protID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A201CotiUltNroObr), "ZZZZZZZ9");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A34CotiID != Z34CotiID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("cotizador:[SecurityCheckFailed value for]"+"Insert_protID:"+context.localUtil.Format( (decimal)(AV9Insert_protID), "ZZZ9"));
                  GXUtil.WriteLog("cotizador:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("cotizador:[SecurityCheckFailed value for]"+"CotiUltNroObr:"+context.localUtil.Format( (decimal)(A201CotiUltNroObr), "ZZZZZZZ9"));
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
                  A34CotiID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
                  getEqualNoModal( ) ;
                  if ( ! (0==AV7CotiID) )
                  {
                     A34CotiID = AV7CotiID;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                     {
                        GXt_int1 = A34CotiID;
                        new obtultcodcoti(context ).execute(  AV8EmpID, out  GXt_int1) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8EmpID), 4, 0)));
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8EmpID), "ZZZ9"), context));
                        A34CotiID = GXt_int1;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
                     }
                  }
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
                     sMode28 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV7CotiID) )
                     {
                        A34CotiID = AV7CotiID;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                        {
                           GXt_int1 = A34CotiID;
                           new obtultcodcoti(context ).execute(  AV8EmpID, out  GXt_int1) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8EmpID), 4, 0)));
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8EmpID), "ZZZ9"), context));
                           A34CotiID = GXt_int1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
                        }
                     }
                     Gx_mode = sMode28;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound28 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0E0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttButton1_Internalname;
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
                        E110E2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120E2 ();
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
            E120E2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0E28( ) ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttButton1_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttButton1_Visible), 5, 0)), true);
            }
            DisableAttributes0E28( ) ;
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

      protected void CONFIRM_0E0( )
      {
         BeforeValidate0E28( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0E28( ) ;
            }
            else
            {
               CheckExtendedTable0E28( ) ;
               CloseExtendedTableCursors0E28( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode28 = Gx_mode;
            CONFIRM_0E29( ) ;
            if ( AnyError == 0 )
            {
               CONFIRM_0E30( ) ;
               if ( AnyError == 0 )
               {
                  /* Restore parent mode. */
                  Gx_mode = sMode28;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  IsConfirmed = 1;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
               }
            }
            /* Restore parent mode. */
            Gx_mode = sMode28;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0E30( )
      {
         s177ObrSubtotal = O177ObrSubtotal;
         n177ObrSubtotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         s175sumTotNeto = O175sumTotNeto;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         s181TotNeto = O181TotNeto;
         n181TotNeto = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         nGXsfl_90_idx = 0;
         while ( nGXsfl_90_idx < nRC_GXsfl_90 )
         {
            ReadRow0E30( ) ;
            if ( ( nRcdExists_30 != 0 ) || ( nIsMod_30 != 0 ) )
            {
               GetKey0E30( ) ;
               if ( ( nRcdExists_30 == 0 ) && ( nRcdDeleted_30 == 0 ) )
               {
                  if ( RcdFound30 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0E30( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0E30( ) ;
                        CloseExtendedTableCursors0E30( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O177ObrSubtotal = A177ObrSubtotal;
                        n177ObrSubtotal = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
                        O175sumTotNeto = A175sumTotNeto;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                        O181TotNeto = A181TotNeto;
                        n181TotNeto = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                     }
                  }
                  else
                  {
                     GXCCtl = "NROSEC_" + sGXsfl_90_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtnroSec_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound30 != 0 )
                  {
                     if ( nRcdDeleted_30 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0E30( ) ;
                        Load0E30( ) ;
                        BeforeValidate0E30( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0E30( ) ;
                           O177ObrSubtotal = A177ObrSubtotal;
                           n177ObrSubtotal = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
                           O175sumTotNeto = A175sumTotNeto;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                           O181TotNeto = A181TotNeto;
                           n181TotNeto = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_30 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0E30( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0E30( ) ;
                              CloseExtendedTableCursors0E30( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O177ObrSubtotal = A177ObrSubtotal;
                              n177ObrSubtotal = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
                              O175sumTotNeto = A175sumTotNeto;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                              O181TotNeto = A181TotNeto;
                              n181TotNeto = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_30 == 0 )
                     {
                        GXCCtl = "NROSEC_" + sGXsfl_90_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtnroSec_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtnroSec_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A38nroSec), 4, 0, ",", ""))) ;
            ChangePostValue( edtObrDsc_Internalname, A202ObrDsc) ;
            ChangePostValue( edtObrValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A178ObrValor, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z38nroSec_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38nroSec), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z202ObrDsc_"+sGXsfl_90_idx, Z202ObrDsc) ;
            ChangePostValue( "ZT_"+"Z178ObrValor_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z178ObrValor, 10, 2, ",", ""))) ;
            ChangePostValue( "T178ObrValor_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( O178ObrValor, 10, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_30_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_30), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_30_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_30), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_30_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_30), 4, 0, ",", ""))) ;
            if ( nIsMod_30 != 0 )
            {
               ChangePostValue( "NROSEC_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnroSec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OBRDSC_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObrDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OBRVALOR_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObrValor_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O177ObrSubtotal = s177ObrSubtotal;
         n177ObrSubtotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         O175sumTotNeto = s175sumTotNeto;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         O181TotNeto = s181TotNeto;
         n181TotNeto = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_0E29( )
      {
         s156CotiUltNro = O156CotiUltNro;
         n156CotiUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
         s176sumTotNeto1 = O176sumTotNeto1;
         n176sumTotNeto1 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         s180sumTotValorIVA = O180sumTotValorIVA;
         n180sumTotValorIVA = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         s179sumTotValor = O179sumTotValor;
         n179sumTotValor = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         s174sumTotCant = O174sumTotCant;
         n174sumTotCant = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         s175sumTotNeto = O175sumTotNeto;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         s181TotNeto = O181TotNeto;
         n181TotNeto = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         nGXsfl_74_idx = 0;
         while ( nGXsfl_74_idx < nRC_GXsfl_74 )
         {
            ReadRow0E29( ) ;
            if ( ( nRcdExists_29 != 0 ) || ( nIsMod_29 != 0 ) )
            {
               GetKey0E29( ) ;
               if ( ( nRcdExists_29 == 0 ) && ( nRcdDeleted_29 == 0 ) )
               {
                  if ( RcdFound29 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0E29( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0E29( ) ;
                        CloseExtendedTableCursors0E29( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O156CotiUltNro = A156CotiUltNro;
                        n156CotiUltNro = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
                        O176sumTotNeto1 = A176sumTotNeto1;
                        n176sumTotNeto1 = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
                        O180sumTotValorIVA = A180sumTotValorIVA;
                        n180sumTotValorIVA = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                        O179sumTotValor = A179sumTotValor;
                        n179sumTotValor = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                        O174sumTotCant = A174sumTotCant;
                        n174sumTotCant = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                        O175sumTotNeto = A175sumTotNeto;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                        O181TotNeto = A181TotNeto;
                        n181TotNeto = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                     }
                  }
                  else
                  {
                     GXCCtl = "SECID_" + sGXsfl_74_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtsecID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound29 != 0 )
                  {
                     if ( nRcdDeleted_29 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0E29( ) ;
                        Load0E29( ) ;
                        BeforeValidate0E29( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0E29( ) ;
                           O156CotiUltNro = A156CotiUltNro;
                           n156CotiUltNro = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
                           O176sumTotNeto1 = A176sumTotNeto1;
                           n176sumTotNeto1 = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
                           O180sumTotValorIVA = A180sumTotValorIVA;
                           n180sumTotValorIVA = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                           O179sumTotValor = A179sumTotValor;
                           n179sumTotValor = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                           O174sumTotCant = A174sumTotCant;
                           n174sumTotCant = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                           O175sumTotNeto = A175sumTotNeto;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                           O181TotNeto = A181TotNeto;
                           n181TotNeto = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_29 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0E29( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0E29( ) ;
                              CloseExtendedTableCursors0E29( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O156CotiUltNro = A156CotiUltNro;
                              n156CotiUltNro = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
                              O176sumTotNeto1 = A176sumTotNeto1;
                              n176sumTotNeto1 = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
                              O180sumTotValorIVA = A180sumTotValorIVA;
                              n180sumTotValorIVA = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                              O179sumTotValor = A179sumTotValor;
                              n179sumTotValor = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                              O174sumTotCant = A174sumTotCant;
                              n174sumTotCant = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                              O175sumTotNeto = A175sumTotNeto;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                              O181TotNeto = A181TotNeto;
                              n181TotNeto = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_29 == 0 )
                     {
                        GXCCtl = "SECID_" + sGXsfl_74_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtsecID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtsecID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A35secID), 4, 0, ",", ""))) ;
            ChangePostValue( edtdetTipoProdID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ",", ""))) ;
            ChangePostValue( edtcategID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ",", ""))) ;
            ChangePostValue( edtsubCatID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( edtsubCatDsc_Internalname, StringUtil.RTrim( A148subCatDsc)) ;
            ChangePostValue( edtsubCatPrec_Internalname, StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", ""))) ;
            ChangePostValue( edtCotiDetCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A157CotiDetCant, 10, 2, ",", ""))) ;
            ChangePostValue( edtCotiDetValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A158CotiDetValor, 10, 2, ",", ""))) ;
            ChangePostValue( edtCotiDetIva_Internalname, StringUtil.LTrim( StringUtil.NToC( A159CotiDetIva, 5, 2, ",", ""))) ;
            ChangePostValue( edtCotiDetTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A160CotiDetTotal, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z35secID_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z35secID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z157CotiDetCant_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( Z157CotiDetCant, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z36detTipoProdID_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36detTipoProdID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z32categID_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( "T160CotiDetTotal_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( O160CotiDetTotal, 10, 2, ",", ""))) ;
            ChangePostValue( "T159CotiDetIva_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( O159CotiDetIva, 5, 2, ",", ""))) ;
            ChangePostValue( "T158CotiDetValor_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( O158CotiDetValor, 10, 2, ",", ""))) ;
            ChangePostValue( "T157CotiDetCant_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( O157CotiDetCant, 10, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_29_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_29), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_29_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_29), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_29_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_29), 4, 0, ",", ""))) ;
            if ( nIsMod_29 != 0 )
            {
               ChangePostValue( "SECID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsecID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETTIPOPRODID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetTipoProdID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CATEGID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDSC_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPREC_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COTIDETCANT_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COTIDETVALOR_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetValor_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COTIDETIVA_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetIva_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COTIDETTOTAL_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetTotal_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O156CotiUltNro = s156CotiUltNro;
         n156CotiUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
         O176sumTotNeto1 = s176sumTotNeto1;
         n176sumTotNeto1 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         O180sumTotValorIVA = s180sumTotValorIVA;
         n180sumTotValorIVA = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         O179sumTotValor = s179sumTotValor;
         n179sumTotValor = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         O174sumTotCant = s174sumTotCant;
         n174sumTotCant = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         O175sumTotNeto = s175sumTotNeto;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         O181TotNeto = s181TotNeto;
         n181TotNeto = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0E0( )
      {
      }

      protected void E110E2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV19Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV19Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV13WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV9Insert_protID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Insert_protID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9Insert_protID), 4, 0)));
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV19Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV20GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GXV1), 8, 0)));
            while ( AV20GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV20GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "protID") == 0 )
               {
                  AV9Insert_protID = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Insert_protID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9Insert_protID), 4, 0)));
               }
               AV20GXV1 = (int)(AV20GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GXV1), 8, 0)));
            }
         }
      }

      protected void E120E2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwcotizador.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0E28( short GX_JID )
      {
         if ( ( GX_JID == 30 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z181TotNeto = T000E11_A181TotNeto[0];
               Z154CotiDsc = T000E11_A154CotiDsc[0];
               Z155CotiIVA = T000E11_A155CotiIVA[0];
               Z156CotiUltNro = T000E11_A156CotiUltNro[0];
               Z201CotiUltNroObr = T000E11_A201CotiUltNroObr[0];
               Z182CotiObs = T000E11_A182CotiObs[0];
               Z10protID = T000E11_A10protID[0];
            }
            else
            {
               Z181TotNeto = A181TotNeto;
               Z154CotiDsc = A154CotiDsc;
               Z155CotiIVA = A155CotiIVA;
               Z156CotiUltNro = A156CotiUltNro;
               Z201CotiUltNroObr = A201CotiUltNroObr;
               Z182CotiObs = A182CotiObs;
               Z10protID = A10protID;
            }
         }
         if ( GX_JID == -30 )
         {
            Z34CotiID = A34CotiID;
            Z181TotNeto = A181TotNeto;
            Z154CotiDsc = A154CotiDsc;
            Z155CotiIVA = A155CotiIVA;
            Z156CotiUltNro = A156CotiUltNro;
            Z201CotiUltNroObr = A201CotiUltNroObr;
            Z182CotiObs = A182CotiObs;
            Z1EmpID = A1EmpID;
            Z10protID = A10protID;
            Z44empdsc = A44empdsc;
            Z176sumTotNeto1 = A176sumTotNeto1;
            Z180sumTotValorIVA = A180sumTotValorIVA;
            Z177ObrSubtotal = A177ObrSubtotal;
            Z174sumTotCant = A174sumTotCant;
            Z179sumTotValor = A179sumTotValor;
            Z74protDsc = A74protDsc;
         }
      }

      protected void standaloneNotModal( )
      {
         edtCotiUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiUltNro_Enabled), 5, 0)), true);
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_10_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00a1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"PROTID"+"'), id:'"+"PROTID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtCotiUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiUltNro_Enabled), 5, 0)), true);
         if ( ! (0==AV8EmpID) )
         {
            A1EmpID = AV8EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( ! (0==AV8EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         else
         {
            edtEmpID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV8EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7CotiID) )
         {
            edtCotiID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiID_Enabled), 5, 0)), true);
         }
         else
         {
            edtCotiID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7CotiID) )
         {
            edtCotiID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiID_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV9Insert_protID) )
         {
            edtprotID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprotID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprotID_Enabled), 5, 0)), true);
         }
         else
         {
            edtprotID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprotID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprotID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV9Insert_protID) )
         {
            A10protID = AV9Insert_protID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
         }
         if ( ! (0==AV7CotiID) )
         {
            A34CotiID = AV7CotiID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A34CotiID;
               new obtultcodcoti(context ).execute(  AV8EmpID, out  GXt_int1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8EmpID), "ZZZ9"), context));
               A34CotiID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
            }
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttButton1_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttButton1_Enabled), 5, 0)), true);
         }
         else
         {
            bttButton1_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttButton1_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T000E12 */
            pr_default.execute(10, new Object[] {A1EmpID});
            A44empdsc = T000E12_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000E12_n44empdsc[0];
            pr_default.close(10);
            AV19Pgmname = "Cotizador";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
            /* Using cursor T000E13 */
            pr_default.execute(11, new Object[] {A1EmpID, A10protID});
            A74protDsc = T000E13_A74protDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74protDsc", A74protDsc);
            n74protDsc = T000E13_n74protDsc[0];
            pr_default.close(11);
            /* Using cursor T000E17 */
            pr_default.execute(12, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(12) != 101) )
            {
               A176sumTotNeto1 = T000E17_A176sumTotNeto1[0];
               n176sumTotNeto1 = T000E17_n176sumTotNeto1[0];
            }
            else
            {
               A176sumTotNeto1 = 0;
               n176sumTotNeto1 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            }
            O176sumTotNeto1 = A176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            pr_default.close(12);
            /* Using cursor T000E20 */
            pr_default.execute(13, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(13) != 101) )
            {
               A180sumTotValorIVA = T000E20_A180sumTotValorIVA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
               n180sumTotValorIVA = T000E20_n180sumTotValorIVA[0];
            }
            else
            {
               A180sumTotValorIVA = 0;
               n180sumTotValorIVA = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            }
            O180sumTotValorIVA = A180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            pr_default.close(13);
            /* Using cursor T000E22 */
            pr_default.execute(14, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(14) != 101) )
            {
               A177ObrSubtotal = T000E22_A177ObrSubtotal[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               n177ObrSubtotal = T000E22_n177ObrSubtotal[0];
            }
            else
            {
               A177ObrSubtotal = 0;
               n177ObrSubtotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            }
            O177ObrSubtotal = A177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            pr_default.close(14);
            A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            /* Using cursor T000E24 */
            pr_default.execute(15, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(15) != 101) )
            {
               A174sumTotCant = T000E24_A174sumTotCant[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
               n174sumTotCant = T000E24_n174sumTotCant[0];
            }
            else
            {
               A174sumTotCant = 0;
               n174sumTotCant = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            }
            O174sumTotCant = A174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            pr_default.close(15);
            /* Using cursor T000E26 */
            pr_default.execute(16, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(16) != 101) )
            {
               A179sumTotValor = T000E26_A179sumTotValor[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
               n179sumTotValor = T000E26_n179sumTotValor[0];
            }
            else
            {
               A179sumTotValor = 0;
               n179sumTotValor = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            }
            O179sumTotValor = A179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            pr_default.close(16);
         }
      }

      protected void Load0E28( )
      {
         /* Using cursor T000E35 */
         pr_default.execute(17, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound28 = 1;
            A181TotNeto = T000E35_A181TotNeto[0];
            n181TotNeto = T000E35_n181TotNeto[0];
            A44empdsc = T000E35_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000E35_n44empdsc[0];
            A154CotiDsc = T000E35_A154CotiDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154CotiDsc", A154CotiDsc);
            n154CotiDsc = T000E35_n154CotiDsc[0];
            A74protDsc = T000E35_A74protDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74protDsc", A74protDsc);
            n74protDsc = T000E35_n74protDsc[0];
            A155CotiIVA = T000E35_A155CotiIVA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155CotiIVA", StringUtil.LTrim( StringUtil.Str( A155CotiIVA, 8, 3)));
            n155CotiIVA = T000E35_n155CotiIVA[0];
            A156CotiUltNro = T000E35_A156CotiUltNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            n156CotiUltNro = T000E35_n156CotiUltNro[0];
            A201CotiUltNroObr = T000E35_A201CotiUltNroObr[0];
            n201CotiUltNroObr = T000E35_n201CotiUltNroObr[0];
            A182CotiObs = T000E35_A182CotiObs[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182CotiObs", A182CotiObs);
            n182CotiObs = T000E35_n182CotiObs[0];
            A10protID = T000E35_A10protID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
            A176sumTotNeto1 = T000E35_A176sumTotNeto1[0];
            n176sumTotNeto1 = T000E35_n176sumTotNeto1[0];
            A180sumTotValorIVA = T000E35_A180sumTotValorIVA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            n180sumTotValorIVA = T000E35_n180sumTotValorIVA[0];
            A177ObrSubtotal = T000E35_A177ObrSubtotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            n177ObrSubtotal = T000E35_n177ObrSubtotal[0];
            A174sumTotCant = T000E35_A174sumTotCant[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            n174sumTotCant = T000E35_n174sumTotCant[0];
            A179sumTotValor = T000E35_A179sumTotValor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            n179sumTotValor = T000E35_n179sumTotValor[0];
            ZM0E28( -30) ;
         }
         pr_default.close(17);
         OnLoadActions0E28( ) ;
      }

      protected void OnLoadActions0E28( )
      {
         O177ObrSubtotal = A177ObrSubtotal;
         n177ObrSubtotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         O176sumTotNeto1 = A176sumTotNeto1;
         n176sumTotNeto1 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         O180sumTotValorIVA = A180sumTotValorIVA;
         n180sumTotValorIVA = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         O179sumTotValor = A179sumTotValor;
         n179sumTotValor = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         O174sumTotCant = A174sumTotCant;
         n174sumTotCant = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         AV19Pgmname = "Cotizador";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
         A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            A181TotNeto = A175sumTotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         }
      }

      protected void CheckExtendedTable0E28( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV19Pgmname = "Cotizador";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
         /* Using cursor T000E12 */
         pr_default.execute(10, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000E12_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000E12_n44empdsc[0];
         pr_default.close(10);
         /* Using cursor T000E13 */
         pr_default.execute(11, new Object[] {A1EmpID, A10protID});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Prototipo'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A74protDsc = T000E13_A74protDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74protDsc", A74protDsc);
         n74protDsc = T000E13_n74protDsc[0];
         pr_default.close(11);
         /* Using cursor T000E17 */
         pr_default.execute(12, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(12) != 101) )
         {
            A176sumTotNeto1 = T000E17_A176sumTotNeto1[0];
            n176sumTotNeto1 = T000E17_n176sumTotNeto1[0];
         }
         else
         {
            A176sumTotNeto1 = 0;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         }
         pr_default.close(12);
         /* Using cursor T000E20 */
         pr_default.execute(13, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(13) != 101) )
         {
            A180sumTotValorIVA = T000E20_A180sumTotValorIVA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            n180sumTotValorIVA = T000E20_n180sumTotValorIVA[0];
         }
         else
         {
            A180sumTotValorIVA = 0;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         }
         pr_default.close(13);
         /* Using cursor T000E22 */
         pr_default.execute(14, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(14) != 101) )
         {
            A177ObrSubtotal = T000E22_A177ObrSubtotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            n177ObrSubtotal = T000E22_n177ObrSubtotal[0];
         }
         else
         {
            A177ObrSubtotal = 0;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         }
         pr_default.close(14);
         A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            A181TotNeto = A175sumTotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         }
         /* Using cursor T000E24 */
         pr_default.execute(15, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(15) != 101) )
         {
            A174sumTotCant = T000E24_A174sumTotCant[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            n174sumTotCant = T000E24_n174sumTotCant[0];
         }
         else
         {
            A174sumTotCant = 0;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         }
         pr_default.close(15);
         /* Using cursor T000E26 */
         pr_default.execute(16, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(16) != 101) )
         {
            A179sumTotValor = T000E26_A179sumTotValor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            n179sumTotValor = T000E26_n179sumTotValor[0];
         }
         else
         {
            A179sumTotValor = 0;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         }
         pr_default.close(16);
      }

      protected void CloseExtendedTableCursors0E28( )
      {
         pr_default.close(10);
         pr_default.close(11);
         pr_default.close(12);
         pr_default.close(13);
         pr_default.close(14);
         pr_default.close(15);
         pr_default.close(16);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_31( short A1EmpID )
      {
         /* Using cursor T000E36 */
         pr_default.execute(18, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000E36_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000E36_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(18) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(18);
      }

      protected void gxLoad_32( short A1EmpID ,
                                short A10protID )
      {
         /* Using cursor T000E37 */
         pr_default.execute(19, new Object[] {A1EmpID, A10protID});
         if ( (pr_default.getStatus(19) == 101) )
         {
            GX_msglist.addItem("No existe 'Prototipo'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A74protDsc = T000E37_A74protDsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74protDsc", A74protDsc);
         n74protDsc = T000E37_n74protDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A74protDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(19) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(19);
      }

      protected void gxLoad_33( short A1EmpID ,
                                short A34CotiID )
      {
         /* Using cursor T000E41 */
         pr_default.execute(20, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(20) != 101) )
         {
            A176sumTotNeto1 = T000E41_A176sumTotNeto1[0];
            n176sumTotNeto1 = T000E41_n176sumTotNeto1[0];
         }
         else
         {
            A176sumTotNeto1 = 0;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A176sumTotNeto1), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(20) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(20);
      }

      protected void gxLoad_34( short A1EmpID ,
                                short A34CotiID )
      {
         /* Using cursor T000E44 */
         pr_default.execute(21, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(21) != 101) )
         {
            A180sumTotValorIVA = T000E44_A180sumTotValorIVA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            n180sumTotValorIVA = T000E44_n180sumTotValorIVA[0];
         }
         else
         {
            A180sumTotValorIVA = 0;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A180sumTotValorIVA, 10, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(21) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(21);
      }

      protected void gxLoad_35( short A1EmpID ,
                                short A34CotiID )
      {
         /* Using cursor T000E46 */
         pr_default.execute(22, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(22) != 101) )
         {
            A177ObrSubtotal = T000E46_A177ObrSubtotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            n177ObrSubtotal = T000E46_n177ObrSubtotal[0];
         }
         else
         {
            A177ObrSubtotal = 0;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A177ObrSubtotal, 10, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(22) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(22);
      }

      protected void gxLoad_36( short A1EmpID ,
                                short A34CotiID )
      {
         /* Using cursor T000E48 */
         pr_default.execute(23, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(23) != 101) )
         {
            A174sumTotCant = T000E48_A174sumTotCant[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            n174sumTotCant = T000E48_n174sumTotCant[0];
         }
         else
         {
            A174sumTotCant = 0;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A174sumTotCant, 10, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(23) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(23);
      }

      protected void gxLoad_37( short A1EmpID ,
                                short A34CotiID )
      {
         /* Using cursor T000E50 */
         pr_default.execute(24, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(24) != 101) )
         {
            A179sumTotValor = T000E50_A179sumTotValor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            n179sumTotValor = T000E50_n179sumTotValor[0];
         }
         else
         {
            A179sumTotValor = 0;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A179sumTotValor, 10, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(24) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(24);
      }

      protected void GetKey0E28( )
      {
         /* Using cursor T000E51 */
         pr_default.execute(25, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound28 = 1;
         }
         else
         {
            RcdFound28 = 0;
         }
         pr_default.close(25);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000E11 */
         pr_default.execute(9, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            ZM0E28( 30) ;
            RcdFound28 = 1;
            A34CotiID = T000E11_A34CotiID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
            A181TotNeto = T000E11_A181TotNeto[0];
            n181TotNeto = T000E11_n181TotNeto[0];
            A154CotiDsc = T000E11_A154CotiDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154CotiDsc", A154CotiDsc);
            n154CotiDsc = T000E11_n154CotiDsc[0];
            A155CotiIVA = T000E11_A155CotiIVA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155CotiIVA", StringUtil.LTrim( StringUtil.Str( A155CotiIVA, 8, 3)));
            n155CotiIVA = T000E11_n155CotiIVA[0];
            A156CotiUltNro = T000E11_A156CotiUltNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            n156CotiUltNro = T000E11_n156CotiUltNro[0];
            A201CotiUltNroObr = T000E11_A201CotiUltNroObr[0];
            n201CotiUltNroObr = T000E11_n201CotiUltNroObr[0];
            A182CotiObs = T000E11_A182CotiObs[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182CotiObs", A182CotiObs);
            n182CotiObs = T000E11_n182CotiObs[0];
            A1EmpID = T000E11_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A10protID = T000E11_A10protID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
            O156CotiUltNro = A156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            Z1EmpID = A1EmpID;
            Z34CotiID = A34CotiID;
            sMode28 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0E28( ) ;
            if ( AnyError == 1 )
            {
               RcdFound28 = 0;
               InitializeNonKey0E28( ) ;
            }
            Gx_mode = sMode28;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound28 = 0;
            InitializeNonKey0E28( ) ;
            sMode28 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode28;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(9);
      }

      protected void getEqualNoModal( )
      {
         GetKey0E28( ) ;
         if ( RcdFound28 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound28 = 0;
         /* Using cursor T000E52 */
         pr_default.execute(26, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(26) != 101) )
         {
            while ( (pr_default.getStatus(26) != 101) && ( ( T000E52_A1EmpID[0] < A1EmpID ) || ( T000E52_A1EmpID[0] == A1EmpID ) && ( T000E52_A34CotiID[0] < A34CotiID ) ) )
            {
               pr_default.readNext(26);
            }
            if ( (pr_default.getStatus(26) != 101) && ( ( T000E52_A1EmpID[0] > A1EmpID ) || ( T000E52_A1EmpID[0] == A1EmpID ) && ( T000E52_A34CotiID[0] > A34CotiID ) ) )
            {
               A1EmpID = T000E52_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A34CotiID = T000E52_A34CotiID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
               RcdFound28 = 1;
            }
         }
         pr_default.close(26);
      }

      protected void move_previous( )
      {
         RcdFound28 = 0;
         /* Using cursor T000E53 */
         pr_default.execute(27, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(27) != 101) )
         {
            while ( (pr_default.getStatus(27) != 101) && ( ( T000E53_A1EmpID[0] > A1EmpID ) || ( T000E53_A1EmpID[0] == A1EmpID ) && ( T000E53_A34CotiID[0] > A34CotiID ) ) )
            {
               pr_default.readNext(27);
            }
            if ( (pr_default.getStatus(27) != 101) && ( ( T000E53_A1EmpID[0] < A1EmpID ) || ( T000E53_A1EmpID[0] == A1EmpID ) && ( T000E53_A34CotiID[0] < A34CotiID ) ) )
            {
               A1EmpID = T000E53_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A34CotiID = T000E53_A34CotiID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
               RcdFound28 = 1;
            }
         }
         pr_default.close(27);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0E28( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A156CotiUltNro = O156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            A176sumTotNeto1 = O176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            A180sumTotValorIVA = O180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            A179sumTotValor = O179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            A174sumTotCant = O174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            A175sumTotNeto = O175sumTotNeto;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            A181TotNeto = O181TotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
            A177ObrSubtotal = O177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            A175sumTotNeto = O175sumTotNeto;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            A181TotNeto = O181TotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0E28( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound28 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A34CotiID != Z34CotiID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A34CotiID = Z34CotiID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A156CotiUltNro = O156CotiUltNro;
                  n156CotiUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
                  A176sumTotNeto1 = O176sumTotNeto1;
                  n176sumTotNeto1 = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
                  A180sumTotValorIVA = O180sumTotValorIVA;
                  n180sumTotValorIVA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                  A179sumTotValor = O179sumTotValor;
                  n179sumTotValor = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                  A174sumTotCant = O174sumTotCant;
                  n174sumTotCant = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                  A175sumTotNeto = O175sumTotNeto;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                  A181TotNeto = O181TotNeto;
                  n181TotNeto = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                  A177ObrSubtotal = O177ObrSubtotal;
                  n177ObrSubtotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
                  A175sumTotNeto = O175sumTotNeto;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                  A181TotNeto = O181TotNeto;
                  n181TotNeto = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A156CotiUltNro = O156CotiUltNro;
                  n156CotiUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
                  A176sumTotNeto1 = O176sumTotNeto1;
                  n176sumTotNeto1 = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
                  A180sumTotValorIVA = O180sumTotValorIVA;
                  n180sumTotValorIVA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                  A179sumTotValor = O179sumTotValor;
                  n179sumTotValor = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                  A174sumTotCant = O174sumTotCant;
                  n174sumTotCant = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                  A175sumTotNeto = O175sumTotNeto;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                  A181TotNeto = O181TotNeto;
                  n181TotNeto = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                  A177ObrSubtotal = O177ObrSubtotal;
                  n177ObrSubtotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
                  A175sumTotNeto = O175sumTotNeto;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                  A181TotNeto = O181TotNeto;
                  n181TotNeto = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                  Update0E28( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A34CotiID != Z34CotiID ) )
               {
                  /* Insert record */
                  A156CotiUltNro = O156CotiUltNro;
                  n156CotiUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
                  A176sumTotNeto1 = O176sumTotNeto1;
                  n176sumTotNeto1 = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
                  A180sumTotValorIVA = O180sumTotValorIVA;
                  n180sumTotValorIVA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                  A179sumTotValor = O179sumTotValor;
                  n179sumTotValor = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                  A174sumTotCant = O174sumTotCant;
                  n174sumTotCant = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                  A175sumTotNeto = O175sumTotNeto;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                  A181TotNeto = O181TotNeto;
                  n181TotNeto = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                  A177ObrSubtotal = O177ObrSubtotal;
                  n177ObrSubtotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
                  A175sumTotNeto = O175sumTotNeto;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                  A181TotNeto = O181TotNeto;
                  n181TotNeto = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0E28( ) ;
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
                     A156CotiUltNro = O156CotiUltNro;
                     n156CotiUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
                     A176sumTotNeto1 = O176sumTotNeto1;
                     n176sumTotNeto1 = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
                     A180sumTotValorIVA = O180sumTotValorIVA;
                     n180sumTotValorIVA = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                     A179sumTotValor = O179sumTotValor;
                     n179sumTotValor = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                     A174sumTotCant = O174sumTotCant;
                     n174sumTotCant = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                     A175sumTotNeto = O175sumTotNeto;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                     A181TotNeto = O181TotNeto;
                     n181TotNeto = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                     A177ObrSubtotal = O177ObrSubtotal;
                     n177ObrSubtotal = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
                     A175sumTotNeto = O175sumTotNeto;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                     A181TotNeto = O181TotNeto;
                     n181TotNeto = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0E28( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A34CotiID != Z34CotiID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A34CotiID = Z34CotiID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A156CotiUltNro = O156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            A176sumTotNeto1 = O176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            A180sumTotValorIVA = O180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            A179sumTotValor = O179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            A174sumTotCant = O174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            A175sumTotNeto = O175sumTotNeto;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            A181TotNeto = O181TotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
            A177ObrSubtotal = O177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            A175sumTotNeto = O175sumTotNeto;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            A181TotNeto = O181TotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0E28( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000E10 */
            pr_default.execute(8, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cotizador"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(8) == 101) || ( Z181TotNeto != T000E10_A181TotNeto[0] ) || ( StringUtil.StrCmp(Z154CotiDsc, T000E10_A154CotiDsc[0]) != 0 ) || ( Z155CotiIVA != T000E10_A155CotiIVA[0] ) || ( Z156CotiUltNro != T000E10_A156CotiUltNro[0] ) || ( Z201CotiUltNroObr != T000E10_A201CotiUltNroObr[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z182CotiObs, T000E10_A182CotiObs[0]) != 0 ) || ( Z10protID != T000E10_A10protID[0] ) )
            {
               if ( Z181TotNeto != T000E10_A181TotNeto[0] )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"TotNeto");
                  GXUtil.WriteLogRaw("Old: ",Z181TotNeto);
                  GXUtil.WriteLogRaw("Current: ",T000E10_A181TotNeto[0]);
               }
               if ( StringUtil.StrCmp(Z154CotiDsc, T000E10_A154CotiDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"CotiDsc");
                  GXUtil.WriteLogRaw("Old: ",Z154CotiDsc);
                  GXUtil.WriteLogRaw("Current: ",T000E10_A154CotiDsc[0]);
               }
               if ( Z155CotiIVA != T000E10_A155CotiIVA[0] )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"CotiIVA");
                  GXUtil.WriteLogRaw("Old: ",Z155CotiIVA);
                  GXUtil.WriteLogRaw("Current: ",T000E10_A155CotiIVA[0]);
               }
               if ( Z156CotiUltNro != T000E10_A156CotiUltNro[0] )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"CotiUltNro");
                  GXUtil.WriteLogRaw("Old: ",Z156CotiUltNro);
                  GXUtil.WriteLogRaw("Current: ",T000E10_A156CotiUltNro[0]);
               }
               if ( Z201CotiUltNroObr != T000E10_A201CotiUltNroObr[0] )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"CotiUltNroObr");
                  GXUtil.WriteLogRaw("Old: ",Z201CotiUltNroObr);
                  GXUtil.WriteLogRaw("Current: ",T000E10_A201CotiUltNroObr[0]);
               }
               if ( StringUtil.StrCmp(Z182CotiObs, T000E10_A182CotiObs[0]) != 0 )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"CotiObs");
                  GXUtil.WriteLogRaw("Old: ",Z182CotiObs);
                  GXUtil.WriteLogRaw("Current: ",T000E10_A182CotiObs[0]);
               }
               if ( Z10protID != T000E10_A10protID[0] )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"protID");
                  GXUtil.WriteLogRaw("Old: ",Z10protID);
                  GXUtil.WriteLogRaw("Current: ",T000E10_A10protID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Cotizador"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0E28( )
      {
         BeforeValidate0E28( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E28( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0E28( 0) ;
            CheckOptimisticConcurrency0E28( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E28( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0E28( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E54 */
                     pr_default.execute(28, new Object[] {A34CotiID, n181TotNeto, A181TotNeto, n154CotiDsc, A154CotiDsc, n155CotiIVA, A155CotiIVA, n156CotiUltNro, A156CotiUltNro, n201CotiUltNroObr, A201CotiUltNroObr, n182CotiObs, A182CotiObs, A1EmpID, A10protID});
                     pr_default.close(28);
                     dsDefault.SmartCacheProvider.SetUpdated("Cotizador") ;
                     if ( (pr_default.getStatus(28) == 1) )
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
                           ProcessLevel0E28( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0E0( ) ;
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
               Load0E28( ) ;
            }
            EndLevel0E28( ) ;
         }
         CloseExtendedTableCursors0E28( ) ;
      }

      protected void Update0E28( )
      {
         BeforeValidate0E28( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E28( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E28( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E28( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0E28( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E55 */
                     pr_default.execute(29, new Object[] {n181TotNeto, A181TotNeto, n154CotiDsc, A154CotiDsc, n155CotiIVA, A155CotiIVA, n156CotiUltNro, A156CotiUltNro, n201CotiUltNroObr, A201CotiUltNroObr, n182CotiObs, A182CotiObs, A10protID, A1EmpID, A34CotiID});
                     pr_default.close(29);
                     dsDefault.SmartCacheProvider.SetUpdated("Cotizador") ;
                     if ( (pr_default.getStatus(29) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cotizador"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0E28( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0E28( ) ;
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
            EndLevel0E28( ) ;
         }
         CloseExtendedTableCursors0E28( ) ;
      }

      protected void DeferredUpdate0E28( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0E28( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E28( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0E28( ) ;
            AfterConfirm0E28( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0E28( ) ;
               if ( AnyError == 0 )
               {
                  A177ObrSubtotal = O177ObrSubtotal;
                  n177ObrSubtotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
                  A175sumTotNeto = O175sumTotNeto;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                  A181TotNeto = O181TotNeto;
                  n181TotNeto = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                  ScanStart0E30( ) ;
                  while ( RcdFound30 != 0 )
                  {
                     getByPrimaryKey0E30( ) ;
                     Delete0E30( ) ;
                     ScanNext0E30( ) ;
                     O177ObrSubtotal = A177ObrSubtotal;
                     n177ObrSubtotal = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
                     O175sumTotNeto = A175sumTotNeto;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                     O181TotNeto = A181TotNeto;
                     n181TotNeto = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                  }
                  ScanEnd0E30( ) ;
                  A156CotiUltNro = O156CotiUltNro;
                  n156CotiUltNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
                  A176sumTotNeto1 = O176sumTotNeto1;
                  n176sumTotNeto1 = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
                  A180sumTotValorIVA = O180sumTotValorIVA;
                  n180sumTotValorIVA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                  A179sumTotValor = O179sumTotValor;
                  n179sumTotValor = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                  A174sumTotCant = O174sumTotCant;
                  n174sumTotCant = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                  A175sumTotNeto = O175sumTotNeto;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                  A181TotNeto = O181TotNeto;
                  n181TotNeto = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                  ScanStart0E29( ) ;
                  while ( RcdFound29 != 0 )
                  {
                     getByPrimaryKey0E29( ) ;
                     Delete0E29( ) ;
                     ScanNext0E29( ) ;
                     O156CotiUltNro = A156CotiUltNro;
                     n156CotiUltNro = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
                     O176sumTotNeto1 = A176sumTotNeto1;
                     n176sumTotNeto1 = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
                     O180sumTotValorIVA = A180sumTotValorIVA;
                     n180sumTotValorIVA = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                     O179sumTotValor = A179sumTotValor;
                     n179sumTotValor = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                     O174sumTotCant = A174sumTotCant;
                     n174sumTotCant = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                     O175sumTotNeto = A175sumTotNeto;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
                     O181TotNeto = A181TotNeto;
                     n181TotNeto = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
                  }
                  ScanEnd0E29( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E56 */
                     pr_default.execute(30, new Object[] {A1EmpID, A34CotiID});
                     pr_default.close(30);
                     dsDefault.SmartCacheProvider.SetUpdated("Cotizador") ;
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
         sMode28 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0E28( ) ;
         Gx_mode = sMode28;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0E28( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV19Pgmname = "Cotizador";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
            /* Using cursor T000E57 */
            pr_default.execute(31, new Object[] {A1EmpID});
            A44empdsc = T000E57_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000E57_n44empdsc[0];
            pr_default.close(31);
            /* Using cursor T000E61 */
            pr_default.execute(32, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(32) != 101) )
            {
               A176sumTotNeto1 = T000E61_A176sumTotNeto1[0];
               n176sumTotNeto1 = T000E61_n176sumTotNeto1[0];
            }
            else
            {
               A176sumTotNeto1 = 0;
               n176sumTotNeto1 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            }
            pr_default.close(32);
            /* Using cursor T000E64 */
            pr_default.execute(33, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(33) != 101) )
            {
               A180sumTotValorIVA = T000E64_A180sumTotValorIVA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
               n180sumTotValorIVA = T000E64_n180sumTotValorIVA[0];
            }
            else
            {
               A180sumTotValorIVA = 0;
               n180sumTotValorIVA = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            }
            pr_default.close(33);
            /* Using cursor T000E66 */
            pr_default.execute(34, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(34) != 101) )
            {
               A177ObrSubtotal = T000E66_A177ObrSubtotal[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               n177ObrSubtotal = T000E66_n177ObrSubtotal[0];
            }
            else
            {
               A177ObrSubtotal = 0;
               n177ObrSubtotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            }
            pr_default.close(34);
            A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            /* Using cursor T000E68 */
            pr_default.execute(35, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(35) != 101) )
            {
               A174sumTotCant = T000E68_A174sumTotCant[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
               n174sumTotCant = T000E68_n174sumTotCant[0];
            }
            else
            {
               A174sumTotCant = 0;
               n174sumTotCant = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            }
            pr_default.close(35);
            /* Using cursor T000E70 */
            pr_default.execute(36, new Object[] {A1EmpID, A34CotiID});
            if ( (pr_default.getStatus(36) != 101) )
            {
               A179sumTotValor = T000E70_A179sumTotValor[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
               n179sumTotValor = T000E70_n179sumTotValor[0];
            }
            else
            {
               A179sumTotValor = 0;
               n179sumTotValor = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            }
            pr_default.close(36);
            /* Using cursor T000E71 */
            pr_default.execute(37, new Object[] {A1EmpID, A10protID});
            A74protDsc = T000E71_A74protDsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74protDsc", A74protDsc);
            n74protDsc = T000E71_n74protDsc[0];
            pr_default.close(37);
         }
      }

      protected void ProcessNestedLevel0E29( )
      {
         s156CotiUltNro = O156CotiUltNro;
         n156CotiUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
         s176sumTotNeto1 = O176sumTotNeto1;
         n176sumTotNeto1 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         s180sumTotValorIVA = O180sumTotValorIVA;
         n180sumTotValorIVA = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         s179sumTotValor = O179sumTotValor;
         n179sumTotValor = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         s174sumTotCant = O174sumTotCant;
         n174sumTotCant = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         s175sumTotNeto = O175sumTotNeto;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         s181TotNeto = O181TotNeto;
         n181TotNeto = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         nGXsfl_74_idx = 0;
         while ( nGXsfl_74_idx < nRC_GXsfl_74 )
         {
            ReadRow0E29( ) ;
            if ( ( nRcdExists_29 != 0 ) || ( nIsMod_29 != 0 ) )
            {
               standaloneNotModal0E29( ) ;
               GetKey0E29( ) ;
               if ( ( nRcdExists_29 == 0 ) && ( nRcdDeleted_29 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0E29( ) ;
               }
               else
               {
                  if ( RcdFound29 != 0 )
                  {
                     if ( ( nRcdDeleted_29 != 0 ) && ( nRcdExists_29 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0E29( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_29 != 0 ) && ( nRcdExists_29 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0E29( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_29 == 0 )
                     {
                        GXCCtl = "SECID_" + sGXsfl_74_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtsecID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O156CotiUltNro = A156CotiUltNro;
               n156CotiUltNro = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
               O176sumTotNeto1 = A176sumTotNeto1;
               n176sumTotNeto1 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
               O180sumTotValorIVA = A180sumTotValorIVA;
               n180sumTotValorIVA = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
               O179sumTotValor = A179sumTotValor;
               n179sumTotValor = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
               O174sumTotCant = A174sumTotCant;
               n174sumTotCant = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
               O175sumTotNeto = A175sumTotNeto;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
               O181TotNeto = A181TotNeto;
               n181TotNeto = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
            }
            ChangePostValue( edtsecID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A35secID), 4, 0, ",", ""))) ;
            ChangePostValue( edtdetTipoProdID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ",", ""))) ;
            ChangePostValue( edtcategID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ",", ""))) ;
            ChangePostValue( edtsubCatID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( edtsubCatDsc_Internalname, StringUtil.RTrim( A148subCatDsc)) ;
            ChangePostValue( edtsubCatPrec_Internalname, StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", ""))) ;
            ChangePostValue( edtCotiDetCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A157CotiDetCant, 10, 2, ",", ""))) ;
            ChangePostValue( edtCotiDetValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A158CotiDetValor, 10, 2, ",", ""))) ;
            ChangePostValue( edtCotiDetIva_Internalname, StringUtil.LTrim( StringUtil.NToC( A159CotiDetIva, 5, 2, ",", ""))) ;
            ChangePostValue( edtCotiDetTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A160CotiDetTotal, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z35secID_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z35secID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z157CotiDetCant_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( Z157CotiDetCant, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z36detTipoProdID_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36detTipoProdID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z32categID_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( "T160CotiDetTotal_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( O160CotiDetTotal, 10, 2, ",", ""))) ;
            ChangePostValue( "T159CotiDetIva_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( O159CotiDetIva, 5, 2, ",", ""))) ;
            ChangePostValue( "T158CotiDetValor_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( O158CotiDetValor, 10, 2, ",", ""))) ;
            ChangePostValue( "T157CotiDetCant_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( O157CotiDetCant, 10, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_29_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_29), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_29_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_29), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_29_"+sGXsfl_74_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_29), 4, 0, ",", ""))) ;
            if ( nIsMod_29 != 0 )
            {
               ChangePostValue( "SECID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsecID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETTIPOPRODID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetTipoProdID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CATEGID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDSC_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPREC_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COTIDETCANT_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COTIDETVALOR_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetValor_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COTIDETIVA_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetIva_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "COTIDETTOTAL_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetTotal_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0E29( ) ;
         if ( AnyError != 0 )
         {
            O156CotiUltNro = s156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            O176sumTotNeto1 = s176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            O180sumTotValorIVA = s180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            O179sumTotValor = s179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            O174sumTotCant = s174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            O175sumTotNeto = s175sumTotNeto;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            O181TotNeto = s181TotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         }
         nRcdExists_29 = 0;
         nIsMod_29 = 0;
         nRcdDeleted_29 = 0;
      }

      protected void ProcessNestedLevel0E30( )
      {
         s177ObrSubtotal = O177ObrSubtotal;
         n177ObrSubtotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         s175sumTotNeto = O175sumTotNeto;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         s181TotNeto = O181TotNeto;
         n181TotNeto = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         nGXsfl_90_idx = 0;
         while ( nGXsfl_90_idx < nRC_GXsfl_90 )
         {
            ReadRow0E30( ) ;
            if ( ( nRcdExists_30 != 0 ) || ( nIsMod_30 != 0 ) )
            {
               standaloneNotModal0E30( ) ;
               GetKey0E30( ) ;
               if ( ( nRcdExists_30 == 0 ) && ( nRcdDeleted_30 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0E30( ) ;
               }
               else
               {
                  if ( RcdFound30 != 0 )
                  {
                     if ( ( nRcdDeleted_30 != 0 ) && ( nRcdExists_30 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0E30( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_30 != 0 ) && ( nRcdExists_30 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0E30( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_30 == 0 )
                     {
                        GXCCtl = "NROSEC_" + sGXsfl_90_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtnroSec_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O177ObrSubtotal = A177ObrSubtotal;
               n177ObrSubtotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               O175sumTotNeto = A175sumTotNeto;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
               O181TotNeto = A181TotNeto;
               n181TotNeto = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
            }
            ChangePostValue( edtnroSec_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A38nroSec), 4, 0, ",", ""))) ;
            ChangePostValue( edtObrDsc_Internalname, A202ObrDsc) ;
            ChangePostValue( edtObrValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A178ObrValor, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z38nroSec_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38nroSec), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z202ObrDsc_"+sGXsfl_90_idx, Z202ObrDsc) ;
            ChangePostValue( "ZT_"+"Z178ObrValor_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z178ObrValor, 10, 2, ",", ""))) ;
            ChangePostValue( "T178ObrValor_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( O178ObrValor, 10, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_30_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_30), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_30_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_30), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_30_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_30), 4, 0, ",", ""))) ;
            if ( nIsMod_30 != 0 )
            {
               ChangePostValue( "NROSEC_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnroSec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OBRDSC_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObrDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OBRVALOR_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObrValor_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0E30( ) ;
         if ( AnyError != 0 )
         {
            O177ObrSubtotal = s177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            O175sumTotNeto = s175sumTotNeto;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            O181TotNeto = s181TotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         }
         nRcdExists_30 = 0;
         nIsMod_30 = 0;
         nRcdDeleted_30 = 0;
      }

      protected void ProcessLevel0E28( )
      {
         /* Save parent mode. */
         sMode28 = Gx_mode;
         ProcessNestedLevel0E29( ) ;
         ProcessNestedLevel0E30( ) ;
         if ( AnyError != 0 )
         {
            O156CotiUltNro = s156CotiUltNro;
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
            O176sumTotNeto1 = s176sumTotNeto1;
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            O180sumTotValorIVA = s180sumTotValorIVA;
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            O179sumTotValor = s179sumTotValor;
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            O174sumTotCant = s174sumTotCant;
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            O175sumTotNeto = s175sumTotNeto;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            O181TotNeto = s181TotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
            O177ObrSubtotal = s177ObrSubtotal;
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            O175sumTotNeto = s175sumTotNeto;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            O181TotNeto = s181TotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode28;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T000E72 */
         pr_default.execute(38, new Object[] {n156CotiUltNro, A156CotiUltNro, n181TotNeto, A181TotNeto, A1EmpID, A34CotiID});
         pr_default.close(38);
         dsDefault.SmartCacheProvider.SetUpdated("Cotizador") ;
      }

      protected void EndLevel0E28( )
      {
         pr_default.close(8);
         if ( AnyError == 0 )
         {
            BeforeComplete0E28( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(31);
            pr_default.close(37);
            pr_default.close(32);
            pr_default.close(33);
            pr_default.close(34);
            pr_default.close(35);
            pr_default.close(36);
            pr_default.close(7);
            pr_default.close(4);
            pr_default.close(5);
            pr_default.close(6);
            context.CommitDataStores("cotizador",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0E0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(31);
            pr_default.close(37);
            pr_default.close(32);
            pr_default.close(33);
            pr_default.close(34);
            pr_default.close(35);
            pr_default.close(36);
            pr_default.close(7);
            pr_default.close(4);
            pr_default.close(5);
            pr_default.close(6);
            context.RollbackDataStores("cotizador",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0E28( )
      {
         /* Scan By routine */
         /* Using cursor T000E73 */
         pr_default.execute(39);
         RcdFound28 = 0;
         if ( (pr_default.getStatus(39) != 101) )
         {
            RcdFound28 = 1;
            A1EmpID = T000E73_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A34CotiID = T000E73_A34CotiID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0E28( )
      {
         /* Scan next routine */
         pr_default.readNext(39);
         RcdFound28 = 0;
         if ( (pr_default.getStatus(39) != 101) )
         {
            RcdFound28 = 1;
            A1EmpID = T000E73_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A34CotiID = T000E73_A34CotiID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
         }
      }

      protected void ScanEnd0E28( )
      {
         pr_default.close(39);
      }

      protected void AfterConfirm0E28( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0E28( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0E28( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0E28( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0E28( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0E28( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0E28( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtCotiID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiID_Enabled), 5, 0)), true);
         edtCotiDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiDsc_Enabled), 5, 0)), true);
         edtprotID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprotID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprotID_Enabled), 5, 0)), true);
         edtprotDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtprotDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtprotDsc_Enabled), 5, 0)), true);
         edtCotiIVA_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiIVA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiIVA_Enabled), 5, 0)), true);
         edtCotiUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiUltNro_Enabled), 5, 0)), true);
         edtCotiObs_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiObs_Enabled), 5, 0)), true);
         edtObrSubtotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObrSubtotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObrSubtotal_Enabled), 5, 0)), true);
         edtsumTotCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsumTotCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsumTotCant_Enabled), 5, 0)), true);
         edtsumTotValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsumTotValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsumTotValor_Enabled), 5, 0)), true);
         edtsumTotValorIVA_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsumTotValorIVA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsumTotValorIVA_Enabled), 5, 0)), true);
         edtsumTotNeto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsumTotNeto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsumTotNeto_Enabled), 5, 0)), true);
      }

      protected void ZM0E29( short GX_JID )
      {
         if ( ( GX_JID == 38 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z157CotiDetCant = T000E5_A157CotiDetCant[0];
               Z36detTipoProdID = T000E5_A36detTipoProdID[0];
               Z32categID = T000E5_A32categID[0];
               Z33subCatID = T000E5_A33subCatID[0];
            }
            else
            {
               Z157CotiDetCant = A157CotiDetCant;
               Z36detTipoProdID = A36detTipoProdID;
               Z32categID = A32categID;
               Z33subCatID = A33subCatID;
            }
         }
         if ( GX_JID == -38 )
         {
            Z34CotiID = A34CotiID;
            Z35secID = A35secID;
            Z157CotiDetCant = A157CotiDetCant;
            Z1EmpID = A1EmpID;
            Z36detTipoProdID = A36detTipoProdID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            Z146categDsc = A146categDsc;
            Z148subCatDsc = A148subCatDsc;
            Z150subCatPrec = A150subCatPrec;
         }
      }

      protected void standaloneNotModal0E29( )
      {
         edtCotiUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiUltNro_Enabled), 5, 0)), true);
         edtCotiUltNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiUltNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiUltNro_Enabled), 5, 0)), true);
      }

      protected void standaloneModal0E29( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A156CotiUltNro = (int)(O156CotiUltNro+1);
            n156CotiUltNro = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A35secID = (short)(A156CotiUltNro);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtsecID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsecID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsecID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         }
         else
         {
            edtsecID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsecID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsecID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         }
      }

      protected void Load0E29( )
      {
         /* Using cursor T000E74 */
         pr_default.execute(40, new Object[] {A34CotiID, A35secID, A1EmpID});
         if ( (pr_default.getStatus(40) != 101) )
         {
            RcdFound29 = 1;
            A146categDsc = T000E74_A146categDsc[0];
            n146categDsc = T000E74_n146categDsc[0];
            A148subCatDsc = T000E74_A148subCatDsc[0];
            n148subCatDsc = T000E74_n148subCatDsc[0];
            A150subCatPrec = T000E74_A150subCatPrec[0];
            n150subCatPrec = T000E74_n150subCatPrec[0];
            A157CotiDetCant = T000E74_A157CotiDetCant[0];
            n157CotiDetCant = T000E74_n157CotiDetCant[0];
            A36detTipoProdID = T000E74_A36detTipoProdID[0];
            A32categID = T000E74_A32categID[0];
            A33subCatID = T000E74_A33subCatID[0];
            ZM0E29( -38) ;
         }
         pr_default.close(40);
         OnLoadActions0E29( ) ;
      }

      protected void OnLoadActions0E29( )
      {
         A158CotiDetValor = (decimal)(A150subCatPrec*A157CotiDetCant);
         O158CotiDetValor = A158CotiDetValor;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A179sumTotValor = (decimal)(O179sumTotValor+A158CotiDetValor);
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A179sumTotValor = (decimal)(O179sumTotValor+A158CotiDetValor-O158CotiDetValor);
               n179sumTotValor = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A179sumTotValor = (decimal)(O179sumTotValor-O158CotiDetValor);
                  n179sumTotValor = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
               }
            }
         }
         A159CotiDetIva = (decimal)(((A158CotiDetValor*A155CotiIVA)/ (decimal)(100)));
         n159CotiDetIva = false;
         O159CotiDetIva = A159CotiDetIva;
         n159CotiDetIva = false;
         A160CotiDetTotal = NumberUtil.Round( (A158CotiDetValor+A159CotiDetIva), 2);
         n160CotiDetTotal = false;
         O160CotiDetTotal = A160CotiDetTotal;
         n160CotiDetTotal = false;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A176sumTotNeto1 = (short)(O176sumTotNeto1+A160CotiDetTotal);
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A176sumTotNeto1 = (short)(O176sumTotNeto1+A160CotiDetTotal-O160CotiDetTotal);
               n176sumTotNeto1 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A176sumTotNeto1 = (short)(O176sumTotNeto1-O160CotiDetTotal);
                  n176sumTotNeto1 = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
               }
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A180sumTotValorIVA = (decimal)(O180sumTotValorIVA+A159CotiDetIva);
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A180sumTotValorIVA = (decimal)(O180sumTotValorIVA+A159CotiDetIva-O159CotiDetIva);
               n180sumTotValorIVA = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A180sumTotValorIVA = (decimal)(O180sumTotValorIVA-O159CotiDetIva);
                  n180sumTotValorIVA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
               }
            }
         }
         A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            A181TotNeto = A175sumTotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A174sumTotCant = (decimal)(O174sumTotCant+A157CotiDetCant);
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A174sumTotCant = (decimal)(O174sumTotCant+A157CotiDetCant-O157CotiDetCant);
               n174sumTotCant = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A174sumTotCant = (decimal)(O174sumTotCant-O157CotiDetCant);
                  n174sumTotCant = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
               }
            }
         }
      }

      protected void CheckExtendedTable0E29( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0E29( ) ;
         /* Using cursor T000E6 */
         pr_default.execute(4, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GXCCtl = "DETTIPOPRODID_" + sGXsfl_74_idx;
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetTipoProdID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(4);
         /* Using cursor T000E7 */
         pr_default.execute(5, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_74_idx;
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A146categDsc = T000E7_A146categDsc[0];
         n146categDsc = T000E7_n146categDsc[0];
         pr_default.close(5);
         /* Using cursor T000E8 */
         pr_default.execute(6, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_74_idx;
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A148subCatDsc = T000E8_A148subCatDsc[0];
         n148subCatDsc = T000E8_n148subCatDsc[0];
         A150subCatPrec = T000E8_A150subCatPrec[0];
         n150subCatPrec = T000E8_n150subCatPrec[0];
         pr_default.close(6);
         A158CotiDetValor = (decimal)(A150subCatPrec*A157CotiDetCant);
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A179sumTotValor = (decimal)(O179sumTotValor+A158CotiDetValor);
            n179sumTotValor = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A179sumTotValor = (decimal)(O179sumTotValor+A158CotiDetValor-O158CotiDetValor);
               n179sumTotValor = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A179sumTotValor = (decimal)(O179sumTotValor-O158CotiDetValor);
                  n179sumTotValor = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
               }
            }
         }
         A159CotiDetIva = (decimal)(((A158CotiDetValor*A155CotiIVA)/ (decimal)(100)));
         n159CotiDetIva = false;
         A160CotiDetTotal = NumberUtil.Round( (A158CotiDetValor+A159CotiDetIva), 2);
         n160CotiDetTotal = false;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A176sumTotNeto1 = (short)(O176sumTotNeto1+A160CotiDetTotal);
            n176sumTotNeto1 = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A176sumTotNeto1 = (short)(O176sumTotNeto1+A160CotiDetTotal-O160CotiDetTotal);
               n176sumTotNeto1 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A176sumTotNeto1 = (short)(O176sumTotNeto1-O160CotiDetTotal);
                  n176sumTotNeto1 = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
               }
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A180sumTotValorIVA = (decimal)(O180sumTotValorIVA+A159CotiDetIva);
            n180sumTotValorIVA = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A180sumTotValorIVA = (decimal)(O180sumTotValorIVA+A159CotiDetIva-O159CotiDetIva);
               n180sumTotValorIVA = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A180sumTotValorIVA = (decimal)(O180sumTotValorIVA-O159CotiDetIva);
                  n180sumTotValorIVA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
               }
            }
         }
         A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            A181TotNeto = A175sumTotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A174sumTotCant = (decimal)(O174sumTotCant+A157CotiDetCant);
            n174sumTotCant = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A174sumTotCant = (decimal)(O174sumTotCant+A157CotiDetCant-O157CotiDetCant);
               n174sumTotCant = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A174sumTotCant = (decimal)(O174sumTotCant-O157CotiDetCant);
                  n174sumTotCant = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
               }
            }
         }
      }

      protected void CloseExtendedTableCursors0E29( )
      {
         pr_default.close(7);
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable0E29( )
      {
      }

      protected void gxLoad_39( short A1EmpID ,
                                short A36detTipoProdID )
      {
         /* Using cursor T000E6 */
         pr_default.execute(4, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GXCCtl = "DETTIPOPRODID_" + sGXsfl_74_idx;
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetTipoProdID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void gxLoad_40( short A1EmpID ,
                                short A32categID )
      {
         /* Using cursor T000E75 */
         pr_default.execute(41, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(41) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_74_idx;
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A146categDsc = T000E75_A146categDsc[0];
         n146categDsc = T000E75_n146categDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A146categDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(41) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(41);
      }

      protected void gxLoad_41( short A1EmpID ,
                                short A32categID ,
                                short A33subCatID )
      {
         /* Using cursor T000E76 */
         pr_default.execute(42, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(42) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_74_idx;
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A148subCatDsc = T000E76_A148subCatDsc[0];
         n148subCatDsc = T000E76_n148subCatDsc[0];
         A150subCatPrec = T000E76_A150subCatPrec[0];
         n150subCatPrec = T000E76_n150subCatPrec[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A148subCatDsc))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(42) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(42);
      }

      protected void GetKey0E29( )
      {
         /* Using cursor T000E77 */
         pr_default.execute(43, new Object[] {A1EmpID, A34CotiID, A35secID});
         if ( (pr_default.getStatus(43) != 101) )
         {
            RcdFound29 = 1;
         }
         else
         {
            RcdFound29 = 0;
         }
         pr_default.close(43);
      }

      protected void getByPrimaryKey0E29( )
      {
         /* Using cursor T000E5 */
         pr_default.execute(3, new Object[] {A1EmpID, A34CotiID, A35secID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0E29( 38) ;
            RcdFound29 = 1;
            InitializeNonKey0E29( ) ;
            A35secID = T000E5_A35secID[0];
            A157CotiDetCant = T000E5_A157CotiDetCant[0];
            n157CotiDetCant = T000E5_n157CotiDetCant[0];
            A36detTipoProdID = T000E5_A36detTipoProdID[0];
            A32categID = T000E5_A32categID[0];
            A33subCatID = T000E5_A33subCatID[0];
            O157CotiDetCant = A157CotiDetCant;
            n157CotiDetCant = false;
            Z1EmpID = A1EmpID;
            Z34CotiID = A34CotiID;
            Z35secID = A35secID;
            sMode29 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0E29( ) ;
            Gx_mode = sMode29;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound29 = 0;
            InitializeNonKey0E29( ) ;
            sMode29 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0E29( ) ;
            Gx_mode = sMode29;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0E29( ) ;
         }
         pr_default.close(3);
      }

      protected void CheckOptimisticConcurrency0E29( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000E4 */
            pr_default.execute(2, new Object[] {A1EmpID, A34CotiID, A35secID});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CotizadorLevel1"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( Z157CotiDetCant != T000E4_A157CotiDetCant[0] ) || ( Z36detTipoProdID != T000E4_A36detTipoProdID[0] ) || ( Z32categID != T000E4_A32categID[0] ) || ( Z33subCatID != T000E4_A33subCatID[0] ) )
            {
               if ( Z157CotiDetCant != T000E4_A157CotiDetCant[0] )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"CotiDetCant");
                  GXUtil.WriteLogRaw("Old: ",Z157CotiDetCant);
                  GXUtil.WriteLogRaw("Current: ",T000E4_A157CotiDetCant[0]);
               }
               if ( Z36detTipoProdID != T000E4_A36detTipoProdID[0] )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"detTipoProdID");
                  GXUtil.WriteLogRaw("Old: ",Z36detTipoProdID);
                  GXUtil.WriteLogRaw("Current: ",T000E4_A36detTipoProdID[0]);
               }
               if ( Z32categID != T000E4_A32categID[0] )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"categID");
                  GXUtil.WriteLogRaw("Old: ",Z32categID);
                  GXUtil.WriteLogRaw("Current: ",T000E4_A32categID[0]);
               }
               if ( Z33subCatID != T000E4_A33subCatID[0] )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"subCatID");
                  GXUtil.WriteLogRaw("Old: ",Z33subCatID);
                  GXUtil.WriteLogRaw("Current: ",T000E4_A33subCatID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CotizadorLevel1"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0E29( )
      {
         BeforeValidate0E29( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E29( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0E29( 0) ;
            CheckOptimisticConcurrency0E29( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E29( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0E29( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E78 */
                     pr_default.execute(44, new Object[] {A34CotiID, A35secID, n157CotiDetCant, A157CotiDetCant, A1EmpID, A36detTipoProdID, A32categID, A33subCatID});
                     pr_default.close(44);
                     dsDefault.SmartCacheProvider.SetUpdated("CotizadorLevel1") ;
                     if ( (pr_default.getStatus(44) == 1) )
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
               Load0E29( ) ;
            }
            EndLevel0E29( ) ;
         }
         CloseExtendedTableCursors0E29( ) ;
      }

      protected void Update0E29( )
      {
         BeforeValidate0E29( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E29( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E29( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E29( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0E29( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E79 */
                     pr_default.execute(45, new Object[] {n157CotiDetCant, A157CotiDetCant, A36detTipoProdID, A32categID, A33subCatID, A1EmpID, A34CotiID, A35secID});
                     pr_default.close(45);
                     dsDefault.SmartCacheProvider.SetUpdated("CotizadorLevel1") ;
                     if ( (pr_default.getStatus(45) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CotizadorLevel1"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0E29( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0E29( ) ;
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
            EndLevel0E29( ) ;
         }
         CloseExtendedTableCursors0E29( ) ;
      }

      protected void DeferredUpdate0E29( )
      {
      }

      protected void Delete0E29( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0E29( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E29( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0E29( ) ;
            AfterConfirm0E29( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0E29( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000E80 */
                  pr_default.execute(46, new Object[] {A1EmpID, A34CotiID, A35secID});
                  pr_default.close(46);
                  dsDefault.SmartCacheProvider.SetUpdated("CotizadorLevel1") ;
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
         sMode29 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0E29( ) ;
         Gx_mode = sMode29;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0E29( )
      {
         standaloneModal0E29( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000E81 */
            pr_default.execute(47, new Object[] {A1EmpID, A32categID});
            A146categDsc = T000E81_A146categDsc[0];
            n146categDsc = T000E81_n146categDsc[0];
            pr_default.close(47);
            /* Using cursor T000E82 */
            pr_default.execute(48, new Object[] {A1EmpID, A32categID, A33subCatID});
            A148subCatDsc = T000E82_A148subCatDsc[0];
            n148subCatDsc = T000E82_n148subCatDsc[0];
            A150subCatPrec = T000E82_A150subCatPrec[0];
            n150subCatPrec = T000E82_n150subCatPrec[0];
            pr_default.close(48);
            A158CotiDetValor = (decimal)(A150subCatPrec*A157CotiDetCant);
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A179sumTotValor = (decimal)(O179sumTotValor+A158CotiDetValor);
               n179sumTotValor = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A179sumTotValor = (decimal)(O179sumTotValor+A158CotiDetValor-O158CotiDetValor);
                  n179sumTotValor = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A179sumTotValor = (decimal)(O179sumTotValor-O158CotiDetValor);
                     n179sumTotValor = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
                  }
               }
            }
            A159CotiDetIva = (decimal)(((A158CotiDetValor*A155CotiIVA)/ (decimal)(100)));
            n159CotiDetIva = false;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A180sumTotValorIVA = (decimal)(O180sumTotValorIVA+A159CotiDetIva);
               n180sumTotValorIVA = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A180sumTotValorIVA = (decimal)(O180sumTotValorIVA+A159CotiDetIva-O159CotiDetIva);
                  n180sumTotValorIVA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A180sumTotValorIVA = (decimal)(O180sumTotValorIVA-O159CotiDetIva);
                     n180sumTotValorIVA = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
                  }
               }
            }
            A160CotiDetTotal = NumberUtil.Round( (A158CotiDetValor+A159CotiDetIva), 2);
            n160CotiDetTotal = false;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A176sumTotNeto1 = (short)(O176sumTotNeto1+A160CotiDetTotal);
               n176sumTotNeto1 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A176sumTotNeto1 = (short)(O176sumTotNeto1+A160CotiDetTotal-O160CotiDetTotal);
                  n176sumTotNeto1 = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A176sumTotNeto1 = (short)(O176sumTotNeto1-O160CotiDetTotal);
                     n176sumTotNeto1 = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
                  }
               }
            }
            A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A181TotNeto = A175sumTotNeto;
               n181TotNeto = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A174sumTotCant = (decimal)(O174sumTotCant+A157CotiDetCant);
               n174sumTotCant = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A174sumTotCant = (decimal)(O174sumTotCant+A157CotiDetCant-O157CotiDetCant);
                  n174sumTotCant = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A174sumTotCant = (decimal)(O174sumTotCant-O157CotiDetCant);
                     n174sumTotCant = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
                  }
               }
            }
         }
      }

      protected void EndLevel0E29( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(2);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0E29( )
      {
         /* Scan By routine */
         /* Using cursor T000E83 */
         pr_default.execute(49, new Object[] {A34CotiID, A1EmpID});
         RcdFound29 = 0;
         if ( (pr_default.getStatus(49) != 101) )
         {
            RcdFound29 = 1;
            A35secID = T000E83_A35secID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0E29( )
      {
         /* Scan next routine */
         pr_default.readNext(49);
         RcdFound29 = 0;
         if ( (pr_default.getStatus(49) != 101) )
         {
            RcdFound29 = 1;
            A35secID = T000E83_A35secID[0];
         }
      }

      protected void ScanEnd0E29( )
      {
         pr_default.close(49);
      }

      protected void AfterConfirm0E29( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0E29( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0E29( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0E29( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0E29( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0E29( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0E29( )
      {
         edtsecID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsecID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsecID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         edtdetTipoProdID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtdetTipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtdetTipoProdID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         edtcategID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         edtsubCatID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         edtsubCatDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDsc_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         edtsubCatPrec_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPrec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPrec_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         edtCotiDetCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiDetCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiDetCant_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         edtCotiDetValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiDetValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiDetValor_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         edtCotiDetIva_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiDetIva_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiDetIva_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
         edtCotiDetTotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCotiDetTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCotiDetTotal_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
      }

      protected void send_integrity_lvl_hashes0E29( )
      {
      }

      protected void ZM0E30( short GX_JID )
      {
         if ( ( GX_JID == 43 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z202ObrDsc = T000E3_A202ObrDsc[0];
               Z178ObrValor = T000E3_A178ObrValor[0];
            }
            else
            {
               Z202ObrDsc = A202ObrDsc;
               Z178ObrValor = A178ObrValor;
            }
         }
         if ( GX_JID == -43 )
         {
            Z1EmpID = A1EmpID;
            Z34CotiID = A34CotiID;
            Z38nroSec = A38nroSec;
            Z202ObrDsc = A202ObrDsc;
            Z178ObrValor = A178ObrValor;
         }
      }

      protected void standaloneNotModal0E30( )
      {
      }

      protected void standaloneModal0E30( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtnroSec_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnroSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnroSec_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
         }
         else
         {
            edtnroSec_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnroSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnroSec_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
         }
      }

      protected void Load0E30( )
      {
         /* Using cursor T000E84 */
         pr_default.execute(50, new Object[] {A1EmpID, A34CotiID, A38nroSec});
         if ( (pr_default.getStatus(50) != 101) )
         {
            RcdFound30 = 1;
            A202ObrDsc = T000E84_A202ObrDsc[0];
            n202ObrDsc = T000E84_n202ObrDsc[0];
            A178ObrValor = T000E84_A178ObrValor[0];
            n178ObrValor = T000E84_n178ObrValor[0];
            ZM0E30( -43) ;
         }
         pr_default.close(50);
         OnLoadActions0E30( ) ;
      }

      protected void OnLoadActions0E30( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A177ObrSubtotal = (decimal)(O177ObrSubtotal+A178ObrValor);
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A177ObrSubtotal = (decimal)(O177ObrSubtotal+A178ObrValor-O178ObrValor);
               n177ObrSubtotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A177ObrSubtotal = (decimal)(O177ObrSubtotal-O178ObrValor);
                  n177ObrSubtotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               }
            }
         }
         A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            A181TotNeto = A175sumTotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         }
      }

      protected void CheckExtendedTable0E30( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0E30( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A177ObrSubtotal = (decimal)(O177ObrSubtotal+A178ObrValor);
            n177ObrSubtotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A177ObrSubtotal = (decimal)(O177ObrSubtotal+A178ObrValor-O178ObrValor);
               n177ObrSubtotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A177ObrSubtotal = (decimal)(O177ObrSubtotal-O178ObrValor);
                  n177ObrSubtotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               }
            }
         }
         A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            A181TotNeto = A175sumTotNeto;
            n181TotNeto = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         }
      }

      protected void CloseExtendedTableCursors0E30( )
      {
      }

      protected void enableDisable0E30( )
      {
      }

      protected void GetKey0E30( )
      {
         /* Using cursor T000E85 */
         pr_default.execute(51, new Object[] {A1EmpID, A34CotiID, A38nroSec});
         if ( (pr_default.getStatus(51) != 101) )
         {
            RcdFound30 = 1;
         }
         else
         {
            RcdFound30 = 0;
         }
         pr_default.close(51);
      }

      protected void getByPrimaryKey0E30( )
      {
         /* Using cursor T000E3 */
         pr_default.execute(1, new Object[] {A1EmpID, A34CotiID, A38nroSec});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0E30( 43) ;
            RcdFound30 = 1;
            InitializeNonKey0E30( ) ;
            A38nroSec = T000E3_A38nroSec[0];
            A202ObrDsc = T000E3_A202ObrDsc[0];
            n202ObrDsc = T000E3_n202ObrDsc[0];
            A178ObrValor = T000E3_A178ObrValor[0];
            n178ObrValor = T000E3_n178ObrValor[0];
            O178ObrValor = A178ObrValor;
            n178ObrValor = false;
            Z1EmpID = A1EmpID;
            Z34CotiID = A34CotiID;
            Z38nroSec = A38nroSec;
            sMode30 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0E30( ) ;
            Gx_mode = sMode30;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound30 = 0;
            InitializeNonKey0E30( ) ;
            sMode30 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0E30( ) ;
            Gx_mode = sMode30;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0E30( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0E30( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000E2 */
            pr_default.execute(0, new Object[] {A1EmpID, A34CotiID, A38nroSec});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CotizadorObreros"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z202ObrDsc, T000E2_A202ObrDsc[0]) != 0 ) || ( Z178ObrValor != T000E2_A178ObrValor[0] ) )
            {
               if ( StringUtil.StrCmp(Z202ObrDsc, T000E2_A202ObrDsc[0]) != 0 )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"ObrDsc");
                  GXUtil.WriteLogRaw("Old: ",Z202ObrDsc);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A202ObrDsc[0]);
               }
               if ( Z178ObrValor != T000E2_A178ObrValor[0] )
               {
                  GXUtil.WriteLog("cotizador:[seudo value changed for attri]"+"ObrValor");
                  GXUtil.WriteLogRaw("Old: ",Z178ObrValor);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A178ObrValor[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CotizadorObreros"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0E30( )
      {
         BeforeValidate0E30( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E30( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0E30( 0) ;
            CheckOptimisticConcurrency0E30( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E30( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0E30( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E86 */
                     pr_default.execute(52, new Object[] {A1EmpID, A34CotiID, A38nroSec, n202ObrDsc, A202ObrDsc, n178ObrValor, A178ObrValor});
                     pr_default.close(52);
                     dsDefault.SmartCacheProvider.SetUpdated("CotizadorObreros") ;
                     if ( (pr_default.getStatus(52) == 1) )
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
               Load0E30( ) ;
            }
            EndLevel0E30( ) ;
         }
         CloseExtendedTableCursors0E30( ) ;
      }

      protected void Update0E30( )
      {
         BeforeValidate0E30( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E30( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E30( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E30( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0E30( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E87 */
                     pr_default.execute(53, new Object[] {n202ObrDsc, A202ObrDsc, n178ObrValor, A178ObrValor, A1EmpID, A34CotiID, A38nroSec});
                     pr_default.close(53);
                     dsDefault.SmartCacheProvider.SetUpdated("CotizadorObreros") ;
                     if ( (pr_default.getStatus(53) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CotizadorObreros"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0E30( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0E30( ) ;
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
            EndLevel0E30( ) ;
         }
         CloseExtendedTableCursors0E30( ) ;
      }

      protected void DeferredUpdate0E30( )
      {
      }

      protected void Delete0E30( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0E30( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E30( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0E30( ) ;
            AfterConfirm0E30( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0E30( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000E88 */
                  pr_default.execute(54, new Object[] {A1EmpID, A34CotiID, A38nroSec});
                  pr_default.close(54);
                  dsDefault.SmartCacheProvider.SetUpdated("CotizadorObreros") ;
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
         sMode30 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0E30( ) ;
         Gx_mode = sMode30;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0E30( )
      {
         standaloneModal0E30( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A177ObrSubtotal = (decimal)(O177ObrSubtotal+A178ObrValor);
               n177ObrSubtotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A177ObrSubtotal = (decimal)(O177ObrSubtotal+A178ObrValor-O178ObrValor);
                  n177ObrSubtotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A177ObrSubtotal = (decimal)(O177ObrSubtotal-O178ObrValor);
                     n177ObrSubtotal = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
                  }
               }
            }
            A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A181TotNeto = A175sumTotNeto;
               n181TotNeto = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
            }
         }
      }

      protected void EndLevel0E30( )
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

      public void ScanStart0E30( )
      {
         /* Scan By routine */
         /* Using cursor T000E89 */
         pr_default.execute(55, new Object[] {A1EmpID, A34CotiID});
         RcdFound30 = 0;
         if ( (pr_default.getStatus(55) != 101) )
         {
            RcdFound30 = 1;
            A38nroSec = T000E89_A38nroSec[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0E30( )
      {
         /* Scan next routine */
         pr_default.readNext(55);
         RcdFound30 = 0;
         if ( (pr_default.getStatus(55) != 101) )
         {
            RcdFound30 = 1;
            A38nroSec = T000E89_A38nroSec[0];
         }
      }

      protected void ScanEnd0E30( )
      {
         pr_default.close(55);
      }

      protected void AfterConfirm0E30( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0E30( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0E30( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0E30( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0E30( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0E30( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0E30( )
      {
         edtnroSec_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnroSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnroSec_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
         edtObrDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObrDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObrDsc_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
         edtObrValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObrValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObrValor_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
      }

      protected void send_integrity_lvl_hashes0E30( )
      {
      }

      protected void send_integrity_lvl_hashes0E28( )
      {
      }

      protected void SubsflControlProps_7429( )
      {
         edtsecID_Internalname = "SECID_"+sGXsfl_74_idx;
         edtdetTipoProdID_Internalname = "DETTIPOPRODID_"+sGXsfl_74_idx;
         imgprompt_36_Internalname = "PROMPT_36_"+sGXsfl_74_idx;
         edtcategID_Internalname = "CATEGID_"+sGXsfl_74_idx;
         imgprompt_32_Internalname = "PROMPT_32_"+sGXsfl_74_idx;
         edtsubCatID_Internalname = "SUBCATID_"+sGXsfl_74_idx;
         imgprompt_33_Internalname = "PROMPT_33_"+sGXsfl_74_idx;
         edtsubCatDsc_Internalname = "SUBCATDSC_"+sGXsfl_74_idx;
         edtsubCatPrec_Internalname = "SUBCATPREC_"+sGXsfl_74_idx;
         edtCotiDetCant_Internalname = "COTIDETCANT_"+sGXsfl_74_idx;
         edtCotiDetValor_Internalname = "COTIDETVALOR_"+sGXsfl_74_idx;
         edtCotiDetIva_Internalname = "COTIDETIVA_"+sGXsfl_74_idx;
         edtCotiDetTotal_Internalname = "COTIDETTOTAL_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_7429( )
      {
         edtsecID_Internalname = "SECID_"+sGXsfl_74_fel_idx;
         edtdetTipoProdID_Internalname = "DETTIPOPRODID_"+sGXsfl_74_fel_idx;
         imgprompt_36_Internalname = "PROMPT_36_"+sGXsfl_74_fel_idx;
         edtcategID_Internalname = "CATEGID_"+sGXsfl_74_fel_idx;
         imgprompt_32_Internalname = "PROMPT_32_"+sGXsfl_74_fel_idx;
         edtsubCatID_Internalname = "SUBCATID_"+sGXsfl_74_fel_idx;
         imgprompt_33_Internalname = "PROMPT_33_"+sGXsfl_74_fel_idx;
         edtsubCatDsc_Internalname = "SUBCATDSC_"+sGXsfl_74_fel_idx;
         edtsubCatPrec_Internalname = "SUBCATPREC_"+sGXsfl_74_fel_idx;
         edtCotiDetCant_Internalname = "COTIDETCANT_"+sGXsfl_74_fel_idx;
         edtCotiDetValor_Internalname = "COTIDETVALOR_"+sGXsfl_74_fel_idx;
         edtCotiDetIva_Internalname = "COTIDETIVA_"+sGXsfl_74_fel_idx;
         edtCotiDetTotal_Internalname = "COTIDETTOTAL_"+sGXsfl_74_fel_idx;
      }

      protected void AddRow0E29( )
      {
         nGXsfl_74_idx = (short)(nGXsfl_74_idx+1);
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         SubsflControlProps_7429( ) ;
         SendRow0E29( ) ;
      }

      protected void SendRow0E29( )
      {
         GridcotizadordetRow = GXWebRow.GetNew(context);
         if ( subGridcotizadordet_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcotizadordet_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridcotizadordet_Class, "") != 0 )
            {
               subGridcotizadordet_Linesclass = subGridcotizadordet_Class+"Odd";
            }
         }
         else if ( subGridcotizadordet_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcotizadordet_Backstyle = 0;
            subGridcotizadordet_Backcolor = subGridcotizadordet_Allbackcolor;
            if ( StringUtil.StrCmp(subGridcotizadordet_Class, "") != 0 )
            {
               subGridcotizadordet_Linesclass = subGridcotizadordet_Class+"Uniform";
            }
         }
         else if ( subGridcotizadordet_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcotizadordet_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridcotizadordet_Class, "") != 0 )
            {
               subGridcotizadordet_Linesclass = subGridcotizadordet_Class+"Odd";
            }
            subGridcotizadordet_Backcolor = (int)(0x0);
         }
         else if ( subGridcotizadordet_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcotizadordet_Backstyle = 1;
            if ( ((int)(((nGXsfl_74_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridcotizadordet_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcotizadordet_Class, "") != 0 )
               {
                  subGridcotizadordet_Linesclass = subGridcotizadordet_Class+"Odd";
               }
            }
            else
            {
               subGridcotizadordet_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcotizadordet_Class, "") != 0 )
               {
                  subGridcotizadordet_Linesclass = subGridcotizadordet_Class+"Even";
               }
            }
         }
         imgprompt_33_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00r2.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CATEGID_"+sGXsfl_74_idx+"'), id:'"+"CATEGID_"+sGXsfl_74_idx+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"SUBCATID_"+sGXsfl_74_idx+"'), id:'"+"SUBCATID_"+sGXsfl_74_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_29_"+sGXsfl_74_idx+","+"'', false"+","+"false"+");");
         imgprompt_32_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00q1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CATEGID_"+sGXsfl_74_idx+"'), id:'"+"CATEGID_"+sGXsfl_74_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_29_"+sGXsfl_74_idx+","+"'', false"+","+"false"+");");
         imgprompt_36_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00p1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"DETTIPOPRODID_"+sGXsfl_74_idx+"'), id:'"+"DETTIPOPRODID_"+sGXsfl_74_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_29_"+sGXsfl_74_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_29_" + sGXsfl_74_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_74_idx + "',74)\"";
         ROClassString = "Attribute";
         GridcotizadordetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsecID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A35secID), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A35secID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsecID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsecID_Enabled,(short)1,(String)"number",(String)"1",(short)80,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_29_" + sGXsfl_74_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_74_idx + "',74)\"";
         ROClassString = "Attribute";
         GridcotizadordetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtdetTipoProdID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ",", "")),((edtdetTipoProdID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A36detTipoProdID), "ZZZ9")) : context.localUtil.Format( (decimal)(A36detTipoProdID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtdetTipoProdID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtdetTipoProdID_Enabled,(short)0,(String)"number",(String)"1",(short)80,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GridcotizadordetRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_36_Internalname,(String)sImgUrl,(String)imgprompt_36_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_36_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_29_" + sGXsfl_74_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_74_idx + "',74)\"";
         ROClassString = "Attribute";
         GridcotizadordetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcategID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ",", "")),((edtcategID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A32categID), "ZZZ9")) : context.localUtil.Format( (decimal)(A32categID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcategID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtcategID_Enabled,(short)0,(String)"number",(String)"1",(short)80,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GridcotizadordetRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_32_Internalname,(String)sImgUrl,(String)imgprompt_32_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_32_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_29_" + sGXsfl_74_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 78,'',false,'" + sGXsfl_74_idx + "',74)\"";
         ROClassString = "Attribute";
         GridcotizadordetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", "")),((edtsubCatID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A33subCatID), "ZZZ9")) : context.localUtil.Format( (decimal)(A33subCatID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatID_Enabled,(short)0,(String)"number",(String)"1",(short)80,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GridcotizadordetRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_33_Internalname,(String)sImgUrl,(String)imgprompt_33_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_33_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GridcotizadordetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatDsc_Internalname,StringUtil.RTrim( A148subCatDsc),StringUtil.RTrim( context.localUtil.Format( A148subCatDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GridcotizadordetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatPrec_Internalname,StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", "")),((edtsubCatPrec_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")) : context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatPrec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatPrec_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_29_" + sGXsfl_74_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 81,'',false,'" + sGXsfl_74_idx + "',74)\"";
         ROClassString = "Attribute";
         GridcotizadordetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCotiDetCant_Internalname,StringUtil.LTrim( StringUtil.NToC( A157CotiDetCant, 10, 2, ",", "")),((edtCotiDetCant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A157CotiDetCant, "ZZZZZZ9.99")) : context.localUtil.Format( A157CotiDetCant, "ZZZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCotiDetCant_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCotiDetCant_Enabled,(short)0,(String)"text",(String)"",(short)80,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GridcotizadordetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCotiDetValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A158CotiDetValor, 10, 2, ",", "")),((edtCotiDetValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A158CotiDetValor, "ZZZZZZ9.99")) : context.localUtil.Format( A158CotiDetValor, "ZZZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCotiDetValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCotiDetValor_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GridcotizadordetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCotiDetIva_Internalname,StringUtil.LTrim( StringUtil.NToC( A159CotiDetIva, 5, 2, ",", "")),((edtCotiDetIva_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A159CotiDetIva, "Z9.99")) : context.localUtil.Format( A159CotiDetIva, "Z9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCotiDetIva_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCotiDetIva_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GridcotizadordetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCotiDetTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A160CotiDetTotal, 10, 2, ",", "")),((edtCotiDetTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A160CotiDetTotal, "ZZZZZZ9.99")) : context.localUtil.Format( A160CotiDetTotal, "ZZZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCotiDetTotal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCotiDetTotal_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(GridcotizadordetRow);
         send_integrity_lvl_hashes0E29( ) ;
         GXCCtl = "Z35secID_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z35secID), 4, 0, ",", "")));
         GXCCtl = "Z157CotiDetCant_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z157CotiDetCant, 10, 2, ",", "")));
         GXCCtl = "Z36detTipoProdID_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36detTipoProdID), 4, 0, ",", "")));
         GXCCtl = "Z32categID_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", "")));
         GXCCtl = "Z33subCatID_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", "")));
         GXCCtl = "O160CotiDetTotal_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O160CotiDetTotal, 10, 2, ",", "")));
         GXCCtl = "O159CotiDetIva_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O159CotiDetIva, 5, 2, ",", "")));
         GXCCtl = "O158CotiDetValor_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O158CotiDetValor, 10, 2, ",", "")));
         GXCCtl = "O157CotiDetCant_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O157CotiDetCant, 10, 2, ",", "")));
         GXCCtl = "nRcdDeleted_29_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_29), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_29_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_29), 4, 0, ",", "")));
         GXCCtl = "nIsMod_29_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_29), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_74_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV11TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8EmpID), 4, 0, ",", "")));
         GXCCtl = "vCOTIID_" + sGXsfl_74_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CotiID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "SECID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsecID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETTIPOPRODID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtdetTipoProdID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CATEGID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATID_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATDSC_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATPREC_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "COTIDETCANT_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetCant_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "COTIDETVALOR_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetValor_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "COTIDETIVA_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetIva_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "COTIDETTOTAL_"+sGXsfl_74_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCotiDetTotal_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_36_"+sGXsfl_74_idx+"Link", StringUtil.RTrim( imgprompt_36_Link));
         GxWebStd.gx_hidden_field( context, "PROMPT_32_"+sGXsfl_74_idx+"Link", StringUtil.RTrim( imgprompt_32_Link));
         GxWebStd.gx_hidden_field( context, "PROMPT_33_"+sGXsfl_74_idx+"Link", StringUtil.RTrim( imgprompt_33_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         GridcotizadordetContainer.AddRow(GridcotizadordetRow);
      }

      protected void ReadRow0E29( )
      {
         nGXsfl_74_idx = (short)(nGXsfl_74_idx+1);
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         SubsflControlProps_7429( ) ;
         edtsecID_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECID_"+sGXsfl_74_idx+"Enabled"), ",", "."));
         edtdetTipoProdID_Enabled = (int)(context.localUtil.CToN( cgiGet( "DETTIPOPRODID_"+sGXsfl_74_idx+"Enabled"), ",", "."));
         edtcategID_Enabled = (int)(context.localUtil.CToN( cgiGet( "CATEGID_"+sGXsfl_74_idx+"Enabled"), ",", "."));
         edtsubCatID_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATID_"+sGXsfl_74_idx+"Enabled"), ",", "."));
         edtsubCatDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDSC_"+sGXsfl_74_idx+"Enabled"), ",", "."));
         edtsubCatPrec_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPREC_"+sGXsfl_74_idx+"Enabled"), ",", "."));
         edtCotiDetCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "COTIDETCANT_"+sGXsfl_74_idx+"Enabled"), ",", "."));
         edtCotiDetValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "COTIDETVALOR_"+sGXsfl_74_idx+"Enabled"), ",", "."));
         edtCotiDetIva_Enabled = (int)(context.localUtil.CToN( cgiGet( "COTIDETIVA_"+sGXsfl_74_idx+"Enabled"), ",", "."));
         edtCotiDetTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "COTIDETTOTAL_"+sGXsfl_74_idx+"Enabled"), ",", "."));
         imgprompt_1_Link = cgiGet( "PROMPT_36_"+sGXsfl_74_idx+"Link");
         imgprompt_1_Link = cgiGet( "PROMPT_32_"+sGXsfl_74_idx+"Link");
         imgprompt_1_Link = cgiGet( "PROMPT_33_"+sGXsfl_74_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtsecID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtsecID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SECID_" + sGXsfl_74_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtsecID_Internalname;
            wbErr = true;
            A35secID = 0;
         }
         else
         {
            A35secID = (short)(context.localUtil.CToN( cgiGet( edtsecID_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtdetTipoProdID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtdetTipoProdID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "DETTIPOPRODID_" + sGXsfl_74_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtdetTipoProdID_Internalname;
            wbErr = true;
            A36detTipoProdID = 0;
         }
         else
         {
            A36detTipoProdID = (short)(context.localUtil.CToN( cgiGet( edtdetTipoProdID_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtcategID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcategID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_74_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
            wbErr = true;
            A32categID = 0;
         }
         else
         {
            A32categID = (short)(context.localUtil.CToN( cgiGet( edtcategID_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SUBCATID_" + sGXsfl_74_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtsubCatID_Internalname;
            wbErr = true;
            A33subCatID = 0;
         }
         else
         {
            A33subCatID = (short)(context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", "."));
         }
         A148subCatDsc = StringUtil.Upper( cgiGet( edtsubCatDsc_Internalname));
         n148subCatDsc = false;
         A150subCatPrec = context.localUtil.CToN( cgiGet( edtsubCatPrec_Internalname), ",", ".");
         n150subCatPrec = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtCotiDetCant_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCotiDetCant_Internalname), ",", ".") > 9999999.99m ) ) )
         {
            GXCCtl = "COTIDETCANT_" + sGXsfl_74_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtCotiDetCant_Internalname;
            wbErr = true;
            A157CotiDetCant = 0;
            n157CotiDetCant = false;
         }
         else
         {
            A157CotiDetCant = context.localUtil.CToN( cgiGet( edtCotiDetCant_Internalname), ",", ".");
            n157CotiDetCant = false;
         }
         n157CotiDetCant = ((Convert.ToDecimal(0)==A157CotiDetCant) ? true : false);
         A158CotiDetValor = context.localUtil.CToN( cgiGet( edtCotiDetValor_Internalname), ",", ".");
         A159CotiDetIva = context.localUtil.CToN( cgiGet( edtCotiDetIva_Internalname), ",", ".");
         n159CotiDetIva = false;
         A160CotiDetTotal = context.localUtil.CToN( cgiGet( edtCotiDetTotal_Internalname), ",", ".");
         n160CotiDetTotal = false;
         GXCCtl = "Z35secID_" + sGXsfl_74_idx;
         Z35secID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z157CotiDetCant_" + sGXsfl_74_idx;
         Z157CotiDetCant = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n157CotiDetCant = ((Convert.ToDecimal(0)==A157CotiDetCant) ? true : false);
         GXCCtl = "Z36detTipoProdID_" + sGXsfl_74_idx;
         Z36detTipoProdID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z32categID_" + sGXsfl_74_idx;
         Z32categID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z33subCatID_" + sGXsfl_74_idx;
         Z33subCatID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "O160CotiDetTotal_" + sGXsfl_74_idx;
         O160CotiDetTotal = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         GXCCtl = "O159CotiDetIva_" + sGXsfl_74_idx;
         O159CotiDetIva = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         GXCCtl = "O158CotiDetValor_" + sGXsfl_74_idx;
         O158CotiDetValor = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         GXCCtl = "O157CotiDetCant_" + sGXsfl_74_idx;
         O157CotiDetCant = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n157CotiDetCant = ((Convert.ToDecimal(0)==A157CotiDetCant) ? true : false);
         GXCCtl = "nRcdDeleted_29_" + sGXsfl_74_idx;
         nRcdDeleted_29 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_29_" + sGXsfl_74_idx;
         nRcdExists_29 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_29_" + sGXsfl_74_idx;
         nIsMod_29 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void SubsflControlProps_9030( )
      {
         edtnroSec_Internalname = "NROSEC_"+sGXsfl_90_idx;
         edtObrDsc_Internalname = "OBRDSC_"+sGXsfl_90_idx;
         edtObrValor_Internalname = "OBRVALOR_"+sGXsfl_90_idx;
      }

      protected void SubsflControlProps_fel_9030( )
      {
         edtnroSec_Internalname = "NROSEC_"+sGXsfl_90_fel_idx;
         edtObrDsc_Internalname = "OBRDSC_"+sGXsfl_90_fel_idx;
         edtObrValor_Internalname = "OBRVALOR_"+sGXsfl_90_fel_idx;
      }

      protected void AddRow0E30( )
      {
         nGXsfl_90_idx = (short)(nGXsfl_90_idx+1);
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
         SubsflControlProps_9030( ) ;
         SendRow0E30( ) ;
      }

      protected void SendRow0E30( )
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
            if ( ((int)(((nGXsfl_90_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_30_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 91,'',false,'" + sGXsfl_90_idx + "',90)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtnroSec_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A38nroSec), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A38nroSec), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtnroSec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtnroSec_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_30_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 92,'',false,'" + sGXsfl_90_idx + "',90)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObrDsc_Internalname,(String)A202ObrDsc,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,92);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtObrDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtObrDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_30_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 93,'',false,'" + sGXsfl_90_idx + "',90)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObrValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A178ObrValor, 10, 2, ",", "")),((edtObrValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A178ObrValor, "ZZZZZZ9.99")) : context.localUtil.Format( A178ObrValor, "ZZZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,93);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtObrValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtObrValor_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)90,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Grid1Row);
         send_integrity_lvl_hashes0E30( ) ;
         GXCCtl = "Z38nroSec_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38nroSec), 4, 0, ",", "")));
         GXCCtl = "Z202ObrDsc_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z202ObrDsc);
         GXCCtl = "Z178ObrValor_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z178ObrValor, 10, 2, ",", "")));
         GXCCtl = "O178ObrValor_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O178ObrValor, 10, 2, ",", "")));
         GXCCtl = "nRcdDeleted_30_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_30), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_30_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_30), 4, 0, ",", "")));
         GXCCtl = "nIsMod_30_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_30), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_90_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV11TrnContext);
         }
         GXCCtl = "vEMPID_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8EmpID), 4, 0, ",", "")));
         GXCCtl = "vCOTIID_" + sGXsfl_90_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CotiID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "NROSEC_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnroSec_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OBRDSC_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObrDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OBRVALOR_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObrValor_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Grid1Container.AddRow(Grid1Row);
      }

      protected void ReadRow0E30( )
      {
         nGXsfl_90_idx = (short)(nGXsfl_90_idx+1);
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
         SubsflControlProps_9030( ) ;
         edtnroSec_Enabled = (int)(context.localUtil.CToN( cgiGet( "NROSEC_"+sGXsfl_90_idx+"Enabled"), ",", "."));
         edtObrDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "OBRDSC_"+sGXsfl_90_idx+"Enabled"), ",", "."));
         edtObrValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "OBRVALOR_"+sGXsfl_90_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtnroSec_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtnroSec_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "NROSEC_" + sGXsfl_90_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtnroSec_Internalname;
            wbErr = true;
            A38nroSec = 0;
         }
         else
         {
            A38nroSec = (short)(context.localUtil.CToN( cgiGet( edtnroSec_Internalname), ",", "."));
         }
         A202ObrDsc = cgiGet( edtObrDsc_Internalname);
         n202ObrDsc = false;
         n202ObrDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A202ObrDsc)) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtObrValor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtObrValor_Internalname), ",", ".") > 9999999.99m ) ) )
         {
            GXCCtl = "OBRVALOR_" + sGXsfl_90_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtObrValor_Internalname;
            wbErr = true;
            A178ObrValor = 0;
            n178ObrValor = false;
         }
         else
         {
            A178ObrValor = context.localUtil.CToN( cgiGet( edtObrValor_Internalname), ",", ".");
            n178ObrValor = false;
         }
         n178ObrValor = ((Convert.ToDecimal(0)==A178ObrValor) ? true : false);
         GXCCtl = "Z38nroSec_" + sGXsfl_90_idx;
         Z38nroSec = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z202ObrDsc_" + sGXsfl_90_idx;
         Z202ObrDsc = cgiGet( GXCCtl);
         n202ObrDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A202ObrDsc)) ? true : false);
         GXCCtl = "Z178ObrValor_" + sGXsfl_90_idx;
         Z178ObrValor = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n178ObrValor = ((Convert.ToDecimal(0)==A178ObrValor) ? true : false);
         GXCCtl = "O178ObrValor_" + sGXsfl_90_idx;
         O178ObrValor = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n178ObrValor = ((Convert.ToDecimal(0)==A178ObrValor) ? true : false);
         GXCCtl = "nRcdDeleted_30_" + sGXsfl_90_idx;
         nRcdDeleted_30 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_30_" + sGXsfl_90_idx;
         nRcdExists_30 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_30_" + sGXsfl_90_idx;
         nIsMod_30 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtnroSec_Enabled = edtnroSec_Enabled;
         defedtsecID_Enabled = edtsecID_Enabled;
      }

      protected void ConfirmValues0E0( )
      {
         nGXsfl_74_idx = 0;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         SubsflControlProps_7429( ) ;
         while ( nGXsfl_74_idx < nRC_GXsfl_74 )
         {
            nGXsfl_74_idx = (short)(nGXsfl_74_idx+1);
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_7429( ) ;
            ChangePostValue( "Z35secID_"+sGXsfl_74_idx, cgiGet( "ZT_"+"Z35secID_"+sGXsfl_74_idx)) ;
            DeletePostValue( "ZT_"+"Z35secID_"+sGXsfl_74_idx) ;
            ChangePostValue( "Z157CotiDetCant_"+sGXsfl_74_idx, cgiGet( "ZT_"+"Z157CotiDetCant_"+sGXsfl_74_idx)) ;
            DeletePostValue( "ZT_"+"Z157CotiDetCant_"+sGXsfl_74_idx) ;
            ChangePostValue( "Z36detTipoProdID_"+sGXsfl_74_idx, cgiGet( "ZT_"+"Z36detTipoProdID_"+sGXsfl_74_idx)) ;
            DeletePostValue( "ZT_"+"Z36detTipoProdID_"+sGXsfl_74_idx) ;
            ChangePostValue( "Z32categID_"+sGXsfl_74_idx, cgiGet( "ZT_"+"Z32categID_"+sGXsfl_74_idx)) ;
            DeletePostValue( "ZT_"+"Z32categID_"+sGXsfl_74_idx) ;
            ChangePostValue( "Z33subCatID_"+sGXsfl_74_idx, cgiGet( "ZT_"+"Z33subCatID_"+sGXsfl_74_idx)) ;
            DeletePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_74_idx) ;
         }
         nGXsfl_90_idx = 0;
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
         SubsflControlProps_9030( ) ;
         while ( nGXsfl_90_idx < nRC_GXsfl_90 )
         {
            nGXsfl_90_idx = (short)(nGXsfl_90_idx+1);
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
            SubsflControlProps_9030( ) ;
            ChangePostValue( "Z38nroSec_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z38nroSec_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z38nroSec_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z202ObrDsc_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z202ObrDsc_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z202ObrDsc_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z178ObrValor_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z178ObrValor_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z178ObrValor_"+sGXsfl_90_idx) ;
         }
         ChangePostValue( "O160CotiDetTotal", cgiGet( "T160CotiDetTotal")) ;
         DeletePostValue( "T160CotiDetTotal") ;
         ChangePostValue( "O159CotiDetIva", cgiGet( "T159CotiDetIva")) ;
         DeletePostValue( "T159CotiDetIva") ;
         ChangePostValue( "O158CotiDetValor", cgiGet( "T158CotiDetValor")) ;
         DeletePostValue( "T158CotiDetValor") ;
         ChangePostValue( "O157CotiDetCant", cgiGet( "T157CotiDetCant")) ;
         DeletePostValue( "T157CotiDetCant") ;
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
         context.SendWebValue( "Cotizador") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022111922531984", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("cotizador.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV8EmpID) + "," + UrlEncode("" +AV7CotiID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Cotizador";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV9Insert_protID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A201CotiUltNroObr), "ZZZZZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("cotizador:[SendSecurityCheck value for]"+"Insert_protID:"+context.localUtil.Format( (decimal)(AV9Insert_protID), "ZZZ9"));
         GXUtil.WriteLog("cotizador:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("cotizador:[SendSecurityCheck value for]"+"CotiUltNroObr:"+context.localUtil.Format( (decimal)(A201CotiUltNroObr), "ZZZZZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z34CotiID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34CotiID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z181TotNeto", StringUtil.LTrim( StringUtil.NToC( Z181TotNeto, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z154CotiDsc", Z154CotiDsc);
         GxWebStd.gx_hidden_field( context, "Z155CotiIVA", StringUtil.LTrim( StringUtil.NToC( Z155CotiIVA, 8, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z156CotiUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z156CotiUltNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z201CotiUltNroObr", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z201CotiUltNroObr), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z182CotiObs", Z182CotiObs);
         GxWebStd.gx_hidden_field( context, "Z10protID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10protID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O177ObrSubtotal", StringUtil.LTrim( StringUtil.NToC( O177ObrSubtotal, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "O156CotiUltNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(O156CotiUltNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O176sumTotNeto1", StringUtil.LTrim( StringUtil.NToC( (decimal)(O176sumTotNeto1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O180sumTotValorIVA", StringUtil.LTrim( StringUtil.NToC( O180sumTotValorIVA, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "O179sumTotValor", StringUtil.LTrim( StringUtil.NToC( O179sumTotValor, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "O174sumTotCant", StringUtil.LTrim( StringUtil.NToC( O174sumTotCant, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_74_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_90", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_90_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N10protID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "SUMTOTNETO1", StringUtil.LTrim( StringUtil.NToC( (decimal)(A176sumTotNeto1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vEMPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vCOTIID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CotiID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCOTIID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CotiID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_PROTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9Insert_protID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TOTNETO", StringUtil.LTrim( StringUtil.NToC( A181TotNeto, 10, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "COTIULTNROOBR", StringUtil.LTrim( StringUtil.NToC( (decimal)(A201CotiUltNroObr), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV19Pgmname));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "CATEGDSC", StringUtil.RTrim( A146categDsc));
         GxWebStd.gx_hidden_field( context, "TIPOPRODID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31tipoProdID), 4, 0, ",", "")));
      }

      protected void RenderHtmlCloseForm0E28( )
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
         return "Cotizador" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cotizador" ;
      }

      protected void InitializeNonKey0E28( )
      {
         A10protID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
         A181TotNeto = 0;
         n181TotNeto = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TotNeto", StringUtil.LTrim( StringUtil.Str( A181TotNeto, 10, 2)));
         A175sumTotNeto = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175sumTotNeto", StringUtil.LTrim( StringUtil.Str( A175sumTotNeto, 10, 2)));
         A176sumTotNeto1 = 0;
         n176sumTotNeto1 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         A180sumTotValorIVA = 0;
         n180sumTotValorIVA = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A154CotiDsc = "";
         n154CotiDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154CotiDsc", A154CotiDsc);
         n154CotiDsc = (String.IsNullOrEmpty(StringUtil.RTrim( A154CotiDsc)) ? true : false);
         A74protDsc = "";
         n74protDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74protDsc", A74protDsc);
         A155CotiIVA = 0;
         n155CotiIVA = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155CotiIVA", StringUtil.LTrim( StringUtil.Str( A155CotiIVA, 8, 3)));
         n155CotiIVA = ((Convert.ToDecimal(0)==A155CotiIVA) ? true : false);
         A156CotiUltNro = 0;
         n156CotiUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
         n156CotiUltNro = ((0==A156CotiUltNro) ? true : false);
         A201CotiUltNroObr = 0;
         n201CotiUltNroObr = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201CotiUltNroObr", StringUtil.LTrim( StringUtil.Str( (decimal)(A201CotiUltNroObr), 8, 0)));
         A182CotiObs = "";
         n182CotiObs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182CotiObs", A182CotiObs);
         n182CotiObs = (String.IsNullOrEmpty(StringUtil.RTrim( A182CotiObs)) ? true : false);
         A177ObrSubtotal = 0;
         n177ObrSubtotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         A174sumTotCant = 0;
         n174sumTotCant = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         A179sumTotValor = 0;
         n179sumTotValor = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         O177ObrSubtotal = A177ObrSubtotal;
         n177ObrSubtotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177ObrSubtotal", StringUtil.LTrim( StringUtil.Str( A177ObrSubtotal, 10, 2)));
         O156CotiUltNro = A156CotiUltNro;
         n156CotiUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
         O176sumTotNeto1 = A176sumTotNeto1;
         n176sumTotNeto1 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176sumTotNeto1", StringUtil.LTrim( StringUtil.Str( (decimal)(A176sumTotNeto1), 4, 0)));
         O180sumTotValorIVA = A180sumTotValorIVA;
         n180sumTotValorIVA = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180sumTotValorIVA", StringUtil.LTrim( StringUtil.Str( A180sumTotValorIVA, 10, 2)));
         O179sumTotValor = A179sumTotValor;
         n179sumTotValor = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179sumTotValor", StringUtil.LTrim( StringUtil.Str( A179sumTotValor, 10, 2)));
         O174sumTotCant = A174sumTotCant;
         n174sumTotCant = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174sumTotCant", StringUtil.LTrim( StringUtil.Str( A174sumTotCant, 10, 2)));
         Z181TotNeto = 0;
         Z154CotiDsc = "";
         Z155CotiIVA = 0;
         Z156CotiUltNro = 0;
         Z201CotiUltNroObr = 0;
         Z182CotiObs = "";
         Z10protID = 0;
      }

      protected void InitAll0E28( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A34CotiID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
         InitializeNonKey0E28( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0E29( )
      {
         A31tipoProdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
         A158CotiDetValor = 0;
         A36detTipoProdID = 0;
         A32categID = 0;
         A146categDsc = "";
         n146categDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A146categDsc", A146categDsc);
         A33subCatID = 0;
         A148subCatDsc = "";
         n148subCatDsc = false;
         A150subCatPrec = 0;
         n150subCatPrec = false;
         A157CotiDetCant = 0;
         n157CotiDetCant = false;
         A159CotiDetIva = 0;
         n159CotiDetIva = false;
         A160CotiDetTotal = 0;
         n160CotiDetTotal = false;
         O160CotiDetTotal = A160CotiDetTotal;
         n160CotiDetTotal = false;
         O159CotiDetIva = A159CotiDetIva;
         n159CotiDetIva = false;
         O158CotiDetValor = A158CotiDetValor;
         O157CotiDetCant = A157CotiDetCant;
         n157CotiDetCant = false;
         Z157CotiDetCant = 0;
         Z36detTipoProdID = 0;
         Z32categID = 0;
         Z33subCatID = 0;
      }

      protected void InitAll0E29( )
      {
         A35secID = 0;
         InitializeNonKey0E29( ) ;
      }

      protected void StandaloneModalInsert0E29( )
      {
         A156CotiUltNro = i156CotiUltNro;
         n156CotiUltNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156CotiUltNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A156CotiUltNro), 8, 0)));
      }

      protected void InitializeNonKey0E30( )
      {
         A202ObrDsc = "";
         n202ObrDsc = false;
         A178ObrValor = 0;
         n178ObrValor = false;
         O178ObrValor = A178ObrValor;
         n178ObrValor = false;
         Z202ObrDsc = "";
         Z178ObrValor = 0;
      }

      protected void InitAll0E30( )
      {
         A38nroSec = 0;
         InitializeNonKey0E30( ) ;
      }

      protected void StandaloneModalInsert0E30( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2022111922532014", true);
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
         context.AddJavascriptSource("cotizador.js", "?2022111922532016", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties29( )
      {
         edtsecID_Enabled = defedtsecID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsecID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsecID_Enabled), 5, 0)), !bGXsfl_74_Refreshing);
      }

      protected void init_level_properties30( )
      {
         edtnroSec_Enabled = defedtnroSec_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnroSec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnroSec_Enabled), 5, 0)), !bGXsfl_90_Refreshing);
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtEmpID_Internalname = "EMPID";
         edtempdsc_Internalname = "EMPDSC";
         edtCotiID_Internalname = "COTIID";
         edtCotiDsc_Internalname = "COTIDSC";
         edtprotID_Internalname = "PROTID";
         edtprotDsc_Internalname = "PROTDSC";
         edtCotiIVA_Internalname = "COTIIVA";
         edtCotiUltNro_Internalname = "COTIULTNRO";
         edtCotiObs_Internalname = "COTIOBS";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         edtsecID_Internalname = "SECID";
         edtdetTipoProdID_Internalname = "DETTIPOPRODID";
         edtcategID_Internalname = "CATEGID";
         edtsubCatID_Internalname = "SUBCATID";
         edtsubCatDsc_Internalname = "SUBCATDSC";
         edtsubCatPrec_Internalname = "SUBCATPREC";
         edtCotiDetCant_Internalname = "COTIDETCANT";
         edtCotiDetValor_Internalname = "COTIDETVALOR";
         edtCotiDetIva_Internalname = "COTIDETIVA";
         edtCotiDetTotal_Internalname = "COTIDETTOTAL";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         edtnroSec_Internalname = "NROSEC";
         edtObrDsc_Internalname = "OBRDSC";
         edtObrValor_Internalname = "OBRVALOR";
         edtObrSubtotal_Internalname = "OBRSUBTOTAL";
         divTbsubtobra_Internalname = "TBSUBTOBRA";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         edtsumTotCant_Internalname = "SUMTOTCANT";
         divSection4_Internalname = "SECTION4";
         edtsumTotValor_Internalname = "SUMTOTVALOR";
         divSection5_Internalname = "SECTION5";
         edtsumTotValorIVA_Internalname = "SUMTOTVALORIVA";
         divSection1_Internalname = "SECTION1";
         edtsumTotNeto_Internalname = "SUMTOTNETO";
         divSection2_Internalname = "SECTION2";
         divTable1_Internalname = "TABLE1";
         divDettable_Internalname = "DETTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttButton1_Internalname = "BUTTON1";
         bttButton2_Internalname = "BUTTON2";
         divLayout1_Internalname = "LAYOUT1";
         divMaintable1_Internalname = "MAINTABLE1";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_10_Internalname = "PROMPT_10";
         imgprompt_36_Internalname = "PROMPT_36";
         imgprompt_32_Internalname = "PROMPT_32";
         imgprompt_33_Internalname = "PROMPT_33";
         subGridcotizadordet_Internalname = "GRIDCOTIZADORDET";
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
         edtObrValor_Jsonclick = "";
         edtObrDsc_Jsonclick = "";
         edtnroSec_Jsonclick = "";
         subGrid1_Class = "Grid";
         subGrid1_Backcolorstyle = 0;
         edtCotiDetTotal_Jsonclick = "";
         edtCotiDetIva_Jsonclick = "";
         edtCotiDetValor_Jsonclick = "";
         edtCotiDetCant_Jsonclick = "";
         edtsubCatPrec_Jsonclick = "";
         edtsubCatDsc_Jsonclick = "";
         imgprompt_33_Visible = 1;
         imgprompt_33_Link = "";
         edtsubCatID_Jsonclick = "";
         imgprompt_32_Visible = 1;
         imgprompt_32_Link = "";
         edtcategID_Jsonclick = "";
         imgprompt_36_Visible = 1;
         imgprompt_36_Link = "";
         imgprompt_1_Visible = 1;
         edtdetTipoProdID_Jsonclick = "";
         edtsecID_Jsonclick = "";
         subGridcotizadordet_Class = "GridDataOPCustom";
         subGridcotizadordet_Backcolorstyle = 0;
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtObrValor_Enabled = 1;
         edtObrDsc_Enabled = 1;
         edtnroSec_Enabled = 1;
         subGrid1_Header = "";
         subGridcotizadordet_Allowcollapsing = 0;
         subGridcotizadordet_Allowselection = 0;
         edtCotiDetTotal_Enabled = 0;
         edtCotiDetIva_Enabled = 0;
         edtCotiDetValor_Enabled = 0;
         edtCotiDetCant_Enabled = 1;
         edtsubCatPrec_Enabled = 0;
         edtsubCatDsc_Enabled = 0;
         edtsubCatID_Enabled = 1;
         edtcategID_Enabled = 1;
         edtdetTipoProdID_Enabled = 1;
         edtsecID_Enabled = 1;
         subGridcotizadordet_Header = "";
         bttButton2_Visible = 1;
         bttButton1_Enabled = 1;
         bttButton1_Visible = 1;
         edtsumTotNeto_Jsonclick = "";
         edtsumTotNeto_Enabled = 0;
         edtsumTotValorIVA_Jsonclick = "";
         edtsumTotValorIVA_Enabled = 0;
         edtsumTotValor_Jsonclick = "";
         edtsumTotValor_Enabled = 0;
         edtsumTotCant_Jsonclick = "";
         edtsumTotCant_Enabled = 0;
         edtObrSubtotal_Jsonclick = "";
         edtObrSubtotal_Enabled = 0;
         edtCotiObs_Enabled = 1;
         edtCotiUltNro_Jsonclick = "";
         edtCotiUltNro_Enabled = 0;
         edtCotiIVA_Jsonclick = "";
         edtCotiIVA_Enabled = 1;
         edtprotDsc_Jsonclick = "";
         edtprotDsc_Enabled = 0;
         imgprompt_10_Visible = 1;
         imgprompt_10_Link = "";
         edtprotID_Jsonclick = "";
         edtprotID_Enabled = 1;
         edtCotiDsc_Jsonclick = "";
         edtCotiDsc_Enabled = 1;
         edtCotiID_Jsonclick = "";
         edtCotiID_Enabled = 1;
         edtempdsc_Jsonclick = "";
         edtempdsc_Enabled = 0;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 1;
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

      protected void GX6ASACOTIID0E28( short AV7CotiID ,
                                       short AV8EmpID )
      {
         if ( ! (0==AV7CotiID) )
         {
            A34CotiID = AV7CotiID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A34CotiID;
               new obtultcodcoti(context ).execute(  AV8EmpID, out  GXt_int1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8EmpID), "ZZZ9"), context));
               A34CotiID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34CotiID", StringUtil.LTrim( StringUtil.Str( (decimal)(A34CotiID), 4, 0)));
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A34CotiID), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void gxnrGridcotizadordet_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_7429( ) ;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0E29( ) ;
            standaloneModal0E29( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0E29( ) ;
            nGXsfl_74_idx = (short)(nGXsfl_74_idx+1);
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_7429( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridcotizadordetContainer));
         /* End function gxnrGridcotizadordet_newrow */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_9030( ) ;
         while ( nGXsfl_90_idx <= nRC_GXsfl_90 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0E30( ) ;
            standaloneModal0E30( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0E30( ) ;
            nGXsfl_90_idx = (short)(nGXsfl_90_idx+1);
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0");
            SubsflControlProps_9030( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000E57 */
         pr_default.execute(31, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(31) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000E57_A44empdsc[0];
         n44empdsc = T000E57_n44empdsc[0];
         pr_default.close(31);
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

      public void Valid_Cotiid( String GX_Parm1 ,
                                short GX_Parm2 ,
                                short GX_Parm3 ,
                                short GX_Parm4 ,
                                decimal GX_Parm5 ,
                                decimal GX_Parm6 ,
                                decimal GX_Parm7 ,
                                decimal GX_Parm8 ,
                                decimal GX_Parm9 ,
                                decimal GX_Parm10 )
      {
         Gx_mode = GX_Parm1;
         A1EmpID = GX_Parm2;
         A34CotiID = GX_Parm3;
         A176sumTotNeto1 = GX_Parm4;
         n176sumTotNeto1 = false;
         A177ObrSubtotal = GX_Parm5;
         n177ObrSubtotal = false;
         A175sumTotNeto = GX_Parm6;
         A180sumTotValorIVA = GX_Parm7;
         n180sumTotValorIVA = false;
         A181TotNeto = GX_Parm8;
         n181TotNeto = false;
         A174sumTotCant = GX_Parm9;
         n174sumTotCant = false;
         A179sumTotValor = GX_Parm10;
         n179sumTotValor = false;
         /* Using cursor T000E61 */
         pr_default.execute(32, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(32) != 101) )
         {
            A176sumTotNeto1 = T000E61_A176sumTotNeto1[0];
            n176sumTotNeto1 = T000E61_n176sumTotNeto1[0];
         }
         else
         {
            A176sumTotNeto1 = 0;
            n176sumTotNeto1 = false;
         }
         pr_default.close(32);
         /* Using cursor T000E64 */
         pr_default.execute(33, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(33) != 101) )
         {
            A180sumTotValorIVA = T000E64_A180sumTotValorIVA[0];
            n180sumTotValorIVA = T000E64_n180sumTotValorIVA[0];
         }
         else
         {
            A180sumTotValorIVA = 0;
            n180sumTotValorIVA = false;
         }
         pr_default.close(33);
         /* Using cursor T000E66 */
         pr_default.execute(34, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(34) != 101) )
         {
            A177ObrSubtotal = T000E66_A177ObrSubtotal[0];
            n177ObrSubtotal = T000E66_n177ObrSubtotal[0];
         }
         else
         {
            A177ObrSubtotal = 0;
            n177ObrSubtotal = false;
         }
         pr_default.close(34);
         A175sumTotNeto = (decimal)((A176sumTotNeto1+A177ObrSubtotal));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            A181TotNeto = A175sumTotNeto;
            n181TotNeto = false;
         }
         /* Using cursor T000E68 */
         pr_default.execute(35, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(35) != 101) )
         {
            A174sumTotCant = T000E68_A174sumTotCant[0];
            n174sumTotCant = T000E68_n174sumTotCant[0];
         }
         else
         {
            A174sumTotCant = 0;
            n174sumTotCant = false;
         }
         pr_default.close(35);
         /* Using cursor T000E70 */
         pr_default.execute(36, new Object[] {A1EmpID, A34CotiID});
         if ( (pr_default.getStatus(36) != 101) )
         {
            A179sumTotValor = T000E70_A179sumTotValor[0];
            n179sumTotValor = T000E70_n179sumTotValor[0];
         }
         else
         {
            A179sumTotValor = 0;
            n179sumTotValor = false;
         }
         pr_default.close(36);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A176sumTotNeto1 = 0;
            n176sumTotNeto1 = false;
            A180sumTotValorIVA = 0;
            n180sumTotValorIVA = false;
            A177ObrSubtotal = 0;
            n177ObrSubtotal = false;
            A174sumTotCant = 0;
            n174sumTotCant = false;
            A179sumTotValor = 0;
            n179sumTotValor = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A176sumTotNeto1), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A180sumTotValorIVA, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A177ObrSubtotal, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A175sumTotNeto, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A181TotNeto, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A174sumTotCant, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A179sumTotValor, 10, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Protid( short GX_Parm1 ,
                                short GX_Parm2 ,
                                String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         A10protID = GX_Parm2;
         A74protDsc = GX_Parm3;
         n74protDsc = false;
         /* Using cursor T000E71 */
         pr_default.execute(37, new Object[] {A1EmpID, A10protID});
         if ( (pr_default.getStatus(37) == 101) )
         {
            GX_msglist.addItem("No existe 'Prototipo'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A74protDsc = T000E71_A74protDsc[0];
         n74protDsc = T000E71_n74protDsc[0];
         pr_default.close(37);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A74protDsc = "";
            n74protDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A74protDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Dettipoprodid( short GX_Parm1 ,
                                       short GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A36detTipoProdID = GX_Parm2;
         /* Using cursor T000E90 */
         pr_default.execute(56, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(56) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "DETTIPOPRODID");
            AnyError = 1;
            GX_FocusControl = edtdetTipoProdID_Internalname;
         }
         pr_default.close(56);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Categid( short GX_Parm1 ,
                                 short GX_Parm2 ,
                                 String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         A32categID = GX_Parm2;
         A146categDsc = GX_Parm3;
         n146categDsc = false;
         /* Using cursor T000E81 */
         pr_default.execute(47, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(47) == 101) )
         {
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, "CATEGID");
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
         }
         A146categDsc = T000E81_A146categDsc[0];
         n146categDsc = T000E81_n146categDsc[0];
         pr_default.close(47);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A146categDsc = "";
            n146categDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A146categDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Subcatid( short GX_Parm1 ,
                                  short GX_Parm2 ,
                                  short GX_Parm3 ,
                                  String GX_Parm4 ,
                                  decimal GX_Parm5 )
      {
         A1EmpID = GX_Parm1;
         A32categID = GX_Parm2;
         A33subCatID = GX_Parm3;
         A148subCatDsc = GX_Parm4;
         n148subCatDsc = false;
         A150subCatPrec = GX_Parm5;
         n150subCatPrec = false;
         /* Using cursor T000E82 */
         pr_default.execute(48, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(48) == 101) )
         {
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, "CATEGID");
            AnyError = 1;
            GX_FocusControl = edtcategID_Internalname;
         }
         A148subCatDsc = T000E82_A148subCatDsc[0];
         n148subCatDsc = T000E82_n148subCatDsc[0];
         A150subCatPrec = T000E82_A150subCatPrec[0];
         n150subCatPrec = T000E82_n150subCatPrec[0];
         pr_default.close(48);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A148subCatDsc = "";
            n148subCatDsc = false;
            A150subCatPrec = 0;
            n150subCatPrec = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A148subCatDsc));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ".", "")));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV7CotiID',fld:'vCOTIID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'AV7CotiID',fld:'vCOTIID',pic:'ZZZ9',hsh:true},{av:'AV9Insert_protID',fld:'vINSERT_PROTID',pic:'ZZZ9'},{av:'A201CotiUltNroObr',fld:'COTIULTNROOBR',pic:'ZZZZZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120E2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(3);
         pr_default.close(56);
         pr_default.close(47);
         pr_default.close(48);
         pr_default.close(9);
         pr_default.close(31);
         pr_default.close(37);
         pr_default.close(32);
         pr_default.close(33);
         pr_default.close(34);
         pr_default.close(35);
         pr_default.close(36);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z154CotiDsc = "";
         Z182CotiObs = "";
         Z202ObrDsc = "";
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
         sImgUrl = "";
         A44empdsc = "";
         A154CotiDsc = "";
         A74protDsc = "";
         A182CotiObs = "";
         lblTextblock1_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         bttButton1_Jsonclick = "";
         bttButton2_Jsonclick = "";
         GridcotizadordetContainer = new GXWebGrid( context);
         GridcotizadordetColumn = new GXWebColumn();
         A148subCatDsc = "";
         sMode29 = "";
         sStyleString = "";
         Grid1Container = new GXWebGrid( context);
         Grid1Column = new GXWebColumn();
         A202ObrDsc = "";
         sMode30 = "";
         AV19Pgmname = "";
         A146categDsc = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode28 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV11TrnContext = new SdtTransactionContext(context);
         AV13WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z44empdsc = "";
         Z74protDsc = "";
         T000E12_A44empdsc = new String[] {""} ;
         T000E12_n44empdsc = new bool[] {false} ;
         T000E13_A74protDsc = new String[] {""} ;
         T000E13_n74protDsc = new bool[] {false} ;
         T000E17_A176sumTotNeto1 = new short[1] ;
         T000E17_n176sumTotNeto1 = new bool[] {false} ;
         T000E20_A180sumTotValorIVA = new decimal[1] ;
         T000E20_n180sumTotValorIVA = new bool[] {false} ;
         T000E22_A177ObrSubtotal = new decimal[1] ;
         T000E22_n177ObrSubtotal = new bool[] {false} ;
         T000E24_A174sumTotCant = new decimal[1] ;
         T000E24_n174sumTotCant = new bool[] {false} ;
         T000E26_A179sumTotValor = new decimal[1] ;
         T000E26_n179sumTotValor = new bool[] {false} ;
         T000E35_A34CotiID = new short[1] ;
         T000E35_A181TotNeto = new decimal[1] ;
         T000E35_n181TotNeto = new bool[] {false} ;
         T000E35_A44empdsc = new String[] {""} ;
         T000E35_n44empdsc = new bool[] {false} ;
         T000E35_A154CotiDsc = new String[] {""} ;
         T000E35_n154CotiDsc = new bool[] {false} ;
         T000E35_A74protDsc = new String[] {""} ;
         T000E35_n74protDsc = new bool[] {false} ;
         T000E35_A155CotiIVA = new decimal[1] ;
         T000E35_n155CotiIVA = new bool[] {false} ;
         T000E35_A156CotiUltNro = new int[1] ;
         T000E35_n156CotiUltNro = new bool[] {false} ;
         T000E35_A201CotiUltNroObr = new int[1] ;
         T000E35_n201CotiUltNroObr = new bool[] {false} ;
         T000E35_A182CotiObs = new String[] {""} ;
         T000E35_n182CotiObs = new bool[] {false} ;
         T000E35_A1EmpID = new short[1] ;
         T000E35_A10protID = new short[1] ;
         T000E35_A176sumTotNeto1 = new short[1] ;
         T000E35_n176sumTotNeto1 = new bool[] {false} ;
         T000E35_A180sumTotValorIVA = new decimal[1] ;
         T000E35_n180sumTotValorIVA = new bool[] {false} ;
         T000E35_A177ObrSubtotal = new decimal[1] ;
         T000E35_n177ObrSubtotal = new bool[] {false} ;
         T000E35_A174sumTotCant = new decimal[1] ;
         T000E35_n174sumTotCant = new bool[] {false} ;
         T000E35_A179sumTotValor = new decimal[1] ;
         T000E35_n179sumTotValor = new bool[] {false} ;
         T000E36_A44empdsc = new String[] {""} ;
         T000E36_n44empdsc = new bool[] {false} ;
         T000E37_A74protDsc = new String[] {""} ;
         T000E37_n74protDsc = new bool[] {false} ;
         T000E41_A176sumTotNeto1 = new short[1] ;
         T000E41_n176sumTotNeto1 = new bool[] {false} ;
         T000E44_A180sumTotValorIVA = new decimal[1] ;
         T000E44_n180sumTotValorIVA = new bool[] {false} ;
         T000E46_A177ObrSubtotal = new decimal[1] ;
         T000E46_n177ObrSubtotal = new bool[] {false} ;
         T000E48_A174sumTotCant = new decimal[1] ;
         T000E48_n174sumTotCant = new bool[] {false} ;
         T000E50_A179sumTotValor = new decimal[1] ;
         T000E50_n179sumTotValor = new bool[] {false} ;
         T000E51_A1EmpID = new short[1] ;
         T000E51_A34CotiID = new short[1] ;
         T000E11_A34CotiID = new short[1] ;
         T000E11_A181TotNeto = new decimal[1] ;
         T000E11_n181TotNeto = new bool[] {false} ;
         T000E11_A154CotiDsc = new String[] {""} ;
         T000E11_n154CotiDsc = new bool[] {false} ;
         T000E11_A155CotiIVA = new decimal[1] ;
         T000E11_n155CotiIVA = new bool[] {false} ;
         T000E11_A156CotiUltNro = new int[1] ;
         T000E11_n156CotiUltNro = new bool[] {false} ;
         T000E11_A201CotiUltNroObr = new int[1] ;
         T000E11_n201CotiUltNroObr = new bool[] {false} ;
         T000E11_A182CotiObs = new String[] {""} ;
         T000E11_n182CotiObs = new bool[] {false} ;
         T000E11_A1EmpID = new short[1] ;
         T000E11_A10protID = new short[1] ;
         T000E52_A1EmpID = new short[1] ;
         T000E52_A34CotiID = new short[1] ;
         T000E53_A1EmpID = new short[1] ;
         T000E53_A34CotiID = new short[1] ;
         T000E10_A34CotiID = new short[1] ;
         T000E10_A181TotNeto = new decimal[1] ;
         T000E10_n181TotNeto = new bool[] {false} ;
         T000E10_A154CotiDsc = new String[] {""} ;
         T000E10_n154CotiDsc = new bool[] {false} ;
         T000E10_A155CotiIVA = new decimal[1] ;
         T000E10_n155CotiIVA = new bool[] {false} ;
         T000E10_A156CotiUltNro = new int[1] ;
         T000E10_n156CotiUltNro = new bool[] {false} ;
         T000E10_A201CotiUltNroObr = new int[1] ;
         T000E10_n201CotiUltNroObr = new bool[] {false} ;
         T000E10_A182CotiObs = new String[] {""} ;
         T000E10_n182CotiObs = new bool[] {false} ;
         T000E10_A1EmpID = new short[1] ;
         T000E10_A10protID = new short[1] ;
         T000E57_A44empdsc = new String[] {""} ;
         T000E57_n44empdsc = new bool[] {false} ;
         T000E61_A176sumTotNeto1 = new short[1] ;
         T000E61_n176sumTotNeto1 = new bool[] {false} ;
         T000E64_A180sumTotValorIVA = new decimal[1] ;
         T000E64_n180sumTotValorIVA = new bool[] {false} ;
         T000E66_A177ObrSubtotal = new decimal[1] ;
         T000E66_n177ObrSubtotal = new bool[] {false} ;
         T000E68_A174sumTotCant = new decimal[1] ;
         T000E68_n174sumTotCant = new bool[] {false} ;
         T000E70_A179sumTotValor = new decimal[1] ;
         T000E70_n179sumTotValor = new bool[] {false} ;
         T000E71_A74protDsc = new String[] {""} ;
         T000E71_n74protDsc = new bool[] {false} ;
         T000E73_A1EmpID = new short[1] ;
         T000E73_A34CotiID = new short[1] ;
         Z146categDsc = "";
         Z148subCatDsc = "";
         T000E74_A34CotiID = new short[1] ;
         T000E74_A35secID = new short[1] ;
         T000E74_A146categDsc = new String[] {""} ;
         T000E74_n146categDsc = new bool[] {false} ;
         T000E74_A148subCatDsc = new String[] {""} ;
         T000E74_n148subCatDsc = new bool[] {false} ;
         T000E74_A150subCatPrec = new decimal[1] ;
         T000E74_n150subCatPrec = new bool[] {false} ;
         T000E74_A157CotiDetCant = new decimal[1] ;
         T000E74_n157CotiDetCant = new bool[] {false} ;
         T000E74_A1EmpID = new short[1] ;
         T000E74_A36detTipoProdID = new short[1] ;
         T000E74_A32categID = new short[1] ;
         T000E74_A33subCatID = new short[1] ;
         T000E6_A31tipoProdID = new short[1] ;
         T000E7_A146categDsc = new String[] {""} ;
         T000E7_n146categDsc = new bool[] {false} ;
         T000E8_A148subCatDsc = new String[] {""} ;
         T000E8_n148subCatDsc = new bool[] {false} ;
         T000E8_A150subCatPrec = new decimal[1] ;
         T000E8_n150subCatPrec = new bool[] {false} ;
         T000E75_A146categDsc = new String[] {""} ;
         T000E75_n146categDsc = new bool[] {false} ;
         T000E76_A148subCatDsc = new String[] {""} ;
         T000E76_n148subCatDsc = new bool[] {false} ;
         T000E76_A150subCatPrec = new decimal[1] ;
         T000E76_n150subCatPrec = new bool[] {false} ;
         T000E77_A1EmpID = new short[1] ;
         T000E77_A34CotiID = new short[1] ;
         T000E77_A35secID = new short[1] ;
         T000E5_A34CotiID = new short[1] ;
         T000E5_A35secID = new short[1] ;
         T000E5_A157CotiDetCant = new decimal[1] ;
         T000E5_n157CotiDetCant = new bool[] {false} ;
         T000E5_A1EmpID = new short[1] ;
         T000E5_A36detTipoProdID = new short[1] ;
         T000E5_A32categID = new short[1] ;
         T000E5_A33subCatID = new short[1] ;
         T000E4_A34CotiID = new short[1] ;
         T000E4_A35secID = new short[1] ;
         T000E4_A157CotiDetCant = new decimal[1] ;
         T000E4_n157CotiDetCant = new bool[] {false} ;
         T000E4_A1EmpID = new short[1] ;
         T000E4_A36detTipoProdID = new short[1] ;
         T000E4_A32categID = new short[1] ;
         T000E4_A33subCatID = new short[1] ;
         T000E81_A146categDsc = new String[] {""} ;
         T000E81_n146categDsc = new bool[] {false} ;
         T000E82_A148subCatDsc = new String[] {""} ;
         T000E82_n148subCatDsc = new bool[] {false} ;
         T000E82_A150subCatPrec = new decimal[1] ;
         T000E82_n150subCatPrec = new bool[] {false} ;
         T000E83_A1EmpID = new short[1] ;
         T000E83_A34CotiID = new short[1] ;
         T000E83_A35secID = new short[1] ;
         T000E84_A1EmpID = new short[1] ;
         T000E84_A34CotiID = new short[1] ;
         T000E84_A38nroSec = new short[1] ;
         T000E84_A202ObrDsc = new String[] {""} ;
         T000E84_n202ObrDsc = new bool[] {false} ;
         T000E84_A178ObrValor = new decimal[1] ;
         T000E84_n178ObrValor = new bool[] {false} ;
         T000E85_A1EmpID = new short[1] ;
         T000E85_A34CotiID = new short[1] ;
         T000E85_A38nroSec = new short[1] ;
         T000E3_A1EmpID = new short[1] ;
         T000E3_A34CotiID = new short[1] ;
         T000E3_A38nroSec = new short[1] ;
         T000E3_A202ObrDsc = new String[] {""} ;
         T000E3_n202ObrDsc = new bool[] {false} ;
         T000E3_A178ObrValor = new decimal[1] ;
         T000E3_n178ObrValor = new bool[] {false} ;
         T000E2_A1EmpID = new short[1] ;
         T000E2_A34CotiID = new short[1] ;
         T000E2_A38nroSec = new short[1] ;
         T000E2_A202ObrDsc = new String[] {""} ;
         T000E2_n202ObrDsc = new bool[] {false} ;
         T000E2_A178ObrValor = new decimal[1] ;
         T000E2_n178ObrValor = new bool[] {false} ;
         T000E89_A1EmpID = new short[1] ;
         T000E89_A34CotiID = new short[1] ;
         T000E89_A38nroSec = new short[1] ;
         GridcotizadordetRow = new GXWebRow();
         subGridcotizadordet_Linesclass = "";
         ROClassString = "";
         Grid1Row = new GXWebRow();
         subGrid1_Linesclass = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000E90_A31tipoProdID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cotizador__default(),
            new Object[][] {
                new Object[] {
               T000E2_A1EmpID, T000E2_A34CotiID, T000E2_A38nroSec, T000E2_A202ObrDsc, T000E2_n202ObrDsc, T000E2_A178ObrValor, T000E2_n178ObrValor
               }
               , new Object[] {
               T000E3_A1EmpID, T000E3_A34CotiID, T000E3_A38nroSec, T000E3_A202ObrDsc, T000E3_n202ObrDsc, T000E3_A178ObrValor, T000E3_n178ObrValor
               }
               , new Object[] {
               T000E4_A34CotiID, T000E4_A35secID, T000E4_A157CotiDetCant, T000E4_n157CotiDetCant, T000E4_A1EmpID, T000E4_A36detTipoProdID, T000E4_A32categID, T000E4_A33subCatID
               }
               , new Object[] {
               T000E5_A34CotiID, T000E5_A35secID, T000E5_A157CotiDetCant, T000E5_n157CotiDetCant, T000E5_A1EmpID, T000E5_A36detTipoProdID, T000E5_A32categID, T000E5_A33subCatID
               }
               , new Object[] {
               T000E6_A31tipoProdID
               }
               , new Object[] {
               T000E7_A146categDsc, T000E7_n146categDsc
               }
               , new Object[] {
               T000E8_A148subCatDsc, T000E8_n148subCatDsc, T000E8_A150subCatPrec, T000E8_n150subCatPrec
               }
               , new Object[] {
               T000E9_A31tipoProdID
               }
               , new Object[] {
               T000E10_A34CotiID, T000E10_A181TotNeto, T000E10_n181TotNeto, T000E10_A154CotiDsc, T000E10_n154CotiDsc, T000E10_A155CotiIVA, T000E10_n155CotiIVA, T000E10_A156CotiUltNro, T000E10_n156CotiUltNro, T000E10_A201CotiUltNroObr,
               T000E10_n201CotiUltNroObr, T000E10_A182CotiObs, T000E10_n182CotiObs, T000E10_A1EmpID, T000E10_A10protID
               }
               , new Object[] {
               T000E11_A34CotiID, T000E11_A181TotNeto, T000E11_n181TotNeto, T000E11_A154CotiDsc, T000E11_n154CotiDsc, T000E11_A155CotiIVA, T000E11_n155CotiIVA, T000E11_A156CotiUltNro, T000E11_n156CotiUltNro, T000E11_A201CotiUltNroObr,
               T000E11_n201CotiUltNroObr, T000E11_A182CotiObs, T000E11_n182CotiObs, T000E11_A1EmpID, T000E11_A10protID
               }
               , new Object[] {
               T000E12_A44empdsc, T000E12_n44empdsc
               }
               , new Object[] {
               T000E13_A74protDsc, T000E13_n74protDsc
               }
               , new Object[] {
               T000E17_A176sumTotNeto1, T000E17_n176sumTotNeto1
               }
               , new Object[] {
               T000E20_A180sumTotValorIVA, T000E20_n180sumTotValorIVA
               }
               , new Object[] {
               T000E22_A177ObrSubtotal, T000E22_n177ObrSubtotal
               }
               , new Object[] {
               T000E24_A174sumTotCant, T000E24_n174sumTotCant
               }
               , new Object[] {
               T000E26_A179sumTotValor, T000E26_n179sumTotValor
               }
               , new Object[] {
               T000E35_A34CotiID, T000E35_A181TotNeto, T000E35_n181TotNeto, T000E35_A44empdsc, T000E35_n44empdsc, T000E35_A154CotiDsc, T000E35_n154CotiDsc, T000E35_A74protDsc, T000E35_n74protDsc, T000E35_A155CotiIVA,
               T000E35_n155CotiIVA, T000E35_A156CotiUltNro, T000E35_n156CotiUltNro, T000E35_A201CotiUltNroObr, T000E35_n201CotiUltNroObr, T000E35_A182CotiObs, T000E35_n182CotiObs, T000E35_A1EmpID, T000E35_A10protID, T000E35_A176sumTotNeto1,
               T000E35_n176sumTotNeto1, T000E35_A180sumTotValorIVA, T000E35_n180sumTotValorIVA, T000E35_A177ObrSubtotal, T000E35_n177ObrSubtotal, T000E35_A174sumTotCant, T000E35_n174sumTotCant, T000E35_A179sumTotValor, T000E35_n179sumTotValor
               }
               , new Object[] {
               T000E36_A44empdsc, T000E36_n44empdsc
               }
               , new Object[] {
               T000E37_A74protDsc, T000E37_n74protDsc
               }
               , new Object[] {
               T000E41_A176sumTotNeto1, T000E41_n176sumTotNeto1
               }
               , new Object[] {
               T000E44_A180sumTotValorIVA, T000E44_n180sumTotValorIVA
               }
               , new Object[] {
               T000E46_A177ObrSubtotal, T000E46_n177ObrSubtotal
               }
               , new Object[] {
               T000E48_A174sumTotCant, T000E48_n174sumTotCant
               }
               , new Object[] {
               T000E50_A179sumTotValor, T000E50_n179sumTotValor
               }
               , new Object[] {
               T000E51_A1EmpID, T000E51_A34CotiID
               }
               , new Object[] {
               T000E52_A1EmpID, T000E52_A34CotiID
               }
               , new Object[] {
               T000E53_A1EmpID, T000E53_A34CotiID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000E57_A44empdsc, T000E57_n44empdsc
               }
               , new Object[] {
               T000E61_A176sumTotNeto1, T000E61_n176sumTotNeto1
               }
               , new Object[] {
               T000E64_A180sumTotValorIVA, T000E64_n180sumTotValorIVA
               }
               , new Object[] {
               T000E66_A177ObrSubtotal, T000E66_n177ObrSubtotal
               }
               , new Object[] {
               T000E68_A174sumTotCant, T000E68_n174sumTotCant
               }
               , new Object[] {
               T000E70_A179sumTotValor, T000E70_n179sumTotValor
               }
               , new Object[] {
               T000E71_A74protDsc, T000E71_n74protDsc
               }
               , new Object[] {
               }
               , new Object[] {
               T000E73_A1EmpID, T000E73_A34CotiID
               }
               , new Object[] {
               T000E74_A34CotiID, T000E74_A35secID, T000E74_A146categDsc, T000E74_n146categDsc, T000E74_A148subCatDsc, T000E74_n148subCatDsc, T000E74_A150subCatPrec, T000E74_n150subCatPrec, T000E74_A157CotiDetCant, T000E74_n157CotiDetCant,
               T000E74_A1EmpID, T000E74_A36detTipoProdID, T000E74_A32categID, T000E74_A33subCatID
               }
               , new Object[] {
               T000E75_A146categDsc, T000E75_n146categDsc
               }
               , new Object[] {
               T000E76_A148subCatDsc, T000E76_n148subCatDsc, T000E76_A150subCatPrec, T000E76_n150subCatPrec
               }
               , new Object[] {
               T000E77_A1EmpID, T000E77_A34CotiID, T000E77_A35secID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000E81_A146categDsc, T000E81_n146categDsc
               }
               , new Object[] {
               T000E82_A148subCatDsc, T000E82_n148subCatDsc, T000E82_A150subCatPrec, T000E82_n150subCatPrec
               }
               , new Object[] {
               T000E83_A1EmpID, T000E83_A34CotiID, T000E83_A35secID
               }
               , new Object[] {
               T000E84_A1EmpID, T000E84_A34CotiID, T000E84_A38nroSec, T000E84_A202ObrDsc, T000E84_n202ObrDsc, T000E84_A178ObrValor, T000E84_n178ObrValor
               }
               , new Object[] {
               T000E85_A1EmpID, T000E85_A34CotiID, T000E85_A38nroSec
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000E89_A1EmpID, T000E89_A34CotiID, T000E89_A38nroSec
               }
               , new Object[] {
               T000E90_A31tipoProdID
               }
            }
         );
         AV19Pgmname = "Cotizador";
      }

      private short nIsMod_29 ;
      private short wcpOAV8EmpID ;
      private short wcpOAV7CotiID ;
      private short Z1EmpID ;
      private short Z34CotiID ;
      private short Z10protID ;
      private short O176sumTotNeto1 ;
      private short nRC_GXsfl_74 ;
      private short nGXsfl_74_idx=1 ;
      private short nRC_GXsfl_90 ;
      private short nGXsfl_90_idx=1 ;
      private short N10protID ;
      private short Z35secID ;
      private short Z36detTipoProdID ;
      private short Z32categID ;
      private short Z33subCatID ;
      private short nRcdDeleted_29 ;
      private short nRcdExists_29 ;
      private short Z38nroSec ;
      private short nRcdDeleted_30 ;
      private short nRcdExists_30 ;
      private short nIsMod_30 ;
      private short GxWebError ;
      private short AV7CotiID ;
      private short AV8EmpID ;
      private short A1EmpID ;
      private short A10protID ;
      private short A34CotiID ;
      private short A36detTipoProdID ;
      private short A32categID ;
      private short A33subCatID ;
      private short Gx_BScreen ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short subGridcotizadordet_Backcolorstyle ;
      private short A35secID ;
      private short subGridcotizadordet_Allowselection ;
      private short subGridcotizadordet_Allowhovering ;
      private short subGridcotizadordet_Allowcollapsing ;
      private short subGridcotizadordet_Collapsed ;
      private short nBlankRcdCount29 ;
      private short RcdFound29 ;
      private short B176sumTotNeto1 ;
      private short A176sumTotNeto1 ;
      private short nBlankRcdUsr29 ;
      private short subGrid1_Backcolorstyle ;
      private short A38nroSec ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nBlankRcdCount30 ;
      private short RcdFound30 ;
      private short nBlankRcdUsr30 ;
      private short AV9Insert_protID ;
      private short A31tipoProdID ;
      private short RcdFound28 ;
      private short s176sumTotNeto1 ;
      private short GX_JID ;
      private short Z176sumTotNeto1 ;
      private short subGridcotizadordet_Backstyle ;
      private short subGrid1_Backstyle ;
      private short GXt_int1 ;
      private short wbTemp ;
      private int Z156CotiUltNro ;
      private int Z201CotiUltNroObr ;
      private int O156CotiUltNro ;
      private int A156CotiUltNro ;
      private int trnEnded ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtempdsc_Enabled ;
      private int edtCotiID_Enabled ;
      private int edtCotiDsc_Enabled ;
      private int edtprotID_Enabled ;
      private int imgprompt_10_Visible ;
      private int edtprotDsc_Enabled ;
      private int edtCotiIVA_Enabled ;
      private int edtCotiUltNro_Enabled ;
      private int edtCotiObs_Enabled ;
      private int edtObrSubtotal_Enabled ;
      private int edtsumTotCant_Enabled ;
      private int edtsumTotValor_Enabled ;
      private int edtsumTotValorIVA_Enabled ;
      private int edtsumTotNeto_Enabled ;
      private int bttButton1_Visible ;
      private int bttButton1_Enabled ;
      private int bttButton2_Visible ;
      private int edtsecID_Enabled ;
      private int edtdetTipoProdID_Enabled ;
      private int edtcategID_Enabled ;
      private int edtsubCatID_Enabled ;
      private int edtsubCatDsc_Enabled ;
      private int edtsubCatPrec_Enabled ;
      private int edtCotiDetCant_Enabled ;
      private int edtCotiDetValor_Enabled ;
      private int edtCotiDetIva_Enabled ;
      private int edtCotiDetTotal_Enabled ;
      private int subGridcotizadordet_Selectedindex ;
      private int subGridcotizadordet_Selectioncolor ;
      private int subGridcotizadordet_Hoveringcolor ;
      private int B156CotiUltNro ;
      private int fRowAdded ;
      private int edtnroSec_Enabled ;
      private int edtObrDsc_Enabled ;
      private int edtObrValor_Enabled ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int A201CotiUltNroObr ;
      private int s156CotiUltNro ;
      private int AV20GXV1 ;
      private int subGridcotizadordet_Backcolor ;
      private int subGridcotizadordet_Allbackcolor ;
      private int imgprompt_36_Visible ;
      private int imgprompt_32_Visible ;
      private int imgprompt_33_Visible ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int defedtnroSec_Enabled ;
      private int defedtsecID_Enabled ;
      private int i156CotiUltNro ;
      private int idxLst ;
      private long GRIDCOTIZADORDET_nFirstRecordOnPage ;
      private long GRID1_nFirstRecordOnPage ;
      private decimal Z181TotNeto ;
      private decimal Z155CotiIVA ;
      private decimal O177ObrSubtotal ;
      private decimal O180sumTotValorIVA ;
      private decimal O179sumTotValor ;
      private decimal O174sumTotCant ;
      private decimal Z157CotiDetCant ;
      private decimal O160CotiDetTotal ;
      private decimal O159CotiDetIva ;
      private decimal O158CotiDetValor ;
      private decimal O157CotiDetCant ;
      private decimal Z178ObrValor ;
      private decimal O178ObrValor ;
      private decimal A155CotiIVA ;
      private decimal A177ObrSubtotal ;
      private decimal A174sumTotCant ;
      private decimal A179sumTotValor ;
      private decimal A180sumTotValorIVA ;
      private decimal A175sumTotNeto ;
      private decimal A150subCatPrec ;
      private decimal A157CotiDetCant ;
      private decimal A158CotiDetValor ;
      private decimal A159CotiDetIva ;
      private decimal A160CotiDetTotal ;
      private decimal B177ObrSubtotal ;
      private decimal B180sumTotValorIVA ;
      private decimal B179sumTotValor ;
      private decimal B174sumTotCant ;
      private decimal A178ObrValor ;
      private decimal A181TotNeto ;
      private decimal s177ObrSubtotal ;
      private decimal s175sumTotNeto ;
      private decimal O175sumTotNeto ;
      private decimal s181TotNeto ;
      private decimal O181TotNeto ;
      private decimal T178ObrValor ;
      private decimal s180sumTotValorIVA ;
      private decimal s179sumTotValor ;
      private decimal s174sumTotCant ;
      private decimal T160CotiDetTotal ;
      private decimal T159CotiDetIva ;
      private decimal T158CotiDetValor ;
      private decimal T157CotiDetCant ;
      private decimal Z180sumTotValorIVA ;
      private decimal Z177ObrSubtotal ;
      private decimal Z174sumTotCant ;
      private decimal Z179sumTotValor ;
      private decimal Z150subCatPrec ;
      private String sPrefix ;
      private String sGXsfl_74_idx="0001" ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String sGXsfl_90_idx="0001" ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEmpID_Internalname ;
      private String divMaintable1_Internalname ;
      private String divLayout1_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String edtEmpID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String edtCotiID_Internalname ;
      private String edtCotiID_Jsonclick ;
      private String edtCotiDsc_Internalname ;
      private String edtCotiDsc_Jsonclick ;
      private String edtprotID_Internalname ;
      private String edtprotID_Jsonclick ;
      private String imgprompt_10_Internalname ;
      private String imgprompt_10_Link ;
      private String edtprotDsc_Internalname ;
      private String A74protDsc ;
      private String edtprotDsc_Jsonclick ;
      private String edtCotiIVA_Internalname ;
      private String edtCotiIVA_Jsonclick ;
      private String edtCotiUltNro_Internalname ;
      private String edtCotiUltNro_Jsonclick ;
      private String edtCotiObs_Internalname ;
      private String divDettable_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String divTbsubtobra_Internalname ;
      private String edtObrSubtotal_Internalname ;
      private String edtObrSubtotal_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String divTable1_Internalname ;
      private String divSection4_Internalname ;
      private String edtsumTotCant_Internalname ;
      private String edtsumTotCant_Jsonclick ;
      private String divSection5_Internalname ;
      private String edtsumTotValor_Internalname ;
      private String edtsumTotValor_Jsonclick ;
      private String divSection1_Internalname ;
      private String edtsumTotValorIVA_Internalname ;
      private String edtsumTotValorIVA_Jsonclick ;
      private String divSection2_Internalname ;
      private String edtsumTotNeto_Internalname ;
      private String edtsumTotNeto_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String subGridcotizadordet_Header ;
      private String A148subCatDsc ;
      private String sMode29 ;
      private String edtsecID_Internalname ;
      private String edtdetTipoProdID_Internalname ;
      private String edtcategID_Internalname ;
      private String edtsubCatID_Internalname ;
      private String edtsubCatDsc_Internalname ;
      private String edtsubCatPrec_Internalname ;
      private String edtCotiDetCant_Internalname ;
      private String edtCotiDetValor_Internalname ;
      private String edtCotiDetIva_Internalname ;
      private String edtCotiDetTotal_Internalname ;
      private String sStyleString ;
      private String subGrid1_Header ;
      private String sMode30 ;
      private String edtnroSec_Internalname ;
      private String edtObrDsc_Internalname ;
      private String edtObrValor_Internalname ;
      private String AV19Pgmname ;
      private String A146categDsc ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode28 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z74protDsc ;
      private String Z146categDsc ;
      private String Z148subCatDsc ;
      private String imgprompt_36_Internalname ;
      private String imgprompt_32_Internalname ;
      private String imgprompt_33_Internalname ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String subGridcotizadordet_Class ;
      private String subGridcotizadordet_Linesclass ;
      private String imgprompt_33_Link ;
      private String imgprompt_32_Link ;
      private String imgprompt_36_Link ;
      private String ROClassString ;
      private String edtsecID_Jsonclick ;
      private String edtdetTipoProdID_Jsonclick ;
      private String edtcategID_Jsonclick ;
      private String edtsubCatID_Jsonclick ;
      private String edtsubCatDsc_Jsonclick ;
      private String edtsubCatPrec_Jsonclick ;
      private String edtCotiDetCant_Jsonclick ;
      private String edtCotiDetValor_Jsonclick ;
      private String edtCotiDetIva_Jsonclick ;
      private String edtCotiDetTotal_Jsonclick ;
      private String sGXsfl_90_fel_idx="0001" ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtnroSec_Jsonclick ;
      private String edtObrDsc_Jsonclick ;
      private String edtObrValor_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridcotizadordet_Internalname ;
      private String subGrid1_Internalname ;
      private bool entryPointCalled ;
      private bool n156CotiUltNro ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n177ObrSubtotal ;
      private bool n176sumTotNeto1 ;
      private bool n180sumTotValorIVA ;
      private bool n179sumTotValor ;
      private bool n174sumTotCant ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool bGXsfl_90_Refreshing=false ;
      private bool n44empdsc ;
      private bool n154CotiDsc ;
      private bool n74protDsc ;
      private bool n155CotiIVA ;
      private bool n182CotiObs ;
      private bool n181TotNeto ;
      private bool n201CotiUltNroObr ;
      private bool n146categDsc ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool n148subCatDsc ;
      private bool n150subCatPrec ;
      private bool n157CotiDetCant ;
      private bool n159CotiDetIva ;
      private bool n160CotiDetTotal ;
      private bool n202ObrDsc ;
      private bool n178ObrValor ;
      private String Z154CotiDsc ;
      private String Z182CotiObs ;
      private String Z202ObrDsc ;
      private String A44empdsc ;
      private String A154CotiDsc ;
      private String A182CotiObs ;
      private String A202ObrDsc ;
      private String Z44empdsc ;
      private IGxSession AV13WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid GridcotizadordetContainer ;
      private GXWebGrid Grid1Container ;
      private GXWebRow GridcotizadordetRow ;
      private GXWebRow Grid1Row ;
      private GXWebColumn GridcotizadordetColumn ;
      private GXWebColumn Grid1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000E12_A44empdsc ;
      private bool[] T000E12_n44empdsc ;
      private String[] T000E13_A74protDsc ;
      private bool[] T000E13_n74protDsc ;
      private short[] T000E17_A176sumTotNeto1 ;
      private bool[] T000E17_n176sumTotNeto1 ;
      private decimal[] T000E20_A180sumTotValorIVA ;
      private bool[] T000E20_n180sumTotValorIVA ;
      private decimal[] T000E22_A177ObrSubtotal ;
      private bool[] T000E22_n177ObrSubtotal ;
      private decimal[] T000E24_A174sumTotCant ;
      private bool[] T000E24_n174sumTotCant ;
      private decimal[] T000E26_A179sumTotValor ;
      private bool[] T000E26_n179sumTotValor ;
      private short[] T000E35_A34CotiID ;
      private decimal[] T000E35_A181TotNeto ;
      private bool[] T000E35_n181TotNeto ;
      private String[] T000E35_A44empdsc ;
      private bool[] T000E35_n44empdsc ;
      private String[] T000E35_A154CotiDsc ;
      private bool[] T000E35_n154CotiDsc ;
      private String[] T000E35_A74protDsc ;
      private bool[] T000E35_n74protDsc ;
      private decimal[] T000E35_A155CotiIVA ;
      private bool[] T000E35_n155CotiIVA ;
      private int[] T000E35_A156CotiUltNro ;
      private bool[] T000E35_n156CotiUltNro ;
      private int[] T000E35_A201CotiUltNroObr ;
      private bool[] T000E35_n201CotiUltNroObr ;
      private String[] T000E35_A182CotiObs ;
      private bool[] T000E35_n182CotiObs ;
      private short[] T000E35_A1EmpID ;
      private short[] T000E35_A10protID ;
      private short[] T000E35_A176sumTotNeto1 ;
      private bool[] T000E35_n176sumTotNeto1 ;
      private decimal[] T000E35_A180sumTotValorIVA ;
      private bool[] T000E35_n180sumTotValorIVA ;
      private decimal[] T000E35_A177ObrSubtotal ;
      private bool[] T000E35_n177ObrSubtotal ;
      private decimal[] T000E35_A174sumTotCant ;
      private bool[] T000E35_n174sumTotCant ;
      private decimal[] T000E35_A179sumTotValor ;
      private bool[] T000E35_n179sumTotValor ;
      private String[] T000E36_A44empdsc ;
      private bool[] T000E36_n44empdsc ;
      private String[] T000E37_A74protDsc ;
      private bool[] T000E37_n74protDsc ;
      private short[] T000E41_A176sumTotNeto1 ;
      private bool[] T000E41_n176sumTotNeto1 ;
      private decimal[] T000E44_A180sumTotValorIVA ;
      private bool[] T000E44_n180sumTotValorIVA ;
      private decimal[] T000E46_A177ObrSubtotal ;
      private bool[] T000E46_n177ObrSubtotal ;
      private decimal[] T000E48_A174sumTotCant ;
      private bool[] T000E48_n174sumTotCant ;
      private decimal[] T000E50_A179sumTotValor ;
      private bool[] T000E50_n179sumTotValor ;
      private short[] T000E51_A1EmpID ;
      private short[] T000E51_A34CotiID ;
      private short[] T000E11_A34CotiID ;
      private decimal[] T000E11_A181TotNeto ;
      private bool[] T000E11_n181TotNeto ;
      private String[] T000E11_A154CotiDsc ;
      private bool[] T000E11_n154CotiDsc ;
      private decimal[] T000E11_A155CotiIVA ;
      private bool[] T000E11_n155CotiIVA ;
      private int[] T000E11_A156CotiUltNro ;
      private bool[] T000E11_n156CotiUltNro ;
      private int[] T000E11_A201CotiUltNroObr ;
      private bool[] T000E11_n201CotiUltNroObr ;
      private String[] T000E11_A182CotiObs ;
      private bool[] T000E11_n182CotiObs ;
      private short[] T000E11_A1EmpID ;
      private short[] T000E11_A10protID ;
      private short[] T000E52_A1EmpID ;
      private short[] T000E52_A34CotiID ;
      private short[] T000E53_A1EmpID ;
      private short[] T000E53_A34CotiID ;
      private short[] T000E10_A34CotiID ;
      private decimal[] T000E10_A181TotNeto ;
      private bool[] T000E10_n181TotNeto ;
      private String[] T000E10_A154CotiDsc ;
      private bool[] T000E10_n154CotiDsc ;
      private decimal[] T000E10_A155CotiIVA ;
      private bool[] T000E10_n155CotiIVA ;
      private int[] T000E10_A156CotiUltNro ;
      private bool[] T000E10_n156CotiUltNro ;
      private int[] T000E10_A201CotiUltNroObr ;
      private bool[] T000E10_n201CotiUltNroObr ;
      private String[] T000E10_A182CotiObs ;
      private bool[] T000E10_n182CotiObs ;
      private short[] T000E10_A1EmpID ;
      private short[] T000E10_A10protID ;
      private String[] T000E57_A44empdsc ;
      private bool[] T000E57_n44empdsc ;
      private short[] T000E61_A176sumTotNeto1 ;
      private bool[] T000E61_n176sumTotNeto1 ;
      private decimal[] T000E64_A180sumTotValorIVA ;
      private bool[] T000E64_n180sumTotValorIVA ;
      private decimal[] T000E66_A177ObrSubtotal ;
      private bool[] T000E66_n177ObrSubtotal ;
      private decimal[] T000E68_A174sumTotCant ;
      private bool[] T000E68_n174sumTotCant ;
      private decimal[] T000E70_A179sumTotValor ;
      private bool[] T000E70_n179sumTotValor ;
      private String[] T000E71_A74protDsc ;
      private bool[] T000E71_n74protDsc ;
      private short[] T000E73_A1EmpID ;
      private short[] T000E73_A34CotiID ;
      private short[] T000E74_A34CotiID ;
      private short[] T000E74_A35secID ;
      private String[] T000E74_A146categDsc ;
      private bool[] T000E74_n146categDsc ;
      private String[] T000E74_A148subCatDsc ;
      private bool[] T000E74_n148subCatDsc ;
      private decimal[] T000E74_A150subCatPrec ;
      private bool[] T000E74_n150subCatPrec ;
      private decimal[] T000E74_A157CotiDetCant ;
      private bool[] T000E74_n157CotiDetCant ;
      private short[] T000E74_A1EmpID ;
      private short[] T000E74_A36detTipoProdID ;
      private short[] T000E74_A32categID ;
      private short[] T000E74_A33subCatID ;
      private short[] T000E6_A31tipoProdID ;
      private String[] T000E7_A146categDsc ;
      private bool[] T000E7_n146categDsc ;
      private String[] T000E8_A148subCatDsc ;
      private bool[] T000E8_n148subCatDsc ;
      private decimal[] T000E8_A150subCatPrec ;
      private bool[] T000E8_n150subCatPrec ;
      private String[] T000E75_A146categDsc ;
      private bool[] T000E75_n146categDsc ;
      private String[] T000E76_A148subCatDsc ;
      private bool[] T000E76_n148subCatDsc ;
      private decimal[] T000E76_A150subCatPrec ;
      private bool[] T000E76_n150subCatPrec ;
      private short[] T000E77_A1EmpID ;
      private short[] T000E77_A34CotiID ;
      private short[] T000E77_A35secID ;
      private short[] T000E5_A34CotiID ;
      private short[] T000E5_A35secID ;
      private decimal[] T000E5_A157CotiDetCant ;
      private bool[] T000E5_n157CotiDetCant ;
      private short[] T000E5_A1EmpID ;
      private short[] T000E5_A36detTipoProdID ;
      private short[] T000E5_A32categID ;
      private short[] T000E5_A33subCatID ;
      private short[] T000E4_A34CotiID ;
      private short[] T000E4_A35secID ;
      private decimal[] T000E4_A157CotiDetCant ;
      private bool[] T000E4_n157CotiDetCant ;
      private short[] T000E4_A1EmpID ;
      private short[] T000E4_A36detTipoProdID ;
      private short[] T000E4_A32categID ;
      private short[] T000E4_A33subCatID ;
      private String[] T000E81_A146categDsc ;
      private bool[] T000E81_n146categDsc ;
      private String[] T000E82_A148subCatDsc ;
      private bool[] T000E82_n148subCatDsc ;
      private decimal[] T000E82_A150subCatPrec ;
      private bool[] T000E82_n150subCatPrec ;
      private short[] T000E83_A1EmpID ;
      private short[] T000E83_A34CotiID ;
      private short[] T000E83_A35secID ;
      private short[] T000E84_A1EmpID ;
      private short[] T000E84_A34CotiID ;
      private short[] T000E84_A38nroSec ;
      private String[] T000E84_A202ObrDsc ;
      private bool[] T000E84_n202ObrDsc ;
      private decimal[] T000E84_A178ObrValor ;
      private bool[] T000E84_n178ObrValor ;
      private short[] T000E85_A1EmpID ;
      private short[] T000E85_A34CotiID ;
      private short[] T000E85_A38nroSec ;
      private short[] T000E3_A1EmpID ;
      private short[] T000E3_A34CotiID ;
      private short[] T000E3_A38nroSec ;
      private String[] T000E3_A202ObrDsc ;
      private bool[] T000E3_n202ObrDsc ;
      private decimal[] T000E3_A178ObrValor ;
      private bool[] T000E3_n178ObrValor ;
      private short[] T000E2_A1EmpID ;
      private short[] T000E2_A34CotiID ;
      private short[] T000E2_A38nroSec ;
      private String[] T000E2_A202ObrDsc ;
      private bool[] T000E2_n202ObrDsc ;
      private decimal[] T000E2_A178ObrValor ;
      private bool[] T000E2_n178ObrValor ;
      private short[] T000E89_A1EmpID ;
      private short[] T000E89_A34CotiID ;
      private short[] T000E89_A38nroSec ;
      private short[] T000E90_A31tipoProdID ;
      private short[] T000E9_A31tipoProdID ;
      private SdtTransactionContext AV11TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class cotizador__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new UpdateCursor(def[28])
         ,new UpdateCursor(def[29])
         ,new UpdateCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new ForEachCursor(def[35])
         ,new ForEachCursor(def[36])
         ,new ForEachCursor(def[37])
         ,new UpdateCursor(def[38])
         ,new ForEachCursor(def[39])
         ,new ForEachCursor(def[40])
         ,new ForEachCursor(def[41])
         ,new ForEachCursor(def[42])
         ,new ForEachCursor(def[43])
         ,new UpdateCursor(def[44])
         ,new UpdateCursor(def[45])
         ,new UpdateCursor(def[46])
         ,new ForEachCursor(def[47])
         ,new ForEachCursor(def[48])
         ,new ForEachCursor(def[49])
         ,new ForEachCursor(def[50])
         ,new ForEachCursor(def[51])
         ,new UpdateCursor(def[52])
         ,new UpdateCursor(def[53])
         ,new UpdateCursor(def[54])
         ,new ForEachCursor(def[55])
         ,new ForEachCursor(def[56])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000E9 ;
          prmT000E9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E35 ;
          prmT000E35 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          String cmdBufferT000E35 ;
          cmdBufferT000E35=" SELECT TM1.[CotiID], TM1.[TotNeto], T2.[empdsc], TM1.[CotiDsc], T8.[protDsc], TM1.[CotiIVA], TM1.[CotiUltNro], TM1.[CotiUltNroObr], TM1.[CotiObs], TM1.[EmpID], TM1.[protID], COALESCE( T3.[sumTotNeto1], 0) AS sumTotNeto1, COALESCE( T4.[sumTotValorIVA], 0) AS sumTotValorIVA, COALESCE( T5.[ObrSubtotal], 0) AS ObrSubtotal, COALESCE( T6.[sumTotCant], 0) AS sumTotCant, COALESCE( T7.[sumTotValor], 0) AS sumTotValor FROM ((((((([Cotizador] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) LEFT JOIN (SELECT SUM(COALESCE( T10.[CotiDetTotal], 0)) AS sumTotNeto1, T9.[EmpID], T9.[CotiID] FROM ([CotizadorLevel1] T9 WITH (NOLOCK) INNER JOIN (SELECT ROUND(( COALESCE( T12.[subCatPrec], 0) * CAST(COALESCE( T11.[CotiDetCant], 0) AS decimal( 20, 10)) + COALESCE( T13.[CotiDetIva], 0)), 2) AS CotiDetTotal, T11.[EmpID], T11.[CotiID], T11.[secID] FROM (([CotizadorLevel1] T11 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T12 WITH (NOLOCK) ON T12.[EmpID] = T11.[EmpID] AND T12.[categID] = T11.[categID] AND T12.[subCatID] = T11.[subCatID]) INNER JOIN (SELECT ( CAST(( ( COALESCE( T15.[subCatPrec], 0) * CAST(COALESCE( T14.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( TM1.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T14.[EmpID], T14.[CotiID], T14.[secID] FROM (([CotizadorLevel1] T14 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T15 WITH (NOLOCK) ON T15.[EmpID] = T14.[EmpID] AND T15.[categID] = T14.[categID] AND T15.[subCatID] = T14.[subCatID]) INNER JOIN [Cotizador] TM1 WITH (NOLOCK) ON TM1.[EmpID] = T14.[EmpID] AND TM1.[CotiID] = T14.[CotiID]) ) T13 ON T13.[EmpID] = T11.[EmpID] AND T13.[CotiID] = T11.[CotiID] AND T13.[secID] = T11.[secID]) ) T10 ON T10.[EmpID] = T9.[EmpID] AND T10.[CotiID] = T9.[CotiID] AND T10.[secID] = T9.[secID]) "
          + " GROUP BY T9.[EmpID], T9.[CotiID] ) T3 ON T3.[EmpID] = TM1.[EmpID] AND T3.[CotiID] = TM1.[CotiID]) LEFT JOIN (SELECT SUM(COALESCE( T10.[CotiDetIva], 0)) AS sumTotValorIVA, T9.[EmpID], T9.[CotiID] FROM ([CotizadorLevel1] T9 WITH (NOLOCK) INNER JOIN (SELECT ( CAST(( ( COALESCE( T12.[subCatPrec], 0) * CAST(COALESCE( T11.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( TM1.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T11.[EmpID], T11.[CotiID], T11.[secID] FROM (([CotizadorLevel1] T11 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T12 WITH (NOLOCK) ON T12.[EmpID] = T11.[EmpID] AND T12.[categID] = T11.[categID] AND T12.[subCatID] = T11.[subCatID]) INNER JOIN [Cotizador] TM1 WITH (NOLOCK) ON TM1.[EmpID] = T11.[EmpID] AND TM1.[CotiID] = T11.[CotiID]) ) T10 ON T10.[EmpID] = T9.[EmpID] AND T10.[CotiID] = T9.[CotiID] AND T10.[secID] = T9.[secID]) GROUP BY T9.[EmpID], T9.[CotiID] ) T4 ON T4.[EmpID] = TM1.[EmpID] AND T4.[CotiID] = TM1.[CotiID]) LEFT JOIN (SELECT SUM([ObrValor]) AS ObrSubtotal, [EmpID], [CotiID] FROM [CotizadorObreros] WITH (NOLOCK) GROUP BY [EmpID], [CotiID] ) T5 ON T5.[EmpID] = TM1.[EmpID] AND T5.[CotiID] = TM1.[CotiID]) LEFT JOIN (SELECT SUM([CotiDetCant]) AS sumTotCant, [EmpID], [CotiID] FROM [CotizadorLevel1] WITH (NOLOCK) GROUP BY [EmpID], [CotiID] ) T6 ON T6.[EmpID] = TM1.[EmpID] AND T6.[CotiID] = TM1.[CotiID]) LEFT JOIN (SELECT SUM(COALESCE( T10.[subCatPrec], 0) * CAST(COALESCE( T9.[CotiDetCant], 0) AS decimal( 20, 10))) AS sumTotValor, T9.[EmpID], T9.[CotiID] FROM ([CotizadorLevel1] T9 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T10 WITH (NOLOCK) ON T10.[EmpID] = T9.[EmpID] AND T10.[categID] = T9.[categID] AND T10.[subCatID] = T9.[subCatID]) GROUP BY T9.[EmpID], T9.[CotiID] ) T7 ON T7.[EmpID] = TM1.[EmpID] AND T7.[CotiID]"
          + " = TM1.[CotiID]) INNER JOIN [Prototipo] T8 WITH (NOLOCK) ON T8.[EmpID] = TM1.[EmpID] AND T8.[protID] = TM1.[protID]) WHERE TM1.[EmpID] = @EmpID and TM1.[CotiID] = @CotiID ORDER BY TM1.[EmpID], TM1.[CotiID]  OPTION (FAST 100)" ;
          Object[] prmT000E12 ;
          prmT000E12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E13 ;
          prmT000E13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E17 ;
          prmT000E17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E20 ;
          prmT000E20 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E22 ;
          prmT000E22 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E24 ;
          prmT000E24 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E26 ;
          prmT000E26 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E36 ;
          prmT000E36 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E37 ;
          prmT000E37 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E41 ;
          prmT000E41 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E44 ;
          prmT000E44 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E46 ;
          prmT000E46 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E48 ;
          prmT000E48 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E50 ;
          prmT000E50 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E51 ;
          prmT000E51 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E11 ;
          prmT000E11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E52 ;
          prmT000E52 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E53 ;
          prmT000E53 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E10 ;
          prmT000E10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E54 ;
          prmT000E54 = new Object[] {
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TotNeto",SqlDbType.Decimal,10,2} ,
          new Object[] {"@CotiDsc",SqlDbType.VarChar,100,0} ,
          new Object[] {"@CotiIVA",SqlDbType.Decimal,8,3} ,
          new Object[] {"@CotiUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@CotiUltNroObr",SqlDbType.Int,8,0} ,
          new Object[] {"@CotiObs",SqlDbType.VarChar,120,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E55 ;
          prmT000E55 = new Object[] {
          new Object[] {"@TotNeto",SqlDbType.Decimal,10,2} ,
          new Object[] {"@CotiDsc",SqlDbType.VarChar,100,0} ,
          new Object[] {"@CotiIVA",SqlDbType.Decimal,8,3} ,
          new Object[] {"@CotiUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@CotiUltNroObr",SqlDbType.Int,8,0} ,
          new Object[] {"@CotiObs",SqlDbType.VarChar,120,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E56 ;
          prmT000E56 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E72 ;
          prmT000E72 = new Object[] {
          new Object[] {"@CotiUltNro",SqlDbType.Int,8,0} ,
          new Object[] {"@TotNeto",SqlDbType.Decimal,10,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E73 ;
          prmT000E73 = new Object[] {
          } ;
          Object[] prmT000E74 ;
          prmT000E74 = new Object[] {
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E7 ;
          prmT000E7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E8 ;
          prmT000E8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E6 ;
          prmT000E6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E75 ;
          prmT000E75 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E76 ;
          prmT000E76 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E77 ;
          prmT000E77 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E5 ;
          prmT000E5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E4 ;
          prmT000E4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E78 ;
          prmT000E78 = new Object[] {
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiDetCant",SqlDbType.Decimal,10,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E79 ;
          prmT000E79 = new Object[] {
          new Object[] {"@CotiDetCant",SqlDbType.Decimal,10,2} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E80 ;
          prmT000E80 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E83 ;
          prmT000E83 = new Object[] {
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E84 ;
          prmT000E84 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E85 ;
          prmT000E85 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E3 ;
          prmT000E3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E2 ;
          prmT000E2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E86 ;
          prmT000E86 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObrDsc",SqlDbType.VarChar,40,0} ,
          new Object[] {"@ObrValor",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmT000E87 ;
          prmT000E87 = new Object[] {
          new Object[] {"@ObrDsc",SqlDbType.VarChar,40,0} ,
          new Object[] {"@ObrValor",SqlDbType.Decimal,10,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E88 ;
          prmT000E88 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroSec",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E89 ;
          prmT000E89 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E57 ;
          prmT000E57 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E61 ;
          prmT000E61 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E64 ;
          prmT000E64 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E66 ;
          prmT000E66 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E68 ;
          prmT000E68 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E70 ;
          prmT000E70 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CotiID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E71 ;
          prmT000E71 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E90 ;
          prmT000E90 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E81 ;
          prmT000E81 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000E82 ;
          prmT000E82 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000E2", "SELECT [EmpID], [CotiID], [nroSec], [ObrDsc], [ObrValor] FROM [CotizadorObreros] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID AND [nroSec] = @nroSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E2,1,0,true,false )
             ,new CursorDef("T000E3", "SELECT [EmpID], [CotiID], [nroSec], [ObrDsc], [ObrValor] FROM [CotizadorObreros] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID AND [nroSec] = @nroSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E3,1,0,true,false )
             ,new CursorDef("T000E4", "SELECT [CotiID], [secID], [CotiDetCant], [EmpID], [detTipoProdID], [categID], [subCatID] FROM [CotizadorLevel1] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID AND [secID] = @secID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E4,1,0,true,false )
             ,new CursorDef("T000E5", "SELECT [CotiID], [secID], [CotiDetCant], [EmpID], [detTipoProdID], [categID], [subCatID] FROM [CotizadorLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID AND [secID] = @secID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E5,1,0,true,false )
             ,new CursorDef("T000E6", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @detTipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E6,1,0,true,false )
             ,new CursorDef("T000E7", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E7,1,0,true,false )
             ,new CursorDef("T000E8", "SELECT [subCatDsc], [subCatPrec] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E8,1,0,true,false )
             ,new CursorDef("T000E9", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E9,1,0,true,false )
             ,new CursorDef("T000E10", "SELECT [CotiID], [TotNeto], [CotiDsc], [CotiIVA], [CotiUltNro], [CotiUltNroObr], [CotiObs], [EmpID], [protID] FROM [Cotizador] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E10,1,0,true,false )
             ,new CursorDef("T000E11", "SELECT [CotiID], [TotNeto], [CotiDsc], [CotiIVA], [CotiUltNro], [CotiUltNroObr], [CotiObs], [EmpID], [protID] FROM [Cotizador] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E11,1,0,true,false )
             ,new CursorDef("T000E12", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E12,1,0,true,false )
             ,new CursorDef("T000E13", "SELECT [protDsc] FROM [Prototipo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [protID] = @protID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E13,1,0,true,false )
             ,new CursorDef("T000E17", "SELECT COALESCE( T1.[sumTotNeto1], 0) AS sumTotNeto1 FROM (SELECT SUM(COALESCE( T3.[CotiDetTotal], 0)) AS sumTotNeto1, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (UPDLOCK) INNER JOIN (SELECT ROUND(( COALESCE( T5.[subCatPrec], 0) * CAST(COALESCE( T4.[CotiDetCant], 0) AS decimal( 20, 10)) + COALESCE( T6.[CotiDetIva], 0)), 2) AS CotiDetTotal, T4.[EmpID], T4.[CotiID], T4.[secID] FROM (([CotizadorLevel1] T4 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T5 WITH (NOLOCK) ON T5.[EmpID] = T4.[EmpID] AND T5.[categID] = T4.[categID] AND T5.[subCatID] = T4.[subCatID]) INNER JOIN (SELECT ( CAST(( ( COALESCE( T8.[subCatPrec], 0) * CAST(COALESCE( T7.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T9.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T7.[EmpID], T7.[CotiID], T7.[secID] FROM (([CotizadorLevel1] T7 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T8 WITH (NOLOCK) ON T8.[EmpID] = T7.[EmpID] AND T8.[categID] = T7.[categID] AND T8.[subCatID] = T7.[subCatID]) INNER JOIN [Cotizador] T9 WITH (UPDLOCK) ON T9.[EmpID] = T7.[EmpID] AND T9.[CotiID] = T7.[CotiID]) ) T6 ON T6.[EmpID] = T4.[EmpID] AND T6.[CotiID] = T4.[CotiID] AND T6.[secID] = T4.[secID]) ) T3 ON T3.[EmpID] = T2.[EmpID] AND T3.[CotiID] = T2.[CotiID] AND T3.[secID] = T2.[secID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E17,1,0,true,false )
             ,new CursorDef("T000E20", "SELECT COALESCE( T1.[sumTotValorIVA], 0) AS sumTotValorIVA FROM (SELECT SUM(COALESCE( T3.[CotiDetIva], 0)) AS sumTotValorIVA, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (UPDLOCK) INNER JOIN (SELECT ( CAST(( ( COALESCE( T5.[subCatPrec], 0) * CAST(COALESCE( T4.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T6.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T4.[EmpID], T4.[CotiID], T4.[secID] FROM (([CotizadorLevel1] T4 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T5 WITH (NOLOCK) ON T5.[EmpID] = T4.[EmpID] AND T5.[categID] = T4.[categID] AND T5.[subCatID] = T4.[subCatID]) INNER JOIN [Cotizador] T6 WITH (UPDLOCK) ON T6.[EmpID] = T4.[EmpID] AND T6.[CotiID] = T4.[CotiID]) ) T3 ON T3.[EmpID] = T2.[EmpID] AND T3.[CotiID] = T2.[CotiID] AND T3.[secID] = T2.[secID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E20,1,0,true,false )
             ,new CursorDef("T000E22", "SELECT COALESCE( T1.[ObrSubtotal], 0) AS ObrSubtotal FROM (SELECT SUM([ObrValor]) AS ObrSubtotal, [EmpID], [CotiID] FROM [CotizadorObreros] WITH (UPDLOCK) GROUP BY [EmpID], [CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E22,1,0,true,false )
             ,new CursorDef("T000E24", "SELECT COALESCE( T1.[sumTotCant], 0) AS sumTotCant FROM (SELECT SUM([CotiDetCant]) AS sumTotCant, [EmpID], [CotiID] FROM [CotizadorLevel1] WITH (UPDLOCK) GROUP BY [EmpID], [CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E24,1,0,true,false )
             ,new CursorDef("T000E26", "SELECT COALESCE( T1.[sumTotValor], 0) AS sumTotValor FROM (SELECT SUM(COALESCE( T3.[subCatPrec], 0) * CAST(COALESCE( T2.[CotiDetCant], 0) AS decimal( 20, 10))) AS sumTotValor, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T2.[EmpID] AND T3.[categID] = T2.[categID] AND T3.[subCatID] = T2.[subCatID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E26,1,0,true,false )
             ,new CursorDef("T000E35", cmdBufferT000E35,true, GxErrorMask.GX_NOMASK, false, this,prmT000E35,100,0,true,false )
             ,new CursorDef("T000E36", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E36,1,0,true,false )
             ,new CursorDef("T000E37", "SELECT [protDsc] FROM [Prototipo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [protID] = @protID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E37,1,0,true,false )
             ,new CursorDef("T000E41", "SELECT COALESCE( T1.[sumTotNeto1], 0) AS sumTotNeto1 FROM (SELECT SUM(COALESCE( T3.[CotiDetTotal], 0)) AS sumTotNeto1, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (UPDLOCK) INNER JOIN (SELECT ROUND(( COALESCE( T5.[subCatPrec], 0) * CAST(COALESCE( T4.[CotiDetCant], 0) AS decimal( 20, 10)) + COALESCE( T6.[CotiDetIva], 0)), 2) AS CotiDetTotal, T4.[EmpID], T4.[CotiID], T4.[secID] FROM (([CotizadorLevel1] T4 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T5 WITH (NOLOCK) ON T5.[EmpID] = T4.[EmpID] AND T5.[categID] = T4.[categID] AND T5.[subCatID] = T4.[subCatID]) INNER JOIN (SELECT ( CAST(( ( COALESCE( T8.[subCatPrec], 0) * CAST(COALESCE( T7.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T9.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T7.[EmpID], T7.[CotiID], T7.[secID] FROM (([CotizadorLevel1] T7 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T8 WITH (NOLOCK) ON T8.[EmpID] = T7.[EmpID] AND T8.[categID] = T7.[categID] AND T8.[subCatID] = T7.[subCatID]) INNER JOIN [Cotizador] T9 WITH (UPDLOCK) ON T9.[EmpID] = T7.[EmpID] AND T9.[CotiID] = T7.[CotiID]) ) T6 ON T6.[EmpID] = T4.[EmpID] AND T6.[CotiID] = T4.[CotiID] AND T6.[secID] = T4.[secID]) ) T3 ON T3.[EmpID] = T2.[EmpID] AND T3.[CotiID] = T2.[CotiID] AND T3.[secID] = T2.[secID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E41,1,0,true,false )
             ,new CursorDef("T000E44", "SELECT COALESCE( T1.[sumTotValorIVA], 0) AS sumTotValorIVA FROM (SELECT SUM(COALESCE( T3.[CotiDetIva], 0)) AS sumTotValorIVA, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (UPDLOCK) INNER JOIN (SELECT ( CAST(( ( COALESCE( T5.[subCatPrec], 0) * CAST(COALESCE( T4.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T6.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T4.[EmpID], T4.[CotiID], T4.[secID] FROM (([CotizadorLevel1] T4 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T5 WITH (NOLOCK) ON T5.[EmpID] = T4.[EmpID] AND T5.[categID] = T4.[categID] AND T5.[subCatID] = T4.[subCatID]) INNER JOIN [Cotizador] T6 WITH (UPDLOCK) ON T6.[EmpID] = T4.[EmpID] AND T6.[CotiID] = T4.[CotiID]) ) T3 ON T3.[EmpID] = T2.[EmpID] AND T3.[CotiID] = T2.[CotiID] AND T3.[secID] = T2.[secID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E44,1,0,true,false )
             ,new CursorDef("T000E46", "SELECT COALESCE( T1.[ObrSubtotal], 0) AS ObrSubtotal FROM (SELECT SUM([ObrValor]) AS ObrSubtotal, [EmpID], [CotiID] FROM [CotizadorObreros] WITH (UPDLOCK) GROUP BY [EmpID], [CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E46,1,0,true,false )
             ,new CursorDef("T000E48", "SELECT COALESCE( T1.[sumTotCant], 0) AS sumTotCant FROM (SELECT SUM([CotiDetCant]) AS sumTotCant, [EmpID], [CotiID] FROM [CotizadorLevel1] WITH (UPDLOCK) GROUP BY [EmpID], [CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E48,1,0,true,false )
             ,new CursorDef("T000E50", "SELECT COALESCE( T1.[sumTotValor], 0) AS sumTotValor FROM (SELECT SUM(COALESCE( T3.[subCatPrec], 0) * CAST(COALESCE( T2.[CotiDetCant], 0) AS decimal( 20, 10))) AS sumTotValor, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T2.[EmpID] AND T3.[categID] = T2.[categID] AND T3.[subCatID] = T2.[subCatID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E50,1,0,true,false )
             ,new CursorDef("T000E51", "SELECT [EmpID], [CotiID] FROM [Cotizador] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000E51,1,0,true,false )
             ,new CursorDef("T000E52", "SELECT TOP 1 [EmpID], [CotiID] FROM [Cotizador] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [CotiID] > @CotiID) ORDER BY [EmpID], [CotiID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000E52,1,0,true,true )
             ,new CursorDef("T000E53", "SELECT TOP 1 [EmpID], [CotiID] FROM [Cotizador] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [CotiID] < @CotiID) ORDER BY [EmpID] DESC, [CotiID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000E53,1,0,true,true )
             ,new CursorDef("T000E54", "INSERT INTO [Cotizador]([CotiID], [TotNeto], [CotiDsc], [CotiIVA], [CotiUltNro], [CotiUltNroObr], [CotiObs], [EmpID], [protID]) VALUES(@CotiID, @TotNeto, @CotiDsc, @CotiIVA, @CotiUltNro, @CotiUltNroObr, @CotiObs, @EmpID, @protID)", GxErrorMask.GX_NOMASK,prmT000E54)
             ,new CursorDef("T000E55", "UPDATE [Cotizador] SET [TotNeto]=@TotNeto, [CotiDsc]=@CotiDsc, [CotiIVA]=@CotiIVA, [CotiUltNro]=@CotiUltNro, [CotiUltNroObr]=@CotiUltNroObr, [CotiObs]=@CotiObs, [protID]=@protID  WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID", GxErrorMask.GX_NOMASK,prmT000E55)
             ,new CursorDef("T000E56", "DELETE FROM [Cotizador]  WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID", GxErrorMask.GX_NOMASK,prmT000E56)
             ,new CursorDef("T000E57", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E57,1,0,true,false )
             ,new CursorDef("T000E61", "SELECT COALESCE( T1.[sumTotNeto1], 0) AS sumTotNeto1 FROM (SELECT SUM(COALESCE( T3.[CotiDetTotal], 0)) AS sumTotNeto1, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (UPDLOCK) INNER JOIN (SELECT ROUND(( COALESCE( T5.[subCatPrec], 0) * CAST(COALESCE( T4.[CotiDetCant], 0) AS decimal( 20, 10)) + COALESCE( T6.[CotiDetIva], 0)), 2) AS CotiDetTotal, T4.[EmpID], T4.[CotiID], T4.[secID] FROM (([CotizadorLevel1] T4 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T5 WITH (NOLOCK) ON T5.[EmpID] = T4.[EmpID] AND T5.[categID] = T4.[categID] AND T5.[subCatID] = T4.[subCatID]) INNER JOIN (SELECT ( CAST(( ( COALESCE( T8.[subCatPrec], 0) * CAST(COALESCE( T7.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T9.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T7.[EmpID], T7.[CotiID], T7.[secID] FROM (([CotizadorLevel1] T7 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T8 WITH (NOLOCK) ON T8.[EmpID] = T7.[EmpID] AND T8.[categID] = T7.[categID] AND T8.[subCatID] = T7.[subCatID]) INNER JOIN [Cotizador] T9 WITH (UPDLOCK) ON T9.[EmpID] = T7.[EmpID] AND T9.[CotiID] = T7.[CotiID]) ) T6 ON T6.[EmpID] = T4.[EmpID] AND T6.[CotiID] = T4.[CotiID] AND T6.[secID] = T4.[secID]) ) T3 ON T3.[EmpID] = T2.[EmpID] AND T3.[CotiID] = T2.[CotiID] AND T3.[secID] = T2.[secID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E61,1,0,true,false )
             ,new CursorDef("T000E64", "SELECT COALESCE( T1.[sumTotValorIVA], 0) AS sumTotValorIVA FROM (SELECT SUM(COALESCE( T3.[CotiDetIva], 0)) AS sumTotValorIVA, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (UPDLOCK) INNER JOIN (SELECT ( CAST(( ( COALESCE( T5.[subCatPrec], 0) * CAST(COALESCE( T4.[CotiDetCant], 0) AS decimal( 20, 10))) * CAST(COALESCE( T6.[CotiIVA], 0) AS decimal( 20, 10))) AS decimal( 20, 10)) / 100) AS CotiDetIva, T4.[EmpID], T4.[CotiID], T4.[secID] FROM (([CotizadorLevel1] T4 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T5 WITH (NOLOCK) ON T5.[EmpID] = T4.[EmpID] AND T5.[categID] = T4.[categID] AND T5.[subCatID] = T4.[subCatID]) INNER JOIN [Cotizador] T6 WITH (UPDLOCK) ON T6.[EmpID] = T4.[EmpID] AND T6.[CotiID] = T4.[CotiID]) ) T3 ON T3.[EmpID] = T2.[EmpID] AND T3.[CotiID] = T2.[CotiID] AND T3.[secID] = T2.[secID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E64,1,0,true,false )
             ,new CursorDef("T000E66", "SELECT COALESCE( T1.[ObrSubtotal], 0) AS ObrSubtotal FROM (SELECT SUM([ObrValor]) AS ObrSubtotal, [EmpID], [CotiID] FROM [CotizadorObreros] WITH (UPDLOCK) GROUP BY [EmpID], [CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E66,1,0,true,false )
             ,new CursorDef("T000E68", "SELECT COALESCE( T1.[sumTotCant], 0) AS sumTotCant FROM (SELECT SUM([CotiDetCant]) AS sumTotCant, [EmpID], [CotiID] FROM [CotizadorLevel1] WITH (UPDLOCK) GROUP BY [EmpID], [CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E68,1,0,true,false )
             ,new CursorDef("T000E70", "SELECT COALESCE( T1.[sumTotValor], 0) AS sumTotValor FROM (SELECT SUM(COALESCE( T3.[subCatPrec], 0) * CAST(COALESCE( T2.[CotiDetCant], 0) AS decimal( 20, 10))) AS sumTotValor, T2.[EmpID], T2.[CotiID] FROM ([CotizadorLevel1] T2 WITH (UPDLOCK) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T2.[EmpID] AND T3.[categID] = T2.[categID] AND T3.[subCatID] = T2.[subCatID]) GROUP BY T2.[EmpID], T2.[CotiID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[CotiID] = @CotiID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E70,1,0,true,false )
             ,new CursorDef("T000E71", "SELECT [protDsc] FROM [Prototipo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [protID] = @protID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E71,1,0,true,false )
             ,new CursorDef("T000E72", "UPDATE [Cotizador] SET [CotiUltNro]=@CotiUltNro, [TotNeto]=@TotNeto  WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID", GxErrorMask.GX_NOMASK,prmT000E72)
             ,new CursorDef("T000E73", "SELECT [EmpID], [CotiID] FROM [Cotizador] WITH (NOLOCK) ORDER BY [EmpID], [CotiID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000E73,100,0,true,false )
             ,new CursorDef("T000E74", "SELECT T1.[CotiID], T1.[secID], T2.[categDsc], T3.[subCatDsc], T3.[subCatPrec], T1.[CotiDetCant], T1.[EmpID], T1.[detTipoProdID], T1.[categID], T1.[subCatID] FROM (([CotizadorLevel1] T1 WITH (NOLOCK) INNER JOIN [Categorias] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[categID] = T1.[categID] AND T3.[subCatID] = T1.[subCatID]) WHERE T1.[CotiID] = @CotiID and T1.[secID] = @secID and T1.[EmpID] = @EmpID ORDER BY T1.[EmpID], T1.[CotiID], T1.[secID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E74,11,0,true,false )
             ,new CursorDef("T000E75", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E75,1,0,true,false )
             ,new CursorDef("T000E76", "SELECT [subCatDsc], [subCatPrec] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E76,1,0,true,false )
             ,new CursorDef("T000E77", "SELECT [EmpID], [CotiID], [secID] FROM [CotizadorLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID AND [secID] = @secID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E77,1,0,true,false )
             ,new CursorDef("T000E78", "INSERT INTO [CotizadorLevel1]([CotiID], [secID], [CotiDetCant], [EmpID], [detTipoProdID], [categID], [subCatID]) VALUES(@CotiID, @secID, @CotiDetCant, @EmpID, @detTipoProdID, @categID, @subCatID)", GxErrorMask.GX_NOMASK,prmT000E78)
             ,new CursorDef("T000E79", "UPDATE [CotizadorLevel1] SET [CotiDetCant]=@CotiDetCant, [detTipoProdID]=@detTipoProdID, [categID]=@categID, [subCatID]=@subCatID  WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID AND [secID] = @secID", GxErrorMask.GX_NOMASK,prmT000E79)
             ,new CursorDef("T000E80", "DELETE FROM [CotizadorLevel1]  WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID AND [secID] = @secID", GxErrorMask.GX_NOMASK,prmT000E80)
             ,new CursorDef("T000E81", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E81,1,0,true,false )
             ,new CursorDef("T000E82", "SELECT [subCatDsc], [subCatPrec] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E82,1,0,true,false )
             ,new CursorDef("T000E83", "SELECT [EmpID], [CotiID], [secID] FROM [CotizadorLevel1] WITH (NOLOCK) WHERE [CotiID] = @CotiID and [EmpID] = @EmpID ORDER BY [EmpID], [CotiID], [secID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E83,11,0,true,false )
             ,new CursorDef("T000E84", "SELECT [EmpID], [CotiID], [nroSec], [ObrDsc], [ObrValor] FROM [CotizadorObreros] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [CotiID] = @CotiID and [nroSec] = @nroSec ORDER BY [EmpID], [CotiID], [nroSec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E84,11,0,true,false )
             ,new CursorDef("T000E85", "SELECT [EmpID], [CotiID], [nroSec] FROM [CotizadorObreros] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID AND [nroSec] = @nroSec ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E85,1,0,true,false )
             ,new CursorDef("T000E86", "INSERT INTO [CotizadorObreros]([EmpID], [CotiID], [nroSec], [ObrDsc], [ObrValor]) VALUES(@EmpID, @CotiID, @nroSec, @ObrDsc, @ObrValor)", GxErrorMask.GX_NOMASK,prmT000E86)
             ,new CursorDef("T000E87", "UPDATE [CotizadorObreros] SET [ObrDsc]=@ObrDsc, [ObrValor]=@ObrValor  WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID AND [nroSec] = @nroSec", GxErrorMask.GX_NOMASK,prmT000E87)
             ,new CursorDef("T000E88", "DELETE FROM [CotizadorObreros]  WHERE [EmpID] = @EmpID AND [CotiID] = @CotiID AND [nroSec] = @nroSec", GxErrorMask.GX_NOMASK,prmT000E88)
             ,new CursorDef("T000E89", "SELECT [EmpID], [CotiID], [nroSec] FROM [CotizadorObreros] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [CotiID] = @CotiID ORDER BY [EmpID], [CotiID], [nroSec] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E89,11,0,true,false )
             ,new CursorDef("T000E90", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @detTipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E90,1,0,true,false )
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
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((int[]) buf[9])[0] = rslt.getInt(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((short[]) buf[13])[0] = rslt.getShort(8) ;
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((int[]) buf[9])[0] = rslt.getInt(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((short[]) buf[13])[0] = rslt.getShort(8) ;
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 16 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 50) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((int[]) buf[13])[0] = rslt.getInt(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                ((short[]) buf[19])[0] = rslt.getShort(12) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(12);
                ((decimal[]) buf[21])[0] = rslt.getDecimal(13) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(13);
                ((decimal[]) buf[23])[0] = rslt.getDecimal(14) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(14);
                ((decimal[]) buf[25])[0] = rslt.getDecimal(15) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(15);
                ((decimal[]) buf[27])[0] = rslt.getDecimal(16) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(16);
                return;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 21 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 22 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 23 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 24 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 25 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 26 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 27 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 31 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 32 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 33 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 34 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 35 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 36 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 37 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 39 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 40 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((short[]) buf[10])[0] = rslt.getShort(7) ;
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((short[]) buf[12])[0] = rslt.getShort(9) ;
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                return;
             case 41 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 42 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 43 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 47 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 48 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 49 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 50 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                return;
             case 51 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 55 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 56 :
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
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
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
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (decimal)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (decimal)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[12]);
                }
                stmt.SetParameter(8, (short)parms[13]);
                stmt.SetParameter(9, (short)parms[14]);
                return;
             case 29 :
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
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(3, (decimal)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(4, (int)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                stmt.SetParameter(7, (short)parms[12]);
                stmt.SetParameter(8, (short)parms[13]);
                stmt.SetParameter(9, (short)parms[14]);
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
                return;
             case 31 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 32 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 33 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                return;
             case 38 :
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
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (decimal)parms[3]);
                }
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (short)parms[5]);
                return;
             case 40 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 41 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 42 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 43 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 44 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(3, (decimal)parms[3]);
                }
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                stmt.SetParameter(7, (short)parms[7]);
                return;
             case 45 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (decimal)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                stmt.SetParameter(7, (short)parms[7]);
                return;
             case 46 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 47 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 48 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 49 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 50 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 51 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 52 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[6]);
                }
                return;
             case 53 :
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
                stmt.SetParameter(3, (short)parms[4]);
                stmt.SetParameter(4, (short)parms[5]);
                stmt.SetParameter(5, (short)parms[6]);
                return;
             case 54 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 55 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 56 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
