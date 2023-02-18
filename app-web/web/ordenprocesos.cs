/*
               File: OrdenProcesos
        Description: Orden Procesos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:27.71
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
   public class ordenprocesos : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A20ProcID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A20ProcID) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridordenprocesos_level1") == 0 )
         {
            nRC_GXsfl_63 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_63_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_63_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridordenprocesos_level1_newrow( ) ;
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
            Form.Meta.addItem("description", "Orden Procesos", 0) ;
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

      public ordenprocesos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ordenprocesos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Orden Procesos", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_OrdenProcesos.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00k0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"SECUENCIA"+"'), id:'"+"SECUENCIA"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ORDENID"+"'), id:'"+"ORDENID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_OrdenProcesos.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), ((edtEmpID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")) : context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_OrdenProcesos.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenProcesos.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtsecuencia_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtsecuencia_Internalname, "secuencia", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtsecuencia_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A21secuencia), 4, 0, ",", "")), ((edtsecuencia_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A21secuencia), "ZZZ9")) : context.localUtil.Format( (decimal)(A21secuencia), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtsecuencia_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtsecuencia_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenID_Internalname, "Nro. Orden", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")), ((edtOrdenID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9")) : context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdPrcEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdPrcEst_Internalname, "Estado", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdPrcEst_Internalname, A131OrdPrcEst, StringUtil.RTrim( context.localUtil.Format( A131OrdPrcEst, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdPrcEst_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdPrcEst_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenProcesos.htm");
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
            GxWebStd.gx_label_ctrl( context, lblTitlelevel1_Internalname, "Level1", "", "", lblTitlelevel1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridordenprocesos_level1( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProcesos.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0920( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Gridordenprocesos_level1( )
      {
         /*  Grid Control  */
         Gridordenprocesos_level1Container.AddObjectProperty("GridName", "Gridordenprocesos_level1");
         Gridordenprocesos_level1Container.AddObjectProperty("Header", subGridordenprocesos_level1_Header);
         Gridordenprocesos_level1Container.AddObjectProperty("Class", "Grid");
         Gridordenprocesos_level1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridordenprocesos_level1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridordenprocesos_level1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenprocesos_level1_Backcolorstyle), 1, 0, ".", "")));
         Gridordenprocesos_level1Container.AddObjectProperty("CmpContext", "");
         Gridordenprocesos_level1Container.AddObjectProperty("InMasterPage", "false");
         Gridordenprocesos_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenprocesos_level1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23nro), 4, 0, ".", "")));
         Gridordenprocesos_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnro_Enabled), 5, 0, ".", "")));
         Gridordenprocesos_level1Container.AddColumnProperties(Gridordenprocesos_level1Column);
         Gridordenprocesos_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenprocesos_level1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A20ProcID), 4, 0, ".", "")));
         Gridordenprocesos_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProcID_Enabled), 5, 0, ".", "")));
         Gridordenprocesos_level1Container.AddColumnProperties(Gridordenprocesos_level1Column);
         Gridordenprocesos_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenprocesos_level1Container.AddColumnProperties(Gridordenprocesos_level1Column);
         Gridordenprocesos_level1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridordenprocesos_level1Column.AddObjectProperty("Value", StringUtil.RTrim( A128ProcDsc));
         Gridordenprocesos_level1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProcDsc_Enabled), 5, 0, ".", "")));
         Gridordenprocesos_level1Container.AddColumnProperties(Gridordenprocesos_level1Column);
         Gridordenprocesos_level1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenprocesos_level1_Selectedindex), 4, 0, ".", "")));
         Gridordenprocesos_level1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenprocesos_level1_Allowselection), 1, 0, ".", "")));
         Gridordenprocesos_level1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenprocesos_level1_Selectioncolor), 9, 0, ".", "")));
         Gridordenprocesos_level1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenprocesos_level1_Allowhovering), 1, 0, ".", "")));
         Gridordenprocesos_level1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenprocesos_level1_Hoveringcolor), 9, 0, ".", "")));
         Gridordenprocesos_level1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenprocesos_level1_Allowcollapsing), 1, 0, ".", "")));
         Gridordenprocesos_level1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridordenprocesos_level1_Collapsed), 1, 0, ".", "")));
         nGXsfl_63_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount21 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_21 = 1;
               ScanStart0921( ) ;
               while ( RcdFound21 != 0 )
               {
                  init_level_properties21( ) ;
                  getByPrimaryKey0921( ) ;
                  AddRow0921( ) ;
                  ScanNext0921( ) ;
               }
               ScanEnd0921( ) ;
               nBlankRcdCount21 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0921( ) ;
            standaloneModal0921( ) ;
            sMode21 = Gx_mode;
            while ( nGXsfl_63_idx < nRC_GXsfl_63 )
            {
               bGXsfl_63_Refreshing = true;
               ReadRow0921( ) ;
               edtnro_Enabled = (int)(context.localUtil.CToN( cgiGet( "NRO_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnro_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtProcID_Enabled = (int)(context.localUtil.CToN( cgiGet( "PROCID_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProcID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProcID_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtProcDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "PROCDSC_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProcDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProcDsc_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_20_"+sGXsfl_63_idx+"Link");
               if ( ( nRcdExists_21 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal0921( ) ;
               }
               SendRow0921( ) ;
               bGXsfl_63_Refreshing = false;
            }
            Gx_mode = sMode21;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount21 = 5;
            nRcdExists_21 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0921( ) ;
               while ( RcdFound21 != 0 )
               {
                  sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_6321( ) ;
                  init_level_properties21( ) ;
                  standaloneNotModal0921( ) ;
                  getByPrimaryKey0921( ) ;
                  standaloneModal0921( ) ;
                  AddRow0921( ) ;
                  ScanNext0921( ) ;
               }
               ScanEnd0921( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode21 = Gx_mode;
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx+1), 4, 0)), 4, "0");
         SubsflControlProps_6321( ) ;
         InitAll0921( ) ;
         init_level_properties21( ) ;
         standaloneNotModal0921( ) ;
         standaloneModal0921( ) ;
         nRcdExists_21 = 0;
         nIsMod_21 = 0;
         nRcdDeleted_21 = 0;
         nBlankRcdCount21 = (short)(nBlankRcdUsr21+nBlankRcdCount21);
         fRowAdded = 0;
         while ( nBlankRcdCount21 > 0 )
         {
            AddRow0921( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtnro_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount21 = (short)(nBlankRcdCount21-1);
         }
         Gx_mode = sMode21;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridordenprocesos_level1Container"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridordenprocesos_level1", Gridordenprocesos_level1Container);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridordenprocesos_level1ContainerData", Gridordenprocesos_level1Container.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridordenprocesos_level1ContainerData"+"V", Gridordenprocesos_level1Container.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridordenprocesos_level1ContainerData"+"V"+"\" value='"+Gridordenprocesos_level1Container.GridValuesHidden()+"'/>") ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtsecuencia_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtsecuencia_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SECUENCIA");
                  AnyError = 1;
                  GX_FocusControl = edtsecuencia_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A21secuencia = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
               }
               else
               {
                  A21secuencia = (short)(context.localUtil.CToN( cgiGet( edtsecuencia_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORDENID");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A22OrdenID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               }
               else
               {
                  A22OrdenID = (short)(context.localUtil.CToN( cgiGet( edtOrdenID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               }
               A131OrdPrcEst = cgiGet( edtOrdPrcEst_Internalname);
               n131OrdPrcEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131OrdPrcEst", A131OrdPrcEst);
               n131OrdPrcEst = (String.IsNullOrEmpty(StringUtil.RTrim( A131OrdPrcEst)) ? true : false);
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z21secuencia = (short)(context.localUtil.CToN( cgiGet( "Z21secuencia"), ",", "."));
               Z22OrdenID = (short)(context.localUtil.CToN( cgiGet( "Z22OrdenID"), ",", "."));
               Z131OrdPrcEst = cgiGet( "Z131OrdPrcEst");
               n131OrdPrcEst = (String.IsNullOrEmpty(StringUtil.RTrim( A131OrdPrcEst)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_63 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_63"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
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
                  A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A21secuencia = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
                  A22OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                        btn_enter( ) ;
                        /* No code required for Cancel button. It is implemented as the Reset button. */
                     }
                     else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_first( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_previous( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_next( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_last( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_select( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                     {
                        context.wbHandled = 1;
                        btn_delete( ) ;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                     {
                        context.wbHandled = 1;
                        AfterKeyLoadScreen( ) ;
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
               InitAll0920( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
      }

      protected void disable_std_buttons_dsp( )
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
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
         }
         DisableAttributes0920( ) ;
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

      protected void CONFIRM_0921( )
      {
         nGXsfl_63_idx = 0;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            ReadRow0921( ) ;
            if ( ( nRcdExists_21 != 0 ) || ( nIsMod_21 != 0 ) )
            {
               GetKey0921( ) ;
               if ( ( nRcdExists_21 == 0 ) && ( nRcdDeleted_21 == 0 ) )
               {
                  if ( RcdFound21 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0921( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0921( ) ;
                        CloseExtendedTableCursors0921( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "NRO_" + sGXsfl_63_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtnro_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound21 != 0 )
                  {
                     if ( nRcdDeleted_21 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0921( ) ;
                        Load0921( ) ;
                        BeforeValidate0921( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0921( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_21 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0921( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0921( ) ;
                              CloseExtendedTableCursors0921( ) ;
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
                     if ( nRcdDeleted_21 == 0 )
                     {
                        GXCCtl = "NRO_" + sGXsfl_63_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtnro_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtnro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A23nro), 4, 0, ",", ""))) ;
            ChangePostValue( edtProcID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20ProcID), 4, 0, ",", ""))) ;
            ChangePostValue( edtProcDsc_Internalname, StringUtil.RTrim( A128ProcDsc)) ;
            ChangePostValue( "ZT_"+"Z23nro_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23nro), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z20ProcID_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20ProcID), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_21_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_21), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_21_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_21), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_21_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_21), 4, 0, ",", ""))) ;
            if ( nIsMod_21 != 0 )
            {
               ChangePostValue( "NRO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnro_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PROCID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProcID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PROCDSC_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProcDsc_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption090( )
      {
      }

      protected void ZM0920( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z131OrdPrcEst = T00096_A131OrdPrcEst[0];
            }
            else
            {
               Z131OrdPrcEst = A131OrdPrcEst;
            }
         }
         if ( GX_JID == -1 )
         {
            Z21secuencia = A21secuencia;
            Z22OrdenID = A22OrdenID;
            Z131OrdPrcEst = A131OrdPrcEst;
            Z1EmpID = A1EmpID;
            Z44empdsc = A44empdsc;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
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
      }

      protected void Load0920( )
      {
         /* Using cursor T00098 */
         pr_default.execute(6, new Object[] {A1EmpID, A21secuencia, A22OrdenID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound20 = 1;
            A44empdsc = T00098_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T00098_n44empdsc[0];
            A131OrdPrcEst = T00098_A131OrdPrcEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131OrdPrcEst", A131OrdPrcEst);
            n131OrdPrcEst = T00098_n131OrdPrcEst[0];
            ZM0920( -1) ;
         }
         pr_default.close(6);
         OnLoadActions0920( ) ;
      }

      protected void OnLoadActions0920( )
      {
      }

      protected void CheckExtendedTable0920( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00097_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00097_n44empdsc[0];
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors0920( )
      {
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A1EmpID )
      {
         /* Using cursor T00099 */
         pr_default.execute(7, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T00099_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T00099_n44empdsc[0];
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

      protected void GetKey0920( )
      {
         /* Using cursor T000910 */
         pr_default.execute(8, new Object[] {A1EmpID, A21secuencia, A22OrdenID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound20 = 1;
         }
         else
         {
            RcdFound20 = 0;
         }
         pr_default.close(8);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00096 */
         pr_default.execute(4, new Object[] {A1EmpID, A21secuencia, A22OrdenID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM0920( 1) ;
            RcdFound20 = 1;
            A21secuencia = T00096_A21secuencia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
            A22OrdenID = T00096_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A131OrdPrcEst = T00096_A131OrdPrcEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131OrdPrcEst", A131OrdPrcEst);
            n131OrdPrcEst = T00096_n131OrdPrcEst[0];
            A1EmpID = T00096_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            Z1EmpID = A1EmpID;
            Z21secuencia = A21secuencia;
            Z22OrdenID = A22OrdenID;
            sMode20 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0920( ) ;
            if ( AnyError == 1 )
            {
               RcdFound20 = 0;
               InitializeNonKey0920( ) ;
            }
            Gx_mode = sMode20;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound20 = 0;
            InitializeNonKey0920( ) ;
            sMode20 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode20;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey0920( ) ;
         if ( RcdFound20 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound20 = 0;
         /* Using cursor T000911 */
         pr_default.execute(9, new Object[] {A1EmpID, A21secuencia, A22OrdenID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000911_A1EmpID[0] < A1EmpID ) || ( T000911_A1EmpID[0] == A1EmpID ) && ( T000911_A21secuencia[0] < A21secuencia ) || ( T000911_A21secuencia[0] == A21secuencia ) && ( T000911_A1EmpID[0] == A1EmpID ) && ( T000911_A22OrdenID[0] < A22OrdenID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000911_A1EmpID[0] > A1EmpID ) || ( T000911_A1EmpID[0] == A1EmpID ) && ( T000911_A21secuencia[0] > A21secuencia ) || ( T000911_A21secuencia[0] == A21secuencia ) && ( T000911_A1EmpID[0] == A1EmpID ) && ( T000911_A22OrdenID[0] > A22OrdenID ) ) )
            {
               A1EmpID = T000911_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A21secuencia = T000911_A21secuencia[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
               A22OrdenID = T000911_A22OrdenID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               RcdFound20 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void move_previous( )
      {
         RcdFound20 = 0;
         /* Using cursor T000912 */
         pr_default.execute(10, new Object[] {A1EmpID, A21secuencia, A22OrdenID});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000912_A1EmpID[0] > A1EmpID ) || ( T000912_A1EmpID[0] == A1EmpID ) && ( T000912_A21secuencia[0] > A21secuencia ) || ( T000912_A21secuencia[0] == A21secuencia ) && ( T000912_A1EmpID[0] == A1EmpID ) && ( T000912_A22OrdenID[0] > A22OrdenID ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000912_A1EmpID[0] < A1EmpID ) || ( T000912_A1EmpID[0] == A1EmpID ) && ( T000912_A21secuencia[0] < A21secuencia ) || ( T000912_A21secuencia[0] == A21secuencia ) && ( T000912_A1EmpID[0] == A1EmpID ) && ( T000912_A22OrdenID[0] < A22OrdenID ) ) )
            {
               A1EmpID = T000912_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A21secuencia = T000912_A21secuencia[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
               A22OrdenID = T000912_A22OrdenID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               RcdFound20 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0920( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0920( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound20 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A21secuencia != Z21secuencia ) || ( A22OrdenID != Z22OrdenID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A21secuencia = Z21secuencia;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
                  A22OrdenID = Z22OrdenID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
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
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0920( ) ;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A21secuencia != Z21secuencia ) || ( A22OrdenID != Z22OrdenID ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0920( ) ;
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
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtEmpID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0920( ) ;
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
      }

      protected void btn_delete( )
      {
         if ( ( A1EmpID != Z1EmpID ) || ( A21secuencia != Z21secuencia ) || ( A22OrdenID != Z22OrdenID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A21secuencia = Z21secuencia;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
            A22OrdenID = Z22OrdenID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
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
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtOrdPrcEst_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0920( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtOrdPrcEst_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0920( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_previous( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtOrdPrcEst_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_next( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtOrdPrcEst_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0920( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound20 != 0 )
            {
               ScanNext0920( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtOrdPrcEst_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0920( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0920( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00095 */
            pr_default.execute(3, new Object[] {A1EmpID, A21secuencia, A22OrdenID});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenProcesos"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( StringUtil.StrCmp(Z131OrdPrcEst, T00095_A131OrdPrcEst[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z131OrdPrcEst, T00095_A131OrdPrcEst[0]) != 0 )
               {
                  GXUtil.WriteLog("ordenprocesos:[seudo value changed for attri]"+"OrdPrcEst");
                  GXUtil.WriteLogRaw("Old: ",Z131OrdPrcEst);
                  GXUtil.WriteLogRaw("Current: ",T00095_A131OrdPrcEst[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"OrdenProcesos"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0920( )
      {
         BeforeValidate0920( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0920( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0920( 0) ;
            CheckOptimisticConcurrency0920( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0920( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0920( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000913 */
                     pr_default.execute(11, new Object[] {A21secuencia, A22OrdenID, n131OrdPrcEst, A131OrdPrcEst, A1EmpID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProcesos") ;
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
                           ProcessLevel0920( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption090( ) ;
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
               Load0920( ) ;
            }
            EndLevel0920( ) ;
         }
         CloseExtendedTableCursors0920( ) ;
      }

      protected void Update0920( )
      {
         BeforeValidate0920( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0920( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0920( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0920( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0920( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000914 */
                     pr_default.execute(12, new Object[] {n131OrdPrcEst, A131OrdPrcEst, A1EmpID, A21secuencia, A22OrdenID});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProcesos") ;
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenProcesos"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0920( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0920( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                              ResetCaption090( ) ;
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
            EndLevel0920( ) ;
         }
         CloseExtendedTableCursors0920( ) ;
      }

      protected void DeferredUpdate0920( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0920( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0920( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0920( ) ;
            AfterConfirm0920( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0920( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0921( ) ;
                  while ( RcdFound21 != 0 )
                  {
                     getByPrimaryKey0921( ) ;
                     Delete0921( ) ;
                     ScanNext0921( ) ;
                  }
                  ScanEnd0921( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000915 */
                     pr_default.execute(13, new Object[] {A1EmpID, A21secuencia, A22OrdenID});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProcesos") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound20 == 0 )
                           {
                              InitAll0920( ) ;
                              Gx_mode = "INS";
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           }
                           else
                           {
                              getByPrimaryKey( ) ;
                              Gx_mode = "UPD";
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           }
                           GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                           ResetCaption090( ) ;
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
         sMode20 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0920( ) ;
         Gx_mode = sMode20;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0920( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000916 */
            pr_default.execute(14, new Object[] {A1EmpID});
            A44empdsc = T000916_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000916_n44empdsc[0];
            pr_default.close(14);
         }
      }

      protected void ProcessNestedLevel0921( )
      {
         nGXsfl_63_idx = 0;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            ReadRow0921( ) ;
            if ( ( nRcdExists_21 != 0 ) || ( nIsMod_21 != 0 ) )
            {
               standaloneNotModal0921( ) ;
               GetKey0921( ) ;
               if ( ( nRcdExists_21 == 0 ) && ( nRcdDeleted_21 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  Insert0921( ) ;
               }
               else
               {
                  if ( RcdFound21 != 0 )
                  {
                     if ( ( nRcdDeleted_21 != 0 ) && ( nRcdExists_21 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0921( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_21 != 0 ) && ( nRcdExists_21 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0921( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_21 == 0 )
                     {
                        GXCCtl = "NRO_" + sGXsfl_63_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtnro_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtnro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A23nro), 4, 0, ",", ""))) ;
            ChangePostValue( edtProcID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20ProcID), 4, 0, ",", ""))) ;
            ChangePostValue( edtProcDsc_Internalname, StringUtil.RTrim( A128ProcDsc)) ;
            ChangePostValue( "ZT_"+"Z23nro_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23nro), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z20ProcID_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20ProcID), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_21_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_21), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_21_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_21), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_21_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_21), 4, 0, ",", ""))) ;
            if ( nIsMod_21 != 0 )
            {
               ChangePostValue( "NRO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnro_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PROCID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProcID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PROCDSC_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProcDsc_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0921( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_21 = 0;
         nIsMod_21 = 0;
         nRcdDeleted_21 = 0;
      }

      protected void ProcessLevel0920( )
      {
         /* Save parent mode. */
         sMode20 = Gx_mode;
         ProcessNestedLevel0921( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode20;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0920( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0920( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(14);
            pr_default.close(2);
            context.CommitDataStores("ordenprocesos",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues090( ) ;
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
            context.RollbackDataStores("ordenprocesos",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0920( )
      {
         /* Using cursor T000917 */
         pr_default.execute(15);
         RcdFound20 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound20 = 1;
            A1EmpID = T000917_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A21secuencia = T000917_A21secuencia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
            A22OrdenID = T000917_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0920( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound20 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound20 = 1;
            A1EmpID = T000917_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A21secuencia = T000917_A21secuencia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
            A22OrdenID = T000917_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         }
      }

      protected void ScanEnd0920( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0920( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0920( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0920( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0920( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0920( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0920( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0920( )
      {
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         edtsecuencia_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsecuencia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsecuencia_Enabled), 5, 0)), true);
         edtOrdenID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenID_Enabled), 5, 0)), true);
         edtOrdPrcEst_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdPrcEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdPrcEst_Enabled), 5, 0)), true);
      }

      protected void ZM0921( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z20ProcID = T00093_A20ProcID[0];
            }
            else
            {
               Z20ProcID = A20ProcID;
            }
         }
         if ( GX_JID == -3 )
         {
            Z1EmpID = A1EmpID;
            Z21secuencia = A21secuencia;
            Z22OrdenID = A22OrdenID;
            Z23nro = A23nro;
            Z20ProcID = A20ProcID;
            Z128ProcDsc = A128ProcDsc;
         }
      }

      protected void standaloneNotModal0921( )
      {
      }

      protected void standaloneModal0921( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtnro_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnro_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         }
         else
         {
            edtnro_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnro_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         }
      }

      protected void Load0921( )
      {
         /* Using cursor T000918 */
         pr_default.execute(16, new Object[] {A1EmpID, A21secuencia, A22OrdenID, A23nro});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound21 = 1;
            A128ProcDsc = T000918_A128ProcDsc[0];
            n128ProcDsc = T000918_n128ProcDsc[0];
            A20ProcID = T000918_A20ProcID[0];
            ZM0921( -3) ;
         }
         pr_default.close(16);
         OnLoadActions0921( ) ;
      }

      protected void OnLoadActions0921( )
      {
      }

      protected void CheckExtendedTable0921( )
      {
         Gx_BScreen = 1;
         standaloneModal0921( ) ;
         /* Using cursor T00094 */
         pr_default.execute(2, new Object[] {A20ProcID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "PROCID_" + sGXsfl_63_idx;
            GX_msglist.addItem("No existe 'Procesos'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtProcID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A128ProcDsc = T00094_A128ProcDsc[0];
         n128ProcDsc = T00094_n128ProcDsc[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0921( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0921( )
      {
      }

      protected void gxLoad_4( short A20ProcID )
      {
         /* Using cursor T000919 */
         pr_default.execute(17, new Object[] {A20ProcID});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GXCCtl = "PROCID_" + sGXsfl_63_idx;
            GX_msglist.addItem("No existe 'Procesos'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtProcID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A128ProcDsc = T000919_A128ProcDsc[0];
         n128ProcDsc = T000919_n128ProcDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A128ProcDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(17) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(17);
      }

      protected void GetKey0921( )
      {
         /* Using cursor T000920 */
         pr_default.execute(18, new Object[] {A1EmpID, A21secuencia, A22OrdenID, A23nro});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound21 = 1;
         }
         else
         {
            RcdFound21 = 0;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey0921( )
      {
         /* Using cursor T00093 */
         pr_default.execute(1, new Object[] {A1EmpID, A21secuencia, A22OrdenID, A23nro});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0921( 3) ;
            RcdFound21 = 1;
            InitializeNonKey0921( ) ;
            A23nro = T00093_A23nro[0];
            A20ProcID = T00093_A20ProcID[0];
            Z1EmpID = A1EmpID;
            Z21secuencia = A21secuencia;
            Z22OrdenID = A22OrdenID;
            Z23nro = A23nro;
            sMode21 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0921( ) ;
            Load0921( ) ;
            Gx_mode = sMode21;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound21 = 0;
            InitializeNonKey0921( ) ;
            sMode21 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0921( ) ;
            Gx_mode = sMode21;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0921( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0921( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00092 */
            pr_default.execute(0, new Object[] {A1EmpID, A21secuencia, A22OrdenID, A23nro});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenProcesosLevel1"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z20ProcID != T00092_A20ProcID[0] ) )
            {
               if ( Z20ProcID != T00092_A20ProcID[0] )
               {
                  GXUtil.WriteLog("ordenprocesos:[seudo value changed for attri]"+"ProcID");
                  GXUtil.WriteLogRaw("Old: ",Z20ProcID);
                  GXUtil.WriteLogRaw("Current: ",T00092_A20ProcID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"OrdenProcesosLevel1"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0921( )
      {
         BeforeValidate0921( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0921( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0921( 0) ;
            CheckOptimisticConcurrency0921( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0921( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0921( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000921 */
                     pr_default.execute(19, new Object[] {A1EmpID, A21secuencia, A22OrdenID, A23nro, A20ProcID});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProcesosLevel1") ;
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
               Load0921( ) ;
            }
            EndLevel0921( ) ;
         }
         CloseExtendedTableCursors0921( ) ;
      }

      protected void Update0921( )
      {
         BeforeValidate0921( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0921( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0921( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0921( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0921( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000922 */
                     pr_default.execute(20, new Object[] {A20ProcID, A1EmpID, A21secuencia, A22OrdenID, A23nro});
                     pr_default.close(20);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProcesosLevel1") ;
                     if ( (pr_default.getStatus(20) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenProcesosLevel1"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0921( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0921( ) ;
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
            EndLevel0921( ) ;
         }
         CloseExtendedTableCursors0921( ) ;
      }

      protected void DeferredUpdate0921( )
      {
      }

      protected void Delete0921( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0921( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0921( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0921( ) ;
            AfterConfirm0921( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0921( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000923 */
                  pr_default.execute(21, new Object[] {A1EmpID, A21secuencia, A22OrdenID, A23nro});
                  pr_default.close(21);
                  dsDefault.SmartCacheProvider.SetUpdated("OrdenProcesosLevel1") ;
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
         sMode21 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0921( ) ;
         Gx_mode = sMode21;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0921( )
      {
         standaloneModal0921( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000924 */
            pr_default.execute(22, new Object[] {A20ProcID});
            A128ProcDsc = T000924_A128ProcDsc[0];
            n128ProcDsc = T000924_n128ProcDsc[0];
            pr_default.close(22);
         }
      }

      protected void EndLevel0921( )
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

      public void ScanStart0921( )
      {
         /* Scan By routine */
         /* Using cursor T000925 */
         pr_default.execute(23, new Object[] {A1EmpID, A21secuencia, A22OrdenID});
         RcdFound21 = 0;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound21 = 1;
            A23nro = T000925_A23nro[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0921( )
      {
         /* Scan next routine */
         pr_default.readNext(23);
         RcdFound21 = 0;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound21 = 1;
            A23nro = T000925_A23nro[0];
         }
      }

      protected void ScanEnd0921( )
      {
         pr_default.close(23);
      }

      protected void AfterConfirm0921( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0921( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0921( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0921( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0921( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0921( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0921( )
      {
         edtnro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnro_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtProcID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProcID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProcID_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtProcDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProcDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProcDsc_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
      }

      protected void send_integrity_lvl_hashes0921( )
      {
      }

      protected void send_integrity_lvl_hashes0920( )
      {
      }

      protected void SubsflControlProps_6321( )
      {
         edtnro_Internalname = "NRO_"+sGXsfl_63_idx;
         edtProcID_Internalname = "PROCID_"+sGXsfl_63_idx;
         imgprompt_20_Internalname = "PROMPT_20_"+sGXsfl_63_idx;
         edtProcDsc_Internalname = "PROCDSC_"+sGXsfl_63_idx;
      }

      protected void SubsflControlProps_fel_6321( )
      {
         edtnro_Internalname = "NRO_"+sGXsfl_63_fel_idx;
         edtProcID_Internalname = "PROCID_"+sGXsfl_63_fel_idx;
         imgprompt_20_Internalname = "PROMPT_20_"+sGXsfl_63_fel_idx;
         edtProcDsc_Internalname = "PROCDSC_"+sGXsfl_63_fel_idx;
      }

      protected void AddRow0921( )
      {
         nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_6321( ) ;
         SendRow0921( ) ;
      }

      protected void SendRow0921( )
      {
         Gridordenprocesos_level1Row = GXWebRow.GetNew(context);
         if ( subGridordenprocesos_level1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridordenprocesos_level1_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridordenprocesos_level1_Class, "") != 0 )
            {
               subGridordenprocesos_level1_Linesclass = subGridordenprocesos_level1_Class+"Odd";
            }
         }
         else if ( subGridordenprocesos_level1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridordenprocesos_level1_Backstyle = 0;
            subGridordenprocesos_level1_Backcolor = subGridordenprocesos_level1_Allbackcolor;
            if ( StringUtil.StrCmp(subGridordenprocesos_level1_Class, "") != 0 )
            {
               subGridordenprocesos_level1_Linesclass = subGridordenprocesos_level1_Class+"Uniform";
            }
         }
         else if ( subGridordenprocesos_level1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridordenprocesos_level1_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridordenprocesos_level1_Class, "") != 0 )
            {
               subGridordenprocesos_level1_Linesclass = subGridordenprocesos_level1_Class+"Odd";
            }
            subGridordenprocesos_level1_Backcolor = (int)(0x0);
         }
         else if ( subGridordenprocesos_level1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridordenprocesos_level1_Backstyle = 1;
            if ( ((int)(((nGXsfl_63_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridordenprocesos_level1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridordenprocesos_level1_Class, "") != 0 )
               {
                  subGridordenprocesos_level1_Linesclass = subGridordenprocesos_level1_Class+"Odd";
               }
            }
            else
            {
               subGridordenprocesos_level1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridordenprocesos_level1_Class, "") != 0 )
               {
                  subGridordenprocesos_level1_Linesclass = subGridordenprocesos_level1_Class+"Even";
               }
            }
         }
         imgprompt_20_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00j0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PROCID_"+sGXsfl_63_idx+"'), id:'"+"PROCID_"+sGXsfl_63_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_21_"+sGXsfl_63_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_21_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridordenprocesos_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtnro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A23nro), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A23nro), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtnro_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtnro_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_21_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridordenprocesos_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProcID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A20ProcID), 4, 0, ",", "")),((edtProcID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A20ProcID), "ZZZ9")) : context.localUtil.Format( (decimal)(A20ProcID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProcID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtProcID_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridordenprocesos_level1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_20_Internalname,(String)sImgUrl,(String)imgprompt_20_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_20_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridordenprocesos_level1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProcDsc_Internalname,StringUtil.RTrim( A128ProcDsc),StringUtil.RTrim( context.localUtil.Format( A128ProcDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProcDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtProcDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridordenprocesos_level1Row);
         send_integrity_lvl_hashes0921( ) ;
         GXCCtl = "Z23nro_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23nro), 4, 0, ",", "")));
         GXCCtl = "Z20ProcID_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20ProcID), 4, 0, ",", "")));
         GXCCtl = "nRcdDeleted_21_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_21), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_21_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_21), 4, 0, ",", "")));
         GXCCtl = "nIsMod_21_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_21), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "NRO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtnro_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROCID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProcID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROCDSC_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProcDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_20_"+sGXsfl_63_idx+"Link", StringUtil.RTrim( imgprompt_20_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridordenprocesos_level1Container.AddRow(Gridordenprocesos_level1Row);
      }

      protected void ReadRow0921( )
      {
         nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_6321( ) ;
         edtnro_Enabled = (int)(context.localUtil.CToN( cgiGet( "NRO_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         edtProcID_Enabled = (int)(context.localUtil.CToN( cgiGet( "PROCID_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         edtProcDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "PROCDSC_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         imgprompt_1_Link = cgiGet( "PROMPT_20_"+sGXsfl_63_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtnro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtnro_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "NRO_" + sGXsfl_63_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtnro_Internalname;
            wbErr = true;
            A23nro = 0;
         }
         else
         {
            A23nro = (short)(context.localUtil.CToN( cgiGet( edtnro_Internalname), ",", "."));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtProcID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtProcID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "PROCID_" + sGXsfl_63_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtProcID_Internalname;
            wbErr = true;
            A20ProcID = 0;
         }
         else
         {
            A20ProcID = (short)(context.localUtil.CToN( cgiGet( edtProcID_Internalname), ",", "."));
         }
         A128ProcDsc = StringUtil.Upper( cgiGet( edtProcDsc_Internalname));
         n128ProcDsc = false;
         GXCCtl = "Z23nro_" + sGXsfl_63_idx;
         Z23nro = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z20ProcID_" + sGXsfl_63_idx;
         Z20ProcID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdDeleted_21_" + sGXsfl_63_idx;
         nRcdDeleted_21 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_21_" + sGXsfl_63_idx;
         nRcdExists_21 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_21_" + sGXsfl_63_idx;
         nIsMod_21 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtnro_Enabled = edtnro_Enabled;
      }

      protected void ConfirmValues090( )
      {
         nGXsfl_63_idx = 0;
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_6321( ) ;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
            SubsflControlProps_6321( ) ;
            ChangePostValue( "Z23nro_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z23nro_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z23nro_"+sGXsfl_63_idx) ;
            ChangePostValue( "Z20ProcID_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z20ProcID_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z20ProcID_"+sGXsfl_63_idx) ;
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
         context.SendWebValue( "Orden Procesos") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2022102620132998", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("ordenprocesos.aspx") +"\">") ;
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
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z21secuencia", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z21secuencia), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z22OrdenID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z131OrdPrcEst", Z131OrdPrcEst);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_63", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_63_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
      }

      protected void RenderHtmlCloseForm0920( )
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
         return "OrdenProcesos" ;
      }

      public override String GetPgmdesc( )
      {
         return "Orden Procesos" ;
      }

      protected void InitializeNonKey0920( )
      {
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A131OrdPrcEst = "";
         n131OrdPrcEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131OrdPrcEst", A131OrdPrcEst);
         n131OrdPrcEst = (String.IsNullOrEmpty(StringUtil.RTrim( A131OrdPrcEst)) ? true : false);
         Z131OrdPrcEst = "";
      }

      protected void InitAll0920( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A21secuencia = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21secuencia", StringUtil.LTrim( StringUtil.Str( (decimal)(A21secuencia), 4, 0)));
         A22OrdenID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         InitializeNonKey0920( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0921( )
      {
         A20ProcID = 0;
         A128ProcDsc = "";
         n128ProcDsc = false;
         Z20ProcID = 0;
      }

      protected void InitAll0921( )
      {
         A23nro = 0;
         InitializeNonKey0921( ) ;
      }

      protected void StandaloneModalInsert0921( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202210262013303", true);
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
         context.AddJavascriptSource("ordenprocesos.js", "?202210262013303", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties21( )
      {
         edtnro_Enabled = defedtnro_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtnro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtnro_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
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
         edtsecuencia_Internalname = "SECUENCIA";
         edtOrdenID_Internalname = "ORDENID";
         edtOrdPrcEst_Internalname = "ORDPRCEST";
         lblTitlelevel1_Internalname = "TITLELEVEL1";
         edtnro_Internalname = "NRO";
         edtProcID_Internalname = "PROCID";
         edtProcDsc_Internalname = "PROCDSC";
         divLevel1table_Internalname = "LEVEL1TABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_20_Internalname = "PROMPT_20";
         subGridordenprocesos_level1_Internalname = "GRIDORDENPROCESOS_LEVEL1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtProcDsc_Jsonclick = "";
         imgprompt_20_Visible = 1;
         imgprompt_20_Link = "";
         imgprompt_1_Visible = 1;
         edtProcID_Jsonclick = "";
         edtnro_Jsonclick = "";
         subGridordenprocesos_level1_Class = "Grid";
         subGridordenprocesos_level1_Backcolorstyle = 0;
         subGridordenprocesos_level1_Allowcollapsing = 0;
         subGridordenprocesos_level1_Allowselection = 0;
         edtProcDsc_Enabled = 0;
         edtProcID_Enabled = 1;
         edtnro_Enabled = 1;
         subGridordenprocesos_level1_Header = "";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtOrdPrcEst_Jsonclick = "";
         edtOrdPrcEst_Enabled = 1;
         edtOrdenID_Jsonclick = "";
         edtOrdenID_Enabled = 1;
         edtsecuencia_Jsonclick = "";
         edtsecuencia_Enabled = 1;
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

      protected void gxnrGridordenprocesos_level1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_6321( ) ;
         while ( nGXsfl_63_idx <= nRC_GXsfl_63 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0921( ) ;
            standaloneModal0921( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0921( ) ;
            nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
            SubsflControlProps_6321( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridordenprocesos_level1Container));
         /* End function gxnrGridordenprocesos_level1_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         /* Using cursor T000916 */
         pr_default.execute(14, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000916_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000916_n44empdsc[0];
         pr_default.close(14);
         GX_FocusControl = edtOrdPrcEst_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               String GX_Parm2 )
      {
         A1EmpID = GX_Parm1;
         A44empdsc = GX_Parm2;
         n44empdsc = false;
         /* Using cursor T000916 */
         pr_default.execute(14, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000916_A44empdsc[0];
         n44empdsc = T000916_n44empdsc[0];
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

      public void Valid_Ordenid( String GX_Parm1 ,
                                 short GX_Parm2 ,
                                 short GX_Parm3 ,
                                 short GX_Parm4 ,
                                 String GX_Parm5 )
      {
         Gx_mode = GX_Parm1;
         A1EmpID = GX_Parm2;
         A21secuencia = GX_Parm3;
         A22OrdenID = GX_Parm4;
         A131OrdPrcEst = GX_Parm5;
         n131OrdPrcEst = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A44empdsc = "";
            n44empdsc = false;
         }
         isValidOutput.Add(A131OrdPrcEst);
         isValidOutput.Add(A44empdsc);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z21secuencia), 4, 0, ",", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22OrdenID), 4, 0, ",", "")));
         isValidOutput.Add(Z131OrdPrcEst);
         isValidOutput.Add(Z44empdsc);
         isValidOutput.Add(Gridordenprocesos_level1Container);
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Procid( short GX_Parm1 ,
                                String GX_Parm2 )
      {
         A20ProcID = GX_Parm1;
         A128ProcDsc = GX_Parm2;
         n128ProcDsc = false;
         /* Using cursor T000924 */
         pr_default.execute(22, new Object[] {A20ProcID});
         if ( (pr_default.getStatus(22) == 101) )
         {
            GX_msglist.addItem("No existe 'Procesos'.", "ForeignKeyNotFound", 1, "PROCID");
            AnyError = 1;
            GX_FocusControl = edtProcID_Internalname;
         }
         A128ProcDsc = T000924_A128ProcDsc[0];
         n128ProcDsc = T000924_n128ProcDsc[0];
         pr_default.close(22);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A128ProcDsc = "";
            n128ProcDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A128ProcDsc));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
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
         pr_default.close(22);
         pr_default.close(4);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z131OrdPrcEst = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         Gx_mode = "";
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
         A131OrdPrcEst = "";
         lblTitlelevel1_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridordenprocesos_level1Container = new GXWebGrid( context);
         Gridordenprocesos_level1Column = new GXWebColumn();
         A128ProcDsc = "";
         sMode21 = "";
         sStyleString = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         Z44empdsc = "";
         T00098_A21secuencia = new short[1] ;
         T00098_A22OrdenID = new short[1] ;
         T00098_A44empdsc = new String[] {""} ;
         T00098_n44empdsc = new bool[] {false} ;
         T00098_A131OrdPrcEst = new String[] {""} ;
         T00098_n131OrdPrcEst = new bool[] {false} ;
         T00098_A1EmpID = new short[1] ;
         T00097_A44empdsc = new String[] {""} ;
         T00097_n44empdsc = new bool[] {false} ;
         T00099_A44empdsc = new String[] {""} ;
         T00099_n44empdsc = new bool[] {false} ;
         T000910_A1EmpID = new short[1] ;
         T000910_A21secuencia = new short[1] ;
         T000910_A22OrdenID = new short[1] ;
         T00096_A21secuencia = new short[1] ;
         T00096_A22OrdenID = new short[1] ;
         T00096_A131OrdPrcEst = new String[] {""} ;
         T00096_n131OrdPrcEst = new bool[] {false} ;
         T00096_A1EmpID = new short[1] ;
         sMode20 = "";
         T000911_A1EmpID = new short[1] ;
         T000911_A21secuencia = new short[1] ;
         T000911_A22OrdenID = new short[1] ;
         T000912_A1EmpID = new short[1] ;
         T000912_A21secuencia = new short[1] ;
         T000912_A22OrdenID = new short[1] ;
         T00095_A21secuencia = new short[1] ;
         T00095_A22OrdenID = new short[1] ;
         T00095_A131OrdPrcEst = new String[] {""} ;
         T00095_n131OrdPrcEst = new bool[] {false} ;
         T00095_A1EmpID = new short[1] ;
         T000916_A44empdsc = new String[] {""} ;
         T000916_n44empdsc = new bool[] {false} ;
         T000917_A1EmpID = new short[1] ;
         T000917_A21secuencia = new short[1] ;
         T000917_A22OrdenID = new short[1] ;
         Z128ProcDsc = "";
         T000918_A1EmpID = new short[1] ;
         T000918_A21secuencia = new short[1] ;
         T000918_A22OrdenID = new short[1] ;
         T000918_A23nro = new short[1] ;
         T000918_A128ProcDsc = new String[] {""} ;
         T000918_n128ProcDsc = new bool[] {false} ;
         T000918_A20ProcID = new short[1] ;
         T00094_A128ProcDsc = new String[] {""} ;
         T00094_n128ProcDsc = new bool[] {false} ;
         T000919_A128ProcDsc = new String[] {""} ;
         T000919_n128ProcDsc = new bool[] {false} ;
         T000920_A1EmpID = new short[1] ;
         T000920_A21secuencia = new short[1] ;
         T000920_A22OrdenID = new short[1] ;
         T000920_A23nro = new short[1] ;
         T00093_A1EmpID = new short[1] ;
         T00093_A21secuencia = new short[1] ;
         T00093_A22OrdenID = new short[1] ;
         T00093_A23nro = new short[1] ;
         T00093_A20ProcID = new short[1] ;
         T00092_A1EmpID = new short[1] ;
         T00092_A21secuencia = new short[1] ;
         T00092_A22OrdenID = new short[1] ;
         T00092_A23nro = new short[1] ;
         T00092_A20ProcID = new short[1] ;
         T000924_A128ProcDsc = new String[] {""} ;
         T000924_n128ProcDsc = new bool[] {false} ;
         T000925_A1EmpID = new short[1] ;
         T000925_A21secuencia = new short[1] ;
         T000925_A22OrdenID = new short[1] ;
         T000925_A23nro = new short[1] ;
         Gridordenprocesos_level1Row = new GXWebRow();
         subGridordenprocesos_level1_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ordenprocesos__default(),
            new Object[][] {
                new Object[] {
               T00092_A1EmpID, T00092_A21secuencia, T00092_A22OrdenID, T00092_A23nro, T00092_A20ProcID
               }
               , new Object[] {
               T00093_A1EmpID, T00093_A21secuencia, T00093_A22OrdenID, T00093_A23nro, T00093_A20ProcID
               }
               , new Object[] {
               T00094_A128ProcDsc, T00094_n128ProcDsc
               }
               , new Object[] {
               T00095_A21secuencia, T00095_A22OrdenID, T00095_A131OrdPrcEst, T00095_n131OrdPrcEst, T00095_A1EmpID
               }
               , new Object[] {
               T00096_A21secuencia, T00096_A22OrdenID, T00096_A131OrdPrcEst, T00096_n131OrdPrcEst, T00096_A1EmpID
               }
               , new Object[] {
               T00097_A44empdsc, T00097_n44empdsc
               }
               , new Object[] {
               T00098_A21secuencia, T00098_A22OrdenID, T00098_A44empdsc, T00098_n44empdsc, T00098_A131OrdPrcEst, T00098_n131OrdPrcEst, T00098_A1EmpID
               }
               , new Object[] {
               T00099_A44empdsc, T00099_n44empdsc
               }
               , new Object[] {
               T000910_A1EmpID, T000910_A21secuencia, T000910_A22OrdenID
               }
               , new Object[] {
               T000911_A1EmpID, T000911_A21secuencia, T000911_A22OrdenID
               }
               , new Object[] {
               T000912_A1EmpID, T000912_A21secuencia, T000912_A22OrdenID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000916_A44empdsc, T000916_n44empdsc
               }
               , new Object[] {
               T000917_A1EmpID, T000917_A21secuencia, T000917_A22OrdenID
               }
               , new Object[] {
               T000918_A1EmpID, T000918_A21secuencia, T000918_A22OrdenID, T000918_A23nro, T000918_A128ProcDsc, T000918_n128ProcDsc, T000918_A20ProcID
               }
               , new Object[] {
               T000919_A128ProcDsc, T000919_n128ProcDsc
               }
               , new Object[] {
               T000920_A1EmpID, T000920_A21secuencia, T000920_A22OrdenID, T000920_A23nro
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000924_A128ProcDsc, T000924_n128ProcDsc
               }
               , new Object[] {
               T000925_A1EmpID, T000925_A21secuencia, T000925_A22OrdenID, T000925_A23nro
               }
            }
         );
      }

      private short nIsMod_21 ;
      private short Z1EmpID ;
      private short Z21secuencia ;
      private short Z22OrdenID ;
      private short nRC_GXsfl_63 ;
      private short nGXsfl_63_idx=1 ;
      private short Z23nro ;
      private short Z20ProcID ;
      private short nRcdDeleted_21 ;
      private short nRcdExists_21 ;
      private short GxWebError ;
      private short A1EmpID ;
      private short A20ProcID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A21secuencia ;
      private short A22OrdenID ;
      private short subGridordenprocesos_level1_Backcolorstyle ;
      private short A23nro ;
      private short subGridordenprocesos_level1_Allowselection ;
      private short subGridordenprocesos_level1_Allowhovering ;
      private short subGridordenprocesos_level1_Allowcollapsing ;
      private short subGridordenprocesos_level1_Collapsed ;
      private short nBlankRcdCount21 ;
      private short RcdFound21 ;
      private short nBlankRcdUsr21 ;
      private short GX_JID ;
      private short RcdFound20 ;
      private short Gx_BScreen ;
      private short subGridordenprocesos_level1_Backstyle ;
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
      private int edtsecuencia_Enabled ;
      private int edtOrdenID_Enabled ;
      private int edtOrdPrcEst_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtnro_Enabled ;
      private int edtProcID_Enabled ;
      private int edtProcDsc_Enabled ;
      private int subGridordenprocesos_level1_Selectedindex ;
      private int subGridordenprocesos_level1_Selectioncolor ;
      private int subGridordenprocesos_level1_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridordenprocesos_level1_Backcolor ;
      private int subGridordenprocesos_level1_Allbackcolor ;
      private int imgprompt_20_Visible ;
      private int defedtnro_Enabled ;
      private int idxLst ;
      private long GRIDORDENPROCESOS_LEVEL1_nFirstRecordOnPage ;
      private String sPrefix ;
      private String sGXsfl_63_idx="0001" ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
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
      private String edtEmpID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String edtsecuencia_Internalname ;
      private String edtsecuencia_Jsonclick ;
      private String edtOrdenID_Internalname ;
      private String edtOrdenID_Jsonclick ;
      private String edtOrdPrcEst_Internalname ;
      private String edtOrdPrcEst_Jsonclick ;
      private String divLevel1table_Internalname ;
      private String lblTitlelevel1_Internalname ;
      private String lblTitlelevel1_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridordenprocesos_level1_Header ;
      private String A128ProcDsc ;
      private String sMode21 ;
      private String edtnro_Internalname ;
      private String edtProcID_Internalname ;
      private String edtProcDsc_Internalname ;
      private String sStyleString ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sMode20 ;
      private String Z128ProcDsc ;
      private String imgprompt_20_Internalname ;
      private String sGXsfl_63_fel_idx="0001" ;
      private String subGridordenprocesos_level1_Class ;
      private String subGridordenprocesos_level1_Linesclass ;
      private String imgprompt_20_Link ;
      private String ROClassString ;
      private String edtnro_Jsonclick ;
      private String edtProcID_Jsonclick ;
      private String edtProcDsc_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridordenprocesos_level1_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_63_Refreshing=false ;
      private bool n44empdsc ;
      private bool n131OrdPrcEst ;
      private bool n128ProcDsc ;
      private String Z131OrdPrcEst ;
      private String A44empdsc ;
      private String A131OrdPrcEst ;
      private String Z44empdsc ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridordenprocesos_level1Container ;
      private GXWebRow Gridordenprocesos_level1Row ;
      private GXWebColumn Gridordenprocesos_level1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00098_A21secuencia ;
      private short[] T00098_A22OrdenID ;
      private String[] T00098_A44empdsc ;
      private bool[] T00098_n44empdsc ;
      private String[] T00098_A131OrdPrcEst ;
      private bool[] T00098_n131OrdPrcEst ;
      private short[] T00098_A1EmpID ;
      private String[] T00097_A44empdsc ;
      private bool[] T00097_n44empdsc ;
      private String[] T00099_A44empdsc ;
      private bool[] T00099_n44empdsc ;
      private short[] T000910_A1EmpID ;
      private short[] T000910_A21secuencia ;
      private short[] T000910_A22OrdenID ;
      private short[] T00096_A21secuencia ;
      private short[] T00096_A22OrdenID ;
      private String[] T00096_A131OrdPrcEst ;
      private bool[] T00096_n131OrdPrcEst ;
      private short[] T00096_A1EmpID ;
      private short[] T000911_A1EmpID ;
      private short[] T000911_A21secuencia ;
      private short[] T000911_A22OrdenID ;
      private short[] T000912_A1EmpID ;
      private short[] T000912_A21secuencia ;
      private short[] T000912_A22OrdenID ;
      private short[] T00095_A21secuencia ;
      private short[] T00095_A22OrdenID ;
      private String[] T00095_A131OrdPrcEst ;
      private bool[] T00095_n131OrdPrcEst ;
      private short[] T00095_A1EmpID ;
      private String[] T000916_A44empdsc ;
      private bool[] T000916_n44empdsc ;
      private short[] T000917_A1EmpID ;
      private short[] T000917_A21secuencia ;
      private short[] T000917_A22OrdenID ;
      private short[] T000918_A1EmpID ;
      private short[] T000918_A21secuencia ;
      private short[] T000918_A22OrdenID ;
      private short[] T000918_A23nro ;
      private String[] T000918_A128ProcDsc ;
      private bool[] T000918_n128ProcDsc ;
      private short[] T000918_A20ProcID ;
      private String[] T00094_A128ProcDsc ;
      private bool[] T00094_n128ProcDsc ;
      private String[] T000919_A128ProcDsc ;
      private bool[] T000919_n128ProcDsc ;
      private short[] T000920_A1EmpID ;
      private short[] T000920_A21secuencia ;
      private short[] T000920_A22OrdenID ;
      private short[] T000920_A23nro ;
      private short[] T00093_A1EmpID ;
      private short[] T00093_A21secuencia ;
      private short[] T00093_A22OrdenID ;
      private short[] T00093_A23nro ;
      private short[] T00093_A20ProcID ;
      private short[] T00092_A1EmpID ;
      private short[] T00092_A21secuencia ;
      private short[] T00092_A22OrdenID ;
      private short[] T00092_A23nro ;
      private short[] T00092_A20ProcID ;
      private String[] T000924_A128ProcDsc ;
      private bool[] T000924_n128ProcDsc ;
      private short[] T000925_A1EmpID ;
      private short[] T000925_A21secuencia ;
      private short[] T000925_A22OrdenID ;
      private short[] T000925_A23nro ;
   }

   public class ordenprocesos__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00098 ;
          prmT00098 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00097 ;
          prmT00097 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00099 ;
          prmT00099 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000910 ;
          prmT000910 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00096 ;
          prmT00096 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000911 ;
          prmT000911 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000912 ;
          prmT000912 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00095 ;
          prmT00095 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000913 ;
          prmT000913 = new Object[] {
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdPrcEst",SqlDbType.VarChar,5,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000914 ;
          prmT000914 = new Object[] {
          new Object[] {"@OrdPrcEst",SqlDbType.VarChar,5,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000915 ;
          prmT000915 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000917 ;
          prmT000917 = new Object[] {
          } ;
          Object[] prmT000918 ;
          prmT000918 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00094 ;
          prmT00094 = new Object[] {
          new Object[] {"@ProcID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000919 ;
          prmT000919 = new Object[] {
          new Object[] {"@ProcID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000920 ;
          prmT000920 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00093 ;
          prmT00093 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00092 ;
          prmT00092 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000921 ;
          prmT000921 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProcID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000922 ;
          prmT000922 = new Object[] {
          new Object[] {"@ProcID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000923 ;
          prmT000923 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nro",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000925 ;
          prmT000925 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@secuencia",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000916 ;
          prmT000916 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000924 ;
          prmT000924 = new Object[] {
          new Object[] {"@ProcID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00092", "SELECT [EmpID], [secuencia], [OrdenID], [nro], [ProcID] FROM [OrdenProcesosLevel1] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [secuencia] = @secuencia AND [OrdenID] = @OrdenID AND [nro] = @nro ",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1,0,true,false )
             ,new CursorDef("T00093", "SELECT [EmpID], [secuencia], [OrdenID], [nro], [ProcID] FROM [OrdenProcesosLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [secuencia] = @secuencia AND [OrdenID] = @OrdenID AND [nro] = @nro ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1,0,true,false )
             ,new CursorDef("T00094", "SELECT [ProcDsc] FROM [Procesos] WITH (NOLOCK) WHERE [ProcID] = @ProcID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,1,0,true,false )
             ,new CursorDef("T00095", "SELECT [secuencia], [OrdenID], [OrdPrcEst], [EmpID] FROM [OrdenProcesos] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [secuencia] = @secuencia AND [OrdenID] = @OrdenID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,1,0,true,false )
             ,new CursorDef("T00096", "SELECT [secuencia], [OrdenID], [OrdPrcEst], [EmpID] FROM [OrdenProcesos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [secuencia] = @secuencia AND [OrdenID] = @OrdenID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,1,0,true,false )
             ,new CursorDef("T00097", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,1,0,true,false )
             ,new CursorDef("T00098", "SELECT TM1.[secuencia], TM1.[OrdenID], T2.[empdsc], TM1.[OrdPrcEst], TM1.[EmpID] FROM ([OrdenProcesos] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) WHERE TM1.[EmpID] = @EmpID and TM1.[secuencia] = @secuencia and TM1.[OrdenID] = @OrdenID ORDER BY TM1.[EmpID], TM1.[secuencia], TM1.[OrdenID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00098,100,0,true,false )
             ,new CursorDef("T00099", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00099,1,0,true,false )
             ,new CursorDef("T000910", "SELECT [EmpID], [secuencia], [OrdenID] FROM [OrdenProcesos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [secuencia] = @secuencia AND [OrdenID] = @OrdenID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000910,1,0,true,false )
             ,new CursorDef("T000911", "SELECT TOP 1 [EmpID], [secuencia], [OrdenID] FROM [OrdenProcesos] WITH (NOLOCK) WHERE ( [EmpID] > @EmpID or [EmpID] = @EmpID and [secuencia] > @secuencia or [secuencia] = @secuencia and [EmpID] = @EmpID and [OrdenID] > @OrdenID) ORDER BY [EmpID], [secuencia], [OrdenID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000911,1,0,true,true )
             ,new CursorDef("T000912", "SELECT TOP 1 [EmpID], [secuencia], [OrdenID] FROM [OrdenProcesos] WITH (NOLOCK) WHERE ( [EmpID] < @EmpID or [EmpID] = @EmpID and [secuencia] < @secuencia or [secuencia] = @secuencia and [EmpID] = @EmpID and [OrdenID] < @OrdenID) ORDER BY [EmpID] DESC, [secuencia] DESC, [OrdenID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000912,1,0,true,true )
             ,new CursorDef("T000913", "INSERT INTO [OrdenProcesos]([secuencia], [OrdenID], [OrdPrcEst], [EmpID]) VALUES(@secuencia, @OrdenID, @OrdPrcEst, @EmpID)", GxErrorMask.GX_NOMASK,prmT000913)
             ,new CursorDef("T000914", "UPDATE [OrdenProcesos] SET [OrdPrcEst]=@OrdPrcEst  WHERE [EmpID] = @EmpID AND [secuencia] = @secuencia AND [OrdenID] = @OrdenID", GxErrorMask.GX_NOMASK,prmT000914)
             ,new CursorDef("T000915", "DELETE FROM [OrdenProcesos]  WHERE [EmpID] = @EmpID AND [secuencia] = @secuencia AND [OrdenID] = @OrdenID", GxErrorMask.GX_NOMASK,prmT000915)
             ,new CursorDef("T000916", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000916,1,0,true,false )
             ,new CursorDef("T000917", "SELECT [EmpID], [secuencia], [OrdenID] FROM [OrdenProcesos] WITH (NOLOCK) ORDER BY [EmpID], [secuencia], [OrdenID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000917,100,0,true,false )
             ,new CursorDef("T000918", "SELECT T1.[EmpID], T1.[secuencia], T1.[OrdenID], T1.[nro], T2.[ProcDsc], T1.[ProcID] FROM ([OrdenProcesosLevel1] T1 WITH (NOLOCK) INNER JOIN [Procesos] T2 WITH (NOLOCK) ON T2.[ProcID] = T1.[ProcID]) WHERE T1.[EmpID] = @EmpID and T1.[secuencia] = @secuencia and T1.[OrdenID] = @OrdenID and T1.[nro] = @nro ORDER BY T1.[EmpID], T1.[secuencia], T1.[OrdenID], T1.[nro] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000918,11,0,true,false )
             ,new CursorDef("T000919", "SELECT [ProcDsc] FROM [Procesos] WITH (NOLOCK) WHERE [ProcID] = @ProcID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000919,1,0,true,false )
             ,new CursorDef("T000920", "SELECT [EmpID], [secuencia], [OrdenID], [nro] FROM [OrdenProcesosLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [secuencia] = @secuencia AND [OrdenID] = @OrdenID AND [nro] = @nro ",true, GxErrorMask.GX_NOMASK, false, this,prmT000920,1,0,true,false )
             ,new CursorDef("T000921", "INSERT INTO [OrdenProcesosLevel1]([EmpID], [secuencia], [OrdenID], [nro], [ProcID]) VALUES(@EmpID, @secuencia, @OrdenID, @nro, @ProcID)", GxErrorMask.GX_NOMASK,prmT000921)
             ,new CursorDef("T000922", "UPDATE [OrdenProcesosLevel1] SET [ProcID]=@ProcID  WHERE [EmpID] = @EmpID AND [secuencia] = @secuencia AND [OrdenID] = @OrdenID AND [nro] = @nro", GxErrorMask.GX_NOMASK,prmT000922)
             ,new CursorDef("T000923", "DELETE FROM [OrdenProcesosLevel1]  WHERE [EmpID] = @EmpID AND [secuencia] = @secuencia AND [OrdenID] = @OrdenID AND [nro] = @nro", GxErrorMask.GX_NOMASK,prmT000923)
             ,new CursorDef("T000924", "SELECT [ProcDsc] FROM [Procesos] WITH (NOLOCK) WHERE [ProcID] = @ProcID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000924,1,0,true,false )
             ,new CursorDef("T000925", "SELECT [EmpID], [secuencia], [OrdenID], [nro] FROM [OrdenProcesosLevel1] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [secuencia] = @secuencia and [OrdenID] = @OrdenID ORDER BY [EmpID], [secuencia], [OrdenID], [nro] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000925,11,0,true,false )
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
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 23 :
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
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 11 :
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
                stmt.SetParameter(4, (short)parms[4]);
                return;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
